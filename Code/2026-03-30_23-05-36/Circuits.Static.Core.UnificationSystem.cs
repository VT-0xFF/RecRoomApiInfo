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
	public interface ZSLKVIHDTZQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates TWTWQUSDYXX(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ORFDXBOITGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2966E60", Offset = "0x2965C60", VA = "0x182966E60")]
		public static Id32<FUOQNRHVAEF> QHVDNMCPKIX(this int a)
		{
			return default(Id32<FUOQNRHVAEF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class FUOQNRHVAEF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ZHHMMSJCAMW : GAJLSRYNUUX
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2967050", Offset = "0x2965E50", VA = "0x182967050", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2967080", Offset = "0x2965E80", VA = "0x182967080")]
		public ZHHMMSJCAMW()
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
			[Cpp2IlInjected.Address(RVA = "0x2965CD0", Offset = "0x2964AD0", VA = "0x182965CD0")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2965D40", Offset = "0x2964B40", VA = "0x182965D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2965E60", Offset = "0x2964C60", VA = "0x182965E60")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2965D80", Offset = "0x2964B80", VA = "0x182965D80")]
		public static ApplyConstraintResult QSCLKVCRXKC([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2965E30", Offset = "0x2964C30", VA = "0x182965E30")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2965D50", Offset = "0x2964B50", VA = "0x182965D50")]
		public static ApplyConstraintResult PRGSRISXCNZ([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2965E20", Offset = "0x2964C20", VA = "0x182965E20")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2965E00", Offset = "0x2964C00", VA = "0x182965E00")]
		public static ApplyConstraintResult RKBNBGURCPE()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<FUOQNRHVAEF> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<FUOQNRHVAEF> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
		private Arrow(Id32<FUOQNRHVAEF> from, Id32<FUOQNRHVAEF> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x294A440", Offset = "0x2949240", VA = "0x18294A440")]
		public static Arrow New(Id32<FUOQNRHVAEF> from, Id32<FUOQNRHVAEF> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2965EE0", Offset = "0x2964CE0", VA = "0x182965EE0", Slot = "3")]
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
		public readonly Id32<FUOQNRHVAEF> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<FUOQNRHVAEF> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
		private Constraint(Id32<FUOQNRHVAEF> lhs, Id32<FUOQNRHVAEF> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x294A440", Offset = "0x2949240", VA = "0x18294A440")]
		public static Constraint New(Id32<FUOQNRHVAEF> lhs, Id32<FUOQNRHVAEF> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2966430", Offset = "0x2965230", VA = "0x182966430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class BDPZSZPPQNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2965F70", Offset = "0x2964D70", VA = "0x182965F70")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<FUOQNRHVAEF, Term> terms, Id32<FUOQNRHVAEF>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<FUOQNRHVAEF> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<FUOQNRHVAEF> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC90B80", Offset = "0xC8F980", VA = "0x180C90B80")]
		private Substitution(Id32<FUOQNRHVAEF> identifier, Id32<FUOQNRHVAEF> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x294A440", Offset = "0x2949240", VA = "0x18294A440")]
		public static Substitution New(Id32<FUOQNRHVAEF> identifier, Id32<FUOQNRHVAEF> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2966EA0", Offset = "0x2965CA0", VA = "0x182966EA0", Slot = "3")]
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
			public readonly Id32<FUOQNRHVAEF> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2966F30", Offset = "0x2965D30", VA = "0x182966F30")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2966F40", Offset = "0x2965D40", VA = "0x182966F40")]
			public TermImpl(Id32<FUOQNRHVAEF> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2967040", Offset = "0x2965E40", VA = "0x182967040")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2966F70", Offset = "0x2965D70", VA = "0x182966F70")]
		public static Term SVOQQYESQHF([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2967020", Offset = "0x2965E20", VA = "0x182967020")]
		private Term(Id32<FUOQNRHVAEF> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2966F50", Offset = "0x2965D50", VA = "0x182966F50")]
		public static Term DCIHEDOBQBT(Id32<FUOQNRHVAEF> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2966F90", Offset = "0x2965D90", VA = "0x182966F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ISPNYCRLLHL<a, b> where b : ZSLKVIHDTZQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DRLFUGSKICJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<FUOQNRHVAEF, Term> UFGSKCBBTDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<FUOQNRHVAEF>[] JWFSSLGNQUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<FUOQNRHVAEF, bool> ZAZGIUSFBSM;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public DRLFUGSKICJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4198330", Offset = "0x4197130", VA = "0x184198330")]
			internal Result<JUTCXVUDHEU, GAJLSRYNUUX> MZQKHILQMDK(Substitution a)
			{
				return default(Result<JUTCXVUDHEU, GAJLSRYNUUX>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> TQUYGBACNKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> KJKWIUVOLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b PDDKCLIEEXJ;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5113090", Offset = "0x5111E90", VA = "0x185113090")]
		protected ISPNYCRLLHL([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5111760", Offset = "0x5110560", VA = "0x185111760")]
		public static ISPNYCRLLHL<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5112DC0", Offset = "0x5111BC0", VA = "0x185112DC0")]
		public Id32<FUOQNRHVAEF> YQUVINSVRVC()
		{
			return default(Id32<FUOQNRHVAEF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5112B10", Offset = "0x5111910", VA = "0x185112B10")]
		public Id32<FUOQNRHVAEF> WBPPEYIBXTP(Id32<FUOQNRHVAEF> a, Id32<FUOQNRHVAEF> b)
		{
			return default(Id32<FUOQNRHVAEF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB2C810", Offset = "0xB2B610", VA = "0x180B2C810")]
		public Id32<FUOQNRHVAEF> FKHZXZJRGUD(Id32<FUOQNRHVAEF> a)
		{
			return default(Id32<FUOQNRHVAEF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5111640", Offset = "0x5110440", VA = "0x185111640")]
		public void ITYPOWGXORV(Id32<FUOQNRHVAEF> a, Id32<FUOQNRHVAEF> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5111950", Offset = "0x5110750", VA = "0x185111950")]
		public Result<JUTCXVUDHEU[], GAJLSRYNUUX> Solve([In] a root)
		{
			return default(Result<JUTCXVUDHEU[], GAJLSRYNUUX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5111750", Offset = "0x5110550", VA = "0x185111750")]
		public SBSDUOTZRVD LTSHAXQWUWC(Id32<FUOQNRHVAEF> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class NRATAUOOHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2966A00", Offset = "0x2965800", VA = "0x182966A00")]
		internal static Term SWNZWCTKKAG(Id32<FUOQNRHVAEF> a, IdArray<FUOQNRHVAEF, Term> b, Id32<FUOQNRHVAEF>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface SBSDUOTZRVD : IEquatable<SBSDUOTZRVD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind SSNBWZUXQFA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<FUOQNRHVAEF> TGNRRVDUPCW
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		SBSDUOTZRVD MSTJMMJYLEV
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		SBSDUOTZRVD WGXVQPGWHTG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class BOLTYYWFJOO : SBSDUOTZRVD, IEquatable<SBSDUOTZRVD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly SBSDUOTZRVD VTVENKNJTNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly SBSDUOTZRVD ZIMZTFFZMUR;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind SSNBWZUXQFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<FUOQNRHVAEF> XYBXYVYQXIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x29662B0", Offset = "0x29650B0", VA = "0x1829662B0", Slot = "5")]
			get
			{
				return default(Id32<FUOQNRHVAEF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private SBSDUOTZRVD FKRMYWKCJTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private SBSDUOTZRVD LNRWQWQEPQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAD31B0", Offset = "0xAD1FB0", VA = "0x180AD31B0")]
		private BOLTYYWFJOO(SBSDUOTZRVD a, SBSDUOTZRVD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2966300", Offset = "0x2965100", VA = "0x182966300")]
		public static BOLTYYWFJOO New(SBSDUOTZRVD from, SBSDUOTZRVD to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2966130", Offset = "0x2964F30", VA = "0x182966130", Slot = "8")]
		public bool Equals(SBSDUOTZRVD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2966380", Offset = "0x2965180", VA = "0x182966380", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class OEVVXJRHXTM : SBSDUOTZRVD, IEquatable<SBSDUOTZRVD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<FUOQNRHVAEF> JMWYIQGMJFT;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind SSNBWZUXQFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<FUOQNRHVAEF> XYBXYVYQXIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110", Slot = "5")]
			get
			{
				return default(Id32<FUOQNRHVAEF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private SBSDUOTZRVD FKRMYWKCJTW
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2966D70", Offset = "0x2965B70", VA = "0x182966D70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private SBSDUOTZRVD LNRWQWQEPQF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2966C00", Offset = "0x2965A00", VA = "0x182966C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xEFA5A0", Offset = "0xEF93A0", VA = "0x180EFA5A0")]
		private OEVVXJRHXTM(Id32<FUOQNRHVAEF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2966DC0", Offset = "0x2965BC0", VA = "0x182966DC0")]
		public static OEVVXJRHXTM New(Id32<FUOQNRHVAEF> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2966C50", Offset = "0x2965A50", VA = "0x182966C50", Slot = "8")]
		public bool Equals(SBSDUOTZRVD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2966E20", Offset = "0x2965C20", VA = "0x182966E20", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class JUTCXVUDHEU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<FUOQNRHVAEF> ZVXCDESMJGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<FUOQNRHVAEF>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D80", Offset = "0xAD2B80", VA = "0x180AD3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SBSDUOTZRVD JMWYIQGMJFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE64E90", Offset = "0xE63C90", VA = "0x180E64E90")]
		private JUTCXVUDHEU(Id32<FUOQNRHVAEF> a, SBSDUOTZRVD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x29664C0", Offset = "0x29652C0", VA = "0x1829664C0")]
		public static Result<JUTCXVUDHEU, GAJLSRYNUUX> FAWFABFMWMM([In] Substitution substitution, IdArray<FUOQNRHVAEF, Term> a, Id32<FUOQNRHVAEF>[] b, IdArray<FUOQNRHVAEF, bool> c)
		{
			return default(Result<JUTCXVUDHEU, GAJLSRYNUUX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x29666F0", Offset = "0x29654F0", VA = "0x1829666F0")]
		private static Result<SBSDUOTZRVD, GAJLSRYNUUX> URRHNIAHNNQ(Id32<FUOQNRHVAEF> a, IdArray<FUOQNRHVAEF, Term> b, Id32<FUOQNRHVAEF>[] c, IdArray<FUOQNRHVAEF, bool> d)
		{
			return default(Result<SBSDUOTZRVD, GAJLSRYNUUX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2966680", Offset = "0x2965480", VA = "0x182966680", Slot = "3")]
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
