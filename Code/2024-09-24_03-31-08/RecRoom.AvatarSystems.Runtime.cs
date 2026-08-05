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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A6BD20", Offset = "0x6A6A720", VA = "0x186A6BD20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BDA0", Offset = "0x6A6A7A0", VA = "0x186A6BDA0", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DEKINLCKNLM]
internal class GPHDGGAECLK : GFFCGFEPLCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HGKLALCAFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public GPHDGGAECLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public KPAFIKBMJHO avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CHKDBNHDDEE DNCIGPIJLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CBMHAIAJMGJ KCCOGNDJBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MIPPOBGKEOE LMBPBIPOMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LCOPDDLFHOK GKAMBOJKBLP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A010", Offset = "0x6A68A10", VA = "0x186A6A010")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	[UsedImplicitly]
	internal static void GJFEGKCJKML(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AD60", Offset = "0x6A69760", VA = "0x186A6AD60")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GPHDGGAECLK([LKKACOOMNBP(null)] CHKDBNHDDEE DNCIGPIJLHC, [LKKACOOMNBP(null)] CBMHAIAJMGJ KCCOGNDJBAG, [LKKACOOMNBP(null)] MIPPOBGKEOE LMBPBIPOMEN, [LKKACOOMNBP(null)] LCOPDDLFHOK GKAMBOJKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A1A0", Offset = "0x6A68BA0", VA = "0x186A6A1A0", Slot = "5")]
	public DLHFACFAANC JABDMMDDAGP(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A69560", Offset = "0x6A67F60", VA = "0x186A69560", Slot = "4")]
	public DLHFACFAANC FJEMNHMFDCA(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AC50", Offset = "0x6A69650", VA = "0x186A6AC50", Slot = "6")]
	public AJIOFMBJNMD PIEJCHAKOCM(DLHFACFAANC LNCKNHNHHDF, int LDENBEFJCEC, string? DDDMPLCOGIM, string? ACJJNHMJBNL, BIJHKDPNNOK CIGMBCEOBCE, List<GJADONOJELD>? POMIPIBJBED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A080", Offset = "0x6A68A80", VA = "0x186A6A080", Slot = "7")]
	public bool HLELPPPHBHL(NMJLDHGPEHE PMHDOECBHBP, [Out] DLHFACFAANC? FFJKBJMDJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A69F30", Offset = "0x6A68930", VA = "0x186A69F30", Slot = "8")]
	public bool GIJKMOHDKBK(AJIOFMBJNMD AJEIOKOIKOM, [Out] DLHFACFAANC? FFJKBJMDJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A110", Offset = "0x6A68B10", VA = "0x186A6A110", Slot = "9")]
	public bool ILPEBKMCEDL(AJIOFMBJNMD AJEIOKOIKOM, [Out] HDCOJNPPCGK? PMHDOECBHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D74AA0", Offset = "0x2D734A0", VA = "0x182D74AA0")]
	private bool IBGKOHIIABH<TInput, TOutput>(TInput AHBBCFFJCCJ, CPHFKPIAEGC<TInput, TOutput> BPHBGNGGDJM, [Out] TOutput? NLAECIHBKHE) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A693B0", Offset = "0x6A67DB0", VA = "0x186A693B0")]
	[CompilerGenerated]
	private LJNKIOIAELL EONBPNFAAAG(FaceFeatureType AOGGPMLOFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A970", Offset = "0x6A69370", VA = "0x186A6A970")]
	[CompilerGenerated]
	private LJNKIOIAELL ODGKKNPAKII(FaceFeatureType AOGGPMLOFJF, HGKLALCAFJI P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DEKINLCKNLM]
internal class AGJEFKLNLDG : CHKDBNHDDEE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void AFBDPHBKFLJ<in TData>(TData FFJKBJMDJMD, IReadOnlyList<GJADONOJELD>? POMIPIBJBED);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MIPPOBGKEOE LMBPBIPOMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HIMJLHGHAJA DONCNEAGOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AFBDPHBKFLJ<DLHFACFAANC>?[] DNCIGPIJLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AFBDPHBKFLJ<HDCOJNPPCGK>?[] GBCJMDDHKEN;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B470", Offset = "0x6A49E70", VA = "0x186A4B470")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	[UsedImplicitly]
	internal static void GJFEGKCJKML(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C170", Offset = "0x6A4AB70", VA = "0x186A4C170")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AGJEFKLNLDG([LKKACOOMNBP(null)] MIPPOBGKEOE LMBPBIPOMEN, [LKKACOOMNBP(null)] HIMJLHGHAJA DONCNEAGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B340", Offset = "0x6A49D40", VA = "0x186A4B340", Slot = "4")]
	public bool CDLHCFACBMI(DLHFACFAANC FFJKBJMDJMD, IReadOnlyList<GJADONOJELD>? POMIPIBJBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B1E0", Offset = "0x6A49BE0", VA = "0x186A4B1E0", Slot = "5")]
	public bool CDLHCFACBMI(HDCOJNPPCGK PMHDOECBHBP, IReadOnlyList<GJADONOJELD>? POMIPIBJBED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B740", Offset = "0x6A4A140", VA = "0x186A4B740")]
	private void JEHHPKIMBOA(DLHFACFAANC FFJKBJMDJMD, IReadOnlyList<GJADONOJELD>? DICHKFJDHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B4E0", Offset = "0x6A49EE0", VA = "0x186A4B4E0")]
	private void HDDACJHAHIO(DLHFACFAANC FFJKBJMDJMD, IReadOnlyList<GJADONOJELD>? DICHKFJDHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B440", Offset = "0x6A49E40", VA = "0x186A4B440")]
	private void ECEMGNICCDD(DLHFACFAANC FFJKBJMDJMD, IReadOnlyList<GJADONOJELD>? DICHKFJDHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B710", Offset = "0x6A4A110", VA = "0x186A4B710")]
	private void IBEGIOKJEPP(DLHFACFAANC FFJKBJMDJMD, IReadOnlyList<GJADONOJELD>? DICHKFJDHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CHKDBNHDDEE
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CDLHCFACBMI(DLHFACFAANC FFJKBJMDJMD, IReadOnlyList<GJADONOJELD>? POMIPIBJBED);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CDLHCFACBMI(HDCOJNPPCGK PMHDOECBHBP, IReadOnlyList<GJADONOJELD>? POMIPIBJBED);
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
		public JFNLIAEECCK AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6A4C520", Offset = "0x6A4AF20", VA = "0x186A4C520")]
		public void AJDAPADPMCB(AnimationPoseSetting CGCLEIBHLHF, float CMGJOFEJLAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C650", Offset = "0x6A4B050", VA = "0x186A4C650")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendHelperController : MonoBehaviour, IFKIABHOMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
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
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
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
		private Vector3? MGHJGJGDLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool LNAKPHOJALL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C670", Offset = "0x6A4B070", VA = "0x186A4C670", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A4CC50", Offset = "0x6A4B650", VA = "0x186A4CC50", Slot = "4")]
		public void UpdateController(float CPLJOMEDMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x10B2C80", Offset = "0x10B1680", VA = "0x1810B2C80", Slot = "6")]
		public void SetEnabled(bool IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C710", Offset = "0x6A4B110", VA = "0x186A4C710")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D0E0", Offset = "0x6A4BAE0", VA = "0x186A4D0E0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarElbowBendTargetController : MonoBehaviour, IFKIABHOMBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float NINFDAIMKOD = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
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
		private Vector3 FGKMFIGKIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 JNHKFOAKCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool LNAKPHOJALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float MOFLANKGCMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float OFMNMNPGHPC;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D460", Offset = "0x6A4BE60", VA = "0x186A4D460", Slot = "4")]
		public void UpdateController(float CPLJOMEDMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xB90FB0", Offset = "0xB8F9B0", VA = "0x180B90FB0", Slot = "6")]
		public void SetEnabled(bool IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D180", Offset = "0x6A4BB80", VA = "0x186A4D180")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DF20", Offset = "0x6A4C920", VA = "0x186A4DF20")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E820", Offset = "0x6A4D220", VA = "0x186A4E820")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E7E0", Offset = "0x6A4D1E0", VA = "0x186A4E7E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DF50", Offset = "0x6A4C950", VA = "0x186A4DF50")]
		private void JMLIEIPLPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A15730", Offset = "0x6A14130", VA = "0x186A15730", Slot = "4")]
		public void SetEnabled(bool PBBOCFHFMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E850", Offset = "0x6A4D250", VA = "0x186A4E850")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarForearmRollController : MonoBehaviour, IFKIABHOMBF
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
		private float MOFLANKGCMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool LNAKPHOJALL;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E890", Offset = "0x6A4D290", VA = "0x186A4E890", Slot = "4")]
		public void UpdateController(float CPLJOMEDMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1050860", Offset = "0x104F260", VA = "0x181050860", Slot = "6")]
		public void SetEnabled(bool IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F310", Offset = "0x6A4DD10", VA = "0x186A4F310")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HandDisplaySettings HandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Header("Watch")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x359")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F380", Offset = "0x6A4DD80", VA = "0x186A4F380")]
		public AnimationPoseSetting BHFAOLPDMCB(JFNLIAEECCK OBIIPDJPALK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F340", Offset = "0x6A4DD40", VA = "0x186A4F340")]
		public void BDNFIJHBNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F3B0", Offset = "0x6A4DDB0", VA = "0x186A4F3B0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A69370", Offset = "0x6A67D70", VA = "0x186A69370")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MHAPGGKGIKO : DCLIPBJBPPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static int LPEIGOOOEEL;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int BNFEGMHDEFI;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int GGBJPADMHLG;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int MMOBMNDMOPH;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int DKPEEGFMMDN;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static int BOPBICMDFPH;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int KHKHEFKGCMC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int[] MLFAJOJOEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private HICNFDHGCAO IKBLAONMFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private GJPEHIFCNFC OIOPEKHFMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int LPHBJBPIODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float AAGDCBECFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Animator OMNOGMANLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AvatarFullBodyConfiguration KGKIHMKBKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int HNBDJFHBBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private int CPNMIKPDPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int PBHAGBNGOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool KCJFPCOEPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private EILAKOKDEEF GAOBKCLPHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int MHNKDJMIKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private float KLOOGFFPOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private HandDisplaySettings FAHBKMGJCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private KPAFIKBMJHO CNALACGMMNA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform DLAFNJLAOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 HBNBCJDHPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x101F9B0", Offset = "0x101E3B0", VA = "0x18101F9B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x101FA60", Offset = "0x101E460", VA = "0x18101FA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion OEADNAKNFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x16725A0", Offset = "0x1670FA0", VA = "0x1816725A0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x20B8B00", Offset = "0x20B7500", VA = "0x1820B8B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool NDMOJIDHEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B740", Offset = "0x6A6A140", VA = "0x186A6B740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B3D0", Offset = "0x6A69DD0", VA = "0x186A6B3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 PEFDIANDPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE19A40", Offset = "0xE18440", VA = "0x180E19A40", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xE187C0", Offset = "0xE171C0", VA = "0x180E187C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion LGFCBHKCINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAFA6A0", Offset = "0xAF90A0", VA = "0x180AFA6A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE17E20", Offset = "0xE16820", VA = "0x180E17E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PCHLGAICDCO HOPEODJHNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9BBA40", Offset = "0x9BA440", VA = "0x1809BBA40", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(PCHLGAICDCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9BBC70", Offset = "0x9BA670", VA = "0x1809BBC70", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PCHLGAICDCO FLHNHNBDEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x14E1940", Offset = "0x14E0340", VA = "0x1814E1940", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(PCHLGAICDCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1C4FC90", Offset = "0x1C4E690", VA = "0x181C4FC90", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float FIKAMILIDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x16AA1E0", Offset = "0x16A8BE0", VA = "0x1816AA1E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9BD0A0", Offset = "0x9BBAA0", VA = "0x1809BD0A0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool NEMPLPOJFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B7C0", Offset = "0x6A6A1C0", VA = "0x186A6B7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MGHJHBFAPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A6BA70", Offset = "0x6A6A470", VA = "0x186A6BA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DIKOIPOJLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A6B400", Offset = "0x6A69E00", VA = "0x186A6B400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MMODNBNHCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6A6AF70", Offset = "0x6A69970", VA = "0x186A6AF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AF80", Offset = "0x6A69980", VA = "0x186A6AF80", Slot = "21")]
	public void HINDDHMAHAN(HICNFDHGCAO BLIKBCJANJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B7D0", Offset = "0x6A6A1D0", VA = "0x186A6B7D0")]
	public void NAAIOOEEDHL(GJPEHIFCNFC GFGJCOMHPIP, HandDisplaySettings ONONNKMGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B820", Offset = "0x6A6A220", VA = "0x186A6B820", Slot = "12")]
	public void NOFHJDNOPFP(bool MPFEOFHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B410", Offset = "0x6A69E10", VA = "0x186A6B410", Slot = "11")]
	public void MBNHOAKHEAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B8B0", Offset = "0x6A6A2B0", VA = "0x186A6B8B0")]
	private int OMEPFDHPKLK(PCHLGAICDCO JMKCOOIEHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B1C0", Offset = "0x6A69BC0", VA = "0x186A6B1C0")]
	private void JGOFPLBPEIP(int NHPJABIAHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B3B0", Offset = "0x6A69DB0", VA = "0x186A6B3B0", Slot = "13")]
	public bool LBOKHMLCKNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B360", Offset = "0x6A69D60", VA = "0x186A6B360", Slot = "14")]
	public bool KOHKGNLKKMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B770", Offset = "0x6A6A170", VA = "0x186A6B770")]
	private PCHLGAICDCO MKIPEOOOIDB()
	{
		return default(PCHLGAICDCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x974170", Offset = "0x972B70", VA = "0x180974170", Slot = "15")]
	public void CIFBCFAJJNA(bool MPFEOFHFNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B370", Offset = "0x6A69D70", VA = "0x186A6B370", Slot = "10")]
	public void LAIKDKNJOCC(int NHPJABIAHMM, float BALNPFFFJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AF50", Offset = "0x6A69950", VA = "0x186A6AF50", Slot = "8")]
	public void BLKJNBJNPMO(EILAKOKDEEF PFFGBBPKGJN, bool GJHDHJFGOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B1B0", Offset = "0x6A69BB0", VA = "0x186A6B1B0", Slot = "9")]
	public void HKAIKEJMAJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B310", Offset = "0x6A69D10", VA = "0x186A6B310", Slot = "16")]
	public void KAIFGJLADFK(Transform KMAENCDMJDN, Vector3 CAAPHPLMKPD, Quaternion KHIGADNNPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6BD10", Offset = "0x6A6A710", VA = "0x186A6BD10")]
	public MHAPGGKGIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CHIAEEAFOAC : EAIPNMNJOEO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class EAPDPMGBOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 OEBNKAIEFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Quaternion ENKIJNFLKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Vector3 EDFCEDCFMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Transform DLDECKAGCFP;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 ENJDHIFNDFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x16F7060", Offset = "0x16F5A60", VA = "0x1816F7060")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x16F7080", Offset = "0x16F5A80", VA = "0x1816F7080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion AHFMCEEEDNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xD631D0", Offset = "0xD61BD0", VA = "0x180D631D0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD631C0", Offset = "0xD61BC0", VA = "0x180D631C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float PEFCHOJICOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAFA750", Offset = "0xAF9150", VA = "0x180AFA750")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x10D48C0", Offset = "0x10D32C0", VA = "0x1810D48C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool LEGLCJPNOFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x88B1D0", Offset = "0x889BD0", VA = "0x18088B1D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x88B240", Offset = "0x889C40", VA = "0x18088B240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool NHHALPHODFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x88B2E0", Offset = "0x889CE0", VA = "0x18088B2E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x88B210", Offset = "0x889C10", VA = "0x18088B210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool AGNADPNCGKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x88B300", Offset = "0x889D00", VA = "0x18088B300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x88B200", Offset = "0x889C00", VA = "0x18088B200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float OKGPGOEHBPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAFA770", Offset = "0xAF9170", VA = "0x180AFA770")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x2708E10", Offset = "0x2707810", VA = "0x182708E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A69280", Offset = "0x6A67C80", VA = "0x186A69280")]
		public void OLGHAHDEFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A68710", Offset = "0x6A67110", VA = "0x186A68710")]
		public void CLPLBMAPBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A68720", Offset = "0x6A67120", VA = "0x186A68720")]
		public float CPHMPFDALNB(Transform BMOLIBAGCCP, [In] FootSettings LOPFBNMGIEF, float GLEIPEGLCJA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A68900", Offset = "0x6A67300", VA = "0x186A68900")]
		public void ODEEOGPCPFN(Transform FEAIIBOCALI, Transform BKGBBODEKMI, float JFMEPELMKNI, bool GBMPDKJMAMC, bool PFHJKFNBJAJ, float PBHHOODMAMD, float GAFPOPKIOJI, Transform BAFHJDFHJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A69050", Offset = "0x6A67A50", VA = "0x186A69050")]
		public void OHCDGCPMICB(Transform CDJIGJNHMME, Transform BAFHJDFHJHD, bool MOABHAIEKGG, bool COPKKJKIHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A68610", Offset = "0x6A67010", VA = "0x186A68610")]
		private void APIEHNNPKOD(Transform BAFHJDFHJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A69290", Offset = "0x6A67C90", VA = "0x186A69290")]
		public void PLNKAAIEFEK(Transform BAFHJDFHJHD, AvatarFullBodyConfiguration EILKMNJGOBA, Vector3 IICPJOLMNGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A688F0", Offset = "0x6A672F0", VA = "0x186A688F0")]
		public void JEAMPGMFGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A69360", Offset = "0x6A67D60", VA = "0x186A69360")]
		public EAPDPMGBOBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class DFAEHKLFOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float JKNGJHIAKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool IOEIMACKDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AnimationPoseSetting PNLNGAKPNHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float DLOPJLJAPOG;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A67C30", Offset = "0x6A66630", VA = "0x186A67C30")]
		public void KBLEOEOMHMK(IKSolverVR.Arm OLKJFGAMAIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A67A90", Offset = "0x6A66490", VA = "0x186A67A90")]
		public void EDPLFMNOPNN(IKSolverVR.Arm OLKJFGAMAIP, float HPKNAEIAEEM, bool IOEIMACKDJG, AvatarFullBodyConfiguration EILKMNJGOBA, float PJCCLBGHKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A67450", Offset = "0x6A65E50", VA = "0x186A67450")]
		private void AONJCKMFNOP(IKSolverVR.Arm OLKJFGAMAIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A67070", Offset = "0x6A65A70", VA = "0x186A67070")]
		public void AOLKNKCEIIM(IKSolverVR.Arm OLKJFGAMAIP, Transform KPOFKOOMAHA, Transform BKGBBODEKMI, Quaternion NJMGMONNNIL, Vector3 AIBNBKDEEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A68100", Offset = "0x6A66B00", VA = "0x186A68100")]
		private (Vector3, Quaternion) LEFILCCNKGJ(MHAPGGKGIKO FIGJPIHGKAE, Quaternion ENDJGCNFAIH, Vector3 OGMIHMLLECG)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A67AD0", Offset = "0x6A664D0", VA = "0x186A67AD0")]
		public void JKMMOMDOLNO(MHAPGGKGIKO FIGJPIHGKAE, IKSolverVR.Arm OLKJFGAMAIP, Quaternion ENDJGCNFAIH, Vector3 OGMIHMLLECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A67490", Offset = "0x6A65E90", VA = "0x186A67490")]
		public void DEINEMAKAEH(MHAPGGKGIKO FIGJPIHGKAE, IKSolverVR.Arm OLKJFGAMAIP, Quaternion ENDJGCNFAIH, Vector3 OGMIHMLLECG, [In] AvatarFullBodyConfiguration EILKMNJGOBA, [In] LIIDFOAKDJP PFFGBBPKGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A66F30", Offset = "0x6A65930", VA = "0x186A66F30")]
		public void ANJDBKMBAAC(JFNLIAEECCK JABBIOIEFKL, AvatarFullBodyConfiguration EILKMNJGOBA, LIIDFOAKDJP PFFGBBPKGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A67C60", Offset = "0x6A66660", VA = "0x186A67C60")]
		public void KBMANDPJAPG(IKSolverVR.Arm OLKJFGAMAIP, Transform KPOFKOOMAHA, Vector3 DMNIPPJFMHL, float NCPMJIHCPFH, Quaternion DJFDMKGCNHF, Vector3 FBPJLBDENEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A68590", Offset = "0x6A66F90", VA = "0x186A68590")]
		public DFAEHKLFOAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum OPJPNEJCIDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int GOIMLEHPNBK;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int EFPPLGBNDJP;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int FKFCLNBFNCM;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int CKFDIJJFLOO;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int EDAONMBMKIB;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int KOMNHFNGCPH;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int EMBNGGFMBMA;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int JOLFEMIPOBN;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int EMMJFLONONA;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int KACPEIFACDE;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int PBDFCPLBABJ;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int ALGKLDMEHIL;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int LGIGCBBMIOA;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int ONNPGGHCLPD;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int DMKHBBMECAH;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int AFMBMGHEPDG;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int OHENLAKIEBF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int KEEACMOLPFA;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int HAHENKOPLHL;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int NMJHBKGDOHK;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int JKFAHNKNOKL;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int CFCDJJHGPAH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int DAIBECLAFEG;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int NKENDEMDBJI;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int IDBAAHGPKIB;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int NEMCHFGLJCC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int ACDEHMCDAFM;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int CNCBLHAKHMD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int CEEFBHJCLKH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly Vector3 AGIBCOPDEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool OHBLNEMKIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool OMEGPBCMDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool IKHELPGFPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool BMFICMDKHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool AEODMKBPAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Vector3 BOHFKPGPMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private string BMJACHMFMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private KDMJBOGGEPA? IKBLAONMFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private MKJGAODFAGO? OFLHFHFACGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private OBOOFNFPMMC CALOAFBBCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PDJDJECFKJA LNFKJBFBJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private MHAPGGKGIKO NKNAOELEBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private MHAPGGKGIKO GIKBCMKMDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool LGOGEKADPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool PABFDHMAOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly EJDBMMGGFDF FMOAOBIOCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly GIHLAEGKLGC KFKGOIOAHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int CAPHDGLPFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private float JIPDHEOJKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private GameObject LJNFAMCADCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Transform LDIFPKPIDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform HKNIPHEDMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Transform OPPPNDCMEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform FMKBNFJALII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform CAEODEJAIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float DICGADPHNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float CGBOIEAMEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Vector3 EEFIANLCLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Quaternion GOAAPCPCGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform BPCGLKBDMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform KHGOJEINKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform JIMJMLACJLI;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker PCHNIHDFEGM;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker GCJOFGGILPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private ProfilerMarker MECPLAEODBP;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker OGFLGLCCDGD;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker MKCOMOFGJPF;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker IDFKPBJGJBE;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly List<CHIAEEAFOAC> MAAAGBGEBEE;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int DKGBGAODMNN;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> CDJCMJBODBI;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int FLMBBKMLDDI;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int DOPHADEBEPD;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int NPFBOKIPINO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int KKHEPAFJOBE;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static float PMADMPIDHFE;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int GALEKGPEJNK;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static float OAEJNPDPKMN;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static float JCFFLMDOOJH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float BGMJMEBLDBH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static float DNGHMMKMELF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static ONKABCNFBBO IMMOMJDFBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float JBDPLAMNJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool PGCLKOGKJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float PHAAHBIEBKA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly int ICKDINJMOOF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly int IPFFBBGABOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private EAPDPMGBOBG PDPCOBHCOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private EAPDPMGBOBG GFKCGGCHIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private float LBHLMOCEFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Vector3 BBLKIMEDAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private Vector3 JHIKCPJKKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool KNJJMHENOHM;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly Quaternion FHCCGBKLOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly Quaternion KIIKABKIEKF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly Vector3 OEENEFKEJFP;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly Vector3 EGAPNHFONNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float GHHCDFMLODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float GIGEPHGKBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private DFAEHKLFOAC CAKHLAGKDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private DFAEHKLFOAC JGHNOBMIMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private JJGMEIHJKPE KOFELAOKFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private PBJPDDJBMDJ NFLFCALNDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly LOOPFJMNIDF HLKHJGLBMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float BADAGIDADAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float PAOCJAJDLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly PBJPDDJBMDJ ICDDDLKJFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 MGHNAENKCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 DPOOHNPALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float KKPCDGKIHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private float HAFKFKKALIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly PBJPDDJBMDJ MFBBHHOPMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly JJGMEIHJKPE KAGPLAKHFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly PBJPDDJBMDJ ABPLAAEDMMN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BPJHNJKJMPB MHCGDGPFPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BPJHNJKJMPB MBEANKMCCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration HIBNMLGNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A55D10", Offset = "0x6A54710", VA = "0x186A55D10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public KPAFIKBMJHO HNNNBEDDMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A50FA0", Offset = "0x6A4F9A0", VA = "0x186A50FA0", Slot = "23")]
		get
		{
			return default(KPAFIKBMJHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration PAKBIPODDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A582D0", Offset = "0x6A56CD0", VA = "0x186A582D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform HJFAGFPAMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6A58A60", Offset = "0x6A57460", VA = "0x186A58A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform FPFPOJBOBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A55370", Offset = "0x6A53D70", VA = "0x186A55370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer OLKMDODKCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A50EA0", Offset = "0x6A4F8A0", VA = "0x186A50EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] BHGJLKEGMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A55E90", Offset = "0x6A54890", VA = "0x186A55E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] IDOLOJHFMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A580D0", Offset = "0x6A56AD0", VA = "0x186A580D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator GIAAELMBPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A65BD0", Offset = "0x6A645D0", VA = "0x186A65BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK GDOELPBCICB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A515B0", Offset = "0x6A4FFB0", VA = "0x186A515B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private IFKIABHOMBF CECDNBBLKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A581D0", Offset = "0x6A56BD0", VA = "0x186A581D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private IFKIABHOMBF LDNHILKMPOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A65CD0", Offset = "0x6A646D0", VA = "0x186A65CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private IFKIABHOMBF KGCEBDBDKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A62B50", Offset = "0x6A61550", VA = "0x186A62B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private IFKIABHOMBF PMMOKHPJCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A62000", Offset = "0x6A60A00", VA = "0x186A62000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private IFKIABHOMBF LMGHEODNEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A55F90", Offset = "0x6A54990", VA = "0x186A55F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private IFKIABHOMBF CLOJGJIKOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A514B0", Offset = "0x6A4FEB0", VA = "0x186A514B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private IFKIABHOMBF FFCKDAAIPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E240", Offset = "0x6A5CC40", VA = "0x186A5E240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private IFKIABHOMBF FGBFFPPKIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6A654B0", Offset = "0x6A63EB0", VA = "0x186A654B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public MKJGAODFAGO KEOCDLGPOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6A62950", Offset = "0x6A61350", VA = "0x186A62950", Slot = "15")]
		get
		{
			return default(MKJGAODFAGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GEBCNIOAIHJ JLCGLLNGLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1578820", Offset = "0x1577220", VA = "0x181578820", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public PIOIOFPJAKI EKJBPCNKCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x161EA30", Offset = "0x161D430", VA = "0x18161EA30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DCLIPBJBPPJ NECINBMPPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x19AE9F0", Offset = "0x19AD3F0", VA = "0x1819AE9F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public DCLIPBJBPPJ IAIDCCMLKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1734F10", Offset = "0x1733910", VA = "0x181734F10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string OFHMAAEAELD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform NIMOFGEIAID
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A51460", Offset = "0x6A4FE60", VA = "0x186A51460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform DINCCLKJFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A65B60", Offset = "0x6A64560", VA = "0x186A65B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform CACCKKOIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F920", Offset = "0x6A4E320", VA = "0x186A4F920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool CEIANDAANFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A510A0", Offset = "0x6A4FAA0", VA = "0x186A510A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform DLJDEMKCBFF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A53B10", Offset = "0x6A52510", VA = "0x186A53B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject BICFCMICGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A5DA10", Offset = "0x6A5C410", VA = "0x186A5DA10", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets HMOAOAEJOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B260", Offset = "0x6A59C60", VA = "0x186A5B260", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform IDKIGLHHNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD42FA0", Offset = "0xD419A0", VA = "0x180D42FA0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform DPPCICCIICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD42F80", Offset = "0xD41980", VA = "0x180D42F80", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CGNNDIGKNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x17350A0", Offset = "0x1733AA0", VA = "0x1817350A0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform PCMJFGLABMO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1534350", Offset = "0x1532D50", VA = "0x181534350", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 NJOIPMFDGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A548B0", Offset = "0x6A532B0", VA = "0x186A548B0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float MLCPFGJLAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A5EB20", Offset = "0x6A5D520", VA = "0x186A5EB20", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform BFIGCIPMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FD90", Offset = "0x6A4E790", VA = "0x186A4FD90", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform PEBBLCGIEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1A231B0", Offset = "0x1A21BB0", VA = "0x181A231B0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform LGOKNNEMPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1A23290", Offset = "0x1A21C90", VA = "0x181A23290", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform EAHKJPLDHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1534F20", Offset = "0x1533920", VA = "0x181534F20", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool BNGGKMOOBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A5D1B0", Offset = "0x6A5BBB0", VA = "0x186A5D1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool IBGBAHHICDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A55E10", Offset = "0x6A54810", VA = "0x186A55E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool PHOFLFHMOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A62AD0", Offset = "0x6A614D0", VA = "0x186A62AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A56830", Offset = "0x6A55230", VA = "0x186A56830")]
	private void FKKOGOIACMH([In] LIIDFOAKDJP KKPFMKHMJNK, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A54FD0", Offset = "0x6A539D0", VA = "0x186A54FD0")]
	private void EFGHOIGMLGD(LIIDFOAKDJP KKPFMKHMJNK, AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A59090", Offset = "0x6A57A90", VA = "0x186A59090")]
	private void HALIBCKIENC([In] LIIDFOAKDJP PFFGBBPKGJN, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A66A80", Offset = "0x6A65480", VA = "0x186A66A80")]
	public CHIAEEAFOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A62C50", Offset = "0x6A61650", VA = "0x186A62C50", Slot = "12")]
	public void OIHGANNGDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A62100", Offset = "0x6A60B00", VA = "0x186A62100", Slot = "13")]
	public void MPAPCJBNMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D0E0", Offset = "0x6A5BAE0", VA = "0x186A5D0E0", Slot = "14")]
	public void KECKIEOACEE(bool ONLMMLNABIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A516B0", Offset = "0x6A500B0", VA = "0x186A516B0", Slot = "25")]
	public Transform CILPJBOLLLB(string KKGJMHJKAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A62580", Offset = "0x6A60F80", VA = "0x186A62580", Slot = "26")]
	public Vector3? NKPHJBMLGCP(string KKGJMHJKAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A583A0", Offset = "0x6A56DA0", VA = "0x186A583A0", Slot = "7")]
	public void GKEEEHECBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A58B60", Offset = "0x6A57560", VA = "0x186A58B60")]
	private void GNIIJDBBDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A51800", Offset = "0x6A50200", VA = "0x186A51800", Slot = "6")]
	public void CJMBLEGCJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A628E0", Offset = "0x6A612E0", VA = "0x186A628E0", Slot = "8")]
	public void NLGHDHECAFL(float CIEKKEFDGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AB20", Offset = "0x6A59520", VA = "0x186A5AB20")]
	private void IHPIEJBJBFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A63170", Offset = "0x6A61B70", VA = "0x186A63170", Slot = "4")]
	public void OLAFFFJADPF(string CDHDLKJANDG, KDMJBOGGEPA PJLPKFJPPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A59780", Offset = "0x6A58180", VA = "0x186A59780", Slot = "5")]
	public void HHMKIOBOOHL(MKJGAODFAGO GFGJCOMHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AA30", Offset = "0x6A59430", VA = "0x186A5AA30", Slot = "11")]
	public void IHNIBIDJAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A53510", Offset = "0x6A51F10", VA = "0x186A53510", Slot = "24")]
	public void DFPJPFEMLJB([Out] Vector3 OPGAPMIPPLJ, [Out] Quaternion DJFDMKGCNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B230", Offset = "0x6A59C30", VA = "0x186A5B230")]
	private void JFCECIIMFME([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AB70", Offset = "0x6A59570", VA = "0x186A5AB70", Slot = "27")]
	public void INANLHCJEIG(float KDFMECJCGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A59430", Offset = "0x6A57E30", VA = "0x186A59430", Slot = "28")]
	public void HHLPMBJJGMH(float NFMNJJOKMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A61910", Offset = "0x6A60310", VA = "0x186A61910", Slot = "44")]
	public void MJKCNCOCMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A65B10", Offset = "0x6A64510", VA = "0x186A65B10", Slot = "29")]
	public void PENAMBACENA(bool JNDFGAACNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CFB0", Offset = "0x6A5B9B0", VA = "0x186A5CFB0", Slot = "30")]
	public HandLogicOffsets JPHLPFMIOCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A624C0", Offset = "0x6A60EC0", VA = "0x186A624C0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets NKBJIDDLFGM()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C680", Offset = "0x6A5B080", VA = "0x186A5C680")]
	private void JNKLDBKLONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AB80", Offset = "0x6A59580", VA = "0x186A5AB80")]
	private void IOBOELACMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A60050", Offset = "0x6A5EA50", VA = "0x186A60050")]
	private void MGFDPPENLNL(HFLALFLFNKL HAJDFFBCAJI, bool NOCMPIEOFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A59C40", Offset = "0x6A58640", VA = "0x186A59C40")]
	private void HLNNFIAABIC(HFLALFLFNKL HAJDFFBCAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A62A80", Offset = "0x6A61480", VA = "0x186A62A80")]
	public Vector3 NMJMLELADLP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DAB0", Offset = "0x6A5C4B0", VA = "0x186A5DAB0")]
	private void KKCNOADJIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A800", Offset = "0x6A59200", VA = "0x186A5A800")]
	private void HOHAEMDAGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B080", Offset = "0x6A59A80", VA = "0x186A5B080")]
	private float JBAILOCJHHJ([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D000", Offset = "0x6A5BA00", VA = "0x186A5D000")]
	private int KALGKCEHNAD([In] KJANIDNFMPP NEPIOBIFMDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C160", Offset = "0x6A5AB60", VA = "0x186A5C160")]
	private void JLDJMEKPMAD(LIIDFOAKDJP KKPFMKHMJNK, bool GOAHNHBBOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A820", Offset = "0x6A59220", VA = "0x186A5A820")]
	private static void IEKDKOIKECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B2E0", Offset = "0x6A59CE0", VA = "0x186A5B2E0")]
	private static void JJPHEPLBCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A59250", Offset = "0x6A57C50", VA = "0x186A59250")]
	private float HHBMNIEIFPH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A55470", Offset = "0x6A53E70", VA = "0x186A55470")]
	private static int EKJFPOBCOJO(CHIAEEAFOAC OMCEEKENOBB, CHIAEEAFOAC MOBHGIAPGGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F740", Offset = "0x6A4E140", VA = "0x186A4F740", Slot = "40")]
	public LIIDFOAKDJP ACFKHCJIEJF()
	{
		return default(LIIDFOAKDJP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A59E00", Offset = "0x6A58800", VA = "0x186A59E00")]
	public void HMBLPMJNGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DD70", Offset = "0x6A5C770", VA = "0x186A5DD70")]
	private (bool, bool) KKFAKHBCKOG()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A5EB70", Offset = "0x6A5D570", VA = "0x186A5EB70")]
	private void LIIJNCHBPOG([In] LIIDFOAKDJP PFFGBBPKGJN, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A60330", Offset = "0x6A5ED30", VA = "0x186A60330")]
	private void MGGAPFNLDJM([In] LIIDFOAKDJP PFFGBBPKGJN, [In] AvatarFullBodyConfiguration EILKMNJGOBA, FootSettings LOPFBNMGIEF, bool DOMGOHKFNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F8A0", Offset = "0x6A4E2A0", VA = "0x186A4F8A0")]
	private float AGNPPCKDJPN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A60750", Offset = "0x6A5F150", VA = "0x186A60750")]
	private void MIFJJLPGJJO(LIIDFOAKDJP PFFGBBPKGJN, AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A530C0", Offset = "0x6A51AC0", VA = "0x186A530C0")]
	private float DDMGMELHBDL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A54AE0", Offset = "0x6A534E0", VA = "0x186A54AE0")]
	private void EALNNNGDKHI([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FDF0", Offset = "0x6A4E7F0", VA = "0x186A4FDF0")]
	private void AOLKNKCEIIM([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A61A40", Offset = "0x6A60440", VA = "0x186A61A40")]
	private void MMEFGCBFLKA([In] LIIDFOAKDJP PFFGBBPKGJN, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A5DF90", Offset = "0x6A5C990", VA = "0x186A5DF90")]
	private void LAPFBMAJAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A4FB40", Offset = "0x6A4E540", VA = "0x186A4FB40")]
	private void AOEOIADEKNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A54940", Offset = "0x6A53340", VA = "0x186A54940")]
	private void EAEAAAEIMHO([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A655B0", Offset = "0x6A63FB0", VA = "0x186A655B0")]
	private void PEEKIECFJON(MHAPGGKGIKO OMKBKHNJNAD, IKSolverVR.Arm OLKJFGAMAIP, Transform PMLBABCMMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A510F0", Offset = "0x6A4FAF0", VA = "0x186A510F0")]
	private void CDFPCCELJFH(LIIDFOAKDJP PFFGBBPKGJN, AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FE80", Offset = "0x6A5E880", VA = "0x186A5FE80")]
	private void MBNHOAKHEAP(BCIEKGFGGCK MBGBDMDBMDF, DCLIPBJBPPJ OMKBKHNJNAD, IKSolverVR.Arm OLKJFGAMAIP, float HPKNAEIAEEM, float NACNIILKADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C8F0", Offset = "0x6A5B2F0", VA = "0x186A5C8F0")]
	private void JPCBGHMEEEJ([In] LIIDFOAKDJP PFFGBBPKGJN, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A53110", Offset = "0x6A51B10", VA = "0x186A53110")]
	protected void DFBJFGALCCK([In] LIIDFOAKDJP PFFGBBPKGJN, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A65840", Offset = "0x6A64240", VA = "0x186A65840")]
	private void PEGGDDGCHNF([In] LIIDFOAKDJP PFFGBBPKGJN, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D750", Offset = "0x6A5C150", VA = "0x186A5D750")]
	protected void KJMLPCMMAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A50720", Offset = "0x6A4F120", VA = "0x186A50720")]
	private void BFDKIJKGELC([In] LIIDFOAKDJP PFFGBBPKGJN, [In] OPJPNEJCIDM EDIABIBGOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A65160", Offset = "0x6A63B60", VA = "0x186A65160")]
	private void OOHNKABCBAN(LIIDFOAKDJP PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A58360", Offset = "0x6A56D60", VA = "0x186A58360")]
	private void GKDLLALAMDB([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A50140", Offset = "0x6A4EB40", VA = "0x186A50140")]
	private Vector3 BAHMPDHNBCO([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A50650", Offset = "0x6A4F050", VA = "0x186A50650")]
	private void BBMDHMCJOEA([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A58C60", Offset = "0x6A57660", VA = "0x186A58C60")]
	private float HAIFPOALMGE(float GAFPOPKIOJI, [In] LIIDFOAKDJP PFFGBBPKGJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C010", Offset = "0x6A5AA10", VA = "0x186A5C010")]
	private void JKMCEGCMIJK(float GAFPOPKIOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D2B0", Offset = "0x6A5BCB0", VA = "0x186A5D2B0")]
	private void KFLMGDFAOLJ([In] LIIDFOAKDJP PFFGBBPKGJN, OPJPNEJCIDM EDIABIBGOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A554A0", Offset = "0x6A53EA0", VA = "0x186A554A0")]
	private float EKMPDDICPFL([In] LIIDFOAKDJP KKPFMKHMJNK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A52B10", Offset = "0x6A51510", VA = "0x186A52B10")]
	private void CMCNAFFEPJM(LIIDFOAKDJP PFFGBBPKGJN, OPJPNEJCIDM EDIABIBGOPN, Vector3 EBPKCHAANFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A55B60", Offset = "0x6A54560", VA = "0x186A55B60")]
	private static void ELFBKNDHAFE(Transform ICGEMCDDICC, Quaternion PCIAHIPKDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A65DD0", Offset = "0x6A647D0", VA = "0x186A65DD0")]
	private void PKAMGACGNIH([In] LIIDFOAKDJP HPPFKGKBFCP, [In] KJANIDNFMPP NEPIOBIFMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A54040", Offset = "0x6A52A40", VA = "0x186A54040")]
	private void DICLBINLGJK([In] LIIDFOAKDJP HPPFKGKBFCP, [In] KJANIDNFMPP NEPIOBIFMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A4F990", Offset = "0x6A4E390", VA = "0x186A4F990")]
	private void AOCLPKMAHJL(float PJGHHGFBGOJ, [In] LIIDFOAKDJP KKPFMKHMJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A611D0", Offset = "0x6A5FBD0", VA = "0x186A611D0")]
	private float MJINFFIFHAD([In] LIIDFOAKDJP KKPFMKHMJNK, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A538A0", Offset = "0x6A522A0", VA = "0x186A538A0")]
	private void DGAGOCHKHCH([In] LIIDFOAKDJP KKPFMKHMJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E340", Offset = "0x6A5CD40", VA = "0x186A5E340")]
	private void LIALJJDKHKN([In] LIIDFOAKDJP KKPFMKHMJNK, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A56490", Offset = "0x6A54E90", VA = "0x186A56490")]
	private void FKGGPEMEOJJ([In] LIIDFOAKDJP KKPFMKHMJNK, float AMIEMAHGOGP, float GFKLNDHPJDK, Vector3 IMGDCBLPDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A59E40", Offset = "0x6A58840", VA = "0x186A59E40")]
	private void HOGIEFKHBNF(LIIDFOAKDJP KKPFMKHMJNK, AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A56090", Offset = "0x6A54A90", VA = "0x186A56090")]
	private void FJEEDHPIKAO(LIIDFOAKDJP KKPFMKHMJNK, AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A62710", Offset = "0x6A61110", VA = "0x186A62710")]
	public void NLEIEOGJANF([In] LIIDFOAKDJP PFFGBBPKGJN, [In] AvatarFullBodyConfiguration EILKMNJGOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A65310", Offset = "0x6A63D10", VA = "0x186A65310")]
	[CompilerGenerated]
	internal static void OPNMOJJBJEP(Transform EEBGELKKKEJ, IKSolverVR.Arm OLKJFGAMAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AFB0", Offset = "0x6A599B0", VA = "0x186A5AFB0")]
	[CompilerGenerated]
	internal static void IOJKFAEIEGC(EAPDPMGBOBG MPKOIJECIAH, EAPDPMGBOBG NPANIIFMAGB, Transform FIGADHKDKIB, float EJIIMGEBDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C7E0", Offset = "0x6A5B1E0", VA = "0x186A5C7E0")]
	[CompilerGenerated]
	internal static bool JONINIKGEEC(IKSolverVR.Arm OLKJFGAMAIP, APJLGFDLFBG HICMHKKLOFF, float DFHFOHAHLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A53C10", Offset = "0x6A52610", VA = "0x186A53C10")]
	[CompilerGenerated]
	internal static float DGGFLBIIDMI(Vector3 AFJBIOEPGAC, Vector3 DPAFFJFBHGN, Vector3 GALLKDDJEBB, LIIDFOAKDJP KKPFMKHMJNK, AvatarFullBodyConfiguration EILKMNJGOBA, float EDCGGCHLNEI)
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
		public enum EABCEDFCLJG
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private EABCEDFCLJG handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D640", Offset = "0x6A6C040", VA = "0x186A6D640")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D600", Offset = "0x6A6C000", VA = "0x186A6D600")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D000", Offset = "0x6A6BA00", VA = "0x186A6D000")]
		private void JMLIEIPLPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A15730", Offset = "0x6A14130", VA = "0x186A15730", Slot = "4")]
		public void SetEnabled(bool PBBOCFHFMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D670", Offset = "0x6A6C070", VA = "0x186A6D670")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarKneeBendTargetController : MonoBehaviour, IFKIABHOMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private Vector3 FGKMFIGKIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private Vector3 HPLNBKEOOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Vector3 NBIOJGMJPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Matrix4x4 ENPIHANPCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool LNAKPHOJALL;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DB10", Offset = "0x6A6C510", VA = "0x186A6DB10", Slot = "4")]
		public void UpdateController(float CPLJOMEDMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DB00", Offset = "0x6A6C500", VA = "0x186A6DB00", Slot = "6")]
		public void SetEnabled(bool IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D6A0", Offset = "0x6A6C0A0", VA = "0x186A6D6A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E1D0", Offset = "0x6A6CBD0", VA = "0x186A6E1D0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, BNBLNCOBKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[Header("Configuration")]
		[SerializeField]
		private KPAFIKBMJHO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[CCFGIEGBFJM(NEFCELJHDOC.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		[Header("Configuration")]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[Header("Facial Animation")]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private EAIPNMNJOEO OENPBGMHAHE;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EAIPNMNJOEO EGMNAKLFCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE60", Offset = "0x8CE860", VA = "0x1808CFE60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform AJJJFHDFFEE
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F060", Offset = "0x6A6DA60", VA = "0x186A6F060", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E1E0", Offset = "0x6A6CBE0", VA = "0x186A6E1E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EF20", Offset = "0x6A6D920", VA = "0x186A6EF20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EED0", Offset = "0x6A6D8D0", VA = "0x186A6EED0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EE60", Offset = "0x6A6D860", VA = "0x186A6EE60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E1E0", Offset = "0x6A6CBE0", VA = "0x186A6E1E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E660", Offset = "0x6A6D060", VA = "0x186A6E660", Slot = "6")]
		public EAIPNMNJOEO CreateAvatarSystem(string CDHDLKJANDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EE60", Offset = "0x6A6D860", VA = "0x186A6EE60", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E290", Offset = "0x6A6CC90", VA = "0x186A6E290", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EF70", Offset = "0x6A6D970", VA = "0x186A6EF70", Slot = "9")]
		public void UpdatePostIKAnimControllers(float CPLJOMEDMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[RecRoom.NoEngine.Common.Preserve]
internal class FMIKHIPIPGJ : OBENIFNLHGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private Dictionary<string, EAIPNMNJOEO> LALHLDDGJPH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A71B70", Offset = "0x6A70570", VA = "0x186A71B70")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void AOCLHBLDAGL(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A71BE0", Offset = "0x6A705E0", VA = "0x186A71BE0", Slot = "4")]
	public EAIPNMNJOEO BAKJDABJNEI(string OHCNACMPALG, AvatarSystemConfiguration GKOIFCHMJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A71E00", Offset = "0x6A70800", VA = "0x186A71E00", Slot = "5")]
	public void FLDNEFEJKEA(string OHCNACMPALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6A71F80", Offset = "0x6A70980", VA = "0x186A71F80", Slot = "6")]
	public string NBANMAGOHGP(string LCHHAJJEGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A720C0", Offset = "0x6A70AC0", VA = "0x186A720C0")]
	private string NOBBFGPLCPL(string LCHHAJJEGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A72130", Offset = "0x6A70B30", VA = "0x186A72130")]
	public FMIKHIPIPGJ()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class NOJANALLKDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private Dictionary<string, Transform> ILGCMGNMEGO;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool EMCJBNDMBFI
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x6A78D70", Offset = "0x6A77770", VA = "0x186A78D70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6A78C40", Offset = "0x6A77640", VA = "0x186A78C40")]
			public void FEGBGJFFDAI(VRIK NELOLBACIED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
			public void AALPNMOEHMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x6A78DB0", Offset = "0x6A777B0", VA = "0x186A78DB0")]
			public void NJEMNKBBDAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x6A78E00", Offset = "0x6A77800", VA = "0x186A78E00")]
			public NOJANALLKDD()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		[IBDNIDADCCI(NEFCELJHDOC.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		[CCFGIEGBFJM(NEFCELJHDOC.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly NOJANALLKDD JNPPNHDPCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private BNBLNCOBKHI DLIGDKEMIAK;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F0B0", Offset = "0x6A6DAB0", VA = "0x186A6F0B0")]
		private void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F390", Offset = "0x6A6DD90", VA = "0x186A6F390")]
		private bool JJLFLNCEHAH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F3E0", Offset = "0x6A6DDE0", VA = "0x186A6F3E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F450", Offset = "0x6A6DE50", VA = "0x186A6F450")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F3F0", Offset = "0x6A6DDF0", VA = "0x186A6F3F0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F6C0", Offset = "0x6A6E0C0", VA = "0x186A6F6C0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6A75270", Offset = "0x6A73C70", VA = "0x186A75270")]
		public void BDNFIJHBNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A75390", Offset = "0x6A73D90", VA = "0x186A75390")]
		public int DIGPNKIPDJA(int DICLOGJPGHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HandDisplaySettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6A75400", Offset = "0x6A73E00", VA = "0x186A75400")]
			public void BDNFIJHBNDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x6A754E0", Offset = "0x6A73EE0", VA = "0x186A754E0")]
			public (float, float) GPKLBFCAJHO(Animator KEKNNGMMOPP, AnimatorStateInfo FGJJDLKIGOK)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A75620", Offset = "0x6A74020", VA = "0x186A75620")]
		public void BDNFIJHBNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A75810", Offset = "0x6A74210", VA = "0x186A75810")]
		public (float, float) FNGOAOPKLDP(Animator KEKNNGMMOPP)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A75A20", Offset = "0x6A74420", VA = "0x186A75A20")]
		private (float, float) JGEGIILJEJK(Animator KEKNNGMMOPP, AnimatorStateInfo FGJJDLKIGOK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6A75C10", Offset = "0x6A74610", VA = "0x186A75C10")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6A78AC0", Offset = "0x6A774C0", VA = "0x186A78AC0", Slot = "4")]
		public override void OnStateEnter(Animator KEKNNGMMOPP, AnimatorStateInfo FGJJDLKIGOK, int MKGPHEFPPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6A78C20", Offset = "0x6A77620", VA = "0x186A78C20")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class NEENMLKJOMF<TInput, TOutput> : CPHFKPIAEGC<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	protected readonly HIMJLHGHAJA DONCNEAGOEE;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4795840", Offset = "0x4794240", VA = "0x184795840")]
	protected NEENMLKJOMF(HIMJLHGHAJA DONCNEAGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput MPIHBHFBPAP(TInput AHBBCFFJCCJ, [Out] IReadOnlyList<GJADONOJELD>? POMIPIBJBED);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x47957A0", Offset = "0x47941A0", VA = "0x1847957A0", Slot = "5")]
	public bool IBGKOHIIABH(TInput AHBBCFFJCCJ, [Out] TOutput? NLAECIHBKHE, [Out] IReadOnlyList<GJADONOJELD>? POMIPIBJBED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DEKINLCKNLM]
public static class MMKLBFDEIND
{
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly Regex NBNGIELPDNO;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6A786B0", Offset = "0x6A770B0", VA = "0x186A786B0")]
	public static KHAHGFBEPPJ IOKEOKNKCGK(OILMEJJBBPK LAPNIHDLAOI, AOFHBLCBKAK PIDDOGFCGDC, Guid? FKNGDEPOLMA, Color? FMLOJPEKNKB, BDAPCPEBHHJ EGKBNBCGHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6A788C0", Offset = "0x6A772C0", VA = "0x186A788C0")]
	public static ACPAMABFJKA LDLLKDGMJJG(KHAHGFBEPPJ LNCKNHNHHDF)
	{
		return default(ACPAMABFJKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2E7A130", Offset = "0x2E78B30", VA = "0x182E7A130")]
	internal static TModern? BBDCCMDOJCH<TModern>(string? AHBBCFFJCCJ, LJDDNBJAGCH<TModern> KLPKFCDODEJ, HIMJLHGHAJA DONCNEAGOEE, EONJMMOBJAD NIMCBLPCOBF, TModern GACCNFAEGJI) where TModern : struct, DJFLCPIMHBF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2E7B780", Offset = "0x2E7A180", VA = "0x182E7B780")]
	internal static ODANONMCNNG NOGCIFKFOFA<TModern>(string? AHBBCFFJCCJ, LJDDNBJAGCH<TModern> KLPKFCDODEJ, HIMJLHGHAJA DONCNEAGOEE, EONJMMOBJAD NIMCBLPCOBF, TModern GACCNFAEGJI) where TModern : struct, DJFLCPIMHBF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6A78570", Offset = "0x6A76F70", VA = "0x186A78570")]
	internal static List<GJADONOJELD> DIBLNFGIAKG(IEnumerable<IIMLHMJPGHK>? PHKCDJKIOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2E79310", Offset = "0x2E77D10", VA = "0x182E79310")]
	internal static string ALLBCDMOGCG<TModern>(TModern AHBBCFFJCCJ, LJDDNBJAGCH<TModern> KLPKFCDODEJ, HIMJLHGHAJA DONCNEAGOEE) where TModern : DJFLCPIMHBF
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class LEHOABBKOHE : CBMHAIAJMGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public CPHFKPIAEGC<NMJLDHGPEHE, DLHFACFAANC> NCKDDEBAEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public CPHFKPIAEGC<AJIOFMBJNMD, HDCOJNPPCGK> FJGOLNMOAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CPHFKPIAEGC<AJIOFMBJNMD, HDCOJNPPCGK> COCPDFDMFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FPBJIGKDKJN KJALCKLPNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public KEFKJDKFIIA PBMJEIDCACN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A77FA0", Offset = "0x6A769A0", VA = "0x186A77FA0")]
	[UsedImplicitly]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	internal static void GJFEGKCJKML(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A78010", Offset = "0x6A76A10", VA = "0x186A78010")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LEHOABBKOHE([LKKACOOMNBP("UnitySerialization")] NIBEBIMDKNI CBDFNNAGJBJ, [LKKACOOMNBP(null)] OELIFBKKNIM HFEKNGPPDID, [LKKACOOMNBP(null)] HIMJLHGHAJA DONCNEAGOEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum CABJHGMIMFO
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OFNEIGOPLKL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A78EC0", Offset = "0x6A778C0", VA = "0x186A78EC0")]
	public OFNEIGOPLKL(string BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6A78E90", Offset = "0x6A77890", VA = "0x186A78E90")]
	public OFNEIGOPLKL(string BBDGOIMNDJI, Exception DEHBLLKHAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6A78EF0", Offset = "0x6A778F0", VA = "0x186A78EF0")]
	public OFNEIGOPLKL(CABJHGMIMFO NAANNFJNLEO, string BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6A78F20", Offset = "0x6A77920", VA = "0x186A78F20")]
	public OFNEIGOPLKL(CABJHGMIMFO NAANNFJNLEO, string BBDGOIMNDJI, Exception DEHBLLKHAIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal abstract class JBFNPKFMFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly NIBEBIMDKNI CBDFNNAGJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	protected readonly OELIFBKKNIM HFEKNGPPDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	protected readonly HIMJLHGHAJA DONCNEAGOEE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6A750F0", Offset = "0x6A73AF0", VA = "0x186A750F0")]
	protected JBFNPKFMFHA(NIBEBIMDKNI CBDFNNAGJBJ, OELIFBKKNIM HFEKNGPPDID, HIMJLHGHAJA DONCNEAGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6A76B70", Offset = "0x6A75570", VA = "0x186A76B70")]
	protected string LMGMINJOFNB(DLHFACFAANC FFJKBJMDJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6A76520", Offset = "0x6A74F20", VA = "0x186A76520")]
	protected string FKOEHBNKJFG(DLHFACFAANC FFJKBJMDJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6A76840", Offset = "0x6A75240", VA = "0x186A76840")]
	private AvatarOutfitSelectionData IOKEOKNKCGK(KHAHGFBEPPJ IBPBMEEEPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6A76700", Offset = "0x6A75100", VA = "0x186A76700")]
	private static AvatarCustomizationSettingsData.AnchorParams FODFABLLMGP(EAKAJADPDPK? IJLNGMDCOBO)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CPHFKPIAEGC<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput MPIHBHFBPAP(TInput AHBBCFFJCCJ, [Out] IReadOnlyList<GJADONOJELD>? POMIPIBJBED);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IBGKOHIIABH(TInput AHBBCFFJCCJ, [Out] TOutput? NLAECIHBKHE, [Out] IReadOnlyList<GJADONOJELD>? POMIPIBJBED);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CBMHAIAJMGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	CPHFKPIAEGC<NMJLDHGPEHE, DLHFACFAANC> NCKDDEBAEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	CPHFKPIAEGC<AJIOFMBJNMD, HDCOJNPPCGK> COCPDFDMFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	FPBJIGKDKJN KJALCKLPNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum EONJMMOBJAD
{
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KEFKJDKFIIA
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHEOFCJHFHN BBLOJHGNHMB(DLHFACFAANC LNCKNHNHHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FPBJIGKDKJN
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AJIOFMBJNMD BBLOJHGNHMB(DLHFACFAANC LNCKNHNHHDF, int LDENBEFJCEC, string? DDDMPLCOGIM, string? ACJJNHMJBNL, BIJHKDPNNOK CIGMBCEOBCE, List<GJADONOJELD>? POMIPIBJBED);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DEKINLCKNLM]
internal class IJIMKMDNHLL : NEENMLKJOMF<NMJLDHGPEHE, DLHFACFAANC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly OELIFBKKNIM HFEKNGPPDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly GLKHNGFLBEK FNBPMLANMKD;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6A76350", Offset = "0x6A74D50", VA = "0x186A76350")]
	public IJIMKMDNHLL(NIBEBIMDKNI CBDFNNAGJBJ, OELIFBKKNIM HFEKNGPPDID, HIMJLHGHAJA DONCNEAGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6A760B0", Offset = "0x6A74AB0", VA = "0x186A760B0", Slot = "6")]
	public override DLHFACFAANC MPIHBHFBPAP(NMJLDHGPEHE AHBBCFFJCCJ, [Out] IReadOnlyList<GJADONOJELD>? POMIPIBJBED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class KBMKAHOBEGD : NIBEBIMDKNI
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class PJBHKDCBFKA : JsonConverter<ODANONMCNNG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6A79080", Offset = "0x6A77A80", VA = "0x186A79080", Slot = "9")]
		public override void WriteJson(JsonWriter HJIMDHLCBKF, ODANONMCNNG? IPHMAHBENGI, JsonSerializer GKBHCOPNOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6A78F60", Offset = "0x6A77960", VA = "0x186A78F60", Slot = "10")]
		public override ODANONMCNNG ReadJson(JsonReader BPJDDKOBEGL, Type FJGEIIALIIK, ODANONMCNNG? IHDFICFMMDD, bool DDGEJFDDGFB, JsonSerializer GKBHCOPNOKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6A79120", Offset = "0x6A77B20", VA = "0x186A79120")]
		public PJBHKDCBFKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class AMBDPCIPMHP : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool MILDPAAPGAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C510", Offset = "0x6A6AF10", VA = "0x186A6C510", Slot = "5")]
		public override object ReadJson(JsonReader BPJDDKOBEGL, Type FJGEIIALIIK, object? IHDFICFMMDD, JsonSerializer GKBHCOPNOKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C150", Offset = "0x6A6AB50", VA = "0x186A6C150", Slot = "6")]
		public override bool CanConvert(Type FJGEIIALIIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C570", Offset = "0x6A6AF70", VA = "0x186A6C570", Slot = "4")]
		public override void WriteJson(JsonWriter HJIMDHLCBKF, object? IPHMAHBENGI, JsonSerializer GKBHCOPNOKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C330", Offset = "0x6A6AD30", VA = "0x186A6C330")]
		private static bool JNHMJEKKPFD(object IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public AMBDPCIPMHP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly JsonSerializerSettings ONONNKMGMKH;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6A77E40", Offset = "0x6A76840", VA = "0x186A77E40")]
	internal KBMKAHOBEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2DFFA50", Offset = "0x2DFE450", VA = "0x182DFFA50", Slot = "4")]
	public string HMMNHPIHDOD<T>(T FHFDEAHMMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2DFF9C0", Offset = "0x2DFE3C0", VA = "0x182DFF9C0", Slot = "5")]
	public T CEANFGOEGOB<T>(string IPHMAHBENGI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[RecRoom.NoEngine.Common.Preserve]
internal class LHCPELAHADP : NIBEBIMDKNI
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C4A0", Offset = "0x2E1AEA0", VA = "0x182E1C4A0", Slot = "4")]
	public string HMMNHPIHDOD<T>(T FHFDEAHMMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C420", Offset = "0x2E1AE20", VA = "0x182E1C420", Slot = "5")]
	public T CEANFGOEGOB<T>(string IPHMAHBENGI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public LHCPELAHADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[DEKINLCKNLM]
internal class GLKHNGFLBEK : NEENMLKJOMF<AJIOFMBJNMD, HDCOJNPPCGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly NIBEBIMDKNI CBDFNNAGJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private readonly OELIFBKKNIM HFEKNGPPDID;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6A745D0", Offset = "0x6A72FD0", VA = "0x186A745D0")]
	public GLKHNGFLBEK(NIBEBIMDKNI CBDFNNAGJBJ, OELIFBKKNIM HFEKNGPPDID, HIMJLHGHAJA DONCNEAGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6A73A90", Offset = "0x6A72490", VA = "0x186A73A90", Slot = "6")]
	public override HDCOJNPPCGK MPIHBHFBPAP(AJIOFMBJNMD AHBBCFFJCCJ, [Out] IReadOnlyList<GJADONOJELD>? POMIPIBJBED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6A72A40", Offset = "0x6A71440", VA = "0x186A72A40")]
	internal void BPGMJJDHEFG(string JNGLHOEKGGE, DLHFACFAANC FFJKBJMDJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A72BA0", Offset = "0x6A715A0", VA = "0x186A72BA0")]
	public IEnumerable<KHAHGFBEPPJ> CJGOBPMJAIF(string IKEBKCHOMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6A741B0", Offset = "0x6A72BB0", VA = "0x186A741B0")]
	private IEnumerable<KHAHGFBEPPJ> PJOJHHPDOMH(string IKEBKCHOMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A732E0", Offset = "0x6A71CE0", VA = "0x186A732E0")]
	internal IEnumerable<KHAHGFBEPPJ> KOELGKKOJIO(string IKEBKCHOMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6A72C50", Offset = "0x6A71650", VA = "0x186A72C50")]
	private KHAHGFBEPPJ EELEFMAMFPF(AvatarOutfitSelectionData LJMEKMJFOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6A721C0", Offset = "0x6A70BC0", VA = "0x186A721C0")]
	private void BKAAENDKGPJ(AvatarCustomizationSettingsData NKHOPNOMIEL, DLHFACFAANC FFJKBJMDJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A72FD0", Offset = "0x6A719D0", VA = "0x186A72FD0")]
	private KHAHGFBEPPJ EELEFMAMFPF(string OFEAIBFHDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6A73EB0", Offset = "0x6A728B0", VA = "0x186A73EB0")]
	internal static (BDAPCPEBHHJ, string, string) PBEJBBKEFNB(string OFEAIBFHDLJ, HIMJLHGHAJA DONCNEAGOEE)
	{
		return default((BDAPCPEBHHJ, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6A73890", Offset = "0x6A72290", VA = "0x186A73890")]
	private LJNKIOIAELL? LPHPGDFCEMN(string? OKMPNEEAGBI, Vector2 CAAPHPLMKPD, float DPKLBGLHONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6A73730", Offset = "0x6A72130", VA = "0x186A73730")]
	private static EAKAJADPDPK KOFDKFFNPBF(AvatarCustomizationSettingsData.AnchorParams DEBJBIHFJJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DEKINLCKNLM]
internal class HBPOPMKPIMB : JBFNPKFMFHA, KEFKJDKFIIA
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6A750F0", Offset = "0x6A73AF0", VA = "0x186A750F0")]
	public HBPOPMKPIMB(NIBEBIMDKNI CBDFNNAGJBJ, OELIFBKKNIM HFEKNGPPDID, HIMJLHGHAJA DONCNEAGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6A74A00", Offset = "0x6A73400", VA = "0x186A74A00", Slot = "4")]
	public EHEOFCJHFHN BBLOJHGNHMB(DLHFACFAANC LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6A74FF0", Offset = "0x6A739F0", VA = "0x186A74FF0")]
	private string FLNGNCHIFKG(DLHFACFAANC FFJKBJMDJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6A74DB0", Offset = "0x6A737B0", VA = "0x186A74DB0")]
	private string BMONJEPJCIG(KHAHGFBEPPJ IBPBMEEEPIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[DEKINLCKNLM]
internal class BPBOHHNOLFB : NEENMLKJOMF<AJIOFMBJNMD, HDCOJNPPCGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly NIBEBIMDKNI CBDFNNAGJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly CPHFKPIAEGC<AJIOFMBJNMD, HDCOJNPPCGK> DPGGCLOKABC;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FBD0", Offset = "0x6A6E5D0", VA = "0x186A6FBD0")]
	public BPBOHHNOLFB(CPHFKPIAEGC<AJIOFMBJNMD, HDCOJNPPCGK> DPGGCLOKABC, HIMJLHGHAJA DONCNEAGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F7A0", Offset = "0x6A6E1A0", VA = "0x186A6F7A0", Slot = "6")]
	public override HDCOJNPPCGK MPIHBHFBPAP(AJIOFMBJNMD AHBBCFFJCCJ, [Out] IReadOnlyList<GJADONOJELD>? POMIPIBJBED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DEKINLCKNLM]
internal class IHPKLONIJJO : FPBJIGKDKJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly NIBEBIMDKNI CBDFNNAGJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly KEFKJDKFIIA CIKHKBABKDI;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6A75FC0", Offset = "0x6A749C0", VA = "0x186A75FC0")]
	public IHPKLONIJJO(KEFKJDKFIIA CIKHKBABKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6A75C20", Offset = "0x6A74620", VA = "0x186A75C20", Slot = "4")]
	public AJIOFMBJNMD BBLOJHGNHMB(DLHFACFAANC LNCKNHNHHDF, int LDENBEFJCEC, string? DDDMPLCOGIM, string? ACJJNHMJBNL, BIJHKDPNNOK CIGMBCEOBCE, List<GJADONOJELD>? POMIPIBJBED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RecRoom.NoEngine.Common.Preserve]
internal class EOLIOFFKOLH : LCOPDDLFHOK
{
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly Vector2 LIGDPNFBHBE;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly Vector2 EDIHMFAPDBL;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly Vector2 LHCDAMANAPH;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly Vector2 BOOILNIDDAK;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly Vector2 GECKALGAEPA;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly Vector2 BOJBJCEIAML;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly Vector2 DHHBFLKACLE;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly Vector2 NCBHMBMKGBK;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly Vector2 NKCFHOGFAMJ;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly Vector2 FJGMCNOAPAA;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 HDIEJJKIEAA;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 LLJOJKDCEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private readonly Dictionary<KPAFIKBMJHO, AvatarConfiguration> IHKMLIMDDNC;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6A708F0", Offset = "0x6A6F2F0", VA = "0x186A708F0")]
	[MDINNNLEANF.FIHKBCJDGBK]
	internal static void IKJKJBOLHEB(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A71AC0", Offset = "0x6A704C0", VA = "0x186A71AC0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EOLIOFFKOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6A70960", Offset = "0x6A6F360", VA = "0x186A70960", Slot = "4")]
	public Vector2 IPFPFCHLBKM(FaceFeatureType AOGGPMLOFJF, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6A70490", Offset = "0x6A6EE90", VA = "0x186A70490", Slot = "5")]
	public float DLOPHCNIDEB(FaceFeatureType AOGGPMLOFJF, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6A706A0", Offset = "0x6A6F0A0", VA = "0x186A706A0", Slot = "6")]
	public void EHDJLJEEFMP(KPAFIKBMJHO CEJNFGHJJOB, AvatarConfiguration GKOIFCHMJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6A71510", Offset = "0x6A6FF10", VA = "0x186A71510", Slot = "7")]
	public void OFEAMFPLNFA(PMNGKEFFCCB EBJOFNOPDBJ, AvatarConfiguration MAJDHPGOBHN, KPAFIKBMJHO LHIDMGMOAEI, KPAFIKBMJHO BEGGIDJDBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6A71460", Offset = "0x6A6FE60", VA = "0x186A71460", Slot = "8")]
	public float NKMHPGKADEN(FaceFeatureType LDCDGHGIBGH, float FBNNCGFKAAN, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A70510", Offset = "0x6A6EF10", VA = "0x186A70510", Slot = "9")]
	public float DNIKGHIFEKL(FaceFeatureType LDCDGHGIBGH, float DPKLBGLHONO, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6A70D10", Offset = "0x6A6F710", VA = "0x186A70D10", Slot = "11")]
	public Vector2 KPKDFKIDDBO(FaceFeatureType LDCDGHGIBGH, Vector2 NHPMHGOACNK, Vector2 MGADICHIJJF, Vector2 CNBMNHPDGEP, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6A70EC0", Offset = "0x6A6F8C0", VA = "0x186A70EC0", Slot = "10")]
	public Vector2 LAGDPHJBCIO(FaceFeatureType LDCDGHGIBGH, Vector2 NIBPCMOAJKJ, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6A70AD0", Offset = "0x6A6F4D0", VA = "0x186A70AD0")]
	private Vector2 JAFGMOKGNPA(FaceFeatureType LDCDGHGIBGH, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6A70540", Offset = "0x6A6EF40", VA = "0x186A70540")]
	private Vector2 EEHLKIFBKGH(FaceFeatureType LDCDGHGIBGH, Vector2 NHPMHGOACNK, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FDA0", Offset = "0x6A6E7A0", VA = "0x186A6FDA0", Slot = "12")]
	public Vector2 BDCABEILAEO(FaceFeatureType LDCDGHGIBGH, Vector2 NIBPCMOAJKJ, Vector2 MGADICHIJJF, Vector2 CNBMNHPDGEP, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6A71160", Offset = "0x6A6FB60", VA = "0x186A71160", Slot = "13")]
	public float MCIPPKJGBMA(FaceFeatureType LDCDGHGIBGH, float DPKLBGLHONO, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6A70C40", Offset = "0x6A6F640", VA = "0x186A70C40")]
	private float JCMNDAKODCH(float INMICDHDKLG, float LACIJCNPAEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6A71330", Offset = "0x6A6FD30", VA = "0x186A71330")]
	private Vector2 NBDMOMIEBFG(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A70140", Offset = "0x6A6EB40", VA = "0x186A70140")]
	private Vector2 BHJPAPOIJPM(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A710E0", Offset = "0x6A6FAE0", VA = "0x186A710E0")]
	private Vector2 LIMPFEHCFEH(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A71490", Offset = "0x6A6FE90", VA = "0x186A71490")]
	private Vector2 NLBHMGDFBGA(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A70290", Offset = "0x6A6EC90", VA = "0x186A70290")]
	private float CNODNJPKLHB(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A70CD0", Offset = "0x6A6F6D0", VA = "0x186A70CD0")]
	private float JPACLBMOBMK(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A70710", Offset = "0x6A6F110", VA = "0x186A70710")]
	private float FPDHGJNMLMA(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A702D0", Offset = "0x6A6ECD0", VA = "0x186A702D0")]
	private float COEPPPCLIHO(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A70750", Offset = "0x6A6F150", VA = "0x186A70750")]
	private Vector2 HDJLOBPFNID(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A71690", Offset = "0x6A70090", VA = "0x186A71690")]
	private Vector2 PBGLNNLCILI(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FCD0", Offset = "0x6A6E6D0", VA = "0x186A6FCD0")]
	private Vector2 ALODMOBFOGM(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A70B70", Offset = "0x6A6F570", VA = "0x186A70B70")]
	private Vector2 JBLEDDABFBI(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A701C0", Offset = "0x6A6EBC0", VA = "0x186A701C0")]
	private Vector2 CJBKDFMLKLJ(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A70820", Offset = "0x6A6F220", VA = "0x186A70820")]
	private Vector2 ICHEFMLIILM(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A715C0", Offset = "0x6A6FFC0", VA = "0x186A715C0")]
	private Vector2 OJCPOMNIFPJ(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A71760", Offset = "0x6A70160", VA = "0x186A71760")]
	private Vector2 PJJCFGDAIPM(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A703C0", Offset = "0x6A6EDC0", VA = "0x186A703C0")]
	private Vector2 DEFIAGLOCPE(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A713B0", Offset = "0x6A6FDB0", VA = "0x186A713B0")]
	private Vector2 NDCOBJEMKON(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A71830", Offset = "0x6A70230", VA = "0x186A71830")]
	private Vector2 PLHFGJEDOKM(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A70310", Offset = "0x6A6ED10", VA = "0x186A70310")]
	private Vector2 DDPCPHMNANA(KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C700", Offset = "0x6A6B100", VA = "0x186A6C700")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class HAEPCDNCIGJ
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A748F0", Offset = "0x6A732F0", VA = "0x186A748F0")]
	public static ACPAMABFJKA MPIHBHFBPAP(this AHJLLBNOGMN LNCKNHNHHDF)
	{
		return default(ACPAMABFJKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A74770", Offset = "0x6A73170", VA = "0x186A74770")]
	public static AHJLLBNOGMN BBLOJHGNHMB(this ACPAMABFJKA AIOHGKLIBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A74890", Offset = "0x6A73290", VA = "0x186A74890")]
	public static bool HJOCGBHEPKG(this ACPAMABFJKA AIOHGKLIBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A74710", Offset = "0x6A73110", VA = "0x186A74710")]
	public static bool ANLJFFAJCDF(this ACPAMABFJKA AIOHGKLIBAB)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x4EDAF70", Offset = "0x4ED9970", VA = "0x184EDAF70")]
			public AnchorParams(Vector2 NHPMHGOACNK, Vector3 JEGMFKAEDFB, Vector3 LLGPPANDACN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x6A6C650", Offset = "0x6A6B050", VA = "0x186A6C650")]
			internal EAKAJADPDPK BBLOJHGNHMB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private NAJAGABDOJJ useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x6A6CEE0", Offset = "0x6A6B8E0", VA = "0x186A6CEE0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3FE4E10", Offset = "0x3FE3810", VA = "0x183FE4E10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x92A990", Offset = "0x929390", VA = "0x18092A990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x9B6DB0", Offset = "0x9B57B0", VA = "0x1809B6DB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xC1E4C0", Offset = "0xC1CEC0", VA = "0x180C1E4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6A6CF80", Offset = "0x6A6B980", VA = "0x186A6CF80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8892D0", Offset = "0x887CD0", VA = "0x1808892D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC0C0", Offset = "0xAAAAC0", VA = "0x180AAC0C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x12D90E0", Offset = "0x12D7AE0", VA = "0x1812D90E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x883E30", Offset = "0x882830", VA = "0x180883E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6A6CFC0", Offset = "0x6A6B9C0", VA = "0x186A6CFC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x90FA40", Offset = "0x90E440", VA = "0x18090FA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xAFA6E0", Offset = "0xAF90E0", VA = "0x180AFA6E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x10C18B0", Offset = "0x10C02B0", VA = "0x1810C18B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x88C420", Offset = "0x88AE20", VA = "0x18088C420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x88C410", Offset = "0x88AE10", VA = "0x18088C410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x4392F60", Offset = "0x4391960", VA = "0x184392F60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x90F140", Offset = "0x90DB40", VA = "0x18090F140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8B9AA0", Offset = "0x8B84A0", VA = "0x1808B9AA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x8B9B00", Offset = "0x8B8500", VA = "0x1808B9B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x883D40", Offset = "0x882740", VA = "0x180883D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x883E00", Offset = "0x882800", VA = "0x180883E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x883E50", Offset = "0x882850", VA = "0x180883E50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x883E40", Offset = "0x882840", VA = "0x180883E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x883C90", Offset = "0x882690", VA = "0x180883C90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x883DE0", Offset = "0x8827E0", VA = "0x180883DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9C2BB0", Offset = "0x9C15B0", VA = "0x1809C2BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xD2B0B0", Offset = "0xD29AB0", VA = "0x180D2B0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x883D00", Offset = "0x882700", VA = "0x180883D00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x883E60", Offset = "0x882860", VA = "0x180883E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x92C030", Offset = "0x92AA30", VA = "0x18092C030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x913BD0", Offset = "0x9125D0", VA = "0x180913BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x88EC20", Offset = "0x88D620", VA = "0x18088EC20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x88EBD0", Offset = "0x88D5D0", VA = "0x18088EBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x913710", Offset = "0x912110", VA = "0x180913710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x913720", Offset = "0x912120", VA = "0x180913720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xC4C550", Offset = "0xC4AF50", VA = "0x180C4C550")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xF52DA0", Offset = "0xF517A0", VA = "0x180F52DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public NAJAGABDOJJ UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9BDA90", Offset = "0x9BC490", VA = "0x1809BDA90")]
			get
			{
				return default(NAJAGABDOJJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9BC840", Offset = "0x9BB240", VA = "0x1809BC840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9BD9D0", Offset = "0x9BC3D0", VA = "0x1809BD9D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x9BD120", Offset = "0x9BBB20", VA = "0x1809BD120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6A6CFA0", Offset = "0x6A6B9A0", VA = "0x186A6CFA0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6A6CFE0", Offset = "0x6A6B9E0", VA = "0x186A6CFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A6CB80", Offset = "0x6A6B580", VA = "0x186A6CB80")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public BDAPCPEBHHJ BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private FAOJCMNAOGM? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F080", Offset = "0x6A6DA80", VA = "0x186A6F080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
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
