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
	public interface IUAMOHWSHKE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates RKANVKUVWGH(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class PAGEXXEQJIV
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9950", Offset = "0x2BA8950", VA = "0x182BA9950")]
		public static Id32<LUFZDYJCGSH> EDPFWDKRLGN(this int a)
		{
			return default(Id32<LUFZDYJCGSH>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class LUFZDYJCGSH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ZNWTEEDJRGE : SIEDSHFPKXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA4A0", Offset = "0x2BA94A0", VA = "0x182BAA4A0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA4D0", Offset = "0x2BA94D0", VA = "0x182BAA4D0")]
		public ZNWTEEDJRGE()
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
			[Cpp2IlInjected.Address(RVA = "0x2BA9120", Offset = "0x2BA8120", VA = "0x182BA9120")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9190", Offset = "0x2BA8190", VA = "0x182BA9190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA92B0", Offset = "0x2BA82B0", VA = "0x182BA92B0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA91A0", Offset = "0x2BA81A0", VA = "0x182BA91A0")]
		public static ApplyConstraintResult DIZBKDGEKEE([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9280", Offset = "0x2BA8280", VA = "0x182BA9280")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9240", Offset = "0x2BA8240", VA = "0x182BA9240")]
		public static ApplyConstraintResult XKPWDAEYJSB([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9270", Offset = "0x2BA8270", VA = "0x182BA9270")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9220", Offset = "0x2BA8220", VA = "0x182BA9220")]
		public static ApplyConstraintResult WDAVIQKROHS()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<LUFZDYJCGSH> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<LUFZDYJCGSH> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		private Arrow(Id32<LUFZDYJCGSH> from, Id32<LUFZDYJCGSH> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B880", Offset = "0x2B8A880", VA = "0x182B8B880")]
		public static Arrow New(Id32<LUFZDYJCGSH> from, Id32<LUFZDYJCGSH> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9330", Offset = "0x2BA8330", VA = "0x182BA9330", Slot = "3")]
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
		public readonly Id32<LUFZDYJCGSH> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<LUFZDYJCGSH> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		private Constraint(Id32<LUFZDYJCGSH> lhs, Id32<LUFZDYJCGSH> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B880", Offset = "0x2B8A880", VA = "0x182B8B880")]
		public static Constraint New(Id32<LUFZDYJCGSH> lhs, Id32<LUFZDYJCGSH> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BA96C0", Offset = "0x2BA86C0", VA = "0x182BA96C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class UJITOVIFSLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA2E0", Offset = "0x2BA92E0", VA = "0x182BAA2E0")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<LUFZDYJCGSH, Term> terms, Id32<LUFZDYJCGSH>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<LUFZDYJCGSH> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<LUFZDYJCGSH> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		private Substitution(Id32<LUFZDYJCGSH> identifier, Id32<LUFZDYJCGSH> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B880", Offset = "0x2B8A880", VA = "0x182B8B880")]
		public static Substitution New(Id32<LUFZDYJCGSH> identifier, Id32<LUFZDYJCGSH> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA130", Offset = "0x2BA9130", VA = "0x182BAA130", Slot = "3")]
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
			public readonly Id32<LUFZDYJCGSH> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BAA1C0", Offset = "0x2BA91C0", VA = "0x182BAA1C0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BAA1D0", Offset = "0x2BA91D0", VA = "0x182BAA1D0")]
			public TermImpl(Id32<LUFZDYJCGSH> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2BAA2D0", Offset = "0x2BA92D0", VA = "0x182BAA2D0")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA1E0", Offset = "0x2BA91E0", VA = "0x182BAA1E0")]
		public static Term DEUYKATVJQV([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA2B0", Offset = "0x2BA92B0", VA = "0x182BAA2B0")]
		private Term(Id32<LUFZDYJCGSH> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA200", Offset = "0x2BA9200", VA = "0x182BAA200")]
		public static Term OSPLQRGECVB(Id32<LUFZDYJCGSH> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA220", Offset = "0x2BA9220", VA = "0x182BAA220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class EMLGQPYYQVZ<a, b> where b : IUAMOHWSHKE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QWHKHWJLEJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<LUFZDYJCGSH, Term> CQYUSMJCVIZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<LUFZDYJCGSH>[] INSOQFXRLGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<LUFZDYJCGSH, bool> OCPPGLXPBRQ;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QWHKHWJLEJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x77F09D0", Offset = "0x77EF9D0", VA = "0x1877F09D0")]
			internal Result<RVPEZDXVRTY, SIEDSHFPKXL> MAUFCSLZNPE(Substitution a)
			{
				return default(Result<RVPEZDXVRTY, SIEDSHFPKXL>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> MOMKHUEIUVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> MTUQYVAIWYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b BIQCNNIQICF;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5B48010", Offset = "0x5B47010", VA = "0x185B48010")]
		protected EMLGQPYYQVZ([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5B46E90", Offset = "0x5B45E90", VA = "0x185B46E90")]
		public static EMLGQPYYQVZ<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5B46CB0", Offset = "0x5B45CB0", VA = "0x185B46CB0")]
		public Id32<LUFZDYJCGSH> AZEMLZLVSFY()
		{
			return default(Id32<LUFZDYJCGSH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5B468F0", Offset = "0x5B458F0", VA = "0x185B468F0")]
		public Id32<LUFZDYJCGSH> ATBZYVCDXBF(Id32<LUFZDYJCGSH> a, Id32<LUFZDYJCGSH> b)
		{
			return default(Id32<LUFZDYJCGSH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD5A6D0", Offset = "0xD596D0", VA = "0x180D5A6D0")]
		public Id32<LUFZDYJCGSH> ALWALAWXEVT(Id32<LUFZDYJCGSH> a)
		{
			return default(Id32<LUFZDYJCGSH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B46AD0", Offset = "0x5B45AD0", VA = "0x185B46AD0")]
		public void AYJTNIPAZUJ(Id32<LUFZDYJCGSH> a, Id32<LUFZDYJCGSH> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5B478E0", Offset = "0x5B468E0", VA = "0x185B478E0")]
		public Result<RVPEZDXVRTY[], SIEDSHFPKXL> Solve([In] a root)
		{
			return default(Result<RVPEZDXVRTY[], SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5B48000", Offset = "0x5B47000", VA = "0x185B48000")]
		public BUEAGKDIJLF ZNZZGULBDMQ(Id32<LUFZDYJCGSH> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class IPAGZKXARKR
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9750", Offset = "0x2BA8750", VA = "0x182BA9750")]
		internal static Term PDYDZXPZTRS(Id32<LUFZDYJCGSH> a, IdArray<LUFZDYJCGSH, Term> b, Id32<LUFZDYJCGSH>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface BUEAGKDIJLF : IEquatable<BUEAGKDIJLF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind BWQZNOWSFXG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<LUFZDYJCGSH> ZHOIEMXBOAY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		BUEAGKDIJLF XGAOFHIHCQP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		BUEAGKDIJLF FLYYFJZUPZI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class BYTJOGMLZYE : BUEAGKDIJLF, IEquatable<BUEAGKDIJLF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly BUEAGKDIJLF SGWAHMLMBLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly BUEAGKDIJLF MKJKWNBQJRF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind BWQZNOWSFXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<LUFZDYJCGSH> CWNGUZYIACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9540", Offset = "0x2BA8540", VA = "0x182BA9540", Slot = "5")]
			get
			{
				return default(Id32<LUFZDYJCGSH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private BUEAGKDIJLF AOKDLBTLZLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BUEAGKDIJLF REDBZLQNMBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		private BYTJOGMLZYE(BUEAGKDIJLF a, BUEAGKDIJLF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9590", Offset = "0x2BA8590", VA = "0x182BA9590")]
		public static BYTJOGMLZYE New(BUEAGKDIJLF from, BUEAGKDIJLF to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BA93C0", Offset = "0x2BA83C0", VA = "0x182BA93C0", Slot = "8")]
		public bool Equals(BUEAGKDIJLF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9610", Offset = "0x2BA8610", VA = "0x182BA9610", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class POALWLHSHIE : BUEAGKDIJLF, IEquatable<BUEAGKDIJLF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<LUFZDYJCGSH> WZVCBEIJRSP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind BWQZNOWSFXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<LUFZDYJCGSH> CWNGUZYIACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110", Slot = "5")]
			get
			{
				return default(Id32<LUFZDYJCGSH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private BUEAGKDIJLF AOKDLBTLZLY
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9BA0", Offset = "0x2BA8BA0", VA = "0x182BA9BA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private BUEAGKDIJLF REDBZLQNMBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9AB0", Offset = "0x2BA8AB0", VA = "0x182BA9AB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1129140", Offset = "0x1128140", VA = "0x181129140")]
		private POALWLHSHIE(Id32<LUFZDYJCGSH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9B00", Offset = "0x2BA8B00", VA = "0x182BA9B00")]
		public static POALWLHSHIE New(Id32<LUFZDYJCGSH> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9990", Offset = "0x2BA8990", VA = "0x182BA9990", Slot = "8")]
		public bool Equals(BUEAGKDIJLF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9B60", Offset = "0x2BA8B60", VA = "0x182BA9B60", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class RVPEZDXVRTY
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<LUFZDYJCGSH> OSRJHZIEHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<LUFZDYJCGSH>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA30", Offset = "0xCFAA30", VA = "0x180CFBA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BUEAGKDIJLF WZVCBEIJRSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x10958A0", Offset = "0x10948A0", VA = "0x1810958A0")]
		private RVPEZDXVRTY(Id32<LUFZDYJCGSH> a, BUEAGKDIJLF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9BF0", Offset = "0x2BA8BF0", VA = "0x182BA9BF0")]
		public static Result<RVPEZDXVRTY, SIEDSHFPKXL> HOMOBCVXHYG([In] Substitution substitution, IdArray<LUFZDYJCGSH, Term> a, Id32<LUFZDYJCGSH>[] b, IdArray<LUFZDYJCGSH, bool> c)
		{
			return default(Result<RVPEZDXVRTY, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9DB0", Offset = "0x2BA8DB0", VA = "0x182BA9DB0")]
		private static Result<BUEAGKDIJLF, SIEDSHFPKXL> IRYLHPWPJHK(Id32<LUFZDYJCGSH> a, IdArray<LUFZDYJCGSH, Term> b, Id32<LUFZDYJCGSH>[] c, IdArray<LUFZDYJCGSH, bool> d)
		{
			return default(Result<BUEAGKDIJLF, SIEDSHFPKXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA0C0", Offset = "0x2BA90C0", VA = "0x182BAA0C0", Slot = "3")]
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
