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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x68DEBB0", Offset = "0x68DD1B0", VA = "0x1868DEBB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[OBKEFOLKLJN]
internal class LIEPDKNAIDD : HGFDOHKDIEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct PCAINCHEGAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public LIEPDKNAIDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public PGDJCFPPLAG avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly BMHOKGJEPOA JEOMJNDBBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IGHOIOGENCJ EGGOGAGOMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GMPIHCCICNG ODFMLOGHKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly ECDOPJEKNOA IKDBMHAJECG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68DC740", Offset = "0x68DAD40", VA = "0x1868DC740")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.GameOnly)]
	[UsedImplicitly]
	private static void BDACIGIPHCC(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68DD710", Offset = "0x68DBD10", VA = "0x1868DD710")]
	[Preserve]
	internal LIEPDKNAIDD([JAMCDGPOOBO(null)] BMHOKGJEPOA JEOMJNDBBGO, [JAMCDGPOOBO(null)] IGHOIOGENCJ EGGOGAGOMCN, [JAMCDGPOOBO(null)] GMPIHCCICNG ODFMLOGHKID, [JAMCDGPOOBO(null)] ECDOPJEKNOA IKDBMHAJECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68DC9A0", Offset = "0x68DAFA0", VA = "0x1868DC9A0", Slot = "5")]
	public PANBOAAKJAE JOGNBEEJGOB(bool KOFFEFJIODE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68DBD80", Offset = "0x68DA380", VA = "0x1868DBD80", Slot = "4")]
	public PANBOAAKJAE ANINLHDDDGA(bool KOFFEFJIODE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68DC7B0", Offset = "0x68DADB0", VA = "0x1868DC7B0", Slot = "6")]
	public OMPHBNLEMFF GJMJKLLGFGE(PANBOAAKJAE MMDLBEBNCGC, int FOHLLJFLLPN, string? GJEDHMJMNJA, string? EEGOHJAELPL, JJEPHBBIFMN DJFONDNNOON, List<DDGJNLGHJFM>? PEGPPBOCHIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68DD310", Offset = "0x68DB910", VA = "0x1868DD310", Slot = "7")]
	public bool KGEFCBHOOEE(LAFHIKFJEKF KMCCEIBHHIE, [Out] PANBOAAKJAE? HEDFAKOOGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68DC8C0", Offset = "0x68DAEC0", VA = "0x1868DC8C0", Slot = "8")]
	public bool HAKBHOOCLOA(OMPHBNLEMFF FFNKLPJFOHJ, [Out] PANBOAAKJAE? HEDFAKOOGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68DD680", Offset = "0x68DBC80", VA = "0x1868DD680", Slot = "9")]
	public bool PPNELMNOOLO(OMPHBNLEMFF FFNKLPJFOHJ, [Out] EAIIBKNMIAM? KMCCEIBHHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2C58100", Offset = "0x2C56700", VA = "0x182C58100")]
	private bool BAOHJFIHBPA<TInput, TOutput>(TInput BNBKMKBLLLG, JEDLHPNLHIF<TInput, TOutput> NGLOGICHGHM, [Out] TOutput? IAFCFGOKEAK) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68DD160", Offset = "0x68DB760", VA = "0x1868DD160")]
	[CompilerGenerated]
	private KIBMMBGHFBO JPDGICDEIOC(FaceFeatureType KEDKCMEKJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68DD3A0", Offset = "0x68DB9A0", VA = "0x1868DD3A0")]
	[CompilerGenerated]
	private KIBMMBGHFBO MGJHOPIHMOM(FaceFeatureType KEDKCMEKJMN, PCAINCHEGAK P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OBKEFOLKLJN]
internal class NCCCAEGHGKP : BMHOKGJEPOA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void JDDBGPBCGKP<in TData>(TData HEDFAKOOGHK, IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly GMPIHCCICNG ODFMLOGHKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PKAMEBFLEIB GAECPNEAIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JDDBGPBCGKP<PANBOAAKJAE>?[] JEOMJNDBBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JDDBGPBCGKP<EAIIBKNMIAM>?[] KHBDAMLOALP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68DD900", Offset = "0x68DBF00", VA = "0x1868DD900")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.GameOnly)]
	[UsedImplicitly]
	private static void BDACIGIPHCC(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68DE880", Offset = "0x68DCE80", VA = "0x1868DE880")]
	[Preserve]
	internal NCCCAEGHGKP([JAMCDGPOOBO(null)] GMPIHCCICNG ODFMLOGHKID, [JAMCDGPOOBO(null)] PKAMEBFLEIB GAECPNEAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68DDD30", Offset = "0x68DC330", VA = "0x1868DDD30", Slot = "4")]
	public bool JDLLANHODJA(PANBOAAKJAE HEDFAKOOGHK, IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68DDBD0", Offset = "0x68DC1D0", VA = "0x1868DDBD0", Slot = "5")]
	public bool JDLLANHODJA(EAIIBKNMIAM KMCCEIBHHIE, IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68DDE30", Offset = "0x68DC430", VA = "0x1868DDE30")]
	private void MMGHAOAIDHH(PANBOAAKJAE HEDFAKOOGHK, IReadOnlyList<DDGJNLGHJFM>? INKFLMKONLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68DD9A0", Offset = "0x68DBFA0", VA = "0x1868DD9A0")]
	private void HCHDMLBOANC(PANBOAAKJAE HEDFAKOOGHK, IReadOnlyList<DDGJNLGHJFM>? INKFLMKONLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68DD970", Offset = "0x68DBF70", VA = "0x1868DD970")]
	private void FDFPJKBJJGG(PANBOAAKJAE HEDFAKOOGHK, IReadOnlyList<DDGJNLGHJFM>? INKFLMKONLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BMHOKGJEPOA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JDLLANHODJA(PANBOAAKJAE HEDFAKOOGHK, IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JDLLANHODJA(EAIIBKNMIAM KMCCEIBHHIE, IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE);
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
		public IOBIIAEKPJM AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x68BFB90", Offset = "0x68BE190", VA = "0x1868BFB90")]
		public void AFJBILALFIB(AnimationPoseSetting BHFGHGMPKOJ, float KKPNFHNJAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68BFCC0", Offset = "0x68BE2C0", VA = "0x1868BFCC0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, DJJFDLKHLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
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
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
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
		private Vector3? GOMLBEDLKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool OAFHHCGEEEJ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68BFCE0", Offset = "0x68BE2E0", VA = "0x1868BFCE0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x68C02E0", Offset = "0x68BE8E0", VA = "0x1868C02E0", Slot = "4")]
		public void UpdateController(float JOOMCFPDCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEC3840", Offset = "0xEC1E40", VA = "0x180EC3840", Slot = "6")]
		public void SetEnabled(bool DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68BFD80", Offset = "0x68BE380", VA = "0x1868BFD80")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68C0700", Offset = "0x68BED00", VA = "0x1868C0700")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, DJJFDLKHLKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float MFBDCKONFIF = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
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
		private Vector3 KDAAKHEDIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 CBGKMCDHPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool OAFHHCGEEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float CBGKNBONLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float DCCGMEOEOAJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x68C0A80", Offset = "0x68BF080", VA = "0x1868C0A80", Slot = "4")]
		public void UpdateController(float JOOMCFPDCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB88B50", Offset = "0xB87150", VA = "0x180B88B50", Slot = "6")]
		public void SetEnabled(bool DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x68C07A0", Offset = "0x68BEDA0", VA = "0x1868C07A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68C1540", Offset = "0x68BFB40", VA = "0x1868C1540")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68C1E60", Offset = "0x68C0460", VA = "0x1868C1E60")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68C1E20", Offset = "0x68C0420", VA = "0x1868C1E20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68C1570", Offset = "0x68BFB70", VA = "0x1868C1570")]
		private void DKEDIHOMFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x688AB80", Offset = "0x6889180", VA = "0x18688AB80", Slot = "4")]
		public void SetEnabled(bool PCJPKCENFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68C1E90", Offset = "0x68C0490", VA = "0x1868C1E90")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarForearmRollController : MonoBehaviour, DJJFDLKHLKN
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
		private float CBGKNBONLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool OAFHHCGEEEJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68C1ED0", Offset = "0x68C04D0", VA = "0x1868C1ED0", Slot = "4")]
		public void UpdateController(float JOOMCFPDCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE16EA0", Offset = "0xE154A0", VA = "0x180E16EA0", Slot = "6")]
		public void SetEnabled(bool DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68C2960", Offset = "0x68C0F60", VA = "0x1868C2960")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, GONODADOJFM
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
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.SelfAndChildren, false, false, false)]
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
		[Header("Facial Animation")]
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
		[Header("Watch")]
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
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private MDMICJCKJAK JNBBIHFGODL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MDMICJCKJAK PDDMELIJOBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x68C37C0", Offset = "0x68C1DC0", VA = "0x1868C37C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform GNDGECGAKNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x68C3800", Offset = "0x68C1E00", VA = "0x1868C3800", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68C2990", Offset = "0x68C0F90", VA = "0x1868C2990")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68C3680", Offset = "0x68C1C80", VA = "0x1868C3680")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68C3630", Offset = "0x68C1C30", VA = "0x1868C3630")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68C35C0", Offset = "0x68C1BC0", VA = "0x1868C35C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68C3530", Offset = "0x68C1B30", VA = "0x1868C3530", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68C35C0", Offset = "0x68C1BC0", VA = "0x1868C35C0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68C2A30", Offset = "0x68C1030", VA = "0x1868C2A30", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x68C36D0", Offset = "0x68C1CD0", VA = "0x1868C36D0", Slot = "8")]
		public void UpdatePostIKAnimControllers(float JOOMCFPDCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68C34A0", Offset = "0x68C1AA0", VA = "0x1868C34A0")]
		private void IPCOHNGFNDL(GameObject NJKKPOFFNNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68C2D60", Offset = "0x68C1360", VA = "0x1868C2D60")]
		private MDMICJCKJAK ILLCPMGFNOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public AvatarFullBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Header("Hand Animation")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x371")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x68C3850", Offset = "0x68C1E50", VA = "0x1868C3850")]
		public AnimationPoseSetting CKAGGNFIANM(IOBIIAEKPJM JAIJPILMEIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68C3820", Offset = "0x68C1E20", VA = "0x1868C3820")]
		public void ADKLMMLJNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68C3880", Offset = "0x68C1E80", VA = "0x1868C3880")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x68C52A0", Offset = "0x68C38A0", VA = "0x1868C52A0")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IGFMBOFCPJL : JAFGLADBEOD
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int DLJBKEIDLCB;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int LPCIOEBDENL;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static int OGNFAHFJJMB;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static int HPMOJEEOKFL;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static int CMEHOHGNAOE;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static int DJOOFKDPCFH;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int KLJGPHHKKGJ;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static int[] HHHOMFMKLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private HBABJMKNLDF IPDJBJCIMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int OAKHHNPCOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private float GGGEDGPKAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private bool CMFEKJMMBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Animator PMFEOANDFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private AvatarFullBodyConfiguration IPOBKHILPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int JFMPLPLMGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int GJCOECJNBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int LMCLLCLENBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool IOKADCPGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private OEMMBBGMLDB KJCPCHFNADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private float EGFGGGIGIAL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform NDJPNNFPHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 EPKNHFKMCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE108C0", Offset = "0xE0EEC0", VA = "0x180E108C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE109F0", Offset = "0xE0EFF0", VA = "0x180E109F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion PLDAIPMHCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1C0DA80", Offset = "0x1C0C080", VA = "0x181C0DA80")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1F734F0", Offset = "0x1F71AF0", VA = "0x181F734F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal bool PAODHNDNMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68DA650", Offset = "0x68D8C50", VA = "0x1868DA650")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68DAAA0", Offset = "0x68D90A0", VA = "0x1868DAAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 PFOACMDNCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8912C0", VA = "0x180892CC0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x893CA0", Offset = "0x8922A0", VA = "0x180893CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Quaternion FMLFPEFEDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x892E70", Offset = "0x891470", VA = "0x180892E70", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x893E30", Offset = "0x892430", VA = "0x180893E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DDJELBEAPKP FDPMMDAOOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1AF0A60", Offset = "0x1AEF060", VA = "0x181AF0A60", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DDJELBEAPKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1AF0A70", Offset = "0x1AEF070", VA = "0x181AF0A70", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DDJELBEAPKP HPOIEIDPEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9E7AB0", Offset = "0x9E60B0", VA = "0x1809E7AB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(DDJELBEAPKP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9E8160", Offset = "0x9E6760", VA = "0x1809E8160", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float FAFHPEKAOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC350", Offset = "0x1DBA950", VA = "0x181DBC350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1DBAF60", Offset = "0x1DB9560", VA = "0x181DBAF60", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ANMEDAEOLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68DA9C0", Offset = "0x68D8FC0", VA = "0x1868DA9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool LFODFNHHHED
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x68DA9F0", Offset = "0x68D8FF0", VA = "0x1868DA9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MCNOELAMIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68DA7B0", Offset = "0x68D8DB0", VA = "0x1868DA7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x68DAB70", Offset = "0x68D9170", VA = "0x1868DAB70", Slot = "21")]
	public void PNLKNBIHCGI(HBABJMKNLDF MJIGPJMJDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68DAA00", Offset = "0x68D9000", VA = "0x1868DAA00", Slot = "22")]
	public void HLAAEOAGOFF(GDEFOANGIMC GNKGNFAAAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x68DAA10", Offset = "0x68D9010", VA = "0x1868DAA10", Slot = "12")]
	public void IFICAKHJBHI(bool AKKNAKBNOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x68DA330", Offset = "0x68D8930", VA = "0x1868DA330", Slot = "11")]
	public void ABMGDBOIEPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68DA810", Offset = "0x68D8E10", VA = "0x1868DA810")]
	private int FFBLJJOFPOJ(DDJELBEAPKP JHCEFLHBODH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68DA680", Offset = "0x68D8C80", VA = "0x1868DA680")]
	private void CKGLPAPIJPG(int ICPIJHMDCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68DA9D0", Offset = "0x68D8FD0", VA = "0x1868DA9D0", Slot = "13")]
	public bool GFOMOGHAIGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68DAB60", Offset = "0x68D9160", VA = "0x1868DAB60", Slot = "14")]
	public bool PBGHJFJEMNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68DA7C0", Offset = "0x68D8DC0", VA = "0x1868DA7C0")]
	private DDJELBEAPKP FBMDPFNOJIB()
	{
		return default(DDJELBEAPKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1AE8B00", Offset = "0x1AE7100", VA = "0x181AE8B00", Slot = "15")]
	public void IGGGCFEBFED(bool AKKNAKBNOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68DAAD0", Offset = "0x68D90D0", VA = "0x1868DAAD0", Slot = "10")]
	public void INPEKKFKJGD(int ICPIJHMDCBK, float LFAOADOCADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x68DAB40", Offset = "0x68D9140", VA = "0x1868DAB40", Slot = "8")]
	public void MPGFIMFKIKC(OEMMBBGMLDB NEIJPCGNELF, bool HBGFFBOKCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68DAB30", Offset = "0x68D9130", VA = "0x1868DAB30", Slot = "9")]
	public void JHPDCNNCAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68DAAE0", Offset = "0x68D90E0", VA = "0x1868DAAE0", Slot = "16")]
	public void JBDHFCCNICM(Transform PPEEAFEPIIK, Vector3 KLBHDOICAKF, Quaternion HLFKIBPOHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68DB000", Offset = "0x68D9600", VA = "0x1868DB000")]
	public IGFMBOFCPJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GFPOOPMHFLN : MDMICJCKJAK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class LECBAGECOAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private Vector3 ODDBHAPNPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Quaternion FAHAFLOCDAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Vector3 JNDLDPIDPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Transform NBJPIDEGJLO;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector3 GEDEHICMHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x13D50C0", Offset = "0x13D36C0", VA = "0x1813D50C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x13D50E0", Offset = "0x13D36E0", VA = "0x1813D50E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Quaternion ODBJAIBHJCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB3DD90", Offset = "0xB3C390", VA = "0x180B3DD90")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB3DE10", Offset = "0xB3C410", VA = "0x180B3DE10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float HODBACEFOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E00", Offset = "0x8F6400", VA = "0x1808F7E00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xECDC50", Offset = "0xECC250", VA = "0x180ECDC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool BDABPKLGDOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x873610", Offset = "0x871C10", VA = "0x180873610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8735F0", Offset = "0x871BF0", VA = "0x1808735F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool LLHIBINJCEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8736E0", Offset = "0x871CE0", VA = "0x1808736E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x873600", Offset = "0x871C00", VA = "0x180873600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool ONOJKBBGMKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x873520", Offset = "0x871B20", VA = "0x180873520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x873540", Offset = "0x871B40", VA = "0x180873540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float DAANJKHMOPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E30", Offset = "0x8F6430", VA = "0x1808F7E30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9E5AB0", Offset = "0x9E40B0", VA = "0x1809E5AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68DBD60", Offset = "0x68DA360", VA = "0x1868DBD60")]
		public void OPLLBPAMJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x68DB010", Offset = "0x68D9610", VA = "0x1868DB010")]
		public void BAMFJBJGIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x68DB020", Offset = "0x68D9620", VA = "0x1868DB020")]
		public float CFABPBIMHOJ(Transform FENOAMJHLHH, [In] FootSettings BIMLEMJNACG, float NJILNMPKHDH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x68DB420", Offset = "0x68D9A20", VA = "0x1868DB420")]
		public void FEDHLAKOKKB(Transform NFGKPANPJJO, Transform NPMMCMKLGON, float NGGNOMFPGHA, bool ELHDPPPMAMA, bool LHHNGOCOPIE, float EKFCCOAJBLB, float DICMLMDICDE, Transform OPJBDKMKMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x68DB1F0", Offset = "0x68D97F0", VA = "0x1868DB1F0")]
		public void FEBCBEMKJMP(Transform NOCMNHKMNOE, Transform OPJBDKMKMOF, bool JGAFDCCPLCH, bool MJELDAFCNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x68DBC60", Offset = "0x68DA260", VA = "0x1868DBC60")]
		private void NBOEFAFCIJD(Transform OPJBDKMKMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x68DBB90", Offset = "0x68DA190", VA = "0x1868DBB90")]
		public void MJOCOAEGDOG(Transform OPJBDKMKMOF, AvatarFullBodyConfiguration NIHBAMBHFCG, Vector3 EGNCNGJACAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x68DBB80", Offset = "0x68DA180", VA = "0x1868DBB80")]
		public void KECAMKKDHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x68DBD70", Offset = "0x68DA370", VA = "0x1868DBD70")]
		public LECBAGECOAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class DMMHCIDHILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private float MOPDKPMICGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private bool KMFOPGKLLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AnimationPoseSetting EIIEEFJECBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private float HPMBHPDIMHM;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x68C45D0", Offset = "0x68C2BD0", VA = "0x1868C45D0")]
		public void KGFJCFCCHII(IKSolverVR.Arm IDEOPOCIPEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68C4760", Offset = "0x68C2D60", VA = "0x1868C4760")]
		public void NJANJIJDMML(IKSolverVR.Arm IDEOPOCIPEM, float FFMNAKGLDFH, bool KMFOPGKLLEL, AvatarFullBodyConfiguration NIHBAMBHFCG, float MGGEAGELPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x68C4450", Offset = "0x68C2A50", VA = "0x1868C4450")]
		private void IJBAIECACDN(IKSolverVR.Arm IDEOPOCIPEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x68C3BE0", Offset = "0x68C21E0", VA = "0x1868C3BE0")]
		public void AFLKKENFFHM(IKSolverVR.Arm IDEOPOCIPEM, Transform PKDFGLMFFKI, Transform NPMMCMKLGON, Quaternion ACKFGOOPOFJ, Vector3 DHCCAPKIIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x68C3FC0", Offset = "0x68C25C0", VA = "0x1868C3FC0")]
		private (Vector3, Quaternion) CLNCGAHGIDA(IGFMBOFCPJL MKBMMHCFGNC, Quaternion MOLGHJGOEIP, Vector3 JLHGCCNFNOK)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x68C4600", Offset = "0x68C2C00", VA = "0x1868C4600")]
		public void MPMAJCDJGOO(IGFMBOFCPJL MKBMMHCFGNC, IKSolverVR.Arm IDEOPOCIPEM, Quaternion MOLGHJGOEIP, Vector3 JLHGCCNFNOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x68C4C20", Offset = "0x68C3220", VA = "0x1868C4C20")]
		public void POIFCNNCFKD(IGFMBOFCPJL MKBMMHCFGNC, IKSolverVR.Arm IDEOPOCIPEM, Quaternion MOLGHJGOEIP, Vector3 JLHGCCNFNOK, [In] AvatarFullBodyConfiguration NIHBAMBHFCG, [In] ANKFKLNBGCB NEIJPCGNELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x68C4490", Offset = "0x68C2A90", VA = "0x1868C4490")]
		public void JKNFJDCLAIF(IOBIIAEKPJM LNNNGPPLCGM, AvatarFullBodyConfiguration NIHBAMBHFCG, ANKFKLNBGCB NEIJPCGNELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x68C47A0", Offset = "0x68C2DA0", VA = "0x1868C47A0")]
		public void OELJEJEFLMG(IKSolverVR.Arm IDEOPOCIPEM, Transform PKDFGLMFFKI, Vector3 DKJDIJFIFBE, float LGPPGMHGOIA, Quaternion NANOMEMEMLO, Vector3 KBCNLJGGOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x68C5220", Offset = "0x68C3820", VA = "0x1868C5220")]
		public DMMHCIDHILG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum NJODAEAHKMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int OKDOPGLNMPK;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int EOFJPLLMHBB;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int NDGLBHIIAJP;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int EHIBBFPJOFC;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int BKLHPIBBDKH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int DFPKHEJEECJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int NGGLBHHBKKN;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int DLKHIGLAHCA;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int AIDEABHJGNF;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int BMGLIFHDGJP;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int HPEDIMKNOCJ;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int KAHJPFGGAMJ;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int ACFIJNFHENP;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int NKBIDLFDHEG;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int NHHBAIJEEGH;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int DNIONAEOIEE;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int MGADDHCIADM;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int FMMHMMCLKDE;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int PKFIEOKGKNB;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int DFIICFFLAKN;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int EDCGHNLFJKK;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int GNIHIGLHFAE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int BNIOBLDOJNL;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int OJPKPHMDMDL;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly int NKAIAKMLKPB;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int CEEKKLBKDDH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int NGCPHDPBADO;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly int EOBHGBPOBIF;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly int AJNHIFICPBG;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly Vector3 NGJFJFMBDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool MBCMPEJCKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool PLMHJPACKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private bool NOPJHOHJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool NKMPPJNMCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private bool EMFDDKIIABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Vector3 GBAIIAPPINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private JHGPPLOMCNA? IPDJBJCIMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private KJBALPNAEFI? BPDMMNOPABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private JIADPNPDEID HKKGEHOOLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private CKCAKCNBJPH KHNEOJJECCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private IGFMBOFCPJL MLCLLLKPFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private IGFMBOFCPJL MLIPEBHHHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private bool IKECKJLGDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x241")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool JGNIOIFIFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly JAGJEEHIKHG ELBDFGLLEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly KJIEGMMGEGN OHCKLBPBFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int AEIEFGBFLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float JACKPLDDOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private GameObject BLKHOBBGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Transform MJPPCALMFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private Transform INMAAHKBMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float OFFAEIAGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private float MNGMPKDLAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private Vector3 DOJPCNPMFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private Quaternion PMPKLNJEHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Transform KJGOODOJICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private Transform MKLKABOKGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private Transform FOIEPEIGELJ;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly ProfilerMarker FGIONHMBCEM;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly ProfilerMarker AKNDKOKADNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private ProfilerMarker POJDOGIKNBN;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly ProfilerMarker KPHOFHIBFCP;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly ProfilerMarker OKMCFGJMECO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly ProfilerMarker PBDGAIEPCOD;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly List<GFPOOPMHFLN> JEJPKNDJNGC;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int NGKDHPMFIFE;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> KMBBFAIHKJB;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static int LFGLNNJMHND;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static int PMLEABLKLPG;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static int DDBGGOGCHNO;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static int EONLFDIPGFH;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static float ENDHNEGPDGG;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static int KBAGGOHABNI;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static float DGBKCLNCAFL;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static float IJLKEONEHKD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static float IBJOHGIMNOI;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static float NECICCLOHGP;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static IIALEDFEMBD ACIOBIDIMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float FGBKEHHKBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool PKODCKIILAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float KAIIPPPAEFO;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int CJEMFDBKCOA;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int ENCGHHHFPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private LECBAGECOAA IOPALKPJLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private LECBAGECOAA JPNJIONAPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float GIIEIFHJALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private Vector3 BIENHBKJLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private Vector3 PHGMJEOPOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool JAGMNLBKHBA;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly Quaternion EINBIHILOIO;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly Quaternion IFOIHNJIGCF;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly Vector3 BHHDPEFLFDB;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly Vector3 PMBCFKAPOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float JLNCIMDHKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private float DGMAHABCGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private DMMHCIDHILG IGACBEOKAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private DMMHCIDHILG JIEFONHNHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private DDALDNLGAED LKMCMBILCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private MFEKMNLMOOH KIPHGHGMLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly OGBNIKOMKLC GBCHJMFHCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private float ALJNDBFPCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private float AIMNNHFPFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly MFEKMNLMOOH LGKJOBFBKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Vector3 FDIDFDLDCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Vector3 NGJBIPOEFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private float DDHNAIALNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private float ILNFDDEMCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly MFEKMNLMOOH IPEELIKLLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly DDALDNLGAED DJHFFNLDELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly MFEKMNLMOOH FCPNPKHGLJL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AOBPFOPEJNG OBHGKGBKINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AOBPFOPEJNG PIBLACEOBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AvatarConfiguration LPBNOJBDBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68CC320", Offset = "0x68CA920", VA = "0x1868CC320", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration ACBIGPGJHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68D5930", Offset = "0x68D3F30", VA = "0x1868D5930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform JGJLPEPHMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68D3720", Offset = "0x68D1D20", VA = "0x1868D3720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform LGNHBJDOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x68CE790", Offset = "0x68CCD90", VA = "0x1868CE790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer JLHJIKMFBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68CF1D0", Offset = "0x68CD7D0", VA = "0x1868CF1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] DAEMCILDEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68D7A40", Offset = "0x68D6040", VA = "0x1868D7A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] AGEMOAFCALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68CF4C0", Offset = "0x68CDAC0", VA = "0x1868CF4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator MKOGGOIBPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68D2E60", Offset = "0x68D1460", VA = "0x1868D2E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK AJIOCEANFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68C8030", Offset = "0x68C6630", VA = "0x1868C8030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private DJJFDLKHLKN IHAINFCNFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68C8120", Offset = "0x68C6720", VA = "0x1868C8120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private DJJFDLKHLKN AAHOCIMNDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68CBD30", Offset = "0x68CA330", VA = "0x1868CBD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private DJJFDLKHLKN DHDEGOPIMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68CF0E0", Offset = "0x68CD6E0", VA = "0x1868CF0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private DJJFDLKHLKN CBANJGDFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68CA7C0", Offset = "0x68C8DC0", VA = "0x1868CA7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private DJJFDLKHLKN LAMMNBNEGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68D8380", Offset = "0x68D6980", VA = "0x1868D8380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private DJJFDLKHLKN NBKDHBEOFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68D3540", Offset = "0x68D1B40", VA = "0x1868D3540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private DJJFDLKHLKN HGLJIDKGMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68CA090", Offset = "0x68C8690", VA = "0x1868CA090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private DJJFDLKHLKN FOALMKGEFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68D59C0", Offset = "0x68D3FC0", VA = "0x1868D59C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public KJBALPNAEFI GKKBMHCCNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68D7910", Offset = "0x68D5F10", VA = "0x1868D7910", Slot = "37")]
		get
		{
			return default(KJBALPNAEFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public OFNGPKLAKGC LDEKFHDNIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB33B60", Offset = "0xB32160", VA = "0x180B33B60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public JHJJPNCIKAD MDJJJHEDKFP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xB35690", Offset = "0xB33C90", VA = "0x180B35690", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public JAFGLADBEOD KHNIIDEEABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x142D920", Offset = "0x142BF20", VA = "0x18142D920", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public JAFGLADBEOD OFLPNHAGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xBCB410", Offset = "0xBC9A10", VA = "0x180BCB410", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Transform CMCBJKCCONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68D8B20", Offset = "0x68D7120", VA = "0x1868D8B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform IBODAHOAPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68CA180", Offset = "0x68C8780", VA = "0x1868CA180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform DIHONAJDPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x68C7D00", Offset = "0x68C6300", VA = "0x1868C7D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform KKMIDFDGLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x68D56E0", Offset = "0x68D3CE0", VA = "0x1868D56E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public GameObject FNAHDAKHMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x68D2A50", Offset = "0x68D1050", VA = "0x1868D2A50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HeadLogicOffsets LHHDMAAHOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x68D3B80", Offset = "0x68D2180", VA = "0x1868D3B80", Slot = "28")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform PLODDBGDCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x142D750", Offset = "0x142BD50", VA = "0x18142D750", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform MCLBOBBPBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA617A0", VA = "0x180A631A0", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Vector3 JNNFBNBBNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68CE520", Offset = "0x68CCB20", VA = "0x1868CE520", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float LICHHNALAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x68D2260", Offset = "0x68D0860", VA = "0x1868D2260", Slot = "32")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CDEAHLMKCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x68CAB20", Offset = "0x68C9120", VA = "0x1868CAB20", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform DBNGMFLGMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xB34AB0", Offset = "0xB330B0", VA = "0x180B34AB0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Transform DKPFOKOFFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x165C9C0", Offset = "0x165AFC0", VA = "0x18165C9C0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Transform JNPKLMNPLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x19EC2F0", Offset = "0x19EA8F0", VA = "0x1819EC2F0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool DLPDCICCHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68D8050", Offset = "0x68D6650", VA = "0x1868D8050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool HOGADDJAFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x68D5500", Offset = "0x68D3B00", VA = "0x1868D5500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private bool FGHBNLBNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x68D2DE0", Offset = "0x68D13E0", VA = "0x1868D2DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68CCA30", Offset = "0x68CB030", VA = "0x1868CCA30")]
	private void GAPIMLFCBLH([In] ANKFKLNBGCB PCIPAODOALE, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68C9A80", Offset = "0x68C8080", VA = "0x1868C9A80")]
	private void BDNPEBJCPMJ(ANKFKLNBGCB PCIPAODOALE, AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x68CC410", Offset = "0x68CAA10", VA = "0x1868CC410")]
	private void FIIBHBAEKOH([In] ANKFKLNBGCB NEIJPCGNELF, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68D9EA0", Offset = "0x68D84A0", VA = "0x1868D9EA0")]
	public GFPOOPMHFLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x68CEB80", Offset = "0x68CD180", VA = "0x1868CEB80", Slot = "12")]
	public void GPDONKFLOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x68D2AF0", Offset = "0x68D10F0", VA = "0x1868D2AF0", Slot = "13")]
	public void KLCMDGFOHFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x68D5AB0", Offset = "0x68D40B0", VA = "0x1868D5AB0", Slot = "14")]
	public void OCCHIDAGEOP(bool JIOHNCKEBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68CEF90", Offset = "0x68CD590", VA = "0x1868CEF90", Slot = "22")]
	public Transform GPFFGINCLMM(string CAFGNKAIMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x68CC190", Offset = "0x68CA790", VA = "0x1868CC190", Slot = "23")]
	public Vector3? FAJNDEBGKHI(string CAFGNKAIMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x68C9560", Offset = "0x68C7B60", VA = "0x1868C9560", Slot = "7")]
	public void ANMDLPLMOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x68D6980", Offset = "0x68D4F80", VA = "0x1868D6980", Slot = "6")]
	public void OEBGJBKLDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x68CBCC0", Offset = "0x68CA2C0", VA = "0x1868CBCC0", Slot = "8")]
	public void EEGMBENPAJB(float POHONDCCOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x68C72C0", Offset = "0x68C58C0", VA = "0x1868C72C0")]
	private void ADNDLOJIMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x68C52E0", Offset = "0x68C38E0", VA = "0x1868C52E0", Slot = "4")]
	public void AADCBIKBIMJ(JHGPPLOMCNA DGMOIJFAHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x68D1330", Offset = "0x68CF930", VA = "0x1868D1330", Slot = "5")]
	public void JEHDEDALOMM(KJBALPNAEFI GNKGNFAAAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x68D3630", Offset = "0x68D1C30", VA = "0x1868D3630", Slot = "11")]
	public void LOFHMJKHHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x68C7310", Offset = "0x68C5910", VA = "0x1868C7310", Slot = "21")]
	public void AECGABOFFAM([Out] Vector3 EPDAEFLAJCK, [Out] Quaternion NANOMEMEMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x68D4480", Offset = "0x68D2A80", VA = "0x1868D4480")]
	private void MCFMODFIEGJ([In] ANKFKLNBGCB NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x68D0870", Offset = "0x68CEE70", VA = "0x1868D0870", Slot = "24")]
	public void INMFDDOGBNL(float MCLAGDJBAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x68D80B0", Offset = "0x68D66B0", VA = "0x1868D80B0", Slot = "25")]
	public void PDLFOIPLAIM(float MPFGNPJGCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x68CF410", Offset = "0x68CDA10", VA = "0x1868CF410", Slot = "26")]
	public HandLogicOffsets HLMKINEFBPF()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x68CBC00", Offset = "0x68CA200", VA = "0x1868CBC00", Slot = "27")]
	public PlatformSpecificPlayerHandOffsets EDIOFMJCDFM()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68D1270", Offset = "0x68CF870", VA = "0x1868D1270")]
	private void JEDBJNHFNDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x68D0450", Offset = "0x68CEA50", VA = "0x1868D0450")]
	private void INEBJKNDBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x68CBEA0", Offset = "0x68CA4A0", VA = "0x1868CBEA0")]
	private void EKLFDHCACJO(DKAMHPILGME DKONPFAPPEN, bool ILHLBOIBFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x68D3380", Offset = "0x68D1980", VA = "0x1868D3380")]
	private void LNOHCCIGFBM(DKAMHPILGME DKONPFAPPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x68C9E20", Offset = "0x68C8420", VA = "0x1868C9E20")]
	public Vector3 BGFNKDIELMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x68CBE20", Offset = "0x68CA420", VA = "0x1868CBE20")]
	private void EHMEOCFCOAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x68CF2C0", Offset = "0x68CD8C0", VA = "0x1868CF2C0")]
	private void HDNIMJEOKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x68CF5B0", Offset = "0x68CDBB0", VA = "0x1868CF5B0")]
	private void IGDEMOAKKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x68D6450", Offset = "0x68D4A50", VA = "0x1868D6450")]
	private float OCKBLALEDKO([In] ANKFKLNBGCB NEIJPCGNELF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x68D57D0", Offset = "0x68D3DD0", VA = "0x1868D57D0")]
	private int NGLELOPPEEO([In] GDLCGBNGCBM DFJILJCBLKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x68CF5D0", Offset = "0x68CDBD0", VA = "0x1868CF5D0")]
	private void IJFOEEEBCGH(ANKFKLNBGCB PCIPAODOALE, bool IGINFDCPAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x68CA590", Offset = "0x68C8B90", VA = "0x1868CA590")]
	private static void CNFMDMEFAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x68D44B0", Offset = "0x68D2AB0", VA = "0x1868D44B0")]
	private static void MCMLJCJJOLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x68C76B0", Offset = "0x68C5CB0", VA = "0x1868C76B0")]
	private float AECJKOHPAEK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x68CE2E0", Offset = "0x68CC8E0", VA = "0x1868CE2E0")]
	private static int GBFMPJINHFA(GFPOOPMHFLN CLMMPLJCADB, GFPOOPMHFLN NIGNLACGOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x68CC9F0", Offset = "0x68CAFF0", VA = "0x1868CC9F0")]
	public void FOALDOIHDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x68CE560", Offset = "0x68CCB60", VA = "0x1868CE560")]
	private (bool, bool) GKCGLNNHHFL()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x68C8210", Offset = "0x68C6810", VA = "0x1868C8210")]
	private void ANEAGPBJMKB([In] ANKFKLNBGCB NEIJPCGNELF, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x68D2F50", Offset = "0x68D1550", VA = "0x1868D2F50")]
	private void LLEIEGHJFEB([In] ANKFKLNBGCB NEIJPCGNELF, [In] AvatarFullBodyConfiguration NIHBAMBHFCG, FootSettings BIMLEMJNACG, bool KDGLAACDICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x68D58B0", Offset = "0x68D3EB0", VA = "0x1868D58B0")]
	private float NIGDKBJCHCB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x68CFB00", Offset = "0x68CE100", VA = "0x1868CFB00")]
	private void INDCCBIFPDC(ANKFKLNBGCB NEIJPCGNELF, AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x68D5580", Offset = "0x68D3B80", VA = "0x1868D5580")]
	private float MNDMHLEKFGK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x68CAB80", Offset = "0x68C9180", VA = "0x1868CAB80")]
	private void DMFAOIKFDFJ([In] ANKFKLNBGCB NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x68C79B0", Offset = "0x68C5FB0", VA = "0x1868C79B0")]
	private void AFLKKENFFHM([In] ANKFKLNBGCB NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x68D0C90", Offset = "0x68CF290", VA = "0x1868D0C90")]
	private void JDHDBLHDOIM([In] ANKFKLNBGCB NEIJPCGNELF, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x68CE310", Offset = "0x68CC910", VA = "0x1868CE310")]
	private void GBICFGIELKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x68D55D0", Offset = "0x68D3BD0", VA = "0x1868D55D0")]
	private void NDOCDLGEIDD([In] ANKFKLNBGCB NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x68D1FD0", Offset = "0x68D05D0", VA = "0x1868D1FD0")]
	private void JLMGEDMFAOO(IGFMBOFCPJL POEGJCPHNEO, IKSolverVR.Arm IDEOPOCIPEM, Transform DAIOAPFJNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x68D3810", Offset = "0x68D1E10", VA = "0x1868D3810")]
	private void MABIOOLMICM(ANKFKLNBGCB NEIJPCGNELF, AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x68C6B60", Offset = "0x68C5160", VA = "0x1868C6B60")]
	private void ABMGDBOIEPM(FDICCLMPFOA CNFDHACHOBG, JAFGLADBEOD POEGJCPHNEO, IKSolverVR.Arm IDEOPOCIPEM, float FFMNAKGLDFH, float FIMPIEEENLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x68D8470", Offset = "0x68D6A70", VA = "0x1868D8470")]
	private void PHGFCBODGGG([In] ANKFKLNBGCB NEIJPCGNELF, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x68D65F0", Offset = "0x68D4BF0", VA = "0x1868D65F0")]
	protected void OCLNJEDFHKH([In] ANKFKLNBGCB NEIJPCGNELF, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x68D1850", Offset = "0x68CFE50", VA = "0x1868D1850")]
	private void JGBHLIJDAFC([In] ANKFKLNBGCB NEIJPCGNELF, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x68C7D70", Offset = "0x68C6370", VA = "0x1868C7D70")]
	protected void AGHFKOGPDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x68D3DB0", Offset = "0x68D23B0", VA = "0x1868D3DB0")]
	private void MAJNNGAEOPA([In] ANKFKLNBGCB NEIJPCGNELF, [In] NJODAEAHKMD OHMJLLGPHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x68D3C00", Offset = "0x68D2200", VA = "0x1868D3C00")]
	private void MAJCMOENGOB(ANKFKLNBGCB NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68D2A10", Offset = "0x68D1010", VA = "0x1868D2A10")]
	private void KKJNONLFJND([In] ANKFKLNBGCB NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68D5040", Offset = "0x68D3640", VA = "0x1868D5040")]
	private Vector3 MIBHHJLPBAN([In] ANKFKLNBGCB NEIJPCGNELF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68C9FC0", Offset = "0x68C85C0", VA = "0x1868C9FC0")]
	private void BGLGIMIMEHG([In] ANKFKLNBGCB NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68CB7C0", Offset = "0x68C9DC0", VA = "0x1868CB7C0")]
	private float EALHCBDGAPK(float DICMLMDICDE, [In] ANKFKLNBGCB NEIJPCGNELF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x68C9E70", Offset = "0x68C8470", VA = "0x1868C9E70")]
	private void BGJPBMOLLLN(float DICMLMDICDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68D1B30", Offset = "0x68D0130", VA = "0x1868D1B30")]
	private void JKEDPKMDCKH([In] ANKFKLNBGCB NEIJPCGNELF, NJODAEAHKMD OHMJLLGPHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68CC5E0", Offset = "0x68CABE0", VA = "0x1868CC5E0")]
	private float FJPEBOGMDCH([In] ANKFKLNBGCB PCIPAODOALE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68D7B30", Offset = "0x68D6130", VA = "0x1868D7B30")]
	private void OMGNNLBFHPF(ANKFKLNBGCB NEIJPCGNELF, NJODAEAHKMD OHMJLLGPHBG, Vector3 CGBGHEHAHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x68C7800", Offset = "0x68C5E00", VA = "0x1868C7800")]
	private static void AEGNBBILFGD(Transform AFJHLFMCCIJ, Quaternion GLKHDAMNPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68CE880", Offset = "0x68CCE80", VA = "0x1868CE880")]
	private void GNBJCGNDEOG([In] ANKFKLNBGCB BEAHJPGOGMF, [In] GDLCGBNGCBM DFJILJCBLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68D2290", Offset = "0x68D0890", VA = "0x1868D2290")]
	private void KGGCNNOKKJH([In] ANKFKLNBGCB BEAHJPGOGMF, [In] GDLCGBNGCBM DFJILJCBLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68D8B70", Offset = "0x68D7170", VA = "0x1868D8B70")]
	private void PPKFAPAADHM(float CKJNKGFOHHN, [In] ANKFKLNBGCB PCIPAODOALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68CB070", Offset = "0x68C9670", VA = "0x1868CB070")]
	private float DNMMIICEGKI([In] ANKFKLNBGCB PCIPAODOALE, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68CA8B0", Offset = "0x68C8EB0", VA = "0x1868CA8B0")]
	private void CPBBIGDEIKM([In] ANKFKLNBGCB PCIPAODOALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x68D8D20", Offset = "0x68D7320", VA = "0x1868D8D20")]
	private void PPNJONKEPKF([In] ANKFKLNBGCB PCIPAODOALE, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x68CA1F0", Offset = "0x68C87F0", VA = "0x1868CA1F0")]
	private void CFKJABGKMOP([In] ANKFKLNBGCB PCIPAODOALE, float NCJBCGBOAPD, float CEAEBMKBMEP, Vector3 IAEOINOFEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68D5B80", Offset = "0x68D4180", VA = "0x1868D5B80")]
	private void OCJHDDAGINJ(ANKFKLNBGCB PCIPAODOALE, AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x68D0880", Offset = "0x68CEE80", VA = "0x1868D0880")]
	private void JBLNGGLNPCD(ANKFKLNBGCB PCIPAODOALE, AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68C7170", Offset = "0x68C5770", VA = "0x1868C7170")]
	public void ADGABEPEAHA([In] ANKFKLNBGCB NEIJPCGNELF, [In] AvatarFullBodyConfiguration NIHBAMBHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x68CF340", Offset = "0x68CD940", VA = "0x1868CF340")]
	[CompilerGenerated]
	internal static void HFCBDHEIMPL(LECBAGECOAA HIIKHHGJHNE, LECBAGECOAA NKJFIBHHAHD, Transform CJCBBFIADPE, float ENLEFDLBBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68D1740", Offset = "0x68CFD40", VA = "0x1868D1740")]
	[CompilerGenerated]
	internal static bool JFLPLLFNEND(IKSolverVR.Arm IDEOPOCIPEM, AGPIFGMKBJI KBGLDCDKNOB, float OKPKLEPCFCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x68C6D30", Offset = "0x68C5330", VA = "0x1868C6D30")]
	[CompilerGenerated]
	internal static float ADCPNGNEHCJ(Vector3 MDHKLILJJEM, Vector3 CCIJHHFFJGL, Vector3 LDPCAGANKPO, ANKFKLNBGCB PCIPAODOALE, AvatarFullBodyConfiguration NIHBAMBHFCG, float GCMGLJCEDLO)
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
		public enum KKADCCLCEIH
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		private KKADCCLCEIH handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x68DFCA0", Offset = "0x68DE2A0", VA = "0x1868DFCA0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x68DFC60", Offset = "0x68DE260", VA = "0x1868DFC60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68DF630", Offset = "0x68DDC30", VA = "0x1868DF630")]
		private void DKEDIHOMFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x688AB80", Offset = "0x6889180", VA = "0x18688AB80", Slot = "4")]
		public void SetEnabled(bool PCJPKCENFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x68DFCD0", Offset = "0x68DE2D0", VA = "0x1868DFCD0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarKneeBendTargetController : MonoBehaviour, DJJFDLKHLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private Vector3 KDAAKHEDIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private Vector3 PBIHDMJINIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Vector3 DICAEGEIDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private Matrix4x4 AFLPDOOHMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool OAFHHCGEEEJ;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x68E0170", Offset = "0x68DE770", VA = "0x1868E0170", Slot = "4")]
		public void UpdateController(float JOOMCFPDCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x68E0160", Offset = "0x68DE760", VA = "0x1868E0160", Slot = "6")]
		public void SetEnabled(bool DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x68DFD00", Offset = "0x68DE300", VA = "0x1868DFD00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x68E0830", Offset = "0x68DEE30", VA = "0x1868E0830")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Preserve]
internal class FFKOFKDGDHK : CNGPOMKCCJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private Dictionary<string, MDMICJCKJAK> BPCBMCEJKPJ;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NGBABNCIPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x68E39E0", Offset = "0x68E1FE0", VA = "0x1868E39E0")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.None)]
	private static void PPHHIKMNPEC(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x68E3660", Offset = "0x68E1C60", VA = "0x1868E3660", Slot = "4")]
	public MDMICJCKJAK EHBNDGBOHDH(string BDDMMAGOOJH, AvatarSystemConfiguration NDDODAELILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x68E3800", Offset = "0x68E1E00", VA = "0x1868E3800", Slot = "5")]
	public void OEENCCKJGPH(string BDDMMAGOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x68E3A50", Offset = "0x68E2050", VA = "0x1868E3A50")]
	public FFKOFKDGDHK()
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
		public class LFCKBICFKNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			private Dictionary<string, Transform> KMGHHKDBHEP;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public bool HIFFGJEKBHK
			{
				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x68E97D0", Offset = "0x68E7DD0", VA = "0x1868E97D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x68E96A0", Offset = "0x68E7CA0", VA = "0x1868E96A0")]
			public void AJMAAKILBOH(VRIK DCMBIAOMPHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
			public void AJADNGPDJNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x68E9810", Offset = "0x68E7E10", VA = "0x1868E9810")]
			public void LJOBMJGJKLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x68E9860", Offset = "0x68E7E60", VA = "0x1868E9860")]
			public LFCKBICFKNA()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		[EOFOOIANCED(MLFOJBPNDOB.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly LFCKBICFKNA KIIHNLMMNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private GONODADOJFM KLBLBEBLEKD;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x68E08D0", Offset = "0x68DEED0", VA = "0x1868E08D0")]
		private void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x68E0870", Offset = "0x68DEE70", VA = "0x1868E0870")]
		private bool EEBDKNJKDGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68E08C0", Offset = "0x68DEEC0", VA = "0x1868E08C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x68E0BF0", Offset = "0x68DF1F0", VA = "0x1868E0BF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x68E0B90", Offset = "0x68DF190", VA = "0x1868E0B90")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x68E0E60", Offset = "0x68DF460", VA = "0x1868E0E60")]
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
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x68E41D0", Offset = "0x68E27D0", VA = "0x1868E41D0")]
			public void ADKLMMLJNNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x68E42B0", Offset = "0x68E28B0", VA = "0x1868E42B0")]
			public (float, float) GFJCIMGCBCN(Animator CPJANMINGEK, AnimatorStateInfo PBDPIGFMPEM)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x68E43F0", Offset = "0x68E29F0", VA = "0x1868E43F0")]
		public void ADKLMMLJNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x68E45E0", Offset = "0x68E2BE0", VA = "0x1868E45E0")]
		public (float, float) JBCNMMGLADI(Animator CPJANMINGEK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x68E47F0", Offset = "0x68E2DF0", VA = "0x1868E47F0")]
		private (float, float) KKMHDHBAKBG(Animator CPJANMINGEK, AnimatorStateInfo PBDPIGFMPEM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x68E4A00", Offset = "0x68E3000", VA = "0x1868E4A00")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x68EA630", Offset = "0x68E8C30", VA = "0x1868EA630", Slot = "4")]
		public override void OnStateEnter(Animator CPJANMINGEK, AnimatorStateInfo PBDPIGFMPEM, int ELIDCHMIIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x68EA7A0", Offset = "0x68E8DA0", VA = "0x1868EA7A0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class KOBOCKMAGOB<TInput, TOutput> : JEDLHPNLHIF<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	protected readonly PKAMEBFLEIB GAECPNEAIFK;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x41C7AA0", Offset = "0x41C60A0", VA = "0x1841C7AA0")]
	protected KOBOCKMAGOB(PKAMEBFLEIB GAECPNEAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput OJPHNAHFOOE(TInput BNBKMKBLLLG, [Out] IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x41C7A00", Offset = "0x41C6000", VA = "0x1841C7A00", Slot = "5")]
	public bool BAOHJFIHBPA(TInput BNBKMKBLLLG, [Out] TOutput? IAFCFGOKEAK, [Out] IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[OBKEFOLKLJN]
public static class HIOBCIFIJNE
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static readonly Regex MOGBBIIMPJO;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x68E3AE0", Offset = "0x68E20E0", VA = "0x1868E3AE0")]
	public static APEPIKMHPEE ANAFIKHDBJI(DIBKDMJIGJP IJMBHINBANJ, NAJCLKBNHFG HMGKHFECAIP, Guid? OGDBLHEOKHP, Color? IGPFEJDMKAK, JNJJMPPHJEI ANOHNNKPBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x68E3CF0", Offset = "0x68E22F0", VA = "0x1868E3CF0")]
	public static IIGFKAAIIHK LDLLLLCLFMD(APEPIKMHPEE MMDLBEBNCGC)
	{
		return default(IIGFKAAIIHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2BA63A0", Offset = "0x2BA49A0", VA = "0x182BA63A0")]
	internal static TModern? IOCKANPIFEM<TModern>(string? BNBKMKBLLLG, NHEFIAGPNID<TModern> HNNAOAIENLN, PKAMEBFLEIB GAECPNEAIFK, ABDADLDIIHE FHDMCKPGAHF, TModern JABJHFBFNAL) where TModern : struct, PKCEIIEOBOB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4CE0", Offset = "0x2BA32E0", VA = "0x182BA4CE0")]
	internal static NMOPJHLLFGI ALBFCJJOLJN<TModern>(string? BNBKMKBLLLG, NHEFIAGPNID<TModern> HNNAOAIENLN, PKAMEBFLEIB GAECPNEAIFK, ABDADLDIIHE FHDMCKPGAHF, TModern JABJHFBFNAL) where TModern : struct, PKCEIIEOBOB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x68E3FE0", Offset = "0x68E25E0", VA = "0x1868E3FE0")]
	internal static List<DDGJNLGHJFM> LMJNKNIEAIK(IEnumerable<FDIIOJMHIHC>? CJPPNPMAHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2BA54F0", Offset = "0x2BA3AF0", VA = "0x182BA54F0")]
	internal static string EFHGBAOAJIF<TModern>(TModern BNBKMKBLLLG, NHEFIAGPNID<TModern> HNNAOAIENLN, PKAMEBFLEIB GAECPNEAIFK) where TModern : PKCEIIEOBOB
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class LJPAHLLKLOM : IGHOIOGENCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JEDLHPNLHIF<LAFHIKFJEKF, PANBOAAKJAE> JIGBGHMODMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JEDLHPNLHIF<OMPHBNLEMFF, EAIIBKNMIAM> DMFHJHLCPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public JEDLHPNLHIF<OMPHBNLEMFF, EAIIBKNMIAM> AOIBPDIEFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GBFIAGACMJH NJAKPPIKAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public OBODLHFOMCO FNCMOANMDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x68E98F0", Offset = "0x68E7EF0", VA = "0x1868E98F0")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.GameOnly)]
	[UsedImplicitly]
	private static void BDACIGIPHCC(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x68E9960", Offset = "0x68E7F60", VA = "0x1868E9960")]
	[Preserve]
	internal LJPAHLLKLOM([JAMCDGPOOBO("UnitySerialization")] BHLMMKCDIDD MLIANCPIJAJ, [JAMCDGPOOBO(null)] IIHHJNFJGAC PHFMADOPDOC, [JAMCDGPOOBO(null)] PKAMEBFLEIB GAECPNEAIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum BNFHDBCLOKB
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CIGHJOEMHDB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x68E0FE0", Offset = "0x68DF5E0", VA = "0x1868E0FE0")]
	public CIGHJOEMHDB(string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x68E0F40", Offset = "0x68DF540", VA = "0x1868E0F40")]
	public CIGHJOEMHDB(string ELIMFPDKMPD, Exception INPOOCPJGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x68E0F70", Offset = "0x68DF570", VA = "0x1868E0F70")]
	public CIGHJOEMHDB(BNFHDBCLOKB NLEFOCHONMJ, string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x68E0FA0", Offset = "0x68DF5A0", VA = "0x1868E0FA0")]
	public CIGHJOEMHDB(BNFHDBCLOKB NLEFOCHONMJ, string ELIMFPDKMPD, Exception INPOOCPJGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class EHLLHEDAPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly BHLMMKCDIDD MLIANCPIJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	protected readonly IIHHJNFJGAC PHFMADOPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	protected readonly PKAMEBFLEIB GAECPNEAIFK;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x68E3040", Offset = "0x68E1640", VA = "0x1868E3040")]
	protected EHLLHEDAPAD(BHLMMKCDIDD MLIANCPIJAJ, IIHHJNFJGAC PHFMADOPDOC, PKAMEBFLEIB GAECPNEAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x68E1BF0", Offset = "0x68E01F0", VA = "0x1868E1BF0")]
	protected string MAIHHMOHIOA(PANBOAAKJAE HEDFAKOOGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x68E1A00", Offset = "0x68E0000", VA = "0x1868E1A00")]
	protected string JGBGPPIFDAE(PANBOAAKJAE HEDFAKOOGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x68E1690", Offset = "0x68DFC90", VA = "0x1868E1690")]
	private AvatarOutfitSelectionData ANAFIKHDBJI(APEPIKMHPEE OJLGCBLPPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x68E2F00", Offset = "0x68E1500", VA = "0x1868E2F00")]
	private static AvatarCustomizationSettingsData.AnchorParams PKMHENDDFHK(CMMPCECIIBE? IDKCOIPPEHL)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JEDLHPNLHIF<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput OJPHNAHFOOE(TInput BNBKMKBLLLG, [Out] IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BAOHJFIHBPA(TInput BNBKMKBLLLG, [Out] TOutput? IAFCFGOKEAK, [Out] IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IGHOIOGENCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	JEDLHPNLHIF<LAFHIKFJEKF, PANBOAAKJAE> JIGBGHMODMM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JEDLHPNLHIF<OMPHBNLEMFF, EAIIBKNMIAM> AOIBPDIEFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	GBFIAGACMJH NJAKPPIKAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum ABDADLDIIHE
{
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OBODLHFOMCO
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFLIHKMKFHJ PEGIGFCKLEH(PANBOAAKJAE MMDLBEBNCGC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GBFIAGACMJH
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMPHBNLEMFF PEGIGFCKLEH(PANBOAAKJAE MMDLBEBNCGC, int FOHLLJFLLPN, string? GJEDHMJMNJA, string? EEGOHJAELPL, JJEPHBBIFMN DJFONDNNOON, List<DDGJNLGHJFM>? PEGPPBOCHIE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[OBKEFOLKLJN]
internal class JHMDOAMHHOF : KOBOCKMAGOB<LAFHIKFJEKF, PANBOAAKJAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly IIHHJNFJGAC PHFMADOPDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly KOLIIDFGNHI FMNGLALHCII;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x68E69B0", Offset = "0x68E4FB0", VA = "0x1868E69B0")]
	public JHMDOAMHHOF(BHLMMKCDIDD MLIANCPIJAJ, IIHHJNFJGAC PHFMADOPDOC, PKAMEBFLEIB GAECPNEAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x68E6700", Offset = "0x68E4D00", VA = "0x1868E6700", Slot = "6")]
	public override PANBOAAKJAE OJPHNAHFOOE(LAFHIKFJEKF BNBKMKBLLLG, [Out] IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class ECIIOJNFIED : BHLMMKCDIDD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class OADBHAOEOIO : JsonConverter<NMOPJHLLFGI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x68EA8E0", Offset = "0x68E8EE0", VA = "0x1868EA8E0", Slot = "9")]
		public override void WriteJson(JsonWriter JFIDOOOHFIL, NMOPJHLLFGI? DMNGPNKHPKF, JsonSerializer JBDHPKKOEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x68EA7C0", Offset = "0x68E8DC0", VA = "0x1868EA7C0", Slot = "10")]
		public override NMOPJHLLFGI ReadJson(JsonReader MMDEOFGAFEK, Type DBPNFFLNOOP, NMOPJHLLFGI? KLLMBGBKCEK, bool OEBLCPILHFD, JsonSerializer JBDHPKKOEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x68EA980", Offset = "0x68E8F80", VA = "0x1868EA980")]
		public OADBHAOEOIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class DAMJNGBGPGH : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool DPBFHINDPKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x68E13F0", Offset = "0x68DF9F0", VA = "0x1868E13F0", Slot = "5")]
		public override object ReadJson(JsonReader MMDEOFGAFEK, Type DBPNFFLNOOP, object? KLLMBGBKCEK, JsonSerializer JBDHPKKOEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x68E1010", Offset = "0x68DF610", VA = "0x1868E1010", Slot = "6")]
		public override bool CanConvert(Type DBPNFFLNOOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x68E1450", Offset = "0x68DFA50", VA = "0x1868E1450", Slot = "4")]
		public override void WriteJson(JsonWriter JFIDOOOHFIL, object? DMNGPNKHPKF, JsonSerializer JBDHPKKOEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x68E11F0", Offset = "0x68DF7F0", VA = "0x1868E11F0")]
		private static bool IMJMBGKBHCC(object DMNGPNKHPKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public DAMJNGBGPGH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly JsonSerializerSettings PJGJFAMDILE;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x68E1530", Offset = "0x68DFB30", VA = "0x1868E1530")]
	internal ECIIOJNFIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F960", Offset = "0x2A2DF60", VA = "0x182A2F960", Slot = "4")]
	public string HEACKHFJNHK<T>(T NJKKPOFFNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F8D0", Offset = "0x2A2DED0", VA = "0x182A2F8D0", Slot = "5")]
	public T BEHKKDNLEJO<T>(string DMNGPNKHPKF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Preserve]
internal class CAMMALFILDP : BHLMMKCDIDD
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2996990", Offset = "0x2994F90", VA = "0x182996990", Slot = "4")]
	public string HEACKHFJNHK<T>(T NJKKPOFFNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2996910", Offset = "0x2994F10", VA = "0x182996910", Slot = "5")]
	public T BEHKKDNLEJO<T>(string DMNGPNKHPKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public CAMMALFILDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[OBKEFOLKLJN]
internal class KOLIIDFGNHI : KOBOCKMAGOB<OMPHBNLEMFF, EAIIBKNMIAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly BHLMMKCDIDD MLIANCPIJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly IIHHJNFJGAC PHFMADOPDOC;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x68E9560", Offset = "0x68E7B60", VA = "0x1868E9560")]
	public KOLIIDFGNHI(BHLMMKCDIDD MLIANCPIJAJ, IIHHJNFJGAC PHFMADOPDOC, PKAMEBFLEIB GAECPNEAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x68E89D0", Offset = "0x68E6FD0", VA = "0x1868E89D0", Slot = "6")]
	public override EAIIBKNMIAM OJPHNAHFOOE(OMPHBNLEMFF BNBKMKBLLLG, [Out] IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68E7FD0", Offset = "0x68E65D0", VA = "0x1868E7FD0")]
	internal void LKGOIIBDDNK(string HFONNMLMOPM, PANBOAAKJAE HEDFAKOOGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x68E7020", Offset = "0x68E5620", VA = "0x1868E7020")]
	public IEnumerable<APEPIKMHPEE> ACCALFPIEEN(string BLIMNOGKMIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x68E8130", Offset = "0x68E6730", VA = "0x1868E8130")]
	private IEnumerable<APEPIKMHPEE> MFBLANMEFIN(string BLIMNOGKMIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68E8560", Offset = "0x68E6B60", VA = "0x1868E8560")]
	internal IEnumerable<APEPIKMHPEE> MKCCIAJGNID(string BLIMNOGKMIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x68E8E00", Offset = "0x68E7400", VA = "0x1868E8E00")]
	private APEPIKMHPEE OPHOGNLMKCN(AvatarOutfitSelectionData MKFCJIBCCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x68E70D0", Offset = "0x68E56D0", VA = "0x1868E70D0")]
	private void DOKMLCOKCKD(AvatarCustomizationSettingsData DCJGHCKNBIG, PANBOAAKJAE HEDFAKOOGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x68E91D0", Offset = "0x68E77D0", VA = "0x1868E91D0")]
	private APEPIKMHPEE OPHOGNLMKCN(string OEOMMBENDJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68E7AD0", Offset = "0x68E60D0", VA = "0x1868E7AD0")]
	internal static (JNJJMPPHJEI, string, string) JEIKBAKBGNH(string OEOMMBENDJK, PKAMEBFLEIB GAECPNEAIFK)
	{
		return default((JNJJMPPHJEI, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68E7DD0", Offset = "0x68E63D0", VA = "0x1868E7DD0")]
	private KIBMMBGHFBO? LFAIHAGFFFF(string? IJNLNGBKEAC, Vector2 KLBHDOICAKF, float GEOOJJOLFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x68E7970", Offset = "0x68E5F70", VA = "0x1868E7970")]
	private static CMMPCECIIBE IKPEAOIANBE(AvatarCustomizationSettingsData.AnchorParams HMOGOKCBKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[OBKEFOLKLJN]
internal class LKKBCKNHPAA : EHLLHEDAPAD, OBODLHFOMCO
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x68E3040", Offset = "0x68E1640", VA = "0x1868E3040")]
	public LKKBCKNHPAA(BHLMMKCDIDD MLIANCPIJAJ, IIHHJNFJGAC PHFMADOPDOC, PKAMEBFLEIB GAECPNEAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x68EA180", Offset = "0x68E8780", VA = "0x1868EA180", Slot = "4")]
	public BFLIHKMKFHJ PEGIGFCKLEH(PANBOAAKJAE MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x68EA530", Offset = "0x68E8B30", VA = "0x1868EA530")]
	private string PMGEPHCCGFA(PANBOAAKJAE HEDFAKOOGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x68E9EC0", Offset = "0x68E84C0", VA = "0x1868E9EC0")]
	private string ANLMFADJCIP(APEPIKMHPEE OJLGCBLPPNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[OBKEFOLKLJN]
internal class PHNLJDMBKCG : KOBOCKMAGOB<OMPHBNLEMFF, EAIIBKNMIAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly BHLMMKCDIDD MLIANCPIJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly JEDLHPNLHIF<OMPHBNLEMFF, EAIIBKNMIAM> LGADDHJDHOJ;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x68EADF0", Offset = "0x68E93F0", VA = "0x1868EADF0")]
	public PHNLJDMBKCG(JEDLHPNLHIF<OMPHBNLEMFF, EAIIBKNMIAM> LGADDHJDHOJ, PKAMEBFLEIB GAECPNEAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x68EA9C0", Offset = "0x68E8FC0", VA = "0x1868EA9C0", Slot = "6")]
	public override EAIIBKNMIAM OJPHNAHFOOE(OMPHBNLEMFF BNBKMKBLLLG, [Out] IReadOnlyList<DDGJNLGHJFM>? PEGPPBOCHIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[OBKEFOLKLJN]
internal class KHNONEMIBNI : GBFIAGACMJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly BHLMMKCDIDD MLIANCPIJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly OBODLHFOMCO LJCMBONDIAE;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x68E6F30", Offset = "0x68E5530", VA = "0x1868E6F30")]
	public KHNONEMIBNI(OBODLHFOMCO LJCMBONDIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x68E6B80", Offset = "0x68E5180", VA = "0x1868E6B80", Slot = "4")]
	public OMPHBNLEMFF PEGIGFCKLEH(PANBOAAKJAE MMDLBEBNCGC, int FOHLLJFLLPN, string? GJEDHMJMNJA, string? EEGOHJAELPL, JJEPHBBIFMN DJFONDNNOON, List<DDGJNLGHJFM>? PEGPPBOCHIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Preserve]
internal class IGGFKJHJCGK : ECDOPJEKNOA
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private static readonly Vector2 BOOCPIAPBJL;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly Vector2 ECCKOJGECCB;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly Vector2 PJBBKJJLEEO;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly Vector2 KOPOFCHELDB;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly Vector2 MPCNBINFONH;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly Vector2 MNFAFGFNEJL;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly Vector2 GOPCCAHKFKB;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly Vector2 OOPLLNILAAH;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly Vector2 FDCBCKPEEAB;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly Vector2 MOEKBPHOCEF;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly Vector2 LJGALFBBFFH;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly Vector2 ECOCMFENLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private Dictionary<PGDJCFPPLAG, AvatarConfiguration> JCEPCCKCDPC;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x68E5E20", Offset = "0x68E4420", VA = "0x1868E5E20")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.None)]
	private static void MFCCMFFCMCJ(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x68E6650", Offset = "0x68E4C50", VA = "0x1868E6650")]
	[Preserve]
	internal IGGFKJHJCGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x68E55A0", Offset = "0x68E3BA0", VA = "0x1868E55A0", Slot = "4")]
	public Vector2 GFDLNNOLBEL(FaceFeatureType KEDKCMEKJMN, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68E5910", Offset = "0x68E3F10", VA = "0x1868E5910", Slot = "5")]
	public float ILNJGPLDGBL(FaceFeatureType KEDKCMEKJMN, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68E5E90", Offset = "0x68E4490", VA = "0x1868E5E90", Slot = "6")]
	public void MHPHJFGEFAD(PGDJCFPPLAG IGPCDBJDJOC, AvatarConfiguration NDDODAELILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68E6250", Offset = "0x68E4850", VA = "0x1868E6250", Slot = "7")]
	public float PDJPFHKMCGO(FaceFeatureType OAKMGOIOEPE, float JMIDMMMHLLA, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68E5C30", Offset = "0x68E4230", VA = "0x1868E5C30", Slot = "8")]
	public float KABFDPONHDJ(FaceFeatureType OAKMGOIOEPE, float GEOOJJOLFGB, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x68E5310", Offset = "0x68E3910", VA = "0x1868E5310", Slot = "10")]
	public Vector2 FKHPILEIFOM(FaceFeatureType OAKMGOIOEPE, Vector2 FALBFJBNPOD, Vector2 BHDCBMHNLBO, Vector2 ALIJPMJDICG, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x68E50E0", Offset = "0x68E36E0", VA = "0x1868E50E0", Slot = "9")]
	public Vector2 FBFEGPNFALB(FaceFeatureType OAKMGOIOEPE, Vector2 OMNGDIHHADC, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x68E6360", Offset = "0x68E4960", VA = "0x1868E6360")]
	private Vector2 PGAKIABNPBP(FaceFeatureType OAKMGOIOEPE, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x68E6040", Offset = "0x68E4640", VA = "0x1868E6040")]
	private Vector2 OBKNIMGGIHC(FaceFeatureType OAKMGOIOEPE, Vector2 FALBFJBNPOD, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x68E4CD0", Offset = "0x68E32D0", VA = "0x1868E4CD0", Slot = "11")]
	public Vector2 CLCNKDPHCAO(FaceFeatureType OAKMGOIOEPE, Vector2 OMNGDIHHADC, Vector2 BHDCBMHNLBO, Vector2 ALIJPMJDICG, PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x68E5740", Offset = "0x68E3D40", VA = "0x1868E5740")]
	private float GJKNEJKILFM(float KNJOHLDIOOJ, float JEAHIMKCJFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x68E5890", Offset = "0x68E3E90", VA = "0x1868E5890")]
	private Vector2 IGHEAPCDOLH(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x68E5FC0", Offset = "0x68E45C0", VA = "0x1868E5FC0")]
	private Vector2 NPECPLGMCHA(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x68E5060", Offset = "0x68E3660", VA = "0x1868E5060")]
	private Vector2 DOAPBLCEKKI(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x68E57D0", Offset = "0x68E3DD0", VA = "0x1868E57D0")]
	private Vector2 HJDJCIPEEBL(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x68E5700", Offset = "0x68E3D00", VA = "0x1868E5700")]
	private float GHMKGOMCIPI(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x68E5850", Offset = "0x68E3E50", VA = "0x1868E5850")]
	private float HPLJLHLNCED(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x68E4AD0", Offset = "0x68E30D0", VA = "0x1868E4AD0")]
	private float BAEONOELKGA(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x68E6400", Offset = "0x68E4A00", VA = "0x1868E6400")]
	private float PGEELBONHHA(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x68E5990", Offset = "0x68E3F90", VA = "0x1868E5990")]
	private Vector2 INDDALGKNCF(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x68E5B50", Offset = "0x68E4150", VA = "0x1868E5B50")]
	private Vector2 JEBKGOCIEIE(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x68E54C0", Offset = "0x68E3AC0", VA = "0x1868E54C0")]
	private Vector2 FNHCNONPPLH(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x68E5C60", Offset = "0x68E4260", VA = "0x1868E5C60")]
	private Vector2 LAFDCDNMNPA(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x68E6280", Offset = "0x68E4880", VA = "0x1868E6280")]
	private Vector2 PEEMAHHNPFF(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x68E5A70", Offset = "0x68E4070", VA = "0x1868E5A70")]
	private Vector2 IOLBPJAGDEF(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x68E5D40", Offset = "0x68E4340", VA = "0x1868E5D40")]
	private Vector2 LBFIFCKOPOI(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x68E4B10", Offset = "0x68E3110", VA = "0x1868E4B10")]
	private Vector2 BAMNCHOCLCM(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x68E4BF0", Offset = "0x68E31F0", VA = "0x1868E4BF0")]
	private Vector2 BEEGEKNLMIK(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x68E6190", Offset = "0x68E4790", VA = "0x1868E6190")]
	private Vector2 OHPDKJMBKOG(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x68E4A10", Offset = "0x68E3010", VA = "0x1868E4A10")]
	private Vector2 AMPNNLDAHGA(PGDJCFPPLAG IGPCDBJDJOC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x68E5F00", Offset = "0x68E4500", VA = "0x1868E5F00")]
	private Vector2 NHDIMEJKHHC(PGDJCFPPLAG IGPCDBJDJOC)
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
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x68DECE0", Offset = "0x68DD2E0", VA = "0x1868DECE0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EPCPMBNHNLE
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x68E3230", Offset = "0x68E1830", VA = "0x1868E3230")]
	public static IIGFKAAIIHK OJPHNAHFOOE(this CJGFIMPLKLL MMDLBEBNCGC)
	{
		return default(IIGFKAAIIHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x68E34B0", Offset = "0x68E1AB0", VA = "0x1868E34B0")]
	public static CJGFIMPLKLL PEGIGFCKLEH(this IIGFKAAIIHK IEFBDMLKKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x68E31C0", Offset = "0x68E17C0", VA = "0x1868E31C0")]
	public static bool NBNMFMDCMBK(this IIGFKAAIIHK IEFBDMLKKMK)
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
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4D15AB0", Offset = "0x4D140B0", VA = "0x184D15AB0")]
			public AnchorParams(Vector2 FALBFJBNPOD, Vector3 HHAAIEGMJEP, Vector3 CJPIMOOHIKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x68DEC30", Offset = "0x68DD230", VA = "0x1868DEC30")]
			internal CMMPCECIIBE PEGIGFCKLEH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		private OHLFEAJAGIC useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x68DF500", Offset = "0x68DDB00", VA = "0x1868DF500")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x45E1840", Offset = "0x45DFE40", VA = "0x1845E1840")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x10B3F10", Offset = "0x10B2510", VA = "0x1810B3F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8F76E0", Offset = "0x8F5CE0", VA = "0x1808F76E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xA08240", Offset = "0xA06840", VA = "0x180A08240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x868240", Offset = "0x866840", VA = "0x180868240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x68DF5B0", Offset = "0x68DDBB0", VA = "0x1868DF5B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x874CD0", Offset = "0x8732D0", VA = "0x180874CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8F7690", Offset = "0x8F5C90", VA = "0x1808F7690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x10C0900", Offset = "0x10BEF00", VA = "0x1810C0900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x868CA0", Offset = "0x8672A0", VA = "0x180868CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x68DF5F0", Offset = "0x68DDBF0", VA = "0x1868DF5F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1CF3ED0", Offset = "0x1CF24D0", VA = "0x181CF3ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8F7D70", Offset = "0x8F6370", VA = "0x1808F7D70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xECF290", Offset = "0xECD890", VA = "0x180ECF290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x86AE10", Offset = "0x869410", VA = "0x18086AE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x86ADC0", Offset = "0x8693C0", VA = "0x18086ADC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x413B6C0", Offset = "0x4139CC0", VA = "0x18413B6C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1D379A0", Offset = "0x1D35FA0", VA = "0x181D379A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x89CF10", Offset = "0x89B510", VA = "0x18089CF10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x89CF70", Offset = "0x89B570", VA = "0x18089CF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x86C8D0", Offset = "0x86AED0", VA = "0x18086C8D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x86C8E0", Offset = "0x86AEE0", VA = "0x18086C8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x86C8B0", Offset = "0x86AEB0", VA = "0x18086C8B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x86C8C0", Offset = "0x86AEC0", VA = "0x18086C8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x86C840", Offset = "0x86AE40", VA = "0x18086C840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x86C730", Offset = "0x86AD30", VA = "0x18086C730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x9F6890", Offset = "0x9F4E90", VA = "0x1809F6890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xA3E120", Offset = "0xA3C720", VA = "0x180A3E120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x86C8F0", Offset = "0x86AEF0", VA = "0x18086C8F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x86C7B0", Offset = "0x86ADB0", VA = "0x18086C7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA1BD30", Offset = "0xA1A330", VA = "0x180A1BD30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x9FB860", Offset = "0x9F9E60", VA = "0x1809FB860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x870C20", Offset = "0x86F220", VA = "0x180870C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x870C00", Offset = "0x86F200", VA = "0x180870C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8DE280", Offset = "0x8DC880", VA = "0x1808DE280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xBCF310", Offset = "0xBCD910", VA = "0x180BCF310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8ECC30", Offset = "0x8EB230", VA = "0x1808ECC30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x8ECBD0", Offset = "0x8EB1D0", VA = "0x1808ECBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OHLFEAJAGIC UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1DBC520", Offset = "0x1DBAB20", VA = "0x181DBC520")]
			get
			{
				return default(OHLFEAJAGIC);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1DBAEB0", Offset = "0x1DB94B0", VA = "0x181DBAEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5020", Offset = "0xAA3620", VA = "0x180AA5020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA37E0", Offset = "0xAA1DE0", VA = "0x180AA37E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x68DF5D0", Offset = "0x68DDBD0", VA = "0x1868DF5D0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x68DF610", Offset = "0x68DDC10", VA = "0x1868DF610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x68DF160", Offset = "0x68DD760", VA = "0x1868DF160")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public JNJJMPPHJEI BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private FPLOGOPHJCG? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x68E0840", Offset = "0x68DEE40", VA = "0x1868E0840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
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
