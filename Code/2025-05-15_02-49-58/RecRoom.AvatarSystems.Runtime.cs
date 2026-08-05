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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AEA8E0", Offset = "0x7AE8EE0", VA = "0x187AEA8E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AECB30", Offset = "0x7AEB130", VA = "0x187AECB30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HJNCDIOGCJG]
internal class CDHPMBLNKCN : GILFOBMOIPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MOANLKMIHCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CDHPMBLNKCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public BLMBMEMIHNO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JNJBHPPDMGB HKADICMBJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PLLJPLIPBAF INFNNDKEMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OHBNFOFIAOK IJHMDBKFLOH;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF240", Offset = "0x7ACD840", VA = "0x187ACF240")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	[UsedImplicitly]
	internal static void MADPONIHLIN(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0680", Offset = "0x7ACEC80", VA = "0x187AD0680")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CDHPMBLNKCN([DJIFKCCBBND(null)] JNJBHPPDMGB HKADICMBJHI, [DJIFKCCBBND(null)] PLLJPLIPBAF INFNNDKEMPO, [DJIFKCCBBND(null)] OHBNFOFIAOK IJHMDBKFLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF2B0", Offset = "0x7ACD8B0", VA = "0x187ACF2B0", Slot = "5")]
	public MAKBECHNCGC MELFIJJOKPH(BLMBMEMIHNO JDMGBLFHDLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFB80", Offset = "0x7ACE180", VA = "0x187ACFB80", Slot = "4")]
	public MAKBECHNCGC ONIOINPGMLG(BLMBMEMIHNO JDMGBLFHDLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7ACEC30", Offset = "0x7ACD230", VA = "0x187ACEC30", Slot = "6")]
	public MBEOFKNNOOM DCJGEMDLDJL(MAKBECHNCGC APDBNIMCPID, int LKOLHBGNLLI, string? NFHOBPDKIPM, string? POLFGBPDKII, GGBJCIFEEKL MPCIGGLFCOI, List<GIPABNFHILC>? GLELOIJPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7ACEE20", Offset = "0x7ACD420", VA = "0x187ACEE20", Slot = "7")]
	public bool HGNHMGHOCGB(JPHMOLEBDKN AAKLPOECHFN, [Out] MAKBECHNCGC? MNFOAJDGMOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7ACED40", Offset = "0x7ACD340", VA = "0x187ACED40", Slot = "8")]
	public bool FHMJFKLGPEC(MBEOFKNNOOM ELDDGNMPPJC, [Out] MAKBECHNCGC? MNFOAJDGMOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7ACEBA0", Offset = "0x7ACD1A0", VA = "0x187ACEBA0", Slot = "9")]
	public bool AOMJOPBNAGP(MBEOFKNNOOM ELDDGNMPPJC, [Out] AGDKHFDLFEH? AAKLPOECHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3650190", Offset = "0x364E790", VA = "0x183650190")]
	private bool EDMAKJIKLMC<TInput, TOutput>(TInput HPLMFDGMJFE, OLMHCHJOBOD<TInput, TOutput> NABBGPFFMLK, [Out] TOutput? OBOOAPELMPF) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF090", Offset = "0x7ACD690", VA = "0x187ACF090")]
	[CompilerGenerated]
	private ECEBIFEBOFL LIHKAIMELAF(FaceFeatureType FHPHLNGNANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7ACEEB0", Offset = "0x7ACD4B0", VA = "0x187ACEEB0")]
	[CompilerGenerated]
	private ECEBIFEBOFL KKKKLHFBOKA(FaceFeatureType FHPHLNGNANC, MOANLKMIHCA P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HJNCDIOGCJG]
internal class PAANFBNILFO : JNJBHPPDMGB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void EGKNHBGOCNP<in TData>(TData MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GHKDLIKPNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public EIPECHOFFIG rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public KFHPMGIEDDO currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KFHPMGIEDDO latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GHKDLIKPNCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0880", Offset = "0x7ACEE80", VA = "0x187AD0880")]
		internal bool NCLLIPIPKAN(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0800", Offset = "0x7ACEE00", VA = "0x187AD0800")]
		internal bool CDENDILILCB(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OHBNFOFIAOK IJHMDBKFLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ABHKBFFIJLO KPKDGGHCPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EGKNHBGOCNP<MAKBECHNCGC>?[] HKADICMBJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly EGKNHBGOCNP<AGDKHFDLFEH>?[] LFMPGAHIEKJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC320", Offset = "0x7AEA920", VA = "0x187AEC320")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	[UsedImplicitly]
	internal static void MADPONIHLIN(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC4D0", Offset = "0x7AEAAD0", VA = "0x187AEC4D0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PAANFBNILFO([DJIFKCCBBND(null)] OHBNFOFIAOK IJHMDBKFLOH, [DJIFKCCBBND(null)] ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBB70", Offset = "0x7AEA170", VA = "0x187AEBB70", Slot = "4")]
	public bool GMNBDIADDKJ(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBA10", Offset = "0x7AEA010", VA = "0x187AEBA10", Slot = "5")]
	public bool GMNBDIADDKJ(AGDKHFDLFEH AAKLPOECHFN, IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7AEAE40", Offset = "0x7AE9440", VA = "0x187AEAE40")]
	private void GBEKEJOOJJM(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7AEAC10", Offset = "0x7AE9210", VA = "0x187AEAC10")]
	private void EEHNNPEMIDB(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7AEABE0", Offset = "0x7AE91E0", VA = "0x187AEABE0")]
	private void EBCOEIBACDL(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBF60", Offset = "0x7AEA560", VA = "0x187AEBF60")]
	private void JCNAGMKEJAF(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC400", Offset = "0x7AEAA00", VA = "0x187AEC400")]
	private void PDBBKBFEGCG(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7AEAB30", Offset = "0x7AE9130", VA = "0x187AEAB30")]
	private void BOCHNOEJAFO(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBF90", Offset = "0x7AEA590", VA = "0x187AEBF90")]
	private void JPMKDJBOBGF(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBF50", Offset = "0x7AEA550", VA = "0x187AEBF50")]
	private void ILLACHIEPCK(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC3D0", Offset = "0x7AEA9D0", VA = "0x187AEC3D0")]
	private void NBIDHAMMHPF(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBC70", Offset = "0x7AEA270", VA = "0x187AEBC70")]
	private void HDCMAPPMLHG(MAKBECHNCGC MNFOAJDGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC040", Offset = "0x7AEA640", VA = "0x187AEC040")]
	private MAKBECHNCGC LGFLGMELJNH(MAKBECHNCGC MNFOAJDGMOA, List<RangeMigration> HDJDIKLOEDI, KFHPMGIEDDO PFGHKIAPPEK, KFHPMGIEDDO CLAKMLOGHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7AEC390", Offset = "0x7AEA990", VA = "0x187AEC390")]
	private float MJMJBGPFDPE(float HPODJGPCPOL, Vector2 OLPNHALEGJP, Vector2 CNFFBBEJIGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA960", Offset = "0x7AE8F60", VA = "0x187AEA960")]
	private (RangeMigration?, RangeMigration?) AELIKOCACJO(List<RangeMigration> NMOJKIDEPBJ, EIPECHOFFIG GNOKAEFHKNE, KFHPMGIEDDO PFGHKIAPPEK, KFHPMGIEDDO CLAKMLOGHCG)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JNJBHPPDMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMNBDIADDKJ(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMNBDIADDKJ(AGDKHFDLFEH AAKLPOECHFN, IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);
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
		public CJANPBEAPEB AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7ACC7A0", Offset = "0x7ACADA0", VA = "0x187ACC7A0")]
		public void ANPBBEMJJGA(AnimationPoseSetting MIJLJBIHDMP, float IPMCKPMMICH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC8D0", Offset = "0x7ACAED0", VA = "0x187ACC8D0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		[SerializeField]
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

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD1C0", Offset = "0x7ACB7C0", VA = "0x187ACD1C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD180", Offset = "0x7ACB780", VA = "0x187ACD180")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7ACC8F0", Offset = "0x7ACAEF0", VA = "0x187ACC8F0")]
		private void ABPFKNCECPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C380", Offset = "0x7A5A980", VA = "0x187A5C380", Slot = "4")]
		public void SetEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD1F0", Offset = "0x7ACB7F0", VA = "0x187ACD1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ACD230", Offset = "0x7ACB830", VA = "0x187ACD230")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		[Header("Turning")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Header("Performance Tuning")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F9")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x484")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B4")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4BC")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Local offset from pelvis to foot center")]
		[Header("Shoe Settings")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4EC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x500")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD270", Offset = "0x7ACB870", VA = "0x187ACD270")]
		public AnimationPoseSetting DGBCKPGGNNO(CJANPBEAPEB AOIDMOEIADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD2A0", Offset = "0x7ACB8A0", VA = "0x187ACD2A0")]
		public void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD2E0", Offset = "0x7ACB8E0", VA = "0x187ACD2E0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum NIBHOAAEGKL
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private NIBHOAAEGKL handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDD90", Offset = "0x7ACC390", VA = "0x187ACDD90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDD50", Offset = "0x7ACC350", VA = "0x187ACDD50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD750", Offset = "0x7ACBD50", VA = "0x187ACD750")]
		private void ABPFKNCECPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C380", Offset = "0x7A5A980", VA = "0x187A5C380", Slot = "4")]
		public void SetEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDDC0", Offset = "0x7ACC3C0", VA = "0x187ACDDC0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, HFKIKIIPDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Header("Configuration")]
		[SerializeField]
		private BLMBMEMIHNO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[ANKANEOPOFH(JINCPHMLLKA.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		[FormerlySerializedAs("HeadTweakBone")]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private BAAPGEGHOGM NMNGJKOEAJB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BAAPGEGHOGM JCGAHJGOKLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7260", Offset = "0xAA5860", VA = "0x180AA7260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform KLBBKNPLNCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7ACEB80", Offset = "0x7ACD180", VA = "0x187ACEB80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDDF0", Offset = "0x7ACC3F0", VA = "0x187ACDDF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7ACEA40", Offset = "0x7ACD040", VA = "0x187ACEA40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7ACE9F0", Offset = "0x7ACCFF0", VA = "0x187ACE9F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7ACE980", Offset = "0x7ACCF80", VA = "0x187ACE980")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDDF0", Offset = "0x7ACC3F0", VA = "0x187ACDDF0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7ACE180", Offset = "0x7ACC780", VA = "0x187ACE180", Slot = "6")]
		public BAAPGEGHOGM CreateAvatarSystem(string OPGLNLBLJOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7ACE980", Offset = "0x7ACCF80", VA = "0x187ACE980", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7ACDEB0", Offset = "0x7ACC4B0", VA = "0x187ACDEB0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7ACEA90", Offset = "0x7ACD090", VA = "0x187ACEA90", Slot = "9")]
		public void UpdatePostIKAnimControllers(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KEDHFDNIIKP : BAAPGEGHOGM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class HBJMJMJHGGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 AHDMCFJJAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Quaternion FPGMDGKKEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Vector3 HOHFGLJKADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Transform LOJIHEHJPLD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 LKIOGLNDOHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1EDD5B0", Offset = "0x1EDBBB0", VA = "0x181EDD5B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1EDD5D0", Offset = "0x1EDBBD0", VA = "0x181EDD5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion OEHNFKKFODH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1371B80", Offset = "0x1370180", VA = "0x181371B80")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1371B90", Offset = "0x1370190", VA = "0x181371B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float AMPKPACIDCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x10BFD20", Offset = "0x10BE320", VA = "0x1810BFD20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x173D2D0", Offset = "0x173B8D0", VA = "0x18173D2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool ENADPPNAAIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CA0", Offset = "0x9F32A0", VA = "0x1809F4CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9F4C90", Offset = "0x9F3290", VA = "0x1809F4C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool EBHPIAIONII
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9F4C60", Offset = "0x9F3260", VA = "0x1809F4C60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CB0", Offset = "0x9F32B0", VA = "0x1809F4CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool LPNPAAALDEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9F4C80", Offset = "0x9F3280", VA = "0x1809F4C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F32D0", VA = "0x1809F4CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EJLLFPPJONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xC905F0", Offset = "0xC8EBF0", VA = "0x180C905F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xC8F7D0", Offset = "0xC8DDD0", VA = "0x180C8F7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7AF56C0", Offset = "0x7AF3CC0", VA = "0x187AF56C0")]
		public void KIBIAGGEMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5310", Offset = "0x7AF3910", VA = "0x187AF5310")]
		public void FFDADALPKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5100", Offset = "0x7AF3700", VA = "0x187AF5100")]
		public float BGJJPKDKGFF(Vector3 JEIANMNIGHN, Quaternion NGOFPBNJOEJ, [In] AvatarFootSettings IFJGIEKGHDM, float ABHKEDALKLL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7AF57D0", Offset = "0x7AF3DD0", VA = "0x187AF57D0")]
		public void NKOMLIJALIC(Vector3 NODLJBNFFGM, Quaternion CJHIPGMFCAF, Transform MGGPOKDEKGA, float PNCFODJKBFN, bool PPMKMIPLJGM, bool ANCJDJHBEAL, float NJFONFMOHLK, float DADKAHMKKBE, Transform KNNDNAPJIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5470", Offset = "0x7AF3A70", VA = "0x187AF5470")]
		public void HCCLMKDOBMK(Transform IFMAFLHJDAP, Transform KNNDNAPJIDP, bool ENIMGFKLHBK, bool JKBLJCLPDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7AF56D0", Offset = "0x7AF3CD0", VA = "0x187AF56D0")]
		private void LOMODCBODFF(Transform KNNDNAPJIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5320", Offset = "0x7AF3920", VA = "0x187AF5320")]
		public void FLFELAFMHIO(Transform KNNDNAPJIDP, AvatarFullBodyConfiguration NFFGNPJGBOO, Vector3 NCIOBCBDCOB, float AJIDOMIHCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7AF56A0", Offset = "0x7AF3CA0", VA = "0x187AF56A0")]
		public void IKIHBMBBIDI(float DADKAHMKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5EA0", Offset = "0x7AF44A0", VA = "0x187AF5EA0")]
		public HBJMJMJHGGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class CPCDNNIMDHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private float EFNIOHLHIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private bool ENOBDNKBFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AnimationPoseSetting EKMODJMGJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private float HEBNBAJLALE;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1040", Offset = "0x7AEF640", VA = "0x187AF1040")]
		public void LHHGAJOGJGK(IKSolverVR.Arm KMLBDKANGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0400", Offset = "0x7AEEA00", VA = "0x187AF0400")]
		public void HNLEICEGKNB(IKSolverVR.Arm KMLBDKANGGL, float EPBLMPBMDKA, bool ENOBDNKBFFF, AvatarFullBodyConfiguration NFFGNPJGBOO, float ECBHLBONMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFF30", Offset = "0x7AEE530", VA = "0x187AEFF30")]
		private void CMCKIBNIONO(IKSolverVR.Arm KMLBDKANGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7AF11B0", Offset = "0x7AEF7B0", VA = "0x187AF11B0")]
		public void PGIPEGODLPL(IKSolverVR.Arm KMLBDKANGGL, Transform FBFGPAFFALE, Transform MGGPOKDEKGA, Quaternion DGCPLNAEDED, Vector3 DCHPIGDNFHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFF70", Offset = "0x7AEE570", VA = "0x187AEFF70")]
		private (Vector3, Quaternion) DEGLAHDGBFC(HDJDJLAMOAI JELKBJEBGGD, Quaternion GLEKCENDMGF, Vector3 JFJICIHGCGB)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0EE0", Offset = "0x7AEF4E0", VA = "0x187AF0EE0")]
		public void KIKNOKNAKBC(HDJDJLAMOAI JELKBJEBGGD, IKSolverVR.Arm KMLBDKANGGL, Quaternion GLEKCENDMGF, Vector3 JFJICIHGCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7AF08E0", Offset = "0x7AEEEE0", VA = "0x187AF08E0")]
		public void JNAICAKPLCI(HDJDJLAMOAI JELKBJEBGGD, IKSolverVR.Arm KMLBDKANGGL, Quaternion GLEKCENDMGF, Vector3 JFJICIHGCGB, [In] AvatarFullBodyConfiguration NFFGNPJGBOO, [In] BKFAAPBAEGE IDAKFFICKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1070", Offset = "0x7AEF670", VA = "0x187AF1070")]
		public void MEGPNBIEJKK(CJANPBEAPEB EOOPLAGBJHM, AvatarFullBodyConfiguration NFFGNPJGBOO, BKFAAPBAEGE IDAKFFICKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0440", Offset = "0x7AEEA40", VA = "0x187AF0440")]
		public void JDLJNOPBMNH(IKSolverVR.Arm KMLBDKANGGL, Transform FBFGPAFFALE, Vector3 ENKIHFKAFDE, float HICICLILPGJ, Quaternion IIOACNCLGFC, Vector3 HGOHGAJLNIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1590", Offset = "0x7AEFB90", VA = "0x187AF1590")]
		public CPCDNNIMDHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum HEIAFJCBLJB
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DLCAPFGFEMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HGNBHHMIHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int OJEIGALDDOM;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int EOBBINEGJBM;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int PLCNOLACMAG;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int MEMHMFJCIBN;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int ALMHACOGPAJ;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int AIHNHKJMEID;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int JOGJLOHMLLG;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int OHIDEDLBACO;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int NIMOLFKCMCH;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int FDOBJNJNCNJ;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int CAAMDJKKPFJ;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int BGFHOACLGPJ;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int JHGPMPPKBML;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int KGFNEMIBFDC;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int GICLOEJCNKN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int EHBOHFGMBNK;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int MMDJIHPMFHF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int PHDELGNILKJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int DFMHPCBBFFF;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int EIDEMKFPNNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int MNIJBMJOPOP;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int LHBJDMFKMMN;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int ONBLEKIADJL;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int OCIAOGKMKNK;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int JMKIGNFEGPB;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int OIHDNOBHMDE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int EJPGFNPEFLG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int EPICLJNMEAL;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int ILOAMDIEJLE;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int MIOEDLILDPE;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int KCMICEMMAKK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int CNNBGGDIGMJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 KLDLCLMAOBG;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int KINOLPPFDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool OHIDOHNEAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool CGKOANKLGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool GHJJMAILJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool GCOOGGDMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool LLCKLPOEGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool COCAPCPOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Vector3 MLMIJLFBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private string DFHNBJHAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FFDGDDDMBCG? IKEDLLJHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private GBNFCHJEJII? ELOBFHBECGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private KPPCNHOKIIC HLDDCPCMHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private CGBJAHEPEBP GMCECMEINAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private HDJDJLAMOAI MGCOAJDDCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private HDJDJLAMOAI NCPPMDKMJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool GEBENMKLECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x261")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool FFJKCBMEDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly EPKODNDAIHB EHGCCIHFOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly MOOJDGDFCON LLGAMDPECDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int GNKJBPNODAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float JLPNIKIMEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private GameObject GILLDKHCBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform EIAIAHEFGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform IGOAHLJKLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform IKNMDADMLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform NPFNEEBCKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float KJFFEPPDIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float JOGNGJFELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 JNPOGLGNCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Quaternion DPBKHMLLGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform HDBBMNLMBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform LNCNNENDAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform DIFBHCCODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private AMLNEKCGNJH KBJAAJAOODI;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker ALIMKAGDCPH;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker ICJAOIAOPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker FJCCNIAKKHJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker EIJIIIFCAEA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker PENNNOJPPAA;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker NGFGHACMHMH;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<KEDHFDNIIKP> MIELAKEKJLD;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int HMBHBLGMCBF;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> PIPMNNPBPIM;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int BFIJFAHACPL;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int FNDKIBMANEL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int OFMMOEDAJBE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int EFGFMIEPJFH;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float PFNPNLIGEEB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int DEGAMCDICCN;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float COHHMGPKDDI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float JEEPEOELPFN;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float CNBOLLBMJAM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float MJGLNFAKDBF;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static DKGKCBNAIJN GMGKHICJADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float GCBOIHBJHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool DLPBGCLNIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float EGMAMNLGLFA;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int GCKAABPNCHG;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int EGKEFAKPAFG;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly int GFONPPMFAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly int FBPFGABDBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private HBJMJMJHGGJ ENNNFDPDODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private HBJMJMJHGGJ DLBEONIDANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float NKFKHNHLFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private Vector3 OAPOBKECFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private Vector3 BCNGFCGGPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool CGELGCPJABC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Quaternion CHAMHONPJMC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Quaternion ICPFMGOLLHD;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Vector3 KEMDLGODAFL;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly Vector3 GDJFEHEBOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private float MLILMPDFFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float EEFKJCEMFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private CPCDNNIMDHM FHNOKCMANMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private CPCDNNIMDHM KJBLFENEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private JBBDGNIEKHD MCBEJFHKEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private GJEJHFLDGJM EBFHILKEMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly BDLMIJMHMIN HFOADIGGDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float DLKKGCKHKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float MCGPJNHBFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly GJEJHFLDGJM AEFMJPIPPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private Vector3 ENLFDEBPIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private Vector3 JAOCIKLOPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private float DDNLCABBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float BGFELKEBNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly GJEJHFLDGJM FCAEMGNPNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly JBBDGNIEKHD IEPIJDMFLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly GJEJHFLDGJM GGINPMJEEHH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GCADBNOOJOM FALKKJBODPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GCADBNOOJOM CIDHADJOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration MMMOHDOGNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7AD11A0", Offset = "0x7ACF7A0", VA = "0x187AD11A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BLMBMEMIHNO JOABLBMPDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7AE93E0", Offset = "0x7AE79E0", VA = "0x187AE93E0", Slot = "24")]
		get
		{
			return default(BLMBMEMIHNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration IMEDJCCEKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AE94E0", Offset = "0x7AE7AE0", VA = "0x187AE94E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform MMKIBCDBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7AE7A30", Offset = "0x7AE6030", VA = "0x187AE7A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform MPPMOIEBFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7AD79C0", Offset = "0x7AD5FC0", VA = "0x187AD79C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer IEOFEJIOBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7AE06E0", Offset = "0x7ADECE0", VA = "0x187AE06E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] DEMPEPENGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8FF0", Offset = "0x7AE75F0", VA = "0x187AE8FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] BFAADINIEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7AD8940", Offset = "0x7AD6F40", VA = "0x187AD8940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator AOBKBNDEDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7AE5510", Offset = "0x7AE3B10", VA = "0x187AE5510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK IPKNFEMIIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7AD09A0", Offset = "0x7ACEFA0", VA = "0x187AD09A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private FNDPENBBHHD JHOHMBCGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC1E0", Offset = "0x7ADA7E0", VA = "0x187ADC1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private FNDPENBBHHD OBLMFHHJJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC920", Offset = "0x7ADAF20", VA = "0x187ADC920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private FNDPENBBHHD LEPMEJADPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD08A0", Offset = "0x7ACEEA0", VA = "0x187AD08A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private FNDPENBBHHD GMJFNFDEGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3DC0", Offset = "0x7AD23C0", VA = "0x187AD3DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private FNDPENBBHHD MHPPOMEODAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE5610", Offset = "0x7AE3C10", VA = "0x187AE5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private FNDPENBBHHD HGHKCOHLMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3130", Offset = "0x7AD1730", VA = "0x187AD3130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FNDPENBBHHD ALMJJNOHBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AE6D80", Offset = "0x7AE5380", VA = "0x187AE6D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private FNDPENBBHHD FDPCDAFNBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8130", Offset = "0x7AE6730", VA = "0x187AE8130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GBNFCHJEJII GBBCLJHIIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7AE98B0", Offset = "0x7AE7EB0", VA = "0x187AE98B0", Slot = "16")]
		get
		{
			return default(GBNFCHJEJII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EEFKKODIKGJ PGJMAJLFKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA6B3C0", Offset = "0xA699C0", VA = "0x180A6B3C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public CPCAHHNKCEK AHDDGCHGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAC28A0", Offset = "0xAC0EA0", VA = "0x180AC28A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public EKFIOJKBHPO LGEIPIKACBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAC2890", Offset = "0xAC0E90", VA = "0x180AC2890", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public EKFIOJKBHPO MEJGBGHHDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAC1ED0", Offset = "0xAC04D0", VA = "0x180AC1ED0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string FPFIMAEMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform OIMOCFODBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7AC0", Offset = "0x7AD60C0", VA = "0x187AD7AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform EGOPBKOEGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA0A0", Offset = "0x7AD86A0", VA = "0x187ADA0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform OMEDCCOBOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD56F0", Offset = "0x7AD3CF0", VA = "0x187AD56F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform HCOOIIBEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3010", Offset = "0x7AD1610", VA = "0x187AD3010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform BDPCIDJICIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE6580", Offset = "0x7AE4B80", VA = "0x187AE6580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool IFPNBLDHLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC140", Offset = "0x7ADA740", VA = "0x187ADC140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool GGDGFDBCBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC140", Offset = "0x7ADA740", VA = "0x187ADC140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool FDBJJDFBNED
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD2610", Offset = "0x7AD0C10", VA = "0x187AD2610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform BJEKBNFCICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7ADC040", Offset = "0x7ADA640", VA = "0x187ADC040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject CEKGANCAJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7AE5FE0", Offset = "0x7AE45E0", VA = "0x187AE5FE0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets JCKKPKMFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE6500", Offset = "0x7AE4B00", VA = "0x187AE6500", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform EEMJLEFBEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAC2250", Offset = "0xAC0850", VA = "0x180AC2250", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform PONCBILALNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAC28B0", Offset = "0xAC0EB0", VA = "0x180AC28B0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform CFBOOEIGCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAC1D90", Offset = "0xAC0390", VA = "0x180AC1D90", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform NKCCLNKEPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAB1010", Offset = "0xAAF610", VA = "0x180AB1010", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 FKIDGPICNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7640", Offset = "0x7AD5C40", VA = "0x187AD7640", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float IIDIEKPGOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0F50", Offset = "0x7ACF550", VA = "0x187AD0F50", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform ACNOOGHMDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7AE64A0", Offset = "0x7AE4AA0", VA = "0x187AE64A0", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform JDGLPAJALKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1352B40", Offset = "0x1351140", VA = "0x181352B40", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform FEDDLKCMNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x13528F0", Offset = "0x1350EF0", VA = "0x1813528F0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform FELDIDAKLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1F39440", Offset = "0x1F37A40", VA = "0x181F39440", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool EPKCPCGIKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD7CF0", Offset = "0x7AD62F0", VA = "0x187AD7CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool PANJDBMBBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD0ED0", Offset = "0x7ACF4D0", VA = "0x187AD0ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool ODKNDJDIBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7AD3EC0", Offset = "0x7AD24C0", VA = "0x187AD3EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6570", Offset = "0x7AD4B70", VA = "0x187AD6570")]
	private float ECKOBNDKGCN(FKMOHDFJKCD PCLHDOBKGMJ, float JMECHLCOKLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7ADEB60", Offset = "0x7ADD160", VA = "0x187ADEB60")]
	private void KIPBOMHHOKG([In] BKFAAPBAEGE FDHOMNINNFB, [In] AvatarFullBodyConfiguration NFFGNPJGBOO, bool MKHEMFMHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5D60", Offset = "0x7AE4360", VA = "0x187AE5D60")]
	private float MJJINOJKCEA([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0FA0", Offset = "0x7ACF5A0", VA = "0x187AD0FA0")]
	private float AIJAHLGCNFE([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE8500", Offset = "0x7AE6B00", VA = "0x187AE8500")]
	private void OJIIMNPCEEL(BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO, bool MKHEMFMHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0DD0", Offset = "0x7ADF3D0", VA = "0x187AE0DD0")]
	private void LAJCLKGLMOC([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AD3230", Offset = "0x7AD1830", VA = "0x187AD3230")]
	private void CEMKCPLABMM([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AEA440", Offset = "0x7AE8A40", VA = "0x187AEA440")]
	public KEDHFDNIIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2740", Offset = "0x7AD0D40", VA = "0x187AD2740", Slot = "13")]
	public void BGKKHEEMPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7B30", Offset = "0x7AE6130", VA = "0x187AE7B30", Slot = "14")]
	public void NLMDKFIPDPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7EE0", Offset = "0x7AE64E0", VA = "0x187AE7EE0", Slot = "15")]
	public void NMLKBJPOGME(bool FMMFAGJDEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7ADC7D0", Offset = "0x7ADADD0", VA = "0x187ADC7D0", Slot = "26")]
	public Transform JPCAGFMIMOL(string HFLPGENJMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0550", Offset = "0x7ADEB50", VA = "0x187AE0550", Slot = "27")]
	public Vector3? KJEJPIJOLAL(string HFLPGENJMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7AD68E0", Offset = "0x7AD4EE0", VA = "0x187AD68E0", Slot = "7")]
	public void EGHAMAMEBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1C60", Offset = "0x7AD0260", VA = "0x187AD1C60")]
	private void APBEHOLPKFB(AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7ADBB40", Offset = "0x7ADA140", VA = "0x187ADBB40", Slot = "8")]
	public void IGJHBAOAEEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7060", Offset = "0x7AE5660", VA = "0x187AE7060")]
	private void NFINBFCFNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7FB0", Offset = "0x7AE65B0", VA = "0x187AE7FB0")]
	private Vector3 NPHGBDECEIF([In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7AE07E0", Offset = "0x7ADEDE0", VA = "0x187AE07E0", Slot = "6")]
	public void KNFDABEMHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD3F40", Offset = "0x7AD2540", VA = "0x187AD3F40")]
	private void DCAKCCALHHN(bool MKHEMFMHMAJ, HEIAFJCBLJB IJHMKNOGOAN, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7ADBFD0", Offset = "0x7ADA5D0", VA = "0x187ADBFD0", Slot = "9")]
	public void IMKGNDJODKL(float APHAELKDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7AD7F40", Offset = "0x7AD6540", VA = "0x187AD7F40")]
	private void FMIGKOFEBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7ADCA20", Offset = "0x7ADB020", VA = "0x187ADCA20", Slot = "4")]
	public void KGAOLFNFLCP(string OPGLNLBLJOI, FFDGDDDMBCG EDIPMLDKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7AE7160", Offset = "0x7AE5760", VA = "0x187AE7160", Slot = "5")]
	public void NGFGIBJCFPD(GBNFCHJEJII AGPMMEOIJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7AD7DE0", Offset = "0x7AD63E0", VA = "0x187AD7DE0", Slot = "12")]
	public void FJEOGFLJHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1130", Offset = "0x7ADF730", VA = "0x187AE1130", Slot = "25")]
	public void LBJLCGJPOON([Out] Vector3 PJHDKAHBFNO, [Out] Quaternion IIOACNCLGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4820", Offset = "0x7AD2E20", VA = "0x187AD4820")]
	private void DEDAINOIOIH([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7AE90F0", Offset = "0x7AE76F0", VA = "0x187AE90F0", Slot = "28")]
	public void PDFAPKGMIJD(float OHCJJNIGGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6590", Offset = "0x7AD4B90", VA = "0x187AD6590", Slot = "29")]
	public void EEPICOCCDIG(float FALLCBJGLEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7AD7CA0", Offset = "0x7AD62A0", VA = "0x187AD7CA0", Slot = "45")]
	public void FDMFMABKNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1750", Offset = "0x7ADFD50", VA = "0x187AE1750", Slot = "30")]
	public void LEIBACJOHED(bool BDDOBLGJAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7ADC190", Offset = "0x7ADA790", VA = "0x187ADC190", Slot = "31")]
	public HandLogicOffsets JCMFJHLNCOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA640", Offset = "0x7AD8C40", VA = "0x187ADA640", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets HJAFIGNLJLF()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA700", Offset = "0x7AD8D00", VA = "0x187ADA700")]
	private void HKCLCIAJHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1020", Offset = "0x7ACF620", VA = "0x187AD1020")]
	private void AJGFCJMCCHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7AD0AA0", Offset = "0x7ACF0A0", VA = "0x187AD0AA0")]
	private void ACEFOMCHHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7AE17A0", Offset = "0x7ADFDA0", VA = "0x187AE17A0")]
	private void LEINIAFHOBB(HAIPDKCGNLO LNCNKMFHBPB, bool CCADIPLOOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9F20", Offset = "0x7AD8520", VA = "0x187AD9F20")]
	private void GGDMFKECHOF(HAIPDKCGNLO LNCNKMFHBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA0E0", Offset = "0x7AD86E0", VA = "0x187ADA0E0")]
	public Vector3 HHJFOPFNLDG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4C90", Offset = "0x7AD3290", VA = "0x187AD4C90")]
	private void DLKKGMNKMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7ADB990", Offset = "0x7AD9F90", VA = "0x187ADB990")]
	private void ICPFDPMIICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7ADB150", Offset = "0x7AD9750", VA = "0x187ADB150")]
	private void IBALCPCKFOL(BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7ADAFA0", Offset = "0x7AD95A0", VA = "0x187ADAFA0")]
	private float HLHHEKBBOKL([In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7AD3050", Offset = "0x7AD1650", VA = "0x187AD3050")]
	private int BPDKICOOIKJ([In] OLDCJKMFKKN DODBKCGLJPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1A80", Offset = "0x7AE0080", VA = "0x187AE1A80")]
	private void LEJNMAOONDO(BKFAAPBAEGE FDHOMNINNFB, bool DNBOLDKBAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1FA0", Offset = "0x7AE05A0", VA = "0x187AE1FA0")]
	private static void LFHMHDDKPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AE21E0", Offset = "0x7AE07E0", VA = "0x187AE21E0")]
	private static void LKKJKIFIPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AD22F0", Offset = "0x7AD08F0", VA = "0x187AD22F0")]
	private float BBKMKHGFHEJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7AE21B0", Offset = "0x7AE07B0", VA = "0x187AE21B0")]
	private static int LHEBGIJOIAN(KEDHFDNIIKP JOOBCOFNIAM, KEDHFDNIIKP MCIIEEEAOOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7AD24C0", Offset = "0x7AD0AC0", VA = "0x187AD24C0", Slot = "41")]
	public BKFAAPBAEGE BBMLHAIIGJC()
	{
		return default(BKFAAPBAEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6B90", Offset = "0x7AD5190", VA = "0x187AD6B90")]
	private bool EHHJFOPNHHM(int HJPLNJNIFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4F80", Offset = "0x7AD3580", VA = "0x187AD4F80")]
	public void DMBKEMKCDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7AD12A0", Offset = "0x7ACF8A0", VA = "0x187AD12A0")]
	private (bool, bool) ALECFKIALKB()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6E80", Offset = "0x7AE5480", VA = "0x187AE6E80")]
	private (float, float) NAKMNCLEPIH([In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7AE2EE0", Offset = "0x7AE14E0", VA = "0x187AE2EE0")]
	private void LKLBMGMHGLD([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7ADC2E0", Offset = "0x7ADA8E0", VA = "0x187ADC2E0")]
	private void JODGKCLKINE([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE6080", Offset = "0x7AE4680", VA = "0x187AE6080")]
	private void MMDNALMPJJL([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO, AvatarFootSettings IFJGIEKGHDM, bool FNHKHFEGGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7AD7B10", Offset = "0x7AD6110", VA = "0x187AD7B10")]
	private float EPKHFLDFONI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5840", Offset = "0x7AD3E40", VA = "0x187AD5840")]
	private void EABLDLAAGCO(BKFAAPBAEGE IDAKFFICKHC, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5720", Offset = "0x7AD3D20", VA = "0x187AD5720")]
	private float DPIJAGPKKOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9A60", Offset = "0x7AD8060", VA = "0x187AD9A60")]
	private void GEMLCDHOLKH([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9100", Offset = "0x7AE7700", VA = "0x187AE9100")]
	private void PGIPEGODLPL([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7AE09E0", Offset = "0x7ADEFE0", VA = "0x187AE09E0")]
	private void KNNNDIJIOFH([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5710", Offset = "0x7AE3D10", VA = "0x187AE5710")]
	private void LPNDHPLDNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7ADBD80", Offset = "0x7ADA380", VA = "0x187ADBD80")]
	private void ILONNJLIEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7ADB9B0", Offset = "0x7AD9FB0", VA = "0x187ADB9B0")]
	private void IDKEKBCJBPD([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1930", Offset = "0x7ACFF30", VA = "0x187AD1930")]
	private void AMGFNHJOKCB(HDJDJLAMOAI EJODGNCGFLE, IKSolverVR.Arm KMLBDKANGGL, Transform GCIMGLDLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1470", Offset = "0x7ACFA70", VA = "0x187AD1470")]
	private void AMFJLCOEOIO(BKFAAPBAEGE IDAKFFICKHC, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7ADC600", Offset = "0x7ADAC00", VA = "0x187ADC600")]
	private void JOPMFAEKJFH(GIEBMJIOCBM HMFFEIMOHIO, EKFIOJKBHPO EJODGNCGFLE, IKSolverVR.Arm KMLBDKANGGL, float EPBLMPBMDKA, float GIDMJDBCHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5B50", Offset = "0x7AE4150", VA = "0x187AE5B50")]
	private void MHKIDMEPLMC([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7AE89F0", Offset = "0x7AE6FF0", VA = "0x187AE89F0")]
	private void OMPGGGNLGLM([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7AD36D0", Offset = "0x7AD1CD0", VA = "0x187AD36D0")]
	protected void CJPOAHAAELG([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7AE8230", Offset = "0x7AE6830", VA = "0x187AE8230")]
	private void OFLMDHHJMAJ([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7AD3480", Offset = "0x7AD1A80", VA = "0x187AD3480")]
	protected void CFGAALCCPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7AD9240", Offset = "0x7AD7840", VA = "0x187AD9240")]
	private void GDIOBGEPFJA([In] BKFAAPBAEGE IDAKFFICKHC, [In] HEIAFJCBLJB IJHMKNOGOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7AE59A0", Offset = "0x7AE3FA0", VA = "0x187AE59A0")]
	private void MFNOPKJNBCA(BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2700", Offset = "0x7AD0D00", VA = "0x187AD2700")]
	private void BFKKKLPPOPG([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA130", Offset = "0x7AD8730", VA = "0x187ADA130")]
	private Vector3 HIECFJNAGEE([In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5770", Offset = "0x7AD3D70", VA = "0x187AD5770")]
	private void DPJFIEFICNI([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7AE75E0", Offset = "0x7AE5BE0", VA = "0x187AE75E0")]
	private float NIBIOOMECLK(float DADKAHMKKBE, [In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7AD3330", Offset = "0x7AD1930", VA = "0x187AD3330")]
	private void CEPHKCOJIEF(float DADKAHMKKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5000", Offset = "0x7AD3600", VA = "0x187AD5000")]
	private void DMFMFCOCDEK([In] BKFAAPBAEGE IDAKFFICKHC, HEIAFJCBLJB IJHMKNOGOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7AD8A40", Offset = "0x7AD7040", VA = "0x187AD8A40")]
	private float GDFMHEJMMKN([In] BKFAAPBAEGE FDHOMNINNFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7AD7F90", Offset = "0x7AD6590", VA = "0x187AD7F90")]
	private void FNOCILEKDFN(BKFAAPBAEGE IDAKFFICKHC, HEIAFJCBLJB IJHMKNOGOAN, Vector3 BLGLDDKBMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7AD63C0", Offset = "0x7AD49C0", VA = "0x187AD63C0")]
	private static void ECJOBGHNBOK(Transform KOOMPFGMBLG, Quaternion OOBEGCNALKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7AD3A90", Offset = "0x7AD2090", VA = "0x187AD3A90")]
	private void CLMOKIGLMFB([In] BKFAAPBAEGE JOIIFDKKKIE, [In] OLDCJKMFKKN DODBKCGLJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7ADA730", Offset = "0x7AD8D30", VA = "0x187ADA730")]
	private void HLBIMGLNEEI([In] BKFAAPBAEGE JOIIFDKKKIE, [In] OLDCJKMFKKN DODBKCGLJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7AE5DF0", Offset = "0x7AE43F0", VA = "0x187AE5DF0")]
	private void MLIOLAMKCAF(float HADKMGNGIIG, [In] BKFAAPBAEGE FDHOMNINNFB, float KMDPGOPNPAM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7AE65C0", Offset = "0x7AE4BC0", VA = "0x187AE65C0")]
	private float MNOHIHEPKPH([In] BKFAAPBAEGE FDHOMNINNFB, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7AD76D0", Offset = "0x7AD5CD0", VA = "0x187AD76D0")]
	private void ELOHIOGEFMC([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7AD6C30", Offset = "0x7AD5230", VA = "0x187AD6C30")]
	private void EIONBJCOEAE([In] BKFAAPBAEGE FDHOMNINNFB, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7AD2C40", Offset = "0x7AD1240", VA = "0x187AD2C40")]
	private void BKLNHKBDNCC([In] BKFAAPBAEGE FDHOMNINNFB, float ENFPGPOONLD, float DLDCPMNBMDP, Vector3 HJBEKDOHMKF, float KMDPGOPNPAM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4B20", Offset = "0x7AE3120", VA = "0x187AE4B20")]
	private void LLKBOHPFNCN(BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7AE14C0", Offset = "0x7ADFAC0", VA = "0x187AE14C0")]
	private void LCCEGCLEJEI(BKFAAPBAEGE IDAKFFICKHC, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9570", Offset = "0x7AE7B70", VA = "0x187AE9570")]
	private void PLFEDPGCJMI(BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7AD8780", Offset = "0x7AD6D80", VA = "0x187AD8780")]
	public void FNPLFBOIELG([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7AE8690", Offset = "0x7AE6C90", VA = "0x187AE8690")]
	public void OKCGGPJMFKG([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7AE0F90", Offset = "0x7ADF590", VA = "0x187AE0F90")]
	[CompilerGenerated]
	internal static void LAPDEEFLDPN(Transform KIDPOMGFMKB, IKSolverVR.Arm KMLBDKANGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7AE4A70", Offset = "0x7AE3070", VA = "0x187AE4A70")]
	[CompilerGenerated]
	internal static void LKLEHAJCOOF(Vector3 BMBKJBKLNIB, Vector3 KMCJLPDGMDA, DLCAPFGFEMK P_2, HGNBHHMIHKN P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7AD1BC0", Offset = "0x7AD01C0", VA = "0x187AD1BC0")]
	[CompilerGenerated]
	internal static void ANMPPFBDJJJ(HBJMJMJHGGJ JLNFDGMNHDM, HBJMJMJHGGJ GLPLDKAKOFI, Vector3 CKDNKLDAIAB, float JHEMEKBLBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7AD7B90", Offset = "0x7AD6190", VA = "0x187AD7B90")]
	[CompilerGenerated]
	internal static bool FCBFIIHAEHJ(IKSolverVR.Arm KMLBDKANGGL, GDMIHKFKLMH NGNHNPHIJOK, float AIMBGIEBEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7AD4850", Offset = "0x7AD2E50", VA = "0x187AD4850")]
	[CompilerGenerated]
	internal static float DFBEGCLDNIA(Vector3 JFPOLFGLBDM, Vector3 DMIFICFHEOI, Vector3 HNNHIEBJCJB, BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO, float LLPAIMMACAP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class FMNBNNMCNPJ : JACLIHLEMAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Dictionary<string, BAAPGEGHOGM> GHBKJDKBDPA;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4530", Offset = "0x7AF2B30", VA = "0x187AF4530")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JMCKCPCEAJJ(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7AF47F0", Offset = "0x7AF2DF0", VA = "0x187AF47F0", Slot = "4")]
	public BAAPGEGHOGM PFHELEOHDCA(string NECIOMIMGKD, AvatarSystemConfiguration CMHGCKDMJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4610", Offset = "0x7AF2C10", VA = "0x187AF4610", Slot = "5")]
	public void NMFFIGNDNCP(string NECIOMIMGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4A10", Offset = "0x7AF3010", VA = "0x187AF4A10", Slot = "6")]
	public string PMDODNHPLDN(string BMHHPAIDCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7AF45A0", Offset = "0x7AF2BA0", VA = "0x187AF45A0")]
	private string NLKMEOLJFAG(string BMHHPAIDCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4B50", Offset = "0x7AF3150", VA = "0x187AF4B50")]
	public FMNBNNMCNPJ()
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
		public class GKPDCAENGDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private Dictionary<string, Transform> ONJHBHMPBOE;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool NOJJAOAIMCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x7AF4E30", Offset = "0x7AF3430", VA = "0x187AF4E30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7AF4CB0", Offset = "0x7AF32B0", VA = "0x187AF4CB0")]
			public void BBHPEHLDGLO(VRIK EHGKDCMDLEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
			public void JGJJMPCGBHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7AF4DE0", Offset = "0x7AF33E0", VA = "0x187AF4DE0")]
			public void KGPJOLOPJJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7AF4E70", Offset = "0x7AF3470", VA = "0x187AF4E70")]
			public GKPDCAENGDA()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[JFJLIIJLCAB(JINCPHMLLKA.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[ANKANEOPOFH(JINCPHMLLKA.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private readonly GKPDCAENGDA DPIPNCMHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private HFKIKIIPDMF FJPDGCGFEHB;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7AEDDA0", Offset = "0x7AEC3A0", VA = "0x187AEDDA0")]
		private void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE080", Offset = "0x7AEC680", VA = "0x187AEE080")]
		private bool GGMEKDFHJEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE0D0", Offset = "0x7AEC6D0", VA = "0x187AEE0D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE140", Offset = "0x7AEC740", VA = "0x187AEE140")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE0E0", Offset = "0x7AEC6E0", VA = "0x187AEE0E0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE3B0", Offset = "0x7AEC9B0", VA = "0x187AEE3B0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6920", Offset = "0x7AF4F20", VA = "0x187AF6920")]
			public (float, float) KPKJBHABBED(float BCHJFDGMAAD)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6010", Offset = "0x7AF4610", VA = "0x187AF6010")]
			public void EEBICEODLFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7AF60F0", Offset = "0x7AF46F0", VA = "0x187AF60F0")]
			public (float, float) PFNFLKNLEEE(Animator FGOJMFPPJBI, AnimatorStateInfo JBHBDBBFEAP)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6230", Offset = "0x7AF4830", VA = "0x187AF6230")]
		public void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6420", Offset = "0x7AF4A20", VA = "0x187AF6420")]
		public (float, float) KKJKAAFIDEN(Animator FGOJMFPPJBI, FKMOHDFJKCD PCLHDOBKGMJ, float AKKDDCLLFHA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6660", Offset = "0x7AF4C60", VA = "0x187AF6660")]
		private (float, float) PBBFHPHENMN(Animator FGOJMFPPJBI, AnimatorStateInfo JBHBDBBFEAP, FKMOHDFJKCD PCLHDOBKGMJ, float AKKDDCLLFHA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6910", Offset = "0x7AF4F10", VA = "0x187AF6910")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7920", Offset = "0x7AF5F20", VA = "0x187AF7920", Slot = "4")]
		public override void OnStateEnter(Animator FGOJMFPPJBI, AnimatorStateInfo JBHBDBBFEAP, int HBNFAFEHMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7A80", Offset = "0x7AF6080", VA = "0x187AF7A80")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class LMKPELOOABO<TInput, TOutput> : OLMHCHJOBOD<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected readonly ABHKBFFIJLO KPKDGGHCPAF;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5155940", Offset = "0x5153F40", VA = "0x185155940")]
	protected LMKPELOOABO(ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput AKDPGDCBDMI(TInput HPLMFDGMJFE, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x51558A0", Offset = "0x5153EA0", VA = "0x1851558A0", Slot = "5")]
	public bool EDMAKJIKLMC(TInput HPLMFDGMJFE, [Out] TOutput? OBOOAPELMPF, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HJNCDIOGCJG]
public static class AOPBBLANAAA
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly Regex KKENPPFNLNC;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7AECFC0", Offset = "0x7AEB5C0", VA = "0x187AECFC0")]
	public static BAENJCCJOCI EDBFABDFNGE(PJDNIEDEHFC MONOBEAOLBH, DHMNCODBNBK HAAMPPLFBEG, Guid? DGPIPOJOJGM, Color? CHCKIPOAJCK, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7AECE60", Offset = "0x7AEB460", VA = "0x187AECE60")]
	public static KEEOBDBOKHK EAIHNFCIGOL(BAENJCCJOCI APDBNIMCPID)
	{
		return default(KEEOBDBOKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3FC86C0", Offset = "0x3FC6CC0", VA = "0x183FC86C0")]
	internal static TModern? HDMMMKEACBD<TModern>(string? HPLMFDGMJFE, JNCCJLHKFDA<TModern> DMOEALABEHK, ABHKBFFIJLO KPKDGGHCPAF, OGAHGIMAJLK CHBMNCOOIEN, TModern FKEHMADKJKF) where TModern : struct, AKFPMLPANDI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3FC7EE0", Offset = "0x3FC64E0", VA = "0x183FC7EE0")]
	internal static GNDBKEBKKKN FBHFOEJDJJO<TModern>(string? HPLMFDGMJFE, JNCCJLHKFDA<TModern> DMOEALABEHK, ABHKBFFIJLO KPKDGGHCPAF, OGAHGIMAJLK CHBMNCOOIEN, TModern FKEHMADKJKF) where TModern : struct, AKFPMLPANDI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7AED1D0", Offset = "0x7AEB7D0", VA = "0x187AED1D0")]
	internal static List<GIPABNFHILC> PMNPCAEINKH(IEnumerable<HIPIMHFHIGB>? CBOLBPFMLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3FC9D10", Offset = "0x3FC8310", VA = "0x183FC9D10")]
	internal static string LCJEHPGDKMM<TModern>(TModern HPLMFDGMJFE, JNCCJLHKFDA<TModern> DMOEALABEHK, ABHKBFFIJLO KPKDGGHCPAF) where TModern : AKFPMLPANDI
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class KNOPJCBNDEA : PLLJPLIPBAF
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OLMHCHJOBOD<JPHMOLEBDKN, MAKBECHNCGC> LOHBCIEHAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> GKNAPDPPFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> FGCBEIHKOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CHGBFFPHBCL ODGOMOIFKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PPCLOIEDJJJ ICOEDJMKBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6E50", Offset = "0x7AF5450", VA = "0x187AF6E50")]
	[UsedImplicitly]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void MADPONIHLIN(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6EC0", Offset = "0x7AF54C0", VA = "0x187AF6EC0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KNOPJCBNDEA([DJIFKCCBBND("UnitySerialization")] DANGHPLHCHI LDMLFEILEFC, [DJIFKCCBBND(null)] POAKPCMKJOA ABPDFJDNHFE, [DJIFKCCBBND(null)] ABHKBFFIJLO KPKDGGHCPAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DJKNOBEMALE
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
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GGOPEIFOMDM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4C10", Offset = "0x7AF3210", VA = "0x187AF4C10")]
	public GGOPEIFOMDM(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4C80", Offset = "0x7AF3280", VA = "0x187AF4C80")]
	public GGOPEIFOMDM(string NAAMEAFIHJI, Exception HBNIOKPNOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4BE0", Offset = "0x7AF31E0", VA = "0x187AF4BE0")]
	public GGOPEIFOMDM(DJKNOBEMALE DAOAPLFBLDC, string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4C40", Offset = "0x7AF3240", VA = "0x187AF4C40")]
	public GGOPEIFOMDM(DJKNOBEMALE DAOAPLFBLDC, string NAAMEAFIHJI, Exception HBNIOKPNOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class BMBHFFBEOND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly DANGHPLHCHI LDMLFEILEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly POAKPCMKJOA ABPDFJDNHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly ABHKBFFIJLO KPKDGGHCPAF;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFDB0", Offset = "0x7AEE3B0", VA = "0x187AEFDB0")]
	protected BMBHFFBEOND(DANGHPLHCHI LDMLFEILEFC, POAKPCMKJOA ABPDFJDNHFE, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7AEEAE0", Offset = "0x7AED0E0", VA = "0x187AEEAE0")]
	protected string JHODCHDNPNI(MAKBECHNCGC MNFOAJDGMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE5D0", Offset = "0x7AECBD0", VA = "0x187AEE5D0")]
	protected string CKAMECBLGMC(MAKBECHNCGC MNFOAJDGMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE7B0", Offset = "0x7AECDB0", VA = "0x187AEE7B0")]
	private AvatarOutfitSelectionData EDBFABDFNGE(BAENJCCJOCI KMJIGOCPILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE490", Offset = "0x7AECA90", VA = "0x187AEE490")]
	private static AvatarCustomizationSettingsData.AnchorParams BBDOIAOKBBH(HMAKLDEGKBC? OGABAGJHKNB)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OLMHCHJOBOD<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput AKDPGDCBDMI(TInput HPLMFDGMJFE, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EDMAKJIKLMC(TInput HPLMFDGMJFE, [Out] TOutput? OBOOAPELMPF, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PLLJPLIPBAF
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OLMHCHJOBOD<JPHMOLEBDKN, MAKBECHNCGC> LOHBCIEHAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> FGCBEIHKOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CHGBFFPHBCL ODGOMOIFKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum OGAHGIMAJLK
{
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PPCLOIEDJJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIMFOIMANHI DFNAEDFOBIJ(MAKBECHNCGC APDBNIMCPID);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CHGBFFPHBCL
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBEOFKNNOOM DFNAEDFOBIJ(MAKBECHNCGC APDBNIMCPID, int LKOLHBGNLLI, string? NFHOBPDKIPM, string? POLFGBPDKII, GGBJCIFEEKL MPCIGGLFCOI, List<GIPABNFHILC>? GLELOIJPLDA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[HJNCDIOGCJG]
internal class KIMFMCJCCGH : LMKPELOOABO<JPHMOLEBDKN, MAKBECHNCGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly POAKPCMKJOA ABPDFJDNHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly DCKNCGFAFJO LJIJGHEOFMK;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6C80", Offset = "0x7AF5280", VA = "0x187AF6C80")]
	public KIMFMCJCCGH(DANGHPLHCHI LDMLFEILEFC, POAKPCMKJOA ABPDFJDNHFE, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7AF69E0", Offset = "0x7AF4FE0", VA = "0x187AF69E0", Slot = "6")]
	public override MAKBECHNCGC AKDPGDCBDMI(JPHMOLEBDKN HPLMFDGMJFE, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class HLCOCAJDBNG : DANGHPLHCHI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GLFIJBKDDMM : JsonConverter<GNDBKEBKKKN>
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5020", Offset = "0x7AF3620", VA = "0x187AF5020", Slot = "9")]
		public override void WriteJson(JsonWriter NFOCFJIIPHM, GNDBKEBKKKN? OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4F00", Offset = "0x7AF3500", VA = "0x187AF4F00", Slot = "10")]
		public override GNDBKEBKKKN ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, GNDBKEBKKKN? ELCIIJEPMCL, bool BKBDGNCEMML, JsonSerializer AKEPDIDIPNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF50C0", Offset = "0x7AF36C0", VA = "0x187AF50C0")]
		public GLFIJBKDDMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class LIDGPOPLACF : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool NCIPIFCEDNM
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7AF77E0", Offset = "0x7AF5DE0", VA = "0x187AF77E0", Slot = "5")]
		public override object ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, object? ELCIIJEPMCL, JsonSerializer AKEPDIDIPNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7420", Offset = "0x7AF5A20", VA = "0x187AF7420", Slot = "6")]
		public override bool CanConvert(Type GENJGIKLGPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7840", Offset = "0x7AF5E40", VA = "0x187AF7840", Slot = "4")]
		public override void WriteJson(JsonWriter NFOCFJIIPHM, object? OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7600", Offset = "0x7AF5C00", VA = "0x187AF7600")]
		private static bool JKHLLOCGHIB(object OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public LIDGPOPLACF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly JsonSerializerSettings OHPJOMKGGBN;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5EB0", Offset = "0x7AF44B0", VA = "0x187AF5EB0")]
	internal HLCOCAJDBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3888810", Offset = "0x3886E10", VA = "0x183888810", Slot = "4")]
	public string ELEEPPJEPCO<T>(T BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3888870", Offset = "0x3886E70", VA = "0x183888870", Slot = "5")]
	public T MDICJHFJMDI<T>(string OHLIHBDBKCE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class POLBGPAENAA : DANGHPLHCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3A13300", Offset = "0x3A11900", VA = "0x183A13300", Slot = "4")]
	public string ELEEPPJEPCO<T>(T BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3A13380", Offset = "0x3A11980", VA = "0x183A13380", Slot = "5")]
	public T MDICJHFJMDI<T>(string OHLIHBDBKCE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public POLBGPAENAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HJNCDIOGCJG]
internal class DCKNCGFAFJO : LMKPELOOABO<MBEOFKNNOOM, AGDKHFDLFEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly DANGHPLHCHI LDMLFEILEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly POAKPCMKJOA ABPDFJDNHFE;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3A30", Offset = "0x7AF2030", VA = "0x187AF3A30")]
	public DCKNCGFAFJO(DANGHPLHCHI LDMLFEILEFC, POAKPCMKJOA ABPDFJDNHFE, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1610", Offset = "0x7AEFC10", VA = "0x187AF1610", Slot = "6")]
	public override AGDKHFDLFEH AKDPGDCBDMI(MBEOFKNNOOM HPLMFDGMJFE, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF38D0", Offset = "0x7AF1ED0", VA = "0x187AF38D0")]
	internal void PNNBCOLBGOK(string DAMLLFNDABK, MAKBECHNCGC MNFOAJDGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1D30", Offset = "0x7AF0330", VA = "0x187AF1D30")]
	public IEnumerable<BAENJCCJOCI> EJNLHCCEFMA(string GPFOJBECLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF2230", Offset = "0x7AF0830", VA = "0x187AF2230")]
	private IEnumerable<BAENJCCJOCI> GMDDAGCHELB(string GPFOJBECLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1DE0", Offset = "0x7AF03E0", VA = "0x187AF1DE0")]
	internal IEnumerable<BAENJCCJOCI> FDECFLOOFHL(string GPFOJBECLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7AF29B0", Offset = "0x7AF0FB0", VA = "0x187AF29B0")]
	private BAENJCCJOCI OIEMKEMFHGG(AvatarOutfitSelectionData OKGIFFJFICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3050", Offset = "0x7AF1650", VA = "0x187AF3050")]
	private void PLMJPLPIGJG(AvatarCustomizationSettingsData ENMKPKEIKGL, MAKBECHNCGC MNFOAJDGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7AF2D30", Offset = "0x7AF1330", VA = "0x187AF2D30")]
	private BAENJCCJOCI OIEMKEMFHGG(string BCLPLNFCBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1A30", Offset = "0x7AF0030", VA = "0x187AF1A30")]
	internal static (LEMFDNDBDJC, string, string) BHIDPCCLDNM(string BCLPLNFCBNC, ABHKBFFIJLO KPKDGGHCPAF)
	{
		return default((LEMFDNDBDJC, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7AF27B0", Offset = "0x7AF0DB0", VA = "0x187AF27B0")]
	private ECEBIFEBOFL? NLIOHHNLJEK(string? DGNNPFFMIEE, Vector2 MKBIPJMOOAN, float EIIHOPBEFCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7AF2650", Offset = "0x7AF0C50", VA = "0x187AF2650")]
	private static HMAKLDEGKBC HKBPHCOGCNM(AvatarCustomizationSettingsData.AnchorParams MJOPHNIAFAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HJNCDIOGCJG]
internal class PIPJHIJMPBM : BMBHFFBEOND, PPCLOIEDJJJ
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7AEFDB0", Offset = "0x7AEE3B0", VA = "0x187AEFDB0")]
	public PIPJHIJMPBM(DANGHPLHCHI LDMLFEILEFC, POAKPCMKJOA ABPDFJDNHFE, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7D30", Offset = "0x7AF6330", VA = "0x187AF7D30", Slot = "4")]
	public EIMFOIMANHI DFNAEDFOBIJ(MAKBECHNCGC APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF80E0", Offset = "0x7AF66E0", VA = "0x187AF80E0")]
	private string GONEHFPEDLB(MAKBECHNCGC MNFOAJDGMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7AF81E0", Offset = "0x7AF67E0", VA = "0x187AF81E0")]
	private string OGNJENAMGKO(BAENJCCJOCI KMJIGOCPILL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[HJNCDIOGCJG]
internal class EKGJELGHDGK : LMKPELOOABO<MBEOFKNNOOM, AGDKHFDLFEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly DANGHPLHCHI LDMLFEILEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> ADFCJLGMDIM;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3FA0", Offset = "0x7AF25A0", VA = "0x187AF3FA0")]
	public EKGJELGHDGK(OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> ADFCJLGMDIM, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3B70", Offset = "0x7AF2170", VA = "0x187AF3B70", Slot = "6")]
	public override AGDKHFDLFEH AKDPGDCBDMI(MBEOFKNNOOM HPLMFDGMJFE, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[HJNCDIOGCJG]
internal class FGLPPGGIOLL : CHGBFFPHBCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly DANGHPLHCHI LDMLFEILEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly PPCLOIEDJJJ LIKCICMJKMA;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4440", Offset = "0x7AF2A40", VA = "0x187AF4440")]
	public FGLPPGGIOLL(PPCLOIEDJJJ LIKCICMJKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7AF40A0", Offset = "0x7AF26A0", VA = "0x187AF40A0", Slot = "4")]
	public MBEOFKNNOOM DFNAEDFOBIJ(MAKBECHNCGC APDBNIMCPID, int LKOLHBGNLLI, string? NFHOBPDKIPM, string? POLFGBPDKII, GGBJCIFEEKL MPCIGGLFCOI, List<GIPABNFHILC>? GLELOIJPLDA)
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
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7AED460", Offset = "0x7AEBA60", VA = "0x187AED460")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NGAKKJFEAFK
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7B00", Offset = "0x7AF6100", VA = "0x187AF7B00")]
	public static KEEOBDBOKHK AKDPGDCBDMI(this BJLONKHHECM APDBNIMCPID)
	{
		return default(KEEOBDBOKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7C10", Offset = "0x7AF6210", VA = "0x187AF7C10")]
	public static BJLONKHHECM DFNAEDFOBIJ(this KEEOBDBOKHK BNOFDCLPOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7AA0", Offset = "0x7AF60A0", VA = "0x187AF7AA0")]
	public static bool ABIDACALKIJ(this KEEOBDBOKHK BNOFDCLPOBM)
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
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5C3B5B0", Offset = "0x5C39BB0", VA = "0x185C3B5B0")]
			public AnchorParams(Vector2 AFLACKAFDJB, Vector3 LGAJDNIMLAA, Vector3 GILNNGGNLNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x7AED3B0", Offset = "0x7AEB9B0", VA = "0x187AED3B0")]
			internal HMAKLDEGKBC DFNAEDFOBIJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private OJELMNHDJHH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7AEDC50", Offset = "0x7AEC250", VA = "0x187AEDC50")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x50D3C10", Offset = "0x50D2210", VA = "0x1850D3C10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xF3EEC0", Offset = "0xF3D4C0", VA = "0x180F3EEC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x12FC720", Offset = "0x12FAD20", VA = "0x1812FC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x7AEDCF0", Offset = "0x7AEC2F0", VA = "0x187AEDCF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xC07210", Offset = "0xC05810", VA = "0x180C07210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xC06FF0", Offset = "0xC055F0", VA = "0x180C06FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7AEDD30", Offset = "0x7AEC330", VA = "0x187AEDD30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xE281D0", Offset = "0xE267D0", VA = "0x180E281D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCE0", Offset = "0x10BE2E0", VA = "0x1810BFCE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x17465B0", Offset = "0x1744BB0", VA = "0x1817465B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x2273DD0", Offset = "0x22723D0", VA = "0x182273DD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xE58CD0", Offset = "0xE572D0", VA = "0x180E58CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA20D90", Offset = "0xA1F390", VA = "0x180A20D90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA20DF0", Offset = "0xA1F3F0", VA = "0x180A20DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9F3080", Offset = "0x9F1680", VA = "0x1809F3080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x9F3010", Offset = "0x9F1610", VA = "0x1809F3010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F2FF0", Offset = "0x9F15F0", VA = "0x1809F2FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xBEE060", Offset = "0xBEC660", VA = "0x180BEE060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x13038B0", Offset = "0x1301EB0", VA = "0x1813038B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x9F3040", Offset = "0x9F1640", VA = "0x1809F3040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9F3050", Offset = "0x9F1650", VA = "0x1809F3050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6750", Offset = "0xCD4D50", VA = "0x180CD6750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xE59ED0", Offset = "0xE584D0", VA = "0x180E59ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x9F64A0", Offset = "0x9F4AA0", VA = "0x1809F64A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x9F64C0", Offset = "0x9F4AC0", VA = "0x1809F64C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xD65080", Offset = "0xD63680", VA = "0x180D65080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xE6ABC0", Offset = "0xE691C0", VA = "0x180E6ABC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xC6EFE0", Offset = "0xC6D5E0", VA = "0x180C6EFE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xC6ABE0", Offset = "0xC691E0", VA = "0x180C6ABE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OJELMNHDJHH UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xF46C20", Offset = "0xF45220", VA = "0x180F46C20")]
			get
			{
				return default(OJELMNHDJHH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xF488C0", Offset = "0xF46EC0", VA = "0x180F488C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xF46350", Offset = "0xF44950", VA = "0x180F46350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xBD80F0", Offset = "0xBD66F0", VA = "0x180BD80F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x7AEDD10", Offset = "0x7AEC310", VA = "0x187AEDD10")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7AEDD50", Offset = "0x7AEC350", VA = "0x187AEDD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7AED8F0", Offset = "0x7AEBEF0", VA = "0x187AED8F0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public LEMFDNDBDJC BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private HDKFBPEELCJ? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x7AEDD70", Offset = "0x7AEC370", VA = "0x187AEDD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
