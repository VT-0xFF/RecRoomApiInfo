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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class QUZNMKSIOOE : IEquatable<QUZNMKSIOOE>, MJOFOHUMYGG<QUZNMKSIOOE>, GDPEXLFGKHZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool MBDJOALVFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DMIRXMUNCBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int ZFZMXDJJQPI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind DAPXUDJAJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? GACVFCDTUKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2BDA8C0", Offset = "0x2BD92C0", VA = "0x182BDA8C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual QUZNMKSIOOE IKPPFZGBHIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE33C70", VA = "0x180E35270", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool KVVZETYHCQP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAD80", Offset = "0x2BD9780", VA = "0x182BDAD80")]
		public static void RKCBVVMJUOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
		protected QUZNMKSIOOE(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDACC0", Offset = "0x2BD96C0", VA = "0x182BDACC0")]
		public static QUZNMKSIOOE New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE33C70", VA = "0x180E35270")]
		protected static a MZFUDIQFXQQ<a>(a a) where a : QUZNMKSIOOE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE33C70", VA = "0x180E35270", Slot = "9")]
		public virtual QUZNMKSIOOE QFZSHGGMNUD(IReadOnlyDictionary<string, QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA9C0", Offset = "0x2BD93C0", VA = "0x182BDA9C0", Slot = "11")]
		public virtual void EMNEZFPJTXD(Action<QUZNMKSIOOE> a, Action<QUZNMKSIOOE> b, Action<QUZNMKSIOOE> c, Action<QUZNMKSIOOE> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAE10", Offset = "0x2BD9810", VA = "0x182BDAE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA820", Offset = "0x2BD9220", VA = "0x182BDA820", Slot = "12")]
		public virtual bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA9F0", Offset = "0x2BD93F0", VA = "0x182BDA9F0", Slot = "4")]
		public bool Equals(QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAA20", Offset = "0x2BD9420", VA = "0x182BDAA20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAC80", Offset = "0x2BD9680", VA = "0x182BDAC80")]
		public static bool ITVTPRNZGNV(QUZNMKSIOOE a, QUZNMKSIOOE b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA930", Offset = "0x2BD9330", VA = "0x182BDA930")]
		public static bool CYAUITUETAA(QUZNMKSIOOE a, QUZNMKSIOOE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAA70", Offset = "0x2BD9470", VA = "0x182BDAA70", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAF80", Offset = "0x2BD9980", VA = "0x182BDAF80", Slot = "13")]
		public virtual int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAF80", Offset = "0x2BD9980", VA = "0x182BDAF80", Slot = "14")]
		protected virtual int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3BF68E0", Offset = "0x3BF52E0", VA = "0x183BF68E0")]
		public b GEVWTHIZUGG<b>() where b : QUZNMKSIOOE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2620", Offset = "0x2BD1020", VA = "0x182BD2620", Slot = "15")]
		public virtual string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA970", Offset = "0x2BD9370", VA = "0x182BDA970", Slot = "16")]
		public virtual int DLTUNUIPIVM(IReadOnlyList<QUZNMKSIOOE> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAD30", Offset = "0x2BD9730", VA = "0x182BDAD30", Slot = "17")]
		public virtual bool PJHTFAMIMXB(IReadOnlyList<QUZNMKSIOOE> a, IReadOnlyList<QUZNMKSIOOE> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAB20", Offset = "0x2BD9520", VA = "0x182BDAB20")]
		public HKXMWIVRURF IEMRQDZXUFL(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAC70", Offset = "0x2BD9670", VA = "0x182BDAC70")]
		public HKXMWIVRURF IEMRQDZXUFL(params QUZNMKSIOOE[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDAC70", Offset = "0x2BD9670", VA = "0x182BDAC70")]
		public HKXMWIVRURF IEMRQDZXUFL(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface EXOUKTTMMZJ<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a QCRAXOWCMRD(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b YRAHWQNDRZF([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind SJKKSAKMTJT([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates BPXBUEXSJRC(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface GDPEXLFGKHZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int UVKSOXERWNG(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class UVKSOXERWNG
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class MSQXLDQVGPS<a> where a : GDPEXLFGKHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int MBZZYFSNQDP;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public MSQXLDQVGPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6FF8650", Offset = "0x6FF7050", VA = "0x186FF8650")]
			internal int XCGVWKVLLIZ(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ITTXRCVCEBE<a, b> where b : GDPEXLFGKHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int MBZZYFSNQDP;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public ITTXRCVCEBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x665E0F0", Offset = "0x665CAF0", VA = "0x18665E0F0")]
			internal int XCGVWKVLLIZ(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class ZAGAZIDTYHU<a> where a : GDPEXLFGKHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int MBZZYFSNQDP;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public ZAGAZIDTYHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5154590", Offset = "0x5152F90", VA = "0x185154590")]
			internal int QPQYXQMEQHY(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x40E1140", Offset = "0x40DFB40", VA = "0x1840E1140")]
		public static int TELKMLEDAQD<a>(this IEnumerable<a> a, int b = 0) where a : GDPEXLFGKHZ
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x40E1210", Offset = "0x40DFC10", VA = "0x1840E1210")]
		public static int TELKMLEDAQD<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : GDPEXLFGKHZ
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x40E1140", Offset = "0x40DFB40", VA = "0x1840E1140")]
		public static int QDFZOBTTONE<d>(this IEnumerable<d> a, int b = 0) where d : GDPEXLFGKHZ
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : EXOUKTTMMZJ<TDirectedType, QUZNMKSIOOE, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x53674E0", Offset = "0x5365EE0", VA = "0x1853674E0")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7DE5A00", Offset = "0x7DE4400", VA = "0x187DE5A00")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class CJHJLIDOHPY
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QHKJRYGJUVQ<a, b, c> where c : EXOUKTTMMZJ<a, QUZNMKSIOOE, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public QUZNMKSIOOE JJOAOSSQKPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<QUZNMKSIOOE> GMKYNRYIMUX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public QUZNMKSIOOE QUAOSXJXCFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<QUZNMKSIOOE> XYHDILZBWPM;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public QHKJRYGJUVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x772B220", Offset = "0x7729C20", VA = "0x18772B220")]
			internal bool YKHFZPBBIZG([In] TypeSys<a, b, c> self_, QUZNMKSIOOE a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x772B2B0", Offset = "0x7729CB0", VA = "0x18772B2B0")]
			internal bool YKXARJITLHH([In] TypeSys<a, b, c> self_, QUZNMKSIOOE a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x772B5B0", Offset = "0x7729FB0", VA = "0x18772B5B0")]
			internal bool YLCHOQCQUSQ([In] TypeSys<a, b, c> self_, QUZNMKSIOOE a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class YRWGTDCXCSR<a, b, c> where c : EXOUKTTMMZJ<a, QUZNMKSIOOE, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public QUZNMKSIOOE AEFNCPMWIYQ;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public YRWGTDCXCSR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x50FB5B0", Offset = "0x50F9FB0", VA = "0x1850FB5B0")]
			internal bool YLHOLWWOEDZ([In] TypeSys<a, b, c> self__, QUZNMKSIOOE a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class OMMTMWSMUYY<a, b, c> where c : EXOUKTTMMZJ<a, QUZNMKSIOOE, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b NEXPSVAOOPT;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public OMMTMWSMUYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x73BE730", Offset = "0x73BD130", VA = "0x1873BE730")]
			internal QUZNMKSIOOE SAXXKGTNEWL([In] TypeSys<a, b, c> self_, [In] b root_, QUZNMKSIOOE a, QUZNMKSIOOE b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class FFJNXXAWTKT<a, b, c> where c : EXOUKTTMMZJ<a, QUZNMKSIOOE, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public HLUORRWSTUX OTXLOQWDORW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HLUORRWSTUX WJIGXULECPN;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FFJNXXAWTKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x635C580", Offset = "0x635AF80", VA = "0x18635C580")]
			internal a SBDEHNNKOHU([In] TypeSys<a, b, c> self_, IOKind a, HLUORRWSTUX b, HLUORRWSTUX c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class UEBOPKGPTRQ<a, b, c> where c : EXOUKTTMMZJ<a, QUZNMKSIOOE, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<HLUORRWSTUX> RUXFOJKRBKH;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public UEBOPKGPTRQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7E24F40", Offset = "0x7E23940", VA = "0x187E24F40")]
			internal bool GVMDWTVJZXO(bool a, HLUORRWSTUX b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] GJYTPXRVYFZ;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x382D450", Offset = "0x382BE50", VA = "0x18382D450")]
		public static bool YAXTIIAIYSS<a, b, c>([In] this TypeSys<a, b, c> _, QUZNMKSIOOE a) where c : EXOUKTTMMZJ<a, QUZNMKSIOOE, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x382D290", Offset = "0x382BC90", VA = "0x18382D290")]
		public static bool WCKAMCRMAJN<d, e, f>([In] this TypeSys<d, e, f> _, QUZNMKSIOOE a) where f : EXOUKTTMMZJ<d, QUZNMKSIOOE, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x382D2B0", Offset = "0x382BCB0", VA = "0x18382D2B0")]
		public static bool WFKFCMVFMYZ<g, h, i>([In] this TypeSys<g, h, i> self, QUZNMKSIOOE a, QUZNMKSIOOE b) where i : EXOUKTTMMZJ<g, QUZNMKSIOOE, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x382B810", Offset = "0x382A210", VA = "0x18382B810")]
		private static bool MVVFIWBUXIY<j, k, l>([In] this TypeSys<j, k, l> self, QUZNMKSIOOE a, QUZNMKSIOOE b, IReadOnlyList<QUZNMKSIOOE> c, IReadOnlyList<QUZNMKSIOOE> d) where l : EXOUKTTMMZJ<j, QUZNMKSIOOE, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x38230E0", Offset = "0x3821AE0", VA = "0x1838230E0")]
		public static QUZNMKSIOOE EJXWZSOGUQW<m, n, o>([In] this TypeSys<m, n, o> self, n a, QUZNMKSIOOE b, QUZNMKSIOOE c) where o : EXOUKTTMMZJ<m, QUZNMKSIOOE, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3823430", Offset = "0x3821E30", VA = "0x183823430")]
		public static p EJXWZSOGUQW<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : EXOUKTTMMZJ<p, QUZNMKSIOOE, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x382CE90", Offset = "0x382B890", VA = "0x18382CE90")]
		private static List<w> NNPAJBICXNC<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : EXOUKTTMMZJ<t, QUZNMKSIOOE, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x382B670", Offset = "0x382A070", VA = "0x18382B670")]
		private static ba LZQNFWKGCUG<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class JPVBKBLQSDH
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static QUZNMKSIOOE SUZZIYUSVDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8FD0", Offset = "0x2BD79D0", VA = "0x182BD8FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static QUZNMKSIOOE DHITGJJTEFK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2BD89D0", Offset = "0x2BD73D0", VA = "0x182BD89D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static QUZNMKSIOOE RCTXLAFBAWL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9020", Offset = "0x2BD7A20", VA = "0x182BD9020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static QUZNMKSIOOE QAPGWLOCXWX
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8AC0", Offset = "0x2BD74C0", VA = "0x182BD8AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static QUZNMKSIOOE NSNZQDFVDLN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8A20", Offset = "0x2BD7420", VA = "0x182BD8A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static QUZNMKSIOOE ABECZOKNUII
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8D20", Offset = "0x2BD7720", VA = "0x182BD8D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static QUZNMKSIOOE JOTGRXAUZFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8A70", Offset = "0x2BD7470", VA = "0x182BD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static QUZNMKSIOOE IZHNBLYRWVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2BD8CD0", Offset = "0x2BD76D0", VA = "0x182BD8CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8B10", Offset = "0x2BD7510", VA = "0x182BD8B10")]
		public static HKXMWIVRURF GNCAOCWJVYL([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8D70", Offset = "0x2BD7770", VA = "0x182BD8D70")]
		public static HKXMWIVRURF UFRZYMVEBPZ(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8940", Offset = "0x2BD7340", VA = "0x182BD8940")]
		public static HKXMWIVRURF CUJTTFSJOLH(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8790", Offset = "0x2BD7190", VA = "0x182BD8790")]
		public static HKXMWIVRURF CUJTTFSJOLH(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8C40", Offset = "0x2BD7640", VA = "0x182BD8C40")]
		public static HKXMWIVRURF LPGPBLHSASU(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8E00", Offset = "0x2BD7800", VA = "0x182BD8E00")]
		public static FMJXCHWCMWA ULTUAHONXVJ(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class HKXMWIVRURF : QUZNMKSIOOE, IEquatable<HKXMWIVRURF>, MJOFOHUMYGG<HKXMWIVRURF>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class QNWEWNJMZCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, QUZNMKSIOOE> HGCMIJDCELX;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2BDA7E0", Offset = "0x2BD91E0", VA = "0x182BDA7E0")]
			internal QUZNMKSIOOE FNYAQJLGLQR(QUZNMKSIOOE a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public QUZNMKSIOOE YPJVHKNXTPF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override QUZNMKSIOOE IKPPFZGBHIS
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<QUZNMKSIOOE> QFJYATZVZMW
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool KVVZETYHCQP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2BD6B20", Offset = "0x2BD5520", VA = "0x182BD6B20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6A00", Offset = "0x2BD5400", VA = "0x182BD6A00", Slot = "9")]
		public sealed override QUZNMKSIOOE QFZSHGGMNUD(IReadOnlyDictionary<string, QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD66A0", Offset = "0x2BD50A0", VA = "0x182BD66A0", Slot = "11")]
		public sealed override void EMNEZFPJTXD(Action<QUZNMKSIOOE> a, Action<QUZNMKSIOOE> b, Action<QUZNMKSIOOE> c, Action<QUZNMKSIOOE> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6D30", Offset = "0x2BD5730", VA = "0x182BD6D30")]
		private HKXMWIVRURF(QUZNMKSIOOE a, IEnumerable<QUZNMKSIOOE> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6980", Offset = "0x2BD5380", VA = "0x182BD6980")]
		public static HKXMWIVRURF New(QUZNMKSIOOE originalType, IEnumerable<QUZNMKSIOOE> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6C40", Offset = "0x2BD5640", VA = "0x182BD6C40", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BD65B0", Offset = "0x2BD4FB0", VA = "0x182BD65B0", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6600", Offset = "0x2BD5000", VA = "0x182BD6600")]
		public bool ABAKIYLIPET([In] HKXMWIVRURF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6950", Offset = "0x2BD5350", VA = "0x182BD6950", Slot = "18")]
		public bool Equals(HKXMWIVRURF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6900", Offset = "0x2BD5300", VA = "0x182BD6900", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6C80", Offset = "0x2BD5680", VA = "0x182BD6C80", Slot = "14")]
		protected override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6970", Offset = "0x2BD5370", VA = "0x182BD6970", Slot = "19")]
		private bool FQMECSASLCK([In] HKXMWIVRURF other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class IPYTKMLDXMW : QUZNMKSIOOE, IEquatable<IPYTKMLDXMW>, MJOFOHUMYGG<IPYTKMLDXMW>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8770", Offset = "0x2BD7170", VA = "0x182BD8770")]
		private IPYTKMLDXMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8660", Offset = "0x2BD7060", VA = "0x182BD8660")]
		public static IPYTKMLDXMW New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8710", Offset = "0x2BD7110", VA = "0x182BD8710", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8580", Offset = "0x2BD6F80", VA = "0x182BD8580", Slot = "15")]
		public sealed override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2BD86D0", Offset = "0x2BD70D0", VA = "0x182BD86D0")]
		private static string QDQFCSHOMYD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8530", Offset = "0x2BD6F30", VA = "0x182BD8530", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280")]
		public bool ABAKIYLIPET([In] IPYTKMLDXMW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xF8B9E0", Offset = "0xF8A3E0", VA = "0x180F8B9E0", Slot = "18")]
		public bool Equals(IPYTKMLDXMW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8610", Offset = "0x2BD7010", VA = "0x182BD8610", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280", Slot = "19")]
		private bool UDKERWCIPVD([In] IPYTKMLDXMW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class FYQSCVWBVAP
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KRDFVZFEZPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public QUZNMKSIOOE NGLWSNYOWQF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<QUZNMKSIOOE, HKXMWIVRURF> ERVRTDQHCCT;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9D40", Offset = "0x2BD8740", VA = "0x182BD9D40")]
			internal HKXMWIVRURF IZJKSEHRERH(QUZNMKSIOOE a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class KRIMTFZCJAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public QUZNMKSIOOE VLDUBDEKWWH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<QUZNMKSIOOE, HKXMWIVRURF> FQNLYFEHVMJ;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public KRIMTFZCJAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9EC0", Offset = "0x2BD88C0", VA = "0x182BD9EC0")]
			internal HKXMWIVRURF SHZLCTHGUQT(QUZNMKSIOOE a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BD47C0", Offset = "0x2BD31C0", VA = "0x182BD47C0")]
		public static IEnumerable<HLUORRWSTUX> RSTMEIZRDJZ(this HLUORRWSTUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BD40E0", Offset = "0x2BD2AE0", VA = "0x182BD40E0")]
		private static IEnumerable<HLUORRWSTUX> LOYIJWHAUFX(this HLUORRWSTUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6070", Offset = "0x2BD4A70", VA = "0x182BD6070")]
		public static (QUZNMKSIOOE, IReadOnlyList<QUZNMKSIOOE>, bool) VAYNTXOONQH(this QUZNMKSIOOE a, [Optional] IReadOnlyList<QUZNMKSIOOE> b)
		{
			return default((QUZNMKSIOOE, IReadOnlyList<QUZNMKSIOOE>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6240", Offset = "0x2BD4C40", VA = "0x182BD6240")]
		public static TypeKind WPGJKAXNXGY(this QUZNMKSIOOE a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD32D0", Offset = "0x2BD1CD0", VA = "0x182BD32D0")]
		private static QUZNMKSIOOE ConvertClassesToIntersections(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3DB0", Offset = "0x2BD27B0", VA = "0x182BD3DB0")]
		private static QUZNMKSIOOE DistributeUnionIntoIntersection(this HKXMWIVRURF self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3920", Offset = "0x2BD2320", VA = "0x182BD3920")]
		private static QUZNMKSIOOE DistributeIntersectionIntoIntersection(this HKXMWIVRURF self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3C50", Offset = "0x2BD2650", VA = "0x182BD3C50")]
		private static QUZNMKSIOOE DistributeIntoIntersection(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2BD41A0", Offset = "0x2BD2BA0", VA = "0x182BD41A0")]
		private static bool OtherIsAssignableToOther(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes, QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BD58D0", Offset = "0x2BD42D0", VA = "0x182BD58D0")]
		private static bool UnionIsAssignableToOther(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes, QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4330", Offset = "0x2BD2D30", VA = "0x182BD4330")]
		private static bool OtherIsAssignableToUnion(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes, QUZNMKSIOOE union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5C00", Offset = "0x2BD4600", VA = "0x182BD5C00")]
		private static bool UnionIsAssignableToUnion(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes, QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BD56D0", Offset = "0x2BD40D0", VA = "0x182BD56D0")]
		public static QUZNMKSIOOE RemoveCommonTypesFromIntersectionDistribution(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2BD49F0", Offset = "0x2BD33F0", VA = "0x182BD49F0")]
		public static QUZNMKSIOOE RemoveCommonTypesFromIntersectionDistributionInternal(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5800", Offset = "0x2BD4200", VA = "0x182BD5800")]
		public static QUZNMKSIOOE SimplifyIntersectionUnion(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2BD46E0", Offset = "0x2BD30E0", VA = "0x182BD46E0")]
		public static IEnumerable<QUZNMKSIOOE> QFJYATZVZMW(this QUZNMKSIOOE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2BD4730", Offset = "0x2BD3130", VA = "0x182BD4730")]
		public static IEnumerable<QUZNMKSIOOE> QZORVUWEYCB(this QUZNMKSIOOE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class HLUORRWSTUX : JUOLMKMWPGQ, IEquatable<HLUORRWSTUX>, MJOFOHUMYGG<HLUORRWSTUX>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class JSMMREYGZBM : IEnumerable<HLUORRWSTUX>, IEnumerable, IEnumerator<HLUORRWSTUX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private HLUORRWSTUX OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public HLUORRWSTUX XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<HLUORRWSTUX> ULWCKXMDKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private HLUORRWSTUX COLNBGXMYPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<HLUORRWSTUX> ULLOQJYIRFJ;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private HLUORRWSTUX SNKJCECOVDA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
			[DebuggerHidden]
			public JSMMREYGZBM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9910", Offset = "0x2BD8310", VA = "0x182BD9910", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9550", Offset = "0x2BD7F50", VA = "0x182BD9550", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9AF0", Offset = "0x2BD84F0", VA = "0x182BD9AF0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9AA0", Offset = "0x2BD84A0", VA = "0x182BD9AA0")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2BD9A60", Offset = "0x2BD8460", VA = "0x182BD9A60", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2BD94B0", Offset = "0x2BD7EB0", VA = "0x182BD94B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HLUORRWSTUX> ETARUXQIBHL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2BD94B0", Offset = "0x2BD7EB0", VA = "0x182BD94B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> LNEHTJAXLUH;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, HLUORRWSTUX> RDRYSUIQOAE;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, HLUORRWSTUX> AUGIRISRNEY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2BD6F70", Offset = "0x2BD5970", VA = "0x182BD6F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? GACVFCDTUKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid CRWLHSKOIBS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xF92C90", Offset = "0xF91690", VA = "0x180F92C90")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xF931D0", Offset = "0xF91BD0", VA = "0x180F931D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<HLUORRWSTUX> NCBJZTAYVQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<HLUORRWSTUX> ICSQNZXPCOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2BD7D50", Offset = "0x2BD6750", VA = "0x182BD7D50")]
			[IteratorStateMachine(typeof(JSMMREYGZBM))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> TJFCEFCBDVK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, DKWNGFRJWFD> HTLRXUKVYHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7EC0", Offset = "0x2BD68C0", VA = "0x182BD7EC0")]
		public HLUORRWSTUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BD81D0", Offset = "0x2BD6BD0", VA = "0x182BD81D0")]
		public HLUORRWSTUX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7100", Offset = "0x2BD5B00", VA = "0x182BD7100")]
		public static HLUORRWSTUX HFSYOHOAITW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BD76F0", Offset = "0x2BD60F0", VA = "0x182BD76F0")]
		public static HLUORRWSTUX PEVRHZLFAZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7420", Offset = "0x2BD5E20", VA = "0x182BD7420")]
		public void Initialize(HLUORRWSTUX from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7F20", Offset = "0x2BD6920", VA = "0x182BD7F20")]
		private HLUORRWSTUX([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<FMJXCHWCMWA> c, [Optional] IEnumerable<HLUORRWSTUX> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, DKWNGFRJWFD>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7620", Offset = "0x2BD6020", VA = "0x182BD7620")]
		public static HLUORRWSTUX New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<FMJXCHWCMWA> typeParameters, [Optional] IEnumerable<HLUORRWSTUX> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, DKWNGFRJWFD>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7B40", Offset = "0x2BD6540", VA = "0x182BD7B40", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7740", Offset = "0x2BD6140", VA = "0x182BD7740")]
		private string PFOZOKVSTQQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BD77A0", Offset = "0x2BD61A0", VA = "0x182BD77A0")]
		private static string QAJBRBXFUWB(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7860", Offset = "0x2BD6260", VA = "0x182BD7860")]
		private string RGFQYISBGYM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7150", Offset = "0x2BD5B50", VA = "0x182BD7150")]
		private string HHJKKYJHIKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6FC0", Offset = "0x2BD59C0", VA = "0x182BD6FC0", Slot = "15")]
		public sealed override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6F20", Offset = "0x2BD5920", VA = "0x182BD6F20", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6E00", Offset = "0x2BD5800", VA = "0x182BD6E00")]
		public bool ABAKIYLIPET([In] HLUORRWSTUX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD70E0", Offset = "0x2BD5AE0", VA = "0x182BD70E0", Slot = "18")]
		public bool Equals(HLUORRWSTUX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7090", Offset = "0x2BD5A90", VA = "0x182BD7090", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7C30", Offset = "0x2BD6630", VA = "0x182BD7C30", Slot = "14")]
		protected override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BD7D40", Offset = "0x2BD6740", VA = "0x182BD7D40", Slot = "19")]
		private bool YUJPWGNCCGE([In] HLUORRWSTUX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class RLFBOHXBUXE
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<QUZNMKSIOOE> SFOSLGENCEZ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<HLUORRWSTUX> YRUCGDKYSAA;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, FMJXCHWCMWA> VHKFNWJOTUJ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> PXXUIWVZPAL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, DKWNGFRJWFD> EWKGCMRVHGK;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class NOXBFFLFFAX : IEquatable<NOXBFFLFFAX>, MJOFOHUMYGG<NOXBFFLFFAX>, GDPEXLFGKHZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public QUZNMKSIOOE YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		private NOXBFFLFFAX(QUZNMKSIOOE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA130", Offset = "0x2BD8B30", VA = "0x182BDA130")]
		public static NOXBFFLFFAX New(QUZNMKSIOOE type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B999E0", Offset = "0x2B983E0", VA = "0x182B999E0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA040", Offset = "0x2BD8A40", VA = "0x182BDA040")]
		public bool ABAKIYLIPET([In] NOXBFFLFFAX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA0E0", Offset = "0x2BD8AE0", VA = "0x182BDA0E0", Slot = "4")]
		public bool Equals(NOXBFFLFFAX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA090", Offset = "0x2BD8A90", VA = "0x182BDA090", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB2A0", Offset = "0x2BA9CA0", VA = "0x182BAB2A0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA190", Offset = "0x2BD8B90", VA = "0x182BDA190", Slot = "6")]
		public int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA040", Offset = "0x2BD8A40", VA = "0x182BDA040", Slot = "5")]
		private bool IBFBRFOFZYE([In] NOXBFFLFFAX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class YMQORHFWAXW : IEquatable<YMQORHFWAXW>, MJOFOHUMYGG<YMQORHFWAXW>, GDPEXLFGKHZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public QUZNMKSIOOE YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		private YMQORHFWAXW(QUZNMKSIOOE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD860", Offset = "0x2BDC260", VA = "0x182BDD860")]
		public static YMQORHFWAXW New(QUZNMKSIOOE type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B999E0", Offset = "0x2B983E0", VA = "0x182B999E0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA040", Offset = "0x2BD8A40", VA = "0x182BDA040")]
		public bool ABAKIYLIPET([In] YMQORHFWAXW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA0E0", Offset = "0x2BD8AE0", VA = "0x182BDA0E0", Slot = "4")]
		public bool Equals(YMQORHFWAXW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD810", Offset = "0x2BDC210", VA = "0x182BDD810", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB2A0", Offset = "0x2BA9CA0", VA = "0x182BAB2A0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA190", Offset = "0x2BD8B90", VA = "0x182BDA190", Slot = "6")]
		public int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA040", Offset = "0x2BD8A40", VA = "0x182BDA040", Slot = "5")]
		private bool KWYKSUZADSF([In] YMQORHFWAXW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DKWNGFRJWFD : JUOLMKMWPGQ, IEquatable<DKWNGFRJWFD>, MJOFOHUMYGG<DKWNGFRJWFD>, GDPEXLFGKHZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, NOXBFFLFFAX>> DATGAKDCFWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, YMQORHFWAXW>> RQRLHTQNUCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2D60", Offset = "0x2BD1760", VA = "0x182BD2D60")]
		private DKWNGFRJWFD(IEnumerable<FMJXCHWCMWA> a, IEnumerable<KeyValuePair<string, NOXBFFLFFAX>> b, IEnumerable<KeyValuePair<string, YMQORHFWAXW>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BD26C0", Offset = "0x2BD10C0", VA = "0x182BD26C0")]
		public static DKWNGFRJWFD New(IEnumerable<FMJXCHWCMWA> typeParameters, IEnumerable<KeyValuePair<string, NOXBFFLFFAX>> inputs, IEnumerable<KeyValuePair<string, YMQORHFWAXW>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BD27F0", Offset = "0x2BD11F0", VA = "0x182BD27F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2620", Offset = "0x2BD1020", VA = "0x182BD2620", Slot = "15")]
		public sealed override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BD24A0", Offset = "0x2BD0EA0", VA = "0x182BD24A0")]
		private string BBQZKPQQWWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2BE0", Offset = "0x2BD15E0", VA = "0x182BD2BE0")]
		private string UOVMFRBZFWJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2370", Offset = "0x2BD0D70", VA = "0x182BD2370", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD23C0", Offset = "0x2BD0DC0", VA = "0x182BD23C0")]
		public bool ABAKIYLIPET([In] DKWNGFRJWFD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2690", Offset = "0x2BD1090", VA = "0x182BD2690", Slot = "18")]
		public bool Equals(DKWNGFRJWFD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2640", Offset = "0x2BD1040", VA = "0x182BD2640", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2B00", Offset = "0x2BD1500", VA = "0x182BD2B00", Slot = "14")]
		protected sealed override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BD26B0", Offset = "0x2BD10B0", VA = "0x182BD26B0", Slot = "19")]
		private bool FFHTIOTVWHW([In] DKWNGFRJWFD other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UWGHXCGSUSY : QUZNMKSIOOE, IEquatable<UWGHXCGSUSY>, MJOFOHUMYGG<UWGHXCGSUSY>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD320", Offset = "0x2BDBD20", VA = "0x182BDD320")]
		private UWGHXCGSUSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD230", Offset = "0x2BDBC30", VA = "0x182BDD230")]
		public static UWGHXCGSUSY New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD2F0", Offset = "0x2BDBCF0", VA = "0x182BDD2F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD0F0", Offset = "0x2BDBAF0", VA = "0x182BDD0F0", Slot = "15")]
		public override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD0A0", Offset = "0x2BDBAA0", VA = "0x182BDD0A0", Slot = "16")]
		public override int DLTUNUIPIVM(IReadOnlyList<QUZNMKSIOOE> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD2A0", Offset = "0x2BDBCA0", VA = "0x182BDD2A0", Slot = "17")]
		public override bool PJHTFAMIMXB(IReadOnlyList<QUZNMKSIOOE> a, IReadOnlyList<QUZNMKSIOOE> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD050", Offset = "0x2BDBA50", VA = "0x182BDD050", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280")]
		public bool ABAKIYLIPET([In] UWGHXCGSUSY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xF8B9E0", Offset = "0xF8A3E0", VA = "0x180F8B9E0", Slot = "18")]
		public bool Equals(UWGHXCGSUSY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD1E0", Offset = "0x2BDBBE0", VA = "0x182BDD1E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280", Slot = "19")]
		private bool PIJDYQQERTL([In] UWGHXCGSUSY other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, MJOFOHUMYGG<Property>, GDPEXLFGKHZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool DMIRXMUNCBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int ZFZMXDJJQPI;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public QUZNMKSIOOE YFKMMNNXMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool NFFYLUPKEWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DXBQOOMNRQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1290080", Offset = "0x128EA80", VA = "0x181290080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA780", Offset = "0x2BD9180", VA = "0x182BDA780")]
		private Property(QUZNMKSIOOE type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA490", Offset = "0x2BD8E90", VA = "0x182BDA490")]
		public static Property New(QUZNMKSIOOE type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA530", Offset = "0x2BD8F30", VA = "0x182BDA530", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA3F0", Offset = "0x2BD8DF0", VA = "0x182BDA3F0")]
		private string KZLTYHWNQNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA440", Offset = "0x2BD8E40", VA = "0x182BDA440")]
		private string LTWHRPFFLJV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA1C0", Offset = "0x2BD8BC0", VA = "0x182BDA1C0")]
		public bool ABAKIYLIPET([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA310", Offset = "0x2BD8D10", VA = "0x182BDA310", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA2C0", Offset = "0x2BD8CC0", VA = "0x182BDA2C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA330", Offset = "0x2BD8D30", VA = "0x182BDA330", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA610", Offset = "0x2BD9010", VA = "0x182BDA610")]
		private int UFVJOZUZSOY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA6C0", Offset = "0x2BD90C0", VA = "0x182BDA6C0", Slot = "6")]
		public int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDA520", Offset = "0x2BD8F20", VA = "0x182BDA520", Slot = "5")]
		private bool ROSUEKQNCSZ([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class VUUXBDYRNQZ : QUZNMKSIOOE, IEquatable<VUUXBDYRNQZ>, MJOFOHUMYGG<VUUXBDYRNQZ>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD500", Offset = "0x2BDBF00", VA = "0x182BDD500")]
		private VUUXBDYRNQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD460", Offset = "0x2BDBE60", VA = "0x182BDD460")]
		public static VUUXBDYRNQZ New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD4D0", Offset = "0x2BDBED0", VA = "0x182BDD4D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD390", Offset = "0x2BDBD90", VA = "0x182BDD390", Slot = "15")]
		public override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD340", Offset = "0x2BDBD40", VA = "0x182BDD340", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280")]
		public bool ABAKIYLIPET([In] VUUXBDYRNQZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF8B9E0", Offset = "0xF8A3E0", VA = "0x180F8B9E0", Slot = "18")]
		public bool Equals(VUUXBDYRNQZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD410", Offset = "0x2BDBE10", VA = "0x182BDD410", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280", Slot = "19")]
		private bool TOORETIQMKG([In] VUUXBDYRNQZ other)
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
	public sealed class HMVIXNKGPYF : QUZNMKSIOOE, IEquatable<HMVIXNKGPYF>, MJOFOHUMYGG<HMVIXNKGPYF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool KVVZETYHCQP
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2BD83E0", Offset = "0x2BD6DE0", VA = "0x182BD83E0", Slot = "9")]
		public sealed override QUZNMKSIOOE QFZSHGGMNUD(IReadOnlyDictionary<string, QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD82E0", Offset = "0x2BD6CE0", VA = "0x182BD82E0", Slot = "11")]
		public sealed override void EMNEZFPJTXD(Action<QUZNMKSIOOE> a, Action<QUZNMKSIOOE> b, Action<QUZNMKSIOOE> c, Action<QUZNMKSIOOE> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD84F0", Offset = "0x2BD6EF0", VA = "0x182BD84F0")]
		private HMVIXNKGPYF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8360", Offset = "0x2BD6D60", VA = "0x182BD8360")]
		public static HMVIXNKGPYF New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8290", Offset = "0x2BD6C90", VA = "0x182BD8290", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280")]
		public bool ABAKIYLIPET([In] HMVIXNKGPYF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xF8B9E0", Offset = "0xF8A3E0", VA = "0x180F8B9E0", Slot = "18")]
		public bool Equals(HMVIXNKGPYF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8310", Offset = "0x2BD6D10", VA = "0x182BD8310", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2BD84D0", Offset = "0x2BD6ED0", VA = "0x182BD84D0", Slot = "14")]
		protected sealed override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280", Slot = "19")]
		private bool OGMZTGYLJVS([In] HMVIXNKGPYF other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class JUOLMKMWPGQ : QUZNMKSIOOE
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<FMJXCHWCMWA> ICCAFVNBKXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9BA0", Offset = "0x2BD85A0", VA = "0x182BD9BA0")]
		public void Initialize(JUOLMKMWPGQ from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9CD0", Offset = "0x2BD86D0", VA = "0x182BD9CD0")]
		protected JUOLMKMWPGQ(IEnumerable<FMJXCHWCMWA> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool ABAKIYLIPET([In] QUZNMKSIOOE other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9B40", Offset = "0x2BD8540", VA = "0x182BD9B40")]
		protected bool ABAKIYLIPET([In] JUOLMKMWPGQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9C50", Offset = "0x2BD8650", VA = "0x182BD9C50", Slot = "14")]
		protected override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD9BD0", Offset = "0x2BD85D0", VA = "0x182BD9BD0")]
		protected int MRDYGNDDQRU(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class FMJXCHWCMWA : QUZNMKSIOOE, IEquatable<FMJXCHWCMWA>, MJOFOHUMYGG<FMJXCHWCMWA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public QUZNMKSIOOE TCOVDVSZKHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3210", Offset = "0x2BD1C10", VA = "0x182BD3210")]
		private FMJXCHWCMWA(string a, [Optional] QUZNMKSIOOE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2F90", Offset = "0x2BD1990", VA = "0x182BD2F90")]
		public static FMJXCHWCMWA New(string name, [Optional] QUZNMKSIOOE constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3090", Offset = "0x2BD1A90", VA = "0x182BD3090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2E50", Offset = "0x2BD1850", VA = "0x182BD2E50", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2EA0", Offset = "0x2BD18A0", VA = "0x182BD2EA0")]
		public bool ABAKIYLIPET([In] FMJXCHWCMWA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2F40", Offset = "0x2BD1940", VA = "0x182BD2F40", Slot = "18")]
		public bool Equals(FMJXCHWCMWA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2EF0", Offset = "0x2BD18F0", VA = "0x182BD2EF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BD3120", Offset = "0x2BD1B20", VA = "0x182BD3120", Slot = "14")]
		protected override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BD31A0", Offset = "0x2BD1BA0", VA = "0x182BD31A0", Slot = "13")]
		public override int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2EA0", Offset = "0x2BD18A0", VA = "0x182BD2EA0", Slot = "19")]
		private bool UOTSXFBHVXR([In] FMJXCHWCMWA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class XXNYDUUCKUI : QUZNMKSIOOE, IEquatable<XXNYDUUCKUI>, MJOFOHUMYGG<XXNYDUUCKUI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD7F0", Offset = "0x2BDC1F0", VA = "0x182BDD7F0")]
		private XXNYDUUCKUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD700", Offset = "0x2BDC100", VA = "0x182BDD700")]
		public static XXNYDUUCKUI New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD7C0", Offset = "0x2BDC1C0", VA = "0x182BDD7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD5C0", Offset = "0x2BDBFC0", VA = "0x182BDD5C0", Slot = "15")]
		public override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD570", Offset = "0x2BDBF70", VA = "0x182BDD570", Slot = "16")]
		public override int DLTUNUIPIVM(IReadOnlyList<QUZNMKSIOOE> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD770", Offset = "0x2BDC170", VA = "0x182BDD770", Slot = "17")]
		public override bool PJHTFAMIMXB(IReadOnlyList<QUZNMKSIOOE> a, IReadOnlyList<QUZNMKSIOOE> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD520", Offset = "0x2BDBF20", VA = "0x182BDD520", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280")]
		public bool ABAKIYLIPET([In] XXNYDUUCKUI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xF8B9E0", Offset = "0xF8A3E0", VA = "0x180F8B9E0", Slot = "18")]
		public bool Equals(XXNYDUUCKUI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD6B0", Offset = "0x2BDC0B0", VA = "0x182BDD6B0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2BD8280", Offset = "0x2BD6C80", VA = "0x182BD8280", Slot = "19")]
		private bool OLJACSACBBR([In] XXNYDUUCKUI other)
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
			public readonly QUZNMKSIOOE CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x111A3F0", Offset = "0x1118DF0", VA = "0x18111A3F0")]
			internal Impl(QUZNMKSIOOE circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2BD19A0", Offset = "0x2BD03A0", VA = "0x182BD19A0")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1800", Offset = "0x2BD0200", VA = "0x182BD1800")]
		public static CircuitTypeOrString KVAMJBRZXIU(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2BD17A0", Offset = "0x2BD01A0", VA = "0x182BD17A0")]
		public static CircuitTypeOrString KVAMJBRZXIU(QUZNMKSIOOE a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1700", Offset = "0x2BD0100", VA = "0x182BD1700")]
		public QUZNMKSIOOE JICXWLGETYD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1870", Offset = "0x2BD0270", VA = "0x182BD1870")]
		public static QUZNMKSIOOE[] WVBYVFNDRJM(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly GOPNAPZMDFZ _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
		private ClassFactoryBaseClasses(GOPNAPZMDFZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x110DB10", Offset = "0x110C510", VA = "0x18110DB10")]
		public static ClassFactoryBaseClasses New(GOPNAPZMDFZ data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1A30", Offset = "0x2BD0430", VA = "0x182BD1A30")]
		public ClassFactoryBaseClasses SKIBMFMCTLL(HLUORRWSTUX a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x18A5690", Offset = "0x18A4090", VA = "0x1818A5690")]
		public ClassFactoryProps NIZIRRYHBPU()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BD19D0", Offset = "0x2BD03D0", VA = "0x182BD19D0")]
		public ClassFactoryProps JCGXSVLLZOH(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1AF0", Offset = "0x2BD04F0", VA = "0x182BD1AF0")]
		public HLUORRWSTUX YTMSCNEQASK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class GOPNAPZMDFZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? CRWLHSKOIBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string CTZDLOJAEUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<FMJXCHWCMWA> ICCAFVNBKXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<HLUORRWSTUX> NCBJZTAYVQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> TJFCEFCBDVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, DKWNGFRJWFD>> HTLRXUKVYHM;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6420", Offset = "0x2BD4E20", VA = "0x182BD6420")]
		private GOPNAPZMDFZ([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6270", Offset = "0x2BD4C70", VA = "0x182BD6270")]
		public static GOPNAPZMDFZ New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly GOPNAPZMDFZ _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
		private ClassFactoryFuncs(GOPNAPZMDFZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x110DB10", Offset = "0x110C510", VA = "0x18110DB10")]
		public static ClassFactoryFuncs New(GOPNAPZMDFZ data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1B40", Offset = "0x2BD0540", VA = "0x182BD1B40")]
		public HLUORRWSTUX YTMSCNEQASK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly GOPNAPZMDFZ _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
		public ClassFactoryProps(GOPNAPZMDFZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1C90", Offset = "0x2BD0690", VA = "0x182BD1C90")]
		public ClassFactoryProps JCGXSVLLZOH(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x18A5690", Offset = "0x18A4090", VA = "0x1818A5690")]
		public ClassFactoryFuncs GRIKUSJJHSX()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1E20", Offset = "0x2BD0820", VA = "0x182BD1E20")]
		public HLUORRWSTUX YTMSCNEQASK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly GOPNAPZMDFZ _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xEF90A0", Offset = "0xEF7AA0", VA = "0x180EF90A0")]
		private ClassFactoryTypeParams(GOPNAPZMDFZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1E60", Offset = "0x2BD0860", VA = "0x182BD1E60")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2070", Offset = "0x2BD0A70", VA = "0x182BD2070")]
		public ClassFactoryTypeParams ULTUAHONXVJ(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x18A5690", Offset = "0x18A4090", VA = "0x1818A5690")]
		public ClassFactoryBaseClasses MQPOCCMYFID()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2030", Offset = "0x2BD0A30", VA = "0x182BD2030")]
		public ClassFactoryBaseClasses SKIBMFMCTLL(HLUORRWSTUX a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2310", Offset = "0x2BD0D10", VA = "0x182BD2310")]
		public HLUORRWSTUX YTMSCNEQASK()
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
