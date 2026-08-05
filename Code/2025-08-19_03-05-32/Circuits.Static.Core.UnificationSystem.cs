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
	public interface XZBYKVFOQNN<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates RNHCULQHDBI(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class GNIFZIJPKTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B12540", Offset = "0x2B11340", VA = "0x182B12540")]
		public static Id32<UCBVOTVWSOI> SOZBGUDZUNK(this int a)
		{
			return default(Id32<UCBVOTVWSOI>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class UCBVOTVWSOI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class XPDAPSYPRMF : RHLDYTPLBXY
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B133D0", Offset = "0x2B121D0", VA = "0x182B133D0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B13400", Offset = "0x2B12200", VA = "0x182B13400")]
		public XPDAPSYPRMF()
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
			[Cpp2IlInjected.Address(RVA = "0x2B12210", Offset = "0x2B11010", VA = "0x182B12210")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2B12280", Offset = "0x2B11080", VA = "0x182B12280")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B123A0", Offset = "0x2B111A0", VA = "0x182B123A0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B122E0", Offset = "0x2B110E0", VA = "0x182B122E0")]
		public static ApplyConstraintResult VHLSOSJDILH([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B12370", Offset = "0x2B11170", VA = "0x182B12370")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B12290", Offset = "0x2B11090", VA = "0x182B12290")]
		public static ApplyConstraintResult FTXZMIZXBNY([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B12360", Offset = "0x2B11160", VA = "0x182B12360")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B122C0", Offset = "0x2B110C0", VA = "0x182B122C0")]
		public static ApplyConstraintResult QDYFKZMUXSL()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<UCBVOTVWSOI> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<UCBVOTVWSOI> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
		private Arrow(Id32<UCBVOTVWSOI> from, Id32<UCBVOTVWSOI> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9A50", Offset = "0x2AF8850", VA = "0x182AF9A50")]
		public static Arrow New(Id32<UCBVOTVWSOI> from, Id32<UCBVOTVWSOI> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B12420", Offset = "0x2B11220", VA = "0x182B12420", Slot = "3")]
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
		public readonly Id32<UCBVOTVWSOI> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<UCBVOTVWSOI> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
		private Constraint(Id32<UCBVOTVWSOI> lhs, Id32<UCBVOTVWSOI> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9A50", Offset = "0x2AF8850", VA = "0x182AF9A50")]
		public static Constraint New(Id32<UCBVOTVWSOI> lhs, Id32<UCBVOTVWSOI> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B124B0", Offset = "0x2B112B0", VA = "0x182B124B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class YFGDQNXXIWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B13410", Offset = "0x2B12210", VA = "0x182B13410")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<UCBVOTVWSOI, Term> terms, Id32<UCBVOTVWSOI>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<UCBVOTVWSOI> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<UCBVOTVWSOI> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEBBC90", Offset = "0xEBAA90", VA = "0x180EBBC90")]
		private Substitution(Id32<UCBVOTVWSOI> identifier, Id32<UCBVOTVWSOI> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9A50", Offset = "0x2AF8850", VA = "0x182AF9A50")]
		public static Substitution New(Id32<UCBVOTVWSOI> identifier, Id32<UCBVOTVWSOI> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B12CC0", Offset = "0x2B11AC0", VA = "0x182B12CC0", Slot = "3")]
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
			public readonly Id32<UCBVOTVWSOI> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B12D50", Offset = "0x2B11B50", VA = "0x182B12D50")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2B12D60", Offset = "0x2B11B60", VA = "0x182B12D60")]
			public TermImpl(Id32<UCBVOTVWSOI> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2B12E60", Offset = "0x2B11C60", VA = "0x182B12E60")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B12D70", Offset = "0x2B11B70", VA = "0x182B12D70")]
		public static Term KSWYYWEZZEA([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B12E40", Offset = "0x2B11C40", VA = "0x182B12E40")]
		private Term(Id32<UCBVOTVWSOI> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B12E20", Offset = "0x2B11C20", VA = "0x182B12E20")]
		public static Term VPLBVSISIBS(Id32<UCBVOTVWSOI> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B12D90", Offset = "0x2B11B90", VA = "0x182B12D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class BYTZKWPVLRW<a, b> where b : XZBYKVFOQNN<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ZVGRUIXYDWS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<UCBVOTVWSOI, Term> USXJUQXOSRY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<UCBVOTVWSOI>[] MVAVBGYOBMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<UCBVOTVWSOI, bool> JFJMFZHKQDH;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZVGRUIXYDWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x413B370", Offset = "0x413A170", VA = "0x18413B370")]
			internal Result<OBBVPDPDFHL, RHLDYTPLBXY> FCWUEWAPJTH(Substitution a)
			{
				return default(Result<OBBVPDPDFHL, RHLDYTPLBXY>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> TBXRPWTVSZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> IHKYUUZSZVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b JGLYIVPXDNI;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x70F9E10", Offset = "0x70F8C10", VA = "0x1870F9E10")]
		protected BYTZKWPVLRW([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70F8730", Offset = "0x70F7530", VA = "0x1870F8730")]
		public static BYTZKWPVLRW<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70F83E0", Offset = "0x70F71E0", VA = "0x1870F83E0")]
		public Id32<UCBVOTVWSOI> CJCLIMKPPFX()
		{
			return default(Id32<UCBVOTVWSOI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70F8870", Offset = "0x70F7670", VA = "0x1870F8870")]
		public Id32<UCBVOTVWSOI> PJKLMYXFRCE(Id32<UCBVOTVWSOI> a, Id32<UCBVOTVWSOI> b)
		{
			return default(Id32<UCBVOTVWSOI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBD0E60", Offset = "0xBCFC60", VA = "0x180BD0E60")]
		public Id32<UCBVOTVWSOI> BLVAROODRXK(Id32<UCBVOTVWSOI> a)
		{
			return default(Id32<UCBVOTVWSOI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70F8BD0", Offset = "0x70F79D0", VA = "0x1870F8BD0")]
		public void PLLAZOXJMMM(Id32<UCBVOTVWSOI> a, Id32<UCBVOTVWSOI> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x70F9550", Offset = "0x70F8350", VA = "0x1870F9550")]
		public Result<OBBVPDPDFHL[], RHLDYTPLBXY> Solve([In] a root)
		{
			return default(Result<OBBVPDPDFHL[], RHLDYTPLBXY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x70F8860", Offset = "0x70F7660", VA = "0x1870F8860")]
		public PLLMWAEAPJK OCHKCWTNJIN(Id32<UCBVOTVWSOI> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MXICIJEQCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B12580", Offset = "0x2B11380", VA = "0x182B12580")]
		internal static Term QJKPRIHXBDR(Id32<UCBVOTVWSOI> a, IdArray<UCBVOTVWSOI, Term> b, Id32<UCBVOTVWSOI>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface PLLMWAEAPJK : IEquatable<PLLMWAEAPJK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind JSZILMLWUMV
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<UCBVOTVWSOI> PIVWSXKSADT
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		PLLMWAEAPJK EESIXMUMTZG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		PLLMWAEAPJK PHZHRBQGIVL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class XLZDHUPDNSV : PLLMWAEAPJK, IEquatable<PLLMWAEAPJK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly PLLMWAEAPJK FJEJEXGDWUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly PLLMWAEAPJK PKOUNBZLGBI;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind JSZILMLWUMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<UCBVOTVWSOI> CQFUBPHFZQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2B130D0", Offset = "0x2B11ED0", VA = "0x182B130D0", Slot = "5")]
			get
			{
				return default(Id32<UCBVOTVWSOI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private PLLMWAEAPJK JQXTCIDNFGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PLLMWAEAPJK JHFMGPTAJFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		private XLZDHUPDNSV(PLLMWAEAPJK a, PLLMWAEAPJK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B132A0", Offset = "0x2B120A0", VA = "0x182B132A0")]
		public static XLZDHUPDNSV New(PLLMWAEAPJK from, PLLMWAEAPJK to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B13120", Offset = "0x2B11F20", VA = "0x182B13120", Slot = "8")]
		public bool Equals(PLLMWAEAPJK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B13320", Offset = "0x2B12120", VA = "0x182B13320", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class UUDTIIGAMRN : PLLMWAEAPJK, IEquatable<PLLMWAEAPJK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<UCBVOTVWSOI> REKHREVTQMM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind JSZILMLWUMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<UCBVOTVWSOI> CQFUBPHFZQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110", Slot = "5")]
			get
			{
				return default(Id32<UCBVOTVWSOI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private PLLMWAEAPJK JQXTCIDNFGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2B13080", Offset = "0x2B11E80", VA = "0x182B13080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private PLLMWAEAPJK JHFMGPTAJFE
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B12F90", Offset = "0x2B11D90", VA = "0x182B12F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1123790", Offset = "0x1122590", VA = "0x181123790")]
		private UUDTIIGAMRN(Id32<UCBVOTVWSOI> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B12FE0", Offset = "0x2B11DE0", VA = "0x182B12FE0")]
		public static UUDTIIGAMRN New(Id32<UCBVOTVWSOI> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B12E70", Offset = "0x2B11C70", VA = "0x182B12E70", Slot = "8")]
		public bool Equals(PLLMWAEAPJK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B13040", Offset = "0x2B11E40", VA = "0x182B13040", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class OBBVPDPDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<UCBVOTVWSOI> QXVQSTMOTBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<UCBVOTVWSOI>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PLLMWAEAPJK REKHREVTQMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1088910", Offset = "0x1087710", VA = "0x181088910")]
		private OBBVPDPDFHL(Id32<UCBVOTVWSOI> a, PLLMWAEAPJK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B12780", Offset = "0x2B11580", VA = "0x182B12780")]
		public static Result<OBBVPDPDFHL, RHLDYTPLBXY> SLOSALPTYDT([In] Substitution substitution, IdArray<UCBVOTVWSOI, Term> a, Id32<UCBVOTVWSOI>[] b, IdArray<UCBVOTVWSOI, bool> c)
		{
			return default(Result<OBBVPDPDFHL, RHLDYTPLBXY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B129B0", Offset = "0x2B117B0", VA = "0x182B129B0")]
		private static Result<PLLMWAEAPJK, RHLDYTPLBXY> WFBIPDYEZXF(Id32<UCBVOTVWSOI> a, IdArray<UCBVOTVWSOI, Term> b, Id32<UCBVOTVWSOI>[] c, IdArray<UCBVOTVWSOI, bool> d)
		{
			return default(Result<PLLMWAEAPJK, RHLDYTPLBXY>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B12940", Offset = "0x2B11740", VA = "0x182B12940", Slot = "3")]
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
