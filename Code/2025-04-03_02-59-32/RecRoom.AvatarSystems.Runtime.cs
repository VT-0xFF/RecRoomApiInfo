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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x7743490", Offset = "0x7742890", VA = "0x187743490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7743510", Offset = "0x7742910", VA = "0x187743510", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CBAKGNGODOD]
internal class IAIFNNCNKCJ : FKEIIBMPICN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GNMOAEOFCBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public IAIFNNCNKCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public GEHKDDKOMID avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OHCDBGKPMDE PHNMEFNEKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OFDFNMGNHCI IMKMOBALPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LIJOGIGJHBL FOCEHAPAJKO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7742770", Offset = "0x7741B70", VA = "0x187742770")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	[UsedImplicitly]
	internal static void LCLELILMCHI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7743310", Offset = "0x7742710", VA = "0x187743310")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IAIFNNCNKCJ([CMKKAFOAFJE(null)] OHCDBGKPMDE PHNMEFNEKGC, [CMKKAFOAFJE(null)] OFDFNMGNHCI IMKMOBALPLA, [CMKKAFOAFJE(null)] LIJOGIGJHBL FOCEHAPAJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7742A50", Offset = "0x7741E50", VA = "0x187742A50", Slot = "5")]
	public FKAIDAOIGIH OBHDMGFJBFA(GEHKDDKOMID IOAAKAMPEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77418E0", Offset = "0x7740CE0", VA = "0x1877418E0", Slot = "4")]
	public FKAIDAOIGIH COKPGEJLEMJ(GEHKDDKOMID IOAAKAMPEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77424B0", Offset = "0x77418B0", VA = "0x1877424B0", Slot = "6")]
	public CNAEMFJKIGO HHOAHHBMLOA(FKAIDAOIGIH HPMNBNLACCC, int KAJDCINBCAB, string? IGEPDAOOLBO, string? PPLFMLCMNCJ, LFNHDMIHLED NPGFKMBHNMB, List<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x77427E0", Offset = "0x7741BE0", VA = "0x1877427E0", Slot = "7")]
	public bool LEDPPMAHDJL(OPKBFEBFLKC MOLMNIDNABI, [Out] FKAIDAOIGIH? IGGKLFCOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77423D0", Offset = "0x77417D0", VA = "0x1877423D0", Slot = "8")]
	public bool EKKFAJIFIBK(CNAEMFJKIGO HNNKCDGDBAL, [Out] FKAIDAOIGIH? IGGKLFCOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7741850", Offset = "0x7740C50", VA = "0x187741850", Slot = "9")]
	public bool ANCDIOMNOGJ(CNAEMFJKIGO HNNKCDGDBAL, [Out] BIAHFMGAOCL? MOLMNIDNABI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3608CF0", Offset = "0x36080F0", VA = "0x183608CF0")]
	private bool OLICLMFNHDN<TInput, TOutput>(TInput PJCOHHCODGF, LMBLCGDOFNF<TInput, TOutput> HEHLCOLGLJE, [Out] TOutput? HBALBIOOGIJ) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77425C0", Offset = "0x77419C0", VA = "0x1877425C0")]
	[CompilerGenerated]
	private ICDNLIPEIMO KJEFGNGPFFH(FaceFeatureType MODHLEEDKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7742870", Offset = "0x7741C70", VA = "0x187742870")]
	[CompilerGenerated]
	private ICDNLIPEIMO NFBHOONNAOF(FaceFeatureType MODHLEEDKMM, GNMOAEOFCBJ P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CBAKGNGODOD]
internal class CBENMANPIDI : OHCDBGKPMDE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void EOEAFCIPKMM<in TData>(TData IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GFLPJKHCIOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public BJLOHGAHOCA rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JLBLAHIIBKF currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JLBLAHIIBKF latestAvatarVersion;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GFLPJKHCIOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7741810", Offset = "0x7740C10", VA = "0x187741810")]
		internal bool JLEOOENCKIN(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7741830", Offset = "0x7740C30", VA = "0x187741830")]
		internal bool MBMCCBDDELG(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LIJOGIGJHBL FOCEHAPAJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ENCEHJNHPBL HKNGEHEEHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EOEAFCIPKMM<FKAIDAOIGIH>?[] PHNMEFNEKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly EOEAFCIPKMM<BIAHFMGAOCL>?[] JBNCAKKCHDC;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77409F0", Offset = "0x773FDF0", VA = "0x1877409F0")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	[UsedImplicitly]
	internal static void LCLELILMCHI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7741230", Offset = "0x7740630", VA = "0x187741230")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CBENMANPIDI([CMKKAFOAFJE(null)] LIJOGIGJHBL FOCEHAPAJKO, [CMKKAFOAFJE(null)] ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7740E50", Offset = "0x7740250", VA = "0x187740E50", Slot = "4")]
	public bool NPDGNNFBAFO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7740CF0", Offset = "0x77400F0", VA = "0x187740CF0", Slot = "5")]
	public bool NPDGNNFBAFO(BIAHFMGAOCL MOLMNIDNABI, IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x773FDD0", Offset = "0x773F1D0", VA = "0x18773FDD0")]
	private void IGMDOODJJJB(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7740F50", Offset = "0x7740350", VA = "0x187740F50")]
	private void NPMALOBABCO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77409C0", Offset = "0x773FDC0", VA = "0x1877409C0")]
	private void LBCICIBDKML(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7740CC0", Offset = "0x77400C0", VA = "0x187740CC0")]
	private void MNBJDMNFNIO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x773F700", Offset = "0x773EB00", VA = "0x18773F700")]
	private void BCONGBPAADH(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7740C10", Offset = "0x7740010", VA = "0x187740C10")]
	private void MHFDKCMICOA(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7741180", Offset = "0x7740580", VA = "0x187741180")]
	private void OPJJADOEKOL(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x773F6F0", Offset = "0x773EAF0", VA = "0x18773F6F0")]
	private void AHHBIMMKJEO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x773FAF0", Offset = "0x773EEF0", VA = "0x18773FAF0")]
	private void GNGBNADIINM(FKAIDAOIGIH IGGKLFCOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x773F7D0", Offset = "0x773EBD0", VA = "0x18773F7D0")]
	private FKAIDAOIGIH EBBCIFGBDGJ(FKAIDAOIGIH IGGKLFCOGPM, List<RangeMigration> ECDENHJAIGP, JLBLAHIIBKF ENNGOFOCADI, JLBLAHIIBKF NHHNCOGCFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x773FAB0", Offset = "0x773EEB0", VA = "0x18773FAB0")]
	private float FPBJEHPOMGD(float IPDNENCBJGL, Vector2 DCDLPFBPBMI, Vector2 ODDGCFPFIKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7740A60", Offset = "0x773FE60", VA = "0x187740A60")]
	private (RangeMigration?, RangeMigration?) LKEFDNDLAFJ(List<RangeMigration> NNFIKKJIGAL, BJLOHGAHOCA DLDGEABKFCD, JLBLAHIIBKF ENNGOFOCADI, JLBLAHIIBKF NHHNCOGCFAH)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OHCDBGKPMDE
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPDGNNFBAFO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPDGNNFBAFO(BIAHFMGAOCL MOLMNIDNABI, IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO);
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AnimationPoseSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Tooltip("Type of pose")]
		public ILNDAIKDAIH AnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Tooltip("Blend in time")]
		public float BlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Tooltip("How much of the head movement is applied to the hand movement")]
		public float HeadMovementWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("Weight between IK hand and Animated hand for position")]
		public float HandAnimationPosWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("Weight between IK hand and Animated hand for rotation")]
		public float HandAnimationRotWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Tooltip("Weight between shoulders facing forward and alignment with hands")]
		public float ShoulderFollowWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Tooltip("How much the aim follows direction of feet vs head (0 = head, 1 = feet)")]
		public float FeetFollowWeight;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x773D280", Offset = "0x773C680", VA = "0x18773D280")]
		public void FFEFLKAFCLH(AnimationPoseSetting KNCKFHOKGJM, float OHDKEIGOGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x773D3B0", Offset = "0x773C7B0", VA = "0x18773D3B0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x773DCC0", Offset = "0x773D0C0", VA = "0x18773DCC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x773DC80", Offset = "0x773D080", VA = "0x18773DC80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x773D3D0", Offset = "0x773C7D0", VA = "0x18773D3D0")]
		private void OBFEEOBGEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x76B2AB0", Offset = "0x76B1EB0", VA = "0x1876B2AB0", Slot = "4")]
		public void SetEnabled(bool CGAPLHFOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x773DCF0", Offset = "0x773D0F0", VA = "0x18773DCF0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x773DD30", Offset = "0x773D130", VA = "0x18773DD30")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E1")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Seated animation settings")]
		[Tooltip("How much to twist shoulders when seated.")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x464")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A4")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4AC")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Local offset from pelvis to foot center")]
		[Header("Shoe Settings")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4CC")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D4")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x773DDB0", Offset = "0x773D1B0", VA = "0x18773DDB0")]
		public AnimationPoseSetting KFIHDKBDBDJ(ILNDAIKDAIH PCCNNFIJGNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x773DD70", Offset = "0x773D170", VA = "0x18773DD70")]
		public void BECHPFCMIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x773DDE0", Offset = "0x773D1E0", VA = "0x18773DDE0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum CMGDAALKGLA
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private CMGDAALKGLA handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x773E8B0", Offset = "0x773DCB0", VA = "0x18773E8B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x773E870", Offset = "0x773DC70", VA = "0x18773E870")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x773E250", Offset = "0x773D650", VA = "0x18773E250")]
		private void OBFEEOBGEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76B2AB0", Offset = "0x76B1EB0", VA = "0x1876B2AB0", Slot = "4")]
		public void SetEnabled(bool CGAPLHFOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x773E8E0", Offset = "0x773DCE0", VA = "0x18773E8E0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, NGFEFCOKFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		[Header("Configuration")]
		private GEHKDDKOMID avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[HCOGNCHHAAD(GKKLJNPNNON.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[FormerlySerializedAs("HeadTweakBone")]
		[SerializeField]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private OHGFGGMFLAM EMLNHOBFFCL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public OHGFGGMFLAM LBMGMJIBGJA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA1A4A0", Offset = "0xA198A0", VA = "0x180A1A4A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform DEBDOHLKJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x773F6D0", Offset = "0x773EAD0", VA = "0x18773F6D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x773E910", Offset = "0x773DD10", VA = "0x18773E910")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x773F590", Offset = "0x773E990", VA = "0x18773F590")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x773F540", Offset = "0x773E940", VA = "0x18773F540")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x773F4D0", Offset = "0x773E8D0", VA = "0x18773F4D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x773E910", Offset = "0x773DD10", VA = "0x18773E910", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x773ECA0", Offset = "0x773E0A0", VA = "0x18773ECA0", Slot = "6")]
		public OHGFGGMFLAM CreateAvatarSystem(string OFHHLDJLPDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x773F4D0", Offset = "0x773E8D0", VA = "0x18773F4D0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x773E9D0", Offset = "0x773DDD0", VA = "0x18773E9D0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x773F5E0", Offset = "0x773E9E0", VA = "0x18773F5E0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float JNFHMFBFJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class AGKBBPGDILM : OHGFGGMFLAM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class LHMKMCFEGNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Vector3 AABGKAKEAIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Quaternion FDEPCFHCFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Vector3 COKKIKCABED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Transform NAJFMPHNAJD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 MFALEFHDHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1DB4290", Offset = "0x1DB3690", VA = "0x181DB4290")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1DB42B0", Offset = "0x1DB36B0", VA = "0x181DB42B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion FGOBMENEKND
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x124D9C0", Offset = "0x124CDC0", VA = "0x18124D9C0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x124D680", Offset = "0x124CA80", VA = "0x18124D680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float AHAMCJICHKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xFB4520", Offset = "0xFB3920", VA = "0x180FB4520")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x15FB250", Offset = "0x15FA650", VA = "0x1815FB250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool JABGIECJHJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x994380", Offset = "0x993780", VA = "0x180994380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9944F0", Offset = "0x9938F0", VA = "0x1809944F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool MIMKHALFMJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x994350", Offset = "0x993750", VA = "0x180994350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x994390", Offset = "0x993790", VA = "0x180994390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool BGMIPJMNDPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x994520", Offset = "0x993920", VA = "0x180994520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x994600", Offset = "0x993A00", VA = "0x180994600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EKCIGFMALPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xBE35E0", Offset = "0xBE29E0", VA = "0x180BE35E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xBE45B0", Offset = "0xBE39B0", VA = "0x180BE45B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x774AF80", Offset = "0x774A380", VA = "0x18774AF80")]
		public void BOAKHMFLLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x774B1A0", Offset = "0x774A5A0", VA = "0x18774B1A0")]
		public void DJODKKEGBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x774AF90", Offset = "0x774A390", VA = "0x18774AF90")]
		public float CCOPLPBPKGE(Vector3 BNOPMBDJJMI, Quaternion MJBNOOFMMKI, [In] AvatarFootSettings EIELDECCFNM, float HAFADEOKAFJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x774B420", Offset = "0x774A820", VA = "0x18774B420")]
		public void OMKDHELPGNO(Vector3 PLKKJHFPAME, Quaternion CCCINBKEDFA, Transform HDNHKPGGPLN, float PFBBLPGGPPJ, bool GCHGOFCJOLK, bool FHOMHHIIPIG, float BAIMJCJACOM, float NACECBLGLON, Transform BKHMOJGGBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x774AD50", Offset = "0x774A150", VA = "0x18774AD50")]
		public void AACEHMEKDIN(Transform PBPFBBCFKNN, Transform BKHMOJGGBFN, bool MCKLFPAKNNG, bool BEPICDCJHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x774B320", Offset = "0x774A720", VA = "0x18774B320")]
		private void OGNBBJJCCIM(Transform BKHMOJGGBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x774B1D0", Offset = "0x774A5D0", VA = "0x18774B1D0")]
		public void LLHJJDAIKMD(Transform BKHMOJGGBFN, AvatarFullBodyConfiguration HNFCGGMPMHM, Vector3 KNFCDDMNGLJ, float LGEGDFIKLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x774B1B0", Offset = "0x774A5B0", VA = "0x18774B1B0")]
		public void IGBIGHIEBEM(float NACECBLGLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x774BB00", Offset = "0x774AF00", VA = "0x18774BB00")]
		public LHMKMCFEGNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class JMGGMLJOGKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private float KAEEDFOIMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private bool DNNHJFLKKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AnimationPoseSetting PHAELKDPGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private float IDMEENKCGCE;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x77487A0", Offset = "0x7747BA0", VA = "0x1877487A0")]
		public void AJNGODCFNAB(IKSolverVR.Arm LCMHDAFJMNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7749260", Offset = "0x7748660", VA = "0x187749260")]
		public void JEMEKPHJDBH(IKSolverVR.Arm LCMHDAFJMNP, float BLFJEGJJBFG, bool DNNHJFLKKEA, AvatarFullBodyConfiguration HNFCGGMPMHM, float ENOGEACDIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7749C80", Offset = "0x7749080", VA = "0x187749C80")]
		private void NPBGBIBALDH(IKSolverVR.Arm LCMHDAFJMNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x77498A0", Offset = "0x7748CA0", VA = "0x1877498A0")]
		public void NJBIHEJHFMO(IKSolverVR.Arm LCMHDAFJMNP, Transform NAGDLAMLEKO, Transform HDNHKPGGPLN, Quaternion MHEEGCAGLHM, Vector3 DFCPGNEFHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7748DD0", Offset = "0x77481D0", VA = "0x187748DD0")]
		private (Vector3, Quaternion) ECDIKLKBLCN(KBBMLEHBPBD DNAJMFFBCPA, Quaternion BNMINADHENM, Vector3 JPLFJFKFPLH)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7748C70", Offset = "0x7748070", VA = "0x187748C70")]
		public void BJLJDKCGGPK(KBBMLEHBPBD DNAJMFFBCPA, IKSolverVR.Arm LCMHDAFJMNP, Quaternion BNMINADHENM, Vector3 JPLFJFKFPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x77492A0", Offset = "0x77486A0", VA = "0x1877492A0")]
		public void MBFBJAKMNNB(KBBMLEHBPBD DNAJMFFBCPA, IKSolverVR.Arm LCMHDAFJMNP, Quaternion BNMINADHENM, Vector3 JPLFJFKFPLH, [In] AvatarFullBodyConfiguration HNFCGGMPMHM, [In] KPDOMOAMKCP DHJOIBPBMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7749CC0", Offset = "0x77490C0", VA = "0x187749CC0")]
		public void OMEMHIBGANE(ILNDAIKDAIH OKMFMOLKNNG, AvatarFullBodyConfiguration HNFCGGMPMHM, KPDOMOAMKCP DHJOIBPBMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x77487D0", Offset = "0x7747BD0", VA = "0x1877487D0")]
		public void AKEGKBODIMJ(IKSolverVR.Arm LCMHDAFJMNP, Transform NAGDLAMLEKO, Vector3 HHLCPCGANOB, float OIFDCGLGBEM, Quaternion JOHIIPFHDMH, Vector3 KNJNGDHOBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7749E00", Offset = "0x7749200", VA = "0x187749E00")]
		public JMGGMLJOGKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum OKCPPNLOCMD
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct EPPKEMKNFDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct KFAODICGGAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int CCDHAODOELP;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int EGDBLKJKMMK;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int JBEMAHPDNEA;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int KJGGDAKNFNM;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int IDOOJKAMIIO;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int MEMEJHDMOKG;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int APKODPPBGEA;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int IOACENCHPJB;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int COLKAJDFMAN;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int JBFCMFCPGJL;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int GJJNPKPBECG;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int FNFOPJGCPEM;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int EBGGCKNGJDA;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int NCJLCHPNFMG;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int MKBHFLIPJKG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int CJNLCJLBPGC;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int CHGFMHJFMFE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int LKGNFHILOLH;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int BGIIHEPMKLM;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int LIDCMKPKDDA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int MCPDKMIDBEK;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int HJEGCNMOOOO;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int BHHPIEKLOEI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int JLNHFLLOHDH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int FNOABOIFJPM;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int AEBHIOCAGNO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int HKPDHJMLBMC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int PFAPKPAPJGM;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int OLNDAPGALDM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int OOIHBFBPOCD;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int APFEMCCDLOB;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly Vector3 LCLINFPNFFF;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int AOJJLAAOOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool BHEGHMGFLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool KNKCHIAIIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool DLKJCBPALEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool DCLFFDOHCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool ALBBNDBAAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool LOMGAIJMJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Vector3 ENBBPDLFLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private string BCHCPNGPGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NKOKBOFABJF? FAPMBJIHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private DFOFNIFAMPI? AFAFFDBBLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private FGEPGNFMAOA MDCIBHGGNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private FMDNJMEBKIG MFGFECCKJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private KBBMLEHBPBD HPBIPHPIKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private KBBMLEHBPBD PMJLLMBGDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool MKJLIDLFPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool ICJLIMKIJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly FEOGLIOOBAH MGDPPHNBKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly DKNEGCKDEDB CGBDEFIALMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int MENKNLAEDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float PBPGJFCADMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GameObject KOIKLLLEMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform DALLBFMJEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform IDOPOAHLEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform FDCCJIKCDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform PBDFLBGAIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private float IELILAKDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float BBEOIEKOINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Vector3 OIOIIAEHNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Quaternion OGLJGKPFJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform AHBCBLAENNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform NMCNCMNPDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform EPENJJKCPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NCEMHJIBLAC MKLJDFHONFD;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker MNDMLGNJMGJ;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker EECEKAAIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private ProfilerMarker AKGFMKMHJPP;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker KGCJHJLGKDL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker BHIOCOPGMEL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker NGJEPCLBEPB;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly List<AGKBBPGDILM> CDANCPJCBLH;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int NPJIFJJJKBP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> BIJFLNFPOPB;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int IBOLMDGALLC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int KGPHAILPGGO;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int OGGKEGLEMCL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int ABOCLIMKPJO;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float JMENIPONCDN;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static int LEIEIAHEKBP;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float OFHOCPDDFAF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float OOEJHMBNDFH;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float BHDFNFMNJLI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float CCHIKLKOODE;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static IHKAOAADKDE EILJHKPJNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private float LEHDPCOBBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private bool HIDFNPEEIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float OBMOLBCKMIK;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly int LDDOLDBHEOD;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int IIFOKCONPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private LHMKMCFEGNN CCFPKHFJJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private LHMKMCFEGNN KFPAAKIKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private float HFKCLPILIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private Vector3 IDOPGBMCDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Vector3 DKBJNAPEOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool HFCLALBNCJN;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Quaternion FJBHOEMINMJ;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion CGBDBOCNKEM;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Vector3 JGFJAHOIHGJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 DBGAEJOLFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float FPIPPCPPMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float PCPEHPMDLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private JMGGMLJOGKL MIHDOKIGCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JMGGMLJOGKL GNFDGGNDIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private AHMAPHCLJAE DLFIBOGNLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private KKOLHKMJCKF CNNIAGEGNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly FBAHEBPPBJN HEPEPNIIENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float OLIEOBOGLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float JHNJIGEIKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly KKOLHKMJCKF BPLLEKLPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Vector3 PKCDOOECDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 KGNKNGEOPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float LBDLKBAINBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float KCBHKGLKEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly KKOLHKMJCKF DGBDCOEPDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly AHMAPHCLJAE CKFEEIMEKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly KKOLHKMJCKF AHCNBHNJLNM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OPNNLJDPBAB IICGPFNOHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OPNNLJDPBAB FMAJALMIMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration CAAEHJNMLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x772C3F0", Offset = "0x772B7F0", VA = "0x18772C3F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GEHKDDKOMID HDDJMHIPOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x772E560", Offset = "0x772D960", VA = "0x18772E560", Slot = "23")]
		get
		{
			return default(GEHKDDKOMID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration DGIFMCBMNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7729BA0", Offset = "0x7728FA0", VA = "0x187729BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform LCLJFALEIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7738970", Offset = "0x7737D70", VA = "0x187738970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform MOCPOEICMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7739800", Offset = "0x7738C00", VA = "0x187739800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer EEOJPPIMCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7729760", Offset = "0x7728B60", VA = "0x187729760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] OKBHPPCIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x77290B0", Offset = "0x77284B0", VA = "0x1877290B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] EADAHIALNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7739D20", Offset = "0x7739120", VA = "0x187739D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator JFBAGGBJKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x773B700", Offset = "0x773AB00", VA = "0x18773B700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK JFMFHKDHHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7739C20", Offset = "0x7739020", VA = "0x187739C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private DAKFJKMHLMM GONEDGBEAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x772E460", Offset = "0x772D860", VA = "0x18772E460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private DAKFJKMHLMM MJALHJPGFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x773AC80", Offset = "0x773A080", VA = "0x18773AC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private DAKFJKMHLMM DFGGGDFBINN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7726CF0", Offset = "0x77260F0", VA = "0x187726CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private DAKFJKMHLMM CDPBKENOBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7724170", Offset = "0x7723570", VA = "0x187724170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private DAKFJKMHLMM JBAMOAJDLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x77358E0", Offset = "0x7734CE0", VA = "0x1877358E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private DAKFJKMHLMM GPONFKFPGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x772C4F0", Offset = "0x772B8F0", VA = "0x18772C4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private DAKFJKMHLMM OODAMLGEFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7726F40", Offset = "0x7726340", VA = "0x187726F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private DAKFJKMHLMM DCNLIDHECDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x773A340", Offset = "0x7739740", VA = "0x18773A340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DFOFNIFAMPI BLEICLCIEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7729A70", Offset = "0x7728E70", VA = "0x187729A70", Slot = "15")]
		get
		{
			return default(DFOFNIFAMPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EDHLCJGGGBG MPLFFAOGBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF30", Offset = "0xA1A330", VA = "0x180A1AF30", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EGAPJAGIONO IOKHLOAJJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5C0", Offset = "0xA1A9C0", VA = "0x180A1B5C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public APBOJJNEGEB KBLBNCNJEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA1B870", Offset = "0xA1AC70", VA = "0x180A1B870", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public APBOJJNEGEB ODOHDKFMEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2D0", Offset = "0xA1A6D0", VA = "0x180A1B2D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string HDIEEINEIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform FBGIGNKMCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x772A6E0", Offset = "0x7729AE0", VA = "0x18772A6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform PBLNJHOMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7731740", Offset = "0x7730B40", VA = "0x187731740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform GEMNMHJCGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x773B980", Offset = "0x773AD80", VA = "0x18773B980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform JLFNHFMPPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7729610", Offset = "0x7728A10", VA = "0x187729610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform JNHOLLNGGND
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x772BCB0", Offset = "0x772B0B0", VA = "0x18772BCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool LMMPPCEEDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7726BD0", Offset = "0x7725FD0", VA = "0x187726BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool KCIKKJFOCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7726BD0", Offset = "0x7725FD0", VA = "0x187726BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KNJKBMIMPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x772A000", Offset = "0x7729400", VA = "0x18772A000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform MLAGPNJOJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x773AD80", Offset = "0x773A180", VA = "0x18773AD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject GIIGFIAPGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7729C30", Offset = "0x7729030", VA = "0x187729C30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets CLEFGDLPJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x772B080", Offset = "0x772A480", VA = "0x18772B080", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform CDPAPEJLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA0EF60", Offset = "0xA0E360", VA = "0x180A0EF60", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform PHKCCAEBHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA1B8B0", Offset = "0xA1ACB0", VA = "0x180A1B8B0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform ECNMLGLKGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA1A510", Offset = "0xA19910", VA = "0x180A1A510", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform BJPNAJLJKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1AFA4D0", Offset = "0x1AF98D0", VA = "0x181AFA4D0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 OCDPOKEPCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7729650", Offset = "0x7728A50", VA = "0x187729650", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float ODKKHKJPFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x773A2F0", Offset = "0x77396F0", VA = "0x18773A2F0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform DBOHNEMHCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x772BD70", Offset = "0x772B170", VA = "0x18772BD70", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform IFEGLOBMEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x217D790", Offset = "0x217CB90", VA = "0x18217D790", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform HABNIFBEOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2189620", Offset = "0x2188A20", VA = "0x182189620", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CAIFDKBJEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1AFB090", Offset = "0x1AFA490", VA = "0x181AFB090", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool AIPKHMNEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x773A1F0", Offset = "0x77395F0", VA = "0x18773A1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool GHLFJLLLBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x77388F0", Offset = "0x7737CF0", VA = "0x1877388F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool HFMMCAHMFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x77296E0", Offset = "0x7728AE0", VA = "0x1877296E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x772C5F0", Offset = "0x772B9F0", VA = "0x18772C5F0")]
	private void IOEMIALMBMI([In] KPDOMOAMKCP MFIEBHBJHGH, [In] AvatarFullBodyConfiguration HNFCGGMPMHM, bool LBEOLHDGBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77277A0", Offset = "0x7726BA0", VA = "0x1877277A0")]
	private float EGGOKHIGJDI([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7729DD0", Offset = "0x77291D0", VA = "0x187729DD0")]
	private float HDFCJFMHIAA([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7738A70", Offset = "0x7737E70", VA = "0x187738A70")]
	private void NHLIGNMBPIO(KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM, bool LBEOLHDGBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7736960", Offset = "0x7735D60", VA = "0x187736960")]
	private void MFDJKAPOBBG([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7731D30", Offset = "0x7731130", VA = "0x187731D30")]
	private void KMOOJOIECAK([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x773CDE0", Offset = "0x773C1E0", VA = "0x18773CDE0")]
	public AGKBBPGDILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x772A100", Offset = "0x7729500", VA = "0x18772A100", Slot = "12")]
	public void HDNMBPHDHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x77260B0", Offset = "0x77254B0", VA = "0x1877260B0", Slot = "13")]
	public void CBAKONOKKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x77238A0", Offset = "0x7722CA0", VA = "0x1877238A0", Slot = "14")]
	public void ABIPLPIJBMO(bool PCDNGBDMGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7726DF0", Offset = "0x77261F0", VA = "0x187726DF0", Slot = "25")]
	public Transform DKAFJDOAFDA(string NKODMGPOEPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7724630", Offset = "0x7723A30", VA = "0x187724630", Slot = "26")]
	public Vector3? BDNNMOHILEP(string NKODMGPOEPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7727C00", Offset = "0x7727000", VA = "0x187727C00", Slot = "7")]
	public void EPCAFDKMFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77276A0", Offset = "0x7726AA0", VA = "0x1877276A0")]
	private void EDNBIDBDBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7727040", Offset = "0x7726440", VA = "0x187727040")]
	private Vector3 DNFLECNFHHA([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77283A0", Offset = "0x77277A0", VA = "0x1877283A0", Slot = "6")]
	public void EPDDMLBIPCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x77242A0", Offset = "0x77236A0", VA = "0x1877242A0", Slot = "8")]
	public void AJNPGAALLBK(float NAHDGPLGPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7732370", Offset = "0x7731770", VA = "0x187732370")]
	private void KPJAIENMICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7732F70", Offset = "0x7732370", VA = "0x187732F70", Slot = "4")]
	public void LCGCOIGCKIG(string OFHHLDJLPDA, NKOKBOFABJF HIPBHGICOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x772DFC0", Offset = "0x772D3C0", VA = "0x18772DFC0", Slot = "5")]
	public void JDBPGBAJDBM(DFOFNIFAMPI BKCGHNNBNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x772B100", Offset = "0x772A500", VA = "0x18772B100", Slot = "11")]
	public void HKHAIJJCPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x772A730", Offset = "0x7729B30", VA = "0x18772A730", Slot = "24")]
	public void HGGMLGAGCIG([Out] Vector3 OLLGPOIFDBE, [Out] Quaternion JOHIIPFHDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x772BCF0", Offset = "0x772B0F0", VA = "0x18772BCF0")]
	private void IDJIFHMJDOP([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7731780", Offset = "0x7730B80", VA = "0x187731780", Slot = "27")]
	public void JPJMKAHEAMC(float HNMMHCECPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x77291B0", Offset = "0x77285B0", VA = "0x1877291B0", Slot = "28")]
	public void FDDCGFOHPPC(float FCJOECDLHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7739BD0", Offset = "0x7738FD0", VA = "0x187739BD0", Slot = "44")]
	public void NLKJDJLCHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7731CE0", Offset = "0x77310E0", VA = "0x187731CE0", Slot = "29")]
	public void KHFACAHIHFI(bool EOGFHJJNAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x773BFC0", Offset = "0x773B3C0", VA = "0x18773BFC0", Slot = "30")]
	public HandLogicOffsets PJCBJLNLOFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x772A620", Offset = "0x7729A20", VA = "0x18772A620", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets HECEDAAODNG()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7724270", Offset = "0x7723670", VA = "0x187724270")]
	private void AIBOGGKGIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x773B800", Offset = "0x773AC00", VA = "0x18773B800")]
	private void PCEBJENMEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x772BFB0", Offset = "0x772B3B0", VA = "0x18772BFB0")]
	private void IMBIBDCBIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x77319F0", Offset = "0x7730DF0", VA = "0x1877319F0")]
	private void KDHPEJCHPGK(FGIODNKADFN FJKPALMOKBI, bool IIGOHJFNEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7730DE0", Offset = "0x77301E0", VA = "0x187730DE0")]
	private void JKOBGAAOCIL(FGIODNKADFN FJKPALMOKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7736910", Offset = "0x7735D10", VA = "0x187736910")]
	public Vector3 LKDDCHGKECE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77235B0", Offset = "0x77229B0", VA = "0x1877235B0")]
	private void AAMMHGOALIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7729DB0", Offset = "0x77291B0", VA = "0x187729DB0")]
	private void GNCIEHPFKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x773AE80", Offset = "0x773A280", VA = "0x18773AE80")]
	private void OLMDDDPECNF(KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7729E50", Offset = "0x7729250", VA = "0x187729E50")]
	private float HDHPEJJILFG([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7729CD0", Offset = "0x77290D0", VA = "0x187729CD0")]
	private int GMABMPGCLCB([In] DIJMGPOHLHK ADPNCMHFIFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E30", Offset = "0x7731230", VA = "0x187731E30")]
	private void KOOLPLHFAPH(KPDOMOAMKCP MFIEBHBJHGH, bool JKJLDLCBCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x77361A0", Offset = "0x77355A0", VA = "0x1877361A0")]
	private static void LENHBJJACKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x77300B0", Offset = "0x772F4B0", VA = "0x1877300B0")]
	private static void JIKJEIOHBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x772BDD0", Offset = "0x772B1D0", VA = "0x18772BDD0")]
	private float ILJEJCPMJLJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7726C20", Offset = "0x7726020", VA = "0x187726C20")]
	private static int DDJNMPLFPED(AGKBBPGDILM KGCKEJLFPJB, AGKBBPGDILM HKELKGIPNGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x77244C0", Offset = "0x77238C0", VA = "0x1877244C0", Slot = "40")]
	public KPDOMOAMKCP APFGDAKHIHK()
	{
		return default(KPDOMOAMKCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x77363D0", Offset = "0x77357D0", VA = "0x1877363D0")]
	public void LGEMEHEGCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7729860", Offset = "0x7728C60", VA = "0x187729860")]
	private (bool, bool) FOOLOLJHMCH()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x77269F0", Offset = "0x7725DF0", VA = "0x1877269F0")]
	private (float, float) DAFBNANGDMP([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x772E660", Offset = "0x772DA60", VA = "0x18772E660")]
	private void JHFBCBFLCJC([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x773C010", Offset = "0x773B410", VA = "0x18773C010")]
	private void PMCMHJIPDCB([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x772AAC0", Offset = "0x7729EC0", VA = "0x18772AAC0")]
	private void HGPPINEOAII([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM, AvatarFootSettings EIELDECCFNM, bool JBGMGPAKPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7729030", Offset = "0x7728430", VA = "0x187729030")]
	private float FBMIIFINBPM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x77247D0", Offset = "0x7723BD0", VA = "0x1877247D0")]
	private void BGLDDHPOEFI(KPDOMOAMKCP DHJOIBPBMPI, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x772BD20", Offset = "0x772B120", VA = "0x18772BD20")]
	private float IJCBJBCNBPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7736450", Offset = "0x7735850", VA = "0x187736450")]
	private void LHJPOAMJFLL([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7739510", Offset = "0x7738910", VA = "0x187739510")]
	private void NJBIHEJHFMO([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x77382A0", Offset = "0x77376A0", VA = "0x1877382A0")]
	private void NCGBMCNAEOE([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7737210", Offset = "0x7736610", VA = "0x187737210")]
	private void MNDFFPOGOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7731790", Offset = "0x7730B90", VA = "0x187731790")]
	private void KBJKMJPAICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x772AEE0", Offset = "0x772A2E0", VA = "0x18772AEE0")]
	private void HIFLKMNJELK([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7737760", Offset = "0x7736B60", VA = "0x187737760")]
	private void NCBOAEKCPNC(KBBMLEHBPBD OGKJGEDOCHH, IKSolverVR.Arm LCMHDAFJMNP, Transform EJDCPJCBFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7735550", Offset = "0x7734950", VA = "0x187735550")]
	private void LDGNAFBLBNI(KPDOMOAMKCP DHJOIBPBMPI, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7737590", Offset = "0x7736990", VA = "0x187737590")]
	private void MOJBPHJHEJI(OLHEIENPJAM LFHECPBHJLI, APBOJJNEGEB OGKJGEDOCHH, IKSolverVR.Arm LCMHDAFJMNP, float BLFJEGJJBFG, float JBLJNMLIKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7725AB0", Offset = "0x7724EB0", VA = "0x187725AB0")]
	private void CALIKNNNBIH([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7739E20", Offset = "0x7739220", VA = "0x187739E20")]
	protected void OCEMMJJIDEC([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7739900", Offset = "0x7738D00", VA = "0x187739900")]
	private void NLFEDAOOHBE([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x77386A0", Offset = "0x7737AA0", VA = "0x1877386A0")]
	protected void NCNGMDNLFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x773A440", Offset = "0x7739840", VA = "0x18773A440")]
	private void OIFGCLHMLCP([In] KPDOMOAMKCP DHJOIBPBMPI, [In] OKCPPNLOCMD ECCFEKEGACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x77323C0", Offset = "0x77317C0", VA = "0x1877323C0")]
	private void LAGPDOLKPMP(KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x773BF80", Offset = "0x773B380", VA = "0x18773BF80")]
	private void PHOMDLAMHMD([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x773B9B0", Offset = "0x773ADB0", VA = "0x18773B9B0")]
	private Vector3 PDKDGOPHODI([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x77374C0", Offset = "0x77368C0", VA = "0x1877374C0")]
	private void MNDFLMEHEMH([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7738ED0", Offset = "0x77382D0", VA = "0x187738ED0")]
	private float NIPKFGEGDFH(float NACECBLGLON, [In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7725960", Offset = "0x7724D60", VA = "0x187725960")]
	private void BMPCLEMBKPK(float NACECBLGLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7736B20", Offset = "0x7735F20", VA = "0x187736B20")]
	private void MKOKOBNGNJC([In] KPDOMOAMKCP DHJOIBPBMPI, OKCPPNLOCMD ECCFEKEGACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x77359E0", Offset = "0x7734DE0", VA = "0x1877359E0")]
	private float LEJEIHLDCFK([In] KPDOMOAMKCP MFIEBHBJHGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7723970", Offset = "0x7722D70", VA = "0x187723970")]
	private void ADCIMDNBHCG(KPDOMOAMKCP DHJOIBPBMPI, OKCPPNLOCMD ECCFEKEGACH, Vector3 HJAMNHBOHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7724310", Offset = "0x7723710", VA = "0x187724310")]
	private static void ALCECFJOJLJ(Transform KHDOKFIGIID, Quaternion AJFJKBHPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7728D30", Offset = "0x7728130", VA = "0x187728D30")]
	private void FAGJJIAFKLL([In] KPDOMOAMKCP FPEANNOHINP, [In] DIJMGPOHLHK ADPNCMHFIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x77379F0", Offset = "0x7736DF0", VA = "0x1877379F0")]
	private void NCFOKAIGHEL([In] KPDOMOAMKCP FPEANNOHINP, [In] DIJMGPOHLHK ADPNCMHFIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7739320", Offset = "0x7738720", VA = "0x187739320")]
	private void NJADCACPEDF(float KDAECIFJIHB, [In] KPDOMOAMKCP MFIEBHBJHGH, float HLEMKGLLJDM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7730F70", Offset = "0x7730370", VA = "0x187730F70")]
	private float JOCINCEGLCG([In] KPDOMOAMKCP MFIEBHBJHGH, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7726470", Offset = "0x7725870", VA = "0x187726470")]
	private void CCNAODECDMP([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x772B260", Offset = "0x772A660", VA = "0x18772B260")]
	private void IBGKODBHCFD([In] KPDOMOAMKCP MFIEBHBJHGH, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7727830", Offset = "0x7726C30", VA = "0x187727830")]
	private void EOMBNDPMCCF([In] KPDOMOAMKCP MFIEBHBJHGH, float BDOPBBNAPIC, float OOBGNHFCMPF, Vector3 PAPBOFGFMFF, float HLEMKGLLJDM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7732570", Offset = "0x7731970", VA = "0x187732570")]
	private void LBBLAFKDEJJ(KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7726760", Offset = "0x7725B60", VA = "0x187726760")]
	private void CLDJCIKCKMA(KPDOMOAMKCP DHJOIBPBMPI, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x77271C0", Offset = "0x77265C0", VA = "0x1877271C0")]
	private void DOJCONPLJGA(KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x77257A0", Offset = "0x7724BA0", VA = "0x1877257A0")]
	public void BMHJLMAMPJH([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x77351E0", Offset = "0x77345E0", VA = "0x1877351E0")]
	public void LCOJBAKLJPO([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7727500", Offset = "0x7726900", VA = "0x187727500")]
	[CompilerGenerated]
	internal static void EDGPFPHCPLL(Transform IEAOMLJNJLM, IKSolverVR.Arm LCMHDAFJMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x773BED0", Offset = "0x773B2D0", VA = "0x18773BED0")]
	[CompilerGenerated]
	internal static void PHOAIMILADK(Vector3 PFCFCNFONJL, Vector3 PJODGPHCLLB, EPPKEMKNFDB P_2, KFAODICGGAD P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7726C50", Offset = "0x7726050", VA = "0x187726C50")]
	[CompilerGenerated]
	internal static void DFDFFFMECDP(LHMKMCFEGNN CNDHPHFDEGP, LHMKMCFEGNN EMAKNCJGAPB, Vector3 DHGCOICCBCL, float AFHGIBDEPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7729500", Offset = "0x7728900", VA = "0x187729500")]
	[CompilerGenerated]
	internal static bool FELFKDGOPGP(IKSolverVR.Arm LCMHDAFJMNP, MJHCLFFGKLN OMLNJEFBNLA, float DAPLPMBCCFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7725360", Offset = "0x7724760", VA = "0x187725360")]
	[CompilerGenerated]
	internal static float BJNPEDODAMD(Vector3 LAAIFMHODMJ, Vector3 HPADBNFBMCL, Vector3 JBIPNMMILJE, KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM, float HGHGCNDALFP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class LAADPCGOIEJ : DPMFNBJIIOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Dictionary<string, OHGFGGMFLAM> GBPBALHKPPL;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x774A6E0", Offset = "0x7749AE0", VA = "0x18774A6E0")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void LGFHJPGNODF(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x774A4C0", Offset = "0x77498C0", VA = "0x18774A4C0", Slot = "4")]
	public OHGFGGMFLAM JBDPCCAPANL(string KNLNHFBBNLF, AvatarSystemConfiguration LOKJMMPMKLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x774A2E0", Offset = "0x77496E0", VA = "0x18774A2E0", Slot = "5")]
	public void GMFLMMMFDLD(string KNLNHFBBNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x774A1A0", Offset = "0x77495A0", VA = "0x18774A1A0", Slot = "6")]
	public string AFIKJDLIGKN(string LAIPGODCECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x774A750", Offset = "0x7749B50", VA = "0x18774A750")]
	private string MPMLAIMDPML(string LAIPGODCECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x774A7C0", Offset = "0x7749BC0", VA = "0x18774A7C0")]
	public LAADPCGOIEJ()
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
		public class KDDIKKOPGDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private Dictionary<string, Transform> AKLFEHCPBAP;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool KCBHPIPJOPL
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x7749F50", Offset = "0x7749350", VA = "0x187749F50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7749FE0", Offset = "0x77493E0", VA = "0x187749FE0")]
			public void HFPBHANLJLH(VRIK DICOKLNCFCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
			public void OBDKCKPAKIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7749F90", Offset = "0x7749390", VA = "0x187749F90")]
			public void GCJCJGLHJHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x774A110", Offset = "0x7749510", VA = "0x18774A110")]
			public KDDIKKOPGDE()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[IDNFDPCBAID(GKKLJNPNNON.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[HCOGNCHHAAD(GKKLJNPNNON.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly KDDIKKOPGDE LKGKNOMLHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private NGFEFCOKFJH GOMNBPPENAL;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7744FC0", Offset = "0x77443C0", VA = "0x187744FC0")]
		private void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7744F70", Offset = "0x7744370", VA = "0x187744F70")]
		private bool BCAOFGJMJKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x77452A0", Offset = "0x77446A0", VA = "0x1877452A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7745310", Offset = "0x7744710", VA = "0x187745310")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x77452B0", Offset = "0x77446B0", VA = "0x1877452B0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7745580", Offset = "0x7744980", VA = "0x187745580")]
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
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7747D80", Offset = "0x7747180", VA = "0x187747D80")]
			public void BECHPFCMIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7747E60", Offset = "0x7747260", VA = "0x187747E60")]
			public (float, float) CNHBCMELOCC(Animator GONCFDEOKGC, AnimatorStateInfo NOILPEONCGL)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7747FA0", Offset = "0x77473A0", VA = "0x187747FA0")]
		public void BECHPFCMIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7748380", Offset = "0x7747780", VA = "0x187748380")]
		public (float, float) HMKJHCGLGNI(Animator GONCFDEOKGC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7748190", Offset = "0x7747590", VA = "0x187748190")]
		private (float, float) CEHLKMHMIBL(Animator GONCFDEOKGC, AnimatorStateInfo NOILPEONCGL)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7748590", Offset = "0x7747990", VA = "0x187748590")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x774E0E0", Offset = "0x774D4E0", VA = "0x18774E0E0", Slot = "4")]
		public override void OnStateEnter(Animator GONCFDEOKGC, AnimatorStateInfo NOILPEONCGL, int ILOBPOODEIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x774E250", Offset = "0x774D650", VA = "0x18774E250")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal abstract class PEOLILLNNGA<TInput, TOutput> : LMBLCGDOFNF<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected readonly ENCEHJNHPBL HKNGEHEEHMP;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x52D8610", Offset = "0x52D7A10", VA = "0x1852D8610")]
	protected PEOLILLNNGA(ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput HFAEDKNMEEN(TInput PJCOHHCODGF, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x52D8570", Offset = "0x52D7970", VA = "0x1852D8570", Slot = "5")]
	public bool OLICLMFNHDN(TInput PJCOHHCODGF, [Out] TOutput? HBALBIOOGIJ, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[CBAKGNGODOD]
public static class HJGPFOBGPPL
{
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly Regex GMJPGOAOEDP;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7747980", Offset = "0x7746D80", VA = "0x187747980")]
	public static FAKCGGBDOGH BLFCLAOHGFG(LALAGECKOGA FJPDHEKILDP, PECGMKADMMG BDLNICBMKMP, Guid? LMGCOEEBLBC, Color? AEMFOIHKBPM, IDINMFOPJOG OFBICLFFJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7747820", Offset = "0x7746C20", VA = "0x187747820")]
	public static FEJKALOKOAI AKCBJHDFIKG(FAKCGGBDOGH HPMNBNLACCC)
	{
		return default(FEJKALOKOAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x35F0F30", Offset = "0x35F0330", VA = "0x1835F0F30")]
	internal static TModern? IPEKAODCNHD<TModern>(string? PJCOHHCODGF, CHOCLPPHKEE<TModern> HKHCADCPLDM, ENCEHJNHPBL HKNGEHEEHMP, KLJLCKNDCOJ PGKDFMFJCBL, TModern GEKFCDAJGMG) where TModern : struct, OOBOEDGJKIN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x35F0750", Offset = "0x35EFB50", VA = "0x1835F0750")]
	internal static OAFOHPOELEF IIKGIICKJGO<TModern>(string? PJCOHHCODGF, CHOCLPPHKEE<TModern> HKHCADCPLDM, ENCEHJNHPBL HKNGEHEEHMP, KLJLCKNDCOJ PGKDFMFJCBL, TModern GEKFCDAJGMG) where TModern : struct, OOBOEDGJKIN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7747B90", Offset = "0x7746F90", VA = "0x187747B90")]
	internal static List<JLODCGNCFMB> OKKFOGPLDCI(IEnumerable<KOHEBNEONED>? IBFKIAPMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x35F2580", Offset = "0x35F1980", VA = "0x1835F2580")]
	internal static string MNFGFKPMCAD<TModern>(TModern PJCOHHCODGF, CHOCLPPHKEE<TModern> HKHCADCPLDM, ENCEHJNHPBL HKNGEHEEHMP) where TModern : OOBOEDGJKIN
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class CHLAIBJOEEJ : OFDFNMGNHCI
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LMBLCGDOFNF<OPKBFEBFLKC, FKAIDAOIGIH> OLGCDJPPIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LMBLCGDOFNF<CNAEMFJKIGO, BIAHFMGAOCL> DMILGBLHGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LMBLCGDOFNF<CNAEMFJKIGO, BIAHFMGAOCL> GGKLNPKCMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public ANMMJNGAPKM CNKPLPPFGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MKDFFABAFDM ODJOJLIMJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x77458F0", Offset = "0x7744CF0", VA = "0x1877458F0")]
	[UsedImplicitly]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void LCLELILMCHI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7745960", Offset = "0x7744D60", VA = "0x187745960")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CHLAIBJOEEJ([CMKKAFOAFJE("UnitySerialization")] NMGHNPBEPOC KLABIPAOBNI, [CMKKAFOAFJE(null)] IKKNLBGAIJE JJHCKCDCEDH, [CMKKAFOAFJE(null)] ENCEHJNHPBL HKNGEHEEHMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum NDGCAOKKIGI
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JPMBMDNPLGA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7749EC0", Offset = "0x77492C0", VA = "0x187749EC0")]
	public JPMBMDNPLGA(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7749EF0", Offset = "0x77492F0", VA = "0x187749EF0")]
	public JPMBMDNPLGA(string DAMFJFKKFBI, Exception HIFFMIIALED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7749F20", Offset = "0x7749320", VA = "0x187749F20")]
	public JPMBMDNPLGA(NDGCAOKKIGI BMBMKKHEAHH, string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7749E80", Offset = "0x7749280", VA = "0x187749E80")]
	public JPMBMDNPLGA(NDGCAOKKIGI BMBMKKHEAHH, string DAMFJFKKFBI, Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal abstract class DEMLFILFAPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly NMGHNPBEPOC KLABIPAOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	protected readonly IKKNLBGAIJE JJHCKCDCEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	protected readonly ENCEHJNHPBL HKNGEHEEHMP;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x77443B0", Offset = "0x77437B0", VA = "0x1877443B0")]
	protected DEMLFILFAPL(NMGHNPBEPOC KLABIPAOBNI, IKKNLBGAIJE JJHCKCDCEDH, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x77463E0", Offset = "0x77457E0", VA = "0x1877463E0")]
	protected string GIEANBCIEMK(FKAIDAOIGIH IGGKLFCOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x77461F0", Offset = "0x77455F0", VA = "0x1877461F0")]
	protected string DEHFNFFHNMG(FKAIDAOIGIH IGGKLFCOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7745EC0", Offset = "0x77452C0", VA = "0x187745EC0")]
	private AvatarOutfitSelectionData BLFCLAOHGFG(FAKCGGBDOGH MMPOOFEEMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x77476E0", Offset = "0x7746AE0", VA = "0x1877476E0")]
	private static AvatarCustomizationSettingsData.AnchorParams LHONNPBEDKM(KGGLBONGBPM? JCNNIJENAJB)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LMBLCGDOFNF<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput HFAEDKNMEEN(TInput PJCOHHCODGF, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLICLMFNHDN(TInput PJCOHHCODGF, [Out] TOutput? HBALBIOOGIJ, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OFDFNMGNHCI
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	LMBLCGDOFNF<OPKBFEBFLKC, FKAIDAOIGIH> OLGCDJPPIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LMBLCGDOFNF<CNAEMFJKIGO, BIAHFMGAOCL> GGKLNPKCMMI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	ANMMJNGAPKM CNKPLPPFGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum KLJLCKNDCOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MKDFFABAFDM
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KBKDBBKOBJO PELCBGJOJPC(FKAIDAOIGIH HPMNBNLACCC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface ANMMJNGAPKM
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNAEMFJKIGO PELCBGJOJPC(FKAIDAOIGIH HPMNBNLACCC, int KAJDCINBCAB, string? IGEPDAOOLBO, string? PPLFMLCMNCJ, LFNHDMIHLED NPGFKMBHNMB, List<JLODCGNCFMB>? DOEAEOCODNO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[CBAKGNGODOD]
internal class AAPNAHMOEEO : PEOLILLNNGA<OPKBFEBFLKC, FKAIDAOIGIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly IKKNLBGAIJE JJHCKCDCEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly LOEIGANIIJD MHHGABHDMNE;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7743AF0", Offset = "0x7742EF0", VA = "0x187743AF0")]
	public AAPNAHMOEEO(NMGHNPBEPOC KLABIPAOBNI, IKKNLBGAIJE JJHCKCDCEDH, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7743840", Offset = "0x7742C40", VA = "0x187743840", Slot = "6")]
	public override FKAIDAOIGIH HFAEDKNMEEN(OPKBFEBFLKC PJCOHHCODGF, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[RecRoom.NoEngine.Common.Preserve]
internal class PDIIKNJEIFC : NMGHNPBEPOC
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class IHAMACNGDAI : JsonConverter<OAFOHPOELEF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x77486C0", Offset = "0x7747AC0", VA = "0x1877486C0", Slot = "9")]
		public override void WriteJson(JsonWriter CEAJPINGICH, OAFOHPOELEF? FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x77485A0", Offset = "0x77479A0", VA = "0x1877485A0", Slot = "10")]
		public override OAFOHPOELEF ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, OAFOHPOELEF? IAGJKNIMAKN, bool POLAJMAPPCG, JsonSerializer ILLAJGPAKHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7748760", Offset = "0x7747B60", VA = "0x187748760")]
		public IHAMACNGDAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class LCKLJNLJCMJ : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool FHKDOADDAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x774AC10", Offset = "0x774A010", VA = "0x18774AC10", Slot = "5")]
		public override object ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, object? IAGJKNIMAKN, JsonSerializer ILLAJGPAKHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x774AA30", Offset = "0x7749E30", VA = "0x18774AA30", Slot = "6")]
		public override bool CanConvert(Type NILLICCLHIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x774AC70", Offset = "0x774A070", VA = "0x18774AC70", Slot = "4")]
		public override void WriteJson(JsonWriter CEAJPINGICH, object? FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x774A850", Offset = "0x7749C50", VA = "0x18774A850")]
		private static bool AFNGLKNFPLL(object FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public LCKLJNLJCMJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly JsonSerializerSettings JLDKPAAABKO;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x774E710", Offset = "0x774DB10", VA = "0x18774E710")]
	internal PDIIKNJEIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x380D760", Offset = "0x380CB60", VA = "0x18380D760", Slot = "4")]
	public string FDLDHAOIFJM<T>(T BLFGIKOAKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x380D6D0", Offset = "0x380CAD0", VA = "0x18380D6D0", Slot = "5")]
	public T AGHKMDPJHOK<T>(string FFOEEMKIKJO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[RecRoom.NoEngine.Common.Preserve]
internal class NKILNJKIPAC : NMGHNPBEPOC
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x37C2870", Offset = "0x37C1C70", VA = "0x1837C2870", Slot = "4")]
	public string FDLDHAOIFJM<T>(T BLFGIKOAKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x37C27F0", Offset = "0x37C1BF0", VA = "0x1837C27F0", Slot = "5")]
	public T AGHKMDPJHOK<T>(string FFOEEMKIKJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public NKILNJKIPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[CBAKGNGODOD]
internal class LOEIGANIIJD : PEOLILLNNGA<CNAEMFJKIGO, BIAHFMGAOCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly NMGHNPBEPOC KLABIPAOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly IKKNLBGAIJE JJHCKCDCEDH;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x774DFA0", Offset = "0x774D3A0", VA = "0x18774DFA0")]
	public LOEIGANIIJD(NMGHNPBEPOC KLABIPAOBNI, IKKNLBGAIJE JJHCKCDCEDH, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x774C7E0", Offset = "0x774BBE0", VA = "0x18774C7E0", Slot = "6")]
	public override BIAHFMGAOCL HFAEDKNMEEN(CNAEMFJKIGO PJCOHHCODGF, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x774DE40", Offset = "0x774D240", VA = "0x18774DE40")]
	internal void OGLFPCEDMFB(string AGCBNPEKJNA, FKAIDAOIGIH IGGKLFCOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x774DB90", Offset = "0x774CF90", VA = "0x18774DB90")]
	public IEnumerable<FAKCGGBDOGH> OCCJAGJHDBP(string BMJFOMOIGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x774C3B0", Offset = "0x774B7B0", VA = "0x18774C3B0")]
	private IEnumerable<FAKCGGBDOGH> GIJDPJFBMFL(string BMJFOMOIGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x774D5C0", Offset = "0x774C9C0", VA = "0x18774D5C0")]
	internal IEnumerable<FAKCGGBDOGH> MIFJPNEADDA(string BMJFOMOIGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x774CC10", Offset = "0x774C010", VA = "0x18774CC10")]
	private FAKCGGBDOGH HPKFFFDBLII(AvatarOutfitSelectionData PBKKOKKLJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x774BB10", Offset = "0x774AF10", VA = "0x18774BB10")]
	private void DNLLOKGJLNO(AvatarCustomizationSettingsData ILIFELFMNEJ, FKAIDAOIGIH IGGKLFCOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x774CFA0", Offset = "0x774C3A0", VA = "0x18774CFA0")]
	private FAKCGGBDOGH HPKFFFDBLII(string PENKNNBAFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x774D2C0", Offset = "0x774C6C0", VA = "0x18774D2C0")]
	internal static (IDINMFOPJOG, string, string) KGBPJKGEEFD(string PENKNNBAFNA, ENCEHJNHPBL HKNGEHEEHMP)
	{
		return default((IDINMFOPJOG, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x774DC40", Offset = "0x774D040", VA = "0x18774DC40")]
	private ICDNLIPEIMO? OFBGCMEKLJA(string? KDBHLLEACIN, Vector2 MKJEPMILFBJ, float PBGGIDHPDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x774DA30", Offset = "0x774CE30", VA = "0x18774DA30")]
	private static KGGLBONGBPM NDGGDFEDCBC(AvatarCustomizationSettingsData.AnchorParams ACPHBAAHEMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[CBAKGNGODOD]
internal class AKDKAMHOOAJ : DEMLFILFAPL, MKDFFABAFDM
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x77443B0", Offset = "0x77437B0", VA = "0x1877443B0")]
	public AKDKAMHOOAJ(NMGHNPBEPOC KLABIPAOBNI, IKKNLBGAIJE JJHCKCDCEDH, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7744000", Offset = "0x7743400", VA = "0x187744000", Slot = "4")]
	public KBKDBBKOBJO PELCBGJOJPC(FKAIDAOIGIH HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7743CC0", Offset = "0x77430C0", VA = "0x187743CC0")]
	private string HAOJLEHGOBH(FKAIDAOIGIH IGGKLFCOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7743DC0", Offset = "0x77431C0", VA = "0x187743DC0")]
	private string JCLBIHMKAIJ(FAKCGGBDOGH MMPOOFEEMHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CBAKGNGODOD]
internal class POPEMNKELEL : PEOLILLNNGA<CNAEMFJKIGO, BIAHFMGAOCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly NMGHNPBEPOC KLABIPAOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly LMBLCGDOFNF<CNAEMFJKIGO, BIAHFMGAOCL> EIGGBAMOBLN;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x774ECA0", Offset = "0x774E0A0", VA = "0x18774ECA0")]
	public POPEMNKELEL(LMBLCGDOFNF<CNAEMFJKIGO, BIAHFMGAOCL> EIGGBAMOBLN, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x774E870", Offset = "0x774DC70", VA = "0x18774E870", Slot = "6")]
	public override BIAHFMGAOCL HFAEDKNMEEN(CNAEMFJKIGO PJCOHHCODGF, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CBAKGNGODOD]
internal class NNJMHEMOLEF : ANMMJNGAPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly NMGHNPBEPOC KLABIPAOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly MKDFFABAFDM DNKJNCIIDLK;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x774E620", Offset = "0x774DA20", VA = "0x18774E620")]
	public NNJMHEMOLEF(MKDFFABAFDM DNKJNCIIDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x774E270", Offset = "0x774D670", VA = "0x18774E270", Slot = "4")]
	public CNAEMFJKIGO PELCBGJOJPC(FKAIDAOIGIH HPMNBNLACCC, int KAJDCINBCAB, string? IGEPDAOOLBO, string? PPLFMLCMNCJ, LFNHDMIHLED NPGFKMBHNMB, List<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return null;
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x77445E0", Offset = "0x77439E0", VA = "0x1877445E0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BCLKCLOLOBE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x77456C0", Offset = "0x7744AC0", VA = "0x1877456C0")]
	public static FEJKALOKOAI HFAEDKNMEEN(this GJGJNGDGGDM HPMNBNLACCC)
	{
		return default(FEJKALOKOAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x77457D0", Offset = "0x7744BD0", VA = "0x1877457D0")]
	public static GJGJNGDGGDM PELCBGJOJPC(this FEJKALOKOAI LEEGMHDKJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7745660", Offset = "0x7744A60", VA = "0x187745660")]
	public static bool AAELJMIEJNK(this FEJKALOKOAI LEEGMHDKJLE)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x58C6FB0", Offset = "0x58C63B0", VA = "0x1858C6FB0")]
			public AnchorParams(Vector2 NEMCEGFJAMM, Vector3 JJFMMKBGHBD, Vector3 CEGIKJLFFBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x7744530", Offset = "0x7743930", VA = "0x187744530")]
			internal KGGLBONGBPM PELCBGJOJPC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private HPMNLDEHFIP useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7744E10", Offset = "0x7744210", VA = "0x187744E10")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x42E22B0", Offset = "0x42E16B0", VA = "0x1842E22B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xC09330", Offset = "0xC08730", VA = "0x180C09330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xE58410", Offset = "0xE57810", VA = "0x180E58410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x11C7260", Offset = "0x11C6660", VA = "0x1811C7260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x99E210", Offset = "0x99D610", VA = "0x18099E210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7744EC0", Offset = "0x77442C0", VA = "0x187744EC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x99A0D0", Offset = "0x9994D0", VA = "0x18099A0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xB45BA0", Offset = "0xB44FA0", VA = "0x180B45BA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xB46090", Offset = "0xB45490", VA = "0x180B46090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9943C0", Offset = "0x9937C0", VA = "0x1809943C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x9945F0", Offset = "0x9939F0", VA = "0x1809945F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x7744F00", Offset = "0x7744300", VA = "0x187744F00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xD7D270", Offset = "0xD7C670", VA = "0x180D7D270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xFB44E0", Offset = "0xFB38E0", VA = "0x180FB44E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x1623D10", Offset = "0x1623110", VA = "0x181623D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x993A50", Offset = "0x992E50", VA = "0x180993A50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x993AA0", Offset = "0x992EA0", VA = "0x180993AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x213A680", Offset = "0x2139A80", VA = "0x18213A680")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD9B060", Offset = "0xD9A460", VA = "0x180D9B060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9CAFA0", Offset = "0x9CA3A0", VA = "0x1809CAFA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9CB000", Offset = "0x9CA400", VA = "0x1809CB000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9984B0", Offset = "0x9978B0", VA = "0x1809984B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x998570", Offset = "0x997970", VA = "0x180998570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x998560", Offset = "0x997960", VA = "0x180998560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x998580", Offset = "0x997980", VA = "0x180998580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x998640", Offset = "0x997A40", VA = "0x180998640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9985E0", Offset = "0x9979E0", VA = "0x1809985E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB1B2F0", Offset = "0xB1A6F0", VA = "0x180B1B2F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x11EBD10", Offset = "0x11EB110", VA = "0x1811EBD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9984E0", Offset = "0x9978E0", VA = "0x1809984E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9985B0", Offset = "0x9979B0", VA = "0x1809985B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xC2F980", Offset = "0xC2ED80", VA = "0x180C2F980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xDA69D0", Offset = "0xDA5DD0", VA = "0x180DA69D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x99CBA0", Offset = "0x99BFA0", VA = "0x18099CBA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x99CC00", Offset = "0x99C000", VA = "0x18099CC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB7E120", Offset = "0xB7D520", VA = "0x180B7E120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xDAB6E0", Offset = "0xDAAAE0", VA = "0x180DAB6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xBCB340", Offset = "0xBCA740", VA = "0x180BCB340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xBC7330", Offset = "0xBC6730", VA = "0x180BC7330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public HPMNLDEHFIP UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xE5E000", Offset = "0xE5D400", VA = "0x180E5E000")]
			get
			{
				return default(HPMNLDEHFIP);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xE5D8C0", Offset = "0xE5CCC0", VA = "0x180E5D8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xE5C630", Offset = "0xE5BA30", VA = "0x180E5C630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB15900", Offset = "0xB14D00", VA = "0x180B15900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x7744EE0", Offset = "0x77442E0", VA = "0x187744EE0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7744F20", Offset = "0x7744320", VA = "0x187744F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7744A70", Offset = "0x7743E70", VA = "0x187744A70")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public IDINMFOPJOG BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private BLFDDICPCCB? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x7744F40", Offset = "0x7744340", VA = "0x187744F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
