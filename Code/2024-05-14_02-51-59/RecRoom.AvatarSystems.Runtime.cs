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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x6220250", Offset = "0x621EC50", VA = "0x186220250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[JFFHACELPPM]
internal class NAAILDJKBHB : ACDCIOHCIKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct PONDCKOBACG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NAAILDJKBHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public HOOKFBKAAPJ avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AAJCFCFCAEB EPHFHOHCEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BHLHANEPCEB DMCCCHMFNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JIPIHMKGMNC CNMFKJFOEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly MAMEICAOAJG AAPAMDPDCKA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x620D2A0", Offset = "0x620BCA0", VA = "0x18620D2A0")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.GameOnly)]
	[UsedImplicitly]
	private static void AODJBBGHLFI(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x620EB70", Offset = "0x620D570", VA = "0x18620EB70")]
	[Preserve]
	internal NAAILDJKBHB([JDJLHBHAJCP(null)] AAJCFCFCAEB EPHFHOHCEAH, [JDJLHBHAJCP(null)] BHLHANEPCEB DMCCCHMFNCA, [JDJLHBHAJCP(null)] JIPIHMKGMNC CNMFKJFOEJE, [JDJLHBHAJCP(null)] MAMEICAOAJG AAPAMDPDCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x620D310", Offset = "0x620BD10", VA = "0x18620D310", Slot = "5")]
	public OFACNJAMAEN CIDPIFJKJPI(bool LBDPCGDFCKK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x620DEF0", Offset = "0x620C8F0", VA = "0x18620DEF0", Slot = "4")]
	public OFACNJAMAEN MOMHNCEMFCO(bool LBDPCGDFCKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x620DDE0", Offset = "0x620C7E0", VA = "0x18620DDE0", Slot = "6")]
	public HLJDKLFNOBH JJMOIGBCLHI(OFACNJAMAEN ABDLEBPKDKC, int BCBPFMFEAHC, string? GKDOOPOCBPP, string? OLCNPPPDBHP, KCMDKMFGMIO INLJBNBBCKM, List<PLFJENGLHGM>? CLGDKAPAPJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x620D210", Offset = "0x620BC10", VA = "0x18620D210", Slot = "7")]
	public bool AAILGILHJNA(DIEPDBDMEGI CBMEMELEHAE, [Out] OFACNJAMAEN? EHILAAAAAOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x620DD00", Offset = "0x620C700", VA = "0x18620DD00", Slot = "8")]
	public bool IBEMLIAGJHE(HLJDKLFNOBH FDDHLNNMJOH, [Out] OFACNJAMAEN? EHILAAAAAOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x620DAC0", Offset = "0x620C4C0", VA = "0x18620DAC0", Slot = "9")]
	public bool COOECCMHGPL(HLJDKLFNOBH FDDHLNNMJOH, [Out] FIBBCEMKLGG? CBMEMELEHAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A79CA0", Offset = "0x2A786A0", VA = "0x182A79CA0")]
	private bool BKPLPOKAAJD<TInput, TOutput>(TInput KAPFFOPPBJF, JFNGHKMKAKC<TInput, TOutput> EAPEENGMIKJ, [Out] TOutput? LKBGEIGOHEF) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x620DB50", Offset = "0x620C550", VA = "0x18620DB50")]
	[CompilerGenerated]
	private FJIHDFFKLMB EJHBPEIKDJF(FaceFeatureType KIDMEJEMJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x620E890", Offset = "0x620D290", VA = "0x18620E890")]
	[CompilerGenerated]
	private FJIHDFFKLMB OFOLNHAJCNC(FaceFeatureType KIDMEJEMJHF, PONDCKOBACG P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[JFFHACELPPM]
internal class GINMJFGCHCI : AAJCFCFCAEB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void GFKMIMCDAMH<in TData>(TData EHILAAAAAOH, IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JIPIHMKGMNC CNMFKJFOEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KMDJJDLOPBI HILDBFOHDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GFKMIMCDAMH<OFACNJAMAEN>?[] EPHFHOHCEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GFKMIMCDAMH<FIBBCEMKLGG>?[] LJBHADFPPLD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x620B060", Offset = "0x6209A60", VA = "0x18620B060")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.GameOnly)]
	[UsedImplicitly]
	private static void AODJBBGHLFI(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x620BFA0", Offset = "0x620A9A0", VA = "0x18620BFA0")]
	[Preserve]
	internal GINMJFGCHCI([JDJLHBHAJCP(null)] JIPIHMKGMNC CNMFKJFOEJE, [JDJLHBHAJCP(null)] KMDJJDLOPBI HILDBFOHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x620B230", Offset = "0x6209C30", VA = "0x18620B230", Slot = "4")]
	public bool IBNPMCPMPOD(OFACNJAMAEN EHILAAAAAOH, IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x620B0D0", Offset = "0x6209AD0", VA = "0x18620B0D0", Slot = "5")]
	public bool IBNPMCPMPOD(FIBBCEMKLGG CBMEMELEHAE, IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x620B560", Offset = "0x6209F60", VA = "0x18620B560")]
	private void NIIDIBCINCG(OFACNJAMAEN EHILAAAAAOH, IReadOnlyList<PLFJENGLHGM>? GCGDEDCNCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x620B330", Offset = "0x6209D30", VA = "0x18620B330")]
	private void LALEEENMKCF(OFACNJAMAEN EHILAAAAAOH, IReadOnlyList<PLFJENGLHGM>? GCGDEDCNCCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AAJCFCFCAEB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IBNPMCPMPOD(OFACNJAMAEN EHILAAAAAOH, IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IBNPMCPMPOD(FIBBCEMKLGG CBMEMELEHAE, IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarElbowBendHelperController : MonoBehaviour, FJKOEONHJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
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
		private Vector3? MAHCBJFNJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool EMEPGIFDGCB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6202320", Offset = "0x6200D20", VA = "0x186202320", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6202920", Offset = "0x6201320", VA = "0x186202920", Slot = "4")]
		public void UpdateController(float JFNONBMGLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD23A50", Offset = "0xD22450", VA = "0x180D23A50", Slot = "6")]
		public void SetEnabled(bool AEJBOLFACJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62023C0", Offset = "0x6200DC0", VA = "0x1862023C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6202D40", Offset = "0x6201740", VA = "0x186202D40")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendTargetController : MonoBehaviour, FJKOEONHJGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const float FAFCEPGDGMN = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
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
		private Vector3 ICLFKLKBBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Vector3 LAACOLLEJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool EMEPGIFDGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float PIOEKNNIMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private float AHPNKHIAJGF;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62030C0", Offset = "0x6201AC0", VA = "0x1862030C0", Slot = "4")]
		public void UpdateController(float JFNONBMGLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA43CE0", Offset = "0xA426E0", VA = "0x180A43CE0", Slot = "6")]
		public void SetEnabled(bool AEJBOLFACJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6202DE0", Offset = "0x62017E0", VA = "0x186202DE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6203AA0", Offset = "0x62024A0", VA = "0x186203AA0")]
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
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
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
		[Cpp2IlInjected.Address(RVA = "0x62043C0", Offset = "0x6202DC0", VA = "0x1862043C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6204380", Offset = "0x6202D80", VA = "0x186204380")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6203AD0", Offset = "0x62024D0", VA = "0x186203AD0")]
		private void IAOAHGKOBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x11CD250", Offset = "0x11CBC50", VA = "0x1811CD250", Slot = "4")]
		public void SetEnabled(bool IHFMNOOBPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62043F0", Offset = "0x6202DF0", VA = "0x1862043F0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarForearmRollController : MonoBehaviour, FJKOEONHJGH
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
		private bool EMEPGIFDGCB;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6204430", Offset = "0x6202E30", VA = "0x186204430", Slot = "4")]
		public void UpdateController(float JFNONBMGLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7D43E0", Offset = "0x7D2DE0", VA = "0x1807D43E0", Slot = "6")]
		public void SetEnabled(bool AEJBOLFACJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6204BB0", Offset = "0x62035B0", VA = "0x186204BB0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, OAFDGKHMAII
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
		[JBAFOAIPPLI(PHOLEAOCMFP.SelfAndChildren, false, false, false)]
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
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private IGMDLNOEPHG APCPHPDBPAD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IGMDLNOEPHG OONBGOCJIIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x62059A0", Offset = "0x62043A0", VA = "0x1862059A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform AHCEHMHEBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x62059E0", Offset = "0x62043E0", VA = "0x1862059E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6204BE0", Offset = "0x62035E0", VA = "0x186204BE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6205860", Offset = "0x6204260", VA = "0x186205860")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6205810", Offset = "0x6204210", VA = "0x186205810")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62057A0", Offset = "0x62041A0", VA = "0x1862057A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6205720", Offset = "0x6204120", VA = "0x186205720", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62057A0", Offset = "0x62041A0", VA = "0x1862057A0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6205330", Offset = "0x6203D30", VA = "0x186205330", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62058B0", Offset = "0x62042B0", VA = "0x1862058B0", Slot = "8")]
		public void UpdatePostIKAnimControllers(float JFNONBMGLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6204C60", Offset = "0x6203660", VA = "0x186204C60")]
		private void BHJHMAJHDOJ(GameObject COMOOAEHALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6204CF0", Offset = "0x62036F0", VA = "0x186204CF0")]
		private IGMDLNOEPHG BIPOPMGMFCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is turned off.")]
			public float AngleOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is fully on.")]
			public float AngleOn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[Tooltip("Normalized height (0-1) where IK is turned off.")]
			public float HeightOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[Tooltip("Normalized height (0-1) where IK is fully on.")]
			public float HeightOn;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6220540", Offset = "0x621EF40", VA = "0x186220540")]
			public float IPCOLAIIDDE(float CABMFOMELEA, float NKMLPOKNGCH)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Header("Hand Animation")]
		[Tooltip("Time axis is the normalized distance the hand effector currently is from the origin of the upper arm bone.  A time of 0 implies the hand effector is directly on top of the upper arm origin (ie: up at your shoulder), a time = 1, that implies the hand effector is somewhere exactly a full arm's length away, a time of 1.7 implies the hand effector is somewhere exactly 1.7 times the arm's length away.  Value axis is the effector weight from 0 to 1.")]
		public AnimationCurve HandEffectorWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Time that the hand animator weight changes from 0 to 1 in a second. When the hand gesture system turns on when making a gesture, and off when the gesture system is idle, this determines the speed that it lerps towards the target weight.")]
		public float HandAnimatorWeightChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Time it takes to transition to an open or closed hand pose during an animated hand state transition")]
		public float HandOpenCloseChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F5")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Header("IK Weights")]
		[Tooltip("Control data for when to allow IK to control the head position for screens players.")]
		public WeightData ScreenHeadPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Control data for when to allow IK to control the head rotation for screens players.")]
		public WeightData ScreenHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Control data for when to allow IK to control the pelvis position for screens players.")]
		public WeightData ScreenPelvisPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Control data for when to allow IK to control the pelvis rotation for screens players.")]
		public WeightData ScreenPelvisRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Header("VR runtime weights")]
		[Tooltip("The head is moved flat forward with given amount in VR to match up with our animated head position.")]
		public float StaticHeadForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("The animated root is moved flat forward with given amount in VR to match up the physical feet with our animated feet.")]
		public float StaticRootForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Weight for head while moving. (0 = animated, 1 = VR)")]
		public float MovingHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Weight for head while idle. (0 = animated, 1 = VR)")]
		public float IdleHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Max head height offset compensation")]
		public float MaxHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Min head height offset compensation")]
		public float MinHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Head height offset compensation smooth time")]
		public float HeadHeightCompensationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Distance to apply head movement dampening")]
		public float HeadHeightDampeningDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		public float VRShoulderTwistBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6205A00", Offset = "0x6204400", VA = "0x186205A00")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MJFAAFGJMFC : GKHMLJOEGEB
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static int FFCMCOPMGAN;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static int NCMJFKDPAAL;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int ADMPIMGJHND;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int IJNOJNADGON;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int LNIFNGMLCBI;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static int OHMJCKIBAAG;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static int MPFKGLKFPLK;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static int ACONELGKAGM;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int IFMKLFHLAJC;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int[] DINMBLDDOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	internal bool DPKINFHCJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private DBHKFJIHFFG LBADENLFEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int JJFJOGMLPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private float OKODOFCHLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool OMCAKGDBFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Animator MDIHFLDBDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private AvatarFullBodyConfiguration KJNMIKANNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int MKCPHMDOLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int CAGPKEIHCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int GKJEAHOCKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool DMKBDNDDFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private JIOOCOJMACC CJIMDIOCNHM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform KDHHJEHHAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 IBJNGEPDDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDCA950", Offset = "0xDC9350", VA = "0x180DCA950")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDCA980", Offset = "0xDC9380", VA = "0x180DCA980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion KBNNIBNBGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1A1E7C0", Offset = "0x1A1D1C0", VA = "0x181A1E7C0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E070A0", Offset = "0x1E05AA0", VA = "0x181E070A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MLJIIJGFFHE HDFBOBMBIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1128270", Offset = "0x1126C70", VA = "0x181128270", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(MLJIIJGFFHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x116D880", Offset = "0x116C280", VA = "0x18116D880", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MLJIIJGFFHE NFOOFAGHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CF960", Offset = "0x7CE360", VA = "0x1807CF960", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(MLJIIJGFFHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CF9C0", Offset = "0x7CE3C0", VA = "0x1807CF9C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public float PEBJPLPDDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xF27AC0", Offset = "0xF264C0", VA = "0x180F27AC0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB3AAD0", Offset = "0xB394D0", VA = "0x180B3AAD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LEPAGJPMHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x620CC70", Offset = "0x620B670", VA = "0x18620CC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool MJFEEPPJEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x620C480", Offset = "0x620AE80", VA = "0x18620C480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EPDJFJMNNCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x620C4A0", Offset = "0x620AEA0", VA = "0x18620C4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x620CAA0", Offset = "0x620B4A0", VA = "0x18620CAA0", Slot = "19")]
	public void MPOMBMILLLK(DBHKFJIHFFG CHGFLBOHAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x620C740", Offset = "0x620B140", VA = "0x18620C740", Slot = "20")]
	public void JECKEOGKAMC(OHGDFPPDAHB BELGCNKCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x620C510", Offset = "0x620AF10", VA = "0x18620C510", Slot = "11")]
	public void GBPOJGNLPKH(bool EPKGBANDAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x620C770", Offset = "0x620B170", VA = "0x18620C770", Slot = "10")]
	public void JPCEEOKOBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x620C5A0", Offset = "0x620AFA0", VA = "0x18620C5A0")]
	private int IHAPMMJJNBF(MLJIIJGFFHE EOCMNGKDANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x620CC80", Offset = "0x620B680", VA = "0x18620CC80")]
	private void OGPBKOFFBFD(int KPGHNNAKIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x620C490", Offset = "0x620AE90", VA = "0x18620C490", Slot = "12")]
	public bool COOJMECNLLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x620C720", Offset = "0x620B120", VA = "0x18620C720", Slot = "13")]
	public bool IKGCJCCFFLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x620CA50", Offset = "0x620B450", VA = "0x18620CA50")]
	private MLJIIJGFFHE KHIAECGLPKL()
	{
		return default(MLJIIJGFFHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xDD0E10", Offset = "0xDCF810", VA = "0x180DD0E10", Slot = "14")]
	public void PPGIGGOBPGE(bool EPKGBANDAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x620C4B0", Offset = "0x620AEB0", VA = "0x18620C4B0", Slot = "9")]
	public void EKLMEBFLCAB(int KPGHNNAKIJF, float FOIHBOKMFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x620C750", Offset = "0x620B150", VA = "0x18620C750", Slot = "7")]
	public void JMACOAGPFPP(JIOOCOJMACC MLJADEFEEPB, bool LPFEOFHGOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x620C730", Offset = "0x620B130", VA = "0x18620C730", Slot = "8")]
	public void JCBCIDGOJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x620C4C0", Offset = "0x620AEC0", VA = "0x18620C4C0", Slot = "15")]
	public void FEEABHECNNA(Transform HHJLJBMAMDD, Vector3 AABFABCMHCJ, Quaternion JCDHEFIFJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x620D0D0", Offset = "0x620BAD0", VA = "0x18620D0D0")]
	public MJFAAFGJMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class NAHMDPFAKBG : IGMDLNOEPHG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class FLDJABFFKML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private float KNAKBNJALCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Vector3 IPKKLIHIOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private bool IHKPMJMOEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float DALDGLMHOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool EEMAIECOJEP;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool BPNDMICCKLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x62091F0", Offset = "0x6207BF0", VA = "0x1862091F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6209250", Offset = "0x6207C50", VA = "0x186209250")]
		public void MEODGNEHPNK(IKSolverVR.Arm BPCPEKPKPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6209280", Offset = "0x6207C80", VA = "0x186209280")]
		public void NLKGPPAEOLJ(IKSolverVR.Arm BPCPEKPKPKF, Transform AEMEHENOOLI, bool HELKCHGIAPD, AvatarFullBodyConfiguration FAKHGNGCNKM, float JAPPHOMJMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x62081E0", Offset = "0x6206BE0", VA = "0x1862081E0")]
		public void EBNEGMEBCKH(IKSolverVR.Arm BPCPEKPKPKF, bool GNKDLIOKDDJ, bool EEMAIECOJEP, AvatarFullBodyConfiguration FAKHGNGCNKM, float JAPPHOMJMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6209100", Offset = "0x6207B00", VA = "0x186209100")]
		private void KMLDCMGKAEM(Transform AEMEHENOOLI, IKSolverVR.Arm BPCPEKPKPKF, float LMDMMNFANJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6208290", Offset = "0x6206C90", VA = "0x186208290")]
		private void EMLGPIHFANM(bool HELKCHGIAPD, AvatarFullBodyConfiguration FAKHGNGCNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6208A90", Offset = "0x6207490", VA = "0x186208A90")]
		private void JDONNMAMBFD(AvatarFullBodyConfiguration FAKHGNGCNKM, float JAPPHOMJMBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6209210", Offset = "0x6207C10", VA = "0x186209210")]
		private void LNGDFFDFLGK(IKSolverVR.Arm BPCPEKPKPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6208300", Offset = "0x6206D00", VA = "0x186208300")]
		public void GFFHLJIDCOD(IKSolverVR.Arm BPCPEKPKPKF, Transform GMMFNBCCFLK, Transform NLIEPEMLLDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6208B20", Offset = "0x6207520", VA = "0x186208B20")]
		private (Vector3, Quaternion) JNNDPCAJCJL(MJFAAFGJMFC AOJFKHOKIAO, Quaternion OFDMBIPLOOI, Vector3 LHINFPEPAFM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6208FB0", Offset = "0x62079B0", VA = "0x186208FB0")]
		public void KLBLLPBCKCI(MJFAAFGJMFC AOJFKHOKIAO, IKSolverVR.Arm BPCPEKPKPKF, Quaternion OFDMBIPLOOI, Vector3 LHINFPEPAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x62084C0", Offset = "0x6206EC0", VA = "0x1862084C0")]
		public void GOJDBAHMOEH(MJFAAFGJMFC AOJFKHOKIAO, IKSolverVR.Arm BPCPEKPKPKF, Quaternion OFDMBIPLOOI, Vector3 LHINFPEPAFM, AvatarFullBodyConfiguration FAKHGNGCNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x62094A0", Offset = "0x6207EA0", VA = "0x1862094A0")]
		private static float OEBBNPJBIFM(bool IHFMNOOBPFC, float AEMGIECPDNE, float KHKFHBKIKHJ, float MFDKDFMIKBH, float JAPPHOMJMBA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6208030", Offset = "0x6206A30", VA = "0x186208030")]
		private static void CPJOBMEMNLJ(Transform MPBCCGDKJLE, Transform LLKDHFLEBGD, Transform MOKJALGDBAA, float FABEBFAODPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public FLDJABFFKML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private enum HJADCIMGONE
	{
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum FADMINODLPC
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int HJLJICDKEKG;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int OCBLLGNBFGJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int BENACPPCLIC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int MMPMDNIGLHL;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int EEIPCDDBFAB;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int MDLDNCFCBPO;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int GJGGEJPKEDF;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int ABABGKIOAML;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int AGFCEPJJLPA;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int CPONPJKHANF;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int GCACDADCOLD;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int CNNNAJIFGHO;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int NLMNFLKMEHJ;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int MGGKNFPMIIA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int HKKFICDFEOB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int OMPAICPIJIH;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int ADMEBIFEMOB;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int JJHIHJBCLNE;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int BDLLKHDGNGK;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int EBBCPAPHDNO;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int LAHNPHOELAE;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int PBCPHKAKLCG;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int NEEFNCFHBNO;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int FAKMEPIBFNJ;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int FDLMNLCCOHI;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int OCAFJNOFFCD;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int OBNGPAKCGCH;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int GJOPMACELIP;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int BGEKHKMAKFF;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int LANNOBOLHGC;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly Vector3 LBECIFLCEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private bool JFDHGFKGIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool NBBKMBPOJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool LHHOBFOOFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool BLDNPKDNOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool BLANNNOPBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Vector3 GIMDMOGDIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private MINOBPJNDBN? LBADENLFEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private INKOKDMKPEE? EOOJCOFHEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NMLDIONDNCM PMBHHMEGPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private GDCACBLAAKC PGMAEFODKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private MJFAAFGJMFC MDIDIJGNCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private MJFAAFGJMFC BIALECNLNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool KBOGKLHGEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private bool BJEAHCDNPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly AMCAHBFPFKN OBPCOOFMKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly NOFHJNOEPOF CHAEBJDBCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int OABAEHJFEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float KHFGKJCIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private GameObject DJCDDJOKOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Transform MOAHMODOGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Transform FFNPFCKIJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private float GGEEGGMAEME;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker NIHNFJKHALM;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker JBLLMGIFJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private ProfilerMarker HNMEAKGJIDL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker LGGGHFHCIDM;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly ProfilerMarker DOJFPPCHELF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ProfilerMarker FBGNGEHOLMN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly List<NAHMDPFAKBG> NHGJJIPDGBL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int DPCACIFCJDD;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> FFKEPMHDDFJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int AIDIBDAOJPE;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static int JLEHHAAMIHB;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int GBPMEIKGCKO;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int GHNCFAHLKHP;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float LGNFAIBNDOH;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int BLJNGBIBFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float AKBBANLIGEC;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static float FACIKHKNGOM;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float CICNPMNMBKJ;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static float BMEOPJMDJNC;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static JHMPLIIPMNK MNHDFBLGHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private float HLCMOJGMPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool MCBIIAPFDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float COBCOFIFHKL;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Quaternion HPAGCPAKFPI;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Quaternion HGMENPGKPLC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Vector3 GBIBCHLIPGG;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly Vector3 HIODMAJMOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private FLDJABFFKML AAJKAFFINBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private FLDJABFFKML IDCPOOOHLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private HJADCIMGONE NFJJCGFOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private float BAMLGHAINJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly EENGPEELNDP ADPNOKGCGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float ACIAFPLCBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float AGHMAGHBIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Vector3 IACCBBMILID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly PLJCJFBNLEF NGEAOBDOPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly JCNFLNNGJAO BJNNPCKACOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float KFEDLCLDHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private HJADCIMGONE AJLMFNEFJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private Vector3 GABIJGAOIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float PMIOGECLDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float DEFPOBAKMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private MNPEIFKLFOH GAOHEIEDKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private PLJCJFBNLEF FHAHGOFOMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly PLJCJFBNLEF JDIFBGCNNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly MNPEIFKLFOH EGLJENPDFCO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public KMHDPFOFGLH OJDGAICDOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public KMHDPFOFGLH AKCAJHPEFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public AvatarConfiguration FMLCLHPAHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62155D0", Offset = "0x6213FD0", VA = "0x1862155D0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AvatarFullBodyConfiguration PINMHPMOKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x621DE00", Offset = "0x621C800", VA = "0x18621DE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Transform KHPKFNOJEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x621CD00", Offset = "0x621B700", VA = "0x18621CD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Transform HEPAILFLLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6214AA0", Offset = "0x62134A0", VA = "0x186214AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private SkinnedMeshRenderer JHAPJBLPGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6211FA0", Offset = "0x62109A0", VA = "0x186211FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Renderer[] BLPONBDMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x621F2A0", Offset = "0x621DCA0", VA = "0x18621F2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private GameObject[] MPFHHCLJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x621E0A0", Offset = "0x621CAA0", VA = "0x18621E0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Animator LDJPCDMDNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6216B30", Offset = "0x6215530", VA = "0x186216B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private VRIK KMMAFNJGLBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x621A2F0", Offset = "0x6218CF0", VA = "0x18621A2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private FJKOEONHJGH LKBDABMPJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62182E0", Offset = "0x6216CE0", VA = "0x1862182E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private FJKOEONHJGH FIAAEHNBNJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62171A0", Offset = "0x6215BA0", VA = "0x1862171A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private FJKOEONHJGH BNNKPOINJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x621C940", Offset = "0x621B340", VA = "0x18621C940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private FJKOEONHJGH NNMFBDPENPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6217B10", Offset = "0x6216510", VA = "0x186217B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private FJKOEONHJGH LHLKGJOHPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x621DFD0", Offset = "0x621C9D0", VA = "0x18621DFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private FJKOEONHJGH LMPHGBFELPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6216C00", Offset = "0x6215600", VA = "0x186216C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private FJKOEONHJGH HBNGFBHILCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x621A5B0", Offset = "0x6218FB0", VA = "0x18621A5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private FJKOEONHJGH MIFCEFDEOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x620FA20", Offset = "0x620E420", VA = "0x18620FA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public INKOKDMKPEE LFBDAFGMCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6216CD0", Offset = "0x62156D0", VA = "0x186216CD0", Slot = "32")]
		get
		{
			return default(INKOKDMKPEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public GOJDIMLAHCA IJEAECICPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D6980", Offset = "0x8D5380", VA = "0x1808D6980", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DGANKBFPJAD BPPPFMGBKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA5ABD0", Offset = "0xA595D0", VA = "0x180A5ABD0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GKHMLJOEGEB IOGCGDLKBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD95010", Offset = "0xD93A10", VA = "0x180D95010", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GKHMLJOEGEB DLBMLINBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA611B0", Offset = "0xA5FBB0", VA = "0x180A611B0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public GameObject PACDKKMGCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x621E700", Offset = "0x621D100", VA = "0x18621E700", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Transform IPLBHEJNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC20", Offset = "0xA3C620", VA = "0x180A3DC20", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Transform IKAICKFDONF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5C10", Offset = "0x9C4610", VA = "0x1809C5C10", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Vector3 DLCCCBDKCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6214530", Offset = "0x6212F30", VA = "0x186214530", Slot = "29")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float BBBOIINJBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x620F550", Offset = "0x620DF50", VA = "0x18620F550", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform EPCHJJGGIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x621A3C0", Offset = "0x6218DC0", VA = "0x18621A3C0", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool LBMPLJGDKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x621E170", Offset = "0x621CB70", VA = "0x18621E170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool PJJCIMLMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x621F3E0", Offset = "0x621DDE0", VA = "0x18621F3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62156A0", Offset = "0x62140A0", VA = "0x1862156A0")]
	private void EOHGCPLAJJG([In] ELJDAEBKIKC EDLLEIMOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6219830", Offset = "0x6218230", VA = "0x186219830")]
	private void JCKCHOKNKKE(ELJDAEBKIKC EDLLEIMOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x621A420", Offset = "0x6218E20", VA = "0x18621A420")]
	private void JPCEEOKOBJG(NJEPMHMFMFN FABMDPFKLCK, GKHMLJOEGEB CCGJALIMLHB, IKSolverVR.Arm BPCPEKPKPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62198E0", Offset = "0x62182E0", VA = "0x1862198E0")]
	private void JEHCGFHHOMI([In] ELJDAEBKIKC MLJADEFEEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x621FE50", Offset = "0x621E850", VA = "0x18621FE50")]
	public NAHMDPFAKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x621D370", Offset = "0x621BD70", VA = "0x18621D370", Slot = "12")]
	public void NGLOOPGOIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x621CA10", Offset = "0x621B410", VA = "0x18621CA10", Slot = "13")]
	public void MCNAOEIHDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62127E0", Offset = "0x62111E0", VA = "0x1862127E0", Slot = "14")]
	public void BOIFMJELJFI(bool FBKCJHAEPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6218EF0", Offset = "0x62178F0", VA = "0x186218EF0", Slot = "22")]
	public Transform INHJGEOBADH(string CKOCOBJKKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x62189A0", Offset = "0x62173A0", VA = "0x1862189A0", Slot = "23")]
	public Vector3? IJHMECMKACG(string CKOCOBJKKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x621A680", Offset = "0x6219080", VA = "0x18621A680", Slot = "7")]
	public void KGLJCPJBJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6214B70", Offset = "0x6213570", VA = "0x186214B70", Slot = "6")]
	public void EMFNICJIJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x621F370", Offset = "0x621DD70", VA = "0x18621F370", Slot = "8")]
	public void PGPIHFMJBNC(float LIBHBFDDNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6217AC0", Offset = "0x62164C0", VA = "0x186217AC0")]
	private void HHNONIIAELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x620FF10", Offset = "0x620E910", VA = "0x18620FF10", Slot = "4")]
	public void BEAENCAGNNO(MINOBPJNDBN GFDIJFGMIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6219EB0", Offset = "0x62188B0", VA = "0x186219EB0", Slot = "5")]
	public void JIBDBIOOJAM(INKOKDMKPEE BELGCNKCKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62124D0", Offset = "0x6210ED0", VA = "0x1862124D0", Slot = "11")]
	public void BMONKCCKBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6216E00", Offset = "0x6215800", VA = "0x186216E00", Slot = "21")]
	public void FKIHHFOAGGC([Out] Vector3 PAEDNOFBPJJ, [Out] Quaternion KEFCJMIEEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x621DE90", Offset = "0x621C890", VA = "0x18621DE90", Slot = "24")]
	public void OGDEIDGNOAM(float EEBMKLPLCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62149F0", Offset = "0x62133F0", VA = "0x1862149F0", Slot = "25")]
	public HandLogicOffsets EGCOIDHKEBO()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x621DF10", Offset = "0x621C910", VA = "0x18621DF10", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets OGLKJFNECDO()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6217920", Offset = "0x6216320", VA = "0x186217920")]
	private void GOLBPJNHMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6217270", Offset = "0x6215C70", VA = "0x186217270")]
	private void GDOPMAPBIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x620F820", Offset = "0x620E220", VA = "0x18620F820")]
	private void ANEHKOGIJCB(IHGKDIOHOHL CFCJPFCCHOE, bool NCHCLNHGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x621EEF0", Offset = "0x621D8F0", VA = "0x18621EEF0")]
	private void PDABGLJLPJG(IHGKDIOHOHL CFCJPFCCHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x621C8F0", Offset = "0x621B2F0", VA = "0x18621C8F0")]
	public Vector3 LLKEBEPBKCN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6217BE0", Offset = "0x62165E0", VA = "0x186217BE0")]
	private void HMLINFEDIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x621B150", Offset = "0x6219B50", VA = "0x18621B150")]
	private float KLIPJDFMHLB([In] ELJDAEBKIKC MLJADEFEEPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62179E0", Offset = "0x62163E0", VA = "0x1862179E0")]
	private int HAFIHDMDFMH([In] FGKMNPELKPI BCGFJNCAIOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x621E1D0", Offset = "0x621CBD0", VA = "0x18621E1D0")]
	private void ONHAAOJGCOA(ELJDAEBKIKC EDLLEIMOMJG, bool JOOPJBGIJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x621F080", Offset = "0x621DA80", VA = "0x18621F080")]
	private static void PEFFEOLCPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x621BBB0", Offset = "0x621A5B0", VA = "0x18621BBB0")]
	private static void LBPGGNNILAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x62177D0", Offset = "0x62161D0", VA = "0x1862177D0")]
	private float GIIIINDEMAO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x62137C0", Offset = "0x62121C0", VA = "0x1862137C0")]
	private static int DMMFHNAOJHP(NAHMDPFAKBG OLKIFIEFDII, NAHMDPFAKBG AEIEBLGGCGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62111D0", Offset = "0x620FBD0", VA = "0x1862111D0")]
	private void BEFLCFDLPGF(ELJDAEBKIKC MLJADEFEEPB, AvatarFullBodyConfiguration FAKHGNGCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6217670", Offset = "0x6216070", VA = "0x186217670")]
	private void GFFHLJIDCOD([In] ELJDAEBKIKC MLJADEFEEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x621B2F0", Offset = "0x6219CF0", VA = "0x18621B2F0")]
	private void KMIDJNNBKAA([In] ELJDAEBKIKC MLJADEFEEPB, [In] AvatarFullBodyConfiguration FAKHGNGCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x620FAF0", Offset = "0x620E4F0", VA = "0x18620FAF0")]
	private void BCPCEKLIIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x620FCA0", Offset = "0x620E6A0", VA = "0x18620FCA0")]
	private void BDPDDKPLHIM([In] ELJDAEBKIKC MLJADEFEEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x620F280", Offset = "0x620DC80", VA = "0x18620F280")]
	public void ABIMBBBMKLD(RigidbodyEx JONFOBDKGHI, IKSolverVR.Arm BPCPEKPKPKF, Quaternion OFDMBIPLOOI, Vector3 LHINFPEPAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x620F9A0", Offset = "0x620E3A0", VA = "0x18620F9A0")]
	private float AOPJIIBGFCH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x621D7E0", Offset = "0x621C1E0", VA = "0x18621D7E0")]
	private void OECCOMAPGBG([In] ELJDAEBKIKC MLJADEFEEPB, [In] FADMINODLPC OBEBIHEBLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6219B60", Offset = "0x6218560", VA = "0x186219B60")]
	private void JFAPADJCHIP(ELJDAEBKIKC MLJADEFEEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62177B0", Offset = "0x62161B0", VA = "0x1862177B0")]
	private void GGIENANGKDN(HJADCIMGONE MBLEJLPJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62125C0", Offset = "0x6210FC0", VA = "0x1862125C0")]
	private void BOEABGJIPCO(float OMLCLOOHMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x621E7A0", Offset = "0x621D1A0", VA = "0x18621E7A0")]
	private void PCDLIKDNPEN([In] ELJDAEBKIKC MLJADEFEEPB, FADMINODLPC OBEBIHEBLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6213E50", Offset = "0x6212850", VA = "0x186213E50")]
	private Vector3 EAJKKLCKGCP([In] ELJDAEBKIKC MLJADEFEEPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x621AD60", Offset = "0x6219760", VA = "0x18621AD60")]
	private float KKOFJADGAPN(float JNHCJJINKFL, [In] ELJDAEBKIKC MLJADEFEEPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x62128B0", Offset = "0x62112B0", VA = "0x1862128B0")]
	private void CABDNMFMBDI(HJADCIMGONE MBLEJLPJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6214570", Offset = "0x6212F70", VA = "0x186214570")]
	private void EEMJDJCIHNF(float JNHCJJINKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x621CDD0", Offset = "0x621B7D0", VA = "0x18621CDD0")]
	private void MNJCJOMJFJC([In] ELJDAEBKIKC MLJADEFEEPB, FADMINODLPC OBEBIHEBLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x621B7A0", Offset = "0x621A1A0", VA = "0x18621B7A0")]
	private float KMLFCDKILNH([In] ELJDAEBKIKC EDLLEIMOMJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x620ED60", Offset = "0x620D760", VA = "0x18620ED60")]
	private void ABAGCIHFHEE(ELJDAEBKIKC MLJADEFEEPB, FADMINODLPC OBEBIHEBLFI, Vector3 KFPODLLAEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x621C740", Offset = "0x621B140", VA = "0x18621C740")]
	private static void LHDKOFDBCAA(Transform OEIDOHJNAOK, Quaternion DMBBOEJIOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x62134C0", Offset = "0x6211EC0", VA = "0x1862134C0")]
	private void DBGIJBPCJFP([In] ELJDAEBKIKC EMFGGEIGNKG, [In] FGKMNPELKPI BCGFJNCAIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62129D0", Offset = "0x62113D0", VA = "0x1862129D0")]
	private void CIOOKHGENHM([In] ELJDAEBKIKC EMFGGEIGNKG, [In] FGKMNPELKPI BCGFJNCAIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x62137F0", Offset = "0x62121F0", VA = "0x1862137F0")]
	private void DMMNBHKNEOA([In] ELJDAEBKIKC MLJADEFEEPB, [In] AvatarFullBodyConfiguration FAKHGNGCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x620F580", Offset = "0x620DF80", VA = "0x18620F580")]
	public void AMJHAHBKKBD([In] ELJDAEBKIKC MLJADEFEEPB, [In] AvatarFullBodyConfiguration FAKHGNGCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62183B0", Offset = "0x6216DB0", VA = "0x1862183B0", Slot = "33")]
	protected virtual void IFGCMDAJODJ([In] ELJDAEBKIKC MLJADEFEEPB, [In] AvatarFullBodyConfiguration FAKHGNGCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62146C0", Offset = "0x62130C0", VA = "0x1862146C0")]
	private void EFDFEGHBAPA([In] ELJDAEBKIKC MLJADEFEEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6212070", Offset = "0x6210A70", VA = "0x186212070")]
	private void BMGCCBGIBMK(float PJMCOBGNENP, [In] ELJDAEBKIKC EDLLEIMOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6217C50", Offset = "0x6216650", VA = "0x186217C50")]
	private float IBIMADGHIKF([In] ELJDAEBKIKC EDLLEIMOMJG, [In] AvatarFullBodyConfiguration FAKHGNGCNKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6211C00", Offset = "0x6210600", VA = "0x186211C00")]
	private void BGNJOLGGMHP([In] ELJDAEBKIKC EDLLEIMOMJG, [In] AvatarFullBodyConfiguration FAKHGNGCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6218B30", Offset = "0x6217530", VA = "0x186218B30")]
	private void IJIPGHLAIME([In] ELJDAEBKIKC EDLLEIMOMJG, float CHBDPNJMDFE, float BAPOCKGGPLH, Vector3 AFKEFHELGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6219040", Offset = "0x6217A40", VA = "0x186219040")]
	private void JAHCEJIIIJC(ELJDAEBKIKC EDLLEIMOMJG, AvatarFullBodyConfiguration FAKHGNGCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x62128D0", Offset = "0x62112D0", VA = "0x1862128D0")]
	[CompilerGenerated]
	internal static bool CDODOJEMPCO(IKSolverVR.Arm BPCPEKPKPKF, BDKBNHBIPHK JKAFDGHDACB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6213080", Offset = "0x6211A80", VA = "0x186213080")]
	[CompilerGenerated]
	internal static float DAIGIDOHPOF(Vector3 FBKKKHIFMIP, Vector3 GFBANMEIMKN, Vector3 HCINIPOMDAJ, ELJDAEBKIKC EDLLEIMOMJG, AvatarFullBodyConfiguration FAKHGNGCNKM, float KNFIDNLGJFO)
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
		public enum JANBMMLLBBE
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private JANBMMLLBBE handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6206310", Offset = "0x6204D10", VA = "0x186206310")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x62062D0", Offset = "0x6204CD0", VA = "0x1862062D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6205CA0", Offset = "0x62046A0", VA = "0x186205CA0")]
		private void IAOAHGKOBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x11CD250", Offset = "0x11CBC50", VA = "0x1811CD250", Slot = "4")]
		public void SetEnabled(bool IHFMNOOBPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6206340", Offset = "0x6204D40", VA = "0x186206340")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, FJKOEONHJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Vector3 ICLFKLKBBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Vector3 NGFEEOENDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3 EBIMJHMLNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Matrix4x4 FAMNOKIPHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private bool EMEPGIFDGCB;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x62067D0", Offset = "0x62051D0", VA = "0x1862067D0", Slot = "4")]
		public void UpdateController(float JFNONBMGLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x614B090", Offset = "0x6149A90", VA = "0x18614B090", Slot = "6")]
		public void SetEnabled(bool AEJBOLFACJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6206370", Offset = "0x6204D70", VA = "0x186206370")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6206E90", Offset = "0x6205890", VA = "0x186206E90")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
internal class EHFLLILLHJL : NIPKPIDMEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Dictionary<string, IGMDLNOEPHG> CHFMCCGOHDO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AILPDJKFIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6207D70", Offset = "0x6206770", VA = "0x186207D70")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.None)]
	private static void HMHBKKBBDIM(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6207DE0", Offset = "0x62067E0", VA = "0x186207DE0", Slot = "4")]
	public IGMDLNOEPHG KDEPJEDOMCD(string JJNGIKMDGEL, AvatarSystemConfiguration FJJFOHOHMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6207BF0", Offset = "0x62065F0", VA = "0x186207BF0", Slot = "5")]
	public void FCHBGGIFBOB(string JJNGIKMDGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6207FA0", Offset = "0x62069A0", VA = "0x186207FA0")]
	public EHFLLILLHJL()
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
		public class EBFLHCNFPCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private Dictionary<string, Transform> AFNJEPJDHEM;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public bool MJOGKGKNLAM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x6207540", Offset = "0x6205F40", VA = "0x186207540")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6207580", Offset = "0x6205F80", VA = "0x186207580")]
			public void LDAECJFICCI(VRIK DIGNMBLHGMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
			public void IJKOMCPHDEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x62074F0", Offset = "0x6205EF0", VA = "0x1862074F0")]
			public void EMPGGONCJIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x62076B0", Offset = "0x62060B0", VA = "0x1862076B0")]
			public EBFLHCNFPCA()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		[FHOJJMNIIDJ(PHOLEAOCMFP.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		[JBAFOAIPPLI(PHOLEAOCMFP.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly EBFLHCNFPCA FJCHNKHIEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private OAFDGKHMAII HAPOKCILHGK;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6206EA0", Offset = "0x62058A0", VA = "0x186206EA0")]
		private void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6207160", Offset = "0x6205B60", VA = "0x186207160")]
		private bool NAAODFBCBAE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x62071B0", Offset = "0x6205BB0", VA = "0x1862071B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6207220", Offset = "0x6205C20", VA = "0x186207220")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x62071C0", Offset = "0x6205BC0", VA = "0x1862071C0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6207410", Offset = "0x6205E10", VA = "0x186207410")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x620D0E0", Offset = "0x620BAE0", VA = "0x18620D0E0", Slot = "4")]
		public override void OnStateEnter(Animator JEJNLHOIBOF, AnimatorStateInfo FHBPOEBGOHG, int ADMKCBHFBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x620D200", Offset = "0x620BC00", VA = "0x18620D200")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal abstract class CNKLKJJAGFE<TInput, TOutput> : JFNGHKMKAKC<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected readonly KMDJJDLOPBI HILDBFOHDJH;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4E3EC60", Offset = "0x4E3D660", VA = "0x184E3EC60")]
	protected CNKLKJJAGFE(KMDJJDLOPBI HILDBFOHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput HIBHLHEFCGJ(TInput KAPFFOPPBJF, [Out] IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4E3EBC0", Offset = "0x4E3D5C0", VA = "0x184E3EBC0", Slot = "5")]
	public bool BKPLPOKAAJD(TInput KAPFFOPPBJF, [Out] TOutput? LKBGEIGOHEF, [Out] IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[JFFHACELPPM]
public static class EFGBFJILLLM
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly Regex NDDNKIDKKCL;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6207740", Offset = "0x6206140", VA = "0x186207740")]
	public static LMHGPJNKIML DCBFNLNLJAL(NNIELEFOFHC JBFFGIIFJOO, KHIGNFPBAIG GPCHKKIHAJF, Guid? FJEDLMBCIOF, Color? JOKPJFPPJDK, DCDDAAOOBKB OENALIHIKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6207950", Offset = "0x6206350", VA = "0x186207950")]
	public static IMADIEACKLJ DHACCBNHPFI(LMHGPJNKIML ABDLEBPKDKC)
	{
		return default(IMADIEACKLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2803F70", Offset = "0x2802970", VA = "0x182803F70")]
	internal static TModern? KECDNBAKNBB<TModern>(string? KAPFFOPPBJF, FKMAIDJKEAO<TModern> DLDGDBCLOBC, KMDJJDLOPBI HILDBFOHDJH, PMIJKGOJEDN AKMOHDJIDIA, TModern KMNPAIOLKBO) where TModern : struct, KMKAGJMEMOH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x28037E0", Offset = "0x28021E0", VA = "0x1828037E0")]
	internal static IFPKLGCBJFA JINHPCINILC<TModern>(string? KAPFFOPPBJF, FKMAIDJKEAO<TModern> DLDGDBCLOBC, KMDJJDLOPBI HILDBFOHDJH, PMIJKGOJEDN AKMOHDJIDIA, TModern KMNPAIOLKBO) where TModern : struct, KMKAGJMEMOH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6207A00", Offset = "0x6206400", VA = "0x186207A00")]
	internal static List<PLFJENGLHGM> IICPCGDKPKO(IEnumerable<IOPKBCJHMKL>? NMHILALEIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x28055C0", Offset = "0x2803FC0", VA = "0x1828055C0")]
	internal static string NJBHDMLMHGF<TModern>(TModern KAPFFOPPBJF, FKMAIDJKEAO<TModern> DLDGDBCLOBC, KMDJJDLOPBI HILDBFOHDJH) where TModern : KMKAGJMEMOH
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class MCOHPELKGIG : BHLHANEPCEB
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public JFNGHKMKAKC<DIEPDBDMEGI, OFACNJAMAEN> KIOBOMMCGMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public JFNGHKMKAKC<HLJDKLFNOBH, FIBBCEMKLGG> IEJEDAJBFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public JFNGHKMKAKC<HLJDKLFNOBH, FIBBCEMKLGG> HFNKBAIDCCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KAFGAMOLGDB AEDEHALFPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public DLCNKIKPAAO NOEFICFMKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x620C240", Offset = "0x620AC40", VA = "0x18620C240")]
	[UsedImplicitly]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.GameOnly)]
	private static void AODJBBGHLFI(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x620C2B0", Offset = "0x620ACB0", VA = "0x18620C2B0")]
	[Preserve]
	internal MCOHPELKGIG([JDJLHBHAJCP("UnitySerialization")] OIHOFHEEIIO AEEMIHKOKPI, [JDJLHBHAJCP(null)] MELEAMAAHID ODOCDPLLFBN, [JDJLHBHAJCP(null)] KMDJJDLOPBI HILDBFOHDJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum KLMNDOJOCEN
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PHMGJNILEJP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6220340", Offset = "0x621ED40", VA = "0x186220340")]
	public PHMGJNILEJP(string CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6220370", Offset = "0x621ED70", VA = "0x186220370")]
	public PHMGJNILEJP(string CPPFNMDMGHI, Exception BGHIPOHPBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x62202D0", Offset = "0x621ECD0", VA = "0x1862202D0")]
	public PHMGJNILEJP(KLMNDOJOCEN PEJCBFELECM, string CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6220300", Offset = "0x621ED00", VA = "0x186220300")]
	public PHMGJNILEJP(KLMNDOJOCEN PEJCBFELECM, string CPPFNMDMGHI, Exception BGHIPOHPBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class GADDBFILHIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly OIHOFHEEIIO AEEMIHKOKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected readonly MELEAMAAHID ODOCDPLLFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly KMDJJDLOPBI HILDBFOHDJH;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x620AEE0", Offset = "0x62098E0", VA = "0x18620AEE0")]
	protected GADDBFILHIB(OIHOFHEEIIO AEEMIHKOKPI, MELEAMAAHID ODOCDPLLFBN, KMDJJDLOPBI HILDBFOHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6209710", Offset = "0x6208110", VA = "0x186209710")]
	protected string CDEGAMFCAKM(OFACNJAMAEN EHILAAAAAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6209530", Offset = "0x6207F30", VA = "0x186209530")]
	protected string BLLIJILLKHL(OFACNJAMAEN EHILAAAAAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x620AA30", Offset = "0x6209430", VA = "0x18620AA30")]
	private AvatarOutfitSelectionData DCBFNLNLJAL(LMHGPJNKIML PBKOPJCBHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x620ADA0", Offset = "0x62097A0", VA = "0x18620ADA0")]
	private static AvatarCustomizationSettingsData.AnchorParams FILOGDCBNPD(BFLEOALKIFK? KKENDFMDGHM)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JFNGHKMKAKC<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput HIBHLHEFCGJ(TInput KAPFFOPPBJF, [Out] IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BKPLPOKAAJD(TInput KAPFFOPPBJF, [Out] TOutput? LKBGEIGOHEF, [Out] IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BHLHANEPCEB
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JFNGHKMKAKC<DIEPDBDMEGI, OFACNJAMAEN> KIOBOMMCGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JFNGHKMKAKC<HLJDKLFNOBH, FIBBCEMKLGG> HFNKBAIDCCD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KAFGAMOLGDB AEDEHALFPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal enum PMIJKGOJEDN
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DLCNKIKPAAO
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEKHMIALJBG BOALAEMEPIG(OFACNJAMAEN ABDLEBPKDKC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KAFGAMOLGDB
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLJDKLFNOBH BOALAEMEPIG(OFACNJAMAEN ABDLEBPKDKC, int BCBPFMFEAHC, string? GKDOOPOCBPP, string? OLCNPPPDBHP, KCMDKMFGMIO INLJBNBBCKM, List<PLFJENGLHGM>? CLGDKAPAPJF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[JFFHACELPPM]
internal class MILIDGAIAJE : CNKLKJJAGFE<DIEPDBDMEGI, OFACNJAMAEN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly MELEAMAAHID ODOCDPLLFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly NFJEICLHJCD BDPNIKLMENJ;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6223070", Offset = "0x6221A70", VA = "0x186223070")]
	public MILIDGAIAJE(OIHOFHEEIIO AEEMIHKOKPI, MELEAMAAHID ODOCDPLLFBN, KMDJJDLOPBI HILDBFOHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6222DC0", Offset = "0x62217C0", VA = "0x186222DC0", Slot = "6")]
	public override OFACNJAMAEN HIBHLHEFCGJ(DIEPDBDMEGI KAPFFOPPBJF, [Out] IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Preserve]
internal class BFGKPPAPLAO : OIHOFHEEIIO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class IOJKHPFMHNI : JsonConverter<IFPKLGCBJFA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6222380", Offset = "0x6220D80", VA = "0x186222380", Slot = "9")]
		public override void WriteJson(JsonWriter KLKMGHMAEIH, IFPKLGCBJFA? AEJBOLFACJC, JsonSerializer PAKNEEDIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6222260", Offset = "0x6220C60", VA = "0x186222260", Slot = "10")]
		public override IFPKLGCBJFA ReadJson(JsonReader INBDAJDBDHK, Type ILBMJEMBDKI, IFPKLGCBJFA? GKBJMKIMLDK, bool NPAGCLHPJEB, JsonSerializer PAKNEEDIODP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6222420", Offset = "0x6220E20", VA = "0x186222420")]
		public IOJKHPFMHNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class BAPNPIHPCLH : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool FPFAHHFIFPD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x62213B0", Offset = "0x621FDB0", VA = "0x1862213B0", Slot = "5")]
		public override object ReadJson(JsonReader INBDAJDBDHK, Type ILBMJEMBDKI, object? GKBJMKIMLDK, JsonSerializer PAKNEEDIODP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6220FF0", Offset = "0x621F9F0", VA = "0x186220FF0", Slot = "6")]
		public override bool CanConvert(Type ILBMJEMBDKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6221410", Offset = "0x621FE10", VA = "0x186221410", Slot = "4")]
		public override void WriteJson(JsonWriter KLKMGHMAEIH, object? AEJBOLFACJC, JsonSerializer PAKNEEDIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x62211D0", Offset = "0x621FBD0", VA = "0x1862211D0")]
		private static bool NHAJHKAOONI(object AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public BAPNPIHPCLH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly JsonSerializerSettings OBDBJKPMGDD;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x62214F0", Offset = "0x621FEF0", VA = "0x1862214F0")]
	internal BFGKPPAPLAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x27178D0", Offset = "0x27162D0", VA = "0x1827178D0", Slot = "4")]
	public string FCLIDDAPMIL<T>(T COMOOAEHALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2717850", Offset = "0x2716250", VA = "0x182717850", Slot = "5")]
	public T EAKLCKHDOFF<T>(string AEJBOLFACJC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class EMOACKEGMFN : OIHOFHEEIIO
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x280E3F0", Offset = "0x280CDF0", VA = "0x18280E3F0", Slot = "4")]
	public string FCLIDDAPMIL<T>(T COMOOAEHALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x280E390", Offset = "0x280CD90", VA = "0x18280E390", Slot = "5")]
	public T EAKLCKHDOFF<T>(string AEJBOLFACJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public EMOACKEGMFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[JFFHACELPPM]
internal class NFJEICLHJCD : CNKLKJJAGFE<HLJDKLFNOBH, FIBBCEMKLGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly OIHOFHEEIIO AEEMIHKOKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly MELEAMAAHID ODOCDPLLFBN;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6225740", Offset = "0x6224140", VA = "0x186225740")]
	public NFJEICLHJCD(OIHOFHEEIIO AEEMIHKOKPI, MELEAMAAHID ODOCDPLLFBN, KMDJJDLOPBI HILDBFOHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6223B90", Offset = "0x6222590", VA = "0x186223B90", Slot = "6")]
	public override FIBBCEMKLGG HIBHLHEFCGJ(HLJDKLFNOBH KAPFFOPPBJF, [Out] IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6224830", Offset = "0x6223230", VA = "0x186224830")]
	internal void LHHFKNPLFKA(string AKPEBPEBMHI, OFACNJAMAEN EHILAAAAAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6223240", Offset = "0x6221C40", VA = "0x186223240")]
	public IEnumerable<LMHGPJNKIML> CPAGDGIADMA(string KINFEFPCPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6224400", Offset = "0x6222E00", VA = "0x186224400")]
	private IEnumerable<LMHGPJNKIML> JLEAJDNAMJO(string KINFEFPCPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x62252D0", Offset = "0x6223CD0", VA = "0x1862252D0")]
	internal IEnumerable<LMHGPJNKIML> OMIJIHIJOLF(string KINFEFPCPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6224F00", Offset = "0x6223900", VA = "0x186224F00")]
	private LMHGPJNKIML OGOAHNECECL(AvatarOutfitSelectionData KJDOBBDAGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x62232F0", Offset = "0x6221CF0", VA = "0x1862232F0")]
	private void EAHOKDFBHFE(AvatarCustomizationSettingsData LNEDBGMOEON, OFACNJAMAEN EHILAAAAAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6224B90", Offset = "0x6223590", VA = "0x186224B90")]
	private LMHGPJNKIML OGOAHNECECL(string EGDIPGECBPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6224120", Offset = "0x6222B20", VA = "0x186224120")]
	internal static (DCDDAAOOBKB, string, string) IMJLAFGPNOJ(string EGDIPGECBPC, KMDJJDLOPBI HILDBFOHDJH)
	{
		return default((DCDDAAOOBKB, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6224990", Offset = "0x6223390", VA = "0x186224990")]
	private FJIHDFFKLMB? MCABAFKEHIA(string? JHOGCCPFJGM, Vector2 AABFABCMHCJ, float NCDCOCIMMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6223FC0", Offset = "0x62229C0", VA = "0x186223FC0")]
	private static BFLEOALKIFK IEMCNFFIMGE(AvatarCustomizationSettingsData.AnchorParams KNEOCOCJGLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[JFFHACELPPM]
internal class HBONDCDGEGJ : GADDBFILHIB, DLCNKIKPAAO
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6221DC0", Offset = "0x62207C0", VA = "0x186221DC0")]
	public HBONDCDGEGJ(OIHOFHEEIIO AEEMIHKOKPI, MELEAMAAHID ODOCDPLLFBN, KMDJJDLOPBI HILDBFOHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6221650", Offset = "0x6220050", VA = "0x186221650", Slot = "4")]
	public OEKHMIALJBG BOALAEMEPIG(OFACNJAMAEN ABDLEBPKDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6221CC0", Offset = "0x62206C0", VA = "0x186221CC0")]
	private string KDCCEAEHBBG(OFACNJAMAEN EHILAAAAAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6221A00", Offset = "0x6220400", VA = "0x186221A00")]
	private string FDDJOEOHLMD(LMHGPJNKIML PBKOPJCBHOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[JFFHACELPPM]
internal class JADLFAFPGLK : CNKLKJJAGFE<HLJDKLFNOBH, FIBBCEMKLGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly OIHOFHEEIIO AEEMIHKOKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly JFNGHKMKAKC<HLJDKLFNOBH, FIBBCEMKLGG> PCKHDKDMNMF;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6222890", Offset = "0x6221290", VA = "0x186222890")]
	public JADLFAFPGLK(JFNGHKMKAKC<HLJDKLFNOBH, FIBBCEMKLGG> PCKHDKDMNMF, KMDJJDLOPBI HILDBFOHDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6222460", Offset = "0x6220E60", VA = "0x186222460", Slot = "6")]
	public override FIBBCEMKLGG HIBHLHEFCGJ(HLJDKLFNOBH KAPFFOPPBJF, [Out] IReadOnlyList<PLFJENGLHGM>? CLGDKAPAPJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[JFFHACELPPM]
internal class HJOFNCECCEA : KAFGAMOLGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly OIHOFHEEIIO AEEMIHKOKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly DLCNKIKPAAO PKCGPFFJKLN;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6222170", Offset = "0x6220B70", VA = "0x186222170")]
	public HJOFNCECCEA(DLCNKIKPAAO PKCGPFFJKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6221DD0", Offset = "0x62207D0", VA = "0x186221DD0", Slot = "4")]
	public HLJDKLFNOBH BOALAEMEPIG(OFACNJAMAEN ABDLEBPKDKC, int BCBPFMFEAHC, string? GKDOOPOCBPP, string? OLCNPPPDBHP, KCMDKMFGMIO INLJBNBBCKM, List<PLFJENGLHGM>? CLGDKAPAPJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Preserve]
internal class PACNCCMEBOP : MAMEICAOAJG
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static readonly Vector2 GEENNCJMKOB;

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private static readonly Vector2 IPHHLPMIKFP;

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly Vector2 MIAFHBGAKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly Vector2 CCJGOHBJJCN;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static readonly Vector2 HGMGMLPLGLI;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly Vector2 GHKLPCMEHEG;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly Vector2 NCMEGDAJANA;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly Vector2 FAAJODODDDF;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly Vector2 LIPEOPNOFDF;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly Vector2 FGOLHBPLPEO;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly Vector2 OJBPCIMOMJC;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static readonly Vector2 EIPIBJJKHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private Dictionary<HOOKFBKAAPJ, AvatarConfiguration> KIOOKEGFOAB;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6227180", Offset = "0x6225B80", VA = "0x186227180")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.None)]
	private static void PHLODKIBLGJ(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6227550", Offset = "0x6225F50", VA = "0x186227550")]
	[Preserve]
	internal PACNCCMEBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6226060", Offset = "0x6224A60", VA = "0x186226060", Slot = "4")]
	public Vector2 GHOGICGHBBN(FaceFeatureType KIDMEJEMJHF, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6225E20", Offset = "0x6224820", VA = "0x186225E20", Slot = "5")]
	public float DJNDKDENJPA(FaceFeatureType KIDMEJEMJHF, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6226A60", Offset = "0x6225460", VA = "0x186226A60", Slot = "6")]
	public void KKKJAPACEIB(HOOKFBKAAPJ MKFJIMNEHJN, AvatarConfiguration FJJFOHOHMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6226AD0", Offset = "0x62254D0", VA = "0x186226AD0", Slot = "7")]
	public float LDBADMFCHCO(FaceFeatureType BHLNJGBFGEM, float NMJLMNGCOCB, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6226C90", Offset = "0x6225690", VA = "0x186226C90", Slot = "8")]
	public float MPLDIKJCENK(FaceFeatureType BHLNJGBFGEM, float NCDCOCIMMBO, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6226360", Offset = "0x6224D60", VA = "0x186226360", Slot = "10")]
	public Vector2 HLPFKANNAJM(FaceFeatureType BHLNJGBFGEM, Vector2 GNAHAPKPEBH, Vector2 EGHJPEKMLDK, Vector2 PCNGLECLBDO, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6226D50", Offset = "0x6225750", VA = "0x186226D50", Slot = "9")]
	public Vector2 NLHJODOAFKF(FaceFeatureType BHLNJGBFGEM, Vector2 OODCIEHPNID, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6225EA0", Offset = "0x62248A0", VA = "0x186225EA0")]
	private Vector2 FEOJOJKOPBD(FaceFeatureType BHLNJGBFGEM, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6226B40", Offset = "0x6225540", VA = "0x186226B40")]
	private Vector2 LDPODFKMNMJ(FaceFeatureType BHLNJGBFGEM, Vector2 GNAHAPKPEBH, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6226510", Offset = "0x6224F10", VA = "0x186226510", Slot = "11")]
	public Vector2 HPDGICNMBGD(FaceFeatureType BHLNJGBFGEM, Vector2 OODCIEHPNID, Vector2 EGHJPEKMLDK, Vector2 PCNGLECLBDO, HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6226CC0", Offset = "0x62256C0", VA = "0x186226CC0")]
	private float NGJMKOIGMON(float DOOLANFACOC, float AOFEKHADIFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6225B00", Offset = "0x6224500", VA = "0x186225B00")]
	private Vector2 CBAKGKGOMBF(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6227100", Offset = "0x6225B00", VA = "0x186227100")]
	private Vector2 PGBAGGBPPNM(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6227080", Offset = "0x6225A80", VA = "0x186227080")]
	private Vector2 PDAPDOAKFJJ(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6226200", Offset = "0x6224C00", VA = "0x186226200")]
	private Vector2 HEIAMKAGHAD(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6226F80", Offset = "0x6225980", VA = "0x186226F80")]
	private float OAINLPBGIGP(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6226020", Offset = "0x6224A20", VA = "0x186226020")]
	private float GAFIJINOINA(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x62261C0", Offset = "0x6224BC0", VA = "0x1862261C0")]
	private float GKJMGCFGMAJ(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6226B00", Offset = "0x6225500", VA = "0x186226B00")]
	private float LDPJDIKBNCM(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x62268A0", Offset = "0x62252A0", VA = "0x1862268A0")]
	private Vector2 JJFPEMCEFEP(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6226280", Offset = "0x6224C80", VA = "0x186226280")]
	private Vector2 HHBFPAKBNIE(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6226980", Offset = "0x6225380", VA = "0x186226980")]
	private Vector2 KIKAFOOHDMH(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6225C60", Offset = "0x6224660", VA = "0x186225C60")]
	private Vector2 CFEOOADAJDF(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6225940", Offset = "0x6224340", VA = "0x186225940")]
	private Vector2 AOIKDPCENAA(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6225F40", Offset = "0x6224940", VA = "0x186225F40")]
	private Vector2 FNCHKMJJLKN(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6225A20", Offset = "0x6224420", VA = "0x186225A20")]
	private Vector2 BECGNHGKAME(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6225D40", Offset = "0x6224740", VA = "0x186225D40")]
	private Vector2 CMOBCGBCOAA(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6225B80", Offset = "0x6224580", VA = "0x186225B80")]
	private Vector2 CBJANOHFAHJ(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6225880", Offset = "0x6224280", VA = "0x186225880")]
	private Vector2 AIPABAEDIMK(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6227280", Offset = "0x6225C80", VA = "0x186227280")]
	private Vector2 PPGGJAHGIMB(HOOKFBKAAPJ MKFJIMNEHJN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6226FC0", Offset = "0x62259C0", VA = "0x186226FC0")]
	private Vector2 OKLECLMKJHF(HOOKFBKAAPJ MKFJIMNEHJN)
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
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6220670", Offset = "0x621F070", VA = "0x186220670")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class KFDBDBHHAKC
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6222B40", Offset = "0x6221540", VA = "0x186222B40")]
	public static IMADIEACKLJ HIBHLHEFCGJ(this GJIMLFBMGPF ABDLEBPKDKC)
	{
		return default(IMADIEACKLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6222990", Offset = "0x6221390", VA = "0x186222990")]
	public static GJIMLFBMGPF BOALAEMEPIG(this IMADIEACKLJ JGMLMJMIOKF)
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
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4794DD0", Offset = "0x47937D0", VA = "0x184794DD0")]
			public AnchorParams(Vector2 GNAHAPKPEBH, Vector3 GDEMJGPDNEF, Vector3 PPOKIILIAHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x62205C0", Offset = "0x621EFC0", VA = "0x1862205C0")]
			internal BFLEOALKIFK BOALAEMEPIG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private HCNPBJEHGNO useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x6220E90", Offset = "0x621F890", VA = "0x186220E90")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x40C2490", Offset = "0x40C0E90", VA = "0x1840C2490")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xF407B0", Offset = "0xF3F1B0", VA = "0x180F407B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x978B90", Offset = "0x977590", VA = "0x180978B90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x89BDE0", Offset = "0x89A7E0", VA = "0x18089BDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x6220F40", Offset = "0x621F940", VA = "0x186220F40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7C5510", Offset = "0x7C3F10", VA = "0x1807C5510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xC93170", Offset = "0xC91B70", VA = "0x180C93170")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xF2CE10", Offset = "0xF2B810", VA = "0x180F2CE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x7C9AE0", Offset = "0x7C84E0", VA = "0x1807C9AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x6220F80", Offset = "0x621F980", VA = "0x186220F80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1B19680", Offset = "0x1B18080", VA = "0x181B19680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD3BA30", Offset = "0xD3A430", VA = "0x180D3BA30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD37250", Offset = "0xD35C50", VA = "0x180D37250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7C6960", Offset = "0x7C5360", VA = "0x1807C6960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x7C68E0", Offset = "0x7C52E0", VA = "0x1807C68E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3D12950", Offset = "0x3D11350", VA = "0x183D12950")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1B45F50", Offset = "0x1B44950", VA = "0x181B45F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7F8FC0", Offset = "0x7F79C0", VA = "0x1807F8FC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7F9020", Offset = "0x7F7A20", VA = "0x1807F9020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x7CF990", Offset = "0x7CE390", VA = "0x1807CF990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA00", Offset = "0x7CE400", VA = "0x1807CFA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7CF950", Offset = "0x7CE350", VA = "0x1807CF950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA20", Offset = "0x7CE420", VA = "0x1807CFA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA10", Offset = "0x7CE410", VA = "0x1807CFA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7CF970", Offset = "0x7CE370", VA = "0x1807CF970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x91E190", Offset = "0x91CB90", VA = "0x18091E190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9AF5A0", Offset = "0x9ADFA0", VA = "0x1809AF5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x7CF8B0", Offset = "0x7CE2B0", VA = "0x1807CF8B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7CF9A0", Offset = "0x7CE3A0", VA = "0x1807CF9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8AE850", Offset = "0x8AD250", VA = "0x1808AE850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x88B860", Offset = "0x88A260", VA = "0x18088B860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7CD490", Offset = "0x7CBE90", VA = "0x1807CD490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7CD3E0", Offset = "0x7CBDE0", VA = "0x1807CD3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA39B50", Offset = "0xA38550", VA = "0x180A39B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA41A80", Offset = "0xA40480", VA = "0x180A41A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8E7FE0", Offset = "0x8E69E0", VA = "0x1808E7FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xBCB810", Offset = "0xBCA210", VA = "0x180BCB810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public HCNPBJEHGNO UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1BE29B0", Offset = "0x1BE13B0", VA = "0x181BE29B0")]
			get
			{
				return default(HCNPBJEHGNO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1BE3590", Offset = "0x1BE1F90", VA = "0x181BE3590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x936F60", Offset = "0x935960", VA = "0x180936F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x938060", Offset = "0x936A60", VA = "0x180938060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x6220F60", Offset = "0x621F960", VA = "0x186220F60")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6220FA0", Offset = "0x621F9A0", VA = "0x186220FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6220AF0", Offset = "0x621F4F0", VA = "0x186220AF0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public DCDDAAOOBKB BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private OAMGKCPJLHC? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x6220FC0", Offset = "0x621F9C0", VA = "0x186220FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
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
