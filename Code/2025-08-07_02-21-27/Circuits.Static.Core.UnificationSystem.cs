using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Core.UnificationSystem.Reference;
using Circuits.Static.Core.UnificationSystem.Value;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Circuits.Static.Core.UnificationSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal enum ApplyConstraintResultKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Constraints,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		NoOp,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Substitution
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface MQMDYMTPLDL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates LVOSKEQMYKA(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class QUFGXHZWYWW
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2E026B0", Offset = "0x2E012B0", VA = "0x182E026B0")]
		public static Id32<QNJVCBQUPRU> HLPRXJXQQMK(this int a)
		{
			return default(Id32<QNJVCBQUPRU>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class QNJVCBQUPRU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class XNAGZWCCDLF : UTITDXZLKVK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2E028A0", Offset = "0x2E014A0", VA = "0x182E028A0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2E028D0", Offset = "0x2E014D0", VA = "0x182E028D0")]
		public XNAGZWCCDLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum TermKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Identifier,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Arrow
	}
}
namespace Circuits.Static.Core.UnificationSystem.Value
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal readonly struct ApplyConstraintResult
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public readonly struct ApplyConstraintResultImpl
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly (Constraint First, Constraint Second) Constraints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly Substitution Substitution;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2E01520", Offset = "0x2E00120", VA = "0x182E01520")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2E01590", Offset = "0x2E00190", VA = "0x182E01590")]
			public ApplyConstraintResultImpl([In] Substitution substitution)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly ApplyConstraintResultImpl Impl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly ApplyConstraintResultKind Kind;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2E016B0", Offset = "0x2E002B0", VA = "0x182E016B0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2E015F0", Offset = "0x2E001F0", VA = "0x182E015F0")]
		public static ApplyConstraintResult SPGRRNAMKHZ([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2E01680", Offset = "0x2E00280", VA = "0x182E01680")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2E015A0", Offset = "0x2E001A0", VA = "0x182E015A0")]
		public static ApplyConstraintResult ELKJPBUNTUI([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2E01670", Offset = "0x2E00270", VA = "0x182E01670")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2E015D0", Offset = "0x2E001D0", VA = "0x182E015D0")]
		public static ApplyConstraintResult JTOXHWYAGIJ()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<QNJVCBQUPRU> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<QNJVCBQUPRU> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		private Arrow(Id32<QNJVCBQUPRU> from, Id32<QNJVCBQUPRU> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE26A0", Offset = "0x2DE12A0", VA = "0x182DE26A0")]
		public static Arrow New(Id32<QNJVCBQUPRU> from, Id32<QNJVCBQUPRU> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2E01730", Offset = "0x2E00330", VA = "0x182E01730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal readonly struct Constraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly Id32<QNJVCBQUPRU> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<QNJVCBQUPRU> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		private Constraint(Id32<QNJVCBQUPRU> lhs, Id32<QNJVCBQUPRU> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DE26A0", Offset = "0x2DE12A0", VA = "0x182DE26A0")]
		public static Constraint New(Id32<QNJVCBQUPRU> lhs, Id32<QNJVCBQUPRU> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2E017C0", Offset = "0x2E003C0", VA = "0x182E017C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class ECHLNBADZYF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2E01850", Offset = "0x2E00450", VA = "0x182E01850")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<QNJVCBQUPRU, Term> terms, Id32<QNJVCBQUPRU>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<QNJVCBQUPRU> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<QNJVCBQUPRU> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		private Substitution(Id32<QNJVCBQUPRU> identifier, Id32<QNJVCBQUPRU> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2DE26A0", Offset = "0x2DE12A0", VA = "0x182DE26A0")]
		public static Substitution New(Id32<QNJVCBQUPRU> identifier, Id32<QNJVCBQUPRU> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2E026F0", Offset = "0x2E012F0", VA = "0x182E026F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct Term
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public readonly struct TermImpl
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly Arrow Arrow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Id32<QNJVCBQUPRU> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2E02780", Offset = "0x2E01380", VA = "0x182E02780")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2E02790", Offset = "0x2E01390", VA = "0x182E02790")]
			public TermImpl(Id32<QNJVCBQUPRU> identifier)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly TermImpl Impl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly TermKind Kind;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2E02890", Offset = "0x2E01490", VA = "0x182E02890")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2E027A0", Offset = "0x2E013A0", VA = "0x182E027A0")]
		public static Term QQRJKEVAZJM([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2E02870", Offset = "0x2E01470", VA = "0x182E02870")]
		private Term(Id32<QNJVCBQUPRU> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2E027C0", Offset = "0x2E013C0", VA = "0x182E027C0")]
		public static Term RICNYTVWRYW(Id32<QNJVCBQUPRU> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2E027E0", Offset = "0x2E013E0", VA = "0x182E027E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class BRJRFCKGQRA<a, b> where b : MQMDYMTPLDL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<QNJVCBQUPRU, Term> UGWOTGRLWKY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<QNJVCBQUPRU>[] BDIXTCQIYPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<QNJVCBQUPRU, bool> OYINITGCASL;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x447F6F0", Offset = "0x447E2F0", VA = "0x18447F6F0")]
			internal Result<LBDQRSHFOFV, UTITDXZLKVK> SIZGZBAYQLR(Substitution a)
			{
				return default(Result<LBDQRSHFOFV, UTITDXZLKVK>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> DJTSENUEWUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> SIYFRLXVRNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b KOIFGESKYOE;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x77C4B90", Offset = "0x77C3790", VA = "0x1877C4B90")]
		protected BRJRFCKGQRA([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77C2AF0", Offset = "0x77C16F0", VA = "0x1877C2AF0")]
		public static BRJRFCKGQRA<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77C2D30", Offset = "0x77C1930", VA = "0x1877C2D30")]
		public Id32<QNJVCBQUPRU> QQREJJITUPZ()
		{
			return default(Id32<QNJVCBQUPRU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x77C27B0", Offset = "0x77C13B0", VA = "0x1877C27B0")]
		public Id32<QNJVCBQUPRU> GHGMQUZXMCK(Id32<QNJVCBQUPRU> a, Id32<QNJVCBQUPRU> b)
		{
			return default(Id32<QNJVCBQUPRU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC2A140", Offset = "0xC28D40", VA = "0x180C2A140")]
		public Id32<QNJVCBQUPRU> FLGTGZRUBMC(Id32<QNJVCBQUPRU> a)
		{
			return default(Id32<QNJVCBQUPRU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77C4890", Offset = "0x77C3490", VA = "0x1877C4890")]
		public void UUXOONAFRXI(Id32<QNJVCBQUPRU> a, Id32<QNJVCBQUPRU> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x77C4090", Offset = "0x77C2C90", VA = "0x1877C4090")]
		public Result<LBDQRSHFOFV[], UTITDXZLKVK> Solve([In] a root)
		{
			return default(Result<LBDQRSHFOFV[], UTITDXZLKVK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A30", Offset = "0x77C1630", VA = "0x1877C2A30")]
		public NVTBIKAOMDA JITVHMGCZEL(Id32<QNJVCBQUPRU> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class GUIIUWURVNG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01A10", Offset = "0x2E00610", VA = "0x182E01A10")]
		internal static Term CSAGFZCIMGR(Id32<QNJVCBQUPRU> a, IdArray<QNJVCBQUPRU, Term> b, Id32<QNJVCBQUPRU>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface NVTBIKAOMDA : IEquatable<NVTBIKAOMDA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind IXVPXZPOTQH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<QNJVCBQUPRU> QFVCNIGJOID
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		NVTBIKAOMDA ILWVYQTHYXU
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NVTBIKAOMDA OSVHDYGNYOX
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class OQOAJKMMATJ : NVTBIKAOMDA, IEquatable<NVTBIKAOMDA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly NVTBIKAOMDA HBCUPFSPXWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly NVTBIKAOMDA ZOPHHWVKNIQ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind IXVPXZPOTQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<QNJVCBQUPRU> GIVIVYYDJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2E02530", Offset = "0x2E01130", VA = "0x182E02530", Slot = "5")]
			get
			{
				return default(Id32<QNJVCBQUPRU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private NVTBIKAOMDA YWZEVBKYZMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NVTBIKAOMDA AWCBOZQLJDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		private OQOAJKMMATJ(NVTBIKAOMDA a, NVTBIKAOMDA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2E02580", Offset = "0x2E01180", VA = "0x182E02580")]
		public static OQOAJKMMATJ New(NVTBIKAOMDA from, NVTBIKAOMDA to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2E023B0", Offset = "0x2E00FB0", VA = "0x182E023B0", Slot = "8")]
		public bool Equals(NVTBIKAOMDA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2E02600", Offset = "0x2E01200", VA = "0x182E02600", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class HRYRWJPDADT : NVTBIKAOMDA, IEquatable<NVTBIKAOMDA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<QNJVCBQUPRU> ZSNEVPBDVJU;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind IXVPXZPOTQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<QNJVCBQUPRU> GIVIVYYDJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110", Slot = "5")]
			get
			{
				return default(Id32<QNJVCBQUPRU>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private NVTBIKAOMDA YWZEVBKYZMR
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2E01D90", Offset = "0x2E00990", VA = "0x182E01D90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private NVTBIKAOMDA AWCBOZQLJDC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2E01DE0", Offset = "0x2E009E0", VA = "0x182E01DE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x11E9470", Offset = "0x11E8070", VA = "0x1811E9470")]
		private HRYRWJPDADT(Id32<QNJVCBQUPRU> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2E01D30", Offset = "0x2E00930", VA = "0x182E01D30")]
		public static HRYRWJPDADT New(Id32<QNJVCBQUPRU> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00810", VA = "0x182E01C10", Slot = "8")]
		public bool Equals(NVTBIKAOMDA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2E01E30", Offset = "0x2E00A30", VA = "0x182E01E30", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class LBDQRSHFOFV
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<QNJVCBQUPRU> AXUVQJAOTPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QNJVCBQUPRU>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public NVTBIKAOMDA ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1155AA0", Offset = "0x11546A0", VA = "0x181155AA0")]
		private LBDQRSHFOFV(Id32<QNJVCBQUPRU> a, NVTBIKAOMDA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2E02180", Offset = "0x2E00D80", VA = "0x182E02180")]
		public static Result<LBDQRSHFOFV, UTITDXZLKVK> MVBQEXAFRFZ([In] Substitution substitution, IdArray<QNJVCBQUPRU, Term> a, Id32<QNJVCBQUPRU>[] b, IdArray<QNJVCBQUPRU, bool> c)
		{
			return default(Result<LBDQRSHFOFV, UTITDXZLKVK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2E01E70", Offset = "0x2E00A70", VA = "0x182E01E70")]
		private static Result<NVTBIKAOMDA, UTITDXZLKVK> FGNORYIOSTX(Id32<QNJVCBQUPRU> a, IdArray<QNJVCBQUPRU, Term> b, Id32<QNJVCBQUPRU>[] c, IdArray<QNJVCBQUPRU, bool> d)
		{
			return default(Result<NVTBIKAOMDA, UTITDXZLKVK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2E02340", Offset = "0x2E00F40", VA = "0x182E02340", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
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
