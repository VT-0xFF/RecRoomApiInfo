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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B4B30", Offset = "0x28B3330", VA = "0x1828B4B30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class BFDEDUVIWER
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28B3B20", Offset = "0x28B2320", VA = "0x1828B3B20")]
		private static string MHUELBGPYVS(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28B3E00", Offset = "0x28B2600", VA = "0x1828B3E00")]
		public static string VHVOFPYJFSZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28B3D10", Offset = "0x28B2510", VA = "0x1828B3D10")]
		public static string QNKZFNIOAIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x33A07F0", Offset = "0x339EFF0", VA = "0x1833A07F0")]
		public static string NVJDEORAWYY<a>([In] a actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28B3AF0", Offset = "0x28B22F0", VA = "0x1828B3AF0")]
		public static string MAKVKWVKJZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x339FD80", Offset = "0x339E580", VA = "0x18339FD80")]
		public static string JGYGBSKUZDW<b, c>([In] b expected, [In] c actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x339FC10", Offset = "0x339E410", VA = "0x18339FC10")]
		public static string IKLXLVDRVUX<d, e>([In] d notExpected, [In] e actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28B3DB0", Offset = "0x28B25B0", VA = "0x1828B3DB0")]
		public static string UHGKVIIGYMT(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28B3900", Offset = "0x28B2100", VA = "0x1828B3900")]
		public static string FQCGRVOTTGV(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28B3C90", Offset = "0x28B2490", VA = "0x1828B3C90")]
		public static string OPPMBVXOANK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28B3D40", Offset = "0x28B2540", VA = "0x1828B3D40")]
		public static string RBWWLOLLWXX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x33A1420", Offset = "0x339FC20", VA = "0x1833A1420")]
		public static string WESUINAHHGB<dg>(string a, [In] dg actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28B3CD0", Offset = "0x28B24D0", VA = "0x1828B3CD0")]
		public static string PEBYSBIOQQO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x33A0A90", Offset = "0x339F290", VA = "0x1833A0A90")]
		public static string TPXNORMSVCB<dh, di>(string a, [In] dh expected, [In] di actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x33A08F0", Offset = "0x339F0F0", VA = "0x1833A08F0")]
		public static string TFJADDZLQVA<dj, dk>(string a, [In] dj notExpected, [In] dk actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28B3980", Offset = "0x28B2180", VA = "0x1828B3980")]
		public static void FTBBQERHPFI(this LogDelegate a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2080", VA = "0x1828B3880")]
		public static bool AZEBFQFIOKS([In] this LogDelegates log, [Optional] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28B3F20", Offset = "0x28B2720", VA = "0x1828B3F20")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28B3FF0", Offset = "0x28B27F0", VA = "0x1828B3FF0")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Out] LogDelegate err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28B3A20", Offset = "0x28B2220", VA = "0x1828B3A20")]
		public static bool LKVIDLAMEUB([In] this LogDelegates log, bool a, [Optional] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x33A05D0", Offset = "0x339EDD0", VA = "0x1833A05D0")]
		public static bool LKVIDLAMEUB<ic>([In] this LogDelegates log, bool a, ic b, FastestMessageFunc<ic> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x33A0F70", Offset = "0x339F770", VA = "0x1833A0F70")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T expected, U actual, [Optional] string message) where T : IEquatable<U>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28B3E30", Offset = "0x28B2630", VA = "0x1828B3E30")]
		public static bool VerifyAreNotEqual([In] this LogDelegates log, object notExpected, object actual, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x33A1310", Offset = "0x339FB10", VA = "0x1833A1310")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, [In] T actual, [Optional] string message) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28B3D80", Offset = "0x28B2580", VA = "0x1828B3D80")]
		public static PerfScopeToken TDUFEVBBPGB([In] this PerfScopeDelegates self, [Optional][CallerMemberName] string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28B40D0", Offset = "0x28B28D0", VA = "0x1828B40D0")]
		public static PerfScopeToken YHJRZWUGAPS([In] this PerfScopeDelegates self, Func<string> a)
		{
			return default(PerfScopeToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class OTRSFSRGFSJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x38B0A00", Offset = "0x38AF200", VA = "0x1838B0A00")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x38B0B80", Offset = "0x38AF380", VA = "0x1838B0B80")]
		public static bool VerifyIsNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38B06F0", Offset = "0x38AEEF0", VA = "0x1838B06F0")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T? expected, U? actual, [Optional] string message, [Optional] string isNotNullMessage, [Optional] string isNullMessage) where T : struct, IEquatable<U> where U : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerTypeProxy(typeof(IdUnsafeList<, >.EOINQAQTMSQ))]
	public struct IdUnsafeList<M, T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public sealed class EOINQAQTMSQ
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal UnsafeList<T> _unsafeList;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xFED370", Offset = "0xFEBB70", VA = "0x180FED370")]
		internal IdUnsafeList([In] UnsafeList<T> unsafeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x500C0A0", Offset = "0x500A8A0", VA = "0x18500C0A0")]
		public static IdUnsafeList<M, T> New()
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x500C1B0", Offset = "0x500A9B0", VA = "0x18500C1B0")]
		public static IdUnsafeList<M, T> TALVXPZATHN(int a)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x500CA10", Offset = "0x500B210", VA = "0x18500CA10", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ZCUOAVOLFCI
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
			[Cpp2IlInjected.Address(RVA = "0xE12FC0", Offset = "0xE117C0", VA = "0x180E12FC0")]
			internal Deserializer(RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3615490", Offset = "0x3613C90", VA = "0x183615490")]
			public IdUnsafeList<a, TDeserialized> GKVTZPEUDHU<a>()
			{
				return default(IdUnsafeList<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB3D0", Offset = "0x3BF9BD0", VA = "0x183BFB3D0")]
		public static void LGUGPDCUSLC<a, b, c>([In] this IdUnsafeList<a, b> self, RepeatedField<c> a, Func<b, c> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x394C050", Offset = "0x394A850", VA = "0x18394C050")]
		public static Deserializer<i, j> MHTYNEBIZHL<i, j>(this RepeatedField<i> a, Func<i, j> b)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA310", Offset = "0x3BF8B10", VA = "0x183BFA310")]
		public static void Destroy<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBAF0", Offset = "0x3BFA2F0", VA = "0x183BFBAF0")]
		public static string NRIFDNFTQDQ<n, o>([In] this IdUnsafeList<n, o> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0")]
		public static UnsafeList<y> VTJQBAXZZUD<y, x>([In] this IdUnsafeList<x, y> self)
		{
			return default(UnsafeList<y>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA350", Offset = "0x3BF8B50", VA = "0x183BFA350")]
		public static T Get<T, M>([In] this IdUnsafeList<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA4A0", Offset = "0x3BF8CA0", VA = "0x183BFA4A0")]
		public static ba EEIMAHKHUGN<ba, z>(this IdUnsafeList<z, ba> a, Id32<z> b)
		{
			return (ba)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9D40", Offset = "0x3BF8540", VA = "0x183BF9D40")]
		public static bc BCWSWZHXEWR<bc, bb>([In] this IdUnsafeList<bb, bc> self, Id32<bb> a)
		{
			return (bc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC3D0", Offset = "0x3BFABD0", VA = "0x183BFC3D0")]
		public static void Set<M, T>(this IdUnsafeList<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC3D0", Offset = "0x3BFABD0", VA = "0x183BFC3D0")]
		public static void SWMAQODUKIJ<bd, be>(this IdUnsafeList<bd, be> a, Id32<bd> b, be c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD120", Offset = "0x3BFB920", VA = "0x183BFD120")]
		public static int XPRPVYFZYNS<bh, bi>([In] this IdUnsafeList<bh, bi> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9FB0", Offset = "0x3BF87B0", VA = "0x183BF9FB0")]
		public static Id32<bl> BXKXZDWPRDW<bl, bm>([In] this IdUnsafeList<bl, bm> self)
		{
			return default(Id32<bl>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAE30", Offset = "0x3BF9630", VA = "0x183BFAE30")]
		public static bo ITNTHDXMDNT<bo, bn>([In] this IdUnsafeList<bn, bo> self)
		{
			return (bo)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB330", Offset = "0x3BF9B30", VA = "0x183BFB330")]
		public static ReadOnlyIdArray<bt, bu> JRFHIAJNCJN<bt, bu>(this IdUnsafeList<bt, bu> a)
		{
			return default(ReadOnlyIdArray<bt, bu>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9900", Offset = "0x3BF8100", VA = "0x183BF9900")]
		public static Id32<M> Add<M, T>(this IdUnsafeList<M, T> self, [In] T item)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB190", Offset = "0x3BF9990", VA = "0x183BFB190")]
		public static Id32<bv> JEGDGLOKLIQ<bv, bw>(this IdUnsafeList<bv, bw> a, bw b)
		{
			return default(Id32<bv>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAED0", Offset = "0x3BF96D0", VA = "0x183BFAED0")]
		public static void Insert<M, T>(this IdUnsafeList<M, T> self, int index, [In] T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCF20", Offset = "0x3BFB720", VA = "0x183BFCF20")]
		public static void UPUKBJCXFBE<bx, by>(this IdUnsafeList<bx, by> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAA60", Offset = "0x3BF9260", VA = "0x183BFAA60")]
		public static void GNAPKEHNOYY<bz, ca>(this IdUnsafeList<bz, ca> a, Id32<bz> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA010", Offset = "0x3BF8810", VA = "0x183BFA010")]
		public static void Clear<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA0E0", Offset = "0x3BF88E0", VA = "0x183BFA0E0")]
		public static IdUnsafeList<M, T> Clone<M, T>([In] this IdUnsafeList<M, T> self, InFunc<T, T> cloneItem)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA200", Offset = "0x3BF8A00", VA = "0x183BFA200")]
		public static Id32Enumerator<ch> DLJDINLECZQ<ch, ci>([In] this IdUnsafeList<ch, ci> self)
		{
			return default(Id32Enumerator<ch>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3BFACE0", Offset = "0x3BF94E0", VA = "0x183BFACE0")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T, M>([In] this IdUnsafeList<M, T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA2B0", Offset = "0x3BF8AB0", VA = "0x183BFA2B0")]
		public static UnsafeList<ck>.MutEnumerator DOXBUVVBBTZ<ck, cj>(this IdUnsafeList<cj, ck> a)
		{
			return default(UnsafeList<ck>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCFF0", Offset = "0x3BFB7F0", VA = "0x183BFCFF0")]
		public static CopyEnumerable<Id32<cl>, Id32Enumerator<cl>> VMCTMPCFAUK<cl, cm>([In] this IdUnsafeList<cl, cm> self)
		{
			return default(CopyEnumerable<Id32<cl>, Id32Enumerator<cl>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3BFAD90", Offset = "0x3BF9590", VA = "0x183BFAD90")]
		public static ConstEnumerable<co, UnsafeList<co>.Enumerator> HIJSWMHAYVJ<co, cn>([In] this IdUnsafeList<cn, co> self)
		{
			return default(ConstEnumerable<co, UnsafeList<co>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD080", Offset = "0x3BFB880", VA = "0x183BFD080")]
		public static MutEnumerable<cq, UnsafeList<cq>.MutEnumerator> XJVGZUNRBBB<cq, cp>(this IdUnsafeList<cp, cq> a)
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
		[Cpp2IlInjected.Address(RVA = "0x12EB0F0", Offset = "0x12E98F0", VA = "0x1812EB0F0")]
		internal LinearIdAllocator32(int next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x53357D0", Offset = "0x5333FD0", VA = "0x1853357D0")]
		public static LinearIdAllocator32<M> New()
		{
			return default(LinearIdAllocator32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x53358D0", Offset = "0x53340D0", VA = "0x1853358D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class KTLJYZHFPVX
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3743FD0", Offset = "0x37427D0", VA = "0x183743FD0")]
		public static void Clear<M>(this LinearIdAllocator32<M> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3744030", Offset = "0x3742830", VA = "0x183744030")]
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
				[Cpp2IlInjected.Address(RVA = "0x500B5A0", Offset = "0x5009DA0", VA = "0x18500B5A0", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private readonly object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x500B190", Offset = "0x5009990", VA = "0x18500B190", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x500B480", Offset = "0x5009C80", VA = "0x18500B480")]
			private IdEnumerator(Dictionary<Id32<M>, Id32<M>> gcToLinear, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x500B200", Offset = "0x5009A00", VA = "0x18500B200")]
			public static IdEnumerator New(LinearObjAllocator32<M, T> self)
			{
				return default(IdEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x500B0B0", Offset = "0x50098B0", VA = "0x18500B0B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x500B440", Offset = "0x5009C40", VA = "0x18500B440", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5335DC0", Offset = "0x53345C0", VA = "0x185335DC0")]
		private LinearObjAllocator32([In] SOAId32Field<M, T> gcObjAllocator, Dictionary<Id32<M>, Id32<M>> linearToGC, Dictionary<Id32<M>, Id32<M>> gcToLinear, LinearIdAllocator32<M> linearIdAllocator32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5335990", Offset = "0x5334190", VA = "0x185335990")]
		public static LinearObjAllocator32<M, T> New()
		{
			return default(LinearObjAllocator32<M, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class IENTRIJETIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x36C51A0", Offset = "0x36C39A0", VA = "0x1836C51A0")]
		public static T Get<T, M>([In] this LinearObjAllocator32<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x36C50D0", Offset = "0x36C38D0", VA = "0x1836C50D0")]
		public static void Destroy<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x36C5370", Offset = "0x36C3B70", VA = "0x1836C5370")]
		public static Id32<e> KRLRSDMBTIW<e, f>(this LinearObjAllocator32<e, f> a, [In] f obj)
		{
			return default(Id32<e>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x36C54F0", Offset = "0x36C3CF0", VA = "0x1836C54F0")]
		public static void Release<M, T>(this LinearObjAllocator32<M, T> self, Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x36C4D80", Offset = "0x36C3580", VA = "0x1836C4D80")]
		public static void Clear<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x36C4FF0", Offset = "0x36C37F0", VA = "0x1836C4FF0")]
		public static LinearObjAllocator32<n, o>.IdEnumerator DLJDINLECZQ<n, o>([In] this LinearObjAllocator32<n, o> self)
		{
			return default(LinearObjAllocator32<n, o>.IdEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x36C5640", Offset = "0x36C3E40", VA = "0x1836C5640")]
		public static CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator> VMCTMPCFAUK<t, u>([In] this LinearObjAllocator32<t, u> self)
		{
			return default(CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MultiResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct Enumerator : NOTPLCJJTON<Result<object, PWKRFVXRRZL>>, RUZXJFDKMDW<Result<object, PWKRFVXRRZL>>, IEnumerator<Result<object, PWKRFVXRRZL>>, IEnumerator, IDisposable, RVDGWJCKYKZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private readonly Result<object, PWKRFVXRRZL>[] _results;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public readonly int QYQDPJWWJPY
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x28B4480", Offset = "0x28B2C80", VA = "0x1828B4480", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public readonly Result<object, PWKRFVXRRZL> Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x28B4440", Offset = "0x28B2C40", VA = "0x1828B4440", Slot = "11")]
				get
				{
					return default(Result<object, PWKRFVXRRZL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private readonly Result<object, PWKRFVXRRZL> CLGDGAFQAPT
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x28B4440", Offset = "0x28B2C40", VA = "0x1828B4440", Slot = "4")]
				get
				{
					return default(Result<object, PWKRFVXRRZL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private readonly Result<object, PWKRFVXRRZL> OKJNNFZCJCZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x28B44A0", Offset = "0x28B2CA0", VA = "0x1828B44A0", Slot = "5")]
				get
				{
					return default(Result<object, PWKRFVXRRZL>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private readonly object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x28B4350", Offset = "0x28B2B50", VA = "0x1828B4350", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xC29C20", Offset = "0xC28420", VA = "0x180C29C20")]
			private Enumerator(Result<object, PWKRFVXRRZL>[] results, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28B4400", Offset = "0x28B2C00", VA = "0x1828B4400")]
			public static Enumerator New(Result<object, PWKRFVXRRZL>[] results)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x28B42F0", Offset = "0x28B2AF0", VA = "0x1828B42F0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x28B4430", Offset = "0x28B2C30", VA = "0x1828B4430", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly Result<object, PWKRFVXRRZL>[] _results;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Result<object, PWKRFVXRRZL> this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x28B4AF0", Offset = "0x28B32F0", VA = "0x1828B4AF0")]
			get
			{
				return default(Result<object, PWKRFVXRRZL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static MultiResult ZVPUUHTUYEI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x28B4A50", Offset = "0x28B3250", VA = "0x1828B4A50")]
			get
			{
				return default(MultiResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
		internal MultiResult(Result<object, PWKRFVXRRZL>[] results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xDFA4B0", Offset = "0xDF8CB0", VA = "0x180DFA4B0")]
		public static MultiResult New(Result<object, PWKRFVXRRZL>[] results)
		{
			return default(MultiResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28B4A10", Offset = "0x28B3210", VA = "0x1828B4A10")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DebuggerTypeProxy(typeof(SOAField<, >.EOINQAQTMSQ))]
	public struct SOAField<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct MutEnumerator : NOTPLCJJTON<T>, RUZXJFDKMDW<T>, IEnumerator<T>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5848C60", Offset = "0x5847460", VA = "0x185848C60", Slot = "10")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public readonly T FJJXYTBYFJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x5847F60", Offset = "0x5846760", VA = "0x185847F60")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private readonly T ZTPWMUCUAGK
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x58474E0", Offset = "0x5845CE0", VA = "0x1858474E0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private readonly T BQJDXWPHEGK
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x58485D0", Offset = "0x5846DD0", VA = "0x1858485D0", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private readonly object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x5847980", Offset = "0x5846180", VA = "0x185847980", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5848A20", Offset = "0x5847220", VA = "0x185848A20")]
			internal MutEnumerator([In] IdUnsafeList<M, T> objects, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x58475B0", Offset = "0x5845DB0", VA = "0x1858475B0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5848410", Offset = "0x5846C10", VA = "0x185848410", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct Enumerator : RUZXJFDKMDW<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x4753380", Offset = "0x4751B80", VA = "0x184753380", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly T BQJDXWPHEGK
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x4750210", Offset = "0x474EA10", VA = "0x184750210", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private readonly object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x4750210", Offset = "0x474EA10", VA = "0x184750210", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4023340", Offset = "0x4021B40", VA = "0x184023340")]
			internal Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x474F9C0", Offset = "0x474E1C0", VA = "0x18474F9C0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4750340", Offset = "0x474EB40", VA = "0x184750340", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x474F5C0", Offset = "0x474DDC0", VA = "0x18474F5C0", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public sealed class EOINQAQTMSQ
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal IdUnsafeList<M, T> _objects;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xFED370", Offset = "0xFEBB70", VA = "0x180FED370")]
		internal SOAField([In] IdUnsafeList<M, T> objects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E245C0", Offset = "0x5E22DC0", VA = "0x185E245C0")]
		public static SOAField<M, T> New()
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E24980", Offset = "0x5E23180", VA = "0x185E24980")]
		public static SOAField<M, T> TALVXPZATHN(int a)
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E23A00", Offset = "0x5E22200", VA = "0x185E23A00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5E23FC0", Offset = "0x5E227C0", VA = "0x185E23FC0")]
		public void KRLRSDMBTIW(Id32<M> a, [In] T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E233E0", Offset = "0x5E21BE0", VA = "0x185E233E0")]
		public void CTDPUEXOBZK(Id32<M> a, T b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E248A0", Offset = "0x5E230A0", VA = "0x185E248A0")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E23BD0", Offset = "0x5E223D0", VA = "0x185E23BD0")]
		public void JVNLJYOIGPY(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E24B80", Offset = "0x5E23380", VA = "0x185E24B80", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class ZCULFXEIFWY
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3BF69B0", Offset = "0x3BF51B0", VA = "0x183BF69B0")]
		public static void LGUGPDCUSLC<a, b, c>([In] this SOAField<a, b> self, [In] SOAId32<a> ids, RepeatedField<c> a, Func<b, c> b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8040", Offset = "0x3BF6840", VA = "0x183BF8040")]
		public static void LGUGPDCUSLC<d, e, f>([In] this SOAField<d, e> self, [In] SOAId32<d> ids, RepeatedField<f> a, InFunc<e, f> b, f c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7990", Offset = "0x3BF6190", VA = "0x183BF7990")]
		public static void LGUGPDCUSLC<g, h>([In] this SOAField<g, h> self, [In] SOAId32<g> ids, RepeatedField<h> a, h b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8BE0", Offset = "0x3BF73E0", VA = "0x183BF8BE0")]
		public static void QFILUZGIFBS<i, j, k>([In] this SOAField<i, j> self, [In] SOAId32<i> ids, RepeatedField<k> a, Func<Id32<i>, k> b, k c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5430", Offset = "0x3BF3C30", VA = "0x183BF5430")]
		public static void Destroy<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8480", Offset = "0x3BF6C80", VA = "0x183BF8480")]
		public static string NRIFDNFTQDQ<l, m>([In] this SOAField<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28CF920", Offset = "0x28CE120", VA = "0x1828CF920")]
		public static T Get<T, M>([In] this SOAField<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2A27400", Offset = "0x2A25C00", VA = "0x182A27400")]
		public static o EEIMAHKHUGN<o, n>(this SOAField<n, o> a, Id32<n> b)
		{
			return (o)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5050", Offset = "0x3BF3850", VA = "0x183BF5050")]
		public static q BCWSWZHXEWR<q, p>([In] this SOAField<p, q> self, Id32<p> a)
		{
			return (q)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2A66C00", Offset = "0x2A65400", VA = "0x182A66C00")]
		public static void Set<M, T>(this SOAField<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28C3BC0", Offset = "0x28C23C0", VA = "0x1828C3BC0")]
		public static void SWMAQODUKIJ<r, s>(this SOAField<r, s> a, Id32<r> b, s c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9500", Offset = "0x3BF7D00", VA = "0x183BF9500")]
		public static ReadOnlyIdSpan<v, w> XQEGEIVWPJS<v, w>([In] this SOAField<v, w> self)
		{
			return default(ReadOnlyIdSpan<v, w>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9580", Offset = "0x3BF7D80", VA = "0x183BF9580")]
		public static int ZZGJUGISHXW<x, y>([In] this SOAField<x, y> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF52A0", Offset = "0x3BF3AA0", VA = "0x183BF52A0")]
		public static void Clear<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9290", Offset = "0x3BF7A90", VA = "0x183BF9290")]
		public static bool UNALUPZDZIL<z, ba>([In] this SOAField<z, ba> self, Id32<z> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF58C0", Offset = "0x3BF40C0", VA = "0x183BF58C0")]
		public static SOAField<M, T>.Enumerator GetEnumerator<M, T>([In] this SOAField<M, T> self, [In] SOAId32<M> ids)
		{
			return default(SOAField<M, T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5390", Offset = "0x3BF3B90", VA = "0x183BF5390")]
		public static SOAField<bd, be>.MutEnumerator DOXBUVVBBTZ<bd, be>(this SOAField<bd, be> a, [In] SOAId32<bd> ids)
		{
			return default(SOAField<bd, be>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5B30", Offset = "0x3BF4330", VA = "0x183BF5B30")]
		public static ConstEnumerable<bi, SOAField<bh, bi>.Enumerator> HIJSWMHAYVJ<bi, bh>([In] this SOAField<bh, bi> self, [In] SOAId32<bh> ids)
		{
			return default(ConstEnumerable<bi, SOAField<bh, bi>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3BF93A0", Offset = "0x3BF7BA0", VA = "0x183BF93A0")]
		public static MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator> XJVGZUNRBBB<bm, bl>(this SOAField<bl, bm> a, [In] SOAId32<bl> ids)
		{
			return default(MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DebuggerTypeProxy(typeof(SOAId32<>.EOINQAQTMSQ))]
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
				[Cpp2IlInjected.Address(RVA = "0x46E0140", Offset = "0x46DE940", VA = "0x1846E0140", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private readonly object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x46DDAC0", Offset = "0x46DC2C0", VA = "0x1846DDAC0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x28D9F90", Offset = "0x28D8790", VA = "0x1828D9F90")]
			private Enumerator([In] UnsafeList<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x46DDBE0", Offset = "0x46DC3E0", VA = "0x1846DDBE0")]
			public static Enumerator New([In] SOAId32<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x46DC8C0", Offset = "0x46DB0C0", VA = "0x1846DC8C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2BAD460", Offset = "0x2BABC60", VA = "0x182BAD460", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public sealed class EOINQAQTMSQ
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
		[Cpp2IlInjected.Address(RVA = "0x5E313D0", Offset = "0x5E2FBD0", VA = "0x185E313D0")]
		internal SOAId32(UnsafeList<ulong> used, UnsafeList<Id32<M>> free, Id32<M> next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E305D0", Offset = "0x5E2EDD0", VA = "0x185E305D0")]
		public static SOAId32<M> New()
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F3D0", Offset = "0x5E2DBD0", VA = "0x185E2F3D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E30130", Offset = "0x5E2E930", VA = "0x185E30130")]
		public Id32<M> KRLRSDMBTIW()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E30820", Offset = "0x5E2F020", VA = "0x185E30820")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FAA0", Offset = "0x5E2E2A0", VA = "0x185E2FAA0")]
		public readonly JRTAVCPMZII JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
		public readonly Id32<M> IAZLJCXOMWJ()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E31200", Offset = "0x5E2FA00", VA = "0x185E31200")]
		public readonly bool UNALUPZDZIL(Id32<M> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E30450", Offset = "0x5E2EC50", VA = "0x185E30450")]
		public readonly bool MJQWBVQVIEE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E31310", Offset = "0x5E2FB10", VA = "0x185E31310")]
		public readonly int XPRPVYFZYNS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F280", Offset = "0x5E2DA80", VA = "0x185E2F280")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F440", Offset = "0x5E2DC40", VA = "0x185E2F440")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F540", Offset = "0x5E2DD40", VA = "0x185E2F540")]
		public readonly CopyEnumerable<Id32<M>, Enumerator> HIJSWMHAYVJ()
		{
			return default(CopyEnumerable<Id32<M>, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E30960", Offset = "0x5E2F160", VA = "0x185E30960", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class UXOGPRNCOCY
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x28B5960", Offset = "0x28B4160", VA = "0x1828B5960")]
		public static (int, ulong) IZNAJESPGDY(int a)
		{
			return default((int, ulong));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class YMEHYXJWTUA<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x304B350", Offset = "0x3049B50", VA = "0x18304B350")]
		public static SOAId32<b> GEWKGALZMRL<a>([In] SOAId32<a> self) where a : b
		{
			return default(SOAId32<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerTypeProxy(typeof(SOAId32Field<, >.EOINQAQTMSQ))]
	public struct SOAId32Field<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class EOINQAQTMSQ
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal SOAId32<M> _soaId32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal SOAField<M, T> _soaField;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F140", Offset = "0x5E2D940", VA = "0x185E2F140")]
		internal SOAId32Field([In] SOAId32<M> soaId32, [In] SOAField<M, T> soaField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E670", Offset = "0x5E2CE70", VA = "0x185E2E670")]
		public static SOAId32Field<M, T> New()
		{
			return default(SOAId32Field<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D570", Offset = "0x5E2BD70", VA = "0x185E2D570", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E2DF60", Offset = "0x5E2C760", VA = "0x185E2DF60")]
		public Id32<M> KRLRSDMBTIW([In] T obj)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EDF0", Offset = "0x5E2D5F0", VA = "0x185E2EDF0")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E2DB70", Offset = "0x5E2C370", VA = "0x185E2DB70")]
		public void JVNLJYOIGPY(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F080", Offset = "0x5E2D880", VA = "0x185E2F080", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class QLSCOYMWKWE
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public readonly struct Deserializer<TSerialized, TDeserialized>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly JRTAVCPMZII _serializedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly RepeatedField<TSerialized> _serialized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Func<TSerialized, TDeserialized> _deserialize;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1BA8470", Offset = "0x1BA6C70", VA = "0x181BA8470")]
			internal Deserializer(JRTAVCPMZII serializedIds, RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3614FB0", Offset = "0x36137B0", VA = "0x183614FB0")]
			public SOAId32Field<a, TDeserialized> GKVTZPEUDHU<a>()
			{
				return default(SOAId32Field<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3950C00", Offset = "0x394F400", VA = "0x183950C00")]
		public static JRTAVCPMZII LGUGPDCUSLC<a, b, c>([In] this SOAId32Field<a, b> self, RepeatedField<c> a, Func<b, c> b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3951C80", Offset = "0x3950480", VA = "0x183951C80")]
		public static Deserializer<i, j> NTNJZEARGRX<i, j>(this JRTAVCPMZII a, RepeatedField<i> b, Func<i, j> c)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3950770", Offset = "0x394EF70", VA = "0x183950770")]
		public static void Destroy<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3950E40", Offset = "0x394F640", VA = "0x183950E40")]
		public static string NRIFDNFTQDQ<l, m>([In] this SOAId32Field<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x39505F0", Offset = "0x394EDF0", VA = "0x1839505F0")]
		public static void Clear<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x39506B0", Offset = "0x394EEB0", VA = "0x1839506B0")]
		public static SOAId32<bb>.Enumerator DLJDINLECZQ<bb, bc>([In] this SOAId32Field<bb, bc> self)
		{
			return default(SOAId32<bb>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3951DF0", Offset = "0x39505F0", VA = "0x183951DF0")]
		public static CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator> VMCTMPCFAUK<bd, be>([In] this SOAId32Field<bd, be> self)
		{
			return default(CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3950810", Offset = "0x394F010", VA = "0x183950810")]
		public static T Get<T, M>([In] this SOAId32Field<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x39508A0", Offset = "0x394F0A0", VA = "0x1839508A0")]
		public static bg EEIMAHKHUGN<bg, bf>(this SOAId32Field<bf, bg> a, Id32<bf> b)
		{
			return (bg)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3950510", Offset = "0x394ED10", VA = "0x183950510")]
		public static bi BCWSWZHXEWR<bi, bh>([In] this SOAId32Field<bh, bi> self, Id32<bh> a)
		{
			return (bi)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3951D80", Offset = "0x3950580", VA = "0x183951D80")]
		public static ConstEnumerable<bw, SOAField<bv, bw>.Enumerator> VJENGWHEUEQ<bw, bv>([In] this SOAId32Field<bv, bw> self)
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
		[Cpp2IlInjected.Address(RVA = "0x28B58E0", Offset = "0x28B40E0", VA = "0x1828B58E0")]
		private StopwatchLogScope(string message, [In] ReadOnlyStopwatch stopwatch, [In] LogDelegates logDelegates, bool cachedShouldLog)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x28B5700", Offset = "0x28B3F00", VA = "0x1828B5700", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28B57B0", Offset = "0x28B3FB0", VA = "0x1828B57B0")]
		public static StopwatchLogScope OSYAYVYDBOY(string a, [In] LogDelegates logDelegates, bool b)
		{
			return default(StopwatchLogScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class SQAVIJUXPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28B5280", Offset = "0x28B3A80", VA = "0x1828B5280")]
		public static void TRFNXRMVMVQ(this Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x28B50D0", Offset = "0x28B38D0", VA = "0x1828B50D0")]
		public static bool OTVJPCMAWMD(this Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x28B5670", Offset = "0x28B3E70", VA = "0x1828B5670")]
		public static void ZJTUWBCPZDC(this Stream a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28B4EB0", Offset = "0x28B36B0", VA = "0x1828B4EB0")]
		public static float MZCIIMCXLYP(this Stream a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28B5470", Offset = "0x28B3C70", VA = "0x1828B5470")]
		public static void XDHIHZPEKDB(this Stream a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28B4BB0", Offset = "0x28B33B0", VA = "0x1828B4BB0")]
		public static int EADCIDQEEXC(this Stream a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28B4BD0", Offset = "0x28B33D0", VA = "0x1828B4BD0")]
		public static void FTHLOGBCAVO(this Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28B4F00", Offset = "0x28B3700", VA = "0x1828B4F00")]
		public static long OJQWBCOIGPD(this Stream a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28B5100", Offset = "0x28B3900", VA = "0x1828B5100")]
		public static void SUFCNMFQCSL(this Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28B53A0", Offset = "0x28B3BA0", VA = "0x1828B53A0")]
		public static string WPIQFNJPLYO(this Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28B4ED0", Offset = "0x28B36D0", VA = "0x1828B4ED0")]
		public static void OBPIZRQFXOE(this Stream a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28B5500", Offset = "0x28B3D00", VA = "0x1828B5500")]
		public static void XJHCPFKCKLH(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28B52C0", Offset = "0x28B3AC0", VA = "0x1828B52C0")]
		public static void WMEMISPAJBL(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28B4E80", Offset = "0x28B3680", VA = "0x1828B4E80")]
		public static byte LKARNTJIAKN(this Stream a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28B5580", Offset = "0x28B3D80", VA = "0x1828B5580")]
		public static (byte, byte, byte, byte) YPMFLHSGYRW(this Stream self)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28B4CC0", Offset = "0x28B34C0", VA = "0x1828B4CC0")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) FWSQQTMBDDK(this Stream self)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class PHYPVUBWOVQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x38B9BB0", Offset = "0x38B83B0", VA = "0x1838B9BB0")]
		public static void LGUGPDCUSLC<a, b>([In] this UnsafeList<a> self, RepeatedField<b> a, Func<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x38BA390", Offset = "0x38B8B90", VA = "0x1838BA390")]
		public static void LGUGPDCUSLC<e>([In] this UnsafeList<e> self, RepeatedField<e> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x38BABB0", Offset = "0x38B93B0", VA = "0x1838BABB0")]
		public static UnsafeList<i> MJYTRYOIYSS<i, h>(this RepeatedField<h> a, Func<h, i> b)
		{
			return default(UnsafeList<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x38BADD0", Offset = "0x38B95D0", VA = "0x1838BADD0")]
		public static UnsafeList<k> MJYTRYOIYSS<k>(this RepeatedField<k> a)
		{
			return default(UnsafeList<k>);
		}
	}
}
namespace Circuits.Shared.Utilities.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class SGZVJOHXNUW
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3002D70", Offset = "0x3001570", VA = "0x183002D70")]
		public static SOAFieldData<T> ADIAKKFUHVW<T>(this RepeatedField<T> a) where T : notnull
		{
			return default(SOAFieldData<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3002D70", Offset = "0x3001570", VA = "0x183002D70")]
		public static RepeatedId32Field<M> EWHLATWZJAR<M>(this RepeatedField<int> a) where M : notnull
		{
			return default(RepeatedId32Field<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A25060", Offset = "0x3A23860", VA = "0x183A25060")]
		internal static void GNAPKEHNOYY<a>(this RepeatedField<a> a, int b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A24FF0", Offset = "0x3A237F0", VA = "0x183A24FF0")]
		internal static void GNAPKEHNOYY<b>(this RepeatedField<b> self, int a, b b) where b : struct
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
				[Cpp2IlInjected.Address(RVA = "0x46DFA90", Offset = "0x46DE290", VA = "0x1846DFA90", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x46DD9E0", Offset = "0x46DC1E0", VA = "0x1846DD9E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x46DF3A0", Offset = "0x46DDBA0", VA = "0x1846DF3A0")]
			private Enumerator(RepeatedField<int> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x4030F40", Offset = "0x402F740", VA = "0x184030F40")]
			public static Enumerator New(RepeatedField<int> impl)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x46DCFF0", Offset = "0x46DB7F0", VA = "0x1846DCFF0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x28B4430", Offset = "0x28B2C30", VA = "0x1828B4430", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RepeatedField<int> _impl;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
		internal RepeatedId32Field(RepeatedField<int> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DC25D0", Offset = "0x5DC0DD0", VA = "0x185DC25D0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2620", Offset = "0x5DC0E20", VA = "0x185DC2620", Slot = "4")]
		private IEnumerator<Id32<M>> YJPQGZVWHIV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2620", Offset = "0x5DC0E20", VA = "0x185DC2620", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
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
		[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
		internal SOAFieldData(RepeatedField<T> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3939710", Offset = "0x3937F10", VA = "0x183939710")]
		public SOAField<a?, b?> WDKEUGVWMDY<a, b>([In] SOAId32<a> ids, Func<T, b> deserialize)
		{
			return default(SOAField<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3938210", Offset = "0x3936A10", VA = "0x183938210")]
		public SOAField<c?, d?> PONWVRQYCSA<c, d>([In] SOAId32<c> ids, Func<T, d> deserialize)
		{
			return default(SOAField<c, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x393B290", Offset = "0x3939A90", VA = "0x18393B290")]
		public SOAField<e?, T?> WDKEUGVWMDY<e>([In] SOAId32<e> ids)
		{
			return default(SOAField<e, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x39376A0", Offset = "0x3935EA0", VA = "0x1839376A0")]
		public SOAField<f?, g?> ODXHDEMVINY<f, g>([In] SOAId32<f> ids, Func<Id32<f>, g> deserialize)
		{
			return default(SOAField<f, g>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class BERNLAPAKVZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x339F6D0", Offset = "0x339DED0", VA = "0x18339F6D0")]
		public static void KRLRSDMBTIW<a>(this SOAFieldData<a> self, int a, a b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x339F640", Offset = "0x339DE40", VA = "0x18339F640")]
		public static void KRLRSDMBTIW<b>(this SOAFieldData<b> a, int b, b c, b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x339F760", Offset = "0x339DF60", VA = "0x18339F760")]
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
			private MDAGXDRPNRR.Enumerator _impl;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public readonly Id32<M> Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x46E02D0", Offset = "0x46DEAD0", VA = "0x1846E02D0", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private readonly object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x46DDB50", Offset = "0x46DC350", VA = "0x1846DDB50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xFED370", Offset = "0xFEBB70", VA = "0x180FED370")]
			private Enumerator([In] MDAGXDRPNRR.Enumerator impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x46DDC40", Offset = "0x46DC440", VA = "0x1846DDC40")]
			public static Enumerator New([In] SOAId32Data<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x46DD7E0", Offset = "0x46DBFE0", VA = "0x1846DD7E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x46DDCF0", Offset = "0x46DC4F0", VA = "0x1846DDCF0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly JRTAVCPMZII _impl;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xBE9BA0", Offset = "0xBE83A0", VA = "0x180BE9BA0")]
		internal SOAId32Data(JRTAVCPMZII impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D3E0", Offset = "0x5E2BBE0", VA = "0x185E2D3E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D430", Offset = "0x5E2BC30", VA = "0x185E2D430", Slot = "4")]
		private IEnumerator<Id32<M>> YJPQGZVWHIV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D430", Offset = "0x5E2BC30", VA = "0x185E2D430", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class MDAGXDRPNRR
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
				[Cpp2IlInjected.Address(RVA = "0xC9D230", Offset = "0xC9BA30", VA = "0x180C9D230", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x28B4320", Offset = "0x28B2B20", VA = "0x1828B4320", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x28B44E0", Offset = "0x28B2CE0", VA = "0x1828B44E0")]
			private Enumerator([In] RepeatedField<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x28B43C0", Offset = "0x28B2BC0", VA = "0x1828B43C0")]
			public static Enumerator New([In] JRTAVCPMZII self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x28B4110", Offset = "0x28B2910", VA = "0x1828B4110", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x28B4430", Offset = "0x28B2C30", VA = "0x1828B4430", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x376DBE0", Offset = "0x376C3E0", VA = "0x18376DBE0")]
		public static SOAId32<M> WDKEUGVWMDY<M>(this JRTAVCPMZII a) where M : notnull
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28B4900", Offset = "0x28B3100", VA = "0x1828B4900")]
		public static bool UNALUPZDZIL(this JRTAVCPMZII a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28B4600", Offset = "0x28B2E00", VA = "0x1828B4600")]
		public static int KRLRSDMBTIW(this JRTAVCPMZII a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28B47C0", Offset = "0x28B2FC0", VA = "0x1828B47C0")]
		public static void Release(this JRTAVCPMZII self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3002D70", Offset = "0x3001570", VA = "0x183002D70")]
		public static SOAId32Data<M> EWHLATWZJAR<M>(this JRTAVCPMZII a) where M : notnull
		{
			return default(SOAId32Data<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28B4510", Offset = "0x28B2D10", VA = "0x1828B4510")]
		public static Enumerator GetEnumerator(this JRTAVCPMZII self)
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28B4560", Offset = "0x28B2D60", VA = "0x1828B4560")]
		public static CopyEnumerable<int, Enumerator> HIJSWMHAYVJ(this JRTAVCPMZII self)
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
