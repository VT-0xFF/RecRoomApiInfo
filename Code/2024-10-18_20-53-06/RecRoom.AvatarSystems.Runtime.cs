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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C82180", Offset = "0x6C81580", VA = "0x186C82180")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C9B340", Offset = "0x6C9A740", VA = "0x186C9B340", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JEGDMIPNMMJ]
internal class LNENIBHFOMP : BBCEEFPPLMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FKIPHNPLCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public LNENIBHFOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public OJHEMGLCFCA avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MMAAGBCFEAN MKODILAIJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BPHHIBAOOMD CABPEAIFEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AJGMPEPJFOL FDECINOLCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NBOFHJGIADK PMCCPLPJBDN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F850", Offset = "0x6C7EC50", VA = "0x186C7F850")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	[UsedImplicitly]
	internal static void ADEMPLHINMH(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C811C0", Offset = "0x6C805C0", VA = "0x186C811C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LNENIBHFOMP([CCLHMIDBCEM(null)] MMAAGBCFEAN MKODILAIJGI, [CCLHMIDBCEM(null)] BPHHIBAOOMD CABPEAIFEPA, [CCLHMIDBCEM(null)] AJGMPEPJFOL FDECINOLCBO, [CCLHMIDBCEM(null)] NBOFHJGIADK PMCCPLPJBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FAF0", Offset = "0x6C7EEF0", VA = "0x186C7FAF0", Slot = "5")]
	public BFNDHBOFNNE GMDIPFNNPIO(OJHEMGLCFCA OFELOJDHFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C80570", Offset = "0x6C7F970", VA = "0x186C80570", Slot = "4")]
	public BFNDHBOFNNE HOEBEAFFMIJ(OJHEMGLCFCA OFELOJDHFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C80F40", Offset = "0x6C80340", VA = "0x186C80F40", Slot = "6")]
	public CIBGHHDGNPO IEMOGPONEJF(BFNDHBOFNNE AIKOCCMKKAE, int OFIAEKGDMFK, string? DDDHPCNFCEK, string? OCJLJNPJPKG, FLOAFIFFJHG NPFAKIKEAMF, List<FIOFGMBEDNB>? KOJLKIGKMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F8C0", Offset = "0x6C7ECC0", VA = "0x186C7F8C0", Slot = "7")]
	public bool CKAEDPGDCCD(INHFFNLLDDF HLMKKBLEAFL, [Out] BFNDHBOFNNE? HKAHDMHKEIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C81050", Offset = "0x6C80450", VA = "0x186C81050", Slot = "8")]
	public bool KOKNKBODOCB(CIBGHHDGNPO DCJKICLDAJI, [Out] BFNDHBOFNNE? HKAHDMHKEIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C81130", Offset = "0x6C80530", VA = "0x186C81130", Slot = "9")]
	public bool OPINHPEDMOM(CIBGHHDGNPO DCJKICLDAJI, [Out] NFJNJHKNJNH? HLMKKBLEAFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2F169F0", Offset = "0x2F15DF0", VA = "0x182F169F0")]
	private bool NHJPMMNFDNI<TInput, TOutput>(TInput EBJHHBADCKF, FJLANEHODAC<TInput, TOutput> LJCALMBJGHJ, [Out] TOutput? IPNDOKDOGDG) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F950", Offset = "0x6C7ED50", VA = "0x186C7F950")]
	[CompilerGenerated]
	private IBOGHKPHLPM CNEHMBHMJGB(FaceFeatureType IAOGKLDOLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C802A0", Offset = "0x6C7F6A0", VA = "0x186C802A0")]
	[CompilerGenerated]
	private IBOGHKPHLPM GOLBBAPEEME(FaceFeatureType IAOGKLDOLJN, FKIPHNPLCLJ P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[JEGDMIPNMMJ]
internal class LHOMFGIJMND : MMAAGBCFEAN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void JNONNFMNBML<in TData>(TData HKAHDMHKEIF, IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AJGMPEPJFOL FDECINOLCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CFKANHJCJBB IMDPBFNLDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JNONNFMNBML<BFNDHBOFNNE>?[] MKODILAIJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JNONNFMNBML<NFJNJHKNJNH>?[] IBMIEIPAMIO;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E500", Offset = "0x6C7D900", VA = "0x186C7E500")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	[UsedImplicitly]
	internal static void ADEMPLHINMH(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F490", Offset = "0x6C7E890", VA = "0x186C7F490")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LHOMFGIJMND([CCLHMIDBCEM(null)] AJGMPEPJFOL FDECINOLCBO, [CCLHMIDBCEM(null)] CFKANHJCJBB IMDPBFNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C7EFD0", Offset = "0x6C7E3D0", VA = "0x186C7EFD0", Slot = "4")]
	public bool JGDONJJKKDL(BFNDHBOFNNE HKAHDMHKEIF, IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F0D0", Offset = "0x6C7E4D0", VA = "0x186C7F0D0", Slot = "5")]
	public bool JGDONJJKKDL(NFJNJHKNJNH HLMKKBLEAFL, IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E570", Offset = "0x6C7D970", VA = "0x186C7E570")]
	private void CJGJPHNKCOH(BFNDHBOFNNE HKAHDMHKEIF, IReadOnlyList<FIOFGMBEDNB>? EFCBJHHANBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F260", Offset = "0x6C7E660", VA = "0x186C7F260")]
	private void OCNHDJLBMKH(BFNDHBOFNNE HKAHDMHKEIF, IReadOnlyList<FIOFGMBEDNB>? EFCBJHHANBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C7EFA0", Offset = "0x6C7E3A0", VA = "0x186C7EFA0")]
	private void HOFHCJPFKBE(BFNDHBOFNNE HKAHDMHKEIF, IReadOnlyList<FIOFGMBEDNB>? EFCBJHHANBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C7F230", Offset = "0x6C7E630", VA = "0x186C7F230")]
	private void KHNAOJKEMMF(BFNDHBOFNNE HKAHDMHKEIF, IReadOnlyList<FIOFGMBEDNB>? EFCBJHHANBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MMAAGBCFEAN
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGDONJJKKDL(BFNDHBOFNNE HKAHDMHKEIF, IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JGDONJJKKDL(NFJNJHKNJNH HLMKKBLEAFL, IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM);
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
		public NPMELALGOIO AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6C7B240", Offset = "0x6C7A640", VA = "0x186C7B240")]
		public void FKNBBEDEHON(AnimationPoseSetting KNLMODPGFOA, float AGPDFGFBCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B370", Offset = "0x6C7A770", VA = "0x186C7B370")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendHelperController : MonoBehaviour, OCFGMGFBNFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
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
		private Vector3? DIFJDOBBJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool FHAIGAGAFKG;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B390", Offset = "0x6C7A790", VA = "0x186C7B390", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B970", Offset = "0x6C7AD70", VA = "0x186C7B970", Slot = "4")]
		public void UpdateController(float KDDKBBMEFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x113DCF0", Offset = "0x113D0F0", VA = "0x18113DCF0", Slot = "6")]
		public void SetEnabled(bool EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B430", Offset = "0x6C7A830", VA = "0x186C7B430")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BE00", Offset = "0x6C7B200", VA = "0x186C7BE00")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarElbowBendTargetController : MonoBehaviour, OCFGMGFBNFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float MIOMDHNCJBF = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
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
		private Vector3 IKGBDOMDBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 BGKEIJAIABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FHAIGAGAFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float PKENDDNOBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float CIANHMIIPEL;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C180", Offset = "0x6C7B580", VA = "0x186C7C180", Slot = "4")]
		public void UpdateController(float KDDKBBMEFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xC0EBB0", Offset = "0xC0DFB0", VA = "0x180C0EBB0", Slot = "6")]
		public void SetEnabled(bool EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BEA0", Offset = "0x6C7B2A0", VA = "0x186C7BEA0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CC40", Offset = "0x6C7C040", VA = "0x186C7CC40")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7D540", Offset = "0x6C7C940", VA = "0x186C7D540")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D500", Offset = "0x6C7C900", VA = "0x186C7D500")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CC70", Offset = "0x6C7C070", VA = "0x186C7CC70")]
		private void HLCANFNLAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C44DB0", Offset = "0x6C441B0", VA = "0x186C44DB0", Slot = "4")]
		public void SetEnabled(bool BOCGODCJHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D570", Offset = "0x6C7C970", VA = "0x186C7D570")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarForearmRollController : MonoBehaviour, OCFGMGFBNFD
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
		private float PKENDDNOBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool FHAIGAGAFKG;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D5B0", Offset = "0x6C7C9B0", VA = "0x186C7D5B0", Slot = "4")]
		public void UpdateController(float KDDKBBMEFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x10CBC80", Offset = "0x10CB080", VA = "0x1810CBC80", Slot = "6")]
		public void SetEnabled(bool EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E030", Offset = "0x6C7D430", VA = "0x186C7E030")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7E0A0", Offset = "0x6C7D4A0", VA = "0x186C7E0A0")]
		public AnimationPoseSetting LBLIGLNCJBL(NPMELALGOIO IPPECFBOPHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E060", Offset = "0x6C7D460", VA = "0x186C7E060")]
		public void IPNPHEKPPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E0D0", Offset = "0x6C7D4D0", VA = "0x186C7E0D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7E4C0", Offset = "0x6C7D8C0", VA = "0x186C7E4C0")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NPCIKFLJJGC : OKJNLEKGHKB
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int DOBFICLHIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int ELJJKOKNIOJ;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int CMMBAPMKDOG;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int FGNBLCOLLJL;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int IIBAMFLBPJK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int DCAHHJCIKEJ;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int AHAAMFFAPBJ;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int[] CIAOPKLDAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private EJACKGLNBEA HCLPDPDMGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private ONLIPADCKIK OAJEGANELGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int CKLNEJOJHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private float KCJEOBJHPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator ECKABNKLGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private AvatarFullBodyConfiguration HOMBHGNLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int LDPCMKNFOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int FHKIAHJIHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int GAPBFDPPHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool HCIIAPJKIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private GFOPDLKKFMG BGIEGHNJKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int KCIOIALAFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private float GGPMAFHIJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private HandDisplaySettings ADMFIOINMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private OJHEMGLCFCA GPJHOADBLEO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform CKABLFCNHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 CODPEIGNGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10BF3A0", Offset = "0x10BE7A0", VA = "0x1810BF3A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x10BF420", Offset = "0x10BE820", VA = "0x1810BF420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion DMAEEHBEPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x17B7ED0", Offset = "0x17B72D0", VA = "0x1817B7ED0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x21A0150", Offset = "0x219F550", VA = "0x1821A0150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool NNAGIIEOHED
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6C81B00", Offset = "0x6C80F00", VA = "0x186C81B00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6C81D40", Offset = "0x6C81140", VA = "0x186C81D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 CEBEHNGKJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xEBA7A0", Offset = "0xEB9BA0", VA = "0x180EBA7A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEB9A40", Offset = "0xEB8E40", VA = "0x180EB9A40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion IGPIPBGNHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB84C80", Offset = "0xB84080", VA = "0x180B84C80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xEB9440", Offset = "0xEB8840", VA = "0x180EB9440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NCFKEMPCADI BHLLDFNHACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA38670", Offset = "0xA37A70", VA = "0x180A38670", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(NCFKEMPCADI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA375E0", Offset = "0xA369E0", VA = "0x180A375E0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NCFKEMPCADI MHPEOGEAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x158D5A0", Offset = "0x158C9A0", VA = "0x18158D5A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(NCFKEMPCADI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1D918F0", Offset = "0x1D90CF0", VA = "0x181D918F0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float PKBIDOPDPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x17F6B10", Offset = "0x17F5F10", VA = "0x1817F6B10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA38B10", Offset = "0xA37F10", VA = "0x180A38B10", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool GIPNIAGPBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C81D70", Offset = "0x6C81170", VA = "0x186C81D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DPNCNALIAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C81D80", Offset = "0x6C81180", VA = "0x186C81D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FKIAMNJIKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C81570", Offset = "0x6C80970", VA = "0x186C81570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BBFOGMJCFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C81E30", Offset = "0x6C81230", VA = "0x186C81E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C818D0", Offset = "0x6C80CD0", VA = "0x186C818D0", Slot = "21")]
	public void CGCFJDLGJFP(EJACKGLNBEA HGHNKBINKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C81D90", Offset = "0x6C81190", VA = "0x186C81D90")]
	public void MCIKLCLLBBL(ONLIPADCKIK GMJMLMCNDLM, HandDisplaySettings AOECAENFDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C81CB0", Offset = "0x6C810B0", VA = "0x186C81CB0", Slot = "12")]
	public void HIKEOBAPCLA(bool JFIONMMANLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C81580", Offset = "0x6C80980", VA = "0x186C81580", Slot = "11")]
	public void CBAGMIKGFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C813B0", Offset = "0x6C807B0", VA = "0x186C813B0")]
	private int AFCONBEHIEJ(NCFKEMPCADI HMNKCALELIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C81B30", Offset = "0x6C80F30", VA = "0x186C81B30")]
	private void ENPNIJIPNPE(int IJFLBMJJJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C818B0", Offset = "0x6C80CB0", VA = "0x186C818B0", Slot = "13")]
	public bool CBBHOGEIAIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C81C80", Offset = "0x6C81080", VA = "0x186C81C80", Slot = "14")]
	public bool FCGDLEBHGCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C81DE0", Offset = "0x6C811E0", VA = "0x186C81DE0")]
	private NCFKEMPCADI NFENDBLPKPM()
	{
		return default(NCFKEMPCADI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA00FC0", Offset = "0xA003C0", VA = "0x180A00FC0", Slot = "15")]
	public void LPHKAMJNCGL(bool JFIONMMANLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C81EA0", Offset = "0x6C812A0", VA = "0x186C81EA0", Slot = "10")]
	public void PPPIDJOGOEB(int IJFLBMJJJOL, float NPFDNIJCEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C81C90", Offset = "0x6C81090", VA = "0x186C81C90", Slot = "8")]
	public void FDHEALAGHNB(GFOPDLKKFMG NMAIGNOENJN, bool OLDPCMHFMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C81E40", Offset = "0x6C81240", VA = "0x186C81E40", Slot = "9")]
	public void PLCLKBGFJNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C81E50", Offset = "0x6C81250", VA = "0x186C81E50", Slot = "16")]
	public void PNMMGHHENLG(Transform DEDHJMDEEIE, Vector3 AIPIPEIGGHJ, Quaternion OOLJKOKKGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C82170", Offset = "0x6C81570", VA = "0x186C82170")]
	public NPCIKFLJJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OJFBLECGCCE : KMAJMHNAMGE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class DOIMENJFFIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3 MKAHMBOALDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Quaternion BHOEOFGIOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 PFALCLONBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Transform IPFILMKCAJM;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 GCKGOGHKPDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x1825120", Offset = "0x1824520", VA = "0x181825120")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1825140", Offset = "0x1824540", VA = "0x181825140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion MFMGBKPPNBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xDFD690", Offset = "0xDFCA90", VA = "0x180DFD690")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xDFD920", Offset = "0xDFCD20", VA = "0x180DFD920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float IHPBEACLFFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xB84D00", Offset = "0xB84100", VA = "0x180B84D00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1168DF0", Offset = "0x11681F0", VA = "0x181168DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool CIOHKEHLCLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C80", Offset = "0x8B2080", VA = "0x1808B2C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8B2CA0", Offset = "0x8B20A0", VA = "0x1808B2CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool MMMMNCEDDPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8B2CE0", Offset = "0x8B20E0", VA = "0x1808B2CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8B2CB0", Offset = "0x8B20B0", VA = "0x1808B2CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool MHFNHBNHAPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8B2CC0", Offset = "0x8B20C0", VA = "0x1808B2CC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C60", Offset = "0x8B2060", VA = "0x1808B2C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float NAAAEGFJCAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xB84D20", Offset = "0xB84120", VA = "0x180B84D20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x27F5A80", Offset = "0x27F4E80", VA = "0x1827F5A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0670", Offset = "0x6C9FA70", VA = "0x186CA0670")]
		public void HGHOBJHKCJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0660", Offset = "0x6C9FA60", VA = "0x186CA0660")]
		public void GMHAJCAFIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6CA08B0", Offset = "0x6C9FCB0", VA = "0x186CA08B0")]
		public float LJEOCMIELEM(Vector3 PCOFOIBDPCP, Quaternion OKEMDIEFICI, [In] FootSettings AFHIEJIBLCI, float JDLPCPHKCFH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FE90", Offset = "0x6C9F290", VA = "0x186C9FE90")]
		public void COFBFHDIEMI(Vector3 LGNEDPPFFPB, Quaternion PCHCGGCJBEN, Transform JDJCFMBJGMM, float AMFDELKINHD, bool DLFAIPOFIJF, bool HLKAKNJFHCP, float EDLPAOIFKBJ, float NHJEKJBCBEM, Transform KCFGMPGPMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0680", Offset = "0x6C9FA80", VA = "0x186CA0680")]
		public void LEFIHLJHDKE(Transform IMNCNKPCOAG, Transform KCFGMPGPMFA, bool IHIFIKDNPBN, bool NIJELCMAFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0560", Offset = "0x6C9F960", VA = "0x186CA0560")]
		private void FGFABCBEJME(Transform KCFGMPGPMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0AC0", Offset = "0x6C9FEC0", VA = "0x186CA0AC0")]
		public void LPCOKKJEJLG(Transform KCFGMPGPMFA, AvatarFullBodyConfiguration HGDDFPIIMHP, Vector3 NPBHDLENHFM, float MNHLDHGGOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FE80", Offset = "0x6C9F280", VA = "0x186C9FE80")]
		public void CJNJCJBAOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0C10", Offset = "0x6CA0010", VA = "0x186CA0C10")]
		public DOIMENJFFIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class PLFDMAEANAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float DOGGAABAFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool AMFBGENPFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AnimationPoseSetting OMLNOGOPIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float BBHJKBHHIPM;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA5A0", Offset = "0x6CA99A0", VA = "0x186CAA5A0")]
		public void IDOHPPNHJEA(IKSolverVR.Arm FCJKJEKOEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9AC0", Offset = "0x6CA8EC0", VA = "0x186CA9AC0")]
		public void CCAKAEFGFIM(IKSolverVR.Arm FCJKJEKOEGF, float HOGDNIGNMHM, bool AMFBGENPFHI, AvatarFullBodyConfiguration HGDDFPIIMHP, float NJKOHBLGLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA5D0", Offset = "0x6CA99D0", VA = "0x186CAA5D0")]
		private void KMLJDKMAAMH(IKSolverVR.Arm FCJKJEKOEGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA610", Offset = "0x6CA9A10", VA = "0x186CAA610")]
		public void NOFOGNCALED(IKSolverVR.Arm FCJKJEKOEGF, Transform GNEOOGOKPCG, Transform JDJCFMBJGMM, Quaternion DOGGOLMKJJM, Vector3 IPGCNGDPIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6CA94D0", Offset = "0x6CA88D0", VA = "0x186CA94D0")]
		private (Vector3, Quaternion) BBMEFNNMPJD(NPCIKFLJJGC MCCFFBFCKFN, Quaternion ALELHFHPKJJ, Vector3 DHAFMFBHIKI)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9960", Offset = "0x6CA8D60", VA = "0x186CA9960")]
		public void BDAEDKEEKBB(NPCIKFLJJGC MCCFFBFCKFN, IKSolverVR.Arm FCJKJEKOEGF, Quaternion ALELHFHPKJJ, Vector3 DHAFMFBHIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9FA0", Offset = "0x6CA93A0", VA = "0x186CA9FA0")]
		public void HFACHGDCKNI(NPCIKFLJJGC MCCFFBFCKFN, IKSolverVR.Arm FCJKJEKOEGF, Quaternion ALELHFHPKJJ, Vector3 DHAFMFBHIKI, [In] AvatarFullBodyConfiguration HGDDFPIIMHP, [In] DBGGFBFPGLA NMAIGNOENJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA9F0", Offset = "0x6CA9DF0", VA = "0x186CAA9F0")]
		public void PPDKGCKMEOI(NPMELALGOIO KFLCIFMNGCG, AvatarFullBodyConfiguration HGDDFPIIMHP, DBGGFBFPGLA NMAIGNOENJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9B00", Offset = "0x6CA8F00", VA = "0x186CA9B00")]
		public void EDCOHPJBBDF(IKSolverVR.Arm FCJKJEKOEGF, Transform GNEOOGOKPCG, Vector3 CIKHMONKMEE, float NJFFOMEMCFK, Quaternion NBLNCIPHNAM, Vector3 FFDJCHFKHDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAB20", Offset = "0x6CA9F20", VA = "0x186CAAB20")]
		public PLFDMAEANAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum MFOKLHAMBNH
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
	private struct NEHMIADJHAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct LBNFBLEDHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int KDGPEDNPACH;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int KEEBGOJCEIG;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int HNKCJNJPPHL;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int JCNBJJBLDNK;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int GEJPEDJBKDD;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int MJBEJCOOBMM;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int DHLECMLOHJC;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int ADFHNGMAOHB;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int IDBAMEJNONF;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int MLAAHCAKPBM;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int AKJMFNDMDEL;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int LOKOHHNBHJO;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int HDGKLFPMHKF;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int DIPPKHNHBLI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int NMJKDMPBBHJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int PCPLHOKFCJG;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int FPGFLHJALHF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int NJJCAPNKFBA;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int LFJLFDKPMOH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int MONKCJHJFAH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int FHBANPLDGBA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int GONIIDKDFLN;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int NEKCODCKFMI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int OMHKABOBPHI;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int DMBAJJMAFJK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int AHEHIHEBHEM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int LDHCEEFHFAE;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int ALHDNBMKBBG;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int OGPFHMEHJPC;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 CGJHMGOFCAB;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int NOHCFJGODAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool IIJLNNHKAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool EKPBGNBHKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool FBGGPHLDKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool KNMPCNGLJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool BACGKHNNBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Vector3 BOOPAAIMEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private string IJAKLDEJGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private FKONMJCFGHH? HCLPDPDMGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private CJCIOJDIDLI? NGGJKLFFGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private BAJDMDMLFIB NOKPEOFHCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private LHAALAHCKGK JHBJDAKGKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private NPCIKFLJJGC HIPGOAPNLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NPCIKFLJJGC LGGHGIDINOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool MADAIFEPKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool CODCCPAOGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly FMHHDNPLFFL APPPILMHELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly CMFCMNBIANI AAIDAFKMECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int NGOBAJDPJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float CKEGBJEHCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GameObject LHJAICKKDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform EEPLBAHCGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform BDDICDGOIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform BOCFOBBNKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform BIKGBFLBJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform GHHHKMIKGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float DEMKKMKOMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float KPAIJELLPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 MNOGPFBNCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Quaternion AKIOIMPKKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform NKCDAMHCGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform LLMONPILKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform ABFNJJHNJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool LEDEOLJFIMN;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker AIAFENGPHCA;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker PCOCINJFFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker HDAHKOAMHOL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker DKNFMNFJHIC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker JGPGECKEPAO;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker MAPHKFFKMIK;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<OJFBLECGCCE> FNBINOCIDNP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int ONPGNBKLDMF;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> ELCEIPOMMBO;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int MHIMHKNNNIC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int NHJNFEFBIGA;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int KJHJIIOMKNI;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int NDPADHAGOJL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float BMEHHAAMCBE;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int JDOCIBNMPDA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float ALEEIIABFIK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float GBHMBACKEND;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float PNNNHNIHGHM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float IBCPDBHHLGI;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static OKGBOMIHNHM KIMDFKJDLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float PCCMAHCCIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool GMPLPPANEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float ONCJBOPFJEB;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int OFHBECAKIEF;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int MJBMAFNGEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private DOIMENJFFIB HJAENCCAPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private DOIMENJFFIB KCEGDLIFHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float FMINKHIMCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Vector3 EKFOPLEIJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Vector3 PNIDCANFFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool PPGAFPGJBDM;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion KFBCODGCIPM;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion BBEOPJEMOPK;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 LBFGCBJFBNN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 AJAGDBIHPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float MACDHJMFDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float BBMHDACNFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private PLFDMAEANAJ LDDKKLIIMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private PLFDMAEANAJ DBJCJDLDOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private MGKDPHEOGOK KOIHMAHFFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private IFIBOBEMCOA EILJGECJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly ELOJEKNNKBG PAIEKJFAPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float DJMMKEBDNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float EOBAODNBBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly IFIBOBEMCOA HCGLBFDAEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 ELOEEGOIEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Vector3 APDNLHJIADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float JJDEIOFPJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float FPPGFOIOKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly IFIBOBEMCOA BHGCMDJOFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly MGKDPHEOGOK POKDHNGIBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly IFIBOBEMCOA LEOMNPPPDKO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LDNMACGBDLI APGFLMCHHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LDNMACGBDLI AFPLBCLGMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration GEMGFFCAADP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C926F0", Offset = "0x6C91AF0", VA = "0x186C926F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OJHEMGLCFCA ODMIHOFOGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C88430", Offset = "0x6C87830", VA = "0x186C88430", Slot = "23")]
		get
		{
			return default(OJHEMGLCFCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration DEJIHDPKGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C87C20", Offset = "0x6C87020", VA = "0x186C87C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform LPDBOIBDMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E490", Offset = "0x6C8D890", VA = "0x186C8E490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform DJIGGNDJOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C82BD0", Offset = "0x6C81FD0", VA = "0x186C82BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer FILIOJAJFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C927F0", Offset = "0x6C91BF0", VA = "0x186C927F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] DENPJHKFGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B700", Offset = "0x6C8AB00", VA = "0x186C8B700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] JLDNIKCAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C82200", Offset = "0x6C81600", VA = "0x186C82200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator ODFLPBOOIDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C95CC0", Offset = "0x6C950C0", VA = "0x186C95CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK PNNEIIKGPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C91720", Offset = "0x6C90B20", VA = "0x186C91720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private OCFGMGFBNFD NAGEEMHOIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F480", Offset = "0x6C8E880", VA = "0x186C8F480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private OCFGMGFBNFD CKCBNLCFDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C85960", Offset = "0x6C84D60", VA = "0x186C85960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private OCFGMGFBNFD BBNMBJDBMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C96630", Offset = "0x6C95A30", VA = "0x186C96630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private OCFGMGFBNFD KNGMOBNADIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C93E00", Offset = "0x6C93200", VA = "0x186C93E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private OCFGMGFBNFD BBBJHGJNDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C89EB0", Offset = "0x6C892B0", VA = "0x186C89EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private OCFGMGFBNFD FGPGEEGOLJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6C8DD50", Offset = "0x6C8D150", VA = "0x186C8DD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private OCFGMGFBNFD KMOCKNJIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C88530", Offset = "0x6C87930", VA = "0x186C88530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private OCFGMGFBNFD PAGCJMNKEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C946C0", Offset = "0x6C93AC0", VA = "0x186C946C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CJCIOJDIDLI GNIKLDIKDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C8FFA0", Offset = "0x6C8F3A0", VA = "0x186C8FFA0", Slot = "15")]
		get
		{
			return default(CJCIOJDIDLI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public HOKJPOPDING LHHNKMACPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x921F30", Offset = "0x921330", VA = "0x180921F30", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public FHKAGHFDKOE LNOLJLEGIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x921E60", Offset = "0x921260", VA = "0x180921E60", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public OKJNLEKGHKB FPGFJAOPKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x921F50", Offset = "0x921350", VA = "0x180921F50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public OKJNLEKGHKB EFEPJDJPKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xDE6590", Offset = "0xDE5990", VA = "0x180DE6590", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string NIALBJBGCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform LBEHGEFNKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C83A30", Offset = "0x6C82E30", VA = "0x186C83A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform KFMHIEFJDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8A3B0", Offset = "0x6C897B0", VA = "0x186C8A3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform OPJMNHDBPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C925E0", Offset = "0x6C919E0", VA = "0x186C925E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool DOBFCLIAHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EC50", Offset = "0x6C8E050", VA = "0x186C8EC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform DBEMCBGOGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C85070", Offset = "0x6C84470", VA = "0x186C85070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject BCDDMHHPJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C89E10", Offset = "0x6C89210", VA = "0x186C89E10", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets CPDLICHMFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C98FD0", Offset = "0x6C983D0", VA = "0x186C98FD0", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform JOHDEJFIEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xDE5FC0", Offset = "0xDE53C0", VA = "0x180DE5FC0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform CNJDGOJLHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x187C0D0", Offset = "0x187B4D0", VA = "0x18187C0D0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform GEJPNOHFEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x187C280", Offset = "0x187B680", VA = "0x18187C280", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform HJDNGILDJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x15F7A00", Offset = "0x15F6E00", VA = "0x1815F7A00", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 OBGMDDLJHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C928F0", Offset = "0x6C91CF0", VA = "0x186C928F0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float KBNGAOKCAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C87BD0", Offset = "0x6C86FD0", VA = "0x186C87BD0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform NCONFIKLHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E8F0", Offset = "0x6C8DCF0", VA = "0x186C8E8F0", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform GJEOLPLBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1B83940", Offset = "0x1B82D40", VA = "0x181B83940", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform JPMEIOHKMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1B83A20", Offset = "0x1B82E20", VA = "0x181B83A20", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform MPDGLLKOIJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x15F85E0", Offset = "0x15F79E0", VA = "0x1815F85E0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool AIHGBMNHAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C82850", Offset = "0x6C81C50", VA = "0x186C82850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool POECKMMKABH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8FDC0", Offset = "0x6C8F1C0", VA = "0x186C8FDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool FAMHOOKALML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E410", Offset = "0x6C8D810", VA = "0x186C8E410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B900", Offset = "0x6C8AD00", VA = "0x186C8B900")]
	private void GMKBPDEPBEJ([In] DBGGFBFPGLA GLNEFNOFBPC, [In] AvatarFullBodyConfiguration HGDDFPIIMHP, bool OLEDNKMJJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C858D0", Offset = "0x6C84CD0", VA = "0x186C858D0")]
	private float DFPIKCBPKMB([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C99750", Offset = "0x6C98B50", VA = "0x186C99750")]
	private float PHBCKFKNDEH([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C85490", Offset = "0x6C84890", VA = "0x186C85490")]
	private void DCAAHGPPHNI(DBGGFBFPGLA GLNEFNOFBPC, AvatarFullBodyConfiguration HGDDFPIIMHP, bool OLEDNKMJJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C82300", Offset = "0x6C81700", VA = "0x186C82300")]
	private void ABOKKIHGJJD([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C91AE0", Offset = "0x6C90EE0", VA = "0x186C91AE0")]
	private void LHEJECGOPAG([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AEA0", Offset = "0x6C9A2A0", VA = "0x186C9AEA0")]
	public OJFBLECGCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C83150", Offset = "0x6C82550", VA = "0x186C83150", Slot = "12")]
	public void BCLJBHEKBCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C992C0", Offset = "0x6C986C0", VA = "0x186C992C0", Slot = "13")]
	public void PFNBEEBPCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C85A60", Offset = "0x6C84E60", VA = "0x186C85A60", Slot = "14")]
	public void DJNDCCMNFKN(bool NJHFCPHDEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6C95820", Offset = "0x6C94C20", VA = "0x186C95820", Slot = "25")]
	public Transform NNEKPCCFGBI(string BJANEOFJHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E590", Offset = "0x6C8D990", VA = "0x186C8E590", Slot = "26")]
	public Vector3? IODPBNKADGI(string BJANEOFJHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C87380", Offset = "0x6C86780", VA = "0x186C87380", Slot = "7")]
	public void EHNAGGEMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B800", Offset = "0x6C8AC00", VA = "0x186C8B800")]
	private void GKJLHDOKDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8A420", Offset = "0x6C89820", VA = "0x186C8A420", Slot = "6")]
	public void FPMADKNNDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E950", Offset = "0x6C8DD50", VA = "0x186C8E950", Slot = "8")]
	public void JCBBKJPBKMK(float APIOACIGING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8FF50", Offset = "0x6C8F350", VA = "0x186C8FF50")]
	private void KFNDEIOHHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C96AD0", Offset = "0x6C95ED0", VA = "0x186C96AD0", Slot = "4")]
	public void OHIIIEDBFNM(string PONIPAHEPEC, FKONMJCFGHH LCEBMJPOKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C86900", Offset = "0x6C85D00", VA = "0x186C86900", Slot = "5")]
	public void ECHJKHENBEA(CJCIOJDIDLI GMJMLMCNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C99F30", Offset = "0x6C99330", VA = "0x186C99F30", Slot = "11")]
	public void PMEDNGKAFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C824C0", Offset = "0x6C818C0", VA = "0x186C824C0", Slot = "24")]
	public void ADEKMJNNMOI([Out] Vector3 PJDACKDPNCF, [Out] Quaternion NBLNCIPHNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C91BE0", Offset = "0x6C90FE0", VA = "0x186C91BE0")]
	private void LODKIDNGBKJ([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C82950", Offset = "0x6C81D50", VA = "0x186C82950", Slot = "27")]
	public void AFJDBHAGLFB(float AKBDHFIOJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C8FA70", Offset = "0x6C8EE70", VA = "0x186C8FA70", Slot = "28")]
	public void JPCLDIEAMLJ(float NJDGCAEIHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DC10", Offset = "0x6C8D010", VA = "0x186C8DC10", Slot = "44")]
	public void HMMJCPBPEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C84F40", Offset = "0x6C84340", VA = "0x186C84F40", Slot = "29")]
	public void CFHKLPGOPPN(bool HCJEGOFACJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6C92CF0", Offset = "0x6C920F0", VA = "0x186C92CF0", Slot = "30")]
	public HandLogicOffsets MFECJJPJDPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C82960", Offset = "0x6C81D60", VA = "0x186C82960", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets AFLAJPGNJOP()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C85DC0", Offset = "0x6C851C0", VA = "0x186C85DC0")]
	private void EAPBOHOJPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C82CD0", Offset = "0x6C820D0", VA = "0x186C82CD0")]
	private void AKKCDOHLCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A040", Offset = "0x6C99440", VA = "0x186C9A040")]
	private void PMGCIHHIPIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C88150", Offset = "0x6C87550", VA = "0x186C88150")]
	private void FDPKMCFGNLG(AKFJEGODPDH GBEPDPCIABL, bool LCNIJLOJAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C912C0", Offset = "0x6C906C0", VA = "0x186C912C0")]
	private void KPPIGFHKCOM(AKFJEGODPDH GBEPDPCIABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C85D70", Offset = "0x6C85170", VA = "0x186C85D70")]
	public Vector3 DPKGDHAOGBA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C91820", Offset = "0x6C90C20", VA = "0x186C91820")]
	private void LGGAHDIHDBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A020", Offset = "0x6C99420", VA = "0x186C9A020")]
	private void PMFNBMPBIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C91C10", Offset = "0x6C91010", VA = "0x186C91C10")]
	private void LOIHFBJHPBH(DBGGFBFPGLA GLNEFNOFBPC, AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C93F80", Offset = "0x6C93380", VA = "0x186C93F80")]
	private float NFHCEEFKAKD([In] DBGGFBFPGLA NMAIGNOENJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C84F90", Offset = "0x6C84390", VA = "0x186C84F90")]
	private int CHJHFPCNENP([In] NBHCPMDJNIM BCAHMCIECHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C92F40", Offset = "0x6C92340", VA = "0x186C92F40")]
	private void MKKMDNJPNDK(DBGGFBFPGLA GLNEFNOFBPC, bool OEGFHBOPHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D3F0", Offset = "0x6C8C7F0", VA = "0x186C8D3F0")]
	private static void HBKGJHOOBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C94AF0", Offset = "0x6C93EF0", VA = "0x186C94AF0")]
	private static void NKPDEHKKPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D9F0", Offset = "0x6C8CDF0", VA = "0x186C8D9F0")]
	private float HJCKAKGFBJN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DE50", Offset = "0x6C8D250", VA = "0x186C8DE50")]
	private static int IGAABLDCPFK(OJFBLECGCCE OPJKGPJPNJJ, OJFBLECGCCE EANFIEEELEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C94130", Offset = "0x6C93530", VA = "0x186C94130", Slot = "40")]
	public DBGGFBFPGLA NGBGAGABHIC()
	{
		return default(DBGGFBFPGLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C87B90", Offset = "0x6C86F90", VA = "0x186C87B90")]
	public void EIHFHAFFDMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B4E0", Offset = "0x6C8A8E0", VA = "0x186C8B4E0")]
	private (bool, bool) GHEOAGKABFA()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C85B30", Offset = "0x6C84F30", VA = "0x186C85B30")]
	private (float, float) DLPJMNGMJGF([In] DBGGFBFPGLA NMAIGNOENJN)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C88630", Offset = "0x6C87A30", VA = "0x186C88630")]
	private void FKNKGGFKKMP([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C85170", Offset = "0x6C84570", VA = "0x186C85170")]
	private void DAMCPLCLFJL([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C85F20", Offset = "0x6C85320", VA = "0x186C85F20")]
	private void EAPJDCFLHJJ([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C86DC0", Offset = "0x6C861C0", VA = "0x186C86DC0")]
	private void EDDAIBJKDCI([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP, FootSettings AFHIEJIBLCI, bool CAFNIHKIAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C93F00", Offset = "0x6C93300", VA = "0x186C93F00")]
	private float NBKGFBLIFAG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C90790", Offset = "0x6C8FB90", VA = "0x186C90790")]
	private void KPDPGBCKELC(DBGGFBFPGLA NMAIGNOENJN, AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C83100", Offset = "0x6C82500", VA = "0x186C83100")]
	private float BCEJPKGGPBH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6C8F580", Offset = "0x6C8E980", VA = "0x186C8F580")]
	private void JNBPLDEGIIO([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C95970", Offset = "0x6C94D70", VA = "0x186C95970")]
	private void NOFOGNCALED([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E020", Offset = "0x6C8D420", VA = "0x186C8E020")]
	private void IIJAAEBKLLJ([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C91470", Offset = "0x6C90870", VA = "0x186C91470")]
	private void LEIJALGBJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A2B0", Offset = "0x6C996B0", VA = "0x186C9A2B0")]
	private void PPGGBCEAAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DE80", Offset = "0x6C8D280", VA = "0x186C8DE80")]
	private void IGCOHHMOFKC([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E9C0", Offset = "0x6C8DDC0", VA = "0x186C8E9C0")]
	private void JCHJMNNLOHI(NPCIKFLJJGC GACBINGCFHK, IKSolverVR.Arm FCJKJEKOEGF, Transform MGAKLJEHEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C92980", Offset = "0x6C91D80", VA = "0x186C92980")]
	private void MENPKHFJFDB(DBGGFBFPGLA NMAIGNOENJN, AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C84440", Offset = "0x6C83840", VA = "0x186C84440")]
	private void CBAGMIKGFMN(BBOEJMKNLKG DDNDJFLOKIE, OKJNLEKGHKB GACBINGCFHK, IKSolverVR.Arm FCJKJEKOEGF, float HOGDNIGNMHM, float AFOMDLMHFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6C93460", Offset = "0x6C92860", VA = "0x186C93460")]
	private void MLHNBHPBLIG([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D5F0", Offset = "0x6C8C9F0", VA = "0x186C8D5F0")]
	protected void HHGNCOMCFAF([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6C93B20", Offset = "0x6C92F20", VA = "0x186C93B20")]
	private void MOLFDAFONHN([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C83770", Offset = "0x6C82B70", VA = "0x186C83770")]
	protected void BEAKCIFGAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6C847C0", Offset = "0x6C83BC0", VA = "0x186C847C0")]
	private void CDOOAKNFBAH([In] DBGGFBFPGLA NMAIGNOENJN, [In] MFOKLHAMBNH FMEBPPELFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6C99D80", Offset = "0x6C99180", VA = "0x186C99D80")]
	private void PKCHBMPGONE(DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DBD0", Offset = "0x6C8CFD0", VA = "0x186C8DBD0")]
	private void HJHLGCNLAKI([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C98AC0", Offset = "0x6C97EC0", VA = "0x186C98AC0")]
	private Vector3 OLBJGDDLHDO([In] DBGGFBFPGLA NMAIGNOENJN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C85CA0", Offset = "0x6C850A0", VA = "0x186C85CA0")]
	private void DNJKKOEJANG([In] DBGGFBFPGLA NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6C94290", Offset = "0x6C93690", VA = "0x186C94290")]
	private float NJBKABOGCPH(float NHJEKJBCBEM, [In] DBGGFBFPGLA NMAIGNOENJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6C92D40", Offset = "0x6C92140", VA = "0x186C92D40")]
	private void MHIIICAFFJK(float NHJEKJBCBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6C87CB0", Offset = "0x6C870B0", VA = "0x186C87CB0")]
	private void ELEFNIBNLIL([In] DBGGFBFPGLA NMAIGNOENJN, MFOKLHAMBNH FMEBPPELFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6C900D0", Offset = "0x6C8F4D0", VA = "0x186C900D0")]
	private float KGAJECEMCPD([In] DBGGFBFPGLA GLNEFNOFBPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C997D0", Offset = "0x6C98BD0", VA = "0x186C997D0")]
	private void PKBLOCPPOGH(DBGGFBFPGLA NMAIGNOENJN, MFOKLHAMBNH FMEBPPELFAB, Vector3 KOJMCALKKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C84610", Offset = "0x6C83A10", VA = "0x186C84610")]
	private static void CCDCMNGEMIJ(Transform HGENDDPKHHK, Quaternion MDJOMEFJFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6C947C0", Offset = "0x6C93BC0", VA = "0x186C947C0")]
	private void NKNJNHAJNGE([In] DBGGFBFPGLA FPCPCDFPMLC, [In] NBHCPMDJNIM BCAHMCIECHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6C95DC0", Offset = "0x6C951C0", VA = "0x186C95DC0")]
	private void NPDGMCBKCOF([In] DBGGFBFPGLA FPCPCDFPMLC, [In] NBHCPMDJNIM BCAHMCIECHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6C82A20", Offset = "0x6C81E20", VA = "0x186C82A20")]
	private void AHEHENAEAHO(float GHNPPAAPPNL, [In] DBGGFBFPGLA GLNEFNOFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6C8ADA0", Offset = "0x6C8A1A0", VA = "0x186C8ADA0")]
	private float GBMGBDKOLPB([In] DBGGFBFPGLA GLNEFNOFBPC, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C99050", Offset = "0x6C98450", VA = "0x186C99050")]
	private void OLOKFGCHFDK([In] DBGGFBFPGLA GLNEFNOFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C8ECA0", Offset = "0x6C8E0A0", VA = "0x186C8ECA0")]
	private void JJCNHDJHELJ([In] DBGGFBFPGLA GLNEFNOFBPC, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6C96730", Offset = "0x6C95B30", VA = "0x186C96730")]
	private void OCLENKIGJEJ([In] DBGGFBFPGLA GLNEFNOFBPC, float GPEKDHLJGHE, float BAIGNGCPPDG, Vector3 LAEMHFDMNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6C83A80", Offset = "0x6C82E80", VA = "0x186C83A80")]
	private void BPAELFMONHB(DBGGFBFPGLA GLNEFNOFBPC, AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6C89FB0", Offset = "0x6C893B0", VA = "0x186C89FB0")]
	private void FNAEANLKCCA(DBGGFBFPGLA GLNEFNOFBPC, AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E720", Offset = "0x6C8DB20", VA = "0x186C8E720")]
	public void IPEAMLAMBDD([In] DBGGFBFPGLA NMAIGNOENJN, [In] AvatarFullBodyConfiguration HGDDFPIIMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C871E0", Offset = "0x6C865E0", VA = "0x186C871E0")]
	[CompilerGenerated]
	internal static void EHCIAAMGKEG(Transform CEMFCPJEKHI, IKSolverVR.Arm FCJKJEKOEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6C92E90", Offset = "0x6C92290", VA = "0x186C92E90")]
	[CompilerGenerated]
	internal static void MKAEIMJNMHP(Vector3 ALMLENNBNBL, Vector3 OCIKLLCIPEK, NEHMIADJHAA P_2, LBNFBLEDHID P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C92650", Offset = "0x6C91A50", VA = "0x186C92650")]
	[CompilerGenerated]
	internal static void MCMOAHJOKGF(DOIMENJFFIB FGLJDDMLENB, DOIMENJFFIB HBKLDODMABA, Vector3 KHLOEGPNEJP, float MEDJAOOGFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8FE40", Offset = "0x6C8F240", VA = "0x186C8FE40")]
	[CompilerGenerated]
	internal static bool KBBJPKMBDIC(IKSolverVR.Arm FCJKJEKOEGF, FCDMJNGGIIL GECMBAOCBBN, float BANHNLHDGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CFC0", Offset = "0x6C8C3C0", VA = "0x186C8CFC0")]
	[CompilerGenerated]
	internal static float GOABOOAANMO(Vector3 EKMPHLANHME, Vector3 DCOPJHLFEAC, Vector3 BJGCGNBMACP, DBGGFBFPGLA GLNEFNOFBPC, AvatarFullBodyConfiguration HGDDFPIIMHP, float OLMEFNCLGNG)
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
		public enum CHFIJMLIELP
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private CHFIJMLIELP handleType;

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

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C700", Offset = "0x6C9BB00", VA = "0x186C9C700")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C6C0", Offset = "0x6C9BAC0", VA = "0x186C9C6C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C0C0", Offset = "0x6C9B4C0", VA = "0x186C9C0C0")]
		private void HLCANFNLAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C44DB0", Offset = "0x6C441B0", VA = "0x186C44DB0", Slot = "4")]
		public void SetEnabled(bool BOCGODCJHIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C730", Offset = "0x6C9BB30", VA = "0x186C9C730")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AvatarKneeBendTargetController : MonoBehaviour, OCFGMGFBNFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
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
		private Vector3 IKGBDOMDBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Vector3 JOPDKPDIDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Vector3 BFDOIOLIMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Matrix4x4 GGMHECOOIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private bool FHAIGAGAFKG;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CBD0", Offset = "0x6C9BFD0", VA = "0x186C9CBD0", Slot = "4")]
		public void UpdateController(float KDDKBBMEFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CBC0", Offset = "0x6C9BFC0", VA = "0x186C9CBC0", Slot = "6")]
		public void SetEnabled(bool EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C760", Offset = "0x6C9BB60", VA = "0x186C9C760")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D290", Offset = "0x6C9C690", VA = "0x186C9D290")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, HNGHHJMOACL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[Header("Configuration")]
		private OJHEMGLCFCA avatarBodyType;

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
		[SerializeField]
		[AIBPGBFCHJI(OPJKPNFINLK.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[Header("Configuration")]
		[SerializeField]
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
		[Header("Watch")]
		[SerializeField]
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
		private KMAJMHNAMGE AKLFGNCKDEK;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public KMAJMHNAMGE GEMNBOEOGKH
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8FC980", Offset = "0x8FBD80", VA = "0x1808FC980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform DHCIFDGGJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6C9E120", Offset = "0x6C9D520", VA = "0x186C9E120", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D2A0", Offset = "0x6C9C6A0", VA = "0x186C9D2A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DFE0", Offset = "0x6C9D3E0", VA = "0x186C9DFE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DF90", Offset = "0x6C9D390", VA = "0x186C9DF90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DF20", Offset = "0x6C9D320", VA = "0x186C9DF20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D2A0", Offset = "0x6C9C6A0", VA = "0x186C9D2A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D720", Offset = "0x6C9CB20", VA = "0x186C9D720", Slot = "6")]
		public KMAJMHNAMGE CreateAvatarSystem(string PONIPAHEPEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6C9DF20", Offset = "0x6C9D320", VA = "0x186C9DF20", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D350", Offset = "0x6C9C750", VA = "0x186C9D350", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E030", Offset = "0x6C9D430", VA = "0x186C9E030", Slot = "9")]
		public void UpdatePostIKAnimControllers(float KDDKBBMEFBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class DKIGJLIIEDG : BMALLHJCHHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<string, KMAJMHNAMGE> JCCIBAKALII;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FB60", Offset = "0x6C9EF60", VA = "0x186C9FB60")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void JJOGKFJBOFF(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FBD0", Offset = "0x6C9EFD0", VA = "0x186C9FBD0", Slot = "4")]
	public KMAJMHNAMGE PBCDAGKDPDK(string NKEIOHDBDMI, AvatarSystemConfiguration GPIDEPIIFGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F970", Offset = "0x6C9ED70", VA = "0x186C9F970", Slot = "5")]
	public void FEOHNMLMGGF(string NKEIOHDBDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F830", Offset = "0x6C9EC30", VA = "0x186C9F830", Slot = "6")]
	public string DNACAAGCPLP(string IBDADMEEBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FAF0", Offset = "0x6C9EEF0", VA = "0x186C9FAF0")]
	private string IOMAPMCBDFO(string IBDADMEEBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9FDF0", Offset = "0x6C9F1F0", VA = "0x186C9FDF0")]
	public DKIGJLIIEDG()
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
		public class HLAOJMPDELB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private Dictionary<string, Transform> HDACAHDKHLO;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool HNBCNJGJEII
			{
				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x6CA12B0", Offset = "0x6CA06B0", VA = "0x186CA12B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x6CA12F0", Offset = "0x6CA06F0", VA = "0x186CA12F0")]
			public void FOHGLKMJJEG(VRIK HHPDDGFFPHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
			public void EPNKIOFKBPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6CA1420", Offset = "0x6CA0820", VA = "0x186CA1420")]
			public void PGLAGHNEHAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6CA1470", Offset = "0x6CA0870", VA = "0x186CA1470")]
			public HLAOJMPDELB()
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
		[MDLMPHLONML(OPJKPNFINLK.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[AIBPGBFCHJI(OPJKPNFINLK.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly HLAOJMPDELB OGMDEDBFBFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HNGHHJMOACL GHBGCAEDIFK;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E170", Offset = "0x6C9D570", VA = "0x186C9E170")]
		private void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E450", Offset = "0x6C9D850", VA = "0x186C9E450")]
		private bool GKGKHMFDMDJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E4A0", Offset = "0x6C9D8A0", VA = "0x186C9E4A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E510", Offset = "0x6C9D910", VA = "0x186C9E510")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E4B0", Offset = "0x6C9D8B0", VA = "0x186C9E4B0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6C9E780", Offset = "0x6C9DB80", VA = "0x186C9E780")]
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

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1570", Offset = "0x6CA0970", VA = "0x186CA1570")]
		public void IPNPHEKPPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1500", Offset = "0x6CA0900", VA = "0x186CA1500")]
		public int ANPOBCPLEBD(int FDGLJJBGDAC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6CA17D0", Offset = "0x6CA0BD0", VA = "0x186CA17D0")]
			public void IPNPHEKPPLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x6CA1690", Offset = "0x6CA0A90", VA = "0x186CA1690")]
			public (float, float) BFAKKBEILNK(Animator GGBDBJDKMKF, AnimatorStateInfo NNLKBEOLGAO)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA18B0", Offset = "0x6CA0CB0", VA = "0x186CA18B0")]
		public void IPNPHEKPPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1AA0", Offset = "0x6CA0EA0", VA = "0x186CA1AA0")]
		public (float, float) JOHIKPAOHHL(Animator GGBDBJDKMKF)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1CB0", Offset = "0x6CA10B0", VA = "0x186CA1CB0")]
		private (float, float) MGJJMALJEGH(Animator GGBDBJDKMKF, AnimatorStateInfo NNLKBEOLGAO)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1EA0", Offset = "0x6CA12A0", VA = "0x186CA1EA0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6CA49F0", Offset = "0x6CA3DF0", VA = "0x186CA49F0", Slot = "4")]
		public override void OnStateEnter(Animator GGBDBJDKMKF, AnimatorStateInfo NNLKBEOLGAO, int ONBIKNCKBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4B50", Offset = "0x6CA3F50", VA = "0x186CA4B50")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal abstract class LIFJOLKMKOH<TInput, TOutput> : FJLANEHODAC<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	protected readonly CFKANHJCJBB IMDPBFNLDEL;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x45B51D0", Offset = "0x45B45D0", VA = "0x1845B51D0")]
	protected LIFJOLKMKOH(CFKANHJCJBB IMDPBFNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput AJCCBGLJAMD(TInput EBJHHBADCKF, [Out] IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x45B5130", Offset = "0x45B4530", VA = "0x1845B5130", Slot = "5")]
	public bool NHJPMMNFDNI(TInput EBJHHBADCKF, [Out] TOutput? IPNDOKDOGDG, [Out] IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[JEGDMIPNMMJ]
public static class IAIPELFINIL
{
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly Regex MCJMBHAFNCF;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1EB0", Offset = "0x6CA12B0", VA = "0x186CA1EB0")]
	public static KPHGBMEHLAH AKPFIMNLBDP(KMLPKJNOABE PKPAINDLBBJ, MHELINGPEEM EMDPPAAKHEO, Guid? DFOFCJFKCNP, Color? NEEJLOIFMJD, IMEAMGPJJIG COCDOPPFGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA20C0", Offset = "0x6CA14C0", VA = "0x186CA20C0")]
	public static OGJHNDNNOJI FFBHHLEBDDF(KPHGBMEHLAH AIKOCCMKKAE)
	{
		return default(OGJHNDNNOJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2E88930", Offset = "0x2E87D30", VA = "0x182E88930")]
	internal static TModern? NGOHHDEJONJ<TModern>(string? EBJHHBADCKF, IMGPDDOFEAJ<TModern> BHPFBCFHAEK, CFKANHJCJBB IMDPBFNLDEL, BCDIICPGFKG JLDFLMCEBOL, TModern JCKKALFBNDF) where TModern : struct, JEBNHHNAHFI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2E88150", Offset = "0x2E87550", VA = "0x182E88150")]
	internal static FOCKAFCCMDA LPHDMJJPOOK<TModern>(string? EBJHHBADCKF, IMGPDDOFEAJ<TModern> BHPFBCFHAEK, CFKANHJCJBB IMDPBFNLDEL, BCDIICPGFKG JLDFLMCEBOL, TModern JCKKALFBNDF) where TModern : struct, JEBNHHNAHFI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2220", Offset = "0x6CA1620", VA = "0x186CA2220")]
	internal static List<FIOFGMBEDNB> ODOAFLOAFLH(IEnumerable<INFILHLGKJP>? IOIDPDPMEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2E872D0", Offset = "0x2E866D0", VA = "0x182E872D0")]
	internal static string JMLILKBHJHM<TModern>(TModern EBJHHBADCKF, IMGPDDOFEAJ<TModern> BHPFBCFHAEK, CFKANHJCJBB IMDPBFNLDEL) where TModern : JEBNHHNAHFI
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class PCFOKMKHOLA : BPHHIBAOOMD
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public FJLANEHODAC<INHFFNLLDDF, BFNDHBOFNNE> COOEIEKDDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public FJLANEHODAC<CIBGHHDGNPO, NFJNJHKNJNH> MGPACGNNPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FJLANEHODAC<CIBGHHDGNPO, NFJNJHKNJNH> AJOBFPOGANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public KGIHFFEHGML HDHNIODECEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public LKCMDLIBLJJ BIINGONOCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6CA64A0", Offset = "0x6CA58A0", VA = "0x186CA64A0")]
	[UsedImplicitly]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	internal static void ADEMPLHINMH(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6510", Offset = "0x6CA5910", VA = "0x186CA6510")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PCFOKMKHOLA([CCLHMIDBCEM("UnitySerialization")] AIECAPDCBCJ NGNLHMNOLFA, [CCLHMIDBCEM(null)] HBJEJEFHOOL MAOBDLMLMDP, [CCLHMIDBCEM(null)] CFKANHJCJBB IMDPBFNLDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum AHPLMFPJOGG
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
public class MLBPKBOHEHA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4950", Offset = "0x6CA3D50", VA = "0x186CA4950")]
	public MLBPKBOHEHA(string MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4920", Offset = "0x6CA3D20", VA = "0x186CA4920")]
	public MLBPKBOHEHA(string MOKGCFCFCPE, Exception GPPNMDMLEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA49C0", Offset = "0x6CA3DC0", VA = "0x186CA49C0")]
	public MLBPKBOHEHA(AHPLMFPJOGG EKDMJPGDAHA, string MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4980", Offset = "0x6CA3D80", VA = "0x186CA4980")]
	public MLBPKBOHEHA(AHPLMFPJOGG EKDMJPGDAHA, string MOKGCFCFCPE, Exception GPPNMDMLEIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal abstract class OMFPNBCBAHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly AIECAPDCBCJ NGNLHMNOLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	protected readonly HBJEJEFHOOL MAOBDLMLMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	protected readonly CFKANHJCJBB IMDPBFNLDEL;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F240", Offset = "0x6C9E640", VA = "0x186C9F240")]
	protected OMFPNBCBAHH(AIECAPDCBCJ NGNLHMNOLFA, HBJEJEFHOOL MAOBDLMLMDP, CFKANHJCJBB IMDPBFNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5090", Offset = "0x6CA4490", VA = "0x186CA5090")]
	protected string FAHJECBFOEH(BFNDHBOFNNE HKAHDMHKEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4EA0", Offset = "0x6CA42A0", VA = "0x186CA4EA0")]
	protected string BGCNHJKKNCB(BFNDHBOFNNE HKAHDMHKEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4B70", Offset = "0x6CA3F70", VA = "0x186CA4B70")]
	private AvatarOutfitSelectionData AKPFIMNLBDP(KPHGBMEHLAH KNHDGEPCBBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6360", Offset = "0x6CA5760", VA = "0x186CA6360")]
	private static AvatarCustomizationSettingsData.AnchorParams NIMELKGICND(FFMFOGNHMIP? KPJNCLNNBDL)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FJLANEHODAC<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput AJCCBGLJAMD(TInput EBJHHBADCKF, [Out] IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHJPMMNFDNI(TInput EBJHHBADCKF, [Out] TOutput? IPNDOKDOGDG, [Out] IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface BPHHIBAOOMD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	FJLANEHODAC<INHFFNLLDDF, BFNDHBOFNNE> COOEIEKDDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	FJLANEHODAC<CIBGHHDGNPO, NFJNJHKNJNH> AJOBFPOGANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	KGIHFFEHGML HDHNIODECEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal enum BCDIICPGFKG
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LKCMDLIBLJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KACNIPCKOKH IFDLICGNEEM(BFNDHBOFNNE AIKOCCMKKAE);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KGIHFFEHGML
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CIBGHHDGNPO IFDLICGNEEM(BFNDHBOFNNE AIKOCCMKKAE, int OFIAEKGDMFK, string? DDDHPCNFCEK, string? OCJLJNPJPKG, FLOAFIFFJHG NPFAKIKEAMF, List<FIOFGMBEDNB>? KOJLKIGKMGM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[JEGDMIPNMMJ]
internal class CNOCLHJOFFP : LIFJOLKMKOH<INHFFNLLDDF, BFNDHBOFNNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly HBJEJEFHOOL MAOBDLMLMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly PFKBDFJGAKP BCDMJHBNCMO;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F660", Offset = "0x6C9EA60", VA = "0x186C9F660")]
	public CNOCLHJOFFP(AIECAPDCBCJ NGNLHMNOLFA, HBJEJEFHOOL MAOBDLMLMDP, CFKANHJCJBB IMDPBFNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F3C0", Offset = "0x6C9E7C0", VA = "0x186C9F3C0", Slot = "6")]
	public override BFNDHBOFNNE AJCCBGLJAMD(INHFFNLLDDF EBJHHBADCKF, [Out] IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RecRoom.NoEngine.Common.Preserve]
internal class KGMBLOCOIFG : AIECAPDCBCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class ECHHOCDCOFC : JsonConverter<FOCKAFCCMDA>
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0D40", Offset = "0x6CA0140", VA = "0x186CA0D40", Slot = "9")]
		public override void WriteJson(JsonWriter HOKCJMCABPI, FOCKAFCCMDA? EEPLCHCGAIN, JsonSerializer GDOIAPFGEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0C20", Offset = "0x6CA0020", VA = "0x186CA0C20", Slot = "10")]
		public override FOCKAFCCMDA ReadJson(JsonReader GDCGEJPDKCM, Type EFFIANFFJNF, FOCKAFCCMDA? JDKGGKBILGD, bool DFPFNIOCFEK, JsonSerializer GDOIAPFGEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0DE0", Offset = "0x6CA01E0", VA = "0x186CA0DE0")]
		public ECHHOCDCOFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class JJNMBBGJCAL : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool GPCKNOIDJDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6CA27E0", Offset = "0x6CA1BE0", VA = "0x186CA27E0", Slot = "5")]
		public override object ReadJson(JsonReader GDCGEJPDKCM, Type EFFIANFFJNF, object? JDKGGKBILGD, JsonSerializer GDOIAPFGEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2400", Offset = "0x6CA1800", VA = "0x186CA2400", Slot = "6")]
		public override bool CanConvert(Type EFFIANFFJNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2840", Offset = "0x6CA1C40", VA = "0x186CA2840", Slot = "4")]
		public override void WriteJson(JsonWriter HOKCJMCABPI, object? EEPLCHCGAIN, JsonSerializer GDOIAPFGEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6CA25E0", Offset = "0x6CA19E0", VA = "0x186CA25E0")]
		private static bool DGFOLJPHJJK(object EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public JJNMBBGJCAL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly JsonSerializerSettings AOECAENFDDA;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2920", Offset = "0x6CA1D20", VA = "0x186CA2920")]
	internal KGMBLOCOIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8450", Offset = "0x2EE7850", VA = "0x182EE8450", Slot = "4")]
	public string CKGGBCCHLBA<T>(T FMAFBHGACNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2EE84B0", Offset = "0x2EE78B0", VA = "0x182EE84B0", Slot = "5")]
	public T KEPEKDCACMI<T>(string EEPLCHCGAIN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RecRoom.NoEngine.Common.Preserve]
internal class OBICHINPNAG : AIECAPDCBCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB390", Offset = "0x2FFA790", VA = "0x182FFB390", Slot = "4")]
	public string CKGGBCCHLBA<T>(T FMAFBHGACNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB410", Offset = "0x2FFA810", VA = "0x182FFB410", Slot = "5")]
	public T KEPEKDCACMI<T>(string EEPLCHCGAIN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public OBICHINPNAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[JEGDMIPNMMJ]
internal class PFKBDFJGAKP : LIFJOLKMKOH<CIBGHHDGNPO, NFJNJHKNJNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly AIECAPDCBCJ NGNLHMNOLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly HBJEJEFHOOL MAOBDLMLMDP;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8E60", Offset = "0x6CA8260", VA = "0x186CA8E60")]
	public PFKBDFJGAKP(AIECAPDCBCJ NGNLHMNOLFA, HBJEJEFHOOL MAOBDLMLMDP, CFKANHJCJBB IMDPBFNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6A70", Offset = "0x6CA5E70", VA = "0x186CA6A70", Slot = "6")]
	public override NFJNJHKNJNH AJCCBGLJAMD(CIBGHHDGNPO EBJHHBADCKF, [Out] IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8520", Offset = "0x6CA7920", VA = "0x186CA8520")]
	internal void KKKPOHENIEF(string CMHPPBDAHLE, BFNDHBOFNNE HKAHDMHKEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7F70", Offset = "0x6CA7370", VA = "0x186CA7F70")]
	public IEnumerable<KPHGBMEHLAH> FIKCJPGPLFM(string FNLEFLMANLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA72E0", Offset = "0x6CA66E0", VA = "0x186CA72E0")]
	private IEnumerable<KPHGBMEHLAH> CJAPMNHNPCO(string FNLEFLMANLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6E90", Offset = "0x6CA6290", VA = "0x186CA6E90")]
	internal IEnumerable<KPHGBMEHLAH> CDCAOIBHOEB(string FNLEFLMANLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8670", Offset = "0x6CA7A70", VA = "0x186CA8670")]
	private KPHGBMEHLAH NEBBPPHMFEL(AvatarOutfitSelectionData JBPACGOCIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6CA76F0", Offset = "0x6CA6AF0", VA = "0x186CA76F0")]
	private void FIJPJOPDCAP(AvatarCustomizationSettingsData DBOKHFFHGBI, BFNDHBOFNNE HKAHDMHKEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6CA89F0", Offset = "0x6CA7DF0", VA = "0x186CA89F0")]
	private KPHGBMEHLAH NEBBPPHMFEL(string BEOCGCOIJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8020", Offset = "0x6CA7420", VA = "0x186CA8020")]
	internal static (IMEAMGPJJIG, string, string) FLCNFMHKLIF(string BEOCGCOIJGG, CFKANHJCJBB IMDPBFNLDEL)
	{
		return default((IMEAMGPJJIG, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8320", Offset = "0x6CA7720", VA = "0x186CA8320")]
	private IBOGHKPHLPM? JABDAOOOKGO(string? GPJCGLBMIBA, Vector2 AIPIPEIGGHJ, float GOKIBDGGDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8D00", Offset = "0x6CA8100", VA = "0x186CA8D00")]
	private static FFMFOGNHMIP OMBMPBNAPOL(AvatarCustomizationSettingsData.AnchorParams DAOECKODFLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[JEGDMIPNMMJ]
internal class CFAFEALJBMP : OMFPNBCBAHH, LKCMDLIBLJJ
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F240", Offset = "0x6C9E640", VA = "0x186C9F240")]
	public CFAFEALJBMP(AIECAPDCBCJ NGNLHMNOLFA, HBJEJEFHOOL MAOBDLMLMDP, CFKANHJCJBB IMDPBFNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EE90", Offset = "0x6C9E290", VA = "0x186C9EE90", Slot = "4")]
	public KACNIPCKOKH IFDLICGNEEM(BFNDHBOFNNE AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6C9ED90", Offset = "0x6C9E190", VA = "0x186C9ED90")]
	private string BEGLPEOAODG(BFNDHBOFNNE HKAHDMHKEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EB50", Offset = "0x6C9DF50", VA = "0x186C9EB50")]
	private string BDPMDOIOPDJ(KPHGBMEHLAH KNHDGEPCBBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[JEGDMIPNMMJ]
internal class PHGBECFBLBD : LIFJOLKMKOH<CIBGHHDGNPO, NFJNJHKNJNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly AIECAPDCBCJ NGNLHMNOLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly FJLANEHODAC<CIBGHHDGNPO, NFJNJHKNJNH> AFHNMHGCBNN;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6CA93D0", Offset = "0x6CA87D0", VA = "0x186CA93D0")]
	public PHGBECFBLBD(FJLANEHODAC<CIBGHHDGNPO, NFJNJHKNJNH> AFHNMHGCBNN, CFKANHJCJBB IMDPBFNLDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8FA0", Offset = "0x6CA83A0", VA = "0x186CA8FA0", Slot = "6")]
	public override NFJNJHKNJNH AJCCBGLJAMD(CIBGHHDGNPO EBJHHBADCKF, [Out] IReadOnlyList<FIOFGMBEDNB>? KOJLKIGKMGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[JEGDMIPNMMJ]
internal class FPOBHMKEJJN : KGIHFFEHGML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly AIECAPDCBCJ NGNLHMNOLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly LKCMDLIBLJJ MLCLFNIDCML;

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6CA11C0", Offset = "0x6CA05C0", VA = "0x186CA11C0")]
	public FPOBHMKEJJN(LKCMDLIBLJJ MLCLFNIDCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0E20", Offset = "0x6CA0220", VA = "0x186CA0E20", Slot = "4")]
	public CIBGHHDGNPO IFDLICGNEEM(BFNDHBOFNNE AIKOCCMKKAE, int OFIAEKGDMFK, string? DDDHPCNFCEK, string? OCJLJNPJPKG, FLOAFIFFJHG NPFAKIKEAMF, List<FIOFGMBEDNB>? KOJLKIGKMGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RecRoom.NoEngine.Common.Preserve]
internal class MCENNPJHENF : NBOFHJGIADK
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 FLHPIOABNGE;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 JFKNPNEKPOB;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly Vector2 AKMLNBJLBOO;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly Vector2 PDFKPDNIBOH;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static readonly Vector2 CEFAHKGLMHL;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static readonly Vector2 HGMJPKJOENG;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static readonly Vector2 GLBBCGIGBFN;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly Vector2 DAPFNGMFNNO;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static readonly Vector2 OMOPKJOBKFA;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly Vector2 PFABDFNGJJI;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private static readonly Vector2 KLLKDOAFGCO;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly Vector2 CEFMDPLDNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Dictionary<OJHEMGLCFCA, AvatarConfiguration> AKNFJCCDLNP;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6CA35E0", Offset = "0x6CA29E0", VA = "0x186CA35E0")]
	[OAJAKDHKADM.LHNCMMKCKFL]
	internal static void FEHLMOFHDJL(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4870", Offset = "0x6CA3C70", VA = "0x186CA4870")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MCENNPJHENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA42D0", Offset = "0x6CA36D0", VA = "0x186CA42D0", Slot = "4")]
	public Vector2 NBLCENELJHJ(FaceFeatureType IAOGKLDOLJN, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3490", Offset = "0x6CA2890", VA = "0x186CA3490", Slot = "5")]
	public float ELEIKDEOEJO(FaceFeatureType IAOGKLDOLJN, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4020", Offset = "0x6CA3420", VA = "0x186CA4020", Slot = "6")]
	public void LIKPMMKHFNK(OJHEMGLCFCA OFELOJDHFHP, AvatarConfiguration GPIDEPIIFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3D50", Offset = "0x6CA3150", VA = "0x186CA3D50", Slot = "7")]
	public void KJNKIELPMNB(LEJLBGPEGEO NMJLMAFGBOH, AvatarConfiguration EAJGEMFMPPA, OJHEMGLCFCA LKBBMGAGBGE, OJHEMGLCFCA OGMPMGIMOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3880", Offset = "0x6CA2C80", VA = "0x186CA3880", Slot = "8")]
	public float HLJJBOPMNLK(FaceFeatureType FMEOGNKJNMN, float IFPEIOCFBIE, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4110", Offset = "0x6CA3510", VA = "0x186CA4110", Slot = "9")]
	public float LOOAJOFMACM(FaceFeatureType FMEOGNKJNMN, float GOKIBDGGDIJ, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2A80", Offset = "0x6CA1E80", VA = "0x186CA2A80", Slot = "11")]
	public Vector2 AABAGCPHHHA(FaceFeatureType FMEOGNKJNMN, Vector2 NIPNLAEFABE, Vector2 MNOJOFFNMEH, Vector2 FHPANMAKFLE, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3E00", Offset = "0x6CA3200", VA = "0x186CA3E00", Slot = "10")]
	public Vector2 LBBFMGJPJIC(FaceFeatureType FMEOGNKJNMN, Vector2 HEILLAOEIGM, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2C30", Offset = "0x6CA2030", VA = "0x186CA2C30")]
	private Vector2 AGAABIILMCB(FaceFeatureType FMEOGNKJNMN, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3650", Offset = "0x6CA2A50", VA = "0x186CA3650")]
	private Vector2 FIIKPNLIHIE(FaceFeatureType FMEOGNKJNMN, Vector2 NIPNLAEFABE, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2E50", Offset = "0x6CA2250", VA = "0x186CA2E50", Slot = "12")]
	public Vector2 CGKFOEAJALJ(FaceFeatureType FMEOGNKJNMN, Vector2 HEILLAOEIGM, Vector2 MNOJOFFNMEH, Vector2 FHPANMAKFLE, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA39E0", Offset = "0x6CA2DE0", VA = "0x186CA39E0", Slot = "13")]
	public float JNIBEEMFAGG(FaceFeatureType FMEOGNKJNMN, float GOKIBDGGDIJ, OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3BF0", Offset = "0x6CA2FF0", VA = "0x186CA3BF0")]
	private float KCANMKDAOBC(float DBFICLBOEFG, float EGCLLCBPEBE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4250", Offset = "0x6CA3650", VA = "0x186CA4250")]
	private Vector2 MNEMPLKBKOA(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4090", Offset = "0x6CA3490", VA = "0x186CA4090")]
	private Vector2 LOFNGBENMBA(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3390", Offset = "0x6CA2790", VA = "0x186CA3390")]
	private Vector2 DLIGECFOHDM(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3410", Offset = "0x6CA2810", VA = "0x186CA3410")]
	private Vector2 DMGJMMNOMEM(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4140", Offset = "0x6CA3540", VA = "0x186CA4140")]
	private float MIOPPNDFMCJ(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA38F0", Offset = "0x6CA2CF0", VA = "0x186CA38F0")]
	private float IOBFGKKNPJL(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA38B0", Offset = "0x6CA2CB0", VA = "0x186CA38B0")]
	private float IKGFMFMILEJ(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3BB0", Offset = "0x6CA2FB0", VA = "0x186CA3BB0")]
	private float JNLAHAEFBMP(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA31F0", Offset = "0x6CA25F0", VA = "0x186CA31F0")]
	private Vector2 CLLDOLBKLCM(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3C80", Offset = "0x6CA3080", VA = "0x186CA3C80")]
	private Vector2 KFHPIICAJLE(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4180", Offset = "0x6CA3580", VA = "0x186CA4180")]
	private Vector2 MKNMHGBOEFI(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA37B0", Offset = "0x6CA2BB0", VA = "0x186CA37B0")]
	private Vector2 HHMHNJDMCPG(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2CD0", Offset = "0x6CA20D0", VA = "0x186CA2CD0")]
	private Vector2 APHEBNDFKLP(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3510", Offset = "0x6CA2910", VA = "0x186CA3510")]
	private Vector2 FBKBDBJGJOL(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4440", Offset = "0x6CA3840", VA = "0x186CA4440")]
	private Vector2 OBMJJOOKGLM(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA32C0", Offset = "0x6CA26C0", VA = "0x186CA32C0")]
	private Vector2 CNFPGCBPBFK(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA45C0", Offset = "0x6CA39C0", VA = "0x186CA45C0")]
	private Vector2 PGMKOINOJGO(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2DA0", Offset = "0x6CA21A0", VA = "0x186CA2DA0")]
	private Vector2 BBBJGAMFOEE(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3930", Offset = "0x6CA2D30", VA = "0x186CA3930")]
	private Vector2 IPFBHJOHNEF(OJHEMGLCFCA OFELOJDHFHP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4510", Offset = "0x6CA3910", VA = "0x186CA4510")]
	private Vector2 PGJPHGHOAIC(OJHEMGLCFCA OFELOJDHFHP)
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

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C9B7B0", Offset = "0x6C9ABB0", VA = "0x186C9B7B0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BJIGGOEMOMC
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E860", Offset = "0x6C9DC60", VA = "0x186C9E860")]
	public static OGJHNDNNOJI AJCCBGLJAMD(this JNFFMKBKJOO AIKOCCMKKAE)
	{
		return default(OGJHNDNNOJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E9D0", Offset = "0x6C9DDD0", VA = "0x186C9E9D0")]
	public static JNFFMKBKJOO IFDLICGNEEM(this OGJHNDNNOJI GCPKONFPIMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EAF0", Offset = "0x6C9DEF0", VA = "0x186C9EAF0")]
	public static bool NHBIIHNLKEJ(this OGJHNDNNOJI GCPKONFPIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E970", Offset = "0x6C9DD70", VA = "0x186C9E970")]
	public static bool GDFAHODPBLG(this OGJHNDNNOJI GCPKONFPIMO)
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

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x5085F80", Offset = "0x5085380", VA = "0x185085F80")]
			public AnchorParams(Vector2 NIPNLAEFABE, Vector3 JCFABLPPFLM, Vector3 FGBJCAIMNDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6C9B700", Offset = "0x6C9AB00", VA = "0x186C9B700")]
			internal FFMFOGNHMIP IFDLICGNEEM()
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
		private HJOHJJLAMOD useHelmetHair;

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
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6C9BFA0", Offset = "0x6C9B3A0", VA = "0x186C9BFA0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3B7CF80", Offset = "0x3B7C380", VA = "0x183B7CF80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9A2B50", Offset = "0x9A1F50", VA = "0x1809A2B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA330C0", Offset = "0xA324C0", VA = "0x180A330C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xCBCF00", Offset = "0xCBC300", VA = "0x180CBCF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD00", Offset = "0x8AA100", VA = "0x1808AAD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6C9C040", Offset = "0x6C9B440", VA = "0x186C9C040")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA50", Offset = "0x8ACE50", VA = "0x1808ADA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xB47480", Offset = "0xB46880", VA = "0x180B47480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x138A840", Offset = "0x1389C40", VA = "0x18138A840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB70", Offset = "0x8AEF70", VA = "0x1808AFB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6C9C080", Offset = "0x6C9B480", VA = "0x186C9C080")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9850E0", Offset = "0x9844E0", VA = "0x1809850E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xB84CC0", Offset = "0xB840C0", VA = "0x180B84CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1167140", Offset = "0x1166540", VA = "0x181167140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8ACB10", Offset = "0x8ABF10", VA = "0x1808ACB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8ACB40", Offset = "0x8ABF40", VA = "0x1808ACB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x44CBA20", Offset = "0x44CAE20", VA = "0x1844CBA20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9B7630", Offset = "0x9B6A30", VA = "0x1809B7630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8E02E0", Offset = "0x8DF6E0", VA = "0x1808E02E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8E0340", Offset = "0x8DF740", VA = "0x1808E0340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCC0", Offset = "0x8AF0C0", VA = "0x1808AFCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD20", Offset = "0x8AF120", VA = "0x1808AFD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC60", Offset = "0x8AF060", VA = "0x1808AFC60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8AFBF0", Offset = "0x8AEFF0", VA = "0x1808AFBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC80", Offset = "0x8AF080", VA = "0x1808AFC80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB50", Offset = "0x8AEF50", VA = "0x1808AFB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA730C0", Offset = "0xA724C0", VA = "0x180A730C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xDCE380", Offset = "0xDCD780", VA = "0x180DCE380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC70", Offset = "0x8AF070", VA = "0x1808AFC70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCA0", Offset = "0x8AF0A0", VA = "0x1808AFCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9B5880", Offset = "0x9B4C80", VA = "0x1809B5880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9B0D00", Offset = "0x9B0100", VA = "0x1809B0D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x8B2320", Offset = "0x8B1720", VA = "0x1808B2320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8B2360", Offset = "0x8B1760", VA = "0x1808B2360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x9258E0", Offset = "0x924CE0", VA = "0x1809258E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B5420", Offset = "0x9B4820", VA = "0x1809B5420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xCC0E90", Offset = "0xCC0290", VA = "0x180CC0E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xFE1940", Offset = "0xFE0D40", VA = "0x180FE1940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public HJOHJJLAMOD UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA37900", Offset = "0xA36D00", VA = "0x180A37900")]
			get
			{
				return default(HJOHJJLAMOD);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA37250", Offset = "0xA36650", VA = "0x180A37250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xA386C0", Offset = "0xA37AC0", VA = "0x180A386C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA38630", Offset = "0xA37A30", VA = "0x180A38630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6C9C060", Offset = "0x6C9B460", VA = "0x186C9C060")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x6C9C0A0", Offset = "0x6C9B4A0", VA = "0x186C9C0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C9BC40", Offset = "0x6C9B040", VA = "0x186C9BC40")]
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

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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
		public IMEAMGPJJIG BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private ECPOMHDNIMA? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x6C9E140", Offset = "0x6C9D540", VA = "0x186C9E140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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
