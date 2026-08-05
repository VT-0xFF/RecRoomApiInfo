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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7494AC0", Offset = "0x7493EC0", VA = "0x187494AC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74AE820", Offset = "0x74ADC20", VA = "0x1874AE820", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MENIDINFMMJ]
internal class IADAOINJLJJ : NFHPDKNPKPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LFNLEKAHEHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public IADAOINJLJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public DIINEKIAPFE avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HNAGPAIDFBH LLJMAMCAOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FMPJBLDCLOC NMCGOIJGJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GEMEMDDPCDF IDHFELMMAEF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7494590", Offset = "0x7493990", VA = "0x187494590")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	[UsedImplicitly]
	internal static void IDEOAALFMGD(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7494940", Offset = "0x7493D40", VA = "0x187494940")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IADAOINJLJJ([PNFCCJKFMBH(null)] HNAGPAIDFBH LLJMAMCAOAK, [PNFCCJKFMBH(null)] FMPJBLDCLOC NMCGOIJGJAH, [PNFCCJKFMBH(null)] GEMEMDDPCDF IDHFELMMAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7493000", Offset = "0x7492400", VA = "0x187493000", Slot = "5")]
	public GKDBEGOBGHP CPEPKCAPKBC(DIINEKIAPFE NKOMJFFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74938D0", Offset = "0x7492CD0", VA = "0x1874938D0", Slot = "4")]
	public GKDBEGOBGHP GEPHCGEDDEA(DIINEKIAPFE NKOMJFFJMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74947A0", Offset = "0x7493BA0", VA = "0x1874947A0", Slot = "6")]
	public JBDKFAALPPD NPKJMABLJAN(GKDBEGOBGHP MJFOKKFMONL, int ABHPEBOHJHB, string? OGOCCCFKJPG, string? PCFHDJDLMFG, IHODNCAIHCO ALEBFNOGPNE, List<JOKNDKDOAOG>? CKFGAKGEIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74948B0", Offset = "0x7493CB0", VA = "0x1874948B0", Slot = "7")]
	public bool OFNKPEKLKBK(FMCBLLPHGJK FNGCCDNIGPP, [Out] GKDBEGOBGHP? BFLCMMHHBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7492F20", Offset = "0x7492320", VA = "0x187492F20", Slot = "8")]
	public bool CIHNMILMMND(JBDKFAALPPD AMFDLGBNNMD, [Out] GKDBEGOBGHP? BFLCMMHHBLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7493840", Offset = "0x7492C40", VA = "0x187493840", Slot = "9")]
	public bool FEKFLFGOHBJ(JBDKFAALPPD AMFDLGBNNMD, [Out] EODCNACCAOB? FNGCCDNIGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x34F5960", Offset = "0x34F4D60", VA = "0x1834F5960")]
	private bool JNJCCNIMPBH<TInput, TOutput>(TInput NIPDIMDKGGA, NPILLHODFPM<TInput, TOutput> BNAAGMKPIEK, [Out] TOutput? HOCIBOCHCFJ) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7494600", Offset = "0x7493A00", VA = "0x187494600")]
	[CompilerGenerated]
	private GMOHEDJKJCH NBPEDGIPLCJ(FaceFeatureType FHBFDOFHNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74943B0", Offset = "0x74937B0", VA = "0x1874943B0")]
	[CompilerGenerated]
	private GMOHEDJKJCH HKIIIBBGMGA(FaceFeatureType FHBFDOFHNME, LFNLEKAHEHE P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[MENIDINFMMJ]
internal class AILMIMELKII : HNAGPAIDFBH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void PIGJLJAJJLE<in TData>(TData BFLCMMHHBLO, IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly GEMEMDDPCDF IDHFELMMAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JJHMNFHFHIL NLLOMHBDPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PIGJLJAJJLE<GKDBEGOBGHP>?[] LLJMAMCAOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PIGJLJAJJLE<EODCNACCAOB>?[] IADBMLFNDGL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x748F8A0", Offset = "0x748ECA0", VA = "0x18748F8A0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	[UsedImplicitly]
	internal static void IDEOAALFMGD(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74906B0", Offset = "0x748FAB0", VA = "0x1874906B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AILMIMELKII([PNFCCJKFMBH(null)] GEMEMDDPCDF IDHFELMMAEF, [PNFCCJKFMBH(null)] JJHMNFHFHIL NLLOMHBDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74905B0", Offset = "0x748F9B0", VA = "0x1874905B0", Slot = "4")]
	public bool NOEBJAKBDHP(GKDBEGOBGHP BFLCMMHHBLO, IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7490450", Offset = "0x748F850", VA = "0x187490450", Slot = "5")]
	public bool NOEBJAKBDHP(EODCNACCAOB FNGCCDNIGPP, IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x748F910", Offset = "0x748ED10", VA = "0x18748F910")]
	private void JDLFMDHHJBG(GKDBEGOBGHP BFLCMMHHBLO, IReadOnlyList<JOKNDKDOAOG>? NCCMNNBGHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x748F5A0", Offset = "0x748E9A0", VA = "0x18748F5A0")]
	private void HCBBENPDPOA(GKDBEGOBGHP BFLCMMHHBLO, IReadOnlyList<JOKNDKDOAOG>? NCCMNNBGHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74903F0", Offset = "0x748F7F0", VA = "0x1874903F0")]
	private void JELDHBAFFKF(GKDBEGOBGHP BFLCMMHHBLO, IReadOnlyList<JOKNDKDOAOG>? NCCMNNBGHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7490420", Offset = "0x748F820", VA = "0x187490420")]
	private void JMOPCEBDODJ(GKDBEGOBGHP BFLCMMHHBLO, IReadOnlyList<JOKNDKDOAOG>? NCCMNNBGHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x748F7D0", Offset = "0x748EBD0", VA = "0x18748F7D0")]
	private void IACDMODHELH(GKDBEGOBGHP BFLCMMHHBLO, IReadOnlyList<JOKNDKDOAOG>? NCCMNNBGHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HNAGPAIDFBH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOEBJAKBDHP(GKDBEGOBGHP BFLCMMHHBLO, IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOEBJAKBDHP(EODCNACCAOB FNGCCDNIGPP, IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH);
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
		public LPFNJMNNCNC AnimationPoseType;

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

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7490AF0", Offset = "0x748FEF0", VA = "0x187490AF0")]
		public void IKKFAILNHGM(AnimationPoseSetting MNALNBMKJLK, float NPNINMBPOGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7490C20", Offset = "0x7490020", VA = "0x187490C20")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7491510", Offset = "0x7490910", VA = "0x187491510")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74914D0", Offset = "0x74908D0", VA = "0x1874914D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7490C40", Offset = "0x7490040", VA = "0x187490C40")]
		private void BHMDNAAMLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7422F30", Offset = "0x7422330", VA = "0x187422F30", Slot = "4")]
		public void SetEnabled(bool KFMEJIELJKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7491540", Offset = "0x7490940", VA = "0x187491540")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7491580", Offset = "0x7490980", VA = "0x187491580")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		[Header("Turning")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x389")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74915C0", Offset = "0x74909C0", VA = "0x1874915C0")]
		public AnimationPoseSetting HLALOBBOBIH(LPFNJMNNCNC DEMMJALMEPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74915F0", Offset = "0x74909F0", VA = "0x1874915F0")]
		public void MEKFCHHLHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7491630", Offset = "0x7490A30", VA = "0x187491630")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum LJAOMOOFDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private LJAOMOOFDFJ handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74920E0", Offset = "0x74914E0", VA = "0x1874920E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x74920A0", Offset = "0x74914A0", VA = "0x1874920A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7491AA0", Offset = "0x7490EA0", VA = "0x187491AA0")]
		private void BHMDNAAMLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7422F30", Offset = "0x7422330", VA = "0x187422F30", Slot = "4")]
		public void SetEnabled(bool KFMEJIELJKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7492110", Offset = "0x7491510", VA = "0x187492110")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, DHIFFBJMEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Header("Configuration")]
		private DIINEKIAPFE avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[IGKHBFEOLOG(MFMOBKOPAIF.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		[Header("Facial Animation")]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private PPBGPPFLHFP DELPOPNDIBG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public PPBGPPFLHFP CHHGMFMBIJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9FC050", Offset = "0x9FB450", VA = "0x1809FC050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform ONCAPKLALNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7492F00", Offset = "0x7492300", VA = "0x187492F00", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7492140", Offset = "0x7491540", VA = "0x187492140")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7492DC0", Offset = "0x74921C0", VA = "0x187492DC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7492D70", Offset = "0x7492170", VA = "0x187492D70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7492D00", Offset = "0x7492100", VA = "0x187492D00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7492140", Offset = "0x7491540", VA = "0x187492140", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74924D0", Offset = "0x74918D0", VA = "0x1874924D0", Slot = "6")]
		public PPBGPPFLHFP CreateAvatarSystem(string NNJDHALJMJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7492D00", Offset = "0x7492100", VA = "0x187492D00", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7492200", Offset = "0x7491600", VA = "0x187492200", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7492E10", Offset = "0x7492210", VA = "0x187492E10", Slot = "9")]
		public void UpdatePostIKAnimControllers(float JHAIOFABKNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class PGICMFKDBOE : PPBGPPFLHFP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class HHGICEBOLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 CIKIIFFLDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Quaternion DJHIAEALLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 OEGMCHMFCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Transform ANJBCGIOPDF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 PEAGJDLKJAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1D0B610", Offset = "0x1D0AA10", VA = "0x181D0B610")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1D0B630", Offset = "0x1D0AA30", VA = "0x181D0B630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion IGMEOCBNFHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x11CE740", Offset = "0x11CDB40", VA = "0x1811CE740")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x11CE750", Offset = "0x11CDB50", VA = "0x1811CE750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float MODMNOIBBJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xF3EDB0", Offset = "0xF3E1B0", VA = "0x180F3EDB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x15781D0", Offset = "0x15775D0", VA = "0x1815781D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool BNEPPCEOIPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x96E0B0", Offset = "0x96D4B0", VA = "0x18096E0B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x96E1C0", Offset = "0x96D5C0", VA = "0x18096E1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool MEKDJKHEKEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x96E0D0", Offset = "0x96D4D0", VA = "0x18096E0D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x96E0C0", Offset = "0x96D4C0", VA = "0x18096E0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool ECODDLBEJPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x96E0F0", Offset = "0x96D4F0", VA = "0x18096E0F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x96E1B0", Offset = "0x96D5B0", VA = "0x18096E1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float AEDCEGEHLHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB8D090", Offset = "0xB8C490", VA = "0x180B8D090")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB8D9E0", Offset = "0xB8CDE0", VA = "0x180B8D9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x74B2490", Offset = "0x74B1890", VA = "0x1874B2490")]
		public void OAEMGCLBDFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x74B1950", Offset = "0x74B0D50", VA = "0x1874B1950")]
		public void FLLGNEHPMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x74B1AB0", Offset = "0x74B0EB0", VA = "0x1874B1AB0")]
		public float HCHFHPMHALE(Vector3 KGHOBNFNKJN, Quaternion AMLCHNMAEMM, [In] AvatarFootSettings CLFJKLFHCAJ, float FOLPOMHOBDD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x74B1DC0", Offset = "0x74B11C0", VA = "0x1874B1DC0")]
		public void LJGKAJIKBOA(Vector3 JCJMAEKAJAH, Quaternion BOODCALAODC, Transform BDFJJMFOHEL, float JKHIGDBEGDG, bool HLAOAHJDNIO, bool GENOAIAEMIC, float PCNFEEJGJOB, float BOBBAFCKGAN, Transform HAIKBOLEOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x74B1720", Offset = "0x74B0B20", VA = "0x1874B1720")]
		public void BEMEICKJIOA(Transform NAJDAFMFJMO, Transform HAIKBOLEOOP, bool HIGOFMDIAKG, bool PNELEACLGKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74B1CC0", Offset = "0x74B10C0", VA = "0x1874B1CC0")]
		private void HLDNDEDPDPB(Transform HAIKBOLEOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x74B1960", Offset = "0x74B0D60", VA = "0x1874B1960")]
		public void GPDBPAKIOJL(Transform HAIKBOLEOOP, AvatarFullBodyConfiguration FLKLAANBPFM, Vector3 PCMNKDCKEKG, float AKCGIEPFPNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74B24A0", Offset = "0x74B18A0", VA = "0x1874B24A0")]
		public void PJJKMMFEPNE(float BOBBAFCKGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x74B24C0", Offset = "0x74B18C0", VA = "0x1874B24C0")]
		public HHGICEBOLLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class KEPHCFILOBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float EMJENFHPBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool NPOKPGCEDDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AnimationPoseSetting GPHGDGNOEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private float MOJNCGMBOAP;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x74B60A0", Offset = "0x74B54A0", VA = "0x1874B60A0")]
		public void EFCPBNGIDBG(IKSolverVR.Arm LCFKKEIDGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x74B60D0", Offset = "0x74B54D0", VA = "0x1874B60D0")]
		public void EIGIGJILFMK(IKSolverVR.Arm LCFKKEIDGPI, float CIHGAPEDKLC, bool NPOKPGCEDDD, AvatarFullBodyConfiguration FLKLAANBPFM, float HEDKILDIFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74B6110", Offset = "0x74B5510", VA = "0x1874B6110")]
		private void GNGKDMMFGDO(IKSolverVR.Arm LCFKKEIDGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x74B6150", Offset = "0x74B5550", VA = "0x1874B6150")]
		public void HGKMDDBBLAD(IKSolverVR.Arm LCFKKEIDGPI, Transform CGFMALKLNMC, Transform BDFJJMFOHEL, Quaternion NNIOKEBDBHI, Vector3 OJPIPKOOKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74B6530", Offset = "0x74B5930", VA = "0x1874B6530")]
		private (Vector3, Quaternion) IHKJFHDANLE(FMKLMOOCMIN KKMDAIFPPAA, Quaternion AFLMPAHGDHO, Vector3 PKPFAKJAMPM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x74B7100", Offset = "0x74B6500", VA = "0x1874B7100")]
		public void PKPGKJIOGEG(FMKLMOOCMIN KKMDAIFPPAA, IKSolverVR.Arm LCFKKEIDGPI, Quaternion AFLMPAHGDHO, Vector3 PKPFAKJAMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74B69C0", Offset = "0x74B5DC0", VA = "0x1874B69C0")]
		public void NKHANNAHFGJ(FMKLMOOCMIN KKMDAIFPPAA, IKSolverVR.Arm LCFKKEIDGPI, Quaternion AFLMPAHGDHO, Vector3 PKPFAKJAMPM, [In] AvatarFullBodyConfiguration FLKLAANBPFM, [In] DOHDGPIOHIE MLIDEILJAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x74B6FC0", Offset = "0x74B63C0", VA = "0x1874B6FC0")]
		public void OKJJBHJBNMC(LPFNJMNNCNC DNBDBHBLEON, AvatarFullBodyConfiguration FLKLAANBPFM, DOHDGPIOHIE MLIDEILJAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x74B5C00", Offset = "0x74B5000", VA = "0x1874B5C00")]
		public void BMCDIICEFOO(IKSolverVR.Arm LCFKKEIDGPI, Transform CGFMALKLNMC, Vector3 AKCLDDAEOPB, float ONIPFJHOENJ, Quaternion FGHKDCEANBI, Vector3 AHLLJHMDGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x74B7260", Offset = "0x74B6660", VA = "0x1874B7260")]
		public KEPHCFILOBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum AKMOFHBFDIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DLCBLGHGIPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FMJHLCBNCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int KCKFBLEADNH;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int LLLNLHOEIKF;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int DDECHINHFCJ;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int DADEOBMCBLC;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int BAHALLINCBC;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int NHGDINFHBBD;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int CNBCANNLPMA;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int IHCFALCLOHG;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int CGELLOHMKML;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int GGADAFJBIOO;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int JOKJJNCHELC;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int MHBKNHJLDON;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int BOPNFPLMLCK;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int NKCCLCJNJCI;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int JDIDNCLJFJO;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int OONGHGKCEOB;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int OCLPDIKDHEA;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int BKNPDHKKBDL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int MPPKKPBBHPI;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int BEDJKIAHHMC;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int AOBLLJNNAIP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int FJMCPJOMEPP;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int NOPCGIIGDLP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int DBIDOOFGLAF;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int FEAMHADOPDH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int GDCHOHOOKKG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int FOFFMHDNJNH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int OLHNIECBPHN;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int LLKPEBPDPKB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int DABFEDDEJPJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int GDHCEPFMODJ;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly Vector3 AACCBGEJJMF;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int JBGOHKLDNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool NCCMGENBONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool ECLJHGHEJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool BBFGCLGBMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool JCJFCBAPDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool KFEPJLHJCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool NHDDNJKLEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Vector3 JLPFPHNDAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private string HNLFAEAPMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private ILCBGHOPBEI? KKKMAMBKCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private CKPMFAMNJCP? PONBOPFKHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private MBOGIKGHAPE POLNJCMKMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private IIBMKBKGNKI FCDJKGHHHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FMKLMOOCMIN GBOPGCJIHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private FMKLMOOCMIN AAKHNKNNOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool BLIOFGEIMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool DIDPCMNJAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly LNDPEIIJDBB AEEBLCKBAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly IPBJOKENCEG MOMFBOGBHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int JBPCLIHOIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private float NLMMOFJOIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GameObject FEPMPPDJCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform EKAIODLGBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform BHBOKMPKJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform BMGHLKOICIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform GBMPEBLDGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float DIADEHOPBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float MBGPOKCFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 CKOPIHOCDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Quaternion ONDOAEIJABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform NIHNAEJHFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform OALHPMIDDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform GIHIGGJCALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private GODMKLJCBJM FOKLFDLIIOP;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker EEOFHFIALFL;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker KJHJBODBIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ProfilerMarker EJMOAJFPHHP;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker HDIMNJDCEGD;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker OPCDKHBKMBN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker NIGMFLPIIOH;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly List<PGICMFKDBOE> GKNAGGEIAAO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int HAMIOHJKEFA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> JPBCCLPIIDI;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static int DBCGNMAELIB;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int IAAADLGBLGP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int CEPMKBPJAAM;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int DFMMIOFNENG;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float ENOJNJENCCJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int PHEOKMIBFCA;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static float INKCCHPPCCN;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float DLFLEOEDIOI;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float OFENJCEOFIK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float HJAPBJONCDM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static BAMKDEHEKHK ICANEAKPHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float HGOLKOAMFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool AOHJBOEIKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float EJFIGMKNOJE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly int KFAPPPJLMKE;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly int OFNOKNDEBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private HHGICEBOLLD CKFEMCEKAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private HHGICEBOLLD POEHHMKLBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float LFMAKIBLPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Vector3 PCKJEIFNPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Vector3 COCGOHKCKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private bool FDMGKHPCBLD;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly Quaternion EIDDOMPDIOC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly Quaternion IMNIJHMDFHB;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly Vector3 DBONLKHDDPD;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Vector3 ABHNIGMNPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float PJMFJPPOAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float MGIGDAMJHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private KEPHCFILOBI ONPLPFLAHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private KEPHCFILOBI DDJIJDGAGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private FGNPIKKGCBJ LOCNHFJJIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private CKEAIMPPPJJ CNGMJAPJECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly DGIJAJBEDPG KJBOIHNIAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float COAOHLMDJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float MGBDFLJMMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly CKEAIMPPPJJ CJJFFIAPCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Vector3 ABMIPAHJCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 NIKGFIBLBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float FHBGHHDODON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float IFLEGNFNFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly CKEAIMPPPJJ HLANKGLGNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly FGNPIKKGCBJ IMLJEJLCOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly CKEAIMPPPJJ NFIFBILHJDG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EBGLFEEDNOA LKIPGOCPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EBGLFEEDNOA JFMFDPPAMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration ABBINCFKGEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7499BD0", Offset = "0x7498FD0", VA = "0x187499BD0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DIINEKIAPFE CCBKMGCAFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74A8340", Offset = "0x74A7740", VA = "0x1874A8340", Slot = "23")]
		get
		{
			return default(DIINEKIAPFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration OANMKGCENIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74A6E80", Offset = "0x74A6280", VA = "0x1874A6E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform KFNINEGDDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74A2310", Offset = "0x74A1710", VA = "0x1874A2310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform NJHDGIDBBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7498F30", Offset = "0x7498330", VA = "0x187498F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer LPFFPGJDBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74968A0", Offset = "0x7495CA0", VA = "0x1874968A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] NFGBPBPLBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74A0BE0", Offset = "0x749FFE0", VA = "0x1874A0BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] KEGDAAHHLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7497A00", Offset = "0x7496E00", VA = "0x187497A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator HAFPFODLFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74A9000", Offset = "0x74A8400", VA = "0x1874A9000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK NMHOGIGHGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74988F0", Offset = "0x7497CF0", VA = "0x1874988F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private FFFMFLNNING OODMPJMIIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74A5CD0", Offset = "0x74A50D0", VA = "0x1874A5CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private FFFMFLNNING GEACPMGOPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74A2990", Offset = "0x74A1D90", VA = "0x1874A2990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private FFFMFLNNING GNMAKKHBNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x749B310", Offset = "0x749A710", VA = "0x18749B310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private FFFMFLNNING OIIOIMIIBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7498480", Offset = "0x7497880", VA = "0x187498480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private FFFMFLNNING BBFCFOMBOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7496460", Offset = "0x7495860", VA = "0x187496460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private FFFMFLNNING JFIECGIOOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x749B540", Offset = "0x749A940", VA = "0x18749B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FFFMFLNNING GOCBBDCMOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x749A3D0", Offset = "0x74997D0", VA = "0x18749A3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private FFFMFLNNING ANHILIJIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x74A2DA0", Offset = "0x74A21A0", VA = "0x1874A2DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CKPMFAMNJCP FPNPNLILNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x749B410", Offset = "0x749A810", VA = "0x18749B410", Slot = "15")]
		get
		{
			return default(CKPMFAMNJCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NHBJOEBCOCP PCMLFCKLPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCD5B80", Offset = "0xCD4F80", VA = "0x180CD5B80", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IAENBMOFMLD NBHAKAKGHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCD5BF0", Offset = "0xCD4FF0", VA = "0x180CD5BF0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MBDCKCDIJDA GANCCIOCOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1055C00", Offset = "0x1055000", VA = "0x181055C00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MBDCKCDIJDA MPBFMGGKGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1C46F50", Offset = "0x1C46350", VA = "0x181C46F50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string AGHJIAELIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform MHEGBDCFAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7498880", Offset = "0x7497C80", VA = "0x187498880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform NIFAOJFGDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x749F370", Offset = "0x749E770", VA = "0x18749F370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform ILHIHCGPHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7497130", Offset = "0x7496530", VA = "0x187497130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform JACCBFHIIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x74970F0", Offset = "0x74964F0", VA = "0x1874970F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform NBPCPOFFKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x749A4D0", Offset = "0x74998D0", VA = "0x18749A4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool NCNABKAIFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7497200", Offset = "0x7496600", VA = "0x187497200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool IMFPJKEJNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7497200", Offset = "0x7496600", VA = "0x187497200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Transform EJACDEOPCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74969A0", Offset = "0x7495DA0", VA = "0x1874969A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GameObject IIKFCCENKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7497160", Offset = "0x7496560", VA = "0x187497160", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HeadLogicOffsets JEEDADDAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x74AB0A0", Offset = "0x74AA4A0", VA = "0x1874AB0A0", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform BKGDOMJOHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA66520", Offset = "0xA65920", VA = "0x180A66520", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform MLOKHIOAMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1D66E90", Offset = "0x1D66290", VA = "0x181D66E90", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform APPFMKLJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA8BEF0", Offset = "0xA8B2F0", VA = "0x180A8BEF0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform OCLPLJIAMLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1A59B90", Offset = "0x1A58F90", VA = "0x181A59B90", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 CGNGLKDAODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7498CE0", Offset = "0x74980E0", VA = "0x187498CE0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float EEDBBAJPPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x74A35A0", Offset = "0x74A29A0", VA = "0x1874A35A0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform JHEBCBBCGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x74A1890", Offset = "0x74A0C90", VA = "0x1874A1890", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform BLINIOPDPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x20B2A80", Offset = "0x20B1E80", VA = "0x1820B2A80", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform LGBAPBLNKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20BE770", Offset = "0x20BDB70", VA = "0x1820BE770", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform JKPHHIDHECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1A5A750", Offset = "0x1A59B50", VA = "0x181A5A750", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool LIAMIABLOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x74A9490", Offset = "0x74A8890", VA = "0x1874A9490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool DHOLOJMGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x74952C0", Offset = "0x74946C0", VA = "0x1874952C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DACHLOHDCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74A2D20", Offset = "0x74A2120", VA = "0x1874A2D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x749CF20", Offset = "0x749C320", VA = "0x18749CF20")]
	private void GOKJPIJKLBK([In] DOHDGPIOHIE PICMDJADPLK, [In] AvatarFullBodyConfiguration FLKLAANBPFM, bool IDDGOOHHKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x749E8F0", Offset = "0x749DCF0", VA = "0x18749E8F0")]
	private float HAFHCMEODLA([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x749EB70", Offset = "0x749DF70", VA = "0x18749EB70")]
	private float HGIAPNDNPPF([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74A6700", Offset = "0x74A5B00", VA = "0x1874A6700")]
	private void LDFGKNNGIHO(DOHDGPIOHIE PICMDJADPLK, AvatarFullBodyConfiguration FLKLAANBPFM, bool IDDGOOHHKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74A6B60", Offset = "0x74A5F60", VA = "0x1874A6B60")]
	private void LFLFKNLMMGL([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74A34A0", Offset = "0x74A28A0", VA = "0x1874A34A0")]
	private void KJCAKNOGOFL([In] DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74AE380", Offset = "0x74AD780", VA = "0x1874AE380")]
	public PGICMFKDBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74AB120", Offset = "0x74AA520", VA = "0x1874AB120", Slot = "12")]
	public void OPCJGBFHJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74ABC90", Offset = "0x74AB090", VA = "0x1874ABC90", Slot = "13")]
	public void PGDLKHMOLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7497B80", Offset = "0x7496F80", VA = "0x187497B80", Slot = "14")]
	public void DFBBHOABBCK(bool DMGKGJAKKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7498580", Offset = "0x7497980", VA = "0x187498580", Slot = "25")]
	public Transform DNHCBJMIDEP(string FJLJJNGMMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74A3310", Offset = "0x74A2710", VA = "0x1874A3310", Slot = "26")]
	public Vector3? KIOLOMPMLBE(string FJLJJNGMMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74A00C0", Offset = "0x749F4C0", VA = "0x1874A00C0", Slot = "7")]
	public void IAJMEAMFIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7496C30", Offset = "0x7496030", VA = "0x187496C30")]
	private void BJLEGHOABFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74A6460", Offset = "0x74A5860", VA = "0x1874A6460")]
	private Vector3 KNEHCEKMHJE([In] DOHDGPIOHIE MLIDEILJAJE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74ACD40", Offset = "0x74AC140", VA = "0x1874ACD40", Slot = "6")]
	public void PPPCEENHDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x74A65E0", Offset = "0x74A59E0", VA = "0x1874A65E0", Slot = "8")]
	public void LABMPPLJFLE(float DACHNFBNDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7495240", Offset = "0x7494640", VA = "0x187495240")]
	private void AFFINBHJGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74A3A60", Offset = "0x74A2E60", VA = "0x1874A3A60", Slot = "4")]
	public void KLGKENCBJIB(string NNJDHALJMJF, ILCBGHOPBEI MMDAAIEGOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7495710", Offset = "0x7494B10", VA = "0x187495710", Slot = "5")]
	public void AJOLHKMPPBJ(CKPMFAMNJCP KFDMHDEHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74A6D20", Offset = "0x74A6120", VA = "0x1874A6D20", Slot = "11")]
	public void LHABLOHFECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74A9100", Offset = "0x74A8500", VA = "0x1874A9100", Slot = "24")]
	public void OFCENCIGNMM([Out] Vector3 HMOBDIFMAOH, [Out] Quaternion FGHKDCEANBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x749A5B0", Offset = "0x74999B0", VA = "0x18749A5B0")]
	private void FPBNGACJFBN([In] DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7499030", Offset = "0x7498430", VA = "0x187499030", Slot = "27")]
	public void ENLLDJGFKFF(float KKNOHOAHCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74A7820", Offset = "0x74A6C20", VA = "0x1874A7820", Slot = "28")]
	public void MOCJCONHNJJ(float POCNCNLKNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7496E10", Offset = "0x7496210", VA = "0x187496E10", Slot = "44")]
	public void BOHPKOKNBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74AC900", Offset = "0x74ABD00", VA = "0x1874AC900", Slot = "29")]
	public void PNJLGJPAMGF(bool FBHFGFFEBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74A2EA0", Offset = "0x74A22A0", VA = "0x1874A2EA0", Slot = "30")]
	public HandLogicOffsets KBEDLCCMOGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x74A37A0", Offset = "0x74A2BA0", VA = "0x1874A37A0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets KJJFBBNJEKC()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7495290", Offset = "0x7494690", VA = "0x187495290")]
	private void AHDGNMMDNOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x74A2A90", Offset = "0x74A1E90", VA = "0x1874A2A90")]
	private void JNBCMFCAJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x74975C0", Offset = "0x74969C0", VA = "0x1874975C0")]
	private void CLPLEBJNBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7499E20", Offset = "0x7499220", VA = "0x187499E20")]
	private void FEPHCECLIIB(AIOKEFGMGBL LAMEMGAPFKE, bool DPDMJKGJHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7496AA0", Offset = "0x7495EA0", VA = "0x187496AA0")]
	private void BGHLIIHODAI(AIOKEFGMGBL LAMEMGAPFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x749EED0", Offset = "0x749E2D0", VA = "0x18749EED0")]
	public Vector3 HIAAHFGOJHL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x749A110", Offset = "0x7499510", VA = "0x18749A110")]
	private void FFKJAMPLAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74988D0", Offset = "0x7497CD0", VA = "0x1874988D0")]
	private void EBAAINJNPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x74A1A90", Offset = "0x74A0E90", VA = "0x1874A1A90")]
	private void IOFHMGLCEOL(DOHDGPIOHIE PICMDJADPLK, AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x74986D0", Offset = "0x7497AD0", VA = "0x1874986D0")]
	private float DPFNJJJMCGN([In] DOHDGPIOHIE MLIDEILJAJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7496D30", Offset = "0x7496130", VA = "0x187496D30")]
	private int BMJBGOACCJG([In] ELEIPFKNBOG GAFDEDOGHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x74A6F10", Offset = "0x74A6310", VA = "0x1874A6F10")]
	private void MKFGDFBNKNL(DOHDGPIOHIE PICMDJADPLK, bool LPAEMJFOBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74A3860", Offset = "0x74A2C60", VA = "0x1874A3860")]
	private static void KKPMJIGPPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x749A5E0", Offset = "0x74999E0", VA = "0x18749A5E0")]
	private static void GBNMFJMJNPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x74A8E20", Offset = "0x74A8220", VA = "0x1874A8E20")]
	private float OCLCALAMMFD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x74A1520", Offset = "0x74A0920", VA = "0x1874A1520")]
	private static int IIOOKHDPCLP(PGICMFKDBOE BBGKOKBOEGA, PGICMFKDBOE NBNHMPFPBPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7496730", Offset = "0x7495B30", VA = "0x187496730", Slot = "40")]
	public DOHDGPIOHIE ANEAEJDGPAI()
	{
		return default(DOHDGPIOHIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74A14A0", Offset = "0x74A08A0", VA = "0x1874A14A0")]
	public void IIOJJMMKHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74A8C20", Offset = "0x74A8020", VA = "0x1874A8C20")]
	private (bool, bool) OADOEPMMMAK()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x74A8A40", Offset = "0x74A7E40", VA = "0x1874A8A40")]
	private (float, float) OAAMGFEFENI([In] DOHDGPIOHIE MLIDEILJAJE)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x74A9660", Offset = "0x74A8A60", VA = "0x1874A9660")]
	private void OHKILNOGEAB([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x74A08C0", Offset = "0x749FCC0", VA = "0x1874A08C0")]
	private void IAMPENAMCHE([In] DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74A2EF0", Offset = "0x74A22F0", VA = "0x1874A2EF0")]
	private void KCLFJGBJFOM([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM, AvatarFootSettings CLFJKLFHCAJ, bool IAFDLKBABEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7497B00", Offset = "0x7496F00", VA = "0x187497B00")]
	private float DELMOCIAABM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7499040", Offset = "0x7498440", VA = "0x187499040")]
	private void FAAHDJDEKBG(DOHDGPIOHIE MLIDEILJAJE, AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x74A7440", Offset = "0x74A6840", VA = "0x1874A7440")]
	private float MKJEHIBMJFN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x74AB630", Offset = "0x74AAA30", VA = "0x1874AB630")]
	private void PAHCIMGFLKA([In] DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x749EBF0", Offset = "0x749DFF0", VA = "0x18749EBF0")]
	private void HGKMDDBBLAD([In] DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x74AC950", Offset = "0x74ABD50", VA = "0x1874AC950")]
	private void PNOKLKCNJJJ([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x74A26E0", Offset = "0x74A1AE0", VA = "0x1874A26E0")]
	private void JJLGNIDGLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x74AC050", Offset = "0x74AB450", VA = "0x1874AC050")]
	private void PHEKIMANMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x74A18F0", Offset = "0x74A0CF0", VA = "0x1874A18F0")]
	private void ILLFJCDDACO([In] DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7496E60", Offset = "0x7496260", VA = "0x187496E60")]
	private void BPEBHPMJJEA(FMKLMOOCMIN HCEJOBEKGFD, IKSolverVR.Arm LCFKKEIDGPI, Transform FJIOGMDGCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x74A7490", Offset = "0x74A6890", VA = "0x1874A7490")]
	private void MOBCHGBLHEJ(DOHDGPIOHIE MLIDEILJAJE, AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7496560", Offset = "0x7495960", VA = "0x187496560")]
	private void ALGHBALMIKL(MEOCNJEEBBM HDFBMDHIHJN, MBDCKCDIJDA HCEJOBEKGFD, IKSolverVR.Arm LCFKKEIDGPI, float CIHGAPEDKLC, float CIGOBKEKMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x74A8440", Offset = "0x74A7840", VA = "0x1874A8440")]
	private void NOHABHCLEBE([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x74AC530", Offset = "0x74AB930", VA = "0x1874AC530")]
	protected void PMGLIBNNDFE([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x74A2410", Offset = "0x74A1810", VA = "0x1874A2410")]
	private void JJGAMDKBDLH([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x74A6210", Offset = "0x74A5610", VA = "0x1874A6210")]
	protected void KMNGEHGIGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7497C50", Offset = "0x7497050", VA = "0x187497C50")]
	private void DLIJOAPCDPF([In] DOHDGPIOHIE MLIDEILJAJE, [In] AKMOFHBFDIL PFDDBBNLJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x749E9C0", Offset = "0x749DDC0", VA = "0x18749E9C0")]
	private void HGGCHEHOIAH(DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x749E980", Offset = "0x749DD80", VA = "0x18749E980")]
	private void HEJMOBDAIEL([In] DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7494D30", Offset = "0x7494130", VA = "0x187494D30")]
	private Vector3 ABCHIIIDOPJ([In] DOHDGPIOHIE MLIDEILJAJE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x74A9590", Offset = "0x74A8990", VA = "0x1874A9590")]
	private void OGNJKFAHMCN([In] DOHDGPIOHIE MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x749EF20", Offset = "0x749E320", VA = "0x18749EF20")]
	private float HIGDLJLHINJ(float BOBBAFCKGAN, [In] DOHDGPIOHIE MLIDEILJAJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7499CD0", Offset = "0x74990D0", VA = "0x187499CD0")]
	private void FEBOHDMEPOM(float BOBBAFCKGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x749C040", Offset = "0x749B440", VA = "0x18749C040")]
	private void GLLMHDIGAML([In] DOHDGPIOHIE MLIDEILJAJE, AKMOFHBFDIL PFDDBBNLJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x74A0CE0", Offset = "0x74A00E0", VA = "0x1874A0CE0")]
	private float IINHAOGANOE([In] DOHDGPIOHIE PICMDJADPLK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x749C730", Offset = "0x749BB30", VA = "0x18749C730")]
	private void GOKDKFMDAHG(DOHDGPIOHIE MLIDEILJAJE, AKMOFHBFDIL PFDDBBNLJHI, Vector3 DMGELHDJBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x74A35F0", Offset = "0x74A29F0", VA = "0x1874A35F0")]
	private static void KJFOGFFBONH(Transform NCNOHDPHPJB, Quaternion NBFJKGINHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x749F3B0", Offset = "0x749E7B0", VA = "0x18749F3B0")]
	private void HOHHJIIBEOB([In] DOHDGPIOHIE MJFFNOMLMPK, [In] ELEIPFKNBOG GAFDEDOGHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7495BB0", Offset = "0x7494FB0", VA = "0x187495BB0")]
	private void AKBIMAOKJKO([In] DOHDGPIOHIE MJFFNOMLMPK, [In] ELEIPFKNBOG GAFDEDOGHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7494B40", Offset = "0x7493F40", VA = "0x187494B40")]
	private void AAJNMBBGEPC(float GHEDBHKMIEA, [In] DOHDGPIOHIE PICMDJADPLK, float CJNMHJBGEPE = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x74A7B70", Offset = "0x74A6F70", VA = "0x1874A7B70")]
	private float NJPEMFANIAB([In] DOHDGPIOHIE PICMDJADPLK, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x74989F0", Offset = "0x7497DF0", VA = "0x1874989F0")]
	private void EJPODPIJDFG([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x749F6E0", Offset = "0x749EAE0", VA = "0x18749F6E0")]
	private void HOPLBFCFLPL([In] DOHDGPIOHIE PICMDJADPLK, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7495340", Offset = "0x7494740", VA = "0x187495340")]
	private void AIENDKPAFLG([In] DOHDGPIOHIE PICMDJADPLK, float DHGMEIJKCFC, float JECNJLGNBJN, Vector3 EECFHCONDJK, float CJNMHJBGEPE = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x749B640", Offset = "0x749AA40", VA = "0x18749B640")]
	private void GKFJLJKKJLO(DOHDGPIOHIE PICMDJADPLK, AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x74AC2A0", Offset = "0x74AB6A0", VA = "0x1874AC2A0")]
	private void PJABLEHCDEP(DOHDGPIOHIE MLIDEILJAJE, AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x74A1550", Offset = "0x74A0950", VA = "0x1874A1550")]
	private void IIPBFEKAIBC(DOHDGPIOHIE PICMDJADPLK, AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7498D70", Offset = "0x7498170", VA = "0x187498D70")]
	public void EMOACLGNNFF([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7497250", Offset = "0x7496650", VA = "0x187497250")]
	public void CLPHIHGNLED([In] DOHDGPIOHIE MLIDEILJAJE, [In] AvatarFullBodyConfiguration FLKLAANBPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x74ABAF0", Offset = "0x74AAEF0", VA = "0x1874ABAF0")]
	[CompilerGenerated]
	internal static void PBAFCMNCNMN(Transform BLMGNEDEHDK, IKSolverVR.Arm LCFKKEIDGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x74A6650", Offset = "0x74A5A50", VA = "0x1874A6650")]
	[CompilerGenerated]
	internal static void LBODOPMIKJH(Vector3 HLDLLICLEAI, Vector3 PBDAMPILHLE, DLCBLGHGIPJ P_2, FMJHLCBNCFE P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x749A510", Offset = "0x7499910", VA = "0x18749A510")]
	[CompilerGenerated]
	internal static void FODFKILKHGP(HHGICEBOLLD CCFAKGMEBGJ, HHGICEBOLLD KBPHHNFMOFD, Vector3 NPKBFNLCCLH, float JPAKKPAOGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x74A2C10", Offset = "0x74A2010", VA = "0x1874A2C10")]
	[CompilerGenerated]
	internal static bool JOKPJENJLCK(IKSolverVR.Arm LCFKKEIDGPI, AMNEJNPHKDL MHJHFBGHAHI, float MEMEGDKJCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x74A5DD0", Offset = "0x74A51D0", VA = "0x1874A5DD0")]
	[CompilerGenerated]
	internal static float KMFJLGOCKKN(Vector3 MJNPCPJPBDN, Vector3 MFAAGGKHHGB, Vector3 NAJBFPFDCOA, DOHDGPIOHIE PICMDJADPLK, AvatarFullBodyConfiguration FLKLAANBPFM, float FGCNBOMLCIC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class AGFPGGPILNH : MIKLNAIBLFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<string, PPBGPPFLHFP> FDIINFBCABK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x74AEDE0", Offset = "0x74AE1E0", VA = "0x1874AEDE0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC]
	internal static void IFBCHFNGGOF(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x74AEB50", Offset = "0x74ADF50", VA = "0x1874AEB50", Slot = "4")]
	public PPBGPPFLHFP AFFNGNOCGCK(string OLPGCAHBHPP, AvatarSystemConfiguration AMOMBCNFLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x74AEF90", Offset = "0x74AE390", VA = "0x1874AEF90", Slot = "5")]
	public void KIJCGBACNLN(string OLPGCAHBHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x74AEE50", Offset = "0x74AE250", VA = "0x1874AEE50", Slot = "6")]
	public string IIOMAADAMII(string MGMFKIEJBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x74AED70", Offset = "0x74AE170", VA = "0x1874AED70")]
	private string HIMDFDNMOEN(string MGMFKIEJBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x74AF170", Offset = "0x74AE570", VA = "0x1874AF170")]
	public AGFPGGPILNH()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class PBNLLNPPAHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private Dictionary<string, Transform> KKMEANOLJLC;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool EAANCJCJLOJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x74B9E80", Offset = "0x74B9280", VA = "0x1874B9E80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x74B9D50", Offset = "0x74B9150", VA = "0x1874B9D50")]
			public void IEGKFFLJGHH(VRIK BHEELPJPJPL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
			public void BCJHBAOPOON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x74B9D00", Offset = "0x74B9100", VA = "0x1874B9D00")]
			public void HKGADJFONBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x74B9EC0", Offset = "0x74B92C0", VA = "0x1874B9EC0")]
			public PBNLLNPPAHL()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		[NMHMDFOPAOE(MFMOBKOPAIF.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[IGKHBFEOLOG(MFMOBKOPAIF.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly PBNLLNPPAHL AOBKPBJJEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private DHIFFBJMEJF FELJHFCADGB;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x74AFC40", Offset = "0x74AF040", VA = "0x1874AFC40")]
		private void OBBALIPJEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x74AFBF0", Offset = "0x74AEFF0", VA = "0x1874AFBF0")]
		private bool EKCJONBIGIB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x74AFF20", Offset = "0x74AF320", VA = "0x1874AFF20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x74AFF90", Offset = "0x74AF390", VA = "0x1874AFF90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x74AFF30", Offset = "0x74AF330", VA = "0x1874AFF30")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x74B0200", Offset = "0x74AF600", VA = "0x1874B0200")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x74B2610", Offset = "0x74B1A10", VA = "0x1874B2610")]
			public void MEKFCHHLHOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x74B24D0", Offset = "0x74B18D0", VA = "0x1874B24D0")]
			public (float, float) FJNCHNLONLP(Animator FIIDFFKLCFC, AnimatorStateInfo EAPEHKGJEGK)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x74B2AF0", Offset = "0x74B1EF0", VA = "0x1874B2AF0")]
		public void MEKFCHHLHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x74B28E0", Offset = "0x74B1CE0", VA = "0x1874B28E0")]
		public (float, float) LGAHOKCEACI(Animator FIIDFFKLCFC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x74B26F0", Offset = "0x74B1AF0", VA = "0x1874B26F0")]
		private (float, float) BEJFINDMBMF(Animator FIIDFFKLCFC, AnimatorStateInfo EAPEHKGJEGK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x74B2CE0", Offset = "0x74B20E0", VA = "0x1874B2CE0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x74B9080", Offset = "0x74B8480", VA = "0x1874B9080", Slot = "4")]
		public override void OnStateEnter(Animator FIIDFFKLCFC, AnimatorStateInfo EAPEHKGJEGK, int HGPLELKKFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x74B91E0", Offset = "0x74B85E0", VA = "0x1874B91E0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class FKMBFELHBMH<TInput, TOutput> : NPILLHODFPM<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected readonly JJHMNFHFHIL NLLOMHBDPLH;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x450E750", Offset = "0x450DB50", VA = "0x18450E750")]
	protected FKMBFELHBMH(JJHMNFHFHIL NLLOMHBDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput NHMCOOCBIHH(TInput NIPDIMDKGGA, [Out] IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x450E6B0", Offset = "0x450DAB0", VA = "0x18450E6B0", Slot = "5")]
	public bool JNJCCNIMPBH(TInput NIPDIMDKGGA, [Out] TOutput? HOCIBOCHCFJ, [Out] IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[MENIDINFMMJ]
public static class BGCPCPMPIKM
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly Regex PEGBECONIHF;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x74B0440", Offset = "0x74AF840", VA = "0x1874B0440")]
	public static BDNAEELKJJI FOBAOMHOCNC(HOEDMLCMIIH DLBCELKPPFF, APAOJHILPJK KMDGCJDPFJN, Guid? BNFNDCGCFGH, Color? DEOEIENJBEE, FGFOFKPBCAF CBBFCGBIHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x74B02E0", Offset = "0x74AF6E0", VA = "0x1874B02E0")]
	public static HEFHKNJHOBF FBDAGNLKLKG(BDNAEELKJJI MJFOKKFMONL)
	{
		return default(HEFHKNJHOBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3200800", Offset = "0x31FFC00", VA = "0x183200800")]
	internal static TModern? FDDNMCPENNK<TModern>(string? NIPDIMDKGGA, DGEJEGPCHIG<TModern> ICKGBEMEJCO, JJHMNFHFHIL NLLOMHBDPLH, OHCMILONPPI EGLPPAFFJBA, TModern LIEGAKLFHGA) where TModern : struct, COENILANACJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x31FF200", Offset = "0x31FE600", VA = "0x1831FF200")]
	internal static DHPFFADDMDJ AJBAEHBMCEB<TModern>(string? NIPDIMDKGGA, DGEJEGPCHIG<TModern> ICKGBEMEJCO, JJHMNFHFHIL NLLOMHBDPLH, OHCMILONPPI EGLPPAFFJBA, TModern LIEGAKLFHGA) where TModern : struct, COENILANACJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x74B0650", Offset = "0x74AFA50", VA = "0x1874B0650")]
	internal static List<JOKNDKDOAOG> JLMGKOFOEMK(IEnumerable<BJNDGNOHJIG>? NFCOACKCLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x31FF9E0", Offset = "0x31FEDE0", VA = "0x1831FF9E0")]
	internal static string CMEEAAJBHOE<TModern>(TModern NIPDIMDKGGA, DGEJEGPCHIG<TModern> ICKGBEMEJCO, JJHMNFHFHIL NLLOMHBDPLH) where TModern : COENILANACJ
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class NLECMFMFOLM : FMPJBLDCLOC
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NPILLHODFPM<FMCBLLPHGJK, GKDBEGOBGHP> MGMPCBKDAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NPILLHODFPM<JBDKFAALPPD, EODCNACCAOB> MFDPOBPIGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NPILLHODFPM<JBDKFAALPPD, EODCNACCAOB> DDBFFGMMAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LCDCONAGJMM HJBMDLOKGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KDKKJDJBNMO GFIFBJDJPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x74B9730", Offset = "0x74B8B30", VA = "0x1874B9730")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	[UsedImplicitly]
	internal static void IDEOAALFMGD(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x74B97A0", Offset = "0x74B8BA0", VA = "0x1874B97A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NLECMFMFOLM([PNFCCJKFMBH("UnitySerialization")] OKIBPJIPCEN BHGJMPFFAFF, [PNFCCJKFMBH(null)] AALNDNADIPN FNOMGDENIIC, [PNFCCJKFMBH(null)] JJHMNFHFHIL NLLOMHBDPLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum MNKGMKJPLGM
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CKIOBAFAGKG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x74B0860", Offset = "0x74AFC60", VA = "0x1874B0860")]
	public CKIOBAFAGKG(string LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x74B0830", Offset = "0x74AFC30", VA = "0x1874B0830")]
	public CKIOBAFAGKG(string LPIFIOEEOGF, Exception JALIEJNBJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x74B0890", Offset = "0x74AFC90", VA = "0x1874B0890")]
	public CKIOBAFAGKG(MNKGMKJPLGM LNEEKMIFMOP, string LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x74B08C0", Offset = "0x74AFCC0", VA = "0x1874B08C0")]
	public CKIOBAFAGKG(MNKGMKJPLGM LNEEKMIFMOP, string LPIFIOEEOGF, Exception JALIEJNBJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class MJIBCJHPGPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly OKIBPJIPCEN BHGJMPFFAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly AALNDNADIPN FNOMGDENIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly JJHMNFHFHIL NLLOMHBDPLH;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x74B33E0", Offset = "0x74B27E0", VA = "0x1874B33E0")]
	protected MJIBCJHPGPG(OKIBPJIPCEN BHGJMPFFAFF, AALNDNADIPN FNOMGDENIIC, JJHMNFHFHIL NLLOMHBDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x74B7DB0", Offset = "0x74B71B0", VA = "0x1874B7DB0")]
	protected string KBAEAPPCLIN(GKDBEGOBGHP BFLCMMHHBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x74B7750", Offset = "0x74B6B50", VA = "0x1874B7750")]
	protected string ANELGMOMMJK(GKDBEGOBGHP BFLCMMHHBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x74B7A80", Offset = "0x74B6E80", VA = "0x1874B7A80")]
	private AvatarOutfitSelectionData FOBAOMHOCNC(BDNAEELKJJI LDPLECPNAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x74B7940", Offset = "0x74B6D40", VA = "0x1874B7940")]
	private static AvatarCustomizationSettingsData.AnchorParams FNLNAHIKBAM(CFIMFIIKPEO? FJKEGLCCHFI)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NPILLHODFPM<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput NHMCOOCBIHH(TInput NIPDIMDKGGA, [Out] IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JNJCCNIMPBH(TInput NIPDIMDKGGA, [Out] TOutput? HOCIBOCHCFJ, [Out] IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FMPJBLDCLOC
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NPILLHODFPM<FMCBLLPHGJK, GKDBEGOBGHP> MGMPCBKDAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NPILLHODFPM<JBDKFAALPPD, EODCNACCAOB> DDBFFGMMAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LCDCONAGJMM HJBMDLOKGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum OHCMILONPPI
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KDKKJDJBNMO
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MIPOHCOGFHL EFGCEHNIDJN(GKDBEGOBGHP MJFOKKFMONL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LCDCONAGJMM
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JBDKFAALPPD EFGCEHNIDJN(GKDBEGOBGHP MJFOKKFMONL, int ABHPEBOHJHB, string? OGOCCCFKJPG, string? PCFHDJDLMFG, IHODNCAIHCO ALEBFNOGPNE, List<JOKNDKDOAOG>? CKFGAKGEIMH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[MENIDINFMMJ]
internal class KMFEKEFBJOB : FKMBFELHBMH<FMCBLLPHGJK, GKDBEGOBGHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly AALNDNADIPN FNOMGDENIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly IHMIDPGMOON CNICINJBNMB;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x74B7580", Offset = "0x74B6980", VA = "0x1874B7580")]
	public KMFEKEFBJOB(OKIBPJIPCEN BHGJMPFFAFF, AALNDNADIPN FNOMGDENIIC, JJHMNFHFHIL NLLOMHBDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x74B72E0", Offset = "0x74B66E0", VA = "0x1874B72E0", Slot = "6")]
	public override GKDBEGOBGHP NHMCOOCBIHH(FMCBLLPHGJK NIPDIMDKGGA, [Out] IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class JNEFKAAKEJG : OKIBPJIPCEN
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class DPDBACOHKAF : JsonConverter<DHPFFADDMDJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x74B1140", Offset = "0x74B0540", VA = "0x1874B1140", Slot = "9")]
		public override void WriteJson(JsonWriter MGKMPBCECKN, DHPFFADDMDJ? PEBNJNGMMHE, JsonSerializer PLMEPNACBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x74B1020", Offset = "0x74B0420", VA = "0x1874B1020", Slot = "10")]
		public override DHPFFADDMDJ ReadJson(JsonReader AENCLAHFBDP, Type DIKJKPHGOEG, DHPFFADDMDJ? LANBFFGLEHJ, bool KNMLPJCCGHD, JsonSerializer PLMEPNACBMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x74B11E0", Offset = "0x74B05E0", VA = "0x1874B11E0")]
		public DPDBACOHKAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class ENMEGHHPFMO : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool NCHOJGIPJAI
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x74B15E0", Offset = "0x74B09E0", VA = "0x1874B15E0", Slot = "5")]
		public override object ReadJson(JsonReader AENCLAHFBDP, Type DIKJKPHGOEG, object? LANBFFGLEHJ, JsonSerializer PLMEPNACBMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x74B1220", Offset = "0x74B0620", VA = "0x1874B1220", Slot = "6")]
		public override bool CanConvert(Type DIKJKPHGOEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x74B1640", Offset = "0x74B0A40", VA = "0x1874B1640", Slot = "4")]
		public override void WriteJson(JsonWriter MGKMPBCECKN, object? PEBNJNGMMHE, JsonSerializer PLMEPNACBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x74B1400", Offset = "0x74B0800", VA = "0x1874B1400")]
		private static bool IGLKAFFFNEC(object PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public ENMEGHHPFMO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings LHOBKNFOAPB;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x74B5AA0", Offset = "0x74B4EA0", VA = "0x1874B5AA0")]
	internal JNEFKAAKEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x351EDA0", Offset = "0x351E1A0", VA = "0x18351EDA0", Slot = "4")]
	public string CBOBFEDPAEP<T>(T NBAMGPFDMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x351EE00", Offset = "0x351E200", VA = "0x18351EE00", Slot = "5")]
	public T OHCIJAPMKHE<T>(string PEBNJNGMMHE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class COEPANLCBKP : OKIBPJIPCEN
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x328B180", Offset = "0x328A580", VA = "0x18328B180", Slot = "4")]
	public string CBOBFEDPAEP<T>(T NBAMGPFDMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x328B200", Offset = "0x328A600", VA = "0x18328B200", Slot = "5")]
	public T OHCIJAPMKHE<T>(string PEBNJNGMMHE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public COEPANLCBKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[MENIDINFMMJ]
internal class IHMIDPGMOON : FKMBFELHBMH<JBDKFAALPPD, EODCNACCAOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly OKIBPJIPCEN BHGJMPFFAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly AALNDNADIPN FNOMGDENIIC;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x74B5960", Offset = "0x74B4D60", VA = "0x1874B5960")]
	public IHMIDPGMOON(OKIBPJIPCEN BHGJMPFFAFF, AALNDNADIPN FNOMGDENIIC, JJHMNFHFHIL NLLOMHBDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x74B4AC0", Offset = "0x74B3EC0", VA = "0x1874B4AC0", Slot = "6")]
	public override EODCNACCAOB NHMCOOCBIHH(JBDKFAALPPD NIPDIMDKGGA, [Out] IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x74B3C70", Offset = "0x74B3070", VA = "0x1874B3C70")]
	internal void GNNOFAEHMIN(string LKODGMEPAJI, GKDBEGOBGHP BFLCMMHHBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x74B3DC0", Offset = "0x74B31C0", VA = "0x1874B3DC0")]
	public IEnumerable<BDNAEELKJJI> HMANECOEGDO(string BFKAGJHALDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x74B3860", Offset = "0x74B2C60", VA = "0x1874B3860")]
	private IEnumerable<BDNAEELKJJI> DLAHDNFKAMG(string BFKAGJHALDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x74B3FD0", Offset = "0x74B33D0", VA = "0x1874B3FD0")]
	internal IEnumerable<BDNAEELKJJI> JLBCMFLKIDL(string BFKAGJHALDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x74B4740", Offset = "0x74B3B40", VA = "0x1874B4740")]
	private BDNAEELKJJI KKEJJMIOMCI(AvatarOutfitSelectionData KGELDIJAJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x74B4EE0", Offset = "0x74B42E0", VA = "0x1874B4EE0")]
	private void ONNEOFDMGNI(AvatarCustomizationSettingsData DNMLHGOLFDB, GKDBEGOBGHP BFLCMMHHBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x74B4420", Offset = "0x74B3820", VA = "0x1874B4420")]
	private BDNAEELKJJI KKEJJMIOMCI(string IKEEPHJFOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x74B3560", Offset = "0x74B2960", VA = "0x1874B3560")]
	internal static (FGFOFKPBCAF, string, string) ADJCOGCJDNK(string IKEEPHJFOPE, JJHMNFHFHIL NLLOMHBDPLH)
	{
		return default((FGFOFKPBCAF, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x74B5760", Offset = "0x74B4B60", VA = "0x1874B5760")]
	private GMOHEDJKJCH? PPGEJHFPKEM(string? BCIHOIBCNMJ, Vector2 LPCBIJGIIBF, float JFONOIBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x74B3E70", Offset = "0x74B3270", VA = "0x1874B3E70")]
	private static CFIMFIIKPEO IMIHPOBLEHH(AvatarCustomizationSettingsData.AnchorParams JDOBNCOLDLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[MENIDINFMMJ]
internal class IAEKKGAMKGG : MJIBCJHPGPG, KDKKJDJBNMO
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x74B33E0", Offset = "0x74B27E0", VA = "0x1874B33E0")]
	public IAEKKGAMKGG(OKIBPJIPCEN BHGJMPFFAFF, AALNDNADIPN FNOMGDENIIC, JJHMNFHFHIL NLLOMHBDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x74B2F30", Offset = "0x74B2330", VA = "0x1874B2F30", Slot = "4")]
	public MIPOHCOGFHL EFGCEHNIDJN(GKDBEGOBGHP MJFOKKFMONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x74B32E0", Offset = "0x74B26E0", VA = "0x1874B32E0")]
	private string LANBIABAENO(GKDBEGOBGHP BFLCMMHHBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x74B2CF0", Offset = "0x74B20F0", VA = "0x1874B2CF0")]
	private string DKOOHEOLNCE(BDNAEELKJJI LDPLECPNAKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[MENIDINFMMJ]
internal class NJNGALOFCLJ : FKMBFELHBMH<JBDKFAALPPD, EODCNACCAOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly OKIBPJIPCEN BHGJMPFFAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly NPILLHODFPM<JBDKFAALPPD, EODCNACCAOB> FJKHNHKIMKD;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x74B9630", Offset = "0x74B8A30", VA = "0x1874B9630")]
	public NJNGALOFCLJ(NPILLHODFPM<JBDKFAALPPD, EODCNACCAOB> FJKHNHKIMKD, JJHMNFHFHIL NLLOMHBDPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x74B9200", Offset = "0x74B8600", VA = "0x1874B9200", Slot = "6")]
	public override EODCNACCAOB NHMCOOCBIHH(JBDKFAALPPD NIPDIMDKGGA, [Out] IReadOnlyList<JOKNDKDOAOG>? CKFGAKGEIMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[MENIDINFMMJ]
internal class CLHCBCDCMAD : LCDCONAGJMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly OKIBPJIPCEN BHGJMPFFAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly KDKKJDJBNMO ELECPLOBOAP;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x74B0CA0", Offset = "0x74B00A0", VA = "0x1874B0CA0")]
	public CLHCBCDCMAD(KDKKJDJBNMO ELECPLOBOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x74B0900", Offset = "0x74AFD00", VA = "0x1874B0900", Slot = "4")]
	public JBDKFAALPPD EFGCEHNIDJN(GKDBEGOBGHP MJFOKKFMONL, int ABHPEBOHJHB, string? OGOCCCFKJPG, string? PCFHDJDLMFG, IHODNCAIHCO ALEBFNOGPNE, List<JOKNDKDOAOG>? CKFGAKGEIMH)
	{
		return null;
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
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x74AF2B0", Offset = "0x74AE6B0", VA = "0x1874AF2B0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DHNAAFKFMMD
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x74B0F10", Offset = "0x74B0310", VA = "0x1874B0F10")]
	public static HEFHKNJHOBF NHMCOOCBIHH(this CNOBGECJNAD MJFOKKFMONL)
	{
		return default(HEFHKNJHOBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x74B0D90", Offset = "0x74B0190", VA = "0x1874B0D90")]
	public static CNOBGECJNAD EFGCEHNIDJN(this HEFHKNJHOBF KHKMGOAAPFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x74B0EB0", Offset = "0x74B02B0", VA = "0x1874B0EB0")]
	public static bool EPKALAEDHGD(this HEFHKNJHOBF KHKMGOAAPFM)
	{
		return default(bool);
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
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x5657B70", Offset = "0x5656F70", VA = "0x185657B70")]
			public AnchorParams(Vector2 JEEPPACFOCD, Vector3 FKNJHOMMHBO, Vector3 IOONKEHABOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x74AF200", Offset = "0x74AE600", VA = "0x1874AF200")]
			internal CFIMFIIKPEO EFGCEHNIDJN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private JKJEECCDFGN useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x74AFAA0", Offset = "0x74AEEA0", VA = "0x1874AFAA0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4737810", Offset = "0x4736C10", VA = "0x184737810")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xBB5B80", Offset = "0xBB4F80", VA = "0x180BB5B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xDEF010", Offset = "0xDEE410", VA = "0x180DEF010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x1091010", Offset = "0x1090410", VA = "0x181091010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x969460", Offset = "0x968860", VA = "0x180969460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x74AFB40", Offset = "0x74AEF40", VA = "0x1874AFB40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x96FCD0", Offset = "0x96F0D0", VA = "0x18096FCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xAEF550", Offset = "0xAEE950", VA = "0x180AEF550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAEF490", Offset = "0xAEE890", VA = "0x180AEF490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x96A970", Offset = "0x969D70", VA = "0x18096A970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x74AFB80", Offset = "0x74AEF80", VA = "0x1874AFB80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xD32210", Offset = "0xD31610", VA = "0x180D32210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xF3ED70", Offset = "0xF3E170", VA = "0x180F3ED70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x15894C0", Offset = "0x15888C0", VA = "0x1815894C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9642F0", Offset = "0x9636F0", VA = "0x1809642F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x964300", Offset = "0x963700", VA = "0x180964300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x2048EC0", Offset = "0x20482C0", VA = "0x182048EC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xD31480", Offset = "0xD30880", VA = "0x180D31480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x99C000", Offset = "0x99B400", VA = "0x18099C000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x99C060", Offset = "0x99B460", VA = "0x18099C060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x971410", Offset = "0x970810", VA = "0x180971410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x971400", Offset = "0x970800", VA = "0x180971400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9712F0", Offset = "0x9706F0", VA = "0x1809712F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9712E0", Offset = "0x9706E0", VA = "0x1809712E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x9712A0", Offset = "0x9706A0", VA = "0x1809712A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x971450", Offset = "0x970850", VA = "0x180971450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xACC560", Offset = "0xACB960", VA = "0x180ACC560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1179AC0", Offset = "0x1178EC0", VA = "0x181179AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9712D0", Offset = "0x9706D0", VA = "0x1809712D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9713A0", Offset = "0x9707A0", VA = "0x1809713A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xBDAFB0", Offset = "0xBDA3B0", VA = "0x180BDAFB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD458D0", Offset = "0xD44CD0", VA = "0x180D458D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x9744C0", Offset = "0x9738C0", VA = "0x1809744C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x974460", Offset = "0x973860", VA = "0x180974460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xB16520", Offset = "0xB15920", VA = "0x180B16520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xD2A950", Offset = "0xD29D50", VA = "0x180D2A950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB77A60", Offset = "0xB76E60", VA = "0x180B77A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB745D0", Offset = "0xB739D0", VA = "0x180B745D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public JKJEECCDFGN UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xDF8830", Offset = "0xDF7C30", VA = "0x180DF8830")]
			get
			{
				return default(JKJEECCDFGN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xDF6660", Offset = "0xDF5A60", VA = "0x180DF6660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xDF6440", Offset = "0xDF5840", VA = "0x180DF6440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAC6530", Offset = "0xAC5930", VA = "0x180AC6530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x74AFB60", Offset = "0x74AEF60", VA = "0x1874AFB60")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x74AFBA0", Offset = "0x74AEFA0", VA = "0x1874AFBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x74AF740", Offset = "0x74AEB40", VA = "0x1874AF740")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public FGFOFKPBCAF BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private KKPPLOGPOPC? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x74AFBC0", Offset = "0x74AEFC0", VA = "0x1874AFBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
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
