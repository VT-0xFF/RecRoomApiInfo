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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JFWWKSXUUGK : IEquatable<JFWWKSXUUGK>, GBMNYUSYUQI<JFWWKSXUUGK>, LNISVCHADRL
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool HZAHOLTAHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool CUMYGOICBUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int SRAMUISSXQE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind JNGPBCCCNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA95110", Offset = "0xA93D10", VA = "0x180A95110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA2D20", Offset = "0xAA1920", VA = "0x180AA2D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? UEUUKWVKDIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x28C8C10", Offset = "0x28C7810", VA = "0x1828C8C10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual JFWWKSXUUGK BOCCJNRAEDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool NLPIFHVNXDP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28C87C0", Offset = "0x28C73C0", VA = "0x1828C87C0")]
		public static void NXLLWCOSNCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
		protected JFWWKSXUUGK(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8850", Offset = "0x28C7450", VA = "0x1828C8850")]
		public static JFWWKSXUUGK New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
		protected static a HZOVHFERODQ<a>(a a) where a : JFWWKSXUUGK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960", Slot = "9")]
		public virtual JFWWKSXUUGK IVLKRNJIMPP(IReadOnlyDictionary<string, JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28C8790", Offset = "0x28C7390", VA = "0x1828C8790", Slot = "11")]
		public virtual void MYPPHTICBHZ(Action<JFWWKSXUUGK> a, Action<JFWWKSXUUGK> b, Action<JFWWKSXUUGK> c, Action<JFWWKSXUUGK> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28C8940", Offset = "0x28C7540", VA = "0x1828C8940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28C8520", Offset = "0x28C7120", VA = "0x1828C8520", Slot = "12")]
		public virtual bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28C8610", Offset = "0x28C7210", VA = "0x1828C8610", Slot = "4")]
		public bool Equals(JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28C85C0", Offset = "0x28C71C0", VA = "0x1828C85C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28C88C0", Offset = "0x28C74C0", VA = "0x1828C88C0")]
		public static bool OKWKXGGAXFT(JFWWKSXUUGK a, JFWWKSXUUGK b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28C8900", Offset = "0x28C7500", VA = "0x1828C8900")]
		public static bool QHJSFCGIZAO(JFWWKSXUUGK a, JFWWKSXUUGK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28C8690", Offset = "0x28C7290", VA = "0x1828C8690", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28C8760", Offset = "0x28C7360", VA = "0x1828C8760", Slot = "13")]
		public virtual int VMDFWORFIKC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28C8760", Offset = "0x28C7360", VA = "0x1828C8760", Slot = "14")]
		protected virtual int JEZZFSCWJXQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3721440", Offset = "0x3720040", VA = "0x183721440")]
		public b TXIJRCMJOVG<b>() where b : JFWWKSXUUGK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28C8740", Offset = "0x28C7340", VA = "0x1828C8740", Slot = "15")]
		public virtual string HVAHHEZFAAT(IReadOnlyList<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8640", Offset = "0x28C7240", VA = "0x1828C8640", Slot = "16")]
		public virtual int GCDAXPTWRKQ(IReadOnlyList<JFWWKSXUUGK> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28C8C80", Offset = "0x28C7880", VA = "0x1828C8C80", Slot = "17")]
		public virtual bool YIFNZJBWUDT(IReadOnlyList<JFWWKSXUUGK> a, IReadOnlyList<JFWWKSXUUGK> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28C8AC0", Offset = "0x28C76C0", VA = "0x1828C8AC0")]
		public EEBTCGHBHYR XFUJPYPYKTZ(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28C8AB0", Offset = "0x28C76B0", VA = "0x1828C8AB0")]
		public EEBTCGHBHYR XFUJPYPYKTZ(params JFWWKSXUUGK[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28C8AB0", Offset = "0x28C76B0", VA = "0x1828C8AB0")]
		public EEBTCGHBHYR XFUJPYPYKTZ(IEnumerable<JFWWKSXUUGK> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface LGUBDHHAHFH<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a OGQCSCTWJBZ(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b VOSEEDGPEQB([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind EXVFAEXBJNF([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates MNEMFNCTKJM(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LNISVCHADRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int VMDFWORFIKC(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class VMDFWORFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class TCVNAJKYADE<a> where a : LNISVCHADRL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int ZAAHIKPMUEX;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TCVNAJKYADE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E15270", Offset = "0x5E13E70", VA = "0x185E15270")]
			internal int CVFXGHJKITZ(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GMWDUQZAJFG<a, b> where b : LNISVCHADRL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int ZAAHIKPMUEX;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public GMWDUQZAJFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4D964D0", Offset = "0x4D950D0", VA = "0x184D964D0")]
			internal int CVFXGHJKITZ(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class JSGWOLZEVUM<a> where a : LNISVCHADRL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int ZAAHIKPMUEX;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public JSGWOLZEVUM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5068640", Offset = "0x5067240", VA = "0x185068640")]
			internal int PNBDQQPDNAY(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF0F0", Offset = "0x3BCDCF0", VA = "0x183BCF0F0")]
		public static int NPEOLIDIUOZ<a>(this IEnumerable<a> a, int b = 0) where a : LNISVCHADRL
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF1C0", Offset = "0x3BCDDC0", VA = "0x183BCF1C0")]
		public static int NPEOLIDIUOZ<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : LNISVCHADRL
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF0F0", Offset = "0x3BCDCF0", VA = "0x183BCF0F0")]
		public static int LGDEIKLSXIQ<d>(this IEnumerable<d> a, int b = 0) where d : LNISVCHADRL
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : LGUBDHHAHFH<TDirectedType, JFWWKSXUUGK, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3FFF010", Offset = "0x3FFDC10", VA = "0x183FFF010")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FEEBC0", Offset = "0x5FED7C0", VA = "0x185FEEBC0")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class NCLRCYUVTLK
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PWTVBFVDLBK<a, b, c> where c : LGUBDHHAHFH<a, JFWWKSXUUGK, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public JFWWKSXUUGK GOHNRIYECHW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<JFWWKSXUUGK> SOLPPOXZOHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public JFWWKSXUUGK YLNNOAVFZLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<JFWWKSXUUGK> SETCFNHOKGI;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public PWTVBFVDLBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x59E4D50", Offset = "0x59E3950", VA = "0x1859E4D50")]
			internal bool FCWMPGZNZPE([In] TypeSys<a, b, c> self_, JFWWKSXUUGK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x59E4B40", Offset = "0x59E3740", VA = "0x1859E4B40")]
			internal bool FCRFSAFQQDV([In] TypeSys<a, b, c> self_, JFWWKSXUUGK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x59E4E80", Offset = "0x59E3A80", VA = "0x1859E4E80")]
			internal bool FDROEIBDLIO([In] TypeSys<a, b, c> self_, JFWWKSXUUGK a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class GPQPMGDNJNF<a, b, c> where c : LGUBDHHAHFH<a, JFWWKSXUUGK, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public JFWWKSXUUGK JGUJWRTVVOS;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public GPQPMGDNJNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4D9D850", Offset = "0x4D9C450", VA = "0x184D9D850")]
			internal bool FDWVBOVAUTX([In] TypeSys<a, b, c> self__, JFWWKSXUUGK a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class UTNWWTHWKLE<a, b, c> where c : LGUBDHHAHFH<a, JFWWKSXUUGK, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b CEBPHRDGBWL;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public UTNWWTHWKLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6033BC0", Offset = "0x60327C0", VA = "0x186033BC0")]
			internal JFWWKSXUUGK VTSRJWMBTER([In] TypeSys<a, b, c> self_, [In] b root_, JFWWKSXUUGK a, JFWWKSXUUGK b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class KLRJLFZWGPH<a, b, c> where c : LGUBDHHAHFH<a, JFWWKSXUUGK, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public TENELWVUMZX AXPHAKKBERQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TENELWVUMZX UKCXKXSWUTT;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KLRJLFZWGPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5163810", Offset = "0x5162410", VA = "0x185163810")]
			internal a VTCWSCEJQWQ([In] TypeSys<a, b, c> self_, IOKind a, TENELWVUMZX b, TENELWVUMZX c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class QBXAHNSTXOU<a, b, c> where c : LGUBDHHAHFH<a, JFWWKSXUUGK, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<TENELWVUMZX> PWSHSQHXQCZ;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public QBXAHNSTXOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5A45BF0", Offset = "0x5A447F0", VA = "0x185A45BF0")]
			internal bool JNSTYWMGUIG(bool a, TENELWVUMZX b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] YHJZXJOLJPT;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3871B60", Offset = "0x3870760", VA = "0x183871B60")]
		public static bool ORGWRJVFEQQ<a, b, c>([In] this TypeSys<a, b, c> _, JFWWKSXUUGK a) where c : LGUBDHHAHFH<a, JFWWKSXUUGK, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3871B40", Offset = "0x3870740", VA = "0x183871B40")]
		public static bool LYEZEIJJWNT<d, e, f>([In] this TypeSys<d, e, f> _, JFWWKSXUUGK a) where f : LGUBDHHAHFH<d, JFWWKSXUUGK, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3871B80", Offset = "0x3870780", VA = "0x183871B80")]
		public static bool PGJOCNTBOJR<g, h, i>([In] this TypeSys<g, h, i> self, JFWWKSXUUGK a, JFWWKSXUUGK b) where i : LGUBDHHAHFH<g, JFWWKSXUUGK, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x386FF90", Offset = "0x386EB90", VA = "0x18386FF90")]
		private static bool IOSSIZFJRXI<j, k, l>([In] this TypeSys<j, k, l> self, JFWWKSXUUGK a, JFWWKSXUUGK b, IReadOnlyList<JFWWKSXUUGK> c, IReadOnlyList<JFWWKSXUUGK> d) where l : LGUBDHHAHFH<j, JFWWKSXUUGK, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3874B50", Offset = "0x3873750", VA = "0x183874B50")]
		public static JFWWKSXUUGK QWMCQNIVLLO<m, n, o>([In] this TypeSys<m, n, o> self, n a, JFWWKSXUUGK b, JFWWKSXUUGK c) where o : LGUBDHHAHFH<m, JFWWKSXUUGK, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3871D20", Offset = "0x3870920", VA = "0x183871D20")]
		public static p QWMCQNIVLLO<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : LGUBDHHAHFH<p, JFWWKSXUUGK, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3879EE0", Offset = "0x3878AE0", VA = "0x183879EE0")]
		private static List<w> WTUWJCLAXBI<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : LGUBDHHAHFH<t, JFWWKSXUUGK, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x38719A0", Offset = "0x38705A0", VA = "0x1838719A0")]
		private static ba LOBQODTDXMQ<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class HFQMKIZLWMD
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JFWWKSXUUGK FCMSHXOTWKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x28C7E10", Offset = "0x28C6A10", VA = "0x1828C7E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static JFWWKSXUUGK ZUMOQGPEGHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x28C7750", Offset = "0x28C6350", VA = "0x1828C7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static JFWWKSXUUGK FAIXJSGAMDX
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x28C7840", Offset = "0x28C6440", VA = "0x1828C7840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static JFWWKSXUUGK KMSUPTLOCFD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28C77A0", Offset = "0x28C63A0", VA = "0x1828C77A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static JFWWKSXUUGK RHXVMCLEWHL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28C77F0", Offset = "0x28C63F0", VA = "0x1828C77F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static JFWWKSXUUGK CQDSIXGXKGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x28C7DC0", Offset = "0x28C69C0", VA = "0x1828C7DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static JFWWKSXUUGK KMNXGOPKMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28C7EB0", Offset = "0x28C6AB0", VA = "0x1828C7EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static JFWWKSXUUGK EETCULMSLUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28C7E60", Offset = "0x28C6A60", VA = "0x1828C7E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x28C7F00", Offset = "0x28C6B00", VA = "0x1828C7F00")]
		public static EEBTCGHBHYR YQMCFOCYVGR([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x28C7890", Offset = "0x28C6490", VA = "0x1828C7890")]
		public static EEBTCGHBHYR NBFXJEJFIEJ(IEnumerable<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28C7B80", Offset = "0x28C6780", VA = "0x1828C7B80")]
		public static EEBTCGHBHYR RTHBHQXTKTN(IEnumerable<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28C7C10", Offset = "0x28C6810", VA = "0x1828C7C10")]
		public static EEBTCGHBHYR RTHBHQXTKTN(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28C7920", Offset = "0x28C6520", VA = "0x1828C7920")]
		public static EEBTCGHBHYR QPGLDCQIGGG(IEnumerable<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28C79B0", Offset = "0x28C65B0", VA = "0x1828C79B0")]
		public static SHINXXVMWXA RHEVRXUQYSR(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class EEBTCGHBHYR : JFWWKSXUUGK, IEquatable<EEBTCGHBHYR>, GBMNYUSYUQI<EEBTCGHBHYR>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class XYQPMXZJXMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, JFWWKSXUUGK> WETTFFNYIQH;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XYQPMXZJXMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x28CF190", Offset = "0x28CDD90", VA = "0x1828CF190")]
			internal JFWWKSXUUGK VQWDZHFQVCT(JFWWKSXUUGK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JFWWKSXUUGK OUQBTUTJEAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override JFWWKSXUUGK BOCCJNRAEDW
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<JFWWKSXUUGK> DVOKGRXQZDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool NLPIFHVNXDP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28C72A0", Offset = "0x28C5EA0", VA = "0x1828C72A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28C6E70", Offset = "0x28C5A70", VA = "0x1828C6E70", Slot = "9")]
		public sealed override JFWWKSXUUGK IVLKRNJIMPP(IReadOnlyDictionary<string, JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28C7040", Offset = "0x28C5C40", VA = "0x1828C7040", Slot = "11")]
		public sealed override void MYPPHTICBHZ(Action<JFWWKSXUUGK> a, Action<JFWWKSXUUGK> b, Action<JFWWKSXUUGK> c, Action<JFWWKSXUUGK> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28C7490", Offset = "0x28C6090", VA = "0x1828C7490")]
		private EEBTCGHBHYR(JFWWKSXUUGK a, IEnumerable<JFWWKSXUUGK> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28C73C0", Offset = "0x28C5FC0", VA = "0x1828C73C0")]
		public static EEBTCGHBHYR New(JFWWKSXUUGK originalType, IEnumerable<JFWWKSXUUGK> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28C7450", Offset = "0x28C6050", VA = "0x1828C7450", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28C6D10", Offset = "0x28C5910", VA = "0x1828C6D10", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28C6D60", Offset = "0x28C5960", VA = "0x1828C6D60")]
		public bool BQMHWPIWXMR([In] EEBTCGHBHYR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28C6E50", Offset = "0x28C5A50", VA = "0x1828C6E50", Slot = "18")]
		public bool Equals(EEBTCGHBHYR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28C6E00", Offset = "0x28C5A00", VA = "0x1828C6E00", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28C6F90", Offset = "0x28C5B90", VA = "0x1828C6F90", Slot = "14")]
		protected override int JEZZFSCWJXQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28C7440", Offset = "0x28C6040", VA = "0x1828C7440", Slot = "19")]
		private bool PCKQOTNFCMU([In] EEBTCGHBHYR other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class QUBOJSROGYE : JFWWKSXUUGK, IEquatable<QUBOJSROGYE>, GBMNYUSYUQI<QUBOJSROGYE>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6B0", Offset = "0x28C92B0", VA = "0x1828CA6B0")]
		private QUBOJSROGYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28CA5A0", Offset = "0x28C91A0", VA = "0x1828CA5A0")]
		public static QUBOJSROGYE New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28CA610", Offset = "0x28C9210", VA = "0x1828CA610", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28CA510", Offset = "0x28C9110", VA = "0x1828CA510", Slot = "15")]
		public sealed override string HVAHHEZFAAT(IReadOnlyList<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28CA670", Offset = "0x28C9270", VA = "0x1828CA670")]
		private static string VZWQHEBHQVD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28CA470", Offset = "0x28C9070", VA = "0x1828CA470", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0")]
		public bool BQMHWPIWXMR([In] QUBOJSROGYE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xC720E0", Offset = "0xC70CE0", VA = "0x180C720E0", Slot = "18")]
		public bool Equals(QUBOJSROGYE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28CA4C0", Offset = "0x28C90C0", VA = "0x1828CA4C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0", Slot = "19")]
		private bool QWALDEKQAUP([In] QUBOJSROGYE other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class YMWADPANFEB
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public JFWWKSXUUGK FJZPEVCYGUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<JFWWKSXUUGK, EEBTCGHBHYR> HWRFHGJIZTP;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x28CAB50", Offset = "0x28C9750", VA = "0x1828CAB50")]
			internal EEBTCGHBHYR KTXBCPZIVMP(JFWWKSXUUGK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class TCAVWYNZTHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public JFWWKSXUUGK ZRYKVMLXELX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<JFWWKSXUUGK, EEBTCGHBHYR> RZSQDFIPJDB;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TCAVWYNZTHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x28CACD0", Offset = "0x28C98D0", VA = "0x1828CACD0")]
			internal EEBTCGHBHYR OSAOOGKSKUZ(JFWWKSXUUGK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28D1F40", Offset = "0x28D0B40", VA = "0x1828D1F40")]
		public static IEnumerable<TENELWVUMZX> XYKMEMSKNGN(this TENELWVUMZX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28D1E80", Offset = "0x28D0A80", VA = "0x1828D1E80")]
		private static IEnumerable<TENELWVUMZX> WASVXHUFLDN(this TENELWVUMZX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28D0060", Offset = "0x28CEC60", VA = "0x1828D0060")]
		public static (JFWWKSXUUGK, IReadOnlyList<JFWWKSXUUGK>, bool) KKHRIAXHJKV(this JFWWKSXUUGK a, [Optional] IReadOnlyList<JFWWKSXUUGK> b)
		{
			return default((JFWWKSXUUGK, IReadOnlyList<JFWWKSXUUGK>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x28CF1D0", Offset = "0x28CDDD0", VA = "0x1828CF1D0")]
		public static TypeKind AIMIOVKSFWW(this JFWWKSXUUGK a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28CF200", Offset = "0x28CDE00", VA = "0x1828CF200")]
		private static JFWWKSXUUGK ConvertClassesToIntersections(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28CFD30", Offset = "0x28CE930", VA = "0x1828CFD30")]
		private static JFWWKSXUUGK DistributeUnionIntoIntersection(this EEBTCGHBHYR self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28CF8A0", Offset = "0x28CE4A0", VA = "0x1828CF8A0")]
		private static JFWWKSXUUGK DistributeIntersectionIntoIntersection(this EEBTCGHBHYR self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28CFBD0", Offset = "0x28CE7D0", VA = "0x1828CFBD0")]
		private static JFWWKSXUUGK DistributeIntoIntersection(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28D0230", Offset = "0x28CEE30", VA = "0x1828D0230")]
		private static bool OtherIsAssignableToOther(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes, JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x28D16E0", Offset = "0x28D02E0", VA = "0x1828D16E0")]
		private static bool UnionIsAssignableToOther(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes, JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28D03C0", Offset = "0x28CEFC0", VA = "0x1828D03C0")]
		private static bool OtherIsAssignableToUnion(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes, JFWWKSXUUGK union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28D1A10", Offset = "0x28D0610", VA = "0x1828D1A10")]
		private static bool UnionIsAssignableToUnion(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes, JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28D1450", Offset = "0x28D0050", VA = "0x1828D1450")]
		public static JFWWKSXUUGK RemoveCommonTypesFromIntersectionDistribution(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28D0770", Offset = "0x28CF370", VA = "0x1828D0770")]
		public static JFWWKSXUUGK RemoveCommonTypesFromIntersectionDistributionInternal(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28D1610", Offset = "0x28D0210", VA = "0x1828D1610")]
		public static JFWWKSXUUGK SimplifyIntersectionUnion(this JFWWKSXUUGK self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28CF850", Offset = "0x28CE450", VA = "0x1828CF850")]
		public static IEnumerable<JFWWKSXUUGK> DVOKGRXQZDG(this JFWWKSXUUGK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28D1580", Offset = "0x28D0180", VA = "0x1828D1580")]
		public static IEnumerable<JFWWKSXUUGK> SPUWZWBFEML(this JFWWKSXUUGK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class TENELWVUMZX : WWCDXGUFWOO, IEquatable<TENELWVUMZX>, GBMNYUSYUQI<TENELWVUMZX>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class MBRTIBLRQMQ : IEnumerable<TENELWVUMZX>, IEnumerable, IEnumerator<TENELWVUMZX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private TENELWVUMZX VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public TENELWVUMZX BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<TENELWVUMZX> KYBQTQIMGAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TENELWVUMZX OVMPBTOAGMU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<TENELWVUMZX> KYMEODWGYXD;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private TENELWVUMZX BUHLXNQSWHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public MBRTIBLRQMQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x28C97A0", Offset = "0x28C83A0", VA = "0x1828C97A0", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x28C9300", Offset = "0x28C7F00", VA = "0x1828C9300", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x28C9260", Offset = "0x28C7E60", VA = "0x1828C9260")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x28C92B0", Offset = "0x28C7EB0", VA = "0x1828C92B0")]
			private void LTHDVLZCRLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x28C9760", Offset = "0x28C8360", VA = "0x1828C9760", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x28C96C0", Offset = "0x28C82C0", VA = "0x1828C96C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<TENELWVUMZX> WBZXCMKXEBJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x28C96C0", Offset = "0x28C82C0", VA = "0x1828C96C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> ZMNBJWTZXMJ;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, TENELWVUMZX> JVNZBJSXNCC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, TENELWVUMZX> DUWJUOQCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x28CB770", Offset = "0x28CA370", VA = "0x1828CB770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? UEUUKWVKDIU
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid HSLXDBEEAPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xC5CCD0", Offset = "0xC5B8D0", VA = "0x180C5CCD0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xC5CCC0", Offset = "0xC5B8C0", VA = "0x180C5CCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string XPPEXRAPNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9F800", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA98C60", Offset = "0xA97860", VA = "0x180A98C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<TENELWVUMZX> GUDAAGULMRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA988A0", Offset = "0xA974A0", VA = "0x180A988A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<TENELWVUMZX> TGVDXHTTCFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x28CB030", Offset = "0x28C9C30", VA = "0x1828CB030")]
			[IteratorStateMachine(typeof(MBRTIBLRQMQ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> IOHNNEJGHXM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5C0", Offset = "0xA991C0", VA = "0x180A9A5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5B0", Offset = "0xA991B0", VA = "0x180A9A5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, VRZQZUJBTYL> HFFQJDBBXNW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5A0", Offset = "0xA991A0", VA = "0x180A9A5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA9A580", Offset = "0xA99180", VA = "0x180A9A580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28CBFC0", Offset = "0x28CABC0", VA = "0x1828CBFC0")]
		public TENELWVUMZX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28CBF10", Offset = "0x28CAB10", VA = "0x1828CBF10")]
		public TENELWVUMZX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28CBA30", Offset = "0x28CA630", VA = "0x1828CBA30")]
		public static TENELWVUMZX UELKFAMQOVY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28CB890", Offset = "0x28CA490", VA = "0x1828CB890")]
		public static TENELWVUMZX QYUARELVNVK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28CB190", Offset = "0x28C9D90", VA = "0x1828CB190")]
		public void Initialize(TENELWVUMZX from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28CC020", Offset = "0x28CAC20", VA = "0x1828CC020")]
		private TENELWVUMZX([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<SHINXXVMWXA> c, [Optional] IEnumerable<TENELWVUMZX> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, VRZQZUJBTYL>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28CB7C0", Offset = "0x28CA3C0", VA = "0x1828CB7C0")]
		public static TENELWVUMZX New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<SHINXXVMWXA> typeParameters, [Optional] IEnumerable<TENELWVUMZX> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, VRZQZUJBTYL>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28CB940", Offset = "0x28CA540", VA = "0x1828CB940", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28CB8E0", Offset = "0x28CA4E0", VA = "0x1828CB8E0")]
		private string TJAELOPLTWS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28CBD60", Offset = "0x28CA960", VA = "0x1828CBD60")]
		private static string WLDCNBRMLPZ(IEnumerable<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28CBA80", Offset = "0x28CA680", VA = "0x1828CBA80")]
		private string WIQREOLEHHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28CB4A0", Offset = "0x28CA0A0", VA = "0x1828CB4A0")]
		private string JXCDNVCKNAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28CB0C0", Offset = "0x28C9CC0", VA = "0x1828CB0C0", Slot = "15")]
		public sealed override string HVAHHEZFAAT(IReadOnlyList<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28CAE50", Offset = "0x28C9A50", VA = "0x1828CAE50", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28CAEA0", Offset = "0x28C9AA0", VA = "0x1828CAEA0")]
		public bool BQMHWPIWXMR([In] TENELWVUMZX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28CAFC0", Offset = "0x28C9BC0", VA = "0x1828CAFC0", Slot = "18")]
		public bool Equals(TENELWVUMZX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28CAFE0", Offset = "0x28C9BE0", VA = "0x1828CAFE0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x28CB390", Offset = "0x28C9F90", VA = "0x1828CB390", Slot = "14")]
		protected override int JEZZFSCWJXQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28CB0B0", Offset = "0x28C9CB0", VA = "0x1828CB0B0", Slot = "19")]
		private bool GDDVOJWDJKC([In] TENELWVUMZX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class NXNCOWLILVC
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<JFWWKSXUUGK> SSYHKOPXYBN;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<TENELWVUMZX> ZBSMXGDFPVY;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, SHINXXVMWXA> DQBYHQNGZAP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> PXETJDYEGHH;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, VRZQZUJBTYL> ZVKLOCNSZOI;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class AWHCOTDHAHH : IEquatable<AWHCOTDHAHH>, GBMNYUSYUQI<AWHCOTDHAHH>, LNISVCHADRL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public JFWWKSXUUGK XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		private AWHCOTDHAHH(JFWWKSXUUGK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28C6010", Offset = "0x28C4C10", VA = "0x1828C6010")]
		public static AWHCOTDHAHH New(JFWWKSXUUGK type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x287E600", Offset = "0x287D200", VA = "0x18287E600", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28C5F20", Offset = "0x28C4B20", VA = "0x1828C5F20")]
		public bool BQMHWPIWXMR([In] AWHCOTDHAHH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28C5F70", Offset = "0x28C4B70", VA = "0x1828C5F70", Slot = "4")]
		public bool Equals(AWHCOTDHAHH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28C5FC0", Offset = "0x28C4BC0", VA = "0x1828C5FC0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x289F350", Offset = "0x289DF50", VA = "0x18289F350", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28C6070", Offset = "0x28C4C70", VA = "0x1828C6070", Slot = "6")]
		public int VMDFWORFIKC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28C5F20", Offset = "0x28C4B20", VA = "0x1828C5F20", Slot = "5")]
		private bool XEMYUMCISQW([In] AWHCOTDHAHH other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class ICDUBMLBROC : IEquatable<ICDUBMLBROC>, GBMNYUSYUQI<ICDUBMLBROC>, LNISVCHADRL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public JFWWKSXUUGK XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		private ICDUBMLBROC(JFWWKSXUUGK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28C84C0", Offset = "0x28C70C0", VA = "0x1828C84C0")]
		public static ICDUBMLBROC New(JFWWKSXUUGK type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x287E600", Offset = "0x287D200", VA = "0x18287E600", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28C5F20", Offset = "0x28C4B20", VA = "0x1828C5F20")]
		public bool BQMHWPIWXMR([In] ICDUBMLBROC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28C5F70", Offset = "0x28C4B70", VA = "0x1828C5F70", Slot = "4")]
		public bool Equals(ICDUBMLBROC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28C8470", Offset = "0x28C7070", VA = "0x1828C8470", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x289F350", Offset = "0x289DF50", VA = "0x18289F350", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28C6070", Offset = "0x28C4C70", VA = "0x1828C6070", Slot = "6")]
		public int VMDFWORFIKC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28C5F20", Offset = "0x28C4B20", VA = "0x1828C5F20", Slot = "5")]
		private bool CUDMDIZQZEL([In] ICDUBMLBROC other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class VRZQZUJBTYL : WWCDXGUFWOO, IEquatable<VRZQZUJBTYL>, GBMNYUSYUQI<VRZQZUJBTYL>, LNISVCHADRL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, AWHCOTDHAHH>> ZDQQNOZPSQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, ICDUBMLBROC>> SAQCWVPRAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28CEEA0", Offset = "0x28CDAA0", VA = "0x1828CEEA0")]
		private VRZQZUJBTYL(IEnumerable<SHINXXVMWXA> a, IEnumerable<KeyValuePair<string, AWHCOTDHAHH>> b, IEnumerable<KeyValuePair<string, ICDUBMLBROC>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x28CE8E0", Offset = "0x28CD4E0", VA = "0x1828CE8E0")]
		public static VRZQZUJBTYL New(IEnumerable<SHINXXVMWXA> typeParameters, IEnumerable<KeyValuePair<string, AWHCOTDHAHH>> inputs, IEnumerable<KeyValuePair<string, ICDUBMLBROC>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28CEB90", Offset = "0x28CD790", VA = "0x1828CEB90", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28C8740", Offset = "0x28C7340", VA = "0x1828C8740", Slot = "15")]
		public sealed override string HVAHHEZFAAT(IReadOnlyList<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28CEA10", Offset = "0x28CD610", VA = "0x1828CEA10")]
		private string OJSWTSUYPVE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x28CE670", Offset = "0x28CD270", VA = "0x1828CE670")]
		private string GJVDVZNDJPV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x28CE4D0", Offset = "0x28CD0D0", VA = "0x1828CE4D0", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28CE520", Offset = "0x28CD120", VA = "0x1828CE520")]
		public bool BQMHWPIWXMR([In] VRZQZUJBTYL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28CE600", Offset = "0x28CD200", VA = "0x1828CE600", Slot = "18")]
		public bool Equals(VRZQZUJBTYL other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28CE620", Offset = "0x28CD220", VA = "0x1828CE620", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28CE7F0", Offset = "0x28CD3F0", VA = "0x1828CE7F0", Slot = "14")]
		protected sealed override int JEZZFSCWJXQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28CE8D0", Offset = "0x28CD4D0", VA = "0x1828CE8D0", Slot = "19")]
		private bool JSKOBUSEGQK([In] VRZQZUJBTYL other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class KQTRHNLMEPU : JFWWKSXUUGK, IEquatable<KQTRHNLMEPU>, GBMNYUSYUQI<KQTRHNLMEPU>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28C8FA0", Offset = "0x28C7BA0", VA = "0x1828C8FA0")]
		private KQTRHNLMEPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x28C8EB0", Offset = "0x28C7AB0", VA = "0x1828C8EB0")]
		public static KQTRHNLMEPU New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28C8F20", Offset = "0x28C7B20", VA = "0x1828C8F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28C8DC0", Offset = "0x28C79C0", VA = "0x1828C8DC0", Slot = "15")]
		public override string HVAHHEZFAAT(IReadOnlyList<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28C8D70", Offset = "0x28C7970", VA = "0x1828C8D70", Slot = "16")]
		public override int GCDAXPTWRKQ(IReadOnlyList<JFWWKSXUUGK> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8F50", Offset = "0x28C7B50", VA = "0x1828C8F50", Slot = "17")]
		public override bool YIFNZJBWUDT(IReadOnlyList<JFWWKSXUUGK> a, IReadOnlyList<JFWWKSXUUGK> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28C8CD0", Offset = "0x28C78D0", VA = "0x1828C8CD0", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0")]
		public bool BQMHWPIWXMR([In] KQTRHNLMEPU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xC720E0", Offset = "0xC70CE0", VA = "0x180C720E0", Slot = "18")]
		public bool Equals(KQTRHNLMEPU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28C8D20", Offset = "0x28C7920", VA = "0x1828C8D20", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0", Slot = "19")]
		private bool BECEPNZTHWP([In] KQTRHNLMEPU other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, GBMNYUSYUQI<Property>, LNISVCHADRL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool CUMYGOICBUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int SRAMUISSXQE;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public JFWWKSXUUGK XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ZLFWVZAAJRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xBAE8E0", Offset = "0xBAD4E0", VA = "0x180BAE8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool STIUEOTDMFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xF47A90", Offset = "0xF46690", VA = "0x180F47A90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x28CA410", Offset = "0x28C9010", VA = "0x1828CA410")]
		private Property(JFWWKSXUUGK type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28CA130", Offset = "0x28C8D30", VA = "0x1828CA130")]
		public static Property New(JFWWKSXUUGK type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x28CA220", Offset = "0x28C8E20", VA = "0x1828CA220", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x28CA1D0", Offset = "0x28C8DD0", VA = "0x1828CA1D0")]
		private string SLUHUDNLTTX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x28CA3C0", Offset = "0x28C8FC0", VA = "0x1828CA3C0")]
		private string XBBHVKWIQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28C9E50", Offset = "0x28C8A50", VA = "0x1828C9E50")]
		public bool BQMHWPIWXMR([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28C9FA0", Offset = "0x28C8BA0", VA = "0x1828C9FA0", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28C9F50", Offset = "0x28C8B50", VA = "0x1828C9F50", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28C9FC0", Offset = "0x28C8BC0", VA = "0x1828C9FC0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x28CA080", Offset = "0x28C8C80", VA = "0x1828CA080")]
		private int JEZZFSCWJXQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x28CA300", Offset = "0x28C8F00", VA = "0x1828CA300", Slot = "6")]
		public int VMDFWORFIKC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x28CA1C0", Offset = "0x28C8DC0", VA = "0x1828CA1C0", Slot = "5")]
		private bool PQPFPFEKMET([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class EJWOVJPKZLF : JFWWKSXUUGK, IEquatable<EJWOVJPKZLF>, GBMNYUSYUQI<EJWOVJPKZLF>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x28C7730", Offset = "0x28C6330", VA = "0x1828C7730")]
		private EJWOVJPKZLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x28C7690", Offset = "0x28C6290", VA = "0x1828C7690")]
		public static EJWOVJPKZLF New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x28C7700", Offset = "0x28C6300", VA = "0x1828C7700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x28C7610", Offset = "0x28C6210", VA = "0x1828C7610", Slot = "15")]
		public override string HVAHHEZFAAT(IReadOnlyList<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x28C7560", Offset = "0x28C6160", VA = "0x1828C7560", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0")]
		public bool BQMHWPIWXMR([In] EJWOVJPKZLF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xC720E0", Offset = "0xC70CE0", VA = "0x180C720E0", Slot = "18")]
		public bool Equals(EJWOVJPKZLF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x28C75C0", Offset = "0x28C61C0", VA = "0x1828C75C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0", Slot = "19")]
		private bool YTULLFJSIFG([In] EJWOVJPKZLF other)
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
	public sealed class LECLEKIWJJV : JFWWKSXUUGK, IEquatable<LECLEKIWJJV>, GBMNYUSYUQI<LECLEKIWJJV>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string XPPEXRAPNHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool NLPIFHVNXDP
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x28C9060", Offset = "0x28C7C60", VA = "0x1828C9060", Slot = "9")]
		public sealed override JFWWKSXUUGK IVLKRNJIMPP(IReadOnlyDictionary<string, JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x28C9170", Offset = "0x28C7D70", VA = "0x1828C9170", Slot = "11")]
		public sealed override void MYPPHTICBHZ(Action<JFWWKSXUUGK> a, Action<JFWWKSXUUGK> b, Action<JFWWKSXUUGK> c, Action<JFWWKSXUUGK> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x28C9220", Offset = "0x28C7E20", VA = "0x1828C9220")]
		private LECLEKIWJJV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x28C91A0", Offset = "0x28C7DA0", VA = "0x1828C91A0")]
		public static LECLEKIWJJV New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x28C8FC0", Offset = "0x28C7BC0", VA = "0x1828C8FC0", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0")]
		public bool BQMHWPIWXMR([In] LECLEKIWJJV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xC720E0", Offset = "0xC70CE0", VA = "0x180C720E0", Slot = "18")]
		public bool Equals(LECLEKIWJJV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x28C9010", Offset = "0x28C7C10", VA = "0x1828C9010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x28C9150", Offset = "0x28C7D50", VA = "0x1828C9150", Slot = "14")]
		protected sealed override int JEZZFSCWJXQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0", Slot = "19")]
		private bool DVMHCUODIQW([In] LECLEKIWJJV other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class WWCDXGUFWOO : JFWWKSXUUGK
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<SHINXXVMWXA> FFSOBWMDFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xA98370", Offset = "0xA96F70", VA = "0x180A98370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x28CF070", Offset = "0x28CDC70", VA = "0x1828CF070")]
		public void Initialize(WWCDXGUFWOO from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x28CF120", Offset = "0x28CDD20", VA = "0x1828CF120")]
		protected WWCDXGUFWOO(IEnumerable<SHINXXVMWXA> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool BQMHWPIWXMR([In] JFWWKSXUUGK other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x28CEF90", Offset = "0x28CDB90", VA = "0x1828CEF90")]
		protected bool BQMHWPIWXMR([In] WWCDXGUFWOO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x28CF0A0", Offset = "0x28CDCA0", VA = "0x1828CF0A0", Slot = "14")]
		protected override int JEZZFSCWJXQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x28CEFF0", Offset = "0x28CDBF0", VA = "0x1828CEFF0")]
		protected int FVWXUILRQUQ(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class SHINXXVMWXA : JFWWKSXUUGK, IEquatable<SHINXXVMWXA>, GBMNYUSYUQI<SHINXXVMWXA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string XPPEXRAPNHC
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public JFWWKSXUUGK ETKFTFUXFFO
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x28CAA90", Offset = "0x28C9690", VA = "0x1828CAA90")]
		private SHINXXVMWXA(string a, [Optional] JFWWKSXUUGK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x28CA890", Offset = "0x28C9490", VA = "0x1828CA890")]
		public static SHINXXVMWXA New(string name, [Optional] JFWWKSXUUGK constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x28CA990", Offset = "0x28C9590", VA = "0x1828CA990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x28CA6D0", Offset = "0x28C92D0", VA = "0x1828CA6D0", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x28CA720", Offset = "0x28C9320", VA = "0x1828CA720")]
		public bool BQMHWPIWXMR([In] SHINXXVMWXA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x28CA7C0", Offset = "0x28C93C0", VA = "0x1828CA7C0", Slot = "18")]
		public bool Equals(SHINXXVMWXA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x28CA770", Offset = "0x28C9370", VA = "0x1828CA770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x28CA810", Offset = "0x28C9410", VA = "0x1828CA810", Slot = "14")]
		protected override int JEZZFSCWJXQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x28CAA20", Offset = "0x28C9620", VA = "0x1828CAA20", Slot = "13")]
		public override int VMDFWORFIKC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x28CA720", Offset = "0x28C9320", VA = "0x1828CA720", Slot = "19")]
		private bool SEEWUSFIFVL([In] SHINXXVMWXA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class MSADHYWVXKG : JFWWKSXUUGK, IEquatable<MSADHYWVXKG>, GBMNYUSYUQI<MSADHYWVXKG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x28C9BC0", Offset = "0x28C87C0", VA = "0x1828C9BC0")]
		private MSADHYWVXKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x28C9AD0", Offset = "0x28C86D0", VA = "0x1828C9AD0")]
		public static MSADHYWVXKG New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x28C9B40", Offset = "0x28C8740", VA = "0x1828C9B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x28C99E0", Offset = "0x28C85E0", VA = "0x1828C99E0", Slot = "15")]
		public override string HVAHHEZFAAT(IReadOnlyList<JFWWKSXUUGK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x28C9990", Offset = "0x28C8590", VA = "0x1828C9990", Slot = "16")]
		public override int GCDAXPTWRKQ(IReadOnlyList<JFWWKSXUUGK> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x28C9B70", Offset = "0x28C8770", VA = "0x1828C9B70", Slot = "17")]
		public override bool YIFNZJBWUDT(IReadOnlyList<JFWWKSXUUGK> a, IReadOnlyList<JFWWKSXUUGK> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x28C98F0", Offset = "0x28C84F0", VA = "0x1828C98F0", Slot = "12")]
		public override bool BQMHWPIWXMR([In] JFWWKSXUUGK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0")]
		public bool BQMHWPIWXMR([In] MSADHYWVXKG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xC720E0", Offset = "0xC70CE0", VA = "0x180C720E0", Slot = "18")]
		public bool Equals(MSADHYWVXKG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x28C9940", Offset = "0x28C8540", VA = "0x1828C9940", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x28C75B0", Offset = "0x28C61B0", VA = "0x1828C75B0", Slot = "19")]
		private bool MNPLINFHXWR([In] MSADHYWVXKG other)
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
			public readonly JFWWKSXUUGK CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
			internal Impl(JFWWKSXUUGK circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x28C6340", Offset = "0x28C4F40", VA = "0x1828C6340")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x28C6230", Offset = "0x28C4E30", VA = "0x1828C6230")]
		public static CircuitTypeOrString LFNJGUQZVGO(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x28C61D0", Offset = "0x28C4DD0", VA = "0x1828C61D0")]
		public static CircuitTypeOrString LFNJGUQZVGO(JFWWKSXUUGK a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x28C62A0", Offset = "0x28C4EA0", VA = "0x1828C62A0")]
		public JFWWKSXUUGK NHRWFWRWLKV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x28C60A0", Offset = "0x28C4CA0", VA = "0x1828C60A0")]
		public static JFWWKSXUUGK[] EMECWLVSRAU(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly VFIUYJTNGZH _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		private ClassFactoryBaseClasses(VFIUYJTNGZH data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xDE5490", Offset = "0xDE4090", VA = "0x180DE5490")]
		public static ClassFactoryBaseClasses New(VFIUYJTNGZH data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x28C63D0", Offset = "0x28C4FD0", VA = "0x1828C63D0")]
		public ClassFactoryBaseClasses SSKEOBPOOLN(TENELWVUMZX a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1571F20", Offset = "0x1570B20", VA = "0x181571F20")]
		public ClassFactoryProps USWVATQMCBW()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x28C6370", Offset = "0x28C4F70", VA = "0x1828C6370")]
		public ClassFactoryProps OTZTEHWPGWJ(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x28C6490", Offset = "0x28C5090", VA = "0x1828C6490")]
		public TENELWVUMZX ZXGWLXXUFYA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class VFIUYJTNGZH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? HSLXDBEEAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string XPPEXRAPNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<SHINXXVMWXA> FFSOBWMDFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<TENELWVUMZX> GUDAAGULMRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> IOHNNEJGHXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, VRZQZUJBTYL>> HFFQJDBBXNW;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x28CE340", Offset = "0x28CCF40", VA = "0x1828CE340")]
		private VFIUYJTNGZH([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x28CE190", Offset = "0x28CCD90", VA = "0x1828CE190")]
		public static VFIUYJTNGZH New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly VFIUYJTNGZH _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		private ClassFactoryFuncs(VFIUYJTNGZH data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xDE5490", Offset = "0xDE4090", VA = "0x180DE5490")]
		public static ClassFactoryFuncs New(VFIUYJTNGZH data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x28C64E0", Offset = "0x28C50E0", VA = "0x1828C64E0")]
		public TENELWVUMZX ZXGWLXXUFYA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly VFIUYJTNGZH _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		public ClassFactoryProps(VFIUYJTNGZH data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x28C6630", Offset = "0x28C5230", VA = "0x1828C6630")]
		public ClassFactoryProps OTZTEHWPGWJ(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1571F20", Offset = "0x1570B20", VA = "0x181571F20")]
		public ClassFactoryFuncs DNEVVXYUDYJ()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x28C67C0", Offset = "0x28C53C0", VA = "0x1828C67C0")]
		public TENELWVUMZX ZXGWLXXUFYA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly VFIUYJTNGZH _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		private ClassFactoryTypeParams(VFIUYJTNGZH data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x28C6800", Offset = "0x28C5400", VA = "0x1828C6800")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x28C69D0", Offset = "0x28C55D0", VA = "0x1828C69D0")]
		public ClassFactoryTypeParams RHEVRXUQYSR(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1571F20", Offset = "0x1570B20", VA = "0x181571F20")]
		public ClassFactoryBaseClasses WUDZACYLKJT()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x28C6C70", Offset = "0x28C5870", VA = "0x1828C6C70")]
		public ClassFactoryBaseClasses SSKEOBPOOLN(TENELWVUMZX a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x28C6CB0", Offset = "0x28C58B0", VA = "0x1828C6CB0")]
		public TENELWVUMZX ZXGWLXXUFYA()
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
