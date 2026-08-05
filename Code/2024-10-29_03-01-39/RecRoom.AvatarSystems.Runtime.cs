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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D711C0", Offset = "0x6D701C0", VA = "0x186D711C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D72580", Offset = "0x6D71580", VA = "0x186D72580", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PGJOKJDJLNC]
internal class IPPDAAFMLBL : KCJFCDDMEHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BJOPJMFAFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public IPPDAAFMLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public HEGHLNFMEGC avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HEMCAKFHAIM HIKJGJPLEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MJICKBLGHGD KDMKFBJEANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OOGLHFNPIHJ CIDGOCFBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KCIEGBAKIPC PDCNBODCNIA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E930", Offset = "0x6D6D930", VA = "0x186D6E930")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	[UsedImplicitly]
	internal static void GINBDFFNHCF(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D70200", Offset = "0x6D6F200", VA = "0x186D70200")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IPPDAAFMLBL([GAHPILLNNBL(null)] HEMCAKFHAIM HIKJGJPLEPO, [GAHPILLNNBL(null)] MJICKBLGHGD KDMKFBJEANB, [GAHPILLNNBL(null)] OOGLHFNPIHJ CIDGOCFBCOO, [GAHPILLNNBL(null)] KCIEGBAKIPC PDCNBODCNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EB40", Offset = "0x6D6DB40", VA = "0x186D6EB40", Slot = "5")]
	public LGAKPDPMGDK IHCHPMBGODG(HEGHLNFMEGC KJFGNCHICJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F830", Offset = "0x6D6E830", VA = "0x186D6F830", Slot = "4")]
	public LGAKPDPMGDK NLPLGKOHCKK(HEGHLNFMEGC KJFGNCHICJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EA30", Offset = "0x6D6DA30", VA = "0x186D6EA30", Slot = "6")]
	public LFOFAMIMPJP GNEDLOJFBML(LGAKPDPMGDK CONAFKKIHKL, int GHANGMDGLPB, string? DMCFPOLFNCF, string? FCFKBAJONJM, AJFAECAAJNI KHAKAAGNHOM, List<AILCDLDOFAP>? HEJIMNMCIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E9A0", Offset = "0x6D6D9A0", VA = "0x186D6E9A0", Slot = "7")]
	public bool GJGOAMBPLNM(DGKJPCCGNNH ELAGLJPBCJK, [Out] LGAKPDPMGDK? HKJLEANLJDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E850", Offset = "0x6D6D850", VA = "0x186D6E850", Slot = "8")]
	public bool AHMJNHAMDKF(LFOFAMIMPJP KEPEIGJAGFN, [Out] LGAKPDPMGDK? HKJLEANLJDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F7A0", Offset = "0x6D6E7A0", VA = "0x186D6F7A0", Slot = "9")]
	public bool LBBJLKDNPKG(LFOFAMIMPJP KEPEIGJAGFN, [Out] HACPMBHDCOE? ELAGLJPBCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2FECEB0", Offset = "0x2FEBEB0", VA = "0x182FECEB0")]
	private bool FFFNMAIDGAI<TInput, TOutput>(TInput EDAMLOGMMEK, IBDJHFEJNEB<TInput, TOutput> OFCPGDIAFPM, [Out] TOutput? POCKBMKNJHC) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F310", Offset = "0x6D6E310", VA = "0x186D6F310")]
	[CompilerGenerated]
	private BBPLMAEHHAO JDPACIGDHDB(FaceFeatureType DCLELGLJONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F4C0", Offset = "0x6D6E4C0", VA = "0x186D6F4C0")]
	[CompilerGenerated]
	private BBPLMAEHHAO KALCMOLIFEI(FaceFeatureType DCLELGLJONB, BJOPJMFAFFC P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[PGJOKJDJLNC]
internal class PLPLEPDLMFI : HEMCAKFHAIM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void NKEKFKLHDCP<in TData>(TData HKJLEANLJDA, IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OOGLHFNPIHJ CIDGOCFBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NAAEIEAKGMH AGNAOKAOOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NKEKFKLHDCP<LGAKPDPMGDK>?[] HIKJGJPLEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NKEKFKLHDCP<HACPMBHDCOE>?[] DKIEKJJKLLF;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D714A0", Offset = "0x6D704A0", VA = "0x186D714A0")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	[UsedImplicitly]
	internal static void GINBDFFNHCF(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D721D0", Offset = "0x6D711D0", VA = "0x186D721D0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PLPLEPDLMFI([GAHPILLNNBL(null)] OOGLHFNPIHJ CIDGOCFBCOO, [GAHPILLNNBL(null)] NAAEIEAKGMH AGNAOKAOOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D713A0", Offset = "0x6D703A0", VA = "0x186D713A0", Slot = "4")]
	public bool EOPCOJMGDAM(LGAKPDPMGDK HKJLEANLJDA, IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D71240", Offset = "0x6D70240", VA = "0x186D71240", Slot = "5")]
	public bool EOPCOJMGDAM(HACPMBHDCOE ELAGLJPBCJK, IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D71510", Offset = "0x6D70510", VA = "0x186D71510")]
	private void HABFMIGIFGD(LGAKPDPMGDK HKJLEANLJDA, IReadOnlyList<AILCDLDOFAP>? BEELICCCBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D71F70", Offset = "0x6D70F70", VA = "0x186D71F70")]
	private void KEPMODDDCGE(LGAKPDPMGDK HKJLEANLJDA, IReadOnlyList<AILCDLDOFAP>? BEELICCCBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D71F40", Offset = "0x6D70F40", VA = "0x186D71F40")]
	private void HONENPEIIPP(LGAKPDPMGDK HKJLEANLJDA, IReadOnlyList<AILCDLDOFAP>? BEELICCCBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D721A0", Offset = "0x6D711A0", VA = "0x186D721A0")]
	private void OFLJCCPMBMF(LGAKPDPMGDK HKJLEANLJDA, IReadOnlyList<AILCDLDOFAP>? BEELICCCBAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HEMCAKFHAIM
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOPCOJMGDAM(LGAKPDPMGDK HKJLEANLJDA, IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EOPCOJMGDAM(HACPMBHDCOE ELAGLJPBCJK, IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI);
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
		public DOCMDIBFMFN AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6D52440", Offset = "0x6D51440", VA = "0x186D52440")]
		public void OOCKFDPIOGK(AnimationPoseSetting DFABCHNPEEM, float ACKDAJABPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D52570", Offset = "0x6D51570", VA = "0x186D52570")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendHelperController : MonoBehaviour, HEIFOMILKAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
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
		private Vector3? NNFDPCLOPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool PHACGPOCJPH;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D52590", Offset = "0x6D51590", VA = "0x186D52590", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D52B70", Offset = "0x6D51B70", VA = "0x186D52B70", Slot = "4")]
		public void UpdateController(float MLPBAIIBHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1260810", Offset = "0x125F810", VA = "0x181260810", Slot = "6")]
		public void SetEnabled(bool BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D52630", Offset = "0x6D51630", VA = "0x186D52630")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D53000", Offset = "0x6D52000", VA = "0x186D53000")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarElbowBendTargetController : MonoBehaviour, HEIFOMILKAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float NBGNLNCAJFG = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
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
		private Vector3 IDHICBIKEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 JOAMEMPCJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool PHACGPOCJPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float IJNNGDPHMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float DLFKLONNMCC;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D53380", Offset = "0x6D52380", VA = "0x186D53380", Slot = "4")]
		public void UpdateController(float MLPBAIIBHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD23D00", Offset = "0xD22D00", VA = "0x180D23D00", Slot = "6")]
		public void SetEnabled(bool BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D530A0", Offset = "0x6D520A0", VA = "0x186D530A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D53E40", Offset = "0x6D52E40", VA = "0x186D53E40")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x6D54740", Offset = "0x6D53740", VA = "0x186D54740")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D54700", Offset = "0x6D53700", VA = "0x186D54700")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D53E70", Offset = "0x6D52E70", VA = "0x186D53E70")]
		private void OPLFPHGJCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C030", Offset = "0x6D1B030", VA = "0x186D1C030", Slot = "4")]
		public void SetEnabled(bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6D54770", Offset = "0x6D53770", VA = "0x186D54770")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarForearmRollController : MonoBehaviour, HEIFOMILKAA
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
		private float IJNNGDPHMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool PHACGPOCJPH;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D547B0", Offset = "0x6D537B0", VA = "0x186D547B0", Slot = "4")]
		public void UpdateController(float MLPBAIIBHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x11EB6B0", Offset = "0x11EA6B0", VA = "0x1811EB6B0", Slot = "6")]
		public void SetEnabled(bool BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6D55230", Offset = "0x6D54230", VA = "0x186D55230")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D55260", Offset = "0x6D54260", VA = "0x186D55260")]
		public AnimationPoseSetting AOHBEDGAJHJ(DOCMDIBFMFN AJCBNKELGNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6D55290", Offset = "0x6D54290", VA = "0x186D55290")]
		public void BCCFFCEEHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D552D0", Offset = "0x6D542D0", VA = "0x186D552D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6E810", Offset = "0x6D6D810", VA = "0x186D6E810")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LGPCGPPOBBD : PFOGADOEGMB
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int EDFPFNEGLHN;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int MGBAIAAAIJM;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int OAGCPJDGNJM;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int JOFFPBODDPA;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int KDIJAACIGOO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int LKBOAIFILEN;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int KBGMCHDJFEK;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int[] FJGCNNFGNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private HAAGELDNEFG IPMGGDKMPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private AKLLHGNFJLD PGHIPJPAAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int FMMKKPENGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private float CEDOCMLLCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator BHOCEFHOMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private AvatarFullBodyConfiguration CJOFBDOBIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int GMHEAGPIMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int MDELNIJFLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int BBPCHLHFFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool HPGNPNIOAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MOGPEEFLIPO HOLGNEIJJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int OJMGJFGEEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private float LJKNKMMIHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private HandDisplaySettings KLPHFOOECPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private HEGHLNFMEGC LDAPNIKHAIA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform CCPLPAFAHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 OKDGPNDBLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x11D0DD0", Offset = "0x11CFDD0", VA = "0x1811D0DD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x11D0ED0", Offset = "0x11CFED0", VA = "0x1811D0ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion AEGPHLPGEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98E610", Offset = "0x98D610", VA = "0x18098E610")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x22748A0", Offset = "0x22738A0", VA = "0x1822748A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool FPALGAFBLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D70AC0", Offset = "0x6D6FAC0", VA = "0x186D70AC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D70A30", Offset = "0x6D6FA30", VA = "0x186D70A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 MJIIPELFKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xFD3C80", Offset = "0xFD2C80", VA = "0x180FD3C80", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xFD2F80", Offset = "0xFD1F80", VA = "0x180FD2F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion MLPNJCICFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC97C80", Offset = "0xC96C80", VA = "0x180C97C80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFD2840", Offset = "0xFD1840", VA = "0x180FD2840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NPCCGMLEOLA KLBLBMJAHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x93DED0", Offset = "0x93CED0", VA = "0x18093DED0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(NPCCGMLEOLA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xB48440", Offset = "0xB47440", VA = "0x180B48440", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NPCCGMLEOLA OMCNENKEHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x16A2380", Offset = "0x16A1380", VA = "0x1816A2380", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(NPCCGMLEOLA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1E9A2B0", Offset = "0x1E992B0", VA = "0x181E9A2B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float FJOBOGOFCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x19087B0", Offset = "0x19077B0", VA = "0x1819087B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB48510", Offset = "0xB47510", VA = "0x180B48510", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LNNMBHHLDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D70AB0", Offset = "0x6D6FAB0", VA = "0x186D70AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OLGCCDPNGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D70430", Offset = "0x6D6F430", VA = "0x186D70430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool IEEBFAPBFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D70A90", Offset = "0x6D6FA90", VA = "0x186D70A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GILBLJILIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6D70C60", Offset = "0x6D6FC60", VA = "0x186D70C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6D704D0", Offset = "0x6D6F4D0", VA = "0x186D704D0", Slot = "21")]
	public void CPDDJGLEDNE(HAAGELDNEFG GKBGGLNDHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D70E30", Offset = "0x6D6FE30", VA = "0x186D70E30")]
	public void NIOJBJEPPLB(AKLLHGNFJLD GKOLKKOLLLK, HandDisplaySettings FJIDNEHJBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6D70440", Offset = "0x6D6F440", VA = "0x186D70440", Slot = "12")]
	public void CFNJNKECJND(bool EJMENMMDJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D70700", Offset = "0x6D6F700", VA = "0x186D70700", Slot = "11")]
	public void DMAGOJPACOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D70C70", Offset = "0x6D6FC70", VA = "0x186D70C70")]
	private int NEBLJKJNGNC(NPCCGMLEOLA EMECOBOHCNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D70B10", Offset = "0x6D6FB10", VA = "0x186D70B10")]
	private void JIGNKFHKFJF(int FNNFJMHLELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D70A70", Offset = "0x6D6FA70", VA = "0x186D70A70", Slot = "13")]
	public bool GMHACEHOCBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D70AA0", Offset = "0x6D6FAA0", VA = "0x186D70AA0", Slot = "14")]
	public bool HKPEEGJICOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D70E80", Offset = "0x6D6FE80", VA = "0x186D70E80")]
	private NPCCGMLEOLA OFGAJBCFBBP()
	{
		return default(NPCCGMLEOLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xB12070", Offset = "0xB11070", VA = "0x180B12070", Slot = "15")]
	public void DLHDNIGNFAN(bool EJMENMMDJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D703F0", Offset = "0x6D6F3F0", VA = "0x186D703F0", Slot = "10")]
	public void BOFKPEOIBAI(int FNNFJMHLELK, float DMCMGIBMJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D70AF0", Offset = "0x6D6FAF0", VA = "0x186D70AF0", Slot = "8")]
	public void IIMMKHCMHNL(MOGPEEFLIPO LNHGKEAKACI, bool PHLFEEMONCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D70A60", Offset = "0x6D6FA60", VA = "0x186D70A60", Slot = "9")]
	public void GCHFNKACCKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D70ED0", Offset = "0x6D6FED0", VA = "0x186D70ED0", Slot = "16")]
	public void PDJCECANDJL(Transform JNLBEALAMNB, Vector3 BBHPNIDGLLI, Quaternion LCFPEBKAHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D711B0", Offset = "0x6D701B0", VA = "0x186D711B0")]
	public LGPCGPPOBBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BIGOLBIKDLN : ENBELBPGKHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class GEMBECIJGPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3 LIHDOLEEGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Quaternion JFPDOKOICEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 EEPPPOHLAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Transform LKAILNMMOJA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 EPAFILACCLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x1937220", Offset = "0x1936220", VA = "0x181937220")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1937240", Offset = "0x1936240", VA = "0x181937240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion ECKPNIIGDFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xF0B400", Offset = "0xF0A400", VA = "0x180F0B400")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xF0B410", Offset = "0xF0A410", VA = "0x180F0B410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float LELAACBJJDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xC97D00", Offset = "0xC96D00", VA = "0x180C97D00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1275510", Offset = "0x1274510", VA = "0x181275510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool MEAMACHBMNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E80", Offset = "0x8B8E80", VA = "0x1808B9E80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8BA070", Offset = "0x8B9070", VA = "0x1808BA070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool FOCLMBDOOLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BA090", Offset = "0x8B9090", VA = "0x1808BA090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8BA060", Offset = "0x8B9060", VA = "0x1808BA060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool IAJCDLMHLPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E40", Offset = "0x8B8E40", VA = "0x1808B9E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E30", Offset = "0x8B8E30", VA = "0x1808B9E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float IGGMLKFFDME
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xC97D20", Offset = "0xC96D20", VA = "0x180C97D20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x28C9E50", Offset = "0x28C8E50", VA = "0x1828C9E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6D797A0", Offset = "0x6D787A0", VA = "0x186D797A0")]
		public void OHCDCIFDFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D79680", Offset = "0x6D78680", VA = "0x186D79680")]
		public void JAEGFKHLFCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D79320", Offset = "0x6D78320", VA = "0x186D79320")]
		public float DNMHPJGJMGA(Vector3 JBJJEFGLPGN, Quaternion OOGCALMFJAE, [In] FootSettings EEFEBENEEBB, float APLGDEKCLIE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D797B0", Offset = "0x6D787B0", VA = "0x186D797B0")]
		public void PHOFDPLKDBE(Vector3 LBIEFFGAJND, Quaternion BMEJFOICNHE, Transform OGAGKAHJKBJ, float EACFKABNCEE, bool NJLMAMBDHKO, bool MHJIAKJKIPN, float JPKNIKIOOBM, float IHIODIBEJKF, Transform BAOAKGNNKEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D790F0", Offset = "0x6D780F0", VA = "0x186D790F0")]
		public void CHHAIAFJNOL(Transform GKDLPAFMMME, Transform BAOAKGNNKEP, bool MPBLHOBAKNL, bool FNKFHLDFCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D79690", Offset = "0x6D78690", VA = "0x186D79690")]
		private void JJLIHGIBBMG(Transform BAOAKGNNKEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6D79530", Offset = "0x6D78530", VA = "0x186D79530")]
		public void DPCEAIIKOHB(Transform BAOAKGNNKEP, AvatarFullBodyConfiguration CLGKEAHKEGA, Vector3 EEAJGJLIDKF, float MDPLKCDDLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6D79790", Offset = "0x6D78790", VA = "0x186D79790")]
		public void NNFKCPCENFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6D79E80", Offset = "0x6D78E80", VA = "0x186D79E80")]
		public GEMBECIJGPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class JIFMAMEDEKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float AHBBINHHKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool LNNIEIAIMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AnimationPoseSetting OCBKFCMFLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float MMNHBAHPLMN;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F050", Offset = "0x6D7E050", VA = "0x186D7F050")]
		public void MALFJIENMAE(IKSolverVR.Arm KBOFADEAKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E4C0", Offset = "0x6D7D4C0", VA = "0x186D7E4C0")]
		public void HKFFJFNFONA(IKSolverVR.Arm KBOFADEAKFF, float KLEHBEJKDKM, bool LNNIEIAIMAF, AvatarFullBodyConfiguration CLGKEAHKEGA, float HECONEAPGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EB00", Offset = "0x6D7DB00", VA = "0x186D7EB00")]
		private void KKOMMBHLBNP(IKSolverVR.Arm KBOFADEAKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EC70", Offset = "0x6D7DC70", VA = "0x186D7EC70")]
		public void MAEDCBECDGB(IKSolverVR.Arm KBOFADEAKFF, Transform FJOOONJICFK, Transform OGAGKAHJKBJ, Quaternion AFHLIBANBJG, Vector3 LEGJNAGHDAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E030", Offset = "0x6D7D030", VA = "0x186D7E030")]
		private (Vector3, Quaternion) HKCJOIAPPDL(LGPCGPPOBBD EBLAGBDDFJI, Quaternion NEPCLOAPGBN, Vector3 MJHPDOGPKLB)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E9A0", Offset = "0x6D7D9A0", VA = "0x186D7E9A0")]
		public void KDDHGENOFGC(LGPCGPPOBBD EBLAGBDDFJI, IKSolverVR.Arm KBOFADEAKFF, Quaternion NEPCLOAPGBN, Vector3 MJHPDOGPKLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6D7DA30", Offset = "0x6D7CA30", VA = "0x186D7DA30")]
		public void CBHCNLPPLBC(LGPCGPPOBBD EBLAGBDDFJI, IKSolverVR.Arm KBOFADEAKFF, Quaternion NEPCLOAPGBN, Vector3 MJHPDOGPKLB, [In] AvatarFullBodyConfiguration CLGKEAHKEGA, [In] KLDJADNODDC LNHGKEAKACI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EB40", Offset = "0x6D7DB40", VA = "0x186D7EB40")]
		public void LAMFKLIKPFB(DOCMDIBFMFN JKFBIDOHKOD, AvatarFullBodyConfiguration CLGKEAHKEGA, KLDJADNODDC LNHGKEAKACI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E500", Offset = "0x6D7D500", VA = "0x186D7E500")]
		public void HPBKENNLBNI(IKSolverVR.Arm KBOFADEAKFF, Transform FJOOONJICFK, Vector3 GEHDPLAFIIO, float BIMACDBNHKF, Quaternion KHPALMBNFHH, Vector3 BIFKJNJKDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F080", Offset = "0x6D7E080", VA = "0x186D7F080")]
		public JIFMAMEDEKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum KBKEMADOGMA
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
	private struct IPLLHEGIGNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct FDDNNMFAMAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int CGJEBJPKODD;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int GHPEIKMJFDG;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int KKBLDDBGFIH;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int OAAFFEKHGKP;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int PICEAPJKKKL;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int DBJDAAKHPFG;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int AEBLFFCIEBI;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int MOEMAEBNNPG;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int ECPHKOIHLNP;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int LHNFNFEDONM;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int OBHICPOCECO;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int OFNIJAKAFJD;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int DMDGELOHHAD;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int ABEOMIAHOAD;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int OMHBODCDMPD;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int CKPIAFLGCDL;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int PEFBMCOGNKK;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int DGCNBDIEKEC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int HHAAJNDDPBA;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int MBLKHBCDBMD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int PJBGBPILBJH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int HPPAKBENCLI;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int OIKIBEIEFIO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int ABFHHKBPDIB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int FGLCHPOHCOL;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int DDPDLJPCOLM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int HGPLFBJJBKP;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int IIOCFDOMHPL;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int JEKNHMOKPOO;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 BJHGLBDKOAH;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int HHLOMPIHPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool AIFOFKHGDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool JLFDCDKNMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool CNMBEBLGLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool JIBKCKNJJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool JLMJNBGHGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Vector3 OMDEDGPGMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private string PBLFKIEAFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private HNKMHACJBEN? IPMGGDKMPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DCPCIMEHGCI? LECDEENKCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private BIOMPCEPIBK IKCJMHBBKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private KPFMBDIOCFK JJENCKAGCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private LGPCGPPOBBD HOHFENNOBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private LGPCGPPOBBD DLJCCLMBNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool CCNBDEHBKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool HDEHLEAOFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly DONANKAIBGH NJKDOACLCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly NEGLEJLBGIL DEPKHHDFEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int EDNCGAHAJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float BCCDHLAPHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GameObject JPKDDGBAGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform PNGJLDLEMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform LBKKJGDFCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform NOGPJJKLJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform EHGEKHIKOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform CIACACFGAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float GGIEHGLLBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float HLOFGIBKAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 MBBOMJLAHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Quaternion PKDEFDLPIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform ICHHIEGELBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform CAGELACIPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform FBOCMMCACNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool CNMIBMCGDNB;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker CDEAMNMEAGI;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker FODPPFPKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker JKKMBDMACBJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker ACKDAFCACBP;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker BDMPGODLHNC;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker NBONPAAKINI;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<BIGOLBIKDLN> CODMKGBMBGI;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int LNPMCLJBCAG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> HFLKJMOPOKI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int EEPFOIBKGGK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int GOBKFMICKCG;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int HBBLLADFPLE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int OACBIGGBGBF;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float MKDJHKIIMLO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int KEKFLLALGFJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float MGKPKDBFKMP;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float BBNFLLOLBME;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float JNADGJOIDLC;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float IEJCJFHMDNJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static HPNPHNPIPGD MLCINEJONNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float GHAAPCPJKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool NAECKPLLPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float LGJALNMFNHC;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int GBMJNDHCBKK;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int IHPKNNIHFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private GEMBECIJGPJ KELPLOCGMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private GEMBECIJGPJ BNACFMMBAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float PLNHDJCJOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Vector3 DOEDBBPBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Vector3 IKCICHDJJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool LIBCMJOHOHB;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion PCMJNHPIDJC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion ACMKKBOPOIF;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 JFMABNIMJAP;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 AHBJLPOEIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float FONGNECMMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float FAAMMIGDNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JIFMAMEDEKE KNGFGPKMJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private JIFMAMEDEKE MLBJPMNIJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private AONECPHINCO LKPLKDPNGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private POJDCMGNGBL BLFHBJEJCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly NDGIDLMOPHP CDNFDCNGOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float IGBDEPMACDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float FLIOCLJCAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly POJDCMGNGBL IAMALCFHBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 APJIFBBEMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Vector3 JMKGMFECEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float EIAPNBPFAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float EPICPIFPAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly POJDCMGNGBL DMGOGGHBJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly AONECPHINCO NKKCBKCPMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly POJDCMGNGBL GGCIDBLFOLN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GDBINPMHEFP BHOEPOJEKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GDBINPMHEFP DGCFOAPJHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration FCKOPGPBFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6D60400", Offset = "0x6D5F400", VA = "0x186D60400", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HEGHLNFMEGC IDGOFJLOIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D5BF70", Offset = "0x6D5AF70", VA = "0x186D5BF70", Slot = "23")]
		get
		{
			return default(HEGHLNFMEGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration EAJNMOIAKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E870", Offset = "0x6D5D870", VA = "0x186D5E870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform NPCDALGDLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E900", Offset = "0x6D5D900", VA = "0x186D5E900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform JJOBIMAOPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6D60090", Offset = "0x6D5F090", VA = "0x186D60090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer KEPNKBMELNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6D5FE60", Offset = "0x6D5EE60", VA = "0x186D5FE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] MAIDMGBCPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6D557F0", Offset = "0x6D547F0", VA = "0x186D557F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] NBOCGAKOMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D62180", Offset = "0x6D61180", VA = "0x186D62180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator MHMGJJOHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D55AA0", Offset = "0x6D54AA0", VA = "0x186D55AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK GKLBHPOCOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C5D0", Offset = "0x6D6B5D0", VA = "0x186D6C5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private HEIFOMILKAA CPNNCILIICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D58CD0", Offset = "0x6D57CD0", VA = "0x186D58CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private HEIFOMILKAA ACMFDBCEKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A230", Offset = "0x6D69230", VA = "0x186D6A230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private HEIFOMILKAA ACMBDLCFAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CA50", Offset = "0x6D5BA50", VA = "0x186D5CA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private HEIFOMILKAA KKDCFFCMIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D633B0", Offset = "0x6D623B0", VA = "0x186D633B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private HEIFOMILKAA DEKKNEDDFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D634B0", Offset = "0x6D624B0", VA = "0x186D634B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private HEIFOMILKAA NHJNCPCNFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A680", Offset = "0x6D59680", VA = "0x186D5A680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private HEIFOMILKAA BIAEGDCFBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D635B0", Offset = "0x6D625B0", VA = "0x186D635B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private HEIFOMILKAA LODKHJLDEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D673D0", Offset = "0x6D663D0", VA = "0x186D673D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public DCPCIMEHGCI PJACPBNKLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D556C0", Offset = "0x6D546C0", VA = "0x186D556C0", Slot = "15")]
		get
		{
			return default(DCPCIMEHGCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GFMDJEEHKJD ECONIGGLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA17050", Offset = "0xA16050", VA = "0x180A17050", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public HDPGNAMFPFM GCAOPPPGPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA16F80", Offset = "0xA15F80", VA = "0x180A16F80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public PFOGADOEGMB JKANNPDMHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA17070", Offset = "0xA16070", VA = "0x180A17070", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public PFOGADOEGMB HBJOJJIAGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xEE2150", Offset = "0xEE1150", VA = "0x180EE2150", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string BLMPDJEBAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform PKICJNLIKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D66E00", Offset = "0x6D65E00", VA = "0x186D66E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform MBLCMPGLDII
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EE50", Offset = "0x6D5DE50", VA = "0x186D5EE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform GIIGHJIJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D639A0", Offset = "0x6D629A0", VA = "0x186D639A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool AFBBJFOOKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D67D30", Offset = "0x6D66D30", VA = "0x186D67D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform LOFHKGHLNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D63150", Offset = "0x6D62150", VA = "0x186D63150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject IEELEEMHGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B710", Offset = "0x6D6A710", VA = "0x186D6B710", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets ENGODFJAAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D61300", Offset = "0x6D60300", VA = "0x186D61300", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform DMNEKKPOONG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x951E30", Offset = "0x950E30", VA = "0x180951E30", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform ABHIJMHFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x198DBE0", Offset = "0x198CBE0", VA = "0x18198DBE0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform LCIGDGECBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x198DD90", Offset = "0x198CD90", VA = "0x18198DD90", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform NEMFOOFIDOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1730CC0", Offset = "0x172FCC0", VA = "0x181730CC0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 OBEAAFLHALB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D69D70", Offset = "0x6D68D70", VA = "0x186D69D70", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float PNOBFAALPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D62730", Offset = "0x6D61730", VA = "0x186D62730", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform ODJPJDEKAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D575B0", Offset = "0x6D565B0", VA = "0x186D575B0", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform OJJBPOHFODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1C951C0", Offset = "0x1C941C0", VA = "0x181C951C0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform BBENOELFOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1C952A0", Offset = "0x1C942A0", VA = "0x181C952A0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform FDMMGEDECFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x17318A0", Offset = "0x17308A0", VA = "0x1817318A0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool OEHFKKGDIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D61BF0", Offset = "0x6D60BF0", VA = "0x186D61BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool DGAGGMPGCPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D5BA40", Offset = "0x6D5AA40", VA = "0x186D5BA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool NEDBIGLCAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D626B0", Offset = "0x6D616B0", VA = "0x186D626B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D57610", Offset = "0x6D56610", VA = "0x186D57610")]
	private void BMFGCFJMGKJ([In] KLDJADNODDC DAOLAIHHKKP, [In] AvatarFullBodyConfiguration CLGKEAHKEGA, bool KNOJNKOJNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BEE0", Offset = "0x6D5AEE0", VA = "0x186D5BEE0")]
	private float EFEGIKCMLJP([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D655A0", Offset = "0x6D645A0", VA = "0x186D655A0")]
	private float MCNLFLNAPPP([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AE30", Offset = "0x6D59E30", VA = "0x186D5AE30")]
	private void DHLBMJHIAJN(KLDJADNODDC DAOLAIHHKKP, AvatarFullBodyConfiguration CLGKEAHKEGA, bool KNOJNKOJNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D66C40", Offset = "0x6D65C40", VA = "0x186D66C40")]
	private void MMADNMJHFOB([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D5ED50", Offset = "0x6D5DD50", VA = "0x186D5ED50")]
	private void FMJIPNHINIC([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E370", Offset = "0x6D6D370", VA = "0x186D6E370")]
	public BIGOLBIKDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D59DE0", Offset = "0x6D58DE0", VA = "0x186D59DE0", Slot = "12")]
	public void CHBEJBHDDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D61CF0", Offset = "0x6D60CF0", VA = "0x186D61CF0", Slot = "13")]
	public void JADFEAGILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D67C60", Offset = "0x6D66C60", VA = "0x186D67C60", Slot = "14")]
	public void ODDMGIIFOIF(bool JHOFANHGFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6D64400", Offset = "0x6D63400", VA = "0x186D64400", Slot = "25")]
	public Transform LDMPGJJLMDP(string IEGKLHJGLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D62FC0", Offset = "0x6D61FC0", VA = "0x186D62FC0", Slot = "26")]
	public Vector3? JPIHJBMIGEC(string IEGKLHJGLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6D59360", Offset = "0x6D58360", VA = "0x186D59360", Slot = "7")]
	public void CBJMGKHIMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BAC0", Offset = "0x6D5AAC0", VA = "0x186D5BAC0")]
	private void ECJGOHDHMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D56BE0", Offset = "0x6D55BE0", VA = "0x186D56BE0", Slot = "6")]
	public void BFHKMCNAPPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D59B70", Offset = "0x6D58B70", VA = "0x186D59B70", Slot = "8")]
	public void CDCGEHPIOEK(float LDCADHEMGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B610", Offset = "0x6D5A610", VA = "0x186D5B610")]
	private void DLIIGBOGPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6D67D80", Offset = "0x6D66D80", VA = "0x186D67D80", Slot = "4")]
	public void OHONBOAHBHJ(string FICOHGIHLOJ, HNKMHACJBEN KFEGDEEIPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D56720", Offset = "0x6D55720", VA = "0x186D56720", Slot = "5")]
	public void BBJPCLJNNNL(DCPCIMEHGCI GKOLKKOLLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6D67B70", Offset = "0x6D66B70", VA = "0x186D67B70", Slot = "11")]
	public void OCPCBFEOKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D63B80", Offset = "0x6D62B80", VA = "0x186D63B80", Slot = "24")]
	public void LBKMONEHIDH([Out] Vector3 CCLBFGLLEPL, [Out] Quaternion KHPALMBNFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E840", Offset = "0x6D5D840", VA = "0x186D5E840")]
	private void FHLNGJANBIM([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6D60500", Offset = "0x6D5F500", VA = "0x186D60500", Slot = "27")]
	public void IEGDLNNJPLI(float DMFMJMGPLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EA00", Offset = "0x6D5DA00", VA = "0x186D5EA00", Slot = "28")]
	public void FLKBPLMMOAM(float EKDCGOFLBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D5FF60", Offset = "0x6D5EF60", VA = "0x186D5FF60", Slot = "44")]
	public void HKHOAKINILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D59D90", Offset = "0x6D58D90", VA = "0x186D59D90", Slot = "29")]
	public void CGKEJOEKDOL(bool EPMCNOFFBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D60190", Offset = "0x6D5F190", VA = "0x186D60190", Slot = "30")]
	public HandLogicOffsets IALECDGHEMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AD70", Offset = "0x6D59D70", VA = "0x186D5AD70", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets DFKFINKODJD()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D66E50", Offset = "0x6D65E50", VA = "0x186D66E50")]
	private void MOJEDGINILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D62280", Offset = "0x6D61280", VA = "0x186D62280")]
	private void JFBAJAMEBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D67160", Offset = "0x6D66160", VA = "0x186D67160")]
	private void MPJLMMENPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D59080", Offset = "0x6D58080", VA = "0x186D59080")]
	private void BPPDGPPMJGP(FEJLBHKHNGD INCABPJJNLD, bool BDOONMIDCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D59BE0", Offset = "0x6D58BE0", VA = "0x186D59BE0")]
	private void CDHAHNMADLE(FEJLBHKHNGD INCABPJJNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D57560", Offset = "0x6D56560", VA = "0x186D57560")]
	public Vector3 BGADLOFDLNE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D65900", Offset = "0x6D64900", VA = "0x186D65900")]
	private void MIKKOAILGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D64B70", Offset = "0x6D63B70", VA = "0x186D64B70")]
	private void LLIDEOLNCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6AD30", Offset = "0x6D69D30", VA = "0x186D6AD30")]
	private void OOGNJGMCEPK(KLDJADNODDC DAOLAIHHKKP, AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AAB0", Offset = "0x6D59AB0", VA = "0x186D5AAB0")]
	private float CPKGJONGPBD([In] KLDJADNODDC LNHGKEAKACI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D67A90", Offset = "0x6D66A90", VA = "0x186D67A90")]
	private int NMEAENHJICG([In] HKOKIGGHPCN PODOIPDJIFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D64650", Offset = "0x6D63650", VA = "0x186D64650")]
	private void LGJHOIHPOGG(KLDJADNODDC DAOLAIHHKKP, bool EOGGBIJKPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B830", Offset = "0x6D5A830", VA = "0x186D5B830")]
	private static void EABJHKJJNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CCA0", Offset = "0x6D6BCA0", VA = "0x186D6CCA0")]
	private static void PNGAIFKINGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BBE0", Offset = "0x6D6ABE0", VA = "0x186D6BBE0")]
	private float PHKCELHFCCE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A400", Offset = "0x6D59400", VA = "0x186D5A400")]
	private static int CNGOHHAIBNJ(BIGOLBIKDLN GGEOEEJGPGH, BIGOLBIKDLN OLIPOMNIFIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D63250", Offset = "0x6D62250", VA = "0x186D63250", Slot = "40")]
	public KLDJADNODDC KDFLLJCEGGE()
	{
		return default(KLDJADNODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D59040", Offset = "0x6D58040", VA = "0x186D59040")]
	public void BOEBIHCKLOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D601E0", Offset = "0x6D5F1E0", VA = "0x186D601E0")]
	private (bool, bool) IBIHIIAPPHO()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D63A10", Offset = "0x6D62A10", VA = "0x186D63A10")]
	private (float, float) LAHFGEJKGCF([In] KLDJADNODDC LNHGKEAKACI)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D060", Offset = "0x6D5C060", VA = "0x186D5D060")]
	private void FFFHGFKDAFO([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BBC0", Offset = "0x6D5ABC0", VA = "0x186D5BBC0")]
	private void EFAPLEPAIIK([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C070", Offset = "0x6D5B070", VA = "0x186D5C070")]
	private void EHLBMEGAPDN([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C6D0", Offset = "0x6D6B6D0", VA = "0x186D6C6D0")]
	private void PKPAHEJONCK([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA, FootSettings EEFEBENEEBB, bool CAPJLMJDJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A4D0", Offset = "0x6D694D0", VA = "0x186D6A4D0")]
	private float ONEEKIDMLFB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D607D0", Offset = "0x6D5F7D0", VA = "0x186D607D0")]
	private void IGFDKFFPDFK(KLDJADNODDC LNHGKEAKACI, AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D64600", Offset = "0x6D63600", VA = "0x186D64600")]
	private float LGBHDJIMDOG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6D63F10", Offset = "0x6D62F10", VA = "0x186D63F10")]
	private void LCADKKLOBDA([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6D65250", Offset = "0x6D64250", VA = "0x186D65250")]
	private void MAEDCBECDGB([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6D674D0", Offset = "0x6D664D0", VA = "0x186D674D0")]
	private void NGHFHCOHDGK([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D636B0", Offset = "0x6D626B0", VA = "0x186D636B0")]
	private void KLIHPEIOIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A430", Offset = "0x6D59430", VA = "0x186D5A430")]
	private void CNNNLNKICDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A330", Offset = "0x6D69330", VA = "0x186D6A330")]
	private void OLPCMCHHPII([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D62D30", Offset = "0x6D61D30", VA = "0x186D62D30")]
	private void JNLJHNOLPCB(LGPCGPPOBBD DOJAOHNPIBP, IKSolverVR.Arm KBOFADEAKFF, Transform AFKENBNOEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D5CCF0", Offset = "0x6D5BCF0", VA = "0x186D5CCF0")]
	private void FCJJOIJJBCE(KLDJADNODDC LNHGKEAKACI, AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B660", Offset = "0x6D5A660", VA = "0x186D5B660")]
	private void DMAGOJPACOE(PJHLCOJOHEC JEDECPINGDI, PFOGADOEGMB DOJAOHNPIBP, IKSolverVR.Arm KBOFADEAKFF, float KLEHBEJKDKM, float DJKDOPHABIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D66580", Offset = "0x6D65580", VA = "0x186D66580")]
	private void MLLGHNLFNPF([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F3D0", Offset = "0x6D5E3D0", VA = "0x186D5F3D0")]
	protected void GNJMCPCODAG([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D65620", Offset = "0x6D64620", VA = "0x186D65620")]
	private void MHCDCOHDKJD([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D60510", Offset = "0x6D5F510", VA = "0x186D60510")]
	protected void IEOADPAENPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D55FA0", Offset = "0x6D54FA0", VA = "0x186D55FA0")]
	private void ANDLAHNJIFC([In] KLDJADNODDC LNHGKEAKACI, [In] KBKEMADOGMA AAJCOLCAODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CAF0", Offset = "0x6D6BAF0", VA = "0x186D6CAF0")]
	private void PMFHCCOABJF(KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D63960", Offset = "0x6D62960", VA = "0x186D63960")]
	private void KNHAJBNKHKP([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EEC0", Offset = "0x6D5DEC0", VA = "0x186D5EEC0")]
	private Vector3 GLGGELDKOGM([In] KLDJADNODDC LNHGKEAKACI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BDC0", Offset = "0x6D6ADC0", VA = "0x186D6BDC0")]
	private void PIAPICDLPHN([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6D69E00", Offset = "0x6D68E00", VA = "0x186D69E00")]
	private float OKCGHHAJEME(float IHIODIBEJKF, [In] KLDJADNODDC LNHGKEAKACI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6D5FD10", Offset = "0x6D5ED10", VA = "0x186D5FD10")]
	private void HEIJDIDMGGL(float IHIODIBEJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F870", Offset = "0x6D5E870", VA = "0x186D5F870")]
	private void HDNOPHHFCDF([In] KLDJADNODDC LNHGKEAKACI, KBKEMADOGMA AAJCOLCAODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6D64B90", Offset = "0x6D63B90", VA = "0x186D64B90")]
	private float LPOKIKKMOLD([In] KLDJADNODDC DAOLAIHHKKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6D62780", Offset = "0x6D61780", VA = "0x186D62780")]
	private void JNIFOLIHKJE(KLDJADNODDC LNHGKEAKACI, KBKEMADOGMA AAJCOLCAODB, Vector3 BHAKCKOFCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D558F0", Offset = "0x6D548F0", VA = "0x186D558F0")]
	private static void AGEFLCMMJEO(Transform IMCFIOFNLHP, Quaternion JKJHCABJJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A780", Offset = "0x6D59780", VA = "0x186D5A780")]
	private void CPHLBKBOKCD([In] KLDJADNODDC MLBAPODAFAG, [In] HKOKIGGHPCN PODOIPDJIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D61380", Offset = "0x6D60380", VA = "0x186D61380")]
	private void IKMEONILMIM([In] KLDJADNODDC MLBAPODAFAG, [In] HKOKIGGHPCN PODOIPDJIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D66FB0", Offset = "0x6D65FB0", VA = "0x186D66FB0")]
	private void MPGDLGNGEFA(float CENFACNJNIP, [In] KLDJADNODDC DAOLAIHHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BE90", Offset = "0x6D6AE90", VA = "0x186D6BE90")]
	private float PIBJJAOFFPD([In] KLDJADNODDC DAOLAIHHKKP, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D58DD0", Offset = "0x6D57DD0", VA = "0x186D58DD0")]
	private void BOCAMDMFOHD([In] KLDJADNODDC DAOLAIHHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D6A550", Offset = "0x6D69550", VA = "0x186D6A550")]
	private void OOFIBBBNGOD([In] KLDJADNODDC DAOLAIHHKKP, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B270", Offset = "0x6D5A270", VA = "0x186D5B270")]
	private void DJLFCAGBBHD([In] KLDJADNODDC DAOLAIHHKKP, float AHLHJACCHDE, float COKIEIFGNJP, Vector3 PEOCNDKDCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6D65BC0", Offset = "0x6D64BC0", VA = "0x186D65BC0")]
	private void MJCKDIDOILC(KLDJADNODDC DAOLAIHHKKP, AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D55BA0", Offset = "0x6D54BA0", VA = "0x186D55BA0")]
	private void ALKOBJGCJKD(KLDJADNODDC DAOLAIHHKKP, AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6D678C0", Offset = "0x6D668C0", VA = "0x186D678C0")]
	public void NHLMEIKDLNK([In] KLDJADNODDC LNHGKEAKACI, [In] AvatarFullBodyConfiguration CLGKEAHKEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D5CB50", Offset = "0x6D5BB50", VA = "0x186D5CB50")]
	[CompilerGenerated]
	internal static void FALBIHFBCMM(Transform KBCCBGCMCIL, IKSolverVR.Arm KBOFADEAKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6D64550", Offset = "0x6D63550", VA = "0x186D64550")]
	[CompilerGenerated]
	internal static void LFECEAIFPPG(Vector3 GDBMGABMGJH, Vector3 HIKLKJEIOCG, IPLLHEGIGNO P_2, FDDNNMFAMAO P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F7D0", Offset = "0x6D5E7D0", VA = "0x186D5F7D0")]
	[CompilerGenerated]
	internal static void GODDJAEOPDJ(GEMBECIJGPJ PIAOMECMJMA, GEMBECIJGPJ BPOIBHDMPLA, Vector3 NFHMGEILMEN, float IPLILPPMPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AC60", Offset = "0x6D59C60", VA = "0x186D5AC60")]
	[CompilerGenerated]
	internal static bool DEKJIAPFAME(IKSolverVR.Arm KBOFADEAKFF, DCLNENPEBDC OOKLPDDOBLH, float MCJJMAKJIJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B7B0", Offset = "0x6D6A7B0", VA = "0x186D6B7B0")]
	[CompilerGenerated]
	internal static float PGGIAKHNKJL(Vector3 CCILOIFMAMI, Vector3 PFFPJHOEDNO, Vector3 FNFDBIGEHKH, KLDJADNODDC DAOLAIHHKKP, AvatarFullBodyConfiguration CLGKEAHKEGA, float OFDADLBABBI)
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
		public enum PODLDLAJLDH
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private PODLDLAJLDH handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x6D73C00", Offset = "0x6D72C00", VA = "0x186D73C00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D73BC0", Offset = "0x6D72BC0", VA = "0x186D73BC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6D735C0", Offset = "0x6D725C0", VA = "0x186D735C0")]
		private void OPLFPHGJCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C030", Offset = "0x6D1B030", VA = "0x186D1C030", Slot = "4")]
		public void SetEnabled(bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6D73C30", Offset = "0x6D72C30", VA = "0x186D73C30")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AvatarKneeBendTargetController : MonoBehaviour, HEIFOMILKAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
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
		private Vector3 IDHICBIKEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Vector3 DNGHEGINION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Vector3 EEJCNGJMCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Matrix4x4 JFEAGDAMGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private bool PHACGPOCJPH;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6D740D0", Offset = "0x6D730D0", VA = "0x186D740D0", Slot = "4")]
		public void UpdateController(float MLPBAIIBHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6D740C0", Offset = "0x6D730C0", VA = "0x186D740C0", Slot = "6")]
		public void SetEnabled(bool BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6D73C60", Offset = "0x6D72C60", VA = "0x186D73C60")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6D74790", Offset = "0x6D73790", VA = "0x186D74790")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, EFKKGHCGNJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[Header("Configuration")]
		private HEGHLNFMEGC avatarBodyType;

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
		[DPAAGPNIBEP(CCPGINMHCCO.SelfAndChildren, false, false, false)]
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
		private ENBELBPGKHJ JHAKGOMKHFO;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public ENBELBPGKHJ HENIHFCEKDP
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA16F60", Offset = "0xA15F60", VA = "0x180A16F60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform BMMMOHJHMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6D75620", Offset = "0x6D74620", VA = "0x186D75620", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D747A0", Offset = "0x6D737A0", VA = "0x186D747A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6D754E0", Offset = "0x6D744E0", VA = "0x186D754E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D75490", Offset = "0x6D74490", VA = "0x186D75490")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D75420", Offset = "0x6D74420", VA = "0x186D75420")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6D747A0", Offset = "0x6D737A0", VA = "0x186D747A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6D74C20", Offset = "0x6D73C20", VA = "0x186D74C20", Slot = "6")]
		public ENBELBPGKHJ CreateAvatarSystem(string FICOHGIHLOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6D75420", Offset = "0x6D74420", VA = "0x186D75420", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6D74850", Offset = "0x6D73850", VA = "0x186D74850", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6D75530", Offset = "0x6D74530", VA = "0x186D75530", Slot = "9")]
		public void UpdatePostIKAnimControllers(float MLPBAIIBHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class KKONGHPCJIJ : KFFKINEPFPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<string, ENBELBPGKHJ> COCLAMPHEOE;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FA00", Offset = "0x6D7EA00", VA = "0x186D7FA00")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void FPOMNMOFONH(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F770", Offset = "0x6D7E770", VA = "0x186D7F770", Slot = "4")]
	public ENBELBPGKHJ BIEJCJHKGPN(string DCNNHOAAKIG, AvatarSystemConfiguration AGFCEIEGNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FA70", Offset = "0x6D7EA70", VA = "0x186D7FA70", Slot = "5")]
	public void IMBLBBAHCMB(string DCNNHOAAKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F630", Offset = "0x6D7E630", VA = "0x186D7F630", Slot = "6")]
	public string APJBNPEHDDE(string IDJONFHBDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F990", Offset = "0x6D7E990", VA = "0x186D7F990")]
	private string DPGKLGBIJNH(string IDJONFHBDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FBF0", Offset = "0x6D7EBF0", VA = "0x186D7FBF0")]
	public KKONGHPCJIJ()
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
		public class PBOJBHCAJKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private Dictionary<string, Transform> MMHMPFBMOPP;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool DCLLIFLPMLP
			{
				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x6D819B0", Offset = "0x6D809B0", VA = "0x186D819B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x6D81880", Offset = "0x6D80880", VA = "0x186D81880")]
			public void ACPBMDJCCNP(VRIK KGMIKPEMCNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
			public void OKABIOMBPAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6D819F0", Offset = "0x6D809F0", VA = "0x186D819F0")]
			public void CMJEOBEPHJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6D81A40", Offset = "0x6D80A40", VA = "0x186D81A40")]
			public PBOJBHCAJKM()
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
		[MONCIELHEAI(CCPGINMHCCO.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[DPAAGPNIBEP(CCPGINMHCCO.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly PBOJBHCAJKM CIDGMCMMKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private EFKKGHCGNJD PCOLAHCKBNA;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6D75670", Offset = "0x6D74670", VA = "0x186D75670")]
		private void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6D75950", Offset = "0x6D74950", VA = "0x186D75950")]
		private bool IKBAFFDAKLE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6D759A0", Offset = "0x6D749A0", VA = "0x186D759A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6D75A10", Offset = "0x6D74A10", VA = "0x186D75A10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6D759B0", Offset = "0x6D749B0", VA = "0x186D759B0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6D75C80", Offset = "0x6D74C80", VA = "0x186D75C80")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D7CC10", Offset = "0x6D7BC10", VA = "0x186D7CC10")]
		public void BCCFFCEEHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D7CD30", Offset = "0x6D7BD30", VA = "0x186D7CD30")]
		public int KEMMDNLKPNH(int FLJCCEHCPEF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6D7CDA0", Offset = "0x6D7BDA0", VA = "0x186D7CDA0")]
			public void BCCFFCEEHAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x6D7CE80", Offset = "0x6D7BE80", VA = "0x186D7CE80")]
			public (float, float) GAPLAHBHPAM(Animator IKIHCGBBMNO, AnimatorStateInfo NGPDMGGNCFH)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D7CFC0", Offset = "0x6D7BFC0", VA = "0x186D7CFC0")]
		public void BCCFFCEEHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D1B0", Offset = "0x6D7C1B0", VA = "0x186D7D1B0")]
		public (float, float) FLKINDJEMOE(Animator IKIHCGBBMNO)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D3C0", Offset = "0x6D7C3C0", VA = "0x186D7D3C0")]
		private (float, float) PIEHJOHEDAA(Animator IKIHCGBBMNO, AnimatorStateInfo NGPDMGGNCFH)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7D5B0", Offset = "0x6D7C5B0", VA = "0x186D7D5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D81700", Offset = "0x6D80700", VA = "0x186D81700", Slot = "4")]
		public override void OnStateEnter(Animator IKIHCGBBMNO, AnimatorStateInfo NGPDMGGNCFH, int HEFMBGPCKLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6D81860", Offset = "0x6D80860", VA = "0x186D81860")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal abstract class ADGENMFJGOI<TInput, TOutput> : IBDJHFEJNEB<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	protected readonly NAAEIEAKGMH AGNAOKAOOII;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x408F2F0", Offset = "0x408E2F0", VA = "0x18408F2F0")]
	protected ADGENMFJGOI(NAAEIEAKGMH AGNAOKAOOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput OGCNNFLPKKP(TInput EDAMLOGMMEK, [Out] IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x408F250", Offset = "0x408E250", VA = "0x18408F250", Slot = "5")]
	public bool FFFNMAIDGAI(TInput EDAMLOGMMEK, [Out] TOutput? POCKBMKNJHC, [Out] IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PGJOKJDJLNC]
public static class HHKAKONKNKE
{
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly Regex NNLLHIEKDBH;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A820", Offset = "0x6D79820", VA = "0x186D7A820")]
	public static KANBAKOHKIG FBPICDNMHOB(IOFOCLGJBKE OLPKPFAKBOD, BEFENALLNEP DPPPNAPANKJ, Guid? OPIHNJMKJBC, Color? LOCAOLCMFJJ, PPEPNMKDOKP ABOBDACKLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AB70", Offset = "0x6D79B70", VA = "0x186D7AB70")]
	public static MMDGIABAHDI PBLPPNKHHAO(KANBAKOHKIG CONAFKKIHKL)
	{
		return default(MMDGIABAHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2F91A00", Offset = "0x2F90A00", VA = "0x182F91A00")]
	internal static TModern? GNCMIFGFOHL<TModern>(string? EDAMLOGMMEK, JMKEPDKLDNL<TModern> COPDEHBBEJA, NAAEIEAKGMH AGNAOKAOOII, GKDNHFAFMEH JGGIJCHAMEM, TModern NNFOIAGKJCG) where TModern : struct, PACINHNAFHD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2F93050", Offset = "0x2F92050", VA = "0x182F93050")]
	internal static ECELGBMJMPG JMAPDAFADHM<TModern>(string? EDAMLOGMMEK, JMKEPDKLDNL<TModern> COPDEHBBEJA, NAAEIEAKGMH AGNAOKAOOII, GKDNHFAFMEH JGGIJCHAMEM, TModern NNFOIAGKJCG) where TModern : struct, PACINHNAFHD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AA30", Offset = "0x6D79A30", VA = "0x186D7AA30")]
	internal static List<AILCDLDOFAP> MOLOFJNBDFK(IEnumerable<NHGGLKDIEHB>? MMNPFNOBOAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2F90B80", Offset = "0x2F8FB80", VA = "0x182F90B80")]
	internal static string AMJIDLDICBA<TModern>(TModern EDAMLOGMMEK, JMKEPDKLDNL<TModern> COPDEHBBEJA, NAAEIEAKGMH AGNAOKAOOII) where TModern : PACINHNAFHD
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class BHKGMFDIAPM : MJICKBLGHGD
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IBDJHFEJNEB<DGKJPCCGNNH, LGAKPDPMGDK> POBGNONCGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IBDJHFEJNEB<LFOFAMIMPJP, HACPMBHDCOE> PHGFACNJFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IBDJHFEJNEB<LFOFAMIMPJP, HACPMBHDCOE> CELNEKJGABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public LJCEALAPHEE IMBKEEBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public PBCDLJOKHLG GGLAEEJBLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6D75D60", Offset = "0x6D74D60", VA = "0x186D75D60")]
	[UsedImplicitly]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	internal static void GINBDFFNHCF(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D75DD0", Offset = "0x6D74DD0", VA = "0x186D75DD0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BHKGMFDIAPM([GAHPILLNNBL("UnitySerialization")] IFDIPPGPIPG FJHMKFOGHHM, [GAHPILLNNBL(null)] KDABCBFBNHH JMNMKCFBPFJ, [GAHPILLNNBL(null)] NAAEIEAKGMH AGNAOKAOOII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum NGFMKLEOHCN
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
public class APAOHMMKCAA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6D72BA0", Offset = "0x6D71BA0", VA = "0x186D72BA0")]
	public APAOHMMKCAA(string ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D72BD0", Offset = "0x6D71BD0", VA = "0x186D72BD0")]
	public APAOHMMKCAA(string ABHPFCOODAJ, Exception AHKLKPABMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6D72B30", Offset = "0x6D71B30", VA = "0x186D72B30")]
	public APAOHMMKCAA(NGFMKLEOHCN NNMDNPOJCMN, string ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D72B60", Offset = "0x6D71B60", VA = "0x186D72B60")]
	public APAOHMMKCAA(NGFMKLEOHCN NNMDNPOJCMN, string ABHPFCOODAJ, Exception AHKLKPABMPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal abstract class LAAIOLGPILM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly IFDIPPGPIPG FJHMKFOGHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	protected readonly KDABCBFBNHH JMNMKCFBPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	protected readonly NAAEIEAKGMH AGNAOKAOOII;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D78F70", Offset = "0x6D77F70", VA = "0x186D78F70")]
	protected LAAIOLGPILM(IFDIPPGPIPG FJHMKFOGHHM, KDABCBFBNHH JMNMKCFBPFJ, NAAEIEAKGMH AGNAOKAOOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D80430", Offset = "0x6D7F430", VA = "0x186D80430")]
	protected string PHKDOAKPNNB(LGAKPDPMGDK HKJLEANLJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D80250", Offset = "0x6D7F250", VA = "0x186D80250")]
	protected string NFPALBFLFKP(LGAKPDPMGDK HKJLEANLJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FDE0", Offset = "0x6D7EDE0", VA = "0x186D7FDE0")]
	private AvatarOutfitSelectionData FBPICDNMHOB(KANBAKOHKIG HHNFGFHLJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D80110", Offset = "0x6D7F110", VA = "0x186D80110")]
	private static AvatarCustomizationSettingsData.AnchorParams IIFHFLOMDLN(DIHADCKDDGJ? PEIDAJMALFG)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IBDJHFEJNEB<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput OGCNNFLPKKP(TInput EDAMLOGMMEK, [Out] IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FFFNMAIDGAI(TInput EDAMLOGMMEK, [Out] TOutput? POCKBMKNJHC, [Out] IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MJICKBLGHGD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	IBDJHFEJNEB<DGKJPCCGNNH, LGAKPDPMGDK> POBGNONCGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	IBDJHFEJNEB<LFOFAMIMPJP, HACPMBHDCOE> CELNEKJGABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	LJCEALAPHEE IMBKEEBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal enum GKDNHFAFMEH
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PBCDLJOKHLG
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHBFHKBIAKA EKFEJLFJOKC(LGAKPDPMGDK CONAFKKIHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LJCEALAPHEE
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFOFAMIMPJP EKFEJLFJOKC(LGAKPDPMGDK CONAFKKIHKL, int GHANGMDGLPB, string? DMCFPOLFNCF, string? FCFKBAJONJM, AJFAECAAJNI KHAKAAGNHOM, List<AILCDLDOFAP>? HEJIMNMCIKI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[PGJOKJDJLNC]
internal class ILFHIKDAIBM : ADGENMFJGOI<DGKJPCCGNNH, LGAKPDPMGDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly KDABCBFBNHH JMNMKCFBPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly EFJKBIJEMKC EECIDCIDCDG;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D860", Offset = "0x6D7C860", VA = "0x186D7D860")]
	public ILFHIKDAIBM(IFDIPPGPIPG FJHMKFOGHHM, KDABCBFBNHH JMNMKCFBPFJ, NAAEIEAKGMH AGNAOKAOOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7D5C0", Offset = "0x6D7C5C0", VA = "0x186D7D5C0", Slot = "6")]
	public override LGAKPDPMGDK OGCNNFLPKKP(DGKJPCCGNNH EDAMLOGMMEK, [Out] IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RecRoom.NoEngine.Common.Preserve]
internal class KPOLPGNLPBG : IFDIPPGPIPG
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class ACOKBAMGKFO : JsonConverter<ECELGBMJMPG>
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6D72A50", Offset = "0x6D71A50", VA = "0x186D72A50", Slot = "9")]
		public override void WriteJson(JsonWriter FOJCOMJJHIM, ECELGBMJMPG? BJDKOHEGDOK, JsonSerializer CHFFECKHFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6D72930", Offset = "0x6D71930", VA = "0x186D72930", Slot = "10")]
		public override ECELGBMJMPG ReadJson(JsonReader EEKHIEJPCBE, Type JLJIJLCLHCP, ECELGBMJMPG? LKPHJKCPNIB, bool ABNOPLAMPIM, JsonSerializer CHFFECKHFII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6D72AF0", Offset = "0x6D71AF0", VA = "0x186D72AF0")]
		public ACOKBAMGKFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class GGLIBHIJBMK : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool IMBMFBHOKLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6D7A250", Offset = "0x6D79250", VA = "0x186D7A250", Slot = "5")]
		public override object ReadJson(JsonReader EEKHIEJPCBE, Type JLJIJLCLHCP, object? LKPHJKCPNIB, JsonSerializer CHFFECKHFII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6D79E90", Offset = "0x6D78E90", VA = "0x186D79E90", Slot = "6")]
		public override bool CanConvert(Type JLJIJLCLHCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6D7A2B0", Offset = "0x6D792B0", VA = "0x186D7A2B0", Slot = "4")]
		public override void WriteJson(JsonWriter FOJCOMJJHIM, object? BJDKOHEGDOK, JsonSerializer CHFFECKHFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6D7A070", Offset = "0x6D79070", VA = "0x186D7A070")]
		private static bool FBJLDGMJEDL(object BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public GGLIBHIJBMK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly JsonSerializerSettings FJIDNEHJBMJ;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FC80", Offset = "0x6D7EC80", VA = "0x186D7FC80")]
	internal KPOLPGNLPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x30401F0", Offset = "0x303F1F0", VA = "0x1830401F0", Slot = "4")]
	public string NDHDMOAFJGL<T>(T IFPBFCLBBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3040250", Offset = "0x303F250", VA = "0x183040250", Slot = "5")]
	public T NKPDMNJDIKE<T>(string BJDKOHEGDOK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RecRoom.NoEngine.Common.Preserve]
internal class DGKDFIKPHII : IFDIPPGPIPG
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2DB9940", Offset = "0x2DB8940", VA = "0x182DB9940", Slot = "4")]
	public string NDHDMOAFJGL<T>(T IFPBFCLBBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2DB99C0", Offset = "0x2DB89C0", VA = "0x182DB99C0", Slot = "5")]
	public T NKPDMNJDIKE<T>(string BJDKOHEGDOK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public DGKDFIKPHII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[PGJOKJDJLNC]
internal class EFJKBIJEMKC : ADGENMFJGOI<LFOFAMIMPJP, HACPMBHDCOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly IFDIPPGPIPG FJHMKFOGHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly KDABCBFBNHH JMNMKCFBPFJ;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6D78740", Offset = "0x6D77740", VA = "0x186D78740")]
	public EFJKBIJEMKC(IFDIPPGPIPG FJHMKFOGHHM, KDABCBFBNHH JMNMKCFBPFJ, NAAEIEAKGMH AGNAOKAOOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6D77FC0", Offset = "0x6D76FC0", VA = "0x186D77FC0", Slot = "6")]
	public override HACPMBHDCOE OGCNNFLPKKP(LFOFAMIMPJP EDAMLOGMMEK, [Out] IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6D777D0", Offset = "0x6D767D0", VA = "0x186D777D0")]
	internal void NBGMFMMIHAE(string BGHMNFOEGMH, LGAKPDPMGDK HKJLEANLJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6D77300", Offset = "0x6D76300", VA = "0x186D77300")]
	public IEnumerable<KANBAKOHKIG> GNFJBNCHGPM(string OFMNELDFILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6D773B0", Offset = "0x6D763B0", VA = "0x186D773B0")]
	private IEnumerable<KANBAKOHKIG> KGOCOFKNINA(string OFMNELDFILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6D76630", Offset = "0x6D75630", VA = "0x186D76630")]
	internal IEnumerable<KANBAKOHKIG> CJBDLPJHJHG(string OFMNELDFILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D77C40", Offset = "0x6D76C40", VA = "0x186D77C40")]
	private KANBAKOHKIG NKGPDEGDEFE(AvatarOutfitSelectionData NNNIMCBLHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6D76A80", Offset = "0x6D75A80", VA = "0x186D76A80")]
	private void FHHKLPLCCEI(AvatarCustomizationSettingsData LBIINFBLHFM, LGAKPDPMGDK HKJLEANLJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6D77930", Offset = "0x6D76930", VA = "0x186D77930")]
	private KANBAKOHKIG NKGPDEGDEFE(string MDDJHKKPCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6D76330", Offset = "0x6D75330", VA = "0x186D76330")]
	internal static (PPEPNMKDOKP, string, string) CCIOAGHJKGK(string MDDJHKKPCKM, NAAEIEAKGMH AGNAOKAOOII)
	{
		return default((PPEPNMKDOKP, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6D78540", Offset = "0x6D77540", VA = "0x186D78540")]
	private BBPLMAEHHAO? PKFKNOJCIBO(string? EEKOILIMLBO, Vector2 BBHPNIDGLLI, float EMGOJDIECJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6D783E0", Offset = "0x6D773E0", VA = "0x186D783E0")]
	private static DIHADCKDDGJ OMDBNBKEOMK(AvatarCustomizationSettingsData.AnchorParams MILBKJMOCIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PGJOKJDJLNC]
internal class FIJPMHDOIHM : LAAIOLGPILM, PBCDLJOKHLG
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6D78F70", Offset = "0x6D77F70", VA = "0x186D78F70")]
	public FIJPMHDOIHM(IFDIPPGPIPG FJHMKFOGHHM, KDABCBFBNHH JMNMKCFBPFJ, NAAEIEAKGMH AGNAOKAOOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6D78880", Offset = "0x6D77880", VA = "0x186D78880", Slot = "4")]
	public OHBFHKBIAKA EKFEJLFJOKC(LGAKPDPMGDK CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6D78C30", Offset = "0x6D77C30", VA = "0x186D78C30")]
	private string GPFBHFMLBCH(LGAKPDPMGDK HKJLEANLJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6D78D30", Offset = "0x6D77D30", VA = "0x186D78D30")]
	private string KCCLDGHKEGP(KANBAKOHKIG HHNFGFHLJDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PGJOKJDJLNC]
internal class KHFBLLDELKI : ADGENMFJGOI<LFOFAMIMPJP, HACPMBHDCOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly IFDIPPGPIPG FJHMKFOGHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly IBDJHFEJNEB<LFOFAMIMPJP, HACPMBHDCOE> EDDIMEOPAKA;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F530", Offset = "0x6D7E530", VA = "0x186D7F530")]
	public KHFBLLDELKI(IBDJHFEJNEB<LFOFAMIMPJP, HACPMBHDCOE> EDDIMEOPAKA, NAAEIEAKGMH AGNAOKAOOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F100", Offset = "0x6D7E100", VA = "0x186D7F100", Slot = "6")]
	public override HACPMBHDCOE OGCNNFLPKKP(LFOFAMIMPJP EDAMLOGMMEK, [Out] IReadOnlyList<AILCDLDOFAP>? HEJIMNMCIKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[PGJOKJDJLNC]
internal class GJEOHFGJNPD : LJCEALAPHEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly IFDIPPGPIPG FJHMKFOGHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly PBCDLJOKHLG OPDJCDFPCPD;

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A730", Offset = "0x6D79730", VA = "0x186D7A730")]
	public GJEOHFGJNPD(PBCDLJOKHLG OPDJCDFPCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A390", Offset = "0x6D79390", VA = "0x186D7A390", Slot = "4")]
	public LFOFAMIMPJP EKFEJLFJOKC(LGAKPDPMGDK CONAFKKIHKL, int GHANGMDGLPB, string? DMCFPOLFNCF, string? FCFKBAJONJM, AJFAECAAJNI KHAKAAGNHOM, List<AILCDLDOFAP>? HEJIMNMCIKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RecRoom.NoEngine.Common.Preserve]
internal class HKOGNJBAJBG : KCIEGBAKIPC
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 JGGDHHIGAPI;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 ALONLCIBFJA;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly Vector2 LIDFOHKPBGA;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly Vector2 JJNMGPDAMIB;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static readonly Vector2 CEDOIPIFEGB;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static readonly Vector2 FFJADOHMNCG;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static readonly Vector2 GPFPGLEKGDO;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly Vector2 ECGICBLPOII;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static readonly Vector2 KFCMKDJGBKC;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly Vector2 PEOGKHHGMHO;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private static readonly Vector2 MEGOKKALDNJ;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly Vector2 CPEKLLLKMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Dictionary<HEGHLNFMEGC, AvatarConfiguration> OJNCLEPPJDH;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B0B0", Offset = "0x6D7A0B0", VA = "0x186D7B0B0")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	internal static void CHALJMMPIBP(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CB60", Offset = "0x6D7BB60", VA = "0x186D7CB60")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HKOGNJBAJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B340", Offset = "0x6D7A340", VA = "0x186D7B340", Slot = "4")]
	public Vector2 EBNALNMEKPD(FaceFeatureType DCLELGLJONB, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AFA0", Offset = "0x6D79FA0", VA = "0x186D7AFA0", Slot = "5")]
	public float BPPPGGDGGIG(FaceFeatureType DCLELGLJONB, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C840", Offset = "0x6D7B840", VA = "0x186D7C840", Slot = "6")]
	public void PHOICPIACEL(HEGHLNFMEGC KJFGNCHICJH, AvatarConfiguration AGFCEIEGNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C790", Offset = "0x6D7B790", VA = "0x186D7C790", Slot = "7")]
	public void PEDNKKKGFDH(HFHMJNJOALC FIDFGLFIENB, AvatarConfiguration BMGBEPGFPKO, HEGHLNFMEGC NHKMFDLLFMI, HEGHLNFMEGC JHKMKFFDBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BDF0", Offset = "0x6D7ADF0", VA = "0x186D7BDF0", Slot = "8")]
	public float KBFDGCGAFBA(FaceFeatureType LDJGABCJBIB, float JFGHIOMGHEH, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BCF0", Offset = "0x6D7ACF0", VA = "0x186D7BCF0", Slot = "9")]
	public float JGEGIKBCNPL(FaceFeatureType LDJGABCJBIB, float EMGOJDIECJD, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C560", Offset = "0x6D7B560", VA = "0x186D7C560", Slot = "11")]
	public Vector2 NCDEDOKEHAD(FaceFeatureType LDJGABCJBIB, Vector2 DKFCBLFGLII, Vector2 BHHPMCLPPDN, Vector2 DFALLLJJMPE, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C340", Offset = "0x6D7B340", VA = "0x186D7C340", Slot = "10")]
	public Vector2 MICEMKDKBAA(FaceFeatureType LDJGABCJBIB, Vector2 IHNAEPCNJHJ, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B610", Offset = "0x6D7A610", VA = "0x186D7B610")]
	private Vector2 GAEAIIJIELM(FaceFeatureType LDJGABCJBIB, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AE40", Offset = "0x6D79E40", VA = "0x186D7AE40")]
	private Vector2 BOBMHDDLGGJ(FaceFeatureType LDJGABCJBIB, Vector2 DKFCBLFGLII, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BEA0", Offset = "0x6D7AEA0", VA = "0x186D7BEA0", Slot = "12")]
	public Vector2 LNFHOPDDJNF(FaceFeatureType LDJGABCJBIB, Vector2 IHNAEPCNJHJ, Vector2 BHHPMCLPPDN, Vector2 DFALLLJJMPE, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B8B0", Offset = "0x6D7A8B0", VA = "0x186D7B8B0", Slot = "13")]
	public float HOGJFHEGNCI(FaceFeatureType LDJGABCJBIB, float EMGOJDIECJD, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B020", Offset = "0x6D7A020", VA = "0x186D7B020")]
	private float CFJGGHBBMIJ(float JCGGLMFLBCP, float PLFLOPDIPGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C240", Offset = "0x6D7B240", VA = "0x186D7C240")]
	private Vector2 LNGFCLNJOAA(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C710", Offset = "0x6D7B710", VA = "0x186D7C710")]
	private Vector2 NKBGAOOKBHI(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B830", Offset = "0x6D7A830", VA = "0x186D7B830")]
	private Vector2 HEFLCLCEDCB(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C2C0", Offset = "0x6D7B2C0", VA = "0x186D7C2C0")]
	private Vector2 MGHCFEMAIOO(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B300", Offset = "0x6D7A300", VA = "0x186D7B300")]
	private float DLHNLCGNOMN(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B120", Offset = "0x6D7A120", VA = "0x186D7B120")]
	private float CIOEKCKGHIC(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BE60", Offset = "0x6D7AE60", VA = "0x186D7BE60")]
	private float LDNOMEGFLCB(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BE20", Offset = "0x6D7AE20", VA = "0x186D7BE20")]
	private float KNNAPLILDJO(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AD70", Offset = "0x6D79D70", VA = "0x186D7AD70")]
	private Vector2 BOAGCMLGBGF(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BC20", Offset = "0x6D7AC20", VA = "0x186D7BC20")]
	private Vector2 JFEJFNMFPKO(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B160", Offset = "0x6D7A160", VA = "0x186D7B160")]
	private Vector2 CMNKLJPGFFC(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BA80", Offset = "0x6D7AA80", VA = "0x186D7BA80")]
	private Vector2 HPFCDHDCNKN(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BD20", Offset = "0x6D7AD20", VA = "0x186D7BD20")]
	private Vector2 JIMOAOAHCCE(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BB50", Offset = "0x6D7AB50", VA = "0x186D7BB50")]
	private Vector2 IDACCHOHIJM(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B230", Offset = "0x6D7A230", VA = "0x186D7B230")]
	private Vector2 CNCPBOAKBAM(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B760", Offset = "0x6D7A760", VA = "0x186D7B760")]
	private Vector2 GLHCAMFFIEG(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C8B0", Offset = "0x6D7B8B0", VA = "0x186D7C8B0")]
	private Vector2 PODKNHBICEC(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B4B0", Offset = "0x6D7A4B0", VA = "0x186D7B4B0")]
	private Vector2 FCDINKDDNGA(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B560", Offset = "0x6D7A560", VA = "0x186D7B560")]
	private Vector2 FPGENPKEFOM(HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B6B0", Offset = "0x6D7A6B0", VA = "0x186D7B6B0")]
	private Vector2 GFDOFFEPAJD(HEGHLNFMEGC KJFGNCHICJH)
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
		[Cpp2IlInjected.Address(RVA = "0x6D72CB0", Offset = "0x6D71CB0", VA = "0x186D72CB0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class PCLIBDHAAJI
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D81C50", Offset = "0x6D80C50", VA = "0x186D81C50")]
	public static MMDGIABAHDI OGCNNFLPKKP(this OIKDEGBLBCB CONAFKKIHKL)
	{
		return default(MMDGIABAHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D81AD0", Offset = "0x6D80AD0", VA = "0x186D81AD0")]
	public static OIKDEGBLBCB EKFEJLFJOKC(this MMDGIABAHDI MIPCJLBBBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D81BF0", Offset = "0x6D80BF0", VA = "0x186D81BF0")]
	public static bool IDBKKALBOFN(this MMDGIABAHDI MIPCJLBBBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6D81D60", Offset = "0x6D80D60", VA = "0x186D81D60")]
	public static bool PGKAHKGNCCP(this MMDGIABAHDI MIPCJLBBBJG)
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
			[Cpp2IlInjected.Address(RVA = "0x5113360", Offset = "0x5112360", VA = "0x185113360")]
			public AnchorParams(Vector2 DKFCBLFGLII, Vector3 HDBLHPKOOND, Vector3 JEAPGNBCPPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6D72C00", Offset = "0x6D71C00", VA = "0x186D72C00")]
			internal DIHADCKDDGJ EKFEJLFJOKC()
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
		private MKGNMDNIPHG useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x6D734A0", Offset = "0x6D724A0", VA = "0x186D734A0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x41F2770", Offset = "0x41F1770", VA = "0x1841F2770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x92B0E0", Offset = "0x92A0E0", VA = "0x18092B0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xB42050", Offset = "0xB41050", VA = "0x180B42050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xDD4A20", Offset = "0xDD3A20", VA = "0x180DD4A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6D73540", Offset = "0x6D72540", VA = "0x186D73540")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F50", Offset = "0x8C1F50", VA = "0x1808C2F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x95FBE0", Offset = "0x95EBE0", VA = "0x18095FBE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x14A1EB0", Offset = "0x14A0EB0", VA = "0x1814A1EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6D73580", Offset = "0x6D72580", VA = "0x186D73580")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA9A420", Offset = "0xA99420", VA = "0x180A9A420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xC97CC0", Offset = "0xC96CC0", VA = "0x180C97CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1273830", Offset = "0x1272830", VA = "0x181273830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8B4290", Offset = "0x8B3290", VA = "0x1808B4290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8B4240", Offset = "0x8B3240", VA = "0x1808B4240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4635630", Offset = "0x4634630", VA = "0x184635630")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABD110", VA = "0x180ABE110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8EBDB0", Offset = "0x8EADB0", VA = "0x1808EBDB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8EBE10", Offset = "0x8EAE10", VA = "0x1808EBE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B71A0", VA = "0x1808B81A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8B8320", Offset = "0x8B7320", VA = "0x1808B8320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8B8270", Offset = "0x8B7270", VA = "0x1808B8270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8B8380", Offset = "0x8B7380", VA = "0x1808B8380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x8B82B0", Offset = "0x8B72B0", VA = "0x1808B82B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8B81B0", Offset = "0x8B71B0", VA = "0x1808B81B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x952970", Offset = "0x951970", VA = "0x180952970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xECA090", Offset = "0xEC9090", VA = "0x180ECA090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8B8220", Offset = "0x8B7220", VA = "0x1808B8220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8B82D0", Offset = "0x8B72D0", VA = "0x1808B82D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC53E0", Offset = "0xAC43E0", VA = "0x180AC53E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0B90", Offset = "0xABFB90", VA = "0x180AC0B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAB0", Offset = "0x8BDAB0", VA = "0x1808BEAB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA70", Offset = "0x8BDA70", VA = "0x1808BEA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x9517A0", VA = "0x1809527A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BB0", Offset = "0xAC6BB0", VA = "0x180AC7BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x957F50", Offset = "0x956F50", VA = "0x180957F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x956530", Offset = "0x955530", VA = "0x180956530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public MKGNMDNIPHG UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xB470E0", Offset = "0xB460E0", VA = "0x180B470E0")]
			get
			{
				return default(MKGNMDNIPHG);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xB46840", Offset = "0xB45840", VA = "0x180B46840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xB47FF0", Offset = "0xB46FF0", VA = "0x180B47FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xB48470", Offset = "0xB47470", VA = "0x180B48470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6D73560", Offset = "0x6D72560", VA = "0x186D73560")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x6D735A0", Offset = "0x6D725A0", VA = "0x186D735A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D73140", Offset = "0x6D72140", VA = "0x186D73140")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
		public PPEPNMKDOKP BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private FKLOMFJFNCB? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x6D75640", Offset = "0x6D74640", VA = "0x186D75640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
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
