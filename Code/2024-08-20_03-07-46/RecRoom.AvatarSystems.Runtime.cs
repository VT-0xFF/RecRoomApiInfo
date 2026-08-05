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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6851B90", Offset = "0x6850B90", VA = "0x186851B90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[CCEMJNNADFH]
internal class CPAPODFMKNL : IFKOIJCCJJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct AAEMAJCADLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CPAPODFMKNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public IOPEHOFLEFL avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LBMFHHPLPDD CLFMPFPFCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MMAFMCJCMPD OGKHMEOJKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly COFMKOEBBLF MJMPLKAOMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HFHGPPMHDBH KCJIGLIAAAO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68356D0", Offset = "0x68346D0", VA = "0x1868356D0")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.GameOnly)]
	[UsedImplicitly]
	private static void AHAHFCAOJFB(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6836EC0", Offset = "0x6835EC0", VA = "0x186836EC0")]
	[Preserve]
	internal CPAPODFMKNL([JONIFKKOOAA(null)] LBMFHHPLPDD CLFMPFPFCFL, [JONIFKKOOAA(null)] MMAFMCJCMPD OGKHMEOJKKN, [JONIFKKOOAA(null)] COFMKOEBBLF MJMPLKAOMDG, [JONIFKKOOAA(null)] HFHGPPMHDBH KCJIGLIAAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6835740", Offset = "0x6834740", VA = "0x186835740", Slot = "5")]
	public BFOPEDMIDNF EHLMCCCMBDG(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6835FA0", Offset = "0x6834FA0", VA = "0x186835FA0", Slot = "4")]
	public BFOPEDMIDNF LNIFBPCLCOD(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6836DB0", Offset = "0x6835DB0", VA = "0x186836DB0", Slot = "6")]
	public KDCJMIKEAAI OBNIJKNPPNE(BFOPEDMIDNF AHGAPHMJDIB, int DFJEFGPHPMN, string? CKEJJGPNKGO, string? JPNADFLILCL, IBMJBLBOIAO EDAPJBNJBMN, List<EMEKMPJCNKD>? MPBHPEBLNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6835F10", Offset = "0x6834F10", VA = "0x186835F10", Slot = "7")]
	public bool GBCDEFHCMPG(IFEGPOPBOAE MHBGFKNOHLK, [Out] BFOPEDMIDNF? DJCHDINKLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6836CD0", Offset = "0x6835CD0", VA = "0x186836CD0", Slot = "8")]
	public bool NPNJBNMPBLG(KDCJMIKEAAI APGMLMGENDO, [Out] BFOPEDMIDNF? DJCHDINKLAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6836C40", Offset = "0x6835C40", VA = "0x186836C40", Slot = "9")]
	public bool NLLGPHMAMPL(KDCJMIKEAAI APGMLMGENDO, [Out] IJFIKDFEFBI? MHBGFKNOHLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29A6520", Offset = "0x29A5520", VA = "0x1829A6520")]
	private bool GNAKPGKJDOI<TInput, TOutput>(TInput MIFEONEPPKP, JJCLDDPGINI<TInput, TOutput> MLFDDBHEOIB, [Out] TOutput? KNFGDDANCCK) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6835520", Offset = "0x6834520", VA = "0x186835520")]
	[CompilerGenerated]
	private KKPMNBPAHMC ACINFDACHNO(FaceFeatureType JODLIPILJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6836960", Offset = "0x6835960", VA = "0x186836960")]
	[CompilerGenerated]
	private KKPMNBPAHMC NHCDLCONPCH(FaceFeatureType JODLIPILJKK, AAEMAJCADLF P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CCEMJNNADFH]
internal class IHEOPANKOGD : LBMFHHPLPDD
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void OEDFEDGGIEK<in TData>(TData DJCHDINKLAB, IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly COFMKOEBBLF MJMPLKAOMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KKGAIAJPKOC JJHGHICMIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OEDFEDGGIEK<BFOPEDMIDNF>?[] CLFMPFPFCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly OEDFEDGGIEK<IJFIKDFEFBI>?[] PJPDPEAGOGK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6850830", Offset = "0x684F830", VA = "0x186850830")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.GameOnly)]
	[UsedImplicitly]
	private static void AHAHFCAOJFB(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68517D0", Offset = "0x68507D0", VA = "0x1868517D0")]
	[Preserve]
	internal IHEOPANKOGD([JONIFKKOOAA(null)] COFMKOEBBLF MJMPLKAOMDG, [JONIFKKOOAA(null)] KKGAIAJPKOC JJHGHICMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6850A00", Offset = "0x684FA00", VA = "0x186850A00", Slot = "4")]
	public bool CCDEBMAPJKE(BFOPEDMIDNF DJCHDINKLAB, IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68508A0", Offset = "0x684F8A0", VA = "0x1868508A0", Slot = "5")]
	public bool CCDEBMAPJKE(IJFIKDFEFBI MHBGFKNOHLK, IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6850D30", Offset = "0x684FD30", VA = "0x186850D30")]
	private void IFEMPNIIMKG(BFOPEDMIDNF DJCHDINKLAB, IReadOnlyList<EMEKMPJCNKD>? PGMBMLICCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6850B00", Offset = "0x684FB00", VA = "0x186850B00")]
	private void FJFBHONEDBE(BFOPEDMIDNF DJCHDINKLAB, IReadOnlyList<EMEKMPJCNKD>? PGMBMLICCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68517A0", Offset = "0x68507A0", VA = "0x1868517A0")]
	private void PLIGBDDEGKA(BFOPEDMIDNF DJCHDINKLAB, IReadOnlyList<EMEKMPJCNKD>? PGMBMLICCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6851770", Offset = "0x6850770", VA = "0x186851770")]
	private void OIBGHMCGNCP(BFOPEDMIDNF DJCHDINKLAB, IReadOnlyList<EMEKMPJCNKD>? PGMBMLICCAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LBMFHHPLPDD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CCDEBMAPJKE(BFOPEDMIDNF DJCHDINKLAB, IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CCDEBMAPJKE(IJFIKDFEFBI MHBGFKNOHLK, IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA);
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
		public ENCAJAEKLFP AnimationPoseType;

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

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68322B0", Offset = "0x68312B0", VA = "0x1868322B0")]
		public void PGNMFHOOJJJ(AnimationPoseSetting ACBLPNJDJBF, float FEDJACEFPEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68323E0", Offset = "0x68313E0", VA = "0x1868323E0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, DEDMMHOGNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
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
		private Vector3? IGOJKNOAMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool BBDPDEBAGDM;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6832400", Offset = "0x6831400", VA = "0x186832400", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6832A00", Offset = "0x6831A00", VA = "0x186832A00", Slot = "4")]
		public void UpdateController(float HEGNCBOIFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF4C3F0", Offset = "0xF4B3F0", VA = "0x180F4C3F0", Slot = "6")]
		public void SetEnabled(bool JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68324A0", Offset = "0x68314A0", VA = "0x1868324A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6832E90", Offset = "0x6831E90", VA = "0x186832E90")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, DEDMMHOGNPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float DACFMBHAAMJ = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
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
		private Vector3 PEEANPACIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 DIILGEINDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool BBDPDEBAGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float HBFHDNHEANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float BPDHMBGEJFB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6833210", Offset = "0x6832210", VA = "0x186833210", Slot = "4")]
		public void UpdateController(float HEGNCBOIFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA20260", Offset = "0xA1F260", VA = "0x180A20260", Slot = "6")]
		public void SetEnabled(bool JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6832F30", Offset = "0x6831F30", VA = "0x186832F30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6833CD0", Offset = "0x6832CD0", VA = "0x186833CD0")]
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
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68345F0", Offset = "0x68335F0", VA = "0x1868345F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68345B0", Offset = "0x68335B0", VA = "0x1868345B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6833D00", Offset = "0x6832D00", VA = "0x186833D00")]
		private void MLIGHJPCFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67FDEF0", Offset = "0x67FCEF0", VA = "0x1867FDEF0", Slot = "4")]
		public void SetEnabled(bool HFODIMENHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6834620", Offset = "0x6833620", VA = "0x186834620")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarForearmRollController : MonoBehaviour, DEDMMHOGNPA
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
		private float HBFHDNHEANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool BBDPDEBAGDM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6834660", Offset = "0x6833660", VA = "0x186834660", Slot = "4")]
		public void UpdateController(float HEGNCBOIFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEDF440", Offset = "0xEDE440", VA = "0x180EDF440", Slot = "6")]
		public void SetEnabled(bool JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68350F0", Offset = "0x68340F0", VA = "0x1868350F0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HandDisplaySettings HandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x331")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6835160", Offset = "0x6834160", VA = "0x186835160")]
		public AnimationPoseSetting CPLDMIIGFCK(ENCAJAEKLFP GDDHPELOCKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6835120", Offset = "0x6834120", VA = "0x186835120")]
		public void BEDHOPCKIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6835190", Offset = "0x6834190", VA = "0x186835190")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
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

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6838770", Offset = "0x6837770", VA = "0x186838770")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IGOIBENKFKJ : NJBLEJAEGEO
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static int IGPHJJPFOJO;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int CMHLKIGCHNH;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int MFDLMADBODP;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int NBHKMDNPIEF;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int AHHDCJALHLC;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static int MDCAAPJLDLC;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int MBDNLPBGLMI;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int[] FBKDKLIBDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private LMKNIEHFCOD DHJPAPEDIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private FJEOPFIGLGA IGAFEOMFBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int CBABPBMONFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float NNMCGOEODBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Animator BEBKBIKEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AvatarFullBodyConfiguration IKDEHFOEGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int LHKNIGNEEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private int AMFOJHJHJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int FOFJHHLKCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool AMKEBDMDCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private GNNDNJBMDJG CCOELMDAEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int KPOEJAPGLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private float BONBMMICAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private HandDisplaySettings LFPNFLBMLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IOPEHOFLEFL OHCFCIIDDPB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform AGGANMFHDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 DPBOEKGIGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xEE56C0", Offset = "0xEE46C0", VA = "0x180EE56C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xEE5840", Offset = "0xEE4840", VA = "0x180EE5840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion PCMJNINJDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x12B23A0", Offset = "0x12B13A0", VA = "0x1812B23A0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F7EB40", Offset = "0x1F7DB40", VA = "0x181F7EB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool DMLJGGDDKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68504A0", Offset = "0x684F4A0", VA = "0x1868504A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x684FD70", Offset = "0x684ED70", VA = "0x18684FD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 GHALGDNEAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xCB52A0", Offset = "0xCB42A0", VA = "0x180CB52A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCB3440", Offset = "0xCB2440", VA = "0x180CB3440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion HMOOGEBNABI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99B460", Offset = "0x99A460", VA = "0x18099B460", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xCB4570", Offset = "0xCB3570", VA = "0x180CB4570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JFCDGCENLLI KJAHPOCKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xEC4BD0", Offset = "0xEC3BD0", VA = "0x180EC4BD0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(JFCDGCENLLI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xEC36A0", Offset = "0xEC26A0", VA = "0x180EC36A0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JFCDGCENLLI ODEDAFIKAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x139DFB0", Offset = "0x139CFB0", VA = "0x18139DFB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(JFCDGCENLLI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x19E4A00", Offset = "0x19E3A00", VA = "0x1819E4A00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float EKIIBJIFEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x143E350", Offset = "0x143D350", VA = "0x18143E350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x143BB20", Offset = "0x143AB20", VA = "0x18143BB20", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LIMMFFBONGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6850520", Offset = "0x684F520", VA = "0x186850520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DHLMCKFKNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6850210", Offset = "0x684F210", VA = "0x186850210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FMBALGJDDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x684FDC0", Offset = "0x684EDC0", VA = "0x18684FDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MEFKCCOMIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x684FD50", Offset = "0x684ED50", VA = "0x18684FD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6850220", Offset = "0x684F220", VA = "0x186850220", Slot = "21")]
	public void LFNNOPDGNGK(LMKNIEHFCOD AFLKKDMHNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68504D0", Offset = "0x684F4D0", VA = "0x1868504D0")]
	public void NLENINNCGGF(FJEOPFIGLGA DPCGJHFICJI, HandDisplaySettings MCEFNBMGMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6850180", Offset = "0x684F180", VA = "0x186850180", Slot = "12")]
	public void KMHDAPHDAPF(bool AJNJOGNFDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x684FA10", Offset = "0x684EA10", VA = "0x18684FA10", Slot = "11")]
	public void ADCNNEADJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x684FE70", Offset = "0x684EE70", VA = "0x18684FE70")]
	private int IOMAIGHBDEM(JFCDGCENLLI KEGOFLCGPFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6850030", Offset = "0x684F030", VA = "0x186850030")]
	private void JMIOOGODING(int CINPDEALOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6850530", Offset = "0x684F530", VA = "0x186850530", Slot = "13")]
	public bool PMLHLFLOODF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x684FE20", Offset = "0x684EE20", VA = "0x18684FE20", Slot = "14")]
	public bool GILFLPDPHBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x684FDD0", Offset = "0x684EDD0", VA = "0x18684FDD0")]
	private JFCDGCENLLI GFPIKJMOJOH()
	{
		return default(JFCDGCENLLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x10F2CF0", Offset = "0x10F1CF0", VA = "0x1810F2CF0", Slot = "15")]
	public void BLOILPKCLCG(bool AJNJOGNFDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x684FE30", Offset = "0x684EE30", VA = "0x18684FE30", Slot = "10")]
	public void IHJDHFGLMEC(int CINPDEALOKD, float BODANBEFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x684FDA0", Offset = "0x684EDA0", VA = "0x18684FDA0", Slot = "8")]
	public void FFMBLOLDALE(GNNDNJBMDJG JKKAFCBPEPF, bool HHLLKDECJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x684FD60", Offset = "0x684ED60", VA = "0x18684FD60", Slot = "9")]
	public void BKOKOFGNMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6850450", Offset = "0x684F450", VA = "0x186850450", Slot = "16")]
	public void MFOFCNFHDJF(Transform EMOKCJBMKOL, Vector3 JPDGHEOKABK, Quaternion BDGPCMOCBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6850820", Offset = "0x684F820", VA = "0x186850820")]
	public IGOIBENKFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class IDPDNIPJBJE : LPHGLBHEBKF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class OIDCENFOHFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 MJFHCKGIJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Quaternion AMOMOPJFLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Vector3 HBCAJGADIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Transform NLDNDEOOAFA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 CGAIKFOALPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1488B10", Offset = "0x1487B10", VA = "0x181488B10")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1488B30", Offset = "0x1487B30", VA = "0x181488B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion DNOEOEPCBLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xBFF250", Offset = "0xBFE250", VA = "0x180BFF250")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xBFEC40", Offset = "0xBFDC40", VA = "0x180BFEC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float HLJALOLJBJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x99B550", Offset = "0x99A550", VA = "0x18099B550")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xF7DF30", Offset = "0xF7CF30", VA = "0x180F7DF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool OJLAECICOPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8518F0", Offset = "0x8508F0", VA = "0x1808518F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x851900", Offset = "0x850900", VA = "0x180851900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool JHMFDIDGHAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x851610", Offset = "0x850610", VA = "0x180851610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x8507E0", VA = "0x1808517E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool HFNNFOMHINN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x851870", Offset = "0x850870", VA = "0x180851870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x851890", Offset = "0x850890", VA = "0x180851890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float DGLICEAELIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x99B580", Offset = "0x99A580", VA = "0x18099B580")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x25C72A0", Offset = "0x25C62A0", VA = "0x1825C72A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6851CE0", Offset = "0x6850CE0", VA = "0x186851CE0")]
		public void ICBGLINMLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6852020", Offset = "0x6851020", VA = "0x186852020")]
		public void LPAHGPIBLLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6852030", Offset = "0x6851030", VA = "0x186852030")]
		public float MBPPJCONFJM(Transform LDBIHCMBCGJ, [In] FootSettings PKCLHFPHIFL, float KPAHKGMGHKM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6852200", Offset = "0x6851200", VA = "0x186852200")]
		public void MCAAHGCCNCA(Transform FDLALAFMILN, Transform EPGEPHGNBKF, float NJIHDAACONP, bool LGGFOFHKEMH, bool OCPLFMMGBOK, float GLCHJJFLLMB, float JKJJEGAOCDE, Transform JMCFDCHCIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6851CF0", Offset = "0x6850CF0", VA = "0x186851CF0")]
		public void ICNKPKLFICO(Transform ADLBPHPCMEO, Transform JMCFDCHCIPI, bool DIEPFBHIIFA, bool BPKBBAEJGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6851F20", Offset = "0x6850F20", VA = "0x186851F20")]
		private void LJGOMGHGBGP(Transform JMCFDCHCIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6851C10", Offset = "0x6850C10", VA = "0x186851C10")]
		public void ABJLFFPOOCB(Transform JMCFDCHCIPI, AvatarFullBodyConfiguration IOPKIGDDBDF, Vector3 HJIHDAGMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6852960", Offset = "0x6851960", VA = "0x186852960")]
		public void NOBHIPOJGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6852970", Offset = "0x6851970", VA = "0x186852970")]
		public OIDCENFOHFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class FAODCMNADJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float POMADMMCALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool NDEMMOJMAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AnimationPoseSetting FGADLMGJGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float IHIBFDGFIDM;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6838540", Offset = "0x6837540", VA = "0x186838540")]
		public void HGOEMOBEGDP(IKSolverVR.Arm KHBANLFJMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6838570", Offset = "0x6837570", VA = "0x186838570")]
		public void HLECBPFAMKD(IKSolverVR.Arm KHBANLFJMFC, float EJGHPIIJDPE, bool NDEMMOJMAFG, AvatarFullBodyConfiguration IOPKIGDDBDF, float DLAAPEHMBOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x68376A0", Offset = "0x68366A0", VA = "0x1868376A0")]
		private void CJGOENEGOJJ(IKSolverVR.Arm KHBANLFJMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6837CE0", Offset = "0x6836CE0", VA = "0x186837CE0")]
		public void EPIJGKEMFPN(IKSolverVR.Arm KHBANLFJMFC, Transform EODFCNIDOFD, Transform EPGEPHGNBKF, Quaternion LBBIEJOEFPO, Vector3 DHIGNEDKIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68370B0", Offset = "0x68360B0", VA = "0x1868370B0")]
		private (Vector3, Quaternion) BDFIJPFKHEO(IGOIBENKFKJ AMCEGCDKHGN, Quaternion GBLLOEIMJMA, Vector3 NPLIOGEIOLA)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6837540", Offset = "0x6836540", VA = "0x186837540")]
		public void CFFFAKJGLEI(IGOIBENKFKJ AMCEGCDKHGN, IKSolverVR.Arm KHBANLFJMFC, Quaternion GBLLOEIMJMA, Vector3 NPLIOGEIOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x68376E0", Offset = "0x68366E0", VA = "0x1868376E0")]
		public void CNLBIDLAJKF(IGOIBENKFKJ AMCEGCDKHGN, IKSolverVR.Arm KHBANLFJMFC, Quaternion GBLLOEIMJMA, Vector3 NPLIOGEIOLA, [In] AvatarFullBodyConfiguration IOPKIGDDBDF, [In] DNNABOCPAMM JKKAFCBPEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x68385B0", Offset = "0x68375B0", VA = "0x1868385B0")]
		public void MLLEHLIKGNI(ENCAJAEKLFP NHIDHOBDMCM, AvatarFullBodyConfiguration IOPKIGDDBDF, DNNABOCPAMM JKKAFCBPEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x68380C0", Offset = "0x68370C0", VA = "0x1868380C0")]
		public void FPLCNBHJDOA(IKSolverVR.Arm KHBANLFJMFC, Transform EODFCNIDOFD, Vector3 LFGIBNOJODB, float HONNNJLAOFN, Quaternion CLCGLCNIAEB, Vector3 OIMEDEFMJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x68386F0", Offset = "0x68376F0", VA = "0x1868386F0")]
		public FAODCMNADJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum OEPBLDMILOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int JHKPNGNMPCH;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int IKFHDLJJCNG;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int DMKMIIKDGHG;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int JONINEHKMPP;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int BKCNEDODOMM;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int ANHHIHONKMJ;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int KFGJNBJJMII;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int AKEPKCCKMMN;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int JCNOOBNDHMC;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int MMIKFMIHFAM;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int GEFLMAFGAJH;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int AINFMBFDJGO;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int FDLHKIMBDEN;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int MBEAKNKILCN;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int PPNONEGMIDF;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int DCEIPFBHGIN;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int BIDFNADKEAE;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int EALOJEAJAFF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int AGPNOLAGEBE;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int FPMENAHBJKI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int DCKHEIEFMMG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int HKLHFDHGIBD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int OOACFMOAHHP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int ICBCJFHONJL;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int OBEFLNHPHAD;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int CNGLEFPCOPG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int EIFBAAPCLPD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int FFFLFFOCHBF;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int DABDFFLFHDO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly Vector3 DGHEKBDIJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool EEIBBBAGJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool EMCHKLPADBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool AKHFPHJJDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool JACGIMLLEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool NJFPHGLOACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Vector3 DGOKMPEANED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private string LBCJKIKFEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private LOMOONDMIAH? DHJPAPEDIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NKBHCJGAMCO? BCDFAAHCEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private LOFDAKFIBBN EBFGOHOKNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private LKCJLEMCIII NLIOMMNHIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private IGOIBENKFKJ LJJKCCHHHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private IGOIBENKFKJ AIMELLKLMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool BFMMCGAGLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool CBFPPDDJOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly KGCNKDMJNKK MGFPOCFIKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly LBHMAEFHMCP MFAIMGPBCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int JNPFNLBAJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private float FFIAHCKAFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private GameObject JMPGLICIALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Transform EDNBGCDPLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform HEMGJJMEAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Transform GAMADECACGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform FDEFAFLOALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform JDEKGCLIOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float HKFPJEENFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float NAKLGEFOCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Vector3 HCOMLDCDMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Quaternion LPKEJMPCIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform LJAOLNICMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform LOAFOLFELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform MNILENNGHLP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker DECONFKHGFI;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker NFHCFLKMMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private ProfilerMarker HEMOBJHCJOH;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker FLKLOLLGCBD;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker IKLJIEFANFP;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker MKGDABHINHG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly List<IDPDNIPJBJE> HEDBJCJPIKB;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int CGMIDNMLCKD;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> IGNBIHNJDHE;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int DCOOGFOKIOI;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int HFGDPBAEGGF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int AKHNCFGAJLN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int CLLPEBOHDPD;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static float GHKBJJHCJEP;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int NMPIBMKFJGF;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static float KKAFHKOPPDP;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static float GEGMNPAABFI;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float IPIGPKBKGFF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static float MIANOKFJIMM;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static MHNCDDDHJAP OMMDHFLHGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float MKDLPMDAGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool IPOEHPCCFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float KKDNHGIFPHI;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly int AEJBJBKPDPB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly int HIBFKOKIHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private OIDCENFOHFK BIGCFCCFGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private OIDCENFOHFK BBGFNEKBPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private float FCCJEDLMAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Vector3 EFEMEOJNBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private Vector3 OBMMFJMIJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool GFCBJIKMMON;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly Quaternion CGJOJNIPAHA;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly Quaternion KMPODMAEHNE;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly Vector3 DHGIGAEHJCP;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly Vector3 HLNFLJMPOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float PEMODDCCJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float EHCFKAKDJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private FAODCMNADJE OKPCEMPFLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private FAODCMNADJE HCEOCNIOFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private DNGMAMCELGD EGCCHCGFJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private LAILEFLFDPP EPKKCOECENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly DJKOCJJPMEF BNPFPEPAFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float FGAHHDPMJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float AMBLIGPFFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly LAILEFLFDPP LEGEEDNEGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 DBNCMHAPEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 OKIIPDIODOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float MICNDIBNFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private float IENMEDGFALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly LAILEFLFDPP LKDHLPIGGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly DNGMAMCELGD GFPLNLGAGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly LAILEFLFDPP KNAMAPGKKPP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PEHINEDJEEO OOEDAAFMJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PEHINEDJEEO PKLDNDHFBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration JINEJFFAFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x683FF80", Offset = "0x683EF80", VA = "0x18683FF80", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IOPEHOFLEFL GOHICGHDCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x684BC80", Offset = "0x684AC80", VA = "0x18684BC80", Slot = "23")]
		get
		{
			return default(IOPEHOFLEFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration PLGPKCFEKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x684B1B0", Offset = "0x684A1B0", VA = "0x18684B1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform LHILBOPKDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6842140", Offset = "0x6841140", VA = "0x186842140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform JIIIIICMADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6846FE0", Offset = "0x6845FE0", VA = "0x186846FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer LOLHHNDNLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6844000", Offset = "0x6843000", VA = "0x186844000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] ENNHGODKEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x684B030", Offset = "0x684A030", VA = "0x18684B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] PEICJFKKCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x683E300", Offset = "0x683D300", VA = "0x18683E300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator HGLFKAFFBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68400D0", Offset = "0x683F0D0", VA = "0x1868400D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK MAFFLGKLLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68499F0", Offset = "0x68489F0", VA = "0x1868499F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private DEDMMHOGNPA CJHJNNFFDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68459E0", Offset = "0x68449E0", VA = "0x1868459E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private DEDMMHOGNPA AGOFBAOIONO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x684B310", Offset = "0x684A310", VA = "0x18684B310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private DEDMMHOGNPA KBCEAKDEKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x683E7A0", Offset = "0x683D7A0", VA = "0x18683E7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private DEDMMHOGNPA CIIKNBBGCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x683CB70", Offset = "0x683BB70", VA = "0x18683CB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private DEDMMHOGNPA AOEFLIABHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6842240", Offset = "0x6841240", VA = "0x186842240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private DEDMMHOGNPA PBBLIIOKBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x683E8F0", Offset = "0x683D8F0", VA = "0x18683E8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private DEDMMHOGNPA AOEDBMNANLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68401D0", Offset = "0x683F1D0", VA = "0x1868401D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private DEDMMHOGNPA EBGGLEHBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6842890", Offset = "0x6841890", VA = "0x186842890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public NKBHCJGAMCO OLINDDDLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68445F0", Offset = "0x68435F0", VA = "0x1868445F0", Slot = "15")]
		get
		{
			return default(NKBHCJGAMCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CBMBHBAHCAO IILBBCHFLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xE86890", Offset = "0xE85890", VA = "0x180E86890", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public AEPBOLAKNAO APKDAOGNEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x14E0890", Offset = "0x14DF890", VA = "0x1814E0890", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public NJBLEJAEGEO BAEKGHFKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1156980", Offset = "0x1155980", VA = "0x181156980", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public NJBLEJAEGEO NMEKNGJPKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x14E0C80", Offset = "0x14DFC80", VA = "0x1814E0C80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string PHGLDKIBFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform PCCPILBMHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x684EAF0", Offset = "0x684DAF0", VA = "0x18684EAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform OIMLJKABNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6839C00", Offset = "0x6838C00", VA = "0x186839C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform HMMGMHNDPBH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6847B60", Offset = "0x6846B60", VA = "0x186847B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool FJKDJICHLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68388E0", Offset = "0x68378E0", VA = "0x1868388E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform KOMHBIOAKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x684E3F0", Offset = "0x684D3F0", VA = "0x18684E3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject IDHOMJBMFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x684E750", Offset = "0x684D750", VA = "0x18684E750", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets LKJFMBMNPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x684B130", Offset = "0x684A130", VA = "0x18684B130", Slot = "31")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform JKHGLPODEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xBF8460", Offset = "0xBF7460", VA = "0x180BF8460", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform AFHEOAFNPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBF76D0", Offset = "0xBF66D0", VA = "0x180BF76D0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform NAGLLHEDODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4450", Offset = "0x1AA3450", VA = "0x181AA4450", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform HCJFOAAGPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x13D2CA0", Offset = "0x13D1CA0", VA = "0x1813D2CA0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 HNKKHBIFMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x683FD20", Offset = "0x683ED20", VA = "0x18683FD20", Slot = "36")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float NEENLFNLBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6840080", Offset = "0x683F080", VA = "0x186840080", Slot = "37")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform NLBEDCIBDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6838FE0", Offset = "0x6837FE0", VA = "0x186838FE0", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform HMJHJPCKCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x17B5530", Offset = "0x17B4530", VA = "0x1817B5530", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform FAPDICNCNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x17B5600", Offset = "0x17B4600", VA = "0x1817B5600", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform KAGFFKLKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x13D3880", Offset = "0x13D2880", VA = "0x1813D3880", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool FGKMJIBHPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6844110", Offset = "0x6843110", VA = "0x186844110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool KDBIBDCNKMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x683A2D0", Offset = "0x68392D0", VA = "0x18683A2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool HDJCKFDNAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x68475A0", Offset = "0x68465A0", VA = "0x1868475A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6847BD0", Offset = "0x6846BD0", VA = "0x186847BD0")]
	private void MBMCGDEFKJF([In] DNNABOCPAMM KEGGJFLHGDD, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68424F0", Offset = "0x68414F0", VA = "0x1868424F0")]
	private void IEHFJAOIBJH(DNNABOCPAMM KEGGJFLHGDD, AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6844DC0", Offset = "0x6843DC0", VA = "0x186844DC0")]
	private void KGFPHEFHHHM([In] DNNABOCPAMM JKKAFCBPEPF, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x684F560", Offset = "0x684E560", VA = "0x18684F560")]
	public IDPDNIPJBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x683BF10", Offset = "0x683AF10", VA = "0x18683BF10", Slot = "12")]
	public void CECDMPLKOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x683CE20", Offset = "0x683BE20", VA = "0x18683CE20", Slot = "13")]
	public void CMNLFHFLELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6839C70", Offset = "0x6838C70", VA = "0x186839C70", Slot = "14")]
	public void BHOGODJLPFC(bool NFAMAFLDOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x68498A0", Offset = "0x68488A0", VA = "0x1868498A0", Slot = "25")]
	public Transform MHIPMIOAACA(string AADAMINMMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x684DDB0", Offset = "0x684CDB0", VA = "0x18684DDB0", Slot = "26")]
	public Vector3? ONBBEKJFCOL(string AADAMINMMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x683F600", Offset = "0x683E600", VA = "0x18683F600", Slot = "7")]
	public void FHOGIGECKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6839D40", Offset = "0x6838D40", VA = "0x186839D40")]
	private void BIGNGDLFKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x68429E0", Offset = "0x68419E0", VA = "0x1868429E0", Slot = "6")]
	public void JEDPHAOGBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x684E380", Offset = "0x684D380", VA = "0x18684E380", Slot = "8")]
	public void OPOBLMBKGII(float FNIFIKKLIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6842990", Offset = "0x6841990", VA = "0x186842990")]
	private void JBCLAOIKFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x684BE60", Offset = "0x684AE60", VA = "0x18684BE60", Slot = "4")]
	public void OLNOJBKFKMF(string ONGEAHPAIAB, LOMOONDMIAH HIIGNFKEHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x68470E0", Offset = "0x68460E0", VA = "0x1868470E0", Slot = "5")]
	public void LJACJEFLKMF(NKBHCJGAMCO DPCGJHFICJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x683EF90", Offset = "0x683DF90", VA = "0x18683EF90", Slot = "11")]
	public void EJEBAPBFFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x683E400", Offset = "0x683D400", VA = "0x18683E400", Slot = "24")]
	public void DFPOLKLMBHE([Out] Vector3 PPCKGGELNKA, [Out] Quaternion CLCGLCNIAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6844260", Offset = "0x6843260", VA = "0x186844260")]
	private void KBOJKFGDPED([In] DNNABOCPAMM JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6844100", Offset = "0x6843100", VA = "0x186844100", Slot = "27")]
	public void JHAHOBPNNIE(float GGFBCMGLHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6844290", Offset = "0x6843290", VA = "0x186844290", Slot = "28")]
	public void KCMKHJPMLMB(float KKMPHHDHBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x68387B0", Offset = "0x68377B0", VA = "0x1868387B0", Slot = "43")]
	public void ABBCNFOMOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6844210", Offset = "0x6843210", VA = "0x186844210", Slot = "29")]
	public HandLogicOffsets JKDKNLBEDHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x683FDB0", Offset = "0x683EDB0", VA = "0x18683FDB0", Slot = "30")]
	public PlatformSpecificPlayerHandOffsets FPLAOOKAHGM()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6838B00", Offset = "0x6837B00", VA = "0x186838B00")]
	private void AFLHCIHKJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6843BD0", Offset = "0x6842BD0", VA = "0x186843BD0")]
	private void JEGOABKOEKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x683E9F0", Offset = "0x683D9F0", VA = "0x18683E9F0")]
	private void EACBHDIIBGH(FKKFNKHOOAA JNLJBFMPBGD, bool PANBHGCACAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x683A110", Offset = "0x6839110", VA = "0x18683A110")]
	private void BMCBLEGBPKA(FKKFNKHOOAA JNLJBFMPBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x683E8A0", Offset = "0x683D8A0", VA = "0x18683E8A0")]
	public Vector3 DJHKHDMDFLJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6838C50", Offset = "0x6837C50", VA = "0x186838C50")]
	private void AIGPHJPEPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x684DD90", Offset = "0x684CD90", VA = "0x18684DD90")]
	private void OMKNCOKPNON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x683F400", Offset = "0x683E400", VA = "0x18683F400")]
	private float FFGKHPFKIDL([In] DNNABOCPAMM JKKAFCBPEPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x684BD80", Offset = "0x684AD80", VA = "0x18684BD80")]
	private int OLHGACCILOB([In] EMAOLFJIJBD MKJCEGABDJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x68407B0", Offset = "0x683F7B0", VA = "0x1868407B0")]
	private void HAJLEPONPFK(DNNABOCPAMM KEGGJFLHGDD, bool DBGLEPKMCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6839EF0", Offset = "0x6838EF0", VA = "0x186839EF0")]
	private static void BKGFKLNGLEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6845CB0", Offset = "0x6844CB0", VA = "0x186845CB0")]
	private static void LFHNKJLHAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6839790", Offset = "0x6838790", VA = "0x186839790")]
	private float AOBNPLNMHHE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x683F080", Offset = "0x683E080", VA = "0x18683F080")]
	private static int ELLFJNDLNND(IDPDNIPJBJE OHFIHFHICKK, IDPDNIPJBJE CENGDJBMKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6840420", Offset = "0x683F420", VA = "0x186840420", Slot = "39")]
	public DNNABOCPAMM GJGELCCJKEF()
	{
		return default(DNNABOCPAMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6842100", Offset = "0x6841100", VA = "0x186842100")]
	public void HNDAOFKCNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6840580", Offset = "0x683F580", VA = "0x186840580")]
	private (bool, bool) GPONDKEEACF()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x683A350", Offset = "0x6839350", VA = "0x18683A350")]
	private void BPGMCOAFPHB([In] DNNABOCPAMM JKKAFCBPEPF, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6849470", Offset = "0x6848470", VA = "0x186849470")]
	private void MEKPEBEDAKM([In] DNNABOCPAMM JKKAFCBPEPF, [In] AvatarFullBodyConfiguration IOPKIGDDBDF, FootSettings PKCLHFPHIFL, bool FOKGHCKEIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6849AF0", Offset = "0x6848AF0", VA = "0x186849AF0")]
	private float MNPNDFIOLMB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x68410F0", Offset = "0x68400F0", VA = "0x1868410F0")]
	private void HDFBKIBNDFJ(DNNABOCPAMM JKKAFCBPEPF, AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x683F5B0", Offset = "0x683E5B0", VA = "0x18683F5B0")]
	private float FHBLJOIAEJO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x68448D0", Offset = "0x68438D0", VA = "0x1868448D0")]
	private void KFNCBOHLDOH([In] DNNABOCPAMM JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x683F0B0", Offset = "0x683E0B0", VA = "0x18683F0B0")]
	private void EPIJGKEMFPN([In] DNNABOCPAMM JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x68469C0", Offset = "0x68459C0", VA = "0x1868469C0")]
	private void LFMBPBGFOKG([In] DNNABOCPAMM JKKAFCBPEPF, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x68394E0", Offset = "0x68384E0", VA = "0x1868394E0")]
	private void AMCGDOLGNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x684E4F0", Offset = "0x684D4F0", VA = "0x18684E4F0")]
	private void PFAEDGAKDFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x68479C0", Offset = "0x68469C0", VA = "0x1868479C0")]
	private void LOKFBFOKHJN([In] DNNABOCPAMM JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6839970", Offset = "0x6838970", VA = "0x186839970")]
	private void BAPLDKKBBDA(IGOIBENKFKJ AGHNGAAOHIA, IKSolverVR.Arm KHBANLFJMFC, Transform AEICEDGJHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x683B680", Offset = "0x683A680", VA = "0x18683B680")]
	private void CDJCAHIGMKM(DNNABOCPAMM JKKAFCBPEPF, AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6838930", Offset = "0x6837930", VA = "0x186838930")]
	private void ADCNNEADJCB(AFFIOPDABJN HBMEEHDJAHH, NJBLEJAEGEO AGHNGAAOHIA, IKSolverVR.Arm KHBANLFJMFC, float EJGHPIIJDPE, float ODPHNIFKEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x684A980", Offset = "0x6849980", VA = "0x18684A980")]
	private void NBJKFJIKEHP([In] DNNABOCPAMM JKKAFCBPEPF, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x683D1E0", Offset = "0x683C1E0", VA = "0x18683D1E0")]
	protected void CMODGOBLDML([In] DNNABOCPAMM JKKAFCBPEPF, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6838D00", Offset = "0x6837D00", VA = "0x186838D00")]
	private void AILCOCDBNEM([In] DNNABOCPAMM JKKAFCBPEPF, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x683ECD0", Offset = "0x683DCD0", VA = "0x18683ECD0")]
	protected void ECHAMCIOLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x683D5E0", Offset = "0x683C5E0", VA = "0x18683D5E0")]
	private void COIDKPPEKKA([In] DNNABOCPAMM JKKAFCBPEPF, [In] OEPBLDMILOA MPGBPAPJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x683CC70", Offset = "0x683BC70", VA = "0x18683CC70")]
	private void CLHNCNGOKIL(DNNABOCPAMM JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6846FA0", Offset = "0x6845FA0", VA = "0x186846FA0")]
	private void LGJKPCIDNAN([In] DNNABOCPAMM JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6841B70", Offset = "0x6840B70", VA = "0x186841B70")]
	private Vector3 HHIEAEFFJPB([In] DNNABOCPAMM JKKAFCBPEPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6842030", Offset = "0x6841030", VA = "0x186842030")]
	private void HMMFILPEHKB([In] DNNABOCPAMM JKKAFCBPEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x684A540", Offset = "0x6849540", VA = "0x18684A540")]
	private float NAMLFJGGNEF(float JKJJEGAOCDE, [In] DNNABOCPAMM JKKAFCBPEPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68402D0", Offset = "0x683F2D0", VA = "0x1868402D0")]
	private void GHJPCACMBID(float JKJJEGAOCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6839040", Offset = "0x6838040", VA = "0x186839040")]
	private void ALOBPAMIJOI([In] DNNABOCPAMM JKKAFCBPEPF, OEPBLDMILOA MPGBPAPJHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x683DD70", Offset = "0x683CD70", VA = "0x18683DD70")]
	private float COMIFAHCBEB([In] DNNABOCPAMM KEGGJFLHGDD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x683B9F0", Offset = "0x683A9F0", VA = "0x18683B9F0")]
	private void CDOPOHAGCCB(DNNABOCPAMM JKKAFCBPEPF, OEPBLDMILOA MPGBPAPJHMC, Vector3 IHNCOIGLAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6842340", Offset = "0x6841340", VA = "0x186842340")]
	private static void IEFGCFMFAEL(Transform DBCCBLKNBHK, Quaternion BCKIPOGEHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x684E7F0", Offset = "0x684D7F0", VA = "0x18684E7F0")]
	private void POFAMAIMEMA([In] DNNABOCPAMM IHOKOJNPFIO, [In] EMAOLFJIJBD MKJCEGABDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x684B410", Offset = "0x684A410", VA = "0x18684B410")]
	private void OANACNNLNEI([In] DNNABOCPAMM IHOKOJNPFIO, [In] EMAOLFJIJBD MKJCEGABDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6844720", Offset = "0x6843720", VA = "0x186844720")]
	private void KEBDGBINAIA(float AOKOPGMBLDC, [In] DNNABOCPAMM KEGGJFLHGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x683C430", Offset = "0x683B430", VA = "0x18683C430")]
	private float CGACLNCKJNA([In] DNNABOCPAMM KEGGJFLHGDD, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6844F90", Offset = "0x6843F90", VA = "0x186844F90")]
	private void KJBBMJCGNIF([In] DNNABOCPAMM KEGGJFLHGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6845200", Offset = "0x6844200", VA = "0x186845200")]
	private void KJKGPBKLENL([In] DNNABOCPAMM KEGGJFLHGDD, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6847620", Offset = "0x6846620", VA = "0x186847620")]
	private void LLMEMGGONMO([In] DNNABOCPAMM KEGGJFLHGDD, float JMDABFMLJJK, float DMPEGMFKDJA, Vector3 BKPICMHJMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6849B70", Offset = "0x6848B70", VA = "0x186849B70")]
	private void MPEHFAFJKHK(DNNABOCPAMM KEGGJFLHGDD, AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6840CE0", Offset = "0x683FCE0", VA = "0x186840CE0")]
	private void HCLOFGIDJEA(DNNABOCPAMM KEGGJFLHGDD, AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6845AE0", Offset = "0x6844AE0", VA = "0x186845AE0")]
	public void LCHBOPOAGGL([In] DNNABOCPAMM JKKAFCBPEPF, [In] AvatarFullBodyConfiguration IOPKIGDDBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x684B240", Offset = "0x684A240", VA = "0x18684B240")]
	[CompilerGenerated]
	internal static void NMBJBECDJGH(OIDCENFOHFK LBPFODBEDOD, OIDCENFOHFK ECEILLCJOPB, Transform PDDPOAFIFKE, float EHELKEOJPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x683FE70", Offset = "0x683EE70", VA = "0x18683FE70")]
	[CompilerGenerated]
	internal static bool FPOOLMADGAP(IKSolverVR.Arm KHBANLFJMFC, GOGAGPOIFPC CBHBBLDHHIH, float LHBMICIOMLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x684DF40", Offset = "0x684CF40", VA = "0x18684DF40")]
	[CompilerGenerated]
	internal static float ONIMMPNMMAE(Vector3 BHIEAOONOGH, Vector3 NBJNLKHKLFL, Vector3 NFDLAHGBELF, DNNABOCPAMM KEGGJFLHGDD, AvatarFullBodyConfiguration IOPKIGDDBDF, float BEMLKOBANDO)
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
		public enum NDDEIOLNNID
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private NDDEIOLNNID handleType;

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

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x68554E0", Offset = "0x68544E0", VA = "0x1868554E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x68554A0", Offset = "0x68544A0", VA = "0x1868554A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6854E70", Offset = "0x6853E70", VA = "0x186854E70")]
		private void MLIGHJPCFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67FDEF0", Offset = "0x67FCEF0", VA = "0x1867FDEF0", Slot = "4")]
		public void SetEnabled(bool HFODIMENHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6855510", Offset = "0x6854510", VA = "0x186855510")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, DEDMMHOGNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
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
		private Vector3 PEEANPACIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private Vector3 LCIDMFDNFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Vector3 MMBNDCEHMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Matrix4x4 KOPPJOMMJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool BBDPDEBAGDM;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x68559B0", Offset = "0x68549B0", VA = "0x1868559B0", Slot = "4")]
		public void UpdateController(float HEGNCBOIFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x68559A0", Offset = "0x68549A0", VA = "0x1868559A0", Slot = "6")]
		public void SetEnabled(bool JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6855540", Offset = "0x6854540", VA = "0x186855540")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6856070", Offset = "0x6855070", VA = "0x186856070")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, APJJNBGCGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[Header("Configuration")]
		[SerializeField]
		private IOPEHOFLEFL avatarBodyType;

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
		[SerializeField]
		[IDHMMACJAGM(JFBJMOOHBCL.SelfAndChildren, false, false, false)]
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
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		[Header("Equipment Slots")]
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
		private LPHGLBHEBKF BDJCNHBNJAA;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public LPHGLBHEBKF FAOOKKLBPCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x99B610", Offset = "0x99A610", VA = "0x18099B610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform PNCFGNIGIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6856F00", Offset = "0x6855F00", VA = "0x186856F00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6856080", Offset = "0x6855080", VA = "0x186856080")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6856DC0", Offset = "0x6855DC0", VA = "0x186856DC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6856D70", Offset = "0x6855D70", VA = "0x186856D70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6856D00", Offset = "0x6855D00", VA = "0x186856D00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6856080", Offset = "0x6855080", VA = "0x186856080", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6856500", Offset = "0x6855500", VA = "0x186856500", Slot = "6")]
		public LPHGLBHEBKF CreateAvatarSystem(string ONGEAHPAIAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6856D00", Offset = "0x6855D00", VA = "0x186856D00", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6856130", Offset = "0x6855130", VA = "0x186856130", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6856E10", Offset = "0x6855E10", VA = "0x186856E10", Slot = "9")]
		public void UpdatePostIKAnimControllers(float HEGNCBOIFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Preserve]
internal class GPJHBPJEFJD : EGEIDBIOGEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private Dictionary<string, LPHGLBHEBKF> PDFFBAJHHJO;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6858BC0", Offset = "0x6857BC0", VA = "0x186858BC0")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.None)]
	private static void FLELDFILLEH(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6858CA0", Offset = "0x6857CA0", VA = "0x186858CA0", Slot = "4")]
	public LPHGLBHEBKF MFIOJEMJMFH(string JPBFNCHGKNJ, AvatarSystemConfiguration OFINEABMMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6858EC0", Offset = "0x6857EC0", VA = "0x186858EC0", Slot = "5")]
	public void OJAJKJKNDMN(string JPBFNCHGKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6858A80", Offset = "0x6857A80", VA = "0x186858A80", Slot = "6")]
	public string FIDLJGKIFAO(string DLDMMEANNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6858C30", Offset = "0x6857C30", VA = "0x186858C30")]
	private string KCLHNLPPGPN(string DLDMMEANNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6859040", Offset = "0x6858040", VA = "0x186859040")]
	public GPJHBPJEFJD()
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
		public class OFGFMIHPJDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private Dictionary<string, Transform> EDEAMGPJGKJ;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool KFCLKKNDODJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x685F300", Offset = "0x685E300", VA = "0x18685F300")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x685F180", Offset = "0x685E180", VA = "0x18685F180")]
			public void CBPELELKPKP(VRIK JMNOODFEAJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
			public void KFBNEIOMFNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x685F2B0", Offset = "0x685E2B0", VA = "0x18685F2B0")]
			public void CLDDABPDPLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x685F340", Offset = "0x685E340", VA = "0x18685F340")]
			public OFGFMIHPJDE()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
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
		[FIHOJOMCNEF(JFBJMOOHBCL.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		[IDHMMACJAGM(JFBJMOOHBCL.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly OFGFMIHPJDE PIHGDBHCDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private APJJNBGCGPH IFINJOJAKOK;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6856FA0", Offset = "0x6855FA0", VA = "0x186856FA0")]
		private void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6856F50", Offset = "0x6855F50", VA = "0x186856F50")]
		private bool JEBOOOGBIJK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6857270", Offset = "0x6856270", VA = "0x186857270")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x68572E0", Offset = "0x68562E0", VA = "0x1868572E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6857280", Offset = "0x6856280", VA = "0x186857280")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6857550", Offset = "0x6856550", VA = "0x186857550")]
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
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x68590D0", Offset = "0x68580D0", VA = "0x1868590D0")]
		public void BEDHOPCKIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68591F0", Offset = "0x68581F0", VA = "0x1868591F0")]
		public int OACAIPMFOPJ(int KNNINCGFDPC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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
				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x68593A0", Offset = "0x68583A0", VA = "0x1868593A0")]
			public void BEDHOPCKIAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6859260", Offset = "0x6858260", VA = "0x186859260")]
			public (float, float) AEMCDPJMGDM(Animator NLLNLOGDCFP, AnimatorStateInfo DMNOEHLBHHN)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6859480", Offset = "0x6858480", VA = "0x186859480")]
		public void BEDHOPCKIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6859670", Offset = "0x6858670", VA = "0x186859670")]
		public (float, float) GFJHBBMJAGB(Animator NLLNLOGDCFP)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6859880", Offset = "0x6858880", VA = "0x186859880")]
		private (float, float) IPBKBJABCGJ(Animator NLLNLOGDCFP, AnimatorStateInfo DMNOEHLBHHN)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6859A90", Offset = "0x6858A90", VA = "0x186859A90")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
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

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x685EFF0", Offset = "0x685DFF0", VA = "0x18685EFF0", Slot = "4")]
		public override void OnStateEnter(Animator NLLNLOGDCFP, AnimatorStateInfo DMNOEHLBHHN, int LHOBMDFNKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x685F160", Offset = "0x685E160", VA = "0x18685F160")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal abstract class HAOHALIMAPB<TInput, TOutput> : JJCLDDPGINI<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	protected readonly KKGAIAJPKOC JJHGHICMIMA;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1C40", Offset = "0x3DC0C40", VA = "0x183DC1C40")]
	protected HAOHALIMAPB(KKGAIAJPKOC JJHGHICMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput PPFECFLIGJE(TInput MIFEONEPPKP, [Out] IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1BA0", Offset = "0x3DC0BA0", VA = "0x183DC1BA0", Slot = "5")]
	public bool GNAKPGKJDOI(TInput MIFEONEPPKP, [Out] TOutput? KNFGDDANCCK, [Out] IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[CCEMJNNADFH]
public static class DMMJFMPKMDI
{
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly Regex FCHEFAPLGMO;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x68579C0", Offset = "0x68569C0", VA = "0x1868579C0")]
	public static GJGBCABMIHF MJHFMJKFIEK(DBLDAMEGANG GHFPJGKCCOJ, HAADOMONODM GLPIDKLLEIP, Guid? ODFDMKOEKIK, Color? NOBLMBLOJBA, OELEMBFEEON ODGPAFEGIFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6857850", Offset = "0x6856850", VA = "0x186857850")]
	public static MEDGMGIADBO GHKFDLNDOLL(GJGBCABMIHF AHGAPHMJDIB)
	{
		return default(MEDGMGIADBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2A17F40", Offset = "0x2A16F40", VA = "0x182A17F40")]
	internal static TModern? MIEJGDMNFPN<TModern>(string? MIFEONEPPKP, AGBAKLPNDKD<TModern> DGHOCHECDKP, KKGAIAJPKOC JJHGHICMIMA, MOCPLACHHML DGEGONGKGCM, TModern HKFEFCDBOOC) where TModern : struct, NOOOIIHJIEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2A194B0", Offset = "0x2A184B0", VA = "0x182A194B0")]
	internal static NPEOIHDJLEM PFFHPNFKKBL<TModern>(string? MIFEONEPPKP, AGBAKLPNDKD<TModern> DGHOCHECDKP, KKGAIAJPKOC JJHGHICMIMA, MOCPLACHHML DGEGONGKGCM, TModern HKFEFCDBOOC) where TModern : struct, NOOOIIHJIEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6857700", Offset = "0x6856700", VA = "0x186857700")]
	internal static List<EMEKMPJCNKD> DMMJNEAKNDG(IEnumerable<IFLNGCJELOB>? KBLDPKNNJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2A170D0", Offset = "0x2A160D0", VA = "0x182A170D0")]
	internal static string MDOKKLFLJEG<TModern>(TModern MIFEONEPPKP, AGBAKLPNDKD<TModern> DGHOCHECDKP, KKGAIAJPKOC JJHGHICMIMA) where TModern : NOOOIIHJIEB
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class PLLGKAHGGOJ : MMAFMCJCMPD
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public JJCLDDPGINI<IFEGPOPBOAE, BFOPEDMIDNF> ECCDDACGKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public JJCLDDPGINI<KDCJMIKEAAI, IJFIKDFEFBI> CKFNBBFBOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public JJCLDDPGINI<KDCJMIKEAAI, IJFIKDFEFBI> EBANHIMILBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public HFLLPJNFMBB IMGLDBBIJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public JLHJAKPMELB BDLIPLBFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x685F3D0", Offset = "0x685E3D0", VA = "0x18685F3D0")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.GameOnly)]
	[UsedImplicitly]
	private static void AHAHFCAOJFB(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x685F440", Offset = "0x685E440", VA = "0x18685F440")]
	[Preserve]
	internal PLLGKAHGGOJ([JONIFKKOOAA("UnitySerialization")] GENFEPEFEHM FPJMHDINHCH, [JONIFKKOOAA(null)] JKBNIMMMFLF MBIHEIGBHFI, [JONIFKKOOAA(null)] KKGAIAJPKOC JJHGHICMIMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum LCONMKCNEMC
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
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class COMNDJMLONG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6857670", Offset = "0x6856670", VA = "0x186857670")]
	public COMNDJMLONG(string KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x68576A0", Offset = "0x68566A0", VA = "0x1868576A0")]
	public COMNDJMLONG(string KKHEHGHPOAA, Exception NFGOFCBGHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x68576D0", Offset = "0x68566D0", VA = "0x1868576D0")]
	public COMNDJMLONG(LCONMKCNEMC KLHABFFOPGM, string KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6857630", Offset = "0x6856630", VA = "0x186857630")]
	public COMNDJMLONG(LCONMKCNEMC KLHABFFOPGM, string KKHEHGHPOAA, Exception NFGOFCBGHNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal abstract class AJKGFJBKNAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly GENFEPEFEHM FPJMHDINHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	protected readonly JKBNIMMMFLF MBIHEIGBHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	protected readonly KKGAIAJPKOC JJHGHICMIMA;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x68542F0", Offset = "0x68532F0", VA = "0x1868542F0")]
	protected AJKGFJBKNAF(GENFEPEFEHM FPJMHDINHCH, JKBNIMMMFLF MBIHEIGBHFI, KKGAIAJPKOC JJHGHICMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6852CA0", Offset = "0x6851CA0", VA = "0x186852CA0")]
	protected string GNHLJJGEOPG(BFOPEDMIDNF DJCHDINKLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6852980", Offset = "0x6851980", VA = "0x186852980")]
	protected string BNNIOHGOFOM(BFOPEDMIDNF DJCHDINKLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6853FC0", Offset = "0x6852FC0", VA = "0x186853FC0")]
	private AvatarOutfitSelectionData MJHFMJKFIEK(GJGBCABMIHF DMJOHFGFLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6852B60", Offset = "0x6851B60", VA = "0x186852B60")]
	private static AvatarCustomizationSettingsData.AnchorParams CCABBAGAKIB(MACMOFHFNNF? HDDLOHNNELI)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JJCLDDPGINI<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput PPFECFLIGJE(TInput MIFEONEPPKP, [Out] IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNAKPGKJDOI(TInput MIFEONEPPKP, [Out] TOutput? KNFGDDANCCK, [Out] IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MMAFMCJCMPD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	JJCLDDPGINI<IFEGPOPBOAE, BFOPEDMIDNF> ECCDDACGKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	JJCLDDPGINI<KDCJMIKEAAI, IJFIKDFEFBI> EBANHIMILBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	HFLLPJNFMBB IMGLDBBIJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum MOCPLACHHML
{
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JLHJAKPMELB
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EAELIKELHCC JMNIMAIKKED(BFOPEDMIDNF AHGAPHMJDIB);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface HFLLPJNFMBB
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDCJMIKEAAI JMNIMAIKKED(BFOPEDMIDNF AHGAPHMJDIB, int DFJEFGPHPMN, string? CKEJJGPNKGO, string? JPNADFLILCL, IBMJBLBOIAO EDAPJBNJBMN, List<EMEKMPJCNKD>? MPBHPEBLNCA);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[CCEMJNNADFH]
internal class KCFAJIHAPNP : HAOHALIMAPB<IFEGPOPBOAE, BFOPEDMIDNF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly JKBNIMMMFLF MBIHEIGBHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly KODINMADFOB LIDINNHKNDM;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x685A270", Offset = "0x6859270", VA = "0x18685A270")]
	public KCFAJIHAPNP(GENFEPEFEHM FPJMHDINHCH, JKBNIMMMFLF MBIHEIGBHFI, KKGAIAJPKOC JJHGHICMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6859FC0", Offset = "0x6858FC0", VA = "0x186859FC0", Slot = "6")]
	public override BFOPEDMIDNF PPFECFLIGJE(IFEGPOPBOAE MIFEONEPPKP, [Out] IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[Preserve]
internal class GDJEMCLAMMM : GENFEPEFEHM
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class LMAIKDFCALD : JsonConverter<NPEOIHDJLEM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x685D220", Offset = "0x685C220", VA = "0x18685D220", Slot = "9")]
		public override void WriteJson(JsonWriter KOHNEKCBPBH, NPEOIHDJLEM? JJCEIJMGOAB, JsonSerializer MOEKDCMNAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x685D100", Offset = "0x685C100", VA = "0x18685D100", Slot = "10")]
		public override NPEOIHDJLEM ReadJson(JsonReader JBMHGCNDNMN, Type BDNPMKPAOAI, NPEOIHDJLEM? EMBHJCDMNJM, bool JCPEPIIGPCG, JsonSerializer MOEKDCMNAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x685D2C0", Offset = "0x685C2C0", VA = "0x18685D2C0")]
		public LMAIKDFCALD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class IGBHHNLPDNI : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool CNOOMBEFBKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6859E80", Offset = "0x6858E80", VA = "0x186859E80", Slot = "5")]
		public override object ReadJson(JsonReader JBMHGCNDNMN, Type BDNPMKPAOAI, object? EMBHJCDMNJM, JsonSerializer MOEKDCMNAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6859CA0", Offset = "0x6858CA0", VA = "0x186859CA0", Slot = "6")]
		public override bool CanConvert(Type BDNPMKPAOAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6859EE0", Offset = "0x6858EE0", VA = "0x186859EE0", Slot = "4")]
		public override void WriteJson(JsonWriter KOHNEKCBPBH, object? JJCEIJMGOAB, JsonSerializer MOEKDCMNAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6859AA0", Offset = "0x6858AA0", VA = "0x186859AA0")]
		private static bool APAFOJNMOOA(object JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public IGBHHNLPDNI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly JsonSerializerSettings MCEFNBMGMDI;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6858920", Offset = "0x6857920", VA = "0x186858920")]
	internal GDJEMCLAMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7CF0", Offset = "0x2BB6CF0", VA = "0x182BB7CF0", Slot = "4")]
	public string BAKBMDGJMFJ<T>(T NOPFNIKINJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7D50", Offset = "0x2BB6D50", VA = "0x182BB7D50", Slot = "5")]
	public T OKNGPBOHJOI<T>(string JJCEIJMGOAB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Preserve]
internal class KBJDDFEBFAH : GENFEPEFEHM
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2C60140", Offset = "0x2C5F140", VA = "0x182C60140", Slot = "4")]
	public string BAKBMDGJMFJ<T>(T NOPFNIKINJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2C601B0", Offset = "0x2C5F1B0", VA = "0x182C601B0", Slot = "5")]
	public T OKNGPBOHJOI<T>(string JJCEIJMGOAB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public KBJDDFEBFAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CCEMJNNADFH]
internal class KODINMADFOB : HAOHALIMAPB<KDCJMIKEAAI, IJFIKDFEFBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly GENFEPEFEHM FPJMHDINHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private readonly JKBNIMMMFLF MBIHEIGBHFI;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x685CFC0", Offset = "0x685BFC0", VA = "0x18685CFC0")]
	public KODINMADFOB(GENFEPEFEHM FPJMHDINHCH, JKBNIMMMFLF MBIHEIGBHFI, KKGAIAJPKOC JJHGHICMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x685CB90", Offset = "0x685BB90", VA = "0x18685CB90", Slot = "6")]
	public override IJFIKDFEFBI PPFECFLIGJE(KDCJMIKEAAI MIFEONEPPKP, [Out] IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x685B5E0", Offset = "0x685A5E0", VA = "0x18685B5E0")]
	internal void HOBPLEMPIAJ(string FELGDDHKIGC, BFOPEDMIDNF DJCHDINKLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x685AB30", Offset = "0x6859B30", VA = "0x18685AB30")]
	public IEnumerable<GJGBCABMIHF> APCGACFABND(string IFHOABJDIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x685C2F0", Offset = "0x685B2F0", VA = "0x18685C2F0")]
	private IEnumerable<GJGBCABMIHF> PJEMNJIEPMK(string IFHOABJDIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x685C720", Offset = "0x685B720", VA = "0x18685C720")]
	internal IEnumerable<GJGBCABMIHF> PKLLNFADJFM(string IFHOABJDIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x685BF60", Offset = "0x685AF60", VA = "0x18685BF60")]
	private GJGBCABMIHF OPKJKLPLGEB(AvatarOutfitSelectionData LAGMPDFNCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x685AD40", Offset = "0x6859D40", VA = "0x18685AD40")]
	private void ENNBNHKAKJG(AvatarCustomizationSettingsData LNBNFJOABKN, BFOPEDMIDNF DJCHDINKLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x685BC40", Offset = "0x685AC40", VA = "0x18685BC40")]
	private GJGBCABMIHF OPKJKLPLGEB(string EHGNIHBAOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x685B740", Offset = "0x685A740", VA = "0x18685B740")]
	internal static (OELEMBFEEON, string, string) LPNMGKOFBCP(string EHGNIHBAOGB, KKGAIAJPKOC JJHGHICMIMA)
	{
		return default((OELEMBFEEON, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x685BA40", Offset = "0x685AA40", VA = "0x18685BA40")]
	private KKPMNBPAHMC? OGFIFAJJOMA(string? CNIMPJMOLDJ, Vector2 JPDGHEOKABK, float FDAEHFNGEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x685ABE0", Offset = "0x6859BE0", VA = "0x18685ABE0")]
	private static MACMOFHFNNF CJPLEJOKJDE(AvatarCustomizationSettingsData.AnchorParams ACIIKDEGMOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[CCEMJNNADFH]
internal class KDILCLACNFK : AJKGFJBKNAF, JLHJAKPMELB
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68542F0", Offset = "0x68532F0", VA = "0x1868542F0")]
	public KDILCLACNFK(GENFEPEFEHM FPJMHDINHCH, JKBNIMMMFLF MBIHEIGBHFI, KKGAIAJPKOC JJHGHICMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x685A540", Offset = "0x6859540", VA = "0x18685A540", Slot = "4")]
	public EAELIKELHCC JMNIMAIKKED(BFOPEDMIDNF AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x685A440", Offset = "0x6859440", VA = "0x18685A440")]
	private string DIDLPCMAFHB(BFOPEDMIDNF DJCHDINKLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x685A8F0", Offset = "0x68598F0", VA = "0x18685A8F0")]
	private string LPNHMAIBBHL(GJGBCABMIHF DMJOHFGFLLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[CCEMJNNADFH]
internal class EHKHEBDPKEH : HAOHALIMAPB<KDCJMIKEAAI, IJFIKDFEFBI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly GENFEPEFEHM FPJMHDINHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly JJCLDDPGINI<KDCJMIKEAAI, IJFIKDFEFBI> HNMBKIKMANE;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x68580A0", Offset = "0x68570A0", VA = "0x1868580A0")]
	public EHKHEBDPKEH(JJCLDDPGINI<KDCJMIKEAAI, IJFIKDFEFBI> HNMBKIKMANE, KKGAIAJPKOC JJHGHICMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6857C70", Offset = "0x6856C70", VA = "0x186857C70", Slot = "6")]
	public override IJFIKDFEFBI PPFECFLIGJE(KDCJMIKEAAI MIFEONEPPKP, [Out] IReadOnlyList<EMEKMPJCNKD>? MPBHPEBLNCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[CCEMJNNADFH]
internal class FEBMMMHFGGD : HFLLPJNFMBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly GENFEPEFEHM FPJMHDINHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly JLHJAKPMELB EDOPINJMPBJ;

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6858540", Offset = "0x6857540", VA = "0x186858540")]
	public FEBMMMHFGGD(JLHJAKPMELB EDOPINJMPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x68581A0", Offset = "0x68571A0", VA = "0x1868581A0", Slot = "4")]
	public KDCJMIKEAAI JMNIMAIKKED(BFOPEDMIDNF AHGAPHMJDIB, int DFJEFGPHPMN, string? CKEJJGPNKGO, string? JPNADFLILCL, IBMJBLBOIAO EDAPJBNJBMN, List<EMEKMPJCNKD>? MPBHPEBLNCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[Preserve]
internal class LPMMDKFBAEN : HFHGPPMHDBH
{
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly Vector2 FPLOGBKMJHJ;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly Vector2 MHMNIHFKKPA;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly Vector2 DBDFGFIPKAB;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly Vector2 BBJHHGIHJJA;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly Vector2 FIGJAEBNMLI;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly Vector2 ENEDCGDBEDD;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly Vector2 FICELEKFBKF;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly Vector2 OKHBHELJFBL;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly Vector2 JOKGBAPAFHE;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly Vector2 ONPDCMFOACB;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 CCGDMINEHFF;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 GEOCIIGNCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Dictionary<IOPEHOFLEFL, AvatarConfiguration> DCPDFEBKICC;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x685DC00", Offset = "0x685CC00", VA = "0x18685DC00")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.None)]
	private static void HEDHDPLCNKO(NDJGECDCBMH MMBLPJPOBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x685EF40", Offset = "0x685DF40", VA = "0x18685EF40")]
	[Preserve]
	internal LPMMDKFBAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x685E5D0", Offset = "0x685D5D0", VA = "0x18685E5D0", Slot = "4")]
	public Vector2 MAKACODELLH(FaceFeatureType JODLIPILJKK, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x685E410", Offset = "0x685D410", VA = "0x18685E410", Slot = "5")]
	public float LGKAENJMKCF(FaceFeatureType JODLIPILJKK, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x685E760", Offset = "0x685D760", VA = "0x18685E760", Slot = "6")]
	public void MLDKCHHHHIM(IOPEHOFLEFL MPPIBMIMAPM, AvatarConfiguration OFINEABMMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x685E730", Offset = "0x685D730", VA = "0x18685E730", Slot = "7")]
	public float MJJAGGGBPKM(FaceFeatureType HKHKIDDPCIM, float GMKFPFKEMBB, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x685E0D0", Offset = "0x685D0D0", VA = "0x18685E0D0", Slot = "8")]
	public float KALLBFIMAOK(FaceFeatureType HKHKIDDPCIM, float FDAEHFNGEBE, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x685EAC0", Offset = "0x685DAC0", VA = "0x18685EAC0", Slot = "10")]
	public Vector2 OFHBDHDIBKJ(FaceFeatureType HKHKIDDPCIM, Vector2 IDFEGDLKFKJ, Vector2 IBOLBKLJDLE, Vector2 BPECLODPJBC, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x685D460", Offset = "0x685C460", VA = "0x18685D460", Slot = "9")]
	public Vector2 CMOPKPFGIMC(FaceFeatureType HKHKIDDPCIM, Vector2 ECEMBOGBAEH, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x685D3C0", Offset = "0x685C3C0", VA = "0x18685D3C0")]
	private Vector2 BIBCGICOFIM(FaceFeatureType HKHKIDDPCIM, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x685E970", Offset = "0x685D970", VA = "0x18685E970")]
	private Vector2 OAKGFMHEOLO(FaceFeatureType HKHKIDDPCIM, Vector2 IDFEGDLKFKJ, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x685D690", Offset = "0x685C690", VA = "0x18685D690", Slot = "11")]
	public Vector2 DCBLCFFOAPO(FaceFeatureType HKHKIDDPCIM, Vector2 ECEMBOGBAEH, Vector2 IBOLBKLJDLE, Vector2 BPECLODPJBC, IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x685E100", Offset = "0x685D100", VA = "0x18685E100")]
	private float KCEBAHCOHEM(float EGMGMOAFAED, float LJPDMCKLOMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x685E8B0", Offset = "0x685D8B0", VA = "0x18685E8B0")]
	private Vector2 NFDFGHNFFJE(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x685DB40", Offset = "0x685CB40", VA = "0x18685DB40")]
	private Vector2 FBONNJAKFND(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x685E490", Offset = "0x685D490", VA = "0x18685E490")]
	private Vector2 LKCPJOJFNKH(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x685E1D0", Offset = "0x685D1D0", VA = "0x18685E1D0")]
	private Vector2 LBIONKIMEME(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x685DA20", Offset = "0x685CA20", VA = "0x18685DA20")]
	private float DIFEANPFKFD(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x685E930", Offset = "0x685D930", VA = "0x18685E930")]
	private float NGAFIJFINBB(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x685DBC0", Offset = "0x685CBC0", VA = "0x18685DBC0")]
	private float GJABBKJLKLG(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x685E190", Offset = "0x685D190", VA = "0x18685E190")]
	private float KDDOFOCPCPE(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x685DD50", Offset = "0x685CD50", VA = "0x18685DD50")]
	private Vector2 ILCHLONFEEA(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x685DA60", Offset = "0x685CA60", VA = "0x18685DA60")]
	private Vector2 EAGLKBDNPMP(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x685E7D0", Offset = "0x685D7D0", VA = "0x18685E7D0")]
	private Vector2 NEBFNNFJBJG(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x685DC70", Offset = "0x685CC70", VA = "0x18685DC70")]
	private Vector2 HGMNFDDNHLK(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x685DFF0", Offset = "0x685CFF0", VA = "0x18685DFF0")]
	private Vector2 JNFBMACAPJK(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x685DF10", Offset = "0x685CF10", VA = "0x18685DF10")]
	private Vector2 JDNFFFIDLIP(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x685E330", Offset = "0x685D330", VA = "0x18685E330")]
	private Vector2 LFPIBIDMIAM(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x685DE30", Offset = "0x685CE30", VA = "0x18685DE30")]
	private Vector2 ILLMLLLHAMM(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x685E250", Offset = "0x685D250", VA = "0x18685E250")]
	private Vector2 LCPALPPLLCB(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x685D300", Offset = "0x685C300", VA = "0x18685D300")]
	private Vector2 BCOANGKAPLE(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x685EC70", Offset = "0x685DC70", VA = "0x18685EC70")]
	private Vector2 PLHGHKICAME(IOPEHOFLEFL MPPIBMIMAPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x685E510", Offset = "0x685D510", VA = "0x18685E510")]
	private Vector2 LMHLHMDLOEI(IOPEHOFLEFL MPPIBMIMAPM)
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
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
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

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6854520", Offset = "0x6853520", VA = "0x186854520")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FNEOBAJHFNG
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6858810", Offset = "0x6857810", VA = "0x186858810")]
	public static MEDGMGIADBO PPFECFLIGJE(this EPHHDBKKNMO AHGAPHMJDIB)
	{
		return default(MEDGMGIADBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x68586F0", Offset = "0x68576F0", VA = "0x1868586F0")]
	public static EPHHDBKKNMO JMNIMAIKKED(this MEDGMGIADBO GIKJODOJOEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6858690", Offset = "0x6857690", VA = "0x186858690")]
	public static bool IIODGLPFFEP(this MEDGMGIADBO GIKJODOJOEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6858630", Offset = "0x6857630", VA = "0x186858630")]
	public static bool HPHAEDBBFPH(this MEDGMGIADBO GIKJODOJOEA)
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
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x4CD3980", Offset = "0x4CD2980", VA = "0x184CD3980")]
			public AnchorParams(Vector2 IDFEGDLKFKJ, Vector3 OOAENILANAG, Vector3 KOCOOPFGDKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6854470", Offset = "0x6853470", VA = "0x186854470")]
			internal MACMOFHFNNF JMNIMAIKKED()
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
		private NIADOEHBPBA useHelmetHair;

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
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6854D40", Offset = "0x6853D40", VA = "0x186854D40")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x3D59780", Offset = "0x3D58780", VA = "0x183D59780")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1171890", Offset = "0x1170890", VA = "0x181171890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x95D8F0", Offset = "0x95C8F0", VA = "0x18095D8F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA68830", Offset = "0xA67830", VA = "0x180A68830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x6854DF0", Offset = "0x6853DF0", VA = "0x186854DF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x859570", Offset = "0x858570", VA = "0x180859570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x95D9B0", Offset = "0x95C9B0", VA = "0x18095D9B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x118BC60", Offset = "0x118AC60", VA = "0x18118BC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x851820", Offset = "0x850820", VA = "0x180851820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6854E30", Offset = "0x6853E30", VA = "0x186854E30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1DD3520", Offset = "0x1DD2520", VA = "0x181DD3520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x99B4C0", Offset = "0x99A4C0", VA = "0x18099B4C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xF680D0", Offset = "0xF670D0", VA = "0x180F680D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x85B5E0", Offset = "0x85A5E0", VA = "0x18085B5E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x85B5F0", Offset = "0x85A5F0", VA = "0x18085B5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x41942D0", Offset = "0x41932D0", VA = "0x1841942D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1DD4E50", Offset = "0x1DD3E50", VA = "0x181DD4E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x888040", Offset = "0x887040", VA = "0x180888040")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8880A0", Offset = "0x8870A0", VA = "0x1808880A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x85FB20", Offset = "0x85EB20", VA = "0x18085FB20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x85FB30", Offset = "0x85EB30", VA = "0x18085FB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x85FC60", Offset = "0x85EC60", VA = "0x18085FC60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x85FC80", Offset = "0x85EC80", VA = "0x18085FC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x85FBB0", Offset = "0x85EBB0", VA = "0x18085FBB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x85FB60", Offset = "0x85EB60", VA = "0x18085FB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6B50", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xBD14E0", Offset = "0xBD04E0", VA = "0x180BD14E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x85FBD0", Offset = "0x85EBD0", VA = "0x18085FBD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x85FBE0", Offset = "0x85EBE0", VA = "0x18085FBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xB266F0", Offset = "0xB256F0", VA = "0x180B266F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xABCA80", Offset = "0xABBA80", VA = "0x180ABCA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x85D2D0", Offset = "0x85C2D0", VA = "0x18085D2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x85D330", Offset = "0x85C330", VA = "0x18085D330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x981B50", Offset = "0x980B50", VA = "0x180981B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC75870", Offset = "0xC74870", VA = "0x180C75870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xB1A2C0", Offset = "0xB192C0", VA = "0x180B1A2C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xE038B0", Offset = "0xE028B0", VA = "0x180E038B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public NIADOEHBPBA UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1E82520", Offset = "0x1E81520", VA = "0x181E82520")]
			get
			{
				return default(NIADOEHBPBA);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1E82330", Offset = "0x1E81330", VA = "0x181E82330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xB48890", Offset = "0xB47890", VA = "0x180B48890")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xB474D0", Offset = "0xB464D0", VA = "0x180B474D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x6854E10", Offset = "0x6853E10", VA = "0x186854E10")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x6854E50", Offset = "0x6853E50", VA = "0x186854E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x68549A0", Offset = "0x68539A0", VA = "0x1868549A0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
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
		public OELEMBFEEON BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private NADJPEJAJKG? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6856F20", Offset = "0x6855F20", VA = "0x186856F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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
