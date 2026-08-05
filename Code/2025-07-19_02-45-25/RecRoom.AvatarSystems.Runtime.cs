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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x801D7B0", Offset = "0x801C7B0", VA = "0x18801D7B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
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
		[Cpp2IlInjected.Address(RVA = "0x801D830", Offset = "0x801C830", VA = "0x18801D830", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NMAHPGPJLGN]
internal class BBBCIGKGNJP : HNGBAELJNFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct IOMGCGMFHCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public BBBCIGKGNJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NOKGHIEMFJK avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MEKBHEBHAEM LNNLNJHFIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IDCMDKHNCKM GLHFIGCJHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KELDEDMALLB BGMMAGLAOGG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFD40", Offset = "0x7FFED40", VA = "0x187FFFD40")]
	[GOMLKAICHII.NIENCEEHOCF.GHHMJPKJCIP]
	[UsedImplicitly]
	internal static void LMPDHEGBPAJ(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8000A50", Offset = "0x7FFFA50", VA = "0x188000A50")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BBBCIGKGNJP([KELEGLJPNHI(null)] MEKBHEBHAEM LNNLNJHFIHD, [KELEGLJPNHI(null)] IDCMDKHNCKM GLHFIGCJHEA, [KELEGLJPNHI(null)] KELDEDMALLB BGMMAGLAOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF470", Offset = "0x7FFE470", VA = "0x187FFF470", Slot = "5")]
	public KLFIFDMNKOJ KIDDPCCNODC(NOKGHIEMFJK IEAPGKOBGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFE40", Offset = "0x7FFEE40", VA = "0x187FFFE40", Slot = "4")]
	public KLFIFDMNKOJ PFPPIKFEPAC(NOKGHIEMFJK IEAPGKOBGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8000940", Offset = "0x7FFF940", VA = "0x188000940", Slot = "6")]
	public KPPNBDELPNB PLGDKIMMPNM(KLFIFDMNKOJ INCJDDLACNP, int GBBHBDCDACM, string? HJLBILHBIIC, string? CNGJOGOIPJG, KLKIFENPGNG MMHONOGNHPO, List<KIENMMJAMGO>? OEDKMLBBBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF3E0", Offset = "0x7FFE3E0", VA = "0x187FFF3E0", Slot = "7")]
	public bool IFEOBNKPDKL(ACGMLLCPLIA NEKIAAMBBBA, [Out] KLFIFDMNKOJ? FMHHPPLDGPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF150", Offset = "0x7FFE150", VA = "0x187FFF150", Slot = "8")]
	public bool FCIMCPOALPE(KPPNBDELPNB HNMMFMMKIFG, [Out] KLFIFDMNKOJ? FMHHPPLDGPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFDB0", Offset = "0x7FFEDB0", VA = "0x187FFFDB0", Slot = "9")]
	public bool OHOBEAJMAMK(KPPNBDELPNB HNMMFMMKIFG, [Out] CAAACECPOLP? NEKIAAMBBBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x39D0870", Offset = "0x39CF870", VA = "0x1839D0870")]
	private bool LBPIHNHMENG<TInput, TOutput>(TInput JMJJABEKOFI, BPCANCNOMJG<TInput, TOutput> KNIOKPDNBPB, [Out] TOutput? BGOCMPMGKKI) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF230", Offset = "0x7FFE230", VA = "0x187FFF230")]
	[CompilerGenerated]
	private OKJNCKGHGLM HOJIMBEGMKA(FaceFeatureType HNLPFAFEGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FFEF70", Offset = "0x7FFDF70", VA = "0x187FFEF70")]
	[CompilerGenerated]
	private OKJNCKGHGLM DLGMHANGGHK(FaceFeatureType HNLPFAFEGCJ, IOMGCGMFHCC P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NMAHPGPJLGN]
internal class NEEFLLJEINC : MEKBHEBHAEM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void PLMLBKLGKPM<in TData>(TData FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HPLEMPHNDFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public DBNAACPFFGA rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public PPLJPGHLHIG currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public PPLJPGHLHIG latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HPLEMPHNDFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x801B470", Offset = "0x801A470", VA = "0x18801B470")]
		internal bool KJMMILJNOPD(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x801B3F0", Offset = "0x801A3F0", VA = "0x18801B3F0")]
		internal bool AEIALPKJGKB(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KELDEDMALLB BGMMAGLAOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PFDLEOBDONH CHJCOCHCMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PLMLBKLGKPM<KLFIFDMNKOJ>?[] LNNLNJHFIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PLMLBKLGKPM<CAAACECPOLP>?[] KECGIMHBDAI;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x801CCA0", Offset = "0x801BCA0", VA = "0x18801CCA0")]
	[GOMLKAICHII.NIENCEEHOCF.GHHMJPKJCIP]
	[UsedImplicitly]
	internal static void LMPDHEGBPAJ(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x801D0A0", Offset = "0x801C0A0", VA = "0x18801D0A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NEEFLLJEINC([KELEGLJPNHI(null)] KELDEDMALLB BGMMAGLAOGG, [KELEGLJPNHI(null)] PFDLEOBDONH CHJCOCHCMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x801B5F0", Offset = "0x801A5F0", VA = "0x18801B5F0", Slot = "4")]
	public bool AFAHAHDMGIB(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x801B490", Offset = "0x801A490", VA = "0x18801B490", Slot = "5")]
	public bool AFAHAHDMGIB(CAAACECPOLP NEKIAAMBBBA, IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x801BC30", Offset = "0x801AC30", VA = "0x18801BC30")]
	private void BKJNCBLNLKD(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x801B6F0", Offset = "0x801A6F0", VA = "0x18801B6F0")]
	private void AOBNNAMMCBD(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x801BC00", Offset = "0x801AC00", VA = "0x18801BC00")]
	private void BJKEBMKFOBE(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x801CB10", Offset = "0x801BB10", VA = "0x18801CB10")]
	private void KBLMFOOHGGG(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x801C830", Offset = "0x801B830", VA = "0x18801C830")]
	private void CNDAGFPFONM(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x801CB70", Offset = "0x801BB70", VA = "0x18801CB70")]
	private void KMKMGHDMHAE(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x801CD10", Offset = "0x801BD10", VA = "0x18801CD10")]
	private void LNGCNBEMAPG(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x801C820", Offset = "0x801B820", VA = "0x18801C820")]
	private void CEBKDANBCGN(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x801CB40", Offset = "0x801BB40", VA = "0x18801CB40")]
	private void KDNAACBLHBL(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x801CC20", Offset = "0x801BC20", VA = "0x18801CC20")]
	private void LMLIBFLJGFE(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? CIABMLDDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x801B920", Offset = "0x801A920", VA = "0x18801B920")]
	private void APJKGCLGCFF(KLFIFDMNKOJ FMHHPPLDGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x801CDC0", Offset = "0x801BDC0", VA = "0x18801CDC0")]
	private KLFIFDMNKOJ PMEBAPHLPAF(KLFIFDMNKOJ FMHHPPLDGPC, List<RangeMigration> LADDJFLMKDM, PPLJPGHLHIG KPABNJLGBMN, PPLJPGHLHIG CPDOMFLGGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x801C900", Offset = "0x801B900", VA = "0x18801C900")]
	private float EPAHMMCHNLA(float MFIGIHGBOOK, Vector2 CGEJPBMBMID, Vector2 JLLEDABOGKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x801C940", Offset = "0x801B940", VA = "0x18801C940")]
	private (RangeMigration?, RangeMigration?) HPLNJHFMMEP(List<RangeMigration> OBKLIECLPIE, DBNAACPFFGA OBKOLKMOGBG, PPLJPGHLHIG KPABNJLGBMN, PPLJPGHLHIG CPDOMFLGGHK)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MEKBHEBHAEM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFAHAHDMGIB(KLFIFDMNKOJ FMHHPPLDGPC, IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AFAHAHDMGIB(CAAACECPOLP NEKIAAMBBBA, IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA);
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
		public JBPODEMKBHO AnimationPoseType;

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

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCA10", Offset = "0x7FFBA10", VA = "0x187FFCA10")]
		public void JLAKKNJEDJN(AnimationPoseSetting EDJHHGMLKFA, float JCHBLFNDHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCB40", Offset = "0x7FFBB40", VA = "0x187FFCB40")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
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

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD450", Offset = "0x7FFC450", VA = "0x187FFD450")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD410", Offset = "0x7FFC410", VA = "0x187FFD410")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7FFCB60", Offset = "0x7FFBB60", VA = "0x187FFCB60")]
		private void DLOLLHKJLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F88410", Offset = "0x7F87410", VA = "0x187F88410", Slot = "4")]
		public void SetEnabled(bool OPEAEGJENDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD480", Offset = "0x7FFC480", VA = "0x187FFD480")]
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

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD4C0", Offset = "0x7FFC4C0", VA = "0x187FFD4C0")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		[Header("Turning")]
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
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
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
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
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
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
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
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
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
		[Header("Seated animation settings")]
		[Tooltip("How much to twist shoulders when seated.")]
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
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
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
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
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

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD500", Offset = "0x7FFC500", VA = "0x187FFD500")]
		public AnimationPoseSetting AOLOEGGFNCA(JBPODEMKBHO FGKPLHABGOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD530", Offset = "0x7FFC530", VA = "0x187FFD530")]
		public void LMCEEELLBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD570", Offset = "0x7FFC570", VA = "0x187FFD570")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum FAEHCPEDHNL
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private FAEHCPEDHNL handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		[FormerlySerializedAs("color")]
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

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE080", Offset = "0x7FFD080", VA = "0x187FFE080")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE040", Offset = "0x7FFD040", VA = "0x187FFE040")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FFDA20", Offset = "0x7FFCA20", VA = "0x187FFDA20")]
		private void DLOLLHKJLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F88410", Offset = "0x7F87410", VA = "0x187F88410", Slot = "4")]
		public void SetEnabled(bool OPEAEGJENDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE0B0", Offset = "0x7FFD0B0", VA = "0x187FFE0B0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, IHOBDFEMEHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private NOKGHIEMFJK avatarBodyType;

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
		[COPMMNAHICH(KDIHEPCABNF.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Header("Configuration")]
		[SerializeField]
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
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
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
		[SerializeField]
		[Header("Arm Animation Controllers")]
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
		[SerializeField]
		[Header("Facial Animation")]
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
		private CFMKHFLAMBH JFOKKCBEGCF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CFMKHFLAMBH EHFCABFOPKA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xBCCB80", Offset = "0xBCBB80", VA = "0x180BCCB80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform EELELAKHJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7FFEF50", Offset = "0x7FFDF50", VA = "0x187FFEF50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE0E0", Offset = "0x7FFD0E0", VA = "0x187FFE0E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FFEE10", Offset = "0x7FFDE10", VA = "0x187FFEE10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FFEDC0", Offset = "0x7FFDDC0", VA = "0x187FFEDC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7FFED50", Offset = "0x7FFDD50", VA = "0x187FFED50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE0E0", Offset = "0x7FFD0E0", VA = "0x187FFE0E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE520", Offset = "0x7FFD520", VA = "0x187FFE520", Slot = "6")]
		public CFMKHFLAMBH CreateAvatarSystem(string AIAMGPOLAFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7FFED50", Offset = "0x7FFDD50", VA = "0x187FFED50", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE1A0", Offset = "0x7FFD1A0", VA = "0x187FFE1A0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FFEE60", Offset = "0x7FFDE60", VA = "0x187FFEE60", Slot = "9")]
		public void UpdatePostIKAnimControllers(float PFFBKHOBAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class FELGNCGDEDJ : CFMKHFLAMBH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class NLJCBNMFLIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 ONJHDMBNBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion APLOPLAEBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 JNIACAJJHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Transform JLHOHDMBFNO;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 FIBLKOOCPMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x21A2A30", Offset = "0x21A1A30", VA = "0x1821A2A30")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x21A2A50", Offset = "0x21A1A50", VA = "0x1821A2A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion KEBAGJBMEMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x159F470", Offset = "0x159E470", VA = "0x18159F470")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x159F090", Offset = "0x159E090", VA = "0x18159F090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float AEOGDFMMGAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x122F4B0", Offset = "0x122E4B0", VA = "0x18122F4B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x19A2030", Offset = "0x19A1030", VA = "0x1819A2030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool JDIDFIINAHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA683F0", Offset = "0xA673F0", VA = "0x180A683F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA683C0", Offset = "0xA673C0", VA = "0x180A683C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool OEKLCLMPGDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA68460", Offset = "0xA67460", VA = "0x180A68460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA68430", Offset = "0xA67430", VA = "0x180A68430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool OFJKMFINKNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA68410", Offset = "0xA67410", VA = "0x180A68410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA68400", Offset = "0xA67400", VA = "0x180A68400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float AFCIMEAACBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xDB0980", Offset = "0xDAF980", VA = "0x180DB0980")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xDB1410", Offset = "0xDB0410", VA = "0x180DB1410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8027F60", Offset = "0x8026F60", VA = "0x188027F60")]
		public void HBJBINOEFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8027BB0", Offset = "0x8026BB0", VA = "0x188027BB0")]
		public void CMGHMIBEDNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x80279A0", Offset = "0x80269A0", VA = "0x1880279A0")]
		public float ACABEIMGENF(Vector3 FOCIFMGEFIF, Quaternion EMOKEBJMHEA, [In] AvatarFootSettings KPDJPMMBCBN, float CGKBDNGGIGD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8027F70", Offset = "0x8026F70", VA = "0x188027F70")]
		public void HHDKLKADPON(Vector3 AGNNCPFOLDG, Quaternion JEMPAEIAGHM, Transform CFLCECAKNCO, float CHKFHLDDNBF, bool KCPKHKGKCFM, bool JICFGPALPLG, float CDNKJBNHMEF, float KOAOKGCODFM, Transform NKBKNNLLHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8027D10", Offset = "0x8026D10", VA = "0x188027D10")]
		public void FGMNIGCKJNP(Transform HFLPEIIDOJN, Transform NKBKNNLLHKF, bool BKKMGDJDADH, bool FFIJOEIJBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8028650", Offset = "0x8027650", VA = "0x188028650")]
		private void PGKINGGOECK(Transform NKBKNNLLHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8027BC0", Offset = "0x8026BC0", VA = "0x188027BC0")]
		public bool FBMDIICGIOA(Transform NKBKNNLLHKF, AvatarFullBodyConfiguration ANJJOFOGAJP, Vector3 DCJGEDLFDPN, float DGJOCIGBLNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8027F40", Offset = "0x8026F40", VA = "0x188027F40")]
		public void GPNELHBNAKF(float KOAOKGCODFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8028750", Offset = "0x8027750", VA = "0x188028750")]
		public NLJCBNMFLIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class BPFOEBJFIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float MNIODBLIKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool MHFDHCJEAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AnimationPoseSetting BFFPKLJPPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private float AJICMDACNIK;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x80209B0", Offset = "0x801F9B0", VA = "0x1880209B0")]
		public void OMDIPLIIMEP(IKSolverVR.Arm KCMJOKLFIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x801FE10", Offset = "0x801EE10", VA = "0x18801FE10")]
		public void COLGIIIDPKF(IKSolverVR.Arm KCMJOKLFIBN, float GHJDOHBFLPF, bool MHFDHCJEAII, AvatarFullBodyConfiguration ANJJOFOGAJP, float PHKAANJAFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8020590", Offset = "0x801F590", VA = "0x188020590")]
		private void NGBEEPHGEJK(IKSolverVR.Arm KCMJOKLFIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x80205D0", Offset = "0x801F5D0", VA = "0x1880205D0")]
		public void NLFFDEJAAHG(IKSolverVR.Arm KCMJOKLFIBN, Transform KGLLNNIIBEL, Transform CFLCECAKNCO, Quaternion IBAAJJFOKHK, Vector3 PJHAJGHJDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x801F980", Offset = "0x801E980", VA = "0x18801F980")]
		private (Vector3, Quaternion) CDHHGAFIKDD(BKLFMGBIIDB MDHHJNIDJOP, Quaternion KLJBKOLHNGP, Vector3 ODNJOKGEHMN)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x80202F0", Offset = "0x801F2F0", VA = "0x1880202F0")]
		public void LHEOGAONAIE(BKLFMGBIIDB MDHHJNIDJOP, IKSolverVR.Arm KCMJOKLFIBN, Quaternion KLJBKOLHNGP, Vector3 ODNJOKGEHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x801F380", Offset = "0x801E380", VA = "0x18801F380")]
		public void BOANKFPIBLC(BKLFMGBIIDB MDHHJNIDJOP, IKSolverVR.Arm KCMJOKLFIBN, Quaternion KLJBKOLHNGP, Vector3 ODNJOKGEHMN, [In] AvatarFullBodyConfiguration ANJJOFOGAJP, [In] OAGFOODDIAO GICMHPOANOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8020450", Offset = "0x801F450", VA = "0x188020450")]
		public void MEJNGDIBNGA(JBPODEMKBHO NGHDPAIKLEA, AvatarFullBodyConfiguration ANJJOFOGAJP, OAGFOODDIAO GICMHPOANOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x801FE50", Offset = "0x801EE50", VA = "0x18801FE50")]
		public void HMFFHPIBPPB(IKSolverVR.Arm KCMJOKLFIBN, Transform KGLLNNIIBEL, Vector3 LBGMDMMHNFK, float MCLKIMBANAE, Quaternion JJCGDNJIJNA, Vector3 GHOEKLPMIMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x80209E0", Offset = "0x801F9E0", VA = "0x1880209E0")]
		public BPFOEBJFIDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum HIJLFIIMMBH
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
	private struct HEDMMFIPPGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HMEJFACFCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int GCOOGJDMHBJ;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int JKGICBHHHLJ;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int IKGGFKEGDKL;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int IIHEHBLAGIC;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int MGDLIFBLNOF;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int KIJLMNJANFC;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int AIBNHCBOKLE;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int PHKPDPEGOBF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int CAKJLIFLDKD;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JNPGNJAAALB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int PEMNBPINLNL;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int PJOPEOGMEND;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int KNPOHJICMEE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int KGHKIFCAIIJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int KHIKEIKOENO;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int CEJBFKCCMEO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int EHNDMKFBMPF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int OIMMKMACDPF;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int DBPKIFAOFAM;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int OBAALJELMHA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int CFNAKHOGLDO;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int HIDEFIPEJGC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int DCKAGIECNCL;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int DLBPGPHNJLF;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int BLKFCIBGLAO;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int CLFKHNCGFAH;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int AELFFAJDONH;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int MHMLNNDNDAA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int BOEENNLFFID;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int NEANMOLFCNP;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int OIIDOIBGCBB;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int AOJGCLBPIMG;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 CJIBGEJAJLB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int CLFIJDHNBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool EGOBJOPAPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool DAHBPCFMKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ICCBEMGKFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool HBFJEDBOLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool HBKBJKICHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool IOLOPCMNGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 BKLINGCCEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string GDLDJIKAGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private ALMNPPADNPC? DBFEJANLMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private OPIFGMIGBGG? GGKFPIDBOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private AGEDNKOPNGF EDBNNDGMEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private OHHINBPGLJI AHPCMMKMHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private BKLFMGBIIDB BBGDFBJECFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private BKLFMGBIIDB EPCACKMHOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool LENIEPJFHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool AHBPOCKNDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly JKGLEECOMGM FLBEPMHJBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly KALDFMKHAJK PNIOKCCJPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int DMPCDIDJIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float CNHFIFCLFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject KKKNHMPJMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform LGFGLKMHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform CLEAHLBDMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform KKIPDCFEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform BAOPDHKDDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float LIBMNJPGGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float JIAKNDLPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 CHJLNKPPAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion JKAKGCPBHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform OCNJMJPBCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform EJFPPDCOONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform BPKBGLAJDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private LIJBOMIEEMF MKGFFMPNLJL;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker AFNNBLJDFFG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker EPEHLMIDFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker EMOHDKFDKED;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker KILOKJDPLHE;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker NHEKAIFJIDI;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker BAKIHCKBGEG;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<FELGNCGDEDJ> KLKGDAILJFB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int DEPICBJOMAF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> EAJNFOGGNLD;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int JPEHIOPELJN;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int PLECOCHALAA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int BEOGEHDKCLJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int LJOKCJKBABI;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float NLMCDACNPAL;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int IINNBACPHMH;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float LEKIKBPMEEP;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float KCNLKDDCFPB;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float AODMPMFDFDM;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float DKBMFPHJFII;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static NBAFLNNOBHC PHLEJNNPPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float LDEAJBIJHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool JFPJKCAFJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float GAMDELCFGEF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int HIKIBGNIGHL;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int KMFPAFKFHOH;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int KCFGKHMNHJL;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int EPKIPOKBIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NLJCBNMFLIH OGECKAILFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NLJCBNMFLIH EMAPHOKBPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float HBJCDPIMJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 LNLGBECEKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 MHAHOGMKPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool HCFLGGJKGIK;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion HCFDGLFDDPD;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion AFFPHKEGOAK;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 NKCPHCIAPLJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 FIEJAMFJJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float NMDPANJABGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float EEPBBKGFDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private BPFOEBJFIDM EMJGEGECKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private BPFOEBJFIDM JNNLNFCNLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private BCPPGEMKLKN BOIMDDFLHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private LJPIAHCKMIG BDICANAFDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly LHAMKNDBOLF NKMIKAHANPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float HPGILKPCFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float BIEFBCLOMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly LJPIAHCKMIG NGIOMMKMCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 MCFBLLONBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 NODFBCAKGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float NEGOBAEAHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float DPCOBELBGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly LJPIAHCKMIG CCMHHFCMKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly BCPPGEMKLKN GIPGLFLKNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly LJPIAHCKMIG CEPKDOHGDAM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LELKCPPPMEI DBCBJLEMCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LELKCPPPMEI DGAPFODBELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration JCEKOCBIJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8015420", Offset = "0x8014420", VA = "0x188015420", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NOKGHIEMFJK HNFIPMLFCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x800BC50", Offset = "0x800AC50", VA = "0x18800BC50", Slot = "24")]
		get
		{
			return default(NOKGHIEMFJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration NNDNFEEMNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8005010", Offset = "0x8004010", VA = "0x188005010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform AHIMPCMMEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x800C1D0", Offset = "0x800B1D0", VA = "0x18800C1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform KKFACNIGBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x800ABB0", Offset = "0x8009BB0", VA = "0x18800ABB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer NGPNBGMIFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8003AD0", Offset = "0x8002AD0", VA = "0x188003AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] AGEHGGKMPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x80173C0", Offset = "0x80163C0", VA = "0x1880173C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] ODEAHOMJFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x800FEE0", Offset = "0x800EEE0", VA = "0x18800FEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator EDNOMCHEEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8017FB0", Offset = "0x8016FB0", VA = "0x188017FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK JLMEOCPJMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8016070", Offset = "0x8015070", VA = "0x188016070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private BHHGJJDGPBM IFHEFEMLMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8015EA0", Offset = "0x8014EA0", VA = "0x188015EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private BHHGJJDGPBM GPEIGCOJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8007480", Offset = "0x8006480", VA = "0x188007480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private BHHGJJDGPBM GPPLBDMMNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8011460", Offset = "0x8010460", VA = "0x188011460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private BHHGJJDGPBM CEHMHNHMNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x800FDE0", Offset = "0x800EDE0", VA = "0x18800FDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private BHHGJJDGPBM HLBKNIMEEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8016170", Offset = "0x8015170", VA = "0x188016170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private BHHGJJDGPBM GONDGMJPGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x80011A0", Offset = "0x80001A0", VA = "0x1880011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private BHHGJJDGPBM EFNFHBPDNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8001A60", Offset = "0x8000A60", VA = "0x188001A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private BHHGJJDGPBM BFHCBGBNCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8003880", Offset = "0x8002880", VA = "0x188003880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OPIFGMIGBGG NBGKFBPABBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8001EC0", Offset = "0x8000EC0", VA = "0x188001EC0", Slot = "16")]
		get
		{
			return default(OPIFGMIGBGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DBKAMJMIKIH BKEELPLNEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB58E90", Offset = "0xB57E90", VA = "0x180B58E90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PLOEHKAEILB NNOLPDMMCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB58E80", Offset = "0xB57E80", VA = "0x180B58E80", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CJMKPNNMLPB AELCANFJJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBD2AA0", Offset = "0xBD1AA0", VA = "0x180BD2AA0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CJMKPNNMLPB CLMEFFBDPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB59110", Offset = "0xB58110", VA = "0x180B59110", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string HKANNBMMEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform OFFLFLILKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8004FC0", Offset = "0x8003FC0", VA = "0x188004FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform LMOEKLBFJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80122E0", Offset = "0x80112E0", VA = "0x1880122E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform FNDMCICBHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x80120B0", Offset = "0x80110B0", VA = "0x1880120B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform BDAPJEMOMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8019570", Offset = "0x8018570", VA = "0x188019570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform BLNCOLIPGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x80120E0", Offset = "0x80110E0", VA = "0x1880120E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool FPCNGDJIDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x800FD10", Offset = "0x800ED10", VA = "0x18800FD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool EPJDIKMCCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x800FD10", Offset = "0x800ED10", VA = "0x18800FD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool LNKNOMJIBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8014FB0", Offset = "0x8013FB0", VA = "0x188014FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform NGANMCENHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x800A0A0", Offset = "0x80090A0", VA = "0x18800A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject GLGAAAMILBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8016270", Offset = "0x8015270", VA = "0x188016270", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets LMHHFJBJEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8019790", Offset = "0x8018790", VA = "0x188019790", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform COBAHANGJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBD3410", Offset = "0xBD2410", VA = "0x180BD3410", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform BJABKIHOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBD29A0", Offset = "0xBD19A0", VA = "0x180BD29A0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform HAOPBIKBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xBC00A0", Offset = "0xBBF0A0", VA = "0x180BC00A0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform CIBLPOGNDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAD7530", Offset = "0xAD6530", VA = "0x180AD7530", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 PMHOAFKIDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8005790", Offset = "0x8004790", VA = "0x188005790", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float LDFPLJKBPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x800A9C0", Offset = "0x80099C0", VA = "0x18800A9C0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform BIOBGBBOBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8012280", Offset = "0x8011280", VA = "0x188012280", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform NNAGJOFEOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE143E0", Offset = "0xE133E0", VA = "0x180E143E0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform JJBMLPLODEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x157EC70", Offset = "0x157DC70", VA = "0x18157EC70", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform MGHJEDEJCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAD7D40", Offset = "0xAD6D40", VA = "0x180AD7D40", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool AEDFDPGMHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x800C0E0", Offset = "0x800B0E0", VA = "0x18800C0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FHLIAIDPCMK<CFMKHFLAMBH.IPPCBAPCAAB> DCPOFPOAICI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x109AD10", Offset = "0x1099D10", VA = "0x18109AD10", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool FGDNEABNKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x80113E0", Offset = "0x80103E0", VA = "0x1880113E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool BACFDBLIBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8017990", Offset = "0x8016990", VA = "0x188017990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80025D0", Offset = "0x80015D0", VA = "0x1880025D0")]
	private float AOMPPELHLJF(LAJKLJFEMAM FFMAOLMIIFL, float BEDNHJPCDJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x800C450", Offset = "0x800B450", VA = "0x18800C450")]
	private void HLIGPDENIKP([In] OAGFOODDIAO BCBGGOBDICL, [In] AvatarFullBodyConfiguration ANJJOFOGAJP, bool MAEHAILHPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x800E730", Offset = "0x800D730", VA = "0x18800E730")]
	private float HNAJFLAIBED([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8009F70", Offset = "0x8008F70", VA = "0x188009F70")]
	private float DNMOABHCIDP([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x800B620", Offset = "0x800A620", VA = "0x18800B620")]
	private void HALLDLNKCAD(OAGFOODDIAO BCBGGOBDICL, AvatarFullBodyConfiguration ANJJOFOGAJP, bool MAEHAILHPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8003490", Offset = "0x8002490", VA = "0x188003490")]
	private void BHICJIBNDCM([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x800A1A0", Offset = "0x80091A0", VA = "0x18800A1A0")]
	private void EAMDPCAEEGJ([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x801AEF0", Offset = "0x8019EF0", VA = "0x18801AEF0")]
	public FELGNCGDEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8003F10", Offset = "0x8002F10", VA = "0x188003F10", Slot = "13")]
	public void BOPKJANMOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8010940", Offset = "0x800F940", VA = "0x188010940", Slot = "14")]
	public void JFMCHMFNGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x80172F0", Offset = "0x80162F0", VA = "0x1880172F0", Slot = "15")]
	public void NNEMIKPPCBP(bool HOKOHCKMBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8003170", Offset = "0x8002170", VA = "0x188003170", Slot = "26")]
	public Transform BCKOGJCEHIM(string BMDKEGJEJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x800B030", Offset = "0x800A030", VA = "0x18800B030", Slot = "27")]
	public Vector3? GIABOKENBMO(string BMDKEGJEJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8017CA0", Offset = "0x8016CA0", VA = "0x188017CA0", Slot = "7")]
	public void ODAFPFMCNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8018A50", Offset = "0x8017A50", VA = "0x188018A50")]
	private void PBIJCGJEMHL(AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x800ADA0", Offset = "0x8009DA0", VA = "0x18800ADA0", Slot = "8")]
	public void GDPGCAPAOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8001BB0", Offset = "0x8000BB0", VA = "0x188001BB0")]
	private void AKCHEICADHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8017810", Offset = "0x8016810", VA = "0x188017810")]
	private Vector3 OAGNCPBMBOM([In] OAGFOODDIAO GICMHPOANOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8007580", Offset = "0x8006580", VA = "0x188007580", Slot = "6")]
	public void DCKCBKIFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8016B10", Offset = "0x8015B10", VA = "0x188016B10")]
	private void NMPONGCKADK(bool MAEHAILHPBL, HIJLFIIMMBH ACOFJIEOJEH, AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8017F40", Offset = "0x8016F40", VA = "0x188017F40", Slot = "9")]
	public void ODEIKDLNMFC(float PGJIBBNFMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x800AD50", Offset = "0x8009D50", VA = "0x18800AD50")]
	private void FONGHEJGEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8007770", Offset = "0x8006770", VA = "0x188007770", Slot = "4")]
	public void DDMFPIBNFPB(string AIAMGPOLAFO, ALMNPPADNPC NJIHKICNLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80182E0", Offset = "0x80172E0", VA = "0x1880182E0", Slot = "5")]
	public void OMGCEKMGEHI(OPIFGMIGBGG FLKAGOEDHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8012120", Offset = "0x8011120", VA = "0x188012120", Slot = "12")]
	public void KENCGLNGFKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x800BD50", Offset = "0x800AD50", VA = "0x18800BD50", Slot = "25")]
	public void HFEEMMPPPGH([Out] Vector3 INDPOOHBPAJ, [Out] Quaternion JJCGDNJIJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x800A4B0", Offset = "0x80094B0", VA = "0x18800A4B0")]
	private void EECHAOBAEKG([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80190D0", Offset = "0x80180D0", VA = "0x1880190D0", Slot = "28")]
	public void PCDMONOCNFC(float BCBLCKMPKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x80150A0", Offset = "0x80140A0", VA = "0x1880150A0", Slot = "29")]
	public void LNOOEKICEMA(float KLPFPNDAIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x800AFE0", Offset = "0x8009FE0", VA = "0x18800AFE0", Slot = "46")]
	public void GFJKJMAMEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8001B60", Offset = "0x8000B60", VA = "0x188001B60", Slot = "30")]
	public void AHHBGJJHNIK(bool CLCPEIIPCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8013230", Offset = "0x8012230", VA = "0x188013230", Slot = "31")]
	public HandLogicOffsets KNKIJLFANJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8011560", Offset = "0x8010560", VA = "0x188011560", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets JJEHCLAMEMM()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x80153F0", Offset = "0x80143F0", VA = "0x1880153F0")]
	private void MGAONDBKLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x800BAD0", Offset = "0x800AAD0", VA = "0x18800BAD0")]
	private void HEJNEMLMJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8019130", Offset = "0x8018130", VA = "0x188019130")]
	private void PGELBHAFAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8013F30", Offset = "0x8012F30", VA = "0x188013F30")]
	private void LCDHPNEGNJG(EOEFLGKDFOB IFOIIIEDAMF, bool LPDEIPGKDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x800C2D0", Offset = "0x800B2D0", VA = "0x18800C2D0")]
	private void HKJFPADEDOH(EOEFLGKDFOB IFOIIIEDAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x800FFE0", Offset = "0x800EFE0", VA = "0x18800FFE0")]
	public Vector3 IOIHFHILLBC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x80050E0", Offset = "0x80040E0", VA = "0x1880050E0")]
	private void CPIAHOGOHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8001CB0", Offset = "0x8000CB0", VA = "0x188001CB0")]
	private void AKEPEBCGBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8011A00", Offset = "0x8010A00", VA = "0x188011A00")]
	private void JMLFHDIKEMM(OAGFOODDIAO BCBGGOBDICL, AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8016310", Offset = "0x8015310", VA = "0x188016310")]
	private float NILJHNHCJJB([In] OAGFOODDIAO GICMHPOANOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8011920", Offset = "0x8010920", VA = "0x188011920")]
	private int JKEBMCIFCOO([In] FEKFPDEPFDK EMHOPMPFNCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80048B0", Offset = "0x80038B0", VA = "0x1880048B0")]
	private void CEGKODAMELA(OAGFOODDIAO BCBGGOBDICL, bool LCLLPGCCBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80105D0", Offset = "0x800F5D0", VA = "0x1880105D0")]
	private static void JDOBCOPKLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x800E7F0", Offset = "0x800D7F0", VA = "0x18800E7F0")]
	private static void IDPNEECPJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8010400", Offset = "0x800F400", VA = "0x188010400")]
	private float JCKGEMFJGBE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x800E7C0", Offset = "0x800D7C0", VA = "0x18800E7C0")]
	private static int HNOKFGCLIHI(FELGNCGDEDJ AKPAAKDLPCB, FELGNCGDEDJ AIKJCCNDBKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8003980", Offset = "0x8002980", VA = "0x188003980", Slot = "41")]
	public OAGFOODDIAO BKLKPMFAHAF()
	{
		return default(OAGFOODDIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8003E60", Offset = "0x8002E60", VA = "0x188003E60")]
	private bool BOOHEDOBPML(int PBJHGGBBAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80180B0", Offset = "0x80170B0", VA = "0x1880180B0")]
	public void OIGFLIJOBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80195B0", Offset = "0x80185B0", VA = "0x1880195B0")]
	private (bool, bool) PIAENNLDMPE()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8004DE0", Offset = "0x8003DE0", VA = "0x188004DE0")]
	private (float, float) CEKMNHANKEE([In] OAGFOODDIAO GICMHPOANOB)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8005820", Offset = "0x8004820", VA = "0x188005820")]
	private void DBKLKMJCHNK([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x800B7B0", Offset = "0x800A7B0", VA = "0x18800B7B0")]
	private void HDCOHFEOMKM([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8000BD0", Offset = "0x7FFFBD0", VA = "0x188000BD0")]
	private void AAIHAELLDDK([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP, AvatarFootSettings KPDJPMMBCBN, bool MHALNLGPPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x800FD60", Offset = "0x800ED60", VA = "0x18800FD60")]
	private float ILKBKEOOHBE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x80025F0", Offset = "0x80015F0", VA = "0x1880025F0")]
	private void APCFDLDFHKJ(OAGFOODDIAO GICMHPOANOB, AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x80190E0", Offset = "0x80180E0", VA = "0x1880190E0")]
	private float PDIFGPPMPKP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80099A0", Offset = "0x80089A0", VA = "0x1880099A0")]
	private void DGOJBHDMPNK([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8016820", Offset = "0x8015820", VA = "0x188016820")]
	private void NLFFDEJAAHG([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8013B30", Offset = "0x8012B30", VA = "0x188013B30")]
	private void LBLICGAKLOJ([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x800A4E0", Offset = "0x80094E0", VA = "0x18800A4E0")]
	private void EKKGHMPIIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8014BD0", Offset = "0x8013BD0", VA = "0x188014BD0")]
	private void LDJJEACPJHF(float KMCEEICLLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x801A220", Offset = "0x8019220", VA = "0x18801A220")]
	private void POIOOPJPOIN([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8003BD0", Offset = "0x8002BD0", VA = "0x188003BD0")]
	private void BLKPHNFNADO(BKLFMGBIIDB FILAOOMILAA, IKSolverVR.Arm KCMJOKLFIBN, Transform NFNDDBJCFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8015520", Offset = "0x8014520", VA = "0x188015520")]
	private void MKKNHPBAPCE(OAGFOODDIAO GICMHPOANOB, AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80032C0", Offset = "0x80022C0", VA = "0x1880032C0")]
	private void BGOKHCNCEKF(PACFNBDHMMB HAFMGEAJAAG, CJMKPNNMLPB FILAOOMILAA, IKSolverVR.Arm KCMJOKLFIBN, float GHJDOHBFLPF, float MPOHDAEIKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x800A2A0", Offset = "0x80092A0", VA = "0x18800A2A0")]
	private void EBMOECNDIKJ([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8001FD0", Offset = "0x8000FD0", VA = "0x188001FD0")]
	private void ANJFPDPOABN([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80053D0", Offset = "0x80043D0", VA = "0x1880053D0")]
	protected void CPILBKBHMCA([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80174C0", Offset = "0x80164C0", VA = "0x1880174C0")]
	private void NOJBLJPOBHL([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x800A770", Offset = "0x8009770", VA = "0x18800A770")]
	protected void FANKPMPBPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x800F4F0", Offset = "0x800E4F0", VA = "0x18800F4F0")]
	private void IFNGGMLEBGG([In] OAGFOODDIAO GICMHPOANOB, [In] HIJLFIIMMBH ACOFJIEOJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8000FF0", Offset = "0x7FFFFF0", VA = "0x188000FF0")]
	private void ACGOGEFHHBA(OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80050A0", Offset = "0x80040A0", VA = "0x1880050A0")]
	private void CIJNKJEIIHF([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8012D10", Offset = "0x8011D10", VA = "0x188012D10")]
	private Vector3 KKDDGEGHPOJ([In] OAGFOODDIAO GICMHPOANOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8015FA0", Offset = "0x8014FA0", VA = "0x188015FA0")]
	private void MNBFGBOIEIJ([In] OAGFOODDIAO GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x800B1D0", Offset = "0x800A1D0", VA = "0x18800B1D0")]
	private float GILDCIGPBLI(float KOAOKGCODFM, [In] OAGFOODDIAO GICMHPOANOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x80107F0", Offset = "0x800F7F0", VA = "0x1880107F0")]
	private void JFBFEJJEKOC(float KOAOKGCODFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8010CF0", Offset = "0x800FCF0", VA = "0x188010CF0")]
	private void JFMOKCNJJDL([In] OAGFOODDIAO GICMHPOANOB, HIJLFIIMMBH ACOFJIEOJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x800DF30", Offset = "0x800CF30", VA = "0x18800DF30")]
	private float HMBCHJPIECK([In] OAGFOODDIAO BCBGGOBDICL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8014210", Offset = "0x8013210", VA = "0x188014210")]
	private void LDACBDFAOIP(OAGFOODDIAO GICMHPOANOB, HIJLFIIMMBH ACOFJIEOJEH, Vector3 BOLHDDCLCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8018130", Offset = "0x8017130", VA = "0x188018130")]
	private static void OLOAAEAJDPK(Transform PLPGMCABFBF, Quaternion KDHLIJMPIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8011620", Offset = "0x8010620", VA = "0x188011620")]
	private void JJIEKFFGBPP([In] OAGFOODDIAO JCNAIOGCFGK, [In] FEKFPDEPFDK EMHOPMPFNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8013280", Offset = "0x8012280", VA = "0x188013280")]
	private void LBAIPBJNCAL([In] OAGFOODDIAO JCNAIOGCFGK, [In] FEKFPDEPFDK EMHOPMPFNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8001CD0", Offset = "0x8000CD0", VA = "0x188001CD0")]
	private void AMFHDDMOHKM(float CGFFOONAKDE, [In] OAGFOODDIAO BCBGGOBDICL, float PIBNLOIPFKM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x80012A0", Offset = "0x80002A0", VA = "0x1880012A0")]
	private float AGDMFJJHHCN([In] OAGFOODDIAO BCBGGOBDICL, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8018760", Offset = "0x8017760", VA = "0x188018760")]
	private void OMJIHGAMOMG([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8019810", Offset = "0x8018810", VA = "0x188019810")]
	private void PLMJDKJGJFG([In] OAGFOODDIAO BCBGGOBDICL, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8010030", Offset = "0x800F030", VA = "0x188010030")]
	private void JAJHDBKDGBD([In] OAGFOODDIAO BCBGGOBDICL, float GOHIKHGDOAD, float KALEGBLPNMA, Vector3 PEBNCHICEGI, float PIBNLOIPFKM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8012320", Offset = "0x8011320", VA = "0x188012320")]
	private void KJJLGONDCJP(OAGFOODDIAO BCBGGOBDICL, AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8017A10", Offset = "0x8016A10", VA = "0x188017A10")]
	private void OCHMCHCNNAJ(OAGFOODDIAO GICMHPOANOB, AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x80159E0", Offset = "0x80149E0", VA = "0x1880159E0")]
	private void MMDOEFGDFNH(OAGFOODDIAO BCBGGOBDICL, AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8014A10", Offset = "0x8013A10", VA = "0x188014A10")]
	public void LDICOHGNNKM([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x80164C0", Offset = "0x80154C0", VA = "0x1880164C0")]
	public void NKIJBGKMBMD([In] OAGFOODDIAO GICMHPOANOB, [In] AvatarFullBodyConfiguration ANJJOFOGAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x800AA10", Offset = "0x8009A10", VA = "0x18800AA10")]
	[CompilerGenerated]
	internal static void FJPIIEADGKC(Transform BKFMBMLFOLE, IKSolverVR.Arm KCMJOKLFIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8009FF0", Offset = "0x8008FF0", VA = "0x188009FF0")]
	[CompilerGenerated]
	internal static void DPCJBHMECLI(Vector3 DPBEKEKMGOB, Vector3 ELAPNAKCMFE, HEDMMFIPPGC P_2, HMEJFACFCFC P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x800ACB0", Offset = "0x8009CB0", VA = "0x18800ACB0")]
	[CompilerGenerated]
	internal static void FMLJPMCFADD(NLJCBNMFLIH MBOAJNKNJAP, NLJCBNMFLIH CMCOBPKFNCE, Vector3 HOFKDBMECPO, float MGECNFLHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8009E60", Offset = "0x8008E60", VA = "0x188009E60")]
	[CompilerGenerated]
	internal static bool DINDOPMLBIN(IKSolverVR.Arm KCMJOKLFIBN, NJMGHHGJFFM ABHJFPEILBJ, float HGMFJMPPPKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8004470", Offset = "0x8003470", VA = "0x188004470")]
	[CompilerGenerated]
	internal static float CDDJBBEJJJF(Vector3 LDJDEFFBCOH, Vector3 EEDOCJGIPOA, Vector3 OKOGJMKEIAH, OAGFOODDIAO BCBGGOBDICL, AvatarFullBodyConfiguration ANJJOFOGAJP, float MOAJDMPNBPN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class OAMJMKAKKBG : MNNPGKNKDKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Dictionary<string, CFMKHFLAMBH> PENDNMDIKEH;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x80287D0", Offset = "0x80277D0", VA = "0x1880287D0")]
	[GOMLKAICHII.NIENCEEHOCF]
	internal static void GCCKHAEFEEO(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8028840", Offset = "0x8027840", VA = "0x188028840", Slot = "4")]
	public CFMKHFLAMBH HENGPLAHLKC(string LDOMNNPHGOI, AvatarSystemConfiguration OPJOCECCMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8028BA0", Offset = "0x8027BA0", VA = "0x188028BA0", Slot = "5")]
	public void PKBNLACNJNM(string LDOMNNPHGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8028A60", Offset = "0x8027A60", VA = "0x188028A60", Slot = "6")]
	public string NDKBNHOLJEI(string FKIDJAKFLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8028760", Offset = "0x8027760", VA = "0x188028760")]
	private string DNBEGOFFGMM(string FKIDJAKFLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8028D80", Offset = "0x8027D80", VA = "0x188028D80")]
	public OAMJMKAKKBG()
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
		public class BMMKAABAJBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Dictionary<string, Transform> LHLBKGGLFOM;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool BMKKEHNACIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x801F180", Offset = "0x801E180", VA = "0x18801F180")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x801F1C0", Offset = "0x801E1C0", VA = "0x18801F1C0")]
			public void DCBMHPPLOKP(VRIK LEBGAGHHOMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
			public void LJABBNBMAMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x801F130", Offset = "0x801E130", VA = "0x18801F130")]
			public void AEEGGHAFLLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x801F2F0", Offset = "0x801E2F0", VA = "0x18801F2F0")]
			public BMMKAABAJBE()
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
		[SerializeField]
		[ELFKDNHKCIP(KDIHEPCABNF.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[COPMMNAHICH(KDIHEPCABNF.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly BMMKAABAJBE FNCKICODOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private IHOBDFEMEHF POFKGDDAGJM;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x801E600", Offset = "0x801D600", VA = "0x18801E600")]
		private void OCOPJMCPGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x801E5B0", Offset = "0x801D5B0", VA = "0x18801E5B0")]
		private bool JGAGGMECEGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x801E8E0", Offset = "0x801D8E0", VA = "0x18801E8E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x801E950", Offset = "0x801D950", VA = "0x18801E950")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x801E8F0", Offset = "0x801D8F0", VA = "0x18801E8F0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x801EBC0", Offset = "0x801DBC0", VA = "0x18801EBC0")]
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

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8021D60", Offset = "0x8020D60", VA = "0x188021D60")]
			public (float, float) JDPBAOOMJGL(float MBIMANIBKKF)
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
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8021450", Offset = "0x8020450", VA = "0x188021450")]
			public void LMCEEELLBNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8021530", Offset = "0x8020530", VA = "0x188021530")]
			public (float, float) NFEMCMHHGFL(Animator FAKJMABDCPH, AnimatorStateInfo FAOKFEAMNDD)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8021B10", Offset = "0x8020B10", VA = "0x188021B10")]
		public void LMCEEELLBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8021670", Offset = "0x8020670", VA = "0x188021670")]
		public (float, float) FHLMFNJPNOO(Animator FAKJMABDCPH, LAJKLJFEMAM FFMAOLMIIFL, float KJKMDKIPKHM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x80218B0", Offset = "0x80208B0", VA = "0x1880218B0")]
		private (float, float) INIDNJJICGJ(Animator FAKJMABDCPH, AnimatorStateInfo FAOKFEAMNDD, LAJKLJFEMAM FFMAOLMIIFL, float KJKMDKIPKHM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8021D50", Offset = "0x8020D50", VA = "0x188021D50")]
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

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x80270F0", Offset = "0x80260F0", VA = "0x1880270F0", Slot = "4")]
		public override void OnStateEnter(Animator FAKJMABDCPH, AnimatorStateInfo FAOKFEAMNDD, int BBEMPMODLPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8027260", Offset = "0x8026260", VA = "0x188027260")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class GMCFPCHMMIJ<TInput, TOutput> : BPCANCNOMJG<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected readonly PFDLEOBDONH CHJCOCHCMLP;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4CF0", Offset = "0x4ED3CF0", VA = "0x184ED4CF0")]
	protected GMCFPCHMMIJ(PFDLEOBDONH CHJCOCHCMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput LABNBGADOBH(TInput JMJJABEKOFI, [Out] IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4C50", Offset = "0x4ED3C50", VA = "0x184ED4C50", Slot = "5")]
	public bool LBPIHNHMENG(TInput JMJJABEKOFI, [Out] TOutput? BGOCMPMGKKI, [Out] IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[NMAHPGPJLGN]
public static class KNJGCJBCNJK
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly Regex HEOGBAHHKLK;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8024180", Offset = "0x8023180", VA = "0x188024180")]
	public static FKKGCIFJDHN KEMLKHMLJGF(ENEJMMGDILI LBCLDJLEFBH, GLNFCDOGKEH IKMKGJAJKEF, Guid? GKOPHJCJIFA, Color? BBLDNEDOIML, IJELGOILOGJ MOINPJHGPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8023ED0", Offset = "0x8022ED0", VA = "0x188023ED0")]
	public static NPHONPGHNPF ENJCKJPIDOF(FKKGCIFJDHN INCJDDLACNP)
	{
		return default(NPHONPGHNPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3D25A80", Offset = "0x3D24A80", VA = "0x183D25A80")]
	internal static TModern? PKAHELIOJNJ<TModern>(string? JMJJABEKOFI, JOLMNCGABLL<TModern> JMFJIHNBIMD, PFDLEOBDONH CHJCOCHCMLP, HHNOMFBNPGO KIJGKLGLPJG, TModern BKNFFONGNAH) where TModern : struct, HLNHJFLKOLN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3D24490", Offset = "0x3D23490", VA = "0x183D24490")]
	internal static BJOHMGDMKPN CIDOOFGEGBH<TModern>(string? JMJJABEKOFI, JOLMNCGABLL<TModern> JMFJIHNBIMD, PFDLEOBDONH CHJCOCHCMLP, HHNOMFBNPGO KIJGKLGLPJG, TModern BKNFFONGNAH) where TModern : struct, HLNHJFLKOLN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8024030", Offset = "0x8023030", VA = "0x188024030")]
	internal static List<KIENMMJAMGO> HJAHBDFMAPA(IEnumerable<OEGPLENCKHH>? CEHMKOOMBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3D24C00", Offset = "0x3D23C00", VA = "0x183D24C00")]
	internal static string MFPKAHAPEBI<TModern>(TModern JMJJABEKOFI, JOLMNCGABLL<TModern> JMFJIHNBIMD, PFDLEOBDONH CHJCOCHCMLP) where TModern : HLNHJFLKOLN
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class JLJHPLNIIAA : IDCMDKHNCKM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BPCANCNOMJG<ACGMLLCPLIA, KLFIFDMNKOJ> KOGFAPKIGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BPCANCNOMJG<KPPNBDELPNB, CAAACECPOLP> PDICNDOONOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BPCANCNOMJG<KPPNBDELPNB, CAAACECPOLP> KOMPBJIDKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LMCBLIJGPKA APKHHLJCLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public KKDDNPEODLK GAMIFMINAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8023900", Offset = "0x8022900", VA = "0x188023900")]
	[GOMLKAICHII.NIENCEEHOCF.GHHMJPKJCIP]
	[UsedImplicitly]
	internal static void LMPDHEGBPAJ(CBHAAKGBAOP PFJIPDCNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8023970", Offset = "0x8022970", VA = "0x188023970")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JLJHPLNIIAA([KELEGLJPNHI("UnitySerialization")] JCICNOFMJBP JMLPANKKEFE, [KELEGLJPNHI(null)] CAOGJAKDFBC BJHBFIMLHOB, [KELEGLJPNHI(null)] PFDLEOBDONH CHJCOCHCMLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DCJDHBOIBBC
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
public class CFONHDCPLLK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8020BC0", Offset = "0x801FBC0", VA = "0x188020BC0")]
	public CFONHDCPLLK(string OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8020C60", Offset = "0x801FC60", VA = "0x188020C60")]
	public CFONHDCPLLK(string OBCNAJEENCI, Exception BMHAEMEHBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8020BF0", Offset = "0x801FBF0", VA = "0x188020BF0")]
	public CFONHDCPLLK(DCJDHBOIBBC KBDMNJDINLK, string OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8020C20", Offset = "0x801FC20", VA = "0x188020C20")]
	public CFONHDCPLLK(DCJDHBOIBBC KBDMNJDINLK, string OBCNAJEENCI, Exception BMHAEMEHBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class IOHOIJCEDAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly JCICNOFMJBP JMLPANKKEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly CAOGJAKDFBC BJHBFIMLHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly PFDLEOBDONH CHJCOCHCMLP;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8023780", Offset = "0x8022780", VA = "0x188023780")]
	protected IOHOIJCEDAG(JCICNOFMJBP JMLPANKKEFE, CAOGJAKDFBC BJHBFIMLHOB, PFDLEOBDONH CHJCOCHCMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8022470", Offset = "0x8021470", VA = "0x188022470")]
	protected string POMLKLMJDNK(KLFIFDMNKOJ FMHHPPLDGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8022150", Offset = "0x8021150", VA = "0x188022150")]
	protected string LENLCADKLJC(KLFIFDMNKOJ FMHHPPLDGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8021E20", Offset = "0x8020E20", VA = "0x188021E20")]
	private AvatarOutfitSelectionData KEMLKHMLJGF(FKKGCIFJDHN HPAPCPMHCFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8022330", Offset = "0x8021330", VA = "0x188022330")]
	private static AvatarCustomizationSettingsData.AnchorParams LLFNCMBJFCD(KCJIIMMAEMJ? NLKFKEDGKDH)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BPCANCNOMJG<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput LABNBGADOBH(TInput JMJJABEKOFI, [Out] IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LBPIHNHMENG(TInput JMJJABEKOFI, [Out] TOutput? BGOCMPMGKKI, [Out] IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IDCMDKHNCKM
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	BPCANCNOMJG<ACGMLLCPLIA, KLFIFDMNKOJ> KOGFAPKIGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BPCANCNOMJG<KPPNBDELPNB, CAAACECPOLP> KOMPBJIDKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	LMCBLIJGPKA APKHHLJCLCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum HHNOMFBNPGO
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface KKDDNPEODLK
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMCEICICBNP FBGBLPHHDGN(KLFIFDMNKOJ INCJDDLACNP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LMCBLIJGPKA
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPPNBDELPNB FBGBLPHHDGN(KLFIFDMNKOJ INCJDDLACNP, int GBBHBDCDACM, string? HJLBILHBIIC, string? CNGJOGOIPJG, KLKIFENPGNG MMHONOGNHPO, List<KIENMMJAMGO>? OEDKMLBBBAA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NMAHPGPJLGN]
internal class PKNFGPIHPHB : GMCFPCHMMIJ<ACGMLLCPLIA, KLFIFDMNKOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly CAOGJAKDFBC BJHBFIMLHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly KNNDBPPPBPP INAAMCAPFEA;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x80290C0", Offset = "0x80280C0", VA = "0x1880290C0")]
	public PKNFGPIHPHB(JCICNOFMJBP JMLPANKKEFE, CAOGJAKDFBC BJHBFIMLHOB, PFDLEOBDONH CHJCOCHCMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8028E10", Offset = "0x8027E10", VA = "0x188028E10", Slot = "6")]
	public override KLFIFDMNKOJ LABNBGADOBH(ACGMLLCPLIA JMJJABEKOFI, [Out] IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class CBDILPDENAB : JCICNOFMJBP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class NFIHMNKGAPJ : JsonConverter<BJOHMGDMKPN>
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x80273A0", Offset = "0x80263A0", VA = "0x1880273A0", Slot = "9")]
		public override void WriteJson(JsonWriter NMCAGOGLPLD, BJOHMGDMKPN? IOALKPFEKEK, JsonSerializer EPFLIAPJNOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8027280", Offset = "0x8026280", VA = "0x188027280", Slot = "10")]
		public override BJOHMGDMKPN ReadJson(JsonReader AMPJMGIAGBB, Type LOAKNADDLOC, BJOHMGDMKPN? NJJANHLNDFL, bool EPKCMBAEAJM, JsonSerializer EPFLIAPJNOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8027440", Offset = "0x8026440", VA = "0x188027440")]
		public NFIHMNKGAPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class NKDCOGMCGAJ : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool FLHKDMFLLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8027860", Offset = "0x8026860", VA = "0x188027860", Slot = "5")]
		public override object ReadJson(JsonReader AMPJMGIAGBB, Type LOAKNADDLOC, object? NJJANHLNDFL, JsonSerializer EPFLIAPJNOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8027480", Offset = "0x8026480", VA = "0x188027480", Slot = "6")]
		public override bool CanConvert(Type LOAKNADDLOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x80278C0", Offset = "0x80268C0", VA = "0x1880278C0", Slot = "4")]
		public override void WriteJson(JsonWriter NMCAGOGLPLD, object? IOALKPFEKEK, JsonSerializer EPFLIAPJNOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8027660", Offset = "0x8026660", VA = "0x188027660")]
		private static bool NMNPMBKMNBK(object IOALKPFEKEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public NKDCOGMCGAJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JsonSerializerSettings KGDNAKPKMMC;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8020A60", Offset = "0x801FA60", VA = "0x188020A60")]
	internal CBDILPDENAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AF60", Offset = "0x3A39F60", VA = "0x183A3AF60", Slot = "4")]
	public string BKLLIGOKEAD<T>(T PGIOEBKALDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AFC0", Offset = "0x3A39FC0", VA = "0x183A3AFC0", Slot = "5")]
	public T FAIPMAJKMIN<T>(string IOALKPFEKEK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class BEKKDJDMMAG : JCICNOFMJBP
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x39D5C30", Offset = "0x39D4C30", VA = "0x1839D5C30", Slot = "4")]
	public string BKLLIGOKEAD<T>(T PGIOEBKALDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x39D5C90", Offset = "0x39D4C90", VA = "0x1839D5C90", Slot = "5")]
	public T FAIPMAJKMIN<T>(string IOALKPFEKEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BEKKDJDMMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NMAHPGPJLGN]
internal class KNNDBPPPBPP : GMCFPCHMMIJ<KPPNBDELPNB, CAAACECPOLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly JCICNOFMJBP JMLPANKKEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly CAOGJAKDFBC BJHBFIMLHOB;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x80268C0", Offset = "0x80258C0", VA = "0x1880268C0")]
	public KNNDBPPPBPP(JCICNOFMJBP JMLPANKKEFE, CAOGJAKDFBC BJHBFIMLHOB, PFDLEOBDONH CHJCOCHCMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8025B20", Offset = "0x8024B20", VA = "0x188025B20", Slot = "6")]
	public override CAAACECPOLP LABNBGADOBH(KPPNBDELPNB JMJJABEKOFI, [Out] IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x80260B0", Offset = "0x80250B0", VA = "0x1880260B0")]
	internal void LPKKLHCHBKE(string FKMKLLGAJNB, KLFIFDMNKOJ FMHHPPLDGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x80251D0", Offset = "0x80241D0", VA = "0x1880251D0")]
	public IEnumerable<FKKGCIFJDHN> GIKACEDJAGB(string LMIAPKALMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8024BA0", Offset = "0x8023BA0", VA = "0x188024BA0")]
	private IEnumerable<FKKGCIFJDHN> ENGHEKMGDMK(string LMIAPKALMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8024430", Offset = "0x8023430", VA = "0x188024430")]
	internal IEnumerable<FKKGCIFJDHN> BMFDDMKCAOL(string LMIAPKALMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8026530", Offset = "0x8025530", VA = "0x188026530")]
	private FKKGCIFJDHN MBJIPOFGENK(AvatarOutfitSelectionData AMCJIIPPBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8025280", Offset = "0x8024280", VA = "0x188025280")]
	private void IHPCOAAHLFJ(AvatarCustomizationSettingsData AONBHEONOFB, KLFIFDMNKOJ FMHHPPLDGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8026210", Offset = "0x8025210", VA = "0x188026210")]
	private FKKGCIFJDHN MBJIPOFGENK(string FPCGICCDBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x80248A0", Offset = "0x80238A0", VA = "0x1880248A0")]
	internal static (IJELGOILOGJ, string, string) DCEFGFGEOCE(string FPCGICCDBAB, PFDLEOBDONH CHJCOCHCMLP)
	{
		return default((IJELGOILOGJ, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8024FD0", Offset = "0x8023FD0", VA = "0x188024FD0")]
	private OKJNCKGHGLM? GBBJAMBIDND(string? JFLBGDIIGHK, Vector2 BDEAKCBJHMK, float ONMACOBCPLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8025F50", Offset = "0x8024F50", VA = "0x188025F50")]
	private static KCJIIMMAEMJ LFPIHFDLMNJ(AvatarCustomizationSettingsData.AnchorParams PIBKHBBDFBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[NMAHPGPJLGN]
internal class LNADJLGHFCM : IOHOIJCEDAG, KKDDNPEODLK
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8023780", Offset = "0x8022780", VA = "0x188023780")]
	public LNADJLGHFCM(JCICNOFMJBP JMLPANKKEFE, CAOGJAKDFBC BJHBFIMLHOB, PFDLEOBDONH CHJCOCHCMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8026D40", Offset = "0x8025D40", VA = "0x188026D40", Slot = "4")]
	public JMCEICICBNP FBGBLPHHDGN(KLFIFDMNKOJ INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8026C40", Offset = "0x8025C40", VA = "0x188026C40")]
	private string FAALCFDGEOA(KLFIFDMNKOJ FMHHPPLDGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8026A00", Offset = "0x8025A00", VA = "0x188026A00")]
	private string BPAIOHNGDJC(FKKGCIFJDHN HPAPCPMHCFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[NMAHPGPJLGN]
internal class HIMLDOBGEDL : GMCFPCHMMIJ<KPPNBDELPNB, CAAACECPOLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly JCICNOFMJBP JMLPANKKEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly BPCANCNOMJG<KPPNBDELPNB, CAAACECPOLP> KDGAJMOAIPJ;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x80210C0", Offset = "0x80200C0", VA = "0x1880210C0")]
	public HIMLDOBGEDL(BPCANCNOMJG<KPPNBDELPNB, CAAACECPOLP> KDGAJMOAIPJ, PFDLEOBDONH CHJCOCHCMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8020C90", Offset = "0x801FC90", VA = "0x188020C90", Slot = "6")]
	public override CAAACECPOLP LABNBGADOBH(KPPNBDELPNB JMJJABEKOFI, [Out] IReadOnlyList<KIENMMJAMGO>? OEDKMLBBBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[NMAHPGPJLGN]
internal class BALFNKGGEOB : LMCBLIJGPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly JCICNOFMJBP JMLPANKKEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly KKDDNPEODLK HKJKPGBCNEE;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x801F040", Offset = "0x801E040", VA = "0x18801F040")]
	public BALFNKGGEOB(KKDDNPEODLK HKJKPGBCNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x801ECA0", Offset = "0x801DCA0", VA = "0x18801ECA0", Slot = "4")]
	public KPPNBDELPNB FBGBLPHHDGN(KLFIFDMNKOJ INCJDDLACNP, int GBBHBDCDACM, string? HJLBILHBIIC, string? CNGJOGOIPJG, KLKIFENPGNG MMHONOGNHPO, List<KIENMMJAMGO>? OEDKMLBBBAA)
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

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x801DC20", Offset = "0x801CC20", VA = "0x18801DC20")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HNDEKCLKDHP
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x80212E0", Offset = "0x80202E0", VA = "0x1880212E0")]
	public static NPHONPGHNPF LABNBGADOBH(this AKDFCJJINKG INCJDDLACNP)
	{
		return default(NPHONPGHNPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x80211C0", Offset = "0x80201C0", VA = "0x1880211C0")]
	public static AKDFCJJINKG FBGBLPHHDGN(this NPHONPGHNPF EOLNECHGGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x80213F0", Offset = "0x80203F0", VA = "0x1880213F0")]
	public static bool NHDGBANPINI(this NPHONPGHNPF EOLNECHGGHO)
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

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x60911C0", Offset = "0x60901C0", VA = "0x1860911C0")]
			public AnchorParams(Vector2 EHKBJKMBDHB, Vector3 COBIMMANOAJ, Vector3 FHACMMGNAAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x801DB70", Offset = "0x801CB70", VA = "0x18801DB70")]
			internal KCJIIMMAEMJ FBGBLPHHDGN()
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
		private AGBKNCCKDNN useHelmetHair;

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
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x801E450", Offset = "0x801D450", VA = "0x18801E450")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x180BC10", Offset = "0x180AC10", VA = "0x18180BC10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xFA6CB0", Offset = "0xFA5CB0", VA = "0x180FA6CB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x1525AB0", Offset = "0x1524AB0", VA = "0x181525AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x801E500", Offset = "0x801D500", VA = "0x18801E500")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA672F0", Offset = "0xA662F0", VA = "0x180A672F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD09AA0", Offset = "0xD08AA0", VA = "0x180D09AA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD09590", Offset = "0xD08590", VA = "0x180D09590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x801E540", Offset = "0x801D540", VA = "0x18801E540")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xF67CD0", Offset = "0xF66CD0", VA = "0x180F67CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x122F470", Offset = "0x122E470", VA = "0x18122F470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x19AE1B0", Offset = "0x19AD1B0", VA = "0x1819AE1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA63190", Offset = "0xA62190", VA = "0x180A63190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA631F0", Offset = "0xA621F0", VA = "0x180A631F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2550DF0", Offset = "0x254FDF0", VA = "0x182550DF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xF87030", Offset = "0xF86030", VA = "0x180F87030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA97230", Offset = "0xA96230", VA = "0x180A97230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA97290", Offset = "0xA96290", VA = "0x180A97290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA6EF90", Offset = "0xA6DF90", VA = "0x180A6EF90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEF0", Offset = "0xA6DEF0", VA = "0x180A6EEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEA0", Offset = "0xA6DEA0", VA = "0x180A6EEA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA6F010", Offset = "0xA6E010", VA = "0x180A6F010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F020", Offset = "0xA6E020", VA = "0x180A6F020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA6EE80", Offset = "0xA6DE80", VA = "0x180A6EE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xAC8EE0", Offset = "0xAC7EE0", VA = "0x180AC8EE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xAC54F0", Offset = "0xAC44F0", VA = "0x180AC54F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA6EE70", Offset = "0xA6DE70", VA = "0x180A6EE70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA6EFE0", Offset = "0xA6DFE0", VA = "0x180A6EFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xAC9300", Offset = "0xAC8300", VA = "0x180AC9300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB11FD0", Offset = "0xB10FD0", VA = "0x180B11FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA62800", Offset = "0xA61800", VA = "0x180A62800")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA628C0", Offset = "0xA618C0", VA = "0x180A628C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB12000", Offset = "0xB11000", VA = "0x180B12000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB12440", Offset = "0xB11440", VA = "0x180B12440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xDB7590", Offset = "0xDB6590", VA = "0x180DB7590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xDB59C0", Offset = "0xDB49C0", VA = "0x180DB59C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AGBKNCCKDNN UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1041250", Offset = "0x1040250", VA = "0x181041250")]
			get
			{
				return default(AGBKNCCKDNN);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1043500", Offset = "0x1042500", VA = "0x181043500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1042FB0", Offset = "0x1041FB0", VA = "0x181042FB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xD07490", Offset = "0xD06490", VA = "0x180D07490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x801E520", Offset = "0x801D520", VA = "0x18801E520")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x801E560", Offset = "0x801D560", VA = "0x18801E560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x801E0B0", Offset = "0x801D0B0", VA = "0x18801E0B0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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
		public IJELGOILOGJ BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private LFGOFIAPGPE? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x801E580", Offset = "0x801D580", VA = "0x18801E580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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
