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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x684C020", Offset = "0x684B020", VA = "0x18684C020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[LEDNJNPECJC]
internal class CCPPCIFHPFN : OFOLBJMNMGE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct DJJKCPOMLEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CCPPCIFHPFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public PKLKNBHIDDA avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AKKACFAHBDE BDNFHNNAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HDIFBPINGMN KCJJKMDLFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OCPEHBFLGHI NEGLDOLAIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LJBINCFCALP EIJFBMHEBJP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68353A0", Offset = "0x68343A0", VA = "0x1868353A0")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void ELKKFCJLAAD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6836D30", Offset = "0x6835D30", VA = "0x186836D30")]
	[Preserve]
	internal CCPPCIFHPFN([JFHFHOOOEKP(null)] AKKACFAHBDE BDNFHNNAIIE, [JFHFHOOOEKP(null)] HDIFBPINGMN KCJJKMDLFAB, [JFHFHOOOEKP(null)] OCPEHBFLGHI NEGLDOLAIHM, [JFHFHOOOEKP(null)] LJBINCFCALP EIJFBMHEBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68355C0", Offset = "0x68345C0", VA = "0x1868355C0", Slot = "5")]
	public DGKNAIDPAJD JOANFAHKPIG(bool EJIBDDGFJJE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68362E0", Offset = "0x68352E0", VA = "0x1868362E0", Slot = "4")]
	public DGKNAIDPAJD PHHPNIEEMCO(bool EJIBDDGFJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6835D80", Offset = "0x6834D80", VA = "0x186835D80", Slot = "6")]
	public GAJOGHLFFIO JOJKNMCGGEG(DGKNAIDPAJD FHNKDHIILBL, int PELKODHFFGF, string? LCLKDNPLMED, string? AHGIJDBMKEJ, GOCILOCPHNM HBGFNCNPMFK, List<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6836CA0", Offset = "0x6835CA0", VA = "0x186836CA0", Slot = "7")]
	public bool PKKECHAPOAC(OJNLLGMGBIP GGBAOPBACDD, [Out] DGKNAIDPAJD? BMIPHJFPOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6835E90", Offset = "0x6834E90", VA = "0x186835E90", Slot = "8")]
	public bool LNFFPJPACFN(GAJOGHLFFIO EPFDCONIBPD, [Out] DGKNAIDPAJD? BMIPHJFPOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6836250", Offset = "0x6835250", VA = "0x186836250", Slot = "9")]
	public bool PBNPAOCJINC(GAJOGHLFFIO EPFDCONIBPD, [Out] ALHKOGGDKHM? GGBAOPBACDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2927660", Offset = "0x2926660", VA = "0x182927660")]
	private bool DOGJEPGJOGH<TInput, TOutput>(TInput CPEKGDIIDKL, PGLHILCHENG<TInput, TOutput> KIFAJGMPCFF, [Out] TOutput? HJBJAPKPPFA) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6835410", Offset = "0x6834410", VA = "0x186835410")]
	[CompilerGenerated]
	private ACIKNKLFGHF JGLBGBNMKNB(FaceFeatureType CDPIIJCPHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6835F70", Offset = "0x6834F70", VA = "0x186835F70")]
	[CompilerGenerated]
	private ACIKNKLFGHF PAKIDPFPJEK(FaceFeatureType CDPIIJCPHBI, DJJKCPOMLEG P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[LEDNJNPECJC]
internal class LFIONFHIPEB : AKKACFAHBDE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void OJBHNGGIHNG<in TData>(TData BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OCPEHBFLGHI NEGLDOLAIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly DNHLKDIIFLB BNNGHMOAPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OJBHNGGIHNG<DGKNAIDPAJD>?[] BDNFHNNAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OJBHNGGIHNG<ALHKOGGDKHM>?[] HPAACPANGNA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x684AD70", Offset = "0x6849D70", VA = "0x18684AD70")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void ELKKFCJLAAD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x684BCF0", Offset = "0x684ACF0", VA = "0x18684BCF0")]
	[Preserve]
	internal LFIONFHIPEB([JFHFHOOOEKP(null)] OCPEHBFLGHI NEGLDOLAIHM, [JFHFHOOOEKP(null)] DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x684BBC0", Offset = "0x684ABC0", VA = "0x18684BBC0", Slot = "4")]
	public bool KANCLJPDGPI(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x684BA60", Offset = "0x684AA60", VA = "0x18684BA60", Slot = "5")]
	public bool KANCLJPDGPI(ALHKOGGDKHM GGBAOPBACDD, IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x684ADE0", Offset = "0x6849DE0", VA = "0x18684ADE0")]
	private void HDPCCFKOGNF(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? JLMICGLMAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x684B830", Offset = "0x684A830", VA = "0x18684B830")]
	private void IPECEJFLMPH(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? JLMICGLMAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x684BCC0", Offset = "0x684ACC0", VA = "0x18684BCC0")]
	private void OOIGNJGAEMM(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? JLMICGLMAKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AKKACFAHBDE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KANCLJPDGPI(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KANCLJPDGPI(ALHKOGGDKHM GGBAOPBACDD, IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);
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
		public FLNAILNJOEP AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x68302D0", Offset = "0x682F2D0", VA = "0x1868302D0")]
		public void DJCEJHEJNEH(AnimationPoseSetting LJAAPFIIPOF, float NENJONGBLIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6830400", Offset = "0x682F400", VA = "0x186830400")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, CMPPBAAMJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
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
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
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
		private Vector3? JLCFFFLFNNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool LCHNCOECOIP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6830420", Offset = "0x682F420", VA = "0x186830420", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6830A20", Offset = "0x682FA20", VA = "0x186830A20", Slot = "4")]
		public void UpdateController(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE845E0", Offset = "0xE835E0", VA = "0x180E845E0", Slot = "6")]
		public void SetEnabled(bool CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68304C0", Offset = "0x682F4C0", VA = "0x1868304C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6830E40", Offset = "0x682FE40", VA = "0x186830E40")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, CMPPBAAMJMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float NEBIPIOFAHP = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
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
		private Vector3 MLJIIOHOBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 FFPKJBLELDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool LCHNCOECOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float PNBLCKFODKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float IIGOFPGJPLK;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x68311C0", Offset = "0x68301C0", VA = "0x1868311C0", Slot = "4")]
		public void UpdateController(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB77630", Offset = "0xB76630", VA = "0x180B77630", Slot = "6")]
		public void SetEnabled(bool CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6830EE0", Offset = "0x682FEE0", VA = "0x186830EE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6831C80", Offset = "0x6830C80", VA = "0x186831C80")]
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
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
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
		[Cpp2IlInjected.Address(RVA = "0x68325A0", Offset = "0x68315A0", VA = "0x1868325A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6832560", Offset = "0x6831560", VA = "0x186832560")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6831CB0", Offset = "0x6830CB0", VA = "0x186831CB0")]
		private void DNBKJLMCCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67FAE30", Offset = "0x67F9E30", VA = "0x1867FAE30", Slot = "4")]
		public void SetEnabled(bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68325D0", Offset = "0x68315D0", VA = "0x1868325D0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarForearmRollController : MonoBehaviour, CMPPBAAMJMA
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
		private float PNBLCKFODKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool LCHNCOECOIP;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6832610", Offset = "0x6831610", VA = "0x186832610", Slot = "4")]
		public void UpdateController(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDD9700", Offset = "0xDD8700", VA = "0x180DD9700", Slot = "6")]
		public void SetEnabled(bool CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68330A0", Offset = "0x68320A0", VA = "0x1868330A0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, JOONONOGMAB
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
		[AIILLFBIOKD(CKKEEFADMDD.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		[Header("Configuration")]
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
		private HDMELEDKJMC GIGGDCJADKL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HDMELEDKJMC NFLNNGFDILP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6833E60", Offset = "0x6832E60", VA = "0x186833E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform LIAGDHCHNHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6833EA0", Offset = "0x6832EA0", VA = "0x186833EA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68330D0", Offset = "0x68320D0", VA = "0x1868330D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6833D20", Offset = "0x6832D20", VA = "0x186833D20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6833CD0", Offset = "0x6832CD0", VA = "0x186833CD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6833C60", Offset = "0x6832C60", VA = "0x186833C60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6833B50", Offset = "0x6832B50", VA = "0x186833B50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6833C60", Offset = "0x6832C60", VA = "0x186833C60", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6833150", Offset = "0x6832150", VA = "0x186833150", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6833D70", Offset = "0x6832D70", VA = "0x186833D70", Slot = "8")]
		public void UpdatePostIKAnimControllers(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6833BD0", Offset = "0x6832BD0", VA = "0x186833BD0")]
		private void JJDCJANPBPN(GameObject HBFCGFKGCAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6833480", Offset = "0x6832480", VA = "0x186833480")]
		private HDMELEDKJMC IKIIFONHLOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
		public AvatarFullBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("The number of seconds it takes for a turn.")]
		[Header("Turning")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Header("Hand Animation")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x331")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6833EC0", Offset = "0x6832EC0", VA = "0x186833EC0")]
		public AnimationPoseSetting PLACCHGKIDH(FLNAILNJOEP KHOPIOAGPIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6833EF0", Offset = "0x6832EF0", VA = "0x186833EF0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GIIBCNNAPEA : KEOJJFEMGHE
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static int HLGGEHKALDJ;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int PKFLKFGEFML;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int PIGDPDHBHCH;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int HIJIMDIJBGN;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static int AJIGIMIGLGJ;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static int GOAIFAJCPNM;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static int NCLCHGAGDPL;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int CAHNJABHDFJ;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int PMKJFIFPCNH;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static int[] PGLDMJDIEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	internal bool DGOJIMFPLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private CPGPGEHMHOJ HLPIAFCOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private int MEHJNKPMDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private float HKGCJIPLCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool BOKNEIONIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Animator LOEJJGILMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AvatarFullBodyConfiguration OPJPFPDKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int DGBAFJKDBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int EDMIJCBLOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int PJIGLJIHHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool PMOBNGLIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private JAEBJFMEEKJ JPOJLILPCFH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform GPHINIAIMDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 HKDIMJHLGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xDE7C70", Offset = "0xDE6C70", VA = "0x180DE7C70")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDE7C60", Offset = "0xDE6C60", VA = "0x180DE7C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion KDIDNBEJFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1BBF140", Offset = "0x1BBE140", VA = "0x181BBF140")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E0E0", Offset = "0x1F3D0E0", VA = "0x181F3E0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 AIHJNKNHHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4557FC0", Offset = "0x4556FC0", VA = "0x184557FC0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4554940", Offset = "0x4553940", VA = "0x184554940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Quaternion JMBIPPKNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x10CF990", Offset = "0x10CE990", VA = "0x1810CF990", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x385C590", Offset = "0x385B590", VA = "0x18385C590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NNNBHLGDPFP NLGHGKCNDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86B3F0", Offset = "0x86A3F0", VA = "0x18086B3F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(NNNBHLGDPFP);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86B410", Offset = "0x86A410", VA = "0x18086B410", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NNNBHLGDPFP PKHALDCAAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3540", Offset = "0x1AC2540", VA = "0x181AC3540", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(NNNBHLGDPFP);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3550", Offset = "0x1AC2550", VA = "0x181AC3550", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MPGJIBPMNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1D69A40", Offset = "0x1D68A40", VA = "0x181D69A40", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1D6A110", Offset = "0x1D69110", VA = "0x181D6A110", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DLHFGOFLIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x684AA20", Offset = "0x6849A20", VA = "0x18684AA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ACBMMCJNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x684A690", Offset = "0x6849690", VA = "0x18684A690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JHDIGKBFMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x684A350", Offset = "0x6849350", VA = "0x18684A350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x684A170", Offset = "0x6849170", VA = "0x18684A170", Slot = "21")]
	public void BGGINNGCCML(CPGPGEHMHOJ ONHKIOMDBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x684AA30", Offset = "0x6849A30", VA = "0x18684AA30", Slot = "22")]
	public void PNCHDOGCJEH(CBMPKJMGNCL GLPJLLPJKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x684A7E0", Offset = "0x68497E0", VA = "0x18684A7E0", Slot = "11")]
	public void HNACMKLCEEB(bool OHFAELGDCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x684A360", Offset = "0x6849360", VA = "0x18684A360", Slot = "10")]
	public void GBFAMFOABCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x684A8A0", Offset = "0x68498A0", VA = "0x18684A8A0")]
	private int KMPHIPCLCIA(NNNBHLGDPFP FGEAEFHPDPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x684A6B0", Offset = "0x68496B0", VA = "0x18684A6B0")]
	private void HAFACLLLJAB(int MJKCLKCGEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x684A330", Offset = "0x6849330", VA = "0x18684A330", Slot = "12")]
	public bool BKHHHGINHCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x684A870", Offset = "0x6849870", VA = "0x18684A870", Slot = "13")]
	public bool HPPFPPNGNKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x684A120", Offset = "0x6849120", VA = "0x18684A120")]
	private NNNBHLGDPFP AIONKPBGGHA()
	{
		return default(NNNBHLGDPFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xF09030", Offset = "0xF08030", VA = "0x180F09030", Slot = "14")]
	public void LMEFCIABOAJ(bool OHFAELGDCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x684A6A0", Offset = "0x68496A0", VA = "0x18684A6A0", Slot = "9")]
	public void GLLCBEHKPKI(int MJKCLKCGEIP, float MDOIIPJHJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x684A880", Offset = "0x6849880", VA = "0x18684A880", Slot = "7")]
	public void JFALIGGKHCF(JAEBJFMEEKJ NGHALOPECFO, bool GMNLPDCHGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x684A340", Offset = "0x6849340", VA = "0x18684A340", Slot = "8")]
	public void DJPOLEEMPJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x684A640", Offset = "0x6849640", VA = "0x18684A640", Slot = "15")]
	public void GDEJOKOKFGP(Transform HHMPHBNGMGF, Vector3 KCKFECPEICH, Quaternion JPAKCFIICPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x684AD60", Offset = "0x6849D60", VA = "0x18684AD60")]
	public GIIBCNNAPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class CLIFKGDLKCL : HDMELEDKJMC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class PINPBFDHGNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float OPLNJBAKJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Vector3 HKNIBOPPEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float BHLKGMLNJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool DLIEGEADGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AnimationPoseSetting HLJHDDDPALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float PFJPCACBHBM;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x684C260", Offset = "0x684B260", VA = "0x18684C260")]
		public void ENIFIPPFMGI(IKSolverVR.Arm PFJMIOJFJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x684D230", Offset = "0x684C230", VA = "0x18684D230")]
		public void NEFDBEDAHDK(IKSolverVR.Arm PFJMIOJFJCH, Transform IFJIKCHJIFG, bool CBJKBGHDHCK, AvatarFullBodyConfiguration FFADDNJMIIP, float AOIPNCIAIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x684C0A0", Offset = "0x684B0A0", VA = "0x18684C0A0")]
		public void AFINELOKEJO(IKSolverVR.Arm PFJMIOJFJCH, float FJGCJGDDNJE, bool DLIEGEADGNJ, AvatarFullBodyConfiguration FFADDNJMIIP, float AOIPNCIAIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x684D4C0", Offset = "0x684C4C0", VA = "0x18684D4C0")]
		private void NPMEADKBBIK(Transform IFJIKCHJIFG, IKSolverVR.Arm PFJMIOJFJCH, float KHIPOIDNJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x684D420", Offset = "0x684C420", VA = "0x18684D420")]
		private void NNCHMHGFPKF(bool CBJKBGHDHCK, AvatarFullBodyConfiguration FFADDNJMIIP, float AOIPNCIAIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x684C220", Offset = "0x684B220", VA = "0x18684C220")]
		private void EFADGFCDKOE(IKSolverVR.Arm PFJMIOJFJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x684C3E0", Offset = "0x684B3E0", VA = "0x18684C3E0")]
		public void HCJMINLPHED(IKSolverVR.Arm PFJMIOJFJCH, Transform OMNBACONICF, Transform PKNLKFCCKOF, Quaternion BLDOJMLPCEO, Vector3 IOGKFELDEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x684D5B0", Offset = "0x684C5B0", VA = "0x18684D5B0")]
		private (Vector3, Quaternion) PHEKDBFKFMB(GIIBCNNAPEA OEBENPNMDBG, Quaternion JCCPLLNKMFM, Vector3 BDGIIINNKPL)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x684C290", Offset = "0x684B290", VA = "0x18684C290")]
		public void FINNBLNMBNN(GIIBCNNAPEA OEBENPNMDBG, IKSolverVR.Arm PFJMIOJFJCH, Quaternion JCCPLLNKMFM, Vector3 BDGIIINNKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x684C7C0", Offset = "0x684B7C0", VA = "0x18684C7C0")]
		public void HOJJGBGFJCC(GIIBCNNAPEA OEBENPNMDBG, IKSolverVR.Arm PFJMIOJFJCH, Quaternion JCCPLLNKMFM, Vector3 BDGIIINNKPL, [In] AvatarFullBodyConfiguration FFADDNJMIIP, [In] AILLONLIOPL NGHALOPECFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x684C0E0", Offset = "0x684B0E0", VA = "0x18684C0E0")]
		public void ECOBPJGJLNJ(FLNAILNJOEP KGACENBDLHB, AvatarFullBodyConfiguration FFADDNJMIIP, AILLONLIOPL NGHALOPECFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x684CDB0", Offset = "0x684BDB0", VA = "0x18684CDB0")]
		public void IMIBJGFIDGD(IKSolverVR.Arm PFJMIOJFJCH, Transform OMNBACONICF, Vector3 FDLNFOLDHLB, float EMPIBEEEFOP, Quaternion BAJBLBPFPNF, Vector3 JFHJMGKJFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x684DA40", Offset = "0x684CA40", VA = "0x18684DA40")]
		public PINPBFDHGNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private enum IDCGBCKGBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum MKJGPPHPMCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int APPPKIOLDNG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int PNAIOFJILFJ;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int OCEBLKHIEBO;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int JPIFJAHGOFE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int AMKLFMOCBAN;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int FHEBEFEGGNM;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int KNGKHOBICBH;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int PBJLFPOELEP;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int FPJLODDIOJH;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int DGFBJKKNIIK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int DMDIHIMIAKE;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int HAIHINFGJHI;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int AJCOCNMLLPA;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int CBJEPIBDJNM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int IAGHBOMIHKG;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int LCMPPMBDOLI;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int KFABKBDABKE;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int IJMKJICFANK;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int NDKIMNLNKHP;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int BHEDDGLILAC;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int DDIADDBEGEA;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int FJIHMGHPJAP;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int EMJJJHOKECI;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int GCALLHGPCAC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int KAAEJJHNLCG;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int AKDKKPOGHCC;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int NKCDBKPAHIN;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int GHFLMAKPNOM;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int BEEJAEHIOIP;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly int DCCEOGGOBMC;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int HKBGAGFBBDM;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly Vector3 DPOHECPBGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool FJKAGJIBFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool HLAMMLPDMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private bool BLAJJPFLGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool HFLDGPIBJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool HFGKLLLLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Vector3 JLNLFPINMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private KBANNBMGJGE? HLPIAFCOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private CEGDCKHDECC? NFLIDGGOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private OBBNDEFFAJC POLMHPGDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private GKEHDNDBNEP JMFHDPLHEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private GIIBCNNAPEA PCADGFAPKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private GIIBCNNAPEA FELMHGCCLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private bool DDAKBKPELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private bool MHCEPFOPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly DOEOAOEMHHF IGJJFNPMIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly FGMICPHPGIN NIBNBHHONJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int CHFFKJEANBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private float MGGDKLCMDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private GameObject GOPBEGEFOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Transform ILIFOJLCAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Transform HMLHBDKNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float ODMHMPJANLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float BFKKOHEGMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private Vector3 MKIFGNFCAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private Quaternion DEOFFNKDGBO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly ProfilerMarker DKOGONAEJNL;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly ProfilerMarker HPMNPFKKHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private ProfilerMarker FKCAKJKFNMC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly ProfilerMarker KDLOHKOABKC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly ProfilerMarker JJMCCKLHBCB;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly ProfilerMarker PFPKDEDDCJI;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly List<CLIFKGDLKCL> EHMPFNFAMDE;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int HCEICCNCKBF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> GKEFNFDLJMJ;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static int OOFGACJIAID;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int GJLOJKEGPFE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int BFKPCDCMIAD;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int NECACDNKKLN;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static float GINIMEBBMFM;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static int ODFFJJIBCAL;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static float CIDFFICPMIC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static float NIHLDGKGBGD;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static float BOPNOMJLJNM;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static float APBFOHDHBJA;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static DCMCMMLEHNC HBAFDLFPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private float HKGIAMOLELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private bool AKEACJPKAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float KPMFDKBHMAD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly Quaternion IGJHBFCBJMC;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion COKCPFCJMII;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Vector3 NCBLJIEGPAB;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 MHFCGCEOPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private PINPBFDHGNP IFNLHMOIPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private PINPBFDHGNP GNECLAHBGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private FLLPGFNEMKD OKNEOOFDHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private BEFAAFONJJI HFFMKCFAPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private IDCGBCKGBFJ PNOCOMIOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private float PMFJPDICHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly PDHJEBCHLDG OMPODAGHCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float HDLLMJCPBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float FENDKMBAPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private Vector3 ADCEKPOLBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly BEFAAFONJJI NJNHEGAOADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly GHBCENONNHL BEJAJCONCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private float DLCKFEEMKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private IDCGBCKGBFJ AEINOFLLBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private Vector3 KIJDADDJPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private float CJACFKIEANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private float DCFFOKDCNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly BEFAAFONJJI ANBMMADCLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly FLLPGFNEMKD FLPFHIKGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly BEFAAFONJJI EAGDPPAJMOF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BGECMLEGDCD MGAFGHMOJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BGECMLEGDCD DBFGHKFBGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration LEEEOGFHBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x683AEF0", Offset = "0x6839EF0", VA = "0x18683AEF0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AvatarFullBodyConfiguration OKIOHEAHFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68467E0", Offset = "0x68457E0", VA = "0x1868467E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Transform LKDKGPNBLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68482A0", Offset = "0x68472A0", VA = "0x1868482A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform LEOMHIJIBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x683AA90", Offset = "0x6839A90", VA = "0x18683AA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private SkinnedMeshRenderer JPCPFIGHCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68477D0", Offset = "0x68467D0", VA = "0x1868477D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Renderer[] HJJGJIEHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x683EC80", Offset = "0x683DC80", VA = "0x18683EC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private GameObject[] DDLAPKNCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x683B740", Offset = "0x683A740", VA = "0x18683B740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private Animator OBKCMGFICNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6837030", Offset = "0x6836030", VA = "0x186837030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private VRIK GAAMGBLHHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x683FE10", Offset = "0x683EE10", VA = "0x18683FE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private CMPPBAAMJMA AKMLHJOAKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6846700", Offset = "0x6845700", VA = "0x186846700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private CMPPBAAMJMA KIDENPLCELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68451E0", Offset = "0x68441E0", VA = "0x1868451E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private CMPPBAAMJMA BLGJKFNDKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x683FAB0", Offset = "0x683EAB0", VA = "0x18683FAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private CMPPBAAMJMA JDMDFIJLAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x683BFB0", Offset = "0x683AFB0", VA = "0x18683BFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private CMPPBAAMJMA IACKLJGCCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6836F20", Offset = "0x6835F20", VA = "0x186836F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private CMPPBAAMJMA DPHJGGACDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6841700", Offset = "0x6840700", VA = "0x186841700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private CMPPBAAMJMA PCBNLCLFBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68382E0", Offset = "0x68372E0", VA = "0x1868382E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private CMPPBAAMJMA OACFLDPILIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x683F8C0", Offset = "0x683E8C0", VA = "0x18683F8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CEGDCKHDECC GILAOJOBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6837AC0", Offset = "0x6836AC0", VA = "0x186837AC0", Slot = "33")]
		get
		{
			return default(CEGDCKHDECC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IIPFAIHICNK FJBMJAMFDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D1110", Offset = "0x8D0110", VA = "0x1808D1110", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public KFANBJCCOLL HOJDIEPCEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB098D0", Offset = "0xB088D0", VA = "0x180B098D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public KEOJJFEMGHE NMANJOKKMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB098F0", Offset = "0xB088F0", VA = "0x180B098F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public KEOJJFEMGHE IKOOOIOFKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB07DD0", Offset = "0xB06DD0", VA = "0x180B07DD0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private Transform BPMBMGDILFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x683B820", Offset = "0x683A820", VA = "0x18683B820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public GameObject INALOLPJOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6838640", Offset = "0x6837640", VA = "0x186838640", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform CCBHEDIMNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x13E50E0", Offset = "0x13E40E0", VA = "0x1813E50E0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform MMOBACPCDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1102870", Offset = "0x1101870", VA = "0x181102870", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Vector3 MCIPHIILBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6838CA0", Offset = "0x6837CA0", VA = "0x186838CA0", Slot = "30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float MDNCNCNIOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6837110", Offset = "0x6836110", VA = "0x186837110", Slot = "31")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Transform AIKPGIKIEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6847900", Offset = "0x6846900", VA = "0x186847900", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private bool ECCKGDBIBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6848240", Offset = "0x6847240", VA = "0x186848240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool IMIDJDDMEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x683ED60", Offset = "0x683DD60", VA = "0x18683ED60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6838CE0", Offset = "0x6837CE0", VA = "0x186838CE0")]
	private void EFFMKHFIMAL([In] AILLONLIOPL KJFHCCMMCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6837A10", Offset = "0x6836A10", VA = "0x186837A10")]
	private void BGCEHOPDLGN(AILLONLIOPL KJFHCCMMCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x683B510", Offset = "0x683A510", VA = "0x18683B510")]
	private void GBFAMFOABCH(NHNAPMDMKLL PBOHHLCAFNM, KEOJJFEMGHE DNEFBOPBALB, IKSolverVR.Arm PFJMIOJFJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6844D60", Offset = "0x6843D60", VA = "0x186844D60")]
	private void MKBFOHJDEJC([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x68498A0", Offset = "0x68488A0", VA = "0x1868498A0")]
	public CLIFKGDLKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x683D8C0", Offset = "0x683C8C0", VA = "0x18683D8C0", Slot = "12")]
	public void HKOFMDOIPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x683E370", Offset = "0x683D370", VA = "0x18683E370", Slot = "13")]
	public void ICCFEIPIENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6841630", Offset = "0x6840630", VA = "0x186841630", Slot = "14")]
	public void LJGLCFICHIP(bool DEOFCJPMPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6837CA0", Offset = "0x6836CA0", VA = "0x186837CA0", Slot = "22")]
	public Transform CGEFPHHPDED(string GGIILCEGNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6843A00", Offset = "0x6842A00", VA = "0x186843A00", Slot = "23")]
	public Vector3? MAIIPBOOMJB(string GGIILCEGNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6845E50", Offset = "0x6844E50", VA = "0x186845E50", Slot = "7")]
	public void NDFGILDEPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6846870", Offset = "0x6845870", VA = "0x186846870", Slot = "6")]
	public void OHOCMLGJCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x683FDA0", Offset = "0x683EDA0", VA = "0x18683FDA0", Slot = "8")]
	public void KBHAFJDGNNG(float DAFIFBHNPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68478B0", Offset = "0x68468B0", VA = "0x1868478B0")]
	private void OOJJFJOIIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x68424D0", Offset = "0x68414D0", VA = "0x1868424D0", Slot = "4")]
	public void LPOICOKCJJL(KBANNBMGJGE JEBLLDKLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6842100", Offset = "0x6841100", VA = "0x186842100", Slot = "5")]
	public void LPNNNPNPPJO(CEGDCKHDECC GLPJLLPJKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x683AFD0", Offset = "0x6839FD0", VA = "0x18683AFD0", Slot = "11")]
	public void FKPIGLMGCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6846360", Offset = "0x6845360", VA = "0x186846360", Slot = "21")]
	public void NMPKDNKBEMP([Out] Vector3 IHDDHDBEHPJ, [Out] Quaternion BAJBLBPFPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x683AA60", Offset = "0x6839A60", VA = "0x18683AA60")]
	private void FCCCHEDLOID([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x683B6C0", Offset = "0x683A6C0", VA = "0x18683B6C0", Slot = "24")]
	public void GCBMAJKFOJO(float NKJDAOJLGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x683BA10", Offset = "0x683AA10", VA = "0x18683BA10", Slot = "25")]
	public void HAFPLCLCLOM(float OIADPFNJLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6837BF0", Offset = "0x6836BF0", VA = "0x186837BF0", Slot = "26")]
	public HandLogicOffsets CFIHGLLKAND()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x683B3D0", Offset = "0x683A3D0", VA = "0x18683B3D0", Slot = "27")]
	public PlatformSpecificPlayerHandOffsets FNGKAFKNOIJ()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x683B950", Offset = "0x683A950", VA = "0x18683B950")]
	private void GOJKEFHIOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x683DE10", Offset = "0x683CE10", VA = "0x18683DE10")]
	private void HPFOHLIFHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6843CE0", Offset = "0x6842CE0", VA = "0x186843CE0")]
	private void MDKFFIDANLC(GMBPJONDGEK CHLNKNCOHNB, bool FFPHPJEJBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x683A8D0", Offset = "0x68398D0", VA = "0x18683A8D0")]
	private void ENLJAAGMBLK(GMBPJONDGEK CHLNKNCOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x68420B0", Offset = "0x68410B0", VA = "0x1868420B0")]
	public Vector3 LNPBCIIHPNI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x683DDA0", Offset = "0x683CDA0", VA = "0x18683DDA0")]
	private void HPEDPEEHJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x683AD20", Offset = "0x6839D20", VA = "0x18683AD20")]
	private void FGCBFPPFBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x683F8A0", Offset = "0x683E8A0", VA = "0x18683F8A0")]
	private void IOFBDAHBIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6837140", Offset = "0x6836140", VA = "0x186837140")]
	private float BDPGCKKDCEB([In] AILLONLIOPL NGHALOPECFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6838200", Offset = "0x6837200", VA = "0x186838200")]
	private int DAAIBNELJKP([In] HNHGIGGCOEK LLBOGOPOIBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6843E50", Offset = "0x6842E50", VA = "0x186843E50")]
	private void MGGAAPJMGIL(AILLONLIOPL KJFHCCMMCDL, bool DHFMFLIMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x683A6A0", Offset = "0x68396A0", VA = "0x18683A6A0")]
	private static void ENLIMPJNCME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x68452C0", Offset = "0x68442C0", VA = "0x1868452C0")]
	private static void NCBFENOAHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x683E220", Offset = "0x683D220", VA = "0x18683E220")]
	private float IAPHHFDIPHF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6837000", Offset = "0x6836000", VA = "0x186837000")]
	private static int AFFJMLLCHLG(CLIFKGDLKCL KKEPMPAJLEA, CLIFKGDLKCL HIEMMBKCCDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x683C090", Offset = "0x683B090", VA = "0x18683C090")]
	private void HFMOOBBGCCK(AILLONLIOPL NGHALOPECFO, AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x683B900", Offset = "0x683A900", VA = "0x18683B900")]
	private float GKDGOPJJHDI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6840AD0", Offset = "0x683FAD0", VA = "0x186840AD0")]
	private void KNDKHDKJNJK([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x683BCE0", Offset = "0x683ACE0", VA = "0x18683BCE0")]
	private void HCJMINLPHED([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x68386E0", Offset = "0x68376E0", VA = "0x1868386E0")]
	private void DFJNAENAMNH([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x683FB90", Offset = "0x683EB90", VA = "0x18683FB90")]
	private void JLCFOHDKMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x683F9A0", Offset = "0x683E9A0", VA = "0x18683F9A0")]
	private void JBJKAEGPGGC([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x683FEF0", Offset = "0x683EEF0", VA = "0x18683FEF0")]
	private void KFHCPJBNEOB(GIIBCNNAPEA DNEFBOPBALB, IKSolverVR.Arm PFJMIOJFJCH, Transform FGNPBJHMCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x683B490", Offset = "0x683A490", VA = "0x18683B490")]
	private float FPBPHEHMPNN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x683E660", Offset = "0x683D660", VA = "0x18683E660")]
	private void IDPIEEHIAAB([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x683B0C0", Offset = "0x683A0C0", VA = "0x18683B0C0", Slot = "34")]
	protected virtual void FMFFGMGNPDD([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x683CD60", Offset = "0x683BD60", VA = "0x18683CD60")]
	private void HGPMIDDLJOD([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x68383C0", Offset = "0x68373C0", VA = "0x1868383C0")]
	protected void DCAAJEPECGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x68404B0", Offset = "0x683F4B0", VA = "0x1868404B0")]
	private void KJIHBFHBADD([In] AILLONLIOPL NGHALOPECFO, [In] MKJGPPHPMCI EPHCOJEEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6844A10", Offset = "0x6843A10", VA = "0x186844A10")]
	private void MJPDBEDLCAE(AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6848E60", Offset = "0x6847E60", VA = "0x186848E60")]
	private void PPGMHFKECAI(IDCGBCKGBFJ ICDFCJEPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x683F680", Offset = "0x683E680", VA = "0x18683F680")]
	private void IOAFJMFMIFJ(float DMJHHOKIICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6848710", Offset = "0x6847710", VA = "0x186848710")]
	private void PPFNMGHDKME([In] AILLONLIOPL NGHALOPECFO, MKJGPPHPMCI EPHCOJEEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x683CFC0", Offset = "0x683BFC0", VA = "0x18683CFC0")]
	private Vector3 HGPNNPJLMOD([In] AILLONLIOPL NGHALOPECFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x683DCD0", Offset = "0x683CCD0", VA = "0x18683DCD0")]
	private void HNCFEHLLMKK([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x683A1A0", Offset = "0x68391A0", VA = "0x18683A1A0")]
	private float EHOCHPAKBJC(float LDFACAKBPNJ, [In] AILLONLIOPL NGHALOPECFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x68449F0", Offset = "0x68439F0", VA = "0x1868449F0")]
	private void MIOMCCCGFAD(IDCGBCKGBFJ ICDFCJEPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6843B90", Offset = "0x6842B90", VA = "0x186843B90")]
	private void MBENMNEDGDD(float LDFACAKBPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6844380", Offset = "0x6843380", VA = "0x186844380")]
	private void MHNFNDEEIPH([In] AILLONLIOPL NGHALOPECFO, MKJGPPHPMCI EPHCOJEEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6837DF0", Offset = "0x6836DF0", VA = "0x186837DF0")]
	private float CKKMOOLFMHI([In] AILLONLIOPL KJFHCCMMCDL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x683EDE0", Offset = "0x683DDE0", VA = "0x18683EDE0")]
	private void ILBKLEGMBBL(AILLONLIOPL NGHALOPECFO, MKJGPPHPMCI EPHCOJEEPMK, Vector3 MMHHLGLGJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x683AB70", Offset = "0x6839B70", VA = "0x18683AB70")]
	private static void FEELMFJEIGE(Transform DNPKMJFBJBC, Quaternion ADNGPFKNGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6844EE0", Offset = "0x6843EE0", VA = "0x186844EE0")]
	private void MKCEOAHEGLH([In] AILLONLIOPL EJGFFDKGCAF, [In] HNHGIGGCOEK LLBOGOPOIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6840F00", Offset = "0x683FF00", VA = "0x186840F00")]
	private void LGGIHJAOGDB([In] AILLONLIOPL EJGFFDKGCAF, [In] HNHGIGGCOEK LLBOGOPOIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x683ADA0", Offset = "0x6839DA0", VA = "0x18683ADA0")]
	public void FGEOENPDICK([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6840180", Offset = "0x683F180", VA = "0x186840180")]
	private void KILGMIDGFMA([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6848090", Offset = "0x6847090", VA = "0x186848090")]
	private void PFDFHDGHFKK(float JPBKKFNHKCC, [In] AILLONLIOPL KJFHCCMMCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68372E0", Offset = "0x68362E0", VA = "0x1868372E0")]
	private float BFILJILFCMC([In] AILLONLIOPL KJFHCCMMCDL, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6847960", Offset = "0x6846960", VA = "0x186847960")]
	private void PCJPACIKKLE([In] AILLONLIOPL KJFHCCMMCDL, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x683F300", Offset = "0x683E300", VA = "0x18683F300")]
	private void ILJAPPDLKAO([In] AILLONLIOPL KJFHCCMMCDL, float LKKBPGMNBJE, float FAJOFICAJNL, Vector3 HMNDPPMBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68417E0", Offset = "0x68407E0", VA = "0x1868417E0")]
	private void LNMDHHJGMHL(AILLONLIOPL KJFHCCMMCDL, AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6848380", Offset = "0x6847380", VA = "0x186848380")]
	private void POOMONAGHKH(AILLONLIOPL KJFHCCMMCDL, AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x683A590", Offset = "0x6839590", VA = "0x18683A590")]
	[CompilerGenerated]
	internal static bool ENIDFFOONCN(IKSolverVR.Arm PFJMIOJFJCH, CJJPNJPONEO JKIDPFKKIBP, float PBMDDCLJEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x683D480", Offset = "0x683C480", VA = "0x18683D480")]
	[CompilerGenerated]
	internal static float HHAOFGEAKLN(Vector3 LKBDILAAHNA, Vector3 MFOOBAHGEKC, Vector3 FDIKGBKIKDH, AILLONLIOPL KJFHCCMMCDL, AvatarFullBodyConfiguration FFADDNJMIIP, float ANNLKNNLIGI)
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
		public enum GLFEEPNCONO
		{
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private GLFEEPNCONO handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6834800", Offset = "0x6833800", VA = "0x186834800")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x68347C0", Offset = "0x68337C0", VA = "0x1868347C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6834190", Offset = "0x6833190", VA = "0x186834190")]
		private void DNBKJLMCCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x67FAE30", Offset = "0x67F9E30", VA = "0x1867FAE30", Slot = "4")]
		public void SetEnabled(bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6834830", Offset = "0x6833830", VA = "0x186834830")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, CMPPBAAMJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private Vector3 MLJIIOHOBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private Vector3 DFMDIOBNPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private Vector3 OBHLFIKMOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private Matrix4x4 EGEMLLHGCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool LCHNCOECOIP;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6834CD0", Offset = "0x6833CD0", VA = "0x186834CD0", Slot = "4")]
		public void UpdateController(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6834CC0", Offset = "0x6833CC0", VA = "0x186834CC0", Slot = "6")]
		public void SetEnabled(bool CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6834860", Offset = "0x6833860", VA = "0x186834860")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6835390", Offset = "0x6834390", VA = "0x186835390")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
internal class EKOOEKMFDOE : MPCHACNCAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Dictionary<string, HDMELEDKJMC> NJODHBOMMJI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GHHDKCJNKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x684A020", Offset = "0x6849020", VA = "0x18684A020")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.None)]
	private static void KMIBGBLECLK(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6849E60", Offset = "0x6848E60", VA = "0x186849E60", Slot = "4")]
	public HDMELEDKJMC FLBJBKMGHFK(string GGKICEPNPHD, AvatarSystemConfiguration LOGLAMBNPJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6849CE0", Offset = "0x6848CE0", VA = "0x186849CE0", Slot = "5")]
	public void EDAPOJBFKNO(string GGKICEPNPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x684A090", Offset = "0x6849090", VA = "0x18684A090")]
	public EKOOEKMFDOE()
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
		public class LDPJHICOAJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private Dictionary<string, Transform> MFAFHBNNJCH;

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public bool DFLAHLKBLGO
			{
				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x6854270", Offset = "0x6853270", VA = "0x186854270")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6854300", Offset = "0x6853300", VA = "0x186854300")]
			public void MODBFAFEFEE(VRIK IIEELMMCHNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
			public void JPDINLNHIBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x68542B0", Offset = "0x68532B0", VA = "0x1868542B0")]
			public void FDHFDDAAOOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6854430", Offset = "0x6853430", VA = "0x186854430")]
			public LDPJHICOAJO()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[NPPPEBEMIFD(CKKEEFADMDD.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[AIILLFBIOKD(CKKEEFADMDD.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private readonly LDPJHICOAJO OPBKANGDCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private JOONONOGMAB FDKEILFALOM;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x684E600", Offset = "0x684D600", VA = "0x18684E600")]
		private void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x684E8C0", Offset = "0x684D8C0", VA = "0x18684E8C0")]
		private bool HOCBEGLCMEC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x684E910", Offset = "0x684D910", VA = "0x18684E910")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x684E980", Offset = "0x684D980", VA = "0x18684E980")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x684E920", Offset = "0x684D920", VA = "0x18684E920")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x684EBF0", Offset = "0x684DBF0", VA = "0x18684EBF0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6856AD0", Offset = "0x6855AD0", VA = "0x186856AD0", Slot = "4")]
		public override void OnStateEnter(Animator IIKEFOKPPGC, AnimatorStateInfo NDLGBAIPFMI, int KKIKIMABCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6856C40", Offset = "0x6855C40", VA = "0x186856C40")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal abstract class MKFNHDCPGLD<TInput, TOutput> : PGLHILCHENG<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	protected readonly DNHLKDIIFLB BNNGHMOAPNI;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x44F59F0", Offset = "0x44F49F0", VA = "0x1844F59F0")]
	protected MKFNHDCPGLD(DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput JGNOLJBBCJA(TInput CPEKGDIIDKL, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x44F5950", Offset = "0x44F4950", VA = "0x1844F5950", Slot = "5")]
	public bool DOGJEPGJOGH(TInput CPEKGDIIDKL, [Out] TOutput? HJBJAPKPPFA, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[LEDNJNPECJC]
public static class BAHNFDLNPGO
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly Regex AKIBOABIEAJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x684EFC0", Offset = "0x684DFC0", VA = "0x18684EFC0")]
	public static EPBAMAOALIM EFGJGBLAKGC(AJKMIEONCMG DILOBOGMJEO, ENHFLJGMKFD CDPDFJELCCD, Guid? HOMBKAMBMCA, Color? OCIFBODPGIK, CFGFGPACPAK CNCOCPFNBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x684ECD0", Offset = "0x684DCD0", VA = "0x18684ECD0")]
	public static MMILDBOFIKL AOABHHGKJBH(EPBAMAOALIM FHNKDHIILBL)
	{
		return default(MMILDBOFIKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x28B5BF0", Offset = "0x28B4BF0", VA = "0x1828B5BF0")]
	internal static TModern? IPFGGPDLLPC<TModern>(string? CPEKGDIIDKL, FMGJFHCBAGJ<TModern> ALGLLIDCCHE, DNHLKDIIFLB BNNGHMOAPNI, LNFJMOJINMA EPIJIABJEPC, TModern LAFKPOMBBJD) where TModern : struct, FOOBKOEHCJF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x28B7240", Offset = "0x28B6240", VA = "0x1828B7240")]
	internal static FHMOFBOMCOC MKJKBAEODMA<TModern>(string? CPEKGDIIDKL, FMGJFHCBAGJ<TModern> ALGLLIDCCHE, DNHLKDIIFLB BNNGHMOAPNI, LNFJMOJINMA EPIJIABJEPC, TModern LAFKPOMBBJD) where TModern : struct, FOOBKOEHCJF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x684F1D0", Offset = "0x684E1D0", VA = "0x18684F1D0")]
	internal static List<GKMGBKADAJN> NCENLDCKAKA(IEnumerable<PCEKBJHFJHE>? HJBBNJNFBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x28B7A50", Offset = "0x28B6A50", VA = "0x1828B7A50")]
	internal static string PIJCMJKLIKM<TModern>(TModern CPEKGDIIDKL, FMGJFHCBAGJ<TModern> ALGLLIDCCHE, DNHLKDIIFLB BNNGHMOAPNI) where TModern : FOOBKOEHCJF
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FFFGIKFKFIL : HDIFBPINGMN
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public PGLHILCHENG<OJNLLGMGBIP, DGKNAIDPAJD> KKPGGJJPIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> GPBCENPKHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> MGOPAFEOMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MFNBAKPHICN GMOBAOFGIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KIKIMFIPLCP BLKGKGOPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6851F70", Offset = "0x6850F70", VA = "0x186851F70")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void ELKKFCJLAAD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6851FE0", Offset = "0x6850FE0", VA = "0x186851FE0")]
	[Preserve]
	internal FFFGIKFKFIL([JFHFHOOOEKP("UnitySerialization")] DAOBIGDGLOO KPHHFEIJHFB, [JFHFHOOOEKP(null)] LAAMNMEBFLF BNAJHALNKBG, [JFHFHOOOEKP(null)] DNHLKDIIFLB BNNGHMOAPNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum NPGINAOIGJO
{
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NHBNLADEFNO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6856E60", Offset = "0x6855E60", VA = "0x186856E60")]
	public NHBNLADEFNO(string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6856DC0", Offset = "0x6855DC0", VA = "0x186856DC0")]
	public NHBNLADEFNO(string NFOHONOFFAP, Exception EEOIAMFNMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6856E30", Offset = "0x6855E30", VA = "0x186856E30")]
	public NHBNLADEFNO(NPGINAOIGJO KEFHKMFECFI, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6856DF0", Offset = "0x6855DF0", VA = "0x186856DF0")]
	public NHBNLADEFNO(NPGINAOIGJO KEFHKMFECFI, string NFOHONOFFAP, Exception EEOIAMFNMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class HCFAJMEHKJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly DAOBIGDGLOO KPHHFEIJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	protected readonly LAAMNMEBFLF BNAJHALNKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	protected readonly DNHLKDIIFLB BNNGHMOAPNI;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6853EF0", Offset = "0x6852EF0", VA = "0x186853EF0")]
	protected HCFAJMEHKJG(DAOBIGDGLOO KPHHFEIJHFB, LAAMNMEBFLF BNAJHALNKBG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6852BE0", Offset = "0x6851BE0", VA = "0x186852BE0")]
	protected string GKMINIFMDBB(DGKNAIDPAJD BMIPHJFPOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6852540", Offset = "0x6851540", VA = "0x186852540")]
	protected string AFOGBCCBMHH(DGKNAIDPAJD BMIPHJFPOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6852870", Offset = "0x6851870", VA = "0x186852870")]
	private AvatarOutfitSelectionData EFGJGBLAKGC(EPBAMAOALIM COHLHCBLMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6852730", Offset = "0x6851730", VA = "0x186852730")]
	private static AvatarCustomizationSettingsData.AnchorParams BCCCJAFFOAM(MPNIGMOKBGH? GAILDDGHHLF)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PGLHILCHENG<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput JGNOLJBBCJA(TInput CPEKGDIIDKL, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOGJEPGJOGH(TInput CPEKGDIIDKL, [Out] TOutput? HJBJAPKPPFA, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HDIFBPINGMN
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PGLHILCHENG<OJNLLGMGBIP, DGKNAIDPAJD> KKPGGJJPIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> MGOPAFEOMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MFNBAKPHICN GMOBAOFGIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal enum LNFJMOJINMA
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KIKIMFIPLCP
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APEJHCDIBGK KLDBPIDHOEH(DGKNAIDPAJD FHNKDHIILBL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface MFNBAKPHICN
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GAJOGHLFFIO KLDBPIDHOEH(DGKNAIDPAJD FHNKDHIILBL, int PELKODHFFGF, string? LCLKDNPLMED, string? AHGIJDBMKEJ, GOCILOCPHNM HBGFNCNPMFK, List<GKMGBKADAJN>? MNBBNGOOGMB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[LEDNJNPECJC]
internal class MIFMKBIGLEA : MKFNHDCPGLD<OJNLLGMGBIP, DGKNAIDPAJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly LAAMNMEBFLF BNAJHALNKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly EGBFOEJAPIN GAOCOAEAPIJ;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6856460", Offset = "0x6855460", VA = "0x186856460")]
	public MIFMKBIGLEA(DAOBIGDGLOO KPHHFEIJHFB, LAAMNMEBFLF BNAJHALNKBG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x68561B0", Offset = "0x68551B0", VA = "0x1868561B0", Slot = "6")]
	public override DGKNAIDPAJD JGNOLJBBCJA(OJNLLGMGBIP CPEKGDIIDKL, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Preserve]
internal class NCEHOAOBNCL : DAOBIGDGLOO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class LBMOBAPLGAL : JsonConverter<FHMOFBOMCOC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6854190", Offset = "0x6853190", VA = "0x186854190", Slot = "9")]
		public override void WriteJson(JsonWriter OGONFGJBIBI, FHMOFBOMCOC? CBAEIEAPLIH, JsonSerializer AABBBPHCHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6854070", Offset = "0x6853070", VA = "0x186854070", Slot = "10")]
		public override FHMOFBOMCOC ReadJson(JsonReader DHKLMNOOPAJ, Type MDFBEPCIDHL, FHMOFBOMCOC? GLHAJCLPPCD, bool HFNKLKJPFOO, JsonSerializer AABBBPHCHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6854230", Offset = "0x6853230", VA = "0x186854230")]
		public LBMOBAPLGAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class ODENPHMFIDI : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool EAECKJBAICN
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x68576F0", Offset = "0x68566F0", VA = "0x1868576F0", Slot = "5")]
		public override object ReadJson(JsonReader DHKLMNOOPAJ, Type MDFBEPCIDHL, object? GLHAJCLPPCD, JsonSerializer AABBBPHCHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6857330", Offset = "0x6856330", VA = "0x186857330", Slot = "6")]
		public override bool CanConvert(Type MDFBEPCIDHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6857750", Offset = "0x6856750", VA = "0x186857750", Slot = "4")]
		public override void WriteJson(JsonWriter OGONFGJBIBI, object? CBAEIEAPLIH, JsonSerializer AABBBPHCHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6857510", Offset = "0x6856510", VA = "0x186857510")]
		private static bool GGBBIFBHAOA(object CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public ODENPHMFIDI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly JsonSerializerSettings NJGBEKGEHCO;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6856C60", Offset = "0x6855C60", VA = "0x186856C60")]
	internal NCEHOAOBNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2C803E0", Offset = "0x2C7F3E0", VA = "0x182C803E0", Slot = "4")]
	public string MHOIPFCLCJO<T>(T HBFCGFKGCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2C80350", Offset = "0x2C7F350", VA = "0x182C80350", Slot = "5")]
	public T FDCBALDOPKI<T>(string CBAEIEAPLIH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class HBENEBKFNNC : DAOBIGDGLOO
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F170", Offset = "0x2B1E170", VA = "0x182B1F170", Slot = "4")]
	public string MHOIPFCLCJO<T>(T HBFCGFKGCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F0F0", Offset = "0x2B1E0F0", VA = "0x182B1F0F0", Slot = "5")]
	public T FDCBALDOPKI<T>(string CBAEIEAPLIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public HBENEBKFNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[LEDNJNPECJC]
internal class EGBFOEJAPIN : MKFNHDCPGLD<GAJOGHLFFIO, ALHKOGGDKHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly DAOBIGDGLOO KPHHFEIJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly LAAMNMEBFLF BNAJHALNKBG;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6851E30", Offset = "0x6850E30", VA = "0x186851E30")]
	public EGBFOEJAPIN(DAOBIGDGLOO KPHHFEIJHFB, LAAMNMEBFLF BNAJHALNKBG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x68512E0", Offset = "0x68502E0", VA = "0x1868512E0", Slot = "6")]
	public override ALHKOGGDKHM JGNOLJBBCJA(GAJOGHLFFIO CPEKGDIIDKL, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6850E80", Offset = "0x684FE80", VA = "0x186850E80")]
	internal void HBDLBJLJHDC(string IGKJHHNIPKB, DGKNAIDPAJD BMIPHJFPOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6851D80", Offset = "0x6850D80", VA = "0x186851D80")]
	public IEnumerable<EPBAMAOALIM> LGMLNBGNEMG(string OCONBJGLBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6850A50", Offset = "0x684FA50", VA = "0x186850A50")]
	private IEnumerable<EPBAMAOALIM> GDKDGBBONIC(string OCONBJGLBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6851710", Offset = "0x6850710", VA = "0x186851710")]
	internal IEnumerable<EPBAMAOALIM> JHODOHEPOMN(string OCONBJGLBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x684FC80", Offset = "0x684EC80", VA = "0x18684FC80")]
	private EPBAMAOALIM CCILJPGFBJD(AvatarOutfitSelectionData KCBHMGILKGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x68501B0", Offset = "0x684F1B0", VA = "0x1868501B0")]
	private void FAKCPEMJDLA(AvatarCustomizationSettingsData MPMBGMHOEAE, DGKNAIDPAJD BMIPHJFPOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x684F8F0", Offset = "0x684E8F0", VA = "0x18684F8F0")]
	private EPBAMAOALIM CCILJPGFBJD(string KIMCGNFAMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6850FE0", Offset = "0x684FFE0", VA = "0x186850FE0")]
	internal static (CFGFGPACPAK, string, string) JDEBDBFGNMI(string KIMCGNFAMJH, DNHLKDIIFLB BNNGHMOAPNI)
	{
		return default((CFGFGPACPAK, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6851B80", Offset = "0x6850B80", VA = "0x186851B80")]
	private ACIKNKLFGHF? KPGICAJMFCJ(string? NNFEKLKANBO, Vector2 KCKFECPEICH, float NKLJGNMFDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6850050", Offset = "0x684F050", VA = "0x186850050")]
	private static MPNIGMOKBGH EHFNNLGANCD(AvatarCustomizationSettingsData.AnchorParams NPODIKEHINJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LEDNJNPECJC]
internal class PNEBEFPNKCJ : HCFAJMEHKJG, KIKIMFIPLCP
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6853EF0", Offset = "0x6852EF0", VA = "0x186853EF0")]
	public PNEBEFPNKCJ(DAOBIGDGLOO KPHHFEIJHFB, LAAMNMEBFLF BNAJHALNKBG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6857BF0", Offset = "0x6856BF0", VA = "0x186857BF0", Slot = "4")]
	public APEJHCDIBGK KLDBPIDHOEH(DGKNAIDPAJD FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6857AF0", Offset = "0x6856AF0", VA = "0x186857AF0")]
	private string GKMKBJALCGG(DGKNAIDPAJD BMIPHJFPOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6857830", Offset = "0x6856830", VA = "0x186857830")]
	private string BCMIHIFMMKA(EPBAMAOALIM COHLHCBLMMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[LEDNJNPECJC]
internal class DPAPIEHPICD : MKFNHDCPGLD<GAJOGHLFFIO, ALHKOGGDKHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly DAOBIGDGLOO KPHHFEIJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> EKBAJJFDLCG;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x684F7F0", Offset = "0x684E7F0", VA = "0x18684F7F0")]
	public DPAPIEHPICD(PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> EKBAJJFDLCG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x684F3C0", Offset = "0x684E3C0", VA = "0x18684F3C0", Slot = "6")]
	public override ALHKOGGDKHM JGNOLJBBCJA(GAJOGHLFFIO CPEKGDIIDKL, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[LEDNJNPECJC]
internal class NJKEFKDLKHO : MFNBAKPHICN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly DAOBIGDGLOO KPHHFEIJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly KIKIMFIPLCP LFHNLMKIIDH;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6857240", Offset = "0x6856240", VA = "0x186857240")]
	public NJKEFKDLKHO(KIKIMFIPLCP LFHNLMKIIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6856E90", Offset = "0x6855E90", VA = "0x186856E90", Slot = "4")]
	public GAJOGHLFFIO KLDBPIDHOEH(DGKNAIDPAJD FHNKDHIILBL, int PELKODHFFGF, string? LCLKDNPLMED, string? AHGIJDBMKEJ, GOCILOCPHNM HBGFNCNPMFK, List<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Preserve]
internal class LGMNDELPNIE : LJBINCFCALP
{
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static readonly Vector2 PNBNHFDCIJG;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static readonly Vector2 LKJDNIGFELI;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly Vector2 OBADMEAGDLL;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static readonly Vector2 MLLEKJNDPEL;

	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static readonly Vector2 OJOICHDEOCO;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private static readonly Vector2 HMHPGNMOGIG;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private static readonly Vector2 JNNGLNOBCFL;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly Vector2 APEHIOMCCMJ;

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private static readonly Vector2 GPFKOLMEFLG;

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private static readonly Vector2 JIFAAKAHOGG;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly Vector2 CGLKHDKNHLN;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly Vector2 HKBODBNIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private Dictionary<PKLKNBHIDDA, AvatarConfiguration> OJPOHPBHHIF;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6855940", Offset = "0x6854940", VA = "0x186855940")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.None)]
	private static void OBOFKHCDFNO(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6856100", Offset = "0x6855100", VA = "0x186856100")]
	[Preserve]
	internal LGMNDELPNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6855310", Offset = "0x6854310", VA = "0x186855310", Slot = "4")]
	public Vector2 IBMENODALHH(FaceFeatureType CDPIIJCPHBI, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6854E10", Offset = "0x6853E10", VA = "0x186854E10", Slot = "5")]
	public float GFKPNLCMBLC(FaceFeatureType CDPIIJCPHBI, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x68559B0", Offset = "0x68549B0", VA = "0x1868559B0", Slot = "6")]
	public void OIKOMOHFMMJ(PKLKNBHIDDA LHEGLCAAFHK, AvatarConfiguration LOGLAMBNPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6855830", Offset = "0x6854830", VA = "0x186855830", Slot = "7")]
	public float NEFLPIHADEG(FaceFeatureType NIFKLDNIBPI, float BGBANMEEMGD, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6854E90", Offset = "0x6853E90", VA = "0x186854E90", Slot = "8")]
	public float GMMPMHJHEEI(FaceFeatureType NIFKLDNIBPI, float NKLJGNMFDCD, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6854C60", Offset = "0x6853C60", VA = "0x186854C60", Slot = "10")]
	public Vector2 GDFCJCNMCJM(FaceFeatureType NIFKLDNIBPI, Vector2 NLOAKGCNEMF, Vector2 FABJGBLGIHK, Vector2 IBBEBMMMLKP, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x68548F0", Offset = "0x68538F0", VA = "0x1868548F0", Slot = "9")]
	public Vector2 EPNACMGMDMG(FaceFeatureType NIFKLDNIBPI, Vector2 LLFCCOMMMGN, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6855790", Offset = "0x6854790", VA = "0x186855790")]
	private Vector2 NBPOIFDFIEL(FaceFeatureType NIFKLDNIBPI, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6855060", Offset = "0x6854060", VA = "0x186855060")]
	private Vector2 HPCGLAJHNPN(FaceFeatureType NIFKLDNIBPI, Vector2 NLOAKGCNEMF, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6855AA0", Offset = "0x6854AA0", VA = "0x186855AA0", Slot = "11")]
	public Vector2 PIKGGDCCGOD(FaceFeatureType NIFKLDNIBPI, Vector2 LLFCCOMMMGN, Vector2 FABJGBLGIHK, Vector2 IBBEBMMMLKP, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6854620", Offset = "0x6853620", VA = "0x186854620")]
	private float DIFDNEONLHF(float MDCIOHOLJPO, float HGPGLPENOMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x68544C0", Offset = "0x68534C0", VA = "0x1868544C0")]
	private Vector2 BGJLCDJIHJM(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6854790", Offset = "0x6853790", VA = "0x186854790")]
	private Vector2 DONJDEFHKHL(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6855A20", Offset = "0x6854A20", VA = "0x186855A20")]
	private Vector2 OJDGAEDHIEM(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68551B0", Offset = "0x68541B0", VA = "0x1868551B0")]
	private Vector2 IAEPKJIIEPH(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6854B20", Offset = "0x6853B20", VA = "0x186854B20")]
	private float FBLFIBMNHDJ(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6855550", Offset = "0x6854550", VA = "0x186855550")]
	private float IMIOEHFPPBH(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6855670", Offset = "0x6854670", VA = "0x186855670")]
	private float JJNGGLDJGIL(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6854C20", Offset = "0x6853C20", VA = "0x186854C20")]
	private float FPDCGENFHKO(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6855470", Offset = "0x6854470", VA = "0x186855470")]
	private Vector2 IIAMPCOKKHI(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6855590", Offset = "0x6854590", VA = "0x186855590")]
	private Vector2 JEKCCHAKNGH(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6854810", Offset = "0x6853810", VA = "0x186854810")]
	private Vector2 EGKBKPMKINI(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68546B0", Offset = "0x68536B0", VA = "0x1868546B0")]
	private Vector2 DMENMFBOFOK(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6855230", Offset = "0x6854230", VA = "0x186855230")]
	private Vector2 IAFEANBGLLN(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x68556B0", Offset = "0x68546B0", VA = "0x1868556B0")]
	private Vector2 MJJOEJFBBCD(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6854EC0", Offset = "0x6853EC0", VA = "0x186854EC0")]
	private Vector2 HLPBLEJOCHG(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6854540", Offset = "0x6853540", VA = "0x186854540")]
	private Vector2 BJDKIHLKBMB(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6855860", Offset = "0x6854860", VA = "0x186855860")]
	private Vector2 OAIGFAGJEOC(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6854FA0", Offset = "0x6853FA0", VA = "0x186854FA0")]
	private Vector2 HMKMBFLDCGM(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6854B60", Offset = "0x6853B60", VA = "0x186854B60")]
	private Vector2 FEBFILLDPJI(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6855E30", Offset = "0x6854E30", VA = "0x186855E30")]
	private Vector2 PKPEHAHDGGJ(PKLKNBHIDDA LHEGLCAAFHK)
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
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x684DC80", Offset = "0x684CC80", VA = "0x18684DC80")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MNBGIFEELEI
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x68566A0", Offset = "0x68556A0", VA = "0x1868566A0")]
	public static MMILDBOFIKL JGNOLJBBCJA(this MFBAFFGNDHK FHNKDHIILBL)
	{
		return default(MMILDBOFIKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6856920", Offset = "0x6855920", VA = "0x186856920")]
	public static MFBAFFGNDHK KLDBPIDHOEH(this MMILDBOFIKL PCOOLHMNJLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6856630", Offset = "0x6855630", VA = "0x186856630")]
	public static bool CGIHEPGJEFN(this MMILDBOFIKL PCOOLHMNJLA)
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
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4CC22D0", Offset = "0x4CC12D0", VA = "0x184CC22D0")]
			public AnchorParams(Vector2 NLOAKGCNEMF, Vector3 FPDAAEPPIEJ, Vector3 DIPLBFGLHMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x684DBD0", Offset = "0x684CBD0", VA = "0x18684DBD0")]
			internal MPNIGMOKBGH KLDBPIDHOEH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private ILADNPKLBOP useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x684E4A0", Offset = "0x684D4A0", VA = "0x18684E4A0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x867DF0", Offset = "0x866DF0", VA = "0x180867DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4512F30", Offset = "0x4511F30", VA = "0x184512F30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1083F60", Offset = "0x1082F60", VA = "0x181083F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8D0B40", Offset = "0x8CFB40", VA = "0x1808D0B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DFDB0", VA = "0x1809E0DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x868800", Offset = "0x867800", VA = "0x180868800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x684E550", Offset = "0x684D550", VA = "0x18684E550")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x870FE0", Offset = "0x86FFE0", VA = "0x180870FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8D0AF0", Offset = "0x8CFAF0", VA = "0x1808D0AF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x108F8C0", Offset = "0x108E8C0", VA = "0x18108F8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x86B9A0", Offset = "0x86A9A0", VA = "0x18086B9A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x86BA50", Offset = "0x86AA50", VA = "0x18086BA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x684E590", Offset = "0x684D590", VA = "0x18684E590")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x1CA24D0", Offset = "0x1CA14D0", VA = "0x181CA24D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8D11D0", Offset = "0x8D01D0", VA = "0x1808D11D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xEA4D50", Offset = "0xEA3D50", VA = "0x180EA4D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x866E00", Offset = "0x865E00", VA = "0x180866E00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x866DE0", Offset = "0x865DE0", VA = "0x180866DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x41BF5A0", Offset = "0x41BE5A0", VA = "0x1841BF5A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1CCD3B0", Offset = "0x1CCC3B0", VA = "0x181CCD3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x89BD60", Offset = "0x89AD60", VA = "0x18089BD60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x89BDC0", Offset = "0x89ADC0", VA = "0x18089BDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x86BA10", Offset = "0x86AA10", VA = "0x18086BA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x86BB10", Offset = "0x86AB10", VA = "0x18086BB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x86BAA0", Offset = "0x86AAA0", VA = "0x18086BAA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x86BAC0", Offset = "0x86AAC0", VA = "0x18086BAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x86B9D0", Offset = "0x86A9D0", VA = "0x18086B9D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x86B9F0", Offset = "0x86A9F0", VA = "0x18086B9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9CF6F0", Offset = "0x9CE6F0", VA = "0x1809CF6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F8390", Offset = "0x9F7390", VA = "0x1809F8390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x86BA30", Offset = "0x86AA30", VA = "0x18086BA30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x86B930", Offset = "0x86A930", VA = "0x18086B930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x9F5AC0", Offset = "0x9F4AC0", VA = "0x1809F5AC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9D46C0", Offset = "0x9D36C0", VA = "0x1809D46C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x872650", Offset = "0x871650", VA = "0x180872650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8725D0", Offset = "0x8715D0", VA = "0x1808725D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB9A5E0", Offset = "0xB995E0", VA = "0x180B9A5E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xBA25A0", Offset = "0xBA15A0", VA = "0x180BA25A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA49410", Offset = "0xA48410", VA = "0x180A49410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xD2D020", Offset = "0xD2C020", VA = "0x180D2D020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public ILADNPKLBOP UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1D68C90", Offset = "0x1D67C90", VA = "0x181D68C90")]
			get
			{
				return default(ILADNPKLBOP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1D6AEE0", Offset = "0x1D69EE0", VA = "0x181D6AEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA79FD0", Offset = "0xA78FD0", VA = "0x180A79FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xA783E0", Offset = "0xA773E0", VA = "0x180A783E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x684E570", Offset = "0x684D570", VA = "0x18684E570")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x684E5B0", Offset = "0x684D5B0", VA = "0x18684E5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x684E100", Offset = "0x684D100", VA = "0x18684E100")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public CFGFGPACPAK BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private BHFPKMDNKBO? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x684E5D0", Offset = "0x684D5D0", VA = "0x18684E5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
