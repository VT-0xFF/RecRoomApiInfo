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
	public interface IRREUTSWWRI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates GVEFFOYCAKN(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class UQAGWEKRRTJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29308E0", Offset = "0x292FAE0", VA = "0x1829308E0")]
		public static Id32<BITKYMLEUEZ> LUQSELLGRVF(this int a)
		{
			return default(Id32<BITKYMLEUEZ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class BITKYMLEUEZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class LVBYPUIPTEW : VTISYMIGLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x29306F0", Offset = "0x292F8F0", VA = "0x1829306F0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2930720", Offset = "0x292F920", VA = "0x182930720")]
		public LVBYPUIPTEW()
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
			[Cpp2IlInjected.Address(RVA = "0x292FAC0", Offset = "0x292ECC0", VA = "0x18292FAC0")]
			public ApplyConstraintResultImpl([In] Constraint first, [In] Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x292FB30", Offset = "0x292ED30", VA = "0x18292FB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x292FC50", Offset = "0x292EE50", VA = "0x18292FC50")]
		private ApplyConstraintResult([In] Constraint first, [In] Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x292FB90", Offset = "0x292ED90", VA = "0x18292FB90")]
		public static ApplyConstraintResult LQODHIBJJTU([In] Constraint first, [In] Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x292FC20", Offset = "0x292EE20", VA = "0x18292FC20")]
		private ApplyConstraintResult([In] Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x292FB40", Offset = "0x292ED40", VA = "0x18292FB40")]
		public static ApplyConstraintResult ISADAPMLFKX([In] Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x292FC10", Offset = "0x292EE10", VA = "0x18292FC10")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x292FB70", Offset = "0x292ED70", VA = "0x18292FB70")]
		public static ApplyConstraintResult JNZDGUWDMVM()
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct Arrow
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id32<BITKYMLEUEZ> From;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<BITKYMLEUEZ> To;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
		private Arrow(Id32<BITKYMLEUEZ> from, Id32<BITKYMLEUEZ> to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2912610", Offset = "0x2911810", VA = "0x182912610")]
		public static Arrow New(Id32<BITKYMLEUEZ> from, Id32<BITKYMLEUEZ> to)
		{
			return default(Arrow);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x292FCD0", Offset = "0x292EED0", VA = "0x18292FCD0", Slot = "3")]
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
		public readonly Id32<BITKYMLEUEZ> Lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<BITKYMLEUEZ> Rhs;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
		private Constraint(Id32<BITKYMLEUEZ> lhs, Id32<BITKYMLEUEZ> rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2912610", Offset = "0x2911810", VA = "0x182912610")]
		public static Constraint New(Id32<BITKYMLEUEZ> lhs, Id32<BITKYMLEUEZ> rhs)
		{
			return default(Constraint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x292FD60", Offset = "0x292EF60", VA = "0x18292FD60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class HPPCMJSKCWS
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2930530", Offset = "0x292F730", VA = "0x182930530")]
		public static ApplyConstraintResult Apply([In] this Constraint self, IdArray<BITKYMLEUEZ, Term> terms, Id32<BITKYMLEUEZ>[] termsToUpdateBuffer)
		{
			return default(ApplyConstraintResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct Substitution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<BITKYMLEUEZ> Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<BITKYMLEUEZ> Value;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
		private Substitution(Id32<BITKYMLEUEZ> identifier, Id32<BITKYMLEUEZ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2912610", Offset = "0x2911810", VA = "0x182912610")]
		public static Substitution New(Id32<BITKYMLEUEZ> identifier, Id32<BITKYMLEUEZ> value)
		{
			return default(Substitution);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2930730", Offset = "0x292F930", VA = "0x182930730", Slot = "3")]
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
			public readonly Id32<BITKYMLEUEZ> Identifier;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x29307C0", Offset = "0x292F9C0", VA = "0x1829307C0")]
			public TermImpl([In] Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x29307D0", Offset = "0x292F9D0", VA = "0x1829307D0")]
			public TermImpl(Id32<BITKYMLEUEZ> identifier)
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
		[Cpp2IlInjected.Address(RVA = "0x29308B0", Offset = "0x292FAB0", VA = "0x1829308B0")]
		private Term([In] Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2930800", Offset = "0x292FA00", VA = "0x182930800")]
		public static Term JTOWOGPIEJN([In] Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x29308C0", Offset = "0x292FAC0", VA = "0x1829308C0")]
		private Term(Id32<BITKYMLEUEZ> identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x29307E0", Offset = "0x292F9E0", VA = "0x1829307E0")]
		public static Term GTQJJKVKHSZ(Id32<BITKYMLEUEZ> a)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2930820", Offset = "0x292FA20", VA = "0x182930820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class QLCAPXSBBAV<a, b> where b : IRREUTSWWRI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class SZVZAOYZOQR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IdArray<BITKYMLEUEZ, Term> BBUJBZVFVTF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Id32<BITKYMLEUEZ>[] OOFFPMBTHHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IdArray<BITKYMLEUEZ, bool> JMZFRSNJMAQ;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public SZVZAOYZOQR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5F83B30", Offset = "0x5F82D30", VA = "0x185F83B30")]
			internal Result<EQBAFDWUSOQ, VTISYMIGLDB> BQTZPTVSZAQ(Substitution a)
			{
				return default(Result<EQBAFDWUSOQ, VTISYMIGLDB>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<Term> BFYQZDTOQMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Stack<Constraint> JEXQOHUPAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly b SNMLORCJSFB;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5CB5F30", Offset = "0x5CB5130", VA = "0x185CB5F30")]
		protected QLCAPXSBBAV([In] b deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4980", Offset = "0x5CB3B80", VA = "0x185CB4980")]
		public static QLCAPXSBBAV<a, b> New([In] b deps)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4CD0", Offset = "0x5CB3ED0", VA = "0x185CB4CD0")]
		public Id32<BITKYMLEUEZ> SMQTLUGBXKE()
		{
			return default(Id32<BITKYMLEUEZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4840", Offset = "0x5CB3A40", VA = "0x185CB4840")]
		public Id32<BITKYMLEUEZ> ABHSLMGJANT(Id32<BITKYMLEUEZ> a, Id32<BITKYMLEUEZ> b)
		{
			return default(Id32<BITKYMLEUEZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB19EF0", Offset = "0xB190F0", VA = "0x180B19EF0")]
		public Id32<BITKYMLEUEZ> PYFNRDUQBUT(Id32<BITKYMLEUEZ> a)
		{
			return default(Id32<BITKYMLEUEZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5CB5E10", Offset = "0x5CB5010", VA = "0x185CB5E10")]
		public void VWFNFFTYMMT(Id32<BITKYMLEUEZ> a, Id32<BITKYMLEUEZ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4DF0", Offset = "0x5CB3FF0", VA = "0x185CB4DF0")]
		public Result<EQBAFDWUSOQ[], VTISYMIGLDB> Solve([In] a root)
		{
			return default(Result<EQBAFDWUSOQ[], VTISYMIGLDB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5CB5F20", Offset = "0x5CB5120", VA = "0x185CB5F20")]
		public ESZRIAQUGWR VYQUMWZVFJU(Id32<BITKYMLEUEZ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FWWGZWUFQCX
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2930330", Offset = "0x292F530", VA = "0x182930330")]
		internal static Term INMPJHUDDUO(Id32<BITKYMLEUEZ> a, IdArray<BITKYMLEUEZ, Term> b, Id32<BITKYMLEUEZ>[] c)
		{
			return default(Term);
		}
	}
}
namespace Circuits.Static.Core.UnificationSystem.Reference
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ESZRIAQUGWR : IEquatable<ESZRIAQUGWR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TermKind EQBNTADKZHU
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Id32<BITKYMLEUEZ> QIPUMVHKDSS
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		ESZRIAQUGWR PKCOMLRZADX
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		ESZRIAQUGWR LGSABZCRJOE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal sealed class WZLWCZQVHVE : ESZRIAQUGWR, IEquatable<ESZRIAQUGWR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly ESZRIAQUGWR LAIOMVHWHEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly ESZRIAQUGWR JFIMDWJCFIB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TermKind EQBNTADKZHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Id32<BITKYMLEUEZ> IKCWJVHPCFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2930B20", Offset = "0x292FD20", VA = "0x182930B20", Slot = "5")]
			get
			{
				return default(Id32<BITKYMLEUEZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private ESZRIAQUGWR EVJNGKKGRMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ESZRIAQUGWR IPHLVYVHYNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xAC0190", VA = "0x180AC0F90")]
		private WZLWCZQVHVE(ESZRIAQUGWR a, ESZRIAQUGWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2930AA0", Offset = "0x292FCA0", VA = "0x182930AA0")]
		public static WZLWCZQVHVE New(ESZRIAQUGWR from, ESZRIAQUGWR to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2930920", Offset = "0x292FB20", VA = "0x182930920", Slot = "8")]
		public bool Equals(ESZRIAQUGWR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2930B70", Offset = "0x292FD70", VA = "0x182930B70", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class XZLGRDXRTXQ : ESZRIAQUGWR, IEquatable<ESZRIAQUGWR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly Id32<BITKYMLEUEZ> LRBPAVAYBMJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TermKind EQBNTADKZHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Id32<BITKYMLEUEZ> IKCWJVHPCFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB4310", VA = "0x180AB5110", Slot = "5")]
			get
			{
				return default(Id32<BITKYMLEUEZ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private ESZRIAQUGWR EVJNGKKGRMI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2930D40", Offset = "0x292FF40", VA = "0x182930D40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private ESZRIAQUGWR IPHLVYVHYNL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2930E30", Offset = "0x2930030", VA = "0x182930E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xEC5A40", Offset = "0xEC4C40", VA = "0x180EC5A40")]
		private XZLGRDXRTXQ(Id32<BITKYMLEUEZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2930D90", Offset = "0x292FF90", VA = "0x182930D90")]
		public static XZLGRDXRTXQ New(Id32<BITKYMLEUEZ> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2930C20", Offset = "0x292FE20", VA = "0x182930C20", Slot = "8")]
		public bool Equals(ESZRIAQUGWR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2930DF0", Offset = "0x292FFF0", VA = "0x182930DF0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class EQBAFDWUSOQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<BITKYMLEUEZ> LYEFCWKIZSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB4310", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BITKYMLEUEZ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAC3260", Offset = "0xAC2460", VA = "0x180AC3260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ESZRIAQUGWR LRBPAVAYBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xABA470", Offset = "0xAB9670", VA = "0x180ABA470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE196D0", Offset = "0xE188D0", VA = "0x180E196D0")]
		private EQBAFDWUSOQ(Id32<BITKYMLEUEZ> a, ESZRIAQUGWR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x292FDF0", Offset = "0x292EFF0", VA = "0x18292FDF0")]
		public static Result<EQBAFDWUSOQ, VTISYMIGLDB> AXLHEBPIAIY([In] Substitution substitution, IdArray<BITKYMLEUEZ, Term> a, Id32<BITKYMLEUEZ>[] b, IdArray<BITKYMLEUEZ, bool> c)
		{
			return default(Result<EQBAFDWUSOQ, VTISYMIGLDB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x292FFB0", Offset = "0x292F1B0", VA = "0x18292FFB0")]
		private static Result<ESZRIAQUGWR, VTISYMIGLDB> MZKVESLTYJA(Id32<BITKYMLEUEZ> a, IdArray<BITKYMLEUEZ, Term> b, Id32<BITKYMLEUEZ>[] c, IdArray<BITKYMLEUEZ, bool> d)
		{
			return default(Result<ESZRIAQUGWR, VTISYMIGLDB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x29302C0", Offset = "0x292F4C0", VA = "0x1829302C0", Slot = "3")]
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
