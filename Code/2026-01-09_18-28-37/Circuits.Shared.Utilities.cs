using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Algorithms;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.Common.Delegates;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Performance;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x28BA280", Offset = "0x28B9680", VA = "0x1828BA280")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LULDCETIQAU
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28B9A10", Offset = "0x28B8E10", VA = "0x1828B9A10")]
		private static string DXMXCVQBSJB(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28B99A0", Offset = "0x28B8DA0", VA = "0x1828B99A0")]
		public static string CAJYIWPKIOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28B9D70", Offset = "0x28B9170", VA = "0x1828B9D70")]
		public static string MQMJWZECKGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x37935C0", Offset = "0x37929C0", VA = "0x1837935C0")]
		public static string GHPBACFAWUF<a>([In] a actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28B9E90", Offset = "0x28B9290", VA = "0x1828B9E90")]
		public static string UMKIDQKAFIU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3793ED0", Offset = "0x37932D0", VA = "0x183793ED0")]
		public static string WEURAQNWLAV<b, c>([In] b expected, [In] c actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x37949C0", Offset = "0x3793DC0", VA = "0x1837949C0")]
		public static string XHGFXWMOUVW<d, e>([In] d notExpected, [In] e actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28B9950", Offset = "0x28B8D50", VA = "0x1828B9950")]
		public static string ASNUWUOHMHK(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28B98D0", Offset = "0x28B8CD0", VA = "0x1828B98D0")]
		public static string AOJNGVJIDQY(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28B99D0", Offset = "0x28B8DD0", VA = "0x1828B99D0")]
		public static string CRIQOIJBAMB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28B9C20", Offset = "0x28B9020", VA = "0x1828B9C20")]
		public static string HNNKFMJFVRE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3795400", Offset = "0x3794800", VA = "0x183795400")]
		public static string ZKQPOQUTYQI<dg>(string a, [In] dg actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28B9E50", Offset = "0x28B9250", VA = "0x1828B9E50")]
		public static string UJJPJEXQKJH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3794EC0", Offset = "0x37942C0", VA = "0x183794EC0")]
		public static string YPKRNSWEHPC<dh, di>(string a, [In] dh expected, [In] di actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37938F0", Offset = "0x3792CF0", VA = "0x1837938F0")]
		public static string QYOWFFHDZMF<dj, dk>(string a, [In] dj notExpected, [In] dk actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28B9B80", Offset = "0x28B8F80", VA = "0x1828B9B80")]
		public static void EGRYOYRODLD(this LogDelegate a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28B9DA0", Offset = "0x28B91A0", VA = "0x1828B9DA0")]
		public static bool NQESXLJZTCP([In] this LogDelegates log, [Optional] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28BA090", Offset = "0x28B9490", VA = "0x1828BA090")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28B9FB0", Offset = "0x28B93B0", VA = "0x1828B9FB0")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Out] LogDelegate err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28B9CA0", Offset = "0x28B90A0", VA = "0x1828B9CA0")]
		public static bool KGKQRWNAKCC([In] this LogDelegates log, bool a, [Optional] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3793700", Offset = "0x3792B00", VA = "0x183793700")]
		public static bool KGKQRWNAKCC<ic>([In] this LogDelegates log, bool a, ic b, FastestMessageFunc<ic> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3793A90", Offset = "0x3792E90", VA = "0x183793A90")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T expected, U actual, [Optional] string message) where T : IEquatable<U>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28B9EC0", Offset = "0x28B92C0", VA = "0x1828B9EC0")]
		public static bool VerifyAreNotEqual([In] this LogDelegates log, object notExpected, object actual, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3793E20", Offset = "0x3793220", VA = "0x183793E20")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, [In] T actual, [Optional] string message) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28B9E20", Offset = "0x28B9220", VA = "0x1828B9E20")]
		public static PerfScopeToken QHMURJUDVKY([In] this PerfScopeDelegates self, [Optional][CallerMemberName] string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28B9C60", Offset = "0x28B9060", VA = "0x1828B9C60")]
		public static PerfScopeToken HWLSVKEZVJH([In] this PerfScopeDelegates self, Func<string> a)
		{
			return default(PerfScopeToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class VPJSIXPXLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BBC850", Offset = "0x3BBBC50", VA = "0x183BBC850")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BBC9D0", Offset = "0x3BBBDD0", VA = "0x183BBC9D0")]
		public static bool VerifyIsNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3BBC540", Offset = "0x3BBB940", VA = "0x183BBC540")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T? expected, U? actual, [Optional] string message, [Optional] string isNotNullMessage, [Optional] string isNullMessage) where T : struct, IEquatable<U> where U : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerTypeProxy(typeof(IdUnsafeList<, >.GVVHORLATCH))]
	public struct IdUnsafeList<M, T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public sealed class GVVHORLATCH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal UnsafeList<T> _unsafeList;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xFF1B60", Offset = "0xFF0F60", VA = "0x180FF1B60")]
		internal IdUnsafeList([In] UnsafeList<T> unsafeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x50365D0", Offset = "0x50359D0", VA = "0x1850365D0")]
		public static IdUnsafeList<M, T> New()
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5036420", Offset = "0x5035820", VA = "0x185036420")]
		public static IdUnsafeList<M, T> KVESTPMENZS(int a)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5036E80", Offset = "0x5036280", VA = "0x185036E80", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MFCVOIZZDLX
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public readonly struct Deserializer<TSerialized, TDeserialized>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private readonly RepeatedField<TSerialized> _serialized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private readonly Func<TSerialized, TDeserialized> _deserialize;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
			internal Deserializer(RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x355F730", Offset = "0x355EB30", VA = "0x18355F730")]
			public IdUnsafeList<a, TDeserialized> VFQRKPNOCRB<a>()
			{
				return default(IdUnsafeList<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37C4D30", Offset = "0x37C4130", VA = "0x1837C4D30")]
		public static void JGXKWGFOQON<a, b, c>([In] this IdUnsafeList<a, b> self, RepeatedField<c> a, Func<b, c> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x33B2860", Offset = "0x33B1C60", VA = "0x1833B2860")]
		public static Deserializer<i, j> TFCDMJZJEIG<i, j>(this RepeatedField<i> a, Func<i, j> b)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37C3BB0", Offset = "0x37C2FB0", VA = "0x1837C3BB0")]
		public static void Destroy<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x37C6080", Offset = "0x37C5480", VA = "0x1837C6080")]
		public static string RENGAFQEHKR<n, o>([In] this IdUnsafeList<n, o> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840")]
		public static UnsafeList<y> ZJBSEVSTTAE<y, x>([In] this IdUnsafeList<x, y> self)
		{
			return default(UnsafeList<y>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x37C3DA0", Offset = "0x37C31A0", VA = "0x1837C3DA0")]
		public static T Get<T, M>([In] this IdUnsafeList<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37C3DF0", Offset = "0x37C31F0", VA = "0x1837C3DF0")]
		public static ba QNECGDCLYAI<ba, z>(this IdUnsafeList<z, ba> a, Id32<z> b)
		{
			return (ba)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37C5BA0", Offset = "0x37C4FA0", VA = "0x1837C5BA0")]
		public static bc KXOBOFJVSKA<bc, bb>([In] this IdUnsafeList<bb, bc> self, Id32<bb> a)
		{
			return (bc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37C4750", Offset = "0x37C3B50", VA = "0x1837C4750")]
		public static void Set<M, T>(this IdUnsafeList<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37C4750", Offset = "0x37C3B50", VA = "0x1837C4750")]
		public static void ISUVJNLMLFC<bd, be>(this IdUnsafeList<bd, be> a, Id32<bd> b, be c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37C6DA0", Offset = "0x37C61A0", VA = "0x1837C6DA0")]
		public static int UOQYEEADIQF<bh, bi>([In] this IdUnsafeList<bh, bi> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37C3B50", Offset = "0x37C2F50", VA = "0x1837C3B50")]
		public static Id32<bl> DTIWDBOUSAL<bl, bm>([In] this IdUnsafeList<bl, bm> self)
		{
			return default(Id32<bl>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37C37E0", Offset = "0x37C2BE0", VA = "0x1837C37E0")]
		public static bo BTQWUJOGPCS<bo, bn>([In] this IdUnsafeList<bn, bo> self)
		{
			return (bo)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x37C4230", Offset = "0x37C3630", VA = "0x1837C4230")]
		public static ReadOnlyIdArray<bt, bu> IQWWUTAKGAU<bt, bu>(this IdUnsafeList<bt, bu> a)
		{
			return default(ReadOnlyIdArray<bt, bu>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37C3520", Offset = "0x37C2920", VA = "0x1837C3520")]
		public static Id32<M> Add<M, T>(this IdUnsafeList<M, T> self, [In] T item)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37C59B0", Offset = "0x37C4DB0", VA = "0x1837C59B0")]
		public static Id32<bv> JTMQIXRSKJX<bv, bw>(this IdUnsafeList<bv, bw> a, bw b)
		{
			return default(Id32<bv>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37C4BD0", Offset = "0x37C3FD0", VA = "0x1837C4BD0")]
		public static void Insert<M, T>(this IdUnsafeList<M, T> self, int index, [In] T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x37C3C40", Offset = "0x37C3040", VA = "0x1837C3C40")]
		public static void ETDSAUINKHN<bx, by>(this IdUnsafeList<bx, by> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37C5410", Offset = "0x37C4810", VA = "0x1837C5410")]
		public static void JPRTPHUCDTL<bz, ca>(this IdUnsafeList<bz, ca> a, Id32<bz> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37C3960", Offset = "0x37C2D60", VA = "0x1837C3960")]
		public static void Clear<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37C3A30", Offset = "0x37C2E30", VA = "0x1837C3A30")]
		public static IdUnsafeList<M, T> Clone<M, T>([In] this IdUnsafeList<M, T> self, InFunc<T, T> cloneItem)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x37C3870", Offset = "0x37C2C70", VA = "0x1837C3870")]
		public static Id32Enumerator<ch> CPVDIMQGXRH<ch, ci>([In] this IdUnsafeList<ch, ci> self)
		{
			return default(Id32Enumerator<ch>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x37C3CF0", Offset = "0x37C30F0", VA = "0x1837C3CF0")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T, M>([In] this IdUnsafeList<M, T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37C6DD0", Offset = "0x37C61D0", VA = "0x1837C6DD0")]
		public static UnsafeList<ck>.MutEnumerator VJQVVTTFLNE<ck, cj>(this IdUnsafeList<cj, ck> a)
		{
			return default(UnsafeList<ck>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37C6580", Offset = "0x37C5980", VA = "0x1837C6580")]
		public static CopyEnumerable<Id32<cl>, Id32Enumerator<cl>> SOALUHYAACZ<cl, cm>([In] this IdUnsafeList<cl, cm> self)
		{
			return default(CopyEnumerable<Id32<cl>, Id32Enumerator<cl>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x37C38C0", Offset = "0x37C2CC0", VA = "0x1837C38C0")]
		public static ConstEnumerable<co, UnsafeList<co>.Enumerator> CWPAKWWTVPK<co, cn>([In] this IdUnsafeList<cn, co> self)
		{
			return default(ConstEnumerable<co, UnsafeList<co>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x37C6E30", Offset = "0x37C6230", VA = "0x1837C6E30")]
		public static MutEnumerable<cq, UnsafeList<cq>.MutEnumerator> WLLLXKRAFIO<cq, cp>(this IdUnsafeList<cp, cq> a)
		{
			return default(MutEnumerable<cq, UnsafeList<cq>.MutEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct LinearIdAllocator32<M>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal int _next;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
		internal LinearIdAllocator32(int next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5352260", Offset = "0x5351660", VA = "0x185352260")]
		public static LinearIdAllocator32<M> New()
		{
			return default(LinearIdAllocator32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5352360", Offset = "0x5351760", VA = "0x185352360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ZTVBLSXLYIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C12D30", Offset = "0x3C12130", VA = "0x183C12D30")]
		public static void Clear<M>(this LinearIdAllocator32<M> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C12D90", Offset = "0x3C12190", VA = "0x183C12D90")]
		public static Id32<M> Next<M>(this LinearIdAllocator32<M> self)
		{
			return default(Id32<M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct LinearObjAllocator32<M, T>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct IdEnumerator : IEnumerator<Id32<M>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private readonly Dictionary<Id32<M>, Id32<M>> _gcToLinear;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private SOAId32<M>.Enumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public readonly Id32<M> Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x5035920", Offset = "0x5034D20", VA = "0x185035920", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private readonly object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x50353C0", Offset = "0x50347C0", VA = "0x1850353C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5035800", Offset = "0x5034C00", VA = "0x185035800")]
			private IdEnumerator(Dictionary<Id32<M>, Id32<M>> gcToLinear, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5035580", Offset = "0x5034980", VA = "0x185035580")]
			public static IdEnumerator New(LinearObjAllocator32<M, T> self)
			{
				return default(IdEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5035540", Offset = "0x5034940", VA = "0x185035540", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x50357C0", Offset = "0x5034BC0", VA = "0x1850357C0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal SOAId32Field<M, T> _gcObjAllocator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal Dictionary<Id32<M>, Id32<M>> _linearToGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal Dictionary<Id32<M>, Id32<M>> _gcToLinear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal LinearIdAllocator32<M> _linearIdAllocator32;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5352850", Offset = "0x5351C50", VA = "0x185352850")]
		private LinearObjAllocator32([In] SOAId32Field<M, T> gcObjAllocator, Dictionary<Id32<M>, Id32<M>> linearToGC, Dictionary<Id32<M>, Id32<M>> gcToLinear, LinearIdAllocator32<M> linearIdAllocator32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5352420", Offset = "0x5351820", VA = "0x185352420")]
		public static LinearObjAllocator32<M, T> New()
		{
			return default(LinearObjAllocator32<M, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class UPSLWOWJVYM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3B7A980", Offset = "0x3B79D80", VA = "0x183B7A980")]
		public static T Get<T, M>([In] this LinearObjAllocator32<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3B7A8B0", Offset = "0x3B79CB0", VA = "0x183B7A8B0")]
		public static void Destroy<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3B7AB50", Offset = "0x3B79F50", VA = "0x183B7AB50")]
		public static Id32<e> ILXZZJDUBET<e, f>(this LinearObjAllocator32<e, f> a, [In] f obj)
		{
			return default(Id32<e>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3B7ACD0", Offset = "0x3B7A0D0", VA = "0x183B7ACD0")]
		public static void Release<M, T>(this LinearObjAllocator32<M, T> self, Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3B7A6E0", Offset = "0x3B79AE0", VA = "0x183B7A6E0")]
		public static void Clear<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3B7A3B0", Offset = "0x3B797B0", VA = "0x183B7A3B0")]
		public static LinearObjAllocator32<n, o>.IdEnumerator CPVDIMQGXRH<n, o>([In] this LinearObjAllocator32<n, o> self)
		{
			return default(LinearObjAllocator32<n, o>.IdEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3B7AE20", Offset = "0x3B7A220", VA = "0x183B7AE20")]
		public static CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator> SOALUHYAACZ<t, u>([In] this LinearObjAllocator32<t, u> self)
		{
			return default(CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MultiResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct Enumerator : BUZMWBXGJOU<Result<object, AFOSPUXIYKE>>, DUJGQQLBCCJ<Result<object, AFOSPUXIYKE>>, IEnumerator<Result<object, AFOSPUXIYKE>>, IEnumerator, IDisposable, VFTEPWSFKPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private readonly Result<object, AFOSPUXIYKE>[] _results;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public readonly int RUUQZBEMWUZ
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x28B97C0", Offset = "0x28B8BC0", VA = "0x1828B97C0", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public readonly Result<object, AFOSPUXIYKE> Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x28B9860", Offset = "0x28B8C60", VA = "0x1828B9860", Slot = "11")]
				get
				{
					return default(Result<object, AFOSPUXIYKE>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private readonly Result<object, AFOSPUXIYKE> SXOODGJQKNS
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x28B9860", Offset = "0x28B8C60", VA = "0x1828B9860", Slot = "4")]
				get
				{
					return default(Result<object, AFOSPUXIYKE>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private readonly Result<object, AFOSPUXIYKE> RSCRDQRENMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x28B94D0", Offset = "0x28B88D0", VA = "0x1828B94D0", Slot = "5")]
				get
				{
					return default(Result<object, AFOSPUXIYKE>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private readonly object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x28B9510", Offset = "0x28B8910", VA = "0x1828B9510", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xC2A570", Offset = "0xC29970", VA = "0x180C2A570")]
			private Enumerator(Result<object, AFOSPUXIYKE>[] results, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28B97E0", Offset = "0x28B8BE0", VA = "0x1828B97E0")]
			public static Enumerator New(Result<object, AFOSPUXIYKE>[] results)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28B9790", Offset = "0x28B8B90", VA = "0x1828B9790", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28B9850", Offset = "0x28B8C50", VA = "0x1828B9850", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly Result<object, AFOSPUXIYKE>[] _results;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Result<object, AFOSPUXIYKE> this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x28BA240", Offset = "0x28B9640", VA = "0x1828BA240")]
			get
			{
				return default(Result<object, AFOSPUXIYKE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static MultiResult RMUSGMNMVYD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x28BA1A0", Offset = "0x28B95A0", VA = "0x1828BA1A0")]
			get
			{
				return default(MultiResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		internal MultiResult(Result<object, AFOSPUXIYKE>[] results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE07730", Offset = "0xE06B30", VA = "0x180E07730")]
		public static MultiResult New(Result<object, AFOSPUXIYKE>[] results)
		{
			return default(MultiResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28BA160", Offset = "0x28B9560", VA = "0x1828BA160")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DebuggerTypeProxy(typeof(SOAField<, >.GVVHORLATCH))]
	public struct SOAField<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct MutEnumerator : BUZMWBXGJOU<T>, DUJGQQLBCCJ<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly IdUnsafeList<M, T> _objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private SOAId32<M>.Enumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x58416C0", Offset = "0x5840AC0", VA = "0x1858416C0", Slot = "10")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public readonly T MVRBAIBTSVE
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x5841100", Offset = "0x5840500", VA = "0x185841100")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private readonly T BHBEOJVMRUV
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x5840C50", Offset = "0x5840050", VA = "0x185840C50", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private readonly T YCZVSCZNOBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x5840990", Offset = "0x583FD90", VA = "0x185840990", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private readonly object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x5840240", Offset = "0x583F640", VA = "0x185840240", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5841510", Offset = "0x5840910", VA = "0x185841510")]
			internal MutEnumerator([In] IdUnsafeList<M, T> objects, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5840D60", Offset = "0x5840160", VA = "0x185840D60", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5840E80", Offset = "0x5840280", VA = "0x185840E80", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct Enumerator : DUJGQQLBCCJ<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x481DEF0", Offset = "0x481D2F0", VA = "0x18481DEF0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly T YCZVSCZNOBH
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x481A210", Offset = "0x4819610", VA = "0x18481A210", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private readonly object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x481A210", Offset = "0x4819610", VA = "0x18481A210", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4056530", Offset = "0x4055930", VA = "0x184056530")]
			internal Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x481A620", Offset = "0x4819A20", VA = "0x18481A620", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x481AFA0", Offset = "0x481A3A0", VA = "0x18481AFA0", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x481A160", Offset = "0x4819560", VA = "0x18481A160", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public sealed class GVVHORLATCH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal IdUnsafeList<M, T> _objects;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xFF1B60", Offset = "0xFF0F60", VA = "0x180FF1B60")]
		internal SOAField([In] IdUnsafeList<M, T> objects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4830", Offset = "0x5DB3C30", VA = "0x185DB4830")]
		public static SOAField<M, T> New()
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4730", Offset = "0x5DB3B30", VA = "0x185DB4730")]
		public static SOAField<M, T> KVESTPMENZS(int a)
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2D90", Offset = "0x5DB2190", VA = "0x185DB2D90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3EF0", Offset = "0x5DB32F0", VA = "0x185DB3EF0")]
		public void ILXZZJDUBET(Id32<M> a, [In] T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1D10", Offset = "0x5DB1110", VA = "0x185DB1D10")]
		public void AHDCFLVYQUH(Id32<M> a, T b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4D30", Offset = "0x5DB4130", VA = "0x185DB4D30")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3230", Offset = "0x5DB2630", VA = "0x185DB3230")]
		public void EBGWYFOPHBN(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5420", Offset = "0x5DB4820", VA = "0x185DB5420", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class KEYHMSQMUYR
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3771680", Offset = "0x3770A80", VA = "0x183771680")]
		public static void JGXKWGFOQON<a, b, c>([In] this SOAField<a, b> self, [In] SOAId32<a> ids, RepeatedField<c> a, Func<b, c> b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3772D10", Offset = "0x3772110", VA = "0x183772D10")]
		public static void JGXKWGFOQON<d, e, f>([In] this SOAField<d, e> self, [In] SOAId32<d> ids, RepeatedField<f> a, InFunc<e, f> b, f c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3772660", Offset = "0x3771A60", VA = "0x183772660")]
		public static void JGXKWGFOQON<g, h>([In] this SOAField<g, h> self, [In] SOAId32<g> ids, RepeatedField<h> a, h b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3773F90", Offset = "0x3773390", VA = "0x183773F90")]
		public static void TZEJAABZVPD<i, j, k>([In] this SOAField<i, j> self, [In] SOAId32<i> ids, RepeatedField<k> a, Func<Id32<i>, k> b, k c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3770010", Offset = "0x376F410", VA = "0x183770010")]
		public static void Destroy<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x37736B0", Offset = "0x3772AB0", VA = "0x1837736B0")]
		public static string RENGAFQEHKR<l, m>([In] this SOAField<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28D4F00", Offset = "0x28D4300", VA = "0x1828D4F00")]
		public static T Get<T, M>([In] this SOAField<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2A2CB00", Offset = "0x2A2BF00", VA = "0x182A2CB00")]
		public static o QNECGDCLYAI<o, n>(this SOAField<n, o> a, Id32<n> b)
		{
			return (o)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3773220", Offset = "0x3772620", VA = "0x183773220")]
		public static q KXOBOFJVSKA<q, p>([In] this SOAField<p, q> self, Id32<p> a)
		{
			return (q)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2A6C310", Offset = "0x2A6B710", VA = "0x182A6C310")]
		public static void Set<M, T>(this SOAField<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28C9220", Offset = "0x28C8620", VA = "0x1828C9220")]
		public static void ISUVJNLMLFC<r, s>(this SOAField<r, s> a, Id32<r> b, s c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3774240", Offset = "0x3773640", VA = "0x183774240")]
		public static ReadOnlyIdSpan<v, w> UJXDDXPDOAZ<v, w>([In] this SOAField<v, w> self)
		{
			return default(ReadOnlyIdSpan<v, w>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3774550", Offset = "0x3773950", VA = "0x183774550")]
		public static int YINNLDNMCOL<x, y>([In] this SOAField<x, y> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x376FFD0", Offset = "0x376F3D0", VA = "0x18376FFD0")]
		public static void Clear<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3772FA0", Offset = "0x37723A0", VA = "0x183772FA0")]
		public static bool KOBCOVZASQC<z, ba>([In] this SOAField<z, ba> self, Id32<z> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3770160", Offset = "0x376F560", VA = "0x183770160")]
		public static SOAField<M, T>.Enumerator GetEnumerator<M, T>([In] this SOAField<M, T> self, [In] SOAId32<M> ids)
		{
			return default(SOAField<M, T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3774380", Offset = "0x3773780", VA = "0x183774380")]
		public static SOAField<bd, be>.MutEnumerator VJQVVTTFLNE<bd, be>(this SOAField<bd, be> a, [In] SOAId32<bd> ids)
		{
			return default(SOAField<bd, be>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x376FE40", Offset = "0x376F240", VA = "0x18376FE40")]
		public static ConstEnumerable<bi, SOAField<bh, bi>.Enumerator> CWPAKWWTVPK<bi, bh>([In] this SOAField<bh, bi> self, [In] SOAId32<bh> ids)
		{
			return default(ConstEnumerable<bi, SOAField<bh, bi>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3774420", Offset = "0x3773820", VA = "0x183774420")]
		public static MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator> WLLLXKRAFIO<bm, bl>(this SOAField<bl, bm> a, [In] SOAId32<bl> ids)
		{
			return default(MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DebuggerTypeProxy(typeof(SOAId32<>.GVVHORLATCH))]
	public struct SOAId32<M> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct Enumerator : IEnumerator<Id32<M>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private UnsafeList<ulong> _used;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int _current;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public readonly Id32<M> Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x47AB6F0", Offset = "0x47AAAF0", VA = "0x1847AB6F0", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private readonly object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x47A6DC0", Offset = "0x47A61C0", VA = "0x1847A6DC0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x28E0C20", Offset = "0x28E0020", VA = "0x1828E0C20")]
			private Enumerator([In] UnsafeList<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x47A8AF0", Offset = "0x47A7EF0", VA = "0x1847A8AF0")]
			public static Enumerator New([In] SOAId32<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x47A7480", Offset = "0x47A6880", VA = "0x1847A7480", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2B9ED20", Offset = "0x2B9E120", VA = "0x182B9ED20", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public sealed class GVVHORLATCH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal UnsafeList<ulong> _used;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal UnsafeList<Id32<M>> _free;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal Id32<M> _next;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5DB9470", Offset = "0x5DB8870", VA = "0x185DB9470")]
		internal SOAId32(UnsafeList<ulong> used, UnsafeList<Id32<M>> free, Id32<M> next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8890", Offset = "0x5DB7C90", VA = "0x185DB8890")]
		public static SOAId32<M> New()
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7660", Offset = "0x5DB6A60", VA = "0x185DB7660", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B60", Offset = "0x5DB6F60", VA = "0x185DB7B60")]
		public Id32<M> ILXZZJDUBET()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8AE0", Offset = "0x5DB7EE0", VA = "0x185DB8AE0")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8450", Offset = "0x5DB7850", VA = "0x185DB8450")]
		public readonly TJMYNTEGKYD MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0")]
		public readonly Id32<M> UPSGYNCIPNA()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7F50", Offset = "0x5DB7350", VA = "0x185DB7F50")]
		public readonly bool KOBCOVZASQC(Id32<M> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB80A0", Offset = "0x5DB74A0", VA = "0x185DB80A0")]
		public readonly bool KZSKNTWAFUV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB93B0", Offset = "0x5DB87B0", VA = "0x185DB93B0")]
		public readonly int UOQYEEADIQF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7510", Offset = "0x5DB6910", VA = "0x185DB7510")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB76D0", Offset = "0x5DB6AD0", VA = "0x185DB76D0")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7230", Offset = "0x5DB6630", VA = "0x185DB7230")]
		public readonly CopyEnumerable<Id32<M>, Enumerator> CWPAKWWTVPK()
		{
			return default(CopyEnumerable<Id32<M>, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8C20", Offset = "0x5DB8020", VA = "0x185DB8C20", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class AIDPVAOMOBR
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x28B8F20", Offset = "0x28B8320", VA = "0x1828B8F20")]
		public static (int, ulong) EKFKWNCQUIF(int a)
		{
			return default((int, ulong));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class LVOWZJMEAKN<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3613D20", Offset = "0x3613120", VA = "0x183613D20")]
		public static SOAId32<b> YPLFTEJBRUM<a>([In] SOAId32<a> self) where a : b
		{
			return default(SOAId32<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerTypeProxy(typeof(SOAId32Field<, >.GVVHORLATCH))]
	public struct SOAId32Field<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class GVVHORLATCH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal SOAId32<M> _soaId32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal SOAField<M, T> _soaField;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB71E0", Offset = "0x5DB65E0", VA = "0x185DB71E0")]
		internal SOAId32Field([In] SOAId32<M> soaId32, [In] SOAField<M, T> soaField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB65E0", Offset = "0x5DB59E0", VA = "0x185DB65E0")]
		public static SOAId32Field<M, T> New()
		{
			return default(SOAId32Field<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB57B0", Offset = "0x5DB4BB0", VA = "0x185DB57B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6430", Offset = "0x5DB5830", VA = "0x185DB6430")]
		public Id32<M> ILXZZJDUBET([In] T obj)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB69B0", Offset = "0x5DB5DB0", VA = "0x185DB69B0")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5D20", Offset = "0x5DB5120", VA = "0x185DB5D20")]
		public void EBGWYFOPHBN(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7160", Offset = "0x5DB6560", VA = "0x185DB7160", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class XZSROKXETYR
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public readonly struct Deserializer<TSerialized, TDeserialized>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly TJMYNTEGKYD _serializedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly RepeatedField<TSerialized> _serialized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Func<TSerialized, TDeserialized> _deserialize;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1BB53E0", Offset = "0x1BB47E0", VA = "0x181BB53E0")]
			internal Deserializer(TJMYNTEGKYD serializedIds, RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x355F4F0", Offset = "0x355E8F0", VA = "0x18355F4F0")]
			public SOAId32Field<a, TDeserialized> VFQRKPNOCRB<a>()
			{
				return default(SOAId32Field<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1A40", Offset = "0x3BF0E40", VA = "0x183BF1A40")]
		public static TJMYNTEGKYD JGXKWGFOQON<a, b, c>([In] this SOAId32Field<a, b> self, RepeatedField<c> a, Func<b, c> b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1890", Offset = "0x3BF0C90", VA = "0x183BF1890")]
		public static Deserializer<i, j> ISNGONMPKGW<i, j>(this TJMYNTEGKYD a, RepeatedField<i> b, Func<i, j> c)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1520", Offset = "0x3BF0920", VA = "0x183BF1520")]
		public static void Destroy<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3BF23D0", Offset = "0x3BF17D0", VA = "0x183BF23D0")]
		public static string RENGAFQEHKR<l, m>([In] this SOAId32Field<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1480", Offset = "0x3BF0880", VA = "0x183BF1480")]
		public static void Clear<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x378D210", Offset = "0x378C610", VA = "0x18378D210")]
		public static SOAId32<bb>.Enumerator CPVDIMQGXRH<bb, bc>([In] this SOAId32Field<bb, bc> self)
		{
			return default(SOAId32<bb>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x378CBD0", Offset = "0x378BFD0", VA = "0x18378CBD0")]
		public static CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator> SOALUHYAACZ<bd, be>([In] this SOAId32Field<bd, be> self)
		{
			return default(CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1650", Offset = "0x3BF0A50", VA = "0x183BF1650")]
		public static T Get<T, M>([In] this SOAId32Field<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3BF16E0", Offset = "0x3BF0AE0", VA = "0x183BF16E0")]
		public static bg QNECGDCLYAI<bg, bf>(this SOAId32Field<bf, bg> a, Id32<bf> b)
		{
			return (bg)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1D50", Offset = "0x3BF1150", VA = "0x183BF1D50")]
		public static bi KXOBOFJVSKA<bi, bh>([In] this SOAId32Field<bh, bi> self, Id32<bh> a)
		{
			return (bi)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1E50", Offset = "0x3BF1250", VA = "0x183BF1E50")]
		public static ConstEnumerable<bw, SOAField<bv, bw>.Enumerator> LFIXSQJTKCN<bw, bv>([In] this SOAId32Field<bv, bw> self)
		{
			return default(ConstEnumerable<bw, SOAField<bv, bw>.Enumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public readonly struct StopwatchLogScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly string _message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public readonly ReadOnlyStopwatch Stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly LogDelegates _logDelegates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly bool _cachedShouldLog;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x28BA4E0", Offset = "0x28B98E0", VA = "0x1828BA4E0")]
		private StopwatchLogScope(string message, [In] ReadOnlyStopwatch stopwatch, [In] LogDelegates logDelegates, bool cachedShouldLog)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28BA430", Offset = "0x28B9830", VA = "0x1828BA430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28BA300", Offset = "0x28B9700", VA = "0x1828BA300")]
		public static StopwatchLogScope BGPNQNQKDTB(string a, [In] LogDelegates logDelegates, bool b)
		{
			return default(StopwatchLogScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class YGBNQSNVJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28BAFF0", Offset = "0x28BA3F0", VA = "0x1828BAFF0")]
		public static void UTXWHJAULDL(this Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28BAB30", Offset = "0x28B9F30", VA = "0x1828BAB30")]
		public static bool KNSUXVTNHZY(this Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28BA860", Offset = "0x28B9C60", VA = "0x1828BA860")]
		public static void INZSJWPZQDH(this Stream a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28BA840", Offset = "0x28B9C40", VA = "0x1828BA840")]
		public static float GSWMCJSRDAU(this Stream a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28BAAA0", Offset = "0x28B9EA0", VA = "0x1828BAAA0")]
		public static void KGKKSPBDMHY(this Stream a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28BA650", Offset = "0x28B9A50", VA = "0x1828BA650")]
		public static int CLYGWHQHDBF(this Stream a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28BA560", Offset = "0x28B9960", VA = "0x1828BA560")]
		public static void ALRNVMTUTLB(this Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28BAB60", Offset = "0x28B9F60", VA = "0x1828BAB60")]
		public static long LAGEWNFIQKA(this Stream a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28BA920", Offset = "0x28B9D20", VA = "0x1828BA920")]
		public static void JTAODDQKAJW(this Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28BAEF0", Offset = "0x28BA2F0", VA = "0x1828BAEF0")]
		public static string TEHZBYUZCOX(this Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28BA8F0", Offset = "0x28B9CF0", VA = "0x1828BA8F0")]
		public static void JABNGWIXAWT(this Stream a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28BB030", Offset = "0x28BA430", VA = "0x1828BB030")]
		public static void ZUZONNKOGSC(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28BA760", Offset = "0x28B9B60", VA = "0x1828BA760")]
		public static void DWYHEEILZOC(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28BAFC0", Offset = "0x28BA3C0", VA = "0x1828BAFC0")]
		public static byte TTEHYOJIZDG(this Stream a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28BA670", Offset = "0x28B9A70", VA = "0x1828BA670")]
		public static (byte, byte, byte, byte) DGFFDLGEBVD(this Stream self)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28BAD30", Offset = "0x28BA130", VA = "0x1828BAD30")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) MTAWFHUHTAJ(this Stream self)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class LRVZNSGDYYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3792020", Offset = "0x3791420", VA = "0x183792020")]
		public static void JGXKWGFOQON<a, b>([In] this UnsafeList<a> self, RepeatedField<b> a, Func<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3792800", Offset = "0x3791C00", VA = "0x183792800")]
		public static void JGXKWGFOQON<e>([In] this UnsafeList<e> self, RepeatedField<e> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3793020", Offset = "0x3792420", VA = "0x183793020")]
		public static UnsafeList<i> MJSOKMYCXMP<i, h>(this RepeatedField<h> a, Func<h, i> b)
		{
			return default(UnsafeList<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3793240", Offset = "0x3792640", VA = "0x183793240")]
		public static UnsafeList<k> MJSOKMYCXMP<k>(this RepeatedField<k> a)
		{
			return default(UnsafeList<k>);
		}
	}
}
namespace Circuits.Shared.Utilities.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class WBPYDWNZLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x35C1AF0", Offset = "0x35C0EF0", VA = "0x1835C1AF0")]
		public static SOAFieldData<T> VHWAZDRKKIN<T>(this RepeatedField<T> a) where T : notnull
		{
			return default(SOAFieldData<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x35C1AF0", Offset = "0x35C0EF0", VA = "0x1835C1AF0")]
		public static RepeatedId32Field<M> PUOFHVXVUNK<M>(this RepeatedField<int> a) where M : notnull
		{
			return default(RepeatedId32Field<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3BDBE00", Offset = "0x3BDB200", VA = "0x183BDBE00")]
		internal static void JPRTPHUCDTL<a>(this RepeatedField<a> a, int b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3BDBD90", Offset = "0x3BDB190", VA = "0x183BDBD90")]
		internal static void JPRTPHUCDTL<b>(this RepeatedField<b> self, int a, b b) where b : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct RepeatedId32Field<M> : IEnumerable<Id32<M>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct Enumerator : IEnumerator<Id32<M>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly RepeatedField<int> _impl;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public readonly Id32<M> Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x47AB020", Offset = "0x47AA420", VA = "0x1847AB020", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x47A6BF0", Offset = "0x47A5FF0", VA = "0x1847A6BF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x47AA8E0", Offset = "0x47A9CE0", VA = "0x1847AA8E0")]
			private Enumerator(RepeatedField<int> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x4063EE0", Offset = "0x40632E0", VA = "0x184063EE0")]
			public static Enumerator New(RepeatedField<int> impl)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x47A7F00", Offset = "0x47A7300", VA = "0x1847A7F00", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x28B9850", Offset = "0x28B8C50", VA = "0x1828B9850", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RepeatedField<int> _impl;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		internal RepeatedId32Field(RepeatedField<int> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E9E0", Offset = "0x5D5DDE0", VA = "0x185D5E9E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E8B0", Offset = "0x5D5DCB0", VA = "0x185D5E8B0", Slot = "4")]
		private IEnumerator<Id32<M>> EEULKPYCWTE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D5E8B0", Offset = "0x5D5DCB0", VA = "0x185D5E8B0", Slot = "5")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct SOAFieldData<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal readonly RepeatedField<T> _Impl;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		internal SOAFieldData(RepeatedField<T> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x364F020", Offset = "0x364E420", VA = "0x18364F020")]
		public SOAField<a?, b?> EXEWSDYIDQV<a, b>([In] SOAId32<a> ids, Func<T, b> deserialize)
		{
			return default(SOAField<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3651C60", Offset = "0x3651060", VA = "0x183651C60")]
		public SOAField<c?, d?> LWGOHGXFIUB<c, d>([In] SOAId32<c> ids, Func<T, d> deserialize)
		{
			return default(SOAField<c, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x36514A0", Offset = "0x36508A0", VA = "0x1836514A0")]
		public SOAField<e?, T?> EXEWSDYIDQV<e>([In] SOAId32<e> ids)
		{
			return default(SOAField<e, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3652300", Offset = "0x3651700", VA = "0x183652300")]
		public SOAField<f?, g?> PPSJWWDBDYJ<f, g>([In] SOAId32<f> ids, Func<Id32<f>, g> deserialize)
		{
			return default(SOAField<f, g>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class HKAUNPYGSMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x36D1190", Offset = "0x36D0590", VA = "0x1836D1190")]
		public static void ILXZZJDUBET<a>(this SOAFieldData<a> self, int a, a b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x36D1100", Offset = "0x36D0500", VA = "0x1836D1100")]
		public static void ILXZZJDUBET<b>(this SOAFieldData<b> a, int b, b c, b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x36D1220", Offset = "0x36D0620", VA = "0x1836D1220")]
		public static void Release<T>(this SOAFieldData<T> self, int id, Func<T> defaultValueGenerator) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public readonly struct SOAId32Data<M> : IEnumerable<Id32<M>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct Enumerator : IEnumerator<Id32<M>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private EMUCUKOFEFM.Enumerator _impl;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public readonly Id32<M> Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x47AB870", Offset = "0x47AAC70", VA = "0x1847AB870", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private readonly object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x47A6D30", Offset = "0x47A6130", VA = "0x1847A6D30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xFF1B60", Offset = "0xFF0F60", VA = "0x180FF1B60")]
			private Enumerator([In] EMUCUKOFEFM.Enumerator impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x47A8B50", Offset = "0x47A7F50", VA = "0x1847A8B50")]
			public static Enumerator New([In] SOAId32Data<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x47A8800", Offset = "0x47A7C00", VA = "0x1847A8800", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x47A8BB0", Offset = "0x47A7FB0", VA = "0x1847A8BB0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly TJMYNTEGKYD _impl;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		internal SOAId32Data(TJMYNTEGKYD impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5760", Offset = "0x5DB4B60", VA = "0x185DB5760")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB56C0", Offset = "0x5DB4AC0", VA = "0x185DB56C0", Slot = "4")]
		private IEnumerator<Id32<M>> EEULKPYCWTE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB56C0", Offset = "0x5DB4AC0", VA = "0x185DB56C0", Slot = "5")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class EMUCUKOFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public struct Enumerator : IEnumerator<int>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private RepeatedField<ulong> _used;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int _current;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public readonly int Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0xC9E840", Offset = "0xC9DC40", VA = "0x180C9E840", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x28B9580", Offset = "0x28B8980", VA = "0x1828B9580", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x28B98A0", Offset = "0x28B8CA0", VA = "0x1828B98A0")]
			private Enumerator([In] RepeatedField<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x28B9810", Offset = "0x28B8C10", VA = "0x1828B9810")]
			public static Enumerator New([In] TJMYNTEGKYD self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x28B95B0", Offset = "0x28B89B0", VA = "0x1828B95B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x28B9850", Offset = "0x28B8C50", VA = "0x1828B9850", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x35C17E0", Offset = "0x35C0BE0", VA = "0x1835C17E0")]
		public static SOAId32<M> EXEWSDYIDQV<M>(this TJMYNTEGKYD a) where M : notnull
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28B9280", Offset = "0x28B8680", VA = "0x1828B9280")]
		public static bool KOBCOVZASQC(this TJMYNTEGKYD a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28B90C0", Offset = "0x28B84C0", VA = "0x1828B90C0")]
		public static int ILXZZJDUBET(this TJMYNTEGKYD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28B9390", Offset = "0x28B8790", VA = "0x1828B9390")]
		public static void Release(this TJMYNTEGKYD self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x35C1AF0", Offset = "0x35C0EF0", VA = "0x1835C1AF0")]
		public static SOAId32Data<M> PUOFHVXVUNK<M>(this TJMYNTEGKYD a) where M : notnull
		{
			return default(SOAId32Data<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28B9070", Offset = "0x28B8470", VA = "0x1828B9070")]
		public static Enumerator GetEnumerator(this TJMYNTEGKYD self)
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28B8FD0", Offset = "0x28B83D0", VA = "0x1828B8FD0")]
		public static CopyEnumerable<int, Enumerator> CWPAKWWTVPK(this TJMYNTEGKYD self)
		{
			return default(CopyEnumerable<int, Enumerator>);
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
