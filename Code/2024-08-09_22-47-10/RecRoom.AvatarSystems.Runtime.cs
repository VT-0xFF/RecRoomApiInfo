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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B9EC0", Offset = "0x67B92C0", VA = "0x1867B9EC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[NIMGPLGMLPL]
internal class NIMPOILADEB : MBAJMGKNFMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct MHCJKOKOGEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NIMPOILADEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public DBODHIJMFKE avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AHEEKBGNEGI EJPAFDAMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HLDKCOHODNI EDFOBJGFHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BCGADLKLNIG HCAPPJIMDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly OEKGLDJIPCK PGNHBFCLCJN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67B9B80", Offset = "0x67B8F80", VA = "0x1867B9B80")]
	[EAMANMFIEOM(LALOBMMKLJJ.Root, NBICBCAKHEI.GameOnly)]
	[UsedImplicitly]
	private static void PAFCJLAHAKN(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67B9CD0", Offset = "0x67B90D0", VA = "0x1867B9CD0")]
	[Preserve]
	internal NIMPOILADEB([NCPIDBJOPHL(null)] AHEEKBGNEGI EJPAFDAMCKO, [NCPIDBJOPHL(null)] HLDKCOHODNI EDFOBJGFHPL, [NCPIDBJOPHL(null)] BCGADLKLNIG HCAPPJIMDPN, [NCPIDBJOPHL(null)] OEKGLDJIPCK PGNHBFCLCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67B8950", Offset = "0x67B7D50", VA = "0x1867B8950", Slot = "5")]
	public GCLNOLIGGFH JMCLPCABHEJ(DBODHIJMFKE MCNAHMPHBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67B9120", Offset = "0x67B8520", VA = "0x1867B9120", Slot = "4")]
	public GCLNOLIGGFH OADEDNPJHAM(DBODHIJMFKE MCNAHMPHBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67B87B0", Offset = "0x67B7BB0", VA = "0x1867B87B0", Slot = "6")]
	public PLHCOMNHOME EHPGAGDAJGO(GCLNOLIGGFH LDNEPNAGEGN, int LLCPIKPJEFE, string? FIKHOKLHCII, string? NNLJDDEEOND, CEHEBDFBLFJ POHKOLGMMBG, List<EFKHLHPELON>? CHFJOLMLFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67B9AF0", Offset = "0x67B8EF0", VA = "0x1867B9AF0", Slot = "7")]
	public bool OBEDPLKLFEG(FAFHFIMHHOA PLMEENDJJJM, [Out] GCLNOLIGGFH? MGJIAIBPJOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67B9BF0", Offset = "0x67B8FF0", VA = "0x1867B9BF0", Slot = "8")]
	public bool PFIGJKCIHDD(PLHCOMNHOME DFKIBCEBANI, [Out] GCLNOLIGGFH? MGJIAIBPJOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67B88C0", Offset = "0x67B7CC0", VA = "0x1867B88C0", Slot = "9")]
	public bool HKAOFFFNIIO(PLHCOMNHOME DFKIBCEBANI, [Out] OEKMIFOBLEJ? PLMEENDJJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6BC0", Offset = "0x2CE5FC0", VA = "0x182CE6BC0")]
	private bool OEEDDBHCECH<TInput, TOutput>(TInput BCPLMINPIEH, IIHGPJNDNAJ<TInput, TOutput> JIHEBNFJFGL, [Out] TOutput? LLANANCGECL) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67B8600", Offset = "0x67B7A00", VA = "0x1867B8600")]
	[CompilerGenerated]
	private PCBOBJFNCEM EBBEMLGDIBI(FaceFeatureType ACKMKCCLCON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67B8320", Offset = "0x67B7720", VA = "0x1867B8320")]
	[CompilerGenerated]
	private PCBOBJFNCEM CKNJBNFGFPG(FaceFeatureType ACKMKCCLCON, MHCJKOKOGEO P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NIMGPLGMLPL]
internal class MDBJKPFCPCB : AHEEKBGNEGI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void MFNHNDBEJDD<in TData>(TData MGJIAIBPJOF, IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BCGADLKLNIG HCAPPJIMDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JPOEPDBMJNF GGBNKLGKHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MFNHNDBEJDD<GCLNOLIGGFH>?[] EJPAFDAMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MFNHNDBEJDD<OEKMIFOBLEJ>?[] BHONIONMHPG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67B7F80", Offset = "0x67B7380", VA = "0x1867B7F80")]
	[EAMANMFIEOM(LALOBMMKLJJ.Root, NBICBCAKHEI.GameOnly)]
	[UsedImplicitly]
	private static void PAFCJLAHAKN(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67B7FF0", Offset = "0x67B73F0", VA = "0x1867B7FF0")]
	[Preserve]
	internal MDBJKPFCPCB([NCPIDBJOPHL(null)] BCGADLKLNIG HCAPPJIMDPN, [NCPIDBJOPHL(null)] JPOEPDBMJNF GGBNKLGKHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67B7400", Offset = "0x67B6800", VA = "0x1867B7400", Slot = "4")]
	public bool ELMPMBFKIAE(GCLNOLIGGFH MGJIAIBPJOF, IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67B72A0", Offset = "0x67B66A0", VA = "0x1867B72A0", Slot = "5")]
	public bool ELMPMBFKIAE(OEKMIFOBLEJ PLMEENDJJJM, IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67B7530", Offset = "0x67B6930", VA = "0x1867B7530")]
	private void LPJJJFEOOJE(GCLNOLIGGFH MGJIAIBPJOF, IReadOnlyList<EFKHLHPELON>? MHKDAHGGECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67B7070", Offset = "0x67B6470", VA = "0x1867B7070")]
	private void EKOFMHPMOFH(GCLNOLIGGFH MGJIAIBPJOF, IReadOnlyList<EFKHLHPELON>? MHKDAHGGECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x67B7500", Offset = "0x67B6900", VA = "0x1867B7500")]
	private void GLGBHJABBBP(GCLNOLIGGFH MGJIAIBPJOF, IReadOnlyList<EFKHLHPELON>? MHKDAHGGECP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AHEEKBGNEGI
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELMPMBFKIAE(GCLNOLIGGFH MGJIAIBPJOF, IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ELMPMBFKIAE(OEKMIFOBLEJ PLMEENDJJJM, IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL);
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
		public LCEEJICONKJ AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x67B0550", Offset = "0x67AF950", VA = "0x1867B0550")]
		public void ADKDNMBMCJN(AnimationPoseSetting IEDCHGMDIML, float DAMELHHBEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67B0680", Offset = "0x67AFA80", VA = "0x1867B0680")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, APOBEBAKCDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
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
		private Vector3? KFEFLCKCKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool IIGEKGJNHLF;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67B06A0", Offset = "0x67AFAA0", VA = "0x1867B06A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67B0CA0", Offset = "0x67B00A0", VA = "0x1867B0CA0", Slot = "4")]
		public void UpdateController(float OBMBAKPLLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xF48850", Offset = "0xF47C50", VA = "0x180F48850", Slot = "6")]
		public void SetEnabled(bool OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67B0740", Offset = "0x67AFB40", VA = "0x1867B0740")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67B1130", Offset = "0x67B0530", VA = "0x1867B1130")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, APOBEBAKCDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float FGNJBMKDDIM = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
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
		private Vector3 CHNDBKIHHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 NGDDCOFAHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool IIGEKGJNHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float EPKEDNHAIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float CEJLHANGNKB;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67B14B0", Offset = "0x67B08B0", VA = "0x1867B14B0", Slot = "4")]
		public void UpdateController(float OBMBAKPLLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBC0B50", Offset = "0xBBFF50", VA = "0x180BC0B50", Slot = "6")]
		public void SetEnabled(bool OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67B11D0", Offset = "0x67B05D0", VA = "0x1867B11D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67B1F70", Offset = "0x67B1370", VA = "0x1867B1F70")]
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
		[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x67B2890", Offset = "0x67B1C90", VA = "0x1867B2890")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67B2850", Offset = "0x67B1C50", VA = "0x1867B2850")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67B1FA0", Offset = "0x67B13A0", VA = "0x1867B1FA0")]
		private void HKBKMDGLOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x677BFF0", Offset = "0x677B3F0", VA = "0x18677BFF0", Slot = "4")]
		public void SetEnabled(bool PHHPGKLENNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67B28C0", Offset = "0x67B1CC0", VA = "0x1867B28C0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarForearmRollController : MonoBehaviour, APOBEBAKCDA
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
		private float EPKEDNHAIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool IIGEKGJNHLF;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67B2900", Offset = "0x67B1D00", VA = "0x1867B2900", Slot = "4")]
		public void UpdateController(float OBMBAKPLLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xED9D80", Offset = "0xED9180", VA = "0x180ED9D80", Slot = "6")]
		public void SetEnabled(bool OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67B3390", Offset = "0x67B2790", VA = "0x1867B3390")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HandDisplaySettings HandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D9")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67B3400", Offset = "0x67B2800", VA = "0x1867B3400")]
		public AnimationPoseSetting FAIDJNFGMKB(LCEEJICONKJ CPPFOLAFLKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67B33C0", Offset = "0x67B27C0", VA = "0x1867B33C0")]
		public void BGMBKGHFJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67B3430", Offset = "0x67B2830", VA = "0x1867B3430")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67B3E60", Offset = "0x67B3260", VA = "0x1867B3E60")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LFPJGMFBHDJ : FHMJHENMAFA
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static int DHMBMHLLLMO;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static int EBDEACLLOAK;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static int FOENPCDBIBC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static int HEBJFAOLPLL;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int FAHIJBJBPDF;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int CDCBEOBJLPF;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int FBPCOKLPKEI;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int[] IHLDEIMPJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private OENJMENICAE HJDKIAHCKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int BNGNNHICBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private float MJGGDDIBHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool DFOOMBMEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Animator NCFPKPCIKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarFullBodyConfiguration POFDBAIKHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int LPLAOLCGPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int BNPMABEOJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int GPDBACHEJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool MIHCPIGFILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private GLDELPCMEFD PBFAJJDFELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float LFOONBHEAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private HandDisplaySettings LJPFANMHONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private DBODHIJMFKE GPCKGBHLPNA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform DNNIEBNFDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 LMFBGOJJHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xECAB50", Offset = "0xEC9F50", VA = "0x180ECAB50")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xECAA20", Offset = "0xEC9E20", VA = "0x180ECAA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion HDBEDPHBING
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1CBBD70", Offset = "0x1CBB170", VA = "0x181CBBD70")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F697E0", Offset = "0x1F68BE0", VA = "0x181F697E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool HEBAHJGFBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67B6A80", Offset = "0x67B5E80", VA = "0x1867B6A80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67B6AB0", Offset = "0x67B5EB0", VA = "0x1867B6AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 FMGHILIJPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC42480", Offset = "0xC41880", VA = "0x180C42480", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xBF8760", Offset = "0xBF7B60", VA = "0x180BF8760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion MBOLNJHCPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x996220", Offset = "0x995620", VA = "0x180996220", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4660C40", Offset = "0x4660040", VA = "0x184660C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IGPEJDHHMCO PHEDCILLPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21FACA0", Offset = "0x21FA0A0", VA = "0x1821FACA0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(IGPEJDHHMCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x21FACB0", Offset = "0x21FA0B0", VA = "0x1821FACB0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IGPEJDHHMCO CBPEFAOAKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x150BFB0", Offset = "0x150B3B0", VA = "0x18150BFB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(IGPEJDHHMCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x150B790", Offset = "0x150AB90", VA = "0x18150B790", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float NEGNHPNBLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xB10050", Offset = "0xB0F450", VA = "0x180B10050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1427E00", Offset = "0x1427200", VA = "0x181427E00", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool AHJFHNGNIIP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67B6580", Offset = "0x67B5980", VA = "0x1867B6580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EHPKNHCLGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x67B6590", Offset = "0x67B5990", VA = "0x1867B6590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KFKEJPJDLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67B6560", Offset = "0x67B5960", VA = "0x1867B6560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GCNLLJIKGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67B6A70", Offset = "0x67B5E70", VA = "0x1867B6A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x67B6B30", Offset = "0x67B5F30", VA = "0x1867B6B30", Slot = "21")]
	public void MGIGIPLLEKC(OENJMENICAE BBHKLJEMHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67B6A50", Offset = "0x67B5E50", VA = "0x1867B6A50")]
	public void HEKFPJBJJIH(PKHNBGDANJA KHHKOMBFPFB, HandDisplaySettings MHNOIPFGGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x67B64B0", Offset = "0x67B58B0", VA = "0x1867B64B0", Slot = "12")]
	public void BHCPLNDIBJE(bool PEGAAPONPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67B65A0", Offset = "0x67B59A0", VA = "0x1867B65A0", Slot = "11")]
	public void GBCNIFAAANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67B62F0", Offset = "0x67B56F0", VA = "0x1867B62F0")]
	private int ADBLNBGCGCG(IGPEJDHHMCO NAJEDEDCOGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67B68F0", Offset = "0x67B5CF0", VA = "0x1867B68F0")]
	private void HAGMBADHEIH(int NMPPAPHEKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67B62D0", Offset = "0x67B56D0", VA = "0x1867B62D0", Slot = "13")]
	public bool ACEOOAFMJLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67B6D30", Offset = "0x67B6130", VA = "0x1867B6D30", Slot = "14")]
	public bool MKAMABJDPNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67B6AE0", Offset = "0x67B5EE0", VA = "0x1867B6AE0")]
	private IGPEJDHHMCO LMDFMALANNE()
	{
		return default(IGPEJDHHMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xD66120", Offset = "0xD65520", VA = "0x180D66120", Slot = "15")]
	public void LGDNAOCIFMN(bool PEGAAPONPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x67B6570", Offset = "0x67B5970", VA = "0x1867B6570", Slot = "10")]
	public void CINKIPEJFNM(int NMPPAPHEKHG, float NPOFJIHPDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x67B6540", Offset = "0x67B5940", VA = "0x1867B6540", Slot = "8")]
	public void BOHEMKDDJAE(GLDELPCMEFD AHEJMLCHHMA, bool LIFMKOAECLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67B6A40", Offset = "0x67B5E40", VA = "0x1867B6A40", Slot = "9")]
	public void HEDGFDGCBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x67B6D40", Offset = "0x67B6140", VA = "0x1867B6D40", Slot = "16")]
	public void OOMHENNDGLP(Transform KOBAADDGPBN, Vector3 KONFJLEJLEA, Quaternion PHAOIBJDGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x67B7060", Offset = "0x67B6460", VA = "0x1867B7060")]
	public LFPJGMFBHDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class OFJLFPFHPAG : HBLKMPJDDAA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class HCCBLLFMAOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private Vector3 DGAKAGEGLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Quaternion HDJFIAIMMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private Vector3 KHJALLCCCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Transform FINBAFCLEBK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector3 CFKHNHOHIBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x14775E0", Offset = "0x14769E0", VA = "0x1814775E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1477600", Offset = "0x1476A00", VA = "0x181477600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Quaternion CPAIDFLHJPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xC09310", Offset = "0xC08710", VA = "0x180C09310")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xC093D0", Offset = "0xC087D0", VA = "0x180C093D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float JFJAFGJCLKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x9962F0", Offset = "0x9956F0", VA = "0x1809962F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xF5C100", Offset = "0xF5B500", VA = "0x180F5C100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool CBPCEFAGBGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x859100", Offset = "0x858500", VA = "0x180859100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8592A0", Offset = "0x8586A0", VA = "0x1808592A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool ECACIHOKNMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8590F0", Offset = "0x8584F0", VA = "0x1808590F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8590E0", Offset = "0x8584E0", VA = "0x1808590E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool FNBPLDEBPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8592B0", Offset = "0x8586B0", VA = "0x1808592B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x859290", Offset = "0x858690", VA = "0x180859290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public float COCHAMNDHGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x996320", Offset = "0x995720", VA = "0x180996320")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA1FE0", Offset = "0xAA13E0", VA = "0x180AA1FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x67B3EA0", Offset = "0x67B32A0", VA = "0x1867B3EA0")]
		public void AIKGGKAOGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x67B4BF0", Offset = "0x67B3FF0", VA = "0x1867B4BF0")]
		public void PGGJLJFEJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x67B47E0", Offset = "0x67B3BE0", VA = "0x1867B47E0")]
		public float OAEOFGHHFKO(Transform JJIDCFJOHNG, [In] FootSettings MFFMCDBNOFN, float NFMNELLIHFK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x67B4080", Offset = "0x67B3480", VA = "0x1867B4080")]
		public void MNDNPJAHDKD(Transform GJKHBEGHGDA, Transform GKKABALHGKK, float DPPLILAALKH, bool LOOOECMBNLN, bool MKILDPJODNO, float HEMFKJCKJHE, float GMNHCCDMMFM, Transform MILPLABKJCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x67B49B0", Offset = "0x67B3DB0", VA = "0x1867B49B0")]
		public void OGNFPBNBEFJ(Transform OAMFFFABJLD, Transform MILPLABKJCF, bool EDJOEIGDAKH, bool GDCCMDDBDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x67B3EB0", Offset = "0x67B32B0", VA = "0x1867B3EB0")]
		private void BOALPJMOOLN(Transform MILPLABKJCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x67B3FB0", Offset = "0x67B33B0", VA = "0x1867B3FB0")]
		public void GJHDFIJODLJ(Transform MILPLABKJCF, AvatarFullBodyConfiguration FNDJNKIILKB, Vector3 DNMEDOBIABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x67B4BE0", Offset = "0x67B3FE0", VA = "0x1867B4BE0")]
		public void ONPKEJKNOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x67B4C00", Offset = "0x67B4000", VA = "0x1867B4C00")]
		public HCCBLLFMAOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class JFHNCNCMLGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private float OCDJBJINJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private bool HMCDIPBEKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AnimationPoseSetting NBBOCBOEKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float KKPOCHJMJBC;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x67B6220", Offset = "0x67B5620", VA = "0x1867B6220")]
		public void PNGLNKIAIOG(IKSolverVR.Arm GIPLJGNPBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x67B5BF0", Offset = "0x67B4FF0", VA = "0x1867B5BF0")]
		public void KLCEPPOPPAL(IKSolverVR.Arm GIPLJGNPBGC, float NHANGACEJJJ, bool HMCDIPBEKGP, AvatarFullBodyConfiguration FNDJNKIILKB, float DLDKDCBIBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x67B5BB0", Offset = "0x67B4FB0", VA = "0x1867B5BB0")]
		private void KFKEBKGEACD(IKSolverVR.Arm GIPLJGNPBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x67B4C10", Offset = "0x67B4010", VA = "0x1867B4C10")]
		public void APIBEEDJFDM(IKSolverVR.Arm GIPLJGNPBGC, Transform EBOGMEAMFAO, Transform GKKABALHGKK, Quaternion HEOMONBBOCB, Vector3 MMMOFBEHKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x67B5D90", Offset = "0x67B5190", VA = "0x1867B5D90")]
		private (Vector3, Quaternion) PCACAMHNMIL(LFPJGMFBHDJ BFBNCOBAOLM, Quaternion KGIIDMPMDFB, Vector3 NNMPIKGEPDC)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x67B5C30", Offset = "0x67B5030", VA = "0x1867B5C30")]
		public void OOKMEMDGDKP(LFPJGMFBHDJ BFBNCOBAOLM, IKSolverVR.Arm GIPLJGNPBGC, Quaternion KGIIDMPMDFB, Vector3 NNMPIKGEPDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x67B4FF0", Offset = "0x67B43F0", VA = "0x1867B4FF0")]
		public void CAHAFBLPAOP(LFPJGMFBHDJ BFBNCOBAOLM, IKSolverVR.Arm GIPLJGNPBGC, Quaternion KGIIDMPMDFB, Vector3 NNMPIKGEPDC, [In] AvatarFullBodyConfiguration FNDJNKIILKB, [In] DEBNEDBKMEC AHEJMLCHHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x67B5A70", Offset = "0x67B4E70", VA = "0x1867B5A70")]
		public void KDPFPKFBKEE(LCEEJICONKJ EDAMGMGNHMG, AvatarFullBodyConfiguration FNDJNKIILKB, DEBNEDBKMEC AHEJMLCHHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x67B55F0", Offset = "0x67B49F0", VA = "0x1867B55F0")]
		public void FHLCJBCDCLI(IKSolverVR.Arm GIPLJGNPBGC, Transform EBOGMEAMFAO, Vector3 CCGMFHJDBDI, float MHAHFOKGPEB, Quaternion AEMGJFFOFJO, Vector3 NKABCEKJIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x67B6250", Offset = "0x67B5650", VA = "0x1867B6250")]
		public JFHNCNCMLGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum LJPLFHLPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly int MEJOIJIJAJF;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly int HDHIFMEJNEK;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly int LMLALBALOFK;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly int IHFNFNOCKCN;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int MNMGBHFHJAN;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int OJEJBMGGDIL;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int NIHFHINDHBB;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int OBCIJDLIKIO;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int JKNOMONDLFE;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int LDMJNIMMHNP;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int EEHIDKDMFOE;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int COHGJIFMPPM;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int FPDLPDOIEGA;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int POOMJACLPCN;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int OPAPMPAALBO;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int GCIDLIIEBDA;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int KKDMIDNPILJ;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int GFNNCMIOCNA;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int FJGPAHKADMH;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int PMJHDLPPGMP;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int MGLHPFMPHLF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int HCGANPLMLOL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int EADIMCEFIBE;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int NHGKBHLKNFF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int PJFKBPPDDHM;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int BGNHDEHDMOJ;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int KOLOJHOHIPA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int DIBJCFDELIE;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int AMEEIHPMJHF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Vector3 KNANBCDOKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool DFPEOACCHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool GBGGGONNMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private bool BFINOCDOLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool GOCLAGFGAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool MJDDLOAABFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Vector3 AFJKCLLALFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private string JCGKAFDCOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private IEEALKDNMIP? HJDKIAHCKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private CNPNJDGCEFI? KIBJDGAEPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private GNHNIHPGAII IMKDABBPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private OPPLJAHMLKF MHKHNHFIKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private LFPJGMFBHDJ JGKALCHLLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private LFPJGMFBHDJ BNPHKJLHBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool EOEINLMCKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x259")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool KFLLMEMLKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly GIGNLJOCGDA OJEAEFDDHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly MDFHPNMEOAF MIDDGBOCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private int AFOJJJDDBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private float HFONEANIIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private GameObject EDMJPGLMLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Transform IPKGBOBLGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private Transform MFFLLMJFNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Transform FGHPEAKLDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private float PGCOCAKALFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private float HFCMEPDGKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Vector3 NJLABHGODFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Quaternion GJIJMBCGBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform OPPJCDCLPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform BAFPGOBCECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform ELJAOBGDFDG;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker NBFHHMHOFNO;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly ProfilerMarker EAILELEMAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private ProfilerMarker KAADLOCPIOK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker AJNBMBAGCKP;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker MJFAFNDCBDC;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker HFBKJBKMNFL;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly List<OFJLFPFHPAG> KHFIDNGNBPA;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static int HBCKLMIFIFI;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> BDBFIJLPPFJ;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int BJKPGLBFMIO;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int MKLAMAOCLPF;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int IBKGOAKNMKJ;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static int GMALCGEPKLM;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static float GLKJCJJECBG;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static int AEGNPCIIMHC;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static float NENFNCJHBFC;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static float KKFANCHKHJN;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static float KNCCHDHCJHL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static float CEPLPNGHCHM;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static NLJFGGBBLDF LIGPEPEPBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float PIPIOBAEKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private bool IKFPGKILOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private float DGNIOKIDAMM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly int DLCKLBNLOJK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly int NOHFPNNPFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private HCCBLLFMAOM EFAGCCLIOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private HCCBLLFMAOM NJPGDBBBPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float BCLOODBPJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Vector3 LGCHDCJKDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private Vector3 GDGDBNAEFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool EFDJAGKGEJB;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly Quaternion ONFDCELFDHN;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly Quaternion DDNJJHDDKGN;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly Vector3 OOGEEOINKKJ;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly Vector3 DKOAEEIKDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float GMEBFADLJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float OHENCJNOMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private JFHNCNCMLGG PDKGOLEMBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private JFHNCNCMLGG GPEILBFHGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private JAHMHMHAEHH ENAHLAOBDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private HDMIGICJOBB DMGCJGIIEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly JFCJKIJBIKH HCDGAINOLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float JIHGGEAPAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float FPNIKAAHLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly HDMIGICJOBB HHLJDCPICNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private Vector3 DCBKHOPDNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private Vector3 IOGNEOKJINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private float NGBLACBJCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float FPKFEOFMKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly HDMIGICJOBB LKMLLCLCBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly JAHMHMHAEHH FDFDLFDCGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly HDMIGICJOBB NMOKLNBPOPF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IDDBOOGKPOH MDEANGELPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IDDBOOGKPOH HIAJJKKHPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration KOABFLLEDIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x67C2A10", Offset = "0x67C1E10", VA = "0x1867C2A10", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DBODHIJMFKE OMPGCOJPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x67C6620", Offset = "0x67C5A20", VA = "0x1867C6620", Slot = "22")]
		get
		{
			return default(DBODHIJMFKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration BOFBFJHMGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67C3870", Offset = "0x67C2C70", VA = "0x1867C3870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform KNLPJDEGJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x67C2260", Offset = "0x67C1660", VA = "0x1867C2260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform ALGGACAPIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x67CE660", Offset = "0x67CDA60", VA = "0x1867CE660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer PGOJDJLGEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x67BA760", Offset = "0x67B9B60", VA = "0x1867BA760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] DPKDCMOLEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x67CB550", Offset = "0x67CA950", VA = "0x1867CB550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] FNPLAGJMNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x67C3DF0", Offset = "0x67C31F0", VA = "0x1867C3DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator AJFBAHILKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x67BC610", Offset = "0x67BBA10", VA = "0x1867BC610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK EKLMJACBMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x67BA850", Offset = "0x67B9C50", VA = "0x1867BA850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private APOBEBAKCDA HKJKPEKIJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67C3130", Offset = "0x67C2530", VA = "0x1867C3130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private APOBEBAKCDA IGPFDKGFDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67C3970", Offset = "0x67C2D70", VA = "0x1867C3970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private APOBEBAKCDA DKAIDBLKICD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x67C4A00", Offset = "0x67C3E00", VA = "0x1867C4A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private APOBEBAKCDA HGAMIJCFNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67BD7F0", Offset = "0x67BCBF0", VA = "0x1867BD7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private APOBEBAKCDA LKFFPKBIPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67C4E60", Offset = "0x67C4260", VA = "0x1867C4E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private APOBEBAKCDA DIHMAILNHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67C1F10", Offset = "0x67C1310", VA = "0x1867C1F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private APOBEBAKCDA BEGKCECKIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x67C2910", Offset = "0x67C1D10", VA = "0x1867C2910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private APOBEBAKCDA NDFJPDEJPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67C4D20", Offset = "0x67C4120", VA = "0x1867C4D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CNPNJDGCEFI NJNALJAIAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67CDB10", Offset = "0x67CCF10", VA = "0x1867CDB10", Slot = "39")]
		get
		{
			return default(CNPNJDGCEFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public DJPJDDCJGDP PIDDMKJDLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xC65E20", Offset = "0xC65220", VA = "0x180C65E20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public AAHJCJJEOLB KPBNNKAGHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA80890", Offset = "0xA7FC90", VA = "0x180A80890", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public FHMJHENMAFA ACPHOONLLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x14CCA40", Offset = "0x14CBE40", VA = "0x1814CCA40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public FHMJHENMAFA KAJDAHNECGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xE7FBE0", Offset = "0xE7EFE0", VA = "0x180E7FBE0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string HBGDMHLHLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform LOHACMGMJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67CC290", Offset = "0x67CB690", VA = "0x1867CC290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform BEEDLJFIPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67CCAB0", Offset = "0x67CBEB0", VA = "0x1867CCAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform CCGBNLDBENA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x67C3900", Offset = "0x67C2D00", VA = "0x1867C3900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool FJFPCLLEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x67CA260", Offset = "0x67C9660", VA = "0x1867CA260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform LEAGMILFAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67BDF80", Offset = "0x67BD380", VA = "0x1867BDF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject GODEJCKEDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x67C2B00", Offset = "0x67C1F00", VA = "0x1867C2B00", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets ECEDOPMIDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x67BE070", Offset = "0x67BD470", VA = "0x1867BE070", Slot = "30")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform MGBFKNMLMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x14CDE40", Offset = "0x14CD240", VA = "0x1814CDE40", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform CPFBAOIPNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x14CCD40", Offset = "0x14CC140", VA = "0x1814CCD40", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Vector3 EFCGICNHBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67C3EE0", Offset = "0x67C32E0", VA = "0x1867C3EE0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float JGNCMBNMPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67C33F0", Offset = "0x67C27F0", VA = "0x1867C33F0", Slot = "34")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Transform HDFPHPMILCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67C4950", Offset = "0x67C3D50", VA = "0x1867C4950", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Transform BGCCHKGPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xBED570", Offset = "0xBEC970", VA = "0x180BED570", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform EAALCACDNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBED140", Offset = "0xBEC540", VA = "0x180BED140", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform OKJMBDODIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x178ABA0", Offset = "0x1789FA0", VA = "0x18178ABA0", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool NAKPLPNKEDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x67C6F40", Offset = "0x67C6340", VA = "0x1867C6F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool MAEDMMALBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x67C65A0", Offset = "0x67C59A0", VA = "0x1867C65A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool ADBPHKADBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x67BDE50", Offset = "0x67BD250", VA = "0x1867BDE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x67C8550", Offset = "0x67C7950", VA = "0x1867C8550")]
	private void KILMFOJDOKF([In] DEBNEDBKMEC LPBFIMLBAKE, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x67C6FA0", Offset = "0x67C63A0", VA = "0x1867C6FA0")]
	private void JLEGFFFEEIP(DEBNEDBKMEC LPBFIMLBAKE, AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67C4F50", Offset = "0x67C4350", VA = "0x1867C4F50")]
	private void IGLHAIKDPND([In] DEBNEDBKMEC AHEJMLCHHMA, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67CF640", Offset = "0x67CEA40", VA = "0x1867CF640")]
	public OFJLFPFHPAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x67C5120", Offset = "0x67C4520", VA = "0x1867C5120", Slot = "12")]
	public void IMFHDEAGMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67BE0F0", Offset = "0x67BD4F0", VA = "0x1867BE0F0", Slot = "13")]
	public void CDDADGIIPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67C2000", Offset = "0x67C1400", VA = "0x1867C2000", Slot = "14")]
	public void DHBJNFAIKKK(bool MAEGKIDJOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x67C1B00", Offset = "0x67C0F00", VA = "0x1867C1B00", Slot = "24")]
	public Transform DECDAHLKJMG(string KFAABPOALLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67BFD00", Offset = "0x67BF100", VA = "0x1867BFD00", Slot = "25")]
	public Vector3? CHBOOHPDOFB(string KFAABPOALLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x67C2BA0", Offset = "0x67C1FA0", VA = "0x1867C2BA0", Slot = "7")]
	public void FMEPPLBAFFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x67BC700", Offset = "0x67BBB00", VA = "0x1867BC700", Slot = "6")]
	public void BJGCJJACGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x67C30C0", Offset = "0x67C24C0", VA = "0x1867C30C0", Slot = "8")]
	public void FMPGPHDAOKL(float ODJMAPACBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x67C49B0", Offset = "0x67C3DB0", VA = "0x1867C49B0")]
	private void HMLGLJALBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x67BFEC0", Offset = "0x67BF2C0", VA = "0x1867BFEC0", Slot = "4")]
	public void DAJBCOOEDKA(string MDNKLJHMNAJ, IEEALKDNMIP DLKNKJLKEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x67BC170", Offset = "0x67BB570", VA = "0x1867BC170", Slot = "5")]
	public void BEIHHNLAAFK(CNPNJDGCEFI KHHKOMBFPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x67CE080", Offset = "0x67CD480", VA = "0x1867CE080", Slot = "11")]
	public void ONNGGOCOBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x67C4200", Offset = "0x67C3600", VA = "0x1867C4200", Slot = "23")]
	public void HGOHNBECODD([Out] Vector3 EHHJHEDBAEF, [Out] Quaternion AEMGJFFOFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x67BFE90", Offset = "0x67BF290", VA = "0x1867BFE90")]
	private void CMALGBFCOCH([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x67C2A00", Offset = "0x67C1E00", VA = "0x1867C2A00", Slot = "26")]
	public void EPPABLLABNI(float FAGFODCOCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x67C45A0", Offset = "0x67C39A0", VA = "0x1867C45A0", Slot = "27")]
	public void HHIEHDGAJLM(float BIEFJBPGIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x67CE750", Offset = "0x67CDB50", VA = "0x1867CE750", Slot = "40")]
	public void PHJAODBALIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x67CE170", Offset = "0x67CD570", VA = "0x1867CE170", Slot = "28")]
	public HandLogicOffsets OPAMHDDJFPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x67CC5B0", Offset = "0x67CB9B0", VA = "0x1867CC5B0", Slot = "29")]
	public PlatformSpecificPlayerHandOffsets NNKOIFNGKBG()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67C3A60", Offset = "0x67C2E60", VA = "0x1867C3A60")]
	private void GMIINPFPCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67C24F0", Offset = "0x67C18F0", VA = "0x1867C24F0")]
	private void ENLMMDGEGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67CB260", Offset = "0x67CA660", VA = "0x1867CB260")]
	private void MMCMCJEAPFA(DMMCHBJDPCN LAMPNKELHFA, bool ONNBDPJFLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67CC3F0", Offset = "0x67CB7F0", VA = "0x1867CC3F0")]
	private void NJIMLMMAINJ(DMMCHBJDPCN LAMPNKELHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67CA210", Offset = "0x67C9610", VA = "0x1867CA210")]
	public Vector3 LPDMKBCPKMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67BDED0", Offset = "0x67BD2D0", VA = "0x1867BDED0")]
	private void CAHNPGEKDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67C1AE0", Offset = "0x67C0EE0", VA = "0x1867C1AE0")]
	private void DCNKECIAACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67C2350", Offset = "0x67C1750", VA = "0x1867C2350")]
	private float EJMKBEMAOAA([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67C4870", Offset = "0x67C3C70", VA = "0x1867C4870")]
	private int HJHJDGGDBKP([In] FFIMPPILPEE GOAHAGHJEOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x67C5760", Offset = "0x67C4B60", VA = "0x1867C5760")]
	private void INHBOLPOIKL(DEBNEDBKMEC LPBFIMLBAKE, bool BMIBLEFBNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x67C3BC0", Offset = "0x67C2FC0", VA = "0x1867C3BC0")]
	private static void HBLPJNALONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x67C79C0", Offset = "0x67C6DC0", VA = "0x1867C79C0")]
	private static void KEEANGBPFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67BA610", Offset = "0x67B9A10", VA = "0x1867BA610")]
	private float ABPHBHCNMNO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x67BD7C0", Offset = "0x67BCBC0", VA = "0x1867BD7C0")]
	private static int BKJNANBIPHI(OFJLFPFHPAG JNFNBKNOBNN, OFJLFPFHPAG CNFAHLDDGGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x67C7340", Offset = "0x67C6740", VA = "0x1867C7340")]
	public void JMMPMNKOCAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x67C4AF0", Offset = "0x67C3EF0", VA = "0x1867C4AF0")]
	private (bool, bool) HMOGCCLMLAP()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x67BE9B0", Offset = "0x67BDDB0", VA = "0x1867BE9B0")]
	private void CFNPFNKICHD([In] DEBNEDBKMEC AHEJMLCHHMA, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x67C7590", Offset = "0x67C6990", VA = "0x1867C7590")]
	private void KBPNBIKMPKD([In] DEBNEDBKMEC AHEJMLCHHMA, [In] AvatarFullBodyConfiguration FNDJNKIILKB, FootSettings MFFMCDBNOFN, bool JINPGEOIAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x67C20D0", Offset = "0x67C14D0", VA = "0x1867C20D0")]
	private float EALNOFJGHHI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x67CB7F0", Offset = "0x67CABF0", VA = "0x1867CB7F0")]
	private void NBKCDIPBOOO(DEBNEDBKMEC AHEJMLCHHMA, AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x67C4E10", Offset = "0x67C4210", VA = "0x1867C4E10")]
	private float ICGOIGPHMBM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x67CD280", Offset = "0x67CC680", VA = "0x1867CD280")]
	private void OHMAJAKFELE([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67BB6D0", Offset = "0x67BAAD0", VA = "0x1867BB6D0")]
	private void APIBEEDJFDM([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67BA940", Offset = "0x67B9D40", VA = "0x1867BA940")]
	private void AJBFDAHGEJM([In] DEBNEDBKMEC AHEJMLCHHMA, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x67C7380", Offset = "0x67C6780", VA = "0x1867C7380")]
	private void KAKHOINFNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x67BE750", Offset = "0x67BDB50", VA = "0x1867BE750")]
	private void CFLDLGJBCPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x67CC2E0", Offset = "0x67CB6E0", VA = "0x1867CC2E0")]
	private void NGBFFMHFAPK([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x67BB440", Offset = "0x67BA840", VA = "0x1867BB440")]
	private void ANPGKKANPEN(LFPJGMFBHDJ KNGEHACGMEO, IKSolverVR.Arm GIPLJGNPBGC, Transform AANGLMHJIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x67BE3E0", Offset = "0x67BD7E0", VA = "0x1867BE3E0")]
	private void CELOHBOALFO(DEBNEDBKMEC AHEJMLCHHMA, AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x67C3220", Offset = "0x67C2620", VA = "0x1867C3220")]
	private void GBCNIFAAANG(LIJCDJPHGMG HOKEOIAGPEE, FHMJHENMAFA KNGEHACGMEO, IKSolverVR.Arm GIPLJGNPBGC, float NHANGACEJJJ, float PDOAOHPJNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x67CABB0", Offset = "0x67C9FB0", VA = "0x1867CABB0")]
	private void MLPIOJNDAPJ([In] DEBNEDBKMEC AHEJMLCHHMA, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x67CE890", Offset = "0x67CDC90", VA = "0x1867CE890")]
	protected void PKKMJKOAOCG([In] DEBNEDBKMEC AHEJMLCHHMA, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x67C3F20", Offset = "0x67C3320", VA = "0x1867C3F20")]
	private void HEHLIPJJCBF([In] DEBNEDBKMEC AHEJMLCHHMA, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x67C1C50", Offset = "0x67C1050", VA = "0x1867C1C50")]
	protected void DFIDNLPKKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x67B9F40", Offset = "0x67B9340", VA = "0x1867B9F40")]
	private void ABLMNOJHPKL([In] DEBNEDBKMEC AHEJMLCHHMA, [In] LJPLFHLPPKB BMFJDDCNPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x67CB640", Offset = "0x67CAA40", VA = "0x1867CB640")]
	private void NAPNEADHJCO(DEBNEDBKMEC AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67C6560", Offset = "0x67C5960", VA = "0x1867C6560")]
	private void IOBFJDMKEIL([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67CE1A0", Offset = "0x67CD5A0", VA = "0x1867CE1A0")]
	private Vector3 PBAHBDHNIMJ([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x67CAAE0", Offset = "0x67C9EE0", VA = "0x1867CAAE0")]
	private void MKBLGEKPJDO([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x67CDC40", Offset = "0x67CD040", VA = "0x1867CDC40")]
	private float OJPOCMAGGHM(float GMNHCCDMMFM, [In] DEBNEDBKMEC AHEJMLCHHMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x67CC140", Offset = "0x67CB540", VA = "0x1867CC140")]
	private void NCCNJKCFJDD(float GMNHCCDMMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x67BD9B0", Offset = "0x67BCDB0", VA = "0x1867BD9B0")]
	private void BPNKCJCFMLM([In] DEBNEDBKMEC AHEJMLCHHMA, LJPLFHLPPKB BMFJDDCNPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67CA520", Offset = "0x67C9920", VA = "0x1867CA520")]
	private float MHJFFHHDIHN([In] DEBNEDBKMEC LPBFIMLBAKE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x67BAF20", Offset = "0x67BA320", VA = "0x1867BAF20")]
	private void AKIINOOMIAJ(DEBNEDBKMEC AHEJMLCHHMA, LJPLFHLPPKB BMFJDDCNPPB, Vector3 JJGJEFKIKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67C55B0", Offset = "0x67C49B0", VA = "0x1867C55B0")]
	private static void INDMCDKNLMK(Transform HDODENDDMOJ, Quaternion MGJIDJKDGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67C3570", Offset = "0x67C2970", VA = "0x1867C3570")]
	private void GENKDLDDMFG([In] DEBNEDBKMEC LFPKLHPINIM, [In] FFIMPPILPEE GOAHAGHJEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67C6710", Offset = "0x67C5B10", VA = "0x1867C6710")]
	private void JIODFGMFLAK([In] DEBNEDBKMEC LFPKLHPINIM, [In] FFIMPPILPEE GOAHAGHJEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67CA930", Offset = "0x67C9D30", VA = "0x1867CA930")]
	private void MIENIFIDJGJ(float HJLFDMKMAIK, [In] DEBNEDBKMEC LPBFIMLBAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67BBA20", Offset = "0x67BAE20", VA = "0x1867BBA20")]
	private float BDIGDHBCKEH([In] DEBNEDBKMEC LPBFIMLBAKE, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x67CA2B0", Offset = "0x67C96B0", VA = "0x1867CA2B0")]
	private void MHACBDHCFFO([In] DEBNEDBKMEC LPBFIMLBAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67CCB20", Offset = "0x67CBF20", VA = "0x1867CCB20")]
	private void OENKENGFLOE([In] DEBNEDBKMEC LPBFIMLBAKE, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x67CD770", Offset = "0x67CCB70", VA = "0x1867CD770")]
	private void OIGNCAELMDA([In] DEBNEDBKMEC LPBFIMLBAKE, float BHOIPEJFMNF, float HJEDEILILGH, Vector3 HHFMMHJNHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x67C5C90", Offset = "0x67C5090", VA = "0x1867C5C90")]
	private void INPHMABHFFD(DEBNEDBKMEC LPBFIMLBAKE, AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x67C9E00", Offset = "0x67C9200", VA = "0x1867C9E00")]
	private void KPPMJKLKEHM(DEBNEDBKMEC LPBFIMLBAKE, AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x67C3420", Offset = "0x67C2820", VA = "0x1867C3420")]
	public void GDIBBLBDPPC([In] DEBNEDBKMEC AHEJMLCHHMA, [In] AvatarFullBodyConfiguration FNDJNKIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67BD8E0", Offset = "0x67BCCE0", VA = "0x1867BD8E0")]
	[CompilerGenerated]
	internal static void BNKGAKJDCBK(HCCBLLFMAOM AEBMAKFPEPC, HCCBLLFMAOM BJKILCGGNML, Transform MCBKFKLIPJN, float ODIFAFDGMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67C2150", Offset = "0x67C1550", VA = "0x1867C2150")]
	[CompilerGenerated]
	internal static bool EHAGJIJIOJO(IKSolverVR.Arm GIPLJGNPBGC, OELEGFGMKCJ DCPAFKBMMPI, float NBGPPBMNBIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67CC670", Offset = "0x67CBA70", VA = "0x1867CC670")]
	[CompilerGenerated]
	internal static float NPJPODGADIN(Vector3 CFIHLBHGHFB, Vector3 HPIAPHPMCNE, Vector3 LHNMFLMOLAO, DEBNEDBKMEC LPBFIMLBAKE, AvatarFullBodyConfiguration FNDJNKIILKB, float BILMLHHHLMM)
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
		public enum JBPKEMFGNHP
		{
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private JBPKEMFGNHP handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x67B3E00", Offset = "0x67B3200", VA = "0x1867B3E00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x67B3DC0", Offset = "0x67B31C0", VA = "0x1867B3DC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x67B3790", Offset = "0x67B2B90", VA = "0x1867B3790")]
		private void HKBKMDGLOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x677BFF0", Offset = "0x677B3F0", VA = "0x18677BFF0", Slot = "4")]
		public void SetEnabled(bool PHHPGKLENNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x67B3E30", Offset = "0x67B3230", VA = "0x1867B3E30")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, APOBEBAKCDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private Vector3 CHNDBKIHHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Vector3 EFHGHGFGFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Vector3 AINCFPOBBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Matrix4x4 BGLCHAEFFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool IIGEKGJNHLF;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x67D1790", Offset = "0x67D0B90", VA = "0x1867D1790", Slot = "4")]
		public void UpdateController(float OBMBAKPLLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67D1780", Offset = "0x67D0B80", VA = "0x1867D1780", Slot = "6")]
		public void SetEnabled(bool OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67D1320", Offset = "0x67D0720", VA = "0x1867D1320")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x67D1E50", Offset = "0x67D1250", VA = "0x1867D1E50")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, JJPGNIJLALO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[Header("Configuration")]
		[SerializeField]
		private DBODHIJMFKE avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[FKKHMOHLHBN(HNCPNLMMHNP.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		[Header("Configuration")]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		[Header("Facial Animation")]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private HBLKMPJDDAA OACDLADLLGK;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public HBLKMPJDDAA NFDBLNIACDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9962A0", Offset = "0x9956A0", VA = "0x1809962A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public Transform AEFMLPEGKMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x67D2C90", Offset = "0x67D2090", VA = "0x1867D2C90", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x67D1E60", Offset = "0x67D1260", VA = "0x1867D1E60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x67D2B50", Offset = "0x67D1F50", VA = "0x1867D2B50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x67D2B00", Offset = "0x67D1F00", VA = "0x1867D2B00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x67D2A90", Offset = "0x67D1E90", VA = "0x1867D2A90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67D1E60", Offset = "0x67D1260", VA = "0x1867D1E60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x67D22E0", Offset = "0x67D16E0", VA = "0x1867D22E0", Slot = "6")]
		public HBLKMPJDDAA CreateAvatarSystem(string MDNKLJHMNAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67D2A90", Offset = "0x67D1E90", VA = "0x1867D2A90", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67D1F10", Offset = "0x67D1310", VA = "0x1867D1F10", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x67D2BA0", Offset = "0x67D1FA0", VA = "0x1867D2BA0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float OBMBAKPLLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Preserve]
internal class AOBOHEEHOCL : LHGAFEFIFBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Dictionary<string, HBLKMPJDDAA> JDEKAMOFGBL;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x67D06A0", Offset = "0x67CFAA0", VA = "0x1867D06A0")]
	[EAMANMFIEOM(LALOBMMKLJJ.Root, NBICBCAKHEI.None)]
	private static void ILPDGLHKPKD(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x67D0340", Offset = "0x67CF740", VA = "0x1867D0340", Slot = "4")]
	public HBLKMPJDDAA GGBJFFIBNJO(string PFKAJNNOLOO, AvatarSystemConfiguration IOIEICBMGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x67D0710", Offset = "0x67CFB10", VA = "0x1867D0710", Slot = "5")]
	public void OGAOGPPEOFP(string PFKAJNNOLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67D0560", Offset = "0x67CF960", VA = "0x1867D0560", Slot = "6")]
	public string HHGHODCPKFN(string KPGEKJPDEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67D02D0", Offset = "0x67CF6D0", VA = "0x1867D02D0")]
	private string EPCNBOFAFGO(string KPGEKJPDEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67D0890", Offset = "0x67CFC90", VA = "0x1867D0890")]
	public AOBOHEEHOCL()
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
		public class AKNFKILFIBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			private Dictionary<string, Transform> MPBNHHDMPNC;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public bool OODFNLHIOMP
			{
				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x67D0200", Offset = "0x67CF600", VA = "0x1867D0200")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x67D00D0", Offset = "0x67CF4D0", VA = "0x1867D00D0")]
			public void IIGKHNIPLCC(VRIK LCHBICMCPHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
			public void MNOFAHNBOHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x67D0080", Offset = "0x67CF480", VA = "0x1867D0080")]
			public void FCLPPFCBMBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x67D0240", Offset = "0x67CF640", VA = "0x1867D0240")]
			public AKNFKILFIBJ()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[AFPIJOONNOP(HNCPNLMMHNP.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[FKKHMOHLHBN(HNCPNLMMHNP.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly AKNFKILFIBJ BGIDMGKPPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private JJPGNIJLALO OGMIIHNKJJE;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x67D2CE0", Offset = "0x67D20E0", VA = "0x1867D2CE0")]
		private void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x67D2FB0", Offset = "0x67D23B0", VA = "0x1867D2FB0")]
		private bool PCNOFBGLALB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x67D2FA0", Offset = "0x67D23A0", VA = "0x1867D2FA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x67D3060", Offset = "0x67D2460", VA = "0x1867D3060")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x67D3000", Offset = "0x67D2400", VA = "0x1867D3000")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x67D32D0", Offset = "0x67D26D0", VA = "0x1867D32D0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class HandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x67D7920", Offset = "0x67D6D20", VA = "0x1867D7920")]
		public void BGMBKGHFJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x67D7A40", Offset = "0x67D6E40", VA = "0x1867D7A40")]
		public int OJBBKHHMJHL(int IKBMOEIFBKE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public HandDisplaySettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x67D7AB0", Offset = "0x67D6EB0", VA = "0x1867D7AB0")]
			public void BGMBKGHFJON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x67D7B90", Offset = "0x67D6F90", VA = "0x1867D7B90")]
			public (float, float) BJBAKBDNJGM(Animator HCCFHMJKMOK, AnimatorStateInfo LJABNNGHNAB)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x67D7CD0", Offset = "0x67D70D0", VA = "0x1867D7CD0")]
		public void BGMBKGHFJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x67D80D0", Offset = "0x67D74D0", VA = "0x1867D80D0")]
		public (float, float) KHDAKJIPPLF(Animator HCCFHMJKMOK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x67D7EC0", Offset = "0x67D72C0", VA = "0x1867D7EC0")]
		private (float, float) GPFMPHHIMCL(Animator HCCFHMJKMOK, AnimatorStateInfo LJABNNGHNAB)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x67D82E0", Offset = "0x67D76E0", VA = "0x1867D82E0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x67DB310", Offset = "0x67DA710", VA = "0x1867DB310", Slot = "4")]
		public override void OnStateEnter(Animator HCCFHMJKMOK, AnimatorStateInfo LJABNNGHNAB, int KODKPCPPMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x67DB480", Offset = "0x67DA880", VA = "0x1867DB480")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal abstract class HBHHPNFCOII<TInput, TOutput> : IIHGPJNDNAJ<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	protected readonly JPOEPDBMJNF GGBNKLGKHPA;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3D512A0", Offset = "0x3D506A0", VA = "0x183D512A0")]
	protected HBHHPNFCOII(JPOEPDBMJNF GGBNKLGKHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput JLCLGLEKPEG(TInput BCPLMINPIEH, [Out] IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3D51200", Offset = "0x3D50600", VA = "0x183D51200", Slot = "5")]
	public bool OEEDDBHCECH(TInput BCPLMINPIEH, [Out] TOutput? LLANANCGECL, [Out] IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[NIMGPLGMLPL]
public static class BGCJMFAIAHD
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly Regex JHCBJICEDAA;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x67D3520", Offset = "0x67D2920", VA = "0x1867D3520")]
	public static EKFDEJANFPB NAILIPFDPKF(PKLEKOKBDCD DLGHIJCLHBE, IMNBCOOFJKJ LPBDGOFCEGB, Guid? HFOAEAPGLPN, Color? BEGJJBADJGN, EPOJMBFGCMA CBBPPBKJBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x67D33B0", Offset = "0x67D27B0", VA = "0x1867D33B0")]
	public static CJKCONKAKEF DHHOJPAJMHI(EKFDEJANFPB LDNEPNAGEGN)
	{
		return default(CJKCONKAKEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x28E6EC0", Offset = "0x28E62C0", VA = "0x1828E6EC0")]
	internal static TModern? CGEBOBFBPLI<TModern>(string? BCPLMINPIEH, OCFMIHMGMHJ<TModern> FLOHKJOMNPP, JPOEPDBMJNF GGBNKLGKHPA, GPCCCNKFDCN NFDPKPHHGFD, TModern NDADOBGDMNA) where TModern : struct, FAOLNGHDKLI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x28E8440", Offset = "0x28E7840", VA = "0x1828E8440")]
	internal static FFEKLOGADCA CNOMLBKJHFI<TModern>(string? BCPLMINPIEH, OCFMIHMGMHJ<TModern> FLOHKJOMNPP, JPOEPDBMJNF GGBNKLGKHPA, GPCCCNKFDCN NFDPKPHHGFD, TModern NDADOBGDMNA) where TModern : struct, FAOLNGHDKLI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x67D3730", Offset = "0x67D2B30", VA = "0x1867D3730")]
	internal static List<EFKHLHPELON> OFKAMDDFNCI(IEnumerable<EDOKIAKFLGE>? JKCDBAGOPLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x28E8C20", Offset = "0x28E8020", VA = "0x1828E8C20")]
	internal static string IHCGBMLFGAH<TModern>(TModern BCPLMINPIEH, OCFMIHMGMHJ<TModern> FLOHKJOMNPP, JPOEPDBMJNF GGBNKLGKHPA) where TModern : FAOLNGHDKLI
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class NCGFCFFDIJA : HLDKCOHODNI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IIHGPJNDNAJ<FAFHFIMHHOA, GCLNOLIGGFH> OLFNDKKFOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IIHGPJNDNAJ<PLHCOMNHOME, OEKMIFOBLEJ> PHKBICDDCFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IIHGPJNDNAJ<PLHCOMNHOME, OEKMIFOBLEJ> AHEIPKONLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public PIMOKCJHICC ANINAMAIOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public ACHNCOCBIJB EOAAJLBEBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x67DB9A0", Offset = "0x67DADA0", VA = "0x1867DB9A0")]
	[EAMANMFIEOM(LALOBMMKLJJ.Root, NBICBCAKHEI.GameOnly)]
	[UsedImplicitly]
	private static void PAFCJLAHAKN(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x67DBA10", Offset = "0x67DAE10", VA = "0x1867DBA10")]
	[Preserve]
	internal NCGFCFFDIJA([NCPIDBJOPHL("UnitySerialization")] GDFMIPKJPFL EBDIOJFKPGO, [NCPIDBJOPHL(null)] NEHCKIELPHC KCBPNJDGLDB, [NCPIDBJOPHL(null)] JPOEPDBMJNF GGBNKLGKHPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum PIENFHEMIGK
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NCLAEJBCPEN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x67DBFA0", Offset = "0x67DB3A0", VA = "0x1867DBFA0")]
	public NCLAEJBCPEN(string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x67DC010", Offset = "0x67DB410", VA = "0x1867DC010")]
	public NCLAEJBCPEN(string PBDOHNMILPN, Exception PEHEBDOPJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x67DBF70", Offset = "0x67DB370", VA = "0x1867DBF70")]
	public NCLAEJBCPEN(PIENFHEMIGK AJKEIPJPDEK, string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x67DBFD0", Offset = "0x67DB3D0", VA = "0x1867DBFD0")]
	public NCLAEJBCPEN(PIENFHEMIGK AJKEIPJPDEK, string PBDOHNMILPN, Exception PEHEBDOPJEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal abstract class DPDPGCFILFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly GDFMIPKJPFL EBDIOJFKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	protected readonly NEHCKIELPHC KCBPNJDGLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	protected readonly JPOEPDBMJNF GGBNKLGKHPA;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x67D57C0", Offset = "0x67D4BC0", VA = "0x1867D57C0")]
	protected DPDPGCFILFB(GDFMIPKJPFL EBDIOJFKPGO, NEHCKIELPHC KCBPNJDGLDB, JPOEPDBMJNF GGBNKLGKHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x67D4180", Offset = "0x67D3580", VA = "0x1867D4180")]
	protected string LLOGLOBLEPE(GCLNOLIGGFH MGJIAIBPJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x67D3E50", Offset = "0x67D3250", VA = "0x1867D3E50")]
	protected string DEGGMLMKGOG(GCLNOLIGGFH MGJIAIBPJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x67D5490", Offset = "0x67D4890", VA = "0x1867D5490")]
	private AvatarOutfitSelectionData NAILIPFDPKF(EKFDEJANFPB EGLPBJGHPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x67D4040", Offset = "0x67D3440", VA = "0x1867D4040")]
	private static AvatarCustomizationSettingsData.AnchorParams KHACBBLNBMK(HKJKDJMCLJK? LAAJMMOKPBE)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IIHGPJNDNAJ<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput JLCLGLEKPEG(TInput BCPLMINPIEH, [Out] IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OEEDDBHCECH(TInput BCPLMINPIEH, [Out] TOutput? LLANANCGECL, [Out] IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HLDKCOHODNI
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IIHGPJNDNAJ<FAFHFIMHHOA, GCLNOLIGGFH> OLFNDKKFOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IIHGPJNDNAJ<PLHCOMNHOME, OEKMIFOBLEJ> AHEIPKONLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	PIMOKCJHICC ANINAMAIOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum GPCCCNKFDCN
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ACHNCOCBIJB
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MOOFDFCCIAN KPIBKDOHBCB(GCLNOLIGGFH LDNEPNAGEGN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PIMOKCJHICC
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLHCOMNHOME KPIBKDOHBCB(GCLNOLIGGFH LDNEPNAGEGN, int LLCPIKPJEFE, string? FIKHOKLHCII, string? NNLJDDEEOND, CEHEBDFBLFJ POHKOLGMMBG, List<EFKHLHPELON>? CHFJOLMLFJL);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NIMGPLGMLPL]
internal class ACDNDPPOBHH : HBHHPNFCOII<FAFHFIMHHOA, GCLNOLIGGFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly NEHCKIELPHC KCBPNJDGLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly MMBJKIMDEPE NHKPIDPIINK;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x67CFEB0", Offset = "0x67CF2B0", VA = "0x1867CFEB0")]
	public ACDNDPPOBHH(GDFMIPKJPFL EBDIOJFKPGO, NEHCKIELPHC KCBPNJDGLDB, JPOEPDBMJNF GGBNKLGKHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x67CFC00", Offset = "0x67CF000", VA = "0x1867CFC00", Slot = "6")]
	public override GCLNOLIGGFH JLCLGLEKPEG(FAFHFIMHHOA BCPLMINPIEH, [Out] IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[Preserve]
internal class KAIEEEOPOCJ : GDFMIPKJPFL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class LMOBNDPFINB : JsonConverter<FFEKLOGADCA>
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x67D8C60", Offset = "0x67D8060", VA = "0x1867D8C60", Slot = "9")]
		public override void WriteJson(JsonWriter CCOPEDCAMKJ, FFEKLOGADCA? OBEEJPGJPFD, JsonSerializer EPNMNPBAAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x67D8B40", Offset = "0x67D7F40", VA = "0x1867D8B40", Slot = "10")]
		public override FFEKLOGADCA ReadJson(JsonReader CKPGDBBGEAK, Type PMDAADBLPNN, FFEKLOGADCA? PAKOKJKBINB, bool CKFEBOCILCP, JsonSerializer EPNMNPBAAGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x67D8D00", Offset = "0x67D8100", VA = "0x1867D8D00")]
		public LMOBNDPFINB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class NAPPOHOCKDK : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public override bool NIDHICMEJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x67DB860", Offset = "0x67DAC60", VA = "0x1867DB860", Slot = "5")]
		public override object ReadJson(JsonReader CKPGDBBGEAK, Type PMDAADBLPNN, object? PAKOKJKBINB, JsonSerializer EPNMNPBAAGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x67DB680", Offset = "0x67DAA80", VA = "0x1867DB680", Slot = "6")]
		public override bool CanConvert(Type PMDAADBLPNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x67DB8C0", Offset = "0x67DACC0", VA = "0x1867DB8C0", Slot = "4")]
		public override void WriteJson(JsonWriter CCOPEDCAMKJ, object? OBEEJPGJPFD, JsonSerializer EPNMNPBAAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x67DB4A0", Offset = "0x67DA8A0", VA = "0x1867DB4A0")]
		private static bool ABGJKPAENBL(object OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public NAPPOHOCKDK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly JsonSerializerSettings MHNOIPFGGGO;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x67D89E0", Offset = "0x67D7DE0", VA = "0x1867D89E0")]
	internal KAIEEEOPOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2C19C30", Offset = "0x2C19030", VA = "0x182C19C30", Slot = "4")]
	public string KIDFIEFENGE<T>(T LALIGKIKEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2C19BA0", Offset = "0x2C18FA0", VA = "0x182C19BA0", Slot = "5")]
	public T ACIAAGHBDIH<T>(string OBEEJPGJPFD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Preserve]
internal class BOAKBNCPIBN : GDFMIPKJPFL
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x28F7410", Offset = "0x28F6810", VA = "0x1828F7410", Slot = "4")]
	public string KIDFIEFENGE<T>(T LALIGKIKEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x28F7390", Offset = "0x28F6790", VA = "0x1828F7390", Slot = "5")]
	public T ACIAAGHBDIH<T>(string OBEEJPGJPFD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public BOAKBNCPIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[NIMGPLGMLPL]
internal class MMBJKIMDEPE : HBHHPNFCOII<PLHCOMNHOME, OEKMIFOBLEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly GDFMIPKJPFL EBDIOJFKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly NEHCKIELPHC KCBPNJDGLDB;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x67DB1D0", Offset = "0x67DA5D0", VA = "0x1867DB1D0")]
	public MMBJKIMDEPE(GDFMIPKJPFL EBDIOJFKPGO, NEHCKIELPHC KCBPNJDGLDB, JPOEPDBMJNF GGBNKLGKHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x67DA0F0", Offset = "0x67D94F0", VA = "0x1867DA0F0", Slot = "6")]
	public override OEKMIFOBLEJ JLCLGLEKPEG(PLHCOMNHOME BCPLMINPIEH, [Out] IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x67DAE70", Offset = "0x67DA270", VA = "0x1867DAE70")]
	internal void ONJLJMHPMPO(string OEHDKJNMCMC, GCLNOLIGGFH MGJIAIBPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x67DA520", Offset = "0x67D9920", VA = "0x1867DA520")]
	public IEnumerable<EKFDEJANFPB> LAKPCHIIBLI(string KIFHDOEDFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x67DA5D0", Offset = "0x67D99D0", VA = "0x1867DA5D0")]
	private IEnumerable<EKFDEJANFPB> LNMLHGBDDHA(string KIFHDOEDFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x67DAA00", Offset = "0x67D9E00", VA = "0x1867DAA00")]
	internal IEnumerable<EKFDEJANFPB> MNIGGJNMJDH(string KIFHDOEDFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x67D9060", Offset = "0x67D8460", VA = "0x1867D9060")]
	private EKFDEJANFPB ADLINCKPFAH(AvatarOutfitSelectionData OKAGFBAKFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x67D9850", Offset = "0x67D8C50", VA = "0x1867D9850")]
	private void HNBKOFPLMEN(AvatarCustomizationSettingsData NCIMPPKGLHO, GCLNOLIGGFH MGJIAIBPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67D8D40", Offset = "0x67D8140", VA = "0x1867D8D40")]
	private EKFDEJANFPB ADLINCKPFAH(string MIAHHCIKCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x67D93F0", Offset = "0x67D87F0", VA = "0x1867D93F0")]
	internal static (EPOJMBFGCMA, string, string) AGELLOMHPNH(string MIAHHCIKCPF, JPOEPDBMJNF GGBNKLGKHPA)
	{
		return default((EPOJMBFGCMA, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x67DAFD0", Offset = "0x67DA3D0", VA = "0x1867DAFD0")]
	private PCBOBJFNCEM? PPIOJOBDHHG(string? HLKHAOEDAIN, Vector2 KONFJLEJLEA, float CHJIHOLNGNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x67D96F0", Offset = "0x67D8AF0", VA = "0x1867D96F0")]
	private static HKJKDJMCLJK HGOIJHEIIDG(AvatarCustomizationSettingsData.AnchorParams CBPGFNPMFCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[NIMGPLGMLPL]
internal class JCJADGMBGIH : DPDPGCFILFB, ACHNCOCBIJB
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x67D57C0", Offset = "0x67D4BC0", VA = "0x1867D57C0")]
	public JCJADGMBGIH(GDFMIPKJPFL EBDIOJFKPGO, NEHCKIELPHC KCBPNJDGLDB, JPOEPDBMJNF GGBNKLGKHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x67D8630", Offset = "0x67D7A30", VA = "0x1867D8630", Slot = "4")]
	public MOOFDFCCIAN KPIBKDOHBCB(GCLNOLIGGFH LDNEPNAGEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x67D82F0", Offset = "0x67D76F0", VA = "0x1867D82F0")]
	private string EPCKCHPHDKK(GCLNOLIGGFH MGJIAIBPJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x67D83F0", Offset = "0x67D77F0", VA = "0x1867D83F0")]
	private string ILHIDOOCNOH(EKFDEJANFPB EGLPBJGHPKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[NIMGPLGMLPL]
internal class BIKBMGNCGNM : HBHHPNFCOII<PLHCOMNHOME, OEKMIFOBLEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly GDFMIPKJPFL EBDIOJFKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private readonly IIHGPJNDNAJ<PLHCOMNHOME, OEKMIFOBLEJ> PDOHNHANGCJ;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x67D3D50", Offset = "0x67D3150", VA = "0x1867D3D50")]
	public BIKBMGNCGNM(IIHGPJNDNAJ<PLHCOMNHOME, OEKMIFOBLEJ> PDOHNHANGCJ, JPOEPDBMJNF GGBNKLGKHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x67D3920", Offset = "0x67D2D20", VA = "0x1867D3920", Slot = "6")]
	public override OEKMIFOBLEJ JLCLGLEKPEG(PLHCOMNHOME BCPLMINPIEH, [Out] IReadOnlyList<EFKHLHPELON>? CHFJOLMLFJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[NIMGPLGMLPL]
internal class OECMGKAKBDM : PIMOKCJHICC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private readonly GDFMIPKJPFL EBDIOJFKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private readonly ACHNCOCBIJB GDJDMAPACFP;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x67DC3F0", Offset = "0x67DB7F0", VA = "0x1867DC3F0")]
	public OECMGKAKBDM(ACHNCOCBIJB GDJDMAPACFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x67DC040", Offset = "0x67DB440", VA = "0x1867DC040", Slot = "4")]
	public PLHCOMNHOME KPIBKDOHBCB(GCLNOLIGGFH LDNEPNAGEGN, int LLCPIKPJEFE, string? FIKHOKLHCII, string? NNLJDDEEOND, CEHEBDFBLFJ POHKOLGMMBG, List<EFKHLHPELON>? CHFJOLMLFJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Preserve]
internal class HCABJONEKJN : OEKGLDJIPCK
{
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly Vector2 ICKDNFHBFKM;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly Vector2 PGLLKOGPBAH;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly Vector2 GNAPEPNKPCL;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly Vector2 AEKPIOCFBCP;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly Vector2 OCAEILDGDAE;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly Vector2 FCMABCEHIOK;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly Vector2 HDDCINOOFAL;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly Vector2 NJBHKGLLEEP;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly Vector2 KAANBDGBFIP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly Vector2 PFIHOMJCDAI;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly Vector2 JEHHLOBKDHO;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly Vector2 FHNDLFCLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private Dictionary<DBODHIJMFKE, AvatarConfiguration> LFGLDCKKAJL;

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x67D70B0", Offset = "0x67D64B0", VA = "0x1867D70B0")]
	[EAMANMFIEOM(LALOBMMKLJJ.Root, NBICBCAKHEI.None)]
	private static void NCHGKDEAMJE(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x67D7870", Offset = "0x67D6C70", VA = "0x1867D7870")]
	[Preserve]
	internal HCABJONEKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x67D6290", Offset = "0x67D5690", VA = "0x1867D6290", Slot = "4")]
	public Vector2 DOABCNJEKGA(FaceFeatureType ACKMKCCLCON, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x67D68E0", Offset = "0x67D5CE0", VA = "0x1867D68E0", Slot = "5")]
	public float GPFMEEOHKKJ(FaceFeatureType ACKMKCCLCON, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x67D74B0", Offset = "0x67D68B0", VA = "0x1867D74B0", Slot = "6")]
	public void OOIMPAHMBBO(DBODHIJMFKE MCNAHMPHBIK, AvatarConfiguration IOIEICBMGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x67D6220", Offset = "0x67D5620", VA = "0x1867D6220", Slot = "7")]
	public float DDCLHIFJCHJ(FaceFeatureType OKMBEALBKHJ, float BGFFDNAPEIO, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x67D6960", Offset = "0x67D5D60", VA = "0x1867D6960", Slot = "8")]
	public float HDBJPDDCEII(FaceFeatureType OKMBEALBKHJ, float CHJIHOLNGNH, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x67D5D10", Offset = "0x67D5110", VA = "0x1867D5D10", Slot = "10")]
	public Vector2 AHPABPIMHHA(FaceFeatureType OKMBEALBKHJ, Vector2 IBEMOMPCMBA, Vector2 JABDCAIOEOA, Vector2 FBLAJGIHOFA, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x67D63F0", Offset = "0x67D57F0", VA = "0x1867D63F0", Slot = "9")]
	public Vector2 ECNMPPDBDOF(FaceFeatureType OKMBEALBKHJ, Vector2 CLODIDHAAEG, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x67D6E10", Offset = "0x67D6210", VA = "0x1867D6E10")]
	private Vector2 LCGBIODLGNA(FaceFeatureType OKMBEALBKHJ, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x67D6CC0", Offset = "0x67D60C0", VA = "0x1867D6CC0")]
	private Vector2 KJJLFMIAIEO(FaceFeatureType OKMBEALBKHJ, Vector2 IBEMOMPCMBA, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x67D7120", Offset = "0x67D6520", VA = "0x1867D7120", Slot = "11")]
	public Vector2 ONHIOALCJLB(FaceFeatureType OKMBEALBKHJ, Vector2 CLODIDHAAEG, Vector2 JABDCAIOEOA, Vector2 FBLAJGIHOFA, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x67D6990", Offset = "0x67D5D90", VA = "0x1867D6990")]
	private float IPPHEOGKFOF(float DNLNJGFKFHE, float JDOCBGNCGMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x67D6F70", Offset = "0x67D6370", VA = "0x1867D6F70")]
	private Vector2 MOAJANHOCEI(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x67D7520", Offset = "0x67D6920", VA = "0x1867D7520")]
	private Vector2 PJBJHOHAOII(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67D5EC0", Offset = "0x67D52C0", VA = "0x1867D5EC0")]
	private Vector2 ANCLKBAKFFP(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67D75E0", Offset = "0x67D69E0", VA = "0x1867D75E0")]
	private Vector2 PPPEPBHCEHK(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67D61E0", Offset = "0x67D55E0", VA = "0x1867D61E0")]
	private float CPHGDAKNJJI(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67D75A0", Offset = "0x67D69A0", VA = "0x1867D75A0")]
	private float PJCNMPGILKH(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x67D6620", Offset = "0x67D5A20", VA = "0x1867D6620")]
	private float EFPCKDLKJEN(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x67D6250", Offset = "0x67D5650", VA = "0x1867D6250")]
	private float DNPOCHCKKNL(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x67D5C30", Offset = "0x67D5030", VA = "0x1867D5C30")]
	private Vector2 AHHBNCJGGDD(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x67D6660", Offset = "0x67D5A60", VA = "0x1867D6660")]
	private Vector2 EMHJIPKPLBA(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x67D6020", Offset = "0x67D5420", VA = "0x1867D6020")]
	private Vector2 BBAAJMPJJPE(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x67D6A20", Offset = "0x67D5E20", VA = "0x1867D6A20")]
	private Vector2 JBFAAPFMHBC(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x67D6BE0", Offset = "0x67D5FE0", VA = "0x1867D6BE0")]
	private Vector2 KILNHOKMAGO(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x67D6800", Offset = "0x67D5C00", VA = "0x1867D6800")]
	private Vector2 FLOENPHOHJN(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x67D6B00", Offset = "0x67D5F00", VA = "0x1867D6B00")]
	private Vector2 JHKLIKLKOMG(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x67D5F40", Offset = "0x67D5340", VA = "0x1867D5F40")]
	private Vector2 AODOJBGKALP(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x67D6100", Offset = "0x67D5500", VA = "0x1867D6100")]
	private Vector2 BKHKIIFCPJF(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x67D6FF0", Offset = "0x67D63F0", VA = "0x1867D6FF0")]
	private Vector2 MPJBOMOMLDM(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x67D6EB0", Offset = "0x67D62B0", VA = "0x1867D6EB0")]
	private Vector2 MFBPHIBFKBN(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x67D6740", Offset = "0x67D5B40", VA = "0x1867D6740")]
	private Vector2 EOICEIHDEPC(DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x67D09D0", Offset = "0x67CFDD0", VA = "0x1867D09D0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HBJANODAIIB
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x67D59A0", Offset = "0x67D4DA0", VA = "0x1867D59A0")]
	public static CJKCONKAKEF JLCLGLEKPEG(this FMIHOHPNGMA LDNEPNAGEGN)
	{
		return default(CJKCONKAKEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x67D5AB0", Offset = "0x67D4EB0", VA = "0x1867D5AB0")]
	public static FMIHOHPNGMA KPIBKDOHBCB(this CJKCONKAKEF GDLBAKOLGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x67D5BD0", Offset = "0x67D4FD0", VA = "0x1867D5BD0")]
	public static bool MFAAICHPJLA(this CJKCONKAKEF GDLBAKOLGFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x67D5940", Offset = "0x67D4D40", VA = "0x1867D5940")]
	public static bool CHKIMPOOJDD(this CJKCONKAKEF GDLBAKOLGFG)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x4CDB2A0", Offset = "0x4CDA6A0", VA = "0x184CDB2A0")]
			public AnchorParams(Vector2 IBEMOMPCMBA, Vector3 FMONHLJHGJB, Vector3 LHICCOAKPJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x67D0920", Offset = "0x67CFD20", VA = "0x1867D0920")]
			internal HKJKDJMCLJK KPIBKDOHBCB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private HJDLNPHIIDN useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x67D11F0", Offset = "0x67D05F0", VA = "0x1867D11F0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3DA0710", Offset = "0x3D9FB10", VA = "0x183DA0710")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x11622C0", Offset = "0x11616C0", VA = "0x1811622C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x95D460", Offset = "0x95C860", VA = "0x18095D460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA5F670", Offset = "0xA5EA70", VA = "0x180A5F670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850C00", VA = "0x180851800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x67D12A0", Offset = "0x67D06A0", VA = "0x1867D12A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x857640", Offset = "0x856A40", VA = "0x180857640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x95D520", Offset = "0x95C920", VA = "0x18095D520")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1179770", Offset = "0x1178B70", VA = "0x181179770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8541B0", Offset = "0x8535B0", VA = "0x1808541B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x67D12E0", Offset = "0x67D06E0", VA = "0x1867D12E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1DBEB80", Offset = "0x1DBDF80", VA = "0x181DBEB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x996260", Offset = "0x995660", VA = "0x180996260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xF5ADD0", Offset = "0xF5A1D0", VA = "0x180F5ADD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84FBD0", VA = "0x1808507D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8507F0", Offset = "0x84FBF0", VA = "0x1808507F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x40F46D0", Offset = "0x40F3AD0", VA = "0x1840F46D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1DBFAB0", Offset = "0x1DBEEB0", VA = "0x181DBFAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8821E0", Offset = "0x8815E0", VA = "0x1808821E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x882240", Offset = "0x881640", VA = "0x180882240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x855F20", Offset = "0x855320", VA = "0x180855F20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x855F00", Offset = "0x855300", VA = "0x180855F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x856030", Offset = "0x855430", VA = "0x180856030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x855F50", Offset = "0x855350", VA = "0x180855F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x855F10", Offset = "0x855310", VA = "0x180855F10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x856010", Offset = "0x855410", VA = "0x180856010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xAB1560", Offset = "0xAB0960", VA = "0x180AB1560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xBC71D0", Offset = "0xBC65D0", VA = "0x180BC71D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x855F80", Offset = "0x855380", VA = "0x180855F80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x855FD0", Offset = "0x8553D0", VA = "0x180855FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xB372F0", Offset = "0xB366F0", VA = "0x180B372F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xAB6500", Offset = "0xAB5900", VA = "0x180AB6500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84C150", VA = "0x18084CD50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x84CCF0", Offset = "0x84C0F0", VA = "0x18084CCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x97ECA0", Offset = "0x97E0A0", VA = "0x18097ECA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xC69D30", Offset = "0xC69130", VA = "0x180C69D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x988890", Offset = "0x987C90", VA = "0x180988890")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9881D0", Offset = "0x9875D0", VA = "0x1809881D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public HJDLNPHIIDN UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1E6EAE0", Offset = "0x1E6DEE0", VA = "0x181E6EAE0")]
			get
			{
				return default(HJDLNPHIIDN);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1E6D600", Offset = "0x1E6CA00", VA = "0x181E6D600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB3E650", Offset = "0xB3DA50", VA = "0x180B3E650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xB3E750", Offset = "0xB3DB50", VA = "0x180B3E750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x67D12C0", Offset = "0x67D06C0", VA = "0x1867D12C0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x67D1300", Offset = "0x67D0700", VA = "0x1867D1300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x67D0E50", Offset = "0x67D0250", VA = "0x1867D0E50")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public EPOJMBFGCMA BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private ACJEOEJGGDE? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x67D2CB0", Offset = "0x67D20B0", VA = "0x1867D2CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
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
