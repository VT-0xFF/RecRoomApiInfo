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
	public interface BZPGNHHMTGT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates DKEPGKMRJNE(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class FUALIJSRHLS
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x290C180", Offset = "0x290A980", VA = "0x18290C180")]
		public static Id32<NJHSCTGHDCA> ADEJQKXGCKM(this int a)
		{
			return default(Id32<NJHSCTGHDCA>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class NJHSCTGHDCA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class LJQKYYPGXLT : GPJDWMBBLWO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x290C1C0", Offset = "0x290A9C0", VA = "0x18290C1C0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x290C1F0", Offset = "0x290A9F0", VA = "0x18290C1F0")]
		public LJQKYYPGXLT()
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
			[Cpp2IlInjected.Address(RVA = "0x290B950", Offset = "0x290A150", VA = "0x18290B950")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x290B9C0", Offset = "0x290A1C0", VA = "0x18290B9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x290BAE0", Offset = "0x290A2E0", VA = "0x18290BAE0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x290BA20", Offset = "0x290A220", VA = "0x18290BA20")]
		public static ApplyConstraintResult QVSDMZESJBD([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x290BAB0", Offset = "0x290A2B0", VA = "0x18290BAB0")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x290B9F0", Offset = "0x290A1F0", VA = "0x18290B9F0")]
		public static ApplyConstraintResult IGVFZTHEQIC([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x290BAA0", Offset = "0x290A2A0", VA = "0x18290BAA0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x290B9D0", Offset = "0x290A1D0", VA = "0x18290B9D0")]
		public static ApplyConstraintResult CETKNUGARUL()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<NJHSCTGHDCA> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<NJHSCTGHDCA> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		private Arrow(Id32<NJHSCTGHDCA> from, Id32<NJHSCTGHDCA> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28F0300", Offset = "0x28EEB00", VA = "0x1828F0300")]
		public static Arrow New(Id32<NJHSCTGHDCA> from, Id32<NJHSCTGHDCA> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x290BB60", Offset = "0x290A360", VA = "0x18290BB60", Slot = "3")]
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
		public readonly Id32<NJHSCTGHDCA> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<NJHSCTGHDCA> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		private Constraint(Id32<NJHSCTGHDCA> lhs, Id32<NJHSCTGHDCA> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28F0300", Offset = "0x28EEB00", VA = "0x1828F0300")]
		public static Constraint New(Id32<NJHSCTGHDCA> lhs, Id32<NJHSCTGHDCA> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x290BBF0", Offset = "0x290A3F0", VA = "0x18290BBF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class ZNNRIKWFHDZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x290C8F0", Offset = "0x290B0F0", VA = "0x18290C8F0")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<NJHSCTGHDCA, Term> terms, Id32<NJHSCTGHDCA>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<NJHSCTGHDCA> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<NJHSCTGHDCA> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		private Substitution(Id32<NJHSCTGHDCA> identifier, Id32<NJHSCTGHDCA> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28F0300", Offset = "0x28EEB00", VA = "0x1828F0300")]
		public static Substitution New(Id32<NJHSCTGHDCA> identifier, Id32<NJHSCTGHDCA> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x290C740", Offset = "0x290AF40", VA = "0x18290C740", Slot = "3")]
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
			public readonly Id32<NJHSCTGHDCA> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x290C7D0", Offset = "0x290AFD0", VA = "0x18290C7D0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x290C7E0", Offset = "0x290AFE0", VA = "0x18290C7E0")]
			public TermImpl(Id32<NJHSCTGHDCA> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x290C8C0", Offset = "0x290B0C0", VA = "0x18290C8C0")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x290C7F0", Offset = "0x290AFF0", VA = "0x18290C7F0")]
		public static Term HTECOOAEBVK([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x290C8D0", Offset = "0x290B0D0", VA = "0x18290C8D0")]
		private Term(Id32<NJHSCTGHDCA> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x290C810", Offset = "0x290B010", VA = "0x18290C810")]
		public static Term RLOVOJBOOAY(Id32<NJHSCTGHDCA> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x290C830", Offset = "0x290B030", VA = "0x18290C830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class HBWCTAIIGZO<a, b> where b : BZPGNHHMTGT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JZDWTNUPEWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<NJHSCTGHDCA, Term> IFZBZGVRVCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<NJHSCTGHDCA>[] RCVRMKMOKLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<NJHSCTGHDCA, bool> AJFXGZTTEAZ;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public JZDWTNUPEWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x50DDDC0", Offset = "0x50DC5C0", VA = "0x1850DDDC0")]
			internal Result<NLWVZJNBSLT, GPJDWMBBLWO> KXIASADCHAB(Substitution a)
			{
				return default(Result<NLWVZJNBSLT, GPJDWMBBLWO>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> HWKPUZPBGJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> JIXVTFBNLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b FPRKQLVLHLA;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4F2D6F0", Offset = "0x4F2BEF0", VA = "0x184F2D6F0")]
		protected HBWCTAIIGZO([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4F2BE10", Offset = "0x4F2A610", VA = "0x184F2BE10")]
		public static HBWCTAIIGZO<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4F2BF30", Offset = "0x4F2A730", VA = "0x184F2BF30")]
		public Id32<NJHSCTGHDCA> PZBGTRFXFZD()
		{
			return default(Id32<NJHSCTGHDCA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4F2C1B0", Offset = "0x4F2A9B0", VA = "0x184F2C1B0")]
		public Id32<NJHSCTGHDCA> QCXMPRIHZMM(Id32<NJHSCTGHDCA> a, Id32<NJHSCTGHDCA> b)
		{
			return default(Id32<NJHSCTGHDCA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB10190", Offset = "0xB0E990", VA = "0x180B10190")]
		public Id32<NJHSCTGHDCA> GYKJPXPTTAM(Id32<NJHSCTGHDCA> a)
		{
			return default(Id32<NJHSCTGHDCA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4F2C460", Offset = "0x4F2AC60", VA = "0x184F2C460")]
		public void RVNFFBPYQKU(Id32<NJHSCTGHDCA> a, Id32<NJHSCTGHDCA> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4F2CE40", Offset = "0x4F2B640", VA = "0x184F2CE40")]
		public Result<NLWVZJNBSLT[], GPJDWMBBLWO> Solve([In] a root)
		{
			return default(Result<NLWVZJNBSLT[], GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4F2D530", Offset = "0x4F2BD30", VA = "0x184F2D530")]
		public EKOAASDODKU ZEUQRIHXCZL(Id32<NJHSCTGHDCA> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DLEXGNKYZJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x290BF80", Offset = "0x290A780", VA = "0x18290BF80")]
		internal static Term HZSCQBDPDIT(Id32<NJHSCTGHDCA> a, IdArray<NJHSCTGHDCA, Term> b, Id32<NJHSCTGHDCA>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface EKOAASDODKU : IEquatable<EKOAASDODKU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind OHCPFBUROHL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<NJHSCTGHDCA> AASETWSDRDT
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		EKOAASDODKU RXFCAPJDEZO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		EKOAASDODKU VZOWRKKWRSB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class DFRFSCSPMHL : EKOAASDODKU, IEquatable<EKOAASDODKU>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly EKOAASDODKU TWKLUZGUDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly EKOAASDODKU JJVTJEMPXQS;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind OHCPFBUROHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<NJHSCTGHDCA> XVQLKUZBKEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x290BE00", Offset = "0x290A600", VA = "0x18290BE00", Slot = "5")]
			get
			{
				return default(Id32<NJHSCTGHDCA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private EKOAASDODKU AEBNYMRJCDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EKOAASDODKU HZHKZMYLQSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xABC070", Offset = "0xABA870", VA = "0x180ABC070")]
		private DFRFSCSPMHL(EKOAASDODKU a, EKOAASDODKU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x290BE50", Offset = "0x290A650", VA = "0x18290BE50")]
		public static DFRFSCSPMHL New(EKOAASDODKU from, EKOAASDODKU to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x290BC80", Offset = "0x290A480", VA = "0x18290BC80", Slot = "8")]
		public bool Equals(EKOAASDODKU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x290BED0", Offset = "0x290A6D0", VA = "0x18290BED0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class AREHAVBEYYD : EKOAASDODKU, IEquatable<EKOAASDODKU>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<NJHSCTGHDCA> ZBQGWKFCAQI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind OHCPFBUROHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<NJHSCTGHDCA> XVQLKUZBKEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110", Slot = "5")]
			get
			{
				return default(Id32<NJHSCTGHDCA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private EKOAASDODKU AEBNYMRJCDB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x290B8B0", Offset = "0x290A0B0", VA = "0x18290B8B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private EKOAASDODKU HZHKZMYLQSS
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x290B900", Offset = "0x290A100", VA = "0x18290B900", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xE95190", Offset = "0xE93990", VA = "0x180E95190")]
		private AREHAVBEYYD(Id32<NJHSCTGHDCA> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x290B810", Offset = "0x290A010", VA = "0x18290B810")]
		public static AREHAVBEYYD New(Id32<NJHSCTGHDCA> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x290B6F0", Offset = "0x2909EF0", VA = "0x18290B6F0", Slot = "8")]
		public bool Equals(EKOAASDODKU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x290B870", Offset = "0x290A070", VA = "0x18290B870", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class NLWVZJNBSLT
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<NJHSCTGHDCA> VXYCUIZXFBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<NJHSCTGHDCA>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EKOAASDODKU ZBQGWKFCAQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDF6AF0", Offset = "0xDF52F0", VA = "0x180DF6AF0")]
		private NLWVZJNBSLT(Id32<NJHSCTGHDCA> a, EKOAASDODKU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x290C510", Offset = "0x290AD10", VA = "0x18290C510")]
		public static Result<NLWVZJNBSLT, GPJDWMBBLWO> SPJBCPDYSMF([In] Substitution substitution, IdArray<NJHSCTGHDCA, Term> a, Id32<NJHSCTGHDCA>[] b, IdArray<NJHSCTGHDCA, bool> c)
		{
			return default(Result<NLWVZJNBSLT, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x290C200", Offset = "0x290AA00", VA = "0x18290C200")]
		private static Result<EKOAASDODKU, GPJDWMBBLWO> NZVRDYOJBIH(Id32<NJHSCTGHDCA> a, IdArray<NJHSCTGHDCA, Term> b, Id32<NJHSCTGHDCA>[] c, IdArray<NJHSCTGHDCA, bool> d)
		{
			return default(Result<EKOAASDODKU, GPJDWMBBLWO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x290C6D0", Offset = "0x290AED0", VA = "0x18290C6D0", Slot = "3")]
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
