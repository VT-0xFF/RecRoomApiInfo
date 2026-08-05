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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCE8F30", Offset = "0xCE7D30", VA = "0x180CE8F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? GACVFCDTUKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C850", Offset = "0x2B9B650", VA = "0x182B9C850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual QUZNMKSIOOE IKPPFZGBHIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDEFAA0", Offset = "0xDEE8A0", VA = "0x180DEFAA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool KVVZETYHCQP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CD10", Offset = "0x2B9BB10", VA = "0x182B9CD10")]
		public static void RKCBVVMJUOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
		protected QUZNMKSIOOE(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CC50", Offset = "0x2B9BA50", VA = "0x182B9CC50")]
		public static QUZNMKSIOOE New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDEFAA0", Offset = "0xDEE8A0", VA = "0x180DEFAA0")]
		protected static a MZFUDIQFXQQ<a>(a a) where a : QUZNMKSIOOE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDEFAA0", Offset = "0xDEE8A0", VA = "0x180DEFAA0", Slot = "9")]
		public virtual QUZNMKSIOOE QFZSHGGMNUD(IReadOnlyDictionary<string, QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C950", Offset = "0x2B9B750", VA = "0x182B9C950", Slot = "11")]
		public virtual void EMNEZFPJTXD(Action<QUZNMKSIOOE> a, Action<QUZNMKSIOOE> b, Action<QUZNMKSIOOE> c, Action<QUZNMKSIOOE> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CDA0", Offset = "0x2B9BBA0", VA = "0x182B9CDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C7B0", Offset = "0x2B9B5B0", VA = "0x182B9C7B0", Slot = "12")]
		public virtual bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C980", Offset = "0x2B9B780", VA = "0x182B9C980", Slot = "4")]
		public bool Equals(QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C9B0", Offset = "0x2B9B7B0", VA = "0x182B9C9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CC10", Offset = "0x2B9BA10", VA = "0x182B9CC10")]
		public static bool ITVTPRNZGNV(QUZNMKSIOOE a, QUZNMKSIOOE b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C8C0", Offset = "0x2B9B6C0", VA = "0x182B9C8C0")]
		public static bool CYAUITUETAA(QUZNMKSIOOE a, QUZNMKSIOOE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CA00", Offset = "0x2B9B800", VA = "0x182B9CA00", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CF10", Offset = "0x2B9BD10", VA = "0x182B9CF10", Slot = "13")]
		public virtual int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CF10", Offset = "0x2B9BD10", VA = "0x182B9CF10", Slot = "14")]
		protected virtual int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3BAF0A0", Offset = "0x3BADEA0", VA = "0x183BAF0A0")]
		public b GEVWTHIZUGG<b>() where b : QUZNMKSIOOE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B945C0", Offset = "0x2B933C0", VA = "0x182B945C0", Slot = "15")]
		public virtual string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C900", Offset = "0x2B9B700", VA = "0x182B9C900", Slot = "16")]
		public virtual int DLTUNUIPIVM(IReadOnlyList<QUZNMKSIOOE> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CCC0", Offset = "0x2B9BAC0", VA = "0x182B9CCC0", Slot = "17")]
		public virtual bool PJHTFAMIMXB(IReadOnlyList<QUZNMKSIOOE> a, IReadOnlyList<QUZNMKSIOOE> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CAB0", Offset = "0x2B9B8B0", VA = "0x182B9CAB0")]
		public HKXMWIVRURF IEMRQDZXUFL(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CC00", Offset = "0x2B9BA00", VA = "0x182B9CC00")]
		public HKXMWIVRURF IEMRQDZXUFL(params QUZNMKSIOOE[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CC00", Offset = "0x2B9BA00", VA = "0x182B9CC00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public MSQXLDQVGPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6EEB4C0", Offset = "0x6EEA2C0", VA = "0x186EEB4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ITTXRCVCEBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x65909B0", Offset = "0x658F7B0", VA = "0x1865909B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZAGAZIDTYHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x50FAEE0", Offset = "0x50F9CE0", VA = "0x1850FAEE0")]
			internal int QPQYXQMEQHY(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4090750", Offset = "0x408F550", VA = "0x184090750")]
		public static int TELKMLEDAQD<a>(this IEnumerable<a> a, int b = 0) where a : GDPEXLFGKHZ
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4090820", Offset = "0x408F620", VA = "0x184090820")]
		public static int TELKMLEDAQD<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : GDPEXLFGKHZ
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4090750", Offset = "0x408F550", VA = "0x184090750")]
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
		[Cpp2IlInjected.Address(RVA = "0x5304C90", Offset = "0x5303A90", VA = "0x185304C90")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C981F0", Offset = "0x7C96FF0", VA = "0x187C981F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QHKJRYGJUVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x75F32F0", Offset = "0x75F20F0", VA = "0x1875F32F0")]
			internal bool YKHFZPBBIZG([In] TypeSys<a, b, c> self_, QUZNMKSIOOE a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x75F3380", Offset = "0x75F2180", VA = "0x1875F3380")]
			internal bool YKXARJITLHH([In] TypeSys<a, b, c> self_, QUZNMKSIOOE a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x75F3660", Offset = "0x75F2460", VA = "0x1875F3660")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public YRWGTDCXCSR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x50A4600", Offset = "0x50A3400", VA = "0x1850A4600")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public OMMTMWSMUYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x729B9E0", Offset = "0x729A7E0", VA = "0x18729B9E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FFJNXXAWTKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x62A1BA0", Offset = "0x62A09A0", VA = "0x1862A1BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public UEBOPKGPTRQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7CD4F30", Offset = "0x7CD3D30", VA = "0x187CD4F30")]
			internal bool GVMDWTVJZXO(bool a, HLUORRWSTUX b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] GJYTPXRVYFZ;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37E4CB0", Offset = "0x37E3AB0", VA = "0x1837E4CB0")]
		public static bool YAXTIIAIYSS<a, b, c>([In] this TypeSys<a, b, c> _, QUZNMKSIOOE a) where c : EXOUKTTMMZJ<a, QUZNMKSIOOE, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37E4AF0", Offset = "0x37E38F0", VA = "0x1837E4AF0")]
		public static bool WCKAMCRMAJN<d, e, f>([In] this TypeSys<d, e, f> _, QUZNMKSIOOE a) where f : EXOUKTTMMZJ<d, QUZNMKSIOOE, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37E4B10", Offset = "0x37E3910", VA = "0x1837E4B10")]
		public static bool WFKFCMVFMYZ<g, h, i>([In] this TypeSys<g, h, i> self, QUZNMKSIOOE a, QUZNMKSIOOE b) where i : EXOUKTTMMZJ<g, QUZNMKSIOOE, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37E30B0", Offset = "0x37E1EB0", VA = "0x1837E30B0")]
		private static bool MVVFIWBUXIY<j, k, l>([In] this TypeSys<j, k, l> self, QUZNMKSIOOE a, QUZNMKSIOOE b, IReadOnlyList<QUZNMKSIOOE> c, IReadOnlyList<QUZNMKSIOOE> d) where l : EXOUKTTMMZJ<j, QUZNMKSIOOE, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x37DAA30", Offset = "0x37D9830", VA = "0x1837DAA30")]
		public static QUZNMKSIOOE EJXWZSOGUQW<m, n, o>([In] this TypeSys<m, n, o> self, n a, QUZNMKSIOOE b, QUZNMKSIOOE c) where o : EXOUKTTMMZJ<m, QUZNMKSIOOE, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37DAD70", Offset = "0x37D9B70", VA = "0x1837DAD70")]
		public static p EJXWZSOGUQW<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : EXOUKTTMMZJ<p, QUZNMKSIOOE, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37E4710", Offset = "0x37E3510", VA = "0x1837E4710")]
		private static List<w> NNPAJBICXNC<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : EXOUKTTMMZJ<t, QUZNMKSIOOE, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37E2F10", Offset = "0x37E1D10", VA = "0x1837E2F10")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9AF60", Offset = "0x2B99D60", VA = "0x182B9AF60")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9A960", Offset = "0x2B99760", VA = "0x182B9A960")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9AFB0", Offset = "0x2B99DB0", VA = "0x182B9AFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9AA50", Offset = "0x2B99850", VA = "0x182B9AA50")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9A9B0", Offset = "0x2B997B0", VA = "0x182B9A9B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9ACB0", Offset = "0x2B99AB0", VA = "0x182B9ACB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9AA00", Offset = "0x2B99800", VA = "0x182B9AA00")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B9AC60", Offset = "0x2B99A60", VA = "0x182B9AC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AAA0", Offset = "0x2B998A0", VA = "0x182B9AAA0")]
		public static HKXMWIVRURF GNCAOCWJVYL([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AD00", Offset = "0x2B99B00", VA = "0x182B9AD00")]
		public static HKXMWIVRURF UFRZYMVEBPZ(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A8D0", Offset = "0x2B996D0", VA = "0x182B9A8D0")]
		public static HKXMWIVRURF CUJTTFSJOLH(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A720", Offset = "0x2B99520", VA = "0x182B9A720")]
		public static HKXMWIVRURF CUJTTFSJOLH(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ABD0", Offset = "0x2B999D0", VA = "0x182B9ABD0")]
		public static HKXMWIVRURF LPGPBLHSASU(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AD90", Offset = "0x2B99B90", VA = "0x182B9AD90")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public QNWEWNJMZCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C770", Offset = "0x2B9B570", VA = "0x182B9C770")]
			internal QUZNMKSIOOE FNYAQJLGLQR(QUZNMKSIOOE a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public QUZNMKSIOOE YPJVHKNXTPF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<QUZNMKSIOOE> QFJYATZVZMW
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B98AC0", Offset = "0x2B978C0", VA = "0x182B98AC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B989A0", Offset = "0x2B977A0", VA = "0x182B989A0", Slot = "9")]
		public sealed override QUZNMKSIOOE QFZSHGGMNUD(IReadOnlyDictionary<string, QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B98640", Offset = "0x2B97440", VA = "0x182B98640", Slot = "11")]
		public sealed override void EMNEZFPJTXD(Action<QUZNMKSIOOE> a, Action<QUZNMKSIOOE> b, Action<QUZNMKSIOOE> c, Action<QUZNMKSIOOE> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B98CD0", Offset = "0x2B97AD0", VA = "0x182B98CD0")]
		private HKXMWIVRURF(QUZNMKSIOOE a, IEnumerable<QUZNMKSIOOE> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B98920", Offset = "0x2B97720", VA = "0x182B98920")]
		public static HKXMWIVRURF New(QUZNMKSIOOE originalType, IEnumerable<QUZNMKSIOOE> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B98BE0", Offset = "0x2B979E0", VA = "0x182B98BE0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B98550", Offset = "0x2B97350", VA = "0x182B98550", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B985A0", Offset = "0x2B973A0", VA = "0x182B985A0")]
		public bool ABAKIYLIPET([In] HKXMWIVRURF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B988F0", Offset = "0x2B976F0", VA = "0x182B988F0", Slot = "18")]
		public bool Equals(HKXMWIVRURF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B988A0", Offset = "0x2B976A0", VA = "0x182B988A0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B98C20", Offset = "0x2B97A20", VA = "0x182B98C20", Slot = "14")]
		protected override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B98910", Offset = "0x2B97710", VA = "0x182B98910", Slot = "19")]
		private bool FQMECSASLCK([In] HKXMWIVRURF other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class IPYTKMLDXMW : QUZNMKSIOOE, IEquatable<IPYTKMLDXMW>, MJOFOHUMYGG<IPYTKMLDXMW>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A700", Offset = "0x2B99500", VA = "0x182B9A700")]
		private IPYTKMLDXMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A5F0", Offset = "0x2B993F0", VA = "0x182B9A5F0")]
		public static IPYTKMLDXMW New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A6A0", Offset = "0x2B994A0", VA = "0x182B9A6A0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A510", Offset = "0x2B99310", VA = "0x182B9A510", Slot = "15")]
		public sealed override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A660", Offset = "0x2B99460", VA = "0x182B9A660")]
		private static string QDQFCSHOMYD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A4C0", Offset = "0x2B992C0", VA = "0x182B9A4C0", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220")]
		public bool ABAKIYLIPET([In] IPYTKMLDXMW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xF6EC00", Offset = "0xF6DA00", VA = "0x180F6EC00", Slot = "18")]
		public bool Equals(IPYTKMLDXMW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A5A0", Offset = "0x2B993A0", VA = "0x182B9A5A0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRDFVZFEZPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B9BCD0", Offset = "0x2B9AAD0", VA = "0x182B9BCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KRIMTFZCJAT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B9BE50", Offset = "0x2B9AC50", VA = "0x182B9BE50")]
			internal HKXMWIVRURF SHZLCTHGUQT(QUZNMKSIOOE a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B96760", Offset = "0x2B95560", VA = "0x182B96760")]
		public static IEnumerable<HLUORRWSTUX> RSTMEIZRDJZ(this HLUORRWSTUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B96080", Offset = "0x2B94E80", VA = "0x182B96080")]
		private static IEnumerable<HLUORRWSTUX> LOYIJWHAUFX(this HLUORRWSTUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B98010", Offset = "0x2B96E10", VA = "0x182B98010")]
		public static (QUZNMKSIOOE, IReadOnlyList<QUZNMKSIOOE>, bool) VAYNTXOONQH(this QUZNMKSIOOE a, [Optional] IReadOnlyList<QUZNMKSIOOE> b)
		{
			return default((QUZNMKSIOOE, IReadOnlyList<QUZNMKSIOOE>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B981E0", Offset = "0x2B96FE0", VA = "0x182B981E0")]
		public static TypeKind WPGJKAXNXGY(this QUZNMKSIOOE a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B95270", Offset = "0x2B94070", VA = "0x182B95270")]
		private static QUZNMKSIOOE ConvertClassesToIntersections(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B95D50", Offset = "0x2B94B50", VA = "0x182B95D50")]
		private static QUZNMKSIOOE DistributeUnionIntoIntersection(this HKXMWIVRURF self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B958C0", Offset = "0x2B946C0", VA = "0x182B958C0")]
		private static QUZNMKSIOOE DistributeIntersectionIntoIntersection(this HKXMWIVRURF self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B95BF0", Offset = "0x2B949F0", VA = "0x182B95BF0")]
		private static QUZNMKSIOOE DistributeIntoIntersection(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B96140", Offset = "0x2B94F40", VA = "0x182B96140")]
		private static bool OtherIsAssignableToOther(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes, QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B97870", Offset = "0x2B96670", VA = "0x182B97870")]
		private static bool UnionIsAssignableToOther(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes, QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B962D0", Offset = "0x2B950D0", VA = "0x182B962D0")]
		private static bool OtherIsAssignableToUnion(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes, QUZNMKSIOOE union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B97BA0", Offset = "0x2B969A0", VA = "0x182B97BA0")]
		private static bool UnionIsAssignableToUnion(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes, QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B97670", Offset = "0x2B96470", VA = "0x182B97670")]
		public static QUZNMKSIOOE RemoveCommonTypesFromIntersectionDistribution(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B96990", Offset = "0x2B95790", VA = "0x182B96990")]
		public static QUZNMKSIOOE RemoveCommonTypesFromIntersectionDistributionInternal(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B977A0", Offset = "0x2B965A0", VA = "0x182B977A0")]
		public static QUZNMKSIOOE SimplifyIntersectionUnion(this QUZNMKSIOOE self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B96680", Offset = "0x2B95480", VA = "0x182B96680")]
		public static IEnumerable<QUZNMKSIOOE> QFJYATZVZMW(this QUZNMKSIOOE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B966D0", Offset = "0x2B954D0", VA = "0x182B966D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public JSMMREYGZBM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B8A0", Offset = "0x2B9A6A0", VA = "0x182B9B8A0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B4E0", Offset = "0x2B9A2E0", VA = "0x182B9B4E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2B9BA80", Offset = "0x2B9A880", VA = "0x182B9BA80")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B9BA30", Offset = "0x2B9A830", VA = "0x182B9BA30")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B9F0", Offset = "0x2B9A7F0", VA = "0x182B9B9F0", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B440", Offset = "0x2B9A240", VA = "0x182B9B440", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HLUORRWSTUX> ETARUXQIBHL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B9B440", Offset = "0x2B9A240", VA = "0x182B9B440", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B98F10", Offset = "0x2B97D10", VA = "0x182B98F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? GACVFCDTUKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xF71A30", Offset = "0xF70830", VA = "0x180F71A30")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xF72010", Offset = "0xF70E10", VA = "0x180F72010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCE8260", Offset = "0xCE7060", VA = "0x180CE8260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<HLUORRWSTUX> NCBJZTAYVQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<HLUORRWSTUX> ICSQNZXPCOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2B99CF0", Offset = "0x2B98AF0", VA = "0x182B99CF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B20", Offset = "0xCE6920", VA = "0x180CE7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCE7900", Offset = "0xCE6700", VA = "0x180CE7900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, DKWNGFRJWFD> HTLRXUKVYHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCE7940", Offset = "0xCE6740", VA = "0x180CE7940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCE82A0", Offset = "0xCE70A0", VA = "0x180CE82A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B99E60", Offset = "0x2B98C60", VA = "0x182B99E60")]
		public HLUORRWSTUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A170", Offset = "0x2B98F70", VA = "0x182B9A170")]
		public HLUORRWSTUX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B990A0", Offset = "0x2B97EA0", VA = "0x182B990A0")]
		public static HLUORRWSTUX HFSYOHOAITW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B99690", Offset = "0x2B98490", VA = "0x182B99690")]
		public static HLUORRWSTUX PEVRHZLFAZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B993C0", Offset = "0x2B981C0", VA = "0x182B993C0")]
		public void Initialize(HLUORRWSTUX from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B99EC0", Offset = "0x2B98CC0", VA = "0x182B99EC0")]
		private HLUORRWSTUX([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<FMJXCHWCMWA> c, [Optional] IEnumerable<HLUORRWSTUX> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, DKWNGFRJWFD>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B995C0", Offset = "0x2B983C0", VA = "0x182B995C0")]
		public static HLUORRWSTUX New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<FMJXCHWCMWA> typeParameters, [Optional] IEnumerable<HLUORRWSTUX> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, DKWNGFRJWFD>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B99AE0", Offset = "0x2B988E0", VA = "0x182B99AE0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B996E0", Offset = "0x2B984E0", VA = "0x182B996E0")]
		private string PFOZOKVSTQQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B99740", Offset = "0x2B98540", VA = "0x182B99740")]
		private static string QAJBRBXFUWB(IEnumerable<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B99800", Offset = "0x2B98600", VA = "0x182B99800")]
		private string RGFQYISBGYM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B990F0", Offset = "0x2B97EF0", VA = "0x182B990F0")]
		private string HHJKKYJHIKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B98F60", Offset = "0x2B97D60", VA = "0x182B98F60", Slot = "15")]
		public sealed override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B98EC0", Offset = "0x2B97CC0", VA = "0x182B98EC0", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B98DA0", Offset = "0x2B97BA0", VA = "0x182B98DA0")]
		public bool ABAKIYLIPET([In] HLUORRWSTUX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B99080", Offset = "0x2B97E80", VA = "0x182B99080", Slot = "18")]
		public bool Equals(HLUORRWSTUX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B99030", Offset = "0x2B97E30", VA = "0x182B99030", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B99BD0", Offset = "0x2B989D0", VA = "0x182B99BD0", Slot = "14")]
		protected override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B99CE0", Offset = "0x2B98AE0", VA = "0x182B99CE0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		private NOXBFFLFFAX(QUZNMKSIOOE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C0C0", Offset = "0x2B9AEC0", VA = "0x182B9C0C0")]
		public static NOXBFFLFFAX New(QUZNMKSIOOE type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BB10", Offset = "0x2B5A910", VA = "0x182B5BB10", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BFD0", Offset = "0x2B9ADD0", VA = "0x182B9BFD0")]
		public bool ABAKIYLIPET([In] NOXBFFLFFAX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C070", Offset = "0x2B9AE70", VA = "0x182B9C070", Slot = "4")]
		public bool Equals(NOXBFFLFFAX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C020", Offset = "0x2B9AE20", VA = "0x182B9C020", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D2A0", Offset = "0x2B6C0A0", VA = "0x182B6D2A0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C120", Offset = "0x2B9AF20", VA = "0x182B9C120", Slot = "6")]
		public int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BFD0", Offset = "0x2B9ADD0", VA = "0x182B9BFD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		private YMQORHFWAXW(QUZNMKSIOOE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7F0", Offset = "0x2B9E5F0", VA = "0x182B9F7F0")]
		public static YMQORHFWAXW New(QUZNMKSIOOE type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BB10", Offset = "0x2B5A910", VA = "0x182B5BB10", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BFD0", Offset = "0x2B9ADD0", VA = "0x182B9BFD0")]
		public bool ABAKIYLIPET([In] YMQORHFWAXW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C070", Offset = "0x2B9AE70", VA = "0x182B9C070", Slot = "4")]
		public bool Equals(YMQORHFWAXW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7A0", Offset = "0x2B9E5A0", VA = "0x182B9F7A0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D2A0", Offset = "0x2B6C0A0", VA = "0x182B6D2A0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C120", Offset = "0x2B9AF20", VA = "0x182B9C120", Slot = "6")]
		public int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BFD0", Offset = "0x2B9ADD0", VA = "0x182B9BFD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B94D00", Offset = "0x2B93B00", VA = "0x182B94D00")]
		private DKWNGFRJWFD(IEnumerable<FMJXCHWCMWA> a, IEnumerable<KeyValuePair<string, NOXBFFLFFAX>> b, IEnumerable<KeyValuePair<string, YMQORHFWAXW>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B94660", Offset = "0x2B93460", VA = "0x182B94660")]
		public static DKWNGFRJWFD New(IEnumerable<FMJXCHWCMWA> typeParameters, IEnumerable<KeyValuePair<string, NOXBFFLFFAX>> inputs, IEnumerable<KeyValuePair<string, YMQORHFWAXW>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B94790", Offset = "0x2B93590", VA = "0x182B94790", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B945C0", Offset = "0x2B933C0", VA = "0x182B945C0", Slot = "15")]
		public sealed override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B94440", Offset = "0x2B93240", VA = "0x182B94440")]
		private string BBQZKPQQWWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B94B80", Offset = "0x2B93980", VA = "0x182B94B80")]
		private string UOVMFRBZFWJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B94310", Offset = "0x2B93110", VA = "0x182B94310", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B94360", Offset = "0x2B93160", VA = "0x182B94360")]
		public bool ABAKIYLIPET([In] DKWNGFRJWFD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B94630", Offset = "0x2B93430", VA = "0x182B94630", Slot = "18")]
		public bool Equals(DKWNGFRJWFD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B945E0", Offset = "0x2B933E0", VA = "0x182B945E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B94AA0", Offset = "0x2B938A0", VA = "0x182B94AA0", Slot = "14")]
		protected sealed override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B94650", Offset = "0x2B93450", VA = "0x182B94650", Slot = "19")]
		private bool FFHTIOTVWHW([In] DKWNGFRJWFD other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UWGHXCGSUSY : QUZNMKSIOOE, IEquatable<UWGHXCGSUSY>, MJOFOHUMYGG<UWGHXCGSUSY>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F2B0", Offset = "0x2B9E0B0", VA = "0x182B9F2B0")]
		private UWGHXCGSUSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F1C0", Offset = "0x2B9DFC0", VA = "0x182B9F1C0")]
		public static UWGHXCGSUSY New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F280", Offset = "0x2B9E080", VA = "0x182B9F280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F080", Offset = "0x2B9DE80", VA = "0x182B9F080", Slot = "15")]
		public override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F030", Offset = "0x2B9DE30", VA = "0x182B9F030", Slot = "16")]
		public override int DLTUNUIPIVM(IReadOnlyList<QUZNMKSIOOE> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F230", Offset = "0x2B9E030", VA = "0x182B9F230", Slot = "17")]
		public override bool PJHTFAMIMXB(IReadOnlyList<QUZNMKSIOOE> a, IReadOnlyList<QUZNMKSIOOE> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EFE0", Offset = "0x2B9DDE0", VA = "0x182B9EFE0", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220")]
		public bool ABAKIYLIPET([In] UWGHXCGSUSY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xF6EC00", Offset = "0xF6DA00", VA = "0x180F6EC00", Slot = "18")]
		public bool Equals(UWGHXCGSUSY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F170", Offset = "0x2B9DF70", VA = "0x182B9F170", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720")]
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
			[Cpp2IlInjected.Address(RVA = "0x1251680", Offset = "0x1250480", VA = "0x181251680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C710", Offset = "0x2B9B510", VA = "0x182B9C710")]
		private Property(QUZNMKSIOOE type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C420", Offset = "0x2B9B220", VA = "0x182B9C420")]
		public static Property New(QUZNMKSIOOE type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C4C0", Offset = "0x2B9B2C0", VA = "0x182B9C4C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C380", Offset = "0x2B9B180", VA = "0x182B9C380")]
		private string KZLTYHWNQNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C3D0", Offset = "0x2B9B1D0", VA = "0x182B9C3D0")]
		private string LTWHRPFFLJV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C150", Offset = "0x2B9AF50", VA = "0x182B9C150")]
		public bool ABAKIYLIPET([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C2A0", Offset = "0x2B9B0A0", VA = "0x182B9C2A0", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C250", Offset = "0x2B9B050", VA = "0x182B9C250", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C2C0", Offset = "0x2B9B0C0", VA = "0x182B9C2C0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C5A0", Offset = "0x2B9B3A0", VA = "0x182B9C5A0")]
		private int UFVJOZUZSOY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C650", Offset = "0x2B9B450", VA = "0x182B9C650", Slot = "6")]
		public int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C4B0", Offset = "0x2B9B2B0", VA = "0x182B9C4B0", Slot = "5")]
		private bool ROSUEKQNCSZ([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class VUUXBDYRNQZ : QUZNMKSIOOE, IEquatable<VUUXBDYRNQZ>, MJOFOHUMYGG<VUUXBDYRNQZ>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F490", Offset = "0x2B9E290", VA = "0x182B9F490")]
		private VUUXBDYRNQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F3F0", Offset = "0x2B9E1F0", VA = "0x182B9F3F0")]
		public static VUUXBDYRNQZ New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F460", Offset = "0x2B9E260", VA = "0x182B9F460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F320", Offset = "0x2B9E120", VA = "0x182B9F320", Slot = "15")]
		public override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F2D0", Offset = "0x2B9E0D0", VA = "0x182B9F2D0", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220")]
		public bool ABAKIYLIPET([In] VUUXBDYRNQZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF6EC00", Offset = "0xF6DA00", VA = "0x180F6EC00", Slot = "18")]
		public bool Equals(VUUXBDYRNQZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F3A0", Offset = "0x2B9E1A0", VA = "0x182B9F3A0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A380", Offset = "0x2B99180", VA = "0x182B9A380", Slot = "9")]
		public sealed override QUZNMKSIOOE QFZSHGGMNUD(IReadOnlyDictionary<string, QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A280", Offset = "0x2B99080", VA = "0x182B9A280", Slot = "11")]
		public sealed override void EMNEZFPJTXD(Action<QUZNMKSIOOE> a, Action<QUZNMKSIOOE> b, Action<QUZNMKSIOOE> c, Action<QUZNMKSIOOE> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A480", Offset = "0x2B99280", VA = "0x182B9A480")]
		private HMVIXNKGPYF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A300", Offset = "0x2B99100", VA = "0x182B9A300")]
		public static HMVIXNKGPYF New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A230", Offset = "0x2B99030", VA = "0x182B9A230", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220")]
		public bool ABAKIYLIPET([In] HMVIXNKGPYF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xF6EC00", Offset = "0xF6DA00", VA = "0x180F6EC00", Slot = "18")]
		public bool Equals(HMVIXNKGPYF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A2B0", Offset = "0x2B990B0", VA = "0x182B9A2B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A460", Offset = "0x2B99260", VA = "0x182B9A460", Slot = "14")]
		protected sealed override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BB30", Offset = "0x2B9A930", VA = "0x182B9BB30")]
		public void Initialize(JUOLMKMWPGQ from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BC60", Offset = "0x2B9AA60", VA = "0x182B9BC60")]
		protected JUOLMKMWPGQ(IEnumerable<FMJXCHWCMWA> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool ABAKIYLIPET([In] QUZNMKSIOOE other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BAD0", Offset = "0x2B9A8D0", VA = "0x182B9BAD0")]
		protected bool ABAKIYLIPET([In] JUOLMKMWPGQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BBE0", Offset = "0x2B9A9E0", VA = "0x182B9BBE0", Slot = "14")]
		protected override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BB60", Offset = "0x2B9A960", VA = "0x182B9BB60")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2B951B0", Offset = "0x2B93FB0", VA = "0x182B951B0")]
		private FMJXCHWCMWA(string a, [Optional] QUZNMKSIOOE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2B94F30", Offset = "0x2B93D30", VA = "0x182B94F30")]
		public static FMJXCHWCMWA New(string name, [Optional] QUZNMKSIOOE constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B95030", Offset = "0x2B93E30", VA = "0x182B95030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B94DF0", Offset = "0x2B93BF0", VA = "0x182B94DF0", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B94E40", Offset = "0x2B93C40", VA = "0x182B94E40")]
		public bool ABAKIYLIPET([In] FMJXCHWCMWA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B94EE0", Offset = "0x2B93CE0", VA = "0x182B94EE0", Slot = "18")]
		public bool Equals(FMJXCHWCMWA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B94E90", Offset = "0x2B93C90", VA = "0x182B94E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B950C0", Offset = "0x2B93EC0", VA = "0x182B950C0", Slot = "14")]
		protected override int UFVJOZUZSOY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2B95140", Offset = "0x2B93F40", VA = "0x182B95140", Slot = "13")]
		public override int UVKSOXERWNG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2B94E40", Offset = "0x2B93C40", VA = "0x182B94E40", Slot = "19")]
		private bool UOTSXFBHVXR([In] FMJXCHWCMWA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class XXNYDUUCKUI : QUZNMKSIOOE, IEquatable<XXNYDUUCKUI>, MJOFOHUMYGG<XXNYDUUCKUI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F780", Offset = "0x2B9E580", VA = "0x182B9F780")]
		private XXNYDUUCKUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F690", Offset = "0x2B9E490", VA = "0x182B9F690")]
		public static XXNYDUUCKUI New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F750", Offset = "0x2B9E550", VA = "0x182B9F750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F550", Offset = "0x2B9E350", VA = "0x182B9F550", Slot = "15")]
		public override string EZWGFCAVZCR(IReadOnlyList<QUZNMKSIOOE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F500", Offset = "0x2B9E300", VA = "0x182B9F500", Slot = "16")]
		public override int DLTUNUIPIVM(IReadOnlyList<QUZNMKSIOOE> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F700", Offset = "0x2B9E500", VA = "0x182B9F700", Slot = "17")]
		public override bool PJHTFAMIMXB(IReadOnlyList<QUZNMKSIOOE> a, IReadOnlyList<QUZNMKSIOOE> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F4B0", Offset = "0x2B9E2B0", VA = "0x182B9F4B0", Slot = "12")]
		public override bool ABAKIYLIPET([In] QUZNMKSIOOE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220")]
		public bool ABAKIYLIPET([In] XXNYDUUCKUI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xF6EC00", Offset = "0xF6DA00", VA = "0x180F6EC00", Slot = "18")]
		public bool Equals(XXNYDUUCKUI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F640", Offset = "0x2B9E440", VA = "0x182B9F640", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A220", Offset = "0x2B99020", VA = "0x182B9A220", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B93940", Offset = "0x2B92740", VA = "0x182B93940")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B937A0", Offset = "0x2B925A0", VA = "0x182B937A0")]
		public static CircuitTypeOrString KVAMJBRZXIU(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B93740", Offset = "0x2B92540", VA = "0x182B93740")]
		public static CircuitTypeOrString KVAMJBRZXIU(QUZNMKSIOOE a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B936A0", Offset = "0x2B924A0", VA = "0x182B936A0")]
		public QUZNMKSIOOE JICXWLGETYD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B93810", Offset = "0x2B92610", VA = "0x182B93810")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		private ClassFactoryBaseClasses(GOPNAPZMDFZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x10C67F0", Offset = "0x10C55F0", VA = "0x1810C67F0")]
		public static ClassFactoryBaseClasses New(GOPNAPZMDFZ data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B939D0", Offset = "0x2B927D0", VA = "0x182B939D0")]
		public ClassFactoryBaseClasses SKIBMFMCTLL(HLUORRWSTUX a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x186CFA0", Offset = "0x186BDA0", VA = "0x18186CFA0")]
		public ClassFactoryProps NIZIRRYHBPU()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B93970", Offset = "0x2B92770", VA = "0x182B93970")]
		public ClassFactoryProps JCGXSVLLZOH(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B93A90", Offset = "0x2B92890", VA = "0x182B93A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B983C0", Offset = "0x2B971C0", VA = "0x182B983C0")]
		private GOPNAPZMDFZ([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2B98210", Offset = "0x2B97010", VA = "0x182B98210")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		private ClassFactoryFuncs(GOPNAPZMDFZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x10C67F0", Offset = "0x10C55F0", VA = "0x1810C67F0")]
		public static ClassFactoryFuncs New(GOPNAPZMDFZ data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B93AE0", Offset = "0x2B928E0", VA = "0x182B93AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		public ClassFactoryProps(GOPNAPZMDFZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C30", Offset = "0x2B92A30", VA = "0x182B93C30")]
		public ClassFactoryProps JCGXSVLLZOH(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x186CFA0", Offset = "0x186BDA0", VA = "0x18186CFA0")]
		public ClassFactoryFuncs GRIKUSJJHSX()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B93DC0", Offset = "0x2B92BC0", VA = "0x182B93DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		private ClassFactoryTypeParams(GOPNAPZMDFZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B93E00", Offset = "0x2B92C00", VA = "0x182B93E00")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B94010", Offset = "0x2B92E10", VA = "0x182B94010")]
		public ClassFactoryTypeParams ULTUAHONXVJ(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x186CFA0", Offset = "0x186BDA0", VA = "0x18186CFA0")]
		public ClassFactoryBaseClasses MQPOCCMYFID()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B93FD0", Offset = "0x2B92DD0", VA = "0x182B93FD0")]
		public ClassFactoryBaseClasses SKIBMFMCTLL(HLUORRWSTUX a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B942B0", Offset = "0x2B930B0", VA = "0x182B942B0")]
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
