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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8235A90", Offset = "0x8234890", VA = "0x188235A90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8235B10", Offset = "0x8234910", VA = "0x188235B10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CMNOLHHFBOP]
internal class JEBOIKMPBPC : ACLMIKLBCIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PHBHBOHJPCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public JEBOIKMPBPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public JLFDMKNKLIE avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MFFAIOFDDLP INJAFCCJABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NFOPFCKFBPO KHNKABPIGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HEJDANFBOBB DBJHBADFBLJ;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8234B90", Offset = "0x8233990", VA = "0x188234B90")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	[UsedImplicitly]
	internal static void HGDPONKELKJ(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8235870", Offset = "0x8234670", VA = "0x188235870")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JEBOIKMPBPC([POMNKOCGGBN(null)] MFFAIOFDDLP INJAFCCJABL, [POMNKOCGGBN(null)] NFOPFCKFBPO KHNKABPIGHM, [POMNKOCGGBN(null)] HEJDANFBOBB DBJHBADFBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8234C00", Offset = "0x8233A00", VA = "0x188234C00", Slot = "5")]
	public BNICAFPKAPB KCBEKJMMLGP(JLFDMKNKLIE FMEDCNPIHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8233D70", Offset = "0x8232B70", VA = "0x188233D70", Slot = "4")]
	public BNICAFPKAPB AIPBJFEGMPE(JLFDMKNKLIE FMEDCNPIHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8234880", Offset = "0x8233680", VA = "0x188234880", Slot = "6")]
	public DBKPFJPOFHC CGKKFNLAODC(BNICAFPKAPB KANAIIDGHCH, int HPEFGPPMOIE, string? PFLDDMDPCBI, string? IIHGKMIFHHF, IHPKKIOOIAO FHOECEOGNGE, List<ECJGOBMDJGD>? MHOHKDCDHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8234A70", Offset = "0x8233870", VA = "0x188234A70", Slot = "7")]
	public bool DBHIAOAHMFL(JOPDFCKLKOH OILEKNGLFHO, [Out] BNICAFPKAPB? HHPKINNPBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8234990", Offset = "0x8233790", VA = "0x188234990", Slot = "8")]
	public bool CJCAGADJJAH(DBKPFJPOFHC FKFEIKMGOCI, [Out] BNICAFPKAPB? HHPKINNPBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8234B00", Offset = "0x8233900", VA = "0x188234B00", Slot = "9")]
	public bool EOBMPCICDBK(DBKPFJPOFHC FKFEIKMGOCI, [Out] CLOGEGKIKOE? OILEKNGLFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D68E50", Offset = "0x3D67C50", VA = "0x183D68E50")]
	private bool GNCEBPDNLPL<TInput, TOutput>(TInput DANFKLEPBNF, AKMGAHHABGI<TInput, TOutput> EBFEMGNAONA, [Out] TOutput? MOBFLOHJOKJ) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82356C0", Offset = "0x82344C0", VA = "0x1882356C0")]
	[CompilerGenerated]
	private NCGKAGAAIBB MNLLDAMMIBJ(FaceFeatureType BJLOCBNAGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82354E0", Offset = "0x82342E0", VA = "0x1882354E0")]
	[CompilerGenerated]
	private NCGKAGAAIBB MBJMABHMGFP(FaceFeatureType BJLOCBNAGBJ, PHBHBOHJPCD P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CMNOLHHFBOP]
internal class ADOJEMGGKEG : MFFAIOFDDLP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void KHOHIFHGCLF<in TData>(TData HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NHGELMEOHBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public HGIEHEPCDPB rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DFPPDPOHHLA currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public DFPPDPOHHLA latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public NHGELMEOHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82359F0", Offset = "0x82347F0", VA = "0x1882359F0")]
		internal bool OICNDMNKPJA(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8235A10", Offset = "0x8234810", VA = "0x188235A10")]
		internal bool PJDDJEAGHGN(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HEJDANFBOBB DBJHBADFBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ODEBHGOALGK NJIBFENKDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KHOHIFHGCLF<BNICAFPKAPB>?[] INJAFCCJABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KHOHIFHGCLF<CLOGEGKIKOE>?[] CNJADEBFOOB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8215CB0", Offset = "0x8214AB0", VA = "0x188215CB0")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	[UsedImplicitly]
	internal static void HGDPONKELKJ(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8217430", Offset = "0x8216230", VA = "0x188217430")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ADOJEMGGKEG([POMNKOCGGBN(null)] HEJDANFBOBB DBJHBADFBLJ, [POMNKOCGGBN(null)] ODEBHGOALGK NJIBFENKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8215E80", Offset = "0x8214C80", VA = "0x188215E80", Slot = "4")]
	public bool HGMOMJLEKDF(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8215D20", Offset = "0x8214B20", VA = "0x188215D20", Slot = "5")]
	public bool HGMOMJLEKDF(CLOGEGKIKOE OILEKNGLFHO, IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82165B0", Offset = "0x82153B0", VA = "0x1882165B0")]
	private void LAKJONKGFOG(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8215860", Offset = "0x8214660", VA = "0x188215860")]
	private void BIBFNJDLKMJ(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82162A0", Offset = "0x82150A0", VA = "0x1882162A0")]
	private void JHJKNNKBMJP(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8215830", Offset = "0x8214630", VA = "0x188215830")]
	private void BAMJHAGAAHK(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8217190", Offset = "0x8215F90", VA = "0x188217190")]
	private void MAGDMLJOPDP(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8215C00", Offset = "0x8214A00", VA = "0x188215C00")]
	private void FMCJENDHBBK(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8215B50", Offset = "0x8214950", VA = "0x188215B50")]
	private void FJPFJBOKGNB(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8215A90", Offset = "0x8214890", VA = "0x188215A90")]
	private void EDEGCIKOKFD(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8215B20", Offset = "0x8214920", VA = "0x188215B20")]
	private void FAHOAOIGCGO(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8215AA0", Offset = "0x82148A0", VA = "0x188215AA0")]
	private void EFLBBHKDILJ(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? OGPILIPEPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82162D0", Offset = "0x82150D0", VA = "0x1882162D0")]
	private void KKEFLAELDCG(BNICAFPKAPB HHPKINNPBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8215F80", Offset = "0x8214D80", VA = "0x188215F80")]
	private BNICAFPKAPB HHFGBKKLGON(BNICAFPKAPB HHPKINNPBPL, List<RangeMigration> BEBKACMEPAF, DFPPDPOHHLA OMHCEJHDMDC, DFPPDPOHHLA NBDBJHCEOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8216260", Offset = "0x8215060", VA = "0x188216260")]
	private float ILPIPBGFLGF(float MHDOOFEMKIL, Vector2 FOMGGGJEKID, Vector2 DKLJMCDCKOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8217260", Offset = "0x8216060", VA = "0x188217260")]
	private (RangeMigration?, RangeMigration?) PFAAGMCAANN(List<RangeMigration> JNINNONOIOM, HGIEHEPCDPB AEOEMIPNHJD, DFPPDPOHHLA OMHCEJHDMDC, DFPPDPOHHLA NBDBJHCEOII)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MFFAIOFDDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGMOMJLEKDF(BNICAFPKAPB HHPKINNPBPL, IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HGMOMJLEKDF(CLOGEGKIKOE OILEKNGLFHO, IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE);
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
		public CFOIPNKKFKM AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x82318D0", Offset = "0x82306D0", VA = "0x1882318D0")]
		public void GIEKIEBEKMC(AnimationPoseSetting FGAEAFBDBPK, float BDCOHHBHKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8231A00", Offset = "0x8230800", VA = "0x188231A00")]
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
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x82322F0", Offset = "0x82310F0", VA = "0x1882322F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82322B0", Offset = "0x82310B0", VA = "0x1882322B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8231A20", Offset = "0x8230820", VA = "0x188231A20")]
		private void CGNHJHGPAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81A0EF0", Offset = "0x819FCF0", VA = "0x1881A0EF0", Slot = "4")]
		public void SetEnabled(bool GDNKPNFMPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8232320", Offset = "0x8231120", VA = "0x188232320")]
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
		[Cpp2IlInjected.Address(RVA = "0x8232360", Offset = "0x8231160", VA = "0x188232360")]
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
		[Cpp2IlInjected.Address(RVA = "0x82323A0", Offset = "0x82311A0", VA = "0x1882323A0")]
		public AnimationPoseSetting EIEEPNDNMDA(CFOIPNKKFKM JBDGHAGBKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82323D0", Offset = "0x82311D0", VA = "0x1882323D0")]
		public void MHDKBDCHLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8232410", Offset = "0x8231210", VA = "0x188232410")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum IKAOJEHDGGB
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private IKAOJEHDGGB handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x8232F00", Offset = "0x8231D00", VA = "0x188232F00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8232EC0", Offset = "0x8231CC0", VA = "0x188232EC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82328C0", Offset = "0x82316C0", VA = "0x1882328C0")]
		private void CGNHJHGPAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81A0EF0", Offset = "0x819FCF0", VA = "0x1881A0EF0", Slot = "4")]
		public void SetEnabled(bool GDNKPNFMPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8232F30", Offset = "0x8231D30", VA = "0x188232F30")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, IFPMCPKDOOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private JLFDMKNKLIE avatarBodyType;

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
		[LAEBPIHCEIF(FBMDOBLPJCI.SelfAndChildren, false, false, false)]
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
		private PPALDFNLNHA DFJDPEMFJDA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public PPALDFNLNHA INJAHAPBLPC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB6C990", Offset = "0xB6B790", VA = "0x180B6C990", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform CGCOEIEGHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8233D50", Offset = "0x8232B50", VA = "0x188233D50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8232F60", Offset = "0x8231D60", VA = "0x188232F60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8233C10", Offset = "0x8232A10", VA = "0x188233C10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8233BC0", Offset = "0x82329C0", VA = "0x188233BC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8233B50", Offset = "0x8232950", VA = "0x188233B50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8232F60", Offset = "0x8231D60", VA = "0x188232F60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82332F0", Offset = "0x82320F0", VA = "0x1882332F0", Slot = "6")]
		public PPALDFNLNHA CreateAvatarSystem(string KKIFLDDKBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8233B50", Offset = "0x8232950", VA = "0x188233B50", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8233020", Offset = "0x8231E20", VA = "0x188233020", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8233C60", Offset = "0x8232A60", VA = "0x188233C60", Slot = "9")]
		public void UpdatePostIKAnimControllers(float GCGEIJPOBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class AHOPHCOOHGC : PPALDFNLNHA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class HFDFMJHPEMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Vector3 KHIGMLLFCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Quaternion CKOPCMEEBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Vector3 LPNMKLALCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Transform IKGLBFKMEIH;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 KNMHNAGFCBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x220D2A0", Offset = "0x220C0A0", VA = "0x18220D2A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x220D2C0", Offset = "0x220C0C0", VA = "0x18220D2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion JOGMOLFGICN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x160DA30", Offset = "0x160C830", VA = "0x18160DA30")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x160DA40", Offset = "0x160C840", VA = "0x18160DA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float LDBJKEDMDLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1284CB0", Offset = "0x1283AB0", VA = "0x181284CB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1A09920", Offset = "0x1A08720", VA = "0x181A09920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IKDPOBKKIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA98B80", Offset = "0xA97980", VA = "0x180A98B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA98B30", Offset = "0xA97930", VA = "0x180A98B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool IHMOHMCILBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA98B20", Offset = "0xA97920", VA = "0x180A98B20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA98B40", Offset = "0xA97940", VA = "0x180A98B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool PPNPDKHDFLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA98B00", Offset = "0xA97900", VA = "0x180A98B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA98D00", Offset = "0xA97B00", VA = "0x180A98D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float KDFKCDMHMHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xE12C90", Offset = "0xE11A90", VA = "0x180E12C90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xE13750", Offset = "0xE12550", VA = "0x180E13750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x823C110", Offset = "0x823AF10", VA = "0x18823C110")]
		public void KJMDKMOIDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x823BA30", Offset = "0x823A830", VA = "0x18823BA30")]
		public void CADPCHLBMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x823C350", Offset = "0x823B150", VA = "0x18823C350")]
		public float MCHMEPNMLAH(Vector3 MDGAKHAAMIJ, Quaternion OELKMHDBBHF, [In] AvatarFootSettings DLCGBGNGLAA, float OHKFJKDLDFG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x823BA40", Offset = "0x823A840", VA = "0x18823BA40")]
		public void DCAMFMPCHBG(Vector3 JABOCIKIENE, Quaternion KDKJIPAKLNA, Transform KCCFFDGIMOP, float LBIIIIFAMLB, bool NHHBPHEHMMD, bool HDLGPHCADAB, float NLHDMABNFHL, float FPGENMIKOCB, Transform MMENCBNBOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x823C120", Offset = "0x823AF20", VA = "0x18823C120")]
		public void LDKDPGOMNKG(Transform LMIJCDNAAJD, Transform MMENCBNBOBJ, bool FAFMLPPIBKM, bool MKPHKNACDNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x823C560", Offset = "0x823B360", VA = "0x18823C560")]
		private void NKNEKKCFEPK(Transform MMENCBNBOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x823C660", Offset = "0x823B460", VA = "0x18823C660")]
		public bool NLEIHLPAMGG(Transform MMENCBNBOBJ, AvatarFullBodyConfiguration AFFIHAGMLBN, Vector3 JLGCOAFKOCK, float LGOLBJJJCGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x823C7B0", Offset = "0x823B5B0", VA = "0x18823C7B0")]
		public void PGENFIKFCEP(float FPGENMIKOCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x823C7D0", Offset = "0x823B5D0", VA = "0x18823C7D0")]
		public HFDFMJHPEMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class MMDBLGOACOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private float IAHJKLJICJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool KHNFANHLEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AnimationPoseSetting BEEIABPCLPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private float EGGKBMDIEIB;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x823EF60", Offset = "0x823DD60", VA = "0x18823EF60")]
		public void MKLBDPFGDOA(IKSolverVR.Arm CCOFBBHDHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x823EF90", Offset = "0x823DD90", VA = "0x18823EF90")]
		public void MONFHHDICKK(IKSolverVR.Arm CCOFBBHDHHG, float DCANEBNFLPK, bool KHNFANHLEHL, AvatarFullBodyConfiguration AFFIHAGMLBN, float ANOLGLFFBFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x823DF40", Offset = "0x823CD40", VA = "0x18823DF40")]
		private void DFMEFEEKODF(IKSolverVR.Arm CCOFBBHDHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x823E420", Offset = "0x823D220", VA = "0x18823E420")]
		public void FLDBBOJOKMB(IKSolverVR.Arm CCOFBBHDHHG, Transform NHPBEBGNCGA, Transform KCCFFDGIMOP, Quaternion AOILCOMMFIH, Vector3 BBAJONKPKJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x823EFD0", Offset = "0x823DDD0", VA = "0x18823EFD0")]
		private (Vector3, Quaternion) NAAFPCBNLDK(CCPCLKELKAE IHIGJAHAMJN, Quaternion LHNMHCNGLMD, Vector3 LAMFNLNKGOF)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x823EE00", Offset = "0x823DC00", VA = "0x18823EE00")]
		public void KPFMDGEGLNO(CCPCLKELKAE IHIGJAHAMJN, IKSolverVR.Arm CCOFBBHDHHG, Quaternion LHNMHCNGLMD, Vector3 LAMFNLNKGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x823E800", Offset = "0x823D600", VA = "0x18823E800")]
		public void HOLKLNGDCBJ(CCPCLKELKAE IHIGJAHAMJN, IKSolverVR.Arm CCOFBBHDHHG, Quaternion LHNMHCNGLMD, Vector3 LAMFNLNKGOF, [In] AvatarFullBodyConfiguration AFFIHAGMLBN, [In] HFOHEOCIICK GKGDEKNIOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x823F460", Offset = "0x823E260", VA = "0x18823F460")]
		public void NBCLOAEJLPL(CFOIPNKKFKM AGCAIGIKJHA, AvatarFullBodyConfiguration AFFIHAGMLBN, HFOHEOCIICK GKGDEKNIOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x823DF80", Offset = "0x823CD80", VA = "0x18823DF80")]
		public void EMJMJEDJNNF(IKSolverVR.Arm CCOFBBHDHHG, Transform NHPBEBGNCGA, Vector3 ACIJEAKGMBK, float CNAFJBKHJFE, Quaternion CCLCBBKFIND, Vector3 CNCCHINIFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x823F5A0", Offset = "0x823E3A0", VA = "0x18823F5A0")]
		public MMDBLGOACOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum LHKGLELBKPL
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
	private struct PMLBPGKJHIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct BLPFDJHPNPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int DJPDHEKFJBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int ECHBFJMIPKL;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int DCDBLMJEOAK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int ADGJOAKOGAI;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JJJIFACJPKE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int OKBIJKNHLJJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int OPGFCIDPMBG;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int KJPCFKOMLIC;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int PKOHNHAMFMC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int MGGLELINAHF;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int EFNJCPONDEP;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int OGGGFMAOHCG;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int EBIENPPMCCK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int ANMDEMLKMPB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int KHAIKJEHFEB;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int AHDBLMMNDPK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int DNBDKKPIKLC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int IHFOGKCBFBD;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int LDMIILHBKKA;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int KMFFONJCGBP;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int BBFEGGMLLFI;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int OLGAPNONOBG;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int CLMONOEKNEA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int EBHKMEEOAJM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int DKOFJPOMPIA;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int KCGPNLDEICK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int MKOGJCNBMAD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int PBABJNFCIGE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int KEEGECNGCJD;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int CLEBALAGMCJ;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int EGAGNFEIPDF;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int GCBMKHNAHKI;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly Vector3 MADINCBNDMJ;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int MCLOAPGNIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool PKIAAINJHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool GHHECJOCAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool HGIMENCEIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool DHCGNCHCHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool KNGLFPPDFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool KGACNDGLMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Vector3 OPNPIGBDGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private string OMBLDCHJIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private BNIMIEOPIIA? AKEFFNFBFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private MKPNDPDPNLP? KMDFBCOJHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private BBJFEIJFEIJ MKPACEIOJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private AFEKBAOOHIK OIDBKAMLNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CCPCLKELKAE CPANCJHMHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private CCPCLKELKAE IEMIELGHOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool KPDMNKGEDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x291")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool MEKIKFHPAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly CABMLHCMPED HHKIJCCNNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly MDDPEAKDNMD MLDNGCKLAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int FDMELLOCMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private float DIDLOABJIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GameObject GKJGCAPLODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Transform AEIGPJJBBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Transform GEANCOGDFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Transform CJOCGCGIHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform ICLCHAKKBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float FFEIAGMDIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float OIEOGEBMJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Vector3 JECDEEDLENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Quaternion MAIDNDOELLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Transform PGPMHALOALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Transform AELDKFCLGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Transform OCBGBPAOMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private HDFNMPGEKIM JCOMCEOEBBD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker PNLDCIKICFL;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker OLPDBMGGFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private ProfilerMarker NONHDFANHNF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly ProfilerMarker JNOMAEDGAHI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ProfilerMarker DIFCGBJKGLP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly ProfilerMarker BFAACGNGPNJ;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly List<AHOPHCOOHGC> IFPMABEIHGI;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int LBLDEEBNOCN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> LAAKOLMHKFJ;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int IELGNEIGJFH;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static int LADPGBCNMEI;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static int BPAOOOMIGNE;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int FPJMHFAIPNE;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float NMHPGHCBCEK;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static int NLHFHHGCIFA;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float IOIHPGJAHFP;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static float AHFAFKEGECK;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static float FPIKEBNPGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static float NGHACFHPJOO;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static DHBGHGNDHHP PBOBENOFPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float HALFGEGPBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private bool EFCHPAOKNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private float ALNKIEEBNJD;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly int NEJKCNBJJOK;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly int JPIMBKBFBKO;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly int OAGAOCFENOF;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly int AMMCLDABMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private HFDFMJHPEMP AOHPAJHFPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private HFDFMJHPEMP MMMDPLJIDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float LMPBMHBGFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 NINKAILJIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private Vector3 EAKLGOIEBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool EJPJAMEHKGD;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly Quaternion OLIBGJFNJJI;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly Quaternion BLEPCMEOHHC;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly Vector3 CBJIHCPPLGB;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly Vector3 HMLKMCCEEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private float IJCNAIOCBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float EGHFOPAHHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private MMDBLGOACOM HGOACOAMDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private MMDBLGOACOM OIHIEMPOGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private GKJPALOFPCE NMLAPLBMLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private LCOGOKFNHFH CGGEOACPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly DAFCHMOPPOE IDGEGFOLIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float LLGCGIHKECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float BIDBPICJIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly LCOGOKFNHFH KPPGMMDEAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private Vector3 CFNEEDLKGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Vector3 BPANBFLMODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private float JNKIIADOJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private float PCAOMHAHLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly LCOGOKFNHFH KPNBFGKECLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly GKJPALOFPCE KDPKAMDDLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly LCOGOKFNHFH IIEGMODGDJM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MKAEDPHCCBC OGMECMMEJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MKAEDPHCCBC ABIEBLDGABD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration JLBHAGOLLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x821EDC0", Offset = "0x821DBC0", VA = "0x18821EDC0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JLFDMKNKLIE MMCOGLIKBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8220520", Offset = "0x821F320", VA = "0x188220520", Slot = "24")]
		get
		{
			return default(JLFDMKNKLIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration DGOKDJNEAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x822D9B0", Offset = "0x822C7B0", VA = "0x18822D9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform IECFPFPLNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x821A2E0", Offset = "0x82190E0", VA = "0x18821A2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform MLPGMNNJJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x822DAC0", Offset = "0x822C8C0", VA = "0x18822DAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer KLPFGBHLPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8222CD0", Offset = "0x8221AD0", VA = "0x188222CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] NNEOCHMPAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x822AC10", Offset = "0x8229A10", VA = "0x18822AC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] BENMPHGPLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8222DA0", Offset = "0x8221BA0", VA = "0x188222DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator DCDFFEBOMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x821EED0", Offset = "0x821DCD0", VA = "0x18821EED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK LHKILBNBMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x821B3C0", Offset = "0x821A1C0", VA = "0x18821B3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private NCDFCANDICB GMNLEMDBABB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x822BDD0", Offset = "0x822ABD0", VA = "0x18822BDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private NCDFCANDICB MOFIEKMOACL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82287F0", Offset = "0x82275F0", VA = "0x1882287F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private NCDFCANDICB IPLLMALFBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8220E00", Offset = "0x821FC00", VA = "0x188220E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private NCDFCANDICB DJNHIFMHGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x821A210", Offset = "0x8219010", VA = "0x18821A210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private NCDFCANDICB JOAKGGOMDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x821AB10", Offset = "0x8219910", VA = "0x18821AB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private NCDFCANDICB LBLHOHNFJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x822F290", Offset = "0x822E090", VA = "0x18822F290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private NCDFCANDICB GEHOBOAPBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x821AA40", Offset = "0x8219840", VA = "0x18821AA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private NCDFCANDICB DCDDPHGODDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x822F360", Offset = "0x822E160", VA = "0x18822F360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MKPNDPDPNLP KFEFJBEOIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8228BA0", Offset = "0x82279A0", VA = "0x188228BA0", Slot = "16")]
		get
		{
			return default(MKPNDPDPNLP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FCEMHMOCEFP DPBCJNMFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC1DC40", Offset = "0xC1CA40", VA = "0x180C1DC40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EDFBLEEALAN CHGFBPCCMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xC1DC30", Offset = "0xC1CA30", VA = "0x180C1DC30", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ELMDBEFEDJJ EJAMPLFEAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC1DC50", Offset = "0xC1CA50", VA = "0x180C1DC50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ELMDBEFEDJJ FAOMJFLPCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC1DC20", Offset = "0xC1CA20", VA = "0x180C1DC20", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string ONEJLDMHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform BAJDHHMKJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82295A0", Offset = "0x82283A0", VA = "0x1882295A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform KKFJEHGMJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x822D260", Offset = "0x822C060", VA = "0x18822D260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform COEOIAGMPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8225ED0", Offset = "0x8224CD0", VA = "0x188225ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform JCGKJDLNBOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x821EE90", Offset = "0x821DC90", VA = "0x18821EE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform LIFHPCKLLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8228DA0", Offset = "0x8227BA0", VA = "0x188228DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool FMDJANJLMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8225060", Offset = "0x8223E60", VA = "0x188225060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool JJOJBNGGLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8225060", Offset = "0x8223E60", VA = "0x188225060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool GHDEHHEGABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8222E70", Offset = "0x8221C70", VA = "0x188222E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform ECNLOBBKOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x822AD10", Offset = "0x8229B10", VA = "0x18822AD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject DFFAMKHOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x822A1A0", Offset = "0x8228FA0", VA = "0x18822A1A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets KMDFJDEJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x82305A0", Offset = "0x822F3A0", VA = "0x1882305A0", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform BDMPLCIMMPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAFA680", Offset = "0xAF9480", VA = "0x180AFA680", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform MABMBCFLOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xBA6D00", Offset = "0xBA5B00", VA = "0x180BA6D00", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform FGFCOJDHNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xBA6EA0", Offset = "0xBA5CA0", VA = "0x180BA6EA0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform BAGAEBEAELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBA6E10", Offset = "0xBA5C10", VA = "0x180BA6E10", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 DNBNBFAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8230510", Offset = "0x822F310", VA = "0x188230510", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float DMALKJJNFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8230820", Offset = "0x822F620", VA = "0x188230820", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform EFJLAGLEKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82295F0", Offset = "0x82283F0", VA = "0x1882295F0", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform EONJDPIJGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x226EE50", Offset = "0x226DC50", VA = "0x18226EE50", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform IFGPOPMFGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBA6CE0", Offset = "0xBA5AE0", VA = "0x180BA6CE0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CAEHMKHMNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28E0440", Offset = "0x28DF240", VA = "0x1828E0440", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool NOBFCKDPLGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8228CB0", Offset = "0x8227AB0", VA = "0x188228CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public GBCEOPMAPJH<PPALDFNLNHA.JAPLGIFFLIB> PMCLODDFMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8230640", Offset = "0x822F440", VA = "0x188230640", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool AINMAFBKEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8217EB0", Offset = "0x8216CB0", VA = "0x188217EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool HLNLPOFPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x822DA40", Offset = "0x822C840", VA = "0x18822DA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x821BD70", Offset = "0x821AB70", VA = "0x18821BD70")]
	private float CKDNOKCHPAJ(GFHOPDLHFLM KMEIIKNIOAB, float DNNMAELFHCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8223580", Offset = "0x8222380", VA = "0x188223580")]
	private void GPFLBBMFDKE([In] HFOHEOCIICK ALFGBNABAAJ, [In] AvatarFullBodyConfiguration AFFIHAGMLBN, bool NJIFMAJHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x822BEA0", Offset = "0x822ACA0", VA = "0x18822BEA0")]
	private float KLAHKDIOLDD([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x822C2E0", Offset = "0x822B0E0", VA = "0x18822C2E0")]
	private float KPLDBHJHEOE([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8217B20", Offset = "0x8216920", VA = "0x188217B20")]
	private void AEFIPDEBLGH(HFOHEOCIICK ALFGBNABAAJ, AvatarFullBodyConfiguration AFFIHAGMLBN, bool NJIFMAJHDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x822D5C0", Offset = "0x822C3C0", VA = "0x18822D5C0")]
	private void MDDODCBGNKE([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x822EE20", Offset = "0x822DC20", VA = "0x18822EE20")]
	private void NJGENMCKHMC([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82313D0", Offset = "0x82301D0", VA = "0x1882313D0")]
	public AHOPHCOOHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x822E130", Offset = "0x822CF30", VA = "0x18822E130", Slot = "13")]
	public void NGONMBKKENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x822BF30", Offset = "0x822AD30", VA = "0x18822BF30", Slot = "14")]
	public void KNLKPDIHHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x821A140", Offset = "0x8218F40", VA = "0x18821A140", Slot = "15")]
	public void BHJOLHKJDDM(bool JPGDOAGJAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x822F870", Offset = "0x822E670", VA = "0x18822F870", Slot = "26")]
	public Transform OAAPOGDEGCL(string EOIFEFNLELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x822B5E0", Offset = "0x822A3E0", VA = "0x18822B5E0", Slot = "27")]
	public Vector3? KDMFNCDAPPM(string EOIFEFNLELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8219780", Offset = "0x8218580", VA = "0x188219780", Slot = "7")]
	public void BFHNLMPJOEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8219A50", Offset = "0x8218850", VA = "0x188219A50")]
	private void BGMHFBMJEIC(AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82250B0", Offset = "0x8223EB0", VA = "0x1882250B0", Slot = "8")]
	public void HDLJGDCMAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x822FD80", Offset = "0x822EB80", VA = "0x18822FD80")]
	private void OCDGCEFIEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82306A0", Offset = "0x822F4A0", VA = "0x1882306A0")]
	private Vector3 PJONNECAEGI([In] HFOHEOCIICK GKGDEKNIOCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8225CE0", Offset = "0x8224AE0", VA = "0x188225CE0", Slot = "6")]
	public void HHFADJNGEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x821B490", Offset = "0x821A290", VA = "0x18821B490")]
	private void CDNJKHPDAEB(bool NJIFMAJHDHI, LHKGLELBKPL FGBBFJLMIOK, AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x821A0D0", Offset = "0x8218ED0", VA = "0x18821A0D0", Slot = "9")]
	public void BHHNFKNOAPA(float APBPLCHJFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8230650", Offset = "0x822F450", VA = "0x188230650")]
	private void PIHOKNNEHKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x821C160", Offset = "0x821AF60", VA = "0x18821C160", Slot = "4")]
	public void DCJJGMOFDIB(string KKIFLDDKBNC, BNIMIEOPIIA DGHBDIJLPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x821AF40", Offset = "0x8219D40", VA = "0x18821AF40", Slot = "5")]
	public void CADAANHFMNB(MKPNDPDPNLP PAKFCFMEHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x822F130", Offset = "0x822DF30", VA = "0x18822F130", Slot = "12")]
	public void NMAHNEJEOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x822F9C0", Offset = "0x822E7C0", VA = "0x18822F9C0", Slot = "25")]
	public void OAEFOFJMKBF([Out] Vector3 PGOBAMLEIOJ, [Out] Quaternion CCLCBBKFIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x822ACE0", Offset = "0x8229AE0", VA = "0x18822ACE0")]
	private void JLDEPEPPOEG([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x821F230", Offset = "0x821E030", VA = "0x18821F230", Slot = "28")]
	public void EGCFPFFDCBG(float ODFBIDNPCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8220080", Offset = "0x821EE80", VA = "0x188220080", Slot = "29")]
	public void ENJFLGIMGOI(float EIKJACBLMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8217F30", Offset = "0x8216D30", VA = "0x188217F30", Slot = "46")]
	public void APILOHMGDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x822F0E0", Offset = "0x822DEE0", VA = "0x18822F0E0", Slot = "30")]
	public void NKCMHLLCIPN(bool ONICGHEMIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8220030", Offset = "0x821EE30", VA = "0x188220030", Slot = "31")]
	public HandLogicOffsets ELNHCEHEJPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8221D70", Offset = "0x8220B70", VA = "0x188221D70", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets FMGBOABPINE()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8221E80", Offset = "0x8220C80", VA = "0x188221E80")]
	private void GAEPDAHGFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8220ED0", Offset = "0x821FCD0", VA = "0x188220ED0")]
	private void FHFKMNHJCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x822B9C0", Offset = "0x822A7C0", VA = "0x18822B9C0")]
	private void KKIPFJNDHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x82288C0", Offset = "0x82276C0", VA = "0x1882288C0")]
	private void IFAONANEFHB(HJAKPLGAOLP HFFBFJEIBNF, bool DJFEPAFCLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x82282A0", Offset = "0x82270A0", VA = "0x1882282A0")]
	private void IBIENCCIFKM(HJAKPLGAOLP HFFBFJEIBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8217E60", Offset = "0x8216C60", VA = "0x188217E60")]
	public Vector3 AHDJGHOAHFC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8229690", Offset = "0x8228490", VA = "0x188229690")]
	private void IPPFDANEOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8230620", Offset = "0x822F420", VA = "0x188230620")]
	private void PGCOFJFAHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8221050", Offset = "0x821FE50", VA = "0x188221050")]
	private void FHMFLFDBECC(HFOHEOCIICK ALFGBNABAAJ, AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8217CB0", Offset = "0x8216AB0", VA = "0x188217CB0")]
	private float AEPGHKIFAAJ([In] HFOHEOCIICK GKGDEKNIOCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8230870", Offset = "0x822F670", VA = "0x188230870")]
	private int POOLPALCPLO([In] CDCJBJIJHIA MECHCLKOPJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x82227B0", Offset = "0x82215B0", VA = "0x1882227B0")]
	private void GDMGOGPANFM(HFOHEOCIICK ALFGBNABAAJ, bool HKCDOBJIIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8220BF0", Offset = "0x821F9F0", VA = "0x188220BF0")]
	private static void FEHIMMOJONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x821E040", Offset = "0x821CE40", VA = "0x18821E040")]
	private static void DDODEHPBOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82233B0", Offset = "0x82221B0", VA = "0x1882233B0")]
	private float GOCEGNADKBO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x822FD50", Offset = "0x822EB50", VA = "0x18822FD50")]
	private static int OBKAIAFBHDB(AHOPHCOOHGC NNEMEIEKIAF, AHOPHCOOHGC JOGLOLMOJGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x82203D0", Offset = "0x821F1D0", VA = "0x1882203D0", Slot = "41")]
	public HFOHEOCIICK EOCIDPDBJLD()
	{
		return default(HFOHEOCIICK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x82196E0", Offset = "0x82184E0", VA = "0x1882196E0")]
	private bool BDOGDKPFIML(int FMFDAFLDAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x821ED40", Offset = "0x821DB40", VA = "0x18821ED40")]
	public void DIEHKPNNKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x821A3B0", Offset = "0x82191B0", VA = "0x18821A3B0")]
	private (bool, bool) BKFJJKFCIIM()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x822DB90", Offset = "0x822C990", VA = "0x18822DB90")]
	private (float, float) MPAFGMKHPPI([In] HFOHEOCIICK GKGDEKNIOCH)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8226320", Offset = "0x8225120", VA = "0x188226320")]
	private void HMKPFGHHMBI([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x822D2A0", Offset = "0x822C0A0", VA = "0x18822D2A0")]
	private void MANBIBLAFCB([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8225F00", Offset = "0x8224D00", VA = "0x188225F00")]
	private void HIPGGCILCAB([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN, AvatarFootSettings DLCGBGNGLAA, bool MJMBGOAPEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x821C0E0", Offset = "0x821AEE0", VA = "0x18821C0E0")]
	private float DAAMIBCGAOJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8218990", Offset = "0x8217790", VA = "0x188218990")]
	private void BDGMNILLFHC(HFOHEOCIICK GKGDEKNIOCH, AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8221E30", Offset = "0x8220C30", VA = "0x188221E30")]
	private float FPEPIIGNEHE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x821F430", Offset = "0x821E230", VA = "0x18821F430")]
	private void EKAHJGADHEN([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8221A90", Offset = "0x8220890", VA = "0x188221A90")]
	private void FLDBBOJOKMB([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x82223C0", Offset = "0x82211C0", VA = "0x1882223C0")]
	private void GDIIHMFKOPJ([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x821EFA0", Offset = "0x821DDA0", VA = "0x18821EFA0")]
	private void EFGFOCDIGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8228420", Offset = "0x8227220", VA = "0x188228420")]
	private void IBIHIHDKMED(float DHPCFKCANKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8227F70", Offset = "0x8226D70", VA = "0x188227F70")]
	private void HPMNGMMHHAH([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8221800", Offset = "0x8220600", VA = "0x188221800")]
	private void FKOLLIEBHKE(CCPCLKELKAE MNDOCOGGJOE, IKSolverVR.Arm CCOFBBHDHHG, Transform HLMPJNBCKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x821A580", Offset = "0x8219380", VA = "0x18821A580")]
	private void BLDCGDFLJGL(HFOHEOCIICK GKGDEKNIOCH, AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8219510", Offset = "0x8218310", VA = "0x188219510")]
	private void BDGPOLJDAEA(JMEMMAAMOCG NKCFIKICOJE, ELMDBEFEDJJ MNDOCOGGJOE, IKSolverVR.Arm CCOFBBHDHHG, float DCANEBNFLPK, float DHFMNHBDEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8230250", Offset = "0x822F050", VA = "0x188230250")]
	private void OIBFIAICKEA([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x82205F0", Offset = "0x821F3F0", VA = "0x1882205F0")]
	private void FACENAKLMKP([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x822A850", Offset = "0x8229650", VA = "0x18822A850")]
	protected void JKKMDNDAJMO([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x821BD90", Offset = "0x821AB90", VA = "0x18821BD90")]
	private void CKMICCPINFH([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x822B770", Offset = "0x822A570", VA = "0x18822B770")]
	protected void KJHMHACNAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8229980", Offset = "0x8228780", VA = "0x188229980")]
	private void JDCPBCAEHCF([In] HFOHEOCIICK GKGDEKNIOCH, [In] LHKGLELBKPL FGBBFJLMIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x821DE90", Offset = "0x821CC90", VA = "0x18821DE90")]
	private void DDKNAPIHADA(HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8229650", Offset = "0x8228450", VA = "0x188229650")]
	private void IPDCKINLOAA([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8221EB0", Offset = "0x8220CB0", VA = "0x188221EB0")]
	private Vector3 GDHLIJGAAPE([In] HFOHEOCIICK GKGDEKNIOCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x822E060", Offset = "0x822CE60", VA = "0x18822E060")]
	private void NEONGOAMDCI([In] HFOHEOCIICK GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8222F60", Offset = "0x8221D60", VA = "0x188222F60")]
	private float GKEILFCBJKL(float FPGENMIKOCB, [In] HFOHEOCIICK GKGDEKNIOCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x822A700", Offset = "0x8229500", VA = "0x18822A700")]
	private void JJEHNCHAJPC(float FPGENMIKOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x822C360", Offset = "0x822B160", VA = "0x18822C360")]
	private void LFAIDOOLCPD([In] HFOHEOCIICK GKGDEKNIOCH, LHKGLELBKPL FGBBFJLMIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x822ADE0", Offset = "0x8229BE0", VA = "0x18822ADE0")]
	private float KBCJPHBDIKM([In] HFOHEOCIICK ALFGBNABAAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x822E630", Offset = "0x822D430", VA = "0x18822E630")]
	private void NHLMPBDHMLN(HFOHEOCIICK GKGDEKNIOCH, LHKGLELBKPL FGBBFJLMIOK, Vector3 LAKNGFDFFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x822CA50", Offset = "0x822B850", VA = "0x18822CA50")]
	private static void LFHHMECKJHF(Transform DNNOOFELIOA, Quaternion GKEKGHNHKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x822CE90", Offset = "0x822BC90", VA = "0x18822CE90")]
	private void LFKDLHNKHAM([In] HFOHEOCIICK COHHIEKGLGP, [In] CDCJBJIJHIA MECHCLKOPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x821F8F0", Offset = "0x821E6F0", VA = "0x18821F8F0")]
	private void ELCBEAFKDLD([In] HFOHEOCIICK COHHIEKGLGP, [In] CDCJBJIJHIA MECHCLKOPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x821F240", Offset = "0x821E040", VA = "0x18821F240")]
	private void EJKGGCOHIGM(float DFEGCNAEHCF, [In] HFOHEOCIICK ALFGBNABAAJ, float EALADGIOBPF = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8228DE0", Offset = "0x8227BE0", VA = "0x188228DE0")]
	private float INMGBNHNLGD([In] HFOHEOCIICK ALFGBNABAAJ, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x822DD70", Offset = "0x822CB70", VA = "0x18822DD70")]
	private void NEGIIDPNDAJ([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8217F80", Offset = "0x8216D80", VA = "0x188217F80")]
	private void BBMDJKOJLEP([In] HFOHEOCIICK ALFGBNABAAJ, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x822FE80", Offset = "0x822EC80", VA = "0x18822FE80")]
	private void OEHMBPAGPDF([In] HFOHEOCIICK ALFGBNABAAJ, float NGELNAGHBFJ, float JKNNNGBFDMJ, Vector3 CPNPFGOPDFD, float EALADGIOBPF = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x82252F0", Offset = "0x82240F0", VA = "0x1882252F0")]
	private void HGBJKGMBAOL(HFOHEOCIICK ALFGBNABAAJ, AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x822CC00", Offset = "0x822BA00", VA = "0x18822CC00")]
	private void LFIJFNAPEBB(HFOHEOCIICK GKGDEKNIOCH, AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x822A240", Offset = "0x8229040", VA = "0x18822A240")]
	private void JIBKABBOEOA(HFOHEOCIICK ALFGBNABAAJ, AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x822EF20", Offset = "0x822DD20", VA = "0x18822EF20")]
	public void NJLLNBGIKLA([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x821ABE0", Offset = "0x82199E0", VA = "0x18821ABE0")]
	public void BPCBLIDJJHB([In] HFOHEOCIICK GKGDEKNIOCH, [In] AvatarFullBodyConfiguration AFFIHAGMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8228100", Offset = "0x8226F00", VA = "0x188228100")]
	[CompilerGenerated]
	internal static void HPNABGGCPHO(Transform HNLFFLNNKGK, IKSolverVR.Arm CCOFBBHDHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8230460", Offset = "0x822F260", VA = "0x188230460")]
	[CompilerGenerated]
	internal static void OIJJAEGLMKL(Vector3 BHAEDBOOIEB, Vector3 JFJKOCMALCA, PMLBPGKJHIE P_2, BLPFDJHPNPL P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x822D1C0", Offset = "0x822BFC0", VA = "0x18822D1C0")]
	[CompilerGenerated]
	internal static void LMBFPIPDCNC(HFDFMJHPEMP BFHKCNKMPDL, HFDFMJHPEMP JENDOGKJGGO, Vector3 HNFILCPGCNG, float DFOJBJDIKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x82216F0", Offset = "0x82204F0", VA = "0x1882216F0")]
	[CompilerGenerated]
	internal static bool FJGBBKGBEMN(IKSolverVR.Arm CCOFBBHDHHG, EPMLCJGIPDA DAIMEOEHLCC, float HFGFDANGEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x822F430", Offset = "0x822E230", VA = "0x18822F430")]
	[CompilerGenerated]
	internal static float NPEKFJKIPFI(Vector3 GMDBAKLICNJ, Vector3 JNKFOKCBLBN, Vector3 LJLHMJAODDD, HFOHEOCIICK ALFGBNABAAJ, AvatarFullBodyConfiguration AFFIHAGMLBN, float IBOFMHFOKKF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class HDPICPEFNLP : GMAFHHFMILN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Dictionary<string, PPALDFNLNHA> KFJKJLEKLAC;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x823B380", Offset = "0x823A180", VA = "0x18823B380")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void DIKPKPLDDPF(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x823B5A0", Offset = "0x823A3A0", VA = "0x18823B5A0", Slot = "4")]
	public PPALDFNLNHA GHOAJNEEBNM(string HHDDOMDMGOD, AvatarSystemConfiguration NGGDLMFKPOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x823B7C0", Offset = "0x823A5C0", VA = "0x18823B7C0", Slot = "5")]
	public void KHOBKKFKFNK(string HHDDOMDMGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x823B3F0", Offset = "0x823A1F0", VA = "0x18823B3F0", Slot = "6")]
	public string EFAAGMOOKKD(string NCPLECCNPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x823B530", Offset = "0x823A330", VA = "0x18823B530")]
	private string EKMNEBHAHNP(string NCPLECCNPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x823B9A0", Offset = "0x823A7A0", VA = "0x18823B9A0")]
	public HDPICPEFNLP()
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
		public class OIIDNNHNMGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private Dictionary<string, Transform> NDMBLOGEKLK;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool MJLOMDJHNBL
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x8241120", Offset = "0x823FF20", VA = "0x188241120")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8241160", Offset = "0x823FF60", VA = "0x188241160")]
			public void PMCGDNLIPOJ(VRIK HFKBHAGAKGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
			public void ONHAKGNFHPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x82410D0", Offset = "0x823FED0", VA = "0x1882410D0")]
			public void KNFHOLHMALL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8241290", Offset = "0x8240090", VA = "0x188241290")]
			public OIIDNNHNMGI()
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
		[EOAEGKJKCPD(FBMDOBLPJCI.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[LAEBPIHCEIF(FBMDOBLPJCI.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly OIIDNNHNMGI PJJICELNPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IFPMCPKDOOL DNBEODKBOJC;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8236E30", Offset = "0x8235C30", VA = "0x188236E30")]
		private void IEHCJBEIMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8236DE0", Offset = "0x8235BE0", VA = "0x188236DE0")]
		private bool DLGPOAANGBD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8237110", Offset = "0x8235F10", VA = "0x188237110")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8237180", Offset = "0x8235F80", VA = "0x188237180")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8237120", Offset = "0x8235F20", VA = "0x188237120")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x82373F0", Offset = "0x82361F0", VA = "0x1882373F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x823D250", Offset = "0x823C050", VA = "0x18823D250")]
			public (float, float) MLBAJDOLMHD(float LBIMPKPGEAE)
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x823CA80", Offset = "0x823B880", VA = "0x18823CA80")]
			public void MHDKBDCHLCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x823C940", Offset = "0x823B740", VA = "0x18823C940")]
			public (float, float) FHHBLKKJJFG(Animator FDCPCNDGHKB, AnimatorStateInfo ADHOABLAFEC)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
		[Cpp2IlInjected.Address(RVA = "0x823D000", Offset = "0x823BE00", VA = "0x18823D000")]
		public void MHDKBDCHLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x823CB60", Offset = "0x823B960", VA = "0x18823CB60")]
		public (float, float) IEBOKEMDAKL(Animator FDCPCNDGHKB, GFHOPDLHFLM KMEIIKNIOAB, float KDEEMJNIFLK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x823CDA0", Offset = "0x823BBA0", VA = "0x18823CDA0")]
		private (float, float) KINEKIBFPGI(Animator FDCPCNDGHKB, AnimatorStateInfo ADHOABLAFEC, GFHOPDLHFLM KMEIIKNIOAB, float KDEEMJNIFLK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x823D240", Offset = "0x823C040", VA = "0x18823D240")]
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
		[Cpp2IlInjected.Address(RVA = "0x823F620", Offset = "0x823E420", VA = "0x18823F620", Slot = "4")]
		public override void OnStateEnter(Animator FDCPCNDGHKB, AnimatorStateInfo ADHOABLAFEC, int IAGMIKIIKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x823F780", Offset = "0x823E580", VA = "0x18823F780")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class MEEIMBDEBEP<TInput, TOutput> : AKMGAHHABGI<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	protected readonly ODEBHGOALGK NJIBFENKDOM;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x589E410", Offset = "0x589D210", VA = "0x18589E410")]
	protected MEEIMBDEBEP(ODEBHGOALGK NJIBFENKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput PPEAGMPJINO(TInput DANFKLEPBNF, [Out] IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x589E370", Offset = "0x589D170", VA = "0x18589E370", Slot = "5")]
	public bool GNCEBPDNLPL(TInput DANFKLEPBNF, [Out] TOutput? MOBFLOHJOKJ, [Out] IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CMNOLHHFBOP]
public static class DCBFFEKPMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly Regex EBKIEKGKIIL;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8237970", Offset = "0x8236770", VA = "0x188237970")]
	public static OCPPLBMCLHD OOIBJKFGAAO(MDLPHIOGMIH DCAPIGMJMIJ, NGBEPHHOLNP IPHOCHADJIG, Guid? PJJIOIOLAMC, Color? LBBIFCBBKPF, PGMODLDJKOM DPNGCNNOBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8237810", Offset = "0x8236610", VA = "0x188237810")]
	public static EPADPFJDNDI ODBEIFCHHBL(OCPPLBMCLHD KANAIIDGHCH)
	{
		return default(EPADPFJDNDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3B4FA50", Offset = "0x3B4E850", VA = "0x183B4FA50")]
	internal static TModern? FINPFCOEGGD<TModern>(string? DANFKLEPBNF, BMGIGODMMEP<TModern> JAOGLOBMJMK, ODEBHGOALGK NJIBFENKDOM, AGACCECBKLA KMAOIHBOBLI, TModern JFGKOGNGCHM) where TModern : struct, CCCADGGIHHO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3B510A0", Offset = "0x3B4FEA0", VA = "0x183B510A0")]
	internal static EOKKFPLHEKO ICFDKJBHHGC<TModern>(string? DANFKLEPBNF, BMGIGODMMEP<TModern> JAOGLOBMJMK, ODEBHGOALGK NJIBFENKDOM, AGACCECBKLA KMAOIHBOBLI, TModern JFGKOGNGCHM) where TModern : struct, CCCADGGIHHO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x82376D0", Offset = "0x82364D0", VA = "0x1882376D0")]
	internal static List<ECJGOBMDJGD> BNAKPHHBPFG(IEnumerable<MAAJLACIBNH>? IDCBPNENJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3B51810", Offset = "0x3B50610", VA = "0x183B51810")]
	internal static string JFDPJLHIHEB<TModern>(TModern DANFKLEPBNF, BMGIGODMMEP<TModern> JAOGLOBMJMK, ODEBHGOALGK NJIBFENKDOM) where TModern : CCCADGGIHHO
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class ABEPDHIHGJP : NFOPFCKFBPO
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AKMGAHHABGI<JOPDFCKLKOH, BNICAFPKAPB> IADAEDJCOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AKMGAHHABGI<DBKPFJPOFHC, CLOGEGKIKOE> BKIEANGPHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AKMGAHHABGI<DBKPFJPOFHC, CLOGEGKIKOE> NGAJAONALBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CFNJKMGMBPJ IJCEPLGPGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DIHMJMIIILJ OAHKMMGAEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8235E40", Offset = "0x8234C40", VA = "0x188235E40")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	[UsedImplicitly]
	internal static void HGDPONKELKJ(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8235EB0", Offset = "0x8234CB0", VA = "0x188235EB0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ABEPDHIHGJP([POMNKOCGGBN("UnitySerialization")] BGIGELOGNGN HPPBNHBPFKO, [POMNKOCGGBN(null)] NHIJPMINOCB LJIELAOKOPG, [POMNKOCGGBN(null)] ODEBHGOALGK NJIBFENKDOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum FFIABCKOKKG
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
public class PBADLMBIKCE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8241350", Offset = "0x8240150", VA = "0x188241350")]
	public PBADLMBIKCE(string JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8241380", Offset = "0x8240180", VA = "0x188241380")]
	public PBADLMBIKCE(string JDFCBBCKOGJ, Exception HDEBIKIKFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8241320", Offset = "0x8240120", VA = "0x188241320")]
	public PBADLMBIKCE(FFIABCKOKKG OIBEBELDBPO, string JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x82413B0", Offset = "0x82401B0", VA = "0x1882413B0")]
	public PBADLMBIKCE(FFIABCKOKKG OIBEBELDBPO, string JDFCBBCKOGJ, Exception HDEBIKIKFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class NKBBFEDJHGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly BGIGELOGNGN HPPBNHBPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected readonly NHIJPMINOCB LJIELAOKOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	protected readonly ODEBHGOALGK NJIBFENKDOM;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8238310", Offset = "0x8237110", VA = "0x188238310")]
	protected NKBBFEDJHGF(BGIGELOGNGN HPPBNHBPFKO, NHIJPMINOCB LJIELAOKOPG, ODEBHGOALGK NJIBFENKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x823FAD0", Offset = "0x823E8D0", VA = "0x18823FAD0")]
	protected string NIKKHFPLEDC(BNICAFPKAPB HHPKINNPBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x823F7A0", Offset = "0x823E5A0", VA = "0x18823F7A0")]
	protected string GNJECFICLKN(BNICAFPKAPB HHPKINNPBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8240DA0", Offset = "0x823FBA0", VA = "0x188240DA0")]
	private AvatarOutfitSelectionData OOIBJKFGAAO(OCPPLBMCLHD FMEHFHOHHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x823F990", Offset = "0x823E790", VA = "0x18823F990")]
	private static AvatarCustomizationSettingsData.AnchorParams MKHNDHIALOF(NODDIPDIFHA? AFCCIGJCPCP)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AKMGAHHABGI<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput PPEAGMPJINO(TInput DANFKLEPBNF, [Out] IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNCEBPDNLPL(TInput DANFKLEPBNF, [Out] TOutput? MOBFLOHJOKJ, [Out] IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NFOPFCKFBPO
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	AKMGAHHABGI<JOPDFCKLKOH, BNICAFPKAPB> IADAEDJCOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AKMGAHHABGI<DBKPFJPOFHC, CLOGEGKIKOE> NGAJAONALBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	CFNJKMGMBPJ IJCEPLGPGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum AGACCECBKLA
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DIHMJMIIILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IGLMKMBJILH OFACCHGGJAP(BNICAFPKAPB KANAIIDGHCH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CFNJKMGMBPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBKPFJPOFHC OFACCHGGJAP(BNICAFPKAPB KANAIIDGHCH, int HPEFGPPMOIE, string? PFLDDMDPCBI, string? IIHGKMIFHHF, IHPKKIOOIAO FHOECEOGNGE, List<ECJGOBMDJGD>? MHOHKDCDHOE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[CMNOLHHFBOP]
internal class IJPJLBNLKPG : MEEIMBDEBEP<JOPDFCKLKOH, BNICAFPKAPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly NHIJPMINOCB LJIELAOKOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly GPFBMJNGCFJ EPLOLPGADIH;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x823D5B0", Offset = "0x823C3B0", VA = "0x18823D5B0")]
	public IJPJLBNLKPG(BGIGELOGNGN HPPBNHBPFKO, NHIJPMINOCB LJIELAOKOPG, ODEBHGOALGK NJIBFENKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x823D310", Offset = "0x823C110", VA = "0x18823D310", Slot = "6")]
	public override BNICAFPKAPB PPEAGMPJINO(JOPDFCKLKOH DANFKLEPBNF, [Out] IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class HLLALFNANNI : BGIGELOGNGN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class CAMEGEEBBFB : JsonConverter<EOKKFPLHEKO>
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x82375F0", Offset = "0x82363F0", VA = "0x1882375F0", Slot = "9")]
		public override void WriteJson(JsonWriter AOOOLDFNADH, EOKKFPLHEKO? HGMAIPELJHM, JsonSerializer OJPPMHCIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x82374D0", Offset = "0x82362D0", VA = "0x1882374D0", Slot = "10")]
		public override EOKKFPLHEKO ReadJson(JsonReader CCOEJPOOOPD, Type GNGCPFDIMFH, EOKKFPLHEKO? KHKPDNBCFEG, bool AJEHEOMPLFN, JsonSerializer OJPPMHCIDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8237690", Offset = "0x8236490", VA = "0x188237690")]
		public CAMEGEEBBFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class GNMNNAPKFGA : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool PBGMMPKCNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8238CE0", Offset = "0x8237AE0", VA = "0x188238CE0", Slot = "5")]
		public override object ReadJson(JsonReader CCOEJPOOOPD, Type GNGCPFDIMFH, object? KHKPDNBCFEG, JsonSerializer OJPPMHCIDCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8238B00", Offset = "0x8237900", VA = "0x188238B00", Slot = "6")]
		public override bool CanConvert(Type GNGCPFDIMFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8238D40", Offset = "0x8237B40", VA = "0x188238D40", Slot = "4")]
		public override void WriteJson(JsonWriter AOOOLDFNADH, object? HGMAIPELJHM, JsonSerializer OJPPMHCIDCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8238920", Offset = "0x8237720", VA = "0x188238920")]
		private static bool AOOIMJOOKHM(object HGMAIPELJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public GNMNNAPKFGA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly JsonSerializerSettings KOEIEIJLGHF;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x823C7E0", Offset = "0x823B5E0", VA = "0x18823C7E0")]
	internal HLLALFNANNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3D29EC0", Offset = "0x3D28CC0", VA = "0x183D29EC0", Slot = "4")]
	public string IGBDHMNAJEE<T>(T ALGAKMGCCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3D29F20", Offset = "0x3D28D20", VA = "0x183D29F20", Slot = "5")]
	public T OMGCHLEDHKE<T>(string HGMAIPELJHM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class JEIDMIJBGED : BGIGELOGNGN
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3D69B10", Offset = "0x3D68910", VA = "0x183D69B10", Slot = "4")]
	public string IGBDHMNAJEE<T>(T ALGAKMGCCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3D69B70", Offset = "0x3D68970", VA = "0x183D69B70", Slot = "5")]
	public T OMGCHLEDHKE<T>(string HGMAIPELJHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JEIDMIJBGED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[CMNOLHHFBOP]
internal class GPFBMJNGCFJ : MEEIMBDEBEP<DBKPFJPOFHC, CLOGEGKIKOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly BGIGELOGNGN HPPBNHBPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly NHIJPMINOCB LJIELAOKOPG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x823B240", Offset = "0x823A040", VA = "0x18823B240")]
	public GPFBMJNGCFJ(BGIGELOGNGN HPPBNHBPFKO, NHIJPMINOCB LJIELAOKOPG, ODEBHGOALGK NJIBFENKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x823AE20", Offset = "0x8239C20", VA = "0x18823AE20", Slot = "6")]
	public override CLOGEGKIKOE PPEAGMPJINO(DBKPFJPOFHC DANFKLEPBNF, [Out] IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x823A570", Offset = "0x8239370", VA = "0x18823A570")]
	internal void NANPGBPDKLD(string AFKLAOKOGBI, BNICAFPKAPB HHPKINNPBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x823AD70", Offset = "0x8239B70", VA = "0x18823AD70")]
	public IEnumerable<OCPPLBMCLHD> PDOMCDKLFMK(string JABDHEAPLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8239AF0", Offset = "0x82388F0", VA = "0x188239AF0")]
	private IEnumerable<OCPPLBMCLHD> FCPPGONKKMJ(string JABDHEAPLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x82396A0", Offset = "0x82384A0", VA = "0x1882396A0")]
	internal IEnumerable<OCPPLBMCLHD> ELBCLLAAOGC(string JABDHEAPLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x823A9F0", Offset = "0x82397F0", VA = "0x18823A9F0")]
	private OCPPLBMCLHD NMCDCFKHLLD(AvatarOutfitSelectionData KMBBFDEKAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8238E20", Offset = "0x8237C20", VA = "0x188238E20")]
	private void ABHNIOIPIIF(AvatarCustomizationSettingsData NPLHABBEPJM, BNICAFPKAPB HHPKINNPBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x823A6D0", Offset = "0x82394D0", VA = "0x18823A6D0")]
	private OCPPLBMCLHD NMCDCFKHLLD(string KPINNMLHCCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8239F10", Offset = "0x8238D10", VA = "0x188239F10")]
	internal static (PGMODLDJKOM, string, string) IAOHCLNLBOK(string KPINNMLHCCE, ODEBHGOALGK NJIBFENKDOM)
	{
		return default((PGMODLDJKOM, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x823A370", Offset = "0x8239170", VA = "0x18823A370")]
	private NCGKAGAAIBB? JFMPOGGABBB(string? NMEMPCKPCOG, Vector2 HHEEJOFPFBC, float LEBBGIACMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x823A210", Offset = "0x8239010", VA = "0x18823A210")]
	private static NODDIPDIFHA IAPCIKPAINB(AvatarCustomizationSettingsData.AnchorParams FCEHCNFMEMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CMNOLHHFBOP]
internal class DJFCBAAJAGI : NKBBFEDJHGF, DIHMJMIIILJ
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8238310", Offset = "0x8237110", VA = "0x188238310")]
	public DJFCBAAJAGI(BGIGELOGNGN HPPBNHBPFKO, NHIJPMINOCB LJIELAOKOPG, ODEBHGOALGK NJIBFENKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8237F60", Offset = "0x8236D60", VA = "0x188237F60", Slot = "4")]
	public IGLMKMBJILH OFACCHGGJAP(BNICAFPKAPB KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8237C20", Offset = "0x8236A20", VA = "0x188237C20")]
	private string AFCFJEDFKKO(BNICAFPKAPB HHPKINNPBPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8237D20", Offset = "0x8236B20", VA = "0x188237D20")]
	private string LPMBLANEAGD(OCPPLBMCLHD FMEHFHOHHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CMNOLHHFBOP]
internal class KFJPCIKAOOH : MEEIMBDEBEP<DBKPFJPOFHC, CLOGEGKIKOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly BGIGELOGNGN HPPBNHBPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly AKMGAHHABGI<DBKPFJPOFHC, CLOGEGKIKOE> OLCJAJPDMFP;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x823DBB0", Offset = "0x823C9B0", VA = "0x18823DBB0")]
	public KFJPCIKAOOH(AKMGAHHABGI<DBKPFJPOFHC, CLOGEGKIKOE> OLCJAJPDMFP, ODEBHGOALGK NJIBFENKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x823D780", Offset = "0x823C580", VA = "0x18823D780", Slot = "6")]
	public override CLOGEGKIKOE PPEAGMPJINO(DBKPFJPOFHC DANFKLEPBNF, [Out] IReadOnlyList<ECJGOBMDJGD>? MHOHKDCDHOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[CMNOLHHFBOP]
internal class FBDEHHKJFJE : CFNJKMGMBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly BGIGELOGNGN HPPBNHBPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly DIHMJMIIILJ NEDPFHMMONA;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8238830", Offset = "0x8237630", VA = "0x188238830")]
	public FBDEHHKJFJE(DIHMJMIIILJ NEDPFHMMONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8238490", Offset = "0x8237290", VA = "0x188238490", Slot = "4")]
	public DBKPFJPOFHC OFACCHGGJAP(BNICAFPKAPB KANAIIDGHCH, int HPEFGPPMOIE, string? PFLDDMDPCBI, string? IIHGKMIFHHF, IHPKKIOOIAO FHOECEOGNGE, List<ECJGOBMDJGD>? MHOHKDCDHOE)
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
		[Cpp2IlInjected.Address(RVA = "0x82364C0", Offset = "0x82352C0", VA = "0x1882364C0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LJNCMAHJKCL
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x823DE30", Offset = "0x823CC30", VA = "0x18823DE30")]
	public static EPADPFJDNDI PPEAGMPJINO(this GFKOOLBOBCC KANAIIDGHCH)
	{
		return default(EPADPFJDNDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x823DD10", Offset = "0x823CB10", VA = "0x18823DD10")]
	public static GFKOOLBOBCC OFACCHGGJAP(this EPADPFJDNDI BMINCCFLNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x823DCB0", Offset = "0x823CAB0", VA = "0x18823DCB0")]
	public static bool BGCOJNAOFND(this EPADPFJDNDI BMINCCFLNLD)
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
			[Cpp2IlInjected.Address(RVA = "0x6255F20", Offset = "0x6254D20", VA = "0x186255F20")]
			public AnchorParams(Vector2 CMKLLLHMFJO, Vector3 ONNFGDICHKJ, Vector3 BFKIALLDNGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8236410", Offset = "0x8235210", VA = "0x188236410")]
			internal NODDIPDIFHA OFACCHGGJAP()
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
		private NLCKMDLDBJL useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x8236CB0", Offset = "0x8235AB0", VA = "0x188236CB0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x188ED50", Offset = "0x188DB50", VA = "0x18188ED50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x10948F0", Offset = "0x10936F0", VA = "0x1810948F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x15A1790", Offset = "0x15A0590", VA = "0x1815A1790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8236D50", Offset = "0x8235B50", VA = "0x188236D50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA2020", Offset = "0xAA0E20", VA = "0x180AA2020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xD5B910", Offset = "0xD5A710", VA = "0x180D5B910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD5BD60", Offset = "0xD5AB60", VA = "0x180D5BD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x29EF9D0", Offset = "0x29EE7D0", VA = "0x1829EF9D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xFBCE50", Offset = "0xFBBC50", VA = "0x180FBCE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1284C70", Offset = "0x1283A70", VA = "0x181284C70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1A49CD0", Offset = "0x1A48AD0", VA = "0x181A49CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA931B0", Offset = "0xA91FB0", VA = "0x180A931B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA931E0", Offset = "0xA91FE0", VA = "0x180A931E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x25D2040", Offset = "0x25D0E40", VA = "0x1825D2040")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xFD3260", Offset = "0xFD2060", VA = "0x180FD3260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xACBD40", Offset = "0xACAB40", VA = "0x180ACBD40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xACBDA0", Offset = "0xACABA0", VA = "0x180ACBDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA9EEB0", Offset = "0xA9DCB0", VA = "0x180A9EEB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA9EE90", Offset = "0xA9DC90", VA = "0x180A9EE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA9EE70", Offset = "0xA9DC70", VA = "0x180A9EE70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA9EDA0", Offset = "0xA9DBA0", VA = "0x180A9EDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA9EEE0", Offset = "0xA9DCE0", VA = "0x180A9EEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA9EDF0", Offset = "0xA9DBF0", VA = "0x180A9EDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB1E590", Offset = "0xB1D390", VA = "0x180B1E590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB633E0", Offset = "0xB621E0", VA = "0x180B633E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA9EE60", Offset = "0xA9DC60", VA = "0x180A9EE60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA9EE40", Offset = "0xA9DC40", VA = "0x180A9EE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB631C0", Offset = "0xB61FC0", VA = "0x180B631C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB635F0", Offset = "0xB623F0", VA = "0x180B635F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3060", Offset = "0xAA1E60", VA = "0x180AA3060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA1F20", VA = "0x180AA3120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB631D0", Offset = "0xB61FD0", VA = "0x180B631D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xB633B0", Offset = "0xB621B0", VA = "0x180B633B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xE03D40", Offset = "0xE02B40", VA = "0x180E03D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xDFFD90", Offset = "0xDFEB90", VA = "0x180DFFD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public NLCKMDLDBJL UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x10B1060", Offset = "0x10AFE60", VA = "0x1810B1060")]
			get
			{
				return default(NLCKMDLDBJL);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x10B1BF0", Offset = "0x10B09F0", VA = "0x1810B1BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x10B1A80", Offset = "0x10B0880", VA = "0x1810B1A80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xD4E100", Offset = "0xD4CF00", VA = "0x180D4E100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x8236D70", Offset = "0x8235B70", VA = "0x188236D70")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8236D90", Offset = "0x8235B90", VA = "0x188236D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8236950", Offset = "0x8235750", VA = "0x188236950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
		public PGMODLDJKOM BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private IEEPKIHFMCL? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8236DB0", Offset = "0x8235BB0", VA = "0x188236DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
