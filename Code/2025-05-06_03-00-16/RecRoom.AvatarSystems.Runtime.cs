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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E46D0", Offset = "0x79E2ED0", VA = "0x1879E46D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E4750", Offset = "0x79E2F50", VA = "0x1879E4750", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DBBJMDENMLB]
internal class IPEBCABOFHG : DHMIBPJAJMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DOHILBOMDFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public IPEBCABOFHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public DODMAGIBHBA avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly ENGBPOHEKEM HFELHAOANAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MGANAECMDED JBEDNMGELIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HBHFGIBIHMH NFDMAMAOHAC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x79C8750", Offset = "0x79C6F50", VA = "0x1879C8750")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	[UsedImplicitly]
	internal static void PIPANJBNOEI(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x79C87C0", Offset = "0x79C6FC0", VA = "0x1879C87C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IPEBCABOFHG([LDAFGEHKDJK(null)] ENGBPOHEKEM HFELHAOANAF, [LDAFGEHKDJK(null)] MGANAECMDED JBEDNMGELIE, [LDAFGEHKDJK(null)] HBHFGIBIHMH NFDMAMAOHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79C6CE0", Offset = "0x79C54E0", VA = "0x1879C6CE0", Slot = "5")]
	public AHOGOONMGAK CIEEPMNBOEA(DODMAGIBHBA CLLFKOMCOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79C7A20", Offset = "0x79C6220", VA = "0x1879C7A20", Slot = "4")]
	public AHOGOONMGAK MPALPDJJILI(DODMAGIBHBA CLLFKOMCOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79C8520", Offset = "0x79C6D20", VA = "0x1879C8520", Slot = "6")]
	public BOIHPHGPMPK NAPPCPHPLIJ(AHOGOONMGAK NFNBKNAJBPN, int OPKLODOCMCI, string? GLGOHIJMLFB, string? HEBADMBACHN, IDBDBALOLAF BABAPBFHKIC, List<FCKBIMABIOA>? GHKFMKIMMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x79C8630", Offset = "0x79C6E30", VA = "0x1879C8630", Slot = "7")]
	public bool NOCPDMIOOBG(KCDOILINLPA OFJCDBCHAMF, [Out] AHOGOONMGAK? BAEHAEFCNBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79C7940", Offset = "0x79C6140", VA = "0x1879C7940", Slot = "8")]
	public bool JGKOEDBIHKN(BOIHPHGPMPK FOKBKJJKLMG, [Out] AHOGOONMGAK? BAEHAEFCNBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x79C86C0", Offset = "0x79C6EC0", VA = "0x1879C86C0", Slot = "9")]
	public bool OLJCDALEIMI(BOIHPHGPMPK FOKBKJJKLMG, [Out] GONFFIMNHAP? OFJCDBCHAMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x37F4B00", Offset = "0x37F3300", VA = "0x1837F4B00")]
	private bool EKBFNBCAIML<TInput, TOutput>(TInput JEOEDPICHHI, ABFFOHELAGI<TInput, TOutput> DNIOCGKONNB, [Out] TOutput? HLPIAOANGMD) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79C7790", Offset = "0x79C5F90", VA = "0x1879C7790")]
	[CompilerGenerated]
	private JKHHFLAMEIB GEMBDMKEOHB(FaceFeatureType GJOMIGIHMND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79C75B0", Offset = "0x79C5DB0", VA = "0x1879C75B0")]
	[CompilerGenerated]
	private JKHHFLAMEIB ENCIDLHPDLC(FaceFeatureType GJOMIGIHMND, DOHILBOMDFJ P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DBBJMDENMLB]
internal class MLGGMCKLAGO : ENGBPOHEKEM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DEBBEKBHIJI<in TData>(TData BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HHMNJPCGCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public IOPOMOOJGAE rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public PBBOLHBJGGN currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public PBBOLHBJGGN latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HHMNJPCGCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x79C6C40", Offset = "0x79C5440", VA = "0x1879C6C40")]
		internal bool MDOBLIDGELM(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x79C6C60", Offset = "0x79C5460", VA = "0x1879C6C60")]
		internal bool OGFFOBBJGCF(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HBHFGIBIHMH NFDMAMAOHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MKCGLADJFFJ MLNADBAMFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DEBBEKBHIJI<AHOGOONMGAK>?[] HFELHAOANAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DEBBEKBHIJI<GONFFIMNHAP>?[] IHJGAEPIOGA;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79E3F50", Offset = "0x79E2750", VA = "0x1879E3F50")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	[UsedImplicitly]
	internal static void PIPANJBNOEI(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79E4070", Offset = "0x79E2870", VA = "0x1879E4070")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MLGGMCKLAGO([LDAFGEHKDJK(null)] HBHFGIBIHMH NFDMAMAOHAC, [LDAFGEHKDJK(null)] MKCGLADJFFJ MLNADBAMFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79E3300", Offset = "0x79E1B00", VA = "0x1879E3300", Slot = "4")]
	public bool HPJLMECNIKK(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79E3400", Offset = "0x79E1C00", VA = "0x1879E3400", Slot = "5")]
	public bool HPJLMECNIKK(GONFFIMNHAP OFJCDBCHAMF, IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x79E2620", Offset = "0x79E0E20", VA = "0x1879E2620")]
	private void GCDINNJIIEC(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x79E3840", Offset = "0x79E2040", VA = "0x1879E3840")]
	private void IPMNLLJPNLN(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79E3A70", Offset = "0x79E2270", VA = "0x1879E3A70")]
	private void JHLBONKJEPO(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x79E2530", Offset = "0x79E0D30", VA = "0x1879E2530")]
	private void BLJCAPPPNKM(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x79E31F0", Offset = "0x79E19F0", VA = "0x1879E31F0")]
	private void GCEFGHBGJEK(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x79E3FC0", Offset = "0x79E27C0", VA = "0x1879E3FC0")]
	private void PJHIDDEKABC(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x79E2570", Offset = "0x79E0D70", VA = "0x1879E2570")]
	private void EJNBKBNGPHM(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79E2560", Offset = "0x79E0D60", VA = "0x1879E2560")]
	private void DHDKPAFJNCP(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x79E2500", Offset = "0x79E0D00", VA = "0x1879E2500")]
	private void BDPHNEKLNCB(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? LDIOMGMJIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x79E3560", Offset = "0x79E1D60", VA = "0x1879E3560")]
	private void IHECCEOLLDL(AHOGOONMGAK BAEHAEFCNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79E3C70", Offset = "0x79E2470", VA = "0x1879E3C70")]
	private AHOGOONMGAK NJHEAKAEGDG(AHOGOONMGAK BAEHAEFCNBH, List<RangeMigration> LIAFJGNJMFA, PBBOLHBJGGN IFJBPDHOAOJ, PBBOLHBJGGN OEBGENIHGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79E32C0", Offset = "0x79E1AC0", VA = "0x1879E32C0")]
	private float HCEKAOPBEGB(float KLOLOCPCHBE, Vector2 FNMAADONFDB, Vector2 JOAEPELLOHE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x79E3AA0", Offset = "0x79E22A0", VA = "0x1879E3AA0")]
	private (RangeMigration?, RangeMigration?) MKCEJAGLAEI(List<RangeMigration> KFALAJANFIC, IOPOMOOJGAE PINJDNNPILD, PBBOLHBJGGN IFJBPDHOAOJ, PBBOLHBJGGN OEBGENIHGHN)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ENGBPOHEKEM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPJLMECNIKK(AHOGOONMGAK BAEHAEFCNBH, IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPJLMECNIKK(GONFFIMNHAP OFJCDBCHAMF, IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH);
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
		public GFPEBKLBEPB AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x79C4810", Offset = "0x79C3010", VA = "0x1879C4810")]
		public void MGINGJEOKKH(AnimationPoseSetting PGPJMFPAKOO, float HJOGHKMAOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x79C4940", Offset = "0x79C3140", VA = "0x1879C4940")]
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
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x79C5230", Offset = "0x79C3A30", VA = "0x1879C5230")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x79C51F0", Offset = "0x79C39F0", VA = "0x1879C51F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x79C4960", Offset = "0x79C3160", VA = "0x1879C4960")]
		private void LCFBGLJDKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7954D00", Offset = "0x7953500", VA = "0x187954D00", Slot = "4")]
		public void SetEnabled(bool BCOFJMBGKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79C5260", Offset = "0x79C3A60", VA = "0x1879C5260")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C52A0", Offset = "0x79C3AA0", VA = "0x1879C52A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C52E0", Offset = "0x79C3AE0", VA = "0x1879C52E0")]
		public AnimationPoseSetting CHKJNOKKDHE(GFPEBKLBEPB FNNMPPDIMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x79C5310", Offset = "0x79C3B10", VA = "0x1879C5310")]
		public void ILJHHMHPGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x79C5350", Offset = "0x79C3B50", VA = "0x1879C5350")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum ILAHOLAJMLM
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private ILAHOLAJMLM handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x79C5E00", Offset = "0x79C4600", VA = "0x1879C5E00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79C5DC0", Offset = "0x79C45C0", VA = "0x1879C5DC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79C57C0", Offset = "0x79C3FC0", VA = "0x1879C57C0")]
		private void LCFBGLJDKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7954D00", Offset = "0x7953500", VA = "0x187954D00", Slot = "4")]
		public void SetEnabled(bool BCOFJMBGKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x79C5E30", Offset = "0x79C4630", VA = "0x1879C5E30")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, NHEOEIAAFHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		[Header("Configuration")]
		private DODMAGIBHBA avatarBodyType;

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
		[DAFFCFHPHBO(HNCMILCNFNF.SelfAndChildren, false, false, false)]
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
		private GIBMNEKOFGJ EEDDHHFBFFB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GIBMNEKOFGJ DGCIFOLEDGM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA79A50", Offset = "0xA78250", VA = "0x180A79A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform KNKIHENFOJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x79C6C20", Offset = "0x79C5420", VA = "0x1879C6C20", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x79C5E60", Offset = "0x79C4660", VA = "0x1879C5E60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x79C6AE0", Offset = "0x79C52E0", VA = "0x1879C6AE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x79C6A90", Offset = "0x79C5290", VA = "0x1879C6A90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x79C6A20", Offset = "0x79C5220", VA = "0x1879C6A20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x79C5E60", Offset = "0x79C4660", VA = "0x1879C5E60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x79C61F0", Offset = "0x79C49F0", VA = "0x1879C61F0", Slot = "6")]
		public GIBMNEKOFGJ CreateAvatarSystem(string CCHJEFHHOEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x79C6A20", Offset = "0x79C5220", VA = "0x1879C6A20", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x79C5F20", Offset = "0x79C4720", VA = "0x1879C5F20", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x79C6B30", Offset = "0x79C5330", VA = "0x1879C6B30", Slot = "9")]
		public void UpdatePostIKAnimControllers(float LMCBAJKHEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class JDIDHDPABJM : GIBMNEKOFGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class FMPGIPGOKLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Vector3 BNAIPEFHONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Quaternion HEBIIGLNLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Vector3 IABEBBEBEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private Transform LLHDBKFCPPF;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 DEGFAMDNJEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1E9E310", Offset = "0x1E9CB10", VA = "0x181E9E310")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1E9E330", Offset = "0x1E9CB30", VA = "0x181E9E330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion KIMNLOIDJHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1322FB0", Offset = "0x13217B0", VA = "0x181322FB0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1322E20", Offset = "0x1321620", VA = "0x181322E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float OOOLKKOAMFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1093CB0", Offset = "0x10924B0", VA = "0x181093CB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x16ECE80", Offset = "0x16EB680", VA = "0x1816ECE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool NHDJBLGCEBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9E24B0", Offset = "0x9E0CB0", VA = "0x1809E24B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9E2380", Offset = "0x9E0B80", VA = "0x1809E2380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool FLOHJJDCCEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9E2490", Offset = "0x9E0C90", VA = "0x1809E2490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9E22D0", Offset = "0x9E0AD0", VA = "0x1809E22D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool DKBFGOOPDCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9E2390", Offset = "0x9E0B90", VA = "0x1809E2390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9E23A0", Offset = "0x9E0BA0", VA = "0x1809E23A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float HHJHEGFGIKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xC466D0", Offset = "0xC44ED0", VA = "0x180C466D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xC47960", Offset = "0xC46160", VA = "0x180C47960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x79E9200", Offset = "0x79E7A00", VA = "0x1879E9200")]
		public void DCKLANBPAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x79E98E0", Offset = "0x79E80E0", VA = "0x1879E98E0")]
		public void FHMKLOAOMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x79E9C40", Offset = "0x79E8440", VA = "0x1879E9C40")]
		public float NEFBIEEABKI(Vector3 JJMONFDKBDA, Quaternion LEEFBINGBOM, [In] AvatarFootSettings OFAOINMFOAH, float IDALAMAMLPO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x79E9210", Offset = "0x79E7A10", VA = "0x1879E9210")]
		public void DDCJNHIJNAE(Vector3 INNPGGAHIAN, Quaternion PHGOLJMIDGO, Transform HPBHOHEPJKA, float PKCMJBCDLCP, bool GEAMAJEAOME, bool NANFKAHOFNJ, float CNKBOFNJAOP, float EKPKHJLPHGG, Transform PNDCHGJLEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x79E9910", Offset = "0x79E8110", VA = "0x1879E9910")]
		public void HIHDHCKBJCG(Transform EPBBFOFAFAB, Transform PNDCHGJLEGG, bool HOIALHEBOIF, bool NJPJAOPJEDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x79E9B40", Offset = "0x79E8340", VA = "0x1879E9B40")]
		private void HINDIJIFGHL(Transform PNDCHGJLEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x79E9E50", Offset = "0x79E8650", VA = "0x1879E9E50")]
		public void NJGEGDLOJMG(Transform PNDCHGJLEGG, AvatarFullBodyConfiguration PKENAIPAKDA, Vector3 JHJMFOIJLON, float GLDOOFNCDHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x79E98F0", Offset = "0x79E80F0", VA = "0x1879E98F0")]
		public void GCCJGGELBKP(float EKPKHJLPHGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79E9FA0", Offset = "0x79E87A0", VA = "0x1879E9FA0")]
		public FMPGIPGOKLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class DBFMNPHGLHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float APHKHNHOGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool DMMDBBOELKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AnimationPoseSetting DEGHIPPOEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float LDHCGEIKOFC;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x79E6660", Offset = "0x79E4E60", VA = "0x1879E6660")]
		public void BKDEPEOOABE(IKSolverVR.Arm DJDABALJHBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x79E6CD0", Offset = "0x79E54D0", VA = "0x1879E6CD0")]
		public void DKFCEOHHBPO(IKSolverVR.Arm DJDABALJHBK, float OBJCFEENBAF, bool DMMDBBOELKJ, AvatarFullBodyConfiguration PKENAIPAKDA, float HAGKKHCGGDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x79E6C90", Offset = "0x79E5490", VA = "0x1879E6C90")]
		private void DFEGDDGGNIP(IKSolverVR.Arm DJDABALJHBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x79E71B0", Offset = "0x79E59B0", VA = "0x1879E71B0")]
		public void FGDPEBOOMAC(IKSolverVR.Arm DJDABALJHBK, Transform KNFCEHEIIEM, Transform HPBHOHEPJKA, Quaternion IIINNJCOKCB, Vector3 EAGKBNEMDFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x79E76F0", Offset = "0x79E5EF0", VA = "0x1879E76F0")]
		private (Vector3, Quaternion) IBDBEHANGGD(NFIFJGNJPKF MOILPNEBJOM, Quaternion PBLACJBFBEE, Vector3 HBNOENKCJHA)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x79E7590", Offset = "0x79E5D90", VA = "0x1879E7590")]
		public void GAEAEHFLJIH(NFIFJGNJPKF MOILPNEBJOM, IKSolverVR.Arm DJDABALJHBK, Quaternion PBLACJBFBEE, Vector3 HBNOENKCJHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x79E6690", Offset = "0x79E4E90", VA = "0x1879E6690")]
		public void DDLILHHLHHK(NFIFJGNJPKF MOILPNEBJOM, IKSolverVR.Arm DJDABALJHBK, Quaternion PBLACJBFBEE, Vector3 HBNOENKCJHA, [In] AvatarFullBodyConfiguration PKENAIPAKDA, [In] EPLMFNEPADG LLNIPANPIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x79E7B80", Offset = "0x79E6380", VA = "0x1879E7B80")]
		public void KIFJGKKLGAM(GFPEBKLBEPB MFDBFKALNEM, AvatarFullBodyConfiguration PKENAIPAKDA, EPLMFNEPADG LLNIPANPIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x79E6D10", Offset = "0x79E5510", VA = "0x1879E6D10")]
		public void DKJEEINMDBH(IKSolverVR.Arm DJDABALJHBK, Transform KNFCEHEIIEM, Vector3 IDOCBPPKLJN, float NMAPKNBOJKC, Quaternion BNNLGJJEKEC, Vector3 DFEFGMDHEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x79E7CC0", Offset = "0x79E64C0", VA = "0x1879E7CC0")]
		public DBFMNPHGLHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum HKDFBHEOFKD
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
	private struct LPDEODOJKGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct CEAINABMBHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int NIKDNPJNPOF;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int CKFFEBFODKM;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int HDPJKCOPCOH;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int ENJBAIFNGJP;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int PLPKLIKGILH;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int AIIPGMNOPOH;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int EELAELFLFPP;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int EMMBACIGCIM;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int HJJKPOHCLNJ;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int IGFINMBMFHK;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int NMJFAIIHPNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int OKFJCBCKJNL;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int OOBAEGMJHNM;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int ODILMCDKPNI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int ENIKINIHNFL;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int DILIIHKPPLJ;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int EAOABICIHJJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int NCPNKGGMCJG;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int PJJLJKMHOCO;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int OGEPOAHIJJB;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int KLKGELLNENM;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int JLOLDCDFEPM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int NEAIOIKPHDI;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int FKBMBELICCA;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int BFCCILKFKBK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int HIMLBGKOGPE;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int KEKIPMNJOOI;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int OKOHBLAOPED;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int DDCJJGEDMIN;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int JMKPPFBGCBH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int MLDOBPJIBDG;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int ALPCPECJIPN;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly Vector3 JOFBPIAKJAN;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int GOJEGCFENGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool LJGPCGEPANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool KHGGJFPBAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool ADHCKLAOJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool JKBDBFDDMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool BODNCLDNCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool FHPKLBLODBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Vector3 DIENEOKDLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private string MNIBGDDNDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private APCADJAPHPK? HGOIEHJLLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NPGOJMKLAEG? MJGNHPHIAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private HLFKGFHMNDN LDPGIMKDJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NPFOAJJMFAJ AMMOCJCAKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private NFIFJGNJPKF ILPFFCHGJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private NFIFJGNJPKF EPMGJAGAANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool HDIBPLCIHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool BIHBDAJIAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly MFJOLECBBLB HMLCJPEMEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly DPKNBNLLFGD PCGGPKBHGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int MMJFMNOPJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private float JJIAAIEECKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private GameObject DOKOCFJOGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform MCFOMJPNPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform GOKNMMIAAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform MHMLGINHDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform CCFEGOBIKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float PBCKNOIDLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private float HKPEDOGIGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Vector3 IMODOHPIDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Quaternion EGLKHIIJNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform LHBGPDCMPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform DIMEOJLJAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Transform KFHLBPMAKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private JEDHIECAPLF HCBOBIAPIKI;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker AEKCGHNNGBH;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker CKMBBGIOOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private ProfilerMarker DGPGCCDDDKD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker PKLKKFMJINO;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker ONADLHINOOI;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly ProfilerMarker LMKCAIELOJM;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly List<JDIDHDPABJM> PJPLMBIPEIK;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int LHACAEONHHK;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> KEAGNKBLOGC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int DPDBDEHGLMH;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int IJCJJFGJMNA;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int IEPKAJAIBOO;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static int CMIHKIAJKFD;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float LNNEOIGOPLG;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int NKKLLJJIMAN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float DDKEKMFABEP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float DCKFJDOHFBN;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float IEBAHHOLLML;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static float IFEGOFMNDCE;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static OAFJPPFOELG DFJEGBPFHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float HKDDKAOEEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool LPMOAIKGPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float IJHEBOOKAIF;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int KPAILPJCHEN;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly int BAGCAFJJMLB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly int HLMGDDBCBJF;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly int MBDJKENIAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private FMPGIPGOKLH PBKDKINNOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private FMPGIPGOKLH MBKNEHMPFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private float IJPPMMJMIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private Vector3 OFNFEHMNAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private Vector3 ABPOFNKFGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool ILNGKBLEONB;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Quaternion FDFGBOJMHIE;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Quaternion HKGGPBBFCEF;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly Vector3 NGHNFJMEEIE;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Vector3 DFBGIFMIGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float FGOIJCKAEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float BFDCIMOHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private DBFMNPHGLHA CAIFBNOGDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private DBFMNPHGLHA APJMHAKFDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private MBMLAIPMNGL KMCCPEHNIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private ECDLMGPDNGA IBOCCAMPJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly HDIIAPIDDCJ GKAGNOLLKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float LHGEOHFBKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float FKAHIEJMKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly ECDLMGPDNGA EBNLBCGIIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private Vector3 EAGAOLNPLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private Vector3 GJKNEAPOADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float JIGBJPBEEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float CGLNJPNEOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly ECDLMGPDNGA HDGJAJABKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly MBMLAIPMNGL DADECHNNLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly ECDLMGPDNGA LGDHDGJLEOE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FIEKIAHLEMJ IICCOPJJOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FIEKIAHLEMJ JJOKDAMMKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration OLGDJBFMBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79E14E0", Offset = "0x79DFCE0", VA = "0x1879E14E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DODMAGIBHBA FNKKGBAANJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x79DED40", Offset = "0x79DD540", VA = "0x1879DED40", Slot = "23")]
		get
		{
			return default(DODMAGIBHBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration IABIHFAOLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x79D9FB0", Offset = "0x79D87B0", VA = "0x1879D9FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform KEJBAGGOMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x79C9E80", Offset = "0x79C8680", VA = "0x1879C9E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform NPIMKEAFGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x79CAA70", Offset = "0x79C9270", VA = "0x1879CAA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer AHCHDKHHMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x79D9A60", Offset = "0x79D8260", VA = "0x1879D9A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] IDOLHCAFMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x79DCA90", Offset = "0x79DB290", VA = "0x1879DCA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] JLNOENBBBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x79D58C0", Offset = "0x79D40C0", VA = "0x1879D58C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator OIHFDHGHGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x79D29B0", Offset = "0x79D11B0", VA = "0x1879D29B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK DLGIDFJBIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x79D0820", Offset = "0x79CF020", VA = "0x1879D0820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private KGKIJCCCBBA CFECLNGJBAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x79DDBD0", Offset = "0x79DC3D0", VA = "0x1879DDBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private KGKIJCCCBBA JHHLBGJMFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x79DA220", Offset = "0x79D8A20", VA = "0x1879DA220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private KGKIJCCCBBA DJFHDONOGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x79D2FD0", Offset = "0x79D17D0", VA = "0x1879D2FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private KGKIJCCCBBA MCLKKIAJPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x79E0080", Offset = "0x79DE880", VA = "0x1879E0080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private KGKIJCCCBBA JNHLGGEOCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79D0B70", Offset = "0x79CF370", VA = "0x1879D0B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private KGKIJCCCBBA NCOPDHIIDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x79D84D0", Offset = "0x79D6CD0", VA = "0x1879D84D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private KGKIJCCCBBA MFDGIOFJAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x79DF520", Offset = "0x79DDD20", VA = "0x1879DF520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private KGKIJCCCBBA LKFFIFMJDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x79CE460", Offset = "0x79CCC60", VA = "0x1879CE460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public NPGOJMKLAEG FLPIAJNAOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x79DFB50", Offset = "0x79DE350", VA = "0x1879DFB50", Slot = "15")]
		get
		{
			return default(NPGOJMKLAEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MKBPDMPFCMC GBBCKHIFMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA9F0F0", Offset = "0xA9D8F0", VA = "0x180A9F0F0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EGMADKKHCJK FOFIGEDFPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA9F0E0", Offset = "0xA9D8E0", VA = "0x180A9F0E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public NDBEIHDKPNF DPPBNCMHJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA9E6F0", Offset = "0xA9CEF0", VA = "0x180A9E6F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public NDBEIHDKPNF LPKJCIGBGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA9ED80", Offset = "0xA9D580", VA = "0x180A9ED80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string DCDLIDOFHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform KNNEMPJHBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x79C9640", Offset = "0x79C7E40", VA = "0x1879C9640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform NBCCHAIPJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x79E0200", Offset = "0x79DEA00", VA = "0x1879E0200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform LOOMIKKHHJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x79C9E50", Offset = "0x79C8650", VA = "0x1879C9E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform KFNJNDLMEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x79E0180", Offset = "0x79DE980", VA = "0x1879E0180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform CNAJNFNGPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x79D39D0", Offset = "0x79D21D0", VA = "0x1879D39D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool NFOEGLJJMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x79CE560", Offset = "0x79CCD60", VA = "0x1879CE560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool ICHGOCDIKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x79CE560", Offset = "0x79CCD60", VA = "0x1879CE560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool BELNCNFILAL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x79CC950", Offset = "0x79CB150", VA = "0x1879CC950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform IFLGCIEFLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x79D33E0", Offset = "0x79D1BE0", VA = "0x1879D33E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject KJMBGAPFJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x79D2910", Offset = "0x79D1110", VA = "0x1879D2910", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets EGFKLIAFJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x79CA200", Offset = "0x79C8A00", VA = "0x1879CA200", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform OMIFOFBJLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA9F100", Offset = "0xA9D900", VA = "0x180A9F100", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform NMKNKFBACIE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E570", Offset = "0xA9CD70", VA = "0x180A9E570", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform OLFMFOCJAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA89B10", Offset = "0xA88310", VA = "0x180A89B10", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform DCHDADKEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F070", Offset = "0xA9D870", VA = "0x180A9F070", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 FKFLFMGINPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x79DABD0", Offset = "0x79D93D0", VA = "0x1879DABD0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float OOJILAMCGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x79DDB80", Offset = "0x79DC380", VA = "0x1879DDB80", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform PELEDJLIEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x79D5860", Offset = "0x79D4060", VA = "0x1879D5860", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform OMAELPGCLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x131D330", Offset = "0x131BB30", VA = "0x18131D330", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform AENPBDGNMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x131D0E0", Offset = "0x131B8E0", VA = "0x18131D0E0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform EKJMHHJNHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x226DDD0", Offset = "0x226C5D0", VA = "0x18226DDD0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool IEKPGHPKAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x79D83E0", Offset = "0x79D6BE0", VA = "0x1879D83E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool MAFOOBDGAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x79CCDA0", Offset = "0x79CB5A0", VA = "0x1879CCDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool OCBDLIKAOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x79CACD0", Offset = "0x79C94D0", VA = "0x1879CACD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79DF9F0", Offset = "0x79DE1F0", VA = "0x1879DF9F0")]
	private float NLPOKCGGGIM(BKNINMNIANP DALEDBGHDIN, float KBMAPMJDDCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x79DACB0", Offset = "0x79D94B0", VA = "0x1879DACB0")]
	private void LHCKDGDOCPG([In] EPLMFNEPADG HJCLEDFILLP, [In] AvatarFullBodyConfiguration PKENAIPAKDA, bool OPDOPDPIDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79D4850", Offset = "0x79D3050", VA = "0x1879D4850")]
	private float GLAJINKAKPB([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79DA3E0", Offset = "0x79D8BE0", VA = "0x1879DA3E0")]
	private float KKMAMCPNHNO([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x79D6BA0", Offset = "0x79D53A0", VA = "0x1879D6BA0")]
	private void IJCPJHBDNNB(EPLMFNEPADG HJCLEDFILLP, AvatarFullBodyConfiguration PKENAIPAKDA, bool OPDOPDPIDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79D9DF0", Offset = "0x79D85F0", VA = "0x1879D9DF0")]
	private void KBILNCAMGLA([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x79CA100", Offset = "0x79C8900", VA = "0x1879CA100")]
	private void BBPKGOLKEFD([In] EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x79E2060", Offset = "0x79E0860", VA = "0x1879E2060")]
	public JDIDHDPABJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79D7010", Offset = "0x79D5810", VA = "0x1879D7010", Slot = "12")]
	public void INGEHFFGBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79DD7D0", Offset = "0x79DBFD0", VA = "0x1879DD7D0", Slot = "13")]
	public void MEOBPFEJNNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x79CDF50", Offset = "0x79CC750", VA = "0x1879CDF50", Slot = "14")]
	public void EDGHJKBNBCP(bool KKOIOCICPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x79D6EC0", Offset = "0x79D56C0", VA = "0x1879D6EC0", Slot = "25")]
	public Transform IKDOPGBGHDF(string KJMMMDHHBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x79C9880", Offset = "0x79C8080", VA = "0x1879C9880", Slot = "26")]
	public Vector3? AHAGJOFKPPM(string KJMMMDHHBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x79DDCD0", Offset = "0x79DC4D0", VA = "0x1879DDCD0", Slot = "7")]
	public void MHOPEGAKOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x79C9D50", Offset = "0x79C8550", VA = "0x1879C9D50")]
	private void AKGADOGDDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x79DF3A0", Offset = "0x79DDBA0", VA = "0x1879DF3A0")]
	private Vector3 NCJILCENDLP([In] EPLMFNEPADG LLNIPANPIOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x79E0240", Offset = "0x79DEA40", VA = "0x1879E0240", Slot = "6")]
	public void PNMABHMNDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x79E0010", Offset = "0x79DE810", VA = "0x1879E0010", Slot = "8")]
	public void PDHEJKMOLNA(float HAAKPDEEDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x79CAD50", Offset = "0x79C9550", VA = "0x1879CAD50")]
	private void BLNPDALIDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x79CE5B0", Offset = "0x79CCDB0", VA = "0x1879CE5B0", Slot = "4")]
	public void EMMPKNLGGCD(string CCHJEFHHOEE, APCADJAPHPK IOMJKDCOJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x79D3AC0", Offset = "0x79D22C0", VA = "0x1879D3AC0", Slot = "5")]
	public void GEJCOHDJHNE(NPGOJMKLAEG AAJMDELFJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x79CAB70", Offset = "0x79C9370", VA = "0x1879CAB70", Slot = "11")]
	public void BIDAJLJEJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x79D17F0", Offset = "0x79CFFF0", VA = "0x1879D17F0", Slot = "24")]
	public void EPAFMLCLACJ([Out] Vector3 OODBNNLLKJF, [Out] Quaternion BNNLGJJEKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x79D30D0", Offset = "0x79D18D0", VA = "0x1879D30D0")]
	private void FEKGHCMEGCP([In] EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x11ACAF0", Offset = "0x11AB2F0", VA = "0x1811ACAF0", Slot = "27")]
	public void NAHJMLLJEON(float LOCBDBLAPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79DC740", Offset = "0x79DAF40", VA = "0x1879DC740", Slot = "28")]
	public void LLNJPOGBLCK(float CLCJCCLEOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x79DC6F0", Offset = "0x79DAEF0", VA = "0x1879DC6F0", Slot = "44")]
	public void LKAFPMMLMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x79DAC60", Offset = "0x79D9460", VA = "0x1879DAC60", Slot = "29")]
	public void LGEFKLICOCN(bool BFHKCKIPLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x79DEE40", Offset = "0x79DD640", VA = "0x1879DEE40", Slot = "30")]
	public HandLogicOffsets MNKAHHBMDPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x79DA320", Offset = "0x79D8B20", VA = "0x1879DA320", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets KIKFOLCBIIL()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x79CDC50", Offset = "0x79CC450", VA = "0x1879CDC50")]
	private void DKFNDMFOHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x79C9F80", Offset = "0x79C8780", VA = "0x1879C9F80")]
	private void APIAPAKNOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x79D65A0", Offset = "0x79D4DA0", VA = "0x1879D65A0")]
	private void IIMFMGBMELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x79D34E0", Offset = "0x79D1CE0", VA = "0x1879D34E0")]
	private void FNOPIDCMHHG(PHIEGKANMEI AGNHFAEPPMC, bool NHEENLIEFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x79DD650", Offset = "0x79DBE50", VA = "0x1879DD650")]
	private void MEANDLMMBPJ(PHIEGKANMEI AGNHFAEPPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x79D7830", Offset = "0x79D6030", VA = "0x1879D7830")]
	public Vector3 JAAHOFIMBHE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x79DF620", Offset = "0x79DDE20", VA = "0x1879DF620")]
	private void NIODKIGGFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x79CADA0", Offset = "0x79C95A0", VA = "0x1879CADA0")]
	private void CJFPLGIHMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x79D59C0", Offset = "0x79D41C0", VA = "0x1879D59C0")]
	private void HOFMLHAFDEK(EPLMFNEPADG HJCLEDFILLP, AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x79D50B0", Offset = "0x79D38B0", VA = "0x1879D50B0")]
	private float HAFDDJMKPDJ([In] EPLMFNEPADG LLNIPANPIOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x79DF910", Offset = "0x79DE110", VA = "0x1879DF910")]
	private int NIPLMBDMDIP([In] FDNPGDLEPBB CFJPBADIEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x79CD430", Offset = "0x79CBC30", VA = "0x1879CD430")]
	private void DHLAAMBMBAD(EPLMFNEPADG HJCLEDFILLP, bool FDEHNKNAHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x79D37C0", Offset = "0x79D1FC0", VA = "0x1879D37C0")]
	private static void GBCLDOLIIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x79C8940", Offset = "0x79C7140", VA = "0x1879C8940")]
	private static void AAKEMKOOIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x79D4EE0", Offset = "0x79D36E0", VA = "0x1879D4EE0")]
	private float GOFCGFMKLFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x79DFA10", Offset = "0x79DE210", VA = "0x1879DFA10")]
	private static int NPODKPCBLJK(JDIDHDPABJM HKAFAMHBCLL, JDIDHDPABJM JAKFFJGMBEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x79D3F40", Offset = "0x79D2740", VA = "0x1879D3F40", Slot = "40")]
	public EPLMFNEPADG GHAIFOIICAK()
	{
		return default(EPLMFNEPADG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79D5260", Offset = "0x79D3A60", VA = "0x1879D5260")]
	private bool HAKHGJFIKEH(int MLBCMOLHELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x79DAB50", Offset = "0x79D9350", VA = "0x1879DAB50")]
	public void KPKLGNLIDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x79D63D0", Offset = "0x79D4BD0", VA = "0x1879D63D0")]
	private (bool, bool) IAJBCCELCJP()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x79DA040", Offset = "0x79D8840", VA = "0x1879DA040")]
	private (float, float) KGEOPCAKDAN([In] EPLMFNEPADG LLNIPANPIOA)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x79CADC0", Offset = "0x79C95C0", VA = "0x1879CADC0")]
	private void CKKFFJEGEDP([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x79D7510", Offset = "0x79D5D10", VA = "0x1879D7510")]
	private void IPCBFMBCHBM([In] EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x79D85D0", Offset = "0x79D6DD0", VA = "0x1879D85D0")]
	private void JLPKLLNOMIO([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA, AvatarFootSettings OFAOINMFOAH, bool CFCFJACIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x79DFC60", Offset = "0x79DE460", VA = "0x1879DFC60")]
	private float OOIOGHCOHIN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x79D0C70", Offset = "0x79CF470", VA = "0x1879D0C70")]
	private void EODIPCOGJNG(EPLMFNEPADG LLNIPANPIOA, AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x79DC6A0", Offset = "0x79DAEA0", VA = "0x1879DC6A0")]
	private float LJDNPCJPFEA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x79CCE20", Offset = "0x79CB620", VA = "0x1879CCE20")]
	private void DDGBONINAMB([In] EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x79D3100", Offset = "0x79D1900", VA = "0x1879D3100")]
	private void FGDPEBOOMAC([In] EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x79D89F0", Offset = "0x79D71F0", VA = "0x1879D89F0")]
	private void JOBPAJHBGJB([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x79D2AB0", Offset = "0x79D12B0", VA = "0x1879D2AB0")]
	private void FDBDCGGHJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x79D7CD0", Offset = "0x79D64D0", VA = "0x1879D7CD0")]
	private void JBEAOPHHJFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x79D6D30", Offset = "0x79D5530", VA = "0x1879D6D30")]
	private void IKCNMAIDHBP([In] EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x79D9B60", Offset = "0x79D8360", VA = "0x1879D9B60")]
	private void JPCLFLAIPBC(NFIFJGNJPKF GMALKCILJOC, IKSolverVR.Arm DJDABALJHBK, Transform MDONMGBFLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x79D7F20", Offset = "0x79D6720", VA = "0x1879D7F20")]
	private void JBLMPEDFBBO(EPLMFNEPADG LLNIPANPIOA, AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x79D6200", Offset = "0x79D4A00", VA = "0x1879D6200")]
	private void IAALIKKALEL(CGLPDKPEOLH DPEJIAGPCNJ, NDBEIHDKPNF GMALKCILJOC, IKSolverVR.Arm DJDABALJHBK, float OBJCFEENBAF, float FEPFIPNNDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x79D48E0", Offset = "0x79D30E0", VA = "0x1879D48E0")]
	private void GNGEDPJEOJH([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x79D54A0", Offset = "0x79D3CA0", VA = "0x1879D54A0")]
	protected void HDMMJINALPM([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x79CDC80", Offset = "0x79CC480", VA = "0x1879CDC80")]
	private void EACEEHKMAOH([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x79D0920", Offset = "0x79CF120", VA = "0x1879D0920")]
	protected void ENDGAGBGAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x79E0CC0", Offset = "0x79DF4C0", VA = "0x1879E0CC0")]
	private void POKNKPFLAPN([In] EPLMFNEPADG LLNIPANPIOA, [In] HKDFBHEOFKD BLLDCDDKIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x79D2760", Offset = "0x79D0F60", VA = "0x1879D2760")]
	private void FBEEAIJCFID(EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x79E01C0", Offset = "0x79DE9C0", VA = "0x1879E01C0")]
	private void PKNHMODMHAF([In] EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x79DEE90", Offset = "0x79DD690", VA = "0x1879DEE90")]
	private Vector3 MOEAIKAJODP([In] EPLMFNEPADG LLNIPANPIOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x79DCB90", Offset = "0x79DB390", VA = "0x1879DCB90")]
	private void MAJMFEFDOBK([In] EPLMFNEPADG LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x79D7880", Offset = "0x79D6080", VA = "0x1879D7880")]
	private float JAPECMLIEDN(float EKPKHJLPHGG, [In] EPLMFNEPADG LLNIPANPIOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x79CD2E0", Offset = "0x79CBAE0", VA = "0x1879CD2E0")]
	private void DGGAPDJPDON(float EKPKHJLPHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x79DA460", Offset = "0x79D8C60", VA = "0x1879DA460")]
	private void KMCBKFAECIL([In] EPLMFNEPADG LLNIPANPIOA, HKDFBHEOFKD BLLDCDDKIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x79DE4A0", Offset = "0x79DCCA0", VA = "0x1879DE4A0")]
	private float MJENNACHEDK([In] EPLMFNEPADG HJCLEDFILLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x79CA280", Offset = "0x79C8A80", VA = "0x1879CA280")]
	private void BFHJEHPNEHM(EPLMFNEPADG LLNIPANPIOA, HKDFBHEOFKD BLLDCDDKIKG, Vector3 COGAOHOCLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x79D25B0", Offset = "0x79D0DB0", VA = "0x1879D25B0")]
	private static void FANHDEDEGNO(Transform POFBAOBKAGL, Quaternion PMHMEKBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x79DFCE0", Offset = "0x79DE4E0", VA = "0x1879DFCE0")]
	private void PBLDMGLCJMB([In] EPLMFNEPADG HNAMKALFCDC, [In] FDNPGDLEPBB CFJPBADIEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x79D91B0", Offset = "0x79D79B0", VA = "0x1879D91B0")]
	private void JOHEHIDHOKE([In] EPLMFNEPADG HNAMKALFCDC, [In] FDNPGDLEPBB CFJPBADIEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x79C9690", Offset = "0x79C7E90", VA = "0x1879C9690")]
	private void ABHBIICENBA(float BBDBGPOMHLD, [In] EPLMFNEPADG HJCLEDFILLP, float GODHFONKICC = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x79D4090", Offset = "0x79D2890", VA = "0x1879D4090")]
	private float GJOODENCFJB([In] EPLMFNEPADG HJCLEDFILLP, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x79CD960", Offset = "0x79CC160", VA = "0x1879CD960")]
	private void DIADGEJKNBK([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x79D1B80", Offset = "0x79D0380", VA = "0x1879D1B80")]
	private void EPCKMHPJCDM([In] EPLMFNEPADG HJCLEDFILLP, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x79D8DE0", Offset = "0x79D75E0", VA = "0x1879D8DE0")]
	private void JOEPFHCKFKG([In] EPLMFNEPADG HJCLEDFILLP, float JDBMHGAKFCN, float ELKMCDKAHBO, Vector3 BODDDFIPJCD, float GODHFONKICC = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x79DCC60", Offset = "0x79DB460", VA = "0x1879DCC60")]
	private void MCFEKDLGNIJ(EPLMFNEPADG HJCLEDFILLP, AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x79D2D40", Offset = "0x79D1540", VA = "0x1879D2D40")]
	private void FDHPPBFKBFI(EPLMFNEPADG LLNIPANPIOA, AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x79C9A10", Offset = "0x79C8210", VA = "0x1879C9A10")]
	private void AJJFBCNKKMM(EPLMFNEPADG HJCLEDFILLP, AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x79D69E0", Offset = "0x79D51E0", VA = "0x1879D69E0")]
	public void IJBLBKLIKHN([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x79CCA40", Offset = "0x79CB240", VA = "0x1879CCA40")]
	public void DAIJJJJFCNM([In] EPLMFNEPADG LLNIPANPIOA, [In] AvatarFullBodyConfiguration PKENAIPAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x79D5300", Offset = "0x79D3B00", VA = "0x1879D5300")]
	[CompilerGenerated]
	internal static void HBIJHJHJPJD(Transform GGBFBJAOFOK, IKSolverVR.Arm DJDABALJHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x79D3A10", Offset = "0x79D2210", VA = "0x1879D3A10")]
	[CompilerGenerated]
	internal static void GCANNHBJGLI(Vector3 IJOEOJKOEJK, Vector3 CCOLCMBGNDD, LPDEODOJKGF P_2, CEAINABMBHJ P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x79DECA0", Offset = "0x79DD4A0", VA = "0x1879DECA0")]
	[CompilerGenerated]
	internal static void MKDENAEKPDJ(FMPGIPGOKLH PDJGNCJHJHM, FMPGIPGOKLH PAKPCLCPNPL, Vector3 HONLMPEECFH, float LKNKJJBHDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x79DFA40", Offset = "0x79DE240", VA = "0x1879DFA40")]
	[CompilerGenerated]
	internal static bool OIHIAIOBIMM(IKSolverVR.Arm DJDABALJHBK, ACHOJMIGBLI PBMCIAKIPDK, float IOEFOIBNGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x79CE020", Offset = "0x79CC820", VA = "0x1879CE020")]
	[CompilerGenerated]
	internal static float EFDKJABNKOG(Vector3 PDPCJAOAPGO, Vector3 FKGMHPPOBFC, Vector3 LKGDJOPIJFP, EPLMFNEPADG HJCLEDFILLP, AvatarFullBodyConfiguration PKENAIPAKDA, float BFKGIFAKMAP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class EHIGEMFKAPO : BGEHNHPOLOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Dictionary<string, GIBMNEKOFGJ> FKHKBCMKDAH;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x79E87D0", Offset = "0x79E6FD0", VA = "0x1879E87D0")]
	[PJMOOJOMMCC.OJAOBFKEEAO]
	internal static void NFAJGADMOAP(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x79E85B0", Offset = "0x79E6DB0", VA = "0x1879E85B0", Slot = "4")]
	public GIBMNEKOFGJ NACGFMFEHPH(string COIAIHNFBIP, AvatarSystemConfiguration COMMPENJPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x79E88B0", Offset = "0x79E70B0", VA = "0x1879E88B0", Slot = "5")]
	public void OJJHNHNFPPJ(string COIAIHNFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x79E8470", Offset = "0x79E6C70", VA = "0x1879E8470", Slot = "6")]
	public string EPEMHBBLDEM(string ANCBJAMOHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x79E8840", Offset = "0x79E7040", VA = "0x1879E8840")]
	private string OHMLILEFKHH(string ANCBJAMOHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x79E8A90", Offset = "0x79E7290", VA = "0x1879E8A90")]
	public EHIGEMFKAPO()
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
		public class FIBEBPDIIIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private Dictionary<string, Transform> FJHNPKKLOOJ;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool KBDBMNHHFOB
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x79E8C50", Offset = "0x79E7450", VA = "0x1879E8C50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x79E8B20", Offset = "0x79E7320", VA = "0x1879E8B20")]
			public void IHGNAMIECND(VRIK FANPGNJFFNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
			public void HKBIOBMBCDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x79E8C90", Offset = "0x79E7490", VA = "0x1879E8C90")]
			public void OMPDHJNPJPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x79E8CE0", Offset = "0x79E74E0", VA = "0x1879E8CE0")]
			public FIBEBPDIIIE()
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
		[FCBJLJFBGGB(HNCMILCNFNF.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		[DAFFCFHPHBO(HNCMILCNFNF.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly FIBEBPDIIIE CGPKPAFBEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private NHEOEIAAFHB NKIPNGCHEFP;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x79E5D30", Offset = "0x79E4530", VA = "0x1879E5D30")]
		private void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x79E5CE0", Offset = "0x79E44E0", VA = "0x1879E5CE0")]
		private bool CFGEAOJOOMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x79E6010", Offset = "0x79E4810", VA = "0x1879E6010")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x79E6080", Offset = "0x79E4880", VA = "0x1879E6080")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x79E6020", Offset = "0x79E4820", VA = "0x1879E6020")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x79E62F0", Offset = "0x79E4AF0", VA = "0x1879E62F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x79EAE10", Offset = "0x79E9610", VA = "0x1879EAE10")]
			public (float, float) JMJAOMMBBKH(float OJHPKFJJLCJ)
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
				[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x79EA640", Offset = "0x79E8E40", VA = "0x1879EA640")]
			public void ILJHHMHPGDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x79EA500", Offset = "0x79E8D00", VA = "0x1879EA500")]
			public (float, float) AFCLBNGOOCG(Animator JKJBGDPDHKC, AnimatorStateInfo KOFGHIJPENM)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EABC0", Offset = "0x79E93C0", VA = "0x1879EABC0")]
		public void ILJHHMHPGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x79EA720", Offset = "0x79E8F20", VA = "0x1879EA720")]
		public (float, float) HFCPJCGALMO(Animator JKJBGDPDHKC, BKNINMNIANP DALEDBGHDIN, float OJFOAPJPJPK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x79EA960", Offset = "0x79E9160", VA = "0x1879EA960")]
		private (float, float) ICIPJEEAPGI(Animator JKJBGDPDHKC, AnimatorStateInfo KOFGHIJPENM, BKNINMNIANP DALEDBGHDIN, float OJFOAPJPJPK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x79EAE00", Offset = "0x79E9600", VA = "0x1879EAE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EE130", Offset = "0x79EC930", VA = "0x1879EE130", Slot = "4")]
		public override void OnStateEnter(Animator JKJBGDPDHKC, AnimatorStateInfo KOFGHIJPENM, int AHJNNGNACEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x79EE290", Offset = "0x79ECA90", VA = "0x1879EE290")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class KAMFFEAGDEB<TInput, TOutput> : ABFFOHELAGI<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected readonly MKCGLADJFFJ MLNADBAMFHP;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4EE9840", Offset = "0x4EE8040", VA = "0x184EE9840")]
	protected KAMFFEAGDEB(MKCGLADJFFJ MLNADBAMFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput MPBEICGIKAG(TInput JEOEDPICHHI, [Out] IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4EE97A0", Offset = "0x4EE7FA0", VA = "0x184EE97A0", Slot = "5")]
	public bool EKBFNBCAIML(TInput JEOEDPICHHI, [Out] TOutput? HLPIAOANGMD, [Out] IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DBBJMDENMLB]
public static class FPCCCFANHPG
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly Regex HACPFMNEKLN;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x79E9FB0", Offset = "0x79E87B0", VA = "0x1879E9FB0")]
	public static KBEFEEFIOCJ BIINBODKKJO(MFBAIOHMEOF IOFOJGFFCHA, EGIKODNAABF LKLNDFOEOPO, Guid? KAAGPNJIINH, Color? GICPICCGEAE, PNLIIGCPIIK MDILONMHHMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x79EA300", Offset = "0x79E8B00", VA = "0x1879EA300")]
	public static AJELBAFCNLN ONDAAIKMBMO(KBEFEEFIOCJ NFNBKNAJBPN)
	{
		return default(AJELBAFCNLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x378AE70", Offset = "0x3789670", VA = "0x18378AE70")]
	internal static TModern? PMFECFHJNOD<TModern>(string? JEOEDPICHHI, DJAOJFIAGJB<TModern> PECDKKHJHMM, MKCGLADJFFJ MLNADBAMFHP, JEIPKKPGIOH JDFJNNBEIBO, TModern CBEGBPCKHPO) where TModern : struct, EHKBGADHGBA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3789810", Offset = "0x3788010", VA = "0x183789810")]
	internal static EEKGCDPEIHM AJKIMCFCMCH<TModern>(string? JEOEDPICHHI, DJAOJFIAGJB<TModern> PECDKKHJHMM, MKCGLADJFFJ MLNADBAMFHP, JEIPKKPGIOH JDFJNNBEIBO, TModern CBEGBPCKHPO) where TModern : struct, EHKBGADHGBA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x79EA1C0", Offset = "0x79E89C0", VA = "0x1879EA1C0")]
	internal static List<FCKBIMABIOA> NCBFKBAOKGL(IEnumerable<PENJJHBLLDC>? PIJHEJBLJIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3789FF0", Offset = "0x37887F0", VA = "0x183789FF0")]
	internal static string PLJBHPJBCCK<TModern>(TModern JEOEDPICHHI, DJAOJFIAGJB<TModern> PECDKKHJHMM, MKCGLADJFFJ MLNADBAMFHP) where TModern : EHKBGADHGBA
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class DNGHLPPNLCA : MGANAECMDED
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ABFFOHELAGI<KCDOILINLPA, AHOGOONMGAK> DBDKIJILKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ABFFOHELAGI<BOIHPHGPMPK, GONFFIMNHAP> NINBAFMONPP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ABFFOHELAGI<BOIHPHGPMPK, GONFFIMNHAP> GGLBCCIPHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public EJKPGJCOMLK DLBAFFIFIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KJJECAACIAL GJBDCPDAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x79E7EA0", Offset = "0x79E66A0", VA = "0x1879E7EA0")]
	[UsedImplicitly]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	internal static void PIPANJBNOEI(HHDGAAFLDEF PMKEELMHMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x79E7F10", Offset = "0x79E6710", VA = "0x1879E7F10")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DNGHLPPNLCA([LDAFGEHKDJK("UnitySerialization")] CHALJOLABNG KMBBDAKFJPK, [LDAFGEHKDJK(null)] HABBFPCILCO CCNONNFOJHJ, [LDAFGEHKDJK(null)] MKCGLADJFFJ MLNADBAMFHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum EDPHJPFFHND
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
public class IKFPFOPIADA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x79ED930", Offset = "0x79EC130", VA = "0x1879ED930")]
	public IKFPFOPIADA(string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x79ED990", Offset = "0x79EC190", VA = "0x1879ED990")]
	public IKFPFOPIADA(string NJAAPDELBNN, Exception CLGGKPBHAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x79ED960", Offset = "0x79EC160", VA = "0x1879ED960")]
	public IKFPFOPIADA(EDPHJPFFHND HLGPGMAFMLJ, string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x79ED9C0", Offset = "0x79EC1C0", VA = "0x1879ED9C0")]
	public IKFPFOPIADA(EDPHJPFFHND HLGPGMAFMLJ, string NJAAPDELBNN, Exception CLGGKPBHAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class PNIJEFJKGPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly CHALJOLABNG KMBBDAKFJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly HABBFPCILCO CCNONNFOJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly MKCGLADJFFJ MLNADBAMFHP;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x79E5170", Offset = "0x79E3970", VA = "0x1879E5170")]
	protected PNIJEFJKGPJ(CHALJOLABNG KMBBDAKFJPK, HABBFPCILCO CCNONNFOJHJ, MKCGLADJFFJ MLNADBAMFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x79EEC30", Offset = "0x79ED430", VA = "0x1879EEC30")]
	protected string FGALHMDADIA(AHOGOONMGAK BAEHAEFCNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x79EEA50", Offset = "0x79ED250", VA = "0x1879EEA50")]
	protected string EANHPIDHKOF(AHOGOONMGAK BAEHAEFCNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x79EE720", Offset = "0x79ECF20", VA = "0x1879EE720")]
	private AvatarOutfitSelectionData BIINBODKKJO(KBEFEEFIOCJ NBNEIOPBBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x79EFF00", Offset = "0x79EE700", VA = "0x1879EFF00")]
	private static AvatarCustomizationSettingsData.AnchorParams GPEAHCCAAND(PNINFJFLLCD? KKJGLMBGHPB)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface ABFFOHELAGI<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput MPBEICGIKAG(TInput JEOEDPICHHI, [Out] IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EKBFNBCAIML(TInput JEOEDPICHHI, [Out] TOutput? HLPIAOANGMD, [Out] IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface MGANAECMDED
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	ABFFOHELAGI<KCDOILINLPA, AHOGOONMGAK> DBDKIJILKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	ABFFOHELAGI<BOIHPHGPMPK, GONFFIMNHAP> GGLBCCIPHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	EJKPGJCOMLK DLBAFFIFIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum JEIPKKPGIOH
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface KJJECAACIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKLNLJPEMAI LIJGMGKAKKG(AHOGOONMGAK NFNBKNAJBPN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EJKPGJCOMLK
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOIHPHGPMPK LIJGMGKAKKG(AHOGOONMGAK NFNBKNAJBPN, int OPKLODOCMCI, string? GLGOHIJMLFB, string? HEBADMBACHN, IDBDBALOLAF BABAPBFHKIC, List<FCKBIMABIOA>? GHKFMKIMMNH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DBBJMDENMLB]
internal class OEEEIGOPOMF : KAMFFEAGDEB<KCDOILINLPA, AHOGOONMGAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly HABBFPCILCO CCNONNFOJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly IENCNNOOBDO FGIDJGIJANH;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x79EE550", Offset = "0x79ECD50", VA = "0x1879EE550")]
	public OEEEIGOPOMF(CHALJOLABNG KMBBDAKFJPK, HABBFPCILCO CCNONNFOJHJ, MKCGLADJFFJ MLNADBAMFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x79EE2B0", Offset = "0x79ECAB0", VA = "0x1879EE2B0", Slot = "6")]
	public override AHOGOONMGAK MPBEICGIKAG(KCDOILINLPA JEOEDPICHHI, [Out] IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class DGJCINAMAGL : CHALJOLABNG
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class KLMNBBAKHFA : JsonConverter<EEKGCDPEIHM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x79EE050", Offset = "0x79EC850", VA = "0x1879EE050", Slot = "9")]
		public override void WriteJson(JsonWriter HIKMEOJBJOJ, EEKGCDPEIHM? OPMIAMEJKDH, JsonSerializer KKFPDDCHJNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x79EDF30", Offset = "0x79EC730", VA = "0x1879EDF30", Slot = "10")]
		public override EEKGCDPEIHM ReadJson(JsonReader DMPKKEDJKBJ, Type EAAOLJJLFCF, EEKGCDPEIHM? GIOGNHBBPCP, bool PHAFPMLAABM, JsonSerializer KKFPDDCHJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x79EE0F0", Offset = "0x79EC8F0", VA = "0x1879EE0F0")]
		public KLMNBBAKHFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class IDEJICFGIFM : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool FCKNAMPFKME
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x79EB290", Offset = "0x79E9A90", VA = "0x1879EB290", Slot = "5")]
		public override object ReadJson(JsonReader DMPKKEDJKBJ, Type EAAOLJJLFCF, object? GIOGNHBBPCP, JsonSerializer KKFPDDCHJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x79EAED0", Offset = "0x79E96D0", VA = "0x1879EAED0", Slot = "6")]
		public override bool CanConvert(Type EAAOLJJLFCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x79EB2F0", Offset = "0x79E9AF0", VA = "0x1879EB2F0", Slot = "4")]
		public override void WriteJson(JsonWriter HIKMEOJBJOJ, object? OPMIAMEJKDH, JsonSerializer KKFPDDCHJNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x79EB0B0", Offset = "0x79E98B0", VA = "0x1879EB0B0")]
		private static bool DHMKGGKAIEE(object OPMIAMEJKDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IDEJICFGIFM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly JsonSerializerSettings MOMLNLMLNBB;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x79E7D40", Offset = "0x79E6540", VA = "0x1879E7D40")]
	internal DGJCINAMAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x35D6060", Offset = "0x35D4860", VA = "0x1835D6060", Slot = "4")]
	public string IGBLCOPIJHK<T>(T PNHCNFOFAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x35D60C0", Offset = "0x35D48C0", VA = "0x1835D60C0", Slot = "5")]
	public T OPGKBNPJMEK<T>(string OPMIAMEJKDH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class GPAMJFDHAHL : CHALJOLABNG
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x379D0A0", Offset = "0x379B8A0", VA = "0x18379D0A0", Slot = "4")]
	public string IGBLCOPIJHK<T>(T PNHCNFOFAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x379D120", Offset = "0x379B920", VA = "0x18379D120", Slot = "5")]
	public T OPGKBNPJMEK<T>(string OPMIAMEJKDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GPAMJFDHAHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DBBJMDENMLB]
internal class IENCNNOOBDO : KAMFFEAGDEB<BOIHPHGPMPK, GONFFIMNHAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly CHALJOLABNG KMBBDAKFJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly HABBFPCILCO CCNONNFOJHJ;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x79ED7F0", Offset = "0x79EBFF0", VA = "0x1879ED7F0")]
	public IENCNNOOBDO(CHALJOLABNG KMBBDAKFJPK, HABBFPCILCO CCNONNFOJHJ, MKCGLADJFFJ MLNADBAMFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x79ED1D0", Offset = "0x79EB9D0", VA = "0x1879ED1D0", Slot = "6")]
	public override GONFFIMNHAP MPBEICGIKAG(BOIHPHGPMPK JEOEDPICHHI, [Out] IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x79EC190", Offset = "0x79EA990", VA = "0x1879EC190")]
	internal void EOCMMJPFNCM(string NKNAJHAPOEH, AHOGOONMGAK BAEHAEFCNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x79EC450", Offset = "0x79EAC50", VA = "0x1879EC450")]
	public IEnumerable<KBEFEEFIOCJ> JEFDOMAGOLL(string FKDJADIJPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x79EB3D0", Offset = "0x79E9BD0", VA = "0x1879EB3D0")]
	private IEnumerable<KBEFEEFIOCJ> BEICFMIJNJC(string FKDJADIJPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x79EC500", Offset = "0x79EAD00", VA = "0x1879EC500")]
	internal IEnumerable<KBEFEEFIOCJ> JMAKIHKFBLI(string FKDJADIJPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x79EB7F0", Offset = "0x79E9FF0", VA = "0x1879EB7F0")]
	private KBEFEEFIOCJ BMPPLPLIIKO(AvatarOutfitSelectionData CJLGOEDFGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x79EC950", Offset = "0x79EB150", VA = "0x1879EC950")]
	private void MMNMMHHLPKD(AvatarCustomizationSettingsData INJAAFBBNLJ, AHOGOONMGAK BAEHAEFCNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x79EBB70", Offset = "0x79EA370", VA = "0x1879EBB70")]
	private KBEFEEFIOCJ BMPPLPLIIKO(string JGCHHFBNINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x79EBE90", Offset = "0x79EA690", VA = "0x1879EBE90")]
	internal static (PNLIIGCPIIK, string, string) EFEKDGNKANE(string JGCHHFBNINK, MKCGLADJFFJ MLNADBAMFHP)
	{
		return default((PNLIIGCPIIK, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x79ED5F0", Offset = "0x79EBDF0", VA = "0x1879ED5F0")]
	private JKHHFLAMEIB? NCIMOHMDBIJ(string? BGPPHEMBCAA, Vector2 JBAELAMNKJN, float DMPEMPFKELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x79EC2F0", Offset = "0x79EAAF0", VA = "0x1879EC2F0")]
	private static PNINFJFLLCD GEIAGHBHMDG(AvatarCustomizationSettingsData.AnchorParams FBMHFMJGHMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DBBJMDENMLB]
internal class AMDONBEKBFL : PNIJEFJKGPJ, KJJECAACIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x79E5170", Offset = "0x79E3970", VA = "0x1879E5170")]
	public AMDONBEKBFL(CHALJOLABNG KMBBDAKFJPK, HABBFPCILCO CCNONNFOJHJ, MKCGLADJFFJ MLNADBAMFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x79E4DC0", Offset = "0x79E35C0", VA = "0x1879E4DC0", Slot = "4")]
	public DKLNLJPEMAI LIJGMGKAKKG(AHOGOONMGAK NFNBKNAJBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x79E4A80", Offset = "0x79E3280", VA = "0x1879E4A80")]
	private string HMNFFJMBHGB(AHOGOONMGAK BAEHAEFCNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x79E4B80", Offset = "0x79E3380", VA = "0x1879E4B80")]
	private string LCOPBFPIHAK(KBEFEEFIOCJ NBNEIOPBBLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[DBBJMDENMLB]
internal class KDMHAJGCKIG : KAMFFEAGDEB<BOIHPHGPMPK, GONFFIMNHAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly CHALJOLABNG KMBBDAKFJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly ABFFOHELAGI<BOIHPHGPMPK, GONFFIMNHAP> ELINBNPCLDP;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x79EDE30", Offset = "0x79EC630", VA = "0x1879EDE30")]
	public KDMHAJGCKIG(ABFFOHELAGI<BOIHPHGPMPK, GONFFIMNHAP> ELINBNPCLDP, MKCGLADJFFJ MLNADBAMFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x79EDA00", Offset = "0x79EC200", VA = "0x1879EDA00", Slot = "6")]
	public override GONFFIMNHAP MPBEICGIKAG(BOIHPHGPMPK JEOEDPICHHI, [Out] IReadOnlyList<FCKBIMABIOA>? GHKFMKIMMNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[DBBJMDENMLB]
internal class FMGCEPJOFKG : EJKPGJCOMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly CHALJOLABNG KMBBDAKFJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly KJJECAACIAL EBICCCNHBLC;

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x79E9110", Offset = "0x79E7910", VA = "0x1879E9110")]
	public FMGCEPJOFKG(KJJECAACIAL EBICCCNHBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x79E8D70", Offset = "0x79E7570", VA = "0x1879E8D70", Slot = "4")]
	public BOIHPHGPMPK LIJGMGKAKKG(AHOGOONMGAK NFNBKNAJBPN, int OPKLODOCMCI, string? GLGOHIJMLFB, string? HEBADMBACHN, IDBDBALOLAF BABAPBFHKIC, List<FCKBIMABIOA>? GHKFMKIMMNH)
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
		[Cpp2IlInjected.Address(RVA = "0x79E53A0", Offset = "0x79E3BA0", VA = "0x1879E53A0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BCLDBFPJAEC
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x79E6550", Offset = "0x79E4D50", VA = "0x1879E6550")]
	public static AJELBAFCNLN MPBEICGIKAG(this NKKOFJNNEJE NFNBKNAJBPN)
	{
		return default(AJELBAFCNLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x79E6430", Offset = "0x79E4C30", VA = "0x1879E6430")]
	public static NKKOFJNNEJE LIJGMGKAKKG(this AJELBAFCNLN EJOBCDODHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x79E63D0", Offset = "0x79E4BD0", VA = "0x1879E63D0")]
	public static bool AJAFHBBDOPM(this AJELBAFCNLN EJOBCDODHHF)
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
			[Cpp2IlInjected.Address(RVA = "0x5B7B5E0", Offset = "0x5B79DE0", VA = "0x185B7B5E0")]
			public AnchorParams(Vector2 BMIOGPDPFFN, Vector3 DENCFLNAPGJ, Vector3 EGGHFEMCBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x79E52F0", Offset = "0x79E3AF0", VA = "0x1879E52F0")]
			internal PNINFJFLLCD LIJGMGKAKKG()
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
		private LHGCMFLMCGH useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x79E5B90", Offset = "0x79E4390", VA = "0x1879E5B90")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4F50380", Offset = "0x4F4EB80", VA = "0x184F50380")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xF14BE0", Offset = "0xF133E0", VA = "0x180F14BE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x128EFC0", Offset = "0x128D7C0", VA = "0x18128EFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x79E5C30", Offset = "0x79E4430", VA = "0x1879E5C30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9E4300", Offset = "0x9E2B00", VA = "0x1809E4300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xBD7EF0", Offset = "0xBD66F0", VA = "0x180BD7EF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xBD7E40", Offset = "0xBD6640", VA = "0x180BD7E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9E0BB0", Offset = "0x9DF3B0", VA = "0x1809E0BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x79E5C70", Offset = "0x79E4470", VA = "0x1879E5C70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xDFC260", Offset = "0xDFAA60", VA = "0x180DFC260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1093C70", Offset = "0x1092470", VA = "0x181093C70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x1706430", Offset = "0x1704C30", VA = "0x181706430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9DD210", Offset = "0x9DBA10", VA = "0x1809DD210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9DD220", Offset = "0x9DBA20", VA = "0x1809DD220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x222EB70", Offset = "0x222D370", VA = "0x18222EB70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xE28F40", Offset = "0xE27740", VA = "0x180E28F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA14D70", Offset = "0xA13570", VA = "0x180A14D70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA14DD0", Offset = "0xA135D0", VA = "0x180A14DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9E93E0", Offset = "0x9E7BE0", VA = "0x1809E93E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9E9480", Offset = "0x9E7C80", VA = "0x1809E9480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9E9310", Offset = "0x9E7B10", VA = "0x1809E9310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9E9320", Offset = "0x9E7B20", VA = "0x1809E9320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9E9400", Offset = "0x9E7C00", VA = "0x1809E9400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9E92D0", Offset = "0x9E7AD0", VA = "0x1809E92D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xBCAEE0", Offset = "0xBC96E0", VA = "0x180BCAEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x12B1DD0", Offset = "0x12B05D0", VA = "0x1812B1DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9E9390", Offset = "0x9E7B90", VA = "0x1809E9390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9E9340", Offset = "0x9E7B40", VA = "0x1809E9340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xCAB0D0", Offset = "0xCA98D0", VA = "0x180CAB0D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xE18B30", Offset = "0xE17330", VA = "0x180E18B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x9E71A0", Offset = "0x9E59A0", VA = "0x1809E71A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9E7180", Offset = "0x9E5980", VA = "0x1809E7180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xBF9060", Offset = "0xBF7860", VA = "0x180BF9060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xE28C10", Offset = "0xE27410", VA = "0x180E28C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xC578D0", Offset = "0xC560D0", VA = "0x180C578D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xC53AB0", Offset = "0xC522B0", VA = "0x180C53AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public LHGCMFLMCGH UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xF1CC10", Offset = "0xF1B410", VA = "0x180F1CC10")]
			get
			{
				return default(LHGCMFLMCGH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xF1DB80", Offset = "0xF1C380", VA = "0x180F1DB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xF1E460", Offset = "0xF1CC60", VA = "0x180F1E460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xBB6A70", Offset = "0xBB5270", VA = "0x180BB6A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x79E5C50", Offset = "0x79E4450", VA = "0x1879E5C50")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x79E5C90", Offset = "0x79E4490", VA = "0x1879E5C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x79E5830", Offset = "0x79E4030", VA = "0x1879E5830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		public PNLIIGCPIIK BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private HICLAFCEFNC? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x79E5CB0", Offset = "0x79E44B0", VA = "0x1879E5CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
