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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x77C7250", Offset = "0x77C5C50", VA = "0x1877C7250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x77C72D0", Offset = "0x77C5CD0", VA = "0x1877C72D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OHBOADDCADD]
internal class EBCIBPCAIBB : LCEDGLFFHAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HBGHHMDFGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public EBCIBPCAIBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public PLCLOJBLHOK avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JPDLHLAEMCA HNAAKHDPJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NGLGPHCAONK PKEKMLLGNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DBIACDJFABC PMCNMEPOAIN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77C3D40", Offset = "0x77C2740", VA = "0x1877C3D40")]
	[EFEOGKEOEKD.IHENNBHNBPA.IFPBCNBMCDE]
	[UsedImplicitly]
	internal static void ENFEOOLNDHA(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77C4E50", Offset = "0x77C3850", VA = "0x1877C4E50")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EBCIBPCAIBB([GJJKIKPKKBJ(null)] JPDLHLAEMCA HNAAKHDPJHM, [GJJKIKPKKBJ(null)] NGLGPHCAONK PKEKMLLGNJE, [GJJKIKPKKBJ(null)] DBIACDJFABC PMCNMEPOAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x77C33A0", Offset = "0x77C1DA0", VA = "0x1877C33A0", Slot = "5")]
	public BKNOFPPIEOM DKICEPAANPB(PLCLOJBLHOK IMLEEPAJBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77C3FE0", Offset = "0x77C29E0", VA = "0x1877C3FE0", Slot = "4")]
	public BKNOFPPIEOM IBALBGHEPEO(PLCLOJBLHOK IMLEEPAJBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77C3DB0", Offset = "0x77C27B0", VA = "0x1877C3DB0", Slot = "6")]
	public JILIDANPOJK FEGCMBJCNNA(BKNOFPPIEOM DFPGGEDGGGN, int PICEKPEFJLJ, string? EMLAIMJKHOE, string? PEJHCKLJFMF, PHMNJENKGDJ OMMANJEFGMG, List<OEELFAFECOH>? GMEMBAMNEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x77C3EC0", Offset = "0x77C28C0", VA = "0x1877C3EC0", Slot = "7")]
	public bool GEDDFPAEELH(CKMKHMAKINF EDJJBENGGOE, [Out] BKNOFPPIEOM? NHBLKJOHPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77C3C60", Offset = "0x77C2660", VA = "0x1877C3C60", Slot = "8")]
	public bool DLLIIDLHEOO(JILIDANPOJK EMFGGMCNEIA, [Out] BKNOFPPIEOM? NHBLKJOHPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77C3F50", Offset = "0x77C2950", VA = "0x1877C3F50", Slot = "9")]
	public bool HBBCEEOPPLE(JILIDANPOJK EMFGGMCNEIA, [Out] IMHNOILOHNM? EDJJBENGGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x349FA50", Offset = "0x349E450", VA = "0x18349FA50")]
	private bool PNGPBBFLKJD<TInput, TOutput>(TInput OBMEHBOBMDK, IBGMJFKBDPK<TInput, TOutput> GALEDDDILBN, [Out] TOutput? FFBEKAFHIDB) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77C4AD0", Offset = "0x77C34D0", VA = "0x1877C4AD0")]
	[CompilerGenerated]
	private MFPLEIAOAAK JAANKKDCKBP(FaceFeatureType PIMBKPEKOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x77C4C70", Offset = "0x77C3670", VA = "0x1877C4C70")]
	[CompilerGenerated]
	private MFPLEIAOAAK NICJMOCCGKH(FaceFeatureType PIMBKPEKOPK, HBGHHMDFGDH P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OHBOADDCADD]
internal class JMMGCJFCKLL : JPDLHLAEMCA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void MHAPPBBMGFA<in TData>(TData NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NAPBGBOEOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public PFIGLPALHOJ rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ENJCIONGFPG currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ENJCIONGFPG latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NAPBGBOEOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x77C71B0", Offset = "0x77C5BB0", VA = "0x1877C71B0")]
		internal bool BOKBKIJCOPO(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x77C71D0", Offset = "0x77C5BD0", VA = "0x1877C71D0")]
		internal bool PDPKHDPEPMN(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DBIACDJFABC PMCNMEPOAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CDENNGLKHCJ DCGDAHBNIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MHAPPBBMGFA<BKNOFPPIEOM>?[] HNAAKHDPJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MHAPPBBMGFA<IMHNOILOHNM>?[] MOGLBLKEMDJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77C52B0", Offset = "0x77C3CB0", VA = "0x1877C52B0")]
	[EFEOGKEOEKD.IHENNBHNBPA.IFPBCNBMCDE]
	[UsedImplicitly]
	internal static void ENFEOOLNDHA(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77C6B50", Offset = "0x77C5550", VA = "0x1877C6B50")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JMMGCJFCKLL([GJJKIKPKKBJ(null)] DBIACDJFABC PMCNMEPOAIN, [GJJKIKPKKBJ(null)] CDENNGLKHCJ DCGDAHBNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77C63D0", Offset = "0x77C4DD0", VA = "0x1877C63D0", Slot = "4")]
	public bool LDPJPBMBJMK(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77C6270", Offset = "0x77C4C70", VA = "0x1877C6270", Slot = "5")]
	public bool LDPJPBMBJMK(IMHNOILOHNM EDJJBENGGOE, IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77C5350", Offset = "0x77C3D50", VA = "0x1877C5350")]
	private void FKCEFKLICLO(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77C6580", Offset = "0x77C4F80", VA = "0x1877C6580")]
	private void MGIIJLGKLIM(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77C6240", Offset = "0x77C4C40", VA = "0x1877C6240")]
	private void KDKLDFIBMFD(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77C6210", Offset = "0x77C4C10", VA = "0x1877C6210")]
	private void KCMHLDIGBNL(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77C6990", Offset = "0x77C5390", VA = "0x1877C6990")]
	private void OALEKNIPJKO(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77C6A60", Offset = "0x77C5460", VA = "0x1877C6A60")]
	private void OOMACAGAAHM(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77C64D0", Offset = "0x77C4ED0", VA = "0x1877C64D0")]
	private void LEFGKINIBEE(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77C67B0", Offset = "0x77C51B0", VA = "0x1877C67B0")]
	private void NMIFCNJCCMN(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77C5320", Offset = "0x77C3D20", VA = "0x1877C5320")]
	private void FHDILNGNCAD(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? FOAJJFFCIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77C4FD0", Offset = "0x77C39D0", VA = "0x1877C4FD0")]
	private void BNOONHOOCBE(BKNOFPPIEOM NHBLKJOHPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77C5F30", Offset = "0x77C4930", VA = "0x1877C5F30")]
	private BKNOFPPIEOM GMIHGBJIPKG(BKNOFPPIEOM NHBLKJOHPMC, List<RangeMigration> GLDPBNHAHPI, ENJCIONGFPG JKAGFEMEKIO, ENJCIONGFPG FGGOPNNMJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77C6B10", Offset = "0x77C5510", VA = "0x1877C6B10")]
	private float PHKFCCOCBDD(float KOKENJMMDFM, Vector2 GIKENJPBEED, Vector2 EIPABKEJCBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77C67C0", Offset = "0x77C51C0", VA = "0x1877C67C0")]
	private (RangeMigration?, RangeMigration?) NPAAJMCDAJK(List<RangeMigration> GLONONPLFFK, PFIGLPALHOJ NLINONDLDGB, ENJCIONGFPG JKAGFEMEKIO, ENJCIONGFPG FGGOPNNMJBN)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JPDLHLAEMCA
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LDPJPBMBJMK(BKNOFPPIEOM NHBLKJOHPMC, IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LDPJPBMBJMK(IMHNOILOHNM EDJJBENGGOE, IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME);
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
		public DLDPDKBIIJO AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x77A72D0", Offset = "0x77A5CD0", VA = "0x1877A72D0")]
		public void HABDBNLMFPF(AnimationPoseSetting OLKLGHOAKNE, float GLBJAMOOJPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x77A7400", Offset = "0x77A5E00", VA = "0x1877A7400")]
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
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x77A7CF0", Offset = "0x77A66F0", VA = "0x1877A7CF0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x77A7CB0", Offset = "0x77A66B0", VA = "0x1877A7CB0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x77A7420", Offset = "0x77A5E20", VA = "0x1877A7420")]
		private void KCLLNAEGDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7736E50", Offset = "0x7735850", VA = "0x187736E50", Slot = "4")]
		public void SetEnabled(bool PLGFLNLCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x77A7D20", Offset = "0x77A6720", VA = "0x1877A7D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x77A7D60", Offset = "0x77A6760", VA = "0x1877A7D60")]
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
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
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
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
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
		[Range(0.01f, 10f)]
		[Header("Performance Tuning")]
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
		[Cpp2IlInjected.Address(RVA = "0x77A7DE0", Offset = "0x77A67E0", VA = "0x1877A7DE0")]
		public AnimationPoseSetting OGNDBEBOAMN(DLDPDKBIIJO FMOLCEAPLAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x77A7DA0", Offset = "0x77A67A0", VA = "0x1877A7DA0")]
		public void JCFABLNPBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x77A7E10", Offset = "0x77A6810", VA = "0x1877A7E10")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum DIMJOFKENGD
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private DIMJOFKENGD handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x77A88C0", Offset = "0x77A72C0", VA = "0x1877A88C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x77A8880", Offset = "0x77A7280", VA = "0x1877A8880")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77A8280", Offset = "0x77A6C80", VA = "0x1877A8280")]
		private void KCLLNAEGDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7736E50", Offset = "0x7735850", VA = "0x187736E50", Slot = "4")]
		public void SetEnabled(bool PLGFLNLCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77A88F0", Offset = "0x77A72F0", VA = "0x1877A88F0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, IBCMALGGFMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		[Header("Configuration")]
		private PLCLOJBLHOK avatarBodyType;

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
		[JNJDEHPMCEK(PLKNMOLBJIE.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
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
		[Header("Watch")]
		[SerializeField]
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
		[Header("Equipment Slots")]
		[SerializeField]
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
		private FIJBBFCDCMP HHGKOCKNBJG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public FIJBBFCDCMP OCAGLIPONEP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA29BD0", Offset = "0xA285D0", VA = "0x180A29BD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform MKEKFONHJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x77A96E0", Offset = "0x77A80E0", VA = "0x1877A96E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77A8920", Offset = "0x77A7320", VA = "0x1877A8920")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x77A95A0", Offset = "0x77A7FA0", VA = "0x1877A95A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x77A9550", Offset = "0x77A7F50", VA = "0x1877A9550")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x77A94E0", Offset = "0x77A7EE0", VA = "0x1877A94E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77A8920", Offset = "0x77A7320", VA = "0x1877A8920", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77A8CB0", Offset = "0x77A76B0", VA = "0x1877A8CB0", Slot = "6")]
		public FIJBBFCDCMP CreateAvatarSystem(string HLIBGODHLGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77A94E0", Offset = "0x77A7EE0", VA = "0x1877A94E0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77A89E0", Offset = "0x77A73E0", VA = "0x1877A89E0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x77A95F0", Offset = "0x77A7FF0", VA = "0x1877A95F0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float GFOGDPEAFLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DLFNAFDGAEA : FIJBBFCDCMP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class BHJAPHCABOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3 BGGICECMBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Quaternion ANJNHADDMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 PHNGGHPOMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Transform DFCDMNOGPBI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 PBDKBIDIFJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9010", Offset = "0x1DF7A10", VA = "0x181DF9010")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9030", Offset = "0x1DF7A30", VA = "0x181DF9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion FKPGIBODDIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x128ACC0", Offset = "0x12896C0", VA = "0x18128ACC0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x128AA40", Offset = "0x1289440", VA = "0x18128AA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float OAEFOGBBHAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x10069E0", Offset = "0x10053E0", VA = "0x1810069E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x164CBB0", Offset = "0x164B5B0", VA = "0x18164CBB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool LBPIICPLMCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9B21A0", Offset = "0x9B0BA0", VA = "0x1809B21A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9B22A0", Offset = "0x9B0CA0", VA = "0x1809B22A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool DPDDOOHGOPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9B2260", Offset = "0x9B0C60", VA = "0x1809B2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9B22B0", Offset = "0x9B0CB0", VA = "0x1809B22B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool NAJKOPGFMIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9B2290", Offset = "0x9B0C90", VA = "0x1809B2290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9B2280", Offset = "0x9B0C80", VA = "0x1809B2280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float CCOHKGLIGFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xBFFBA0", Offset = "0xBFE5A0", VA = "0x180BFFBA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xC00A70", Offset = "0xBFF470", VA = "0x180C00A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x77C8A50", Offset = "0x77C7450", VA = "0x1877C8A50")]
		public void IADIADPEMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x77C86E0", Offset = "0x77C70E0", VA = "0x1877C86E0")]
		public void BHIANLGBMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x77C86F0", Offset = "0x77C70F0", VA = "0x1877C86F0")]
		public float CAGMKKDOKCP(Vector3 PDIMBAPNJFK, Quaternion OBDMHFMLKKF, [In] AvatarFootSettings OJGDKKFHAGJ, float GNGOMENKIMG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x77C8A60", Offset = "0x77C7460", VA = "0x1877C8A60")]
		public void JCMFNLGJBJO(Vector3 CJPBEMJCGDG, Quaternion NEPHHIJDODM, Transform ILLGCGKGNBF, float NFFIAMKPFHK, bool NONAMMGBBII, bool DHPBKNIMCJH, float LAHKODGLLBN, float GNJHGDKNJBM, Transform MHHKOMDGDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x77C9130", Offset = "0x77C7B30", VA = "0x1877C9130")]
		public void JFGCPKBEAOH(Transform NCOFLMFDGGP, Transform MHHKOMDGDID, bool GJPINENPHDH, bool BNKLIGLLAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x77C9380", Offset = "0x77C7D80", VA = "0x1877C9380")]
		private void PLOOOGCCINH(Transform MHHKOMDGDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x77C8900", Offset = "0x77C7300", VA = "0x1877C8900")]
		public void HJCDLJNKAGM(Transform MHHKOMDGDID, AvatarFullBodyConfiguration MOAPPBPCBJG, Vector3 EIKMBNGNEMM, float ECKMPEGEDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x77C9360", Offset = "0x77C7D60", VA = "0x1877C9360")]
		public void OLCHFNDBLMA(float GNJHGDKNJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x77C9480", Offset = "0x77C7E80", VA = "0x1877C9480")]
		public BHJAPHCABOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class JNABLPLDKDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float MEPPMAHIGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool HPDGKFAIDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AnimationPoseSetting FKBENOHLJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float CLHOBFLDJMB;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x77CF070", Offset = "0x77CDA70", VA = "0x1877CF070")]
		public void OKPPNPCJMCD(IKSolverVR.Arm FFPGNGEIFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x77CEA30", Offset = "0x77CD430", VA = "0x1877CEA30")]
		public void GHDMKJELGBO(IKSolverVR.Arm FFPGNGEIFML, float CNPLKMFONMD, bool HPDGKFAIDIM, AvatarFullBodyConfiguration MOAPPBPCBJG, float IMBJMPJOKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x77CDA40", Offset = "0x77CC440", VA = "0x1877CDA40")]
		private void ANOOKLJABHH(IKSolverVR.Arm FFPGNGEIFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x77CE1C0", Offset = "0x77CCBC0", VA = "0x1877CE1C0")]
		public void DKBPIJEPEOH(IKSolverVR.Arm FFPGNGEIFML, Transform INAANIKIALG, Transform ILLGCGKGNBF, Quaternion AKFNHFHPCEF, Vector3 LIFMBBHFBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x77CE5A0", Offset = "0x77CCFA0", VA = "0x1877CE5A0")]
		private (Vector3, Quaternion) EKOHMNEBPJB(MOGLLAJNJHN PNPJEHCLDOM, Quaternion JBAIHHGKMCC, Vector3 EPAGPNDGKDL)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x77CDBC0", Offset = "0x77CC5C0", VA = "0x1877CDBC0")]
		public void COJPMOPHCAP(MOGLLAJNJHN PNPJEHCLDOM, IKSolverVR.Arm FFPGNGEIFML, Quaternion JBAIHHGKMCC, Vector3 EPAGPNDGKDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x77CEA70", Offset = "0x77CD470", VA = "0x1877CEA70")]
		public void IAEBLLNELLN(MOGLLAJNJHN PNPJEHCLDOM, IKSolverVR.Arm FFPGNGEIFML, Quaternion JBAIHHGKMCC, Vector3 EPAGPNDGKDL, [In] AvatarFullBodyConfiguration MOAPPBPCBJG, [In] AIOLAPCBOAN JCFJJCIGDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x77CDA80", Offset = "0x77CC480", VA = "0x1877CDA80")]
		public void CFCODIMMNKH(DLDPDKBIIJO IMAFOJMPHKO, AvatarFullBodyConfiguration MOAPPBPCBJG, AIOLAPCBOAN JCFJJCIGDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x77CDD20", Offset = "0x77CC720", VA = "0x1877CDD20")]
		public void DCKLIMNPLEO(IKSolverVR.Arm FFPGNGEIFML, Transform INAANIKIALG, Vector3 PALNEDOKFKA, float HICCMAGLJBH, Quaternion IKAHDBPCBLN, Vector3 BNNMABOOJHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x77CF0A0", Offset = "0x77CDAA0", VA = "0x1877CF0A0")]
		public JNABLPLDKDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum AEKNOBMIAOO
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
	private struct NLKHBNJFONK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct EJLHLCJFKEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int PEBMPFFOPLK;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int IMHCNEAAPEL;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int DOEBBMJPBFG;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int JGMJNICDAHG;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int NHMIALAEDMO;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int EMDFAFJNAPB;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int IAEGNEJNBBM;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int PCMJJOICECO;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int MAMPBDDLAJC;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int PDMGFMBLFEK;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int HAOBHCHMAND;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int BFJAAEPKLBB;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int PJHLNHHKEHF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int JJPGIGMNGLJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int EMACIFDLGCI;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int FOCJPPHALLJ;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int CBPLPAIHKFG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int FCODJFKDGPG;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int HELCJPHANOI;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int GDNJFCOGFFE;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int MPLMIEICJGF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int IEPCKMMEBLD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int BDCMEKOOKIP;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int LHPFDEBDKCK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int ELIEBHDPHDK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int JMEMMMKMNPA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int JBLFDOKBPGP;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int IGEKJMBIINN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int BEACMCHJFOB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int JFONANJEJCD;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int KKIPPJBNBAI;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 ILADGHPBGLO;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int PGJOBMONFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool DBMBCADPNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool JGDKEKNPHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool OLMDHKLNDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool IMCNGCFHCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool LDJOHMPMBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool GJKPHGNKMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Vector3 LKJJBINLAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private string KIICFLEHEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FJLCAPPLAMJ? NJKONJOLPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private DHJNHNNNKLG? DNFBEMONGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private CPCDHCNGPGN GDCMHMNPFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GHDBNHIGCGP GGIBKCDEIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MOGLLAJNJHN OEBFHNOIKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private MOGLLAJNJHN LGEOGJPNFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool MIKLMONKBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool LNNNLLFJCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly MGAHDGIDOIB AAIPMDLIKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly GDAACOMINCN HKMIPELIHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int FKEMLLNIFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float GGAOCFAODBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private GameObject MLJGJCMFPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform EMGCLHIGGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform HOOMBMACDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform JFGCHBDDMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform KHJBDBOHDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float LHBPHGKOGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float EEEAFBDALBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 HLHJEMMNAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Quaternion HENPAKPFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform AMDHJFHLOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform GNJEAFKHALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform CIGEENOOMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private LHBJICFFJIO NOLLDDBEHJB;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker BCAKKDFOMII;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker AMMILEIHKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker KFDDNGIPMKO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker AHOMJKMONJA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker PMEDMHAGELF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker IFBDEFMDENG;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<DLFNAFDGAEA> GOONGOAMLLI;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int GKNAMBGGKMG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> BNLMJBJOBOH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int DLEAELMDFPD;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int PGBDDGKLGNE;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int CNCDMHAPKEG;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int FBPAFLDMGNL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float ADOEAAEAMIG;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int LDNBPNPFPLH;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float JDMPCOALOFG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float OHFCECENGNK;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float OLJBAABBJEE;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float MENIIMKFABL;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static EGLMPDCLHMN EEEEFGOOCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float DNHJHNDOJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool KAPNIMBLEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float GIOKKONMBLN;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int MEHCAKJGMDG;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int OBEHJPNMBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private BHJAPHCABOE DEJJPGDGLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private BHJAPHCABOE DLLANLNNEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float OHIPBIDFIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Vector3 HMCJKLOGFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Vector3 BOFCBNEPEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool DPDAIDFLKEF;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion IHFDJHGPBJO;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion PIPBFGANJMK;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 MJCFCPOCAGF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 FCOBIJOKHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float INAJCBHOKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float POLNNFOGAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JNABLPLDKDI EGPAFNFHIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private JNABLPLDKDI HDDDBMCPFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private LGNHMJJCAHE GMGBLBMBMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private OMEKKINEIMH IEGDMBOAPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly KBOAOFBHIFD KNIIIJEHHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float GGGFHIFDPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float IPNLEHGJIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly OMEKKINEIMH OBFGLJNJKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 GGLCKGBKIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Vector3 PCMLBFCKAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float JPHFGIEGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float OMLKFNKKHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly OMEKKINEIMH KFOOIJGEPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly LGNHMJJCAHE HKCLGKDEEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly OMEKKINEIMH ANPLEFONKML;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public COOFKGJALFM NMIFFPIKFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public COOFKGJALFM HLOOODCABOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration FIIPGFGPDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x77C2400", Offset = "0x77C0E00", VA = "0x1877C2400", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PLCLOJBLHOK MANDPMOPPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x77B8860", Offset = "0x77B7260", VA = "0x1877B8860", Slot = "23")]
		get
		{
			return default(PLCLOJBLHOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration FGABPDDDENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x77BEF30", Offset = "0x77BD930", VA = "0x1877BEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform CKCDBAECPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77B0AB0", Offset = "0x77AF4B0", VA = "0x1877B0AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform FDKKBGMIOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77AA6A0", Offset = "0x77A90A0", VA = "0x1877AA6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer OIBLPDKBOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x77B8960", Offset = "0x77B7360", VA = "0x1877B8960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] FHHCMJCPLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x77A97D0", Offset = "0x77A81D0", VA = "0x1877A97D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] MBGNAKEFPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77C02C0", Offset = "0x77BECC0", VA = "0x1877C02C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator NAMMPILLBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x77B54D0", Offset = "0x77B3ED0", VA = "0x1877B54D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK JFIKDELGCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x77B20B0", Offset = "0x77B0AB0", VA = "0x1877B20B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private GEEPOBBKDEI CLDFGGCDGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77ABA90", Offset = "0x77AA490", VA = "0x1877ABA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private GEEPOBBKDEI DOJFODCOBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x77BF8B0", Offset = "0x77BE2B0", VA = "0x1877BF8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private GEEPOBBKDEI EGJPAMFIKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x77C0A20", Offset = "0x77BF420", VA = "0x1877C0A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private GEEPOBBKDEI MBLLAMNCKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x77BEC60", Offset = "0x77BD660", VA = "0x1877BEC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private GEEPOBBKDEI HJMIKPNHEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77B3800", Offset = "0x77B2200", VA = "0x1877B3800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private GEEPOBBKDEI CIIGPGMBJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77AEF10", Offset = "0x77AD910", VA = "0x1877AEF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private GEEPOBBKDEI PHPCJAIMJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77B85F0", Offset = "0x77B6FF0", VA = "0x1877B85F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private GEEPOBBKDEI MCHEKFNMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x77AC400", Offset = "0x77AAE00", VA = "0x1877AC400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DHJNHNNNKLG FPCHJBDMNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x77AF5D0", Offset = "0x77ADFD0", VA = "0x1877AF5D0", Slot = "15")]
		get
		{
			return default(DHJNHNNNKLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OLDJDAKOFEE ODGJKOKPKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4E720", Offset = "0xA4D120", VA = "0x180A4E720", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IDADBLCKEOP HIDGGAJOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDB0", Offset = "0xA4D7B0", VA = "0x180A4EDB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ELDIGJNJHMI DOHIECAGEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA4F060", Offset = "0xA4DA60", VA = "0x180A4F060", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ELDIGJNJHMI LEJOLFHHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAC0", Offset = "0xA4D4C0", VA = "0x180A4EAC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string LDLNJPFGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform DHLMLHIGLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x77B2C40", Offset = "0x77B1640", VA = "0x1877B2C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform DIHGAFJAMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77B1510", Offset = "0x77AFF10", VA = "0x1877B1510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform PGBNNOPGJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x77AE9D0", Offset = "0x77AD3D0", VA = "0x1877AE9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform FHEPEMEKPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x77C0890", Offset = "0x77BF290", VA = "0x1877C0890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform EDACJIHODDI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x77C1E80", Offset = "0x77C0880", VA = "0x1877C1E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool PODOKGJHALM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x77A9700", Offset = "0x77A8100", VA = "0x1877A9700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool BOFHDJDBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x77A9700", Offset = "0x77A8100", VA = "0x1877A9700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool DGJAAGIEMPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x77C0790", Offset = "0x77BF190", VA = "0x1877C0790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform JAJAINJHFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x77AA7A0", Offset = "0x77A91A0", VA = "0x1877AA7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject IHDAMAGFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x77AF700", Offset = "0x77AE100", VA = "0x1877AF700", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets NPFMDOABPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77BB600", Offset = "0x77BA000", VA = "0x1877BB600", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform LCBJIADAFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA43F40", Offset = "0xA42940", VA = "0x180A43F40", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform HKANMMNGOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0A0", Offset = "0xA4DAA0", VA = "0x180A4F0A0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform AKGDODGABJH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD20", Offset = "0xA4C720", VA = "0x180A4DD20", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform JHDEEAKKCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x126D520", Offset = "0x126BF20", VA = "0x18126D520", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 MAFADOKBBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x77BDA50", Offset = "0x77BC450", VA = "0x1877BDA50", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float DKGOJNIIGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x77AD3C0", Offset = "0x77ABDC0", VA = "0x1877AD3C0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform IPGJBPDNIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x77C0260", Offset = "0x77BEC60", VA = "0x1877C0260", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform BCIEMOHEDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x21C2AE0", Offset = "0x21C14E0", VA = "0x1821C2AE0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform BHLMANGGFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x21C2AD0", Offset = "0x21C14D0", VA = "0x1821C2AD0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform PJGFJIFDAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1B41270", Offset = "0x1B3FC70", VA = "0x181B41270", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool DCGACEONBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x77C2300", Offset = "0x77C0D00", VA = "0x1877C2300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool KAJNMLBJPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x77BDAE0", Offset = "0x77BC4E0", VA = "0x1877BDAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool IDJBAJDAEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x77B02D0", Offset = "0x77AECD0", VA = "0x1877B02D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77BC080", Offset = "0x77BAA80", VA = "0x1877BC080")]
	private void KMPLOEFDMAL([In] AIOLAPCBOAN JEBDFPOKJNB, [In] AvatarFullBodyConfiguration MOAPPBPCBJG, bool ECOFEOOOBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x77AC370", Offset = "0x77AAD70", VA = "0x1877AC370")]
	private float CMKAOJAIHOF([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x77A9750", Offset = "0x77A8150", VA = "0x1877A9750")]
	private float ACNAOICIPKH([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x77AD5F0", Offset = "0x77ABFF0", VA = "0x1877AD5F0")]
	private void DKAOFGAFJIO(AIOLAPCBOAN JEBDFPOKJNB, AvatarFullBodyConfiguration MOAPPBPCBJG, bool ECOFEOOOBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x77C1CC0", Offset = "0x77C06C0", VA = "0x1877C1CC0")]
	private void PKACOEHHKJA([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77B5B30", Offset = "0x77B4530", VA = "0x1877B5B30")]
	private void JGMPPPBFGOO([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x77C2F00", Offset = "0x77C1900", VA = "0x1877C2F00")]
	public DLFNAFDGAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x77B55D0", Offset = "0x77B3FD0", VA = "0x1877B55D0", Slot = "12")]
	public void JFEBPPLIJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x77B1040", Offset = "0x77AFA40", VA = "0x1877B1040", Slot = "13")]
	public void HKMANJFDJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x77B45D0", Offset = "0x77B2FD0", VA = "0x1877B45D0", Slot = "14")]
	public void JBLGFGPPJHB(bool KIFJPKPHFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x77C08D0", Offset = "0x77BF2D0", VA = "0x1877C08D0", Slot = "25")]
	public Transform OJFEBHBAGDG(string CDCEKALPGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x77ADFF0", Offset = "0x77AC9F0", VA = "0x1877ADFF0", Slot = "26")]
	public Vector3? EKPIBPIKPPC(string CDCEKALPGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77ABB90", Offset = "0x77AA590", VA = "0x1877ABB90", Slot = "7")]
	public void CLJKCKJMKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x77C19D0", Offset = "0x77C03D0", VA = "0x1877C19D0")]
	private void PDKKJEJEHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77BEDB0", Offset = "0x77BD7B0", VA = "0x1877BEDB0")]
	private Vector3 MPFACCGJPAD([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x77B21B0", Offset = "0x77B0BB0", VA = "0x1877B21B0", Slot = "6")]
	public void IENLJLIKGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x77B0A40", Offset = "0x77AF440", VA = "0x1877B0A40", Slot = "8")]
	public void HBKNPOIDJLI(float AAFCIANKDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x77ADEF0", Offset = "0x77AC8F0", VA = "0x1877ADEF0")]
	private void ECEEBBHOPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x77B9390", Offset = "0x77B7D90", VA = "0x1877B9390", Slot = "4")]
	public void KHNKJGALFBE(string HLIBGODHLGK, FJLCAPPLAMJ PMJKDFHGIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x77B4130", Offset = "0x77B2B30", VA = "0x1877B4130", Slot = "5")]
	public void JBJFBOBMOJD(DHJNHNNNKLG CGABNLLGCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x77BBF20", Offset = "0x77BA920", VA = "0x1877BBF20", Slot = "11")]
	public void KMAKOGHJKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77B1D20", Offset = "0x77B0720", VA = "0x1877B1D20", Slot = "24")]
	public void HPJDBHCIBGB([Out] Vector3 ILJABAAIJAM, [Out] Quaternion IKAHDBPCBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x77ADFC0", Offset = "0x77AC9C0", VA = "0x1877ADFC0")]
	private void EHOAICHEEEP([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x77C0C90", Offset = "0x77BF690", VA = "0x1877C0C90", Slot = "27")]
	public void OPLJFICGFII(float MIOLIMOFNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x77BE890", Offset = "0x77BD290", VA = "0x1877BE890", Slot = "28")]
	public void LLEMJAGGPJP(float GEHLOPLMLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x77BED60", Offset = "0x77BD760", VA = "0x1877BED60", Slot = "44")]
	public void MIGKBOENDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x77C1C70", Offset = "0x77C0670", VA = "0x1877C1C70", Slot = "29")]
	public void PHHGNDIOACF(bool JBDHCPKEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x77B5AE0", Offset = "0x77B44E0", VA = "0x1877B5AE0", Slot = "30")]
	public HandLogicOffsets JGADJCKAIDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x77AE910", Offset = "0x77AD310", VA = "0x1877AE910", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets FAFGBOGPINP()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x77ADD30", Offset = "0x77AC730", VA = "0x1877ADD30")]
	private void DLAMHCHOLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x77B49C0", Offset = "0x77B33C0", VA = "0x1877B49C0")]
	private void JDKDDBGABII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x77B0BB0", Offset = "0x77AF5B0", VA = "0x1877B0BB0")]
	private void HGDADAMECOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x77AA8A0", Offset = "0x77A92A0", VA = "0x1877AA8A0")]
	private void BFBNOEEAJAH(COGOJKBIHHJ PDLDPFECJOH, bool OFLGEPPEKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x77ADD60", Offset = "0x77AC760", VA = "0x1877ADD60")]
	private void DMDHFOKHLDG(COGOJKBIHHJ PDLDPFECJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77B0FF0", Offset = "0x77AF9F0", VA = "0x1877B0FF0")]
	public Vector3 HGNHFMNEPFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x77B8A60", Offset = "0x77B7460", VA = "0x1877B8A60")]
	private void KFCKGAPHJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x77B86F0", Offset = "0x77B70F0", VA = "0x1877B86F0")]
	private void JMHLBOOEDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x77B2F80", Offset = "0x77B1980", VA = "0x1877B2F80")]
	private void INGIIMHFHEH(AIOLAPCBOAN JEBDFPOKJNB, AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x77AE180", Offset = "0x77ACB80", VA = "0x1877AE180")]
	private float ELIBAOEKLJI([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x77AF7A0", Offset = "0x77AE1A0", VA = "0x1877AF7A0")]
	private int FPEDNIEGEFF([In] APIFDKHKJFJ OOGLKLHINJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x77BB9F0", Offset = "0x77BA3F0", VA = "0x1877BB9F0")]
	private void KLPAHKONKOG(AIOLAPCBOAN JEBDFPOKJNB, bool PMHAPGCBIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x77BB7F0", Offset = "0x77BA1F0", VA = "0x1877BB7F0")]
	private static void KKPMJDMFBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x77C0CA0", Offset = "0x77BF6A0", VA = "0x1877C0CA0")]
	private static void PAFOKKNKLIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x77AD410", Offset = "0x77ABE10", VA = "0x1877AD410")]
	private float DJPIJMGJOJF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x77AB810", Offset = "0x77AA210", VA = "0x1877AB810")]
	private static int CFFKLPIABNL(DLFNAFDGAEA AKJAPDOPIOF, DLFNAFDGAEA CPKHJEJFIJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x77BB680", Offset = "0x77BA080", VA = "0x1877BB680", Slot = "40")]
	public AIOLAPCBOAN KJKKPAABHEK()
	{
		return default(AIOLAPCBOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x77ADF40", Offset = "0x77AC940", VA = "0x1877ADF40")]
	public void ECONLNJBMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x77BF6B0", Offset = "0x77BE0B0", VA = "0x1877BF6B0")]
	private (bool, bool) NOEDDGCDDEJ()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x77B00F0", Offset = "0x77AEAF0", VA = "0x1877B00F0")]
	private (float, float) GMICANLCJGB([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x77B6BB0", Offset = "0x77B55B0", VA = "0x1877B6BB0")]
	private void JKJLMIPIIIK([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x77B46A0", Offset = "0x77B30A0", VA = "0x1877B46A0")]
	private void JCHAMBEOPEF([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x77BF290", Offset = "0x77BDC90", VA = "0x1877BF290")]
	private void NNKEACOEKKB([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG, AvatarFootSettings OJGDKKFHAGJ, bool HJAOFIMOJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x77BEBE0", Offset = "0x77BD5E0", VA = "0x1877BEBE0")]
	private float LPLNIFDNDAM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x77B5C30", Offset = "0x77B4630", VA = "0x1877B5C30")]
	private void JJAABCINFEI(AIOLAPCBOAN JCFJJCIGDKC, AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x77BDDC0", Offset = "0x77BC7C0", VA = "0x1877BDDC0")]
	private float LHKOHIKJIGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x77ACF00", Offset = "0x77AB900", VA = "0x1877ACF00")]
	private void DGFFGKDPKFO([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x77ADA50", Offset = "0x77AC450", VA = "0x1877ADA50")]
	private void DKBPIJEPEOH([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x77B67C0", Offset = "0x77B51C0", VA = "0x1877B67C0")]
	private void JKHKNJHBPGC([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x77AE660", Offset = "0x77AD060", VA = "0x1877AE660")]
	private void EOEJNPABEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x77AAB90", Offset = "0x77A9590", VA = "0x1877AAB90")]
	private void BIDDIKPIJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x77C1AD0", Offset = "0x77C04D0", VA = "0x1877C1AD0")]
	private void PGKCFKEMKCC([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x77BDE10", Offset = "0x77BC810", VA = "0x1877BDE10")]
	private void LIJAKFBCBBK(MOGLLAJNJHN IMGIKMGEEHA, IKSolverVR.Arm FFPGNGEIFML, Transform MIENFDNLPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x77AA310", Offset = "0x77A8D10", VA = "0x1877AA310")]
	private void ANHJJIBAKOL(AIOLAPCBOAN JCFJJCIGDKC, AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x77B5300", Offset = "0x77B3D00", VA = "0x1877B5300")]
	private void JEBILMLIPFL(JHLJPBJKOFH CGPDFPAKHBN, ELDIGJNJHMI IMGIKMGEEHA, IKSolverVR.Arm FFPGNGEIFML, float CNPLKMFONMD, float GFKMPDMIMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x77B8D90", Offset = "0x77B7790", VA = "0x1877B8D90")]
	private void KHAFPCBFMCM([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x77C03C0", Offset = "0x77BEDC0", VA = "0x1877C03C0")]
	protected void OFGPODIMFPL([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x77BEFC0", Offset = "0x77BD9C0", VA = "0x1877BEFC0")]
	private void NMBHHGEGDCF([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x77AB840", Offset = "0x77AA240", VA = "0x1877AB840")]
	protected void CFLOELEOMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x77B3900", Offset = "0x77B2300", VA = "0x1877B3900")]
	private void JAHLJFNBCFG([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AEKNOBMIAOO CBAPNHFCGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x77C1EC0", Offset = "0x77C08C0", VA = "0x1877C1EC0")]
	private void PMGMPOHMFBN(AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x77B8D50", Offset = "0x77B7750", VA = "0x1877B8D50")]
	private void KFMMGFEPFJB([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x77AEA00", Offset = "0x77AD400", VA = "0x1877AEA00")]
	private Vector3 FDPHENAJPBH([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x77C0BC0", Offset = "0x77BF5C0", VA = "0x1877C0BC0")]
	private void OOANJLCCHEM([In] AIOLAPCBOAN JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x77AB3C0", Offset = "0x77A9DC0", VA = "0x1877AB3C0")]
	private float CCEJKCNBIAN(float GNJHGDKNJBM, [In] AIOLAPCBOAN JCFJJCIGDKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x77B8710", Offset = "0x77B7110", VA = "0x1877B8710")]
	private void JOMDDMJCBIN(float GNJHGDKNJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x77B0350", Offset = "0x77AED50", VA = "0x1877B0350")]
	private void HBFNDPFPLDI([In] AIOLAPCBOAN JCFJJCIGDKC, AEKNOBMIAOO CBAPNHFCGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x77B4B40", Offset = "0x77B3540", VA = "0x1877B4B40")]
	private float JDOOKHANINB([In] AIOLAPCBOAN JEBDFPOKJNB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x77BE0A0", Offset = "0x77BCAA0", VA = "0x1877BE0A0")]
	private void LKGPKHJDJMB(AIOLAPCBOAN JCFJJCIGDKC, AEKNOBMIAOO CBAPNHFCGBH, Vector3 EIONFABDEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x77BDB60", Offset = "0x77BC560", VA = "0x1877BDB60")]
	private static void KPHAAKLGGOL(Transform GBIMAJCBFCJ, Quaternion KONJHPLFEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x77AE330", Offset = "0x77ACD30", VA = "0x1877AE330")]
	private void EMEDEMOGAPI([In] AIOLAPCBOAN MHAGAPCCBFJ, [In] APIFDKHKJFJ OOGLKLHINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x77BF9B0", Offset = "0x77BE3B0", VA = "0x1877BF9B0")]
	private void NPMLLPFBPHK([In] AIOLAPCBOAN MHAGAPCCBFJ, [In] APIFDKHKJFJ OOGLKLHINJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x77AF3E0", Offset = "0x77ADDE0", VA = "0x1877AF3E0")]
	private void FNHDOGJOIBP(float JGNOBJACJEI, [In] AIOLAPCBOAN JEBDFPOKJNB, float ALNDOFLLHOM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x77B1550", Offset = "0x77AFF50", VA = "0x1877B1550")]
	private float HNJONJOGEPJ([In] AIOLAPCBOAN JEBDFPOKJNB, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x77B2C90", Offset = "0x77B1690", VA = "0x1877B2C90")]
	private void IKPLBDLFPDE([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x77A98D0", Offset = "0x77A82D0", VA = "0x1877A98D0")]
	private void AJONGOHMGAI([In] AIOLAPCBOAN JEBDFPOKJNB, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x77AF010", Offset = "0x77ADA10", VA = "0x1877AF010")]
	private void FMBDMAKGEIK([In] AIOLAPCBOAN JEBDFPOKJNB, float OMGHOIPHIMH, float ELCDDAMNCKP, Vector3 JLMLIINBDHF, float ALNDOFLLHOM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x77AC500", Offset = "0x77AAF00", VA = "0x1877AC500")]
	private void DBIPLLJEPAK(AIOLAPCBOAN JEBDFPOKJNB, AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x77C2070", Offset = "0x77C0A70", VA = "0x1877C2070")]
	private void PNEEHHACPAF(AIOLAPCBOAN JCFJJCIGDKC, AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x77AF880", Offset = "0x77AE280", VA = "0x1877AF880")]
	private void GBILBMDFBDD(AIOLAPCBOAN JEBDFPOKJNB, AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x77AFF30", Offset = "0x77AE930", VA = "0x1877AFF30")]
	public void GKHMIJLIJON([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x77AFBC0", Offset = "0x77AE5C0", VA = "0x1877AFBC0")]
	public void GIAJNHFKNND([In] AIOLAPCBOAN JCFJJCIGDKC, [In] AvatarFullBodyConfiguration MOAPPBPCBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x77AADE0", Offset = "0x77A97E0", VA = "0x1877AADE0")]
	[CompilerGenerated]
	internal static void BINFPHHELOE(Transform KKMIKMKCMKE, IKSolverVR.Arm FFPGNGEIFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x77BDD10", Offset = "0x77BC710", VA = "0x1877BDD10")]
	[CompilerGenerated]
	internal static void LAANOJECGJH(Vector3 AOOCMGIKALL, Vector3 GMIHNAEFDHK, NLKHBNJFONK P_2, EJLHLCJFKEN P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x77C0B20", Offset = "0x77BF520", VA = "0x1877C0B20")]
	[CompilerGenerated]
	internal static void ONIIOJHAPND(BHJAPHCABOE IJNGMFHDNCD, BHJAPHCABOE OHJLLPNEPLM, Vector3 MGKIODIMJCO, float LPNLOGECJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x77B1400", Offset = "0x77AFE00", VA = "0x1877B1400")]
	[CompilerGenerated]
	internal static bool HMLMBIEPNNG(IKSolverVR.Arm FFPGNGEIFML, NOPGOBGPPEL PEEPIEOKJGC, float BCMNKLLJABA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x77AAF80", Offset = "0x77A9980", VA = "0x1877AAF80")]
	[CompilerGenerated]
	internal static float BNNAKIPEMNO(Vector3 DNGNFHLDALD, Vector3 IHCHFBKCJME, Vector3 KEAMJABLOPN, AIOLAPCBOAN JEBDFPOKJNB, AvatarFullBodyConfiguration MOAPPBPCBJG, float LMGBAALNFHC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class MLCIBCHFIGG : HEODGNPOOEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Dictionary<string, FIJBBFCDCMP> CIBKAGCNCJD;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x77D2620", Offset = "0x77D1020", VA = "0x1877D2620")]
	[EFEOGKEOEKD.IHENNBHNBPA]
	internal static void PEJFDOOHJHE(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x77D2390", Offset = "0x77D0D90", VA = "0x1877D2390", Slot = "4")]
	public FIJBBFCDCMP LNKONDNIMJE(string FCEDIFACGMI, AvatarSystemConfiguration GLNDEGODJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x77D21B0", Offset = "0x77D0BB0", VA = "0x1877D21B0", Slot = "5")]
	public void CLJOIEJFBKI(string FCEDIFACGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x77D2070", Offset = "0x77D0A70", VA = "0x1877D2070", Slot = "6")]
	public string ABCENJBLBKJ(string EJBBLODIJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x77D25B0", Offset = "0x77D0FB0", VA = "0x1877D25B0")]
	private string NICDOLKNOLP(string EJBBLODIJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x77D2690", Offset = "0x77D1090", VA = "0x1877D2690")]
	public MLCIBCHFIGG()
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
		public class MECCEOJFACG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private Dictionary<string, Transform> FGDDLMDLMAA;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool DDFCNJDHCLF
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x77D1F50", Offset = "0x77D0950", VA = "0x1877D1F50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x77D1E20", Offset = "0x77D0820", VA = "0x1877D1E20")]
			public void EANHCPCKCIM(VRIK ILNIKCMINDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
			public void BCNHNPDEDKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x77D1F90", Offset = "0x77D0990", VA = "0x1877D1F90")]
			public void OPIOKFDHGCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x77D1FE0", Offset = "0x77D09E0", VA = "0x1877D1FE0")]
			public MECCEOJFACG()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		[IFFOMBOELJM(PLKNMOLBJIE.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[JNJDEHPMCEK(PLKNMOLBJIE.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly MECCEOJFACG EDPHALACMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private IBCMALGGFMJ GEKAPLKHAAI;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x77C7FF0", Offset = "0x77C69F0", VA = "0x1877C7FF0")]
		private void ELAEPFFNBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x77C82D0", Offset = "0x77C6CD0", VA = "0x1877C82D0")]
		private bool JMNOHNCNDFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x77C8320", Offset = "0x77C6D20", VA = "0x1877C8320")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x77C8390", Offset = "0x77C6D90", VA = "0x1877C8390")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x77C8330", Offset = "0x77C6D30", VA = "0x1877C8330")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x77C8600", Offset = "0x77C7000", VA = "0x1877C8600")]
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
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x77CCB30", Offset = "0x77CB530", VA = "0x1877CCB30")]
			public void JCFABLNPBJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x77CCC10", Offset = "0x77CB610", VA = "0x1877CCC10")]
			public (float, float) OJBKDDELAIN(Animator EMGDFCHDGNG, AnimatorStateInfo IDCJBMEJLEB)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x77CCF60", Offset = "0x77CB960", VA = "0x1877CCF60")]
		public void JCFABLNPBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x77CCD50", Offset = "0x77CB750", VA = "0x1877CCD50")]
		public (float, float) GABOOMHEAEI(Animator EMGDFCHDGNG)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x77CD150", Offset = "0x77CBB50", VA = "0x1877CD150")]
		private (float, float) PHJHDNJOOFE(Animator EMGDFCHDGNG, AnimatorStateInfo IDCJBMEJLEB)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x77CD340", Offset = "0x77CBD40", VA = "0x1877CD340")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x77D2720", Offset = "0x77D1120", VA = "0x1877D2720", Slot = "4")]
		public override void OnStateEnter(Animator EMGDFCHDGNG, AnimatorStateInfo IDCJBMEJLEB, int BPPPPOBOKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x77D2880", Offset = "0x77D1280", VA = "0x1877D2880")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal abstract class FBHPCHEIHPM<TInput, TOutput> : IBGMJFKBDPK<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected readonly CDENNGLKHCJ DCGDAHBNIII;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47A8440", Offset = "0x47A6E40", VA = "0x1847A8440")]
	protected FBHPCHEIHPM(CDENNGLKHCJ DCGDAHBNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput DHOLDBOACBA(TInput OBMEHBOBMDK, [Out] IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x47A83A0", Offset = "0x47A6DA0", VA = "0x1847A83A0", Slot = "5")]
	public bool PNGPBBFLKJD(TInput OBMEHBOBMDK, [Out] TOutput? FFBEKAFHIDB, [Out] IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[OHBOADDCADD]
public static class DBFBPPFMCBF
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly Regex ECMAIHNGBGM;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x77CA030", Offset = "0x77C8A30", VA = "0x1877CA030")]
	public static BIJFAMACFNA CPJIIGHFKAD(MCOHPILBDMI MIGHDPKECBA, BEAKLKOGAHD KCCGPEIEKFP, Guid? NJBMCDEDLGE, Color? JAFFPJIALCJ, NMDLGPPCNIO NLOPOEHCFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x77CA240", Offset = "0x77C8C40", VA = "0x1877CA240")]
	public static FPDCEKEDCDG GKBMGHIAEOG(BIJFAMACFNA DFPGGEDGGGN)
	{
		return default(FPDCEKEDCDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x345BD00", Offset = "0x345A700", VA = "0x18345BD00")]
	internal static TModern? ANJODHGGFLE<TModern>(string? OBMEHBOBMDK, ACONCFPALJC<TModern> DOECDJOAGNL, CDENNGLKHCJ DCGDAHBNIII, JJCPLKHCGAJ DNGPKLCLBNK, TModern BONEAANOPDH) where TModern : struct, NBFPJEEGCEI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x345E1D0", Offset = "0x345CBD0", VA = "0x18345E1D0")]
	internal static EBMHFJABEIF LFPIMNNEMLL<TModern>(string? OBMEHBOBMDK, ACONCFPALJC<TModern> DOECDJOAGNL, CDENNGLKHCJ DCGDAHBNIII, JJCPLKHCGAJ DNGPKLCLBNK, TModern BONEAANOPDH) where TModern : struct, NBFPJEEGCEI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x77C9EF0", Offset = "0x77C88F0", VA = "0x1877C9EF0")]
	internal static List<OEELFAFECOH> BPLODIBBMLI(IEnumerable<ODBEMAJHDPM>? DINNJAJDKED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x345D350", Offset = "0x345BD50", VA = "0x18345D350")]
	internal static string CGOOIOAEPHN<TModern>(TModern OBMEHBOBMDK, ACONCFPALJC<TModern> DOECDJOAGNL, CDENNGLKHCJ DCGDAHBNIII) where TModern : NBFPJEEGCEI
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class BMGCNCDKGCA : NGLGPHCAONK
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IBGMJFKBDPK<CKMKHMAKINF, BKNOFPPIEOM> NDHDOJJHHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IBGMJFKBDPK<JILIDANPOJK, IMHNOILOHNM> MEPEHCCNMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IBGMJFKBDPK<JILIDANPOJK, IMHNOILOHNM> NADJNLLLECF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JBHFLBIGKDH BBAFJLDCLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LDGJCICGLIL GDFFKMGJPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x77C9490", Offset = "0x77C7E90", VA = "0x1877C9490")]
	[EFEOGKEOEKD.IHENNBHNBPA.IFPBCNBMCDE]
	[UsedImplicitly]
	internal static void ENFEOOLNDHA(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x77C9500", Offset = "0x77C7F00", VA = "0x1877C9500")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BMGCNCDKGCA([GJJKIKPKKBJ("UnitySerialization")] HGKLJCBOMHH BEHFNOCGPDK, [GJJKIKPKKBJ(null)] BFKGFOMADKP AGBDDDDLENG, [GJJKIKPKKBJ(null)] CDENNGLKHCJ DCGDAHBNIII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum OMELGJAKFIL
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ECGHNHMPMHD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x77CA4E0", Offset = "0x77C8EE0", VA = "0x1877CA4E0")]
	public ECGHNHMPMHD(string FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x77CA440", Offset = "0x77C8E40", VA = "0x1877CA440")]
	public ECGHNHMPMHD(string FLPDJFEEMLN, Exception JELEKGKHKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x77CA4B0", Offset = "0x77C8EB0", VA = "0x1877CA4B0")]
	public ECGHNHMPMHD(OMELGJAKFIL ICDLGGKHDLD, string FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x77CA470", Offset = "0x77C8E70", VA = "0x1877CA470")]
	public ECGHNHMPMHD(OMELGJAKFIL ICDLGGKHDLD, string FLPDJFEEMLN, Exception JELEKGKHKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal abstract class GFBFNJBBBBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly HGKLJCBOMHH BEHFNOCGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	protected readonly BFKGFOMADKP AGBDDDDLENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	protected readonly CDENNGLKHCJ DCGDAHBNIII;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x77CC4B0", Offset = "0x77CAEB0", VA = "0x1877CC4B0")]
	protected GFBFNJBBBBA(HGKLJCBOMHH BEHFNOCGPDK, BFKGFOMADKP AGBDDDDLENG, CDENNGLKHCJ DCGDAHBNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x77CB0A0", Offset = "0x77C9AA0", VA = "0x1877CB0A0")]
	protected string GKCHFBANGHG(BKNOFPPIEOM NHBLKJOHPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x77CAEB0", Offset = "0x77C98B0", VA = "0x1877CAEB0")]
	protected string GAJFKNAPEAA(BKNOFPPIEOM NHBLKJOHPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x77CAB80", Offset = "0x77C9580", VA = "0x1877CAB80")]
	private AvatarOutfitSelectionData CPJIIGHFKAD(BIJFAMACFNA NLAFELOBOJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x77CC370", Offset = "0x77CAD70", VA = "0x1877CC370")]
	private static AvatarCustomizationSettingsData.AnchorParams IPIALPLPJGG(CMIMFAFIAGN? KIJNHAIKGOL)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface IBGMJFKBDPK<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput DHOLDBOACBA(TInput OBMEHBOBMDK, [Out] IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PNGPBBFLKJD(TInput OBMEHBOBMDK, [Out] TOutput? FFBEKAFHIDB, [Out] IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NGLGPHCAONK
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	IBGMJFKBDPK<CKMKHMAKINF, BKNOFPPIEOM> NDHDOJJHHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	IBGMJFKBDPK<JILIDANPOJK, IMHNOILOHNM> NADJNLLLECF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JBHFLBIGKDH BBAFJLDCLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum JJCPLKHCGAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LDGJCICGLIL
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBLBGAGAANH CFLEALCFLNK(BKNOFPPIEOM DFPGGEDGGGN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JBHFLBIGKDH
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JILIDANPOJK CFLEALCFLNK(BKNOFPPIEOM DFPGGEDGGGN, int PICEKPEFJLJ, string? EMLAIMJKHOE, string? PEJHCKLJFMF, PHMNJENKGDJ OMMANJEFGMG, List<OEELFAFECOH>? GMEMBAMNEME);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[OHBOADDCADD]
internal class GCEECGKAKAF : FBHPCHEIHPM<CKMKHMAKINF, BKNOFPPIEOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly BFKGFOMADKP AGBDDDDLENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly LDELLGNKOMM HLIGNHEODOE;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x77CA9B0", Offset = "0x77C93B0", VA = "0x1877CA9B0")]
	public GCEECGKAKAF(HGKLJCBOMHH BEHFNOCGPDK, BFKGFOMADKP AGBDDDDLENG, CDENNGLKHCJ DCGDAHBNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x77CA710", Offset = "0x77C9110", VA = "0x1877CA710", Slot = "6")]
	public override BKNOFPPIEOM DHOLDBOACBA(CKMKHMAKINF OBMEHBOBMDK, [Out] IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[RecRoom.NoEngine.Common.Preserve]
internal class OCGGIFINNAH : HGKLJCBOMHH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class FCDLBMGNEJK : JsonConverter<EBMHFJABEIF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x77CA630", Offset = "0x77C9030", VA = "0x1877CA630", Slot = "9")]
		public override void WriteJson(JsonWriter IFAFIMFGJBL, EBMHFJABEIF? PPJFMHBDGNA, JsonSerializer LGMJFLOIPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x77CA510", Offset = "0x77C8F10", VA = "0x1877CA510", Slot = "10")]
		public override EBMHFJABEIF ReadJson(JsonReader BDHKEKKPKBC, Type GKHIEBGMKJK, EBMHFJABEIF? LNJBLKNMANO, bool EHBAJDIDAMH, JsonSerializer LGMJFLOIPKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x77CA6D0", Offset = "0x77C90D0", VA = "0x1877CA6D0")]
		public FCDLBMGNEJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GHJNOJKMIMI : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool BHIKCABMDKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x77CC9F0", Offset = "0x77CB3F0", VA = "0x1877CC9F0", Slot = "5")]
		public override object ReadJson(JsonReader BDHKEKKPKBC, Type GKHIEBGMKJK, object? LNJBLKNMANO, JsonSerializer LGMJFLOIPKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x77CC630", Offset = "0x77CB030", VA = "0x1877CC630", Slot = "6")]
		public override bool CanConvert(Type GKHIEBGMKJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x77CCA50", Offset = "0x77CB450", VA = "0x1877CCA50", Slot = "4")]
		public override void WriteJson(JsonWriter IFAFIMFGJBL, object? PPJFMHBDGNA, JsonSerializer LGMJFLOIPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x77CC810", Offset = "0x77CB210", VA = "0x1877CC810")]
		private static bool NJEICDAJAAJ(object PPJFMHBDGNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public GHJNOJKMIMI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly JsonSerializerSettings DMPGLFJEEDK;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x77D28A0", Offset = "0x77D12A0", VA = "0x1877D28A0")]
	internal OCGGIFINNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3819400", Offset = "0x3817E00", VA = "0x183819400", Slot = "4")]
	public string DOKKCEAANBE<T>(T OIIGDBLKEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3819370", Offset = "0x3817D70", VA = "0x183819370", Slot = "5")]
	public T DLKEPIKJGNI<T>(string PPJFMHBDGNA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[RecRoom.NoEngine.Common.Preserve]
internal class KJCBPJFDKGH : HGKLJCBOMHH
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3715850", Offset = "0x3714250", VA = "0x183715850", Slot = "4")]
	public string DOKKCEAANBE<T>(T OIIGDBLKEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x37157D0", Offset = "0x37141D0", VA = "0x1837157D0", Slot = "5")]
	public T DLKEPIKJGNI<T>(string PPJFMHBDGNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public KJCBPJFDKGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[OHBOADDCADD]
internal class LDELLGNKOMM : FBHPCHEIHPM<JILIDANPOJK, IMHNOILOHNM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly HGKLJCBOMHH BEHFNOCGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly BFKGFOMADKP AGBDDDDLENG;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x77D1A50", Offset = "0x77D0450", VA = "0x1877D1A50")]
	public LDELLGNKOMM(HGKLJCBOMHH BEHFNOCGPDK, BFKGFOMADKP AGBDDDDLENG, CDENNGLKHCJ DCGDAHBNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x77CFDA0", Offset = "0x77CE7A0", VA = "0x1877CFDA0", Slot = "6")]
	public override IMHNOILOHNM DHOLDBOACBA(JILIDANPOJK OBMEHBOBMDK, [Out] IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x77D1080", Offset = "0x77CFA80", VA = "0x1877D1080")]
	internal void MNMCFPPAMEE(string IDCDOOLLPNC, BKNOFPPIEOM NHBLKJOHPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x77D09C0", Offset = "0x77CF3C0", VA = "0x1877D09C0")]
	public IEnumerable<BIJFAMACFNA> HPPPCNEFLLP(string IKMEHLFAKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x77D0C70", Offset = "0x77CF670", VA = "0x1877D0C70")]
	private IEnumerable<BIJFAMACFNA> MGCNGGKDICE(string IKMEHLFAKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x77CF950", Offset = "0x77CE350", VA = "0x1877CF950")]
	internal IEnumerable<BIJFAMACFNA> CANDOFEDDIL(string IKMEHLFAKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x77D0640", Offset = "0x77CF040", VA = "0x1877D0640")]
	private BIJFAMACFNA HLKAHOJIGGC(AvatarOutfitSelectionData KKMLMDCMBEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x77D11D0", Offset = "0x77CFBD0", VA = "0x1877D11D0")]
	private void NKFGANNBFLC(AvatarCustomizationSettingsData LMFPDPECHDD, BKNOFPPIEOM NHBLKJOHPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x77D0320", Offset = "0x77CED20", VA = "0x1877D0320")]
	private BIJFAMACFNA HLKAHOJIGGC(string DCHIHEAMMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x77CF650", Offset = "0x77CE050", VA = "0x1877CF650")]
	internal static (NMDLGPPCNIO, string, string) BPENMAPPEIH(string DCHIHEAMMNJ, CDENNGLKHCJ DCGDAHBNIII)
	{
		return default((NMDLGPPCNIO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x77D0A70", Offset = "0x77CF470", VA = "0x1877D0A70")]
	private MFPLEIAOAAK? KIPPFPBHHHP(string? BIGAPECKJPI, Vector2 EAOIIGNJLGA, float OHNCEDHMBEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x77D01C0", Offset = "0x77CEBC0", VA = "0x1877D01C0")]
	private static CMIMFAFIAGN EBCJDKNNIPC(AvatarCustomizationSettingsData.AnchorParams PDIJGCKNHOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[OHBOADDCADD]
internal class ICCKNNHEDIL : GFBFNJBBBBA, LDGJCICGLIL
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x77CC4B0", Offset = "0x77CAEB0", VA = "0x1877CC4B0")]
	public ICCKNNHEDIL(HGKLJCBOMHH BEHFNOCGPDK, BFKGFOMADKP AGBDDDDLENG, CDENNGLKHCJ DCGDAHBNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x77CD590", Offset = "0x77CBF90", VA = "0x1877CD590", Slot = "4")]
	public MBLBGAGAANH CFLEALCFLNK(BKNOFPPIEOM DFPGGEDGGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x77CD940", Offset = "0x77CC340", VA = "0x1877CD940")]
	private string OPALPKKHDFA(BKNOFPPIEOM NHBLKJOHPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x77CD350", Offset = "0x77CBD50", VA = "0x1877CD350")]
	private string BLEFJCHEIJI(BIJFAMACFNA NLAFELOBOJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[OHBOADDCADD]
internal class KIDDDKFMEJC : FBHPCHEIHPM<JILIDANPOJK, IMHNOILOHNM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly HGKLJCBOMHH BEHFNOCGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly IBGMJFKBDPK<JILIDANPOJK, IMHNOILOHNM> IFBHAPPPMMK;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x77CF550", Offset = "0x77CDF50", VA = "0x1877CF550")]
	public KIDDDKFMEJC(IBGMJFKBDPK<JILIDANPOJK, IMHNOILOHNM> IFBHAPPPMMK, CDENNGLKHCJ DCGDAHBNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x77CF120", Offset = "0x77CDB20", VA = "0x1877CF120", Slot = "6")]
	public override IMHNOILOHNM DHOLDBOACBA(JILIDANPOJK OBMEHBOBMDK, [Out] IReadOnlyList<OEELFAFECOH>? GMEMBAMNEME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[OHBOADDCADD]
internal class CEOIFBNEEMK : JBHFLBIGKDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly HGKLJCBOMHH BEHFNOCGPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly LDGJCICGLIL ELGJIDFPMAI;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x77C9E00", Offset = "0x77C8800", VA = "0x1877C9E00")]
	public CEOIFBNEEMK(LDGJCICGLIL ELGJIDFPMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x77C9A60", Offset = "0x77C8460", VA = "0x1877C9A60", Slot = "4")]
	public JILIDANPOJK CFLEALCFLNK(BKNOFPPIEOM DFPGGEDGGGN, int PICEKPEFJLJ, string? EMLAIMJKHOE, string? PEJHCKLJFMF, PHMNJENKGDJ OMMANJEFGMG, List<OEELFAFECOH>? GMEMBAMNEME)
	{
		return null;
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x77C76B0", Offset = "0x77C60B0", VA = "0x1877C76B0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MCBNNGPDIIC
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x77D1D10", Offset = "0x77D0710", VA = "0x1877D1D10")]
	public static FPDCEKEDCDG DHOLDBOACBA(this INCIGPLPAJC DFPGGEDGGGN)
	{
		return default(FPDCEKEDCDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x77D1BF0", Offset = "0x77D05F0", VA = "0x1877D1BF0")]
	public static INCIGPLPAJC CFLEALCFLNK(this FPDCEKEDCDG GLGGJJHJBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x77D1B90", Offset = "0x77D0590", VA = "0x1877D1B90")]
	public static bool AAEKNHOBCDK(this FPDCEKEDCDG GLGGJJHJBAG)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x599A7C0", Offset = "0x59991C0", VA = "0x18599A7C0")]
			public AnchorParams(Vector2 NBALHHGCFMD, Vector3 BPBGFIJMCOD, Vector3 HFMGFDPLEDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x77C7600", Offset = "0x77C6000", VA = "0x1877C7600")]
			internal CMIMFAFIAGN CFLEALCFLNK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private DBGJIPOCKFK useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x77C7EA0", Offset = "0x77C68A0", VA = "0x1877C7EA0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x48C8460", Offset = "0x48C6E60", VA = "0x1848C8460")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xC24660", Offset = "0xC23060", VA = "0x180C24660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xE86E80", Offset = "0xE85880", VA = "0x180E86E80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x11FB6A0", Offset = "0x11FA0A0", VA = "0x1811FB6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x9B5530", Offset = "0x9B3F30", VA = "0x1809B5530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x77C7F40", Offset = "0x77C6940", VA = "0x1877C7F40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9B6A80", Offset = "0x9B5480", VA = "0x1809B6A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xB917B0", Offset = "0xB901B0", VA = "0x180B917B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB91CB0", Offset = "0xB906B0", VA = "0x180B91CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFE0", Offset = "0x9AD9E0", VA = "0x1809AEFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x77C7F80", Offset = "0x77C6980", VA = "0x1877C7F80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xDB0D00", Offset = "0xDAF700", VA = "0x180DB0D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x10069A0", Offset = "0x10053A0", VA = "0x1810069A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1669AD0", Offset = "0x16684D0", VA = "0x181669AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x9AC510", Offset = "0x9AAF10", VA = "0x1809AC510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4E0", Offset = "0x9AAEE0", VA = "0x1809AC4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x217EAC0", Offset = "0x217D4C0", VA = "0x18217EAC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xDD8B40", Offset = "0xDD7540", VA = "0x180DD8B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9E3E10", Offset = "0x9E2810", VA = "0x1809E3E10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9E3E70", Offset = "0x9E2870", VA = "0x1809E3E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BE0", Offset = "0x9B65E0", VA = "0x1809B7BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BC0", Offset = "0x9B65C0", VA = "0x1809B7BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B20", Offset = "0x9B6520", VA = "0x1809B7B20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A80", Offset = "0x9B6480", VA = "0x1809B7A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BB0", Offset = "0x9B65B0", VA = "0x1809B7BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B80", Offset = "0x9B6580", VA = "0x1809B7B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB5D590", Offset = "0xB5BF90", VA = "0x180B5D590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x121EED0", Offset = "0x121D8D0", VA = "0x18121EED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B50", Offset = "0x9B6550", VA = "0x1809B7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A20", Offset = "0x9B6420", VA = "0x1809B7A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xC5B7C0", Offset = "0xC5A1C0", VA = "0x180C5B7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xDC7F50", Offset = "0xDC6950", VA = "0x180DC7F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9B1780", Offset = "0x9B0180", VA = "0x1809B1780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9B17D0", Offset = "0x9B01D0", VA = "0x1809B17D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xBA86E0", Offset = "0xBA70E0", VA = "0x180BA86E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xDD5050", Offset = "0xDD3A50", VA = "0x180DD5050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xC079C0", Offset = "0xC063C0", VA = "0x180C079C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xC05CA0", Offset = "0xC046A0", VA = "0x180C05CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public DBGJIPOCKFK UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xE8C6A0", Offset = "0xE8B0A0", VA = "0x180E8C6A0")]
			get
			{
				return default(DBGJIPOCKFK);
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xE8D360", Offset = "0xE8BD60", VA = "0x180E8D360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xE8BA40", Offset = "0xE8A440", VA = "0x180E8BA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB4F080", Offset = "0xB4DA80", VA = "0x180B4F080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x77C7F60", Offset = "0x77C6960", VA = "0x1877C7F60")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x77C7FA0", Offset = "0x77C69A0", VA = "0x1877C7FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x77C7B40", Offset = "0x77C6540", VA = "0x1877C7B40")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public NMDLGPPCNIO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private JCKCCOBELDI? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x77C7FC0", Offset = "0x77C69C0", VA = "0x1877C7FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
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
