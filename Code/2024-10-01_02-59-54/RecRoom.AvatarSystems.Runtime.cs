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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CAE070", Offset = "0x6CAD470", VA = "0x186CAE070")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE0F0", Offset = "0x6CAD4F0", VA = "0x186CAE0F0", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NFAHBLEIIKC]
internal class JBHFMLKAJPL : IJBFCDKLMOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LBHDEFHKHLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public JBHFMLKAJPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public BMFEHMICIHN avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HONPCPNCAEP ACILBNDPLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MCLKMPDEOBG GAJOELCNJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EHHFNIGMFBH BKNJFEGNCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LABEAAGFFIC JEMJFAEDOPG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6CADAF0", Offset = "0x6CACEF0", VA = "0x186CADAF0")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	[UsedImplicitly]
	internal static void LHDMPKJJCIL(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6CADE80", Offset = "0x6CAD280", VA = "0x186CADE80")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JBHFMLKAJPL([ACGOIOBGIEE(null)] HONPCPNCAEP ACILBNDPLGE, [ACGOIOBGIEE(null)] MCLKMPDEOBG GAJOELCNJJK, [ACGOIOBGIEE(null)] EHHFNIGMFBH BKNJFEGNCNM, [ACGOIOBGIEE(null)] LABEAAGFFIC JEMJFAEDOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC560", Offset = "0x6CAB960", VA = "0x186CAC560", Slot = "5")]
	public MHDJBPMNPGJ DAPONCKMEEH(BMFEHMICIHN JEIAKJBAGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD010", Offset = "0x6CAC410", VA = "0x186CAD010", Slot = "4")]
	public MHDJBPMNPGJ HPNGOMFEPMI(BMFEHMICIHN JEIAKJBAGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD9E0", Offset = "0x6CACDE0", VA = "0x186CAD9E0", Slot = "6")]
	public EPALDFBFDLE KENLAFOOCHO(MHDJBPMNPGJ MPMEGOKIEPF, int JLLMACKDECJ, string? ADANIHOIEKJ, string? KKKLDKNLEIP, EIIAMCIDOPM LJCPEALDJMF, List<ACLMNPMHHND>? BCFBCEDPCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC4D0", Offset = "0x6CAB8D0", VA = "0x186CAC4D0", Slot = "7")]
	public bool BJACJODEKDG(LNCDIMNAFAB DNGMKBLCCLC, [Out] MHDJBPMNPGJ? OIFJOOICJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CADB60", Offset = "0x6CACF60", VA = "0x186CADB60", Slot = "8")]
	public bool NJEMDJMPJHC(EPALDFBFDLE JIJFONKJBIL, [Out] MHDJBPMNPGJ? OIFJOOICJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6CADC40", Offset = "0x6CAD040", VA = "0x186CADC40", Slot = "9")]
	public bool PCODBMGLMMC(EPALDFBFDLE JIJFONKJBIL, [Out] AFOHDPIACBB? DNGMKBLCCLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBC60", Offset = "0x2ECB060", VA = "0x182ECBC60")]
	private bool FBBKDIEKADC<TInput, TOutput>(TInput GJMNBMBONPJ, IJLBHMEOMFM<TInput, TOutput> IHJLIJJFHPH, [Out] TOutput? CIFMGKBFCHA) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CADCD0", Offset = "0x6CAD0D0", VA = "0x186CADCD0")]
	[CompilerGenerated]
	private GBFACCACHBL PGOBFDEEMNP(FaceFeatureType FCENLFGCIJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6CACD30", Offset = "0x6CAC130", VA = "0x186CACD30")]
	[CompilerGenerated]
	private GBFACCACHBL FFJOKGBDKMF(FaceFeatureType FCENLFGCIJN, LBHDEFHKHLF P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NFAHBLEIIKC]
internal class EFOCEMFPKGI : HONPCPNCAEP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void CHIBHPFJFEH<in TData>(TData OIFJOOICJNK, IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly EHHFNIGMFBH BKNJFEGNCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GOLAIFJFJFA DPKKJKPNDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CHIBHPFJFEH<MHDJBPMNPGJ>?[] ACILBNDPLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CHIBHPFJFEH<AFOHDPIACBB>?[] OGHHGNENCKL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C92CE0", Offset = "0x6C920E0", VA = "0x186C92CE0")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	[UsedImplicitly]
	internal static void LHDMPKJJCIL(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C92F80", Offset = "0x6C92380", VA = "0x186C92F80")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EFOCEMFPKGI([ACGOIOBGIEE(null)] EHHFNIGMFBH BKNJFEGNCNM, [ACGOIOBGIEE(null)] GOLAIFJFJFA DPKKJKPNDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C92B80", Offset = "0x6C91F80", VA = "0x186C92B80", Slot = "4")]
	public bool CIEJBDDKMPK(MHDJBPMNPGJ OIFJOOICJNK, IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C92A20", Offset = "0x6C91E20", VA = "0x186C92A20", Slot = "5")]
	public bool CIEJBDDKMPK(AFOHDPIACBB DNGMKBLCCLC, IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C91FF0", Offset = "0x6C913F0", VA = "0x186C91FF0")]
	private void BENDEBGHLBG(MHDJBPMNPGJ OIFJOOICJNK, IReadOnlyList<ACLMNPMHHND>? PAHNKMKPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C92D50", Offset = "0x6C92150", VA = "0x186C92D50")]
	private void OBIMOCPLKFA(MHDJBPMNPGJ OIFJOOICJNK, IReadOnlyList<ACLMNPMHHND>? PAHNKMKPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C92C80", Offset = "0x6C92080", VA = "0x186C92C80")]
	private void GHFKGDLEEEA(MHDJBPMNPGJ OIFJOOICJNK, IReadOnlyList<ACLMNPMHHND>? PAHNKMKPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C92CB0", Offset = "0x6C920B0", VA = "0x186C92CB0")]
	private void IJCDHKKADMO(MHDJBPMNPGJ OIFJOOICJNK, IReadOnlyList<ACLMNPMHHND>? PAHNKMKPPCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HONPCPNCAEP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIEJBDDKMPK(MHDJBPMNPGJ OIFJOOICJNK, IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CIEJBDDKMPK(AFOHDPIACBB DNGMKBLCCLC, IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI);
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
		public MGAHEHBANKD AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6C8DFA0", Offset = "0x6C8D3A0", VA = "0x186C8DFA0")]
		public void HPHLDNAMIAJ(AnimationPoseSetting OCKBFCIKBEN, float LKJKHDFGPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E0D0", Offset = "0x6C8D4D0", VA = "0x186C8E0D0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendHelperController : MonoBehaviour, HPNMBNLPJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
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
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool DebugExecutionInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Vector3? MAPFEABMPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool APGLHEDEIKJ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E0F0", Offset = "0x6C8D4F0", VA = "0x186C8E0F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E6D0", Offset = "0x6C8DAD0", VA = "0x186C8E6D0", Slot = "4")]
		public void UpdateController(float GJPMFKBAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x116BFF0", Offset = "0x116B3F0", VA = "0x18116BFF0", Slot = "6")]
		public void SetEnabled(bool LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E190", Offset = "0x6C8D590", VA = "0x186C8E190")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EB60", Offset = "0x6C8DF60", VA = "0x186C8EB60")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarElbowBendTargetController : MonoBehaviour, HPNMBNLPJGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float IPFGCGHKEIF = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
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
		private Vector3 FCKGHOJCEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 HPCDLIPFINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool APGLHEDEIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float BGDBOGHMDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float JCCLLJNNPGN;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EEE0", Offset = "0x6C8E2E0", VA = "0x186C8EEE0", Slot = "4")]
		public void UpdateController(float GJPMFKBAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xC63F70", Offset = "0xC63370", VA = "0x180C63F70", Slot = "6")]
		public void SetEnabled(bool LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EC00", Offset = "0x6C8E000", VA = "0x186C8EC00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F9A0", Offset = "0x6C8EDA0", VA = "0x186C8F9A0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
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
		[Cpp2IlInjected.Address(RVA = "0x6C902A0", Offset = "0x6C8F6A0", VA = "0x186C902A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C90260", Offset = "0x6C8F660", VA = "0x186C90260")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F9D0", Offset = "0x6C8EDD0", VA = "0x186C8F9D0")]
		private void MPKIBCPIEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C57C20", Offset = "0x6C57020", VA = "0x186C57C20", Slot = "4")]
		public void SetEnabled(bool PNHMPKNFDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C902D0", Offset = "0x6C8F6D0", VA = "0x186C902D0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarForearmRollController : MonoBehaviour, HPNMBNLPJGF
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
		private float BGDBOGHMDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool APGLHEDEIKJ;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C90310", Offset = "0x6C8F710", VA = "0x186C90310", Slot = "4")]
		public void UpdateController(float GJPMFKBAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x11086F0", Offset = "0x1107AF0", VA = "0x1811086F0", Slot = "6")]
		public void SetEnabled(bool LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C90D90", Offset = "0x6C90190", VA = "0x186C90D90")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HandDisplaySettings HandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x359")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Default angle of the foot bone as seen in idle")]
		public float FootRestAngle;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C90DC0", Offset = "0x6C901C0", VA = "0x186C90DC0")]
		public AnimationPoseSetting JKCCPABCJJJ(MGAHEHBANKD LAPCKNDJJMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C90DF0", Offset = "0x6C901F0", VA = "0x186C90DF0")]
		public void LHMGAKDCLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C90E30", Offset = "0x6C90230", VA = "0x186C90E30")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC490", Offset = "0x6CAB890", VA = "0x186CAC490")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CBPBGFNCOOF : MDEEHEDBKBP
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int EPFOCALBIOP;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int IKBEDOPCIFB;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int KFKNEPAPGIL;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int EOGDDLNAJAH;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int NPIBMOGAHMD;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int HJLDIBBGEME;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int DKLBHINMNCI;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int[] KBMNBGHDAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private GBOKCIDGIJF APPHNBPAKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private MAEOMLDLGKL NFPCNNMDPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int NHCBMEIPODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private float LBOMKBMNFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator KCEDOIDJDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private AvatarFullBodyConfiguration MMCINIGNFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int PDHCGIDLBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int HIGGIIGDIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int LHFBEJLADPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool JHICKIGFFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private DGCAIIMNGIE OBKMBGHIEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int JEBBJAGCPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private float JICEPENBHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private HandDisplaySettings CNBLMFGOGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private BMFEHMICIHN MBBNCAFCPBN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Transform LNGHGGLOPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal Vector3 AHAEOFJPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10E6CF0", Offset = "0x10E60F0", VA = "0x1810E6CF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x10E6BA0", Offset = "0x10E5FA0", VA = "0x1810E6BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Quaternion GDMMHBNGCCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x17E8A70", Offset = "0x17E7E70", VA = "0x1817E8A70")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x21A72F0", Offset = "0x21A66F0", VA = "0x1821A72F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool EHCJNEMMHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6C91470", Offset = "0x6C90870", VA = "0x186C91470")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6C91290", Offset = "0x6C90690", VA = "0x186C91290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 HEOJALGNFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF08D60", Offset = "0xF08160", VA = "0x180F08D60", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xF07D70", Offset = "0xF07170", VA = "0x180F07D70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Quaternion FNIEGNANPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xBBFDD0", Offset = "0xBBF1D0", VA = "0x180BBFDD0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF07830", Offset = "0xF06C30", VA = "0x180F07830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BOJNKBHGGPE LIMKMGCJMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA8D280", Offset = "0xA8C680", VA = "0x180A8D280", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(BOJNKBHGGPE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA8C7C0", Offset = "0xA8BBC0", VA = "0x180A8C7C0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BOJNKBHGGPE HIDNNJMIHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x15DB990", Offset = "0x15DAD90", VA = "0x1815DB990", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(BOJNKBHGGPE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1DCCE30", Offset = "0x1DCC230", VA = "0x181DCCE30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float BMHDKECIGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1827660", Offset = "0x1826A60", VA = "0x181827660", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA8C920", Offset = "0xA8BD20", VA = "0x180A8C920", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FCNPCDGDGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C91B40", Offset = "0x6C90F40", VA = "0x186C91B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HOPNBAEHCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C914E0", Offset = "0x6C908E0", VA = "0x186C914E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OOHDJFMBEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C91220", Offset = "0x6C90620", VA = "0x186C91220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ONDEDKKJBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C912C0", Offset = "0x6C906C0", VA = "0x186C912C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C91580", Offset = "0x6C90980", VA = "0x186C91580", Slot = "21")]
	public void JLABJFAHLGH(GBOKCIDGIJF BCOJLKEJKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C91AF0", Offset = "0x6C90EF0", VA = "0x186C91AF0")]
	public void LHEBJHFOMAO(MAEOMLDLGKL CCJBOCICBDE, HandDisplaySettings LDMELPIIKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C914F0", Offset = "0x6C908F0", VA = "0x186C914F0", Slot = "12")]
	public void ICFDDKEIKIM(bool JFOACCBBNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C917B0", Offset = "0x6C90BB0", VA = "0x186C917B0", Slot = "11")]
	public void KOPNFPPDJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C91B50", Offset = "0x6C90F50", VA = "0x186C91B50")]
	private int OFIIKPAJEPD(BOJNKBHGGPE CFOKINIJPEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C912D0", Offset = "0x6C906D0", VA = "0x186C912D0")]
	private void CNHCFOGDFJI(int BABDGFAKIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C914A0", Offset = "0x6C908A0", VA = "0x186C914A0", Slot = "13")]
	public bool EOFMCJIKDOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C91230", Offset = "0x6C90630", VA = "0x186C91230", Slot = "14")]
	public bool BJFEGGKDOBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C91240", Offset = "0x6C90640", VA = "0x186C91240")]
	private BOJNKBHGGPE BOPHOFFOIJI()
	{
		return default(BOJNKBHGGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA3B150", Offset = "0xA3A550", VA = "0x180A3B150", Slot = "15")]
	public void FMOPMOKKPNI(bool JFOACCBBNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C91D10", Offset = "0x6C91110", VA = "0x186C91D10", Slot = "10")]
	public void PMDDLOBHNKG(int BABDGFAKIDL, float FADBHDJOJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C914C0", Offset = "0x6C908C0", VA = "0x186C914C0", Slot = "8")]
	public void FGINAEDGFND(DGCAIIMNGIE NOGEMBGGBHJ, bool MEFHKNCMBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C91AE0", Offset = "0x6C90EE0", VA = "0x186C91AE0", Slot = "9")]
	public void LGNAKBHADFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C91420", Offset = "0x6C90820", VA = "0x186C91420", Slot = "16")]
	public void DHFANANLAJB(Transform IIOPLDELPHL, Vector3 CGCCLBJDJDB, Quaternion MGPDCFLGEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C91FE0", Offset = "0x6C913E0", VA = "0x186C91FE0")]
	public CBPBGFNCOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ELGGBEMELAJ : MGFGEAEOMOC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class CKGHKGDHBPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3 EPOJOCJAPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Quaternion LHMMMPBGLNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 OBMIJBDPEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Transform MHLNPDHGBHE;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 AKMCEHJBPFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x1852440", Offset = "0x1851840", VA = "0x181852440")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1852460", Offset = "0x1851860", VA = "0x181852460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion HMPPCEBAIAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xE27DA0", Offset = "0xE271A0", VA = "0x180E27DA0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xE28390", Offset = "0xE27790", VA = "0x180E28390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public float DLKGNKMMMFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xBBFE50", Offset = "0xBBF250", VA = "0x180BBFE50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x11BACA0", Offset = "0x11BA0A0", VA = "0x1811BACA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool GAHCGJPAJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8B8290", Offset = "0x8B7690", VA = "0x1808B8290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8B80A0", Offset = "0x8B74A0", VA = "0x1808B80A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool ANAGCGKNHGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8B81B0", Offset = "0x8B75B0", VA = "0x1808B81B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8B81D0", Offset = "0x8B75D0", VA = "0x1808B81D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool ECGOIGIDNAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8B8180", Offset = "0x8B7580", VA = "0x1808B8180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8B80C0", Offset = "0x8B74C0", VA = "0x1808B80C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float PLKJLBDJGGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xBBFE70", Offset = "0xBBF270", VA = "0x180BBFE70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x27FDC30", Offset = "0x27FD030", VA = "0x1827FDC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CB32E0", Offset = "0x6CB26E0", VA = "0x186CB32E0")]
		public void OBIMMMDEFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2FA0", Offset = "0x6CB23A0", VA = "0x186CB2FA0")]
		public void GBAOCPLMLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2560", Offset = "0x6CB1960", VA = "0x186CB2560")]
		public float BMBMIMLNHHL(Vector3 PANBEAEOOKG, Quaternion ANKNFOLLICD, [In] FootSettings AIPKBHGFOOC, float INLNLHLBHKH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2770", Offset = "0x6CB1B70", VA = "0x186CB2770")]
		public void CMGJGMAMPMD(Vector3 IMEJELEHOLA, Quaternion NMLNGHKKHPC, Transform KJCDDCAOFOF, float DODMHLIAEPL, bool CCNPFAIGHKN, bool PNHAFOJINNB, float GNHCOPOJOGJ, float DPAGICBJIAA, Transform FINELPFBLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2FB0", Offset = "0x6CB23B0", VA = "0x186CB2FB0")]
		public void JBGLCNODIKH(Transform CLCMJFPKDJN, Transform FINELPFBLOK, bool HKACKHLMICB, bool CDOJAABCMAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6CB31E0", Offset = "0x6CB25E0", VA = "0x186CB31E0")]
		private void KGKHIOKPPAN(Transform FINELPFBLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2E50", Offset = "0x6CB2250", VA = "0x186CB2E50")]
		public void DDGHGFCDENF(Transform FINELPFBLOK, AvatarFullBodyConfiguration IBOPOOBMBOE, Vector3 HBABIMACLPL, float FJCIDMJHFKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2E40", Offset = "0x6CB2240", VA = "0x186CB2E40")]
		public void CODBBFMMCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6CB32F0", Offset = "0x6CB26F0", VA = "0x186CB32F0")]
		public CKGHKGDHBPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class MNCABDABIHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float KFPHHMJNLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool IOCILOCOOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AnimationPoseSetting AGOJCAJHPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float BFDDJOLKMPL;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC1B0", Offset = "0x6CBB5B0", VA = "0x186CBC1B0")]
		public void BPLMHPCFPAA(IKSolverVR.Arm ILIOKGAIENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC340", Offset = "0x6CBB740", VA = "0x186CBC340")]
		public void FPCEOMBKKMI(IKSolverVR.Arm ILIOKGAIENO, float NMHPFCIFGIC, bool IOCILOCOOEO, AvatarFullBodyConfiguration IBOPOOBMBOE, float BPCBDAAPHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC380", Offset = "0x6CBB780", VA = "0x186CBC380")]
		private void KDPGPIKIMCO(IKSolverVR.Arm ILIOKGAIENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCE20", Offset = "0x6CBC220", VA = "0x186CBCE20")]
		public void NPJHKOBJMCB(IKSolverVR.Arm ILIOKGAIENO, Transform GENIKONNFOE, Transform KJCDDCAOFOF, Quaternion JGDONICGJNI, Vector3 OPLCFCBPFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC860", Offset = "0x6CBBC60", VA = "0x186CBC860")]
		private (Vector3, Quaternion) MDNEOIJNPGK(CBPBGFNCOOF GDJJNGHHCKH, Quaternion KGNCJGEOPAG, Vector3 CBCHCJJLGPI)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC1E0", Offset = "0x6CBB5E0", VA = "0x186CBC1E0")]
		public void EMHBOGOHPEE(CBPBGFNCOOF GDJJNGHHCKH, IKSolverVR.Arm ILIOKGAIENO, Quaternion KGNCJGEOPAG, Vector3 CBCHCJJLGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6CBBBB0", Offset = "0x6CBAFB0", VA = "0x186CBBBB0")]
		public void ALKDEBCHBIP(CBPBGFNCOOF GDJJNGHHCKH, IKSolverVR.Arm ILIOKGAIENO, Quaternion KGNCJGEOPAG, Vector3 CBCHCJJLGPI, [In] AvatarFullBodyConfiguration IBOPOOBMBOE, [In] LEJDNPAGPEF NOGEMBGGBHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCCF0", Offset = "0x6CBC0F0", VA = "0x186CBCCF0")]
		public void MHIBMMKFDAP(MGAHEHBANKD NBJHIFNCDDK, AvatarFullBodyConfiguration IBOPOOBMBOE, LEJDNPAGPEF NOGEMBGGBHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC3C0", Offset = "0x6CBB7C0", VA = "0x186CBC3C0")]
		public void MAFFPOLJGLI(IKSolverVR.Arm ILIOKGAIENO, Transform GENIKONNFOE, Vector3 EEPMPJHGJEH, float LBBIPIKLPCO, Quaternion GBAFDJFPNKC, Vector3 MHAHNOFONAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD200", Offset = "0x6CBC600", VA = "0x186CBD200")]
		public MNCABDABIHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum GCAENLPPHJN
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KAOGIEAMDKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct KPBOJKJLPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int KIOLHCOENJF;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int DCAGBBDKOMN;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int ELHPADDOGGB;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int AHPNEKGOOAA;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int DEHIPEKAIPO;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int JHECCNDGBLI;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int EPLJJBIABMF;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int KJAAHKIMPLN;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int BEHAHFDGDJL;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int HOJIIDNDKNP;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int BEONAEPEIMD;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int IJFLDOIGMOI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int FFMOHFKDIGG;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JNDIICGEALA;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int BDNDLJAADNP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int HAMDPJHKKHH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int BCNNBENOEFH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int NMDMJFGFIDC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int LLGHCKDGMBD;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int CHJJDIFGAMA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int IHCDFAMGDDE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int HNONFFIDGIL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int LBMJDOEIGNA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int MJFECDINLBF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int EDHKNNHBEDO;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int HKCNIBIKBGL;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int CLMBIHBABHH;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int NEJJFGEKPNM;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int MIKMNBJGCKH;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 DHBCMBGHPLE;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int LPGEPCAKLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool JJKBLJEMMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool GKMDKKACKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool IKLHGCPBHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool PGAILABGNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool CKBOIPMLGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Vector3 EEMDIOOKFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private string GMJEFINEOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private HEDEKFGCFKP? APPHNBPAKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MEDIMDINCLB? CJNGIGPHBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private BIAPNLKMOKL POCDJEIPHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private PHCAJNIHEOH DHOPCHOIEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private CBPBGFNCOOF EEPFMOBHHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private CBPBGFNCOOF LLIEBNOBEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool CFOLDNGBIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool NPDHJDGGIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly AHLBMLCALGL GLBBCPBPPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly BLDLAPDPBID EDHCBAAFJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int NGKPILCLLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private float ILNONEOONFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GameObject HHDGHBANCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform MLFOJHGNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform CMGICONJAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform OANAKNEJJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform BGNHJBMAOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform MFLEJDMKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float DDDBPIKAKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float CEPJHPOJPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 MGDJJPBDDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Quaternion JPOEBEKFJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform IFKAAOBBLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform MKFIHIDLIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform JBPODLCDMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool HNCPHMIAJGL;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker JBHFEKJMLGB;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker ALMIOBHIHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker LAKNFAIBMGB;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker DLLDJJKDPIN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker GMBOKFMMKIH;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker ICJKBNNFGCB;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<ELGGBEMELAJ> JJKENPNLBCF;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int LFFCLGNHBCA;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> IEMBHAOEGPF;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int JIBCJKJMKNG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int BPCKAGGEPPK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int IPBMCNOLEJE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int PKIIKEKKEJO;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float HPMLKKOKMJM;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int FBCCGHEAFDK;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float HMLMGIEFAGF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float MEDEGJFAHMI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float FOEFGLCEAMM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float FHIJMKFADAL;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static ALJPDHIIMKD FDBOAMENJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float JFOJILLPCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool GLBNFLNONGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float AODFBBAGNLB;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int DODBHCAOKIC;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int GHFFOOKOLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private CKGHKGDHBPP GDAGDBIFPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private CKGHKGDHBPP MJLCLBDKJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float FGJNBIPPIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Vector3 FEAFGMFAHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Vector3 OGFHDFNNOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool MAKDCBKPJGG;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion JJPHFPFBLMI;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion AHGMOFLPGNG;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 JKNAMEOELLF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 NKLKEOJBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float PHPHHMNCIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float CAIIOCDHCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private MNCABDABIHH EANPHKEKBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private MNCABDABIHH HHFMEOLNHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private HJEJCBNHEHN BKAPEBIDOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private POPFFHGEDMG NCDNODEBIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly NJAICNJPNBK KBKLPKIKIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float BOFFKIOACPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float HHIPNIHPKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly POPFFHGEDMG CPMAILHJECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 BKLAOOGNMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Vector3 GJNJEFEKHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float IICIJGLBKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float BEIGCDGINBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly POPFFHGEDMG PCHKMCLAOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly HJEJCBNHEHN LNCCNHDCJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly POPFFHGEDMG PLHKMDFIDOL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LKILNMKOKHH CHAPLCIPLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LKILNMKOKHH LFKBBEGBPCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration LJNLINKHHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6CA58A0", Offset = "0x6CA4CA0", VA = "0x186CA58A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BMFEHMICIHN DFMKHMJNACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CED0", Offset = "0x6C9C2D0", VA = "0x186C9CED0", Slot = "23")]
		get
		{
			return default(BMFEHMICIHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration GOFOCJEHIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6CA09E0", Offset = "0x6C9FDE0", VA = "0x186CA09E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform AHKCNAOHICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C99FA0", Offset = "0x6C993A0", VA = "0x186C99FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform BABCIHIGNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C99D50", Offset = "0x6C99150", VA = "0x186C99D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer CMLNBPHMNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8EA0", Offset = "0x6CA82A0", VA = "0x186CA8EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] OJCEJMJLLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6540", Offset = "0x6CA5940", VA = "0x186CA6540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] FFOBMBJNJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C9EC80", Offset = "0x6C9E080", VA = "0x186C9EC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator FADENJCKEND
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C99AF0", Offset = "0x6C98EF0", VA = "0x186C99AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK KCIIIPNNCMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7BC0", Offset = "0x6CA6FC0", VA = "0x186CA7BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private HPNMBNLPJGF HOCPOLECAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C9BBE0", Offset = "0x6C9AFE0", VA = "0x186C9BBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private HPNMBNLPJGF KDPDDAEMCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7E50", Offset = "0x6CA7250", VA = "0x186CA7E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private HPNMBNLPJGF AIBMNIAHEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7D50", Offset = "0x6CA7150", VA = "0x186CA7D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private HPNMBNLPJGF HAOJKCBANOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6CA16E0", Offset = "0x6CA0AE0", VA = "0x186CA16E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private HPNMBNLPJGF AGIJHNDBINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6C9EB80", Offset = "0x6C9DF80", VA = "0x186C9EB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private HPNMBNLPJGF IDLHPKCDEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6C96800", Offset = "0x6C95C00", VA = "0x186C96800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private HPNMBNLPJGF PKAJFDCKEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8DA0", Offset = "0x6CA81A0", VA = "0x186CA8DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private HPNMBNLPJGF JMIGHECDMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7F50", Offset = "0x6CA7350", VA = "0x186CA7F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public MEDIMDINCLB FNNAGPIDBEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F7D0", Offset = "0x6C9EBD0", VA = "0x186C9F7D0", Slot = "15")]
		get
		{
			return default(MEDIMDINCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public EGBNLLANDDL KNCLNNMFPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x95E7D0", Offset = "0x95DBD0", VA = "0x18095E7D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public JPHLGKLALBA OAKJOHMJHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x95E700", Offset = "0x95DB00", VA = "0x18095E700", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public MDEEHEDBKBP KBCEICNNLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x95E7F0", Offset = "0x95DBF0", VA = "0x18095E7F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MDEEHEDBKBP GJNCKAACIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x18ACBE0", Offset = "0x18ABFE0", VA = "0x1818ACBE0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string OAGMJBJDHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform ODLBOEJKHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C9ED80", Offset = "0x6C9E180", VA = "0x186C9ED80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform LIANPIFMJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D930", Offset = "0x6C9CD30", VA = "0x186C9D930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform CBBLFNOJJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C110", Offset = "0x6C9B510", VA = "0x186C9C110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private bool BGNILCGBKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8640", Offset = "0x6CA7A40", VA = "0x186CA8640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private Transform KALLLMCEKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6CA24C0", Offset = "0x6CA18C0", VA = "0x186CA24C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GameObject JPONDMDOHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0A70", Offset = "0x6C9FE70", VA = "0x186CA0A70", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HeadLogicOffsets MLIKGMDACIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5F20", Offset = "0x6CA5320", VA = "0x186CA5F20", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform KFECFBONCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x18AC930", Offset = "0x18ABD30", VA = "0x1818AC930", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform DOIKNILGMPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x18ACBC0", Offset = "0x18ABFC0", VA = "0x1818ACBC0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform OEILNKINANH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xE1DB90", Offset = "0xE1CF90", VA = "0x180E1DB90", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform JGIFPDFHEAP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1629890", Offset = "0x1628C90", VA = "0x181629890", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 OJNMLDHLEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7CC0", Offset = "0x6CA70C0", VA = "0x186CA7CC0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float BDELCDANJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C959A0", Offset = "0x6C94DA0", VA = "0x186C959A0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Transform HDPBNOFMEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2460", Offset = "0x6CA1860", VA = "0x186CA2460", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Transform BCFNNKEIGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4680", Offset = "0x1BB3A80", VA = "0x181BB4680", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Transform ACEBBPILEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1BB4760", Offset = "0x1BB3B60", VA = "0x181BB4760", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Transform PEFEDKPOCFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x162A460", Offset = "0x1629860", VA = "0x18162A460", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool CHAANCGBGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3630", Offset = "0x6CA2A30", VA = "0x186CA3630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool PIFPAJHCMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6C98E00", Offset = "0x6C98200", VA = "0x186C98E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool GJMONPBHFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C9D690", Offset = "0x6C9CA90", VA = "0x186C9D690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8FA0", Offset = "0x6CA83A0", VA = "0x186CA8FA0")]
	private void PGJEGBDADIL([In] LEJDNPAGPEF GPPPPGANGAJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE, bool POALJJEJLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAE00", Offset = "0x6CAA200", VA = "0x186CAAE00")]
	private float PHNPANKJHOM([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA08C0", Offset = "0x6C9FCC0", VA = "0x186CA08C0")]
	private float JOBOMMKIPBO([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CA90", Offset = "0x6C9BE90", VA = "0x186C9CA90")]
	private void FMKHPFGLDDL(LEJDNPAGPEF GPPPPGANGAJ, AvatarFullBodyConfiguration IBOPOOBMBOE, bool POALJJEJLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2D90", Offset = "0x6CA2190", VA = "0x186CA2D90")]
	private void LJCPJGHPIJO([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8050", Offset = "0x6CA7450", VA = "0x186CA8050")]
	private void ONPOBOADLHC([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6CABFF0", Offset = "0x6CAB3F0", VA = "0x186CABFF0")]
	public ELGGBEMELAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7150", Offset = "0x6CA6550", VA = "0x186CA7150", Slot = "12")]
	public void OECKONBOLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A0A0", Offset = "0x6C994A0", VA = "0x186C9A0A0", Slot = "13")]
	public void EBDBLICHMNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C9C0", Offset = "0x6C9BDC0", VA = "0x186C9C9C0", Slot = "14")]
	public void FMIAHOFAGPE(bool MJENIHLHNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6C99E50", Offset = "0x6C99250", VA = "0x186C99E50", Slot = "25")]
	public Transform DLFMCDBJHBH(string MOGIFHOJGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6CA59A0", Offset = "0x6CA4DA0", VA = "0x186CA59A0", Slot = "26")]
	public Vector3? NHEFDINCKFD(string MOGIFHOJGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0CD0", Offset = "0x6CA00D0", VA = "0x186CA0CD0", Slot = "7")]
	public void KMIDGHEEHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB550", Offset = "0x6CAA950", VA = "0x186CAB550")]
	private void PLHHNGHJOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9A530", Offset = "0x6C99930", VA = "0x186C9A530", Slot = "6")]
	public void EEBGGLODIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D9A0", Offset = "0x6C9CDA0", VA = "0x186C9D9A0", Slot = "8")]
	public void GOHKLFDDGNN(float FCPHCBOCOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E810", Offset = "0x6C9DC10", VA = "0x186C9E810")]
	private void HKPPHNIMEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C96E10", Offset = "0x6C96210", VA = "0x186C96E10", Slot = "4")]
	public void CKKIMBHLEMG(string GAHABAHIGCD, HEDEKFGCFKP JLACDCJFJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA660", Offset = "0x6CA9A60", VA = "0x186CAA660", Slot = "5")]
	public void PGPAGKDOLEC(MEDIMDINCLB CCJBOCICBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F140", Offset = "0x6C9E540", VA = "0x186C9F140", Slot = "11")]
	public void JAFJJCHCBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2F50", Offset = "0x6CA2350", VA = "0x186CA2F50", Slot = "24")]
	public void LKNGKAHHLID([Out] Vector3 LKLDGADLNHM, [Out] Quaternion GBAFDJFPNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6CA16B0", Offset = "0x6CA0AB0", VA = "0x186CA16B0")]
	private void KPGHPLDOEIB([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C94F10", Offset = "0x6C94310", VA = "0x186C94F10", Slot = "27")]
	public void BHNFLHHMEAC(float OLBECPIGPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6CA32E0", Offset = "0x6CA26E0", VA = "0x186CA32E0", Slot = "28")]
	public void LMCPDHCEKPH(float HIOALHMCJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7020", Offset = "0x6CA6420", VA = "0x186CA7020", Slot = "44")]
	public void ODKLJBIBMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0940", Offset = "0x6C9FD40", VA = "0x186CA0940", Slot = "29")]
	public void KBFHCBHPNCC(bool GBNFAPELOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0990", Offset = "0x6C9FD90", VA = "0x186CA0990", Slot = "30")]
	public HandLogicOffsets KEFJCGNOLDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F4F0", Offset = "0x6C9E8F0", VA = "0x186C9F4F0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets JEHABOKMPMM()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8C40", Offset = "0x6CA8040", VA = "0x186CA8C40")]
	private void PDPEPOLONCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C934E0", Offset = "0x6C928E0", VA = "0x186C934E0")]
	private void ANNGGOCCGGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C350", Offset = "0x6C9B750", VA = "0x186C9C350")]
	private void FJEPMBJHBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7770", Offset = "0x6CA6B70", VA = "0x186CA7770")]
	private void OFFILIPLLGD(NADAIAGKPNF IKAEFBCKFFO, bool FHCBEIGKGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3A50", Offset = "0x6CA2E50", VA = "0x186CA3A50")]
	private void MDGBGBNDDLP(NADAIAGKPNF IKAEFBCKFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C94240", Offset = "0x6C93640", VA = "0x186C94240")]
	public Vector3 BCNBEHKFLGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C94C50", Offset = "0x6C94050", VA = "0x186C94C50")]
	private void BGAEKOFMGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C180", Offset = "0x6C9B580", VA = "0x186C9C180")]
	private void FGGLPCHOCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C95E20", Offset = "0x6C95220", VA = "0x186C95E20")]
	private void CHAPIEKFOMD(LEJDNPAGPEF GPPPPGANGAJ, AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C1A0", Offset = "0x6C9B5A0", VA = "0x186C9C1A0")]
	private float FIBFPIKJFEH([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0B10", Offset = "0x6C9FF10", VA = "0x186CA0B10")]
	private int KKOBBGBCKAM([In] HHMKGBKOOEK EGNFDGDPFJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2870", Offset = "0x6CA1C70", VA = "0x186CA2870")]
	private void LIJCBBPMEMK(LEJDNPAGPEF GPPPPGANGAJ, bool PGEAJGOABIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C95790", Offset = "0x6C94B90", VA = "0x186C95790")]
	private static void BNLJIFAGBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C9AEB0", Offset = "0x6C9A2B0", VA = "0x186C9AEB0")]
	private static void ELBOEADEMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA06E0", Offset = "0x6C9FAE0", VA = "0x186CA06E0")]
	private float JNHCMBBGDMO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0BF0", Offset = "0x6C9FFF0", VA = "0x186CA0BF0")]
	private static int KLFJCOMJKNH(ELGGBEMELAJ EHOEECMJEAD, ELGGBEMELAJ CPKKNGGFDGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C99BF0", Offset = "0x6C98FF0", VA = "0x186C99BF0", Slot = "40")]
	public LEJDNPAGPEF DFANPIGEKDG()
	{
		return default(LEJDNPAGPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0430", Offset = "0x6C9F830", VA = "0x186CA0430")]
	public void JJABJECCIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F5B0", Offset = "0x6C9E9B0", VA = "0x186C9F5B0")]
	private (bool, bool) JGEINFGJAIJ()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7A50", Offset = "0x6CA6E50", VA = "0x186CA7A50")]
	private (float, float) OFOBCIGHHPE([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3CA0", Offset = "0x6CA30A0", VA = "0x186CA3CA0")]
	private void MGGCIGOGKAP([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3730", Offset = "0x6CA2B30", VA = "0x186CA3730")]
	private void LPGKPNNPJPJ([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6640", Offset = "0x6CA5A40", VA = "0x186CA6640")]
	private void OCGFHDMBJDC([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5480", Offset = "0x6CA4880", VA = "0x186CA5480")]
	private void MILMJFCBGGF([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE, FootSettings AIPKBHGFOOC, bool HANIBHIKCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D710", Offset = "0x6C9CB10", VA = "0x186C9D710")]
	private float GDDNMINFPHP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F900", Offset = "0x6C9ED00", VA = "0x186C9F900")]
	private void JIBIDCEIAEE(LEJDNPAGPEF NOGEMBGGBHJ, AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EB30", Offset = "0x6C9DF30", VA = "0x186C9EB30")]
	private float IGPKBPGGIDA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8150", Offset = "0x6CA7550", VA = "0x186CA8150")]
	private void OOLDNHFBJLD([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5FA0", Offset = "0x6CA53A0", VA = "0x186CA5FA0")]
	private void NPJHKOBJMCB([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5B30", Offset = "0x6CA4F30", VA = "0x186CA5B30")]
	private void NKPELMLIPAO([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA25C0", Offset = "0x6CA19C0", VA = "0x186CA25C0")]
	private void LIGGFDPJMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA62F0", Offset = "0x6CA56F0", VA = "0x186CA62F0")]
	private void OBJGGHMHKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C93340", Offset = "0x6C92740", VA = "0x186C93340")]
	private void ACEPOMLHPGF([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E860", Offset = "0x6C9DC60", VA = "0x186C9E860")]
	private void HMGDBKJPPHF(CBPBGFNCOOF MANLMMJPHIP, IKSolverVR.Arm ILIOKGAIENO, Transform LAOHODEHIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EDD0", Offset = "0x6C9E1D0", VA = "0x186C9EDD0")]
	private void IMOBFEBAAIA(LEJDNPAGPEF NOGEMBGGBHJ, AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA14E0", Offset = "0x6CA08E0", VA = "0x186CA14E0")]
	private void KOPNFPPDJEM(HNKCNCFNFJH MMJFNDGNHAA, MDEEHEDBKBP MANLMMJPHIP, IKSolverVR.Arm ILIOKGAIENO, float NMHPFCIFGIC, float JILPNMDOLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CFD0", Offset = "0x6C9C3D0", VA = "0x186C9CFD0")]
	private void FNLBMCGAACF([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C5C0", Offset = "0x6C9B9C0", VA = "0x186C9C5C0")]
	protected void FJKCIONALHB([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAB20", Offset = "0x6CA9F20", VA = "0x186CAAB20")]
	private void PHMADEJFKIH([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DE10", Offset = "0x6C9D210", VA = "0x186C9DE10")]
	protected void HFGGBNJPOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6C98E80", Offset = "0x6C98280", VA = "0x186C98E80")]
	private void DALEMIDDLEG([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] GCAENLPPHJN FIBIBDGLPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6C93EC0", Offset = "0x6C932C0", VA = "0x186C93EC0")]
	private void BADKJOADIMB(LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6C9EAF0", Offset = "0x6C9DEF0", VA = "0x186C9EAF0")]
	private void IDFEBPFNNCO([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C96900", Offset = "0x6C95D00", VA = "0x186C96900")]
	private Vector3 CKGKCJAENLN([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DD40", Offset = "0x6C9D140", VA = "0x186C9DD40")]
	private void HBKCOLMKPEL([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6C959F0", Offset = "0x6C94DF0", VA = "0x186C959F0")]
	private float CDHPOCGBIOO(float DPAGICBJIAA, [In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6C99600", Offset = "0x6C98A00", VA = "0x186C99600")]
	private void DCILEPBBIIP(float DPAGICBJIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA17E0", Offset = "0x6CA0BE0", VA = "0x186CA17E0")]
	private void LCNGFDDIELO([In] LEJDNPAGPEF NOGEMBGGBHJ, GCAENLPPHJN FIBIBDGLPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAE90", Offset = "0x6CAA290", VA = "0x186CAAE90")]
	private float PJAGIEKOCJF([In] LEJDNPAGPEF GPPPPGANGAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C93910", Offset = "0x6C92D10", VA = "0x186C93910")]
	private void ANOJAOGMCAO(LEJDNPAGPEF NOGEMBGGBHJ, GCAENLPPHJN FIBIBDGLPLP, Vector3 JDPFHJPNEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F230", Offset = "0x6C9E630", VA = "0x186C9F230")]
	private static void JBGPOBOOBDM(Transform ADJOLMKPBJM, Quaternion EFFHGIJAIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DA10", Offset = "0x6C9CE10", VA = "0x186C9DA10")]
	private void HAJNAKBLEIP([In] LEJDNPAGPEF EAEDABDCCMH, [In] HHMKGBKOOEK EGNFDGDPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6C94F20", Offset = "0x6C94320", VA = "0x186C94F20")]
	private void BNBNBAAGABD([In] LEJDNPAGPEF EAEDABDCCMH, [In] HHMKGBKOOEK EGNFDGDPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8690", Offset = "0x6CA7A90", VA = "0x186CA8690")]
	private void PBBMLKOHKPO(float PHMGFKEAJKF, [In] LEJDNPAGPEF GPPPPGANGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E0D0", Offset = "0x6C9D4D0", VA = "0x186C9E0D0")]
	private float HIPCBNEEFJD([In] LEJDNPAGPEF GPPPPGANGAJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0470", Offset = "0x6C9F870", VA = "0x186CA0470")]
	private void JJBJMJOBJKE([In] LEJDNPAGPEF GPPPPGANGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1C80", Offset = "0x6CA1080", VA = "0x186CA1C80")]
	private void LDEHBPCIDGL([In] LEJDNPAGPEF GPPPPGANGAJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6C99750", Offset = "0x6C98B50", VA = "0x186C99750")]
	private void DDBLDAAENIP([In] LEJDNPAGPEF GPPPPGANGAJ, float FJFILDOOELJ, float FKCKEKBNPKN, Vector3 KEGNFJFCINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6C94290", Offset = "0x6C93690", VA = "0x186C94290")]
	private void BELEKIFKGPE(LEJDNPAGPEF GPPPPGANGAJ, AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8840", Offset = "0x6CA7C40", VA = "0x186CA8840")]
	private void PCOIDLNLFNF(LEJDNPAGPEF GPPPPGANGAJ, AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6C94070", Offset = "0x6C93470", VA = "0x186C94070")]
	public void BADMNGMONMN([In] LEJDNPAGPEF NOGEMBGGBHJ, [In] AvatarFullBodyConfiguration IBOPOOBMBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D790", Offset = "0x6C9CB90", VA = "0x186C9D790")]
	[CompilerGenerated]
	internal static void GJLGPDKDECD(Transform CAAJFPBAGHE, IKSolverVR.Arm ILIOKGAIENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0C20", Offset = "0x6CA0020", VA = "0x186CA0C20")]
	[CompilerGenerated]
	internal static void KLGOJGBGBLG(Vector3 GFHELKGAOCF, Vector3 GMIJDEHEIDD, KAOGIEAMDKF P_2, KPBOJKJLPKJ P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3C00", Offset = "0x6CA3000", VA = "0x186CA3C00")]
	[CompilerGenerated]
	internal static void MGAOAIPIAON(CKGHKGDHBPP GHFMMCFGKAD, CKGHKGDHBPP CNPAKNCKEEC, Vector3 IAAGPLJACAH, float GJAHCEMFFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F3E0", Offset = "0x6C9E7E0", VA = "0x186C9F3E0")]
	[CompilerGenerated]
	internal static bool JEADLMGPGJI(IKSolverVR.Arm ILIOKGAIENO, MJJKOPMGBLO EINABLJOMPM, float BNFADPKGKME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6C9BCE0", Offset = "0x6C9B0E0", VA = "0x186C9BCE0")]
	[CompilerGenerated]
	internal static float FBFPCMGNCDL(Vector3 LABNHOHMEEL, Vector3 KCJFKBBHEMF, Vector3 NPMHNJHCKBN, LEJDNPAGPEF GPPPPGANGAJ, AvatarFullBodyConfiguration IBOPOOBMBOE, float GMCJIJBLJPF)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum ECNAHJDHEKM
		{
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private ECNAHJDHEKM handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF4A0", Offset = "0x6CAE8A0", VA = "0x186CAF4A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF460", Offset = "0x6CAE860", VA = "0x186CAF460")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEE60", Offset = "0x6CAE260", VA = "0x186CAEE60")]
		private void MPKIBCPIEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C57C20", Offset = "0x6C57020", VA = "0x186C57C20", Slot = "4")]
		public void SetEnabled(bool PNHMPKNFDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF4D0", Offset = "0x6CAE8D0", VA = "0x186CAF4D0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AvatarKneeBendTargetController : MonoBehaviour, HPNMBNLPJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Vector3 FCKGHOJCEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Vector3 JBIEOPFALPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Vector3 CMABIHBBLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Matrix4x4 EBDGMAFGPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private bool APGLHEDEIKJ;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF970", Offset = "0x6CAED70", VA = "0x186CAF970", Slot = "4")]
		public void UpdateController(float GJPMFKBAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF960", Offset = "0x6CAED60", VA = "0x186CAF960", Slot = "6")]
		public void SetEnabled(bool LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF500", Offset = "0x6CAE900", VA = "0x186CAF500")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0030", Offset = "0x6CAF430", VA = "0x186CB0030")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, CLKBPNJIOJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		[Header("Configuration")]
		private BMFEHMICIHN avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[GNGJGNLFLFE(GODLKEADDAA.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private MGFGEAEOMOC APOHGNFLIDH;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public MGFGEAEOMOC GMDMNIAIOJI
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x901E10", Offset = "0x901210", VA = "0x180901E10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Transform PKIMABBAPGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6CB0EC0", Offset = "0x6CB02C0", VA = "0x186CB0EC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0040", Offset = "0x6CAF440", VA = "0x186CB0040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0D80", Offset = "0x6CB0180", VA = "0x186CB0D80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0D30", Offset = "0x6CB0130", VA = "0x186CB0D30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0CC0", Offset = "0x6CB00C0", VA = "0x186CB0CC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0040", Offset = "0x6CAF440", VA = "0x186CB0040", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB04C0", Offset = "0x6CAF8C0", VA = "0x186CB04C0", Slot = "6")]
		public MGFGEAEOMOC CreateAvatarSystem(string GAHABAHIGCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0CC0", Offset = "0x6CB00C0", VA = "0x186CB0CC0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6CB00F0", Offset = "0x6CAF4F0", VA = "0x186CB00F0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0DD0", Offset = "0x6CB01D0", VA = "0x186CB0DD0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float GJPMFKBAIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[RecRoom.NoEngine.Common.Preserve]
internal class GNBJHCAFKOD : ANDIEAKLEHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<string, MGFGEAEOMOC> CKICGEGDCLD;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8350", Offset = "0x6CB7750", VA = "0x186CB8350")]
	[FHFMOACGLML.PCGBCKINAAE]
	internal static void GMMJCFGKGCN(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6CB83C0", Offset = "0x6CB77C0", VA = "0x186CB83C0", Slot = "4")]
	public MGFGEAEOMOC IFFOBHEHLMF(string PMFMCIHAJKK, AvatarSystemConfiguration JADMOJIMCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6CB81D0", Offset = "0x6CB75D0", VA = "0x186CB81D0", Slot = "5")]
	public void FCLCDLEGDBM(string PMFMCIHAJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6CB85E0", Offset = "0x6CB79E0", VA = "0x186CB85E0", Slot = "6")]
	public string JNLGICLDDHK(string IDIPNIEODLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8160", Offset = "0x6CB7560", VA = "0x186CB8160")]
	private string CPCCCGGMOPH(string IDIPNIEODLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8720", Offset = "0x6CB7B20", VA = "0x186CB8720")]
	public GNBJHCAFKOD()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class FACELHIEEGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private Dictionary<string, Transform> JJKCPGFMFPA;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public bool KGFOOIOHGJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x6CB5320", Offset = "0x6CB4720", VA = "0x186CB5320")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x6CB51F0", Offset = "0x6CB45F0", VA = "0x186CB51F0")]
			public void CMFNIKNNNFK(VRIK IDFPKNAHAMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
			public void KMGGCNFNJFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6CB51A0", Offset = "0x6CB45A0", VA = "0x186CB51A0")]
			public void AEAEDDMNDLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6CB5360", Offset = "0x6CB4760", VA = "0x186CB5360")]
			public FACELHIEEGK()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		[KKFPOGPNFEA(GODLKEADDAA.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[GNGJGNLFLFE(GODLKEADDAA.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly FACELHIEEGK FLAJOODGCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private CLKBPNJIOJI IDOJHJGJBBI;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB0F10", Offset = "0x6CB0310", VA = "0x186CB0F10")]
		private void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB11F0", Offset = "0x6CB05F0", VA = "0x186CB11F0")]
		private bool MDPBPHJHLLM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1240", Offset = "0x6CB0640", VA = "0x186CB1240")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB12B0", Offset = "0x6CB06B0", VA = "0x186CB12B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1250", Offset = "0x6CB0650", VA = "0x186CB1250")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1520", Offset = "0x6CB0920", VA = "0x186CB1520")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAD10", Offset = "0x6CBA110", VA = "0x186CBAD10")]
		public void LHMGAKDCLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6CBACA0", Offset = "0x6CBA0A0", VA = "0x186CBACA0")]
		public int ILBCKODOAMJ(int JAEMHEKFLPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HandDisplaySettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6CBAF70", Offset = "0x6CBA370", VA = "0x186CBAF70")]
			public void LHMGAKDCLGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x6CBAE30", Offset = "0x6CBA230", VA = "0x186CBAE30")]
			public (float, float) HOGDAIBLGBE(Animator GKPMMANMEPJ, AnimatorStateInfo HNKLKGECLOG)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB450", Offset = "0x6CBA850", VA = "0x186CBB450")]
		public void LHMGAKDCLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB240", Offset = "0x6CBA640", VA = "0x186CBB240")]
		public (float, float) HGGOOAOBNGP(Animator GKPMMANMEPJ)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB050", Offset = "0x6CBA450", VA = "0x186CBB050")]
		private (float, float) CABIJEIOJAJ(Animator GKPMMANMEPJ, AnimatorStateInfo HNKLKGECLOG)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB640", Offset = "0x6CBAA40", VA = "0x186CBB640")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD280", Offset = "0x6CBC680", VA = "0x186CBD280", Slot = "4")]
		public override void OnStateEnter(Animator GKPMMANMEPJ, AnimatorStateInfo HNKLKGECLOG, int FNFMCKKJAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD3E0", Offset = "0x6CBC7E0", VA = "0x186CBD3E0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal abstract class ANJIBOBLALL<TInput, TOutput> : IJLBHMEOMFM<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	protected readonly GOLAIFJFJFA DPKKJKPNDNP;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x412B5B0", Offset = "0x412A9B0", VA = "0x18412B5B0")]
	protected ANJIBOBLALL(GOLAIFJFJFA DPKKJKPNDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput GEBAPMNFHGF(TInput GJMNBMBONPJ, [Out] IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x412B510", Offset = "0x412A910", VA = "0x18412B510", Slot = "5")]
	public bool FBBKDIEKADC(TInput GJMNBMBONPJ, [Out] TOutput? CIFMGKBFCHA, [Out] IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[NFAHBLEIIKC]
public static class OOKLHFJHCGL
{
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly Regex NCGCKHLDKGL;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD560", Offset = "0x6CBC960", VA = "0x186CBD560")]
	public static HAJALDHAKAI LLJEOMCPMKC(LIPMOPEKLJE MEKMCBBOPDI, MLLCBKIBLJC BPJHMJOCLAM, Guid? GIIHIDHDOHJ, Color? BIFDFOCDDEN, KJCIGENAPJO FHPOINKIBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD400", Offset = "0x6CBC800", VA = "0x186CBD400")]
	public static KGFBNKJDMOF KJPAHOBIJID(HAJALDHAKAI MPMEGOKIEPF)
	{
		return default(KGFBNKJDMOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD080", Offset = "0x2FFC480", VA = "0x182FFD080")]
	internal static TModern? GIDCLBBNMBC<TModern>(string? GJMNBMBONPJ, DBFDHKFKOJC<TModern> FHPNBDHPHCI, GOLAIFJFJFA DPKKJKPNDNP, KPEIFHOPEIC HOOAHAKCAEE, TModern DCENDNCDHDI) where TModern : struct, MFFOALEFBNJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2FFF4F0", Offset = "0x2FFE8F0", VA = "0x182FFF4F0")]
	internal static KGNNALKEFFG PCDNHHGDBBH<TModern>(string? GJMNBMBONPJ, DBFDHKFKOJC<TModern> FHPNBDHPHCI, GOLAIFJFJFA DPKKJKPNDNP, KPEIFHOPEIC HOOAHAKCAEE, TModern DCENDNCDHDI) where TModern : struct, MFFOALEFBNJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD770", Offset = "0x6CBCB70", VA = "0x186CBD770")]
	internal static List<ACLMNPMHHND> PLDMCKMIMIJ(IEnumerable<MMJIMGHBFOB>? NOBEFMOPGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2FFE6D0", Offset = "0x2FFDAD0", VA = "0x182FFE6D0")]
	internal static string OCCBJBGLMAO<TModern>(TModern GJMNBMBONPJ, DBFDHKFKOJC<TModern> FHPNBDHPHCI, GOLAIFJFJFA DPKKJKPNDNP) where TModern : MFFOALEFBNJ
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class CHAELPMDHOJ : MCLKMPDEOBG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IJLBHMEOMFM<LNCDIMNAFAB, MHDJBPMNPGJ> FCDEDLPFMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public IJLBHMEOMFM<EPALDFBFDLE, AFOHDPIACBB> GAMMLDJJFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IJLBHMEOMFM<EPALDFBFDLE, AFOHDPIACBB> HBMBKLMDKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public ANCAJDGJNKD ILFBKLEFMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public KAJLMLDBBKI GEJNCEIJFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1B20", Offset = "0x6CB0F20", VA = "0x186CB1B20")]
	[UsedImplicitly]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	internal static void LHDMPKJJCIL(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1B90", Offset = "0x6CB0F90", VA = "0x186CB1B90")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CHAELPMDHOJ([ACGOIOBGIEE("UnitySerialization")] IJEBOPONAGG HMOGCIPGGFP, [ACGOIOBGIEE(null)] BGKIAOHIJGJ DLFPAKKIEDP, [ACGOIOBGIEE(null)] GOLAIFJFJFA DPKKJKPNDNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum MPAFBLJIADL
{
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JPHCCBNCBNI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBAE0", Offset = "0x6CBAEE0", VA = "0x186CBBAE0")]
	public JPHCCBNCBNI(string ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBB50", Offset = "0x6CBAF50", VA = "0x186CBBB50")]
	public JPHCCBNCBNI(string ADPAIBGIHMB, Exception JHBBMCGELMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBB80", Offset = "0x6CBAF80", VA = "0x186CBBB80")]
	public JPHCCBNCBNI(MPAFBLJIADL IABOOOMGHFL, string ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBB10", Offset = "0x6CBAF10", VA = "0x186CBBB10")]
	public JPHCCBNCBNI(MPAFBLJIADL IABOOOMGHFL, string ADPAIBGIHMB, Exception JHBBMCGELMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal abstract class HABKAEMCPDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private readonly IJEBOPONAGG HMOGCIPGGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	protected readonly BGKIAOHIJGJ DLFPAKKIEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	protected readonly GOLAIFJFJFA DPKKJKPNDNP;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA0D0", Offset = "0x6CB94D0", VA = "0x186CBA0D0")]
	protected HABKAEMCPDB(IJEBOPONAGG HMOGCIPGGFP, BGKIAOHIJGJ DLFPAKKIEDP, GOLAIFJFJFA DPKKJKPNDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8990", Offset = "0x6CB7D90", VA = "0x186CB8990")]
	protected string JPKDMKJOEBA(MHDJBPMNPGJ OIFJOOICJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6CB87B0", Offset = "0x6CB7BB0", VA = "0x186CB87B0")]
	protected string INIGJMJPLAB(MHDJBPMNPGJ OIFJOOICJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9DA0", Offset = "0x6CB91A0", VA = "0x186CB9DA0")]
	private AvatarOutfitSelectionData LLJEOMCPMKC(HAJALDHAKAI FDLDIFDNNPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9C60", Offset = "0x6CB9060", VA = "0x186CB9C60")]
	private static AvatarCustomizationSettingsData.AnchorParams LIHPHPIIJCM(PIMBILBNCGP? BGBBEPBMPLJ)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IJLBHMEOMFM<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput GEBAPMNFHGF(TInput GJMNBMBONPJ, [Out] IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FBBKDIEKADC(TInput GJMNBMBONPJ, [Out] TOutput? CIFMGKBFCHA, [Out] IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MCLKMPDEOBG
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	IJLBHMEOMFM<LNCDIMNAFAB, MHDJBPMNPGJ> FCDEDLPFMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	IJLBHMEOMFM<EPALDFBFDLE, AFOHDPIACBB> HBMBKLMDKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	ANCAJDGJNKD ILFBKLEFMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal enum KPEIFHOPEIC
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface KAJLMLDBBKI
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJHKGFKGDIO KEEAKGCJIOB(MHDJBPMNPGJ MPMEGOKIEPF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface ANCAJDGJNKD
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPALDFBFDLE KEEAKGCJIOB(MHDJBPMNPGJ MPMEGOKIEPF, int JLLMACKDECJ, string? ADANIHOIEKJ, string? KKKLDKNLEIP, EIIAMCIDOPM LJCPEALDJMF, List<ACLMNPMHHND>? BCFBCEDPCLI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NFAHBLEIIKC]
internal class CHPICOFMJOI : ANJIBOBLALL<LNCDIMNAFAB, MHDJBPMNPGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly BGKIAOHIJGJ DLFPAKKIEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly FPPMKHLDLCB OFEDKBNCJBD;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2390", Offset = "0x6CB1790", VA = "0x186CB2390")]
	public CHPICOFMJOI(IJEBOPONAGG HMOGCIPGGFP, BGKIAOHIJGJ DLFPAKKIEDP, GOLAIFJFJFA DPKKJKPNDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB20F0", Offset = "0x6CB14F0", VA = "0x186CB20F0", Slot = "6")]
	public override MHDJBPMNPGJ GEBAPMNFHGF(LNCDIMNAFAB GJMNBMBONPJ, [Out] IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[RecRoom.NoEngine.Common.Preserve]
internal class HDFKIJHPKMC : IJEBOPONAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class HLILDCKOFBM : JsonConverter<KGNNALKEFFG>
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6CBABC0", Offset = "0x6CB9FC0", VA = "0x186CBABC0", Slot = "9")]
		public override void WriteJson(JsonWriter NPFBBELPJIH, KGNNALKEFFG? LIHHDPOHLDK, JsonSerializer FDANEFMKLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAAA0", Offset = "0x6CB9EA0", VA = "0x186CBAAA0", Slot = "10")]
		public override KGNNALKEFFG ReadJson(JsonReader OJMAIJPBMNC, Type ABIBDGNCHJK, KGNNALKEFFG? DECKHMLAEBC, bool OMIEKGAFCNA, JsonSerializer FDANEFMKLAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAC60", Offset = "0x6CBA060", VA = "0x186CBAC60")]
		public HLILDCKOFBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class BLFPEBHLIIF : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override bool EHJGGENMNMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6CB19E0", Offset = "0x6CB0DE0", VA = "0x186CB19E0", Slot = "5")]
		public override object ReadJson(JsonReader OJMAIJPBMNC, Type ABIBDGNCHJK, object? DECKHMLAEBC, JsonSerializer FDANEFMKLAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1600", Offset = "0x6CB0A00", VA = "0x186CB1600", Slot = "6")]
		public override bool CanConvert(Type ABIBDGNCHJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1A40", Offset = "0x6CB0E40", VA = "0x186CB1A40", Slot = "4")]
		public override void WriteJson(JsonWriter NPFBBELPJIH, object? LIHHDPOHLDK, JsonSerializer FDANEFMKLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6CB17E0", Offset = "0x6CB0BE0", VA = "0x186CB17E0")]
		private static bool FOLPJCJDGGF(object LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public BLFPEBHLIIF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly JsonSerializerSettings LDMELPIIKID;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA940", Offset = "0x6CB9D40", VA = "0x186CBA940")]
	internal HDFKIJHPKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C910", Offset = "0x2E7BD10", VA = "0x182E7C910", Slot = "4")]
	public string CJNADGEIMHG<T>(T PBAACPJGKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C880", Offset = "0x2E7BC80", VA = "0x182E7C880", Slot = "5")]
	public T BNACKFJEJMK<T>(string LIHHDPOHLDK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RecRoom.NoEngine.Common.Preserve]
internal class OBFKIGNHFNK : IJEBOPONAGG
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1F00", Offset = "0x2FF1300", VA = "0x182FF1F00", Slot = "4")]
	public string CJNADGEIMHG<T>(T PBAACPJGKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1E80", Offset = "0x2FF1280", VA = "0x182FF1E80", Slot = "5")]
	public T BNACKFJEJMK<T>(string LIHHDPOHLDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public OBFKIGNHFNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[NFAHBLEIIKC]
internal class FPPMKHLDLCB : ANJIBOBLALL<EPALDFBFDLE, AFOHDPIACBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly IJEBOPONAGG HMOGCIPGGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly BGKIAOHIJGJ DLFPAKKIEDP;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7D30", Offset = "0x6CB7130", VA = "0x186CB7D30")]
	public FPPMKHLDLCB(IJEBOPONAGG HMOGCIPGGFP, BGKIAOHIJGJ DLFPAKKIEDP, GOLAIFJFJFA DPKKJKPNDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5F80", Offset = "0x6CB5380", VA = "0x186CB5F80", Slot = "6")]
	public override AFOHDPIACBB GEBAPMNFHGF(EPALDFBFDLE GJMNBMBONPJ, [Out] IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB59D0", Offset = "0x6CB4DD0", VA = "0x186CB59D0")]
	internal void DCACDAHCLLM(string FFGELKCDDBL, MHDJBPMNPGJ OIFJOOICJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5920", Offset = "0x6CB4D20", VA = "0x186CB5920")]
	public IEnumerable<HAJALDHAKAI> BCBNFONDGJH(string KGBCGCMBIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7910", Offset = "0x6CB6D10", VA = "0x186CB7910")]
	private IEnumerable<HAJALDHAKAI> PMENCHDHCPH(string KGBCGCMBIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5B30", Offset = "0x6CB4F30", VA = "0x186CB5B30")]
	internal IEnumerable<HAJALDHAKAI> EEEJJBALMNE(string KGBCGCMBIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7280", Offset = "0x6CB6680", VA = "0x186CB7280")]
	private HAJALDHAKAI MJKHKHEPPDB(AvatarOutfitSelectionData GEBNHIDOJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6500", Offset = "0x6CB5900", VA = "0x186CB6500")]
	private void HDEBPNOMCCD(AvatarCustomizationSettingsData EBIGCOKKJDA, MHDJBPMNPGJ OIFJOOICJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7600", Offset = "0x6CB6A00", VA = "0x186CB7600")]
	private HAJALDHAKAI MJKHKHEPPDB(string CHOGFNMLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6F80", Offset = "0x6CB6380", VA = "0x186CB6F80")]
	internal static (KJCIGENAPJO, string, string) LJCKKJNCBDJ(string CHOGFNMLKHJ, GOLAIFJFJFA DPKKJKPNDNP)
	{
		return default((KJCIGENAPJO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6D80", Offset = "0x6CB6180", VA = "0x186CB6D80")]
	private GBFACCACHBL? JJGAAJJCCHO(string? FDANKBMKMCE, Vector2 CGCCLBJDJDB, float KOOBBKJOJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6CB63A0", Offset = "0x6CB57A0", VA = "0x186CB63A0")]
	private static PIMBILBNCGP HBHOMOPFOJC(AvatarCustomizationSettingsData.AnchorParams HDFKIOJKHHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[NFAHBLEIIKC]
internal class HDDLDKKAJAL : HABKAEMCPDB, KAJLMLDBBKI
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA0D0", Offset = "0x6CB94D0", VA = "0x186CBA0D0")]
	public HDDLDKKAJAL(IJEBOPONAGG HMOGCIPGGFP, BGKIAOHIJGJ DLFPAKKIEDP, GOLAIFJFJFA DPKKJKPNDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA590", Offset = "0x6CB9990", VA = "0x186CBA590", Slot = "4")]
	public OJHKGFKGDIO KEEAKGCJIOB(MHDJBPMNPGJ MPMEGOKIEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA250", Offset = "0x6CB9650", VA = "0x186CBA250")]
	private string BIJCKBCPEDH(MHDJBPMNPGJ OIFJOOICJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA350", Offset = "0x6CB9750", VA = "0x186CBA350")]
	private string JEFAAENBAFK(HAJALDHAKAI FDLDIFDNNPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[NFAHBLEIIKC]
internal class FAOGGKGBMMC : ANJIBOBLALL<EPALDFBFDLE, AFOHDPIACBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly IJEBOPONAGG HMOGCIPGGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly IJLBHMEOMFM<EPALDFBFDLE, AFOHDPIACBB> OBHDPMAJIEF;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5820", Offset = "0x6CB4C20", VA = "0x186CB5820")]
	public FAOGGKGBMMC(IJLBHMEOMFM<EPALDFBFDLE, AFOHDPIACBB> OBHDPMAJIEF, GOLAIFJFJFA DPKKJKPNDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6CB53F0", Offset = "0x6CB47F0", VA = "0x186CB53F0", Slot = "6")]
	public override AFOHDPIACBB GEBAPMNFHGF(EPALDFBFDLE GJMNBMBONPJ, [Out] IReadOnlyList<ACLMNPMHHND>? BCFBCEDPCLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[NFAHBLEIIKC]
internal class JBKOJIICONM : ANCAJDGJNKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly IJEBOPONAGG HMOGCIPGGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly KAJLMLDBBKI HFHICGNKKFB;

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB9F0", Offset = "0x6CBADF0", VA = "0x186CBB9F0")]
	public JBKOJIICONM(KAJLMLDBBKI HFHICGNKKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB650", Offset = "0x6CBAA50", VA = "0x186CBB650", Slot = "4")]
	public EPALDFBFDLE KEEAKGCJIOB(MHDJBPMNPGJ MPMEGOKIEPF, int JLLMACKDECJ, string? ADANIHOIEKJ, string? KKKLDKNLEIP, EIIAMCIDOPM LJCPEALDJMF, List<ACLMNPMHHND>? BCFBCEDPCLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RecRoom.NoEngine.Common.Preserve]
internal class DEPBAJONIHE : LABEAAGFFIC
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly Vector2 IACBMGFMCPP;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly Vector2 IBEMEOAHNNO;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly Vector2 IDNOGONODHF;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly Vector2 AFCOCFHMGDF;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static readonly Vector2 OGCLECDDALL;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static readonly Vector2 AEEOBPGDKAO;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static readonly Vector2 GOAIGHOIKAE;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly Vector2 ABKOMIKCOAG;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static readonly Vector2 AHOFABHBKPF;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly Vector2 EDIHAGBKFAO;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private static readonly Vector2 FFGGEKHOOLC;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly Vector2 IBMPIMIGEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Dictionary<BMFEHMICIHN, AvatarConfiguration> MJHOGEBNCED;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6CB39E0", Offset = "0x6CB2DE0", VA = "0x186CB39E0")]
	[FHFMOACGLML.PCGBCKINAAE]
	internal static void FJGMHLONPAJ(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB50F0", Offset = "0x6CB44F0", VA = "0x186CB50F0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DEPBAJONIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4960", Offset = "0x6CB3D60", VA = "0x186CB4960", Slot = "4")]
	public Vector2 MOFKMNMMAIM(FaceFeatureType FCENLFGCIJN, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3C80", Offset = "0x6CB3080", VA = "0x186CB3C80", Slot = "5")]
	public float GECJOGAOIND(FaceFeatureType FCENLFGCIJN, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3300", Offset = "0x6CB2700", VA = "0x186CB3300", Slot = "6")]
	public void AEHBLBMNBPG(BMFEHMICIHN JEIAKJBAGMN, AvatarConfiguration JADMOJIMCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3BD0", Offset = "0x6CB2FD0", VA = "0x186CB3BD0", Slot = "7")]
	public void GDPHKNBJJNI(BEAEHMFDGGP CDPLAOAAPOP, AvatarConfiguration FKGDGNOMPNB, BMFEHMICIHN OPKACNHBLMG, BMFEHMICIHN DCJBDINLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3DA0", Offset = "0x6CB31A0", VA = "0x186CB3DA0", Slot = "8")]
	public float HDKCDLDABAK(FaceFeatureType CMNNNENKABJ, float DNNOPLCLKII, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4E60", Offset = "0x6CB4260", VA = "0x186CB4E60", Slot = "9")]
	public float OMIKMNGCDNP(FaceFeatureType CMNNNENKABJ, float KOOBBKJOJLN, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6CB40A0", Offset = "0x6CB34A0", VA = "0x186CB40A0", Slot = "11")]
	public Vector2 IDMKAEIADIF(FaceFeatureType CMNNNENKABJ, Vector2 MPKABALDJDH, Vector2 FKBJHEIGOFM, Vector2 NACCMPPGHPE, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3DD0", Offset = "0x6CB31D0", VA = "0x186CB3DD0", Slot = "10")]
	public Vector2 HIDFKOCEDDO(FaceFeatureType CMNNNENKABJ, Vector2 EJCEKDDOAJO, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3D00", Offset = "0x6CB3100", VA = "0x186CB3D00")]
	private Vector2 HDFLLDMBABI(FaceFeatureType CMNNNENKABJ, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3480", Offset = "0x6CB2880", VA = "0x186CB3480")]
	private Vector2 BMKHHOBICIE(FaceFeatureType CMNNNENKABJ, Vector2 MPKABALDJDH, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4320", Offset = "0x6CB3720", VA = "0x186CB4320", Slot = "12")]
	public Vector2 KDONLCCBDJJ(FaceFeatureType CMNNNENKABJ, Vector2 EJCEKDDOAJO, Vector2 FKBJHEIGOFM, Vector2 NACCMPPGHPE, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4790", Offset = "0x6CB3B90", VA = "0x186CB4790", Slot = "13")]
	public float LADAMGFJAPI(FaceFeatureType CMNNNENKABJ, float KOOBBKJOJLN, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4700", Offset = "0x6CB3B00", VA = "0x186CB4700")]
	private float KPGHJFFCIHH(float GOCGGGCOOLH, float GGBNJANNJDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4D10", Offset = "0x6CB4110", VA = "0x186CB4D10")]
	private Vector2 NOBICHFMGIH(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3960", Offset = "0x6CB2D60", VA = "0x186CB3960")]
	private Vector2 FGMNHKKMNGM(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4E90", Offset = "0x6CB4290", VA = "0x186CB4E90")]
	private Vector2 OPKFFGJLCDK(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4AD0", Offset = "0x6CB3ED0", VA = "0x186CB4AD0")]
	private Vector2 MPKFPJELMON(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4C20", Offset = "0x6CB4020", VA = "0x186CB4C20")]
	private float NJDCBHLLFHJ(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3440", Offset = "0x6CB2840", VA = "0x186CB3440")]
	private float BBOCGGAKELA(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB46C0", Offset = "0x6CB3AC0", VA = "0x186CB46C0")]
	private float KKCCOPFOPFF(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB35E0", Offset = "0x6CB29E0", VA = "0x186CB35E0")]
	private float CDPCEJBLLOF(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB36F0", Offset = "0x6CB2AF0", VA = "0x186CB36F0")]
	private Vector2 DLCAOPDCEFB(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6CB37C0", Offset = "0x6CB2BC0", VA = "0x186CB37C0")]
	private Vector2 DPHCBIDJJPH(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4250", Offset = "0x6CB3650", VA = "0x186CB4250")]
	private Vector2 JDCMGANIPIA(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3370", Offset = "0x6CB2770", VA = "0x186CB3370")]
	private Vector2 AMBCFNPPDEA(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4B50", Offset = "0x6CB3F50", VA = "0x186CB4B50")]
	private Vector2 MPLEPFMCIDE(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4D90", Offset = "0x6CB4190", VA = "0x186CB4D90")]
	private Vector2 OKKADBJKOCD(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3890", Offset = "0x6CB2C90", VA = "0x186CB3890")]
	private Vector2 EJGPECFKJMO(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3620", Offset = "0x6CB2A20", VA = "0x186CB3620")]
	private Vector2 DEOAFICAODN(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3B00", Offset = "0x6CB2F00", VA = "0x186CB3B00")]
	private Vector2 FOLNECEDOBB(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4C60", Offset = "0x6CB4060", VA = "0x186CB4C60")]
	private Vector2 NJJHIBLLDLJ(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3FF0", Offset = "0x6CB33F0", VA = "0x186CB3FF0")]
	private Vector2 IBLBDDKGGGD(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3A50", Offset = "0x6CB2E50", VA = "0x186CB3A50")]
	private Vector2 FNMGIDADKMP(BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE560", Offset = "0x6CAD960", VA = "0x186CAE560")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GGIEHMCHOIL
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7E70", Offset = "0x6CB7270", VA = "0x186CB7E70")]
	public static KGFBNKJDMOF GEBAPMNFHGF(this NHJBCDGPHNK MPMEGOKIEPF)
	{
		return default(KGFBNKJDMOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8040", Offset = "0x6CB7440", VA = "0x186CB8040")]
	public static NHJBCDGPHNK KEEAKGCJIOB(this KGFBNKJDMOF CGEFCPFGFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7F80", Offset = "0x6CB7380", VA = "0x186CB7F80")]
	public static bool IGDBFMOFHFJ(this KGFBNKJDMOF CGEFCPFGFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7FE0", Offset = "0x6CB73E0", VA = "0x186CB7FE0")]
	public static bool KAIEHGLKCLP(this KGFBNKJDMOF CGEFCPFGFJD)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x50BD770", Offset = "0x50BCB70", VA = "0x1850BD770")]
			public AnchorParams(Vector2 MPKABALDJDH, Vector3 CDEFFIHHHEP, Vector3 IACOOKJGJPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6CAE4B0", Offset = "0x6CAD8B0", VA = "0x186CAE4B0")]
			internal PIMBILBNCGP KEEAKGCJIOB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private KHMENMBKJGL useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6CAED40", Offset = "0x6CAE140", VA = "0x186CAED40")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3FC2C10", Offset = "0x3FC2010", VA = "0x183FC2C10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9EB870", Offset = "0x9EAC70", VA = "0x1809EB870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA88500", Offset = "0xA87900", VA = "0x180A88500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5600", VA = "0x180CF6200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6CAEDE0", Offset = "0x6CAE1E0", VA = "0x186CAEDE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F30", Offset = "0x8A9330", VA = "0x1808A9F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xB81E40", Offset = "0xB81240", VA = "0x180B81E40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x13B3F50", Offset = "0x13B3350", VA = "0x1813B3F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC10", Offset = "0x8AF010", VA = "0x1808AFC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x6CAEE20", Offset = "0x6CAE220", VA = "0x186CAEE20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9C0030", Offset = "0x9BF430", VA = "0x1809C0030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xBBFE10", Offset = "0xBBF210", VA = "0x180BBFE10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x11B8360", Offset = "0x11B7760", VA = "0x1811B8360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8ADBE0", Offset = "0x8ACFE0", VA = "0x1808ADBE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8ADBB0", Offset = "0x8ACFB0", VA = "0x1808ADBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x44DD6C0", Offset = "0x44DCAC0", VA = "0x1844DD6C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9EFD40", Offset = "0x9EF140", VA = "0x1809EFD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8E1A60", Offset = "0x8E0E60", VA = "0x1808E1A60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8E1AC0", Offset = "0x8E0EC0", VA = "0x1808E1AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB20", Offset = "0x8AEF20", VA = "0x1808AFB20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8AFAA0", Offset = "0x8AEEA0", VA = "0x1808AFAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB40", Offset = "0x8AEF40", VA = "0x1808AFB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC20", Offset = "0x8AF020", VA = "0x1808AFC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC40", Offset = "0x8AF040", VA = "0x1808AFC40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8AFBF0", Offset = "0x8AEFF0", VA = "0x1808AFBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x919AC0", Offset = "0x918EC0", VA = "0x180919AC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xE05300", Offset = "0xE04700", VA = "0x180E05300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8AFA70", Offset = "0x8AEE70", VA = "0x1808AFA70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8AFBA0", Offset = "0x8AEFA0", VA = "0x1808AFBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x9EA8E0", Offset = "0x9E9CE0", VA = "0x1809EA8E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x9DFEB0", Offset = "0x9DF2B0", VA = "0x1809DFEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B10", Offset = "0x8B3F10", VA = "0x1808B4B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B40", Offset = "0x8B3F40", VA = "0x1808B4B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x963E50", Offset = "0x963250", VA = "0x180963E50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x9EEB60", Offset = "0x9EDF60", VA = "0x1809EEB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xD08A00", Offset = "0xD07E00", VA = "0x180D08A00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1016C80", Offset = "0x1016080", VA = "0x181016C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public KHMENMBKJGL UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA8DA30", Offset = "0xA8CE30", VA = "0x180A8DA30")]
			get
			{
				return default(KHMENMBKJGL);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA8CBD0", Offset = "0xA8BFD0", VA = "0x180A8CBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xA8E330", Offset = "0xA8D730", VA = "0x180A8E330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA8E530", Offset = "0xA8D930", VA = "0x180A8E530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6CAEE00", Offset = "0x6CAE200", VA = "0x186CAEE00")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x6CAEE40", Offset = "0x6CAE240", VA = "0x186CAEE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE9E0", Offset = "0x6CADDE0", VA = "0x186CAE9E0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public KJCIGENAPJO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private BFPCODFKEAD? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x6CB0EE0", Offset = "0x6CB02E0", VA = "0x186CB0EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
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
