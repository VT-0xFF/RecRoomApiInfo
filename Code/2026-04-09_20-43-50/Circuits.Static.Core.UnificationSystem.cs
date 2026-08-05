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
		[Cpp2IlInjected.Address(RVA = "0x2BBF010", Offset = "0x2BBE010", VA = "0x182BBF010")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBEFD0", Offset = "0x2BBDFD0", VA = "0x182BBEFD0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF000", Offset = "0x2BBE000", VA = "0x182BBF000")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BBEAA0", Offset = "0x2BBDAA0", VA = "0x182BBEAA0")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BBEB10", Offset = "0x2BBDB10", VA = "0x182BBEB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBEC30", Offset = "0x2BBDC30", VA = "0x182BBEC30")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEB70", Offset = "0x2BBDB70", VA = "0x182BBEB70")]
		public static ApplyConstraintResult VBLNOHGHTVM([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEC00", Offset = "0x2BBDC00", VA = "0x182BBEC00")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEB20", Offset = "0x2BBDB20", VA = "0x182BBEB20")]
		public static ApplyConstraintResult AHCSQMYCCBR([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEBF0", Offset = "0x2BBDBF0", VA = "0x182BBEBF0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEB50", Offset = "0x2BBDB50", VA = "0x182BBEB50")]
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
		[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
		private Arrow(Id32<YKSWNXQGSCB> from, Id32<YKSWNXQGSCB> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0B00", Offset = "0x2B9FB00", VA = "0x182BA0B00")]
		public static Arrow New(Id32<YKSWNXQGSCB> from, Id32<YKSWNXQGSCB> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBECB0", Offset = "0x2BBDCB0", VA = "0x182BBECB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
		private Constraint(Id32<YKSWNXQGSCB> lhs, Id32<YKSWNXQGSCB> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0B00", Offset = "0x2B9FB00", VA = "0x182BA0B00")]
		public static Constraint New(Id32<YKSWNXQGSCB> lhs, Id32<YKSWNXQGSCB> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BBED40", Offset = "0x2BBDD40", VA = "0x182BBED40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class ZSIPCBMCTJU
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFCA0", Offset = "0x2BBECA0", VA = "0x182BBFCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xED28F0", Offset = "0xED18F0", VA = "0x180ED28F0")]
		private Substitution(Id32<YKSWNXQGSCB> identifier, Id32<YKSWNXQGSCB> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0B00", Offset = "0x2B9FB00", VA = "0x182BA0B00")]
		public static Substitution New(Id32<YKSWNXQGSCB> identifier, Id32<YKSWNXQGSCB> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF5B0", Offset = "0x2BBE5B0", VA = "0x182BBF5B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BBF640", Offset = "0x2BBE640", VA = "0x182BBF640")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF650", Offset = "0x2BBE650", VA = "0x182BBF650")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BBF750", Offset = "0x2BBE750", VA = "0x182BBF750")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF660", Offset = "0x2BBE660", VA = "0x182BBF660")]
		public static Term AOYXHDXRUOP([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF730", Offset = "0x2BBE730", VA = "0x182BBF730")]
		private Term(Id32<YKSWNXQGSCB> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF680", Offset = "0x2BBE680", VA = "0x182BBF680")]
		public static Term MEAALMEENER(Id32<YKSWNXQGSCB> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF6A0", Offset = "0x2BBE6A0", VA = "0x182BBF6A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7788460", Offset = "0x7787460", VA = "0x187788460")]
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
		[Cpp2IlInjected.Address(RVA = "0x5113900", Offset = "0x5112900", VA = "0x185113900")]
		protected XIKGHGUNYEN([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51124D0", Offset = "0x51114D0", VA = "0x1851124D0")]
		public static XIKGHGUNYEN<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5112170", Offset = "0x5111170", VA = "0x185112170")]
		public Id32<YKSWNXQGSCB> HSIGJZIDCUQ()
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5112030", Offset = "0x5111030", VA = "0x185112030")]
		public Id32<YKSWNXQGSCB> HDHMYIZHIDD(Id32<YKSWNXQGSCB> a, Id32<YKSWNXQGSCB> b)
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD6F990", Offset = "0xD6E990", VA = "0x180D6F990")]
		public Id32<YKSWNXQGSCB> SGABVFHOYOH(Id32<YKSWNXQGSCB> a)
		{
			return default(Id32<YKSWNXQGSCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x51126A0", Offset = "0x51116A0", VA = "0x1851126A0")]
		public void SVKCKSZOFWH(Id32<YKSWNXQGSCB> a, Id32<YKSWNXQGSCB> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5113030", Offset = "0x5112030", VA = "0x185113030")]
		public Result<UBTYLTBVLTW[], ARGBUOZFZQD> Solve([In] a root)
		{
			return default(Result<UBTYLTBVLTW[], ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5112400", Offset = "0x5111400", VA = "0x185112400")]
		public VCVTKBIEKIR IVSIKPONCPQ(Id32<YKSWNXQGSCB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DEDSWWEZCUX
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBEDD0", Offset = "0x2BBDDD0", VA = "0x182BBEDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<YKSWNXQGSCB> KWEOHVETYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF4B0", Offset = "0x2BBE4B0", VA = "0x182BBF4B0", Slot = "5")]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private VCVTKBIEKIR PJCASZJJIKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private VCVTKBIEKIR NLWDANFKZOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		private QMFXBANROZE(VCVTKBIEKIR a, VCVTKBIEKIR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF430", Offset = "0x2BBE430", VA = "0x182BBF430")]
		public static QMFXBANROZE New(VCVTKBIEKIR from, VCVTKBIEKIR to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF2B0", Offset = "0x2BBE2B0", VA = "0x182BBF2B0", Slot = "8")]
		public bool Equals(VCVTKBIEKIR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF500", Offset = "0x2BBE500", VA = "0x182BBF500", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<YKSWNXQGSCB> KWEOHVETYGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110", Slot = "5")]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private VCVTKBIEKIR PJCASZJJIKU
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF260", Offset = "0x2BBE260", VA = "0x182BBF260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private VCVTKBIEKIR NLWDANFKZOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBF170", Offset = "0x2BBE170", VA = "0x182BBF170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1142940", Offset = "0x1141940", VA = "0x181142940")]
		private PINFZOZWBKO(Id32<YKSWNXQGSCB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF1C0", Offset = "0x2BBE1C0", VA = "0x182BBF1C0")]
		public static PINFZOZWBKO New(Id32<YKSWNXQGSCB> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF050", Offset = "0x2BBE050", VA = "0x182BBF050", Slot = "8")]
		public bool Equals(VCVTKBIEKIR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF220", Offset = "0x2BBE220", VA = "0x182BBF220", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<YKSWNXQGSCB>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD0CAC0", Offset = "0xD0BAC0", VA = "0x180D0CAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public VCVTKBIEKIR YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x10A82A0", Offset = "0x10A72A0", VA = "0x1810A82A0")]
		private UBTYLTBVLTW(Id32<YKSWNXQGSCB> a, VCVTKBIEKIR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFAE0", Offset = "0x2BBEAE0", VA = "0x182BBFAE0")]
		public static Result<UBTYLTBVLTW, ARGBUOZFZQD> XIFDVHYLLSM([In] Substitution substitution, IdArray<YKSWNXQGSCB, Term> a, Id32<YKSWNXQGSCB>[] b, IdArray<YKSWNXQGSCB, bool> c)
		{
			return default(Result<UBTYLTBVLTW, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF760", Offset = "0x2BBE760", VA = "0x182BBF760")]
		private static Result<VCVTKBIEKIR, ARGBUOZFZQD> MGJTZCGSLKW(Id32<YKSWNXQGSCB> a, IdArray<YKSWNXQGSCB, Term> b, Id32<YKSWNXQGSCB>[] c, IdArray<YKSWNXQGSCB, bool> d)
		{
			return default(Result<VCVTKBIEKIR, ARGBUOZFZQD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFA70", Offset = "0x2BBEA70", VA = "0x182BBFA70", Slot = "3")]
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
