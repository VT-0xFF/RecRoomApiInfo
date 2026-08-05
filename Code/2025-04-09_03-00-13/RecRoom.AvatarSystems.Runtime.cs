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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x77902A0", Offset = "0x778F6A0", VA = "0x1877902A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7790320", Offset = "0x778F720", VA = "0x187790320", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
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
	[Cpp2IlInjected.Address(RVA = "0x778F590", Offset = "0x778E990", VA = "0x18778F590")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	[UsedImplicitly]
	internal static void LCLELILMCHI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7790120", Offset = "0x778F520", VA = "0x187790120")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IAIFNNCNKCJ([CMKKAFOAFJE(null)] OHCDBGKPMDE PHNMEFNEKGC, [CMKKAFOAFJE(null)] OFDFNMGNHCI IMKMOBALPLA, [CMKKAFOAFJE(null)] LIJOGIGJHBL FOCEHAPAJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x778F870", Offset = "0x778EC70", VA = "0x18778F870", Slot = "5")]
	public FKAIDAOIGIH OBHDMGFJBFA(GEHKDDKOMID IOAAKAMPEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x778E720", Offset = "0x778DB20", VA = "0x18778E720", Slot = "4")]
	public FKAIDAOIGIH COKPGEJLEMJ(GEHKDDKOMID IOAAKAMPEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x778F2E0", Offset = "0x778E6E0", VA = "0x18778F2E0", Slot = "6")]
	public CNAEMFJKIGO HHOAHHBMLOA(FKAIDAOIGIH HPMNBNLACCC, int KAJDCINBCAB, string? IGEPDAOOLBO, string? PPLFMLCMNCJ, LFNHDMIHLED NPGFKMBHNMB, List<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x778F600", Offset = "0x778EA00", VA = "0x18778F600", Slot = "7")]
	public bool LEDPPMAHDJL(OPKBFEBFLKC MOLMNIDNABI, [Out] FKAIDAOIGIH? IGGKLFCOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x778F200", Offset = "0x778E600", VA = "0x18778F200", Slot = "8")]
	public bool EKKFAJIFIBK(CNAEMFJKIGO HNNKCDGDBAL, [Out] FKAIDAOIGIH? IGGKLFCOGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x778E690", Offset = "0x778DA90", VA = "0x18778E690", Slot = "9")]
	public bool ANCDIOMNOGJ(CNAEMFJKIGO HNNKCDGDBAL, [Out] BIAHFMGAOCL? MOLMNIDNABI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3655920", Offset = "0x3654D20", VA = "0x183655920")]
	private bool OLICLMFNHDN<TInput, TOutput>(TInput PJCOHHCODGF, LMBLCGDOFNF<TInput, TOutput> HEHLCOLGLJE, [Out] TOutput? HBALBIOOGIJ) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x778F3F0", Offset = "0x778E7F0", VA = "0x18778F3F0")]
	[CompilerGenerated]
	private ICDNLIPEIMO KJEFGNGPFFH(FaceFeatureType MODHLEEDKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x778F690", Offset = "0x778EA90", VA = "0x18778F690")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GFLPJKHCIOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x778E650", Offset = "0x778DA50", VA = "0x18778E650")]
		internal bool JLEOOENCKIN(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x778E670", Offset = "0x778DA70", VA = "0x18778E670")]
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
	[Cpp2IlInjected.Address(RVA = "0x778D830", Offset = "0x778CC30", VA = "0x18778D830")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	[UsedImplicitly]
	internal static void LCLELILMCHI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x778E070", Offset = "0x778D470", VA = "0x18778E070")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CBENMANPIDI([CMKKAFOAFJE(null)] LIJOGIGJHBL FOCEHAPAJKO, [CMKKAFOAFJE(null)] ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x778DC90", Offset = "0x778D090", VA = "0x18778DC90", Slot = "4")]
	public bool NPDGNNFBAFO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x778DB30", Offset = "0x778CF30", VA = "0x18778DB30", Slot = "5")]
	public bool NPDGNNFBAFO(BIAHFMGAOCL MOLMNIDNABI, IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x778CC20", Offset = "0x778C020", VA = "0x18778CC20")]
	private void IGMDOODJJJB(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x778DD90", Offset = "0x778D190", VA = "0x18778DD90")]
	private void NPMALOBABCO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x778D800", Offset = "0x778CC00", VA = "0x18778D800")]
	private void LBCICIBDKML(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x778DB00", Offset = "0x778CF00", VA = "0x18778DB00")]
	private void MNBJDMNFNIO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x778C550", Offset = "0x778B950", VA = "0x18778C550")]
	private void BCONGBPAADH(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x778DA50", Offset = "0x778CE50", VA = "0x18778DA50")]
	private void MHFDKCMICOA(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x778DFC0", Offset = "0x778D3C0", VA = "0x18778DFC0")]
	private void OPJJADOEKOL(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x778C540", Offset = "0x778B940", VA = "0x18778C540")]
	private void AHHBIMMKJEO(FKAIDAOIGIH IGGKLFCOGPM, IReadOnlyList<JLODCGNCFMB>? FKPHPPGPLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x778C940", Offset = "0x778BD40", VA = "0x18778C940")]
	private void GNGBNADIINM(FKAIDAOIGIH IGGKLFCOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x778C620", Offset = "0x778BA20", VA = "0x18778C620")]
	private FKAIDAOIGIH EBBCIFGBDGJ(FKAIDAOIGIH IGGKLFCOGPM, List<RangeMigration> ECDENHJAIGP, JLBLAHIIBKF ENNGOFOCADI, JLBLAHIIBKF NHHNCOGCFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x778C900", Offset = "0x778BD00", VA = "0x18778C900")]
	private float FPBJEHPOMGD(float IPDNENCBJGL, Vector2 DCDLPFBPBMI, Vector2 ODDGCFPFIKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x778D8A0", Offset = "0x778CCA0", VA = "0x18778D8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x778A110", Offset = "0x7789510", VA = "0x18778A110")]
		public void FFEFLKAFCLH(AnimationPoseSetting KNCKFHOKGJM, float OHDKEIGOGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x778A240", Offset = "0x7789640", VA = "0x18778A240")]
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
		[Cpp2IlInjected.Address(RVA = "0x778AB30", Offset = "0x7789F30", VA = "0x18778AB30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x778AAF0", Offset = "0x7789EF0", VA = "0x18778AAF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x778A260", Offset = "0x7789660", VA = "0x18778A260")]
		private void OBFEEOBGEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7700910", Offset = "0x76FFD10", VA = "0x187700910", Slot = "4")]
		public void SetEnabled(bool CGAPLHFOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x778AB60", Offset = "0x7789F60", VA = "0x18778AB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x778ABA0", Offset = "0x7789FA0", VA = "0x18778ABA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x778AC20", Offset = "0x778A020", VA = "0x18778AC20")]
		public AnimationPoseSetting KFIHDKBDBDJ(ILNDAIKDAIH PCCNNFIJGNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x778ABE0", Offset = "0x7789FE0", VA = "0x18778ABE0")]
		public void BECHPFCMIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x778AC50", Offset = "0x778A050", VA = "0x18778AC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x778B700", Offset = "0x778AB00", VA = "0x18778B700")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x778B6C0", Offset = "0x778AAC0", VA = "0x18778B6C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x778B0C0", Offset = "0x778A4C0", VA = "0x18778B0C0")]
		private void OBFEEOBGEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7700910", Offset = "0x76FFD10", VA = "0x187700910", Slot = "4")]
		public void SetEnabled(bool CGAPLHFOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x778B730", Offset = "0x778AB30", VA = "0x18778B730")]
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
			[Cpp2IlInjected.Address(RVA = "0xA4C8D0", Offset = "0xA4BCD0", VA = "0x180A4C8D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform DEBDOHLKJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x778C520", Offset = "0x778B920", VA = "0x18778C520", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x778B760", Offset = "0x778AB60", VA = "0x18778B760")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x778C3E0", Offset = "0x778B7E0", VA = "0x18778C3E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x778C390", Offset = "0x778B790", VA = "0x18778C390")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x778C320", Offset = "0x778B720", VA = "0x18778C320")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x778B760", Offset = "0x778AB60", VA = "0x18778B760", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x778BAF0", Offset = "0x778AEF0", VA = "0x18778BAF0", Slot = "6")]
		public OHGFGGMFLAM CreateAvatarSystem(string OFHHLDJLPDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x778C320", Offset = "0x778B720", VA = "0x18778C320", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x778B820", Offset = "0x778AC20", VA = "0x18778B820", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x778C430", Offset = "0x778B830", VA = "0x18778C430", Slot = "9")]
		public void UpdatePostIKAnimControllers(float JNFHMFBFJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1DC4420", Offset = "0x1DC3820", VA = "0x181DC4420")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4440", Offset = "0x1DC3840", VA = "0x181DC4440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion FGOBMENEKND
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x12548D0", Offset = "0x1253CD0", VA = "0x1812548D0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x12545A0", Offset = "0x12539A0", VA = "0x1812545A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float AHAMCJICHKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xFBE960", Offset = "0xFBDD60", VA = "0x180FBE960")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1610070", Offset = "0x160F470", VA = "0x181610070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool JABGIECJHJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9AA350", Offset = "0x9A9750", VA = "0x1809AA350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4C0", Offset = "0x9A98C0", VA = "0x1809AA4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool MIMKHALFMJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9AA320", Offset = "0x9A9720", VA = "0x1809AA320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9AA360", Offset = "0x9A9760", VA = "0x1809AA360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool BGMIPJMNDPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4F0", Offset = "0x9A98F0", VA = "0x1809AA4F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5D0", Offset = "0x9A99D0", VA = "0x1809AA5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EKCIGFMALPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xBEA320", Offset = "0xBE9720", VA = "0x180BEA320")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xBEB2D0", Offset = "0xBEA6D0", VA = "0x180BEB2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7797CF0", Offset = "0x77970F0", VA = "0x187797CF0")]
		public void BOAKHMFLLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7797F10", Offset = "0x7797310", VA = "0x187797F10")]
		public void DJODKKEGBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7797D00", Offset = "0x7797100", VA = "0x187797D00")]
		public float CCOPLPBPKGE(Vector3 BNOPMBDJJMI, Quaternion MJBNOOFMMKI, [In] AvatarFootSettings EIELDECCFNM, float HAFADEOKAFJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7798190", Offset = "0x7797590", VA = "0x187798190")]
		public void OMKDHELPGNO(Vector3 PLKKJHFPAME, Quaternion CCCINBKEDFA, Transform HDNHKPGGPLN, float PFBBLPGGPPJ, bool GCHGOFCJOLK, bool FHOMHHIIPIG, float BAIMJCJACOM, float NACECBLGLON, Transform BKHMOJGGBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7797AC0", Offset = "0x7796EC0", VA = "0x187797AC0")]
		public void AACEHMEKDIN(Transform PBPFBBCFKNN, Transform BKHMOJGGBFN, bool MCKLFPAKNNG, bool BEPICDCJHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7798090", Offset = "0x7797490", VA = "0x187798090")]
		private void OGNBBJJCCIM(Transform BKHMOJGGBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7797F40", Offset = "0x7797340", VA = "0x187797F40")]
		public void LLHJJDAIKMD(Transform BKHMOJGGBFN, AvatarFullBodyConfiguration HNFCGGMPMHM, Vector3 KNFCDDMNGLJ, float LGEGDFIKLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7797F20", Offset = "0x7797320", VA = "0x187797F20")]
		public void IGBIGHIEBEM(float NACECBLGLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7798860", Offset = "0x7797C60", VA = "0x187798860")]
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
		[Cpp2IlInjected.Address(RVA = "0x7795510", Offset = "0x7794910", VA = "0x187795510")]
		public void AJNGODCFNAB(IKSolverVR.Arm LCMHDAFJMNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7795FD0", Offset = "0x77953D0", VA = "0x187795FD0")]
		public void JEMEKPHJDBH(IKSolverVR.Arm LCMHDAFJMNP, float BLFJEGJJBFG, bool DNNHJFLKKEA, AvatarFullBodyConfiguration HNFCGGMPMHM, float ENOGEACDIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x77969F0", Offset = "0x7795DF0", VA = "0x1877969F0")]
		private void NPBGBIBALDH(IKSolverVR.Arm LCMHDAFJMNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7796610", Offset = "0x7795A10", VA = "0x187796610")]
		public void NJBIHEJHFMO(IKSolverVR.Arm LCMHDAFJMNP, Transform NAGDLAMLEKO, Transform HDNHKPGGPLN, Quaternion MHEEGCAGLHM, Vector3 DFCPGNEFHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7795B40", Offset = "0x7794F40", VA = "0x187795B40")]
		private (Vector3, Quaternion) ECDIKLKBLCN(KBBMLEHBPBD DNAJMFFBCPA, Quaternion BNMINADHENM, Vector3 JPLFJFKFPLH)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x77959E0", Offset = "0x7794DE0", VA = "0x1877959E0")]
		public void BJLJDKCGGPK(KBBMLEHBPBD DNAJMFFBCPA, IKSolverVR.Arm LCMHDAFJMNP, Quaternion BNMINADHENM, Vector3 JPLFJFKFPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7796010", Offset = "0x7795410", VA = "0x187796010")]
		public void MBFBJAKMNNB(KBBMLEHBPBD DNAJMFFBCPA, IKSolverVR.Arm LCMHDAFJMNP, Quaternion BNMINADHENM, Vector3 JPLFJFKFPLH, [In] AvatarFullBodyConfiguration HNFCGGMPMHM, [In] KPDOMOAMKCP DHJOIBPBMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7796A30", Offset = "0x7795E30", VA = "0x187796A30")]
		public void OMEMHIBGANE(ILNDAIKDAIH OKMFMOLKNNG, AvatarFullBodyConfiguration HNFCGGMPMHM, KPDOMOAMKCP DHJOIBPBMPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7795540", Offset = "0x7794940", VA = "0x187795540")]
		public void AKEGKBODIMJ(IKSolverVR.Arm LCMHDAFJMNP, Transform NAGDLAMLEKO, Vector3 HHLCPCGANOB, float OIFDCGLGBEM, Quaternion JOHIIPFHDMH, Vector3 KNJNGDHOBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7796B70", Offset = "0x7795F70", VA = "0x187796B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x77793D0", Offset = "0x77787D0", VA = "0x1877793D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GEHKDDKOMID HDDJMHIPOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x777B540", Offset = "0x777A940", VA = "0x18777B540", Slot = "23")]
		get
		{
			return default(GEHKDDKOMID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration DGIFMCBMNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7776BA0", Offset = "0x7775FA0", VA = "0x187776BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform LCLJFALEIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x77858E0", Offset = "0x7784CE0", VA = "0x1877858E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform MOCPOEICMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7786760", Offset = "0x7785B60", VA = "0x187786760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer EEOJPPIMCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7776770", Offset = "0x7775B70", VA = "0x187776770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] OKBHPPCIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x77760C0", Offset = "0x77754C0", VA = "0x1877760C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] EADAHIALNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7786C80", Offset = "0x7786080", VA = "0x187786C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator JFBAGGBJKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7788650", Offset = "0x7787A50", VA = "0x187788650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK JFMFHKDHHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7786B80", Offset = "0x7785F80", VA = "0x187786B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private DAKFJKMHLMM GONEDGBEAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x777B440", Offset = "0x777A840", VA = "0x18777B440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private DAKFJKMHLMM MJALHJPGFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7787BD0", Offset = "0x7786FD0", VA = "0x187787BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private DAKFJKMHLMM DFGGGDFBINN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7773B90", Offset = "0x7772F90", VA = "0x187773B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private DAKFJKMHLMM CDPBKENOBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7771020", Offset = "0x7770420", VA = "0x187771020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private DAKFJKMHLMM JBAMOAJDLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7782890", Offset = "0x7781C90", VA = "0x187782890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private DAKFJKMHLMM GPONFKFPGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77794D0", Offset = "0x77788D0", VA = "0x1877794D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private DAKFJKMHLMM OODAMLGEFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7773DE0", Offset = "0x77731E0", VA = "0x187773DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private DAKFJKMHLMM DCNLIDHECDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x77872A0", Offset = "0x77866A0", VA = "0x1877872A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DFOFNIFAMPI BLEICLCIEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7776A70", Offset = "0x7775E70", VA = "0x187776A70", Slot = "15")]
		get
		{
			return default(DFOFNIFAMPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EDHLCJGGGBG MPLFFAOGBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xD2E9A0", Offset = "0xD2DDA0", VA = "0x180D2E9A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EGAPJAGIONO IOKHLOAJJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD2EA10", Offset = "0xD2DE10", VA = "0x180D2EA10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public APBOJJNEGEB KBLBNCNJEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1CFF480", Offset = "0x1CFE880", VA = "0x181CFF480", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public APBOJJNEGEB ODOHDKFMEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1CFF470", Offset = "0x1CFE870", VA = "0x181CFF470", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string HDIEEINEIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform FBGIGNKMCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x77776D0", Offset = "0x7776AD0", VA = "0x1877776D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform PBLNJHOMPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x777E710", Offset = "0x777DB10", VA = "0x18777E710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform GEMNMHJCGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77888D0", Offset = "0x7787CD0", VA = "0x1877888D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform JLFNHFMPPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7776620", Offset = "0x7775A20", VA = "0x187776620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform JNHOLLNGGND
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7778C90", Offset = "0x7778090", VA = "0x187778C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool LMMPPCEEDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7773A70", Offset = "0x7772E70", VA = "0x187773A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool KCIKKJFOCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7773A70", Offset = "0x7772E70", VA = "0x187773A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KNJKBMIMPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7777000", Offset = "0x7776400", VA = "0x187777000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform MLAGPNJOJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7787CD0", Offset = "0x77870D0", VA = "0x187787CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject GIIGFIAPGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7776C30", Offset = "0x7776030", VA = "0x187776C30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets CLEFGDLPJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7778070", Offset = "0x7777470", VA = "0x187778070", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform CDPAPEJLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA38CE0", Offset = "0xA380E0", VA = "0x180A38CE0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform PHKCCAEBHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1E20540", Offset = "0x1E1F940", VA = "0x181E20540", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform ECNMLGLKGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xADAAE0", Offset = "0xAD9EE0", VA = "0x180ADAAE0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform BJPNAJLJKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x123F730", Offset = "0x123EB30", VA = "0x18123F730", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 OCDPOKEPCPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7776660", Offset = "0x7775A60", VA = "0x187776660", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float ODKKHKJPFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7787250", Offset = "0x7786650", VA = "0x187787250", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform DBOHNEMHCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7778D50", Offset = "0x7778150", VA = "0x187778D50", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform IFEGLOBMEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2189770", Offset = "0x2188B70", VA = "0x182189770", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform HABNIFBEOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2195480", Offset = "0x2194880", VA = "0x182195480", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CAIFDKBJEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1B0DA40", Offset = "0x1B0CE40", VA = "0x181B0DA40", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool AIPKHMNEGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7787150", Offset = "0x7786550", VA = "0x187787150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool GHLFJLLLBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7785860", Offset = "0x7784C60", VA = "0x187785860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool HFMMCAHMFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x77766F0", Offset = "0x7775AF0", VA = "0x1877766F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x77795D0", Offset = "0x77789D0", VA = "0x1877795D0")]
	private void IOEMIALMBMI([In] KPDOMOAMKCP MFIEBHBJHGH, [In] AvatarFullBodyConfiguration HNFCGGMPMHM, bool LBEOLHDGBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7774640", Offset = "0x7773A40", VA = "0x187774640")]
	private float EGGOKHIGJDI([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7776DD0", Offset = "0x77761D0", VA = "0x187776DD0")]
	private float HDFCJFMHIAA([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x77859E0", Offset = "0x7784DE0", VA = "0x1877859E0")]
	private void NHLIGNMBPIO(KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM, bool LBEOLHDGBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x77838E0", Offset = "0x7782CE0", VA = "0x1877838E0")]
	private void MFDJKAPOBBG([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x777ECF0", Offset = "0x777E0F0", VA = "0x18777ECF0")]
	private void KMOOJOIECAK([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7789C70", Offset = "0x7789070", VA = "0x187789C70")]
	public AGKBBPGDILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7777100", Offset = "0x7776500", VA = "0x187777100", Slot = "12")]
	public void HDNMBPHDHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7772F50", Offset = "0x7772350", VA = "0x187772F50", Slot = "13")]
	public void CBAKONOKKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7770760", Offset = "0x776FB60", VA = "0x187770760", Slot = "14")]
	public void ABIPLPIJBMO(bool PCDNGBDMGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7773C90", Offset = "0x7773090", VA = "0x187773C90", Slot = "25")]
	public Transform DKAFJDOAFDA(string NKODMGPOEPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x77714E0", Offset = "0x77708E0", VA = "0x1877714E0", Slot = "26")]
	public Vector3? BDNNMOHILEP(string NKODMGPOEPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7774AA0", Offset = "0x7773EA0", VA = "0x187774AA0", Slot = "7")]
	public void EPCAFDKMFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7774540", Offset = "0x7773940", VA = "0x187774540")]
	private void EDNBIDBDBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7773EE0", Offset = "0x77732E0", VA = "0x187773EE0")]
	private Vector3 DNFLECNFHHA([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7775280", Offset = "0x7774680", VA = "0x187775280", Slot = "6")]
	public void EPDDMLBIPCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7771150", Offset = "0x7770550", VA = "0x187771150", Slot = "8")]
	public void AJNPGAALLBK(float NAHDGPLGPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x777F320", Offset = "0x777E720", VA = "0x18777F320")]
	private void KPJAIENMICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x777FF20", Offset = "0x777F320", VA = "0x18777FF20", Slot = "4")]
	public void LCGCOIGCKIG(string OFHHLDJLPDA, NKOKBOFABJF HIPBHGICOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x777AFA0", Offset = "0x777A3A0", VA = "0x18777AFA0", Slot = "5")]
	public void JDBPGBAJDBM(DFOFNIFAMPI BKCGHNNBNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x77780F0", Offset = "0x77774F0", VA = "0x1877780F0", Slot = "11")]
	public void HKHAIJJCPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7777720", Offset = "0x7776B20", VA = "0x187777720", Slot = "24")]
	public void HGGMLGAGCIG([Out] Vector3 OLLGPOIFDBE, [Out] Quaternion JOHIIPFHDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7778CD0", Offset = "0x77780D0", VA = "0x187778CD0")]
	private void IDJIFHMJDOP([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x777E750", Offset = "0x777DB50", VA = "0x18777E750", Slot = "27")]
	public void JPJMKAHEAMC(float HNMMHCECPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x77761C0", Offset = "0x77755C0", VA = "0x1877761C0", Slot = "28")]
	public void FDDCGFOHPPC(float FCJOECDLHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7786B30", Offset = "0x7785F30", VA = "0x187786B30", Slot = "44")]
	public void NLKJDJLCHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x777ECA0", Offset = "0x777E0A0", VA = "0x18777ECA0", Slot = "29")]
	public void KHFACAHIHFI(bool EOGFHJJNAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7788F00", Offset = "0x7788300", VA = "0x187788F00", Slot = "30")]
	public HandLogicOffsets PJCBJLNLOFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7777610", Offset = "0x7776A10", VA = "0x187777610", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets HECEDAAODNG()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7771120", Offset = "0x7770520", VA = "0x187771120")]
	private void AIBOGGKGIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7788750", Offset = "0x7787B50", VA = "0x187788750")]
	private void PCEBJENMEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7778F90", Offset = "0x7778390", VA = "0x187778F90")]
	private void IMBIBDCBIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x777E9B0", Offset = "0x777DDB0", VA = "0x18777E9B0")]
	private void KDHPEJCHPGK(FGIODNKADFN FJKPALMOKBI, bool IIGOHJFNEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x777DDB0", Offset = "0x777D1B0", VA = "0x18777DDB0")]
	private void JKOBGAAOCIL(FGIODNKADFN FJKPALMOKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7783890", Offset = "0x7782C90", VA = "0x187783890")]
	public Vector3 LKDDCHGKECE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7770470", Offset = "0x776F870", VA = "0x187770470")]
	private void AAMMHGOALIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7776DB0", Offset = "0x77761B0", VA = "0x187776DB0")]
	private void GNCIEHPFKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7787DD0", Offset = "0x77871D0", VA = "0x187787DD0")]
	private void OLMDDDPECNF(KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7776E50", Offset = "0x7776250", VA = "0x187776E50")]
	private float HDHPEJJILFG([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7776CD0", Offset = "0x77760D0", VA = "0x187776CD0")]
	private int GMABMPGCLCB([In] DIJMGPOHLHK ADPNCMHFIFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x777EDF0", Offset = "0x777E1F0", VA = "0x18777EDF0")]
	private void KOOLPLHFAPH(KPDOMOAMKCP MFIEBHBJHGH, bool JKJLDLCBCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7783150", Offset = "0x7782550", VA = "0x187783150")]
	private static void LENHBJJACKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x777D080", Offset = "0x777C480", VA = "0x18777D080")]
	private static void JIKJEIOHBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7778DB0", Offset = "0x77781B0", VA = "0x187778DB0")]
	private float ILJEJCPMJLJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7773AC0", Offset = "0x7772EC0", VA = "0x187773AC0")]
	private static int DDJNMPLFPED(AGKBBPGDILM KGCKEJLFPJB, AGKBBPGDILM HKELKGIPNGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7771370", Offset = "0x7770770", VA = "0x187771370", Slot = "40")]
	public KPDOMOAMKCP APFGDAKHIHK()
	{
		return default(KPDOMOAMKCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7783350", Offset = "0x7782750", VA = "0x187783350")]
	public void LGEMEHEGCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7776870", Offset = "0x7775C70", VA = "0x187776870")]
	private (bool, bool) FOOLOLJHMCH()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7773890", Offset = "0x7772C90", VA = "0x187773890")]
	private (float, float) DAFBNANGDMP([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x777B640", Offset = "0x777AA40", VA = "0x18777B640")]
	private void JHFBCBFLCJC([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7788F50", Offset = "0x7788350", VA = "0x187788F50")]
	private void PMCMHJIPDCB([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7777AB0", Offset = "0x7776EB0", VA = "0x187777AB0")]
	private void HGPPINEOAII([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM, AvatarFootSettings EIELDECCFNM, bool JBGMGPAKPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7776040", Offset = "0x7775440", VA = "0x187776040")]
	private float FBMIIFINBPM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7771670", Offset = "0x7770A70", VA = "0x187771670")]
	private void BGLDDHPOEFI(KPDOMOAMKCP DHJOIBPBMPI, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7778D00", Offset = "0x7778100", VA = "0x187778D00")]
	private float IJCBJBCNBPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x77833D0", Offset = "0x77827D0", VA = "0x1877833D0")]
	private void LHJPOAMJFLL([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7786480", Offset = "0x7785880", VA = "0x187786480")]
	private void NJBIHEJHFMO([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7785220", Offset = "0x7784620", VA = "0x187785220")]
	private void NCGBMCNAEOE([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7784190", Offset = "0x7783590", VA = "0x187784190")]
	private void MNDFFPOGOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x777E760", Offset = "0x777DB60", VA = "0x18777E760")]
	private void KBJKMJPAICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7777ED0", Offset = "0x77772D0", VA = "0x187777ED0")]
	private void HIFLKMNJELK([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x77846E0", Offset = "0x7783AE0", VA = "0x1877846E0")]
	private void NCBOAEKCPNC(KBBMLEHBPBD OGKJGEDOCHH, IKSolverVR.Arm LCMHDAFJMNP, Transform EJDCPJCBFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7782500", Offset = "0x7781900", VA = "0x187782500")]
	private void LDGNAFBLBNI(KPDOMOAMKCP DHJOIBPBMPI, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7784510", Offset = "0x7783910", VA = "0x187784510")]
	private void MOJBPHJHEJI(OLHEIENPJAM LFHECPBHJLI, APBOJJNEGEB OGKJGEDOCHH, IKSolverVR.Arm LCMHDAFJMNP, float BLFJEGJJBFG, float JBLJNMLIKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7772950", Offset = "0x7771D50", VA = "0x187772950")]
	private void CALIKNNNBIH([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7786D80", Offset = "0x7786180", VA = "0x187786D80")]
	protected void OCEMMJJIDEC([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7786860", Offset = "0x7785C60", VA = "0x187786860")]
	private void NLFEDAOOHBE([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7785610", Offset = "0x7784A10", VA = "0x187785610")]
	protected void NCNGMDNLFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x77873A0", Offset = "0x77867A0", VA = "0x1877873A0")]
	private void OIFGCLHMLCP([In] KPDOMOAMKCP DHJOIBPBMPI, [In] OKCPPNLOCMD ECCFEKEGACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x777F370", Offset = "0x777E770", VA = "0x18777F370")]
	private void LAGPDOLKPMP(KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7788EC0", Offset = "0x77882C0", VA = "0x187788EC0")]
	private void PHOMDLAMHMD([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7788900", Offset = "0x7787D00", VA = "0x187788900")]
	private Vector3 PDKDGOPHODI([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7784440", Offset = "0x7783840", VA = "0x187784440")]
	private void MNDFLMEHEMH([In] KPDOMOAMKCP DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7785E40", Offset = "0x7785240", VA = "0x187785E40")]
	private float NIPKFGEGDFH(float NACECBLGLON, [In] KPDOMOAMKCP DHJOIBPBMPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7772800", Offset = "0x7771C00", VA = "0x187772800")]
	private void BMPCLEMBKPK(float NACECBLGLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7783AA0", Offset = "0x7782EA0", VA = "0x187783AA0")]
	private void MKOKOBNGNJC([In] KPDOMOAMKCP DHJOIBPBMPI, OKCPPNLOCMD ECCFEKEGACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7782990", Offset = "0x7781D90", VA = "0x187782990")]
	private float LEJEIHLDCFK([In] KPDOMOAMKCP MFIEBHBJHGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7770830", Offset = "0x776FC30", VA = "0x187770830")]
	private void ADCIMDNBHCG(KPDOMOAMKCP DHJOIBPBMPI, OKCPPNLOCMD ECCFEKEGACH, Vector3 HJAMNHBOHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x77711C0", Offset = "0x77705C0", VA = "0x1877711C0")]
	private static void ALCECFJOJLJ(Transform KHDOKFIGIID, Quaternion AJFJKBHPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7775D10", Offset = "0x7775110", VA = "0x187775D10")]
	private void FAGJJIAFKLL([In] KPDOMOAMKCP FPEANNOHINP, [In] DIJMGPOHLHK ADPNCMHFIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7784970", Offset = "0x7783D70", VA = "0x187784970")]
	private void NCFOKAIGHEL([In] KPDOMOAMKCP FPEANNOHINP, [In] DIJMGPOHLHK ADPNCMHFIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7786290", Offset = "0x7785690", VA = "0x187786290")]
	private void NJADCACPEDF(float KDAECIFJIHB, [In] KPDOMOAMKCP MFIEBHBJHGH, float HLEMKGLLJDM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x777DF40", Offset = "0x777D340", VA = "0x18777DF40")]
	private float JOCINCEGLCG([In] KPDOMOAMKCP MFIEBHBJHGH, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7773310", Offset = "0x7772710", VA = "0x187773310")]
	private void CCNAODECDMP([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7778250", Offset = "0x7777650", VA = "0x187778250")]
	private void IBGKODBHCFD([In] KPDOMOAMKCP MFIEBHBJHGH, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x77746D0", Offset = "0x7773AD0", VA = "0x1877746D0")]
	private void EOMBNDPMCCF([In] KPDOMOAMKCP MFIEBHBJHGH, float BDOPBBNAPIC, float OOBGNHFCMPF, Vector3 PAPBOFGFMFF, float HLEMKGLLJDM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x777F520", Offset = "0x777E920", VA = "0x18777F520")]
	private void LBBLAFKDEJJ(KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7773600", Offset = "0x7772A00", VA = "0x187773600")]
	private void CLDJCIKCKMA(KPDOMOAMKCP DHJOIBPBMPI, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7774060", Offset = "0x7773460", VA = "0x187774060")]
	private void DOJCONPLJGA(KPDOMOAMKCP MFIEBHBJHGH, AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7772640", Offset = "0x7771A40", VA = "0x187772640")]
	public void BMHJLMAMPJH([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7782190", Offset = "0x7781590", VA = "0x187782190")]
	public void LCOJBAKLJPO([In] KPDOMOAMKCP DHJOIBPBMPI, [In] AvatarFullBodyConfiguration HNFCGGMPMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x77743A0", Offset = "0x77737A0", VA = "0x1877743A0")]
	[CompilerGenerated]
	internal static void EDGPFPHCPLL(Transform IEAOMLJNJLM, IKSolverVR.Arm LCMHDAFJMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7788E10", Offset = "0x7788210", VA = "0x187788E10")]
	[CompilerGenerated]
	internal static void PHOAIMILADK(Vector3 PFCFCNFONJL, Vector3 PJODGPHCLLB, EPPKEMKNFDB P_2, KFAODICGGAD P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7773AF0", Offset = "0x7772EF0", VA = "0x187773AF0")]
	[CompilerGenerated]
	internal static void DFDFFFMECDP(LHMKMCFEGNN CNDHPHFDEGP, LHMKMCFEGNN EMAKNCJGAPB, Vector3 DHGCOICCBCL, float AFHGIBDEPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7776510", Offset = "0x7775910", VA = "0x187776510")]
	[CompilerGenerated]
	internal static bool FELFKDGOPGP(IKSolverVR.Arm LCMHDAFJMNP, MJHCLFFGKLN OMLNJEFBNLA, float DAPLPMBCCFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7772200", Offset = "0x7771600", VA = "0x187772200")]
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
	[Cpp2IlInjected.Address(RVA = "0x7797450", Offset = "0x7796850", VA = "0x187797450")]
	[NOCPMGCIOME.CBODKAAMPCM]
	internal static void LGFHJPGNODF(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7797230", Offset = "0x7796630", VA = "0x187797230", Slot = "4")]
	public OHGFGGMFLAM JBDPCCAPANL(string KNLNHFBBNLF, AvatarSystemConfiguration LOKJMMPMKLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7797050", Offset = "0x7796450", VA = "0x187797050", Slot = "5")]
	public void GMFLMMMFDLD(string KNLNHFBBNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7796F10", Offset = "0x7796310", VA = "0x187796F10", Slot = "6")]
	public string AFIKJDLIGKN(string LAIPGODCECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x77974C0", Offset = "0x77968C0", VA = "0x1877974C0")]
	private string MPMLAIMDPML(string LAIPGODCECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7797530", Offset = "0x7796930", VA = "0x187797530")]
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
				[Cpp2IlInjected.Address(RVA = "0x7796CC0", Offset = "0x77960C0", VA = "0x187796CC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7796D50", Offset = "0x7796150", VA = "0x187796D50")]
			public void HFPBHANLJLH(VRIK DICOKLNCFCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
			public void OBDKCKPAKIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7796D00", Offset = "0x7796100", VA = "0x187796D00")]
			public void GCJCJGLHJHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7796E80", Offset = "0x7796280", VA = "0x187796E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7791D70", Offset = "0x7791170", VA = "0x187791D70")]
		private void GDCNGOALEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7791D20", Offset = "0x7791120", VA = "0x187791D20")]
		private bool BCAOFGJMJKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7792050", Offset = "0x7791450", VA = "0x187792050")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x77920C0", Offset = "0x77914C0", VA = "0x1877920C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7792060", Offset = "0x7791460", VA = "0x187792060")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7792330", Offset = "0x7791730", VA = "0x187792330")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7794AF0", Offset = "0x7793EF0", VA = "0x187794AF0")]
			public void BECHPFCMIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7794BD0", Offset = "0x7793FD0", VA = "0x187794BD0")]
			public (float, float) CNHBCMELOCC(Animator GONCFDEOKGC, AnimatorStateInfo NOILPEONCGL)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x7794D10", Offset = "0x7794110", VA = "0x187794D10")]
		public void BECHPFCMIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x77950F0", Offset = "0x77944F0", VA = "0x1877950F0")]
		public (float, float) HMKJHCGLGNI(Animator GONCFDEOKGC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7794F00", Offset = "0x7794300", VA = "0x187794F00")]
		private (float, float) CEHLKMHMIBL(Animator GONCFDEOKGC, AnimatorStateInfo NOILPEONCGL)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7795300", Offset = "0x7794700", VA = "0x187795300")]
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
		[Cpp2IlInjected.Address(RVA = "0x779ADB0", Offset = "0x779A1B0", VA = "0x18779ADB0", Slot = "4")]
		public override void OnStateEnter(Animator GONCFDEOKGC, AnimatorStateInfo NOILPEONCGL, int ILOBPOODEIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x779AF10", Offset = "0x779A310", VA = "0x18779AF10")]
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
	[Cpp2IlInjected.Address(RVA = "0x530BF90", Offset = "0x530B390", VA = "0x18530BF90")]
	protected PEOLILLNNGA(ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput HFAEDKNMEEN(TInput PJCOHHCODGF, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x530BEF0", Offset = "0x530B2F0", VA = "0x18530BEF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7794700", Offset = "0x7793B00", VA = "0x187794700")]
	public static FAKCGGBDOGH BLFCLAOHGFG(LALAGECKOGA FJPDHEKILDP, PECGMKADMMG BDLNICBMKMP, Guid? LMGCOEEBLBC, Color? AEMFOIHKBPM, IDINMFOPJOG OFBICLFFJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x77945A0", Offset = "0x77939A0", VA = "0x1877945A0")]
	public static FEJKALOKOAI AKCBJHDFIKG(FAKCGGBDOGH HPMNBNLACCC)
	{
		return default(FEJKALOKOAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3607030", Offset = "0x3606430", VA = "0x183607030")]
	internal static TModern? IPEKAODCNHD<TModern>(string? PJCOHHCODGF, CHOCLPPHKEE<TModern> HKHCADCPLDM, ENCEHJNHPBL HKNGEHEEHMP, KLJLCKNDCOJ PGKDFMFJCBL, TModern GEKFCDAJGMG) where TModern : struct, OOBOEDGJKIN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3606850", Offset = "0x3605C50", VA = "0x183606850")]
	internal static OAFOHPOELEF IIKGIICKJGO<TModern>(string? PJCOHHCODGF, CHOCLPPHKEE<TModern> HKHCADCPLDM, ENCEHJNHPBL HKNGEHEEHMP, KLJLCKNDCOJ PGKDFMFJCBL, TModern GEKFCDAJGMG) where TModern : struct, OOBOEDGJKIN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7794910", Offset = "0x7793D10", VA = "0x187794910")]
	internal static List<JLODCGNCFMB> OKKFOGPLDCI(IEnumerable<KOHEBNEONED>? IBFKIAPMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3608680", Offset = "0x3607A80", VA = "0x183608680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x77926A0", Offset = "0x7791AA0", VA = "0x1877926A0")]
	[UsedImplicitly]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	internal static void LCLELILMCHI(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7792710", Offset = "0x7791B10", VA = "0x187792710")]
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
	[Cpp2IlInjected.Address(RVA = "0x7796C30", Offset = "0x7796030", VA = "0x187796C30")]
	public JPMBMDNPLGA(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7796C60", Offset = "0x7796060", VA = "0x187796C60")]
	public JPMBMDNPLGA(string DAMFJFKKFBI, Exception HIFFMIIALED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7796C90", Offset = "0x7796090", VA = "0x187796C90")]
	public JPMBMDNPLGA(NDGCAOKKIGI BMBMKKHEAHH, string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7796BF0", Offset = "0x7795FF0", VA = "0x187796BF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x77911B0", Offset = "0x77905B0", VA = "0x1877911B0")]
	protected DEMLFILFAPL(NMGHNPBEPOC KLABIPAOBNI, IKKNLBGAIJE JJHCKCDCEDH, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7793190", Offset = "0x7792590", VA = "0x187793190")]
	protected string GIEANBCIEMK(FKAIDAOIGIH IGGKLFCOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7792FA0", Offset = "0x77923A0", VA = "0x187792FA0")]
	protected string DEHFNFFHNMG(FKAIDAOIGIH IGGKLFCOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7792C70", Offset = "0x7792070", VA = "0x187792C70")]
	private AvatarOutfitSelectionData BLFCLAOHGFG(FAKCGGBDOGH MMPOOFEEMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7794460", Offset = "0x7793860", VA = "0x187794460")]
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
	[Cpp2IlInjected.Address(RVA = "0x77908F0", Offset = "0x778FCF0", VA = "0x1877908F0")]
	public AAPNAHMOEEO(NMGHNPBEPOC KLABIPAOBNI, IKKNLBGAIJE JJHCKCDCEDH, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7790650", Offset = "0x778FA50", VA = "0x187790650", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x7795430", Offset = "0x7794830", VA = "0x187795430", Slot = "9")]
		public override void WriteJson(JsonWriter CEAJPINGICH, OAFOHPOELEF? FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7795310", Offset = "0x7794710", VA = "0x187795310", Slot = "10")]
		public override OAFOHPOELEF ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, OAFOHPOELEF? IAGJKNIMAKN, bool POLAJMAPPCG, JsonSerializer ILLAJGPAKHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x77954D0", Offset = "0x77948D0", VA = "0x1877954D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7797980", Offset = "0x7796D80", VA = "0x187797980", Slot = "5")]
		public override object ReadJson(JsonReader HGFGHNJEEAJ, Type NILLICCLHIK, object? IAGJKNIMAKN, JsonSerializer ILLAJGPAKHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x77977A0", Offset = "0x7796BA0", VA = "0x1877977A0", Slot = "6")]
		public override bool CanConvert(Type NILLICCLHIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x77979E0", Offset = "0x7796DE0", VA = "0x1877979E0", Slot = "4")]
		public override void WriteJson(JsonWriter CEAJPINGICH, object? FFOEEMKIKJO, JsonSerializer ILLAJGPAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x77975C0", Offset = "0x77969C0", VA = "0x1877975C0")]
		private static bool AFNGLKNFPLL(object FFOEEMKIKJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public LCKLJNLJCMJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly JsonSerializerSettings JLDKPAAABKO;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x779B3C0", Offset = "0x779A7C0", VA = "0x18779B3C0")]
	internal PDIIKNJEIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3820F90", Offset = "0x3820390", VA = "0x183820F90", Slot = "4")]
	public string FDLDHAOIFJM<T>(T BLFGIKOAKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3820F00", Offset = "0x3820300", VA = "0x183820F00", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x37D4BF0", Offset = "0x37D3FF0", VA = "0x1837D4BF0", Slot = "4")]
	public string FDLDHAOIFJM<T>(T BLFGIKOAKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x37D4B70", Offset = "0x37D3F70", VA = "0x1837D4B70", Slot = "5")]
	public T AGHKMDPJHOK<T>(string FFOEEMKIKJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x779AC70", Offset = "0x779A070", VA = "0x18779AC70")]
	public LOEIGANIIJD(NMGHNPBEPOC KLABIPAOBNI, IKKNLBGAIJE JJHCKCDCEDH, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7799500", Offset = "0x7798900", VA = "0x187799500", Slot = "6")]
	public override BIAHFMGAOCL HFAEDKNMEEN(CNAEMFJKIGO PJCOHHCODGF, [Out] IReadOnlyList<JLODCGNCFMB>? DOEAEOCODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x779AB20", Offset = "0x7799F20", VA = "0x18779AB20")]
	internal void OGLFPCEDMFB(string AGCBNPEKJNA, FKAIDAOIGIH IGGKLFCOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x779A870", Offset = "0x7799C70", VA = "0x18779A870")]
	public IEnumerable<FAKCGGBDOGH> OCCJAGJHDBP(string BMJFOMOIGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x77990F0", Offset = "0x77984F0", VA = "0x1877990F0")]
	private IEnumerable<FAKCGGBDOGH> GIJDPJFBMFL(string BMJFOMOIGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x779A2C0", Offset = "0x77996C0", VA = "0x18779A2C0")]
	internal IEnumerable<FAKCGGBDOGH> MIFJPNEADDA(string BMJFOMOIGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7799920", Offset = "0x7798D20", VA = "0x187799920")]
	private FAKCGGBDOGH HPKFFFDBLII(AvatarOutfitSelectionData PBKKOKKLJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7798870", Offset = "0x7797C70", VA = "0x187798870")]
	private void DNLLOKGJLNO(AvatarCustomizationSettingsData ILIFELFMNEJ, FKAIDAOIGIH IGGKLFCOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7799CA0", Offset = "0x77990A0", VA = "0x187799CA0")]
	private FAKCGGBDOGH HPKFFFDBLII(string PENKNNBAFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7799FC0", Offset = "0x77993C0", VA = "0x187799FC0")]
	internal static (IDINMFOPJOG, string, string) KGBPJKGEEFD(string PENKNNBAFNA, ENCEHJNHPBL HKNGEHEEHMP)
	{
		return default((IDINMFOPJOG, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x779A920", Offset = "0x7799D20", VA = "0x18779A920")]
	private ICDNLIPEIMO? OFBGCMEKLJA(string? KDBHLLEACIN, Vector2 MKJEPMILFBJ, float PBGGIDHPDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x779A710", Offset = "0x7799B10", VA = "0x18779A710")]
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
	[Cpp2IlInjected.Address(RVA = "0x77911B0", Offset = "0x77905B0", VA = "0x1877911B0")]
	public AKDKAMHOOAJ(NMGHNPBEPOC KLABIPAOBNI, IKKNLBGAIJE JJHCKCDCEDH, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7790E00", Offset = "0x7790200", VA = "0x187790E00", Slot = "4")]
	public KBKDBBKOBJO PELCBGJOJPC(FKAIDAOIGIH HPMNBNLACCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7790AC0", Offset = "0x778FEC0", VA = "0x187790AC0")]
	private string HAOJLEHGOBH(FKAIDAOIGIH IGGKLFCOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7790BC0", Offset = "0x778FFC0", VA = "0x187790BC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x779B950", Offset = "0x779AD50", VA = "0x18779B950")]
	public POPEMNKELEL(LMBLCGDOFNF<CNAEMFJKIGO, BIAHFMGAOCL> EIGGBAMOBLN, ENCEHJNHPBL HKNGEHEEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x779B520", Offset = "0x779A920", VA = "0x18779B520", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x779B2D0", Offset = "0x779A6D0", VA = "0x18779B2D0")]
	public NNJMHEMOLEF(MKDFFABAFDM DNKJNCIIDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x779AF30", Offset = "0x779A330", VA = "0x18779AF30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x77913E0", Offset = "0x77907E0", VA = "0x1877913E0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BCLKCLOLOBE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7792470", Offset = "0x7791870", VA = "0x187792470")]
	public static FEJKALOKOAI HFAEDKNMEEN(this GJGJNGDGGDM HPMNBNLACCC)
	{
		return default(FEJKALOKOAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7792580", Offset = "0x7791980", VA = "0x187792580")]
	public static GJGJNGDGGDM PELCBGJOJPC(this FEJKALOKOAI LEEGMHDKJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7792410", Offset = "0x7791810", VA = "0x187792410")]
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
			[Cpp2IlInjected.Address(RVA = "0x590C720", Offset = "0x590BB20", VA = "0x18590C720")]
			public AnchorParams(Vector2 NEMCEGFJAMM, Vector3 JJFMMKBGHBD, Vector3 CEGIKJLFFBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x7791330", Offset = "0x7790730", VA = "0x187791330")]
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
			[Cpp2IlInjected.Address(RVA = "0x7791BD0", Offset = "0x7790FD0", VA = "0x187791BD0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x42FED70", Offset = "0x42FE170", VA = "0x1842FED70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xC0FC20", Offset = "0xC0F020", VA = "0x180C0FC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xE5C2C0", Offset = "0xE5B6C0", VA = "0x180E5C2C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x11CC860", Offset = "0x11CBC60", VA = "0x1811CC860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7791C70", Offset = "0x7791070", VA = "0x187791C70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x9B0020", Offset = "0x9AF420", VA = "0x1809B0020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xB4D0F0", Offset = "0xB4C4F0", VA = "0x180B4D0F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xB4D5E0", Offset = "0xB4C9E0", VA = "0x180B4D5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x9AA5C0", Offset = "0x9A99C0", VA = "0x1809AA5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x7791CB0", Offset = "0x77910B0", VA = "0x187791CB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xD819F0", Offset = "0xD80DF0", VA = "0x180D819F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xFBE920", Offset = "0xFBDD20", VA = "0x180FBE920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x1636E00", Offset = "0x1636200", VA = "0x181636E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A40", Offset = "0x9A8E40", VA = "0x1809A9A40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A90", Offset = "0x9A8E90", VA = "0x1809A9A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x2146BD0", Offset = "0x2145FD0", VA = "0x182146BD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD9F9E0", Offset = "0xD9EDE0", VA = "0x180D9F9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9E1010", Offset = "0x9E0410", VA = "0x1809E1010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9E1070", Offset = "0x9E0470", VA = "0x1809E1070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x9AE420", Offset = "0x9AD820", VA = "0x1809AE420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4E0", Offset = "0x9AD8E0", VA = "0x1809AE4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4D0", Offset = "0x9AD8D0", VA = "0x1809AE4D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9AE4F0", Offset = "0x9AD8F0", VA = "0x1809AE4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9AE5B0", Offset = "0x9AD9B0", VA = "0x1809AE5B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9AE550", Offset = "0x9AD950", VA = "0x1809AE550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB232B0", Offset = "0xB226B0", VA = "0x180B232B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x11F1080", Offset = "0x11F0480", VA = "0x1811F1080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9AE450", Offset = "0x9AD850", VA = "0x1809AE450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9AE520", Offset = "0x9AD920", VA = "0x1809AE520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xC35E10", Offset = "0xC35210", VA = "0x180C35E10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xDAB2F0", Offset = "0xDAA6F0", VA = "0x180DAB2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x9B2A70", Offset = "0x9B1E70", VA = "0x1809B2A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9B2AD0", Offset = "0x9B1ED0", VA = "0x1809B2AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB6DE10", Offset = "0xB6D210", VA = "0x180B6DE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xDB0000", Offset = "0xDAF400", VA = "0x180DB0000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xBD2580", Offset = "0xBD1980", VA = "0x180BD2580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xBCE5F0", Offset = "0xBCD9F0", VA = "0x180BCE5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public HPMNLDEHFIP UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xE61E60", Offset = "0xE61260", VA = "0x180E61E60")]
			get
			{
				return default(HPMNLDEHFIP);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xE61720", Offset = "0xE60B20", VA = "0x180E61720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xE60480", Offset = "0xE5F880", VA = "0x180E60480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB1D850", Offset = "0xB1CC50", VA = "0x180B1D850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x7791C90", Offset = "0x7791090", VA = "0x187791C90")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7791CD0", Offset = "0x77910D0", VA = "0x187791CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7791870", Offset = "0x7790C70", VA = "0x187791870")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x7791CF0", Offset = "0x77910F0", VA = "0x187791CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
