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
using RecRoom;
using RecRoom.Avatars;
using RecRoom.Avatars.Data;
using RecRoom.Avatars.Face;
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x60D4BC0", Offset = "0x60D3DC0", VA = "0x1860D4BC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[PJKEGBNMNOG]
internal class BKIJMNNHBBO : DDKFBJBFEPJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct GBKIEDIFNDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public BKIJMNNHBBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public MKHOLMAHBJI avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NFNDANMFPGB IHHBNJAFKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HABOMOHKGPC AEOJFMMMCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EPJJBICMHIN PNAIHHGLEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NOGBFLKPLAJ ONKAEDBMHBE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60CE940", Offset = "0x60CDB40", VA = "0x1860CE940")]
	[KEFCCLBEAOJ(BDECECCJEGA.Root, CMEECPGEPNF.GameOnly)]
	[UsedImplicitly]
	private static void OKKCFKPEANH(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60CF360", Offset = "0x60CE560", VA = "0x1860CF360")]
	[Preserve]
	internal BKIJMNNHBBO([GAGPBLHNPNO(null)] NFNDANMFPGB IHHBNJAFKCH, [GAGPBLHNPNO(null)] HABOMOHKGPC AEOJFMMMCPB, [GAGPBLHNPNO(null)] EPJJBICMHIN PNAIHHGLEKI, [GAGPBLHNPNO(null)] NOGBFLKPLAJ ONKAEDBMHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60CDF60", Offset = "0x60CD160", VA = "0x1860CDF60", Slot = "5")]
	public AOFLEHDOPCJ IKJIMKMIDEL(bool JMDKPGOIAGA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60CE9B0", Offset = "0x60CDBB0", VA = "0x1860CE9B0", Slot = "4")]
	public AOFLEHDOPCJ OOPMNEHCPIO(bool JMDKPGOIAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60CE710", Offset = "0x60CD910", VA = "0x1860CE710", Slot = "6")]
	public BFPIHMHLCFF KGHBOAHFEPM(AOFLEHDOPCJ FODGEDCJIDC, int ICAOGBDNOMB, string? IKEFBMMMAJB, string? DJEJNPJICEK, AMGJHJOBMLJ DOGLIFIFMAK, List<HFBGONFPNON>? BHMNFPCHDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60CE8B0", Offset = "0x60CDAB0", VA = "0x1860CE8B0", Slot = "7")]
	public bool OGALECCHBGP(GELLIPBGBMO JIFKLPLLPHN, [Out] AOFLEHDOPCJ? MEBPEONDLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60CDBA0", Offset = "0x60CCDA0", VA = "0x1860CDBA0", Slot = "8")]
	public bool FNCEBMLABHD(BFPIHMHLCFF JDKBGDJHAKA, [Out] AOFLEHDOPCJ? MEBPEONDLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60CE820", Offset = "0x60CDA20", VA = "0x1860CE820", Slot = "9")]
	public bool MMBMDFEENDG(BFPIHMHLCFF JDKBGDJHAKA, [Out] GKIPOKNIJNA? JIFKLPLLPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x26BBB70", Offset = "0x26BAD70", VA = "0x1826BBB70")]
	private bool EPBFGIHPCIL<TInput, TOutput>(TInput CCAOJBHBKKC, POBGBBHJFFJ<TInput, TOutput> GKNPOBMNIGF, [Out] TOutput? HCIDHCBMOPD) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60CD9F0", Offset = "0x60CCBF0", VA = "0x1860CD9F0")]
	[CompilerGenerated]
	private GMBFCNHEHHG CFNFPGHNNHD(FaceFeatureType LFDFHHHDLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60CDC80", Offset = "0x60CCE80", VA = "0x1860CDC80")]
	[CompilerGenerated]
	private GMBFCNHEHHG HCPMMHGDIDF(FaceFeatureType LFDFHHHDLDI, GBKIEDIFNDG P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PJKEGBNMNOG]
internal class MLIEPFOPCBC : NFNDANMFPGB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void MHBKPDOCEJM<in TData>(TData MEBPEONDLPD, IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly EPJJBICMHIN PNAIHHGLEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IAFPOFNODCF POMHMEMGNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MHBKPDOCEJM<AOFLEHDOPCJ>?[] IHHBNJAFKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MHBKPDOCEJM<GKIPOKNIJNA>?[] NKEIGPCBHGH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60D4780", Offset = "0x60D3980", VA = "0x1860D4780")]
	[KEFCCLBEAOJ(BDECECCJEGA.Root, CMEECPGEPNF.GameOnly)]
	[UsedImplicitly]
	private static void OKKCFKPEANH(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60D47F0", Offset = "0x60D39F0", VA = "0x1860D47F0")]
	[Preserve]
	internal MLIEPFOPCBC([GAGPBLHNPNO(null)] EPJJBICMHIN PNAIHHGLEKI, [GAGPBLHNPNO(null)] IAFPOFNODCF POMHMEMGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60D42F0", Offset = "0x60D34F0", VA = "0x1860D42F0", Slot = "4")]
	public bool NOJFELCCMAL(AOFLEHDOPCJ MEBPEONDLPD, IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60D43F0", Offset = "0x60D35F0", VA = "0x1860D43F0", Slot = "5")]
	public bool NOJFELCCMAL(GKIPOKNIJNA JIFKLPLLPHN, IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60D38C0", Offset = "0x60D2AC0", VA = "0x1860D38C0")]
	private void AJABCJPOGOC(AOFLEHDOPCJ MEBPEONDLPD, IReadOnlyList<HFBGONFPNON>? PMBMOONGPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60D4550", Offset = "0x60D3750", VA = "0x1860D4550")]
	private void OFCMFMOBOLB(AOFLEHDOPCJ MEBPEONDLPD, IReadOnlyList<HFBGONFPNON>? PMBMOONGPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NFNDANMFPGB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOJFELCCMAL(AOFLEHDOPCJ MEBPEONDLPD, IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOJFELCCMAL(GKIPOKNIJNA JIFKLPLLPHN, IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarElbowBendHelperController : MonoBehaviour, DEDCNPEEKIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private bool DebugExecutionInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Vector3? MAEBPHEGHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool GDDCMPALELP;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60B72F0", Offset = "0x60B64F0", VA = "0x1860B72F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60B78E0", Offset = "0x60B6AE0", VA = "0x1860B78E0", Slot = "4")]
		public void UpdateController(float NJLEMDJHIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD0C2D0", Offset = "0xD0B4D0", VA = "0x180D0C2D0", Slot = "6")]
		public void SetEnabled(bool NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60B7390", Offset = "0x60B6590", VA = "0x1860B7390")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60B7D00", Offset = "0x60B6F00", VA = "0x1860B7D00")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendTargetController : MonoBehaviour, DEDCNPEEKIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const float PJAANHOLJPO = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Vector3 APJFHOJEEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Vector3 MLEMBDNMGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool GDDCMPALELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float BEMJPLHACHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private float OMLKHMELOBE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60B8080", Offset = "0x60B7280", VA = "0x1860B8080", Slot = "4")]
		public void UpdateController(float NJLEMDJHIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3D950", Offset = "0xA3CB50", VA = "0x180A3D950", Slot = "6")]
		public void SetEnabled(bool NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60B7DA0", Offset = "0x60B6FA0", VA = "0x1860B7DA0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60B8A60", Offset = "0x60B7C60", VA = "0x1860B8A60")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60B8AD0", Offset = "0x60B7CD0", VA = "0x1860B8AD0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60B8A90", Offset = "0x60B7C90", VA = "0x1860B8A90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60B8B00", Offset = "0x60B7D00", VA = "0x1860B8B00")]
		private void PEHGKGDLBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x11B0420", Offset = "0x11AF620", VA = "0x1811B0420", Slot = "4")]
		public void SetEnabled(bool FFABKOCEGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60B93A0", Offset = "0x60B85A0", VA = "0x1860B93A0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarForearmRollController : MonoBehaviour, DEDCNPEEKIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool GDDCMPALELP;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60B93E0", Offset = "0x60B85E0", VA = "0x1860B93E0", Slot = "4")]
		public void UpdateController(float NJLEMDJHIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6490", Offset = "0x7C5690", VA = "0x1807C6490", Slot = "6")]
		public void SetEnabled(bool NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60B9B50", Offset = "0x60B8D50", VA = "0x1860B9B50")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, KDOLBPHPHCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[MGMFHFICAPM(OILHINDHMGI.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private IEOLOCFMODF FPEAEMLCFAL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IEOLOCFMODF GNGNJCGBLOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x60BA940", Offset = "0x60B9B40", VA = "0x1860BA940", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform CEBFJLCJKGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x60BA980", Offset = "0x60B9B80", VA = "0x1860BA980", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60BA1C0", Offset = "0x60B93C0", VA = "0x1860BA1C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60BA770", Offset = "0x60B9970", VA = "0x1860BA770")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60BA720", Offset = "0x60B9920", VA = "0x1860BA720")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60BA6B0", Offset = "0x60B98B0", VA = "0x1860BA6B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60BA630", Offset = "0x60B9830", VA = "0x1860BA630", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60BA6B0", Offset = "0x60B98B0", VA = "0x1860BA6B0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60BA240", Offset = "0x60B9440", VA = "0x1860BA240", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60BA850", Offset = "0x60B9A50", VA = "0x1860BA850", Slot = "8")]
		public void UpdatePostIKAnimControllers(float NJLEMDJHIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60BA7C0", Offset = "0x60B99C0", VA = "0x1860BA7C0")]
		private void PIGALIHHDKP(GameObject JFJMICPDNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60B9B80", Offset = "0x60B8D80", VA = "0x1860B9B80")]
		private IEOLOCFMODF AGCLNPPNHNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public AvatarFullBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct WeightData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is turned off.")]
			public float AngleOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is fully on.")]
			public float AngleOn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[Tooltip("Normalized height (0-1) where IK is turned off.")]
			public float HeightOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[Tooltip("Normalized height (0-1) where IK is fully on.")]
			public float HeightOn;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x60D4DC0", Offset = "0x60D3FC0", VA = "0x1860D4DC0")]
			public float LPPABOBCLEH(float MDOELGKHKFM, float PIJJBKDHMKP)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Header("Hand Animation")]
		[Tooltip("Time axis is the normalized distance the hand effector currently is from the origin of the upper arm bone.  A time of 0 implies the hand effector is directly on top of the upper arm origin (ie: up at your shoulder), a time = 1, that implies the hand effector is somewhere exactly a full arm's length away, a time of 1.7 implies the hand effector is somewhere exactly 1.7 times the arm's length away.  Value axis is the effector weight from 0 to 1.")]
		public AnimationCurve HandEffectorWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Time that the hand animator weight changes from 0 to 1 in a second. When the hand gesture system turns on when making a gesture, and off when the gesture system is idle, this determines the speed that it lerps towards the target weight.")]
		public float HandAnimatorWeightChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Time it takes to transition to an open or closed hand pose during an animated hand state transition")]
		public float HandOpenCloseChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F5")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Header("IK Weights")]
		[Tooltip("Control data for when to allow IK to control the head position for screens players.")]
		public WeightData ScreenHeadPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Control data for when to allow IK to control the head rotation for screens players.")]
		public WeightData ScreenHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Control data for when to allow IK to control the pelvis position for screens players.")]
		public WeightData ScreenPelvisPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Control data for when to allow IK to control the pelvis rotation for screens players.")]
		public WeightData ScreenPelvisRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Header("VR runtime weights")]
		[Tooltip("The head is moved flat forward with given amount in VR to match up with our animated head position.")]
		public float StaticHeadForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("The animated root is moved flat forward with given amount in VR to match up the physical feet with our animated feet.")]
		public float StaticRootForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Weight for head while moving. (0 = animated, 1 = VR)")]
		public float MovingHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Weight for head while idle. (0 = animated, 1 = VR)")]
		public float IdleHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Max head height offset compensation")]
		public float MaxHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Min head height offset compensation")]
		public float MinHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Head height offset compensation smooth time")]
		public float HeadHeightCompensationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Distance to apply head movement dampening")]
		public float HeadHeightDampeningDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		public float VRShoulderTwistBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60BA9A0", Offset = "0x60B9BA0", VA = "0x1860BA9A0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KAOGFLKAJBN : LKKPLKOKMAK
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static int IPDJGEBCFPM;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static int ABOKPJAFOOC;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int AAJDNMCHFPD;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int HMHACGHJPOL;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int ACKPJDHJJKP;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static int HIPCMIIKNBK;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static int KKCECGAAKMI;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static int MJNGDPFHHCL;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int NGOOCGNABBG;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int[] OFAHIMOGNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	internal bool PCPAOJLMPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private AJGAHKJKILJ BCDCIGPLGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int BKPFKEIBECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private float JEGCELEAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool ELJEKAANABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Animator KPOCLDBJFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private AvatarFullBodyConfiguration OAMGPJAEIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private int MGBKINOEJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int KCACGOLENBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int FNKAMLGOLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool LMLIFDJBMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private ANHIHBDLAKJ FKIKGIEIFGA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform HHJENPGLCCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 DMHIIMLKMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDAFEC0", Offset = "0xDAF0C0", VA = "0x180DAFEC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDAFEB0", Offset = "0xDAF0B0", VA = "0x180DAFEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion ALCFCIPMIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x19E96F0", Offset = "0x19E88F0", VA = "0x1819E96F0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DD6BD0", Offset = "0x1DD5DD0", VA = "0x181DD6BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LMBCPHDDEFH AOOKOOCECHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x110B900", Offset = "0x110AB00", VA = "0x18110B900", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(LMBCPHDDEFH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1151E60", Offset = "0x1151060", VA = "0x181151E60", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LMBCPHDDEFH POIIOPMDLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FC0", Offset = "0x7C01C0", VA = "0x1807C0FC0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(LMBCPHDDEFH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F50", Offset = "0x7C0150", VA = "0x1807C0F50", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public float CFONJFACDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xF0D980", Offset = "0xF0CB80", VA = "0x180F0D980", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB21A80", Offset = "0xB20C80", VA = "0x180B21A80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OGHAJMBBENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60D20C0", Offset = "0x60D12C0", VA = "0x1860D20C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LEEKNDPPPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60D1D10", Offset = "0x60D0F10", VA = "0x1860D1D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NDJMGCOKKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60D17C0", Offset = "0x60D09C0", VA = "0x1860D17C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x60D17D0", Offset = "0x60D09D0", VA = "0x1860D17D0", Slot = "19")]
	public void GEJAFFIMNGM(AJGAHKJKILJ KGGOEHJMBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60D1D70", Offset = "0x60D0F70", VA = "0x1860D1D70", Slot = "20")]
	public void IDBPEGLDJLC(HIEMPHFFMCM NMPOFLKEHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60D19A0", Offset = "0x60D0BA0", VA = "0x1860D19A0", Slot = "11")]
	public void GOHKEIPJBEC(bool COENLOODJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60D1A30", Offset = "0x60D0C30", VA = "0x1860D1A30", Slot = "10")]
	public void HAGACGEOOCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60D1D80", Offset = "0x60D0F80", VA = "0x1860D1D80")]
	private int IGIABDPACPB(LMBCPHDDEFH AMDEINKAGIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60D1F90", Offset = "0x60D1190", VA = "0x1860D1F90")]
	private void PACACMLGPEB(int PBDEPBMAOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60D1F80", Offset = "0x60D1180", VA = "0x1860D1F80", Slot = "12")]
	public bool NDOHLIFFCHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60D1F10", Offset = "0x60D1110", VA = "0x1860D1F10", Slot = "13")]
	public bool IMNPMOLBNID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x60D1F20", Offset = "0x60D1120", VA = "0x1860D1F20")]
	private LMBCPHDDEFH JBNEJIPGOJF()
	{
		return default(LMBCPHDDEFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xDB94C0", Offset = "0xDB86C0", VA = "0x180DB94C0", Slot = "14")]
	public void LCJHGEKLPEG(bool COENLOODJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60D17B0", Offset = "0x60D09B0", VA = "0x1860D17B0", Slot = "9")]
	public void DELHKCCCACG(int PBDEPBMAOPO, float MACMEPEOMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60D1EF0", Offset = "0x60D10F0", VA = "0x1860D1EF0", Slot = "7")]
	public void IMDMABKLANP(ANHIHBDLAKJ OAODOPKGJBP, bool IPJGMHONMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60D1F70", Offset = "0x60D1170", VA = "0x1860D1F70", Slot = "8")]
	public void JOPBNGOOIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60D1D20", Offset = "0x60D0F20", VA = "0x1860D1D20", Slot = "15")]
	public void IBAMBLJJCHD(Transform BHNONFFBKHO, Vector3 HDNGAJIDLBF, Quaternion NCGCNIKIAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60D23B0", Offset = "0x60D15B0", VA = "0x1860D23B0")]
	public KAOGFLKAJBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class BDCFPAKFIEC : IEOLOCFMODF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class LLGGJOMAAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private float KICAPJFCDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Vector3 MAFEHPGMAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private bool DABKFDFANBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float NEHJAKEIMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool ONDNAEPMDFE;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool EPJOILCLJKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x60D2D40", Offset = "0x60D1F40", VA = "0x1860D2D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x60D2FD0", Offset = "0x60D21D0", VA = "0x1860D2FD0")]
		public void FMOBBPNJOPI(IKSolverVR.Arm NALHHKEHOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x60D36A0", Offset = "0x60D28A0", VA = "0x1860D36A0")]
		public void PFJJAPMDLBM(IKSolverVR.Arm NALHHKEHOOA, Transform FOACIKIOFGC, bool IJGOHFHFBFE, AvatarFullBodyConfiguration GPNOOFEABCC, float EBOAFAHMELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x60D2D60", Offset = "0x60D1F60", VA = "0x1860D2D60")]
		public void FIOIBODNKKN(IKSolverVR.Arm NALHHKEHOOA, bool ICDCIBEKNAC, bool ONDNAEPMDFE, AvatarFullBodyConfiguration GPNOOFEABCC, float EBOAFAHMELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x60D2A90", Offset = "0x60D1C90", VA = "0x1860D2A90")]
		private void EELIDFEJGPN(Transform FOACIKIOFGC, IKSolverVR.Arm NALHHKEHOOA, float KLGNPOEHDPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60D2B80", Offset = "0x60D1D80", VA = "0x1860D2B80")]
		private void EFFIKOMPADJ(bool IJGOHFHFBFE, AvatarFullBodyConfiguration GPNOOFEABCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x60D2570", Offset = "0x60D1770", VA = "0x1860D2570")]
		private void BLLBJELFLFC(AvatarFullBodyConfiguration GPNOOFEABCC, float EBOAFAHMELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x60D35D0", Offset = "0x60D27D0", VA = "0x1860D35D0")]
		private void JEDOKBMPMEF(IKSolverVR.Arm NALHHKEHOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60D2E10", Offset = "0x60D2010", VA = "0x1860D2E10")]
		public void FJLHOFKNDLE(IKSolverVR.Arm NALHHKEHOOA, Transform AANKDJEMGCD, Transform CGHJKPDCCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x60D2600", Offset = "0x60D1800", VA = "0x1860D2600")]
		private (Vector3, Quaternion) DKKKIOOPNPD(KAOGFLKAJBN PPICJBFOMIB, Quaternion BCKJCIHDBDO, Vector3 FHEJBMHFJLB)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x60D2BF0", Offset = "0x60D1DF0", VA = "0x1860D2BF0")]
		public void EMKKFCBJOAM(KAOGFLKAJBN PPICJBFOMIB, IKSolverVR.Arm NALHHKEHOOA, Quaternion BCKJCIHDBDO, Vector3 FHEJBMHFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x60D3000", Offset = "0x60D2200", VA = "0x1860D3000")]
		public void IPKEHEFFHFB(KAOGFLKAJBN PPICJBFOMIB, IKSolverVR.Arm NALHHKEHOOA, Quaternion BCKJCIHDBDO, Vector3 FHEJBMHFJLB, AvatarFullBodyConfiguration GPNOOFEABCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60D3610", Offset = "0x60D2810", VA = "0x1860D3610")]
		private static float PENLOHFEHPJ(bool FFABKOCEGNL, float EKJLIEFFPDC, float DMEOAMPKDJO, float CKGCIBBAICI, float EBOAFAHMELN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x60D23C0", Offset = "0x60D15C0", VA = "0x1860D23C0")]
		private static void APMKMNGIAMF(Transform NEIABLGNCNH, Transform JKFKFNIGMKM, Transform MBEOGHFKJEA, float LFNHGBPFPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LLGGJOMAAOJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private enum GICNEIAHAAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum PKBPIIABFJN
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int BLEFGJIKOLG;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int GJLEGOEJLCB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int BHLANPCBOHN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int HEKHLOHONIJ;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int DPEPOJNCLJP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int OJDNLILPFJD;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int EOFMLNGJDIL;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int KNIIKBLJHOJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int BIGHHPNDMIK;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int EMEGEALDAAD;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int AIEFEBCDECN;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int NBLPHFCCDIM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int BMLELDBNNDF;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int MJMPNEMKOBM;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int ONJCKEGBBFE;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int DHOBJMIDLGE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int DLGGDKEJGMJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int ANLMFFFOPON;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int HMBCMINDEKO;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int DOEMDNJDBEK;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int PCAAAIHCACB;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int NFMLNLFFLLJ;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int GPGGOILJBKH;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int GEOGECKKLNE;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int IOBMOKNJCHB;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int DBFOFDHHEPC;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int JJAAMINKEKA;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int FNCNEPJIJGP;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int BNEBEIPDDLN;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int IBACAFDNFCN;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly Vector3 AIOMCDOBADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private bool DKHHPDGGIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool AJEGOJOKGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool NKDOJEIJECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool JBJGACCKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool EKPEMEFEJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Vector3 NPKMBBGEHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GIIKNCDPPAL? BCDCIGPLGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private OGOAPAFAKJA? LOFGBGOEOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private HCEFILIJBHC CONBGMJOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private LIKLDOOMCKF OHFAKHMGFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private KAOGFLKAJBN DCMOKIOBKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private KAOGFLKAJBN BAIJEGCFMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool ECPIGBACPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private bool BGMDECIAEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly CLHMFDHGOPK DGMHDIDIDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly JGLPKGBAOIE GFFLIMPIALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private int MHOJHEMMLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float BKABGALAJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private GameObject CODLGICBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Transform GPFHMNGLBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Transform MGEMOGPLDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private float KKDHGDNDPAK;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker EDELEDCEGJA;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker OONDKBMAEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private ProfilerMarker FKIMKENLFJM;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker OFCJIDEGFOC;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly ProfilerMarker CPIAHNIJGKG;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ProfilerMarker KMFIELJCDAK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly List<BDCFPAKFIEC> JFMJKIAGIGE;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int APPAFBANJHK;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> JLBOKCEDAJM;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int FOHNNNBLLCL;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static int DCDGHCPAOCL;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int LNKHKDEBGBC;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int MOCLAIENLBM;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float BLFMBMGMPMG;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int AHDPAKGLDND;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float PEOFMFIJJHN;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static float JAEDBNMBHDL;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float KMFFDBAFMDK;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static float IGCBOJMHOCA;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static KFIFHPIGMID CFNNHPNIBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private float MJPDJPNHLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool IILFNBFMGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float EKODKJGDHPF;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Quaternion LHAKMCNGFAO;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Quaternion FAEKGNKEIOP;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Vector3 KNFHJCCHEOD;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly Vector3 MLGMPGBOBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private LLGGJOMAAOJ DPNJJICLBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private LLGGJOMAAOJ JOMOMCPDNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private GICNEIAHAAH IKOMBIFGFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private float MJLGHAPPHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly ICMHMCNCIAJ NFOAAOCKNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float OFEFHKDAHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float KFLAOJHIFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Vector3 NHOMJPLLOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly DDPIEKPOECH LNGHBAKBJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly GKOINNCAGKG GKDABLGLMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float DAPHGHLJIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private GICNEIAHAAH PMGPKBJFAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private Vector3 HHKPCMICELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float PGOBJNDFMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float IJGFMNFKPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private MLIGNBHMBPJ KGDFFDMAMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private DDPIEKPOECH AFFCIHPNEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly DDPIEKPOECH DJMOGOCDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly MLIGNBHMBPJ AGDGGCENNNJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AGKHEGBIBIG BMGABHAOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public AGKHEGBIBIG PMGFJMCFAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public AvatarConfiguration IMEADHKJGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60C2570", Offset = "0x60C1770", VA = "0x1860C2570", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AvatarFullBodyConfiguration ANCCKLJKBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60CAFC0", Offset = "0x60CA1C0", VA = "0x1860CAFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Transform KDICJNFEBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x60BFCF0", Offset = "0x60BEEF0", VA = "0x1860BFCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Transform JMOCHNDFNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x60BE220", Offset = "0x60BD420", VA = "0x1860BE220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private SkinnedMeshRenderer CPPOALCIFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60CC4E0", Offset = "0x60CB6E0", VA = "0x1860CC4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Renderer[] KNOFCOGHAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x60BFDC0", Offset = "0x60BEFC0", VA = "0x1860BFDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private GameObject[] NADCJFGDNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x60C1A70", Offset = "0x60C0C70", VA = "0x1860C1A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Animator KDLJKFMNEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60BCB10", Offset = "0x60BBD10", VA = "0x1860BCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private VRIK CJCHLKGGPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x60BF240", Offset = "0x60BE440", VA = "0x1860BF240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private DEDCNPEEKIN FFOIFPKFBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60BCCB0", Offset = "0x60BBEB0", VA = "0x1860BCCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private DEDCNPEEKIN MGHGOMHKMII
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60C2890", Offset = "0x60C1A90", VA = "0x1860C2890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private DEDCNPEEKIN KLDCHBJDGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60BCBE0", Offset = "0x60BBDE0", VA = "0x1860BCBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private DEDCNPEEKIN JJGMJIHGJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x60CA220", Offset = "0x60C9420", VA = "0x1860CA220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private DEDCNPEEKIN CJNKHNECBJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60CBC30", Offset = "0x60CAE30", VA = "0x1860CBC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private DEDCNPEEKIN DNLLKHIJCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x60C9BC0", Offset = "0x60C8DC0", VA = "0x1860C9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private DEDCNPEEKIN KAGKPGGKNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60CB050", Offset = "0x60CA250", VA = "0x1860CB050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private DEDCNPEEKIN GJGBFMCAOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60BEC40", Offset = "0x60BDE40", VA = "0x1860BEC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public OGOAPAFAKJA PPHGMCJJCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x60CA0F0", Offset = "0x60C92F0", VA = "0x1860CA0F0", Slot = "32")]
		get
		{
			return default(OGOAPAFAKJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IJFEPFDLJEB FIBBOAEABPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8C7040", Offset = "0x8C6240", VA = "0x1808C7040", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HFDBPGFHIMN NJJJAJEDLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4A750", Offset = "0xA49950", VA = "0x180A4A750", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LKKPLKOKMAK KKKIAPHPDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD7CF00", Offset = "0xD7C100", VA = "0x180D7CF00", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public LKKPLKOKMAK NMKMFLFELMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA50AB0", Offset = "0xA4FCB0", VA = "0x180A50AB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public GameObject OPEBICILKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60C19D0", Offset = "0x60C0BD0", VA = "0x1860C19D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Transform MAKMDKIHPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA2E3C0", Offset = "0xA2D5C0", VA = "0x180A2E3C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Transform PCJKLHGOEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9BAAE0", Offset = "0x9B9CE0", VA = "0x1809BAAE0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Vector3 HBCELDMGJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60BF310", Offset = "0x60BE510", VA = "0x1860BF310", Slot = "29")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float JJBFLHNDBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60C2640", Offset = "0x60C1840", VA = "0x1860C2640", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform AFACNEFAGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60C2830", Offset = "0x60C1A30", VA = "0x1860C2830", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool IBGJLAKAIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60BCAB0", Offset = "0x60BBCB0", VA = "0x1860BCAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool JCCEGNFJBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60C1160", Offset = "0x60C0360", VA = "0x1860C1160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60C34F0", Offset = "0x60C26F0", VA = "0x1860C34F0")]
	private void HNDJLLPBBGI([In] PFBGDBKBFGA GDCNKDNBIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60C84F0", Offset = "0x60C76F0", VA = "0x1860C84F0")]
	private void KNFNNANPKJN(PFBGDBKBFGA GDCNKDNBIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60C2670", Offset = "0x60C1870", VA = "0x1860C2670")]
	private void HAGACGEOOCA(OOHLGGPEONB ELDHMKMFOMH, LKKPLKOKMAK BECNKFKFKBA, IKSolverVR.Arm NALHHKEHOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60BC5F0", Offset = "0x60BB7F0", VA = "0x1860BC5F0")]
	private void AIMFBMMLELC([In] PFBGDBKBFGA OAODOPKGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60CD5F0", Offset = "0x60CC7F0", VA = "0x1860CD5F0")]
	public BDCFPAKFIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60C90C0", Offset = "0x60C82C0", VA = "0x1860C90C0", Slot = "12")]
	public void MDOMBAFJKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60CC9C0", Offset = "0x60CBBC0", VA = "0x1860CC9C0", Slot = "13")]
	public void PPIBFANBPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60C5EF0", Offset = "0x60C50F0", VA = "0x1860C5EF0", Slot = "14")]
	public void IMMHIBOJBCN(bool GIBBHDOPMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60BDAC0", Offset = "0x60BCCC0", VA = "0x1860BDAC0", Slot = "22")]
	public Transform COFOOLNKBFO(string KNKAHCDGFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60BC460", Offset = "0x60BB660", VA = "0x1860BC460", Slot = "23")]
	public Vector3? AEDKCMLFKML(string KNKAHCDGFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60CBDC0", Offset = "0x60CAFC0", VA = "0x1860CBDC0", Slot = "7")]
	public void PFIKNBNDODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60C5380", Offset = "0x60C4580", VA = "0x1860C5380", Slot = "6")]
	public void IFFEOKPKKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60BDA50", Offset = "0x60BCC50", VA = "0x1860BDA50", Slot = "8")]
	public void CLPHHPBAJNF(float PGNGAMHLLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60BDA00", Offset = "0x60BCC00", VA = "0x1860BDA00")]
	private void CLCGGMNGBGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60C67C0", Offset = "0x60C59C0", VA = "0x1860C67C0", Slot = "4")]
	public void KDGFJBCPLEH(GIIKNCDPPAL JLGMMNIBEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE00", Offset = "0x60BE000", VA = "0x1860BEE00", Slot = "5")]
	public void EFKKNAFDKDN(OGOAPAFAKJA NMPOFLKEHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60BED10", Offset = "0x60BDF10", VA = "0x1860BED10", Slot = "11")]
	public void EDLINPBGFHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x60C0970", Offset = "0x60BFB70", VA = "0x1860C0970", Slot = "21")]
	public void FHPHDMDCGCD([Out] Vector3 FFKPEGHDHPK, [Out] Quaternion ANMLDFDLOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60C8400", Offset = "0x60C7600", VA = "0x1860C8400", Slot = "24")]
	public void KJAIDEJCGEH(float MICEFNCEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60BC870", Offset = "0x60BBA70", VA = "0x1860BC870", Slot = "25")]
	public HandLogicOffsets AJNLMIMICEG()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60C6700", Offset = "0x60C5900", VA = "0x1860C6700", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets KDFAJMGGKCD()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60CBD00", Offset = "0x60CAF00", VA = "0x1860CBD00")]
	private void PFEKEPAFAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60BCD80", Offset = "0x60BBF80", VA = "0x1860BCD80")]
	private void CHEDGLHLDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60C7F40", Offset = "0x60C7140", VA = "0x1860C7F40")]
	private void KHDJMNIIOLE(IHMHPNACLKD EMIICAINDDG, bool BGMNOFHPMFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x60BC920", Offset = "0x60BBB20", VA = "0x1860BC920")]
	private void AMPHBOAAGPF(IHMHPNACLKD EMIICAINDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60C84A0", Offset = "0x60C76A0", VA = "0x1860C84A0")]
	public Vector3 KMHNPCEKEMM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60C8390", Offset = "0x60C7590", VA = "0x1860C8390")]
	private void KIMJBIGGJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60BFB50", Offset = "0x60BED50", VA = "0x1860BFB50")]
	private float ELMDIJMNAOJ([In] PFBGDBKBFGA OAODOPKGJBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x60C7E60", Offset = "0x60C7060", VA = "0x1860C7E60")]
	private int KGNOMCKENEH([In] GBMEAJEBBIB AKGPNNIHPBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60C49B0", Offset = "0x60C3BB0", VA = "0x1860C49B0")]
	private void IBFFLDJIALG(PFBGDBKBFGA GDCNKDNBIGI, bool EGCJHOCEJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60C0E50", Offset = "0x60C0050", VA = "0x1860C0E50")]
	private static void FLGLCEMFCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x60C2960", Offset = "0x60C1B60", VA = "0x1860C2960")]
	private static void HFHNPDNICND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x60BD170", Offset = "0x60BC370", VA = "0x1860BD170")]
	private float CJGLOPIIAIG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x60C2800", Offset = "0x60C1A00", VA = "0x1860C2800")]
	private static int HBOGJPKPIJL(BDCFPAKFIEC EBKLEGBLPGD, BDCFPAKFIEC JCPNHMOLDGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x60C1B40", Offset = "0x60C0D40", VA = "0x1860C1B40")]
	private void GNLJAGMGJHI(PFBGDBKBFGA OAODOPKGJBP, AvatarFullBodyConfiguration GPNOOFEABCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60C0D10", Offset = "0x60BFF10", VA = "0x1860C0D10")]
	private void FJLHOFKNDLE([In] PFBGDBKBFGA OAODOPKGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60C4EE0", Offset = "0x60C40E0", VA = "0x1860C4EE0")]
	private void IFFADNHDGJG([In] PFBGDBKBFGA OAODOPKGJBP, [In] AvatarFullBodyConfiguration GPNOOFEABCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x60C5FC0", Offset = "0x60C51C0", VA = "0x1860C5FC0")]
	private void JEJFGNKODDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60BDC10", Offset = "0x60BCE10", VA = "0x1860BDC10")]
	private void DEONOOKELFL([In] PFBGDBKBFGA OAODOPKGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x60C80C0", Offset = "0x60C72C0", VA = "0x1860C80C0")]
	public void KHJKHNHCFFL(RigidbodyEx LDHMNLLBFHP, IKSolverVR.Arm NALHHKEHOOA, Quaternion BCKJCIHDBDO, Vector3 FHEJBMHFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x60CA8E0", Offset = "0x60C9AE0", VA = "0x1860CA8E0")]
	private float OJCPGDJIPAO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x60BE2F0", Offset = "0x60BD4F0", VA = "0x1860BE2F0")]
	private void DLGHJNMNKKF([In] PFBGDBKBFGA OAODOPKGJBP, [In] PKBPIIABFJN FMJJLOIHMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x60CA2F0", Offset = "0x60C94F0", VA = "0x1860CA2F0")]
	private void ODGKAGBHLBM(PFBGDBKBFGA OAODOPKGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x60C7E40", Offset = "0x60C7040", VA = "0x1860C7E40")]
	private void KGANKNEBCCL(GICNEIAHAAH PNCPNEFKHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x60BFE90", Offset = "0x60BF090", VA = "0x1860BFE90")]
	private void FAELLDABIMO(float MGCHFHBDADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60BD2C0", Offset = "0x60BC4C0", VA = "0x1860BD2C0")]
	private void CKBAEADFFFI([In] PFBGDBKBFGA OAODOPKGJBP, PKBPIIABFJN FMJJLOIHMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60C85A0", Offset = "0x60C77A0", VA = "0x1860C85A0")]
	private Vector3 LCEGILMJGAD([In] PFBGDBKBFGA OAODOPKGJBP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x60C6320", Offset = "0x60C5520", VA = "0x1860C6320")]
	private float KBCDKIEOMIP(float OBJFJFCCICA, [In] PFBGDBKBFGA OAODOPKGJBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60C8480", Offset = "0x60C7680", VA = "0x1860C8480")]
	private void KJPJFJPKIME(GICNEIAHAAH PNCPNEFKHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x60BF350", Offset = "0x60BE550", VA = "0x1860BF350")]
	private void EKBEBPLPOGI(float OBJFJFCCICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x60C03D0", Offset = "0x60BF5D0", VA = "0x1860C03D0")]
	private void FGMLMENCNJK([In] PFBGDBKBFGA OAODOPKGJBP, PKBPIIABFJN FMJJLOIHMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x60CC5B0", Offset = "0x60CB7B0", VA = "0x1860CC5B0")]
	private float PKLKJLCNHFK([In] PFBGDBKBFGA GDCNKDNBIGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x60CB710", Offset = "0x60CA910", VA = "0x1860CB710")]
	private void PBMBLLNIKAF(PFBGDBKBFGA OAODOPKGJBP, PKBPIIABFJN FMJJLOIHMIM, Vector3 CFDIJELFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x60C6170", Offset = "0x60C5370", VA = "0x1860C6170")]
	private static void JKHGCLNBJPC(Transform GCDMIBEHAIO, Quaternion HBCECKEGCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x60BE910", Offset = "0x60BDB10", VA = "0x1860BE910")]
	private void DMLBACELKBF([In] PFBGDBKBFGA NMMDDNBHBPO, [In] GBMEAJEBBIB AKGPNNIHPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x60BF4A0", Offset = "0x60BE6A0", VA = "0x1860BF4A0")]
	private void ELDHGKBLFJI([In] PFBGDBKBFGA NMMDDNBHBPO, [In] GBMEAJEBBIB AKGPNNIHPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x60CA960", Offset = "0x60C9B60", VA = "0x1860CA960")]
	private void OKINLGGICFG([In] PFBGDBKBFGA OAODOPKGJBP, [In] AvatarFullBodyConfiguration GPNOOFEABCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x60CA640", Offset = "0x60C9840", VA = "0x1860CA640")]
	public void OIHPHGLJOLM([In] PFBGDBKBFGA OAODOPKGJBP, [In] AvatarFullBodyConfiguration GPNOOFEABCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x60CB120", Offset = "0x60CA320", VA = "0x1860CB120", Slot = "33")]
	protected virtual void PAGOMHAIIGP([In] PFBGDBKBFGA OAODOPKGJBP, [In] AvatarFullBodyConfiguration GPNOOFEABCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60C00A0", Offset = "0x60BF2A0", VA = "0x1860C00A0")]
	private void FBJLMHEPODF([In] PFBGDBKBFGA OAODOPKGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x60C9C90", Offset = "0x60C8E90", VA = "0x1860C9C90")]
	private void MNFGPLCLDAM(float KNDLGEMHOGB, [In] PFBGDBKBFGA GDCNKDNBIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x60C9530", Offset = "0x60C8730", VA = "0x1860C9530")]
	private float MJPILLDFOJJ([In] PFBGDBKBFGA GDCNKDNBIGI, [In] AvatarFullBodyConfiguration GPNOOFEABCC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x60BDE80", Offset = "0x60BD080", VA = "0x1860BDE80")]
	private void DHKOPDNPLCE([In] PFBGDBKBFGA GDCNKDNBIGI, [In] AvatarFullBodyConfiguration GPNOOFEABCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x60C7A80", Offset = "0x60C6C80", VA = "0x1860C7A80")]
	private void KFGIEKMOLCA([In] PFBGDBKBFGA GDCNKDNBIGI, float OLFOCGNDEMJ, float NFDFNEDHBNK, Vector3 FLLELCPFDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x60C11E0", Offset = "0x60C03E0", VA = "0x1860C11E0")]
	private void GEANFBFDKHG(PFBGDBKBFGA GDCNKDNBIGI, AvatarFullBodyConfiguration GPNOOFEABCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x60C1060", Offset = "0x60C0260", VA = "0x1860C1060")]
	[CompilerGenerated]
	internal static bool FMFABOBJMOD(IKSolverVR.Arm NALHHKEHOOA, JDAFONDFDAH NPMNADLBLDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x60C8C80", Offset = "0x60C7E80", VA = "0x1860C8C80")]
	[CompilerGenerated]
	internal static float LNFINNABMAI(Vector3 BNAMLLFGJGL, Vector3 LEHCOOBOPOJ, Vector3 AHFNMFGPKAB, PFBGDBKBFGA GDCNKDNBIGI, AvatarFullBodyConfiguration GPNOOFEABCC, float BJPGLMJPACN)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum NCMHECJPNBG
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private NCMHECJPNBG handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x60BAC80", Offset = "0x60B9E80", VA = "0x1860BAC80")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60BAC40", Offset = "0x60B9E40", VA = "0x1860BAC40")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x60BACB0", Offset = "0x60B9EB0", VA = "0x1860BACB0")]
		private void PEHGKGDLBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x11B0420", Offset = "0x11AF620", VA = "0x1811B0420", Slot = "4")]
		public void SetEnabled(bool FFABKOCEGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x60BB2B0", Offset = "0x60BA4B0", VA = "0x1860BB2B0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, DEDCNPEEKIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Vector3 APJFHOJEEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Vector3 FJDNCFIGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3 OAIDJKBPFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Matrix4x4 ABFLLIBFJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private bool GDDCMPALELP;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x60BB740", Offset = "0x60BA940", VA = "0x1860BB740", Slot = "4")]
		public void UpdateController(float NJLEMDJHIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FE57D0", Offset = "0x5FE49D0", VA = "0x185FE57D0", Slot = "6")]
		public void SetEnabled(bool NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60BB2E0", Offset = "0x60BA4E0", VA = "0x1860BB2E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60BBE00", Offset = "0x60BB000", VA = "0x1860BBE00")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
internal class GMDLHBJAPPF : CPMMAIJDDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Dictionary<string, IEOLOCFMODF> OCNJIPPPLLL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OPAFIBPMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60CFBB0", Offset = "0x60CEDB0", VA = "0x1860CFBB0")]
	[KEFCCLBEAOJ(BDECECCJEGA.Root, CMEECPGEPNF.None)]
	private static void LIAJFILJAFN(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x60CF9F0", Offset = "0x60CEBF0", VA = "0x1860CF9F0", Slot = "4")]
	public IEOLOCFMODF LHJEHKIFHIL(string JKCMOJBMPEE, AvatarSystemConfiguration NKBMLGBCELO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x60CF870", Offset = "0x60CEA70", VA = "0x1860CF870", Slot = "5")]
	public void JICPHHJFLCH(string JKCMOJBMPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x60CFC20", Offset = "0x60CEE20", VA = "0x1860CFC20")]
	public GMDLHBJAPPF()
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
		public class COEEAFLEAHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private Dictionary<string, Transform> LKNFHBPEPGK;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public bool PPFMDOGEELH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x60CF680", Offset = "0x60CE880", VA = "0x1860CF680")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x60CF550", Offset = "0x60CE750", VA = "0x1860CF550")]
			public void CNCKPPOJBGC(VRIK EEHGMPFFEFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
			public void JCACMPDMKDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x60CF6C0", Offset = "0x60CE8C0", VA = "0x1860CF6C0")]
			public void MNHGCJGIAKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x60CF710", Offset = "0x60CE910", VA = "0x1860CF710")]
			public COEEAFLEAHJ()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		[JCPFEOHJOPF(OILHINDHMGI.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		[MGMFHFICAPM(OILHINDHMGI.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly COEEAFLEAHJ CKMDPFHEDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private KDOLBPHPHCA OJBBLMKEJAK;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60BBE60", Offset = "0x60BB060", VA = "0x1860BBE60")]
		private void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x60BBE10", Offset = "0x60BB010", VA = "0x1860BBE10")]
		private bool EPBCHOLPBLG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60BC120", Offset = "0x60BB320", VA = "0x1860BC120")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x60BC190", Offset = "0x60BB390", VA = "0x1860BC190")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60BC130", Offset = "0x60BB330", VA = "0x1860BC130")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x60BC380", Offset = "0x60BB580", VA = "0x1860BC380")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60D4A90", Offset = "0x60D3C90", VA = "0x1860D4A90", Slot = "4")]
		public override void OnStateEnter(Animator KJDCHCBHFCE, AnimatorStateInfo OHHJFFCLPHF, int ILAOAFLMAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60D4BB0", Offset = "0x60D3DB0", VA = "0x1860D4BB0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal abstract class KKKOLOAKPMC<TInput, TOutput> : POBGBBHJFFJ<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected readonly IAFPOFNODCF POMHMEMGNEJ;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BF30", Offset = "0x3C9B130", VA = "0x183C9BF30")]
	protected KKKOLOAKPMC(IAFPOFNODCF POMHMEMGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput LKMADFBDLGL(TInput CCAOJBHBKKC, [Out] IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BE90", Offset = "0x3C9B090", VA = "0x183C9BE90", Slot = "5")]
	public bool EPBFGIHPCIL(TInput CCAOJBHBKKC, [Out] TOutput? HCIDHCBMOPD, [Out] IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[PJKEGBNMNOG]
public static class AGCJEPCHIBG
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly Regex EMCKPMEIKJD;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x60B6F10", Offset = "0x60B6110", VA = "0x1860B6F10")]
	public static INBOAHIBCAN IKLNNBMFKAP(JEAGJPCCODB HFCAFJFHAKA, HNNJKOJEHLP OGHOIOJGABP, Guid? CDMGLKIMINO, Color? BLHHKPJDPEH, BKAHNFPJFDO IHALIDJJKLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x60B6E60", Offset = "0x60B6060", VA = "0x1860B6E60")]
	public static KJPHDDIDNHP HHLNCJMKPLA(INBOAHIBCAN FODGEDCJIDC)
	{
		return default(KJPHDDIDNHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F0FBC0", Offset = "0x2F0EDC0", VA = "0x182F0FBC0")]
	internal static TModern? OMDCCHOBKDI<TModern>(string? CCAOJBHBKKC, LIAFPDFNCIE<TModern> FAMFDCGKBNJ, IAFPOFNODCF POMHMEMGNEJ, HODHEABJAKE AAMMDLAGOBL, TModern EIIIEAODADF) where TModern : struct, CMCGFHCJJCJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E580", Offset = "0x2F0D780", VA = "0x182F0E580")]
	internal static MCFJBICOLMG CCOHKAJIDFL<TModern>(string? CCAOJBHBKKC, LIAFPDFNCIE<TModern> FAMFDCGKBNJ, IAFPOFNODCF POMHMEMGNEJ, HODHEABJAKE AAMMDLAGOBL, TModern EIIIEAODADF) where TModern : struct, CMCGFHCJJCJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x60B7120", Offset = "0x60B6320", VA = "0x1860B7120")]
	internal static List<HFBGONFPNON> OHODJEJGLMM(IEnumerable<FIHCBNIDAFK>? BEPBCDOHEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2F0ED10", Offset = "0x2F0DF10", VA = "0x182F0ED10")]
	internal static string IAHMHDDOACE<TModern>(TModern CCAOJBHBKKC, LIAFPDFNCIE<TModern> FAMFDCGKBNJ, IAFPOFNODCF POMHMEMGNEJ) where TModern : CMCGFHCJJCJ
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class ABLFLMMBALG : HABOMOHKGPC
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public POBGBBHJFFJ<GELLIPBGBMO, AOFLEHDOPCJ> GJPBOAEDOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public POBGBBHJFFJ<BFPIHMHLCFF, GKIPOKNIJNA> HELMJBKMECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public POBGBBHJFFJ<BFPIHMHLCFF, GKIPOKNIJNA> BHNLCMFNLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KEKBFKPKMIE EPGFNLILIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CCBFKBDLHFH IFLAIOCOIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x60B6C20", Offset = "0x60B5E20", VA = "0x1860B6C20")]
	[UsedImplicitly]
	[KEFCCLBEAOJ(BDECECCJEGA.Root, CMEECPGEPNF.GameOnly)]
	private static void OKKCFKPEANH(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60B6C90", Offset = "0x60B5E90", VA = "0x1860B6C90")]
	[Preserve]
	internal ABLFLMMBALG([GAGPBLHNPNO("UnitySerialization")] OBFONIMKKPC ADJPPOMJDHJ, [GAGPBLHNPNO(null)] GPOLAKEALAF DCBDMMLDONE, [GAGPBLHNPNO(null)] IAFPOFNODCF POMHMEMGNEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum JOBFBFPEEEE
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FNFPJDOBFBN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x60CF7D0", Offset = "0x60CE9D0", VA = "0x1860CF7D0")]
	public FNFPJDOBFBN(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x60CF840", Offset = "0x60CEA40", VA = "0x1860CF840")]
	public FNFPJDOBFBN(string JGNAJPMGGNE, Exception EBFLENHEHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60CF7A0", Offset = "0x60CE9A0", VA = "0x1860CF7A0")]
	public FNFPJDOBFBN(JOBFBFPEEEE HALDHGGLICI, string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60CF800", Offset = "0x60CEA00", VA = "0x1860CF800")]
	public FNFPJDOBFBN(JOBFBFPEEEE HALDHGGLICI, string JGNAJPMGGNE, Exception EBFLENHEHHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class HABAGOLFKLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly OBFONIMKKPC ADJPPOMJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	protected readonly GPOLAKEALAF DCBDMMLDONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	protected readonly IAFPOFNODCF POMHMEMGNEJ;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x60D1630", Offset = "0x60D0830", VA = "0x1860D1630")]
	protected HABAGOLFKLK(OBFONIMKKPC ADJPPOMJDHJ, GPOLAKEALAF DCBDMMLDONE, IAFPOFNODCF POMHMEMGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60D0350", Offset = "0x60CF550", VA = "0x1860D0350")]
	protected string OMIOKJACHGK(AOFLEHDOPCJ MEBPEONDLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60CFDF0", Offset = "0x60CEFF0", VA = "0x1860CFDF0")]
	protected string FOLJDGHPMLM(AOFLEHDOPCJ MEBPEONDLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60CFFE0", Offset = "0x60CF1E0", VA = "0x1860CFFE0")]
	private AvatarOutfitSelectionData IKLNNBMFKAP(INBOAHIBCAN ADPHEGNKABI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60CFCB0", Offset = "0x60CEEB0", VA = "0x1860CFCB0")]
	private static AvatarCustomizationSettingsData.AnchorParams FIFDIPHDKOK(BONMPAHMNCG? FMKJDDCLFDE)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface POBGBBHJFFJ<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput LKMADFBDLGL(TInput CCAOJBHBKKC, [Out] IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EPBFGIHPCIL(TInput CCAOJBHBKKC, [Out] TOutput? HCIDHCBMOPD, [Out] IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HABOMOHKGPC
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	POBGBBHJFFJ<GELLIPBGBMO, AOFLEHDOPCJ> GJPBOAEDOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	POBGBBHJFFJ<BFPIHMHLCFF, GKIPOKNIJNA> BHNLCMFNLMP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	KEKBFKPKMIE EPGFNLILIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal enum HODHEABJAKE
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface CCBFKBDLHFH
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHOHMHKFKBC OHDBDPJBHPM(AOFLEHDOPCJ FODGEDCJIDC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KEKBFKPKMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFPIHMHLCFF OHDBDPJBHPM(AOFLEHDOPCJ FODGEDCJIDC, int ICAOGBDNOMB, string? IKEFBMMMAJB, string? DJEJNPJICEK, AMGJHJOBMLJ DOGLIFIFMAK, List<HFBGONFPNON>? BHMNFPCHDPJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[PJKEGBNMNOG]
internal class EHFONAEJMML : KKKOLOAKPMC<GELLIPBGBMO, AOFLEHDOPCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly GPOLAKEALAF DCBDMMLDONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly ILKJKFIPABJ IFMLBIIJLEC;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60D5F10", Offset = "0x60D5110", VA = "0x1860D5F10")]
	public EHFONAEJMML(OBFONIMKKPC ADJPPOMJDHJ, GPOLAKEALAF DCBDMMLDONE, IAFPOFNODCF POMHMEMGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60D5C70", Offset = "0x60D4E70", VA = "0x1860D5C70", Slot = "6")]
	public override AOFLEHDOPCJ LKMADFBDLGL(GELLIPBGBMO CCAOJBHBKKC, [Out] IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Preserve]
internal class OJKFDDHLLNC : OBFONIMKKPC
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class IEIMNKBFKLL : JsonConverter<MCFJBICOLMG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x60D6BC0", Offset = "0x60D5DC0", VA = "0x1860D6BC0", Slot = "9")]
		public override void WriteJson(JsonWriter KPDGEKKKOHO, MCFJBICOLMG? NICEPFIEJED, JsonSerializer EOAKDGCPOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x60D6AA0", Offset = "0x60D5CA0", VA = "0x1860D6AA0", Slot = "10")]
		public override MCFJBICOLMG ReadJson(JsonReader CAMFAGAEHOD, Type JKKGCIBOIGN, MCFJBICOLMG? ACKGLCOKGEB, bool LFOPONGFMEC, JsonSerializer EOAKDGCPOJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x60D6C60", Offset = "0x60D5E60", VA = "0x1860D6C60")]
		public IEIMNKBFKLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class NGNMEGLAAAA : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool ALFFPDHDNEB
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x60D9630", Offset = "0x60D8830", VA = "0x1860D9630", Slot = "5")]
		public override object ReadJson(JsonReader CAMFAGAEHOD, Type JKKGCIBOIGN, object? ACKGLCOKGEB, JsonSerializer EOAKDGCPOJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x60D9450", Offset = "0x60D8650", VA = "0x1860D9450", Slot = "6")]
		public override bool CanConvert(Type JKKGCIBOIGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x60D9690", Offset = "0x60D8890", VA = "0x1860D9690", Slot = "4")]
		public override void WriteJson(JsonWriter KPDGEKKKOHO, object? NICEPFIEJED, JsonSerializer EOAKDGCPOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60D9270", Offset = "0x60D8470", VA = "0x1860D9270")]
		private static bool CMCGEIDIBIE(object NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public NGNMEGLAAAA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly JsonSerializerSettings NIAAPCOCKNI;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60D9770", Offset = "0x60D8970", VA = "0x1860D9770")]
	internal OJKFDDHLLNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AE30", Offset = "0x2A4A030", VA = "0x182A4AE30", Slot = "4")]
	public string DMFMBGMEHCJ<T>(T JFJMICPDNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AE90", Offset = "0x2A4A090", VA = "0x182A4AE90", Slot = "5")]
	public T HPAFFOKLMJA<T>(string NICEPFIEJED)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class DMCFLLMLBFM : OBFONIMKKPC
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x275C6A0", Offset = "0x275B8A0", VA = "0x18275C6A0", Slot = "4")]
	public string DMFMBGMEHCJ<T>(T JFJMICPDNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x275C700", Offset = "0x275B900", VA = "0x18275C700", Slot = "5")]
	public T HPAFFOKLMJA<T>(string NICEPFIEJED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public DMCFLLMLBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[PJKEGBNMNOG]
internal class ILKJKFIPABJ : KKKOLOAKPMC<BFPIHMHLCFF, GKIPOKNIJNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly OBFONIMKKPC ADJPPOMJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly GPOLAKEALAF DCBDMMLDONE;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60D9130", Offset = "0x60D8330", VA = "0x1860D9130")]
	public ILKJKFIPABJ(OBFONIMKKPC ADJPPOMJDHJ, GPOLAKEALAF DCBDMMLDONE, IAFPOFNODCF POMHMEMGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60D8080", Offset = "0x60D7280", VA = "0x1860D8080", Slot = "6")]
	public override GKIPOKNIJNA LKMADFBDLGL(BFPIHMHLCFF CCAOJBHBKKC, [Out] IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x60D6F80", Offset = "0x60D6180", VA = "0x1860D6F80")]
	internal void CFHBCFIFPIN(string LHOCBCGJDEG, AOFLEHDOPCJ MEBPEONDLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x60D86A0", Offset = "0x60D78A0", VA = "0x1860D86A0")]
	public IEnumerable<INBOAHIBCAN> ONKELNPLLLJ(string LFOBKCKOPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x60D7530", Offset = "0x60D6730", VA = "0x1860D7530")]
	private IEnumerable<INBOAHIBCAN> HBFKFJJDPID(string LFOBKCKOPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x60D70E0", Offset = "0x60D62E0", VA = "0x1860D70E0")]
	internal IEnumerable<INBOAHIBCAN> EONHGOBCNNA(string LFOBKCKOPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x60D7950", Offset = "0x60D6B50", VA = "0x1860D7950")]
	private INBOAHIBCAN JDDJALDIELJ(AvatarOutfitSelectionData NFKAFMEBODM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
	private void PAICBFCNHAH(AvatarCustomizationSettingsData FOEAFFFAFDA, AOFLEHDOPCJ MEBPEONDLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x60D7D20", Offset = "0x60D6F20", VA = "0x1860D7D20")]
	private INBOAHIBCAN JDDJALDIELJ(string LJGKKFIIGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x60D6CA0", Offset = "0x60D5EA0", VA = "0x1860D6CA0")]
	internal static (BKAHNFPJFDO, string, string) BMPJAEPMNHD(string LJGKKFIIGEN, IAFPOFNODCF POMHMEMGNEJ)
	{
		return default((BKAHNFPJFDO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x60D84A0", Offset = "0x60D76A0", VA = "0x1860D84A0")]
	private GMBFCNHEHHG? NKNFPEGLGKA(string? IKOKEKHMFKH, Vector2 HDNGAJIDLBF, float NDGLDEKGLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x60D8FD0", Offset = "0x60D81D0", VA = "0x1860D8FD0")]
	private static BONMPAHMNCG PDGEFHHGOAH(AvatarCustomizationSettingsData.AnchorParams IFMOPAEIMLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PJKEGBNMNOG]
internal class PHPOPMEAPIK : HABAGOLFKLK, CCBFKBDLHFH
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x60DA040", Offset = "0x60D9240", VA = "0x1860DA040")]
	public PHPOPMEAPIK(OBFONIMKKPC ADJPPOMJDHJ, GPOLAKEALAF DCBDMMLDONE, IAFPOFNODCF POMHMEMGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x60D9B90", Offset = "0x60D8D90", VA = "0x1860D9B90", Slot = "4")]
	public NHOHMHKFKBC OHDBDPJBHPM(AOFLEHDOPCJ FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x60D9F40", Offset = "0x60D9140", VA = "0x1860D9F40")]
	private string OHLKOCBAJGO(AOFLEHDOPCJ MEBPEONDLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x60D98D0", Offset = "0x60D8AD0", VA = "0x1860D98D0")]
	private string DMBNNBFFMCD(INBOAHIBCAN ADPHEGNKABI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[PJKEGBNMNOG]
internal class HHONCCDCHLM : KKKOLOAKPMC<BFPIHMHLCFF, GKIPOKNIJNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly OBFONIMKKPC ADJPPOMJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly POBGBBHJFFJ<BFPIHMHLCFF, GKIPOKNIJNA> BIDCMODJJNE;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x60D69A0", Offset = "0x60D5BA0", VA = "0x1860D69A0")]
	public HHONCCDCHLM(POBGBBHJFFJ<BFPIHMHLCFF, GKIPOKNIJNA> BIDCMODJJNE, IAFPOFNODCF POMHMEMGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x60D6570", Offset = "0x60D5770", VA = "0x1860D6570", Slot = "6")]
	public override GKIPOKNIJNA LKMADFBDLGL(BFPIHMHLCFF CCAOJBHBKKC, [Out] IReadOnlyList<HFBGONFPNON>? BHMNFPCHDPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[PJKEGBNMNOG]
internal class GNMDHDAGBFF : KEKBFKPKMIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly OBFONIMKKPC ADJPPOMJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly CCBFKBDLHFH NJHCKEIODJH;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x60D6480", Offset = "0x60D5680", VA = "0x1860D6480")]
	public GNMDHDAGBFF(CCBFKBDLHFH NJHCKEIODJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x60D60E0", Offset = "0x60D52E0", VA = "0x1860D60E0", Slot = "4")]
	public BFPIHMHLCFF OHDBDPJBHPM(AOFLEHDOPCJ FODGEDCJIDC, int ICAOGBDNOMB, string? IKEFBMMMAJB, string? DJEJNPJICEK, AMGJHJOBMLJ DOGLIFIFMAK, List<HFBGONFPNON>? BHMNFPCHDPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Preserve]
internal class PMBLIAJKKNO : NOGBFLKPLAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static readonly Vector2 CKHFAGBBEAD;

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private static readonly Vector2 HPDNNMAPABH;

	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static readonly Vector2 GADGJEMPNBF;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly Vector2 PFEIBIIIDII;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static readonly Vector2 OBPGMCAJKLE;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly Vector2 NCBKGAGJNAI;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly Vector2 BDEJDJJMIHH;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly Vector2 GMFPOEDLFJA;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly Vector2 LBAPNAODPGH;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly Vector2 HCHMMDOAJKH;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly Vector2 BLPCMLBGEAA;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static readonly Vector2 EAMFPGNAPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private Dictionary<MKHOLMAHBJI, AvatarConfiguration> PBCIECDHEIL;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x60DB780", Offset = "0x60DA980", VA = "0x1860DB780")]
	[KEFCCLBEAOJ(BDECECCJEGA.Root, CMEECPGEPNF.None)]
	private static void ONFKCHFOKNA(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x60DBC30", Offset = "0x60DAE30", VA = "0x1860DBC30")]
	[Preserve]
	internal PMBLIAJKKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x60DB550", Offset = "0x60DA750", VA = "0x1860DB550", Slot = "4")]
	public Vector2 NPMEDCKFJEP(FaceFeatureType LFDFHHHDLDI, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60DB1D0", Offset = "0x60DA3D0", VA = "0x1860DB1D0", Slot = "5")]
	public float KIDGHOLOECK(FaceFeatureType LFDFHHHDLDI, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x60DA470", Offset = "0x60D9670", VA = "0x1860DA470", Slot = "6")]
	public void FBIFHMMPFKM(MKHOLMAHBJI FPGGKBLIGPM, AvatarConfiguration NKBMLGBCELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x60DB250", Offset = "0x60DA450", VA = "0x1860DB250", Slot = "7")]
	public float KPOBKLKIDDO(FaceFeatureType KEEAPPBIDMI, float OBLLFNINJFF, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x60DAD20", Offset = "0x60D9F20", VA = "0x1860DAD20", Slot = "8")]
	public float JKLJHJLPPIN(FaceFeatureType KEEAPPBIDMI, float NDGLDEKGLJP, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x60DA2C0", Offset = "0x60D94C0", VA = "0x1860DA2C0", Slot = "10")]
	public Vector2 EPKMGGDCJPF(FaceFeatureType KEEAPPBIDMI, Vector2 GNIPCNGPIJO, Vector2 LOLJFEKAEID, Vector2 JABBGBGDNJG, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x60DAFA0", Offset = "0x60DA1A0", VA = "0x1860DAFA0", Slot = "9")]
	public Vector2 KDNKEHOJPOF(FaceFeatureType KEEAPPBIDMI, Vector2 EEIGDNBGIKA, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x60DA0D0", Offset = "0x60D92D0", VA = "0x1860DA0D0")]
	private Vector2 ECLJCLHNHBI(FaceFeatureType KEEAPPBIDMI, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x60DB280", Offset = "0x60DA480", VA = "0x1860DB280")]
	private Vector2 LOAFPALHMED(FaceFeatureType KEEAPPBIDMI, Vector2 GNIPCNGPIJO, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x60DA840", Offset = "0x60D9A40", VA = "0x1860DA840", Slot = "11")]
	public Vector2 IHFDHDCOAKL(FaceFeatureType KEEAPPBIDMI, Vector2 EEIGDNBGIKA, Vector2 LOLJFEKAEID, Vector2 JABBGBGDNJG, MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x60DA5B0", Offset = "0x60D97B0", VA = "0x1860DA5B0")]
	private float GMEEGAPAAAC(float PMCJJGJGOKB, float OEEFGEJNCEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x60DB900", Offset = "0x60DAB00", VA = "0x1860DB900")]
	private Vector2 PNDHHJFALBF(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x60DB880", Offset = "0x60DAA80", VA = "0x1860DB880")]
	private Vector2 PELAIBGENGP(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x60DA240", Offset = "0x60D9440", VA = "0x1860DA240")]
	private Vector2 EHJBFCOAGHP(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x60DA710", Offset = "0x60D9910", VA = "0x1860DA710")]
	private Vector2 HEGHLNLFCAP(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x60DACA0", Offset = "0x60D9EA0", VA = "0x1860DACA0")]
	private float JHJEAPKABEP(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x60DACE0", Offset = "0x60D9EE0", VA = "0x1860DACE0")]
	private float JHNEJHLMIED(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x60DA050", Offset = "0x60D9250", VA = "0x1860DA050")]
	private float AIDGIEKNCIK(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x60DA090", Offset = "0x60D9290", VA = "0x1860DA090")]
	private float CCCELEPKGKM(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x60DA4E0", Offset = "0x60D96E0", VA = "0x1860DA4E0")]
	private Vector2 GGJAPIMCPFD(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x60DAD50", Offset = "0x60D9F50", VA = "0x1860DAD50")]
	private Vector2 KBJFCAECOGO(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x60DA170", Offset = "0x60D9370", VA = "0x1860DA170")]
	private Vector2 EFALAAENIBG(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x60DA640", Offset = "0x60D9840", VA = "0x1860DA640")]
	private Vector2 GNLCPMNCDEJ(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x60DB980", Offset = "0x60DAB80", VA = "0x1860DB980")]
	private Vector2 PPGCIKBLKFM(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x60DB480", Offset = "0x60DA680", VA = "0x1860DB480")]
	private Vector2 MPOPJBPMHLL(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x60DABD0", Offset = "0x60D9DD0", VA = "0x1860DABD0")]
	private Vector2 IKPMNHMAPMK(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x60DAED0", Offset = "0x60DA0D0", VA = "0x1860DAED0")]
	private Vector2 KCLELOCLEFP(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60DB6B0", Offset = "0x60DA8B0", VA = "0x1860DB6B0")]
	private Vector2 OBGAJJGBNIJ(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x60DAE20", Offset = "0x60DA020", VA = "0x1860DAE20")]
	private Vector2 KBKAFNKANOE(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x60DB3D0", Offset = "0x60DA5D0", VA = "0x1860DB3D0")]
	private Vector2 MNJIJFCIOBJ(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x60DA790", Offset = "0x60D9990", VA = "0x1860DA790")]
	private Vector2 HNNGOPIJNCE(MKHOLMAHBJI FPGGKBLIGPM)
	{
		return default(Vector2);
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
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x60D4EF0", Offset = "0x60D40F0", VA = "0x1860D4EF0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DKAMKKHKOLG
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x60D5840", Offset = "0x60D4A40", VA = "0x1860D5840")]
	public static KJPHDDIDNHP LKMADFBDLGL(this HAEEPOLKEJG FODGEDCJIDC)
	{
		return default(KJPHDDIDNHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x60D5AC0", Offset = "0x60D4CC0", VA = "0x1860D5AC0")]
	public static HAEEPOLKEJG OHDBDPJBHPM(this KJPHDDIDNHP GNKDOBAKJGA)
	{
		return null;
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
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x46E9C00", Offset = "0x46E8E00", VA = "0x1846E9C00")]
			public AnchorParams(Vector2 GNIPCNGPIJO, Vector3 DGDAPHOILDA, Vector3 DENIFAFBDNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x60D4E40", Offset = "0x60D4040", VA = "0x1860D4E40")]
			internal BONMPAHMNCG OHDBDPJBHPM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private GNDEMGODMFB useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x60D56D0", Offset = "0x60D48D0", VA = "0x1860D56D0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4132970", Offset = "0x4131B70", VA = "0x184132970")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xF26B70", Offset = "0xF25D70", VA = "0x180F26B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x96FA50", Offset = "0x96EC50", VA = "0x18096FA50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x88A9C0", Offset = "0x889BC0", VA = "0x18088A9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x60D5770", Offset = "0x60D4970", VA = "0x1860D5770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7BFEE0", Offset = "0x7BF0E0", VA = "0x1807BFEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xC7BA80", Offset = "0xC7AC80", VA = "0x180C7BA80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xF1E130", Offset = "0xF1D330", VA = "0x180F1E130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x7B6270", Offset = "0x7B5470", VA = "0x1807B6270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x60D57D0", Offset = "0x60D49D0", VA = "0x1860D57D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1AEB660", Offset = "0x1AEA860", VA = "0x181AEB660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD1D310", Offset = "0xD1C510", VA = "0x180D1D310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xD17AD0", Offset = "0xD16CD0", VA = "0x180D17AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CB0", Offset = "0x7B7EB0", VA = "0x1807B8CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CA0", Offset = "0x7B7EA0", VA = "0x1807B8CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x60D57B0", Offset = "0x60D49B0", VA = "0x1860D57B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1B191F0", Offset = "0x1B183F0", VA = "0x181B191F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7EAD40", Offset = "0x7E9F40", VA = "0x1807EAD40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7EADA0", Offset = "0x7E9FA0", VA = "0x1807EADA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7C02A0", VA = "0x1807C10A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0250", VA = "0x1807C1050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7C0FB0", Offset = "0x7C01B0", VA = "0x1807C0FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F80", Offset = "0x7C0180", VA = "0x1807C0F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F60", Offset = "0x7C0160", VA = "0x1807C0F60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7C0FD0", Offset = "0x7C01D0", VA = "0x1807C0FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x99FAF0", Offset = "0x99ECF0", VA = "0x18099FAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x99FBD0", Offset = "0x99EDD0", VA = "0x18099FBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0240", VA = "0x1807C1040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7C0F10", Offset = "0x7C0110", VA = "0x1807C0F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x89EB50", Offset = "0x89DD50", VA = "0x18089EB50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x87BCE0", Offset = "0x87AEE0", VA = "0x18087BCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7BC0A0", Offset = "0x7BB2A0", VA = "0x1807BC0A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC080", Offset = "0x7BB280", VA = "0x1807BC080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA29870", Offset = "0xA28A70", VA = "0x180A29870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA32190", Offset = "0xA31390", VA = "0x180A32190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8D84D0", Offset = "0x8D76D0", VA = "0x1808D84D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xBB55A0", Offset = "0xBB47A0", VA = "0x180BB55A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public GNDEMGODMFB UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1BB7960", Offset = "0x1BB6B60", VA = "0x181BB7960")]
			get
			{
				return default(GNDEMGODMFB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1BB6070", Offset = "0x1BB5270", VA = "0x181BB6070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9082F0", Offset = "0x9074F0", VA = "0x1809082F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x908D40", Offset = "0x907F40", VA = "0x180908D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x60D5790", Offset = "0x60D4990", VA = "0x1860D5790")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x60D57F0", Offset = "0x60D49F0", VA = "0x1860D57F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x60D5370", Offset = "0x60D4570", VA = "0x1860D5370")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public BKAHNFPJFDO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private PMMOMIOFJDG? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x60D5810", Offset = "0x60D4A10", VA = "0x1860D5810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
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
