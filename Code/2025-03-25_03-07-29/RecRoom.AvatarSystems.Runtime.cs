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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x76D7FF0", Offset = "0x76D73F0", VA = "0x1876D7FF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
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
		[Cpp2IlInjected.Address(RVA = "0x76D8070", Offset = "0x76D7470", VA = "0x1876D8070", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NGHELBGCMPC]
internal class IHACPDAOHAE : KBKCJKPDDEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MHJJKDABKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public IHACPDAOHAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public HBFPFNMMLAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CGNBBJEKFFI JMJCNNNNKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PGJLEIPCBNJ PECFCEMCLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NKLMCHAGBIN PAENCDHCMNN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x76D7010", Offset = "0x76D6410", VA = "0x1876D7010")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	[UsedImplicitly]
	internal static void FKEEGBEBDLF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x76D7E70", Offset = "0x76D7270", VA = "0x1876D7E70")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IHACPDAOHAE([GKAMHFFOHNI(null)] CGNBBJEKFFI JMJCNNNNKOO, [GKAMHFFOHNI(null)] PGJLEIPCBNJ PECFCEMCLKO, [GKAMHFFOHNI(null)] NKLMCHAGBIN PAENCDHCMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76D75B0", Offset = "0x76D69B0", VA = "0x1876D75B0", Slot = "5")]
	public FNHNCLCJBFE PDILJGNPAEB(HBFPFNMMLAG IKONFHFIDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76D6420", Offset = "0x76D5820", VA = "0x1876D6420", Slot = "4")]
	public FNHNCLCJBFE DGCFLJJBKGI(HBFPFNMMLAG IKONFHFIDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76D72F0", Offset = "0x76D66F0", VA = "0x1876D72F0", Slot = "6")]
	public JFEJACCGDHB LFOGDDHIHKM(FNHNCLCJBFE AMHCLKHIFKH, int LEGHOJDPODF, string? MPGDCPPMNJN, string? BDFLCOMLHMK, LILABGCADKK CDPMNKIKIKJ, List<BGOGBDBFPOI>? LIONHABEEGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76D6F80", Offset = "0x76D6380", VA = "0x1876D6F80", Slot = "7")]
	public bool DGOOFFFLGOP(LIOOIDGKCHN LBHOBFIOFPC, [Out] FNHNCLCJBFE? ADDEPKOGHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76D6340", Offset = "0x76D5740", VA = "0x1876D6340", Slot = "8")]
	public bool CBKOBJAODPF(JFEJACCGDHB OFFCEDBBBPH, [Out] FNHNCLCJBFE? ADDEPKOGHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x76D7260", Offset = "0x76D6660", VA = "0x1876D7260", Slot = "9")]
	public bool KKDKGCBAJHG(JFEJACCGDHB OFFCEDBBBPH, [Out] EFPGMKHCLPM? LBHOBFIOFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3658820", Offset = "0x3657C20", VA = "0x183658820")]
	private bool NDPCGJDFJEN<TInput, TOutput>(TInput BEAPIEHNNIB, AKMOONNIJPG<TInput, TOutput> EGNJDGMBFEM, [Out] TOutput? KGODHHBLJOE) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76D7400", Offset = "0x76D6800", VA = "0x1876D7400")]
	[CompilerGenerated]
	private IGPGFFDNKNG NALBOOCIMIK(FaceFeatureType GLHIEONCNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x76D7080", Offset = "0x76D6480", VA = "0x1876D7080")]
	[CompilerGenerated]
	private IGPGFFDNKNG JFFHEBKNNDH(FaceFeatureType GLHIEONCNME, MHJJKDABKDK P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NGHELBGCMPC]
internal class EDAFJNMOGBP : CGNBBJEKFFI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void NFBDBCBBFLI<in TData>(TData ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NKLMCHAGBIN PAENCDHCMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FEHNCHIDFDG EJEHNGBDFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NFBDBCBBFLI<FNHNCLCJBFE>?[] JMJCNNNNKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NFBDBCBBFLI<EFPGMKHCLPM>?[] JICHIHAJOPH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76D4D80", Offset = "0x76D4180", VA = "0x1876D4D80")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	[UsedImplicitly]
	internal static void FKEEGBEBDLF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x76D5DE0", Offset = "0x76D51E0", VA = "0x1876D5DE0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EDAFJNMOGBP([GKAMHFFOHNI(null)] NKLMCHAGBIN PAENCDHCMNN, [GKAMHFFOHNI(null)] FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x76D4DF0", Offset = "0x76D41F0", VA = "0x1876D4DF0", Slot = "4")]
	public bool KDLPGPJPMNK(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x76D4EF0", Offset = "0x76D42F0", VA = "0x1876D4EF0", Slot = "5")]
	public bool KDLPGPJPMNK(EFPGMKHCLPM LBHOBFIOFPC, IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x76D5050", Offset = "0x76D4450", VA = "0x1876D5050")]
	private void MLOPALMEMMG(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? OICAMEEFOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x76D4B50", Offset = "0x76D3F50", VA = "0x1876D4B50")]
	private void CEIKDFJFHJC(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? OICAMEEFOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76D4A70", Offset = "0x76D3E70", VA = "0x1876D4A70")]
	private void AODFIBKJLDC(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? OICAMEEFOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x76D5DB0", Offset = "0x76D51B0", VA = "0x1876D5DB0")]
	private void POPGMPDOINB(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? OICAMEEFOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76D5CE0", Offset = "0x76D50E0", VA = "0x1876D5CE0")]
	private void OBHKMEPHKGA(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? OICAMEEFOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x76D4AA0", Offset = "0x76D3EA0", VA = "0x1876D4AA0")]
	private void BNEIDGCHICM(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? OICAMEEFOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x76D5C30", Offset = "0x76D5030", VA = "0x1876D5C30")]
	private void NAOOJHHDFFI(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? OICAMEEFOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CGNBBJEKFFI
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDLPGPJPMNK(FNHNCLCJBFE ADDEPKOGHPN, IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KDLPGPJPMNK(EFPGMKHCLPM LBHOBFIOFPC, IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC);
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
		public MOANJLFHLFG AnimationPoseType;

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

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76B8990", Offset = "0x76B7D90", VA = "0x1876B8990")]
		public void ACNLPMFFOJP(AnimationPoseSetting JAPIEEBOJEA, float CMAOGCHLNOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x76B8AC0", Offset = "0x76B7EC0", VA = "0x1876B8AC0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76B93B0", Offset = "0x76B87B0", VA = "0x1876B93B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x76B9370", Offset = "0x76B8770", VA = "0x1876B9370")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x76B8AE0", Offset = "0x76B7EE0", VA = "0x1876B8AE0")]
		private void GMDOJMDGPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7648A70", Offset = "0x7647E70", VA = "0x187648A70", Slot = "4")]
		public void SetEnabled(bool EJBJKNOIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76B93E0", Offset = "0x76B87E0", VA = "0x1876B93E0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x76B9420", Offset = "0x76B8820", VA = "0x1876B9420")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D9")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x464")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A4")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Local offset from pelvis to foot center")]
		[Header("Shoe Settings")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4CC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76B94A0", Offset = "0x76B88A0", VA = "0x1876B94A0")]
		public AnimationPoseSetting CAICLCKLOHK(MOANJLFHLFG MOKKKEBMDDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x76B9460", Offset = "0x76B8860", VA = "0x1876B9460")]
		public void AEJOPFDILPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x76B94D0", Offset = "0x76B88D0", VA = "0x1876B94D0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum HIDAONKLBOF
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private HIDAONKLBOF handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76B9F80", Offset = "0x76B9380", VA = "0x1876B9F80")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76B9F40", Offset = "0x76B9340", VA = "0x1876B9F40")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x76B9940", Offset = "0x76B8D40", VA = "0x1876B9940")]
		private void GMDOJMDGPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7648A70", Offset = "0x7647E70", VA = "0x187648A70", Slot = "4")]
		public void SetEnabled(bool EJBJKNOIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76B9FB0", Offset = "0x76B93B0", VA = "0x1876B9FB0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, HFAJMILAENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Header("Configuration")]
		private HBFPFNMMLAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		[Header("Configuration")]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		[Header("Facial Animation")]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[FormerlySerializedAs("HeadTweakBone")]
		[SerializeField]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private EPJPNNGGJPH AGNCKANOCKA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EPJPNNGGJPH JJMNMPFBCMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA17730", Offset = "0xA16B30", VA = "0x180A17730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform HGDMMGDIIMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x76BADA0", Offset = "0x76BA1A0", VA = "0x1876BADA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x76B9FE0", Offset = "0x76B93E0", VA = "0x1876B9FE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x76BAC60", Offset = "0x76BA060", VA = "0x1876BAC60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76BAC10", Offset = "0x76BA010", VA = "0x1876BAC10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x76BABA0", Offset = "0x76B9FA0", VA = "0x1876BABA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x76B9FE0", Offset = "0x76B93E0", VA = "0x1876B9FE0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76BA370", Offset = "0x76B9770", VA = "0x1876BA370", Slot = "6")]
		public EPJPNNGGJPH CreateAvatarSystem(string CENGONCPBJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76BABA0", Offset = "0x76B9FA0", VA = "0x1876BABA0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x76BA0A0", Offset = "0x76B94A0", VA = "0x1876BA0A0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76BACB0", Offset = "0x76BA0B0", VA = "0x1876BACB0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float NFEBFCGCNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class BFFEOMPDIAI : EPJPNNGGJPH
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class LLMNCLBHCKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 LNKBINJCLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Quaternion NAKLHIHLDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 OIMBDFJLJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Transform BPCAHLLINPK;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 NFOHEDOGNDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x1D97B30", Offset = "0x1D96F30", VA = "0x181D97B30")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1D97B50", Offset = "0x1D96F50", VA = "0x181D97B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion LJGDKBKOBGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1254DC0", Offset = "0x12541C0", VA = "0x181254DC0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x1254DD0", Offset = "0x12541D0", VA = "0x181254DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float KPPFDCMFHFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xFAB4F0", Offset = "0xFAA8F0", VA = "0x180FAB4F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x15FC1C0", Offset = "0x15FB5C0", VA = "0x1815FC1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool LINGCBKLMAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x9933C0", Offset = "0x9927C0", VA = "0x1809933C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9933B0", Offset = "0x9927B0", VA = "0x1809933B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool LKODOILBPBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x993470", Offset = "0x992870", VA = "0x180993470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x993440", Offset = "0x992840", VA = "0x180993440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool FPAFIDGOIBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x993570", Offset = "0x992970", VA = "0x180993570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x993420", Offset = "0x992820", VA = "0x180993420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float AGAONJKOGED
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xBD2F80", Offset = "0xBD2380", VA = "0x180BD2F80")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBD3C10", Offset = "0xBD3010", VA = "0x180BD3C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x76E0050", Offset = "0x76DF450", VA = "0x1876E0050")]
		public void FBGPMJHGIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x76DFEF0", Offset = "0x76DF2F0", VA = "0x1876DFEF0")]
		public void DDIEPHJPOHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x76E0060", Offset = "0x76DF460", VA = "0x1876E0060")]
		public float HCMECFDILDA(Vector3 CABMADKPIBO, Quaternion DJIFGKAOHFF, [In] AvatarFootSettings NINJNCIGBHB, float EHBOILEJKPP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x76E0270", Offset = "0x76DF670", VA = "0x1876E0270")]
		public void HFKCFCPDBBD(Vector3 LBHLGCEPFLP, Quaternion BPBLBFBBIEE, Transform FBAEIHDPING, float NDJMCIAKPAP, bool NIJMCAGGJAD, bool FJJIIDGIEPG, float EDBADBOBKPK, float LDKCNFNEKKK, Transform FDNIDHBNFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x76E0A40", Offset = "0x76DFE40", VA = "0x1876E0A40")]
		public void PPEGDCDMAHL(Transform KLHLCMAODCJ, Transform FDNIDHBNFHE, bool MLBAFCMNFMF, bool ANJIJJLDGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x76E0940", Offset = "0x76DFD40", VA = "0x1876E0940")]
		private void LJLLLNPOLNE(Transform FDNIDHBNFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x76DFF00", Offset = "0x76DF300", VA = "0x1876DFF00")]
		public void DPFHAGAELHB(Transform FDNIDHBNFHE, AvatarFullBodyConfiguration EOPBDJJHJJL, Vector3 KPKFKLFCNCI, float PKLHHHMGKOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x76DFED0", Offset = "0x76DF2D0", VA = "0x1876DFED0")]
		public void COMMGANILOO(float LDKCNFNEKKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76E0C70", Offset = "0x76E0070", VA = "0x1876E0C70")]
		public LLMNCLBHCKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class NDHCAJACLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float MEIMBFIDBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool IHJDNMMIKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AnimationPoseSetting BGDMIECIOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private float HJCINFKFECG;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x76E22F0", Offset = "0x76E16F0", VA = "0x1876E22F0")]
		public void PCEADKJJBFK(IKSolverVR.Arm APBJKIIFJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76E22B0", Offset = "0x76E16B0", VA = "0x1876E22B0")]
		public void LHOOJIPKMGH(IKSolverVR.Arm APBJKIIFJJI, float BKKMOKHEJGP, bool IHJDNMMIKLM, AvatarFullBodyConfiguration EOPBDJJHJJL, float OKHHGFLPPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x76E1B10", Offset = "0x76E0F10", VA = "0x1876E1B10")]
		private void ELOLEBPCOLC(IKSolverVR.Arm APBJKIIFJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x76E1290", Offset = "0x76E0690", VA = "0x1876E1290")]
		public void DFPICFADAHO(IKSolverVR.Arm APBJKIIFJJI, Transform NHCGKBKDELL, Transform FBAEIHDPING, Quaternion LLLAMNNFGHA, Vector3 EDDJBONKNAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x76E0E00", Offset = "0x76E0200", VA = "0x1876E0E00")]
		private (Vector3, Quaternion) CNNDLEADFLG(CPCOOJBNCJC GPLNPBEEMBP, Quaternion CNOMKPOHKOC, Vector3 IDCJHOLBBIA)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x76E2150", Offset = "0x76E1550", VA = "0x1876E2150")]
		public void HPFJPEGLFKA(CPCOOJBNCJC GPLNPBEEMBP, IKSolverVR.Arm APBJKIIFJJI, Quaternion CNOMKPOHKOC, Vector3 IDCJHOLBBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x76E1B50", Offset = "0x76E0F50", VA = "0x1876E1B50")]
		public void FMFBBKOEDIJ(CPCOOJBNCJC GPLNPBEEMBP, IKSolverVR.Arm APBJKIIFJJI, Quaternion CNOMKPOHKOC, Vector3 IDCJHOLBBIA, [In] AvatarFullBodyConfiguration EOPBDJJHJJL, [In] DGLPCLEHFNH FBOKGPFKJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x76E2320", Offset = "0x76E1720", VA = "0x1876E2320")]
		public void PCPCFKOHOBF(MOANJLFHLFG JCGEMCKEKBM, AvatarFullBodyConfiguration EOPBDJJHJJL, DGLPCLEHFNH FBOKGPFKJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x76E1670", Offset = "0x76E0A70", VA = "0x1876E1670")]
		public void DHGNOJFLHJH(IKSolverVR.Arm APBJKIIFJJI, Transform NHCGKBKDELL, Vector3 BJNGOLDHMLM, float OCHCHODPOEB, Quaternion FJLKPJIECLN, Vector3 CHPLLMJGOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76E2460", Offset = "0x76E1860", VA = "0x1876E2460")]
		public NDHCAJACLNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum KPJDDBMAPDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct JFFHJNDKFGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HMPAJMHBKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int ELHEMDBGKKL;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int BGGDGEFDHKA;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int KECEANGFKKK;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int GODKIFMJLMB;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int IDGOJLDFFBI;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int JNFFCJJLDNO;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int MOCPECBMIOK;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int PFPLOFIJPBG;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int KIIJBJGEKPO;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int BMLEDPBLFLL;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int BFJNOAMMODE;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int LPEMMEADPCC;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int HEOPDIKAOMO;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int KFLBJGCFJIB;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int IALKEDOGKCN;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int DCGNBHDJJDC;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int MOKEHKDJBPF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int ILGKIKMNHML;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int KPMKEABOOFP;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int PHCLNDBFLMJ;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int PLBCBLHACDE;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int BEALHHOKGME;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int DAFGLHHGBHG;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int GPGONDHODPO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int KMGBANOBHPI;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int JLEHBFIBKPH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int FNEHOMMLOFB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int BMFDLDEOHPD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int PCLAABDAGPE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int INEDKDLOJPG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int HBHCBEFCLBH;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly Vector3 JJBGHEIOAJN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int OCJPPBKCIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool DCDNFDIBFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool APILMHOMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool OCIHOBINFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool BMBECDLMMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool BHBMOJCMAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool NBMMIODKMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Vector3 PLEMBKEFPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private string PMGLAFAMOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PNBIBLHAPIF? HPDPDDMPGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private BCGILGFMGGA? BGCKMDEEGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private OOHHGFPAPOG MEKAEBHNCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private OJAIEMLEGJG KGDDNBHNCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private CPCOOJBNCJC OLMHDGPJCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private CPCOOJBNCJC KDKLFFPDPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool EHPFIFLINLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool HBKKMHKMCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly FHCDIBPNOOO BPBEEHGHJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly FGNIBCMLPCK MMDJEBMAPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int ODAKLKKPAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private float AGAGHJBJMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GameObject NPNAJGGCAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform AGNANKAAPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform PBBMDHPEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform GIBGGNJKKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform KHNALLFCKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float AAGMNFOHFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float PMBODFAJMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 AAMNPNHADNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Quaternion ONHPKOCHKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform OBHDNKNKMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform BAPFNJGPFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform KDDPEMGDNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private KOFBGIAMJEJ LKPGPGJBCFJ;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker ABGKAGIBFCO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker GLPAEDJFAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ProfilerMarker KHEHEKIMDAO;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker FIFDBOLHGLJ;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker AOGKACEDAIB;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker CAPDCOCDBNN;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly List<BFFEOMPDIAI> OFMMHPFHJFJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int FDBPOPGMBPK;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> OEHKBOAGLFH;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static int LIHPKIMBGDA;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int AHGFFDBAKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int HOPGCPJIBBJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int AILBNMDHOHC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float EFMCLLENGIL;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int GHLBNJLGPOB;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static float CMJDPPEFNCF;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float KLGKEGBDDHD;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float PPOPFDBLPBF;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float GMHBDOOMFDM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static KBCPABJHIIH FCMMHCPLJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float DPOBEHLHCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool KLENFNKFAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float FNAAGIECMDB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly int LBODCEEGJIG;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly int CIKEBMNGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private LLMNCLBHCKJ COBCPBBMJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private LLMNCLBHCKJ LIPDLGMHGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float AGNLKKDABME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Vector3 EFOJPKPDCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Vector3 BHOOLIIEFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private bool JKNHJLICHND;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly Quaternion NCEAKLPHAID;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly Quaternion MODKMJDGFCJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly Vector3 KHHIFCCLDGD;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Vector3 EPAFFBOPIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float DAOJMGEHKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float LCANPGLDPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NDHCAJACLNI AADLLGMGEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NDHCAJACLNI CKGNJHFNPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private JJMEDDFBDFG DGEBLPBHLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private JHABKDLIALD CJIFIEDFFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly FLCNENIGCAB FPLKHKELNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float CJIGEHFOJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float MEDOMOPMGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly JHABKDLIALD PGFIMGPCFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Vector3 CFOMCABGCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 IKBBFMNBPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float HIBCFIDPAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float IMIPOLDPCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly JHABKDLIALD GDJLBMACHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly JJMEDDFBDFG HMACBGCDFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly JHABKDLIALD DHKNMIOOPCK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OLDENIALAEA JCMGINHANFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OLDENIALAEA MIEHBFELIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration NACCBFNCPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x76C3C50", Offset = "0x76C3050", VA = "0x1876C3C50", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HBFPFNMMLAG PMPLAAMDBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x76C4350", Offset = "0x76C3750", VA = "0x1876C4350", Slot = "23")]
		get
		{
			return default(HBFPFNMMLAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration CELFCNIHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x76C4BD0", Offset = "0x76C3FD0", VA = "0x1876C4BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform HICIMMBNNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76CF540", Offset = "0x76CE940", VA = "0x1876CF540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform DIOLOECKANB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x76BB5C0", Offset = "0x76BA9C0", VA = "0x1876BB5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer LPDBAPKFMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76D37C0", Offset = "0x76D2BC0", VA = "0x1876D37C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] JMJJMJCJCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x76C07C0", Offset = "0x76BFBC0", VA = "0x1876C07C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] FIKJINCPOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x76BCB40", Offset = "0x76BBF40", VA = "0x1876BCB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator NFHOJPADNNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x76BC940", Offset = "0x76BBD40", VA = "0x1876BC940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK FKOOCPLIOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x76D1DE0", Offset = "0x76D11E0", VA = "0x1876D1DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private PIBLOCDINDP FMJOECPJDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76D38C0", Offset = "0x76D2CC0", VA = "0x1876D38C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private PIBLOCDINDP NAIDJLKKFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x76C88F0", Offset = "0x76C7CF0", VA = "0x1876C88F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private PIBLOCDINDP PGJBNDPHHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x76BC810", Offset = "0x76BBC10", VA = "0x1876BC810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private PIBLOCDINDP ILEIEAHAPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x76CB410", Offset = "0x76CA810", VA = "0x1876CB410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private PIBLOCDINDP AGLDINNIEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x76BF5E0", Offset = "0x76BE9E0", VA = "0x1876BF5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private PIBLOCDINDP IDNKLPBEKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x76BCC40", Offset = "0x76BC040", VA = "0x1876BCC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private PIBLOCDINDP NJEKGLJCFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x76C17E0", Offset = "0x76C0BE0", VA = "0x1876C17E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private PIBLOCDINDP BCIIMFLDNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x76C18E0", Offset = "0x76C0CE0", VA = "0x1876C18E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BCGILGFMGGA BCMPBKFMMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x76D1CB0", Offset = "0x76D10B0", VA = "0x1876D1CB0", Slot = "15")]
		get
		{
			return default(BCGILGFMGGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NGCNOPAGGEC KECDLPJKCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA181C0", Offset = "0xA175C0", VA = "0x180A181C0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PBCNDHELJOL DDECBBMLBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA18850", Offset = "0xA17C50", VA = "0x180A18850", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CINJLPKEMIB EABBECOKHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA18B00", Offset = "0xA17F00", VA = "0x180A18B00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CINJLPKEMIB JIOEDJAOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA18560", Offset = "0xA17960", VA = "0x180A18560", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string NKNJNHDLEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform GEFJPNPMJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76D1C10", Offset = "0x76D1010", VA = "0x1876D1C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform KPCHNPMHCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x76C88A0", Offset = "0x76C7CA0", VA = "0x1876C88A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform MGKNMCJHILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x76BC910", Offset = "0x76BBD10", VA = "0x1876BC910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform AIDOFLELNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x76C14D0", Offset = "0x76C08D0", VA = "0x1876C14D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform ONJILOINENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x76CDCE0", Offset = "0x76CD0E0", VA = "0x1876CDCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool PCGMDEOBIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x76BB360", Offset = "0x76BA760", VA = "0x1876BB360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool LOEFFEFENHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x76BB360", Offset = "0x76BA760", VA = "0x1876BB360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool GBMDBLBINHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76BC320", Offset = "0x76BB720", VA = "0x1876BC320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform JPCFKCFPGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x76BF6E0", Offset = "0x76BEAE0", VA = "0x1876BF6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject MKMGIAEJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x76CF2D0", Offset = "0x76CE6D0", VA = "0x1876CF2D0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets KCFDFEIABAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x76CB210", Offset = "0x76CA610", VA = "0x1876CB210", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform PMDGDJHDDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA01FC0", Offset = "0xA013C0", VA = "0x180A01FC0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform DMFKMMJBBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA18B40", Offset = "0xA17F40", VA = "0x180A18B40", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform ECHLHLPNDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA177A0", Offset = "0xA16BA0", VA = "0x180A177A0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform IKLGOJPMHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1D60", Offset = "0x1AE1160", VA = "0x181AE1D60", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 BPEIAAJPMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x76BADC0", Offset = "0x76BA1C0", VA = "0x1876BADC0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float MDEPHFDJHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x76BD370", Offset = "0x76BC770", VA = "0x1876BD370", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform FAFKGLFDMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x76CC490", Offset = "0x76CB890", VA = "0x1876CC490", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform EFCHADBLMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x21530D0", Offset = "0x21524D0", VA = "0x1821530D0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform KGDDPLKEBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x215EE20", Offset = "0x215E220", VA = "0x18215EE20", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform MJGNMFBCMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1AE2920", Offset = "0x1AE1D20", VA = "0x181AE2920", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool LDENCDMEIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x76CF1D0", Offset = "0x76CE5D0", VA = "0x1876CF1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool BPECBILBENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x76CAD70", Offset = "0x76CA170", VA = "0x1876CAD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool JAPMLCNKCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x76CACF0", Offset = "0x76CA0F0", VA = "0x1876CACF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x76D0210", Offset = "0x76CF610", VA = "0x1876D0210")]
	private void NALBFMPJDPC([In] DGLPCLEHFNH EGLBMPOOHDN, [In] AvatarFullBodyConfiguration EOPBDJJHJJL, bool IDEAICMEEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x76CADF0", Offset = "0x76CA1F0", VA = "0x1876CADF0")]
	private float IOOFFBDJAEC([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x76D0010", Offset = "0x76CF410", VA = "0x1876D0010")]
	private float MJIPMMJHDFF([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76CCAF0", Offset = "0x76CBEF0", VA = "0x1876CCAF0")]
	private void KJFACOHAJPL(DGLPCLEHFNH EGLBMPOOHDN, AvatarFullBodyConfiguration EOPBDJJHJJL, bool IDEAICMEEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x76CDB20", Offset = "0x76CCF20", VA = "0x1876CDB20")]
	private void KOMLPDNPLCK([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x76BD510", Offset = "0x76BC910", VA = "0x1876BD510")]
	private void CNAMLDMKOMB([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x76D45D0", Offset = "0x76D39D0", VA = "0x1876D45D0")]
	public BFFEOMPDIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x76BD820", Offset = "0x76BCC20", VA = "0x1876BD820", Slot = "12")]
	public void CONJHLAMLKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x76C10F0", Offset = "0x76C04F0", VA = "0x1876C10F0", Slot = "13")]
	public void EMHHGFELJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x76C89F0", Offset = "0x76C7DF0", VA = "0x1876C89F0", Slot = "14")]
	public void HCNNHBPCHDB(bool KJHGEEDBPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x76CC340", Offset = "0x76CB740", VA = "0x1876CC340", Slot = "25")]
	public Transform JPBPBKAHOGF(string JJCBJKEODPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x76BB430", Offset = "0x76BA830", VA = "0x1876BB430", Slot = "26")]
	public Vector3? BCGIEHLLAEC(string JJCBJKEODPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4C60", Offset = "0x76C4060", VA = "0x1876C4C60", Slot = "7")]
	public void GJMLBEICPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76BFAC0", Offset = "0x76BEEC0", VA = "0x1876BFAC0")]
	private void DHPBPCONMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x76CB290", Offset = "0x76CA690", VA = "0x1876CB290")]
	private Vector3 JGJKCFFGIAD([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x76D2A40", Offset = "0x76D1E40", VA = "0x1876D2A40", Slot = "6")]
	public void OGLNBPAPBPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x76C1080", Offset = "0x76C0480", VA = "0x1876C1080", Slot = "8")]
	public void EKHDPHLNIIE(float GBPJJJFLGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x76CA4B0", Offset = "0x76C98B0", VA = "0x1876CA4B0")]
	private void IFKDHPOGFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x76C19E0", Offset = "0x76C0DE0", VA = "0x1876C19E0", Slot = "4")]
	public void FHMGGNDILHF(string CENGONCPBJO, PNBIBLHAPIF DKELAIDKEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x76CE180", Offset = "0x76CD580", VA = "0x1876CE180", Slot = "5")]
	public void LHPOCAFCCBC(BCGILGFMGGA DFHADBADINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x76BFBC0", Offset = "0x76BEFC0", VA = "0x1876BFBC0", Slot = "11")]
	public void DKEGCBDKNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76C8E10", Offset = "0x76C8210", VA = "0x1876C8E10", Slot = "24")]
	public void HJKBJHDNFEA([Out] Vector3 AGCCBGGMHLN, [Out] Quaternion FJLKPJIECLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76C1510", Offset = "0x76C0910", VA = "0x1876C1510")]
	private void FFCFIGMJHJD([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x76C88E0", Offset = "0x76C7CE0", VA = "0x1876C88E0", Slot = "27")]
	public void GPKHHBCDOJH(float KCMJBCOFPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x76BCD40", Offset = "0x76BC140", VA = "0x1876BCD40", Slot = "28")]
	public void CCINOPLIIEF(float IILIBOMGIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x76D3B80", Offset = "0x76D2F80", VA = "0x1876D3B80", Slot = "44")]
	public void POIJPDEKPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x76D1C60", Offset = "0x76D1060", VA = "0x1876D1C60", Slot = "29")]
	public void NGIAHNKOCHD(bool BLBHJACGHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x76BCA40", Offset = "0x76BBE40", VA = "0x1876BCA40", Slot = "30")]
	public HandLogicOffsets BPOPHMBKJLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76CDA60", Offset = "0x76CCE60", VA = "0x1876CDA60", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets KOMFNLEBMEJ()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76D1BE0", Offset = "0x76D0FE0", VA = "0x1876D1BE0")]
	private void NCPMCCHEGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76D0090", Offset = "0x76CF490", VA = "0x1876D0090")]
	private void MOODBMDAHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76C94E0", Offset = "0x76C88E0", VA = "0x1876C94E0")]
	private void ICLNHEHPNOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76BE520", Offset = "0x76BD920", VA = "0x1876BE520")]
	private void DAIHCFJIAFM(NFIBELDGELK OOGBEINCFBM, bool AFNGBHPONPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x76CDFF0", Offset = "0x76CD3F0", VA = "0x1876CDFF0")]
	private void LGMFDAKFOMJ(NFIBELDGELK OOGBEINCFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x76C91A0", Offset = "0x76C85A0", VA = "0x1876C91A0")]
	public Vector3 HPAHPAAIKJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x76C91F0", Offset = "0x76C85F0", VA = "0x1876C91F0")]
	private void IAPGPPPLPAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x76C14B0", Offset = "0x76C08B0", VA = "0x1876C14B0")]
	private void EPPHNJMMLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76C5440", Offset = "0x76C4840", VA = "0x1876C5440")]
	private void GKCHKELBHEH(DGLPCLEHFNH EGLBMPOOHDN, AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x76C5CF0", Offset = "0x76C50F0", VA = "0x1876C5CF0")]
	private float GMGFMBLMFOL([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x76BD090", Offset = "0x76BC490", VA = "0x1876BD090")]
	private int CEAGHPDFJPI([In] MFEGKBHEHMP MFDNIGEJKED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x76C0290", Offset = "0x76BF690", VA = "0x1876C0290")]
	private void EHOIJIPEOOF(DGLPCLEHFNH EGLBMPOOHDN, bool JCEIGGHNPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x76BD610", Offset = "0x76BCA10", VA = "0x1876BD610")]
	private static void COJODNHLOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x76C5EA0", Offset = "0x76C52A0", VA = "0x1876C5EA0")]
	private static void GNBIJLJPLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x76D2790", Offset = "0x76D1B90", VA = "0x1876D2790")]
	private float OAINPECGNGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x76C5CC0", Offset = "0x76C50C0", VA = "0x1876C5CC0")]
	private static int GMEBJMLGAGG(BFFEOMPDIAI AJLPPHLPDOI, BFFEOMPDIAI PODDNHBLFOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x76CE620", Offset = "0x76CDA20", VA = "0x1876CE620", Slot = "40")]
	public DGLPCLEHFNH LJMLIKMJIDO()
	{
		return default(DGLPCLEHFNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x76CC010", Offset = "0x76CB410", VA = "0x1876CC010")]
	public void JLHPNHKNCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x76BD170", Offset = "0x76BC570", VA = "0x1876BD170")]
	private (bool, bool) CFGDLAHHMIM()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76CFE30", Offset = "0x76CF230", VA = "0x1876CFE30")]
	private (float, float) MIHLJELPPJB([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x76C6BD0", Offset = "0x76C5FD0", VA = "0x1876C6BD0")]
	private void GNPMHJAELII([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x76BFF70", Offset = "0x76BF370", VA = "0x1876BFF70")]
	private void EFLPHBHPMNI([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76BE100", Offset = "0x76BD500", VA = "0x1876BE100")]
	private void DAGOMJOGOFG([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL, AvatarFootSettings NINJNCIGBHB, bool LJPIHKODJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x76BB3B0", Offset = "0x76BA7B0", VA = "0x1876BB3B0")]
	private float ANEGKNHEPGP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x76C9920", Offset = "0x76C8D20", VA = "0x1876C9920")]
	private void IDMCANEJEHA(DGLPCLEHFNH FBOKGPFKJCL, AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x76C1540", Offset = "0x76C0940", VA = "0x1876C1540")]
	private float FFHFGHGANHE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x76CF970", Offset = "0x76CED70", VA = "0x1876CF970")]
	private void MGEPACKPKHC([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x76BF7E0", Offset = "0x76BEBE0", VA = "0x1876BF7E0")]
	private void DFPICFADAHO([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76BC420", Offset = "0x76BB820", VA = "0x1876BC420")]
	private void BNCDAPPFGIL([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x76CC090", Offset = "0x76CB490", VA = "0x1876CC090")]
	private void JLMLLNBEPJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x76BFD20", Offset = "0x76BF120", VA = "0x1876BFD20")]
	private void DLPEKDEOFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x76C8AC0", Offset = "0x76C7EC0", VA = "0x1876C8AC0")]
	private void HFDFOJOLBFM([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x76C8610", Offset = "0x76C7A10", VA = "0x1876C8610")]
	private void GOAHHHNCGFA(CPCOOJBNCJC LPHFEEFKDKA, IKSolverVR.Arm APBJKIIFJJI, Transform ALFBKNLAPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x76CAE80", Offset = "0x76CA280", VA = "0x1876CAE80")]
	private void IPEGCBALJGH(DGLPCLEHFNH FBOKGPFKJCL, AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76CF370", Offset = "0x76CE770", VA = "0x1876CF370")]
	private void LOHGGMBFGJF(CKFMLNHEIDN HACCFEPGDNH, CINJLPKEMIB LPHFEEFKDKA, IKSolverVR.Arm APBJKIIFJJI, float BKKMOKHEJGP, float FIHPFBGBDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x76CC4F0", Offset = "0x76CB8F0", VA = "0x1876CC4F0")]
	private void KBGIFDPLKGA([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x76BB6C0", Offset = "0x76BAAC0", VA = "0x1876BB6C0")]
	protected void BGHFEHEIENF([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x76CDD20", Offset = "0x76CD120", VA = "0x1876CDD20")]
	private void LGANGAEKFMA([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x76C1590", Offset = "0x76C0990", VA = "0x1876C1590")]
	protected void FGNILFHOJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x76CB7A0", Offset = "0x76CABA0", VA = "0x1876CB7A0")]
	private void JJPLCDPOJGH([In] DGLPCLEHFNH FBOKGPFKJCL, [In] KPJDDBMAPDL FHIFMFJJELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x76BE810", Offset = "0x76BDC10", VA = "0x1876BE810")]
	private void DAIIAJBFEEA(DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x76CBFD0", Offset = "0x76CB3D0", VA = "0x1876CBFD0")]
	private void JKBPFKJGINK([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x76BAE50", Offset = "0x76BA250", VA = "0x1876BAE50")]
	private Vector3 AJJKLAMGBGM([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x76D2970", Offset = "0x76D1D70", VA = "0x1876D2970")]
	private void ODNHNHMNBLN([In] DGLPCLEHFNH FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x76BF190", Offset = "0x76BE590", VA = "0x1876BF190")]
	private float DCDDEDCBMJM(float LDKCNFNEKKK, [In] DGLPCLEHFNH FBOKGPFKJCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x76BD3C0", Offset = "0x76BC7C0", VA = "0x1876BD3C0")]
	private void CLKNPLGBHNF(float LDKCNFNEKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x76BBA90", Offset = "0x76BAE90", VA = "0x1876BBA90")]
	private void BIFIDLKNIAG([In] DGLPCLEHFNH FBOKGPFKJCL, KPJDDBMAPDL FHIFMFJJELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x76C08C0", Offset = "0x76BFCC0", VA = "0x1876C08C0")]
	private float EINEECJFBIJ([In] DGLPCLEHFNH EGLBMPOOHDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x76CA500", Offset = "0x76C9900", VA = "0x1876CA500")]
	private void IIGELGAHAHI(DGLPCLEHFNH FBOKGPFKJCL, KPJDDBMAPDL FHIFMFJJELE, Vector3 GCDNMKJNHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x76C8C60", Offset = "0x76C8060", VA = "0x1876C8C60")]
	private static void HJAJPOBIAJH(Transform NPHMCHFKJHC, Quaternion BENMKDDDBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x76CF640", Offset = "0x76CEA40", VA = "0x1876CF640")]
	private void MDJAMJAIIOA([In] DGLPCLEHFNH OACDOGEEHNB, [In] MFEGKBHEHMP MFDNIGEJKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x76D1EE0", Offset = "0x76D12E0", VA = "0x1876D1EE0")]
	private void NPPHEIFJJOI([In] DGLPCLEHFNH OACDOGEEHNB, [In] MFEGKBHEHMP MFDNIGEJKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76C4160", Offset = "0x76C3560", VA = "0x1876C4160")]
	private void FOMEDBHCICO(float JKOJHDPCIOL, [In] DGLPCLEHFNH EGLBMPOOHDN, float FPEHPKKBDCM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x76BE9C0", Offset = "0x76BDDC0", VA = "0x1876BE9C0")]
	private float DBBCNAEKBLL([In] DGLPCLEHFNH EGLBMPOOHDN, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x76D34D0", Offset = "0x76D28D0", VA = "0x1876D34D0")]
	private void OHOFCBMEAHA([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x76CE790", Offset = "0x76CDB90", VA = "0x1876CE790")]
	private void LKBLECGDKLP([In] DGLPCLEHFNH EGLBMPOOHDN, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x76BDD30", Offset = "0x76BD130", VA = "0x1876BDD30")]
	private void CPHLAMCMHKD([In] DGLPCLEHFNH EGLBMPOOHDN, float PCNHJHOBHDB, float MJNCIPMLJFI, Vector3 GGLIMGILAIP, float FPEHPKKBDCM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x76CCF50", Offset = "0x76CC350", VA = "0x1876CCF50")]
	private void KJMMGPKEDKH(DGLPCLEHFNH EGLBMPOOHDN, AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x76CB510", Offset = "0x76CA910", VA = "0x1876CB510")]
	private void JIMPNKHKOPJ(DGLPCLEHFNH FBOKGPFKJCL, AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x76C4890", Offset = "0x76C3C90", VA = "0x1876C4890")]
	private void GJGCFEHFHCN(DGLPCLEHFNH EGLBMPOOHDN, AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x76D39C0", Offset = "0x76D2DC0", VA = "0x1876D39C0")]
	public void PIICGLKLJCC([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x76C3D50", Offset = "0x76C3150", VA = "0x1876C3D50")]
	public void FMMIAFFAEBL([In] DGLPCLEHFNH FBOKGPFKJCL, [In] AvatarFullBodyConfiguration EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x76BC180", Offset = "0x76BB580", VA = "0x1876BC180")]
	[CompilerGenerated]
	internal static void BLOCJKLOKPN(Transform ICAPBAKKPBL, IKSolverVR.Arm APBJKIIFJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x76BCA90", Offset = "0x76BBE90", VA = "0x1876BCA90")]
	[CompilerGenerated]
	internal static void BPPDFAHODKI(Vector3 GHHHOHMIKOO, Vector3 DKMPBCCDGPN, JFFHJNDKFGB P_2, HMPAJMHBKNG P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x76C40C0", Offset = "0x76C34C0", VA = "0x1876C40C0")]
	[CompilerGenerated]
	internal static void FNKFPDKOOFE(LLMNCLBHCKJ NDLJJEJLKHJ, LLMNCLBHCKJ EIJNDPMACKA, Vector3 MHNHHIDBHMO, float DFEFGBECJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x76CD950", Offset = "0x76CCD50", VA = "0x1876CD950")]
	[CompilerGenerated]
	internal static bool KLDFMCKGMGP(IKSolverVR.Arm APBJKIIFJJI, ODCGGHGCMLN DNBILLMKKLD, float NHMDDGBLPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x76C4450", Offset = "0x76C3850", VA = "0x1876C4450")]
	[CompilerGenerated]
	internal static float GHPNKDHKAIM(Vector3 CPBHNGNKABB, Vector3 OFJONGCOIDF, Vector3 JFHANNIICPN, DGLPCLEHFNH EGLBMPOOHDN, AvatarFullBodyConfiguration EOPBDJJHJJL, float NPELPNMIGOA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class NPAEAABIJJJ : ALAHFHGHFAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<string, EPJPNNGGJPH> JNAPFAGGOLF;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x76E2B70", Offset = "0x76E1F70", VA = "0x1876E2B70")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void CDCNJHJANAF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x76E2F70", Offset = "0x76E2370", VA = "0x1876E2F70", Slot = "4")]
	public EPJPNNGGJPH PHHMFHMCLHI(string DEJMOLKIHBN, AvatarSystemConfiguration LDMGHFNOMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x76E2D90", Offset = "0x76E2190", VA = "0x1876E2D90", Slot = "5")]
	public void PGNGFJGPIJC(string DEJMOLKIHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x76E2C50", Offset = "0x76E2050", VA = "0x1876E2C50", Slot = "6")]
	public string KKMHODHPHKB(string JHFFAGILLPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x76E2BE0", Offset = "0x76E1FE0", VA = "0x1876E2BE0")]
	private string CLDEKALNOIK(string JHFFAGILLPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x76E3190", Offset = "0x76E2590", VA = "0x1876E3190")]
	public NPAEAABIJJJ()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class DGABLOCGFHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private Dictionary<string, Transform> MBNNMPAEOHH;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool JKHINNGGCOD
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x76DC260", Offset = "0x76DB660", VA = "0x1876DC260")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x76DC2A0", Offset = "0x76DB6A0", VA = "0x1876DC2A0")]
			public void GHOMNJKFCLA(VRIK LIJOLCGFBNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
			public void HCNALNEEOEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x76DC210", Offset = "0x76DB610", VA = "0x1876DC210")]
			public void CNJFGCHCFHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x76DC3D0", Offset = "0x76DB7D0", VA = "0x1876DC3D0")]
			public DGABLOCGFHO()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		[HBPAIPBJNDJ(FPABMOGJDEH.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly DGABLOCGFHO GPAIHCJMDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private HFAJMILAENK IAHFKHKDHKK;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x76D8FF0", Offset = "0x76D83F0", VA = "0x1876D8FF0")]
		private void MBHBIOMKKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x76D8FA0", Offset = "0x76D83A0", VA = "0x1876D8FA0")]
		private bool FCOFPAGHJON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x76D92D0", Offset = "0x76D86D0", VA = "0x1876D92D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x76D9340", Offset = "0x76D8740", VA = "0x1876D9340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76D92E0", Offset = "0x76D86E0", VA = "0x1876D92E0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x76D95B0", Offset = "0x76D89B0", VA = "0x1876D95B0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x76DEB20", Offset = "0x76DDF20", VA = "0x1876DEB20")]
			public void AEJOPFDILPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x76DEC00", Offset = "0x76DE000", VA = "0x1876DEC00")]
			public (float, float) LOJMCKCBGAC(Animator LGGEICNAEFM, AnimatorStateInfo BKNNKBKMGGK)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x76DED40", Offset = "0x76DE140", VA = "0x1876DED40")]
		public void AEJOPFDILPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x76DF120", Offset = "0x76DE520", VA = "0x1876DF120")]
		public (float, float) LMBJEOIGLLB(Animator LGGEICNAEFM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x76DEF30", Offset = "0x76DE330", VA = "0x1876DEF30")]
		private (float, float) DKEDGPJAJHL(Animator LGGEICNAEFM, AnimatorStateInfo BKNNKBKMGGK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x76DF330", Offset = "0x76DE730", VA = "0x1876DF330")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x76E0C80", Offset = "0x76E0080", VA = "0x1876E0C80", Slot = "4")]
		public override void OnStateEnter(Animator LGGEICNAEFM, AnimatorStateInfo BKNNKBKMGGK, int KPOIMDAHIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x76E0DE0", Offset = "0x76E01E0", VA = "0x1876E0DE0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class FBOJKPOBKOA<TInput, TOutput> : AKMOONNIJPG<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected readonly FEHNCHIDFDG EJEHNGBDFNJ;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x46C12B0", Offset = "0x46C06B0", VA = "0x1846C12B0")]
	protected FBOJKPOBKOA(FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput OJJOMCGFFJC(TInput BEAPIEHNNIB, [Out] IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x46C1210", Offset = "0x46C0610", VA = "0x1846C1210", Slot = "5")]
	public bool NDPCGJDFJEN(TInput BEAPIEHNNIB, [Out] TOutput? KGODHHBLJOE, [Out] IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[NGHELBGCMPC]
public static class BANEFCFDJHD
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly Regex ADNPMFPCPPJ;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x76D9A00", Offset = "0x76D8E00", VA = "0x1876D9A00")]
	public static IKHCOIJJFNA PKFBKCNBDAI(JCFFMFFLEFL LPOCDKMGBCA, HOBMLDPDGIJ DJCKGIILPPK, Guid? DIFAHGJHFEP, Color? JOLKOJEDAMM, HKLJDIPJMDE DOIOMNLOJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x76D9760", Offset = "0x76D8B60", VA = "0x1876D9760")]
	public static GPINPBJCOOH JDPGPGGOAEP(IKHCOIJJFNA AMHCLKHIFKH)
	{
		return default(GPINPBJCOOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x33564E0", Offset = "0x33558E0", VA = "0x1833564E0")]
	internal static TModern? EJLHIBLDBLJ<TModern>(string? BEAPIEHNNIB, KGFOGAIBEKG<TModern> JCCPGMFEKGH, FEHNCHIDFDG EJEHNGBDFNJ, IHPJFAAOLFC MDPKAGHIJHE, TModern KNJKOBLAGLB) where TModern : struct, IECGHJIBGMC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x33589B0", Offset = "0x3357DB0", VA = "0x1833589B0")]
	internal static MJOAGFKBOBH OBLGBMCAOCJ<TModern>(string? BEAPIEHNNIB, KGFOGAIBEKG<TModern> JCCPGMFEKGH, FEHNCHIDFDG EJEHNGBDFNJ, IHPJFAAOLFC MDPKAGHIJHE, TModern KNJKOBLAGLB) where TModern : struct, IECGHJIBGMC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x76D98C0", Offset = "0x76D8CC0", VA = "0x1876D98C0")]
	internal static List<BGOGBDBFPOI> LNGLNFLECCK(IEnumerable<EOJOOLOPIED>? LAPPMMMCKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3357B30", Offset = "0x3356F30", VA = "0x183357B30")]
	internal static string FIPGEJBPDHD<TModern>(TModern BEAPIEHNNIB, KGFOGAIBEKG<TModern> JCCPGMFEKGH, FEHNCHIDFDG EJEHNGBDFNJ) where TModern : IECGHJIBGMC
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class OICMFOGHELH : PGJLEIPCBNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AKMOONNIJPG<LIOOIDGKCHN, FNHNCLCJBFE> BEJGMOHJNPP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AKMOONNIJPG<JFEJACCGDHB, EFPGMKHCLPM> IOCCMBACAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AKMOONNIJPG<JFEJACCGDHB, EFPGMKHCLPM> CDHJLLOGMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IKMEEOCIOKL GPGGLCILAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public AAJCIEAKCMK CNLHGAGMNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x76E3220", Offset = "0x76E2620", VA = "0x1876E3220")]
	[UsedImplicitly]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	internal static void FKEEGBEBDLF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x76E3290", Offset = "0x76E2690", VA = "0x1876E3290")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OICMFOGHELH([GKAMHFFOHNI("UnitySerialization")] JHLAHEOLKLK GNOIFJBMIMK, [GKAMHFFOHNI(null)] OGNICHHMCBH KJKOHDDODHM, [GKAMHFFOHNI(null)] FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum EODMIHIJIDK
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BAFIHIGCFDE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x76D96F0", Offset = "0x76D8AF0", VA = "0x1876D96F0")]
	public BAFIHIGCFDE(string EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x76D96C0", Offset = "0x76D8AC0", VA = "0x1876D96C0")]
	public BAFIHIGCFDE(string EIGJGBPHOMK, Exception JFHJDHHPKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x76D9690", Offset = "0x76D8A90", VA = "0x1876D9690")]
	public BAFIHIGCFDE(EODMIHIJIDK JMDODKHGNOP, string EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x76D9720", Offset = "0x76D8B20", VA = "0x1876D9720")]
	public BAFIHIGCFDE(EODMIHIJIDK JMDODKHGNOP, string EIGJGBPHOMK, Exception JFHJDHHPKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class FDFENBKMMIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly JHLAHEOLKLK GNOIFJBMIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly OGNICHHMCBH KJKOHDDODHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly FEHNCHIDFDG EJEHNGBDFNJ;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x76DE2B0", Offset = "0x76DD6B0", VA = "0x1876DE2B0")]
	protected FDFENBKMMIF(JHLAHEOLKLK GNOIFJBMIMK, OGNICHHMCBH KJKOHDDODHM, FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x76DCB70", Offset = "0x76DBF70", VA = "0x1876DCB70")]
	protected string IJEHHPNHAMP(FNHNCLCJBFE ADDEPKOGHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x76DC980", Offset = "0x76DBD80", VA = "0x1876DC980")]
	protected string HNIGHHELGMM(FNHNCLCJBFE ADDEPKOGHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x76DDF80", Offset = "0x76DD380", VA = "0x1876DDF80")]
	private AvatarOutfitSelectionData PKFBKCNBDAI(IKHCOIJJFNA KPLAGEOFMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x76DDE40", Offset = "0x76DD240", VA = "0x1876DDE40")]
	private static AvatarCustomizationSettingsData.AnchorParams MIJLCAIEJKI(GHDNJFDBFAB? HENEICJGNKK)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface AKMOONNIJPG<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput OJJOMCGFFJC(TInput BEAPIEHNNIB, [Out] IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDPCGJDFJEN(TInput BEAPIEHNNIB, [Out] TOutput? KGODHHBLJOE, [Out] IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PGJLEIPCBNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AKMOONNIJPG<LIOOIDGKCHN, FNHNCLCJBFE> BEJGMOHJNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	AKMOONNIJPG<JFEJACCGDHB, EFPGMKHCLPM> CDHJLLOGMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	IKMEEOCIOKL GPGGLCILAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum IHPJFAAOLFC
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AAJCIEAKCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGKJILENGGL LMGGAKIACNI(FNHNCLCJBFE AMHCLKHIFKH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IKMEEOCIOKL
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFEJACCGDHB LMGGAKIACNI(FNHNCLCJBFE AMHCLKHIFKH, int LEGHOJDPODF, string? MPGDCPPMNJN, string? BDFLCOMLHMK, LILABGCADKK CDPMNKIKIKJ, List<BGOGBDBFPOI>? LIONHABEEGC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[NGHELBGCMPC]
internal class LAMCHEPPHNL : FBOJKPOBKOA<LIOOIDGKCHN, FNHNCLCJBFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly OGNICHHMCBH KJKOHDDODHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly CCBNOAHIBBG HGDHLCLJEII;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x76DFD00", Offset = "0x76DF100", VA = "0x1876DFD00")]
	public LAMCHEPPHNL(JHLAHEOLKLK GNOIFJBMIMK, OGNICHHMCBH KJKOHDDODHM, FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x76DFA60", Offset = "0x76DEE60", VA = "0x1876DFA60", Slot = "6")]
	public override FNHNCLCJBFE OJJOMCGFFJC(LIOOIDGKCHN BEAPIEHNNIB, [Out] IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class NHDDDBEAFKB : JHLAHEOLKLK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class AMBPIHPCILE : JsonConverter<MJOAGFKBOBH>
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x76D84D0", Offset = "0x76D78D0", VA = "0x1876D84D0", Slot = "9")]
		public override void WriteJson(JsonWriter NACIMEJMHHK, MJOAGFKBOBH? FIIKLGCIAGG, JsonSerializer DKOOENLAMFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x76D83B0", Offset = "0x76D77B0", VA = "0x1876D83B0", Slot = "10")]
		public override MJOAGFKBOBH ReadJson(JsonReader KILJCGGJECG, Type HOAMBGIHCIG, MJOAGFKBOBH? OGJDCDCHPNF, bool NHBGJLMLHEF, JsonSerializer DKOOENLAMFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x76D8570", Offset = "0x76D7970", VA = "0x1876D8570")]
		public AMBPIHPCILE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class EJFGHPIOBCL : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool JEHIKCGNLDO
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x76DC840", Offset = "0x76DBC40", VA = "0x1876DC840", Slot = "5")]
		public override object ReadJson(JsonReader KILJCGGJECG, Type HOAMBGIHCIG, object? OGJDCDCHPNF, JsonSerializer DKOOENLAMFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x76DC460", Offset = "0x76DB860", VA = "0x1876DC460", Slot = "6")]
		public override bool CanConvert(Type HOAMBGIHCIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x76DC8A0", Offset = "0x76DBCA0", VA = "0x1876DC8A0", Slot = "4")]
		public override void WriteJson(JsonWriter NACIMEJMHHK, object? FIIKLGCIAGG, JsonSerializer DKOOENLAMFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76DC640", Offset = "0x76DBA40", VA = "0x1876DC640")]
		private static bool HMJDEMFMLGA(object FIIKLGCIAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public EJFGHPIOBCL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings JJJMCAHFNCD;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x76E2A10", Offset = "0x76E1E10", VA = "0x1876E2A10")]
	internal NHDDDBEAFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x379A030", Offset = "0x3799430", VA = "0x18379A030", Slot = "4")]
	public string GJHMCHAGCOA<T>(T HAPOBHMBDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3799FA0", Offset = "0x37993A0", VA = "0x183799FA0", Slot = "5")]
	public T EFMIPAHDBHL<T>(string FIIKLGCIAGG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class ACLOPNOLOEG : JHLAHEOLKLK
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3D599E0", Offset = "0x3D58DE0", VA = "0x183D599E0", Slot = "4")]
	public string GJHMCHAGCOA<T>(T HAPOBHMBDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3D59960", Offset = "0x3D58D60", VA = "0x183D59960", Slot = "5")]
	public T EFMIPAHDBHL<T>(string FIIKLGCIAGG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public ACLOPNOLOEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NGHELBGCMPC]
internal class CCBNOAHIBBG : FBOJKPOBKOA<JFEJACCGDHB, EFPGMKHCLPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly JHLAHEOLKLK GNOIFJBMIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly OGNICHHMCBH KJKOHDDODHM;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x76DC0D0", Offset = "0x76DB4D0", VA = "0x1876DC0D0")]
	public CCBNOAHIBBG(JHLAHEOLKLK GNOIFJBMIMK, OGNICHHMCBH KJKOHDDODHM, FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x76DBCB0", Offset = "0x76DB0B0", VA = "0x1876DBCB0", Slot = "6")]
	public override EFPGMKHCLPM OJJOMCGFFJC(JFEJACCGDHB BEAPIEHNNIB, [Out] IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x76DAB80", Offset = "0x76D9F80", VA = "0x1876DAB80")]
	internal void GAKLEHBMFGK(string FENDOAEKIEK, FNHNCLCJBFE ADDEPKOGHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x76DB400", Offset = "0x76DA800", VA = "0x1876DB400")]
	public IEnumerable<IKHCOIJJFNA> LJMOMBHHKJM(string LHHPBANAEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x76DACE0", Offset = "0x76DA0E0", VA = "0x1876DACE0")]
	private IEnumerable<IKHCOIJJFNA> HMKJNELNOKB(string LHHPBANAEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x76D9CB0", Offset = "0x76D90B0", VA = "0x1876D9CB0")]
	internal IEnumerable<IKHCOIJJFNA> AAJOJANBFFI(string LHHPBANAEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x76DB4B0", Offset = "0x76DA8B0", VA = "0x1876DB4B0")]
	private IKHCOIJJFNA NJCOOGNHCOD(AvatarOutfitSelectionData JNKJJPDKEEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x76DA100", Offset = "0x76D9500", VA = "0x1876DA100")]
	private void DDMEGGFACBE(AvatarCustomizationSettingsData DPBPPNJCIIE, FNHNCLCJBFE ADDEPKOGHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x76DB830", Offset = "0x76DAC30", VA = "0x1876DB830")]
	private IKHCOIJJFNA NJCOOGNHCOD(string JGIOOAGBHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x76DB100", Offset = "0x76DA500", VA = "0x1876DB100")]
	internal static (HKLJDIPJMDE, string, string) JMNNMICOPMK(string JGIOOAGBHHC, FEHNCHIDFDG EJEHNGBDFNJ)
	{
		return default((HKLJDIPJMDE, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x76DA980", Offset = "0x76D9D80", VA = "0x1876DA980")]
	private IGPGFFDNKNG? EFLILEGGDDM(string? IIBHEJCKGGH, Vector2 MEFLDLLJODM, float MDFMLLDMNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x76DBB50", Offset = "0x76DAF50", VA = "0x1876DBB50")]
	private static GHDNJFDBFAB OABHNIOFGBA(AvatarCustomizationSettingsData.AnchorParams NNIDBNHCBJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NGHELBGCMPC]
internal class HBGNAACKBCP : FDFENBKMMIF, AAJCIEAKCMK
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x76DE2B0", Offset = "0x76DD6B0", VA = "0x1876DE2B0")]
	public HBGNAACKBCP(JHLAHEOLKLK GNOIFJBMIMK, OGNICHHMCBH KJKOHDDODHM, FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x76DE530", Offset = "0x76DD930", VA = "0x1876DE530", Slot = "4")]
	public KGKJILENGGL LMGGAKIACNI(FNHNCLCJBFE AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x76DE430", Offset = "0x76DD830", VA = "0x1876DE430")]
	private string JAOAIKIKAFE(FNHNCLCJBFE ADDEPKOGHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x76DE8E0", Offset = "0x76DDCE0", VA = "0x1876DE8E0")]
	private string MJONFPHCDMJ(IKHCOIJJFNA KPLAGEOFMPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[NGHELBGCMPC]
internal class NEMCDELDBJF : FBOJKPOBKOA<JFEJACCGDHB, EFPGMKHCLPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly JHLAHEOLKLK GNOIFJBMIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly AKMOONNIJPG<JFEJACCGDHB, EFPGMKHCLPM> JANEPPNKCJH;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x76E2910", Offset = "0x76E1D10", VA = "0x1876E2910")]
	public NEMCDELDBJF(AKMOONNIJPG<JFEJACCGDHB, EFPGMKHCLPM> JANEPPNKCJH, FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x76E24E0", Offset = "0x76E18E0", VA = "0x1876E24E0", Slot = "6")]
	public override EFPGMKHCLPM OJJOMCGFFJC(JFEJACCGDHB BEAPIEHNNIB, [Out] IReadOnlyList<BGOGBDBFPOI>? LIONHABEEGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[NGHELBGCMPC]
internal class IFPJBNMNDGN : IKMEEOCIOKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly JHLAHEOLKLK GNOIFJBMIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly AAJCIEAKCMK OLFLFNIOEOL;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x76DF6E0", Offset = "0x76DEAE0", VA = "0x1876DF6E0")]
	public IFPJBNMNDGN(AAJCIEAKCMK OLFLFNIOEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76DF340", Offset = "0x76DE740", VA = "0x1876DF340", Slot = "4")]
	public JFEJACCGDHB LMGGAKIACNI(FNHNCLCJBFE AMHCLKHIFKH, int LEGHOJDPODF, string? MPGDCPPMNJN, string? BDFLCOMLHMK, LILABGCADKK CDPMNKIKIKJ, List<BGOGBDBFPOI>? LIONHABEEGC)
	{
		return null;
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x76D8660", Offset = "0x76D7A60", VA = "0x1876D8660")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JIDAJICHLOL
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x76DF950", Offset = "0x76DED50", VA = "0x1876DF950")]
	public static GPINPBJCOOH OJJOMCGFFJC(this NCLNNNOBIDG AMHCLKHIFKH)
	{
		return default(GPINPBJCOOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x76DF830", Offset = "0x76DEC30", VA = "0x1876DF830")]
	public static NCLNNNOBIDG LMGGAKIACNI(this GPINPBJCOOH KHKFOLKPLGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x76DF7D0", Offset = "0x76DEBD0", VA = "0x1876DF7D0")]
	public static bool FDFKOILLNML(this GPINPBJCOOH KHKFOLKPLGL)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x58A75B0", Offset = "0x58A69B0", VA = "0x1858A75B0")]
			public AnchorParams(Vector2 EJMFMHCAGKJ, Vector3 PJADLGDPDKD, Vector3 EIHLCKFOEIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x76D85B0", Offset = "0x76D79B0", VA = "0x1876D85B0")]
			internal GHDNJFDBFAB LMGGAKIACNI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private KJINMAEGIAJ useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x76D8E50", Offset = "0x76D8250", VA = "0x1876D8E50")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4A270F0", Offset = "0x4A264F0", VA = "0x184A270F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xC07170", Offset = "0xC06570", VA = "0x180C07170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xE525A0", Offset = "0xE519A0", VA = "0x180E525A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x11BDE60", Offset = "0x11BD260", VA = "0x1811BDE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x991DA0", Offset = "0x9911A0", VA = "0x180991DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x76D8EF0", Offset = "0x76D82F0", VA = "0x1876D8EF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99EC70", VA = "0x18099F870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xB41360", Offset = "0xB40760", VA = "0x180B41360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xB41040", Offset = "0xB40440", VA = "0x180B41040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x993400", Offset = "0x992800", VA = "0x180993400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x76D8F30", Offset = "0x76D8330", VA = "0x1876D8F30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD78300", Offset = "0xD77700", VA = "0x180D78300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xFAB4B0", Offset = "0xFAA8B0", VA = "0x180FAB4B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x1617EC0", Offset = "0x16172C0", VA = "0x181617EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x997460", Offset = "0x996860", VA = "0x180997460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x997470", Offset = "0x996870", VA = "0x180997470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2110490", Offset = "0x210F890", VA = "0x182110490")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xDA32B0", Offset = "0xDA26B0", VA = "0x180DA32B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9C7B50", Offset = "0x9C6F50", VA = "0x1809C7B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9C7BB0", Offset = "0x9C6FB0", VA = "0x1809C7BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x99A8A0", Offset = "0x999CA0", VA = "0x18099A8A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x99A9E0", Offset = "0x999DE0", VA = "0x18099A9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x99AA50", Offset = "0x999E50", VA = "0x18099AA50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x99A960", Offset = "0x999D60", VA = "0x18099A960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x99A9F0", Offset = "0x999DF0", VA = "0x18099A9F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x99AA20", Offset = "0x999E20", VA = "0x18099AA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xB2BB10", Offset = "0xB2AF10", VA = "0x180B2BB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x11E1950", Offset = "0x11E0D50", VA = "0x1811E1950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x99A940", Offset = "0x999D40", VA = "0x18099A940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x99A8F0", Offset = "0x999CF0", VA = "0x18099A8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xC2B3E0", Offset = "0xC2A7E0", VA = "0x180C2B3E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xD940F0", Offset = "0xD934F0", VA = "0x180D940F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x999C90", Offset = "0x999090", VA = "0x180999C90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x999C50", Offset = "0x999050", VA = "0x180999C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB7A750", Offset = "0xB79B50", VA = "0x180B7A750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xDA8080", Offset = "0xDA7480", VA = "0x180DA8080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xBC4AB0", Offset = "0xBC3EB0", VA = "0x180BC4AB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xBC0E80", Offset = "0xBC0280", VA = "0x180BC0E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public KJINMAEGIAJ UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xE588F0", Offset = "0xE57CF0", VA = "0x180E588F0")]
			get
			{
				return default(KJINMAEGIAJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xE58900", Offset = "0xE57D00", VA = "0x180E58900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xE584A0", Offset = "0xE578A0", VA = "0x180E584A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB12260", Offset = "0xB11660", VA = "0x180B12260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x76D8F10", Offset = "0x76D8310", VA = "0x1876D8F10")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x76D8F50", Offset = "0x76D8350", VA = "0x1876D8F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x76D8AF0", Offset = "0x76D7EF0", VA = "0x1876D8AF0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public HKLJDIPJMDE BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private MPKOFDEKFGA? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x76D8F70", Offset = "0x76D8370", VA = "0x1876D8F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
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
