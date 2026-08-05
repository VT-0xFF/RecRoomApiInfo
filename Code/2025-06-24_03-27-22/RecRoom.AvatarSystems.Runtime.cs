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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C80AC0", Offset = "0x7C7F6C0", VA = "0x187C80AC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C80B40", Offset = "0x7C7F740", VA = "0x187C80B40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BOOMHEJPJEF]
internal class HBIAGHPEAKJ : DDKPICELNPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NCBMNLBPFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public HBIAGHPEAKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CIFHCHIGFCF avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DHFNIDMKPGA NOGNNOPIPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KLIMGIEECJL LFGGLPNFENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EEHKELBBLDP AFGGAEFCDEL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E670", Offset = "0x7C7D270", VA = "0x187C7E670")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	[UsedImplicitly]
	internal static void NLIKBHJHOFF(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E770", Offset = "0x7C7D370", VA = "0x187C7E770")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HBIAGHPEAKJ([GFNPNOLPMKK(null)] DHFNIDMKPGA NOGNNOPIPCM, [GFNPNOLPMKK(null)] KLIMGIEECJL LFGGLPNFENP, [GFNPNOLPMKK(null)] EEHKELBBLDP AFGGAEFCDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CD70", Offset = "0x7C7B970", VA = "0x187C7CD70", Slot = "5")]
	public FKBFMJFEIFH FFKJPFJGIBE(CIFHCHIGFCF GLKFEKCCCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7DB70", Offset = "0x7C7C770", VA = "0x187C7DB70", Slot = "4")]
	public FKBFMJFEIFH JPKBFJBOBEK(CIFHCHIGFCF GLKFEKCCCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D640", Offset = "0x7C7C240", VA = "0x187C7D640", Slot = "6")]
	public IPDMPCLJLFG FJFEKMKLHFM(FKBFMJFEIFH PEDMEJIDLNB, int HCPPMGFJDNL, string? LAOCJKNALFF, string? CPIOEEDDFDB, ECKLOIPKONK DNKFMFAHMGK, List<BDDPIPFODIL>? NIEADMJLLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7DAE0", Offset = "0x7C7C6E0", VA = "0x187C7DAE0", Slot = "7")]
	public bool GNDIHGGGJBA(KNGBOKKHLPJ HJJGGDONDMM, [Out] FKBFMJFEIFH? HCIFJIKKCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CC90", Offset = "0x7C7B890", VA = "0x187C7CC90", Slot = "8")]
	public bool DCHNCLOAKGN(IPDMPCLJLFG KIBIEPEAFMA, [Out] FKBFMJFEIFH? HCIFJIKKCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E6E0", Offset = "0x7C7D2E0", VA = "0x187C7E6E0", Slot = "9")]
	public bool PNLJIGPMCDH(IPDMPCLJLFG KIBIEPEAFMA, [Out] CNEBKLMIIBL? HJJGGDONDMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD4D0", Offset = "0x3AAC0D0", VA = "0x183AAD4D0")]
	private bool PDGLDKEIFED<TInput, TOutput>(TInput OLMHJMNEENP, KIFIMAFPPCI<TInput, TOutput> GHEGGCKJCJN, [Out] TOutput? DBJBIPJCIKA) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D750", Offset = "0x7C7C350", VA = "0x187C7D750")]
	[CompilerGenerated]
	private BEALCFCAMAO GEDAPFJLHLA(FaceFeatureType PKPCHIEAIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D900", Offset = "0x7C7C500", VA = "0x187C7D900")]
	[CompilerGenerated]
	private BEALCFCAMAO GMPMHHPIEHA(FaceFeatureType PKPCHIEAIOJ, NCBMNLBPFCK P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[BOOMHEJPJEF]
internal class HDOMBHLMEIH : DHFNIDMKPGA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void CJFFHHMMCIJ<in TData>(TData HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BHHPNAGKIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public OKPBOLNLMDJ rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public KFOBCPDEMJM currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KFOBCPDEMJM latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public BHHPNAGKIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C62460", Offset = "0x7C61060", VA = "0x187C62460")]
		internal bool LKOBKFAJNMI(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C623E0", Offset = "0x7C60FE0", VA = "0x187C623E0")]
		internal bool IOFHMAADKBI(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly EEHKELBBLDP AFGGAEFCDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly DGKBILEDBJJ KHABKJJDOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CJFFHHMMCIJ<FKBFMJFEIFH>?[] NOGNNOPIPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CJFFHHMMCIJ<CNEBKLMIIBL>?[] BACGNODNJDG;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C80340", Offset = "0x7C7EF40", VA = "0x187C80340")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	[UsedImplicitly]
	internal static void NLIKBHJHOFF(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C80460", Offset = "0x7C7F060", VA = "0x187C80460")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HDOMBHLMEIH([GFNPNOLPMKK(null)] EEHKELBBLDP AFGGAEFCDEL, [GFNPNOLPMKK(null)] DGKBILEDBJJ KHABKJJDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F670", Offset = "0x7C7E270", VA = "0x187C7F670", Slot = "4")]
	public bool MJFHLDKEHCC(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F510", Offset = "0x7C7E110", VA = "0x187C7F510", Slot = "5")]
	public bool MJFHLDKEHCC(CNEBKLMIIBL HJJGGDONDMM, IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F770", Offset = "0x7C7E370", VA = "0x187C7F770")]
	private void NEDJBBBIPDL(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F010", Offset = "0x7C7DC10", VA = "0x187C7F010")]
	private void JDNHGBIDDOL(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ED00", Offset = "0x7C7D900", VA = "0x187C7ED00")]
	private void GOCDNDDPGCJ(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ECD0", Offset = "0x7C7D8D0", VA = "0x187C7ECD0")]
	private void GELKIEDGOLI(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F410", Offset = "0x7C7E010", VA = "0x187C7F410")]
	private void MAMCJAPIKPP(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C803B0", Offset = "0x7C7EFB0", VA = "0x187C803B0")]
	private void PNLMLDOBNAL(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7EC20", Offset = "0x7C7D820", VA = "0x187C7EC20")]
	private void FCHCFCLDPEB(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E8F0", Offset = "0x7C7D4F0", VA = "0x187C7E8F0")]
	private void AMEAFMLGLIL(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F4E0", Offset = "0x7C7E0E0", VA = "0x187C7F4E0")]
	private void MBIHOMBNMPM(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NGGJJFKLDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E940", Offset = "0x7C7D540", VA = "0x187C7E940")]
	private void EKOIMEICELI(FKBFMJFEIFH HCIFJIKKCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ED30", Offset = "0x7C7D930", VA = "0x187C7ED30")]
	private FKBFMJFEIFH HHCDLIEGJMG(FKBFMJFEIFH HCIFJIKKCEI, List<RangeMigration> ELNEDIELKFE, KFOBCPDEMJM EPCNHPGMEBK, KFOBCPDEMJM CEHIFPJKHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E900", Offset = "0x7C7D500", VA = "0x187C7E900")]
	private float CAHMDCIGMNN(float MGIHJBKDDHI, Vector2 HANNDLDJFID, Vector2 CDBFGNCLAOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F240", Offset = "0x7C7DE40", VA = "0x187C7F240")]
	private (RangeMigration?, RangeMigration?) LJLBIKPHDHA(List<RangeMigration> EKMILJGDNAB, OKPBOLNLMDJ IFFBDPDPMFI, KFOBCPDEMJM EPCNHPGMEBK, KFOBCPDEMJM CEHIFPJKHAM)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DHFNIDMKPGA
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJFHLDKEHCC(FKBFMJFEIFH HCIFJIKKCEI, IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MJFHLDKEHCC(CNEBKLMIIBL HJJGGDONDMM, IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI);
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
		public NCHDLFMKIIB AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7C5FEC0", Offset = "0x7C5EAC0", VA = "0x187C5FEC0")]
		public void BJOPMKPDPCK(AnimationPoseSetting GMNGNCHKEBK, float AGEIDIDHHDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FFF0", Offset = "0x7C5EBF0", VA = "0x187C5FFF0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
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
		[Cpp2IlInjected.Address(RVA = "0x7C608E0", Offset = "0x7C5F4E0", VA = "0x187C608E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C608A0", Offset = "0x7C5F4A0", VA = "0x187C608A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C60010", Offset = "0x7C5EC10", VA = "0x187C60010")]
		private void BDBLFNLHMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEF90", Offset = "0x7BEDB90", VA = "0x187BEEF90", Slot = "4")]
		public void SetEnabled(bool DAMJJNFLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C60910", Offset = "0x7C5F510", VA = "0x187C60910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C60950", Offset = "0x7C5F550", VA = "0x187C60950")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
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
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
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
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Header("Watch")]
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
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
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
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
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
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
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

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C60990", Offset = "0x7C5F590", VA = "0x187C60990")]
		public AnimationPoseSetting CCIBPGDKBPJ(NCHDLFMKIIB DGICBCLJBJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C609C0", Offset = "0x7C5F5C0", VA = "0x187C609C0")]
		public void GFFHNKPMBNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C60A00", Offset = "0x7C5F600", VA = "0x187C60A00")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum GBBCDHKKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private GBBCDHKKJGP handleType;

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

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C614F0", Offset = "0x7C600F0", VA = "0x187C614F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C614B0", Offset = "0x7C600B0", VA = "0x187C614B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C60EB0", Offset = "0x7C5FAB0", VA = "0x187C60EB0")]
		private void BDBLFNLHMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEF90", Offset = "0x7BEDB90", VA = "0x187BEEF90", Slot = "4")]
		public void SetEnabled(bool DAMJJNFLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C61520", Offset = "0x7C60120", VA = "0x187C61520")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, GCBMLMHDBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private CIFHCHIGFCF avatarBodyType;

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
		[GHKDIKFNBMM(EBAHNMNBCJP.SelfAndChildren, false, false, false)]
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
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[FormerlySerializedAs("HeadTweakBone")]
		[SerializeField]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private HPGNGAKAOMH IALINHCOOEG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HPGNGAKAOMH EGOBPGILIEB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB37AA0", Offset = "0xB366A0", VA = "0x180B37AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform GNLOAOBIKGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C623C0", Offset = "0x7C60FC0", VA = "0x187C623C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C61550", Offset = "0x7C60150", VA = "0x187C61550")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C62280", Offset = "0x7C60E80", VA = "0x187C62280")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C62230", Offset = "0x7C60E30", VA = "0x187C62230")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C621C0", Offset = "0x7C60DC0", VA = "0x187C621C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C61550", Offset = "0x7C60150", VA = "0x187C61550", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C61990", Offset = "0x7C60590", VA = "0x187C61990", Slot = "6")]
		public HPGNGAKAOMH CreateAvatarSystem(string GLJPECOKOED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C621C0", Offset = "0x7C60DC0", VA = "0x187C621C0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C61610", Offset = "0x7C60210", VA = "0x187C61610", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C622D0", Offset = "0x7C60ED0", VA = "0x187C622D0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float DJGAODFCDIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DAGGIGANEDD : HPGNGAKAOMH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class KIAODLBBAOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 NDLHLHHNFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion KAEIEOLBBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 OACJNGINKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Transform NFJBBDOIHPO;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 CJFGCMNMNDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2094440", Offset = "0x2093040", VA = "0x182094440")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2094460", Offset = "0x2093060", VA = "0x182094460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion APMBLHJLHBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x113BD50", Offset = "0x113A950", VA = "0x18113BD50")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x113A960", Offset = "0x1139560", VA = "0x18113A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float JJBDGILFFNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1152C50", Offset = "0x1151850", VA = "0x181152C50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x18D64B0", Offset = "0x18D50B0", VA = "0x1818D64B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool ALJAKLLDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA24790", Offset = "0xA23390", VA = "0x180A24790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA24680", Offset = "0xA23280", VA = "0x180A24680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool NMKCOECNOAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA247D0", Offset = "0xA233D0", VA = "0x180A247D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA246D0", Offset = "0xA232D0", VA = "0x180A246D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool IIFCKLDFGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA247A0", Offset = "0xA233A0", VA = "0x180A247A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA248A0", Offset = "0xA234A0", VA = "0x180A248A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float CCHEBDGIENP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xD26CA0", Offset = "0xD258A0", VA = "0x180D26CA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xD279B0", Offset = "0xD265B0", VA = "0x180D279B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C87F20", Offset = "0x7C86B20", VA = "0x187C87F20")]
		public void GAANGKPBNJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C88750", Offset = "0x7C87350", VA = "0x187C88750")]
		public void MBAFDDEKENF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C87D10", Offset = "0x7C86910", VA = "0x187C87D10")]
		public float EAFKFBNHNLP(Vector3 LKFIIDILELF, Quaternion PEACKNILPBH, [In] AvatarFootSettings BJBNDHFNACJ, float ABDFBMHKFDG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C88080", Offset = "0x7C86C80", VA = "0x187C88080")]
		public void KCKNDAFMBJP(Vector3 PHGOINJDNJJ, Quaternion CFJEPAIEMCD, Transform KBKEHBPHPCJ, float CALGLILPAOB, bool ABMBAKMPHBI, bool AFBNONIHLLK, float NGCGICHDBGG, float OBIAMCADEBF, Transform HMGDINOCJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C88760", Offset = "0x7C87360", VA = "0x187C88760")]
		public void MBLEIPFFKHM(Transform DBLJOOHOCED, Transform HMGDINOCJAI, bool FLGGJKGIBHM, bool PKDDCECFFPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C88990", Offset = "0x7C87590", VA = "0x187C88990")]
		private void MCJPPIJNKIO(Transform HMGDINOCJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C87F30", Offset = "0x7C86B30", VA = "0x187C87F30")]
		public bool JPDOIEHPECO(Transform HMGDINOCJAI, AvatarFullBodyConfiguration JLMFPIBLIFF, Vector3 LCLELHLCLFJ, float JFODGLNLCGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C87CF0", Offset = "0x7C868F0", VA = "0x187C87CF0")]
		public void BHMIHDIDGJB(float OBIAMCADEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C88A90", Offset = "0x7C87690", VA = "0x187C88A90")]
		public KIAODLBBAOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class FDIEKJHMKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float HEJDJICLHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool BPDOMAEDBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AnimationPoseSetting OILEEGLGGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private float DBDIEEKHHMC;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C84EB0", Offset = "0x7C83AB0", VA = "0x187C84EB0")]
		public void NIPCJBMKCIE(IKSolverVR.Arm LFEDEPNPMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C838C0", Offset = "0x7C824C0", VA = "0x187C838C0")]
		public void DBKEGCGFKBB(IKSolverVR.Arm LFEDEPNPMAB, float IBBOABINELH, bool BPDOMAEDBPC, AvatarFullBodyConfiguration JLMFPIBLIFF, float IOBMCBBJIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C84EE0", Offset = "0x7C83AE0", VA = "0x187C84EE0")]
		private void OHICDAOCJAI(IKSolverVR.Arm LFEDEPNPMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C83900", Offset = "0x7C82500", VA = "0x187C83900")]
		public void DDLHHEJEEBF(IKSolverVR.Arm LFEDEPNPMAB, Transform NMLCLOBKMCB, Transform KBKEHBPHPCJ, Quaternion IMKKKLJLLHE, Vector3 PKMGECOJJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C842E0", Offset = "0x7C82EE0", VA = "0x187C842E0")]
		private (Vector3, Quaternion) IDLLNMDMNAN(GBGKJEHAAAI GDPGDJPDFOC, Quaternion BCAGLIMHPBP, Vector3 IIJIMBBKOOF)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C84D50", Offset = "0x7C83950", VA = "0x187C84D50")]
		public void KJNJGBMMBFB(GBGKJEHAAAI GDPGDJPDFOC, IKSolverVR.Arm LFEDEPNPMAB, Quaternion BCAGLIMHPBP, Vector3 IIJIMBBKOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C83CE0", Offset = "0x7C828E0", VA = "0x187C83CE0")]
		public void EFNBMCLMDPA(GBGKJEHAAAI GDPGDJPDFOC, IKSolverVR.Arm LFEDEPNPMAB, Quaternion BCAGLIMHPBP, Vector3 IIJIMBBKOOF, [In] AvatarFullBodyConfiguration JLMFPIBLIFF, [In] MBLBODMJALG DKILGKEHOLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C84C10", Offset = "0x7C83810", VA = "0x187C84C10")]
		public void IEPILDFHLAK(NCHDLFMKIIB BLONFKJIJPB, AvatarFullBodyConfiguration JLMFPIBLIFF, MBLBODMJALG DKILGKEHOLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C84770", Offset = "0x7C83370", VA = "0x187C84770")]
		public void IEMOKIMEPFF(IKSolverVR.Arm LFEDEPNPMAB, Transform NMLCLOBKMCB, Vector3 JPPFINALPFL, float DLEJELFFKDE, Quaternion PHEPIFIFFBL, Vector3 EHCKEHNCHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C84F20", Offset = "0x7C83B20", VA = "0x187C84F20")]
		public FDIEKJHMKMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum HNFNGLGIBPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LGFDDDIKNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct DIEFMBPKHKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int NPFIACBHKDN;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int LBANMLAGHIA;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int MAGEPIFPLCM;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int IKHIMPCHKBE;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int ANGNFNPNLCJ;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int PINBGIBIGGP;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int DBLMNDMOIJP;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int DLLJFCACBPJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int KGIGBPCKJNN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JPLJECFNPHN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int JMAKKBONJKK;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int DPKOGDPIMLN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int GKNFAOKOHAI;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int FIJBEHANHIK;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int ANPKAJCILID;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int GOMANDOJFCL;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int CCIIADHPGBN;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int BHECOOEBCBI;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int ODNLFLCIEAG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int PPBOJDJKMIJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int JAAEBMLLKFA;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int POOMMKAOJKN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int FDPPCBKDMML;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int EIDADJAGDBI;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int PFOHFPMDLBF;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int EABFFCJIBLJ;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int EBNJLAAIBGO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int KOJNNNDFECM;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int ABKLGKEAIHG;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int IALJGJGCBIK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int LONONKLOHCF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int JJJAFAKJCCD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 BMMNBCGFAMO;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int LNEEOBGKEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool FOCLIPFNJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool MJICCPJEFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool HAMHJLNLHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool ACBNIKPENPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool LFKENKNDFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool NAOKPJMHAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 CMCNEHHIPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string OOFJFAMOBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private MNKCPAPAJBJ? KBIKABEPDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private ANAKAIIKOLB? KLFEGKJJGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private ONACKJBPCGK MCIPGJMENEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private BGIHBEMGGAL EIAAOCJBJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GBGKJEHAAAI ANBPHJLOBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private GBGKJEHAAAI OCPBHEBDGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool IHCFBHLFHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool CHAMDGNDPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly ENNBOMNEDIG OCHOGMHACBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly GAMNICMFGDG NNLCNCHAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int CEDPFCNEPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float BEJFGEEGKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject DOMBJGCIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform KKBPKGOGJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform ENMMNJLFECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform GEHOOLGNDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform GHFIAHAABON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float AECKMAOCAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float IKHPCKMCACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 JHDDOCLBNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion IDPEKLEANHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform MJGHICLKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform FGNLOPBFNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform PJHBBBJLBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NEEICAFGDGM EJIDMNDINIA;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker OBALFGNLKEH;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker LMHDFAKLELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker BIHNNHJIIGL;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker ONBBLOGAEBK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker GBHKNHIKMPJ;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker IPFIAKKMMGG;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<DAGGIGANEDD> IAOEIHGPAGI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int LMLICHJDJCO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> ONMMJJJHDEF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int KGIDAIFFBBO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int JAMJDAFEPAG;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int FFILICOHLNJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int DENAHENHEFH;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float KIKPCHBPHMA;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int BDBNLJOMOCA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float BHHDBJLPOIF;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float MGMPPLJMKNO;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float PKPKEKCJBIG;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float MHKCEIPPGEO;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static GALDIPGLKAK LDPAGDIPMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float LKBKCLKKCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool OCANPLLLAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float LKICDHMLEPI;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int NCDEELHNEON;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int ALFPIHFLKAF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int ECFDLDHJIDB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int LPFMPBCDEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private KIAODLBBAOF EJPMIGCBAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private KIAODLBBAOF JEPBPAGACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float AJLIJAGMDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 KJAMCMEHPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 PDMJEJBMLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool EBGGMMEKCLC;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion NENMDLGAHIG;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion DLIFDOMBEEK;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 IEDPBBDAMEK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 OOEHJMANFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float NKHEKAANNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float NLLGIIJBOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private FDIEKJHMKMD NJBPNGLNIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private FDIEKJHMKMD PDNLKAFIFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private PFLHIJPFFDF EMAMJIINMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private IHHDEBLIIAL FKKPCGBIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly EEDDNGPINGH EMPMLJOLLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float ECPFPJEIFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float PEGPPPKAHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly IHHDEBLIIAL JEJHBLKPKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 EBMLGLDFFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 NNLALDHHICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float LBGLFEDDEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float NDCEEJLJHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly IHHDEBLIIAL IEFICADLCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly PFLHIJPFFDF LKLIKOIEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly IHHDEBLIIAL DCHNEBBNPPC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HBAAEHCBNNO CCAAPCFDHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HBAAEHCBNNO CAFHJCFFOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration DHGFBPPBBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C76810", Offset = "0x7C75410", VA = "0x187C76810", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CIFHCHIGFCF HMOHOLHLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C68200", Offset = "0x7C66E00", VA = "0x187C68200", Slot = "24")]
		get
		{
			return default(CIFHCHIGFCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration OGEOEBFLNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C6C0", Offset = "0x7C6B2C0", VA = "0x187C6C6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform CKJKGGNDPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C76650", Offset = "0x7C75250", VA = "0x187C76650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform CDPGAPEEEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C75520", Offset = "0x7C74120", VA = "0x187C75520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer OLFMCCBDHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EDB0", Offset = "0x7C6D9B0", VA = "0x187C6EDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] DNIDEMPGPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C669C0", Offset = "0x7C655C0", VA = "0x187C669C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] OLECDLDKHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7C67420", Offset = "0x7C66020", VA = "0x187C67420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator ABLCOAJOCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7C70FE0", Offset = "0x7C6FBE0", VA = "0x187C70FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK CKFBFLGCHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7C71790", Offset = "0x7C70390", VA = "0x187C71790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private KIJBPNOFNNH OBNGNADPOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D450", Offset = "0x7C6C050", VA = "0x187C6D450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private KIJBPNOFNNH JINHMAADLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A820", Offset = "0x7C69420", VA = "0x187C6A820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private KIJBPNOFNNH LOKIOHOIJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7ABE0", Offset = "0x7C797E0", VA = "0x187C7ABE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private KIJBPNOFNNH GJOOEJNJGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C75420", Offset = "0x7C74020", VA = "0x187C75420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private KIJBPNOFNNH KKGKHBIMIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E8C0", Offset = "0x7C6D4C0", VA = "0x187C6E8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private KIJBPNOFNNH IJHHANAPINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6BE20", Offset = "0x7C6AA20", VA = "0x187C6BE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private KIJBPNOFNNH GAMELPKLLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C77960", Offset = "0x7C76560", VA = "0x187C77960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private KIJBPNOFNNH PCBBEEKFHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D870", Offset = "0x7C6C470", VA = "0x187C6D870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ANAKAIIKOLB HCKFABCFFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C67140", Offset = "0x7C65D40", VA = "0x187C67140", Slot = "16")]
		get
		{
			return default(ANAKAIIKOLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JOAGHKKNMDI IGDIPBCAEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAE5660", Offset = "0xAE4260", VA = "0x180AE5660", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DKHBNCECMKL AJNOHKDKICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAE5650", Offset = "0xAE4250", VA = "0x180AE5650", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KGCOEBBKGCN KCPFOGJKIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A540", VA = "0x180B5B940", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KGCOEBBKGCN ALBLEJFMLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAE58F0", Offset = "0xAE44F0", VA = "0x180AE58F0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string AMLAEGNGNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform KFINHDEANJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C746A0", Offset = "0x7C732A0", VA = "0x187C746A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform IFCBKHKOCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C69420", Offset = "0x7C68020", VA = "0x187C69420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform IFBNJENKBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C70FB0", Offset = "0x7C6FBB0", VA = "0x187C70FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform IPIJIFKCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6ED70", Offset = "0x7C6D970", VA = "0x187C6ED70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform HIHKNEPFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C767D0", Offset = "0x7C753D0", VA = "0x187C767D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool JMMJHNEEBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C68E80", Offset = "0x7C67A80", VA = "0x187C68E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool MNHIHIKGBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7C68E80", Offset = "0x7C67A80", VA = "0x187C68E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KOBKEHNEMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6BAC0", Offset = "0x7C6A6C0", VA = "0x187C6BAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform FPLJNBDCHHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D770", Offset = "0x7C6C370", VA = "0x187C6D770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject AOALCMHDOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C71650", Offset = "0x7C70250", VA = "0x187C71650", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets CACMBHBNKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C76750", Offset = "0x7C75350", VA = "0x187C76750", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform JCBFFCBAFDP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB5C2D0", Offset = "0xB5AED0", VA = "0x180B5C2D0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform EDFGEGFPOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB5B840", Offset = "0xB5A440", VA = "0x180B5B840", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform EKLJMILHADH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB479E0", Offset = "0xB465E0", VA = "0x180B479E0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform OBPKBEAOLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xB5C270", Offset = "0xB5AE70", VA = "0x180B5C270", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 MAADKEJPJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C78660", Offset = "0x7C77260", VA = "0x187C78660", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float AFFEPBKNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7C75620", Offset = "0x7C74220", VA = "0x187C75620", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform KLECCCGJIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7C69270", Offset = "0x7C67E70", VA = "0x187C69270", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform LBHAPFAPJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x14B8650", Offset = "0x14B7250", VA = "0x1814B8650", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform FKIDJIOGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x14B8410", Offset = "0x14B7010", VA = "0x1814B8410", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform MFPBIAOFBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAE5870", Offset = "0xAE4470", VA = "0x180AE5870", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool JKFFGAOAEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7C73BF0", Offset = "0x7C727F0", VA = "0x187C73BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PJAJEBBNNBK<HPGNGAKAOMH.BOHHDOCMPIB> EPNKCDGJHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C7ACE0", Offset = "0x7C798E0", VA = "0x187C7ACE0", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool JLMPAAGOBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C7F0", Offset = "0x7C6B3F0", VA = "0x187C6C7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool FAPDMLLNDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C71F80", Offset = "0x7C70B80", VA = "0x187C71F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C6ACF0", Offset = "0x7C698F0", VA = "0x187C6ACF0")]
	private float FIFLECPILDK(OJLMGLFEKAM GKKIEOBINHD, float AEIDEJGOODL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F4D0", Offset = "0x7C6E0D0", VA = "0x187C6F4D0")]
	private void KDNHGAFIJIN([In] MBLBODMJALG GOGIKOKIEKF, [In] AvatarFullBodyConfiguration JLMFPIBLIFF, bool HPPBIAKLOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C240", Offset = "0x7C6AE40", VA = "0x187C6C240")]
	private float GNNEMMJLJDE([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B900", Offset = "0x7C7A500", VA = "0x187C7B900")]
	private float PJMAFGJGJOL([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A370", Offset = "0x7C68F70", VA = "0x187C6A370")]
	private void EKGMFJDODOE(MBLBODMJALG GOGIKOKIEKF, AvatarFullBodyConfiguration JLMFPIBLIFF, bool HPPBIAKLOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A660", Offset = "0x7C79260", VA = "0x187C7A660")]
	private void OIKONFBPFHA([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C71890", Offset = "0x7C70490", VA = "0x187C71890")]
	private void KMOHLLMDCPP([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C790", Offset = "0x7C7B390", VA = "0x187C7C790")]
	public DAGGIGANEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EF80", Offset = "0x7C6DB80", VA = "0x187C6EF80", Slot = "13")]
	public void JONJNOFONEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E9C0", Offset = "0x7C6D5C0", VA = "0x187C6E9C0", Slot = "14")]
	public void JDKHCLLKLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EEB0", Offset = "0x7C6DAB0", VA = "0x187C6EEB0", Slot = "15")]
	public void JOJNMKNLFEI(bool BKALBKDFAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C66FF0", Offset = "0x7C65BF0", VA = "0x187C66FF0", Slot = "26")]
	public Transform CFANJIFBNDE(string NHALHFDGPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C62480", Offset = "0x7C61080", VA = "0x187C62480", Slot = "27")]
	public Vector3? AAGKPMJPDPM(string NHALHFDGPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C66D50", Offset = "0x7C65950", VA = "0x187C66D50", Slot = "7")]
	public void BPFGNBJFCDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C67870", Offset = "0x7C66470", VA = "0x187C67870")]
	private void DDEIAFDBLHO(AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C67520", Offset = "0x7C66120", VA = "0x187C67520", Slot = "8")]
	public void DAJHGIIKELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F90", Offset = "0x7C68B90", VA = "0x187C69F90")]
	private void EHONJNLBICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E5F0", Offset = "0x7C6D1F0", VA = "0x187C6E5F0")]
	private Vector3 IPLLKEOPOIG([In] MBLBODMJALG DKILGKEHOLM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C63D80", Offset = "0x7C62980", VA = "0x187C63D80", Slot = "6")]
	public void BEJFCODFKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C685A0", Offset = "0x7C671A0", VA = "0x187C685A0")]
	private void DKAJPFMHPIE(bool HPPBIAKLOBG, HNFNGLGIBPL CJCPBFHLEBG, AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C66CE0", Offset = "0x7C658E0", VA = "0x187C66CE0", Slot = "9")]
	public void BMJBFIJHMHC(float JGGBJLNAKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C74650", Offset = "0x7C73250", VA = "0x187C74650")]
	private void LOFPPMJMDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C64790", Offset = "0x7C63390", VA = "0x187C64790", Slot = "4")]
	public void BLMKJDCNBCH(string GLJPECOKOED, MNKCPAPAJBJ NENBMFIMFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C69780", Offset = "0x7C68380", VA = "0x187C69780", Slot = "5")]
	public void EFDDEDMFNHA(ANAKAIIKOLB DFNMCAPPCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A6C0", Offset = "0x7C692C0", VA = "0x187C6A6C0", Slot = "12")]
	public void EOCGMENPPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C69C00", Offset = "0x7C68800", VA = "0x187C69C00", Slot = "25")]
	public void EHFJOEOMMID([Out] Vector3 NCEGLLCEOFC, [Out] Quaternion PHEPIFIFFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C66CB0", Offset = "0x7C658B0", VA = "0x187C66CB0")]
	private void BMDCMEIODIF([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BD60", Offset = "0x7C6A960", VA = "0x187C6BD60", Slot = "28")]
	public void GLDEDGFIDFM(float OMJBFEOIKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C76C00", Offset = "0x7C75800", VA = "0x187C76C00", Slot = "29")]
	public void NNBHJBGKMCD(float NDFJDMPJJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A090", Offset = "0x7C68C90", VA = "0x187C6A090", Slot = "46")]
	public void EKDBPINOKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C69220", Offset = "0x7C67E20", VA = "0x187C69220", Slot = "30")]
	public void DMBOAAMCPGG(bool PHALDAPECKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C2D0", Offset = "0x7C6AED0", VA = "0x187C6C2D0", Slot = "31")]
	public HandLogicOffsets GOECMNEKCLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C320", Offset = "0x7C6AF20", VA = "0x187C6C320", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets HAOBCPODBLF()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C746F0", Offset = "0x7C732F0", VA = "0x187C746F0")]
	private void MBOBOONGKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BF20", Offset = "0x7C6AB20", VA = "0x187C6BF20")]
	private void GMNANMGJHIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C77A60", Offset = "0x7C76660", VA = "0x187C77A60")]
	private void NPGJDPAKGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C3E0", Offset = "0x7C6AFE0", VA = "0x187C6C3E0")]
	private void HFDPDHPDEEE(IODHBDFJLPB HBJMEGLCNEI, bool KIEEDBDBNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B980", Offset = "0x7C7A580", VA = "0x187C7B980")]
	private void PMPMPAHHGAB(IODHBDFJLPB HBJMEGLCNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C68550", Offset = "0x7C67150", VA = "0x187C68550")]
	public Vector3 DGMDGFDALBO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C636D0", Offset = "0x7C622D0", VA = "0x187C636D0")]
	private void APHNPOMEIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C74630", Offset = "0x7C73230", VA = "0x187C74630")]
	private void LLOCHOINOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C75670", Offset = "0x7C74270", VA = "0x187C75670")]
	private void NAHOIEFPKDB(MBLBODMJALG GOGIKOKIEKF, AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BBB0", Offset = "0x7C6A7B0", VA = "0x187C6BBB0")]
	private float GKEEHHGAIJC([In] MBLBODMJALG DKILGKEHOLM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A580", Offset = "0x7C79180", VA = "0x187C7A580")]
	private int OHJIJKIECEH([In] LLGDPIKACAP BNIHAIKCDHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B230", Offset = "0x7C79E30", VA = "0x187C7B230")]
	private void PHCBBAMKHKJ(MBLBODMJALG GOGIKOKIEKF, bool PNNIOCMNGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BB00", Offset = "0x7C7A700", VA = "0x187C7BB00")]
	private static void PPIJMGADLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C74720", Offset = "0x7C73320", VA = "0x187C74720")]
	private static void MBPHEPMGJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C67250", Offset = "0x7C65E50", VA = "0x187C67250")]
	private float CMLDFHFLNPH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C786F0", Offset = "0x7C772F0", VA = "0x187C786F0")]
	private static int OFPKEKFPHEN(DAGGIGANEDD NAHMIIJKKEL, DAGGIGANEDD IJNKBHOINCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C710E0", Offset = "0x7C6FCE0", VA = "0x187C710E0", Slot = "41")]
	public MBLBODMJALG KGNLKOEOLBB()
	{
		return default(MBLBODMJALG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C716F0", Offset = "0x7C702F0", VA = "0x187C716F0")]
	private bool KKHMOFPCFPN(int ALPNKEJICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C692D0", Offset = "0x7C67ED0", VA = "0x187C692D0")]
	public void DNDGFPMMBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C63500", Offset = "0x7C62100", VA = "0x187C63500")]
	private (bool, bool) AMHMGEKKCKL()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AD10", Offset = "0x7C69910", VA = "0x187C6AD10")]
	private (float, float) GEBHNHKEMNA([In] MBLBODMJALG DKILGKEHOLM)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C78930", Offset = "0x7C77530", VA = "0x187C78930")]
	private void OHCCIFALBPH([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C69460", Offset = "0x7C68060", VA = "0x187C69460")]
	private void EDGBLKPKNPD([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C71230", Offset = "0x7C6FE30", VA = "0x187C71230")]
	private void KJCMOLAONPK([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF, AvatarFootSettings BJBNDHFNACJ, bool NCOKLJBJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B1B0", Offset = "0x7C79DB0", VA = "0x187C7B1B0")]
	private float PGNNGFCPEAM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C72BB0", Offset = "0x7C717B0", VA = "0x187C72BB0")]
	private void LFGBGDGNGMA(MBLBODMJALG DKILGKEHOLM, AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D720", Offset = "0x7C6C320", VA = "0x187C6D720")]
	private float IEOOONMFNNN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C726F0", Offset = "0x7C712F0", VA = "0x187C726F0")]
	private void LCALAFKOHBD([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C67F20", Offset = "0x7C66B20", VA = "0x187C67F20")]
	private void DDLHHEJEEBF([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D060", Offset = "0x7C6BC60", VA = "0x187C6D060")]
	private void HLMFEJHMPAO([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C71CF0", Offset = "0x7C708F0", VA = "0x187C71CF0")]
	private void KPFGPNAMDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AEF0", Offset = "0x7C69AF0", VA = "0x187C6AEF0")]
	private void GEDNDEMNGMB(float KOCFNLFMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AA50", Offset = "0x7C79650", VA = "0x187C7AA50")]
	private void OJIBKDEIDCO([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A0E0", Offset = "0x7C68CE0", VA = "0x187C6A0E0")]
	private void EKDOFGDBLKG(GBGKJEHAAAI OBAOKJKNFDN, IKSolverVR.Arm LFEDEPNPMAB, Transform ANKAJKPELHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ACF0", Offset = "0x7C798F0", VA = "0x187C7ACF0")]
	private void PFKNMPINOFD(MBLBODMJALG DKILGKEHOLM, AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D550", Offset = "0x7C6C150", VA = "0x187C6D550")]
	private void ICAJLJGGDCO(GOIKDCLLPDK OAPGHELOBOB, KGCOEBBKGCN OBAOKJKNFDN, IKSolverVR.Arm LFEDEPNPMAB, float IBBOABINELH, float JOEICKIOBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C78720", Offset = "0x7C77320", VA = "0x187C78720")]
	private void OGGGENDEMLH([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C62650", Offset = "0x7C61250", VA = "0x187C62650")]
	private void ALNABOFENLG([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C639C0", Offset = "0x7C625C0", VA = "0x187C639C0")]
	protected void APKNBHKOMGE([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C68ED0", Offset = "0x7C67AD0", VA = "0x187C68ED0")]
	private void DKMNPHBJOAA([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C68300", Offset = "0x7C66F00", VA = "0x187C68300")]
	protected void DGILFMJHOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C63F70", Offset = "0x7C62B70", VA = "0x187C63F70")]
	private void BLIKNGGKDED([In] MBLBODMJALG DKILGKEHOLM, [In] HNFNGLGIBPL CJCPBFHLEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C764A0", Offset = "0x7C750A0", VA = "0x187C764A0")]
	private void NEBBGIGOODD(MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C62610", Offset = "0x7C61210", VA = "0x187C62610")]
	private void AJOFBIBELMK([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C73CE0", Offset = "0x7C728E0", VA = "0x187C73CE0")]
	private Vector3 LHMGKMEEHIM([In] MBLBODMJALG DKILGKEHOLM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C69350", Offset = "0x7C67F50", VA = "0x187C69350")]
	private void EAGLBNGANBE([In] MBLBODMJALG DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C76050", Offset = "0x7C74C50", VA = "0x187C76050")]
	private float NDPFKACPPNJ(float OBIAMCADEBF, [In] MBLBODMJALG DKILGKEHOLM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E770", Offset = "0x7C6D370", VA = "0x187C6E770")]
	private void JAFCPLJNNNB(float OBIAMCADEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C72000", Offset = "0x7C70C00", VA = "0x187C72000")]
	private void KPIKOFNOJLH([In] MBLBODMJALG DKILGKEHOLM, HNFNGLGIBPL CJCPBFHLEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B2C0", Offset = "0x7C69EC0", VA = "0x187C6B2C0")]
	private float GIICJEBGAHM([In] MBLBODMJALG GOGIKOKIEKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C870", Offset = "0x7C6B470", VA = "0x187C6C870")]
	private void HLFNDANNLGL(MBLBODMJALG DKILGKEHOLM, HNFNGLGIBPL CJCPBFHLEBG, Vector3 FNNCKDLFBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B750", Offset = "0x7C7A350", VA = "0x187C7B750")]
	private static void PJJGFFJMFID(Transform NMIBCHFJGAE, Quaternion BFEELDCLMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C75D20", Offset = "0x7C74920", VA = "0x187C75D20")]
	private void NBLKMAGHBLD([In] MBLBODMJALG MBCFMKDOGBC, [In] LLGDPIKACAP BNIHAIKCDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C62C50", Offset = "0x7C61850", VA = "0x187C62C50")]
	private void AMDCGAPHIPM([In] MBLBODMJALG MBCFMKDOGBC, [In] LLGDPIKACAP BNIHAIKCDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C66AC0", Offset = "0x7C656C0", VA = "0x187C66AC0")]
	private void BMAOEJMEKAK(float LMDKILNCFCA, [In] MBLBODMJALG GOGIKOKIEKF, float BJFODBJFEML = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C77EA0", Offset = "0x7C76AA0", VA = "0x187C77EA0")]
	private float OCMPEHENLMK([In] MBLBODMJALG GOGIKOKIEKF, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C76910", Offset = "0x7C75510", VA = "0x187C76910")]
	private void NMACGIKLMOB([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C76F50", Offset = "0x7C75B50", VA = "0x187C76F50")]
	private void NNNFBCDPBCH([In] MBLBODMJALG GOGIKOKIEKF, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A920", Offset = "0x7C69520", VA = "0x187C6A920")]
	private void FGKEEHACFJD([In] MBLBODMJALG GOGIKOKIEKF, float KLEBOEBMILN, float HDGPDBNEBAF, Vector3 HPBGHJNPNCA, float BJFODBJFEML = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DC00", Offset = "0x7C6C800", VA = "0x187C6DC00")]
	private void IOPPFOPAGPF(MBLBODMJALG GOGIKOKIEKF, AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D970", Offset = "0x7C6C570", VA = "0x187C6D970")]
	private void IOCHDKNONGD(MBLBODMJALG DKILGKEHOLM, AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C73730", Offset = "0x7C72330", VA = "0x187C73730")]
	private void LFJBECNDOMA(MBLBODMJALG GOGIKOKIEKF, AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A500", Offset = "0x7C69100", VA = "0x187C6A500")]
	public void EMGMPLHMDME([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C71990", Offset = "0x7C70590", VA = "0x187C71990")]
	public void KOBANBMKFFC([In] MBLBODMJALG DKILGKEHOLM, [In] AvatarFullBodyConfiguration JLMFPIBLIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C0A0", Offset = "0x7C6ACA0", VA = "0x187C6C0A0")]
	[CompilerGenerated]
	internal static void GNHLGNLLHHK(Transform ENEAIMANIIG, IKSolverVR.Arm LFEDEPNPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BD70", Offset = "0x7C6A970", VA = "0x187C6BD70")]
	[CompilerGenerated]
	internal static void GMIDEFFNOFJ(Vector3 PMNNGEJKPFI, Vector3 NBJEKDPGCJC, LGFDDDIKNJG P_2, DIEFMBPKHKC P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C750", Offset = "0x7C6B350", VA = "0x187C6C750")]
	[CompilerGenerated]
	internal static void HJEOEOICLNA(KIAODLBBAOF DMIMFLOHPNN, KIAODLBBAOF MNNMLHGGNIA, Vector3 LKFCPKGPJFB, float AJLIMPCCGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C67760", Offset = "0x7C66360", VA = "0x187C67760")]
	[CompilerGenerated]
	internal static bool DBEMNKKKFNB(IKSolverVR.Arm LFEDEPNPMAB, KHOIGAKPNOD OKEPFFAIAAN, float OFFKBHDEPCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C741F0", Offset = "0x7C72DF0", VA = "0x187C741F0")]
	[CompilerGenerated]
	internal static float LLLIEBBGGEN(Vector3 AKCICOEKOLD, Vector3 PLKNBHEOFBM, Vector3 CIHDHLKALKJ, MBLBODMJALG GOGIKOKIEKF, AvatarFullBodyConfiguration JLMFPIBLIFF, float KPHEINADMCH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class IKKAAKIGFOI : GCPMMEBPHON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Dictionary<string, HPGNGAKAOMH> BLHLDMNGOED;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C87640", Offset = "0x7C86240", VA = "0x187C87640")]
	[IGNGJLOKDFM.EEFPBBAIHAI]
	internal static void CDOANLBMHMA(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7C87A40", Offset = "0x7C86640", VA = "0x187C87A40", Slot = "4")]
	public HPGNGAKAOMH NMOBLLKLDBA(string ALHIDLGGBEP, AvatarSystemConfiguration MGIFPBNOLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C876B0", Offset = "0x7C862B0", VA = "0x187C876B0", Slot = "5")]
	public void JDEEHBEAEFP(string ALHIDLGGBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C87900", Offset = "0x7C86500", VA = "0x187C87900", Slot = "6")]
	public string NLDHJGHLIMA(string LOILLGDHCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C87890", Offset = "0x7C86490", VA = "0x187C87890")]
	private string JEAMNDMJAOF(string LOILLGDHCBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C87C60", Offset = "0x7C86860", VA = "0x187C87C60")]
	public IKKAAKIGFOI()
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
		public class DBJIABADDPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Dictionary<string, Transform> AJKAFGBBOHL;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool PNOGDJAFBNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x7C82990", Offset = "0x7C81590", VA = "0x187C82990")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7C829D0", Offset = "0x7C815D0", VA = "0x187C829D0")]
			public void KJDLMNIOACJ(VRIK GMGBDKBMLIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
			public void FCCEMHEOIOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7C82B00", Offset = "0x7C81700", VA = "0x187C82B00")]
			public void NFHAHJGCAOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7C82B50", Offset = "0x7C81750", VA = "0x187C82B50")]
			public DBJIABADDPF()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[MHLPBMEFLGC(EBAHNMNBCJP.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[GHKDIKFNBMM(EBAHNMNBCJP.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly DBJIABADDPF HBOHDGGPCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private GCBMLMHDBMA PCPJFHIHPLJ;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7C81E30", Offset = "0x7C80A30", VA = "0x187C81E30")]
		private void LEIJOMGLGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7C82110", Offset = "0x7C80D10", VA = "0x187C82110")]
		private bool OAIFCMKCPED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C82160", Offset = "0x7C80D60", VA = "0x187C82160")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7C821D0", Offset = "0x7C80DD0", VA = "0x187C821D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7C82170", Offset = "0x7C80D70", VA = "0x187C82170")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C82440", Offset = "0x7C81040", VA = "0x187C82440")]
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
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7C87580", Offset = "0x7C86180", VA = "0x187C87580")]
			public (float, float) LPIFOJJFABL(float NHLNMJLKADD)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7C86C70", Offset = "0x7C85870", VA = "0x187C86C70")]
			public void GFFHNKPMBNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7C86D50", Offset = "0x7C85950", VA = "0x187C86D50")]
			public (float, float) MPNMBLEBOPH(Animator KMKPAAPKAOM, AnimatorStateInfo PIDJMDONNIH)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7C870D0", Offset = "0x7C85CD0", VA = "0x187C870D0")]
		public void GFFHNKPMBNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C86E90", Offset = "0x7C85A90", VA = "0x187C86E90")]
		public (float, float) CKBAJECOOLI(Animator KMKPAAPKAOM, OJLMGLFEKAM GKKIEOBINHD, float BJLFHNICEEP)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7C872C0", Offset = "0x7C85EC0", VA = "0x187C872C0")]
		private (float, float) PAFBJHFOMHO(Animator KMKPAAPKAOM, AnimatorStateInfo PIDJMDONNIH, OJLMGLFEKAM GKKIEOBINHD, float BJLFHNICEEP)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7C87570", Offset = "0x7C86170", VA = "0x187C87570")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7C89460", Offset = "0x7C88060", VA = "0x187C89460", Slot = "4")]
		public override void OnStateEnter(Animator KMKPAAPKAOM, AnimatorStateInfo PIDJMDONNIH, int BLHNDFNBDNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C895C0", Offset = "0x7C881C0", VA = "0x187C895C0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class LBOIJENEGFP<TInput, TOutput> : KIFIMAFPPCI<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected readonly DGKBILEDBJJ KHABKJJDOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x527E130", Offset = "0x527CD30", VA = "0x18527E130")]
	protected LBOIJENEGFP(DGKBILEDBJJ KHABKJJDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput EBAGJKMAFHO(TInput OLMHJMNEENP, [Out] IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x527E090", Offset = "0x527CC90", VA = "0x18527E090", Slot = "5")]
	public bool PDGLDKEIFED(TInput OLMHJMNEENP, [Out] TOutput? DBJBIPJCIKA, [Out] IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BOOMHEJPJEF]
public static class EFEONPJANNH
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly Regex BKFAGJKCIFP;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7C83110", Offset = "0x7C81D10", VA = "0x187C83110")]
	public static HOLLOHBCIIF FCCKJJKFCEK(LFHPPJPAHAE EGLPIFKMHOI, PLMOHPIJHDA FPCAEEAKCLG, Guid? BONHDLJDKPI, Color? FGAHINDOGAI, HBNDGNKPEKC PMGLBCDCDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C82E70", Offset = "0x7C81A70", VA = "0x187C82E70")]
	public static GOFJDLJJOJL DODFJMFPKPN(HOLLOHBCIIF PEDMEJIDLNB)
	{
		return default(GOFJDLJJOJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3908EF0", Offset = "0x3907AF0", VA = "0x183908EF0")]
	internal static TModern? JDKBEJOABBO<TModern>(string? OLMHJMNEENP, IINBGDLEBFP<TModern> MMDCAEODGCA, DGKBILEDBJJ KHABKJJDOCJ, NKEJNNPNMEH ACMGLAMEJHD, TModern GCAEICINLKP) where TModern : struct, BFLKHIBEHMF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x390A540", Offset = "0x3909140", VA = "0x18390A540")]
	internal static FIKDKFFMFGO KFFPOKEAOJI<TModern>(string? OLMHJMNEENP, IINBGDLEBFP<TModern> MMDCAEODGCA, DGKBILEDBJJ KHABKJJDOCJ, NKEJNNPNMEH ACMGLAMEJHD, TModern GCAEICINLKP) where TModern : struct, BFLKHIBEHMF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7C82FD0", Offset = "0x7C81BD0", VA = "0x187C82FD0")]
	internal static List<BDDPIPFODIL> EDBMJLOIDAH(IEnumerable<IDNADOLKALK>? BDNHCMFOFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3908070", Offset = "0x3906C70", VA = "0x183908070")]
	internal static string BPBDEOEJOMA<TModern>(TModern OLMHJMNEENP, IINBGDLEBFP<TModern> MMDCAEODGCA, DGKBILEDBJJ KHABKJJDOCJ) where TModern : BFLKHIBEHMF
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class AJMOHJGOKIF : KLIMGIEECJL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KIFIMAFPPCI<KNGBOKKHLPJ, FKBFMJFEIFH> ONPNBECOOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public KIFIMAFPPCI<IPDMPCLJLFG, CNEBKLMIIBL> JMGNAJHECLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KIFIMAFPPCI<IPDMPCLJLFG, CNEBKLMIIBL> LPMGNIEEECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EKECKOGODFB HINAKOOCLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NEGHLDEOPJJ BINJPPFJKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7C80E70", Offset = "0x7C7FA70", VA = "0x187C80E70")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	[UsedImplicitly]
	internal static void NLIKBHJHOFF(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7C80EE0", Offset = "0x7C7FAE0", VA = "0x187C80EE0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AJMOHJGOKIF([GFNPNOLPMKK("UnitySerialization")] JPGFEHIEAAJ HGDAMFIMPGE, [GFNPNOLPMKK(null)] MCAHKOEDIHJ MBMEDMNPOGB, [GFNPNOLPMKK(null)] DGKBILEDBJJ KHABKJJDOCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum ONNKNKNDDOL
{
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FEIHJJDOPBO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7C85010", Offset = "0x7C83C10", VA = "0x187C85010")]
	public FEIHJJDOPBO(string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7C85040", Offset = "0x7C83C40", VA = "0x187C85040")]
	public FEIHJJDOPBO(string FNFIPKNHEOF, Exception HADEDFDJMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7C84FE0", Offset = "0x7C83BE0", VA = "0x187C84FE0")]
	public FEIHJJDOPBO(ONNKNKNDDOL MOGEIKLHIFI, string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7C84FA0", Offset = "0x7C83BA0", VA = "0x187C84FA0")]
	public FEIHJJDOPBO(ONNKNKNDDOL MOGEIKLHIFI, string FNFIPKNHEOF, Exception HADEDFDJMNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class HKKKAIPEFJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly JPGFEHIEAAJ HGDAMFIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly MCAHKOEDIHJ MBMEDMNPOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly DGKBILEDBJJ KHABKJJDOCJ;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C86AF0", Offset = "0x7C856F0", VA = "0x187C86AF0")]
	protected HKKKAIPEFJF(JPGFEHIEAAJ HGDAMFIMPGE, MCAHKOEDIHJ MBMEDMNPOGB, DGKBILEDBJJ KHABKJJDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C856E0", Offset = "0x7C842E0", VA = "0x187C856E0")]
	protected string FEIMAIOGIEG(FKBFMJFEIFH HCIFJIKKCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7C851D0", Offset = "0x7C83DD0", VA = "0x187C851D0")]
	protected string ENHFENNLNCE(FKBFMJFEIFH HCIFJIKKCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7C853B0", Offset = "0x7C83FB0", VA = "0x187C853B0")]
	private AvatarOutfitSelectionData FCCKJJKFCEK(HOLLOHBCIIF KAPGLFDIHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7C869B0", Offset = "0x7C855B0", VA = "0x187C869B0")]
	private static AvatarCustomizationSettingsData.AnchorParams HHNNOJIDFPI(JJMEKHLKNJB? KFFFNCOIDFN)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KIFIMAFPPCI<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput EBAGJKMAFHO(TInput OLMHJMNEENP, [Out] IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDGLDKEIFED(TInput OLMHJMNEENP, [Out] TOutput? DBJBIPJCIKA, [Out] IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KLIMGIEECJL
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	KIFIMAFPPCI<KNGBOKKHLPJ, FKBFMJFEIFH> ONPNBECOOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	KIFIMAFPPCI<IPDMPCLJLFG, CNEBKLMIIBL> LPMGNIEEECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	EKECKOGODFB HINAKOOCLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum NKEJNNPNMEH
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NEGHLDEOPJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INGEMLDNNPP BLPDEIDOFHH(FKBFMJFEIFH PEDMEJIDLNB);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EKECKOGODFB
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPDMPCLJLFG BLPDEIDOFHH(FKBFMJFEIFH PEDMEJIDLNB, int HCPPMGFJDNL, string? LAOCJKNALFF, string? CPIOEEDDFDB, ECKLOIPKONK DNKFMFAHMGK, List<BDDPIPFODIL>? NIEADMJLLKI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BOOMHEJPJEF]
internal class BFCCJDCFIHB : LBOIJENEGFP<KNGBOKKHLPJ, FKBFMJFEIFH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly MCAHKOEDIHJ MBMEDMNPOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly OCLKKHOMKAM KFIIFFDOMEI;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7C827C0", Offset = "0x7C813C0", VA = "0x187C827C0")]
	public BFCCJDCFIHB(JPGFEHIEAAJ HGDAMFIMPGE, MCAHKOEDIHJ MBMEDMNPOGB, DGKBILEDBJJ KHABKJJDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7C82520", Offset = "0x7C81120", VA = "0x187C82520", Slot = "6")]
	public override FKBFMJFEIFH EBAGJKMAFHO(KNGBOKKHLPJ OLMHJMNEENP, [Out] IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class GKPANHGCLNO : JPGFEHIEAAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class NENMGJLHMHC : JsonConverter<FIKDKFFMFGO>
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C89700", Offset = "0x7C88300", VA = "0x187C89700", Slot = "9")]
		public override void WriteJson(JsonWriter JKKEKKKNJIN, FIKDKFFMFGO? OOHGFGHCOAJ, JsonSerializer PBIAIHKJAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C895E0", Offset = "0x7C881E0", VA = "0x187C895E0", Slot = "10")]
		public override FIKDKFFMFGO ReadJson(JsonReader EENAIFHJAJK, Type ABAJKHLOBLK, FIKDKFFMFGO? DJEBBNDINOA, bool FDLEKHFMKOO, JsonSerializer PBIAIHKJAAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C897A0", Offset = "0x7C883A0", VA = "0x187C897A0")]
		public NENMGJLHMHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class EHNJMPKGFBE : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool AENOMINDILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7C83780", Offset = "0x7C82380", VA = "0x187C83780", Slot = "5")]
		public override object ReadJson(JsonReader EENAIFHJAJK, Type ABAJKHLOBLK, object? DJEBBNDINOA, JsonSerializer PBIAIHKJAAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C835A0", Offset = "0x7C821A0", VA = "0x187C835A0", Slot = "6")]
		public override bool CanConvert(Type ABAJKHLOBLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C837E0", Offset = "0x7C823E0", VA = "0x187C837E0", Slot = "4")]
		public override void WriteJson(JsonWriter JKKEKKKNJIN, object? OOHGFGHCOAJ, JsonSerializer PBIAIHKJAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C833C0", Offset = "0x7C81FC0", VA = "0x187C833C0")]
		private static bool BDKGJLPLGKP(object OOHGFGHCOAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public EHNJMPKGFBE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JsonSerializerSettings FDABCNCAEIC;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7C85070", Offset = "0x7C83C70", VA = "0x187C85070")]
	internal GKPANHGCLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C8C0", Offset = "0x3A9B4C0", VA = "0x183A9C8C0", Slot = "4")]
	public string DPLOBECOGJJ<T>(T KDKJDFFGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C920", Offset = "0x3A9B520", VA = "0x183A9C920", Slot = "5")]
	public T NKPJIKOIBHH<T>(string OOHGFGHCOAJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class PLJEGNBCOCD : JPGFEHIEAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3C85C50", Offset = "0x3C84850", VA = "0x183C85C50", Slot = "4")]
	public string DPLOBECOGJJ<T>(T KDKJDFFGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3C85CB0", Offset = "0x3C848B0", VA = "0x183C85CB0", Slot = "5")]
	public T NKPJIKOIBHH<T>(string OOHGFGHCOAJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PLJEGNBCOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BOOMHEJPJEF]
internal class OCLKKHOMKAM : LBOIJENEGFP<IPDMPCLJLFG, CNEBKLMIIBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly JPGFEHIEAAJ HGDAMFIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly MCAHKOEDIHJ MBMEDMNPOGB;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7C8BC00", Offset = "0x7C8A800", VA = "0x187C8BC00")]
	public OCLKKHOMKAM(JPGFEHIEAAJ HGDAMFIMPGE, MCAHKOEDIHJ MBMEDMNPOGB, DGKBILEDBJJ KHABKJJDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7C89B40", Offset = "0x7C88740", VA = "0x187C89B40", Slot = "6")]
	public override CNEBKLMIIBL EBAGJKMAFHO(IPDMPCLJLFG OLMHJMNEENP, [Out] IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AD20", Offset = "0x7C89920", VA = "0x187C8AD20")]
	internal void LNHLPOHFDCP(string KMIHDLJPAPN, FKBFMJFEIFH HCIFJIKKCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B700", Offset = "0x7C8A300", VA = "0x187C8B700")]
	public IEnumerable<HOLLOHBCIIF> MNNFFFJFJNK(string EELEOPAJBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A900", Offset = "0x7C89500", VA = "0x187C8A900")]
	private IEnumerable<HOLLOHBCIIF> LMPBGKAHPLJ(string EELEOPAJBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B7B0", Offset = "0x7C8A3B0", VA = "0x187C8B7B0")]
	internal IEnumerable<HOLLOHBCIIF> OKCNLEGOALP(string EELEOPAJBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A580", Offset = "0x7C89180", VA = "0x187C8A580")]
	private HOLLOHBCIIF HIDCOLBGGKF(AvatarOutfitSelectionData NKNHGMNFEDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AE80", Offset = "0x7C89A80", VA = "0x187C8AE80")]
	private void MLBMEAADGEC(AvatarCustomizationSettingsData BEOANOLDPAN, FKBFMJFEIFH HCIFJIKKCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A260", Offset = "0x7C88E60", VA = "0x187C8A260")]
	private HOLLOHBCIIF HIDCOLBGGKF(string CAOOEKCOAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7C89F60", Offset = "0x7C88B60", VA = "0x187C89F60")]
	internal static (HBNDGNKPEKC, string, string) HAJPBELEFNF(string CAOOEKCOAOK, DGKBILEDBJJ KHABKJJDOCJ)
	{
		return default((HBNDGNKPEKC, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7C89940", Offset = "0x7C88540", VA = "0x187C89940")]
	private BEALCFCAMAO? DAGFLOOPPII(string? LHECJJHBNHF, Vector2 IHIJHMKCPPP, float CBGOOAGMHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7C897E0", Offset = "0x7C883E0", VA = "0x187C897E0")]
	private static JJMEKHLKNJB CLLFBFCHLGE(AvatarCustomizationSettingsData.AnchorParams JLPGPPPGNOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BOOMHEJPJEF]
internal class PGNCANOPACE : HKKKAIPEFJF, NEGHLDEOPJJ
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7C86AF0", Offset = "0x7C856F0", VA = "0x187C86AF0")]
	public PGNCANOPACE(JPGFEHIEAAJ HGDAMFIMPGE, MCAHKOEDIHJ MBMEDMNPOGB, DGKBILEDBJJ KHABKJJDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8BD40", Offset = "0x7C8A940", VA = "0x187C8BD40", Slot = "4")]
	public INGEMLDNNPP BLPDEIDOFHH(FKBFMJFEIFH PEDMEJIDLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8C330", Offset = "0x7C8AF30", VA = "0x187C8C330")]
	private string NKKIIEBGMLE(FKBFMJFEIFH HCIFJIKKCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8C0F0", Offset = "0x7C8ACF0", VA = "0x187C8C0F0")]
	private string KJNEGJCBKFP(HOLLOHBCIIF KAPGLFDIHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BOOMHEJPJEF]
internal class MJMKKPFIMPF : LBOIJENEGFP<IPDMPCLJLFG, CNEBKLMIIBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly JPGFEHIEAAJ HGDAMFIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly KIFIMAFPPCI<IPDMPCLJLFG, CNEBKLMIIBL> GNEFIPLPBOA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7C89360", Offset = "0x7C87F60", VA = "0x187C89360")]
	public MJMKKPFIMPF(KIFIMAFPPCI<IPDMPCLJLFG, CNEBKLMIIBL> GNEFIPLPBOA, DGKBILEDBJJ KHABKJJDOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7C88F30", Offset = "0x7C87B30", VA = "0x187C88F30", Slot = "6")]
	public override CNEBKLMIIBL EBAGJKMAFHO(IPDMPCLJLFG OLMHJMNEENP, [Out] IReadOnlyList<BDDPIPFODIL>? NIEADMJLLKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BOOMHEJPJEF]
internal class LAILNCOFLLJ : EKECKOGODFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly JPGFEHIEAAJ HGDAMFIMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly NEGHLDEOPJJ KMICCDDCAFF;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C88E40", Offset = "0x7C87A40", VA = "0x187C88E40")]
	public LAILNCOFLLJ(NEGHLDEOPJJ KMICCDDCAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C88AA0", Offset = "0x7C876A0", VA = "0x187C88AA0", Slot = "4")]
	public IPDMPCLJLFG BLPDEIDOFHH(FKBFMJFEIFH PEDMEJIDLNB, int HCPPMGFJDNL, string? LAOCJKNALFF, string? CPIOEEDDFDB, ECKLOIPKONK DNKFMFAHMGK, List<BDDPIPFODIL>? NIEADMJLLKI)
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
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7C814F0", Offset = "0x7C800F0", VA = "0x187C814F0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DJOCICCEHLL
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C82D60", Offset = "0x7C81960", VA = "0x187C82D60")]
	public static GOFJDLJJOJL EBAGJKMAFHO(this OCKHAPIECEB PEDMEJIDLNB)
	{
		return default(GOFJDLJJOJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7C82C40", Offset = "0x7C81840", VA = "0x187C82C40")]
	public static OCKHAPIECEB BLPDEIDOFHH(this GOFJDLJJOJL HJFEKPGLBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7C82BE0", Offset = "0x7C817E0", VA = "0x187C82BE0")]
	public static bool ALKMDACFIMC(this GOFJDLJJOJL HJFEKPGLBDH)
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
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5DD9E80", Offset = "0x5DD8A80", VA = "0x185DD9E80")]
			public AnchorParams(Vector2 DGMAFGEPDGF, Vector3 PMDEGCGIELK, Vector3 OMFMCCKINJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C81440", Offset = "0x7C80040", VA = "0x187C81440")]
			internal JJMEKHLKNJB BLPDEIDOFHH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private GCHCDGNDLCF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x7C81CE0", Offset = "0x7C808E0", VA = "0x187C81CE0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x173FA80", Offset = "0x173E680", VA = "0x18173FA80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xD6C4D0", Offset = "0xD6B0D0", VA = "0x180D6C4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xF23850", Offset = "0xF22450", VA = "0x180F23850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1425D80", Offset = "0x1424980", VA = "0x181425D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA217E0", Offset = "0xA203E0", VA = "0x180A217E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7C81D80", Offset = "0x7C80980", VA = "0x187C81D80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA282A0", Offset = "0xA26EA0", VA = "0x180A282A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xC99B40", Offset = "0xC98740", VA = "0x180C99B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xC9A1E0", Offset = "0xC98DE0", VA = "0x180C9A1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA24890", Offset = "0xA23490", VA = "0x180A24890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7C81DC0", Offset = "0x7C809C0", VA = "0x187C81DC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xEE91A0", Offset = "0xEE7DA0", VA = "0x180EE91A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1152C10", Offset = "0x1151810", VA = "0x181152C10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x18E00B0", Offset = "0x18DECB0", VA = "0x1818E00B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6C0", Offset = "0xA1B2C0", VA = "0x180A1C6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA1C690", Offset = "0xA1B290", VA = "0x180A1C690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x243AA30", Offset = "0x2439630", VA = "0x18243AA30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xF0E6D0", Offset = "0xF0D2D0", VA = "0x180F0E6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA54660", Offset = "0xA53260", VA = "0x180A54660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA546C0", Offset = "0xA532C0", VA = "0x180A546C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA2BE40", Offset = "0xA2AA40", VA = "0x180A2BE40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA2BDA0", Offset = "0xA2A9A0", VA = "0x180A2BDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA2BE00", Offset = "0xA2AA00", VA = "0x180A2BE00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA2BDB0", Offset = "0xA2A9B0", VA = "0x180A2BDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA2BE50", Offset = "0xA2AA50", VA = "0x180A2BE50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA2BC90", Offset = "0xA2A890", VA = "0x180A2BC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA835A0", Offset = "0xA821A0", VA = "0x180A835A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA804F0", Offset = "0xA7F0F0", VA = "0x180A804F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA2BD10", Offset = "0xA2A910", VA = "0x180A2BD10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA2BD70", Offset = "0xA2A970", VA = "0x180A2BD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA839C0", Offset = "0xA825C0", VA = "0x180A839C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA9A0B0", Offset = "0xA98CB0", VA = "0x180A9A0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA2A4A0", Offset = "0xA290A0", VA = "0x180A2A4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA2A4D0", Offset = "0xA290D0", VA = "0x180A2A4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA9A080", Offset = "0xA98C80", VA = "0x180A9A080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA9A030", Offset = "0xA98C30", VA = "0x180A9A030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xD14880", Offset = "0xD13480", VA = "0x180D14880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xD12690", Offset = "0xD11290", VA = "0x180D12690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GCHCDGNDLCF UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xFB13B0", Offset = "0xFAFFB0", VA = "0x180FB13B0")]
			get
			{
				return default(GCHCDGNDLCF);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xFAFFE0", Offset = "0xFAEBE0", VA = "0x180FAFFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xFB2090", Offset = "0xFB0C90", VA = "0x180FB2090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xC7A9B0", Offset = "0xC795B0", VA = "0x180C7A9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C81DA0", Offset = "0x7C809A0", VA = "0x187C81DA0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C81DE0", Offset = "0x7C809E0", VA = "0x187C81DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C81980", Offset = "0x7C80580", VA = "0x187C81980")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HBNDGNKPEKC BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private CIDEIGJIEDC? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7C81E00", Offset = "0x7C80A00", VA = "0x187C81E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
