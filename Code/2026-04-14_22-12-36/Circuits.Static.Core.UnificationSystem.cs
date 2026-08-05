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
		[Cpp2IlInjected.Address(RVA = "0x2BA8E50", Offset = "0x2BA7A50", VA = "0x182BA8E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA8E10", Offset = "0x2BA7A10", VA = "0x182BA8E10", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E40", Offset = "0x2BA7A40", VA = "0x182BA8E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA88E0", Offset = "0x2BA74E0", VA = "0x182BA88E0")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8950", Offset = "0x2BA7550", VA = "0x182BA8950")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA8A70", Offset = "0x2BA7670", VA = "0x182BA8A70")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA89B0", Offset = "0x2BA75B0", VA = "0x182BA89B0")]
		public static ApplyConstraintResult VBLNOHGHTVM([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8A40", Offset = "0x2BA7640", VA = "0x182BA8A40")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8960", Offset = "0x2BA7560", VA = "0x182BA8960")]
		public static ApplyConstraintResult AHCSQMYCCBR([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8A30", Offset = "0x2BA7630", VA = "0x182BA8A30")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8990", Offset = "0x2BA7590", VA = "0x182BA8990")]
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
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
		private Arrow(Id32<YKSWNXQGSCB> from, Id32<YKSWNXQGSCB> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A960", Offset = "0x2B89560", VA = "0x182B8A960")]
		public static Arrow New(Id32<YKSWNXQGSCB> from, Id32<YKSWNXQGSCB> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8AF0", Offset = "0x2BA76F0", VA = "0x182BA8AF0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
		private Constraint(Id32<YKSWNXQGSCB> lhs, Id32<YKSWNXQGSCB> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A960", Offset = "0x2B89560", VA = "0x182B8A960")]
		public static Constraint New(Id32<YKSWNXQGSCB> lhs, Id32<YKSWNXQGSCB> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8B80", Offset = "0x2BA7780", VA = "0x182BA8B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class ZSIPCBMCTJU
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9AE0", Offset = "0x2BA86E0", VA = "0x182BA9AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5CC0", VA = "0x180EB70C0")]
		private Substitution(Id32<YKSWNXQGSCB> identifier, Id32<YKSWNXQGSCB> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A960", Offset = "0x2B89560", VA = "0x182B8A960")]
		public static Substitution New(Id32<YKSWNXQGSCB> identifier, Id32<YKSWNXQGSCB> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA93F0", Offset = "0x2BA7FF0", VA = "0x182BA93F0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA9480", Offset = "0x2BA8080", VA = "0x182BA9480")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9490", Offset = "0x2BA8090", VA = "0x182BA9490")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA9590", Offset = "0x2BA8190", VA = "0x182BA9590")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BA94A0", Offset = "0x2BA80A0", VA = "0x182BA94A0")]
		public static Term AOYXHDXRUOP([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9570", Offset = "0x2BA8170", VA = "0x182BA9570")]
		private Term(Id32<YKSWNXQGSCB> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA94C0", Offset = "0x2BA80C0", VA = "0x182BA94C0")]
		public static Term MEAALMEENER(Id32<YKSWNXQGSCB> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA94E0", Offset = "0x2BA80E0", VA = "0x182BA94E0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7644C00", Offset = "0x7643800", VA = "0x187644C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x50C4420", Offset = "0x50C3020", VA = "0x1850C4420")]
		protected XIKGHGUNYEN([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x50C3080", Offset = "0x50C1C80", VA = "0x1850C3080")]
		public static XIKGHGUNYEN<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x50C2D40", Offset = "0x50C1940", VA = "0x1850C2D40")]
		public Id32<YKSWNXQGSCB> HSIGJZIDCUQ()
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x50C2C00", Offset = "0x50C1800", VA = "0x1850C2C00")]
		public Id32<YKSWNXQGSCB> HDHMYIZHIDD(Id32<YKSWNXQGSCB> a, Id32<YKSWNXQGSCB> b)
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD53170", VA = "0x180D54570")]
		public Id32<YKSWNXQGSCB> SGABVFHOYOH(Id32<YKSWNXQGSCB> a)
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x50C3240", Offset = "0x50C1E40", VA = "0x1850C3240")]
		public void SVKCKSZOFWH(Id32<YKSWNXQGSCB> a, Id32<YKSWNXQGSCB> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x50C3B80", Offset = "0x50C2780", VA = "0x1850C3B80")]
		public Result<UBTYLTBVLTW[], ARGBUOZFZQD> Solve([In] a root)
		{
			return default(Result<UBTYLTBVLTW[], ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x50C2FC0", Offset = "0x50C1BC0", VA = "0x1850C2FC0")]
		public VCVTKBIEKIR IVSIKPONCPQ(Id32<YKSWNXQGSCB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DEDSWWEZCUX
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8C10", Offset = "0x2BA7810", VA = "0x182BA8C10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<YKSWNXQGSCB> KWEOHVETYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BA92F0", Offset = "0x2BA7EF0", VA = "0x182BA92F0", Slot = "5")]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private VCVTKBIEKIR PJCASZJJIKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private VCVTKBIEKIR NLWDANFKZOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1560", VA = "0x180CF2960")]
		private QMFXBANROZE(VCVTKBIEKIR a, VCVTKBIEKIR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9270", Offset = "0x2BA7E70", VA = "0x182BA9270")]
		public static QMFXBANROZE New(VCVTKBIEKIR from, VCVTKBIEKIR to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BA90F0", Offset = "0x2BA7CF0", VA = "0x182BA90F0", Slot = "8")]
		public bool Equals(VCVTKBIEKIR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9340", Offset = "0x2BA7F40", VA = "0x182BA9340", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<YKSWNXQGSCB> KWEOHVETYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110", Slot = "5")]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private VCVTKBIEKIR PJCASZJJIKU
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA90A0", Offset = "0x2BA7CA0", VA = "0x182BA90A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private VCVTKBIEKIR NLWDANFKZOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8FB0", Offset = "0x2BA7BB0", VA = "0x182BA8FB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1126BA0", Offset = "0x11257A0", VA = "0x181126BA0")]
		private PINFZOZWBKO(Id32<YKSWNXQGSCB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9000", Offset = "0x2BA7C00", VA = "0x182BA9000")]
		public static PINFZOZWBKO New(Id32<YKSWNXQGSCB> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E90", Offset = "0x2BA7A90", VA = "0x182BA8E90", Slot = "8")]
		public bool Equals(VCVTKBIEKIR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9060", Offset = "0x2BA7C60", VA = "0x182BA9060", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public VCVTKBIEKIR YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x108C5B0", Offset = "0x108B1B0", VA = "0x18108C5B0")]
		private UBTYLTBVLTW(Id32<YKSWNXQGSCB> a, VCVTKBIEKIR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9920", Offset = "0x2BA8520", VA = "0x182BA9920")]
		public static Result<UBTYLTBVLTW, ARGBUOZFZQD> XIFDVHYLLSM([In] Substitution substitution, IdArray<YKSWNXQGSCB, Term> a, Id32<YKSWNXQGSCB>[] b, IdArray<YKSWNXQGSCB, bool> c)
		{
			return default(Result<UBTYLTBVLTW, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BA95A0", Offset = "0x2BA81A0", VA = "0x182BA95A0")]
		private static Result<VCVTKBIEKIR, ARGBUOZFZQD> MGJTZCGSLKW(Id32<YKSWNXQGSCB> a, IdArray<YKSWNXQGSCB, Term> b, Id32<YKSWNXQGSCB>[] c, IdArray<YKSWNXQGSCB, bool> d)
		{
			return default(Result<VCVTKBIEKIR, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BA98B0", Offset = "0x2BA84B0", VA = "0x182BA98B0", Slot = "3")]
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
