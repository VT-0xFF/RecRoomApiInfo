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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCFB380", Offset = "0xCFA780", VA = "0x180CFB380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? SMCEYZNTYPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B9FCE0", Offset = "0x2B9F0E0", VA = "0x182B9FCE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual BSJAKYMSOCV NEOWKNUHJFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool ZEMBRNIJETW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FE60", Offset = "0x2B9F260", VA = "0x182B9FE60")]
		public static void ORLMZSMEYLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
		protected BSJAKYMSOCV(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FDF0", Offset = "0x2B9F1F0", VA = "0x182B9FDF0")]
		public static BSJAKYMSOCV New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120")]
		protected static a GDBHSHRICEZ<a>(a a) where a : BSJAKYMSOCV
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120", Slot = "9")]
		public virtual BSJAKYMSOCV NKRLZPTQNSW(IReadOnlyDictionary<string, BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FEF0", Offset = "0x2B9F2F0", VA = "0x182B9FEF0", Slot = "11")]
		public virtual void SISHBKCUENM(Action<BSJAKYMSOCV> a, Action<BSJAKYMSOCV> b, Action<BSJAKYMSOCV> c, Action<BSJAKYMSOCV> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FF40", Offset = "0x2B9F340", VA = "0x182B9FF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FD50", Offset = "0x2B9F150", VA = "0x182B9FD50", Slot = "12")]
		public virtual bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB60", Offset = "0x2B9EF60", VA = "0x182B9FB60", Slot = "4")]
		public bool Equals(BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB10", Offset = "0x2B9EF10", VA = "0x182B9FB10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BA00B0", Offset = "0x2B9F4B0", VA = "0x182BA00B0")]
		public static bool VPGVCSNEDTU(BSJAKYMSOCV a, BSJAKYMSOCV b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F950", Offset = "0x2B9ED50", VA = "0x182B9F950")]
		public static bool AIMXGJJQCKF(BSJAKYMSOCV a, BSJAKYMSOCV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FBE0", Offset = "0x2B9EFE0", VA = "0x182B9FBE0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FAE0", Offset = "0x2B9EEE0", VA = "0x182B9FAE0", Slot = "13")]
		public virtual int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FAE0", Offset = "0x2B9EEE0", VA = "0x182B9FAE0", Slot = "14")]
		protected virtual int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3718750", Offset = "0x3717B50", VA = "0x183718750")]
		public b HULXNHXEAJD<b>() where b : BSJAKYMSOCV
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FF20", Offset = "0x2B9F320", VA = "0x182B9FF20", Slot = "15")]
		public virtual string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FB90", Offset = "0x2B9EF90", VA = "0x182B9FB90", Slot = "16")]
		public virtual int FXZDBLVUAHL(IReadOnlyList<BSJAKYMSOCV> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FC90", Offset = "0x2B9F090", VA = "0x182B9FC90", Slot = "17")]
		public virtual bool JXFVUMHPIWY(IReadOnlyList<BSJAKYMSOCV> a, IReadOnlyList<BSJAKYMSOCV> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F9A0", Offset = "0x2B9EDA0", VA = "0x182B9F9A0")]
		public ZMFHVAWJYMI BSSITOFOXKO(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F990", Offset = "0x2B9ED90", VA = "0x182B9F990")]
		public ZMFHVAWJYMI BSSITOFOXKO(params BSJAKYMSOCV[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F990", Offset = "0x2B9ED90", VA = "0x182B9F990")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public QORSQYADZPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x76690A0", Offset = "0x76684A0", VA = "0x1876690A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public DZWZJNTUSZD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5345280", Offset = "0x5344680", VA = "0x185345280")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public BAMFXBKZFMV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4E70120", Offset = "0x4E6F520", VA = "0x184E70120")]
			internal int OTSNRRARVGF(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BF64E0", Offset = "0x3BF58E0", VA = "0x183BF64E0")]
		public static int XVVYGVUTHPU<a>(this IEnumerable<a> a, int b = 0) where a : CUIIHFFBOYM
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BF65B0", Offset = "0x3BF59B0", VA = "0x183BF65B0")]
		public static int XVVYGVUTHPU<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : CUIIHFFBOYM
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BF64E0", Offset = "0x3BF58E0", VA = "0x183BF64E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5309EC0", Offset = "0x53092C0", VA = "0x185309EC0")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7D19950", Offset = "0x7D18D50", VA = "0x187D19950")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public HPFCLJYJAUZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6450940", Offset = "0x644FD40", VA = "0x186450940")]
			internal bool RHEGSXZPHJF([In] TypeSys<a, b, c> self_, BSJAKYMSOCV a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x64509D0", Offset = "0x644FDD0", VA = "0x1864509D0")]
			internal bool RHJNQETMQUO([In] TypeSys<a, b, c> self_, BSJAKYMSOCV a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6450BE0", Offset = "0x644FFE0", VA = "0x186450BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public QWIIAJPZCJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7673790", Offset = "0x7672B90", VA = "0x187673790")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public QFNFLGWFXNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7660700", Offset = "0x765FB00", VA = "0x187660700")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public AGBWXGACUYM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x72543E0", Offset = "0x72537E0", VA = "0x1872543E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public VXCANUKIWFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7E5E590", Offset = "0x7E5D990", VA = "0x187E5E590")]
			internal bool BTJZVCOYZCR(bool a, YDXBZIIWDJA b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] JHUIFSYNZPO;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x410ED80", Offset = "0x410E180", VA = "0x18410ED80")]
		public static bool SYZVBLKFHPP<a, b, c>([In] this TypeSys<a, b, c> _, BSJAKYMSOCV a) where c : MDFEQTCPLCK<a, BSJAKYMSOCV, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x410EDA0", Offset = "0x410E1A0", VA = "0x18410EDA0")]
		public static bool VEKSGNEQEVU<d, e, f>([In] this TypeSys<d, e, f> _, BSJAKYMSOCV a) where f : MDFEQTCPLCK<d, BSJAKYMSOCV, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x410D010", Offset = "0x410C410", VA = "0x18410D010")]
		public static bool JQOVZJIIJEO<g, h, i>([In] this TypeSys<g, h, i> self, BSJAKYMSOCV a, BSJAKYMSOCV b) where i : MDFEQTCPLCK<g, BSJAKYMSOCV, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x410DB90", Offset = "0x410CF90", VA = "0x18410DB90")]
		private static bool PVUAKSDPBHF<j, k, l>([In] this TypeSys<j, k, l> self, BSJAKYMSOCV a, BSJAKYMSOCV b, IReadOnlyList<BSJAKYMSOCV> c, IReadOnlyList<BSJAKYMSOCV> d) where l : MDFEQTCPLCK<j, BSJAKYMSOCV, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4105320", Offset = "0x4104720", VA = "0x184105320")]
		public static BSJAKYMSOCV IZZNNHOBKMZ<m, n, o>([In] this TypeSys<m, n, o> self, n a, BSJAKYMSOCV b, BSJAKYMSOCV c) where o : MDFEQTCPLCK<m, BSJAKYMSOCV, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4105680", Offset = "0x4104A80", VA = "0x184105680")]
		public static p IZZNNHOBKMZ<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : MDFEQTCPLCK<p, BSJAKYMSOCV, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4104F20", Offset = "0x4104320", VA = "0x184104F20")]
		private static List<w> EFSFKEPXOFD<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : MDFEQTCPLCK<t, BSJAKYMSOCV, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x410D9F0", Offset = "0x410CDF0", VA = "0x18410D9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA3030", Offset = "0x2BA2430", VA = "0x182BA3030")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA2BE0", Offset = "0x2BA1FE0", VA = "0x182BA2BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA29D0", Offset = "0x2BA1DD0", VA = "0x182BA29D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA2B00", Offset = "0x2BA1F00", VA = "0x182BA2B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA3080", Offset = "0x2BA2480", VA = "0x182BA3080")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA2A20", Offset = "0x2BA1E20", VA = "0x182BA2A20")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA2800", Offset = "0x2BA1C00", VA = "0x182BA2800")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA2850", Offset = "0x2BA1C50", VA = "0x182BA2850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2BA28A0", Offset = "0x2BA1CA0", VA = "0x182BA28A0")]
		public static ZMFHVAWJYMI KBGMAVVFELG([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2B50", Offset = "0x2BA1F50", VA = "0x182BA2B50")]
		public static ZMFHVAWJYMI SBLLSLBKFUW(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2C30", Offset = "0x2BA2030", VA = "0x182BA2C30")]
		public static ZMFHVAWJYMI VSIGLEEIJLE(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2CC0", Offset = "0x2BA20C0", VA = "0x182BA2CC0")]
		public static ZMFHVAWJYMI VSIGLEEIJLE(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2A70", Offset = "0x2BA1E70", VA = "0x182BA2A70")]
		public static ZMFHVAWJYMI QTNBKFWDLAD(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2E60", Offset = "0x2BA2260", VA = "0x182BA2E60")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public UQEFQITABRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA64C0", Offset = "0x2BA58C0", VA = "0x182BA64C0")]
			internal BSJAKYMSOCV KARHESHPYVS(BSJAKYMSOCV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BSJAKYMSOCV BSAOMIYLMNI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<BSJAKYMSOCV> ZBVOVXRXXPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BAAA40", Offset = "0x2BA9E40", VA = "0x182BAAA40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAD60", Offset = "0x2BAA160", VA = "0x182BAAD60", Slot = "9")]
		public sealed override BSJAKYMSOCV NKRLZPTQNSW(IReadOnlyDictionary<string, BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAF10", Offset = "0x2BAA310", VA = "0x182BAAF10", Slot = "11")]
		public sealed override void SISHBKCUENM(Action<BSJAKYMSOCV> a, Action<BSJAKYMSOCV> b, Action<BSJAKYMSOCV> c, Action<BSJAKYMSOCV> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB1B0", Offset = "0x2BAA5B0", VA = "0x182BAB1B0")]
		private ZMFHVAWJYMI(BSJAKYMSOCV a, IEnumerable<BSJAKYMSOCV> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAE80", Offset = "0x2BAA280", VA = "0x182BAAE80")]
		public static ZMFHVAWJYMI New(BSJAKYMSOCV originalType, IEnumerable<BSJAKYMSOCV> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB170", Offset = "0x2BAA570", VA = "0x182BAB170", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAC70", Offset = "0x2BAA070", VA = "0x182BAAC70", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BAACC0", Offset = "0x2BAA0C0", VA = "0x182BAACC0")]
		public bool NFHEFKJNFIE([In] ZMFHVAWJYMI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAC00", Offset = "0x2BAA000", VA = "0x182BAAC00", Slot = "18")]
		public bool Equals(ZMFHVAWJYMI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAC20", Offset = "0x2BAA020", VA = "0x182BAAC20", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAB50", Offset = "0x2BA9F50", VA = "0x182BAAB50", Slot = "14")]
		protected override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAF00", Offset = "0x2BAA300", VA = "0x182BAAF00", Slot = "19")]
		private bool RHBZNKVLTSN([In] ZMFHVAWJYMI other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class QQJNIOLCRCP : BSJAKYMSOCV, IEquatable<QQJNIOLCRCP>, MAQPBFCDGIJ<QQJNIOLCRCP>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA44B0", Offset = "0x2BA38B0", VA = "0x182BA44B0")]
		private QQJNIOLCRCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4310", Offset = "0x2BA3710", VA = "0x182BA4310")]
		public static QQJNIOLCRCP New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4450", Offset = "0x2BA3850", VA = "0x182BA4450", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BA43C0", Offset = "0x2BA37C0", VA = "0x182BA43C0", Slot = "15")]
		public sealed override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4380", Offset = "0x2BA3780", VA = "0x182BA4380")]
		private static string PXZDOFMZFQA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2BA42C0", Offset = "0x2BA36C0", VA = "0x182BA42C0", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630")]
		public bool NFHEFKJNFIE([In] QQJNIOLCRCP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xF71780", Offset = "0xF70B80", VA = "0x180F71780", Slot = "18")]
		public bool Equals(QQJNIOLCRCP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4270", Offset = "0x2BA3670", VA = "0x182BA4270", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public ZMZGDOYHPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2BAB3F0", Offset = "0x2BAA7F0", VA = "0x182BAB3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public ZMTZGIEKFWY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2BAB270", Offset = "0x2BAA670", VA = "0x182BAB270")]
			internal ZMFHVAWJYMI RNYWPRIAJQY(BSJAKYMSOCV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA5D0", Offset = "0x2BA99D0", VA = "0x182BAA5D0")]
		public static IEnumerable<YDXBZIIWDJA> VHFUCBFZOUM(this YDXBZIIWDJA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8930", Offset = "0x2BA7D30", VA = "0x182BA8930")]
		private static IEnumerable<YDXBZIIWDJA> LZUZVACNVCS(this YDXBZIIWDJA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8770", Offset = "0x2BA7B70", VA = "0x182BA8770")]
		public static (BSJAKYMSOCV, IReadOnlyList<BSJAKYMSOCV>, bool) HIRAWEPEOSA(this BSJAKYMSOCV a, [Optional] IReadOnlyList<BSJAKYMSOCV> b)
		{
			return default((BSJAKYMSOCV, IReadOnlyList<BSJAKYMSOCV>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8740", Offset = "0x2BA7B40", VA = "0x182BA8740")]
		public static TypeKind GYPEMSITGJJ(this BSJAKYMSOCV a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7990", Offset = "0x2BA6D90", VA = "0x182BA7990")]
		private static BSJAKYMSOCV ConvertClassesToIntersections(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8430", Offset = "0x2BA7830", VA = "0x182BA8430")]
		private static BSJAKYMSOCV DistributeUnionIntoIntersection(this ZMFHVAWJYMI self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7FC0", Offset = "0x2BA73C0", VA = "0x182BA7FC0")]
		private static BSJAKYMSOCV DistributeIntersectionIntoIntersection(this ZMFHVAWJYMI self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA82D0", Offset = "0x2BA76D0", VA = "0x182BA82D0")]
		private static BSJAKYMSOCV DistributeIntoIntersection(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8A80", Offset = "0x2BA7E80", VA = "0x182BA8A80")]
		private static bool OtherIsAssignableToOther(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes, BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9E50", Offset = "0x2BA9250", VA = "0x182BA9E50")]
		private static bool UnionIsAssignableToOther(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes, BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8C10", Offset = "0x2BA8010", VA = "0x182BA8C10")]
		private static bool OtherIsAssignableToUnion(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes, BSJAKYMSOCV union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA170", Offset = "0x2BA9570", VA = "0x182BAA170")]
		private static bool UnionIsAssignableToUnion(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes, BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9C50", Offset = "0x2BA9050", VA = "0x182BA9C50")]
		public static BSJAKYMSOCV RemoveCommonTypesFromIntersectionDistribution(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8FB0", Offset = "0x2BA83B0", VA = "0x182BA8FB0")]
		public static BSJAKYMSOCV RemoveCommonTypesFromIntersectionDistributionInternal(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9D80", Offset = "0x2BA9180", VA = "0x182BA9D80")]
		public static BSJAKYMSOCV SimplifyIntersectionUnion(this BSJAKYMSOCV self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA7F0", Offset = "0x2BA9BF0", VA = "0x182BAA7F0")]
		public static IEnumerable<BSJAKYMSOCV> ZBVOVXRXXPD(this BSJAKYMSOCV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2BA89F0", Offset = "0x2BA7DF0", VA = "0x182BA89F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public HALWUWOXEIZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BA25C0", Offset = "0x2BA19C0", VA = "0x182BA25C0", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2200", Offset = "0x2BA1600", VA = "0x182BA2200", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2BA20C0", Offset = "0x2BA14C0", VA = "0x182BA20C0")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2110", Offset = "0x2BA1510", VA = "0x182BA2110")]
			private void ALONWGIYSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2710", Offset = "0x2BA1B10", VA = "0x182BA2710", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2160", Offset = "0x2BA1560", VA = "0x182BA2160", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YDXBZIIWDJA> ERBCXSMUTRM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2160", Offset = "0x2BA1560", VA = "0x182BA2160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BA6850", Offset = "0x2BA5C50", VA = "0x182BA6850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? SMCEYZNTYPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xF5A7F0", Offset = "0xF59BF0", VA = "0x180F5A7F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xF5A620", Offset = "0xF59A20", VA = "0x180F5A620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DE0", Offset = "0xCF41E0", VA = "0x180CF4DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<YDXBZIIWDJA> OZULLSCWKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E20", Offset = "0xCF4220", VA = "0x180CF4E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<YDXBZIIWDJA> FFPDPUBYRVO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6760", Offset = "0x2BA5B60", VA = "0x182BA6760")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4DF0", Offset = "0xCF41F0", VA = "0x180CF4DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E00", Offset = "0xCF4200", VA = "0x180CF4E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, CFJRYRQGJHA> FDTQANXRFLR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF4020", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCF5520", Offset = "0xCF4920", VA = "0x180CF5520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7690", Offset = "0x2BA6A90", VA = "0x182BA7690")]
		public YDXBZIIWDJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA75E0", Offset = "0x2BA69E0", VA = "0x182BA75E0")]
		public YDXBZIIWDJA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6A90", Offset = "0x2BA5E90", VA = "0x182BA6A90")]
		public static YDXBZIIWDJA JKQQFBRMSQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7440", Offset = "0x2BA6840", VA = "0x182BA7440")]
		public static YDXBZIIWDJA XEJZBBLNDXR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA68A0", Offset = "0x2BA5CA0", VA = "0x182BA68A0")]
		public void Initialize(YDXBZIIWDJA from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA76F0", Offset = "0x2BA6AF0", VA = "0x182BA76F0")]
		private YDXBZIIWDJA([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<MSODNTWMEDL> c, [Optional] IEnumerable<YDXBZIIWDJA> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, CFJRYRQGJHA>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F00", Offset = "0x2BA6300", VA = "0x182BA6F00")]
		public static YDXBZIIWDJA New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<MSODNTWMEDL> typeParameters, [Optional] IEnumerable<YDXBZIIWDJA> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, CFJRYRQGJHA>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7350", Offset = "0x2BA6750", VA = "0x182BA7350", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA74A0", Offset = "0x2BA68A0", VA = "0x182BA74A0")]
		private string YKHJXKDGWNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6590", Offset = "0x2BA5990", VA = "0x182BA6590")]
		private static string CVOZSSHFPSG(IEnumerable<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6AE0", Offset = "0x2BA5EE0", VA = "0x182BA6AE0")]
		private string JXKMPCILIZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BA70A0", Offset = "0x2BA64A0", VA = "0x182BA70A0")]
		private string TTUFTFSDCSE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6FD0", Offset = "0x2BA63D0", VA = "0x182BA6FD0", Slot = "15")]
		public sealed override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6EB0", Offset = "0x2BA62B0", VA = "0x182BA6EB0", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D90", Offset = "0x2BA6190", VA = "0x182BA6D90")]
		public bool NFHEFKJNFIE([In] YDXBZIIWDJA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6830", Offset = "0x2BA5C30", VA = "0x182BA6830", Slot = "18")]
		public bool Equals(YDXBZIIWDJA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA67E0", Offset = "0x2BA5BE0", VA = "0x182BA67E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6650", Offset = "0x2BA5A50", VA = "0x182BA6650", Slot = "14")]
		protected override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7490", Offset = "0x2BA6890", VA = "0x182BA7490", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		private HRKYUVQKNES(BSJAKYMSOCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA27A0", Offset = "0x2BA1BA0", VA = "0x182BA27A0")]
		public static HRKYUVQKNES New(BSJAKYMSOCV type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B61930", Offset = "0x2B60D30", VA = "0x182B61930", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F870", Offset = "0x2B9EC70", VA = "0x182B9F870")]
		public bool NFHEFKJNFIE([In] HRKYUVQKNES other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7D0", Offset = "0x2B9EBD0", VA = "0x182B9F7D0", Slot = "4")]
		public bool Equals(HRKYUVQKNES other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2750", Offset = "0x2BA1B50", VA = "0x182BA2750", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B78D20", Offset = "0x2B78120", VA = "0x182B78D20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F8C0", Offset = "0x2B9ECC0", VA = "0x182B9F8C0", Slot = "6")]
		public int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F870", Offset = "0x2B9EC70", VA = "0x182B9F870", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		private BNLUDIDPNCL(BSJAKYMSOCV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F8F0", Offset = "0x2B9ECF0", VA = "0x182B9F8F0")]
		public static BNLUDIDPNCL New(BSJAKYMSOCV type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B61930", Offset = "0x2B60D30", VA = "0x182B61930", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F870", Offset = "0x2B9EC70", VA = "0x182B9F870")]
		public bool NFHEFKJNFIE([In] BNLUDIDPNCL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7D0", Offset = "0x2B9EBD0", VA = "0x182B9F7D0", Slot = "4")]
		public bool Equals(BNLUDIDPNCL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F820", Offset = "0x2B9EC20", VA = "0x182B9F820", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B78D20", Offset = "0x2B78120", VA = "0x182B78D20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F8C0", Offset = "0x2B9ECC0", VA = "0x182B9F8C0", Slot = "6")]
		public int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F870", Offset = "0x2B9EC70", VA = "0x182B9F870", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0AB0", Offset = "0x2B9FEB0", VA = "0x182BA0AB0")]
		private CFJRYRQGJHA(IEnumerable<MSODNTWMEDL> a, IEnumerable<KeyValuePair<string, HRKYUVQKNES>> b, IEnumerable<KeyValuePair<string, BNLUDIDPNCL>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BA04F0", Offset = "0x2B9F8F0", VA = "0x182BA04F0")]
		public static CFJRYRQGJHA New(IEnumerable<MSODNTWMEDL> typeParameters, IEnumerable<KeyValuePair<string, HRKYUVQKNES>> inputs, IEnumerable<KeyValuePair<string, BNLUDIDPNCL>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0630", Offset = "0x2B9FA30", VA = "0x182BA0630", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FF20", Offset = "0x2B9F320", VA = "0x182B9FF20", Slot = "15")]
		public sealed override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0370", Offset = "0x2B9F770", VA = "0x182BA0370")]
		private string NLUNKCPVNFZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0930", Offset = "0x2B9FD30", VA = "0x182BA0930")]
		private string WESRYEIAVZC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0320", Offset = "0x2B9F720", VA = "0x182BA0320", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0240", Offset = "0x2B9F640", VA = "0x182BA0240")]
		public bool NFHEFKJNFIE([In] CFJRYRQGJHA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA01D0", Offset = "0x2B9F5D0", VA = "0x182BA01D0", Slot = "18")]
		public bool Equals(CFJRYRQGJHA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA01F0", Offset = "0x2B9F5F0", VA = "0x182BA01F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA00F0", Offset = "0x2B9F4F0", VA = "0x182BA00F0", Slot = "14")]
		protected sealed override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0620", Offset = "0x2B9FA20", VA = "0x182BA0620", Slot = "19")]
		private bool PGQYQULYXZN([In] CFJRYRQGJHA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class EHTODBRDAHV : BSJAKYMSOCV, IEquatable<EHTODBRDAHV>, MAQPBFCDGIJ<EHTODBRDAHV>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1D60", Offset = "0x2BA1160", VA = "0x182BA1D60")]
		private EHTODBRDAHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1BD0", Offset = "0x2BA0FD0", VA = "0x182BA1BD0")]
		public static EHTODBRDAHV New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1D30", Offset = "0x2BA1130", VA = "0x182BA1D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1C40", Offset = "0x2BA1040", VA = "0x182BA1C40", Slot = "15")]
		public override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1AE0", Offset = "0x2BA0EE0", VA = "0x182BA1AE0", Slot = "16")]
		public override int FXZDBLVUAHL(IReadOnlyList<BSJAKYMSOCV> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1B30", Offset = "0x2BA0F30", VA = "0x182BA1B30", Slot = "17")]
		public override bool JXFVUMHPIWY(IReadOnlyList<BSJAKYMSOCV> a, IReadOnlyList<BSJAKYMSOCV> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1B80", Offset = "0x2BA0F80", VA = "0x182BA1B80", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630")]
		public bool NFHEFKJNFIE([In] EHTODBRDAHV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xF71780", Offset = "0xF70B80", VA = "0x180F71780", Slot = "18")]
		public bool Equals(EHTODBRDAHV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1A90", Offset = "0x2BA0E90", VA = "0x182BA1A90", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEABB30", Offset = "0xEAAF30", VA = "0x180EABB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x126C9E0", Offset = "0x126BDE0", VA = "0x18126C9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4210", Offset = "0x2BA3610", VA = "0x182BA4210")]
		private Property(BSJAKYMSOCV type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2BA40A0", Offset = "0x2BA34A0", VA = "0x182BA40A0")]
		public static Property New(BSJAKYMSOCV type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4130", Offset = "0x2BA3530", VA = "0x182BA4130", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3C50", Offset = "0x2BA3050", VA = "0x182BA3C50")]
		private string ABKBDEWFDOS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3D60", Offset = "0x2BA3160", VA = "0x182BA3D60")]
		private string EYQEILONDLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3FA0", Offset = "0x2BA33A0", VA = "0x182BA3FA0")]
		public bool NFHEFKJNFIE([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3E00", Offset = "0x2BA3200", VA = "0x182BA3E00", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3DB0", Offset = "0x2BA31B0", VA = "0x182BA3DB0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3E20", Offset = "0x2BA3220", VA = "0x182BA3E20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3CB0", Offset = "0x2BA30B0", VA = "0x182BA3CB0")]
		private int EOEAAFJOCDL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3EE0", Offset = "0x2BA32E0", VA = "0x182BA3EE0", Slot = "6")]
		public int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3CA0", Offset = "0x2BA30A0", VA = "0x182BA3CA0", Slot = "5")]
		private bool BLPTXOLSCOW([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class ARCOLPSGVYE : BSJAKYMSOCV, IEquatable<ARCOLPSGVYE>, MAQPBFCDGIJ<ARCOLPSGVYE>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7B0", Offset = "0x2B9EBB0", VA = "0x182B9F7B0")]
		private ARCOLPSGVYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F690", Offset = "0x2B9EA90", VA = "0x182B9F690")]
		public static ARCOLPSGVYE New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F780", Offset = "0x2B9EB80", VA = "0x182B9F780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F700", Offset = "0x2B9EB00", VA = "0x182B9F700", Slot = "15")]
		public override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F640", Offset = "0x2B9EA40", VA = "0x182B9F640", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630")]
		public bool NFHEFKJNFIE([In] ARCOLPSGVYE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF71780", Offset = "0xF70B80", VA = "0x180F71780", Slot = "18")]
		public bool Equals(ARCOLPSGVYE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F5E0", Offset = "0x2B9E9E0", VA = "0x182B9F5E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0C60", Offset = "0x2BA0060", VA = "0x182BA0C60", Slot = "9")]
		public sealed override BSJAKYMSOCV NKRLZPTQNSW(IReadOnlyDictionary<string, BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0DC0", Offset = "0x2BA01C0", VA = "0x182BA0DC0", Slot = "11")]
		public sealed override void SISHBKCUENM(Action<BSJAKYMSOCV> a, Action<BSJAKYMSOCV> b, Action<BSJAKYMSOCV> c, Action<BSJAKYMSOCV> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0DF0", Offset = "0x2BA01F0", VA = "0x182BA0DF0")]
		private CVOJHGHTZTE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0D40", Offset = "0x2BA0140", VA = "0x182BA0D40")]
		public static CVOJHGHTZTE New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0C10", Offset = "0x2BA0010", VA = "0x182BA0C10", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630")]
		public bool NFHEFKJNFIE([In] CVOJHGHTZTE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xF71780", Offset = "0xF70B80", VA = "0x180F71780", Slot = "18")]
		public bool Equals(CVOJHGHTZTE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0BC0", Offset = "0x2B9FFC0", VA = "0x182BA0BC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0BA0", Offset = "0x2B9FFA0", VA = "0x182BA0BA0", Slot = "14")]
		protected sealed override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA940", Offset = "0x2BA9D40", VA = "0x182BAA940")]
		public void Initialize(ZLFCCNWZUSL from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA9D0", Offset = "0x2BA9DD0", VA = "0x182BAA9D0")]
		protected ZLFCCNWZUSL(IEnumerable<MSODNTWMEDL> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool NFHEFKJNFIE([In] BSJAKYMSOCV other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA970", Offset = "0x2BA9D70", VA = "0x182BAA970")]
		protected bool NFHEFKJNFIE([In] ZLFCCNWZUSL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA840", Offset = "0x2BA9C40", VA = "0x182BAA840", Slot = "14")]
		protected override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA8C0", Offset = "0x2BA9CC0", VA = "0x182BAA8C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B90", Offset = "0x2BA2F90", VA = "0x182BA3B90")]
		private MSODNTWMEDL(string a, [Optional] BSJAKYMSOCV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3A00", Offset = "0x2BA2E00", VA = "0x182BA3A00")]
		public static MSODNTWMEDL New(string name, [Optional] BSJAKYMSOCV constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B00", Offset = "0x2BA2F00", VA = "0x182BA3B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BA39B0", Offset = "0x2BA2DB0", VA = "0x182BA39B0", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3960", Offset = "0x2BA2D60", VA = "0x182BA3960")]
		public bool NFHEFKJNFIE([In] MSODNTWMEDL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3850", Offset = "0x2BA2C50", VA = "0x182BA3850", Slot = "18")]
		public bool Equals(MSODNTWMEDL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BA38A0", Offset = "0x2BA2CA0", VA = "0x182BA38A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BA37D0", Offset = "0x2BA2BD0", VA = "0x182BA37D0", Slot = "14")]
		protected override int EOEAAFJOCDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BA38F0", Offset = "0x2BA2CF0", VA = "0x182BA38F0", Slot = "13")]
		public override int MAGHPDUQHYB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3960", Offset = "0x2BA2D60", VA = "0x182BA3960", Slot = "19")]
		private bool UMJMBCPXCEK([In] MSODNTWMEDL other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class KBTULLJQNIB : BSJAKYMSOCV, IEquatable<KBTULLJQNIB>, MAQPBFCDGIJ<KBTULLJQNIB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BA37B0", Offset = "0x2BA2BB0", VA = "0x182BA37B0")]
		private KBTULLJQNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3620", Offset = "0x2BA2A20", VA = "0x182BA3620")]
		public static KBTULLJQNIB New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3780", Offset = "0x2BA2B80", VA = "0x182BA3780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3690", Offset = "0x2BA2A90", VA = "0x182BA3690", Slot = "15")]
		public override string TRIXLILWIJE(IReadOnlyList<BSJAKYMSOCV> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3530", Offset = "0x2BA2930", VA = "0x182BA3530", Slot = "16")]
		public override int FXZDBLVUAHL(IReadOnlyList<BSJAKYMSOCV> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3580", Offset = "0x2BA2980", VA = "0x182BA3580", Slot = "17")]
		public override bool JXFVUMHPIWY(IReadOnlyList<BSJAKYMSOCV> a, IReadOnlyList<BSJAKYMSOCV> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA35D0", Offset = "0x2BA29D0", VA = "0x182BA35D0", Slot = "12")]
		public override bool NFHEFKJNFIE([In] BSJAKYMSOCV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630")]
		public bool NFHEFKJNFIE([In] KBTULLJQNIB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xF71780", Offset = "0xF70B80", VA = "0x180F71780", Slot = "18")]
		public bool Equals(KBTULLJQNIB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BA34E0", Offset = "0x2BA28E0", VA = "0x182BA34E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F630", Offset = "0x2B9EA30", VA = "0x182B9F630", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA10C0", Offset = "0x2BA04C0", VA = "0x182BA10C0")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1050", Offset = "0x2BA0450", VA = "0x182BA1050")]
		public static CircuitTypeOrString WQHQWYPMLDD(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0FF0", Offset = "0x2BA03F0", VA = "0x182BA0FF0")]
		public static CircuitTypeOrString WQHQWYPMLDD(BSJAKYMSOCV a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0F50", Offset = "0x2BA0350", VA = "0x182BA0F50")]
		public BSJAKYMSOCV SYQXXAAIACU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0E30", Offset = "0x2BA0230", VA = "0x182BA0E30")]
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
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		private ClassFactoryBaseClasses(ESJHUWXKJLO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x10E36E0", Offset = "0x10E2AE0", VA = "0x1810E36E0")]
		public static ClassFactoryBaseClasses New(ESJHUWXKJLO data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA11A0", Offset = "0x2BA05A0", VA = "0x182BA11A0")]
		public ClassFactoryBaseClasses QZMSJKEYDJM(YDXBZIIWDJA a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x187E2E0", Offset = "0x187D6E0", VA = "0x18187E2E0")]
		public ClassFactoryProps QUVDBALXKSN()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1140", Offset = "0x2BA0540", VA = "0x182BA1140")]
		public ClassFactoryProps QNXVMXKOROC(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BA10F0", Offset = "0x2BA04F0", VA = "0x182BA10F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BA1F30", Offset = "0x2BA1330", VA = "0x182BA1F30")]
		private ESJHUWXKJLO([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1D80", Offset = "0x2BA1180", VA = "0x182BA1D80")]
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
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		private ClassFactoryFuncs(ESJHUWXKJLO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x10E36E0", Offset = "0x10E2AE0", VA = "0x1810E36E0")]
		public static ClassFactoryFuncs New(ESJHUWXKJLO data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1260", Offset = "0x2BA0660", VA = "0x182BA1260")]
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
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		public ClassFactoryProps(ESJHUWXKJLO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BA13F0", Offset = "0x2BA07F0", VA = "0x182BA13F0")]
		public ClassFactoryProps QNXVMXKOROC(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x187E2E0", Offset = "0x187D6E0", VA = "0x18187E2E0")]
		public ClassFactoryFuncs PZQWSJKGVUQ()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA13B0", Offset = "0x2BA07B0", VA = "0x182BA13B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		private ClassFactoryTypeParams(ESJHUWXKJLO data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA15E0", Offset = "0x2BA09E0", VA = "0x182BA15E0")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA17F0", Offset = "0x2BA0BF0", VA = "0x182BA17F0")]
		public ClassFactoryTypeParams VWNISKSIKUU(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x187E2E0", Offset = "0x187D6E0", VA = "0x18187E2E0")]
		public ClassFactoryBaseClasses SDNBDBMUODO()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BA17B0", Offset = "0x2BA0BB0", VA = "0x182BA17B0")]
		public ClassFactoryBaseClasses QZMSJKEYDJM(YDXBZIIWDJA a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1580", Offset = "0x2BA0980", VA = "0x182BA1580")]
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
