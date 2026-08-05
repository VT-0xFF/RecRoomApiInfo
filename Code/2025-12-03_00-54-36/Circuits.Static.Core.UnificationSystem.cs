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
	public interface LGJNITTFOIP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates MNEMFNCTKJM(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class JZTUIHVVDEU
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28D3140", Offset = "0x28D1D40", VA = "0x1828D3140")]
		public static Id32<GDSKMIQQYAM> PWPCGEIOESA(this int a)
		{
			return default(Id32<GDSKMIQQYAM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class GDSKMIQQYAM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class WHDFPUTGNAV : DOTNMKZGUXE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28D34F0", Offset = "0x28D20F0", VA = "0x1828D34F0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28D3520", Offset = "0x28D2120", VA = "0x1828D3520")]
		public WHDFPUTGNAV()
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
			[Cpp2IlInjected.Address(RVA = "0x28D2170", Offset = "0x28D0D70", VA = "0x1828D2170")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28D21E0", Offset = "0x28D0DE0", VA = "0x1828D21E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D2300", Offset = "0x28D0F00", VA = "0x1828D2300")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28D2220", Offset = "0x28D0E20", VA = "0x1828D2220")]
		public static ApplyConstraintResult ZBCTZNAUDZH([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28D22D0", Offset = "0x28D0ED0", VA = "0x1828D22D0")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28D21F0", Offset = "0x28D0DF0", VA = "0x1828D21F0")]
		public static ApplyConstraintResult DIUCXBHQHMC([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28D22C0", Offset = "0x28D0EC0", VA = "0x1828D22C0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28D22A0", Offset = "0x28D0EA0", VA = "0x1828D22A0")]
		public static ApplyConstraintResult ZXWLDBQWQXF()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<GDSKMIQQYAM> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<GDSKMIQQYAM> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
		private Arrow(Id32<GDSKMIQQYAM> from, Id32<GDSKMIQQYAM> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA60", Offset = "0x28BA660", VA = "0x1828BBA60")]
		public static Arrow New(Id32<GDSKMIQQYAM> from, Id32<GDSKMIQQYAM> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28D2380", Offset = "0x28D0F80", VA = "0x1828D2380", Slot = "3")]
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
		public readonly Id32<GDSKMIQQYAM> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<GDSKMIQQYAM> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
		private Constraint(Id32<GDSKMIQQYAM> lhs, Id32<GDSKMIQQYAM> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA60", Offset = "0x28BA660", VA = "0x1828BBA60")]
		public static Constraint New(Id32<GDSKMIQQYAM> lhs, Id32<GDSKMIQQYAM> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28D2710", Offset = "0x28D1310", VA = "0x1828D2710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class LFSZUELTLNR
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28D3180", Offset = "0x28D1D80", VA = "0x1828D3180")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<GDSKMIQQYAM, Term> terms, Id32<GDSKMIQQYAM>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<GDSKMIQQYAM> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<GDSKMIQQYAM> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBAA8D0", Offset = "0xBA94D0", VA = "0x180BAA8D0")]
		private Substitution(Id32<GDSKMIQQYAM> identifier, Id32<GDSKMIQQYAM> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA60", Offset = "0x28BA660", VA = "0x1828BBA60")]
		public static Substitution New(Id32<GDSKMIQQYAM> identifier, Id32<GDSKMIQQYAM> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28D3340", Offset = "0x28D1F40", VA = "0x1828D3340", Slot = "3")]
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
			public readonly Id32<GDSKMIQQYAM> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28D33D0", Offset = "0x28D1FD0", VA = "0x1828D33D0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x28D33E0", Offset = "0x28D1FE0", VA = "0x1828D33E0")]
			public TermImpl(Id32<GDSKMIQQYAM> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x28D34E0", Offset = "0x28D20E0", VA = "0x1828D34E0")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28D33F0", Offset = "0x28D1FF0", VA = "0x1828D33F0")]
		public static Term FJFHWVEORKM([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28D34C0", Offset = "0x28D20C0", VA = "0x1828D34C0")]
		private Term(Id32<GDSKMIQQYAM> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28D3410", Offset = "0x28D2010", VA = "0x1828D3410")]
		public static Term ILCRUJBBJJG(Id32<GDSKMIQQYAM> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28D3430", Offset = "0x28D2030", VA = "0x1828D3430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class YZBZFTIAKZS<a, b> where b : LGJNITTFOIP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KZRZTSLLDPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<GDSKMIQQYAM, Term> VYAIMWLQIXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<GDSKMIQQYAM>[] WVWUERYNVBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<GDSKMIQQYAM, bool> MXDDLJECGEV;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KZRZTSLLDPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x519DA60", Offset = "0x519C660", VA = "0x18519DA60")]
			internal Result<JKFJJGERAHP, DOTNMKZGUXE> DZIICYSRFOZ(Substitution a)
			{
				return default(Result<JKFJJGERAHP, DOTNMKZGUXE>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> OHQEWVBGCAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> YCHRPGSYDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b GSCBNDREEJU;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8BD40", Offset = "0x3E8A940", VA = "0x183E8BD40")]
		protected YZBZFTIAKZS([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8ABA0", Offset = "0x3E897A0", VA = "0x183E8ABA0")]
		public static YZBZFTIAKZS<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A670", Offset = "0x3E89270", VA = "0x183E8A670")]
		public Id32<GDSKMIQQYAM> GDGAUWNSWQF()
		{
			return default(Id32<GDSKMIQQYAM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AA60", Offset = "0x3E89660", VA = "0x183E8AA60")]
		public Id32<GDSKMIQQYAM> KSYGRZQLSSQ(Id32<GDSKMIQQYAM> a, Id32<GDSKMIQQYAM> b)
		{
			return default(Id32<GDSKMIQQYAM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAF7520", Offset = "0xAF6120", VA = "0x180AF7520")]
		public Id32<GDSKMIQQYAM> QVFKYLVNLHS(Id32<GDSKMIQQYAM> a)
		{
			return default(Id32<GDSKMIQQYAM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A560", Offset = "0x3E89160", VA = "0x183E8A560")]
		public void ETKFTFUXFFO(Id32<GDSKMIQQYAM> a, Id32<GDSKMIQQYAM> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AD80", Offset = "0x3E89980", VA = "0x183E8AD80")]
		public Result<JKFJJGERAHP[], DOTNMKZGUXE> Solve([In] a root)
		{
			return default(Result<JKFJJGERAHP[], DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AD70", Offset = "0x3E89970", VA = "0x183E8AD70")]
		public LXVHPNPEAOE QKKJQACNWSV(Id32<GDSKMIQQYAM> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JGXRTWEINKS
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28D2A00", Offset = "0x28D1600", VA = "0x1828D2A00")]
		internal static Term DGGRTPBANHB(Id32<GDSKMIQQYAM> a, IdArray<GDSKMIQQYAM, Term> b, Id32<GDSKMIQQYAM>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface LXVHPNPEAOE : IEquatable<LXVHPNPEAOE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind JNGPBCCCNLL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<GDSKMIQQYAM> GSXLGZMTVIF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		LXVHPNPEAOE GIZRYKFHOCY
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		LXVHPNPEAOE OKIBATDUYPX
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class BZGWQDKRZRP : LXVHPNPEAOE, IEquatable<LXVHPNPEAOE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly LXVHPNPEAOE IGITJHYKXWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly LXVHPNPEAOE PNYOMCXPLGC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind JNGPBCCCNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<GDSKMIQQYAM> VMUEFGRMOBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x28D26C0", Offset = "0x28D12C0", VA = "0x1828D26C0", Slot = "5")]
			get
			{
				return default(Id32<GDSKMIQQYAM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private LXVHPNPEAOE JBVIDCVGEGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LXVHPNPEAOE NOYSRORWWOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA99D10", Offset = "0xA98910", VA = "0x180A99D10")]
		private BZGWQDKRZRP(LXVHPNPEAOE a, LXVHPNPEAOE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28D2590", Offset = "0x28D1190", VA = "0x1828D2590")]
		public static BZGWQDKRZRP New(LXVHPNPEAOE from, LXVHPNPEAOE to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28D2410", Offset = "0x28D1010", VA = "0x1828D2410", Slot = "8")]
		public bool Equals(LXVHPNPEAOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28D2610", Offset = "0x28D1210", VA = "0x1828D2610", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class DZCOSLXNDQD : LXVHPNPEAOE, IEquatable<LXVHPNPEAOE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<GDSKMIQQYAM> KBCQUAEOSXO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind JNGPBCCCNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<GDSKMIQQYAM> VMUEFGRMOBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA95110", Offset = "0xA93D10", VA = "0x180A95110", Slot = "5")]
			get
			{
				return default(Id32<GDSKMIQQYAM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private LXVHPNPEAOE JBVIDCVGEGX
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x28D28C0", Offset = "0x28D14C0", VA = "0x1828D28C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private LXVHPNPEAOE NOYSRORWWOG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x28D2970", Offset = "0x28D1570", VA = "0x1828D2970", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xE2E5C0", Offset = "0xE2D1C0", VA = "0x180E2E5C0")]
		private DZCOSLXNDQD(Id32<GDSKMIQQYAM> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28D2910", Offset = "0x28D1510", VA = "0x1828D2910")]
		public static DZCOSLXNDQD New(Id32<GDSKMIQQYAM> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28D27A0", Offset = "0x28D13A0", VA = "0x1828D27A0", Slot = "8")]
		public bool Equals(LXVHPNPEAOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28D29C0", Offset = "0x28D15C0", VA = "0x1828D29C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class JKFJJGERAHP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<GDSKMIQQYAM> HSLXDBEEAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA95110", Offset = "0xA93D10", VA = "0x180A95110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GDSKMIQQYAM>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA2D20", Offset = "0xAA1920", VA = "0x180AA2D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LXVHPNPEAOE KBCQUAEOSXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xD96FE0", Offset = "0xD95BE0", VA = "0x180D96FE0")]
		private JKFJJGERAHP(Id32<GDSKMIQQYAM> a, LXVHPNPEAOE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28D2F80", Offset = "0x28D1B80", VA = "0x1828D2F80")]
		public static Result<JKFJJGERAHP, DOTNMKZGUXE> VJJIGOCPYCN([In] Substitution substitution, IdArray<GDSKMIQQYAM, Term> a, Id32<GDSKMIQQYAM>[] b, IdArray<GDSKMIQQYAM, bool> c)
		{
			return default(Result<JKFJJGERAHP, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28D2C70", Offset = "0x28D1870", VA = "0x1828D2C70")]
		private static Result<LXVHPNPEAOE, DOTNMKZGUXE> UUJIZYLFBNB(Id32<GDSKMIQQYAM> a, IdArray<GDSKMIQQYAM, Term> b, Id32<GDSKMIQQYAM>[] c, IdArray<GDSKMIQQYAM, bool> d)
		{
			return default(Result<LXVHPNPEAOE, DOTNMKZGUXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28D2C00", Offset = "0x28D1800", VA = "0x1828D2C00", Slot = "3")]
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
