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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x839B850", Offset = "0x839A250", VA = "0x18839B850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
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
		[Cpp2IlInjected.Address(RVA = "0x839B8D0", Offset = "0x839A2D0", VA = "0x18839B8D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LDDMKMABCFO]
internal class FMHBIMLALLE : CLPMLNKJGJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct EMGEAKBOAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public FMHBIMLALLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public BOIFAILEJMF avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NNKPBOHKNJM JOPKDDEEEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JHNPEHPONLI ELELLBKNCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MNBFGPHNFDP JCCNKPOHPKO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x837E670", Offset = "0x837D070", VA = "0x18837E670")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	[UsedImplicitly]
	internal static void EHDGAPALFJP(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x837F630", Offset = "0x837E030", VA = "0x18837F630")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FMHBIMLALLE([BMCONCJPCIA(null)] NNKPBOHKNJM JOPKDDEEEMM, [BMCONCJPCIA(null)] JHNPEHPONLI ELELLBKNCAN, [BMCONCJPCIA(null)] MNBFGPHNFDP JCCNKPOHPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x837DD20", Offset = "0x837C720", VA = "0x18837DD20", Slot = "5")]
	public DECEKEGDNPK DNOIAGKLJKD(BOIFAILEJMF FJBHHBODDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x837EA30", Offset = "0x837D430", VA = "0x18837EA30", Slot = "4")]
	public DECEKEGDNPK MKAOCAONBNM(BOIFAILEJMF FJBHHBODDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x837F520", Offset = "0x837DF20", VA = "0x18837F520", Slot = "6")]
	public BNNANBPCKPP NHOBDKMHMGI(DECEKEGDNPK BLPDDGCLNPE, int CKOENHFPFNP, string? IELIBBNCJAC, string? PLGKCPJHJIM, OGPADJCDAAA MHLPAIHPPIO, List<HKGMBANLFND>? EODEMANNLNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x837E6E0", Offset = "0x837D0E0", VA = "0x18837E6E0", Slot = "7")]
	public bool INEOCDMOGOC(JMBIIDEIJMI FMMKJHOPBAJ, [Out] DECEKEGDNPK? AIFAODPNIHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x837E950", Offset = "0x837D350", VA = "0x18837E950", Slot = "8")]
	public bool JPGJDFPOCFL(BNNANBPCKPP HKHBILDPHDJ, [Out] DECEKEGDNPK? AIFAODPNIHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x837E5E0", Offset = "0x837CFE0", VA = "0x18837E5E0", Slot = "9")]
	public bool EBBLPNEJKNK(BNNANBPCKPP HKHBILDPHDJ, [Out] ABLACFOHHEB? FMMKJHOPBAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D70120", Offset = "0x3D6EB20", VA = "0x183D70120")]
	private bool BJKPACBAKFA<TInput, TOutput>(TInput GHANLDMHBLD, BPBFAJFIOAA<TInput, TOutput> FGJNJJFEDGL, [Out] TOutput? GGIKEMCHAAA) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x837DB80", Offset = "0x837C580", VA = "0x18837DB80")]
	[CompilerGenerated]
	private NOMMIKCFBEP BGNAJHHIJEL(FaceFeatureType OKHJLKIMLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x837E770", Offset = "0x837D170", VA = "0x18837E770")]
	[CompilerGenerated]
	private NOMMIKCFBEP JOLALMFOPCG(FaceFeatureType OKHJLKIMLFB, EMGEAKBOAFF P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[LDDMKMABCFO]
internal class IDIAIPBLGDN : NNKPBOHKNJM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DFOMMNCAGOJ<in TData>(TData AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? EODEMANNLNK);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ENHINGBBHAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public MCCHLKONJKI rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JPAFNFENLAC currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JPAFNFENLAC latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ENHINGBBHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x837DAE0", Offset = "0x837C4E0", VA = "0x18837DAE0")]
		internal bool JCAFCECGLNN(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x837DB00", Offset = "0x837C500", VA = "0x18837DB00")]
		internal bool OHAHMPNEDOC(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MNBFGPHNFDP JCCNKPOHPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AFCBJHNNPNF LEAGHOGAOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DFOMMNCAGOJ<DECEKEGDNPK>?[] JOPKDDEEEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DFOMMNCAGOJ<ABLACFOHHEB>?[] GGMBMOGLMNE;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x837FAF0", Offset = "0x837E4F0", VA = "0x18837FAF0")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	[UsedImplicitly]
	internal static void EHDGAPALFJP(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83813B0", Offset = "0x837FDB0", VA = "0x1883813B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IDIAIPBLGDN([BMCONCJPCIA(null)] MNBFGPHNFDP JCCNKPOHPKO, [BMCONCJPCIA(null)] AFCBJHNNPNF LEAGHOGAOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8380D50", Offset = "0x837F750", VA = "0x188380D50", Slot = "4")]
	public bool MKALBHCOACB(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? EODEMANNLNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8380BF0", Offset = "0x837F5F0", VA = "0x188380BF0", Slot = "5")]
	public bool MKALBHCOACB(ABLACFOHHEB FMMKJHOPBAJ, IReadOnlyList<HKGMBANLFND>? EODEMANNLNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x837FBB0", Offset = "0x837E5B0", VA = "0x18837FBB0")]
	private void GCILBBKCFBP(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x83809C0", Offset = "0x837F3C0", VA = "0x1883809C0")]
	private void LCPNEOBHOAE(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x837F7E0", Offset = "0x837E1E0", VA = "0x18837F7E0")]
	private void CAGGPJDDEKN(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8380990", Offset = "0x837F390", VA = "0x188380990")]
	private void KGOHKCLEMAF(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8380790", Offset = "0x837F190", VA = "0x188380790")]
	private void GNMECMKGAFD(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83808E0", Offset = "0x837F2E0", VA = "0x1883808E0")]
	private void KGMMLGAMCEI(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8381300", Offset = "0x837FD00", VA = "0x188381300")]
	private void OFPNKOPFPCL(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x837FBA0", Offset = "0x837E5A0", VA = "0x18837FBA0")]
	private void FKEBKBAEPEH(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x837F7B0", Offset = "0x837E1B0", VA = "0x18837F7B0")]
	private void CACHOBGMMEH(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8380860", Offset = "0x837F260", VA = "0x188380860")]
	private void KDIOPECMGBA(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? HBELCFIJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x837F810", Offset = "0x837E210", VA = "0x18837F810")]
	private void EGGEIHHJJFH(DECEKEGDNPK AIFAODPNIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8381020", Offset = "0x837FA20", VA = "0x188381020")]
	private DECEKEGDNPK OBLCGPBODFI(DECEKEGDNPK AIFAODPNIHK, List<RangeMigration> GJGOJEMGFFE, JPAFNFENLAC IGPIIFAKBHF, JPAFNFENLAC ABIDBDDFMKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x837FB60", Offset = "0x837E560", VA = "0x18837FB60")]
	private float EKOEOJCMHAA(float DENEBPHMCNK, Vector2 HLMBGHBJHCE, Vector2 ELCMKGBHLFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8380E50", Offset = "0x837F850", VA = "0x188380E50")]
	private (RangeMigration?, RangeMigration?) NMOBPMLODAO(List<RangeMigration> BHMNFHNIGIN, MCCHLKONJKI OHOEGNOGNBK, JPAFNFENLAC IGPIIFAKBHF, JPAFNFENLAC ABIDBDDFMKL)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NNKPBOHKNJM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MKALBHCOACB(DECEKEGDNPK AIFAODPNIHK, IReadOnlyList<HKGMBANLFND>? EODEMANNLNK);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MKALBHCOACB(ABLACFOHHEB FMMKJHOPBAJ, IReadOnlyList<HKGMBANLFND>? EODEMANNLNK);
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
		public BEIAPHDGACL AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x837B600", Offset = "0x837A000", VA = "0x18837B600")]
		public void FPAGFKDPGEC(AnimationPoseSetting GOCNHGEHNFD, float FNIHHNLPFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x837B730", Offset = "0x837A130", VA = "0x18837B730")]
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
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x837C040", Offset = "0x837AA40", VA = "0x18837C040")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x837C000", Offset = "0x837AA00", VA = "0x18837C000")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x837B750", Offset = "0x837A150", VA = "0x18837B750")]
		private void MJMKIFAHHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8303180", Offset = "0x8301B80", VA = "0x188303180", Slot = "4")]
		public void SetEnabled(bool LEFHPHFNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x837C070", Offset = "0x837AA70", VA = "0x18837C070")]
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
		[Cpp2IlInjected.Address(RVA = "0x837C0B0", Offset = "0x837AAB0", VA = "0x18837C0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x837C0F0", Offset = "0x837AAF0", VA = "0x18837C0F0")]
		public AnimationPoseSetting DPNINCCENLF(BEIAPHDGACL LMHOHOIINOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x837C120", Offset = "0x837AB20", VA = "0x18837C120")]
		public void LHEJPJMHOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x837C160", Offset = "0x837AB60", VA = "0x18837C160")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum DJNGGBNHHKB
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private DJNGGBNHHKB handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x837CC70", Offset = "0x837B670", VA = "0x18837CC70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x837CC30", Offset = "0x837B630", VA = "0x18837CC30")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x837C610", Offset = "0x837B010", VA = "0x18837C610")]
		private void MJMKIFAHHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8303180", Offset = "0x8301B80", VA = "0x188303180", Slot = "4")]
		public void SetEnabled(bool LEFHPHFNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x837CCA0", Offset = "0x837B6A0", VA = "0x18837CCA0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, INNDGHFJNFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private BOIFAILEJMF avatarBodyType;

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
		[IHBEENDFBCJ(EAHEBLGAGFP.SelfAndChildren, false, false, false)]
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
		private CDMJHEHKDNI KMOGBIDOMCG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CDMJHEHKDNI NHJECLBDMBM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB879D0", Offset = "0xB863D0", VA = "0x180B879D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform ONLJGJEPKHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x837DAC0", Offset = "0x837C4C0", VA = "0x18837DAC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x837CCD0", Offset = "0x837B6D0", VA = "0x18837CCD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x837D980", Offset = "0x837C380", VA = "0x18837D980")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x837D930", Offset = "0x837C330", VA = "0x18837D930")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x837D8C0", Offset = "0x837C2C0", VA = "0x18837D8C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x837CCD0", Offset = "0x837B6D0", VA = "0x18837CCD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x837D060", Offset = "0x837BA60", VA = "0x18837D060", Slot = "6")]
		public CDMJHEHKDNI CreateAvatarSystem(string PAOMEOOKDEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x837D8C0", Offset = "0x837C2C0", VA = "0x18837D8C0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x837CD90", Offset = "0x837B790", VA = "0x18837CD90", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x837D9D0", Offset = "0x837C3D0", VA = "0x18837D9D0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float LHPALOIPBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class MAHILLKKPAD : CDMJHEHKDNI
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class OPHNJCNNMBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 OFJKFBCAENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Quaternion ECIMDBGMNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Vector3 NBHJIMCDNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Transform KDJJLBFDNJJ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 FBMPPFHOGPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x227CE00", Offset = "0x227B800", VA = "0x18227CE00")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x227CE20", Offset = "0x227B820", VA = "0x18227CE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion LJECLAAIDNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1682560", Offset = "0x1680F60", VA = "0x181682560")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1682300", Offset = "0x1680D00", VA = "0x181682300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float IMEDCLOHNDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x12CD6D0", Offset = "0x12CC0D0", VA = "0x1812CD6D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1A99110", Offset = "0x1A97B10", VA = "0x181A99110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool LEGDCOMKOGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xABA920", Offset = "0xAB9320", VA = "0x180ABA920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool PLFBFKHDFLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xABA910", Offset = "0xAB9310", VA = "0x180ABA910")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xABA840", Offset = "0xAB9240", VA = "0x180ABA840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool CDNEENMCBOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xABA940", Offset = "0xAB9340", VA = "0x180ABA940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xABA760", Offset = "0xAB9160", VA = "0x180ABA760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float CALHCDNDNAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xE33CF0", Offset = "0xE326F0", VA = "0x180E33CF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xE33FF0", Offset = "0xE329F0", VA = "0x180E33FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x83A6510", Offset = "0x83A4F10", VA = "0x1883A6510")]
		public void DOGKDNOGAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83A6540", Offset = "0x83A4F40", VA = "0x1883A6540")]
		public void EOKILICLILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83A70B0", Offset = "0x83A5AB0", VA = "0x1883A70B0")]
		public float PDGOIKIOLJN(Vector3 CJIBDAHGPND, Quaternion FAIJFPOFBDH, [In] AvatarFootSettings DFLNBFGLNMO, float KDDABGLAJKL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x83A6880", Offset = "0x83A5280", VA = "0x1883A6880")]
		public void INDDDGNDPEG(Vector3 ICKLMBPHJNI, Quaternion MNGFBPAFIGF, Transform EAGJAMFIBLL, float IPENPGEBOIL, bool CIPNHCOEHOA, bool HFDCCOHGNCJ, float EAHAPGJPLPO, float MAFBNCIAPON, Transform FAIGKPPBFHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83A6650", Offset = "0x83A5050", VA = "0x1883A6650")]
		public void IACOAJICFIE(Transform AIKJNABKEKD, Transform FAIGKPPBFHA, bool IJLPAECCHNL, bool EDKFLAHMKGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x83A6550", Offset = "0x83A4F50", VA = "0x1883A6550")]
		private void FAHKLPELEKE(Transform FAIGKPPBFHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83A6F60", Offset = "0x83A5960", VA = "0x1883A6F60")]
		public bool MJHIMOGINMP(Transform FAIGKPPBFHA, AvatarFullBodyConfiguration OINEAODAACF, Vector3 CFFOLPELLEJ, float EIHMDGALCKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83A6520", Offset = "0x83A4F20", VA = "0x1883A6520")]
		public void EGPPANFMMHJ(float MAFBNCIAPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x83A72C0", Offset = "0x83A5CC0", VA = "0x1883A72C0")]
		public OPHNJCNNMBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class EJJHPMEAGKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private float GOLCBPMJIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool NMHHILHEGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AnimationPoseSetting EIMFLBEGFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private float FKNGIJLEAKO;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83A03B0", Offset = "0x839EDB0", VA = "0x1883A03B0")]
		public void DBKCNAKEPMK(IKSolverVR.Arm AOAAONAINNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x83A03E0", Offset = "0x839EDE0", VA = "0x1883A03E0")]
		public void ECALDCHCMKG(IKSolverVR.Arm AOAAONAINNP, float MEPGCHMDHDF, bool NMHHILHEGGP, AvatarFullBodyConfiguration OINEAODAACF, float PMIHAPOMGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83A0370", Offset = "0x839ED70", VA = "0x1883A0370")]
		private void AAANHNNEHGO(IKSolverVR.Arm AOAAONAINNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83A15F0", Offset = "0x839FFF0", VA = "0x1883A15F0")]
		public void MHGBNOIPFPG(IKSolverVR.Arm AOAAONAINNP, Transform CGCMLANDIPO, Transform EAGJAMFIBLL, Quaternion ANGDIEALJAC, Vector3 OBGCAEOJFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x83A0EC0", Offset = "0x839F8C0", VA = "0x1883A0EC0")]
		private (Vector3, Quaternion) FOEOJFFJIHB(OPLBHNJBLLG JDMODGMKMEI, Quaternion EPGIILFFKIH, Vector3 HDHFAIOBOAL)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x83A1350", Offset = "0x839FD50", VA = "0x1883A1350")]
		public void JEAPIBLPFHC(OPLBHNJBLLG JDMODGMKMEI, IKSolverVR.Arm AOAAONAINNP, Quaternion EPGIILFFKIH, Vector3 HDHFAIOBOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x83A0420", Offset = "0x839EE20", VA = "0x1883A0420")]
		public void EEPMPPEPCBI(OPLBHNJBLLG JDMODGMKMEI, IKSolverVR.Arm AOAAONAINNP, Quaternion EPGIILFFKIH, Vector3 HDHFAIOBOAL, [In] AvatarFullBodyConfiguration OINEAODAACF, [In] KMBDFNEGPNB IMNBLKDCAKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x83A14B0", Offset = "0x839FEB0", VA = "0x1883A14B0")]
		public void MAKCMOODAIE(BEIAPHDGACL NJCBBNEKENK, AvatarFullBodyConfiguration OINEAODAACF, KMBDFNEGPNB IMNBLKDCAKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A20", Offset = "0x839F420", VA = "0x1883A0A20")]
		public void EGBLHHHKLFA(IKSolverVR.Arm AOAAONAINNP, Transform CGCMLANDIPO, Vector3 NCGHGOMOCDB, float DOFFKLIIHBD, Quaternion ENAIKKDMCKI, Vector3 LGOAIMBMGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x83A19D0", Offset = "0x83A03D0", VA = "0x1883A19D0")]
		public EJJHPMEAGKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum KAKHLMKLDMO
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
	private struct MEMDPJBDKDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DICAEMGCICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int PBGCIPGGMAD;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int LGHMLEGKAGK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int CDLEBFFOJBC;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int LKNBMIBJHGD;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int CAGNMEJGCFI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int MJCAGFMIGBO;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int CJMLJOFADAH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int MEEIGBKHPCC;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int JCCBHMNMHNH;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int PJCKLIIDBDF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int PLFKCDFEOAK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int HLGEHMGDOBM;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int BJENABFMJMA;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int MLNPAENNCEC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int GCNCKKALMFJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int PFCJIFOFPDE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int HMCGCCPCGIN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int OKNBDGIHIEH;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int FJIOJFOABIP;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int FPPDBPLKPII;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int BNIBNAEKPMO;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int NPJIPJIAJID;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int JNAJJJDNKEB;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int FLCGJILLJOH;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int CIEAKEICEBA;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int LLEHFGHFFHL;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int OCJJLHAKFEF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int MPONBHHHFFP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int BDCENKOCCKM;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int KGIPONBCMEI;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int DMCADCIPHBH;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int MFCABAIMMOB;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly Vector3 LMBEKPHPAAE;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int DGHOFIPBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool CDHKBEKPGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool FDCGHCKNONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool HPELOIECJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool FPNBPEIJHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool POLGNHEKCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool KOLEGBDIBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Vector3 EBFMOHPBBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private string JPJDILIOFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FMFBICLNHAP? LOPPEBOEGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private ODGBENLADGG? AGIGFNBBPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private AGIJPMGLDJD NEPHFGIINBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private APLMPEOAAHJ CPIOOIKMBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private OPLBHNJBLLG EBAHABHLKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private OPLBHNJBLLG HMMALMLIICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool AILPFLPKNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x291")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool MMGJPCNNJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly GIOLPIPCKLD AIMJKNJCONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly GFHFHNCPDEL FLJHIBNFFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int EMIEJFJEGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private float EFCKCBBPLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject DAENOLFEIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Transform NGIDCDOFCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Transform ALOBCHKPJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Transform IDGIDCIOIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform IPNJAOLBEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float ABLFGCMLNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float ELMFPDNOBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Vector3 MDCAFANDDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Quaternion HKFODBKGCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Transform FGJPBPKKCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Transform IPDONDJPNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Transform CDMFPNDHGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private HMPGJMLLIHC CIKMFAOJPDD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker CDLEFNGGOKN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker NFCCKGKMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private ProfilerMarker AHHBFGCPEJP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ProfilerMarker NKOADDMDMBP;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ProfilerMarker AMNLOPNCBFK;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly ProfilerMarker BJNCJHDIHNF;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly List<MAHILLKKPAD> LGGBFNDDPMG;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int JGFPMAGFABG;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> LJNHPIMJKBH;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int KAICHKDGOAE;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int JMHBLPBMMCE;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static int CHHMGEFFOOI;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int DAAKFHHDLJO;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float NCBDOKCFKLG;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static int HBIKCKGMIJL;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float IDLEEMCBAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static float MCOCBBKMNJI;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static float FNGCHKNDBCG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static float LIJGFMKHGIN;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static ILMIFGIDPNP JFOCFHAGOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float OHHAMFGMBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool GDPPACJDIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float IBAOJBGJDCP;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly int CMBEIKBKIIE;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly int BDHJGGFKLMN;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly int MDEDEAGNLHH;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly int CNBLLFCBIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private OPHNJCNNMBB EEJGPFKFDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private OPHNJCNNMBB ODLFKGBJALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float IBMCBJGHNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 NPOIMMHDEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private Vector3 AIJKOMBPOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool IEECAICBAPB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly Quaternion ODILIBLONJO;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly Quaternion JIJODJHGNEN;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly Vector3 ACJNIKJIGJO;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly Vector3 ILIBNCBFHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float LLNECIMJCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float LFECCPEOGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private EJJHPMEAGKI JEEFDKJOCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private EJJHPMEAGKI HNICMLIPIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private ICAMKDKCHJJ POCGONHKOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private NFDJJBBGFHK LPFHOKEPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly MKFPFACHEEI NOGLJKGGNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float KBBDJPMFCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float INKLNMEJJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly NFDJJBBGFHK LALPKAFPOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private Vector3 LFPNOOAKMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Vector3 PEKPPLODDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private float ABMOBFIDFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private float EMDMEGIPFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly NFDJJBBGFHK HCPNENEPPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly ICAMKDKCHJJ PINPNGFCPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly NFDJJBBGFHK IDMEDGNLGLL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EBDGCEEEFPM NMNKEJHMLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EBDGCEEEFPM APLPLKBBHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration MNDNMMNNALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x838CFA0", Offset = "0x838B9A0", VA = "0x18838CFA0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BOIFAILEJMF DGBHIEOFEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8388950", Offset = "0x8387350", VA = "0x188388950", Slot = "24")]
		get
		{
			return default(BOIFAILEJMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration IICPKJOKFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8395130", Offset = "0x8393B30", VA = "0x188395130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform OINBNBEGHLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8381AA0", Offset = "0x83804A0", VA = "0x188381AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform MPOPPPPNHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8394B10", Offset = "0x8393510", VA = "0x188394B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer DAHLIDCJPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8382BA0", Offset = "0x83815A0", VA = "0x188382BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] MGHNMAJDJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8396130", Offset = "0x8394B30", VA = "0x188396130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] LNPBGFLGJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8382AD0", Offset = "0x83814D0", VA = "0x188382AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator JEPPNGIMCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x838A510", Offset = "0x8388F10", VA = "0x18838A510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK JJMKHFFDDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8385C50", Offset = "0x8384650", VA = "0x188385C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private HPCJFNFELMP KHNDGPKBLJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8385D20", Offset = "0x8384720", VA = "0x188385D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private HPCJFNFELMP LLFKGPHHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83842A0", Offset = "0x8382CA0", VA = "0x1883842A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private HPCJFNFELMP FFAHEHKAJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83852B0", Offset = "0x8383CB0", VA = "0x1883852B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private HPCJFNFELMP LHOLDJLHHEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83830D0", Offset = "0x8381AD0", VA = "0x1883830D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private HPCJFNFELMP OJANIJGGNCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8384D20", Offset = "0x8383720", VA = "0x188384D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private HPCJFNFELMP EGMHEKPBECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8382D90", Offset = "0x8381790", VA = "0x188382D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private HPCJFNFELMP GMKBGLPGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8383EB0", Offset = "0x83828B0", VA = "0x188383EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private HPCJFNFELMP AKLOAAFCKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83840F0", Offset = "0x8382AF0", VA = "0x1883840F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ODGBENLADGG PCAHNFEENPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8382C70", Offset = "0x8381670", VA = "0x188382C70", Slot = "16")]
		get
		{
			return default(ODGBENLADGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ICNBFDLCIDH IMNCOKLCNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC41C30", Offset = "0xC40630", VA = "0x180C41C30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public NOCNHILIHGH GEIBKNDDNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC41C20", Offset = "0xC40620", VA = "0x180C41C20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KHMNFMMABMJ LENENJOODFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC41C40", Offset = "0xC40640", VA = "0x180C41C40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KHMNFMMABMJ NGILENECMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC41C10", Offset = "0xC40610", VA = "0x180C41C10", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string ENMICGMLGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform HLMPFMGCICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8383080", Offset = "0x8381A80", VA = "0x188383080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform OIBKBPJGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8385DF0", Offset = "0x83847F0", VA = "0x188385DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform EBBFHGPKCLE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83868A0", Offset = "0x83852A0", VA = "0x1883868A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform CBPKIEACPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83841C0", Offset = "0x8382BC0", VA = "0x1883841C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform MJKGMILGNHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x838B6A0", Offset = "0x838A0A0", VA = "0x18838B6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool JAMOPLPKJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8382290", Offset = "0x8380C90", VA = "0x188382290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool OMFAEGGLAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8382290", Offset = "0x8380C90", VA = "0x188382290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool ECLFMFPHACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8383F80", Offset = "0x8382980", VA = "0x188383F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform AABLDGAHACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x838BE90", Offset = "0x838A890", VA = "0x18838BE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject FNCBMCHNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8384200", Offset = "0x8382C00", VA = "0x188384200", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets HONBMCNBHHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x838B620", Offset = "0x838A020", VA = "0x18838B620", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform MICKCBLBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB11EF0", Offset = "0xB108F0", VA = "0x180B11EF0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform DGJAFMNFJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBC1CE0", Offset = "0xBC06E0", VA = "0x180BC1CE0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform IMFDFJFEEFO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xBC1E70", Offset = "0xBC0870", VA = "0x180BC1E70", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform JBLFFFANNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBC1DF0", Offset = "0xBC07F0", VA = "0x180BC1DF0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 IJJHPJLPCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8396440", Offset = "0x8394E40", VA = "0x188396440", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float DCNBBKJDOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8394690", Offset = "0x8393090", VA = "0x188394690", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform GMOENEHADNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8395900", Offset = "0x8394300", VA = "0x188395900", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform BMGHJCCJBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x22E1830", Offset = "0x22E0230", VA = "0x1822E1830", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform OEAHCEOADIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBC1CC0", Offset = "0xBC06C0", VA = "0x180BC1CC0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform PNGBJDFCEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x296C410", Offset = "0x296AE10", VA = "0x18296C410", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool BPKNCEJGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x838CB10", Offset = "0x838B510", VA = "0x18838CB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public AHDLCNFLGGK<CDMJHEHKDNI.JAMGBDDGDPH> GDHMAFDJNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8386CC0", Offset = "0x83856C0", VA = "0x188386CC0", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool NDOHOOAKIPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8395410", Offset = "0x8393E10", VA = "0x188395410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool LHFBNACAPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8395C50", Offset = "0x8394650", VA = "0x188395C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x839A600", Offset = "0x8399000", VA = "0x18839A600")]
	private float PMDJNENEBAM(NLMGCLIMLFL PAKMCAALBGL, float GLBJOGNEJIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8388A20", Offset = "0x8387420", VA = "0x188388A20")]
	private void HECIIBDHMFE([In] KMBDFNEGPNB MEIGHMBNIHM, [In] AvatarFullBodyConfiguration OINEAODAACF, bool DNODODNACIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x839A3C0", Offset = "0x8398DC0", VA = "0x18839A3C0")]
	private float PJPMEADHCHG([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8383E30", Offset = "0x8382830", VA = "0x188383E30")]
	private float CNKDNMLHEID([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x838AE30", Offset = "0x8389830", VA = "0x18838AE30")]
	private void HMFNMMEJMGH(KMBDFNEGPNB MEIGHMBNIHM, AvatarFullBodyConfiguration OINEAODAACF, bool DNODODNACIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83868D0", Offset = "0x83852D0", VA = "0x1883868D0")]
	private void FDDGCHCNNCA([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83951C0", Offset = "0x8393BC0", VA = "0x1883951C0")]
	private void MCKHLAIENPH([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x839B350", Offset = "0x8399D50", VA = "0x18839B350")]
	public MAHILLKKPAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83996E0", Offset = "0x83980E0", VA = "0x1883996E0", Slot = "13")]
	public void OPCBGNLFGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8396510", Offset = "0x8394F10", VA = "0x188396510", Slot = "14")]
	public void NKKAECOOKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x838E0B0", Offset = "0x838CAB0", VA = "0x18838E0B0", Slot = "15")]
	public void KFCEONCHAOD(bool LGECPALEJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x83968C0", Offset = "0x83952C0", VA = "0x1883968C0", Slot = "26")]
	public Transform NNPPEFPENNF(string JFCAGHAKKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x838C970", Offset = "0x838B370", VA = "0x18838C970", Slot = "27")]
	public Vector3? IOBHPDJMDDO(string JFCAGHAKKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x838A970", Offset = "0x8389370", VA = "0x18838A970", Slot = "7")]
	public void HHKIBGOOPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8385E30", Offset = "0x8384830", VA = "0x188385E30")]
	private void ENIGCPOAGIC(AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8398350", Offset = "0x8396D50", VA = "0x188398350", Slot = "8")]
	public void OHPPOPMOBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x838E260", Offset = "0x838CC60", VA = "0x18838E260")]
	private void KGCJNENMANK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x83948A0", Offset = "0x83932A0", VA = "0x1883948A0")]
	private Vector3 LILMBJGNNMN([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x838AC40", Offset = "0x8389640", VA = "0x18838AC40", Slot = "6")]
	public void HIKEHEOFFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8387960", Offset = "0x8386360", VA = "0x188387960")]
	private void GLPDGOJOBII(bool DNODODNACIC, KAKHLMKLDMO GEGAHCCHNHP, AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8387660", Offset = "0x8386060", VA = "0x188387660", Slot = "9")]
	public void GENDAHIIKBN(float MBMDMAKPOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8394A20", Offset = "0x8393420", VA = "0x188394A20")]
	private void LJALGJKAEJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x838F0B0", Offset = "0x838DAB0", VA = "0x18838F0B0", Slot = "4")]
	public void KJADMKEEAEO(string PAOMEOOKDEM, FMFBICLNHAP CJHCBJDFCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x83839B0", Offset = "0x83823B0", VA = "0x1883839B0", Slot = "5")]
	public void CHGDFLHEOJI(ODGBENLADGG IJIPKLDDBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8381B70", Offset = "0x8380570", VA = "0x188381B70", Slot = "12")]
	public void AGOBEIBFKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x838A5E0", Offset = "0x8388FE0", VA = "0x18838A5E0", Slot = "25")]
	public void HFDGIDNHOKI([Out] Vector3 AFIJBLNBNDO, [Out] Quaternion ENAIKKDMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8384CF0", Offset = "0x83836F0", VA = "0x188384CF0")]
	private void DMNBCBDNPPO([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8382D80", Offset = "0x8381780", VA = "0x188382D80", Slot = "28")]
	public void BJCNPPJAHMF(float MIFFHPFAALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x838CC00", Offset = "0x838B600", VA = "0x18838CC00", Slot = "29")]
	public void JCKABPLEJNK(float NFMMNHDCBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8394AC0", Offset = "0x83934C0", VA = "0x188394AC0", Slot = "46")]
	public void LLLBEFAIADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x838E060", Offset = "0x838CA60", VA = "0x18838E060", Slot = "30")]
	public void KBHCDIAHFHH(bool HHMIMIKFDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8394A70", Offset = "0x8393470", VA = "0x188394A70", Slot = "31")]
	public HandLogicOffsets LLKDGOAMFJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x83922D0", Offset = "0x8390CD0", VA = "0x1883922D0", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets KOGDJMBDLDJ()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x838F080", Offset = "0x838DA80", VA = "0x18838F080")]
	private void KIFFIBIDBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8395780", Offset = "0x8394180", VA = "0x188395780")]
	private void MJIFIHPGAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x83835A0", Offset = "0x8381FA0", VA = "0x1883835A0")]
	private void CGLCBAJHIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8387020", Offset = "0x8385A20", VA = "0x188387020")]
	private void GDCIBPJNHMK(ANNBNLPJGPM HFKFAEDBOJK, bool NFCKHMKCNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8386EA0", Offset = "0x83858A0", VA = "0x188386EA0")]
	private void FOHKNPCMLGB(ANNBNLPJGPM HFKFAEDBOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8382E60", Offset = "0x8381860", VA = "0x188382E60")]
	public Vector3 BJNGFNLGBNH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8395960", Offset = "0x8394360", VA = "0x188395960")]
	private void MNFCBAGICPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8395CD0", Offset = "0x83946D0", VA = "0x188395CD0")]
	private void MOPCJCKCKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8392390", Offset = "0x8390D90", VA = "0x188392390")]
	private void KOGJJONEKPL(KMBDFNEGPNB MEIGHMBNIHM, AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8381CD0", Offset = "0x83806D0", VA = "0x188381CD0")]
	private float AIMMNJEPEPH([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x838E180", Offset = "0x838CB80", VA = "0x18838E180")]
	private int KFNOBOFEDFN([In] PPPHCDIICIH LADKMELLHCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8396EA0", Offset = "0x83958A0", VA = "0x188396EA0")]
	private void OALOLJDAKLE(KMBDFNEGPNB MEIGHMBNIHM, bool AKFEFNIGOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8398930", Offset = "0x8397330", VA = "0x188398930")]
	private static void OLDEMMJJKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x83973D0", Offset = "0x8395DD0", VA = "0x1883973D0")]
	private static void OBPJBABEKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8386CD0", Offset = "0x83856D0", VA = "0x188386CD0")]
	private float FMEIFJJOFNM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8395100", Offset = "0x8393B00", VA = "0x188395100")]
	private static int LOCIKGLDHBG(MAHILLKKPAD IIIICGAEODJ, MAHILLKKPAD ELBIKJBAIEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x83952C0", Offset = "0x8393CC0", VA = "0x1883952C0", Slot = "41")]
	public KMBDFNEGPNB MCOEBMGDEFK()
	{
		return default(KMBDFNEGPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8382A20", Offset = "0x8381420", VA = "0x188382A20")]
	private bool BGMHHALIAJN(int NMAIBBDGPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8382210", Offset = "0x8380C10", VA = "0x188382210")]
	public void AKDBCLPGBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8398170", Offset = "0x8396B70", VA = "0x188398170")]
	private (bool, bool) OHGLNENJNOF()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x838E360", Offset = "0x838CD60", VA = "0x18838E360")]
	private (float, float) KGDBKEOKPFM([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8392A30", Offset = "0x8391430", VA = "0x188392A30")]
	private void KOHDPBPEOHF([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x838ED60", Offset = "0x838D760", VA = "0x18838ED60")]
	private void KHNBCHJKIFE([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8386480", Offset = "0x8384E80", VA = "0x188386480")]
	private void FAOAPKLENEH([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF, AvatarFootSettings DFLNBFGLNMO, bool JDAFFJPHIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8384070", Offset = "0x8382A70", VA = "0x188384070")]
	private float CPFHKOCLIJA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8398B60", Offset = "0x8397560", VA = "0x188398B60")]
	private void OMGGPBEDLLE(KMBDFNEGPNB IMNBLKDCAKA, AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x838CF50", Offset = "0x838B950", VA = "0x18838CF50")]
	private float JEFIEGJOAEM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8384DF0", Offset = "0x83837F0", VA = "0x188384DF0")]
	private void EDAMKHINOHK([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8395490", Offset = "0x8393E90", VA = "0x188395490")]
	private void MHGBNOIPFPG([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x83831A0", Offset = "0x8381BA0", VA = "0x1883831A0")]
	private void CEILCIIJLMO([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x83876D0", Offset = "0x83860D0", VA = "0x1883876D0")]
	private void GLOCNDOCLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x838DC80", Offset = "0x838C680", VA = "0x18838DC80")]
	private void KALLCBOGNLH(float JELOPBOIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x83962B0", Offset = "0x8394CB0", VA = "0x1883962B0")]
	private void NFGBBJKLGHJ([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x838B390", Offset = "0x8389D90", VA = "0x18838B390")]
	private void IDNEPFOJDMJ(OPLBHNJBLLG OJCPACNCMBB, IKSolverVR.Arm AOAAONAINNP, Transform CFNJGAPJPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8399F00", Offset = "0x8398900", VA = "0x188399F00")]
	private void PJJMDNBAMML(KMBDFNEGPNB IMNBLKDCAKA, AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8382EB0", Offset = "0x83818B0", VA = "0x188382EB0")]
	private void BKCNMPFFBMH(ALPKJGEEHOD PCOABABJINI, KHMNFMMABMJ OJCPACNCMBB, IKSolverVR.Arm AOAAONAINNP, float MEPGCHMDHDF, float ANJLLCCIDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8399CF0", Offset = "0x83986F0", VA = "0x188399CF0")]
	private void PGHEIODBMJG([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x838B6E0", Offset = "0x838A0E0", VA = "0x18838B6E0")]
	private void ILBJFOLNBCF([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8381E50", Offset = "0x8380850", VA = "0x188381E50")]
	protected void AKBNICBOMCN([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8388600", Offset = "0x8387000", VA = "0x188388600")]
	private void HACPEAOHLEK([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83986E0", Offset = "0x83970E0", VA = "0x1883986E0")]
	protected void OJPDMGGDOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x838E540", Offset = "0x838CF40", VA = "0x18838E540")]
	private void KHMIMFNFIKI([In] KMBDFNEGPNB IMNBLKDCAKA, [In] KAKHLMKLDMO GEGAHCCHNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x838BCE0", Offset = "0x838A6E0", VA = "0x18838BCE0")]
	private void IMLNIBGIHKH(KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83964D0", Offset = "0x8394ED0", VA = "0x1883964D0")]
	private void NJJHJGFIDCK([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8394BE0", Offset = "0x83935E0", VA = "0x188394BE0")]
	private Vector3 LNKKFGEDECA([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8385B80", Offset = "0x8384580", VA = "0x188385B80")]
	private void EGCDNPNLCIO([In] KMBDFNEGPNB IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x838D830", Offset = "0x838C230", VA = "0x18838D830")]
	private float JJNMIHHFCFN(float MAFBNCIAPON, [In] KMBDFNEGPNB IMNBLKDCAKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8398590", Offset = "0x8396F90", VA = "0x188398590")]
	private void OJNNCNNDCCK(float MAFBNCIAPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8384370", Offset = "0x8382D70", VA = "0x188384370")]
	private void DJFPPKONKAO([In] KMBDFNEGPNB IMNBLKDCAKA, KAKHLMKLDMO GEGAHCCHNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8385380", Offset = "0x8383D80", VA = "0x188385380")]
	private float EEENIFGHGCH([In] KMBDFNEGPNB MEIGHMBNIHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8390DE0", Offset = "0x838F7E0", VA = "0x188390DE0")]
	private void KOBALOJJPHF(KMBDFNEGPNB IMNBLKDCAKA, KAKHLMKLDMO GEGAHCCHNHP, Vector3 KGKHOCLKNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x839A450", Offset = "0x8398E50", VA = "0x18839A450")]
	private static void PMCHKJFJGON(Transform HALOMIKDIAH, Quaternion AMHDLJKDJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x83915E0", Offset = "0x838FFE0", VA = "0x1883915E0")]
	private void KOBIKDHPHAO([In] KMBDFNEGPNB NKAOIPCLIAI, [In] PPPHCDIICIH LADKMELLHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x83822E0", Offset = "0x8380CE0", VA = "0x1883822E0")]
	private void ANLDACNCIKC([In] KMBDFNEGPNB NKAOIPCLIAI, [In] PPPHCDIICIH LADKMELLHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x839A620", Offset = "0x8399020", VA = "0x18839A620")]
	private void POKLDMFNMDH(float MGIBDHFHPHO, [In] KMBDFNEGPNB MEIGHMBNIHM, float FNHNPODJKDE = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x838D070", Offset = "0x838BA70", VA = "0x18838D070")]
	private float JIKOFLINLKB([In] KMBDFNEGPNB MEIGHMBNIHM, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8396BB0", Offset = "0x83955B0", VA = "0x188396BB0")]
	private void OAGLHIEIMOM([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x838BF60", Offset = "0x838A960", VA = "0x18838BF60")]
	private void INNHHPJEBLP([In] KMBDFNEGPNB MEIGHMBNIHM, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x838AFC0", Offset = "0x83899C0", VA = "0x18838AFC0")]
	private void IBPNEJMNBIE([In] KMBDFNEGPNB MEIGHMBNIHM, float FJPCCJDKGOG, float CDBGHGFJLMG, Vector3 EGNHDOLHJMM, float FNHNPODJKDE = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x83918E0", Offset = "0x83902E0", VA = "0x1883918E0")]
	private void KOCKCBJJFCC(KMBDFNEGPNB MEIGHMBNIHM, AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8384A60", Offset = "0x8383460", VA = "0x188384A60")]
	private void DJIHLLKCMDI(KMBDFNEGPNB IMNBLKDCAKA, AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8388140", Offset = "0x8386B40", VA = "0x188388140")]
	private void HABLJJDDICA(KMBDFNEGPNB MEIGHMBNIHM, AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x83946E0", Offset = "0x83930E0", VA = "0x1883946E0")]
	public void KPCILALEGOD([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8387300", Offset = "0x8385D00", VA = "0x188387300")]
	public void GELKIPKDCME([In] KMBDFNEGPNB IMNBLKDCAKA, [In] AvatarFullBodyConfiguration OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8396A10", Offset = "0x8395410", VA = "0x188396A10")]
	[CompilerGenerated]
	internal static void NPKCDCCOLKL(Transform KGCMICBGABJ, IKSolverVR.Arm AOAAONAINNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8396200", Offset = "0x8394C00", VA = "0x188396200")]
	[CompilerGenerated]
	internal static void NELLDEPHELN(Vector3 KHFPLGDHBAJ, Vector3 FEHPHGDIDNG, MEMDPJBDKDM P_2, DICAEMGCICN P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x83980D0", Offset = "0x8396AD0", VA = "0x1883980D0")]
	[CompilerGenerated]
	internal static void OFCJPJKKICI(OPHNJCNNMBB PGOMHEPFAHN, OPHNJCNNMBB CFANFMFEGJH, Vector3 HCGLIJBFCHC, float IHPAEKNOMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8399BE0", Offset = "0x83985E0", VA = "0x188399BE0")]
	[CompilerGenerated]
	internal static bool PDPCOADJBJJ(IKSolverVR.Arm AOAAONAINNP, KCPJCLLOFLD GOOKJAPFHOF, float FENMBLKBDBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8395CF0", Offset = "0x83946F0", VA = "0x188395CF0")]
	[CompilerGenerated]
	internal static float NAHEJEAOJPN(Vector3 CLKPJNCBJMM, Vector3 DOHJAHGAHNC, Vector3 LGGIFIKBBOE, KMBDFNEGPNB MEIGHMBNIHM, AvatarFullBodyConfiguration OINEAODAACF, float JBCPGNDLJHB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class OKANCGANMGJ : KDIMJJLKDAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Dictionary<string, CDMJHEHKDNI> FBLAEGLFLFD;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x83A5ED0", Offset = "0x83A48D0", VA = "0x1883A5ED0")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void BBJEBMEADHL(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x83A6080", Offset = "0x83A4A80", VA = "0x1883A6080", Slot = "4")]
	public CDMJHEHKDNI GALKFHBAFPN(string OFJFKDCDMOC, AvatarSystemConfiguration OEPEIJIAHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x83A62A0", Offset = "0x83A4CA0", VA = "0x1883A62A0", Slot = "5")]
	public void IOIKFEPNMAA(string OFJFKDCDMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x83A5F40", Offset = "0x83A4940", VA = "0x1883A5F40", Slot = "6")]
	public string BNCLJEOHFBB(string MODHABCFJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x83A5E60", Offset = "0x83A4860", VA = "0x1883A5E60")]
	private string AJMILOGLPPG(string MODHABCFJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x83A6480", Offset = "0x83A4E80", VA = "0x1883A6480")]
	public OKANCGANMGJ()
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
		public class EOIFLKBNBLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private Dictionary<string, Transform> IBHGJFPGAOA;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool DGOCJDKBCHH
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x83A1A50", Offset = "0x83A0450", VA = "0x1883A1A50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x83A1AE0", Offset = "0x83A04E0", VA = "0x1883A1AE0")]
			public void OGCGADGIMLJ(VRIK BNNMPHDGCMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
			public void HLBCOPJOJCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x83A1A90", Offset = "0x83A0490", VA = "0x1883A1A90")]
			public void NPPCJNEPLIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x83A1C10", Offset = "0x83A0610", VA = "0x1883A1C10")]
			public EOIFLKBNBLC()
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
		[JOGPDLJFLHG(EAHEBLGAGFP.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[IHBEENDFBCJ(EAHEBLGAGFP.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly EOIFLKBNBLC IAEECKNHEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private INNDGHFJNFN EGOBIHAOIDE;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x839D0F0", Offset = "0x839BAF0", VA = "0x18839D0F0")]
		private void GFALNPPLGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x839D3E0", Offset = "0x839BDE0", VA = "0x18839D3E0")]
		private bool PBFJFAPHIKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x839D3D0", Offset = "0x839BDD0", VA = "0x18839D3D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x839D490", Offset = "0x839BE90", VA = "0x18839D490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x839D430", Offset = "0x839BE30", VA = "0x18839D430")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x839D700", Offset = "0x839C100", VA = "0x18839D700")]
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
			[Cpp2IlInjected.Address(RVA = "0x83A2BB0", Offset = "0x83A15B0", VA = "0x1883A2BB0")]
			public (float, float) LBHMHJGMDIO(float IDAOCICMKCA)
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x83A22A0", Offset = "0x83A0CA0", VA = "0x1883A22A0")]
			public void LHEJPJMHOBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x83A2380", Offset = "0x83A0D80", VA = "0x1883A2380")]
			public (float, float) MIPDEIDOIOB(Animator IHODMJDGGML, AnimatorStateInfo IIINLIKHDIH)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
		[Cpp2IlInjected.Address(RVA = "0x83A2700", Offset = "0x83A1100", VA = "0x1883A2700")]
		public void LHEJPJMHOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83A24C0", Offset = "0x83A0EC0", VA = "0x1883A24C0")]
		public (float, float) HFADFDDPNCD(Animator IHODMJDGGML, NLMGCLIMLFL PAKMCAALBGL, float OLHOFPIMNMA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83A28F0", Offset = "0x83A12F0", VA = "0x1883A28F0")]
		private (float, float) PLNHCLNCICL(Animator IHODMJDGGML, AnimatorStateInfo IIINLIKHDIH, NLMGCLIMLFL PAKMCAALBGL, float OLHOFPIMNMA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83A2BA0", Offset = "0x83A15A0", VA = "0x1883A2BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83A5CD0", Offset = "0x83A46D0", VA = "0x1883A5CD0", Slot = "4")]
		public override void OnStateEnter(Animator IHODMJDGGML, AnimatorStateInfo IIINLIKHDIH, int AGBDBCAGPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x83A5E40", Offset = "0x83A4840", VA = "0x1883A5E40")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class OEELHDBCAHC<TInput, TOutput> : BPBFAJFIOAA<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	protected readonly AFCBJHNNPNF LEAGHOGAOII;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5BA30B0", Offset = "0x5BA1AB0", VA = "0x185BA30B0")]
	protected OEELHDBCAHC(AFCBJHNNPNF LEAGHOGAOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput LEOAOCFGODA(TInput GHANLDMHBLD, [Out] IReadOnlyList<HKGMBANLFND>? EODEMANNLNK);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5BA3010", Offset = "0x5BA1A10", VA = "0x185BA3010", Slot = "5")]
	public bool BJKPACBAKFA(TInput GHANLDMHBLD, [Out] TOutput? GGIKEMCHAAA, [Out] IReadOnlyList<HKGMBANLFND>? EODEMANNLNK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[LDDMKMABCFO]
public static class MMGDFIGPACB
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly Regex CDDEOCGBAAF;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x83A5770", Offset = "0x83A4170", VA = "0x1883A5770")]
	public static DDAAEBMIBEO CKHJKKJBDPH(KCNLPKHKIFL NKDDKILHAIA, CKPKFPAKPLM KGEHMELJMHC, Guid? PCPOOIGHMLK, Color? ELLBPGOKDFA, EHMKAKBCPJB GDCGOHLFNLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x83A5AD0", Offset = "0x83A44D0", VA = "0x1883A5AD0")]
	public static NCHELFAJJGK OBGOPJHOPHJ(DDAAEBMIBEO BLPDDGCLNPE)
	{
		return default(NCHELFAJJGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3EA2A90", Offset = "0x3EA1490", VA = "0x183EA2A90")]
	internal static TModern? KALFNFHDIDJ<TModern>(string? GHANLDMHBLD, FNNGFKJFEMK<TModern> NPCEJKKFBCE, AFCBJHNNPNF LEAGHOGAOII, MLNDKAPIBGE CCIAAFGJINI, TModern OIDAALDBBEM) where TModern : struct, CNAKNBPLFLB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA40E0", Offset = "0x3EA2AE0", VA = "0x183EA40E0")]
	internal static CDMOKKNOPKM OBOEAMNEABA<TModern>(string? GHANLDMHBLD, FNNGFKJFEMK<TModern> NPCEJKKFBCE, AFCBJHNNPNF LEAGHOGAOII, MLNDKAPIBGE CCIAAFGJINI, TModern OIDAALDBBEM) where TModern : struct, CNAKNBPLFLB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x83A5980", Offset = "0x83A4380", VA = "0x1883A5980")]
	internal static List<HKGMBANLFND> IMBADOPJGGJ(IEnumerable<CELDHBEKCDH>? EMLAEABMMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3EA1C10", Offset = "0x3EA0610", VA = "0x183EA1C10")]
	internal static string BFEKNMDNDEK<TModern>(TModern GHANLDMHBLD, FNNGFKJFEMK<TModern> NPCEJKKFBCE, AFCBJHNNPNF LEAGHOGAOII) where TModern : CNAKNBPLFLB
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class ANNKCHMBICP : JHNPEHPONLI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BPBFAJFIOAA<JMBIIDEIJMI, DECEKEGDNPK> OHLPKGPGIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BPBFAJFIOAA<BNNANBPCKPP, ABLACFOHHEB> NBMOOCNGCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BPBFAJFIOAA<BNNANBPCKPP, ABLACFOHHEB> IPHKCCAFLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public OFDKDFMJMND EKBACMAAEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public MKIEJPDGAPM BKIEIJLGILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x839C100", Offset = "0x839AB00", VA = "0x18839C100")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	[UsedImplicitly]
	internal static void EHDGAPALFJP(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x839C170", Offset = "0x839AB70", VA = "0x18839C170")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ANNKCHMBICP([BMCONCJPCIA("UnitySerialization")] JKFGDJDCFPA OLEEILBGOLB, [BMCONCJPCIA(null)] DLFALJHALEC FKKDBGIKNON, [BMCONCJPCIA(null)] AFCBJHNNPNF LEAGHOGAOII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum MNBAONGHBPE
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
public class GLIBGMIDAKM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x83A1D40", Offset = "0x83A0740", VA = "0x1883A1D40")]
	public GLIBGMIDAKM(string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x83A1CA0", Offset = "0x83A06A0", VA = "0x1883A1CA0")]
	public GLIBGMIDAKM(string JEBOHIALEMJ, Exception BFLPFMDLFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x83A1D10", Offset = "0x83A0710", VA = "0x1883A1D10")]
	public GLIBGMIDAKM(MNBAONGHBPE DDFEAKLIDDG, string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x83A1CD0", Offset = "0x83A06D0", VA = "0x1883A1CD0")]
	public GLIBGMIDAKM(MNBAONGHBPE DDFEAKLIDDG, string JEBOHIALEMJ, Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class LKPAPJPDEBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly JKFGDJDCFPA OLEEILBGOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected readonly DLFALJHALEC FKKDBGIKNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	protected readonly AFCBJHNNPNF LEAGHOGAOII;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x83A3360", Offset = "0x83A1D60", VA = "0x1883A3360")]
	protected LKPAPJPDEBA(JKFGDJDCFPA OLEEILBGOLB, DLFALJHALEC FKKDBGIKNON, AFCBJHNNPNF LEAGHOGAOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x83A4130", Offset = "0x83A2B30", VA = "0x1883A4130")]
	protected string LDDCCECEBDL(DECEKEGDNPK AIFAODPNIHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x83A3C10", Offset = "0x83A2610", VA = "0x1883A3C10")]
	protected string AIOAAOMBAOE(DECEKEGDNPK AIFAODPNIHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x83A3E00", Offset = "0x83A2800", VA = "0x1883A3E00")]
	private AvatarOutfitSelectionData CKHJKKJBDPH(DDAAEBMIBEO GMLADKDADNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x83A5430", Offset = "0x83A3E30", VA = "0x1883A5430")]
	private static AvatarCustomizationSettingsData.AnchorParams MMKCGCJEKCP(AFKHHJFHFCH? AJCEKGACABD)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BPBFAJFIOAA<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput LEOAOCFGODA(TInput GHANLDMHBLD, [Out] IReadOnlyList<HKGMBANLFND>? EODEMANNLNK);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BJKPACBAKFA(TInput GHANLDMHBLD, [Out] TOutput? GGIKEMCHAAA, [Out] IReadOnlyList<HKGMBANLFND>? EODEMANNLNK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JHNPEHPONLI
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	BPBFAJFIOAA<JMBIIDEIJMI, DECEKEGDNPK> OHLPKGPGIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BPBFAJFIOAA<BNNANBPCKPP, ABLACFOHHEB> IPHKCCAFLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	OFDKDFMJMND EKBACMAAEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum MLNDKAPIBGE
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MKIEJPDGAPM
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PALFIHGDMPK GCGCKFHBJPB(DECEKEGDNPK BLPDDGCLNPE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface OFDKDFMJMND
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BNNANBPCKPP GCGCKFHBJPB(DECEKEGDNPK BLPDDGCLNPE, int CKOENHFPFNP, string? IELIBBNCJAC, string? PLGKCPJHJIM, OGPADJCDAAA MHLPAIHPPIO, List<HKGMBANLFND>? EODEMANNLNK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[LDDMKMABCFO]
internal class CFNAPAJCAHO : OEELHDBCAHC<JMBIIDEIJMI, DECEKEGDNPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly DLFALJHALEC FKKDBGIKNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly ECAFABHJCID AENGBJJKOOB;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x839DA90", Offset = "0x839C490", VA = "0x18839DA90")]
	public CFNAPAJCAHO(JKFGDJDCFPA OLEEILBGOLB, DLFALJHALEC FKKDBGIKNON, AFCBJHNNPNF LEAGHOGAOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x839D7E0", Offset = "0x839C1E0", VA = "0x18839D7E0", Slot = "6")]
	public override DECEKEGDNPK LEOAOCFGODA(JMBIIDEIJMI GHANLDMHBLD, [Out] IReadOnlyList<HKGMBANLFND>? EODEMANNLNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class DHPHJOCECLO : JKFGDJDCFPA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class LLOKMLMLENM : JsonConverter<CDMOKKNOPKM>
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83A5690", Offset = "0x83A4090", VA = "0x1883A5690", Slot = "9")]
		public override void WriteJson(JsonWriter EAPDKLFLMNB, CDMOKKNOPKM? KMAFNKGMDCF, JsonSerializer PKOJFJHILAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83A5570", Offset = "0x83A3F70", VA = "0x1883A5570", Slot = "10")]
		public override CDMOKKNOPKM ReadJson(JsonReader DIKMKPGIBMB, Type EGBJFHNDMCP, CDMOKKNOPKM? IPBDJBGKODN, bool JIAGKDENELH, JsonSerializer PKOJFJHILAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x83A5730", Offset = "0x83A4130", VA = "0x1883A5730")]
		public LLOKMLMLENM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class ANBJCOKHGLP : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool AMMOLAMGIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x839BFC0", Offset = "0x839A9C0", VA = "0x18839BFC0", Slot = "5")]
		public override object ReadJson(JsonReader DIKMKPGIBMB, Type EGBJFHNDMCP, object? IPBDJBGKODN, JsonSerializer PKOJFJHILAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x839BC00", Offset = "0x839A600", VA = "0x18839BC00", Slot = "6")]
		public override bool CanConvert(Type EGBJFHNDMCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x839C020", Offset = "0x839AA20", VA = "0x18839C020", Slot = "4")]
		public override void WriteJson(JsonWriter EAPDKLFLMNB, object? KMAFNKGMDCF, JsonSerializer PKOJFJHILAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x839BDE0", Offset = "0x839A7E0", VA = "0x18839BDE0")]
		private static bool DPAOHDDLPCO(object KMAFNKGMDCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public ANBJCOKHGLP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly JsonSerializerSettings ANGOOFAAJMM;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x839DC60", Offset = "0x839C660", VA = "0x18839DC60")]
	internal DHPHJOCECLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1830", Offset = "0x3BD0230", VA = "0x183BD1830", Slot = "4")]
	public string MDKPBKCGMBC<T>(T PMNHIPACJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3BD17B0", Offset = "0x3BD01B0", VA = "0x183BD17B0", Slot = "5")]
	public T DOIKGOAEAHP<T>(string KMAFNKGMDCF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class HPCOJEPOHOK : JKFGDJDCFPA
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB470", Offset = "0x3DD9E70", VA = "0x183DDB470", Slot = "4")]
	public string MDKPBKCGMBC<T>(T PMNHIPACJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB410", Offset = "0x3DD9E10", VA = "0x183DDB410", Slot = "5")]
	public T DOIKGOAEAHP<T>(string KMAFNKGMDCF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HPCOJEPOHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[LDDMKMABCFO]
internal class ECAFABHJCID : OEELHDBCAHC<BNNANBPCKPP, ABLACFOHHEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly JKFGDJDCFPA OLEEILBGOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly DLFALJHALEC FKKDBGIKNON;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x83A0230", Offset = "0x839EC30", VA = "0x1883A0230")]
	public ECAFABHJCID(JKFGDJDCFPA OLEEILBGOLB, DLFALJHALEC FKKDBGIKNON, AFCBJHNNPNF LEAGHOGAOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x839F690", Offset = "0x839E090", VA = "0x18839F690", Slot = "6")]
	public override ABLACFOHHEB LEOAOCFGODA(BNNANBPCKPP GHANLDMHBLD, [Out] IReadOnlyList<HKGMBANLFND>? EODEMANNLNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x83A00E0", Offset = "0x839EAE0", VA = "0x1883A00E0")]
	internal void PPMNEDCPAGJ(string NILCIGHBBCP, DECEKEGDNPK AIFAODPNIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x839E660", Offset = "0x839D060", VA = "0x18839E660")]
	public IEnumerable<DDAAEBMIBEO> CKOIOICMAJK(string FCOGNPAEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x839FCC0", Offset = "0x839E6C0", VA = "0x18839FCC0")]
	private IEnumerable<DDAAEBMIBEO> PGNFIOJLHHB(string FCOGNPAEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x839EDC0", Offset = "0x839D7C0", VA = "0x18839EDC0")]
	internal IEnumerable<DDAAEBMIBEO> IBHBBMBDBMG(string FCOGNPAEDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x839E710", Offset = "0x839D110", VA = "0x18839E710")]
	private DDAAEBMIBEO FMGFDOIIHHB(AvatarOutfitSelectionData HPKGOBILFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x839DDC0", Offset = "0x839C7C0", VA = "0x18839DDC0")]
	private void CEHPEENNIKL(AvatarCustomizationSettingsData LLAHJDBJKCB, DECEKEGDNPK AIFAODPNIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x839EAA0", Offset = "0x839D4A0", VA = "0x18839EAA0")]
	private DDAAEBMIBEO FMGFDOIIHHB(string IDIMEJMDHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x839F390", Offset = "0x839DD90", VA = "0x18839F390")]
	internal static (EHMKAKBCPJB, string, string) KBMIOHHPEHL(string IDIMEJMDHIG, AFCBJHNNPNF LEAGHOGAOII)
	{
		return default((EHMKAKBCPJB, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x839FAC0", Offset = "0x839E4C0", VA = "0x18839FAC0")]
	private NOMMIKCFBEP? MGDIABDFNKJ(string? OCONCDFGCOB, Vector2 EFCINLKKPIC, float HBOHCMBAGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x839F230", Offset = "0x839DC30", VA = "0x18839F230")]
	private static AFKHHJFHFCH JNCFLDEDLKM(AvatarCustomizationSettingsData.AnchorParams PADCCFJIPKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[LDDMKMABCFO]
internal class IMIIPMPLPKG : LKPAPJPDEBA, MKIEJPDGAPM
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x83A3360", Offset = "0x83A1D60", VA = "0x1883A3360")]
	public IMIIPMPLPKG(JKFGDJDCFPA OLEEILBGOLB, DLFALJHALEC FKKDBGIKNON, AFCBJHNNPNF LEAGHOGAOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x83A2C70", Offset = "0x83A1670", VA = "0x1883A2C70", Slot = "4")]
	public PALFIHGDMPK GCGCKFHBJPB(DECEKEGDNPK BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x83A3260", Offset = "0x83A1C60", VA = "0x1883A3260")]
	private string PFFBJNDKEPD(DECEKEGDNPK AIFAODPNIHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x83A3020", Offset = "0x83A1A20", VA = "0x1883A3020")]
	private string GCPKKHJLJJK(DDAAEBMIBEO GMLADKDADNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[LDDMKMABCFO]
internal class HGIIMIHLBBD : OEELHDBCAHC<BNNANBPCKPP, ABLACFOHHEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly JKFGDJDCFPA OLEEILBGOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly BPBFAJFIOAA<BNNANBPCKPP, ABLACFOHHEB> MLNCIOEECMB;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x83A21A0", Offset = "0x83A0BA0", VA = "0x1883A21A0")]
	public HGIIMIHLBBD(BPBFAJFIOAA<BNNANBPCKPP, ABLACFOHHEB> MLNCIOEECMB, AFCBJHNNPNF LEAGHOGAOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x83A1D70", Offset = "0x83A0770", VA = "0x1883A1D70", Slot = "6")]
	public override ABLACFOHHEB LEOAOCFGODA(BNNANBPCKPP GHANLDMHBLD, [Out] IReadOnlyList<HKGMBANLFND>? EODEMANNLNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[LDDMKMABCFO]
internal class KKONHFKBAPO : OFDKDFMJMND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly JKFGDJDCFPA OLEEILBGOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly MKIEJPDGAPM AACIFJDMPLE;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x83A3B20", Offset = "0x83A2520", VA = "0x1883A3B20")]
	public KKONHFKBAPO(MKIEJPDGAPM AACIFJDMPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x83A3770", Offset = "0x83A2170", VA = "0x1883A3770", Slot = "4")]
	public BNNANBPCKPP GCGCKFHBJPB(DECEKEGDNPK BLPDDGCLNPE, int CKOENHFPFNP, string? IELIBBNCJAC, string? PLGKCPJHJIM, OGPADJCDAAA MHLPAIHPPIO, List<HKGMBANLFND>? EODEMANNLNK)
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
		[Cpp2IlInjected.Address(RVA = "0x839C780", Offset = "0x839B180", VA = "0x18839C780")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class JDLFBBOPGDD
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x83A3600", Offset = "0x83A2000", VA = "0x1883A3600")]
	public static NCHELFAJJGK LEOAOCFGODA(this AAACIHKFAKF BLPDDGCLNPE)
	{
		return default(NCHELFAJJGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x83A34E0", Offset = "0x83A1EE0", VA = "0x1883A34E0")]
	public static AAACIHKFAKF GCGCKFHBJPB(this NCHELFAJJGK PCKJIKHONCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x83A3710", Offset = "0x83A2110", VA = "0x1883A3710")]
	public static bool PDODMMMBKED(this NCHELFAJJGK PCKJIKHONCF)
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
			[Cpp2IlInjected.Address(RVA = "0x63099B0", Offset = "0x63083B0", VA = "0x1863099B0")]
			public AnchorParams(Vector2 FLFMNJAAFPM, Vector3 IICJEOAGFHF, Vector3 LGJLLGFMONL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x839C6D0", Offset = "0x839B0D0", VA = "0x18839C6D0")]
			internal AFKHHJFHFCH GCGCKFHBJPB()
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
		private FKFKFDENFBG useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x839CFB0", Offset = "0x839B9B0", VA = "0x18839CFB0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x18ED3A0", Offset = "0x18EBDA0", VA = "0x1818ED3A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x10DF360", Offset = "0x10DDD60", VA = "0x1810DF360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x15FEFB0", Offset = "0x15FD9B0", VA = "0x1815FEFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x839D060", Offset = "0x839BA60", VA = "0x18839D060")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xABBE40", Offset = "0xABA840", VA = "0x180ABBE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD84490", Offset = "0xD82E90", VA = "0x180D84490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD84650", Offset = "0xD83050", VA = "0x180D84650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2A7D2E0", Offset = "0x2A7BCE0", VA = "0x182A7D2E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xFEB730", Offset = "0xFEA130", VA = "0x180FEB730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x12CD690", Offset = "0x12CC090", VA = "0x1812CD690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1ABA130", Offset = "0x1AB8B30", VA = "0x181ABA130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2663A40", Offset = "0x2662440", VA = "0x182663A40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1001780", Offset = "0x1000180", VA = "0x181001780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xAE4510", Offset = "0xAE2F10", VA = "0x180AE4510")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAE4570", Offset = "0xAE2F70", VA = "0x180AE4570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xAB7BB0", Offset = "0xAB65B0", VA = "0x180AB7BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xAB7AD0", Offset = "0xAB64D0", VA = "0x180AB7AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB79800", Offset = "0xB78200", VA = "0x180B79800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xAB7AB0", Offset = "0xAB64B0", VA = "0x180AB7AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB795D0", Offset = "0xB77FD0", VA = "0x180B795D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xAB9490", Offset = "0xAB7E90", VA = "0x180AB9490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB795F0", Offset = "0xB77FF0", VA = "0x180B795F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xE2A010", Offset = "0xE28A10", VA = "0x180E2A010")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xE276B0", Offset = "0xE260B0", VA = "0x180E276B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public FKFKFDENFBG UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x10E68C0", Offset = "0x10E52C0", VA = "0x1810E68C0")]
			get
			{
				return default(FKFKFDENFBG);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x10E70F0", Offset = "0x10E5AF0", VA = "0x1810E70F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x10E8B30", Offset = "0x10E7530", VA = "0x1810E8B30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xD75210", Offset = "0xD73C10", VA = "0x180D75210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x839D080", Offset = "0x839BA80", VA = "0x18839D080")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x839D0A0", Offset = "0x839BAA0", VA = "0x18839D0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x839CC10", Offset = "0x839B610", VA = "0x18839CC10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
		public EHMKAKBCPJB BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private CLDEECFFPMA? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x839D0C0", Offset = "0x839BAC0", VA = "0x18839D0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
