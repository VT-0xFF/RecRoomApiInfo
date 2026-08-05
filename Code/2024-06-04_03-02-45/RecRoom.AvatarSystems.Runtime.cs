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
using RecRoom;
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6733270", Offset = "0x6731A70", VA = "0x186733270")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[BFNFAOFCCLN]
internal class FLBHCHBMAOD : GDLNNNKECMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct OFKCLIPHALP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public FLBHCHBMAOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public JNBBILMHJPI avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly ALEOINHOJJA MCFMAFGJACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BODLEHFMNJM EFEIEEFBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FCCCCLHBAGC EOACFKLOMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly OBBNHONMJAJ NEELAPDINAE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6730050", Offset = "0x672E850", VA = "0x186730050")]
	[ANLGLDAOJJE(KKPEBAHBECP.Root, ELBANFBEGNE.GameOnly)]
	[UsedImplicitly]
	private static void MLMGKKCDOHM(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6730870", Offset = "0x672F070", VA = "0x186730870")]
	[Preserve]
	internal FLBHCHBMAOD([GNKLNMHODGG(null)] ALEOINHOJJA MCFMAFGJACE, [GNKLNMHODGG(null)] BODLEHFMNJM EFEIEEFBKKG, [GNKLNMHODGG(null)] FCCCCLHBAGC EOACFKLOMCD, [GNKLNMHODGG(null)] OBBNHONMJAJ NEELAPDINAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67300C0", Offset = "0x672E8C0", VA = "0x1867300C0", Slot = "5")]
	public BGEKPNHNABN PNDIOGLFBHH(bool BKELHAELDAG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x672F610", Offset = "0x672DE10", VA = "0x18672F610", Slot = "4")]
	public BGEKPNHNABN IHGBLEBGFIE(bool BKELHAELDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x672F500", Offset = "0x672DD00", VA = "0x18672F500", Slot = "6")]
	public PIJELOHKNKB FNPHIEMHJML(BGEKPNHNABN MLKNGAFFKGE, int MPGHECCBKFA, string? GCDLMFGKKMH, string? NHKBHFHBLIH, ODGMKINPFBN FNGANFOBOIH, List<BKGGCPNPCAA>? HAPHEALFDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x672EFE0", Offset = "0x672D7E0", VA = "0x18672EFE0", Slot = "7")]
	public bool EOKOLNLLCMI(AHDOLPLLHFG MEJBEJHMLPO, [Out] BGEKPNHNABN? LGJMDPAEIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x672EF00", Offset = "0x672D700", VA = "0x18672EF00", Slot = "8")]
	public bool COIKPIEIOBK(PIJELOHKNKB PGGBHJAAIEH, [Out] BGEKPNHNABN? LGJMDPAEIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x672FFC0", Offset = "0x672E7C0", VA = "0x18672FFC0", Slot = "9")]
	public bool JCIHKICNBOK(PIJELOHKNKB PGGBHJAAIEH, [Out] DHFKGLJPJBM? MEJBEJHMLPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A78B40", Offset = "0x2A77340", VA = "0x182A78B40")]
	private bool DGKAILEPCIM<TInput, TOutput>(TInput FDJIPPJKNDH, LHCHKHEBAOH<TInput, TOutput> JDEHFBLCDPH, [Out] TOutput? KKBKNCNBBJP) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x672F070", Offset = "0x672D870", VA = "0x18672F070")]
	[CompilerGenerated]
	private NCAGCDFGCMA FAPKFJBPBGD(FaceFeatureType KHIDKLAJDFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x672F220", Offset = "0x672DA20", VA = "0x18672F220")]
	[CompilerGenerated]
	private NCAGCDFGCMA FGHEMIICFAI(FaceFeatureType KHIDKLAJDFE, OFKCLIPHALP P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BFNFAOFCCLN]
internal class PBOOMJJOFGI : ALEOINHOJJA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void GLJLGNBLEKD<in TData>(TData LGJMDPAEIIH, IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly FCCCCLHBAGC EOACFKLOMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KOLINNPELBE AHILIMBPIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GLJLGNBLEKD<BGEKPNHNABN>?[] MCFMAFGJACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GLJLGNBLEKD<DHFKGLJPJBM>?[] IGPIFCEGFAN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6734A70", Offset = "0x6733270", VA = "0x186734A70")]
	[ANLGLDAOJJE(KKPEBAHBECP.Root, ELBANFBEGNE.GameOnly)]
	[UsedImplicitly]
	private static void MLMGKKCDOHM(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6735740", Offset = "0x6733F40", VA = "0x186735740")]
	[Preserve]
	internal PBOOMJJOFGI([GNKLNMHODGG(null)] FCCCCLHBAGC EOACFKLOMCD, [GNKLNMHODGG(null)] KOLINNPELBE AHILIMBPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6734970", Offset = "0x6733170", VA = "0x186734970", Slot = "4")]
	public bool AGLJDJJAIIN(BGEKPNHNABN LGJMDPAEIIH, IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6734810", Offset = "0x6733010", VA = "0x186734810", Slot = "5")]
	public bool AGLJDJJAIIN(DHFKGLJPJBM MEJBEJHMLPO, IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6734AE0", Offset = "0x67332E0", VA = "0x186734AE0")]
	private void MNEEKIGIHBM(BGEKPNHNABN LGJMDPAEIIH, IReadOnlyList<BKGGCPNPCAA>? NOFEINPOGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6735510", Offset = "0x6733D10", VA = "0x186735510")]
	private void NNNHILBJKJN(BGEKPNHNABN LGJMDPAEIIH, IReadOnlyList<BKGGCPNPCAA>? NOFEINPOGPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ALEOINHOJJA
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGLJDJJAIIN(BGEKPNHNABN LGJMDPAEIIH, IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGLJDJJAIIN(DHFKGLJPJBM MEJBEJHMLPO, IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarElbowBendHelperController : MonoBehaviour, HPACEKLCMOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private bool DebugExecutionInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Vector3? BHECABMJHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool ENICKGKNCEL;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6718370", Offset = "0x6716B70", VA = "0x186718370", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6718960", Offset = "0x6717160", VA = "0x186718960", Slot = "4")]
		public void UpdateController(float PNBNBIDOECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xE2E590", Offset = "0xE2CD90", VA = "0x180E2E590", Slot = "6")]
		public void SetEnabled(bool IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6718410", Offset = "0x6716C10", VA = "0x186718410")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6718D80", Offset = "0x6717580", VA = "0x186718D80")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendTargetController : MonoBehaviour, HPACEKLCMOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const float PFIMNEFGEEG = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Vector3 DAJOMFMHMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Vector3 GOFAJDJOAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool ENICKGKNCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float KABLKILPBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private float IKFNGIHEJLH;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6719100", Offset = "0x6717900", VA = "0x186719100", Slot = "4")]
		public void UpdateController(float PNBNBIDOECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB56250", Offset = "0xB54A50", VA = "0x180B56250", Slot = "6")]
		public void SetEnabled(bool IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6718E20", Offset = "0x6717620", VA = "0x186718E20")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6719CC0", Offset = "0x67184C0", VA = "0x186719CC0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x671A5D0", Offset = "0x6718DD0", VA = "0x18671A5D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x671A590", Offset = "0x6718D90", VA = "0x18671A590")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6719CF0", Offset = "0x67184F0", VA = "0x186719CF0")]
		private void LLGHLEHEJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x66EADD0", Offset = "0x66E95D0", VA = "0x1866EADD0", Slot = "4")]
		public void SetEnabled(bool JKFJGFGHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x671A600", Offset = "0x6718E00", VA = "0x18671A600")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarForearmRollController : MonoBehaviour, HPACEKLCMOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool ENICKGKNCEL;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x671A640", Offset = "0x6718E40", VA = "0x18671A640", Slot = "4")]
		public void UpdateController(float PNBNBIDOECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x854510", Offset = "0x852D10", VA = "0x180854510", Slot = "6")]
		public void SetEnabled(bool IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x671ADB0", Offset = "0x67195B0", VA = "0x18671ADB0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, GPJPKABEJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private GDBHNPFGFMA PPIOENFLOAM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GDBHNPFGFMA LOGMNECDIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x671BB20", Offset = "0x671A320", VA = "0x18671BB20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform HIFHCBPDOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x671BB60", Offset = "0x671A360", VA = "0x18671BB60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x671ADE0", Offset = "0x67195E0", VA = "0x18671ADE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x671B9E0", Offset = "0x671A1E0", VA = "0x18671B9E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x671B990", Offset = "0x671A190", VA = "0x18671B990")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x671B920", Offset = "0x671A120", VA = "0x18671B920")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x671B810", Offset = "0x671A010", VA = "0x18671B810", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x671B920", Offset = "0x671A120", VA = "0x18671B920", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x671B4E0", Offset = "0x6719CE0", VA = "0x18671B4E0", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x671BA30", Offset = "0x671A230", VA = "0x18671BA30", Slot = "8")]
		public void UpdatePostIKAnimControllers(float PNBNBIDOECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x671B890", Offset = "0x671A090", VA = "0x18671B890")]
		private void JDMACKAGHCO(GameObject GHDJADLHPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x671AE60", Offset = "0x6719660", VA = "0x18671AE60")]
		private GDBHNPFGFMA BBKICAPNEKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public AvatarFullBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct WeightData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is turned off.")]
			public float AngleOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is fully on.")]
			public float AngleOn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[Tooltip("Normalized height (0-1) where IK is turned off.")]
			public float HeightOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[Tooltip("Normalized height (0-1) where IK is fully on.")]
			public float HeightOn;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x67369C0", Offset = "0x67351C0", VA = "0x1867369C0")]
			public float OMCKFHNCKJK(float KEPCOKEGBGP, float JKIIOKFDMKL)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Time axis is the normalized distance the hand effector currently is from the origin of the upper arm bone.  A time of 0 implies the hand effector is directly on top of the upper arm origin (ie: up at your shoulder), a time = 1, that implies the hand effector is somewhere exactly a full arm's length away, a time of 1.7 implies the hand effector is somewhere exactly 1.7 times the arm's length away.  Value axis is the effector weight from 0 to 1.")]
		[Header("Hand Animation")]
		public AnimationCurve HandEffectorWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Time that the hand animator weight changes from 0 to 1 in a second. When the hand gesture system turns on when making a gesture, and off when the gesture system is idle, this determines the speed that it lerps towards the target weight.")]
		public float HandAnimatorWeightChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Time it takes to transition to an open or closed hand pose during an animated hand state transition")]
		public float HandOpenCloseChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F5")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Header("IK Weights")]
		[Tooltip("Control data for when to allow IK to control the head position for screens players.")]
		public WeightData ScreenHeadPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Control data for when to allow IK to control the head rotation for screens players.")]
		public WeightData ScreenHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Control data for when to allow IK to control the pelvis position for screens players.")]
		public WeightData ScreenPelvisPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Control data for when to allow IK to control the pelvis rotation for screens players.")]
		public WeightData ScreenPelvisRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("The head is moved flat forward with given amount in VR to match up with our animated head position.")]
		[Header("VR runtime weights")]
		public float StaticHeadForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("The animated root is moved flat forward with given amount in VR to match up the physical feet with our animated feet.")]
		public float StaticRootForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Weight for head while moving. (0 = animated, 1 = VR)")]
		public float MovingHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Weight for head while idle. (0 = animated, 1 = VR)")]
		public float IdleHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Max head height offset compensation")]
		public float MaxHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Min head height offset compensation")]
		public float MinHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Head height offset compensation smooth time")]
		public float HeadHeightCompensationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("Distance to apply head movement dampening")]
		public float HeadHeightDampeningDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		[Header("Body Twisting")]
		public float VRShoulderTwistBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x671BB80", Offset = "0x671A380", VA = "0x18671BB80")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PMFIEMECKHO : GFOLMCEBPKC
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static int LPIEEJIECNK;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int HFNFJKFHIPA;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int LMJMKCDGOHB;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int NNLDBKNGFMH;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static int NDAPGHDCFKJ;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static int PNOCAKMNMIH;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static int AFFKIOGAAGP;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int CIKLCIEKOFH;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int HJEDLPMKOEH;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static int[] OFBFADADOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	internal bool ANNLPMNLBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private BGNLIMAENOB BAPOHANEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private int COKAJICBMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private float BJFKAHDFBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool FOLMEPAFBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Animator EKKFHJNPGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AvatarFullBodyConfiguration LOPCAOGKDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int AIPJAFGDGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int JDFJOIGPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int JEHFCABLDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool NJIBMMABLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private FMEDBBIHPJK OJGIMOOHIFL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform MEEFDAFIIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 DIKIOLNGAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD80900", Offset = "0xD7F100", VA = "0x180D80900")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD80880", Offset = "0xD7F080", VA = "0x180D80880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion HNALINCAPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1B4D7F0", Offset = "0x1B4BFF0", VA = "0x181B4D7F0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1EB47B0", Offset = "0x1EB2FB0", VA = "0x181EB47B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KGKILIPHNPL MJPPDKACGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1238330", Offset = "0x1236B30", VA = "0x181238330", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(KGKILIPHNPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x12712A0", Offset = "0x126FAA0", VA = "0x1812712A0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KGKILIPHNPL IICLBJFBFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x851420", Offset = "0x84FC20", VA = "0x180851420", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(KGKILIPHNPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x851430", Offset = "0x84FC30", VA = "0x180851430", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public float CKODHDOCHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1007220", Offset = "0x1005A20", VA = "0x181007220", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC2BD30", Offset = "0xC2A530", VA = "0x180C2BD30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EAGKFDMFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67361A0", Offset = "0x67349A0", VA = "0x1867361A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool ICHNACGNOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6736210", Offset = "0x6734A10", VA = "0x186736210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DJAGHLHFIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6735B30", Offset = "0x6734330", VA = "0x186735B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6735B60", Offset = "0x6734360", VA = "0x186735B60", Slot = "19")]
	public void DIHNAABPOCM(BGNLIMAENOB OOJGOAFIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6735B20", Offset = "0x6734320", VA = "0x186735B20", Slot = "20")]
	public void AFMGLGKKKOC(HINONINHLCH EIPGPNFAEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6736270", Offset = "0x6734A70", VA = "0x186736270", Slot = "11")]
	public void LAEDPMPNAGG(bool IOAFJLAKIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6735D20", Offset = "0x6734520", VA = "0x186735D20", Slot = "10")]
	public void DKPFNNLPMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6736030", Offset = "0x6734830", VA = "0x186736030")]
	private int GLBHHMBOMHE(KGKILIPHNPL CPDJCCMNOOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67359F0", Offset = "0x67341F0", VA = "0x1867359F0")]
	private void ABEJLEJFIEC(int NAKJNOOFGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6736020", Offset = "0x6734820", VA = "0x186736020", Slot = "12")]
	public bool FGGCADFOBEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67361B0", Offset = "0x67349B0", VA = "0x1867361B0", Slot = "13")]
	public bool GPDOHNLHNJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6736220", Offset = "0x6734A20", VA = "0x186736220")]
	private KGKILIPHNPL KMAIAIJCPEL()
	{
		return default(KGKILIPHNPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xEAFBC0", Offset = "0xEAE3C0", VA = "0x180EAFBC0", Slot = "14")]
	public void LNNHDHKHMIC(bool IOAFJLAKIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6735B40", Offset = "0x6734340", VA = "0x186735B40", Slot = "9")]
	public void BPABIKKJMNM(int NAKJNOOFGGJ, float CMMHCOBALGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6736000", Offset = "0x6734800", VA = "0x186736000", Slot = "7")]
	public void FBAMEDBACEJ(FMEDBBIHPJK DAGLKLOEBMA, bool GBHPPBEDPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6735B50", Offset = "0x6734350", VA = "0x186735B50", Slot = "8")]
	public void CHCJPAKPIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x67361C0", Offset = "0x67349C0", VA = "0x1867361C0", Slot = "15")]
	public void HCHKJFEMAIF(Transform GGJNHHDMGON, Vector3 AMLFGBAFEIN, Quaternion BCLJBLAEDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67365E0", Offset = "0x6734DE0", VA = "0x1867365E0")]
	public PMFIEMECKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class FJLHNGKBCLN : GDBHNPFGFMA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class OEPPNFNDBNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private float MHJPKLILMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private Vector3 BEJNABAPIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private bool CHLEBHOBPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private float KCOJFKCFOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private bool HBNALOMDLPM;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool EHPAOPPFEJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x67342C0", Offset = "0x6732AC0", VA = "0x1867342C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x67347E0", Offset = "0x6732FE0", VA = "0x1867347E0")]
		public void OIENOOAIEPI(IKSolverVR.Arm CAGMFEEICAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6733530", Offset = "0x6731D30", VA = "0x186733530")]
		public void DFFAMIEKGJC(IKSolverVR.Arm CAGMFEEICAF, Transform JFAEHLJIKPP, bool EJFELBMEINM, AvatarFullBodyConfiguration LNOEPHEPJGF, float BPLAJCFEKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6733750", Offset = "0x6731F50", VA = "0x186733750")]
		public void DKKEMKFIAGL(IKSolverVR.Arm CAGMFEEICAF, bool MLCNBMFHPFN, bool HBNALOMDLPM, AvatarFullBodyConfiguration LNOEPHEPJGF, float BPLAJCFEKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6733440", Offset = "0x6731C40", VA = "0x186733440")]
		private void DECKPAMKDJN(Transform JFAEHLJIKPP, IKSolverVR.Arm CAGMFEEICAF, float KMDOJCAPKMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x67342E0", Offset = "0x6732AE0", VA = "0x1867342E0")]
		private void LHFPJCKJNPD(bool EJFELBMEINM, AvatarFullBodyConfiguration LNOEPHEPJGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6734040", Offset = "0x6732840", VA = "0x186734040")]
		private void HGLIFCKNAMB(AvatarFullBodyConfiguration LNOEPHEPJGF, float BPLAJCFEKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6734280", Offset = "0x6732A80", VA = "0x186734280")]
		private void KKEPKJFBADG(IKSolverVR.Arm CAGMFEEICAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6733800", Offset = "0x6732000", VA = "0x186733800")]
		public void FFNOJFDOABI(IKSolverVR.Arm CAGMFEEICAF, Transform MJOIOEIJLAP, Transform BPLJDPCGLLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6734350", Offset = "0x6732B50", VA = "0x186734350")]
		private (Vector3, Quaternion) MFNIDNIBCLK(PMFIEMECKHO BIFNNNANNAL, Quaternion MOJCBNCICPL, Vector3 JIBAKJLOGAO)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x67332F0", Offset = "0x6731AF0", VA = "0x1867332F0")]
		public void ANCBPACKNJE(PMFIEMECKHO BIFNNNANNAL, IKSolverVR.Arm CAGMFEEICAF, Quaternion MOJCBNCICPL, Vector3 JIBAKJLOGAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67339C0", Offset = "0x67321C0", VA = "0x1867339C0")]
		public void FJKNHKBPAHN(PMFIEMECKHO BIFNNNANNAL, IKSolverVR.Arm CAGMFEEICAF, Quaternion MOJCBNCICPL, Vector3 JIBAKJLOGAO, [In] AvatarFullBodyConfiguration LNOEPHEPJGF, [In] EIDPIMGLEDN DAGLKLOEBMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6733FB0", Offset = "0x67327B0", VA = "0x186733FB0")]
		private static float GOIIOIINBLP(bool JKFJGFGHFNB, float MJKLMDKBKCG, float NFEHNAJICGB, float MCBBDGJNHAF, float BPLAJCFEKPB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67340D0", Offset = "0x67328D0", VA = "0x1867340D0")]
		private static void IIEDKOIOHIM(Transform LCJBJNBGBNF, Transform AAODFNNEAJC, Transform ODHIIKMOFHL, float KAAIGOFGIDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OEPPNFNDBNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private enum BADJGIKAMGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum APOFHCPADCA
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int EJLNHEPEBNA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int HJPJKEDHDPB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int IKMOIOPHDPB;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int AJIAIHGGLEL;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int BPBFNMFGEMD;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int AFDOCJKDMDM;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int CNENFNGCFPJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int GBHKPGGHHON;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int CJOAIOPICEO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int KOPLGDJFDLO;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int DPMFONLFOAA;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int HLFAPFGJNLI;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int JNDJMJDHFLP;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int NJMKPFPHCFA;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int NLLIDLOBEMG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int EJEEHDBLJED;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int EPHEPBGIICH;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int BAKDNHOENKF;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int FBFLHHGJAIO;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int AENIDPMPHPC;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int LDOMEMPCIFF;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int NFAIJNENAAP;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int MJJEKBGIBLD;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int EFKOHIPLMHL;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int ADPGPHJOEEA;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int KPCGEGJALDH;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int BKPFMEBJILD;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int FIAPINKFIDJ;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int GBBPOHCGDPP;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int GDAGPBECNGF;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly Vector3 MMOGCGALBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool BIAOAECDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool CIBHMDHNPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool BECGEJCIDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool OLKBJACIEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool ODHAAGLBEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 BJNKOAMPMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private CFHNEDCHEKI? BAPOHANEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NNPAMPJFNNC? HHKMMDAPJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private JCKGAIJDIGB HPIEJOAMION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private JNLADMGFMMH MEIBJFFKPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private PMFIEMECKHO PFAPBPHMDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private PMFIEMECKHO DNGIAAEJCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private bool ILOPFFNHEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x219")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool CDIODDLEOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly IJLHJEFCCNB NFHGKBEIJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly CKBOBKDMADL ECFGFNELFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private int ODMOAPANJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float FOPDFOLMIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GameObject FCBJFBFBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Transform DDNFEMCJJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Transform KNBAOJEPLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float IMBDMEAPBLP;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker HACGAFAEBGE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker PIMFGELJPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private ProfilerMarker MJCIKELKGAP;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly ProfilerMarker KBMAMMNLNNA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ProfilerMarker IODPGIAMGKK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ProfilerMarker MIPDJFHGOIF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly List<FJLHNGKBCLN> MGBPBGCCPEE;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int KLCADCIMDOJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> COIKOCKAKCP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static int KMDOGGAGFKO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int BDLLGNOOHAG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int JLNOLOFCCHI;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static int LEGODBBPEPP;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float GNKCINLAFJA;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int DLBOBFMBMMN;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static float FCNDCAOOGID;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float JMGANJHDCEM;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static float JIOJMCGBADD;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static float GBMGOJGBCDK;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static GJOMLAFHMKF CNLEMOLEEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float BNBNBAJNGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool PPMIEDHFEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private float BDDGBCCNJIC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Quaternion JDGGIKHFNAB;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Quaternion KILOFDBKOFJ;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly Vector3 HCFIPNDIIOF;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Vector3 IPFNJLINOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private OEPPNFNDBNI IAIMBCIOLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private OEPPNFNDBNI LELJNGNNJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private BADJGIKAMGN FEFGKAOEBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float CACBCCJIGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly LGFOMMDLEPN GEBKFLLCMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float GODONFPPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float PHCAOCKCDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 JDKEMMLHKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly LCEEAOGCJGM LGGOJPNILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly EGCKDGNKCBG MLFPNOPIDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float FAJGICHLLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private BADJGIKAMGN GMNOOFMNGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private Vector3 HNHOKEHFMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float LGLEMMACJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float BJKAGELEPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private NNGCEKHLECH LOKNFKDADJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private LCEEAOGCJGM GHDDFOBMGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly LCEEAOGCJGM MCNCFBKDFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly NNGCEKHLECH DKBIFNEOKCP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LFHDLKLNBFG COMINOEIDIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LFHDLKLNBFG FEILIEEJPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public AvatarConfiguration FKCODEIKNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6723CA0", Offset = "0x67224A0", VA = "0x186723CA0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AvatarFullBodyConfiguration EAAAPFKKMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x671E2F0", Offset = "0x671CAF0", VA = "0x18671E2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Transform HLKJBHKMFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6726C70", Offset = "0x6725470", VA = "0x186726C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Transform DDLHBHNBBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x67244D0", Offset = "0x6722CD0", VA = "0x1867244D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private SkinnedMeshRenderer KALNOMLNKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6723D80", Offset = "0x6722580", VA = "0x186723D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Renderer[] NCLPHCKGCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x67264B0", Offset = "0x6724CB0", VA = "0x1867264B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private GameObject[] DLHOLOIAOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6721950", Offset = "0x6720150", VA = "0x186721950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Animator DPBFLJOCCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6722E40", Offset = "0x6721640", VA = "0x186722E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private VRIK NJJIHEOPOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6721B30", Offset = "0x6720330", VA = "0x186721B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private HPACEKLCMOF CGPIDNDPPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x672B710", Offset = "0x6729F10", VA = "0x18672B710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private HPACEKLCMOF GIBOAMGFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6728280", Offset = "0x6726A80", VA = "0x186728280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private HPACEKLCMOF LEOJJEEFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x672B7F0", Offset = "0x6729FF0", VA = "0x18672B7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private HPACEKLCMOF INJBMOJBCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x671DE40", Offset = "0x671C640", VA = "0x18671DE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private HPACEKLCMOF DPHIDNAEDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67263B0", Offset = "0x6724BB0", VA = "0x1867263B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private HPACEKLCMOF LEPPMDBMNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x672AD80", Offset = "0x6729580", VA = "0x18672AD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private HPACEKLCMOF BOJPNDKIKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x672AB50", Offset = "0x6729350", VA = "0x18672AB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private HPACEKLCMOF HCCOJCNBFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67262D0", Offset = "0x6724AD0", VA = "0x1867262D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public NNPAMPJFNNC GJDAOEBCGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x672D110", Offset = "0x672B910", VA = "0x18672D110", Slot = "32")]
		get
		{
			return default(NNPAMPJFNNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public FAICNNGHKAN EBBNHAEHPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9CB120", Offset = "0x9C9920", VA = "0x1809CB120", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PNAOPNKBNGF KOHNOCHDNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8B2100", Offset = "0x8B0900", VA = "0x1808B2100", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GFOLMCEBPKC GCIJCPPLCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F10", Offset = "0x8B0710", VA = "0x1808B1F10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GFOLMCEBPKC AHEPFPCEDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAB7710", Offset = "0xAB5F10", VA = "0x180AB7710", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public GameObject DLBGNHFNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6728EF0", Offset = "0x67276F0", VA = "0x186728EF0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Transform NLLPGBBADGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x12BB8D0", Offset = "0x12BA0D0", VA = "0x1812BB8D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Transform MONNBGJDOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1381540", Offset = "0x137FD40", VA = "0x181381540", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Vector3 POBIBLIJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6721AF0", Offset = "0x67202F0", VA = "0x186721AF0", Slot = "29")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float JMPLEDNGEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6729CE0", Offset = "0x67284E0", VA = "0x186729CE0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform NHFFNCFFBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6726270", Offset = "0x6724A70", VA = "0x186726270", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool NPNGGCLHPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67296D0", Offset = "0x6727ED0", VA = "0x1867296D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool MPIFOMEABGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6729210", Offset = "0x6727A10", VA = "0x186729210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x672BB00", Offset = "0x672A300", VA = "0x18672BB00")]
	private void ONABILBFNOF([In] EIDPIMGLEDN MFALMFHNMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67218A0", Offset = "0x67200A0", VA = "0x1867218A0")]
	private void ECHNCOOBPJM(EIDPIMGLEDN MFALMFHNMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6721710", Offset = "0x671FF10", VA = "0x186721710")]
	private void DKPFNNLPMPA(HBJLEMDEMFE EODHLDGDFPE, GFOLMCEBPKC MEOPJOJJACD, IKSolverVR.Arm CAGMFEEICAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6728F90", Offset = "0x6727790", VA = "0x186728F90")]
	private void MGAPHBPEFKK([In] EIDPIMGLEDN DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x672EB00", Offset = "0x672D300", VA = "0x18672EB00")]
	public FJLHNGKBCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6729D10", Offset = "0x6728510", VA = "0x186729D10", Slot = "12")]
	public void NHMKDKLHCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x671F000", Offset = "0x671D800", VA = "0x18671F000", Slot = "13")]
	public void CMPCFDGHKBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6723190", Offset = "0x6721990", VA = "0x186723190", Slot = "14")]
	public void GEKFMJEPDJM(bool COBPBACJPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x672AC30", Offset = "0x6729430", VA = "0x18672AC30", Slot = "22")]
	public Transform NNHCPHAOCNA(string HPFJOEMPMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x67209E0", Offset = "0x671F1E0", VA = "0x1867209E0", Slot = "23")]
	public Vector3? DBIFFNBMABH(string HPFJOEMPMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6722370", Offset = "0x6720B70", VA = "0x186722370", Slot = "7")]
	public void FMMAPHKEADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6726D50", Offset = "0x6725550", VA = "0x186726D50", Slot = "6")]
	public void KFCDFMDHAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x671E280", Offset = "0x671CA80", VA = "0x18671E280", Slot = "8")]
	public void CBNCOLDEFND(float HHANHFPADCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x671DD40", Offset = "0x671C540", VA = "0x18671DD40")]
	private void AMPJEDNJION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x671F2E0", Offset = "0x671DAE0", VA = "0x18671F2E0", Slot = "4")]
	public void CNBNJPOANFJ(CFHNEDCHEKI GEEFJDMABKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6729290", Offset = "0x6727A90", VA = "0x186729290", Slot = "5")]
	public void MMHICNOHBAH(NNPAMPJFNNC EIPGPNFAEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x67230A0", Offset = "0x67218A0", VA = "0x1867230A0", Slot = "11")]
	public void GDJJFGJOKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6729940", Offset = "0x6728140", VA = "0x186729940", Slot = "21")]
	public void NBNHLKCNIKN([Out] Vector3 JNNHOAAAIGP, [Out] Quaternion CABDPFOEAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x67206E0", Offset = "0x671EEE0", VA = "0x1867206E0")]
	private void CNHNEHJMAKE([In] EIDPIMGLEDN DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x672B8D0", Offset = "0x672A0D0", VA = "0x18672B8D0", Slot = "24")]
	public void OLHFHDIBHNE(float OCPJMGGCICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x671DD90", Offset = "0x671C590", VA = "0x18671DD90", Slot = "25")]
	public HandLogicOffsets BGILOBGNCFN()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x672B240", Offset = "0x6729A40", VA = "0x18672B240", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets OCFMLFAMFII()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6721A30", Offset = "0x6720230", VA = "0x186721A30")]
	private void FBBGLHMJEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6727E80", Offset = "0x6726680", VA = "0x186727E80")]
	private void LCOJMBDFIBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6722F20", Offset = "0x6721720", VA = "0x186722F20")]
	private void GBCIFCDPAEL(DACPPDODOBJ MAFKIFGOFMO, bool NEAOAKEDNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6723480", Offset = "0x6721C80", VA = "0x186723480")]
	private void GJDMECEOKHE(DACPPDODOBJ MAFKIFGOFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6724480", Offset = "0x6722C80", VA = "0x186724480")]
	public Vector3 HEPFIKLCHBC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6728A50", Offset = "0x6727250", VA = "0x186728A50")]
	private void LIJIAGOGIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6723260", Offset = "0x6721A60", VA = "0x186723260")]
	private float GEMLFFLKODB([In] EIDPIMGLEDN DAGLKLOEBMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6728E10", Offset = "0x6727610", VA = "0x186728E10")]
	private int MAKPNJFIMCB([In] AIBILJPIKDN PFBJGIPENGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x671D7F0", Offset = "0x671BFF0", VA = "0x18671D7F0")]
	private void AFBJPLHFNDF(EIDPIMGLEDN MFALMFHNMGI, bool CAFMKPJMBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x672D240", Offset = "0x672BA40", VA = "0x18672D240")]
	private static void PAJMMLNKEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6724B30", Offset = "0x6723330", VA = "0x186724B30")]
	private static void IDDOGMGJPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6728360", Offset = "0x6726B60", VA = "0x186728360")]
	private float LGCGPGJAIGC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x671DF20", Offset = "0x671C720", VA = "0x18671DF20")]
	private static int BMJGGPDLEHM(FJLHNGKBCLN LDKECOBJCHJ, FJLHNGKBCLN JFMCJHKCOJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x672A120", Offset = "0x6728920", VA = "0x18672A120")]
	private void NIEJMCIEHED(EIDPIMGLEDN DAGLKLOEBMA, AvatarFullBodyConfiguration LNOEPHEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6722230", Offset = "0x6720A30", VA = "0x186722230")]
	private void FFNOJFDOABI([In] EIDPIMGLEDN DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67245B0", Offset = "0x6722DB0", VA = "0x1867245B0")]
	private void HOGEGIEDHPL([In] EIDPIMGLEDN DAGLKLOEBMA, [In] AvatarFullBodyConfiguration LNOEPHEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x672B950", Offset = "0x672A150", VA = "0x18672B950")]
	private void OLMEJAKGCFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67287E0", Offset = "0x6726FE0", VA = "0x1867287E0")]
	private void LIFLGANEFEC([In] EIDPIMGLEDN DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6720710", Offset = "0x671EF10", VA = "0x186720710")]
	public void CODAKKFMBIG(RigidbodyEx EKNFMBHEJLG, IKSolverVR.Arm CAGMFEEICAF, Quaternion MOJCBNCICPL, Vector3 JIBAKJLOGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6723400", Offset = "0x6721C00", VA = "0x186723400")]
	private float GICKNBHJOLP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6721C10", Offset = "0x6720410", VA = "0x186721C10")]
	private void FEJGOIEJNPA([In] EIDPIMGLEDN DAGLKLOEBMA, [In] APOFHCPADCA NFIDCLLJLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6728AC0", Offset = "0x67272C0", VA = "0x186728AC0")]
	private void LNELCMDDDPP(EIDPIMGLEDN DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6726490", Offset = "0x6724C90", VA = "0x186726490")]
	private void JFIAJDBLFHP(BADJGIKAMGN IEGJAEIJLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6729730", Offset = "0x6727F30", VA = "0x186729730")]
	private void MOFNKFHODFB(float HBNPOEHMMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6720B70", Offset = "0x671F370", VA = "0x186720B70")]
	private void DIDLPIDMCGO([In] EIDPIMGLEDN DAGLKLOEBMA, APOFHCPADCA NFIDCLLJLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x671E380", Offset = "0x671CB80", VA = "0x18671E380")]
	private Vector3 CMBPEBALKKK([In] EIDPIMGLEDN DAGLKLOEBMA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x672AE60", Offset = "0x6729660", VA = "0x18672AE60")]
	private float OAJFNDEJDAB(float EFBLFMFIEAM, [In] EIDPIMGLEDN DAGLKLOEBMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x671DD20", Offset = "0x671C520", VA = "0x18671DD20")]
	private void AJDHAGHNOOH(BADJGIKAMGN IEGJAEIJLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x672CFC0", Offset = "0x672B7C0", VA = "0x18672CFC0")]
	private void ONCJLMHJPDO(float EFBLFMFIEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x671EA60", Offset = "0x671D260", VA = "0x18671EA60")]
	private void CMOFAELFMHH([In] EIDPIMGLEDN DAGLKLOEBMA, APOFHCPADCA NFIDCLLJLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x672B300", Offset = "0x6729B00", VA = "0x18672B300")]
	private float OEEEDBFKLKN([In] EIDPIMGLEDN MFALMFHNMGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6723F60", Offset = "0x6722760", VA = "0x186723F60")]
	private void HDKGGBCLHID(EIDPIMGLEDN DAGLKLOEBMA, APOFHCPADCA NFIDCLLJLDF, Vector3 EKBJGPOBLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x671D640", Offset = "0x671BE40", VA = "0x18671D640")]
	private static void ADLINONBBOP(Transform MCHMJHAODPL, Quaternion LOMIHBHMPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x67284B0", Offset = "0x6726CB0", VA = "0x1867284B0")]
	private void LHOOPDKLPBA([In] EIDPIMGLEDN NDOLEHPDFME, [In] AIBILJPIKDN PFBJGIPENGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x672D450", Offset = "0x672BC50", VA = "0x18672D450")]
	private void PCFPJHNKCMM([In] EIDPIMGLEDN NDOLEHPDFME, [In] AIBILJPIKDN PFBJGIPENGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x672DB50", Offset = "0x672C350", VA = "0x18672DB50")]
	private void PDNJHKOBLGM([In] EIDPIMGLEDN DAGLKLOEBMA, [In] AvatarFullBodyConfiguration LNOEPHEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x67269D0", Offset = "0x67251D0", VA = "0x1867269D0")]
	public void JPNFJMNIKGN([In] EIDPIMGLEDN DAGLKLOEBMA, [In] AvatarFullBodyConfiguration LNOEPHEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x67278E0", Offset = "0x67260E0", VA = "0x1867278E0", Slot = "33")]
	protected virtual void KMEAPOCIMKN([In] EIDPIMGLEDN DAGLKLOEBMA, [In] AvatarFullBodyConfiguration LNOEPHEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x671DF50", Offset = "0x671C750", VA = "0x18671DF50")]
	private void BMMOCAKILCO([In] EIDPIMGLEDN DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x67212B0", Offset = "0x671FAB0", VA = "0x1867212B0")]
	private void DJGFJDNEICI(float PCDEPGBJDDB, [In] EIDPIMGLEDN MFALMFHNMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6723610", Offset = "0x6721E10", VA = "0x186723610")]
	private float GKPIMLMHOCK([In] EIDPIMGLEDN MFALMFHNMGI, [In] AvatarFullBodyConfiguration LNOEPHEPJGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6722AA0", Offset = "0x67212A0", VA = "0x186722AA0")]
	private void GAAPFDLNOKH([In] EIDPIMGLEDN MFALMFHNMGI, [In] AvatarFullBodyConfiguration LNOEPHEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6725EB0", Offset = "0x67246B0", VA = "0x186725EB0")]
	private void IGDGJOENOHA([In] EIDPIMGLEDN MFALMFHNMGI, float GHKMAIKAANB, float EBKGMMJEOHP, Vector3 OEJCPEOMBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x67256C0", Offset = "0x6723EC0", VA = "0x1867256C0")]
	private void IDLMBCGNGJE(EIDPIMGLEDN MFALMFHNMGI, AvatarFullBodyConfiguration LNOEPHEPJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6723E60", Offset = "0x6722660", VA = "0x186723E60")]
	[CompilerGenerated]
	internal static bool GPLKFLPHOFK(IKSolverVR.Arm CAGMFEEICAF, PJGPEPMDBPF LGBKKAHEEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6726590", Offset = "0x6724D90", VA = "0x186726590")]
	[CompilerGenerated]
	internal static float JJKJALHJAPF(Vector3 KLFBJJOIAKN, Vector3 KLCNDNKBLIM, Vector3 FGJGCLHGCLL, EIDPIMGLEDN MFALMFHNMGI, AvatarFullBodyConfiguration LNOEPHEPJGF, float MFLLOPOPNNG)
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
		public enum ICCPPBDFDEJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private ICCPPBDFDEJ handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x671C460", Offset = "0x671AC60", VA = "0x18671C460")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x671C420", Offset = "0x671AC20", VA = "0x18671C420")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x671BE20", Offset = "0x671A620", VA = "0x18671BE20")]
		private void LLGHLEHEJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x66EADD0", Offset = "0x66E95D0", VA = "0x1866EADD0", Slot = "4")]
		public void SetEnabled(bool JKFJGFGHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x671C490", Offset = "0x671AC90", VA = "0x18671C490")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, HPACEKLCMOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Vector3 DAJOMFMHMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3 DNPJIHPFGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Vector3 DEKGPPEOHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Matrix4x4 KLIJOEHNAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private bool ENICKGKNCEL;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x671C920", Offset = "0x671B120", VA = "0x18671C920", Slot = "4")]
		public void UpdateController(float PNBNBIDOECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6641EA0", Offset = "0x66406A0", VA = "0x186641EA0", Slot = "6")]
		public void SetEnabled(bool IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x671C4C0", Offset = "0x671ACC0", VA = "0x18671C4C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x671CFE0", Offset = "0x671B7E0", VA = "0x18671CFE0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
internal class KDDDGDCBCBJ : NINHCBMGBMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Dictionary<string, GDBHNPFGFMA> LFLPOAIKFOD;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool DHGJJMBNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6731230", Offset = "0x672FA30", VA = "0x186731230")]
	[ANLGLDAOJJE(KKPEBAHBECP.Root, ELBANFBEGNE.None)]
	private static void NCPGOILFDFB(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6731070", Offset = "0x672F870", VA = "0x186731070", Slot = "4")]
	public GDBHNPFGFMA JOEDDLPJHDM(string NKHLJKJEKPC, AvatarSystemConfiguration AILGHLBLAFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6730EF0", Offset = "0x672F6F0", VA = "0x186730EF0", Slot = "5")]
	public void IKAOKIPIHJN(string NKHLJKJEKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x67312A0", Offset = "0x672FAA0", VA = "0x1867312A0")]
	public KDDDGDCBCBJ()
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
		public class POKJMLOMLCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private Dictionary<string, Transform> KDJLDIDOINI;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public bool HACFJPDLFNP
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x6736720", Offset = "0x6734F20", VA = "0x186736720")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x67365F0", Offset = "0x6734DF0", VA = "0x1867365F0")]
			public void ILDLGKCOCOA(VRIK PGGCGJAMBPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
			public void MKMKCMKCGAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6736760", Offset = "0x6734F60", VA = "0x186736760")]
			public void NJEEDNGOJJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x67367B0", Offset = "0x6734FB0", VA = "0x1867367B0")]
			public POKJMLOMLCN()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly POKJMLOMLCN JMBGGIMNAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private GPJPKABEJAA HOOCAKCFEHB;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x671D040", Offset = "0x671B840", VA = "0x18671D040")]
		private void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x671CFF0", Offset = "0x671B7F0", VA = "0x18671CFF0")]
		private bool CFLFDNCAOPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x671D300", Offset = "0x671BB00", VA = "0x18671D300")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x671D370", Offset = "0x671BB70", VA = "0x18671D370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x671D310", Offset = "0x671BB10", VA = "0x18671D310")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x671D560", Offset = "0x671BD60", VA = "0x18671D560")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6733140", Offset = "0x6731940", VA = "0x186733140", Slot = "4")]
		public override void OnStateEnter(Animator OJALOBLLGDN, AnimatorStateInfo EFLNKNMOKNN, int DAIEAJJHLMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6733260", Offset = "0x6731A60", VA = "0x186733260")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal abstract class ENJILONOCFL<TInput, TOutput> : LHCHKHEBAOH<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected readonly KOLINNPELBE AHILIMBPIGP;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x376CEF0", Offset = "0x376B6F0", VA = "0x18376CEF0")]
	protected ENJILONOCFL(KOLINNPELBE AHILIMBPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput PKPMANIAHDL(TInput FDJIPPJKNDH, [Out] IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x376CE50", Offset = "0x376B650", VA = "0x18376CE50", Slot = "5")]
	public bool DGKAILEPCIM(TInput FDJIPPJKNDH, [Out] TOutput? KKBKNCNBBJP, [Out] IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BFNFAOFCCLN]
public static class HPGOCPDOODG
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly Regex AEDEAFDOAIF;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6730A60", Offset = "0x672F260", VA = "0x186730A60")]
	public static HADOENGGMPL EIGJENMLHAJ(HAPGBAHNIJN NMJFGLOIAMF, NPEBPDPBEAI OIEEIDGCAJM, Guid? HKLDIPLNKCF, Color? FNIDCFFEKGC, COKDDOEMBCP MFKCOFBNOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6730C70", Offset = "0x672F470", VA = "0x186730C70")]
	public static JEMEAOBLCBJ HODPFJECOIB(HADOENGGMPL MLKNGAFFKGE)
	{
		return default(JEMEAOBLCBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2650", Offset = "0x2AB0E50", VA = "0x182AB2650")]
	internal static TModern? ENILMBDKOOL<TModern>(string? FDJIPPJKNDH, BEDDFMDHJNJ<TModern> HHGEFOGEDGE, KOLINNPELBE AHILIMBPIGP, NEHLLCGBDJL JBMIPKJJCOG, TModern KAFOOHKONAE) where TModern : struct, AHEOGJEMBED
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1E40", Offset = "0x2AB0640", VA = "0x182AB1E40")]
	internal static ELMADGALMDO ABGNKFEJJCA<TModern>(string? FDJIPPJKNDH, BEDDFMDHJNJ<TModern> HHGEFOGEDGE, KOLINNPELBE AHILIMBPIGP, NEHLLCGBDJL JBMIPKJJCOG, TModern KAFOOHKONAE) where TModern : struct, AHEOGJEMBED
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6730D20", Offset = "0x672F520", VA = "0x186730D20")]
	internal static List<BKGGCPNPCAA> KNOGLIAJJFP(IEnumerable<EGFDJPJKCPD>? OAMBIOLEECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3CA0", Offset = "0x2AB24A0", VA = "0x182AB3CA0")]
	internal static string LOFDMOAEIHI<TModern>(TModern FDJIPPJKNDH, BEDDFMDHJNJ<TModern> HHGEFOGEDGE, KOLINNPELBE AHILIMBPIGP) where TModern : AHEOGJEMBED
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class MEPEMEOAMMN : BODLEHFMNJM
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LHCHKHEBAOH<AHDOLPLLHFG, BGEKPNHNABN> CJHCEHFJILC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LHCHKHEBAOH<PIJELOHKNKB, DHFKGLJPJBM> IEKHFMNGDHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LHCHKHEBAOH<PIJELOHKNKB, DHFKGLJPJBM> LIKFHJBKFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HANKDDECLAF KCOBLEGAANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EKDENJHABPK FFDOKANEBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6731400", Offset = "0x672FC00", VA = "0x186731400")]
	[UsedImplicitly]
	[ANLGLDAOJJE(KKPEBAHBECP.Root, ELBANFBEGNE.GameOnly)]
	private static void MLMGKKCDOHM(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6731470", Offset = "0x672FC70", VA = "0x186731470")]
	[Preserve]
	internal MEPEMEOAMMN([GNKLNMHODGG("UnitySerialization")] CEBAHIJLEOI FDCJECOGHAJ, [GNKLNMHODGG(null)] IGKLCLDEJHC FBEKIDEFFOG, [GNKLNMHODGG(null)] KOLINNPELBE AHILIMBPIGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum KDEJGFLAMFD
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LNANAKLDPCM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x67313D0", Offset = "0x672FBD0", VA = "0x1867313D0")]
	public LNANAKLDPCM(string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6731330", Offset = "0x672FB30", VA = "0x186731330")]
	public LNANAKLDPCM(string CLBGCJICGJG, Exception JFLEAGGNHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6731360", Offset = "0x672FB60", VA = "0x186731360")]
	public LNANAKLDPCM(KDEJGFLAMFD OHCBIMJNIPL, string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6731390", Offset = "0x672FB90", VA = "0x186731390")]
	public LNANAKLDPCM(KDEJGFLAMFD OHCBIMJNIPL, string CLBGCJICGJG, Exception JFLEAGGNHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class MGCGNGENHCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly CEBAHIJLEOI FDCJECOGHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly IGKLCLDEJHC FBEKIDEFFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly KOLINNPELBE AHILIMBPIGP;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6732FC0", Offset = "0x67317C0", VA = "0x186732FC0")]
	protected MGCGNGENHCM(CEBAHIJLEOI FDCJECOGHAJ, IGKLCLDEJHC FBEKIDEFFOG, KOLINNPELBE AHILIMBPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6731CE0", Offset = "0x67304E0", VA = "0x186731CE0")]
	protected string IHBLPANCEFC(BGEKPNHNABN LGJMDPAEIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6731AF0", Offset = "0x67302F0", VA = "0x186731AF0")]
	protected string GINNOJAKDNO(BGEKPNHNABN LGJMDPAEIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6731780", Offset = "0x672FF80", VA = "0x186731780")]
	private AvatarOutfitSelectionData EIGJENMLHAJ(HADOENGGMPL NEKMBNFDCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6731640", Offset = "0x672FE40", VA = "0x186731640")]
	private static AvatarCustomizationSettingsData.AnchorParams BONBHPJEGCN(NCNMBJAGJBN? JCKKABBMOIP)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LHCHKHEBAOH<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput PKPMANIAHDL(TInput FDJIPPJKNDH, [Out] IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DGKAILEPCIM(TInput FDJIPPJKNDH, [Out] TOutput? KKBKNCNBBJP, [Out] IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BODLEHFMNJM
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LHCHKHEBAOH<AHDOLPLLHFG, BGEKPNHNABN> CJHCEHFJILC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LHCHKHEBAOH<PIJELOHKNKB, DHFKGLJPJBM> LIKFHJBKFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HANKDDECLAF KCOBLEGAANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal enum NEHLLCGBDJL
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface EKDENJHABPK
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCALOOIGBAJ HNAIEAEAFJH(BGEKPNHNABN MLKNGAFFKGE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HANKDDECLAF
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIJELOHKNKB HNAIEAEAFJH(BGEKPNHNABN MLKNGAFFKGE, int MPGHECCBKFA, string? GCDLMFGKKMH, string? NHKBHFHBLIH, ODGMKINPFBN FNGANFOBOIH, List<BKGGCPNPCAA>? HAPHEALFDML);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BFNFAOFCCLN]
internal class JCNJNEAHMLN : ENJILONOCFL<AHDOLPLLHFG, BGEKPNHNABN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly IGKLCLDEJHC FBEKIDEFFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly AEFGKAMGDFF BGDLHDBAKBM;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x673B550", Offset = "0x6739D50", VA = "0x18673B550")]
	public JCNJNEAHMLN(CEBAHIJLEOI FDCJECOGHAJ, IGKLCLDEJHC FBEKIDEFFOG, KOLINNPELBE AHILIMBPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x673B2B0", Offset = "0x6739AB0", VA = "0x18673B2B0", Slot = "6")]
	public override BGEKPNHNABN PKPMANIAHDL(AHDOLPLLHFG FDJIPPJKNDH, [Out] IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Preserve]
internal class EALAOAKIEEC : CEBAHIJLEOI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class CAOCEJIFLKD : JsonConverter<ELMADGALMDO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x673A290", Offset = "0x6738A90", VA = "0x18673A290", Slot = "9")]
		public override void WriteJson(JsonWriter COHNONCDMOG, ELMADGALMDO? IPHHABIKCHD, JsonSerializer CHIFHGDIIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x673A170", Offset = "0x6738970", VA = "0x18673A170", Slot = "10")]
		public override ELMADGALMDO ReadJson(JsonReader PJOJHFLPHKO, Type LEPOFEJEGDF, ELMADGALMDO? NCFNNNEIEAI, bool OIHGHOILDGD, JsonSerializer CHIFHGDIIOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x673A330", Offset = "0x6738B30", VA = "0x18673A330")]
		public CAOCEJIFLKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class ECBDFHCDHLN : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool MNHPGDMDKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x673A8B0", Offset = "0x67390B0", VA = "0x18673A8B0", Slot = "5")]
		public override object ReadJson(JsonReader PJOJHFLPHKO, Type LEPOFEJEGDF, object? NCFNNNEIEAI, JsonSerializer CHIFHGDIIOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x673A4D0", Offset = "0x6738CD0", VA = "0x18673A4D0", Slot = "6")]
		public override bool CanConvert(Type LEPOFEJEGDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x673A910", Offset = "0x6739110", VA = "0x18673A910", Slot = "4")]
		public override void WriteJson(JsonWriter COHNONCDMOG, object? IPHHABIKCHD, JsonSerializer CHIFHGDIIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x673A6B0", Offset = "0x6738EB0", VA = "0x18673A6B0")]
		private static bool KABBHIKFCHJ(object IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public ECBDFHCDHLN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly JsonSerializerSettings PIKLGNEOCJC;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x673A370", Offset = "0x6738B70", VA = "0x18673A370")]
	internal EALAOAKIEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x29128A0", Offset = "0x29110A0", VA = "0x1829128A0", Slot = "4")]
	public string MBMKLJBFLLB<T>(T GHDJADLHPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2912810", Offset = "0x2911010", VA = "0x182912810", Slot = "5")]
	public T HOBNJAIGBJM<T>(string IPHHABIKCHD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class OBDJBFNCFCB : CEBAHIJLEOI
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2C02BB0", Offset = "0x2C013B0", VA = "0x182C02BB0", Slot = "4")]
	public string MBMKLJBFLLB<T>(T GHDJADLHPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2C02B30", Offset = "0x2C01330", VA = "0x182C02B30", Slot = "5")]
	public T HOBNJAIGBJM<T>(string IPHHABIKCHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public OBDJBFNCFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BFNFAOFCCLN]
internal class AEFGKAMGDFF : ENJILONOCFL<PIJELOHKNKB, DHFKGLJPJBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly CEBAHIJLEOI FDCJECOGHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly IGKLCLDEJHC FBEKIDEFFOG;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6738ED0", Offset = "0x67376D0", VA = "0x186738ED0")]
	public AEFGKAMGDFF(CEBAHIJLEOI FDCJECOGHAJ, IGKLCLDEJHC FBEKIDEFFOG, KOLINNPELBE AHILIMBPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6738AB0", Offset = "0x67372B0", VA = "0x186738AB0", Slot = "6")]
	public override DHFKGLJPJBM PKPMANIAHDL(PIJELOHKNKB FDJIPPJKNDH, [Out] IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6737E00", Offset = "0x6736600", VA = "0x186737E00")]
	internal void MJNAFOAHCJK(string LHGKJLJHPAN, BGEKPNHNABN LGJMDPAEIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6736A40", Offset = "0x6735240", VA = "0x186736A40")]
	public IEnumerable<HADOENGGMPL> ACEKDIHAGNI(string BOAJKHNJFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6738690", Offset = "0x6736E90", VA = "0x186738690")]
	private IEnumerable<HADOENGGMPL> NMBNGGJGCFH(string BOAJKHNJFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67376D0", Offset = "0x6735ED0", VA = "0x1867376D0")]
	internal IEnumerable<HADOENGGMPL> FHFEBOMAAJP(string BOAJKHNJFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x67382C0", Offset = "0x6736AC0", VA = "0x1867382C0")]
	private HADOENGGMPL NFGEAPNFHIJ(AvatarOutfitSelectionData GCIIBBHKADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6736AF0", Offset = "0x67352F0", VA = "0x186736AF0")]
	private void DMGPGLNNPNF(AvatarCustomizationSettingsData JDIGMAENOHB, BGEKPNHNABN LGJMDPAEIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6737F60", Offset = "0x6736760", VA = "0x186737F60")]
	private HADOENGGMPL NFGEAPNFHIJ(string JEJILLIOALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6737B20", Offset = "0x6736320", VA = "0x186737B20")]
	internal static (COKDDOEMBCP, string, string) IBAFNNBPFFB(string JEJILLIOALM, KOLINNPELBE AHILIMBPIGP)
	{
		return default((COKDDOEMBCP, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x67374D0", Offset = "0x6735CD0", VA = "0x1867374D0")]
	private NCAGCDFGCMA? FDONKONIJBD(string? PGOHCHKMLGH, Vector2 AMLFGBAFEIN, float NPAKCGCAODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6737370", Offset = "0x6735B70", VA = "0x186737370")]
	private static NCNMBJAGJBN FBLOPBOCKFO(AvatarCustomizationSettingsData.AnchorParams HPABICLGLPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BFNFAOFCCLN]
internal class AOILPIPPMBM : MGCGNGENHCM, EKDENJHABPK
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6739780", Offset = "0x6737F80", VA = "0x186739780")]
	public AOILPIPPMBM(CEBAHIJLEOI FDCJECOGHAJ, IGKLCLDEJHC FBEKIDEFFOG, KOLINNPELBE AHILIMBPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6739010", Offset = "0x6737810", VA = "0x186739010", Slot = "4")]
	public OCALOOIGBAJ HNAIEAEAFJH(BGEKPNHNABN MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6739680", Offset = "0x6737E80", VA = "0x186739680")]
	private string OJFOCFMJKDJ(BGEKPNHNABN LGJMDPAEIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x67393C0", Offset = "0x6737BC0", VA = "0x1867393C0")]
	private string LMGELGEAOPM(HADOENGGMPL NEKMBNFDCEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BFNFAOFCCLN]
internal class LOAALLFEGHJ : ENJILONOCFL<PIJELOHKNKB, DHFKGLJPJBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly CEBAHIJLEOI FDCJECOGHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly LHCHKHEBAOH<PIJELOHKNKB, DHFKGLJPJBM> KHDGFGGANKN;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x673D7E0", Offset = "0x673BFE0", VA = "0x18673D7E0")]
	public LOAALLFEGHJ(LHCHKHEBAOH<PIJELOHKNKB, DHFKGLJPJBM> KHDGFGGANKN, KOLINNPELBE AHILIMBPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x673D3B0", Offset = "0x673BBB0", VA = "0x18673D3B0", Slot = "6")]
	public override DHFKGLJPJBM PKPMANIAHDL(PIJELOHKNKB FDJIPPJKNDH, [Out] IReadOnlyList<BKGGCPNPCAA>? HAPHEALFDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BFNFAOFCCLN]
internal class HPFAEDMKBMH : HANKDDECLAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly CEBAHIJLEOI FDCJECOGHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly EKDENJHABPK JPGEEFNGMEE;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x673B1C0", Offset = "0x67399C0", VA = "0x18673B1C0")]
	public HPFAEDMKBMH(EKDENJHABPK JPGEEFNGMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x673AE20", Offset = "0x6739620", VA = "0x18673AE20", Slot = "4")]
	public PIJELOHKNKB HNAIEAEAFJH(BGEKPNHNABN MLKNGAFFKGE, int MPGHECCBKFA, string? GCDLMFGKKMH, string? NHKBHFHBLIH, ODGMKINPFBN FNGANFOBOIH, List<BKGGCPNPCAA>? HAPHEALFDML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Preserve]
internal class JEDDKGOANBC : OBBNHONMJAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private static readonly Vector2 LGKODGHHJBD;

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly Vector2 CGMFEILEEKE;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly Vector2 DFBALMLOMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static readonly Vector2 KNJKLAOOEHE;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly Vector2 IHFKHEAIAPO;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly Vector2 GCPHFDFIBBH;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly Vector2 IGIGHCKBKDA;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly Vector2 LHKCEANMMPM;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly Vector2 IEKCPEFODFD;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly Vector2 NMBCHIAKBJB;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static readonly Vector2 NJLCLCGPNAA;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static readonly Vector2 HBHDGLIJMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private Dictionary<JNBBILMHJPI, AvatarConfiguration> HDBEEPKENAK;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x673CF30", Offset = "0x673B730", VA = "0x18673CF30")]
	[ANLGLDAOJJE(KKPEBAHBECP.Root, ELBANFBEGNE.None)]
	private static void PCMMPHHGAAG(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x673D300", Offset = "0x673BB00", VA = "0x18673D300")]
	[Preserve]
	internal JEDDKGOANBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x673C9B0", Offset = "0x673B1B0", VA = "0x18673C9B0", Slot = "4")]
	public Vector2 MJBHHPAIOBP(FaceFeatureType KHIDKLAJDFE, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x673D030", Offset = "0x673B830", VA = "0x18673D030", Slot = "5")]
	public float PDNAMBPHBEA(FaceFeatureType KHIDKLAJDFE, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x673BF60", Offset = "0x673A760", VA = "0x18673BF60", Slot = "6")]
	public void DPPPEIEGJIH(JNBBILMHJPI ECGCEDDHANK, AvatarConfiguration AILGHLBLAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x673C450", Offset = "0x673AC50", VA = "0x18673C450", Slot = "7")]
	public float FIFAJLNLNJF(FaceFeatureType MMFDDGOJNCB, float LCNEFMHPBJL, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x673D0F0", Offset = "0x673B8F0", VA = "0x18673D0F0", Slot = "8")]
	public float PMBGOIDNBKI(FaceFeatureType MMFDDGOJNCB, float NPAKCGCAODL, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x673CD80", Offset = "0x673B580", VA = "0x18673CD80", Slot = "10")]
	public Vector2 OIANMECIKNG(FaceFeatureType MMFDDGOJNCB, Vector2 EPKOGBHGJEF, Vector2 DCLLGJMFNJO, Vector2 DCAJMJHCGHA, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x673BBE0", Offset = "0x673A3E0", VA = "0x18673BBE0", Slot = "9")]
	public Vector2 DDNIJLJGKLM(FaceFeatureType MMFDDGOJNCB, Vector2 BOOOMFONEAG, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x673B940", Offset = "0x673A140", VA = "0x18673B940")]
	private Vector2 BJEOKHNOBBF(FaceFeatureType MMFDDGOJNCB, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x673B720", Offset = "0x6739F20", VA = "0x18673B720")]
	private Vector2 AGLKBFAOMJB(FaceFeatureType MMFDDGOJNCB, Vector2 EPKOGBHGJEF, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x673C0C0", Offset = "0x673A8C0", VA = "0x18673C0C0", Slot = "11")]
	public Vector2 FHILAPEEFHI(FaceFeatureType MMFDDGOJNCB, Vector2 BOOOMFONEAG, Vector2 DCLLGJMFNJO, Vector2 DCAJMJHCGHA, JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x673BAD0", Offset = "0x673A2D0", VA = "0x18673BAD0")]
	private float CFNNOFKAEAL(float PHJDDFAGKAI, float AMCDFFFIAPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x673C6D0", Offset = "0x673AED0", VA = "0x18673C6D0")]
	private Vector2 HPHLHMEKJCH(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x673BE10", Offset = "0x673A610", VA = "0x18673BE10")]
	private Vector2 DHMFIKLGGHF(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x673C750", Offset = "0x673AF50", VA = "0x18673C750")]
	private Vector2 IMLIKNDFKLO(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x673BB60", Offset = "0x673A360", VA = "0x18673BB60")]
	private Vector2 DBKELKILKFJ(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x673D0B0", Offset = "0x673B8B0", VA = "0x18673D0B0")]
	private float PLGMJEDMLEK(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x673C080", Offset = "0x673A880", VA = "0x18673C080")]
	private float ECIDHBIAIEE(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x673B9E0", Offset = "0x673A1E0", VA = "0x18673B9E0")]
	private float BMCGAIMLCCG(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x673C970", Offset = "0x673B170", VA = "0x18673C970")]
	private float KMBPKIJGPHP(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x673CB10", Offset = "0x673B310", VA = "0x18673CB10")]
	private Vector2 MPBLPPIBPMD(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x673B870", Offset = "0x673A070", VA = "0x18673B870")]
	private Vector2 AJLJLPEDPIC(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x673C8A0", Offset = "0x673B0A0", VA = "0x18673C8A0")]
	private Vector2 KCHOGLMGFAE(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x673C600", Offset = "0x673AE00", VA = "0x18673C600")]
	private Vector2 HEPCPCKDFKH(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x673C480", Offset = "0x673AC80", VA = "0x18673C480")]
	private Vector2 FOJDDMPNKKC(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x673BE90", Offset = "0x673A690", VA = "0x18673BE90")]
	private Vector2 DLOBNFDNFIH(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x673CCB0", Offset = "0x673B4B0", VA = "0x18673CCB0")]
	private Vector2 OEHMNHPKGJJ(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x673CBE0", Offset = "0x673B3E0", VA = "0x18673CBE0")]
	private Vector2 NHCAIFNGAOJ(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x673C7D0", Offset = "0x673AFD0", VA = "0x18673C7D0")]
	private Vector2 JOPOAGKICBO(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x673BFD0", Offset = "0x673A7D0", VA = "0x18673BFD0")]
	private Vector2 EAPEFHJCNFG(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x673BA20", Offset = "0x673A220", VA = "0x18673BA20")]
	private Vector2 CENMILECJGC(JNBBILMHJPI ECGCEDDHANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x673C550", Offset = "0x673AD50", VA = "0x18673C550")]
	private Vector2 GMACLCPDKPB(JNBBILMHJPI ECGCEDDHANK)
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
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6739840", Offset = "0x6738040", VA = "0x186739840")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class FHBCMJIIJGG
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x673ABA0", Offset = "0x67393A0", VA = "0x18673ABA0")]
	public static JEMEAOBLCBJ PKPMANIAHDL(this MPJHMIGOHDG MLKNGAFFKGE)
	{
		return default(JEMEAOBLCBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x673A9F0", Offset = "0x67391F0", VA = "0x18673A9F0")]
	public static MPJHMIGOHDG HNAIEAEAFJH(this JEMEAOBLCBJ GBIILIKFLHI)
	{
		return null;
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
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x4B79210", Offset = "0x4B77A10", VA = "0x184B79210")]
			public AnchorParams(Vector2 EPKOGBHGJEF, Vector3 COJLFJBMLEC, Vector3 KECHFLJHCAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x6739790", Offset = "0x6737F90", VA = "0x186739790")]
			internal NCNMBJAGJBN HNAIEAEAFJH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private ICJBHBEAGEB useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x673A020", Offset = "0x6738820", VA = "0x18673A020")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x844F20", Offset = "0x843720", VA = "0x180844F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3F8E430", Offset = "0x3F8CC30", VA = "0x183F8E430")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x10266D0", Offset = "0x1024ED0", VA = "0x1810266D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8B1930", Offset = "0x8B0130", VA = "0x1808B1930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x980290", Offset = "0x97EA90", VA = "0x180980290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x673A0C0", Offset = "0x67388C0", VA = "0x18673A0C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x84B740", Offset = "0x849F40", VA = "0x18084B740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8B18E0", Offset = "0x8B00E0", VA = "0x1808B18E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x102D140", Offset = "0x102B940", VA = "0x18102D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8472D0", Offset = "0x845AD0", VA = "0x1808472D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x673A100", Offset = "0x6738900", VA = "0x18673A100")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1C2D880", Offset = "0x1C2C080", VA = "0x181C2D880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8B1FD0", Offset = "0x8B07D0", VA = "0x1808B1FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xE47C90", Offset = "0xE46490", VA = "0x180E47C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x843FE0", Offset = "0x8427E0", VA = "0x180843FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x843FB0", Offset = "0x8427B0", VA = "0x180843FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x402D700", Offset = "0x402BF00", VA = "0x18402D700")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1C5AB70", Offset = "0x1C59370", VA = "0x181C5AB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x879CE0", Offset = "0x8784E0", VA = "0x180879CE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x879D40", Offset = "0x878540", VA = "0x180879D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8513B0", Offset = "0x84FBB0", VA = "0x1808513B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x851370", Offset = "0x84FB70", VA = "0x180851370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x851300", Offset = "0x84FB00", VA = "0x180851300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x851360", Offset = "0x84FB60", VA = "0x180851360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8512E0", Offset = "0x84FAE0", VA = "0x1808512E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x851380", Offset = "0x84FB80", VA = "0x180851380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA2E350", Offset = "0xA2CB50", VA = "0x180A2E350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAA1A60", Offset = "0xAA0260", VA = "0x180AA1A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8513F0", Offset = "0x84FBF0", VA = "0x1808513F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x851340", Offset = "0x84FB40", VA = "0x180851340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x991990", Offset = "0x990190", VA = "0x180991990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x991AB0", Offset = "0x9902B0", VA = "0x180991AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x849990", Offset = "0x848190", VA = "0x180849990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x849900", Offset = "0x848100", VA = "0x180849900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB2CC50", Offset = "0xB2B450", VA = "0x180B2CC50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB34BC0", Offset = "0xB333C0", VA = "0x180B34BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9DD720", Offset = "0x9DBF20", VA = "0x1809DD720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xCDCD00", Offset = "0xCDB500", VA = "0x180CDCD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ICJBHBEAGEB UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1CF6490", Offset = "0x1CF4C90", VA = "0x181CF6490")]
			get
			{
				return default(ICJBHBEAGEB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x1CF4A50", Offset = "0x1CF3250", VA = "0x181CF4A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA480D0", Offset = "0xA468D0", VA = "0x180A480D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA47E50", Offset = "0xA46650", VA = "0x180A47E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x673A0E0", Offset = "0x67388E0", VA = "0x18673A0E0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x673A120", Offset = "0x6738920", VA = "0x18673A120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6739CC0", Offset = "0x67384C0", VA = "0x186739CC0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public COKDDOEMBCP BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private AMCKELCMONE? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x673A140", Offset = "0x6738940", VA = "0x18673A140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
