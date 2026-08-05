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
	public interface XSBPVWOYINP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates ZMPDSGIFETS(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class LONGZSJYBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D30", Offset = "0x2BA5D30", VA = "0x182BA6D30")]
		public static Id32<TBTXFZKHELY> QTILSASQKQG(this int a)
		{
			return default(Id32<TBTXFZKHELY>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class TBTXFZKHELY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class SYVCSGNMPPZ : GJHFNOSHAUY
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F30", Offset = "0x2BA5F30", VA = "0x182BA6F30", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F60", Offset = "0x2BA5F60", VA = "0x182BA6F60")]
		public SYVCSGNMPPZ()
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
			[Cpp2IlInjected.Address(RVA = "0x2BA5FC0", Offset = "0x2BA4FC0", VA = "0x182BA5FC0")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6030", Offset = "0x2BA5030", VA = "0x182BA6030")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6150", Offset = "0x2BA5150", VA = "0x182BA6150")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6090", Offset = "0x2BA5090", VA = "0x182BA6090")]
		public static ApplyConstraintResult OUPUNEVGYFB([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6120", Offset = "0x2BA5120", VA = "0x182BA6120")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6060", Offset = "0x2BA5060", VA = "0x182BA6060")]
		public static ApplyConstraintResult IQGFVNVJFSY([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6110", Offset = "0x2BA5110", VA = "0x182BA6110")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6040", Offset = "0x2BA5040", VA = "0x182BA6040")]
		public static ApplyConstraintResult GBKFIHUXKWJ()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<TBTXFZKHELY> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<TBTXFZKHELY> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
		private Arrow(Id32<TBTXFZKHELY> from, Id32<TBTXFZKHELY> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B87D70", Offset = "0x2B86D70", VA = "0x182B87D70")]
		public static Arrow New(Id32<TBTXFZKHELY> from, Id32<TBTXFZKHELY> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA61D0", Offset = "0x2BA51D0", VA = "0x182BA61D0", Slot = "3")]
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
		public readonly Id32<TBTXFZKHELY> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<TBTXFZKHELY> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
		private Constraint(Id32<TBTXFZKHELY> lhs, Id32<TBTXFZKHELY> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B87D70", Offset = "0x2B86D70", VA = "0x182B87D70")]
		public static Constraint New(Id32<TBTXFZKHELY> lhs, Id32<TBTXFZKHELY> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6260", Offset = "0x2BA5260", VA = "0x182BA6260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class MCELYOTZULX
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D70", Offset = "0x2BA5D70", VA = "0x182BA6D70")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<TBTXFZKHELY, Term> terms, Id32<TBTXFZKHELY>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<TBTXFZKHELY> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<TBTXFZKHELY> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xF86CB0", Offset = "0xF85CB0", VA = "0x180F86CB0")]
		private Substitution(Id32<TBTXFZKHELY> identifier, Id32<TBTXFZKHELY> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B87D70", Offset = "0x2B86D70", VA = "0x182B87D70")]
		public static Substitution New(Id32<TBTXFZKHELY> identifier, Id32<TBTXFZKHELY> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F70", Offset = "0x2BA5F70", VA = "0x182BA6F70", Slot = "3")]
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
			public readonly Id32<TBTXFZKHELY> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7000", Offset = "0x2BA6000", VA = "0x182BA7000")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7010", Offset = "0x2BA6010", VA = "0x182BA7010")]
			public TermImpl(Id32<TBTXFZKHELY> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2BA7110", Offset = "0x2BA6110", VA = "0x182BA7110")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7020", Offset = "0x2BA6020", VA = "0x182BA7020")]
		public static Term MQEGAHZFWCK([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BA70F0", Offset = "0x2BA60F0", VA = "0x182BA70F0")]
		private Term(Id32<TBTXFZKHELY> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA70D0", Offset = "0x2BA60D0", VA = "0x182BA70D0")]
		public static Term VNNGRSSNVEC(Id32<TBTXFZKHELY> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7040", Offset = "0x2BA6040", VA = "0x182BA7040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class KLQZMIXSCVU<a, b> where b : XSBPVWOYINP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class SCYSNCSTSXC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<TBTXFZKHELY, Term> RYEIYCYNLUM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<TBTXFZKHELY>[] KELAENUFAZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<TBTXFZKHELY, bool> GPDBDBULLRF;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public SCYSNCSTSXC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x618DC00", Offset = "0x618CC00", VA = "0x18618DC00")]
			internal Result<DIIBWCJRNTJ, GJHFNOSHAUY> QMATDBXJPKL(Substitution a)
			{
				return default(Result<DIIBWCJRNTJ, GJHFNOSHAUY>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> JEPGBGFGUKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> KSTNLSERPNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b RAESGKCNHZO;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x550E950", Offset = "0x550D950", VA = "0x18550E950")]
		protected KLQZMIXSCVU([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x550D1A0", Offset = "0x550C1A0", VA = "0x18550D1A0")]
		public static KLQZMIXSCVU<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x550E500", Offset = "0x550D500", VA = "0x18550E500")]
		public Id32<TBTXFZKHELY> XHCIBBEYGDV()
		{
			return default(Id32<TBTXFZKHELY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x550CEE0", Offset = "0x550BEE0", VA = "0x18550CEE0")]
		public Id32<TBTXFZKHELY> FXYFLBRNXCC(Id32<TBTXFZKHELY> a, Id32<TBTXFZKHELY> b)
		{
			return default(Id32<TBTXFZKHELY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xCAD580", Offset = "0xCAC580", VA = "0x180CAD580")]
		public Id32<TBTXFZKHELY> SNWUDEXWQWO(Id32<TBTXFZKHELY> a)
		{
			return default(Id32<TBTXFZKHELY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x550D430", Offset = "0x550C430", VA = "0x18550D430")]
		public void RPNXNHZSVAK(Id32<TBTXFZKHELY> a, Id32<TBTXFZKHELY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x550D4B0", Offset = "0x550C4B0", VA = "0x18550D4B0")]
		public Result<DIIBWCJRNTJ[], GJHFNOSHAUY> Solve([In] a root)
		{
			return default(Result<DIIBWCJRNTJ[], GJHFNOSHAUY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x550D4A0", Offset = "0x550C4A0", VA = "0x18550D4A0")]
		public WEBHQSVPRZE SIJJXCPMCDV(Id32<TBTXFZKHELY> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class HPBUUUZHTEM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6B30", Offset = "0x2BA5B30", VA = "0x182BA6B30")]
		internal static Term NNAXBVUTKEZ(Id32<TBTXFZKHELY> a, IdArray<TBTXFZKHELY, Term> b, Id32<TBTXFZKHELY>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface WEBHQSVPRZE : IEquatable<WEBHQSVPRZE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind BSZGMEOZKDB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<TBTXFZKHELY> XJSVPJQSYOL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		WEBHQSVPRZE JLCGUZFCNPU
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		WEBHQSVPRZE ACYHMHOVZYT
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class FQEOQFPKJLB : WEBHQSVPRZE, IEquatable<WEBHQSVPRZE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly WEBHQSVPRZE VISFSJKOCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly WEBHQSVPRZE SRTUDHIAFHW;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind BSZGMEOZKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB36060", Offset = "0xB35060", VA = "0x180B36060", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<TBTXFZKHELY> GSWTAYMLLPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6AE0", Offset = "0x2BA5AE0", VA = "0x182BA6AE0", Slot = "5")]
			get
			{
				return default(Id32<TBTXFZKHELY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private WEBHQSVPRZE VPZJIYODYFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private WEBHQSVPRZE UOYAJWZLZME
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAD9FF0", Offset = "0xAD8FF0", VA = "0x180AD9FF0")]
		private FQEOQFPKJLB(WEBHQSVPRZE a, WEBHQSVPRZE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA69B0", Offset = "0x2BA59B0", VA = "0x182BA69B0")]
		public static FQEOQFPKJLB New(WEBHQSVPRZE from, WEBHQSVPRZE to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6830", Offset = "0x2BA5830", VA = "0x182BA6830", Slot = "8")]
		public bool Equals(WEBHQSVPRZE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6A30", Offset = "0x2BA5A30", VA = "0x182BA6A30", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class VBMQRKGSBAZ : WEBHQSVPRZE, IEquatable<WEBHQSVPRZE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<TBTXFZKHELY> AUBFRNVZHSG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind BSZGMEOZKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<TBTXFZKHELY> GSWTAYMLLPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110", Slot = "5")]
			get
			{
				return default(Id32<TBTXFZKHELY>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private WEBHQSVPRZE VPZJIYODYFX
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7120", Offset = "0x2BA6120", VA = "0x182BA7120", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private WEBHQSVPRZE UOYAJWZLZME
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7330", Offset = "0x2BA6330", VA = "0x182BA7330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x11FBAE0", Offset = "0x11FAAE0", VA = "0x1811FBAE0")]
		private VBMQRKGSBAZ(Id32<TBTXFZKHELY> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7290", Offset = "0x2BA6290", VA = "0x182BA7290")]
		public static VBMQRKGSBAZ New(Id32<TBTXFZKHELY> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7170", Offset = "0x2BA6170", VA = "0x182BA7170", Slot = "8")]
		public bool Equals(WEBHQSVPRZE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA72F0", Offset = "0x2BA62F0", VA = "0x182BA72F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class DIIBWCJRNTJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<TBTXFZKHELY> HGJTEJGBOEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xACD110", Offset = "0xACC110", VA = "0x180ACD110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<TBTXFZKHELY>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xADCB20", Offset = "0xADBB20", VA = "0x180ADCB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public WEBHQSVPRZE AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1151E80", Offset = "0x1150E80", VA = "0x181151E80")]
		private DIIBWCJRNTJ(Id32<TBTXFZKHELY> a, WEBHQSVPRZE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BA62F0", Offset = "0x2BA52F0", VA = "0x182BA62F0")]
		public static Result<DIIBWCJRNTJ, GJHFNOSHAUY> BNRRWDLRMZZ([In] Substitution substitution, IdArray<TBTXFZKHELY, Term> a, Id32<TBTXFZKHELY>[] b, IdArray<TBTXFZKHELY, bool> c)
		{
			return default(Result<DIIBWCJRNTJ, GJHFNOSHAUY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BA64B0", Offset = "0x2BA54B0", VA = "0x182BA64B0")]
		private static Result<WEBHQSVPRZE, GJHFNOSHAUY> DGGLOPIRREV(Id32<TBTXFZKHELY> a, IdArray<TBTXFZKHELY, Term> b, Id32<TBTXFZKHELY>[] c, IdArray<TBTXFZKHELY, bool> d)
		{
			return default(Result<WEBHQSVPRZE, GJHFNOSHAUY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BA67C0", Offset = "0x2BA57C0", VA = "0x182BA67C0", Slot = "3")]
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
