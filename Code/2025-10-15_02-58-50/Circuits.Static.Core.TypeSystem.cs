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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class VJBGGKQUSTY : IEquatable<VJBGGKQUSTY>, IWKTMLXEDYU<VJBGGKQUSTY>, KVCBYXRVPIV
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool NHDHLJLHSXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool XZHIFKZBJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int KRBEJCWQIMA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind KFDHSHLWAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAA950", Offset = "0xAA9750", VA = "0x180AAA950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? JADSNVUIVMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B430D0", Offset = "0x2B41ED0", VA = "0x182B430D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual VJBGGKQUSTY PHMBYVHHESA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool VCIBOKLBHLX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B43750", Offset = "0x2B42550", VA = "0x182B43750")]
		public static void YXKPQQSUPQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
		protected VJBGGKQUSTY(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B43450", Offset = "0x2B42250", VA = "0x182B43450")]
		public static VJBGGKQUSTY New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30")]
		protected static a FTBSQEXPLTU<a>(a a) where a : VJBGGKQUSTY
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30", Slot = "9")]
		public virtual VJBGGKQUSTY NCRZCUWRTCF(IReadOnlyDictionary<string, VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B43420", Offset = "0x2B42220", VA = "0x182B43420", Slot = "11")]
		public virtual void LCBMAGEAVYX(Action<VJBGGKQUSTY> a, Action<VJBGGKQUSTY> b, Action<VJBGGKQUSTY> c, Action<VJBGGKQUSTY> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B43500", Offset = "0x2B42300", VA = "0x182B43500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B43220", Offset = "0x2B42020", VA = "0x182B43220", Slot = "12")]
		public virtual bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B43050", Offset = "0x2B41E50", VA = "0x182B43050", Slot = "4")]
		public bool Equals(VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B43080", Offset = "0x2B41E80", VA = "0x182B43080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B434C0", Offset = "0x2B422C0", VA = "0x182B434C0")]
		public static bool TRHVNHMHPTX(VJBGGKQUSTY a, VJBGGKQUSTY b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B43670", Offset = "0x2B42470", VA = "0x182B43670")]
		public static bool VVLYKZHTTRM(VJBGGKQUSTY a, VJBGGKQUSTY b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B43140", Offset = "0x2B41F40", VA = "0x182B43140", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B431F0", Offset = "0x2B41FF0", VA = "0x182B431F0", Slot = "13")]
		public virtual int HUMYXEZEENE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B431F0", Offset = "0x2B41FF0", VA = "0x182B431F0", Slot = "14")]
		protected virtual int LQQHYKQWPBM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E2D0", Offset = "0x3E7D0D0", VA = "0x183E7E2D0")]
		public b WIRIENBEYYQ<b>() where b : VJBGGKQUSTY
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B39190", Offset = "0x2B37F90", VA = "0x182B39190", Slot = "15")]
		public virtual string KOYROKBXKQT(IReadOnlyList<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B43700", Offset = "0x2B42500", VA = "0x182B43700", Slot = "16")]
		public virtual int XJVDNWTLDHW(IReadOnlyList<VJBGGKQUSTY> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B436B0", Offset = "0x2B424B0", VA = "0x182B436B0", Slot = "17")]
		public virtual bool WABMDFFXAZX(IReadOnlyList<VJBGGKQUSTY> a, IReadOnlyList<VJBGGKQUSTY> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B432C0", Offset = "0x2B420C0", VA = "0x182B432C0")]
		public SCTFVGOUTWF KLQZGCUOFVB(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B43410", Offset = "0x2B42210", VA = "0x182B43410")]
		public SCTFVGOUTWF KLQZGCUOFVB(params VJBGGKQUSTY[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B43410", Offset = "0x2B42210", VA = "0x182B43410")]
		public SCTFVGOUTWF KLQZGCUOFVB(IEnumerable<VJBGGKQUSTY> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface YUERGOQQINL<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a JLSBFIBHNTV(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b LZGCBFDTKHL([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind VSNQGOVPRBV([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates KDZUZAKJCJU(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KVCBYXRVPIV
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HUMYXEZEENE(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class HUMYXEZEENE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class NTBZNHQZZOS<a> where a : KVCBYXRVPIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int LMZORMOZZNZ;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public NTBZNHQZZOS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5A401A0", Offset = "0x5A3EFA0", VA = "0x185A401A0")]
			internal int WEBYGXXWKCT(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GDYTGCHDMUU<a, b> where b : KVCBYXRVPIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int LMZORMOZZNZ;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public GDYTGCHDMUU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x50A2060", Offset = "0x50A0E60", VA = "0x1850A2060")]
			internal int WEBYGXXWKCT(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class UMOPTNJAXIU<a> where a : KVCBYXRVPIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int LMZORMOZZNZ;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public UMOPTNJAXIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x62DD7F0", Offset = "0x62DC5F0", VA = "0x1862DD7F0")]
			internal int QNPOLBPXDVG(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3907BA0", Offset = "0x39069A0", VA = "0x183907BA0")]
		public static int WSALFVKMSYV<a>(this IEnumerable<a> a, int b = 0) where a : KVCBYXRVPIV
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3907C70", Offset = "0x3906A70", VA = "0x183907C70")]
		public static int WSALFVKMSYV<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : KVCBYXRVPIV
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3907BA0", Offset = "0x39069A0", VA = "0x183907BA0")]
		public static int KMKJIMENVKE<d>(this IEnumerable<d> a, int b = 0) where d : KVCBYXRVPIV
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : YUERGOQQINL<TDirectedType, VJBGGKQUSTY, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4324010", Offset = "0x4322E10", VA = "0x184324010")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62A0380", Offset = "0x629F180", VA = "0x1862A0380")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class CJTRGTGMEFC
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OLARDXERZMM<a, b, c> where c : YUERGOQQINL<a, VJBGGKQUSTY, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public VJBGGKQUSTY GEKBIRPOIPW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<VJBGGKQUSTY> USYRQJFWCDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public VJBGGKQUSTY OWNMXIQJXIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<VJBGGKQUSTY> DXQKPHPNAJS;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OLARDXERZMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5B5A6D0", Offset = "0x5B594D0", VA = "0x185B5A6D0")]
			internal bool BRVJOROXZHM([In] TypeSys<a, b, c> self_, VJBGGKQUSTY a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5B5A440", Offset = "0x5B59240", VA = "0x185B5A440")]
			internal bool BRQCRKVAPWD([In] TypeSys<a, b, c> self_, VJBGGKQUSTY a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5B5A760", Offset = "0x5B59560", VA = "0x185B5A760")]
			internal bool BSQLDSQNLAW([In] TypeSys<a, b, c> self_, VJBGGKQUSTY a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class WCBCICOYLMH<a, b, c> where c : YUERGOQQINL<a, VJBGGKQUSTY, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public VJBGGKQUSTY WURLFXPLTZU;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WCBCICOYLMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6759770", Offset = "0x6758570", VA = "0x186759770")]
			internal bool BSVSAZKKUMF([In] TypeSys<a, b, c> self__, VJBGGKQUSTY a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class THUSZKRKYWG<a, b, c> where c : YUERGOQQINL<a, VJBGGKQUSTY, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b DSTQIKJKEHN;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public THUSZKRKYWG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x60EAEF0", Offset = "0x60E9CF0", VA = "0x1860EAEF0")]
			internal VJBGGKQUSTY VGWEBZCSFVP([In] TypeSys<a, b, c> self_, [In] b root_, VJBGGKQUSTY a, VJBGGKQUSTY b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class IGMTQXXDZDD<a, b, c> where c : YUERGOQQINL<a, VJBGGKQUSTY, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NITOSEZCQPT WGKCPUJDOSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public NITOSEZCQPT VGUKPTYSVKR;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public IGMTQXXDZDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x51E02F0", Offset = "0x51DF0F0", VA = "0x1851E02F0")]
			internal a VGGJKEVADNO([In] TypeSys<a, b, c> self_, IOKind a, NITOSEZCQPT b, NITOSEZCQPT c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class XUYAMMAABUA<a, b, c> where c : YUERGOQQINL<a, VJBGGKQUSTY, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<NITOSEZCQPT> CDEQSUVMQPX;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public XUYAMMAABUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x40A72E0", Offset = "0x40A60E0", VA = "0x1840A72E0")]
			internal bool LGFVDCMQKQG(bool a, NITOSEZCQPT b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] SYIXCICCRMB;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x36EBC40", Offset = "0x36EAA40", VA = "0x1836EBC40")]
		public static bool OJGOFWMLRCA<a, b, c>([In] this TypeSys<a, b, c> _, VJBGGKQUSTY a) where c : YUERGOQQINL<a, VJBGGKQUSTY, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x36EBC60", Offset = "0x36EAA60", VA = "0x1836EBC60")]
		public static bool SPPEXRGAMHH<d, e, f>([In] this TypeSys<d, e, f> _, VJBGGKQUSTY a) where f : YUERGOQQINL<d, VJBGGKQUSTY, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x36EBAA0", Offset = "0x36EA8A0", VA = "0x1836EBAA0")]
		public static bool EAVWEIXRRYX<g, h, i>([In] this TypeSys<g, h, i> self, VJBGGKQUSTY a, VJBGGKQUSTY b) where i : YUERGOQQINL<g, VJBGGKQUSTY, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x36E2C10", Offset = "0x36E1A10", VA = "0x1836E2C10")]
		private static bool BVLKTJFBTFM<j, k, l>([In] this TypeSys<j, k, l> self, VJBGGKQUSTY a, VJBGGKQUSTY b, IReadOnlyList<VJBGGKQUSTY> c, IReadOnlyList<VJBGGKQUSTY> d) where l : YUERGOQQINL<j, VJBGGKQUSTY, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x36E6C20", Offset = "0x36E5A20", VA = "0x1836E6C20")]
		public static VJBGGKQUSTY CHTSACTZDFC<m, n, o>([In] this TypeSys<m, n, o> self, n a, VJBGGKQUSTY b, VJBGGKQUSTY c) where o : YUERGOQQINL<m, VJBGGKQUSTY, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x36E3DC0", Offset = "0x36E2BC0", VA = "0x1836E3DC0")]
		public static p CHTSACTZDFC<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : YUERGOQQINL<p, VJBGGKQUSTY, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x36ECB40", Offset = "0x36EB940", VA = "0x1836ECB40")]
		private static List<w> YMSIIGPBXRY<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : YUERGOQQINL<t, VJBGGKQUSTY, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x36EC4C0", Offset = "0x36EB2C0", VA = "0x1836EC4C0")]
		private static ba WDEBGKFLYCY<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class HJZNCHWCBNN
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static VJBGGKQUSTY ZLZHJYHPAFS
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B39D30", Offset = "0x2B38B30", VA = "0x182B39D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static VJBGGKQUSTY YQWQLYTYNYC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2B39B60", Offset = "0x2B38960", VA = "0x182B39B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static VJBGGKQUSTY RXKYHXHFPPD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A140", Offset = "0x2B38F40", VA = "0x182B3A140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static VJBGGKQUSTY QSUJNYYAHUB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B39BB0", Offset = "0x2B389B0", VA = "0x182B39BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static VJBGGKQUSTY WTHJIKLJHXH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B3A360", Offset = "0x2B39160", VA = "0x182B3A360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static VJBGGKQUSTY UFPMKCPJBDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B39CE0", Offset = "0x2B38AE0", VA = "0x182B39CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static VJBGGKQUSTY WHLSRYCELAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B39D80", Offset = "0x2B38B80", VA = "0x182B39D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static VJBGGKQUSTY UANDWHXXWUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B39C00", Offset = "0x2B38A00", VA = "0x182B39C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B39DD0", Offset = "0x2B38BD0", VA = "0x182B39DD0")]
		public static SCTFVGOUTWF PLHJLRGHOHT([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B39C50", Offset = "0x2B38A50", VA = "0x182B39C50")]
		public static SCTFVGOUTWF GUWFUMGQDFD(IEnumerable<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A0B0", Offset = "0x2B38EB0", VA = "0x182B3A0B0")]
		public static SCTFVGOUTWF TANVMIDNSLV(IEnumerable<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B39F00", Offset = "0x2B38D00", VA = "0x182B39F00")]
		public static SCTFVGOUTWF TANVMIDNSLV(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B39AD0", Offset = "0x2B388D0", VA = "0x182B39AD0")]
		public static SCTFVGOUTWF CGPUQGGCUUK(IEnumerable<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A190", Offset = "0x2B38F90", VA = "0x182B3A190")]
		public static JBBNTWVSRYS VOVWIUEGDAR(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class SCTFVGOUTWF : VJBGGKQUSTY, IEquatable<SCTFVGOUTWF>, IWKTMLXEDYU<SCTFVGOUTWF>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DSSMKGTENMR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, VJBGGKQUSTY> ADFEDOPMSDZ;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public DSSMKGTENMR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B38E30", Offset = "0x2B37C30", VA = "0x182B38E30")]
			internal VJBGGKQUSTY CSUWKTPVBRN(VJBGGKQUSTY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public VJBGGKQUSTY FLCNVFJKQWF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override VJBGGKQUSTY PHMBYVHHESA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<VJBGGKQUSTY> IEEEPHTWELC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool VCIBOKLBHLX
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B405D0", Offset = "0x2B3F3D0", VA = "0x182B405D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B40B60", Offset = "0x2B3F960", VA = "0x182B40B60", Slot = "9")]
		public sealed override VJBGGKQUSTY NCRZCUWRTCF(IReadOnlyDictionary<string, VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B40850", Offset = "0x2B3F650", VA = "0x182B40850", Slot = "11")]
		public sealed override void LCBMAGEAVYX(Action<VJBGGKQUSTY> a, Action<VJBGGKQUSTY> b, Action<VJBGGKQUSTY> c, Action<VJBGGKQUSTY> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B40D50", Offset = "0x2B3FB50", VA = "0x182B40D50")]
		private SCTFVGOUTWF(VJBGGKQUSTY a, IEnumerable<VJBGGKQUSTY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B40C80", Offset = "0x2B3FA80", VA = "0x182B40C80")]
		public static SCTFVGOUTWF New(VJBGGKQUSTY originalType, IEnumerable<VJBGGKQUSTY> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B40D00", Offset = "0x2B3FB00", VA = "0x182B40D00", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B40760", Offset = "0x2B3F560", VA = "0x182B40760", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B407B0", Offset = "0x2B3F5B0", VA = "0x182B407B0")]
		public bool JECCPMWTKQN([In] SCTFVGOUTWF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B40740", Offset = "0x2B3F540", VA = "0x182B40740", Slot = "18")]
		public bool Equals(SCTFVGOUTWF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B406F0", Offset = "0x2B3F4F0", VA = "0x182B406F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B40AB0", Offset = "0x2B3F8B0", VA = "0x182B40AB0", Slot = "14")]
		protected override int LQQHYKQWPBM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B40D40", Offset = "0x2B3FB40", VA = "0x182B40D40", Slot = "19")]
		private bool XSGXKTDZYME([In] SCTFVGOUTWF other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class JFBSUSMJRDK : VJBGGKQUSTY, IEquatable<JFBSUSMJRDK>, IWKTMLXEDYU<JFBSUSMJRDK>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B150", Offset = "0x2B39F50", VA = "0x182B3B150")]
		private JFBSUSMJRDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B080", Offset = "0x2B39E80", VA = "0x182B3B080")]
		public static JFBSUSMJRDK New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B0F0", Offset = "0x2B39EF0", VA = "0x182B3B0F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AFF0", Offset = "0x2B39DF0", VA = "0x182B3AFF0", Slot = "15")]
		public sealed override string KOYROKBXKQT(IReadOnlyList<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AF60", Offset = "0x2B39D60", VA = "0x182B3AF60")]
		private static string ICVSEDUACWR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AFA0", Offset = "0x2B39DA0", VA = "0x182B3AFA0", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0")]
		public bool JECCPMWTKQN([In] JFBSUSMJRDK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xBBDAB0", Offset = "0xBBC8B0", VA = "0x180BBDAB0", Slot = "18")]
		public bool Equals(JFBSUSMJRDK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AF10", Offset = "0x2B39D10", VA = "0x182B3AF10", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0", Slot = "19")]
		private bool VMDZGIMLPKH([In] JFBSUSMJRDK other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class KTVIHIVMNEB
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class BLFBRGQSUPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public VJBGGKQUSTY OJOQPYEMQGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<VJBGGKQUSTY, SCTFVGOUTWF> JMNVJOQQKAR;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public BLFBRGQSUPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B37E10", Offset = "0x2B36C10", VA = "0x182B37E10")]
			internal SCTFVGOUTWF PNHPPBVDJST(VJBGGKQUSTY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BLKIONKQEAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public VJBGGKQUSTY CYLQDNSCUQF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<VJBGGKQUSTY, SCTFVGOUTWF> XRCCHAZLCCP;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public BLKIONKQEAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B37F90", Offset = "0x2B36D90", VA = "0x182B37F90")]
			internal SCTFVGOUTWF EIHVQJAIZCJ(VJBGGKQUSTY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C180", Offset = "0x2B3AF80", VA = "0x182B3C180")]
		public static IEnumerable<NITOSEZCQPT> HXAJBDQQGZD(this NITOSEZCQPT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C0C0", Offset = "0x2B3AEC0", VA = "0x182B3C0C0")]
		private static IEnumerable<NITOSEZCQPT> GOZTHKFGBWX(this NITOSEZCQPT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DFE0", Offset = "0x2B3CDE0", VA = "0x182B3DFE0")]
		public static (VJBGGKQUSTY, IReadOnlyList<VJBGGKQUSTY>, bool) YOKYKYNDKKZ(this VJBGGKQUSTY a, [Optional] IReadOnlyList<VJBGGKQUSTY> b)
		{
			return default((VJBGGKQUSTY, IReadOnlyList<VJBGGKQUSTY>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C3F0", Offset = "0x2B3B1F0", VA = "0x182B3C3F0")]
		public static TypeKind OMTRLHFZJRY(this VJBGGKQUSTY a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B220", Offset = "0x2B3A020", VA = "0x182B3B220")]
		private static VJBGGKQUSTY ConvertClassesToIntersections(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BD00", Offset = "0x2B3AB00", VA = "0x182B3BD00")]
		private static VJBGGKQUSTY DistributeUnionIntoIntersection(this SCTFVGOUTWF self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B870", Offset = "0x2B3A670", VA = "0x182B3B870")]
		private static VJBGGKQUSTY DistributeIntersectionIntoIntersection(this SCTFVGOUTWF self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3BBA0", Offset = "0x2B3A9A0", VA = "0x182B3BBA0")]
		private static VJBGGKQUSTY DistributeIntoIntersection(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C420", Offset = "0x2B3B220", VA = "0x182B3C420")]
		private static bool OtherIsAssignableToOther(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes, VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D840", Offset = "0x2B3C640", VA = "0x182B3D840")]
		private static bool UnionIsAssignableToOther(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes, VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C5B0", Offset = "0x2B3B3B0", VA = "0x182B3C5B0")]
		private static bool OtherIsAssignableToUnion(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes, VJBGGKQUSTY union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DB70", Offset = "0x2B3C970", VA = "0x182B3DB70")]
		private static bool UnionIsAssignableToUnion(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes, VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D640", Offset = "0x2B3C440", VA = "0x182B3D640")]
		public static VJBGGKQUSTY RemoveCommonTypesFromIntersectionDistribution(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C960", Offset = "0x2B3B760", VA = "0x182B3C960")]
		public static VJBGGKQUSTY RemoveCommonTypesFromIntersectionDistributionInternal(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B3D770", Offset = "0x2B3C570", VA = "0x182B3D770")]
		public static VJBGGKQUSTY SimplifyIntersectionUnion(this VJBGGKQUSTY self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C3A0", Offset = "0x2B3B1A0", VA = "0x182B3C3A0")]
		public static IEnumerable<VJBGGKQUSTY> IEEEPHTWELC(this VJBGGKQUSTY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B3C030", Offset = "0x2B3AE30", VA = "0x182B3C030")]
		public static IEnumerable<VJBGGKQUSTY> GGPCDGUYAOX(this VJBGGKQUSTY a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class NITOSEZCQPT : AUZZFVIHGIC, IEquatable<NITOSEZCQPT>, IWKTMLXEDYU<NITOSEZCQPT>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class RXWWDEQUIXS : IEnumerable<NITOSEZCQPT>, IEnumerable, IEnumerator<NITOSEZCQPT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private NITOSEZCQPT KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public NITOSEZCQPT SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<NITOSEZCQPT> RSQQLXOAUXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private NITOSEZCQPT TCGQWMJYWFS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<NITOSEZCQPT> RTBEGLBVNTX;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private NITOSEZCQPT OIBETYEWJQU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
			[DebuggerHidden]
			public RXWWDEQUIXS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2B3FF40", Offset = "0x2B3ED40", VA = "0x182B3FF40", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2B400D0", Offset = "0x2B3EED0", VA = "0x182B400D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2B40530", Offset = "0x2B3F330", VA = "0x182B40530")]
			private void XVTZRJOPNYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B40580", Offset = "0x2B3F380", VA = "0x182B40580")]
			private void XWJUJDWHQGV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B40090", Offset = "0x2B3EE90", VA = "0x182B40090", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2B40490", Offset = "0x2B3F290", VA = "0x182B40490", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NITOSEZCQPT> ZMQEGWCLFBN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B40490", Offset = "0x2B3F290", VA = "0x182B40490", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> XRHZJACSFIZ;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, NITOSEZCQPT> AIXUHZYGRWK;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, NITOSEZCQPT> XDRUXBORTYW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B3EF40", Offset = "0x2B3DD40", VA = "0x182B3EF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? JADSNVUIVMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid WBRSHDLSFDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xFBF370", Offset = "0xFBE170", VA = "0x180FBF370")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xFBEBC0", Offset = "0xFBD9C0", VA = "0x180FBEBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BD0", Offset = "0xA9F9D0", VA = "0x180AA0BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<NITOSEZCQPT> MLMZGMMZYJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC10", Offset = "0xA9DA10", VA = "0x180A9EC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<NITOSEZCQPT> EWZOSDFOTDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E2E0", Offset = "0x2B3D0E0", VA = "0x182B3E2E0")]
			[IteratorStateMachine(typeof(RXWWDEQUIXS))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> DZDMQGNNMJU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAA19A0", Offset = "0xAA07A0", VA = "0x180AA19A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAA19B0", Offset = "0xAA07B0", VA = "0x180AA19B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, GHEURDYOPHV> VQXLDKFGIVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAA1950", Offset = "0xAA0750", VA = "0x180AA1950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA1990", Offset = "0xAA0790", VA = "0x180AA1990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F520", Offset = "0x2B3E320", VA = "0x182B3F520")]
		public NITOSEZCQPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F580", Offset = "0x2B3E380", VA = "0x182B3F580")]
		public NITOSEZCQPT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F130", Offset = "0x2B3DF30", VA = "0x182B3F130")]
		public static NITOSEZCQPT VAJERCQOZPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EF90", Offset = "0x2B3DD90", VA = "0x182B3EF90")]
		public static NITOSEZCQPT RUIASQBTHTO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E360", Offset = "0x2B3D160", VA = "0x182B3E360")]
		public void Initialize(NITOSEZCQPT from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F270", Offset = "0x2B3E070", VA = "0x182B3F270")]
		private NITOSEZCQPT([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<JBBNTWVSRYS> c, [Optional] IEnumerable<NITOSEZCQPT> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, GHEURDYOPHV>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EE60", Offset = "0x2B3DC60", VA = "0x182B3EE60")]
		public static NITOSEZCQPT New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<JBBNTWVSRYS> typeParameters, [Optional] IEnumerable<NITOSEZCQPT> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, GHEURDYOPHV>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EFE0", Offset = "0x2B3DDE0", VA = "0x182B3EFE0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F0D0", Offset = "0x2B3DED0", VA = "0x182B3F0D0")]
		private string UJXOORXKARA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E1B0", Offset = "0x2B3CFB0", VA = "0x182B3E1B0")]
		private static string DVYVQSVEGUD(IEnumerable<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E7A0", Offset = "0x2B3D5A0", VA = "0x182B3E7A0")]
		private string LJOLTEHUFUW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EB90", Offset = "0x2B3D990", VA = "0x182B3EB90")]
		private string LZTOFYBVYTZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E6D0", Offset = "0x2B3D4D0", VA = "0x182B3E6D0", Slot = "15")]
		public sealed override string KOYROKBXKQT(IReadOnlyList<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E560", Offset = "0x2B3D360", VA = "0x182B3E560", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E5B0", Offset = "0x2B3D3B0", VA = "0x182B3E5B0")]
		public bool JECCPMWTKQN([In] NITOSEZCQPT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E270", Offset = "0x2B3D070", VA = "0x182B3E270", Slot = "18")]
		public bool Equals(NITOSEZCQPT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E290", Offset = "0x2B3D090", VA = "0x182B3E290", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EA80", Offset = "0x2B3D880", VA = "0x182B3EA80", Slot = "14")]
		protected override int LQQHYKQWPBM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B3EF30", Offset = "0x2B3DD30", VA = "0x182B3EF30", Slot = "19")]
		private bool OSDJHOGTTMO([In] NITOSEZCQPT other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class YQDQZMPTQUI
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<VJBGGKQUSTY> NWSFSKLIBBZ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<NITOSEZCQPT> KSKDDVDQWSK;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, JBBNTWVSRYS> URHNKRDQTNN;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> XNIKFVVDBPL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, GHEURDYOPHV> WLFBVAMUPVS;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class KFSWBVJWGSR : IEquatable<KFSWBVJWGSR>, IWKTMLXEDYU<KFSWBVJWGSR>, KVCBYXRVPIV
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public VJBGGKQUSTY QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		private KFSWBVJWGSR(VJBGGKQUSTY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B1C0", Offset = "0x2B39FC0", VA = "0x182B3B1C0")]
		public static KFSWBVJWGSR New(VJBGGKQUSTY type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AF82F0", Offset = "0x2AF70F0", VA = "0x182AF82F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B39A20", Offset = "0x2B38820", VA = "0x182B39A20")]
		public bool JECCPMWTKQN([In] KFSWBVJWGSR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B399A0", Offset = "0x2B387A0", VA = "0x182B399A0", Slot = "4")]
		public bool Equals(KFSWBVJWGSR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B170", Offset = "0x2B39F70", VA = "0x182B3B170", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B11380", Offset = "0x2B10180", VA = "0x182B11380", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B399F0", Offset = "0x2B387F0", VA = "0x182B399F0", Slot = "6")]
		public int HUMYXEZEENE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B39A20", Offset = "0x2B38820", VA = "0x182B39A20", Slot = "5")]
		private bool ZEZPUWMWDKG([In] KFSWBVJWGSR other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class GHJNOPDDBJM : IEquatable<GHJNOPDDBJM>, IWKTMLXEDYU<GHJNOPDDBJM>, KVCBYXRVPIV
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public VJBGGKQUSTY QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		private GHJNOPDDBJM(VJBGGKQUSTY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B39A70", Offset = "0x2B38870", VA = "0x182B39A70")]
		public static GHJNOPDDBJM New(VJBGGKQUSTY type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF82F0", Offset = "0x2AF70F0", VA = "0x182AF82F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B39A20", Offset = "0x2B38820", VA = "0x182B39A20")]
		public bool JECCPMWTKQN([In] GHJNOPDDBJM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B399A0", Offset = "0x2B387A0", VA = "0x182B399A0", Slot = "4")]
		public bool Equals(GHJNOPDDBJM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B39950", Offset = "0x2B38750", VA = "0x182B39950", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B11380", Offset = "0x2B10180", VA = "0x182B11380", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B399F0", Offset = "0x2B387F0", VA = "0x182B399F0", Slot = "6")]
		public int HUMYXEZEENE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B39A20", Offset = "0x2B38820", VA = "0x182B39A20", Slot = "5")]
		private bool THATJSTFTSX([In] GHJNOPDDBJM other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class GHEURDYOPHV : AUZZFVIHGIC, IEquatable<GHEURDYOPHV>, IWKTMLXEDYU<GHEURDYOPHV>, KVCBYXRVPIV
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, KFSWBVJWGSR>> NIMXKGFJHZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, GHJNOPDDBJM>> TGOZBFGIPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B39860", Offset = "0x2B38660", VA = "0x182B39860")]
		private GHEURDYOPHV(IEnumerable<JBBNTWVSRYS> a, IEnumerable<KeyValuePair<string, KFSWBVJWGSR>> b, IEnumerable<KeyValuePair<string, GHJNOPDDBJM>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B39290", Offset = "0x2B38090", VA = "0x182B39290")]
		public static GHEURDYOPHV New(IEnumerable<JBBNTWVSRYS> typeParameters, IEnumerable<KeyValuePair<string, KFSWBVJWGSR>> inputs, IEnumerable<KeyValuePair<string, GHJNOPDDBJM>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B39550", Offset = "0x2B38350", VA = "0x182B39550", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B39190", Offset = "0x2B37F90", VA = "0x182B39190", Slot = "15")]
		public sealed override string KOYROKBXKQT(IReadOnlyList<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B393C0", Offset = "0x2B381C0", VA = "0x182B393C0")]
		private string PIEEVHBHNJU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B38E70", Offset = "0x2B37C70", VA = "0x182B38E70")]
		private string ATZQYBFSWFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B39060", Offset = "0x2B37E60", VA = "0x182B39060", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B390B0", Offset = "0x2B37EB0", VA = "0x182B390B0")]
		public bool JECCPMWTKQN([In] GHEURDYOPHV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B39040", Offset = "0x2B37E40", VA = "0x182B39040", Slot = "18")]
		public bool Equals(GHEURDYOPHV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B38FF0", Offset = "0x2B37DF0", VA = "0x182B38FF0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B391B0", Offset = "0x2B37FB0", VA = "0x182B391B0", Slot = "14")]
		protected sealed override int LQQHYKQWPBM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B39540", Offset = "0x2B38340", VA = "0x182B39540", Slot = "19")]
		private bool QGDQOREQPZE([In] GHEURDYOPHV other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class OUZXOVTWKBA : VJBGGKQUSTY, IEquatable<OUZXOVTWKBA>, IWKTMLXEDYU<OUZXOVTWKBA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F900", Offset = "0x2B3E700", VA = "0x182B3F900")]
		private OUZXOVTWKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F7C0", Offset = "0x2B3E5C0", VA = "0x182B3F7C0")]
		public static OUZXOVTWKBA New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F830", Offset = "0x2B3E630", VA = "0x182B3F830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F6D0", Offset = "0x2B3E4D0", VA = "0x182B3F6D0", Slot = "15")]
		public override string KOYROKBXKQT(IReadOnlyList<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F8B0", Offset = "0x2B3E6B0", VA = "0x182B3F8B0", Slot = "16")]
		public override int XJVDNWTLDHW(IReadOnlyList<VJBGGKQUSTY> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F860", Offset = "0x2B3E660", VA = "0x182B3F860", Slot = "17")]
		public override bool WABMDFFXAZX(IReadOnlyList<VJBGGKQUSTY> a, IReadOnlyList<VJBGGKQUSTY> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F680", Offset = "0x2B3E480", VA = "0x182B3F680", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0")]
		public bool JECCPMWTKQN([In] OUZXOVTWKBA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xBBDAB0", Offset = "0xBBC8B0", VA = "0x180BBDAB0", Slot = "18")]
		public bool Equals(OUZXOVTWKBA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F630", Offset = "0x2B3E430", VA = "0x182B3F630", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0", Slot = "19")]
		private bool LQTJRIPCSJV([In] OUZXOVTWKBA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, IWKTMLXEDYU<Property>, KVCBYXRVPIV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool XZHIFKZBJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int KRBEJCWQIMA;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public VJBGGKQUSTY QHIGGIBDJUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool LIOPGJMHXFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB869E0", VA = "0x180B87BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool QWAVOJRNPNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x12B98C0", Offset = "0x12B86C0", VA = "0x1812B98C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FEE0", Offset = "0x2B3ECE0", VA = "0x182B3FEE0")]
		private Property(VJBGGKQUSTY type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FD20", Offset = "0x2B3EB20", VA = "0x182B3FD20")]
		public static Property New(VJBGGKQUSTY type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FE00", Offset = "0x2B3EC00", VA = "0x182B3FE00", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FDB0", Offset = "0x2B3EBB0", VA = "0x182B3FDB0")]
		private string SKNVINUKZLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FC20", Offset = "0x2B3EA20", VA = "0x182B3FC20")]
		private string KWCCXRYERMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FB20", Offset = "0x2B3E920", VA = "0x182B3FB20")]
		public bool JECCPMWTKQN([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F980", Offset = "0x2B3E780", VA = "0x182B3F980", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F930", Offset = "0x2B3E730", VA = "0x182B3F930", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F9A0", Offset = "0x2B3E7A0", VA = "0x182B3F9A0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FC70", Offset = "0x2B3EA70", VA = "0x182B3FC70")]
		private int LQQHYKQWPBM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3FA60", Offset = "0x2B3E860", VA = "0x182B3FA60", Slot = "6")]
		public int HUMYXEZEENE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3F920", Offset = "0x2B3E720", VA = "0x182B3F920", Slot = "5")]
		private bool EMWJZOLLMVZ([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class VZVEWXRZWLR : VJBGGKQUSTY, IEquatable<VZVEWXRZWLR>, IWKTMLXEDYU<VZVEWXRZWLR>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2B439A0", Offset = "0x2B427A0", VA = "0x182B439A0")]
		private VZVEWXRZWLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2B43900", Offset = "0x2B42700", VA = "0x182B43900")]
		public static VZVEWXRZWLR New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2B43970", Offset = "0x2B42770", VA = "0x182B43970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2B43880", Offset = "0x2B42680", VA = "0x182B43880", Slot = "15")]
		public override string KOYROKBXKQT(IReadOnlyList<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2B43830", Offset = "0x2B42630", VA = "0x182B43830", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0")]
		public bool JECCPMWTKQN([In] VZVEWXRZWLR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xBBDAB0", Offset = "0xBBC8B0", VA = "0x180BBDAB0", Slot = "18")]
		public bool Equals(VZVEWXRZWLR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2B437E0", Offset = "0x2B425E0", VA = "0x182B437E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0", Slot = "19")]
		private bool SPXDIBVHZBK([In] VZVEWXRZWLR other)
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
	public sealed class HYEXPGDJAOX : VJBGGKQUSTY, IEquatable<HYEXPGDJAOX>, IWKTMLXEDYU<HYEXPGDJAOX>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool VCIBOKLBHLX
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A8F0", Offset = "0x2B396F0", VA = "0x182B3A8F0", Slot = "9")]
		public sealed override VJBGGKQUSTY NCRZCUWRTCF(IReadOnlyDictionary<string, VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A8A0", Offset = "0x2B396A0", VA = "0x182B3A8A0", Slot = "11")]
		public sealed override void LCBMAGEAVYX(Action<VJBGGKQUSTY> a, Action<VJBGGKQUSTY> b, Action<VJBGGKQUSTY> c, Action<VJBGGKQUSTY> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AA50", Offset = "0x2B39850", VA = "0x182B3AA50")]
		private HYEXPGDJAOX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A9D0", Offset = "0x2B397D0", VA = "0x182B3A9D0")]
		public static HYEXPGDJAOX New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A850", Offset = "0x2B39650", VA = "0x182B3A850", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0")]
		public bool JECCPMWTKQN([In] HYEXPGDJAOX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xBBDAB0", Offset = "0xBBC8B0", VA = "0x180BBDAB0", Slot = "18")]
		public bool Equals(HYEXPGDJAOX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A800", Offset = "0x2B39600", VA = "0x182B3A800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A8D0", Offset = "0x2B396D0", VA = "0x182B3A8D0", Slot = "14")]
		protected sealed override int LQQHYKQWPBM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0", Slot = "19")]
		private bool CQTLRYBRBSW([In] HYEXPGDJAOX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class AUZZFVIHGIC : VJBGGKQUSTY
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<JBBNTWVSRYS> BQXXKBBAYDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2B37C10", Offset = "0x2B36A10", VA = "0x182B37C10")]
		public void Initialize(AUZZFVIHGIC from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2B37DA0", Offset = "0x2B36BA0", VA = "0x182B37DA0")]
		protected AUZZFVIHGIC(IEnumerable<JBBNTWVSRYS> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool JECCPMWTKQN([In] VJBGGKQUSTY other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2B37C40", Offset = "0x2B36A40", VA = "0x182B37C40")]
		protected bool JECCPMWTKQN([In] AUZZFVIHGIC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2B37CA0", Offset = "0x2B36AA0", VA = "0x182B37CA0", Slot = "14")]
		protected override int LQQHYKQWPBM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2B37D20", Offset = "0x2B36B20", VA = "0x182B37D20")]
		protected int PYTTFPASKIQ(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class JBBNTWVSRYS : VJBGGKQUSTY, IEquatable<JBBNTWVSRYS>, IWKTMLXEDYU<JBBNTWVSRYS>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public VJBGGKQUSTY SMQRHLHUOYM
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AE50", Offset = "0x2B39C50", VA = "0x182B3AE50")]
		private JBBNTWVSRYS(string a, [Optional] VJBGGKQUSTY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ACC0", Offset = "0x2B39AC0", VA = "0x182B3ACC0")]
		public static JBBNTWVSRYS New(string name, [Optional] VJBGGKQUSTY constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ADC0", Offset = "0x2B39BC0", VA = "0x182B3ADC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ABF0", Offset = "0x2B399F0", VA = "0x182B3ABF0", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ABA0", Offset = "0x2B399A0", VA = "0x182B3ABA0")]
		public bool JECCPMWTKQN([In] JBBNTWVSRYS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AA90", Offset = "0x2B39890", VA = "0x182B3AA90", Slot = "18")]
		public bool Equals(JBBNTWVSRYS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AAE0", Offset = "0x2B398E0", VA = "0x182B3AAE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AC40", Offset = "0x2B39A40", VA = "0x182B3AC40", Slot = "14")]
		protected override int LQQHYKQWPBM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2B3AB30", Offset = "0x2B39930", VA = "0x182B3AB30", Slot = "13")]
		public override int HUMYXEZEENE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2B3ABA0", Offset = "0x2B399A0", VA = "0x182B3ABA0", Slot = "19")]
		private bool OQKTHGRAIUR([In] JBBNTWVSRYS other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class XRRQQTWPVKG : VJBGGKQUSTY, IEquatable<XRRQQTWPVKG>, IWKTMLXEDYU<XRRQQTWPVKG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B43C90", Offset = "0x2B42A90", VA = "0x182B43C90")]
		private XRRQQTWPVKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B43B50", Offset = "0x2B42950", VA = "0x182B43B50")]
		public static XRRQQTWPVKG New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B43BC0", Offset = "0x2B429C0", VA = "0x182B43BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B43A60", Offset = "0x2B42860", VA = "0x182B43A60", Slot = "15")]
		public override string KOYROKBXKQT(IReadOnlyList<VJBGGKQUSTY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B43C40", Offset = "0x2B42A40", VA = "0x182B43C40", Slot = "16")]
		public override int XJVDNWTLDHW(IReadOnlyList<VJBGGKQUSTY> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B43BF0", Offset = "0x2B429F0", VA = "0x182B43BF0", Slot = "17")]
		public override bool WABMDFFXAZX(IReadOnlyList<VJBGGKQUSTY> a, IReadOnlyList<VJBGGKQUSTY> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B43A10", Offset = "0x2B42810", VA = "0x182B43A10", Slot = "12")]
		public override bool JECCPMWTKQN([In] VJBGGKQUSTY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0")]
		public bool JECCPMWTKQN([In] XRRQQTWPVKG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xBBDAB0", Offset = "0xBBC8B0", VA = "0x180BBDAB0", Slot = "18")]
		public bool Equals(XRRQQTWPVKG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B439C0", Offset = "0x2B427C0", VA = "0x182B439C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B3A7F0", Offset = "0x2B395F0", VA = "0x182B3A7F0", Slot = "19")]
		private bool PDUVERTBXTH([In] XRRQQTWPVKG other)
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
			public readonly VJBGGKQUSTY CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
			internal Impl(VJBGGKQUSTY circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2B38440", Offset = "0x2B37240", VA = "0x182B38440")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B38370", Offset = "0x2B37170", VA = "0x182B38370")]
		public static CircuitTypeOrString TSDWFLQHSAO(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B383E0", Offset = "0x2B371E0", VA = "0x182B383E0")]
		public static CircuitTypeOrString TSDWFLQHSAO(VJBGGKQUSTY a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B382D0", Offset = "0x2B370D0", VA = "0x182B382D0")]
		public VJBGGKQUSTY JKWAMEGLNPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B381A0", Offset = "0x2B36FA0", VA = "0x182B381A0")]
		public static VJBGGKQUSTY[] AAMXHQHKHLW(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly SJVISQTWCGV _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		private ClassFactoryBaseClasses(SJVISQTWCGV data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1537D40", Offset = "0x1536B40", VA = "0x181537D40")]
		public static ClassFactoryBaseClasses New(SJVISQTWCGV data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B38520", Offset = "0x2B37320", VA = "0x182B38520")]
		public ClassFactoryBaseClasses XZJGBZXMBRN(NITOSEZCQPT a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2B385E0", Offset = "0x2B373E0", VA = "0x182B385E0")]
		public ClassFactoryProps ZPHYLGTVJZK()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B38470", Offset = "0x2B37270", VA = "0x182B38470")]
		public ClassFactoryProps HFQGWEMDFIB(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B384D0", Offset = "0x2B372D0", VA = "0x182B384D0")]
		public NITOSEZCQPT PKVJCOOHHUA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class SJVISQTWCGV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? WBRSHDLSFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string CCOXOANSCWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<JBBNTWVSRYS> BQXXKBBAYDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<NITOSEZCQPT> MLMZGMMZYJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> DZDMQGNNMJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, GHEURDYOPHV>> VQXLDKFGIVS;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2B40FD0", Offset = "0x2B3FDD0", VA = "0x182B40FD0")]
		private SJVISQTWCGV([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2B40E20", Offset = "0x2B3FC20", VA = "0x182B40E20")]
		public static SJVISQTWCGV New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly SJVISQTWCGV _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		private ClassFactoryFuncs(SJVISQTWCGV data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1537D40", Offset = "0x1536B40", VA = "0x181537D40")]
		public static ClassFactoryFuncs New(SJVISQTWCGV data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B38600", Offset = "0x2B37400", VA = "0x182B38600")]
		public NITOSEZCQPT PKVJCOOHHUA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly SJVISQTWCGV _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		public ClassFactoryProps(SJVISQTWCGV data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B38750", Offset = "0x2B37550", VA = "0x182B38750")]
		public ClassFactoryProps HFQGWEMDFIB(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2B385E0", Offset = "0x2B373E0", VA = "0x182B385E0")]
		public ClassFactoryFuncs UGNFDMHPBQR()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B388E0", Offset = "0x2B376E0", VA = "0x182B388E0")]
		public NITOSEZCQPT PKVJCOOHHUA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly SJVISQTWCGV _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		private ClassFactoryTypeParams(SJVISQTWCGV data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B38920", Offset = "0x2B37720", VA = "0x182B38920")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B38B50", Offset = "0x2B37950", VA = "0x182B38B50")]
		public ClassFactoryTypeParams VOVWIUEGDAR(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2B385E0", Offset = "0x2B373E0", VA = "0x182B385E0")]
		public ClassFactoryBaseClasses WSHMWZICOEF()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B38DF0", Offset = "0x2B37BF0", VA = "0x182B38DF0")]
		public ClassFactoryBaseClasses XZJGBZXMBRN(NITOSEZCQPT a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B38AF0", Offset = "0x2B378F0", VA = "0x182B38AF0")]
		public NITOSEZCQPT PKVJCOOHHUA()
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
