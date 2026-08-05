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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9EA0", Offset = "0x7FA8AA0", VA = "0x187FA9EA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9F20", Offset = "0x7FA8B20", VA = "0x187FA9F20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GOLNKMGDHKC]
internal class HEOMPDPMPCD : JJFKJLJNHKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KAGBOIKLEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public HEOMPDPMPCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public ADAOAPJGFHC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JIGJFNNEMPG IBPGBGCMENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CHCDLCMFGOO MCMLCMNONKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IPADCJFEADJ HMFDDNHKFLB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FA61A0", Offset = "0x7FA4DA0", VA = "0x187FA61A0")]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	[UsedImplicitly]
	internal static void GNDDLPOIOFL(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7B10", Offset = "0x7FA6710", VA = "0x187FA7B10")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HEOMPDPMPCD([HAKCNCGPHPD(null)] JIGJFNNEMPG IBPGBGCMENJ, [HAKCNCGPHPD(null)] CHCDLCMFGOO MCMLCMNONKN, [HAKCNCGPHPD(null)] IPADCJFEADJ HMFDDNHKFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6210", Offset = "0x7FA4E10", VA = "0x187FA6210", Slot = "5")]
	public DNHFACAJPBE GNFBDMNGIEG(ADAOAPJGFHC ODLFGIBLFNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7010", Offset = "0x7FA5C10", VA = "0x187FA7010", Slot = "4")]
	public DNHFACAJPBE PEHMGLHCGHH(ADAOAPJGFHC ODLFGIBLFNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6F00", Offset = "0x7FA5B00", VA = "0x187FA6F00", Slot = "6")]
	public ANJEECOKPKB NAHJBIBPLJM(DNHFACAJPBE CBCNBAPLLJM, int BLCEDCKLLLI, string? BKILENEPEEB, string? LDBFFGHOJNM, MMGGFMEPBPM HEMBOCGAKIC, List<IFMLEFJNJNE>? ONFOJPOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6030", Offset = "0x7FA4C30", VA = "0x187FA6030", Slot = "7")]
	public bool AEKJHPLBEGJ(OBEDBJJCGJB ODKMBOGKFAP, [Out] DNHFACAJPBE? LBEKEMPAKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA60C0", Offset = "0x7FA4CC0", VA = "0x187FA60C0", Slot = "8")]
	public bool FAFLCMNAEHG(ANJEECOKPKB DBPKMBNLBJM, [Out] DNHFACAJPBE? LBEKEMPAKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6E70", Offset = "0x7FA5A70", VA = "0x187FA6E70", Slot = "9")]
	public bool MPCDGILCGKN(ANJEECOKPKB DBPKMBNLBJM, [Out] JCFOCGDGHJD? ODKMBOGKFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C59D30", Offset = "0x3C58930", VA = "0x183C59D30")]
	private bool ACCHANHOAOK<TInput, TOutput>(TInput HOKNBAKODNG, NCPCEKKCPEN<TInput, TOutput> IOPCOHDEODN, [Out] TOutput? ABEFNIJCBBN) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6CC0", Offset = "0x7FA58C0", VA = "0x187FA6CC0")]
	[CompilerGenerated]
	private BLBNDIFNKIB MLHLAGOMGCI(FaceFeatureType ECOBAHJDEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FA6AE0", Offset = "0x7FA56E0", VA = "0x187FA6AE0")]
	[CompilerGenerated]
	private BLBNDIFNKIB KAENMCCGDHL(FaceFeatureType ECOBAHJDEJN, KAGBOIKLEGI P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[GOLNKMGDHKC]
internal class ILCAGHDBKBM : JIGJFNNEMPG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void PIGOPDNLOBF<in TData>(TData LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GELHNBEFJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public IJKJCJNKOIH rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JLDKKACDNCN currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JLDKKACDNCN latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GELHNBEFJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5F90", Offset = "0x7FA4B90", VA = "0x187FA5F90")]
		internal bool DAHADCEGCHP(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5FB0", Offset = "0x7FA4BB0", VA = "0x187FA5FB0")]
		internal bool OMNBHINKEAJ(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IPADCJFEADJ HMFDDNHKFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MBDBKJKILHH LOAKGGDNOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PIGOPDNLOBF<DNHFACAJPBE>?[] IBPGBGCMENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PIGOPDNLOBF<JCFOCGDGHJD>?[] FAPMKIKMONJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FA90F0", Offset = "0x7FA7CF0", VA = "0x187FA90F0")]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	[UsedImplicitly]
	internal static void GNDDLPOIOFL(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9820", Offset = "0x7FA8420", VA = "0x187FA9820")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ILCAGHDBKBM([HAKCNCGPHPD(null)] IPADCJFEADJ HMFDDNHKFLB, [HAKCNCGPHPD(null)] MBDBKJKILHH LOAKGGDNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9480", Offset = "0x7FA8080", VA = "0x187FA9480", Slot = "4")]
	public bool LCABPFJPNEL(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9580", Offset = "0x7FA8180", VA = "0x187FA9580", Slot = "5")]
	public bool LCABPFJPNEL(JCFOCGDGHJD ODKMBOGKFAP, IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FA7C90", Offset = "0x7FA6890", VA = "0x187FA7C90")]
	private void ADDLMCKMLAA(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8EC0", Offset = "0x7FA7AC0", VA = "0x187FA8EC0")]
	private void GDHIMDFDOFC(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9160", Offset = "0x7FA7D60", VA = "0x187FA9160")]
	private void IOFKEBKJPHO(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8DE0", Offset = "0x7FA79E0", VA = "0x187FA8DE0")]
	private void EGMECCAGIEK(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9720", Offset = "0x7FA8320", VA = "0x187FA9720")]
	private void PCGEIGAOJGI(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8880", Offset = "0x7FA7480", VA = "0x187FA8880")]
	private void CMOLPHPCEGC(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8E10", Offset = "0x7FA7A10", VA = "0x187FA8E10")]
	private void FJIPGGPAJCG(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9470", Offset = "0x7FA8070", VA = "0x187FA9470")]
	private void KPGINMFLIHO(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FA97F0", Offset = "0x7FA83F0", VA = "0x187FA97F0")]
	private void PHDAGBADDAH(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? HPNKJCMLGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8930", Offset = "0x7FA7530", VA = "0x187FA8930")]
	private void CPDOJAHDFDC(DNHFACAJPBE LBEKEMPAKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9190", Offset = "0x7FA7D90", VA = "0x187FA9190")]
	private DNHFACAJPBE KKFBLCIPEDC(DNHFACAJPBE LBEKEMPAKCH, List<RangeMigration> FNHIOCLOILP, JLDKKACDNCN LDELKKENAOJ, JLDKKACDNCN JAHJGNGEHPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FA96E0", Offset = "0x7FA82E0", VA = "0x187FA96E0")]
	private float OOINDNCLEHB(float HKAGLMNICCI, Vector2 CPIGBBFHLDA, Vector2 HHDPPJJDPJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FA8C10", Offset = "0x7FA7810", VA = "0x187FA8C10")]
	private (RangeMigration?, RangeMigration?) DAPKBDHBGAF(List<RangeMigration> AEICLGLGFGM, IJKJCJNKOIH LNPLDFMENBC, JLDKKACDNCN LDELKKENAOJ, JLDKKACDNCN JAHJGNGEHPO)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JIGJFNNEMPG
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCABPFJPNEL(DNHFACAJPBE LBEKEMPAKCH, IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCABPFJPNEL(JCFOCGDGHJD ODKMBOGKFAP, IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF);
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AnimationPoseSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Tooltip("Type of pose")]
		public JEAFEOEMKON AnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Tooltip("Blend in time")]
		public float BlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("How much of the head movement is applied to the hand movement")]
		public float HeadMovementWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("Weight between IK hand and Animated hand for position")]
		public float HandAnimationPosWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Tooltip("Weight between IK hand and Animated hand for rotation")]
		public float HandAnimationRotWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Tooltip("Weight between shoulders facing forward and alignment with hands")]
		public float ShoulderFollowWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Tooltip("How much the aim follows direction of feet vs head (0 = head, 1 = feet)")]
		public float FeetFollowWeight;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F89210", Offset = "0x7F87E10", VA = "0x187F89210")]
		public void GLKHIGEIALI(AnimationPoseSetting IIOGPDPGOLB, float BMJFENGKNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F89340", Offset = "0x7F87F40", VA = "0x187F89340")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		[SerializeField]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F89C50", Offset = "0x7F88850", VA = "0x187F89C50")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F89C10", Offset = "0x7F88810", VA = "0x187F89C10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F89360", Offset = "0x7F87F60", VA = "0x187F89360")]
		private void GDLCIKKHHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F15640", Offset = "0x7F14240", VA = "0x187F15640", Slot = "4")]
		public void SetEnabled(bool PMENEMBMEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F89C80", Offset = "0x7F88880", VA = "0x187F89C80")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F89CC0", Offset = "0x7F888C0", VA = "0x187F89CC0")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("Lower than 1 makes the head bob less.")]
		public float BeanHeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("Numbers under 1 = uses a slower locomotion animation. Above = faster.")]
		public float BeanLocomotionAnimationSelectionScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Numbers under 1 = plays the locomotion animations at a slower speed. Above = faster.")]
		public float BeanLocomotionAnimationSpeedScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Forward offset applied to bean animations.")]
		public float BeanHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("Straighten the back by moving the pelvis instead of leaning towards the head.")]
		public float BeanStraightBackFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float ClassicBeanHandSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Header("Watch")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40D")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x464")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x484")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4AC")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4CC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4DC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4FC")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x500")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x504")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x508")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x510")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x518")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F89D00", Offset = "0x7F88900", VA = "0x187F89D00")]
		public AnimationPoseSetting BKMKNELLHPF(JEAFEOEMKON HNPGFFCHHCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F89D30", Offset = "0x7F88930", VA = "0x187F89D30")]
		public void CBACPPGGEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F89D70", Offset = "0x7F88970", VA = "0x187F89D70")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum FEJNMAMHDAP
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private FEJNMAMHDAP handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A880", Offset = "0x7F89480", VA = "0x187F8A880")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A840", Offset = "0x7F89440", VA = "0x187F8A840")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A220", Offset = "0x7F88E20", VA = "0x187F8A220")]
		private void GDLCIKKHHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F15640", Offset = "0x7F14240", VA = "0x187F15640", Slot = "4")]
		public void SetEnabled(bool PMENEMBMEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A8B0", Offset = "0x7F894B0", VA = "0x187F8A8B0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, BAEPBOHMPHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private ADAOAPJGFHC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		[IODJOKMKDII(AFILHNGOOLF.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[Header("Configuration")]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[FormerlySerializedAs("HeadTweakBone")]
		[SerializeField]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private JBPBJDNACEG GLEJPNFNFAN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JBPBJDNACEG BABBPIBBOMM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xBC4CF0", Offset = "0xBC38F0", VA = "0x180BC4CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform KJLFJNIEJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B750", Offset = "0x7F8A350", VA = "0x187F8B750", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A8E0", Offset = "0x7F894E0", VA = "0x187F8A8E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B610", Offset = "0x7F8A210", VA = "0x187F8B610")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B5C0", Offset = "0x7F8A1C0", VA = "0x187F8B5C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B550", Offset = "0x7F8A150", VA = "0x187F8B550")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A8E0", Offset = "0x7F894E0", VA = "0x187F8A8E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F8AD20", Offset = "0x7F89920", VA = "0x187F8AD20", Slot = "6")]
		public JBPBJDNACEG CreateAvatarSystem(string HEFLAGJCJPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B550", Offset = "0x7F8A150", VA = "0x187F8B550", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A9A0", Offset = "0x7F895A0", VA = "0x187F8A9A0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B660", Offset = "0x7F8A260", VA = "0x187F8B660", Slot = "9")]
		public void UpdatePostIKAnimControllers(float EOLAIOLLEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CBGOCEBDHOF : JBPBJDNACEG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class CDIOIAPDPLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 DHGODCKDILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion EPIJPGIBEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 PPCKGBCHHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Transform MDKNPGHGHOJ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 CLFDBAMEDCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x21820C0", Offset = "0x2180CC0", VA = "0x1821820C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x21820E0", Offset = "0x2180CE0", VA = "0x1821820E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion IOJEABMKAFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1573990", Offset = "0x1572590", VA = "0x181573990")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1573A20", Offset = "0x1572620", VA = "0x181573A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float ELIHCEEKAMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1205880", Offset = "0x1204480", VA = "0x181205880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1976270", Offset = "0x1974E70", VA = "0x181976270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool LGAFEAOLLEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5F0", Offset = "0xA5A1F0", VA = "0x180A5B5F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5C0", Offset = "0xA5A1C0", VA = "0x180A5B5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool JHOOBNFNHMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA5B640", Offset = "0xA5A240", VA = "0x180A5B640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA5B520", Offset = "0xA5A120", VA = "0x180A5B520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool LALOFNAFAAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5B0", Offset = "0xA5A1B0", VA = "0x180A5B5B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA5B590", Offset = "0xA5A190", VA = "0x180A5B590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float DLDCNOPFIFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xDAA020", Offset = "0xDA8C20", VA = "0x180DAA020")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xDAA010", Offset = "0xDA8C10", VA = "0x180DAA010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEF40", Offset = "0x7FADB40", VA = "0x187FAEF40")]
		public void NGNLNMDAPNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7FAECE0", Offset = "0x7FAD8E0", VA = "0x187FAECE0")]
		public void EBDEDMFAMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEAB0", Offset = "0x7FAD6B0", VA = "0x187FAEAB0")]
		public float BJBMCEDGKBB(Vector3 HBDFFLOJLPB, Quaternion IGDIOGGIJHB, [In] AvatarFootSettings DFPMAJLODAH, float AKFDCHKADCH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7FAE3D0", Offset = "0x7FACFD0", VA = "0x187FAE3D0")]
		public void BCFAABKBPPN(Vector3 CCLEOJCCGEH, Quaternion CNNGMICBDLP, Transform CEMDPNBFKDJ, float EPKCOKHEIAH, bool GNMGBIEOABE, bool BJKNAENHGKB, float MABNBKBLJFN, float AGFNEGMHDJP, Transform OLIIIAEGOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEF50", Offset = "0x7FADB50", VA = "0x187FAEF50")]
		public void PBADJHDNIDP(Transform MGKDFBLEIOC, Transform OLIIIAEGOLD, bool NANGNFOIKGF, bool AIMFLAGMDCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEE40", Offset = "0x7FADA40", VA = "0x187FAEE40")]
		private void NGFJEPKDGPO(Transform OLIIIAEGOLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7FAECF0", Offset = "0x7FAD8F0", VA = "0x187FAECF0")]
		public bool EFDEEHFELFM(Transform OLIIIAEGOLD, AvatarFullBodyConfiguration IAPLIGCGIFJ, Vector3 OBNPGJANDAC, float NKAKELGHFAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7FAECC0", Offset = "0x7FAD8C0", VA = "0x187FAECC0")]
		public void CNLLHPCLAFJ(float AGFNEGMHDJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7FAF180", Offset = "0x7FADD80", VA = "0x187FAF180")]
		public CDIOIAPDPLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class HEIMBNBHOEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float MIFCJGLIOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool IFAEEFDEBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AnimationPoseSetting BMIHDENEHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private float HNLAGEPEEJO;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2300", Offset = "0x7FB0F00", VA = "0x187FB2300")]
		public void OMFOOHKGPMG(IKSolverVR.Arm FNKAHKBKLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7FB0CD0", Offset = "0x7FAF8D0", VA = "0x187FB0CD0")]
		public void COFEPGPNACC(IKSolverVR.Arm FNKAHKBKLFE, float DBKEFHENIDG, bool IFAEEFDEBCF, AvatarFullBodyConfiguration IAPLIGCGIFJ, float PGNEIGACMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7FB1820", Offset = "0x7FB0420", VA = "0x187FB1820")]
		private void KJGCGGPGJPG(IKSolverVR.Arm FNKAHKBKLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7FB1440", Offset = "0x7FB0040", VA = "0x187FB1440")]
		public void KACOFJOIHMJ(IKSolverVR.Arm FNKAHKBKLFE, Transform AJHIEKNCGGK, Transform CEMDPNBFKDJ, Quaternion KHJFPIOKNNH, Vector3 POMHFKGEAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FB0D10", Offset = "0x7FAF910", VA = "0x187FB0D10")]
		private (Vector3, Quaternion) IPMAFOLADEK(AKPKGBFIAOI HGJGJBGNALO, Quaternion GIBPFHCPCFB, Vector3 ENBNGLCJDHN)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7FB12E0", Offset = "0x7FAFEE0", VA = "0x187FB12E0")]
		public void JCBDBIEMIPG(AKPKGBFIAOI HGJGJBGNALO, IKSolverVR.Arm FNKAHKBKLFE, Quaternion GIBPFHCPCFB, Vector3 ENBNGLCJDHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7FB1860", Offset = "0x7FB0460", VA = "0x187FB1860")]
		public void KMAOMIKKMLN(AKPKGBFIAOI HGJGJBGNALO, IKSolverVR.Arm FNKAHKBKLFE, Quaternion GIBPFHCPCFB, Vector3 ENBNGLCJDHN, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ, [In] CCKALBILEGK EKPDKNLBIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7FB11A0", Offset = "0x7FAFDA0", VA = "0x187FB11A0")]
		public void JBAAGGMALNG(JEAFEOEMKON HEHPNGMONHE, AvatarFullBodyConfiguration IAPLIGCGIFJ, CCKALBILEGK EKPDKNLBIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7FB1E60", Offset = "0x7FB0A60", VA = "0x187FB1E60")]
		public void OBNGBPNLJOB(IKSolverVR.Arm FNKAHKBKLFE, Transform AJHIEKNCGGK, Vector3 KHMNJADABEJ, float EGOBEHNPIGO, Quaternion NNANLLMCDGG, Vector3 KBNEIFFIDBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2330", Offset = "0x7FB0F30", VA = "0x187FB2330")]
		public HEIMBNBHOEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum IDGHLKONKPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct AEIIKJKECBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct KCCHADPEPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int CFIKKAMOMMD;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int LGHBLGHMFOP;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int LEHMLKEDDHI;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int LEHHBGGEKKB;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int GNGOJLPHJBK;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int ALEDECNOJCE;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int PFAHGCHDKMP;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int IALPDCIFCMI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int KPIEJKDLLED;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int APFBKGNHKKH;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int LDJEMAGDEMF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GHHIJMCCHLH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int MJIGABHELDE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int OFJNDBIPCEO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int JMDKFJACHKB;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int IALBLHABMNL;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int CEOOOLKKOBI;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int EFHKDCAFCAM;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int DNGDDOEEKPH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int LNLFIEDOIGP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int JHFEGJCMFAK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int CNJOFCPHPHI;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int OIJDIMMGMFD;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int HOIDLEEPBMF;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int KPKLJEGBJCJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int CKNHNKKPEFA;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int OLOMALAMDHE;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int KNKFHEFBICO;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int GOFPPFICILN;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int GNNEHIPKKEH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int MECDABKCCDM;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int HAFMHPBEFMC;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 PLHILJBODOK;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int APCMGDFGCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool ACBOJONMPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool IOMMJKJFNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool CIHHDMIJACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool BOHFKOGMCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool CPPDAOFJOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool HFMAPAOKGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 OMGNHFFPMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string LHIIMIDLCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private JMIMFNDJLAN? PFLEHJGLOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private HHMJHEBIMDC? IIEODPGGAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private AGFBOOANFCD HAPLOFGAFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private BGHJPDBAAMP LIKGNCPIJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private AKPKGBFIAOI BAOHBKMHGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private AKPKGBFIAOI DLMMCNJECOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool ONJFDKCPPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool PGLPCEPOBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly PEOADOIIIAA DDMHAKPLIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly LBEHIIHKMIG AIPJMGGNGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int KEEJFIFPKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float AGECBNLGNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject MDNCIENIBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform OLNCIADJHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform EBLMMNMALKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform LGCLIMCJKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform DGBDFEKEMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float FOLDLGOEDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float AOHEHPGJCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 ACIPPMINDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion LLPCPCOLIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform BNNCLPCJIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform LPHDOANGKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform DLAPFAMCEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NDKKALCAOBO DEMKLBFOEBL;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker EHKPGHIELKC;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker GBOANLFCECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker NCEPFKHMLHF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker EIBPDNOJHDN;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker GHIBOECFMEI;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker OHMCNPOILFG;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<CBGOCEBDHOF> FMNDOGFHCAG;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int HCDPIDPACPL;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> MDLNHHCGCPE;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int JBJNKANHGCA;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int ABPEGOEDPCB;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int NGEDJOPGPMC;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int NNBMGOKAAAA;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float GPEIAGMIEFO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int CHCPCGPDFHH;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float ABIABMOCOPN;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float DLAEKCANKAL;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float BPBKOBBLIPL;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float MFHNKHDNEDF;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static HPIHLIOJMAG KFIPPCHJNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float AHPFOEBPIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool KFKKIMABDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float JPJECPMOEIG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int JLNPOCBIJFK;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int FGEHJOLBLEF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int DEDAFPHNDJH;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int GKHNAIAACJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private CDIOIAPDPLE NEGKACJONFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private CDIOIAPDPLE MOHOPLJOFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float KBBJIELLBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 GONBPOOPAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 BJJJLFGCGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool BGIIGFAKINN;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion MCHFONNIBKP;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion JFAGGEFCKFO;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 DLNKNEAOOBK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 HJDJMONBJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float HEGGIJODNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float FEPMCOIMOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private HEIMBNBHOEM MPEFCJHHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private HEIMBNBHOEM FFJGHFAHGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JLAGHJFFPLN PANHPCGOIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private LPDGBMPHNKE DHDHFPMANAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly MHHGOJGCKAL GGHNLBCLKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float BGMAPENIHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float LJEJFKHLPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly LPDGBMPHNKE LFKNMGCCLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 BEOAKCHPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 PGJIFPDGDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float FDCJNANGDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float LIBDEILPDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly LPDGBMPHNKE NKFMHBOGNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly JLAGHJFFPLN OBAMJAOAACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly LPDGBMPHNKE BHGNMAGKEBL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LKKDMOCNJPN DIAOMLINAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LKKDMOCNJPN CJOGCCNGBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration DAFCNNGLNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7F8C180", Offset = "0x7F8AD80", VA = "0x187F8C180", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ADAOAPJGFHC NPJGNLJDDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F95300", Offset = "0x7F93F00", VA = "0x187F95300", Slot = "24")]
		get
		{
			return default(ADAOAPJGFHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration DHMNIMNHGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4640", Offset = "0x7FA3240", VA = "0x187FA4640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform KHPMPFKJLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F95400", Offset = "0x7F94000", VA = "0x187F95400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform NGPHDPJIPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E7A0", Offset = "0x7F8D3A0", VA = "0x187F8E7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer EHJGKMOHNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E950", Offset = "0x7F8D550", VA = "0x187F8E950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] LKENHPNNPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F8C280", Offset = "0x7F8AE80", VA = "0x187F8C280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] NNMIODLBNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3510", Offset = "0x7FA2110", VA = "0x187FA3510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator NOMNDEAOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A180", Offset = "0x7F98D80", VA = "0x187F9A180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK GABBMNJMNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F630", Offset = "0x7F9E230", VA = "0x187F9F630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private NBBKAEDFNEM NFIEBGCADMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F956B0", Offset = "0x7F942B0", VA = "0x187F956B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private NBBKAEDFNEM FEPGPGOJFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8FEB0", Offset = "0x7F8EAB0", VA = "0x187F8FEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private NBBKAEDFNEM MGKNANHMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8F990", Offset = "0x7F8E590", VA = "0x187F8F990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private NBBKAEDFNEM KPEHHAECBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3610", Offset = "0x7FA2210", VA = "0x187FA3610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NBBKAEDFNEM KLIOGKJJGON
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4540", Offset = "0x7FA3140", VA = "0x187FA4540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private NBBKAEDFNEM BBHLHNJPCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA29D0", Offset = "0x7FA15D0", VA = "0x187FA29D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private NBBKAEDFNEM OLDNBMCCLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F070", Offset = "0x7F9DC70", VA = "0x187F9F070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private NBBKAEDFNEM FFJBEKBPGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1030", Offset = "0x7F9FC30", VA = "0x187FA1030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HHMJHEBIMDC JNMMKCBAEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7FA28C0", Offset = "0x7FA14C0", VA = "0x187FA28C0", Slot = "16")]
		get
		{
			return default(HHMJHEBIMDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FNKBCEMJFAH ELLOKCFLAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB51010", Offset = "0xB4FC10", VA = "0x180B51010", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HGPOBCJDMGK KCEMAFNKGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB51000", Offset = "0xB4FC00", VA = "0x180B51000", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LAJPNBFOHGM CGPHEOGJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xBCAC10", Offset = "0xBC9810", VA = "0x180BCAC10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LAJPNBFOHGM NJFANICKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB51290", Offset = "0xB4FE90", VA = "0x180B51290", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string GKEADFCHBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform HBAALFBPCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7FA39C0", Offset = "0x7FA25C0", VA = "0x187FA39C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform FIKHNNAFNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4380", Offset = "0x7FA2F80", VA = "0x187FA4380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform GPGNGALKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F92E70", Offset = "0x7F91A70", VA = "0x187F92E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform DLPOHCEAGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E290", Offset = "0x7F8CE90", VA = "0x187F8E290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform HELIJPBDFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8E760", Offset = "0x7F8D360", VA = "0x187F8E760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool KIHMBJKJPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8FFB0", Offset = "0x7F8EBB0", VA = "0x187F8FFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool PAJNJALLIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8FFB0", Offset = "0x7F8EBB0", VA = "0x187F8FFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool DJPNLAMMEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F94C10", Offset = "0x7F93810", VA = "0x187F94C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform BCFDPKDFEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F98EF0", Offset = "0x7F97AF0", VA = "0x187F98EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject HLOIBGDKPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F92360", Offset = "0x7F90F60", VA = "0x187F92360", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets FBAAOCBOOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F7B0", Offset = "0x7F9E3B0", VA = "0x187F9F7B0", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform NHNOJGNLMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xBCB580", Offset = "0xBCA180", VA = "0x180BCB580", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform CLIJGIPKANE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBCAB10", Offset = "0xBC9710", VA = "0x180BCAB10", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform EAEPDBINPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBB7340", Offset = "0xBB5F40", VA = "0x180BB7340", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform HFHJPMGCPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAD21D0", Offset = "0xAD0DD0", VA = "0x180AD21D0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 JHHKJDJECLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F94D00", Offset = "0x7F93900", VA = "0x187F94D00", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float BOLBDDFPDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7FA30E0", Offset = "0x7FA1CE0", VA = "0x187FA30E0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform IOPBGDDAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0750", Offset = "0x7F9F350", VA = "0x187FA0750", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform NNOEJHKFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1568DB0", Offset = "0x15679B0", VA = "0x181568DB0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform EFDGACGGNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1568B60", Offset = "0x1567760", VA = "0x181568B60", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform BKGGHKHNBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAD29E0", Offset = "0xAD15E0", VA = "0x180AD29E0", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool LFDCFMJJGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EF80", Offset = "0x7F9DB80", VA = "0x187F9EF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GFJLLHFJBHN<JBPBJDNACEG.EJFBOLPOEFG> HOCPIGMLAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1324EF0", Offset = "0x1323AF0", VA = "0x181324EF0", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool NMGDDIHGIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F8CA30", Offset = "0x7F8B630", VA = "0x187F8CA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool GJHFAFAMNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F91220", Offset = "0x7F8FE20", VA = "0x187F91220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1D30", Offset = "0x7FA0930", VA = "0x187FA1D30")]
	private float NEBGGAIHJBA(IEELAHJAJHO APHEECONCKB, float MPBDMKIBGHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F957B0", Offset = "0x7F943B0", VA = "0x187F957B0")]
	private void HPEGHJMLPJK([In] CCKALBILEGK CHGBHPJFABC, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ, bool GLGPLHBONFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FA06C0", Offset = "0x7F9F2C0", VA = "0x187FA06C0")]
	private float LMPFMGDBMNP([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F730", Offset = "0x7F9E330", VA = "0x187F9F730")]
	private float KJGDDGAFGBO([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FD40", Offset = "0x7F9E940", VA = "0x187F9FD40")]
	private void KPKFIGENEBA(CCKALBILEGK CHGBHPJFABC, AvatarFullBodyConfiguration IAPLIGCGIFJ, bool GLGPLHBONFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F570", Offset = "0x7F8E170", VA = "0x187F8F570")]
	private void CGLMIEBINCN([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D960", Offset = "0x7F8C560", VA = "0x187F8D960")]
	private void BADDADCFCBB([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA5A90", Offset = "0x7FA4690", VA = "0x187FA5A90")]
	public CBGOCEBDHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F90CC0", Offset = "0x7F8F8C0", VA = "0x187F90CC0", Slot = "13")]
	public void EAGPBCFFPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F92930", Offset = "0x7F91530", VA = "0x187F92930", Slot = "14")]
	public void FGCGBKJPOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F95230", Offset = "0x7F93E30", VA = "0x187F95230", Slot = "15")]
	public void HIEFHOHFNHB(bool GEDJOPLOHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2AD0", Offset = "0x7FA16D0", VA = "0x187FA2AD0", Slot = "26")]
	public Transform OEHBBDJKIHG(string FLOCHPNMHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1B90", Offset = "0x7FA0790", VA = "0x187FA1B90", Slot = "27")]
	public Vector3? NDDIOHHKICE(string FLOCHPNMHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F920C0", Offset = "0x7F90CC0", VA = "0x187F920C0", Slot = "7")]
	public void EPHFFLKKBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F8EEF0", Offset = "0x7F8DAF0", VA = "0x187F8EEF0")]
	private void CGBDGOCLKDG(AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F8DA60", Offset = "0x7F8C660", VA = "0x187F8DA60", Slot = "8")]
	public void BBIIEJOGELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E2D0", Offset = "0x7F8CED0", VA = "0x187F8E2D0")]
	private void BOFGMKLAPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA43C0", Offset = "0x7FA2FC0", VA = "0x187FA43C0")]
	private Vector3 PGLBACDFEOD([In] CCKALBILEGK EKPDKNLBIHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E660", Offset = "0x7F9D260", VA = "0x187F9E660", Slot = "6")]
	public void JPCGKIMODOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1F10", Offset = "0x7FA0B10", VA = "0x187FA1F10")]
	private void NHIKBNELBNE(bool GLGPLHBONFF, IDGHLKONKPA FAOKBOGFDCM, AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CDA0", Offset = "0x7F9B9A0", VA = "0x187F9CDA0", Slot = "9")]
	public void JHMPLCEJILH(float OOLFNOKHHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA07B0", Offset = "0x7F9F3B0", VA = "0x187FA07B0")]
	private void MDGCIAPDMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A6C0", Offset = "0x7F992C0", VA = "0x187F9A6C0", Slot = "4")]
	public void JDLLMEAGKJH(string HEFLAGJCJPL, JMIMFNDJLAN IBIDBPIMDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F912F0", Offset = "0x7F8FEF0", VA = "0x187F912F0", Slot = "5")]
	public void ELLIICJEIOO(HHMJHEBIMDC BKJOJPBEKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C8F0", Offset = "0x7F9B4F0", VA = "0x187F9C8F0", Slot = "12")]
	public void JEOPBGLOGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E3D0", Offset = "0x7F8CFD0", VA = "0x187F8E3D0", Slot = "25")]
	public void CAIFOOEGKFF([Out] Vector3 GDEPLALHFOI, [Out] Quaternion NNANLLMCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F8F960", Offset = "0x7F8E560", VA = "0x187F8F960")]
	private void CHLGMOPAJCO([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0800", Offset = "0x7F9F400", VA = "0x187FA0800", Slot = "28")]
	public void MIADHKDJEMH(float KEDLFMGPHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CA50", Offset = "0x7F9B650", VA = "0x187F9CA50", Slot = "29")]
	public void JGEKMHCHCNN(float GHGPGMKHCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1970", Offset = "0x7FA0570", VA = "0x187FA1970", Slot = "46")]
	public void MNJBHFDFHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F912A0", Offset = "0x7F8FEA0", VA = "0x187F912A0", Slot = "30")]
	public void EFBJFKFFCPP(bool NELGGBKDLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7FA04D0", Offset = "0x7F9F0D0", VA = "0x187FA04D0", Slot = "31")]
	public HandLogicOffsets LHEAJIBMKMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E1D0", Offset = "0x7F8CDD0", VA = "0x187F8E1D0", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets BKJJMMINFEG()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0280", Offset = "0x7F9EE80", VA = "0x187FA0280")]
	private void LEILPOGFJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A000", Offset = "0x7F98C00", VA = "0x187F9A000")]
	private void JBKKLDDEOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A280", Offset = "0x7F98E80", VA = "0x187F9A280")]
	private void JDJELCMFHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F93490", Offset = "0x7F92090", VA = "0x187F93490")]
	private void FNLEJIGDDEB(HAGJDPFPLEP NLOBCBDIMCJ, bool EBMHMKKDKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2740", Offset = "0x7FA1340", VA = "0x187FA2740")]
	private void NMCDMKNLDEE(HAGJDPFPLEP NLOBCBDIMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F93770", Offset = "0x7F92370", VA = "0x187F93770")]
	public Vector3 GBIGLLJACGB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8EC00", Offset = "0x7F8D800", VA = "0x187F8EC00")]
	private void CFPEIIKNDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F947F0", Offset = "0x7F933F0", VA = "0x187F947F0")]
	private void GMIILOJELGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C380", Offset = "0x7F8AF80", VA = "0x187F8C380")]
	private void AINIAIDNDDL(CCKALBILEGK CHGBHPJFABC, AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8EA50", Offset = "0x7F8D650", VA = "0x187F8EA50")]
	private float CEFHHCCEJOL([In] CCKALBILEGK EKPDKNLBIHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3710", Offset = "0x7FA2310", VA = "0x187FA3710")]
	private int OJJMJMCEHKC([In] AHFCJDFACJG EFINFFGHNBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F8DCA0", Offset = "0x7F8C8A0", VA = "0x187F8DCA0")]
	private void BEGPKODINKE(CCKALBILEGK CHGBHPJFABC, bool HDPCDDOOPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FA02B0", Offset = "0x7F9EEB0", VA = "0x187FA02B0")]
	private static void LFIFAICOMAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CE10", Offset = "0x7F9BA10", VA = "0x187F9CE10")]
	private static void JIECLDJBJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7FA37F0", Offset = "0x7FA23F0", VA = "0x187FA37F0")]
	private float OLCJGIMEAIJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E630", Offset = "0x7F9D230", VA = "0x187F9E630")]
	private static int JLKADKAKAID(CBGOCEBDHOF ODBANBBPCIA, CBGOCEBDHOF FMNHBACBGIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1130", Offset = "0x7F9FD30", VA = "0x187FA1130", Slot = "41")]
	public CCKALBILEGK MKOHPHIOCGB()
	{
		return default(CCKALBILEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F99DC0", Offset = "0x7F989C0", VA = "0x187F99DC0")]
	private bool IKBNDFHAKLE(int OIBGADINDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F99E70", Offset = "0x7F98A70", VA = "0x187F99E70")]
	public void IPFNJGBCJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F92750", Offset = "0x7F91350", VA = "0x187F92750")]
	private (bool, bool) FFHGDGJJOLJ()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F94610", Offset = "0x7F93210", VA = "0x187F94610")]
	private (float, float) GLDKHLACOID([In] CCKALBILEGK EKPDKNLBIHJ)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F97290", Offset = "0x7F95E90", VA = "0x187F97290")]
	private void IDNEAPCIMAE([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F830", Offset = "0x7F9E430", VA = "0x187F9F830")]
	private void KNGDIEDODCN([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FA90", Offset = "0x7F8E690", VA = "0x187F8FA90")]
	private void DDOIALFINHM([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ, AvatarFootSettings DFPMAJLODAH, bool IFKPCHKIPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FED0", Offset = "0x7F9EAD0", VA = "0x187F9FED0")]
	private float LBPGCPIGNHD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F98FF0", Offset = "0x7F97BF0", VA = "0x187F98FF0")]
	private void IEPCJGBJLFF(CCKALBILEGK EKPDKNLBIHJ, AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7FA26F0", Offset = "0x7FA12F0", VA = "0x187FA26F0")]
	private float NLJFHAAJHAO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7FA2C20", Offset = "0x7FA1820", VA = "0x187FA2C20")]
	private void OGHJEIKGGEG([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E850", Offset = "0x7F9D450", VA = "0x187F9E850")]
	private void KACOFJOIHMJ([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F94810", Offset = "0x7F93410", VA = "0x187F94810")]
	private void GOADECDGNFI([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FF50", Offset = "0x7F9EB50", VA = "0x187F9FF50")]
	private void LCACHGFHJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3130", Offset = "0x7FA1D30", VA = "0x187FA3130")]
	private void OHFOBAFNBLH(float FCCCDCJDMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F92CE0", Offset = "0x7F918E0", VA = "0x187F92CE0")]
	private void FLGKLOCKEFH([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F90A30", Offset = "0x7F8F630", VA = "0x187F90A30")]
	private void DOGCLDFMGPO(AKPKGBFIAOI EKECOKDHPKI, IKSolverVR.Arm FNKAHKBKLFE, Transform HALGFOHIPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FA4A90", Offset = "0x7FA3690", VA = "0x187FA4A90")]
	private void PJFLFODOAFC(CCKALBILEGK EKPDKNLBIHJ, AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7FA19C0", Offset = "0x7FA05C0", VA = "0x187FA19C0")]
	private void NCGNJONHFIH(FLGMPPMEFKK EPADFPACDMB, LAJPNBFOHGM EKECOKDHPKI, IKSolverVR.Arm FNKAHKBKLFE, float DBKEFHENIDG, float DJCFOHJOLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F94D90", Offset = "0x7F93990", VA = "0x187F94D90")]
	private void HEGOJKAGFFM([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F8CAB0", Offset = "0x7F8B6B0", VA = "0x187F8CAB0")]
	private void AOECPJFOOHD([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7FA46D0", Offset = "0x7FA32D0", VA = "0x187FA46D0")]
	protected void PINABOJLMOH([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F92400", Offset = "0x7F91000", VA = "0x187F92400")]
	private void EPMKHABHGCE([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F99B70", Offset = "0x7F98770", VA = "0x187F99B70")]
	protected void IHJJNGGCNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0810", Offset = "0x7F9F410", VA = "0x187FA0810")]
	private void MJEDJGFJLKO([In] CCKALBILEGK EKPDKNLBIHJ, [In] IDGHLKONKPA FAOKBOGFDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7FA41D0", Offset = "0x7FA2DD0", VA = "0x187FA41D0")]
	private void PAFDCBLDAPC(CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F909F0", Offset = "0x7F8F5F0", VA = "0x187F909F0")]
	private void DNJDGLCGDFM([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F92F70", Offset = "0x7F91B70", VA = "0x187F92F70")]
	private Vector3 FMMPNOGALPF([In] CCKALBILEGK EKPDKNLBIHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F92EA0", Offset = "0x7F91AA0", VA = "0x187F92EA0")]
	private void FMJGNCGPAIM([In] CCKALBILEGK EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F9E1E0", Offset = "0x7F9CDE0", VA = "0x187F9E1E0")]
	private float JLICCLCOGGG(float AGFNEGMHDJP, [In] CCKALBILEGK EKPDKNLBIHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F91770", Offset = "0x7F90370", VA = "0x187F91770")]
	private void EMBJBMBGABI(float AGFNEGMHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1280", Offset = "0x7F9FE80", VA = "0x187FA1280")]
	private void MMPPHMAKDAG([In] CCKALBILEGK EKPDKNLBIHJ, IDGHLKONKPA FAOKBOGFDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F918C0", Offset = "0x7F904C0", VA = "0x187F918C0")]
	private float ENMGHLAMPMF([In] CCKALBILEGK CHGBHPJFABC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F937C0", Offset = "0x7F923C0", VA = "0x187F937C0")]
	private void GCGNAAEDDLA(CCKALBILEGK EKPDKNLBIHJ, IDGHLKONKPA FAOKBOGFDCM, Vector3 IHAODDIOJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F95500", Offset = "0x7F94100", VA = "0x187F95500")]
	private static void HLHGHJOPIAP(Transform LMGPODOPMIJ, Quaternion DINDLKHALMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DB10", Offset = "0x7F9C710", VA = "0x187F9DB10")]
	private void JIJMCIADDOO([In] CCKALBILEGK EJNBLJMFJGK, [In] AHFCJDFACJG EFINFFGHNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D0B0", Offset = "0x7F8BCB0", VA = "0x187F8D0B0")]
	private void APNMOODHHNF([In] CCKALBILEGK EJNBLJMFJGK, [In] AHFCJDFACJG EFINFFGHNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F9FB50", Offset = "0x7F9E750", VA = "0x187F9FB50")]
	private void KNKNNAMDINN(float NKOEEPHCJFC, [In] CCKALBILEGK CHGBHPJFABC, float LCFJDPDKJMJ = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3A10", Offset = "0x7FA2610", VA = "0x187FA3A10")]
	private float OOOCGGGGNNP([In] CCKALBILEGK CHGBHPJFABC, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F94320", Offset = "0x7F92F20", VA = "0x187F94320")]
	private void GJJLBCGDGAL([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B770", Offset = "0x7F8A370", VA = "0x187F8B770")]
	private void ADJJBGPJMDN([In] CCKALBILEGK CHGBHPJFABC, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DE10", Offset = "0x7F9CA10", VA = "0x187F9DE10")]
	private void JKHECCCDFAG([In] CCKALBILEGK CHGBHPJFABC, float JIMBBEMBMJP, float BDNHPGGNEBJ, Vector3 HMPNGMNBIAE, float LCFJDPDKJMJ = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F90000", Offset = "0x7F8EC00", VA = "0x187F90000")]
	private void DNJBLKDBGKM(CCKALBILEGK CHGBHPJFABC, AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F94FA0", Offset = "0x7F93BA0", VA = "0x187F94FA0")]
	private void HHJJJIIJCAL(CCKALBILEGK EKPDKNLBIHJ, AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F9F170", Offset = "0x7F9DD70", VA = "0x187F9F170")]
	private void KFLCFALNPEA(CCKALBILEGK CHGBHPJFABC, AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7FA1D50", Offset = "0x7FA0950", VA = "0x187FA1D50")]
	public void NFFPEBMIJLB([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F93FC0", Offset = "0x7F92BC0", VA = "0x187F93FC0")]
	public void GDAIDDAAONI([In] CCKALBILEGK EKPDKNLBIHJ, [In] AvatarFullBodyConfiguration IAPLIGCGIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7FA0520", Offset = "0x7F9F120", VA = "0x187FA0520")]
	[CompilerGenerated]
	internal static void LKJJGKFINOC(Transform OJNBCCCOMPJ, IKSolverVR.Arm FNKAHKBKLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F8E8A0", Offset = "0x7F8D4A0", VA = "0x187F8E8A0")]
	[CompilerGenerated]
	internal static void CDHLPNEEGKJ(Vector3 MILCMPGCOJD, Vector3 PHFDLEPCLJJ, AEIIKJKECBL P_2, KCCHADPEPBD P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7FA01E0", Offset = "0x7F9EDE0", VA = "0x187FA01E0")]
	[CompilerGenerated]
	internal static void LCKJEPFBDMH(CDIOIAPDPLE HNDLMFIGNLC, CDIOIAPDPLE JONAFMLINLO, Vector3 HEBMCPMLGFD, float PDIIGKEPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F99EF0", Offset = "0x7F98AF0", VA = "0x187F99EF0")]
	[CompilerGenerated]
	internal static bool JAHGLBKCACD(IKSolverVR.Arm FNKAHKBKLFE, DIIBANCLBMB JIAJBCAPIMI, float HLFBHALGELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F9EB40", Offset = "0x7F9D740", VA = "0x187F9EB40")]
	[CompilerGenerated]
	internal static float KAMIDPKKEJL(Vector3 GLNEJGHLCHB, Vector3 EHOEIKHCMAF, Vector3 OICIHHFIOOE, CCKALBILEGK CHGBHPJFABC, AvatarFullBodyConfiguration IAPLIGCGIFJ, float HDEKJKJDEIC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class NCLGNKPOLHH : HMCCDHBPOAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Dictionary<string, JBPBJDNACEG> FHBEJAFFDGJ;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7FB52B0", Offset = "0x7FB3EB0", VA = "0x187FB52B0")]
	[HHMPGEJNNFC.JKDCLEHGFFF]
	internal static void NKAIAKMHDBE(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5090", Offset = "0x7FB3C90", VA = "0x187FB5090", Slot = "4")]
	public JBPBJDNACEG MIOGOFNKPNE(string CBJAHBJADMA, AvatarSystemConfiguration IJNAPAAIOHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4D00", Offset = "0x7FB3900", VA = "0x187FB4D00", Slot = "5")]
	public void EAPKBALBFAH(string CBJAHBJADMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4EE0", Offset = "0x7FB3AE0", VA = "0x187FB4EE0", Slot = "6")]
	public string FLEKGPJOLJB(string LPIHIPMJOIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5020", Offset = "0x7FB3C20", VA = "0x187FB5020")]
	private string FODEGICBMLK(string LPIHIPMJOIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5320", Offset = "0x7FB3F20", VA = "0x187FB5320")]
	public NCLGNKPOLHH()
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
		public class EENEDJEHGIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Dictionary<string, Transform> DCEENHJKBJN;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool NNPPJEMMDAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x7FAF780", Offset = "0x7FAE380", VA = "0x187FAF780")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7FAF810", Offset = "0x7FAE410", VA = "0x187FAF810")]
			public void NOBEOGNCDEA(VRIK EJONAEDEOIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
			public void EEBJKELOMME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7FAF7C0", Offset = "0x7FAE3C0", VA = "0x187FAF7C0")]
			public void HLOPEGKIHMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7FAF940", Offset = "0x7FAE540", VA = "0x187FAF940")]
			public EENEDJEHGIC()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[FBGDLCLCGKH(AFILHNGOOLF.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[IODJOKMKDII(AFILHNGOOLF.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly EENEDJEHGIC CBBNFBCDBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private BAEPBOHMPHD KGNNKBGLBFN;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB510", Offset = "0x7FAA110", VA = "0x187FAB510")]
		private void BFHPBJMBKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB7F0", Offset = "0x7FAA3F0", VA = "0x187FAB7F0")]
		private bool KLABMLHANHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB840", Offset = "0x7FAA440", VA = "0x187FAB840")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB8B0", Offset = "0x7FAA4B0", VA = "0x187FAB8B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB850", Offset = "0x7FAA450", VA = "0x187FAB850")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7FABB20", Offset = "0x7FAA720", VA = "0x187FABB20")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct HandsOpenCloseAmount
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7FB2CC0", Offset = "0x7FB18C0", VA = "0x187FB2CC0")]
			public (float, float) NCONKEKCHPA(float ANLHEFAPFKO)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7FB23B0", Offset = "0x7FB0FB0", VA = "0x187FB23B0")]
			public void CBACPPGGEHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7FB2490", Offset = "0x7FB1090", VA = "0x187FB2490")]
			public (float, float) FCGKDMBNOLH(Animator HELBIEEFMJE, AnimatorStateInfo GPDBLLJGDEH)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7FB25D0", Offset = "0x7FB11D0", VA = "0x187FB25D0")]
		public void CBACPPGGEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2A20", Offset = "0x7FB1620", VA = "0x187FB2A20")]
		public (float, float) JFADEGIBBKL(Animator HELBIEEFMJE, IEELAHJAJHO APHEECONCKB, float HAJDIPFLDAH)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7FB27C0", Offset = "0x7FB13C0", VA = "0x187FB27C0")]
		private (float, float) IJDONHICPCK(Animator HELBIEEFMJE, AnimatorStateInfo GPDBLLJGDEH, IEELAHJAJHO APHEECONCKB, float HAJDIPFLDAH)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7FB2CB0", Offset = "0x7FB18B0", VA = "0x187FB2CB0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4B70", Offset = "0x7FB3770", VA = "0x187FB4B70", Slot = "4")]
		public override void OnStateEnter(Animator HELBIEEFMJE, AnimatorStateInfo GPDBLLJGDEH, int GEADAOGNBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7FB4CE0", Offset = "0x7FB38E0", VA = "0x187FB4CE0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class LIHMGNPFKJP<TInput, TOutput> : NCPCEKKCPEN<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected readonly MBDBKJKILHH LOAKGGDNOOO;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x54634A0", Offset = "0x54620A0", VA = "0x1854634A0")]
	protected LIHMGNPFKJP(MBDBKJKILHH LOAKGGDNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput GLDNKJDIMCO(TInput HOKNBAKODNG, [Out] IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5463400", Offset = "0x5462000", VA = "0x185463400", Slot = "5")]
	public bool ACCHANHOAOK(TInput HOKNBAKODNG, [Out] TOutput? ABEFNIJCBBN, [Out] IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[GOLNKMGDHKC]
public static class FGHMJKOAGFA
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly Regex NPEHHOKBCAL;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF9D0", Offset = "0x7FAE5D0", VA = "0x187FAF9D0")]
	public static MDGPBLDMAEH LCMFBCCHPDC(IBGOJPCJDBO BBGEAICPIAD, GFJCEPIDMBH DCIPPMPIHOK, Guid? COGDOHLDAFA, Color? MBDBEPNGGFP, FMEODGEFBMO DAMAHFKHDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7FAFBE0", Offset = "0x7FAE7E0", VA = "0x187FAFBE0")]
	public static KJEPDDGGDOL LFJDNEEGDII(MDGPBLDMAEH CBCNBAPLLJM)
	{
		return default(KJEPDDGGDOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3C24880", Offset = "0x3C23480", VA = "0x183C24880")]
	internal static TModern? FLMCKLPGEHE<TModern>(string? HOKNBAKODNG, KAOCIBDKDIB<TModern> NLLEAJNAJCM, MBDBKJKILHH LOAKGGDNOOO, LIMHGBOGOKL OANHCEKIJNC, TModern JJAOFAGHKIG) where TModern : struct, CIMNPCOKFON
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3C26D50", Offset = "0x3C25950", VA = "0x183C26D50")]
	internal static NMAPCHCCICP LNHOMGANKJI<TModern>(string? HOKNBAKODNG, KAOCIBDKDIB<TModern> NLLEAJNAJCM, MBDBKJKILHH LOAKGGDNOOO, LIMHGBOGOKL OANHCEKIJNC, TModern JJAOFAGHKIG) where TModern : struct, CIMNPCOKFON
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7FAFD40", Offset = "0x7FAE940", VA = "0x187FAFD40")]
	internal static List<IFMLEFJNJNE> NELFGOEGFAF(IEnumerable<ONHIOBCOPCO>? IHDEPNIBDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3C25ED0", Offset = "0x3C24AD0", VA = "0x183C25ED0")]
	internal static string KLIJALHMMPA<TModern>(TModern HOKNBAKODNG, KAOCIBDKDIB<TModern> NLLEAJNAJCM, MBDBKJKILHH LOAKGGDNOOO) where TModern : CIMNPCOKFON
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class PJEECDCGIME : CHCDLCMFGOO
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NCPCEKKCPEN<OBEDBJJCGJB, DNHFACAJPBE> JHNPKHDECHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NCPCEKKCPEN<ANJEECOKPKB, JCFOCGDGHJD> CIEJLIMALKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public NCPCEKKCPEN<ANJEECOKPKB, JCFOCGDGHJD> ACPGOGBMNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NBAJPDMOAJO AKCGKMEOEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DABNGJKGEKJ AADEODCCKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7FB53B0", Offset = "0x7FB3FB0", VA = "0x187FB53B0")]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	[UsedImplicitly]
	internal static void GNDDLPOIOFL(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5420", Offset = "0x7FB4020", VA = "0x187FB5420")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PJEECDCGIME([HAKCNCGPHPD("UnitySerialization")] OAAANDKDOCL DPEGAJNPCIP, [HAKCNCGPHPD(null)] NJGPDEOPNKH GLIBLGGAABI, [HAKCNCGPHPD(null)] MBDBKJKILHH LOAKGGDNOOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum PEPCEHHBPOI
{
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DLJDPKMODLD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF6B0", Offset = "0x7FAE2B0", VA = "0x187FAF6B0")]
	public DLJDPKMODLD(string HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF750", Offset = "0x7FAE350", VA = "0x187FAF750")]
	public DLJDPKMODLD(string HLMEMBFCHLD, Exception BOEANKIKAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF720", Offset = "0x7FAE320", VA = "0x187FAF720")]
	public DLJDPKMODLD(PEPCEHHBPOI IOMJLDCPLFD, string HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7FAF6E0", Offset = "0x7FAE2E0", VA = "0x187FAF6E0")]
	public DLJDPKMODLD(PEPCEHHBPOI IOMJLDCPLFD, string HLMEMBFCHLD, Exception BOEANKIKAPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class JEHPGKBGEKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly OAAANDKDOCL DPEGAJNPCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly NJGPDEOPNKH GLIBLGGAABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly MBDBKJKILHH LOAKGGDNOOO;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA950", Offset = "0x7FA9550", VA = "0x187FAA950")]
	protected JEHPGKBGEKP(OAAANDKDOCL DPEGAJNPCIP, NJGPDEOPNKH GLIBLGGAABI, MBDBKJKILHH LOAKGGDNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3210", Offset = "0x7FB1E10", VA = "0x187FB3210")]
	protected string AKLFLOHCJDC(DNHFACAJPBE LBEKEMPAKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4520", Offset = "0x7FB3120", VA = "0x187FB4520")]
	protected string ICPCFDOPCDM(DNHFACAJPBE LBEKEMPAKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4840", Offset = "0x7FB3440", VA = "0x187FB4840")]
	private AvatarOutfitSelectionData LCMFBCCHPDC(MDGPBLDMAEH KGKNJFAJPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7FB4700", Offset = "0x7FB3300", VA = "0x187FB4700")]
	private static AvatarCustomizationSettingsData.AnchorParams IOGLCOCDGMH(PBOEGNLEBIG? KOHBJCLJEFM)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NCPCEKKCPEN<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput GLDNKJDIMCO(TInput HOKNBAKODNG, [Out] IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ACCHANHOAOK(TInput HOKNBAKODNG, [Out] TOutput? ABEFNIJCBBN, [Out] IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CHCDLCMFGOO
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NCPCEKKCPEN<OBEDBJJCGJB, DNHFACAJPBE> JHNPKHDECHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	NCPCEKKCPEN<ANJEECOKPKB, JCFOCGDGHJD> ACPGOGBMNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NBAJPDMOAJO AKCGKMEOEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum LIMHGBOGOKL
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DABNGJKGEKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EOHFCLGAGGE PBHGMJKEMBG(DNHFACAJPBE CBCNBAPLLJM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NBAJPDMOAJO
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANJEECOKPKB PBHGMJKEMBG(DNHFACAJPBE CBCNBAPLLJM, int BLCEDCKLLLI, string? BKILENEPEEB, string? LDBFFGHOJNM, MMGGFMEPBPM HEMBOCGAKIC, List<IFMLEFJNJNE>? ONFOJPOCPDF);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[GOLNKMGDHKC]
internal class FPELBLEGOKA : LIHMGNPFKJP<OBEDBJJCGJB, DNHFACAJPBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly NJGPDEOPNKH GLIBLGGAABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly CAHGOGBOLGI BMENNJHNLHO;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0710", Offset = "0x7FAF310", VA = "0x187FB0710")]
	public FPELBLEGOKA(OAAANDKDOCL DPEGAJNPCIP, NJGPDEOPNKH GLIBLGGAABI, MBDBKJKILHH LOAKGGDNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0460", Offset = "0x7FAF060", VA = "0x187FB0460", Slot = "6")]
	public override DNHFACAJPBE GLDNKJDIMCO(OBEDBJJCGJB HOKNBAKODNG, [Out] IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class GGFPLECMOGK : OAAANDKDOCL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class CAEBICNLAAF : JsonConverter<NMAPCHCCICP>
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7FABD20", Offset = "0x7FAA920", VA = "0x187FABD20", Slot = "9")]
		public override void WriteJson(JsonWriter HDDCOPOMJML, NMAPCHCCICP? BKMPCFIAHIG, JsonSerializer JKAPPJFLKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7FABC00", Offset = "0x7FAA800", VA = "0x187FABC00", Slot = "10")]
		public override NMAPCHCCICP ReadJson(JsonReader NOIAIJBDKGG, Type JGFNGJHIJOE, NMAPCHCCICP? ABLHOHBPANP, bool OBHCPOOPKLI, JsonSerializer JKAPPJFLKGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7FABDC0", Offset = "0x7FAA9C0", VA = "0x187FABDC0")]
		public CAEBICNLAAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class DGJJENBIEGD : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool NPOADHODIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7FAF570", Offset = "0x7FAE170", VA = "0x187FAF570", Slot = "5")]
		public override object ReadJson(JsonReader NOIAIJBDKGG, Type JGFNGJHIJOE, object? ABLHOHBPANP, JsonSerializer JKAPPJFLKGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7FAF190", Offset = "0x7FADD90", VA = "0x187FAF190", Slot = "6")]
		public override bool CanConvert(Type JGFNGJHIJOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7FAF5D0", Offset = "0x7FAE1D0", VA = "0x187FAF5D0", Slot = "4")]
		public override void WriteJson(JsonWriter HDDCOPOMJML, object? BKMPCFIAHIG, JsonSerializer JKAPPJFLKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7FAF370", Offset = "0x7FADF70", VA = "0x187FAF370")]
		private static bool FDBMCPPKAJA(object BKMPCFIAHIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public DGJJENBIEGD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JsonSerializerSettings DKFCHCGNBIM;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7FB08E0", Offset = "0x7FAF4E0", VA = "0x187FB08E0")]
	internal GGFPLECMOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3C44E10", Offset = "0x3C43A10", VA = "0x183C44E10", Slot = "4")]
	public string FAKEJBDAIEJ<T>(T KOJLNGLNBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3C44E70", Offset = "0x3C43A70", VA = "0x183C44E70", Slot = "5")]
	public T MGCHINMCCPD<T>(string BKMPCFIAHIG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class CCNLCFOIJEJ : OAAANDKDOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3A310C0", Offset = "0x3A2FCC0", VA = "0x183A310C0", Slot = "4")]
	public string FAKEJBDAIEJ<T>(T KOJLNGLNBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3A31120", Offset = "0x3A2FD20", VA = "0x183A31120", Slot = "5")]
	public T MGCHINMCCPD<T>(string BKMPCFIAHIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public CCNLCFOIJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GOLNKMGDHKC]
internal class CAHGOGBOLGI : LIHMGNPFKJP<ANJEECOKPKB, JCFOCGDGHJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly OAAANDKDOCL DPEGAJNPCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly NJGPDEOPNKH GLIBLGGAABI;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7FAE290", Offset = "0x7FACE90", VA = "0x187FAE290")]
	public CAHGOGBOLGI(OAAANDKDOCL DPEGAJNPCIP, NJGPDEOPNKH GLIBLGGAABI, MBDBKJKILHH LOAKGGDNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC010", Offset = "0x7FAAC10", VA = "0x187FAC010", Slot = "6")]
	public override JCFOCGDGHJD GLDNKJDIMCO(ANJEECOKPKB HOKNBAKODNG, [Out] IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7FACDB0", Offset = "0x7FAB9B0", VA = "0x187FACDB0")]
	internal void MOKECEIKHMI(string PCOCEFAJGAG, DNHFACAJPBE LBEKEMPAKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7FABE00", Offset = "0x7FAAA00", VA = "0x187FABE00")]
	public IEnumerable<MDGPBLDMAEH> BAFKIKKACJA(string LECKBLPMCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD5C0", Offset = "0x7FAC1C0", VA = "0x187FAD5C0")]
	private IEnumerable<MDGPBLDMAEH> OAFLPKAOCCA(string LECKBLPMCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC440", Offset = "0x7FAB040", VA = "0x187FAC440")]
	internal IEnumerable<MDGPBLDMAEH> GPJOLFDNOLJ(string LECKBLPMCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD230", Offset = "0x7FABE30", VA = "0x187FAD230")]
	private MDGPBLDMAEH NIKMLAADANO(AvatarOutfitSelectionData GMIAEJAMGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7FAD9F0", Offset = "0x7FAC5F0", VA = "0x187FAD9F0")]
	private void OKOPLOKHIJB(AvatarCustomizationSettingsData CAPDMPOKLFL, DNHFACAJPBE LBEKEMPAKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7FACF10", Offset = "0x7FABB10", VA = "0x187FACF10")]
	private MDGPBLDMAEH NIKMLAADANO(string OEBKGEGLMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7FACAB0", Offset = "0x7FAB6B0", VA = "0x187FACAB0")]
	internal static (FMEODGEFBMO, string, string) KAPFLAEDAHA(string OEBKGEGLMEL, MBDBKJKILHH LOAKGGDNOOO)
	{
		return default((FMEODGEFBMO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7FAC8B0", Offset = "0x7FAB4B0", VA = "0x187FAC8B0")]
	private BLBNDIFNKIB? HJAIALIGNGP(string? FHNOHJCOOKK, Vector2 INBAHEOIMPP, float JHIOFLALIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7FABEB0", Offset = "0x7FAAAB0", VA = "0x187FABEB0")]
	private static PBOEGNLEBIG BCEEDKOIBHL(AvatarCustomizationSettingsData.AnchorParams FHNGCFDNOMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[GOLNKMGDHKC]
internal class AMAMJEEIGAI : JEHPGKBGEKP, DABNGJKGEKJ
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA950", Offset = "0x7FA9550", VA = "0x187FAA950")]
	public AMAMJEEIGAI(OAAANDKDOCL DPEGAJNPCIP, NJGPDEOPNKH GLIBLGGAABI, MBDBKJKILHH LOAKGGDNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA5A0", Offset = "0x7FA91A0", VA = "0x187FAA5A0", Slot = "4")]
	public EOHFCLGAGGE PBHGMJKEMBG(DNHFACAJPBE CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA260", Offset = "0x7FA8E60", VA = "0x187FAA260")]
	private string HCEIFFCHKBH(DNHFACAJPBE LBEKEMPAKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7FAA360", Offset = "0x7FA8F60", VA = "0x187FAA360")]
	private string MEDIAHGFHLH(MDGPBLDMAEH KGKNJFAJPCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GOLNKMGDHKC]
internal class FKIPBCPBMBC : LIHMGNPFKJP<ANJEECOKPKB, JCFOCGDGHJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly OAAANDKDOCL DPEGAJNPCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly NCPCEKKCPEN<ANJEECOKPKB, JCFOCGDGHJD> FHPGOFNJCKB;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0360", Offset = "0x7FAEF60", VA = "0x187FB0360")]
	public FKIPBCPBMBC(NCPCEKKCPEN<ANJEECOKPKB, JCFOCGDGHJD> FHPGOFNJCKB, MBDBKJKILHH LOAKGGDNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7FAFF30", Offset = "0x7FAEB30", VA = "0x187FAFF30", Slot = "6")]
	public override JCFOCGDGHJD GLDNKJDIMCO(ANJEECOKPKB HOKNBAKODNG, [Out] IReadOnlyList<IFMLEFJNJNE>? ONFOJPOCPDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[GOLNKMGDHKC]
internal class JDDLLOBKGKO : NBAJPDMOAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly OAAANDKDOCL DPEGAJNPCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly DABNGJKGEKJ NIBOLDIGMGO;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3120", Offset = "0x7FB1D20", VA = "0x187FB3120")]
	public JDDLLOBKGKO(DABNGJKGEKJ NIBOLDIGMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7FB2D80", Offset = "0x7FB1980", VA = "0x187FB2D80", Slot = "4")]
	public ANJEECOKPKB PBHGMJKEMBG(DNHFACAJPBE CBCNBAPLLJM, int BLCEDCKLLLI, string? BKILENEPEEB, string? LDBFFGHOJNM, MMGGFMEPBPM HEMBOCGAKIC, List<IFMLEFJNJNE>? ONFOJPOCPDF)
	{
		return null;
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7FAAB80", Offset = "0x7FA9780", VA = "0x187FAAB80")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GJCHCNFBFHB
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0AA0", Offset = "0x7FAF6A0", VA = "0x187FB0AA0")]
	public static KJEPDDGGDOL GLDNKJDIMCO(this HOEBGCLJNBN CBCNBAPLLJM)
	{
		return default(KJEPDDGGDOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0BB0", Offset = "0x7FAF7B0", VA = "0x187FB0BB0")]
	public static HOEBGCLJNBN PBHGMJKEMBG(this KJEPDDGGDOL LHELDJOCKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7FB0A40", Offset = "0x7FAF640", VA = "0x187FB0A40")]
	public static bool DEPBHLIAEON(this KJEPDDGGDOL LHELDJOCKIF)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x6028B90", Offset = "0x6027790", VA = "0x186028B90")]
			public AnchorParams(Vector2 FKIHMFAKHKG, Vector3 AOCFJJDJMOP, Vector3 HFEHNPHEJLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7FAAAD0", Offset = "0x7FA96D0", VA = "0x187FAAAD0")]
			internal PBOEGNLEBIG PBHGMJKEMBG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private LFBJHFHIBPH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x7FAB3B0", Offset = "0x7FA9FB0", VA = "0x187FAB3B0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x17F55B0", Offset = "0x17F41B0", VA = "0x1817F55B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xDD7020", Offset = "0xDD5C20", VA = "0x180DD7020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xF9EEB0", Offset = "0xF9DAB0", VA = "0x180F9EEB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x150C7A0", Offset = "0x150B3A0", VA = "0x18150C7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7FAB460", Offset = "0x7FAA060", VA = "0x187FAB460")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA681F0", Offset = "0xA66DF0", VA = "0x180A681F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15F40", VA = "0x180D17340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD175E0", Offset = "0xD161E0", VA = "0x180D175E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B550", Offset = "0xA5A150", VA = "0x180A5B550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7FAB4A0", Offset = "0x7FAA0A0", VA = "0x187FAB4A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xF64E50", Offset = "0xF63A50", VA = "0x180F64E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1205840", Offset = "0x1204440", VA = "0x181205840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x19998D0", Offset = "0x19984D0", VA = "0x1819998D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA633E0", Offset = "0xA61FE0", VA = "0x180A633E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA633D0", Offset = "0xA61FD0", VA = "0x180A633D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x253A800", Offset = "0x2539400", VA = "0x18253A800")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xF7F470", Offset = "0xF7E070", VA = "0x180F7F470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA944F0", Offset = "0xA930F0", VA = "0x180A944F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA94550", Offset = "0xA93150", VA = "0x180A94550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBE0", Offset = "0xA5D7E0", VA = "0x180A5EBE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA5EAC0", Offset = "0xA5D6C0", VA = "0x180A5EAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB40", Offset = "0xA5D740", VA = "0x180A5EB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB30", Offset = "0xA5D730", VA = "0x180A5EB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA70", Offset = "0xA5D670", VA = "0x180A5EA70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB70", Offset = "0xA5D770", VA = "0x180A5EB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xAC01F0", Offset = "0xABEDF0", VA = "0x180AC01F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xABDCF0", Offset = "0xABC8F0", VA = "0x180ABDCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB20", Offset = "0xA5D720", VA = "0x180A5EB20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB50", Offset = "0xA5D750", VA = "0x180A5EB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0610", Offset = "0xABF210", VA = "0x180AC0610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB0C9D0", Offset = "0xB0B5D0", VA = "0x180B0C9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA65BC0", Offset = "0xA647C0", VA = "0x180A65BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA65C30", Offset = "0xA64830", VA = "0x180A65C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB0CA10", Offset = "0xB0B610", VA = "0x180B0CA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB0CA60", Offset = "0xB0B660", VA = "0x180B0CA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xDB9E90", Offset = "0xDB8A90", VA = "0x180DB9E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xDB6DF0", Offset = "0xDB59F0", VA = "0x180DB6DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public LFBJHFHIBPH UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1024810", Offset = "0x1023410", VA = "0x181024810")]
			get
			{
				return default(LFBJHFHIBPH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1023E90", Offset = "0x1022A90", VA = "0x181023E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1023A10", Offset = "0x1022610", VA = "0x181023A10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xCE74F0", Offset = "0xCE60F0", VA = "0x180CE74F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FAB480", Offset = "0x7FAA080", VA = "0x187FAB480")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x7FAB4C0", Offset = "0x7FAA0C0", VA = "0x187FAB4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7FAB010", Offset = "0x7FA9C10", VA = "0x187FAB010")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public FMEODGEFBMO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private HJHOPKKPBNA? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7FAB4E0", Offset = "0x7FAA0E0", VA = "0x187FAB4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
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
