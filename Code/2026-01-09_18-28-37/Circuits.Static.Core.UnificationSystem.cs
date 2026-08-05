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
	public interface UCJKCVUMNSY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates YKTKFDDBKJF(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class WPKDFKUISLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28EA770", Offset = "0x28E9B70", VA = "0x1828EA770")]
		public static Id32<PVBVGIYYXTF> JISAXQAKFEF(this int a)
		{
			return default(Id32<PVBVGIYYXTF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class PVBVGIYYXTF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class OUMRPDILBDW : NBILMTLEEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28EA3C0", Offset = "0x28E97C0", VA = "0x1828EA3C0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28EA3F0", Offset = "0x28E97F0", VA = "0x1828EA3F0")]
		public OUMRPDILBDW()
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
			[Cpp2IlInjected.Address(RVA = "0x28E95F0", Offset = "0x28E89F0", VA = "0x1828E95F0")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28E9660", Offset = "0x28E8A60", VA = "0x1828E9660")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E9780", Offset = "0x28E8B80", VA = "0x1828E9780")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28E96A0", Offset = "0x28E8AA0", VA = "0x1828E96A0")]
		public static ApplyConstraintResult RQNRHTUDKXC([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28E9750", Offset = "0x28E8B50", VA = "0x1828E9750")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28E9670", Offset = "0x28E8A70", VA = "0x1828E9670")]
		public static ApplyConstraintResult BXPSJNVKTRP([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28E9740", Offset = "0x28E8B40", VA = "0x1828E9740")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28E9720", Offset = "0x28E8B20", VA = "0x1828E9720")]
		public static ApplyConstraintResult ZCCISGEILKU()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<PVBVGIYYXTF> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<PVBVGIYYXTF> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		private Arrow(Id32<PVBVGIYYXTF> from, Id32<PVBVGIYYXTF> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28D3370", Offset = "0x28D2770", VA = "0x1828D3370")]
		public static Arrow New(Id32<PVBVGIYYXTF> from, Id32<PVBVGIYYXTF> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28E9800", Offset = "0x28E8C00", VA = "0x1828E9800", Slot = "3")]
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
		public readonly Id32<PVBVGIYYXTF> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<PVBVGIYYXTF> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		private Constraint(Id32<PVBVGIYYXTF> lhs, Id32<PVBVGIYYXTF> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28D3370", Offset = "0x28D2770", VA = "0x1828D3370")]
		public static Constraint New(Id32<PVBVGIYYXTF> lhs, Id32<PVBVGIYYXTF> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28E9B90", Offset = "0x28E8F90", VA = "0x1828E9B90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class OXURVJHGZZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28EA400", Offset = "0x28E9800", VA = "0x1828EA400")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<PVBVGIYYXTF, Term> terms, Id32<PVBVGIYYXTF>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<PVBVGIYYXTF> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<PVBVGIYYXTF> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		private Substitution(Id32<PVBVGIYYXTF> identifier, Id32<PVBVGIYYXTF> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28D3370", Offset = "0x28D2770", VA = "0x1828D3370")]
		public static Substitution New(Id32<PVBVGIYYXTF> identifier, Id32<PVBVGIYYXTF> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28EA5C0", Offset = "0x28E99C0", VA = "0x1828EA5C0", Slot = "3")]
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
			public readonly Id32<PVBVGIYYXTF> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28EA660", Offset = "0x28E9A60", VA = "0x1828EA660")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x28EA650", Offset = "0x28E9A50", VA = "0x1828EA650")]
			public TermImpl(Id32<PVBVGIYYXTF> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x28EA760", Offset = "0x28E9B60", VA = "0x1828EA760")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28EA690", Offset = "0x28E9A90", VA = "0x1828EA690")]
		public static Term SKEGLSNFFAR([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28EA740", Offset = "0x28E9B40", VA = "0x1828EA740")]
		private Term(Id32<PVBVGIYYXTF> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28EA670", Offset = "0x28E9A70", VA = "0x1828EA670")]
		public static Term LVNXCGSUZUD(Id32<PVBVGIYYXTF> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28EA6B0", Offset = "0x28E9AB0", VA = "0x1828EA6B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class IUWOYZQQFXN<a, b> where b : UCJKCVUMNSY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class TJLYPUTVFSL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<PVBVGIYYXTF, Term> ORRQYLHLHKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<PVBVGIYYXTF>[] VPNLPACTECL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<PVBVGIYYXTF, bool> AUHKOEITJXA;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public TJLYPUTVFSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1570", Offset = "0x5EA0970", VA = "0x185EA1570")]
			internal Result<GISJWUWDESK, NBILMTLEEJL> DUIMHBYROXM(Substitution a)
			{
				return default(Result<GISJWUWDESK, NBILMTLEEJL>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> SFPBKZGLEFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> KWUDTSDBSGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b GOSNOUTRNRX;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5020DD0", Offset = "0x50201D0", VA = "0x185020DD0")]
		protected IUWOYZQQFXN([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x501F960", Offset = "0x501ED60", VA = "0x18501F960")]
		public static IUWOYZQQFXN<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5020A40", Offset = "0x501FE40", VA = "0x185020A40")]
		public Id32<PVBVGIYYXTF> UFUDSWYRVOO()
		{
			return default(Id32<PVBVGIYYXTF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x501F760", Offset = "0x501EB60", VA = "0x18501F760")]
		public Id32<PVBVGIYYXTF> ENGQJNMZUVF(Id32<PVBVGIYYXTF> a, Id32<PVBVGIYYXTF> b)
		{
			return default(Id32<PVBVGIYYXTF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB04E40", Offset = "0xB04240", VA = "0x180B04E40")]
		public Id32<PVBVGIYYXTF> HOTJOSUEJSZ(Id32<PVBVGIYYXTF> a)
		{
			return default(Id32<PVBVGIYYXTF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5020CC0", Offset = "0x50200C0", VA = "0x185020CC0")]
		public void XPGWJFOQOLL(Id32<PVBVGIYYXTF> a, Id32<PVBVGIYYXTF> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5020350", Offset = "0x501F750", VA = "0x185020350")]
		public Result<GISJWUWDESK[], NBILMTLEEJL> Solve([In] a root)
		{
			return default(Result<GISJWUWDESK[], NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x501F8A0", Offset = "0x501ECA0", VA = "0x18501F8A0")]
		public FLIFULXDEKP JQFHWDJSNVS(Id32<PVBVGIYYXTF> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class XVSIAXFPLGV
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28EA7B0", Offset = "0x28E9BB0", VA = "0x1828EA7B0")]
		internal static Term YUHBNCBUUWQ(Id32<PVBVGIYYXTF> a, IdArray<PVBVGIYYXTF, Term> b, Id32<PVBVGIYYXTF>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface FLIFULXDEKP : IEquatable<FLIFULXDEKP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind DKWEGDBOTPS
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<PVBVGIYYXTF> HMCFLCPGJQA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		FLIFULXDEKP PJRUPHBEYVB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		FLIFULXDEKP PTBTSAEJFRE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class CKFBSBZKSEU : FLIFULXDEKP, IEquatable<FLIFULXDEKP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly FLIFULXDEKP MRAWTGOIJUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly FLIFULXDEKP ZORFRVRYREL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind DKWEGDBOTPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB88CD0", Offset = "0xB880D0", VA = "0x180B88CD0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<PVBVGIYYXTF> KOBQOFDJZBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x28E9890", Offset = "0x28E8C90", VA = "0x1828E9890", Slot = "5")]
			get
			{
				return default(Id32<PVBVGIYYXTF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private FLIFULXDEKP WGMBBDRAMGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FLIFULXDEKP RQNKHGHTDZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAAC040", Offset = "0xAAB440", VA = "0x180AAC040")]
		private CKFBSBZKSEU(FLIFULXDEKP a, FLIFULXDEKP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28E9A60", Offset = "0x28E8E60", VA = "0x1828E9A60")]
		public static CKFBSBZKSEU New(FLIFULXDEKP from, FLIFULXDEKP to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28E98E0", Offset = "0x28E8CE0", VA = "0x1828E98E0", Slot = "8")]
		public bool Equals(FLIFULXDEKP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28E9AE0", Offset = "0x28E8EE0", VA = "0x1828E9AE0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class FLNJKUDUXCM : FLIFULXDEKP, IEquatable<FLIFULXDEKP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<PVBVGIYYXTF> MHEWXLBFLTJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind DKWEGDBOTPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<PVBVGIYYXTF> KOBQOFDJZBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110", Slot = "5")]
			get
			{
				return default(Id32<PVBVGIYYXTF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private FLIFULXDEKP WGMBBDRAMGS
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x28E9DA0", Offset = "0x28E91A0", VA = "0x1828E9DA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private FLIFULXDEKP RQNKHGHTDZR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x28E9E30", Offset = "0x28E9230", VA = "0x1828E9E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xE5BE50", Offset = "0xE5B250", VA = "0x180E5BE50")]
		private FLNJKUDUXCM(Id32<PVBVGIYYXTF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28E9D40", Offset = "0x28E9140", VA = "0x1828E9D40")]
		public static FLNJKUDUXCM New(Id32<PVBVGIYYXTF> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28E9C20", Offset = "0x28E9020", VA = "0x1828E9C20", Slot = "8")]
		public bool Equals(FLIFULXDEKP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28E9DF0", Offset = "0x28E91F0", VA = "0x1828E9DF0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class GISJWUWDESK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<PVBVGIYYXTF> KVDFRQPXLVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<PVBVGIYYXTF>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA5C90", Offset = "0xAA5090", VA = "0x180AA5C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FLIFULXDEKP MHEWXLBFLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDC8940", Offset = "0xDC7D40", VA = "0x180DC8940")]
		private GISJWUWDESK(Id32<PVBVGIYYXTF> a, FLIFULXDEKP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28E9E80", Offset = "0x28E9280", VA = "0x1828E9E80")]
		public static Result<GISJWUWDESK, NBILMTLEEJL> QJJNSAOMJTE([In] Substitution substitution, IdArray<PVBVGIYYXTF, Term> a, Id32<PVBVGIYYXTF>[] b, IdArray<PVBVGIYYXTF, bool> c)
		{
			return default(Result<GISJWUWDESK, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28EA0B0", Offset = "0x28E94B0", VA = "0x1828EA0B0")]
		private static Result<FLIFULXDEKP, NBILMTLEEJL> ZPULUPGVEHC(Id32<PVBVGIYYXTF> a, IdArray<PVBVGIYYXTF, Term> b, Id32<PVBVGIYYXTF>[] c, IdArray<PVBVGIYYXTF, bool> d)
		{
			return default(Result<FLIFULXDEKP, NBILMTLEEJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28EA040", Offset = "0x28E9440", VA = "0x1828EA040", Slot = "3")]
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
