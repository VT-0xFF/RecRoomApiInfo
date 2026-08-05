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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x838BB00", Offset = "0x838A100", VA = "0x18838BB00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
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
		[Cpp2IlInjected.Address(RVA = "0x83A5940", Offset = "0x83A3F40", VA = "0x1883A5940", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OEHADFBFMEG]
internal class MBAFIJFLADK : HCGIIOGMDAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct EOAPAAMKJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public MBAFIJFLADK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public KHBAENPMODP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IFMDLBAIGMI PGOIBEMOOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ELLOBOJPDGG AOKNBHAFGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OBFGCNLFAMP PIFCIELOEAF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x838B910", Offset = "0x8389F10", VA = "0x18838B910")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	[UsedImplicitly]
	internal static void ODFKDLKDJJN(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x838B980", Offset = "0x8389F80", VA = "0x18838B980")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MBAFIJFLADK([EDHLHMEHMKO(null)] IFMDLBAIGMI PGOIBEMOOCC, [EDHLHMEHMKO(null)] ELLOBOJPDGG AOKNBHAFGKC, [EDHLHMEHMKO(null)] OBFGCNLFAMP PIFCIELOEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x838AAA0", Offset = "0x83890A0", VA = "0x18838AAA0", Slot = "5")]
	public HBDFLCGDPFO EBPGFDDGNPJ(KHBAENPMODP INLGMINCMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8389F90", Offset = "0x8388590", VA = "0x188389F90", Slot = "4")]
	public HBDFLCGDPFO DANPCDLNOIP(KHBAENPMODP INLGMINCMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8389E80", Offset = "0x8388480", VA = "0x188389E80", Slot = "6")]
	public AOBPEDPLMGH BCLFOLDACHC(HBDFLCGDPFO CDDIADBJAOB, int HGIMHJPBGBB, string? NDIENANOGEK, string? CFKHGNHHJND, FHBEPOAOIND LBOENHPGDNF, List<PBEHPFBHNOE>? PNMPIKDPNBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x838B560", Offset = "0x8389B60", VA = "0x18838B560", Slot = "7")]
	public bool FKHLIJCFDAG(OEMEODNGBLN OIPNDGCMOCE, [Out] HBDFLCGDPFO? CBMCGBCNLPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x838B830", Offset = "0x8389E30", VA = "0x18838B830", Slot = "8")]
	public bool OCIAFMDFPFK(AOBPEDPLMGH NLBMKMJLFNN, [Out] HBDFLCGDPFO? CBMCGBCNLPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x838B7A0", Offset = "0x8389DA0", VA = "0x18838B7A0", Slot = "9")]
	public bool JDMMEBJKLFC(AOBPEDPLMGH NLBMKMJLFNN, [Out] LPOLNBIIPNN? OIPNDGCMOCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA260", Offset = "0x3EC8860", VA = "0x183ECA260")]
	private bool IMOGDAHODOH<TInput, TOutput>(TInput ECBHOIMIBKD, LBBPJNKPCHH<TInput, TOutput> KOLOJCGDPIM, [Out] TOutput? FAKHJBCPGHO) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x838B5F0", Offset = "0x8389BF0", VA = "0x18838B5F0")]
	[CompilerGenerated]
	private JNMJFAICNGJ JBAMPMMLDBE(FaceFeatureType MLPIBMFGLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x838B380", Offset = "0x8389980", VA = "0x18838B380")]
	[CompilerGenerated]
	private JNMJFAICNGJ FEHCPNAMMMJ(FaceFeatureType MLPIBMFGLMC, EOAPAAMKJAL P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OEHADFBFMEG]
internal class EOHALNNGKFH : IFMDLBAIGMI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void LJHBLNNAOAP<in TData>(TData CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HHEPJEIILEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public JNFIHIEEFFB rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MMIIBKEECLM currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public MMIIBKEECLM latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public HHEPJEIILEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8389DE0", Offset = "0x83883E0", VA = "0x188389DE0")]
		internal bool AMCGFNFDDBA(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8389E00", Offset = "0x8388400", VA = "0x188389E00")]
		internal bool IFLKAHPJJFN(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OBFGCNLFAMP PIFCIELOEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KNOKIILHDFE NKJNDBENPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LJHBLNNAOAP<HBDFLCGDPFO>?[] PGOIBEMOOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LJHBLNNAOAP<LPOLNBIIPNN>?[] CEKMKODJFDD;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8389640", Offset = "0x8387C40", VA = "0x188389640")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	[UsedImplicitly]
	internal static void ODFKDLKDJJN(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83896F0", Offset = "0x8387CF0", VA = "0x1883896F0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EOHALNNGKFH([EDHLHMEHMKO(null)] OBFGCNLFAMP PIFCIELOEAF, [EDHLHMEHMKO(null)] KNOKIILHDFE NKJNDBENPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8388DE0", Offset = "0x83873E0", VA = "0x188388DE0", Slot = "4")]
	public bool LFKGDJKGFHE(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8388EE0", Offset = "0x83874E0", VA = "0x188388EE0", Slot = "5")]
	public bool LFKGDJKGFHE(LPOLNBIIPNN OIPNDGCMOCE, IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8387B10", Offset = "0x8386110", VA = "0x188387B10")]
	private void CLNPINGMAOI(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8389320", Offset = "0x8387920", VA = "0x188389320")]
	private void MLFMPGODJMF(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8387AE0", Offset = "0x83860E0", VA = "0x188387AE0")]
	private void ADLDKPFKGED(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8388C60", Offset = "0x8387260", VA = "0x188388C60")]
	private void HGEDILHOAHB(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8388D10", Offset = "0x8387310", VA = "0x188388D10")]
	private void KDNBPPHEIAC(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8388BB0", Offset = "0x83871B0", VA = "0x188388BB0")]
	private void HFCIFHJKONH(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8389550", Offset = "0x8387B50", VA = "0x188389550")]
	private void MODBGCAGDPE(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83896B0", Offset = "0x8387CB0", VA = "0x1883896B0")]
	private void OLDHDEDCBJL(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83896C0", Offset = "0x8387CC0", VA = "0x1883896C0")]
	private void PKHECACJPAJ(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8388C90", Offset = "0x8387290", VA = "0x188388C90")]
	private void HMLLIIADJHE(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? APAPCLFINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83888D0", Offset = "0x8386ED0", VA = "0x1883888D0")]
	private void HEEEBFCLDPC(HBDFLCGDPFO CBMCGBCNLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8389040", Offset = "0x8387640", VA = "0x188389040")]
	private HBDFLCGDPFO LOHCMOCHFDP(HBDFLCGDPFO CBMCGBCNLPB, List<RangeMigration> GDJNFKEOIMF, MMIIBKEECLM DOKANJIKLNF, MMIIBKEECLM NOAKJBHKFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8389600", Offset = "0x8387C00", VA = "0x188389600")]
	private float MPFDEINAMJO(float LMEEEJBAHCF, Vector2 CDKAPKPCIJF, Vector2 AKKKEKGCKOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8388700", Offset = "0x8386D00", VA = "0x188388700")]
	private (RangeMigration?, RangeMigration?) EHNLDAICHCM(List<RangeMigration> KHPALKBMOAD, JNFIHIEEFFB JOECGEDANGP, MMIIBKEECLM DOKANJIKLNF, MMIIBKEECLM NOAKJBHKFNA)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IFMDLBAIGMI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFKGDJKGFHE(HBDFLCGDPFO CBMCGBCNLPB, IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LFKGDJKGFHE(LPOLNBIIPNN OIPNDGCMOCE, IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE);
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
		public HKGDMFKBNJI AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x8385600", Offset = "0x8383C00", VA = "0x188385600")]
		public void KOMDFJAAAJJ(AnimationPoseSetting AAGCKLPFJME, float CGJFHFALEJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8385730", Offset = "0x8383D30", VA = "0x188385730")]
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
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x8386040", Offset = "0x8384640", VA = "0x188386040")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8386000", Offset = "0x8384600", VA = "0x188386000")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8385750", Offset = "0x8383D50", VA = "0x188385750")]
		private void OPGEFNNPPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x830CFB0", Offset = "0x830B5B0", VA = "0x18830CFB0", Slot = "4")]
		public void SetEnabled(bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8386070", Offset = "0x8384670", VA = "0x188386070")]
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
		[Cpp2IlInjected.Address(RVA = "0x83860B0", Offset = "0x83846B0", VA = "0x1883860B0")]
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
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
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
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
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
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
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
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
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
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
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
		[Tooltip("Local offset from pelvis to foot center")]
		[Header("Shoe Settings")]
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
		[Cpp2IlInjected.Address(RVA = "0x8386130", Offset = "0x8384730", VA = "0x188386130")]
		public AnimationPoseSetting NOKFMLPAHFB(HKGDMFKBNJI KGKGEKLCBIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83860F0", Offset = "0x83846F0", VA = "0x1883860F0")]
		public void HAKAIDJFGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8386160", Offset = "0x8384760", VA = "0x188386160")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum BJPHFJBLIND
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private BJPHFJBLIND handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[FormerlySerializedAs("color")]
		[SerializeField]
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
		[Cpp2IlInjected.Address(RVA = "0x8386C70", Offset = "0x8385270", VA = "0x188386C70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8386C30", Offset = "0x8385230", VA = "0x188386C30")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8386610", Offset = "0x8384C10", VA = "0x188386610")]
		private void OPGEFNNPPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x830CFB0", Offset = "0x830B5B0", VA = "0x18830CFB0", Slot = "4")]
		public void SetEnabled(bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8386CA0", Offset = "0x83852A0", VA = "0x188386CA0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, PNAEJBOPKFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private KHBAENPMODP avatarBodyType;

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
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[Header("Configuration")]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private Material modestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		[FormerlySerializedAs("HeadTweakBone")]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private NGEOGCLCLHG FMLBHAEHEKO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NGEOGCLCLHG PIFHMPIGOON
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB80E70", Offset = "0xB7F470", VA = "0x180B80E70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform HCAAIKKCAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8387AC0", Offset = "0x83860C0", VA = "0x188387AC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8386CD0", Offset = "0x83852D0", VA = "0x188386CD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8387980", Offset = "0x8385F80", VA = "0x188387980")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8387930", Offset = "0x8385F30", VA = "0x188387930")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83878C0", Offset = "0x8385EC0", VA = "0x1883878C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8386CD0", Offset = "0x83852D0", VA = "0x188386CD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8387060", Offset = "0x8385660", VA = "0x188387060", Slot = "6")]
		public NGEOGCLCLHG CreateAvatarSystem(string IEFAAKCFKDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83878C0", Offset = "0x8385EC0", VA = "0x1883878C0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8386D90", Offset = "0x8385390", VA = "0x188386D90", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83879D0", Offset = "0x8385FD0", VA = "0x1883879D0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float KJDBPOBDAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OCNHGKIAFHE : NGEOGCLCLHG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class OAJGLMAOHAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 ODBADKLPNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Quaternion JMMALLJPNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Vector3 DEOMGNPGBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Transform NBAKCFIIDNM;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 FPPIDECMDLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x22785A0", Offset = "0x2276BA0", VA = "0x1822785A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x22785C0", Offset = "0x2276BC0", VA = "0x1822785C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion IPDCPJAJFCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x16780A0", Offset = "0x16766A0", VA = "0x1816780A0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1678020", Offset = "0x1676620", VA = "0x181678020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float AEPHFIKAJDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x12CA020", Offset = "0x12C8620", VA = "0x1812CA020")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1A8B1C0", Offset = "0x1A897C0", VA = "0x181A8B1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool OGHEGFOLJJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA5550", Offset = "0xAA3B50", VA = "0x180AA5550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA5500", Offset = "0xAA3B00", VA = "0x180AA5500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool MGJKNFAEJDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAA5630", Offset = "0xAA3C30", VA = "0x180AA5630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5530", Offset = "0xAA3B30", VA = "0x180AA5530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool EHEOEDFBELG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5510", Offset = "0xAA3B10", VA = "0x180AA5510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAA57E0", Offset = "0xAA3DE0", VA = "0x180AA57E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float HOHCBCFJOJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xE36840", Offset = "0xE34E40", VA = "0x180E36840")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xE36390", Offset = "0xE34990", VA = "0x180E36390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x83B0C50", Offset = "0x83AF250", VA = "0x1883B0C50")]
		public void MBJKDGKBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83B06B0", Offset = "0x83AECB0", VA = "0x1883B06B0")]
		public void EEPMFFCAILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83B0A40", Offset = "0x83AF040", VA = "0x1883B0A40")]
		public float KCDHOBCFDEM(Vector3 BGDKDMHJNMI, Quaternion HMDPJLMHHPN, [In] AvatarFootSettings ILFGGLEMFON, float KEJNGBGOHGL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x83AFFD0", Offset = "0x83AE5D0", VA = "0x1883AFFD0")]
		public void DIPLOJOHBAB(Vector3 AGPEFLCJFBB, Quaternion OGCEGKBLAIJ, Transform KNMOPAKLPIL, float BHDMGBKNCOL, bool JEMNJMGNHLD, bool PLHMAADHBKP, float IAEONANCHPA, float GHFCFOKEFEB, Transform BOCNDANOLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83B0810", Offset = "0x83AEE10", VA = "0x1883B0810")]
		public void IOCGAGBCMKB(Transform CEEEGKIFHEG, Transform BOCNDANOLJJ, bool FIFDAEGGIPI, bool BMKDCAAFBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x83B0C80", Offset = "0x83AF280", VA = "0x1883B0C80")]
		private void PLPKMLAEPNK(Transform BOCNDANOLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83B06C0", Offset = "0x83AECC0", VA = "0x1883B06C0")]
		public bool FIHHCNIAOPA(Transform BOCNDANOLJJ, AvatarFullBodyConfiguration GKBHDDGIDDH, Vector3 HNOKDBPGOMK, float GGJEJBFOJCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83B0C60", Offset = "0x83AF260", VA = "0x1883B0C60")]
		public void NACMDLNBADC(float GHFCFOKEFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x83B0D80", Offset = "0x83AF380", VA = "0x1883B0D80")]
		public OAJGLMAOHAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class JIFJPIAMIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private float LMNDCONLGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool KAJFBCJJLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AnimationPoseSetting KLBDOCABJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private float KEEGCKHNPEO;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83AB530", Offset = "0x83A9B30", VA = "0x1883AB530")]
		public void GGKCFGANBMD(IKSolverVR.Arm MFINKNHHBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x83AB050", Offset = "0x83A9650", VA = "0x1883AB050")]
		public void DFEJNCHADJG(IKSolverVR.Arm MFINKNHHBLA, float HMFODCFKMGJ, bool KAJFBCJJLAP, AvatarFullBodyConfiguration GKBHDDGIDDH, float FBIBDLMMIFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83ABDD0", Offset = "0x83AA3D0", VA = "0x1883ABDD0")]
		private void IFMKEOJNHCH(IKSolverVR.Arm MFINKNHHBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83AB560", Offset = "0x83A9B60", VA = "0x1883AB560")]
		public void HCFEDFEAOCB(IKSolverVR.Arm MFINKNHHBLA, Transform OKBPECNOHME, Transform KNMOPAKLPIL, Quaternion DJNNJMFJEEK, Vector3 IEPGHIHEDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x83AB940", Offset = "0x83A9F40", VA = "0x1883AB940")]
		private (Vector3, Quaternion) IDFKJEEPMOG(IJDEGEOEGKG JFFOMPHEAOO, Quaternion HIBPJLEMBGH, Vector3 JPBKENOHIIM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x83ABE10", Offset = "0x83AA410", VA = "0x1883ABE10")]
		public void NCJHJDHEJCC(IJDEGEOEGKG JFFOMPHEAOO, IKSolverVR.Arm MFINKNHHBLA, Quaternion HIBPJLEMBGH, Vector3 JPBKENOHIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x83AC0B0", Offset = "0x83AA6B0", VA = "0x1883AC0B0")]
		public void OPNBFHEKKGC(IJDEGEOEGKG JFFOMPHEAOO, IKSolverVR.Arm MFINKNHHBLA, Quaternion HIBPJLEMBGH, Vector3 JPBKENOHIIM, [In] AvatarFullBodyConfiguration GKBHDDGIDDH, [In] ICIOBEGHHIO HFPFCKAPBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x83ABF70", Offset = "0x83AA570", VA = "0x1883ABF70")]
		public void ONOBLONNJDP(HKGDMFKBNJI ICHHCGEGFAF, AvatarFullBodyConfiguration GKBHDDGIDDH, ICIOBEGHHIO HFPFCKAPBFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x83AB090", Offset = "0x83A9690", VA = "0x1883AB090")]
		public void EJHINHLBFFK(IKSolverVR.Arm MFINKNHHBLA, Transform OKBPECNOHME, Vector3 ADNKCBLMOAP, float HLHHCKCBLGJ, Quaternion GDHHNPNFMAB, Vector3 KMLBLPBNKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x83AC6B0", Offset = "0x83AACB0", VA = "0x1883AC6B0")]
		public JIFJPIAMIGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum AKBIPFFBAMB
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PIALCANBLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct OAKNIJAKIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int KGMCBFJDJCA;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int BBGIKELICJN;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int LAOFOJMGNDL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int DGMBKDKPGMD;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int GKFBPOFIBGH;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int GEEEMCCLKAC;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GLNKLPFLGEJ;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int PIFCBCGPBBE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int FIDAAMAOPLP;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int AJEOAIKCIOC;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int GEMDDCMOEJB;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int BHKCGJHFGAD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int AADKPGLNGAK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int LBEIHLAAALL;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int PPGOFOPHNDJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int HLAIIFIHJMK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int CIJHFKPMLOM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int BGBPCJLIFGH;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int KCOHJECJEKD;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int FFJOFNOFIDK;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int CLNJMMMINMF;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int EPONNLICALE;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int GFOLICPDMND;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int HJGJLCFDLFK;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int HDKMNNGIFIF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int DABNLAONCGG;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int LDJJNLKJFBJ;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int CHAEEICDELO;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int JHGLCKBGGEM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int ECJLFBMILBK;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int EPNNOKJADIL;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int NHJKFDIBBGH;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly Vector3 NPGJIGJNBGH;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int LHFADAJOAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool IODKMKOGHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool CPOGCLOFKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool AFHJIBNNLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool EHMIFNGFAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool ICLHGKFAPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool KOOMEMCOMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Vector3 GDCOKEDHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private string GNGLIHFIFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NGJMPKHEGDC? FEDLNAFAJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private ECECEMFDBGO? FMBGHJNNBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private OKPOGMNNJNF HHFIFICJEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private FOPEDFDPFDB JBBEODNHJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private IJDEGEOEGKG PPJFIDMGLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private IJDEGEOEGKG AHOAKKEGICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool OKEPKCAMGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x291")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool DOGJLGOOPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly ALBDPDEKAJK HGPCMOCEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly IMJIHKCHGKG IICPIAEKPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int FDAJINCFLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private float AIAGHCONNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject OEHLFBLBNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Transform FKOAHPNDIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Transform LLHGKGBIICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Transform MPNAPMOKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform EJEAGKJHCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float FKDNNOBGHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float BCJDCNOHNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Vector3 IPKHDFEPNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Quaternion FCHNNDBFPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Transform JJJIJPFMCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Transform HBHFGNEPCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Transform LFEMGHDGKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private ABMHDCBBMOB HPLGOAEADPP;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker LNIIAEAKEFF;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker OMBHOCEJIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private ProfilerMarker BJFBLDMBDKM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ProfilerMarker GPNJOFNCCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ProfilerMarker NLCIJHLMDMO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly ProfilerMarker BOCMMLGKKBH;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly List<OCNHGKIAFHE> KJIOHHBJAAJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int LJENEFOOIHD;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> KCEMLDGKFEP;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int NDHEPFCJCDE;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int EOAHKMLBLNA;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static int KNMKIBILIDF;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int FAMKEPMGEAI;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float EMBPDEJHCHB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static int BFNOABNJDOD;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float MDEOCNHBJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static float GFGDDJCLHHK;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static float HEODFMNGFGE;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static float KKLNJDBBOCK;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static IECNMOMABAI DCHGKEJLFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float LLFFPOENGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool LELNPLIDCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float JBICNHCBBMN;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly int KBCJPNJGLBG;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly int LGEBDDDDPEH;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly int FDOFNMKMFCI;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly int CJIPIBMEGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private OAJGLMAOHAK PJJEPCHKDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private OAJGLMAOHAK NOBOHFALEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float MAIFBDCDBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 PDLLKKBLNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private Vector3 POKFLCCNIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool HBECMGHIEKA;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly Quaternion OOJACJCEACF;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly Quaternion MBEFLBPFPAN;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly Vector3 EPKGMFMJAIO;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly Vector3 BDIDHIHOMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float BKHLFPIMLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float NKELGNNNMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private JIFJPIAMIGF FBCGEMELALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private JIFJPIAMIGF CPCLONDLIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private FIMLAIBFKOJ NJMAIEKCBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private HFOEMHICCOM DFFNGJKMOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly JNOAKFGFFHF EDNKGLPDCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float PJNCOJFNLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float CIKBGBHLLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly HFOEMHICCOM KJBBFLOKHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private Vector3 MAJIKEMBDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Vector3 NDJDAFCHOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private float OMPOOMPOBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private float JFNNHDOIPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly HFOEMHICCOM MOLHKLBALON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly FIMLAIBFKOJ HDINFCCNMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly HFOEMHICCOM OOCDHKHJBBM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HLLOFHFLNHG BMDKLCEKKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HLLOFHFLNHG HLKEFJICPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration KMINAOBEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x839DB60", Offset = "0x839C160", VA = "0x18839DB60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KHBAENPMODP KEECKLLMACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x839E2E0", Offset = "0x839C8E0", VA = "0x18839E2E0", Slot = "24")]
		get
		{
			return default(KHBAENPMODP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration JHHEHOJMPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x838BB80", Offset = "0x838A180", VA = "0x18838BB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform OILGNCDLGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x839C820", Offset = "0x839AE20", VA = "0x18839C820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform NOLHFEGOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x838E840", Offset = "0x838CE40", VA = "0x18838E840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer JMPNCCMLHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x838C2C0", Offset = "0x838A8C0", VA = "0x18838C2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] CEENLDKPCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x838D700", Offset = "0x838BD00", VA = "0x18838D700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] CPFFHFJLAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8399890", Offset = "0x8397E90", VA = "0x188399890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator GDLJBDCHOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x839E5C0", Offset = "0x839CBC0", VA = "0x18839E5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK LIDLKKHCHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x839C930", Offset = "0x839AF30", VA = "0x18839C930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private ECBPBNMJDJF JHPBCLPDGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83997C0", Offset = "0x8397DC0", VA = "0x1883997C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private ECBPBNMJDJF FBIEEDNFJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83A42A0", Offset = "0x83A28A0", VA = "0x1883A42A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private ECBPBNMJDJF NFJOBPPJIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8397670", Offset = "0x8395C70", VA = "0x188397670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private ECBPBNMJDJF MGIPDMGMFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83A4750", Offset = "0x83A2D50", VA = "0x1883A4750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private ECBPBNMJDJF EKBMDBBIIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x83A05E0", Offset = "0x839EBE0", VA = "0x1883A05E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private ECBPBNMJDJF EPCCDFPHIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83989A0", Offset = "0x8396FA0", VA = "0x1883989A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private ECBPBNMJDJF NJODHFJOIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8398C10", Offset = "0x8397210", VA = "0x188398C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private ECBPBNMJDJF KOFLNAFNAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8395B70", Offset = "0x8394170", VA = "0x188395B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ECECEMFDBGO FAONJMPCLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x838D5F0", Offset = "0x838BBF0", VA = "0x18838D5F0", Slot = "16")]
		get
		{
			return default(ECECEMFDBGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EEDAILNAJPO GCIKGFAOGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC39AC0", VA = "0x180C3B4C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public NCFHMNIFFNK KBAFMJLOMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4B0", Offset = "0xC39AB0", VA = "0x180C3B4B0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GDGKEFFDPOH HNDCHFIGPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4D0", Offset = "0xC39AD0", VA = "0x180C3B4D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GDGKEFFDPOH OJFIAGIEMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4A0", Offset = "0xC39AA0", VA = "0x180C3B4A0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string NPCMGBMOJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform JCPHJNPOBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83A07A0", Offset = "0x839EDA0", VA = "0x1883A07A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform JDLBABNLBDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8397CE0", Offset = "0x83962E0", VA = "0x188397CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform GIEJFPPJKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x839D960", Offset = "0x839BF60", VA = "0x18839D960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform JPCDCFEPAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x839CAA0", Offset = "0x839B0A0", VA = "0x18839CAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform PECLAEHADKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x839C8F0", Offset = "0x839AEF0", VA = "0x18839C8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool KLMKAMHMCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8390CF0", Offset = "0x838F2F0", VA = "0x188390CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool FIOHGOMLJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8390CF0", Offset = "0x838F2F0", VA = "0x188390CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KEHPOPGBKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x839E1F0", Offset = "0x839C7F0", VA = "0x18839E1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform EOLECBHCFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8394090", Offset = "0x8392690", VA = "0x188394090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject JJEACKINPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83A06B0", Offset = "0x839ECB0", VA = "0x1883A06B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets EFGGLFMNPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8390C70", Offset = "0x838F270", VA = "0x188390C70", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform PKBJIKJANFO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB0B1F0", Offset = "0xB097F0", VA = "0x180B0B1F0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform GPKIECHAFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBBB310", Offset = "0xBB9910", VA = "0x180BBB310", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform ABLFCDLMIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xBBB4A0", Offset = "0xBB9AA0", VA = "0x180BBB4A0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform IPIFFBOAKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBBB420", Offset = "0xBB9A20", VA = "0x180BBB420", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 FIBJHMMAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8395600", Offset = "0x8393C00", VA = "0x188395600", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float DCKAJKCMAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x839CA50", Offset = "0x839B050", VA = "0x18839CA50", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform OBBMNAPMIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x838D450", Offset = "0x838BA50", VA = "0x18838D450", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform IKAGPJEKOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x22DD310", Offset = "0x22DB910", VA = "0x1822DD310", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform MIKHLHEDDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBBB2F0", Offset = "0xBB98F0", VA = "0x180BBB2F0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform BEMLJBNHEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x29693B0", Offset = "0x29679B0", VA = "0x1829693B0", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool FPAEDKHAGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83A3960", Offset = "0x83A1F60", VA = "0x1883A3960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PKBDHHCMFJK<NGEOGCLCLHG.CIDBJHEEFAG> DHNPOHFHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x839E820", Offset = "0x839CE20", VA = "0x18839E820", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool MFOBOJCNBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8391380", Offset = "0x838F980", VA = "0x188391380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool CBHBMJGIICE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x839BF80", Offset = "0x839A580", VA = "0x18839BF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x839C800", Offset = "0x839AE00", VA = "0x18839C800")]
	private float KAHNJGIEACK(LGJDABNAAJF AIIFFCAOIMO, float BNNLEKILPFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x83A1B80", Offset = "0x83A0180", VA = "0x1883A1B80")]
	private void PBHPALOCNBL([In] ICIOBEGHHIO FGBDNPDDMMO, [In] AvatarFullBodyConfiguration GKBHDDGIDDH, bool KJAPAGJOAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x839E790", Offset = "0x839CD90", VA = "0x18839E790")]
	private float MMFHMHHOMML([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x83A1B00", Offset = "0x83A0100", VA = "0x1883A1B00")]
	private float PBDEPJEJKLK([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8395C40", Offset = "0x8394240", VA = "0x188395C40")]
	private void GCABELHDNFC(ICIOBEGHHIO FGBDNPDDMMO, AvatarFullBodyConfiguration GKBHDDGIDDH, bool KJAPAGJOAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x839FFA0", Offset = "0x839E5A0", VA = "0x18839FFA0")]
	private void NFLMLJJLCDI([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x839E690", Offset = "0x839CC90", VA = "0x18839E690")]
	private void MLMOENIFGCI([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83A5440", Offset = "0x83A3A40", VA = "0x1883A5440")]
	public OCNHGKIAFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83A3DA0", Offset = "0x83A23A0", VA = "0x1883A3DA0", Slot = "13")]
	public void PJLHGGDMNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8390D40", Offset = "0x838F340", VA = "0x188390D40", Slot = "14")]
	public void DLIDACJHEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x839E480", Offset = "0x839CA80", VA = "0x18839E480", Slot = "15")]
	public void MJGJJFCNKKK(bool MEOHIAPHNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x838C390", Offset = "0x838A990", VA = "0x18838C390", Slot = "26")]
	public Transform AHNLHDKFCFI(string AOLGENGICKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x83944F0", Offset = "0x8392AF0", VA = "0x1883944F0", Slot = "27")]
	public Vector3? EMDGANNGDPD(string AOLGENGICKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x839D2C0", Offset = "0x839B8C0", VA = "0x18839D2C0", Slot = "7")]
	public void LMNEIDKMMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8394FB0", Offset = "0x83935B0", VA = "0x188394FB0")]
	private void FEHLHGKNIDG(AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8390040", Offset = "0x838E640", VA = "0x188390040", Slot = "8")]
	public void DDPJAALGMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x83A07F0", Offset = "0x839EDF0", VA = "0x1883A07F0")]
	private void OIHPEAGFDGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x83A0410", Offset = "0x839EA10", VA = "0x1883A0410")]
	private Vector3 NHKNCFPNGBJ([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x83937C0", Offset = "0x8391DC0", VA = "0x1883937C0", Slot = "6")]
	public void EGALOBAFNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8398CE0", Offset = "0x83972E0", VA = "0x188398CE0")]
	private void IKHNCAIMBMH(bool KJAPAGJOAMI, AKBIPFFBAMB AFAFAFDPHBH, AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x839CF60", Offset = "0x839B560", VA = "0x18839CF60", Slot = "9")]
	public void LKFJEKDMJNN(float AOFJADJGDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x83A0590", Offset = "0x839EB90", VA = "0x1883A0590")]
	private void NHOKCOFOMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8399E30", Offset = "0x8398430", VA = "0x188399E30", Slot = "4")]
	public void JKAHBGJFLII(string IEFAAKCFKDD, NGJMPKHEGDC AEFAFHAIJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x839CAE0", Offset = "0x839B0E0", VA = "0x18839CAE0", Slot = "5")]
	public void LFLPPBMHPME(ECECEMFDBGO GIIEKBECBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x838BC10", Offset = "0x838A210", VA = "0x18838BC10", Slot = "12")]
	public void ADPINCMEABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8394160", Offset = "0x8392760", VA = "0x188394160", Slot = "25")]
	public void ELPDPOCLKAL([Out] Vector3 IOEJLLGHEJH, [Out] Quaternion GDHHNPNFMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x838C290", Offset = "0x838A890", VA = "0x18838C290")]
	private void AGKDKPOAOLA([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x838D7D0", Offset = "0x838BDD0", VA = "0x18838D7D0", Slot = "28")]
	public void BKJNNODOLLA(float MDDJPADLPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x83A3A50", Offset = "0x83A2050", VA = "0x1883A3A50", Slot = "29")]
	public void PFGJFOGPKBE(float FEEPNABPPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8397C90", Offset = "0x8396290", VA = "0x188397C90", Slot = "46")]
	public void IAFFOJFGIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x838D5A0", Offset = "0x838BBA0", VA = "0x18838D5A0", Slot = "30")]
	public void BEJNAPAJPEM(bool OODHOCAKIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x839CA00", Offset = "0x839B000", VA = "0x18839CA00", Slot = "31")]
	public HandLogicOffsets KPDBBHPPEJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x838D4E0", Offset = "0x838BAE0", VA = "0x18838D4E0", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets BANMBHAGLAK()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x839E550", Offset = "0x839CB50", VA = "0x18839E550")]
	private void MJMKPLJMKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8396300", Offset = "0x8394900", VA = "0x188396300")]
	private void GKFKHHDGPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x839DC30", Offset = "0x839C230", VA = "0x18839DC30")]
	private void MCOHGGAIFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x83A12F0", Offset = "0x839F8F0", VA = "0x1883A12F0")]
	private void ONKNAPCOOJM(OCHLPLCDEOP ILOLJOKDOJK, bool NNOFAGIMANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x83974F0", Offset = "0x8395AF0", VA = "0x1883974F0")]
	private void HGEEPICGIAH(OCHLPLCDEOP ILOLJOKDOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x83962B0", Offset = "0x83948B0", VA = "0x1883962B0")]
	public Vector3 GHDBIDIKCOC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x839CFD0", Offset = "0x839B5D0", VA = "0x18839CFD0")]
	private void LLCPGLLKIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x838CA20", Offset = "0x838B020", VA = "0x18838CA20")]
	private void ANNACFKIBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x838F9A0", Offset = "0x838DFA0", VA = "0x18838F9A0")]
	private void DCEJFEPIHME(ICIOBEGHHIO FGBDNPDDMMO, AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x838C8A0", Offset = "0x838AEA0", VA = "0x18838C8A0")]
	private float AKIMMJOGIGD([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x83A4820", Offset = "0x83A2E20", VA = "0x1883A4820")]
	private int PPDGACOPPAP([In] NGBNAMPGCGO MJNFCKJHEKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x83A15D0", Offset = "0x839FBD0", VA = "0x1883A15D0")]
	private void OPKLCFDJIPO(ICIOBEGHHIO FGBDNPDDMMO, bool NBAHJNPCBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8394690", Offset = "0x8392C90", VA = "0x188394690")]
	private static void EPEAJIOKJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x83967F0", Offset = "0x8394DF0", VA = "0x1883967F0")]
	private static void HEFPAOPNMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x839D990", Offset = "0x839BF90", VA = "0x18839D990")]
	private float LOOLBIPPJDJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x838D4B0", Offset = "0x838BAB0", VA = "0x18838D4B0")]
	private static int APPHELOGEMM(OCNHGKIAFHE NEOIFOEJGFD, OCNHGKIAFHE KNACFLNMNOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8395850", Offset = "0x8393E50", VA = "0x188395850", Slot = "41")]
	public ICIOBEGHHIO FMICMIOBNJD()
	{
		return default(ICIOBEGHHIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x83977E0", Offset = "0x8395DE0", VA = "0x1883977E0")]
	private bool HPGBLFDPGLH(int NMILEMOAODL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8396480", Offset = "0x8394A80", VA = "0x188396480")]
	public void GPHKPICDPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x83A08F0", Offset = "0x839EEF0", VA = "0x1883A08F0")]
	private (bool, bool) OIMAHFCHEIA()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x83911A0", Offset = "0x838F7A0", VA = "0x1883911A0")]
	private (float, float) DOCBGJOPJMO([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8391590", Offset = "0x838FB90", VA = "0x188391590")]
	private void EAJOGGJAMFI([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8399960", Offset = "0x8397F60", VA = "0x188399960")]
	private void JFPHJJACHGJ([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x839BB60", Offset = "0x839A160", VA = "0x18839BB60")]
	private void JLMKBLLLCMG([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH, AvatarFootSettings ILFGGLEMFON, bool KHPJPHKIGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x83A0390", Offset = "0x839E990", VA = "0x1883A0390")]
	private float NGGCNJHKJMM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x839F0C0", Offset = "0x839D6C0", VA = "0x18839F0C0")]
	private void NCININBOAAG(ICIOBEGHHIO HFPFCKAPBFI, AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x83A0750", Offset = "0x839ED50", VA = "0x1883A0750")]
	private float OEGODNFMFIK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x83939C0", Offset = "0x8391FC0", VA = "0x1883939C0")]
	private void EIEHELJKDLP([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8396500", Offset = "0x8394B00", VA = "0x188396500")]
	private void HCFEDFEAOCB([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8397890", Offset = "0x8395E90", VA = "0x188397890")]
	private void IADNDKNOKII([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8396020", Offset = "0x8394620", VA = "0x188396020")]
	private void GFLLLELCHCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x83A4370", Offset = "0x83A2970", VA = "0x1883A4370")]
	private void PKJOINFBALJ(float ADGJEOBLOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8391400", Offset = "0x838FA00", VA = "0x188391400")]
	private void DPCFKMPDHHG([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x83933E0", Offset = "0x83919E0", VA = "0x1883933E0")]
	private void EEMACOGFCHL(IJDEGEOEGKG BMEKACOPEEE, IKSolverVR.Arm MFINKNHHBLA, Transform DDLFAFBEIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x838DC40", Offset = "0x838C240", VA = "0x18838DC40")]
	private void CCFCEDBDPDB(ICIOBEGHHIO HFPFCKAPBFI, AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x83959A0", Offset = "0x8393FA0", VA = "0x1883959A0")]
	private void FPJACBNHIJG(EDBKBGPGKEK BFJFNOCLPGD, GDGKEFFDPOH BMEKACOPEEE, IKSolverVR.Arm MFINKNHHBLA, float HMFODCFKMGJ, float IFDGOFLLDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8393E80", Offset = "0x8392480", VA = "0x188393E80")]
	private void EJKCFANCHIG([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x838EBA0", Offset = "0x838D1A0", VA = "0x18838EBA0")]
	private void CLJFAGJJOME([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x838C4E0", Offset = "0x838AAE0", VA = "0x18838C4E0")]
	protected void AIABGAGDNIH([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x838D8F0", Offset = "0x838BEF0", VA = "0x18838D8F0")]
	private void BNJMPBICMJN([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8395DD0", Offset = "0x83943D0", VA = "0x188395DD0")]
	protected void GEGJEDGANFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x83A0AD0", Offset = "0x839F0D0", VA = "0x1883A0AD0")]
	private void OMEFKHJHCID([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AKBIPFFBAMB AFAFAFDPHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x839E040", Offset = "0x839C640", VA = "0x18839E040")]
	private void MEFJKAPEGIM(ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x839E580", Offset = "0x839CB80", VA = "0x18839E580")]
	private void MJMLHLOHHAJ([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x838BD70", Offset = "0x838A370", VA = "0x18838BD70")]
	private Vector3 AGDIAKEJANC([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x839E3B0", Offset = "0x839C9B0", VA = "0x18839E3B0")]
	private void MIODMGHFLOE([In] ICIOBEGHHIO HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x839EC70", Offset = "0x839D270", VA = "0x18839EC70")]
	private float NCHLEDHAEFO(float GHFCFOKEFEB, [In] ICIOBEGHHIO HFPFCKAPBFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8393670", Offset = "0x8391C70", VA = "0x188393670")]
	private void EFAACPJHLGK(float GHFCFOKEFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x83948C0", Offset = "0x8392EC0", VA = "0x1883948C0")]
	private void FDEBJEIFHHD([In] ICIOBEGHHIO HFPFCKAPBFI, AKBIPFFBAMB AFAFAFDPHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x838F1A0", Offset = "0x838D7A0", VA = "0x18838F1A0")]
	private float CNPHDJPOABM([In] ICIOBEGHHIO FGBDNPDDMMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x839C000", Offset = "0x839A600", VA = "0x18839C000")]
	private void JPBGAMFKMBD(ICIOBEGHHIO HFPFCKAPBFI, AKBIPFFBAMB AFAFAFDPHBH, Vector3 DHFENGHPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8399C80", Offset = "0x8398280", VA = "0x188399C80")]
	private static void JGACLMOGNMO(Transform CCHLCEHOKAD, Quaternion LDAEEKEKDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x83994C0", Offset = "0x8397AC0", VA = "0x1883994C0")]
	private void IMNMMLLIKMC([In] ICIOBEGHHIO EJNPFBPOPCO, [In] NGBNAMPGCGO MJNFCKJHEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x838E100", Offset = "0x838C700", VA = "0x18838E100")]
	private void CENLIEAKFAA([In] ICIOBEGHHIO EJNPFBPOPCO, [In] NGBNAMPGCGO MJNFCKJHEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x83931F0", Offset = "0x83917F0", VA = "0x1883931F0")]
	private void EDGNHEBJHLJ(float HADGEBHBENI, [In] ICIOBEGHHIO FGBDNPDDMMO, float MCFAMJBKJCK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8397D20", Offset = "0x8396320", VA = "0x188397D20")]
	private float IDGOCJLDIOG([In] ICIOBEGHHIO FGBDNPDDMMO, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x83A3670", Offset = "0x83A1C70", VA = "0x1883A3670")]
	private void PBHPMNNCNON([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x838CA40", Offset = "0x838B040", VA = "0x18838CA40")]
	private void APGIBIALJKA([In] ICIOBEGHHIO FGBDNPDDMMO, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x839D590", Offset = "0x839BB90", VA = "0x18839D590")]
	private void LNHBMKPALDL([In] ICIOBEGHHIO FGBDNPDDMMO, float OHIPMEOABGF, float OLJPHBBDBEG, Vector3 HGNFECOMFGN, float MCFAMJBKJCK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8390280", Offset = "0x838E880", VA = "0x188390280")]
	private void DEBIICMKCMO(ICIOBEGHHIO FGBDNPDDMMO, AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x838E910", Offset = "0x838CF10", VA = "0x18838E910")]
	private void CIFAOHHGMPI(ICIOBEGHHIO HFPFCKAPBFI, AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x83984E0", Offset = "0x8396AE0", VA = "0x1883984E0")]
	private void IEINNPFOELM(ICIOBEGHHIO FGBDNPDDMMO, AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8395690", Offset = "0x8393C90", VA = "0x188395690")]
	public void FJPOPJPALGF([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x839FC40", Offset = "0x839E240", VA = "0x18839FC40")]
	public void NEIBEEMPFJJ([In] ICIOBEGHHIO HFPFCKAPBFI, [In] AvatarFullBodyConfiguration GKBHDDGIDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8398A70", Offset = "0x8397070", VA = "0x188398A70")]
	[CompilerGenerated]
	internal static void IHBKBLHPPLC(Transform PPEFJKBNOEP, IKSolverVR.Arm MFINKNHHBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x83910F0", Offset = "0x838F6F0", VA = "0x1883910F0")]
	[CompilerGenerated]
	internal static void DNFFCKCNBOI(Vector3 BAPIJJOCPIO, Vector3 FHDNMMJMDPO, PIALCANBLPO P_2, OAKNIJAKIIB P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8397740", Offset = "0x8395D40", VA = "0x188397740")]
	[CompilerGenerated]
	internal static void HMJKNMDIEKC(OAJGLMAOHAK AKBNCBEKCBE, OAJGLMAOHAK MDDEGPEGACE, Vector3 FHJMLEPMHHD, float DAANGKEHOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x838D7E0", Offset = "0x838BDE0", VA = "0x18838D7E0")]
	[CompilerGenerated]
	internal static bool BMCHFDEDJAH(IKSolverVR.Arm MFINKNHHBLA, HJFJANIPPKA IHKHMPACMNB, float GMNPFFOAOJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x839E830", Offset = "0x839CE30", VA = "0x18839E830")]
	[CompilerGenerated]
	internal static float NBPPCEBLECN(Vector3 IGGOLCIMMJO, Vector3 NECFGOBFDNB, Vector3 ICJMHLPGAKI, ICIOBEGHHIO FGBDNPDDMMO, AvatarFullBodyConfiguration GKBHDDGIDDH, float PIOCNHLFCNE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class MCPBKDLECMJ : BGEKLNMEPOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Dictionary<string, NGEOGCLCLHG> MGOIJECNNGH;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x83AEC70", Offset = "0x83AD270", VA = "0x1883AEC70")]
	[EGNICHGEFDG.KHJDAJHJKCM]
	internal static void FGDEEKANGEJ(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x83AF000", Offset = "0x83AD600", VA = "0x1883AF000", Slot = "4")]
	public NGEOGCLCLHG NDGKHENADDJ(string MALIJOPLNPC, AvatarSystemConfiguration EEBLDHEHFBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x83AEE20", Offset = "0x83AD420", VA = "0x1883AEE20", Slot = "5")]
	public void MFBEIJOHHFK(string MALIJOPLNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x83AECE0", Offset = "0x83AD2E0", VA = "0x1883AECE0", Slot = "6")]
	public string LILGKGOPKIH(string APJLABGDCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x83AEC00", Offset = "0x83AD200", VA = "0x1883AEC00")]
	private string FBGFLHCBGEP(string APJLABGDCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x83AF220", Offset = "0x83AD820", VA = "0x1883AF220")]
	public MCPBKDLECMJ()
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
		public class JPGKDDEDMDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private Dictionary<string, Transform> HHPILCLIHJM;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool DEKPKOANCAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x83ACBD0", Offset = "0x83AB1D0", VA = "0x1883ACBD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x83ACC60", Offset = "0x83AB260", VA = "0x1883ACC60")]
			public void PMGFFGKPFJL(VRIK BNKLIGPIPAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
			public void IENICAMNGAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x83ACC10", Offset = "0x83AB210", VA = "0x1883ACC10")]
			public void JGIFDBJEMCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x83ACD90", Offset = "0x83AB390", VA = "0x1883ACD90")]
			public JPGKDDEDMDB()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[DECECLMOCEO(GJFENOMGFMJ.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[OOBMCMDIFDG(GJFENOMGFMJ.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly JPGKDDEDMDB JPCIOJLOLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private PNAEJBOPKFD MJEDLMIEAIE;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83A6F00", Offset = "0x83A5500", VA = "0x1883A6F00")]
		private void BDBKJLHAGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83A71E0", Offset = "0x83A57E0", VA = "0x1883A71E0")]
		private bool INGDCABEKNF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x83A7230", Offset = "0x83A5830", VA = "0x1883A7230")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83A72A0", Offset = "0x83A58A0", VA = "0x1883A72A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x83A7240", Offset = "0x83A5840", VA = "0x1883A7240")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83A7510", Offset = "0x83A5B10", VA = "0x1883A7510")]
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
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x83A89C0", Offset = "0x83A6FC0", VA = "0x1883A89C0")]
			public (float, float) ACAMJOFCNKP(float KBKLPEMHNOK)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x83A81F0", Offset = "0x83A67F0", VA = "0x1883A81F0")]
			public void HAKAIDJFGEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x83A80B0", Offset = "0x83A66B0", VA = "0x1883A80B0")]
			public (float, float) GLMEDDADCKM(Animator MOFNIGFMLOB, AnimatorStateInfo KOFBMGFAJHA)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83A8770", Offset = "0x83A6D70", VA = "0x1883A8770")]
		public void HAKAIDJFGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83A8530", Offset = "0x83A6B30", VA = "0x1883A8530")]
		public (float, float) GEHJLNHLKNL(Animator MOFNIGFMLOB, LGJDABNAAJF AIIFFCAOIMO, float HLNAKGNKNGB)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83A82D0", Offset = "0x83A68D0", VA = "0x1883A82D0")]
		private (float, float) EIBBHPAIEHK(Animator MOFNIGFMLOB, AnimatorStateInfo KOFBMGFAJHA, LGJDABNAAJF AIIFFCAOIMO, float HLNAKGNKNGB)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83A89B0", Offset = "0x83A6FB0", VA = "0x1883A89B0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x83AF7B0", Offset = "0x83ADDB0", VA = "0x1883AF7B0", Slot = "4")]
		public override void OnStateEnter(Animator MOFNIGFMLOB, AnimatorStateInfo KOFBMGFAJHA, int MEKEHCNHBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x83AF920", Offset = "0x83ADF20", VA = "0x1883AF920")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class JGJAOOIJNNH<TInput, TOutput> : LBBPJNKPCHH<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	protected readonly KNOKIILHDFE NKJNDBENPHK;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x54C2B00", Offset = "0x54C1100", VA = "0x1854C2B00")]
	protected JGJAOOIJNNH(KNOKIILHDFE NKJNDBENPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput LPNJIHLFELG(TInput ECBHOIMIBKD, [Out] IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x54C2A60", Offset = "0x54C1060", VA = "0x1854C2A60", Slot = "5")]
	public bool IMOGDAHODOH(TInput ECBHOIMIBKD, [Out] TOutput? FAKHJBCPGHO, [Out] IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[OEHADFBFMEG]
public static class CHDKLGDNNNH
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly Regex GCABFCGPCAM;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x83A78A0", Offset = "0x83A5EA0", VA = "0x1883A78A0")]
	public static PBGFHHLAMII OKJFBGEJACI(EPGMAHLDJMC BNHFGDNPPPD, DHFMHNGLGMC MJCJHJGEDBM, Guid? EJKPIOAFAKI, Color? FLOMOMJEEDP, APMGGBJHHPH HODHODILEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x83A75F0", Offset = "0x83A5BF0", VA = "0x1883A75F0")]
	public static GIJENBMJDLP DBGCDOEDDAP(PBGFHHLAMII CDDIADBJAOB)
	{
		return default(GIJENBMJDLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC800", Offset = "0x3BDAE00", VA = "0x183BDC800")]
	internal static TModern? PDKMNKIDBBO<TModern>(string? ECBHOIMIBKD, FMNKFJKCOEF<TModern> PNLNGPHLDCD, KNOKIILHDFE NKJNDBENPHK, DLLEIEDPHPL JIFAACMLGCL, TModern FLEBBJBABPN) where TModern : struct, CCOONKOMFAG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3BDB210", Offset = "0x3BD9810", VA = "0x183BDB210")]
	internal static MDHNGOEKFHC AJDABDGHIEH<TModern>(string? ECBHOIMIBKD, FMNKFJKCOEF<TModern> PNLNGPHLDCD, KNOKIILHDFE NKJNDBENPHK, DLLEIEDPHPL JIFAACMLGCL, TModern FLEBBJBABPN) where TModern : struct, CCOONKOMFAG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x83A7750", Offset = "0x83A5D50", VA = "0x1883A7750")]
	internal static List<PBEHPFBHNOE> FPPFBODEFDO(IEnumerable<FCODANHLAOJ>? DOAMIEOFGPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3BDB980", Offset = "0x3BD9F80", VA = "0x183BDB980")]
	internal static string HJIBACEDBBP<TModern>(TModern ECBHOIMIBKD, FMNKFJKCOEF<TModern> PNLNGPHLDCD, KNOKIILHDFE NKJNDBENPHK) where TModern : CCOONKOMFAG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class PHEHLIDBBEM : ELLOBOJPDGG
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LBBPJNKPCHH<OEMEODNGBLN, HBDFLCGDPFO> EPAEJNGOANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LBBPJNKPCHH<AOBPEDPLMGH, LPOLNBIIPNN> HAGPFMIGKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public LBBPJNKPCHH<AOBPEDPLMGH, LPOLNBIIPNN> BCJEGLMCAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FEFEGEOJFCF BHEHCPPPPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public LBIEONEFADB INKEBFADCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x83B0D90", Offset = "0x83AF390", VA = "0x1883B0D90")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	[UsedImplicitly]
	internal static void ODFKDLKDJJN(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x83B0E00", Offset = "0x83AF400", VA = "0x1883B0E00")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PHEHLIDBBEM([EDHLHMEHMKO("UnitySerialization")] CAACNOBEDGL FNPABBPGEBM, [EDHLHMEHMKO(null)] HPEMFPFEPIB NOMJKLKJDBD, [EDHLHMEHMKO(null)] KNOKIILHDFE NKJNDBENPHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum KDECCIIFMNC
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FLBBPHCBIIL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x83A8020", Offset = "0x83A6620", VA = "0x1883A8020")]
	public FLBBPHCBIIL(string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x83A8080", Offset = "0x83A6680", VA = "0x1883A8080")]
	public FLBBPHCBIIL(string GKNICJPCIJJ, Exception KJLAGGDJKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x83A8050", Offset = "0x83A6650", VA = "0x1883A8050")]
	public FLBBPHCBIIL(KDECCIIFMNC JEKPMBEJDGB, string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x83A7FE0", Offset = "0x83A65E0", VA = "0x1883A7FE0")]
	public FLBBPHCBIIL(KDECCIIFMNC JEKPMBEJDGB, string GKNICJPCIJJ, Exception KJLAGGDJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class KPHFAINOGDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly CAACNOBEDGL FNPABBPGEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected readonly HPEMFPFEPIB NOMJKLKJDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	protected readonly KNOKIILHDFE NKJNDBENPHK;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x83A6360", Offset = "0x83A4960", VA = "0x1883A6360")]
	protected KPHFAINOGDH(CAACNOBEDGL FNPABBPGEBM, HPEMFPFEPIB NOMJKLKJDBD, KNOKIILHDFE NKJNDBENPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x83AD5D0", Offset = "0x83ABBD0", VA = "0x1883AD5D0")]
	protected string JGGKCODJJPL(HBDFLCGDPFO CBMCGBCNLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x83AD3E0", Offset = "0x83AB9E0", VA = "0x1883AD3E0")]
	protected string FNPHKFDGIEB(HBDFLCGDPFO CBMCGBCNLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x83AE8D0", Offset = "0x83ACED0", VA = "0x1883AE8D0")]
	private AvatarOutfitSelectionData OKJFBGEJACI(PBGFHHLAMII ABFFGEEFIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x83AD2A0", Offset = "0x83AB8A0", VA = "0x1883AD2A0")]
	private static AvatarCustomizationSettingsData.AnchorParams AIIACECEMAL(FKKFOGDLKNE? HDLCOAOKNBE)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LBBPJNKPCHH<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput LPNJIHLFELG(TInput ECBHOIMIBKD, [Out] IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMOGDAHODOH(TInput ECBHOIMIBKD, [Out] TOutput? FAKHJBCPGHO, [Out] IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface ELLOBOJPDGG
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LBBPJNKPCHH<OEMEODNGBLN, HBDFLCGDPFO> EPAEJNGOANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	LBBPJNKPCHH<AOBPEDPLMGH, LPOLNBIIPNN> BCJEGLMCAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FEFEGEOJFCF BHEHCPPPPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum DLLEIEDPHPL
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LBIEONEFADB
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJNOEABBLAB ANHNANMIGBP(HBDFLCGDPFO CDDIADBJAOB);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FEFEGEOJFCF
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOBPEDPLMGH ANHNANMIGBP(HBDFLCGDPFO CDDIADBJAOB, int HGIMHJPBGBB, string? NDIENANOGEK, string? CFKHGNHHJND, FHBEPOAOIND LBOENHPGDNF, List<PBEHPFBHNOE>? PNMPIKDPNBE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[OEHADFBFMEG]
internal class KGLCFPFICFM : JGJAOOIJNNH<OEMEODNGBLN, HBDFLCGDPFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly HPEMFPFEPIB NOMJKLKJDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly JHLLLPJIIPJ ICEINGIJPIF;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x83AD0D0", Offset = "0x83AB6D0", VA = "0x1883AD0D0")]
	public KGLCFPFICFM(CAACNOBEDGL FNPABBPGEBM, HPEMFPFEPIB NOMJKLKJDBD, KNOKIILHDFE NKJNDBENPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x83ACE20", Offset = "0x83AB420", VA = "0x1883ACE20", Slot = "6")]
	public override HBDFLCGDPFO LPNJIHLFELG(OEMEODNGBLN ECBHOIMIBKD, [Out] IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class NOIMLJOFMIN : CAACNOBEDGL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class CPEFPJBFEIE : JsonConverter<MDHNGOEKFHC>
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83A7C70", Offset = "0x83A6270", VA = "0x1883A7C70", Slot = "9")]
		public override void WriteJson(JsonWriter CKPHLHCIFLA, MDHNGOEKFHC? KOPHBHGIACG, JsonSerializer CLMFOECLAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83A7B50", Offset = "0x83A6150", VA = "0x1883A7B50", Slot = "10")]
		public override MDHNGOEKFHC ReadJson(JsonReader KLIAOPJFDOK, Type CEIIOJHLMOO, MDHNGOEKFHC? ACFKNGEDBPB, bool FKADOJEIEBJ, JsonSerializer CLMFOECLAFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x83A7D10", Offset = "0x83A6310", VA = "0x1883A7D10")]
		public CPEFPJBFEIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class MHEAHHOOADH : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool EFNKKHNNFLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x83AF670", Offset = "0x83ADC70", VA = "0x1883AF670", Slot = "5")]
		public override object ReadJson(JsonReader KLIAOPJFDOK, Type CEIIOJHLMOO, object? ACFKNGEDBPB, JsonSerializer CLMFOECLAFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x83AF2B0", Offset = "0x83AD8B0", VA = "0x1883AF2B0", Slot = "6")]
		public override bool CanConvert(Type CEIIOJHLMOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x83AF6D0", Offset = "0x83ADCD0", VA = "0x1883AF6D0", Slot = "4")]
		public override void WriteJson(JsonWriter CKPHLHCIFLA, object? KOPHBHGIACG, JsonSerializer CLMFOECLAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x83AF490", Offset = "0x83ADA90", VA = "0x1883AF490")]
		private static bool IMODPKHJAGH(object KOPHBHGIACG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public MHEAHHOOADH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly JsonSerializerSettings CJEINKGIPEA;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x83AF940", Offset = "0x83ADF40", VA = "0x1883AF940")]
	internal NOIMLJOFMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3F54280", Offset = "0x3F52880", VA = "0x183F54280", Slot = "4")]
	public string BFMCACBOACM<T>(T MPIDDJPOOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3F542E0", Offset = "0x3F528E0", VA = "0x183F542E0", Slot = "5")]
	public T CBLPCGEMOOK<T>(string KOPHBHGIACG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class BDMCEJMIOMB : CAACNOBEDGL
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C480", Offset = "0x3B5AA80", VA = "0x183B5C480", Slot = "4")]
	public string BFMCACBOACM<T>(T MPIDDJPOOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C4E0", Offset = "0x3B5AAE0", VA = "0x183B5C4E0", Slot = "5")]
	public T CBLPCGEMOOK<T>(string KOPHBHGIACG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public BDMCEJMIOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[OEHADFBFMEG]
internal class JHLLLPJIIPJ : JGJAOOIJNNH<AOBPEDPLMGH, LPOLNBIIPNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly CAACNOBEDGL FNPABBPGEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly HPEMFPFEPIB NOMJKLKJDBD;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x83AAF10", Offset = "0x83A9510", VA = "0x1883AAF10")]
	public JHLLLPJIIPJ(CAACNOBEDGL FNPABBPGEBM, HPEMFPFEPIB NOMJKLKJDBD, KNOKIILHDFE NKJNDBENPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x83AA240", Offset = "0x83A8840", VA = "0x1883AA240", Slot = "6")]
	public override LPOLNBIIPNN LPNJIHLFELG(AOBPEDPLMGH ECBHOIMIBKD, [Out] IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x83A9EE0", Offset = "0x83A84E0", VA = "0x1883A9EE0")]
	internal void LHLOIACOBOL(string NIBDLLCCDML, HBDFLCGDPFO CBMCGBCNLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x83A9A00", Offset = "0x83A8000", VA = "0x1883A9A00")]
	public IEnumerable<PBGFHHLAMII> JELKKDFHELN(string ILOCOKCAGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x83A9AB0", Offset = "0x83A80B0", VA = "0x1883A9AB0")]
	private IEnumerable<PBGFHHLAMII> LGCDOHFDGCB(string ILOCOKCAGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x83A8D80", Offset = "0x83A7380", VA = "0x1883A8D80")]
	internal IEnumerable<PBGFHHLAMII> EFHANKAIENP(string ILOCOKCAGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x83A9350", Offset = "0x83A7950", VA = "0x1883A9350")]
	private PBGFHHLAMII HPOCECPEHIM(AvatarOutfitSelectionData BECBMJLGLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x83AA670", Offset = "0x83A8C70", VA = "0x1883AA670")]
	private void NFKCIFBOGDP(AvatarCustomizationSettingsData AJINOFFKMNB, HBDFLCGDPFO CBMCGBCNLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x83A96E0", Offset = "0x83A7CE0", VA = "0x1883A96E0")]
	private PBGFHHLAMII HPOCECPEHIM(string HOHPDEAGLJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x83A8A80", Offset = "0x83A7080", VA = "0x1883A8A80")]
	internal static (APMGGBJHHPH, string, string) CCHOOBLEIHK(string HOHPDEAGLJH, KNOKIILHDFE NKJNDBENPHK)
	{
		return default((APMGGBJHHPH, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x83AA040", Offset = "0x83A8640", VA = "0x1883AA040")]
	private JNMJFAICNGJ? LONMMONFNPJ(string? JJCLDINKIFD, Vector2 PCIIEEHIJJE, float FIFCNJCDJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x83A91F0", Offset = "0x83A77F0", VA = "0x1883A91F0")]
	private static FKKFOGDLKNE GAEPGEGJKNM(AvatarCustomizationSettingsData.AnchorParams GHHFNJBAHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[OEHADFBFMEG]
internal class ADOONHIAOHL : KPHFAINOGDH, LBIEONEFADB
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x83A6360", Offset = "0x83A4960", VA = "0x1883A6360")]
	public ADOONHIAOHL(CAACNOBEDGL FNPABBPGEBM, HPEMFPFEPIB NOMJKLKJDBD, KNOKIILHDFE NKJNDBENPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x83A5C70", Offset = "0x83A4270", VA = "0x1883A5C70", Slot = "4")]
	public IJNOEABBLAB ANHNANMIGBP(HBDFLCGDPFO CDDIADBJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x83A6020", Offset = "0x83A4620", VA = "0x1883A6020")]
	private string DCOHDCBNCDI(HBDFLCGDPFO CBMCGBCNLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x83A6120", Offset = "0x83A4720", VA = "0x1883A6120")]
	private string MHOPCCKOFPO(PBGFHHLAMII ABFFGEEFIIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[OEHADFBFMEG]
internal class NONJCHCNOJL : JGJAOOIJNNH<AOBPEDPLMGH, LPOLNBIIPNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly CAACNOBEDGL FNPABBPGEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly LBBPJNKPCHH<AOBPEDPLMGH, LPOLNBIIPNN> PKALHJNPDNL;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x83AFED0", Offset = "0x83AE4D0", VA = "0x1883AFED0")]
	public NONJCHCNOJL(LBBPJNKPCHH<AOBPEDPLMGH, LPOLNBIIPNN> PKALHJNPDNL, KNOKIILHDFE NKJNDBENPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x83AFAA0", Offset = "0x83AE0A0", VA = "0x1883AFAA0", Slot = "6")]
	public override LPOLNBIIPNN LPNJIHLFELG(AOBPEDPLMGH ECBHOIMIBKD, [Out] IReadOnlyList<PBEHPFBHNOE>? PNMPIKDPNBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[OEHADFBFMEG]
internal class JIPKDADDICA : FEFEGEOJFCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly CAACNOBEDGL FNPABBPGEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly LBIEONEFADB NBDEDMPMFGD;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x83ACAE0", Offset = "0x83AB0E0", VA = "0x1883ACAE0")]
	public JIPKDADDICA(LBIEONEFADB NBDEDMPMFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x83AC730", Offset = "0x83AAD30", VA = "0x1883AC730", Slot = "4")]
	public AOBPEDPLMGH ANHNANMIGBP(HBDFLCGDPFO CDDIADBJAOB, int HGIMHJPBGBB, string? NDIENANOGEK, string? CFKHGNHHJND, FHBEPOAOIND LBOENHPGDNF, List<PBEHPFBHNOE>? PNMPIKDPNBE)
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
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83A6590", Offset = "0x83A4B90", VA = "0x1883A6590")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FKLDMOEKCCP
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x83A7ED0", Offset = "0x83A64D0", VA = "0x1883A7ED0")]
	public static GIJENBMJDLP LPNJIHLFELG(this KBCLDPPKPMN CDDIADBJAOB)
	{
		return default(GIJENBMJDLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x83A7D50", Offset = "0x83A6350", VA = "0x1883A7D50")]
	public static KBCLDPPKPMN ANHNANMIGBP(this GIJENBMJDLP KJLEAIPIPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x83A7E70", Offset = "0x83A6470", VA = "0x1883A7E70")]
	public static bool IBCMDEALMJA(this GIJENBMJDLP KJLEAIPIPLJ)
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
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x6337990", Offset = "0x6335F90", VA = "0x186337990")]
			public AnchorParams(Vector2 DDEOIAKEDLP, Vector3 JAIBPBNIDCL, Vector3 EJGLJGDJPKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x83A64E0", Offset = "0x83A4AE0", VA = "0x1883A64E0")]
			internal FKKFOGDLKNE ANHNANMIGBP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private INLNEMFBLHB useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x83A6DC0", Offset = "0x83A53C0", VA = "0x1883A6DC0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x18E51A0", Offset = "0x18E37A0", VA = "0x1818E51A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xE385E0", Offset = "0xE36BE0", VA = "0x180E385E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x10D9240", Offset = "0x10D7840", VA = "0x1810D9240")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x15FA3E0", Offset = "0x15F89E0", VA = "0x1815FA3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x83A6E70", Offset = "0x83A5470", VA = "0x1883A6E70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAAA0D0", Offset = "0xAA86D0", VA = "0x180AAA0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD7C160", Offset = "0xD7A760", VA = "0x180D7C160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD7C810", Offset = "0xD7AE10", VA = "0x180D7C810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAA57F0", Offset = "0xAA3DF0", VA = "0x180AA57F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7A390", Offset = "0x2A78990", VA = "0x182A7A390")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xFE10D0", Offset = "0xFDF6D0", VA = "0x180FE10D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x12C9FE0", Offset = "0x12C85E0", VA = "0x1812C9FE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1AB5DE0", Offset = "0x1AB43E0", VA = "0x181AB5DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAAAEC0", Offset = "0xAA94C0", VA = "0x180AAAEC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAAAED0", Offset = "0xAA94D0", VA = "0x180AAAED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2660820", Offset = "0x265EE20", VA = "0x182660820")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1004580", Offset = "0x1002B80", VA = "0x181004580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xADD790", Offset = "0xADBD90", VA = "0x180ADD790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xADD7F0", Offset = "0xADBDF0", VA = "0x180ADD7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xAB03C0", Offset = "0xAAE9C0", VA = "0x180AB03C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xAB0540", Offset = "0xAAEB40", VA = "0x180AB0540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xAB04B0", Offset = "0xAAEAB0", VA = "0x180AB04B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xAB0550", Offset = "0xAAEB50", VA = "0x180AB0550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0560", Offset = "0xAAEB60", VA = "0x180AB0560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0400", Offset = "0xAAEA00", VA = "0x180AB0400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB2DCA0", Offset = "0xB2C2A0", VA = "0x180B2DCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB78DD0", Offset = "0xB773D0", VA = "0x180B78DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0450", Offset = "0xAAEA50", VA = "0x180AB0450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0480", Offset = "0xAAEA80", VA = "0x180AB0480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB78DA0", Offset = "0xB773A0", VA = "0x180B78DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB78B30", Offset = "0xB77130", VA = "0x180B78B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAEE90", Offset = "0xAAD490", VA = "0x180AAEE90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAEF10", Offset = "0xAAD510", VA = "0x180AAEF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB78BB0", Offset = "0xB771B0", VA = "0x180B78BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB78B50", Offset = "0xB77150", VA = "0x180B78B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xE20620", Offset = "0xE1EC20", VA = "0x180E20620")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xE1EB40", Offset = "0xE1D140", VA = "0x180E1EB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public INLNEMFBLHB UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x10E1E00", Offset = "0x10E0400", VA = "0x1810E1E00")]
			get
			{
				return default(INLNEMFBLHB);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x10E21B0", Offset = "0x10E07B0", VA = "0x1810E21B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x10E1D40", Offset = "0x10E0340", VA = "0x1810E1D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xD6E0C0", Offset = "0xD6C6C0", VA = "0x180D6E0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x83A6E90", Offset = "0x83A5490", VA = "0x1883A6E90")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x83A6EB0", Offset = "0x83A54B0", VA = "0x1883A6EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x83A6A20", Offset = "0x83A5020", VA = "0x1883A6A20")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public APMGGBJHHPH BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private KOBFNKPKHBD? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x83A6ED0", Offset = "0x83A54D0", VA = "0x1883A6ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
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
