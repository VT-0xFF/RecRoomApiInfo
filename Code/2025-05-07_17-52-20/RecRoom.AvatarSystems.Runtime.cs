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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B1AF70", Offset = "0x7B19F70", VA = "0x187B1AF70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B1D200", Offset = "0x7B1C200", VA = "0x187B1D200", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AFFD40", Offset = "0x7AFED40", VA = "0x187AFFD40")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	[UsedImplicitly]
	internal static void MADPONIHLIN(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B01180", Offset = "0x7B00180", VA = "0x187B01180")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CDHPMBLNKCN([DJIFKCCBBND(null)] JNJBHPPDMGB HKADICMBJHI, [DJIFKCCBBND(null)] PLLJPLIPBAF INFNNDKEMPO, [DJIFKCCBBND(null)] OHBNFOFIAOK IJHMDBKFLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7AFFDB0", Offset = "0x7AFEDB0", VA = "0x187AFFDB0", Slot = "5")]
	public MAKBECHNCGC MELFIJJOKPH(BLMBMEMIHNO JDMGBLFHDLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B00680", Offset = "0x7AFF680", VA = "0x187B00680", Slot = "4")]
	public MAKBECHNCGC ONIOINPGMLG(BLMBMEMIHNO JDMGBLFHDLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF730", Offset = "0x7AFE730", VA = "0x187AFF730", Slot = "6")]
	public MBEOFKNNOOM DCJGEMDLDJL(MAKBECHNCGC APDBNIMCPID, int LKOLHBGNLLI, string? NFHOBPDKIPM, string? POLFGBPDKII, GGBJCIFEEKL MPCIGGLFCOI, List<GIPABNFHILC>? GLELOIJPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF920", Offset = "0x7AFE920", VA = "0x187AFF920", Slot = "7")]
	public bool HGNHMGHOCGB(JPHMOLEBDKN AAKLPOECHFN, [Out] MAKBECHNCGC? MNFOAJDGMOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF840", Offset = "0x7AFE840", VA = "0x187AFF840", Slot = "8")]
	public bool FHMJFKLGPEC(MBEOFKNNOOM ELDDGNMPPJC, [Out] MAKBECHNCGC? MNFOAJDGMOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF6A0", Offset = "0x7AFE6A0", VA = "0x187AFF6A0", Slot = "9")]
	public bool AOMJOPBNAGP(MBEOFKNNOOM ELDDGNMPPJC, [Out] AGDKHFDLFEH? AAKLPOECHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x36333E0", Offset = "0x36323E0", VA = "0x1836333E0")]
	private bool EDMAKJIKLMC<TInput, TOutput>(TInput HPLMFDGMJFE, OLMHCHJOBOD<TInput, TOutput> NABBGPFFMLK, [Out] TOutput? OBOOAPELMPF) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7AFFB90", Offset = "0x7AFEB90", VA = "0x187AFFB90")]
	[CompilerGenerated]
	private ECEBIFEBOFL LIHKAIMELAF(FaceFeatureType FHPHLNGNANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF9B0", Offset = "0x7AFE9B0", VA = "0x187AFF9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GHKDLIKPNCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B01380", Offset = "0x7B00380", VA = "0x187B01380")]
		internal bool NCLLIPIPKAN(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B01300", Offset = "0x7B00300", VA = "0x187B01300")]
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
	[Cpp2IlInjected.Address(RVA = "0x7B1C9D0", Offset = "0x7B1B9D0", VA = "0x187B1C9D0")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	[UsedImplicitly]
	internal static void MADPONIHLIN(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB80", Offset = "0x7B1BB80", VA = "0x187B1CB80")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PAANFBNILFO([DJIFKCCBBND(null)] OHBNFOFIAOK IJHMDBKFLOH, [DJIFKCCBBND(null)] ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B1C220", Offset = "0x7B1B220", VA = "0x187B1C220", Slot = "4")]
	public bool GMNBDIADDKJ(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B1C0C0", Offset = "0x7B1B0C0", VA = "0x187B1C0C0", Slot = "5")]
	public bool GMNBDIADDKJ(AGDKHFDLFEH AAKLPOECHFN, IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B1B4D0", Offset = "0x7B1A4D0", VA = "0x187B1B4D0")]
	private void GBEKEJOOJJM(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B1B2A0", Offset = "0x7B1A2A0", VA = "0x187B1B2A0")]
	private void EEHNNPEMIDB(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B1B270", Offset = "0x7B1A270", VA = "0x187B1B270")]
	private void EBCOEIBACDL(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B1C610", Offset = "0x7B1B610", VA = "0x187B1C610")]
	private void JCNAGMKEJAF(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CAB0", Offset = "0x7B1BAB0", VA = "0x187B1CAB0")]
	private void PDBBKBFEGCG(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B1B1C0", Offset = "0x7B1A1C0", VA = "0x187B1B1C0")]
	private void BOCHNOEJAFO(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B1C640", Offset = "0x7B1B640", VA = "0x187B1C640")]
	private void JPMKDJBOBGF(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B1C600", Offset = "0x7B1B600", VA = "0x187B1C600")]
	private void ILLACHIEPCK(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CA80", Offset = "0x7B1BA80", VA = "0x187B1CA80")]
	private void NBIDHAMMHPF(MAKBECHNCGC MNFOAJDGMOA, IReadOnlyList<GIPABNFHILC>? COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1C320", Offset = "0x7B1B320", VA = "0x187B1C320")]
	private void HDCMAPPMLHG(MAKBECHNCGC MNFOAJDGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B1C6F0", Offset = "0x7B1B6F0", VA = "0x187B1C6F0")]
	private MAKBECHNCGC LGFLGMELJNH(MAKBECHNCGC MNFOAJDGMOA, List<RangeMigration> HDJDIKLOEDI, KFHPMGIEDDO PFGHKIAPPEK, KFHPMGIEDDO CLAKMLOGHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CA40", Offset = "0x7B1BA40", VA = "0x187B1CA40")]
	private float MJMJBGPFDPE(float HPODJGPCPOL, Vector2 OLPNHALEGJP, Vector2 CNFFBBEJIGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B1AFF0", Offset = "0x7B19FF0", VA = "0x187B1AFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AFD230", Offset = "0x7AFC230", VA = "0x187AFD230")]
		public void ANPBBEMJJGA(AnimationPoseSetting MIJLJBIHDMP, float IPMCKPMMICH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AFD360", Offset = "0x7AFC360", VA = "0x187AFD360")]
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
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
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
		[Cpp2IlInjected.Address(RVA = "0x7AFDC70", Offset = "0x7AFCC70", VA = "0x187AFDC70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AFDC30", Offset = "0x7AFCC30", VA = "0x187AFDC30")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AFD380", Offset = "0x7AFC380", VA = "0x187AFD380")]
		private void ABPFKNCECPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C0C0", Offset = "0x7A8B0C0", VA = "0x187A8C0C0", Slot = "4")]
		public void SetEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7AFDCA0", Offset = "0x7AFCCA0", VA = "0x187AFDCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AFDCE0", Offset = "0x7AFCCE0", VA = "0x187AFDCE0")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
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
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
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
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		[Range(0.01f, 10f)]
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
		[Header("Seated animation settings")]
		[Tooltip("How much to twist shoulders when seated.")]
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
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
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
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AFDD20", Offset = "0x7AFCD20", VA = "0x187AFDD20")]
		public AnimationPoseSetting DGBCKPGGNNO(CJANPBEAPEB AOIDMOEIADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AFDD50", Offset = "0x7AFCD50", VA = "0x187AFDD50")]
		public void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7AFDD90", Offset = "0x7AFCD90", VA = "0x187AFDD90")]
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
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private NIBHOAAEGKL handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		[FormerlySerializedAs("color")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AFE860", Offset = "0x7AFD860", VA = "0x187AFE860")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE820", Offset = "0x7AFD820", VA = "0x187AFE820")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE200", Offset = "0x7AFD200", VA = "0x187AFE200")]
		private void ABPFKNCECPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C0C0", Offset = "0x7A8B0C0", VA = "0x187A8C0C0", Slot = "4")]
		public void SetEnabled(bool BFEIIPBAHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE890", Offset = "0x7AFD890", VA = "0x187AFE890")]
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
		[SerializeField]
		[Header("Configuration")]
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
		[SerializeField]
		[Header("Arm Animation Controllers")]
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
		[SerializeField]
		[Header("Facial Animation")]
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
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[FormerlySerializedAs("HeadTweakBone")]
		[SerializeField]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private BAAPGEGHOGM NMNGJKOEAJB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BAAPGEGHOGM JCGAHJGOKLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA8C100", Offset = "0xA8B100", VA = "0x180A8C100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform KLBBKNPLNCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7AFF680", Offset = "0x7AFE680", VA = "0x187AFF680", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE8C0", Offset = "0x7AFD8C0", VA = "0x187AFE8C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF540", Offset = "0x7AFE540", VA = "0x187AFF540")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF4F0", Offset = "0x7AFE4F0", VA = "0x187AFF4F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF480", Offset = "0x7AFE480", VA = "0x187AFF480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE8C0", Offset = "0x7AFD8C0", VA = "0x187AFE8C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AFEC50", Offset = "0x7AFDC50", VA = "0x187AFEC50", Slot = "6")]
		public BAAPGEGHOGM CreateAvatarSystem(string OPGLNLBLJOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF480", Offset = "0x7AFE480", VA = "0x187AFF480", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE980", Offset = "0x7AFD980", VA = "0x187AFE980", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF590", Offset = "0x7AFE590", VA = "0x187AFF590", Slot = "9")]
		public void UpdatePostIKAnimControllers(float CJIPMCGKHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Vector3 AHDMCFJJAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Quaternion FPGMDGKKEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Vector3 HOHFGLJKADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private Transform LOJIHEHJPLD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 LKIOGLNDOHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1EC7EF0", Offset = "0x1EC6EF0", VA = "0x181EC7EF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1EC7F10", Offset = "0x1EC6F10", VA = "0x181EC7F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion OEHNFKKFODH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1356220", Offset = "0x1355220", VA = "0x181356220")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1356230", Offset = "0x1355230", VA = "0x181356230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float AMPKPACIDCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x10AC030", Offset = "0x10AB030", VA = "0x1810AC030")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x17228F0", Offset = "0x17218F0", VA = "0x1817228F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool ENADPPNAAIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9FACA0", Offset = "0x9F9CA0", VA = "0x1809FACA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9FAC90", Offset = "0x9F9C90", VA = "0x1809FAC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool EBHPIAIONII
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9FAC60", Offset = "0x9F9C60", VA = "0x1809FAC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9FACB0", Offset = "0x9F9CB0", VA = "0x1809FACB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool LPNPAAALDEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9FAC80", Offset = "0x9F9C80", VA = "0x1809FAC80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9FACD0", Offset = "0x9F9CD0", VA = "0x1809FACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EJLLFPPJONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xC658A0", Offset = "0xC648A0", VA = "0x180C658A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xC649E0", Offset = "0xC639E0", VA = "0x180C649E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B25EA0", Offset = "0x7B24EA0", VA = "0x187B25EA0")]
		public void KIBIAGGEMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B25AF0", Offset = "0x7B24AF0", VA = "0x187B25AF0")]
		public void FFDADALPKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B258E0", Offset = "0x7B248E0", VA = "0x187B258E0")]
		public float BGJJPKDKGFF(Vector3 JEIANMNIGHN, Quaternion NGOFPBNJOEJ, [In] AvatarFootSettings IFJGIEKGHDM, float ABHKEDALKLL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B25FB0", Offset = "0x7B24FB0", VA = "0x187B25FB0")]
		public void NKOMLIJALIC(Vector3 NODLJBNFFGM, Quaternion CJHIPGMFCAF, Transform MGGPOKDEKGA, float PNCFODJKBFN, bool PPMKMIPLJGM, bool ANCJDJHBEAL, float NJFONFMOHLK, float DADKAHMKKBE, Transform KNNDNAPJIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B25C50", Offset = "0x7B24C50", VA = "0x187B25C50")]
		public void HCCLMKDOBMK(Transform IFMAFLHJDAP, Transform KNNDNAPJIDP, bool ENIMGFKLHBK, bool JKBLJCLPDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B25EB0", Offset = "0x7B24EB0", VA = "0x187B25EB0")]
		private void LOMODCBODFF(Transform KNNDNAPJIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B25B00", Offset = "0x7B24B00", VA = "0x187B25B00")]
		public void FLFELAFMHIO(Transform KNNDNAPJIDP, AvatarFullBodyConfiguration NFFGNPJGBOO, Vector3 NCIOBCBDCOB, float AJIDOMIHCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B25E80", Offset = "0x7B24E80", VA = "0x187B25E80")]
		public void IKIHBMBBIDI(float DADKAHMKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B26690", Offset = "0x7B25690", VA = "0x187B26690")]
		public HBJMJMJHGGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class CPCDNNIMDHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float EFNIOHLHIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool ENOBDNKBFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AnimationPoseSetting EKMODJMGJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float HEBNBAJLALE;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B217C0", Offset = "0x7B207C0", VA = "0x187B217C0")]
		public void LHHGAJOGJGK(IKSolverVR.Arm KMLBDKANGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B20B80", Offset = "0x7B1FB80", VA = "0x187B20B80")]
		public void HNLEICEGKNB(IKSolverVR.Arm KMLBDKANGGL, float EPBLMPBMDKA, bool ENOBDNKBFFF, AvatarFullBodyConfiguration NFFGNPJGBOO, float ECBHLBONMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B206B0", Offset = "0x7B1F6B0", VA = "0x187B206B0")]
		private void CMCKIBNIONO(IKSolverVR.Arm KMLBDKANGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B21930", Offset = "0x7B20930", VA = "0x187B21930")]
		public void PGIPEGODLPL(IKSolverVR.Arm KMLBDKANGGL, Transform FBFGPAFFALE, Transform MGGPOKDEKGA, Quaternion DGCPLNAEDED, Vector3 DCHPIGDNFHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B206F0", Offset = "0x7B1F6F0", VA = "0x187B206F0")]
		private (Vector3, Quaternion) DEGLAHDGBFC(HDJDJLAMOAI JELKBJEBGGD, Quaternion GLEKCENDMGF, Vector3 JFJICIHGCGB)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B21660", Offset = "0x7B20660", VA = "0x187B21660")]
		public void KIKNOKNAKBC(HDJDJLAMOAI JELKBJEBGGD, IKSolverVR.Arm KMLBDKANGGL, Quaternion GLEKCENDMGF, Vector3 JFJICIHGCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B21060", Offset = "0x7B20060", VA = "0x187B21060")]
		public void JNAICAKPLCI(HDJDJLAMOAI JELKBJEBGGD, IKSolverVR.Arm KMLBDKANGGL, Quaternion GLEKCENDMGF, Vector3 JFJICIHGCGB, [In] AvatarFullBodyConfiguration NFFGNPJGBOO, [In] BKFAAPBAEGE IDAKFFICKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B217F0", Offset = "0x7B207F0", VA = "0x187B217F0")]
		public void MEGPNBIEJKK(CJANPBEAPEB EOOPLAGBJHM, AvatarFullBodyConfiguration NFFGNPJGBOO, BKFAAPBAEGE IDAKFFICKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B20BC0", Offset = "0x7B1FBC0", VA = "0x187B20BC0")]
		public void JDLJNOPBMNH(IKSolverVR.Arm KMLBDKANGGL, Transform FBFGPAFFALE, Vector3 ENKIHFKAFDE, float HICICLILPGJ, Quaternion IIOACNCLGFC, Vector3 HGOHGAJLNIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B21D10", Offset = "0x7B20D10", VA = "0x187B21D10")]
		public CPCDNNIMDHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum HEIAFJCBLJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FEHLLDHDPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HIEFNMDKHPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int OJEIGALDDOM;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int EOBBINEGJBM;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int PLCNOLACMAG;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int MEMHMFJCIBN;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int ALMHACOGPAJ;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int AIHNHKJMEID;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int JOGJLOHMLLG;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int OHIDEDLBACO;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int NIMOLFKCMCH;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int FDOBJNJNCNJ;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int CAAMDJKKPFJ;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int BGFHOACLGPJ;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int JHGPMPPKBML;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int KGFNEMIBFDC;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int GICLOEJCNKN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int EHBOHFGMBNK;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int MMDJIHPMFHF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int PHDELGNILKJ;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int DFMHPCBBFFF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int EIDEMKFPNNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int MNIJBMJOPOP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int LHBJDMFKMMN;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int ONBLEKIADJL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int OCIAOGKMKNK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int JMKIGNFEGPB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int OIHDNOBHMDE;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int EJPGFNPEFLG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int EPICLJNMEAL;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int ILOAMDIEJLE;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int MIOEDLILDPE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int KCMICEMMAKK;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int CNNBGGDIGMJ;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly Vector3 KLDLCLMAOBG;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int KINOLPPFDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool OHIDOHNEAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool CGKOANKLGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool GHJJMAILJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool GCOOGGDMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool LLCKLPOEGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool COCAPCPOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Vector3 MLMIJLFBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private string DFHNBJHAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private FFDGDDDMBCG? IKEDLLJHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private GBNFCHJEJII? ELOBFHBECGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private KPPCNHOKIIC HLDDCPCMHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private CGBJAHEPEBP GMCECMEINAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private HDJDJLAMOAI MGCOAJDDCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private HDJDJLAMOAI NCPPMDKMJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool GEBENMKLECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool FFJKCBMEDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly EPKODNDAIHB EHGCCIHFOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly MOOJDGDFCON LLGAMDPECDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int GNKJBPNODAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private float JLPNIKIMEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private GameObject GILLDKHCBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform EIAIAHEFGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform IGOAHLJKLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform IKNMDADMLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform NPFNEEBCKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float KJFFEPPDIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private float JOGNGJFELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Vector3 JNPOGLGNCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Quaternion DPBKHMLLGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform HDBBMNLMBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform LNCNNENDAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Transform DIFBHCCODEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private AMLNEKCGNJH KBJAAJAOODI;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker ALIMKAGDCPH;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker ICJAOIAOPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private ProfilerMarker FJCCNIAKKHJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker EIJIIIFCAEA;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker PENNNOJPPAA;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly ProfilerMarker NGFGHACMHMH;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly List<KEDHFDNIIKP> MIELAKEKJLD;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int HMBHBLGMCBF;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> PIPMNNPBPIM;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int BFIJFAHACPL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int FNDKIBMANEL;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int OFMMOEDAJBE;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static int EFGFMIEPJFH;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float PFNPNLIGEEB;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int DEGAMCDICCN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float COHHMGPKDDI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float JEEPEOELPFN;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float CNBOLLBMJAM;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static float MJGLNFAKDBF;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static DKGKCBNAIJN GMGKHICJADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float GCBOIHBJHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool DLPBGCLNIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float EGMAMNLGLFA;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int GCKAABPNCHG;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly int EGKEFAKPAFG;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly int GFONPPMFAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly int FBPFGABDBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private HBJMJMJHGGJ ENNNFDPDODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private HBJMJMJHGGJ DLBEONIDANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private float NKFKHNHLFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private Vector3 OAPOBKECFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private Vector3 BCNGFCGGPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool CGELGCPJABC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Quaternion CHAMHONPJMC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Quaternion ICPFMGOLLHD;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly Vector3 KEMDLGODAFL;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Vector3 GDJFEHEBOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float MLILMPDFFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float EEFKJCEMFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private CPCDNNIMDHM FHNOKCMANMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private CPCDNNIMDHM KJBLFENEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private JBBDGNIEKHD MCBEJFHKEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private GJEJHFLDGJM EBFHILKEMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly BDLMIJMHMIN HFOADIGGDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float DLKKGCKHKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float MCGPJNHBFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly GJEJHFLDGJM AEFMJPIPPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private Vector3 ENLFDEBPIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private Vector3 JAOCIKLOPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float DDNLCABBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float BGFELKEBNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly GJEJHFLDGJM FCAEMGNPNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly JBBDGNIEKHD IEPIJDMFLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly GJEJHFLDGJM GGINPMJEEHH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GCADBNOOJOM FALKKJBODPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B01CB0", Offset = "0x7B00CB0", VA = "0x187B01CB0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BLMBMEMIHNO JOABLBMPDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B199B0", Offset = "0x7B189B0", VA = "0x187B199B0", Slot = "23")]
		get
		{
			return default(BLMBMEMIHNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration IMEDJCCEKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7B19AB0", Offset = "0x7B18AB0", VA = "0x187B19AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform MMKIBCDBMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B17B10", Offset = "0x7B16B10", VA = "0x187B17B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform MPPMOIEBFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B07570", Offset = "0x7B06570", VA = "0x187B07570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer IEOFEJIOBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B10220", Offset = "0x7B0F220", VA = "0x187B10220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] DEMPEPENGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B19180", Offset = "0x7B18180", VA = "0x187B19180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] BFAADINIEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B083F0", Offset = "0x7B073F0", VA = "0x187B083F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator AOBKBNDEDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B15660", Offset = "0x7B14660", VA = "0x187B15660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK IPKNFEMIIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7B014A0", Offset = "0x7B004A0", VA = "0x187B014A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private FNDPENBBHHD JHOHMBCGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0BAC0", Offset = "0x7B0AAC0", VA = "0x187B0BAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private FNDPENBBHHD OBLMFHHJJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C200", Offset = "0x7B0B200", VA = "0x187B0C200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private FNDPENBBHHD LEPMEJADPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B013A0", Offset = "0x7B003A0", VA = "0x187B013A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private FNDPENBBHHD GMJFNFDEGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B04180", Offset = "0x7B03180", VA = "0x187B04180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private FNDPENBBHHD MHPPOMEODAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B15760", Offset = "0x7B14760", VA = "0x187B15760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private FNDPENBBHHD HGHKCOHLMGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7B03520", Offset = "0x7B02520", VA = "0x187B03520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FNDPENBBHHD ALMJJNOHBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B16E60", Offset = "0x7B15E60", VA = "0x187B16E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private FNDPENBBHHD FDPCDAFNBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B18210", Offset = "0x7B17210", VA = "0x187B18210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GBNFCHJEJII GBBCLJHIIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B19E80", Offset = "0x7B18E80", VA = "0x187B19E80", Slot = "15")]
		get
		{
			return default(GBNFCHJEJII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EEFKKODIKGJ PGJMAJLFKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAB18E0", Offset = "0xAB08E0", VA = "0x180AB18E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public CPCAHHNKCEK AHDDGCHGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAB18D0", Offset = "0xAB08D0", VA = "0x180AB18D0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public EKFIOJKBHPO LGEIPIKACBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAFEE0", VA = "0x180AB0EE0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public EKFIOJKBHPO MEJGBGHHDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAB1570", Offset = "0xAB0570", VA = "0x180AB1570", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string FPFIMAEMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform OIMOCFODBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B07670", Offset = "0x7B06670", VA = "0x187B07670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform EGOPBKOEGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B09B50", Offset = "0x7B08B50", VA = "0x187B09B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform OMEDCCOBOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B04D90", Offset = "0x7B03D90", VA = "0x187B04D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform HCOOIIBEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B03400", Offset = "0x7B02400", VA = "0x187B03400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform BDPCIDJICIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B16660", Offset = "0x7B15660", VA = "0x187B16660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool IFPNBLDHLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0BA20", Offset = "0x7B0AA20", VA = "0x187B0BA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool GGDGFDBCBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0BA20", Offset = "0x7B0AA20", VA = "0x187B0BA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool FDBJJDFBNED
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7B02A00", Offset = "0x7B01A00", VA = "0x187B02A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform BJEKBNFCICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B920", Offset = "0x7B0A920", VA = "0x187B0B920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject CEKGANCAJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B160C0", Offset = "0x7B150C0", VA = "0x187B160C0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets JCKKPKMFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B165E0", Offset = "0x7B155E0", VA = "0x187B165E0", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform EEMJLEFBEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xAB18F0", Offset = "0xAB08F0", VA = "0x180AB18F0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform PONCBILALNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAB0D60", Offset = "0xAAFD60", VA = "0x180AB0D60", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform CFBOOEIGCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAA0040", Offset = "0xA9F040", VA = "0x180AA0040", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform NKCCLNKEPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAB1860", Offset = "0xAB0860", VA = "0x180AB1860", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 FKIDGPICNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B071F0", Offset = "0x7B061F0", VA = "0x187B071F0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float IIDIEKPGOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B01A60", Offset = "0x7B00A60", VA = "0x187B01A60", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform ACNOOGHMDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B16580", Offset = "0x7B15580", VA = "0x187B16580", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform JDGLPAJALKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1339160", Offset = "0x1338160", VA = "0x181339160", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform FEDDLKCMNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1338F00", Offset = "0x1337F00", VA = "0x181338F00", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform FELDIDAKLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x229BEB0", Offset = "0x229AEB0", VA = "0x18229BEB0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool EPKCPCGIKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B07790", Offset = "0x7B06790", VA = "0x187B07790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool PANJDBMBBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B019E0", Offset = "0x7B009E0", VA = "0x187B019E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool ODKNDJDIBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B04280", Offset = "0x7B03280", VA = "0x187B04280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7B05C10", Offset = "0x7B04C10", VA = "0x187B05C10")]
	private float ECKOBNDKGCN(FKMOHDFJKCD PCLHDOBKGMJ, float JMECHLCOKLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7B0E680", Offset = "0x7B0D680", VA = "0x187B0E680")]
	private void KIPBOMHHOKG([In] BKFAAPBAEGE FDHOMNINNFB, [In] AvatarFullBodyConfiguration NFFGNPJGBOO, bool MKHEMFMHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7B15E40", Offset = "0x7B14E40", VA = "0x187B15E40")]
	private float MJJINOJKCEA([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B01AB0", Offset = "0x7B00AB0", VA = "0x187B01AB0")]
	private float AIJAHLGCNFE([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B185E0", Offset = "0x7B175E0", VA = "0x187B185E0")]
	private void OJIIMNPCEEL(BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO, bool MKHEMFMHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B11090", Offset = "0x7B10090", VA = "0x187B11090")]
	private void LAJCLKGLMOC([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B03620", Offset = "0x7B02620", VA = "0x187B03620")]
	private void CEMKCPLABMM([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1AAD0", Offset = "0x7B19AD0", VA = "0x187B1AAD0")]
	public KEDHFDNIIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B02B30", Offset = "0x7B01B30", VA = "0x187B02B30", Slot = "12")]
	public void BGKKHEEMPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B17C10", Offset = "0x7B16C10", VA = "0x187B17C10", Slot = "13")]
	public void NLMDKFIPDPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B17FC0", Offset = "0x7B16FC0", VA = "0x187B17FC0", Slot = "14")]
	public void NMLKBJPOGME(bool FMMFAGJDEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C0B0", Offset = "0x7B0B0B0", VA = "0x187B0C0B0", Slot = "25")]
	public Transform JPCAGFMIMOL(string HFLPGENJMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B10080", Offset = "0x7B0F080", VA = "0x187B10080", Slot = "26")]
	public Vector3? KJEJPIJOLAL(string HFLPGENJMGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B05F80", Offset = "0x7B04F80", VA = "0x187B05F80", Slot = "7")]
	public void EGHAMAMEBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B17140", Offset = "0x7B16140", VA = "0x187B17140")]
	private void NFINBFCFNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B18090", Offset = "0x7B17090", VA = "0x187B18090")]
	private Vector3 NPHGBDECEIF([In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B10320", Offset = "0x7B0F320", VA = "0x187B10320", Slot = "6")]
	public void KNFDABEMHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0B8B0", Offset = "0x7B0A8B0", VA = "0x187B0B8B0", Slot = "8")]
	public void IMKGNDJODKL(float APHAELKDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B079E0", Offset = "0x7B069E0", VA = "0x187B079E0")]
	private void FMIGKOFEBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C300", Offset = "0x7B0B300", VA = "0x187B0C300", Slot = "4")]
	public void KGAOLFNFLCP(string OPGLNLBLJOI, FFDGDDDMBCG EDIPMLDKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B17240", Offset = "0x7B16240", VA = "0x187B17240", Slot = "5")]
	public void NGFGIBJCFPD(GBNFCHJEJII AGPMMEOIJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B07880", Offset = "0x7B06880", VA = "0x187B07880", Slot = "11")]
	public void FJEOGFLJHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B11250", Offset = "0x7B10250", VA = "0x187B11250", Slot = "24")]
	public void LBJLCGJPOON([Out] Vector3 PJHDKAHBFNO, [Out] Quaternion IIOACNCLGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B04300", Offset = "0x7B03300", VA = "0x187B04300")]
	private void DEDAINOIOIH([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x11D7780", Offset = "0x11D6780", VA = "0x1811D7780", Slot = "27")]
	public void PDFAPKGMIJD(float OHCJJNIGGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7B05C30", Offset = "0x7B04C30", VA = "0x187B05C30", Slot = "28")]
	public void EEPICOCCDIG(float FALLCBJGLEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7B07740", Offset = "0x7B06740", VA = "0x187B07740", Slot = "44")]
	public void FDMFMABKNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7B11870", Offset = "0x7B10870", VA = "0x187B11870", Slot = "29")]
	public void LEIBACJOHED(bool BDDOBLGJAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7B0BA70", Offset = "0x7B0AA70", VA = "0x187B0BA70", Slot = "30")]
	public HandLogicOffsets JCMFJHLNCOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7B0A100", Offset = "0x7B09100", VA = "0x187B0A100", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets HJAFIGNLJLF()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7B0A1C0", Offset = "0x7B091C0", VA = "0x187B0A1C0")]
	private void HKCLCIAJHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B01B30", Offset = "0x7B00B30", VA = "0x187B01B30")]
	private void AJGFCJMCCHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B015A0", Offset = "0x7B005A0", VA = "0x187B015A0")]
	private void ACEFOMCHHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B118C0", Offset = "0x7B108C0", VA = "0x187B118C0")]
	private void LEINIAFHOBB(HAIPDKCGNLO LNCNKMFHBPB, bool CCADIPLOOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B099D0", Offset = "0x7B089D0", VA = "0x187B099D0")]
	private void GGDMFKECHOF(HAIPDKCGNLO LNCNKMFHBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B09B90", Offset = "0x7B08B90", VA = "0x187B09B90")]
	public Vector3 HHJFOPFNLDG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B04330", Offset = "0x7B03330", VA = "0x187B04330")]
	private void DLKKGMNKMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0B4A0", Offset = "0x7B0A4A0", VA = "0x187B0B4A0")]
	private void ICPFDPMIICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0AC50", Offset = "0x7B09C50", VA = "0x187B0AC50")]
	private void IBALCPCKFOL(BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0AAA0", Offset = "0x7B09AA0", VA = "0x187B0AAA0")]
	private float HLHHEKBBOKL([In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B03440", Offset = "0x7B02440", VA = "0x187B03440")]
	private int BPDKICOOIKJ([In] OLDCJKMFKKN DODBKCGLJPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7B11BA0", Offset = "0x7B10BA0", VA = "0x187B11BA0")]
	private void LEJNMAOONDO(BKFAAPBAEGE FDHOMNINNFB, bool DNBOLDKBAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7B120E0", Offset = "0x7B110E0", VA = "0x187B120E0")]
	private static void LFHMHDDKPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B123D0", Offset = "0x7B113D0", VA = "0x187B123D0")]
	private static void LKKJKIFIPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B026E0", Offset = "0x7B016E0", VA = "0x187B026E0")]
	private float BBKMKHGFHEJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B12300", Offset = "0x7B11300", VA = "0x187B12300")]
	private static int LHEBGIJOIAN(KEDHFDNIIKP JOOBCOFNIAM, KEDHFDNIIKP MCIIEEEAOOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7B028B0", Offset = "0x7B018B0", VA = "0x187B028B0", Slot = "40")]
	public BKFAAPBAEGE BBMLHAIIGJC()
	{
		return default(BKFAAPBAEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B06710", Offset = "0x7B05710", VA = "0x187B06710")]
	private bool EHHJFOPNHHM(int HJPLNJNIFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7B04620", Offset = "0x7B03620", VA = "0x187B04620")]
	public void DMBKEMKCDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B01DB0", Offset = "0x7B00DB0", VA = "0x187B01DB0")]
	private (bool, bool) ALECFKIALKB()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B16F60", Offset = "0x7B15F60", VA = "0x187B16F60")]
	private (float, float) NAKMNCLEPIH([In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B130D0", Offset = "0x7B120D0", VA = "0x187B130D0")]
	private void LKLBMGMHGLD([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B0BBC0", Offset = "0x7B0ABC0", VA = "0x187B0BBC0")]
	private void JODGKCLKINE([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7B16160", Offset = "0x7B15160", VA = "0x187B16160")]
	private void MMDNALMPJJL([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO, AvatarFootSettings IFJGIEKGHDM, bool FNHKHFEGGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7B076C0", Offset = "0x7B066C0", VA = "0x187B076C0")]
	private float EPKHFLDFONI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B04EE0", Offset = "0x7B03EE0", VA = "0x187B04EE0")]
	private void EABLDLAAGCO(BKFAAPBAEGE IDAKFFICKHC, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B04DC0", Offset = "0x7B03DC0", VA = "0x187B04DC0")]
	private float DPIJAGPKKOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B09510", Offset = "0x7B08510", VA = "0x187B09510")]
	private void GEMLCDHOLKH([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7B196C0", Offset = "0x7B186C0", VA = "0x187B196C0")]
	private void PGIPEGODLPL([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B10C90", Offset = "0x7B0FC90", VA = "0x187B10C90")]
	private void KNNNDIJIOFH([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7B15860", Offset = "0x7B14860", VA = "0x187B15860")]
	private void LPNDHPLDNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7B0B650", Offset = "0x7B0A650", VA = "0x187B0B650")]
	private void ILONNJLIEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B0B4C0", Offset = "0x7B0A4C0", VA = "0x187B0B4C0")]
	private void IDKEKBCJBPD([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7B02450", Offset = "0x7B01450", VA = "0x187B02450")]
	private void AMGFNHJOKCB(HDJDJLAMOAI EJODGNCGFLE, IKSolverVR.Arm KMLBDKANGGL, Transform GCIMGLDLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B01F90", Offset = "0x7B00F90", VA = "0x187B01F90")]
	private void AMFJLCOEOIO(BKFAAPBAEGE IDAKFFICKHC, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B0BEE0", Offset = "0x7B0AEE0", VA = "0x187B0BEE0")]
	private void JOPMFAEKJFH(GIEBMJIOCBM HMFFEIMOHIO, EKFIOJKBHPO EJODGNCGFLE, IKSolverVR.Arm KMLBDKANGGL, float EPBLMPBMDKA, float GIDMJDBCHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B18AD0", Offset = "0x7B17AD0", VA = "0x187B18AD0")]
	private void OMPGGGNLGLM([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7B03AC0", Offset = "0x7B02AC0", VA = "0x187B03AC0")]
	protected void CJPOAHAAELG([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7B18310", Offset = "0x7B17310", VA = "0x187B18310")]
	private void OFLMDHHJMAJ([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7B03870", Offset = "0x7B02870", VA = "0x187B03870")]
	protected void CFGAALCCPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B08CF0", Offset = "0x7B07CF0", VA = "0x187B08CF0")]
	private void GDIOBGEPFJA([In] BKFAAPBAEGE IDAKFFICKHC, [In] HEIAFJCBLJB IJHMKNOGOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7B15AF0", Offset = "0x7B14AF0", VA = "0x187B15AF0")]
	private void MFNOPKJNBCA(BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B02AF0", Offset = "0x7B01AF0", VA = "0x187B02AF0")]
	private void BFKKKLPPOPG([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7B09BE0", Offset = "0x7B08BE0", VA = "0x187B09BE0")]
	private Vector3 HIECFJNAGEE([In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B04E10", Offset = "0x7B03E10", VA = "0x187B04E10")]
	private void DPJFIEFICNI([In] BKFAAPBAEGE IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7B176C0", Offset = "0x7B166C0", VA = "0x187B176C0")]
	private float NIBIOOMECLK(float DADKAHMKKBE, [In] BKFAAPBAEGE IDAKFFICKHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B03720", Offset = "0x7B02720", VA = "0x187B03720")]
	private void CEPHKCOJIEF(float DADKAHMKKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B046A0", Offset = "0x7B036A0", VA = "0x187B046A0")]
	private void DMFMFCOCDEK([In] BKFAAPBAEGE IDAKFFICKHC, HEIAFJCBLJB IJHMKNOGOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B084F0", Offset = "0x7B074F0", VA = "0x187B084F0")]
	private float GDFMHEJMMKN([In] BKFAAPBAEGE FDHOMNINNFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A30", Offset = "0x7B06A30", VA = "0x187B07A30")]
	private void FNOCILEKDFN(BKFAAPBAEGE IDAKFFICKHC, HEIAFJCBLJB IJHMKNOGOAN, Vector3 BLGLDDKBMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B05A60", Offset = "0x7B04A60", VA = "0x187B05A60")]
	private static void ECJOBGHNBOK(Transform KOOMPFGMBLG, Quaternion OOBEGCNALKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B03E80", Offset = "0x7B02E80", VA = "0x187B03E80")]
	private void CLMOKIGLMFB([In] BKFAAPBAEGE JOIIFDKKKIE, [In] OLDCJKMFKKN DODBKCGLJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B0A1F0", Offset = "0x7B091F0", VA = "0x187B0A1F0")]
	private void HLBIMGLNEEI([In] BKFAAPBAEGE JOIIFDKKKIE, [In] OLDCJKMFKKN DODBKCGLJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B15ED0", Offset = "0x7B14ED0", VA = "0x187B15ED0")]
	private void MLIOLAMKCAF(float HADKMGNGIIG, [In] BKFAAPBAEGE FDHOMNINNFB, float KMDPGOPNPAM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B166A0", Offset = "0x7B156A0", VA = "0x187B166A0")]
	private float MNOHIHEPKPH([In] BKFAAPBAEGE FDHOMNINNFB, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B07280", Offset = "0x7B06280", VA = "0x187B07280")]
	private void ELOHIOGEFMC([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B067C0", Offset = "0x7B057C0", VA = "0x187B067C0")]
	private void EIONBJCOEAE([In] BKFAAPBAEGE FDHOMNINNFB, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7B03030", Offset = "0x7B02030", VA = "0x187B03030")]
	private void BKLNHKBDNCC([In] BKFAAPBAEGE FDHOMNINNFB, float ENFPGPOONLD, float DLDCPMNBMDP, Vector3 HJBEKDOHMKF, float KMDPGOPNPAM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7B14C70", Offset = "0x7B13C70", VA = "0x187B14C70")]
	private void LLKBOHPFNCN(BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B115E0", Offset = "0x7B105E0", VA = "0x187B115E0")]
	private void LCCEGCLEJEI(BKFAAPBAEGE IDAKFFICKHC, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B19B40", Offset = "0x7B18B40", VA = "0x187B19B40")]
	private void PLFEDPGCJMI(BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B08230", Offset = "0x7B07230", VA = "0x187B08230")]
	public void FNPLFBOIELG([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7B18770", Offset = "0x7B17770", VA = "0x187B18770")]
	public void OKCGGPJMFKG([In] BKFAAPBAEGE IDAKFFICKHC, [In] AvatarFullBodyConfiguration NFFGNPJGBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B15CA0", Offset = "0x7B14CA0", VA = "0x187B15CA0")]
	[CompilerGenerated]
	internal static void MHOIOKGGINI(Transform KIDPOMGFMKB, IKSolverVR.Arm KMLBDKANGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7B190D0", Offset = "0x7B180D0", VA = "0x187B190D0")]
	[CompilerGenerated]
	internal static void OPBDNBIDLOG(Vector3 BMBKJBKLNIB, Vector3 KMCJLPDGMDA, FEHLLDHDPFO P_2, HIEFNMDKHPH P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B12330", Offset = "0x7B11330", VA = "0x187B12330")]
	[CompilerGenerated]
	internal static void LHJFOPLAEKA(HBJMJMJHGGJ JLNFDGMNHDM, HBJMJMJHGGJ GLPLDKAKOFI, Vector3 CKDNKLDAIAB, float JHEMEKBLBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B0E570", Offset = "0x7B0D570", VA = "0x187B0E570")]
	[CompilerGenerated]
	internal static bool KGOOFFPBOMK(IKSolverVR.Arm KMLBDKANGGL, GDMIHKFKLMH NGNHNPHIJOK, float AIMBGIEBEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B19280", Offset = "0x7B18280", VA = "0x187B19280")]
	[CompilerGenerated]
	internal static float PAGIJOGHCGA(Vector3 JFPOLFGLBDM, Vector3 DMIFICFHEOI, Vector3 HNNHIEBJCJB, BKFAAPBAEGE FDHOMNINNFB, AvatarFullBodyConfiguration NFFGNPJGBOO, float LLPAIMMACAP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class FMNBNNMCNPJ : JACLIHLEMAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Dictionary<string, BAAPGEGHOGM> GHBKJDKBDPA;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7B24D10", Offset = "0x7B23D10", VA = "0x187B24D10")]
	[AOJMKBDAFKB.IKKICAJLINL]
	internal static void JMCKCPCEAJJ(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7B24FD0", Offset = "0x7B23FD0", VA = "0x187B24FD0", Slot = "4")]
	public BAAPGEGHOGM PFHELEOHDCA(string NECIOMIMGKD, AvatarSystemConfiguration CMHGCKDMJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7B24DF0", Offset = "0x7B23DF0", VA = "0x187B24DF0", Slot = "5")]
	public void NMFFIGNDNCP(string NECIOMIMGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7B251F0", Offset = "0x7B241F0", VA = "0x187B251F0", Slot = "6")]
	public string PMDODNHPLDN(string BMHHPAIDCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7B24D80", Offset = "0x7B23D80", VA = "0x187B24D80")]
	private string NLKMEOLJFAG(string BMHHPAIDCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7B25330", Offset = "0x7B24330", VA = "0x187B25330")]
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
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private Dictionary<string, Transform> ONJHBHMPBOE;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool NOJJAOAIMCB
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x7B25610", Offset = "0x7B24610", VA = "0x187B25610")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7B25490", Offset = "0x7B24490", VA = "0x187B25490")]
			public void BBHPEHLDGLO(VRIK EHGKDCMDLEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
			public void JGJJMPCGBHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7B255C0", Offset = "0x7B245C0", VA = "0x187B255C0")]
			public void KGPJOLOPJJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7B25650", Offset = "0x7B24650", VA = "0x187B25650")]
			public GKPDCAENGDA()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[JFJLIIJLCAB(JINCPHMLLKA.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly GKPDCAENGDA DPIPNCMHEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private HFKIKIIPDMF FJPDGCGFEHB;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E4E0", Offset = "0x7B1D4E0", VA = "0x187B1E4E0")]
		private void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E7C0", Offset = "0x7B1D7C0", VA = "0x187B1E7C0")]
		private bool GGMEKDFHJEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E810", Offset = "0x7B1D810", VA = "0x187B1E810")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E880", Offset = "0x7B1D880", VA = "0x187B1E880")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E820", Offset = "0x7B1D820", VA = "0x187B1E820")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EAF0", Offset = "0x7B1DAF0", VA = "0x187B1EAF0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7B27110", Offset = "0x7B26110", VA = "0x187B27110")]
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
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7B26800", Offset = "0x7B25800", VA = "0x187B26800")]
			public void EEBICEODLFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7B268E0", Offset = "0x7B258E0", VA = "0x187B268E0")]
			public (float, float) PFNFLKNLEEE(Animator FGOJMFPPJBI, AnimatorStateInfo JBHBDBBFEAP)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7B26A20", Offset = "0x7B25A20", VA = "0x187B26A20")]
		public void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7B26C10", Offset = "0x7B25C10", VA = "0x187B26C10")]
		public (float, float) KKJKAAFIDEN(Animator FGOJMFPPJBI, FKMOHDFJKCD PCLHDOBKGMJ, float AKKDDCLLFHA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7B26E50", Offset = "0x7B25E50", VA = "0x187B26E50")]
		private (float, float) PBBFHPHENMN(Animator FGOJMFPPJBI, AnimatorStateInfo JBHBDBBFEAP, FKMOHDFJKCD PCLHDOBKGMJ, float AKKDDCLLFHA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7B27100", Offset = "0x7B26100", VA = "0x187B27100")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7B28140", Offset = "0x7B27140", VA = "0x187B28140", Slot = "4")]
		public override void OnStateEnter(Animator FGOJMFPPJBI, AnimatorStateInfo JBHBDBBFEAP, int HBNFAFEHMLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7B282B0", Offset = "0x7B272B0", VA = "0x187B282B0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class LMKPELOOABO<TInput, TOutput> : OLMHCHJOBOD<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected readonly ABHKBFFIJLO KPKDGGHCPAF;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x51270A0", Offset = "0x51260A0", VA = "0x1851270A0")]
	protected LMKPELOOABO(ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput AKDPGDCBDMI(TInput HPLMFDGMJFE, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5127000", Offset = "0x5126000", VA = "0x185127000", Slot = "5")]
	public bool EDMAKJIKLMC(TInput HPLMFDGMJFE, [Out] TOutput? OBOOAPELMPF, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HJNCDIOGCJG]
public static class AOPBBLANAAA
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly Regex KKENPPFNLNC;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7B1D6A0", Offset = "0x7B1C6A0", VA = "0x187B1D6A0")]
	public static BAENJCCJOCI EDBFABDFNGE(PJDNIEDEHFC MONOBEAOLBH, DHMNCODBNBK HAAMPPLFBEG, Guid? DGPIPOJOJGM, Color? CHCKIPOAJCK, LEMFDNDBDJC BDNPFHIBMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7B1D540", Offset = "0x7B1C540", VA = "0x187B1D540")]
	public static KEEOBDBOKHK EAIHNFCIGOL(BAENJCCJOCI APDBNIMCPID)
	{
		return default(KEEOBDBOKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3F71820", Offset = "0x3F70820", VA = "0x183F71820")]
	internal static TModern? HDMMMKEACBD<TModern>(string? HPLMFDGMJFE, JNCCJLHKFDA<TModern> DMOEALABEHK, ABHKBFFIJLO KPKDGGHCPAF, OGAHGIMAJLK CHBMNCOOIEN, TModern FKEHMADKJKF) where TModern : struct, AKFPMLPANDI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3F71040", Offset = "0x3F70040", VA = "0x183F71040")]
	internal static GNDBKEBKKKN FBHFOEJDJJO<TModern>(string? HPLMFDGMJFE, JNCCJLHKFDA<TModern> DMOEALABEHK, ABHKBFFIJLO KPKDGGHCPAF, OGAHGIMAJLK CHBMNCOOIEN, TModern FKEHMADKJKF) where TModern : struct, AKFPMLPANDI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B1D8B0", Offset = "0x7B1C8B0", VA = "0x187B1D8B0")]
	internal static List<GIPABNFHILC> PMNPCAEINKH(IEnumerable<HIPIMHFHIGB>? CBOLBPFMLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3F72E70", Offset = "0x3F71E70", VA = "0x183F72E70")]
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
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> GKNAPDPPFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> FGCBEIHKOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CHGBFFPHBCL ODGOMOIFKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PPCLOIEDJJJ ICOEDJMKBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7B27650", Offset = "0x7B26650", VA = "0x187B27650")]
	[UsedImplicitly]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void MADPONIHLIN(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7B276C0", Offset = "0x7B266C0", VA = "0x187B276C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KNOPJCBNDEA([DJIFKCCBBND("UnitySerialization")] DANGHPLHCHI LDMLFEILEFC, [DJIFKCCBBND(null)] POAKPCMKJOA ABPDFJDNHFE, [DJIFKCCBBND(null)] ABHKBFFIJLO KPKDGGHCPAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DJKNOBEMALE
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GGOPEIFOMDM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7B253F0", Offset = "0x7B243F0", VA = "0x187B253F0")]
	public GGOPEIFOMDM(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7B25460", Offset = "0x7B24460", VA = "0x187B25460")]
	public GGOPEIFOMDM(string NAAMEAFIHJI, Exception HBNIOKPNOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7B253C0", Offset = "0x7B243C0", VA = "0x187B253C0")]
	public GGOPEIFOMDM(DJKNOBEMALE DAOAPLFBLDC, string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7B25420", Offset = "0x7B24420", VA = "0x187B25420")]
	public GGOPEIFOMDM(DJKNOBEMALE DAOAPLFBLDC, string NAAMEAFIHJI, Exception HBNIOKPNOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class BMBHFFBEOND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly DANGHPLHCHI LDMLFEILEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly POAKPCMKJOA ABPDFJDNHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly ABHKBFFIJLO KPKDGGHCPAF;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7B20530", Offset = "0x7B1F530", VA = "0x187B20530")]
	protected BMBHFFBEOND(DANGHPLHCHI LDMLFEILEFC, POAKPCMKJOA ABPDFJDNHFE, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F220", Offset = "0x7B1E220", VA = "0x187B1F220")]
	protected string JHODCHDNPNI(MAKBECHNCGC MNFOAJDGMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7B1ED10", Offset = "0x7B1DD10", VA = "0x187B1ED10")]
	protected string CKAMECBLGMC(MAKBECHNCGC MNFOAJDGMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7B1EEF0", Offset = "0x7B1DEF0", VA = "0x187B1EEF0")]
	private AvatarOutfitSelectionData EDBFABDFNGE(BAENJCCJOCI KMJIGOCPILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7B1EBD0", Offset = "0x7B1DBD0", VA = "0x187B1EBD0")]
	private static AvatarCustomizationSettingsData.AnchorParams BBDOIAOKBBH(HMAKLDEGKBC? OGABAGJHKNB)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OLMHCHJOBOD<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput AKDPGDCBDMI(TInput HPLMFDGMJFE, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EDMAKJIKLMC(TInput HPLMFDGMJFE, [Out] TOutput? OBOOAPELMPF, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PLLJPLIPBAF
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OLMHCHJOBOD<JPHMOLEBDKN, MAKBECHNCGC> LOHBCIEHAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> FGCBEIHKOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CHGBFFPHBCL ODGOMOIFKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum OGAHGIMAJLK
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PPCLOIEDJJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIMFOIMANHI DFNAEDFOBIJ(MAKBECHNCGC APDBNIMCPID);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CHGBFFPHBCL
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBEOFKNNOOM DFNAEDFOBIJ(MAKBECHNCGC APDBNIMCPID, int LKOLHBGNLLI, string? NFHOBPDKIPM, string? POLFGBPDKII, GGBJCIFEEKL MPCIGGLFCOI, List<GIPABNFHILC>? GLELOIJPLDA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[HJNCDIOGCJG]
internal class KIMFMCJCCGH : LMKPELOOABO<JPHMOLEBDKN, MAKBECHNCGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly POAKPCMKJOA ABPDFJDNHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly DCKNCGFAFJO LJIJGHEOFMK;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7B27480", Offset = "0x7B26480", VA = "0x187B27480")]
	public KIMFMCJCCGH(DANGHPLHCHI LDMLFEILEFC, POAKPCMKJOA ABPDFJDNHFE, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7B271D0", Offset = "0x7B261D0", VA = "0x187B271D0", Slot = "6")]
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
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7B25800", Offset = "0x7B24800", VA = "0x187B25800", Slot = "9")]
		public override void WriteJson(JsonWriter NFOCFJIIPHM, GNDBKEBKKKN? OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7B256E0", Offset = "0x7B246E0", VA = "0x187B256E0", Slot = "10")]
		public override GNDBKEBKKKN ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, GNDBKEBKKKN? ELCIIJEPMCL, bool BKBDGNCEMML, JsonSerializer AKEPDIDIPNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7B258A0", Offset = "0x7B248A0", VA = "0x187B258A0")]
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
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B28000", Offset = "0x7B27000", VA = "0x187B28000", Slot = "5")]
		public override object ReadJson(JsonReader HBMFONPEIJC, Type GENJGIKLGPB, object? ELCIIJEPMCL, JsonSerializer AKEPDIDIPNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7B27C20", Offset = "0x7B26C20", VA = "0x187B27C20", Slot = "6")]
		public override bool CanConvert(Type GENJGIKLGPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7B28060", Offset = "0x7B27060", VA = "0x187B28060", Slot = "4")]
		public override void WriteJson(JsonWriter NFOCFJIIPHM, object? OHLIHBDBKCE, JsonSerializer AKEPDIDIPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B27E00", Offset = "0x7B26E00", VA = "0x187B27E00")]
		private static bool JKHLLOCGHIB(object OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public LIDGPOPLACF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly JsonSerializerSettings OHPJOMKGGBN;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7B266A0", Offset = "0x7B256A0", VA = "0x187B266A0")]
	internal HLCOCAJDBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x386A690", Offset = "0x3869690", VA = "0x18386A690", Slot = "4")]
	public string ELEEPPJEPCO<T>(T BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x386A6F0", Offset = "0x38696F0", VA = "0x18386A6F0", Slot = "5")]
	public T MDICJHFJMDI<T>(string OHLIHBDBKCE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class POLBGPAENAA : DANGHPLHCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x39F67D0", Offset = "0x39F57D0", VA = "0x1839F67D0", Slot = "4")]
	public string ELEEPPJEPCO<T>(T BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x39F6850", Offset = "0x39F5850", VA = "0x1839F6850", Slot = "5")]
	public T MDICJHFJMDI<T>(string OHLIHBDBKCE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public POLBGPAENAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HJNCDIOGCJG]
internal class DCKNCGFAFJO : LMKPELOOABO<MBEOFKNNOOM, AGDKHFDLFEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly DANGHPLHCHI LDMLFEILEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly POAKPCMKJOA ABPDFJDNHFE;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7B24210", Offset = "0x7B23210", VA = "0x187B24210")]
	public DCKNCGFAFJO(DANGHPLHCHI LDMLFEILEFC, POAKPCMKJOA ABPDFJDNHFE, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7B21D90", Offset = "0x7B20D90", VA = "0x187B21D90", Slot = "6")]
	public override AGDKHFDLFEH AKDPGDCBDMI(MBEOFKNNOOM HPLMFDGMJFE, [Out] IReadOnlyList<GIPABNFHILC>? GLELOIJPLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7B240C0", Offset = "0x7B230C0", VA = "0x187B240C0")]
	internal void PNNBCOLBGOK(string DAMLLFNDABK, MAKBECHNCGC MNFOAJDGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7B224C0", Offset = "0x7B214C0", VA = "0x187B224C0")]
	public IEnumerable<BAENJCCJOCI> EJNLHCCEFMA(string GPFOJBECLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7B229E0", Offset = "0x7B219E0", VA = "0x187B229E0")]
	private IEnumerable<BAENJCCJOCI> GMDDAGCHELB(string GPFOJBECLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7B22570", Offset = "0x7B21570", VA = "0x187B22570")]
	internal IEnumerable<BAENJCCJOCI> FDECFLOOFHL(string GPFOJBECLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7B23170", Offset = "0x7B22170", VA = "0x187B23170")]
	private BAENJCCJOCI OIEMKEMFHGG(AvatarOutfitSelectionData OKGIFFJFICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B23820", Offset = "0x7B22820", VA = "0x187B23820")]
	private void PLMJPLPIGJG(AvatarCustomizationSettingsData ENMKPKEIKGL, MAKBECHNCGC MNFOAJDGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7B23500", Offset = "0x7B22500", VA = "0x187B23500")]
	private BAENJCCJOCI OIEMKEMFHGG(string BCLPLNFCBNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7B221C0", Offset = "0x7B211C0", VA = "0x187B221C0")]
	internal static (LEMFDNDBDJC, string, string) BHIDPCCLDNM(string BCLPLNFCBNC, ABHKBFFIJLO KPKDGGHCPAF)
	{
		return default((LEMFDNDBDJC, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B22F70", Offset = "0x7B21F70", VA = "0x187B22F70")]
	private ECEBIFEBOFL? NLIOHHNLJEK(string? DGNNPFFMIEE, Vector2 MKBIPJMOOAN, float EIIHOPBEFCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7B22E10", Offset = "0x7B21E10", VA = "0x187B22E10")]
	private static HMAKLDEGKBC HKBPHCOGCNM(AvatarCustomizationSettingsData.AnchorParams MJOPHNIAFAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HJNCDIOGCJG]
internal class PIPJHIJMPBM : BMBHFFBEOND, PPCLOIEDJJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7B20530", Offset = "0x7B1F530", VA = "0x187B20530")]
	public PIPJHIJMPBM(DANGHPLHCHI LDMLFEILEFC, POAKPCMKJOA ABPDFJDNHFE, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7B28560", Offset = "0x7B27560", VA = "0x187B28560", Slot = "4")]
	public EIMFOIMANHI DFNAEDFOBIJ(MAKBECHNCGC APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7B28910", Offset = "0x7B27910", VA = "0x187B28910")]
	private string GONEHFPEDLB(MAKBECHNCGC MNFOAJDGMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7B28A10", Offset = "0x7B27A10", VA = "0x187B28A10")]
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
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly DANGHPLHCHI LDMLFEILEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> ADFCJLGMDIM;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B24780", Offset = "0x7B23780", VA = "0x187B24780")]
	public EKGJELGHDGK(OLMHCHJOBOD<MBEOFKNNOOM, AGDKHFDLFEH> ADFCJLGMDIM, ABHKBFFIJLO KPKDGGHCPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7B24350", Offset = "0x7B23350", VA = "0x187B24350", Slot = "6")]
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
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly DANGHPLHCHI LDMLFEILEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly PPCLOIEDJJJ LIKCICMJKMA;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7B24C20", Offset = "0x7B23C20", VA = "0x187B24C20")]
	public FGLPPGGIOLL(PPCLOIEDJJJ LIKCICMJKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7B24880", Offset = "0x7B23880", VA = "0x187B24880", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7B1DB50", Offset = "0x7B1CB50", VA = "0x187B1DB50")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NGAKKJFEAFK
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7B28330", Offset = "0x7B27330", VA = "0x187B28330")]
	public static KEEOBDBOKHK AKDPGDCBDMI(this BJLONKHHECM APDBNIMCPID)
	{
		return default(KEEOBDBOKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7B28440", Offset = "0x7B27440", VA = "0x187B28440")]
	public static BJLONKHHECM DFNAEDFOBIJ(this KEEOBDBOKHK BNOFDCLPOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7B282D0", Offset = "0x7B272D0", VA = "0x187B282D0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x5C35010", Offset = "0x5C34010", VA = "0x185C35010")]
			public AnchorParams(Vector2 AFLACKAFDJB, Vector3 LGAJDNIMLAA, Vector3 GILNNGGNLNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x7B1DAA0", Offset = "0x7B1CAA0", VA = "0x187B1DAA0")]
			internal HMAKLDEGKBC DFNAEDFOBIJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private OJELMNHDJHH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E380", Offset = "0x7B1D380", VA = "0x187B1E380")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x50A3FC0", Offset = "0x50A2FC0", VA = "0x1850A3FC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xF2D890", Offset = "0xF2C890", VA = "0x180F2D890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x12AA110", Offset = "0x12A9110", VA = "0x1812AA110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E430", Offset = "0x7B1D430", VA = "0x187B1E430")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9F6800", Offset = "0x9F5800", VA = "0x1809F6800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xBFBC10", Offset = "0xBFAC10", VA = "0x180BFBC10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xBFB9F0", Offset = "0xBFA9F0", VA = "0x180BFB9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E470", Offset = "0x7B1D470", VA = "0x187B1E470")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xE16470", Offset = "0xE15470", VA = "0x180E16470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x10ABFF0", Offset = "0x10AAFF0", VA = "0x1810ABFF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x172BCF0", Offset = "0x172ACF0", VA = "0x18172BCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x225A320", Offset = "0x2259320", VA = "0x18225A320")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xE31080", Offset = "0xE30080", VA = "0x180E31080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA269D0", Offset = "0xA259D0", VA = "0x180A269D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA26A30", Offset = "0xA25A30", VA = "0x180A26A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9F9180", Offset = "0x9F8180", VA = "0x1809F9180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9F9080", Offset = "0x9F8080", VA = "0x1809F9080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9F9100", Offset = "0x9F8100", VA = "0x1809F9100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F7FF0", VA = "0x1809F8FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xBDE270", Offset = "0xBDD270", VA = "0x180BDE270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x12CD960", Offset = "0x12CC960", VA = "0x1812CD960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9F9040", Offset = "0x9F8040", VA = "0x1809F9040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F9050", Offset = "0x9F8050", VA = "0x1809F9050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xCC02E0", Offset = "0xCBF2E0", VA = "0x180CC02E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xE32260", Offset = "0xE31260", VA = "0x180E32260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4A0", Offset = "0x9FB4A0", VA = "0x1809FC4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9FC4C0", Offset = "0x9FB4C0", VA = "0x1809FC4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xC0CEE0", Offset = "0xC0BEE0", VA = "0x180C0CEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xE430C0", Offset = "0xE420C0", VA = "0x180E430C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xC6D1F0", Offset = "0xC6C1F0", VA = "0x180C6D1F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xC68D80", Offset = "0xC67D80", VA = "0x180C68D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OJELMNHDJHH UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xF35670", Offset = "0xF34670", VA = "0x180F35670")]
			get
			{
				return default(OJELMNHDJHH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xF37310", Offset = "0xF36310", VA = "0x180F37310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xF34DA0", Offset = "0xF33DA0", VA = "0x180F34DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xBCCE90", Offset = "0xBCBE90", VA = "0x180BCCE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E450", Offset = "0x7B1D450", VA = "0x187B1E450")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E490", Offset = "0x7B1D490", VA = "0x187B1E490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B1DFE0", Offset = "0x7B1CFE0", VA = "0x187B1DFE0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public LEMFDNDBDJC BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private HDKFBPEELCJ? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E4B0", Offset = "0x7B1D4B0", VA = "0x187B1E4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
