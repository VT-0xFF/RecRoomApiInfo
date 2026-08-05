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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x81ACF60", Offset = "0x81AB960", VA = "0x1881ACF60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
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
		[Cpp2IlInjected.Address(RVA = "0x81AF2E0", Offset = "0x81ADCE0", VA = "0x1881AF2E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[IHCCCAONNEJ]
internal class BDAHCGPJEHN : HOFIHHKPMCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct IPEJDNMLLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public BDAHCGPJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public EAJLGMHEHMA avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JALKHBLCIMF GPHBHOMEIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PLBHBOKDDBB HPGNGONPADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ENNJHPPJHKH AJKFHJAPIHN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8190DD0", Offset = "0x818F7D0", VA = "0x188190DD0")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	[UsedImplicitly]
	internal static void DAINBFAPMJK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8192560", Offset = "0x8190F60", VA = "0x188192560")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BDAHCGPJEHN([LNLOHEINMEO(null)] JALKHBLCIMF GPHBHOMEIBC, [LNLOHEINMEO(null)] PLBHBOKDDBB HPGNGONPADB, [LNLOHEINMEO(null)] ENNJHPPJHKH AJKFHJAPIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8191190", Offset = "0x818FB90", VA = "0x188191190", Slot = "5")]
	public ALIGCGMOICI HIJPEHJOFBC(EAJLGMHEHMA LMJNBBKIBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8191A60", Offset = "0x8190460", VA = "0x188191A60", Slot = "4")]
	public ALIGCGMOICI PMGANNDBFGG(EAJLGMHEHMA LMJNBBKIBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8190FF0", Offset = "0x818F9F0", VA = "0x188190FF0", Slot = "6")]
	public JDJOPBCDFGB GKEHPLNCLNC(ALIGCGMOICI GPCDCFCPGFK, int DOBBKHLICOG, string? FLBFBHGDBLM, string? LPDPLPHIDEM, MNNPGENBKHF HKPCIADPKMN, List<PEIDCEBGHBD>? EMGBIJEAFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8191100", Offset = "0x818FB00", VA = "0x188191100", Slot = "7")]
	public bool GNOJDFOAIFF(AEHBGLJGGKB EDDBHNEKABH, [Out] ALIGCGMOICI? OENIAJKILAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8190C60", Offset = "0x818F660", VA = "0x188190C60", Slot = "8")]
	public bool ANMMFBEHJCH(JDJOPBCDFGB KHJPCIFPDCG, [Out] ALIGCGMOICI? OENIAJKILAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8190D40", Offset = "0x818F740", VA = "0x188190D40", Slot = "9")]
	public bool CGAGFEDBJCC(JDJOPBCDFGB KHJPCIFPDCG, [Out] INCBHDFIGGD? EDDBHNEKABH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x39F9880", Offset = "0x39F8280", VA = "0x1839F9880")]
	private bool HIEGMECPOCL<TInput, TOutput>(TInput GMLILPJAKBM, MCJKICHGNLJ<TInput, TOutput> PNLHDEEAAHE, [Out] TOutput? AEAMJGPOBKI) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8190E40", Offset = "0x818F840", VA = "0x188190E40")]
	[CompilerGenerated]
	private IAAJKOODCHI FKONENKLHKD(FaceFeatureType NJDKDEBMHAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8190A80", Offset = "0x818F480", VA = "0x188190A80")]
	[CompilerGenerated]
	private IAAJKOODCHI ADGKPLKFEGP(FaceFeatureType NJDKDEBMHAP, IPEJDNMLLMB P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[IHCCCAONNEJ]
internal class PCFJBHFADLI : JALKHBLCIMF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void NFKFCEHIKAF<in TData>(TData OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NCJLBAPELAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public PKBPDJJKAAJ rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JCKAKKKMCIJ currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JCKAKKKMCIJ latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NCJLBAPELAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81ACEC0", Offset = "0x81AB8C0", VA = "0x1881ACEC0")]
		internal bool MHADMOOLHBP(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81ACEE0", Offset = "0x81AB8E0", VA = "0x1881ACEE0")]
		internal bool NOICJJMFIFI(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly ENNJHPPJHKH AJKFHJAPIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JBEAJCDGOAE FHJFJFFNNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NFKFCEHIKAF<ALIGCGMOICI>?[] GPHBHOMEIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NFKFCEHIKAF<INCBHDFIGGD>?[] PCGBCOHOALG;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81AD300", Offset = "0x81ABD00", VA = "0x1881AD300")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	[UsedImplicitly]
	internal static void DAINBFAPMJK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x81AEBF0", Offset = "0x81AD5F0", VA = "0x1881AEBF0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PCFJBHFADLI([LNLOHEINMEO(null)] ENNJHPPJHKH AJKFHJAPIHN, [LNLOHEINMEO(null)] JBEAJCDGOAE FHJFJFFNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81ADD70", Offset = "0x81AC770", VA = "0x1881ADD70", Slot = "4")]
	public bool LNEFKPGONHK(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81ADE70", Offset = "0x81AC870", VA = "0x1881ADE70", Slot = "5")]
	public bool LNEFKPGONHK(INCBHDFIGGD EDDBHNEKABH, IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81ADFD0", Offset = "0x81AC9D0", VA = "0x1881ADFD0")]
	private void MEADOEKEJIK(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81AD7B0", Offset = "0x81AC1B0", VA = "0x1881AD7B0")]
	private void JJALMAJFDLC(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81AD780", Offset = "0x81AC180", VA = "0x1881AD780")]
	private void HPENCIHEPBM(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81AEBC0", Offset = "0x81AD5C0", VA = "0x1881AEBC0")]
	private void OHECIOPINMP(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81AD370", Offset = "0x81ABD70", VA = "0x1881AD370")]
	private void EIOJGHNPIFF(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x81ADCC0", Offset = "0x81AC6C0", VA = "0x1881ADCC0")]
	private void KHBGCHBEBEH(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81AD690", Offset = "0x81AC090", VA = "0x1881AD690")]
	private void HAHBPOOALIN(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x81AD2C0", Offset = "0x81ABCC0", VA = "0x1881AD2C0")]
	private void BOPPOAMFGMC(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x81AD2D0", Offset = "0x81ABCD0", VA = "0x1881AD2D0")]
	private void CIGOPEHNGDL(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81AD440", Offset = "0x81ABE40", VA = "0x1881AD440")]
	private void GFBENDPIHNB(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? GIGDEGEMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81ACFE0", Offset = "0x81AB9E0", VA = "0x1881ACFE0")]
	private void AIKLEFNGANM(ALIGCGMOICI OENIAJKILAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81AD9E0", Offset = "0x81AC3E0", VA = "0x1881AD9E0")]
	private ALIGCGMOICI JMDFGHMODJF(ALIGCGMOICI OENIAJKILAH, List<RangeMigration> LNBANHCILKH, JCKAKKKMCIJ NFNPLMJGJCK, JCKAKKKMCIJ MIOHMIDCOBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x81AD740", Offset = "0x81AC140", VA = "0x1881AD740")]
	private float HHCOCICMBGE(float HJDOCDFMDPK, Vector2 ABBFPDLCOCM, Vector2 OIOOKPLJOHL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x81AD4C0", Offset = "0x81ABEC0", VA = "0x1881AD4C0")]
	private (RangeMigration?, RangeMigration?) GHEFKBJEKIM(List<RangeMigration> ADAPABEIPDN, PKBPDJJKAAJ NEIKIKCJMGP, JCKAKKKMCIJ NFNPLMJGJCK, JCKAKKKMCIJ MIOHMIDCOBB)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JALKHBLCIMF
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNEFKPGONHK(ALIGCGMOICI OENIAJKILAH, IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LNEFKPGONHK(INCBHDFIGGD EDDBHNEKABH, IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI);
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
		public DIDNDKMHLCC AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x818E5D0", Offset = "0x818CFD0", VA = "0x18818E5D0")]
		public void GJLHFKDGKMJ(AnimationPoseSetting EFNHKCDKOGH, float EKHMFBPDKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x818E700", Offset = "0x818D100", VA = "0x18818E700")]
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
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x818F010", Offset = "0x818DA10", VA = "0x18818F010")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x818EFD0", Offset = "0x818D9D0", VA = "0x18818EFD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x818E720", Offset = "0x818D120", VA = "0x18818E720")]
		private void GEEGFCHOJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8119EA0", Offset = "0x81188A0", VA = "0x188119EA0", Slot = "4")]
		public void SetEnabled(bool DKBBOMHPGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x818F040", Offset = "0x818DA40", VA = "0x18818F040")]
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
		[Cpp2IlInjected.Address(RVA = "0x818F080", Offset = "0x818DA80", VA = "0x18818F080")]
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
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
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

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x818F100", Offset = "0x818DB00", VA = "0x18818F100")]
		public AnimationPoseSetting DJHIOCIGEOI(DIDNDKMHLCC OGHKBNGDLBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x818F0C0", Offset = "0x818DAC0", VA = "0x18818F0C0")]
		public void CEKLAJMLNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x818F130", Offset = "0x818DB30", VA = "0x18818F130")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum COPNBEEHJPH
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private COPNBEEHJPH handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x818FC40", Offset = "0x818E640", VA = "0x18818FC40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x818FC00", Offset = "0x818E600", VA = "0x18818FC00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x818F5E0", Offset = "0x818DFE0", VA = "0x18818F5E0")]
		private void GEEGFCHOJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8119EA0", Offset = "0x81188A0", VA = "0x188119EA0", Slot = "4")]
		public void SetEnabled(bool DKBBOMHPGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x818FC70", Offset = "0x818E670", VA = "0x18818FC70")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, OCCLLAKDGIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private EAJLGMHEHMA avatarBodyType;

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
		[OICBHOIKJDP(MGLGMLBODOF.SelfAndChildren, false, false, false)]
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
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
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
		[SerializeField]
		[Header("Arm Animation Controllers")]
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
		[SerializeField]
		[Header("Facial Animation")]
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
		private JELDKIPDDKE BKABKLPICND;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JELDKIPDDKE AFCIBOCAOBK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xBF3250", Offset = "0xBF1C50", VA = "0x180BF3250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform HPEFFMPFLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8190A60", Offset = "0x818F460", VA = "0x188190A60", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x818FCA0", Offset = "0x818E6A0", VA = "0x18818FCA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8190920", Offset = "0x818F320", VA = "0x188190920")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81908D0", Offset = "0x818F2D0", VA = "0x1881908D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8190860", Offset = "0x818F260", VA = "0x188190860")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x818FCA0", Offset = "0x818E6A0", VA = "0x18818FCA0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8190030", Offset = "0x818EA30", VA = "0x188190030", Slot = "6")]
		public JELDKIPDDKE CreateAvatarSystem(string HCNBMBFBNPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8190860", Offset = "0x818F260", VA = "0x188190860", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x818FD60", Offset = "0x818E760", VA = "0x18818FD60", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8190970", Offset = "0x818F370", VA = "0x188190970", Slot = "9")]
		public void UpdatePostIKAnimControllers(float NIHEEOMEEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HIGJHONEFHK : JELDKIPDDKE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class MIEEIJHKOCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 NGIEDOFPOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion LGDPKNJEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 EKKAOIFIIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Transform IOKDLDHCJLP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 EGNDKPKDEDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x21D24C0", Offset = "0x21D0EC0", VA = "0x1821D24C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x21D24E0", Offset = "0x21D0EE0", VA = "0x1821D24E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion GNHPLILALOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x15D2A00", Offset = "0x15D1400", VA = "0x1815D2A00")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x15D2600", Offset = "0x15D1000", VA = "0x1815D2600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float GIPAEEABPLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x125C220", Offset = "0x125AC20", VA = "0x18125C220")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x19CCB10", Offset = "0x19CB510", VA = "0x1819CCB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool FAHFIOFLHPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA91C40", Offset = "0xA90640", VA = "0x180A91C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA91C60", Offset = "0xA90660", VA = "0x180A91C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool LCEFFNJLEHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA91AA0", Offset = "0xA904A0", VA = "0x180A91AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA91C20", Offset = "0xA90620", VA = "0x180A91C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool CMDFLIHEPJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA91C50", Offset = "0xA90650", VA = "0x180A91C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA91AB0", Offset = "0xA904B0", VA = "0x180A91AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float OADAAMOEJLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xDD1980", Offset = "0xDD0380", VA = "0x180DD1980")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xDD2400", Offset = "0xDD0E00", VA = "0x180DD2400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x81BA600", Offset = "0x81B9000", VA = "0x1881BA600")]
		public void PNPBJABNBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x81B9D00", Offset = "0x81B8700", VA = "0x1881B9D00")]
		public void JGPADNPFOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x81BA3F0", Offset = "0x81B8DF0", VA = "0x1881BA3F0")]
		public float MCHEAMGEEAH(Vector3 DBBJPGECOLB, Quaternion OJKIMKFJCOM, [In] AvatarFootSettings KFMPAIBNIGG, float HKIKLCOFNCI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x81B9D10", Offset = "0x81B8710", VA = "0x1881B9D10")]
		public void LJEMGEPIEOP(Vector3 NDGKPAJNBGI, Quaternion GEMKDGFEDKG, Transform BIEIHEDFBHE, float PEEEPMNIMII, bool MAMFGGJEOJC, bool FLCJEOIPAKN, float BMMHLGOOCJB, float HPLIFFPJHDA, Transform PJFDNMGHMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x81B9AD0", Offset = "0x81B84D0", VA = "0x1881B9AD0")]
		public void IJONCENINAO(Transform KDBMAICDPCM, Transform PJFDNMGHMBL, bool OGJBLDICKIJ, bool JFPJLOFNGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x81B9880", Offset = "0x81B8280", VA = "0x1881B9880")]
		private void HCPCNLBGLHO(Transform PJFDNMGHMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x81B9980", Offset = "0x81B8380", VA = "0x1881B9980")]
		public bool IJIMBGEFENB(Transform PJFDNMGHMBL, AvatarFullBodyConfiguration CJFJFBGGCAJ, Vector3 IPLACMDNHKF, float GOIPBENEFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x81B9860", Offset = "0x81B8260", VA = "0x1881B9860")]
		public void EMLOMONDIAP(float HPLIFFPJHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x81BA610", Offset = "0x81B9010", VA = "0x1881BA610")]
		public MIEEIJHKOCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class LDKJLCCPJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float GGFGBGKMJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool KCDLADEFFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AnimationPoseSetting KKOOFFNJHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private float PNLKOKOBOKG;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x81B7F80", Offset = "0x81B6980", VA = "0x1881B7F80")]
		public void AOFGNJPALNI(IKSolverVR.Arm GEDELKALOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x81B8450", Offset = "0x81B6E50", VA = "0x1881B8450")]
		public void CBFIAIPHGJC(IKSolverVR.Arm GEDELKALOOB, float JHMEPPKCBEN, bool KCDLADEFFHC, AvatarFullBodyConfiguration CJFJFBGGCAJ, float PJMJFHIDLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x81B8B10", Offset = "0x81B7510", VA = "0x1881B8B10")]
		private void NGOLLKIACOI(IKSolverVR.Arm GEDELKALOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x81B8490", Offset = "0x81B6E90", VA = "0x1881B8490")]
		public void DMMHMPDJIJJ(IKSolverVR.Arm GEDELKALOOB, Transform CILJCDIOKDD, Transform BIEIHEDFBHE, Quaternion MLLHNPPMJMO, Vector3 MPLLMEGFDPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x81B9150", Offset = "0x81B7B50", VA = "0x1881B9150")]
		private (Vector3, Quaternion) OGELNKPJOJB(PJADJOAPGAD HDKHNHPMNFJ, Quaternion DPCFEPAACDM, Vector3 IGGMADELDLP)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x81B89B0", Offset = "0x81B73B0", VA = "0x1881B89B0")]
		public void IHFMFHAFEFJ(PJADJOAPGAD HDKHNHPMNFJ, IKSolverVR.Arm GEDELKALOOB, Quaternion DPCFEPAACDM, Vector3 IGGMADELDLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x81B8B50", Offset = "0x81B7550", VA = "0x1881B8B50")]
		public void NJNCEKDJFGK(PJADJOAPGAD HDKHNHPMNFJ, IKSolverVR.Arm GEDELKALOOB, Quaternion DPCFEPAACDM, Vector3 IGGMADELDLP, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ, [In] PMOJIGEBEPK BLKFHFCBEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x81B8870", Offset = "0x81B7270", VA = "0x1881B8870")]
		public void HGDBGCHMIOP(DIDNDKMHLCC OFKDFPKHMKM, AvatarFullBodyConfiguration CJFJFBGGCAJ, PMOJIGEBEPK BLKFHFCBEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x81B7FB0", Offset = "0x81B69B0", VA = "0x1881B7FB0")]
		public void BFNHPHGKBED(IKSolverVR.Arm GEDELKALOOB, Transform CILJCDIOKDD, Vector3 JNCNONAADII, float DIDHAEKPBOI, Quaternion HOHGIGIGCMC, Vector3 JLFHGCDMOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x81B95E0", Offset = "0x81B7FE0", VA = "0x1881B95E0")]
		public LDKJLCCPJBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum FKDEKMMPBDK
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
	private struct IKLEABOMBGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct EFMBCIDJHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int EOMHHJNFOFD;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int ADLOPLGCEHL;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int DEMDPIIFBLI;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int EKGDAOIAACD;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int KAHOHNGDLFH;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int EPOIFBDFKIB;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int CNFAOCOGHFP;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int DHICIACNMPP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int NOLBLBJPFKN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int BHKLDOHELMC;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int AANHHDECGCF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int IPGCINEGEML;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int LEPJLPHNJGO;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int NPPPOGGAMMN;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int BMMIFMIEMGO;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int JGMFIAADAIN;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int AOHBNNNMMPA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int MOPNPNHEOJJ;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int IODJJOODNCK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int HDHPDLKNNFB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int KJIMCJLIIPN;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int CBDAEADEBLK;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int NELKODBHPGM;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int DAMCCBMPHEB;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int JOALPPFMKCM;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int PFFICCOFFHN;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int PNHMPNFDPPJ;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int HKDBFOIALKE;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int OIBHDJBMPPP;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int HHBLLHDHLJN;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int DFHCKJACAKD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int ELGEDMDPCHI;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 KOEAEDGEKOF;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int IEGFNGHDHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool FBEJIJCNNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool OHCEKDHPDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool AELOJCALEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool ANABAFBMMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool JLDNIFCGHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool BCAKNFOPJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 LGEBIHDGCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string KEJGOHJPMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private JLAFFLLHKBA? LJNAGPJKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private DLKPGCIFOFB? AKOMKNJAMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private KAAAFBEDNIK GMNCGDCGJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private LOGFLOJMGGF EMNOBGHLNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private PJADJOAPGAD ODNJPJMHLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private PJADJOAPGAD IPBCHDGFNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool BGJJGNOCMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool AIEFOEHAKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly NDAHKCCODIG ACCFLOOODBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly KDMAKNMPCBB BMIAPMKKJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int AKKLGPFKLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float OGGECJFBOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject COCHIPKGFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform NDDBJPKHMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform OLKLFFDJBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform NDNFDOOCDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform JLPMEPPNPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float IOCCAEDNNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float HPLMIAFLDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 PIECCOPMIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion DKJEMCGNCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform CNNAAMLKEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform DGKKMNAKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform ONPLKEOIAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private LOCNJOFBCHI ANGOBKBJLKE;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker ELGEICJFIIK;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker DHCGOJIBNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker LDJHNCDEAAK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker MOEAAEDHLJG;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker JMFIAOHKAII;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker NANKDJKAIIP;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<HIGJHONEFHK> PPFMHNIPBED;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int LEJNKHMDCOP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> DFIGKLJHBHG;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int FPJNGDEDJGK;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int PLEDOIDADMH;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int CKBPCJHBKDH;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int HCNPMLNAPAF;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float OLCEDFJJNBA;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int EHGCJDFJHJH;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float HIGLEJEHNPE;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float AOIIOJNJOKI;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float MLGNDEENLCH;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float IIAHDABPKKM;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static LJEFIMKLFLJ IKLDFIEIHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float FCIDMAEBNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool GMMMDNODGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float GFPCHAPKEGJ;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int DFGGOOELPME;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int OJABAMCIJHD;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int GKBGCNIKEBC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int DBIHFOBEGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private MIEEIJHKOCC BLOLNLPAIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private MIEEIJHKOCC LIKHBCNLNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float PLIALODGCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 AHCDHNOFLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 BOFOICHEEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool FPDGBBPPNCB;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion OAIIEAMPBCE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion GBLLKPDOJIK;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 BPFHFGINCLA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 KKCGMIPAKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float FALKKDFGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float ABGGCNPBIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private LDKJLCCPJBK LGOHPKGKPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private LDKJLCCPJBK HKFKBDEBJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private OOFODMKLBCF BJMBLCIEEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private KLGLDOBDILG IHKNLCHCEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly GHHJBOEAIIE MFJCIAHGGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float JLMAMENKAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float MGPNBOJCKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly KLGLDOBDILG JPJMEFCPGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 NGKDAIPFEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 DGFBPKBONHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float PKMPHDFGNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float JIEEDAJDFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly KLGLDOBDILG ALOCKPOLPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly OOFODMKLBCF OEGLONMEEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly KLGLDOBDILG DEBDNCCNHOA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HPDJJKCNBLF NDFEOMFJNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HPDJJKCNBLF FIPAMOIKCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration KCMCILAJIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8193BB0", Offset = "0x81925B0", VA = "0x188193BB0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EAJLGMHEHMA NLLMOMBLFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8192BD0", Offset = "0x81915D0", VA = "0x188192BD0", Slot = "24")]
		get
		{
			return default(EAJLGMHEHMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration OBMPJDNALEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x819F020", Offset = "0x819DA20", VA = "0x18819F020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform NFFGGAOEMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81AB850", Offset = "0x81AA250", VA = "0x1881AB850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform GDNOIOGKAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81A4810", Offset = "0x81A3210", VA = "0x1881A4810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer OBHIKPOKPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81A07B0", Offset = "0x819F1B0", VA = "0x1881A07B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] HBDPBCOLELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81A43F0", Offset = "0x81A2DF0", VA = "0x1881A43F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] JPNNCHGHDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81A7F20", Offset = "0x81A6920", VA = "0x1881A7F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator MGPJEAINBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81A7950", Offset = "0x81A6350", VA = "0x1881A7950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK NMGGOKOCJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81AAE50", Offset = "0x81A9850", VA = "0x1881AAE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private LBPAJMNCKBF NAIOAJKJECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81A6860", Offset = "0x81A5260", VA = "0x1881A6860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private LBPAJMNCKBF ILBKHBEKFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8193580", Offset = "0x8191F80", VA = "0x188193580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private LBPAJMNCKBF CBACCPMPKND
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x819B910", Offset = "0x819A310", VA = "0x18819B910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private LBPAJMNCKBF MLHBOHAJLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x81A4640", Offset = "0x81A3040", VA = "0x1881A4640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private LBPAJMNCKBF OLGJDDDILOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x819AE20", Offset = "0x8199820", VA = "0x18819AE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private LBPAJMNCKBF IBNPMLNHBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x81A42F0", Offset = "0x81A2CF0", VA = "0x1881A42F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private LBPAJMNCKBF PFABAPOJGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x81A53B0", Offset = "0x81A3DB0", VA = "0x1881A53B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private LBPAJMNCKBF FJNAMOGBMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8193CB0", Offset = "0x81926B0", VA = "0x188193CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DLKPGCIFOFB APMGJOIEBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8194160", Offset = "0x8192B60", VA = "0x188194160", Slot = "16")]
		get
		{
			return default(DLKPGCIFOFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public POODIKIDKFI PNINANPDKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB81E70", Offset = "0xB80870", VA = "0x180B81E70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ELPBBPMJKFF JPJEDPDEHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB81E40", Offset = "0xB80840", VA = "0x180B81E40", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JPICLCPJPKE GBCMOACOJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB80830", VA = "0x180B81E30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JPICLCPJPKE IEHADJDEGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xBF97E0", Offset = "0xBF81E0", VA = "0x180BF97E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string BNKJJMGGNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform MGAJBNHOHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81A54B0", Offset = "0x81A3EB0", VA = "0x1881A54B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform OAKGNJGLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x81934F0", Offset = "0x8191EF0", VA = "0x1881934F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform FBEGLGFAIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x81AA0B0", Offset = "0x81A8AB0", VA = "0x1881AA0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform NEMDOEHEHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81A47D0", Offset = "0x81A31D0", VA = "0x1881A47D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform LGADNFCJIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x819F390", Offset = "0x819DD90", VA = "0x18819F390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool DLOBMJOONFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x819BBA0", Offset = "0x819A5A0", VA = "0x18819BBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool JOEBKHHFKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x819BBA0", Offset = "0x819A5A0", VA = "0x18819BBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool PJHLOHOGLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x819D6C0", Offset = "0x819C0C0", VA = "0x18819D6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform IGIFJLNADFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x819CE40", Offset = "0x819B840", VA = "0x18819CE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject CEENMGBCJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x819B100", Offset = "0x8199B00", VA = "0x18819B100", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets MMLLKPJAPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81A1270", Offset = "0x819FC70", VA = "0x1881A1270", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform BCFDHJNOHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xBF9AC0", Offset = "0xBF84C0", VA = "0x180BF9AC0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform KKGCIFNHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBF9060", Offset = "0xBF7A60", VA = "0x180BF9060", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform JLEKPBPHDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xBE4DA0", Offset = "0xBE37A0", VA = "0x180BE4DA0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform DLIGFKLCAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAFB820", Offset = "0xAFA220", VA = "0x180AFB820", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 BPIPAFIBMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x81A4740", Offset = "0x81A3140", VA = "0x1881A4740", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float LLKKFFAEDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8193530", Offset = "0x8191F30", VA = "0x188193530", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform HHDHHAPMAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x81AADF0", Offset = "0x81A97F0", VA = "0x1881AADF0", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform JGJOOJNCNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE3A7D0", Offset = "0xE391D0", VA = "0x180E3A7D0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform COFHAKKOOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F40", Offset = "0x15B8940", VA = "0x1815B9F40", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform ANJMFPBNNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAFC030", Offset = "0xAFAA30", VA = "0x180AFC030", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PCJILLFFIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x81926E0", Offset = "0x81910E0", VA = "0x1881926E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public ECMKKKEPCGP<JELDKIPDDKE.JHIGDAJMKCE> MHMHPMKCILA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x10CCFA0", Offset = "0x10CB9A0", VA = "0x1810CCFA0", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool OFIAPEKBLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x81A7C00", Offset = "0x81A6600", VA = "0x1881A7C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool DCAHBKDBHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8198C40", Offset = "0x8197640", VA = "0x188198C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x819F000", Offset = "0x819DA00", VA = "0x18819F000")]
	private float FPAJHPPDKLL(FJKAOBKJCGM DHFGLPEAJOG, float DNEPNFCHNMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8199340", Offset = "0x8197D40", VA = "0x188199340")]
	private void DEHMHIKCDLB([In] PMOJIGEBEPK NHOANOBBFHG, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ, bool JPBCGPLJODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x81A10E0", Offset = "0x819FAE0", VA = "0x1881A10E0")]
	private float IHMOOMCGOKL([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x81A5500", Offset = "0x81A3F00", VA = "0x1881A5500")]
	private float KLGJFIGIGLO([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x81A7D50", Offset = "0x81A6750", VA = "0x1881A7D50")]
	private void NCPOPIAFGIL(PMOJIGEBEPK NHOANOBBFHG, AvatarFullBodyConfiguration CJFJFBGGCAJ, bool JPBCGPLJODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x81A7510", Offset = "0x81A5F10", VA = "0x1881A7510")]
	private void MDLKFLPOJDH([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8194920", Offset = "0x8193320", VA = "0x188194920")]
	private void BNJAEMKOPDJ([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x81AC9C0", Offset = "0x81AB3C0", VA = "0x1881AC9C0")]
	public HIGJHONEFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8194420", Offset = "0x8192E20", VA = "0x188194420", Slot = "13")]
	public void BKNCDGLPFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8193DB0", Offset = "0x81927B0", VA = "0x188193DB0", Slot = "14")]
	public void BEHOPCEDBMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x81A8F30", Offset = "0x81A7930", VA = "0x1881A8F30", Slot = "15")]
	public void NKOGJDMMPFD(bool DMDDKPFAGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x81A44F0", Offset = "0x81A2EF0", VA = "0x1881A44F0", Slot = "26")]
	public Transform JJAGKMPPNCD(string JEGEMHIKDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81A66C0", Offset = "0x81A50C0", VA = "0x1881A66C0", Slot = "27")]
	public Vector3? LABDLKHHJBJ(string JEGEMHIKDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81A8AB0", Offset = "0x81A74B0", VA = "0x1881A8AB0", Slot = "7")]
	public void NJFPIHEEFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8198CC0", Offset = "0x81976C0", VA = "0x188198CC0")]
	private void DDJIJHGBNKM(AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x819F7E0", Offset = "0x819E1E0", VA = "0x18819F7E0", Slot = "8")]
	public void HDAKDFEELOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x81A1170", Offset = "0x819FB70", VA = "0x1881A1170")]
	private void IIAIMNMPKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x81A7A80", Offset = "0x81A6480", VA = "0x1881A7A80")]
	private Vector3 MNOMMJBODJB([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x819F3D0", Offset = "0x819DDD0", VA = "0x18819F3D0", Slot = "6")]
	public void GGJLKDBHHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x81A3530", Offset = "0x81A1F30", VA = "0x1881A3530")]
	private void JFIIGHGKIAA(bool JPBCGPLJODM, FKDEKMMPBDK PNGDEPCDJBI, AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x81AB950", Offset = "0x81AA350", VA = "0x1881AB950", Slot = "9")]
	public void PJOBILNCIHC(float CFCGJPJIDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x81A73F0", Offset = "0x81A5DF0", VA = "0x1881A73F0")]
	private void LLAODEIAPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8195B30", Offset = "0x8194530", VA = "0x188195B30", Slot = "4")]
	public void CGIGLJLLKDB(string HCNBMBFBNPA, JLAFFLLHKBA MPAGCCPADPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x819B1A0", Offset = "0x8199BA0", VA = "0x18819B1A0", Slot = "5")]
	public void DIOMCBIDLLF(DLKPGCIFOFB KJHEPIOHFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A5820", VA = "0x1881A6E20", Slot = "12")]
	public void LEFAMOONJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x819FA20", Offset = "0x819E420", VA = "0x18819FA20", Slot = "25")]
	public void HDNJNENDKME([Out] Vector3 LLNNBPAFGPP, [Out] Quaternion HOHGIGIGCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x819DC00", Offset = "0x819C600", VA = "0x18819DC00")]
	private void FHAIAJELIOH([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81A7C80", Offset = "0x81A6680", VA = "0x1881A7C80", Slot = "28")]
	public void MPJJPPIFLNN(float EJHGOPFDGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8194BA0", Offset = "0x81935A0", VA = "0x188194BA0", Slot = "29")]
	public void CCMEDBBKPDI(float FDACNGBNOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x819DE20", Offset = "0x819C820", VA = "0x18819DE20", Slot = "46")]
	public void FIHLPBJBFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x81A7900", Offset = "0x81A6300", VA = "0x1881A7900", Slot = "30")]
	public void MEICBHCDPID(bool CCCJNENMJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x81AAF50", Offset = "0x81A9950", VA = "0x1881AAF50", Slot = "31")]
	public HandLogicOffsets PANPEHKEAOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x81A7C90", Offset = "0x81A6690", VA = "0x1881A7C90", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets NBGHHDJLGIP()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x81A7A50", Offset = "0x81A6450", VA = "0x1881A7A50")]
	private void MKKMJCJNEJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8194A20", Offset = "0x8193420", VA = "0x188194A20")]
	private void CAFLIOMLFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x819CF40", Offset = "0x819B940", VA = "0x18819CF40")]
	private void EKIGPOMFAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x819F0B0", Offset = "0x819DAB0", VA = "0x18819F0B0")]
	private void GALIKFCLGNL(GAMCEIADCLK HJFLDHAMGGJ, bool CKECAKCIDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x819FFD0", Offset = "0x819E9D0", VA = "0x18819FFD0")]
	private void HHHAMGNOLOB(GAMCEIADCLK HJFLDHAMGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x819D380", Offset = "0x819BD80", VA = "0x18819D380")]
	public Vector3 EKPIPFFCMEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x81AA920", Offset = "0x81A9320", VA = "0x1881AA920")]
	private void OJKHMFLIDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x81A7440", Offset = "0x81A5E40", VA = "0x1881A7440")]
	private void LLLIADJFNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x81A5600", Offset = "0x81A4000", VA = "0x1881A5600")]
	private void KNCHCPCHODD(PMOJIGEBEPK NHOANOBBFHG, AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x819CC90", Offset = "0x819B690", VA = "0x18819CC90")]
	private float EHKOFPDIAOH([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x81A6F80", Offset = "0x81A5980", VA = "0x1881A6F80")]
	private int LEMPKJFEFHD([In] HDKIBJIGHCJ BHFLFAIELAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8193680", Offset = "0x8192080", VA = "0x188193680")]
	private void AJKHCJDLLBD(PMOJIGEBEPK NHOANOBBFHG, bool AHEFJAFMLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x819FDB0", Offset = "0x819E7B0", VA = "0x18819FDB0")]
	private static void HFBNIKHLJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x819E300", Offset = "0x819CD00", VA = "0x18819E300")]
	private static void FOLAFNLDIEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x81A8D60", Offset = "0x81A7760", VA = "0x1881A8D60")]
	private float NKNGOOCFLIK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x81A5380", Offset = "0x81A3D80", VA = "0x1881A5380")]
	private static int KEJOFLKAHCM(HIGJHONEFHK OKDCNKNEMHO, HIGJHONEFHK AAJFLFEAFBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x81A7200", Offset = "0x81A5C00", VA = "0x1881A7200", Slot = "41")]
	public PMOJIGEBEPK LHOOFFGBGPH()
	{
		return default(PMOJIGEBEPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x81A1030", Offset = "0x819FA30", VA = "0x1881A1030")]
	private bool IFDAJDLEPAK(int EGJGKBPPPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81A5580", Offset = "0x81A3F80", VA = "0x1881A5580")]
	public void KMLOAKGDMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x819AF20", Offset = "0x8199920", VA = "0x18819AF20")]
	private (bool, bool) DEKBHILOLFO()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x81AAC10", Offset = "0x81A9610", VA = "0x1881AAC10")]
	private (float, float) OLHNAPDDBHK([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x81A12F0", Offset = "0x819FCF0", VA = "0x1881A12F0")]
	private void JCGNBHFOEHB([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x81A9D90", Offset = "0x81A8790", VA = "0x1881A9D90")]
	private void NPMEMNLGLOO([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x81A3D10", Offset = "0x81A2710", VA = "0x1881A3D10")]
	private void JFOFLLIKMJE([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ, AvatarFootSettings KFMPAIBNIGG, bool BHDPPACBDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x81A5300", Offset = "0x81A3D00", VA = "0x1881A5300")]
	private float KDOFCDMKCCJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x819C110", Offset = "0x819AB10", VA = "0x18819C110")]
	private void EGLNBIOLCAL(PMOJIGEBEPK BLKFHFCBEDC, AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8198BF0", Offset = "0x81975F0", VA = "0x188198BF0")]
	private float CPEEENJCMNG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x81A6960", Offset = "0x81A5360", VA = "0x1881A6960")]
	private void LCIFGCPMAEC([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x819B620", Offset = "0x819A020", VA = "0x18819B620")]
	private void DMMHMPDJIJJ([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x81927D0", Offset = "0x81911D0", VA = "0x1881927D0")]
	private void ACIACPCAPPK([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x81A32A0", Offset = "0x81A1CA0", VA = "0x1881A32A0")]
	private void JFGFJGOJJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x81A09C0", Offset = "0x819F3C0", VA = "0x1881A09C0")]
	private void HMGAKGMJIHK(float MBAJCHFFGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x819BA10", Offset = "0x819A410", VA = "0x18819BA10")]
	private void DOGOLCMKMLH([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x81A8820", Offset = "0x81A7220", VA = "0x1881A8820")]
	private void NJEKACLABNE(PJADJOAPGAD CFEAOPLIELK, IKSolverVR.Arm GEDELKALOOB, Transform IDEFHHJNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8198730", Offset = "0x8197130", VA = "0x188198730")]
	private void COMCJGIIBOC(PMOJIGEBEPK BLKFHFCBEDC, AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x81A9000", Offset = "0x81A7A00", VA = "0x1881A9000")]
	private void NLAHMAEFEKN(HKFEOOBKDMD OALLACJMPBH, JPICLCPJPKE CFEAOPLIELK, IKSolverVR.Arm GEDELKALOOB, float JHMEPPKCBEN, float CIBPLLKACII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x819F5D0", Offset = "0x819DFD0", VA = "0x18819F5D0")]
	private void GKIGPOAJIJH([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8198130", Offset = "0x8196B30", VA = "0x188198130")]
	private void CNHKCDMNKAF([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x819DE70", Offset = "0x819C870", VA = "0x18819DE70")]
	protected void FIODGBMOFML([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x81A2F50", Offset = "0x81A1950", VA = "0x1881A2F50")]
	private void JDEOLNKDMPB([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x81A9990", Offset = "0x81A8390", VA = "0x1881A9990")]
	protected void NOCDPJLHPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8192CD0", Offset = "0x81916D0", VA = "0x188192CD0")]
	private void AFFMOKKPNEE([In] PMOJIGEBEPK BLKFHFCBEDC, [In] FKDEKMMPBDK PNGDEPCDJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8194270", Offset = "0x8192C70", VA = "0x188194270")]
	private void BJIABPHKFPB(PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x81A7EE0", Offset = "0x81A68E0", VA = "0x1881A7EE0")]
	private void NDGIOIKHCPB([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x819BBF0", Offset = "0x819A5F0", VA = "0x18819BBF0")]
	private Vector3 DOPNECBLJFF([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x819E230", Offset = "0x819CC30", VA = "0x18819E230")]
	private void FKCDJMFKCHE([In] PMOJIGEBEPK BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x819D7B0", Offset = "0x819C1B0", VA = "0x18819D7B0")]
	private float FBNFBLMNNKD(float HPLIFFPJHDA, [In] PMOJIGEBEPK BLKFHFCBEDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x81AA0E0", Offset = "0x81A8AE0", VA = "0x1881AA0E0")]
	private void OAFLBJIEAKO(float HPLIFFPJHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x81AA230", Offset = "0x81A8C30", VA = "0x1881AA230")]
	private void OCBKNHILCMA([In] PMOJIGEBEPK BLKFHFCBEDC, FKDEKMMPBDK PNGDEPCDJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x81A8020", Offset = "0x81A6A20", VA = "0x1881A8020")]
	private float NIEJHJEBEIC([In] PMOJIGEBEPK NHOANOBBFHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8194EF0", Offset = "0x81938F0", VA = "0x188194EF0")]
	private void CEBKJDJOLGH(PMOJIGEBEPK BLKFHFCBEDC, FKDEKMMPBDK PNGDEPCDJBI, Vector3 HLJGABBNKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x81A9BE0", Offset = "0x81A85E0", VA = "0x1881A9BE0")]
	private static void NOEHAHKBKCE(Transform EOBBLENOIHL, Quaternion JCDLBIBEGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x81A04B0", Offset = "0x819EEB0", VA = "0x1881A04B0")]
	private void HJKDAGHOJLP([In] PMOJIGEBEPK MEFGMENKMFO, [In] HDKIBJIGHCJ BHFLFAIELAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x81AAFA0", Offset = "0x81A99A0", VA = "0x1881AAFA0")]
	private void PFEOJFANHON([In] PMOJIGEBEPK MEFGMENKMFO, [In] HDKIBJIGHCJ BHFLFAIELAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x819DC30", Offset = "0x819C630", VA = "0x18819DC30")]
	private void FHBEOEHFDFE(float PCJAAHGECLO, [In] PMOJIGEBEPK NHOANOBBFHG, float FKMBBKDHEPF = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x81A91D0", Offset = "0x81A7BD0", VA = "0x1881A91D0")]
	private float NLCOPCBBJAK([In] PMOJIGEBEPK NHOANOBBFHG, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x819D3D0", Offset = "0x819BDD0", VA = "0x18819D3D0")]
	private void ENCKEOOMOLF([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x81A5CB0", Offset = "0x81A46B0", VA = "0x1881A5CB0")]
	private void KNNJGDBGKLD([In] PMOJIGEBEPK NHOANOBBFHG, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8197D60", Offset = "0x8196760", VA = "0x188197D60")]
	private void CMDKAPPNEJB([In] PMOJIGEBEPK NHOANOBBFHG, float AJDJBEMCHFJ, float FODGNPNEBEK, Vector3 APBOELAKDLP, float FKMBBKDHEPF = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x81A4910", Offset = "0x81A3310", VA = "0x1881A4910")]
	private void KCLAMHJJGHB(PMOJIGEBEPK NHOANOBBFHG, AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x81A0DA0", Offset = "0x819F7A0", VA = "0x1881A0DA0")]
	private void IDJLEJLBACM(PMOJIGEBEPK BLKFHFCBEDC, AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x81AB9C0", Offset = "0x81AA3C0", VA = "0x1881AB9C0")]
	private void PPAENGNJILE(PMOJIGEBEPK NHOANOBBFHG, AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x81A4130", Offset = "0x81A2B30", VA = "0x1881A4130")]
	public void JFOJJDDKELK([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x81A0150", Offset = "0x819EB50", VA = "0x1881A0150")]
	public void HIECIJECMJJ([In] PMOJIGEBEPK BLKFHFCBEDC, [In] AvatarFullBodyConfiguration CJFJFBGGCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x81A7060", Offset = "0x81A5A60", VA = "0x1881A7060")]
	[CompilerGenerated]
	internal static void LGJFDDCLDKK(Transform GJFINIAHPMG, IKSolverVR.Arm GEDELKALOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x81A7460", Offset = "0x81A5E60", VA = "0x1881A7460")]
	[CompilerGenerated]
	internal static void LMCDCLNCJAM(Vector3 PPJBGOKGKII, Vector3 AJPKIKPBEGO, IKLEABOMBGJ P_2, EFMBCIDJHIG P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x81A7350", Offset = "0x81A5D50", VA = "0x1881A7350")]
	[CompilerGenerated]
	internal static void LILMCAFEMEO(MIEEIJHKOCC BGPGFPJJGIK, MIEEIJHKOCC GDDFIFMDPNP, Vector3 NIKGEKPIGFP, float GFHOJCCMEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x81A08B0", Offset = "0x819F2B0", VA = "0x1881A08B0")]
	[CompilerGenerated]
	internal static bool HLNOJBLLIFP(IKSolverVR.Arm GEDELKALOOB, KEPEHLLJCBM JLFHELDPFBL, float DFBBDEGONBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x81956F0", Offset = "0x81940F0", VA = "0x1881956F0")]
	[CompilerGenerated]
	internal static float CFEEEJGFIFK(Vector3 OPIACMPGHIK, Vector3 DDAKGOIGADD, Vector3 GBJBIBNGONG, PMOJIGEBEPK NHOANOBBFHG, AvatarFullBodyConfiguration CJFJFBGGCAJ, float KIOPHNHDMKE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class GNGDOEFDGJP : OPMHAGKCMBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Dictionary<string, JELDKIPDDKE> EFFCOHMNPPO;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x81B5320", Offset = "0x81B3D20", VA = "0x1881B5320")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void IPPPFOOKLGH(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x81B4F50", Offset = "0x81B3950", VA = "0x1881B4F50", Slot = "4")]
	public JELDKIPDDKE BNAFNBEOCAP(string DLOCDELFFIM, AvatarSystemConfiguration OKHMOJHHFII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x81B5390", Offset = "0x81B3D90", VA = "0x1881B5390", Slot = "5")]
	public void KPKEMCICCEP(string DLOCDELFFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x81B5170", Offset = "0x81B3B70", VA = "0x1881B5170", Slot = "6")]
	public string FPGAMHHEBBA(string ABPPMJKODBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x81B52B0", Offset = "0x81B3CB0", VA = "0x1881B52B0")]
	private string INPMIABKEHC(string ABPPMJKODBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x81B5570", Offset = "0x81B3F70", VA = "0x1881B5570")]
	public GNGDOEFDGJP()
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
		public class IODEHHMJHBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Dictionary<string, Transform> KABPIAKCNHK;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool OFLDDHIICNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x81B75F0", Offset = "0x81B5FF0", VA = "0x1881B75F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x81B7630", Offset = "0x81B6030", VA = "0x1881B7630")]
			public void EDHJDFJELGD(VRIK HPBGALOBJPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
			public void KJOBABNGOIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x81B75A0", Offset = "0x81B5FA0", VA = "0x1881B75A0")]
			public void AAJENMMCLHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x81B7760", Offset = "0x81B6160", VA = "0x1881B7760")]
			public IODEHHMJHBP()
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
		[SerializeField]
		[MICOBDMLFEG(MGLGMLBODOF.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[OICBHOIKJDP(MGLGMLBODOF.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly IODEHHMJHBP OMJOPPCPAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private OCCLLAKDGIK INHABGONCMH;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x81B2620", Offset = "0x81B1020", VA = "0x1881B2620")]
		private void ICNIAFDKEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x81B2900", Offset = "0x81B1300", VA = "0x1881B2900")]
		private bool IINLOBICEJK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x81B2950", Offset = "0x81B1350", VA = "0x1881B2950")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x81B29C0", Offset = "0x81B13C0", VA = "0x1881B29C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x81B2960", Offset = "0x81B1360", VA = "0x1881B2960")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x81B2C30", Offset = "0x81B1630", VA = "0x1881B2C30")]
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

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x81B63A0", Offset = "0x81B4DA0", VA = "0x1881B63A0")]
			public (float, float) NIEPGBJCKBH(float JLKBODBCNPL)
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
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x81B5A90", Offset = "0x81B4490", VA = "0x1881B5A90")]
			public void CEKLAJMLNPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x81B5B70", Offset = "0x81B4570", VA = "0x1881B5B70")]
			public (float, float) KHBDLGJBKNF(Animator KNKHHKNBDOG, AnimatorStateInfo FIGJOMKKIIL)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x81B5CB0", Offset = "0x81B46B0", VA = "0x1881B5CB0")]
		public void CEKLAJMLNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x81B6100", Offset = "0x81B4B00", VA = "0x1881B6100")]
		public (float, float) HCDMPHKOEIO(Animator KNKHHKNBDOG, FJKAOBKJCGM DHFGLPEAJOG, float EJNFJOJHNOC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x81B5EA0", Offset = "0x81B48A0", VA = "0x1881B5EA0")]
		private (float, float) EIJKAEGJIND(Animator KNKHHKNBDOG, AnimatorStateInfo FIGJOMKKIIL, FJKAOBKJCGM DHFGLPEAJOG, float EJNFJOJHNOC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x81B6390", Offset = "0x81B4D90", VA = "0x1881B6390")]
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

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x81BA620", Offset = "0x81B9020", VA = "0x1881BA620", Slot = "4")]
		public override void OnStateEnter(Animator KNKHHKNBDOG, AnimatorStateInfo FIGJOMKKIIL, int CMACAEPGNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x81BA790", Offset = "0x81B9190", VA = "0x1881BA790")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class HLNBPNDBNLI<TInput, TOutput> : MCJKICHGNLJ<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected readonly JBEAJCDGOAE FHJFJFFNNON;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x505D2E0", Offset = "0x505BCE0", VA = "0x18505D2E0")]
	protected HLNBPNDBNLI(JBEAJCDGOAE FHJFJFFNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput JBBKNKCPLNK(TInput GMLILPJAKBM, [Out] IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x505D240", Offset = "0x505BC40", VA = "0x18505D240", Slot = "5")]
	public bool HIEGMECPOCL(TInput GMLILPJAKBM, [Out] TOutput? AEAMJGPOBKI, [Out] IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[IHCCCAONNEJ]
public static class PJIHGEMAEHC
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly Regex AJMOLMPHHDL;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x81BA7B0", Offset = "0x81B91B0", VA = "0x1881BA7B0")]
	public static GOHDCAIDNDD JALFBCKIDAL(BKDCIKGEGPK GDOCOMJBPDA, NOKNCAGJAEE LGJJKCOMIFH, Guid? DMABDIEKAKJ, Color? DNJIDNPAECJ, BEBMGMBEIIO HMKMCCAOOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x81BA9C0", Offset = "0x81B93C0", VA = "0x1881BA9C0")]
	public static ANBOJIKIHHJ KDLFJHMNELE(GOHDCAIDNDD GPCDCFCPGFK)
	{
		return default(ANBOJIKIHHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3E91060", Offset = "0x3E8FA60", VA = "0x183E91060")]
	internal static TModern? CHJJHLDJEGJ<TModern>(string? GMLILPJAKBM, EHFIBAOOOCP<TModern> HABOOLFCAPA, JBEAJCDGOAE FHJFJFFNNON, MGNCICIPHFF MFBLGJCCEGE, TModern PBKIGBBJBFB) where TModern : struct, GHCCIAMMCFG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3E93530", Offset = "0x3E91F30", VA = "0x183E93530")]
	internal static LLDPDFNDOJI EDGMKFFJLBP<TModern>(string? GMLILPJAKBM, EHFIBAOOOCP<TModern> HABOOLFCAPA, JBEAJCDGOAE FHJFJFFNNON, MGNCICIPHFF MFBLGJCCEGE, TModern PBKIGBBJBFB) where TModern : struct, GHCCIAMMCFG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x81BAB20", Offset = "0x81B9520", VA = "0x1881BAB20")]
	internal static List<PEIDCEBGHBD> KEHCMPAEBAO(IEnumerable<JHNMIKJKCEJ>? GMJCDLDBMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3E926B0", Offset = "0x3E910B0", VA = "0x183E926B0")]
	internal static string DNNHHIHPICG<TModern>(TModern GMLILPJAKBM, EHFIBAOOOCP<TModern> HABOOLFCAPA, JBEAJCDGOAE FHJFJFFNNON) where TModern : GHCCIAMMCFG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class IALBNDONKMO : PLBHBOKDDBB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MCJKICHGNLJ<AEHBGLJGGKB, ALIGCGMOICI> GJDANIBNFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MCJKICHGNLJ<JDJOPBCDFGB, INCBHDFIGGD> PFPMMMCKBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MCJKICHGNLJ<JDJOPBCDFGB, INCBHDFIGGD> BNBIFDCKELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LKPAJDJHJNO OFGGEDOPCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GBOOEPJLHFP GMDBLNIAPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x81B6460", Offset = "0x81B4E60", VA = "0x1881B6460")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	[UsedImplicitly]
	internal static void DAINBFAPMJK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x81B64D0", Offset = "0x81B4ED0", VA = "0x1881B64D0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IALBNDONKMO([LNLOHEINMEO("UnitySerialization")] CLCFJIPINHJ IGKEIAOKOKK, [LNLOHEINMEO(null)] GIAOBDOCLCJ HKJLNLEACIE, [LNLOHEINMEO(null)] JBEAJCDGOAE FHJFJFFNNON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DPKLEDEOMLM
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
public class CNOHCEHCHOD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x81B2DB0", Offset = "0x81B17B0", VA = "0x1881B2DB0")]
	public CNOHCEHCHOD(string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x81B2D10", Offset = "0x81B1710", VA = "0x1881B2D10")]
	public CNOHCEHCHOD(string ONGDPODJNBL, Exception GNHHAMPPHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x81B2D40", Offset = "0x81B1740", VA = "0x1881B2D40")]
	public CNOHCEHCHOD(DPKLEDEOMLM LKMAOFPCIGJ, string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x81B2D70", Offset = "0x81B1770", VA = "0x1881B2D70")]
	public CNOHCEHCHOD(DPKLEDEOMLM LKMAOFPCIGJ, string ONGDPODJNBL, Exception GNHHAMPPHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class GGIFOOIKPLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly CLCFJIPINHJ IGKEIAOKOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly GIAOBDOCLCJ HKJLNLEACIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly JBEAJCDGOAE FHJFJFFNNON;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x81B4DD0", Offset = "0x81B37D0", VA = "0x1881B4DD0")]
	protected GGIFOOIKPLK(CLCFJIPINHJ IGKEIAOKOKK, GIAOBDOCLCJ HKJLNLEACIE, JBEAJCDGOAE FHJFJFFNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x81B3AC0", Offset = "0x81B24C0", VA = "0x1881B3AC0")]
	protected string JBELGIOJEPE(ALIGCGMOICI OENIAJKILAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x81B3470", Offset = "0x81B1E70", VA = "0x1881B3470")]
	protected string CNFBOLIGPOE(ALIGCGMOICI OENIAJKILAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x81B3790", Offset = "0x81B2190", VA = "0x1881B3790")]
	private AvatarOutfitSelectionData JALFBCKIDAL(GOHDCAIDNDD HNLIHPBHPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x81B3650", Offset = "0x81B2050", VA = "0x1881B3650")]
	private static AvatarCustomizationSettingsData.AnchorParams HAMIGCECFOE(JNPBPAOBAGK? HOCLJJCDJMG)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MCJKICHGNLJ<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput JBBKNKCPLNK(TInput GMLILPJAKBM, [Out] IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIEGMECPOCL(TInput GMLILPJAKBM, [Out] TOutput? AEAMJGPOBKI, [Out] IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PLBHBOKDDBB
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	MCJKICHGNLJ<AEHBGLJGGKB, ALIGCGMOICI> GJDANIBNFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MCJKICHGNLJ<JDJOPBCDFGB, INCBHDFIGGD> BNBIFDCKELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	LKPAJDJHJNO OFGGEDOPCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum MGNCICIPHFF
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GBOOEPJLHFP
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPMLIKENHKP AGNKEKDJGCC(ALIGCGMOICI GPCDCFCPGFK);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LKPAJDJHJNO
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDJOPBCDFGB AGNKEKDJGCC(ALIGCGMOICI GPCDCFCPGFK, int DOBBKHLICOG, string? FLBFBHGDBLM, string? LPDPLPHIDEM, MNNPGENBKHF HKPCIADPKMN, List<PEIDCEBGHBD>? EMGBIJEAFPI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[IHCCCAONNEJ]
internal class INOFDNOGEGK : HLNBPNDBNLI<AEHBGLJGGKB, ALIGCGMOICI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly GIAOBDOCLCJ HKJLNLEACIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly AKCIDIBGCAM GLHNNLKHMED;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x81B73D0", Offset = "0x81B5DD0", VA = "0x1881B73D0")]
	public INOFDNOGEGK(CLCFJIPINHJ IGKEIAOKOKK, GIAOBDOCLCJ HKJLNLEACIE, JBEAJCDGOAE FHJFJFFNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x81B7120", Offset = "0x81B5B20", VA = "0x1881B7120", Slot = "6")]
	public override ALIGCGMOICI JBBKNKCPLNK(AEHBGLJGGKB GMLILPJAKBM, [Out] IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class DEJCJKLCAED : CLCFJIPINHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class MHFCOCEMIKK : JsonConverter<LLDPDFNDOJI>
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x81B9780", Offset = "0x81B8180", VA = "0x1881B9780", Slot = "9")]
		public override void WriteJson(JsonWriter ADMHNJGGGLG, LLDPDFNDOJI? PDKJBMPOMNC, JsonSerializer OEPNAGFCALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x81B9660", Offset = "0x81B8060", VA = "0x1881B9660", Slot = "10")]
		public override LLDPDFNDOJI ReadJson(JsonReader IOMONBOBJAC, Type EMOKFILPBJD, LLDPDFNDOJI? GNLNMAFIGHG, bool DBHFDAAAGMI, JsonSerializer OEPNAGFCALD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x81B9820", Offset = "0x81B8220", VA = "0x1881B9820")]
		public MHFCOCEMIKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class IPMMNHNMKGD : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool LIDECCKEJFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x81B7BB0", Offset = "0x81B65B0", VA = "0x1881B7BB0", Slot = "5")]
		public override object ReadJson(JsonReader IOMONBOBJAC, Type EMOKFILPBJD, object? GNLNMAFIGHG, JsonSerializer OEPNAGFCALD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x81B77F0", Offset = "0x81B61F0", VA = "0x1881B77F0", Slot = "6")]
		public override bool CanConvert(Type EMOKFILPBJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x81B7C10", Offset = "0x81B6610", VA = "0x1881B7C10", Slot = "4")]
		public override void WriteJson(JsonWriter ADMHNJGGGLG, object? PDKJBMPOMNC, JsonSerializer OEPNAGFCALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x81B79D0", Offset = "0x81B63D0", VA = "0x1881B79D0")]
		private static bool EKBPGNJAAKB(object PDKJBMPOMNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public IPMMNHNMKGD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JsonSerializerSettings IMFNJOKFKEG;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x81B2DE0", Offset = "0x81B17E0", VA = "0x1881B2DE0")]
	internal DEJCJKLCAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6830", Offset = "0x3AB5230", VA = "0x183AB6830", Slot = "4")]
	public string FELEBOGNEKN<T>(T CEFJEHJNIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB67B0", Offset = "0x3AB51B0", VA = "0x183AB67B0", Slot = "5")]
	public T BMJOCOGAICC<T>(string PDKJBMPOMNC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class OPDNKPKIHNH : CLCFJIPINHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3E512A0", Offset = "0x3E4FCA0", VA = "0x183E512A0", Slot = "4")]
	public string FELEBOGNEKN<T>(T CEFJEHJNIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3E51240", Offset = "0x3E4FC40", VA = "0x183E51240", Slot = "5")]
	public T BMJOCOGAICC<T>(string PDKJBMPOMNC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public OPDNKPKIHNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[IHCCCAONNEJ]
internal class AKCIDIBGCAM : HLNBPNDBNLI<JDJOPBCDFGB, INCBHDFIGGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly CLCFJIPINHJ IGKEIAOKOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly GIAOBDOCLCJ HKJLNLEACIE;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x81B1AA0", Offset = "0x81B04A0", VA = "0x1881B1AA0")]
	public AKCIDIBGCAM(CLCFJIPINHJ IGKEIAOKOKK, GIAOBDOCLCJ HKJLNLEACIE, JBEAJCDGOAE FHJFJFFNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x81B0450", Offset = "0x81AEE50", VA = "0x1881B0450", Slot = "6")]
	public override INCBHDFIGGD JBBKNKCPLNK(JDJOPBCDFGB GMLILPJAKBM, [Out] IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x81B02F0", Offset = "0x81AECF0", VA = "0x1881B02F0")]
	internal void IJEJCAEMEMH(string GOBBHNBEDDI, ALIGCGMOICI OENIAJKILAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x81B19F0", Offset = "0x81B03F0", VA = "0x1881B19F0")]
	public IEnumerable<GOHDCAIDNDD> OCCBJFPDKCJ(string CODLBEAJOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x81AFEC0", Offset = "0x81AE8C0", VA = "0x1881AFEC0")]
	private IEnumerable<GOHDCAIDNDD> BMOGEAGCNFO(string CODLBEAJOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x81B0880", Offset = "0x81AF280", VA = "0x1881B0880")]
	internal IEnumerable<GOHDCAIDNDD> JDBCNNDCNJP(string CODLBEAJOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x81AF930", Offset = "0x81AE330", VA = "0x1881AF930")]
	private GOHDCAIDNDD BDIOEJFEAAL(AvatarOutfitSelectionData NMJLIPKHAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x81B1150", Offset = "0x81AFB50", VA = "0x1881B1150")]
	private void NNCPCGJHIBD(AvatarCustomizationSettingsData EHFHDDBFBBI, ALIGCGMOICI OENIAJKILAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x81AF610", Offset = "0x81AE010", VA = "0x1881AF610")]
	private GOHDCAIDNDD BDIOEJFEAAL(string BOLDCMCKPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x81B0E50", Offset = "0x81AF850", VA = "0x1881B0E50")]
	internal static (BEBMGMBEIIO, string, string) MPGHLFFMMCL(string BOLDCMCKPPG, JBEAJCDGOAE FHJFJFFNNON)
	{
		return default((BEBMGMBEIIO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x81AFCC0", Offset = "0x81AE6C0", VA = "0x1881AFCC0")]
	private IAAJKOODCHI? BGIPNIGLALG(string? DNLDANFOOJK, Vector2 FBLBGOKMNEP, float JGELECMMAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x81B0CF0", Offset = "0x81AF6F0", VA = "0x1881B0CF0")]
	private static JNPBPAOBAGK LDDFIANNNBN(AvatarCustomizationSettingsData.AnchorParams CLOIHFEMNOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[IHCCCAONNEJ]
internal class IDJCJJBKMDJ : GGIFOOIKPLK, GBOOEPJLHFP
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x81B4DD0", Offset = "0x81B37D0", VA = "0x1881B4DD0")]
	public IDJCJJBKMDJ(CLCFJIPINHJ IGKEIAOKOKK, GIAOBDOCLCJ HKJLNLEACIE, JBEAJCDGOAE FHJFJFFNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x81B6A30", Offset = "0x81B5430", VA = "0x1881B6A30", Slot = "4")]
	public JPMLIKENHKP AGNKEKDJGCC(ALIGCGMOICI GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x81B7020", Offset = "0x81B5A20", VA = "0x1881B7020")]
	private string IJILCBEKDAK(ALIGCGMOICI OENIAJKILAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x81B6DE0", Offset = "0x81B57E0", VA = "0x1881B6DE0")]
	private string FEBBPKFPIOI(GOHDCAIDNDD HNLIHPBHPHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IHCCCAONNEJ]
internal class FNFMFHGLNAJ : HLNBPNDBNLI<JDJOPBCDFGB, INCBHDFIGGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly CLCFJIPINHJ IGKEIAOKOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly MCJKICHGNLJ<JDJOPBCDFGB, INCBHDFIGGD> OAHDKNPAGMO;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x81B3370", Offset = "0x81B1D70", VA = "0x1881B3370")]
	public FNFMFHGLNAJ(MCJKICHGNLJ<JDJOPBCDFGB, INCBHDFIGGD> OAHDKNPAGMO, JBEAJCDGOAE FHJFJFFNNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x81B2F40", Offset = "0x81B1940", VA = "0x1881B2F40", Slot = "6")]
	public override INCBHDFIGGD JBBKNKCPLNK(JDJOPBCDFGB GMLILPJAKBM, [Out] IReadOnlyList<PEIDCEBGHBD>? EMGBIJEAFPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[IHCCCAONNEJ]
internal class HFCJIMGABCD : LKPAJDJHJNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly CLCFJIPINHJ IGKEIAOKOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly GBOOEPJLHFP FFKDJEGAJCI;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x81B59A0", Offset = "0x81B43A0", VA = "0x1881B59A0")]
	public HFCJIMGABCD(GBOOEPJLHFP FFKDJEGAJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x81B5600", Offset = "0x81B4000", VA = "0x1881B5600", Slot = "4")]
	public JDJOPBCDFGB AGNKEKDJGCC(ALIGCGMOICI GPCDCFCPGFK, int DOBBKHLICOG, string? FLBFBHGDBLM, string? LPDPLPHIDEM, MNNPGENBKHF HKPCIADPKMN, List<PEIDCEBGHBD>? EMGBIJEAFPI)
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

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x81B1C90", Offset = "0x81B0690", VA = "0x1881B1C90")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KCGKNNIMALG
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x81B7E70", Offset = "0x81B6870", VA = "0x1881B7E70")]
	public static ANBOJIKIHHJ JBBKNKCPLNK(this FOOLPPBDDBC GPCDCFCPGFK)
	{
		return default(ANBOJIKIHHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x81B7CF0", Offset = "0x81B66F0", VA = "0x1881B7CF0")]
	public static FOOLPPBDDBC AGNKEKDJGCC(this ANBOJIKIHHJ AGHNNOFDFMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x81B7E10", Offset = "0x81B6810", VA = "0x1881B7E10")]
	public static bool IIICBFHNOEC(this ANBOJIKIHHJ AGHNNOFDFMH)
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

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x61820F0", Offset = "0x6180AF0", VA = "0x1861820F0")]
			public AnchorParams(Vector2 KPNAOBFPOIA, Vector3 MIMOEDOJDPK, Vector3 OCOCOINKGKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x81B1BE0", Offset = "0x81B05E0", VA = "0x1881B1BE0")]
			internal JNPBPAOBAGK AGNKEKDJGCC()
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
		private DAOAHDPCGLG useHelmetHair;

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
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x81B24C0", Offset = "0x81B0EC0", VA = "0x1881B24C0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1847550", Offset = "0x1845F50", VA = "0x181847550")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xDED820", Offset = "0xDEC220", VA = "0x180DED820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1083F70", Offset = "0x1082970", VA = "0x181083F70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x155DD60", Offset = "0x155C760", VA = "0x18155DD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x81B2570", Offset = "0x81B0F70", VA = "0x1881B2570")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA938F0", Offset = "0xA922F0", VA = "0x180A938F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD3A060", Offset = "0xD38A60", VA = "0x180D3A060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD39F80", Offset = "0xD38980", VA = "0x180D39F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x81B25B0", Offset = "0x81B0FB0", VA = "0x1881B25B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xF91920", Offset = "0xF90320", VA = "0x180F91920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x125C1E0", Offset = "0x125ABE0", VA = "0x18125C1E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x19E5E90", Offset = "0x19E4890", VA = "0x1819E5E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA841C0", Offset = "0xA82BC0", VA = "0x180A841C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2582020", Offset = "0x2580A20", VA = "0x182582020")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xFAD490", Offset = "0xFABE90", VA = "0x180FAD490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xABCD10", Offset = "0xABB710", VA = "0x180ABCD10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xABCD70", Offset = "0xABB770", VA = "0x180ABCD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA90910", Offset = "0xA8F310", VA = "0x180A90910")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA909B0", Offset = "0xA8F3B0", VA = "0x180A909B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA909E0", Offset = "0xA8F3E0", VA = "0x180A909E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA909C0", Offset = "0xA8F3C0", VA = "0x180A909C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA909D0", Offset = "0xA8F3D0", VA = "0x180A909D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA90970", Offset = "0xA8F370", VA = "0x180A90970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xAEDCD0", Offset = "0xAEC6D0", VA = "0x180AEDCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xAEB9B0", Offset = "0xAEA3B0", VA = "0x180AEB9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA90900", Offset = "0xA8F300", VA = "0x180A90900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA90890", Offset = "0xA8F290", VA = "0x180A90890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0F0", Offset = "0xAECAF0", VA = "0x180AEE0F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB40620", Offset = "0xB3F020", VA = "0x180B40620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA89DE0", Offset = "0xA887E0", VA = "0x180A89DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA89E50", Offset = "0xA88850", VA = "0x180A89E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB406B0", Offset = "0xB3F0B0", VA = "0x180B406B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB405B0", Offset = "0xB3EFB0", VA = "0x180B405B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xDDBB50", Offset = "0xDDA550", VA = "0x180DDBB50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xDD7D20", Offset = "0xDD6720", VA = "0x180DD7D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public DAOAHDPCGLG UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x108C400", Offset = "0x108AE00", VA = "0x18108C400")]
			get
			{
				return default(DAOAHDPCGLG);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x108D090", Offset = "0x108BA90", VA = "0x18108D090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x108B810", Offset = "0x108A210", VA = "0x18108B810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xD2A210", Offset = "0xD28C10", VA = "0x180D2A210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x81B2590", Offset = "0x81B0F90", VA = "0x1881B2590")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x81B25D0", Offset = "0x81B0FD0", VA = "0x1881B25D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x81B2120", Offset = "0x81B0B20", VA = "0x1881B2120")]
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

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
		public BEBMGMBEIIO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private HFOIEFHIBLD? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x81B25F0", Offset = "0x81B0FF0", VA = "0x1881B25F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
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
