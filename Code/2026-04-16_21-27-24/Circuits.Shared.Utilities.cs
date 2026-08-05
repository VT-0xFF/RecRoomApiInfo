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
		[Cpp2IlInjected.Address(RVA = "0x2B70600", Offset = "0x2B6F400", VA = "0x182B70600")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FIAZYKDWMRF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FC10", Offset = "0x2B6EA10", VA = "0x182B6FC10")]
		private static string BZCBQRPQWSS(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FBA0", Offset = "0x2B6E9A0", VA = "0x182B6FBA0")]
		public static string ACRIBZKWGRV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FF30", Offset = "0x2B6ED30", VA = "0x182B6FF30")]
		public static string MDQKGFXHYZI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3AA30A0", Offset = "0x3AA1EA0", VA = "0x183AA30A0")]
		public static string ODULNITXNKO<a>([In] a actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B70120", Offset = "0x2B6EF20", VA = "0x182B70120")]
		public static string VXCOKAGXARX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA3A60", Offset = "0x3AA2860", VA = "0x183AA3A60")]
		public static string UJHYFVPNOVY<b, c>([In] b expected, [In] c actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3AA38F0", Offset = "0x3AA26F0", VA = "0x183AA38F0")]
		public static string TJAHKTGDUQR<d, e>([In] d notExpected, [In] e actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FE20", Offset = "0x2B6EC20", VA = "0x182B6FE20")]
		public static string FIJRJWGCNZH(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FE70", Offset = "0x2B6EC70", VA = "0x182B6FE70")]
		public static string HTIRLFLNVTB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FBD0", Offset = "0x2B6E9D0", VA = "0x182B6FBD0")]
		public static string BNQTIHYRXDM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FF60", Offset = "0x2B6ED60", VA = "0x182B6FF60")]
		public static string MXUSQURBZZB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2980", Offset = "0x3AA1780", VA = "0x183AA2980")]
		public static string DABLPRGBUQL<dg>(string a, [In] dg actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FEF0", Offset = "0x2B6ECF0", VA = "0x182B6FEF0")]
		public static string LPQFEMDQSAE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2A40", Offset = "0x3AA1840", VA = "0x183AA2A40")]
		public static string HJRBNIMFQWT<dh, di>(string a, [In] dh expected, [In] di actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2780", Offset = "0x3AA1580", VA = "0x183AA2780")]
		public static string AUAIDKLWLGE<dj, dk>(string a, [In] dj notExpected, [In] dk actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FD80", Offset = "0x2B6EB80", VA = "0x182B6FD80")]
		public static void FEQGKJBAJEA(this LogDelegate a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FFA0", Offset = "0x2B6EDA0", VA = "0x182B6FFA0")]
		public static bool QDJTYCAYWGQ([In] this LogDelegates log, [Optional] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B70320", Offset = "0x2B6F120", VA = "0x182B70320")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B70240", Offset = "0x2B6F040", VA = "0x182B70240")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Out] LogDelegate err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B70050", Offset = "0x2B6EE50", VA = "0x182B70050")]
		public static bool VLABYDCQSJJ([In] this LogDelegates log, bool a, [Optional] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3AA42B0", Offset = "0x3AA30B0", VA = "0x183AA42B0")]
		public static bool VLABYDCQSJJ<ic>([In] this LogDelegates log, bool a, ic b, FastestMessageFunc<ic> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4350", Offset = "0x3AA3150", VA = "0x183AA4350")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T expected, U actual, [Optional] string message) where T : IEquatable<U>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B70150", Offset = "0x2B6EF50", VA = "0x182B70150")]
		public static bool VerifyAreNotEqual([In] this LogDelegates log, object notExpected, object actual, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA46E0", Offset = "0x3AA34E0", VA = "0x183AA46E0")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, [In] T actual, [Optional] string message) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B70020", Offset = "0x2B6EE20", VA = "0x182B70020")]
		public static PerfScopeToken QEMXHTRIIQX([In] this PerfScopeDelegates self, [Optional][CallerMemberName] string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B703F0", Offset = "0x2B6F1F0", VA = "0x182B703F0")]
		public static PerfScopeToken XBTTOTQTCYS([In] this PerfScopeDelegates self, Func<string> a)
		{
			return default(PerfScopeToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class FUXGQQZPOXN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA94B0", Offset = "0x3AA82B0", VA = "0x183AA94B0")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9630", Offset = "0x3AA8430", VA = "0x183AA9630")]
		public static bool VerifyIsNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3AA91A0", Offset = "0x3AA7FA0", VA = "0x183AA91A0")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T? expected, U? actual, [Optional] string message, [Optional] string isNotNullMessage, [Optional] string isNullMessage) where T : struct, IEquatable<U> where U : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerTypeProxy(typeof(IdUnsafeList<, >.FOHLCOITXVI))]
	public struct IdUnsafeList<M, T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public sealed class FOHLCOITXVI
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal UnsafeList<T> _unsafeList;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x12AF450", Offset = "0x12AE250", VA = "0x1812AF450")]
		internal IdUnsafeList([In] UnsafeList<T> unsafeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6598160", Offset = "0x6596F60", VA = "0x186598160")]
		public static IdUnsafeList<M, T> New()
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6598270", Offset = "0x6597070", VA = "0x186598270")]
		public static IdUnsafeList<M, T> OJHNYCKGXCF(int a)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6598AD0", Offset = "0x65978D0", VA = "0x186598AD0", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RPHAKGEIEHQ
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
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			internal Deserializer(RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x37C5650", Offset = "0x37C4450", VA = "0x1837C5650")]
			public IdUnsafeList<a, TDeserialized> QVGLLKEPNLO<a>()
			{
				return default(IdUnsafeList<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A210", Offset = "0x3E39010", VA = "0x183E3A210")]
		public static void LMZZNKCMKGC<a, b, c>([In] this IdUnsafeList<a, b> self, RepeatedField<c> a, Func<b, c> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E550", Offset = "0x3D7D350", VA = "0x183D7E550")]
		public static Deserializer<i, j> YHVVTIELEVJ<i, j>(this RepeatedField<i> a, Func<i, j> b)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3E392C0", Offset = "0x3E380C0", VA = "0x183E392C0")]
		public static void Destroy<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3E48BC0", Offset = "0x3E479C0", VA = "0x183E48BC0")]
		public static string TOAIPHVREMM<n, o>([In] this IdUnsafeList<n, o> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDEFAA0", Offset = "0xDEE8A0", VA = "0x180DEFAA0")]
		public static UnsafeList<y> XQLOBVSABYR<y, x>([In] this IdUnsafeList<x, y> self)
		{
			return default(UnsafeList<y>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3E39410", Offset = "0x3E38210", VA = "0x183E39410")]
		public static T Get<T, M>([In] this IdUnsafeList<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3E39460", Offset = "0x3E38260", VA = "0x183E39460")]
		public static ba OVGQIVVGLQH<ba, z>(this IdUnsafeList<z, ba> a, Id32<z> b)
		{
			return (ba)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3E38E10", Offset = "0x3E37C10", VA = "0x183E38E10")]
		public static bc BGZONRYHXQP<bc, bb>([In] this IdUnsafeList<bb, bc> self, Id32<bb> a)
		{
			return (bc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3E39D50", Offset = "0x3E38B50", VA = "0x183E39D50")]
		public static void Set<M, T>(this IdUnsafeList<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E39D50", Offset = "0x3E38B50", VA = "0x183E39D50")]
		public static void KNGTDHVKDDF<bd, be>(this IdUnsafeList<bd, be> a, Id32<bd> b, be c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E477D0", Offset = "0x3E465D0", VA = "0x183E477D0")]
		public static int MNIKZMVRDAG<bh, bi>([In] this IdUnsafeList<bh, bi> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3E49040", Offset = "0x3E47E40", VA = "0x183E49040")]
		public static Id32<bl> VBQHWUXIARI<bl, bm>([In] this IdUnsafeList<bl, bm> self)
		{
			return default(Id32<bl>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3E38C50", Offset = "0x3E37A50", VA = "0x183E38C50")]
		public static bo BCFYMSBYKQT<bo, bn>([In] this IdUnsafeList<bn, bo> self)
		{
			return (bo)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3E47970", Offset = "0x3E46770", VA = "0x183E47970")]
		public static ReadOnlyIdArray<bt, bu> PSVUXSOJOWJ<bt, bu>(this IdUnsafeList<bt, bu> a)
		{
			return default(ReadOnlyIdArray<bt, bu>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3E38A90", Offset = "0x3E37890", VA = "0x183E38A90")]
		public static Id32<M> Add<M, T>(this IdUnsafeList<M, T> self, [In] T item)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3E49300", Offset = "0x3E48100", VA = "0x183E49300")]
		public static Id32<bv> YRYHSXBVIRE<bv, bw>(this IdUnsafeList<bv, bw> a, bw b)
		{
			return default(Id32<bv>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E39870", Offset = "0x3E38670", VA = "0x183E39870")]
		public static void Insert<M, T>(this IdUnsafeList<M, T> self, int index, [In] T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3E39080", Offset = "0x3E37E80", VA = "0x183E39080")]
		public static void CCZLIMJTFFG<bx, by>(this IdUnsafeList<bx, by> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3E48590", Offset = "0x3E47390", VA = "0x183E48590")]
		public static void TLJJBWBKLYO<bz, ca>(this IdUnsafeList<bz, ca> a, Id32<bz> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3E390D0", Offset = "0x3E37ED0", VA = "0x183E390D0")]
		public static void Clear<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3E391A0", Offset = "0x3E37FA0", VA = "0x183E391A0")]
		public static IdUnsafeList<M, T> Clone<M, T>([In] this IdUnsafeList<M, T> self, InFunc<T, T> cloneItem)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3E48220", Offset = "0x3E47020", VA = "0x183E48220")]
		public static Id32Enumerator<ch> TCBAFEHSVEE<ch, ci>([In] this IdUnsafeList<ch, ci> self)
		{
			return default(Id32Enumerator<ch>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3E39360", Offset = "0x3E38160", VA = "0x183E39360")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T, M>([In] this IdUnsafeList<M, T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3E397B0", Offset = "0x3E385B0", VA = "0x183E397B0")]
		public static UnsafeList<ck>.MutEnumerator HLRDNUKMWYV<ck, cj>(this IdUnsafeList<cj, ck> a)
		{
			return default(UnsafeList<ck>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E49430", Offset = "0x3E48230", VA = "0x183E49430")]
		public static CopyEnumerable<Id32<cl>, Id32Enumerator<cl>> ZCAQORDQJEI<cl, cm>([In] this IdUnsafeList<cl, cm> self)
		{
			return default(CopyEnumerable<Id32<cl>, Id32Enumerator<cl>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A170", Offset = "0x3E38F70", VA = "0x183E3A170")]
		public static ConstEnumerable<co, UnsafeList<co>.Enumerator> LFRDYHFOVCN<co, cn>([In] this IdUnsafeList<cn, co> self)
		{
			return default(ConstEnumerable<co, UnsafeList<co>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3E47800", Offset = "0x3E46600", VA = "0x183E47800")]
		public static MutEnumerable<cq, UnsafeList<cq>.MutEnumerator> PBAPDTEBKVL<cq, cp>(this IdUnsafeList<cp, cq> a)
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
		[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
		internal LinearIdAllocator32(int next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68E9AA0", Offset = "0x68E88A0", VA = "0x1868E9AA0")]
		public static LinearIdAllocator32<M> New()
		{
			return default(LinearIdAllocator32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68E9BA0", Offset = "0x68E89A0", VA = "0x1868E9BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class OJXDELJAMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D764E0", Offset = "0x3D752E0", VA = "0x183D764E0")]
		public static void Clear<M>(this LinearIdAllocator32<M> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D76540", Offset = "0x3D75340", VA = "0x183D76540")]
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
				[Cpp2IlInjected.Address(RVA = "0x6597660", Offset = "0x6596460", VA = "0x186597660", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private readonly object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x65971A0", Offset = "0x6595FA0", VA = "0x1865971A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6597540", Offset = "0x6596340", VA = "0x186597540")]
			private IdEnumerator(Dictionary<Id32<M>, Id32<M>> gcToLinear, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x65972C0", Offset = "0x65960C0", VA = "0x1865972C0")]
			public static IdEnumerator New(LinearObjAllocator32<M, T> self)
			{
				return default(IdEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6597280", Offset = "0x6596080", VA = "0x186597280", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6597500", Offset = "0x6596300", VA = "0x186597500", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x68EA090", Offset = "0x68E8E90", VA = "0x1868EA090")]
		private LinearObjAllocator32([In] SOAId32Field<M, T> gcObjAllocator, Dictionary<Id32<M>, Id32<M>> linearToGC, Dictionary<Id32<M>, Id32<M>> gcToLinear, LinearIdAllocator32<M> linearIdAllocator32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x68E9C60", Offset = "0x68E8A60", VA = "0x1868E9C60")]
		public static LinearObjAllocator32<M, T> New()
		{
			return default(LinearObjAllocator32<M, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class HSRSQFOINKX
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3380", Offset = "0x3AD2180", VA = "0x183AD3380")]
		public static T Get<T, M>([In] this LinearObjAllocator32<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3AD32B0", Offset = "0x3AD20B0", VA = "0x183AD32B0")]
		public static void Destroy<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3AD36A0", Offset = "0x3AD24A0", VA = "0x183AD36A0")]
		public static Id32<e> SZXCONVJSCU<e, f>(this LinearObjAllocator32<e, f> a, [In] f obj)
		{
			return default(Id32<e>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3510", Offset = "0x3AD2310", VA = "0x183AD3510")]
		public static void Release<M, T>(this LinearObjAllocator32<M, T> self, Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3AD30A0", Offset = "0x3AD1EA0", VA = "0x183AD30A0")]
		public static void Clear<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3AD37F0", Offset = "0x3AD25F0", VA = "0x183AD37F0")]
		public static LinearObjAllocator32<n, o>.IdEnumerator TCBAFEHSVEE<n, o>([In] this LinearObjAllocator32<n, o> self)
		{
			return default(LinearObjAllocator32<n, o>.IdEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3960", Offset = "0x3AD2760", VA = "0x183AD3960")]
		public static CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator> ZCAQORDQJEI<t, u>([In] this LinearObjAllocator32<t, u> self)
		{
			return default(CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MultiResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct Enumerator : DAPUSUGFXOD<Result<object, SEZYOHJZPUT>>, QTWRXTHQFKK<Result<object, SEZYOHJZPUT>>, IEnumerator<Result<object, SEZYOHJZPUT>>, IEnumerator, IDisposable, INRSRQYOJXV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private readonly Result<object, SEZYOHJZPUT>[] _results;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public readonly int PUCTPTIOQGU
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2B6F7E0", Offset = "0x2B6E5E0", VA = "0x182B6F7E0", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public readonly Result<object, SEZYOHJZPUT> Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2B6F7A0", Offset = "0x2B6E5A0", VA = "0x182B6F7A0", Slot = "11")]
				get
				{
					return default(Result<object, SEZYOHJZPUT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private readonly Result<object, SEZYOHJZPUT> PQNTDPTHETN
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2B6F7A0", Offset = "0x2B6E5A0", VA = "0x182B6F7A0", Slot = "4")]
				get
				{
					return default(Result<object, SEZYOHJZPUT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private readonly Result<object, SEZYOHJZPUT> EQGJCYAMCZB
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2B6FB30", Offset = "0x2B6E930", VA = "0x182B6FB30", Slot = "5")]
				get
				{
					return default(Result<object, SEZYOHJZPUT>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private readonly object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2B6F830", Offset = "0x2B6E630", VA = "0x182B6F830", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD9EB20", Offset = "0xD9D920", VA = "0x180D9EB20")]
			private Enumerator(Result<object, SEZYOHJZPUT>[] results, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B6FAB0", Offset = "0x2B6E8B0", VA = "0x182B6FAB0")]
			public static Enumerator New(Result<object, SEZYOHJZPUT>[] results)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B6F8A0", Offset = "0x2B6E6A0", VA = "0x182B6F8A0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B6FB20", Offset = "0x2B6E920", VA = "0x182B6FB20", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly Result<object, SEZYOHJZPUT>[] _results;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Result<object, SEZYOHJZPUT> this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2B705C0", Offset = "0x2B6F3C0", VA = "0x182B705C0")]
			get
			{
				return default(Result<object, SEZYOHJZPUT>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static MultiResult TXSURWIFJDY
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B70520", Offset = "0x2B6F320", VA = "0x182B70520")]
			get
			{
				return default(MultiResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		internal MultiResult(Result<object, SEZYOHJZPUT>[] results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x10C67F0", Offset = "0x10C55F0", VA = "0x1810C67F0")]
		public static MultiResult New(Result<object, SEZYOHJZPUT>[] results)
		{
			return default(MultiResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B704E0", Offset = "0x2B6F2E0", VA = "0x182B704E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DebuggerTypeProxy(typeof(SOAField<, >.FOHLCOITXVI))]
	public struct SOAField<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct MutEnumerator : DAPUSUGFXOD<T>, QTWRXTHQFKK<T>, IEnumerator<T>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x71057A0", Offset = "0x71045A0", VA = "0x1871057A0", Slot = "10")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public readonly T SKGGEAXRCYN
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x7103EE0", Offset = "0x7102CE0", VA = "0x187103EE0")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private readonly T BKLGIGYXSAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x7104EB0", Offset = "0x7103CB0", VA = "0x187104EB0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private readonly T HTALOBYUKAE
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x7105110", Offset = "0x7103F10", VA = "0x187105110", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private readonly object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x71048F0", Offset = "0x71036F0", VA = "0x1871048F0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x71055F0", Offset = "0x71043F0", VA = "0x1871055F0")]
			internal MutEnumerator([In] IdUnsafeList<M, T> objects, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7104BB0", Offset = "0x71039B0", VA = "0x187104BB0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7104FE0", Offset = "0x7103DE0", VA = "0x187104FE0", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct Enumerator : QTWRXTHQFKK<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x5C41620", Offset = "0x5C40420", VA = "0x185C41620", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly T HTALOBYUKAE
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x5C3E120", Offset = "0x5C3CF20", VA = "0x185C3E120", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private readonly object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x5C3E120", Offset = "0x5C3CF20", VA = "0x185C3E120", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x52EF6B0", Offset = "0x52EE4B0", VA = "0x1852EF6B0")]
			internal Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5C3E470", Offset = "0x5C3D270", VA = "0x185C3E470", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5C3E840", Offset = "0x5C3D640", VA = "0x185C3E840", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5C3DFB0", Offset = "0x5C3CDB0", VA = "0x185C3DFB0", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public sealed class FOHLCOITXVI
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal IdUnsafeList<M, T> _objects;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x12AF450", Offset = "0x12AE250", VA = "0x1812AF450")]
		internal SOAField([In] IdUnsafeList<M, T> objects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78B1B80", Offset = "0x78B0980", VA = "0x1878B1B80")]
		public static SOAField<M, T> New()
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x78B1BF0", Offset = "0x78B09F0", VA = "0x1878B1BF0")]
		public static SOAField<M, T> OJHNYCKGXCF(int a)
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x78B1AD0", Offset = "0x78B08D0", VA = "0x1878B1AD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x78B4590", Offset = "0x78B3390", VA = "0x1878B4590")]
		public void SZXCONVJSCU(Id32<M> a, [In] T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x78B2920", Offset = "0x78B1720", VA = "0x1878B2920")]
		public void QBEOZWTIYMW(Id32<M> a, T b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x78B3840", Offset = "0x78B2640", VA = "0x1878B3840")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78B2F20", Offset = "0x78B1D20", VA = "0x1878B2F20")]
		public void QLACLYUIVFC(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x78B5270", Offset = "0x78B4070", VA = "0x1878B5270", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class MJFCDEBUJWS
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3C06220", Offset = "0x3C05020", VA = "0x183C06220")]
		public static void LMZZNKCMKGC<a, b, c>([In] this SOAField<a, b> self, [In] SOAId32<a> ids, RepeatedField<c> a, Func<b, c> b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3C078B0", Offset = "0x3C066B0", VA = "0x183C078B0")]
		public static void LMZZNKCMKGC<d, e, f>([In] this SOAField<d, e> self, [In] SOAId32<d> ids, RepeatedField<f> a, InFunc<e, f> b, f c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3C07200", Offset = "0x3C06000", VA = "0x183C07200")]
		public static void LMZZNKCMKGC<g, h>([In] this SOAField<g, h> self, [In] SOAId32<g> ids, RepeatedField<h> a, h b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3C089A0", Offset = "0x3C077A0", VA = "0x183C089A0")]
		public static void TUFBGSKWTQG<i, j, k>([In] this SOAField<i, j> self, [In] SOAId32<i> ids, RepeatedField<k> a, Func<Id32<i>, k> b, k c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3C04660", Offset = "0x3C03460", VA = "0x183C04660")]
		public static void Destroy<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C08240", Offset = "0x3C07040", VA = "0x183C08240")]
		public static string TOAIPHVREMM<l, m>([In] this SOAField<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AD80", Offset = "0x2B89B80", VA = "0x182B8AD80")]
		public static T Get<T, M>([In] this SOAField<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2CE4980", Offset = "0x2CE3780", VA = "0x182CE4980")]
		public static o OVGQIVVGLQH<o, n>(this SOAField<n, o> a, Id32<n> b)
		{
			return (o)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3C043D0", Offset = "0x3C031D0", VA = "0x183C043D0")]
		public static q BGZONRYHXQP<q, p>([In] this SOAField<p, q> self, Id32<p> a)
		{
			return (q)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2D24880", Offset = "0x2D23680", VA = "0x182D24880")]
		public static void Set<M, T>(this SOAField<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F110", Offset = "0x2B7DF10", VA = "0x182B7F110")]
		public static void KNGTDHVKDDF<r, s>(this SOAField<r, s> a, Id32<r> b, s c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3C05240", Offset = "0x3C04040", VA = "0x183C05240")]
		public static ReadOnlyIdSpan<v, w> KYUBDITBCOC<v, w>([In] this SOAField<v, w> self)
		{
			return default(ReadOnlyIdSpan<v, w>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3C04E40", Offset = "0x3C03C40", VA = "0x183C04E40")]
		public static int HLZMISLPCTU<x, y>([In] this SOAField<x, y> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C04620", Offset = "0x3C03420", VA = "0x183C04620")]
		public static void Clear<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3C07C20", Offset = "0x3C06A20", VA = "0x183C07C20")]
		public static bool PBWCOQDYWXL<z, ba>([In] this SOAField<z, ba> self, Id32<z> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3C047B0", Offset = "0x3C035B0", VA = "0x183C047B0")]
		public static SOAField<M, T>.Enumerator GetEnumerator<M, T>([In] this SOAField<M, T> self, [In] SOAId32<M> ids)
		{
			return default(SOAField<M, T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3C04D60", Offset = "0x3C03B60", VA = "0x183C04D60")]
		public static SOAField<bd, be>.MutEnumerator HLRDNUKMWYV<bd, be>(this SOAField<bd, be> a, [In] SOAId32<bd> ids)
		{
			return default(SOAField<bd, be>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3C053D0", Offset = "0x3C041D0", VA = "0x183C053D0")]
		public static ConstEnumerable<bi, SOAField<bh, bi>.Enumerator> LFRDYHFOVCN<bi, bh>([In] this SOAField<bh, bi> self, [In] SOAId32<bh> ids)
		{
			return default(ConstEnumerable<bi, SOAField<bh, bi>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3C07AF0", Offset = "0x3C068F0", VA = "0x183C07AF0")]
		public static MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator> PBAPDTEBKVL<bm, bl>(this SOAField<bl, bm> a, [In] SOAId32<bl> ids)
		{
			return default(MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DebuggerTypeProxy(typeof(SOAId32<>.FOHLCOITXVI))]
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
				[Cpp2IlInjected.Address(RVA = "0x5BB3E90", Offset = "0x5BB2C90", VA = "0x185BB3E90", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private readonly object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x5BAF270", Offset = "0x5BAE070", VA = "0x185BAF270", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2B93940", Offset = "0x2B92740", VA = "0x182B93940")]
			private Enumerator([In] UnsafeList<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5BB1050", Offset = "0x5BAFE50", VA = "0x185BB1050")]
			public static Enumerator New([In] SOAId32<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5BAF910", Offset = "0x5BAE710", VA = "0x185BAF910", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2E57840", Offset = "0x2E56640", VA = "0x182E57840", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public sealed class FOHLCOITXVI
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
		[Cpp2IlInjected.Address(RVA = "0x78B92A0", Offset = "0x78B80A0", VA = "0x1878B92A0")]
		internal SOAId32(UnsafeList<ulong> used, UnsafeList<Id32<M>> free, Id32<M> next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x78B7EF0", Offset = "0x78B6CF0", VA = "0x1878B7EF0")]
		public static SOAId32<M> New()
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x78B7320", Offset = "0x78B6120", VA = "0x1878B7320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x78B84A0", Offset = "0x78B72A0", VA = "0x1878B84A0")]
		public Id32<M> SZXCONVJSCU()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x78B8360", Offset = "0x78B7160", VA = "0x1878B8360")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x78B7AB0", Offset = "0x78B68B0", VA = "0x1878B7AB0")]
		public readonly VOKKKUFXOEW NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCF75E0", Offset = "0xCF63E0", VA = "0x180CF75E0")]
		public readonly Id32<M> BUTMIEWMRRB()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x78B80F0", Offset = "0x78B6EF0", VA = "0x1878B80F0")]
		public readonly bool PBWCOQDYWXL(Id32<M> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x78B7060", Offset = "0x78B5E60", VA = "0x1878B7060")]
		public readonly bool AJRBHITXSUS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78B7700", Offset = "0x78B6500", VA = "0x1878B7700")]
		public readonly int MNIKZMVRDAG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x78B71D0", Offset = "0x78B5FD0", VA = "0x1878B71D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x78B7390", Offset = "0x78B6190", VA = "0x1878B7390")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x78B75B0", Offset = "0x78B63B0", VA = "0x1878B75B0")]
		public readonly CopyEnumerable<Id32<M>, Enumerator> LFRDYHFOVCN()
		{
			return default(CopyEnumerable<Id32<M>, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x78B8B10", Offset = "0x78B7910", VA = "0x1878B8B10", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class HNSZWKBMSDY
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B70430", Offset = "0x2B6F230", VA = "0x182B70430")]
		public static (int, ulong) YQBNGXDVFAQ(int a)
		{
			return default((int, ulong));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class OJMBWEVQPNE<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x39F0AE0", Offset = "0x39EF8E0", VA = "0x1839F0AE0")]
		public static SOAId32<b> FHAXXJZUNZF<a>([In] SOAId32<a> self) where a : b
		{
			return default(SOAId32<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerTypeProxy(typeof(SOAId32Field<, >.FOHLCOITXVI))]
	public struct SOAId32Field<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class FOHLCOITXVI
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal SOAId32<M> _soaId32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal SOAField<M, T> _soaField;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78B7010", Offset = "0x78B5E10", VA = "0x1878B7010")]
		internal SOAId32Field([In] SOAId32<M> soaId32, [In] SOAField<M, T> soaField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x78B5790", Offset = "0x78B4590", VA = "0x1878B5790")]
		public static SOAId32Field<M, T> New()
		{
			return default(SOAId32Field<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x78B5600", Offset = "0x78B4400", VA = "0x1878B5600", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x78B69A0", Offset = "0x78B57A0", VA = "0x1878B69A0")]
		public Id32<M> SZXCONVJSCU([In] T obj)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78B61B0", Offset = "0x78B4FB0", VA = "0x1878B61B0")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x78B5C00", Offset = "0x78B4A00", VA = "0x1878B5C00")]
		public void QLACLYUIVFC(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x78B6F90", Offset = "0x78B5D90", VA = "0x1878B6F90", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class VJMZFTRCTSK
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public readonly struct Deserializer<TSerialized, TDeserialized>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly VOKKKUFXOEW _serializedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly RepeatedField<TSerialized> _serialized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Func<TSerialized, TDeserialized> _deserialize;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F2BCE0", Offset = "0x1F2AAE0", VA = "0x181F2BCE0")]
			internal Deserializer(VOKKKUFXOEW serializedIds, RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x37C5410", Offset = "0x37C4210", VA = "0x1837C5410")]
			public SOAId32Field<a, TDeserialized> QVGLLKEPNLO<a>()
			{
				return default(SOAId32Field<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x40C0AC0", Offset = "0x40BF8C0", VA = "0x1840C0AC0")]
		public static VOKKKUFXOEW LMZZNKCMKGC<a, b, c>([In] this SOAId32Field<a, b> self, RepeatedField<c> a, Func<b, c> b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x40C1BB0", Offset = "0x40C09B0", VA = "0x1840C1BB0")]
		public static Deserializer<i, j> ZMMZTQYOOGP<i, j>(this VOKKKUFXOEW a, RepeatedField<i> b, Func<i, j> c)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x40B7A60", Offset = "0x40B6860", VA = "0x1840B7A60")]
		public static void Destroy<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x40C1210", Offset = "0x40C0010", VA = "0x1840C1210")]
		public static string TOAIPHVREMM<l, m>([In] this SOAId32Field<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x40B7A10", Offset = "0x40B6810", VA = "0x1840B7A10")]
		public static void Clear<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E30380", Offset = "0x3E2F180", VA = "0x183E30380")]
		public static SOAId32<bb>.Enumerator TCBAFEHSVEE<bb, bc>([In] this SOAId32Field<bb, bc> self)
		{
			return default(SOAId32<bb>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E30990", Offset = "0x3E2F790", VA = "0x183E30990")]
		public static CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator> ZCAQORDQJEI<bd, be>([In] this SOAId32Field<bd, be> self)
		{
			return default(CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x40C0760", Offset = "0x40BF560", VA = "0x1840C0760")]
		public static T Get<T, M>([In] this SOAId32Field<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x40C0760", Offset = "0x40BF560", VA = "0x1840C0760")]
		public static bg OVGQIVVGLQH<bg, bf>(this SOAId32Field<bf, bg> a, Id32<bf> b)
		{
			return (bg)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x40B7930", Offset = "0x40B6730", VA = "0x1840B7930")]
		public static bi BGZONRYHXQP<bi, bh>([In] this SOAId32Field<bh, bi> self, Id32<bh> a)
		{
			return (bi)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x40C1B40", Offset = "0x40C0940", VA = "0x1840C1B40")]
		public static ConstEnumerable<bw, SOAField<bv, bw>.Enumerator> TWULWXKPJEG<bw, bv>([In] this SOAId32Field<bv, bw> self)
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
		[Cpp2IlInjected.Address(RVA = "0x2B70860", Offset = "0x2B6F660", VA = "0x182B70860")]
		private StopwatchLogScope(string message, [In] ReadOnlyStopwatch stopwatch, [In] LogDelegates logDelegates, bool cachedShouldLog)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B70680", Offset = "0x2B6F480", VA = "0x182B70680", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B70730", Offset = "0x2B6F530", VA = "0x182B70730")]
		public static StopwatchLogScope LSQOCARDJLM(string a, [In] LogDelegates logDelegates, bool b)
		{
			return default(StopwatchLogScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EYHUQQGEUWM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F3A0", Offset = "0x2B6E1A0", VA = "0x182B6F3A0")]
		public static void PRFKKNJHBCA(this Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EF50", Offset = "0x2B6DD50", VA = "0x182B6EF50")]
		public static bool DMRPOXCKUAJ(this Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F050", Offset = "0x2B6DE50", VA = "0x182B6F050")]
		public static void GVGXWTFTIJI(this Stream a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F600", Offset = "0x2B6E400", VA = "0x182B6F600")]
		public static float YNATPPLGGXT(this Stream a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EC50", Offset = "0x2B6DA50", VA = "0x182B6EC50")]
		public static void BJRCNMZBKZH(this Stream a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F5E0", Offset = "0x2B6E3E0", VA = "0x182B6F5E0")]
		public static int YGIOOONRVBE(this Stream a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F0E0", Offset = "0x2B6DEE0", VA = "0x182B6F0E0")]
		public static void IPXBYVZAIAO(this Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F410", Offset = "0x2B6E210", VA = "0x182B6F410")]
		public static long QAUQMGHHPVR(this Stream a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F620", Offset = "0x2B6E420", VA = "0x182B6F620")]
		public static void ZUQIIUYABXP(this Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EF80", Offset = "0x2B6DD80", VA = "0x182B6EF80")]
		public static string FZCCFRHFRYI(this Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EEA0", Offset = "0x2B6DCA0", VA = "0x182B6EEA0")]
		public static void CDUOYOBIDJQ(this Stream a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EED0", Offset = "0x2B6DCD0", VA = "0x182B6EED0")]
		public static void DAXNSEGVQAX(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F1D0", Offset = "0x2B6DFD0", VA = "0x182B6F1D0")]
		public static void LVDPMPOUVSL(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F3E0", Offset = "0x2B6E1E0", VA = "0x182B6F3E0")]
		public static byte PTESRKDPZNF(this Stream a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F2B0", Offset = "0x2B6E0B0", VA = "0x182B6F2B0")]
		public static (byte, byte, byte, byte) MPQVNZWRGRI(this Stream self)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B6ECE0", Offset = "0x2B6DAE0", VA = "0x182B6ECE0")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) BXMTJYWPGZM(this Stream self)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class BSLZLXZKRHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x371A8D0", Offset = "0x37196D0", VA = "0x18371A8D0")]
		public static void LMZZNKCMKGC<a, b>([In] this UnsafeList<a> self, RepeatedField<b> a, Func<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x371B0B0", Offset = "0x3719EB0", VA = "0x18371B0B0")]
		public static void LMZZNKCMKGC<e>([In] this UnsafeList<e> self, RepeatedField<e> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x371A4B0", Offset = "0x37192B0", VA = "0x18371A4B0")]
		public static UnsafeList<i> HGHIJVPDICI<i, h>(this RepeatedField<h> a, Func<h, i> b)
		{
			return default(UnsafeList<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x371A6D0", Offset = "0x37194D0", VA = "0x18371A6D0")]
		public static UnsafeList<k> HGHIJVPDICI<k>(this RepeatedField<k> a)
		{
			return default(UnsafeList<k>);
		}
	}
}
namespace Circuits.Shared.Utilities.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class CXSLLGBXNAU
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x382EFD0", Offset = "0x382DDD0", VA = "0x18382EFD0")]
		public static SOAFieldData<T> YZKJCUPJTLI<T>(this RepeatedField<T> a) where T : notnull
		{
			return default(SOAFieldData<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x382EFD0", Offset = "0x382DDD0", VA = "0x18382EFD0")]
		public static RepeatedId32Field<M> HIJSSMSIJIP<M>(this RepeatedField<int> a) where M : notnull
		{
			return default(RepeatedId32Field<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x382F170", Offset = "0x382DF70", VA = "0x18382F170")]
		internal static void TLJJBWBKLYO<a>(this RepeatedField<a> a, int b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x382F100", Offset = "0x382DF00", VA = "0x18382F100")]
		internal static void TLJJBWBKLYO<b>(this RepeatedField<b> self, int a, b b) where b : struct
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
				[Cpp2IlInjected.Address(RVA = "0x5BB37E0", Offset = "0x5BB25E0", VA = "0x185BB37E0", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x5BAF300", Offset = "0x5BAE100", VA = "0x185BAF300", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5BB2D70", Offset = "0x5BB1B70", VA = "0x185BB2D70")]
			private Enumerator(RepeatedField<int> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x5303780", Offset = "0x5302580", VA = "0x185303780")]
			public static Enumerator New(RepeatedField<int> impl)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5BB0380", Offset = "0x5BAF180", VA = "0x185BB0380", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2B6FB20", Offset = "0x2B6E920", VA = "0x182B6FB20", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RepeatedField<int> _impl;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		internal RepeatedId32Field(RepeatedField<int> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7864A10", Offset = "0x7863810", VA = "0x187864A10")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7864A60", Offset = "0x7863860", VA = "0x187864A60", Slot = "4")]
		private IEnumerator<Id32<M>> NHDWCRSEPTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7864A60", Offset = "0x7863860", VA = "0x187864A60", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
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
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		internal SOAFieldData(RepeatedField<T> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3E42BE0", Offset = "0x3E419E0", VA = "0x183E42BE0")]
		public SOAField<a?, b?> OFNDDMJZMSY<a, b>([In] SOAId32<a> ids, Func<T, b> deserialize)
		{
			return default(SOAField<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E45520", Offset = "0x3E44320", VA = "0x183E45520")]
		public SOAField<c?, d?> WJGPLZPUVOC<c, d>([In] SOAId32<c> ids, Func<T, d> deserialize)
		{
			return default(SOAField<c, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E44D60", Offset = "0x3E43B60", VA = "0x183E44D60")]
		public SOAField<e?, T?> OFNDDMJZMSY<e>([In] SOAId32<e> ids)
		{
			return default(SOAField<e, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E41730", Offset = "0x3E40530", VA = "0x183E41730")]
		public SOAField<f?, g?> ALFPHBNWQCA<f, g>([In] SOAId32<f> ids, Func<Id32<f>, g> deserialize)
		{
			return default(SOAField<f, g>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class TUCVEOXYFPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F59370", Offset = "0x3F58170", VA = "0x183F59370")]
		public static void SZXCONVJSCU<a>(this SOAFieldData<a> self, int a, a b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F592E0", Offset = "0x3F580E0", VA = "0x183F592E0")]
		public static void SZXCONVJSCU<b>(this SOAFieldData<b> a, int b, b c, b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F59110", Offset = "0x3F57F10", VA = "0x183F59110")]
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
			private ZCQCQDPLZYB.Enumerator _impl;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public readonly Id32<M> Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x5BB4050", Offset = "0x5BB2E50", VA = "0x185BB4050", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private readonly object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x5BAF4B0", Offset = "0x5BAE2B0", VA = "0x185BAF4B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x12AF450", Offset = "0x12AE250", VA = "0x1812AF450")]
			private Enumerator([In] ZCQCQDPLZYB.Enumerator impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5BB10B0", Offset = "0x5BAFEB0", VA = "0x185BB10B0")]
			public static Enumerator New([In] SOAId32Data<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5BB0C80", Offset = "0x5BAFA80", VA = "0x185BB0C80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5BB1160", Offset = "0x5BAFF60", VA = "0x185BB1160", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly VOKKKUFXOEW _impl;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		internal SOAId32Data(VOKKKUFXOEW impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x78B5470", Offset = "0x78B4270", VA = "0x1878B5470")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x78B5560", Offset = "0x78B4360", VA = "0x1878B5560", Slot = "4")]
		private IEnumerator<Id32<M>> NHDWCRSEPTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x78B5560", Offset = "0x78B4360", VA = "0x1878B5560", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class ZCQCQDPLZYB
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
				[Cpp2IlInjected.Address(RVA = "0xF43220", Offset = "0xF42020", VA = "0x180F43220", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x2B6F800", Offset = "0x2B6E600", VA = "0x182B6F800", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2B6FB70", Offset = "0x2B6E970", VA = "0x182B6FB70")]
			private Enumerator([In] RepeatedField<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2B6FAE0", Offset = "0x2B6E8E0", VA = "0x182B6FAE0")]
			public static Enumerator New([In] VOKKKUFXOEW self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2B6F8D0", Offset = "0x2B6E6D0", VA = "0x182B6F8D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2B6FB20", Offset = "0x2B6E920", VA = "0x182B6FB20", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x411EE50", Offset = "0x411DC50", VA = "0x18411EE50")]
		public static SOAId32<M> OFNDDMJZMSY<M>(this VOKKKUFXOEW a) where M : notnull
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B709D0", Offset = "0x2B6F7D0", VA = "0x182B709D0")]
		public static bool PBWCOQDYWXL(this VOKKKUFXOEW a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B70C20", Offset = "0x2B6FA20", VA = "0x182B70C20")]
		public static int SZXCONVJSCU(this VOKKKUFXOEW a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B70AE0", Offset = "0x2B6F8E0", VA = "0x182B70AE0")]
		public static void Release(this VOKKKUFXOEW self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x382EFD0", Offset = "0x382DDD0", VA = "0x18382EFD0")]
		public static SOAId32Data<M> HIJSSMSIJIP<M>(this VOKKKUFXOEW a) where M : notnull
		{
			return default(SOAId32Data<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B708E0", Offset = "0x2B6F6E0", VA = "0x182B708E0")]
		public static Enumerator GetEnumerator(this VOKKKUFXOEW self)
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B70930", Offset = "0x2B6F730", VA = "0x182B70930")]
		public static CopyEnumerable<int, Enumerator> LFRDYHFOVCN(this VOKKKUFXOEW self)
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
