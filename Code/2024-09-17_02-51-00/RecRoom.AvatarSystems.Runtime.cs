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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B0EC00", Offset = "0x6B0D600", VA = "0x186B0EC00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B27640", Offset = "0x6B26040", VA = "0x186B27640", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHFFCNPJGMC]
internal class ICKGFDHIOFE : JLPMIGIAPFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MHLBBBKNPPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public ICKGFDHIOFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public MMBBNHOOGFA avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly BGMCMDNMHIA PONGNEMMMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IFBNHKGJPFP ANAOINBJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AJNIAJIHFAO GEADAFALECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly PDJHHOACBKG IEABHMKLMCF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C510", Offset = "0x6B0AF10", VA = "0x186B0C510")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	[UsedImplicitly]
	internal static void PFBAJLCCLFO(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C580", Offset = "0x6B0AF80", VA = "0x186B0C580")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ICKGFDHIOFE([OLJNBPOCBCJ(null)] BGMCMDNMHIA PONGNEMMMIG, [OLJNBPOCBCJ(null)] IFBNHKGJPFP ANAOINBJOPP, [OLJNBPOCBCJ(null)] AJNIAJIHFAO GEADAFALECJ, [OLJNBPOCBCJ(null)] PDJHHOACBKG IEABHMKLMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B370", Offset = "0x6B09D70", VA = "0x186B0B370", Slot = "5")]
	public HLICDDLODBP LHEEHIJNBAM(MMBBNHOOGFA KLAGAOLBONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BB40", Offset = "0x6B0A540", VA = "0x186B0BB40", Slot = "4")]
	public HLICDDLODBP LKDHCHCDFCB(MMBBNHOOGFA KLAGAOLBONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B260", Offset = "0x6B09C60", VA = "0x186B0B260", Slot = "6")]
	public BKMBOEENOCF LELOEFPBIGB(HLICDDLODBP JGCMECODHDI, int IFGAAGJBJJB, string? KJPHMNNIMDP, string? PHLKCGNACMI, HMAPOJNAMII NCLEFBNEIPE, List<LNLLCGLHGIO>? IEMLJEFHJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B1D0", Offset = "0x6B09BD0", VA = "0x186B0B1D0", Slot = "7")]
	public bool GIJHEEEAFIJ(FOGBEJFOLCM ELFAHMMNJJI, [Out] HLICDDLODBP? IMKFEKABGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B0F0", Offset = "0x6B09AF0", VA = "0x186B0B0F0", Slot = "8")]
	public bool EMFNFJMBMMH(BKMBOEENOCF DOPBGCMNMFK, [Out] HLICDDLODBP? IMKFEKABGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AD80", Offset = "0x6B09780", VA = "0x186B0AD80", Slot = "9")]
	public bool BDHBHNPNKAL(BKMBOEENOCF DOPBGCMNMFK, [Out] ICAMEONBIKE? ELFAHMMNJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E04090", Offset = "0x2E02A90", VA = "0x182E04090")]
	private bool LCHJGBPGNKB<TInput, TOutput>(TInput DIGEGMNKCOG, NDGIHGCPFAO<TInput, TOutput> PFONMJCBBHN, [Out] TOutput? POBDLJBBBCI) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B0ABD0", Offset = "0x6B095D0", VA = "0x186B0ABD0")]
	[CompilerGenerated]
	private EEADPOEJMLJ AJOKJEJFKLP(FaceFeatureType NKBCJKAPIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B0AE10", Offset = "0x6B09810", VA = "0x186B0AE10")]
	[CompilerGenerated]
	private EEADPOEJMLJ CIENHBHJKMC(FaceFeatureType NKBCJKAPIOK, MHLBBBKNPPL P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NHFFCNPJGMC]
internal class POFKPPCDDLO : BGMCMDNMHIA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void AMPPGOCONOD<in TData>(TData IMKFEKABGOM, IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AJNIAJIHFAO GEADAFALECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CICIOHJMEBM LONCLMCGANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AMPPGOCONOD<HLICDDLODBP>?[] PONGNEMMMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AMPPGOCONOD<ICAMEONBIKE>?[] GCNDDGNJALM;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B27220", Offset = "0x6B25C20", VA = "0x186B27220")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	[UsedImplicitly]
	internal static void PFBAJLCCLFO(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B27290", Offset = "0x6B25C90", VA = "0x186B27290")]
	[RecRoom.NoEngine.Common.Preserve]
	internal POFKPPCDDLO([OLJNBPOCBCJ(null)] AJNIAJIHFAO GEADAFALECJ, [OLJNBPOCBCJ(null)] CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B26360", Offset = "0x6B24D60", VA = "0x186B26360", Slot = "4")]
	public bool IBPLGFNMCEN(HLICDDLODBP IMKFEKABGOM, IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B26460", Offset = "0x6B24E60", VA = "0x186B26460", Slot = "5")]
	public bool IBPLGFNMCEN(ICAMEONBIKE ELFAHMMNJJI, IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B265C0", Offset = "0x6B24FC0", VA = "0x186B265C0")]
	private void IEFKBEFPLDJ(HLICDDLODBP IMKFEKABGOM, IReadOnlyList<LNLLCGLHGIO>? MNKBAIOBLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B26FF0", Offset = "0x6B259F0", VA = "0x186B26FF0")]
	private void OPNGAECIMAA(HLICDDLODBP IMKFEKABGOM, IReadOnlyList<LNLLCGLHGIO>? MNKBAIOBLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B26300", Offset = "0x6B24D00", VA = "0x186B26300")]
	private void ALEKCKFFIAA(HLICDDLODBP IMKFEKABGOM, IReadOnlyList<LNLLCGLHGIO>? MNKBAIOBLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B26330", Offset = "0x6B24D30", VA = "0x186B26330")]
	private void EHDAAICANGA(HLICDDLODBP IMKFEKABGOM, IReadOnlyList<LNLLCGLHGIO>? MNKBAIOBLHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BGMCMDNMHIA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IBPLGFNMCEN(HLICDDLODBP IMKFEKABGOM, IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IBPLGFNMCEN(ICAMEONBIKE ELFAHMMNJJI, IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN);
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
		public DGMNNKMGKLI AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6B06BE0", Offset = "0x6B055E0", VA = "0x186B06BE0")]
		public void FFGJHALEIOH(AnimationPoseSetting PLNBHPCFEOK, float FKNHFEJKCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B06D10", Offset = "0x6B05710", VA = "0x186B06D10")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendHelperController : MonoBehaviour, AGHMFCLPFNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
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
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool DebugExecutionInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Vector3? CBKKNMNOJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool MPENAHJNLKK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B06D30", Offset = "0x6B05730", VA = "0x186B06D30", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B07320", Offset = "0x6B05D20", VA = "0x186B07320", Slot = "4")]
		public void UpdateController(float BKOJCILPMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x10C2CD0", Offset = "0x10C16D0", VA = "0x1810C2CD0", Slot = "6")]
		public void SetEnabled(bool KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B06DD0", Offset = "0x6B057D0", VA = "0x186B06DD0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B077B0", Offset = "0x6B061B0", VA = "0x186B077B0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarElbowBendTargetController : MonoBehaviour, AGHMFCLPFNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float MFLNLPNKKHM = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
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
		private Vector3 AFPLHBOHHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 IPCPDNPDGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool MPENAHJNLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float IJKDOPAIJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float PBLIDKPNIIH;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B07B30", Offset = "0x6B06530", VA = "0x186B07B30", Slot = "4")]
		public void UpdateController(float BKOJCILPMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xBA3FA0", Offset = "0xBA29A0", VA = "0x180BA3FA0", Slot = "6")]
		public void SetEnabled(bool KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6B07850", Offset = "0x6B06250", VA = "0x186B07850")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B085F0", Offset = "0x6B06FF0", VA = "0x186B085F0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B08F00", Offset = "0x6B07900", VA = "0x186B08F00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B08EC0", Offset = "0x6B078C0", VA = "0x186B08EC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B08620", Offset = "0x6B07020", VA = "0x186B08620")]
		private void LIOIBBDIKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1240", Offset = "0x6ACFC40", VA = "0x186AD1240", Slot = "4")]
		public void SetEnabled(bool GCKGFMHINMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6B08F30", Offset = "0x6B07930", VA = "0x186B08F30")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarForearmRollController : MonoBehaviour, AGHMFCLPFNI
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
		private float IJKDOPAIJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool MPENAHJNLKK;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6B08F70", Offset = "0x6B07970", VA = "0x186B08F70", Slot = "4")]
		public void UpdateController(float BKOJCILPMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x105F1C0", Offset = "0x105DBC0", VA = "0x18105F1C0", Slot = "6")]
		public void SetEnabled(bool KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B099F0", Offset = "0x6B083F0", VA = "0x186B099F0")]
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
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
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
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
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
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
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
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
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
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
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
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
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

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B09A60", Offset = "0x6B08460", VA = "0x186B09A60")]
		public AnimationPoseSetting CPNLONIFPCB(DGMNNKMGKLI JGPMOKPIKHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B09A20", Offset = "0x6B08420", VA = "0x186B09A20")]
		public void AMLGEKNOMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B09A90", Offset = "0x6B08490", VA = "0x186B09A90")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
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

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AB90", Offset = "0x6B09590", VA = "0x186B0AB90")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JMBCCIGLFFI : OBHAINDJFAC
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static int JLADOOPHKIP;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int KMPILKKKLLC;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int NGJGDCBKIGH;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int MIAENBMELNN;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int FBOAGKJGJID;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static int EBNHPPADAEB;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int KAOBBDLFBOA;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int[] KHGMGAFNDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private PBAKPJDKFHO NOMMJLCEHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private DLPGIEHHLCP ECFMHHMLFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int GBIEOLELCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float FAMBBPPHCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Animator FIHFGMCJOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AvatarFullBodyConfiguration FCOCCEKEKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int JPJDMOLCHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private int ENMJKNANDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int KBAMIKHDOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool GCHBPMMOKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private DBEOJGMKMIH GIHMBHGGJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int LEJOICMDKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private float JPPIOPEPEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private HandDisplaySettings PFHKICGCJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private MMBBNHOOGFA BGDLBFFIJNC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform GEGKNMNPIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 LCBHLPGGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10325C0", Offset = "0x1030FC0", VA = "0x1810325C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x10325B0", Offset = "0x1030FB0", VA = "0x1810325B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion KGPIOAEGHHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1687CD0", Offset = "0x16866D0", VA = "0x181687CD0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x20D0B00", Offset = "0x20CF500", VA = "0x1820D0B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool FJCCFNDPNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF30", Offset = "0x6B0B930", VA = "0x186B0CF30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C770", Offset = "0x6B0B170", VA = "0x186B0C770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 GBAMEKGDHML
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE2DA60", Offset = "0xE2C460", VA = "0x180E2DA60", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xE2CCE0", Offset = "0xE2B6E0", VA = "0x180E2CCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion HAKEKDJGCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB0F2E0", Offset = "0xB0DCE0", VA = "0x180B0F2E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE2C2D0", Offset = "0xE2ACD0", VA = "0x180E2C2D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HLBJMBIMBFF LJLMDGLGJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9D0410", Offset = "0x9CEE10", VA = "0x1809D0410", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(HLBJMBIMBFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9D0D40", Offset = "0x9CF740", VA = "0x1809D0D40", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HLBJMBIMBFF JGBFMDKIALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x14F6180", Offset = "0x14F4B80", VA = "0x1814F6180", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(HLBJMBIMBFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1C67530", Offset = "0x1C65F30", VA = "0x181C67530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float ECMAPGGBIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x16BFA50", Offset = "0x16BE450", VA = "0x1816BFA50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9D0E70", Offset = "0x9CF870", VA = "0x1809D0E70", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HICHJEKLAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CD60", Offset = "0x6B0B760", VA = "0x186B0CD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IJDBLLDAMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CC10", Offset = "0x6B0B610", VA = "0x186B0CC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool GEPOGMPNLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B0C7A0", Offset = "0x6B0B1A0", VA = "0x186B0C7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool EBJJPDJJNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CD50", Offset = "0x6B0B750", VA = "0x186B0CD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C7B0", Offset = "0x6B0B1B0", VA = "0x186B0C7B0", Slot = "21")]
	public void AIFHKOLJDOL(PBAKPJDKFHO LAJMJOEIOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CCB0", Offset = "0x6B0B6B0", VA = "0x186B0CCB0")]
	public void IDIJJJFAMNH(DLPGIEHHLCP MPPFDGEFPLB, HandDisplaySettings HDGFLAHCMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CC20", Offset = "0x6B0B620", VA = "0x186B0CC20", Slot = "12")]
	public void HKCPNNPBDFM(bool BDGDGHAINAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CF60", Offset = "0x6B0B960", VA = "0x186B0CF60", Slot = "11")]
	public void OPJFNAENCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CD70", Offset = "0x6B0B770", VA = "0x186B0CD70")]
	private int NCNHENGNFKF(HLBJMBIMBFF MPKBOPEBFAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CA50", Offset = "0x6B0B450", VA = "0x186B0CA50")]
	private void CGDGKCGMNBJ(int EFMLEILEFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CBA0", Offset = "0x6B0B5A0", VA = "0x186B0CBA0", Slot = "13")]
	public bool CLJCALFJGFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CBC0", Offset = "0x6B0B5C0", VA = "0x186B0CBC0", Slot = "14")]
	public bool EGNGCNCAAPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6B0C9E0", Offset = "0x6B0B3E0", VA = "0x186B0C9E0")]
	private HLBJMBIMBFF BIMDBJKGFOB()
	{
		return default(HLBJMBIMBFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x985980", Offset = "0x984380", VA = "0x180985980", Slot = "15")]
	public void DENMHPPLCOD(bool BDGDGHAINAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CBD0", Offset = "0x6B0B5D0", VA = "0x186B0CBD0", Slot = "10")]
	public void GHELLCNBGEO(int EFMLEILEFEH, float DIOCPDIGPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CA30", Offset = "0x6B0B430", VA = "0x186B0CA30", Slot = "8")]
	public void BNBPJJIIFBJ(DBEOJGMKMIH FDKAGJLJMPF, bool OPPPLDKFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D290", Offset = "0x6B0BC90", VA = "0x186B0D290", Slot = "9")]
	public void PELOMKKEFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CD00", Offset = "0x6B0B700", VA = "0x186B0CD00", Slot = "16")]
	public void LICIHFNJCCO(Transform LDJCBIBELIM, Vector3 IAHEMABMPLA, Quaternion DGALDAFMLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D530", Offset = "0x6B0BF30", VA = "0x186B0D530")]
	public JMBCCIGLFFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PIOOFPEGKHN : DGFMLABLMOB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class FMNGKJOMDED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 MAPLAHHAAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Quaternion ICLNPDOBJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Vector3 OBIBDBJIIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Transform EHMEGOBBELE;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 OLNCDMFLJFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x17129A0", Offset = "0x17113A0", VA = "0x1817129A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x17129C0", Offset = "0x17113C0", VA = "0x1817129C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion PIEHLAJCHJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xD82400", Offset = "0xD80E00", VA = "0x180D82400")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD82060", Offset = "0xD80A60", VA = "0x180D82060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float HFODBEONMOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xB0F390", Offset = "0xB0DD90", VA = "0x180B0F390")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x10E0780", Offset = "0x10DF180", VA = "0x1810E0780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool FJPEFCCDNBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8999B0", Offset = "0x8983B0", VA = "0x1808999B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x899940", Offset = "0x898340", VA = "0x180899940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool PMPJMOJOICD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x899920", Offset = "0x898320", VA = "0x180899920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x899860", Offset = "0x898260", VA = "0x180899860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool COEKDFKGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x899AC0", Offset = "0x8984C0", VA = "0x180899AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8999E0", Offset = "0x8983E0", VA = "0x1808999E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float BBELGADBFLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xB0F3B0", Offset = "0xB0DDB0", VA = "0x180B0F3B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x271C9E0", Offset = "0x271B3E0", VA = "0x18271C9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A7D0", Offset = "0x6B091D0", VA = "0x186B0A7D0")]
		public void IJBKKLFAGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6B09E20", Offset = "0x6B08820", VA = "0x186B09E20")]
		public void AICPLLHGPHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A9B0", Offset = "0x6B093B0", VA = "0x186B0A9B0")]
		public float NEKLAKNDJNC(Transform FCOMLCEDOAO, [In] FootSettings GLFMNKIMBDI, float GOJABGFGMBC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6B09E30", Offset = "0x6B08830", VA = "0x186B09E30")]
		public void BDFEJONNPME(Transform OMMOCILKGDG, Transform BEPJIKJNKCE, float BKOEFAONODO, bool HPPLGGHJPFJ, bool DEEKFOBFDGH, float CEAHIBPCKPE, float DLDKAJNBBCH, Transform JPBBEMPIGCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A590", Offset = "0x6B08F90", VA = "0x186B0A590")]
		public void IDIDIHCGBEN(Transform FPCLPENLPKA, Transform JPBBEMPIGCM, bool MBNFCMDLDKG, bool MNGDLJMJKLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A8B0", Offset = "0x6B092B0", VA = "0x186B0A8B0")]
		private void KGIHMBMICNF(Transform JPBBEMPIGCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A7E0", Offset = "0x6B091E0", VA = "0x186B0A7E0")]
		public void JALKAAINPBO(Transform JPBBEMPIGCM, AvatarFullBodyConfiguration JNHFGLCOILM, Vector3 JFGODMFGEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6B0A7C0", Offset = "0x6B091C0", VA = "0x186B0A7C0")]
		public void IEANIONKDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AB80", Offset = "0x6B09580", VA = "0x186B0AB80")]
		public FMNGKJOMDED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class MHCCELNKDKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float GJAPLBIJJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool PDEGFBDNDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AnimationPoseSetting KBCAKMCAMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float ENFIHICHBJC;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E970", Offset = "0x6B0D370", VA = "0x186B0E970")]
		public void KLCEOBOHMJA(IKSolverVR.Arm IIDLFNJLMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EB40", Offset = "0x6B0D540", VA = "0x186B0EB40")]
		public void PCIDJKJGLKH(IKSolverVR.Arm IIDLFNJLMFA, float CBLJMEOOJLE, bool PDEGFBDNDHA, AvatarFullBodyConfiguration JNHFGLCOILM, float ECEHKCOBPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E9A0", Offset = "0x6B0D3A0", VA = "0x186B0E9A0")]
		private void LHACEFGEBJO(IKSolverVR.Arm IIDLFNJLMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E590", Offset = "0x6B0CF90", VA = "0x186B0E590")]
		public void IBAIGAHBJGF(IKSolverVR.Arm IIDLFNJLMFA, Transform NELGCANFECC, Transform BEPJIKJNKCE, Quaternion NLCJPLCGMLM, Vector3 KKMPKNILPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D540", Offset = "0x6B0BF40", VA = "0x186B0D540")]
		private (Vector3, Quaternion) AHIPJNGIMEK(JMBCCIGLFFI FLOEIBCLCPH, Quaternion DKBJPMLCLBM, Vector3 NENODAPODNL)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E9E0", Offset = "0x6B0D3E0", VA = "0x186B0E9E0")]
		public void OJMACDFFMHJ(JMBCCIGLFFI FLOEIBCLCPH, IKSolverVR.Arm IIDLFNJLMFA, Quaternion DKBJPMLCLBM, Vector3 NENODAPODNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D9D0", Offset = "0x6B0C3D0", VA = "0x186B0D9D0")]
		public void BEJKMNBCIPH(JMBCCIGLFFI FLOEIBCLCPH, IKSolverVR.Arm IIDLFNJLMFA, Quaternion DKBJPMLCLBM, Vector3 NENODAPODNL, [In] AvatarFullBodyConfiguration JNHFGLCOILM, [In] OPAGPNNBGJH FDKAGJLJMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6B0E450", Offset = "0x6B0CE50", VA = "0x186B0E450")]
		public void FEAKHMOMNJE(DGMNNKMGKLI BHFPDDEHCFA, AvatarFullBodyConfiguration JNHFGLCOILM, OPAGPNNBGJH FDKAGJLJMPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DFD0", Offset = "0x6B0C9D0", VA = "0x186B0DFD0")]
		public void CJEIEFAGEHD(IKSolverVR.Arm IIDLFNJLMFA, Transform NELGCANFECC, Vector3 LGMKIOHHJCF, float NHHBGPCHEEK, Quaternion PHBJCMHPNAA, Vector3 NALCGJEJFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EB80", Offset = "0x6B0D580", VA = "0x186B0EB80")]
		public MHCCELNKDKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum KBOAAPEPBPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int NHDLHOLPOPP;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int EIMJPGECJHB;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int ELHOJMFIBDJ;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int DMCHCABAFDG;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int JMGINKPDPNA;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int KBJLKMEHAIH;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int HIPNNBLBCPP;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int DACNILDEFGA;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int FLHIPMOEDIB;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int JDAAGEAIHJH;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int BODIMHNMLGH;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int LLKDGGMGDFD;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int DOIDCNIFOAA;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int DEJHCNBBJOD;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int LCICCAMBGJF;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int GKMMFCCJGGF;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int ANBMOMDAGMB;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int ILMHPEDFNLB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int NHJCGHKICIN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int NKCCGNBPOGC;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int CDDDKBNHHFE;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int LGBFHHDCLMN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int HABJDFILNEH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int FDNIFIDBEEK;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int HMLAEADNMMI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int PAAOMHKJDAI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int HDIGHPDNKEB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int POLGAPELKID;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int NIFMOPGODOI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly Vector3 CAGPDKBCEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool MDAJPBPLPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool CONEHBGAOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool BNIOCBLDCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool JBENOHKCOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool LMGKHFFMIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Vector3 PFLDMIKKOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private string LKJIAEMPJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private BKNEINGFPBD? NOMMJLCEHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private KICAKJJBBFF? CLAMDMDCCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private MNENJKEIKJH HFABOJKCKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private JCIDAIIJICB FJHPPCCBIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private JMBCCIGLFFI JBAHMJBIFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JMBCCIGLFFI PLJFLLNNDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool KEEMKHGKABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool BPFEIFFAOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly OOOPGPMBMAH ALBDNKPHCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly ABHPOGICKMD KCKKHKHCNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int HNKIOINPBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private float PGBCIDIKHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private GameObject LEGOBPHOFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Transform CJLAJEAHNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform GHBIBCDFDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Transform FLCGENPBKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform JNDJAPOAKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform HCHCEHFPPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float IPEFBCKPJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float CJMHKFEIMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Vector3 APANGHHOFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Quaternion NEMOEMDGIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform OIJJJENDFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform ODAJDNKKNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform EFLIIKAJDHI;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker IPPCCAHMEDF;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker DCEIBDLKDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private ProfilerMarker BAKCOKLDLCE;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker KNBGOCCFFIC;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker IDEJKICKKIP;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker CBPHFHIDDJG;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly List<PIOOFPEGKHN> NIDPDHCDBBK;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int PKBHJOCNANN;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> JNDMIFJNKPE;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int HKCAKFJFECK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int IOKOBNMJJNL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int LGCNNCKBMJN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int NNICKAGAHIC;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static float GHHMEGPPKPE;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int LHIHGHHDEFB;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static float FOKOKLKJBCL;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static float EMIHOMJEFEP;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float NGKCLOMNLMG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static float JBMLGPNCBFE;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static EOFILPOAPFK PBBKJDKJHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float PHJAICBJNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool HGCECNDGFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float NCGEFMJHLNM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly int OOMLAFEHFIM;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly int JGGOGCKLNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private FMNGKJOMDED EIHDONIMEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private FMNGKJOMDED JKDMMIHMFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private float DICBNIOIJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Vector3 KGGDLGCFPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private Vector3 NCKAIMLNLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool DKCGCPHEPMH;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly Quaternion ONLJBNPNANN;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly Quaternion IAJHFECBBJD;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly Vector3 PJACMFOACIM;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly Vector3 DBJMHOIKOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float KEGCHGLKHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float HAOFIHHBGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private MHCCELNKDKP NPLHBKGMCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private MHCCELNKDKP JBOPGOLOECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private CMMAOPGPEEA DNEEHMPKLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private FJEGNLGIDFA NJCCCBDPEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ODEALKDCELD DDAPCOIIAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float HPPHNPPGFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float DHFICJNACOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly FJEGNLGIDFA FJHEPJDHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 NAGKPGEHCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 IGJCPLLKJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float KCPHFGAMMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private float BMMHMMMBNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly FJEGNLGIDFA HACLPJHPBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly CMMAOPGPEEA MCFNMDGPCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly FJEGNLGIDFA CAACONJMKGO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GHNLMGKLHKE KOGLOJOALGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GHNLMGKLHKE IKBKLGOMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration APKPKHKHPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6B1A6A0", Offset = "0x6B190A0", VA = "0x186B1A6A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MMBBNHOOGFA GNDMCEHMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6B22D50", Offset = "0x6B21750", VA = "0x186B22D50", Slot = "23")]
		get
		{
			return default(MMBBNHOOGFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration FDEKBPLBGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6B1B4F0", Offset = "0x6B19EF0", VA = "0x186B1B4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform MJJFIFIMDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B17B90", Offset = "0x6B16590", VA = "0x186B17B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform GHHGOKLLELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B1AB30", Offset = "0x6B19530", VA = "0x186B1AB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer NMJFODJEMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B0EC80", Offset = "0x6B0D680", VA = "0x186B0EC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] FMIEKPKKEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B142A0", Offset = "0x6B12CA0", VA = "0x186B142A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] EELAJAAKEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6B20700", Offset = "0x6B1F100", VA = "0x186B20700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator NCJPCILLKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B22C50", Offset = "0x6B21650", VA = "0x186B22C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK BFPLBDAFDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B24910", Offset = "0x6B23310", VA = "0x186B24910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private AGHMFCLPFNI NLIEDPBBOAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1A7A0", Offset = "0x6B191A0", VA = "0x186B1A7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private AGHMFCLPFNI JILPLBBHAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1C8B0", Offset = "0x6B1B2B0", VA = "0x186B1C8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private AGHMFCLPFNI JFFHHPBEHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B14AF0", Offset = "0x6B134F0", VA = "0x186B14AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private AGHMFCLPFNI BAGKEJGLJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B109E0", Offset = "0x6B0F3E0", VA = "0x186B109E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private AGHMFCLPFNI NIOIHBLOLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B194C0", Offset = "0x6B17EC0", VA = "0x186B194C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private AGHMFCLPFNI CNKNKGILLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B24A10", Offset = "0x6B23410", VA = "0x186B24A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private AGHMFCLPFNI OPDPEJOOOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B17A90", Offset = "0x6B16490", VA = "0x186B17A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private AGHMFCLPFNI HFDKNOGFDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B220A0", Offset = "0x6B20AA0", VA = "0x186B220A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public KICAKJJBBFF LPCGOLMKMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6B24060", Offset = "0x6B22A60", VA = "0x186B24060", Slot = "15")]
		get
		{
			return default(KICAKJJBBFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CDCGOHLJDLI NPCIGPFDCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x158D670", Offset = "0x158C070", VA = "0x18158D670", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public HBMOFOAEPNJ FFFMDAMCGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x162FCB0", Offset = "0x162E6B0", VA = "0x18162FCB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public OBHAINDJFAC AHHMNOINCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x19C6160", Offset = "0x19C4B60", VA = "0x1819C6160", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public OBHAINDJFAC NBFMDGDBPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x174A6C0", Offset = "0x17490C0", VA = "0x18174A6C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string PEPAJCGIHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform LGKKFBEDLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6B14AA0", Offset = "0x6B134A0", VA = "0x186B14AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform PMFCFEMFMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6B195C0", Offset = "0x6B17FC0", VA = "0x186B195C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform HMMHFCKLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6B14930", Offset = "0x6B13330", VA = "0x186B14930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool HIHJNPHALFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1A2C0", Offset = "0x6B18CC0", VA = "0x186B1A2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform GCLGNHCEDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6B19630", Offset = "0x6B18030", VA = "0x186B19630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject MNKAGJEGJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6B13F20", Offset = "0x6B12920", VA = "0x186B13F20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets BCPOIFMJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6B201C0", Offset = "0x6B1EBC0", VA = "0x186B201C0", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform CODDGOCBNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xD577E0", Offset = "0xD561E0", VA = "0x180D577E0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform ODHNCCFOPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD577C0", Offset = "0xD561C0", VA = "0x180D577C0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CIFLANIKJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x174A850", Offset = "0x1749250", VA = "0x18174A850", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform IHCBFPNNFON
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1548FD0", Offset = "0x15479D0", VA = "0x181548FD0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 FABDDMEMNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1D120", Offset = "0x6B1BB20", VA = "0x186B1D120", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float DALBBKIFPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1A270", Offset = "0x6B18C70", VA = "0x186B1A270", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform NDIIBIPFAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6B13670", Offset = "0x6B12070", VA = "0x186B13670", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform ABPCOAHGCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1A3A140", Offset = "0x1A38B40", VA = "0x181A3A140", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform OCAIDCMJLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1A3A220", Offset = "0x1A38C20", VA = "0x181A3A220", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform AMNPEDGOEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1549BA0", Offset = "0x15485A0", VA = "0x181549BA0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool ADDGLLCNOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6B149A0", Offset = "0x6B133A0", VA = "0x186B149A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool OEFOBKKKPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B1B260", Offset = "0x6B19C60", VA = "0x186B1B260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool JJIJFDPMDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6B18530", Offset = "0x6B16F30", VA = "0x186B18530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6B20800", Offset = "0x6B1F200", VA = "0x186B20800")]
	private void NGOHNEDCBCC([In] OPAGPNNBGJH JIONEMJPPAA, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EEC0", Offset = "0x6B0D8C0", VA = "0x186B0EEC0")]
	private void AILLIHGJCBK(OPAGPNNBGJH JIONEMJPPAA, AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B090", Offset = "0x6B19A90", VA = "0x186B1B090")]
	private void IPFCJJLABML([In] OPAGPNNBGJH FDKAGJLJMPF, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6B25E50", Offset = "0x6B24850", VA = "0x186B25E50")]
	public PIOOFPEGKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F790", Offset = "0x6B0E190", VA = "0x186B0F790", Slot = "12")]
	public void BGHCGDOMOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B18680", Offset = "0x6B17080", VA = "0x186B18680", Slot = "13")]
	public void GLIBLAOEGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F630", Offset = "0x6B0E030", VA = "0x186B0F630", Slot = "14")]
	public void BDJJFJENIPC(bool DEEICJFAFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B1AF40", Offset = "0x6B19940", VA = "0x186B1AF40", Slot = "25")]
	public Transform IMPDDFFEBPD(string HCCNHFMDGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B360", Offset = "0x6B19D60", VA = "0x186B1B360", Slot = "26")]
	public Vector3? JFCFKCONMFG(string HCCNHFMDGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B16E10", Offset = "0x6B15810", VA = "0x186B16E10", Slot = "7")]
	public void FGFLDCOBFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B10F10", Offset = "0x6B0F910", VA = "0x186B10F10")]
	private void BOLHBFABLDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B14DA0", Offset = "0x6B137A0", VA = "0x186B14DA0", Slot = "6")]
	public void EJGJKJFPFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F860", Offset = "0x6B1E260", VA = "0x186B1F860", Slot = "8")]
	public void MAGIHKBEELD(float LJDIPJFBPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F700", Offset = "0x6B0E100", VA = "0x186B0F700")]
	private void BEFJMDDDMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B11010", Offset = "0x6B0FA10", VA = "0x186B11010", Slot = "4")]
	public void BPMBLACIKKC(string CPHGKKKLKCK, BKNEINGFPBD BDFALAHGPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B20240", Offset = "0x6B1EC40", VA = "0x186B20240", Slot = "5")]
	public void MHPLJKGDFGA(KICAKJJBBFF MPPFDGEFPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F540", Offset = "0x6B0DF40", VA = "0x186B0F540", Slot = "11")]
	public void AONPGCDOGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6B130C0", Offset = "0x6B11AC0", VA = "0x186B130C0", Slot = "24")]
	public void CCJJICLDCMH([Out] Vector3 HEIJCLDDEIL, [Out] Quaternion PHBJCMHPNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B19730", Offset = "0x6B18130", VA = "0x186B19730")]
	private void HHMICAHKFII([In] OPAGPNNBGJH FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D200", Offset = "0x6B1BC00", VA = "0x186B1D200", Slot = "27")]
	public void KNOLGOCJIHK(float ANHGIHGFDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B19760", Offset = "0x6B18160", VA = "0x186B19760", Slot = "28")]
	public void HHMPGLEJKED(float OADFBBBEBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE10", Offset = "0x6B1B810", VA = "0x186B1CE10", Slot = "44")]
	public void KIPPABDLMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B14250", Offset = "0x6B12C50", VA = "0x186B14250", Slot = "29")]
	public void DDMEIOHLIBC(bool GECBJHMPCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B1AEF0", Offset = "0x6B198F0", VA = "0x186B1AEF0", Slot = "30")]
	public HandLogicOffsets IMLOGMFKOCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6B13000", Offset = "0x6B11A00", VA = "0x186B13000", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets CAPBDOAGBIA()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F700", Offset = "0x6B1E100", VA = "0x186B1F700")]
	private void LNLHICMKDMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B13A20", Offset = "0x6B12420", VA = "0x186B13A20")]
	private void COHHAPOEEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F260", Offset = "0x6B0DC60", VA = "0x186B0F260")]
	private void ANCMAPOOFPD(EKIGEEIGKIO CPMCPPFHEIF, bool AMABBFGDEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D420", Offset = "0x6B1BE20", VA = "0x186B1D420")]
	private void LADJPMAOJOF(EKIGEEIGKIO CPMCPPFHEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D1B0", Offset = "0x6B1BBB0", VA = "0x186B1D1B0")]
	public Vector3 KNJHBINIBKM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B19AC0", Offset = "0x6B184C0", VA = "0x186B19AC0")]
	private void HHNNLCPHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B23210", Offset = "0x6B21C10", VA = "0x186B23210")]
	private void ONOLBJMALDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B14BF0", Offset = "0x6B135F0", VA = "0x186B14BF0")]
	private float EGPJDEHKAFK([In] OPAGPNNBGJH FDKAGJLJMPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1AA50", Offset = "0x6B19450", VA = "0x186B1AA50")]
	private int IIGEIMHLCJF([In] KKBMCNLDLHC NIEJNIPNGJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B18000", Offset = "0x6B16A00", VA = "0x186B18000")]
	private void GJBGIDKKFBN(OPAGPNNBGJH JIONEMJPPAA, bool AMBMPPBODOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D210", Offset = "0x6B1BC10", VA = "0x186B1D210")]
	private static void KPEELOBOCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B0FCB0", Offset = "0x6B0E6B0", VA = "0x186B0FCB0")]
	private static void BJADMIGEAPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B1EC20", Offset = "0x6B1D620", VA = "0x186B1EC20")]
	private float LIBOMMMOMMM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B0ED80", Offset = "0x6B0D780", VA = "0x186B0ED80")]
	private static int ADGDIGOOOCL(PIOOFPEGKHN NFCDCHABNCB, PIOOFPEGKHN BCBMNIEKAKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C9B0", Offset = "0x6B1B3B0", VA = "0x186B1C9B0", Slot = "40")]
	public OPAGPNNBGJH KGNJFCMAHGA()
	{
		return default(OPAGPNNBGJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A310", Offset = "0x6B18D10", VA = "0x186B1A310")]
	public void IAPODGNLDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B13450", Offset = "0x6B11E50", VA = "0x186B13450")]
	private (bool, bool) CCKGINGBEAJ()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B580", Offset = "0x6B19F80", VA = "0x186B1B580")]
	private void JJPEMKOLKCD([In] OPAGPNNBGJH FDKAGJLJMPF, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B10AE0", Offset = "0x6B0F4E0", VA = "0x186B10AE0")]
	private void BNICFPBNKNN([In] OPAGPNNBGJH FDKAGJLJMPF, [In] AvatarFullBodyConfiguration JNHFGLCOILM, FootSettings GLFMNKIMBDI, bool OGLMHCOLKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B2E0", Offset = "0x6B19CE0", VA = "0x186B1B2E0")]
	private float JECBJMKHFDM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B18A40", Offset = "0x6B17440", VA = "0x186B18A40")]
	private void GPCDNOLAGHA(OPAGPNNBGJH FDKAGJLJMPF, AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CDC0", Offset = "0x6B1B7C0", VA = "0x186B1CDC0")]
	private float KHGODOBKPGN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B19D80", Offset = "0x6B18780", VA = "0x186B19D80")]
	private void HILKEOENFDG([In] OPAGPNNBGJH FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A350", Offset = "0x6B18D50", VA = "0x186B1A350")]
	private void IBAIGAHBJGF([In] OPAGPNNBGJH FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1EE00", Offset = "0x6B1D800", VA = "0x186B1EE00")]
	private void LLJFMFKMECC([In] OPAGPNNBGJH FDKAGJLJMPF, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CB10", Offset = "0x6B1B510", VA = "0x186B1CB10")]
	private void KHBCLDFAOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E1F0", Offset = "0x6B1CBF0", VA = "0x186B1E1F0")]
	private void LFLPOKKFLLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6B136D0", Offset = "0x6B120D0", VA = "0x186B136D0")]
	private void CIONBFGMJJC([In] OPAGPNNBGJH FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B13FC0", Offset = "0x6B129C0", VA = "0x186B13FC0")]
	private void DDINAEKLCGK(JMBCCIGLFFI BOCEJLIKMCF, IKSolverVR.Arm IIDLFNJLMFA, Transform CIAPMBNICJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B17C90", Offset = "0x6B16690", VA = "0x186B17C90")]
	private void GIMJPHDGPFI(OPAGPNNBGJH FDKAGJLJMPF, AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6B23750", Offset = "0x6B22150", VA = "0x186B23750")]
	private void OPJFNAENCMN(DEDGPDMKNLK BFALPHMPPEG, OBHAINDJFAC BOCEJLIKMCF, IKSolverVR.Arm IIDLFNJLMFA, float CBLJMEOOJLE, float JGENHABLFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6B225A0", Offset = "0x6B20FA0", VA = "0x186B225A0")]
	private void NLHCEEDNJKI([In] OPAGPNNBGJH FDKAGJLJMPF, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6B221A0", Offset = "0x6B20BA0", VA = "0x186B221A0")]
	protected void NJPOHEHLGFA([In] OPAGPNNBGJH FDKAGJLJMPF, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6B24190", Offset = "0x6B22B90", VA = "0x186B24190")]
	private void PJIKHADCGFI([In] OPAGPNNBGJH FDKAGJLJMPF, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1AC30", Offset = "0x6B19630", VA = "0x186B1AC30")]
	protected void IILPHAMGHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B160A0", Offset = "0x6B14AA0", VA = "0x186B160A0")]
	private void ELBCOFBGGNO([In] OPAGPNNBGJH FDKAGJLJMPF, [In] KBOAAPEPBPG HOGMOFFKINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B13870", Offset = "0x6B12270", VA = "0x186B13870")]
	private void CMGBLLOLKFI(OPAGPNNBGJH FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F750", Offset = "0x6B0E150", VA = "0x186B0F750")]
	private void BEIHKIKNCON([In] OPAGPNNBGJH FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FD00", Offset = "0x6B1E700", VA = "0x186B1FD00")]
	private Vector3 MBEONPGHLLL([In] OPAGPNNBGJH FDKAGJLJMPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B13E50", Offset = "0x6B12850", VA = "0x186B13E50")]
	private void COOKALCJEEO([In] OPAGPNNBGJH FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B16830", Offset = "0x6B15230", VA = "0x186B16830")]
	private float EMNMNMOHMBL(float DLDKAJNBBCH, [In] OPAGPNNBGJH FDKAGJLJMPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B230C0", Offset = "0x6B21AC0", VA = "0x186B230C0")]
	private void OGEMDDAGOPO(float DLDKAJNBBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B24470", Offset = "0x6B22E70", VA = "0x186B24470")]
	private void PMJLBNFIFFB([In] OPAGPNNBGJH FDKAGJLJMPF, KBOAAPEPBPG HOGMOFFKINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6B143A0", Offset = "0x6B12DA0", VA = "0x186B143A0")]
	private float DJJJOFJLMPB([In] OPAGPNNBGJH JIONEMJPPAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B23230", Offset = "0x6B21C30", VA = "0x186B23230")]
	private void OOAEPHPMEEO(OPAGPNNBGJH FDKAGJLJMPF, KBOAAPEPBPG HOGMOFFKINB, Vector3 PJFGMKGOICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B178E0", Offset = "0x6B162E0", VA = "0x186B178E0")]
	private static void FOONMBDPLFC(Transform FLDLBOHKNDN, Quaternion JOLHFCINNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F3D0", Offset = "0x6B1DDD0", VA = "0x186B1F3D0")]
	private void LNBGIMAJEKL([In] OPAGPNNBGJH JLAGBOFNFIB, [In] KKBMCNLDLHC NIEJNIPNGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D5E0", Offset = "0x6B1BFE0", VA = "0x186B1D5E0")]
	private void LBNMIHODHHG([In] OPAGPNNBGJH JLAGBOFNFIB, [In] KKBMCNLDLHC NIEJNIPNGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A8A0", Offset = "0x6B192A0", VA = "0x186B1A8A0")]
	private void IHKNFNLKJLN(float PCBDDLKDMJE, [In] OPAGPNNBGJH JIONEMJPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B23920", Offset = "0x6B22320", VA = "0x186B23920")]
	private float PCMEKFFOIEA([In] OPAGPNNBGJH JIONEMJPPAA, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B22E50", Offset = "0x6B21850", VA = "0x186B22E50")]
	private void OCOPLENLDFI([In] OPAGPNNBGJH JIONEMJPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E440", Offset = "0x6B1CE40", VA = "0x186B1E440")]
	private void LGGKOLIGHKE([In] OPAGPNNBGJH JIONEMJPPAA, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DE50", Offset = "0x6B1C850", VA = "0x186B1DE50")]
	private void LDKOEPGBEJP([In] OPAGPNNBGJH JIONEMJPPAA, float CEGOGFIIGDL, float BGMGHAINBDH, Vector3 BEAFFDGFKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B24B10", Offset = "0x6B23510", VA = "0x186B24B10")]
	private void PNPJDLNHJIL(OPAGPNNBGJH JIONEMJPPAA, AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B174D0", Offset = "0x6B15ED0", VA = "0x186B174D0")]
	private void FLEOCCALFKA(OPAGPNNBGJH JIONEMJPPAA, AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CF50", Offset = "0x6B1B950", VA = "0x186B1CF50")]
	public void KKFCGGCOGHB([In] OPAGPNNBGJH FDKAGJLJMPF, [In] AvatarFullBodyConfiguration JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B16C60", Offset = "0x6B15660", VA = "0x186B16C60")]
	[CompilerGenerated]
	internal static void FAIFKEHAMIH(Transform MILPHOELICC, IKSolverVR.Arm IIDLFNJLMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B185B0", Offset = "0x6B16FB0", VA = "0x186B185B0")]
	[CompilerGenerated]
	internal static void GKKCGKAPCIH(FMNGKJOMDED MEALFJEOOGJ, FMNGKJOMDED IAKOAHAKLIF, Transform HDFBBNHCHAB, float ENDMINEHNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6B0EDB0", Offset = "0x6B0D7B0", VA = "0x186B0EDB0")]
	[CompilerGenerated]
	internal static bool AEHMIKDGEAD(IKSolverVR.Arm IIDLFNJLMFA, FLEACBBDJLG PKGFFGFMKLK, float CPDKMLPIKGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F8D0", Offset = "0x6B1E2D0", VA = "0x186B1F8D0")]
	[CompilerGenerated]
	internal static float MAICBBMOFPJ(Vector3 NBPLGDNCKCB, Vector3 FMBPJAFOGOI, Vector3 IPOBNJMIPNP, OPAGPNNBGJH JIONEMJPPAA, AvatarFullBodyConfiguration JNHFGLCOILM, float IEHCONIHMPO)
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
		public enum KPELMEKAKLB
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private KPELMEKAKLB handleType;

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

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6B29430", Offset = "0x6B27E30", VA = "0x186B29430")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6B293F0", Offset = "0x6B27DF0", VA = "0x186B293F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6B28DF0", Offset = "0x6B277F0", VA = "0x186B28DF0")]
		private void LIOIBBDIKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1240", Offset = "0x6ACFC40", VA = "0x186AD1240", Slot = "4")]
		public void SetEnabled(bool GCKGFMHINMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6B29460", Offset = "0x6B27E60", VA = "0x186B29460")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarKneeBendTargetController : MonoBehaviour, AGHMFCLPFNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
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
		private Vector3 AFPLHBOHHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private Vector3 CLODMLHNMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Vector3 OIDHADEINAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Matrix4x4 CKOHNMMNLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool MPENAHJNLKK;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6B29900", Offset = "0x6B28300", VA = "0x186B29900", Slot = "4")]
		public void UpdateController(float BKOJCILPMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6B298F0", Offset = "0x6B282F0", VA = "0x186B298F0", Slot = "6")]
		public void SetEnabled(bool KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6B29490", Offset = "0x6B27E90", VA = "0x186B29490")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6B29FC0", Offset = "0x6B289C0", VA = "0x186B29FC0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, OLKIHHNHEKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[Header("Configuration")]
		[SerializeField]
		private MMBBNHOOGFA avatarBodyType;

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
		[JLEDHNACBFM(LPFNGFMJOGK.SelfAndChildren, false, false, false)]
		[SerializeField]
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
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[Header("Equipment Slots")]
		[SerializeField]
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
		private DGFMLABLMOB DLAHJFCGCDF;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DGFMLABLMOB GMDLJHDFBFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7A50", VA = "0x1808E9050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform GKIPAMJDBGN
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x6B2AE50", Offset = "0x6B29850", VA = "0x186B2AE50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6B29FD0", Offset = "0x6B289D0", VA = "0x186B29FD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AD10", Offset = "0x6B29710", VA = "0x186B2AD10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6B2ACC0", Offset = "0x6B296C0", VA = "0x186B2ACC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AC50", Offset = "0x6B29650", VA = "0x186B2AC50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6B29FD0", Offset = "0x6B289D0", VA = "0x186B29FD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6B2A450", Offset = "0x6B28E50", VA = "0x186B2A450", Slot = "6")]
		public DGFMLABLMOB CreateAvatarSystem(string CPHGKKKLKCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AC50", Offset = "0x6B29650", VA = "0x186B2AC50", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6B2A080", Offset = "0x6B28A80", VA = "0x186B2A080", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AD60", Offset = "0x6B29760", VA = "0x186B2AD60", Slot = "9")]
		public void UpdatePostIKAnimControllers(float BKOJCILPMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[RecRoom.NoEngine.Common.Preserve]
internal class KMOJHOCCIJK : OPGKFDNNCCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private Dictionary<string, DGFMLABLMOB> DAEDDJCBAHC;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6B31D10", Offset = "0x6B30710", VA = "0x186B31D10")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void PEEAGEFAJML(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6B31AF0", Offset = "0x6B304F0", VA = "0x186B31AF0", Slot = "4")]
	public DGFMLABLMOB JOPOCGJAMGN(string MKHCCJCOBHM, AvatarSystemConfiguration JNHBLCGLMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6B31970", Offset = "0x6B30370", VA = "0x186B31970", Slot = "5")]
	public void GMGAABDEDHJ(string MKHCCJCOBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6B31830", Offset = "0x6B30230", VA = "0x186B31830", Slot = "6")]
	public string FLHCPEOHEOG(string MDGJIIBKBLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6B317C0", Offset = "0x6B301C0", VA = "0x186B317C0")]
	private string EPCLOMPECMB(string MDGJIIBKBLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6B31D80", Offset = "0x6B30780", VA = "0x186B31D80")]
	public KMOJHOCCIJK()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class IGDCMCFPCAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private Dictionary<string, Transform> OALPBEFIGID;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool FKPHAIMPOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x6B2F460", Offset = "0x6B2DE60", VA = "0x186B2F460")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F330", Offset = "0x6B2DD30", VA = "0x186B2F330")]
			public void BCMGPOPPJOJ(VRIK OFPAHCHPFGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
			public void NFNJDMIOKHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F4A0", Offset = "0x6B2DEA0", VA = "0x186B2F4A0")]
			public void LFBMALNLGLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F4F0", Offset = "0x6B2DEF0", VA = "0x186B2F4F0")]
			public IGDCMCFPCAF()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
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
		[HELBAACNMJG(LPFNGFMJOGK.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		[JLEDHNACBFM(LPFNGFMJOGK.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly IGDCMCFPCAF LMGPIFCJHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private OLKIHHNHEKN EMKFIOHAFEL;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AEA0", Offset = "0x6B298A0", VA = "0x186B2AEA0")]
		private void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B170", Offset = "0x6B29B70", VA = "0x186B2B170")]
		private bool IMJDALGMKDL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B1C0", Offset = "0x6B29BC0", VA = "0x186B2B1C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B230", Offset = "0x6B29C30", VA = "0x186B2B230")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B1D0", Offset = "0x6B29BD0", VA = "0x186B2B1D0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B4A0", Offset = "0x6B29EA0", VA = "0x186B2B4A0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
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

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6B2E800", Offset = "0x6B2D200", VA = "0x186B2E800")]
		public void AMLGEKNOMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6B2E920", Offset = "0x6B2D320", VA = "0x186B2E920")]
		public int GPLMACOBFGO(int CIFEJHOLCGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HandDisplaySettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
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
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6B2E990", Offset = "0x6B2D390", VA = "0x186B2E990")]
			public void AMLGEKNOMHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x6B2EA70", Offset = "0x6B2D470", VA = "0x186B2EA70")]
			public (float, float) HDOJBKLOPGD(Animator LOKOIKEKLCF, AnimatorStateInfo ONDECJEEGDG)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6B2EBB0", Offset = "0x6B2D5B0", VA = "0x186B2EBB0")]
		public void AMLGEKNOMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6B2EFB0", Offset = "0x6B2D9B0", VA = "0x186B2EFB0")]
		public (float, float) KJENJKGFKPG(Animator LOKOIKEKLCF)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6B2EDA0", Offset = "0x6B2D7A0", VA = "0x186B2EDA0")]
		private (float, float) JNIAEKKAKFO(Animator LOKOIKEKLCF, AnimatorStateInfo ONDECJEEGDG)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F1C0", Offset = "0x6B2DBC0", VA = "0x186B2F1C0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
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

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6B31E10", Offset = "0x6B30810", VA = "0x186B31E10", Slot = "4")]
		public override void OnStateEnter(Animator LOKOIKEKLCF, AnimatorStateInfo ONDECJEEGDG, int CKLLBMEJKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6B31F70", Offset = "0x6B30970", VA = "0x186B31F70")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class AFPONIKCFFF<TInput, TOutput> : NDGIHGCPFAO<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	protected readonly CICIOHJMEBM LONCLMCGANJ;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C9D0", Offset = "0x3E7B3D0", VA = "0x183E7C9D0")]
	protected AFPONIKCFFF(CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput CENBFOHJAFB(TInput DIGEGMNKCOG, [Out] IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C930", Offset = "0x3E7B330", VA = "0x183E7C930", Slot = "5")]
	public bool LCHJGBPGNKB(TInput DIGEGMNKCOG, [Out] TOutput? POBDLJBBBCI, [Out] IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[NHFFCNPJGMC]
public static class AICEBIGCELO
{
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly Regex KLPJKKGLDHK;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6B27B60", Offset = "0x6B26560", VA = "0x186B27B60")]
	public static FBMKHJEBFJF EFNOFLAJDNI(EHINIDBNANO IMJOCPOEBDC, PELNEICAOKM KDNFAFCHIAL, Guid? FLHPJBIPCEP, Color? IJCECLGHKEM, GLHPDDDHLIA NOLHAPCPHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6B279F0", Offset = "0x6B263F0", VA = "0x186B279F0")]
	public static EBOIDAOENMM CHILCOPLFMK(FBMKHJEBFJF JGCMECODHDI)
	{
		return default(EBOIDAOENMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x343E6E0", Offset = "0x343D0E0", VA = "0x18343E6E0")]
	internal static TModern? LADHDCKGACG<TModern>(string? DIGEGMNKCOG, NBNELONLMLH<TModern> GCMDDNENACP, CICIOHJMEBM LONCLMCGANJ, GKKCKHAKMIM AOHCEOHCDAB, TModern BEAGIBPJLAI) where TModern : struct, FFEKDPGODPD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x343FC50", Offset = "0x343E650", VA = "0x18343FC50")]
	internal static PDJLDBJNECB LPAJKBLAONH<TModern>(string? DIGEGMNKCOG, NBNELONLMLH<TModern> GCMDDNENACP, CICIOHJMEBM LONCLMCGANJ, GKKCKHAKMIM AOHCEOHCDAB, TModern BEAGIBPJLAI) where TModern : struct, FFEKDPGODPD
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6B27D70", Offset = "0x6B26770", VA = "0x186B27D70")]
	internal static List<LNLLCGLHGIO> LNAPOBJPJPH(IEnumerable<BPJBKDFPDNC>? GNNBGNDNCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3440430", Offset = "0x343EE30", VA = "0x183440430")]
	internal static string PELPPHPBMMB<TModern>(TModern DIGEGMNKCOG, NBNELONLMLH<TModern> GCMDDNENACP, CICIOHJMEBM LONCLMCGANJ) where TModern : FFEKDPGODPD
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class CGDMPELMLJJ : IFBNHKGJPFP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NDGIHGCPFAO<FOGBEJFOLCM, HLICDDLODBP> ECJJPMMHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NDGIHGCPFAO<BKMBOEENOCF, ICAMEONBIKE> AENEFOOKOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NDGIHGCPFAO<BKMBOEENOCF, ICAMEONBIKE> CANMHCFNKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public CDEHFAIGDPN KGPBIPBCAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public OBBJMCIBOFA JOGMKDAGLHB
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B580", Offset = "0x6B29F80", VA = "0x186B2B580")]
	[UsedImplicitly]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void PFBAJLCCLFO(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B5F0", Offset = "0x6B29FF0", VA = "0x186B2B5F0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CGDMPELMLJJ([OLJNBPOCBCJ("UnitySerialization")] KLMNPBBJDKC BKHKHIAOINE, [OLJNBPOCBCJ(null)] IKLEIDMNHGJ BAPPMIGDNCN, [OLJNBPOCBCJ(null)] CICIOHJMEBM LONCLMCGANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum LKCPELJNODN
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
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HACAEAEHNIO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C8B0", Offset = "0x6B2B2B0", VA = "0x186B2C8B0")]
	public HACAEAEHNIO(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C8E0", Offset = "0x6B2B2E0", VA = "0x186B2C8E0")]
	public HACAEAEHNIO(string KFAOBDLOMDC, Exception OCHGOHJLMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C910", Offset = "0x6B2B310", VA = "0x186B2C910")]
	public HACAEAEHNIO(LKCPELJNODN LPOJEHINHEE, string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C940", Offset = "0x6B2B340", VA = "0x186B2C940")]
	public HACAEAEHNIO(LKCPELJNODN LPOJEHINHEE, string KFAOBDLOMDC, Exception OCHGOHJLMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal abstract class JNDFGLEJMGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly KLMNPBBJDKC BKHKHIAOINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	protected readonly IKLEIDMNHGJ BAPPMIGDNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	protected readonly CICIOHJMEBM LONCLMCGANJ;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C730", Offset = "0x6B2B130", VA = "0x186B2C730")]
	protected JNDFGLEJMGA(KLMNPBBJDKC BKHKHIAOINE, IKLEIDMNHGJ BAPPMIGDNCN, CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6B30070", Offset = "0x6B2EA70", VA = "0x186B30070")]
	protected string HMJICDOMMMF(HLICDDLODBP IMKFEKABGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FA10", Offset = "0x6B2E410", VA = "0x186B2FA10")]
	protected string DPLKBOEHFNH(HLICDDLODBP IMKFEKABGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FC00", Offset = "0x6B2E600", VA = "0x186B2FC00")]
	private AvatarOutfitSelectionData EFNOFLAJDNI(FBMKHJEBFJF PGLEIJFNIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FF30", Offset = "0x6B2E930", VA = "0x186B2FF30")]
	private static AvatarCustomizationSettingsData.AnchorParams GEODLDOCFCI(FMFJFNMKGFN? CMJJLELONED)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NDGIHGCPFAO<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput CENBFOHJAFB(TInput DIGEGMNKCOG, [Out] IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCHJGBPGNKB(TInput DIGEGMNKCOG, [Out] TOutput? POBDLJBBBCI, [Out] IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface IFBNHKGJPFP
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	NDGIHGCPFAO<FOGBEJFOLCM, HLICDDLODBP> ECJJPMMHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	NDGIHGCPFAO<BKMBOEENOCF, ICAMEONBIKE> CANMHCFNKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	CDEHFAIGDPN KGPBIPBCAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum GKKCKHAKMIM
{
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface OBBJMCIBOFA
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MICFCKLJENI AMCHBAGBIFH(HLICDDLODBP JGCMECODHDI);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface CDEHFAIGDPN
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKMBOEENOCF AMCHBAGBIFH(HLICDDLODBP JGCMECODHDI, int IFGAAGJBJJB, string? KJPHMNNIMDP, string? PHLKCGNACMI, HMAPOJNAMII NCLEFBNEIPE, List<LNLLCGLHGIO>? IEMLJEFHJPN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NHFFCNPJGMC]
internal class KHPNLFAKHND : AFPONIKCFFF<FOGBEJFOLCM, HLICDDLODBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly IKLEIDMNHGJ BAPPMIGDNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly NAOEOKJGBMO ODAAPIAKLDL;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6B315F0", Offset = "0x6B2FFF0", VA = "0x186B315F0")]
	public KHPNLFAKHND(KLMNPBBJDKC BKHKHIAOINE, IKLEIDMNHGJ BAPPMIGDNCN, CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6B31350", Offset = "0x6B2FD50", VA = "0x186B31350", Slot = "6")]
	public override HLICDDLODBP CENBFOHJAFB(FOGBEJFOLCM DIGEGMNKCOG, [Out] IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class IEDHNAPIFLC : KLMNPBBJDKC
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class EJOAJEAADNH : JsonConverter<PDJLDBJNECB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6B2BC70", Offset = "0x6B2A670", VA = "0x186B2BC70", Slot = "9")]
		public override void WriteJson(JsonWriter NFLODIHODLH, PDJLDBJNECB? KLABJGGMBGH, JsonSerializer NFMKPKHGNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6B2BB50", Offset = "0x6B2A550", VA = "0x186B2BB50", Slot = "10")]
		public override PDJLDBJNECB ReadJson(JsonReader JEAKAGANOAM, Type JCAJLBCHLLM, PDJLDBJNECB? KOPPDAJGPHN, bool MNNPCGELEEN, JsonSerializer NFMKPKHGNLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6B2BD10", Offset = "0x6B2A710", VA = "0x186B2BD10")]
		public EJOAJEAADNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class APJKPOADNAH : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool BDAHOJLFHOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6B28300", Offset = "0x6B26D00", VA = "0x186B28300", Slot = "5")]
		public override object ReadJson(JsonReader JEAKAGANOAM, Type JCAJLBCHLLM, object? KOPPDAJGPHN, JsonSerializer NFMKPKHGNLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6B27F40", Offset = "0x6B26940", VA = "0x186B27F40", Slot = "6")]
		public override bool CanConvert(Type JCAJLBCHLLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6B28360", Offset = "0x6B26D60", VA = "0x186B28360", Slot = "4")]
		public override void WriteJson(JsonWriter NFLODIHODLH, object? KLABJGGMBGH, JsonSerializer NFMKPKHGNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6B28120", Offset = "0x6B26B20", VA = "0x186B28120")]
		private static bool GBPFCAGHAAI(object KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public APJKPOADNAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly JsonSerializerSettings HDGFLAHCMJL;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F1D0", Offset = "0x6B2DBD0", VA = "0x186B2F1D0")]
	internal IEDHNAPIFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2E060E0", Offset = "0x2E04AE0", VA = "0x182E060E0", Slot = "4")]
	public string NGLDDCOHCFA<T>(T GHMNBJIOGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2E06050", Offset = "0x2E04A50", VA = "0x182E06050", Slot = "5")]
	public T DKKFNMOKABM<T>(string KLABJGGMBGH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[RecRoom.NoEngine.Common.Preserve]
internal class HNGLPNJMGEL : KLMNPBBJDKC
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2860", Offset = "0x2DE1260", VA = "0x182DE2860", Slot = "4")]
	public string NGLDDCOHCFA<T>(T GHMNBJIOGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2DE27E0", Offset = "0x2DE11E0", VA = "0x182DE27E0", Slot = "5")]
	public T DKKFNMOKABM<T>(string KLABJGGMBGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public HNGLPNJMGEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[NHFFCNPJGMC]
internal class NAOEOKJGBMO : AFPONIKCFFF<BKMBOEENOCF, ICAMEONBIKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly KLMNPBBJDKC BKHKHIAOINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private readonly IKLEIDMNHGJ BAPPMIGDNCN;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6B34390", Offset = "0x6B32D90", VA = "0x186B34390")]
	public NAOEOKJGBMO(KLMNPBBJDKC BKHKHIAOINE, IKLEIDMNHGJ BAPPMIGDNCN, CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6B32620", Offset = "0x6B31020", VA = "0x186B32620", Slot = "6")]
	public override ICAMEONBIKE CENBFOHJAFB(BKMBOEENOCF DIGEGMNKCOG, [Out] IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6B33D30", Offset = "0x6B32730", VA = "0x186B33D30")]
	internal void KCLIICADBAJ(string FAPMPPAABAA, HLICDDLODBP IMKFEKABGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6B33FE0", Offset = "0x6B329E0", VA = "0x186B33FE0")]
	public IEnumerable<FBMKHJEBFJF> NHGCGJENNGN(string GJOPOIMGLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6B33910", Offset = "0x6B32310", VA = "0x186B33910")]
	private IEnumerable<FBMKHJEBFJF> FICNAKPIJAB(string GJOPOIMGLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6B32A40", Offset = "0x6B31440", VA = "0x186B32A40")]
	internal IEnumerable<FBMKHJEBFJF> CNHBHGOHLEP(string GJOPOIMGLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6B322A0", Offset = "0x6B30CA0", VA = "0x186B322A0")]
	private FBMKHJEBFJF BAKKOODININ(AvatarOutfitSelectionData PGCDOOJBKJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6B33090", Offset = "0x6B31A90", VA = "0x186B33090")]
	private void EINBDPHGMIH(AvatarCustomizationSettingsData OKBDGNLJKMF, HLICDDLODBP IMKFEKABGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6B31F90", Offset = "0x6B30990", VA = "0x186B31F90")]
	private FBMKHJEBFJF BAKKOODININ(string GIDFEGICBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6B34090", Offset = "0x6B32A90", VA = "0x186B34090")]
	internal static (GLHPDDDHLIA, string, string) OOOOCHKPKPL(string GIDFEGICBGL, CICIOHJMEBM LONCLMCGANJ)
	{
		return default((GLHPDDDHLIA, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6B32E90", Offset = "0x6B31890", VA = "0x186B32E90")]
	private EEADPOEJMLJ? DECOAHIKGOM(string? GDCMEHKEAMI, Vector2 IAHEMABMPLA, float EDJLNIKJGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6B33E80", Offset = "0x6B32880", VA = "0x186B33E80")]
	private static FMFJFNMKGFN MGBMMMFIBKM(AvatarCustomizationSettingsData.AnchorParams GEMLIIHJHFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[NHFFCNPJGMC]
internal class GKAEOIFBLLI : JNDFGLEJMGA, OBBJMCIBOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C730", Offset = "0x6B2B130", VA = "0x186B2C730")]
	public GKAEOIFBLLI(KLMNPBBJDKC BKHKHIAOINE, IKLEIDMNHGJ BAPPMIGDNCN, CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C040", Offset = "0x6B2AA40", VA = "0x186B2C040", Slot = "4")]
	public MICFCKLJENI AMCHBAGBIFH(HLICDDLODBP JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C3F0", Offset = "0x6B2ADF0", VA = "0x186B2C3F0")]
	private string DMBMIACCADO(HLICDDLODBP IMKFEKABGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C4F0", Offset = "0x6B2AEF0", VA = "0x186B2C4F0")]
	private string GIOAEFFMADM(FBMKHJEBFJF PGLEIJFNIIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[NHFFCNPJGMC]
internal class PALBBGPONHG : AFPONIKCFFF<BKMBOEENOCF, ICAMEONBIKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly KLMNPBBJDKC BKHKHIAOINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly NDGIHGCPFAO<BKMBOEENOCF, ICAMEONBIKE> BMPGEDNKCMP;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6B34900", Offset = "0x6B33300", VA = "0x186B34900")]
	public PALBBGPONHG(NDGIHGCPFAO<BKMBOEENOCF, ICAMEONBIKE> BMPGEDNKCMP, CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6B344D0", Offset = "0x6B32ED0", VA = "0x186B344D0", Slot = "6")]
	public override ICAMEONBIKE CENBFOHJAFB(BKMBOEENOCF DIGEGMNKCOG, [Out] IReadOnlyList<LNLLCGLHGIO>? IEMLJEFHJPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[NHFFCNPJGMC]
internal class INLDCCNEHHN : CDEHFAIGDPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly KLMNPBBJDKC BKHKHIAOINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly OBBJMCIBOFA FJAEFADACEE;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F920", Offset = "0x6B2E320", VA = "0x186B2F920")]
	public INLDCCNEHHN(OBBJMCIBOFA FJAEFADACEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F580", Offset = "0x6B2DF80", VA = "0x186B2F580", Slot = "4")]
	public BKMBOEENOCF AMCHBAGBIFH(HLICDDLODBP JGCMECODHDI, int IFGAAGJBJJB, string? KJPHMNNIMDP, string? PHLKCGNACMI, HMAPOJNAMII NCLEFBNEIPE, List<LNLLCGLHGIO>? IEMLJEFHJPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RecRoom.NoEngine.Common.Preserve]
internal class HINNEJDHCHM : PDJHHOACBKG
{
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly Vector2 LNMHDJPEJME;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly Vector2 ECFJPLDLODF;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly Vector2 MLFMBMCNEAK;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly Vector2 CIIBFPILGIF;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly Vector2 NCLLIEPKHOD;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly Vector2 GFOOICLFIIK;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly Vector2 PMDFGDGFHEA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly Vector2 JFANBOOBMPM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly Vector2 PPKOGOAEFFE;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly Vector2 PAGGHNPCJPI;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 EJPCHIOEHJK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 KFKOMGCEIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private readonly Dictionary<MMBBNHOOGFA, AvatarConfiguration> JFDLOENBBNE;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CE10", Offset = "0x6B2B810", VA = "0x186B2CE10")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void EAPLAPAFJKI(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E750", Offset = "0x6B2D150", VA = "0x186B2E750")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HINNEJDHCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E320", Offset = "0x6B2CD20", VA = "0x186B2E320", Slot = "4")]
	public Vector2 NLGDMEFFPAE(FaceFeatureType NKBCJKAPIOK, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D000", Offset = "0x6B2BA00", VA = "0x186B2D000", Slot = "5")]
	public float FMDEBFGHGNH(FaceFeatureType NKBCJKAPIOK, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E480", Offset = "0x6B2CE80", VA = "0x186B2E480", Slot = "6")]
	public void OBGFPOEOBLL(MMBBNHOOGFA KLAGAOLBONF, AvatarConfiguration JNHBLCGLMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D320", Offset = "0x6B2BD20", VA = "0x186B2D320", Slot = "7")]
	public void GMCNFBGOMFM(MALLKMKHLID FNIGDBGFJNL, AvatarConfiguration MNJOAJLMFMH, MMBBNHOOGFA PDOGEIHFOPK, MMBBNHOOGFA LMACLBIABNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C980", Offset = "0x6B2B380", VA = "0x186B2C980", Slot = "8")]
	public float ABKAMMOEOJC(FaceFeatureType KDLEIJBEDLO, float JCBNJOGDJOF, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CB70", Offset = "0x6B2B570", VA = "0x186B2CB70", Slot = "9")]
	public float BPOKEEPIBBK(FaceFeatureType KDLEIJBEDLO, float EDJLNIKJGIK, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D480", Offset = "0x6B2BE80", VA = "0x186B2D480", Slot = "11")]
	public Vector2 HJFBGEPDPCJ(FaceFeatureType KDLEIJBEDLO, Vector2 JEBPIHOLMPI, Vector2 NJFJHDNDIMH, Vector2 CEOPBGEHDCG, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DCA0", Offset = "0x6B2C6A0", VA = "0x186B2DCA0", Slot = "10")]
	public Vector2 KCMCDHDLFDI(FaceFeatureType KDLEIJBEDLO, Vector2 PGDAIMHHILE, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E1B0", Offset = "0x6B2CBB0", VA = "0x186B2E1B0")]
	private Vector2 MKDIFIDFHAM(FaceFeatureType KDLEIJBEDLO, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D080", Offset = "0x6B2BA80", VA = "0x186B2D080")]
	private Vector2 FPGIMHCJMGM(FaceFeatureType KDLEIJBEDLO, Vector2 JEBPIHOLMPI, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D8D0", Offset = "0x6B2C2D0", VA = "0x186B2D8D0", Slot = "12")]
	public Vector2 JBNOEPJHKPK(FaceFeatureType KDLEIJBEDLO, Vector2 PGDAIMHHILE, Vector2 NJFJHDNDIMH, Vector2 CEOPBGEHDCG, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D700", Offset = "0x6B2C100", VA = "0x186B2D700", Slot = "13")]
	public float IKBKNMGNHOC(FaceFeatureType KDLEIJBEDLO, float EDJLNIKJGIK, MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CD80", Offset = "0x6B2B780", VA = "0x186B2CD80")]
	private float DLMPAOBEIGJ(float GDAPDOPOOAD, float EMFANHEMBJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DED0", Offset = "0x6B2C8D0", VA = "0x186B2DED0")]
	private Vector2 KDBAGIIBCAC(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E130", Offset = "0x6B2CB30", VA = "0x186B2E130")]
	private Vector2 LMIAOEKJLDG(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D2A0", Offset = "0x6B2BCA0", VA = "0x186B2D2A0")]
	private Vector2 GIHPIPBPDNA(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E4F0", Offset = "0x6B2CEF0", VA = "0x186B2E4F0")]
	private Vector2 PPCNJKKMEHC(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CD40", Offset = "0x6B2B740", VA = "0x186B2CD40")]
	private float CLDPHDKFILD(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CA80", Offset = "0x6B2B480", VA = "0x186B2CA80")]
	private float BCPALBKPMIP(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E020", Offset = "0x6B2CA20", VA = "0x186B2E020")]
	private float KFEFPHAIIFO(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DC60", Offset = "0x6B2C660", VA = "0x186B2DC60")]
	private float JMOMJEALGOA(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DF50", Offset = "0x6B2C950", VA = "0x186B2DF50")]
	private Vector2 KEJEDGINNBD(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E060", Offset = "0x6B2CA60", VA = "0x186B2E060")]
	private Vector2 KKNOGIADMHN(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CBA0", Offset = "0x6B2B5A0", VA = "0x186B2CBA0")]
	private Vector2 CDEEGKPELDA(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CC70", Offset = "0x6B2B670", VA = "0x186B2CC70")]
	private Vector2 CEOIGHJGEJL(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D630", Offset = "0x6B2C030", VA = "0x186B2D630")]
	private Vector2 IINPGFADHFJ(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C9B0", Offset = "0x6B2B3B0", VA = "0x186B2C9B0")]
	private Vector2 APFNGHJFOFD(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E250", Offset = "0x6B2CC50", VA = "0x186B2E250")]
	private Vector2 NJLLKBBJMBF(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D1D0", Offset = "0x6B2BBD0", VA = "0x186B2D1D0")]
	private Vector2 GEHFELAFNOO(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CF30", Offset = "0x6B2B930", VA = "0x186B2CF30")]
	private Vector2 FJNHMDFNEMI(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CE80", Offset = "0x6B2B880", VA = "0x186B2CE80")]
	private Vector2 EDKLFNHIKNK(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D3D0", Offset = "0x6B2BDD0", VA = "0x186B2D3D0")]
	private Vector2 HCKMHAMCNFO(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CAC0", Offset = "0x6B2B4C0", VA = "0x186B2CAC0")]
	private Vector2 BLPIOOEAAHF(MMBBNHOOGFA KLAGAOLBONF)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
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
		[Cpp2IlInjected.Token(Token = "0x200003F")]
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

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B284F0", Offset = "0x6B26EF0", VA = "0x186B284F0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FOGBKEBEPLG
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BE70", Offset = "0x6B2A870", VA = "0x186B2BE70")]
	public static EBOIDAOENMM CENBFOHJAFB(this HKJKMNJIFJL JGCMECODHDI)
	{
		return default(EBOIDAOENMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BD50", Offset = "0x6B2A750", VA = "0x186B2BD50")]
	public static HKJKMNJIFJL AMCHBAGBIFH(this EBOIDAOENMM GNMIKDGBDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BFE0", Offset = "0x6B2A9E0", VA = "0x186B2BFE0")]
	public static bool JBCEDNKGOOF(this EBOIDAOENMM GNMIKDGBDHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BF80", Offset = "0x6B2A980", VA = "0x186B2BF80")]
	public static bool INKAGEHECPA(this EBOIDAOENMM GNMIKDGBDHH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
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

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x4F59F90", Offset = "0x4F58990", VA = "0x184F59F90")]
			public AnchorParams(Vector2 JEBPIHOLMPI, Vector3 MOHKCJMICJG, Vector3 JDEAKAIMACM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x6B28440", Offset = "0x6B26E40", VA = "0x186B28440")]
			internal FMFJFNMKGFN AMCHBAGBIFH()
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
		private LFHHNEDECGP useHelmetHair;

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
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x6B28CD0", Offset = "0x6B276D0", VA = "0x186B28CD0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3A3E410", Offset = "0x3A3CE10", VA = "0x183A3E410")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x94AA20", Offset = "0x949420", VA = "0x18094AA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x9CB070", Offset = "0x9C9A70", VA = "0x1809CB070")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xC32310", Offset = "0xC30D10", VA = "0x180C32310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6B28D70", Offset = "0x6B27770", VA = "0x186B28D70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8A64B0", Offset = "0x8A4EB0", VA = "0x1808A64B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAC03A0", Offset = "0xABEDA0", VA = "0x180AC03A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x13018F0", Offset = "0x13002F0", VA = "0x1813018F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8999D0", Offset = "0x8983D0", VA = "0x1808999D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6B28DB0", Offset = "0x6B277B0", VA = "0x186B28DB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x923C20", Offset = "0x922620", VA = "0x180923C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xB0F320", Offset = "0xB0DD20", VA = "0x180B0F320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x10E0700", Offset = "0x10DF100", VA = "0x1810E0700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x898870", Offset = "0x897270", VA = "0x180898870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x898860", Offset = "0x897260", VA = "0x180898860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x43A64F0", Offset = "0x43A4EF0", VA = "0x1843A64F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x928EB0", Offset = "0x9278B0", VA = "0x180928EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8CE460", Offset = "0x8CCE60", VA = "0x1808CE460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4C0", Offset = "0x8CCEC0", VA = "0x1808CE4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x89F780", Offset = "0x89E180", VA = "0x18089F780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x89F7B0", Offset = "0x89E1B0", VA = "0x18089F7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x89F740", Offset = "0x89E140", VA = "0x18089F740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x89F720", Offset = "0x89E120", VA = "0x18089F720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x89F6E0", Offset = "0x89E0E0", VA = "0x18089F6E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x89F700", Offset = "0x89E100", VA = "0x18089F700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9D4320", Offset = "0x9D2D20", VA = "0x1809D4320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xD3F8B0", Offset = "0xD3E2B0", VA = "0x180D3F8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x89F620", Offset = "0x89E020", VA = "0x18089F620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x89F6C0", Offset = "0x89E0C0", VA = "0x18089F6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x949AA0", Offset = "0x9484A0", VA = "0x180949AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x923D60", Offset = "0x922760", VA = "0x180923D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x897DE0", Offset = "0x8967E0", VA = "0x180897DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x897DC0", Offset = "0x8967C0", VA = "0x180897DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x924730", Offset = "0x923130", VA = "0x180924730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x924210", Offset = "0x922C10", VA = "0x180924210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xC53E10", Offset = "0xC52810", VA = "0x180C53E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xF67A60", Offset = "0xF66460", VA = "0x180F67A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public LFHHNEDECGP UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9D1CF0", Offset = "0x9D06F0", VA = "0x1809D1CF0")]
			get
			{
				return default(LFHHNEDECGP);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9CFF00", Offset = "0x9CE900", VA = "0x1809CFF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9CFF80", Offset = "0x9CE980", VA = "0x1809CFF80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x9D0DB0", Offset = "0x9CF7B0", VA = "0x1809D0DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6B28D90", Offset = "0x6B27790", VA = "0x186B28D90")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6B28DD0", Offset = "0x6B277D0", VA = "0x186B28DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B28970", Offset = "0x6B27370", VA = "0x186B28970")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
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
		public GLHPDDDHLIA BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private FEDCEIEOEHM? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x6B2AE70", Offset = "0x6B29870", VA = "0x186B2AE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
