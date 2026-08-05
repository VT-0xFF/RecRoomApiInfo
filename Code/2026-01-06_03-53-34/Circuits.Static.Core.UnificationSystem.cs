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
	public interface AGAWTSGPFNV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates SXMEAPWGUZQ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class RIWZDSOFQWI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28F7090", Offset = "0x28F5A90", VA = "0x1828F7090")]
		public static Id32<MQAHHIUQQJG> LECEFSUKXQU(this int a)
		{
			return default(Id32<MQAHHIUQQJG>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class MQAHHIUQQJG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class DJUVSXDQOJT : KZUDSDVUTEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28F6DF0", Offset = "0x28F57F0", VA = "0x1828F6DF0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28F6E20", Offset = "0x28F5820", VA = "0x1828F6E20")]
		public DJUVSXDQOJT()
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
			[Cpp2IlInjected.Address(RVA = "0x28F6700", Offset = "0x28F5100", VA = "0x1828F6700")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28F6770", Offset = "0x28F5170", VA = "0x1828F6770")]
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
		[Cpp2IlInjected.Address(RVA = "0x28F6890", Offset = "0x28F5290", VA = "0x1828F6890")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28F67D0", Offset = "0x28F51D0", VA = "0x1828F67D0")]
		public static ApplyConstraintResult XNBNYMOTAUJ([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28F6860", Offset = "0x28F5260", VA = "0x1828F6860")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28F6780", Offset = "0x28F5180", VA = "0x1828F6780")]
		public static ApplyConstraintResult UERLQIAQQLM([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28F6850", Offset = "0x28F5250", VA = "0x1828F6850")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28F67B0", Offset = "0x28F51B0", VA = "0x1828F67B0")]
		public static ApplyConstraintResult WMTPXKBUYHJ()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<MQAHHIUQQJG> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<MQAHHIUQQJG> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		private Arrow(Id32<MQAHHIUQQJG> from, Id32<MQAHHIUQQJG> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28D87E0", Offset = "0x28D71E0", VA = "0x1828D87E0")]
		public static Arrow New(Id32<MQAHHIUQQJG> from, Id32<MQAHHIUQQJG> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28F6910", Offset = "0x28F5310", VA = "0x1828F6910", Slot = "3")]
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
		public readonly Id32<MQAHHIUQQJG> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<MQAHHIUQQJG> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		private Constraint(Id32<MQAHHIUQQJG> lhs, Id32<MQAHHIUQQJG> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28D87E0", Offset = "0x28D71E0", VA = "0x1828D87E0")]
		public static Constraint New(Id32<MQAHHIUQQJG> lhs, Id32<MQAHHIUQQJG> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28F6D60", Offset = "0x28F5760", VA = "0x1828F6D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class CVRVMCPJUXV
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28F6BA0", Offset = "0x28F55A0", VA = "0x1828F6BA0")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<MQAHHIUQQJG, Term> terms, Id32<MQAHHIUQQJG>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<MQAHHIUQQJG> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<MQAHHIUQQJG> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		private Substitution(Id32<MQAHHIUQQJG> identifier, Id32<MQAHHIUQQJG> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28D87E0", Offset = "0x28D71E0", VA = "0x1828D87E0")]
		public static Substitution New(Id32<MQAHHIUQQJG> identifier, Id32<MQAHHIUQQJG> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28F7610", Offset = "0x28F6010", VA = "0x1828F7610", Slot = "3")]
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
			public readonly Id32<MQAHHIUQQJG> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28F76A0", Offset = "0x28F60A0", VA = "0x1828F76A0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x28F76B0", Offset = "0x28F60B0", VA = "0x1828F76B0")]
			public TermImpl(Id32<MQAHHIUQQJG> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x28F7790", Offset = "0x28F6190", VA = "0x1828F7790")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28F76C0", Offset = "0x28F60C0", VA = "0x1828F76C0")]
		public static Term NBLIMYXTMLC([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28F77A0", Offset = "0x28F61A0", VA = "0x1828F77A0")]
		private Term(Id32<MQAHHIUQQJG> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28F76E0", Offset = "0x28F60E0", VA = "0x1828F76E0")]
		public static Term NENWXDWTUGU(Id32<MQAHHIUQQJG> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28F7700", Offset = "0x28F6100", VA = "0x1828F7700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class GREYGHSGPIM<a, b> where b : AGAWTSGPFNV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class LWREDTRENBY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<MQAHHIUQQJG, Term> KWNMZQNSVGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<MQAHHIUQQJG>[] DGDIZZAWZOU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<MQAHHIUQQJG, bool> PYTRCCYDHCB;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public LWREDTRENBY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x53A8C70", Offset = "0x53A7670", VA = "0x1853A8C70")]
			internal Result<SPAJCUEKSIR, KZUDSDVUTEC> KETNAZDVWOZ(Substitution a)
			{
				return default(Result<SPAJCUEKSIR, KZUDSDVUTEC>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> OHARFDKMJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> OJZIULPWPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b EONMVLIXIRY;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4E4C7A0", Offset = "0x4E4B1A0", VA = "0x184E4C7A0")]
		protected GREYGHSGPIM([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B270", Offset = "0x4E49C70", VA = "0x184E4B270")]
		public static GREYGHSGPIM<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B080", Offset = "0x4E49A80", VA = "0x184E4B080")]
		public Id32<MQAHHIUQQJG> HFNFVTXNTRD()
		{
			return default(Id32<MQAHHIUQQJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B3A0", Offset = "0x4E49DA0", VA = "0x184E4B3A0")]
		public Id32<MQAHHIUQQJG> SWFUIDGLYEI(Id32<MQAHHIUQQJG> a, Id32<MQAHHIUQQJG> b)
		{
			return default(Id32<MQAHHIUQQJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB181F0", Offset = "0xB16BF0", VA = "0x180B181F0")]
		public Id32<MQAHHIUQQJG> MUWKTGFIPSI(Id32<MQAHHIUQQJG> a)
		{
			return default(Id32<MQAHHIUQQJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4E4C690", Offset = "0x4E4B090", VA = "0x184E4C690")]
		public void TOBTGWYJMVW(Id32<MQAHHIUQQJG> a, Id32<MQAHHIUQQJG> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B660", Offset = "0x4E4A060", VA = "0x184E4B660")]
		public Result<SPAJCUEKSIR[], KZUDSDVUTEC> Solve([In] a root)
		{
			return default(Result<SPAJCUEKSIR[], KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4E4B1A0", Offset = "0x4E49BA0", VA = "0x184E4B1A0")]
		public RXAFOYQGPTC LAQRLNMWZBP(Id32<MQAHHIUQQJG> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class BPIQAODBSWS
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28F69A0", Offset = "0x28F53A0", VA = "0x1828F69A0")]
		internal static Term TKOLRMGZGXJ(Id32<MQAHHIUQQJG> a, IdArray<MQAHHIUQQJG, Term> b, Id32<MQAHHIUQQJG>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface RXAFOYQGPTC : IEquatable<RXAFOYQGPTC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind FAURZZYQYPT
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<MQAHHIUQQJG> FVUSPOSCAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RXAFOYQGPTC IIOIJDUOTGA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		RXAFOYQGPTC TVAJDXTLXRD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class UOASVEDRQER : RXAFOYQGPTC, IEquatable<RXAFOYQGPTC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly RXAFOYQGPTC ZJQSOZOYHTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RXAFOYQGPTC FFYGMQFVRWG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind FAURZZYQYPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<MQAHHIUQQJG> YISYHHFYODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x28F7A70", Offset = "0x28F6470", VA = "0x1828F7A70", Slot = "5")]
			get
			{
				return default(Id32<MQAHHIUQQJG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private RXAFOYQGPTC VHUGDNJJITR
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private RXAFOYQGPTC DSNEMXZYKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABCB10", VA = "0x180ABE110")]
		private UOASVEDRQER(RXAFOYQGPTC a, RXAFOYQGPTC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28F7940", Offset = "0x28F6340", VA = "0x1828F7940")]
		public static UOASVEDRQER New(RXAFOYQGPTC from, RXAFOYQGPTC to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28F77C0", Offset = "0x28F61C0", VA = "0x1828F77C0", Slot = "8")]
		public bool Equals(RXAFOYQGPTC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28F79C0", Offset = "0x28F63C0", VA = "0x1828F79C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class NYCQIGPRYGX : RXAFOYQGPTC, IEquatable<RXAFOYQGPTC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<MQAHHIUQQJG> GJDRZFRFPRC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind FAURZZYQYPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<MQAHHIUQQJG> YISYHHFYODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110", Slot = "5")]
			get
			{
				return default(Id32<MQAHHIUQQJG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private RXAFOYQGPTC VHUGDNJJITR
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x28F7000", Offset = "0x28F5A00", VA = "0x1828F7000", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private RXAFOYQGPTC DSNEMXZYKLA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x28F6E30", Offset = "0x28F5830", VA = "0x1828F6E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xE6F3D0", Offset = "0xE6DDD0", VA = "0x180E6F3D0")]
		private NYCQIGPRYGX(Id32<MQAHHIUQQJG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28F6FA0", Offset = "0x28F59A0", VA = "0x1828F6FA0")]
		public static NYCQIGPRYGX New(Id32<MQAHHIUQQJG> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28F6E80", Offset = "0x28F5880", VA = "0x1828F6E80", Slot = "8")]
		public bool Equals(RXAFOYQGPTC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28F7050", Offset = "0x28F5A50", VA = "0x1828F7050", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class SPAJCUEKSIR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<MQAHHIUQQJG> CXQIBDZHUDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<MQAHHIUQQJG>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RXAFOYQGPTC GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDDBC40", Offset = "0xDDA640", VA = "0x180DDBC40")]
		private SPAJCUEKSIR(Id32<MQAHHIUQQJG> a, RXAFOYQGPTC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28F73E0", Offset = "0x28F5DE0", VA = "0x1828F73E0")]
		public static Result<SPAJCUEKSIR, KZUDSDVUTEC> SUZEYGQJRJH([In] Substitution substitution, IdArray<MQAHHIUQQJG, Term> a, Id32<MQAHHIUQQJG>[] b, IdArray<MQAHHIUQQJG, bool> c)
		{
			return default(Result<SPAJCUEKSIR, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28F70D0", Offset = "0x28F5AD0", VA = "0x1828F70D0")]
		private static Result<RXAFOYQGPTC, KZUDSDVUTEC> HDACJVWNGTN(Id32<MQAHHIUQQJG> a, IdArray<MQAHHIUQQJG, Term> b, Id32<MQAHHIUQQJG>[] c, IdArray<MQAHHIUQQJG, bool> d)
		{
			return default(Result<RXAFOYQGPTC, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28F75A0", Offset = "0x28F5FA0", VA = "0x1828F75A0", Slot = "3")]
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
