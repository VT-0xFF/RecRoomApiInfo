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
	public interface ZFMZEQYTVOK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates URERMHZYYFX(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ESSANMMATEX
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6CA0", Offset = "0x2BA56A0", VA = "0x182BA6CA0")]
		public static Id32<XVAQNIQWTAN> XRGVVFSUNTB(this int a)
		{
			return default(Id32<XVAQNIQWTAN>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class XVAQNIQWTAN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class NOAURDFXAHM : JLTZKNUNHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6CE0", Offset = "0x2BA56E0", VA = "0x182BA6CE0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D10", Offset = "0x2BA5710", VA = "0x182BA6D10")]
		public NOAURDFXAHM()
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
			[Cpp2IlInjected.Address(RVA = "0x2BA6770", Offset = "0x2BA5170", VA = "0x182BA6770")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA67E0", Offset = "0x2BA51E0", VA = "0x182BA67E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA6900", Offset = "0x2BA5300", VA = "0x182BA6900")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6810", Offset = "0x2BA5210", VA = "0x182BA6810")]
		public static ApplyConstraintResult MYTOLQTWNOG([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BA68D0", Offset = "0x2BA52D0", VA = "0x182BA68D0")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6890", Offset = "0x2BA5290", VA = "0x182BA6890")]
		public static ApplyConstraintResult ZCYXJRMTBXN([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BA68C0", Offset = "0x2BA52C0", VA = "0x182BA68C0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA67F0", Offset = "0x2BA51F0", VA = "0x182BA67F0")]
		public static ApplyConstraintResult DZCKUUWPPVI()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<XVAQNIQWTAN> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<XVAQNIQWTAN> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
		private Arrow(Id32<XVAQNIQWTAN> from, Id32<XVAQNIQWTAN> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B89170", Offset = "0x2B87B70", VA = "0x182B89170")]
		public static Arrow New(Id32<XVAQNIQWTAN> from, Id32<XVAQNIQWTAN> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6980", Offset = "0x2BA5380", VA = "0x182BA6980", Slot = "3")]
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
		public readonly Id32<XVAQNIQWTAN> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<XVAQNIQWTAN> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
		private Constraint(Id32<XVAQNIQWTAN> lhs, Id32<XVAQNIQWTAN> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B89170", Offset = "0x2B87B70", VA = "0x182B89170")]
		public static Constraint New(Id32<XVAQNIQWTAN> lhs, Id32<XVAQNIQWTAN> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6C10", Offset = "0x2BA5610", VA = "0x182BA6C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class AYZTJZSSSVE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BA65B0", Offset = "0x2BA4FB0", VA = "0x182BA65B0")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<XVAQNIQWTAN, Term> terms, Id32<XVAQNIQWTAN>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<XVAQNIQWTAN> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<XVAQNIQWTAN> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
		private Substitution(Id32<XVAQNIQWTAN> identifier, Id32<XVAQNIQWTAN> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B89170", Offset = "0x2B87B70", VA = "0x182B89170")]
		public static Substitution New(Id32<XVAQNIQWTAN> identifier, Id32<XVAQNIQWTAN> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F80", Offset = "0x2BA5980", VA = "0x182BA6F80", Slot = "3")]
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
			public readonly Id32<XVAQNIQWTAN> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7550", Offset = "0x2BA5F50", VA = "0x182BA7550")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7560", Offset = "0x2BA5F60", VA = "0x182BA7560")]
			public TermImpl(Id32<XVAQNIQWTAN> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2BA7660", Offset = "0x2BA6060", VA = "0x182BA7660")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7590", Offset = "0x2BA5F90", VA = "0x182BA7590")]
		public static Term MWRHVEBHZNR([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7640", Offset = "0x2BA6040", VA = "0x182BA7640")]
		private Term(Id32<XVAQNIQWTAN> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7570", Offset = "0x2BA5F70", VA = "0x182BA7570")]
		public static Term HDWYNWGCQGV(Id32<XVAQNIQWTAN> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA75B0", Offset = "0x2BA5FB0", VA = "0x182BA75B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class XYBXGPHIXWB<a, b> where b : ZFMZEQYTVOK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class VBVXDSOHTWJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<XVAQNIQWTAN, Term> UQQLXRZOYPR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<XVAQNIQWTAN>[] QILRBCTCSMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<XVAQNIQWTAN, bool> KRLIIZQOIYA;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public VBVXDSOHTWJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7EB0B20", Offset = "0x7EAF520", VA = "0x187EB0B20")]
			internal Result<TMJRJGEPBYQ, JLTZKNUNHPJ> JANSAFBWBJO(Substitution a)
			{
				return default(Result<TMJRJGEPBYQ, JLTZKNUNHPJ>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> UFSQGNOBQHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> BSMHFPDBHYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b ANTAOVGZRYP;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x50A6560", Offset = "0x50A4F60", VA = "0x1850A6560")]
		protected XYBXGPHIXWB([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x50A4F80", Offset = "0x50A3980", VA = "0x1850A4F80")]
		public static XYBXGPHIXWB<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x50A52B0", Offset = "0x50A3CB0", VA = "0x1850A52B0")]
		public Id32<XVAQNIQWTAN> RMWEEGKUVWE()
		{
			return default(Id32<XVAQNIQWTAN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x50A4E40", Offset = "0x50A3840", VA = "0x1850A4E40")]
		public Id32<XVAQNIQWTAN> MANPTJHQPKV(Id32<XVAQNIQWTAN> a, Id32<XVAQNIQWTAN> b)
		{
			return default(Id32<XVAQNIQWTAN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD361D0", Offset = "0xD34BD0", VA = "0x180D361D0")]
		public Id32<XVAQNIQWTAN> DOPDVBKWPXV(Id32<XVAQNIQWTAN> a)
		{
			return default(Id32<XVAQNIQWTAN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x50A4BC0", Offset = "0x50A35C0", VA = "0x1850A4BC0")]
		public void ITCDROFPFBN(Id32<XVAQNIQWTAN> a, Id32<XVAQNIQWTAN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x50A53D0", Offset = "0x50A3DD0", VA = "0x1850A53D0")]
		public Result<TMJRJGEPBYQ[], JLTZKNUNHPJ> Solve([In] a root)
		{
			return default(Result<TMJRJGEPBYQ[], JLTZKNUNHPJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x50A4BB0", Offset = "0x50A35B0", VA = "0x1850A4BB0")]
		public WRPAOZFVZTD AFXQJGCWVRU(Id32<XVAQNIQWTAN> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class BGJGBORYPZF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6A10", Offset = "0x2BA5410", VA = "0x182BA6A10")]
		internal static Term OFLLHQWJNTI(Id32<XVAQNIQWTAN> a, IdArray<XVAQNIQWTAN, Term> b, Id32<XVAQNIQWTAN>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface WRPAOZFVZTD : IEquatable<WRPAOZFVZTD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind DPDMCSHWOIO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<XVAQNIQWTAN> QXEEDWWHLIG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		WRPAOZFVZTD XQULERANZPD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		WRPAOZFVZTD RTCMPAWHOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class WZFZNVEHTBE : WRPAOZFVZTD, IEquatable<WRPAOZFVZTD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly WRPAOZFVZTD UZUJHNAIGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly WRPAOZFVZTD FVJTWNSFHLL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind DPDMCSHWOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<XVAQNIQWTAN> PNRSVEPDHSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2BA7670", Offset = "0x2BA6070", VA = "0x182BA7670", Slot = "5")]
			get
			{
				return default(Id32<XVAQNIQWTAN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private WRPAOZFVZTD UFVNXYLQHXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private WRPAOZFVZTD QIGVQSFEQBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xCD4A70", Offset = "0xCD3470", VA = "0x180CD4A70")]
		private WZFZNVEHTBE(WRPAOZFVZTD a, WRPAOZFVZTD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7840", Offset = "0x2BA6240", VA = "0x182BA7840")]
		public static WZFZNVEHTBE New(WRPAOZFVZTD from, WRPAOZFVZTD to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BA76C0", Offset = "0x2BA60C0", VA = "0x182BA76C0", Slot = "8")]
		public bool Equals(WRPAOZFVZTD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BA78C0", Offset = "0x2BA62C0", VA = "0x182BA78C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class OGDPIXGEIWG : WRPAOZFVZTD, IEquatable<WRPAOZFVZTD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<XVAQNIQWTAN> YSLRVNQQVPD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind DPDMCSHWOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<XVAQNIQWTAN> PNRSVEPDHSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110", Slot = "5")]
			get
			{
				return default(Id32<XVAQNIQWTAN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private WRPAOZFVZTD UFVNXYLQHXK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6E40", Offset = "0x2BA5840", VA = "0x182BA6E40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private WRPAOZFVZTD QIGVQSFEQBD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6E90", Offset = "0x2BA5890", VA = "0x182BA6E90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x112ED20", Offset = "0x112D720", VA = "0x18112ED20")]
		private OGDPIXGEIWG(Id32<XVAQNIQWTAN> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6EE0", Offset = "0x2BA58E0", VA = "0x182BA6EE0")]
		public static OGDPIXGEIWG New(Id32<XVAQNIQWTAN> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D20", Offset = "0x2BA5720", VA = "0x182BA6D20", Slot = "8")]
		public bool Equals(WRPAOZFVZTD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F40", Offset = "0x2BA5940", VA = "0x182BA6F40", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class TMJRJGEPBYQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<XVAQNIQWTAN> LVYPECRPQWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<XVAQNIQWTAN>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCDFF30", Offset = "0xCDE930", VA = "0x180CDFF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public WRPAOZFVZTD YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1078050", Offset = "0x1076A50", VA = "0x181078050")]
		private TMJRJGEPBYQ(Id32<XVAQNIQWTAN> a, WRPAOZFVZTD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7010", Offset = "0x2BA5A10", VA = "0x182BA7010")]
		public static Result<TMJRJGEPBYQ, JLTZKNUNHPJ> JCUVFOFRSEI([In] Substitution substitution, IdArray<XVAQNIQWTAN, Term> a, Id32<XVAQNIQWTAN>[] b, IdArray<XVAQNIQWTAN, bool> c)
		{
			return default(Result<TMJRJGEPBYQ, JLTZKNUNHPJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7240", Offset = "0x2BA5C40", VA = "0x182BA7240")]
		private static Result<WRPAOZFVZTD, JLTZKNUNHPJ> UVHVSZAPUIC(Id32<XVAQNIQWTAN> a, IdArray<XVAQNIQWTAN, Term> b, Id32<XVAQNIQWTAN>[] c, IdArray<XVAQNIQWTAN, bool> d)
		{
			return default(Result<WRPAOZFVZTD, JLTZKNUNHPJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BA71D0", Offset = "0x2BA5BD0", VA = "0x182BA71D0", Slot = "3")]
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
