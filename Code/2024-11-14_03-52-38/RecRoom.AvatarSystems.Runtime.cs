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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C12090", Offset = "0x6C11490", VA = "0x186C12090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C12110", Offset = "0x6C11510", VA = "0x186C12110", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MMCIGIHMOCH]
internal class GHLBLPKEMOE : MCDPABIONHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct ILGLBGIJONL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public GHLBLPKEMOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public JNJINABLMLP avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JEDNOOBGIDE FKEIPLPHKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FFMCCLCCCPC NIFNBNEBAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JBLGBLGLODJ IGKDMOEJONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LAFAECECKPI LDFHEBBNIKK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5EB0", Offset = "0x6BF52B0", VA = "0x186BF5EB0")]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	[UsedImplicitly]
	internal static void EOIGAJHAIJI(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6F60", Offset = "0x6BF6360", VA = "0x186BF6F60")]
	[RecRoom.NoEngine.Common.Preserve]
	internal GHLBLPKEMOE([NDMEANGLJKD(null)] JEDNOOBGIDE FKEIPLPHKIM, [NDMEANGLJKD(null)] FFMCCLCCCPC NIFNBNEBAHP, [NDMEANGLJKD(null)] JBLGBLGLODJ IGKDMOEJONK, [NDMEANGLJKD(null)] LAFAECECKPI LDFHEBBNIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5700", Offset = "0x6BF4B00", VA = "0x186BF5700", Slot = "5")]
	public DFJMGIPIJKE ECJMLCNHCOJ(JNJINABLMLP FPADOKOMPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5F20", Offset = "0x6BF5320", VA = "0x186BF5F20", Slot = "4")]
	public DFJMGIPIJKE ICNCIGDKAKG(JNJINABLMLP FPADOKOMPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF55F0", Offset = "0x6BF49F0", VA = "0x186BF55F0", Slot = "6")]
	public KCEABFJAODA DKPPMGNLBDE(DFJMGIPIJKE EIFGKHNPLEK, int IHPPMBJAKIG, string? ACDGEPBIBHJ, string? FAMFKKBKACM, PAEOCALEFHE IFBJNMEBEEF, List<CPFMBEFACFM>? LDCBMLEDFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6D30", Offset = "0x6BF6130", VA = "0x186BF6D30", Slot = "7")]
	public bool PCDOJLLBMIH(MMKFBNALAEE GFJHKJILOJD, [Out] DFJMGIPIJKE? ENEAIENGPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6C50", Offset = "0x6BF6050", VA = "0x186BF6C50", Slot = "8")]
	public bool OFNDEIOLLPH(KCEABFJAODA FCMAPDBIAAI, [Out] DFJMGIPIJKE? ENEAIENGPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6BC0", Offset = "0x6BF5FC0", VA = "0x186BF6BC0", Slot = "9")]
	public bool KOGBFKIGFLG(KCEABFJAODA FCMAPDBIAAI, [Out] IKFJOBFMBCH? GFJHKJILOJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB3630", Offset = "0x2EB2A30", VA = "0x182EB3630")]
	private bool IHDGNELIMJD<TInput, TOutput>(TInput CMILLOOAKEN, LNNPBCHFLGI<TInput, TOutput> LKEDEJNEFFM, [Out] TOutput? HCMJFDLGOJF) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6DC0", Offset = "0x6BF61C0", VA = "0x186BF6DC0")]
	[CompilerGenerated]
	private FDOJHHHBKGC PNAHIAPELGK(FaceFeatureType DBDIJEFBNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6BF68F0", Offset = "0x6BF5CF0", VA = "0x186BF68F0")]
	[CompilerGenerated]
	private FDOJHHHBKGC IFHOODFBONO(FaceFeatureType DBDIJEFBNAK, ILGLBGIJONL P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[MMCIGIHMOCH]
internal class NMOKBPLLBNP : JEDNOOBGIDE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DGCBKBPMDBO<in TData>(TData ENEAIENGPMA, IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JBLGBLGLODJ IGKDMOEJONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MBKGHNEMCHF GIHKDNFKCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DGCBKBPMDBO<DFJMGIPIJKE>?[] FKEIPLPHKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DGCBKBPMDBO<IKFJOBFMBCH>?[] JOLMBMPEIDK;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C10D70", Offset = "0x6C10170", VA = "0x186C10D70")]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	[UsedImplicitly]
	internal static void EOIGAJHAIJI(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C11CE0", Offset = "0x6C110E0", VA = "0x186C11CE0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NMOKBPLLBNP([NDMEANGLJKD(null)] JBLGBLGLODJ IGKDMOEJONK, [NDMEANGLJKD(null)] MBKGHNEMCHF GIHKDNFKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C11170", Offset = "0x6C10570", VA = "0x186C11170", Slot = "4")]
	public bool JDBMINACNPK(DFJMGIPIJKE ENEAIENGPMA, IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C11010", Offset = "0x6C10410", VA = "0x186C11010", Slot = "5")]
	public bool JDBMINACNPK(IKFJOBFMBCH GFJHKJILOJD, IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C11270", Offset = "0x6C10670", VA = "0x186C11270")]
	private void JKMHHJPCEAM(DFJMGIPIJKE ENEAIENGPMA, IReadOnlyList<CPFMBEFACFM>? KGHCPOJBNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C10DE0", Offset = "0x6C101E0", VA = "0x186C10DE0")]
	private void FPDADPDOKEN(DFJMGIPIJKE ENEAIENGPMA, IReadOnlyList<CPFMBEFACFM>? KGHCPOJBNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C10D40", Offset = "0x6C10140", VA = "0x186C10D40")]
	private void CBFIIDMNEMB(DFJMGIPIJKE ENEAIENGPMA, IReadOnlyList<CPFMBEFACFM>? KGHCPOJBNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C11CB0", Offset = "0x6C110B0", VA = "0x186C11CB0")]
	private void POACIJCHKDO(DFJMGIPIJKE ENEAIENGPMA, IReadOnlyList<CPFMBEFACFM>? KGHCPOJBNFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JEDNOOBGIDE
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JDBMINACNPK(DFJMGIPIJKE ENEAIENGPMA, IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JDBMINACNPK(IKFJOBFMBCH GFJHKJILOJD, IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ);
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
		public BNLOIPHFJNO AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6BF22F0", Offset = "0x6BF16F0", VA = "0x186BF22F0")]
		public void GNFNNGNMFEG(AnimationPoseSetting OGKFFDCECEL, float MHEHDABABFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2420", Offset = "0x6BF1820", VA = "0x186BF2420")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendHelperController : MonoBehaviour, ENKLPELIHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
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
		private Vector3? PKGBMNCCFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool MCCJFFPJDKJ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2440", Offset = "0x6BF1840", VA = "0x186BF2440", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2A30", Offset = "0x6BF1E30", VA = "0x186BF2A30", Slot = "4")]
		public void UpdateController(float FDMAJNEEBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x11B0720", Offset = "0x11AFB20", VA = "0x1811B0720", Slot = "6")]
		public void SetEnabled(bool PFKKDHPJFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BF24E0", Offset = "0x6BF18E0", VA = "0x186BF24E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2EC0", Offset = "0x6BF22C0", VA = "0x186BF2EC0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarElbowBendTargetController : MonoBehaviour, ENKLPELIHLL
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float NGBNLPCDDDB = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
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
		private Vector3 JEADJFLCIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 DPOJEBNOKKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool MCCJFFPJDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float MBLMKMHEFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float OLHAFMHCFNG;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BF3240", Offset = "0x6BF2640", VA = "0x186BF3240", Slot = "4")]
		public void UpdateController(float FDMAJNEEBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xC7E040", Offset = "0xC7D440", VA = "0x180C7E040", Slot = "6")]
		public void SetEnabled(bool PFKKDHPJFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2F60", Offset = "0x6BF2360", VA = "0x186BF2F60")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BF3D00", Offset = "0x6BF3100", VA = "0x186BF3D00")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		[SerializeField]
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

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4620", Offset = "0x6BF3A20", VA = "0x186BF4620")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BF45E0", Offset = "0x6BF39E0", VA = "0x186BF45E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6BF3D30", Offset = "0x6BF3130", VA = "0x186BF3D30")]
		private void CHDGILHKBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6BBB960", Offset = "0x6BBAD60", VA = "0x186BBB960", Slot = "4")]
		public void SetEnabled(bool FCINDJJJBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4650", Offset = "0x6BF3A50", VA = "0x186BF4650")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarForearmRollController : MonoBehaviour, ENKLPELIHLL
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
		private float MBLMKMHEFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool MCCJFFPJDKJ;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4690", Offset = "0x6BF3A90", VA = "0x186BF4690", Slot = "4")]
		public void UpdateController(float FDMAJNEEBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x112BA60", Offset = "0x112AE60", VA = "0x18112BA60", Slot = "6")]
		public void SetEnabled(bool PFKKDHPJFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5120", Offset = "0x6BF4520", VA = "0x186BF5120")]
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
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
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
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
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
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
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
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
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
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
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
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Default angle of the foot bone as seen in idle")]
		public float FootRestAngle;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5150", Offset = "0x6BF4550", VA = "0x186BF5150")]
		public AnimationPoseSetting KJJMLCHNJCF(BNLOIPHFJNO FCEKIDDLEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5180", Offset = "0x6BF4580", VA = "0x186BF5180")]
		public void MABFCCPGADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6BF51C0", Offset = "0x6BF45C0", VA = "0x186BF51C0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BF55B0", Offset = "0x6BF49B0", VA = "0x186BF55B0")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MGECMACCGMP : LHIONDHGKJD
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int KHHDFIPNIGP;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int KLCLEBELOII;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int JAKPMOFOIDA;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int MGJKMHOJJOB;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int PKBOLIOJFEF;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int GIFLKMGHKHJ;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int JLNEHGHLIAH;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int[] LDIEFJANCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private HGFBACMKEHB FECGBLLKGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PDBAMNEFIPK EMMLPJNGJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int MKPAIJLGPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private float AEENEGIHFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator JLFELBPOOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private AvatarFullBodyConfiguration KBDMNDAGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int OCGLPGCDJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int FCCLOKJCGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int KGEKFMJGCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool LJDIKHCADAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private OICJBOLAFFE DKIFGGJEJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int LKNDPFFJOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private float KOHIEMPNDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private HandDisplaySettings FJJHNHLIFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private JNJINABLMLP OKLFIHBDGBE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform OJJEHOPFJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 JLCHHKCIBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1125E00", Offset = "0x1125200", VA = "0x181125E00")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1125DF0", Offset = "0x11251F0", VA = "0x181125DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion GNIAEEJPFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1782370", Offset = "0x1781770", VA = "0x181782370")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x21EE120", Offset = "0x21ED520", VA = "0x1821EE120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool EJDMOMCAALM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6C10410", Offset = "0x6C0F810", VA = "0x186C10410")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6C10440", Offset = "0x6C0F840", VA = "0x186C10440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 JAINDCDBNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF2C3C0", Offset = "0xF2B7C0", VA = "0x180F2C3C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xF2B200", Offset = "0xF2A600", VA = "0x180F2B200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion NFOCNIJGEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xBD2EB0", Offset = "0xBD22B0", VA = "0x180BD2EB0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF2B860", Offset = "0xF2AC60", VA = "0x180F2B860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OCMMAIMEJOD LNNMEAELIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA0210", Offset = "0xA9F610", VA = "0x180AA0210", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(OCMMAIMEJOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA9FC20", Offset = "0xA9F020", VA = "0x180A9FC20", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OCMMAIMEJOD GIKNNDCCJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x15F3670", Offset = "0x15F2A70", VA = "0x1815F3670", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(OCMMAIMEJOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1D8EE00", Offset = "0x1D8E200", VA = "0x181D8EE00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float DCMIKGKDMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x17C1150", Offset = "0x17C0550", VA = "0x1817C1150", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAA1D60", Offset = "0xAA1160", VA = "0x180AA1D60", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DOLKEFDBCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C10200", Offset = "0x6C0F600", VA = "0x186C10200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KDHMFCHBDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C106A0", Offset = "0x6C0FAA0", VA = "0x186C106A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FEMGPOEBNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C101D0", Offset = "0x6C0F5D0", VA = "0x186C101D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MOFENKBGICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C10070", Offset = "0x6C0F470", VA = "0x186C10070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C10470", Offset = "0x6C0F870", VA = "0x186C10470", Slot = "21")]
	public void NOCOEJHJFAP(HGFBACMKEHB HLOLIKEMNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FFC0", Offset = "0x6C0F3C0", VA = "0x186C0FFC0")]
	public void CHOHNEBHEPG(PDBAMNEFIPK PMLNBHGDNIK, HandDisplaySettings EDLDEBINPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FF20", Offset = "0x6C0F320", VA = "0x186C0FF20", Slot = "12")]
	public void AHIIIJLAOEJ(bool HLIJMCFPGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C10700", Offset = "0x6C0FB00", VA = "0x186C10700", Slot = "11")]
	public void PFBJOPGFPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C10210", Offset = "0x6C0F610", VA = "0x186C10210")]
	private int LKFNADCICNC(OCMMAIMEJOD NJAPDILGBAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C10080", Offset = "0x6C0F480", VA = "0x186C10080")]
	private void HOIHJPJKMBH(int NAKHIHGEFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C10A40", Offset = "0x6C0FE40", VA = "0x186C10A40", Slot = "13")]
	public bool PLDELBOIDHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FFB0", Offset = "0x6C0F3B0", VA = "0x186C0FFB0", Slot = "14")]
	public bool CBPIDDJFMNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C10010", Offset = "0x6C0F410", VA = "0x186C10010")]
	private OCMMAIMEJOD CNCFAFMDNPK()
	{
		return default(OCMMAIMEJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA6C940", Offset = "0xA6BD40", VA = "0x180A6C940", Slot = "15")]
	public void KDIKJHODLCH(bool HLIJMCFPGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C103D0", Offset = "0x6C0F7D0", VA = "0x186C103D0", Slot = "10")]
	public void MLKEKHAPCHA(int NAKHIHGEFPN, float BCFNOOGJLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C101E0", Offset = "0x6C0F5E0", VA = "0x186C101E0", Slot = "8")]
	public void ILKKIALPBJA(OICJBOLAFFE GCJJLPMGMAA, bool PNJBBPJHGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C10060", Offset = "0x6C0F460", VA = "0x186C10060", Slot = "9")]
	public void EBNOOPNFIBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C106B0", Offset = "0x6C0FAB0", VA = "0x186C106B0", Slot = "16")]
	public void PBDILIIDBOD(Transform EGIKLIBGODG, Vector3 APONDDOHFIM, Quaternion KANEDPCHFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C10D30", Offset = "0x6C10130", VA = "0x186C10D30")]
	public MGECMACCGMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HBGJCIAJCMG : PBBBGCNGNNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class HBOCOCIKDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3 BGIIEMGJNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Quaternion EFDGHNGCBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 BKJDDBOCCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Transform LKBOMDDAGGC;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 JDNPEMEDEGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x180C930", Offset = "0x180BD30", VA = "0x18180C930")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x180C950", Offset = "0x180BD50", VA = "0x18180C950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion LKCBCKOFNID
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xE49430", Offset = "0xE48830", VA = "0x180E49430")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xE49860", Offset = "0xE48C60", VA = "0x180E49860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float ALOCBNDPPBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xBD2F30", Offset = "0xBD2330", VA = "0x180BD2F30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x11CC180", Offset = "0x11CB580", VA = "0x1811CC180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool DKAAOCJMJHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F50", Offset = "0x8A1350", VA = "0x1808A1F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A1E60", Offset = "0x8A1260", VA = "0x1808A1E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool PGJLBMOBFKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F70", Offset = "0x8A1370", VA = "0x1808A1F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F40", Offset = "0x8A1340", VA = "0x1808A1F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool KOKKOONGEEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A1FB0", Offset = "0x8A13B0", VA = "0x1808A1FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F60", Offset = "0x8A1360", VA = "0x1808A1F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float JELBIGMDAHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xBD2F50", Offset = "0xBD2350", VA = "0x180BD2F50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x284B650", Offset = "0x284AA50", VA = "0x18284B650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C9B0", Offset = "0x6C1BDB0", VA = "0x186C1C9B0")]
		public void LGLMEBNNKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BC30", Offset = "0x6C1B030", VA = "0x186C1BC30")]
		public void GFHNAKEKJBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BE70", Offset = "0x6C1B270", VA = "0x186C1BE70")]
		public float JEOGJFINFPN(Vector3 DKEOGKADJDG, Quaternion AOELIJBECHC, [In] FootSettings NELFDGJNDMG, float PMOIMCHNFEJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C2D0", Offset = "0x6C1B6D0", VA = "0x186C1C2D0")]
		public void KPJHLLGKMPK(Vector3 IBPPMPNLLJJ, Quaternion KJGADHOIAPA, Transform KLADOCENKKP, float DLKPGKPDLGD, bool NNLGFLLOKGD, bool GPKOMGFAHKP, float FNAOCKKBGJB, float NIKCFKHLCKB, Transform DADDPLMNJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BC40", Offset = "0x6C1B040", VA = "0x186C1BC40")]
		public void IBJGBIAHINO(Transform JGCJALMMAAA, Transform DADDPLMNJHB, bool GKFFIIGGOCM, bool EDJJDIOBKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C1D0", Offset = "0x6C1B5D0", VA = "0x186C1C1D0")]
		private void KGACLPGOHPC(Transform DADDPLMNJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C080", Offset = "0x6C1B480", VA = "0x186C1C080")]
		public void KACPNIMCFEG(Transform DADDPLMNJHB, AvatarFullBodyConfiguration CPMOJDMDHNC, Vector3 NFBHDDHGGEF, float OMIALDOLJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C9C0", Offset = "0x6C1BDC0", VA = "0x186C1C9C0")]
		public void NKJMCIKHDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C9D0", Offset = "0x6C1BDD0", VA = "0x186C1C9D0")]
		public HBOCOCIKDBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class IODJFCILBML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float OECMJKIBCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool JJKNMIPPBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AnimationPoseSetting JLMAGOHJFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float LNMBACABMKL;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C1EC80", Offset = "0x6C1E080", VA = "0x186C1EC80")]
		public void PHEIJMIMCFP(IKSolverVR.Arm ALJBMCICLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E1A0", Offset = "0x6C1D5A0", VA = "0x186C1E1A0")]
		public void GBKAEFEFOAB(IKSolverVR.Arm ALJBMCICLNB, float NGGGBGDPBEI, bool JJKNMIPPBAG, AvatarFullBodyConfiguration CPMOJDMDHNC, float HGPJOCJDEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E1E0", Offset = "0x6C1D5E0", VA = "0x186C1E1E0")]
		private void GOBEMJLFPIF(IKSolverVR.Arm ALJBMCICLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D660", Offset = "0x6C1CA60", VA = "0x186C1D660")]
		public void BLEBKCGLDIO(IKSolverVR.Arm ALJBMCICLNB, Transform PLJACDCPKED, Transform KLADOCENKKP, Quaternion DLDKGOLEBAJ, Vector3 JBHIEPBFHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E6C0", Offset = "0x6C1DAC0", VA = "0x186C1E6C0")]
		private (Vector3, Quaternion) NONJMPKCMDP(MGECMACCGMP LAGGJIPPDDK, Quaternion HKBNPDPPEOC, Vector3 IIODBEJJACO)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6C1DA40", Offset = "0x6C1CE40", VA = "0x186C1DA40")]
		public void BOGDIIMEDHI(MGECMACCGMP LAGGJIPPDDK, IKSolverVR.Arm ALJBMCICLNB, Quaternion HKBNPDPPEOC, Vector3 IIODBEJJACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6C1DBA0", Offset = "0x6C1CFA0", VA = "0x186C1DBA0")]
		public void EGMKPNKHFAD(MGECMACCGMP LAGGJIPPDDK, IKSolverVR.Arm ALJBMCICLNB, Quaternion HKBNPDPPEOC, Vector3 IIODBEJJACO, [In] AvatarFullBodyConfiguration CPMOJDMDHNC, [In] IEKPGOMPCLP GCJJLPMGMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6C1EB50", Offset = "0x6C1DF50", VA = "0x186C1EB50")]
		public void PAHNNDPCEIK(BNLOIPHFJNO HAOMDGIDLLJ, AvatarFullBodyConfiguration CPMOJDMDHNC, IEKPGOMPCLP GCJJLPMGMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E220", Offset = "0x6C1D620", VA = "0x186C1E220")]
		public void NEJCOFBHODG(IKSolverVR.Arm ALJBMCICLNB, Transform PLJACDCPKED, Vector3 FJPOAMCDAGJ, float GBNLEIEFDBN, Quaternion NPLEFNNOCMH, Vector3 HDGJGMHNILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6C1ECB0", Offset = "0x6C1E0B0", VA = "0x186C1ECB0")]
		public IODJFCILBML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum NOLMGEAELEL
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct ILEHLJAPKOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct MAGCCHDHCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int OJLCHLLNIKJ;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int AJGALOAGNJD;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int HOMKALBBJOH;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int FEKNGCNMPJH;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int BMJKCKGMHOJ;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int HLMEMCHFDIB;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int DAALBLCLBAA;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int DHKLLIONACO;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int BDIEHLGPGME;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int LOEIIJFOKJF;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int AMIHMFJGECN;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int OHHHHPDGDEG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int FOFDLLLEGPK;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int BOBIBEJCAID;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int CHBIDFHCMJM;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int DELAEPDJMNI;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int KIHEKGJBBCC;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int KABNDCNHBCL;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int JAHNHDOPGLD;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int OEGMAPIIHKH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int JIEOHNFKEDO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int EKCPNFLGHDA;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int FDOCPDIHMEL;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int CALBFFKKCGD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int LMGHILBGANK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int BGMIOKCLJDF;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int FEBHAKPKLLI;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int DGNCIOFNFMG;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int HMNLHJMNMFM;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 FGOAPEJEGEG;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int KBCDLBKANNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool BELMDCMGOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool LBFDCNPMLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool APOJIAMAEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool PONOCBKLHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool AEOEHDIPGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Vector3 AAOFNIFHDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private string DNADKIBKBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private KJKGEGCICJC? FECGBLLKGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private IPEGPDPMGHJ? HNBEDINAHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private DIFLFOKANNP IFENFBGAHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private OOCOLAKEFPA AJOELNAMMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MGECMACCGMP NNFALDIPHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MGECMACCGMP DNPKPMDCCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool HKHOOOIENKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool DIGMNBOLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly FGELDAOAPNK EMOKNGDHPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly JGICEGBAOAG MNEGECNOJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int MNMHJHNFJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float LCPJKKKGMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GameObject HIEKKKLODIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform PNOCFOJOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform ILKGGPCMEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform JJNBODDLMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform JEFEGGFIGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform MINOHPDLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float FPPNJABNFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float AEBPKLMBDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 IAIMJHOOAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Quaternion CNDJDKNIAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform KFCCDEEIJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform HNECPPKCCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform DJMJFJLDAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private OLLILMFFDHE HIDILJBLNCF;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker FKGEGPJLKKH;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker PJLBBKDGPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker ENPILEONJKN;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker OGJEPFLJCGL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker CFMIJBFAOJL;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker CHHBLJPFAHL;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<HBGJCIAJCMG> HALPNGHBHCO;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int OJCOOMGFHGD;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> AGMNGIHFDPD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int DIKLFEBMNFP;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int EODGDJIFENM;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int HPKBNIFGNAK;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int OHONDBAKJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float INHBDFBLMHF;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int BIGAJKOHAGD;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float CEIHGMFCPLG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float OLGMDAEFMBP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float NKHACMJPCAP;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float PJNIBEDEIHF;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NNALDMMMOGB FDOMEFBIANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float AJODKFBCMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool GCCADGCJGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float BPNHIMKBHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int BDFCJCJNEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int JGHDKAMMIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private HBOCOCIKDBE HJNMJAIPFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private HBOCOCIKDBE KGHBMDNLKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float PIKGBFKGAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Vector3 GDBFEKBNOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Vector3 JFPJMHADPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool OLMFPPGNKHI;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion CDLDGBFDOGA;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion JJBNLHLJODM;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 EFIKIHLNDJF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 NJHBPLOJDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float DOFAAGFLNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float MJLOBMLFMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IODJFCILBML OECCIIOELOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IODJFCILBML BGDIPIPEDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private BKMNBOBGCJI CMLBEFPDCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private LNCPLBGJKJJ CJHFNODBGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly PDBJLKKHKHG FFCMEKIHBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float MDCDNMHDIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float KPBMJMOJEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly LNCPLBGJKJJ CONOEFDOHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 MBLKHPCEHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Vector3 DIJPECJMPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float BPNIMHANKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float NLCJNFFFNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly LNCPLBGJKJJ LDHFOKAFIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly BKMNBOBGCJI CMANEGLKMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly LNCPLBGJKJJ NFBECCBFPMM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BDDIJCFMLKF OEKPAIGANNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BDDIJCFMLKF GOHBGOPLFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration LDCNMCOPKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BFBD50", Offset = "0x6BFB150", VA = "0x186BFBD50", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JNJINABLMLP FABAGCJMMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BFE830", Offset = "0x6BFDC30", VA = "0x186BFE830", Slot = "23")]
		get
		{
			return default(JNJINABLMLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration BJNJEODONBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C09DA0", Offset = "0x6C091A0", VA = "0x186C09DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform MMNJEPMOFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6BFAB80", Offset = "0x6BF9F80", VA = "0x186BFAB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform OOJHHEGFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9730", Offset = "0x6BF8B30", VA = "0x186BF9730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer AFNKLNAADIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C08970", Offset = "0x6C07D70", VA = "0x186C08970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] PELBHKHIBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C02450", Offset = "0x6C01850", VA = "0x186C02450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] GDBPKLFPHOA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC750", Offset = "0x6BFBB50", VA = "0x186BFC750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator HKPAMADJFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C07860", Offset = "0x6C06C60", VA = "0x186C07860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK JMGOHHOBONF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCBF0", Offset = "0x6BFBFF0", VA = "0x186BFCBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private ENKLPELIHLL MIPMAFGFOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6BFFA70", Offset = "0x6BFEE70", VA = "0x186BFFA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private ENKLPELIHLL CJJFDDCEABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6BFAC80", Offset = "0x6BFA080", VA = "0x186BFAC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private ENKLPELIHLL IOCNBOCBLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C034B0", Offset = "0x6C028B0", VA = "0x186C034B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private ENKLPELIHLL JHINKOFJOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC9A0", Offset = "0x6BFBDA0", VA = "0x186BFC9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private ENKLPELIHLL BJMLOBBBPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6BFBE50", Offset = "0x6BFB250", VA = "0x186BFBE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private ENKLPELIHLL JHHCDNMFJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC0A0", Offset = "0x6BFB4A0", VA = "0x186BFC0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private ENKLPELIHLL AJCJPPPDCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6BFBFA0", Offset = "0x6BFB3A0", VA = "0x186BFBFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private ENKLPELIHLL FILELOBGONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC220", Offset = "0x6BFB620", VA = "0x186BFC220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IPEGPDPMGHJ FKDHGMACNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EB50", Offset = "0x6C0DF50", VA = "0x186C0EB50", Slot = "15")]
		get
		{
			return default(IPEGPDPMGHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public KAMMBOOGGLL BPNBJOOFFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x96CF80", Offset = "0x96C380", VA = "0x18096CF80", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public HEJPJIGBCCH BPDJGPGAIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x96CEB0", Offset = "0x96C2B0", VA = "0x18096CEB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public LHIONDHGKJD MOACJGONCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x96CFA0", Offset = "0x96C3A0", VA = "0x18096CFA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public LHIONDHGKJD CKGPALPBHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xE3D4E0", Offset = "0xE3C8E0", VA = "0x180E3D4E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string PPEKLCNPCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform NDDBLJAALEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C08690", Offset = "0x6C07A90", VA = "0x186C08690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform NMKBBLHKGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C02640", Offset = "0x6C01A40", VA = "0x186C02640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform OANOEGOPLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9060", Offset = "0x6BF8460", VA = "0x186BF9060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool BACMEOKHGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6BF7610", Offset = "0x6BF6A10", VA = "0x186BF7610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform MNIDIAGNMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C03060", Offset = "0x6C02460", VA = "0x186C03060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject NEMCGAENDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC900", Offset = "0x6BFBD00", VA = "0x186BFC900", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets OKIFLALBLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C003C0", Offset = "0x6BFF7C0", VA = "0x186C003C0", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform EMBHMMCPENE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xE3D170", Offset = "0xE3C570", VA = "0x180E3D170", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform DAPMFJOIOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1862990", Offset = "0x1861D90", VA = "0x181862990", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform DNCOGKAOFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1862B40", Offset = "0x1861F40", VA = "0x181862B40", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform EPPDJMLBHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x163EA90", Offset = "0x163DE90", VA = "0x18163EA90", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 OOIKILJFNJO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C06110", Offset = "0x6C05510", VA = "0x186C06110", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float FAAKPFEAPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C08210", Offset = "0x6C07610", VA = "0x186C08210", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform BCKKGNBHPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C0BC90", Offset = "0x6C0B090", VA = "0x186C0BC90", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform AJIJOOKGNKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1B55900", Offset = "0x1B54D00", VA = "0x181B55900", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform CBNBNDOHCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1B559E0", Offset = "0x1B54DE0", VA = "0x181B559E0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform ABAMBGBNDDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x163F670", Offset = "0x163EA70", VA = "0x18163F670", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool CLNGNIHJEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC650", Offset = "0x6BFBA50", VA = "0x186BFC650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool FCNHCNDFFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6BFC880", Offset = "0x6BFBC80", VA = "0x186BFC880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool BMJGDBNFHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA440", Offset = "0x6BF9840", VA = "0x186BFA440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C061A0", Offset = "0x6C055A0", VA = "0x186C061A0")]
	private void MHDFNJNCHNL([In] IEKPGOMPCLP CGFAHFLNPLC, [In] AvatarFullBodyConfiguration CPMOJDMDHNC, bool AHOBCKHGEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8680", Offset = "0x6BF7A80", VA = "0x186BF8680")]
	private float AOFLMLDJLAN([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C0EFB0", Offset = "0x6C0E3B0", VA = "0x186C0EFB0")]
	private float POJKDLKAKJO([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BFCCF0", Offset = "0x6BFC0F0", VA = "0x186BFCCF0")]
	private void GIBPDHJCOKG(IEKPGOMPCLP CGFAHFLNPLC, AvatarFullBodyConfiguration CPMOJDMDHNC, bool AHOBCKHGEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C008F0", Offset = "0x6BFFCF0", VA = "0x186C008F0")]
	private void JACFBHIBLML([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BFC320", Offset = "0x6BFB720", VA = "0x186BFC320")]
	private void EGMOFMCMGDF([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FA80", Offset = "0x6C0EE80", VA = "0x186C0FA80")]
	public HBGJCIAJCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BFF4E0", Offset = "0x6BFE8E0", VA = "0x186BFF4E0", Slot = "12")]
	public void IBCJINNEBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C08260", Offset = "0x6C07660", VA = "0x186C08260", Slot = "13")]
	public void MOGKBPOHEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B8E0", Offset = "0x6C0ACE0", VA = "0x186C0B8E0", Slot = "14")]
	public void OFLDOADNKKJ(bool KONELMFBCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6BFCAA0", Offset = "0x6BFBEA0", VA = "0x186BFCAA0", Slot = "25")]
	public Transform GCACDINBINN(string PPNCBJBPABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7760", Offset = "0x6BF6B60", VA = "0x186BF7760", Slot = "26")]
	public Vector3? AFPDJNJAGPO(string PPNCBJBPABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C035B0", Offset = "0x6C029B0", VA = "0x186C035B0", Slot = "7")]
	public void LLDLCDHBOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7660", Offset = "0x6BF6A60", VA = "0x186BF7660")]
	private void AFNFMIOJFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9B90", Offset = "0x6BF8F90", VA = "0x186BF9B90", Slot = "6")]
	public void BLKKMDALHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C08620", Offset = "0x6C07A20", VA = "0x186C08620", Slot = "8")]
	public void MOGKMFAJGGC(float JFGHOMBKNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6BFF2E0", Offset = "0x6BFE6E0", VA = "0x186BFF2E0")]
	private void HMCMFLPMNAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C0CA20", Offset = "0x6C0BE20", VA = "0x186C0CA20", Slot = "4")]
	public void PJEGFJMJPAL(string HKBNCJFEGBO, KJKGEGCICJC DJGHKKOBAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C08FA0", Offset = "0x6C083A0", VA = "0x186C08FA0", Slot = "5")]
	public void NFPAJCBGBDE(IPEGPDPMGHJ PMLNBHGDNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C02550", Offset = "0x6C01950", VA = "0x186C02550", Slot = "11")]
	public void KIAHPKCPGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C01700", Offset = "0x6C00B00", VA = "0x186C01700", Slot = "24")]
	public void JMBBKMFAMME([Out] Vector3 JPPCLJPKIJK, [Out] Quaternion NPLEFNNOCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6BFC850", Offset = "0x6BFBC50", VA = "0x186BFC850")]
	private void FGIBOLILDLA([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9830", Offset = "0x6BF8C30", VA = "0x186BF9830", Slot = "27")]
	public void BKDHHPIIGIH(float OEBIOJEDNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6BFEF90", Offset = "0x6BFE390", VA = "0x186BFEF90", Slot = "28")]
	public void HJOPOLDLPGI(float KICLNEHKDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C0EA10", Offset = "0x6C0DE10", VA = "0x186C0EA10", Slot = "44")]
	public void PJHGKOFPCMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB8C0", Offset = "0x6BFACC0", VA = "0x186BFB8C0", Slot = "29")]
	public void CPHMIDDODIH(bool DAAINCJOKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6C0C9D0", Offset = "0x6C0BDD0", VA = "0x186C0C9D0", Slot = "30")]
	public HandLogicOffsets PHHHAHCBDJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE970", Offset = "0x6BFDD70", VA = "0x186BFE970", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets HGBDPHOCDHL()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C00AB0", Offset = "0x6BFFEB0", VA = "0x186C00AB0")]
	private void JDBIPBDKLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB910", Offset = "0x6BFAD10", VA = "0x186BFB910")]
	private void DAAJFGADBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B9B0", Offset = "0x6C0ADB0", VA = "0x186C0B9B0")]
	private void OIKOOFOLOKJ(GGMPLOAKJOK GMGNDCKALDD, bool MLNLBIHIEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6BFF330", Offset = "0x6BFE730", VA = "0x186BFF330")]
	private void HPJNALNJBAA(GGMPLOAKJOK GMGNDCKALDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BCF0", Offset = "0x6C0B0F0", VA = "0x186C0BCF0")]
	public Vector3 PDAABBIBKAN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6BFD130", Offset = "0x6BFC530", VA = "0x186BFD130")]
	private void GJHODFEGEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C09980", Offset = "0x6C08D80", VA = "0x186C09980")]
	private void NLJOAJOKGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6BFD3F0", Offset = "0x6BFC7F0", VA = "0x186BFD3F0")]
	private void GLBNMFLNKMB(IEKPGOMPCLP CGFAHFLNPLC, AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB710", Offset = "0x6BFAB10", VA = "0x186BFB710")]
	private float CDOALNEKHND([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BD40", Offset = "0x6C0B140", VA = "0x186C0BD40")]
	private int PDGILELEMFN([In] IKODPMOJNCC DJLPJLPFJPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C08A70", Offset = "0x6C07E70", VA = "0x186C08A70")]
	private void NDELHALOCFL(IEKPGOMPCLP CGFAHFLNPLC, bool JICLMKMALDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6BF90D0", Offset = "0x6BF84D0", VA = "0x186BF90D0")]
	private static void BEJDBOOLNBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A4F0", Offset = "0x6C098F0", VA = "0x186C0A4F0")]
	private static void NPEGJJPCJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7430", Offset = "0x6BF6830", VA = "0x186BF7430")]
	private float AEGEJBGACKI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6BFFB70", Offset = "0x6BFEF70", VA = "0x186BFFB70")]
	private static int IGEKLEEEPHI(HBGJCIAJCMG CGCHNDGEIJH, HBGJCIAJCMG LEGMFFDGEGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6BFEE30", Offset = "0x6BFE230", VA = "0x186BFEE30", Slot = "40")]
	public IEKPGOMPCLP HJFMFIGPLLK()
	{
		return default(IEKPGOMPCLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE930", Offset = "0x6BFDD30", VA = "0x186BFE930")]
	public void HDPGIGDPBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6BFC420", Offset = "0x6BFB820", VA = "0x186BFC420")]
	private (bool, bool) EHBEONHJFLH()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8710", Offset = "0x6BF7B10", VA = "0x186BF8710")]
	private (float, float) APMCNDMLICM([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C04610", Offset = "0x6C03A10", VA = "0x186C04610")]
	private void MAKDHKPMMLJ([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C05DF0", Offset = "0x6C051F0", VA = "0x186C05DF0")]
	private void MBIOHGIPHNP([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BFF0", Offset = "0x6C0B3F0", VA = "0x186C0BFF0")]
	private void PFECCGBAPOD([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6BFFFA0", Offset = "0x6BFF3A0", VA = "0x186BFFFA0")]
	private void IJMBBCPDDLO([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC, FootSettings NELFDGJNDMG, bool HOMJCOIGIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6BFC1A0", Offset = "0x6BFB5A0", VA = "0x186BFC1A0")]
	private float EFPIABDCMON()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7900", Offset = "0x6BF6D00", VA = "0x186BF7900")]
	private void AGOFBJKAJNC(IEKPGOMPCLP GCJJLPMGMAA, AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6BFBF50", Offset = "0x6BFB350", VA = "0x186BFBF50")]
	private float DLAFHJNOAAM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C09E30", Offset = "0x6C09230", VA = "0x186C09E30")]
	private void NMGLPNFMIOF([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9840", Offset = "0x6BF8C40", VA = "0x186BF9840")]
	private void BLEBKCGLDIO([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C099A0", Offset = "0x6C08DA0", VA = "0x186C099A0")]
	private void NMBIKOIONJF([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6C01450", Offset = "0x6C00850", VA = "0x186C01450")]
	private void JLKAOMMKFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C0ED50", Offset = "0x6C0E150", VA = "0x186C0ED50")]
	private void PMLNEBPHODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B3D0", Offset = "0x6C0A7D0", VA = "0x186C0B3D0")]
	private void ODJPIFOFHKM([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C086E0", Offset = "0x6C07AE0", VA = "0x186C086E0")]
	private void NCFINGLMJHN(MGECMACCGMP BKHNEOLFPOC, IKSolverVR.Arm ALJBMCICLNB, Transform PLEEDHOCOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B570", Offset = "0x6C0A970", VA = "0x186C0B570")]
	private void OEAAJLICAKJ(IEKPGOMPCLP GCJJLPMGMAA, AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BE20", Offset = "0x6C0B220", VA = "0x186C0BE20")]
	private void PFBJOPGFPBF(JCIFJNLFFCA BPCNFIFIGML, LHIONDHGKJD BKHNEOLFPOC, IKSolverVR.Arm ALJBMCICLNB, float NGGGBGDPBEI, float HPHJPLOGELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA4C0", Offset = "0x6BF98C0", VA = "0x186BFA4C0")]
	private void BNNGEOBHEIB([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6BFFBA0", Offset = "0x6BFEFA0", VA = "0x186BFFBA0")]
	protected void IHCONLGMLPC([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7150", Offset = "0x6BF6550", VA = "0x186BF7150")]
	private void ADJIIFPCJPO([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6BFAD80", Offset = "0x6BFA180", VA = "0x186BFAD80")]
	protected void CCBJBLAOKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C00CC0", Offset = "0x6C000C0", VA = "0x186C00CC0")]
	private void JJJPEJCEONG([In] IEKPGOMPCLP GCJJLPMGMAA, [In] NOLMGEAELEL IJCKPNDLKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6C03160", Offset = "0x6C02560", VA = "0x186C03160")]
	private void LHDPFGBHKCC(IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE350", Offset = "0x6BFD750", VA = "0x186BFE350")]
	private void HBFIMMFDOJC([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6C09460", Offset = "0x6C08860", VA = "0x186C09460")]
	private Vector3 NGBMDBOHBHO([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C0EC80", Offset = "0x6C0E080", VA = "0x186C0EC80")]
	private void PMFOFLCKJEL([In] IEKPGOMPCLP GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDF10", Offset = "0x6BFD310", VA = "0x186BFDF10")]
	private float HBCECCLHPDB(float NIKCFKHLCKB, [In] IEKPGOMPCLP GCJJLPMGMAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDDC0", Offset = "0x6BFD1C0", VA = "0x186BFDDC0")]
	private void GNDKHBJNILI(float NIKCFKHLCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE390", Offset = "0x6BFD790", VA = "0x186BFE390")]
	private void HBICDMANENO([In] IEKPGOMPCLP GCJJLPMGMAA, NOLMGEAELEL IJCKPNDLKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB040", Offset = "0x6BFA440", VA = "0x186BFB040")]
	private float CCEPCIOHPNL([In] IEKPGOMPCLP CGFAHFLNPLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6C07C60", Offset = "0x6C07060", VA = "0x186C07C60")]
	private void MNBNOFPECJI(IEKPGOMPCLP GCJJLPMGMAA, NOLMGEAELEL IJCKPNDLKJG, Vector3 HDBALBOHKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6BF84D0", Offset = "0x6BF78D0", VA = "0x186BF84D0")]
	private static void ANOAKIMENJD(Transform JGDFNKEDOMO, Quaternion GEMHEIIKJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C07960", Offset = "0x6C06D60", VA = "0x186C07960")]
	private void MMCEOMOPEBC([In] IEKPGOMPCLP DKKELNACEGA, [In] IKODPMOJNCC DJLPJLPFJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6C03DA0", Offset = "0x6C031A0", VA = "0x186C03DA0")]
	private void MAIFPFHKJDD([In] IEKPGOMPCLP DKKELNACEGA, [In] IKODPMOJNCC DJLPJLPFJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B220", Offset = "0x6C0A620", VA = "0x186C0B220")]
	private void OBFOFMFGHKI(float JIKLKNOCNAF, [In] IEKPGOMPCLP CGFAHFLNPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6C026B0", Offset = "0x6C01AB0", VA = "0x186C026B0")]
	private float KMOEJNDKLEO([In] IEKPGOMPCLP CGFAHFLNPLC, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6C02DF0", Offset = "0x6C021F0", VA = "0x186C02DF0")]
	private void LADGOHJJNFE([In] IEKPGOMPCLP CGFAHFLNPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8880", Offset = "0x6BF7C80", VA = "0x186BF8880")]
	private void BCDGNBCJHPN([In] IEKPGOMPCLP CGFAHFLNPLC, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C00550", Offset = "0x6BFF950", VA = "0x186C00550")]
	private void IPOLLDBGEAE([In] IEKPGOMPCLP CGFAHFLNPLC, float BPMDKHHCEEE, float GHMHEPPFKCJ, Vector3 IIGPGMGHKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6C01A90", Offset = "0x6C00E90", VA = "0x186C01A90")]
	private void KCEHJGKJFIN(IEKPGOMPCLP CGFAHFLNPLC, AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6BFEA30", Offset = "0x6BFDE30", VA = "0x186BFEA30")]
	private void HJANLKNIHBB(IEKPGOMPCLP CGFAHFLNPLC, AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A320", Offset = "0x6C09720", VA = "0x186C0A320")]
	public void NMMLNLBAGNB([In] IEKPGOMPCLP GCJJLPMGMAA, [In] AvatarFullBodyConfiguration CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6C03310", Offset = "0x6C02710", VA = "0x186C03310")]
	[CompilerGenerated]
	internal static void LJMGGENLJIM(Transform DPJCEEDGHJL, IKSolverVR.Arm ALJBMCICLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C00C10", Offset = "0x6C00010", VA = "0x186C00C10")]
	[CompilerGenerated]
	internal static void JGBHOMNINIG(Vector3 BFLEJOJJIEE, Vector3 NCMGFNALKMF, ILEHLJAPKOD P_2, MAGCCHDHCMJ P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8430", Offset = "0x6BF7830", VA = "0x186BF8430")]
	[CompilerGenerated]
	internal static void ALMPBDIKADC(HBOCOCIKDBE PGOKAPNOEAP, HBOCOCIKDBE GIKKKOMFCGP, Vector3 IEHLANLLCMC, float IBDGAGPHJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C00440", Offset = "0x6BFF840", VA = "0x186C00440")]
	[CompilerGenerated]
	internal static bool IPLCLEHOJNM(IKSolverVR.Arm ALJBMCICLNB, FFOBOIOBJPG PPOJIKJFEPI, float JEDNLNEECAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9300", Offset = "0x6BF8700", VA = "0x186BF9300")]
	[CompilerGenerated]
	internal static float BFFMKAEAMJC(Vector3 CPKGAGKDLMF, Vector3 HPAHDBAANKG, Vector3 OJDEMHPDJJO, IEKPGOMPCLP CGFAHFLNPLC, AvatarFullBodyConfiguration CPMOJDMDHNC, float HHOJFKLGPBP)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum MFJLMDIAEGM
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private MFJLMDIAEGM handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C13530", Offset = "0x6C12930", VA = "0x186C13530")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6C134F0", Offset = "0x6C128F0", VA = "0x186C134F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C12ED0", Offset = "0x6C122D0", VA = "0x186C12ED0")]
		private void CHDGILHKBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6BBB960", Offset = "0x6BBAD60", VA = "0x186BBB960", Slot = "4")]
		public void SetEnabled(bool FCINDJJJBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C13560", Offset = "0x6C12960", VA = "0x186C13560")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AvatarKneeBendTargetController : MonoBehaviour, ENKLPELIHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Vector3 JEADJFLCIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Vector3 NMFKEKIEGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Vector3 MGLNKALGHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Matrix4x4 EBKOBDMFLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private bool MCCJFFPJDKJ;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6C13A00", Offset = "0x6C12E00", VA = "0x186C13A00", Slot = "4")]
		public void UpdateController(float FDMAJNEEBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C139F0", Offset = "0x6C12DF0", VA = "0x186C139F0", Slot = "6")]
		public void SetEnabled(bool PFKKDHPJFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C13590", Offset = "0x6C12990", VA = "0x186C13590")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6C140C0", Offset = "0x6C134C0", VA = "0x186C140C0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, IJAFOPMGDPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[Header("Configuration")]
		[SerializeField]
		private JNJINABLMLP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[PCIEPDMGHOH(AHBKOCJDDCB.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		[Header("Configuration")]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private PBBBGCNGNNJ MPMPFJODNHI;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public PBBBGCNGNNJ FELFCKMFLDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x96CE90", Offset = "0x96C290", VA = "0x18096CE90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform MGIKCMCJCEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6C14F50", Offset = "0x6C14350", VA = "0x186C14F50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6C140D0", Offset = "0x6C134D0", VA = "0x186C140D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C14E10", Offset = "0x6C14210", VA = "0x186C14E10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6C14DC0", Offset = "0x6C141C0", VA = "0x186C14DC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6C14D50", Offset = "0x6C14150", VA = "0x186C14D50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6C140D0", Offset = "0x6C134D0", VA = "0x186C140D0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6C14550", Offset = "0x6C13950", VA = "0x186C14550", Slot = "6")]
		public PBBBGCNGNNJ CreateAvatarSystem(string HKBNCJFEGBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6C14D50", Offset = "0x6C14150", VA = "0x186C14D50", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6C14180", Offset = "0x6C13580", VA = "0x186C14180", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6C14E60", Offset = "0x6C14260", VA = "0x186C14E60", Slot = "9")]
		public void UpdatePostIKAnimControllers(float FDMAJNEEBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class FCOEOFNOCNH : APOPJLKMBOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<string, PBBBGCNGNNJ> CAAHNBBKBMH;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C19C10", Offset = "0x6C19010", VA = "0x186C19C10")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void MBEDEPMLLGK(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C199F0", Offset = "0x6C18DF0", VA = "0x186C199F0", Slot = "4")]
	public PBBBGCNGNNJ HHLLPODKKHL(string LDFEIFPEKJA, AvatarSystemConfiguration HPDJOCEPKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C19800", Offset = "0x6C18C00", VA = "0x186C19800", Slot = "5")]
	public void CGGDFJDHHJF(string LDFEIFPEKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C19C80", Offset = "0x6C19080", VA = "0x186C19C80", Slot = "6")]
	public string NMJOPLNDOFH(string BDBDCEBLLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C19980", Offset = "0x6C18D80", VA = "0x186C19980")]
	private string DCIPIGDLOND(string BDBDCEBLLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C19DC0", Offset = "0x6C191C0", VA = "0x186C19DC0")]
	public FCOEOFNOCNH()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class ODHCANPGCFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private Dictionary<string, Transform> FFEPPAPNFFO;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool FKFNLLHBIGN
			{
				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x6C21AA0", Offset = "0x6C20EA0", VA = "0x186C21AA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6C21970", Offset = "0x6C20D70", VA = "0x186C21970")]
			public void FFGANLHIGDJ(VRIK MGCDKAHIHCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
			public void DFBCCAANKHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x6C21AE0", Offset = "0x6C20EE0", VA = "0x186C21AE0")]
			public void PGGELGPJGKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6C21B30", Offset = "0x6C20F30", VA = "0x186C21B30")]
			public ODHCANPGCFL()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[BLMMAJBEPMF(AHBKOCJDDCB.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		[PCIEPDMGHOH(AHBKOCJDDCB.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly ODHCANPGCFL NFDPBOGNEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private IJAFOPMGDPN LKIDGKGJEMC;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6C14FF0", Offset = "0x6C143F0", VA = "0x186C14FF0")]
		private void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6C14FA0", Offset = "0x6C143A0", VA = "0x186C14FA0")]
		private bool EECCLDIPDIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C152D0", Offset = "0x6C146D0", VA = "0x186C152D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6C15340", Offset = "0x6C14740", VA = "0x186C15340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C152E0", Offset = "0x6C146E0", VA = "0x186C152E0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C155B0", Offset = "0x6C149B0", VA = "0x186C155B0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CD20", Offset = "0x6C1C120", VA = "0x186C1CD20")]
		public void MABFCCPGADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CCB0", Offset = "0x6C1C0B0", VA = "0x186C1CCB0")]
		public int ENLJCEMDMBH(int DOOEAOILAFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public HandDisplaySettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x6C1CF80", Offset = "0x6C1C380", VA = "0x186C1CF80")]
			public void MABFCCPGADF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6C1CE40", Offset = "0x6C1C240", VA = "0x186C1CE40")]
			public (float, float) FGFNOPDEIIK(Animator GBAKNGHPLFD, AnimatorStateInfo OFLDHEHCJED)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D460", Offset = "0x6C1C860", VA = "0x186C1D460")]
		public void MABFCCPGADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D250", Offset = "0x6C1C650", VA = "0x186C1D250")]
		public (float, float) KPLKFGKHHNP(Animator GBAKNGHPLFD)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D060", Offset = "0x6C1C460", VA = "0x186C1D060")]
		private (float, float) GMFPNMOKFGP(Animator GBAKNGHPLFD, AnimatorStateInfo OFLDHEHCJED)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6C1D650", Offset = "0x6C1CA50", VA = "0x186C1D650")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F230", Offset = "0x6C1E630", VA = "0x186C1F230", Slot = "4")]
		public override void OnStateEnter(Animator GBAKNGHPLFD, AnimatorStateInfo OFLDHEHCJED, int JPNOGKGEIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F3A0", Offset = "0x6C1E7A0", VA = "0x186C1F3A0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal abstract class MOBFINLEHGE<TInput, TOutput> : LNNPBCHFLGI<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	protected readonly MBKGHNEMCHF GIHKDNFKCLH;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x48E5D30", Offset = "0x48E5130", VA = "0x1848E5D30")]
	protected MOBFINLEHGE(MBKGHNEMCHF GIHKDNFKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput LIJBJHOEHGL(TInput CMILLOOAKEN, [Out] IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x48E5C90", Offset = "0x48E5090", VA = "0x1848E5C90", Slot = "5")]
	public bool IHDGNELIMJD(TInput CMILLOOAKEN, [Out] TOutput? HCMJFDLGOJF, [Out] IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[MMCIGIHMOCH]
public static class BIPBPIDDCGG
{
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly Regex EHJNGIMAEKL;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C15AA0", Offset = "0x6C14EA0", VA = "0x186C15AA0")]
	public static NCIACKHDFAL LKDBMJAKFFN(DGMNJDBAMFC NACKNPKJLNN, HLKLPNJACJF AONELJPFCDP, Guid? NMPFPMNJMLM, Color? LMJLBIAJGFL, MHMNKAMKDLO OJEPPEBDDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6C157F0", Offset = "0x6C14BF0", VA = "0x186C157F0")]
	public static MMGKCPFJLPI HPKKCJHJOCC(NCIACKHDFAL EIFGKHNPLEK)
	{
		return default(MMGKCPFJLPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2C49D10", Offset = "0x2C49110", VA = "0x182C49D10")]
	internal static TModern? EGCJPFEGNIL<TModern>(string? CMILLOOAKEN, POOCNPDLGKI<TModern> DAKKHFGHMGK, MBKGHNEMCHF GIHKDNFKCLH, GNLJMIOLFBD AJOMBJGGMLH, TModern EFCICPFJHLB) where TModern : struct, MBFEJGKNDJG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2C49530", Offset = "0x2C48930", VA = "0x182C49530")]
	internal static KLMDDJBOPFF CDAGEAOFECG<TModern>(string? CMILLOOAKEN, POOCNPDLGKI<TModern> DAKKHFGHMGK, MBKGHNEMCHF GIHKDNFKCLH, GNLJMIOLFBD AJOMBJGGMLH, TModern EFCICPFJHLB) where TModern : struct, MBFEJGKNDJG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C15950", Offset = "0x6C14D50", VA = "0x186C15950")]
	internal static List<CPFMBEFACFM> LBGBHMBPMMG(IEnumerable<CHHBPHPDKEK>? BNDPKAEFIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2C486B0", Offset = "0x2C47AB0", VA = "0x182C486B0")]
	internal static string BNEJABCNHKO<TModern>(TModern CMILLOOAKEN, POOCNPDLGKI<TModern> DAKKHFGHMGK, MBKGHNEMCHF GIHKDNFKCLH) where TModern : MBFEJGKNDJG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class DIKLEEKBGCL : FFMCCLCCCPC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public LNNPBCHFLGI<MMKFBNALAEE, DFJMGIPIJKE> GCEGLGKBAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public LNNPBCHFLGI<KCEABFJAODA, IKFJOBFMBCH> KJAKOIANJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public LNNPBCHFLGI<KCEABFJAODA, IKFJOBFMBCH> AAILBHBKANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public JHNADEPKBAB CPFLCKKNBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public AJGEJMAFCNO JDDFOCMNHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6C16040", Offset = "0x6C15440", VA = "0x186C16040")]
	[UsedImplicitly]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	internal static void EOIGAJHAIJI(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6C160B0", Offset = "0x6C154B0", VA = "0x186C160B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DIKLEEKBGCL([NDMEANGLJKD("UnitySerialization")] JODBKJMGABO ONAGMFEHANA, [NDMEANGLJKD(null)] LDBPMFKPPIO FKPCJKGGMDE, [NDMEANGLJKD(null)] MBKGHNEMCHF GIHKDNFKCLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum NCLHABPMEGE
{
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HCEMKDBIECC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6C1CBE0", Offset = "0x6C1BFE0", VA = "0x186C1CBE0")]
	public HCEMKDBIECC(string NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1CC50", Offset = "0x6C1C050", VA = "0x186C1CC50")]
	public HCEMKDBIECC(string NFKMLKNHFEM, Exception PEMONHKIEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1CC80", Offset = "0x6C1C080", VA = "0x186C1CC80")]
	public HCEMKDBIECC(NCLHABPMEGE DKGOGPLFELC, string NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1CC10", Offset = "0x6C1C010", VA = "0x186C1CC10")]
	public HCEMKDBIECC(NCLHABPMEGE DKGOGPLFELC, string NFKMLKNHFEM, Exception PEMONHKIEDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal abstract class FJCEFFCBILD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly JODBKJMGABO ONAGMFEHANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	protected readonly LDBPMFKPPIO FKPCJKGGMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	protected readonly MBKGHNEMCHF GIHKDNFKCLH;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C16D00", Offset = "0x6C16100", VA = "0x186C16D00")]
	protected FJCEFFCBILD(JODBKJMGABO ONAGMFEHANA, LDBPMFKPPIO FKPCJKGGMDE, MBKGHNEMCHF GIHKDNFKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A370", Offset = "0x6C19770", VA = "0x186C1A370")]
	protected string NEPEPBBNFAG(DFJMGIPIJKE ENEAIENGPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A180", Offset = "0x6C19580", VA = "0x186C1A180")]
	protected string NCCKOEHBNIJ(DFJMGIPIJKE ENEAIENGPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6C19E50", Offset = "0x6C19250", VA = "0x186C19E50")]
	private AvatarOutfitSelectionData LKDBMJAKFFN(NCIACKHDFAL LPLAFPLEDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B670", Offset = "0x6C1AA70", VA = "0x186C1B670")]
	private static AvatarCustomizationSettingsData.AnchorParams PIPMGKCPPIB(CHCOONHOENK? BMNEOCMGPNI)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LNNPBCHFLGI<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput LIJBJHOEHGL(TInput CMILLOOAKEN, [Out] IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHDGNELIMJD(TInput CMILLOOAKEN, [Out] TOutput? HCMJFDLGOJF, [Out] IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface FFMCCLCCCPC
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	LNNPBCHFLGI<MMKFBNALAEE, DFJMGIPIJKE> GCEGLGKBAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	LNNPBCHFLGI<KCEABFJAODA, IKFJOBFMBCH> AAILBHBKANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	JHNADEPKBAB CPFLCKKNBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal enum GNLJMIOLFBD
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AJGEJMAFCNO
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GFHPOLJBJAE IJIPNHCCMND(DFJMGIPIJKE EIFGKHNPLEK);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface JHNADEPKBAB
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KCEABFJAODA IJIPNHCCMND(DFJMGIPIJKE EIFGKHNPLEK, int IHPPMBJAKIG, string? ACDGEPBIBHJ, string? FAMFKKBKACM, PAEOCALEFHE IFBJNMEBEEF, List<CPFMBEFACFM>? LDCBMLEDFEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[MMCIGIHMOCH]
internal class HAAJGJHCMLJ : MOBFINLEHGE<MMKFBNALAEE, DFJMGIPIJKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly LDBPMFKPPIO FKPCJKGGMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly NPCMIEEPHMK KBOMHPHNNMK;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BA60", Offset = "0x6C1AE60", VA = "0x186C1BA60")]
	public HAAJGJHCMLJ(JODBKJMGABO ONAGMFEHANA, LDBPMFKPPIO FKPCJKGGMDE, MBKGHNEMCHF GIHKDNFKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B7B0", Offset = "0x6C1ABB0", VA = "0x186C1B7B0", Slot = "6")]
	public override DFJMGIPIJKE LIJBJHOEHGL(MMKFBNALAEE CMILLOOAKEN, [Out] IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RecRoom.NoEngine.Common.Preserve]
internal class BIAJFFAAMOF : JODBKJMGABO
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class HBPHAEPFEEM : JsonConverter<KLMDDJBOPFF>
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CB00", Offset = "0x6C1BF00", VA = "0x186C1CB00", Slot = "9")]
		public override void WriteJson(JsonWriter FJOPPBPMLFL, KLMDDJBOPFF? PFKKDHPJFEH, JsonSerializer ELCOBHNBMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C9E0", Offset = "0x6C1BDE0", VA = "0x186C1C9E0", Slot = "10")]
		public override KLMDDJBOPFF ReadJson(JsonReader ILEMOHLPHEC, Type GFDJLFACKJN, KLMDDJBOPFF? NEAMDOJEIOJ, bool IPGFKMDMJLK, JsonSerializer ELCOBHNBMFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CBA0", Offset = "0x6C1BFA0", VA = "0x186C1CBA0")]
		public HBPHAEPFEEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class MPMNJLBNJAH : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool MAGMJPJFKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F0F0", Offset = "0x6C1E4F0", VA = "0x186C1F0F0", Slot = "5")]
		public override object ReadJson(JsonReader ILEMOHLPHEC, Type GFDJLFACKJN, object? NEAMDOJEIOJ, JsonSerializer ELCOBHNBMFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6C1ED30", Offset = "0x6C1E130", VA = "0x186C1ED30", Slot = "6")]
		public override bool CanConvert(Type GFDJLFACKJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F150", Offset = "0x6C1E550", VA = "0x186C1F150", Slot = "4")]
		public override void WriteJson(JsonWriter FJOPPBPMLFL, object? PFKKDHPJFEH, JsonSerializer ELCOBHNBMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6C1EF10", Offset = "0x6C1E310", VA = "0x186C1EF10")]
		private static bool MIDBHJMCJLH(object PFKKDHPJFEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public MPMNJLBNJAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly JsonSerializerSettings EDLDEBINPFF;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C15690", Offset = "0x6C14A90", VA = "0x186C15690")]
	internal BIAJFFAAMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2C47F30", Offset = "0x2C47330", VA = "0x182C47F30", Slot = "4")]
	public string EMGFALDMIPA<T>(T FAKGLFFOLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2C47F90", Offset = "0x2C47390", VA = "0x182C47F90", Slot = "5")]
	public T IBOAANMMAOB<T>(string PFKKDHPJFEH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RecRoom.NoEngine.Common.Preserve]
internal class LGPJOJDMENI : JODBKJMGABO
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B210", Offset = "0x2F8A610", VA = "0x182F8B210", Slot = "4")]
	public string EMGFALDMIPA<T>(T FAKGLFFOLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B290", Offset = "0x2F8A690", VA = "0x182F8B290", Slot = "5")]
	public T IBOAANMMAOB<T>(string PFKKDHPJFEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public LGPJOJDMENI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[MMCIGIHMOCH]
internal class NPCMIEEPHMK : MOBFINLEHGE<KCEABFJAODA, IKFJOBFMBCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly JODBKJMGABO ONAGMFEHANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly LDBPMFKPPIO FKPCJKGGMDE;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6C21830", Offset = "0x6C20C30", VA = "0x186C21830")]
	public NPCMIEEPHMK(JODBKJMGABO ONAGMFEHANA, LDBPMFKPPIO FKPCJKGGMDE, MBKGHNEMCHF GIHKDNFKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6C20B60", Offset = "0x6C1FF60", VA = "0x186C20B60", Slot = "6")]
	public override IKFJOBFMBCH LIJBJHOEHGL(KCEABFJAODA CMILLOOAKEN, [Out] IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6C200D0", Offset = "0x6C1F4D0", VA = "0x186C200D0")]
	internal void HDLMOKCADPJ(string NGHJJDDIFMJ, DFJMGIPIJKE ENEAIENGPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6C20220", Offset = "0x6C1F620", VA = "0x186C20220")]
	public IEnumerable<NCIACKHDFAL> KDDHELFGMMC(string JKLOMMIKPNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6C202D0", Offset = "0x6C1F6D0", VA = "0x186C202D0")]
	private IEnumerable<NCIACKHDFAL> KHLDHKLCHLC(string JKLOMMIKPNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6C206F0", Offset = "0x6C1FAF0", VA = "0x186C206F0")]
	internal IEnumerable<NCIACKHDFAL> KKENJKPAHNJ(string JKLOMMIKPNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F820", Offset = "0x6C1EC20", VA = "0x186C1F820")]
	private NCIACKHDFAL BMJBGHGGOLI(AvatarOutfitSelectionData DHFMEEOKOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6C20F90", Offset = "0x6C20390", VA = "0x186C20F90")]
	private void OCMPGDGNEJE(AvatarCustomizationSettingsData HHLMINBPHDM, DFJMGIPIJKE ENEAIENGPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FBB0", Offset = "0x6C1EFB0", VA = "0x186C1FBB0")]
	private NCIACKHDFAL BMJBGHGGOLI(string CBBNNPHNMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F520", Offset = "0x6C1E920", VA = "0x186C1F520")]
	internal static (MHMNKAMKDLO, string, string) BLPANPHEHAF(string CBBNNPHNMPL, MBKGHNEMCHF GIHKDNFKCLH)
	{
		return default((MHMNKAMKDLO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FED0", Offset = "0x6C1F2D0", VA = "0x186C1FED0")]
	private FDOJHHHBKGC? DAANCNDIEND(string? MDOJFEIEAFI, Vector2 APONDDOHFIM, float KKNKIMBIPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F3C0", Offset = "0x6C1E7C0", VA = "0x186C1F3C0")]
	private static CHCOONHOENK BDGEKDJMNDO(AvatarCustomizationSettingsData.AnchorParams BJPCNDMKOPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[MMCIGIHMOCH]
internal class DJCCDCPAMCM : FJCEFFCBILD, AJGEJMAFCNO
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6C16D00", Offset = "0x6C16100", VA = "0x186C16D00")]
	public DJCCDCPAMCM(JODBKJMGABO ONAGMFEHANA, LDBPMFKPPIO FKPCJKGGMDE, MBKGHNEMCHF GIHKDNFKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6C16610", Offset = "0x6C15A10", VA = "0x186C16610", Slot = "4")]
	public GFHPOLJBJAE IJIPNHCCMND(DFJMGIPIJKE EIFGKHNPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6C16C00", Offset = "0x6C16000", VA = "0x186C16C00")]
	private string PCIEAPLIICF(DFJMGIPIJKE ENEAIENGPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6C169C0", Offset = "0x6C15DC0", VA = "0x186C169C0")]
	private string MLKHKGEEPHF(NCIACKHDFAL LPLAFPLEDLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[MMCIGIHMOCH]
internal class DMDCFDHMDHM : MOBFINLEHGE<KCEABFJAODA, IKFJOBFMBCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly JODBKJMGABO ONAGMFEHANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly LNNPBCHFLGI<KCEABFJAODA, IKFJOBFMBCH> JAFBGBHNAPG;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6C172B0", Offset = "0x6C166B0", VA = "0x186C172B0")]
	public DMDCFDHMDHM(LNNPBCHFLGI<KCEABFJAODA, IKFJOBFMBCH> JAFBGBHNAPG, MBKGHNEMCHF GIHKDNFKCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6C16E80", Offset = "0x6C16280", VA = "0x186C16E80", Slot = "6")]
	public override IKFJOBFMBCH LIJBJHOEHGL(KCEABFJAODA CMILLOOAKEN, [Out] IReadOnlyList<CPFMBEFACFM>? LDCBMLEDFEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[MMCIGIHMOCH]
internal class EOMLCDKKEEB : JHNADEPKBAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly JODBKJMGABO ONAGMFEHANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly AJGEJMAFCNO NADCJOKCELD;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6C19710", Offset = "0x6C18B10", VA = "0x186C19710")]
	public EOMLCDKKEEB(AJGEJMAFCNO NADCJOKCELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6C19360", Offset = "0x6C18760", VA = "0x186C19360", Slot = "4")]
	public KCEABFJAODA IJIPNHCCMND(DFJMGIPIJKE EIFGKHNPLEK, int IHPPMBJAKIG, string? ACDGEPBIBHJ, string? FAMFKKBKACM, PAEOCALEFHE IFBJNMEBEEF, List<CPFMBEFACFM>? LDCBMLEDFEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RecRoom.NoEngine.Common.Preserve]
internal class ENGGNMIDAAG : LAFAECECKPI
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 DKAEJPFIMMP;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 OFFCODOJIJF;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly Vector2 DFNEGPMIADK;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly Vector2 CIMKAFJIMBG;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static readonly Vector2 NJBJHFPDANC;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static readonly Vector2 DPLMODBMJIA;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static readonly Vector2 CJCONMJANCD;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly Vector2 GGHPKIKKCIO;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static readonly Vector2 JKOIHEDIACE;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly Vector2 BJBFKHHDIFA;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private static readonly Vector2 KGMLIDJELAN;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly Vector2 JJFLFIIJMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Dictionary<JNJINABLMLP, AvatarConfiguration> GLLJIAGFFNA;

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6C17810", Offset = "0x6C16C10", VA = "0x186C17810")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void BHNOBBLNEHN(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6C192B0", Offset = "0x6C186B0", VA = "0x186C192B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ENGGNMIDAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6C18B10", Offset = "0x6C17F10", VA = "0x186C18B10", Slot = "4")]
	public Vector2 OAFMKEKPBHH(FaceFeatureType DBDIJEFBNAK, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6C18C80", Offset = "0x6C18080", VA = "0x186C18C80", Slot = "5")]
	public float OBKGMLKBOOI(FaceFeatureType DBDIJEFBNAK, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6C18430", Offset = "0x6C17830", VA = "0x186C18430", Slot = "6")]
	public void JALEHFHKOIB(JNJINABLMLP FPADOKOMPIJ, AvatarConfiguration HPDJOCEPKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6C184A0", Offset = "0x6C178A0", VA = "0x186C184A0", Slot = "7")]
	public void KAEFPBBDNCD(MJFJHIHLFBJ MJDIOJJGPEE, AvatarConfiguration MNIPNMAGNED, JNJINABLMLP HCDLPEMFILE, JNJINABLMLP IAMMKJNCFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6C17C90", Offset = "0x6C17090", VA = "0x186C17C90", Slot = "8")]
	public float DLIKNBINNID(FaceFeatureType GLGNKKIHJGD, float CLLGCBCMEEB, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6C18AE0", Offset = "0x6C17EE0", VA = "0x186C18AE0", Slot = "9")]
	public float NPFLDMLJOJL(FaceFeatureType GLGNKKIHJGD, float KKNKIMBIPJE, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C17EC0", Offset = "0x6C172C0", VA = "0x186C17EC0", Slot = "11")]
	public Vector2 FJANHCOGBEA(FaceFeatureType GLGNKKIHJGD, Vector2 PFCFHEEIOOD, Vector2 HAAGPCIGHKN, Vector2 PNDNNDOIGGA, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C17940", Offset = "0x6C16D40", VA = "0x186C17940", Slot = "10")]
	public Vector2 CHMLHHOBAAI(FaceFeatureType GLGNKKIHJGD, Vector2 DIGHGMEJIJE, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C18A40", Offset = "0x6C17E40", VA = "0x186C18A40")]
	private Vector2 NIOOBHODKHP(FaceFeatureType GLGNKKIHJGD, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C188D0", Offset = "0x6C17CD0", VA = "0x186C188D0")]
	private Vector2 MNKNBCCIIBE(FaceFeatureType GLGNKKIHJGD, Vector2 PFCFHEEIOOD, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C18D00", Offset = "0x6C18100", VA = "0x186C18D00", Slot = "12")]
	public Vector2 OMJCNFBPCHD(FaceFeatureType GLGNKKIHJGD, Vector2 DIGHGMEJIJE, Vector2 HAAGPCIGHKN, Vector2 PNDNNDOIGGA, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C17440", Offset = "0x6C16840", VA = "0x186C17440", Slot = "13")]
	public float AHOMFKHKLNA(FaceFeatureType GLGNKKIHJGD, float KKNKIMBIPJE, JNJINABLMLP FPADOKOMPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C173B0", Offset = "0x6C167B0", VA = "0x186C173B0")]
	private float AANEKDDAFIC(float AOFEGKJKMDG, float FBENJJMLPKG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C18330", Offset = "0x6C17730", VA = "0x186C18330")]
	private Vector2 HOMKNGENAAI(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C18550", Offset = "0x6C17950", VA = "0x186C18550")]
	private Vector2 KEALOGNIGON(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C183B0", Offset = "0x6C177B0", VA = "0x186C183B0")]
	private Vector2 ILOCMIGFBDH(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C185D0", Offset = "0x6C179D0", VA = "0x186C185D0")]
	private Vector2 LCAHJACDCIM(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C18070", Offset = "0x6C17470", VA = "0x186C18070")]
	private float FLCNPOHCFOE(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C17DA0", Offset = "0x6C171A0", VA = "0x186C17DA0")]
	private float FDGHBIPPBDF(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C176F0", Offset = "0x6C16AF0", VA = "0x186C176F0")]
	private float APJCJLJDKLI(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C17C50", Offset = "0x6C17050", VA = "0x186C17C50")]
	private float DHMPDCACLGA(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C17CC0", Offset = "0x6C170C0", VA = "0x186C17CC0")]
	private Vector2 EFJCOKDFLHP(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C18250", Offset = "0x6C17650", VA = "0x186C18250")]
	private Vector2 HHPIHMEAOCB(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C17DE0", Offset = "0x6C171E0", VA = "0x186C17DE0")]
	private Vector2 FILEHNPBKEL(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C180B0", Offset = "0x6C174B0", VA = "0x186C180B0")]
	private Vector2 GKOMDKMBGCE(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C17730", Offset = "0x6C16B30", VA = "0x186C17730")]
	private Vector2 BEAHIHMDPHM(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C17610", Offset = "0x6C16A10", VA = "0x186C17610")]
	private Vector2 AJBHANNDCPL(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C187F0", Offset = "0x6C17BF0", VA = "0x186C187F0")]
	private Vector2 LNHBEBGACEN(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C18650", Offset = "0x6C17A50", VA = "0x186C18650")]
	private Vector2 LFFHFFAGEIO(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C17B70", Offset = "0x6C16F70", VA = "0x186C17B70")]
	private Vector2 CKONIMBGHMH(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C18190", Offset = "0x6C17590", VA = "0x186C18190")]
	private Vector2 HBBMPKBACDO(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C17880", Offset = "0x6C16C80", VA = "0x186C17880")]
	private Vector2 CBMLNBGAGFD(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C18730", Offset = "0x6C17B30", VA = "0x186C18730")]
	private Vector2 LGMDGMLBMIM(JNJINABLMLP FPADOKOMPIJ)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C12570", Offset = "0x6C11970", VA = "0x186C12570")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class DFJKNDJCJCC
{
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C15F30", Offset = "0x6C15330", VA = "0x186C15F30")]
	public static MMGKCPFJLPI LIJBJHOEHGL(this LFFEMHKFCFD EIFGKHNPLEK)
	{
		return default(MMGKCPFJLPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C15E10", Offset = "0x6C15210", VA = "0x186C15E10")]
	public static LFFEMHKFCFD IJIPNHCCMND(this MMGKCPFJLPI CFDNGIINCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C15DB0", Offset = "0x6C151B0", VA = "0x186C15DB0")]
	public static bool DMLPNPMPNLC(this MMGKCPFJLPI CFDNGIINCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C15D50", Offset = "0x6C15150", VA = "0x186C15D50")]
	public static bool AMHAPOIIJDH(this MMGKCPFJLPI CFDNGIINCOC)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x505E170", Offset = "0x505D570", VA = "0x18505E170")]
			public AnchorParams(Vector2 PFCFHEEIOOD, Vector3 FHNIIMABIHN, Vector3 OFFMKFJBHHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6C124C0", Offset = "0x6C118C0", VA = "0x186C124C0")]
			internal CHCOONHOENK IJIPNHCCMND()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private NKFNPGNHNGI useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x6C12DA0", Offset = "0x6C121A0", VA = "0x186C12DA0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3FBF800", Offset = "0x3FBEC00", VA = "0x183FBF800")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9F1D90", Offset = "0x9F1190", VA = "0x1809F1D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA9B890", Offset = "0xA9AC90", VA = "0x180A9B890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD14DA0", VA = "0x180D159A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x89EF30", Offset = "0x89E330", VA = "0x18089EF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6C12E50", Offset = "0x6C12250", VA = "0x186C12E50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8A1330", Offset = "0x8A0730", VA = "0x1808A1330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xB923A0", Offset = "0xB917A0", VA = "0x180B923A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x13E0AE0", Offset = "0x13DFEE0", VA = "0x1813E0AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89F1B0", VA = "0x18089FDB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x89FBE0", Offset = "0x89EFE0", VA = "0x18089FBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6C12E90", Offset = "0x6C12290", VA = "0x186C12E90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9CF5B0", Offset = "0x9CE9B0", VA = "0x1809CF5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xBD2EF0", Offset = "0xBD22F0", VA = "0x180BD2EF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x11C7060", Offset = "0x11C6460", VA = "0x1811C7060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x89D9E0", Offset = "0x89CDE0", VA = "0x18089D9E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x89D990", Offset = "0x89CD90", VA = "0x18089D990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x44B9540", Offset = "0x44B8940", VA = "0x1844B9540")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA01F20", Offset = "0xA01320", VA = "0x180A01F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8D1790", Offset = "0x8D0B90", VA = "0x1808D1790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8D17F0", Offset = "0x8D0BF0", VA = "0x1808D17F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x89FC50", Offset = "0x89F050", VA = "0x18089FC50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x89FCD0", Offset = "0x89F0D0", VA = "0x18089FCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x89FC60", Offset = "0x89F060", VA = "0x18089FC60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x89FBF0", Offset = "0x89EFF0", VA = "0x18089FBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x89FC70", Offset = "0x89F070", VA = "0x18089FC70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x89FC20", Offset = "0x89F020", VA = "0x18089FC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x929060", Offset = "0x928460", VA = "0x180929060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xE24CE0", Offset = "0xE240E0", VA = "0x180E24CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x89FBC0", Offset = "0x89EFC0", VA = "0x18089FBC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x89FD60", Offset = "0x89F160", VA = "0x18089FD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9F1750", Offset = "0x9F0B50", VA = "0x1809F1750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9EFFD0", Offset = "0x9EF3D0", VA = "0x1809EFFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x89A360", Offset = "0x899760", VA = "0x18089A360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x89A420", Offset = "0x899820", VA = "0x18089A420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x9711F0", Offset = "0x9705F0", VA = "0x1809711F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA03B90", Offset = "0xA02F90", VA = "0x180A03B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xD1E460", Offset = "0xD1D860", VA = "0x180D1E460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1059990", Offset = "0x1058D90", VA = "0x181059990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public NKFNPGNHNGI UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA1660", Offset = "0xAA0A60", VA = "0x180AA1660")]
			get
			{
				return default(NKFNPGNHNGI);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F30", Offset = "0xAA0330", VA = "0x180AA0F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA1360", Offset = "0xAA0760", VA = "0x180AA1360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA1B40", Offset = "0xAA0F40", VA = "0x180AA1B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x6C12E70", Offset = "0x6C12270", VA = "0x186C12E70")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6C12EB0", Offset = "0x6C122B0", VA = "0x186C12EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C12A00", Offset = "0x6C11E00", VA = "0x186C12A00")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public MHMNKAMKDLO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private PFOMBIPKCAJ? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x6C14F70", Offset = "0x6C14370", VA = "0x186C14F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
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
