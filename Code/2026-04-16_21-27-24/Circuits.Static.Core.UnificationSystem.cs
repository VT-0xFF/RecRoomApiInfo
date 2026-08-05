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
		[Cpp2IlInjected.Address(RVA = "0x2BA0BD0", Offset = "0x2B9F9D0", VA = "0x182BA0BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA02C0", Offset = "0x2B9F0C0", VA = "0x182BA02C0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BA02F0", Offset = "0x2B9F0F0", VA = "0x182BA02F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9F850", Offset = "0x2B9E650", VA = "0x182B9F850")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F8C0", Offset = "0x2B9E6C0", VA = "0x182B9F8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9F9E0", Offset = "0x2B9E7E0", VA = "0x182B9F9E0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F8D0", Offset = "0x2B9E6D0", VA = "0x182B9F8D0")]
		public static ApplyConstraintResult BXRHJRELUSP([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F9B0", Offset = "0x2B9E7B0", VA = "0x182B9F9B0")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F950", Offset = "0x2B9E750", VA = "0x182B9F950")]
		public static ApplyConstraintResult VIJGYRJVTGQ([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F9A0", Offset = "0x2B9E7A0", VA = "0x182B9F9A0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F980", Offset = "0x2B9E780", VA = "0x182B9F980")]
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
		[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
		private Arrow(Id32<UWMTGGTCNFQ> from, Id32<UWMTGGTCNFQ> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B81560", Offset = "0x2B80360", VA = "0x182B81560")]
		public static Arrow New(Id32<UWMTGGTCNFQ> from, Id32<UWMTGGTCNFQ> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FA60", Offset = "0x2B9E860", VA = "0x182B9FA60", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
		private Constraint(Id32<UWMTGGTCNFQ> lhs, Id32<UWMTGGTCNFQ> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B81560", Offset = "0x2B80360", VA = "0x182B81560")]
		public static Constraint New(Id32<UWMTGGTCNFQ> lhs, Id32<UWMTGGTCNFQ> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FAF0", Offset = "0x2B9E8F0", VA = "0x182B9FAF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class NWWTBDFUGWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0860", Offset = "0x2B9F660", VA = "0x182BA0860")]
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
		[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
		private Substitution(Id32<UWMTGGTCNFQ> identifier, Id32<UWMTGGTCNFQ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B81560", Offset = "0x2B80360", VA = "0x182B81560")]
		public static Substitution New(Id32<UWMTGGTCNFQ> identifier, Id32<UWMTGGTCNFQ> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0A20", Offset = "0x2B9F820", VA = "0x182BA0A20", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA0AB0", Offset = "0x2B9F8B0", VA = "0x182BA0AB0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0AC0", Offset = "0x2B9F8C0", VA = "0x182BA0AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA0BC0", Offset = "0x2B9F9C0", VA = "0x182BA0BC0")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0AF0", Offset = "0x2B9F8F0", VA = "0x182BA0AF0")]
		public static Term MQRRTTWZXFA([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0BA0", Offset = "0x2B9F9A0", VA = "0x182BA0BA0")]
		private Term(Id32<UWMTGGTCNFQ> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0AD0", Offset = "0x2B9F8D0", VA = "0x182BA0AD0")]
		public static Term KPRJPLIVJRY(Id32<UWMTGGTCNFQ> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0B10", Offset = "0x2B9F910", VA = "0x182BA0B10", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UACGPVXXMUQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7CCE040", Offset = "0x7CCCE40", VA = "0x187CCE040")]
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
		[Cpp2IlInjected.Address(RVA = "0x6593A60", Offset = "0x6592860", VA = "0x186593A60")]
		protected IUHXJXDREZU([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6592170", Offset = "0x6590F70", VA = "0x186592170")]
		public static IUHXJXDREZU<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6592290", Offset = "0x6591090", VA = "0x186592290")]
		public Id32<UWMTGGTCNFQ> QSKXGXAIHLJ()
		{
			return default(Id32<UWMTGGTCNFQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6593770", Offset = "0x6592570", VA = "0x186593770")]
		public Id32<UWMTGGTCNFQ> WELXHLDHVBM(Id32<UWMTGGTCNFQ> a, Id32<UWMTGGTCNFQ> b)
		{
			return default(Id32<UWMTGGTCNFQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD4BB70", Offset = "0xD4A970", VA = "0x180D4BB70")]
		public Id32<UWMTGGTCNFQ> VQRUGTSIEYC(Id32<UWMTGGTCNFQ> a)
		{
			return default(Id32<UWMTGGTCNFQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6593590", Offset = "0x6592390", VA = "0x186593590")]
		public void TCOVDVSZKHQ(Id32<UWMTGGTCNFQ> a, Id32<UWMTGGTCNFQ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6592510", Offset = "0x6591310", VA = "0x186592510")]
		public Result<GEMTJDXWSYD[], TDAXDIBDDUE> Solve([In] a root)
		{
			return default(Result<GEMTJDXWSYD[], TDAXDIBDDUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x65920B0", Offset = "0x6590EB0", VA = "0x1865920B0")]
		public TJKHEENBPWS CEMLEZTSGAL(Id32<UWMTGGTCNFQ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FIPHGMPWSRO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB80", Offset = "0x2B9E980", VA = "0x182B9FB80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<UWMTGGTCNFQ> YKEGSPPJXLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0810", Offset = "0x2B9F610", VA = "0x182BA0810", Slot = "5")]
			get
			{
				return default(Id32<UWMTGGTCNFQ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private TJKHEENBPWS VIYOMQGVJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private TJKHEENBPWS SUJRNQKJGYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xCE9C40", Offset = "0xCE8A40", VA = "0x180CE9C40")]
		private NBUMAIHTETV(TJKHEENBPWS a, TJKHEENBPWS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA06E0", Offset = "0x2B9F4E0", VA = "0x182BA06E0")]
		public static NBUMAIHTETV New(TJKHEENBPWS from, TJKHEENBPWS to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0560", Offset = "0x2B9F360", VA = "0x182BA0560", Slot = "8")]
		public bool Equals(TJKHEENBPWS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0760", Offset = "0x2B9F560", VA = "0x182BA0760", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<UWMTGGTCNFQ> YKEGSPPJXLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110", Slot = "5")]
			get
			{
				return default(Id32<UWMTGGTCNFQ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private TJKHEENBPWS VIYOMQGVJIN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA0420", Offset = "0x2B9F220", VA = "0x182BA0420", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private TJKHEENBPWS SUJRNQKJGYA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA04D0", Offset = "0x2B9F2D0", VA = "0x182BA04D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1117DC0", Offset = "0x1116BC0", VA = "0x181117DC0")]
		private KLRFVMQOVUZ(Id32<UWMTGGTCNFQ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0470", Offset = "0x2B9F270", VA = "0x182BA0470")]
		public static KLRFVMQOVUZ New(Id32<UWMTGGTCNFQ> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0300", Offset = "0x2B9F100", VA = "0x182BA0300", Slot = "8")]
		public bool Equals(TJKHEENBPWS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0520", Offset = "0x2B9F320", VA = "0x182BA0520", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<UWMTGGTCNFQ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCE8F30", Offset = "0xCE7D30", VA = "0x180CE8F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public TJKHEENBPWS PGGBLURLEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1087AC0", Offset = "0x10868C0", VA = "0x181087AC0")]
		private GEMTJDXWSYD(Id32<UWMTGGTCNFQ> a, TJKHEENBPWS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FD80", Offset = "0x2B9EB80", VA = "0x182B9FD80")]
		public static Result<GEMTJDXWSYD, TDAXDIBDDUE> MFLPBBQARJV([In] Substitution substitution, IdArray<UWMTGGTCNFQ, Term> a, Id32<UWMTGGTCNFQ>[] b, IdArray<UWMTGGTCNFQ, bool> c)
		{
			return default(Result<GEMTJDXWSYD, TDAXDIBDDUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FFB0", Offset = "0x2B9EDB0", VA = "0x182B9FFB0")]
		private static Result<TJKHEENBPWS, TDAXDIBDDUE> VAXUGYIYYKN(Id32<UWMTGGTCNFQ> a, IdArray<UWMTGGTCNFQ, Term> b, Id32<UWMTGGTCNFQ>[] c, IdArray<UWMTGGTCNFQ, bool> d)
		{
			return default(Result<TJKHEENBPWS, TDAXDIBDDUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FF40", Offset = "0x2B9ED40", VA = "0x182B9FF40", Slot = "3")]
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
