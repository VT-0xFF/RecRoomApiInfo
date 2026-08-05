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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5BC20", Offset = "0x7E5A420", VA = "0x187E5BC20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5BCA0", Offset = "0x7E5A4A0", VA = "0x187E5BCA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DIADIMJDNBG]
internal class BKNMHEBFFNI : OEHOELAOAAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GCHKNFAPOJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public BKNMHEBFFNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CJONCCGGHCH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NNGLOMANNOD BADGEJBIHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DCOOPGBCPFA MMCLAHADMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DGALOKBDEJI KONNHIKNEBM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DC50", Offset = "0x7E3C450", VA = "0x187E3DC50")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	[UsedImplicitly]
	internal static void HLPHGODNDMF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F1C0", Offset = "0x7E3D9C0", VA = "0x187E3F1C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BKNMHEBFFNI([FAPODKMFODF(null)] NNGLOMANNOD BADGEJBIHCO, [FAPODKMFODF(null)] DCOOPGBCPFA MMCLAHADMDH, [FAPODKMFODF(null)] DGALOKBDEJI KONNHIKNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E910", Offset = "0x7E3D110", VA = "0x187E3E910", Slot = "5")]
	public BLGOLEELJGA PBLOHDBIEJA(CJONCCGGHCH KFPNMIJCCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DCC0", Offset = "0x7E3C4C0", VA = "0x187E3DCC0", Slot = "4")]
	public BLGOLEELJGA NCOGCFABDKL(CJONCCGGHCH KFPNMIJCCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D8D0", Offset = "0x7E3C0D0", VA = "0x187E3D8D0", Slot = "6")]
	public GEDBAJICPKM DOOIMONJNJK(BLGOLEELJGA IMINNNCPCJF, int MPDDLGFNLIA, string? HPANEBBHGAC, string? EKCIKEIHOEL, LLFJILOKJLH JAIHGHAJIFE, List<EPFGOPKFNIC>? OIKDMPJFCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E3DBC0", Offset = "0x7E3C3C0", VA = "0x187E3DBC0", Slot = "7")]
	public bool HHPFPPNCCCC(NALNGAMGADO LGJAFGEAOKB, [Out] BLGOLEELJGA? CLPELFLAOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E7A0", Offset = "0x7E3CFA0", VA = "0x187E3E7A0", Slot = "8")]
	public bool OCNPHPIAGHG(GEDBAJICPKM KKPOIPONPHG, [Out] BLGOLEELJGA? CLPELFLAOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3E880", Offset = "0x7E3D080", VA = "0x187E3E880", Slot = "9")]
	public bool PAFKOMFOENK(GEDBAJICPKM KKPOIPONPHG, [Out] IGOJFJLGCNK? LGJAFGEAOKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x372D700", Offset = "0x372BF00", VA = "0x18372D700")]
	private bool HMENANGKBKB<TInput, TOutput>(TInput FNFJALHKEGF, JJGFAJCCKMP<TInput, TOutput> EJAFGMDPBKF, [Out] TOutput? KJCFPPKBAOB) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D730", Offset = "0x7E3BF30", VA = "0x187E3D730")]
	[CompilerGenerated]
	private LHHCKEDJAIM CKGLNACMHFK(FaceFeatureType GMDJKCMLNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D9E0", Offset = "0x7E3C1E0", VA = "0x187E3D9E0")]
	[CompilerGenerated]
	private LHHCKEDJAIM FEANBABFLLG(FaceFeatureType GMDJKCMLNPH, GCHKNFAPOJK P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DIADIMJDNBG]
internal class DHNMOBNAPCC : NNGLOMANNOD
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void MKEMFBIMGKH<in TData>(TData CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NCDKKILFNNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public GIOCCJLKHIC rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public KGEFLHMMEHJ currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KGEFLHMMEHJ latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NCDKKILFNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E5BB80", Offset = "0x7E5A380", VA = "0x187E5BB80")]
		internal bool MHGGDFEJKBP(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E5BBA0", Offset = "0x7E5A3A0", VA = "0x187E5BBA0")]
		internal bool MMIEIIACKOL(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DGALOKBDEJI KONNHIKNEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AFIBAJHIFMJ IKIKFGGLHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MKEMFBIMGKH<BLGOLEELJGA>?[] BADGEJBIHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MKEMFBIMGKH<IGOJFJLGCNK>?[] DMDMLJIMONA;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E40140", Offset = "0x7E3E940", VA = "0x187E40140")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	[UsedImplicitly]
	internal static void HLPHGODNDMF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E40EB0", Offset = "0x7E3F6B0", VA = "0x187E40EB0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DHNMOBNAPCC([FAPODKMFODF(null)] DGALOKBDEJI KONNHIKNEBM, [FAPODKMFODF(null)] AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E40310", Offset = "0x7E3EB10", VA = "0x187E40310", Slot = "4")]
	public bool JNKIIHDJKAF(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E401B0", Offset = "0x7E3E9B0", VA = "0x187E401B0", Slot = "5")]
	public bool JNKIIHDJKAF(IGOJFJLGCNK LGJAFGEAOKB, IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F500", Offset = "0x7E3DD00", VA = "0x187E3F500")]
	private void DNNDPKGLGGH(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E405E0", Offset = "0x7E3EDE0", VA = "0x187E405E0")]
	private void MDOOKIKCGJE(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E40110", Offset = "0x7E3E910", VA = "0x187E40110")]
	private void HKJAIFMKFIG(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E400D0", Offset = "0x7E3E8D0", VA = "0x187E400D0")]
	private void FIFLLPLLKKC(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F380", Offset = "0x7E3DB80", VA = "0x187E3F380")]
	private void CODJBLOGAOL(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F450", Offset = "0x7E3DC50", VA = "0x187E3F450")]
	private void CPLNNPNBKCN(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E40E00", Offset = "0x7E3F600", VA = "0x187E40E00")]
	private void PJMJIBNHOML(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E40100", Offset = "0x7E3E900", VA = "0x187E40100")]
	private void HGIPBNGILPK(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E40AF0", Offset = "0x7E3F2F0", VA = "0x187E40AF0")]
	private void NLJPFBMMPAB(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? FOIMOKIBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E40B20", Offset = "0x7E3F320", VA = "0x187E40B20")]
	private void NMOINKHIHBJ(BLGOLEELJGA CLPELFLAOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E40810", Offset = "0x7E3F010", VA = "0x187E40810")]
	private BLGOLEELJGA NBAJGCAMIOM(BLGOLEELJGA CLPELFLAOOD, List<RangeMigration> AHAAAAFCHGB, KGEFLHMMEHJ PGOMDJOOGBM, KGEFLHMMEHJ BJGKFGDBNLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F340", Offset = "0x7E3DB40", VA = "0x187E3F340")]
	private float AEOOOFPLALG(float IHAAIMADIEG, Vector2 OPAAGODHPOA, Vector2 PHMINKFIFNJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E40410", Offset = "0x7E3EC10", VA = "0x187E40410")]
	private (RangeMigration?, RangeMigration?) LPAELMKFNCD(List<RangeMigration> AMLFFPPALMH, GIOCCJLKHIC AMEKNFINEGB, KGEFLHMMEHJ PGOMDJOOGBM, KGEFLHMMEHJ BJGKFGDBNLB)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NNGLOMANNOD
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JNKIIHDJKAF(BLGOLEELJGA CLPELFLAOOD, IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JNKIIHDJKAF(IGOJFJLGCNK LGJAFGEAOKB, IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC);
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
		public JFNAOAENFGO AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7E3B2C0", Offset = "0x7E39AC0", VA = "0x187E3B2C0")]
		public void FOHJIAPKACN(AnimationPoseSetting KEKEFPAJGHD, float OJFBFKBMNOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E3B3F0", Offset = "0x7E39BF0", VA = "0x187E3B3F0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3BCE0", Offset = "0x7E3A4E0", VA = "0x187E3BCE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E3BCA0", Offset = "0x7E3A4A0", VA = "0x187E3BCA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E3B410", Offset = "0x7E39C10", VA = "0x187E3B410")]
		private void COJPHMBLELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB190", Offset = "0x7DC9990", VA = "0x187DCB190", Slot = "4")]
		public void SetEnabled(bool EMMOENAPJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E3BD10", Offset = "0x7E3A510", VA = "0x187E3BD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3BD50", Offset = "0x7E3A550", VA = "0x187E3BD50")]
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

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7E3BD90", Offset = "0x7E3A590", VA = "0x187E3BD90")]
		public AnimationPoseSetting ADFFFMIJNHB(JFNAOAENFGO DIJMIGDDPDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7E3BDC0", Offset = "0x7E3A5C0", VA = "0x187E3BDC0")]
		public void HNPKBJNJFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7E3BE00", Offset = "0x7E3A600", VA = "0x187E3BE00")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum AGAGKNLMAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private AGAGKNLMAFJ handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x7E3C8F0", Offset = "0x7E3B0F0", VA = "0x187E3C8F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C8B0", Offset = "0x7E3B0B0", VA = "0x187E3C8B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C2B0", Offset = "0x7E3AAB0", VA = "0x187E3C2B0")]
		private void COJPHMBLELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DCB190", Offset = "0x7DC9990", VA = "0x187DCB190", Slot = "4")]
		public void SetEnabled(bool EMMOENAPJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C920", Offset = "0x7E3B120", VA = "0x187E3C920")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, OPOKOIJPPKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		[Header("Configuration")]
		private CJONCCGGHCH avatarBodyType;

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
		[GKBMICLOBGF(CGAFHOMJNOP.SelfAndChildren, false, false, false)]
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
		[Header("Equipment Slots")]
		[SerializeField]
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
		private ALKDACMNLHL JKDCGGCKNBL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ALKDACMNLHL FIPCLONIEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB240E0", Offset = "0xB228E0", VA = "0x180B240E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform DIJJOEEBMAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7E3D710", Offset = "0x7E3BF10", VA = "0x187E3D710", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C950", Offset = "0x7E3B150", VA = "0x187E3C950")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D5D0", Offset = "0x7E3BDD0", VA = "0x187E3D5D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D580", Offset = "0x7E3BD80", VA = "0x187E3D580")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D510", Offset = "0x7E3BD10", VA = "0x187E3D510")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E3C950", Offset = "0x7E3B150", VA = "0x187E3C950", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CCE0", Offset = "0x7E3B4E0", VA = "0x187E3CCE0", Slot = "6")]
		public ALKDACMNLHL CreateAvatarSystem(string JCJKPLKKFOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D510", Offset = "0x7E3BD10", VA = "0x187E3D510", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E3CA10", Offset = "0x7E3B210", VA = "0x187E3CA10", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D620", Offset = "0x7E3BE20", VA = "0x187E3D620", Slot = "9")]
		public void UpdatePostIKAnimControllers(float JGHFILFLDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class JGDFNCJGEJF : ALKDACMNLHL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class ODGFMPNPCMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Vector3 AEODDNHIMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Quaternion PLOJHPEGLOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 EAIBIDHKFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Transform IMMNMIFAPBO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 OIGMCLPHADG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1FFAD80", Offset = "0x1FF9580", VA = "0x181FFAD80")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FFADA0", Offset = "0x1FF95A0", VA = "0x181FFADA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion KKFKBLJBIPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x10EB6D0", Offset = "0x10E9ED0", VA = "0x1810EB6D0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x10EA950", Offset = "0x10E9150", VA = "0x1810EA950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float GKPAFBLBMPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1122B10", Offset = "0x1121310", VA = "0x181122B10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x181F190", Offset = "0x181D990", VA = "0x18181F190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool EFFHPKLAKKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4B0", Offset = "0xA2BCB0", VA = "0x180A2D4B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA2D490", Offset = "0xA2BC90", VA = "0x180A2D490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool FCBIMKGCPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3A0", Offset = "0xA2BBA0", VA = "0x180A2D3A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA2D470", Offset = "0xA2BC70", VA = "0x180A2D470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool FBBMIJABOHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3C0", Offset = "0xA2BBC0", VA = "0x180A2D3C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4C0", Offset = "0xA2BCC0", VA = "0x180A2D4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float MDKKOJIHBJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD13080", Offset = "0xD11880", VA = "0x180D13080")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xD140A0", Offset = "0xD128A0", VA = "0x180D140A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E65B50", Offset = "0x7E64350", VA = "0x187E65B50")]
		public void BMKJGOEAJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E65B40", Offset = "0x7E64340", VA = "0x187E65B40")]
		public void AJGAIHGPGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7E65CD0", Offset = "0x7E644D0", VA = "0x187E65CD0")]
		public float FIFBOHJCDBD(Vector3 BGIHIJGCNPG, Quaternion IDAKFMHEFOO, [In] AvatarFootSettings BKBNEPLOOML, float OMMLOLLCKOD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E65EE0", Offset = "0x7E646E0", VA = "0x187E65EE0")]
		public void HHFGDGAFOLA(Vector3 GHDNEILPOON, Quaternion IAEAPOHJDGB, Transform HKEBEKFFLHH, float JLAEIOKMINJ, bool KKIJDAFHMMI, bool NPMAPNOAFMO, float MCCPCONKLEH, float OJJCLPIDGIE, Transform MJAMEBJFAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E666B0", Offset = "0x7E64EB0", VA = "0x187E666B0")]
		public void MOKOFIGEMMM(Transform JENBNBAGFPK, Transform MJAMEBJFAIN, bool PAJNONFKKCC, bool OMPDNBNFNOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E665B0", Offset = "0x7E64DB0", VA = "0x187E665B0")]
		private void LFDGAEGDMAM(Transform MJAMEBJFAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E65B80", Offset = "0x7E64380", VA = "0x187E65B80")]
		public void FFDMLGPMEFF(Transform MJAMEBJFAIN, AvatarFullBodyConfiguration LDCOIJIBFHA, Vector3 CCBIMMCBIGD, float ILCENEPIPEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E65B60", Offset = "0x7E64360", VA = "0x187E65B60")]
		public void ELFNCHPLLCH(float OJJCLPIDGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E668E0", Offset = "0x7E650E0", VA = "0x187E668E0")]
		public ODGFMPNPCMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class OADMIIBDIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private float MGEDNDJIBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private bool IKJLJGABDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AnimationPoseSetting FNEHJBFBCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private float ACNLMMCJOCM;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E644A0", Offset = "0x7E62CA0", VA = "0x187E644A0")]
		public void GBKJNALMKNH(IKSolverVR.Arm AJELHFMAIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E64460", Offset = "0x7E62C60", VA = "0x187E64460")]
		public void FEHANCOBELJ(IKSolverVR.Arm AJELHFMAIPI, float MFJHMOPBHPO, bool IKJLJGABDNC, AvatarFullBodyConfiguration LDCOIJIBFHA, float GBGEOECKKBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E644D0", Offset = "0x7E62CD0", VA = "0x187E644D0")]
		private void IFLELCJGANH(IKSolverVR.Arm AJELHFMAIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E650E0", Offset = "0x7E638E0", VA = "0x187E650E0")]
		public void NJEJHIFFHDN(IKSolverVR.Arm AJELHFMAIPI, Transform CAKCBOJGKKB, Transform HKEBEKFFLHH, Quaternion HAAHIECACKJ, Vector3 OFGCPLBANNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E64510", Offset = "0x7E62D10", VA = "0x187E64510")]
		private (Vector3, Quaternion) IJEOLONJGIF(JCBCLFGKHFJ PPOKHIFEEGG, Quaternion GCACPBDCEJP, Vector3 GEGBAHDNOIP)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E649A0", Offset = "0x7E631A0", VA = "0x187E649A0")]
		public void JPJAEGDDAGI(JCBCLFGKHFJ PPOKHIFEEGG, IKSolverVR.Arm AJELHFMAIPI, Quaternion GCACPBDCEJP, Vector3 GEGBAHDNOIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E654C0", Offset = "0x7E63CC0", VA = "0x187E654C0")]
		public void OBHFNAHCFGI(JCBCLFGKHFJ PPOKHIFEEGG, IKSolverVR.Arm AJELHFMAIPI, Quaternion GCACPBDCEJP, Vector3 GEGBAHDNOIP, [In] AvatarFullBodyConfiguration LDCOIJIBFHA, [In] JKGAEDPPCAA OJGLGPLNKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E64FA0", Offset = "0x7E637A0", VA = "0x187E64FA0")]
		public void MJJKIDJCGEL(JFNAOAENFGO EEGLJJJMIMK, AvatarFullBodyConfiguration LDCOIJIBFHA, JKGAEDPPCAA OJGLGPLNKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E64B00", Offset = "0x7E63300", VA = "0x187E64B00")]
		public void LFPLLODAOFI(IKSolverVR.Arm AJELHFMAIPI, Transform CAKCBOJGKKB, Vector3 DPJCEMLDJOC, float HPNKALLMCDG, Quaternion ILAHJKMAMFJ, Vector3 CANDCBKFCBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E65AC0", Offset = "0x7E642C0", VA = "0x187E65AC0")]
		public OADMIIBDIKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum IHMKGOHLOEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FPBDCNAJCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct NJMDIKCOKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int INIGLEBJAPC;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int HMODCLLPPDK;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int ADMCHCJDEJF;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int JGGGACAOJEF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int PFMFOMDPFIJ;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int IEIFCHGMPCI;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int GNIEGABENFB;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int JDKPCHMBGKH;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int EIJPEHKGDHG;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int KMFOOIMPNJN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int CAOAAADJFOG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int JHGOMJNBFKB;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int ICGOPMLOMNE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int BMFBEPEPGJH;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int NLJPKIEJJHP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int NNLBCNJPLGM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int HAGNFJOCMNO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int AMLFOJHGDPJ;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int AHFOLHPOPLF;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int HJIIJOEOFME;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int FJJHEBEBGHB;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int EHDJBJFGONP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int FEJALODHNMF;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int LGKBCINIHJP;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int HJGGGLPMCFN;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int DIHIFMCNIMD;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int MPKHPCAKEGL;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int PKJPMAJKNBB;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int PGICDIADOJP;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int DCKJEMPFFJM;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int CDGPLPLGFKN;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int BKMKDDGEONF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 JHDLJIPALLP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int GADNEDOAOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool PIBEOJNEGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool CAAJHFECJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool PILIOAMDCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool NJAPPLBCKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool GGDMILJKEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool ODHHKFGOBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 IGNAEOKAHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string GCMCAIAIGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private KIMODIHJPAE? FADNEFADOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private BMCIKEIJKJC? MLPMOFKMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private OEIDMFLEFCG BHECNDKNHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private GEDBPIOCADA DMLEKOPKHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private JCBCLFGKHFJ BNKBIKALFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private JCBCLFGKHFJ KAJBMDAPDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool MFDOPHCILIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool BJAGDOJACHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly PDHBKGEIGLD DGCIHLMPGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly MJCLEAGEKFI OMEAEOAGLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int FNLBKMNMNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float NMIGDFCKKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject OAPEHFPGDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform COOILCMMHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform DFCBCBKDFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform ONPJNAGAOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform GEMPEDEHKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float DIOGADJLFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float EONCICPBHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 DNPEJDIFFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion FABELLOMHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform MEJOPMEHLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform FOPBGECCAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform APENMILPNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private DKAALOPIDKO IGGEKIAMILN;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker OILBLDCLLKB;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker EBLJEJPEHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker DABHKMKOHBJ;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker GBPFHHDMOFM;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker MMMELNPOADD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker MCKODMBNPII;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<JGDFNCJGEJF> PIHHBBLPJML;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int FEIGMLEBMOK;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> FAJMGKDMJAF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int CCAMCMLFJHK;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int HELKKLPBHMM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int BBJBIAIDAOB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int OIMBKIIEKNC;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float DDOAEHBLPOJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int EJKEILHDHCG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float INIPFIAKNKG;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float HHKIADCOCEM;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float AJKDKAIKCOI;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float HDEIHPFGLPG;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static AKFHKNHAELL LNMOFFMFIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float IJBDDMPJNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool FCBNHCJNJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float KHFIOLJNGJE;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int LNHNPKIGJDG;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int ENFPCDOCCLA;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int FIBLBAIHPJA;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int CNNLHODDGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private ODGFMPNPCMF IHHNKAHAGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private ODGFMPNPCMF CKDEAOBAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float MALFPOPHKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 DKOOBDAJDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 OJGLDEIGJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool FPODCBNPIHA;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly Quaternion CMJBHBPGKJN;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion AEPFICAJNKJ;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Vector3 KHKJKAKOAFO;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 PMBNICHNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float CDKPAIJGLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float OOHJBKILINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private OADMIIBDIKJ EDOKJDGAJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private OADMIIBDIKJ JBGGPCCCFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private BLEDPEJHDCB MHNHJKNMBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private BKKBLCCLCKD NCCOHGAPJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly NCCLAIFEGFO GLPFKMBNNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float IMEMGJCFLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float PKCAMLKHHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly BKKBLCCLCKD LHLKGKENNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private Vector3 KHJHCFNBMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 ODOHMJMCJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private float DNOKEMKEEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float DLPKKGHDAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly BKKBLCCLCKD PENBFEJPJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly BLEDPEJHDCB FNEMFHOILEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly BKKBLCCLCKD PFMEEJPIKNC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KECNPIDOCPH DOBOGANNAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KECNPIDOCPH HOBCLEJALFE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration HICJKOOOICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7E54790", Offset = "0x7E52F90", VA = "0x187E54790", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CJONCCGGHCH FKBBHJAMMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A290", Offset = "0x7E48A90", VA = "0x187E4A290", Slot = "24")]
		get
		{
			return default(CJONCCGGHCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration OLCDEPGHDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7E53D90", Offset = "0x7E52590", VA = "0x187E53D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform HDEIEAFFCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7E566B0", Offset = "0x7E54EB0", VA = "0x187E566B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform LGILLALCEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7E54690", Offset = "0x7E52E90", VA = "0x187E54690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer BLCKELAHACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7E53F10", Offset = "0x7E52710", VA = "0x187E53F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] ILDIBDGOBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C540", Offset = "0x7E4AD40", VA = "0x187E4C540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] HJFAIOHOCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C170", Offset = "0x7E4A970", VA = "0x187E4C170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator NFCLPOLMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B880", Offset = "0x7E4A080", VA = "0x187E4B880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK NGFGDOCCMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B780", Offset = "0x7E49F80", VA = "0x187E4B780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private IOOHCENIFJI LHGCKNBPKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4CE30", Offset = "0x7E4B630", VA = "0x187E4CE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private IOOHCENIFJI ADAJPDPPMJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E56090", Offset = "0x7E54890", VA = "0x187E56090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private IOOHCENIFJI DLIOCGAGMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E46A70", Offset = "0x7E45270", VA = "0x187E46A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private IOOHCENIFJI LGCOAEINIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BBE0", Offset = "0x7E4A3E0", VA = "0x187E4BBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private IOOHCENIFJI AMJFIMFJKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7E53110", Offset = "0x7E51910", VA = "0x187E53110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private IOOHCENIFJI MKMMCLHMFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7E54590", Offset = "0x7E52D90", VA = "0x187E54590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private IOOHCENIFJI HDIAJPJNOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E52B10", Offset = "0x7E51310", VA = "0x187E52B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private IOOHCENIFJI DNCEGNPNHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7E517D0", Offset = "0x7E4FFD0", VA = "0x187E517D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BMCIKEIJKJC FCKBKBNGFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E54480", Offset = "0x7E52C80", VA = "0x187E54480", Slot = "16")]
		get
		{
			return default(BMCIKEIJKJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MEKGIBHCPGB GAECDNFMMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAD4CF0", Offset = "0xAD34F0", VA = "0x180AD4CF0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DEJGECFFKMC DLHFIMANFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB47430", Offset = "0xB45C30", VA = "0x180B47430", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KKBENOBLINI PGONDBIHNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAD4FA0", Offset = "0xAD37A0", VA = "0x180AD4FA0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KKBENOBLINI CDCPNLHMHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB47130", Offset = "0xB45930", VA = "0x180B47130", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string BLEGDBJIHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform IDAGPMALJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E530C0", Offset = "0x7E518C0", VA = "0x187E530C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform AHCAILFLAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A0D0", Offset = "0x7E488D0", VA = "0x187E4A0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform DJHKOFNBCFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E57E10", Offset = "0x7E56610", VA = "0x187E57E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform POEHPIONJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E51020", Offset = "0x7E4F820", VA = "0x187E51020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform HFNGMLHAECA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A850", Offset = "0x7E59050", VA = "0x187E5A850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool IKNDLNGDDML
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E44340", Offset = "0x7E42B40", VA = "0x187E44340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool NEMKEBLNBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E44340", Offset = "0x7E42B40", VA = "0x187E44340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool PBFKIGHLECP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7E51FB0", Offset = "0x7E507B0", VA = "0x187E51FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform PGHNIDMGIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F0E0", Offset = "0x7E4D8E0", VA = "0x187E4F0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject EMOLHEPHCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E53E20", Offset = "0x7E52620", VA = "0x187E53E20", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets ANBKEEIFKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E469F0", Offset = "0x7E451F0", VA = "0x187E469F0", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform JAANOFMAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB47440", Offset = "0xB45C40", VA = "0x180B47440", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform LKEJEJDAJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB469A0", Offset = "0xB451A0", VA = "0x180B469A0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform IOJAIECNFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB348E0", Offset = "0xB330E0", VA = "0x180B348E0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform AMOFHHDHAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4F10", Offset = "0xAD3710", VA = "0x180AD4F10", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 AHPLAFMLEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7E4CF30", Offset = "0x7E4B730", VA = "0x187E4CF30", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float KPEJDLBGFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7E53EC0", Offset = "0x7E526C0", VA = "0x187E53EC0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform IHMOLACJABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7E4ABF0", Offset = "0x7E493F0", VA = "0x187E4ABF0", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform CAMJBBCBCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x143CC40", Offset = "0x143B440", VA = "0x18143CC40", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform PDGFNCPLNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAD4F20", Offset = "0xAD3720", VA = "0x180AD4F20", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform DPKMMJNACFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x23C81A0", Offset = "0x23C69A0", VA = "0x1823C81A0", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool KMGCJODGGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E548C0", Offset = "0x7E530C0", VA = "0x187E548C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool IAKNDIGPFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E56010", Offset = "0x7E54810", VA = "0x187E56010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool BFEMFAIKIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E51240", Offset = "0x7E4FA40", VA = "0x187E51240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C270", Offset = "0x7E4AA70", VA = "0x187E4C270")]
	private float GDKOFLPEDEC(MPAMJMIIGEP IJKBGDNHCOA, float BGIAMFOMPNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E482F0", Offset = "0x7E46AF0", VA = "0x187E482F0")]
	private void DADHBAKNCBI([In] JKGAEDPPCAA IJGGEPJDCCI, [In] AvatarFullBodyConfiguration LDCOIJIBFHA, bool CCDAEHDKPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F620", Offset = "0x7E4DE20", VA = "0x187E4F620")]
	private float IAMOHFEJCPD([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AC50", Offset = "0x7E49450", VA = "0x187E4AC50")]
	private float EHJCEFCOJOB([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E51060", Offset = "0x7E4F860", VA = "0x187E51060")]
	private void IJNFBGLPAOP(JKGAEDPPCAA IJGGEPJDCCI, AvatarFullBodyConfiguration LDCOIJIBFHA, bool CCDAEHDKPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E55C20", Offset = "0x7E54420", VA = "0x187E55C20")]
	private void NDCDLFFNNFF([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E41690", Offset = "0x7E3FE90", VA = "0x187E41690")]
	private void ACLHEKFGHPL([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B6E0", Offset = "0x7E59EE0", VA = "0x187E5B6E0")]
	public JGDFNCJGEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7E586A0", Offset = "0x7E56EA0", VA = "0x187E586A0", Slot = "13")]
	public void PAOLMJJFGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E52D10", Offset = "0x7E51510", VA = "0x187E52D10", Slot = "14")]
	public void JPBCPKECCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E567B0", Offset = "0x7E54FB0", VA = "0x187E567B0", Slot = "15")]
	public void NIOLELMDGCB(bool GOFAKPMFCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CCE0", Offset = "0x7E4B4E0", VA = "0x187E4CCE0", Slot = "26")]
	public Transform HELAPIFHPDB(string AOACOOAOMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A390", Offset = "0x7E48B90", VA = "0x187E4A390", Slot = "27")]
	public Vector3? DLBOAGMLNIM(string AOACOOAOMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B4E0", Offset = "0x7E49CE0", VA = "0x187E4B4E0", Slot = "7")]
	public void FEGLMDCLPML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E520A0", Offset = "0x7E508A0", VA = "0x187E520A0")]
	private void JGACLGNPEJB(AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E41B30", Offset = "0x7E40330", VA = "0x187E41B30", Slot = "8")]
	public void AGALLNMLHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E52C10", Offset = "0x7E51410", VA = "0x187E52C10")]
	private void JLNAAMGOBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A110", Offset = "0x7E48910", VA = "0x187E4A110")]
	private Vector3 DGNCPADFAEH([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E584B0", Offset = "0x7E56CB0", VA = "0x187E584B0", Slot = "6")]
	public void OILONMHNKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E534B0", Offset = "0x7E51CB0", VA = "0x187E534B0")]
	private void KIJMNLEOMHP(bool CCDAEHDKPKH, IHMKGOHLOEF ODAOFDKIDCJ, AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B980", Offset = "0x7E4A180", VA = "0x187E4B980", Slot = "9")]
	public void FMHBFJHNLFH(float FKOHELNDNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A080", Offset = "0x7E48880", VA = "0x187E4A080")]
	private void DCGHEJDDPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E41F40", Offset = "0x7E40740", VA = "0x187E41F40", Slot = "4")]
	public void AILCKNICINN(string JCJKPLKKFOP, KIMODIHJPAE MEOFKFJHGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E46570", Offset = "0x7E44D70", VA = "0x187E46570", Slot = "5")]
	public void CJPJFAMHBAH(BMCIKEIJKJC HECBLBAKOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B380", Offset = "0x7E49B80", VA = "0x187E4B380", Slot = "12")]
	public void FEFBKINEFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7E55890", Offset = "0x7E54090", VA = "0x187E55890", Slot = "25")]
	public void NCLDJLOKJFP([Out] Vector3 LGBCHEJAFDK, [Out] Quaternion ILAHJKMAMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E571E0", Offset = "0x7E559E0", VA = "0x187E571E0")]
	private void NNJPKONBEDJ([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x122E4C0", Offset = "0x122CCC0", VA = "0x18122E4C0", Slot = "28")]
	public void ONFPAIOABNP(float KNDJGMOJOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E56E90", Offset = "0x7E55690", VA = "0x187E56E90", Slot = "29")]
	public void NNJNDPGGOPP(float BICELGCKOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F090", Offset = "0x7E4D890", VA = "0x187E4F090", Slot = "45")]
	public void HNHKGIMDEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E511F0", Offset = "0x7E4F9F0", VA = "0x187E511F0", Slot = "30")]
	public void IPJNGBIEKKA(bool LKCGADGGLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E53210", Offset = "0x7E51A10", VA = "0x187E53210", Slot = "31")]
	public HandLogicOffsets KDEHLHBHIGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7E44390", Offset = "0x7E42B90", VA = "0x187E44390", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets BABFCEDCJMD()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E41D70", Offset = "0x7E40570", VA = "0x187E41D70")]
	private void AIEMLOMEPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E56D10", Offset = "0x7E55510", VA = "0x187E56D10")]
	private void NMAIPHIDOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F1E0", Offset = "0x7E4D9E0", VA = "0x187E4F1E0")]
	private void IAFLKFONKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E417D0", Offset = "0x7E3FFD0", VA = "0x187E417D0")]
	private void AEPDODBAAGA(LHDELCHFOJE LOBMKMMADMF, bool FMFJOLALOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E41510", Offset = "0x7E3FD10", VA = "0x187E41510")]
	private void ACKJLPDNLKP(LHDELCHFOJE LOBMKMMADMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7E54E00", Offset = "0x7E53600", VA = "0x187E54E00")]
	public Vector3 MLIGBGHAMAK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7E518D0", Offset = "0x7E500D0", VA = "0x187E518D0")]
	private void JCDJDPLOFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A060", Offset = "0x7E48860", VA = "0x187E4A060")]
	private void DBJFFAJFCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4ACD0", Offset = "0x7E494D0", VA = "0x187E4ACD0")]
	private void FBIGDOEIIKB(JKGAEDPPCAA IJGGEPJDCCI, AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7E56B60", Offset = "0x7E55360", VA = "0x187E56B60")]
	private float NLMGHPKABBA([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C460", Offset = "0x7E4AC60", VA = "0x187E4C460")]
	private int GHLBENJGCKI([In] GDODOMJKNKM OJPOKOEHGDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E56190", Offset = "0x7E54990", VA = "0x187E56190")]
	private void NGFJOLEBNHB(JKGAEDPPCAA IJGGEPJDCCI, bool JEJPEBOHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7E4BCE0", Offset = "0x7E4A4E0", VA = "0x187E4BCE0")]
	private static void GBDJCBKLGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E50320", Offset = "0x7E4EB20", VA = "0x187E50320")]
	private static void IGNAGADEEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E44170", Offset = "0x7E42970", VA = "0x187E44170")]
	private float ALJDBOPJABP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E54890", Offset = "0x7E53090", VA = "0x187E54890")]
	private static int MGNGFOKDIOJ(JGDFNCJGEJF HGBNKPCDEON, JGDFNCJGEJF DPOCHOAKFKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E45060", Offset = "0x7E43860", VA = "0x187E45060", Slot = "41")]
	public JKGAEDPPCAA BELLMCPHGML()
	{
		return default(JKGAEDPPCAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E54010", Offset = "0x7E52810", VA = "0x187E54010")]
	private bool LMAFHHNLHND(int EBHOIBHGECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E451B0", Offset = "0x7E439B0", VA = "0x187E451B0")]
	public void BGLKLPELIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C290", Offset = "0x7E4AA90", VA = "0x187E4C290")]
	private (bool, bool) GFIIAFKAGHA()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CB00", Offset = "0x7E4B300", VA = "0x187E4CB00")]
	private (float, float) HBAGNOPHDGH([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CFC0", Offset = "0x7E4B7C0", VA = "0x187E4CFC0")]
	private void HJINHAGCOBO([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E47FD0", Offset = "0x7E467D0", VA = "0x187E47FD0")]
	private void CPOMNDPGCEL([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C640", Offset = "0x7E4AE40", VA = "0x187E4C640")]
	private void GNOCJLIKFNH([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA, AvatarFootSettings BKBNEPLOOML, bool KMFPBPEAAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E41AB0", Offset = "0x7E402B0", VA = "0x187E41AB0")]
	private float AFBKGLDMBCD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7E58BA0", Offset = "0x7E573A0", VA = "0x187E58BA0")]
	private void PCKPBMHFMCO(JKGAEDPPCAA OJGLGPLNKGO, AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E512C0", Offset = "0x7E4FAC0", VA = "0x187E512C0")]
	private float JAAONKNGNGN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E54E50", Offset = "0x7E53650", VA = "0x187E54E50")]
	private void MLLANFKDPKO([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E56880", Offset = "0x7E55080", VA = "0x187E56880")]
	private void NJEJHIFFHDN([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E51BC0", Offset = "0x7E503C0", VA = "0x187E51BC0")]
	private void JDOOFCEEEHC([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E55600", Offset = "0x7E53E00", VA = "0x187E55600")]
	private void NBDDHPNJJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A890", Offset = "0x7E59090", VA = "0x187E5A890")]
	private void PPLKEHOPNGM(float DDJNJBNNBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E45230", Offset = "0x7E43A30", VA = "0x187E45230")]
	private void BIOAEFLBMCN([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E49DD0", Offset = "0x7E485D0", VA = "0x187E49DD0")]
	private void DBGBBEOOOFF(JCBCLFGKHFJ OJMHCHJKBIH, IKSolverVR.Arm AJELHFMAIPI, Transform GIKFJOOLDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E51310", Offset = "0x7E4FB10", VA = "0x187E51310")]
	private void JAMEDEPPOFC(JKGAEDPPCAA OJGLGPLNKGO, AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E44450", Offset = "0x7E42C50", VA = "0x187E44450")]
	private void BAHKHJCGICF(FBFBPPNBDEF MONAMBLMANL, KKBENOBLINI OJMHCHJKBIH, IKSolverVR.Arm AJELHFMAIPI, float MFJHMOPBHPO, float MBEFDPCOKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EE80", Offset = "0x7E4D680", VA = "0x187E4EE80")]
	private void HLLFDIAGOAI([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E44620", Offset = "0x7E42E20", VA = "0x187E44620")]
	private void BAIKGEFNONH([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E52750", Offset = "0x7E50F50", VA = "0x187E52750")]
	protected void JHKEDNGMNHN([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E57AC0", Offset = "0x7E562C0", VA = "0x187E57AC0")]
	private void NPOHGBGEICO([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E53260", Offset = "0x7E51A60", VA = "0x187E53260")]
	protected void KEMKKCPNFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E59720", Offset = "0x7E57F20", VA = "0x187E59720")]
	private void PIOBEJIJGCM([In] JKGAEDPPCAA OJGLGPLNKGO, [In] IHMKGOHLOEF ODAOFDKIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E47E20", Offset = "0x7E46620", VA = "0x187E47E20")]
	private void CPOFFOAANOI(JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E41790", Offset = "0x7E3FF90", VA = "0x187E41790")]
	private void ADDCABCJLPA([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A520", Offset = "0x7E48D20", VA = "0x187E4A520")]
	private Vector3 EBEIAEJJBLC([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E46B70", Offset = "0x7E45370", VA = "0x187E46B70")]
	private void CNOOIJPIKJM([In] JKGAEDPPCAA OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E549B0", Offset = "0x7E531B0", VA = "0x187E549B0")]
	private float MIPNPKMKHEN(float OJJCLPIDGIE, [In] JKGAEDPPCAA OJGLGPLNKGO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FA10", Offset = "0x7E4E210", VA = "0x187E4FA10")]
	private void IDBEJOAJFKL(float OJJCLPIDGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E45E80", Offset = "0x7E44680", VA = "0x187E45E80")]
	private void CHFNKHGDAFC([In] JKGAEDPPCAA OJGLGPLNKGO, IHMKGOHLOEF ODAOFDKIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E59F40", Offset = "0x7E58740", VA = "0x187E59F40")]
	private float PLLPHJGNEJD([In] JKGAEDPPCAA IJGGEPJDCCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E46C40", Offset = "0x7E45440", VA = "0x187E46C40")]
	private void COMMDHFDIBC(JKGAEDPPCAA OJGLGPLNKGO, IHMKGOHLOEF ODAOFDKIDCJ, Vector3 FEDKCOBIMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7E57E40", Offset = "0x7E56640", VA = "0x187E57E40")]
	private static void OCBJKEPFMNK(Transform KCODNJGBFEK, Quaternion FENAGHBAFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EB50", Offset = "0x7E4D350", VA = "0x187E4EB50")]
	private void HKLEGHPFFEG([In] JKGAEDPPCAA EOIGFLMHAMP, [In] GDODOMJKNKM OJPOKOEHGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E57210", Offset = "0x7E55A10", VA = "0x187E57210")]
	private void NNLCLPLCEHJ([In] JKGAEDPPCAA EOIGFLMHAMP, [In] GDODOMJKNKM OJPOKOEHGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B9F0", Offset = "0x7E4A1F0", VA = "0x187E4B9F0")]
	private void FNEALCOGFKM(float LBFBDACDKJI, [In] JKGAEDPPCAA IJGGEPJDCCI, float MHDJLBFJHMG = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E4FB60", Offset = "0x7E4E360", VA = "0x187E4FB60")]
	private float IFGOLDBOOIL([In] JKGAEDPPCAA IJGGEPJDCCI, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E55310", Offset = "0x7E53B10", VA = "0x187E55310")]
	private void MPPAIMDJPBK([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E45470", Offset = "0x7E43C70", VA = "0x187E45470")]
	private void BNELBNLACMN([In] JKGAEDPPCAA IJGGEPJDCCI, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7E540B0", Offset = "0x7E528B0", VA = "0x187E540B0")]
	private void LMDIGFIJDLG([In] JKGAEDPPCAA IJGGEPJDCCI, float CLLBBGHKEKI, float GPCOMHGCLCJ, Vector3 GECEBMMOKHJ, float MHDJLBFJHMG = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E47430", Offset = "0x7E45C30", VA = "0x187E47430")]
	private void CPFKCIHBMFN(JKGAEDPPCAA IJGGEPJDCCI, AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E4BEE0", Offset = "0x7E4A6E0", VA = "0x187E4BEE0")]
	private void GCBPJABOEDD(JKGAEDPPCAA OJGLGPLNKGO, AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E57FF0", Offset = "0x7E567F0", VA = "0x187E57FF0")]
	private void ODNGOAMFPFL(JKGAEDPPCAA IJGGEPJDCCI, AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AA30", Offset = "0x7E49230", VA = "0x187E4AA30")]
	public void ECDALANFPIN([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F6B0", Offset = "0x7E4DEB0", VA = "0x187E4F6B0")]
	public void ICFGMFLIGLF([In] JKGAEDPPCAA OJGLGPLNKGO, [In] AvatarFullBodyConfiguration LDCOIJIBFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E41DA0", Offset = "0x7E405A0", VA = "0x187E41DA0")]
	[CompilerGenerated]
	internal static void AIKBOCJHGFL(Transform GJKNNKIANJJ, IKSolverVR.Arm AJELHFMAIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E453C0", Offset = "0x7E43BC0", VA = "0x187E453C0")]
	[CompilerGenerated]
	internal static void BJKDONBBNMM(Vector3 ONNKIBGMDBH, Vector3 EIIBHALMEMA, FPBDCNAJCDJ P_2, NJMDIKCOKCI P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CA60", Offset = "0x7E4B260", VA = "0x187E4CA60")]
	[CompilerGenerated]
	internal static void GPLFBFIBAKI(ODGFMPNPCMF PPIIKCPONIB, ODGFMPNPCMF JPDDGLAJEPH, Vector3 LDOLMNPGAMC, float MEBFHJECJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A740", Offset = "0x7E58F40", VA = "0x187E5A740")]
	[CompilerGenerated]
	internal static bool PMDHJEDBGMH(IKSolverVR.Arm AJELHFMAIPI, BFKICGJGOCM MLKJJEMGGBP, float BPHEEJBOCDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E44C20", Offset = "0x7E43420", VA = "0x187E44C20")]
	[CompilerGenerated]
	internal static float BDKEJGBLCHP(Vector3 JDMKLPPDDCI, Vector3 IHEENJPNHKL, Vector3 MDNPFJFMNDG, JKGAEDPPCAA IJGGEPJDCCI, AvatarFullBodyConfiguration LDCOIJIBFHA, float BJCMHPBMOOK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class PFNPKBAEAHK : CCLEFODNHKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Dictionary<string, ALKDACMNLHL> IEGNILFKBBD;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7E67400", Offset = "0x7E65C00", VA = "0x187E67400")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	internal static void HGFEMAMBAFP(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7E66EC0", Offset = "0x7E656C0", VA = "0x187E66EC0", Slot = "4")]
	public ALKDACMNLHL EEJOOFPFNLB(string PFGMCCKNNJD, AvatarSystemConfiguration JNGPAICEHML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7E67220", Offset = "0x7E65A20", VA = "0x187E67220", Slot = "5")]
	public void FOCKEHNGHJA(string PFGMCCKNNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7E670E0", Offset = "0x7E658E0", VA = "0x187E670E0", Slot = "6")]
	public string FEJBDAMDKMI(string JAHALDGAAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7E67470", Offset = "0x7E65C70", VA = "0x187E67470")]
	private string JGHGCCDCAKB(string JAHALDGAAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7E674E0", Offset = "0x7E65CE0", VA = "0x187E674E0")]
	public PFNPKBAEAHK()
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
		public class DNEHOODKJLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private Dictionary<string, Transform> HMLBOGBLEFD;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool KBMDKILMFNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x7E5DDB0", Offset = "0x7E5C5B0", VA = "0x187E5DDB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7E5DC80", Offset = "0x7E5C480", VA = "0x187E5DC80")]
			public void CHOJINDOIKG(VRIK MABBMLKOOLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
			public void IFBBIIAPGND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7E5DDF0", Offset = "0x7E5C5F0", VA = "0x187E5DDF0")]
			public void MMBGNLDGDEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7E5DE40", Offset = "0x7E5C640", VA = "0x187E5DE40")]
			public DNEHOODKJLM()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		[GFEALGLPKIM(CGAFHOMJNOP.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[GKBMICLOBGF(CGAFHOMJNOP.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private readonly DNEHOODKJLM BHNNKGIJBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private OPOKOIJPPKB MILLGPFMNJD;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CA90", Offset = "0x7E5B290", VA = "0x187E5CA90")]
		private void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CD70", Offset = "0x7E5B570", VA = "0x187E5CD70")]
		private bool JPGCBOEJDPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CDC0", Offset = "0x7E5B5C0", VA = "0x187E5CDC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CE30", Offset = "0x7E5B630", VA = "0x187E5CE30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CDD0", Offset = "0x7E5B5D0", VA = "0x187E5CDD0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D0A0", Offset = "0x7E5B8A0", VA = "0x187E5D0A0")]
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
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7E60A00", Offset = "0x7E5F200", VA = "0x187E60A00")]
			public (float, float) EAFOHLLAJJC(float GFMIJMLIOKP)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7E60230", Offset = "0x7E5EA30", VA = "0x187E60230")]
			public void HNPKBJNJFKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E600F0", Offset = "0x7E5E8F0", VA = "0x187E600F0")]
			public (float, float) AGJDCFHEIDF(Animator NENMJJJOCJL, AnimatorStateInfo GPOICKBHLHI)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7E60310", Offset = "0x7E5EB10", VA = "0x187E60310")]
		public void HNPKBJNJFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7E60500", Offset = "0x7E5ED00", VA = "0x187E60500")]
		public (float, float) JPAOKFFBPBA(Animator NENMJJJOCJL, MPAMJMIIGEP IJKBGDNHCOA, float JFAKNMLNOKM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7E60740", Offset = "0x7E5EF40", VA = "0x187E60740")]
		private (float, float) KLBNOCLDNBN(Animator NENMJJJOCJL, AnimatorStateInfo GPOICKBHLHI, MPAMJMIIGEP IJKBGDNHCOA, float JFAKNMLNOKM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7E609F0", Offset = "0x7E5F1F0", VA = "0x187E609F0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7E63C80", Offset = "0x7E62480", VA = "0x187E63C80", Slot = "4")]
		public override void OnStateEnter(Animator NENMJJJOCJL, AnimatorStateInfo GPOICKBHLHI, int KOCGNHFDCPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7E63DE0", Offset = "0x7E625E0", VA = "0x187E63DE0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class BENOOCIMOOD<TInput, TOutput> : JJGFAJCCKMP<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	protected readonly AFIBAJHIFMJ IKIKFGGLHPE;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6167DE0", Offset = "0x61665E0", VA = "0x186167DE0")]
	protected BENOOCIMOOD(AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput OLFGCACBCKJ(TInput FNFJALHKEGF, [Out] IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6167D40", Offset = "0x6166540", VA = "0x186167D40", Slot = "5")]
	public bool HMENANGKBKB(TInput FNFJALHKEGF, [Out] TOutput? KJCFPPKBAOB, [Out] IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DIADIMJDNBG]
public static class JABIJNJHIIF
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static readonly Regex LCKNFHPDJBJ;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7E61290", Offset = "0x7E5FA90", VA = "0x187E61290")]
	public static IPMHHNLHLEB ILJIDEFKEFL(HEHJIIEIGHG NBHDLEDEAJP, HPJMJPAALJE OFKIDNJKEHM, Guid? FLLEHMEKPHP, Color? JOEMJFBJALB, AMKHIMALNFB BHONCPBICBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7E60FF0", Offset = "0x7E5F7F0", VA = "0x187E60FF0")]
	public static OOLKLJDECHH CNOLDAJHENI(IPMHHNLHLEB IMINNNCPCJF)
	{
		return default(OOLKLJDECHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3A46F70", Offset = "0x3A45770", VA = "0x183A46F70")]
	internal static TModern? HJKFEJOHAFN<TModern>(string? FNFJALHKEGF, PLLILOMKMAL<TModern> HIFCJFBCEBG, AFIBAJHIFMJ IKIKFGGLHPE, CHADBBDEKDD NPCMOPDEMJP, TModern IJDDDJDJHNJ) where TModern : struct, ODFIDMKBKKG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3A46790", Offset = "0x3A44F90", VA = "0x183A46790")]
	internal static MNHEBGBIPLJ FJPLKJCLPCB<TModern>(string? FNFJALHKEGF, PLLILOMKMAL<TModern> HIFCJFBCEBG, AFIBAJHIFMJ IKIKFGGLHPE, CHADBBDEKDD NPCMOPDEMJP, TModern IJDDDJDJHNJ) where TModern : struct, ODFIDMKBKKG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7E61150", Offset = "0x7E5F950", VA = "0x187E61150")]
	internal static List<EPFGOPKFNIC> HNPKCGELIKL(IEnumerable<HMDMHEDBGEA>? HJHKOGGEAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3A45910", Offset = "0x3A44110", VA = "0x183A45910")]
	internal static string FFAICGKMNBB<TModern>(TModern FNFJALHKEGF, PLLILOMKMAL<TModern> HIFCJFBCEBG, AFIBAJHIFMJ IKIKFGGLHPE) where TModern : ODFIDMKBKKG
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class OFIMIIPDECO : DCOOPGBCPFA
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public JJGFAJCCKMP<NALNGAMGADO, BLGOLEELJGA> OALLOFBEGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JJGFAJCCKMP<GEDBAJICPKM, IGOJFJLGCNK> NFEKONGBDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JJGFAJCCKMP<GEDBAJICPKM, IGOJFJLGCNK> MKMBODDMOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BDFHOMMLMCE AEJNPMEMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DHDPAJFKDKN CMGDCFOHMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E668F0", Offset = "0x7E650F0", VA = "0x187E668F0")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	[UsedImplicitly]
	internal static void HLPHGODNDMF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7E66960", Offset = "0x7E65160", VA = "0x187E66960")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OFIMIIPDECO([FAPODKMFODF("UnitySerialization")] EDKGMOLBBDI IIJFCCFMAHO, [FAPODKMFODF(null)] EHFMOIGBMGN NPKAAOKDEFM, [FAPODKMFODF(null)] AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum IJAELJJEBOL
{
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ABGLOPDLDOO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C000", Offset = "0x7E5A800", VA = "0x187E5C000")]
	public ABGLOPDLDOO(string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C030", Offset = "0x7E5A830", VA = "0x187E5C030")]
	public ABGLOPDLDOO(string ILBALOOKKCP, Exception GJEDNEMABLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BFD0", Offset = "0x7E5A7D0", VA = "0x187E5BFD0")]
	public ABGLOPDLDOO(IJAELJJEBOL EOKPMGGJEMH, string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C060", Offset = "0x7E5A860", VA = "0x187E5C060")]
	public ABGLOPDLDOO(IJAELJJEBOL EOKPMGGJEMH, string ILBALOOKKCP, Exception GJEDNEMABLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class HOHGEAJGOKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly EDKGMOLBBDI IIJFCCFMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected readonly EHFMOIGBMGN NPKAAOKDEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly AFIBAJHIFMJ IKIKFGGLHPE;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DB00", Offset = "0x7E5C300", VA = "0x187E5DB00")]
	protected HOHGEAJGOKA(EDKGMOLBBDI IIJFCCFMAHO, EHFMOIGBMGN NPKAAOKDEFM, AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E5EE20", Offset = "0x7E5D620", VA = "0x187E5EE20")]
	protected string KBJMMJFCGNE(BLGOLEELJGA CLPELFLAOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E7D0", Offset = "0x7E5CFD0", VA = "0x187E5E7D0")]
	protected string AKBPLDGKLLF(BLGOLEELJGA CLPELFLAOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5EAF0", Offset = "0x7E5D2F0", VA = "0x187E5EAF0")]
	private AvatarOutfitSelectionData ILJIDEFKEFL(IPMHHNLHLEB GLALDMENNJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E9B0", Offset = "0x7E5D1B0", VA = "0x187E5E9B0")]
	private static AvatarCustomizationSettingsData.AnchorParams CPHNDKLDAEA(CPOALKJLKJO? BEELNCKOPGF)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JJGFAJCCKMP<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput OLFGCACBCKJ(TInput FNFJALHKEGF, [Out] IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMENANGKBKB(TInput FNFJALHKEGF, [Out] TOutput? KJCFPPKBAOB, [Out] IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DCOOPGBCPFA
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	JJGFAJCCKMP<NALNGAMGADO, BLGOLEELJGA> OALLOFBEGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JJGFAJCCKMP<GEDBAJICPKM, IGOJFJLGCNK> MKMBODDMOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BDFHOMMLMCE AEJNPMEMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum CHADBBDEKDD
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DHDPAJFKDKN
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MFPAOKMPONF GJCNJFECIPF(BLGOLEELJGA IMINNNCPCJF);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BDFHOMMLMCE
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GEDBAJICPKM GJCNJFECIPF(BLGOLEELJGA IMINNNCPCJF, int MPDDLGFNLIA, string? HPANEBBHGAC, string? EKCIKEIHOEL, LLFJILOKJLH JAIHGHAJIFE, List<EPFGOPKFNIC>? OIKDMPJFCOC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DIADIMJDNBG]
internal class HBMBCGGCKFN : BENOOCIMOOD<NALNGAMGADO, BLGOLEELJGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly EHFMOIGBMGN NPKAAOKDEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly LJABPLKHKFI AFMFKCBJFNJ;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E170", Offset = "0x7E5C970", VA = "0x187E5E170")]
	public HBMBCGGCKFN(EDKGMOLBBDI IIJFCCFMAHO, EHFMOIGBMGN NPKAAOKDEFM, AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DED0", Offset = "0x7E5C6D0", VA = "0x187E5DED0", Slot = "6")]
	public override BLGOLEELJGA OLFGCACBCKJ(NALNGAMGADO FNFJALHKEGF, [Out] IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class NKBDHOOABJH : EDKGMOLBBDI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class KILBLMFDDPM : JsonConverter<MNHEBGBIPLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7E61660", Offset = "0x7E5FE60", VA = "0x187E61660", Slot = "9")]
		public override void WriteJson(JsonWriter LFDMHEHCHCC, MNHEBGBIPLJ? MGONBEDEDON, JsonSerializer KDNIJMFFINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7E61540", Offset = "0x7E5FD40", VA = "0x187E61540", Slot = "10")]
		public override MNHEBGBIPLJ ReadJson(JsonReader JEPFPDOKDAD, Type CEBILNINJIM, MNHEBGBIPLJ? ABJDBDDKHEI, bool GJBBOAHIAIF, JsonSerializer KDNIJMFFINB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7E61700", Offset = "0x7E5FF00", VA = "0x187E61700")]
		public KILBLMFDDPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class NCNPBDGIOKF : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool JDKIPMFHOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7E641C0", Offset = "0x7E629C0", VA = "0x187E641C0", Slot = "5")]
		public override object ReadJson(JsonReader JEPFPDOKDAD, Type CEBILNINJIM, object? ABJDBDDKHEI, JsonSerializer KDNIJMFFINB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7E63E00", Offset = "0x7E62600", VA = "0x187E63E00", Slot = "6")]
		public override bool CanConvert(Type CEBILNINJIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7E64220", Offset = "0x7E62A20", VA = "0x187E64220", Slot = "4")]
		public override void WriteJson(JsonWriter LFDMHEHCHCC, object? MGONBEDEDON, JsonSerializer KDNIJMFFINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7E63FE0", Offset = "0x7E627E0", VA = "0x187E63FE0")]
		private static bool PEICJHLPEMB(object MGONBEDEDON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public NCNPBDGIOKF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly JsonSerializerSettings OIIBNOKOCAB;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7E64300", Offset = "0x7E62B00", VA = "0x187E64300")]
	internal NKBDHOOABJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A240", Offset = "0x3B48A40", VA = "0x183B4A240", Slot = "4")]
	public string EALGHOHNKFF<T>(T HPLLAPMNIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A1B0", Offset = "0x3B489B0", VA = "0x183B4A1B0", Slot = "5")]
	public T DFFIEEKNPFP<T>(string MGONBEDEDON)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class EMJKBHBJBEO : EDKGMOLBBDI
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x384A610", Offset = "0x3848E10", VA = "0x18384A610", Slot = "4")]
	public string EALGHOHNKFF<T>(T HPLLAPMNIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x384A590", Offset = "0x3848D90", VA = "0x18384A590", Slot = "5")]
	public T DFFIEEKNPFP<T>(string MGONBEDEDON)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public EMJKBHBJBEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DIADIMJDNBG]
internal class LJABPLKHKFI : BENOOCIMOOD<GEDBAJICPKM, IGOJFJLGCNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly EDKGMOLBBDI IIJFCCFMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly EHFMOIGBMGN NPKAAOKDEFM;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7E63B40", Offset = "0x7E62340", VA = "0x187E63B40")]
	public LJABPLKHKFI(EDKGMOLBBDI IIJFCCFMAHO, EHFMOIGBMGN NPKAAOKDEFM, AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7E63720", Offset = "0x7E61F20", VA = "0x187E63720", Slot = "6")]
	public override IGOJFJLGCNK OLFGCACBCKJ(GEDBAJICPKM FNFJALHKEGF, [Out] IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7E62C70", Offset = "0x7E61470", VA = "0x187E62C70")]
	internal void JFNIBNHEEMM(string CKAPFCMHBPM, BLGOLEELJGA CLPELFLAOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7E62F20", Offset = "0x7E61720", VA = "0x187E62F20")]
	public IEnumerable<IPMHHNLHLEB> LDOMIIJOLFN(string GHHCKHNNGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7E61940", Offset = "0x7E60140", VA = "0x187E61940")]
	private IEnumerable<IPMHHNLHLEB> FOFAOPCFGFG(string GHHCKHNNGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7E632D0", Offset = "0x7E61AD0", VA = "0x187E632D0")]
	internal IEnumerable<IPMHHNLHLEB> MKOLAOPGINM(string GHHCKHNNGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7E62070", Offset = "0x7E60870", VA = "0x187E62070")]
	private IPMHHNLHLEB GPBDOLEAPBM(AvatarOutfitSelectionData LPLBGHCFNKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7E623F0", Offset = "0x7E60BF0", VA = "0x187E623F0")]
	private void ILPOLCOKMMI(AvatarCustomizationSettingsData OBKCPEFCGHL, BLGOLEELJGA CLPELFLAOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7E61D50", Offset = "0x7E60550", VA = "0x187E61D50")]
	private IPMHHNLHLEB GPBDOLEAPBM(string MHIPKFALNHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7E62FD0", Offset = "0x7E617D0", VA = "0x187E62FD0")]
	internal static (AMKHIMALNFB, string, string) MBIJHNAINFC(string MHIPKFALNHM, AFIBAJHIFMJ IKIKFGGLHPE)
	{
		return default((AMKHIMALNFB, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7E61740", Offset = "0x7E5FF40", VA = "0x187E61740")]
	private LHHCKEDJAIM? DLGMEJLGKCM(string? JMHOEKKPCPG, Vector2 NDENPKKMCME, float NHKOKLGIOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7E62DC0", Offset = "0x7E615C0", VA = "0x187E62DC0")]
	private static CPOALKJLKJO JLHDANIBFHO(AvatarCustomizationSettingsData.AnchorParams OMPBAAGKIFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DIADIMJDNBG]
internal class DFOGEPODKLO : HOHGEAJGOKA, DHDPAJFKDKN
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DB00", Offset = "0x7E5C300", VA = "0x187E5DB00")]
	public DFOGEPODKLO(EDKGMOLBBDI IIJFCCFMAHO, EHFMOIGBMGN NPKAAOKDEFM, AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D410", Offset = "0x7E5BC10", VA = "0x187E5D410", Slot = "4")]
	public MFPAOKMPONF GJCNJFECIPF(BLGOLEELJGA IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D7C0", Offset = "0x7E5BFC0", VA = "0x187E5D7C0")]
	private string JCPDJILLHPN(BLGOLEELJGA CLPELFLAOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D8C0", Offset = "0x7E5C0C0", VA = "0x187E5D8C0")]
	private string KAMEPLMEGOG(IPMHHNLHLEB GLALDMENNJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[DIADIMJDNBG]
internal class INNPONGNIBB : BENOOCIMOOD<GEDBAJICPKM, IGOJFJLGCNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly EDKGMOLBBDI IIJFCCFMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly JJGFAJCCKMP<GEDBAJICPKM, IGOJFJLGCNK> AMOIKJPLPHA;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7E60EF0", Offset = "0x7E5F6F0", VA = "0x187E60EF0")]
	public INNPONGNIBB(JJGFAJCCKMP<GEDBAJICPKM, IGOJFJLGCNK> AMOIKJPLPHA, AFIBAJHIFMJ IKIKFGGLHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7E60AC0", Offset = "0x7E5F2C0", VA = "0x187E60AC0", Slot = "6")]
	public override IGOJFJLGCNK OLFGCACBCKJ(GEDBAJICPKM FNFJALHKEGF, [Out] IReadOnlyList<EPFGOPKFNIC>? OIKDMPJFCOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[DIADIMJDNBG]
internal class HOENBFBBICM : BDFHOMMLMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly EDKGMOLBBDI IIJFCCFMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly DHDPAJFKDKN HLEDJLMAIOJ;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E6E0", Offset = "0x7E5CEE0", VA = "0x187E5E6E0")]
	public HOENBFBBICM(DHDPAJFKDKN HLEDJLMAIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E340", Offset = "0x7E5CB40", VA = "0x187E5E340", Slot = "4")]
	public GEDBAJICPKM GJCNJFECIPF(BLGOLEELJGA IMINNNCPCJF, int MPDDLGFNLIA, string? HPANEBBHGAC, string? EKCIKEIHOEL, LLFJILOKJLH JAIHGHAJIFE, List<EPFGOPKFNIC>? OIKDMPJFCOC)
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
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C150", Offset = "0x7E5A950", VA = "0x187E5C150")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BDMIMGPALPE
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D300", Offset = "0x7E5BB00", VA = "0x187E5D300")]
	public static OOLKLJDECHH OLFGCACBCKJ(this ODCFPAPHIDD IMINNNCPCJF)
	{
		return default(OOLKLJDECHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D180", Offset = "0x7E5B980", VA = "0x187E5D180")]
	public static ODCFPAPHIDD GJCNJFECIPF(this OOLKLJDECHH HDIHLBOKMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D2A0", Offset = "0x7E5BAA0", VA = "0x187E5D2A0")]
	public static bool MDAPMICDECB(this OOLKLJDECHH HDIHLBOKMOF)
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
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5ED9C20", Offset = "0x5ED8420", VA = "0x185ED9C20")]
			public AnchorParams(Vector2 OEMBIJGEAKD, Vector3 GEGHMHKIJGM, Vector3 DHNKBJGALEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x7E5C0A0", Offset = "0x7E5A8A0", VA = "0x187E5C0A0")]
			internal CPOALKJLKJO GJCNJFECIPF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private ODBDPJODIME useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7E5C940", Offset = "0x7E5B140", VA = "0x187E5C940")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4CA6220", Offset = "0x4CA4A20", VA = "0x184CA6220")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xF047C0", Offset = "0xF02FC0", VA = "0x180F047C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x13CE520", Offset = "0x13CCD20", VA = "0x1813CE520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x7E5C9E0", Offset = "0x7E5B1E0", VA = "0x187E5C9E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA30040", Offset = "0xA2E840", VA = "0x180A30040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xC860B0", Offset = "0xC848B0", VA = "0x180C860B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xC85E50", Offset = "0xC84650", VA = "0x180C85E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7E5CA20", Offset = "0x7E5B220", VA = "0x187E5CA20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xECB420", Offset = "0xEC9C20", VA = "0x180ECB420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1122AD0", Offset = "0x11212D0", VA = "0x181122AD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1885970", Offset = "0x1884170", VA = "0x181885970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x23852F0", Offset = "0x2383AF0", VA = "0x1823852F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xEE4A50", Offset = "0xEE3250", VA = "0x180EE4A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5DC80", VA = "0x180A5F480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA5F4E0", Offset = "0xA5DCE0", VA = "0x180A5F4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA35000", Offset = "0xA33800", VA = "0x180A35000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33860", VA = "0x180A35060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA34F80", Offset = "0xA33780", VA = "0x180A34F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA8C920", Offset = "0xA8B120", VA = "0x180A8C920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA35090", Offset = "0xA33890", VA = "0x180A35090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xEEFE60", Offset = "0xEEE660", VA = "0x180EEFE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA2B7E0", Offset = "0xA29FE0", VA = "0x180A2B7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xEF9690", Offset = "0xEF7E90", VA = "0x180EF9690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xCF2CA0", Offset = "0xCF14A0", VA = "0x180CF2CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF50", Offset = "0xCEE750", VA = "0x180CEFF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public ODBDPJODIME UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xF790F0", Offset = "0xF778F0", VA = "0x180F790F0")]
			get
			{
				return default(ODBDPJODIME);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xF77870", Offset = "0xF76070", VA = "0x180F77870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xF77E80", Offset = "0xF76680", VA = "0x180F77E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xC5AFE0", Offset = "0xC597E0", VA = "0x180C5AFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x7E5CA00", Offset = "0x7E5B200", VA = "0x187E5CA00")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7E5CA40", Offset = "0x7E5B240", VA = "0x187E5CA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C5E0", Offset = "0x7E5ADE0", VA = "0x187E5C5E0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AMKHIMALNFB BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private BODDLEFMJJJ? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x7E5CA60", Offset = "0x7E5B260", VA = "0x187E5CA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
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
