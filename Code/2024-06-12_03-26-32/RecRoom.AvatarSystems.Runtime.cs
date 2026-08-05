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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67AB710", Offset = "0x67AA310", VA = "0x1867AB710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[KPAMBFFNOBG]
internal class NMBDNDANALJ : FAAFCMNNOIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct MHLIIKIOKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NMBDNDANALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public PHGHBONDFAJ avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LHDBGMDGGGB KCDLNPKAKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BIBHPOHGKNF NKICHLDFGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FHDDNKHICNJ MNFLCANFJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LMNEMHKFMDH IFMFNGCIPOL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67A9D30", Offset = "0x67A8930", VA = "0x1867A9D30")]
	[FJJFAIMPJIC(AMDAGODFNAF.Root, JBEKPLNNIEC.GameOnly)]
	[UsedImplicitly]
	private static void BDPIJDLFOCH(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67AB520", Offset = "0x67AA120", VA = "0x1867AB520")]
	[Preserve]
	internal NMBDNDANALJ([GOICEJLKLIB(null)] LHDBGMDGGGB KCDLNPKAKBL, [GOICEJLKLIB(null)] BIBHPOHGKNF NKICHLDFGHH, [GOICEJLKLIB(null)] FHDDNKHICNJ MNFLCANFJLJ, [GOICEJLKLIB(null)] LMNEMHKFMDH IFMFNGCIPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67AAA90", Offset = "0x67A9690", VA = "0x1867AAA90", Slot = "5")]
	public KHKINBELDHE HJPDHDHGNCL(bool LNAONEPEPIG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67AA0F0", Offset = "0x67A8CF0", VA = "0x1867AA0F0", Slot = "4")]
	public KHKINBELDHE HIOLDMLBEOC(bool LNAONEPEPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67A9FE0", Offset = "0x67A8BE0", VA = "0x1867A9FE0", Slot = "6")]
	public LAMBMCGFGPC GJMNHBPIMOF(KHKINBELDHE IMCLGJBJJKP, int MBCOCMLNCKC, string? GFLNGGKHEOH, string? ADFEIFMKMOO, KKMJODEAJKG NGGLNLGICPK, List<DJGPLGBNDEL>? AIKHGIAMAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67A9BC0", Offset = "0x67A87C0", VA = "0x1867A9BC0", Slot = "7")]
	public bool AFDHBEFEMKP(JPCLLNBNEEM AHMPPPKJMKO, [Out] KHKINBELDHE? NEELLKGBEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67A9C50", Offset = "0x67A8850", VA = "0x1867A9C50", Slot = "8")]
	public bool AHHJBNDONPC(LAMBMCGFGPC KOHFLCKFGPJ, [Out] KHKINBELDHE? NEELLKGBEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67A9DA0", Offset = "0x67A89A0", VA = "0x1867A9DA0", Slot = "9")]
	public bool CCOPAJDHIPE(LAMBMCGFGPC KOHFLCKFGPJ, [Out] HHEBJPOEEJJ? AHMPPPKJMKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1DC0", Offset = "0x2CA09C0", VA = "0x182CA1DC0")]
	private bool EEFKPAEHKJH<TInput, TOutput>(TInput HJNPKADFMMO, LLDBHKLPGFG<TInput, TOutput> CHCNBJNGDFH, [Out] TOutput? JFBAIGMLPKE) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67A9E30", Offset = "0x67A8A30", VA = "0x1867A9E30")]
	[CompilerGenerated]
	private HNDHMGNPIDG ENELIKLGIIK(FaceFeatureType DGLKEMHNODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67AB240", Offset = "0x67A9E40", VA = "0x1867AB240")]
	[CompilerGenerated]
	private HNDHMGNPIDG LAKJMHEKNCP(FaceFeatureType DGLKEMHNODA, MHLIIKIOKMJ P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[KPAMBFFNOBG]
internal class LDFDDEMKAHH : LHDBGMDGGGB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void EPGEICBELOM<in TData>(TData NEELLKGBEDH, IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly FHDDNKHICNJ MNFLCANFJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PDINJOMHAFF GMJFPKILIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EPGEICBELOM<KHKINBELDHE>?[] KCDLNPKAKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly EPGEICBELOM<HHEBJPOEEJJ>?[] IONNGMNMEBL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67A7380", Offset = "0x67A5F80", VA = "0x1867A7380")]
	[FJJFAIMPJIC(AMDAGODFNAF.Root, JBEKPLNNIEC.GameOnly)]
	[UsedImplicitly]
	private static void BDPIJDLFOCH(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67A82C0", Offset = "0x67A6EC0", VA = "0x1867A82C0")]
	[Preserve]
	internal LDFDDEMKAHH([GOICEJLKLIB(null)] FHDDNKHICNJ MNFLCANFJLJ, [GOICEJLKLIB(null)] PDINJOMHAFF GMJFPKILIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67A81C0", Offset = "0x67A6DC0", VA = "0x1867A81C0", Slot = "4")]
	public bool KICKFDPKKOE(KHKINBELDHE NEELLKGBEDH, IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67A8060", Offset = "0x67A6C60", VA = "0x1867A8060", Slot = "5")]
	public bool KICKFDPKKOE(HHEBJPOEEJJ AHMPPPKJMKO, IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67A7620", Offset = "0x67A6220", VA = "0x1867A7620")]
	private void KAALNHHGMMF(KHKINBELDHE NEELLKGBEDH, IReadOnlyList<DJGPLGBNDEL>? KGECOLOELOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67A73F0", Offset = "0x67A5FF0", VA = "0x1867A73F0")]
	private void HHPPLOLBCAP(KHKINBELDHE NEELLKGBEDH, IReadOnlyList<DJGPLGBNDEL>? KGECOLOELOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LHDBGMDGGGB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KICKFDPKKOE(KHKINBELDHE NEELLKGBEDH, IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KICKFDPKKOE(HHEBJPOEEJJ AHMPPPKJMKO, IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarElbowBendHelperController : MonoBehaviour, DBCBOAKCJHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
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
		private Vector3? ELBHDLFHHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool DJDJJAPLFDO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67A0AA0", Offset = "0x679F6A0", VA = "0x1867A0AA0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67A10A0", Offset = "0x679FCA0", VA = "0x1867A10A0", Slot = "4")]
		public void UpdateController(float HHCAAOJDKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A370", Offset = "0xE58F70", VA = "0x180E5A370", Slot = "6")]
		public void SetEnabled(bool GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67A0B40", Offset = "0x679F740", VA = "0x1867A0B40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67A14C0", Offset = "0x67A00C0", VA = "0x1867A14C0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendTargetController : MonoBehaviour, DBCBOAKCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const float FEBKPDAIDDM = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
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
		private Vector3 OKJMELFBHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Vector3 MBNICCBDGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool DJDJJAPLFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float COMAHKPPMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private float BGPLJODMDIN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67A1840", Offset = "0x67A0440", VA = "0x1867A1840", Slot = "4")]
		public void UpdateController(float HHCAAOJDKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB55360", Offset = "0xB53F60", VA = "0x180B55360", Slot = "6")]
		public void SetEnabled(bool GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67A1560", Offset = "0x67A0160", VA = "0x1867A1560")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67A2400", Offset = "0x67A1000", VA = "0x1867A2400")]
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
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x67A2D20", Offset = "0x67A1920", VA = "0x1867A2D20")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67A2CE0", Offset = "0x67A18E0", VA = "0x1867A2CE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67A2430", Offset = "0x67A1030", VA = "0x1867A2430")]
		private void BFHENAKALGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x675DDE0", Offset = "0x675C9E0", VA = "0x18675DDE0", Slot = "4")]
		public void SetEnabled(bool MPKDEMAOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67A2D50", Offset = "0x67A1950", VA = "0x1867A2D50")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarForearmRollController : MonoBehaviour, DBCBOAKCJHM
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
		private bool DJDJJAPLFDO;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67A2D90", Offset = "0x67A1990", VA = "0x1867A2D90", Slot = "4")]
		public void UpdateController(float HHCAAOJDKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x854F90", Offset = "0x853B90", VA = "0x180854F90", Slot = "6")]
		public void SetEnabled(bool GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67A3510", Offset = "0x67A2110", VA = "0x1867A3510")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, IPJGIHMHELG
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
		[HHMHLCBPJEC(LBBGAALIOCK.SelfAndChildren, false, false, false)]
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
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private JOODJDONNFI KLKOFPIOAIO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JOODJDONNFI AHBIPGIPNNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x67A42A0", Offset = "0x67A2EA0", VA = "0x1867A42A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform NBNKENEGEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67A42E0", Offset = "0x67A2EE0", VA = "0x1867A42E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67A3540", Offset = "0x67A2140", VA = "0x1867A3540")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67A4160", Offset = "0x67A2D60", VA = "0x1867A4160")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67A4110", Offset = "0x67A2D10", VA = "0x1867A4110")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67A40A0", Offset = "0x67A2CA0", VA = "0x1867A40A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67A38F0", Offset = "0x67A24F0", VA = "0x1867A38F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67A40A0", Offset = "0x67A2CA0", VA = "0x1867A40A0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67A35C0", Offset = "0x67A21C0", VA = "0x1867A35C0", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67A41B0", Offset = "0x67A2DB0", VA = "0x1867A41B0", Slot = "8")]
		public void UpdatePostIKAnimControllers(float HHCAAOJDKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67A4010", Offset = "0x67A2C10", VA = "0x1867A4010")]
		private void LCJBHGBFPIP(GameObject HAHECKLGOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67A3970", Offset = "0x67A2570", VA = "0x1867A3970")]
		private JOODJDONNFI KDHOPPJLCCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is turned off.")]
			public float AngleOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is fully on.")]
			public float AngleOn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[Tooltip("Normalized height (0-1) where IK is turned off.")]
			public float HeightOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			[Tooltip("Normalized height (0-1) where IK is fully on.")]
			public float HeightOn;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x67ABD70", Offset = "0x67AA970", VA = "0x1867ABD70")]
			public float HINKLNIMFDG(float IMFOPJIGIDP, float KDDKPEMDOBJ)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Time axis is the normalized distance the hand effector currently is from the origin of the upper arm bone.  A time of 0 implies the hand effector is directly on top of the upper arm origin (ie: up at your shoulder), a time = 1, that implies the hand effector is somewhere exactly a full arm's length away, a time of 1.7 implies the hand effector is somewhere exactly 1.7 times the arm's length away.  Value axis is the effector weight from 0 to 1.")]
		[Header("Hand Animation")]
		public AnimationCurve HandEffectorWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Time that the hand animator weight changes from 0 to 1 in a second. When the hand gesture system turns on when making a gesture, and off when the gesture system is idle, this determines the speed that it lerps towards the target weight.")]
		public float HandAnimatorWeightChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("Time it takes to transition to an open or closed hand pose during an animated hand state transition")]
		public float HandOpenCloseChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F5")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Control data for when to allow IK to control the head position for screens players.")]
		[Header("IK Weights")]
		public WeightData ScreenHeadPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Control data for when to allow IK to control the head rotation for screens players.")]
		public WeightData ScreenHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Control data for when to allow IK to control the pelvis position for screens players.")]
		public WeightData ScreenPelvisPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Control data for when to allow IK to control the pelvis rotation for screens players.")]
		public WeightData ScreenPelvisRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("The head is moved flat forward with given amount in VR to match up with our animated head position.")]
		[Header("VR runtime weights")]
		public float StaticHeadForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("The animated root is moved flat forward with given amount in VR to match up the physical feet with our animated feet.")]
		public float StaticRootForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Weight for head while moving. (0 = animated, 1 = VR)")]
		public float MovingHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Weight for head while idle. (0 = animated, 1 = VR)")]
		public float IdleHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Max head height offset compensation")]
		public float MaxHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Min head height offset compensation")]
		public float MinHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("Head height offset compensation smooth time")]
		public float HeadHeightCompensationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("Distance to apply head movement dampening")]
		public float HeadHeightDampeningDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		[Header("Body Twisting")]
		public float VRShoulderTwistBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67A4300", Offset = "0x67A2F00", VA = "0x1867A4300")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BKANKFGDCFN : JNNDDPMPGOI
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int DCPNAONFJFF;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int GEGDMIDMLGJ;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int GHBMNHMBJNP;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static int FAOFMDMCCMD;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static int EGDKFILNCPO;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static int DNKBLLKOCOL;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int HBKIIJKINOL;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int DENOKMCECMB;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static int OKFBIHGMMJL;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static int[] HLGIPICOEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	internal bool MCNGEALEPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private CHEABBJKBHM DGJAIHMIDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private int MGOPFNIEODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private float BDDNOPDCOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool EHPPEBCCKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Animator GCKDCKDBPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private AvatarFullBodyConfiguration JKKMNKPFLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int DFKHKLGCCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int JDNICBGIBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int OPMDPFCHGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool HMDKDDBAODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private HCCLLALHLCD GFLFKFDNKLG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform IINCFDFBGME
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 KIBBJDAGKFN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDB3200", Offset = "0xDB1E00", VA = "0x180DB3200")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDB3250", Offset = "0xDB1E50", VA = "0x180DB3250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion BMPBOOKOBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1B93470", Offset = "0x1B92070", VA = "0x181B93470")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B330", Offset = "0x1F09F30", VA = "0x181F0B330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LLEOMDDHGBI CCPPDLDKFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1255F80", Offset = "0x1254B80", VA = "0x181255F80", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(LLEOMDDHGBI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x12A5020", Offset = "0x12A3C20", VA = "0x1812A5020", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LLEOMDDHGBI DLJNFMNJKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x851570", Offset = "0x850170", VA = "0x180851570", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(LLEOMDDHGBI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x851620", Offset = "0x850220", VA = "0x180851620", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public float MBEFEJHFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x103B640", Offset = "0x103A240", VA = "0x18103B640", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC59560", Offset = "0xC58160", VA = "0x180C59560", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FCONGPHKLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67A6650", Offset = "0x67A5250", VA = "0x1867A6650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool ALKKBDMJAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x67A5E10", Offset = "0x67A4A10", VA = "0x1867A5E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OFPFJOKNFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67A6330", Offset = "0x67A4F30", VA = "0x1867A6330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x67A6100", Offset = "0x67A4D00", VA = "0x1867A6100", Slot = "19")]
	public void EHHLDMLDHNI(CHEABBJKBHM GGJNJHCJHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67A5DF0", Offset = "0x67A49F0", VA = "0x1867A5DF0", Slot = "20")]
	public void AEBFAMAOKCI(LILIKACMDLC HFGNELEKBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67A6660", Offset = "0x67A5260", VA = "0x1867A6660", Slot = "11")]
	public void MKOCJHMPLIM(bool MOAICLIJDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67A5E20", Offset = "0x67A4A20", VA = "0x1867A5E20", Slot = "10")]
	public void EHAJBAGENME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67A64D0", Offset = "0x67A50D0", VA = "0x1867A64D0")]
	private int LLEGLMIBKBO(LLEOMDDHGBI BJIPEBKGPIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67A63A0", Offset = "0x67A4FA0", VA = "0x1867A63A0")]
	private void JAEFCAHMIPF(int DFOONGDPCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67A6700", Offset = "0x67A5300", VA = "0x1867A6700", Slot = "12")]
	public bool OFPHJGKOCBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67A6340", Offset = "0x67A4F40", VA = "0x1867A6340", Slot = "13")]
	public bool HHKFPOCANEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x67A62E0", Offset = "0x67A4EE0", VA = "0x1867A62E0")]
	private LLEOMDDHGBI FHDNDBMECJA()
	{
		return default(LLEOMDDHGBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xEE0280", Offset = "0xEDEE80", VA = "0x180EE0280", Slot = "14")]
	public void CABBGJILBDH(bool MOAICLIJDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x67A66F0", Offset = "0x67A52F0", VA = "0x1867A66F0", Slot = "9")]
	public void OAGPDOCODJF(int DFOONGDPCGA, float EJHNCKBGMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67A62C0", Offset = "0x67A4EC0", VA = "0x1867A62C0", Slot = "7")]
	public void FAMBFNMOBJB(HCCLLALHLCD GJEHPOMDLIP, bool FDMPLBLFINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x67A5E00", Offset = "0x67A4A00", VA = "0x1867A5E00", Slot = "8")]
	public void AGOKOFJIDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x67A6350", Offset = "0x67A4F50", VA = "0x1867A6350", Slot = "15")]
	public void HMBDGDJPNGO(Transform GPMGJNAOOEP, Vector3 JJIFNHGBJHM, Quaternion OJOBOFCMDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67A6A30", Offset = "0x67A5630", VA = "0x1867A6A30")]
	public BKANKFGDCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class AFKDIKHPAID : JOODJDONNFI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class LOJDKPGPLBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float CKLLIHFLLAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Vector3 IOOJPAHNPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool GMLLPLAAFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private float DHPJFJFCDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private bool JEBLDHGCOHN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool FDIJNCAGCPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x67A9240", Offset = "0x67A7E40", VA = "0x1867A9240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x67A8E00", Offset = "0x67A7A00", VA = "0x1867A8E00")]
		public void JGHBHNLEBPI(IKSolverVR.Arm MBPOHBKGAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x67A8570", Offset = "0x67A7170", VA = "0x1867A8570")]
		public void BFKJIJNNKLG(IKSolverVR.Arm MBPOHBKGAON, Transform NJCFDBIGLGG, bool LPMDCLPKFMK, AvatarFullBodyConfiguration BPPGADPMEGH, float BMMEINIHMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x67A8880", Offset = "0x67A7480", VA = "0x1867A8880")]
		public void DHHCOKJNMJO(IKSolverVR.Arm MBPOHBKGAON, bool NHKDICFMPFJ, bool JEBLDHGCOHN, AvatarFullBodyConfiguration BPPGADPMEGH, float BMMEINIHMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x67A8790", Offset = "0x67A7390", VA = "0x1867A8790")]
		private void CNHNFEFKHAI(Transform NJCFDBIGLGG, IKSolverVR.Arm MBPOHBKGAON, float MFOAPLPFNLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x67A91D0", Offset = "0x67A7DD0", VA = "0x1867A91D0")]
		private void KNKMHEECINP(bool LPMDCLPKFMK, AvatarFullBodyConfiguration BPPGADPMEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x67A9140", Offset = "0x67A7D40", VA = "0x1867A9140")]
		private void KEPKPGNKMOJ(AvatarFullBodyConfiguration BPPGADPMEGH, float BMMEINIHMGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x67A8930", Offset = "0x67A7530", VA = "0x1867A8930")]
		private void FCPIGPELOCA(IKSolverVR.Arm MBPOHBKGAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67A8E30", Offset = "0x67A7A30", VA = "0x1867A8E30")]
		public void KAAKLCLJFAP(IKSolverVR.Arm MBPOHBKGAON, Transform OBHOJHFBMMM, Transform HMDLIOCOMJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x67A8970", Offset = "0x67A7570", VA = "0x1867A8970")]
		private (Vector3, Quaternion) FDNNDEECFHL(BKANKFGDCFN MKEEDCPAJMC, Quaternion HJDLJNHNJCO, Vector3 LHCPFFPHJKC)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67A8FF0", Offset = "0x67A7BF0", VA = "0x1867A8FF0")]
		public void KELKBKOPIGO(BKANKFGDCFN MKEEDCPAJMC, IKSolverVR.Arm MBPOHBKGAON, Quaternion HJDLJNHNJCO, Vector3 LHCPFFPHJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67A9260", Offset = "0x67A7E60", VA = "0x1867A9260")]
		public void OMBKAMEFJAN(BKANKFGDCFN MKEEDCPAJMC, IKSolverVR.Arm MBPOHBKGAON, Quaternion HJDLJNHNJCO, Vector3 LHCPFFPHJKC, [In] AvatarFullBodyConfiguration BPPGADPMEGH, [In] AFNNLHFGIKH GJEHPOMDLIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67A9A00", Offset = "0x67A8600", VA = "0x1867A9A00")]
		private static float PNDNGFFBCJA(bool MPKDEMAOPIG, float JEGHDCOJDAN, float PMELLAPBEHE, float OABFAAHBALJ, float BMMEINIHMGD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x67A9850", Offset = "0x67A8450", VA = "0x1867A9850")]
		private static void PIJDEBMPHIE(Transform INENMADDCHB, Transform GDFEHLLCFFB, Transform LCNANOACBAH, float CCGOICIPBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LOJDKPGPLBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private enum GGIDHCEDDBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum MKKPKGJAPFE
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int KJHGIPBDPHP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int BGIOLBPJMMN;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int FDIOCKGFEIC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int FMPGKMAPOEI;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int BKPHHNNIFMB;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int GCFINMPPHCB;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int MDOLAOKBLME;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int KMKGBLPKOMO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int GOPAHLIBDGH;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int JBFMBBJEMDG;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int NBGCFJGNDDM;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int BMHNJHMKNEE;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int FDBBFDFOKIH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int KNLDJFAFMIJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int FDHGMNJIJNI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int FOBBLHIGOJB;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int BMGECEMIENM;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int DHMAJHBBPEB;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int CIKKACMALKA;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int FFAEPNOJPOM;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int FOBKBGDEDFN;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int MMCCLHEPGOA;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int BLGOABKDHIF;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int KHJHCLEEJCH;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int NBAPFEHGIBI;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int OJHPCMJBIHK;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int LIIIMNDBIGM;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int HDECJOONBIB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int PPCAIHKMHAB;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int EFLLBJOOOHG;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly Vector3 AJJMFFLIGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool CMIBOOLAOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool JACOMJPNPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool MPFHGKBNOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool GBJCFNCJCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private bool JCJMGFINCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Vector3 BHPNPGFMOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private ANDALEBLIHI? DGJAIHMIDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private AGBFGICDBPI? BAGFDEIPLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private PEFKMCHIDBK NDFDMINKOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private JKOJGCHGPBC OJJDKHNBPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private BKANKFGDCFN MPIOOPGKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private BKANKFGDCFN IPEHLNENFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool LEHBNKMMBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x221")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool ACPKBGHECFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly OANEKPMHIDJ HMBFOEGOGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly DEPGENALEBH HNIENELPGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int NBIHBHNBCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float DFHLNMODBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GameObject LPJOMHNNAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Transform KJEFKAKGIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Transform KLDJOIGPNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private float DOCLJNGMJOO;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker HEKGBMAEFMI;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker AHCMLJEDDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private ProfilerMarker HHKDJAPGOPB;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ProfilerMarker JDHFAHEGLHD;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ProfilerMarker AEGKBPIMFFC;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly ProfilerMarker GODIHOBNJEA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly List<AFKDIKHPAID> PFDPCPKFOCE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int GEKJHOPIGKC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> AKNFDBCKAJH;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int GJPGAOIHDGA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int IABMDDIEGOD;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static int FOGNAONCLFC;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int BFLDIGHBFCF;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float DJCHEHBFMAP;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static int OFCJHHPJFFE;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float GPDDPIHLLAO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static float MFHAODJEBLA;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static float ONEFJOAAMMF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static float OFLMGIJIBHJ;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static LCGFHFIMJFH JOJKMCFPNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float EOBDFJFLDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool BOGGFPEELFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float GDHLAGDJOKG;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Quaternion DMGGBAGDNEG;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly Quaternion EJBPHJGGDBM;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Vector3 OINHEHABODD;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly Vector3 HJPMEDGGJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private LOJDKPGPLBL JEKOIHANKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private LOJDKPGPLBL ANBIAFJLBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private GGIDHCEDDBP IJHGJKMGLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float PLKDICNBBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly ANKKBICMPDJ GODAKKEBGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float FMDOKAHAGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float LPLBKHKKMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Vector3 IDGJAOENFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HHNPAIILCMI LEIECLKIKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly JEMFPJEBLGH ADPMFLJFKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private float HANDNFJNBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private GGIDHCEDDBP PIEPDOIDCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private Vector3 ABGGMAGPCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float PLEMNILMDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float MHELMPOAOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private ILCODCPBDGI HBHGLIAJNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private HHNPAIILCMI GDDICDCLFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly HHNPAIILCMI BFEJDDAPBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly ILCODCPBDGI HEALAONAMKA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public DEHOLECDIJP PJEBPILBMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DEHOLECDIJP KOCAMCDMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public AvatarConfiguration LJLMIEPKHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6792BE0", Offset = "0x67917E0", VA = "0x186792BE0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AvatarFullBodyConfiguration LFNGPHPLIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x678EDA0", Offset = "0x678D9A0", VA = "0x18678EDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Transform KIBBBDNJMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x678DEF0", Offset = "0x678CAF0", VA = "0x18678DEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Transform NDBGLFODINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6794990", Offset = "0x6793590", VA = "0x186794990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private SkinnedMeshRenderer GBGKLBHHGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x679DAF0", Offset = "0x679C6F0", VA = "0x18679DAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Renderer[] KBOOOGFHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6798900", Offset = "0x6797500", VA = "0x186798900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private GameObject[] JAEJPJGCFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x67918D0", Offset = "0x67904D0", VA = "0x1867918D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Animator LGPCKOANKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6796770", Offset = "0x6795370", VA = "0x186796770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private VRIK PDAHCBFHJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6799790", Offset = "0x6798390", VA = "0x186799790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private DBCBOAKCJHM EBBCKGINNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6795ED0", Offset = "0x6794AD0", VA = "0x186795ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private DBCBOAKCJHM EOLMMHAGJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6793750", Offset = "0x6792350", VA = "0x186793750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private DBCBOAKCJHM NIDCPMGNOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67919B0", Offset = "0x67905B0", VA = "0x1867919B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private DBCBOAKCJHM EFPFGHCLJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6792980", Offset = "0x6791580", VA = "0x186792980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private DBCBOAKCJHM EABJDHIFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x678EC40", Offset = "0x678D840", VA = "0x18678EC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private DBCBOAKCJHM BFBONOOFPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x679B940", Offset = "0x679A540", VA = "0x18679B940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private DBCBOAKCJHM IBALDOLIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x679E0A0", Offset = "0x679CCA0", VA = "0x18679E0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private DBCBOAKCJHM LCIJDFLKKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x678EFD0", Offset = "0x678DBD0", VA = "0x18678EFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public AGBFGICDBPI FHCKCPEJGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x679A9D0", Offset = "0x67995D0", VA = "0x18679A9D0", Slot = "32")]
		get
		{
			return default(AGBFGICDBPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public KGCFGBIOMLM ECDLDCNPKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B39D0", Offset = "0x8B25D0", VA = "0x1808B39D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public OGDFMPCHDJF BFBJAOBOOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8B37E0", Offset = "0x8B23E0", VA = "0x1808B37E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public JNNDDPMPGOI NDPPECHGBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAE3FD0", Offset = "0xAE2BD0", VA = "0x180AE3FD0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JNNDDPMPGOI OBLPJEJNGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAE5AD0", Offset = "0xAE46D0", VA = "0x180AE5AD0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public GameObject OLFFLDPKCIP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x679DA50", Offset = "0x679C650", VA = "0x18679DA50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Transform MOHHBBAHOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x13B6B10", Offset = "0x13B5710", VA = "0x1813B6B10", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Transform OEGLCIGICBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x13B7E30", Offset = "0x13B6A30", VA = "0x1813B7E30", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Vector3 GHHHCGEIMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x679DBD0", Offset = "0x679C7D0", VA = "0x18679DBD0", Slot = "29")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float EJOIOKEPMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6792BB0", Offset = "0x67917B0", VA = "0x186792BB0", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform GPPPEKJIILL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x67922F0", Offset = "0x6790EF0", VA = "0x1867922F0", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool HNHCEIGLOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6798490", Offset = "0x6797090", VA = "0x186798490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool MKJJBAFFJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6799650", Offset = "0x6798250", VA = "0x186799650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x679C490", Offset = "0x679B090", VA = "0x18679C490")]
	private void OHBHCLPIKPF([In] AFNNLHFGIKH NMCMELDPHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6790360", Offset = "0x678EF60", VA = "0x186790360")]
	private void CKILCGMKJIC(AFNNLHFGIKH NMCMELDPHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6792350", Offset = "0x6790F50", VA = "0x186792350")]
	private void EHAJBAGENME(EJEHFCIHAJD BNNFAIHKIOG, JNNDDPMPGOI GDFCGNNHFOG, IKSolverVR.Arm MBPOHBKGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x679BA20", Offset = "0x679A620", VA = "0x18679BA20")]
	private void NOPDPFAHGGL([In] AFNNLHFGIKH GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x679EB70", Offset = "0x679D770", VA = "0x18679EB70")]
	public AFKDIKHPAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67984F0", Offset = "0x67970F0", VA = "0x1867984F0", Slot = "12")]
	public void LALDJECNCKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6793C40", Offset = "0x6792840", VA = "0x186793C40", Slot = "13")]
	public void IBFFJMLEMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67928B0", Offset = "0x67914B0", VA = "0x1867928B0", Slot = "14")]
	public void FNAGNHOPPNO(bool GNJGNFHMCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6799870", Offset = "0x6798470", VA = "0x186799870", Slot = "22")]
	public Transform LMMHPMOFBBE(string LFLHDCPMFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x679AE50", Offset = "0x6799A50", VA = "0x18679AE50", Slot = "23")]
	public Vector3? NJLLHKKLAKF(string LFLHDCPMFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67910F0", Offset = "0x678FCF0", VA = "0x1867910F0", Slot = "7")]
	public void DENONPNJFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6792CC0", Offset = "0x67918C0", VA = "0x186792CC0", Slot = "6")]
	public void GMPNOPHMODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x679DC10", Offset = "0x679C810", VA = "0x18679DC10", Slot = "8")]
	public void PKGJEKEPGKJ(float PLPEBHOMICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6793830", Offset = "0x6792430", VA = "0x186793830")]
	private void IBBANFGMOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6796B70", Offset = "0x6795770", VA = "0x186796B70", Slot = "4")]
	public void KGNJENKFAAI(ANDALEBLIHI NMNNDKPBKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x67989E0", Offset = "0x67975E0", VA = "0x1867989E0", Slot = "5")]
	public void LDOBOCIEIKG(AGBFGICDBPI HFGNELEKBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6799560", Offset = "0x6798160", VA = "0x186799560", Slot = "11")]
	public void LGCGCHEDING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x679A630", Offset = "0x6799230", VA = "0x18679A630", Slot = "21")]
	public void MHMAIAJALCK([Out] Vector3 CCNDJKMHMEB, [Out] Quaternion GAAMKNOKECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6793F30", Offset = "0x6792B30", VA = "0x186793F30")]
	private void IGGNGCJIMJM([In] AFNNLHFGIKH GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x678ED20", Offset = "0x678D920", VA = "0x18678ED20", Slot = "24")]
	public void BELPAPJIFEJ(float MIFIAIBOKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6792800", Offset = "0x6791400", VA = "0x186792800", Slot = "25")]
	public HandLogicOffsets FIEKCGMOOKH()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x679D920", Offset = "0x679C520", VA = "0x18679D920", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets OINFPOKHBFD()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x67996D0", Offset = "0x67982D0", VA = "0x1867996D0")]
	private void LHMNDLPNMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6798080", Offset = "0x6796C80", VA = "0x186798080")]
	private void KONBEGGHKFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6790F70", Offset = "0x678FB70", VA = "0x186790F70")]
	private void CNPHDAAEPLB(OOHKIHMPJNC KJFNFLOILPH, bool AHOFFNDGFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x679BCA0", Offset = "0x679A8A0", VA = "0x18679BCA0")]
	private void ODJHCANAHKG(OOHKIHMPJNC KJFNFLOILPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6798030", Offset = "0x6796C30", VA = "0x186798030")]
	public Vector3 KMHCGEFPPCH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x679D9E0", Offset = "0x679C5E0", VA = "0x18679D9E0")]
	private void OOCIBEIJMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6790410", Offset = "0x678F010", VA = "0x186790410")]
	private void CLIMOPEICDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x678EE30", Offset = "0x678DA30", VA = "0x18678EE30")]
	private float BHPGJNAIIMF([In] AFNNLHFGIKH GJEHPOMDLIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x678DFD0", Offset = "0x678CBD0", VA = "0x18678DFD0")]
	private int APCAPJBHHHG([In] AOIOICAPEPC BLKEPFKDIAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6791DC0", Offset = "0x67909C0", VA = "0x186791DC0")]
	private void EFGPBHPKEEF(AFNNLHFGIKH NMCMELDPHHG, bool DHNBDJDGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6796550", Offset = "0x6795150", VA = "0x186796550")]
	private static void JJPAENEJAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x678E0B0", Offset = "0x678CCB0", VA = "0x18678E0B0")]
	private static void APJIPMMGLDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6792A60", Offset = "0x6791660", VA = "0x186792A60")]
	private float GFPIJHBGPJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6796B40", Offset = "0x6795740", VA = "0x186796B40")]
	private static int KEHHNCDCAMM(AFKDIKHPAID HOGIDEMINCM, AFKDIKHPAID FKJHDCOBNND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6793F60", Offset = "0x6792B60", VA = "0x186793F60")]
	private void IHGBNKPEAGO(AFNNLHFGIKH GJEHPOMDLIP, AvatarFullBodyConfiguration BPPGADPMEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6796A00", Offset = "0x6795600", VA = "0x186796A00")]
	private void KAAKLCLJFAP([In] AFNNLHFGIKH GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x679A0A0", Offset = "0x6798CA0", VA = "0x18679A0A0")]
	private void MEJEPMILCCA([In] AFNNLHFGIKH GJEHPOMDLIP, [In] AvatarFullBodyConfiguration BPPGADPMEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6795090", Offset = "0x6793C90", VA = "0x186795090")]
	private void IMNGKHDMMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x678D5F0", Offset = "0x678C1F0", VA = "0x18678D5F0")]
	private void AAALKMLAEPD([In] AFNNLHFGIKH GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6790CA0", Offset = "0x678F8A0", VA = "0x186790CA0")]
	public void CNFJEHMLJFB(RigidbodyEx NFFOJIEAKIK, IKSolverVR.Arm MBPOHBKGAON, Quaternion HJDLJNHNJCO, Vector3 LHCPFFPHJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6792780", Offset = "0x6791380", VA = "0x186792780")]
	private float EMNABHKAGOO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6794A70", Offset = "0x6793670", VA = "0x186794A70")]
	private void IJIBEDAMBCB([In] AFNNLHFGIKH GJEHPOMDLIP, [In] MKKPKGJAPFE NIDLBCIDCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x679AB00", Offset = "0x6799700", VA = "0x18679AB00")]
	private void NJCDNNDPMED(AFNNLHFGIKH GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6790340", Offset = "0x678EF40", VA = "0x186790340")]
	private void CJCGOKNKMMC(GGIDHCEDDBP LBOMCBMHLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6798E20", Offset = "0x6797A20", VA = "0x186798E20")]
	private void LFHCBANJOLJ(float FHGFMIHMKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x678F4F0", Offset = "0x678E0F0", VA = "0x18678F4F0")]
	private void BOFEJBDBAFK([In] AFNNLHFGIKH GJEHPOMDLIP, MKKPKGJAPFE NIDLBCIDCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x67999C0", Offset = "0x67985C0", VA = "0x1867999C0")]
	private Vector3 MDHEMGJFLOO([In] AFNNLHFGIKH GJEHPOMDLIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x67957E0", Offset = "0x67943E0", VA = "0x1867957E0")]
	private float IPAGLCHLLNF(float MONHMFIDDCI, [In] AFNNLHFGIKH GJEHPOMDLIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x679B130", Offset = "0x6799D30", VA = "0x18679B130")]
	private void NKPKGNJCLLN(GGIDHCEDDBP LBOMCBMHLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x679AFE0", Offset = "0x6799BE0", VA = "0x18679AFE0")]
	private void NKHALIFAAON(float MONHMFIDDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6795FB0", Offset = "0x6794BB0", VA = "0x186795FB0")]
	private void JHNKLMPOOAC([In] AFNNLHFGIKH GJEHPOMDLIP, MKKPKGJAPFE NIDLBCIDCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6790430", Offset = "0x678F030", VA = "0x186790430")]
	private float CMALJCBBBMB([In] AFNNLHFGIKH NMCMELDPHHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6799040", Offset = "0x6797C40", VA = "0x186799040")]
	private void LFNMHGLEAAP(AFNNLHFGIKH GJEHPOMDLIP, MKKPKGJAPFE NIDLBCIDCCB, Vector3 OPGLDNGBDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6796850", Offset = "0x6795450", VA = "0x186796850")]
	private static void JMACCCHDLAC(Transform KHIOEALLADK, Quaternion DELGPMLKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6795BD0", Offset = "0x67947D0", VA = "0x186795BD0")]
	private void IPKEPHJDAEL([In] AFNNLHFGIKH KBMPHALHHKM, [In] AOIOICAPEPC BLKEPFKDIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x678FC40", Offset = "0x678E840", VA = "0x18678FC40")]
	private void BOJIGPBPIMB([In] AFNNLHFGIKH KBMPHALHHKM, [In] AOIOICAPEPC BLKEPFKDIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x679BE30", Offset = "0x679AA30", VA = "0x18679BE30")]
	private void OEFPCELFOKC([In] AFNNLHFGIKH GJEHPOMDLIP, [In] AvatarFullBodyConfiguration BPPGADPMEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x67924E0", Offset = "0x67910E0", VA = "0x1867924E0")]
	public void EMKNHDFKNGC([In] AFNNLHFGIKH GJEHPOMDLIP, [In] AvatarFullBodyConfiguration BPPGADPMEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6795240", Offset = "0x6793E40", VA = "0x186795240", Slot = "33")]
	protected virtual void IOKGAPOJELG([In] AFNNLHFGIKH GJEHPOMDLIP, [In] AvatarFullBodyConfiguration BPPGADPMEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6791A90", Offset = "0x6790690", VA = "0x186791A90")]
	private void DOCGCGIGCEA([In] AFNNLHFGIKH GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6790840", Offset = "0x678F440", VA = "0x186790840")]
	private void CMOLKNGDGKA(float LCHNFLNPGFF, [In] AFNNLHFGIKH NMCMELDPHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x678D860", Offset = "0x678C460", VA = "0x18678D860")]
	private float AJLDGDCPMKK([In] AFNNLHFGIKH NMCMELDPHHG, [In] AvatarFullBodyConfiguration BPPGADPMEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x679DC80", Offset = "0x679C880", VA = "0x18679DC80")]
	private void PLDMPMICNAC([In] AFNNLHFGIKH NMCMELDPHHG, [In] AvatarFullBodyConfiguration BPPGADPMEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6793880", Offset = "0x6792480", VA = "0x186793880")]
	private void IBEHLMOOPLO([In] AFNNLHFGIKH NMCMELDPHHG, float KBPHEGCOKNH, float ELPKFOGMLJG, Vector3 NEIOCKHLEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x679B150", Offset = "0x6799D50", VA = "0x18679B150")]
	private void NNKILGKDAPP(AFNNLHFGIKH NMCMELDPHHG, AvatarFullBodyConfiguration BPPGADPMEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x67917D0", Offset = "0x67903D0", VA = "0x1867917D0")]
	[CompilerGenerated]
	internal static bool DGKMJHFMLME(IKSolverVR.Arm MBPOHBKGAON, GEIIBLKDFCL MOEKKGKEANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x678F0B0", Offset = "0x678DCB0", VA = "0x18678F0B0")]
	[CompilerGenerated]
	internal static float BLOHDKONDCE(Vector3 PJKJBOPFIPP, Vector3 IAGHEFNEGAB, Vector3 MAEBFCJEOEA, AFNNLHFGIKH NMCMELDPHHG, AvatarFullBodyConfiguration BPPGADPMEGH, float MANKJHLJMBO)
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
		public enum CAHEFPKCNED
		{
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private CAHEFPKCNED handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x67A4C10", Offset = "0x67A3810", VA = "0x1867A4C10")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x67A4BD0", Offset = "0x67A37D0", VA = "0x1867A4BD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x67A45A0", Offset = "0x67A31A0", VA = "0x1867A45A0")]
		private void BFHENAKALGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x675DDE0", Offset = "0x675C9E0", VA = "0x18675DDE0", Slot = "4")]
		public void SetEnabled(bool MPKDEMAOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x67A4C40", Offset = "0x67A3840", VA = "0x1867A4C40")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, DBCBOAKCJHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3 OKJMELFBHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Vector3 PBABOIJOHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Vector3 LKJOFCAFIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Matrix4x4 DNKINLLLONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool DJDJJAPLFDO;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x67A50D0", Offset = "0x67A3CD0", VA = "0x1867A50D0", Slot = "4")]
		public void UpdateController(float HHCAAOJDKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x66A7640", Offset = "0x66A6240", VA = "0x1866A7640", Slot = "6")]
		public void SetEnabled(bool GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x67A4C70", Offset = "0x67A3870", VA = "0x1867A4C70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x67A5790", Offset = "0x67A4390", VA = "0x1867A5790")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
internal class ONOCEBLBCJF : CKNDLMKNDEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Dictionary<string, JOODJDONNFI> MJDGGONHEOL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GJDFKCPCLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67ABAD0", Offset = "0x67AA6D0", VA = "0x1867ABAD0")]
	[FJJFAIMPJIC(AMDAGODFNAF.Root, JBEKPLNNIEC.None)]
	private static void OBPCKLILFCM(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x67AB790", Offset = "0x67AA390", VA = "0x1867AB790", Slot = "4")]
	public JOODJDONNFI FNDBBINDDLC(string LCGBGLEHPPO, AvatarSystemConfiguration PBPFIONKOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x67AB950", Offset = "0x67AA550", VA = "0x1867AB950", Slot = "5")]
	public void INGPFMPHDJA(string LCGBGLEHPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x67ABB40", Offset = "0x67AA740", VA = "0x1867ABB40")]
	public ONOCEBLBCJF()
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
		public class FKMOOEFLHCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			private Dictionary<string, Transform> NFMAINGPGBK;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public bool IHNECOIEJHB
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x67A6A40", Offset = "0x67A5640", VA = "0x1867A6A40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x67A6AD0", Offset = "0x67A56D0", VA = "0x1867A6AD0")]
			public void MHMMOEOGCPN(VRIK IJEIAFAGJOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
			public void PMBKGFBGLAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x67A6A80", Offset = "0x67A5680", VA = "0x1867A6A80")]
			public void CJMFGDFICPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x67A6C00", Offset = "0x67A5800", VA = "0x1867A6C00")]
			public FKMOOEFLHCK()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[ENJEIGPOGID(LBBGAALIOCK.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		[HHMHLCBPJEC(LBBGAALIOCK.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly FKMOOEFLHCK FCGHHCMJLCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private IPJGIHMHELG GCAIJCGIDEJ;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x67A57A0", Offset = "0x67A43A0", VA = "0x1867A57A0")]
		private void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x67A5A60", Offset = "0x67A4660", VA = "0x1867A5A60")]
		private bool LCALGHAGCAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x67A5AB0", Offset = "0x67A46B0", VA = "0x1867A5AB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x67A5B20", Offset = "0x67A4720", VA = "0x1867A5B20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x67A5AC0", Offset = "0x67A46C0", VA = "0x1867A5AC0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x67A5D10", Offset = "0x67A4910", VA = "0x1867A5D10")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x67A9A90", Offset = "0x67A8690", VA = "0x1867A9A90", Slot = "4")]
		public override void OnStateEnter(Animator GIAFNOJHGHN, AnimatorStateInfo NCGHJHHJIBO, int NFEKLICMKNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x67A9BB0", Offset = "0x67A87B0", VA = "0x1867A9BB0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal abstract class FEOMMHNHGFO<TInput, TOutput> : LLDBHKLPGFG<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected readonly PDINJOMHAFF GMJFPKILIBB;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3B985C0", Offset = "0x3B971C0", VA = "0x183B985C0")]
	protected FEOMMHNHGFO(PDINJOMHAFF GMJFPKILIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput EGCBEAACMHC(TInput HJNPKADFMMO, [Out] IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B98520", Offset = "0x3B97120", VA = "0x183B98520", Slot = "5")]
	public bool EEFKPAEHKJH(TInput HJNPKADFMMO, [Out] TOutput? JFBAIGMLPKE, [Out] IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[KPAMBFFNOBG]
public static class GBLFLLBJCEM
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly Regex HAFBBCCCIGA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x67A6DE0", Offset = "0x67A59E0", VA = "0x1867A6DE0")]
	public static DFANCAMLMFG LAAJGGDJKOD(LKFMAAICKAG BGKJFLNJDKH, KAECHKCDNJH FLKLHHHEFCH, Guid? HKHHGEIPJJM, Color? GMCFHJCMOPP, BHNAMMMFFGC OIAOOOECAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x67A6FF0", Offset = "0x67A5BF0", VA = "0x1867A6FF0")]
	public static BBAGBHNBMOO NKPPNCNJEID(DFANCAMLMFG IMCLGJBJJKP)
	{
		return default(BBAGBHNBMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B05580", Offset = "0x2B04180", VA = "0x182B05580")]
	internal static TModern? AHBMEFFHCLI<TModern>(string? HJNPKADFMMO, JKMOIHHGHAC<TModern> KLOCLKKIJOG, PDINJOMHAFF GMJFPKILIBB, OEABMHIFFJM EHHIGMINFCK, TModern NODEIMCMPEI) where TModern : struct, JJAKLHDPBME
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2B07A70", Offset = "0x2B06670", VA = "0x182B07A70")]
	internal static IGBKPIKGINI PAHIHNHJPBD<TModern>(string? HJNPKADFMMO, JKMOIHHGHAC<TModern> KLOCLKKIJOG, PDINJOMHAFF GMJFPKILIBB, OEABMHIFFJM EHHIGMINFCK, TModern NODEIMCMPEI) where TModern : struct, JJAKLHDPBME
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x67A6C90", Offset = "0x67A5890", VA = "0x1867A6C90")]
	internal static List<DJGPLGBNDEL> FDNGEIKEPDJ(IEnumerable<AGEIADJDEGF>? PCDJAMBBEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B06BD0", Offset = "0x2B057D0", VA = "0x182B06BD0")]
	internal static string BANDAAHCHML<TModern>(TModern HJNPKADFMMO, JKMOIHHGHAC<TModern> KLOCLKKIJOG, PDINJOMHAFF GMJFPKILIBB) where TModern : JJAKLHDPBME
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class HNEIIFGNAPF : BIBHPOHGKNF
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LLDBHKLPGFG<JPCLLNBNEEM, KHKINBELDHE> PKHCGEBELAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LLDBHKLPGFG<LAMBMCGFGPC, HHEBJPOEEJJ> KNGOPIAIMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LLDBHKLPGFG<LAMBMCGFGPC, HHEBJPOEEJJ> FLIFIPOHPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FGFLIKMAHLM DJNBKECIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JCGINMIIMLM FJCDOAODPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x67A7140", Offset = "0x67A5D40", VA = "0x1867A7140")]
	[FJJFAIMPJIC(AMDAGODFNAF.Root, JBEKPLNNIEC.GameOnly)]
	[UsedImplicitly]
	private static void BDPIJDLFOCH(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x67A71B0", Offset = "0x67A5DB0", VA = "0x1867A71B0")]
	[Preserve]
	internal HNEIIFGNAPF([GOICEJLKLIB("UnitySerialization")] MGGLHIMFGHK FFPMEDOBENJ, [GOICEJLKLIB(null)] IFBHIOFCNNP CAEAAMIBODB, [GOICEJLKLIB(null)] PDINJOMHAFF GMJFPKILIBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum HIKGNCMJPBE
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
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AAIHFOOFFMF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x678D580", Offset = "0x678C180", VA = "0x18678D580")]
	public AAIHFOOFFMF(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x678D520", Offset = "0x678C120", VA = "0x18678D520")]
	public AAIHFOOFFMF(string JIMAFLGJGFB, Exception OPBDCLKCGHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x678D550", Offset = "0x678C150", VA = "0x18678D550")]
	public AAIHFOOFFMF(HIKGNCMJPBE FMEADDKOFED, string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x678D5B0", Offset = "0x678C1B0", VA = "0x18678D5B0")]
	public AAIHFOOFFMF(HIKGNCMJPBE FMEADDKOFED, string JIMAFLGJGFB, Exception OPBDCLKCGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class AGCFMINOMOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly MGGLHIMFGHK FFPMEDOBENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly IFBHIOFCNNP CAEAAMIBODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly PDINJOMHAFF GMJFPKILIBB;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x67A0920", Offset = "0x679F520", VA = "0x1867A0920")]
	protected AGCFMINOMOI(MGGLHIMFGHK FFPMEDOBENJ, IFBHIOFCNNP CAEAAMIBODB, PDINJOMHAFF GMJFPKILIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x679EF70", Offset = "0x679DB70", VA = "0x18679EF70")]
	protected string ADMCEAFKCGA(KHKINBELDHE NEELLKGBEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x67A03D0", Offset = "0x679EFD0", VA = "0x1867A03D0")]
	protected string HLPHPFPDAAB(KHKINBELDHE NEELLKGBEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x67A05B0", Offset = "0x679F1B0", VA = "0x1867A05B0")]
	private AvatarOutfitSelectionData LAAJGGDJKOD(DFANCAMLMFG LHFDOAPNMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x67A0290", Offset = "0x679EE90", VA = "0x1867A0290")]
	private static AvatarCustomizationSettingsData.AnchorParams GCFCAMHMDFE(POPGKCADAAO? ECEOHADMEOG)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LLDBHKLPGFG<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput EGCBEAACMHC(TInput HJNPKADFMMO, [Out] IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEFKPAEHKJH(TInput HJNPKADFMMO, [Out] TOutput? JFBAIGMLPKE, [Out] IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BIBHPOHGKNF
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LLDBHKLPGFG<JPCLLNBNEEM, KHKINBELDHE> PKHCGEBELAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LLDBHKLPGFG<LAMBMCGFGPC, HHEBJPOEEJJ> FLIFIPOHPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	FGFLIKMAHLM DJNBKECIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal enum OEABMHIFFJM
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JCGINMIIMLM
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKCIGPJMCPP PLFEAILJDFE(KHKINBELDHE IMCLGJBJJKP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FGFLIKMAHLM
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LAMBMCGFGPC PLFEAILJDFE(KHKINBELDHE IMCLGJBJJKP, int MBCOCMLNCKC, string? GFLNGGKHEOH, string? ADFEIFMKMOO, KKMJODEAJKG NGGLNLGICPK, List<DJGPLGBNDEL>? AIKHGIAMAMP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[KPAMBFFNOBG]
internal class LFDLLKGDKJF : FEOMMHNHGFO<JPCLLNBNEEM, KHKINBELDHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly IFBHIOFCNNP CAEAAMIBODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly KLAEKFFEIMM DOBKLJLJCEM;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x67B0010", Offset = "0x67AEC10", VA = "0x1867B0010")]
	public LFDLLKGDKJF(MGGLHIMFGHK FFPMEDOBENJ, IFBHIOFCNNP CAEAAMIBODB, PDINJOMHAFF GMJFPKILIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67AFD60", Offset = "0x67AE960", VA = "0x1867AFD60", Slot = "6")]
	public override KHKINBELDHE EGCBEAACMHC(JPCLLNBNEEM HJNPKADFMMO, [Out] IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Preserve]
internal class JOPFLEICCGM : MGGLHIMFGHK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class FCFECJNOCAH : JsonConverter<IGBKPIKGINI>
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x67AD0C0", Offset = "0x67ABCC0", VA = "0x1867AD0C0", Slot = "9")]
		public override void WriteJson(JsonWriter AKHHKFNOJLO, IGBKPIKGINI? GLMEMJNJKAN, JsonSerializer FFABADEFODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x67ACFA0", Offset = "0x67ABBA0", VA = "0x1867ACFA0", Slot = "10")]
		public override IGBKPIKGINI ReadJson(JsonReader GGPHPLOPODB, Type KBKALMJCJAE, IGBKPIKGINI? JJMOFPIKBAB, bool JMCHNEBINCA, JsonSerializer FFABADEFODC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x67AD160", Offset = "0x67ABD60", VA = "0x1867AD160")]
		public FCFECJNOCAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class PABMOKLGEMD : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool ECGEIHINGBF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x67B2330", Offset = "0x67B0F30", VA = "0x1867B2330", Slot = "5")]
		public override object ReadJson(JsonReader GGPHPLOPODB, Type KBKALMJCJAE, object? JJMOFPIKBAB, JsonSerializer FFABADEFODC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x67B2150", Offset = "0x67B0D50", VA = "0x1867B2150", Slot = "6")]
		public override bool CanConvert(Type KBKALMJCJAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x67B2390", Offset = "0x67B0F90", VA = "0x1867B2390", Slot = "4")]
		public override void WriteJson(JsonWriter AKHHKFNOJLO, object? GLMEMJNJKAN, JsonSerializer FFABADEFODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x67B1F50", Offset = "0x67B0B50", VA = "0x1867B1F50")]
		private static bool AFNBCANIMEE(object GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public PABMOKLGEMD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly JsonSerializerSettings LEEINMKPJFE;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67AD5D0", Offset = "0x67AC1D0", VA = "0x1867AD5D0")]
	internal JOPFLEICCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0E90", Offset = "0x2B9FA90", VA = "0x182BA0E90", Slot = "4")]
	public string LGCGHINOFKG<T>(T HAHECKLGOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0E00", Offset = "0x2B9FA00", VA = "0x182BA0E00", Slot = "5")]
	public T EJKAANOGHHE<T>(string GLMEMJNJKAN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class IBMJCHPFALL : MGGLHIMFGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CAF0", Offset = "0x2B2B6F0", VA = "0x182B2CAF0", Slot = "4")]
	public string LGCGHINOFKG<T>(T HAHECKLGOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CA70", Offset = "0x2B2B670", VA = "0x182B2CA70", Slot = "5")]
	public T EJKAANOGHHE<T>(string GLMEMJNJKAN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public IBMJCHPFALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[KPAMBFFNOBG]
internal class KLAEKFFEIMM : FEOMMHNHGFO<LAMBMCGFGPC, HHEBJPOEEJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly MGGLHIMFGHK FFPMEDOBENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly IFBHIOFCNNP CAEAAMIBODB;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x67AFC20", Offset = "0x67AE820", VA = "0x1867AFC20")]
	public KLAEKFFEIMM(MGGLHIMFGHK FFPMEDOBENJ, IFBHIOFCNNP CAEAAMIBODB, PDINJOMHAFF GMJFPKILIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x67AD930", Offset = "0x67AC530", VA = "0x1867AD930", Slot = "6")]
	public override HHEBJPOEEJJ EGCBEAACMHC(LAMBMCGFGPC HJNPKADFMMO, [Out] IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x67AE1D0", Offset = "0x67ACDD0", VA = "0x1867AE1D0")]
	internal void IBBCLJPOCIL(string KBEKNEFAMKH, KHKINBELDHE NEELLKGBEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x67AF890", Offset = "0x67AE490", VA = "0x1867AF890")]
	public IEnumerable<DFANCAMLMFG> MJDPAIEBILA(string KNNMNCMNDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67AEBC0", Offset = "0x67AD7C0", VA = "0x1867AEBC0")]
	private IEnumerable<DFANCAMLMFG> KCNKJDPAMFK(string KNNMNCMNDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x67ADD60", Offset = "0x67AC960", VA = "0x1867ADD60")]
	internal IEnumerable<DFANCAMLMFG> GFPDEDJOHBH(string KNNMNCMNDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x67AF360", Offset = "0x67ADF60", VA = "0x1867AF360")]
	private DFANCAMLMFG MFMMKDOFLNK(AvatarOutfitSelectionData BNKCFKBPBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x67AE320", Offset = "0x67ACF20", VA = "0x1867AE320")]
	private void IBNDGJIGCFK(AvatarCustomizationSettingsData CLPGPHAIPHG, KHKINBELDHE NEELLKGBEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67AEFF0", Offset = "0x67ADBF0", VA = "0x1867AEFF0")]
	private DFANCAMLMFG MFMMKDOFLNK(string GDCGFFKEPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x67AF940", Offset = "0x67AE540", VA = "0x1867AF940")]
	internal static (BHNAMMMFFGC, string, string) PHDMFFIPPDJ(string GDCGFFKEPOK, PDINJOMHAFF GMJFPKILIBB)
	{
		return default((BHNAMMMFFGC, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x67AD730", Offset = "0x67AC330", VA = "0x1867AD730")]
	private HNDHMGNPIDG? DBGHGPOBEEF(string? CICFLOBNFHG, Vector2 JJIFNHGBJHM, float GMGNMIKDEIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x67AF730", Offset = "0x67AE330", VA = "0x1867AF730")]
	private static POPGKCADAAO MHNEOABCNJM(AvatarCustomizationSettingsData.AnchorParams CCOMIIGGPIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[KPAMBFFNOBG]
internal class BKDFMIJCJGK : AGCFMINOMOI, JCGINMIIMLM
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x67ACF90", Offset = "0x67ABB90", VA = "0x1867ACF90")]
	public BKDFMIJCJGK(MGGLHIMFGHK FFPMEDOBENJ, IFBHIOFCNNP CAEAAMIBODB, PDINJOMHAFF GMJFPKILIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x67ACBE0", Offset = "0x67AB7E0", VA = "0x1867ACBE0", Slot = "4")]
	public NKCIGPJMCPP PLFEAILJDFE(KHKINBELDHE IMCLGJBJJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x67AC820", Offset = "0x67AB420", VA = "0x1867AC820")]
	private string DDJCGOBKMJL(KHKINBELDHE NEELLKGBEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x67AC920", Offset = "0x67AB520", VA = "0x1867AC920")]
	private string MIECMIEHNBH(DFANCAMLMFG LHFDOAPNMIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KPAMBFFNOBG]
internal class PCPMHDJBMDF : FEOMMHNHGFO<LAMBMCGFGPC, HHEBJPOEEJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly MGGLHIMFGHK FFPMEDOBENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly LLDBHKLPGFG<LAMBMCGFGPC, HHEBJPOEEJJ> PDKDGOLEOMO;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x67B28A0", Offset = "0x67B14A0", VA = "0x1867B28A0")]
	public PCPMHDJBMDF(LLDBHKLPGFG<LAMBMCGFGPC, HHEBJPOEEJJ> PDKDGOLEOMO, PDINJOMHAFF GMJFPKILIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x67B2470", Offset = "0x67B1070", VA = "0x1867B2470", Slot = "6")]
	public override HHEBJPOEEJJ EGCBEAACMHC(LAMBMCGFGPC HJNPKADFMMO, [Out] IReadOnlyList<DJGPLGBNDEL>? AIKHGIAMAMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KPAMBFFNOBG]
internal class POFNGHAIJMG : FGFLIKMAHLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly MGGLHIMFGHK FFPMEDOBENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly JCGINMIIMLM ACPINPONCKM;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x67B2D40", Offset = "0x67B1940", VA = "0x1867B2D40")]
	public POFNGHAIJMG(JCGINMIIMLM ACPINPONCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x67B29A0", Offset = "0x67B15A0", VA = "0x1867B29A0", Slot = "4")]
	public LAMBMCGFGPC PLFEAILJDFE(KHKINBELDHE IMCLGJBJJKP, int MBCOCMLNCKC, string? GFLNGGKHEOH, string? ADFEIFMKMOO, KKMJODEAJKG NGGLNLGICPK, List<DJGPLGBNDEL>? AIKHGIAMAMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Preserve]
internal class NLHLIONOOOA : LMNEMHKFMDH
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly Vector2 NOFKOFPADKO;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly Vector2 BDKNKDKIPEN;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static readonly Vector2 CNJGMEBFKCB;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly Vector2 JOPLEGFGDLL;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly Vector2 OAEIODOHBPM;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly Vector2 NPJGDFMBFNA;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly Vector2 OHKFAJKKFHF;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly Vector2 GDHOMBMMPLK;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly Vector2 PCBIEAADIDB;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static readonly Vector2 AIKKIFCCNKL;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static readonly Vector2 LMILOFOHOPE;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly Vector2 EFMHHBDMMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private Dictionary<PHGHBONDFAJ, AvatarConfiguration> MANCCKDICEC;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x67B01E0", Offset = "0x67AEDE0", VA = "0x1867B01E0")]
	[FJJFAIMPJIC(AMDAGODFNAF.Root, JBEKPLNNIEC.None)]
	private static void AEHLFOFDHHE(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x67B1EA0", Offset = "0x67B0AA0", VA = "0x1867B1EA0")]
	[Preserve]
	internal NLHLIONOOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x67B0420", Offset = "0x67AF020", VA = "0x1867B0420", Slot = "4")]
	public Vector2 BGEPJMDLKNH(FaceFeatureType DGLKEMHNODA, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x67B0660", Offset = "0x67AF260", VA = "0x1867B0660", Slot = "5")]
	public float BHGFOELMIPJ(FaceFeatureType DGLKEMHNODA, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x67B02D0", Offset = "0x67AEED0", VA = "0x1867B02D0", Slot = "6")]
	public void AIDAPMKHNKE(PHGHBONDFAJ BNOOPHIBANK, AvatarConfiguration PBPFIONKOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x67B06E0", Offset = "0x67AF2E0", VA = "0x1867B06E0", Slot = "7")]
	public float BMPOPHGALBI(FaceFeatureType HBFBJIHKKNO, float MBBNFKOPDBP, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x67B1170", Offset = "0x67AFD70", VA = "0x1867B1170", Slot = "8")]
	public float JCNOCLEKCLO(FaceFeatureType HBFBJIHKKNO, float GMGNMIKDEIG, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x67B11A0", Offset = "0x67AFDA0", VA = "0x1867B11A0", Slot = "10")]
	public Vector2 JFKIGJABLKF(FaceFeatureType HBFBJIHKKNO, Vector2 OMNDJDEHBKM, Vector2 JELONFHPIIK, Vector2 OKKJLHBHJFF, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x67B0930", Offset = "0x67AF530", VA = "0x1867B0930", Slot = "9")]
	public Vector2 EOPGICOOPPE(FaceFeatureType HBFBJIHKKNO, Vector2 KALBBOPGHPI, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x67B1890", Offset = "0x67B0490", VA = "0x1867B1890")]
	private Vector2 NHEFMNGOFFP(FaceFeatureType HBFBJIHKKNO, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x67B1500", Offset = "0x67B0100", VA = "0x1867B1500")]
	private Vector2 LFOJMOJOOKM(FaceFeatureType HBFBJIHKKNO, Vector2 OMNDJDEHBKM, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x67B0B60", Offset = "0x67AF760", VA = "0x1867B0B60", Slot = "11")]
	public Vector2 GBILCPFHNLA(FaceFeatureType HBFBJIHKKNO, Vector2 KALBBOPGHPI, Vector2 JELONFHPIIK, Vector2 OKKJLHBHJFF, PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x67B1390", Offset = "0x67AFF90", VA = "0x1867B1390")]
	private float KHBLMAJAOJC(float KFFFFOIIONO, float EJBCANAPLDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x67B1710", Offset = "0x67B0310", VA = "0x1867B1710")]
	private Vector2 LLOPILLFOAO(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x67B0FD0", Offset = "0x67AFBD0", VA = "0x1867B0FD0")]
	private Vector2 HOALLOBOAPJ(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67B1810", Offset = "0x67B0410", VA = "0x1867B1810")]
	private Vector2 NDOKEIAKBCE(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x67B1790", Offset = "0x67B0390", VA = "0x1867B1790")]
	private Vector2 MCMJDAPPBPP(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x67B1350", Offset = "0x67AFF50", VA = "0x1867B1350")]
	private float JJFHOBHFOKG(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x67B0710", Offset = "0x67AF310", VA = "0x1867B0710")]
	private float CLIPGNBNCGO(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x67B0750", Offset = "0x67AF350", VA = "0x1867B0750")]
	private float DGGKIBILNJH(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x67B1130", Offset = "0x67AFD30", VA = "0x1867B1130")]
	private float IKJCJPJNNAK(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x67B0850", Offset = "0x67AF450", VA = "0x1867B0850")]
	private Vector2 DLCDILMHEIG(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x67B0EF0", Offset = "0x67AFAF0", VA = "0x1867B0EF0")]
	private Vector2 HLPMOHFICPM(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x67B1050", Offset = "0x67AFC50", VA = "0x1867B1050")]
	private Vector2 IIHIGOLLDMJ(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x67B0580", Offset = "0x67AF180", VA = "0x1867B0580")]
	private Vector2 BGHDHFFGGPL(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x67B19F0", Offset = "0x67B05F0", VA = "0x1867B19F0")]
	private Vector2 OBLNPPHMHCJ(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x67B1AD0", Offset = "0x67B06D0", VA = "0x1867B1AD0")]
	private Vector2 ONOBHMPOPKA(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x67B1420", Offset = "0x67B0020", VA = "0x1867B1420")]
	private Vector2 KLKLONIOMMI(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x67B1BB0", Offset = "0x67B07B0", VA = "0x1867B1BB0")]
	private Vector2 PIEEGMJKHJD(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x67B0340", Offset = "0x67AEF40", VA = "0x1867B0340")]
	private Vector2 AMOFLJJDAIM(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67B0790", Offset = "0x67AF390", VA = "0x1867B0790")]
	private Vector2 DHGLIEMKEDE(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67B1930", Offset = "0x67B0530", VA = "0x1867B1930")]
	private Vector2 NJLKIMGDOMG(PHGHBONDFAJ BNOOPHIBANK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67B1650", Offset = "0x67B0250", VA = "0x1867B1650")]
	private Vector2 LKMIDEOPKOD(PHGHBONDFAJ BNOOPHIBANK)
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
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x67ABEA0", Offset = "0x67AAAA0", VA = "0x1867ABEA0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GPHMANOOJFI
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x67AD1A0", Offset = "0x67ABDA0", VA = "0x1867AD1A0")]
	public static BBAGBHNBMOO EGCBEAACMHC(this AKHAFOFNJPC IMCLGJBJJKP)
	{
		return default(BBAGBHNBMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x67AD420", Offset = "0x67AC020", VA = "0x1867AD420")]
	public static AKHAFOFNJPC PLFEAILJDFE(this BBAGBHNBMOO KDCKJDHJJMA)
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
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x4C5D340", Offset = "0x4C5BF40", VA = "0x184C5D340")]
			public AnchorParams(Vector2 OMNDJDEHBKM, Vector3 DCGPCGKMAGD, Vector3 PJBOJGIPEHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x67ABDF0", Offset = "0x67AA9F0", VA = "0x1867ABDF0")]
			internal POPGKCADAAO PLFEAILJDFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private AGPEOLJGKML useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x67AC6C0", Offset = "0x67AB2C0", VA = "0x1867AC6C0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3802940", Offset = "0x3801540", VA = "0x183802940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x105B610", Offset = "0x105A210", VA = "0x18105B610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x8B3200", Offset = "0x8B1E00", VA = "0x1808B3200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9C3370", Offset = "0x9C1F70", VA = "0x1809C3370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x67AC770", Offset = "0x67AB370", VA = "0x1867AC770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x84B8E0", Offset = "0x84A4E0", VA = "0x18084B8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8B31B0", Offset = "0x8B1DB0", VA = "0x1808B31B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x106AEC0", Offset = "0x1069AC0", VA = "0x18106AEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x843390", Offset = "0x841F90", VA = "0x180843390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x67AC7B0", Offset = "0x67AB3B0", VA = "0x1867AC7B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1C6C940", Offset = "0x1C6B540", VA = "0x181C6C940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8B38A0", Offset = "0x8B24A0", VA = "0x1808B38A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xE78490", Offset = "0xE77090", VA = "0x180E78490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x848BE0", Offset = "0x8477E0", VA = "0x180848BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x848BF0", Offset = "0x8477F0", VA = "0x180848BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x40FFC00", Offset = "0x40FE800", VA = "0x1840FFC00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1C98BD0", Offset = "0x1C977D0", VA = "0x181C98BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x879EE0", Offset = "0x878AE0", VA = "0x180879EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x879F40", Offset = "0x878B40", VA = "0x180879F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850100", VA = "0x180851500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8514A0", Offset = "0x8500A0", VA = "0x1808514A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8501F0", VA = "0x1808515F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x851580", Offset = "0x850180", VA = "0x180851580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8514C0", Offset = "0x8500C0", VA = "0x1808514C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x851530", Offset = "0x850130", VA = "0x180851530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA59020", Offset = "0xA57C20", VA = "0x180A59020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xACE080", Offset = "0xACCC80", VA = "0x180ACE080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8515A0", Offset = "0x8501A0", VA = "0x1808515A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x851550", Offset = "0x850150", VA = "0x180851550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AEDE0", VA = "0x1809B01E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9B0300", Offset = "0x9AEF00", VA = "0x1809B0300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x850760", Offset = "0x84F360", VA = "0x180850760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x850740", Offset = "0x84F340", VA = "0x180850740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB796A0", Offset = "0xB782A0", VA = "0x180B796A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB81680", Offset = "0xB80280", VA = "0x180B81680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA257D0", Offset = "0xA243D0", VA = "0x180A257D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xD0C010", Offset = "0xD0AC10", VA = "0x180D0C010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public AGPEOLJGKML UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x1D37AB0", Offset = "0x1D366B0", VA = "0x181D37AB0")]
			get
			{
				return default(AGPEOLJGKML);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x1D38330", Offset = "0x1D36F30", VA = "0x181D38330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA72070", Offset = "0xA70C70", VA = "0x180A72070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA72080", Offset = "0xA70C80", VA = "0x180A72080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x67AC790", Offset = "0x67AB390", VA = "0x1867AC790")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x67AC7D0", Offset = "0x67AB3D0", VA = "0x1867AC7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x67AC320", Offset = "0x67AAF20", VA = "0x1867AC320")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public BHNAMMMFFGC BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private DPGGOBMNMNN? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x67AC7F0", Offset = "0x67AB3F0", VA = "0x1867AC7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
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
