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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B51E40", Offset = "0x7B51040", VA = "0x187B51E40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B54090", Offset = "0x7B53290", VA = "0x187B54090", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CFBFBMEJALB]
internal class NFENDJLLLFO : MGOFGBFNMBM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JGMFHDIABPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public NFENDJLLLFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public EAEHACEIFMC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GMGKCGECFMG CCCPAJDPPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AFIODINNKKJ ILENLEEONJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LININKIOLPA OACDOHJMHIP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B503C0", Offset = "0x7B4F5C0", VA = "0x187B503C0")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	[UsedImplicitly]
	internal static void CLGBFGEFKDO(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B51CC0", Offset = "0x7B50EC0", VA = "0x187B51CC0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NFENDJLLLFO([ALHAHLCGLLK(null)] GMGKCGECFMG CCCPAJDPPNO, [ALHAHLCGLLK(null)] AFIODINNKKJ ILENLEEONJB, [ALHAHLCGLLK(null)] LININKIOLPA OACDOHJMHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B513F0", Offset = "0x7B505F0", VA = "0x187B513F0", Slot = "5")]
	public HEAMFGBJNNJ MAAICBKOIAG(EAEHACEIFMC IMIGMMADGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B50750", Offset = "0x7B4F950", VA = "0x187B50750", Slot = "4")]
	public HEAMFGBJNNJ ILIBBHEICPB(EAEHACEIFMC IMIGMMADGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B51250", Offset = "0x7B50450", VA = "0x187B51250", Slot = "6")]
	public AKHNIDFFNPA LICGILLCOOK(HEAMFGBJNNJ DHAOEHNLNON, int FIAODFNFKEN, string? DGIAFBEDPNJ, string? KLKFBNEMAON, LNMPHCNNDCM BCCBJDEOPHO, List<MJJEAILKKIC>? KGFMNFNGEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B506C0", Offset = "0x7B4F8C0", VA = "0x187B506C0", Slot = "7")]
	public bool IHPAFOOPFMM(AIBBOLDMIIO PEKOKNDJGJK, [Out] HEAMFGBJNNJ? LNAHHHMDCMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7B50430", Offset = "0x7B4F630", VA = "0x187B50430", Slot = "8")]
	public bool CLNECKAKMOA(AKHNIDFFNPA MHFHAMDDKGB, [Out] HEAMFGBJNNJ? LNAHHHMDCMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7B51360", Offset = "0x7B50560", VA = "0x187B51360", Slot = "9")]
	public bool LPFHBMJOBNH(AKHNIDFFNPA MHFHAMDDKGB, [Out] FCGFCMKDIAL? PEKOKNDJGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3982BE0", Offset = "0x3981DE0", VA = "0x183982BE0")]
	private bool BLNKLIEOOCN<TInput, TOutput>(TInput EEEOGOJIPGB, NIDIDCFABDI<TInput, TOutput> OKDAIHBKEEE, [Out] TOutput? IGGKBIDIAJL) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7B50510", Offset = "0x7B4F710", VA = "0x187B50510")]
	[CompilerGenerated]
	private GLCEONPLMMA EFPBPACIMJG(FaceFeatureType CNIMCDMPCAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7B501E0", Offset = "0x7B4F3E0", VA = "0x187B501E0")]
	[CompilerGenerated]
	private GLCEONPLMMA CCADBIIOOON(FaceFeatureType CNIMCDMPCAO, JGMFHDIABPM P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CFBFBMEJALB]
internal class OOMPIKPMNEE : GMGKCGECFMG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void CJDFKFLIIDE<in TData>(TData LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FBHJNPHOFGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public APCCAICKIBN rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AOKFOMCJFEP currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AOKFOMCJFEP latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FBHJNPHOFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B35FC0", Offset = "0x7B351C0", VA = "0x187B35FC0")]
		internal bool BMPDDFLPNPJ(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B35FE0", Offset = "0x7B351E0", VA = "0x187B35FE0")]
		internal bool HNNLFEHEIFA(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LININKIOLPA OACDOHJMHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly DECADMNPJIG ICPFLHOEKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CJDFKFLIIDE<HEAMFGBJNNJ>?[] CCCPAJDPPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CJDFKFLIIDE<FCGFCMKDIAL>?[] NPKHHINFABB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7B51EF0", Offset = "0x7B510F0", VA = "0x187B51EF0")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	[UsedImplicitly]
	internal static void CLGBFGEFKDO(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B53A30", Offset = "0x7B52C30", VA = "0x187B53A30")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OOMPIKPMNEE([ALHAHLCGLLK(null)] LININKIOLPA OACDOHJMHIP, [ALHAHLCGLLK(null)] DECADMNPJIG ICPFLHOEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B537C0", Offset = "0x7B529C0", VA = "0x187B537C0", Slot = "4")]
	public bool KNJBGPKCJJJ(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B53660", Offset = "0x7B52860", VA = "0x187B53660", Slot = "5")]
	public bool KNJBGPKCJJJ(FCGFCMKDIAL PEKOKNDJGJK, IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B52700", Offset = "0x7B51900", VA = "0x187B52700")]
	private void IANNLEBJKKI(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B51F70", Offset = "0x7B51170", VA = "0x187B51F70")]
	private void FCJHDGBBNHB(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B53900", Offset = "0x7B52B00", VA = "0x187B53900")]
	private void LIDDJPKGGFN(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B53A00", Offset = "0x7B52C00", VA = "0x187B53A00")]
	private void OBFEJOFFAHG(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B53930", Offset = "0x7B52B30", VA = "0x187B53930")]
	private void MPPFDCAGKFD(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B532D0", Offset = "0x7B524D0", VA = "0x187B532D0")]
	private void JDKHJCENKMC(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B52480", Offset = "0x7B51680", VA = "0x187B52480")]
	private void GBFGGPHAFHL(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B51F60", Offset = "0x7B51160", VA = "0x187B51F60")]
	private void DCMOPGENPCF(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B51EC0", Offset = "0x7B510C0", VA = "0x187B51EC0")]
	private void CCBLHJOCPBO(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? NIDPEFPJBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B521A0", Offset = "0x7B513A0", VA = "0x187B521A0")]
	private void FJNJLIKAKCP(HEAMFGBJNNJ LNAHHHMDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B53380", Offset = "0x7B52580", VA = "0x187B53380")]
	private HEAMFGBJNNJ JIMIIFMCAOA(HEAMFGBJNNJ LNAHHHMDCMM, List<RangeMigration> BIIMMBGPHCO, AOKFOMCJFEP DPNJMCCKBFM, AOKFOMCJFEP DBEHDOBIGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B538C0", Offset = "0x7B52AC0", VA = "0x187B538C0")]
	private float KPKMPLOMGKK(float PKMCDCICDPF, Vector2 HCACDOGGHMN, Vector2 BHNDOIOEOPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B52530", Offset = "0x7B51730", VA = "0x187B52530")]
	private (RangeMigration?, RangeMigration?) HOHILJKGPLN(List<RangeMigration> HJCIJDAEBDF, APCCAICKIBN NINAELPBIHN, AOKFOMCJFEP DPNJMCCKBFM, AOKFOMCJFEP DBEHDOBIGCK)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GMGKCGECFMG
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNJBGPKCJJJ(HEAMFGBJNNJ LNAHHHMDCMM, IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KNJBGPKCJJJ(FCGFCMKDIAL PEKOKNDJGJK, IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO);
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
		public ANANKEENBDL AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7B33B90", Offset = "0x7B32D90", VA = "0x187B33B90")]
		public void KNLDAPLPPAH(AnimationPoseSetting FNJGMJGALLH, float DLEJOCNJIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B33CC0", Offset = "0x7B32EC0", VA = "0x187B33CC0")]
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
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
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

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B345B0", Offset = "0x7B337B0", VA = "0x187B345B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B34570", Offset = "0x7B33770", VA = "0x187B34570")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B33CE0", Offset = "0x7B32EE0", VA = "0x187B33CE0")]
		private void OJKMFMKKNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3CF0", Offset = "0x7AC2EF0", VA = "0x187AC3CF0", Slot = "4")]
		public void SetEnabled(bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B345E0", Offset = "0x7B337E0", VA = "0x187B345E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B34620", Offset = "0x7B33820", VA = "0x187B34620")]
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
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4AC")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4BC")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4DC")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7B34660", Offset = "0x7B33860", VA = "0x187B34660")]
		public AnimationPoseSetting EGPEEBPPNIH(ANANKEENBDL NBBGHJIPJKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B34690", Offset = "0x7B33890", VA = "0x187B34690")]
		public void MNFKMEBPDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B346D0", Offset = "0x7B338D0", VA = "0x187B346D0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum EMIGICPKDCK
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private EMIGICPKDCK handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B35180", Offset = "0x7B34380", VA = "0x187B35180")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B35140", Offset = "0x7B34340", VA = "0x187B35140")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B34B40", Offset = "0x7B33D40", VA = "0x187B34B40")]
		private void OJKMFMKKNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3CF0", Offset = "0x7AC2EF0", VA = "0x187AC3CF0", Slot = "4")]
		public void SetEnabled(bool PGGLOGHIPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B351B0", Offset = "0x7B343B0", VA = "0x187B351B0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, LCJHDJLDNIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Header("Configuration")]
		[SerializeField]
		private EAEHACEIFMC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		[GABLABEDCEL(HJNEPGJJFOF.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		[FormerlySerializedAs("HeadTweakBone")]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private NKNMMGCEDBO GEBCMAIOGLL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NKNMMGCEDBO FONNPGGHLKP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA5180", VA = "0x180AA5F80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform FKCAICIFDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B35FA0", Offset = "0x7B351A0", VA = "0x187B35FA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B351E0", Offset = "0x7B343E0", VA = "0x187B351E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B35E60", Offset = "0x7B35060", VA = "0x187B35E60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B35E10", Offset = "0x7B35010", VA = "0x187B35E10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B35DA0", Offset = "0x7B34FA0", VA = "0x187B35DA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B351E0", Offset = "0x7B343E0", VA = "0x187B351E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B35570", Offset = "0x7B34770", VA = "0x187B35570", Slot = "6")]
		public NKNMMGCEDBO CreateAvatarSystem(string DOOAPKJOLDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B35DA0", Offset = "0x7B34FA0", VA = "0x187B35DA0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B352A0", Offset = "0x7B344A0", VA = "0x187B352A0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B35EB0", Offset = "0x7B350B0", VA = "0x187B35EB0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float PNLPAJFPFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class MFEHEMHPFBB : NKNMMGCEDBO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class KKAMKKPNFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Vector3 IJOENHFOFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Quaternion LPLMNAELOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Vector3 IDKEALJFPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private Transform DLFBHKFBEEJ;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 LJIEMMJGPEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB2F0", Offset = "0x1EFA4F0", VA = "0x181EFB2F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB310", Offset = "0x1EFA510", VA = "0x181EFB310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion DKOEEHDNPBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x13768D0", Offset = "0x1375AD0", VA = "0x1813768D0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1376BE0", Offset = "0x1375DE0", VA = "0x181376BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float CAJPLBMLDCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x10CFAA0", Offset = "0x10CECA0", VA = "0x1810CFAA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1752EA0", Offset = "0x17520A0", VA = "0x181752EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool GJNENLEPADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D80", Offset = "0x9F5F80", VA = "0x1809F6D80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D60", Offset = "0x9F5F60", VA = "0x1809F6D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool HCEONMBMFIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D50", Offset = "0x9F5F50", VA = "0x1809F6D50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9F6DC0", Offset = "0x9F5FC0", VA = "0x1809F6DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool EIJPGJDIJOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x9F6DA0", Offset = "0x9F5FA0", VA = "0x1809F6DA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BF0", Offset = "0x9F5DF0", VA = "0x1809F6BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float KMMNGHDGPBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xC8D230", Offset = "0xC8C430", VA = "0x180C8D230")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xC8D220", Offset = "0xC8C420", VA = "0x180C8D220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D2D0", Offset = "0x7B5C4D0", VA = "0x187B5D2D0")]
		public void PLDBFFDCBID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CF90", Offset = "0x7B5C190", VA = "0x187B5CF90")]
		public void JGHFAKCDCDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CFC0", Offset = "0x7B5C1C0", VA = "0x187B5CFC0")]
		public float ODMIFAGPCNC(Vector3 PIFBACAKANG, Quaternion LNKNJPPIENI, [In] AvatarFootSettings ICFFBGOIPLN, float HJCPJGFLIFO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C770", Offset = "0x7B5B970", VA = "0x187B5C770")]
		public void IBHLPFNGGNM(Vector3 PMEGOJCLLAK, Quaternion ABPDMFHDGMD, Transform BDMBDEFINAI, float NHAAHCJMMOI, bool GLBIKKIIPCI, bool OKIOCDAGEHD, float NPJEJMBBDHC, float PANCDNKMIDM, Transform FHPKLENNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C540", Offset = "0x7B5B740", VA = "0x187B5C540")]
		public void FGNMBAALGLP(Transform GOEBMDPCFFI, Transform FHPKLENNKKO, bool FMKJOFLEGHC, bool DGKAMECGOKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D1D0", Offset = "0x7B5C3D0", VA = "0x187B5D1D0")]
		private void PEIIANCHEAC(Transform FHPKLENNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CE40", Offset = "0x7B5C040", VA = "0x187B5CE40")]
		public void JEBKPLNDCJK(Transform FHPKLENNKKO, AvatarFullBodyConfiguration EPCCHCFNMNH, Vector3 PGMMPHJBPPI, float MLKAJOEKKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CFA0", Offset = "0x7B5C1A0", VA = "0x187B5CFA0")]
		public void NLAHNNBDKEH(float PANCDNKMIDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D2E0", Offset = "0x7B5C4E0", VA = "0x187B5D2E0")]
		public KKAMKKPNFPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class LEJKDHCDHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float AGAOGKBBIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool AEMHDNPAFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AnimationPoseSetting MPJHEEPGKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private float BBDAPKBAIML;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D330", Offset = "0x7B5C530", VA = "0x187B5D330")]
		public void GPKIPPOIKBC(IKSolverVR.Arm PKAAOJFDJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D360", Offset = "0x7B5C560", VA = "0x187B5D360")]
		public void IGMEMJCLKML(IKSolverVR.Arm PKAAOJFDJCJ, float IDEJFCIKJAH, bool AEMHDNPAFFD, AvatarFullBodyConfiguration EPCCHCFNMNH, float BCCEKGNMJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D2F0", Offset = "0x7B5C4F0", VA = "0x187B5D2F0")]
		private void GHHHKFPMEPB(IKSolverVR.Arm PKAAOJFDJCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D500", Offset = "0x7B5C700", VA = "0x187B5D500")]
		public void IPIIDNEPODC(IKSolverVR.Arm PKAAOJFDJCJ, Transform FMMHCMAOCGN, Transform BDMBDEFINAI, Quaternion HILLCIKHGBI, Vector3 FNILMBPHONH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E4C0", Offset = "0x7B5D6C0", VA = "0x187B5E4C0")]
		private (Vector3, Quaternion) OFNDPFDOHBP(INKDMEIAPOM EKBFEFGEJKC, Quaternion DIAINPKHIJJ, Vector3 PGPOOEJMKCC)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D3A0", Offset = "0x7B5C5A0", VA = "0x187B5D3A0")]
		public void ILMHANPKHIA(INKDMEIAPOM EKBFEFGEJKC, IKSolverVR.Arm PKAAOJFDJCJ, Quaternion DIAINPKHIJJ, Vector3 PGPOOEJMKCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DA20", Offset = "0x7B5CC20", VA = "0x187B5DA20")]
		public void KEAMMBPFHBH(INKDMEIAPOM EKBFEFGEJKC, IKSolverVR.Arm PKAAOJFDJCJ, Quaternion DIAINPKHIJJ, Vector3 PGPOOEJMKCC, [In] AvatarFullBodyConfiguration EPCCHCFNMNH, [In] MICAOOIHFBH HPAPEOOKLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D8E0", Offset = "0x7B5CAE0", VA = "0x187B5D8E0")]
		public void KDPIAHLPIHJ(ANANKEENBDL KPHJOIKBENB, AvatarFullBodyConfiguration EPCCHCFNMNH, MICAOOIHFBH HPAPEOOKLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E020", Offset = "0x7B5D220", VA = "0x187B5E020")]
		public void LLCDFKAFEOO(IKSolverVR.Arm PKAAOJFDJCJ, Transform FMMHCMAOCGN, Vector3 EGPOHKKGOEE, float NKGOCMEFOKI, Quaternion PFKBNIAEKKD, Vector3 AEHGCOEMLDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E950", Offset = "0x7B5DB50", VA = "0x187B5E950")]
		public LEJKDHCDHNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum LIKPEPAIFFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DGEAEKCEBII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HFOCCAHDOBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int OJFOIOICBGI;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int BCGHGMDMJLP;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int EBDJOGALBCJ;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int LBFHMIDHPHH;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int DHIDBGHKFNL;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int PKFLDJDGOBA;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int NBLAIOCFBAP;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int KLJHINGENEI;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int OINHLMPMILA;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int JEPBOPGKCOF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int FBJGGABJBCE;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int IJKOEBBDGNE;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int MPMEKGPLEGE;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int CGBCANADOKF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int NLOHMCAHIAN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int BMKGIAIHPIC;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int PCMIMCOMFML;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int POJGDPIHJFI;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int DJHGCDDKICN;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int IIACPNDDEBG;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int NKCNCGIAFMG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int EPLMKLEBDMC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int PLBPGHALODH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int OJIKBEMMNBJ;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int BNIIJHLNPLD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int PACFJJMGADJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int IJKIIFEEKIE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int AKHBGCAEANH;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int BHFPCKNAPBK;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int ABJCMPCICOB;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int LLIMLMLFOLB;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int AAAMBPNLOMO;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly Vector3 ICJEFLJJLBC;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int IGOEPAKEGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool CNDKHDAIDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool LBGFFDJBBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool CONEJHFCFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool IBKEGPKIINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool CFFPGGIJGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool JMLOODLBOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Vector3 ALMNNMOKFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private string PJPDGKELOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private ECBAJAHPPAN? JPIGGEFFKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private AMDPONNBBJP? GLDMFHHGENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private PGFGDPCGKIK AGDLPLFKGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MDNLJPIOKLL DAFDDEPIIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private INKDMEIAPOM FJFIABHAFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private INKDMEIAPOM LFMFMDEOONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool HCMHFAIOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool MOFEODHKFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly NCKFHDHCKAP LOMADBDAJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly GILICPLEMHB GFAHHLOLPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int HKMBDIOBALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private float AJDPKHPDNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private GameObject BMEJOLMDJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform JGBACCLLMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform OFIMEBIMEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform BHPIOPILDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform OABMCNLLBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float CAPFHPOLJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private float DFECLOJBEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Vector3 KKBBADEDHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Quaternion MBPECCIKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform KDOMACMHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform PIMOBEBLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Transform LECBAPMAFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private DJKCEHNOJIC PDEEOHOAJGI;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker ILOBFMONJDM;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker JBPBGIEDCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private ProfilerMarker OFFONKIIMPN;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker KEOHDDKNPPJ;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker IEEBFIEIEOK;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly ProfilerMarker ICCLMEENANP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly List<MFEHEMHPFBB> KJCBMNHDCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int KHLEFNIEBCH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> HBBEANPHIIH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int FPBHNGENHOA;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int GANFCJNIOIM;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int DBGCIPMNMLH;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static int PGKLBFCENDA;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float BAMLEDGNCAI;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int JGLFFPCOBFD;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float MFCBABKBDNP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float GJEGOMBEECH;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float EKCNDOEKLHE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static float LNKMNNFBIPD;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static BAAGLBABOCJ BMDCCGJJHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float EEAMADMHJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool AMNAAIDAIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float KMPAOIABOEH;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int HDJBLIEDHOI;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly int HHNOENJKDCD;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static readonly int DKPCOAKBEKH;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly int KKCIPJAHELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private KKAMKKPNFPG NFNGAKHIOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private KKAMKKPNFPG FBHLMININNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private float MIAPFILLALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private Vector3 DPBFILNOJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private Vector3 HPCNDNFHFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool BKPAAIPIBPL;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Quaternion KGJIGFAFEGH;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Quaternion OKMHNFDIDJJ;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly Vector3 PCOLDOECLKE;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Vector3 NDIBAPINLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float OBOHCNKPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float FLKNLODMELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private LEJKDHCDHNA IIACBMNAPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private LEJKDHCDHNA LNCFCELNFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private DJIOPGMBADD BGLGIFNEHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private PIIOOLNDMID COKLKOIODGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly ENMMFKDMOFB MPEFLMFJLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float FBNBBNAGDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float EDPEIEFMFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly PIIOOLNDMID BEPHIFLNIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private Vector3 CNIJFGFGKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private Vector3 KABCFJEIBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float LEHOOLCGGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float BMFDHEEJPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly PIIOOLNDMID GPDLKNNMHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly DJIOPGMBADD LGGOKGFFDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly PIIOOLNDMID IILBGBFECHF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JGNOJICCDHE LIEKKAIPCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JGNOJICCDHE DNGCFHJCGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration BMPCHJILGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B40260", Offset = "0x7B3F460", VA = "0x187B40260", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EAEHACEIFMC APFNIIPECKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A360", Offset = "0x7B39560", VA = "0x187B3A360", Slot = "24")]
		get
		{
			return default(EAEHACEIFMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration MGCADPMBBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A830", Offset = "0x7B49A30", VA = "0x187B4A830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform FFCJOIKMFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B371B0", Offset = "0x7B363B0", VA = "0x187B371B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform BKLFHBGCOGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B45130", Offset = "0x7B44330", VA = "0x187B45130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer OMKEKOCGHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B47D20", Offset = "0x7B46F20", VA = "0x187B47D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] HEDAJOIABLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B3CF70", Offset = "0x7B3C170", VA = "0x187B3CF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] HGPJNOEOOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B400B0", Offset = "0x7B3F2B0", VA = "0x187B400B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator AHMKOLFEICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B44770", Offset = "0x7B43970", VA = "0x187B44770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK JBBHAKLIADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7B45030", Offset = "0x7B44230", VA = "0x187B45030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private FNEGHPKEGOG PGAPLHCHGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7B43CB0", Offset = "0x7B42EB0", VA = "0x187B43CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private FNEGHPKEGOG ODHECOCBGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4EE20", Offset = "0x7B4E020", VA = "0x187B4EE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private FNEGHPKEGOG PMEEAFKNAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A2D0", Offset = "0x7B494D0", VA = "0x187B4A2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private FNEGHPKEGOG PFKMMGACJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B370B0", Offset = "0x7B362B0", VA = "0x187B370B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private FNEGHPKEGOG LCOKPOPFNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4ED20", Offset = "0x7B4DF20", VA = "0x187B4ED20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private FNEGHPKEGOG NEOMDABNDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7B43E30", Offset = "0x7B43030", VA = "0x187B43E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private FNEGHPKEGOG MLHMDAIIONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E3D0", Offset = "0x7B3D5D0", VA = "0x187B3E3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private FNEGHPKEGOG OPKMHHJGHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F30", Offset = "0x7B43130", VA = "0x187B43F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AMDPONNBBJP IBCAHOLOMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AA60", Offset = "0x7B49C60", VA = "0x187B4AA60", Slot = "16")]
		get
		{
			return default(AMDPONNBBJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public KILAHEJLJLB FCGCFBHJNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6C0", Offset = "0xA6E8C0", VA = "0x180A6F6C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HGCMEOFLAIK MCBOKIAFKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAC95A0", Offset = "0xAC87A0", VA = "0x180AC95A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public APPJCEDIMMA CKDMLHBFNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAC8BE0", Offset = "0xAC7DE0", VA = "0x180AC8BE0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public APPJCEDIMMA OICHBIPODPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAC9270", Offset = "0xAC8470", VA = "0x180AC9270", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string GGKCIIOKDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform HHIJCHKCLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E4D0", Offset = "0x7B3D6D0", VA = "0x187B3E4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform OIJHODDKMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B43140", Offset = "0x7B42340", VA = "0x187B43140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform AOLIOIEGNID
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D900", Offset = "0x7B3CB00", VA = "0x187B3D900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform AKKHPGHHCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4ECE0", Offset = "0x7B4DEE0", VA = "0x187B4ECE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform BKGOFMPOMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B40220", Offset = "0x7B3F420", VA = "0x187B40220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool EPKMBJBPDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E020", Offset = "0x7B3D220", VA = "0x187B3E020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool AEACACLJNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E020", Offset = "0x7B3D220", VA = "0x187B3E020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KJFHMFDNPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7B386D0", Offset = "0x7B378D0", VA = "0x187B386D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform AIKDCIGIGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A8C0", Offset = "0x7B49AC0", VA = "0x187B4A8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject GNOLFLMODHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D070", Offset = "0x7B3C270", VA = "0x187B3D070", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets PBCHGLJDHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B43DB0", Offset = "0x7B42FB0", VA = "0x187B43DB0", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform BPGJHCHKAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAC95B0", Offset = "0xAC87B0", VA = "0x180AC95B0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform CCBPICLNLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAC8A90", Offset = "0xAC7C90", VA = "0x180AC8A90", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform ACJMHKDJJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xABC8B0", Offset = "0xABBAB0", VA = "0x180ABC8B0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform MPKCAKOPOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAC9530", Offset = "0xAC8730", VA = "0x180AC9530", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 BAGPJMIKDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D250", Offset = "0x7B3C450", VA = "0x187B3D250", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float ECDAAEAGJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A9C0", Offset = "0x7B49BC0", VA = "0x187B4A9C0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform GBMHPDBCGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7B37D20", Offset = "0x7B36F20", VA = "0x187B37D20", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform DDJLNAODHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1365260", Offset = "0x1364460", VA = "0x181365260", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform DJNPDNHLGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1F5A170", Offset = "0x1F59370", VA = "0x181F5A170", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform OCILJIPGAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x22DC720", Offset = "0x22DB920", VA = "0x1822DC720", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool MGFEFHOIBKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D160", Offset = "0x7B3C360", VA = "0x187B3D160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool LKBAOFIMKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B446F0", Offset = "0x7B438F0", VA = "0x187B446F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool AAFCEALLDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B4A0", Offset = "0x7B4A6A0", VA = "0x187B4B4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7B4A810", Offset = "0x7B49A10", VA = "0x187B4A810")]
	private float MOAHDMJOPDI(HDIDGIAMNLH MBKEPLIEKNJ, float ADKHKCPIBGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7B40CB0", Offset = "0x7B3FEB0", VA = "0x187B40CB0")]
	private void HMPLHNDPDAK([In] MICAOOIHFBH PGMKGIEKDAE, [In] AvatarFullBodyConfiguration EPCCHCFNMNH, bool KAMDMEJPHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A940", Offset = "0x7B39B40", VA = "0x187B3A940")]
	private float DIIBELHMMLM([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AE90", Offset = "0x7B3A090", VA = "0x187B3AE90")]
	private float DJADMKAFCGN([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40B20", Offset = "0x7B3FD20", VA = "0x187B40B20")]
	private void HLEPHCOHGPM(MICAOOIHFBH PGMKGIEKDAE, AvatarFullBodyConfiguration EPCCHCFNMNH, bool KAMDMEJPHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4B2E0", Offset = "0x7B4A4E0", VA = "0x187B4B2E0")]
	private void OFAKMIIMGMP([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B43850", Offset = "0x7B42A50", VA = "0x187B43850")]
	private void IGICFLJMNPP([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4FD40", Offset = "0x7B4EF40", VA = "0x187B4FD40")]
	public MFEHEMHPFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B39490", Offset = "0x7B38690", VA = "0x187B39490", Slot = "13")]
	public void CIHCPFDOJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B3BF40", Offset = "0x7B3B140", VA = "0x187B3BF40", Slot = "14")]
	public void EBGGGMNGKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B4AFD0", Offset = "0x7B4A1D0", VA = "0x187B4AFD0", Slot = "15")]
	public void OCCGFCJMJPF(bool KNJJNAFJBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B404B0", Offset = "0x7B3F6B0", VA = "0x187B404B0", Slot = "26")]
	public Transform HDPJOPAKCBL(string BNEGAFBFOGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B4B150", Offset = "0x7B4A350", VA = "0x187B4B150", Slot = "27")]
	public Vector3? OEEKPAIPEGO(string BNEGAFBFOGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B4B9A0", Offset = "0x7B4ABA0", VA = "0x187B4B9A0", Slot = "7")]
	public void PAACDFAELEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B48B70", Offset = "0x7B47D70", VA = "0x187B48B70")]
	private void LPFPBMDLBKO(AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B48360", Offset = "0x7B47560", VA = "0x187B48360", Slot = "8")]
	public void LIKJFNDMIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A240", Offset = "0x7B39440", VA = "0x187B3A240")]
	private void DCAJPIHPNMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B44360", Offset = "0x7B43560", VA = "0x187B44360")]
	private Vector3 JAHNCCMKOLF([In] MICAOOIHFBH HPAPEOOKLIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B4EF20", Offset = "0x7B4E120", VA = "0x187B4EF20", Slot = "6")]
	public void PKHAKIHGEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B46850", Offset = "0x7B45A50", VA = "0x187B46850")]
	private void LBDOIJFDJAA(bool KAMDMEJPHEB, LIKPEPAIFFO JGEMKOHFEFE, AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B401B0", Offset = "0x7B3F3B0", VA = "0x187B401B0", Slot = "9")]
	public void GCDJJFKEDDP(float FPKPHMIMKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D110", Offset = "0x7B3C310", VA = "0x187B3D110")]
	private void EJIFHLMKOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B4CAB0", Offset = "0x7B4BCB0", VA = "0x187B4CAB0", Slot = "4")]
	public void PDMLKOLBBJO(string DOOAPKJOLDP, ECBAJAHPPAN LJCKDKBDAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B4B520", Offset = "0x7B4A720", VA = "0x187B4B520", Slot = "5")]
	public void OOEJKBNOBKO(AMDPONNBBJP NABBANDAIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7B43B50", Offset = "0x7B42D50", VA = "0x187B43B50", Slot = "12")]
	public void IIIANNKJPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7B37D80", Offset = "0x7B36F80", VA = "0x187B37D80", Slot = "25")]
	public void CAIMHBNHOOF([Out] Vector3 BKONELNAHKI, [Out] Quaternion PFKBNIAEKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7B45540", Offset = "0x7B44740", VA = "0x187B45540")]
	private void KDNBJPBBILM([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x11FFEA0", Offset = "0x11FF0A0", VA = "0x1811FFEA0", Slot = "28")]
	public void AEANOPFBIMH(float LPHFKAFHINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7B4AB70", Offset = "0x7B49D70", VA = "0x187B4AB70", Slot = "29")]
	public void NPMMPOAEGBD(float LKBHNKGPMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B1E0", Offset = "0x7B3A3E0", VA = "0x187B3B1E0", Slot = "45")]
	public void DLPBOKCBGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7B45D60", Offset = "0x7B44F60", VA = "0x187B45D60", Slot = "30")]
	public void KEOMMOJHGIC(bool PHOJELJGGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7B4AA10", Offset = "0x7B49C10", VA = "0x187B4AA10", Slot = "31")]
	public HandLogicOffsets NFOPAILPGHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4C1F0", Offset = "0x7B4B3F0", VA = "0x187B4C1F0", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets PCJCHFEJICH()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B45230", Offset = "0x7B44430", VA = "0x187B45230")]
	private void KDJEECJLBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B48870", Offset = "0x7B47A70", VA = "0x187B48870")]
	private void LKPNEGBPBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B4A3D0", Offset = "0x7B495D0", VA = "0x187B4A3D0")]
	private void MLDGLMCGCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B45260", Offset = "0x7B44460", VA = "0x187B45260")]
	private void KDKOCPBGBED(FLECLLPEPCA DKDDMFMEFJD, bool JPKNJNJLHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B489F0", Offset = "0x7B47BF0", VA = "0x187B489F0")]
	private void LOCDCAIEJPH(FLECLLPEPCA DKDDMFMEFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7B44030", Offset = "0x7B43230", VA = "0x187B44030")]
	public Vector3 INDEECHNKJN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B48070", Offset = "0x7B47270", VA = "0x187B48070")]
	private void LHNIPEEOBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A340", Offset = "0x7B39540", VA = "0x187B3A340")]
	private void DCOANMBJHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C3C0", Offset = "0x7B3B5C0", VA = "0x187B3C3C0")]
	private void EIGGNMLFFMJ(MICAOOIHFBH PGMKGIEKDAE, AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4BC50", Offset = "0x7B4AE50", VA = "0x187B4BC50")]
	private float PBECGJNMJMN([In] MICAOOIHFBH HPAPEOOKLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B3CC00", Offset = "0x7B3BE00", VA = "0x187B3CC00")]
	private int EIMCOHMNDDE([In] LLLLGFIMNAK LNEFCKAEJLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B40600", Offset = "0x7B3F800", VA = "0x187B40600")]
	private void HJGBPIAJICH(MICAOOIHFBH PGMKGIEKDAE, bool GHLNAGMNNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AFD0", Offset = "0x7B3A1D0", VA = "0x187B3AFD0")]
	private static void DKODEMBNADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7B49210", Offset = "0x7B48410", VA = "0x187B49210")]
	private static void MBHMEJHELHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D2E0", Offset = "0x7B3C4E0", VA = "0x187B3D2E0")]
	private float ENFDDHMDNOL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20")]
	private static int IIFMFFNCDOJ(MFEHEMHPFBB MHEJPNNFCGC, MFEHEMHPFBB BGMAPCGDHFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B40360", Offset = "0x7B3F560", VA = "0x187B40360", Slot = "41")]
	public MICAOOIHFBH HDABPIDPNDN()
	{
		return default(MICAOOIHFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B372B0", Offset = "0x7B364B0", VA = "0x187B372B0")]
	private bool APFAGOCHDKG(int MKHHKDJKLDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AF10", Offset = "0x7B3A110", VA = "0x187B3AF10")]
	public void DJOJFHCFHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B43950", Offset = "0x7B42B50", VA = "0x187B43950")]
	private (bool, bool) IHLHJBODBNC()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7B47130", Offset = "0x7B46330", VA = "0x187B47130")]
	private (float, float) LBHKGBFMKDA([In] MICAOOIHFBH HPAPEOOKLIH)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7B3E520", Offset = "0x7B3D720", VA = "0x187B3E520")]
	private void FOFPNIELANI([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B230", Offset = "0x7B3A430", VA = "0x187B3B230")]
	private void DOCKDIDOCOJ([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B42B60", Offset = "0x7B41D60", VA = "0x187B42B60")]
	private void HOHKIMMBKNA([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH, AvatarFootSettings ICFFBGOIPLN, bool DCOLINFCDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C2F0", Offset = "0x7B3B4F0", VA = "0x187B3C2F0")]
	private float EFIBJKJFPOP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7B38910", Offset = "0x7B37B10", VA = "0x187B38910")]
	private void CICFOLJMBLH(MICAOOIHFBH HPAPEOOKLIH, AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C370", Offset = "0x7B3B570", VA = "0x187B3C370")]
	private float EGBMEMOOGFN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7B426A0", Offset = "0x7B418A0", VA = "0x187B426A0")]
	private void HNACBHDAFGC([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7B44080", Offset = "0x7B43280", VA = "0x187B44080")]
	private void IPIIDNEPODC([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B4BE00", Offset = "0x7B4B000", VA = "0x187B4BE00")]
	private void PBKALLHIPIJ([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7B38110", Offset = "0x7B37310", VA = "0x187B38110")]
	private void CALLHIOMCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7B45DB0", Offset = "0x7B44FB0", VA = "0x187B45DB0")]
	private void KFJGKCCLFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B3E070", Offset = "0x7B3D270", VA = "0x187B3E070")]
	private void FFELHBGMFLP([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B3CCE0", Offset = "0x7B3BEE0", VA = "0x187B3CCE0")]
	private void EINFGAAGOJP(INKDMEIAPOM OKBCEGDCEIK, IKSolverVR.Arm PKAAOJFDJCJ, Transform OHCJDCBGGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A9D0", Offset = "0x7B39BD0", VA = "0x187B3A9D0")]
	private void DINMLFGAHKE(MICAOOIHFBH HPAPEOOKLIH, AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7B3E200", Offset = "0x7B3D400", VA = "0x187B3E200")]
	private void FLFPODIPEBN(JHFMFICOFJE GCDLCIEJNLB, APPJCEDIMMA OKBCEGDCEIK, IKSolverVR.Arm PKAAOJFDJCJ, float IDEJFCIKJAH, float IGPILPDGJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7B444E0", Offset = "0x7B436E0", VA = "0x187B444E0")]
	private void JEAFNLNLPEE([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B43250", Offset = "0x7B42450", VA = "0x187B43250")]
	private void IEOOPIECNPE([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7B49F10", Offset = "0x7B49110", VA = "0x187B49F10")]
	protected void MIOEBBPGFIG([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B485A0", Offset = "0x7B477A0", VA = "0x187B485A0")]
	private void LJAFCPPIPIG([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7B47E20", Offset = "0x7B47020", VA = "0x187B47E20")]
	protected void LEMDIGKNCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7B37500", Offset = "0x7B36700", VA = "0x187B37500")]
	private void BGCHFEJLIEG([In] MICAOOIHFBH HPAPEOOKLIH, [In] LIKPEPAIFFO JGEMKOHFEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7B37350", Offset = "0x7B36550", VA = "0x187B37350")]
	private void BBLEMCADNNN(MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AF90", Offset = "0x7B3A190", VA = "0x187B3AF90")]
	private void DKDCGPIADIB([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B46000", Offset = "0x7B45200", VA = "0x187B46000")]
	private Vector3 KGFBBLPDIHH([In] MICAOOIHFBH HPAPEOOKLIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B43180", Offset = "0x7B42380", VA = "0x187B43180")]
	private void ICIAFAJCJDL([In] MICAOOIHFBH HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D4B0", Offset = "0x7B3C6B0", VA = "0x187B3D4B0")]
	private float FCIHOKMJFFJ(float PANCDNKMIDM, [In] MICAOOIHFBH HPAPEOOKLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B387C0", Offset = "0x7B379C0", VA = "0x187B387C0")]
	private void CHEONKEECHM(float PANCDNKMIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B3D930", Offset = "0x7B3CB30", VA = "0x187B3D930")]
	private void FECJLMFFHHK([In] MICAOOIHFBH HPAPEOOKLIH, LIKPEPAIFFO JGEMKOHFEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B4C2B0", Offset = "0x7B4B4B0", VA = "0x187B4C2B0")]
	private float PCPLMEKBPKE([In] MICAOOIHFBH PGMKGIEKDAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B45570", Offset = "0x7B44770", VA = "0x187B45570")]
	private void KEJFBHHEKLG(MICAOOIHFBH HPAPEOOKLIH, LIKPEPAIFFO JGEMKOHFEFE, Vector3 MAFGBJGODLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B365B0", Offset = "0x7B357B0", VA = "0x187B365B0")]
	private static void AGAHGLJLLOE(Transform PMPOHKBNMIB, Quaternion PANMBKPFLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B383A0", Offset = "0x7B375A0", VA = "0x187B383A0")]
	private void CBEICIKDNAH([In] MICAOOIHFBH EAPLBEJALFB, [In] LLLLGFIMNAK LNEFCKAEJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B39990", Offset = "0x7B38B90", VA = "0x187B39990")]
	private void DAOGIMDNKNK([In] MICAOOIHFBH EAPLBEJALFB, [In] LLLLGFIMNAK LNEFCKAEJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7B36060", Offset = "0x7B35260", VA = "0x187B36060")]
	private void ACGCCFBEIIO(float ABOJJGLAGDN, [In] MICAOOIHFBH PGMKGIEKDAE, float HFFEBBGHFAK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7B44870", Offset = "0x7B43A70", VA = "0x187B44870")]
	private float JJGIAMAPAGN([In] MICAOOIHFBH PGMKGIEKDAE, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B36DC0", Offset = "0x7B35FC0", VA = "0x187B36DC0")]
	private void AKPFLDPFFLF([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B47310", Offset = "0x7B46510", VA = "0x187B47310")]
	private void LCHLAONENIF([In] MICAOOIHFBH PGMKGIEKDAE, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B36760", Offset = "0x7B35960", VA = "0x187B36760")]
	private void AHKHPILDNDO([In] MICAOOIHFBH PGMKGIEKDAE, float HCMIIEAIAPC, float POJJJPIPHCC, Vector3 AFPIIFFOAAO, float HFFEBBGHFAK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B550", Offset = "0x7B3A750", VA = "0x187B3B550")]
	private void DPFPNCHGEHM(MICAOOIHFBH PGMKGIEKDAE, AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B36B30", Offset = "0x7B35D30", VA = "0x187B36B30")]
	private void AJELIGCLGPI(MICAOOIHFBH HPAPEOOKLIH, AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B46510", Offset = "0x7B45710", VA = "0x187B46510")]
	private void KNGLOHBNPND(MICAOOIHFBH PGMKGIEKDAE, AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7B42F80", Offset = "0x7B42180", VA = "0x187B42F80")]
	public void IBDCAIGOJBI([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B36250", Offset = "0x7B35450", VA = "0x187B36250")]
	public void ADEPECDBPKI([In] MICAOOIHFBH HPAPEOOKLIH, [In] AvatarFullBodyConfiguration EPCCHCFNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B4F120", Offset = "0x7B4E320", VA = "0x187B4F120")]
	[CompilerGenerated]
	internal static void POICHIAIFBN(Transform JIJCOIBMMGK, IKSolverVR.Arm PKAAOJFDJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B4B0A0", Offset = "0x7B4A2A0", VA = "0x187B4B0A0")]
	[CompilerGenerated]
	internal static void OCHPIMCAJIB(Vector3 MEAFDGJIHKK, Vector3 DNPAFOIPKKF, DGEAEKCEBII P_2, HFOCCAHDOBF P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A8A0", Offset = "0x7B39AA0", VA = "0x187B3A8A0")]
	[CompilerGenerated]
	internal static void DGOEFEPFBHA(KKAMKKPNFPG JKIHPJFICAC, KKAMKKPNFPG AFFHMGNEINO, Vector3 EFEJEADJIFL, float KOIHEPAFBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B4AEC0", Offset = "0x7B4A0C0", VA = "0x187B4AEC0")]
	[CompilerGenerated]
	internal static bool OBAPKNKANLD(IKSolverVR.Arm PKAAOJFDJCJ, KMCLPECHMCN DLAHHMHPADL, float KPGHGGNJHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B3A460", Offset = "0x7B39660", VA = "0x187B3A460")]
	[CompilerGenerated]
	internal static float DENJCMEFOEB(Vector3 HDGAKBHIEHL, Vector3 KHDBFKHIEKJ, Vector3 DEIPHIJAOLM, MICAOOIHFBH PGMKGIEKDAE, AvatarFullBodyConfiguration EPCCHCFNMNH, float OEBFFKLMAPN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class JKMINNHELDE : AMEODHBNCLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Dictionary<string, NKNMMGCEDBO> CKJNJGJBEGC;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BEF0", Offset = "0x7B5B0F0", VA = "0x187B5BEF0")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void PGBFFIPEICE(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BB90", Offset = "0x7B5AD90", VA = "0x187B5BB90", Slot = "4")]
	public NKNMMGCEDBO FGFBMINDFAF(string FKIBJIMFPJC, AvatarSystemConfiguration IDOPMFNAKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B940", Offset = "0x7B5AB40", VA = "0x187B5B940", Slot = "5")]
	public void CGPCLPLGICF(string FKIBJIMFPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BDB0", Offset = "0x7B5AFB0", VA = "0x187B5BDB0", Slot = "6")]
	public string LOLJIKBGIGN(string NKIFKCCCMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BB20", Offset = "0x7B5AD20", VA = "0x187B5BB20")]
	private string ELJDMBCLDAI(string NKIFKCCCMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BF60", Offset = "0x7B5B160", VA = "0x187B5BF60")]
	public JKMINNHELDE()
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
		public class JFAMPHPBJDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private Dictionary<string, Transform> PEMNHNLBFBJ;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool BFALGEPOBJF
			{
				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x7B59E20", Offset = "0x7B59020", VA = "0x187B59E20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7B59E60", Offset = "0x7B59060", VA = "0x187B59E60")]
			public void FJNFHNFHJJC(VRIK ELHAIAIJAKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
			public void MDJGFFOFJEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7B59DD0", Offset = "0x7B58FD0", VA = "0x187B59DD0")]
			public void AJIPEHIHHNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7B59F90", Offset = "0x7B59190", VA = "0x187B59F90")]
			public JFAMPHPBJDA()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[BMOELPNDLIH(HJNEPGJJFOF.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[GABLABEDCEL(HJNEPGJJFOF.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly JFAMPHPBJDA IPHJFHJGEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private LCJHDJLDNIG KJHLIPJEOGB;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7B552B0", Offset = "0x7B544B0", VA = "0x187B552B0")]
		private void ILLMBOBOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7B55590", Offset = "0x7B54790", VA = "0x187B55590")]
		private bool MBAHNFPADHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7B555E0", Offset = "0x7B547E0", VA = "0x187B555E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7B55650", Offset = "0x7B54850", VA = "0x187B55650")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7B555F0", Offset = "0x7B547F0", VA = "0x187B555F0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7B558C0", Offset = "0x7B54AC0", VA = "0x187B558C0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7B59010", Offset = "0x7B58210", VA = "0x187B59010")]
			public (float, float) CGGBJGNMCPE(float ICKFPJCJLOB)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7B58840", Offset = "0x7B57A40", VA = "0x187B58840")]
			public void MNFKMEBPDCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7B58700", Offset = "0x7B57900", VA = "0x187B58700")]
			public (float, float) ECMJLKHMLJP(Animator KNFBMPBMNKE, AnimatorStateInfo DDMLPBKJBLN)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B58DC0", Offset = "0x7B57FC0", VA = "0x187B58DC0")]
		public void MNFKMEBPDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7B58B80", Offset = "0x7B57D80", VA = "0x187B58B80")]
		public (float, float) KOGJMJKAMPN(Animator KNFBMPBMNKE, HDIDGIAMNLH MBKEPLIEKNJ, float GPHOGPNMOAM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7B58920", Offset = "0x7B57B20", VA = "0x187B58920")]
		private (float, float) APFNCPPBBLJ(Animator KNFBMPBMNKE, AnimatorStateInfo DDMLPBKJBLN, HDIDGIAMNLH MBKEPLIEKNJ, float GPHOGPNMOAM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7B59000", Offset = "0x7B58200", VA = "0x187B59000")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EC60", Offset = "0x7B5DE60", VA = "0x187B5EC60", Slot = "4")]
		public override void OnStateEnter(Animator KNFBMPBMNKE, AnimatorStateInfo DDMLPBKJBLN, int KNHOMEKMMBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EDC0", Offset = "0x7B5DFC0", VA = "0x187B5EDC0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class PMKFDJIKGIL<TInput, TOutput> : NIDIDCFABDI<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected readonly DECADMNPJIG ICPFLHOEKBN;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5638440", Offset = "0x5637640", VA = "0x185638440")]
	protected PMKFDJIKGIL(DECADMNPJIG ICPFLHOEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput JKAINKAKBPB(TInput EEEOGOJIPGB, [Out] IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x56383A0", Offset = "0x56375A0", VA = "0x1856383A0", Slot = "5")]
	public bool BLNKLIEOOCN(TInput EEEOGOJIPGB, [Out] TOutput? IGGKBIDIAJL, [Out] IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CFBFBMEJALB]
public static class JPCINBJHEAA
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly Regex GNPAENEEPFK;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C290", Offset = "0x7B5B490", VA = "0x187B5C290")]
	public static ONPEEMOLPPE OFIFJGJDEGA(KAKAKJKDPIO FCGPCABMNKH, MKHDGODFEOG IPFIMCHLLHB, Guid? NFCMKJPGKGP, Color? DDEKIALKNHF, KPCHKNGGLCC IKCLPEICFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BFF0", Offset = "0x7B5B1F0", VA = "0x187B5BFF0")]
	public static PMLAJJBBALO EEPPGBHEDMM(ONPEEMOLPPE DHAOEHNLNON)
	{
		return default(PMLAJJBBALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3876300", Offset = "0x3875500", VA = "0x183876300")]
	internal static TModern? INHFNEMGKCC<TModern>(string? EEEOGOJIPGB, NILCLPCBFCI<TModern> JDLOIOFPOJB, DECADMNPJIG ICPFLHOEKBN, PDLBOOFFMJE PIFMAGABOAI, TModern IMCNMPHGLDO) where TModern : struct, FDEINOGEHIH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3877950", Offset = "0x3876B50", VA = "0x183877950")]
	internal static MCIGOGBJPKJ PCMOJNLGGJK<TModern>(string? EEEOGOJIPGB, NILCLPCBFCI<TModern> JDLOIOFPOJB, DECADMNPJIG ICPFLHOEKBN, PDLBOOFFMJE PIFMAGABOAI, TModern IMCNMPHGLDO) where TModern : struct, FDEINOGEHIH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5C150", Offset = "0x7B5B350", VA = "0x187B5C150")]
	internal static List<MJJEAILKKIC> LBOAIKDOMJA(IEnumerable<HHNPNGAMMKB>? NOJDNAFLHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3875480", Offset = "0x3874680", VA = "0x183875480")]
	internal static string GEIJBHALKHL<TModern>(TModern EEEOGOJIPGB, NILCLPCBFCI<TModern> JDLOIOFPOJB, DECADMNPJIG ICPFLHOEKBN) where TModern : FDEINOGEHIH
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class FNGMNKNCBPM : AFIODINNKKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NIDIDCFABDI<AIBBOLDMIIO, HEAMFGBJNNJ> LNCNDKBAKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NIDIDCFABDI<AKHNIDFFNPA, FCGFCMKDIAL> BNKKHOGDKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NIDIDCFABDI<AKHNIDFFNPA, FCGFCMKDIAL> LGIOFFEMMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FJGKNOBLJFC GGJPLNIENEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EANJEECINCE DFEHKFHMFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7B559A0", Offset = "0x7B54BA0", VA = "0x187B559A0")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	[UsedImplicitly]
	internal static void CLGBFGEFKDO(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7B55A10", Offset = "0x7B54C10", VA = "0x187B55A10")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FNGMNKNCBPM([ALHAHLCGLLK("UnitySerialization")] JINKGABEJML BBCDDKGNDAB, [ALHAHLCGLLK(null)] FCFDCMAIFMA KKFHBKHKLCD, [ALHAHLCGLLK(null)] DECADMNPJIG ICPFLHOEKBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum FOICIKOFFAK
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GEEHOFOHEMO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7B58690", Offset = "0x7B57890", VA = "0x187B58690")]
	public GEEHOFOHEMO(string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7B58630", Offset = "0x7B57830", VA = "0x187B58630")]
	public GEEHOFOHEMO(string BDAAPBJEHGD, Exception DBEGDJHGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7B58660", Offset = "0x7B57860", VA = "0x187B58660")]
	public GEEHOFOHEMO(FOICIKOFFAK DEBMEFDDEDD, string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7B586C0", Offset = "0x7B578C0", VA = "0x187B586C0")]
	public GEEHOFOHEMO(FOICIKOFFAK DEBMEFDDEDD, string BDAAPBJEHGD, Exception DBEGDJHGEMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class JJNFJJLJHFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly JINKGABEJML BBCDDKGNDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly FCFDCMAIFMA KKFHBKHKLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly DECADMNPJIG ICPFLHOEKBN;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7B59C50", Offset = "0x7B58E50", VA = "0x187B59C50")]
	protected JJNFJJLJHFM(JINKGABEJML BBCDDKGNDAB, FCFDCMAIFMA KKFHBKHKLCD, DECADMNPJIG ICPFLHOEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A020", Offset = "0x7B59220", VA = "0x187B5A020")]
	protected string BMECCIDMLLM(HEAMFGBJNNJ LNAHHHMDCMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B430", Offset = "0x7B5A630", VA = "0x187B5B430")]
	protected string JIBKIEPOJFM(HEAMFGBJNNJ LNAHHHMDCMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B610", Offset = "0x7B5A810", VA = "0x187B5B610")]
	private AvatarOutfitSelectionData OFIFJGJDEGA(ONPEEMOLPPE CAGJKICDFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5B2F0", Offset = "0x7B5A4F0", VA = "0x187B5B2F0")]
	private static AvatarCustomizationSettingsData.AnchorParams DJPPJICDCPO(EDFKFIPIEMK? NEGNAILDEPM)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NIDIDCFABDI<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput JKAINKAKBPB(TInput EEEOGOJIPGB, [Out] IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BLNKLIEOOCN(TInput EEEOGOJIPGB, [Out] TOutput? IGGKBIDIAJL, [Out] IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AFIODINNKKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NIDIDCFABDI<AIBBOLDMIIO, HEAMFGBJNNJ> LNCNDKBAKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NIDIDCFABDI<AKHNIDFFNPA, FCGFCMKDIAL> LGIOFFEMMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	FJGKNOBLJFC GGJPLNIENEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum PDLBOOFFMJE
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EANJEECINCE
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MADOHDFLEFJ CEBCPPBDNIB(HEAMFGBJNNJ DHAOEHNLNON);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FJGKNOBLJFC
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKHNIDFFNPA CEBCPPBDNIB(HEAMFGBJNNJ DHAOEHNLNON, int FIAODFNFKEN, string? DGIAFBEDPNJ, string? KLKFBNEMAON, LNMPHCNNDCM BCCBJDEOPHO, List<MJJEAILKKIC>? KGFMNFNGEKO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[CFBFBMEJALB]
internal class OEICMGEIFOH : PMKFDJIKGIL<AIBBOLDMIIO, HEAMFGBJNNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly FCFDCMAIFMA KKFHBKHKLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly GAIKFDKDBKE BNBPKMADELA;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F080", Offset = "0x7B5E280", VA = "0x187B5F080")]
	public OEICMGEIFOH(JINKGABEJML BBCDDKGNDAB, FCFDCMAIFMA KKFHBKHKLCD, DECADMNPJIG ICPFLHOEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7B5EDE0", Offset = "0x7B5DFE0", VA = "0x187B5EDE0", Slot = "6")]
	public override HEAMFGBJNNJ JKAINKAKBPB(AIBBOLDMIIO EEEOGOJIPGB, [Out] IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class GBBBMPGEIMH : JINKGABEJML
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class PMMPAKPABIG : JsonConverter<MCIGOGBJPKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F8A0", Offset = "0x7B5EAA0", VA = "0x187B5F8A0", Slot = "9")]
		public override void WriteJson(JsonWriter GDEDILINNBI, MCIGOGBJPKJ? MLCDCHNOCFI, JsonSerializer BMKNJFOIIEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F780", Offset = "0x7B5E980", VA = "0x187B5F780", Slot = "10")]
		public override MCIGOGBJPKJ ReadJson(JsonReader OHHBENOLPAE, Type ODHJIEMHPHD, MCIGOGBJPKJ? CMFFOBHOCKM, bool MBIHNBJDGKO, JsonSerializer BMKNJFOIIEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F940", Offset = "0x7B5EB40", VA = "0x187B5F940")]
		public PMMPAKPABIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class AEPDKEAAENA : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool LMLFLGFNEBI
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7B54780", Offset = "0x7B53980", VA = "0x187B54780", Slot = "5")]
		public override object ReadJson(JsonReader OHHBENOLPAE, Type ODHJIEMHPHD, object? CMFFOBHOCKM, JsonSerializer BMKNJFOIIEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B543C0", Offset = "0x7B535C0", VA = "0x187B543C0", Slot = "6")]
		public override bool CanConvert(Type ODHJIEMHPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B547E0", Offset = "0x7B539E0", VA = "0x187B547E0", Slot = "4")]
		public override void WriteJson(JsonWriter GDEDILINNBI, object? MLCDCHNOCFI, JsonSerializer BMKNJFOIIEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7B545A0", Offset = "0x7B537A0", VA = "0x187B545A0")]
		private static bool KMBMCGNAMLA(object MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public AEPDKEAAENA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly JsonSerializerSettings PDKFGEDPJIJ;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7B584D0", Offset = "0x7B576D0", VA = "0x187B584D0")]
	internal GBBBMPGEIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x381E8F0", Offset = "0x381DAF0", VA = "0x18381E8F0", Slot = "4")]
	public string EBKCPJJKDBC<T>(T DBCLNEGBNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x381E950", Offset = "0x381DB50", VA = "0x18381E950", Slot = "5")]
	public T MFKKOENJELG<T>(string MLCDCHNOCFI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class DOEGBBEKCAI : JINKGABEJML
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x36741D0", Offset = "0x36733D0", VA = "0x1836741D0", Slot = "4")]
	public string EBKCPJJKDBC<T>(T DBCLNEGBNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3674250", Offset = "0x3673450", VA = "0x183674250", Slot = "5")]
	public T MFKKOENJELG<T>(string MLCDCHNOCFI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DOEGBBEKCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[CFBFBMEJALB]
internal class GAIKFDKDBKE : PMKFDJIKGIL<AKHNIDFFNPA, FCGFCMKDIAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly JINKGABEJML BBCDDKGNDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly FCFDCMAIFMA KKFHBKHKLCD;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7B58390", Offset = "0x7B57590", VA = "0x187B58390")]
	public GAIKFDKDBKE(JINKGABEJML BBCDDKGNDAB, FCFDCMAIFMA KKFHBKHKLCD, DECADMNPJIG ICPFLHOEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7B57360", Offset = "0x7B56560", VA = "0x187B57360", Slot = "6")]
	public override FCGFCMKDIAL JKAINKAKBPB(AKHNIDFFNPA EEEOGOJIPGB, [Out] IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7B578E0", Offset = "0x7B56AE0", VA = "0x187B578E0")]
	internal void MFKELPLBOGN(string CNMCNFHDGKA, HEAMFGBJNNJ LNAHHHMDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B580E0", Offset = "0x7B572E0", VA = "0x187B580E0")]
	public IEnumerable<ONPEEMOLPPE> PLNPIFKNHBL(string GHBCAOEILBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7B56F40", Offset = "0x7B56140", VA = "0x187B56F40")]
	private IEnumerable<ONPEEMOLPPE> INOPPMEOPCD(string GHBCAOEILBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7B56AF0", Offset = "0x7B55CF0", VA = "0x187B56AF0")]
	internal IEnumerable<ONPEEMOLPPE> FHDIEDKDHEJ(string GHBCAOEILBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B57A40", Offset = "0x7B56C40", VA = "0x187B57A40")]
	private ONPEEMOLPPE NFBDCDABEMB(AvatarOutfitSelectionData DJLEKOIINOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7B55F70", Offset = "0x7B55170", VA = "0x187B55F70")]
	private void BDEJPBCMIBJ(AvatarCustomizationSettingsData JMMIKOCDHGI, HEAMFGBJNNJ LNAHHHMDCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7B57DC0", Offset = "0x7B56FC0", VA = "0x187B57DC0")]
	private ONPEEMOLPPE NFBDCDABEMB(string BLOKCDFKHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7B567F0", Offset = "0x7B559F0", VA = "0x187B567F0")]
	internal static (KPCHKNGGLCC, string, string) BMOFKJCEOFF(string BLOKCDFKHKD, DECADMNPJIG ICPFLHOEKBN)
	{
		return default((KPCHKNGGLCC, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7B58190", Offset = "0x7B57390", VA = "0x187B58190")]
	private GLCEONPLMMA? PMHJFMIEDLG(string? DIHOLCNHIND, Vector2 BKOODGIFLHB, float NJBNCPCJNPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7B57780", Offset = "0x7B56980", VA = "0x187B57780")]
	private static EDFKFIPIEMK JOHHOKANGFG(AvatarCustomizationSettingsData.AnchorParams OANNFBKIILM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CFBFBMEJALB]
internal class IOEJMBNPOKI : JJNFJJLJHFM, EANJEECINCE
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7B59C50", Offset = "0x7B58E50", VA = "0x187B59C50")]
	public IOEJMBNPOKI(JINKGABEJML BBCDDKGNDAB, FCFDCMAIFMA KKFHBKHKLCD, DECADMNPJIG ICPFLHOEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7B59560", Offset = "0x7B58760", VA = "0x187B59560", Slot = "4")]
	public MADOHDFLEFJ CEBCPPBDNIB(HEAMFGBJNNJ DHAOEHNLNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7B59910", Offset = "0x7B58B10", VA = "0x187B59910")]
	private string FBKLLBJDCNO(HEAMFGBJNNJ LNAHHHMDCMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7B59A10", Offset = "0x7B58C10", VA = "0x187B59A10")]
	private string KDMPBCACOAJ(ONPEEMOLPPE CAGJKICDFJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CFBFBMEJALB]
internal class PILCLKEPJLJ : PMKFDJIKGIL<AKHNIDFFNPA, FCGFCMKDIAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly JINKGABEJML BBCDDKGNDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly NIDIDCFABDI<AKHNIDFFNPA, FCGFCMKDIAL> LGOBECBNOJH;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F680", Offset = "0x7B5E880", VA = "0x187B5F680")]
	public PILCLKEPJLJ(NIDIDCFABDI<AKHNIDFFNPA, FCGFCMKDIAL> LGOBECBNOJH, DECADMNPJIG ICPFLHOEKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F250", Offset = "0x7B5E450", VA = "0x187B5F250", Slot = "6")]
	public override FCGFCMKDIAL JKAINKAKBPB(AKHNIDFFNPA EEEOGOJIPGB, [Out] IReadOnlyList<MJJEAILKKIC>? KGFMNFNGEKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[CFBFBMEJALB]
internal class IINNGAJIGIF : FJGKNOBLJFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly JINKGABEJML BBCDDKGNDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly EANJEECINCE OELOBPBBMFM;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7B59470", Offset = "0x7B58670", VA = "0x187B59470")]
	public IINNGAJIGIF(EANJEECINCE OELOBPBBMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7B590D0", Offset = "0x7B582D0", VA = "0x187B590D0", Slot = "4")]
	public AKHNIDFFNPA CEBCPPBDNIB(HEAMFGBJNNJ DHAOEHNLNON, int FIAODFNFKEN, string? DGIAFBEDPNJ, string? KLKFBNEMAON, LNMPHCNNDCM BCCBJDEOPHO, List<MJJEAILKKIC>? KGFMNFNGEKO)
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
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7B54970", Offset = "0x7B53B70", VA = "0x187B54970")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LMFDKOAOEOO
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7B5EAF0", Offset = "0x7B5DCF0", VA = "0x187B5EAF0")]
	public static PMLAJJBBALO JKAINKAKBPB(this MGOEOENKEHH DHAOEHNLNON)
	{
		return default(PMLAJJBBALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E9D0", Offset = "0x7B5DBD0", VA = "0x187B5E9D0")]
	public static MGOEOENKEHH CEBCPPBDNIB(this PMLAJJBBALO ODMNDGGNEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5EC00", Offset = "0x7B5DE00", VA = "0x187B5EC00")]
	public static bool LKIECDGFHLC(this PMLAJJBBALO ODMNDGGNEHM)
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
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x5C51670", Offset = "0x5C50870", VA = "0x185C51670")]
			public AnchorParams(Vector2 FPOKODMMKIM, Vector3 GPJCKDOKELO, Vector3 HNPGHEDFFIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x7B548C0", Offset = "0x7B53AC0", VA = "0x187B548C0")]
			internal EDFKFIPIEMK CEBCPPBDNIB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private BIDLKADDAJF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7B55160", Offset = "0x7B54360", VA = "0x187B55160")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4B788E0", Offset = "0x4B77AE0", VA = "0x184B788E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xF498C0", Offset = "0xF48AC0", VA = "0x180F498C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x1310930", Offset = "0x130FB30", VA = "0x181310930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x7B55200", Offset = "0x7B54400", VA = "0x187B55200")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x9FD8C0", Offset = "0x9FCAC0", VA = "0x1809FD8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xC079B0", Offset = "0xC06BB0", VA = "0x180C079B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xC07E40", Offset = "0xC07040", VA = "0x180C07E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7B55240", Offset = "0x7B54440", VA = "0x187B55240")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xE2D910", Offset = "0xE2CB10", VA = "0x180E2D910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x10CFA60", Offset = "0x10CEC60", VA = "0x1810CFA60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x17604C0", Offset = "0x175F6C0", VA = "0x1817604C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x229ACD0", Offset = "0x2299ED0", VA = "0x18229ACD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xE74AC0", Offset = "0xE73CC0", VA = "0x180E74AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA27C50", Offset = "0xA26E50", VA = "0x180A27C50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA27CB0", Offset = "0xA26EB0", VA = "0x180A27CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8670", VA = "0x1809F9470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9F93F0", Offset = "0x9F85F0", VA = "0x1809F93F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F87B0", VA = "0x1809F95B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9F9460", Offset = "0x9F8660", VA = "0x1809F9460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F94A0", Offset = "0x9F86A0", VA = "0x1809F94A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xBE1AD0", Offset = "0xBE0CD0", VA = "0x180BE1AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1316000", Offset = "0x1315200", VA = "0x181316000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9400", Offset = "0x9F8600", VA = "0x1809F9400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9F94C0", Offset = "0x9F86C0", VA = "0x1809F94C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xCDF180", Offset = "0xCDE380", VA = "0x180CDF180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xE62E80", Offset = "0xE62080", VA = "0x180E62E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x9F8B10", Offset = "0x9F7D10", VA = "0x1809F8B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x9F8AD0", Offset = "0x9F7CD0", VA = "0x1809F8AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xD6D9C0", Offset = "0xD6CBC0", VA = "0x180D6D9C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xE70820", Offset = "0xE6FA20", VA = "0x180E70820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xC79B40", Offset = "0xC78D40", VA = "0x180C79B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xC771C0", Offset = "0xC763C0", VA = "0x180C771C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public BIDLKADDAJF UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xF52E10", Offset = "0xF52010", VA = "0x180F52E10")]
			get
			{
				return default(BIDLKADDAJF);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xF50FF0", Offset = "0xF501F0", VA = "0x180F50FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xF50EC0", Offset = "0xF500C0", VA = "0x180F50EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xBDDDD0", Offset = "0xBDCFD0", VA = "0x180BDDDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x7B55220", Offset = "0x7B54420", VA = "0x187B55220")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7B55260", Offset = "0x7B54460", VA = "0x187B55260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B54E00", Offset = "0x7B54000", VA = "0x187B54E00")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public KPCHKNGGLCC BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private DCEEHFLNMHP? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x7B55280", Offset = "0x7B54480", VA = "0x187B55280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
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
