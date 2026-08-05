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
		[Cpp2IlInjected.Address(RVA = "0x28E48B0", Offset = "0x28E30B0", VA = "0x1828E48B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E4610", Offset = "0x28E2E10", VA = "0x1828E4610", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28E4640", Offset = "0x28E2E40", VA = "0x1828E4640")]
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
			[Cpp2IlInjected.Address(RVA = "0x28E3F20", Offset = "0x28E2720", VA = "0x1828E3F20")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28E3F90", Offset = "0x28E2790", VA = "0x1828E3F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E40B0", Offset = "0x28E28B0", VA = "0x1828E40B0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28E3FF0", Offset = "0x28E27F0", VA = "0x1828E3FF0")]
		public static ApplyConstraintResult XNBNYMOTAUJ([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28E4080", Offset = "0x28E2880", VA = "0x1828E4080")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28E3FA0", Offset = "0x28E27A0", VA = "0x1828E3FA0")]
		public static ApplyConstraintResult UERLQIAQQLM([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28E4070", Offset = "0x28E2870", VA = "0x1828E4070")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28E3FD0", Offset = "0x28E27D0", VA = "0x1828E3FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
		private Arrow(Id32<MQAHHIUQQJG> from, Id32<MQAHHIUQQJG> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28C6010", Offset = "0x28C4810", VA = "0x1828C6010")]
		public static Arrow New(Id32<MQAHHIUQQJG> from, Id32<MQAHHIUQQJG> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28E4130", Offset = "0x28E2930", VA = "0x1828E4130", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
		private Constraint(Id32<MQAHHIUQQJG> lhs, Id32<MQAHHIUQQJG> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28C6010", Offset = "0x28C4810", VA = "0x1828C6010")]
		public static Constraint New(Id32<MQAHHIUQQJG> lhs, Id32<MQAHHIUQQJG> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28E4580", Offset = "0x28E2D80", VA = "0x1828E4580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class CVRVMCPJUXV
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28E43C0", Offset = "0x28E2BC0", VA = "0x1828E43C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBD99B0", Offset = "0xBD81B0", VA = "0x180BD99B0")]
		private Substitution(Id32<MQAHHIUQQJG> identifier, Id32<MQAHHIUQQJG> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28C6010", Offset = "0x28C4810", VA = "0x1828C6010")]
		public static Substitution New(Id32<MQAHHIUQQJG> identifier, Id32<MQAHHIUQQJG> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28E4E30", Offset = "0x28E3630", VA = "0x1828E4E30", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x28E4EC0", Offset = "0x28E36C0", VA = "0x1828E4EC0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x28E4ED0", Offset = "0x28E36D0", VA = "0x1828E4ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E4FB0", Offset = "0x28E37B0", VA = "0x1828E4FB0")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28E4EE0", Offset = "0x28E36E0", VA = "0x1828E4EE0")]
		public static Term NBLIMYXTMLC([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28E4FC0", Offset = "0x28E37C0", VA = "0x1828E4FC0")]
		private Term(Id32<MQAHHIUQQJG> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28E4F00", Offset = "0x28E3700", VA = "0x1828E4F00")]
		public static Term NENWXDWTUGU(Id32<MQAHHIUQQJG> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28E4F20", Offset = "0x28E3720", VA = "0x1828E4F20", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public LWREDTRENBY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5317100", Offset = "0x5315900", VA = "0x185317100")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DDC840", Offset = "0x4DDB040", VA = "0x184DDC840")]
		protected GREYGHSGPIM([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4DDB390", Offset = "0x4DD9B90", VA = "0x184DDB390")]
		public static GREYGHSGPIM<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4DDB1B0", Offset = "0x4DD99B0", VA = "0x184DDB1B0")]
		public Id32<MQAHHIUQQJG> HFNFVTXNTRD()
		{
			return default(Id32<MQAHHIUQQJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4DDB4B0", Offset = "0x4DD9CB0", VA = "0x184DDB4B0")]
		public Id32<MQAHHIUQQJG> SWFUIDGLYEI(Id32<MQAHHIUQQJG> a, Id32<MQAHHIUQQJG> b)
		{
			return default(Id32<MQAHHIUQQJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB01040", Offset = "0xAFF840", VA = "0x180B01040")]
		public Id32<MQAHHIUQQJG> MUWKTGFIPSI(Id32<MQAHHIUQQJG> a)
		{
			return default(Id32<MQAHHIUQQJG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4DDC730", Offset = "0x4DDAF30", VA = "0x184DDC730")]
		public void TOBTGWYJMVW(Id32<MQAHHIUQQJG> a, Id32<MQAHHIUQQJG> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4DDB760", Offset = "0x4DD9F60", VA = "0x184DDB760")]
		public Result<SPAJCUEKSIR[], KZUDSDVUTEC> Solve([In] a root)
		{
			return default(Result<SPAJCUEKSIR[], KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4DDB2D0", Offset = "0x4DD9AD0", VA = "0x184DDB2D0")]
		public RXAFOYQGPTC LAQRLNMWZBP(Id32<MQAHHIUQQJG> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class BPIQAODBSWS
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28E41C0", Offset = "0x28E29C0", VA = "0x1828E41C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<MQAHHIUQQJG> YISYHHFYODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x28E5290", Offset = "0x28E3A90", VA = "0x1828E5290", Slot = "5")]
			get
			{
				return default(Id32<MQAHHIUQQJG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private RXAFOYQGPTC VHUGDNJJITR
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private RXAFOYQGPTC DSNEMXZYKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA71B0", Offset = "0xAA59B0", VA = "0x180AA71B0")]
		private UOASVEDRQER(RXAFOYQGPTC a, RXAFOYQGPTC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28E5160", Offset = "0x28E3960", VA = "0x1828E5160")]
		public static UOASVEDRQER New(RXAFOYQGPTC from, RXAFOYQGPTC to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28E4FE0", Offset = "0x28E37E0", VA = "0x1828E4FE0", Slot = "8")]
		public bool Equals(RXAFOYQGPTC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28E51E0", Offset = "0x28E39E0", VA = "0x1828E51E0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<MQAHHIUQQJG> YISYHHFYODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA9E110", Offset = "0xA9C910", VA = "0x180A9E110", Slot = "5")]
			get
			{
				return default(Id32<MQAHHIUQQJG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private RXAFOYQGPTC VHUGDNJJITR
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x28E4820", Offset = "0x28E3020", VA = "0x1828E4820", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private RXAFOYQGPTC DSNEMXZYKLA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x28E4650", Offset = "0x28E2E50", VA = "0x1828E4650", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xE57A90", Offset = "0xE56290", VA = "0x180E57A90")]
		private NYCQIGPRYGX(Id32<MQAHHIUQQJG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28E47C0", Offset = "0x28E2FC0", VA = "0x1828E47C0")]
		public static NYCQIGPRYGX New(Id32<MQAHHIUQQJG> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28E46A0", Offset = "0x28E2EA0", VA = "0x1828E46A0", Slot = "8")]
		public bool Equals(RXAFOYQGPTC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28E4870", Offset = "0x28E3070", VA = "0x1828E4870", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xA9E110", Offset = "0xA9C910", VA = "0x180A9E110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<MQAHHIUQQJG>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA9530", Offset = "0xAA7D30", VA = "0x180AA9530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RXAFOYQGPTC GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDC4580", Offset = "0xDC2D80", VA = "0x180DC4580")]
		private SPAJCUEKSIR(Id32<MQAHHIUQQJG> a, RXAFOYQGPTC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28E4C00", Offset = "0x28E3400", VA = "0x1828E4C00")]
		public static Result<SPAJCUEKSIR, KZUDSDVUTEC> SUZEYGQJRJH([In] Substitution substitution, IdArray<MQAHHIUQQJG, Term> a, Id32<MQAHHIUQQJG>[] b, IdArray<MQAHHIUQQJG, bool> c)
		{
			return default(Result<SPAJCUEKSIR, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28E48F0", Offset = "0x28E30F0", VA = "0x1828E48F0")]
		private static Result<RXAFOYQGPTC, KZUDSDVUTEC> HDACJVWNGTN(Id32<MQAHHIUQQJG> a, IdArray<MQAHHIUQQJG, Term> b, Id32<MQAHHIUQQJG>[] c, IdArray<MQAHHIUQQJG, bool> d)
		{
			return default(Result<RXAFOYQGPTC, KZUDSDVUTEC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28E4DC0", Offset = "0x28E35C0", VA = "0x1828E4DC0", Slot = "3")]
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
