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
	public interface MCUQWFOUSFS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates CDQYILGDNLR(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class YANHZHOKSRP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC8F0", Offset = "0x2BABCF0", VA = "0x182BAC8F0")]
		public static Id32<UGRFIELSMCH> FWLRTXPPSWZ(this int a)
		{
			return default(Id32<UGRFIELSMCH>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class UGRFIELSMCH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class HYAVFGWCYIU : OKJLNQTBITD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BABA60", Offset = "0x2BAAE60", VA = "0x182BABA60", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BABA90", Offset = "0x2BAAE90", VA = "0x182BABA90")]
		public HYAVFGWCYIU()
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
			[Cpp2IlInjected.Address(RVA = "0x2BAB730", Offset = "0x2BAAB30", VA = "0x182BAB730")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BAB7A0", Offset = "0x2BAABA0", VA = "0x182BAB7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BAB8C0", Offset = "0x2BAACC0", VA = "0x182BAB8C0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB800", Offset = "0x2BAAC00", VA = "0x182BAB800")]
		public static ApplyConstraintResult YPJKUBZHRHK([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB890", Offset = "0x2BAAC90", VA = "0x182BAB890")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB7B0", Offset = "0x2BAABB0", VA = "0x182BAB7B0")]
		public static ApplyConstraintResult BTMEQNEBZEN([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB880", Offset = "0x2BAAC80", VA = "0x182BAB880")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB7E0", Offset = "0x2BAABE0", VA = "0x182BAB7E0")]
		public static ApplyConstraintResult NVDMPGPNDUU()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<UGRFIELSMCH> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<UGRFIELSMCH> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
		private Arrow(Id32<UGRFIELSMCH> from, Id32<UGRFIELSMCH> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D770", Offset = "0x2B8CB70", VA = "0x182B8D770")]
		public static Arrow New(Id32<UGRFIELSMCH> from, Id32<UGRFIELSMCH> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB940", Offset = "0x2BAAD40", VA = "0x182BAB940", Slot = "3")]
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
		public readonly Id32<UGRFIELSMCH> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<UGRFIELSMCH> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
		private Constraint(Id32<UGRFIELSMCH> lhs, Id32<UGRFIELSMCH> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D770", Offset = "0x2B8CB70", VA = "0x182B8D770")]
		public static Constraint New(Id32<UGRFIELSMCH> lhs, Id32<UGRFIELSMCH> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB9D0", Offset = "0x2BAADD0", VA = "0x182BAB9D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class AXGMDHAQWFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB570", Offset = "0x2BAA970", VA = "0x182BAB570")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<UGRFIELSMCH, Term> terms, Id32<UGRFIELSMCH>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<UGRFIELSMCH> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<UGRFIELSMCH> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEC94D0", Offset = "0xEC88D0", VA = "0x180EC94D0")]
		private Substitution(Id32<UGRFIELSMCH> identifier, Id32<UGRFIELSMCH> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D770", Offset = "0x2B8CB70", VA = "0x182B8D770")]
		public static Substitution New(Id32<UGRFIELSMCH> identifier, Id32<UGRFIELSMCH> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC740", Offset = "0x2BABB40", VA = "0x182BAC740", Slot = "3")]
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
			public readonly Id32<UGRFIELSMCH> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BAC7E0", Offset = "0x2BABBE0", VA = "0x182BAC7E0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BAC7D0", Offset = "0x2BABBD0", VA = "0x182BAC7D0")]
			public TermImpl(Id32<UGRFIELSMCH> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2BAC8E0", Offset = "0x2BABCE0", VA = "0x182BAC8E0")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC7F0", Offset = "0x2BABBF0", VA = "0x182BAC7F0")]
		public static Term PCROAQVHZHX([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC8C0", Offset = "0x2BABCC0", VA = "0x182BAC8C0")]
		private Term(Id32<UGRFIELSMCH> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC810", Offset = "0x2BABC10", VA = "0x182BAC810")]
		public static Term TXBXQSZSUAD(Id32<UGRFIELSMCH> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC830", Offset = "0x2BABC30", VA = "0x182BAC830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ZETIEVUQTQH<a, b> where b : MCUQWFOUSFS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QXLRGRRVYAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<UGRFIELSMCH, Term> GKCNPOUWRGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<UGRFIELSMCH>[] UBSZRRWYZEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<UGRFIELSMCH, bool> KSNCAZWEZZA;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public QXLRGRRVYAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x76750E0", Offset = "0x76744E0", VA = "0x1876750E0")]
			internal Result<SRIWBTQKVAG, OKJLNQTBITD> WDKNXAVQKDI(Substitution a)
			{
				return default(Result<SRIWBTQKVAG, OKJLNQTBITD>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> PDWOGROJANU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> GIIJOLBZMUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b RATSQORCBWB;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x508A7E0", Offset = "0x5089BE0", VA = "0x18508A7E0")]
		protected ZETIEVUQTQH([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5089630", Offset = "0x5088A30", VA = "0x185089630")]
		public static ZETIEVUQTQH<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5088FF0", Offset = "0x50883F0", VA = "0x185088FF0")]
		public Id32<UGRFIELSMCH> AZVFNJJDGZI()
		{
			return default(Id32<UGRFIELSMCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x50894F0", Offset = "0x50888F0", VA = "0x1850894F0")]
		public Id32<UGRFIELSMCH> MQWCZGVZKIL(Id32<UGRFIELSMCH> a, Id32<UGRFIELSMCH> b)
		{
			return default(Id32<UGRFIELSMCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD59D60", Offset = "0xD59160", VA = "0x180D59D60")]
		public Id32<UGRFIELSMCH> IHPMWMULMXH(Id32<UGRFIELSMCH> a)
		{
			return default(Id32<UGRFIELSMCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5089270", Offset = "0x5088670", VA = "0x185089270")]
		public void DAHZITFHSEV(Id32<UGRFIELSMCH> a, Id32<UGRFIELSMCH> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5089810", Offset = "0x5088C10", VA = "0x185089810")]
		public Result<SRIWBTQKVAG[], OKJLNQTBITD> Solve([In] a root)
		{
			return default(Result<SRIWBTQKVAG[], OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5089800", Offset = "0x5088C00", VA = "0x185089800")]
		public HNLHWIOTSUH PCLDEWALJYY(Id32<UGRFIELSMCH> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class OXLQSPYWGVX
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC000", Offset = "0x2BAB400", VA = "0x182BAC000")]
		internal static Term UUXWGUKJAIA(Id32<UGRFIELSMCH> a, IdArray<UGRFIELSMCH, Term> b, Id32<UGRFIELSMCH>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface HNLHWIOTSUH : IEquatable<HNLHWIOTSUH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind NDBCZWHGVDW
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<UGRFIELSMCH> ZQMQXINVVYE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HNLHWIOTSUH ZMTTNMIVJJB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		HNLHWIOTSUH HWXGDMVKAIG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class LFDAWCRRAEY : HNLHWIOTSUH, IEquatable<HNLHWIOTSUH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly HNLHWIOTSUH OURBHQIYNOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly HNLHWIOTSUH CVFJVRRANFF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind NDBCZWHGVDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<UGRFIELSMCH> JPEVDSOASVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BABD00", Offset = "0x2BAB100", VA = "0x182BABD00", Slot = "5")]
			get
			{
				return default(Id32<UGRFIELSMCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private HNLHWIOTSUH AZDFVDUGJEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HNLHWIOTSUH CIRKSLLLHWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xCFB220", Offset = "0xCFA620", VA = "0x180CFB220")]
		private LFDAWCRRAEY(HNLHWIOTSUH a, HNLHWIOTSUH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BABED0", Offset = "0x2BAB2D0", VA = "0x182BABED0")]
		public static LFDAWCRRAEY New(HNLHWIOTSUH from, HNLHWIOTSUH to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BABD50", Offset = "0x2BAB150", VA = "0x182BABD50", Slot = "8")]
		public bool Equals(HNLHWIOTSUH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BABF50", Offset = "0x2BAB350", VA = "0x182BABF50", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class JDWDPAZJKZO : HNLHWIOTSUH, IEquatable<HNLHWIOTSUH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<UGRFIELSMCH> FCAQLXAUMLJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind NDBCZWHGVDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<UGRFIELSMCH> JPEVDSOASVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110", Slot = "5")]
			get
			{
				return default(Id32<UGRFIELSMCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private HNLHWIOTSUH AZDFVDUGJEO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BABBC0", Offset = "0x2BAAFC0", VA = "0x182BABBC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private HNLHWIOTSUH CIRKSLLLHWT
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BABC10", Offset = "0x2BAB010", VA = "0x182BABC10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x112DEF0", Offset = "0x112D2F0", VA = "0x18112DEF0")]
		private JDWDPAZJKZO(Id32<UGRFIELSMCH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BABC60", Offset = "0x2BAB060", VA = "0x182BABC60")]
		public static JDWDPAZJKZO New(Id32<UGRFIELSMCH> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BABAA0", Offset = "0x2BAAEA0", VA = "0x182BABAA0", Slot = "8")]
		public bool Equals(HNLHWIOTSUH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BABCC0", Offset = "0x2BAB0C0", VA = "0x182BABCC0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class SRIWBTQKVAG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<UGRFIELSMCH> SGYXLDBUDMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<UGRFIELSMCH>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCFB380", Offset = "0xCFA780", VA = "0x180CFB380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HNLHWIOTSUH FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x10920F0", Offset = "0x10914F0", VA = "0x1810920F0")]
		private SRIWBTQKVAG(Id32<UGRFIELSMCH> a, HNLHWIOTSUH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC580", Offset = "0x2BAB980", VA = "0x182BAC580")]
		public static Result<SRIWBTQKVAG, OKJLNQTBITD> UCIQVMCKUIS([In] Substitution substitution, IdArray<UGRFIELSMCH, Term> a, Id32<UGRFIELSMCH>[] b, IdArray<UGRFIELSMCH, bool> c)
		{
			return default(Result<SRIWBTQKVAG, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC200", Offset = "0x2BAB600", VA = "0x182BAC200")]
		private static Result<HNLHWIOTSUH, OKJLNQTBITD> MPWLRCZVNHS(Id32<UGRFIELSMCH> a, IdArray<UGRFIELSMCH, Term> b, Id32<UGRFIELSMCH>[] c, IdArray<UGRFIELSMCH, bool> d)
		{
			return default(Result<HNLHWIOTSUH, OKJLNQTBITD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC510", Offset = "0x2BAB910", VA = "0x182BAC510", Slot = "3")]
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
