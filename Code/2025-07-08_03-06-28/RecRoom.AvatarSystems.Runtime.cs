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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F707C0", Offset = "0x7F6F5C0", VA = "0x187F707C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F70840", Offset = "0x7F6F640", VA = "0x187F70840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HCBEFNLCJPF]
internal class JEJEPNJPMIF : NNDCGEJFCCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DFHADGNAEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public JEJEPNJPMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public PKNFPGJAIIB avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly COOHOBLCNJO LOBKPBNMBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OHLNENJBNKM CGFJNGGFLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OAGLLEEAHJE LONPDLLHPJF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D720", Offset = "0x7F6C520", VA = "0x187F6D720")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	[UsedImplicitly]
	internal static void NEBFFACFKHB(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E3A0", Offset = "0x7F6D1A0", VA = "0x187F6E3A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JEJEPNJPMIF([OLOAAHJODHH(null)] COOHOBLCNJO LOBKPBNMBKD, [OLOAAHJODHH(null)] OHLNENJBNKM CGFJNGGFLPO, [OLOAAHJODHH(null)] OAGLLEEAHJE LONPDLLHPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CA90", Offset = "0x7F6B890", VA = "0x187F6CA90", Slot = "5")]
	public MAMJKFCNJKC BHFAAOAMLGK(PKNFPGJAIIB AFDMCKAKEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D820", Offset = "0x7F6C620", VA = "0x187F6D820", Slot = "4")]
	public MAMJKFCNJKC OCJBEPJEDEN(PKNFPGJAIIB AFDMCKAKEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D350", Offset = "0x7F6C150", VA = "0x187F6D350", Slot = "6")]
	public LFOGLJADGMO CCHIMIIDKEK(MAMJKFCNJKC BOIPFNOKGBJ, int MGGAEMKOADB, string? GGDFKFACHGG, string? CPPBIPFENNP, NGHFCMNNGJM KNADKFHEGDI, List<NOFBPEFCPEN>? EPCMJFMMJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D790", Offset = "0x7F6C590", VA = "0x187F6D790", Slot = "7")]
	public bool NIDAFPALOHN(LMJHLONIKBE LAMLBHGLINN, [Out] MAMJKFCNJKC? HPAFAKCFFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D640", Offset = "0x7F6C440", VA = "0x187F6D640", Slot = "8")]
	public bool LJNPNFEMHEF(LFOGLJADGMO CMNDMCDJNKB, [Out] MAMJKFCNJKC? HPAFAKCFFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E310", Offset = "0x7F6D110", VA = "0x187F6E310", Slot = "9")]
	public bool PBGGHAKIFMN(LFOGLJADGMO CMNDMCDJNKB, [Out] OPAAGPPHAEP? LAMLBHGLINN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3BEB050", Offset = "0x3BE9E50", VA = "0x183BEB050")]
	private bool IGGCMLBAHGK<TInput, TOutput>(TInput PADDIEKMDDH, NPICHFKMMPG<TInput, TOutput> GAIFBHHEDMA, [Out] TOutput? OHLBIIOAJDL) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C8F0", Offset = "0x7F6B6F0", VA = "0x187F6C8F0")]
	[CompilerGenerated]
	private OCJBFIOACAA BAOKKECAKHE(FaceFeatureType HNBPPNIGJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D460", Offset = "0x7F6C260", VA = "0x187F6D460")]
	[CompilerGenerated]
	private OCJBFIOACAA HJFFHKBLMCE(FaceFeatureType HNBPPNIGJHI, DFHADGNAEDD P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HCBEFNLCJPF]
internal class JOEKNDNGCGO : COOHOBLCNJO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DNDPGMHNGOH<in TData>(TData HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LDKFCLCIFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public PMJDFCMACFJ rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public KHCGBJGPDFI currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KHCGBJGPDFI latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public LDKFCLCIFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F70720", Offset = "0x7F6F520", VA = "0x187F70720")]
		internal bool COOANOBMPDP(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F70740", Offset = "0x7F6F540", VA = "0x187F70740")]
		internal bool PGEJDEKCDOO(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OAGLLEEAHJE LONPDLLHPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NEFGBBBPMJE LFAMJEMPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DNDPGMHNGOH<MAMJKFCNJKC>?[] LOBKPBNMBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DNDPGMHNGOH<OPAAGPPHAEP>?[] OPBMAKBPHNH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FFC0", Offset = "0x7F6EDC0", VA = "0x187F6FFC0")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	[UsedImplicitly]
	internal static void NEBFFACFKHB(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F700A0", Offset = "0x7F6EEA0", VA = "0x187F700A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JOEKNDNGCGO([OLOAAHJODHH(null)] OAGLLEEAHJE LONPDLLHPJF, [OLOAAHJODHH(null)] NEFGBBBPMJE LFAMJEMPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EA60", Offset = "0x7F6D860", VA = "0x187F6EA60", Slot = "4")]
	public bool COKDDKMDALO(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EB60", Offset = "0x7F6D960", VA = "0x187F6EB60", Slot = "5")]
	public bool COKDDKMDALO(OPAAGPPHAEP LAMLBHGLINN, IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F6ECD0", Offset = "0x7F6DAD0", VA = "0x187F6ECD0")]
	private void FFMBHNKDFHB(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E520", Offset = "0x7F6D320", VA = "0x187F6E520")]
	private void APOKEAFIDFC(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EA30", Offset = "0x7F6D830", VA = "0x187F6EA30")]
	private void BGCGMADMDAP(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FF90", Offset = "0x7F6ED90", VA = "0x187F6FF90")]
	private void LIEJONGFBJD(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F960", Offset = "0x7F6E760", VA = "0x187F6F960")]
	private void FLDKFHMBAPJ(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F8B0", Offset = "0x7F6E6B0", VA = "0x187F6F8B0")]
	private void FFNOMENAFEC(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FC00", Offset = "0x7F6EA00", VA = "0x187F6FC00")]
	private void IBKMFEOKNKM(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6ECC0", Offset = "0x7F6DAC0", VA = "0x187F6ECC0")]
	private void EJOALIKJFOA(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F70070", Offset = "0x7F6EE70", VA = "0x187F70070")]
	private void POHINGFLJAG(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? FCNMCCJKGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FCB0", Offset = "0x7F6EAB0", VA = "0x187F6FCB0")]
	private void KAPCIGOKAGJ(MAMJKFCNJKC HPAFAKCFFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E750", Offset = "0x7F6D550", VA = "0x187F6E750")]
	private MAMJKFCNJKC BCHMFHPBDLN(MAMJKFCNJKC HPAFAKCFFEI, List<RangeMigration> PKKKEEAICLE, KHCGBJGPDFI GENBNDCAJMI, KHCGBJGPDFI PJKFDEIFJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F70030", Offset = "0x7F6EE30", VA = "0x187F70030")]
	private float NHCAANIMKOC(float LHPFEMELMLE, Vector2 FBPDDDICHIO, Vector2 AIDILDPDNEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FA30", Offset = "0x7F6E830", VA = "0x187F6FA30")]
	private (RangeMigration?, RangeMigration?) GHPGOGBBIHD(List<RangeMigration> JGHGLCHMEDA, PMJDFCMACFJ OMJFKGLIMMI, KHCGBJGPDFI GENBNDCAJMI, KHCGBJGPDFI PJKFDEIFJOE)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface COOHOBLCNJO
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COKDDKMDALO(MAMJKFCNJKC HPAFAKCFFEI, IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool COKDDKMDALO(OPAAGPPHAEP LAMLBHGLINN, IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB);
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
		public LLNAFKIBAKK AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7F4FC60", Offset = "0x7F4EA60", VA = "0x187F4FC60")]
		public void EIHJBLPHLLP(AnimationPoseSetting LOKLFHKEJPC, float EBGHAKDGLEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4FD90", Offset = "0x7F4EB90", VA = "0x187F4FD90")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x7F506A0", Offset = "0x7F4F4A0", VA = "0x187F506A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F50660", Offset = "0x7F4F460", VA = "0x187F50660")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4FDB0", Offset = "0x7F4EBB0", VA = "0x187F4FDB0")]
		private void EHBOHLAMNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EDEB50", Offset = "0x7EDD950", VA = "0x187EDEB50", Slot = "4")]
		public void SetEnabled(bool IDKBJKINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F506D0", Offset = "0x7F4F4D0", VA = "0x187F506D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F50710", Offset = "0x7F4F510", VA = "0x187F50710")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F50750", Offset = "0x7F4F550", VA = "0x187F50750")]
		public AnimationPoseSetting MILPABDFEOJ(LLNAFKIBAKK FNINHMKJAJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F50780", Offset = "0x7F4F580", VA = "0x187F50780")]
		public void ONJHMMKMDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F507C0", Offset = "0x7F4F5C0", VA = "0x187F507C0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum MBFFMNCMOBM
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private MBFFMNCMOBM handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x7F512D0", Offset = "0x7F500D0", VA = "0x187F512D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F51290", Offset = "0x7F50090", VA = "0x187F51290")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F50C70", Offset = "0x7F4FA70", VA = "0x187F50C70")]
		private void EHBOHLAMNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7EDEB50", Offset = "0x7EDD950", VA = "0x187EDEB50", Slot = "4")]
		public void SetEnabled(bool IDKBJKINDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F51300", Offset = "0x7F50100", VA = "0x187F51300")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, BLHAPJFGHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private PKNFPGJAIIB avatarBodyType;

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
		[LHHMDDGFBKD(NKIOFDIBBLL.SelfAndChildren, false, false, false)]
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
		private HGPIEJBGKCA CIAEFIMDCMA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HGPIEJBGKCA HBEBPAIANLC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xBBF580", Offset = "0xBBE380", VA = "0x180BBF580", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform FDBGHPPJADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7F520F0", Offset = "0x7F50EF0", VA = "0x187F520F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F51330", Offset = "0x7F50130", VA = "0x187F51330")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F51FB0", Offset = "0x7F50DB0", VA = "0x187F51FB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F51F60", Offset = "0x7F50D60", VA = "0x187F51F60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F51EF0", Offset = "0x7F50CF0", VA = "0x187F51EF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F51330", Offset = "0x7F50130", VA = "0x187F51330", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F516C0", Offset = "0x7F504C0", VA = "0x187F516C0", Slot = "6")]
		public HGPIEJBGKCA CreateAvatarSystem(string DIIOOLNJPKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F51EF0", Offset = "0x7F50CF0", VA = "0x187F51EF0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F513F0", Offset = "0x7F501F0", VA = "0x187F513F0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F52000", Offset = "0x7F50E00", VA = "0x187F52000", Slot = "9")]
		public void UpdatePostIKAnimControllers(float GJELOGAKDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class FLHACLCDJKC : HGPIEJBGKCA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class PMAPDBBFAEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 JNOLHPHFNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion JMLEDFFINMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 DCEBIOMOPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Transform GCDHJAJHONP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 JBBGHFCEPIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x214A0A0", Offset = "0x2148EA0", VA = "0x18214A0A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x214A0C0", Offset = "0x2148EC0", VA = "0x18214A0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion PCPOGEJKHJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1556210", Offset = "0x1555010", VA = "0x181556210")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1556110", Offset = "0x1554F10", VA = "0x181556110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float GKHNNLDJFJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x11F3CF0", Offset = "0x11F2AF0", VA = "0x1811F3CF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x196F020", Offset = "0x196DE20", VA = "0x18196F020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool JJAEIGJDEMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA604E0", Offset = "0xA5F2E0", VA = "0x180A604E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA60420", Offset = "0xA5F220", VA = "0x180A60420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool FLAIKLOEHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA60500", Offset = "0xA5F300", VA = "0x180A60500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA604C0", Offset = "0xA5F2C0", VA = "0x180A604C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool OKKGFKMOODJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA60480", Offset = "0xA5F280", VA = "0x180A60480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA605B0", Offset = "0xA5F3B0", VA = "0x180A605B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float JMDAIGPPEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xDA13F0", Offset = "0xDA01F0", VA = "0x180DA13F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xDA2650", Offset = "0xDA1450", VA = "0x180DA2650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BDF0", Offset = "0x7F7ABF0", VA = "0x187F7BDF0")]
		public void HDMBKDCJABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BBB0", Offset = "0x7F7A9B0", VA = "0x187F7BBB0")]
		public void AEODIEINKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BF70", Offset = "0x7F7AD70", VA = "0x187F7BF70")]
		public float OMCNJBNFFJL(Vector3 KJHCBNJADIC, Quaternion NHJCNKOMGAB, [In] AvatarFootSettings CJKEONJLGKM, float BBEKCHMELDF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B4D0", Offset = "0x7F7A2D0", VA = "0x187F7B4D0")]
		public void ABIJIPOGKDE(Vector3 MFKNJHJOALK, Quaternion FNGONONGPAO, Transform PGCIBIGMPJE, float DLDDIKCBMKM, bool FOCHADOPJGN, bool PDNIPEHNDEA, float KDNMDKAGKDA, float KDHOCDJNLLA, Transform EGPDFGOHLFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BBC0", Offset = "0x7F7A9C0", VA = "0x187F7BBC0")]
		public void EKNMMJPHLBN(Transform EJHMLDJMEIL, Transform EGPDFGOHLFM, bool GAIDMGPKAGK, bool MFGMAIPJKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C180", Offset = "0x7F7AF80", VA = "0x187F7C180")]
		private void OOGPPHKDGPC(Transform EGPDFGOHLFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BE20", Offset = "0x7F7AC20", VA = "0x187F7BE20")]
		public bool OEJCELBPJIH(Transform EGPDFGOHLFM, AvatarFullBodyConfiguration FNFCFIGCMHH, Vector3 KPKJDDJDLBN, float NPAHNOJNJBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BE00", Offset = "0x7F7AC00", VA = "0x187F7BE00")]
		public void JFEHNFJFBNJ(float KDHOCDJNLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C280", Offset = "0x7F7B080", VA = "0x187F7C280")]
		public PMAPDBBFAEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class MNLNMHEMKFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float IMIEAGGPILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool CPHBPHAKCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AnimationPoseSetting FJKFKEKIIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private float CNKIPDAGAFH;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F79690", Offset = "0x7F78490", VA = "0x187F79690")]
		public void EGDEDFDLFHB(IKSolverVR.Arm EGMCDJLMNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A790", Offset = "0x7F79590", VA = "0x187F7A790")]
		public void OOEOEMIJBCB(IKSolverVR.Arm EGMCDJLMNOG, float EKCMGIOHEBM, bool CPHBPHAKCID, AvatarFullBodyConfiguration FNFCFIGCMHH, float KJLNCNCOPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F79FF0", Offset = "0x7F78DF0", VA = "0x187F79FF0")]
		private void KOAOGLHBDNL(IKSolverVR.Arm EGMCDJLMNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A910", Offset = "0x7F79710", VA = "0x187F7A910")]
		public void PHOAAJGFBLB(IKSolverVR.Arm EGMCDJLMNOG, Transform PMDEHCADEEN, Transform PGCIBIGMPJE, Quaternion PHKHJPABJBG, Vector3 PDBOLNFJEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F796C0", Offset = "0x7F784C0", VA = "0x187F796C0")]
		private (Vector3, Quaternion) HMFPCFPDABN(DAJLNAGNEAO JNPMMPAAGGP, Quaternion BMCNIAEEDHF, Vector3 EGOIFJOEFFN)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A030", Offset = "0x7F78E30", VA = "0x187F7A030")]
		public void LJHDKHOFLCM(DAJLNAGNEAO JNPMMPAAGGP, IKSolverVR.Arm EGMCDJLMNOG, Quaternion BMCNIAEEDHF, Vector3 EGOIFJOEFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A190", Offset = "0x7F78F90", VA = "0x187F7A190")]
		public void OENCLCANEKJ(DAJLNAGNEAO JNPMMPAAGGP, IKSolverVR.Arm EGMCDJLMNOG, Quaternion BMCNIAEEDHF, Vector3 EGOIFJOEFFN, [In] AvatarFullBodyConfiguration FNFCFIGCMHH, [In] MGHNOBKDCAE EOMNODKHFBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A7D0", Offset = "0x7F795D0", VA = "0x187F7A7D0")]
		public void PGBLJGENCKJ(LLNAFKIBAKK CLAFGGMHNPJ, AvatarFullBodyConfiguration FNFCFIGCMHH, MGHNOBKDCAE EOMNODKHFBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F79B50", Offset = "0x7F78950", VA = "0x187F79B50")]
		public void HOJNIBCCJAP(IKSolverVR.Arm EGMCDJLMNOG, Transform PMDEHCADEEN, Vector3 LIDMLFFLCBA, float PDEILAOGKCA, Quaternion KCMNAEPBKCM, Vector3 MDJFNKOHPNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7F7ACF0", Offset = "0x7F79AF0", VA = "0x187F7ACF0")]
		public MNLNMHEMKFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum EEBAHBCIGOK
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
	private struct MONDGKOBLGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct IJFFAEOPCMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int MKEDABBFFNC;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int OHFJHMGGLPO;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int BGJHNFCKNAM;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int PBFDFKKGEDN;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int DFHANPJFFFG;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int JABHKFEKNDJ;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int OLBBIECEPGL;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int FJMDGCNBFKM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int PEAPBEIGGDO;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int NLAEKLJMNLH;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int ALCBJAECAFK;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int OJAMLPLNMBB;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int GPLGHAFLHEP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int BMLGIHJKDIC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int DGGOLMNNMMG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int OIOIDHLOFHO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int ODBNOEKLJII;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int NFCHHGPFAOK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int LHBDPCJFMBK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int FCHGGAILDIF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int JEIMJBPGIEI;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int IDDDODCCCGM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int FLCHGIOJNOA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int MDHKNKPBJPA;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int MAAEKNALAEK;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int KEMEJMKENLF;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int GNKBACKMPDN;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int MOEJDOCMFEP;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int LEAIBLELGNH;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int HEJKNGILAHK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int LABKMEMNLKH;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int GMKKIHEHKAP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 CMAGHOFOGAF;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int EOFCNMDINBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool PIHNBGLIOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool NOKIKCGOEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool DIFNPOKOHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool LIANLBJEMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool OCEBECJJJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool LONFHEJPMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 COJFAPDOADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string GEFFNOLPGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private JKJLHBMPFJH? NILKJCIONLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private BPCADBPEGHO? PCCJNMFBEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PGNJDNMGAEC FFFEFPFLGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private KOBHOKNFIOJ OHLPKBGMBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private DAJLNAGNEAO JPHNDBLNLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private DAJLNAGNEAO NGCMKKEOIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool JELKCEMIGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool DJDKKNAFJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly NLMIAEPBION NPMPJLHGBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly MMMPMMIOIJK JHMKBMMPCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int ANEHDHPKALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float GKNPNDMKNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject OMJLFGDMKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform FLALCFLJPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform BEFPONJDBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform KNIGILHNFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform LGFLLIENHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float AJKEBPGHBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float NHPPCEOOHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 NFPENAIGDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion ADGIPDIFGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform DOHKGBAFGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform KLOKMNFDHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform KADBODNGOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PAMHNMDOJHJ CBBHGBPFMIG;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker ENDCFNCKBAJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker PFGBBINCOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker LIOKEILDEFA;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker MLFJKHLLAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker GAADIOOEFIG;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker PCIPHNIGOFN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<FLHACLCDJKC> JNDDNPLENJB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int OJNPJINLLDE;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> DIPGPCIIFNE;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int FFPMLIKGBLJ;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int OHNIEPFJHNI;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int BDIMCJBCDJP;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int IKDJGHGFEGP;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float GMHHLICLIHE;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int ELMNCCIKEGJ;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float NPLCGKMPKIG;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float CMEDJIKLCCH;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float OAPKIIEINNB;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float CFPNOHDIDCM;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static BALMAHPDIII LJEFIIAOAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float IBBACGGJPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool EPEOBKGJNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float KIPPHEBEAHP;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int NLDIKFDFFCM;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int BEFJBOPDGGH;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int BCDEMBHCLGJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int EOPOGPMEHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private PMAPDBBFAEN JPKECHDGGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PMAPDBBFAEN EIEKMINBGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float PIMMCEFDDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 LHCHPHDLFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 FDOMBLJPOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool GPANPMOMOEF;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion IGOFMCBJLHF;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion NEOPABAHNBB;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 PEGJGPFDHNN;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 NKNEIHEEOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float FJHCLBMGNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float HODIOPJACKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private MNLNMHEMKFC JDCLAGHEPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private MNLNMHEMKFC FODEDBOIOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private KMOLBGBMEFH CGIHAJGIPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private NBDPDLIOBCL JDCGEEHAHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly MABLHJFCJIH DLONGDBNGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float EKHJCNIEABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float MCNABEGDNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly NBDPDLIOBCL GIEBPHHAIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 FMNOAFPHGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 DEMPGDIFGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float BHFEOAOBILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float IHHENOKGMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly NBDPDLIOBCL DJIHJAAKODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly KMOLBGBMEFH OMBNHDKPHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly NBDPDLIOBCL HHFOCAMDGHH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EPBKGABEMJJ NHGNLOMKAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EPBKGABEMJJ JJGFJIKOFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration BDODILEIPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B280", Offset = "0x7F5A080", VA = "0x187F5B280", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PKNFPGJAIIB NCIHFOBJIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F52C50", Offset = "0x7F51A50", VA = "0x187F52C50", Slot = "24")]
		get
		{
			return default(PKNFPGJAIIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration BKOBDBAIFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CD60", Offset = "0x7F5BB60", VA = "0x187F5CD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform MNPJOBLOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F60CC0", Offset = "0x7F5FAC0", VA = "0x187F60CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform KHHBLKOLBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F591E0", Offset = "0x7F57FE0", VA = "0x187F591E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer IGHKKEHPAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F62C80", Offset = "0x7F61A80", VA = "0x187F62C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] DNGBBEAEGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F62FD0", Offset = "0x7F61DD0", VA = "0x187F62FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] IDDGOLDJLEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F68F00", Offset = "0x7F67D00", VA = "0x187F68F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator PINHPFGBKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F56E80", Offset = "0x7F55C80", VA = "0x187F56E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK OHDKLPCFJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F66990", Offset = "0x7F65790", VA = "0x187F66990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private PGIHJAPDENJ LECMCNOBLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F62D80", Offset = "0x7F61B80", VA = "0x187F62D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private PGIHJAPDENJ ICGAFEMIBLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BBE0", Offset = "0x7F5A9E0", VA = "0x187F5BBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private PGIHJAPDENJ GBGHJJFCOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F54C70", Offset = "0x7F53A70", VA = "0x187F54C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private PGIHJAPDENJ MKNADENPPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F69000", Offset = "0x7F67E00", VA = "0x187F69000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private PGIHJAPDENJ POMJMNPGIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7F62E80", Offset = "0x7F61C80", VA = "0x187F62E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private PGIHJAPDENJ BGBAMMBFEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7F69280", Offset = "0x7F68080", VA = "0x187F69280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private PGIHJAPDENJ MNBKCNIIGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F55D50", Offset = "0x7F54B50", VA = "0x187F55D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private PGIHJAPDENJ BEMOMFBENOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F55BD0", Offset = "0x7F549D0", VA = "0x187F55BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BPCADBPEGHO NKMCHGAJEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F62620", Offset = "0x7F61420", VA = "0x187F62620", Slot = "16")]
		get
		{
			return default(BPCADBPEGHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DKKDNHKBJLF CHEOCMJHINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB4BBC0", Offset = "0xB4A9C0", VA = "0x180B4BBC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GLADMCEDLEP MFIOCIPJPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB4BBB0", Offset = "0xB4A9B0", VA = "0x180B4BBB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FKLMPLDDLKB KDIOOGJEIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xBC54B0", Offset = "0xBC42B0", VA = "0x180BC54B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FKLMPLDDLKB AAFNBMBFOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB4BE30", Offset = "0xB4AC30", VA = "0x180B4BE30", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string NHFKAFLKGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform PJLNCCJOGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C520", Offset = "0x7F5B320", VA = "0x187F5C520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform FHBPOONCGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F60E60", Offset = "0x7F5FC60", VA = "0x187F60E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform CDALIIHHFDF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F59720", Offset = "0x7F58520", VA = "0x187F59720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform CBBDNOOLCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F58320", Offset = "0x7F57120", VA = "0x187F58320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform NDGPBENHAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F53F00", Offset = "0x7F52D00", VA = "0x187F53F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool KMOPEPFOIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F58E20", Offset = "0x7F57C20", VA = "0x187F58E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool HCOLDAPJFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F58E20", Offset = "0x7F57C20", VA = "0x187F58E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool OGLBNPAIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F020", Offset = "0x7F5DE20", VA = "0x187F5F020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform MADMPEDCJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F61720", Offset = "0x7F60520", VA = "0x187F61720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject JLNNGPHDMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F58280", Offset = "0x7F57080", VA = "0x187F58280", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets KLMPJOONLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F58360", Offset = "0x7F57160", VA = "0x187F58360", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform FEEOCGHIBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xBC5E30", Offset = "0xBC4C30", VA = "0x180BC5E30", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform EJGOHLKLMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBC53B0", Offset = "0xBC41B0", VA = "0x180BC53B0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform CFGHFINCBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBB3730", Offset = "0xBB2530", VA = "0x180BB3730", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform FFLGHOFOPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xACE0A0", Offset = "0xACCEA0", VA = "0x180ACE0A0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 LHMLAFPKMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B3E0", Offset = "0x7F6A1E0", VA = "0x187F6B3E0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float FJCOMLNANEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7F53FC0", Offset = "0x7F52DC0", VA = "0x187F53FC0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform FNPBDOAGEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7F596C0", Offset = "0x7F584C0", VA = "0x187F596C0", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform KPNDCHEHKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x154F610", Offset = "0x154E410", VA = "0x18154F610", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform IDGBMDLEELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x154F3C0", Offset = "0x154E1C0", VA = "0x18154F3C0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform ILODIBADOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xACE8B0", Offset = "0xACD6B0", VA = "0x180ACE8B0", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool FFBOHJOCHIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F577A0", Offset = "0x7F565A0", VA = "0x187F577A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IKLFNFDBNDM<HGPIEJBGKCA.CMCDHKNDNNO> EFHHPIBHDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F642A0", Offset = "0x7F630A0", VA = "0x187F642A0", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool LOACPABELGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F52BD0", Offset = "0x7F519D0", VA = "0x187F52BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool HCMDBKMDMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F53F40", Offset = "0x7F52D40", VA = "0x187F53F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F58F40", Offset = "0x7F57D40", VA = "0x187F58F40")]
	private float GAHKGHLMGIL(OKOMIEKODHK CHPCEINJOLJ, float EBCFKMFAFFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F597A0", Offset = "0x7F585A0", VA = "0x187F597A0")]
	private void GNJIGAOGGJL([In] MGHNOBKDCAE GBHLDHNGFAJ, [In] AvatarFullBodyConfiguration FNFCFIGCMHH, bool IHIIFHJLPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F58F60", Offset = "0x7F57D60", VA = "0x187F58F60")]
	private float GBMLEOFPPBG([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F616A0", Offset = "0x7F604A0", VA = "0x187F616A0")]
	private float KCKCDKLBDPL([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F66200", Offset = "0x7F65000", VA = "0x187F66200")]
	private void MLMHADGMINO(MGHNOBKDCAE GBHLDHNGFAJ, AvatarFullBodyConfiguration FNFCFIGCMHH, bool IHIIFHJLPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F69F40", Offset = "0x7F68D40", VA = "0x187F69F40")]
	private void PAEJEEKFGKP([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A3B0", Offset = "0x7F691B0", VA = "0x187F6A3B0")]
	private void PEFPJAOKBFO([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6C3F0", Offset = "0x7F6B1F0", VA = "0x187F6C3F0")]
	public FLHACLCDJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C570", Offset = "0x7F5B370", VA = "0x187F5C570", Slot = "13")]
	public void HOPAFNAGMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F69B90", Offset = "0x7F68990", VA = "0x187F69B90", Slot = "14")]
	public void OPKHMLPELEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F547D0", Offset = "0x7F535D0", VA = "0x187F547D0", Slot = "15")]
	public void CMPDFNFMPKL(bool OECGBAAEAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F683A0", Offset = "0x7F671A0", VA = "0x187F683A0", Slot = "26")]
	public Transform NMHAECNIHBM(string GFAKNNDBMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7F66060", Offset = "0x7F64E60", VA = "0x187F66060", Slot = "27")]
	public Vector3? MLJHIJCFEEP(string GFAKNNDBMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F630D0", Offset = "0x7F61ED0", VA = "0x187F630D0", Slot = "7")]
	public void MDPBNGHHMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BEA0", Offset = "0x7F5ACA0", VA = "0x187F5BEA0")]
	private void HLAJPMHMPLF(AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F53AB0", Offset = "0x7F528B0", VA = "0x187F53AB0", Slot = "8")]
	public void BPGIEFJHDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CC60", Offset = "0x7F5BA60", VA = "0x187F5CC60")]
	private void IDCJJEAOJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F61820", Offset = "0x7F60620", VA = "0x187F61820")]
	private Vector3 KHDBGLIICOG([In] MGHNOBKDCAE EOMNODKHFBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F56700", Offset = "0x7F55500", VA = "0x187F56700", Slot = "6")]
	public void EBGKJNOPCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F67BC0", Offset = "0x7F669C0", VA = "0x187F67BC0")]
	private void NLDLHECANJB(bool IHIIFHJLPJD, EEBAHBCIGOK ODPHEKMALCP, AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F52B60", Offset = "0x7F51960", VA = "0x187F52B60", Slot = "9")]
	public void AMLBLBBEMEE(float OEMIIAHPBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F529C0", Offset = "0x7F517C0", VA = "0x187F529C0")]
	private void AHPKOGFAHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CDF0", Offset = "0x7F5BBF0", VA = "0x187F5CDF0", Slot = "4")]
	public void IELIFJPNDCF(string DIIOOLNJPKJ, JKJLHBMPFJH NEFPAIHLODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F69380", Offset = "0x7F68180", VA = "0x187F69380", Slot = "5")]
	public void OKCIJICPKHL(BPCADBPEGHO BAHBHJFPCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F544D0", Offset = "0x7F532D0", VA = "0x187F544D0", Slot = "12")]
	public void CJPHMCIGGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F69800", Offset = "0x7F68600", VA = "0x187F69800", Slot = "25")]
	public void OPDAMEEINON([Out] Vector3 PMPFJDHPHCK, [Out] Quaternion KCMNAEPBKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F110", Offset = "0x7F5DF10", VA = "0x187F5F110")]
	private void IJLOKCGJAFE([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B980", Offset = "0x7F5A780", VA = "0x187F5B980", Slot = "28")]
	public void HABDNDDDDCH(float DFGFCDJJKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F60970", Offset = "0x7F5F770", VA = "0x187F60970", Slot = "29")]
	public void JEJNOOJMMDF(float FFBFCKPLKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F55650", Offset = "0x7F54450", VA = "0x187F55650", Slot = "46")]
	public void DHCDECIHKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F62F80", Offset = "0x7F61D80", VA = "0x187F62F80", Slot = "30")]
	public void LHECIGBMKHG(bool LEFBHBHKHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F666B0", Offset = "0x7F654B0", VA = "0x187F666B0", Slot = "31")]
	public HandLogicOffsets MPAFKJHNGHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F64030", Offset = "0x7F62E30", VA = "0x187F64030", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets MKBIFMKELBK()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F67B90", Offset = "0x7F66990", VA = "0x187F67B90")]
	private void NJDDIOGLLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F67A10", Offset = "0x7F66810", VA = "0x187F67A10")]
	private void NIGGPAOIMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B470", Offset = "0x7F6A270", VA = "0x187F6B470")]
	private void PPKHDMEEICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F63830", Offset = "0x7F62630", VA = "0x187F63830")]
	private void MFKKDKDABFL(OPDBNCCBFHO JLGBMHAMFFJ, bool DJGMHEMHHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F69100", Offset = "0x7F67F00", VA = "0x187F69100")]
	private void OEFDJMHACML(OPDBNCCBFHO JLGBMHAMFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F59750", Offset = "0x7F58550", VA = "0x187F59750")]
	public Vector3 GNIENDFFIDA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F583E0", Offset = "0x7F571E0", VA = "0x187F583E0")]
	private void FCEBJKJDCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CAB0", Offset = "0x7F5B8B0", VA = "0x187F5CAB0")]
	private void HPMJEHJCAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6AB80", Offset = "0x7F69980", VA = "0x187F6AB80")]
	private void PLBAIGDDCCM(MGHNOBKDCAE GBHLDHNGFAJ, AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F830", Offset = "0x7F5E630", VA = "0x187F5F830")]
	private float IPACNOHJLAI([In] MGHNOBKDCAE EOMNODKHFBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F55570", Offset = "0x7F54370", VA = "0x187F55570")]
	private int DGKGDKKGNGF([In] ABPLALNDLAI PGCJCDPDGBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F556A0", Offset = "0x7F544A0", VA = "0x187F556A0")]
	private void DJADAKOMNDF(MGHNOBKDCAE GBHLDHNGFAJ, bool COFBICDFDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F58BF0", Offset = "0x7F579F0", VA = "0x187F58BF0")]
	private static void FIOBHMLLEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FC70", Offset = "0x7F5EA70", VA = "0x187F5FC70")]
	private static void JAMBLAGMKLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F52110", Offset = "0x7F50F10", VA = "0x187F52110")]
	private float ABIIDIIPJLN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F6AB50", Offset = "0x7F69950", VA = "0x187F6AB50")]
	private static int PKCHBMDNBNN(FLHACLCDJKC EIECDDIBOHA, FLHACLCDJKC AFKLBECCDNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F65F10", Offset = "0x7F64D10", VA = "0x187F65F10", Slot = "41")]
	public MGHNOBKDCAE MLABBLDCJCK()
	{
		return default(MGHNOBKDCAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F66A90", Offset = "0x7F65890", VA = "0x187F66A90")]
	private bool NCDAIBBJKKE(int PPPFBKMGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F55CD0", Offset = "0x7F54AD0", VA = "0x187F55CD0")]
	public void DLIAAMMIBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F63E50", Offset = "0x7F62C50", VA = "0x187F63E50")]
	private (bool, bool) MJHBIBDCFNG()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F52D50", Offset = "0x7F51B50", VA = "0x187F52D50")]
	private (float, float) BEGGEFCNJIM([In] MGHNOBKDCAE EOMNODKHFBK)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F642B0", Offset = "0x7F630B0", VA = "0x187F642B0")]
	private void MKKBGDDNNGC([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F66390", Offset = "0x7F65190", VA = "0x187F66390")]
	private void MOHJNNPPBGG([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F675F0", Offset = "0x7F663F0", VA = "0x187F675F0")]
	private void NGOMBBBJGNL([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH, AvatarFootSettings CJKEONJLGKM, bool HKNDCJBPHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A330", Offset = "0x7F69130", VA = "0x187F6A330")]
	private float PBGLCEGADBP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F52F30", Offset = "0x7F51D30", VA = "0x187F52F30")]
	private void BOHCCAMKJGO(MGHNOBKDCAE EOMNODKHFBK, AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F63E00", Offset = "0x7F62C00", VA = "0x187F63E00")]
	private float MJEHJLCCMMG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F63370", Offset = "0x7F62170", VA = "0x187F63370")]
	private void MFIDIAKHKNA([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A860", Offset = "0x7F69660", VA = "0x187F6A860")]
	private void PHOAAJGFBLB([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F66E90", Offset = "0x7F65C90", VA = "0x187F66E90")]
	private void NCHLAFNENGJ([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F522E0", Offset = "0x7F510E0", VA = "0x187F522E0")]
	private void AELDGHEJCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F592E0", Offset = "0x7F580E0", VA = "0x187F592E0")]
	private void GMBJJJOGHKO(float AMPIDPJNAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CAD0", Offset = "0x7F5B8D0", VA = "0x187F5CAD0")]
	private void IAHDHOAKAMF([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F9E0", Offset = "0x7F5E7E0", VA = "0x187F5F9E0")]
	private void IPGFOKDNDCO(DAJLNAGNEAO IMIGEFHNJBD, IKSolverVR.Arm EGMCDJLMNOG, Transform HJJHMCAMDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F62160", Offset = "0x7F60F60", VA = "0x187F62160")]
	private void KJIKNIJGCJF(MGHNOBKDCAE EOMNODKHFBK, AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F568F0", Offset = "0x7F556F0", VA = "0x187F568F0")]
	private void ECMPJHFENLP(LHKLLOAONCN IKANCMMICBE, FKLMPLDDLKB IMIGEFHNJBD, IKSolverVR.Arm EGMCDJLMNOG, float EKCMGIOHEBM, float HPACAADAIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F53CF0", Offset = "0x7F52AF0", VA = "0x187F53CF0")]
	private void BPLNKJHBBNG([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B380", Offset = "0x7F5A180", VA = "0x187F5B380")]
	private void GPPECPKDFNK([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F56AC0", Offset = "0x7F558C0", VA = "0x187F56AC0")]
	protected void ECOHHEJCHNN([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F66B40", Offset = "0x7F65940", VA = "0x187F66B40")]
	private void NCDAIPJKOLC([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B990", Offset = "0x7F5A790", VA = "0x187F5B990")]
	protected void HBOLFEFMIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F56F80", Offset = "0x7F55D80", VA = "0x187F56F80")]
	private void EKOPFOAOGIN([In] MGHNOBKDCAE EOMNODKHFBK, [In] EEBAHBCIGOK ODPHEKMALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B230", Offset = "0x7F6A030", VA = "0x187F6B230")]
	private void PNFKHKAMKIC(MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CA70", Offset = "0x7F5B870", VA = "0x187F5CA70")]
	private void HPIAHCBAAFD([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F586D0", Offset = "0x7F574D0", VA = "0x187F586D0")]
	private Vector3 FCOLKMCMKCD([In] MGHNOBKDCAE EOMNODKHFBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F58E70", Offset = "0x7F57C70", VA = "0x187F58E70")]
	private void FLDGICJDKGM([In] MGHNOBKDCAE EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F52570", Offset = "0x7F51370", VA = "0x187F52570")]
	private float AHELPFOLOKA(float KDHOCDJNLLA, [In] MGHNOBKDCAE EOMNODKHFBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F52A10", Offset = "0x7F51810", VA = "0x187F52A10")]
	private void AKAMAPGNHFF(float KDHOCDJNLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F140", Offset = "0x7F5DF40", VA = "0x187F5F140")]
	private void IKEBELEBAJC([In] MGHNOBKDCAE EOMNODKHFBK, EEBAHBCIGOK ODPHEKMALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F54D70", Offset = "0x7F53B70", VA = "0x187F54D70")]
	private float DCCLNCPFLHB([In] MGHNOBKDCAE GBHLDHNGFAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F60EA0", Offset = "0x7F5FCA0", VA = "0x187F60EA0")]
	private void KBCGKFNKHNB(MGHNOBKDCAE EOMNODKHFBK, EEBAHBCIGOK ODPHEKMALCP, Vector3 AGBBNKKBCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F640F0", Offset = "0x7F62EF0", VA = "0x187F640F0")]
	private static void MKFHFPGAJPB(Transform OLPMPAIMKPI, Quaternion NOLDGDLLBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A560", Offset = "0x7F69360", VA = "0x187F6A560")]
	private void PGCLJMDBBBD([In] MGHNOBKDCAE NMCMNFOPJIM, [In] ABPLALNDLAI PGCJCDPDGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F55E50", Offset = "0x7F54C50", VA = "0x187F55E50")]
	private void DONBDKJOKPO([In] MGHNOBKDCAE NMCMNFOPJIM, [In] ABPLALNDLAI PGCJCDPDGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F58FF0", Offset = "0x7F57DF0", VA = "0x187F58FF0")]
	private void GHEAIDNDPJL(float PFAOCHHKECN, [In] MGHNOBKDCAE GBHLDHNGFAJ, float PGGLLNPLKEN = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F619A0", Offset = "0x7F607A0", VA = "0x187F619A0")]
	private float KJGHFACAAPB([In] MGHNOBKDCAE GBHLDHNGFAJ, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F63B10", Offset = "0x7F62910", VA = "0x187F63B10")]
	private void MIGEKHAONDB([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F684F0", Offset = "0x7F672F0", VA = "0x187F684F0")]
	private void NMLEEJMGNIG([In] MGHNOBKDCAE GBHLDHNGFAJ, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7F548A0", Offset = "0x7F536A0", VA = "0x187F548A0")]
	private void DAHCOGHMOIG([In] MGHNOBKDCAE GBHLDHNGFAJ, float NHOBHFJCKOH, float HLBKCFLOLHE, Vector3 PDMNJBLAGCK, float PGGLLNPLKEN = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F57890", Offset = "0x7F56690", VA = "0x187F57890")]
	private void EOOCPACCAFI(MGHNOBKDCAE GBHLDHNGFAJ, AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F66700", Offset = "0x7F65500", VA = "0x187F66700")]
	private void NACIMGHJGHD(MGHNOBKDCAE EOMNODKHFBK, AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F54010", Offset = "0x7F52E10", VA = "0x187F54010")]
	private void CIGHOPGCLAN(MGHNOBKDCAE GBHLDHNGFAJ, AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BCE0", Offset = "0x7F5AAE0", VA = "0x187F5BCE0")]
	public void HKJKHJHCKIC([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F67290", Offset = "0x7F66090", VA = "0x187F67290")]
	public void NFBNHMHCGPC([In] MGHNOBKDCAE EOMNODKHFBK, [In] AvatarFullBodyConfiguration FNFCFIGCMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F54630", Offset = "0x7F53430", VA = "0x187F54630")]
	[CompilerGenerated]
	internal static void CLLFBPJICGE(Transform GGCHDPHENOB, IKSolverVR.Arm EGMCDJLMNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A4B0", Offset = "0x7F692B0", VA = "0x187F6A4B0")]
	[CompilerGenerated]
	internal static void PGCHJMNHLLH(Vector3 GBJPGEJCOPD, Vector3 JAJDNEFHAEA, MONDGKOBLGM P_2, IJFFAEOPCMH P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F60DC0", Offset = "0x7F5FBC0", VA = "0x187F60DC0")]
	[CompilerGenerated]
	internal static void JHAGBJPOHJM(PMAPDBBFAEN HGKICBNCODM, PMAPDBBFAEN OOEIAEBMMHH, Vector3 BLFGGKHHAEF, float BKBLOMKNEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F62730", Offset = "0x7F61530", VA = "0x187F62730")]
	[CompilerGenerated]
	internal static bool KKMECGPMECP(IKSolverVR.Arm EGMCDJLMNOG, FLPLAMKKHFG KGECAEKBFAN, float MKNKMJLKMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F62840", Offset = "0x7F61640", VA = "0x187F62840")]
	[CompilerGenerated]
	internal static float KKOKEEMKPGG(Vector3 HACPMJALFCK, Vector3 IJKMOCHMNOF, Vector3 FAFPAACCNFP, MGHNOBKDCAE GBHLDHNGFAJ, AvatarFullBodyConfiguration FNFCFIGCMHH, float DOBKAGHAEBK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class LGIGCFAEJMD : NBJFPJIMJFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Dictionary<string, HGPIEJBGKCA> LAMDEAKHDMF;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7F78A00", Offset = "0x7F77800", VA = "0x187F78A00")]
	[ONLJNMLDJBD.KDDDMPKOLFO]
	internal static void NDJLOAICLNO(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7F784C0", Offset = "0x7F772C0", VA = "0x187F784C0", Slot = "4")]
	public HGPIEJBGKCA IAKNMHDFJBD(string FBKHBPIFHEL, AvatarSystemConfiguration LDLJKPNAGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7F786E0", Offset = "0x7F774E0", VA = "0x187F786E0", Slot = "5")]
	public void IODDCLIKFBF(string FBKHBPIFHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7F788C0", Offset = "0x7F776C0", VA = "0x187F788C0", Slot = "6")]
	public string LMKOIGCNGAF(string GNMBNMKMIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7F78450", Offset = "0x7F77250", VA = "0x187F78450")]
	private string HIHPFOLJBNJ(string GNMBNMKMIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7F78A70", Offset = "0x7F77870", VA = "0x187F78A70")]
	public LGIGCFAEJMD()
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
		public class AOEHLMGINDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Dictionary<string, Transform> CLFKGCNJIDJ;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool NPDDCPKLJPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x7F70CB0", Offset = "0x7F6FAB0", VA = "0x187F70CB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7F70B80", Offset = "0x7F6F980", VA = "0x187F70B80")]
			public void HKKMADGECGH(VRIK OIFKADFOBEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
			public void AHCODEMILFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7F70CF0", Offset = "0x7F6FAF0", VA = "0x187F70CF0")]
			public void PLDNCIPNLFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7F70D40", Offset = "0x7F6FB40", VA = "0x187F70D40")]
			public AOEHLMGINDB()
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
		[GHCBEJGHGJA(NKIOFDIBBLL.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[LHHMDDGFBKD(NKIOFDIBBLL.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly AOEHLMGINDB NMILPCKBFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private BLHAPJFGHFD LHPOLDKBNGJ;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F73F20", Offset = "0x7F72D20", VA = "0x187F73F20")]
		private void DGPDNICIDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F74200", Offset = "0x7F73000", VA = "0x187F74200")]
		private bool MPOGOBEHEEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7F74250", Offset = "0x7F73050", VA = "0x187F74250")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7F742C0", Offset = "0x7F730C0", VA = "0x187F742C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7F74260", Offset = "0x7F73060", VA = "0x187F74260")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7F74530", Offset = "0x7F73330", VA = "0x187F74530")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F77E40", Offset = "0x7F76C40", VA = "0x187F77E40")]
			public (float, float) FCDKFABOFLF(float OFEPBBHGEIO)
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
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7F77670", Offset = "0x7F76470", VA = "0x187F77670")]
			public void ONJHMMKMDOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7F77530", Offset = "0x7F76330", VA = "0x187F77530")]
			public (float, float) GHOPDMJOOAL(Animator JENHOLADGPF, AnimatorStateInfo BLKAJEHLKBG)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F77BF0", Offset = "0x7F769F0", VA = "0x187F77BF0")]
		public void ONJHMMKMDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7F77750", Offset = "0x7F76550", VA = "0x187F77750")]
		public (float, float) FCCEDADOOFI(Animator JENHOLADGPF, OKOMIEKODHK CHPCEINJOLJ, float LKFHBDLIEKK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7F77990", Offset = "0x7F76790", VA = "0x187F77990")]
		private (float, float) MACLJHBKLBF(Animator JENHOLADGPF, AnimatorStateInfo BLKAJEHLKBG, OKOMIEKODHK CHPCEINJOLJ, float LKFHBDLIEKK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7F77E30", Offset = "0x7F76C30", VA = "0x187F77E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F7AD70", Offset = "0x7F79B70", VA = "0x187F7AD70", Slot = "4")]
		public override void OnStateEnter(Animator JENHOLADGPF, AnimatorStateInfo BLKAJEHLKBG, int PFGFEOMMEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AEE0", Offset = "0x7F79CE0", VA = "0x187F7AEE0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class LEHKLKCHJHO<TInput, TOutput> : NPICHFKMMPG<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected readonly NEFGBBBPMJE LFAMJEMPOAL;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5412C40", Offset = "0x5411A40", VA = "0x185412C40")]
	protected LEHKLKCHJHO(NEFGBBBPMJE LFAMJEMPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput KIDJPDKJMHF(TInput PADDIEKMDDH, [Out] IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5412BA0", Offset = "0x54119A0", VA = "0x185412BA0", Slot = "5")]
	public bool IGGCMLBAHGK(TInput PADDIEKMDDH, [Out] TOutput? OHLBIIOAJDL, [Out] IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HCBEFNLCJPF]
public static class FHHLJGINKKM
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly Regex AEHHJFMHBIB;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7F76820", Offset = "0x7F75620", VA = "0x187F76820")]
	public static NHAPPPHCCCK FOIOCFHPLHH(NANMHMIBICI DIHALJHDCND, MKELHNOGKHJ AJLPPOOPFPL, Guid? AIGIABENOBD, Color? PLGCIHJKPNF, EEPOCEICAIB GPNKMGAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7F76B80", Offset = "0x7F75980", VA = "0x187F76B80")]
	public static EMIPHPEOPMO JGGOGJBCNIN(NHAPPPHCCCK BOIPFNOKGBJ)
	{
		return default(EMIPHPEOPMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3B64650", Offset = "0x3B63450", VA = "0x183B64650")]
	internal static TModern? BBFBBLFJDPN<TModern>(string? PADDIEKMDDH, EOHMEIJACBP<TModern> BDEEAMAAGED, NEFGBBBPMJE LFAMJEMPOAL, JMMOKMHALHB JCEMAKFKIKC, TModern DJLECGLCJOD) where TModern : struct, BNCNHCPLOHA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3B65CA0", Offset = "0x3B64AA0", VA = "0x183B65CA0")]
	internal static DOCKCEIEPPD LEOJBGOJEPE<TModern>(string? PADDIEKMDDH, EOHMEIJACBP<TModern> BDEEAMAAGED, NEFGBBBPMJE LFAMJEMPOAL, JMMOKMHALHB JCEMAKFKIKC, TModern DJLECGLCJOD) where TModern : struct, BNCNHCPLOHA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7F76A30", Offset = "0x7F75830", VA = "0x187F76A30")]
	internal static List<NOFBPEFCPEN> HLPIPEDHKBE(IEnumerable<AEPJLFLKICD>? IOCJFDLGEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3B66410", Offset = "0x3B65210", VA = "0x183B66410")]
	internal static string PNOIPLBCNPC<TModern>(TModern PADDIEKMDDH, EOHMEIJACBP<TModern> BDEEAMAAGED, NEFGBBBPMJE LFAMJEMPOAL) where TModern : BNCNHCPLOHA
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class PENHNPGFJNN : OHLNENJBNKM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NPICHFKMMPG<LMJHLONIKBE, MAMJKFCNJKC> DKBCFICFLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NPICHFKMMPG<LFOGLJADGMO, OPAAGPPHAEP> DDADGJBGNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public NPICHFKMMPG<LFOGLJADGMO, OPAAGPPHAEP> JBEOHMNOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EHJNABBFEBL LKHGEJJFPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IENAMFMLAKI HPIMNHDPGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AF00", Offset = "0x7F79D00", VA = "0x187F7AF00")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	[UsedImplicitly]
	internal static void NEBFFACFKHB(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AF70", Offset = "0x7F79D70", VA = "0x187F7AF70")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PENHNPGFJNN([OLOAAHJODHH("UnitySerialization")] NLJDKLNDHOC JGDLFPKPDAL, [OLOAAHJODHH(null)] PLELJALJHKF NNCGOBAAJDN, [OLOAAHJODHH(null)] NEFGBBBPMJE LFAMJEMPOAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum IEHNHOMFPDG
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
public class KCCBNOOFAPH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7F783E0", Offset = "0x7F771E0", VA = "0x187F783E0")]
	public KCCBNOOFAPH(string IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7F78380", Offset = "0x7F77180", VA = "0x187F78380")]
	public KCCBNOOFAPH(string IIHOFBLPONF, Exception CEFEOBEJCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F783B0", Offset = "0x7F771B0", VA = "0x187F783B0")]
	public KCCBNOOFAPH(IEHNHOMFPDG PBBMMPMCJKL, string IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7F78410", Offset = "0x7F77210", VA = "0x187F78410")]
	public KCCBNOOFAPH(IEHNHOMFPDG PBBMMPMCJKL, string IIHOFBLPONF, Exception CEFEOBEJCIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class EHINDLKMDEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly NLJDKLNDHOC JGDLFPKPDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly PLELJALJHKF NNCGOBAAJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly NEFGBBBPMJE LFAMJEMPOAL;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F764A0", Offset = "0x7F752A0", VA = "0x187F764A0")]
	protected EHINDLKMDEN(NLJDKLNDHOC JGDLFPKPDAL, PLELJALJHKF NNCGOBAAJDN, NEFGBBBPMJE LFAMJEMPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7F751A0", Offset = "0x7F73FA0", VA = "0x187F751A0")]
	protected string MKAPHPKOOLC(MAMJKFCNJKC HPAFAKCFFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F74FB0", Offset = "0x7F73DB0", VA = "0x187F74FB0")]
	protected string MFILLPCDGJM(MAMJKFCNJKC HPAFAKCFFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F74C80", Offset = "0x7F73A80", VA = "0x187F74C80")]
	private AvatarOutfitSelectionData FOIOCFHPLHH(NHAPPPHCCCK ALOLIAIBPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7F74B40", Offset = "0x7F73940", VA = "0x187F74B40")]
	private static AvatarCustomizationSettingsData.AnchorParams EBPAKEOBJLC(BHJLPMKOMMK? DCDDJLKPLJE)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NPICHFKMMPG<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput KIDJPDKJMHF(TInput PADDIEKMDDH, [Out] IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IGGCMLBAHGK(TInput PADDIEKMDDH, [Out] TOutput? OHLBIIOAJDL, [Out] IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface OHLNENJBNKM
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NPICHFKMMPG<LMJHLONIKBE, MAMJKFCNJKC> DKBCFICFLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	NPICHFKMMPG<LFOGLJADGMO, OPAAGPPHAEP> JBEOHMNOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	EHJNABBFEBL LKHGEJJFPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum JMMOKMHALHB
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IENAMFMLAKI
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DOLEDBPJJIA NEJFHFKCOKJ(MAMJKFCNJKC BOIPFNOKGBJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EHJNABBFEBL
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFOGLJADGMO NEJFHFKCOKJ(MAMJKFCNJKC BOIPFNOKGBJ, int MGGAEMKOADB, string? GGDFKFACHGG, string? CPPBIPFENNP, NGHFCMNNGJM KNADKFHEGDI, List<NOFBPEFCPEN>? EPCMJFMMJNB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[HCBEFNLCJPF]
internal class JILPNKHMHNO : LEHKLKCHJHO<LMJHLONIKBE, MAMJKFCNJKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly PLELJALJHKF NNCGOBAAJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly APLBHJIKGAN ILAFINIMMHA;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7F781B0", Offset = "0x7F76FB0", VA = "0x187F781B0")]
	public JILPNKHMHNO(NLJDKLNDHOC JGDLFPKPDAL, PLELJALJHKF NNCGOBAAJDN, NEFGBBBPMJE LFAMJEMPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7F77F00", Offset = "0x7F76D00", VA = "0x187F77F00", Slot = "6")]
	public override MAMJKFCNJKC KIDJPDKJMHF(LMJHLONIKBE PADDIEKMDDH, [Out] IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class APCEKCHCOPM : NLJDKLNDHOC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class EOGLMEBPAFG : JsonConverter<DOCKCEIEPPD>
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7F76740", Offset = "0x7F75540", VA = "0x187F76740", Slot = "9")]
		public override void WriteJson(JsonWriter JAIJDFCBLCH, DOCKCEIEPPD? BNECONOIKOE, JsonSerializer MHJAFOGOHPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7F76620", Offset = "0x7F75420", VA = "0x187F76620", Slot = "10")]
		public override DOCKCEIEPPD ReadJson(JsonReader DGMHJDFFMEI, Type BMPFINLAMLL, DOCKCEIEPPD? EBJHMLHNIIK, bool KJOLIGCEDKO, JsonSerializer MHJAFOGOHPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7F767E0", Offset = "0x7F755E0", VA = "0x187F767E0")]
		public EOGLMEBPAFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class FLBNDFNBNGI : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool HOBDHNJAEPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7F77160", Offset = "0x7F75F60", VA = "0x187F77160", Slot = "5")]
		public override object ReadJson(JsonReader DGMHJDFFMEI, Type BMPFINLAMLL, object? EBJHMLHNIIK, JsonSerializer MHJAFOGOHPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7F76F80", Offset = "0x7F75D80", VA = "0x187F76F80", Slot = "6")]
		public override bool CanConvert(Type BMPFINLAMLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7F771C0", Offset = "0x7F75FC0", VA = "0x187F771C0", Slot = "4")]
		public override void WriteJson(JsonWriter JAIJDFCBLCH, object? BNECONOIKOE, JsonSerializer MHJAFOGOHPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7F76D80", Offset = "0x7F75B80", VA = "0x187F76D80")]
		private static bool AGDDHAPLHMH(object BNECONOIKOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public FLBNDFNBNGI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JsonSerializerSettings LIKCCDGEANE;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7F70DD0", Offset = "0x7F6FBD0", VA = "0x187F70DD0")]
	internal APCEKCHCOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3122640", Offset = "0x3121440", VA = "0x183122640", Slot = "4")]
	public string LHJFPPKHBAN<T>(T MKPNGAKJFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x31226A0", Offset = "0x31214A0", VA = "0x1831226A0", Slot = "5")]
	public T PDAFEHCFJOC<T>(string BNECONOIKOE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class JJKBFCPOBJH : NLJDKLNDHOC
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE1A0", Offset = "0x3BECFA0", VA = "0x183BEE1A0", Slot = "4")]
	public string LHJFPPKHBAN<T>(T MKPNGAKJFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE200", Offset = "0x3BED000", VA = "0x183BEE200", Slot = "5")]
	public T PDAFEHCFJOC<T>(string BNECONOIKOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public JJKBFCPOBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HCBEFNLCJPF]
internal class APLBHJIKGAN : LEHKLKCHJHO<LFOGLJADGMO, OPAAGPPHAEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly NLJDKLNDHOC JGDLFPKPDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly PLELJALJHKF NNCGOBAAJDN;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F733A0", Offset = "0x7F721A0", VA = "0x187F733A0")]
	public APLBHJIKGAN(NLJDKLNDHOC JGDLFPKPDAL, PLELJALJHKF NNCGOBAAJDN, NEFGBBBPMJE LFAMJEMPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7F71E20", Offset = "0x7F70C20", VA = "0x187F71E20", Slot = "6")]
	public override OPAAGPPHAEP KIDJPDKJMHF(LFOGLJADGMO PADDIEKMDDH, [Out] IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7F712E0", Offset = "0x7F700E0", VA = "0x187F712E0")]
	internal void DOOEDDKOGHP(string GLMEBJOKCGP, MAMJKFCNJKC HPAFAKCFFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7F70F30", Offset = "0x7F6FD30", VA = "0x187F70F30")]
	public IEnumerable<NHAPPPHCCCK> CLAEPIKDADL(string HAMNAKJIKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7F71430", Offset = "0x7F70230", VA = "0x187F71430")]
	private IEnumerable<NHAPPPHCCCK> EABHCBGMHMH(string HAMNAKJIKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7F719B0", Offset = "0x7F707B0", VA = "0x187F719B0")]
	internal IEnumerable<NHAPPPHCCCK> JGPDEDKOGAO(string HAMNAKJIKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7F72450", Offset = "0x7F71250", VA = "0x187F72450")]
	private NHAPPPHCCCK MIDLMECLNHC(AvatarOutfitSelectionData PLCMBEIIGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7F72B00", Offset = "0x7F71900", VA = "0x187F72B00")]
	private void NKKILDPIFGF(AvatarCustomizationSettingsData FDLKDLNIPLJ, MAMJKFCNJKC HPAFAKCFFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7F727E0", Offset = "0x7F715E0", VA = "0x187F727E0")]
	private NHAPPPHCCCK MIDLMECLNHC(string EPKGJGNJAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7F70FE0", Offset = "0x7F6FDE0", VA = "0x187F70FE0")]
	internal static (EEPOCEICAIB, string, string) CPAJGFJMNKD(string EPKGJGNJAHH, NEFGBBBPMJE LFAMJEMPOAL)
	{
		return default((EEPOCEICAIB, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7F72250", Offset = "0x7F71050", VA = "0x187F72250")]
	private OCJBFIOACAA? MGCJKJIBDAM(string? OKDHAOKOGCM, Vector2 MIFPACKEOBL, float HDFJJEDGFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7F71850", Offset = "0x7F70650", VA = "0x187F71850")]
	private static BHJLPMKOMMK GBHAEFHCDGN(AvatarCustomizationSettingsData.AnchorParams LIKMOFHHMMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HCBEFNLCJPF]
internal class MDLCFLMHAKN : EHINDLKMDEN, IENAMFMLAKI
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7F764A0", Offset = "0x7F752A0", VA = "0x187F764A0")]
	public MDLCFLMHAKN(NLJDKLNDHOC JGDLFPKPDAL, PLELJALJHKF NNCGOBAAJDN, NEFGBBBPMJE LFAMJEMPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7F792E0", Offset = "0x7F780E0", VA = "0x187F792E0", Slot = "4")]
	public DOLEDBPJJIA NEJFHFKCOKJ(MAMJKFCNJKC BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7F791E0", Offset = "0x7F77FE0", VA = "0x187F791E0")]
	private string HICGHNENFFL(MAMJKFCNJKC HPAFAKCFFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7F78FA0", Offset = "0x7F77DA0", VA = "0x187F78FA0")]
	private string FDCEMKDCJKA(NHAPPPHCCCK ALOLIAIBPPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[HCBEFNLCJPF]
internal class COAEADGOBJP : LEHKLKCHJHO<LFOGLJADGMO, OPAAGPPHAEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly NLJDKLNDHOC JGDLFPKPDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly NPICHFKMMPG<LFOGLJADGMO, OPAAGPPHAEP> GMKNLDMLOEB;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7F74A40", Offset = "0x7F73840", VA = "0x187F74A40")]
	public COAEADGOBJP(NPICHFKMMPG<LFOGLJADGMO, OPAAGPPHAEP> GMKNLDMLOEB, NEFGBBBPMJE LFAMJEMPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7F74610", Offset = "0x7F73410", VA = "0x187F74610", Slot = "6")]
	public override OPAAGPPHAEP KIDJPDKJMHF(LFOGLJADGMO PADDIEKMDDH, [Out] IReadOnlyList<NOFBPEFCPEN>? EPCMJFMMJNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[HCBEFNLCJPF]
internal class MBCCMOCMJFN : EHJNABBFEBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly NLJDKLNDHOC JGDLFPKPDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly IENAMFMLAKI JPHABAMOJIA;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7F78EB0", Offset = "0x7F77CB0", VA = "0x187F78EB0")]
	public MBCCMOCMJFN(IENAMFMLAKI JPHABAMOJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7F78B00", Offset = "0x7F77900", VA = "0x187F78B00", Slot = "4")]
	public LFOGLJADGMO NEJFHFKCOKJ(MAMJKFCNJKC BOIPFNOKGBJ, int MGGAEMKOADB, string? GGDFKFACHGG, string? CPPBIPFENNP, NGHFCMNNGJM KNADKFHEGDI, List<NOFBPEFCPEN>? EPCMJFMMJNB)
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
		[Cpp2IlInjected.Address(RVA = "0x7F73590", Offset = "0x7F72390", VA = "0x187F73590")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HKNNDCKJFPC
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7F77300", Offset = "0x7F76100", VA = "0x187F77300")]
	public static EMIPHPEOPMO KIDJPDKJMHF(this FMLMDMMCDPG BOIPFNOKGBJ)
	{
		return default(EMIPHPEOPMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7F77410", Offset = "0x7F76210", VA = "0x187F77410")]
	public static FMLMDMMCDPG NEJFHFKCOKJ(this EMIPHPEOPMO EFOJPDNHNAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7F772A0", Offset = "0x7F760A0", VA = "0x187F772A0")]
	public static bool ICDJELCICOH(this EMIPHPEOPMO EFOJPDNHNAD)
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
			[Cpp2IlInjected.Address(RVA = "0x5FD9CD0", Offset = "0x5FD8AD0", VA = "0x185FD9CD0")]
			public AnchorParams(Vector2 JCMIDJDOHLA, Vector3 BOOIPDLBAFC, Vector3 NAMBHOOINPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7F734E0", Offset = "0x7F722E0", VA = "0x187F734E0")]
			internal BHJLPMKOMMK NEJFHFKCOKJ()
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
		private GFLNPIGKFCH useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x7F73DC0", Offset = "0x7F72BC0", VA = "0x187F73DC0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x17DC670", Offset = "0x17DB470", VA = "0x1817DC670")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xDD1BC0", Offset = "0xDD09C0", VA = "0x180DD1BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xFA7260", Offset = "0xFA6060", VA = "0x180FA7260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x14F3320", Offset = "0x14F2120", VA = "0x1814F3320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7F73E70", Offset = "0x7F72C70", VA = "0x187F73E70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF90", Offset = "0xA5AD90", VA = "0x180A5BF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD06540", Offset = "0xD05340", VA = "0x180D06540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD06550", Offset = "0xD05350", VA = "0x180D06550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA60470", Offset = "0xA5F270", VA = "0x180A60470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7F73EB0", Offset = "0x7F72CB0", VA = "0x187F73EB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xF569A0", Offset = "0xF557A0", VA = "0x180F569A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x11F3CB0", Offset = "0x11F2AB0", VA = "0x1811F3CB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x197E360", Offset = "0x197D160", VA = "0x18197E360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA5F380", Offset = "0xA5E180", VA = "0x180A5F380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA5F350", Offset = "0xA5E150", VA = "0x180A5F350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x24FAF90", Offset = "0x24F9D90", VA = "0x1824FAF90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xF7F2D0", Offset = "0xF7E0D0", VA = "0x180F7F2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA8F950", Offset = "0xA8E750", VA = "0x180A8F950")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA8F9B0", Offset = "0xA8E7B0", VA = "0x180A8F9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA667D0", Offset = "0xA655D0", VA = "0x180A667D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA66740", Offset = "0xA65540", VA = "0x180A66740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA66720", Offset = "0xA65520", VA = "0x180A66720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA66710", Offset = "0xA65510", VA = "0x180A66710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA66730", Offset = "0xA65530", VA = "0x180A66730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA66690", Offset = "0xA65490", VA = "0x180A66690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xABBEB0", Offset = "0xABACB0", VA = "0x180ABBEB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xAB9B50", Offset = "0xAB8950", VA = "0x180AB9B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA66680", Offset = "0xA65480", VA = "0x180A66680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA667E0", Offset = "0xA655E0", VA = "0x180A667E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xABC2D0", Offset = "0xABB0D0", VA = "0x180ABC2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB0E290", Offset = "0xB0D090", VA = "0x180B0E290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA65C30", Offset = "0xA64A30", VA = "0x180A65C30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA65C10", Offset = "0xA64A10", VA = "0x180A65C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB0E4E0", Offset = "0xB0D2E0", VA = "0x180B0E4E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB0E440", Offset = "0xB0D240", VA = "0x180B0E440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xDB2810", Offset = "0xDB1610", VA = "0x180DB2810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xDAFF10", Offset = "0xDAED10", VA = "0x180DAFF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GFLNPIGKFCH UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1026660", Offset = "0x1025460", VA = "0x181026660")]
			get
			{
				return default(GFLNPIGKFCH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1027300", Offset = "0x1026100", VA = "0x181027300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1027E10", Offset = "0x1026C10", VA = "0x181027E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xCE1310", Offset = "0xCE0110", VA = "0x180CE1310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F73E90", Offset = "0x7F72C90", VA = "0x187F73E90")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x7F73ED0", Offset = "0x7F72CD0", VA = "0x187F73ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F73A20", Offset = "0x7F72820", VA = "0x187F73A20")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		public EEPOCEICAIB BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private HLNBCOGMHLF? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7F73EF0", Offset = "0x7F72CF0", VA = "0x187F73EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
