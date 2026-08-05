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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class EUKWVPLYZVT : IEquatable<EUKWVPLYZVT>, VZURHGBSTCB<EUKWVPLYZVT>, OBEOUKPJQRC
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool CMYQNXQLYBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool YRPUXABTUCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int EWWYEECRRNP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind BWQZNOWSFXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA30", Offset = "0xCFAA30", VA = "0x180CFBA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? CDHSFMBDHTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B9E490", Offset = "0x2B9D490", VA = "0x182B9E490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual EUKWVPLYZVT UODJEXJVJNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool PZITTNBQNJW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E030", Offset = "0x2B9D030", VA = "0x182B9E030")]
		public static void KWSQHQMQIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
		protected EUKWVPLYZVT(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E0F0", Offset = "0x2B9D0F0", VA = "0x182B9E0F0")]
		public static EUKWVPLYZVT New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0")]
		protected static a BJCMXEHXVLH<a>(a a) where a : EUKWVPLYZVT
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0", Slot = "9")]
		public virtual EUKWVPLYZVT SQAYJDGMQCC(IReadOnlyDictionary<string, EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E000", Offset = "0x2B9D000", VA = "0x182B9E000", Slot = "11")]
		public virtual void JNSSDAYPMJE(Action<EUKWVPLYZVT> a, Action<EUKWVPLYZVT> b, Action<EUKWVPLYZVT> c, Action<EUKWVPLYZVT> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E320", Offset = "0x2B9D320", VA = "0x182B9E320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DE70", Offset = "0x2B9CE70", VA = "0x182B9DE70", Slot = "12")]
		public virtual bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DDF0", Offset = "0x2B9CDF0", VA = "0x182B9DDF0", Slot = "4")]
		public bool Equals(EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DE20", Offset = "0x2B9CE20", VA = "0x182B9DE20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DFC0", Offset = "0x2B9CFC0", VA = "0x182B9DFC0")]
		public static bool HCRCQFCURBY(EUKWVPLYZVT a, EUKWVPLYZVT b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E2E0", Offset = "0x2B9D2E0", VA = "0x182B9E2E0")]
		public static bool SIHBZTKNPGZ(EUKWVPLYZVT a, EUKWVPLYZVT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DF10", Offset = "0x2B9CF10", VA = "0x182B9DF10", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E0C0", Offset = "0x2B9D0C0", VA = "0x182B9E0C0", Slot = "13")]
		public virtual int YLWIHPJRJFX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E0C0", Offset = "0x2B9D0C0", VA = "0x182B9E0C0", Slot = "14")]
		protected virtual int MGRAVPAGNMN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x394D4D0", Offset = "0x394C4D0", VA = "0x18394D4D0")]
		public b BAFULLWRJAJ<b>() where b : EUKWVPLYZVT
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E2C0", Offset = "0x2B9D2C0", VA = "0x182B9E2C0", Slot = "15")]
		public virtual string QOXGGEJDGZM(IReadOnlyList<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DD50", Offset = "0x2B9CD50", VA = "0x182B9DD50", Slot = "16")]
		public virtual int AGZWSANJZRT(IReadOnlyList<EUKWVPLYZVT> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DDA0", Offset = "0x2B9CDA0", VA = "0x182B9DDA0", Slot = "17")]
		public virtual bool EWHOFWMUTCE(IReadOnlyList<EUKWVPLYZVT> a, IReadOnlyList<EUKWVPLYZVT> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E160", Offset = "0x2B9D160", VA = "0x182B9E160")]
		public JFOXBOFRTHW QHHVSZZLWDY(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E2B0", Offset = "0x2B9D2B0", VA = "0x182B9E2B0")]
		public JFOXBOFRTHW QHHVSZZLWDY(params EUKWVPLYZVT[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E2B0", Offset = "0x2B9D2B0", VA = "0x182B9E2B0")]
		public JFOXBOFRTHW QHHVSZZLWDY(IEnumerable<EUKWVPLYZVT> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IULAIVKNAGW<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a QFLLVZOCRUU(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b JYSBXQEZMIK([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind TMNPSQNEJUA([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates RKANVKUVWGH(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OBEOUKPJQRC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int YLWIHPJRJFX(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class YLWIHPJRJFX
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class UDKKDBKIJRZ<a> where a : OBEOUKPJQRC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int NFAMEJNXCRA;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public UDKKDBKIJRZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7F027A0", Offset = "0x7F017A0", VA = "0x187F027A0")]
			internal int RKRECXFEXMA(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class SJBJABCBNQR<a, b> where b : OBEOUKPJQRC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int NFAMEJNXCRA;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public SJBJABCBNQR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7ABCE50", Offset = "0x7ABBE50", VA = "0x187ABCE50")]
			internal int RKRECXFEXMA(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class TBSNIXJJGRH<a> where a : OBEOUKPJQRC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int NFAMEJNXCRA;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public TBSNIXJJGRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7C47C40", Offset = "0x7C46C40", VA = "0x187C47C40")]
			internal int WZYSTZAMYYF(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x411AE10", Offset = "0x4119E10", VA = "0x18411AE10")]
		public static int JRBTCUYKEHQ<a>(this IEnumerable<a> a, int b = 0) where a : OBEOUKPJQRC
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x411AEE0", Offset = "0x4119EE0", VA = "0x18411AEE0")]
		public static int JRBTCUYKEHQ<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : OBEOUKPJQRC
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x411AE10", Offset = "0x4119E10", VA = "0x18411AE10")]
		public static int IESGPMTBSZD<d>(this IEnumerable<d> a, int b = 0) where d : OBEOUKPJQRC
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : IULAIVKNAGW<TDirectedType, EUKWVPLYZVT, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x537F120", Offset = "0x537E120", VA = "0x18537F120")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7ECAD60", Offset = "0x7EC9D60", VA = "0x187ECAD60")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class RXAYFCZBAOH
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PGXITMCKOFH<a, b, c> where c : IULAIVKNAGW<a, EUKWVPLYZVT, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public EUKWVPLYZVT SSRALFRXPZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<EUKWVPLYZVT> VCCAWADENHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public EUKWVPLYZVT SEBBUPBHNMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<EUKWVPLYZVT> DJRKWDXYOUR;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public PGXITMCKOFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x75379A0", Offset = "0x75369A0", VA = "0x1875379A0")]
			internal bool LWUWGAQEXOT([In] TypeSys<a, b, c> self_, EUKWVPLYZVT a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7537B50", Offset = "0x7536B50", VA = "0x187537B50")]
			internal bool LXADDHKCHAC([In] TypeSys<a, b, c> self_, EUKWVPLYZVT a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7537D30", Offset = "0x7536D30", VA = "0x187537D30")]
			internal bool LXPXVBRUJID([In] TypeSys<a, b, c> self_, EUKWVPLYZVT a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ZHMAFLGHLQS<a, b, c> where c : IULAIVKNAGW<a, EUKWVPLYZVT, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public EUKWVPLYZVT CETJANBOVVP;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public ZHMAFLGHLQS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5137EE0", Offset = "0x5136EE0", VA = "0x185137EE0")]
			internal bool LXKQXUXWZWU([In] TypeSys<a, b, c> self__, EUKWVPLYZVT a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class VHFRZNRJHLN<a, b, c> where c : IULAIVKNAGW<a, EUKWVPLYZVT, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b DIIJJEHZBXI;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VHFRZNRJHLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8021610", Offset = "0x8020610", VA = "0x188021610")]
			internal EUKWVPLYZVT BOUYRBCTVWQ([In] TypeSys<a, b, c> self_, [In] b root_, EUKWVPLYZVT a, EUKWVPLYZVT b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class NWRTLQTWLKU<a, b, c> where c : IULAIVKNAGW<a, EUKWVPLYZVT, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public QNRICJJABYK JNRAWXLVMOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public QNRICJJABYK JNKILLVHOPG;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public NWRTLQTWLKU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x72A4DA0", Offset = "0x72A3DA0", VA = "0x1872A4DA0")]
			internal a BPKTIVKLYER([In] TypeSys<a, b, c> self_, IOKind a, QNRICJJABYK b, QNRICJJABYK c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class AYUNCBFMGEF<a, b, c> where c : IULAIVKNAGW<a, EUKWVPLYZVT, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<QNRICJJABYK> FGXAASQJTCS;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public AYUNCBFMGEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7326790", Offset = "0x7325790", VA = "0x187326790")]
			internal bool NGRIPPGNXHX(bool a, QNRICJJABYK b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] JNNSJDOHNDO;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD9B0", Offset = "0x3EBC9B0", VA = "0x183EBD9B0")]
		public static bool DZIJWUPJOWV<a, b, c>([In] this TypeSys<a, b, c> _, EUKWVPLYZVT a) where c : IULAIVKNAGW<a, EUKWVPLYZVT, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3EBE260", Offset = "0x3EBD260", VA = "0x183EBE260")]
		public static bool LFVHUWUBAWK<d, e, f>([In] this TypeSys<d, e, f> _, EUKWVPLYZVT a) where f : IULAIVKNAGW<d, EUKWVPLYZVT, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3EBEC60", Offset = "0x3EBDC60", VA = "0x183EBEC60")]
		public static bool WGNSQSBKFZE<g, h, i>([In] this TypeSys<g, h, i> self, EUKWVPLYZVT a, EUKWVPLYZVT b) where i : IULAIVKNAGW<g, EUKWVPLYZVT, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9150", Offset = "0x3EA8150", VA = "0x183EA9150")]
		private static bool CURSUXYKMEH<j, k, l>([In] this TypeSys<j, k, l> self, EUKWVPLYZVT a, EUKWVPLYZVT b, IReadOnlyList<EUKWVPLYZVT> c, IReadOnlyList<EUKWVPLYZVT> d) where l : IULAIVKNAGW<j, EUKWVPLYZVT, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3EAD070", Offset = "0x3EAC070", VA = "0x183EAD070")]
		public static EUKWVPLYZVT DIRDWYECRNT<m, n, o>([In] this TypeSys<m, n, o> self, n a, EUKWVPLYZVT b, EUKWVPLYZVT c) where o : IULAIVKNAGW<m, EUKWVPLYZVT, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3EAA300", Offset = "0x3EA9300", VA = "0x183EAA300")]
		public static p DIRDWYECRNT<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : IULAIVKNAGW<p, EUKWVPLYZVT, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3EBDE80", Offset = "0x3EBCE80", VA = "0x183EBDE80")]
		private static List<w> JAKRMDRERHD<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : IULAIVKNAGW<t, EUKWVPLYZVT, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3EBEAC0", Offset = "0x3EBDAC0", VA = "0x183EBEAC0")]
		private static ba SZGRHALBFED<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class GIDOULERIPM
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static EUKWVPLYZVT ITRFKOVHOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B9EA90", Offset = "0x2B9DA90", VA = "0x182B9EA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static EUKWVPLYZVT WBTCCGKNBDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F070", Offset = "0x2B9E070", VA = "0x182B9F070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static EUKWVPLYZVT KFCFBYWIXOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F160", Offset = "0x2B9E160", VA = "0x182B9F160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static EUKWVPLYZVT KNUKSYGNVCS
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F110", Offset = "0x2B9E110", VA = "0x182B9F110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static EUKWVPLYZVT JSVOVRSWZNW
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B9ED20", Offset = "0x2B9DD20", VA = "0x182B9ED20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static EUKWVPLYZVT DGNWOAOXBVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F1B0", Offset = "0x2B9E1B0", VA = "0x182B9F1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static EUKWVPLYZVT QQNIDUYCKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F0C0", Offset = "0x2B9E0C0", VA = "0x182B9F0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static EUKWVPLYZVT VOFVUNACUCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F200", Offset = "0x2B9E200", VA = "0x182B9F200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ED70", Offset = "0x2B9DD70", VA = "0x182B9ED70")]
		public static JFOXBOFRTHW LHDSBGKCYYU([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F250", Offset = "0x2B9E250", VA = "0x182B9F250")]
		public static JFOXBOFRTHW ZPRXLYJHDDI(IEnumerable<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EC90", Offset = "0x2B9DC90", VA = "0x182B9EC90")]
		public static JFOXBOFRTHW HBFQNCUOJEC(IEnumerable<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EAE0", Offset = "0x2B9DAE0", VA = "0x182B9EAE0")]
		public static JFOXBOFRTHW HBFQNCUOJEC(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EA00", Offset = "0x2B9DA00", VA = "0x182B9EA00")]
		public static JFOXBOFRTHW AQSIODMDUGL(IEnumerable<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EEA0", Offset = "0x2B9DEA0", VA = "0x182B9EEA0")]
		public static JLWXGYSAWHT MUVZKHXMFFW(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class JFOXBOFRTHW : EUKWVPLYZVT, IEquatable<JFOXBOFRTHW>, VZURHGBSTCB<JFOXBOFRTHW>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WJESLANGGFS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, EUKWVPLYZVT> ODNYUJMTNVS;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WJESLANGGFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8240", Offset = "0x2BA7240", VA = "0x182BA8240")]
			internal EUKWVPLYZVT MOMFTSXAQLW(EUKWVPLYZVT a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public EUKWVPLYZVT FBPHNJOGICG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override EUKWVPLYZVT UODJEXJVJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<EUKWVPLYZVT> PEVSITPLNHT
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool PZITTNBQNJW
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2BA3140", Offset = "0x2BA2140", VA = "0x182BA3140", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3020", Offset = "0x2BA2020", VA = "0x182BA3020", Slot = "9")]
		public sealed override EUKWVPLYZVT SQAYJDGMQCC(IReadOnlyDictionary<string, EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2C90", Offset = "0x2BA1C90", VA = "0x182BA2C90", Slot = "11")]
		public sealed override void JNSSDAYPMJE(Action<EUKWVPLYZVT> a, Action<EUKWVPLYZVT> b, Action<EUKWVPLYZVT> c, Action<EUKWVPLYZVT> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2BA32B0", Offset = "0x2BA22B0", VA = "0x182BA32B0")]
		private JFOXBOFRTHW(EUKWVPLYZVT a, IEnumerable<EUKWVPLYZVT> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2FA0", Offset = "0x2BA1FA0", VA = "0x182BA2FA0")]
		public static JFOXBOFRTHW New(EUKWVPLYZVT originalType, IEnumerable<EUKWVPLYZVT> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3260", Offset = "0x2BA2260", VA = "0x182BA3260", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2BA0", Offset = "0x2BA1BA0", VA = "0x182BA2BA0", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2BF0", Offset = "0x2BA1BF0", VA = "0x182BA2BF0")]
		public bool FNYFOTOAQQI([In] JFOXBOFRTHW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2B80", Offset = "0x2BA1B80", VA = "0x182BA2B80", Slot = "18")]
		public bool Equals(JFOXBOFRTHW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2B30", Offset = "0x2BA1B30", VA = "0x182BA2B30", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2EF0", Offset = "0x2BA1EF0", VA = "0x182BA2EF0", Slot = "14")]
		protected override int MGRAVPAGNMN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BA32A0", Offset = "0x2BA22A0", VA = "0x182BA32A0", Slot = "19")]
		private bool YDOSAMIRKIN([In] JFOXBOFRTHW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class FNFMPQGGUGT : EUKWVPLYZVT, IEquatable<FNFMPQGGUGT>, VZURHGBSTCB<FNFMPQGGUGT>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E9E0", Offset = "0x2B9D9E0", VA = "0x182B9E9E0")]
		private FNFMPQGGUGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E880", Offset = "0x2B9D880", VA = "0x182B9E880")]
		public static FNFMPQGGUGT New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E980", Offset = "0x2B9D980", VA = "0x182B9E980", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E8F0", Offset = "0x2B9D8F0", VA = "0x182B9E8F0", Slot = "15")]
		public sealed override string QOXGGEJDGZM(IReadOnlyList<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E840", Offset = "0x2B9D840", VA = "0x182B9E840")]
		private static string GARUUHDZMJC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E7F0", Offset = "0x2B9D7F0", VA = "0x182B9E7F0", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550")]
		public bool FNYFOTOAQQI([In] FNFMPQGGUGT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xF7F660", Offset = "0xF7E660", VA = "0x180F7F660", Slot = "18")]
		public bool Equals(FNFMPQGGUGT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E7A0", Offset = "0x2B9D7A0", VA = "0x182B9E7A0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550", Slot = "19")]
		private bool EUFRXQKEPNK([In] FNFMPQGGUGT other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class GVETGLPTJFS
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class QBUTDWRBSPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public EUKWVPLYZVT RVNEZSQYODW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<EUKWVPLYZVT, JFOXBOFRTHW> CVJBMXXIHNK;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBUTDWRBSPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2BA4C40", Offset = "0x2BA3C40", VA = "0x182BA4C40")]
			internal JFOXBOFRTHW VUVRPJLNDQA(EUKWVPLYZVT a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class QBPMGPXEJEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public EUKWVPLYZVT YOZGVDGOEBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<EUKWVPLYZVT, JFOXBOFRTHW> IBPNQVJUAMY;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QBPMGPXEJEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2BA4AC0", Offset = "0x2BA3AC0", VA = "0x182BA4AC0")]
			internal JFOXBOFRTHW SZBIGGOQWWA(EUKWVPLYZVT a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2580", Offset = "0x2BA1580", VA = "0x182BA2580")]
		public static IEnumerable<QNRICJJABYK> ZSXHROWZQQE(this QNRICJJABYK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BA24C0", Offset = "0x2BA14C0", VA = "0x182BA24C0")]
		private static IEnumerable<QNRICJJABYK> WWWGHDUIXGC(this QNRICJJABYK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA06E0", Offset = "0x2B9F6E0", VA = "0x182BA06E0")]
		public static (EUKWVPLYZVT, IReadOnlyList<EUKWVPLYZVT>, bool) ITGLZOTFTFO(this EUKWVPLYZVT a, [Optional] IReadOnlyList<EUKWVPLYZVT> b)
		{
			return default((EUKWVPLYZVT, IReadOnlyList<EUKWVPLYZVT>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA06B0", Offset = "0x2B9F6B0", VA = "0x182BA06B0")]
		public static TypeKind IABNYADJSQL(this EUKWVPLYZVT a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F8A0", Offset = "0x2B9E8A0", VA = "0x182B9F8A0")]
		private static EUKWVPLYZVT ConvertClassesToIntersections(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0380", Offset = "0x2B9F380", VA = "0x182BA0380")]
		private static EUKWVPLYZVT DistributeUnionIntoIntersection(this JFOXBOFRTHW self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FEF0", Offset = "0x2B9EEF0", VA = "0x182B9FEF0")]
		private static EUKWVPLYZVT DistributeIntersectionIntoIntersection(this JFOXBOFRTHW self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0220", Offset = "0x2B9F220", VA = "0x182BA0220")]
		private static EUKWVPLYZVT DistributeIntoIntersection(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2BA08B0", Offset = "0x2B9F8B0", VA = "0x182BA08B0")]
		private static bool OtherIsAssignableToOther(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes, EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1D20", Offset = "0x2BA0D20", VA = "0x182BA1D20")]
		private static bool UnionIsAssignableToOther(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes, EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0A40", Offset = "0x2B9FA40", VA = "0x182BA0A40")]
		private static bool OtherIsAssignableToUnion(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes, EUKWVPLYZVT union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2050", Offset = "0x2BA1050", VA = "0x182BA2050")]
		private static bool UnionIsAssignableToUnion(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes, EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1B20", Offset = "0x2BA0B20", VA = "0x182BA1B20")]
		public static EUKWVPLYZVT RemoveCommonTypesFromIntersectionDistribution(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0E40", Offset = "0x2B9FE40", VA = "0x182BA0E40")]
		public static EUKWVPLYZVT RemoveCommonTypesFromIntersectionDistributionInternal(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1C50", Offset = "0x2BA0C50", VA = "0x182BA1C50")]
		public static EUKWVPLYZVT SimplifyIntersectionUnion(this EUKWVPLYZVT self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0DF0", Offset = "0x2B9FDF0", VA = "0x182BA0DF0")]
		public static IEnumerable<EUKWVPLYZVT> PEVSITPLNHT(this EUKWVPLYZVT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2BA27B0", Offset = "0x2BA17B0", VA = "0x182BA27B0")]
		public static IEnumerable<EUKWVPLYZVT> ZXICTXIFSRI(this EUKWVPLYZVT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class QNRICJJABYK : DPRQGTECURV, IEquatable<QNRICJJABYK>, VZURHGBSTCB<QNRICJJABYK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class YGJITLMBBJT : IEnumerable<QNRICJJABYK>, IEnumerable, IEnumerator<QNRICJJABYK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private QNRICJJABYK NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public QNRICJJABYK NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<QNRICJJABYK> PQBFSTXQTPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private QNRICJJABYK PCQECLSWQLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<QNRICJJABYK> PPQRYGJWASU;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private QNRICJJABYK EDESNXTWSQF
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public YGJITLMBBJT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8AC0", Offset = "0x2BA7AC0", VA = "0x182BA8AC0", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8700", Offset = "0x2BA7700", VA = "0x182BA8700", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8660", Offset = "0x2BA7660", VA = "0x182BA8660")]
			private void LZWZIAQZAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2BA86B0", Offset = "0x2BA76B0", VA = "0x182BA86B0")]
			private void MACGFHKWJQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8C10", Offset = "0x2BA7C10", VA = "0x182BA8C10", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2BA85C0", Offset = "0x2BA75C0", VA = "0x182BA85C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<QNRICJJABYK> KKYLPNOMRSS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2BA85C0", Offset = "0x2BA75C0", VA = "0x182BA85C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> IKLAZPIPCJQ;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, QNRICJJABYK> IIEVKRUHQXR;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, QNRICJJABYK> DLRRZJLBFNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5C50", Offset = "0x2BA4C50", VA = "0x182BA5C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? CDHSFMBDHTN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid OSRJHZIEHJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xF71A20", Offset = "0xF70A20", VA = "0x180F71A20")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xF72420", Offset = "0xF71420", VA = "0x180F72420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<QNRICJJABYK> DZDITQVYUEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCFC240", Offset = "0xCFB240", VA = "0x180CFC240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<QNRICJJABYK> EGJUZTJCLRW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2BA5BD0", Offset = "0x2BA4BD0", VA = "0x182BA5BD0")]
			[IteratorStateMachine(typeof(YGJITLMBBJT))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> YVFFJRZFCRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF6BC0", VA = "0x180CF7BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, KNJBUTYALBM> KVWSKQPTBXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E60", Offset = "0xCF6E60", VA = "0x180CF7E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA61E0", Offset = "0x2BA51E0", VA = "0x182BA61E0")]
		public QNRICJJABYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5E80", Offset = "0x2BA4E80", VA = "0x182BA5E80")]
		public QNRICJJABYK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5980", Offset = "0x2BA4980", VA = "0x182BA5980")]
		public static QNRICJJABYK MQLRZFTVNNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5AB0", Offset = "0x2BA4AB0", VA = "0x182BA5AB0")]
		public static QNRICJJABYK QFPHBYYXGTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5610", Offset = "0x2BA4610", VA = "0x182BA5610")]
		public void Initialize(QNRICJJABYK from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5F30", Offset = "0x2BA4F30", VA = "0x182BA5F30")]
		private QNRICJJABYK([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<JLWXGYSAWHT> c, [Optional] IEnumerable<QNRICJJABYK> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, KNJBUTYALBM>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA59D0", Offset = "0x2BA49D0", VA = "0x182BA59D0")]
		public static QNRICJJABYK New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<JLWXGYSAWHT> typeParameters, [Optional] IEnumerable<QNRICJJABYK> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, KNJBUTYALBM>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5CA0", Offset = "0x2BA4CA0", VA = "0x182BA5CA0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5810", Offset = "0x2BA4810", VA = "0x182BA5810")]
		private string MEDSULXXDSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5550", Offset = "0x2BA4550", VA = "0x182BA5550")]
		private static string HHXKORLKHSG(IEnumerable<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5270", Offset = "0x2BA4270", VA = "0x182BA5270")]
		private string FYMVMZEDCRH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4DC0", Offset = "0x2BA3DC0", VA = "0x182BA4DC0")]
		private string EULAMWWUMOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5B00", Offset = "0x2BA4B00", VA = "0x182BA5B00", Slot = "15")]
		public sealed override string QOXGGEJDGZM(IReadOnlyList<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5220", Offset = "0x2BA4220", VA = "0x182BA5220", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5100", Offset = "0x2BA4100", VA = "0x182BA5100")]
		public bool FNYFOTOAQQI([In] QNRICJJABYK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5090", Offset = "0x2BA4090", VA = "0x182BA5090", Slot = "18")]
		public bool Equals(QNRICJJABYK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA50B0", Offset = "0x2BA40B0", VA = "0x182BA50B0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5870", Offset = "0x2BA4870", VA = "0x182BA5870", Slot = "14")]
		protected override int MGRAVPAGNMN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5AA0", Offset = "0x2BA4AA0", VA = "0x182BA5AA0", Slot = "19")]
		private bool PRVBGMPNFDH([In] QNRICJJABYK other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class ZWNKDECSZDB
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<EUKWVPLYZVT> CZNQIEQEXNI;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<QNRICJJABYK> KSDYIQSPMRZ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, JLWXGYSAWHT> SVSZUFBRRRQ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> UTJZCMJFFNQ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, KNJBUTYALBM> CXVJOGKWPKD;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class VHKPCQHXUEG : IEquatable<VHKPCQHXUEG>, VZURHGBSTCB<VHKPCQHXUEG>, OBEOUKPJQRC
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public EUKWVPLYZVT AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		private VHKPCQHXUEG(EUKWVPLYZVT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA81E0", Offset = "0x2BA71E0", VA = "0x182BA81E0")]
		public static VHKPCQHXUEG New(EUKWVPLYZVT type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BA70", Offset = "0x2B5AA70", VA = "0x182B5BA70", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7C0", Offset = "0x2B9E7C0", VA = "0x182B9F7C0")]
		public bool FNYFOTOAQQI([In] VHKPCQHXUEG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F770", Offset = "0x2B9E770", VA = "0x182B9F770", Slot = "4")]
		public bool Equals(VHKPCQHXUEG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8190", Offset = "0x2BA7190", VA = "0x182BA8190", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B76350", Offset = "0x2B75350", VA = "0x182B76350", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F870", Offset = "0x2B9E870", VA = "0x182B9F870", Slot = "6")]
		public int YLWIHPJRJFX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7C0", Offset = "0x2B9E7C0", VA = "0x182B9F7C0", Slot = "5")]
		private bool TBZAQNDKRLX([In] VHKPCQHXUEG other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class GNQJPNILCDV : IEquatable<GNQJPNILCDV>, VZURHGBSTCB<GNQJPNILCDV>, OBEOUKPJQRC
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public EUKWVPLYZVT AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		private GNQJPNILCDV(EUKWVPLYZVT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F810", Offset = "0x2B9E810", VA = "0x182B9F810")]
		public static GNQJPNILCDV New(EUKWVPLYZVT type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BA70", Offset = "0x2B5AA70", VA = "0x182B5BA70", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7C0", Offset = "0x2B9E7C0", VA = "0x182B9F7C0")]
		public bool FNYFOTOAQQI([In] GNQJPNILCDV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F770", Offset = "0x2B9E770", VA = "0x182B9F770", Slot = "4")]
		public bool Equals(GNQJPNILCDV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F720", Offset = "0x2B9E720", VA = "0x182B9F720", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B76350", Offset = "0x2B75350", VA = "0x182B76350", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F870", Offset = "0x2B9E870", VA = "0x182B9F870", Slot = "6")]
		public int YLWIHPJRJFX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F7C0", Offset = "0x2B9E7C0", VA = "0x182B9F7C0", Slot = "5")]
		private bool YMNZMGVBLJM([In] GNQJPNILCDV other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class KNJBUTYALBM : DPRQGTECURV, IEquatable<KNJBUTYALBM>, VZURHGBSTCB<KNJBUTYALBM>, OBEOUKPJQRC
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, VHKPCQHXUEG>> OVARURGOYXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, GNQJPNILCDV>> LYBOYIUPWUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2BA41D0", Offset = "0x2BA31D0", VA = "0x182BA41D0")]
		private KNJBUTYALBM(IEnumerable<JLWXGYSAWHT> a, IEnumerable<KeyValuePair<string, VHKPCQHXUEG>> b, IEnumerable<KeyValuePair<string, GNQJPNILCDV>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3D80", Offset = "0x2BA2D80", VA = "0x182BA3D80")]
		public static KNJBUTYALBM New(IEnumerable<JLWXGYSAWHT> typeParameters, IEnumerable<KeyValuePair<string, VHKPCQHXUEG>> inputs, IEnumerable<KeyValuePair<string, GNQJPNILCDV>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3EB0", Offset = "0x2BA2EB0", VA = "0x182BA3EB0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E2C0", Offset = "0x2B9D2C0", VA = "0x182B9E2C0", Slot = "15")]
		public sealed override string QOXGGEJDGZM(IReadOnlyList<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3980", Offset = "0x2BA2980", VA = "0x182BA3980")]
		private string DLKEIVTDDZR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3800", Offset = "0x2BA2800", VA = "0x182BA3800")]
		private string BTZXSWHQCWU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B70", Offset = "0x2BA2B70", VA = "0x182BA3B70", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3BC0", Offset = "0x2BA2BC0", VA = "0x182BA3BC0")]
		public bool FNYFOTOAQQI([In] KNJBUTYALBM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B50", Offset = "0x2BA2B50", VA = "0x182BA3B50", Slot = "18")]
		public bool Equals(KNJBUTYALBM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B00", Offset = "0x2BA2B00", VA = "0x182BA3B00", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3CA0", Offset = "0x2BA2CA0", VA = "0x182BA3CA0", Slot = "14")]
		protected sealed override int MGRAVPAGNMN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2BA41C0", Offset = "0x2BA31C0", VA = "0x182BA41C0", Slot = "19")]
		private bool ZTFKAMLUVKT([In] KNJBUTYALBM other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class ZGFYCQAMKGH : EUKWVPLYZVT, IEquatable<ZGFYCQAMKGH>, VZURHGBSTCB<ZGFYCQAMKGH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8F20", Offset = "0x2BA7F20", VA = "0x182BA8F20")]
		private ZGFYCQAMKGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8D90", Offset = "0x2BA7D90", VA = "0x182BA8D90")]
		public static ZGFYCQAMKGH New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8EF0", Offset = "0x2BA7EF0", VA = "0x182BA8EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8E00", Offset = "0x2BA7E00", VA = "0x182BA8E00", Slot = "15")]
		public override string QOXGGEJDGZM(IReadOnlyList<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8C50", Offset = "0x2BA7C50", VA = "0x182BA8C50", Slot = "16")]
		public override int AGZWSANJZRT(IReadOnlyList<EUKWVPLYZVT> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8CA0", Offset = "0x2BA7CA0", VA = "0x182BA8CA0", Slot = "17")]
		public override bool EWHOFWMUTCE(IReadOnlyList<EUKWVPLYZVT> a, IReadOnlyList<EUKWVPLYZVT> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8D40", Offset = "0x2BA7D40", VA = "0x182BA8D40", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550")]
		public bool FNYFOTOAQQI([In] ZGFYCQAMKGH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xF7F660", Offset = "0xF7E660", VA = "0x180F7F660", Slot = "18")]
		public bool Equals(ZGFYCQAMKGH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8CF0", Offset = "0x2BA7CF0", VA = "0x182BA8CF0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550", Slot = "19")]
		private bool AGMPIXGRYUK([In] ZGFYCQAMKGH other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, VZURHGBSTCB<Property>, OBEOUKPJQRC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool YRPUXABTUCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int EWWYEECRRNP;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public EUKWVPLYZVT AHRPWOVSMCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool AJVXFLKUGHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool FUBXFHJQDPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x125B7E0", Offset = "0x125A7E0", VA = "0x18125B7E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4A60", Offset = "0x2BA3A60", VA = "0x182BA4A60")]
		private Property(EUKWVPLYZVT type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2BA47E0", Offset = "0x2BA37E0", VA = "0x182BA47E0")]
		public static Property New(EUKWVPLYZVT type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4870", Offset = "0x2BA3870", VA = "0x182BA4870", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2BA44A0", Offset = "0x2BA34A0", VA = "0x182BA44A0")]
		private string CSUCHYFQOYS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4A10", Offset = "0x2BA3A10", VA = "0x182BA4A10")]
		private string ZBOYFUMGGTY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4560", Offset = "0x2BA3560", VA = "0x182BA4560")]
		public bool FNYFOTOAQQI([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4540", Offset = "0x2BA3540", VA = "0x182BA4540", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA44F0", Offset = "0x2BA34F0", VA = "0x182BA44F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4660", Offset = "0x2BA3660", VA = "0x182BA4660", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4730", Offset = "0x2BA3730", VA = "0x182BA4730")]
		private int MGRAVPAGNMN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4950", Offset = "0x2BA3950", VA = "0x182BA4950", Slot = "6")]
		public int YLWIHPJRJFX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4720", Offset = "0x2BA3720", VA = "0x182BA4720", Slot = "5")]
		private bool MGIADADMRNM([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class PZKGSDSCYUI : EUKWVPLYZVT, IEquatable<PZKGSDSCYUI>, VZURHGBSTCB<PZKGSDSCYUI>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4480", Offset = "0x2BA3480", VA = "0x182BA4480")]
		private PZKGSDSCYUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4360", Offset = "0x2BA3360", VA = "0x182BA4360")]
		public static PZKGSDSCYUI New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4450", Offset = "0x2BA3450", VA = "0x182BA4450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2BA43D0", Offset = "0x2BA33D0", VA = "0x182BA43D0", Slot = "15")]
		public override string QOXGGEJDGZM(IReadOnlyList<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4310", Offset = "0x2BA3310", VA = "0x182BA4310", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550")]
		public bool FNYFOTOAQQI([In] PZKGSDSCYUI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF7F660", Offset = "0xF7E660", VA = "0x180F7F660", Slot = "18")]
		public bool Equals(PZKGSDSCYUI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2BA42C0", Offset = "0x2BA32C0", VA = "0x182BA42C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550", Slot = "19")]
		private bool CNPWYELHZLR([In] PZKGSDSCYUI other)
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
	public sealed class FJZUDWGOYIW : EUKWVPLYZVT, IEquatable<FJZUDWGOYIW>, VZURHGBSTCB<FJZUDWGOYIW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool PZITTNBQNJW
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E680", Offset = "0x2B9D680", VA = "0x182B9E680", Slot = "9")]
		public sealed override EUKWVPLYZVT SQAYJDGMQCC(IReadOnlyDictionary<string, EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E5B0", Offset = "0x2B9D5B0", VA = "0x182B9E5B0", Slot = "11")]
		public sealed override void JNSSDAYPMJE(Action<EUKWVPLYZVT> a, Action<EUKWVPLYZVT> b, Action<EUKWVPLYZVT> c, Action<EUKWVPLYZVT> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E760", Offset = "0x2B9D760", VA = "0x182B9E760")]
		private FJZUDWGOYIW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E600", Offset = "0x2B9D600", VA = "0x182B9E600")]
		public static FJZUDWGOYIW New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E560", Offset = "0x2B9D560", VA = "0x182B9E560", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550")]
		public bool FNYFOTOAQQI([In] FJZUDWGOYIW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xF7F660", Offset = "0xF7E660", VA = "0x180F7F660", Slot = "18")]
		public bool Equals(FJZUDWGOYIW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E500", Offset = "0x2B9D500", VA = "0x182B9E500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E5E0", Offset = "0x2B9D5E0", VA = "0x182B9E5E0", Slot = "14")]
		protected sealed override int MGRAVPAGNMN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550", Slot = "19")]
		private bool RIZDIQFVAVN([In] FJZUDWGOYIW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class DPRQGTECURV : EUKWVPLYZVT
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<JLWXGYSAWHT> TKENVPWUJSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DBB0", Offset = "0x2B9CBB0", VA = "0x182B9DBB0")]
		public void Initialize(DPRQGTECURV from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DCE0", Offset = "0x2B9CCE0", VA = "0x182B9DCE0")]
		protected DPRQGTECURV(IEnumerable<JLWXGYSAWHT> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool FNYFOTOAQQI([In] EUKWVPLYZVT other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DB50", Offset = "0x2B9CB50", VA = "0x182B9DB50")]
		protected bool FNYFOTOAQQI([In] DPRQGTECURV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DBE0", Offset = "0x2B9CBE0", VA = "0x182B9DBE0", Slot = "14")]
		protected override int MGRAVPAGNMN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DC60", Offset = "0x2B9CC60", VA = "0x182B9DC60")]
		protected int RHGFAYMMILR(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class JLWXGYSAWHT : EUKWVPLYZVT, IEquatable<JLWXGYSAWHT>, VZURHGBSTCB<JLWXGYSAWHT>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public EUKWVPLYZVT AYJTNIPAZUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3740", Offset = "0x2BA2740", VA = "0x182BA3740")]
		private JLWXGYSAWHT(string a, [Optional] EUKWVPLYZVT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3540", Offset = "0x2BA2540", VA = "0x182BA3540")]
		public static JLWXGYSAWHT New(string name, [Optional] EUKWVPLYZVT constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3640", Offset = "0x2BA2640", VA = "0x182BA3640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3420", Offset = "0x2BA2420", VA = "0x182BA3420", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3470", Offset = "0x2BA2470", VA = "0x182BA3470")]
		public bool FNYFOTOAQQI([In] JLWXGYSAWHT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BA33D0", Offset = "0x2BA23D0", VA = "0x182BA33D0", Slot = "18")]
		public bool Equals(JLWXGYSAWHT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3380", Offset = "0x2BA2380", VA = "0x182BA3380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BA34C0", Offset = "0x2BA24C0", VA = "0x182BA34C0", Slot = "14")]
		protected override int MGRAVPAGNMN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BA36D0", Offset = "0x2BA26D0", VA = "0x182BA36D0", Slot = "13")]
		public override int YLWIHPJRJFX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3470", Offset = "0x2BA2470", VA = "0x182BA3470", Slot = "19")]
		private bool UAPOOGHDSMC([In] JLWXGYSAWHT other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class HWEJLZJYMHX : EUKWVPLYZVT, IEquatable<HWEJLZJYMHX>, VZURHGBSTCB<HWEJLZJYMHX>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2B10", Offset = "0x2BA1B10", VA = "0x182BA2B10")]
		private HWEJLZJYMHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2980", Offset = "0x2BA1980", VA = "0x182BA2980")]
		public static HWEJLZJYMHX New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2AE0", Offset = "0x2BA1AE0", VA = "0x182BA2AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA29F0", Offset = "0x2BA19F0", VA = "0x182BA29F0", Slot = "15")]
		public override string QOXGGEJDGZM(IReadOnlyList<EUKWVPLYZVT> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2840", Offset = "0x2BA1840", VA = "0x182BA2840", Slot = "16")]
		public override int AGZWSANJZRT(IReadOnlyList<EUKWVPLYZVT> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2890", Offset = "0x2BA1890", VA = "0x182BA2890", Slot = "17")]
		public override bool EWHOFWMUTCE(IReadOnlyList<EUKWVPLYZVT> a, IReadOnlyList<EUKWVPLYZVT> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2930", Offset = "0x2BA1930", VA = "0x182BA2930", Slot = "12")]
		public override bool FNYFOTOAQQI([In] EUKWVPLYZVT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550")]
		public bool FNYFOTOAQQI([In] HWEJLZJYMHX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xF7F660", Offset = "0xF7E660", VA = "0x180F7F660", Slot = "18")]
		public bool Equals(HWEJLZJYMHX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2BA28E0", Offset = "0x2BA18E0", VA = "0x182BA28E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E550", Offset = "0x2B9D550", VA = "0x182B9E550", Slot = "19")]
		private bool UPLMYTFQBFA([In] HWEJLZJYMHX other)
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
			public readonly EUKWVPLYZVT CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			internal Impl(EUKWVPLYZVT circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2B9D180", Offset = "0x2B9C180", VA = "0x182B9D180")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D0B0", Offset = "0x2B9C0B0", VA = "0x182B9D0B0")]
		public static CircuitTypeOrString NSHZCSRSKJT(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D120", Offset = "0x2B9C120", VA = "0x182B9D120")]
		public static CircuitTypeOrString NSHZCSRSKJT(EUKWVPLYZVT a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D010", Offset = "0x2B9C010", VA = "0x182B9D010")]
		public EUKWVPLYZVT LJFZPSDCOVW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CEE0", Offset = "0x2B9BEE0", VA = "0x182B9CEE0")]
		public static EUKWVPLYZVT[] ITORTNPSPFN(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly XRXPBQAIJYE _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		private ClassFactoryBaseClasses(XRXPBQAIJYE data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x10E4B80", Offset = "0x10E3B80", VA = "0x1810E4B80")]
		public static ClassFactoryBaseClasses New(XRXPBQAIJYE data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D210", Offset = "0x2B9C210", VA = "0x182B9D210")]
		public ClassFactoryBaseClasses TDNXTIFPTKS(QNRICJJABYK a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x187BBC0", Offset = "0x187ABC0", VA = "0x18187BBC0")]
		public ClassFactoryProps MDHEJSQHBHH()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D1B0", Offset = "0x2B9C1B0", VA = "0x182B9D1B0")]
		public ClassFactoryProps PVFMCTUOQHU(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D2D0", Offset = "0x2B9C2D0", VA = "0x182B9D2D0")]
		public QNRICJJABYK ZQHOKUWTOCH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class XRXPBQAIJYE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? OSRJHZIEHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string PAVMQALYVSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<JLWXGYSAWHT> TKENVPWUJSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<QNRICJJABYK> DZDITQVYUEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> YVFFJRZFCRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, KNJBUTYALBM>> KVWSKQPTBXB;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8430", Offset = "0x2BA7430", VA = "0x182BA8430")]
		private XRXPBQAIJYE([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8280", Offset = "0x2BA7280", VA = "0x182BA8280")]
		public static XRXPBQAIJYE New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly XRXPBQAIJYE _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		private ClassFactoryFuncs(XRXPBQAIJYE data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x10E4B80", Offset = "0x10E3B80", VA = "0x1810E4B80")]
		public static ClassFactoryFuncs New(XRXPBQAIJYE data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D320", Offset = "0x2B9C320", VA = "0x182B9D320")]
		public QNRICJJABYK ZQHOKUWTOCH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly XRXPBQAIJYE _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		public ClassFactoryProps(XRXPBQAIJYE data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D470", Offset = "0x2B9C470", VA = "0x182B9D470")]
		public ClassFactoryProps PVFMCTUOQHU(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x187BBC0", Offset = "0x187ABC0", VA = "0x18187BBC0")]
		public ClassFactoryFuncs GQMZNRPCFPK()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D600", Offset = "0x2B9C600", VA = "0x182B9D600")]
		public QNRICJJABYK ZQHOKUWTOCH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly XRXPBQAIJYE _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		private ClassFactoryTypeParams(XRXPBQAIJYE data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D8E0", Offset = "0x2B9C8E0", VA = "0x182B9D8E0")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D640", Offset = "0x2B9C640", VA = "0x182B9D640")]
		public ClassFactoryTypeParams MUVZKHXMFFW(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x187BBC0", Offset = "0x187ABC0", VA = "0x18187BBC0")]
		public ClassFactoryBaseClasses OBGJSHVRJSM()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DAB0", Offset = "0x2B9CAB0", VA = "0x182B9DAB0")]
		public ClassFactoryBaseClasses TDNXTIFPTKS(QNRICJJABYK a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DAF0", Offset = "0x2B9CAF0", VA = "0x182B9DAF0")]
		public QNRICJJABYK ZQHOKUWTOCH()
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
