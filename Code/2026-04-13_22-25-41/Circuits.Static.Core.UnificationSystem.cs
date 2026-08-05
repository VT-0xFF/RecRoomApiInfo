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
	public interface VDFOEWNMPJQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates MVOOPKPIKPP(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class LHPJXAITWTZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7BC0", Offset = "0x2BA65C0", VA = "0x182BA7BC0")]
		public static Id32<YKSWNXQGSCB> JHFAPPHNHCX(this int a)
		{
			return default(Id32<YKSWNXQGSCB>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class YKSWNXQGSCB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class JBQLRPLLWXA : ARGBUOZFZQD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7B80", Offset = "0x2BA6580", VA = "0x182BA7B80", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7BB0", Offset = "0x2BA65B0", VA = "0x182BA7BB0")]
		public JBQLRPLLWXA()
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
			[Cpp2IlInjected.Address(RVA = "0x2BA7650", Offset = "0x2BA6050", VA = "0x182BA7650")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA76C0", Offset = "0x2BA60C0", VA = "0x182BA76C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA77E0", Offset = "0x2BA61E0", VA = "0x182BA77E0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7720", Offset = "0x2BA6120", VA = "0x182BA7720")]
		public static ApplyConstraintResult VBLNOHGHTVM([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BA77B0", Offset = "0x2BA61B0", VA = "0x182BA77B0")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BA76D0", Offset = "0x2BA60D0", VA = "0x182BA76D0")]
		public static ApplyConstraintResult AHCSQMYCCBR([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BA77A0", Offset = "0x2BA61A0", VA = "0x182BA77A0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7700", Offset = "0x2BA6100", VA = "0x182BA7700")]
		public static ApplyConstraintResult EWGQFESVSBY()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<YKSWNXQGSCB> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<YKSWNXQGSCB> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
		private Arrow(Id32<YKSWNXQGSCB> from, Id32<YKSWNXQGSCB> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B896D0", Offset = "0x2B880D0", VA = "0x182B896D0")]
		public static Arrow New(Id32<YKSWNXQGSCB> from, Id32<YKSWNXQGSCB> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7860", Offset = "0x2BA6260", VA = "0x182BA7860", Slot = "3")]
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
		public readonly Id32<YKSWNXQGSCB> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<YKSWNXQGSCB> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
		private Constraint(Id32<YKSWNXQGSCB> lhs, Id32<YKSWNXQGSCB> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B896D0", Offset = "0x2B880D0", VA = "0x182B896D0")]
		public static Constraint New(Id32<YKSWNXQGSCB> lhs, Id32<YKSWNXQGSCB> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BA78F0", Offset = "0x2BA62F0", VA = "0x182BA78F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class ZSIPCBMCTJU
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8850", Offset = "0x2BA7250", VA = "0x182BA8850")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<YKSWNXQGSCB, Term> terms, Id32<YKSWNXQGSCB>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<YKSWNXQGSCB> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<YKSWNXQGSCB> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
		private Substitution(Id32<YKSWNXQGSCB> identifier, Id32<YKSWNXQGSCB> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B896D0", Offset = "0x2B880D0", VA = "0x182B896D0")]
		public static Substitution New(Id32<YKSWNXQGSCB> identifier, Id32<YKSWNXQGSCB> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8160", Offset = "0x2BA6B60", VA = "0x182BA8160", Slot = "3")]
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
			public readonly Id32<YKSWNXQGSCB> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA81F0", Offset = "0x2BA6BF0", VA = "0x182BA81F0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8200", Offset = "0x2BA6C00", VA = "0x182BA8200")]
			public TermImpl(Id32<YKSWNXQGSCB> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2BA8300", Offset = "0x2BA6D00", VA = "0x182BA8300")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8210", Offset = "0x2BA6C10", VA = "0x182BA8210")]
		public static Term AOYXHDXRUOP([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BA82E0", Offset = "0x2BA6CE0", VA = "0x182BA82E0")]
		private Term(Id32<YKSWNXQGSCB> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8230", Offset = "0x2BA6C30", VA = "0x182BA8230")]
		public static Term MEAALMEENER(Id32<YKSWNXQGSCB> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8250", Offset = "0x2BA6C50", VA = "0x182BA8250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class XIKGHGUNYEN<a, b> where b : VDFOEWNMPJQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QWQABXVDRJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<YKSWNXQGSCB, Term> MTEMYTSASKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<YKSWNXQGSCB>[] YIAONEYZGXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<YKSWNXQGSCB, bool> FJKDPGAVGEM;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7643480", Offset = "0x7641E80", VA = "0x187643480")]
			internal Result<UBTYLTBVLTW, ARGBUOZFZQD> MCYVVLCQNMU(Substitution a)
			{
				return default(Result<UBTYLTBVLTW, ARGBUOZFZQD>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> XBMBXZQLRDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> MMVOXETAATF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b XBSGLFJHVQL;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x50C2D30", Offset = "0x50C1730", VA = "0x1850C2D30")]
		protected XIKGHGUNYEN([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x50C1990", Offset = "0x50C0390", VA = "0x1850C1990")]
		public static XIKGHGUNYEN<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x50C1650", Offset = "0x50C0050", VA = "0x1850C1650")]
		public Id32<YKSWNXQGSCB> HSIGJZIDCUQ()
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x50C1510", Offset = "0x50BFF10", VA = "0x1850C1510")]
		public Id32<YKSWNXQGSCB> HDHMYIZHIDD(Id32<YKSWNXQGSCB> a, Id32<YKSWNXQGSCB> b)
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD52F70", VA = "0x180D54570")]
		public Id32<YKSWNXQGSCB> SGABVFHOYOH(Id32<YKSWNXQGSCB> a)
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x50C1B50", Offset = "0x50C0550", VA = "0x1850C1B50")]
		public void SVKCKSZOFWH(Id32<YKSWNXQGSCB> a, Id32<YKSWNXQGSCB> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x50C2490", Offset = "0x50C0E90", VA = "0x1850C2490")]
		public Result<UBTYLTBVLTW[], ARGBUOZFZQD> Solve([In] a root)
		{
			return default(Result<UBTYLTBVLTW[], ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x50C18D0", Offset = "0x50C02D0", VA = "0x1850C18D0")]
		public VCVTKBIEKIR IVSIKPONCPQ(Id32<YKSWNXQGSCB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DEDSWWEZCUX
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7980", Offset = "0x2BA6380", VA = "0x182BA7980")]
		internal static Term OVJLTVDOMSC(Id32<YKSWNXQGSCB> a, IdArray<YKSWNXQGSCB, Term> b, Id32<YKSWNXQGSCB>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface VCVTKBIEKIR : IEquatable<VCVTKBIEKIR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind JPOHFKUZLGS
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<YKSWNXQGSCB> CEICPTIHIIW
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		VCVTKBIEKIR JYUGRLZEXXP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		VCVTKBIEKIR ETOGDRAGOIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class QMFXBANROZE : VCVTKBIEKIR, IEquatable<VCVTKBIEKIR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly VCVTKBIEKIR SUSCFZIGOIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly VCVTKBIEKIR HOIYXHDNLFD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind JPOHFKUZLGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<YKSWNXQGSCB> KWEOHVETYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8060", Offset = "0x2BA6A60", VA = "0x182BA8060", Slot = "5")]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private VCVTKBIEKIR PJCASZJJIKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private VCVTKBIEKIR NLWDANFKZOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1360", VA = "0x180CF2960")]
		private QMFXBANROZE(VCVTKBIEKIR a, VCVTKBIEKIR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7FE0", Offset = "0x2BA69E0", VA = "0x182BA7FE0")]
		public static QMFXBANROZE New(VCVTKBIEKIR from, VCVTKBIEKIR to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E60", Offset = "0x2BA6860", VA = "0x182BA7E60", Slot = "8")]
		public bool Equals(VCVTKBIEKIR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BA80B0", Offset = "0x2BA6AB0", VA = "0x182BA80B0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class PINFZOZWBKO : VCVTKBIEKIR, IEquatable<VCVTKBIEKIR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<YKSWNXQGSCB> YMGSSSXYISN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind JPOHFKUZLGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<YKSWNXQGSCB> KWEOHVETYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECB10", VA = "0x180CEE110", Slot = "5")]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private VCVTKBIEKIR PJCASZJJIKU
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7E10", Offset = "0x2BA6810", VA = "0x182BA7E10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private VCVTKBIEKIR NLWDANFKZOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7D20", Offset = "0x2BA6720", VA = "0x182BA7D20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1126BA0", Offset = "0x11255A0", VA = "0x181126BA0")]
		private PINFZOZWBKO(Id32<YKSWNXQGSCB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7D70", Offset = "0x2BA6770", VA = "0x182BA7D70")]
		public static PINFZOZWBKO New(Id32<YKSWNXQGSCB> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7C00", Offset = "0x2BA6600", VA = "0x182BA7C00", Slot = "8")]
		public bool Equals(VCVTKBIEKIR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7DD0", Offset = "0x2BA67D0", VA = "0x182BA7DD0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class UBTYLTBVLTW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<YKSWNXQGSCB> JQCTFOCWOYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECB10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0440", VA = "0x180CF1A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public VCVTKBIEKIR YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0410", VA = "0x180CF1A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x108C5B0", Offset = "0x108AFB0", VA = "0x18108C5B0")]
		private UBTYLTBVLTW(Id32<YKSWNXQGSCB> a, VCVTKBIEKIR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8690", Offset = "0x2BA7090", VA = "0x182BA8690")]
		public static Result<UBTYLTBVLTW, ARGBUOZFZQD> XIFDVHYLLSM([In] Substitution substitution, IdArray<YKSWNXQGSCB, Term> a, Id32<YKSWNXQGSCB>[] b, IdArray<YKSWNXQGSCB, bool> c)
		{
			return default(Result<UBTYLTBVLTW, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8310", Offset = "0x2BA6D10", VA = "0x182BA8310")]
		private static Result<VCVTKBIEKIR, ARGBUOZFZQD> MGJTZCGSLKW(Id32<YKSWNXQGSCB> a, IdArray<YKSWNXQGSCB, Term> b, Id32<YKSWNXQGSCB>[] c, IdArray<YKSWNXQGSCB, bool> d)
		{
			return default(Result<VCVTKBIEKIR, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8620", Offset = "0x2BA7020", VA = "0x182BA8620", Slot = "3")]
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
