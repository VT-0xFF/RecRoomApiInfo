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
	public interface EXZIFHHHFWB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates BPXBUEXSJRC(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class VOARQCJAOUW
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEC40", Offset = "0x2BDD640", VA = "0x182BDEC40")]
		public static Id32<UWMTGGTCNFQ> UISRRFDFAQO(this int a)
		{
			return default(Id32<UWMTGGTCNFQ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class UWMTGGTCNFQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class JXIUBFAMYWX : TDAXDIBDDUE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE330", Offset = "0x2BDCD30", VA = "0x182BDE330", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE360", Offset = "0x2BDCD60", VA = "0x182BDE360")]
		public JXIUBFAMYWX()
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
			[Cpp2IlInjected.Address(RVA = "0x2BDD8C0", Offset = "0x2BDC2C0", VA = "0x182BDD8C0")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BDD930", Offset = "0x2BDC330", VA = "0x182BDD930")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDDA50", Offset = "0x2BDC450", VA = "0x182BDDA50")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD940", Offset = "0x2BDC340", VA = "0x182BDD940")]
		public static ApplyConstraintResult BXRHJRELUSP([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDA20", Offset = "0x2BDC420", VA = "0x182BDDA20")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD9C0", Offset = "0x2BDC3C0", VA = "0x182BDD9C0")]
		public static ApplyConstraintResult VIJGYRJVTGQ([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDA10", Offset = "0x2BDC410", VA = "0x182BDDA10")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD9F0", Offset = "0x2BDC3F0", VA = "0x182BDD9F0")]
		public static ApplyConstraintResult XYQXWIMXZUJ()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<UWMTGGTCNFQ> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<UWMTGGTCNFQ> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
		private Arrow(Id32<UWMTGGTCNFQ> from, Id32<UWMTGGTCNFQ> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF5A0", Offset = "0x2BBDFA0", VA = "0x182BBF5A0")]
		public static Arrow New(Id32<UWMTGGTCNFQ> from, Id32<UWMTGGTCNFQ> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDAD0", Offset = "0x2BDC4D0", VA = "0x182BDDAD0", Slot = "3")]
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
		public readonly Id32<UWMTGGTCNFQ> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<UWMTGGTCNFQ> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
		private Constraint(Id32<UWMTGGTCNFQ> lhs, Id32<UWMTGGTCNFQ> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF5A0", Offset = "0x2BBDFA0", VA = "0x182BBF5A0")]
		public static Constraint New(Id32<UWMTGGTCNFQ> lhs, Id32<UWMTGGTCNFQ> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDB60", Offset = "0x2BDC560", VA = "0x182BDDB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class NWWTBDFUGWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE8D0", Offset = "0x2BDD2D0", VA = "0x182BDE8D0")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<UWMTGGTCNFQ, Term> terms, Id32<UWMTGGTCNFQ>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<UWMTGGTCNFQ> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<UWMTGGTCNFQ> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
		private Substitution(Id32<UWMTGGTCNFQ> identifier, Id32<UWMTGGTCNFQ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF5A0", Offset = "0x2BBDFA0", VA = "0x182BBF5A0")]
		public static Substitution New(Id32<UWMTGGTCNFQ> identifier, Id32<UWMTGGTCNFQ> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEA90", Offset = "0x2BDD490", VA = "0x182BDEA90", Slot = "3")]
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
			public readonly Id32<UWMTGGTCNFQ> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BDEB20", Offset = "0x2BDD520", VA = "0x182BDEB20")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BDEB30", Offset = "0x2BDD530", VA = "0x182BDEB30")]
			public TermImpl(Id32<UWMTGGTCNFQ> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2BDEC30", Offset = "0x2BDD630", VA = "0x182BDEC30")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEB60", Offset = "0x2BDD560", VA = "0x182BDEB60")]
		public static Term MQRRTTWZXFA([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEC10", Offset = "0x2BDD610", VA = "0x182BDEC10")]
		private Term(Id32<UWMTGGTCNFQ> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEB40", Offset = "0x2BDD540", VA = "0x182BDEB40")]
		public static Term KPRJPLIVJRY(Id32<UWMTGGTCNFQ> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDEB80", Offset = "0x2BDD580", VA = "0x182BDEB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class IUHXJXDREZU<a, b> where b : EXZIFHHHFWB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class UACGPVXXMUQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<UWMTGGTCNFQ, Term> DVIBLPHALRK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<UWMTGGTCNFQ>[] KBMVIYGVSGW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<UWMTGGTCNFQ, bool> CVZYGDHQMKH;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7E1DF20", Offset = "0x7E1C920", VA = "0x187E1DF20")]
			internal Result<GEMTJDXWSYD, TDAXDIBDDUE> KPHAVCJOODF(Substitution a)
			{
				return default(Result<GEMTJDXWSYD, TDAXDIBDDUE>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> LVYXAUAZXVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> HNUGGMZSODQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b BJEOXILCYDG;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66612E0", Offset = "0x665FCE0", VA = "0x1866612E0")]
		protected IUHXJXDREZU([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x665F940", Offset = "0x665E340", VA = "0x18665F940")]
		public static IUHXJXDREZU<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x665FA70", Offset = "0x665E470", VA = "0x18665FA70")]
		public Id32<UWMTGGTCNFQ> QSKXGXAIHLJ()
		{
			return default(Id32<UWMTGGTCNFQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6660FE0", Offset = "0x665F9E0", VA = "0x186660FE0")]
		public Id32<UWMTGGTCNFQ> WELXHLDHVBM(Id32<UWMTGGTCNFQ> a, Id32<UWMTGGTCNFQ> b)
		{
			return default(Id32<UWMTGGTCNFQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD75DC0", Offset = "0xD747C0", VA = "0x180D75DC0")]
		public Id32<UWMTGGTCNFQ> VQRUGTSIEYC(Id32<UWMTGGTCNFQ> a)
		{
			return default(Id32<UWMTGGTCNFQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6660DF0", Offset = "0x665F7F0", VA = "0x186660DF0")]
		public void TCOVDVSZKHQ(Id32<UWMTGGTCNFQ> a, Id32<UWMTGGTCNFQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x665FD00", Offset = "0x665E700", VA = "0x18665FD00")]
		public Result<GEMTJDXWSYD[], TDAXDIBDDUE> Solve([In] a root)
		{
			return default(Result<GEMTJDXWSYD[], TDAXDIBDDUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x665F870", Offset = "0x665E270", VA = "0x18665F870")]
		public TJKHEENBPWS CEMLEZTSGAL(Id32<UWMTGGTCNFQ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FIPHGMPWSRO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDBF0", Offset = "0x2BDC5F0", VA = "0x182BDDBF0")]
		internal static Term JETRAWJXOFX(Id32<UWMTGGTCNFQ> a, IdArray<UWMTGGTCNFQ, Term> b, Id32<UWMTGGTCNFQ>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface TJKHEENBPWS : IEquatable<TJKHEENBPWS>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind DAPXUDJAJEL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<UWMTGGTCNFQ> RLRVXXCFROX
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		TJKHEENBPWS AUHFZFKUQNU
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		TJKHEENBPWS SMGOLFAOIVF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class NBUMAIHTETV : TJKHEENBPWS, IEquatable<TJKHEENBPWS>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly TJKHEENBPWS FDCKRPNUPSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly TJKHEENBPWS GVVPWVSHOTK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind DAPXUDJAJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<UWMTGGTCNFQ> YKEGSPPJXLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BDE880", Offset = "0x2BDD280", VA = "0x182BDE880", Slot = "5")]
			get
			{
				return default(Id32<UWMTGGTCNFQ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private TJKHEENBPWS VIYOMQGVJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private TJKHEENBPWS SUJRNQKJGYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD13C40", Offset = "0xD12640", VA = "0x180D13C40")]
		private NBUMAIHTETV(TJKHEENBPWS a, TJKHEENBPWS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE750", Offset = "0x2BDD150", VA = "0x182BDE750")]
		public static NBUMAIHTETV New(TJKHEENBPWS from, TJKHEENBPWS to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE5D0", Offset = "0x2BDCFD0", VA = "0x182BDE5D0", Slot = "8")]
		public bool Equals(TJKHEENBPWS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE7D0", Offset = "0x2BDD1D0", VA = "0x182BDE7D0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class KLRFVMQOVUZ : TJKHEENBPWS, IEquatable<TJKHEENBPWS>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<UWMTGGTCNFQ> PGGBLURLEPI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind DAPXUDJAJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<UWMTGGTCNFQ> YKEGSPPJXLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110", Slot = "5")]
			get
			{
				return default(Id32<UWMTGGTCNFQ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private TJKHEENBPWS VIYOMQGVJIN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BDE490", Offset = "0x2BDCE90", VA = "0x182BDE490", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private TJKHEENBPWS SUJRNQKJGYA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BDE540", Offset = "0x2BDCF40", VA = "0x182BDE540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x116ABD0", Offset = "0x11695D0", VA = "0x18116ABD0")]
		private KLRFVMQOVUZ(Id32<UWMTGGTCNFQ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE4E0", Offset = "0x2BDCEE0", VA = "0x182BDE4E0")]
		public static KLRFVMQOVUZ New(Id32<UWMTGGTCNFQ> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE370", Offset = "0x2BDCD70", VA = "0x182BDE370", Slot = "8")]
		public bool Equals(TJKHEENBPWS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE590", Offset = "0x2BDCF90", VA = "0x182BDE590", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class GEMTJDXWSYD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<UWMTGGTCNFQ> CRWLHSKOIBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<UWMTGGTCNFQ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public TJKHEENBPWS PGGBLURLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x10B08A0", Offset = "0x10AF2A0", VA = "0x1810B08A0")]
		private GEMTJDXWSYD(Id32<UWMTGGTCNFQ> a, TJKHEENBPWS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDDF0", Offset = "0x2BDC7F0", VA = "0x182BDDDF0")]
		public static Result<GEMTJDXWSYD, TDAXDIBDDUE> MFLPBBQARJV([In] Substitution substitution, IdArray<UWMTGGTCNFQ, Term> a, Id32<UWMTGGTCNFQ>[] b, IdArray<UWMTGGTCNFQ, bool> c)
		{
			return default(Result<GEMTJDXWSYD, TDAXDIBDDUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE020", Offset = "0x2BDCA20", VA = "0x182BDE020")]
		private static Result<TJKHEENBPWS, TDAXDIBDDUE> VAXUGYIYYKN(Id32<UWMTGGTCNFQ> a, IdArray<UWMTGGTCNFQ, Term> b, Id32<UWMTGGTCNFQ>[] c, IdArray<UWMTGGTCNFQ, bool> d)
		{
			return default(Result<TJKHEENBPWS, TDAXDIBDDUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BDDFB0", Offset = "0x2BDC9B0", VA = "0x182BDDFB0", Slot = "3")]
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
