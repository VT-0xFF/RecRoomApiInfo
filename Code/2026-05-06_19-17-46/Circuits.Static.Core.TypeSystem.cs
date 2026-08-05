using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Core.TypeSystem.Factory;
using Circuits.Static.Core.TypeSystem.Type;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class BSJAKYMSOCV : IEquatable<BSJAKYMSOCV>, MAQPBFCDGIJ<BSJAKYMSOCV>, CUIIHFFBOYM
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool HKABLAHWXPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool MVMFKVHWVBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int GVKIBXSWTQZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind NDBCZWHGVDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCDD360", Offset = "0xCDBD60", VA = "0x180CDD360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? SMCEYZNTYPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B9FA50", Offset = "0x2B9E450", VA = "0x182B9FA50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual BSJAKYMSOCV NEOWKNUHJFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool ZEMBRNIJETW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FBD0", Offset = "0x2B9E5D0", VA = "0x182B9FBD0")]
		public static void ORLMZSMEYLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
		protected BSJAKYMSOCV(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB60", Offset = "0x2B9E560", VA = "0x182B9FB60")]
		public static BSJAKYMSOCV New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0")]
		protected static a GDBHSHRICEZ<a>(a a) where a : BSJAKYMSOCV
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0", Slot = "9")]
		public virtual BSJAKYMSOCV NKRLZPTQNSW(IReadOnlyDictionary<string, BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FC60", Offset = "0x2B9E660", VA = "0x182B9FC60", Slot = "11")]
		public virtual void SISHBKCUENM(Action<BSJAKYMSOCV> a, Action<BSJAKYMSOCV> b, Action<BSJAKYMSOCV> c, Action<BSJAKYMSOCV> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FCB0", Offset = "0x2B9E6B0", VA = "0x182B9FCB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FAC0", Offset = "0x2B9E4C0", VA = "0x182B9FAC0", Slot = "12")]
		public virtual bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F8D0", Offset = "0x2B9E2D0", VA = "0x182B9F8D0", Slot = "4")]
		public bool Equals(BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F880", Offset = "0x2B9E280", VA = "0x182B9F880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FE20", Offset = "0x2B9E820", VA = "0x182B9FE20")]
		public static bool VPGVCSNEDTU(BSJAKYMSOCV a, BSJAKYMSOCV b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F6B0", Offset = "0x2B9E0B0", VA = "0x182B9F6B0")]
		public static bool AIMXGJJQCKF(BSJAKYMSOCV a, BSJAKYMSOCV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F950", Offset = "0x2B9E350", VA = "0x182B9F950", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F850", Offset = "0x2B9E250", VA = "0x182B9F850", Slot = "13")]
		public virtual int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F850", Offset = "0x2B9E250", VA = "0x182B9F850", Slot = "14")]
		protected virtual int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3724230", Offset = "0x3722C30", VA = "0x183724230")]
		public b HULXNHXEAJD<b>() where b : BSJAKYMSOCV
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FC90", Offset = "0x2B9E690", VA = "0x182B9FC90", Slot = "15")]
		public virtual string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F900", Offset = "0x2B9E300", VA = "0x182B9F900", Slot = "16")]
		public virtual int FXZDBLVUAHL(IReadOnlyList<BSJAKYMSOCV> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FA00", Offset = "0x2B9E400", VA = "0x182B9FA00", Slot = "17")]
		public virtual bool JXFVUMHPIWY(IReadOnlyList<BSJAKYMSOCV> a, IReadOnlyList<BSJAKYMSOCV> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F700", Offset = "0x2B9E100", VA = "0x182B9F700")]
		public ZMFHVAWJYMI BSSITOFOXKO(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F6F0", Offset = "0x2B9E0F0", VA = "0x182B9F6F0")]
		public ZMFHVAWJYMI BSSITOFOXKO(params BSJAKYMSOCV[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F6F0", Offset = "0x2B9E0F0", VA = "0x182B9F6F0")]
		public ZMFHVAWJYMI BSSITOFOXKO(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface MDFEQTCPLCK<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a FCAYXWEMBPO(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b XFXUWYNGDPI([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind RWAEVSYXJVG([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates CDQYILGDNLR(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CUIIHFFBOYM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MAGHPDUQHYB(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MAGHPDUQHYB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class QORSQYADZPN<a> where a : CUIIHFFBOYM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int PMNBOQCQVGS;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QORSQYADZPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x76FEF60", Offset = "0x76FD960", VA = "0x1876FEF60")]
			internal int UBFDSITAJUQ(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DZWZJNTUSZD<a, b> where b : CUIIHFFBOYM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int PMNBOQCQVGS;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public DZWZJNTUSZD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x53C64A0", Offset = "0x53C4EA0", VA = "0x1853C64A0")]
			internal int UBFDSITAJUQ(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class BAMFXBKZFMV<a> where a : CUIIHFFBOYM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int PMNBOQCQVGS;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public BAMFXBKZFMV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4EEF1E0", Offset = "0x4EEDBE0", VA = "0x184EEF1E0")]
			internal int OTSNRRARVGF(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C01FE0", Offset = "0x3C009E0", VA = "0x183C01FE0")]
		public static int XVVYGVUTHPU<a>(this IEnumerable<a> a, int b = 0) where a : CUIIHFFBOYM
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C020B0", Offset = "0x3C00AB0", VA = "0x183C020B0")]
		public static int XVVYGVUTHPU<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : CUIIHFFBOYM
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C01FE0", Offset = "0x3C009E0", VA = "0x183C01FE0")]
		public static int UYCOQJURNQZ<d>(this IEnumerable<d> a, int b = 0) where d : CUIIHFFBOYM
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : MDFEQTCPLCK<TDirectedType, BSJAKYMSOCV, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x538AE60", Offset = "0x5389860", VA = "0x18538AE60")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF180", Offset = "0x7DBDB80", VA = "0x187DBF180")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class XJZHCAQFRHB
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HPFCLJYJAUZ<a, b, c> where c : MDFEQTCPLCK<a, BSJAKYMSOCV, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public BSJAKYMSOCV KVOGGLOYMBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<BSJAKYMSOCV> DDSGXWMDFRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public BSJAKYMSOCV QZWFQKQCWEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<BSJAKYMSOCV> AYOQHPTDAIR;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public HPFCLJYJAUZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x64D9C30", Offset = "0x64D8630", VA = "0x1864D9C30")]
			internal bool RHEGSXZPHJF([In] TypeSys<a, b, c> self_, BSJAKYMSOCV a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x64D9CC0", Offset = "0x64D86C0", VA = "0x1864D9CC0")]
			internal bool RHJNQETMQUO([In] TypeSys<a, b, c> self_, BSJAKYMSOCV a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x64D9ED0", Offset = "0x64D88D0", VA = "0x1864D9ED0")]
			internal bool RHZIHZBETCP([In] TypeSys<a, b, c> self_, BSJAKYMSOCV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class QWIIAJPZCJE<a, b, c> where c : MDFEQTCPLCK<a, BSJAKYMSOCV, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public BSJAKYMSOCV OKUZWARGXMZ;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QWIIAJPZCJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7709590", Offset = "0x7707F90", VA = "0x187709590")]
			internal bool RHUBKSHHJRG([In] TypeSys<a, b, c> self__, BSJAKYMSOCV a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class QFNFLGWFXNB<a, b, c> where c : MDFEQTCPLCK<a, BSJAKYMSOCV, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b JBSQCTQPIEC;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QFNFLGWFXNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x76F65A0", Offset = "0x76F4FA0", VA = "0x1876F65A0")]
			internal BSJAKYMSOCV HKPJJBZAVTO([In] TypeSys<a, b, c> self_, [In] b root_, BSJAKYMSOCV a, BSJAKYMSOCV b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class AGBWXGACUYM<a, b, c> where c : MDFEQTCPLCK<a, BSJAKYMSOCV, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public YDXBZIIWDJA XNSDQOJHBBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public YDXBZIIWDJA BODCNWMMPHS;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public AGBWXGACUYM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x72E68C0", Offset = "0x72E52C0", VA = "0x1872E68C0")]
			internal a HLFEAWGSYBP([In] TypeSys<a, b, c> self_, IOKind a, YDXBZIIWDJA b, YDXBZIIWDJA c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class VXCANUKIWFT<a, b, c> where c : MDFEQTCPLCK<a, BSJAKYMSOCV, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<YDXBZIIWDJA> FYYLJXNGTRM;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VXCANUKIWFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7F05750", Offset = "0x7F04150", VA = "0x187F05750")]
			internal bool BTJZVCOYZCR(bool a, YDXBZIIWDJA b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] JHUIFSYNZPO;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x411A4D0", Offset = "0x4118ED0", VA = "0x18411A4D0")]
		public static bool SYZVBLKFHPP<a, b, c>([In] this TypeSys<a, b, c> _, BSJAKYMSOCV a) where c : MDFEQTCPLCK<a, BSJAKYMSOCV, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x411A4F0", Offset = "0x4118EF0", VA = "0x18411A4F0")]
		public static bool VEKSGNEQEVU<d, e, f>([In] this TypeSys<d, e, f> _, BSJAKYMSOCV a) where f : MDFEQTCPLCK<d, BSJAKYMSOCV, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4118700", Offset = "0x4117100", VA = "0x184118700")]
		public static bool JQOVZJIIJEO<g, h, i>([In] this TypeSys<g, h, i> self, BSJAKYMSOCV a, BSJAKYMSOCV b) where i : MDFEQTCPLCK<g, BSJAKYMSOCV, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x41192A0", Offset = "0x4117CA0", VA = "0x1841192A0")]
		private static bool PVUAKSDPBHF<j, k, l>([In] this TypeSys<j, k, l> self, BSJAKYMSOCV a, BSJAKYMSOCV b, IReadOnlyList<BSJAKYMSOCV> c, IReadOnlyList<BSJAKYMSOCV> d) where l : MDFEQTCPLCK<j, BSJAKYMSOCV, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41109C0", Offset = "0x410F3C0", VA = "0x1841109C0")]
		public static BSJAKYMSOCV IZZNNHOBKMZ<m, n, o>([In] this TypeSys<m, n, o> self, n a, BSJAKYMSOCV b, BSJAKYMSOCV c) where o : MDFEQTCPLCK<m, BSJAKYMSOCV, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4110D00", Offset = "0x410F700", VA = "0x184110D00")]
		public static p IZZNNHOBKMZ<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : MDFEQTCPLCK<p, BSJAKYMSOCV, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x41105E0", Offset = "0x410EFE0", VA = "0x1841105E0")]
		private static List<w> EFSFKEPXOFD<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : MDFEQTCPLCK<t, BSJAKYMSOCV, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4119100", Offset = "0x4117B00", VA = "0x184119100")]
		private static ba PRMFPMGZGOT<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class HTZSTQESFKK
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static BSJAKYMSOCV WWEUIVUEMHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2DD0", Offset = "0x2BA17D0", VA = "0x182BA2DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static BSJAKYMSOCV OHOKSCVAKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2970", Offset = "0x2BA1370", VA = "0x182BA2970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static BSJAKYMSOCV BAPGRJGYHOY
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2760", Offset = "0x2BA1160", VA = "0x182BA2760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static BSJAKYMSOCV LRNSTRRVQSO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2890", Offset = "0x2BA1290", VA = "0x182BA2890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static BSJAKYMSOCV ZKRJLSXPSGY
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2E20", Offset = "0x2BA1820", VA = "0x182BA2E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static BSJAKYMSOCV RJNCBAQGWCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2BA27B0", Offset = "0x2BA11B0", VA = "0x182BA27B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static BSJAKYMSOCV KHNZQIIKHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2590", Offset = "0x2BA0F90", VA = "0x182BA2590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static BSJAKYMSOCV XNQTODWCJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2BA25E0", Offset = "0x2BA0FE0", VA = "0x182BA25E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2630", Offset = "0x2BA1030", VA = "0x182BA2630")]
		public static ZMFHVAWJYMI KBGMAVVFELG([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2BA28E0", Offset = "0x2BA12E0", VA = "0x182BA28E0")]
		public static ZMFHVAWJYMI SBLLSLBKFUW(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2BA29C0", Offset = "0x2BA13C0", VA = "0x182BA29C0")]
		public static ZMFHVAWJYMI VSIGLEEIJLE(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2A50", Offset = "0x2BA1450", VA = "0x182BA2A50")]
		public static ZMFHVAWJYMI VSIGLEEIJLE(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2800", Offset = "0x2BA1200", VA = "0x182BA2800")]
		public static ZMFHVAWJYMI QTNBKFWDLAD(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2C00", Offset = "0x2BA1600", VA = "0x182BA2C00")]
		public static MSODNTWMEDL VWNISKSIKUU(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ZMFHVAWJYMI : BSJAKYMSOCV, IEquatable<ZMFHVAWJYMI>, MAQPBFCDGIJ<ZMFHVAWJYMI>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class UQEFQITABRG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, BSJAKYMSOCV> VNXHTFIQVEM;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public UQEFQITABRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6340", Offset = "0x2BA4D40", VA = "0x182BA6340")]
			internal BSJAKYMSOCV KARHESHPYVS(BSJAKYMSOCV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BSJAKYMSOCV BSAOMIYLMNI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override BSJAKYMSOCV NEOWKNUHJFH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<BSJAKYMSOCV> ZBVOVXRXXPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool ZEMBRNIJETW
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2BAAA20", Offset = "0x2BA9420", VA = "0x182BAAA20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAD50", Offset = "0x2BA9750", VA = "0x182BAAD50", Slot = "9")]
		public sealed override BSJAKYMSOCV NKRLZPTQNSW(IReadOnlyDictionary<string, BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAF00", Offset = "0x2BA9900", VA = "0x182BAAF00", Slot = "11")]
		public sealed override void SISHBKCUENM(Action<BSJAKYMSOCV> a, Action<BSJAKYMSOCV> b, Action<BSJAKYMSOCV> c, Action<BSJAKYMSOCV> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB1A0", Offset = "0x2BA9BA0", VA = "0x182BAB1A0")]
		private ZMFHVAWJYMI(BSJAKYMSOCV a, IEnumerable<BSJAKYMSOCV> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAE70", Offset = "0x2BA9870", VA = "0x182BAAE70")]
		public static ZMFHVAWJYMI New(BSJAKYMSOCV originalType, IEnumerable<BSJAKYMSOCV> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB160", Offset = "0x2BA9B60", VA = "0x182BAB160", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAC60", Offset = "0x2BA9660", VA = "0x182BAAC60", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BAACB0", Offset = "0x2BA96B0", VA = "0x182BAACB0")]
		public bool NFHEFKJNFIE([In] ZMFHVAWJYMI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BAABF0", Offset = "0x2BA95F0", VA = "0x182BAABF0", Slot = "18")]
		public bool Equals(ZMFHVAWJYMI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAC10", Offset = "0x2BA9610", VA = "0x182BAAC10", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAB40", Offset = "0x2BA9540", VA = "0x182BAAB40", Slot = "14")]
		protected override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAEF0", Offset = "0x2BA98F0", VA = "0x182BAAEF0", Slot = "19")]
		private bool RHBZNKVLTSN([In] ZMFHVAWJYMI other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class QQJNIOLCRCP : BSJAKYMSOCV, IEquatable<QQJNIOLCRCP>, MAQPBFCDGIJ<QQJNIOLCRCP>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4280", Offset = "0x2BA2C80", VA = "0x182BA4280")]
		private QQJNIOLCRCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA40E0", Offset = "0x2BA2AE0", VA = "0x182BA40E0")]
		public static QQJNIOLCRCP New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4220", Offset = "0x2BA2C20", VA = "0x182BA4220", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4190", Offset = "0x2BA2B90", VA = "0x182BA4190", Slot = "15")]
		public sealed override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4150", Offset = "0x2BA2B50", VA = "0x182BA4150")]
		private static string PXZDOFMZFQA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4090", Offset = "0x2BA2A90", VA = "0x182BA4090", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390")]
		public bool NFHEFKJNFIE([In] QQJNIOLCRCP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xF5A950", Offset = "0xF59350", VA = "0x180F5A950", Slot = "18")]
		public bool Equals(QQJNIOLCRCP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4040", Offset = "0x2BA2A40", VA = "0x182BA4040", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390", Slot = "19")]
		private bool ZJNEVHLKAUY([In] QQJNIOLCRCP other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class YZOJJPJETGQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ZMZGDOYHPIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public BSJAKYMSOCV VAYLBIGVHYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<BSJAKYMSOCV, ZMFHVAWJYMI> FUFZPQDRKVO;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ZMZGDOYHPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2BAB3F0", Offset = "0x2BA9DF0", VA = "0x182BAB3F0")]
			internal ZMFHVAWJYMI ENAXCGUROMU(BSJAKYMSOCV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ZMTZGIEKFWY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public BSJAKYMSOCV CETOOKBPWQS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<BSJAKYMSOCV, ZMFHVAWJYMI> BDJTSFRXKQY;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ZMTZGIEKFWY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2BAB270", Offset = "0x2BA9C70", VA = "0x182BAB270")]
			internal ZMFHVAWJYMI RNYWPRIAJQY(BSJAKYMSOCV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA5B0", Offset = "0x2BA8FB0", VA = "0x182BAA5B0")]
		public static IEnumerable<YDXBZIIWDJA> VHFUCBFZOUM(this YDXBZIIWDJA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BA88A0", Offset = "0x2BA72A0", VA = "0x182BA88A0")]
		private static IEnumerable<YDXBZIIWDJA> LZUZVACNVCS(this YDXBZIIWDJA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA86D0", Offset = "0x2BA70D0", VA = "0x182BA86D0")]
		public static (BSJAKYMSOCV, IReadOnlyList<BSJAKYMSOCV>, bool) HIRAWEPEOSA(this BSJAKYMSOCV a, [Optional] IReadOnlyList<BSJAKYMSOCV> b)
		{
			return default((BSJAKYMSOCV, IReadOnlyList<BSJAKYMSOCV>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA86A0", Offset = "0x2BA70A0", VA = "0x182BA86A0")]
		public static TypeKind GYPEMSITGJJ(this BSJAKYMSOCV a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7890", Offset = "0x2BA6290", VA = "0x182BA7890")]
		private static BSJAKYMSOCV ConvertClassesToIntersections(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8370", Offset = "0x2BA6D70", VA = "0x182BA8370")]
		private static BSJAKYMSOCV DistributeUnionIntoIntersection(this ZMFHVAWJYMI self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7EE0", Offset = "0x2BA68E0", VA = "0x182BA7EE0")]
		private static BSJAKYMSOCV DistributeIntersectionIntoIntersection(this ZMFHVAWJYMI self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8210", Offset = "0x2BA6C10", VA = "0x182BA8210")]
		private static BSJAKYMSOCV DistributeIntoIntersection(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2BA89F0", Offset = "0x2BA73F0", VA = "0x182BA89F0")]
		private static bool OtherIsAssignableToOther(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes, BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9E10", Offset = "0x2BA8810", VA = "0x182BA9E10")]
		private static bool UnionIsAssignableToOther(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes, BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8B80", Offset = "0x2BA7580", VA = "0x182BA8B80")]
		private static bool OtherIsAssignableToUnion(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes, BSJAKYMSOCV union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA140", Offset = "0x2BA8B40", VA = "0x182BAA140")]
		private static bool UnionIsAssignableToUnion(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes, BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9C10", Offset = "0x2BA8610", VA = "0x182BA9C10")]
		public static BSJAKYMSOCV RemoveCommonTypesFromIntersectionDistribution(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8F30", Offset = "0x2BA7930", VA = "0x182BA8F30")]
		public static BSJAKYMSOCV RemoveCommonTypesFromIntersectionDistributionInternal(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9D40", Offset = "0x2BA8740", VA = "0x182BA9D40")]
		public static BSJAKYMSOCV SimplifyIntersectionUnion(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA7D0", Offset = "0x2BA91D0", VA = "0x182BAA7D0")]
		public static IEnumerable<BSJAKYMSOCV> ZBVOVXRXXPD(this BSJAKYMSOCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8960", Offset = "0x2BA7360", VA = "0x182BA8960")]
		public static IEnumerable<BSJAKYMSOCV> MRMGCULCNLY(this BSJAKYMSOCV a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class YDXBZIIWDJA : ZLFCCNWZUSL, IEquatable<YDXBZIIWDJA>, MAQPBFCDGIJ<YDXBZIIWDJA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class HALWUWOXEIZ : IEnumerable<YDXBZIIWDJA>, IEnumerable, IEnumerator<YDXBZIIWDJA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private YDXBZIIWDJA BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public YDXBZIIWDJA IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<YDXBZIIWDJA> MXGZQBRVDOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private YDXBZIIWDJA IENJPXHUILH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<YDXBZIIWDJA> MWWLVOEAKRO;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private YDXBZIIWDJA DRTIAKTKCGR
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public HALWUWOXEIZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2350", Offset = "0x2BA0D50", VA = "0x182BA2350", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1F90", Offset = "0x2BA0990", VA = "0x182BA1F90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1E50", Offset = "0x2BA0850", VA = "0x182BA1E50")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1EA0", Offset = "0x2BA08A0", VA = "0x182BA1EA0")]
			private void ALONWGIYSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2BA24A0", Offset = "0x2BA0EA0", VA = "0x182BA24A0", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1EF0", Offset = "0x2BA08F0", VA = "0x182BA1EF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YDXBZIIWDJA> ERBCXSMUTRM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1EF0", Offset = "0x2BA08F0", VA = "0x182BA1EF0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> JJLYBIIBQZA;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, YDXBZIIWDJA> GJRCPCPCUGL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, YDXBZIIWDJA> RSUKPKBPJLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2BA66D0", Offset = "0x2BA50D0", VA = "0x182BA66D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? SMCEYZNTYPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid SGYXLDBUDMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xF43900", Offset = "0xF42300", VA = "0x180F43900")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xF43730", Offset = "0xF42130", VA = "0x180F43730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<YDXBZIIWDJA> OZULLSCWKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E10", Offset = "0xCD5810", VA = "0x180CD6E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<YDXBZIIWDJA> FFPDPUBYRVO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2BA65E0", Offset = "0x2BA4FE0", VA = "0x182BA65E0")]
			[IteratorStateMachine(typeof(HALWUWOXEIZ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> OCPMTNNRQSX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DF0", Offset = "0xCD57F0", VA = "0x180CD6DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, CFJRYRQGJHA> FDTQANXRFLR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCD7510", Offset = "0xCD5F10", VA = "0x180CD7510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7580", Offset = "0x2BA5F80", VA = "0x182BA7580")]
		public YDXBZIIWDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA74D0", Offset = "0x2BA5ED0", VA = "0x182BA74D0")]
		public YDXBZIIWDJA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6920", Offset = "0x2BA5320", VA = "0x182BA6920")]
		public static YDXBZIIWDJA JKQQFBRMSQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7320", Offset = "0x2BA5D20", VA = "0x182BA7320")]
		public static YDXBZIIWDJA XEJZBBLNDXR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6720", Offset = "0x2BA5120", VA = "0x182BA6720")]
		public void Initialize(YDXBZIIWDJA from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA75E0", Offset = "0x2BA5FE0", VA = "0x182BA75E0")]
		private YDXBZIIWDJA([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<MSODNTWMEDL> c, [Optional] IEnumerable<YDXBZIIWDJA> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, CFJRYRQGJHA>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6DC0", Offset = "0x2BA57C0", VA = "0x182BA6DC0")]
		public static YDXBZIIWDJA New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<MSODNTWMEDL> typeParameters, [Optional] IEnumerable<YDXBZIIWDJA> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, CFJRYRQGJHA>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7230", Offset = "0x2BA5C30", VA = "0x182BA7230", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7380", Offset = "0x2BA5D80", VA = "0x182BA7380")]
		private string YKHJXKDGWNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6410", Offset = "0x2BA4E10", VA = "0x182BA6410")]
		private static string CVOZSSHFPSG(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6970", Offset = "0x2BA5370", VA = "0x182BA6970")]
		private string JXKMPCILIZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F60", Offset = "0x2BA5960", VA = "0x182BA6F60")]
		private string TTUFTFSDCSE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6E90", Offset = "0x2BA5890", VA = "0x182BA6E90", Slot = "15")]
		public sealed override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D70", Offset = "0x2BA5770", VA = "0x182BA6D70", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6C50", Offset = "0x2BA5650", VA = "0x182BA6C50")]
		public bool NFHEFKJNFIE([In] YDXBZIIWDJA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA66B0", Offset = "0x2BA50B0", VA = "0x182BA66B0", Slot = "18")]
		public bool Equals(YDXBZIIWDJA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6660", Offset = "0x2BA5060", VA = "0x182BA6660", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA64D0", Offset = "0x2BA4ED0", VA = "0x182BA64D0", Slot = "14")]
		protected override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7370", Offset = "0x2BA5D70", VA = "0x182BA7370", Slot = "19")]
		private bool YHEQRSTSAFH([In] YDXBZIIWDJA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class TPSTSPDAYMT
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<BSJAKYMSOCV> RMGGOPHTBZY;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<YDXBZIIWDJA> KLDFZIFRVYX;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, MSODNTWMEDL> FTKTXJWSGVE;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> RGPQNWKONJI;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, CFJRYRQGJHA> QJERSMBFGBB;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class HRKYUVQKNES : IEquatable<HRKYUVQKNES>, MAQPBFCDGIJ<HRKYUVQKNES>, CUIIHFFBOYM
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BSJAKYMSOCV UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		private HRKYUVQKNES(BSJAKYMSOCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2530", Offset = "0x2BA0F30", VA = "0x182BA2530")]
		public static HRKYUVQKNES New(BSJAKYMSOCV type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B61380", Offset = "0x2B5FD80", VA = "0x182B61380", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F5D0", Offset = "0x2B9DFD0", VA = "0x182B9F5D0")]
		public bool NFHEFKJNFIE([In] HRKYUVQKNES other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F530", Offset = "0x2B9DF30", VA = "0x182B9F530", Slot = "4")]
		public bool Equals(HRKYUVQKNES other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA24E0", Offset = "0x2BA0EE0", VA = "0x182BA24E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B78810", Offset = "0x2B77210", VA = "0x182B78810", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F620", Offset = "0x2B9E020", VA = "0x182B9F620", Slot = "6")]
		public int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F5D0", Offset = "0x2B9DFD0", VA = "0x182B9F5D0", Slot = "5")]
		private bool IEOXLEEGXAV([In] HRKYUVQKNES other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class BNLUDIDPNCL : IEquatable<BNLUDIDPNCL>, MAQPBFCDGIJ<BNLUDIDPNCL>, CUIIHFFBOYM
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BSJAKYMSOCV UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		private BNLUDIDPNCL(BSJAKYMSOCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F650", Offset = "0x2B9E050", VA = "0x182B9F650")]
		public static BNLUDIDPNCL New(BSJAKYMSOCV type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B61380", Offset = "0x2B5FD80", VA = "0x182B61380", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F5D0", Offset = "0x2B9DFD0", VA = "0x182B9F5D0")]
		public bool NFHEFKJNFIE([In] BNLUDIDPNCL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F530", Offset = "0x2B9DF30", VA = "0x182B9F530", Slot = "4")]
		public bool Equals(BNLUDIDPNCL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F580", Offset = "0x2B9DF80", VA = "0x182B9F580", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B78810", Offset = "0x2B77210", VA = "0x182B78810", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F620", Offset = "0x2B9E020", VA = "0x182B9F620", Slot = "6")]
		public int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F5D0", Offset = "0x2B9DFD0", VA = "0x182B9F5D0", Slot = "5")]
		private bool LWICPHGOTDY([In] BNLUDIDPNCL other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class CFJRYRQGJHA : ZLFCCNWZUSL, IEquatable<CFJRYRQGJHA>, MAQPBFCDGIJ<CFJRYRQGJHA>, CUIIHFFBOYM
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, HRKYUVQKNES>> DBJUNIANPQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, BNLUDIDPNCL>> CYZNYIDEGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0830", Offset = "0x2B9F230", VA = "0x182BA0830")]
		private CFJRYRQGJHA(IEnumerable<MSODNTWMEDL> a, IEnumerable<KeyValuePair<string, HRKYUVQKNES>> b, IEnumerable<KeyValuePair<string, BNLUDIDPNCL>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0260", Offset = "0x2B9EC60", VA = "0x182BA0260")]
		public static CFJRYRQGJHA New(IEnumerable<MSODNTWMEDL> typeParameters, IEnumerable<KeyValuePair<string, HRKYUVQKNES>> inputs, IEnumerable<KeyValuePair<string, BNLUDIDPNCL>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BA03A0", Offset = "0x2B9EDA0", VA = "0x182BA03A0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FC90", Offset = "0x2B9E690", VA = "0x182B9FC90", Slot = "15")]
		public sealed override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BA00E0", Offset = "0x2B9EAE0", VA = "0x182BA00E0")]
		private string NLUNKCPVNFZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA06B0", Offset = "0x2B9F0B0", VA = "0x182BA06B0")]
		private string WESRYEIAVZC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0090", Offset = "0x2B9EA90", VA = "0x182BA0090", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FFB0", Offset = "0x2B9E9B0", VA = "0x182B9FFB0")]
		public bool NFHEFKJNFIE([In] CFJRYRQGJHA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FF40", Offset = "0x2B9E940", VA = "0x182B9FF40", Slot = "18")]
		public bool Equals(CFJRYRQGJHA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FF60", Offset = "0x2B9E960", VA = "0x182B9FF60", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FE60", Offset = "0x2B9E860", VA = "0x182B9FE60", Slot = "14")]
		protected sealed override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0390", Offset = "0x2B9ED90", VA = "0x182BA0390", Slot = "19")]
		private bool PGQYQULYXZN([In] CFJRYRQGJHA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class EHTODBRDAHV : BSJAKYMSOCV, IEquatable<EHTODBRDAHV>, MAQPBFCDGIJ<EHTODBRDAHV>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1AF0", Offset = "0x2BA04F0", VA = "0x182BA1AF0")]
		private EHTODBRDAHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1960", Offset = "0x2BA0360", VA = "0x182BA1960")]
		public static EHTODBRDAHV New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1AC0", Offset = "0x2BA04C0", VA = "0x182BA1AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BA19D0", Offset = "0x2BA03D0", VA = "0x182BA19D0", Slot = "15")]
		public override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1870", Offset = "0x2BA0270", VA = "0x182BA1870", Slot = "16")]
		public override int FXZDBLVUAHL(IReadOnlyList<BSJAKYMSOCV> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA18C0", Offset = "0x2BA02C0", VA = "0x182BA18C0", Slot = "17")]
		public override bool JXFVUMHPIWY(IReadOnlyList<BSJAKYMSOCV> a, IReadOnlyList<BSJAKYMSOCV> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1910", Offset = "0x2BA0310", VA = "0x182BA1910", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390")]
		public bool NFHEFKJNFIE([In] EHTODBRDAHV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xF5A950", Offset = "0xF59350", VA = "0x180F5A950", Slot = "18")]
		public bool Equals(EHTODBRDAHV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1820", Offset = "0x2BA0220", VA = "0x182BA1820", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390", Slot = "19")]
		private bool FXEJDPJYZGC([In] EHTODBRDAHV other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, MAQPBFCDGIJ<Property>, CUIIHFFBOYM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool MVMFKVHWVBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int GVKIBXSWTQZ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public BSJAKYMSOCV UXYUOXCBTLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool WKVDZZLESMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool CVKBZELIZRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1258890", Offset = "0x1257290", VA = "0x181258890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3FE0", Offset = "0x2BA29E0", VA = "0x182BA3FE0")]
		private Property(BSJAKYMSOCV type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3E70", Offset = "0x2BA2870", VA = "0x182BA3E70")]
		public static Property New(BSJAKYMSOCV type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3F00", Offset = "0x2BA2900", VA = "0x182BA3F00", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3A20", Offset = "0x2BA2420", VA = "0x182BA3A20")]
		private string ABKBDEWFDOS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B30", Offset = "0x2BA2530", VA = "0x182BA3B30")]
		private string EYQEILONDLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3D70", Offset = "0x2BA2770", VA = "0x182BA3D70")]
		public bool NFHEFKJNFIE([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3BD0", Offset = "0x2BA25D0", VA = "0x182BA3BD0", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B80", Offset = "0x2BA2580", VA = "0x182BA3B80", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3BF0", Offset = "0x2BA25F0", VA = "0x182BA3BF0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3A80", Offset = "0x2BA2480", VA = "0x182BA3A80")]
		private int EOEAAFJOCDL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3CB0", Offset = "0x2BA26B0", VA = "0x182BA3CB0", Slot = "6")]
		public int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3A70", Offset = "0x2BA2470", VA = "0x182BA3A70", Slot = "5")]
		private bool BLPTXOLSCOW([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class ARCOLPSGVYE : BSJAKYMSOCV, IEquatable<ARCOLPSGVYE>, MAQPBFCDGIJ<ARCOLPSGVYE>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F510", Offset = "0x2B9DF10", VA = "0x182B9F510")]
		private ARCOLPSGVYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F3F0", Offset = "0x2B9DDF0", VA = "0x182B9F3F0")]
		public static ARCOLPSGVYE New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F4E0", Offset = "0x2B9DEE0", VA = "0x182B9F4E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F460", Offset = "0x2B9DE60", VA = "0x182B9F460", Slot = "15")]
		public override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F3A0", Offset = "0x2B9DDA0", VA = "0x182B9F3A0", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390")]
		public bool NFHEFKJNFIE([In] ARCOLPSGVYE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF5A950", Offset = "0xF59350", VA = "0x180F5A950", Slot = "18")]
		public bool Equals(ARCOLPSGVYE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F340", Offset = "0x2B9DD40", VA = "0x182B9F340", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390", Slot = "19")]
		private bool KGKGKQBJASX([In] ARCOLPSGVYE other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum TypeKind
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Any,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Boolean,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Int32,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Single,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Tuple,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Union,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Function,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		TypeParameter,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		TypeParameterReference,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		AppliedGeneric,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Intersection
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class CVOJHGHTZTE : BSJAKYMSOCV, IEquatable<CVOJHGHTZTE>, MAQPBFCDGIJ<CVOJHGHTZTE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool ZEMBRNIJETW
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2BA09E0", Offset = "0x2B9F3E0", VA = "0x182BA09E0", Slot = "9")]
		public sealed override BSJAKYMSOCV NKRLZPTQNSW(IReadOnlyDictionary<string, BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0B40", Offset = "0x2B9F540", VA = "0x182BA0B40", Slot = "11")]
		public sealed override void SISHBKCUENM(Action<BSJAKYMSOCV> a, Action<BSJAKYMSOCV> b, Action<BSJAKYMSOCV> c, Action<BSJAKYMSOCV> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0B70", Offset = "0x2B9F570", VA = "0x182BA0B70")]
		private CVOJHGHTZTE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0AC0", Offset = "0x2B9F4C0", VA = "0x182BA0AC0")]
		public static CVOJHGHTZTE New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0990", Offset = "0x2B9F390", VA = "0x182BA0990", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390")]
		public bool NFHEFKJNFIE([In] CVOJHGHTZTE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xF5A950", Offset = "0xF59350", VA = "0x180F5A950", Slot = "18")]
		public bool Equals(CVOJHGHTZTE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0940", Offset = "0x2B9F340", VA = "0x182BA0940", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0920", Offset = "0x2B9F320", VA = "0x182BA0920", Slot = "14")]
		protected sealed override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390", Slot = "19")]
		private bool DYZDGAPTVBJ([In] CVOJHGHTZTE other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class ZLFCCNWZUSL : BSJAKYMSOCV
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<MSODNTWMEDL> LFNSPUBKBRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA920", Offset = "0x2BA9320", VA = "0x182BAA920")]
		public void Initialize(ZLFCCNWZUSL from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA9B0", Offset = "0x2BA93B0", VA = "0x182BAA9B0")]
		protected ZLFCCNWZUSL(IEnumerable<MSODNTWMEDL> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool NFHEFKJNFIE([In] BSJAKYMSOCV other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA950", Offset = "0x2BA9350", VA = "0x182BAA950")]
		protected bool NFHEFKJNFIE([In] ZLFCCNWZUSL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA820", Offset = "0x2BA9220", VA = "0x182BAA820", Slot = "14")]
		protected override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA8A0", Offset = "0x2BA92A0", VA = "0x182BAA8A0")]
		protected int IWLUSVRSTNZ(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class MSODNTWMEDL : BSJAKYMSOCV, IEquatable<MSODNTWMEDL>, MAQPBFCDGIJ<MSODNTWMEDL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public BSJAKYMSOCV DAHZITFHSEV
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3960", Offset = "0x2BA2360", VA = "0x182BA3960")]
		private MSODNTWMEDL(string a, [Optional] BSJAKYMSOCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2BA37D0", Offset = "0x2BA21D0", VA = "0x182BA37D0")]
		public static MSODNTWMEDL New(string name, [Optional] BSJAKYMSOCV constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BA38D0", Offset = "0x2BA22D0", VA = "0x182BA38D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3780", Offset = "0x2BA2180", VA = "0x182BA3780", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3730", Offset = "0x2BA2130", VA = "0x182BA3730")]
		public bool NFHEFKJNFIE([In] MSODNTWMEDL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3620", Offset = "0x2BA2020", VA = "0x182BA3620", Slot = "18")]
		public bool Equals(MSODNTWMEDL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3670", Offset = "0x2BA2070", VA = "0x182BA3670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BA35A0", Offset = "0x2BA1FA0", VA = "0x182BA35A0", Slot = "14")]
		protected override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BA36C0", Offset = "0x2BA20C0", VA = "0x182BA36C0", Slot = "13")]
		public override int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3730", Offset = "0x2BA2130", VA = "0x182BA3730", Slot = "19")]
		private bool UMJMBCPXCEK([In] MSODNTWMEDL other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class KBTULLJQNIB : BSJAKYMSOCV, IEquatable<KBTULLJQNIB>, MAQPBFCDGIJ<KBTULLJQNIB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3580", Offset = "0x2BA1F80", VA = "0x182BA3580")]
		private KBTULLJQNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA33F0", Offset = "0x2BA1DF0", VA = "0x182BA33F0")]
		public static KBTULLJQNIB New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3550", Offset = "0x2BA1F50", VA = "0x182BA3550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3460", Offset = "0x2BA1E60", VA = "0x182BA3460", Slot = "15")]
		public override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3300", Offset = "0x2BA1D00", VA = "0x182BA3300", Slot = "16")]
		public override int FXZDBLVUAHL(IReadOnlyList<BSJAKYMSOCV> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3350", Offset = "0x2BA1D50", VA = "0x182BA3350", Slot = "17")]
		public override bool JXFVUMHPIWY(IReadOnlyList<BSJAKYMSOCV> a, IReadOnlyList<BSJAKYMSOCV> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA33A0", Offset = "0x2BA1DA0", VA = "0x182BA33A0", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390")]
		public bool NFHEFKJNFIE([In] KBTULLJQNIB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xF5A950", Offset = "0xF59350", VA = "0x180F5A950", Slot = "18")]
		public bool Equals(KBTULLJQNIB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BA32B0", Offset = "0x2BA1CB0", VA = "0x182BA32B0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F390", Offset = "0x2B9DD90", VA = "0x182B9F390", Slot = "19")]
		private bool WPKMKMPVPJQ([In] KBTULLJQNIB other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Factory
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct CircuitTypeOrString
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct Impl
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly BSJAKYMSOCV CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
			internal Impl(BSJAKYMSOCV circuitType, string typeParameterReference)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private enum TypeOrStringKind
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			CircuitType,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			TypeParameterReference
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Impl _impl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly TypeOrStringKind _kind;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0E50", Offset = "0x2B9F850", VA = "0x182BA0E50")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0DE0", Offset = "0x2B9F7E0", VA = "0x182BA0DE0")]
		public static CircuitTypeOrString WQHQWYPMLDD(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0D80", Offset = "0x2B9F780", VA = "0x182BA0D80")]
		public static CircuitTypeOrString WQHQWYPMLDD(BSJAKYMSOCV a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0CE0", Offset = "0x2B9F6E0", VA = "0x182BA0CE0")]
		public BSJAKYMSOCV SYQXXAAIACU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0BB0", Offset = "0x2B9F5B0", VA = "0x182BA0BB0")]
		public static BSJAKYMSOCV[] ORARKYIBMFJ(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly ESJHUWXKJLO _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
		private ClassFactoryBaseClasses(ESJHUWXKJLO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x10CDE90", Offset = "0x10CC890", VA = "0x1810CDE90")]
		public static ClassFactoryBaseClasses New(ESJHUWXKJLO data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0F30", Offset = "0x2B9F930", VA = "0x182BA0F30")]
		public ClassFactoryBaseClasses QZMSJKEYDJM(YDXBZIIWDJA a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x186EDB0", Offset = "0x186D7B0", VA = "0x18186EDB0")]
		public ClassFactoryProps QUVDBALXKSN()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0ED0", Offset = "0x2B9F8D0", VA = "0x182BA0ED0")]
		public ClassFactoryProps QNXVMXKOROC(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0E80", Offset = "0x2B9F880", VA = "0x182BA0E80")]
		public YDXBZIIWDJA ISHNKJMJOID()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class ESJHUWXKJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? SGYXLDBUDMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string EREWIERIFZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<MSODNTWMEDL> LFNSPUBKBRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<YDXBZIIWDJA> OZULLSCWKIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> OCPMTNNRQSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, CFJRYRQGJHA>> FDTQANXRFLR;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1CC0", Offset = "0x2BA06C0", VA = "0x182BA1CC0")]
		private ESJHUWXKJLO([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1B10", Offset = "0x2BA0510", VA = "0x182BA1B10")]
		public static ESJHUWXKJLO New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly ESJHUWXKJLO _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
		private ClassFactoryFuncs(ESJHUWXKJLO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x10CDE90", Offset = "0x10CC890", VA = "0x1810CDE90")]
		public static ClassFactoryFuncs New(ESJHUWXKJLO data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0FF0", Offset = "0x2B9F9F0", VA = "0x182BA0FF0")]
		public YDXBZIIWDJA ISHNKJMJOID()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly ESJHUWXKJLO _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
		public ClassFactoryProps(ESJHUWXKJLO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1180", Offset = "0x2B9FB80", VA = "0x182BA1180")]
		public ClassFactoryProps QNXVMXKOROC(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x186EDB0", Offset = "0x186D7B0", VA = "0x18186EDB0")]
		public ClassFactoryFuncs PZQWSJKGVUQ()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1140", Offset = "0x2B9FB40", VA = "0x182BA1140")]
		public YDXBZIIWDJA ISHNKJMJOID()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly ESJHUWXKJLO _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
		private ClassFactoryTypeParams(ESJHUWXKJLO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1370", Offset = "0x2B9FD70", VA = "0x182BA1370")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1580", Offset = "0x2B9FF80", VA = "0x182BA1580")]
		public ClassFactoryTypeParams VWNISKSIKUU(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x186EDB0", Offset = "0x186D7B0", VA = "0x18186EDB0")]
		public ClassFactoryBaseClasses SDNBDBMUODO()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1540", Offset = "0x2B9FF40", VA = "0x182BA1540")]
		public ClassFactoryBaseClasses QZMSJKEYDJM(YDXBZIIWDJA a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1310", Offset = "0x2B9FD10", VA = "0x182BA1310")]
		public YDXBZIIWDJA ISHNKJMJOID()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Flags]
	public enum GetSet
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Get = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Set = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		GetSet = 3
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
