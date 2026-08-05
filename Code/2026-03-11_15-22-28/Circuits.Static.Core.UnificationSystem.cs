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
	public interface GJBEFWGGCMP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates JLMTPEBOOEG(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class HMDSZQHVIAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x294B400", Offset = "0x294A400", VA = "0x18294B400")]
		public static Id32<TAKJGNICNJO> XFQJHTOEZYQ(this int a)
		{
			return default(Id32<TAKJGNICNJO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class TAKJGNICNJO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class XIUJWEBYCMJ : DEINNYDYQPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x294BD50", Offset = "0x294AD50", VA = "0x18294BD50", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x294BD80", Offset = "0x294AD80", VA = "0x18294BD80")]
		public XIUJWEBYCMJ()
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
			[Cpp2IlInjected.Address(RVA = "0x294AF10", Offset = "0x2949F10", VA = "0x18294AF10")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x294AF80", Offset = "0x2949F80", VA = "0x18294AF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x294B0A0", Offset = "0x294A0A0", VA = "0x18294B0A0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x294AF90", Offset = "0x2949F90", VA = "0x18294AF90")]
		public static ApplyConstraintResult DJBGPJPXCOR([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x294B070", Offset = "0x294A070", VA = "0x18294B070")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x294B030", Offset = "0x294A030", VA = "0x18294B030")]
		public static ApplyConstraintResult FNWQQJHJICK([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x294B060", Offset = "0x294A060", VA = "0x18294B060")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x294B010", Offset = "0x294A010", VA = "0x18294B010")]
		public static ApplyConstraintResult DNGGORVRONZ()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<TAKJGNICNJO> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<TAKJGNICNJO> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
		private Arrow(Id32<TAKJGNICNJO> from, Id32<TAKJGNICNJO> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x292D160", Offset = "0x292C160", VA = "0x18292D160")]
		public static Arrow New(Id32<TAKJGNICNJO> from, Id32<TAKJGNICNJO> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x294B120", Offset = "0x294A120", VA = "0x18294B120", Slot = "3")]
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
		public readonly Id32<TAKJGNICNJO> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<TAKJGNICNJO> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
		private Constraint(Id32<TAKJGNICNJO> lhs, Id32<TAKJGNICNJO> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x292D160", Offset = "0x292C160", VA = "0x18292D160")]
		public static Constraint New(Id32<TAKJGNICNJO> lhs, Id32<TAKJGNICNJO> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x294B370", Offset = "0x294A370", VA = "0x18294B370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class CJMFDHSORWX
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x294B1B0", Offset = "0x294A1B0", VA = "0x18294B1B0")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<TAKJGNICNJO, Term> terms, Id32<TAKJGNICNJO>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<TAKJGNICNJO> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<TAKJGNICNJO> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC31DB0", Offset = "0xC30DB0", VA = "0x180C31DB0")]
		private Substitution(Id32<TAKJGNICNJO> identifier, Id32<TAKJGNICNJO> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x292D160", Offset = "0x292C160", VA = "0x18292D160")]
		public static Substitution New(Id32<TAKJGNICNJO> identifier, Id32<TAKJGNICNJO> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x294BBA0", Offset = "0x294ABA0", VA = "0x18294BBA0", Slot = "3")]
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
			public readonly Id32<TAKJGNICNJO> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x294BC30", Offset = "0x294AC30", VA = "0x18294BC30")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x294BC40", Offset = "0x294AC40", VA = "0x18294BC40")]
			public TermImpl(Id32<TAKJGNICNJO> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x294BD40", Offset = "0x294AD40", VA = "0x18294BD40")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x294BC50", Offset = "0x294AC50", VA = "0x18294BC50")]
		public static Term CQNQRMKSTUQ([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x294BD20", Offset = "0x294AD20", VA = "0x18294BD20")]
		private Term(Id32<TAKJGNICNJO> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x294BC70", Offset = "0x294AC70", VA = "0x18294BC70")]
		public static Term DQHQMFSGDGE(Id32<TAKJGNICNJO> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x294BC90", Offset = "0x294AC90", VA = "0x18294BC90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class QBZHVCMWOZC<a, b> where b : GJBEFWGGCMP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class RMSRXUIDDBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<TAKJGNICNJO, Term> IYOQSZOYXZU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<TAKJGNICNJO>[] VSRSUBXYMOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<TAKJGNICNJO, bool> TAXZXVNVTOF;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public RMSRXUIDDBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E7EE10", Offset = "0x5E7DE10", VA = "0x185E7EE10")]
			internal Result<ZOLJBPUKJXT, DEINNYDYQPE> FLSOPZNQGBP(Substitution a)
			{
				return default(Result<ZOLJBPUKJXT, DEINNYDYQPE>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> YBZWKLFITMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> MYZSICEFXJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b USEUOEMXTCW;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E35E90", Offset = "0x5E34E90", VA = "0x185E35E90")]
		protected QBZHVCMWOZC([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E348C0", Offset = "0x5E338C0", VA = "0x185E348C0")]
		public static QBZHVCMWOZC<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E345D0", Offset = "0x5E335D0", VA = "0x185E345D0")]
		public Id32<TAKJGNICNJO> AYGWUIXZKFL()
		{
			return default(Id32<TAKJGNICNJO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E35BA0", Offset = "0x5E34BA0", VA = "0x185E35BA0")]
		public Id32<TAKJGNICNJO> TIPTQVBDGGY(Id32<TAKJGNICNJO> a, Id32<TAKJGNICNJO> b)
		{
			return default(Id32<TAKJGNICNJO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB30F60", Offset = "0xB2FF60", VA = "0x180B30F60")]
		public Id32<TAKJGNICNJO> LFCZHHAXZHK(Id32<TAKJGNICNJO> a)
		{
			return default(Id32<TAKJGNICNJO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E34790", Offset = "0x5E33790", VA = "0x185E34790")]
		public void CHMJHPORAKA(Id32<TAKJGNICNJO> a, Id32<TAKJGNICNJO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E34A00", Offset = "0x5E33A00", VA = "0x185E34A00")]
		public Result<ZOLJBPUKJXT[], DEINNYDYQPE> Solve([In] a root)
		{
			return default(Result<ZOLJBPUKJXT[], DEINNYDYQPE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E349F0", Offset = "0x5E339F0", VA = "0x185E349F0")]
		public LHXOXHRKKRO QIZSNJWAHTP(Id32<TAKJGNICNJO> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class IVVVLTBFEUK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x294B440", Offset = "0x294A440", VA = "0x18294B440")]
		internal static Term RIGRHBBUKEL(Id32<TAKJGNICNJO> a, IdArray<TAKJGNICNJO, Term> b, Id32<TAKJGNICNJO>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface LHXOXHRKKRO : IEquatable<LHXOXHRKKRO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind GMGTQKAJVHL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<TAKJGNICNJO> ASVLBRVKSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		LHXOXHRKKRO CMAPWGKGRFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		LHXOXHRKKRO OUKZCMOOSLH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class QVJPOYNYHYJ : LHXOXHRKKRO, IEquatable<LHXOXHRKKRO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly LHXOXHRKKRO PHOFETWECBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly LHXOXHRKKRO UJZLQWRIOOO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind GMGTQKAJVHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<TAKJGNICNJO> AOUIERWCGYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x294B8A0", Offset = "0x294A8A0", VA = "0x18294B8A0", Slot = "5")]
			get
			{
				return default(Id32<TAKJGNICNJO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private LHXOXHRKKRO EACKRHQBGKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LHXOXHRKKRO NAZWOPRURAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xACA870", Offset = "0xAC9870", VA = "0x180ACA870")]
		private QVJPOYNYHYJ(LHXOXHRKKRO a, LHXOXHRKKRO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x294BA70", Offset = "0x294AA70", VA = "0x18294BA70")]
		public static QVJPOYNYHYJ New(LHXOXHRKKRO from, LHXOXHRKKRO to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x294B8F0", Offset = "0x294A8F0", VA = "0x18294B8F0", Slot = "8")]
		public bool Equals(LHXOXHRKKRO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x294BAF0", Offset = "0x294AAF0", VA = "0x18294BAF0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class KBSXGFWBLML : LHXOXHRKKRO, IEquatable<LHXOXHRKKRO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<TAKJGNICNJO> FNDQYUTZTLK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind GMGTQKAJVHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<TAKJGNICNJO> AOUIERWCGYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110", Slot = "5")]
			get
			{
				return default(Id32<TAKJGNICNJO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private LHXOXHRKKRO EACKRHQBGKP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x294B810", Offset = "0x294A810", VA = "0x18294B810", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private LHXOXHRKKRO NAZWOPRURAG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x294B760", Offset = "0x294A760", VA = "0x18294B760", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xEB7AD0", Offset = "0xEB6AD0", VA = "0x180EB7AD0")]
		private KBSXGFWBLML(Id32<TAKJGNICNJO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x294B7B0", Offset = "0x294A7B0", VA = "0x18294B7B0")]
		public static KBSXGFWBLML New(Id32<TAKJGNICNJO> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x294B640", Offset = "0x294A640", VA = "0x18294B640", Slot = "8")]
		public bool Equals(LHXOXHRKKRO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x294B860", Offset = "0x294A860", VA = "0x18294B860", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class ZOLJBPUKJXT
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<TAKJGNICNJO> TXKKVYGLDVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xACA110", Offset = "0xAC9110", VA = "0x180ACA110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<TAKJGNICNJO>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAD4F50", Offset = "0xAD3F50", VA = "0x180AD4F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LHXOXHRKKRO FNDQYUTZTLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F60", Offset = "0xAD1F60", VA = "0x180AD2F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE24C70", Offset = "0xE23C70", VA = "0x180E24C70")]
		private ZOLJBPUKJXT(Id32<TAKJGNICNJO> a, LHXOXHRKKRO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x294BD90", Offset = "0x294AD90", VA = "0x18294BD90")]
		public static Result<ZOLJBPUKJXT, DEINNYDYQPE> LXSJWAKQPBT([In] Substitution substitution, IdArray<TAKJGNICNJO, Term> a, Id32<TAKJGNICNJO>[] b, IdArray<TAKJGNICNJO, bool> c)
		{
			return default(Result<ZOLJBPUKJXT, DEINNYDYQPE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x294BFC0", Offset = "0x294AFC0", VA = "0x18294BFC0")]
		private static Result<LHXOXHRKKRO, DEINNYDYQPE> VZCEBWUXCXJ(Id32<TAKJGNICNJO> a, IdArray<TAKJGNICNJO, Term> b, Id32<TAKJGNICNJO>[] c, IdArray<TAKJGNICNJO, bool> d)
		{
			return default(Result<LHXOXHRKKRO, DEINNYDYQPE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x294BF50", Offset = "0x294AF50", VA = "0x18294BF50", Slot = "3")]
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
