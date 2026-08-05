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
	public interface GHQHUOGIKCI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates OBTGJXOSLLZ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class HTJCKJXWYCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28A11A0", Offset = "0x28A05A0", VA = "0x1828A11A0")]
		public static Id32<GCSZUSBMJXZ> TCILXHEUPZH(this int a)
		{
			return default(Id32<GCSZUSBMJXZ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class GCSZUSBMJXZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class RYQPWKJEHRG : GKLIEWNFSHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28A13E0", Offset = "0x28A07E0", VA = "0x1828A13E0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28A1410", Offset = "0x28A0810", VA = "0x1828A1410")]
		public RYQPWKJEHRG()
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
			[Cpp2IlInjected.Address(RVA = "0x28A0910", Offset = "0x289FD10", VA = "0x1828A0910")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x28A0980", Offset = "0x289FD80", VA = "0x1828A0980")]
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
		[Cpp2IlInjected.Address(RVA = "0x28A0AA0", Offset = "0x289FEA0", VA = "0x1828A0AA0")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28A0990", Offset = "0x289FD90", VA = "0x1828A0990")]
		public static ApplyConstraintResult FRYLZDKMXCU([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28A0A70", Offset = "0x289FE70", VA = "0x1828A0A70")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28A0A10", Offset = "0x289FE10", VA = "0x1828A0A10")]
		public static ApplyConstraintResult RXZXAVRYGXL([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28A0A60", Offset = "0x289FE60", VA = "0x1828A0A60")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28A0A40", Offset = "0x289FE40", VA = "0x1828A0A40")]
		public static ApplyConstraintResult SXVZNEGAOHK()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<GCSZUSBMJXZ> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<GCSZUSBMJXZ> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
		private Arrow(Id32<GCSZUSBMJXZ> from, Id32<GCSZUSBMJXZ> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2882B80", Offset = "0x2881F80", VA = "0x182882B80")]
		public static Arrow New(Id32<GCSZUSBMJXZ> from, Id32<GCSZUSBMJXZ> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28A0B20", Offset = "0x289FF20", VA = "0x1828A0B20", Slot = "3")]
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
		public readonly Id32<GCSZUSBMJXZ> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<GCSZUSBMJXZ> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
		private Constraint(Id32<GCSZUSBMJXZ> lhs, Id32<GCSZUSBMJXZ> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2882B80", Offset = "0x2881F80", VA = "0x182882B80")]
		public static Constraint New(Id32<GCSZUSBMJXZ> lhs, Id32<GCSZUSBMJXZ> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28A0EB0", Offset = "0x28A02B0", VA = "0x1828A0EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class THRBGQCPTOU
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28A14B0", Offset = "0x28A08B0", VA = "0x1828A14B0")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<GCSZUSBMJXZ, Term> terms, Id32<GCSZUSBMJXZ>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<GCSZUSBMJXZ> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<GCSZUSBMJXZ> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBA6870", Offset = "0xBA5C70", VA = "0x180BA6870")]
		private Substitution(Id32<GCSZUSBMJXZ> identifier, Id32<GCSZUSBMJXZ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2882B80", Offset = "0x2881F80", VA = "0x182882B80")]
		public static Substitution New(Id32<GCSZUSBMJXZ> identifier, Id32<GCSZUSBMJXZ> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28A1420", Offset = "0x28A0820", VA = "0x1828A1420", Slot = "3")]
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
			public readonly Id32<GCSZUSBMJXZ> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x28A1BB0", Offset = "0x28A0FB0", VA = "0x1828A1BB0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x28A1BC0", Offset = "0x28A0FC0", VA = "0x1828A1BC0")]
			public TermImpl(Id32<GCSZUSBMJXZ> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x28A1CA0", Offset = "0x28A10A0", VA = "0x1828A1CA0")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28A1BD0", Offset = "0x28A0FD0", VA = "0x1828A1BD0")]
		public static Term LAHBBFMREMR([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28A1CB0", Offset = "0x28A10B0", VA = "0x1828A1CB0")]
		private Term(Id32<GCSZUSBMJXZ> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28A1BF0", Offset = "0x28A0FF0", VA = "0x1828A1BF0")]
		public static Term OZMWJVSCNFV(Id32<GCSZUSBMJXZ> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28A1C10", Offset = "0x28A1010", VA = "0x1828A1C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class LSXXHGXEEFJ<a, b> where b : GHQHUOGIKCI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class UMOAHPPLSQX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<GCSZUSBMJXZ, Term> DJDTHPNSDCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<GCSZUSBMJXZ>[] KVGJTBZZEGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<GCSZUSBMJXZ, bool> PGOZBHVNKPA;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UMOAHPPLSQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x612F7D0", Offset = "0x612EBD0", VA = "0x18612F7D0")]
			internal Result<TISUFEMQXQW, GKLIEWNFSHL> VQTIECHHUMW(Substitution a)
			{
				return default(Result<TISUFEMQXQW, GKLIEWNFSHL>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> SGBNLBQCAHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> XRLEUUFFRZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b MKZWHJKZWXT;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5306EC0", Offset = "0x53062C0", VA = "0x185306EC0")]
		protected LSXXHGXEEFJ([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5305A90", Offset = "0x5304E90", VA = "0x185305A90")]
		public static LSXXHGXEEFJ<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5306C40", Offset = "0x5306040", VA = "0x185306C40")]
		public Id32<GCSZUSBMJXZ> TNQPVQLDVAO()
		{
			return default(Id32<GCSZUSBMJXZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x53056D0", Offset = "0x5304AD0", VA = "0x1853056D0")]
		public Id32<GCSZUSBMJXZ> IPSJFGPCUOH(Id32<GCSZUSBMJXZ> a, Id32<GCSZUSBMJXZ> b)
		{
			return default(Id32<GCSZUSBMJXZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC34310", Offset = "0xC33710", VA = "0x180C34310")]
		public Id32<GCSZUSBMJXZ> AODAERRLJWF(Id32<GCSZUSBMJXZ> a)
		{
			return default(Id32<GCSZUSBMJXZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5305A20", Offset = "0x5304E20", VA = "0x185305A20")]
		public void NPJKIQZLBPD(Id32<GCSZUSBMJXZ> a, Id32<GCSZUSBMJXZ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5306550", Offset = "0x5305950", VA = "0x185306550")]
		public Result<TISUFEMQXQW[], GKLIEWNFSHL> Solve([In] a root)
		{
			return default(Result<TISUFEMQXQW[], GKLIEWNFSHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5305C60", Offset = "0x5305060", VA = "0x185305C60")]
		public ZRLRJQTAACD OTMSIXSDUSA(Id32<GCSZUSBMJXZ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KSCNDENXYUJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28A11E0", Offset = "0x28A05E0", VA = "0x1828A11E0")]
		internal static Term ZZFQAZNUUHK(Id32<GCSZUSBMJXZ> a, IdArray<GCSZUSBMJXZ, Term> b, Id32<GCSZUSBMJXZ>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ZRLRJQTAACD : IEquatable<ZRLRJQTAACD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind LAFGGLSRZTW
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<GCSZUSBMJXZ> HUMFVLLOODS
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		ZRLRJQTAACD LVZMNYQGVKX
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		ZRLRJQTAACD KISGUVPEKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class BTIGJUMKCSU : ZRLRJQTAACD, IEquatable<ZRLRJQTAACD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly ZRLRJQTAACD DNOITPUCOUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly ZRLRJQTAACD EZBGUMPEGDN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind LAFGGLSRZTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<GCSZUSBMJXZ> QSEZGYOQRLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x28A0D30", Offset = "0x28A0130", VA = "0x1828A0D30", Slot = "5")]
			get
			{
				return default(Id32<GCSZUSBMJXZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private ZRLRJQTAACD BTTQGZXTHQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ZRLRJQTAACD QZCEPXPECVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		private BTIGJUMKCSU(ZRLRJQTAACD a, ZRLRJQTAACD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28A0D80", Offset = "0x28A0180", VA = "0x1828A0D80")]
		public static BTIGJUMKCSU New(ZRLRJQTAACD from, ZRLRJQTAACD to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28A0BB0", Offset = "0x289FFB0", VA = "0x1828A0BB0", Slot = "8")]
		public bool Equals(ZRLRJQTAACD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28A0E00", Offset = "0x28A0200", VA = "0x1828A0E00", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class HITATHTPLFK : ZRLRJQTAACD, IEquatable<ZRLRJQTAACD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<GCSZUSBMJXZ> QEMSNQIEONV;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind LAFGGLSRZTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<GCSZUSBMJXZ> QSEZGYOQRLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110", Slot = "5")]
			get
			{
				return default(Id32<GCSZUSBMJXZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private ZRLRJQTAACD BTTQGZXTHQO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x28A10C0", Offset = "0x28A04C0", VA = "0x1828A10C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private ZRLRJQTAACD QZCEPXPECVR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x28A1110", Offset = "0x28A0510", VA = "0x1828A1110", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xE1F9F0", Offset = "0xE1EDF0", VA = "0x180E1F9F0")]
		private HITATHTPLFK(Id32<GCSZUSBMJXZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28A1060", Offset = "0x28A0460", VA = "0x1828A1060")]
		public static HITATHTPLFK New(Id32<GCSZUSBMJXZ> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28A0F40", Offset = "0x28A0340", VA = "0x1828A0F40", Slot = "8")]
		public bool Equals(ZRLRJQTAACD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28A1160", Offset = "0x28A0560", VA = "0x1828A1160", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class TISUFEMQXQW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<GCSZUSBMJXZ> OQGVUCEGDTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GCSZUSBMJXZ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ZRLRJQTAACD QEMSNQIEONV
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xD7A3C0", Offset = "0xD797C0", VA = "0x180D7A3C0")]
		private TISUFEMQXQW(Id32<GCSZUSBMJXZ> a, ZRLRJQTAACD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28A1980", Offset = "0x28A0D80", VA = "0x1828A1980")]
		public static Result<TISUFEMQXQW, GKLIEWNFSHL> MNGCMHZMWAC([In] Substitution substitution, IdArray<GCSZUSBMJXZ, Term> a, Id32<GCSZUSBMJXZ>[] b, IdArray<GCSZUSBMJXZ, bool> c)
		{
			return default(Result<TISUFEMQXQW, GKLIEWNFSHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28A1670", Offset = "0x28A0A70", VA = "0x1828A1670")]
		private static Result<ZRLRJQTAACD, GKLIEWNFSHL> KXFCXSWSDRW(Id32<GCSZUSBMJXZ> a, IdArray<GCSZUSBMJXZ, Term> b, Id32<GCSZUSBMJXZ>[] c, IdArray<GCSZUSBMJXZ, bool> d)
		{
			return default(Result<ZRLRJQTAACD, GKLIEWNFSHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28A1B40", Offset = "0x28A0F40", VA = "0x1828A1B40", Slot = "3")]
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
