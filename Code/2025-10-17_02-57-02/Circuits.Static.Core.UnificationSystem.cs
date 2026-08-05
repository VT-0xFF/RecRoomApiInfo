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
	public interface UWPCASDNCUG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates TBAWTTYZFHT(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EJNDQFJVHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FD60", Offset = "0x2B2E360", VA = "0x182B2FD60")]
		public static Id32<EPCLSBZFMCJ> XXQLQNRJIXZ(this int a)
		{
			return default(Id32<EPCLSBZFMCJ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class EPCLSBZFMCJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class QOHOKUWQWAW : VMQHICPCFYT
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FDA0", Offset = "0x2B2E3A0", VA = "0x182B2FDA0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FDD0", Offset = "0x2B2E3D0", VA = "0x182B2FDD0")]
		public QOHOKUWQWAW()
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
			[Cpp2IlInjected.Address(RVA = "0x2B2F870", Offset = "0x2B2DE70", VA = "0x182B2F870")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F8E0", Offset = "0x2B2DEE0", VA = "0x182B2F8E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2FA00", Offset = "0x2B2E000", VA = "0x182B2FA00")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F920", Offset = "0x2B2DF20", VA = "0x182B2F920")]
		public static ApplyConstraintResult IYSDUSCMBGK([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F9D0", Offset = "0x2B2DFD0", VA = "0x182B2F9D0")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F8F0", Offset = "0x2B2DEF0", VA = "0x182B2F8F0")]
		public static ApplyConstraintResult GVTRNVFPDFV([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F9C0", Offset = "0x2B2DFC0", VA = "0x182B2F9C0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F9A0", Offset = "0x2B2DFA0", VA = "0x182B2F9A0")]
		public static ApplyConstraintResult VPIJTBXCBPQ()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<EPCLSBZFMCJ> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<EPCLSBZFMCJ> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
		private Arrow(Id32<EPCLSBZFMCJ> from, Id32<EPCLSBZFMCJ> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C90", Offset = "0x2B10290", VA = "0x182B11C90")]
		public static Arrow New(Id32<EPCLSBZFMCJ> from, Id32<EPCLSBZFMCJ> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FA80", Offset = "0x2B2E080", VA = "0x182B2FA80", Slot = "3")]
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
		public readonly Id32<EPCLSBZFMCJ> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<EPCLSBZFMCJ> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
		private Constraint(Id32<EPCLSBZFMCJ> lhs, Id32<EPCLSBZFMCJ> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C90", Offset = "0x2B10290", VA = "0x182B11C90")]
		public static Constraint New(Id32<EPCLSBZFMCJ> lhs, Id32<EPCLSBZFMCJ> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FCD0", Offset = "0x2B2E2D0", VA = "0x182B2FCD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class CDZWMXLJWNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FB10", Offset = "0x2B2E110", VA = "0x182B2FB10")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<EPCLSBZFMCJ, Term> terms, Id32<EPCLSBZFMCJ>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<EPCLSBZFMCJ> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<EPCLSBZFMCJ> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xF2E190", Offset = "0xF2C790", VA = "0x180F2E190")]
		private Substitution(Id32<EPCLSBZFMCJ> identifier, Id32<EPCLSBZFMCJ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C90", Offset = "0x2B10290", VA = "0x182B11C90")]
		public static Substitution New(Id32<EPCLSBZFMCJ> identifier, Id32<EPCLSBZFMCJ> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FDE0", Offset = "0x2B2E3E0", VA = "0x182B2FDE0", Slot = "3")]
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
			public readonly Id32<EPCLSBZFMCJ> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FE70", Offset = "0x2B2E470", VA = "0x182B2FE70")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2B2FE80", Offset = "0x2B2E480", VA = "0x182B2FE80")]
			public TermImpl(Id32<EPCLSBZFMCJ> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2B2FF60", Offset = "0x2B2E560", VA = "0x182B2FF60")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FF40", Offset = "0x2B2E540", VA = "0x182B2FF40")]
		public static Term ZZEMWHSABMP([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FF70", Offset = "0x2B2E570", VA = "0x182B2FF70")]
		private Term(Id32<EPCLSBZFMCJ> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FE90", Offset = "0x2B2E490", VA = "0x182B2FE90")]
		public static Term JSRCNEVTABT(Id32<EPCLSBZFMCJ> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FEB0", Offset = "0x2B2E4B0", VA = "0x182B2FEB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class UVKEDGUURQR<a, b> where b : UWPCASDNCUG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PMCLZVAKTMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<EPCLSBZFMCJ, Term> MQZWMFWSTXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<EPCLSBZFMCJ>[] BHZFGMFAKOR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<EPCLSBZFMCJ, bool> GXIUKWJVYIE;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PMCLZVAKTMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5C86CA0", Offset = "0x5C852A0", VA = "0x185C86CA0")]
			internal Result<AVHYLQQRJRK, VMQHICPCFYT> MCTODJABBSY(Substitution a)
			{
				return default(Result<AVHYLQQRJRK, VMQHICPCFYT>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> BRKZWXPAMYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> CRCDLBXHZBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b KUPOYFERZJZ;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x63C2770", Offset = "0x63C0D70", VA = "0x1863C2770")]
		protected UVKEDGUURQR([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63C1320", Offset = "0x63BF920", VA = "0x1863C1320")]
		public static UVKEDGUURQR<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63C0F90", Offset = "0x63BF590", VA = "0x1863C0F90")]
		public Id32<EPCLSBZFMCJ> AWHIWRQILYU()
		{
			return default(Id32<EPCLSBZFMCJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63C24C0", Offset = "0x63C0AC0", VA = "0x1863C24C0")]
		public Id32<EPCLSBZFMCJ> YOHXTDHWEJH(Id32<EPCLSBZFMCJ> a, Id32<EPCLSBZFMCJ> b)
		{
			return default(Id32<EPCLSBZFMCJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC3C7B0", Offset = "0xC3ADB0", VA = "0x180C3C7B0")]
		public Id32<EPCLSBZFMCJ> OXUPZUIFZAP(Id32<EPCLSBZFMCJ> a)
		{
			return default(Id32<EPCLSBZFMCJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63C1210", Offset = "0x63BF810", VA = "0x1863C1210")]
		public void HMTVOSZUYWT(Id32<EPCLSBZFMCJ> a, Id32<EPCLSBZFMCJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x63C1500", Offset = "0x63BFB00", VA = "0x1863C1500")]
		public Result<AVHYLQQRJRK[], VMQHICPCFYT> Solve([In] a root)
		{
			return default(Result<AVHYLQQRJRK[], VMQHICPCFYT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63C14F0", Offset = "0x63BFAF0", VA = "0x1863C14F0")]
		public SWBVZPJLBLX OGTBPAGJHHE(Id32<EPCLSBZFMCJ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class ZQFJCVYANKP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B301F0", Offset = "0x2B2E7F0", VA = "0x182B301F0")]
		internal static Term VBNQIUYXIUO(Id32<EPCLSBZFMCJ> a, IdArray<EPCLSBZFMCJ, Term> b, Id32<EPCLSBZFMCJ>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface SWBVZPJLBLX : IEquatable<SWBVZPJLBLX>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind CXTXOPLXEQC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<EPCLSBZFMCJ> BXFDPVBGOPY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		SWBVZPJLBLX JVSIZQPODJD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		SWBVZPJLBLX MNRJQPVMDOY
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class ANCSELBIWTQ : SWBVZPJLBLX, IEquatable<SWBVZPJLBLX>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly SWBVZPJLBLX VEAIAPDXKCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly SWBVZPJLBLX UAFJOBCUKMB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind CXTXOPLXEQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<EPCLSBZFMCJ> KNRXUMCKDER
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F1B0", Offset = "0x2B2D7B0", VA = "0x182B2F1B0", Slot = "5")]
			get
			{
				return default(Id32<EPCLSBZFMCJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private SWBVZPJLBLX NZSSSTWXXMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private SWBVZPJLBLX RCIYSNFFVND
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		private ANCSELBIWTQ(SWBVZPJLBLX a, SWBVZPJLBLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F200", Offset = "0x2B2D800", VA = "0x182B2F200")]
		public static ANCSELBIWTQ New(SWBVZPJLBLX from, SWBVZPJLBLX to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F030", Offset = "0x2B2D630", VA = "0x182B2F030", Slot = "8")]
		public bool Equals(SWBVZPJLBLX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F280", Offset = "0x2B2D880", VA = "0x182B2F280", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class XFQHRPEGJFI : SWBVZPJLBLX, IEquatable<SWBVZPJLBLX>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<EPCLSBZFMCJ> HOYELULZOXT;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind CXTXOPLXEQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<EPCLSBZFMCJ> KNRXUMCKDER
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110", Slot = "5")]
			get
			{
				return default(Id32<EPCLSBZFMCJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private SWBVZPJLBLX NZSSSTWXXMM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2B30100", Offset = "0x2B2E700", VA = "0x182B30100", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private SWBVZPJLBLX RCIYSNFFVND
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B300B0", Offset = "0x2B2E6B0", VA = "0x182B300B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1184770", Offset = "0x1182D70", VA = "0x181184770")]
		private XFQHRPEGJFI(Id32<EPCLSBZFMCJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B30150", Offset = "0x2B2E750", VA = "0x182B30150")]
		public static XFQHRPEGJFI New(Id32<EPCLSBZFMCJ> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FF90", Offset = "0x2B2E590", VA = "0x182B2FF90", Slot = "8")]
		public bool Equals(SWBVZPJLBLX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B301B0", Offset = "0x2B2E7B0", VA = "0x182B301B0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class AVHYLQQRJRK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<EPCLSBZFMCJ> SNTOXKRGJFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<EPCLSBZFMCJ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SWBVZPJLBLX HOYELULZOXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x10F35E0", Offset = "0x10F1BE0", VA = "0x1810F35E0")]
		private AVHYLQQRJRK(Id32<EPCLSBZFMCJ> a, SWBVZPJLBLX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F330", Offset = "0x2B2D930", VA = "0x182B2F330")]
		public static Result<AVHYLQQRJRK, VMQHICPCFYT> KEQEAHFLIHO([In] Substitution substitution, IdArray<EPCLSBZFMCJ, Term> a, Id32<EPCLSBZFMCJ>[] b, IdArray<EPCLSBZFMCJ, bool> c)
		{
			return default(Result<AVHYLQQRJRK, VMQHICPCFYT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F4F0", Offset = "0x2B2DAF0", VA = "0x182B2F4F0")]
		private static Result<SWBVZPJLBLX, VMQHICPCFYT> LEIDUJRRPVY(Id32<EPCLSBZFMCJ> a, IdArray<EPCLSBZFMCJ, Term> b, Id32<EPCLSBZFMCJ>[] c, IdArray<EPCLSBZFMCJ, bool> d)
		{
			return default(Result<SWBVZPJLBLX, VMQHICPCFYT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F800", Offset = "0x2B2DE00", VA = "0x182B2F800", Slot = "3")]
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
