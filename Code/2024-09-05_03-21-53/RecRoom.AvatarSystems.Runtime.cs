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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A7DBD0", Offset = "0x6A7C5D0", VA = "0x186A7DBD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A805B0", Offset = "0x6A7EFB0", VA = "0x186A805B0", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PLAFBFJHEAK]
internal class PIFFHPCOLBD : AONDKMHELMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PPFKNBMKECG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public PIFFHPCOLBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public LJIAAKKJMFC avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PIBINGGEKHN DKEDONHMDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BPNMKGBBJGN DIMLKEAJDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FFOFKPFJJNE GPFGCOIAPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly PPBEGIKPOCE IBOADBLPOGK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A80350", Offset = "0x6A7ED50", VA = "0x186A80350")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	[UsedImplicitly]
	internal static void NKHHMPMLMGG(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A803C0", Offset = "0x6A7EDC0", VA = "0x186A803C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PIFFHPCOLBD([CNNDHKODGDP(null)] PIBINGGEKHN DKEDONHMDBF, [CNNDHKODGDP(null)] BPNMKGBBJGN DIMLKEAJDMO, [CNNDHKODGDP(null)] FFOFKPFJJNE GPFGCOIAPBL, [CNNDHKODGDP(null)] PPBEGIKPOCE IBOADBLPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EBD0", Offset = "0x6A7D5D0", VA = "0x186A7EBD0", Slot = "5")]
	public OGHEBKGCIPF BMKFKJMIEKK(LJIAAKKJMFC OGHNIOCONDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F6B0", Offset = "0x6A7E0B0", VA = "0x186A7F6B0", Slot = "4")]
	public OGHEBKGCIPF JOGPEOGBBFK(LJIAAKKJMFC OGHNIOCONDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F510", Offset = "0x6A7DF10", VA = "0x186A7F510", Slot = "6")]
	public HHPMELGLIIA JCKEAFEIGJB(OGHEBKGCIPF OIGMDCDEKEG, int GBFKFLAFFMD, string? HBOONHFLONJ, string? NNOOJPFBHGL, IJNKGDNCJLA EEJDENEMAKH, List<CGDNFBGOLIE>? DHEPNPNIKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F3A0", Offset = "0x6A7DDA0", VA = "0x186A7F3A0", Slot = "7")]
	public bool FIEGCEFDMHF(CCHKDPCEGOP JDPLPGCJJCG, [Out] OGHEBKGCIPF? OCPNBFGAMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F430", Offset = "0x6A7DE30", VA = "0x186A7F430", Slot = "8")]
	public bool IACEDCKKFKL(HHPMELGLIIA JONKNAHFHCJ, [Out] OGHEBKGCIPF? OCPNBFGAMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F620", Offset = "0x6A7E020", VA = "0x186A7F620", Slot = "9")]
	public bool JFHMKEJJIKG(HHPMELGLIIA JONKNAHFHCJ, [Out] EJNDBNBBEPK? JDPLPGCJJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C1D0", Offset = "0x2E4ABD0", VA = "0x182E4C1D0")]
	private bool JCBJPPKKDJI<TInput, TOutput>(TInput DKDIADEJLHP, IFDAFPNLJEK<TInput, TOutput> IGBCDHOMAHD, [Out] TOutput? DFEFBOIIPKP) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EA20", Offset = "0x6A7D420", VA = "0x186A7EA20")]
	[CompilerGenerated]
	private PFMNAIAGGDI BKEDAKMKPIE(FaceFeatureType AFLFJPOGOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A80070", Offset = "0x6A7EA70", VA = "0x186A80070")]
	[CompilerGenerated]
	private PFMNAIAGGDI MKMMDEICPIP(FaceFeatureType AFLFJPOGOMJ, PPFKNBMKECG P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[PLAFBFJHEAK]
internal class ACFMEMMLKDA : PIBINGGEKHN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void IOHONHHNKFO<in TData>(TData OCPNBFGAMKH, IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly FFOFKPFJJNE GPFGCOIAPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GFEMHOFJCGN OOBEMKODKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly IOHONHHNKFO<OGHEBKGCIPF>?[] DKEDONHMDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly IOHONHHNKFO<EJNDBNBBEPK>?[] OGHFDGCIHHO;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FFB0", Offset = "0x6A5E9B0", VA = "0x186A5FFB0")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	[UsedImplicitly]
	internal static void NKHHMPMLMGG(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A60CB0", Offset = "0x6A5F6B0", VA = "0x186A60CB0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ACFMEMMLKDA([CNNDHKODGDP(null)] FFOFKPFJJNE GPFGCOIAPBL, [CNNDHKODGDP(null)] GFEMHOFJCGN OOBEMKODKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A60180", Offset = "0x6A5EB80", VA = "0x186A60180", Slot = "4")]
	public bool PFPKNLPJACF(OGHEBKGCIPF OCPNBFGAMKH, IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A60020", Offset = "0x6A5EA20", VA = "0x186A60020", Slot = "5")]
	public bool PFPKNLPJACF(EJNDBNBBEPK JDPLPGCJJCG, IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A60280", Offset = "0x6A5EC80", VA = "0x186A60280")]
	private void PGKFKAHJGLL(OGHEBKGCIPF OCPNBFGAMKH, IReadOnlyList<CGDNFBGOLIE>? AHPMMDKKKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FD20", Offset = "0x6A5E720", VA = "0x186A5FD20")]
	private void EOOHAGGDHAC(OGHEBKGCIPF OCPNBFGAMKH, IReadOnlyList<CGDNFBGOLIE>? AHPMMDKKKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FF50", Offset = "0x6A5E950", VA = "0x186A5FF50")]
	private void FBGLODHMNOO(OGHEBKGCIPF OCPNBFGAMKH, IReadOnlyList<CGDNFBGOLIE>? AHPMMDKKKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A5FF80", Offset = "0x6A5E980", VA = "0x186A5FF80")]
	private void KNMHPCPIBIH(OGHEBKGCIPF OCPNBFGAMKH, IReadOnlyList<CGDNFBGOLIE>? AHPMMDKKKFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PIBINGGEKHN
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFPKNLPJACF(OGHEBKGCIPF OCPNBFGAMKH, IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PFPKNLPJACF(EJNDBNBBEPK JDPLPGCJJCG, IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ);
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AnimationPoseSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Tooltip("Type of pose")]
		public IBPCPGIHICI AnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Tooltip("Blend in time")]
		public float BlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Tooltip("How much of the head movement is applied to the hand movement")]
		public float HeadMovementWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Tooltip("Weight between IK hand and Animated hand for position")]
		public float HandAnimationPosWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Tooltip("Weight between IK hand and Animated hand for rotation")]
		public float HandAnimationRotWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Tooltip("Weight between shoulders facing forward and alignment with hands")]
		public float ShoulderFollowWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("How much the aim follows direction of feet vs head (0 = head, 1 = feet)")]
		public float FeetFollowWeight;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A61070", Offset = "0x6A5FA70", VA = "0x186A61070")]
		public void CHOMOFKBKBI(AnimationPoseSetting AIPFCMFLDKG, float DHCCAMINKEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A611A0", Offset = "0x6A5FBA0", VA = "0x186A611A0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendHelperController : MonoBehaviour, KDEMKMMCFEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool DebugExecutionInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Vector3? GIELMIAOPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool FNAILHCCABH;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A611C0", Offset = "0x6A5FBC0", VA = "0x186A611C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A617B0", Offset = "0x6A601B0", VA = "0x186A617B0", Slot = "4")]
		public void UpdateController(float OMPPDBKHEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x10074A0", Offset = "0x1005EA0", VA = "0x1810074A0", Slot = "6")]
		public void SetEnabled(bool CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A61260", Offset = "0x6A5FC60", VA = "0x186A61260")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A61C40", Offset = "0x6A60640", VA = "0x186A61C40")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarElbowBendTargetController : MonoBehaviour, KDEMKMMCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float IDLPPJGMEBJ = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Vector3 IECMHAFNHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 AGJCEDHOMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FNAILHCCABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float KMLMDEFFOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float IFLALBCELLA;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A61FC0", Offset = "0x6A609C0", VA = "0x186A61FC0", Slot = "4")]
		public void UpdateController(float OMPPDBKHEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAEE810", Offset = "0xAED210", VA = "0x180AEE810", Slot = "6")]
		public void SetEnabled(bool CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A61CE0", Offset = "0x6A606E0", VA = "0x186A61CE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A62A80", Offset = "0x6A61480", VA = "0x186A62A80")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A63390", Offset = "0x6A61D90", VA = "0x186A63390")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A63350", Offset = "0x6A61D50", VA = "0x186A63350")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A62AB0", Offset = "0x6A614B0", VA = "0x186A62AB0")]
		private void AELMEPELNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A9F0", Offset = "0x6A293F0", VA = "0x186A2A9F0", Slot = "4")]
		public void SetEnabled(bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A633C0", Offset = "0x6A61DC0", VA = "0x186A633C0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarForearmRollController : MonoBehaviour, KDEMKMMCFEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float KMLMDEFFOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool FNAILHCCABH;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A63400", Offset = "0x6A61E00", VA = "0x186A63400", Slot = "4")]
		public void UpdateController(float OMPPDBKHEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xF796C0", Offset = "0xF780C0", VA = "0x180F796C0", Slot = "6")]
		public void SetEnabled(bool CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A63E80", Offset = "0x6A62880", VA = "0x186A63E80")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HandDisplaySettings HandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Header("Watch")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x341")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A63EB0", Offset = "0x6A628B0", VA = "0x186A63EB0")]
		public AnimationPoseSetting AIOFKBEDHCK(IBPCPGIHICI NMDGONIGDBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A63EE0", Offset = "0x6A628E0", VA = "0x186A63EE0")]
		public void FKBEJNBPEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A63F20", Offset = "0x6A62920", VA = "0x186A63F20")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A666E0", Offset = "0x6A650E0", VA = "0x186A666E0")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OFFAJDJBLID : KKJNGHJGLDI
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static int EDDJMDJNOMG;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int PBKMNPPECDK;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int JCFDDLLHGBM;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int IFGLAJNHPFF;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int NBFKPPNEIIM;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static int KAFPPBFJKAM;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int LFJAPINBPHL;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int[] LOEKPMKMFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private NPIOCLAEKFF CINDPPNIBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private MOJHHEKAHMF LJJFILHBPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private int CKNDHEOECHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float FMFHGKPMBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Animator OGNHCHCJNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AvatarFullBodyConfiguration INJOMFICHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int JOJBNALAMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private int LKDDFFEEEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int IMDEFEBGKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool OBADBHMNPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private KHNKMFKBAMO LHEGJBIAJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int LPOBLHIHIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private float NCFCMOOMENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private HandDisplaySettings OICECLDBCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private LJIAAKKJMFC HBIJIAMKAMN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform LAGBLPOIKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 ECDEBEOJPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF6A880", Offset = "0xF69280", VA = "0x180F6A880")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xF6A7A0", Offset = "0xF691A0", VA = "0x180F6A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion IIGNBKFMGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x15393B0", Offset = "0x1537DB0", VA = "0x1815393B0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2029A00", Offset = "0x2028400", VA = "0x182029A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool IHLOFMABLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E1B0", Offset = "0x6A7CBB0", VA = "0x186A7E1B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E1F0", Offset = "0x6A7CBF0", VA = "0x186A7E1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 PEFLODPBEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD73590", Offset = "0xD71F90", VA = "0x180D73590", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xD719C0", Offset = "0xD703C0", VA = "0x180D719C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion KCGJACFGNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA3E260", Offset = "0xA3CC60", VA = "0x180A3E260", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD72870", Offset = "0xD71270", VA = "0x180D72870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DMCEDLDHENL KLEOOJPANEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x929890", Offset = "0x928290", VA = "0x180929890", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DMCEDLDHENL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x92B7D0", Offset = "0x92A1D0", VA = "0x18092B7D0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DMCEDLDHENL AGMMODLLLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x145F770", Offset = "0x145E170", VA = "0x18145F770", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(DMCEDLDHENL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1B044E0", Offset = "0x1B02EE0", VA = "0x181B044E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float GNPHJFFBEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1577AE0", Offset = "0x15764E0", VA = "0x181577AE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x92B000", Offset = "0x929A00", VA = "0x18092B000", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool GEEDDDOLHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E0D0", Offset = "0x6A7CAD0", VA = "0x186A7E0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LHLJLFLOGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E220", Offset = "0x6A7CC20", VA = "0x186A7E220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KCODMANOJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E4A0", Offset = "0x6A7CEA0", VA = "0x186A7E4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool AOMJJPDJNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E770", Offset = "0x6A7D170", VA = "0x186A7E770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E540", Offset = "0x6A7CF40", VA = "0x186A7E540", Slot = "21")]
	public void PCEEADECCDH(NPIOCLAEKFF OIIKBEIOGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E100", Offset = "0x6A7CB00", VA = "0x186A7E100")]
	public void EADHJHEMMBC(MOJHHEKAHMF DGFMIFIEKJL, HandDisplaySettings HOCCJLPDDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E4B0", Offset = "0x6A7CEB0", VA = "0x186A7E4B0", Slot = "12")]
	public void OOMDJBJIIEI(bool CIPDEENNFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DDA0", Offset = "0x6A7C7A0", VA = "0x186A7DDA0", Slot = "11")]
	public void ANLGEAFNDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E230", Offset = "0x6A7CC30", VA = "0x186A7E230")]
	private int MFOEEIDDJKL(DMCEDLDHENL DCKEGIIOIBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7DC50", Offset = "0x6A7C650", VA = "0x186A7DC50")]
	private void AABKFKOEOGN(int DJBLOIPJLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E480", Offset = "0x6A7CE80", VA = "0x186A7E480", Slot = "13")]
	public bool OCNFENCKIFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E1A0", Offset = "0x6A7CBA0", VA = "0x186A7E1A0", Slot = "14")]
	public bool FIBAAOOMFBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E150", Offset = "0x6A7CB50", VA = "0x186A7E150")]
	private DMCEDLDHENL EKPGEELOLHP()
	{
		return default(DMCEDLDHENL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x11AA380", Offset = "0x11A8D80", VA = "0x1811AA380", Slot = "15")]
	public void FHIONJIODKB(bool CIPDEENNFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E440", Offset = "0x6A7CE40", VA = "0x186A7E440", Slot = "10")]
	public void NBEFNHPNMPG(int DJBLOIPJLJL, float MHCMGMLHGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E0E0", Offset = "0x6A7CAE0", VA = "0x186A7E0E0", Slot = "8")]
	public void DDBOFKAMLKH(KHNKMFKBAMO ACEEMNFHFMB, bool LICPECIHEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E1E0", Offset = "0x6A7CBE0", VA = "0x186A7E1E0", Slot = "9")]
	public void IBFCFFPODMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7E3F0", Offset = "0x6A7CDF0", VA = "0x186A7E3F0", Slot = "16")]
	public void MPALFIPCOPH(Transform DLPGBMPJIIG, Vector3 NIGFOLDLBHO, Quaternion GHFMCKINNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EA10", Offset = "0x6A7D410", VA = "0x186A7EA10")]
	public OFFAJDJBLID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LEAEOGGAPBF : BKACIKEJPIA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class DDEJNHECENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 NPFMOPBFBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Quaternion MDMCEJNLALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Vector3 FJIGIEJLDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Transform HAGFOJIMCGA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 KDAKJBLPFJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x15A3E20", Offset = "0x15A2820", VA = "0x1815A3E20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x15A3E40", Offset = "0x15A2840", VA = "0x1815A3E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion HAGEFKHAPDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xCAA990", Offset = "0xCA9390", VA = "0x180CAA990")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xCAAA10", Offset = "0xCA9410", VA = "0x180CAAA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float HLPCJGFGMFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA3E320", Offset = "0xA3CD20", VA = "0x180A3E320")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x10306A0", Offset = "0x102F0A0", VA = "0x1810306A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool FDHFPDKDFGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x891440", Offset = "0x88FE40", VA = "0x180891440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x891610", Offset = "0x890010", VA = "0x180891610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool GLDPGEGLDGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x891480", Offset = "0x88FE80", VA = "0x180891480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x891560", Offset = "0x88FF60", VA = "0x180891560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool LOGCNPCJEMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x891430", Offset = "0x88FE30", VA = "0x180891430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x891630", Offset = "0x890030", VA = "0x180891630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float IFDJNKAIENO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA3E350", Offset = "0xA3CD50", VA = "0x180A3E350")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x26714F0", Offset = "0x266FEF0", VA = "0x1826714F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A65000", Offset = "0x6A63A00", VA = "0x186A65000")]
		public void KJOKPACBNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A64FE0", Offset = "0x6A639E0", VA = "0x186A64FE0")]
		public void FNEKHCJMNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A64BE0", Offset = "0x6A635E0", VA = "0x186A64BE0")]
		public float EGBPABJCECJ(Transform ABEMALIIAAN, [In] FootSettings HBGBBNBHKCN, float JHDBCDCEDHO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A642B0", Offset = "0x6A62CB0", VA = "0x186A642B0")]
		public void CCNJNJNIJHA(Transform OBKIEBNBBMM, Transform IJGGINCOHIE, float LNLAKONMOBA, bool MGMIDPMFDLN, bool BHMAJFALOMI, float ALEHAOKABEH, float ONOKGIOKKBB, Transform MGPJOGDJPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A64DB0", Offset = "0x6A637B0", VA = "0x186A64DB0")]
		public void FADGICJDIHE(Transform NKBPAFFFKNL, Transform MGPJOGDJPHA, bool CEGGIIMMEFO, bool BHPIMAPGPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A64AE0", Offset = "0x6A634E0", VA = "0x186A64AE0")]
		private void DPECAEHLPAF(Transform MGPJOGDJPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A64A10", Offset = "0x6A63410", VA = "0x186A64A10")]
		public void DFHNDFBJJIK(Transform MGPJOGDJPHA, AvatarFullBodyConfiguration KNPAPMCPMPB, Vector3 ADJBHOCMAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A64FF0", Offset = "0x6A639F0", VA = "0x186A64FF0")]
		public void GKNFMIHPIAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A65010", Offset = "0x6A63A10", VA = "0x186A65010")]
		public DDEJNHECENA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class EDOFLCHGOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private float JIBJIIIEJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool EKIINMHLPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AnimationPoseSetting GNIBDBCECOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float MHAHAPOPDKH;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A665F0", Offset = "0x6A64FF0", VA = "0x186A665F0")]
		public void PANJDGPJNDF(IKSolverVR.Arm JHJHAJEBKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A66620", Offset = "0x6A65020", VA = "0x186A66620")]
		public void PAOOECAFFGP(IKSolverVR.Arm JHJHAJEBKAC, float MICMDKHIGKH, bool EKIINMHLPOI, AvatarFullBodyConfiguration KNPAPMCPMPB, float LBBEJLNBHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A66450", Offset = "0x6A64E50", VA = "0x186A66450")]
		private void LFOPIKMNLFB(IKSolverVR.Arm JHJHAJEBKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A654B0", Offset = "0x6A63EB0", VA = "0x186A654B0")]
		public void DBMOIEPOONB(IKSolverVR.Arm JHJHAJEBKAC, Transform FFPKHMMLIOA, Transform IJGGINCOHIE, Quaternion BELHHELNKHB, Vector3 KJHPFIOBAEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A65020", Offset = "0x6A63A20", VA = "0x186A65020")]
		private (Vector3, Quaternion) AEFELADENNL(OFFAJDJBLID KHCCELEMGEK, Quaternion OKLNOOLJCOI, Vector3 EDLJEJCKPHE)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A66490", Offset = "0x6A64E90", VA = "0x186A66490")]
		public void LIFIEOMEGLH(OFFAJDJBLID KHCCELEMGEK, IKSolverVR.Arm JHJHAJEBKAC, Quaternion OKLNOOLJCOI, Vector3 EDLJEJCKPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A659D0", Offset = "0x6A643D0", VA = "0x186A659D0")]
		public void GFKOOBGNOMM(OFFAJDJBLID KHCCELEMGEK, IKSolverVR.Arm JHJHAJEBKAC, Quaternion OKLNOOLJCOI, Vector3 EDLJEJCKPHE, [In] AvatarFullBodyConfiguration KNPAPMCPMPB, [In] FCMNGFAPMAI ACEEMNFHFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A65890", Offset = "0x6A64290", VA = "0x186A65890")]
		public void EEBHCBGLPLD(IBPCPGIHICI NFHIBLJKIDB, AvatarFullBodyConfiguration KNPAPMCPMPB, FCMNGFAPMAI ACEEMNFHFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A65FD0", Offset = "0x6A649D0", VA = "0x186A65FD0")]
		public void IDDCDJEAOLK(IKSolverVR.Arm JHJHAJEBKAC, Transform FFPKHMMLIOA, Vector3 HBOLMJLANAC, float PAIAENIMHCP, Quaternion JGLPKHDLNIL, Vector3 CGHCJPONMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A66660", Offset = "0x6A65060", VA = "0x186A66660")]
		public EDOFLCHGOEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum NIBDLJBOAIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int JGIMNBLHCEH;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int HNNAJCBOKNB;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int OJLBOGFIINE;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int MIEDAMKOALG;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int HMKGNKKFKAN;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int DKLCLENLHMK;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int ANMHOJOFFEP;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int LJCOGNNOFMC;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int HJDCGNMLEKO;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int FDBDFMBIBEG;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int CAMEKKMHCDC;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int GGHGCEBPAED;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int BICAKIGAING;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int OFDMLFKECCF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int GCEJDHMAEDA;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int CNFEEICIODH;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int FHAMGFFLDMJ;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int JFFLIDFHEBC;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int ACLKKKGGIOO;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int NDHKGELJJAD;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int ENGFLBBKPCF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int CFOOCICCFLF;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int FANINFIFFIH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int EPGNADBOMCA;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int PIEFHILGKHH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int AHJHDIODCPA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int OIMFENNIGCG;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int HKPGECLEALL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int BLBGPPEIHPM;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly Vector3 FHHCFAJLCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool FFFBLBEONAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool CBHAFFHBBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool DBDMJLFLMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool MHFFEHNNELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool FHELHLHNBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Vector3 AIEBBNMFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private string IOABHACDNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private HAALKJBIFLL? CINDPPNIBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private MIODDBCPMAL? EIDAFABHELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private JFBKCLMGPNG LJEJMDCEBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private COIKIBKNBPI IGCEKBLKPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private OFFAJDJBLID EKJLLFMMBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private OFFAJDJBLID MBGLLOKFIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool JFNIPIJIINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool MFOMNIFKPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly PNBAKDFDPBJ AFDKBCPHOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly KHJBOPJJEBM LPICADHDPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int EMNCDFOBMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private float HBGFMHHDCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private GameObject JHBODHJMJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Transform DLIFCKECHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform OCANIEOALCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Transform DHIFDFGJKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform BBBDPKMDOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform OCJHEKHKLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float BJELECFLHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float DCNOMNMIKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Vector3 NCBDGLFFAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Quaternion OJGEPCHEMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform GACPPMCEFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform FIKIGJGAMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform NGBCJFCEMGC;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker FIDIBBECOMF;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker EMOFJNCAGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private ProfilerMarker PHEMFLOIIEC;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker JDGCAONPOIA;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker FPBBGOOKBIE;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker LHCIPGPFMFD;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly List<LEAEOGGAPBF> MIPPAGOCKGO;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int EAKBEKALANP;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> LCMBGMHMOPG;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static int CIBIBANBDPD;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int OGCKPPPPODP;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int MDOGEBDOCIJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int DAEEBFHGJOI;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static float IBKAGCFKGPA;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int EKFEOLNKBIP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static float EKFOEDCBGMD;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static float FHNIANGIJDD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float CDDIHLIJACM;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static float IPKCPIKKHLP;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static IODNCFKJFBM FLCELMPBIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float CHGLIDFIKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool JILMEGGEOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float CLHPBJCPFGD;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly int JKMKJIOHJNI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly int AAMOBLBAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private DDEJNHECENA AJMPMIGDKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private DDEJNHECENA NIBFBCBLGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private float OONKEMOFEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Vector3 MMHNIACPMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private Vector3 OEIBGMPJOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool JOKBMHMGJFB;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly Quaternion EHIAGENLECK;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly Quaternion BKKKHCMJPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly Vector3 PELPMABHODH;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly Vector3 HDJPGODKPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float LJHELECHMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float INMNDPEJELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private EDOFLCHGOEB BLGEIDKEKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private EDOFLCHGOEB JKNOMGJOJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private EJEMNALIPEK FJNNPKJHADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private CACGGCDDNDC PADABMJBIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly DIJKAPEGFIF FJJEMDLNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float KCKMLPBOJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float DNKMELDAJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly CACGGCDDNDC HIKALKPEOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 DOMGLFICPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 AODKNENHCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float KFLNBFNNKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private float HPEALINOMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly CACGGCDDNDC DPMEPOIOFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly EJEMNALIPEK LINGMHNCHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly CACGGCDDNDC JCDIPMCGPAB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PLAJPLAPENK IMBFNJCNCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PLAJPLAPENK DDFDOMMKILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration FENCHBEAGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A74320", Offset = "0x6A72D20", VA = "0x186A74320", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LJIAAKKJMFC EAKPPFDKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A77410", Offset = "0x6A75E10", VA = "0x186A77410", Slot = "23")]
		get
		{
			return default(LJIAAKKJMFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration CIDNEEFPHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A69450", Offset = "0x6A67E50", VA = "0x186A69450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform EBCFKEIFFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DC80", Offset = "0x6A6C680", VA = "0x186A6DC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform FNNNDAJMGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A69B30", Offset = "0x6A68530", VA = "0x186A69B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer IGPFMBENMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A76CB0", Offset = "0x6A756B0", VA = "0x186A76CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] MKBJINBJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A70980", Offset = "0x6A6F380", VA = "0x186A70980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] ILLNECNPAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A74420", Offset = "0x6A72E20", VA = "0x186A74420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator MDLDBOFIJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C7B0", Offset = "0x6A6B1B0", VA = "0x186A6C7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK LLBPMDKPIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E930", Offset = "0x6A6D330", VA = "0x186A6E930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private KDEMKMMCFEE HFOOLJDEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C020", Offset = "0x6A6AA20", VA = "0x186A6C020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private KDEMKMMCFEE EENDLFIDNOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DD80", Offset = "0x6A6C780", VA = "0x186A6DD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private KDEMKMMCFEE AKEGMHOFOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A747B0", Offset = "0x6A731B0", VA = "0x186A747B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private KDEMKMMCFEE EGMNBPPBCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A120", Offset = "0x6A68B20", VA = "0x186A6A120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private KDEMKMMCFEE HAIOEKHBILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C6B0", Offset = "0x6A6B0B0", VA = "0x186A6C6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private KDEMKMMCFEE BDHMNAPMJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A68560", Offset = "0x6A66F60", VA = "0x186A68560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private KDEMKMMCFEE OOJOMLMFFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A6D9F0", Offset = "0x6A6C3F0", VA = "0x186A6D9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private KDEMKMMCFEE IDJBNBMPJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6A67130", Offset = "0x6A65B30", VA = "0x186A67130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public MIODDBCPMAL JGIPBCMLINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6A75F40", Offset = "0x6A74940", VA = "0x186A75F40", Slot = "15")]
		get
		{
			return default(MIODDBCPMAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public HPBDMLCGCCD LMCOOJACBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x14C6EC0", Offset = "0x14C58C0", VA = "0x1814C6EC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public JPLPDGPDHJC IOLPHOFIMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x15FB9C0", Offset = "0x15FA3C0", VA = "0x1815FB9C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public KKJNGHJGLDI HBMDNEFNOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1426F20", Offset = "0x1425920", VA = "0x181426F20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KKJNGHJGLDI FDODEGKELDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x15FBDC0", Offset = "0x15FA7C0", VA = "0x1815FBDC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string GMFCGBFPKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform MGLOKCAHMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A7CD60", Offset = "0x6A7B760", VA = "0x186A7CD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform IJHNDGHMCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A69230", Offset = "0x6A67C30", VA = "0x186A69230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform KDJLIFHJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A76DB0", Offset = "0x6A757B0", VA = "0x186A76DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool BLADLOLEIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F980", Offset = "0x6A6E380", VA = "0x186A6F980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform BCEOGKIJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6A670", Offset = "0x6A69070", VA = "0x186A6A670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject EABKFLBGOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EE60", Offset = "0x6A6D860", VA = "0x186A6EE60", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets OAKGKMHDHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A69AB0", Offset = "0x6A684B0", VA = "0x186A69AB0", Slot = "31")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform CNLKMKKAFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xC9CD20", Offset = "0xC9B720", VA = "0x180C9CD20", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform PLPFCFDDDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xC9CD00", Offset = "0xC9B700", VA = "0x180C9CD00", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform MBBJDDJMAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1B383B0", Offset = "0x1B36DB0", VA = "0x181B383B0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform OMOMDEGCIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1495AE0", Offset = "0x14944E0", VA = "0x181495AE0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 NPONPHLNDND
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DAF0", Offset = "0x6A6C4F0", VA = "0x186A6DAF0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float KFCPFFMKIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FD60", Offset = "0x6A6E760", VA = "0x186A6FD60", Slot = "37")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform MKCCDNGNJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A693F0", Offset = "0x6A67DF0", VA = "0x186A693F0", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform DNBHPDNIFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x18F7870", Offset = "0x18F6270", VA = "0x1818F7870", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform FKKAEEEHNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x18F7940", Offset = "0x18F6340", VA = "0x1818F7940", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform IMPKGMCBKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x14966B0", Offset = "0x14950B0", VA = "0x1814966B0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool MNJKNJENDAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A767F0", Offset = "0x6A751F0", VA = "0x186A767F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool NJKPPICPLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DB80", Offset = "0x6A6C580", VA = "0x186A6DB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool ADKOPFLLFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A76E20", Offset = "0x6A75820", VA = "0x186A76E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A72660", Offset = "0x6A71060", VA = "0x186A72660")]
	private void IPACDFPIDBK([In] FCMNGFAPMAI ADPFBHKGCMF, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A220", Offset = "0x6A68C20", VA = "0x186A6A220")]
	private void CFMJHIAKLEH(FCMNGFAPMAI ADPFBHKGCMF, AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A707B0", Offset = "0x6A6F1B0", VA = "0x186A707B0")]
	private void GNGFPPIOINC([In] FCMNGFAPMAI ACEEMNFHFMB, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D720", Offset = "0x6A7C120", VA = "0x186A7D720")]
	public LEAEOGGAPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A76EA0", Offset = "0x6A758A0", VA = "0x186A76EA0", Slot = "12")]
	public void MBBFLLICBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A768F0", Offset = "0x6A752F0", VA = "0x186A768F0", Slot = "13")]
	public void LJPLCLHLABB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A770", Offset = "0x6A69170", VA = "0x186A6A770", Slot = "14")]
	public void CGNOIBKIOHM(bool CAKFIIEDIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D420", Offset = "0x6A6BE20", VA = "0x186A6D420", Slot = "25")]
	public Transform CMKPJOLJJCM(string FLGKLJDBOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A70510", Offset = "0x6A6EF10", VA = "0x186A70510", Slot = "26")]
	public Vector3? FOHFMNBAGMF(string FLGKLJDBOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A71840", Offset = "0x6A70240", VA = "0x186A71840", Slot = "7")]
	public void IBIHPKBGFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C360", Offset = "0x6A7AD60", VA = "0x186A7C360")]
	private void PCNLIODONKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A6AC70", Offset = "0x6A69670", VA = "0x186A6AC70", Slot = "6")]
	public void CIADAHECLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A76420", Offset = "0x6A74E20", VA = "0x186A76420", Slot = "8")]
	public void LFDAIICBNBJ(float INIHLANBLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A71F00", Offset = "0x6A70900", VA = "0x186A71F00")]
	private void IGABNCHIDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A776D0", Offset = "0x6A760D0", VA = "0x186A776D0", Slot = "4")]
	public void MOBBLNOKNNE(string GADKBOCLPJK, HAALKJBIFLL AHEGCKNDBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A748F0", Offset = "0x6A732F0", VA = "0x186A748F0", Slot = "5")]
	public void KAKMKMOFGFH(MIODDBCPMAL DGFMIFIEKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A79940", Offset = "0x6A78340", VA = "0x186A79940", Slot = "11")]
	public void NCICOGHHIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D090", Offset = "0x6A6BA90", VA = "0x186A6D090", Slot = "24")]
	public void CMCOHLPDODL([Out] Vector3 DIOMEDAAILL, [Out] Quaternion JGLPKHDLNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A70780", Offset = "0x6A6F180", VA = "0x186A70780")]
	private void GMCDOIJNBPO([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B630", Offset = "0x6A7A030", VA = "0x186A7B630", Slot = "27")]
	public void OEONLPHNEFF(float AJLKGICELDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A76490", Offset = "0x6A74E90", VA = "0x186A76490", Slot = "28")]
	public void LHFPKFCNBHF(float HNGNFOGLPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D570", Offset = "0x6A6BF70", VA = "0x186A6D570", Slot = "43")]
	public void CNEIHDJKFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A751B0", Offset = "0x6A73BB0", VA = "0x186A751B0", Slot = "29")]
	public HandLogicOffsets KCAMIOEPELK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A66BB0", Offset = "0x6A655B0", VA = "0x186A66BB0", Slot = "30")]
	public PlatformSpecificPlayerHandOffsets ACPADLMAHHH()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A692A0", Offset = "0x6A67CA0", VA = "0x186A692A0")]
	private void BDPDLAALKIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EA30", Offset = "0x6A6D430", VA = "0x186A6EA30")]
	private void EKGBGGMMIDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A66720", Offset = "0x6A65120", VA = "0x186A66720")]
	private void ABDNHOLDPCL(FJDKJBAPALO FKIIFADNMND, bool LHJNJOHGEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A77510", Offset = "0x6A75F10", VA = "0x186A77510")]
	private void MOAGJLKECID(FJDKJBAPALO FKIIFADNMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A773C0", Offset = "0x6A75DC0", VA = "0x186A773C0")]
	public Vector3 MHCDNHPHLCK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A5C0", Offset = "0x6A68FC0", VA = "0x186A6A5C0")]
	private void CGHGOMLDCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FD40", Offset = "0x6A6E740", VA = "0x186A6FD40")]
	private void FGINPLKDKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C680", Offset = "0x6A7B080", VA = "0x186A7C680")]
	private float PJGLFFAEPKN([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A706A0", Offset = "0x6A6F0A0", VA = "0x186A706A0")]
	private int GLBONKOJFEE([In] DFKFFDGMMBA HIJJKPEKMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C830", Offset = "0x6A7B230", VA = "0x186A7C830")]
	private void PLOFMCEJABO(FCMNGFAPMAI ADPFBHKGCMF, bool DKIIJAADFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B120", Offset = "0x6A79B20", VA = "0x186A7B120")]
	private static void NNAFMHBHACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A3F0", Offset = "0x6A78DF0", VA = "0x186A7A3F0")]
	private static void NMILAFJEIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A70E90", Offset = "0x6A6F890", VA = "0x186A70E90")]
	private float HOMGMPBJKHB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A69030", Offset = "0x6A67A30", VA = "0x186A69030")]
	private static int ALHFICPPJAH(LEAEOGGAPBF JHAFNHPHBBL, LEAEOGGAPBF GONHEFIHLCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A76070", Offset = "0x6A74A70", VA = "0x186A76070", Slot = "39")]
	public FCMNGFAPMAI LDDJDGCECME()
	{
		return default(FCMNGFAPMAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A748B0", Offset = "0x6A732B0", VA = "0x186A748B0")]
	public void JKBBIGANANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C460", Offset = "0x6A7AE60", VA = "0x186A7C460")]
	private (bool, bool) PICMNLFBHNK()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A67230", Offset = "0x6A65C30", VA = "0x186A67230")]
	private void AJJDFPPGCJG([In] FCMNGFAPMAI ACEEMNFHFMB, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A6A840", Offset = "0x6A69240", VA = "0x186A6A840")]
	private void CHCJFMBCLPD([In] FCMNGFAPMAI ACEEMNFHFMB, [In] AvatarFullBodyConfiguration KNPAPMCPMPB, FootSettings HBGBBNBHKCN, bool CECEJGLBDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DC00", Offset = "0x6A6C600", VA = "0x186A6DC00")]
	private float DKJKIOMNIBD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A6EF00", Offset = "0x6A6D900", VA = "0x186A6EF00")]
	private void EPHFJCCBLDF(FCMNGFAPMAI ACEEMNFHFMB, AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B5E0", Offset = "0x6A79FE0", VA = "0x186A7B5E0")]
	private float ODOBFDKAOPN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A69C30", Offset = "0x6A68630", VA = "0x186A69C30")]
	private void BOHMJFKDDAI([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A6D6A0", Offset = "0x6A6C0A0", VA = "0x186A6D6A0")]
	private void DBMOIEPOONB([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A694E0", Offset = "0x6A67EE0", VA = "0x186A694E0")]
	private void BIOIMCADCCC([In] FCMNGFAPMAI ACEEMNFHFMB, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B330", Offset = "0x6A79D30", VA = "0x186A7B330")]
	private void OCMHFCJHKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A761D0", Offset = "0x6A74BD0", VA = "0x186A761D0")]
	private void LDJIGNCCFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B640", Offset = "0x6A7A040", VA = "0x186A7B640")]
	private void OIMMBNMFNHI([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A74520", Offset = "0x6A72F20", VA = "0x186A74520")]
	private void JDKHKBPFLDJ(OFFAJDJBLID NBMCEOEKEKH, IKSolverVR.Arm JHJHAJEBKAC, Transform HBDHCEJJOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A6F9D0", Offset = "0x6A6E3D0", VA = "0x186A6F9D0")]
	private void FBNOKMFNJKN(FCMNGFAPMAI ACEEMNFHFMB, AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A69060", Offset = "0x6A67A60", VA = "0x186A69060")]
	private void ANLGEAFNDOL(DDCDBMMKLME NIJBJNAFPAI, KKJNGHJGLDI NBMCEOEKEKH, IKSolverVR.Arm JHJHAJEBKAC, float MICMDKHIGKH, float LDBMAHLMAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DF50", Offset = "0x6A6C950", VA = "0x186A6DF50")]
	private void EBLHFKCCNIF([In] FCMNGFAPMAI ACEEMNFHFMB, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A74DB0", Offset = "0x6A737B0", VA = "0x186A74DB0")]
	protected void KBMOPIABHLC([In] FCMNGFAPMAI ACEEMNFHFMB, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7B7E0", Offset = "0x6A7A1E0", VA = "0x186A7B7E0")]
	private void OMKLCKNCBOC([In] FCMNGFAPMAI ACEEMNFHFMB, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A6FDB0", Offset = "0x6A6E7B0", VA = "0x186A6FDB0")]
	protected void FJJNBDGGKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BAC0", Offset = "0x6A7A4C0", VA = "0x186A7BAC0")]
	private void PACCDMJJLDB([In] FCMNGFAPMAI ACEEMNFHFMB, [In] NIBDLJBOAIK APPIFEICLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A724B0", Offset = "0x6A70EB0", VA = "0x186A724B0")]
	private void IOJCPDEPBMA(FCMNGFAPMAI ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A71F50", Offset = "0x6A70950", VA = "0x186A71F50")]
	private void IHJNBKLBJOI([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A66C70", Offset = "0x6A65670", VA = "0x186A66C70")]
	private Vector3 ADBEDDFLEHF([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A6DE80", Offset = "0x6A6C880", VA = "0x186A6DE80")]
	private void DPAMFEGAMEE([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A71070", Offset = "0x6A6FA70", VA = "0x186A71070")]
	private float IAGLBJFECHL(float ONOKGIOKKBB, [In] FCMNGFAPMAI ACEEMNFHFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A79A30", Offset = "0x6A78430", VA = "0x186A79A30")]
	private void NGNHFBOIGBO(float ONOKGIOKKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A70070", Offset = "0x6A6EA70", VA = "0x186A70070")]
	private void FJLCPFMKDIH([In] FCMNGFAPMAI ACEEMNFHFMB, NIBDLJBOAIK APPIFEICLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C120", Offset = "0x6A6AB20", VA = "0x186A6C120")]
	private float CJKACFOLIDE([In] FCMNGFAPMAI ADPFBHKGCMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A71F90", Offset = "0x6A70990", VA = "0x186A71F90")]
	private void INNACBLNGHC(FCMNGFAPMAI ACEEMNFHFMB, NIBDLJBOAIK APPIFEICLIL, Vector3 CKOOJHLBKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A66A00", Offset = "0x6A65400", VA = "0x186A66A00")]
	private static void ACOGOHLOENA(Transform JKDLLOIHFGK, Quaternion FJFNLINEAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E600", Offset = "0x6A6D000", VA = "0x186A6E600")]
	private void ECAPDOMEBPP([In] FCMNGFAPMAI IJDAEIDBODM, [In] DFKFFDGMMBA HIJJKPEKMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A79B80", Offset = "0x6A78580", VA = "0x186A79B80")]
	private void NKJONOFPADA([In] FCMNGFAPMAI IJDAEIDBODM, [In] DFKFFDGMMBA HIJJKPEKMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A79790", Offset = "0x6A78190", VA = "0x186A79790")]
	private void NAFDAPHFPHP(float PDNODHHEBLP, [In] FCMNGFAPMAI ADPFBHKGCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A75630", Offset = "0x6A74030", VA = "0x186A75630")]
	private float KFDGCOINECE([In] FCMNGFAPMAI ADPFBHKGCMF, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A73F00", Offset = "0x6A72900", VA = "0x186A73F00")]
	private void JAECJDMBMOC([In] FCMNGFAPMAI ADPFBHKGCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A6C8B0", Offset = "0x6A6B2B0", VA = "0x186A6C8B0")]
	private void CMBHDPEPNEC([In] FCMNGFAPMAI ADPFBHKGCMF, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A714A0", Offset = "0x6A6FEA0", VA = "0x186A714A0")]
	private void IANOFGEJCNG([In] FCMNGFAPMAI ADPFBHKGCMF, float CNNAJKECKGD, float JCOOGEFAPGA, Vector3 EGIDOFPJHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A68660", Offset = "0x6A67060", VA = "0x186A68660")]
	private void AKACIJMBOHL(FCMNGFAPMAI ADPFBHKGCMF, AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A70A80", Offset = "0x6A6F480", VA = "0x186A70A80")]
	private void HIBNLDHHPDH(FCMNGFAPMAI ADPFBHKGCMF, AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A75D70", Offset = "0x6A74770", VA = "0x186A75D70")]
	public void KFDIMKCBPPJ([In] FCMNGFAPMAI ACEEMNFHFMB, [In] AvatarFullBodyConfiguration KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A74170", Offset = "0x6A72B70", VA = "0x186A74170")]
	[CompilerGenerated]
	internal static void JCFCDEBJFKB(Transform CDNMICCKGIM, IKSolverVR.Arm JHJHAJEBKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A796C0", Offset = "0x6A780C0", VA = "0x186A796C0")]
	[CompilerGenerated]
	internal static void MPOENLMAKMP(DDEJNHECENA MNAJKPPLLDN, DDEJNHECENA EIKKMCJAEBL, Transform DAJICJEFKCE, float DMBOCOKFCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C250", Offset = "0x6A7AC50", VA = "0x186A7C250")]
	[CompilerGenerated]
	internal static bool PCEBNLPPFBH(IKSolverVR.Arm JHJHAJEBKAC, HFNAGABCGMO HHKFEHPNJLO, float LENPIEOJLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A75200", Offset = "0x6A73C00", VA = "0x186A75200")]
	[CompilerGenerated]
	internal static float KCKMBMKLLJP(Vector3 ANHIBCEODEM, Vector3 BFMKFLOAFPD, Vector3 ENEJFPBDIPA, FCMNGFAPMAI ADPFBHKGCMF, AvatarFullBodyConfiguration KNPAPMCPMPB, float ELDAPMPELBH)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum IALIJOFADDP
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private IALIJOFADDP handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6A81F30", Offset = "0x6A80930", VA = "0x186A81F30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A81EF0", Offset = "0x6A808F0", VA = "0x186A81EF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A818F0", Offset = "0x6A802F0", VA = "0x186A818F0")]
		private void AELMEPELNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A9F0", Offset = "0x6A293F0", VA = "0x186A2A9F0", Slot = "4")]
		public void SetEnabled(bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6A81F60", Offset = "0x6A80960", VA = "0x186A81F60")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarKneeBendTargetController : MonoBehaviour, KDEMKMMCFEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private Vector3 IECMHAFNHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private Vector3 FBNDOMNKIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Vector3 KHCALEJKEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Matrix4x4 AHKCMAEFONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool FNAILHCCABH;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A82400", Offset = "0x6A80E00", VA = "0x186A82400", Slot = "4")]
		public void UpdateController(float OMPPDBKHEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6A823F0", Offset = "0x6A80DF0", VA = "0x186A823F0", Slot = "6")]
		public void SetEnabled(bool CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6A81F90", Offset = "0x6A80990", VA = "0x186A81F90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A82AC0", Offset = "0x6A814C0", VA = "0x186A82AC0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, DHBGEPCIJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[Header("Configuration")]
		[SerializeField]
		private LJIAAKKJMFC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[EHNJJNMEJEA(BILCJMODHFE.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[Header("Facial Animation")]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private BKACIKEJPIA GLKIECDGCND;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public BKACIKEJPIA CJOBAGOHPBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8DD390", Offset = "0x8DBD90", VA = "0x1808DD390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform HBMHAKMPLLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x6A83950", Offset = "0x6A82350", VA = "0x186A83950", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A82AD0", Offset = "0x6A814D0", VA = "0x186A82AD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A83810", Offset = "0x6A82210", VA = "0x186A83810")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A837C0", Offset = "0x6A821C0", VA = "0x186A837C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A83750", Offset = "0x6A82150", VA = "0x186A83750")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6A82AD0", Offset = "0x6A814D0", VA = "0x186A82AD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6A82F50", Offset = "0x6A81950", VA = "0x186A82F50", Slot = "6")]
		public BKACIKEJPIA CreateAvatarSystem(string GADKBOCLPJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A83750", Offset = "0x6A82150", VA = "0x186A83750", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6A82B80", Offset = "0x6A81580", VA = "0x186A82B80", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6A83860", Offset = "0x6A82260", VA = "0x186A83860", Slot = "9")]
		public void UpdatePostIKAnimControllers(float OMPPDBKHEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[RecRoom.NoEngine.Common.Preserve]
internal class GOAHONIFHBO : ACIEJAKNPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private Dictionary<string, BKACIKEJPIA> PFLJOJOHGDM;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A85C80", Offset = "0x6A84680", VA = "0x186A85C80")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void HGKIIHMMLFL(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A859F0", Offset = "0x6A843F0", VA = "0x186A859F0", Slot = "4")]
	public BKACIKEJPIA BNPABFMLLAK(string MOBGCGNBBOP, AvatarSystemConfiguration ALLBDHOEBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A85E30", Offset = "0x6A84830", VA = "0x186A85E30", Slot = "5")]
	public void OJDPIFMCMBI(string MOBGCGNBBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A85CF0", Offset = "0x6A846F0", VA = "0x186A85CF0", Slot = "6")]
	public string JLKJDIMGEKP(string CODJHBDIGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6A85C10", Offset = "0x6A84610", VA = "0x186A85C10")]
	private string GICAFNKDKOM(string CODJHBDIGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FB0", Offset = "0x6A849B0", VA = "0x186A85FB0")]
	public GOAHONIFHBO()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class NKCEFIDGNGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private Dictionary<string, Transform> JHPLKMLANHL;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool OFKDLHJCMKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x6A8CAC0", Offset = "0x6A8B4C0", VA = "0x186A8CAC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CB00", Offset = "0x6A8B500", VA = "0x186A8CB00")]
			public void OKMDNOGGCJB(VRIK GEABNOHILNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
			public void AMMNAGNJBFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CA70", Offset = "0x6A8B470", VA = "0x186A8CA70")]
			public void CGBFLDMMJFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x6A8CC30", Offset = "0x6A8B630", VA = "0x186A8CC30")]
			public NKCEFIDGNGB()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		[HIPIAIBDPPP(BILCJMODHFE.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly NKCEFIDGNGB BILBNOLOEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private DHBGEPCIJOK CAJPDHDPBIB;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6A83A00", Offset = "0x6A82400", VA = "0x186A83A00")]
		private void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6A839A0", Offset = "0x6A823A0", VA = "0x186A839A0")]
		private bool ADOJPPNMEGN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A839F0", Offset = "0x6A823F0", VA = "0x186A839F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6A83D30", Offset = "0x6A82730", VA = "0x186A83D30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6A83CD0", Offset = "0x6A826D0", VA = "0x186A83CD0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6A83FA0", Offset = "0x6A829A0", VA = "0x186A83FA0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6A87CF0", Offset = "0x6A866F0", VA = "0x186A87CF0")]
		public void FKBEJNBPEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6A87E10", Offset = "0x6A86810", VA = "0x186A87E10")]
		public int PMNHIIKHPDA(int BALJAOJNICM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HandDisplaySettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x6A87E80", Offset = "0x6A86880", VA = "0x186A87E80")]
			public void FKBEJNBPEHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6A87F60", Offset = "0x6A86960", VA = "0x186A87F60")]
			public (float, float) GJIIFAIMJIE(Animator LCOKPPOONCL, AnimatorStateInfo FILKBFCLLCC)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A882B0", Offset = "0x6A86CB0", VA = "0x186A882B0")]
		public void FKBEJNBPEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A884A0", Offset = "0x6A86EA0", VA = "0x186A884A0")]
		public (float, float) POLPMBAEIKC(Animator LCOKPPOONCL)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A880A0", Offset = "0x6A86AA0", VA = "0x186A880A0")]
		private (float, float) ABEBEPDECBM(Animator LCOKPPOONCL, AnimatorStateInfo FILKBFCLLCC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A886B0", Offset = "0x6A870B0", VA = "0x186A886B0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C8F0", Offset = "0x6A8B2F0", VA = "0x186A8C8F0", Slot = "4")]
		public override void OnStateEnter(Animator LCOKPPOONCL, AnimatorStateInfo FILKBFCLLCC, int CDOKLHBBLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CA50", Offset = "0x6A8B450", VA = "0x186A8CA50")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class BBNLKLPNEAG<TInput, TOutput> : IFDAFPNLJEK<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	protected readonly GFEMHOFJCGN OOBEMKODKLN;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB990", Offset = "0x4FFA390", VA = "0x184FFB990")]
	protected BBNLKLPNEAG(GFEMHOFJCGN OOBEMKODKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput ILDFGHALABA(TInput DKDIADEJLHP, [Out] IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB8F0", Offset = "0x4FFA2F0", VA = "0x184FFB8F0", Slot = "5")]
	public bool JCBJPPKKDJI(TInput DKDIADEJLHP, [Out] TOutput? DFEFBOIIPKP, [Out] IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[PLAFBFJHEAK]
public static class FIHIMNHNGBO
{
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly Regex NCGALGLOHKF;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6A850F0", Offset = "0x6A83AF0", VA = "0x186A850F0")]
	public static GJJDGJFKAMA KBFAFKIEBLD(PPKIGHIHCHJ JPFIIFIHDHE, NLPKIMNBAMP CFPKGOJEEDA, Guid? IHILNBAGNHB, Color? PAFCDOOAFIB, PLGDACFFJCI IIACJIKFNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6A84F80", Offset = "0x6A83980", VA = "0x186A84F80")]
	public static AHDCONECEDL BAHBMLKONGB(GJJDGJFKAMA OIGMDCDEKEG)
	{
		return default(AHDCONECEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2C69FF0", Offset = "0x2C689F0", VA = "0x182C69FF0")]
	internal static TModern? ENGAMPMGKHM<TModern>(string? DKDIADEJLHP, PNKMDIEINFE<TModern> GEJOBNDAJEM, GFEMHOFJCGN OOBEMKODKLN, IKAJNCJIIBO MNKHCEMCLKE, TModern KCNLCGCBJPA) where TModern : struct, NAOFDPDFIEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2C69810", Offset = "0x2C68210", VA = "0x182C69810")]
	internal static FKKPIHEJPIN EEJEMBNAJLK<TModern>(string? DKDIADEJLHP, PNKMDIEINFE<TModern> GEJOBNDAJEM, GFEMHOFJCGN OOBEMKODKLN, IKAJNCJIIBO MNKHCEMCLKE, TModern KCNLCGCBJPA) where TModern : struct, NAOFDPDFIEP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6A85300", Offset = "0x6A83D00", VA = "0x186A85300")]
	internal static List<CGDNFBGOLIE> LNFPFKICKJE(IEnumerable<CLFDHDJNLLH>? CEJLEJNAECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2C6B560", Offset = "0x2C69F60", VA = "0x182C6B560")]
	internal static string OLILMCAOKDE<TModern>(TModern DKDIADEJLHP, PNKMDIEINFE<TModern> GEJOBNDAJEM, GFEMHOFJCGN OOBEMKODKLN) where TModern : NAOFDPDFIEP
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class ABDDDMAKHNL : BPNMKGBBJGN
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IFDAFPNLJEK<CCHKDPCEGOP, OGHEBKGCIPF> KAOOLDFPIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IFDAFPNLJEK<HHPMELGLIIA, EJNDBNBBEPK> NKFIDCIGEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IFDAFPNLJEK<HHPMELGLIIA, EJNDBNBBEPK> AIANDENMCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public BCHDILIKMIB JPOLAODOEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public PGCNPBAMDAC BKBOALCKELC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6A80970", Offset = "0x6A7F370", VA = "0x186A80970")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	[UsedImplicitly]
	internal static void NKHHMPMLMGG(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A809E0", Offset = "0x6A7F3E0", VA = "0x186A809E0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ABDDDMAKHNL([CNNDHKODGDP("UnitySerialization")] NLJFGCALLNJ HCPJBBGPJMP, [CNNDHKODGDP(null)] BDGAMALNPBH HMALHDFPOKM, [CNNDHKODGDP(null)] GFEMHOFJCGN OOBEMKODKLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum BGKDKJJLDLL
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JAFNEEPIEHD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A886C0", Offset = "0x6A870C0", VA = "0x186A886C0")]
	public JAFNEEPIEHD(string MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A88760", Offset = "0x6A87160", VA = "0x186A88760")]
	public JAFNEEPIEHD(string MEBLNPKEJMN, Exception LBKPPFCANNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6A886F0", Offset = "0x6A870F0", VA = "0x186A886F0")]
	public JAFNEEPIEHD(BGKDKJJLDLL AEIPLEGPCAL, string MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6A88720", Offset = "0x6A87120", VA = "0x186A88720")]
	public JAFNEEPIEHD(BGKDKJJLDLL AEIPLEGPCAL, string MEBLNPKEJMN, Exception LBKPPFCANNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal abstract class JOBEIANNHHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly NLJFGCALLNJ HCPJBBGPJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	protected readonly BDGAMALNPBH HMALHDFPOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	protected readonly GFEMHOFJCGN OOBEMKODKLN;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6A84770", Offset = "0x6A83170", VA = "0x186A84770")]
	protected JOBEIANNHHC(NLJFGCALLNJ HCPJBBGPJMP, BDGAMALNPBH HMALHDFPOKM, GFEMHOFJCGN OOBEMKODKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6A88790", Offset = "0x6A87190", VA = "0x186A88790")]
	protected string BLDLOKGJKJL(OGHEBKGCIPF OCPNBFGAMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6A89A70", Offset = "0x6A88470", VA = "0x186A89A70")]
	protected string JBPDCJNLEHP(OGHEBKGCIPF OCPNBFGAMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6A89C50", Offset = "0x6A88650", VA = "0x186A89C50")]
	private AvatarOutfitSelectionData KBFAFKIEBLD(GJJDGJFKAMA NBBMGDELGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6A89F80", Offset = "0x6A88980", VA = "0x186A89F80")]
	private static AvatarCustomizationSettingsData.AnchorParams LIILJKCPJJP(IDDKLPOMBMA? POOAGJMBAEN)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IFDAFPNLJEK<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput ILDFGHALABA(TInput DKDIADEJLHP, [Out] IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JCBJPPKKDJI(TInput DKDIADEJLHP, [Out] TOutput? DFEFBOIIPKP, [Out] IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BPNMKGBBJGN
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	IFDAFPNLJEK<CCHKDPCEGOP, OGHEBKGCIPF> KAOOLDFPIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	IFDAFPNLJEK<HHPMELGLIIA, EJNDBNBBEPK> AIANDENMCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	BCHDILIKMIB JPOLAODOEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum IKAJNCJIIBO
{
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PGCNPBAMDAC
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BEHKGJEOEJH LKLOMDOAOHF(OGHEBKGCIPF OIGMDCDEKEG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface BCHDILIKMIB
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHPMELGLIIA LKLOMDOAOHF(OGHEBKGCIPF OIGMDCDEKEG, int GBFKFLAFFMD, string? HBOONHFLONJ, string? NNOOJPFBHGL, IJNKGDNCJLA EEJDENEMAKH, List<CGDNFBGOLIE>? DHEPNPNIKNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[PLAFBFJHEAK]
internal class PPBHKCENEMO : BBNLKLPNEAG<CCHKDPCEGOP, OGHEBKGCIPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly BDGAMALNPBH HMALHDFPOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly JPPAGGIFDJP LJDLJMFGOCH;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D5E0", Offset = "0x6A8BFE0", VA = "0x186A8D5E0")]
	public PPBHKCENEMO(NLJFGCALLNJ HCPJBBGPJMP, BDGAMALNPBH HMALHDFPOKM, GFEMHOFJCGN OOBEMKODKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D340", Offset = "0x6A8BD40", VA = "0x186A8D340", Slot = "6")]
	public override OGHEBKGCIPF ILDFGHALABA(CCHKDPCEGOP DKDIADEJLHP, [Out] IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class PODIGBNIHAC : NLJFGCALLNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FCABCKOFJEK : JsonConverter<FKKPIHEJPIN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6A84A10", Offset = "0x6A83410", VA = "0x186A84A10", Slot = "9")]
		public override void WriteJson(JsonWriter GMONMLMLDAL, FKKPIHEJPIN? CLMKDBDPNNH, JsonSerializer OGEGPBNNHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6A848F0", Offset = "0x6A832F0", VA = "0x186A848F0", Slot = "10")]
		public override FKKPIHEJPIN ReadJson(JsonReader PHJKOICFNBE, Type BBECINDKAEL, FKKPIHEJPIN? EJIOFLPOHJP, bool BLBBKLAFMIH, JsonSerializer OGEGPBNNHOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6A84AB0", Offset = "0x6A834B0", VA = "0x186A84AB0")]
		public FCABCKOFJEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class PGHOEGAKHKI : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool POOHHKEACPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D0A0", Offset = "0x6A8BAA0", VA = "0x186A8D0A0", Slot = "5")]
		public override object ReadJson(JsonReader PHJKOICFNBE, Type BBECINDKAEL, object? EJIOFLPOHJP, JsonSerializer OGEGPBNNHOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CEC0", Offset = "0x6A8B8C0", VA = "0x186A8CEC0", Slot = "6")]
		public override bool CanConvert(Type BBECINDKAEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D100", Offset = "0x6A8BB00", VA = "0x186A8D100", Slot = "4")]
		public override void WriteJson(JsonWriter GMONMLMLDAL, object? CLMKDBDPNNH, JsonSerializer OGEGPBNNHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CCC0", Offset = "0x6A8B6C0", VA = "0x186A8CCC0")]
		private static bool ADCLFOMHLEF(object CLMKDBDPNNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public PGHOEGAKHKI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly JsonSerializerSettings HOCCJLPDDCN;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D1E0", Offset = "0x6A8BBE0", VA = "0x186A8D1E0")]
	internal PODIGBNIHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2E51860", Offset = "0x2E50260", VA = "0x182E51860", Slot = "4")]
	public string JFLIPPKEGIH<T>(T GIGIFGONEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2E518C0", Offset = "0x2E502C0", VA = "0x182E518C0", Slot = "5")]
	public T OCBBLKCGPHA<T>(string CLMKDBDPNNH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[RecRoom.NoEngine.Common.Preserve]
internal class LBKHKECEFDO : NLJFGCALLNJ
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2D389E0", Offset = "0x2D373E0", VA = "0x182D389E0", Slot = "4")]
	public string JFLIPPKEGIH<T>(T GIGIFGONEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2D38A60", Offset = "0x2D37460", VA = "0x182D38A60", Slot = "5")]
	public T OCBBLKCGPHA<T>(string CLMKDBDPNNH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public LBKHKECEFDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[PLAFBFJHEAK]
internal class JPPAGGIFDJP : BBNLKLPNEAG<HHPMELGLIIA, EJNDBNBBEPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly NLJFGCALLNJ HCPJBBGPJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private readonly BDGAMALNPBH HMALHDFPOKM;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C4C0", Offset = "0x6A8AEC0", VA = "0x186A8C4C0")]
	public JPPAGGIFDJP(NLJFGCALLNJ HCPJBBGPJMP, BDGAMALNPBH HMALHDFPOKM, GFEMHOFJCGN OOBEMKODKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BBE0", Offset = "0x6A8A5E0", VA = "0x186A8BBE0", Slot = "6")]
	public override EJNDBNBBEPK ILDFGHALABA(HHPMELGLIIA DKDIADEJLHP, [Out] IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C200", Offset = "0x6A8AC00", VA = "0x186A8C200")]
	internal void MLEOFEONHAP(string AMAIPMGJHLP, OGHEBKGCIPF OCPNBFGAMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6A8AA50", Offset = "0x6A89450", VA = "0x186A8AA50")]
	public IEnumerable<GJJDGJFKAMA> CLGIKMLCLFK(string CADANDGPAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6A8AF50", Offset = "0x6A89950", VA = "0x186A8AF50")]
	private IEnumerable<GJJDGJFKAMA> EHDDKBDDGEH(string CADANDGPAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6A8AB00", Offset = "0x6A89500", VA = "0x186A8AB00")]
	internal IEnumerable<GJJDGJFKAMA> DEGKMMENENM(string CADANDGPAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6A8A3D0", Offset = "0x6A88DD0", VA = "0x186A8A3D0")]
	private GJJDGJFKAMA ADOOGLJOOBP(AvatarOutfitSelectionData BEMEPDCNOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6A8B360", Offset = "0x6A89D60", VA = "0x186A8B360")]
	private void HCFNOHAEBNC(AvatarCustomizationSettingsData IENCGHJJGMD, OGHEBKGCIPF OCPNBFGAMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6A8A0C0", Offset = "0x6A88AC0", VA = "0x186A8A0C0")]
	private GJJDGJFKAMA ADOOGLJOOBP(string PKOCCIGGLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8A750", Offset = "0x6A89150", VA = "0x186A8A750")]
	internal static (PLGDACFFJCI, string, string) APOFKJABMLK(string PKOCCIGGLGN, GFEMHOFJCGN OOBEMKODKLN)
	{
		return default((PLGDACFFJCI, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C000", Offset = "0x6A8AA00", VA = "0x186A8C000")]
	private PFMNAIAGGDI? JHJNCMMFLCF(string? HLIKNGLOMIK, Vector2 NIGFOLDLBHO, float NKPOHMELKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C360", Offset = "0x6A8AD60", VA = "0x186A8C360")]
	private static IDDKLPOMBMA PGBAEEABCFC(AvatarCustomizationSettingsData.AnchorParams OBHDJFMCMPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[PLAFBFJHEAK]
internal class ECGNMNJODNM : JOBEIANNHHC, PGCNPBAMDAC
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6A84770", Offset = "0x6A83170", VA = "0x186A84770")]
	public ECGNMNJODNM(NLJFGCALLNJ HCPJBBGPJMP, BDGAMALNPBH HMALHDFPOKM, GFEMHOFJCGN OOBEMKODKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6A843C0", Offset = "0x6A82DC0", VA = "0x186A843C0", Slot = "4")]
	public BEHKGJEOEJH LKLOMDOAOHF(OGHEBKGCIPF OIGMDCDEKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6A842C0", Offset = "0x6A82CC0", VA = "0x186A842C0")]
	private string JOLEGOFCLOP(OGHEBKGCIPF OCPNBFGAMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6A84080", Offset = "0x6A82A80", VA = "0x186A84080")]
	private string AEBJKNIPPKD(GJJDGJFKAMA NBBMGDELGDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[PLAFBFJHEAK]
internal class GMJNHPCDPIN : BBNLKLPNEAG<HHPMELGLIIA, EJNDBNBBEPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly NLJFGCALLNJ HCPJBBGPJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly IFDAFPNLJEK<HHPMELGLIIA, EJNDBNBBEPK> JHEMILIFKEJ;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6A858F0", Offset = "0x6A842F0", VA = "0x186A858F0")]
	public GMJNHPCDPIN(IFDAFPNLJEK<HHPMELGLIIA, EJNDBNBBEPK> JHEMILIFKEJ, GFEMHOFJCGN OOBEMKODKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6A854D0", Offset = "0x6A83ED0", VA = "0x186A854D0", Slot = "6")]
	public override EJNDBNBBEPK ILDFGHALABA(HHPMELGLIIA DKDIADEJLHP, [Out] IReadOnlyList<CGDNFBGOLIE>? DHEPNPNIKNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PLAFBFJHEAK]
internal class FCGNOGCFCAD : BCHDILIKMIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly NLJFGCALLNJ HCPJBBGPJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly PGCNPBAMDAC FPCJFEECGMF;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6A84E90", Offset = "0x6A83890", VA = "0x186A84E90")]
	public FCGNOGCFCAD(PGCNPBAMDAC FPCJFEECGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6A84AF0", Offset = "0x6A834F0", VA = "0x186A84AF0", Slot = "4")]
	public HHPMELGLIIA LKLOMDOAOHF(OGHEBKGCIPF OIGMDCDEKEG, int GBFKFLAFFMD, string? HBOONHFLONJ, string? NNOOJPFBHGL, IJNKGDNCJLA EEJDENEMAKH, List<CGDNFBGOLIE>? DHEPNPNIKNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[RecRoom.NoEngine.Common.Preserve]
internal class HCDBPDGCGMP : PPBEGIKPOCE
{
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly Vector2 HPNEGBDBGGL;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly Vector2 OMDBLMBBKME;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly Vector2 DEOBEFDJJLO;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly Vector2 GIADAKIDFMI;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly Vector2 LJFNNJBBCEM;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly Vector2 GCFJFCMBOFL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly Vector2 GFLJFFPKEOO;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly Vector2 MIEBDGDNFHE;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly Vector2 BJIIHJGNHAC;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly Vector2 DGDANABBCCI;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 OFAJAPFIPBK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 CHGBBFOAEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private readonly Dictionary<LJIAAKKJMFC, AvatarConfiguration> ABLDOHPJIKK;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6A87970", Offset = "0x6A86370", VA = "0x186A87970")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void OFOANFKDEIC(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6A87C40", Offset = "0x6A86640", VA = "0x186A87C40")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HCDBPDGCGMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6A86FF0", Offset = "0x6A859F0", VA = "0x186A86FF0", Slot = "4")]
	public Vector2 KNLBIIANLAM(FaceFeatureType AFLFJPOGOMJ, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6A86E40", Offset = "0x6A85840", VA = "0x186A86E40", Slot = "5")]
	public float INKHONIBFDK(FaceFeatureType AFLFJPOGOMJ, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6A874E0", Offset = "0x6A85EE0", VA = "0x186A874E0", Slot = "6")]
	public void LAMJGOPGLEA(LJIAAKKJMFC OGHNIOCONDA, AvatarConfiguration ALLBDHOEBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6A87550", Offset = "0x6A85F50", VA = "0x186A87550", Slot = "7")]
	public void LOILMBKFHAO(LAKMAGKELAJ OMFPDPBPIPM, AvatarConfiguration IICOAALEPOB, LJIAAKKJMFC FNIGPJOCLMC, LJIAAKKJMFC HKKEKAJCMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6A86BE0", Offset = "0x6A855E0", VA = "0x186A86BE0", Slot = "8")]
	public float IFHICLCINKK(FaceFeatureType CCDECPBNDJK, float LDNIDGKHECH, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6A86650", Offset = "0x6A85050", VA = "0x186A86650", Slot = "9")]
	public float GDCHIHKIBIJ(FaceFeatureType CCDECPBNDJK, float NKPOHMELKHL, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A86960", Offset = "0x6A85360", VA = "0x186A86960", Slot = "11")]
	public Vector2 IAMODCMMBKA(FaceFeatureType CCDECPBNDJK, Vector2 NEOEJHMBGMN, Vector2 DHKCLLNBKMB, Vector2 EMMMLBPBNPH, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6A86C10", Offset = "0x6A85610", VA = "0x186A86C10", Slot = "10")]
	public Vector2 IMGLGHODGIG(FaceFeatureType CCDECPBNDJK, Vector2 BGIIONJGOMH, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6A87800", Offset = "0x6A86200", VA = "0x186A87800")]
	private Vector2 NPNLJBALMMD(FaceFeatureType CCDECPBNDJK, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6A876B0", Offset = "0x6A860B0", VA = "0x186A876B0")]
	private Vector2 NLMHFCEKMCO(FaceFeatureType CCDECPBNDJK, Vector2 NEOEJHMBGMN, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6A87150", Offset = "0x6A85B50", VA = "0x186A87150", Slot = "12")]
	public Vector2 KNOOIBBMNIE(FaceFeatureType CCDECPBNDJK, Vector2 BGIIONJGOMH, Vector2 DHKCLLNBKMB, Vector2 EMMMLBPBNPH, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6A86080", Offset = "0x6A84A80", VA = "0x186A86080")]
	private float CIHHBAKJKFN(float NLBIFNGGFFK, float AAGMKEOFFOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6A86820", Offset = "0x6A85220", VA = "0x186A86820")]
	private Vector2 HCMKFPANDPD(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6A86F70", Offset = "0x6A85970", VA = "0x186A86F70")]
	private Vector2 JMIAFJEMJLA(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6A865D0", Offset = "0x6A84FD0", VA = "0x186A865D0")]
	private Vector2 GCHBKMBBEKM(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A868E0", Offset = "0x6A852E0", VA = "0x186A868E0")]
	private Vector2 HOOCCNDAIFH(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A86040", Offset = "0x6A84A40", VA = "0x186A86040")]
	private float CHMILIFIGBD(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A868A0", Offset = "0x6A852A0", VA = "0x186A868A0")]
	private float HLMLLHAKMOK(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A87A20", Offset = "0x6A86420", VA = "0x186A87A20")]
	private float PFOFEJAGNNP(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A879E0", Offset = "0x6A863E0", VA = "0x186A879E0")]
	private float PEEOKGBCCLO(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A86B10", Offset = "0x6A85510", VA = "0x186A86B10")]
	private Vector2 IBIFIAPLIEJ(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A86500", Offset = "0x6A84F00", VA = "0x186A86500")]
	private Vector2 FHJMBBKLAKM(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A878A0", Offset = "0x6A862A0", VA = "0x186A878A0")]
	private Vector2 ODPLFJNHFJE(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A86750", Offset = "0x6A85150", VA = "0x186A86750")]
	private Vector2 HCCNMGMKINN(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A86430", Offset = "0x6A84E30", VA = "0x186A86430")]
	private Vector2 EIPEDADJKGK(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A86360", Offset = "0x6A84D60", VA = "0x186A86360")]
	private Vector2 DKBEGBJHALN(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A86680", Offset = "0x6A85080", VA = "0x186A86680")]
	private Vector2 GIBPFHGILLE(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A861C0", Offset = "0x6A84BC0", VA = "0x186A861C0")]
	private Vector2 CPCLJHHLNII(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A86290", Offset = "0x6A84C90", VA = "0x186A86290")]
	private Vector2 DEDOABHPCEE(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A86EC0", Offset = "0x6A858C0", VA = "0x186A86EC0")]
	private Vector2 JHPBOILDNBB(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A87600", Offset = "0x6A86000", VA = "0x186A87600")]
	private Vector2 NEFPBAKFFEL(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A86110", Offset = "0x6A84B10", VA = "0x186A86110")]
	private Vector2 COKALHCKCFP(LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A80FF0", Offset = "0x6A7F9F0", VA = "0x186A80FF0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LGGGFLGDLHL
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C660", Offset = "0x6A8B060", VA = "0x186A8C660")]
	public static AHDCONECEDL ILDFGHALABA(this EOFNPPDPLOA OIGMDCDEKEG)
	{
		return default(AHDCONECEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C7D0", Offset = "0x6A8B1D0", VA = "0x186A8C7D0")]
	public static EOFNPPDPLOA LKLOMDOAOHF(this AHDCONECEDL MEOKACMLMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C770", Offset = "0x6A8B170", VA = "0x186A8C770")]
	public static bool KJKIPJOHNNO(this AHDCONECEDL MEOKACMLMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C600", Offset = "0x6A8B000", VA = "0x186A8C600")]
	public static bool EKCDJMLHOEB(this AHDCONECEDL MEOKACMLMHJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x4E87950", Offset = "0x4E86350", VA = "0x184E87950")]
			public AnchorParams(Vector2 NEOEJHMBGMN, Vector3 NFMBDHKIAGH, Vector3 MAICEANCLKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x6A80F40", Offset = "0x6A7F940", VA = "0x186A80F40")]
			internal IDDKLPOMBMA LKLOMDOAOHF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private OHGEMMOAKLG useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x6A817D0", Offset = "0x6A801D0", VA = "0x186A817D0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x885AE0", Offset = "0x8844E0", VA = "0x180885AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3E12C30", Offset = "0x3E11630", VA = "0x183E12C30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x120D590", Offset = "0x120BF90", VA = "0x18120D590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x923030", Offset = "0x921A30", VA = "0x180923030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xB61FB0", Offset = "0xB609B0", VA = "0x180B61FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x6A81870", Offset = "0x6A80270", VA = "0x186A81870")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x886970", Offset = "0x885370", VA = "0x180886970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x9ECD30", Offset = "0x9EB730", VA = "0x1809ECD30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x12300C0", Offset = "0x122EAC0", VA = "0x1812300C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x88C840", Offset = "0x88B240", VA = "0x18088C840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x6A818B0", Offset = "0x6A802B0", VA = "0x186A818B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1EF4DD0", Offset = "0x1EF37D0", VA = "0x181EF4DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2B0", Offset = "0xA3CCB0", VA = "0x180A3E2B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1028060", Offset = "0x1026A60", VA = "0x181028060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x885FE0", Offset = "0x8849E0", VA = "0x180885FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x886030", Offset = "0x884A30", VA = "0x180886030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x42B9890", Offset = "0x42B8290", VA = "0x1842B9890")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1EF9CC0", Offset = "0x1EF86C0", VA = "0x181EF9CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B8D70", VA = "0x1808BA370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3D0", Offset = "0x8B8DD0", VA = "0x1808BA3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x88C870", Offset = "0x88B270", VA = "0x18088C870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x88C8A0", Offset = "0x88B2A0", VA = "0x18088C8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x88C880", Offset = "0x88B280", VA = "0x18088C880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x88C860", Offset = "0x88B260", VA = "0x18088C860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x88C900", Offset = "0x88B300", VA = "0x18088C900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x88C740", Offset = "0x88B140", VA = "0x18088C740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x92DDE0", Offset = "0x92C7E0", VA = "0x18092DDE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xC84C10", Offset = "0xC83610", VA = "0x180C84C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x88C8E0", Offset = "0x88B2E0", VA = "0x18088C8E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x88C8C0", Offset = "0x88B2C0", VA = "0x18088C8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x93A510", Offset = "0x938F10", VA = "0x18093A510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xB7A020", Offset = "0xB78A20", VA = "0x180B7A020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x888340", Offset = "0x886D40", VA = "0x180888340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8882D0", Offset = "0x886CD0", VA = "0x1808882D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xA38CD0", Offset = "0xA376D0", VA = "0x180A38CD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16550", VA = "0x180D17B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xB93B60", Offset = "0xB92560", VA = "0x180B93B60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xEB09F0", Offset = "0xEAF3F0", VA = "0x180EB09F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public OHGEMMOAKLG UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x92A700", Offset = "0x929100", VA = "0x18092A700")]
			get
			{
				return default(OHGEMMOAKLG);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x92B330", Offset = "0x929D30", VA = "0x18092B330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x92B5D0", Offset = "0x929FD0", VA = "0x18092B5D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x92C140", Offset = "0x92AB40", VA = "0x18092C140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6A81890", Offset = "0x6A80290", VA = "0x186A81890")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6A818D0", Offset = "0x6A802D0", VA = "0x186A818D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A81470", Offset = "0x6A7FE70", VA = "0x186A81470")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public PLGDACFFJCI BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private MKALFOKDGKE? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6A83970", Offset = "0x6A82370", VA = "0x186A83970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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
