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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HZZYFIUKWAB : IEquatable<HZZYFIUKWAB>, SCCEHWEFPHH<HZZYFIUKWAB>, ENOPHJTKITG
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool AWQVEYILYSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool BCVNXQKMWUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int PNVOKEEQUDP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind QZFCEIPKDTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? EBNDKVCMCCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2BD5DF0", Offset = "0x2BD47F0", VA = "0x182BD5DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual HZZYFIUKWAB XUVSPWCGWPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool UCSDUZMHEXG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6070", Offset = "0x2BD4A70", VA = "0x182BD6070")]
		public static void SRPDLCJVRSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
		protected HZZYFIUKWAB(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5E60", Offset = "0x2BD4860", VA = "0x182BD5E60")]
		public static HZZYFIUKWAB New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		protected static a IJCIKLCFBSB<a>(a a) where a : HZZYFIUKWAB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0", Slot = "9")]
		public virtual HZZYFIUKWAB VVCQMGXEHGO(IReadOnlyDictionary<string, HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5DC0", Offset = "0x2BD47C0", VA = "0x182BD5DC0", Slot = "11")]
		public virtual void ICTXZCNZRES(Action<HZZYFIUKWAB> a, Action<HZZYFIUKWAB> b, Action<HZZYFIUKWAB> c, Action<HZZYFIUKWAB> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6100", Offset = "0x2BD4B00", VA = "0x182BD6100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6270", Offset = "0x2BD4C70", VA = "0x182BD6270", Slot = "12")]
		public virtual bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5C90", Offset = "0x2BD4690", VA = "0x182BD5C90", Slot = "4")]
		public bool Equals(HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5C40", Offset = "0x2BD4640", VA = "0x182BD5C40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6030", Offset = "0x2BD4A30", VA = "0x182BD6030")]
		public static bool SHHUBVCQRYC(HZZYFIUKWAB a, HZZYFIUKWAB b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5C00", Offset = "0x2BD4600", VA = "0x182BD5C00")]
		public static bool ENWYWLXFHXP(HZZYFIUKWAB a, HZZYFIUKWAB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5D10", Offset = "0x2BD4710", VA = "0x182BD5D10", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5B80", Offset = "0x2BD4580", VA = "0x182BD5B80", Slot = "13")]
		public virtual int ANNERUPBDRX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5B80", Offset = "0x2BD4580", VA = "0x182BD5B80", Slot = "14")]
		protected virtual int ZQAAQMEZZPX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B278F0", Offset = "0x3B262F0", VA = "0x183B278F0")]
		public b QCTXCFPJGWJ<b>() where b : HZZYFIUKWAB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4A40", Offset = "0x2BD3440", VA = "0x182BD4A40", Slot = "15")]
		public virtual string SFXAXROLCZM(IReadOnlyList<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5BB0", Offset = "0x2BD45B0", VA = "0x182BD5BB0", Slot = "16")]
		public virtual int CGCBGEQSIER(IReadOnlyList<HZZYFIUKWAB> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5CC0", Offset = "0x2BD46C0", VA = "0x182BD5CC0", Slot = "17")]
		public virtual bool GOPLVLUYDPS(IReadOnlyList<HZZYFIUKWAB> a, IReadOnlyList<HZZYFIUKWAB> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5EE0", Offset = "0x2BD48E0", VA = "0x182BD5EE0")]
		public ZGFIKLGOGCU PJGRLPLUQPQ(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5ED0", Offset = "0x2BD48D0", VA = "0x182BD5ED0")]
		public ZGFIKLGOGCU PJGRLPLUQPQ(params HZZYFIUKWAB[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5ED0", Offset = "0x2BD48D0", VA = "0x182BD5ED0")]
		public ZGFIKLGOGCU PJGRLPLUQPQ(IEnumerable<HZZYFIUKWAB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface SWYTVHETLJM<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a EJZLZWIFBRK(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b MMAOFCTWQJI([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind UFDKVSSFIUM([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates BMKRLQVWROT(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ENOPHJTKITG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ANNERUPBDRX(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ANNERUPBDRX
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class WZMNMFSNCIX<a> where a : ENOPHJTKITG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int HNHHVKVXHAG;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WZMNMFSNCIX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x874CDE0", Offset = "0x874B7E0", VA = "0x18874CDE0")]
			internal int DXPNOAQZLTC(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LQPRZMCNGRT<a, b> where b : ENOPHJTKITG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int HNHHVKVXHAG;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LQPRZMCNGRT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68D62A0", Offset = "0x68D4CA0", VA = "0x1868D62A0")]
			internal int DXPNOAQZLTC(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class MWVGGDREEOF<a> where a : ENOPHJTKITG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int HNHHVKVXHAG;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public MWVGGDREEOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F439F0", Offset = "0x6F423F0", VA = "0x186F439F0")]
			internal int XWOGDKOCPXT(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x33A6130", Offset = "0x33A4B30", VA = "0x1833A6130")]
		public static int MGEKGKFKMQW<a>(this IEnumerable<a> a, int b = 0) where a : ENOPHJTKITG
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x33A6200", Offset = "0x33A4C00", VA = "0x1833A6200")]
		public static int MGEKGKFKMQW<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : ENOPHJTKITG
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x33A6130", Offset = "0x33A4B30", VA = "0x1833A6130")]
		public static int IPTYJHBCTQB<d>(this IEnumerable<d> a, int b = 0) where d : ENOPHJTKITG
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : SWYTVHETLJM<TDirectedType, HZZYFIUKWAB, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5373EA0", Offset = "0x53728A0", VA = "0x185373EA0")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7CDAA90", Offset = "0x7CD9490", VA = "0x187CDAA90")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class MZQBMSMUIRR
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class IOLRSXCWHGJ<a, b, c> where c : SWYTVHETLJM<a, HZZYFIUKWAB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public HZZYFIUKWAB BWYJSBZAALD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<HZZYFIUKWAB> BGPJRDXRNOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public HZZYFIUKWAB IEAEMKVQKRK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<HZZYFIUKWAB> KMDDWXABXJT;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public IOLRSXCWHGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6601320", Offset = "0x65FFD20", VA = "0x186601320")]
			internal bool WVRKKFFDEWH([In] TypeSys<a, b, c> self_, HZZYFIUKWAB a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6601570", Offset = "0x65FFF70", VA = "0x186601570")]
			internal bool WVWRHLZAOHQ([In] TypeSys<a, b, c> self_, HZZYFIUKWAB a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6601680", Offset = "0x6600080", VA = "0x186601680")]
			internal bool WWMLZGGSQPR([In] TypeSys<a, b, c> self_, HZZYFIUKWAB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class LHITROLGQKS<a, b, c> where c : SWYTVHETLJM<a, HZZYFIUKWAB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public HZZYFIUKWAB TQUQGLKBVCV;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LHITROLGQKS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x68C1010", Offset = "0x68BFA10", VA = "0x1868C1010")]
			internal bool WWHFBZMVHEI([In] TypeSys<a, b, c> self__, HZZYFIUKWAB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MXMYXMODOUH<a, b, c> where c : SWYTVHETLJM<a, HZZYFIUKWAB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b VQTHZPRYINY;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public MXMYXMODOUH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F44750", Offset = "0x6F43150", VA = "0x186F44750")]
			internal HZZYFIUKWAB NXNBFTKBDOY([In] TypeSys<a, b, c> self_, [In] b root_, HZZYFIUKWAB a, HZZYFIUKWAB b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ENBBWHRQGXG<a, b, c> where c : SWYTVHETLJM<a, HZZYFIUKWAB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public RISVPEMNZVA CBYGYPHNXFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public RISVPEMNZVA EYSBPKSFMPO;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ENBBWHRQGXG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5B49BB0", Offset = "0x5B485B0", VA = "0x185B49BB0")]
			internal a NYCVXNRTFWZ([In] TypeSys<a, b, c> self_, IOKind a, RISVPEMNZVA b, RISVPEMNZVA c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class SPBUAACGNMZ<a, b, c> where c : SWYTVHETLJM<a, HZZYFIUKWAB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<RISVPEMNZVA> TXYBHSUBHFU;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public SPBUAACGNMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x79023E0", Offset = "0x7900DE0", VA = "0x1879023E0")]
			internal bool JDYCRGIXQXD(bool a, RISVPEMNZVA b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] KPQGMJUOOZW;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C573D0", Offset = "0x3C55DD0", VA = "0x183C573D0")]
		public static bool PNQSHFKQLCB<a, b, c>([In] this TypeSys<a, b, c> _, HZZYFIUKWAB a) where c : SWYTVHETLJM<a, HZZYFIUKWAB, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C573F0", Offset = "0x3C55DF0", VA = "0x183C573F0")]
		public static bool RKWOCLEAPWW<d, e, f>([In] this TypeSys<d, e, f> _, HZZYFIUKWAB a) where f : SWYTVHETLJM<d, HZZYFIUKWAB, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E2B0", Offset = "0x3C4CCB0", VA = "0x183C4E2B0")]
		public static bool ABPMYNPUPOK<g, h, i>([In] this TypeSys<g, h, i> self, HZZYFIUKWAB a, HZZYFIUKWAB b) where i : SWYTVHETLJM<g, HZZYFIUKWAB, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E450", Offset = "0x3C4CE50", VA = "0x183C4E450")]
		private static bool KFXTXCTCTML<j, k, l>([In] this TypeSys<j, k, l> self, HZZYFIUKWAB a, HZZYFIUKWAB b, IReadOnlyList<HZZYFIUKWAB> c, IReadOnlyList<HZZYFIUKWAB> d) where l : SWYTVHETLJM<j, HZZYFIUKWAB, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F680", Offset = "0x3C4E080", VA = "0x183C4F680")]
		public static HZZYFIUKWAB LTHRAXGGBBL<m, n, o>([In] this TypeSys<m, n, o> self, n a, HZZYFIUKWAB b, HZZYFIUKWAB c) where o : SWYTVHETLJM<m, HZZYFIUKWAB, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F9D0", Offset = "0x3C4E3D0", VA = "0x183C4F9D0")]
		public static p LTHRAXGGBBL<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : SWYTVHETLJM<p, HZZYFIUKWAB, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3C582C0", Offset = "0x3C56CC0", VA = "0x183C582C0")]
		private static List<w> XYVQUSOCECZ<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : SWYTVHETLJM<t, HZZYFIUKWAB, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C57C50", Offset = "0x3C56650", VA = "0x183C57C50")]
		private static ba WFOEYMFZLFR<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class BNKAYRTVCTM
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static HZZYFIUKWAB KDDZIISXHTB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2D30", Offset = "0x2BD1730", VA = "0x182BD2D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static HZZYFIUKWAB OSVOASADAUT
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2880", Offset = "0x2BD1280", VA = "0x182BD2880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static HZZYFIUKWAB FDFTGKQDCTK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2BD27E0", Offset = "0x2BD11E0", VA = "0x182BD27E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static HZZYFIUKWAB BRENKGXIHFU
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2700", Offset = "0x2BD1100", VA = "0x182BD2700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static HZZYFIUKWAB ODHRTFBTPJO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2CE0", Offset = "0x2BD16E0", VA = "0x182BD2CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static HZZYFIUKWAB YERKSMIRHAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2830", Offset = "0x2BD1230", VA = "0x182BD2830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static HZZYFIUKWAB SWILVONJDQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2F90", Offset = "0x2BD1990", VA = "0x182BD2F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static HZZYFIUKWAB MCQXNVXGPYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2BD2D80", Offset = "0x2BD1780", VA = "0x182BD2D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2E60", Offset = "0x2BD1860", VA = "0x182BD2E60")]
		public static ZGFIKLGOGCU WQOOMKEGKIM([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2DD0", Offset = "0x2BD17D0", VA = "0x182BD2DD0")]
		public static ZGFIKLGOGCU UIELGASEODE(IEnumerable<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2AA0", Offset = "0x2BD14A0", VA = "0x182BD2AA0")]
		public static ZGFIKLGOGCU MXKNGNLRNGW(IEnumerable<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2B30", Offset = "0x2BD1530", VA = "0x182BD2B30")]
		public static ZGFIKLGOGCU MXKNGNLRNGW(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2750", Offset = "0x2BD1150", VA = "0x182BD2750")]
		public static ZGFIKLGOGCU BAFOGRIEVRB(IEnumerable<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BD28D0", Offset = "0x2BD12D0", VA = "0x182BD28D0")]
		public static HVOEPOZMOCF JGRRQOVVGEE(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ZGFIKLGOGCU : HZZYFIUKWAB, IEquatable<ZGFIKLGOGCU>, SCCEHWEFPHH<ZGFIKLGOGCU>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DKHQXDBGZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, HZZYFIUKWAB> OFGFQCWJFCQ;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DKHQXDBGZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2BD4090", Offset = "0x2BD2A90", VA = "0x182BD4090")]
			internal HZZYFIUKWAB IAHBAFPFOVS(HZZYFIUKWAB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HZZYFIUKWAB AOGIBRUGQDM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override HZZYFIUKWAB XUVSPWCGWPP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<HZZYFIUKWAB> UCKWGRCKNGF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool UCSDUZMHEXG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2BDE3D0", Offset = "0x2BDCDD0", VA = "0x182BDE3D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE5C0", Offset = "0x2BDCFC0", VA = "0x182BDE5C0", Slot = "9")]
		public sealed override HZZYFIUKWAB VVCQMGXEHGO(IReadOnlyDictionary<string, HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE170", Offset = "0x2BDCB70", VA = "0x182BDE170", Slot = "11")]
		public sealed override void ICTXZCNZRES(Action<HZZYFIUKWAB> a, Action<HZZYFIUKWAB> b, Action<HZZYFIUKWAB> c, Action<HZZYFIUKWAB> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE880", Offset = "0x2BDD280", VA = "0x182BDE880")]
		private ZGFIKLGOGCU(HZZYFIUKWAB a, IEnumerable<HZZYFIUKWAB> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE4F0", Offset = "0x2BDCEF0", VA = "0x182BDE4F0")]
		public static ZGFIKLGOGCU New(HZZYFIUKWAB originalType, IEnumerable<HZZYFIUKWAB> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE580", Offset = "0x2BDCF80", VA = "0x182BDE580", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE6E0", Offset = "0x2BDD0E0", VA = "0x182BDE6E0", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE730", Offset = "0x2BDD130", VA = "0x182BDE730")]
		public bool XNDJLZYNOLK([In] ZGFIKLGOGCU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE100", Offset = "0x2BDCB00", VA = "0x182BDE100", Slot = "18")]
		public bool Equals(ZGFIKLGOGCU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE120", Offset = "0x2BDCB20", VA = "0x182BDE120", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE7D0", Offset = "0x2BDD1D0", VA = "0x182BDE7D0", Slot = "14")]
		protected override int ZQAAQMEZZPX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BDE570", Offset = "0x2BDCF70", VA = "0x182BDE570", Slot = "19")]
		private bool PKBPAKWJULX([In] ZGFIKLGOGCU other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class JODSFXKSHIT : HZZYFIUKWAB, IEquatable<JODSFXKSHIT>, SCCEHWEFPHH<JODSFXKSHIT>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6A60", Offset = "0x2BD5460", VA = "0x182BD6A60")]
		private JODSFXKSHIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6870", Offset = "0x2BD5270", VA = "0x182BD6870")]
		public static JODSFXKSHIT New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6970", Offset = "0x2BD5370", VA = "0x182BD6970", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BD68E0", Offset = "0x2BD52E0", VA = "0x182BD68E0", Slot = "15")]
		public sealed override string SFXAXROLCZM(IReadOnlyList<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6A20", Offset = "0x2BD5420", VA = "0x182BD6A20")]
		private static string XXYHSKVUFDC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2BD69D0", Offset = "0x2BD53D0", VA = "0x182BD69D0", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860")]
		public bool XNDJLZYNOLK([In] JODSFXKSHIT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xF90A50", Offset = "0xF8F450", VA = "0x180F90A50", Slot = "18")]
		public bool Equals(JODSFXKSHIT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6810", Offset = "0x2BD5210", VA = "0x182BD6810", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860", Slot = "19")]
		private bool JEKVNESTJWA([In] JODSFXKSHIT other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class MCLBYUYIMDC
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public HZZYFIUKWAB TNBOKMJBQOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<HZZYFIUKWAB, ZGFIKLGOGCU> YANQIJPQLBS;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2BD6490", Offset = "0x2BD4E90", VA = "0x182BD6490")]
			internal ZGFIKLGOGCU TAULUADPMMU(HZZYFIUKWAB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class JIXDBIORISE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public HZZYFIUKWAB TIPQDKPYNTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<HZZYFIUKWAB, ZGFIKLGOGCU> BVILBCMOOZO;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JIXDBIORISE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2BD6310", Offset = "0x2BD4D10", VA = "0x182BD6310")]
			internal ZGFIKLGOGCU OXQZRBFVDEI(HZZYFIUKWAB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9910", Offset = "0x2BD8310", VA = "0x182BD9910")]
		public static IEnumerable<RISVPEMNZVA> YEURUVPHYCQ(this RISVPEMNZVA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9B40", Offset = "0x2BD8540", VA = "0x182BD9B40")]
		private static IEnumerable<RISVPEMNZVA> ZIRESYCDBLA(this RISVPEMNZVA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8070", Offset = "0x2BD6A70", VA = "0x182BD8070")]
		public static (HZZYFIUKWAB, IReadOnlyList<HZZYFIUKWAB>, bool) PSGBHAOUMNS(this HZZYFIUKWAB a, [Optional] IReadOnlyList<HZZYFIUKWAB> b)
		{
			return default((HZZYFIUKWAB, IReadOnlyList<HZZYFIUKWAB>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7340", Offset = "0x2BD5D40", VA = "0x182BD7340")]
		public static TypeKind DDWMXOAAOTF(this HZZYFIUKWAB a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6CF0", Offset = "0x2BD56F0", VA = "0x182BD6CF0")]
		private static HZZYFIUKWAB ConvertClassesToIntersections(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7800", Offset = "0x2BD6200", VA = "0x182BD7800")]
		private static HZZYFIUKWAB DistributeUnionIntoIntersection(this ZGFIKLGOGCU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7370", Offset = "0x2BD5D70", VA = "0x182BD7370")]
		private static HZZYFIUKWAB DistributeIntersectionIntoIntersection(this ZGFIKLGOGCU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD76A0", Offset = "0x2BD60A0", VA = "0x182BD76A0")]
		private static HZZYFIUKWAB DistributeIntoIntersection(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7B30", Offset = "0x2BD6530", VA = "0x182BD7B30")]
		private static bool OtherIsAssignableToOther(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes, HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9170", Offset = "0x2BD7B70", VA = "0x182BD9170")]
		private static bool UnionIsAssignableToOther(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes, HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7CC0", Offset = "0x2BD66C0", VA = "0x182BD7CC0")]
		private static bool OtherIsAssignableToUnion(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes, HZZYFIUKWAB union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BD94A0", Offset = "0x2BD7EA0", VA = "0x182BD94A0")]
		private static bool UnionIsAssignableToUnion(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes, HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8F20", Offset = "0x2BD7920", VA = "0x182BD8F20")]
		public static HZZYFIUKWAB RemoveCommonTypesFromIntersectionDistribution(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8240", Offset = "0x2BD6C40", VA = "0x182BD8240")]
		public static HZZYFIUKWAB RemoveCommonTypesFromIntersectionDistributionInternal(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9050", Offset = "0x2BD7A50", VA = "0x182BD9050")]
		public static HZZYFIUKWAB SimplifyIntersectionUnion(this HZZYFIUKWAB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9120", Offset = "0x2BD7B20", VA = "0x182BD9120")]
		public static IEnumerable<HZZYFIUKWAB> UCKWGRCKNGF(this HZZYFIUKWAB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6C60", Offset = "0x2BD5660", VA = "0x182BD6C60")]
		public static IEnumerable<HZZYFIUKWAB> BRELAITUYZY(this HZZYFIUKWAB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class RISVPEMNZVA : JJMHTRIRLSH, IEquatable<RISVPEMNZVA>, SCCEHWEFPHH<RISVPEMNZVA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class HRLLJQTJTYV : IEnumerable<RISVPEMNZVA>, IEnumerable, IEnumerator<RISVPEMNZVA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private RISVPEMNZVA RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public RISVPEMNZVA TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<RISVPEMNZVA> IRFNBWFCZWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private RISVPEMNZVA OGXIVMOHYDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<RISVPEMNZVA> IQUZHIRIGZW;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private RISVPEMNZVA JXFYGJPJQPP
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public HRLLJQTJTYV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BD5070", Offset = "0x2BD3A70", VA = "0x182BD5070", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2BD5200", Offset = "0x2BD3C00", VA = "0x182BD5200", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2BD5660", Offset = "0x2BD4060", VA = "0x182BD5660")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2BD56B0", Offset = "0x2BD40B0", VA = "0x182BD56B0")]
			private void XNORPFATVNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2BD51C0", Offset = "0x2BD3BC0", VA = "0x182BD51C0", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2BD55C0", Offset = "0x2BD3FC0", VA = "0x182BD55C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<RISVPEMNZVA> UJQIEVJYAFY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2BD55C0", Offset = "0x2BD3FC0", VA = "0x182BD55C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> ZHKSWMZBBWC;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, RISVPEMNZVA> QRFULYNNJGH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, RISVPEMNZVA> UENTXEPHUMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2BDB4B0", Offset = "0x2BD9EB0", VA = "0x182BDB4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? EBNDKVCMCCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid JQHSIUZOJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xF870D0", Offset = "0xF85AD0", VA = "0x180F870D0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xF87A10", Offset = "0xF86410", VA = "0x180F87A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xD15950", Offset = "0xD14350", VA = "0x180D15950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<RISVPEMNZVA> STKDNHWBWGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<RISVPEMNZVA> TUSYTBWLQMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2BDB5D0", Offset = "0x2BD9FD0", VA = "0x182BDB5D0")]
			[IteratorStateMachine(typeof(HRLLJQTJTYV))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> DYRCPOILMYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD141E0", Offset = "0xD12BE0", VA = "0x180D141E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, HFMUXQKNYLM> TRWQSVTJDSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xD14480", Offset = "0xD12E80", VA = "0x180D14480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD141C0", Offset = "0xD12BC0", VA = "0x180D141C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBCA0", Offset = "0x2BDA6A0", VA = "0x182BDBCA0")]
		public RISVPEMNZVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBD00", Offset = "0x2BDA700", VA = "0x182BDBD00")]
		public RISVPEMNZVA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAF80", Offset = "0x2BD9980", VA = "0x182BDAF80")]
		public static RISVPEMNZVA FNYQGBMVDLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB7E0", Offset = "0x2BDA1E0", VA = "0x182BDB7E0")]
		public static RISVPEMNZVA TCVEUWIEFGT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB2B0", Offset = "0x2BD9CB0", VA = "0x182BDB2B0")]
		public void Initialize(RISVPEMNZVA from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBDB0", Offset = "0x2BDA7B0", VA = "0x182BDBDB0")]
		private RISVPEMNZVA([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<HVOEPOZMOCF> c, [Optional] IEnumerable<RISVPEMNZVA> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, HFMUXQKNYLM>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB500", Offset = "0x2BD9F00", VA = "0x182BDB500")]
		public static RISVPEMNZVA New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<HVOEPOZMOCF> typeParameters, [Optional] IEnumerable<RISVPEMNZVA> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, HFMUXQKNYLM>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB830", Offset = "0x2BDA230", VA = "0x182BDB830", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAEB0", Offset = "0x2BD98B0", VA = "0x182BDAEB0")]
		private string ELSSLOTCLFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB650", Offset = "0x2BDA050", VA = "0x182BDB650")]
		private static string OVNBLDGGOVM(IEnumerable<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAFD0", Offset = "0x2BD99D0", VA = "0x182BDAFD0")]
		private string GGESVYJOGEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BDABE0", Offset = "0x2BD95E0", VA = "0x182BDABE0")]
		private string BAHSJBCGGCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB710", Offset = "0x2BDA110", VA = "0x182BDB710", Slot = "15")]
		public sealed override string SFXAXROLCZM(IReadOnlyList<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB920", Offset = "0x2BDA320", VA = "0x182BDB920", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB970", Offset = "0x2BDA370", VA = "0x182BDB970")]
		public bool XNDJLZYNOLK([In] RISVPEMNZVA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAF60", Offset = "0x2BD9960", VA = "0x182BDAF60", Slot = "18")]
		public bool Equals(RISVPEMNZVA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAF10", Offset = "0x2BD9910", VA = "0x182BDAF10", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBAA0", Offset = "0x2BDA4A0", VA = "0x182BDBAA0", Slot = "14")]
		protected override int ZQAAQMEZZPX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BDBA90", Offset = "0x2BDA490", VA = "0x182BDBA90", Slot = "19")]
		private bool ZKSOHINMBCZ([In] RISVPEMNZVA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class WQAPYOINAIL
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<HZZYFIUKWAB> NYEAHBRSQPQ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<RISVPEMNZVA> VLDVJZTEMTN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, HVOEPOZMOCF> CCHQUCRRRHU;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> FUEXAJAIKWK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, HFMUXQKNYLM> IUBFENQVBCT;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class NDRJMIYBWSS : IEquatable<NDRJMIYBWSS>, SCCEHWEFPHH<NDRJMIYBWSS>, ENOPHJTKITG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public HZZYFIUKWAB AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		private NDRJMIYBWSS(HZZYFIUKWAB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA270", Offset = "0x2BD8C70", VA = "0x182BDA270")]
		public static NDRJMIYBWSS New(HZZYFIUKWAB type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B92AA0", Offset = "0x2B914A0", VA = "0x182B92AA0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD44E0", Offset = "0x2BD2EE0", VA = "0x182BD44E0")]
		public bool XNDJLZYNOLK([In] NDRJMIYBWSS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4490", Offset = "0x2BD2E90", VA = "0x182BD4490", Slot = "4")]
		public bool Equals(NDRJMIYBWSS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA220", Offset = "0x2BD8C20", VA = "0x182BDA220", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC440", Offset = "0x2BAAE40", VA = "0x182BAC440", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4410", Offset = "0x2BD2E10", VA = "0x182BD4410", Slot = "6")]
		public int ANNERUPBDRX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD44E0", Offset = "0x2BD2EE0", VA = "0x182BD44E0", Slot = "5")]
		private bool RRWFEZBSLMV([In] NDRJMIYBWSS other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class GMJLOQQZLGT : IEquatable<GMJLOQQZLGT>, SCCEHWEFPHH<GMJLOQQZLGT>, ENOPHJTKITG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public HZZYFIUKWAB AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		private GMJLOQQZLGT(HZZYFIUKWAB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4530", Offset = "0x2BD2F30", VA = "0x182BD4530")]
		public static GMJLOQQZLGT New(HZZYFIUKWAB type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B92AA0", Offset = "0x2B914A0", VA = "0x182B92AA0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BD44E0", Offset = "0x2BD2EE0", VA = "0x182BD44E0")]
		public bool XNDJLZYNOLK([In] GMJLOQQZLGT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4490", Offset = "0x2BD2E90", VA = "0x182BD4490", Slot = "4")]
		public bool Equals(GMJLOQQZLGT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4440", Offset = "0x2BD2E40", VA = "0x182BD4440", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC440", Offset = "0x2BAAE40", VA = "0x182BAC440", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4410", Offset = "0x2BD2E10", VA = "0x182BD4410", Slot = "6")]
		public int ANNERUPBDRX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BD44E0", Offset = "0x2BD2EE0", VA = "0x182BD44E0", Slot = "5")]
		private bool GIDZFWCPJSK([In] GMJLOQQZLGT other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HFMUXQKNYLM : JJMHTRIRLSH, IEquatable<HFMUXQKNYLM>, SCCEHWEFPHH<HFMUXQKNYLM>, ENOPHJTKITG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, NDRJMIYBWSS>> AHNQPCHOHYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, GMJLOQQZLGT>> WJRAALCBJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4F80", Offset = "0x2BD3980", VA = "0x182BD4F80")]
		private HFMUXQKNYLM(IEnumerable<HVOEPOZMOCF> a, IEnumerable<KeyValuePair<string, NDRJMIYBWSS>> b, IEnumerable<KeyValuePair<string, GMJLOQQZLGT>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4910", Offset = "0x2BD3310", VA = "0x182BD4910")]
		public static HFMUXQKNYLM New(IEnumerable<HVOEPOZMOCF> typeParameters, IEnumerable<KeyValuePair<string, NDRJMIYBWSS>> inputs, IEnumerable<KeyValuePair<string, GMJLOQQZLGT>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4A60", Offset = "0x2BD3460", VA = "0x182BD4A60", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4A40", Offset = "0x2BD3440", VA = "0x182BD4A40", Slot = "15")]
		public sealed override string SFXAXROLCZM(IReadOnlyList<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4590", Offset = "0x2BD2F90", VA = "0x182BD4590")]
		private string ANQIEYUBJWH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4710", Offset = "0x2BD3110", VA = "0x182BD4710")]
		private string DPJGSRIBCDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4D70", Offset = "0x2BD3770", VA = "0x182BD4D70", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4DC0", Offset = "0x2BD37C0", VA = "0x182BD4DC0")]
		public bool XNDJLZYNOLK([In] HFMUXQKNYLM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4890", Offset = "0x2BD3290", VA = "0x182BD4890", Slot = "18")]
		public bool Equals(HFMUXQKNYLM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD48B0", Offset = "0x2BD32B0", VA = "0x182BD48B0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4EA0", Offset = "0x2BD38A0", VA = "0x182BD4EA0", Slot = "14")]
		protected sealed override int ZQAAQMEZZPX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4900", Offset = "0x2BD3300", VA = "0x182BD4900", Slot = "19")]
		private bool GJGASQIZXKT([In] HFMUXQKNYLM other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class PJBBKEHBHQX : HZZYFIUKWAB, IEquatable<PJBBKEHBHQX>, SCCEHWEFPHH<PJBBKEHBHQX>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA5A0", Offset = "0x2BD8FA0", VA = "0x182BDA5A0")]
		private PJBBKEHBHQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA3C0", Offset = "0x2BD8DC0", VA = "0x182BDA3C0")]
		public static PJBBKEHBHQX New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA520", Offset = "0x2BD8F20", VA = "0x182BDA520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA430", Offset = "0x2BD8E30", VA = "0x182BDA430", Slot = "15")]
		public override string SFXAXROLCZM(IReadOnlyList<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA2D0", Offset = "0x2BD8CD0", VA = "0x182BDA2D0", Slot = "16")]
		public override int CGCBGEQSIER(IReadOnlyList<HZZYFIUKWAB> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA370", Offset = "0x2BD8D70", VA = "0x182BDA370", Slot = "17")]
		public override bool GOPLVLUYDPS(IReadOnlyList<HZZYFIUKWAB> a, IReadOnlyList<HZZYFIUKWAB> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA550", Offset = "0x2BD8F50", VA = "0x182BDA550", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860")]
		public bool XNDJLZYNOLK([In] PJBBKEHBHQX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xF90A50", Offset = "0xF8F450", VA = "0x180F90A50", Slot = "18")]
		public bool Equals(PJBBKEHBHQX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA320", Offset = "0x2BD8D20", VA = "0x182BDA320", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860", Slot = "19")]
		private bool XIOWUXIFTSS([In] PJBBKEHBHQX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, SCCEHWEFPHH<Property>, ENOPHJTKITG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool BCVNXQKMWUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int PNVOKEEQUDP;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public HZZYFIUKWAB AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool PIGWOAHRTDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool SSQZNGIMSTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x128F670", Offset = "0x128E070", VA = "0x18128F670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAB80", Offset = "0x2BD9580", VA = "0x182BDAB80")]
		private Property(HZZYFIUKWAB type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA7B0", Offset = "0x2BD91B0", VA = "0x182BDA7B0")]
		public static Property New(HZZYFIUKWAB type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA8A0", Offset = "0x2BD92A0", VA = "0x182BDA8A0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA850", Offset = "0x2BD9250", VA = "0x182BDA850")]
		private string PFRUPEBZQBY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAA80", Offset = "0x2BD9480", VA = "0x182BDAA80")]
		private string YWFYDOSPLJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA980", Offset = "0x2BD9380", VA = "0x182BDA980")]
		public bool XNDJLZYNOLK([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA6D0", Offset = "0x2BD90D0", VA = "0x182BDA6D0", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA680", Offset = "0x2BD9080", VA = "0x182BDA680", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA6F0", Offset = "0x2BD90F0", VA = "0x182BDA6F0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAAD0", Offset = "0x2BD94D0", VA = "0x182BDAAD0")]
		private int ZQAAQMEZZPX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA5C0", Offset = "0x2BD8FC0", VA = "0x182BDA5C0", Slot = "6")]
		public int ANNERUPBDRX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA840", Offset = "0x2BD9240", VA = "0x182BDA840", Slot = "5")]
		private bool PDMIUCOHOAC([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class KEEYZUUYCZO : HZZYFIUKWAB, IEquatable<KEEYZUUYCZO>, SCCEHWEFPHH<KEEYZUUYCZO>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6C40", Offset = "0x2BD5640", VA = "0x182BD6C40")]
		private KEEYZUUYCZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6AD0", Offset = "0x2BD54D0", VA = "0x182BD6AD0")]
		public static KEEYZUUYCZO New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6BC0", Offset = "0x2BD55C0", VA = "0x182BD6BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6B40", Offset = "0x2BD5540", VA = "0x182BD6B40", Slot = "15")]
		public override string SFXAXROLCZM(IReadOnlyList<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6BF0", Offset = "0x2BD55F0", VA = "0x182BD6BF0", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860")]
		public bool XNDJLZYNOLK([In] KEEYZUUYCZO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF90A50", Offset = "0xF8F450", VA = "0x180F90A50", Slot = "18")]
		public bool Equals(KEEYZUUYCZO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6A80", Offset = "0x2BD5480", VA = "0x182BD6A80", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860", Slot = "19")]
		private bool SNBUVDWEWBJ([In] KEEYZUUYCZO other)
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
	public sealed class MFIZUZZVIUW : HZZYFIUKWAB, IEquatable<MFIZUZZVIUW>, SCCEHWEFPHH<MFIZUZZVIUW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool UCSDUZMHEXG
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9D00", Offset = "0x2BD8700", VA = "0x182BD9D00", Slot = "9")]
		public sealed override HZZYFIUKWAB VVCQMGXEHGO(IReadOnlyDictionary<string, HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C50", Offset = "0x2BD8650", VA = "0x182BD9C50", Slot = "11")]
		public sealed override void ICTXZCNZRES(Action<HZZYFIUKWAB> a, Action<HZZYFIUKWAB> b, Action<HZZYFIUKWAB> c, Action<HZZYFIUKWAB> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9E60", Offset = "0x2BD8860", VA = "0x182BD9E60")]
		private MFIZUZZVIUW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C80", Offset = "0x2BD8680", VA = "0x182BD9C80")]
		public static MFIZUZZVIUW New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9DF0", Offset = "0x2BD87F0", VA = "0x182BD9DF0", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860")]
		public bool XNDJLZYNOLK([In] MFIZUZZVIUW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xF90A50", Offset = "0xF8F450", VA = "0x180F90A50", Slot = "18")]
		public bool Equals(MFIZUZZVIUW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C00", Offset = "0x2BD8600", VA = "0x182BD9C00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9E40", Offset = "0x2BD8840", VA = "0x182BD9E40", Slot = "14")]
		protected sealed override int ZQAAQMEZZPX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860", Slot = "19")]
		private bool AWEAVNAIMSD([In] MFIZUZZVIUW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class JJMHTRIRLSH : HZZYFIUKWAB
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<HVOEPOZMOCF> ALGSAYOJAXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6610", Offset = "0x2BD5010", VA = "0x182BD6610")]
		public void Initialize(JJMHTRIRLSH from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2BD67A0", Offset = "0x2BD51A0", VA = "0x182BD67A0")]
		protected JJMHTRIRLSH(IEnumerable<HVOEPOZMOCF> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool XNDJLZYNOLK([In] HZZYFIUKWAB other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD66C0", Offset = "0x2BD50C0", VA = "0x182BD66C0")]
		protected bool XNDJLZYNOLK([In] JJMHTRIRLSH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6720", Offset = "0x2BD5120", VA = "0x182BD6720", Slot = "14")]
		protected override int ZQAAQMEZZPX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6640", Offset = "0x2BD5040", VA = "0x182BD6640")]
		protected int LOHOCBOOAZV(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class HVOEPOZMOCF : HZZYFIUKWAB, IEquatable<HVOEPOZMOCF>, SCCEHWEFPHH<HVOEPOZMOCF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public HZZYFIUKWAB EIATCTDNWVT
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5AC0", Offset = "0x2BD44C0", VA = "0x182BD5AC0")]
		private HVOEPOZMOCF(string a, [Optional] HZZYFIUKWAB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5810", Offset = "0x2BD4210", VA = "0x182BD5810")]
		public static HVOEPOZMOCF New(string name, [Optional] HZZYFIUKWAB constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5910", Offset = "0x2BD4310", VA = "0x182BD5910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BD59A0", Offset = "0x2BD43A0", VA = "0x182BD59A0", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BD59F0", Offset = "0x2BD43F0", VA = "0x182BD59F0")]
		public bool XNDJLZYNOLK([In] HVOEPOZMOCF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5770", Offset = "0x2BD4170", VA = "0x182BD5770", Slot = "18")]
		public bool Equals(HVOEPOZMOCF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BD57C0", Offset = "0x2BD41C0", VA = "0x182BD57C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5A40", Offset = "0x2BD4440", VA = "0x182BD5A40", Slot = "14")]
		protected override int ZQAAQMEZZPX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5700", Offset = "0x2BD4100", VA = "0x182BD5700", Slot = "13")]
		public override int ANNERUPBDRX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD59F0", Offset = "0x2BD43F0", VA = "0x182BD59F0", Slot = "19")]
		private bool ZYVTSXXGDXI([In] HVOEPOZMOCF other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class MKQZABVTEFT : HZZYFIUKWAB, IEquatable<MKQZABVTEFT>, SCCEHWEFPHH<MKQZABVTEFT>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA170", Offset = "0x2BD8B70", VA = "0x182BDA170")]
		private MKQZABVTEFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9F90", Offset = "0x2BD8990", VA = "0x182BD9F90")]
		public static MKQZABVTEFT New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA0F0", Offset = "0x2BD8AF0", VA = "0x182BDA0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA000", Offset = "0x2BD8A00", VA = "0x182BDA000", Slot = "15")]
		public override string SFXAXROLCZM(IReadOnlyList<HZZYFIUKWAB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9EA0", Offset = "0x2BD88A0", VA = "0x182BD9EA0", Slot = "16")]
		public override int CGCBGEQSIER(IReadOnlyList<HZZYFIUKWAB> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9F40", Offset = "0x2BD8940", VA = "0x182BD9F40", Slot = "17")]
		public override bool GOPLVLUYDPS(IReadOnlyList<HZZYFIUKWAB> a, IReadOnlyList<HZZYFIUKWAB> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA120", Offset = "0x2BD8B20", VA = "0x182BDA120", Slot = "12")]
		public override bool XNDJLZYNOLK([In] HZZYFIUKWAB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860")]
		public bool XNDJLZYNOLK([In] MKQZABVTEFT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xF90A50", Offset = "0xF8F450", VA = "0x180F90A50", Slot = "18")]
		public bool Equals(MKQZABVTEFT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9EF0", Offset = "0x2BD88F0", VA = "0x182BD9EF0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6860", Offset = "0x2BD5260", VA = "0x182BD6860", Slot = "19")]
		private bool WGFCJNCVRKG([In] MKQZABVTEFT other)
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
			public readonly HZZYFIUKWAB CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			internal Impl(HZZYFIUKWAB circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2BD36C0", Offset = "0x2BD20C0", VA = "0x182BD36C0")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3550", Offset = "0x2BD1F50", VA = "0x182BD3550")]
		public static CircuitTypeOrString UACGLLSIADX(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BD35C0", Offset = "0x2BD1FC0", VA = "0x182BD35C0")]
		public static CircuitTypeOrString UACGLLSIADX(HZZYFIUKWAB a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3620", Offset = "0x2BD2020", VA = "0x182BD3620")]
		public HZZYFIUKWAB VDYJTTYIWDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3420", Offset = "0x2BD1E20", VA = "0x182BD3420")]
		public static HZZYFIUKWAB[] BHFPWUKGUCX(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly GJUARQQLVOA _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		private ClassFactoryBaseClasses(GJUARQQLVOA data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x111A6A0", Offset = "0x11190A0", VA = "0x18111A6A0")]
		public static ClassFactoryBaseClasses New(GJUARQQLVOA data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3740", Offset = "0x2BD2140", VA = "0x182BD3740")]
		public ClassFactoryBaseClasses HJUYUIPHELU(RISVPEMNZVA a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x18A66D0", Offset = "0x18A50D0", VA = "0x1818A66D0")]
		public ClassFactoryProps ENSZFZFYWDD()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3800", Offset = "0x2BD2200", VA = "0x182BD3800")]
		public ClassFactoryProps YMJVNVNQYGO(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BD36F0", Offset = "0x2BD20F0", VA = "0x182BD36F0")]
		public RISVPEMNZVA FHFBFMADOYL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class GJUARQQLVOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? JQHSIUZOJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string EDJPGUEQTOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<HVOEPOZMOCF> ALGSAYOJAXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<RISVPEMNZVA> STKDNHWBWGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> DYRCPOILMYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, HFMUXQKNYLM>> TRWQSVTJDSL;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4280", Offset = "0x2BD2C80", VA = "0x182BD4280")]
		private GJUARQQLVOA([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BD40D0", Offset = "0x2BD2AD0", VA = "0x182BD40D0")]
		public static GJUARQQLVOA New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly GJUARQQLVOA _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		private ClassFactoryFuncs(GJUARQQLVOA data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x111A6A0", Offset = "0x11190A0", VA = "0x18111A6A0")]
		public static ClassFactoryFuncs New(GJUARQQLVOA data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3860", Offset = "0x2BD2260", VA = "0x182BD3860")]
		public RISVPEMNZVA FHFBFMADOYL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly GJUARQQLVOA _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		public ClassFactoryProps(GJUARQQLVOA data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BD39F0", Offset = "0x2BD23F0", VA = "0x182BD39F0")]
		public ClassFactoryProps YMJVNVNQYGO(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x18A66D0", Offset = "0x18A50D0", VA = "0x1818A66D0")]
		public ClassFactoryFuncs KGTQVDQELTK()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD39B0", Offset = "0x2BD23B0", VA = "0x182BD39B0")]
		public RISVPEMNZVA FHFBFMADOYL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly GJUARQQLVOA _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		private ClassFactoryTypeParams(GJUARQQLVOA data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3EC0", Offset = "0x2BD28C0", VA = "0x182BD3EC0")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3C20", Offset = "0x2BD2620", VA = "0x182BD3C20")]
		public ClassFactoryTypeParams JGRRQOVVGEE(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x18A66D0", Offset = "0x18A50D0", VA = "0x1818A66D0")]
		public ClassFactoryBaseClasses QXCPPVPBCDO()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3BE0", Offset = "0x2BD25E0", VA = "0x182BD3BE0")]
		public ClassFactoryBaseClasses HJUYUIPHELU(RISVPEMNZVA a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3B80", Offset = "0x2BD2580", VA = "0x182BD3B80")]
		public RISVPEMNZVA FHFBFMADOYL()
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
