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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B2F1A0", Offset = "0x6B2E3A0", VA = "0x186B2F1A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F220", Offset = "0x6B2E420", VA = "0x186B2F220", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HAAHLEBGOKA]
internal class BFLJLCKMAIG : BNOGMIAKAIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DAPBPGEMPMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public BFLJLCKMAIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public DANEJOKJCGO avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HMHJPOAOCHP CPKILMAIEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HAPFDJAICOL NDJPMLMFNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AKDKKNHEGMM NEHFMDGDJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HAHCJDCFGIB DOBPLNIEFPA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B128B0", Offset = "0x6B11AB0", VA = "0x186B128B0")]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	[UsedImplicitly]
	internal static void JFNMLGPEHIA(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B13D20", Offset = "0x6B12F20", VA = "0x186B13D20")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BFLJLCKMAIG([GEFLINBOFNF(null)] HMHJPOAOCHP CPKILMAIEIA, [GEFLINBOFNF(null)] HAPFDJAICOL NDJPMLMFNLF, [GEFLINBOFNF(null)] AKDKKNHEGMM NEHFMDGDJBE, [GEFLINBOFNF(null)] HAHCJDCFGIB DOBPLNIEFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B133D0", Offset = "0x6B125D0", VA = "0x186B133D0", Slot = "5")]
	public HAJLBENLNNH NJMBNOGHKBH(DANEJOKJCGO HAELGLMEIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B12920", Offset = "0x6B11B20", VA = "0x186B12920", Slot = "4")]
	public HAJLBENLNNH MCGGOMCFLOE(DANEJOKJCGO HAELGLMEIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B12440", Offset = "0x6B11640", VA = "0x186B12440", Slot = "6")]
	public HLPJBLPBJFD EFNGDAKOGGE(HAJLBENLNNH LJIEGDEDOHM, int EKIEHPJCEHF, string? EPPPGDEIJCI, string? KHCNICJLEON, NONJPEHBDOG CPIPMBOAGCD, List<LADAKBLMDLG>? MJCFJFKKJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B12820", Offset = "0x6B11A20", VA = "0x186B12820", Slot = "7")]
	public bool JEDPDBLJIJL(GIDMCCLKDAJ ANDIMHBMEJJ, [Out] HAJLBENLNNH? HDNIDPMFHFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B132F0", Offset = "0x6B124F0", VA = "0x186B132F0", Slot = "8")]
	public bool MEIBAHOPENH(HLPJBLPBJFD MPLCOLOHECF, [Out] HAJLBENLNNH? HDNIDPMFHFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B123B0", Offset = "0x6B115B0", VA = "0x186B123B0", Slot = "9")]
	public bool BDMEPGNMPAK(HLPJBLPBJFD MPLCOLOHECF, [Out] HMLNFBEHCNE? ANDIMHBMEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6A40", Offset = "0x2BA5C40", VA = "0x182BA6A40")]
	private bool NIOAMEHLGLF<TInput, TOutput>(TInput GJDJIDOLBAE, OKAGKBEDPBE<TInput, TOutput> INDFCLEGHBO, [Out] TOutput? KHPJAGHLNBM) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B13B80", Offset = "0x6B12D80", VA = "0x186B13B80")]
	[CompilerGenerated]
	private IALFIMLAJHG OLPJALIJOAP(FaceFeatureType INKLBEJOPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B12550", Offset = "0x6B11750", VA = "0x186B12550")]
	[CompilerGenerated]
	private IALFIMLAJHG GJDMBPNGHEJ(FaceFeatureType INKLBEJOPCG, DAPBPGEMPMK P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HAAHLEBGOKA]
internal class IGAGFGKOFGG : HMHJPOAOCHP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void MBIAMEILMBC<in TData>(TData HDNIDPMFHFO, IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AKDKKNHEGMM NEHFMDGDJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PACHMFNGNKE HIMGNMIHEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MBIAMEILMBC<HAJLBENLNNH>?[] CPKILMAIEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MBIAMEILMBC<HMLNFBEHCNE>?[] DPBHCHLKNBG;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B2ED80", Offset = "0x6B2DF80", VA = "0x186B2ED80")]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	[UsedImplicitly]
	internal static void JFNMLGPEHIA(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EDF0", Offset = "0x6B2DFF0", VA = "0x186B2EDF0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IGAGFGKOFGG([GEFLINBOFNF(null)] AKDKKNHEGMM NEHFMDGDJBE, [GEFLINBOFNF(null)] PACHMFNGNKE HIMGNMIHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DE60", Offset = "0x6B2D060", VA = "0x186B2DE60", Slot = "4")]
	public bool GAHNFHPIJOI(HAJLBENLNNH HDNIDPMFHFO, IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DF60", Offset = "0x6B2D160", VA = "0x186B2DF60", Slot = "5")]
	public bool GAHNFHPIJOI(HMLNFBEHCNE ANDIMHBMEJJ, IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E350", Offset = "0x6B2D550", VA = "0x186B2E350")]
	private void ICGBOMEMPII(HAJLBENLNNH HDNIDPMFHFO, IReadOnlyList<LADAKBLMDLG>? JNLAAHCIJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E0F0", Offset = "0x6B2D2F0", VA = "0x186B2E0F0")]
	private void HBCNBIOMCGM(HAJLBENLNNH HDNIDPMFHFO, IReadOnlyList<LADAKBLMDLG>? JNLAAHCIJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E320", Offset = "0x6B2D520", VA = "0x186B2E320")]
	private void HJCJDLLIADO(HAJLBENLNNH HDNIDPMFHFO, IReadOnlyList<LADAKBLMDLG>? JNLAAHCIJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E0C0", Offset = "0x6B2D2C0", VA = "0x186B2E0C0")]
	private void GKCNNHIIBAA(HAJLBENLNNH HDNIDPMFHFO, IReadOnlyList<LADAKBLMDLG>? JNLAAHCIJJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HMHJPOAOCHP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAHNFHPIJOI(HAJLBENLNNH HDNIDPMFHFO, IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAHNFHPIJOI(HMLNFBEHCNE ANDIMHBMEJJ, IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH);
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
		public DADJPCJNGEE AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6B0F130", Offset = "0x6B0E330", VA = "0x186B0F130")]
		public void LCAPBPCBHJI(AnimationPoseSetting KDHPJMADEAD, float FKCCEMJDJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F260", Offset = "0x6B0E460", VA = "0x186B0F260")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendHelperController : MonoBehaviour, PNBCFBEJCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
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
		private Vector3? EPFILPDHGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool FEJNAJKJGHJ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F280", Offset = "0x6B0E480", VA = "0x186B0F280", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F860", Offset = "0x6B0EA60", VA = "0x186B0F860", Slot = "4")]
		public void UpdateController(float GCFLAEHGPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1122560", Offset = "0x1121760", VA = "0x181122560", Slot = "6")]
		public void SetEnabled(bool JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B0F320", Offset = "0x6B0E520", VA = "0x186B0F320")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FCF0", Offset = "0x6B0EEF0", VA = "0x186B0FCF0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarElbowBendTargetController : MonoBehaviour, PNBCFBEJCEK
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float CHNNAPPPDPG = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
		[SerializeField]
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
		private Vector3 LGBNKIHMKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 NCEADPOIAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FEJNAJKJGHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float JPMKHFBDCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float DFJEEIGHPBI;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B10070", Offset = "0x6B0F270", VA = "0x186B10070", Slot = "4")]
		public void UpdateController(float GCFLAEHGPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xBFA2E0", Offset = "0xBF94E0", VA = "0x180BFA2E0", Slot = "6")]
		public void SetEnabled(bool JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6B0FD90", Offset = "0x6B0EF90", VA = "0x186B0FD90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B10B30", Offset = "0x6B0FD30", VA = "0x186B10B30")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B11430", Offset = "0x6B10630", VA = "0x186B11430")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B113F0", Offset = "0x6B105F0", VA = "0x186B113F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B10B60", Offset = "0x6B0FD60", VA = "0x186B10B60")]
		private void OIEBHIELBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9790", Offset = "0x6AD8990", VA = "0x186AD9790", Slot = "4")]
		public void SetEnabled(bool DFFHKLMFIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6B11460", Offset = "0x6B10660", VA = "0x186B11460")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarForearmRollController : MonoBehaviour, PNBCFBEJCEK
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
		private float JPMKHFBDCCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool FEJNAJKJGHJ;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6B114A0", Offset = "0x6B106A0", VA = "0x186B114A0", Slot = "4")]
		public void UpdateController(float GCFLAEHGPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x10B0720", Offset = "0x10AF920", VA = "0x1810B0720", Slot = "6")]
		public void SetEnabled(bool JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B11F20", Offset = "0x6B11120", VA = "0x186B11F20")]
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
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
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
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
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
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
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
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
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
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
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
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Default angle of the foot bone as seen in idle")]
		public float FootRestAngle;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B11F90", Offset = "0x6B11190", VA = "0x186B11F90")]
		public AnimationPoseSetting EJNOIOJHOGE(DADJPCJNGEE KPKCDIECNOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B11F50", Offset = "0x6B11150", VA = "0x186B11F50")]
		public void BPKFIOLMIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B11FC0", Offset = "0x6B111C0", VA = "0x186B11FC0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B14CE0", Offset = "0x6B13EE0", VA = "0x186B14CE0")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FPDKMJHOCGK : DIJLNDLFKHG
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int NHFKNJKHGJC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int KNAOBEEGKFD;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int PBLCCFPCEOA;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int LKMPDPCBEDP;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int EGGGBEBGPOP;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int LNGDNJDBFHD;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int BLPAMJLOMOF;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int[] FKKLDDEHAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NDOANFGOBGA CBMCPDAPKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private HNIHPLCACCG PINBNAEOALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int MCNKHBGILKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private float KNGBHNNBKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator EHNHMPHACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private AvatarFullBodyConfiguration LIAIIBLBMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int PBNOJLDEMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int KEBAPDPEPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int BKAEMNKFOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool EGNOBOPBCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private PCMMCMPCLFH FJAAAJHANNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int IFLAINCDACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private float DFMOMMFIFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private HandDisplaySettings MAGHOPHAONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private DANEJOKJCGO DMAIGIEKBOB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform DLGINHBOGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 PPDHLDJGDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10A1770", Offset = "0x10A0970", VA = "0x1810A1770")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x10A1760", Offset = "0x10A0960", VA = "0x1810A1760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion POMJAJAIKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1796180", Offset = "0x1795380", VA = "0x181796180")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2175720", Offset = "0x2174920", VA = "0x182175720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool COFFADGCJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6B14A10", Offset = "0x6B13C10", VA = "0x186B14A10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B149E0", Offset = "0x6B13BE0", VA = "0x186B149E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 MKBOPHNCMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE9D4E0", Offset = "0xE9C6E0", VA = "0x180E9D4E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xE9AF30", Offset = "0xE9A130", VA = "0x180E9AF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion HLGELPKMPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB6F190", Offset = "0xB6E390", VA = "0x180B6F190", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE9C080", Offset = "0xE9B280", VA = "0x180E9C080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ANBMMDFIHBA EKNEEBHCGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA21630", Offset = "0xA20830", VA = "0x180A21630", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(ANBMMDFIHBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA21C90", Offset = "0xA20E90", VA = "0x180A21C90", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ANBMMDFIHBA BDFPJCNDILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1566F60", Offset = "0x1566160", VA = "0x181566F60", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(ANBMMDFIHBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1D6B7E0", Offset = "0x1D6A9E0", VA = "0x181D6B7E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float DFJAOHBDJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x17D4BB0", Offset = "0x17D3DB0", VA = "0x1817D4BB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA22600", Offset = "0xA21800", VA = "0x180A22600", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FIHBPJOCAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B14810", Offset = "0x6B13A10", VA = "0x186B14810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AKCGKJCONHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B146C0", Offset = "0x6B138C0", VA = "0x186B146C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HLPDENCBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B146B0", Offset = "0x6B138B0", VA = "0x186B146B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool EGPPDGMJHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B14320", Offset = "0x6B13520", VA = "0x186B14320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6B13F30", Offset = "0x6B13130", VA = "0x186B13F30", Slot = "21")]
	public void DDNLIMMJHCH(NDOANFGOBGA GMPDEAOANEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6B14330", Offset = "0x6B13530", VA = "0x186B14330")]
	public void IHNABKFAEOP(HNIHPLCACCG HGAFMPEIKPK, HandDisplaySettings NGFFEEKLEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6B14780", Offset = "0x6B13980", VA = "0x186B14780", Slot = "12")]
	public void LMDKHCLEBFI(bool CIBBAIKMIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6B14380", Offset = "0x6B13580", VA = "0x186B14380", Slot = "11")]
	public void IKIELDFJMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6B14820", Offset = "0x6B13A20", VA = "0x186B14820")]
	private int MLGCNHGOOHD(ANBMMDFIHBA NEHPIIGCCIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B14180", Offset = "0x6B13380", VA = "0x186B14180")]
	private void EMEKPOIGJAA(int PEGIIIOKCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B14160", Offset = "0x6B13360", VA = "0x186B14160", Slot = "13")]
	public bool EHPDALOPFAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B14710", Offset = "0x6B13910", VA = "0x186B14710", Slot = "14")]
	public bool JLLNDHCODIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6B14730", Offset = "0x6B13930", VA = "0x186B14730")]
	private ANBMMDFIHBA LBMEBJCMBAJ()
	{
		return default(ANBMMDFIHBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9ECAA0", Offset = "0x9EBCA0", VA = "0x1809ECAA0", Slot = "15")]
	public void BEHACHIEAPE(bool CIBBAIKMIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6B146D0", Offset = "0x6B138D0", VA = "0x186B146D0", Slot = "10")]
	public void JGNHLIFPLBI(int PEGIIIOKCAK, float LCPOPFPDBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B13F10", Offset = "0x6B13110", VA = "0x186B13F10", Slot = "8")]
	public void BAMKDAMGDFN(PCMMCMPCLFH NHDPLCKEAAN, bool OFBHOKEDBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B14720", Offset = "0x6B13920", VA = "0x186B14720", Slot = "9")]
	public void KGKNGGCANGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B142D0", Offset = "0x6B134D0", VA = "0x186B142D0", Slot = "16")]
	public void HIOGLKAGLPI(Transform MBOJNCFILKL, Vector3 MMCPMBFKFKI, Quaternion IFCBGNCLBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B14CD0", Offset = "0x6B13ED0", VA = "0x186B14CD0")]
	public FPDKMJHOCGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ICCOCFIOGGH : BPLDJELLEBC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class GLDBFMAPOGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3 CJFKDJPIBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Quaternion IIFNPNIIEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 DKDCJJOLNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Transform CBLAPDAOEDB;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 BMFBGLDFJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x17FFFE0", Offset = "0x17FF1E0", VA = "0x1817FFFE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1800000", Offset = "0x17FF200", VA = "0x181800000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion JCKEDAHJOFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xDD5D60", Offset = "0xDD4F60", VA = "0x180DD5D60")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xDD5D50", Offset = "0xDD4F50", VA = "0x180DD5D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float EBBGFEDIJBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xB6F210", Offset = "0xB6E410", VA = "0x180B6F210")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x11488D0", Offset = "0x1147AD0", VA = "0x1811488D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool DAKLFOHBHBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x894330", Offset = "0x893530", VA = "0x180894330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x894440", Offset = "0x893640", VA = "0x180894440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool EDCEOFGDDKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8942F0", Offset = "0x8934F0", VA = "0x1808942F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x894300", Offset = "0x893500", VA = "0x180894300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool FOGCHNMCMHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8942C0", Offset = "0x8934C0", VA = "0x1808942C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8944F0", Offset = "0x8936F0", VA = "0x1808944F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float NEEILFNGGBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xB6F230", Offset = "0xB6E430", VA = "0x180B6F230")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x27CD060", Offset = "0x27CC260", VA = "0x1827CD060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6B389F0", Offset = "0x6B37BF0", VA = "0x186B389F0")]
		public void AMBAMKAKIHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B38FA0", Offset = "0x6B381A0", VA = "0x186B38FA0")]
		public void OADNADNEMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B38A10", Offset = "0x6B37C10", VA = "0x186B38A10")]
		public float ECLPDNEOKAK(Vector3 DCOHPDFKMNC, Quaternion OOOCOCEIMPI, [In] FootSettings OOJBDMKEAKG, float OFMJNPNPLFP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6B38FB0", Offset = "0x6B381B0", VA = "0x186B38FB0")]
		public void OEHKGMBDHDO(Vector3 BJHJOIKDNPE, Quaternion KLAHBFEJMBF, Transform GLGPKCNHPED, float HEEAPPMEKFE, bool OMIJAMAGJAB, bool BDIBFOFLIBG, float MANCJLFPIKM, float CDFKJHEMGBA, Transform LPLEFLJFGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6B38D70", Offset = "0x6B37F70", VA = "0x186B38D70")]
		public void LIOALILBEFF(Transform HLFOKDDOEGP, Transform LPLEFLJFGNH, bool IDIKEJJGCAG, bool PJIMDKCOFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6B388F0", Offset = "0x6B37AF0", VA = "0x186B388F0")]
		private void AEBFIEAKOBG(Transform LPLEFLJFGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6B38C20", Offset = "0x6B37E20", VA = "0x186B38C20")]
		public void HJNFBAIJBBO(Transform LPLEFLJFGNH, AvatarFullBodyConfiguration MADBAEFJKGN, Vector3 JHCIONKNILC, float CLJGDDENPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6B38A00", Offset = "0x6B37C00", VA = "0x186B38A00")]
		public void CCLPAJONFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6B39680", Offset = "0x6B38880", VA = "0x186B39680")]
		public GLDBFMAPOGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class AECGJDCJIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float NJHNMLMADNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool PBDACGDDJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AnimationPoseSetting EDPLDNGMDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float LPECLKEBDBE;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6B30620", Offset = "0x6B2F820", VA = "0x186B30620")]
		public void KJMNFJNBBJH(IKSolverVR.Arm CLAGINFHPBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F5D0", Offset = "0x6B2E7D0", VA = "0x186B2F5D0")]
		public void BCIGJNNEBPK(IKSolverVR.Arm CLAGINFHPBI, float MCBEBANDMKK, bool PBDACGDDJAI, AvatarFullBodyConfiguration MADBAEFJKGN, float NKDNNEIGLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6B305E0", Offset = "0x6B2F7E0", VA = "0x186B305E0")]
		private void JICCPNLNEJN(IKSolverVR.Arm CLAGINFHPBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6B30200", Offset = "0x6B2F400", VA = "0x186B30200")]
		public void JFJPKLNEMEN(IKSolverVR.Arm CLAGINFHPBI, Transform OAAAGDMPAIG, Transform GLGPKCNHPED, Quaternion KFMGLDMIOLI, Vector3 PKHGLILKCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6B2FD70", Offset = "0x6B2EF70", VA = "0x186B2FD70")]
		private (Vector3, Quaternion) IEMFPIOFAGN(FPDKMJHOCGK JPHHJFBGPCC, Quaternion ANFJJLBIGIM, Vector3 HAMNPAOBCOE)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6B2FC10", Offset = "0x6B2EE10", VA = "0x186B2FC10")]
		public void FHMKKKNHNFB(FPDKMJHOCGK JPHHJFBGPCC, IKSolverVR.Arm CLAGINFHPBI, Quaternion ANFJJLBIGIM, Vector3 HAMNPAOBCOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F610", Offset = "0x6B2E810", VA = "0x186B2F610")]
		public void DCCLLBDNNPL(FPDKMJHOCGK JPHHJFBGPCC, IKSolverVR.Arm CLAGINFHPBI, Quaternion ANFJJLBIGIM, Vector3 HAMNPAOBCOE, [In] AvatarFullBodyConfiguration MADBAEFJKGN, [In] MHOABJOJNEL NHDPLCKEAAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6B30650", Offset = "0x6B2F850", VA = "0x186B30650")]
		public void MAKMAHNHLOF(DADJPCJNGEE NOIFOBMBGGH, AvatarFullBodyConfiguration MADBAEFJKGN, MHOABJOJNEL NHDPLCKEAAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6B30780", Offset = "0x6B2F980", VA = "0x186B30780")]
		public void NFPKJKDKBCD(IKSolverVR.Arm CLAGINFHPBI, Transform OAAAGDMPAIG, Vector3 JIICDPPBGFM, float PGPOPFIFGMO, Quaternion HLDEJMBNEDN, Vector3 KCEHDCDEILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6B30C20", Offset = "0x6B2FE20", VA = "0x186B30C20")]
		public AECGJDCJIEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum LFPFBHBACHE
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
	private struct IMODEDJAFJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct ODMHJEEOJKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int JHOBNEFPNHE;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int DKCNFGICCKK;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int BNOKNIMCMHG;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int GEDNDNGLBOL;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int FKKBFOAIHKE;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int IJMJFEBJPKE;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int IKEAFHNCKGP;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int DODJGAGKDEH;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int KKGIOIGLNJO;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int MPEJNHFDHEE;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int PJEPKBEPDHO;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int JJBDNCFIHDF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int IHFEBHEJCMN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int KBCHDBKCONO;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int KJIJIEMHPDE;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int ANMGFIEJNHL;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int FKHLGPKFFDF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int FHNMECFAIDC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int EMIHOKBMDIE;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int GLPGCBHAMEI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int GHGLGCEGEEF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int LKFHCHDDHJE;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int OAIJHIBHIHL;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int MHPONDKAKIB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int GGHPFCKLKOG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int GCKMHBGCELN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int IMBAJMDGLIA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int OPICLFLOGAP;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int GGEOMDKKJCB;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 NFIKKJDAJKE;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int NIHLEJGMIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool DINOLGEAHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool IJMOAODJBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool MCELLLDLDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool JADDJMJFMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool DMDNJPBBHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Vector3 LCHHOLPLPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private string JPMECMBKPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private CPJJKCJALHG? CBMCPDAPKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private KLMMLBILLMG? KIIOMCGONIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private LAEJGEBPIDC MAHNMFGLCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private LGLABONODFG AKOBHFGHHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private FPDKMJHOCGK MCPNDKCLJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private FPDKMJHOCGK PIOEGFCEEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool KPGPFBPKBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool MPIKALJCDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly HGFBPMFBFDD MJJJKMEAGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly JMGHCKNLFAK AKOHPKDMAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int IFOFOOCPOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float AOGOGPADCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GameObject OHGJKIGCOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform IIIPJLNJJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform CHABNAOLBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform OFFDABCMLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform NDAKIAJOAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform ANLOGEMGKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float MBAONGAPMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float LEILAFJGDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 MCMMAHBPFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Quaternion NKBMBKFKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform GGLJMLJCBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform PIJGLBEBOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform GAJIEPBONHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool CNNOLOIOHGI;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker MOMNFEBIJCJ;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker ACBNHGMMHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker LEGJLPGFCLM;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker BGKDJLEAAFP;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker HGJNHKAEEFA;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker HGMHINAKDOD;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<ICCOCFIOGGH> DCOAIPHOIFO;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int HJMFKDNKDKA;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> OECLDDAMOJD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int JHMFEFOAJLK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int PCKKHEIPCAG;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int LNMCLIFDDMK;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int PNADABJCMCL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float LBCEBPAHPNO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int FBGOKLNGLJM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float MEHOOGGAINL;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float CCOCFGNDEKB;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float GJBNNMMDFCO;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float FNGJPBCDPDN;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static KEJIFCFJHFE JMNICFBNCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float GNCBGLMFLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool HJFCFFIEMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float KCFDKMOOLKN;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int NGHFAKONHFG;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int CACAOHBAMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private GLDBFMAPOGO DEEPBLMOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private GLDBFMAPOGO ILBEOKPBCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float LAEGEGLCPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Vector3 APCPBBHLMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Vector3 DBNIKHJMPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool BBDIGAAKCPJ;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion CJCIPMCMMKG;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion INHAIHBEBDB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 CAMMOANCEPB;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 EACPGJEPAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float PAJBFKLOFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float PLFOPJHIGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private AECGJDCJIEO MCAFBIELDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private AECGJDCJIEO ODLDELCIPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private EAJMJADIAEG GLEDECEIFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private HIHNAEEKCLI LAFNAPHHHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly LGGGOPHIFJF HPLGLLJGMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float IAHPJGLHMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float EEKHCKEAKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly HIHNAEEKCLI JAPPDEBPJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 EJEAHAMICEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Vector3 PBKBODJFLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float DPPCBCNMLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float EDKGNEMBDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly HIHNAEEKCLI KPKFPGHLNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly EAJMJADIAEG KDEGLIDLLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly HIHNAEEKCLI JENNDPGAGFH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public OAACCCGABIO KJOMOBCBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public OAACCCGABIO NPBMPLPNFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration OHMMMAKBAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B15800", Offset = "0x6B14A00", VA = "0x186B15800", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DANEJOKJCGO LMGEKMKCDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B1FED0", Offset = "0x6B1F0D0", VA = "0x186B1FED0", Slot = "23")]
		get
		{
			return default(DANEJOKJCGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration DHDNNAIDBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B1D740", Offset = "0x6B1C940", VA = "0x186B1D740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform OMICAOGLLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B1ED10", Offset = "0x6B1DF10", VA = "0x186B1ED10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform BLNKEJAJNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B390", Offset = "0x6B2A590", VA = "0x186B2B390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer ODJMNODOCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B17030", Offset = "0x6B16230", VA = "0x186B17030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] GOBDBBLPPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1AA90", Offset = "0x6B19C90", VA = "0x186B1AA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] HFBCKBIECAE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B29F50", Offset = "0x6B29150", VA = "0x186B29F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator IKECAFGEOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B16890", Offset = "0x6B15A90", VA = "0x186B16890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK LFFEHDGPJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1B970", Offset = "0x6B1AB70", VA = "0x186B1B970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private PNBCFBEJCEK GELBMMJFMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B16C70", Offset = "0x6B15E70", VA = "0x186B16C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private PNBCFBEJCEK LLPBADJPCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B1BF00", Offset = "0x6B1B100", VA = "0x186B1BF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private PNBCFBEJCEK DKCLNMHFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B1B870", Offset = "0x6B1AA70", VA = "0x186B1B870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private PNBCFBEJCEK MLOCOIJCDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B1EC10", Offset = "0x6B1DE10", VA = "0x186B1EC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private PNBCFBEJCEK CFKNJKBPLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B2A630", Offset = "0x6B29830", VA = "0x186B2A630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private PNBCFBEJCEK JHJFABAKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6B14E20", Offset = "0x6B14020", VA = "0x186B14E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private PNBCFBEJCEK DFNFENLAOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6B1DF00", Offset = "0x6B1D100", VA = "0x186B1DF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private PNBCFBEJCEK NHGBCOMJPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6B1EF50", Offset = "0x6B1E150", VA = "0x186B1EF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public KLMMLBILLMG JIIDDJHFMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6B2B260", Offset = "0x6B2A460", VA = "0x186B2B260", Slot = "15")]
		get
		{
			return default(KLMMLBILLMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PAMDDCADMGC CKDMBGHALAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x90B2B0", Offset = "0x90A4B0", VA = "0x18090B2B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public OPIFINMLCLO KNFLJCAJKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x90B1E0", Offset = "0x90A3E0", VA = "0x18090B1E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DIJLNDLFKHG DIPEFLDBNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x90B2D0", Offset = "0x90A4D0", VA = "0x18090B2D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public DIJLNDLFKHG BBEPFGKMMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x185A100", Offset = "0x1859300", VA = "0x18185A100", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string MGEPEOEAIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform ENHBHLOOGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1FC60", Offset = "0x6B1EE60", VA = "0x186B1FC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform DNBFNAPPFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6B17130", Offset = "0x6B16330", VA = "0x186B17130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform PPFDJPAHPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6B2A050", Offset = "0x6B29250", VA = "0x186B2A050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool PANKFMCACDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6B2A8E0", Offset = "0x6B29AE0", VA = "0x186B2A8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform IDMMJFBPLME
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6B20560", Offset = "0x6B1F760", VA = "0x186B20560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject PLNJOBKLAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6B29EB0", Offset = "0x6B290B0", VA = "0x186B29EB0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets AKIKDILOLMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6B155E0", Offset = "0x6B147E0", VA = "0x186B155E0", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform HJDBMINKBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1859E50", Offset = "0x1859050", VA = "0x181859E50", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform MHLOAFNCHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x185A0E0", Offset = "0x18592E0", VA = "0x18185A0E0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform OBHLILMHLAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xDCBD50", Offset = "0xDCAF50", VA = "0x180DCBD50", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform NFDKKIADNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x15D6930", Offset = "0x15D5B30", VA = "0x1815D6930", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 LPJNLKBECFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6B18B90", Offset = "0x6B17D90", VA = "0x186B18B90", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float KKKCPNHIFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6B17AE0", Offset = "0x6B16CE0", VA = "0x186B17AE0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform NAANAACBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6B19C40", Offset = "0x6B18E40", VA = "0x186B19C40", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform BHNOLANKFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1B5E8D0", Offset = "0x1B5DAD0", VA = "0x181B5E8D0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform HDGCCLDBJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1B5E9B0", Offset = "0x1B5DBB0", VA = "0x181B5E9B0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform NMBBAJJLPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x15D7500", Offset = "0x15D6700", VA = "0x1815D7500", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool PNPMCCMDPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6B209B0", Offset = "0x6B1FBB0", VA = "0x186B209B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool HCCAMBMIBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6B1FBE0", Offset = "0x6B1EDE0", VA = "0x186B1FBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool AEGHAGAIIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B2A540", Offset = "0x6B29740", VA = "0x186B2A540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6B26AD0", Offset = "0x6B25CD0", VA = "0x186B26AD0")]
	private void LBPDNMJENEM([In] MHOABJOJNEL HJGNBGOFKAL, [In] AvatarFullBodyConfiguration MADBAEFJKGN, bool JGKMNMDJDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B9B0", Offset = "0x6B2ABB0", VA = "0x186B2B9B0")]
	private float PEACCMCEJMJ([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6B19340", Offset = "0x6B18540", VA = "0x186B19340")]
	private float CLPOPFDGDCF([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E7D0", Offset = "0x6B1D9D0", VA = "0x186B1E7D0")]
	private void IAPFJKHGNBL(MHOABJOJNEL HJGNBGOFKAL, AvatarFullBodyConfiguration MADBAEFJKGN, bool JGKMNMDJDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A380", Offset = "0x6B29580", VA = "0x186B2A380")]
	private void NBGCMMIDANN([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6B1EE10", Offset = "0x6B1E010", VA = "0x186B1EE10")]
	private void IHGNKMANGLI([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D9C0", Offset = "0x6B2CBC0", VA = "0x186B2D9C0")]
	public ICCOCFIOGGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B16270", Offset = "0x6B15470", VA = "0x186B16270", Slot = "12")]
	public void BCLKGBFEOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B1BA70", Offset = "0x6B1AC70", VA = "0x186B1BA70", Slot = "13")]
	public void FGAOHPPHNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D400", Offset = "0x6B1C600", VA = "0x186B1D400", Slot = "14")]
	public void HDDNHIFEJEN(bool NIAJCGFBJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B19D60", Offset = "0x6B18F60", VA = "0x186B19D60", Slot = "25")]
	public Transform DLLOFOJAEOO(string HMONCPNNKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE10", Offset = "0x6B1C010", VA = "0x186B1CE10", Slot = "26")]
	public Vector3? GIMBGIELNFC(string HMONCPNNKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B293B0", Offset = "0x6B285B0", VA = "0x186B293B0", Slot = "7")]
	public void MKPFCNJPHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6B15900", Offset = "0x6B14B00", VA = "0x186B15900")]
	private void APOLBKHGFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B281A0", Offset = "0x6B273A0", VA = "0x186B281A0", Slot = "6")]
	public void LONFDBNCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A5C0", Offset = "0x6B297C0", VA = "0x186B2A5C0", Slot = "8")]
	public void NIJHOLFGLEC(float LBDMLINNCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E780", Offset = "0x6B1D980", VA = "0x186B1E780")]
	private void IAOJBJFLBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6B22290", Offset = "0x6B21490", VA = "0x186B22290", Slot = "4")]
	public void JPHGBKMKCOL(string LLMBNLNEBAA, CPJJKCJALHG HNIMOOBDILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6B24280", Offset = "0x6B23480", VA = "0x186B24280", Slot = "5")]
	public void KAKKILBIPBA(KLMMLBILLMG HGAFMPEIKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B28B20", Offset = "0x6B27D20", VA = "0x186B28B20", Slot = "11")]
	public void MDOJKEELHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B171A0", Offset = "0x6B163A0", VA = "0x186B171A0", Slot = "24")]
	public void BNIANMMAHHA([Out] Vector3 CDCECKEAOAB, [Out] Quaternion HLDEJMBNEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B14DF0", Offset = "0x6B13FF0", VA = "0x186B14DF0")]
	private void ABGPNNCOHMO([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B28190", Offset = "0x6B27390", VA = "0x186B28190", Slot = "27")]
	public void LMDFBLHOKOB(float CGJIIEAPJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BBB0", Offset = "0x6B2ADB0", VA = "0x186B2BBB0", Slot = "28")]
	public void PJGGKNNGLND(float OGNDJFPHDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6B193C0", Offset = "0x6B185C0", VA = "0x186B193C0", Slot = "44")]
	public void DDGPKJBMIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CC10", Offset = "0x6B1BE10", VA = "0x186B1CC10", Slot = "29")]
	public void GBOGELMGDAH(bool OABJNEKOGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A840", Offset = "0x6B19A40", VA = "0x186B1A840", Slot = "30")]
	public HandLogicOffsets EAALKMHHOGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B19CA0", Offset = "0x6B18EA0", VA = "0x186B19CA0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets DKLFJCMKGPL()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1AB90", Offset = "0x6B19D90", VA = "0x186B1AB90")]
	private void EIPDOGPKFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B25210", Offset = "0x6B24410", VA = "0x186B25210")]
	private void KKKDCJOHHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D4D0", Offset = "0x6B1C6D0", VA = "0x186B1D4D0")]
	private void HDLAPPBLKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B25640", Offset = "0x6B24840", VA = "0x186B25640")]
	private void KMHDONIEDJH(PIMMPONFKHJ GINGOMNONCP, bool BKKKGCNMPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A730", Offset = "0x6B29930", VA = "0x186B2A730")]
	private void NLIKGEPEBJA(PIMMPONFKHJ GINGOMNONCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CDC0", Offset = "0x6B1BFC0", VA = "0x186B1CDC0")]
	public Vector3 GFDILPFLONI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B26810", Offset = "0x6B25A10", VA = "0x186B26810")]
	private void LANCHJJMMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D390", Offset = "0x6B1C590", VA = "0x186B1D390")]
	private void GOMPJPNIANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1ACF0", Offset = "0x6B19EF0", VA = "0x186B1ACF0")]
	private void EKFBCLKMCPL(MHOABJOJNEL HJGNBGOFKAL, AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D140", Offset = "0x6B1C340", VA = "0x186B1D140")]
	private float GLBFFFFNGIN([In] MHOABJOJNEL NHDPLCKEAAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B26730", Offset = "0x6B25930", VA = "0x186B26730")]
	private int LADKCHOGNPA([In] CDJLLHFFCLC DAALGBBAGLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B490", Offset = "0x6B2A690", VA = "0x186B2B490")]
	private void PDLBKBIHKFM(MHOABJOJNEL HJGNBGOFKAL, bool CGBIEKDEJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A890", Offset = "0x6B19A90", VA = "0x186B1A890")]
	private static void EGAFPEMEKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B17D10", Offset = "0x6B16F10", VA = "0x186B17D10")]
	private static void CEBAFKDDJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B17B30", Offset = "0x6B16D30", VA = "0x186B17B30")]
	private float BPHMMOCIHIC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B230", Offset = "0x6B2A430", VA = "0x186B2B230")]
	private static int OAEOGLNNAHI(ICCOCFIOGGH PCICJLNHPMM, ICCOCFIOGGH OIJJJJFPNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CC60", Offset = "0x6B1BE60", VA = "0x186B1CC60", Slot = "40")]
	public MHOABJOJNEL GCBCBPDKKOA()
	{
		return default(MHOABJOJNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B29E70", Offset = "0x6B29070", VA = "0x186B29E70")]
	public void MOHPENDNGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FCB0", Offset = "0x6B1EEB0", VA = "0x186B1FCB0")]
	private (bool, bool) JAJMBBCLKBC()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BA40", Offset = "0x6B2AC40", VA = "0x186B2BA40")]
	private (float, float) PELBLMPEJNL([In] MHOABJOJNEL NHDPLCKEAAN)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B20AB0", Offset = "0x6B1FCB0", VA = "0x186B20AB0")]
	private void JMFJMCKKLLI([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B19020", Offset = "0x6B18220", VA = "0x186B19020")]
	private void CKPPEMKCDON([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B25D50", Offset = "0x6B24F50", VA = "0x186B25D50")]
	private void KOAJPPIECLJ([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C0D0", Offset = "0x6B2B2D0", VA = "0x186B2C0D0")]
	private void PLPEHCMKLFB([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN, FootSettings OOJBDMKEAKG, bool JEPBPNPHMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6B25190", Offset = "0x6B24390", VA = "0x186B25190")]
	private float KJMPMMNPINL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C4F0", Offset = "0x6B2B6F0", VA = "0x186B2C4F0")]
	private void PMAGAEICNPO(MHOABJOJNEL NHDPLCKEAAN, AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D3B0", Offset = "0x6B1C5B0", VA = "0x186B1D3B0")]
	private float HCDCGHKILDB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6B19EB0", Offset = "0x6B190B0", VA = "0x186B19EB0")]
	private void DNEJKHKHKLN([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6B20660", Offset = "0x6B1F860", VA = "0x186B20660")]
	private void JFJPKLNEMEN([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6B2AE40", Offset = "0x6B2A040", VA = "0x186B2AE40")]
	private void OADOPLNIDGD([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6B29BC0", Offset = "0x6B28DC0", VA = "0x186B29BC0")]
	private void MLNGIIOHGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6B20080", Offset = "0x6B1F280", VA = "0x186B20080")]
	private void JECFGODENCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6B15660", Offset = "0x6B14860", VA = "0x186B15660")]
	private void AMAEKNBDCLO([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6B202D0", Offset = "0x6B1F4D0", VA = "0x186B202D0")]
	private void JEOANKMBAGP(FPDKMJHOCGK DDLCCDLPFCO, IKSolverVR.Arm CLAGINFHPBI, Transform PPADCEIDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6B28C10", Offset = "0x6B27E10", VA = "0x186B28C10")]
	private void MJEKONMONOJ(MHOABJOJNEL NHDPLCKEAAN, AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F050", Offset = "0x6B1E250", VA = "0x186B1F050")]
	private void IKIELDFJMDD(KOKMAFANCEF KKDGHOGOKNH, DIJLNDLFKHG DDLCCDLPFCO, IKSolverVR.Arm CLAGINFHPBI, float MCBEBANDMKK, float KHDCOEFGALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B15A00", Offset = "0x6B14C00", VA = "0x186B15A00")]
	private void BAGNDEECGKP([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DB00", Offset = "0x6B1CD00", VA = "0x186B1DB00")]
	protected void HKAPGAKIEAN([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B16990", Offset = "0x6B15B90", VA = "0x186B16990")]
	private void BEHAOOPGOPE([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A0C0", Offset = "0x6B292C0", VA = "0x186B2A0C0")]
	protected void MPKMHGCHBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E000", Offset = "0x6B1D200", VA = "0x186B1E000")]
	private void HPKCJCEMDIJ([In] MHOABJOJNEL NHDPLCKEAAN, [In] LFPFBHBACHE LIDJLMJIPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6B16E80", Offset = "0x6B16080", VA = "0x186B16E80")]
	private void BJCBPKGMHKG(MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1EF10", Offset = "0x6B1E110", VA = "0x186B1EF10")]
	private void IIBALPBEKCI([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A930", Offset = "0x6B29B30", VA = "0x186B2A930")]
	private Vector3 NOKKJPGNODB([In] MHOABJOJNEL NHDPLCKEAAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B14D20", Offset = "0x6B13F20", VA = "0x186B14D20")]
	private void ABBPCOGINEN([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6B28F80", Offset = "0x6B28180", VA = "0x186B28F80")]
	private float MJLIIEIDJPL(float CDFKJHEMGBA, [In] MHOABJOJNEL NHDPLCKEAAN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6B18A40", Offset = "0x6B17C40", VA = "0x186B18A40")]
	private void CEJKBENGNKE(float CDFKJHEMGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A3A0", Offset = "0x6B195A0", VA = "0x186B1A3A0")]
	private void DNIICDFHGEO([In] MHOABJOJNEL NHDPLCKEAAN, LFPFBHBACHE LIDJLMJIPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6B14F20", Offset = "0x6B14120", VA = "0x186B14F20")]
	private float AINCLFPICGD([In] MHOABJOJNEL HJGNBGOFKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6B17530", Offset = "0x6B16730", VA = "0x186B17530")]
	private void BNPINBDKDOO(MHOABJOJNEL NHDPLCKEAAN, LFPFBHBACHE LIDJLMJIPMJ, Vector3 DMFLGLGCCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6B160C0", Offset = "0x6B152C0", VA = "0x186B160C0")]
	private static void BAOBCMNIEHE(Transform PKBNMONECNF, Quaternion MBMKLLFOFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D7D0", Offset = "0x6B1C9D0", VA = "0x186B1D7D0")]
	private void HIEELPBKHLA([In] MHOABJOJNEL HKMPKNHGPGD, [In] CDJLLHFFCLC DAALGBBAGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C000", Offset = "0x6B1B200", VA = "0x186B1C000")]
	private void FNBJCMBHJLH([In] MHOABJOJNEL HKMPKNHGPGD, [In] CDJLLHFFCLC DAALGBBAGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B6C0", Offset = "0x6B1A8C0", VA = "0x186B1B6C0")]
	private void EKJJDHHLEHH(float LOKMLKJDJLD, [In] MHOABJOJNEL HJGNBGOFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6B19500", Offset = "0x6B18700", VA = "0x186B19500")]
	private float DEPELLDDIKC([In] MHOABJOJNEL HJGNBGOFKAL, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B24F20", Offset = "0x6B24120", VA = "0x186B24F20")]
	private void KENMNEJJCKG([In] MHOABJOJNEL HJGNBGOFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6B24740", Offset = "0x6B23940", VA = "0x186B24740")]
	private void KBPDKJPHGPM([In] MHOABJOJNEL HJGNBGOFKAL, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C870", Offset = "0x6B1BA70", VA = "0x186B1C870")]
	private void GAEIJBJPMKH([In] MHOABJOJNEL HJGNBGOFKAL, float PCIPPFNJJHP, float NJPPMBKFDNN, Vector3 NIKBHKNFCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F220", Offset = "0x6B1E420", VA = "0x186B1F220")]
	private void IMKEMBIBLOO(MHOABJOJNEL HJGNBGOFKAL, AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6B18C20", Offset = "0x6B17E20", VA = "0x186B18C20")]
	private void CKCBAADGFDA(MHOABJOJNEL HJGNBGOFKAL, AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BF00", Offset = "0x6B2B100", VA = "0x186B2BF00")]
	public void PJKDDONBGDE([In] MHOABJOJNEL NHDPLCKEAAN, [In] AvatarFullBodyConfiguration MADBAEFJKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CFA0", Offset = "0x6B1C1A0", VA = "0x186B1CFA0")]
	[CompilerGenerated]
	internal static void GINECJJLCGM(Transform MMPBCCIBPMB, IKSolverVR.Arm CLAGINFHPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1FFD0", Offset = "0x6B1F1D0", VA = "0x186B1FFD0")]
	[CompilerGenerated]
	internal static void JDLJENOPHPL(Vector3 CFIPNABFCOA, Vector3 MHMHBJOLOOO, IMODEDJAFJM P_2, ODMHJEEOJKM P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D2F0", Offset = "0x6B1C4F0", VA = "0x186B1D2F0")]
	[CompilerGenerated]
	internal static void GOAJBBICBDI(GLDBFMAPOGO CMOAAHKOBHD, GLDBFMAPOGO MMGGIMNAPDM, Vector3 DCMBGEBJPBC, float BAHJDCJDFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6B16D70", Offset = "0x6B15F70", VA = "0x186B16D70")]
	[CompilerGenerated]
	internal static bool BIALIIJMFBG(IKSolverVR.Arm CLAGINFHPBI, LNIJLNBPJIM ONFNABMLFON, float KANFABIGGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6B25920", Offset = "0x6B24B20", VA = "0x186B25920")]
	[CompilerGenerated]
	internal static float KNGBCDBIGMI(Vector3 CONGLBHICNH, Vector3 CPIGJFEKNMC, Vector3 BFMLMABAJNN, MHOABJOJNEL HJGNBGOFKAL, AvatarFullBodyConfiguration MADBAEFJKGN, float ECDKJELMFBH)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum KPFIFALPHNP
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private KPFIFALPHNP handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6B31C90", Offset = "0x6B30E90", VA = "0x186B31C90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6B31C50", Offset = "0x6B30E50", VA = "0x186B31C50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6B31650", Offset = "0x6B30850", VA = "0x186B31650")]
		private void OIEBHIELBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9790", Offset = "0x6AD8990", VA = "0x186AD9790", Slot = "4")]
		public void SetEnabled(bool DFFHKLMFIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6B31CC0", Offset = "0x6B30EC0", VA = "0x186B31CC0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AvatarKneeBendTargetController : MonoBehaviour, PNBCFBEJCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Vector3 LGBNKIHMKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Vector3 DIOMMPGLKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Vector3 APMLHMBKNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Matrix4x4 JMKBLNDFHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private bool FEJNAJKJGHJ;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6B32160", Offset = "0x6B31360", VA = "0x186B32160", Slot = "4")]
		public void UpdateController(float GCFLAEHGPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6B32150", Offset = "0x6B31350", VA = "0x186B32150", Slot = "6")]
		public void SetEnabled(bool JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6B31CF0", Offset = "0x6B30EF0", VA = "0x186B31CF0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6B32820", Offset = "0x6B31A20", VA = "0x186B32820")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, HMLPGJGFJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[Header("Configuration")]
		private DANEJOKJCGO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[FICFPGOHBIA(IKBOIBNEMID.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private BPLDJELLEBC BFBAKKMCJPF;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public BPLDJELLEBC FOHJHAJJIHL
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8E6410", Offset = "0x8E5610", VA = "0x1808E6410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform GBCIFNDMLAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6B336B0", Offset = "0x6B328B0", VA = "0x186B336B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6B32830", Offset = "0x6B31A30", VA = "0x186B32830")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6B33570", Offset = "0x6B32770", VA = "0x186B33570")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6B33520", Offset = "0x6B32720", VA = "0x186B33520")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6B334B0", Offset = "0x6B326B0", VA = "0x186B334B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6B32830", Offset = "0x6B31A30", VA = "0x186B32830", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6B32CB0", Offset = "0x6B31EB0", VA = "0x186B32CB0", Slot = "6")]
		public BPLDJELLEBC CreateAvatarSystem(string LLMBNLNEBAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6B334B0", Offset = "0x6B326B0", VA = "0x186B334B0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6B328E0", Offset = "0x6B31AE0", VA = "0x186B328E0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6B335C0", Offset = "0x6B327C0", VA = "0x186B335C0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float GCFLAEHGPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class MBAJPALDHHJ : JEIIJEJBIBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<string, BPLDJELLEBC> BHMIJDDDLEG;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B470", Offset = "0x6B3A670", VA = "0x186B3B470")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void JNDBKBFCAEE(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B0D0", Offset = "0x6B3A2D0", VA = "0x186B3B0D0", Slot = "4")]
	public BPLDJELLEBC ALBEOHDHNJP(string KEBHPBMKJKL, AvatarSystemConfiguration IDLPLLJJIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B2F0", Offset = "0x6B3A4F0", VA = "0x186B3B2F0", Slot = "5")]
	public void EPGLIENIFKG(string KEBHPBMKJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B4E0", Offset = "0x6B3A6E0", VA = "0x186B3B4E0", Slot = "6")]
	public string KMEIAJDADOB(string KEBGNDKAGAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B620", Offset = "0x6B3A820", VA = "0x186B3B620")]
	private string LOPNCENFKDO(string KEBGNDKAGAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B690", Offset = "0x6B3A890", VA = "0x186B3B690")]
	public MBAJPALDHHJ()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class KEFPFMNOOLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private Dictionary<string, Transform> MCLKNPAJGEH;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool IDJFCBEKMDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x6B3AED0", Offset = "0x6B3A0D0", VA = "0x186B3AED0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x6B3AF10", Offset = "0x6B3A110", VA = "0x186B3AF10")]
			public void MNIHDNBBOBJ(VRIK OPHNEOGICEP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
			public void OMCNNLNODFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6B3AE80", Offset = "0x6B3A080", VA = "0x186B3AE80")]
			public void AKMCCPCKADJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6B3B040", Offset = "0x6B3A240", VA = "0x186B3B040")]
			public KEFPFMNOOLB()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[NFJOGFGDKNB(IKBOIBNEMID.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[FICFPGOHBIA(IKBOIBNEMID.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly KEFPFMNOOLB IMJHMNEHODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HMLPGJGFJCD GDMGGPLMDGJ;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6B33750", Offset = "0x6B32950", VA = "0x186B33750")]
		private void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6B33700", Offset = "0x6B32900", VA = "0x186B33700")]
		private bool CDFIGPGFFHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6B33A30", Offset = "0x6B32C30", VA = "0x186B33A30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6B33AA0", Offset = "0x6B32CA0", VA = "0x186B33AA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6B33A40", Offset = "0x6B32C40", VA = "0x186B33A40")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6B33D10", Offset = "0x6B32F10", VA = "0x186B33D10")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6B39D80", Offset = "0x6B38F80", VA = "0x186B39D80")]
		public void BPKFIOLMIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6B39EA0", Offset = "0x6B390A0", VA = "0x186B39EA0")]
		public int IFJDLNMHGBG(int BJONNOGDNHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public HandDisplaySettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6B39F10", Offset = "0x6B39110", VA = "0x186B39F10")]
			public void BPKFIOLMIPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x6B39FF0", Offset = "0x6B391F0", VA = "0x186B39FF0")]
			public (float, float) EPHKMPLOLBM(Animator JIAEJDOJLJC, AnimatorStateInfo KFPBOHJFBPH)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6B3A130", Offset = "0x6B39330", VA = "0x186B3A130")]
		public void BPKFIOLMIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3A510", Offset = "0x6B39710", VA = "0x186B3A510")]
		public (float, float) ICAJMJOAMPD(Animator JIAEJDOJLJC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6B3A320", Offset = "0x6B39520", VA = "0x186B3A320")]
		private (float, float) GMIFIJOPAEG(Animator JIAEJDOJLJC, AnimatorStateInfo KFPBOHJFBPH)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6B3A720", Offset = "0x6B39920", VA = "0x186B3A720")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6B3BB90", Offset = "0x6B3AD90", VA = "0x186B3BB90", Slot = "4")]
		public override void OnStateEnter(Animator JIAEJDOJLJC, AnimatorStateInfo KFPBOHJFBPH, int CKBABDDGILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6B3BCF0", Offset = "0x6B3AEF0", VA = "0x186B3BCF0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal abstract class INGEAKOAKKK<TInput, TOutput> : OKAGKBEDPBE<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	protected readonly PACHMFNGNKE HIMGNMIHEHA;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4184680", Offset = "0x4183880", VA = "0x184184680")]
	protected INGEAKOAKKK(PACHMFNGNKE HIMGNMIHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput GBKBNNNFJGC(TInput GJDJIDOLBAE, [Out] IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x41845E0", Offset = "0x41837E0", VA = "0x1841845E0", Slot = "5")]
	public bool NIOAMEHLGLF(TInput GJDJIDOLBAE, [Out] TOutput? KHPJAGHLNBM, [Out] IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[HAAHLEBGOKA]
public static class IJONNPHHCBH
{
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly Regex OOCGJNDFENN;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A890", Offset = "0x6B39A90", VA = "0x186B3A890")]
	public static FENDCALOPLC EJCPDEBPLDF(ODIOBCFCCOG NLJPJFBHJII, FPAFDHKJIGP JDCICNDKINP, Guid? LKJJNNCNEFN, Color? DDOKAPCKCKH, IPFKHDEMKPH KEDCKJDPMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A730", Offset = "0x6B39930", VA = "0x186B3A730")]
	public static LGIGHIHBKAO BCOHJEDJLEH(FENDCALOPLC LJIEGDEDOHM)
	{
		return default(LGIGHIHBKAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2E57130", Offset = "0x2E56330", VA = "0x182E57130")]
	internal static TModern? CEBNBONDBDE<TModern>(string? GJDJIDOLBAE, MHOPPHPACNL<TModern> HHDGIHIJDAK, PACHMFNGNKE HIMGNMIHEHA, DDJPOELJLHC HMGMBFLNLMH, TModern MGBCPJAFFJE) where TModern : struct, LPODAIJOFKC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2E58780", Offset = "0x2E57980", VA = "0x182E58780")]
	internal static MPEKJAJPCMO NGAIBNFKFDF<TModern>(string? GJDJIDOLBAE, MHOPPHPACNL<TModern> HHDGIHIJDAK, PACHMFNGNKE HIMGNMIHEHA, DDJPOELJLHC HMGMBFLNLMH, TModern MGBCPJAFFJE) where TModern : struct, LPODAIJOFKC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3AAA0", Offset = "0x6B39CA0", VA = "0x186B3AAA0")]
	internal static List<LADAKBLMDLG> NOLFNDABMCB(IEnumerable<ABLKNNOBFKK>? ADEKBPFLBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2E562B0", Offset = "0x2E554B0", VA = "0x182E562B0")]
	internal static string CBELFLAKOGD<TModern>(TModern GJDJIDOLBAE, MHOPPHPACNL<TModern> HHDGIHIJDAK, PACHMFNGNKE HIMGNMIHEHA) where TModern : LPODAIJOFKC
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class PNGFDINMJCG : HAPFDJAICOL
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public OKAGKBEDPBE<GIDMCCLKDAJ, HAJLBENLNNH> CICBAKJGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public OKAGKBEDPBE<HLPJBLPBJFD, HMLNFBEHCNE> GMCJIEDLIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public OKAGKBEDPBE<HLPJBLPBJFD, HMLNFBEHCNE> EKHMKBEGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public PEELHAHOCGD OBLEHPGOBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public IOGAFGFCJCO IHENPOBJJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E3A0", Offset = "0x6B3D5A0", VA = "0x186B3E3A0")]
	[UsedImplicitly]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	internal static void JFNMLGPEHIA(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E410", Offset = "0x6B3D610", VA = "0x186B3E410")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PNGFDINMJCG([GEFLINBOFNF("UnitySerialization")] KKFEOLGKPAG GFPDKEBCGJG, [GEFLINBOFNF(null)] BEJANLLLKLB LGLHNJPHIGK, [GEFLINBOFNF(null)] PACHMFNGNKE HIMGNMIHEHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum NNACJEIJNCC
{
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PNJODFLBLKN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E9A0", Offset = "0x6B3DBA0", VA = "0x186B3E9A0")]
	public PNJODFLBLKN(string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E970", Offset = "0x6B3DB70", VA = "0x186B3E970")]
	public PNJODFLBLKN(string ADNFLGLLNKI, Exception DKNINGGCJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EA10", Offset = "0x6B3DC10", VA = "0x186B3EA10")]
	public PNJODFLBLKN(NNACJEIJNCC KKAKJFAKCOH, string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E9D0", Offset = "0x6B3DBD0", VA = "0x186B3E9D0")]
	public PNJODFLBLKN(NNACJEIJNCC KKAKJFAKCOH, string ADNFLGLLNKI, Exception DKNINGGCJGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal abstract class BKFOJHANOMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly KKFEOLGKPAG GFPDKEBCGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	protected readonly BEJANLLLKLB LGLHNJPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	protected readonly PACHMFNGNKE HIMGNMIHEHA;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6B35720", Offset = "0x6B34920", VA = "0x186B35720")]
	protected BKFOJHANOMA(KKFEOLGKPAG GFPDKEBCGJG, BEJANLLLKLB LGLHNJPHIGK, PACHMFNGNKE HIMGNMIHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6B34450", Offset = "0x6B33650", VA = "0x186B34450")]
	protected string MKKGHKCMMGD(HAJLBENLNNH HDNIDPMFHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6B33DF0", Offset = "0x6B32FF0", VA = "0x186B33DF0")]
	protected string AONOPBFHFNP(HAJLBENLNNH HDNIDPMFHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6B33FE0", Offset = "0x6B331E0", VA = "0x186B33FE0")]
	private AvatarOutfitSelectionData EJCPDEBPLDF(FENDCALOPLC ABBOKBDDLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6B34310", Offset = "0x6B33510", VA = "0x186B34310")]
	private static AvatarCustomizationSettingsData.AnchorParams LPHLKLPDFFM(HMMONNFLLEB? DHMIEIAKEPB)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface OKAGKBEDPBE<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput GBKBNNNFJGC(TInput GJDJIDOLBAE, [Out] IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NIOAMEHLGLF(TInput GJDJIDOLBAE, [Out] TOutput? KHPJAGHLNBM, [Out] IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface HAPFDJAICOL
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	OKAGKBEDPBE<GIDMCCLKDAJ, HAJLBENLNNH> CICBAKJGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	OKAGKBEDPBE<HLPJBLPBJFD, HMLNFBEHCNE> EKHMKBEGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	PEELHAHOCGD OBLEHPGOBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal enum DDJPOELJLHC
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IOGAFGFCJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCMMCKDOKGD LMOHAAKIFFE(HAJLBENLNNH LJIEGDEDOHM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface PEELHAHOCGD
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLPJBLPBJFD LMOHAAKIFFE(HAJLBENLNNH LJIEGDEDOHM, int EKIEHPJCEHF, string? EPPPGDEIJCI, string? KHCNICJLEON, NONJPEHBDOG CPIPMBOAGCD, List<LADAKBLMDLG>? MJCFJFKKJMH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HAAHLEBGOKA]
internal class MDOKDPFNOEK : INGEAKOAKKK<GIDMCCLKDAJ, HAJLBENLNNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly BEJANLLLKLB LGLHNJPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly OKPKEFOAGHC AIKGBCHKFNA;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B9C0", Offset = "0x6B3ABC0", VA = "0x186B3B9C0")]
	public MDOKDPFNOEK(KKFEOLGKPAG GFPDKEBCGJG, BEJANLLLKLB LGLHNJPHIGK, PACHMFNGNKE HIMGNMIHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6B3B720", Offset = "0x6B3A920", VA = "0x186B3B720", Slot = "6")]
	public override HAJLBENLNNH GBKBNNNFJGC(GIDMCCLKDAJ GJDJIDOLBAE, [Out] IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RecRoom.NoEngine.Common.Preserve]
internal class NGOCPINNLND : KKFEOLGKPAG
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class KDJLPGJCBCA : JsonConverter<MPEKJAJPCMO>
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3ADA0", Offset = "0x6B39FA0", VA = "0x186B3ADA0", Slot = "9")]
		public override void WriteJson(JsonWriter MIOAACOLOAF, MPEKJAJPCMO? JECHHBGMFLN, JsonSerializer GKDINGKIFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6B3AC80", Offset = "0x6B39E80", VA = "0x186B3AC80", Slot = "10")]
		public override MPEKJAJPCMO ReadJson(JsonReader IDGMLEGKFGC, Type EAPHLKNKMNE, MPEKJAJPCMO? MEKKNMBHKPC, bool NDOOGCGNAML, JsonSerializer GKDINGKIFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6B3AE40", Offset = "0x6B3A040", VA = "0x186B3AE40")]
		public KDJLPGJCBCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class CCLADNCOKFM : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool PBDKADJHBJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6B36620", Offset = "0x6B35820", VA = "0x186B36620", Slot = "5")]
		public override object ReadJson(JsonReader IDGMLEGKFGC, Type EAPHLKNKMNE, object? MEKKNMBHKPC, JsonSerializer GKDINGKIFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6B36260", Offset = "0x6B35460", VA = "0x186B36260", Slot = "6")]
		public override bool CanConvert(Type EAPHLKNKMNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6B36680", Offset = "0x6B35880", VA = "0x186B36680", Slot = "4")]
		public override void WriteJson(JsonWriter MIOAACOLOAF, object? JECHHBGMFLN, JsonSerializer GKDINGKIFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6B36440", Offset = "0x6B35640", VA = "0x186B36440")]
		private static bool FFJGNMCDONP(object JECHHBGMFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public CCLADNCOKFM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly JsonSerializerSettings NGFFEEKLEJP;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3BD10", Offset = "0x6B3AF10", VA = "0x186B3BD10")]
	internal NGOCPINNLND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C8C0", Offset = "0x2F7BAC0", VA = "0x182F7C8C0", Slot = "4")]
	public string KJJPPJLPKAA<T>(T JMJAOKJJFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C830", Offset = "0x2F7BA30", VA = "0x182F7C830", Slot = "5")]
	public T DKCLNLKHMKL<T>(string JECHHBGMFLN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RecRoom.NoEngine.Common.Preserve]
internal class IEBCFEOIKAC : KKFEOLGKPAG
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2E45850", Offset = "0x2E44A50", VA = "0x182E45850", Slot = "4")]
	public string KJJPPJLPKAA<T>(T JMJAOKJJFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2E457D0", Offset = "0x2E449D0", VA = "0x182E457D0", Slot = "5")]
	public T DKCLNLKHMKL<T>(string JECHHBGMFLN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public IEBCFEOIKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[HAAHLEBGOKA]
internal class OKPKEFOAGHC : INGEAKOAKKK<HLPJBLPBJFD, HMLNFBEHCNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly KKFEOLGKPAG GFPDKEBCGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly BEJANLLLKLB LGLHNJPHIGK;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E260", Offset = "0x6B3D460", VA = "0x186B3E260")]
	public OKPKEFOAGHC(KKFEOLGKPAG GFPDKEBCGJG, BEJANLLLKLB LGLHNJPHIGK, PACHMFNGNKE HIMGNMIHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CEC0", Offset = "0x6B3C0C0", VA = "0x186B3CEC0", Slot = "6")]
	public override HMLNFBEHCNE GBKBNNNFJGC(HLPJBLPBJFD GJDJIDOLBAE, [Out] IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E110", Offset = "0x6B3D310", VA = "0x186B3E110")]
	internal void OJEIDLIEDHP(string PAJOGNEGIBF, HAJLBENLNNH HDNIDPMFHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D2E0", Offset = "0x6B3C4E0", VA = "0x186B3D2E0")]
	public IEnumerable<FENDCALOPLC> KEGMLHKJKJB(string PCDOLOGLLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6B3BFD0", Offset = "0x6B3B1D0", VA = "0x186B3BFD0")]
	private IEnumerable<FENDCALOPLC> DCNKJFMBACP(string PCDOLOGLLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6B3C3E0", Offset = "0x6B3B5E0", VA = "0x186B3C3E0")]
	internal IEnumerable<FENDCALOPLC> DPFIADJPHMM(string PCDOLOGLLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6B3CB40", Offset = "0x6B3BD40", VA = "0x186B3CB40")]
	private FENDCALOPLC EPLJJAJLODA(AvatarOutfitSelectionData IGNKBFMKNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D390", Offset = "0x6B3C590", VA = "0x186B3D390")]
	private void NAFNHDKONNI(AvatarCustomizationSettingsData EFKDOFCFPBM, HAJLBENLNNH HDNIDPMFHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6B3C830", Offset = "0x6B3BA30", VA = "0x186B3C830")]
	private FENDCALOPLC EPLJJAJLODA(string KNJIIHNOCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DC10", Offset = "0x6B3CE10", VA = "0x186B3DC10")]
	internal static (IPFKHDEMKPH, string, string) NNEBCMGAPON(string KNJIIHNOCFB, PACHMFNGNKE HIMGNMIHEHA)
	{
		return default((IPFKHDEMKPH, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DF10", Offset = "0x6B3D110", VA = "0x186B3DF10")]
	private IALFIMLAJHG? NNKAJOPEAHA(string? KGBBBBHDKAF, Vector2 MMCPMBFKFKI, float ABOONCNIEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6B3BE70", Offset = "0x6B3B070", VA = "0x186B3BE70")]
	private static HMMONNFLLEB BOIKGHPCENA(AvatarCustomizationSettingsData.AnchorParams NAADGKMBLBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[HAAHLEBGOKA]
internal class HGNHMOAAAEH : BKFOJHANOMA, IOGAFGFCJCO
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6B35720", Offset = "0x6B34920", VA = "0x186B35720")]
	public HGNHMOAAAEH(KKFEOLGKPAG GFPDKEBCGJG, BEJANLLLKLB LGLHNJPHIGK, PACHMFNGNKE HIMGNMIHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6B399D0", Offset = "0x6B38BD0", VA = "0x186B399D0", Slot = "4")]
	public PCMMCKDOKGD LMOHAAKIFFE(HAJLBENLNNH LJIEGDEDOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6B39690", Offset = "0x6B38890", VA = "0x186B39690")]
	private string APIBCDLPLHF(HAJLBENLNNH HDNIDPMFHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6B39790", Offset = "0x6B38990", VA = "0x186B39790")]
	private string CGCFEIMGEFN(FENDCALOPLC ABBOKBDDLDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[HAAHLEBGOKA]
internal class CAJHOBFBEMF : INGEAKOAKKK<HLPJBLPBJFD, HMLNFBEHCNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly KKFEOLGKPAG GFPDKEBCGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly OKAGKBEDPBE<HLPJBLPBJFD, HMLNFBEHCNE> FDPFHNIKNKJ;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6B36160", Offset = "0x6B35360", VA = "0x186B36160")]
	public CAJHOBFBEMF(OKAGKBEDPBE<HLPJBLPBJFD, HMLNFBEHCNE> FDPFHNIKNKJ, PACHMFNGNKE HIMGNMIHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6B35D30", Offset = "0x6B34F30", VA = "0x186B35D30", Slot = "6")]
	public override HMLNFBEHCNE GBKBNNNFJGC(HLPJBLPBJFD GJDJIDOLBAE, [Out] IReadOnlyList<LADAKBLMDLG>? MJCFJFKKJMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[HAAHLEBGOKA]
internal class BLDJEEGBCHJ : PEELHAHOCGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly KKFEOLGKPAG GFPDKEBCGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly IOGAFGFCJCO AEJKLMEMPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6B35C40", Offset = "0x6B34E40", VA = "0x186B35C40")]
	public BLDJEEGBCHJ(IOGAFGFCJCO AEJKLMEMPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6B358A0", Offset = "0x6B34AA0", VA = "0x186B358A0", Slot = "4")]
	public HLPJBLPBJFD LMOHAAKIFFE(HAJLBENLNNH LJIEGDEDOHM, int EKIEHPJCEHF, string? EPPPGDEIJCI, string? KHCNICJLEON, NONJPEHBDOG CPIPMBOAGCD, List<LADAKBLMDLG>? MJCFJFKKJMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RecRoom.NoEngine.Common.Preserve]
internal class EEHACODDBKB : HAHCJDCFGIB
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 ELBOEJPJLPP;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 JNJBIHDFBBJ;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly Vector2 EDABDCDFNEH;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly Vector2 FIHLOGPHPOM;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static readonly Vector2 GAELDIBEECP;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static readonly Vector2 MLIHLMLAMMP;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static readonly Vector2 EBBBCBBDJPC;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly Vector2 HNHCPFAIBGN;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static readonly Vector2 FGHEGNFKKAN;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly Vector2 OPKBPJEOGCF;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private static readonly Vector2 OMONJLBOHIC;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly Vector2 FFBIJHIHIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Dictionary<DANEJOKJCGO, AvatarConfiguration> CPELINHACBH;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6B37370", Offset = "0x6B36570", VA = "0x186B37370")]
	[NPIOOMADHDK.JLDADBHPDAA]
	internal static void ELFABFAMGKI(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6B38840", Offset = "0x6B37A40", VA = "0x186B38840")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EEHACODDBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6B37D40", Offset = "0x6B36F40", VA = "0x186B37D40", Slot = "4")]
	public Vector2 NAGOHHJECOP(FaceFeatureType INKLBEJOPCG, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6B37530", Offset = "0x6B36730", VA = "0x186B37530", Slot = "5")]
	public float GLJKHGIIOJI(FaceFeatureType INKLBEJOPCG, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6B375B0", Offset = "0x6B367B0", VA = "0x186B375B0", Slot = "6")]
	public void HBDAHOAMDKK(DANEJOKJCGO HAELGLMEIMP, AvatarConfiguration IDLPLLJJIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6B37620", Offset = "0x6B36820", VA = "0x186B37620", Slot = "7")]
	public void HKKMCNKDHNJ(KKEEBNBGFGE MGNBPBHJDOG, AvatarConfiguration ODPKPFKMAJM, DANEJOKJCGO IBJCBLOMNOJ, DANEJOKJCGO HLJFBLKMLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6B371A0", Offset = "0x6B363A0", VA = "0x186B371A0", Slot = "8")]
	public float DCBEPGADAGC(FaceFeatureType JGLOFNNAFGG, float EBNKAFLFNBN, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B38630", Offset = "0x6B37830", VA = "0x186B38630", Slot = "9")]
	public float POCCBBMGJNA(FaceFeatureType JGLOFNNAFGG, float ABOONCNIEIJ, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B36B60", Offset = "0x6B35D60", VA = "0x186B36B60", Slot = "11")]
	public Vector2 BBOOOCCFIBE(FaceFeatureType JGLOFNNAFGG, Vector2 OBAOAIHMKHP, Vector2 OKHBIGOMKIA, Vector2 HHMHPPFPKOK, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B36D10", Offset = "0x6B35F10", VA = "0x186B36D10", Slot = "10")]
	public Vector2 BGHHONFKDGB(FaceFeatureType JGLOFNNAFGG, Vector2 MCDJMBFBACK, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B37000", Offset = "0x6B36200", VA = "0x186B37000")]
	private Vector2 BLIJMALGHHN(FaceFeatureType JGLOFNNAFGG, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B382D0", Offset = "0x6B374D0", VA = "0x186B382D0")]
	private Vector2 NEDLCNLGGIJ(FaceFeatureType JGLOFNNAFGG, Vector2 OBAOAIHMKHP, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B37EB0", Offset = "0x6B370B0", VA = "0x186B37EB0", Slot = "12")]
	public Vector2 NAMLIBFDLID(FaceFeatureType JGLOFNNAFGG, Vector2 MCDJMBFBACK, Vector2 OKHBIGOMKIA, Vector2 HHMHPPFPKOK, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B37850", Offset = "0x6B36A50", VA = "0x186B37850", Slot = "13")]
	public float JLBBJOAOFAG(FaceFeatureType JGLOFNNAFGG, float ABOONCNIEIJ, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B374A0", Offset = "0x6B366A0", VA = "0x186B374A0")]
	private float GKBMIIJFDLI(float LGOHHHLPLHB, float KBKIMKNFKDL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B385B0", Offset = "0x6B377B0", VA = "0x186B385B0")]
	private Vector2 PHFCBLCHACF(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B370E0", Offset = "0x6B362E0", VA = "0x186B370E0")]
	private Vector2 CHMNAMBFGME(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B38250", Offset = "0x6B37450", VA = "0x186B38250")]
	private Vector2 NCFKKMCDEAG(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B37420", Offset = "0x6B36620", VA = "0x186B37420")]
	private Vector2 GDIMOPFEKPD(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B37160", Offset = "0x6B36360", VA = "0x186B37160")]
	private float CLGKNGGPJIP(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B370A0", Offset = "0x6B362A0", VA = "0x186B370A0")]
	private float BOPOLEKBPKJ(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6B373E0", Offset = "0x6B365E0", VA = "0x186B373E0")]
	private float FGCFCKANLNM(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B36A50", Offset = "0x6B35C50", VA = "0x186B36A50")]
	private float AHDCHNICPNM(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B38430", Offset = "0x6B37630", VA = "0x186B38430")]
	private Vector2 NOCBFDPDPEN(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B36F30", Offset = "0x6B36130", VA = "0x186B36F30")]
	private Vector2 BJDONNDOBHC(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B376D0", Offset = "0x6B368D0", VA = "0x186B376D0")]
	private Vector2 JCLABJJOOPN(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B37AF0", Offset = "0x6B36CF0", VA = "0x186B37AF0")]
	private Vector2 LAAPHPMBDLC(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B371D0", Offset = "0x6B363D0", VA = "0x186B371D0")]
	private Vector2 DDEGFDPPKAA(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B37A20", Offset = "0x6B36C20", VA = "0x186B37A20")]
	private Vector2 KNLGNLNNJOK(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B37BC0", Offset = "0x6B36DC0", VA = "0x186B37BC0")]
	private Vector2 LOAJHJNFGHI(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B36A90", Offset = "0x6B35C90", VA = "0x186B36A90")]
	private Vector2 BABIGCEAEBM(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B372A0", Offset = "0x6B364A0", VA = "0x186B372A0")]
	private Vector2 DKDNOCOGOAO(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B377A0", Offset = "0x6B369A0", VA = "0x186B377A0")]
	private Vector2 JFBHCBEEOAN(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B37C90", Offset = "0x6B36E90", VA = "0x186B37C90")]
	private Vector2 NADFLCHJJOH(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6B38500", Offset = "0x6B37700", VA = "0x186B38500")]
	private Vector2 OEMOBFOOOLN(DANEJOKJCGO HAELGLMEIMP)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6B30D50", Offset = "0x6B2FF50", VA = "0x186B30D50")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CHPHABKJGEA
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6B367C0", Offset = "0x6B359C0", VA = "0x186B367C0")]
	public static LGIGHIHBKAO GBKBNNNFJGC(this JCEDIEHJAIC LJIEGDEDOHM)
	{
		return default(LGIGHIHBKAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6B36930", Offset = "0x6B35B30", VA = "0x186B36930")]
	public static JCEDIEHJAIC LMOHAAKIFFE(this LGIGHIHBKAO CBLGBPDFLLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6B36760", Offset = "0x6B35960", VA = "0x186B36760")]
	public static bool EAILFGKHKAC(this LGIGHIHBKAO CBLGBPDFLLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6B368D0", Offset = "0x6B35AD0", VA = "0x186B368D0")]
	public static bool LKANPGHCKMG(this LGIGHIHBKAO CBLGBPDFLLN)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4FD0AE0", Offset = "0x4FCFCE0", VA = "0x184FD0AE0")]
			public AnchorParams(Vector2 OBAOAIHMKHP, Vector3 ICLPEAGENDJ, Vector3 LPINAINOABB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6B30CA0", Offset = "0x6B2FEA0", VA = "0x186B30CA0")]
			internal HMMONNFLLEB LMOHAAKIFFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private OBKCEGEEPPJ useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6B31530", Offset = "0x6B30730", VA = "0x186B31530")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x47C45C0", Offset = "0x47C37C0", VA = "0x1847C45C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x99CD10", Offset = "0x99BF10", VA = "0x18099CD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA1BE30", Offset = "0xA1B030", VA = "0x180A1BE30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xCA44F0", Offset = "0xCA36F0", VA = "0x180CA44F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x89AD00", Offset = "0x899F00", VA = "0x18089AD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6B315D0", Offset = "0x6B307D0", VA = "0x186B315D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x89F8D0", Offset = "0x89EAD0", VA = "0x18089F8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xB325C0", Offset = "0xB317C0", VA = "0x180B325C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x13686A0", Offset = "0x13678A0", VA = "0x1813686A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x894340", Offset = "0x893540", VA = "0x180894340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x894350", Offset = "0x893550", VA = "0x180894350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6B31610", Offset = "0x6B30810", VA = "0x186B31610")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x972D90", Offset = "0x971F90", VA = "0x180972D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xB6F1D0", Offset = "0xB6E3D0", VA = "0x180B6F1D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1137AA0", Offset = "0x1136CA0", VA = "0x181137AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x897130", Offset = "0x896330", VA = "0x180897130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x897120", Offset = "0x896320", VA = "0x180897120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x443B1D0", Offset = "0x443A3D0", VA = "0x18443B1D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x98D790", Offset = "0x98C990", VA = "0x18098D790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8CBBA0", Offset = "0x8CADA0", VA = "0x1808CBBA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8CBC00", Offset = "0x8CAE00", VA = "0x1808CBC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8A2460", Offset = "0x8A1660", VA = "0x1808A2460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8A2550", Offset = "0x8A1750", VA = "0x1808A2550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8A2570", Offset = "0x8A1770", VA = "0x1808A2570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8A24F0", Offset = "0x8A16F0", VA = "0x1808A24F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x8A24C0", Offset = "0x8A16C0", VA = "0x1808A24C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8A23B0", Offset = "0x8A15B0", VA = "0x1808A23B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA25C10", Offset = "0xA24E10", VA = "0x180A25C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xDB3540", Offset = "0xDB2740", VA = "0x180DB3540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8A2400", Offset = "0x8A1600", VA = "0x1808A2400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8A2470", Offset = "0x8A1670", VA = "0x1808A2470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x99C970", Offset = "0x99BB70", VA = "0x18099C970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x98E630", Offset = "0x98D830", VA = "0x18098E630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x899430", Offset = "0x898630", VA = "0x180899430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8993B0", Offset = "0x8985B0", VA = "0x1808993B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x90F820", Offset = "0x90EA20", VA = "0x18090F820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x9A0E80", Offset = "0x9A0080", VA = "0x1809A0E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xCA93F0", Offset = "0xCA85F0", VA = "0x180CA93F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xFC3CA0", Offset = "0xFC2EA0", VA = "0x180FC3CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public OBKCEGEEPPJ UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA1FFB0", Offset = "0xA1F1B0", VA = "0x180A1FFB0")]
			get
			{
				return default(OBKCEGEEPPJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA208D0", Offset = "0xA1FAD0", VA = "0x180A208D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xA21BA0", Offset = "0xA20DA0", VA = "0x180A21BA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA21C60", Offset = "0xA20E60", VA = "0x180A21C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6B315F0", Offset = "0x6B307F0", VA = "0x186B315F0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x6B31630", Offset = "0x6B30830", VA = "0x186B31630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6B311D0", Offset = "0x6B303D0", VA = "0x186B311D0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public IPFKHDEMKPH BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private OOBMPNMLJGF? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x6B336D0", Offset = "0x6B328D0", VA = "0x186B336D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
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
