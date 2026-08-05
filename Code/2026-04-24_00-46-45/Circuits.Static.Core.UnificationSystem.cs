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
	public interface SWOGATQYSMU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates BMKRLQVWROT(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class FZJVEQAFKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEC80", Offset = "0x2BDD680", VA = "0x182BDEC80")]
		public static Id32<AIVDWRIFEVZ> ZZOEMVLIEXH(this int a)
		{
			return default(Id32<AIVDWRIFEVZ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class AIVDWRIFEVZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class USGRNDBQVPS : XZBQMYIZLTP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF910", Offset = "0x2BDE310", VA = "0x182BDF910", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF940", Offset = "0x2BDE340", VA = "0x182BDF940")]
		public USGRNDBQVPS()
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
			[Cpp2IlInjected.Address(RVA = "0x2BDE950", Offset = "0x2BDD350", VA = "0x182BDE950")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BDE9C0", Offset = "0x2BDD3C0", VA = "0x182BDE9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDEAE0", Offset = "0x2BDD4E0", VA = "0x182BDEAE0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEA00", Offset = "0x2BDD400", VA = "0x182BDEA00")]
		public static ApplyConstraintResult RUJVGBXOUKA([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEAB0", Offset = "0x2BDD4B0", VA = "0x182BDEAB0")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE9D0", Offset = "0x2BDD3D0", VA = "0x182BDE9D0")]
		public static ApplyConstraintResult NWZTKSPRXLH([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEAA0", Offset = "0x2BDD4A0", VA = "0x182BDEAA0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEA80", Offset = "0x2BDD480", VA = "0x182BDEA80")]
		public static ApplyConstraintResult UGBNTJATMBG()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<AIVDWRIFEVZ> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<AIVDWRIFEVZ> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		private Arrow(Id32<AIVDWRIFEVZ> from, Id32<AIVDWRIFEVZ> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8520", Offset = "0x2BC6F20", VA = "0x182BC8520")]
		public static Arrow New(Id32<AIVDWRIFEVZ> from, Id32<AIVDWRIFEVZ> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEB60", Offset = "0x2BDD560", VA = "0x182BDEB60", Slot = "3")]
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
		public readonly Id32<AIVDWRIFEVZ> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<AIVDWRIFEVZ> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		private Constraint(Id32<AIVDWRIFEVZ> lhs, Id32<AIVDWRIFEVZ> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8520", Offset = "0x2BC6F20", VA = "0x182BC8520")]
		public static Constraint New(Id32<AIVDWRIFEVZ> lhs, Id32<AIVDWRIFEVZ> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEBF0", Offset = "0x2BDD5F0", VA = "0x182BDEBF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class XPLPHCCVXIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF950", Offset = "0x2BDE350", VA = "0x182BDF950")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<AIVDWRIFEVZ, Term> terms, Id32<AIVDWRIFEVZ>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<AIVDWRIFEVZ> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<AIVDWRIFEVZ> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		private Substitution(Id32<AIVDWRIFEVZ> identifier, Id32<AIVDWRIFEVZ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8520", Offset = "0x2BC6F20", VA = "0x182BC8520")]
		public static Substitution New(Id32<AIVDWRIFEVZ> identifier, Id32<AIVDWRIFEVZ> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF460", Offset = "0x2BDDE60", VA = "0x182BDF460", Slot = "3")]
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
			public readonly Id32<AIVDWRIFEVZ> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF4F0", Offset = "0x2BDDEF0", VA = "0x182BDF4F0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF500", Offset = "0x2BDDF00", VA = "0x182BDF500")]
			public TermImpl(Id32<AIVDWRIFEVZ> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2BDF600", Offset = "0x2BDE000", VA = "0x182BDF600")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF510", Offset = "0x2BDDF10", VA = "0x182BDF510")]
		public static Term REPQVGPGDOZ([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF5E0", Offset = "0x2BDDFE0", VA = "0x182BDF5E0")]
		private Term(Id32<AIVDWRIFEVZ> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF5C0", Offset = "0x2BDDFC0", VA = "0x182BDF5C0")]
		public static Term VIJQEENCIGP(Id32<AIVDWRIFEVZ> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF530", Offset = "0x2BDDF30", VA = "0x182BDF530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class WIKVJSGBZLR<a, b> where b : SWOGATQYSMU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class RPQRTZAZVHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<AIVDWRIFEVZ, Term> FVWHIRXXJQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<AIVDWRIFEVZ>[] SDYRNIQWIGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<AIVDWRIFEVZ, bool> CKQZLXSTSVU;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RPQRTZAZVHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7654F10", Offset = "0x7653910", VA = "0x187654F10")]
			internal Result<KRKJXHJAUGG, XZBQMYIZLTP> UKVEKNVMBNQ(Substitution a)
			{
				return default(Result<KRKJXHJAUGG, XZBQMYIZLTP>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> UZCXLTGMEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> JFBAYFZTBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b FHQCWCTTOJP;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8726DD0", Offset = "0x87257D0", VA = "0x188726DD0")]
		protected WIKVJSGBZLR([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8725B90", Offset = "0x8724590", VA = "0x188725B90")]
		public static WIKVJSGBZLR<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8725A60", Offset = "0x8724460", VA = "0x188725A60")]
		public Id32<AIVDWRIFEVZ> MKRZUWATZGC()
		{
			return default(Id32<AIVDWRIFEVZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87257B0", Offset = "0x87241B0", VA = "0x1887257B0")]
		public Id32<AIVDWRIFEVZ> ESCAHKNHDIP(Id32<AIVDWRIFEVZ> a, Id32<AIVDWRIFEVZ> b)
		{
			return default(Id32<AIVDWRIFEVZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD76900", Offset = "0xD75300", VA = "0x180D76900")]
		public Id32<AIVDWRIFEVZ> YUURIMMXEQV(Id32<AIVDWRIFEVZ> a)
		{
			return default(Id32<AIVDWRIFEVZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x87255C0", Offset = "0x8723FC0", VA = "0x1887255C0")]
		public void EIATCTDNWVT(Id32<AIVDWRIFEVZ> a, Id32<AIVDWRIFEVZ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87266B0", Offset = "0x87250B0", VA = "0x1887266B0")]
		public Result<KRKJXHJAUGG[], XZBQMYIZLTP> Solve([In] a root)
		{
			return default(Result<KRKJXHJAUGG[], XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8725B80", Offset = "0x8724580", VA = "0x188725B80")]
		public DAVONDENLTV NAHLYJNXGZC(Id32<AIVDWRIFEVZ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class XXAAODVYURP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDFB10", Offset = "0x2BDE510", VA = "0x182BDFB10")]
		internal static Term URCUGQWESCU(Id32<AIVDWRIFEVZ> a, IdArray<AIVDWRIFEVZ, Term> b, Id32<AIVDWRIFEVZ>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface DAVONDENLTV : IEquatable<DAVONDENLTV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind QZFCEIPKDTG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<AIVDWRIFEVZ> PQWNDAXMHJS
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DAVONDENLTV BUNDTJUBUOL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		DAVONDENLTV ZISYTAGNKAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class UPMFKYMLGWE : DAVONDENLTV, IEquatable<DAVONDENLTV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly DAVONDENLTV HJKCYGEDZHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly DAVONDENLTV JHVQXYRBJPR;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind QZFCEIPKDTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<AIVDWRIFEVZ> BCUSJPPQYFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF810", Offset = "0x2BDE210", VA = "0x182BDF810", Slot = "5")]
			get
			{
				return default(Id32<AIVDWRIFEVZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private DAVONDENLTV ZKBTSKGIDPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private DAVONDENLTV MVIZTHTEFVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		private UPMFKYMLGWE(DAVONDENLTV a, DAVONDENLTV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF790", Offset = "0x2BDE190", VA = "0x182BDF790")]
		public static UPMFKYMLGWE New(DAVONDENLTV from, DAVONDENLTV to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF610", Offset = "0x2BDE010", VA = "0x182BDF610", Slot = "8")]
		public bool Equals(DAVONDENLTV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF860", Offset = "0x2BDE260", VA = "0x182BDF860", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class NTCKITDQJOQ : DAVONDENLTV, IEquatable<DAVONDENLTV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<AIVDWRIFEVZ> BPERYPXGUEX;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind QZFCEIPKDTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<AIVDWRIFEVZ> BCUSJPPQYFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110", Slot = "5")]
			get
			{
				return default(Id32<AIVDWRIFEVZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private DAVONDENLTV ZKBTSKGIDPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF320", Offset = "0x2BDDD20", VA = "0x182BDF320", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private DAVONDENLTV MVIZTHTEFVV
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF370", Offset = "0x2BDDD70", VA = "0x182BDF370", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1172850", Offset = "0x1171250", VA = "0x181172850")]
		private NTCKITDQJOQ(Id32<AIVDWRIFEVZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF3C0", Offset = "0x2BDDDC0", VA = "0x182BDF3C0")]
		public static NTCKITDQJOQ New(Id32<AIVDWRIFEVZ> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF200", Offset = "0x2BDDC00", VA = "0x182BDF200", Slot = "8")]
		public bool Equals(DAVONDENLTV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF420", Offset = "0x2BDDE20", VA = "0x182BDF420", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class KRKJXHJAUGG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<AIVDWRIFEVZ> JQHSIUZOJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<AIVDWRIFEVZ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DAVONDENLTV BPERYPXGUEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x10B3BE0", Offset = "0x10B25E0", VA = "0x1810B3BE0")]
		private KRKJXHJAUGG(Id32<AIVDWRIFEVZ> a, DAVONDENLTV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEFD0", Offset = "0x2BDD9D0", VA = "0x182BDEFD0")]
		public static Result<KRKJXHJAUGG, XZBQMYIZLTP> SVEGLXCKQXU([In] Substitution substitution, IdArray<AIVDWRIFEVZ, Term> a, Id32<AIVDWRIFEVZ>[] b, IdArray<AIVDWRIFEVZ, bool> c)
		{
			return default(Result<KRKJXHJAUGG, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BDECC0", Offset = "0x2BDD6C0", VA = "0x182BDECC0")]
		private static Result<DAVONDENLTV, XZBQMYIZLTP> CRSLHXFRNUI(Id32<AIVDWRIFEVZ> a, IdArray<AIVDWRIFEVZ, Term> b, Id32<AIVDWRIFEVZ>[] c, IdArray<AIVDWRIFEVZ, bool> d)
		{
			return default(Result<DAVONDENLTV, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF190", Offset = "0x2BDDB90", VA = "0x182BDF190", Slot = "3")]
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
