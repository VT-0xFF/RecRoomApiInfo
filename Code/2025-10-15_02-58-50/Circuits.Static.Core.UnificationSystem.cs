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
	public interface YTUDMBCVPQT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates KDZUZAKJCJU(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class OBWUNZYSCYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B44E00", Offset = "0x2B43C00", VA = "0x182B44E00")]
		public static Id32<BOBYAKZQBIA> UCERBUDGLYA(this int a)
		{
			return default(Id32<BOBYAKZQBIA>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class BOBYAKZQBIA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class DMSMETLRIUB : NLAHVKALZBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B441C0", Offset = "0x2B42FC0", VA = "0x182B441C0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B441F0", Offset = "0x2B42FF0", VA = "0x182B441F0")]
		public DMSMETLRIUB()
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
			[Cpp2IlInjected.Address(RVA = "0x2B43E90", Offset = "0x2B42C90", VA = "0x182B43E90")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x2B43F00", Offset = "0x2B42D00", VA = "0x182B43F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B44020", Offset = "0x2B42E20", VA = "0x182B44020")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F10", Offset = "0x2B42D10", VA = "0x182B43F10")]
		public static ApplyConstraintResult AAORNSJQNDD([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B43FF0", Offset = "0x2B42DF0", VA = "0x182B43FF0")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B43FB0", Offset = "0x2B42DB0", VA = "0x182B43FB0")]
		public static ApplyConstraintResult NTYAIEMWZHE([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B43FE0", Offset = "0x2B42DE0", VA = "0x182B43FE0")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F90", Offset = "0x2B42D90", VA = "0x182B43F90")]
		public static ApplyConstraintResult BSXZMPDSGRR()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<BOBYAKZQBIA> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<BOBYAKZQBIA> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
		private Arrow(Id32<BOBYAKZQBIA> from, Id32<BOBYAKZQBIA> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B60", Offset = "0x2B24960", VA = "0x182B25B60")]
		public static Arrow New(Id32<BOBYAKZQBIA> from, Id32<BOBYAKZQBIA> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B440A0", Offset = "0x2B42EA0", VA = "0x182B440A0", Slot = "3")]
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
		public readonly Id32<BOBYAKZQBIA> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<BOBYAKZQBIA> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
		private Constraint(Id32<BOBYAKZQBIA> lhs, Id32<BOBYAKZQBIA> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B60", Offset = "0x2B24960", VA = "0x182B25B60")]
		public static Constraint New(Id32<BOBYAKZQBIA> lhs, Id32<BOBYAKZQBIA> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B44130", Offset = "0x2B42F30", VA = "0x182B44130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class HBFGGDTEKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B44500", Offset = "0x2B43300", VA = "0x182B44500")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<BOBYAKZQBIA, Term> terms, Id32<BOBYAKZQBIA>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<BOBYAKZQBIA> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<BOBYAKZQBIA> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xF29E50", Offset = "0xF28C50", VA = "0x180F29E50")]
		private Substitution(Id32<BOBYAKZQBIA> identifier, Id32<BOBYAKZQBIA> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B60", Offset = "0x2B24960", VA = "0x182B25B60")]
		public static Substitution New(Id32<BOBYAKZQBIA> identifier, Id32<BOBYAKZQBIA> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B450A0", Offset = "0x2B43EA0", VA = "0x182B450A0", Slot = "3")]
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
			public readonly Id32<BOBYAKZQBIA> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2B45130", Offset = "0x2B43F30", VA = "0x182B45130")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2B45140", Offset = "0x2B43F40", VA = "0x182B45140")]
			public TermImpl(Id32<BOBYAKZQBIA> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x2B45240", Offset = "0x2B44040", VA = "0x182B45240")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B45170", Offset = "0x2B43F70", VA = "0x182B45170")]
		public static Term JJPJXBTOVQY([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B45220", Offset = "0x2B44020", VA = "0x182B45220")]
		private Term(Id32<BOBYAKZQBIA> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B45150", Offset = "0x2B43F50", VA = "0x182B45150")]
		public static Term FNPSEKESQKA(Id32<BOBYAKZQBIA> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B45190", Offset = "0x2B43F90", VA = "0x182B45190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class NVDXPKNXLYY<a, b> where b : YTUDMBCVPQT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class IEWMQXGPNAW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<BOBYAKZQBIA, Term> WTSGFVXLGVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<BOBYAKZQBIA>[] XYYSAJSYASM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<BOBYAKZQBIA, bool> UAYPBLWOMSJ;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public IEWMQXGPNAW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x51DBE60", Offset = "0x51DAC60", VA = "0x1851DBE60")]
			internal Result<NYCIDYHYVAR, NLAHVKALZBM> JOCRTWPTJVL(Substitution a)
			{
				return default(Result<NYCIDYHYVAR, NLAHVKALZBM>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> IAZQUVWBXJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> CAGHRRFKLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b RHEDUJJJYXY;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5A42B10", Offset = "0x5A41910", VA = "0x185A42B10")]
		protected NVDXPKNXLYY([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5A41420", Offset = "0x5A40220", VA = "0x185A41420")]
		public static NVDXPKNXLYY<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5A41300", Offset = "0x5A40100", VA = "0x185A41300")]
		public Id32<BOBYAKZQBIA> GEVVOREERUJ()
		{
			return default(Id32<BOBYAKZQBIA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5A42830", Offset = "0x5A41630", VA = "0x185A42830")]
		public Id32<BOBYAKZQBIA> YVAUDRWEJNW(Id32<BOBYAKZQBIA> a, Id32<BOBYAKZQBIA> b)
		{
			return default(Id32<BOBYAKZQBIA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC34580", Offset = "0xC33380", VA = "0x180C34580")]
		public Id32<BOBYAKZQBIA> RMMKMJSZRBO(Id32<BOBYAKZQBIA> a)
		{
			return default(Id32<BOBYAKZQBIA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5A415F0", Offset = "0x5A403F0", VA = "0x185A415F0")]
		public void SMQRHLHUOYM(Id32<BOBYAKZQBIA> a, Id32<BOBYAKZQBIA> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5A41710", Offset = "0x5A40510", VA = "0x185A41710")]
		public Result<NYCIDYHYVAR[], NLAHVKALZBM> Solve([In] a root)
		{
			return default(Result<NYCIDYHYVAR[], NLAHVKALZBM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5A41700", Offset = "0x5A40500", VA = "0x185A41700")]
		public UWJRGFWROTK SNAUHMPCTDH(Id32<BOBYAKZQBIA> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class INZLHNHRQJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B446C0", Offset = "0x2B434C0", VA = "0x182B446C0")]
		internal static Term RPIRIGRNPMX(Id32<BOBYAKZQBIA> a, IdArray<BOBYAKZQBIA, Term> b, Id32<BOBYAKZQBIA>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface UWJRGFWROTK : IEquatable<UWJRGFWROTK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind KFDHSHLWAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<BOBYAKZQBIA> LRAXCQGIGGF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		UWJRGFWROTK EIUBRKUWGKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		UWJRGFWROTK ZPXGQSJAHQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class FDUKSREIBXD : UWJRGFWROTK, IEquatable<UWJRGFWROTK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly UWJRGFWROTK SEKLOUDQVPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly UWJRGFWROTK HLJYPCQAUTM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind KFDHSHLWAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<BOBYAKZQBIA> GGEFJYCYVUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2B444B0", Offset = "0x2B432B0", VA = "0x182B444B0", Slot = "5")]
			get
			{
				return default(Id32<BOBYAKZQBIA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private UWJRGFWROTK YQLIDJKUEVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private UWJRGFWROTK RRURVFOFABA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA5770", Offset = "0xAA4570", VA = "0x180AA5770")]
		private FDUKSREIBXD(UWJRGFWROTK a, UWJRGFWROTK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B44380", Offset = "0x2B43180", VA = "0x182B44380")]
		public static FDUKSREIBXD New(UWJRGFWROTK from, UWJRGFWROTK to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B44200", Offset = "0x2B43000", VA = "0x182B44200", Slot = "8")]
		public bool Equals(UWJRGFWROTK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B44400", Offset = "0x2B43200", VA = "0x182B44400", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class RLYRQQYLSFN : UWJRGFWROTK, IEquatable<UWJRGFWROTK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<BOBYAKZQBIA> XDXPKJAQNFO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind KFDHSHLWAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<BOBYAKZQBIA> GGEFJYCYVUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110", Slot = "5")]
			get
			{
				return default(Id32<BOBYAKZQBIA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private UWJRGFWROTK YQLIDJKUEVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2B44FB0", Offset = "0x2B43DB0", VA = "0x182B44FB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private UWJRGFWROTK RRURVFOFABA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2B44E40", Offset = "0x2B43C40", VA = "0x182B44E40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1181FF0", Offset = "0x1180DF0", VA = "0x181181FF0")]
		private RLYRQQYLSFN(Id32<BOBYAKZQBIA> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B45000", Offset = "0x2B43E00", VA = "0x182B45000")]
		public static RLYRQQYLSFN New(Id32<BOBYAKZQBIA> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B44E90", Offset = "0x2B43C90", VA = "0x182B44E90", Slot = "8")]
		public bool Equals(UWJRGFWROTK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B45060", Offset = "0x2B43E60", VA = "0x182B45060", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class NYCIDYHYVAR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<BOBYAKZQBIA> WBRSHDLSFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BOBYAKZQBIA>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAAA950", Offset = "0xAA9750", VA = "0x180AAA950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public UWJRGFWROTK XDXPKJAQNFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x10EFBB0", Offset = "0x10EE9B0", VA = "0x1810EFBB0")]
		private NYCIDYHYVAR(Id32<BOBYAKZQBIA> a, UWJRGFWROTK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B44C40", Offset = "0x2B43A40", VA = "0x182B44C40")]
		public static Result<NYCIDYHYVAR, NLAHVKALZBM> YXQLFUWKFHH([In] Substitution substitution, IdArray<BOBYAKZQBIA, Term> a, Id32<BOBYAKZQBIA>[] b, IdArray<BOBYAKZQBIA, bool> c)
		{
			return default(Result<NYCIDYHYVAR, NLAHVKALZBM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B448C0", Offset = "0x2B436C0", VA = "0x182B448C0")]
		private static Result<UWJRGFWROTK, NLAHVKALZBM> FRXKMALRQKL(Id32<BOBYAKZQBIA> a, IdArray<BOBYAKZQBIA, Term> b, Id32<BOBYAKZQBIA>[] c, IdArray<BOBYAKZQBIA, bool> d)
		{
			return default(Result<UWJRGFWROTK, NLAHVKALZBM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B44BD0", Offset = "0x2B439D0", VA = "0x182B44BD0", Slot = "3")]
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
