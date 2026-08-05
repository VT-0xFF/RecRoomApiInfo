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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class NRZUVTJIBNZ : IEquatable<NRZUVTJIBNZ>, YTDJCTQVIZN<NRZUVTJIBNZ>, DHPTPBHEZAS
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool XDUETXRDMET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool UBXTHNSEYPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int GWHHIVYTRFJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind EQBNTADKZHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB4310", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAC3260", Offset = "0xAC2460", VA = "0x180AC3260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? EYTBNMJXXWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2929D60", Offset = "0x2928F60", VA = "0x182929D60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual NRZUVTJIBNZ QCBTDZDYDST
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBA0810", Offset = "0xB9FA10", VA = "0x180BA0810", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool ADMYCYZXVSG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29297F0", Offset = "0x29289F0", VA = "0x1829297F0")]
		public static void MPSAKZMSCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
		protected NRZUVTJIBNZ(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x29298B0", Offset = "0x2928AB0", VA = "0x1829298B0")]
		public static NRZUVTJIBNZ New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBA0810", Offset = "0xB9FA10", VA = "0x180BA0810")]
		protected static a EAKWSAKKWED<a>(a a) where a : NRZUVTJIBNZ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBA0810", Offset = "0xB9FA10", VA = "0x180BA0810", Slot = "9")]
		public virtual NRZUVTJIBNZ IREZWXNTQHO(IReadOnlyDictionary<string, NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2929B00", Offset = "0x2928D00", VA = "0x182929B00", Slot = "11")]
		public virtual void TQDXKJSPQZS(Action<NRZUVTJIBNZ> a, Action<NRZUVTJIBNZ> b, Action<NRZUVTJIBNZ> c, Action<NRZUVTJIBNZ> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2929B30", Offset = "0x2928D30", VA = "0x182929B30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2929CC0", Offset = "0x2928EC0", VA = "0x182929CC0", Slot = "12")]
		public virtual bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29296C0", Offset = "0x29288C0", VA = "0x1829296C0", Slot = "4")]
		public bool Equals(NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x29296F0", Offset = "0x29288F0", VA = "0x1829296F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2929920", Offset = "0x2928B20", VA = "0x182929920")]
		public static bool QEDRWBLLCYQ(NRZUVTJIBNZ a, NRZUVTJIBNZ b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2929680", Offset = "0x2928880", VA = "0x182929680")]
		public static bool EPOGIYJSRBR(NRZUVTJIBNZ a, NRZUVTJIBNZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2929740", Offset = "0x2928940", VA = "0x182929740", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2929880", Offset = "0x2928A80", VA = "0x182929880", Slot = "13")]
		public virtual int QDRIJESPZBN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2929880", Offset = "0x2928A80", VA = "0x182929880", Slot = "14")]
		protected virtual int NRAEYZKAVZZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38010E0", Offset = "0x38002E0", VA = "0x1838010E0")]
		public b SGBAODNQZXZ<b>() where b : NRZUVTJIBNZ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2929CA0", Offset = "0x2928EA0", VA = "0x182929CA0", Slot = "15")]
		public virtual string UFZUMNHAJBK(IReadOnlyList<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2929DD0", Offset = "0x2928FD0", VA = "0x182929DD0", Slot = "16")]
		public virtual int XVZITEGYMPN(IReadOnlyList<NRZUVTJIBNZ> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2929960", Offset = "0x2928B60", VA = "0x182929960", Slot = "17")]
		public virtual bool ROHZLNRWFBI(IReadOnlyList<NRZUVTJIBNZ> a, IReadOnlyList<NRZUVTJIBNZ> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x29299C0", Offset = "0x2928BC0", VA = "0x1829299C0")]
		public HMXDRHPONDM TLHJSMRJICM(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x29299B0", Offset = "0x2928BB0", VA = "0x1829299B0")]
		public HMXDRHPONDM TLHJSMRJICM(params NRZUVTJIBNZ[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x29299B0", Offset = "0x2928BB0", VA = "0x1829299B0")]
		public HMXDRHPONDM TLHJSMRJICM(IEnumerable<NRZUVTJIBNZ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IRGRAGFCDUQ<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a MYVIKAPAPIW(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b QACPWNNUFVS([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind SWURMRAVSUG([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates GVEFFOYCAKN(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DHPTPBHEZAS
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int QDRIJESPZBN(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class QDRIJESPZBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class CZQIAJCKJOB<a> where a : DHPTPBHEZAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int VXYAEQRKAXO;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public CZQIAJCKJOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3DC47A0", Offset = "0x3DC39A0", VA = "0x183DC47A0")]
			internal int DPMYNRWYOJE(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LSAQVHFHYVB<a, b> where b : DHPTPBHEZAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int VXYAEQRKAXO;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public LSAQVHFHYVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x53C92E0", Offset = "0x53C84E0", VA = "0x1853C92E0")]
			internal int DPMYNRWYOJE(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class AJBUFIUKWTR<a> where a : DHPTPBHEZAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int VXYAEQRKAXO;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public AJBUFIUKWTR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x55893E0", Offset = "0x55885E0", VA = "0x1855893E0")]
			internal int ENSUYMOHKHF(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39D8D50", Offset = "0x39D7F50", VA = "0x1839D8D50")]
		public static int EQIZGMSXGZG<a>(this IEnumerable<a> a, int b = 0) where a : DHPTPBHEZAS
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39D8C80", Offset = "0x39D7E80", VA = "0x1839D8C80")]
		public static int EQIZGMSXGZG<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : DHPTPBHEZAS
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39D8D50", Offset = "0x39D7F50", VA = "0x1839D8D50")]
		public static int FHFDLGKNMBZ<d>(this IEnumerable<d> a, int b = 0) where d : DHPTPBHEZAS
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : IRGRAGFCDUQ<TDirectedType, NRZUVTJIBNZ, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4073BA0", Offset = "0x4072DA0", VA = "0x184073BA0")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6233300", Offset = "0x6232500", VA = "0x186233300")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class TQDIWLTQGCZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FFDMQZKKKIH<a, b, c> where c : IRGRAGFCDUQ<a, NRZUVTJIBNZ, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public NRZUVTJIBNZ FVATIGNMZQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<NRZUVTJIBNZ> QBGQVSTJSMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public NRZUVTJIBNZ FOHJHBPXOHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<NRZUVTJIBNZ> BMKWUHWSGBJ;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public FFDMQZKKKIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4D3BFE0", Offset = "0x4D3B1E0", VA = "0x184D3BFE0")]
			internal bool TSIWDZOMXSJ([In] TypeSys<a, b, c> self_, NRZUVTJIBNZ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4D3BDC0", Offset = "0x4D3AFC0", VA = "0x184D3BDC0")]
			internal bool TRTBMFGUVKI([In] TypeSys<a, b, c> self_, NRZUVTJIBNZ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4D3C1E0", Offset = "0x4D3B3E0", VA = "0x184D3C1E0")]
			internal bool TTDXTAQCJLT([In] TypeSys<a, b, c> self_, NRZUVTJIBNZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OMGSFZCALWM<a, b, c> where c : IRGRAGFCDUQ<a, NRZUVTJIBNZ, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public NRZUVTJIBNZ PJGOKGSTPRR;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public OMGSFZCALWM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5A89160", Offset = "0x5A88360", VA = "0x185A89160")]
			internal bool TSYQVTWFAAK([In] TypeSys<a, b, c> self__, NRZUVTJIBNZ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JBEGPZGTHKJ<a, b, c> where c : IRGRAGFCDUQ<a, NRZUVTJIBNZ, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b OLVATFGKMBC;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public JBEGPZGTHKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x50DC7A0", Offset = "0x50DB9A0", VA = "0x1850DC7A0")]
			internal NRZUVTJIBNZ ECHWOBAORCG([In] TypeSys<a, b, c> self_, [In] b root_, NRZUVTJIBNZ a, NRZUVTJIBNZ b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class AKFWYLXMJOG<a, b, c> where c : IRGRAGFCDUQ<a, NRZUVTJIBNZ, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public OJOXJTZCBAY WBJKZITOMRP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public OJOXJTZCBAY PIOJFGXOEFI;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public AKFWYLXMJOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x558FFA0", Offset = "0x558F1A0", VA = "0x18558FFA0")]
			internal a ECCPQUGRHQX([In] TypeSys<a, b, c> self_, IOKind a, OJOXJTZCBAY b, OJOXJTZCBAY c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class DJPLNLSQIRR<a, b, c> where c : IRGRAGFCDUQ<a, NRZUVTJIBNZ, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<OJOXJTZCBAY> ETKMKBRCPAU;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public DJPLNLSQIRR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4080EE0", Offset = "0x40800E0", VA = "0x184080EE0")]
			internal bool XDZTWZAAGLR(bool a, OJOXJTZCBAY b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] OPYWXUTKLXI;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB040", Offset = "0x3AEA240", VA = "0x183AEB040")]
		public static bool TFFQOWQXTST<a, b, c>([In] this TypeSys<a, b, c> _, NRZUVTJIBNZ a) where c : IRGRAGFCDUQ<a, NRZUVTJIBNZ, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2AC0", Offset = "0x3AE1CC0", VA = "0x183AE2AC0")]
		public static bool JVPWPMDVRPS<d, e, f>([In] this TypeSys<d, e, f> _, NRZUVTJIBNZ a) where f : IRGRAGFCDUQ<d, NRZUVTJIBNZ, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBA60", Offset = "0x3AEAC60", VA = "0x183AEBA60")]
		public static bool WKQQVTSHOXO<g, h, i>([In] this TypeSys<g, h, i> self, NRZUVTJIBNZ a, NRZUVTJIBNZ b) where i : IRGRAGFCDUQ<g, NRZUVTJIBNZ, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBC00", Offset = "0x3AEAE00", VA = "0x183AEBC00")]
		private static bool ZPJFDGFFIHP<j, k, l>([In] this TypeSys<j, k, l> self, NRZUVTJIBNZ a, NRZUVTJIBNZ b, IReadOnlyList<NRZUVTJIBNZ> c, IReadOnlyList<NRZUVTJIBNZ> d) where l : IRGRAGFCDUQ<j, NRZUVTJIBNZ, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2AE0", Offset = "0x3AE1CE0", VA = "0x183AE2AE0")]
		public static NRZUVTJIBNZ KWTGYVLNMYT<m, n, o>([In] this TypeSys<m, n, o> self, n a, NRZUVTJIBNZ b, NRZUVTJIBNZ c) where o : IRGRAGFCDUQ<m, NRZUVTJIBNZ, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2E20", Offset = "0x3AE2020", VA = "0x183AE2E20")]
		public static p KWTGYVLNMYT<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : IRGRAGFCDUQ<p, NRZUVTJIBNZ, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AEAC60", Offset = "0x3AE9E60", VA = "0x183AEAC60")]
		private static List<w> LIMDMXYCYAD<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : IRGRAGFCDUQ<t, NRZUVTJIBNZ, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB8C0", Offset = "0x3AEAAC0", VA = "0x183AEB8C0")]
		private static ba UOIPEKDLCDH<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class LMFXSBBOFTG
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static NRZUVTJIBNZ JOFPEVIWCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2928E40", Offset = "0x2928040", VA = "0x182928E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static NRZUVTJIBNZ DKFMCTSBEFT
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2928790", Offset = "0x2927990", VA = "0x182928790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static NRZUVTJIBNZ CJIMUPECOSK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2928D50", Offset = "0x2927F50", VA = "0x182928D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static NRZUVTJIBNZ UGYYYKWWZJS
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2928DA0", Offset = "0x2927FA0", VA = "0x182928DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static NRZUVTJIBNZ MLRHRXGDWUG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2928E90", Offset = "0x2928090", VA = "0x182928E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static NRZUVTJIBNZ CAZVSZUAAWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2928DF0", Offset = "0x2927FF0", VA = "0x182928DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static NRZUVTJIBNZ HXDPVNQRMWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x29287E0", Offset = "0x29279E0", VA = "0x1829287E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static NRZUVTJIBNZ HZTWWMKDDTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2928740", Offset = "0x2927940", VA = "0x182928740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2928EE0", Offset = "0x29280E0", VA = "0x182928EE0")]
		public static HMXDRHPONDM YRJVNOGLMLY([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2928830", Offset = "0x2927A30", VA = "0x182928830")]
		public static HMXDRHPONDM KGJQBHRXSCM(IEnumerable<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2928B20", Offset = "0x2927D20", VA = "0x182928B20")]
		public static HMXDRHPONDM SOXNVVKZFAA(IEnumerable<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2928BB0", Offset = "0x2927DB0", VA = "0x182928BB0")]
		public static HMXDRHPONDM SOXNVVKZFAA(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2928A90", Offset = "0x2927C90", VA = "0x182928A90")]
		public static HMXDRHPONDM RKNYGVMCSRX(IEnumerable<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x29288C0", Offset = "0x2927AC0", VA = "0x1829288C0")]
		public static ZGNJGYIDZNF OTIORDKVIPU(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class HMXDRHPONDM : NRZUVTJIBNZ, IEquatable<HMXDRHPONDM>, YTDJCTQVIZN<HMXDRHPONDM>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FVGGAGPQVFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, NRZUVTJIBNZ> RQAETPUBJMG;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public FVGGAGPQVFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2924A90", Offset = "0x2923C90", VA = "0x182924A90")]
			internal NRZUVTJIBNZ LPEGABQLXUO(NRZUVTJIBNZ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NRZUVTJIBNZ PJMNVAEOESI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override NRZUVTJIBNZ QCBTDZDYDST
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<NRZUVTJIBNZ> ACOQXYRWFWT
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool ADMYCYZXVSG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2925130", Offset = "0x2924330", VA = "0x182925130", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2924B40", Offset = "0x2923D40", VA = "0x182924B40", Slot = "9")]
		public sealed override NRZUVTJIBNZ IREZWXNTQHO(IReadOnlyDictionary<string, NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2924D90", Offset = "0x2923F90", VA = "0x182924D90", Slot = "11")]
		public sealed override void TQDXKJSPQZS(Action<NRZUVTJIBNZ> a, Action<NRZUVTJIBNZ> b, Action<NRZUVTJIBNZ> c, Action<NRZUVTJIBNZ> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2925240", Offset = "0x2924440", VA = "0x182925240")]
		private HMXDRHPONDM(NRZUVTJIBNZ a, IEnumerable<NRZUVTJIBNZ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2924D10", Offset = "0x2923F10", VA = "0x182924D10")]
		public static HMXDRHPONDM New(NRZUVTJIBNZ originalType, IEnumerable<NRZUVTJIBNZ> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2924FF0", Offset = "0x29241F0", VA = "0x182924FF0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x29250D0", Offset = "0x29242D0", VA = "0x1829250D0", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2925030", Offset = "0x2924230", VA = "0x182925030")]
		public bool VNLJEVZERES([In] HMXDRHPONDM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2924B20", Offset = "0x2923D20", VA = "0x182924B20", Slot = "18")]
		public bool Equals(HMXDRHPONDM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2924AD0", Offset = "0x2923CD0", VA = "0x182924AD0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2924C60", Offset = "0x2923E60", VA = "0x182924C60", Slot = "14")]
		protected override int NRAEYZKAVZZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2925120", Offset = "0x2924320", VA = "0x182925120", Slot = "19")]
		private bool YPIDIMKQMST([In] HMXDRHPONDM other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class NLEAKIFWHEF : NRZUVTJIBNZ, IEquatable<NLEAKIFWHEF>, YTDJCTQVIZN<NLEAKIFWHEF>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2929660", Offset = "0x2928860", VA = "0x182929660")]
		private NLEAKIFWHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x29294B0", Offset = "0x29286B0", VA = "0x1829294B0")]
		public static NLEAKIFWHEF New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2929520", Offset = "0x2928720", VA = "0x182929520", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2929580", Offset = "0x2928780", VA = "0x182929580", Slot = "15")]
		public sealed override string UFZUMNHAJBK(IReadOnlyList<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2929420", Offset = "0x2928620", VA = "0x182929420")]
		private static string DLDXJLEKMHQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2929610", Offset = "0x2928810", VA = "0x182929610", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0")]
		public bool VNLJEVZERES([In] NLEAKIFWHEF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD00770", Offset = "0xCFF970", VA = "0x180D00770", Slot = "18")]
		public bool Equals(NLEAKIFWHEF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2929460", Offset = "0x2928660", VA = "0x182929460", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0", Slot = "19")]
		private bool PUVHCFBSTBA([In] NLEAKIFWHEF other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class IDORJCCIGRQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KZUDVNTIBMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public NRZUVTJIBNZ SBIXSWKCCJQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<NRZUVTJIBNZ, HMXDRHPONDM> CYAEOPJDHLY;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public KZUDVNTIBMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x29285C0", Offset = "0x29277C0", VA = "0x1829285C0")]
			internal HMXDRHPONDM SCXXOVMKYSK(NRZUVTJIBNZ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class KZOWYGZKSAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public NRZUVTJIBNZ MTYXUQCINZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<NRZUVTJIBNZ, HMXDRHPONDM> YPWAGYGQNRI;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public KZOWYGZKSAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2928440", Offset = "0x2927640", VA = "0x182928440")]
			internal HMXDRHPONDM SAIGBFVBQJQ(NRZUVTJIBNZ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x29262C0", Offset = "0x29254C0", VA = "0x1829262C0")]
		public static IEnumerable<OJOXJTZCBAY> KPUINRPSRPA(this OJOXJTZCBAY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x29280F0", Offset = "0x29272F0", VA = "0x1829280F0")]
		private static IEnumerable<OJOXJTZCBAY> WTTSULHZNSY(this OJOXJTZCBAY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2926100", Offset = "0x2925300", VA = "0x182926100")]
		public static (NRZUVTJIBNZ, IReadOnlyList<NRZUVTJIBNZ>, bool) ILGMNIMKCIW(this NRZUVTJIBNZ a, [Optional] IReadOnlyList<NRZUVTJIBNZ> b)
		{
			return default((NRZUVTJIBNZ, IReadOnlyList<NRZUVTJIBNZ>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x29280C0", Offset = "0x29272C0", VA = "0x1829280C0")]
		public static TypeKind VXDQMGDROZP(this NRZUVTJIBNZ a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2925350", Offset = "0x2924550", VA = "0x182925350")]
		private static NRZUVTJIBNZ ConvertClassesToIntersections(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2925DF0", Offset = "0x2924FF0", VA = "0x182925DF0")]
		private static NRZUVTJIBNZ DistributeUnionIntoIntersection(this HMXDRHPONDM self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2925980", Offset = "0x2924B80", VA = "0x182925980")]
		private static NRZUVTJIBNZ DistributeIntersectionIntoIntersection(this HMXDRHPONDM self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2925C90", Offset = "0x2924E90", VA = "0x182925C90")]
		private static NRZUVTJIBNZ DistributeIntoIntersection(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x29264E0", Offset = "0x29256E0", VA = "0x1829264E0")]
		private static bool OtherIsAssignableToOther(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes, NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2927940", Offset = "0x2926B40", VA = "0x182927940")]
		private static bool UnionIsAssignableToOther(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes, NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2926670", Offset = "0x2925870", VA = "0x182926670")]
		private static bool OtherIsAssignableToUnion(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes, NRZUVTJIBNZ union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2927C60", Offset = "0x2926E60", VA = "0x182927C60")]
		private static bool UnionIsAssignableToUnion(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes, NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x29276B0", Offset = "0x29268B0", VA = "0x1829276B0")]
		public static NRZUVTJIBNZ RemoveCommonTypesFromIntersectionDistribution(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2926A10", Offset = "0x2925C10", VA = "0x182926A10")]
		public static NRZUVTJIBNZ RemoveCommonTypesFromIntersectionDistributionInternal(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x29277E0", Offset = "0x29269E0", VA = "0x1829277E0")]
		public static NRZUVTJIBNZ SimplifyIntersectionUnion(this NRZUVTJIBNZ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2925300", Offset = "0x2924500", VA = "0x182925300")]
		public static IEnumerable<NRZUVTJIBNZ> ACOQXYRWFWT(this NRZUVTJIBNZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x29278B0", Offset = "0x2926AB0", VA = "0x1829278B0")]
		public static IEnumerable<NRZUVTJIBNZ> UEURIEXLOVG(this NRZUVTJIBNZ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class OJOXJTZCBAY : UCWIVKQOIVX, IEquatable<OJOXJTZCBAY>, YTDJCTQVIZN<OJOXJTZCBAY>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class WHMWEEMTEOL : IEnumerable<OJOXJTZCBAY>, IEnumerable, IEnumerator<OJOXJTZCBAY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private OJOXJTZCBAY HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public OJOXJTZCBAY LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<OJOXJTZCBAY> XORIMGFAPUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private OJOXJTZCBAY GOYDRHHSUUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<OJOXJTZCBAY> XPBWGTSVIRQ;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private OJOXJTZCBAY ZBCBEKYQFDR
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public WHMWEEMTEOL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x292ED10", Offset = "0x292DF10", VA = "0x18292ED10", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x292EE60", Offset = "0x292E060", VA = "0x18292EE60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x292F270", Offset = "0x292E470", VA = "0x18292F270")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x292F220", Offset = "0x292E420", VA = "0x18292F220")]
			private void RJYPYWGNHOQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x292F2C0", Offset = "0x292E4C0", VA = "0x18292F2C0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x292EC70", Offset = "0x292DE70", VA = "0x18292EC70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<OJOXJTZCBAY> CXMBLSOGOQI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x292EC70", Offset = "0x292DE70", VA = "0x18292EC70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> CKUBCLONUGI;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, OJOXJTZCBAY> VBXHYORSEUF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, OJOXJTZCBAY> ITZJVXTGVXT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x292AC80", Offset = "0x2929E80", VA = "0x18292AC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? EYTBNMJXXWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid LYEFCWKIZSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD052E0", Offset = "0xD044E0", VA = "0x180D052E0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD05730", Offset = "0xD04930", VA = "0x180D05730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xABE640", Offset = "0xABD840", VA = "0x180ABE640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<OJOXJTZCBAY> YZWUFLUNQPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAB92F0", Offset = "0xAB84F0", VA = "0x180AB92F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<OJOXJTZCBAY> WVQHYFNYVDU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x292A5D0", Offset = "0x29297D0", VA = "0x18292A5D0")]
			[IteratorStateMachine(typeof(WHMWEEMTEOL))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> MANSZKMMOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xABC9A0", Offset = "0xABBBA0", VA = "0x180ABC9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xABC960", Offset = "0xABBB60", VA = "0x180ABC960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, TSVJSKUUXLC> MAFPVQWXWIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xABCB70", Offset = "0xABBD70", VA = "0x180ABCB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xABC980", Offset = "0xABBB80", VA = "0x180ABC980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x292B1C0", Offset = "0x292A3C0", VA = "0x18292B1C0")]
		public OJOXJTZCBAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x292B110", Offset = "0x292A310", VA = "0x18292B110")]
		public OJOXJTZCBAY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x292A3A0", Offset = "0x29295A0", VA = "0x18292A3A0")]
		public static OJOXJTZCBAY LJFNDBTXUDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x292AAC0", Offset = "0x2929CC0", VA = "0x18292AAC0")]
		public static OJOXJTZCBAY VHQLUPGQYMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x292A1B0", Offset = "0x29293B0", VA = "0x18292A1B0")]
		public void Initialize(OJOXJTZCBAY from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x292AE70", Offset = "0x292A070", VA = "0x18292AE70")]
		private OJOXJTZCBAY([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<ZGNJGYIDZNF> c, [Optional] IEnumerable<OJOXJTZCBAY> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, TSVJSKUUXLC>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x292A500", Offset = "0x2929700", VA = "0x18292A500")]
		public static OJOXJTZCBAY New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<ZGNJGYIDZNF> typeParameters, [Optional] IEnumerable<OJOXJTZCBAY> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, TSVJSKUUXLC>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x292A900", Offset = "0x2929B00", VA = "0x18292A900", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x292A0D0", Offset = "0x29292D0", VA = "0x18292A0D0")]
		private string CLMLGUVRARR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x292ACD0", Offset = "0x2929ED0", VA = "0x18292ACD0")]
		private static string ZQQIGYFNDPS(IEnumerable<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2929E20", Offset = "0x2929020", VA = "0x182929E20")]
		private string APYJGISZMSD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x292A650", Offset = "0x2929850", VA = "0x18292A650")]
		private string TVPOVCKUCUC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x292A9F0", Offset = "0x2929BF0", VA = "0x18292A9F0", Slot = "15")]
		public sealed override string UFZUMNHAJBK(IReadOnlyList<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x292AC30", Offset = "0x2929E30", VA = "0x18292AC30", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x292AB10", Offset = "0x2929D10", VA = "0x18292AB10")]
		public bool VNLJEVZERES([In] OJOXJTZCBAY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x292A180", Offset = "0x2929380", VA = "0x18292A180", Slot = "18")]
		public bool Equals(OJOXJTZCBAY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x292A130", Offset = "0x2929330", VA = "0x18292A130", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x292A3F0", Offset = "0x29295F0", VA = "0x18292A3F0", Slot = "14")]
		protected override int NRAEYZKAVZZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x292A1A0", Offset = "0x29293A0", VA = "0x18292A1A0", Slot = "19")]
		private bool HSUYTCWAQJB([In] OJOXJTZCBAY other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class QYTYLGMTYSF
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<NRZUVTJIBNZ> ANETLTAOCXO;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<OJOXJTZCBAY> KMMTVYOJWQB;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, ZGNJGYIDZNF> DAEAIOXDHMA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> UAUHSMYYGRS;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, TSVJSKUUXLC> OHBDOFFYPKJ;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class RHMGRFYKWTC : IEquatable<RHMGRFYKWTC>, YTDJCTQVIZN<RHMGRFYKWTC>, DHPTPBHEZAS
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NRZUVTJIBNZ OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		private RHMGRFYKWTC(NRZUVTJIBNZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x292BCD0", Offset = "0x292AED0", VA = "0x18292BCD0")]
		public static RHMGRFYKWTC New(NRZUVTJIBNZ type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28DDC30", Offset = "0x28DCE30", VA = "0x1828DDC30", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x292BC80", Offset = "0x292AE80", VA = "0x18292BC80")]
		public bool VNLJEVZERES([In] RHMGRFYKWTC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x292BBE0", Offset = "0x292ADE0", VA = "0x18292BBE0", Slot = "4")]
		public bool Equals(RHMGRFYKWTC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x292BC30", Offset = "0x292AE30", VA = "0x18292BC30", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28FD2D0", Offset = "0x28FC4D0", VA = "0x1828FD2D0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x292BD30", Offset = "0x292AF30", VA = "0x18292BD30", Slot = "6")]
		public int QDRIJESPZBN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x292BC80", Offset = "0x292AE80", VA = "0x18292BC80", Slot = "5")]
		private bool LWGAEXFNTTN([In] RHMGRFYKWTC other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class TORQBLMELZD : IEquatable<TORQBLMELZD>, YTDJCTQVIZN<TORQBLMELZD>, DHPTPBHEZAS
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NRZUVTJIBNZ OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		private TORQBLMELZD(NRZUVTJIBNZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x292BDB0", Offset = "0x292AFB0", VA = "0x18292BDB0")]
		public static TORQBLMELZD New(NRZUVTJIBNZ type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28DDC30", Offset = "0x28DCE30", VA = "0x1828DDC30", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x292BC80", Offset = "0x292AE80", VA = "0x18292BC80")]
		public bool VNLJEVZERES([In] TORQBLMELZD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x292BBE0", Offset = "0x292ADE0", VA = "0x18292BBE0", Slot = "4")]
		public bool Equals(TORQBLMELZD other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x292BD60", Offset = "0x292AF60", VA = "0x18292BD60", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28FD2D0", Offset = "0x28FC4D0", VA = "0x1828FD2D0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x292BD30", Offset = "0x292AF30", VA = "0x18292BD30", Slot = "6")]
		public int QDRIJESPZBN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x292BC80", Offset = "0x292AE80", VA = "0x18292BC80", Slot = "5")]
		private bool UWABOWJVYXO([In] TORQBLMELZD other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class TSVJSKUUXLC : UCWIVKQOIVX, IEquatable<TSVJSKUUXLC>, YTDJCTQVIZN<TSVJSKUUXLC>, DHPTPBHEZAS
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, RHMGRFYKWTC>> IPKEBOMJKTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, TORQBLMELZD>> LOEUARIWFLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x292C860", Offset = "0x292BA60", VA = "0x18292C860")]
		private TSVJSKUUXLC(IEnumerable<ZGNJGYIDZNF> a, IEnumerable<KeyValuePair<string, RHMGRFYKWTC>> b, IEnumerable<KeyValuePair<string, TORQBLMELZD>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x292C170", Offset = "0x292B370", VA = "0x18292C170")]
		public static TSVJSKUUXLC New(IEnumerable<ZGNJGYIDZNF> typeParameters, IEnumerable<KeyValuePair<string, RHMGRFYKWTC>> inputs, IEnumerable<KeyValuePair<string, TORQBLMELZD>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x292C430", Offset = "0x292B630", VA = "0x18292C430", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2929CA0", Offset = "0x2928EA0", VA = "0x182929CA0", Slot = "15")]
		public sealed override string UFZUMNHAJBK(IReadOnlyList<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x292BF10", Offset = "0x292B110", VA = "0x18292BF10")]
		private string HYWXGIDGNJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x292C2B0", Offset = "0x292B4B0", VA = "0x18292C2B0")]
		private string TUBVHZRBJVQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x292C810", Offset = "0x292BA10", VA = "0x18292C810", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x292C730", Offset = "0x292B930", VA = "0x18292C730")]
		public bool VNLJEVZERES([In] TSVJSKUUXLC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x292BEF0", Offset = "0x292B0F0", VA = "0x18292BEF0", Slot = "18")]
		public bool Equals(TSVJSKUUXLC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x292BEA0", Offset = "0x292B0A0", VA = "0x18292BEA0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x292C090", Offset = "0x292B290", VA = "0x18292C090", Slot = "14")]
		protected sealed override int NRAEYZKAVZZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x292C2A0", Offset = "0x292B4A0", VA = "0x18292C2A0", Slot = "19")]
		private bool SJLMCPAHKXD([In] TSVJSKUUXLC other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class UGQBTBOMXWJ : NRZUVTJIBNZ, IEquatable<UGQBTBOMXWJ>, YTDJCTQVIZN<UGQBTBOMXWJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x292EC50", Offset = "0x292DE50", VA = "0x18292EC50")]
		private UGQBTBOMXWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x292E9D0", Offset = "0x292DBD0", VA = "0x18292E9D0")]
		public static UGQBTBOMXWJ New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x292EA90", Offset = "0x292DC90", VA = "0x18292EA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x292EAC0", Offset = "0x292DCC0", VA = "0x18292EAC0", Slot = "15")]
		public override string UFZUMNHAJBK(IReadOnlyList<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x292EC00", Offset = "0x292DE00", VA = "0x18292EC00", Slot = "16")]
		public override int XVZITEGYMPN(IReadOnlyList<NRZUVTJIBNZ> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x292EA40", Offset = "0x292DC40", VA = "0x18292EA40", Slot = "17")]
		public override bool ROHZLNRWFBI(IReadOnlyList<NRZUVTJIBNZ> a, IReadOnlyList<NRZUVTJIBNZ> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x292EBB0", Offset = "0x292DDB0", VA = "0x18292EBB0", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0")]
		public bool VNLJEVZERES([In] UGQBTBOMXWJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xD00770", Offset = "0xCFF970", VA = "0x180D00770", Slot = "18")]
		public bool Equals(UGQBTBOMXWJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x292E980", Offset = "0x292DB80", VA = "0x18292E980", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0", Slot = "19")]
		private bool KKSDPXNZZHK([In] UGQBTBOMXWJ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, YTDJCTQVIZN<Property>, DHPTPBHEZAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool UBXTHNSEYPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int GWHHIVYTRFJ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NRZUVTJIBNZ OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool UHQDZHTKEAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xC56780", Offset = "0xC55980", VA = "0x180C56780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool XVGNGSAOYPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xFFA810", Offset = "0xFF9A10", VA = "0x180FFA810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x292B9C0", Offset = "0x292ABC0", VA = "0x18292B9C0")]
		private Property(NRZUVTJIBNZ type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x292B630", Offset = "0x292A830", VA = "0x18292B630")]
		public static Property New(NRZUVTJIBNZ type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x292B790", Offset = "0x292A990", VA = "0x18292B790", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x292B970", Offset = "0x292AB70", VA = "0x18292B970")]
		private string WLKAYNUSICI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x292B530", Offset = "0x292A730", VA = "0x18292B530")]
		private string JAJIMKTOCOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x292B870", Offset = "0x292AA70", VA = "0x18292B870")]
		public bool VNLJEVZERES([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x292B450", Offset = "0x292A650", VA = "0x18292B450", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x292B400", Offset = "0x292A600", VA = "0x18292B400", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x292B470", Offset = "0x292A670", VA = "0x18292B470", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x292B580", Offset = "0x292A780", VA = "0x18292B580")]
		private int NRAEYZKAVZZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x292B6D0", Offset = "0x292A8D0", VA = "0x18292B6D0", Slot = "6")]
		public int QDRIJESPZBN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x292B6C0", Offset = "0x292A8C0", VA = "0x18292B6C0", Slot = "5")]
		private bool OYCXYZHUGIQ([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class PBMKPATSQPU : NRZUVTJIBNZ, IEquatable<PBMKPATSQPU>, YTDJCTQVIZN<PBMKPATSQPU>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x292B3E0", Offset = "0x292A5E0", VA = "0x18292B3E0")]
		private PBMKPATSQPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x292B270", Offset = "0x292A470", VA = "0x18292B270")]
		public static PBMKPATSQPU New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x292B2E0", Offset = "0x292A4E0", VA = "0x18292B2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x292B310", Offset = "0x292A510", VA = "0x18292B310", Slot = "15")]
		public override string UFZUMNHAJBK(IReadOnlyList<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x292B390", Offset = "0x292A590", VA = "0x18292B390", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0")]
		public bool VNLJEVZERES([In] PBMKPATSQPU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xD00770", Offset = "0xCFF970", VA = "0x180D00770", Slot = "18")]
		public bool Equals(PBMKPATSQPU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x292B220", Offset = "0x292A420", VA = "0x18292B220", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0", Slot = "19")]
		private bool BHOPPKXOQSF([In] PBMKPATSQPU other)
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
	public sealed class KNJUVLSHGNW : NRZUVTJIBNZ, IEquatable<KNJUVLSHGNW>, YTDJCTQVIZN<KNJUVLSHGNW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool ADMYCYZXVSG
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2928200", Offset = "0x2927400", VA = "0x182928200", Slot = "9")]
		public sealed override NRZUVTJIBNZ IREZWXNTQHO(IReadOnlyDictionary<string, NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2928380", Offset = "0x2927580", VA = "0x182928380", Slot = "11")]
		public sealed override void TQDXKJSPQZS(Action<NRZUVTJIBNZ> a, Action<NRZUVTJIBNZ> b, Action<NRZUVTJIBNZ> c, Action<NRZUVTJIBNZ> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2928400", Offset = "0x2927600", VA = "0x182928400")]
		private KNJUVLSHGNW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2928300", Offset = "0x2927500", VA = "0x182928300")]
		public static KNJUVLSHGNW New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x29283B0", Offset = "0x29275B0", VA = "0x1829283B0", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0")]
		public bool VNLJEVZERES([In] KNJUVLSHGNW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xD00770", Offset = "0xCFF970", VA = "0x180D00770", Slot = "18")]
		public bool Equals(KNJUVLSHGNW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x29281B0", Offset = "0x29273B0", VA = "0x1829281B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x29282E0", Offset = "0x29274E0", VA = "0x1829282E0", Slot = "14")]
		protected sealed override int NRAEYZKAVZZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0", Slot = "19")]
		private bool YMGOGSSBESB([In] KNJUVLSHGNW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class UCWIVKQOIVX : NRZUVTJIBNZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<ZGNJGYIDZNF> WJIFCAPRMEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7360", VA = "0x180AB8160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x292E780", Offset = "0x292D980", VA = "0x18292E780")]
		public void Initialize(UCWIVKQOIVX from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x292E910", Offset = "0x292DB10", VA = "0x18292E910")]
		protected UCWIVKQOIVX(IEnumerable<ZGNJGYIDZNF> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool VNLJEVZERES([In] NRZUVTJIBNZ other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x292E8B0", Offset = "0x292DAB0", VA = "0x18292E8B0")]
		protected bool VNLJEVZERES([In] UCWIVKQOIVX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x292E830", Offset = "0x292DA30", VA = "0x18292E830", Slot = "14")]
		protected override int NRAEYZKAVZZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x292E7B0", Offset = "0x292D9B0", VA = "0x18292E7B0")]
		protected int KVLDUHCPFXX(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class ZGNJGYIDZNF : NRZUVTJIBNZ, IEquatable<ZGNJGYIDZNF>, YTDJCTQVIZN<ZGNJGYIDZNF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string TEJXEWDXJRB
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public NRZUVTJIBNZ VWFNFFTYMMT
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x292FA00", Offset = "0x292EC00", VA = "0x18292FA00")]
		private ZGNJGYIDZNF(string a, [Optional] NRZUVTJIBNZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x292F760", Offset = "0x292E960", VA = "0x18292F760")]
		public static ZGNJGYIDZNF New(string name, [Optional] NRZUVTJIBNZ constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x292F8D0", Offset = "0x292EAD0", VA = "0x18292F8D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x292F960", Offset = "0x292EB60", VA = "0x18292F960", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x292F9B0", Offset = "0x292EBB0", VA = "0x18292F9B0")]
		public bool VNLJEVZERES([In] ZGNJGYIDZNF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x292F640", Offset = "0x292E840", VA = "0x18292F640", Slot = "18")]
		public bool Equals(ZGNJGYIDZNF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x292F690", Offset = "0x292E890", VA = "0x18292F690", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x292F6E0", Offset = "0x292E8E0", VA = "0x18292F6E0", Slot = "14")]
		protected override int NRAEYZKAVZZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x292F860", Offset = "0x292EA60", VA = "0x18292F860", Slot = "13")]
		public override int QDRIJESPZBN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x292F9B0", Offset = "0x292EBB0", VA = "0x18292F9B0", Slot = "19")]
		private bool XLWEMCNXVAE([In] ZGNJGYIDZNF other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class ENYXWBBZFQH : NRZUVTJIBNZ, IEquatable<ENYXWBBZFQH>, YTDJCTQVIZN<ENYXWBBZFQH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2924A70", Offset = "0x2923C70", VA = "0x182924A70")]
		private ENYXWBBZFQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x29247F0", Offset = "0x29239F0", VA = "0x1829247F0")]
		public static ENYXWBBZFQH New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x29248B0", Offset = "0x2923AB0", VA = "0x1829248B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x29248E0", Offset = "0x2923AE0", VA = "0x1829248E0", Slot = "15")]
		public override string UFZUMNHAJBK(IReadOnlyList<NRZUVTJIBNZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2924A20", Offset = "0x2923C20", VA = "0x182924A20", Slot = "16")]
		public override int XVZITEGYMPN(IReadOnlyList<NRZUVTJIBNZ> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2924860", Offset = "0x2923A60", VA = "0x182924860", Slot = "17")]
		public override bool ROHZLNRWFBI(IReadOnlyList<NRZUVTJIBNZ> a, IReadOnlyList<NRZUVTJIBNZ> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x29249D0", Offset = "0x2923BD0", VA = "0x1829249D0", Slot = "12")]
		public override bool VNLJEVZERES([In] NRZUVTJIBNZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0")]
		public bool VNLJEVZERES([In] ENYXWBBZFQH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xD00770", Offset = "0xCFF970", VA = "0x180D00770", Slot = "18")]
		public bool Equals(ENYXWBBZFQH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2924790", Offset = "0x2923990", VA = "0x182924790", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x29239E0", VA = "0x1829247E0", Slot = "19")]
		private bool NXTDGEYIJSY([In] ENYXWBBZFQH other)
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
			public readonly NRZUVTJIBNZ CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xE88080", Offset = "0xE87280", VA = "0x180E88080")]
			internal Impl(NRZUVTJIBNZ circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2923DC0", Offset = "0x2922FC0", VA = "0x182923DC0")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2923CF0", Offset = "0x2922EF0", VA = "0x182923CF0")]
		public static CircuitTypeOrString ZVBIEXBOOKH(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2923D60", Offset = "0x2922F60", VA = "0x182923D60")]
		public static CircuitTypeOrString ZVBIEXBOOKH(NRZUVTJIBNZ a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2923C50", Offset = "0x2922E50", VA = "0x182923C50")]
		public NRZUVTJIBNZ WKDVSTIDUWK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2923B30", Offset = "0x2922D30", VA = "0x182923B30")]
		public static NRZUVTJIBNZ[] KKMKCCUODRL(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly YBWMXJQVXLA _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		private ClassFactoryBaseClasses(YBWMXJQVXLA data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xE70900", Offset = "0xE6FB00", VA = "0x180E70900")]
		public static ClassFactoryBaseClasses New(YBWMXJQVXLA data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2923DF0", Offset = "0x2922FF0", VA = "0x182923DF0")]
		public ClassFactoryBaseClasses OLMCJQLIYOM(OJOXJTZCBAY a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x160C440", Offset = "0x160B640", VA = "0x18160C440")]
		public ClassFactoryProps QEQMUIOOEQL()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2923EB0", Offset = "0x29230B0", VA = "0x182923EB0")]
		public ClassFactoryProps PLQAPAOLTKY(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2923F10", Offset = "0x2923110", VA = "0x182923F10")]
		public OJOXJTZCBAY QIOJAOPXSKN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class YBWMXJQVXLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? LYEFCWKIZSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string TEJXEWDXJRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<ZGNJGYIDZNF> WJIFCAPRMEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<OJOXJTZCBAY> YZWUFLUNQPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> MANSZKMMOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, TSVJSKUUXLC>> MAFPVQWXWIF;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x292F4B0", Offset = "0x292E6B0", VA = "0x18292F4B0")]
		private YBWMXJQVXLA([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x292F300", Offset = "0x292E500", VA = "0x18292F300")]
		public static YBWMXJQVXLA New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly YBWMXJQVXLA _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		private ClassFactoryFuncs(YBWMXJQVXLA data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xE70900", Offset = "0xE6FB00", VA = "0x180E70900")]
		public static ClassFactoryFuncs New(YBWMXJQVXLA data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2923F60", Offset = "0x2923160", VA = "0x182923F60")]
		public OJOXJTZCBAY QIOJAOPXSKN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly YBWMXJQVXLA _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		public ClassFactoryProps(YBWMXJQVXLA data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x29240B0", Offset = "0x29232B0", VA = "0x1829240B0")]
		public ClassFactoryProps PLQAPAOLTKY(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x160C440", Offset = "0x160B640", VA = "0x18160C440")]
		public ClassFactoryFuncs LQWBNUPSJHI()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2924240", Offset = "0x2923440", VA = "0x182924240")]
		public OJOXJTZCBAY QIOJAOPXSKN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly YBWMXJQVXLA _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		private ClassFactoryTypeParams(YBWMXJQVXLA data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2924280", Offset = "0x2923480", VA = "0x182924280")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2924490", Offset = "0x2923690", VA = "0x182924490")]
		public ClassFactoryTypeParams OTIORDKVIPU(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x160C440", Offset = "0x160B640", VA = "0x18160C440")]
		public ClassFactoryBaseClasses MDIVOKBJGSG()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2924450", Offset = "0x2923650", VA = "0x182924450")]
		public ClassFactoryBaseClasses OLMCJQLIYOM(OJOXJTZCBAY a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2924730", Offset = "0x2923930", VA = "0x182924730")]
		public OJOXJTZCBAY QIOJAOPXSKN()
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
