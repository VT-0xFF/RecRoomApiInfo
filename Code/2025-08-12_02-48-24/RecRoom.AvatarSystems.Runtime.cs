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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x830B150", Offset = "0x8309750", VA = "0x18830B150")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x830B1D0", Offset = "0x83097D0", VA = "0x18830B1D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KALHGBCMMAN]
internal class LCLKFGCPEMP : ANFBGFIIPOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BALKKJACBKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public LCLKFGCPEMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public GAPGDDKJAHD avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GJJPNOADFPJ AMAKDJKDCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LFGNEPGNKPG MGLHOMHFANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NMPCJCHOINP FFPPHACFLKB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8308BB0", Offset = "0x83071B0", VA = "0x188308BB0")]
	[LAFCEDCMNGK.DCDCJCFDIHP.KFAGBDMOPBG]
	[UsedImplicitly]
	internal static void PPCBOOHAJHC(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8308C20", Offset = "0x8307220", VA = "0x188308C20")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LCLKFGCPEMP([OEKMEJFDAAI(null)] GJJPNOADFPJ AMAKDJKDCLD, [OEKMEJFDAAI(null)] LFGNEPGNKPG MGLHOMHFANI, [OEKMEJFDAAI(null)] NMPCJCHOINP FFPPHACFLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8308150", Offset = "0x8306750", VA = "0x188308150", Slot = "5")]
	public HKEIODNMLBG KKDALJFGCLK(GAPGDDKJAHD JGCEJNPMHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8307580", Offset = "0x8305B80", VA = "0x188307580", Slot = "4")]
	public HKEIODNMLBG HIFOFOKNIMC(GAPGDDKJAHD JGCEJNPMHBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8308AA0", Offset = "0x83070A0", VA = "0x188308AA0", Slot = "6")]
	public DADENNIAJDJ PEHMFFGJGBD(HKEIODNMLBG DAJAOHIJHHL, int JLKLAKIGBEB, string? DJFMCHMDHGK, string? MIFLOGCGDKD, KJFAHMKAJPA CMNPBHOKKNN, List<CPEFFIJECFJ>? HAADBCFMFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8308A10", Offset = "0x8307010", VA = "0x188308A10", Slot = "7")]
	public bool PCBMCLPHJNH(HOHENDGOGEP CJCHJICEKNP, [Out] HKEIODNMLBG? EBBCNNOGLPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8308070", Offset = "0x8306670", VA = "0x188308070", Slot = "8")]
	public bool JHGHLLKJPJF(DADENNIAJDJ PGFGCEFEFOP, [Out] HKEIODNMLBG? EBBCNNOGLPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8307170", Offset = "0x8305770", VA = "0x188307170", Slot = "9")]
	public bool BHKMKBLBHIC(DADENNIAJDJ PGFGCEFEFOP, [Out] LKMAMIALIDP? CJCHJICEKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E77520", Offset = "0x3E75B20", VA = "0x183E77520")]
	private bool EEELHEEBKPH<TInput, TOutput>(TInput EKNLPIEMHNC, DBIJDCGIGLN<TInput, TOutput> FNAOOJHLLJO, [Out] TOutput? CENCPMGPALN) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8307200", Offset = "0x8305800", VA = "0x188307200")]
	[CompilerGenerated]
	private LGPBBDJEAJD FEDFFJGBCOF(FaceFeatureType HFINMKMAMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x83073A0", Offset = "0x83059A0", VA = "0x1883073A0")]
	[CompilerGenerated]
	private LGPBBDJEAJD FJCAECBAFGM(FaceFeatureType HFINMKMAMGN, BALKKJACBKP P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[KALHGBCMMAN]
internal class NNKLJLOMMAD : GJJPNOADFPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void CHGNFENKODJ<in TData>(TData EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LKLOBKJDOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public NNCDJIDPCCL rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public FHHKAJDHEIL currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public FHHKAJDHEIL latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LKLOBKJDOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8308DA0", Offset = "0x83073A0", VA = "0x188308DA0")]
		internal bool BHJKAOAPMIC(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8308DC0", Offset = "0x83073C0", VA = "0x188308DC0")]
		internal bool DBFAGHMCCGH(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NMPCJCHOINP FFPPHACFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly DKGIANPHICG MCCAGOGFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CHGNFENKODJ<HKEIODNMLBG>?[] AMAKDJKDCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CHGNFENKODJ<LKMAMIALIDP>?[] NKEHDGNNPHO;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x830A9D0", Offset = "0x8308FD0", VA = "0x18830A9D0")]
	[LAFCEDCMNGK.DCDCJCFDIHP.KFAGBDMOPBG]
	[UsedImplicitly]
	internal static void PPCBOOHAJHC(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x830AA40", Offset = "0x8309040", VA = "0x18830AA40")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NNKLJLOMMAD([OEKMEJFDAAI(null)] NMPCJCHOINP FFPPHACFLKB, [OEKMEJFDAAI(null)] DKGIANPHICG MCCAGOGFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8309F20", Offset = "0x8308520", VA = "0x188309F20", Slot = "4")]
	public bool GPAILFHFLMG(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x830A020", Offset = "0x8308620", VA = "0x18830A020", Slot = "5")]
	public bool GPAILFHFLMG(LKMAMIALIDP CJCHJICEKNP, IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8309250", Offset = "0x8307850", VA = "0x188309250")]
	private void CMCIJMOAMHE(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x830A770", Offset = "0x8308D70", VA = "0x18830A770")]
	private void MCFJJFHMKGC(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x830A630", Offset = "0x8308C30", VA = "0x18830A630")]
	private void HGKHAMAENOJ(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x830A660", Offset = "0x8308C60", VA = "0x18830A660")]
	private void LHFFGLOMABN(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x830A690", Offset = "0x8308C90", VA = "0x18830A690")]
	private void LNEEECEFMBP(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8309E70", Offset = "0x8308470", VA = "0x188309E70")]
	private void GHJKEIHLOFP(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8308E40", Offset = "0x8307440", VA = "0x188308E40")]
	private void AAJNLHLJKBJ(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x830A760", Offset = "0x8308D60", VA = "0x18830A760")]
	private void LNEFJHDBMHD(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x830A9A0", Offset = "0x8308FA0", VA = "0x18830A9A0")]
	private void NDGLJDEKLMN(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8308EF0", Offset = "0x83074F0", VA = "0x188308EF0")]
	private void AJHBEIAPOLF(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? CGLIDCMIAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x830A350", Offset = "0x8308950", VA = "0x18830A350")]
	private void HCDGJLLPHOG(HKEIODNMLBG EBBCNNOGLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8308F70", Offset = "0x8307570", VA = "0x188308F70")]
	private HKEIODNMLBG BKMMHEJNNIH(HKEIODNMLBG EBBCNNOGLPB, List<RangeMigration> IDDNAMKFHCK, FHHKAJDHEIL OKIDOKMKIMB, FHHKAJDHEIL ENJKFBDOJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8309E30", Offset = "0x8308430", VA = "0x188309E30")]
	private float GDGGMFAOFBA(float JILHAMKDPCH, Vector2 KIPGAEDOKNC, Vector2 KPPFKHAGDHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x830A180", Offset = "0x8308780", VA = "0x18830A180")]
	private (RangeMigration?, RangeMigration?) HBNPMCHHNEM(List<RangeMigration> DELPOMDPOGE, NNCDJIDPCCL JKGLBPHIGEN, FHHKAJDHEIL OKIDOKMKIMB, FHHKAJDHEIL ENJKFBDOJOC)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GJJPNOADFPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPAILFHFLMG(HKEIODNMLBG EBBCNNOGLPB, IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GPAILFHFLMG(LKMAMIALIDP CJCHJICEKNP, IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP);
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
		public KGEDEDMFKMD AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x82EAEB0", Offset = "0x82E94B0", VA = "0x1882EAEB0")]
		public void LIGGFNEADFE(AnimationPoseSetting IBCMCOKAJEM, float DAIMLOLJCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82EAFE0", Offset = "0x82E95E0", VA = "0x1882EAFE0")]
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
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x82EB8F0", Offset = "0x82E9EF0", VA = "0x1882EB8F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82EB8B0", Offset = "0x82E9EB0", VA = "0x1882EB8B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82EB000", Offset = "0x82E9600", VA = "0x1882EB000")]
		private void OIPMKNJBDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82751A0", Offset = "0x82737A0", VA = "0x1882751A0", Slot = "4")]
		public void SetEnabled(bool ANBCINBEIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82EB920", Offset = "0x82E9F20", VA = "0x1882EB920")]
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
		[Cpp2IlInjected.Address(RVA = "0x82EB960", Offset = "0x82E9F60", VA = "0x1882EB960")]
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
		[Cpp2IlInjected.Address(RVA = "0x82EB9A0", Offset = "0x82E9FA0", VA = "0x1882EB9A0")]
		public AnimationPoseSetting LBEKPLHCJDA(KGEDEDMFKMD KGBMIHLCGFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82EB9D0", Offset = "0x82E9FD0", VA = "0x1882EB9D0")]
		public void PNHKIAJGEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82EBA10", Offset = "0x82EA010", VA = "0x1882EBA10")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum ONHFPJHADKA
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private ONHFPJHADKA handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x82EC520", Offset = "0x82EAB20", VA = "0x1882EC520")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82EC4E0", Offset = "0x82EAAE0", VA = "0x1882EC4E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82EBEC0", Offset = "0x82EA4C0", VA = "0x1882EBEC0")]
		private void OIPMKNJBDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82751A0", Offset = "0x82737A0", VA = "0x1882751A0", Slot = "4")]
		public void SetEnabled(bool ANBCINBEIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82EC550", Offset = "0x82EAB50", VA = "0x1882EC550")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, DBIIDKDDKGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private GAPGDDKJAHD avatarBodyType;

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
		[HPOJEGADLAJ(BMGFACECMPD.SelfAndChildren, false, false, false)]
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
		private MAFFFDNDICA IIPLLKJCCIJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MAFFFDNDICA FMAGMOBIABM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB6DDF0", Offset = "0xB6C3F0", VA = "0x180B6DDF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform FHINNFMIKGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x82ED370", Offset = "0x82EB970", VA = "0x1882ED370", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82EC580", Offset = "0x82EAB80", VA = "0x1882EC580")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82ED230", Offset = "0x82EB830", VA = "0x1882ED230")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82ED1E0", Offset = "0x82EB7E0", VA = "0x1882ED1E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82ED170", Offset = "0x82EB770", VA = "0x1882ED170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82EC580", Offset = "0x82EAB80", VA = "0x1882EC580", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82EC910", Offset = "0x82EAF10", VA = "0x1882EC910", Slot = "6")]
		public MAFFFDNDICA CreateAvatarSystem(string EFBKGHDDNNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82ED170", Offset = "0x82EB770", VA = "0x1882ED170", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82EC640", Offset = "0x82EAC40", VA = "0x1882EC640", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82ED280", Offset = "0x82EB880", VA = "0x1882ED280", Slot = "9")]
		public void UpdatePostIKAnimControllers(float KNMJNADDDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HCAJOHIDGCO : MAFFFDNDICA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class PPJADNHGLJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 KJFBNCNFNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Quaternion ODDEAEKPCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Vector3 OGHLPJELDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Transform KFFPFOJEHJO;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 IPHGIFPPMAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2227090", Offset = "0x2225690", VA = "0x182227090")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x22270B0", Offset = "0x22256B0", VA = "0x1822270B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion JFLAEEFFDDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1620910", Offset = "0x161EF10", VA = "0x181620910")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1620D90", Offset = "0x161F390", VA = "0x181620D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float HACHCMBHIBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x128CCD0", Offset = "0x128B2D0", VA = "0x18128CCD0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1A238B0", Offset = "0x1A21EB0", VA = "0x181A238B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool OKDMKIEBCBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA99370", Offset = "0xA97970", VA = "0x180A99370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA99260", Offset = "0xA97860", VA = "0x180A99260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool PJGBAGFAJGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA99430", Offset = "0xA97A30", VA = "0x180A99430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA99330", Offset = "0xA97930", VA = "0x180A99330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool GGOJJEJBCNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA99360", Offset = "0xA97960", VA = "0x180A99360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA99340", Offset = "0xA97940", VA = "0x180A99340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float KIEKBLFLKKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xE14FE0", Offset = "0xE135E0", VA = "0x180E14FE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xE15070", Offset = "0xE13670", VA = "0x180E15070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8316AB0", Offset = "0x83150B0", VA = "0x188316AB0")]
		public void HEMMPHMJLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8316BE0", Offset = "0x83151E0", VA = "0x188316BE0")]
		public void POAGIKEAIHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8316750", Offset = "0x8314D50", VA = "0x188316750")]
		public float CNJMOMFKCPF(Vector3 HLEDCAMNKEF, Quaternion DMACPEAPGCE, [In] AvatarFootSettings PNCMHIFLIGC, float FMKLEFAIBJN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8315E40", Offset = "0x8314440", VA = "0x188315E40")]
		public void BGIHFHHCLCK(Vector3 HKFKHGBEGBB, Quaternion MKOHJOKPBOB, Transform HGMCEOAEJKL, float JKDBNOGNCNJ, bool NEBKMBMIEID, bool KEELBMFPFKE, float AMLIMICHJNJ, float FHNPJFFDAFD, Transform PPOKNBNEDHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8316520", Offset = "0x8314B20", VA = "0x188316520")]
		public void CHPFKKACPPF(Transform HJNNMBHPCLB, Transform PPOKNBNEDHM, bool MCNOAJCNEMG, bool NHMKLDDMCJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8316AC0", Offset = "0x83150C0", VA = "0x188316AC0")]
		private void NCIBHBCCMGA(Transform PPOKNBNEDHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8316960", Offset = "0x8314F60", VA = "0x188316960")]
		public bool EPOGKHAMHIN(Transform PPOKNBNEDHM, AvatarFullBodyConfiguration CKJHMCELOAA, Vector3 AOEKGKDNCGH, float HBGBAHHJOGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8316BC0", Offset = "0x83151C0", VA = "0x188316BC0")]
		public void PKBDABADJEF(float FHNPJFFDAFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8316BF0", Offset = "0x83151F0", VA = "0x188316BF0")]
		public PPJADNHGLJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class DPLJPFOIEAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private float JLEHKFGLDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool NHIECKNFIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AnimationPoseSetting IGGCFABGOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private float JPGJJDOHEBH;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x830FA00", Offset = "0x830E000", VA = "0x18830FA00")]
		public void HEPLGHJMPAF(IKSolverVR.Arm NLBABFLJNKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x830F9C0", Offset = "0x830DFC0", VA = "0x18830F9C0")]
		public void HBBGKOHJDLC(IKSolverVR.Arm NLBABFLJNKE, float EMCLGGCIJKF, bool NHIECKNFIMD, AvatarFullBodyConfiguration CKJHMCELOAA, float EEOAGLADFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8310000", Offset = "0x830E600", VA = "0x188310000")]
		private void KOFJKPHNJMN(IKSolverVR.Arm NLBABFLJNKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83101A0", Offset = "0x830E7A0", VA = "0x1883101A0")]
		public void PNCEKCJOHJJ(IKSolverVR.Arm NLBABFLJNKE, Transform ODBDCAMGEIP, Transform HGMCEOAEJKL, Quaternion EHIJMLMNODB, Vector3 HNHDBGPEAON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x830FA30", Offset = "0x830E030", VA = "0x18830FA30")]
		private (Vector3, Quaternion) JEPPEFOCPFD(MDHIIHIMHAG CNPPFGOLIBJ, Quaternion CPJFAENPFFG, Vector3 OJIIMFEPPMH)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8310040", Offset = "0x830E640", VA = "0x188310040")]
		public void NNGCNAMIHNA(MDHIIHIMHAG CNPPFGOLIBJ, IKSolverVR.Arm NLBABFLJNKE, Quaternion CPJFAENPFFG, Vector3 OJIIMFEPPMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x830F3C0", Offset = "0x830D9C0", VA = "0x18830F3C0")]
		public void ECHFIJADOBC(MDHIIHIMHAG CNPPFGOLIBJ, IKSolverVR.Arm NLBABFLJNKE, Quaternion CPJFAENPFFG, Vector3 OJIIMFEPPMH, [In] AvatarFullBodyConfiguration CKJHMCELOAA, [In] FCGJKCCGGPN BJGEPEKIJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x830FEC0", Offset = "0x830E4C0", VA = "0x18830FEC0")]
		public void KIKNGOLHBHN(KGEDEDMFKMD NIBFAOHOJGA, AvatarFullBodyConfiguration CKJHMCELOAA, FCGJKCCGGPN BJGEPEKIJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x830EF20", Offset = "0x830D520", VA = "0x18830EF20")]
		public void AINEEGIJMGJ(IKSolverVR.Arm NLBABFLJNKE, Transform ODBDCAMGEIP, Vector3 HJJACEEJMDK, float IOFCNDIHINH, Quaternion IGELINOHEFG, Vector3 LKOHPAEMJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8310580", Offset = "0x830EB80", VA = "0x188310580")]
		public DPLJPFOIEAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum OKHMMOJGJOP
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
	private struct ADFFAOABPBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GGKLNAEGMFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int GDCICLFGEHN;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int MBCOPKIOPPA;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int IDBAEDAJHKK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int FHNMFMLLBKF;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int CFOELCIGMBP;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int JAHDFCCBNLG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int MNFDJJACHCP;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int LLOINLHLOBL;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int HKIPEGNPGKD;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int PLDAIABGCPI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int CFLPLOGBPPF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int MKMDKOFBNJO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int LOAKDAAIBGA;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int CGIGIIMICPJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int EEICCPCBJDL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int LEBBJJDLPNE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int ACADFANAKHJ;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int NJHOKEDEBCA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int DPPAKJHJINA;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int LLMKABJKNLE;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int FBALADGLDMM;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int PPBAJHHOOFM;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int GLAJDIBPJFL;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int HNEGBPLJBFH;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int KPEGEDJPDNO;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int CLCDABIOGIL;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int NFLIKADCDPJ;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int IHPKHMPGKDF;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int GAFPLKLMHEO;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int JKLCLENABEA;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int HIGLIFFNCCG;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int DNIFDDPAGGI;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly Vector3 DHADINMJNEN;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int LKIOIOOCIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool HHBKEFELAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool AINEPBDBADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool CJNMAKJBCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool ENNGGLLJEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool HPAFOEKEJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool DMMCFBHJOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Vector3 HPCENDMHNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private string DGPFMLJDLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private EDJLCDBLPBM? NHICJKHJFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private LGHNKJDKLBJ? LHLCBELBGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private GJFNGGHJKCH ENPGJNPLFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private GAGPMCFOOIL JMKADBAJPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private MDHIIHIMHAG MOMNMJCKIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private MDHIIHIMHAG JKNBNOKBEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool MKOCPGJEHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x291")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool ACBBIAKECNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly HCNNHDEBGHP BMCMCJJGDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly OGBMOEONNDP HOMLNDIDENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int MFAJJKLCCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private float IMLNMMHNDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject KIKKDPNHMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Transform FBJKLFFMBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Transform IGBMGJNFINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Transform HNMDALAFACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform GMIDGCCJLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float GHHMNFPEOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float IODCLIMOLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Vector3 MGHMDONCBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Quaternion CNEODPDDOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Transform JDCAHFJNLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Transform NHINPJOOOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Transform LGPBMJJHAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private NHGHDBBMNIE KBIKJLMHNHP;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker EOGCGBNINDM;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker DDLJKJPFBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private ProfilerMarker IIJICFIIPDL;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ProfilerMarker HKGACAFLJNM;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ProfilerMarker LMHLFPDKFKL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly ProfilerMarker IGFIDENPEAF;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly List<HCAJOHIDGCO> GILELDPIMAM;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int OMOLHNHNAFK;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> POLKONCDGDM;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int FBKEDFOBNHP;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int PHPMIAKJKGP;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static int CFHAJEKPGCE;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int APDCCFALKOK;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float LFKICJMAMIE;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static int OCDABHMIICN;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float DOKDDCLFHLO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static float KNLJHCKOGBI;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static float IBDAAKGGENJ;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static float GHFBALHGEMI;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static HCFCEBEFDDB HJLKJLIIMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float FJFMMKDHHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool BHEPGEOGMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float MIPPNNIFOPK;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly int PCDDGBFEHLL;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly int CCMKCPKPJON;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly int OLEACECHONK;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly int FLNDDOKPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private PPJADNHGLJF EEDLFBPFHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private PPJADNHGLJF BCHOIFNMCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float CINIBAMGPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 FIEPFJJBOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private Vector3 JFMNDJKIPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool BAANJOKLAJB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly Quaternion LGNILNDOCFD;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly Quaternion HHPAGBONLFB;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly Vector3 OOMNLAHJBGG;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly Vector3 FLFPNOMMIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float JKEGMBBNLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float ABLIOFPNEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private DPLJPFOIEAC OPIFPBCCKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private DPLJPFOIEAC EOHEEEJBILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private BHGNFPJOCPG GLJNNHBMOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private NOFJAMCCIJL ENCGLDLIDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly IILPBLFPEHK LOAHPBDMPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float KJPAFFECLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float PLFLLDKIMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly NOFJAMCCIJL KBFGLPCKAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private Vector3 BCOAJAGIKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Vector3 JEBLNLPBDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private float EFMBKJBIPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private float HNGIMNJCNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly NOFJAMCCIJL FKIEHMNBAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly BHGNFPJOCPG MANEABNOKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly NOFJAMCCIJL PGKNOKALEGN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HBPNKKOKOOA GHKCJAEPIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HBPNKKOKOOA HBEFIKIMGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration APOGJOMMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82F0FF0", Offset = "0x82EF5F0", VA = "0x1882F0FF0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GAPGDDKJAHD HCMEFIDAIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8300CD0", Offset = "0x82FF2D0", VA = "0x188300CD0", Slot = "24")]
		get
		{
			return default(GAPGDDKJAHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration NALPMFJNLDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82F20B0", Offset = "0x82F06B0", VA = "0x1882F20B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform EMIDEIOEGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82EF6C0", Offset = "0x82EDCC0", VA = "0x1882EF6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform KBENHCKIMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x82F8D20", Offset = "0x82F7320", VA = "0x1882F8D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer FFDIPHIELBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82F5900", Offset = "0x82F3F00", VA = "0x1882F5900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] KMLOOEBJMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82FF3F0", Offset = "0x82FD9F0", VA = "0x1882FF3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] BMFCMLEEOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8300F20", Offset = "0x82FF520", VA = "0x188300F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator PJLGPFLFDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82F6290", Offset = "0x82F4890", VA = "0x1882F6290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK ANMDMFHHDBL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8302D30", Offset = "0x8301330", VA = "0x188302D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private OKAANANKHDJ OJODFPDIJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x82FFC90", Offset = "0x82FE290", VA = "0x1882FFC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private OKAANANKHDJ JLHHKJMGFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82FC610", Offset = "0x82FAC10", VA = "0x1882FC610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private OKAANANKHDJ NOHODDCBCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82F8DF0", Offset = "0x82F73F0", VA = "0x1882F8DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private OKAANANKHDJ IPHGHAOAJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8303DA0", Offset = "0x83023A0", VA = "0x188303DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private OKAANANKHDJ EMLLMEHGCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x82F2140", Offset = "0x82F0740", VA = "0x1882F2140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private OKAANANKHDJ IFMGIJOEJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82F61C0", Offset = "0x82F47C0", VA = "0x1882F61C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private OKAANANKHDJ IPACCCPGNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82F6360", Offset = "0x82F4960", VA = "0x1882F6360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private OKAANANKHDJ NAACIPKBEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82F4200", Offset = "0x82F2800", VA = "0x1882F4200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LGHNKJDKLBJ PIHNMOOLKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x82EF150", Offset = "0x82ED750", VA = "0x1882EF150", Slot = "16")]
		get
		{
			return default(LGHNKJDKLBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BGCOFBKKHJK IOBNGAAAADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC1FAA0", Offset = "0xC1E0A0", VA = "0x180C1FAA0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public OBKFCAOBFHI OBLFBDJMMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC1FA90", Offset = "0xC1E090", VA = "0x180C1FA90", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public PNBAICGDONK MHHLPBEAKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC1FAB0", Offset = "0xC1E0B0", VA = "0x180C1FAB0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PNBAICGDONK CDMAHCJHNHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC1FA80", Offset = "0xC1E080", VA = "0x180C1FA80", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string KJMDBDOADCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform JAELPEAPAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8300AF0", Offset = "0x82FF0F0", VA = "0x188300AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform ALMEPIMBPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8300C90", Offset = "0x82FF290", VA = "0x188300C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform FMCJMILJANA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8304F10", Offset = "0x8303510", VA = "0x188304F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform GKHEAFPKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8301F30", Offset = "0x8300530", VA = "0x188301F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform GNIALBJJKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82F58C0", Offset = "0x82F3EC0", VA = "0x1882F58C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool EFPEOFCOCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82F4720", Offset = "0x82F2D20", VA = "0x1882F4720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool MMGGPAIIFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x82F4720", Offset = "0x82F2D20", VA = "0x1882F4720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool LPIOOOPNGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82F5BA0", Offset = "0x82F41A0", VA = "0x1882F5BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform BCMIELHCKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82F4650", Offset = "0x82F2C50", VA = "0x1882F4650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject EGMHLHLEIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x82F0850", Offset = "0x82EEE50", VA = "0x1882F0850", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets COOMDJHLHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83051D0", Offset = "0x83037D0", VA = "0x1883051D0", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform KCFCACANKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAFB600", Offset = "0xAF9C00", VA = "0x180AFB600", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform JPNMONLMEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBA83F0", Offset = "0xBA69F0", VA = "0x180BA83F0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform HBDAJOEBPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xBA8590", Offset = "0xBA6B90", VA = "0x180BA8590", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform NDKECKPHAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBA8500", Offset = "0xBA6B00", VA = "0x180BA8500", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 EBKOAGGAPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83022C0", Offset = "0x83008C0", VA = "0x1883022C0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float LCDNIHIBOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x82F5870", Offset = "0x82F3E70", VA = "0x1882F5870", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform CMDIIGGGDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82EF260", Offset = "0x82ED860", VA = "0x1882EF260", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform FCKNMHMLAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2286910", Offset = "0x2284F10", VA = "0x182286910", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform ELHLMCHBLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBA83D0", Offset = "0xBA69D0", VA = "0x180BA83D0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform BKFFEPJHBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28FEDD0", Offset = "0x28FD3D0", VA = "0x1828FEDD0", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool DAHGGIADKOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x82F3BF0", Offset = "0x82F21F0", VA = "0x1882F3BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GJIKMKGBNOL<MAFFFDNDICA.GBBEONHOCHB> LNKNDLBOGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8305570", Offset = "0x8303B70", VA = "0x188305570", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool KNINAJEKBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8302E50", Offset = "0x8301450", VA = "0x188302E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool EEBJOPGOCFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8302C00", Offset = "0x8301200", VA = "0x188302C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x82F09F0", Offset = "0x82EEFF0", VA = "0x1882F09F0")]
	private float CAFAAOKHMOC(IBEPLAFCFLL ABBMKEFCEAI, float OAMLKHJBLAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82FD620", Offset = "0x82FBC20", VA = "0x1882FD620")]
	private void KBAGPHAKLIL([In] FCGJKCCGGPN PHOFKFMFLBH, [In] AvatarFullBodyConfiguration CKJHMCELOAA, bool GKFJBKEFIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82F6C60", Offset = "0x82F5260", VA = "0x1882F6C60")]
	private float HFIPMENINIJ([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8301CF0", Offset = "0x83002F0", VA = "0x188301CF0")]
	private float MDHGLNANIEB([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82F1D40", Offset = "0x82F0340", VA = "0x1882F1D40")]
	private void DFHPGKOJEIH(FCGJKCCGGPN PHOFKFMFLBH, AvatarFullBodyConfiguration CKJHMCELOAA, bool GKFJBKEFIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8303E70", Offset = "0x8302470", VA = "0x188303E70")]
	private void OGPCLNABMAF([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82F08F0", Offset = "0x82EEEF0", VA = "0x1882F08F0")]
	private void BPOJMFBLMOO([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8306C70", Offset = "0x8305270", VA = "0x188306C70")]
	public HCAJOHIDGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8302700", Offset = "0x8300D00", VA = "0x188302700", Slot = "13")]
	public void NMDBGEDIFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8302350", Offset = "0x8300950", VA = "0x188302350", Slot = "14")]
	public void NFJMLMLDHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82FD260", Offset = "0x82FB860", VA = "0x1882FD260", Slot = "15")]
	public void JJMFEIBIMIJ(bool OICHDKMCIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8300B40", Offset = "0x82FF140", VA = "0x188300B40", Slot = "26")]
	public Transform LKKOJIMIJLP(string HDDBDNDCLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x83052D0", Offset = "0x83038D0", VA = "0x1883052D0", Slot = "27")]
	public Vector3? PJJFPHJOFMI(string HDDBDNDCLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82F8590", Offset = "0x82F6B90", VA = "0x1882F8590", Slot = "7")]
	public void HOIEPHILFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8305AE0", Offset = "0x83040E0", VA = "0x188305AE0")]
	private void PPFFJAFIJNC(AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8304F90", Offset = "0x8303590", VA = "0x188304F90", Slot = "8")]
	public void PBMCPNIJALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8305470", Offset = "0x8303A70", VA = "0x188305470")]
	private void PKBLBPJADOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82F42D0", Offset = "0x82F28D0", VA = "0x1882F42D0")]
	private Vector3 EOCMMFBCBDG([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x82F4450", Offset = "0x82F2A50", VA = "0x1882F4450", Slot = "6")]
	public void EOELCDCDDHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82F2210", Offset = "0x82F0810", VA = "0x1882F2210")]
	private void DLOBNIHPDMI(bool GKFJBKEFIAM, OKHMMOJGJOP ECMKDACDFIG, AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82EF790", Offset = "0x82EDD90", VA = "0x1882EF790", Slot = "9")]
	public void ALKMJCBJNPE(float CHGHIDFGEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x82FB0B0", Offset = "0x82F96B0", VA = "0x1882FB0B0")]
	private void IIEKMAANLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82F9380", Offset = "0x82F7980", VA = "0x1882F9380", Slot = "4")]
	public void IGHPJKOMJAP(string EFBKGHDDNNK, EDJLCDBLPBM LFHAPBHHOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82F12B0", Offset = "0x82EF8B0", VA = "0x1882F12B0", Slot = "5")]
	public void COGLGNMGOIB(LGHNKJDKLBJ MLPODEELIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x82EEFF0", Offset = "0x82ED5F0", VA = "0x1882EEFF0", Slot = "12")]
	public void AFKFDAGOIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x82F5100", Offset = "0x82F3700", VA = "0x1882F5100", Slot = "25")]
	public void FKKGNLPKPAO([Out] Vector3 IHAAAFBGFIP, [Out] Quaternion IGELINOHEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82FC0D0", Offset = "0x82FA6D0", VA = "0x1882FC0D0")]
	private void IMGJPHPFDDH([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82F3180", Offset = "0x82F1780", VA = "0x1882F3180", Slot = "28")]
	public void DNJCLBOLDBA(float BENAAPEEPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8301F70", Offset = "0x8300570", VA = "0x188301F70", Slot = "29")]
	public void MOIJAGHHAIO(float NIILFENPMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x82FF4C0", Offset = "0x82FDAC0", VA = "0x1882FF4C0", Slot = "46")]
	public void KHEJILJBAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82F3130", Offset = "0x82F1730", VA = "0x1882F3130", Slot = "30")]
	public void DNGJEDMAPNE(bool ANMNPKCOJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8302E00", Offset = "0x8301400", VA = "0x188302E00", Slot = "31")]
	public HandLogicOffsets NNNADHMBPEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82F82F0", Offset = "0x82F68F0", VA = "0x1882F82F0", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets HMPGDLEKMJD()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8304A60", Offset = "0x8303060", VA = "0x188304A60")]
	private void OJGGLMENJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8300DA0", Offset = "0x82FF3A0", VA = "0x188300DA0")]
	private void LPCAIJANFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x82F6430", Offset = "0x82F4A30", VA = "0x1882F6430")]
	private void HANJPLLPNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x82FB2B0", Offset = "0x82F98B0", VA = "0x1882FB2B0")]
	private void IJLHFPGIGEP(FFEDAAPDFJC KMEFGNJFGED, bool EAPOMGLHHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x82F32E0", Offset = "0x82F18E0", VA = "0x1882F32E0")]
	private void EBDCDEJHKEN(FFEDAAPDFJC KMEFGNJFGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x82F8540", Offset = "0x82F6B40", VA = "0x1882F8540")]
	public Vector3 HOHPKHKAOFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x82FF100", Offset = "0x82FD700", VA = "0x1882FF100")]
	private void KCNPECGBOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8305580", Offset = "0x8303B80", VA = "0x188305580")]
	private void PKJLBFMJEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8300450", Offset = "0x82FEA50", VA = "0x188300450")]
	private void LAMMIFBILGN(FCGJKCCGGPN PHOFKFMFLBH, AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x82FB100", Offset = "0x82F9700", VA = "0x1882FB100")]
	private float IJIEAIOKCPH([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x82FFBB0", Offset = "0x82FE1B0", VA = "0x1882FFBB0")]
	private int KNHJCDFOKNJ([In] DOAMLHNNHBL IPBDJBJNPLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x82F5C90", Offset = "0x82F4290", VA = "0x1882F5C90")]
	private void GEHLFGLCHCO(FCGJKCCGGPN PHOFKFMFLBH, bool GCCBNAAMLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8304CE0", Offset = "0x83032E0", VA = "0x188304CE0")]
	private static void ONJHKNPNJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8300FF0", Offset = "0x82FF5F0", VA = "0x188300FF0")]
	private static void MDBBJGMNKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82F59D0", Offset = "0x82F3FD0", VA = "0x1882F59D0")]
	private float GAECNDKEGCO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x82F4D00", Offset = "0x82F3300", VA = "0x1882F4D00")]
	private static int FJINHMGJFPP(HCAJOHIDGCO LEOAACGBJCD, HCAJOHIDGCO GDBFOEGEGHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x82F3190", Offset = "0x82F1790", VA = "0x1882F3190", Slot = "41")]
	public FCGJKCCGGPN DOPFPNKFAMM()
	{
		return default(FCGJKCCGGPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8304C30", Offset = "0x8303230", VA = "0x188304C30")]
	private bool OMFAGOGBPKC(int JIEJOKBHEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x82FF950", Offset = "0x82FDF50", VA = "0x1882FF950")]
	public void KINHFDFAELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x82FF9D0", Offset = "0x82FDFD0", VA = "0x1882FF9D0")]
	private (bool, bool) KLDGNMFAIFF()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x82F1ED0", Offset = "0x82F04D0", VA = "0x1882F1ED0")]
	private (float, float) DGAKDOLCCOC([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x82ED390", Offset = "0x82EB990", VA = "0x1882ED390")]
	private void ABAJAEFCPOD([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x82FBDB0", Offset = "0x82FA3B0", VA = "0x1882FBDB0")]
	private void ILCGJNKKAKP([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x82F6840", Offset = "0x82F4E40", VA = "0x1882F6840")]
	private void HEEJBEMJAHH([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA, AvatarFootSettings PNCMHIFLIGC, bool EIEDANNEKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8305250", Offset = "0x8303850", VA = "0x188305250")]
	private float PHMCDGINIFD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x82FC6E0", Offset = "0x82FACE0", VA = "0x1882FC6E0")]
	private void JHEPJIPOOPA(FCGJKCCGGPN BJGEPEKIJPC, AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8304F40", Offset = "0x8303540", VA = "0x188304F40")]
	private float OOPEIFLGAJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x82F8860", Offset = "0x82F6E60", VA = "0x1882F8860")]
	private void IAKAICLCHKD([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x83057F0", Offset = "0x8303DF0", VA = "0x1883057F0")]
	private void PNCEKCJOHJJ([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x82EF2C0", Offset = "0x82ED8C0", VA = "0x1882EF2C0")]
	private void AIPECNDDBJK([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x82F05C0", Offset = "0x82EEBC0", VA = "0x1882F05C0")]
	private void BJMGMMHECON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x82F5490", Offset = "0x82F3A90", VA = "0x1882F5490")]
	private void FLIGLCGPBNA(float BBBNACOPFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x82F83B0", Offset = "0x82F69B0", VA = "0x1882F83B0")]
	private void HNDEACBPGPI([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x82F1730", Offset = "0x82EFD30", VA = "0x1882F1730")]
	private void DAADDPHBLEM(MDHIIHIMHAG IJMMPOPLLKO, IKSolverVR.Arm NLBABFLJNKE, Transform EHKOEMBKONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x82F8EC0", Offset = "0x82F74C0", VA = "0x1882F8EC0")]
	private void IFCICAMPCGD(FCGJKCCGGPN BJGEPEKIJPC, AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x82F4770", Offset = "0x82F2D70", VA = "0x1882F4770")]
	private void FEDAHDLLHBK(BDBBFEMNJAE GPHFOPLHHNM, PNBAICGDONK IJMMPOPLLKO, IKSolverVR.Arm NLBABFLJNKE, float EMCLGGCIJKF, float NCLGHGAOKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x82F1A60", Offset = "0x82F0060", VA = "0x1882F1A60")]
	private void DEDCLGMPPIA([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x82F35F0", Offset = "0x82F1BF0", VA = "0x1882F35F0")]
	private void EGHPEIIEKKB([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x82F4940", Offset = "0x82F2F40", VA = "0x1882F4940")]
	protected void FIKLDENEPDE([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x82F0CA0", Offset = "0x82EF2A0", VA = "0x1882F0CA0")]
	private void CEOBPDEAALE([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83055A0", Offset = "0x8303BA0", VA = "0x1883055A0")]
	protected void PMLOCJBLFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x82FB590", Offset = "0x82F9B90", VA = "0x1882FB590")]
	private void ILACHCFEDHN([In] FCGJKCCGGPN BJGEPEKIJPC, [In] OKHMMOJGJOP ECMKDACDFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x82F0000", Offset = "0x82EE600", VA = "0x1882F0000")]
	private void BBLIPFBLFNI(FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x82F3460", Offset = "0x82F1A60", VA = "0x1882F3460")]
	private void EEEAAHDOEJL([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x82F3CE0", Offset = "0x82F22E0", VA = "0x1882F3CE0")]
	private Vector3 EKPLEJKHGIP([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82F1C70", Offset = "0x82F0270", VA = "0x1882F1C70")]
	private void DFDPINJLDLC([In] FCGJKCCGGPN BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x82F76E0", Offset = "0x82F5CE0", VA = "0x1882F76E0")]
	private float HKBJAPALJIB(float FHNPJFFDAFD, [In] FCGJKCCGGPN BJGEPEKIJPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x82F34A0", Offset = "0x82F1AA0", VA = "0x1882F34A0")]
	private void EFKFIMKGDJH(float FHNPJFFDAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x82FFD60", Offset = "0x82FE360", VA = "0x1882FFD60")]
	private void KPMKMJCDFLJ([In] FCGJKCCGGPN BJGEPEKIJPC, OKHMMOJGJOP ECMKDACDFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x82EF800", Offset = "0x82EDE00", VA = "0x1882EF800")]
	private float ANMPGCAEEFE([In] FCGJKCCGGPN PHOFKFMFLBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8304260", Offset = "0x8302860", VA = "0x188304260")]
	private void OIHOIFDPMBE(FCGJKCCGGPN BJGEPEKIJPC, OKHMMOJGJOP ECMKDACDFIG, Vector3 JLBJHBHKNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x82FC100", Offset = "0x82FA700", VA = "0x1882FC100")]
	private static void IMJFGEAADEH(Transform JAHKFPBBGHB, Quaternion NEOIPHFFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82F01B0", Offset = "0x82EE7B0", VA = "0x1882F01B0")]
	private void BHPJFPINIGD([In] FCGJKCCGGPN PDOCNKCEMLA, [In] DOAMLHNNHBL IPBDJBJNPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x82F29F0", Offset = "0x82F0FF0", VA = "0x1882F29F0")]
	private void DMJEONFFFIN([In] FCGJKCCGGPN PDOCNKCEMLA, [In] DOAMLHNNHBL IPBDJBJNPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x82F10C0", Offset = "0x82EF6C0", VA = "0x1882F10C0")]
	private void CNKDMPGABDN(float MMHMOIKFKFL, [In] FCGJKCCGGPN PHOFKFMFLBH, float GPLAFHMOPCK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x82F7B30", Offset = "0x82F6130", VA = "0x1882F7B30")]
	private float HMOJBOMGJLE([In] FCGJKCCGGPN PHOFKFMFLBH, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x82FD330", Offset = "0x82FB930", VA = "0x1882FD330")]
	private void JKFDIJAGODB([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8302ED0", Offset = "0x83014D0", VA = "0x188302ED0")]
	private void ODIKCBPJEJL([In] FCGJKCCGGPN PHOFKFMFLBH, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x82F4D30", Offset = "0x82F3330", VA = "0x1882F4D30")]
	private void FKHGOBIDABH([In] FCGJKCCGGPN PHOFKFMFLBH, float FCILKDAALJG, float ECGCFKAFOOC, Vector3 DECCEAFJJLO, float GPLAFHMOPCK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x82F6CF0", Offset = "0x82F52F0", VA = "0x1882F6CF0")]
	private void HFNNCCOPLCK(FCGJKCCGGPN PHOFKFMFLBH, AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x82F0A10", Offset = "0x82EF010", VA = "0x1882F0A10")]
	private void CCIAGPGFNBI(FCGJKCCGGPN BJGEPEKIJPC, AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x83038E0", Offset = "0x8301EE0", VA = "0x1883038E0")]
	private void OEKCEPBABAI(FCGJKCCGGPN PHOFKFMFLBH, AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8301D70", Offset = "0x8300370", VA = "0x188301D70")]
	public void MKPKFFINKNP([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x82FC2B0", Offset = "0x82FA8B0", VA = "0x1882FC2B0")]
	public void IMMGFICCCDF([In] FCGJKCCGGPN BJGEPEKIJPC, [In] AvatarFullBodyConfiguration CKJHMCELOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8304A90", Offset = "0x8303090", VA = "0x188304A90")]
	[CompilerGenerated]
	internal static void OLHHBJCOAOA(Transform JHGKHIGHBBL, IKSolverVR.Arm NLBABFLJNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8302C80", Offset = "0x8301280", VA = "0x188302C80")]
	[CompilerGenerated]
	internal static void NMNKPLFLECD(Vector3 FBFADOIKFIM, Vector3 JLALDOPIHNO, ADFFAOABPBM P_2, GGKLNAEGMFJ P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x82F19C0", Offset = "0x82EFFC0", VA = "0x1882F19C0")]
	[CompilerGenerated]
	internal static void DBLIHOGIKEJ(PPJADNHGLJF MLLEBAKAPCM, PPJADNHGLJF MNHGLMDOPOE, Vector3 NBNGPOMAIJH, float GJJJIJGCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x82F04B0", Offset = "0x82EEAB0", VA = "0x1882F04B0")]
	[CompilerGenerated]
	internal static bool BICGPECDJKB(IKSolverVR.Arm NLBABFLJNKE, GDGFOPHLEDC HBEBNIGOHHM, float LKAJKIOGOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x82FF510", Offset = "0x82FDB10", VA = "0x1882FF510")]
	[CompilerGenerated]
	internal static float KICOGECGCLL(Vector3 BHCEPDMFBCE, Vector3 NLFPOKCOKCD, Vector3 FIPGCLMALMK, FCGJKCCGGPN PHOFKFMFLBH, AvatarFullBodyConfiguration CKJHMCELOAA, float EFCGAKGCCGN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class JHOHMHNCGCA : AECENOPDNPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Dictionary<string, MAFFFDNDICA> BHPDPGNALHP;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8314830", Offset = "0x8312E30", VA = "0x188314830")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	internal static void FCADDECJEFK(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8314910", Offset = "0x8312F10", VA = "0x188314910", Slot = "4")]
	public MAFFFDNDICA LDJLLHGKNBM(string PDFDCGDLKLE, AvatarSystemConfiguration CIPALCFEDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8314650", Offset = "0x8312C50", VA = "0x188314650", Slot = "5")]
	public void DGEJIKNAMJG(string PDFDCGDLKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8314B30", Offset = "0x8313130", VA = "0x188314B30", Slot = "6")]
	public string PGILHNCOLHC(string EDKFJNBDCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x83148A0", Offset = "0x8312EA0", VA = "0x1883148A0")]
	private string GMJDAPODLIA(string EDKFJNBDCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8314C70", Offset = "0x8313270", VA = "0x188314C70")]
	public JHOHMHNCGCA()
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
		public class IDNAJCGJELF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private Dictionary<string, Transform> KAFMMGNNNHM;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool ACEIOKDFPFN
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x8314400", Offset = "0x8312A00", VA = "0x188314400")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8314490", Offset = "0x8312A90", VA = "0x188314490")]
			public void PFGGJJIMGGG(VRIK LOCLJLOPJDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
			public void CGHCLGECIDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8314440", Offset = "0x8312A40", VA = "0x188314440")]
			public void IMGLACMMFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x83145C0", Offset = "0x8312BC0", VA = "0x1883145C0")]
			public IDNAJCGJELF()
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
		[MKKFIBEOMHP(BMGFACECMPD.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[HPOJEGADLAJ(BMGFACECMPD.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly IDNAJCGJELF GODFCININBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private DBIIDKDDKGI CJPAAPMGNFJ;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x830DA60", Offset = "0x830C060", VA = "0x18830DA60")]
		private void LJDCNOCKLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x830DA10", Offset = "0x830C010", VA = "0x18830DA10")]
		private bool KEBNKHGBGCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x830DD40", Offset = "0x830C340", VA = "0x18830DD40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x830DDB0", Offset = "0x830C3B0", VA = "0x18830DDB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x830DD50", Offset = "0x830C350", VA = "0x18830DD50")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x830E020", Offset = "0x830C620", VA = "0x18830E020")]
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
			[Cpp2IlInjected.Address(RVA = "0x8314340", Offset = "0x8312940", VA = "0x188314340")]
			public (float, float) JHJMOKKANMH(float PKAJJPPEGMC)
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8313B70", Offset = "0x8312170", VA = "0x188313B70")]
			public void PNHKIAJGEDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8313A30", Offset = "0x8312030", VA = "0x188313A30")]
			public (float, float) BGAKFEFFGGO(Animator KDIGOBFAOEB, AnimatorStateInfo JHLLDAEAKBD)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83140F0", Offset = "0x83126F0", VA = "0x1883140F0")]
		public void PNHKIAJGEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8313EB0", Offset = "0x83124B0", VA = "0x188313EB0")]
		public (float, float) IGBDCAFJHHN(Animator KDIGOBFAOEB, IBEPLAFCFLL ABBMKEFCEAI, float GPBHBOBGNCP)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8313C50", Offset = "0x8312250", VA = "0x188313C50")]
		private (float, float) HKAEHAEOAHB(Animator KDIGOBFAOEB, AnimatorStateInfo JHLLDAEAKBD, IBEPLAFCFLL ABBMKEFCEAI, float GPBHBOBGNCP)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8314330", Offset = "0x8312930", VA = "0x188314330")]
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
		[Cpp2IlInjected.Address(RVA = "0x8315610", Offset = "0x8313C10", VA = "0x188315610", Slot = "4")]
		public override void OnStateEnter(Animator KDIGOBFAOEB, AnimatorStateInfo JHLLDAEAKBD, int HMGCNCNKCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8315780", Offset = "0x8313D80", VA = "0x188315780")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class NHPPOECKDMB<TInput, TOutput> : DBIJDCGIGLN<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	protected readonly DKGIANPHICG MCCAGOGFMBB;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x59EB980", Offset = "0x59E9F80", VA = "0x1859EB980")]
	protected NHPPOECKDMB(DKGIANPHICG MCCAGOGFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput KJBCLIOBDIC(TInput EKNLPIEMHNC, [Out] IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x59EB8E0", Offset = "0x59E9EE0", VA = "0x1859EB8E0", Slot = "5")]
	public bool EEELHEEBKPH(TInput EKNLPIEMHNC, [Out] TOutput? CENCPMGPALN, [Out] IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[KALHGBCMMAN]
public static class GMJKJJBLKPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly Regex EBLKDEFGFMI;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8311070", Offset = "0x830F670", VA = "0x188311070")]
	public static OAJGABNCNBD JCLDPIHHEDG(KFPCHIHLHJM NGIIDBPAAGG, PHJLLKHDGCC FPDIENPMAAK, Guid? MECFNLMOEBM, Color? AFMDNHPLCPN, CNFLLNFLBIO CGKEIIDMLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8311280", Offset = "0x830F880", VA = "0x188311280")]
	public static BDDFNOANCGH OIFGDFMNOEH(OAJGABNCNBD DAJAOHIJHHL)
	{
		return default(BDDFNOANCGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3DAC180", Offset = "0x3DAA780", VA = "0x183DAC180")]
	internal static TModern? BADGKOGBCPA<TModern>(string? EKNLPIEMHNC, HILFMOALGJN<TModern> HMCLJNPDMCD, DKGIANPHICG MCCAGOGFMBB, NMPBKAMFMPL GINJEEELENO, TModern IBOKCOHKNNE) where TModern : struct, NFJHEOPKPGK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD7D0", Offset = "0x3DABDD0", VA = "0x183DAD7D0")]
	internal static HCOGGNFMNLP DKEACGIHHAN<TModern>(string? EKNLPIEMHNC, HILFMOALGJN<TModern> HMCLJNPDMCD, DKGIANPHICG MCCAGOGFMBB, NMPBKAMFMPL GINJEEELENO, TModern IBOKCOHKNNE) where TModern : struct, NFJHEOPKPGK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x8310F20", Offset = "0x830F520", VA = "0x188310F20")]
	internal static List<CPEFFIJECFJ> HEEJCOLJOMG(IEnumerable<DMNGFFKFFEM>? JOKEAFMNPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3DADF40", Offset = "0x3DAC540", VA = "0x183DADF40")]
	internal static string EJGJELADGDI<TModern>(TModern EKNLPIEMHNC, HILFMOALGJN<TModern> HMCLJNPDMCD, DKGIANPHICG MCCAGOGFMBB) where TModern : NFJHEOPKPGK
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class OENKMBPBNKB : LFGNEPGNKPG
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DBIJDCGIGLN<HOHENDGOGEP, HKEIODNMLBG> BEADJLELPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DBIJDCGIGLN<DADENNIAJDJ, LKMAMIALIDP> KODJNKMGDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DBIJDCGIGLN<DADENNIAJDJ, LKMAMIALIDP> NCAKDHBNOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JKIOBHLGEGA FJIOPDHLMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public LAIHHEDNJDJ JEMHIBHNOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x83157A0", Offset = "0x8313DA0", VA = "0x1883157A0")]
	[LAFCEDCMNGK.DCDCJCFDIHP.KFAGBDMOPBG]
	[UsedImplicitly]
	internal static void PPCBOOHAJHC(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8315810", Offset = "0x8313E10", VA = "0x188315810")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OENKMBPBNKB([OEKMEJFDAAI("UnitySerialization")] OCGNFEOODBN DHALEHMBLGP, [OEKMEJFDAAI(null)] ICDMELAABPI KPCLGEPKDJE, [OEKMEJFDAAI(null)] DKGIANPHICG MCCAGOGFMBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum IICKFDKHKAC
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
public class PIIDMHCLNJN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8315DB0", Offset = "0x83143B0", VA = "0x188315DB0")]
	public PIIDMHCLNJN(string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8315DE0", Offset = "0x83143E0", VA = "0x188315DE0")]
	public PIIDMHCLNJN(string IFEHDCDCFPK, Exception ACENGOJDDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8315E10", Offset = "0x8314410", VA = "0x188315E10")]
	public PIIDMHCLNJN(IICKFDKHKAC KBFPIDKMNOD, string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8315D70", Offset = "0x8314370", VA = "0x188315D70")]
	public PIIDMHCLNJN(IICKFDKHKAC KBFPIDKMNOD, string IFEHDCDCFPK, Exception ACENGOJDDLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class AJNPPPDMJIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly OCGNFEOODBN DHALEHMBLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected readonly ICDMELAABPI KPCLGEPKDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	protected readonly DKGIANPHICG MCCAGOGFMBB;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x830CE70", Offset = "0x830B470", VA = "0x18830CE70")]
	protected AJNPPPDMJIO(OCGNFEOODBN DHALEHMBLGP, ICDMELAABPI KPCLGEPKDJE, DKGIANPHICG MCCAGOGFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x830B510", Offset = "0x8309B10", VA = "0x18830B510")]
	protected string CIOGLIOBPEM(HKEIODNMLBG EBBCNNOGLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x830C810", Offset = "0x830AE10", VA = "0x18830C810")]
	protected string CJAFIPEFPGG(HKEIODNMLBG EBBCNNOGLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x830CA00", Offset = "0x830B000", VA = "0x18830CA00")]
	private AvatarOutfitSelectionData JCLDPIHHEDG(OAJGABNCNBD MKPMEGNEIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x830CD30", Offset = "0x830B330", VA = "0x18830CD30")]
	private static AvatarCustomizationSettingsData.AnchorParams OCJBIOOMPGN(NKKOKKMIKCN? CMADCPGPGID)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DBIJDCGIGLN<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput KJBCLIOBDIC(TInput EKNLPIEMHNC, [Out] IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EEELHEEBKPH(TInput EKNLPIEMHNC, [Out] TOutput? CENCPMGPALN, [Out] IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LFGNEPGNKPG
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	DBIJDCGIGLN<HOHENDGOGEP, HKEIODNMLBG> BEADJLELPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	DBIJDCGIGLN<DADENNIAJDJ, LKMAMIALIDP> NCAKDHBNOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	JKIOBHLGEGA FJIOPDHLMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum NMPBKAMFMPL
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LAIHHEDNJDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BHKCKFPPGOJ CAELEDFILEL(HKEIODNMLBG DAJAOHIJHHL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JKIOBHLGEGA
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DADENNIAJDJ CAELEDFILEL(HKEIODNMLBG DAJAOHIJHHL, int JLKLAKIGBEB, string? DJFMCHMDHGK, string? MIFLOGCGDKD, KJFAHMKAJPA CMNPBHOKKNN, List<CPEFFIJECFJ>? HAADBCFMFEP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[KALHGBCMMAN]
internal class GGCKDGAMFDG : NHPPOECKDMB<HOHENDGOGEP, HKEIODNMLBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly ICDMELAABPI KPCLGEPKDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly GNALMJDAEIH HIPCKBPNDNC;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x83108B0", Offset = "0x830EEB0", VA = "0x1883108B0")]
	public GGCKDGAMFDG(OCGNFEOODBN DHALEHMBLGP, ICDMELAABPI KPCLGEPKDJE, DKGIANPHICG MCCAGOGFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8310600", Offset = "0x830EC00", VA = "0x188310600", Slot = "6")]
	public override HKEIODNMLBG KJBCLIOBDIC(HOHENDGOGEP EKNLPIEMHNC, [Out] IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class LEPMHMDNOAO : OCGNFEOODBN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class CJBBFABLMJO : JsonConverter<HCOGGNFMNLP>
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x830EE40", Offset = "0x830D440", VA = "0x18830EE40", Slot = "9")]
		public override void WriteJson(JsonWriter ENKMBIEHHDM, HCOGGNFMNLP? FKMNCAKIOFK, JsonSerializer KLAOHOGIDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x830ED20", Offset = "0x830D320", VA = "0x18830ED20", Slot = "10")]
		public override HCOGGNFMNLP ReadJson(JsonReader EMPLJNKCONI, Type JEMGDFOINDM, HCOGGNFMNLP? KKBDIMMDKHH, bool GIAKEPLAFBK, JsonSerializer KLAOHOGIDJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x830EEE0", Offset = "0x830D4E0", VA = "0x18830EEE0")]
		public CJBBFABLMJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class KMLKKEMDCAM : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool IDFHMLGNBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x83150E0", Offset = "0x83136E0", VA = "0x1883150E0", Slot = "5")]
		public override object ReadJson(JsonReader EMPLJNKCONI, Type JEMGDFOINDM, object? KKBDIMMDKHH, JsonSerializer KLAOHOGIDJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8314D00", Offset = "0x8313300", VA = "0x188314D00", Slot = "6")]
		public override bool CanConvert(Type JEMGDFOINDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8315140", Offset = "0x8313740", VA = "0x188315140", Slot = "4")]
		public override void WriteJson(JsonWriter ENKMBIEHHDM, object? FKMNCAKIOFK, JsonSerializer KLAOHOGIDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8314EE0", Offset = "0x83134E0", VA = "0x188314EE0")]
		private static bool ODAIODFDOLJ(object FKMNCAKIOFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public KMLKKEMDCAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly JsonSerializerSettings FCMBNELMFMA;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x83154B0", Offset = "0x8313AB0", VA = "0x1883154B0")]
	internal LEPMHMDNOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B1B0", Offset = "0x3E797B0", VA = "0x183E7B1B0", Slot = "4")]
	public string BIFNAJIBCGH<T>(T NDBJJGOPOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B210", Offset = "0x3E79810", VA = "0x183E7B210", Slot = "5")]
	public T EFCCCKGNLHH<T>(string FKMNCAKIOFK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class GOAOJOJIEKH : OCGNFEOODBN
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3DB2180", Offset = "0x3DB0780", VA = "0x183DB2180", Slot = "4")]
	public string BIFNAJIBCGH<T>(T NDBJJGOPOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3DB21E0", Offset = "0x3DB07E0", VA = "0x183DB21E0", Slot = "5")]
	public T EFCCCKGNLHH<T>(string FKMNCAKIOFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GOAOJOJIEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KALHGBCMMAN]
internal class GNALMJDAEIH : NHPPOECKDMB<DADENNIAJDJ, LKMAMIALIDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly OCGNFEOODBN DHALEHMBLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly ICDMELAABPI KPCLGEPKDJE;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x83138F0", Offset = "0x8311EF0", VA = "0x1883138F0")]
	public GNALMJDAEIH(OCGNFEOODBN DHALEHMBLGP, ICDMELAABPI KPCLGEPKDJE, DKGIANPHICG MCCAGOGFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8312B50", Offset = "0x8311150", VA = "0x188312B50", Slot = "6")]
	public override LKMAMIALIDP KJBCLIOBDIC(DADENNIAJDJ EKNLPIEMHNC, [Out] IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8312000", Offset = "0x8310600", VA = "0x188312000")]
	internal void IAIAFHEAGBM(string DCBLDKNLCIB, HKEIODNMLBG EBBCNNOGLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8311F50", Offset = "0x8310550", VA = "0x188311F50")]
	public IEnumerable<OAJGABNCNBD> EGCCHNECFGI(string AAOGNFDPHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8311480", Offset = "0x830FA80", VA = "0x188311480")]
	private IEnumerable<OAJGABNCNBD> BBLLBHKHAJI(string AAOGNFDPHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8313280", Offset = "0x8311880", VA = "0x188313280")]
	internal IEnumerable<OAJGABNCNBD> OFJNBECJLJE(string AAOGNFDPHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x83118A0", Offset = "0x830FEA0", VA = "0x1883118A0")]
	private OAJGABNCNBD BHJGIPPDOMD(AvatarOutfitSelectionData CKDFICKKBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x83122B0", Offset = "0x83108B0", VA = "0x1883122B0")]
	private void JHHKELALJBA(AvatarCustomizationSettingsData GDJGMABEKNJ, HKEIODNMLBG EBBCNNOGLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8311C30", Offset = "0x8310230", VA = "0x188311C30")]
	private OAJGABNCNBD BHJGIPPDOMD(string AHNGCDDILLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8312F80", Offset = "0x8311580", VA = "0x188312F80")]
	internal static (CNFLLNFLBIO, string, string) NLCKGINHDMH(string AHNGCDDILLG, DKGIANPHICG MCCAGOGFMBB)
	{
		return default((CNFLLNFLBIO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x83136F0", Offset = "0x8311CF0", VA = "0x1883136F0")]
	private LGPBBDJEAJD? PNLDCJAGDKC(string? CLPJLOJHBDJ, Vector2 MAFINEEGDIM, float LIPMNDGJIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8312150", Offset = "0x8310750", VA = "0x188312150")]
	private static NKKOKKMIKCN JDBOGHHGCFN(AvatarCustomizationSettingsData.AnchorParams NBLKKBHLIKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[KALHGBCMMAN]
internal class CALCDBHINCN : AJNPPPDMJIO, LAIHHEDNJDJ
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x830CE70", Offset = "0x830B470", VA = "0x18830CE70")]
	public CALCDBHINCN(OCGNFEOODBN DHALEHMBLGP, ICDMELAABPI KPCLGEPKDJE, DKGIANPHICG MCCAGOGFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x830E630", Offset = "0x830CC30", VA = "0x18830E630", Slot = "4")]
	public BHKCKFPPGOJ CAELEDFILEL(HKEIODNMLBG DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x830EC20", Offset = "0x830D220", VA = "0x18830EC20")]
	private string PAAAANAOOOA(HKEIODNMLBG EBBCNNOGLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x830E9E0", Offset = "0x830CFE0", VA = "0x18830E9E0")]
	private string CPDDDEIBHKJ(OAJGABNCNBD MKPMEGNEIEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KALHGBCMMAN]
internal class BPLKFFNHHML : NHPPOECKDMB<DADENNIAJDJ, LKMAMIALIDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly OCGNFEOODBN DHALEHMBLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly DBIJDCGIGLN<DADENNIAJDJ, LKMAMIALIDP> FBOCGFLBDAG;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x830E530", Offset = "0x830CB30", VA = "0x18830E530")]
	public BPLKFFNHHML(DBIJDCGIGLN<DADENNIAJDJ, LKMAMIALIDP> FBOCGFLBDAG, DKGIANPHICG MCCAGOGFMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x830E100", Offset = "0x830C700", VA = "0x18830E100", Slot = "6")]
	public override LKMAMIALIDP KJBCLIOBDIC(DADENNIAJDJ EKNLPIEMHNC, [Out] IReadOnlyList<CPEFFIJECFJ>? HAADBCFMFEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[KALHGBCMMAN]
internal class GGDKLJJDHCB : JKIOBHLGEGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly OCGNFEOODBN DHALEHMBLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly LAIHHEDNJDJ NIFJIAJGFJH;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8310E30", Offset = "0x830F430", VA = "0x188310E30")]
	public GGDKLJJDHCB(LAIHHEDNJDJ NIFJIAJGFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8310A80", Offset = "0x830F080", VA = "0x188310A80", Slot = "4")]
	public DADENNIAJDJ CAELEDFILEL(HKEIODNMLBG DAJAOHIJHHL, int JLKLAKIGBEB, string? DJFMCHMDHGK, string? MIFLOGCGDKD, KJFAHMKAJPA CMNPBHOKKNN, List<CPEFFIJECFJ>? HAADBCFMFEP)
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
		[Cpp2IlInjected.Address(RVA = "0x830D0A0", Offset = "0x830B6A0", VA = "0x18830D0A0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LBHHFIACFCG
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8315340", Offset = "0x8313940", VA = "0x188315340")]
	public static BDDFNOANCGH KJBCLIOBDIC(this IALPOLACGAI DAJAOHIJHHL)
	{
		return default(BDDFNOANCGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8315220", Offset = "0x8313820", VA = "0x188315220")]
	public static IALPOLACGAI CAELEDFILEL(this BDDFNOANCGH CFMGEHFDBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8315450", Offset = "0x8313A50", VA = "0x188315450")]
	public static bool NKHHIFMOHAB(this BDDFNOANCGH CFMGEHFDBOG)
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
			[Cpp2IlInjected.Address(RVA = "0x62DD8B0", Offset = "0x62DBEB0", VA = "0x1862DD8B0")]
			public AnchorParams(Vector2 HPMBAPLIPOG, Vector3 LDDEODCBKOL, Vector3 MHENPFCKHON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x830CFF0", Offset = "0x830B5F0", VA = "0x18830CFF0")]
			internal NKKOKKMIKCN CAELEDFILEL()
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
		private AEJMMPKIJPB useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x830D8D0", Offset = "0x830BED0", VA = "0x18830D8D0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1897EB0", Offset = "0x18964B0", VA = "0x181897EB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xE19D10", Offset = "0xE18310", VA = "0x180E19D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x109BE00", Offset = "0x109A400", VA = "0x18109BE00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x15ACBD0", Offset = "0x15AB1D0", VA = "0x1815ACBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x830D980", Offset = "0x830BF80", VA = "0x18830D980")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F20", Offset = "0xAA0520", VA = "0x180AA1F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD5D9C0", Offset = "0xD5BFC0", VA = "0x180D5D9C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD5D620", Offset = "0xD5BC20", VA = "0x180D5D620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2A0F770", Offset = "0x2A0DD70", VA = "0x182A0F770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xFC0E60", Offset = "0xFBF460", VA = "0x180FC0E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x128CC90", Offset = "0x128B290", VA = "0x18128CC90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1A5AFC0", Offset = "0x1A595C0", VA = "0x181A5AFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA962F0", Offset = "0xA948F0", VA = "0x180A962F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x25ED6B0", Offset = "0x25EBCB0", VA = "0x1825ED6B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xFDC840", Offset = "0xFDAE40", VA = "0x180FDC840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACAE10", VA = "0x180ACC810")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xACC870", Offset = "0xACAE70", VA = "0x180ACC870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA9D690", Offset = "0xA9BC90", VA = "0x180A9D690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA9D640", Offset = "0xA9BC40", VA = "0x180A9D640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA9D7B0", Offset = "0xA9BDB0", VA = "0x180A9D7B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA9D620", Offset = "0xA9BC20", VA = "0x180A9D620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA9D770", Offset = "0xA9BD70", VA = "0x180A9D770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA9D7C0", Offset = "0xA9BDC0", VA = "0x180A9D7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB19E20", Offset = "0xB18420", VA = "0x180B19E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB65E80", Offset = "0xB64480", VA = "0x180B65E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA9D630", Offset = "0xA9BC30", VA = "0x180A9D630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA9D710", Offset = "0xA9BD10", VA = "0x180A9D710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB65DA0", Offset = "0xB643A0", VA = "0x180B65DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB65E50", Offset = "0xB64450", VA = "0x180B65E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA9F180", Offset = "0xA9D780", VA = "0x180A9F180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA9F110", Offset = "0xA9D710", VA = "0x180A9F110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB66230", Offset = "0xB64830", VA = "0x180B66230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB66210", Offset = "0xB64810", VA = "0x180B66210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xE05C40", Offset = "0xE04240", VA = "0x180E05C40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xE03BF0", Offset = "0xE021F0", VA = "0x180E03BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AEJMMPKIJPB UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x10B9340", Offset = "0x10B7940", VA = "0x1810B9340")]
			get
			{
				return default(AEJMMPKIJPB);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x10B7D70", Offset = "0x10B6370", VA = "0x1810B7D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x10B7D80", Offset = "0x10B6380", VA = "0x1810B7D80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xD517C0", Offset = "0xD4FDC0", VA = "0x180D517C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x830D9A0", Offset = "0x830BFA0", VA = "0x18830D9A0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x830D9C0", Offset = "0x830BFC0", VA = "0x18830D9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x830D530", Offset = "0x830BB30", VA = "0x18830D530")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
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
		public CNFLLNFLBIO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private ECOHPDCJPMM? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x830D9E0", Offset = "0x830BFE0", VA = "0x18830D9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
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
