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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x681C480", Offset = "0x681AA80", VA = "0x18681C480")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
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
	[Cpp2IlInjected.Address(RVA = "0x6805EC0", Offset = "0x68044C0", VA = "0x186805EC0")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void ELKKFCJLAAD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6807830", Offset = "0x6805E30", VA = "0x186807830")]
	[Preserve]
	internal CCPPCIFHPFN([JFHFHOOOEKP(null)] AKKACFAHBDE BDNFHNNAIIE, [JFHFHOOOEKP(null)] HDIFBPINGMN KCJJKMDLFAB, [JFHFHOOOEKP(null)] OCPEHBFLGHI NEGLDOLAIHM, [JFHFHOOOEKP(null)] LJBINCFCALP EIJFBMHEBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68060E0", Offset = "0x68046E0", VA = "0x1868060E0", Slot = "5")]
	public DGKNAIDPAJD JOANFAHKPIG(bool EJIBDDGFJJE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6806DF0", Offset = "0x68053F0", VA = "0x186806DF0", Slot = "4")]
	public DGKNAIDPAJD PHHPNIEEMCO(bool EJIBDDGFJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6806890", Offset = "0x6804E90", VA = "0x186806890", Slot = "6")]
	public GAJOGHLFFIO JOJKNMCGGEG(DGKNAIDPAJD FHNKDHIILBL, int PELKODHFFGF, string? LCLKDNPLMED, string? AHGIJDBMKEJ, GOCILOCPHNM HBGFNCNPMFK, List<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68077A0", Offset = "0x6805DA0", VA = "0x1868077A0", Slot = "7")]
	public bool PKKECHAPOAC(OJNLLGMGBIP GGBAOPBACDD, [Out] DGKNAIDPAJD? BMIPHJFPOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68069A0", Offset = "0x6804FA0", VA = "0x1868069A0", Slot = "8")]
	public bool LNFFPJPACFN(GAJOGHLFFIO EPFDCONIBPD, [Out] DGKNAIDPAJD? BMIPHJFPOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6806D60", Offset = "0x6805360", VA = "0x186806D60", Slot = "9")]
	public bool PBNPAOCJINC(GAJOGHLFFIO EPFDCONIBPD, [Out] ALHKOGGDKHM? GGBAOPBACDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2916D60", Offset = "0x2915360", VA = "0x182916D60")]
	private bool DOGJEPGJOGH<TInput, TOutput>(TInput CPEKGDIIDKL, PGLHILCHENG<TInput, TOutput> KIFAJGMPCFF, [Out] TOutput? HJBJAPKPPFA) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6805F30", Offset = "0x6804530", VA = "0x186805F30")]
	[CompilerGenerated]
	private ACIKNKLFGHF JGLBGBNMKNB(FaceFeatureType CDPIIJCPHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6806A80", Offset = "0x6805080", VA = "0x186806A80")]
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
	[Cpp2IlInjected.Address(RVA = "0x681B100", Offset = "0x6819700", VA = "0x18681B100")]
	[UsedImplicitly]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	private static void ELKKFCJLAAD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x681C050", Offset = "0x681A650", VA = "0x18681C050")]
	[Preserve]
	internal LFIONFHIPEB([JFHFHOOOEKP(null)] OCPEHBFLGHI NEGLDOLAIHM, [JFHFHOOOEKP(null)] DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x681BF50", Offset = "0x681A550", VA = "0x18681BF50", Slot = "4")]
	public bool KANCLJPDGPI(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x681BDF0", Offset = "0x681A3F0", VA = "0x18681BDF0", Slot = "5")]
	public bool KANCLJPDGPI(ALHKOGGDKHM GGBAOPBACDD, IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x681B170", Offset = "0x6819770", VA = "0x18681B170")]
	private void HDPCCFKOGNF(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? JLMICGLMAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x681BBC0", Offset = "0x681A1C0", VA = "0x18681BBC0")]
	private void IPECEJFLMPH(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? JLMICGLMAKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AKKACFAHBDE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KANCLJPDGPI(DGKNAIDPAJD BMIPHJFPOAO, IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
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

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6800560", Offset = "0x67FEB60", VA = "0x186800560")]
		public void DJCEJHEJNEH(AnimationPoseSetting LJAAPFIIPOF, float NENJONGBLIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6800690", Offset = "0x67FEC90", VA = "0x186800690")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, CMPPBAAMJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
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
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
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

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68006B0", Offset = "0x67FECB0", VA = "0x1868006B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6800CB0", Offset = "0x67FF2B0", VA = "0x186800CB0", Slot = "4")]
		public void UpdateController(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE7CEB0", Offset = "0xE7B4B0", VA = "0x180E7CEB0", Slot = "6")]
		public void SetEnabled(bool CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6800750", Offset = "0x67FED50", VA = "0x186800750")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68010D0", Offset = "0x67FF6D0", VA = "0x1868010D0")]
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
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6801450", Offset = "0x67FFA50", VA = "0x186801450", Slot = "4")]
		public void UpdateController(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB717A0", Offset = "0xB6FDA0", VA = "0x180B717A0", Slot = "6")]
		public void SetEnabled(bool CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6801170", Offset = "0x67FF770", VA = "0x186801170")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6802020", Offset = "0x6800620", VA = "0x186802020")]
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
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
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
		[Cpp2IlInjected.Address(RVA = "0x6802940", Offset = "0x6800F40", VA = "0x186802940")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6802900", Offset = "0x6800F00", VA = "0x186802900")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6802050", Offset = "0x6800650", VA = "0x186802050")]
		private void DNBKJLMCCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67CB2B0", Offset = "0x67C98B0", VA = "0x1867CB2B0", Slot = "4")]
		public void SetEnabled(bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6802970", Offset = "0x6800F70", VA = "0x186802970")]
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
		private bool LCHNCOECOIP;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68029B0", Offset = "0x6800FB0", VA = "0x1868029B0", Slot = "4")]
		public void UpdateController(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x873F30", Offset = "0x872530", VA = "0x180873F30", Slot = "6")]
		public void SetEnabled(bool CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6803130", Offset = "0x6801730", VA = "0x186803130")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, JOONONOGMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		[Header("Configuration")]
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
		[AIILLFBIOKD(CKKEEFADMDD.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Header("Configuration")]
		[SerializeField]
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
		[Header("Arm Animation Controllers")]
		[SerializeField]
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
		private HDMELEDKJMC GIGGDCJADKL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HDMELEDKJMC NFLNNGFDILP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6803EC0", Offset = "0x68024C0", VA = "0x186803EC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform LIAGDHCHNHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6803F00", Offset = "0x6802500", VA = "0x186803F00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6803160", Offset = "0x6801760", VA = "0x186803160")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6803D80", Offset = "0x6802380", VA = "0x186803D80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6803D30", Offset = "0x6802330", VA = "0x186803D30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6803CC0", Offset = "0x68022C0", VA = "0x186803CC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6803BB0", Offset = "0x68021B0", VA = "0x186803BB0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6803CC0", Offset = "0x68022C0", VA = "0x186803CC0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68031E0", Offset = "0x68017E0", VA = "0x1868031E0", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6803DD0", Offset = "0x68023D0", VA = "0x186803DD0", Slot = "8")]
		public void UpdatePostIKAnimControllers(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6803C30", Offset = "0x6802230", VA = "0x186803C30")]
		private void JJDCJANPBPN(GameObject HBFCGFKGCAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6803510", Offset = "0x6801B10", VA = "0x186803510")]
		private HDMELEDKJMC IKIIFONHLOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
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
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
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
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6803F20", Offset = "0x6802520", VA = "0x186803F20")]
		public AnimationPoseSetting PLACCHGKIDH(FLNAILNJOEP KHOPIOAGPIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6803F50", Offset = "0x6802550", VA = "0x186803F50")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GIIBCNNAPEA : KEOJJFEMGHE
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int HLGGEHKALDJ;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static int PKFLKFGEFML;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static int PIGDPDHBHCH;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static int HIJIMDIJBGN;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static int AJIGIMIGLGJ;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static int GOAIFAJCPNM;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static int NCLCHGAGDPL;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int CAHNJABHDFJ;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int PMKJFIFPCNH;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int[] PGLDMJDIEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	internal bool DGOJIMFPLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private CPGPGEHMHOJ HLPIAFCOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private int MEHJNKPMDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float HKGCJIPLCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool BOKNEIONIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Animator LOEJJGILMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private AvatarFullBodyConfiguration OPJPFPDKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int DGBAFJKDBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private int EDMIJCBLOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private int PJIGLJIHHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool PMOBNGLIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private JAEBJFMEEKJ JPOJLILPCFH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform GPHINIAIMDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 HKDIMJHLGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xDC6200", Offset = "0xDC4800", VA = "0x180DC6200")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xDC61F0", Offset = "0xDC47F0", VA = "0x180DC61F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion KDIDNBEJFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1BB2750", Offset = "0x1BB0D50", VA = "0x181BB2750")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1F30700", Offset = "0x1F2ED00", VA = "0x181F30700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 AIHJNKNHHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4537010", Offset = "0x4535610", VA = "0x184537010", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4533E90", Offset = "0x4532490", VA = "0x184533E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Quaternion JMBIPPKNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x10C7370", Offset = "0x10C5970", VA = "0x1810C7370", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x383D830", Offset = "0x383BE30", VA = "0x18383D830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NNNBHLGDPFP NLGHGKCNDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8683F0", Offset = "0x8669F0", VA = "0x1808683F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(NNNBHLGDPFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x868410", Offset = "0x866A10", VA = "0x180868410", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NNNBHLGDPFP PKHALDCAAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7380", Offset = "0x1AB5980", VA = "0x181AB7380", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(NNNBHLGDPFP);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7390", Offset = "0x1AB5990", VA = "0x181AB7390", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MPGJIBPMNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C8B0", Offset = "0x1D5AEB0", VA = "0x181D5C8B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CF80", Offset = "0x1D5B580", VA = "0x181D5CF80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DLHFGOFLIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x681AB60", Offset = "0x6819160", VA = "0x18681AB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ACBMMCJNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x681A7D0", Offset = "0x6818DD0", VA = "0x18681A7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JHDIGKBFMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x681A490", Offset = "0x6818A90", VA = "0x18681A490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x681A2B0", Offset = "0x68188B0", VA = "0x18681A2B0", Slot = "21")]
	public void BGGINNGCCML(CPGPGEHMHOJ ONHKIOMDBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x681AB70", Offset = "0x6819170", VA = "0x18681AB70", Slot = "22")]
	public void PNCHDOGCJEH(CBMPKJMGNCL GLPJLLPJKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x681A920", Offset = "0x6818F20", VA = "0x18681A920", Slot = "11")]
	public void HNACMKLCEEB(bool OHFAELGDCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x681A4A0", Offset = "0x6818AA0", VA = "0x18681A4A0", Slot = "10")]
	public void GBFAMFOABCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x681A9E0", Offset = "0x6818FE0", VA = "0x18681A9E0")]
	private int KMPHIPCLCIA(NNNBHLGDPFP FGEAEFHPDPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x681A7F0", Offset = "0x6818DF0", VA = "0x18681A7F0")]
	private void HAFACLLLJAB(int MJKCLKCGEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x681A470", Offset = "0x6818A70", VA = "0x18681A470", Slot = "12")]
	public bool BKHHHGINHCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x681A9B0", Offset = "0x6818FB0", VA = "0x18681A9B0", Slot = "13")]
	public bool HPPFPPNGNKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x681A260", Offset = "0x6818860", VA = "0x18681A260")]
	private NNNBHLGDPFP AIONKPBGGHA()
	{
		return default(NNNBHLGDPFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xF015E0", Offset = "0xEFFBE0", VA = "0x180F015E0", Slot = "14")]
	public void LMEFCIABOAJ(bool OHFAELGDCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x681A7E0", Offset = "0x6818DE0", VA = "0x18681A7E0", Slot = "9")]
	public void GLLCBEHKPKI(int MJKCLKCGEIP, float MDOIIPJHJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x681A9C0", Offset = "0x6818FC0", VA = "0x18681A9C0", Slot = "7")]
	public void JFALIGGKHCF(JAEBJFMEEKJ NGHALOPECFO, bool GMNLPDCHGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x681A480", Offset = "0x6818A80", VA = "0x18681A480", Slot = "8")]
	public void DJPOLEEMPJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x681A780", Offset = "0x6818D80", VA = "0x18681A780", Slot = "15")]
	public void GDEJOKOKFGP(Transform HHMPHBNGMGF, Vector3 KCKFECPEICH, Quaternion JPAKCFIICPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x681AEA0", Offset = "0x68194A0", VA = "0x18681AEA0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float OPLNJBAKJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Vector3 HKNIBOPPEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private float BHLKGMLNJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private bool DLIEGEADGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AnimationPoseSetting HLJHDDDPALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private float PFJPCACBHBM;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x681C6C0", Offset = "0x681ACC0", VA = "0x18681C6C0")]
		public void ENIFIPPFMGI(IKSolverVR.Arm PFJMIOJFJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x681D690", Offset = "0x681BC90", VA = "0x18681D690")]
		public void NEFDBEDAHDK(IKSolverVR.Arm PFJMIOJFJCH, Transform IFJIKCHJIFG, bool CBJKBGHDHCK, AvatarFullBodyConfiguration FFADDNJMIIP, float AOIPNCIAIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x681C500", Offset = "0x681AB00", VA = "0x18681C500")]
		public void AFINELOKEJO(IKSolverVR.Arm PFJMIOJFJCH, float FJGCJGDDNJE, bool DLIEGEADGNJ, AvatarFullBodyConfiguration FFADDNJMIIP, float AOIPNCIAIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x681D920", Offset = "0x681BF20", VA = "0x18681D920")]
		private void NPMEADKBBIK(Transform IFJIKCHJIFG, IKSolverVR.Arm PFJMIOJFJCH, float KHIPOIDNJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x681D880", Offset = "0x681BE80", VA = "0x18681D880")]
		private void NNCHMHGFPKF(bool CBJKBGHDHCK, AvatarFullBodyConfiguration FFADDNJMIIP, float AOIPNCIAIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x681C680", Offset = "0x681AC80", VA = "0x18681C680")]
		private void EFADGFCDKOE(IKSolverVR.Arm PFJMIOJFJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x681C840", Offset = "0x681AE40", VA = "0x18681C840")]
		public void HCJMINLPHED(IKSolverVR.Arm PFJMIOJFJCH, Transform OMNBACONICF, Transform PKNLKFCCKOF, Quaternion BLDOJMLPCEO, Vector3 IOGKFELDEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x681DA10", Offset = "0x681C010", VA = "0x18681DA10")]
		private (Vector3, Quaternion) PHEKDBFKFMB(GIIBCNNAPEA OEBENPNMDBG, Quaternion JCCPLLNKMFM, Vector3 BDGIIINNKPL)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x681C6F0", Offset = "0x681ACF0", VA = "0x18681C6F0")]
		public void FINNBLNMBNN(GIIBCNNAPEA OEBENPNMDBG, IKSolverVR.Arm PFJMIOJFJCH, Quaternion JCCPLLNKMFM, Vector3 BDGIIINNKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x681CC20", Offset = "0x681B220", VA = "0x18681CC20")]
		public void HOJJGBGFJCC(GIIBCNNAPEA OEBENPNMDBG, IKSolverVR.Arm PFJMIOJFJCH, Quaternion JCCPLLNKMFM, Vector3 BDGIIINNKPL, [In] AvatarFullBodyConfiguration FFADDNJMIIP, [In] AILLONLIOPL NGHALOPECFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x681C540", Offset = "0x681AB40", VA = "0x18681C540")]
		public void ECOBPJGJLNJ(FLNAILNJOEP KGACENBDLHB, AvatarFullBodyConfiguration FFADDNJMIIP, AILLONLIOPL NGHALOPECFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x681D210", Offset = "0x681B810", VA = "0x18681D210")]
		public void IMIBJGFIDGD(IKSolverVR.Arm PFJMIOJFJCH, Transform OMNBACONICF, Vector3 FDLNFOLDHLB, float EMPIBEEEFOP, Quaternion BAJBLBPFPNF, Vector3 JFHJMGKJFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x681DEA0", Offset = "0x681C4A0", VA = "0x18681DEA0")]
		public PINPBFDHGNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private enum IDCGBCKGBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum MKJGPPHPMCI
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int APPPKIOLDNG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int PNAIOFJILFJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int OCEBLKHIEBO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int JPIFJAHGOFE;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int AMKLFMOCBAN;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int FHEBEFEGGNM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int KNGKHOBICBH;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int PBJLFPOELEP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int FPJLODDIOJH;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int DGFBJKKNIIK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int DMDIHIMIAKE;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int HAIHINFGJHI;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int AJCOCNMLLPA;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int CBJEPIBDJNM;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int IAGHBOMIHKG;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int LCMPPMBDOLI;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int KFABKBDABKE;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int IJMKJICFANK;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int NDKIMNLNKHP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int BHEDDGLILAC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int DDIADDBEGEA;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int FJIHMGHPJAP;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int EMJJJHOKECI;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int GCALLHGPCAC;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int KAAEJJHNLCG;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int AKDKKPOGHCC;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int NKCDBKPAHIN;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int GHFLMAKPNOM;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int BEEJAEHIOIP;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int DCCEOGGOBMC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int HKBGAGFBBDM;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly Vector3 DPOHECPBGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool FJKAGJIBFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool HLAMMLPDMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private bool BLAJJPFLGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool HFLDGPIBJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool HFGKLLLLAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Vector3 JLNLFPINMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private KBANNBMGJGE? HLPIAFCOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private CEGDCKHDECC? NFLIDGGOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private OBBNDEFFAJC POLMHPGDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private GKEHDNDBNEP JMFHDPLHEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private GIIBCNNAPEA PCADGFAPKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private GIIBCNNAPEA FELMHGCCLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private bool DDAKBKPELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x221")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool MHCEPFOPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly DOEOAOEMHHF IGJJFNPMIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly FGMICPHPGIN NIBNBHHONJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int CHFFKJEANBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float MGGDKLCMDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private GameObject GOPBEGEFOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform ILIFOJLCAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Transform HMLHBDKNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float ODMHMPJANLB;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker DKOGONAEJNL;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly ProfilerMarker HPMNPFKKHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private ProfilerMarker FKCAKJKFNMC;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker KDLOHKOABKC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker JJMCCKLHBCB;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker PFPKDEDDCJI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly List<CLIFKGDLKCL> EHMPFNFAMDE;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int HCEICCNCKBF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> GKEFNFDLJMJ;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int OOFGACJIAID;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int GJLOJKEGPFE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int BFKPCDCMIAD;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static int NECACDNKKLN;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static float GINIMEBBMFM;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int ODFFJJIBCAL;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float CIDFFICPMIC;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float NIHLDGKGBGD;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float BOPNOMJLJNM;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static float APBFOHDHBJA;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static DCMCMMLEHNC HBAFDLFPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float HKGIAMOLELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool AKEACJPKAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private float KPMFDKBHMAD;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion IGJHBFCBJMC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion COKCPFCJMII;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 NCBLJIEGPAB;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 MHFCGCEOPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PINPBFDHGNP IFNLHMOIPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private PINPBFDHGNP GNECLAHBGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private FLLPGFNEMKD OKNEOOFDHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private BEFAAFONJJI HFFMKCFAPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IDCGBCKGBFJ PNOCOMIOEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private float PMFJPDICHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly PDHJEBCHLDG OMPODAGHCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float HDLLMJCPBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float FENDKMBAPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Vector3 ADCEKPOLBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly BEFAAFONJJI NJNHEGAOADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly GHBCENONNHL BEJAJCONCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float DLCKFEEMKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private IDCGBCKGBFJ AEINOFLLBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private Vector3 KIJDADDJPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float CJACFKIEANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float DCFFOKDCNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly BEFAAFONJJI ANBMMADCLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly FLLPGFNEMKD FLPFHIKGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly BEFAAFONJJI EAGDPPAJMOF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BGECMLEGDCD MGAFGHMOJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BGECMLEGDCD DBFGHKFBGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration LEEEOGFHBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x680B6E0", Offset = "0x6809CE0", VA = "0x18680B6E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AvatarFullBodyConfiguration OKIOHEAHFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6816D10", Offset = "0x6815310", VA = "0x186816D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Transform LKDKGPNBLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6818530", Offset = "0x6816B30", VA = "0x186818530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform LEOMHIJIBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x680B300", Offset = "0x6809900", VA = "0x18680B300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private SkinnedMeshRenderer JPCPFIGHCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6817AD0", Offset = "0x68160D0", VA = "0x186817AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Renderer[] HJJGJIEHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x680EDD0", Offset = "0x680D3D0", VA = "0x18680EDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private GameObject[] DDLAPKNCFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x680BF30", Offset = "0x680A530", VA = "0x18680BF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private Animator OBKCMGFICNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6807C30", Offset = "0x6806230", VA = "0x186807C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private VRIK GAAMGBLHHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6810070", Offset = "0x680E670", VA = "0x186810070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private CMPPBAAMJMA AKMLHJOAKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6816C30", Offset = "0x6815230", VA = "0x186816C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private CMPPBAAMJMA KIDENPLCELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6815590", Offset = "0x6813B90", VA = "0x186815590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private CMPPBAAMJMA BLGJKFNDKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x680FD70", Offset = "0x680E370", VA = "0x18680FD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private CMPPBAAMJMA JDMDFIJLAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x680C3F0", Offset = "0x680A9F0", VA = "0x18680C3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private CMPPBAAMJMA IACKLJGCCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6807A20", Offset = "0x6806020", VA = "0x186807A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private CMPPBAAMJMA DPHJGGACDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6811D70", Offset = "0x6810370", VA = "0x186811D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private CMPPBAAMJMA PCBNLCLFBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6808EE0", Offset = "0x68074E0", VA = "0x186808EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private CMPPBAAMJMA OACFLDPILIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x680FB80", Offset = "0x680E180", VA = "0x18680FB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CEGDCKHDECC GILAOJOBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68086C0", Offset = "0x6806CC0", VA = "0x1868086C0", Slot = "32")]
		get
		{
			return default(CEGDCKHDECC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IIPFAIHICNK FJBMJAMFDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5B0", Offset = "0x8CCBB0", VA = "0x1808CE5B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public KFANBJCCOLL HOJDIEPCEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3C0", Offset = "0x8CC9C0", VA = "0x1808CE3C0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public KEOJJFEMGHE NMANJOKKMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB02430", Offset = "0xB00A30", VA = "0x180B02430", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public KEOJJFEMGHE IKOOOIOFKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB03F40", Offset = "0xB02540", VA = "0x180B03F40", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject INALOLPJOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6808FC0", Offset = "0x68075C0", VA = "0x186808FC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform CCBHEDIMNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x13DBE10", Offset = "0x13DA410", VA = "0x1813DBE10", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform MMOBACPCDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x13DD120", Offset = "0x13DB720", VA = "0x1813DD120", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Vector3 MCIPHIILBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6809620", Offset = "0x6807C20", VA = "0x186809620", Slot = "29")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float MDNCNCNIOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6807D10", Offset = "0x6806310", VA = "0x186807D10", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform AIKPGIKIEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6817C00", Offset = "0x6816200", VA = "0x186817C00", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private bool ECCKGDBIBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x68184D0", Offset = "0x6816AD0", VA = "0x1868184D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private bool IMIDJDDMEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x680EEB0", Offset = "0x680D4B0", VA = "0x18680EEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6809660", Offset = "0x6807C60", VA = "0x186809660")]
	private void EFFMKHFIMAL([In] AILLONLIOPL KJFHCCMMCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6808610", Offset = "0x6806C10", VA = "0x186808610")]
	private void BGCEHOPDLGN(AILLONLIOPL KJFHCCMMCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x680BD00", Offset = "0x680A300", VA = "0x18680BD00")]
	private void GBFAMFOABCH(NHNAPMDMKLL PBOHHLCAFNM, KEOJJFEMGHE DNEFBOPBALB, IKSolverVR.Arm PFJMIOJFJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x680D110", Offset = "0x680B710", VA = "0x18680D110")]
	private void HGPMIDDLJOD([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68197A0", Offset = "0x6817DA0", VA = "0x1868197A0")]
	public CLIFKGDLKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x680DA10", Offset = "0x680C010", VA = "0x18680DA10", Slot = "12")]
	public void HKOFMDOIPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x680E4C0", Offset = "0x680CAC0", VA = "0x18680E4C0", Slot = "13")]
	public void ICCFEIPIENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6811CA0", Offset = "0x68102A0", VA = "0x186811CA0", Slot = "14")]
	public void LJGLCFICHIP(bool DEOFCJPMPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x68088A0", Offset = "0x6806EA0", VA = "0x1868088A0", Slot = "22")]
	public Transform CGEFPHHPDED(string GGIILCEGNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6813F30", Offset = "0x6812530", VA = "0x186813F30", Slot = "23")]
	public Vector3? MAIIPBOOMJB(string GGIILCEGNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6816200", Offset = "0x6814800", VA = "0x186816200", Slot = "7")]
	public void NDFGILDEPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6816E50", Offset = "0x6815450", VA = "0x186816E50", Slot = "6")]
	public void OHOCMLGJCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6810000", Offset = "0x680E600", VA = "0x186810000", Slot = "8")]
	public void KBHAFJDGNNG(float DAFIFBHNPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6817BB0", Offset = "0x68161B0", VA = "0x186817BB0")]
	private void OOJJFJOIIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6812A70", Offset = "0x6811070", VA = "0x186812A70", Slot = "4")]
	public void LPOICOKCJJL(KBANNBMGJGE JEBLLDKLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68126A0", Offset = "0x6810CA0", VA = "0x1868126A0", Slot = "5")]
	public void LPNNNPNPPJO(CEGDCKHDECC GLPJLLPJKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x680B7C0", Offset = "0x6809DC0", VA = "0x18680B7C0", Slot = "11")]
	public void FKPIGLMGCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6816890", Offset = "0x6814E90", VA = "0x186816890", Slot = "21")]
	public void NMPKDNKBEMP([Out] Vector3 IHDDHDBEHPJ, [Out] Quaternion BAJBLBPFPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x680B2D0", Offset = "0x68098D0", VA = "0x18680B2D0")]
	private void FCCCHEDLOID([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x680BEB0", Offset = "0x680A4B0", VA = "0x18680BEB0", Slot = "24")]
	public void GCBMAJKFOJO(float NKJDAOJLGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x68087F0", Offset = "0x6806DF0", VA = "0x1868087F0", Slot = "25")]
	public HandLogicOffsets CFIHGLLKAND()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x680BBC0", Offset = "0x680A1C0", VA = "0x18680BBC0", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets FNGKAFKNOIJ()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x680C060", Offset = "0x680A660", VA = "0x18680C060")]
	private void GOJKEFHIOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x680DF60", Offset = "0x680C560", VA = "0x18680DF60")]
	private void HPFOHLIFHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6814210", Offset = "0x6812810", VA = "0x186814210")]
	private void MDKFFIDANLC(GMBPJONDGEK CHLNKNCOHNB, bool FFPHPJEJBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x680B140", Offset = "0x6809740", VA = "0x18680B140")]
	private void ENLJAAGMBLK(GMBPJONDGEK CHLNKNCOHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6812650", Offset = "0x6810C50", VA = "0x186812650")]
	public Vector3 LNPBCIIHPNI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x680DEF0", Offset = "0x680C4F0", VA = "0x18680DEF0")]
	private void HPEDPEEHJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x680FB60", Offset = "0x680E160", VA = "0x18680FB60")]
	private void IOFBDAHBIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6807D40", Offset = "0x6806340", VA = "0x186807D40")]
	private float BDPGCKKDCEB([In] AILLONLIOPL NGHALOPECFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6808E00", Offset = "0x6807400", VA = "0x186808E00")]
	private int DAAIBNELJKP([In] HNHGIGGCOEK LLBOGOPOIBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6814380", Offset = "0x6812980", VA = "0x186814380")]
	private void MGGAAPJMGIL(AILLONLIOPL KJFHCCMMCDL, bool DHFMFLIMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x680AF10", Offset = "0x6809510", VA = "0x18680AF10")]
	private static void ENLIMPJNCME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6815670", Offset = "0x6813C70", VA = "0x186815670")]
	private static void NCBFENOAHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x680E370", Offset = "0x680C970", VA = "0x18680E370")]
	private float IAPHHFDIPHF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6807C00", Offset = "0x6806200", VA = "0x186807C00")]
	private static int AFFJMLLCHLG(CLIFKGDLKCL KKEPMPAJLEA, CLIFKGDLKCL HIEMMBKCCDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x680C4D0", Offset = "0x680AAD0", VA = "0x18680C4D0")]
	private void HFMOOBBGCCK(AILLONLIOPL NGHALOPECFO, AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x680C010", Offset = "0x680A610", VA = "0x18680C010")]
	private float GKDGOPJJHDI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6811170", Offset = "0x680F770", VA = "0x186811170")]
	private void KNDKHDKJNJK([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x680C120", Offset = "0x680A720", VA = "0x18680C120")]
	private void HCJMINLPHED([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6809060", Offset = "0x6807660", VA = "0x186809060")]
	private void DFJNAENAMNH([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x680FE50", Offset = "0x680E450", VA = "0x18680FE50")]
	private void JLCFOHDKMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x680FC60", Offset = "0x680E260", VA = "0x18680FC60")]
	private void JBJKAEGPGGC([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6810150", Offset = "0x680E750", VA = "0x186810150")]
	private void KFHCPJBNEOB(GIIBCNNAPEA DNEFBOPBALB, IKSolverVR.Arm PFJMIOJFJCH, Transform FGNPBJHMCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x680BC80", Offset = "0x680A280", VA = "0x18680BC80")]
	private float FPBPHEHMPNN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x680E7B0", Offset = "0x680CDB0", VA = "0x18680E7B0")]
	private void IDPIEEHIAAB([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x680B8B0", Offset = "0x6809EB0", VA = "0x18680B8B0", Slot = "33")]
	protected virtual void FMFFGMGNPDD([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6810B50", Offset = "0x680F150", VA = "0x186810B50")]
	private void KJIHBFHBADD([In] AILLONLIOPL NGHALOPECFO, [In] MKJGPPHPMCI EPHCOJEEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6814F40", Offset = "0x6813540", VA = "0x186814F40")]
	private void MJPDBEDLCAE(AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6818D60", Offset = "0x6817360", VA = "0x186818D60")]
	private void PPGMHFKECAI(IDCGBCKGBFJ ICDFCJEPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x680F940", Offset = "0x680DF40", VA = "0x18680F940")]
	private void IOAFJMFMIFJ(float DMJHHOKIICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6818610", Offset = "0x6816C10", VA = "0x186818610")]
	private void PPFNMGHDKME([In] AILLONLIOPL NGHALOPECFO, MKJGPPHPMCI EPHCOJEEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x680D550", Offset = "0x680BB50", VA = "0x18680D550")]
	private Vector3 HGPNNPJLMOD([In] AILLONLIOPL NGHALOPECFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x680DE20", Offset = "0x680C420", VA = "0x18680DE20")]
	private void HNCFEHLLMKK([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x680AB20", Offset = "0x6809120", VA = "0x18680AB20")]
	private float EHOCHPAKBJC(float LDFACAKBPNJ, [In] AILLONLIOPL NGHALOPECFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6814F20", Offset = "0x6813520", VA = "0x186814F20")]
	private void MIOMCCCGFAD(IDCGBCKGBFJ ICDFCJEPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x68140C0", Offset = "0x68126C0", VA = "0x1868140C0")]
	private void MBENMNEDGDD(float LDFACAKBPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x68148B0", Offset = "0x6812EB0", VA = "0x1868148B0")]
	private void MHNFNDEEIPH([In] AILLONLIOPL NGHALOPECFO, MKJGPPHPMCI EPHCOJEEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x68089F0", Offset = "0x6806FF0", VA = "0x1868089F0")]
	private float CKKMOOLFMHI([In] AILLONLIOPL KJFHCCMMCDL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x680EF30", Offset = "0x680D530", VA = "0x18680EF30")]
	private void ILBKLEGMBBL(AILLONLIOPL NGHALOPECFO, MKJGPPHPMCI EPHCOJEEPMK, Vector3 MMHHLGLGJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x680B3E0", Offset = "0x68099E0", VA = "0x18680B3E0")]
	private static void FEELMFJEIGE(Transform DNPKMJFBJBC, Quaternion ADNGPFKNGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6815290", Offset = "0x6813890", VA = "0x186815290")]
	private void MKCEOAHEGLH([In] AILLONLIOPL EJGFFDKGCAF, [In] HNHGIGGCOEK LLBOGOPOIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x68115A0", Offset = "0x680FBA0", VA = "0x1868115A0")]
	private void LGGIHJAOGDB([In] AILLONLIOPL EJGFFDKGCAF, [In] HNHGIGGCOEK LLBOGOPOIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x680B590", Offset = "0x6809B90", VA = "0x18680B590")]
	public void FGEOENPDICK([In] AILLONLIOPL NGHALOPECFO, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x68103E0", Offset = "0x680E9E0", VA = "0x1868103E0")]
	private void KILGMIDGFMA([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6818320", Offset = "0x6816920", VA = "0x186818320")]
	private void PFDFHDGHFKK(float JPBKKFNHKCC, [In] AILLONLIOPL KJFHCCMMCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6807EE0", Offset = "0x68064E0", VA = "0x186807EE0")]
	private float BFILJILFCMC([In] AILLONLIOPL KJFHCCMMCDL, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6817C60", Offset = "0x6816260", VA = "0x186817C60")]
	private void PCJPACIKKLE([In] AILLONLIOPL KJFHCCMMCDL, [In] AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x680F450", Offset = "0x680DA50", VA = "0x18680F450")]
	private void ILJAPPDLKAO([In] AILLONLIOPL KJFHCCMMCDL, float LKKBPGMNBJE, float FAJOFICAJNL, Vector3 HMNDPPMBANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6811E50", Offset = "0x6810450", VA = "0x186811E50")]
	private void LNMDHHJGMHL(AILLONLIOPL KJFHCCMMCDL, AvatarFullBodyConfiguration FFADDNJMIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6807B00", Offset = "0x6806100", VA = "0x186807B00")]
	[CompilerGenerated]
	internal static bool AEEAAPECDOB(IKSolverVR.Arm PFJMIOJFJCH, CJJPNJPONEO JKIDPFKKIBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6810710", Offset = "0x680ED10", VA = "0x186810710")]
	[CompilerGenerated]
	internal static float KIPNLMGMJKB(Vector3 LKBDILAAHNA, Vector3 MFOOBAHGEKC, Vector3 FDIKGBKIKDH, AILLONLIOPL KJFHCCMMCDL, AvatarFullBodyConfiguration FFADDNJMIIP, float ANNLKNNLIGI)
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
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private GLFEEPNCONO handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6804820", Offset = "0x6802E20", VA = "0x186804820")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68047E0", Offset = "0x6802DE0", VA = "0x1868047E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68041B0", Offset = "0x68027B0", VA = "0x1868041B0")]
		private void DNBKJLMCCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x67CB2B0", Offset = "0x67C98B0", VA = "0x1867CB2B0", Slot = "4")]
		public void SetEnabled(bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6804850", Offset = "0x6802E50", VA = "0x186804850")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, CMPPBAAMJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Vector3 MLJIIOHOBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Vector3 DFMDIOBNPCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3 OBHLFIKMOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Matrix4x4 EGEMLLHGCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private bool LCHNCOECOIP;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6804CF0", Offset = "0x68032F0", VA = "0x186804CF0", Slot = "4")]
		public void UpdateController(float DGOHALMDCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6804CE0", Offset = "0x68032E0", VA = "0x186804CE0", Slot = "6")]
		public void SetEnabled(bool CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6804880", Offset = "0x6802E80", VA = "0x186804880")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x68053B0", Offset = "0x68039B0", VA = "0x1868053B0")]
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
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Dictionary<string, HDMELEDKJMC> NJODHBOMMJI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GHHDKCJNKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6819F20", Offset = "0x6818520", VA = "0x186819F20")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.None)]
	private static void KMIBGBLECLK(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6819D60", Offset = "0x6818360", VA = "0x186819D60", Slot = "4")]
	public HDMELEDKJMC FLBJBKMGHFK(string GGKICEPNPHD, AvatarSystemConfiguration LOGLAMBNPJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6819BE0", Offset = "0x68181E0", VA = "0x186819BE0", Slot = "5")]
	public void EDAPOJBFKNO(string GGKICEPNPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6819F90", Offset = "0x6818590", VA = "0x186819F90")]
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
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private Dictionary<string, Transform> MFAFHBNNJCH;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public bool DFLAHLKBLGO
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x681AEB0", Offset = "0x68194B0", VA = "0x18681AEB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x681AF40", Offset = "0x6819540", VA = "0x18681AF40")]
			public void MODBFAFEFEE(VRIK IIEELMMCHNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
			public void JPDINLNHIBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x681AEF0", Offset = "0x68194F0", VA = "0x18681AEF0")]
			public void FDHFDDAAOOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x681B070", Offset = "0x6819670", VA = "0x18681B070")]
			public LDPJHICOAJO()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		[NPPPEBEMIFD(CKKEEFADMDD.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[AIILLFBIOKD(CKKEEFADMDD.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly LDPJHICOAJO OPBKANGDCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private JOONONOGMAB FDKEILFALOM;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x68053C0", Offset = "0x68039C0", VA = "0x1868053C0")]
		private void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6805680", Offset = "0x6803C80", VA = "0x186805680")]
		private bool HOCBEGLCMEC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x68056D0", Offset = "0x6803CD0", VA = "0x1868056D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6805740", Offset = "0x6803D40", VA = "0x186805740")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68056E0", Offset = "0x6803CE0", VA = "0x1868056E0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6805930", Offset = "0x6803F30", VA = "0x186805930")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x681C2F0", Offset = "0x681A8F0", VA = "0x18681C2F0", Slot = "4")]
		public override void OnStateEnter(Animator IIKEFOKPPGC, AnimatorStateInfo NDLGBAIPFMI, int KKIKIMABCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x681C460", Offset = "0x681AA60", VA = "0x18681C460")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal abstract class MKFNHDCPGLD<TInput, TOutput> : PGLHILCHENG<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected readonly DNHLKDIIFLB BNNGHMOAPNI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x44D5200", Offset = "0x44D3800", VA = "0x1844D5200")]
	protected MKFNHDCPGLD(DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput JGNOLJBBCJA(TInput CPEKGDIIDKL, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x44D5160", Offset = "0x44D3760", VA = "0x1844D5160", Slot = "5")]
	public bool DOGJEPGJOGH(TInput CPEKGDIIDKL, [Out] TOutput? HJBJAPKPPFA, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[LEDNJNPECJC]
public static class BAHNFDLNPGO
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly Regex AKIBOABIEAJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6805AC0", Offset = "0x68040C0", VA = "0x186805AC0")]
	public static EPBAMAOALIM EFGJGBLAKGC(AJKMIEONCMG DILOBOGMJEO, ENHFLJGMKFD CDPDFJELCCD, Guid? HOMBKAMBMCA, Color? OCIFBODPGIK, CFGFGPACPAK CNCOCPFNBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6805A10", Offset = "0x6804010", VA = "0x186805A10")]
	public static MMILDBOFIKL AOABHHGKJBH(EPBAMAOALIM FHNKDHIILBL)
	{
		return default(MMILDBOFIKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x28A66C0", Offset = "0x28A4CC0", VA = "0x1828A66C0")]
	internal static TModern? IPFGGPDLLPC<TModern>(string? CPEKGDIIDKL, FMGJFHCBAGJ<TModern> ALGLLIDCCHE, DNHLKDIIFLB BNNGHMOAPNI, LNFJMOJINMA EPIJIABJEPC, TModern LAFKPOMBBJD) where TModern : struct, FOOBKOEHCJF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x28A7D10", Offset = "0x28A6310", VA = "0x1828A7D10")]
	internal static FHMOFBOMCOC MKJKBAEODMA<TModern>(string? CPEKGDIIDKL, FMGJFHCBAGJ<TModern> ALGLLIDCCHE, DNHLKDIIFLB BNNGHMOAPNI, LNFJMOJINMA EPIJIABJEPC, TModern LAFKPOMBBJD) where TModern : struct, FOOBKOEHCJF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6805CD0", Offset = "0x68042D0", VA = "0x186805CD0")]
	internal static List<GKMGBKADAJN> NCENLDCKAKA(IEnumerable<PCEKBJHFJHE>? HJBBNJNFBIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x28A8520", Offset = "0x28A6B20", VA = "0x1828A8520")]
	internal static string PIJCMJKLIKM<TModern>(TModern CPEKGDIIDKL, FMGJFHCBAGJ<TModern> ALGLLIDCCHE, DNHLKDIIFLB BNNGHMOAPNI) where TModern : FOOBKOEHCJF
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FFFGIKFKFIL : HDIFBPINGMN
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public PGLHILCHENG<OJNLLGMGBIP, DGKNAIDPAJD> KKPGGJJPIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> GPBCENPKHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> MGOPAFEOMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MFNBAKPHICN GMOBAOFGIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KIKIMFIPLCP BLKGKGOPLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x681A020", Offset = "0x6818620", VA = "0x18681A020")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void ELKKFCJLAAD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x681A090", Offset = "0x6818690", VA = "0x18681A090")]
	[Preserve]
	internal FFFGIKFKFIL([JFHFHOOOEKP("UnitySerialization")] DAOBIGDGLOO KPHHFEIJHFB, [JFHFHOOOEKP(null)] LAAMNMEBFLF BNAJHALNKBG, [JFHFHOOOEKP(null)] DNHLKDIIFLB BNNGHMOAPNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum NPGINAOIGJO
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NHBNLADEFNO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6825C30", Offset = "0x6824230", VA = "0x186825C30")]
	public NHBNLADEFNO(string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6825B90", Offset = "0x6824190", VA = "0x186825B90")]
	public NHBNLADEFNO(string NFOHONOFFAP, Exception EEOIAMFNMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6825C00", Offset = "0x6824200", VA = "0x186825C00")]
	public NHBNLADEFNO(NPGINAOIGJO KEFHKMFECFI, string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6825BC0", Offset = "0x68241C0", VA = "0x186825BC0")]
	public NHBNLADEFNO(NPGINAOIGJO KEFHKMFECFI, string NFOHONOFFAP, Exception EEOIAMFNMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class HCFAJMEHKJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly DAOBIGDGLOO KPHHFEIJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly LAAMNMEBFLF BNAJHALNKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly DNHLKDIIFLB BNNGHMOAPNI;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6823010", Offset = "0x6821610", VA = "0x186823010")]
	protected HCFAJMEHKJG(DAOBIGDGLOO KPHHFEIJHFB, LAAMNMEBFLF BNAJHALNKBG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6821D00", Offset = "0x6820300", VA = "0x186821D00")]
	protected string GKMINIFMDBB(DGKNAIDPAJD BMIPHJFPOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6821660", Offset = "0x681FC60", VA = "0x186821660")]
	protected string AFOGBCCBMHH(DGKNAIDPAJD BMIPHJFPOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6821990", Offset = "0x681FF90", VA = "0x186821990")]
	private AvatarOutfitSelectionData EFGJGBLAKGC(EPBAMAOALIM COHLHCBLMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6821850", Offset = "0x681FE50", VA = "0x186821850")]
	private static AvatarCustomizationSettingsData.AnchorParams BCCCJAFFOAM(MPNIGMOKBGH? GAILDDGHHLF)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PGLHILCHENG<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput JGNOLJBBCJA(TInput CPEKGDIIDKL, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOGJEPGJOGH(TInput CPEKGDIIDKL, [Out] TOutput? HJBJAPKPPFA, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HDIFBPINGMN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	PGLHILCHENG<OJNLLGMGBIP, DGKNAIDPAJD> KKPGGJJPIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> MGOPAFEOMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MFNBAKPHICN GMOBAOFGIDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal enum LNFJMOJINMA
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KIKIMFIPLCP
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APEJHCDIBGK KLDBPIDHOEH(DGKNAIDPAJD FHNKDHIILBL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface MFNBAKPHICN
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GAJOGHLFFIO KLDBPIDHOEH(DGKNAIDPAJD FHNKDHIILBL, int PELKODHFFGF, string? LCLKDNPLMED, string? AHGIJDBMKEJ, GOCILOCPHNM HBGFNCNPMFK, List<GKMGBKADAJN>? MNBBNGOOGMB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[LEDNJNPECJC]
internal class MIFMKBIGLEA : MKFNHDCPGLD<OJNLLGMGBIP, DGKNAIDPAJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly LAAMNMEBFLF BNAJHALNKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly EGBFOEJAPIN GAOCOAEAPIJ;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x68253C0", Offset = "0x68239C0", VA = "0x1868253C0")]
	public MIFMKBIGLEA(DAOBIGDGLOO KPHHFEIJHFB, LAAMNMEBFLF BNAJHALNKBG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6825110", Offset = "0x6823710", VA = "0x186825110", Slot = "6")]
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
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x68232B0", Offset = "0x68218B0", VA = "0x1868232B0", Slot = "9")]
		public override void WriteJson(JsonWriter OGONFGJBIBI, FHMOFBOMCOC? CBAEIEAPLIH, JsonSerializer AABBBPHCHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6823190", Offset = "0x6821790", VA = "0x186823190", Slot = "10")]
		public override FHMOFBOMCOC ReadJson(JsonReader DHKLMNOOPAJ, Type MDFBEPCIDHL, FHMOFBOMCOC? GLHAJCLPPCD, bool HFNKLKJPFOO, JsonSerializer AABBBPHCHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6823350", Offset = "0x6821950", VA = "0x186823350")]
		public LBMOBAPLGAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class ODENPHMFIDI : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool EAECKJBAICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x68264C0", Offset = "0x6824AC0", VA = "0x1868264C0", Slot = "5")]
		public override object ReadJson(JsonReader DHKLMNOOPAJ, Type MDFBEPCIDHL, object? GLHAJCLPPCD, JsonSerializer AABBBPHCHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6826100", Offset = "0x6824700", VA = "0x186826100", Slot = "6")]
		public override bool CanConvert(Type MDFBEPCIDHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6826520", Offset = "0x6824B20", VA = "0x186826520", Slot = "4")]
		public override void WriteJson(JsonWriter OGONFGJBIBI, object? CBAEIEAPLIH, JsonSerializer AABBBPHCHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x68262E0", Offset = "0x68248E0", VA = "0x1868262E0")]
		private static bool GGBBIFBHAOA(object CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
		public ODENPHMFIDI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly JsonSerializerSettings NJGBEKGEHCO;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6825A30", Offset = "0x6824030", VA = "0x186825A30")]
	internal NCEHOAOBNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2C66F70", Offset = "0x2C65570", VA = "0x182C66F70", Slot = "4")]
	public string MHOIPFCLCJO<T>(T HBFCGFKGCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2C66EE0", Offset = "0x2C654E0", VA = "0x182C66EE0", Slot = "5")]
	public T FDCBALDOPKI<T>(string CBAEIEAPLIH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class HBENEBKFNNC : DAOBIGDGLOO
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2B06440", Offset = "0x2B04A40", VA = "0x182B06440", Slot = "4")]
	public string MHOIPFCLCJO<T>(T HBFCGFKGCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2B063C0", Offset = "0x2B049C0", VA = "0x182B063C0", Slot = "5")]
	public T FDCBALDOPKI<T>(string CBAEIEAPLIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public HBENEBKFNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[LEDNJNPECJC]
internal class EGBFOEJAPIN : MKFNHDCPGLD<GAJOGHLFFIO, ALHKOGGDKHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly DAOBIGDGLOO KPHHFEIJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly LAAMNMEBFLF BNAJHALNKBG;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6821520", Offset = "0x681FB20", VA = "0x186821520")]
	public EGBFOEJAPIN(DAOBIGDGLOO KPHHFEIJHFB, LAAMNMEBFLF BNAJHALNKBG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x68209D0", Offset = "0x681EFD0", VA = "0x1868209D0", Slot = "6")]
	public override ALHKOGGDKHM JGNOLJBBCJA(GAJOGHLFFIO CPEKGDIIDKL, [Out] IReadOnlyList<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6820590", Offset = "0x681EB90", VA = "0x186820590")]
	internal void HBDLBJLJHDC(string IGKJHHNIPKB, DGKNAIDPAJD BMIPHJFPOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6821470", Offset = "0x681FA70", VA = "0x186821470")]
	public IEnumerable<EPBAMAOALIM> LGMLNBGNEMG(string OCONBJGLBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6820160", Offset = "0x681E760", VA = "0x186820160")]
	private IEnumerable<EPBAMAOALIM> GDKDGBBONIC(string OCONBJGLBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6820E00", Offset = "0x681F400", VA = "0x186820E00")]
	internal IEnumerable<EPBAMAOALIM> JHODOHEPOMN(string OCONBJGLBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x681F390", Offset = "0x681D990", VA = "0x18681F390")]
	private EPBAMAOALIM CCILJPGFBJD(AvatarOutfitSelectionData KCBHMGILKGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x681F8C0", Offset = "0x681DEC0", VA = "0x18681F8C0")]
	private void FAKCPEMJDLA(AvatarCustomizationSettingsData MPMBGMHOEAE, DGKNAIDPAJD BMIPHJFPOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x681F020", Offset = "0x681D620", VA = "0x18681F020")]
	private EPBAMAOALIM CCILJPGFBJD(string KIMCGNFAMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x68206F0", Offset = "0x681ECF0", VA = "0x1868206F0")]
	internal static (CFGFGPACPAK, string, string) JDEBDBFGNMI(string KIMCGNFAMJH, DNHLKDIIFLB BNNGHMOAPNI)
	{
		return default((CFGFGPACPAK, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6821270", Offset = "0x681F870", VA = "0x186821270")]
	private ACIKNKLFGHF? KPGICAJMFCJ(string? NNFEKLKANBO, Vector2 KCKFECPEICH, float NKLJGNMFDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x681F760", Offset = "0x681DD60", VA = "0x18681F760")]
	private static MPNIGMOKBGH EHFNNLGANCD(AvatarCustomizationSettingsData.AnchorParams NPODIKEHINJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LEDNJNPECJC]
internal class PNEBEFPNKCJ : HCFAJMEHKJG, KIKIMFIPLCP
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6823010", Offset = "0x6821610", VA = "0x186823010")]
	public PNEBEFPNKCJ(DAOBIGDGLOO KPHHFEIJHFB, LAAMNMEBFLF BNAJHALNKBG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x68269C0", Offset = "0x6824FC0", VA = "0x1868269C0", Slot = "4")]
	public APEJHCDIBGK KLDBPIDHOEH(DGKNAIDPAJD FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x68268C0", Offset = "0x6824EC0", VA = "0x1868268C0")]
	private string GKMKBJALCGG(DGKNAIDPAJD BMIPHJFPOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6826600", Offset = "0x6824C00", VA = "0x186826600")]
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
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly DAOBIGDGLOO KPHHFEIJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> EKBAJJFDLCG;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x681EF20", Offset = "0x681D520", VA = "0x18681EF20")]
	public DPAPIEHPICD(PGLHILCHENG<GAJOGHLFFIO, ALHKOGGDKHM> EKBAJJFDLCG, DNHLKDIIFLB BNNGHMOAPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x681EAF0", Offset = "0x681D0F0", VA = "0x18681EAF0", Slot = "6")]
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
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly DAOBIGDGLOO KPHHFEIJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly KIKIMFIPLCP LFHNLMKIIDH;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6826010", Offset = "0x6824610", VA = "0x186826010")]
	public NJKEFKDLKHO(KIKIMFIPLCP LFHNLMKIIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6825C60", Offset = "0x6824260", VA = "0x186825C60", Slot = "4")]
	public GAJOGHLFFIO KLDBPIDHOEH(DGKNAIDPAJD FHNKDHIILBL, int PELKODHFFGF, string? LCLKDNPLMED, string? AHGIJDBMKEJ, GOCILOCPHNM HBGFNCNPMFK, List<GKMGBKADAJN>? MNBBNGOOGMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Preserve]
internal class LGMNDELPNIE : LJBINCFCALP
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly Vector2 PNBNHFDCIJG;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly Vector2 LKJDNIGFELI;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static readonly Vector2 OBADMEAGDLL;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly Vector2 MLLEKJNDPEL;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly Vector2 OJOICHDEOCO;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly Vector2 HMHPGNMOGIG;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly Vector2 JNNGLNOBCFL;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly Vector2 APEHIOMCCMJ;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly Vector2 GPFKOLMEFLG;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static readonly Vector2 JIFAAKAHOGG;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static readonly Vector2 CGLKHDKNHLN;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly Vector2 HKBODBNIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private Dictionary<PKLKNBHIDDA, AvatarConfiguration> OJPOHPBHHIF;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6824810", Offset = "0x6822E10", VA = "0x186824810")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.None)]
	private static void OBOFKHCDFNO(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6825060", Offset = "0x6823660", VA = "0x186825060")]
	[Preserve]
	internal LGMNDELPNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x68241E0", Offset = "0x68227E0", VA = "0x1868241E0", Slot = "4")]
	public Vector2 IBMENODALHH(FaceFeatureType CDPIIJCPHBI, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6823CE0", Offset = "0x68222E0", VA = "0x186823CE0", Slot = "5")]
	public float GFKPNLCMBLC(FaceFeatureType CDPIIJCPHBI, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6824910", Offset = "0x6822F10", VA = "0x186824910", Slot = "6")]
	public void OIKOMOHFMMJ(PKLKNBHIDDA LHEGLCAAFHK, AvatarConfiguration LOGLAMBNPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6824700", Offset = "0x6822D00", VA = "0x186824700", Slot = "7")]
	public float NEFLPIHADEG(FaceFeatureType NIFKLDNIBPI, float BGBANMEEMGD, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6823D60", Offset = "0x6822360", VA = "0x186823D60", Slot = "8")]
	public float GMMPMHJHEEI(FaceFeatureType NIFKLDNIBPI, float NKLJGNMFDCD, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6823B30", Offset = "0x6822130", VA = "0x186823B30", Slot = "10")]
	public Vector2 GDFCJCNMCJM(FaceFeatureType NIFKLDNIBPI, Vector2 NLOAKGCNEMF, Vector2 FABJGBLGIHK, Vector2 IBBEBMMMLKP, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x68237C0", Offset = "0x6821DC0", VA = "0x1868237C0", Slot = "9")]
	public Vector2 EPNACMGMDMG(FaceFeatureType NIFKLDNIBPI, Vector2 LLFCCOMMMGN, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6824660", Offset = "0x6822C60", VA = "0x186824660")]
	private Vector2 NBPOIFDFIEL(FaceFeatureType NIFKLDNIBPI, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6823F30", Offset = "0x6822530", VA = "0x186823F30")]
	private Vector2 HPCGLAJHNPN(FaceFeatureType NIFKLDNIBPI, Vector2 NLOAKGCNEMF, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6824A00", Offset = "0x6823000", VA = "0x186824A00", Slot = "11")]
	public Vector2 PIKGGDCCGOD(FaceFeatureType NIFKLDNIBPI, Vector2 LLFCCOMMMGN, Vector2 FABJGBLGIHK, Vector2 IBBEBMMMLKP, PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x68234F0", Offset = "0x6821AF0", VA = "0x1868234F0")]
	private float DIFDNEONLHF(float MDCIOHOLJPO, float HGPGLPENOMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6823390", Offset = "0x6821990", VA = "0x186823390")]
	private Vector2 BGJLCDJIHJM(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6823660", Offset = "0x6821C60", VA = "0x186823660")]
	private Vector2 DONJDEFHKHL(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6824980", Offset = "0x6822F80", VA = "0x186824980")]
	private Vector2 OJDGAEDHIEM(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6824080", Offset = "0x6822680", VA = "0x186824080")]
	private Vector2 IAEPKJIIEPH(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x68239F0", Offset = "0x6821FF0", VA = "0x1868239F0")]
	private float FBLFIBMNHDJ(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6824420", Offset = "0x6822A20", VA = "0x186824420")]
	private float IMIOEHFPPBH(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6824540", Offset = "0x6822B40", VA = "0x186824540")]
	private float JJNGGLDJGIL(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6823AF0", Offset = "0x68220F0", VA = "0x186823AF0")]
	private float FPDCGENFHKO(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6824340", Offset = "0x6822940", VA = "0x186824340")]
	private Vector2 IIAMPCOKKHI(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6824460", Offset = "0x6822A60", VA = "0x186824460")]
	private Vector2 JEKCCHAKNGH(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68236E0", Offset = "0x6821CE0", VA = "0x1868236E0")]
	private Vector2 EGKBKPMKINI(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6823580", Offset = "0x6821B80", VA = "0x186823580")]
	private Vector2 DMENMFBOFOK(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6824100", Offset = "0x6822700", VA = "0x186824100")]
	private Vector2 IAFEANBGLLN(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6824580", Offset = "0x6822B80", VA = "0x186824580")]
	private Vector2 MJJOEJFBBCD(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6823D90", Offset = "0x6822390", VA = "0x186823D90")]
	private Vector2 HLPBLEJOCHG(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6823410", Offset = "0x6821A10", VA = "0x186823410")]
	private Vector2 BJDKIHLKBMB(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6824730", Offset = "0x6822D30", VA = "0x186824730")]
	private Vector2 OAIGFAGJEOC(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6823E70", Offset = "0x6822470", VA = "0x186823E70")]
	private Vector2 HMKMBFLDCGM(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6823A30", Offset = "0x6822030", VA = "0x186823A30")]
	private Vector2 FEBFILLDPJI(PKLKNBHIDDA LHEGLCAAFHK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6824D90", Offset = "0x6823390", VA = "0x186824D90")]
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
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x681E170", Offset = "0x681C770", VA = "0x18681E170")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MNBGIFEELEI
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6825600", Offset = "0x6823C00", VA = "0x186825600")]
	public static MMILDBOFIKL JGNOLJBBCJA(this MFBAFFGNDHK FHNKDHIILBL)
	{
		return default(MMILDBOFIKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6825880", Offset = "0x6823E80", VA = "0x186825880")]
	public static MFBAFFGNDHK KLDBPIDHOEH(this MMILDBOFIKL PCOOLHMNJLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6825590", Offset = "0x6823B90", VA = "0x186825590")]
	public static bool BPHCFLFLDPC(this MMILDBOFIKL PCOOLHMNJLA)
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
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4C94E50", Offset = "0x4C93450", VA = "0x184C94E50")]
			public AnchorParams(Vector2 NLOAKGCNEMF, Vector3 FPDAAEPPIEJ, Vector3 DIPLBFGLHMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x681E0C0", Offset = "0x681C6C0", VA = "0x18681E0C0")]
			internal MPNIGMOKBGH KLDBPIDHOEH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private ILADNPKLBOP useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x681E990", Offset = "0x681CF90", VA = "0x18681E990")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x864DF0", Offset = "0x8633F0", VA = "0x180864DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x44F2740", Offset = "0x44F0D40", VA = "0x1844F2740")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x107B940", Offset = "0x1079F40", VA = "0x18107B940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8CDDF0", Offset = "0x8CC3F0", VA = "0x1808CDDF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9DCFA0", Offset = "0x9DB5A0", VA = "0x1809DCFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x865800", Offset = "0x863E00", VA = "0x180865800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x681EA40", Offset = "0x681D040", VA = "0x18681EA40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x86DFE0", Offset = "0x86C5E0", VA = "0x18086DFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8CDDA0", Offset = "0x8CC3A0", VA = "0x1808CDDA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x10872A0", Offset = "0x10858A0", VA = "0x1810872A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x868A50", Offset = "0x867050", VA = "0x180868A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x681EA80", Offset = "0x681D080", VA = "0x18681EA80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1C95510", Offset = "0x1C93B10", VA = "0x181C95510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8CE480", Offset = "0x8CCA80", VA = "0x1808CE480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xE9D620", Offset = "0xE9BC20", VA = "0x180E9D620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x863E00", Offset = "0x862400", VA = "0x180863E00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x863DE0", Offset = "0x8623E0", VA = "0x180863DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x41A2FE0", Offset = "0x41A15E0", VA = "0x1841A2FE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1CC0370", Offset = "0x1CBE970", VA = "0x181CC0370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x898D60", Offset = "0x897360", VA = "0x180898D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x898DC0", Offset = "0x8973C0", VA = "0x180898DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x868A10", Offset = "0x867010", VA = "0x180868A10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x868B10", Offset = "0x867110", VA = "0x180868B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x868AA0", Offset = "0x8670A0", VA = "0x180868AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x868AC0", Offset = "0x8670C0", VA = "0x180868AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8689D0", Offset = "0x866FD0", VA = "0x1808689D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8689F0", Offset = "0x866FF0", VA = "0x1808689F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9CB870", Offset = "0x9C9E70", VA = "0x1809CB870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9F3F40", Offset = "0x9F2540", VA = "0x1809F3F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x868A30", Offset = "0x867030", VA = "0x180868A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x868930", Offset = "0x866F30", VA = "0x180868930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9F18C0", Offset = "0x9EFEC0", VA = "0x1809F18C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9D08B0", Offset = "0x9CEEB0", VA = "0x1809D08B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x86F650", Offset = "0x86DC50", VA = "0x18086F650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x86F5D0", Offset = "0x86DBD0", VA = "0x18086F5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB94710", Offset = "0xB92D10", VA = "0x180B94710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB9C700", Offset = "0xB9AD00", VA = "0x180B9C700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA44F70", Offset = "0xA43570", VA = "0x180A44F70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xD26ED0", Offset = "0xD254D0", VA = "0x180D26ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ILADNPKLBOP UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1D5BB00", Offset = "0x1D5A100", VA = "0x181D5BB00")]
			get
			{
				return default(ILADNPKLBOP);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1D5DD50", Offset = "0x1D5C350", VA = "0x181D5DD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA75590", Offset = "0xA73B90", VA = "0x180A75590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA739A0", Offset = "0xA71FA0", VA = "0x180A739A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x681EA60", Offset = "0x681D060", VA = "0x18681EA60")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x681EAA0", Offset = "0x681D0A0", VA = "0x18681EAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x681E5F0", Offset = "0x681CBF0", VA = "0x18681E5F0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public CFGFGPACPAK BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private BHFPKMDNKBO? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x681EAC0", Offset = "0x681D0C0", VA = "0x18681EAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
