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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8155890", Offset = "0x8154C90", VA = "0x188155890")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8155910", Offset = "0x8154D10", VA = "0x188155910", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EAFHNCFGKJO]
internal class DLCFCMIJAFH : LNKIDJMEHIB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DMJPNGGKKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public DLCFCMIJAFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AGMMOBNOCAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PNJLHGEDMNG DDFGHEAKDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HLAAMCKOKEB LBNCHJIMHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IDJMDLKIOFJ PHFMCLGCHFB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8138230", Offset = "0x8137630", VA = "0x188138230")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	[UsedImplicitly]
	internal static void BBPKCCDBHID(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8139C30", Offset = "0x8139030", VA = "0x188139C30")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DLCFCMIJAFH([PKIHAALFADL(null)] PNJLHGEDMNG DDFGHEAKDLB, [PKIHAALFADL(null)] HLAAMCKOKEB LBNCHJIMHOD, [PKIHAALFADL(null)] IDJMDLKIOFJ PHFMCLGCHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81390D0", Offset = "0x81384D0", VA = "0x1881390D0", Slot = "5")]
	public PKLMLDNJFKK PCNLLJFPEAM(AGMMOBNOCAG OEJHEOJFBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8138480", Offset = "0x8137880", VA = "0x188138480", Slot = "4")]
	public PKLMLDNJFKK FCKAKEDPCBE(AGMMOBNOCAG OEJHEOJFBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8139B20", Offset = "0x8138F20", VA = "0x188139B20", Slot = "6")]
	public HBAHGJJIJND PMALJONHOBA(PKLMLDNJFKK NGIAGNLBILI, int DNCNBFLLNOA, string? HDNPPEBJPAE, string? HNCJKEINFAH, POKGCAJLAGP LGGIEAFHOLJ, List<AMMBECAJBIA>? HPMPLFMFCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81381A0", Offset = "0x81375A0", VA = "0x1881381A0", Slot = "7")]
	public bool ANDDDBHFDKA(BBOLELEACLM DFLCJEMMILA, [Out] PKLMLDNJFKK? GPPGDEEJAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8138F60", Offset = "0x8138360", VA = "0x188138F60", Slot = "8")]
	public bool GIMFADDIKIG(HBAHGJJIJND CMKJMFOIEHO, [Out] PKLMLDNJFKK? GPPGDEEJAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8139040", Offset = "0x8138440", VA = "0x188139040", Slot = "9")]
	public bool KLDADIPMJAN(HBAHGJJIJND CMKJMFOIEHO, [Out] CJHBFKMKJAB? DFLCJEMMILA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3B122A0", Offset = "0x3B116A0", VA = "0x183B122A0")]
	private bool DONCEPDPLAE<TInput, TOutput>(TInput MICKAKKPGLH, AAFCHKPMHJG<TInput, TOutput> FCIBEHPCFDJ, [Out] TOutput? HJBCDFKDKBA) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8139980", Offset = "0x8138D80", VA = "0x188139980")]
	[CompilerGenerated]
	private CJIOEHLNJOG PHLHOOFKIBO(FaceFeatureType JEIPMELMMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x81382A0", Offset = "0x81376A0", VA = "0x1881382A0")]
	[CompilerGenerated]
	private CJIOEHLNJOG DLPMHJILLIJ(FaceFeatureType JEIPMELMMOO, DMJPNGGKKBG P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[EAFHNCFGKJO]
internal class IPPFICBNPAJ : PNJLHGEDMNG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void NMHEBCBAMOL<in TData>(TData GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BBCDLFFNCFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public ABLDIJJLPAC rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NPFFJCEJHIN currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public NPFFJCEJHIN latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BBCDLFFNCFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8138180", Offset = "0x8137580", VA = "0x188138180")]
		internal bool MMBDPJPKJAF(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8138100", Offset = "0x8137500", VA = "0x188138100")]
		internal bool HCCCADGKMBJ(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IDJMDLKIOFJ PHFMCLGCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KEPKCCNNHIG NMHGBBCEPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NMHEBCBAMOL<PKLMLDNJFKK>?[] DDFGHEAKDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NMHEBCBAMOL<CJHBFKMKJAB>?[] BGKKFNOLKGL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8139F80", Offset = "0x8139380", VA = "0x188139F80")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	[UsedImplicitly]
	internal static void BBPKCCDBHID(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x813B9B0", Offset = "0x813ADB0", VA = "0x18813B9B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IPPFICBNPAJ([PKIHAALFADL(null)] IDJMDLKIOFJ PHFMCLGCHFB, [PKIHAALFADL(null)] KEPKCCNNHIG NMHGBBCEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x813A500", Offset = "0x8139900", VA = "0x18813A500", Slot = "4")]
	public bool DDPCMBHKFAH(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x813A600", Offset = "0x8139A00", VA = "0x18813A600", Slot = "5")]
	public bool DDPCMBHKFAH(CJHBFKMKJAB DFLCJEMMILA, IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x813A760", Offset = "0x8139B60", VA = "0x18813A760")]
	private void FJKLHJMJIPC(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8139FF0", Offset = "0x81393F0", VA = "0x188139FF0")]
	private void CNCFPFJIELP(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x813B670", Offset = "0x813AA70", VA = "0x18813B670")]
	private void NOPNOIGCHNP(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x813B450", Offset = "0x813A850", VA = "0x18813B450")]
	private void HDDJFODOFBL(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x813B380", Offset = "0x813A780", VA = "0x18813B380")]
	private void GJLCCJKGDAO(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x813B5C0", Offset = "0x813A9C0", VA = "0x18813B5C0")]
	private void NOAABGGMOCA(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x813B510", Offset = "0x813A910", VA = "0x18813B510")]
	private void LAGHDMIPEHK(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x813B480", Offset = "0x813A880", VA = "0x18813B480")]
	private void HNCDOFLNOMA(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x813B6A0", Offset = "0x813AAA0", VA = "0x18813B6A0")]
	private void OAIHLLGOFIO(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x813B490", Offset = "0x813A890", VA = "0x18813B490")]
	private void JNOIIGIOLFA(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? PCKIEOGDDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x813B6D0", Offset = "0x813AAD0", VA = "0x18813B6D0")]
	private void OLOPMLCIFEM(PKLMLDNJFKK GPPGDEEJAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x813A220", Offset = "0x8139620", VA = "0x18813A220")]
	private PKLMLDNJFKK DAAOPPIPFAD(PKLMLDNJFKK GPPGDEEJAMN, List<RangeMigration> NNLJLOFPHGE, NPFFJCEJHIN CCBJFJMICGB, NPFFJCEJHIN BFCCJNOPINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x813B340", Offset = "0x813A740", VA = "0x18813B340")]
	private float GDEPPKDEHBJ(float LFDGAMLNPOJ, Vector2 PKHNGDNJOCF, Vector2 IPKDFBLBAOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8139DB0", Offset = "0x81391B0", VA = "0x188139DB0")]
	private (RangeMigration?, RangeMigration?) ALDDAFNEICK(List<RangeMigration> HOENMFCNCEJ, ABLDIJJLPAC OCCAGEMKJBP, NPFFJCEJHIN CCBJFJMICGB, NPFFJCEJHIN BFCCJNOPINC)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PNJLHGEDMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDPCMBHKFAH(PKLMLDNJFKK GPPGDEEJAMN, IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDPCMBHKFAH(CJHBFKMKJAB DFLCJEMMILA, IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD);
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
		public EEDBHFKLMBC AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x8135C20", Offset = "0x8135020", VA = "0x188135C20")]
		public void OINCCGHFJMA(AnimationPoseSetting LHDOHAKINKP, float PIFMNLLFMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8135D50", Offset = "0x8135150", VA = "0x188135D50")]
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
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x8136660", Offset = "0x8135A60", VA = "0x188136660")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8136620", Offset = "0x8135A20", VA = "0x188136620")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8135D70", Offset = "0x8135170", VA = "0x188135D70")]
		private void OILGPENCEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80C09E0", Offset = "0x80BFDE0", VA = "0x1880C09E0", Slot = "4")]
		public void SetEnabled(bool DGKJCLCLLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8136690", Offset = "0x8135A90", VA = "0x188136690")]
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
		[Cpp2IlInjected.Address(RVA = "0x81366D0", Offset = "0x8135AD0", VA = "0x1881366D0")]
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
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
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
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
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
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
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
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
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
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
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
		[Cpp2IlInjected.Address(RVA = "0x8136750", Offset = "0x8135B50", VA = "0x188136750")]
		public AnimationPoseSetting JBFGLPKGGPC(EEDBHFKLMBC AKIHLEBCPNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8136710", Offset = "0x8135B10", VA = "0x188136710")]
		public void IPJPKJAMFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8136780", Offset = "0x8135B80", VA = "0x188136780")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum CEADBJHGNLP
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private CEADBJHGNLP handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		[FormerlySerializedAs("color")]
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
		[Cpp2IlInjected.Address(RVA = "0x8137290", Offset = "0x8136690", VA = "0x188137290")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8137250", Offset = "0x8136650", VA = "0x188137250")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8136C30", Offset = "0x8136030", VA = "0x188136C30")]
		private void OILGPENCEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80C09E0", Offset = "0x80BFDE0", VA = "0x1880C09E0", Slot = "4")]
		public void SetEnabled(bool DGKJCLCLLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81372C0", Offset = "0x81366C0", VA = "0x1881372C0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, NJIKDDAGPDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private AGMMOBNOCAG avatarBodyType;

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
		[BNCHLJBJHLJ(FIPBCJPBODB.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		[FormerlySerializedAs("HeadTweakBone")]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private GEMHKEHPGAH KCJBDAALDGO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GEMHKEHPGAH DMMICDGJIGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAF7FE0", Offset = "0xAF73E0", VA = "0x180AF7FE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform CJINGHMNOGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x81380E0", Offset = "0x81374E0", VA = "0x1881380E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81372F0", Offset = "0x81366F0", VA = "0x1881372F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8137FA0", Offset = "0x81373A0", VA = "0x188137FA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8137F50", Offset = "0x8137350", VA = "0x188137F50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8137EE0", Offset = "0x81372E0", VA = "0x188137EE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81372F0", Offset = "0x81366F0", VA = "0x1881372F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8137730", Offset = "0x8136B30", VA = "0x188137730", Slot = "6")]
		public GEMHKEHPGAH CreateAvatarSystem(string GOAAHKDHGCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8137EE0", Offset = "0x81372E0", VA = "0x188137EE0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81373B0", Offset = "0x81367B0", VA = "0x1881373B0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8137FF0", Offset = "0x81373F0", VA = "0x188137FF0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float HBFJOJKDNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class NKFHFBOMBJD : GEMHKEHPGAH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class CMMLCKOFNHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 OGGDMAGKGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Quaternion MCKBHOEIOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Vector3 NBDFNDJKPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Transform GEMLNFDICEJ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 EKGEHMEBHCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x21DB7D0", Offset = "0x21DABD0", VA = "0x1821DB7D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x21DB7F0", Offset = "0x21DABF0", VA = "0x1821DB7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion IJEPBEELAKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x15DAA80", Offset = "0x15D9E80", VA = "0x1815DAA80")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x15DAA70", Offset = "0x15D9E70", VA = "0x1815DAA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float CILFFNFMJIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1246880", Offset = "0x1245C80", VA = "0x181246880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x19CB5F0", Offset = "0x19CA9F0", VA = "0x1819CB5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool JNPMDEBCKFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA703C0", Offset = "0xA6F7C0", VA = "0x180A703C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA70460", Offset = "0xA6F860", VA = "0x180A70460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool GDDNBJHMFLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA70160", Offset = "0xA6F560", VA = "0x180A70160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA70470", Offset = "0xA6F870", VA = "0x180A70470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool CFMMHCCFNBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA70490", Offset = "0xA6F890", VA = "0x180A70490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA702B0", Offset = "0xA6F6B0", VA = "0x180A702B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float KNMKJGKMFKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xDD8DA0", Offset = "0xDD81A0", VA = "0x180DD8DA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xDD80A0", Offset = "0xDD74A0", VA = "0x180DD80A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8159060", Offset = "0x8158460", VA = "0x188159060")]
		public void CLJHCIKJGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8159CB0", Offset = "0x81590B0", VA = "0x188159CB0")]
		public void LDACACFPAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8159090", Offset = "0x8158490", VA = "0x188159090")]
		public float DEEFDJKOOKD(Vector3 AHIEKHKOAJE, Quaternion DIPMCIKKHBM, [In] AvatarFootSettings JFMDBPKLEJP, float DFEDFLFIAJK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x81592A0", Offset = "0x81586A0", VA = "0x1881592A0")]
		public void FNMEMLAFFDP(Vector3 HLLKHOPFGEP, Quaternion FNPEFGGAHLN, Transform PNGEENJIGKI, float GNEJPGODJKL, bool IFNKGOMPDPM, bool HEEEMNHAACE, float OLKBGMMGLEF, float AJKCJKIFCLO, Transform LDEPDDDHLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8159A80", Offset = "0x8158E80", VA = "0x188159A80")]
		public void IMACEKGCHKB(Transform ENCPCNCKAGE, Transform LDEPDDDHLLO, bool APOIMPCJHBF, bool LCCBPOKMLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8159980", Offset = "0x8158D80", VA = "0x188159980")]
		private void HABANKEFHLL(Transform LDEPDDDHLLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8159CC0", Offset = "0x81590C0", VA = "0x188159CC0")]
		public bool PDFCMPLONEO(Transform LDEPDDDHLLO, AvatarFullBodyConfiguration HFDKCBHNBMB, Vector3 GCEAEHDIIJM, float NEDFPMDMPGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8159070", Offset = "0x8158470", VA = "0x188159070")]
		public void DAILFFPGPOF(float AJKCJKIFCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8159E10", Offset = "0x8159210", VA = "0x188159E10")]
		public CMMLCKOFNHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class FBFOMNFCJJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private float IEMPNBCCAIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private bool GEICHIAJPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public AnimationPoseSetting LPPCBPCLDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private float ADDEOJJABJN;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x815AAC0", Offset = "0x8159EC0", VA = "0x18815AAC0")]
		public void HOELOPAJEPJ(IKSolverVR.Arm MFNCDCOCFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x815B830", Offset = "0x815AC30", VA = "0x18815B830")]
		public void KAIJOFIAJPF(IKSolverVR.Arm MFNCDCOCFEF, float PDIPCAJJOFI, bool GEICHIAJPED, AvatarFullBodyConfiguration HFDKCBHNBMB, float EMAMJICFHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x815AA80", Offset = "0x8159E80", VA = "0x18815AA80")]
		private void FBFFKFDFPMK(IKSolverVR.Arm MFNCDCOCFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x815A210", Offset = "0x8159610", VA = "0x18815A210")]
		public void CEINCCCOAOC(IKSolverVR.Arm MFNCDCOCFEF, Transform LPMJHHLEMEG, Transform PNGEENJIGKI, Quaternion BKAOOOMHBAE, Vector3 HHEFLHFEFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x815A5F0", Offset = "0x81599F0", VA = "0x18815A5F0")]
		private (Vector3, Quaternion) ECGJNHPKNIG(CCIDKAHJCID AOHJEMCLGFD, Quaternion ECPCONBIAPL, Vector3 CGDJPMFGBOJ)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x815B6D0", Offset = "0x815AAD0", VA = "0x18815B6D0")]
		public void JNPBBFPNLCK(CCIDKAHJCID AOHJEMCLGFD, IKSolverVR.Arm MFNCDCOCFEF, Quaternion ECPCONBIAPL, Vector3 CGDJPMFGBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x815AC30", Offset = "0x815A030", VA = "0x18815AC30")]
		public void IABMCMLHIPG(CCIDKAHJCID AOHJEMCLGFD, IKSolverVR.Arm MFNCDCOCFEF, Quaternion ECPCONBIAPL, Vector3 CGDJPMFGBOJ, [In] AvatarFullBodyConfiguration HFDKCBHNBMB, [In] FEOCPHDGKMA JPDKKKJJNLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x815AAF0", Offset = "0x8159EF0", VA = "0x18815AAF0")]
		public void HPBHJKMNHIF(EEDBHFKLMBC ELGICIBOGNG, AvatarFullBodyConfiguration HFDKCBHNBMB, FEOCPHDGKMA JPDKKKJJNLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x815B230", Offset = "0x815A630", VA = "0x18815B230")]
		public void IMAKMIKLBPF(IKSolverVR.Arm MFNCDCOCFEF, Transform LPMJHHLEMEG, Vector3 IPPAGBBGGNE, float MAAJABAAELN, Quaternion NMJJJNBCBMF, Vector3 KMBBHCHOMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x815B870", Offset = "0x815AC70", VA = "0x18815B870")]
		public FBFOMNFCJJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum IEGDIABPOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PNELPJIMEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HKIAHMMMCNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int ICMLKPGDLHH;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int DINFNLIHNEJ;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int KLCFMACPJEE;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int GCAKILFEOLE;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int CNIMMBHDMBA;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int OBDFDFCPBOB;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int GJKGFNJMIHB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int OFMCMGKNFOB;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int COPICMGJIEN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int DANGGGMNHCL;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int MIJIIPKEAKF;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int IJEPNJDNHIA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int HBGEHDAEOCC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int DELLCDBBNMH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int ENKNNNGHMAD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int FAACAJLBGAI;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int AMEHDBCMAMD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int BNMOAEOPPNA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int NGHJHGKKBEG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int GEMJBBHLDCB;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int KFBAOELNNEH;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int GPPCBJIMEOE;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int OFEBIOIFPJH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int HIKPABLELAE;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int IPCLHGEAFKL;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int IPLFFOBPEJE;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int BLHBFFKBOJC;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int HFFPOLPHBJI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int PKLKMGAHFOE;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int DEJMMGGGDJA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int FGLCBIEHIJB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int BPFJFIBHIJG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Vector3 PBJPONEJOIH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int HMIJGHGIPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool NHMBDHLJIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool GMNALOMFEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool HGOCJEAKDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool ACGBHDNAHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool FEOBEAGLLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool KHIFGNPEACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Vector3 ENNGHPNEHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private string JHAKLNCADNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private MMNAOHGJCIL? NLNDMJGILNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NBGOCKIJAOF? NJJBMBFIGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private DDPPAPLKBEM JEBAFAACIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GMMJPMBNBJB LIIALFFJOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CCIDKAHJCID ACABEPPEDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CCIDKAHJCID HIHHDHGBINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool GMMHABNGDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool HGOLBJGKMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly BNKDELOCDNA DCGAFPNJPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly AHGKIFMFJKA FOGFGBAPEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private int GFFDOIALMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private float ECCJBPNPEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private GameObject JBDBCPJJIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform CBBPLEEOFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform IGPPCOKKLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform MKMHNGDMMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Transform EPDBAKOGHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float HCOBLJBFCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float IPHGIADKAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Vector3 CNDBKFEOIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Quaternion INCKLCJBPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform MBGFGDKNGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform EIHGEFJKLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Transform DFGJHLPANPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private CJJPLGLCIOB JLHPCDGIDPM;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker PDECGDOBHME;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly ProfilerMarker JGHBIIJGAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private ProfilerMarker CBEPKIBPOMF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker FKDPKEEDDKL;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker MMBMEJPAHNO;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker DGJOBFKGKDB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly List<NKFHFBOMBJD> ECHFHKCNHKO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int CEGALFFKIPE;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> EGBCKFMHPIP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int CNCLPMLODFI;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int ICIPALGCPFA;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int GPBIPFNDIPC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static int PMLLIGBGNKC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static float DJJOBAKFGLM;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int JJKGIEJFDIG;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float JJMMDKOIDBB;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float ONLAHPKBJDM;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float HHBGIFGHMDN;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static float FMEMBECKNFN;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static IAGGIEEPMAK HOLBMBAGFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float JCNGJIJFGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool BIFJAAMGGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private float BHOILLPJLFG;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int IEKCEBGINFK;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int MAGCJKCHGOK;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int MDAECLPLBAN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly int MEJJDINCJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private CMMLCKOFNHP IIPCNEFENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private CMMLCKOFNHP NELJLNFBCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private float BKGFIOEOELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 EEKEOGGMIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private Vector3 HOOPPOFGLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private bool MMELDIDAHHH;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion ILOOLEAFKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Quaternion JKMMKFEAPDD;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 AALGIMENLJD;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly Vector3 CMFJOKJOHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float KGDDJLMNCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float LFOAMDLEOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private FBFOMNFCJJM EJANINNKHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private FBFOMNFCJJM LKOPCBEMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private KGGEACCCEGF HNJEFIOMHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private PNGELAOKFOH BOPHGNCFBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly LGNKCFLAPMK AKBLCKJMNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float MPIGGNOADPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private float HHBMOCICGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly PNGELAOKFOH MMMJEGLPBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 PLLHKLHNHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private Vector3 BNFIMMNDAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float MCODOAPEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private float ADNFJPCMIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly PNGELAOKFOH JCMAMIACGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly KGGEACCCEGF EJBIHALIJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly PNGELAOKFOH BPMJJCCFAHH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OFFOKCJIMNI DJEPGHJEGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OFFOKCJIMNI LGENOJMKCCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration LOIAMBLPPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81534D0", Offset = "0x81528D0", VA = "0x1881534D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AGMMOBNOCAG BFNOIEAFADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x813C3E0", Offset = "0x813B7E0", VA = "0x18813C3E0", Slot = "24")]
		get
		{
			return default(AGMMOBNOCAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration NGDOBFPGMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8145280", Offset = "0x8144680", VA = "0x188145280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform ABNIENFLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8153C90", Offset = "0x8153090", VA = "0x188153C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform BMHBCGFEGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8146D80", Offset = "0x8146180", VA = "0x188146D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer KKHPDFEMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81481A0", Offset = "0x81475A0", VA = "0x1881481A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] BEOILLKNLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x814B900", Offset = "0x814AD00", VA = "0x18814B900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] JLFLDEIBIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81474A0", Offset = "0x81468A0", VA = "0x1881474A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator DHBPPJBFBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8143210", Offset = "0x8142610", VA = "0x188143210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK AIJDMIEPGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8153AC0", Offset = "0x8152EC0", VA = "0x188153AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private PJBHBAKDOAN CNNGMPDDGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8147380", Offset = "0x8146780", VA = "0x188147380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private PJBHBAKDOAN DIBHFDLBPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x81422B0", Offset = "0x81416B0", VA = "0x1881422B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private PJBHBAKDOAN EFKPMAFFMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x814A6F0", Offset = "0x8149AF0", VA = "0x18814A6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private PJBHBAKDOAN AINGMDDEDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x814FC50", Offset = "0x814F050", VA = "0x18814FC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private PJBHBAKDOAN OGBAGOOFCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x81445D0", Offset = "0x81439D0", VA = "0x1881445D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private PJBHBAKDOAN ELEGFGCIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x813C790", Offset = "0x813BB90", VA = "0x18813C790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private PJBHBAKDOAN PJPNILCDBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8153D50", Offset = "0x8153150", VA = "0x188153D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private PJBHBAKDOAN LKMCDPOOKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x813C320", Offset = "0x813B720", VA = "0x18813C320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public NBGOCKIJAOF AJGAILDDEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x814F660", Offset = "0x814EA60", VA = "0x18814F660", Slot = "16")]
		get
		{
			return default(NBGOCKIJAOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CNJDPLBKGCC CLGNFLFNIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB69270", Offset = "0xB68670", VA = "0x180B69270", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JMOFGJBGKPC BHPNLPMDAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB69260", Offset = "0xB68660", VA = "0x180B69260", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JHCCFFGGMLF PJHJKALHIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xBE1800", Offset = "0xBE0C00", VA = "0x180BE1800", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JHCCFFGGMLF KAKAAOGDJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB69500", Offset = "0xB68900", VA = "0x180B69500", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string JGFCKBOAGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform EAIPINCDBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x814D2F0", Offset = "0x814C6F0", VA = "0x18814D2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform FAGLMEJKLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x814A440", Offset = "0x8149840", VA = "0x18814A440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform BGFDBHBPACL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8144310", Offset = "0x8143710", VA = "0x188144310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform MCCMHLCEDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x814C780", Offset = "0x814BB80", VA = "0x18814C780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform HAMNAICKEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8147460", Offset = "0x8146860", VA = "0x188147460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool HPPHNBCLHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81492D0", Offset = "0x81486D0", VA = "0x1881492D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool FAMFLMGFJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81492D0", Offset = "0x81486D0", VA = "0x1881492D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool LIILOJBMJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x814C050", Offset = "0x814B450", VA = "0x18814C050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform LOJPBIPCCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81432D0", Offset = "0x81426D0", VA = "0x1881432D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject JBJNKCGNJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x814B660", Offset = "0x814AA60", VA = "0x18814B660", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets DKLBOCMGHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8146C30", Offset = "0x8146030", VA = "0x188146C30", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform LBJPGBPCADG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBE1080", Offset = "0xBE0480", VA = "0x180BE1080", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform MEEBFALNPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBCF8E0", Offset = "0xBCECE0", VA = "0x180BCF8E0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform KKLJNACDEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAE20D0", Offset = "0xAE14D0", VA = "0x180AE20D0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform PHPELPOIMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBE0830", Offset = "0xBDFC30", VA = "0x180BE0830", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 ODDCHPNEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8153B80", Offset = "0x8152F80", VA = "0x188153B80", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float MAGJPIGLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x814A480", Offset = "0x8149880", VA = "0x18814A480", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform OJGDPONACCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8146220", Offset = "0x8145620", VA = "0x188146220", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform NHPPPMHLDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x15BA280", Offset = "0x15B9680", VA = "0x1815BA280", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform DKHHAMOKKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAE28E0", Offset = "0xAE1CE0", VA = "0x180AE28E0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform DGEPPBLIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAE28F0", Offset = "0xAE1CF0", VA = "0x180AE28F0", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool GJDEFCJJAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x81544B0", Offset = "0x81538B0", VA = "0x1881544B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BBKKNBJGBDM<GEMHKEHPGAH.IAGLANAAGNO> NFDOPODAFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2235E00", Offset = "0x2235200", VA = "0x182235E00", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool ODJKOAEJBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x814B450", Offset = "0x814A850", VA = "0x18814B450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool CMOANAIPIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8153C10", Offset = "0x8153010", VA = "0x188153C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8147440", Offset = "0x8146840", VA = "0x188147440")]
	private float FLENCNJCDBE(PJNGMFEHKCP CBJJLDMFBOC, float MPEIAKPDEEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x813F9D0", Offset = "0x813EDD0", VA = "0x18813F9D0")]
	private void BJOMPOGOMIM([In] FEOCPHDGKMA PDBEGENGKOF, [In] AvatarFullBodyConfiguration HFDKCBHNBMB, bool CIIILNFACOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x814F280", Offset = "0x814E680", VA = "0x18814F280")]
	private float LJLKODKCLHH([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8148390", Offset = "0x8147790", VA = "0x188148390")]
	private float GIMOJKMKPLJ([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x814B4D0", Offset = "0x814A8D0", VA = "0x18814B4D0")]
	private void JCMEBKOELMB(FEOCPHDGKMA PDBEGENGKOF, AvatarFullBodyConfiguration HFDKCBHNBMB, bool CIIILNFACOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x814A020", Offset = "0x8149420", VA = "0x18814A020")]
	private void HFBIAFGHBLA([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8145310", Offset = "0x8144710", VA = "0x188145310")]
	private void ECECCAHPINL([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8155390", Offset = "0x8154790", VA = "0x188155390")]
	public NKFHFBOMBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x813F2D0", Offset = "0x813E6D0", VA = "0x18813F2D0", Slot = "13")]
	public void BIDKJBKICEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8146430", Offset = "0x8145830", VA = "0x188146430", Slot = "14")]
	public void EJNGDLHHKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x814C7C0", Offset = "0x814BBC0", VA = "0x18814C7C0", Slot = "15")]
	public void KPKMACLNEPC(bool OFJBKBOMAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x814C630", Offset = "0x814BA30", VA = "0x18814C630", Slot = "26")]
	public Transform KKHIECNHMOF(string GNBHHOHKOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x813F830", Offset = "0x813EC30", VA = "0x18813F830", Slot = "27")]
	public Vector3? BJGMCOGHAIB(string GNBHHOHKOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8151960", Offset = "0x8150D60", VA = "0x188151960", Slot = "7")]
	public void MLBIBLEAKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8141C70", Offset = "0x8141070", VA = "0x188141C70")]
	private void BKPMJGMPKFC(AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8145B20", Offset = "0x8144F20", VA = "0x188145B20", Slot = "8")]
	public void EGAELEMDIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8144210", Offset = "0x8143610", VA = "0x188144210")]
	private void DDCEBJGJGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8143BD0", Offset = "0x8142FD0", VA = "0x188143BD0")]
	private Vector3 CPEONBPHGPK([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x814B700", Offset = "0x814AB00", VA = "0x18814B700", Slot = "6")]
	public void JGHFAOELIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8148AF0", Offset = "0x8147EF0", VA = "0x188148AF0")]
	private void GLKDDFDMLIE(bool CIIILNFACOK, IEGDIABPOKJ JAEOBOMNFCG, AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8144690", Offset = "0x8143A90", VA = "0x188144690", Slot = "9")]
	public void DKFJKGKPIEC(float GHEBAMLHAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8151910", Offset = "0x8150D10", VA = "0x188151910")]
	private void MKLPMIFNJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x814FD10", Offset = "0x814F110", VA = "0x18814FD10", Slot = "4")]
	public void MHDEEKFIBKF(string GOAAHKDHGCK, MMNAOHGJCIL BEEKKMNOBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8147D20", Offset = "0x8147120", VA = "0x188147D20", Slot = "5")]
	public void GFKECFIBKEM(NBGOCKIJAOF GBBGGABPHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x814B2F0", Offset = "0x814A6F0", VA = "0x18814B2F0", Slot = "12")]
	public void IOOHPKACAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8146FF0", Offset = "0x81463F0", VA = "0x188146FF0", Slot = "25")]
	public void FENJGPCNLGJ([Out] Vector3 NJKHOANHAJM, [Out] Quaternion NMJJJNBCBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x814A410", Offset = "0x8149810", VA = "0x18814A410")]
	private void HFEGOIIDGCP([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x135CDE0", Offset = "0x135C1E0", VA = "0x18135CDE0", Slot = "28")]
	public void ODEJCDGMINO(float LCLBNMPNFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x814F310", Offset = "0x814E710", VA = "0x18814F310", Slot = "29")]
	public void LKHNJGHBBHO(float APCJEEOBDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x814FC00", Offset = "0x814F000", VA = "0x18814FC00", Slot = "46")]
	public void MDNMMMALGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x81431C0", Offset = "0x81425C0", VA = "0x1881431C0", Slot = "30")]
	public void CFNIFOPMMLC(bool CENCEKFIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x814D2A0", Offset = "0x814C6A0", VA = "0x18814D2A0", Slot = "31")]
	public HandLogicOffsets LDMEMHNIIKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8152A30", Offset = "0x8151E30", VA = "0x188152A30", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets NDEOOIDJEDO()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x81467E0", Offset = "0x8145BE0", VA = "0x1881467E0")]
	private void FABMACBLNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8152AF0", Offset = "0x8151EF0", VA = "0x188152AF0")]
	private void NDMDKGDDFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x814C220", Offset = "0x814B620", VA = "0x18814C220")]
	private void KDEIJGEJNKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8152C70", Offset = "0x8152070", VA = "0x188152C70")]
	private void NMPLPGGHOLN(HHMPDIJPAEB LLOFHEHCNEP, bool FLJJABAPNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8152F50", Offset = "0x8152350", VA = "0x188152F50")]
	private void NOBJFJILBIP(HHMPDIJPAEB LLOFHEHCNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8147CD0", Offset = "0x81470D0", VA = "0x188147CD0")]
	public Vector3 GEEBOMHLPMI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x813C4A0", Offset = "0x813B8A0", VA = "0x18813C4A0")]
	private void AGNDOFJEBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x813D240", Offset = "0x813C640", VA = "0x18813D240")]
	private void AINPNIKIFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8153E10", Offset = "0x8153210", VA = "0x188153E10")]
	private void PJAPEIBHKNO(FEOCPHDGKMA PDBEGENGKOF, AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8146280", Offset = "0x8145680", VA = "0x188146280")]
	private float EHDHFKFPADF([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x814C140", Offset = "0x814B540", VA = "0x18814C140")]
	private int KBMBGDHILNO([In] MENFIDEBANF HPBMDHPANGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8153590", Offset = "0x8152990", VA = "0x188153590")]
	private void OIEBCGGBIBG(FEOCPHDGKMA PDBEGENGKOF, bool ODOPCBKPJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x814A4D0", Offset = "0x81498D0", VA = "0x18814A4D0")]
	private static void HJOEKKMFENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8149320", Offset = "0x8148720", VA = "0x188149320")]
	private static void HAJJNJLFFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8151590", Offset = "0x8150990", VA = "0x188151590")]
	private float MJFCIOJGGDO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x81545A0", Offset = "0x81539A0", VA = "0x1881545A0")]
	private static int PLDANNHDGAK(NKFHFBOMBJD JLJHECODIOL, NKFHFBOMBJD DABLONGJEGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x814D340", Offset = "0x814C740", VA = "0x18814D340", Slot = "41")]
	public FEOCPHDGKMA LILCPKODLGJ()
	{
		return default(FEOCPHDGKMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8143390", Offset = "0x8142790", VA = "0x188143390")]
	private bool CIAFNAOEDEN(int CLNGGGMIBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8148260", Offset = "0x8147660", VA = "0x188148260")]
	public void GHLLJJHBPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x81545D0", Offset = "0x81539D0", VA = "0x1881545D0")]
	private (bool, bool) PNLNELNJHNE()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x814A900", Offset = "0x8149D00", VA = "0x18814A900")]
	private (float, float) IDFJEBMDAKC([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x814D620", Offset = "0x814CA20", VA = "0x18814D620")]
	private void LJDCDAMCHHI([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81479B0", Offset = "0x8146DB0", VA = "0x1881479B0")]
	private void GCNABJEPPCC([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8146810", Offset = "0x8145C10", VA = "0x188146810")]
	private void FBMCEMBCNLK([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB, AvatarFootSettings JFMDBPKLEJP, bool OLHDCIFGBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x814F9C0", Offset = "0x814EDC0", VA = "0x18814F9C0")]
	private float MAEKPHPODAF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8144700", Offset = "0x8143B00", VA = "0x188144700")]
	private void DODNHGHJFIB(FEOCPHDGKMA JPDKKKJJNLC, AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x813C0C0", Offset = "0x813B4C0", VA = "0x18813C0C0")]
	private float AAEHPNFBBNG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8143D50", Offset = "0x8143150", VA = "0x188143D50")]
	private void DDBBMCAINHL([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x81426D0", Offset = "0x8141AD0", VA = "0x1881426D0")]
	private void CEINCCCOAOC([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x81530D0", Offset = "0x81524D0", VA = "0x1881530D0")]
	private void ODDBPBDJGND([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8144340", Offset = "0x8143740", VA = "0x188144340")]
	private void DEEDHEJKJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x814AC80", Offset = "0x814A080", VA = "0x18814AC80")]
	private void IEBKHLMGOPC(float JAIAEKHLNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x814D490", Offset = "0x814C890", VA = "0x18814D490")]
	private void LJAGPNDHFLP([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x814B060", Offset = "0x814A460", VA = "0x18814B060")]
	private void IELJJHGGPHG(CCIDKAHJCID DJAEBFDLNEG, IKSolverVR.Arm MFNCDCOCFEF, Transform ABNNODBMCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x814B9C0", Offset = "0x814ADC0", VA = "0x18814B9C0")]
	private void JKJBBPDOOOL(FEOCPHDGKMA JPDKKKJJNLC, AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x814BE80", Offset = "0x814B280", VA = "0x18814BE80")]
	private void JPHDMDHPIII(MDLGMEFJOML LFKCEGCPBCB, JHCCFFGGMLF DJAEBFDLNEG, IKSolverVR.Arm MFNCDCOCFEF, float PDIPCAJJOFI, float LFJPMDDMKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x813C110", Offset = "0x813B510", VA = "0x18813C110")]
	private void AAMIKMNECJK([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8145410", Offset = "0x8144810", VA = "0x188145410")]
	private void ECMNNKGDIEA([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8143810", Offset = "0x8142C10", VA = "0x188143810")]
	protected void CMJBJIOBOCF([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8152450", Offset = "0x8151850", VA = "0x188152450")]
	private void MOMCJHCJBPO([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x814F770", Offset = "0x814EB70", VA = "0x18814F770")]
	protected void LNPBGMGPKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8151C30", Offset = "0x8151030", VA = "0x188151C30")]
	private void MMDFDFFGMMP([In] FEOCPHDGKMA JPDKKKJJNLC, [In] IEGDIABPOKJ JAEOBOMNFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8146E40", Offset = "0x8146240", VA = "0x188146E40")]
	private void FDMLKJPIADD(FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x813D6A0", Offset = "0x813CAA0", VA = "0x18813D6A0")]
	private void AKNFBMJINHK([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x813E8C0", Offset = "0x813DCC0", VA = "0x18813E8C0")]
	private Vector3 BCKMCKJMLNO([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8146CB0", Offset = "0x81460B0", VA = "0x188146CB0")]
	private void FCGNCPOMENM([In] FEOCPHDGKMA JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8147560", Offset = "0x8146960", VA = "0x188147560")]
	private float FPCBEOCDIHE(float AJKCJKIFCLO, [In] FEOCPHDGKMA JPDKKKJJNLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x814A7B0", Offset = "0x8149BB0", VA = "0x18814A7B0")]
	private void ICGPEGIGIEA(float AJKCJKIFCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x813E1D0", Offset = "0x813D5D0", VA = "0x18813E1D0")]
	private void BBAOGAPLMGO([In] FEOCPHDGKMA JPDKKKJJNLC, IEGDIABPOKJ JAEOBOMNFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x81429C0", Offset = "0x8141DC0", VA = "0x1881429C0")]
	private float CEMIMEPDKHL([In] FEOCPHDGKMA PDBEGENGKOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x813D9D0", Offset = "0x813CDD0", VA = "0x18813D9D0")]
	private void AOONFNAIGAD(FEOCPHDGKMA JPDKKKJJNLC, IEGDIABPOKJ JAEOBOMNFCG, Vector3 FMPDGCIGGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8151760", Offset = "0x8150B60", VA = "0x188151760")]
	private static void MJLDMFBFNIG(Transform GANAIKEBLIG, Quaternion EMLGDFFEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x813EFD0", Offset = "0x813E3D0", VA = "0x18813EFD0")]
	private void BHFIOGGEFPH([In] FEOCPHDGKMA KACAMOGEMBH, [In] MENFIDEBANF HPBMDHPANGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8148410", Offset = "0x8147810", VA = "0x188148410")]
	private void GKAHKFOLPMH([In] FEOCPHDGKMA KACAMOGEMBH, [In] MENFIDEBANF HPBMDHPANGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x813EDE0", Offset = "0x813E1E0", VA = "0x18813EDE0")]
	private void BFPEDLIDNDP(float OOAMCNCODAJ, [In] FEOCPHDGKMA PDBEGENGKOF, float OKMLALGCNCM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x81414B0", Offset = "0x81408B0", VA = "0x1881414B0")]
	private float BKCGFAHDGMB([In] FEOCPHDGKMA PDBEGENGKOF, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x813D6E0", Offset = "0x813CAE0", VA = "0x18813D6E0")]
	private void AMIHHBNKELG([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x814C890", Offset = "0x814BC90", VA = "0x18814C890")]
	private void LBCNCEBKOKD([In] FEOCPHDGKMA PDBEGENGKOF, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8143440", Offset = "0x8142840", VA = "0x188143440")]
	private void CKBNAILJELG([In] FEOCPHDGKMA PDBEGENGKOF, float DHPGCIKFAEH, float AIHJHOADHLM, Vector3 OLNPFADCMCK, float OKMLALGCNCM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x813C850", Offset = "0x813BC50", VA = "0x18813C850")]
	private void AHDGKCDAKJL(FEOCPHDGKMA PDBEGENGKOF, AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x81527A0", Offset = "0x8151BA0", VA = "0x1881527A0")]
	private void NBAAOGHDBEC(FEOCPHDGKMA JPDKKKJJNLC, AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8145D60", Offset = "0x8145160", VA = "0x188145D60")]
	private void EGFFOBCDGKA(FEOCPHDGKMA PDBEGENGKOF, AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x814FA40", Offset = "0x814EE40", VA = "0x18814FA40")]
	public void MBCHCOLKNAA([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8142370", Offset = "0x8141770", VA = "0x188142370")]
	public void BOKEOHIOHBK([In] FEOCPHDGKMA JPDKKKJJNLC, [In] AvatarFullBodyConfiguration HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x814AAE0", Offset = "0x8149EE0", VA = "0x18814AAE0")]
	[CompilerGenerated]
	internal static void IDNDAGBGOJO(Transform BEOBAPANJHO, IKSolverVR.Arm MFNCDCOCFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x81482E0", Offset = "0x81476E0", VA = "0x1881482E0")]
	[CompilerGenerated]
	internal static void GIFDODAHLJJ(Vector3 AFKAGLJGHKD, Vector3 OHONBNIDOGM, PNELPJIMEDD P_2, HKIAHMMMCNJ P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x81547B0", Offset = "0x8153BB0", VA = "0x1881547B0")]
	[CompilerGenerated]
	internal static void POJPFGEGAKH(CMMLCKOFNHP CBIBFPMKGAP, CMMLCKOFNHP AJKOKCCCEDD, Vector3 PPGKKEKFPCH, float FKPCAPOIAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8145A10", Offset = "0x8144E10", VA = "0x188145A10")]
	[CompilerGenerated]
	internal static bool EDPIABPJJGM(IKSolverVR.Arm MFNCDCOCFEF, LJAFGANLIDA BFEPODFMALD, float NJMFFADCDKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x813D260", Offset = "0x813C660", VA = "0x18813D260")]
	[CompilerGenerated]
	internal static float AKILKGAAMAC(Vector3 MPDBCGHIFAJ, Vector3 FOFKCMGEOLP, Vector3 LNGEBILHEBO, FEOCPHDGKMA PDBEGENGKOF, AvatarFullBodyConfiguration HFDKCBHNBMB, float FDIDNNCIDHK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class JIIGJMHKJIM : CGPNEMHDHJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private Dictionary<string, GEMHKEHPGAH> PALEFOLGNEH;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x815ED00", Offset = "0x815E100", VA = "0x18815ED00")]
	[MKODAOGKIAA.PMDGGDAFIAI]
	internal static void CFHGDPAOCPG(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x815F100", Offset = "0x815E500", VA = "0x18815F100", Slot = "4")]
	public GEMHKEHPGAH OLFCPKKOKFH(string GKMFFOJDBEO, AvatarSystemConfiguration LHNDMFPBDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x815EEB0", Offset = "0x815E2B0", VA = "0x18815EEB0", Slot = "5")]
	public void NBFFKGBJMBN(string GKMFFOJDBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x815ED70", Offset = "0x815E170", VA = "0x18815ED70", Slot = "6")]
	public string IAJCBDNANPM(string DNEEJJMLKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x815F090", Offset = "0x815E490", VA = "0x18815F090")]
	private string OLBAOPKNKKD(string DNEEJJMLKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x815F320", Offset = "0x815E720", VA = "0x18815F320")]
	public JIIGJMHKJIM()
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
		public class CBHOJEHEDJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private Dictionary<string, Transform> OOKLDMEHJCM;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool GAGDCLONJBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x8158F90", Offset = "0x8158390", VA = "0x188158F90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8158E60", Offset = "0x8158260", VA = "0x188158E60")]
			public void EJIFDFELCDH(VRIK JFEFDFHMHAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
			public void CLFALIKDKDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8158E10", Offset = "0x8158210", VA = "0x188158E10")]
			public void CNFJEHEIBKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8158FD0", Offset = "0x81583D0", VA = "0x188158FD0")]
			public CBHOJEHEDJN()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[OCPKILIHCKA(FIPBCJPBODB.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[BNCHLJBJHLJ(FIPBCJPBODB.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly CBHOJEHEDJN NJOMINCAKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private NJIKDDAGPDG CGCAEPDEIGA;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x81566D0", Offset = "0x8155AD0", VA = "0x1881566D0")]
		private void PJOFCLDPLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8156670", Offset = "0x8155A70", VA = "0x188156670")]
		private bool CEKKNDLFICA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x81566C0", Offset = "0x8155AC0", VA = "0x1881566C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8156A10", Offset = "0x8155E10", VA = "0x188156A10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x81569B0", Offset = "0x8155DB0", VA = "0x1881569B0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8156C80", Offset = "0x8156080", VA = "0x188156C80")]
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
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x815C690", Offset = "0x815BA90", VA = "0x18815C690")]
			public (float, float) NHEJJJAHDPM(float KFIBMJDGHCL)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x815BEC0", Offset = "0x815B2C0", VA = "0x18815BEC0")]
			public void IPJPKJAMFMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x815BD80", Offset = "0x815B180", VA = "0x18815BD80")]
			public (float, float) FGGNDALNJHO(Animator FNIJEPIPDEG, AnimatorStateInfo PLHBKGJADEN)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x815C200", Offset = "0x815B600", VA = "0x18815C200")]
		public void IPJPKJAMFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x815C3F0", Offset = "0x815B7F0", VA = "0x18815C3F0")]
		public (float, float) JLLNJHAFKCA(Animator FNIJEPIPDEG, PJNGMFEHKCP CBJJLDMFBOC, float KMMDEILMCGA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x815BFA0", Offset = "0x815B3A0", VA = "0x18815BFA0")]
		private (float, float) EAGJPHAGFAL(Animator FNIJEPIPDEG, AnimatorStateInfo PLHBKGJADEN, PJNGMFEHKCP CBJJLDMFBOC, float KMMDEILMCGA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x815C680", Offset = "0x815BA80", VA = "0x18815C680")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8160120", Offset = "0x815F520", VA = "0x188160120", Slot = "4")]
		public override void OnStateEnter(Animator FNIJEPIPDEG, AnimatorStateInfo PLHBKGJADEN, int BOHJBGEGLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8160290", Offset = "0x815F690", VA = "0x188160290")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class BJDJHFACPKC<TInput, TOutput> : AAFCHKPMHJG<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	protected readonly KEPKCCNNHIG NMHGBBCEPEC;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6558910", Offset = "0x6557D10", VA = "0x186558910")]
	protected BJDJHFACPKC(KEPKCCNNHIG NMHGBBCEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput DGFNGGGAAON(TInput MICKAKKPGLH, [Out] IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6558870", Offset = "0x6557C70", VA = "0x186558870", Slot = "5")]
	public bool DONCEPDPLAE(TInput MICKAKKPGLH, [Out] TOutput? HJBCDFKDKBA, [Out] IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[EAFHNCFGKJO]
public static class OJFIGDFNOJE
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly Regex LELNHLOMPHG;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x81607D0", Offset = "0x815FBD0", VA = "0x1881607D0")]
	public static AMJJELPNDPE AIAMJFOPBKA(PPDJPCBBHNI JCGHBPGKAOE, KHANOMCGPKB PDDKNCKPEDN, Guid? NPMPEIAPAOF, Color? IOCPPEEKJJO, KMPAOABCDOI FBBAOHEBJDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8160B30", Offset = "0x815FF30", VA = "0x188160B30")]
	public static PBBHALCOHCB GDMEJKICJLK(AMJJELPNDPE NGIAGNLBILI)
	{
		return default(PBBHALCOHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8AC0", Offset = "0x3EB7EC0", VA = "0x183EB8AC0")]
	internal static TModern? MILFKEFEFBO<TModern>(string? MICKAKKPGLH, FHLIDKIAKPK<TModern> FHBOBHLAHIA, KEPKCCNNHIG NMHGBBCEPEC, ONIGGHDBHDO JKLDDPGHDCE, TModern GKFKGIIINBI) where TModern : struct, PIKPFPHMMFH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB8350", Offset = "0x3EB7750", VA = "0x183EB8350")]
	internal static PFHMJGCBHKL GPHLBPPCNNO<TModern>(string? MICKAKKPGLH, FHLIDKIAKPK<TModern> FHBOBHLAHIA, KEPKCCNNHIG NMHGBBCEPEC, ONIGGHDBHDO JKLDDPGHDCE, TModern GKFKGIIINBI) where TModern : struct, PIKPFPHMMFH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x81609E0", Offset = "0x815FDE0", VA = "0x1881609E0")]
	internal static List<AMMBECAJBIA> AMJEHCEPHGE(IEnumerable<EEPNMBMKPKK>? AICGEPFLEKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB74D0", Offset = "0x3EB68D0", VA = "0x183EB74D0")]
	internal static string GHPGEAKOAHH<TModern>(TModern MICKAKKPGLH, FHLIDKIAKPK<TModern> FHBOBHLAHIA, KEPKCCNNHIG NMHGBBCEPEC) where TModern : PIKPFPHMMFH
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class CBHIBBKGKGD : HLAAMCKOKEB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AAFCHKPMHJG<BBOLELEACLM, PKLMLDNJFKK> MLIIKCMFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AAFCHKPMHJG<HBAHGJJIJND, CJHBFKMKJAB> FFNHJEEPICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AAFCHKPMHJG<HBAHGJJIJND, CJHBFKMKJAB> NFFJHOAJKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NNAAPNJECBJ BBCCLFKNBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public POCFDEFJHML DONCEJLAMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8158840", Offset = "0x8157C40", VA = "0x188158840")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	[UsedImplicitly]
	internal static void BBPKCCDBHID(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x81588B0", Offset = "0x8157CB0", VA = "0x1881588B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CBHIBBKGKGD([PKIHAALFADL("UnitySerialization")] PPEPIPPAMEL CHGPPCNMBEA, [PKIHAALFADL(null)] PNAAMOOFGFL MHOGLOHJNKN, [PKIHAALFADL(null)] KEPKCCNNHIG NMHGBBCEPEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum NFKMCEDILJP
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OLHNFEJAFPN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8160D90", Offset = "0x8160190", VA = "0x188160D90")]
	public OLHNFEJAFPN(string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8160D30", Offset = "0x8160130", VA = "0x188160D30")]
	public OLHNFEJAFPN(string AFDNIPHJHMO, Exception DNFKLOFLLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8160D60", Offset = "0x8160160", VA = "0x188160D60")]
	public OLHNFEJAFPN(NFKMCEDILJP AINAMMEFIOC, string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8160DC0", Offset = "0x81601C0", VA = "0x188160DC0")]
	public OLHNFEJAFPN(NFKMCEDILJP AINAMMEFIOC, string AFDNIPHJHMO, Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class BCMGABPEADN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly PPEPIPPAMEL CHGPPCNMBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly PNAAMOOFGFL MHOGLOHJNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	protected readonly KEPKCCNNHIG NMHGBBCEPEC;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x81586C0", Offset = "0x8157AC0", VA = "0x1881586C0")]
	protected BCMGABPEADN(PPEPIPPAMEL CHGPPCNMBEA, PNAAMOOFGFL MHOGLOHJNKN, KEPKCCNNHIG NMHGBBCEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8157090", Offset = "0x8156490", VA = "0x188157090")]
	protected string AINKDMIBJFB(PKLMLDNJFKK GPPGDEEJAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x81584E0", Offset = "0x81578E0", VA = "0x1881584E0")]
	protected string JMLGJIALLOM(PKLMLDNJFKK GPPGDEEJAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8156D60", Offset = "0x8156160", VA = "0x188156D60")]
	private AvatarOutfitSelectionData AIAMJFOPBKA(AMJJELPNDPE JCHHPKAFJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x81583A0", Offset = "0x81577A0", VA = "0x1881583A0")]
	private static AvatarCustomizationSettingsData.AnchorParams BHEMBBCFNOC(CHMLELHGCGH? MAGHBHCOCFM)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AAFCHKPMHJG<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput DGFNGGGAAON(TInput MICKAKKPGLH, [Out] IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DONCEPDPLAE(TInput MICKAKKPGLH, [Out] TOutput? HJBCDFKDKBA, [Out] IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HLAAMCKOKEB
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	AAFCHKPMHJG<BBOLELEACLM, PKLMLDNJFKK> MLIIKCMFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AAFCHKPMHJG<HBAHGJJIJND, CJHBFKMKJAB> NFFJHOAJKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NNAAPNJECBJ BBCCLFKNBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum ONIGGHDBHDO
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface POCFDEFJHML
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICAGGCEOOAB COFPFOKABJF(PKLMLDNJFKK NGIAGNLBILI);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NNAAPNJECBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBAHGJJIJND COFPFOKABJF(PKLMLDNJFKK NGIAGNLBILI, int DNCNBFLLNOA, string? HDNPPEBJPAE, string? HNCJKEINFAH, POKGCAJLAGP LGGIEAFHOLJ, List<AMMBECAJBIA>? HPMPLFMFCHD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[EAFHNCFGKJO]
internal class KPFOIPOMLBL : BJDJHFACPKC<BBOLELEACLM, PKLMLDNJFKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly PNAAMOOFGFL MHOGLOHJNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JDEAGIBNGEJ KBKAMCKOJDK;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x815FD50", Offset = "0x815F150", VA = "0x18815FD50")]
	public KPFOIPOMLBL(PPEPIPPAMEL CHGPPCNMBEA, PNAAMOOFGFL MHOGLOHJNKN, KEPKCCNNHIG NMHGBBCEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x815FAA0", Offset = "0x815EEA0", VA = "0x18815FAA0", Slot = "6")]
	public override PKLMLDNJFKK DGFNGGGAAON(BBOLELEACLM MICKAKKPGLH, [Out] IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class EPBIHIBGEBA : PPEPIPPAMEL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class MKFEOOJGDBL : JsonConverter<PFHMJGCBHKL>
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8160040", Offset = "0x815F440", VA = "0x188160040", Slot = "9")]
		public override void WriteJson(JsonWriter HNNLPFDFOLO, PFHMJGCBHKL? CBMEHPPMEEA, JsonSerializer GBOEJHCDIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x815FF20", Offset = "0x815F320", VA = "0x18815FF20", Slot = "10")]
		public override PFHMJGCBHKL ReadJson(JsonReader BPCOJLPPMNI, Type LKHMPELKIJH, PFHMJGCBHKL? PJEFBKKJBCH, bool IFPHNEAKMBE, JsonSerializer GBOEJHCDIGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x81600E0", Offset = "0x815F4E0", VA = "0x1881600E0")]
		public MKFEOOJGDBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class NKCBHMIFDEJ : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool DELHOEPBHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8160690", Offset = "0x815FA90", VA = "0x188160690", Slot = "5")]
		public override object ReadJson(JsonReader BPCOJLPPMNI, Type LKHMPELKIJH, object? PJEFBKKJBCH, JsonSerializer GBOEJHCDIGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x81602B0", Offset = "0x815F6B0", VA = "0x1881602B0", Slot = "6")]
		public override bool CanConvert(Type LKHMPELKIJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x81606F0", Offset = "0x815FAF0", VA = "0x1881606F0", Slot = "4")]
		public override void WriteJson(JsonWriter HNNLPFDFOLO, object? CBMEHPPMEEA, JsonSerializer GBOEJHCDIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8160490", Offset = "0x815F890", VA = "0x188160490")]
		private static bool MNMHENOBKEM(object CBMEHPPMEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public NKCBHMIFDEJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly JsonSerializerSettings FKBCJNJEHBA;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x815A0B0", Offset = "0x81594B0", VA = "0x18815A0B0")]
	internal EPBIHIBGEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3B44F60", Offset = "0x3B44360", VA = "0x183B44F60", Slot = "4")]
	public string HLKPNPNKHBO<T>(T DEJGDIIDCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3B44FC0", Offset = "0x3B443C0", VA = "0x183B44FC0", Slot = "5")]
	public T IJDIGNFGFEO<T>(string CBMEHPPMEEA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class MJNHBOLLNJD : PPEPIPPAMEL
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2FB0", Offset = "0x3DF23B0", VA = "0x183DF2FB0", Slot = "4")]
	public string HLKPNPNKHBO<T>(T DEJGDIIDCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3DF3010", Offset = "0x3DF2410", VA = "0x183DF3010", Slot = "5")]
	public T IJDIGNFGFEO<T>(string CBMEHPPMEEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MJNHBOLLNJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[EAFHNCFGKJO]
internal class JDEAGIBNGEJ : BJDJHFACPKC<HBAHGJJIJND, CJHBFKMKJAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly PPEPIPPAMEL CHGPPCNMBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly PNAAMOOFGFL MHOGLOHJNKN;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x815EBC0", Offset = "0x815DFC0", VA = "0x18815EBC0")]
	public JDEAGIBNGEJ(PPEPIPPAMEL CHGPPCNMBEA, PNAAMOOFGFL MHOGLOHJNKN, KEPKCCNNHIG NMHGBBCEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x815CFF0", Offset = "0x815C3F0", VA = "0x18815CFF0", Slot = "6")]
	public override CJHBFKMKJAB DGFNGGGAAON(HBAHGJJIJND MICKAKKPGLH, [Out] IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x815EA70", Offset = "0x815DE70", VA = "0x18815EA70")]
	internal void PLJKHANFEPF(string KOJFKNGJJIL, PKLMLDNJFKK GPPGDEEJAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x815DEA0", Offset = "0x815D2A0", VA = "0x18815DEA0")]
	public IEnumerable<AMJJELPNDPE> MNBICEMHBBI(string JHBNKEPIGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x815D580", Offset = "0x815C980", VA = "0x18815D580")]
	private IEnumerable<AMJJELPNDPE> DOFIEHAGMEO(string JHBNKEPIGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x815E600", Offset = "0x815DA00", VA = "0x18815E600")]
	internal IEnumerable<AMJJELPNDPE> OHCKIFNHIHH(string JHBNKEPIGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x815E270", Offset = "0x815D670", VA = "0x18815E270")]
	private AMJJELPNDPE OFEOMPBKJOM(AvatarOutfitSelectionData GIAFDIPMNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x815C750", Offset = "0x815BB50", VA = "0x18815C750")]
	private void DDDNNEJDBPJ(AvatarCustomizationSettingsData PNOJBADHNHN, PKLMLDNJFKK GPPGDEEJAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x815DF50", Offset = "0x815D350", VA = "0x18815DF50")]
	private AMJJELPNDPE OFEOMPBKJOM(string DKEHPEFIMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x815D9A0", Offset = "0x815CDA0", VA = "0x18815D9A0")]
	internal static (KMPAOABCDOI, string, string) EKEAMCIBMPH(string DKEHPEFIMIG, KEPKCCNNHIG NMHGBBCEPEC)
	{
		return default((KMPAOABCDOI, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x815DCA0", Offset = "0x815D0A0", VA = "0x18815DCA0")]
	private CJIOEHLNJOG? GHNOOPMALIM(string? OOOANFDGEED, Vector2 PGMGEEDJNJE, float DAGPHMPCCAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x815D420", Offset = "0x815C820", VA = "0x18815D420")]
	private static CHMLELHGCGH DKLKOOOBHBL(AvatarCustomizationSettingsData.AnchorParams ALAMBIGCOHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[EAFHNCFGKJO]
internal class KKPNECHHONO : BCMGABPEADN, POCFDEFJHML
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x81586C0", Offset = "0x8157AC0", VA = "0x1881586C0")]
	public KKPNECHHONO(PPEPIPPAMEL CHGPPCNMBEA, PNAAMOOFGFL MHOGLOHJNKN, KEPKCCNNHIG NMHGBBCEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x815F4B0", Offset = "0x815E8B0", VA = "0x18815F4B0", Slot = "4")]
	public ICAGGCEOOAB COFPFOKABJF(PKLMLDNJFKK NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x815F3B0", Offset = "0x815E7B0", VA = "0x18815F3B0")]
	private string CCJMODBNONA(PKLMLDNJFKK GPPGDEEJAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x815F860", Offset = "0x815EC60", VA = "0x18815F860")]
	private string NKEJKKNGKAB(AMJJELPNDPE JCHHPKAFJDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[EAFHNCFGKJO]
internal class PJBBAJOALGJ : BJDJHFACPKC<HBAHGJJIJND, CJHBFKMKJAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly PPEPIPPAMEL CHGPPCNMBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly AAFCHKPMHJG<HBAHGJJIJND, CJHBFKMKJAB> BFHEKGBOHMB;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8161230", Offset = "0x8160630", VA = "0x188161230")]
	public PJBBAJOALGJ(AAFCHKPMHJG<HBAHGJJIJND, CJHBFKMKJAB> BFHEKGBOHMB, KEPKCCNNHIG NMHGBBCEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8160E00", Offset = "0x8160200", VA = "0x188160E00", Slot = "6")]
	public override CJHBFKMKJAB DGFNGGGAAON(HBAHGJJIJND MICKAKKPGLH, [Out] IReadOnlyList<AMMBECAJBIA>? HPMPLFMFCHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[EAFHNCFGKJO]
internal class GFDPIAPABEP : NNAAPNJECBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly PPEPIPPAMEL CHGPPCNMBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly POCFDEFJHML EPAKIJPFODO;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x815BC90", Offset = "0x815B090", VA = "0x18815BC90")]
	public GFDPIAPABEP(POCFDEFJHML EPAKIJPFODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x815B8F0", Offset = "0x815ACF0", VA = "0x18815B8F0", Slot = "4")]
	public HBAHGJJIJND COFPFOKABJF(PKLMLDNJFKK NGIAGNLBILI, int DNCNBFLLNOA, string? HDNPPEBJPAE, string? HNCJKEINFAH, POKGCAJLAGP LGGIEAFHOLJ, List<AMMBECAJBIA>? HPMPLFMFCHD)
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
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8155D00", Offset = "0x8155100", VA = "0x188155D00")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DNMODKOEPLE
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8159F40", Offset = "0x8159340", VA = "0x188159F40")]
	public static PBBHALCOHCB DGFNGGGAAON(this OALBLGMMLKG NGIAGNLBILI)
	{
		return default(PBBHALCOHCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8159E20", Offset = "0x8159220", VA = "0x188159E20")]
	public static OALBLGMMLKG COFPFOKABJF(this PBBHALCOHCB AGBLJCDPLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x815A050", Offset = "0x8159450", VA = "0x18815A050")]
	public static bool FDGOGHMKPHE(this PBBHALCOHCB AGBLJCDPLPB)
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
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x61576E0", Offset = "0x6156AE0", VA = "0x1861576E0")]
			public AnchorParams(Vector2 BLPEDOCJJCL, Vector3 CPNMEOJCCLA, Vector3 IEIKMFFPGJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8155C50", Offset = "0x8155050", VA = "0x188155C50")]
			internal CHMLELHGCGH COFPFOKABJF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private ADHECDELIKB useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8156530", Offset = "0x8155930", VA = "0x188156530")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1847E90", Offset = "0x1847290", VA = "0x181847E90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1057300", Offset = "0x1056700", VA = "0x181057300")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x1561E90", Offset = "0x1561290", VA = "0x181561E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x81565E0", Offset = "0x81559E0", VA = "0x1881565E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA7B820", Offset = "0xA7AC20", VA = "0x180A7B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD22450", Offset = "0xD21850", VA = "0x180D22450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD22600", Offset = "0xD21A00", VA = "0x180D22600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xEA67D0", Offset = "0xEA5BD0", VA = "0x180EA67D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xF78A90", Offset = "0xF77E90", VA = "0x180F78A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1246840", Offset = "0x1245C40", VA = "0x181246840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x19ED750", Offset = "0x19ECB50", VA = "0x1819ED750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2594F20", Offset = "0x2594320", VA = "0x182594F20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xF911E0", Offset = "0xF905E0", VA = "0x180F911E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xAA53B0", Offset = "0xAA47B0", VA = "0x180AA53B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAA5410", Offset = "0xAA4810", VA = "0x180AA5410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA7C8A0", Offset = "0xA7BCA0", VA = "0x180A7C8A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9A0", Offset = "0xA7BDA0", VA = "0x180A7C9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9B0", Offset = "0xA7BDB0", VA = "0x180A7C9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA7C810", Offset = "0xA7BC10", VA = "0x180A7C810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB1ECE0", Offset = "0xB1E0E0", VA = "0x180B1ECE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA7C860", Offset = "0xA7BC60", VA = "0x180A7C860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA7C970", Offset = "0xA7BD70", VA = "0x180A7C970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB1F0B0", Offset = "0xB1E4B0", VA = "0x180B1F0B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB1F110", Offset = "0xB1E510", VA = "0x180B1F110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA76C50", Offset = "0xA76050", VA = "0x180A76C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA76BE0", Offset = "0xA75FE0", VA = "0x180A76BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB1ED30", Offset = "0xB1E130", VA = "0x180B1ED30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB1F130", Offset = "0xB1E530", VA = "0x180B1F130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xDC1C80", Offset = "0xDC1080", VA = "0x180DC1C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xDBDE60", Offset = "0xDBD260", VA = "0x180DBDE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public ADHECDELIKB UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1074260", Offset = "0x1073660", VA = "0x181074260")]
			get
			{
				return default(ADHECDELIKB);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1073EA0", Offset = "0x10732A0", VA = "0x181073EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1073BA0", Offset = "0x1072FA0", VA = "0x181073BA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xD128C0", Offset = "0xD11CC0", VA = "0x180D128C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x8156600", Offset = "0x8155A00", VA = "0x188156600")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8156620", Offset = "0x8155A20", VA = "0x188156620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8156190", Offset = "0x8155590", VA = "0x188156190")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public KMPAOABCDOI BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private DPHDNJLDDAD? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8156640", Offset = "0x8155A40", VA = "0x188156640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
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
