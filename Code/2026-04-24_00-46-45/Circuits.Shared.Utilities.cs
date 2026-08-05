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
		[Cpp2IlInjected.Address(RVA = "0x2BAE700", Offset = "0x2BAD100", VA = "0x182BAE700")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class PFWCKPAIQVO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEE20", Offset = "0x2BAD820", VA = "0x182BAEE20")]
		private static string XTSPAKEZHNZ(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEA80", Offset = "0x2BAD480", VA = "0x182BAEA80")]
		public static string OXMGMDZTHHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEA50", Offset = "0x2BAD450", VA = "0x182BAEA50")]
		public static string NIQKEQVJCJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E590", Offset = "0x3D9CF90", VA = "0x183D9E590")]
		public static string PURWYKWIMSN<a>([In] a actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE910", Offset = "0x2BAD310", VA = "0x182BAE910")]
		public static string JZZEYCBTVQY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C9E0", Offset = "0x3D9B3E0", VA = "0x183D9C9E0")]
		public static string ABFBSCEGIYV<b, c>([In] b expected, [In] c actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D820", Offset = "0x3D9C220", VA = "0x183D9D820")]
		public static string LLAWZZIUMHG<d, e>([In] d notExpected, [In] e actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEDD0", Offset = "0x2BAD7D0", VA = "0x182BAEDD0")]
		public static string XLSBEAISHFO(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEF90", Offset = "0x2BAD990", VA = "0x182BAEF90")]
		public static string XTXYDKYROXC(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAED90", Offset = "0x2BAD790", VA = "0x182BAED90")]
		public static string WVRJGPUDDBP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE8D0", Offset = "0x2BAD2D0", VA = "0x182BAE8D0")]
		public static string JABYJNSDVDE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D1E0", Offset = "0x3D9BBE0", VA = "0x183D9D1E0")]
		public static string BGTTLNBZJPS<dg>(string a, [In] dg actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE940", Offset = "0x2BAD340", VA = "0x182BAE940")]
		public static string KHNNIMKSPZH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D990", Offset = "0x3D9C390", VA = "0x183D9D990")]
		public static string LOESTNOAOLK<dh, di>(string a, [In] dh expected, [In] di actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E270", Offset = "0x3D9CC70", VA = "0x183D9E270")]
		public static string OBSUBUHKFZH<dj, dk>(string a, [In] dj notExpected, [In] dk actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE980", Offset = "0x2BAD380", VA = "0x182BAE980")]
		public static void KKHNKUJHRSB(this LogDelegate a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE780", Offset = "0x2BAD180", VA = "0x182BAE780")]
		public static bool FLMYVEZKKKP([In] this LogDelegates log, [Optional] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BAECC0", Offset = "0x2BAD6C0", VA = "0x182BAECC0")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEBE0", Offset = "0x2BAD5E0", VA = "0x182BAEBE0")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Out] LogDelegate err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE800", Offset = "0x2BAD200", VA = "0x182BAE800")]
		public static bool GDTCZORZCHM([In] this LogDelegates log, bool a, [Optional] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D430", Offset = "0x3D9BE30", VA = "0x183D9D430")]
		public static bool GDTCZORZCHM<ic>([In] this LogDelegates log, bool a, ic b, FastestMessageFunc<ic> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E620", Offset = "0x3D9D020", VA = "0x183D9E620")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T expected, U actual, [Optional] string message) where T : IEquatable<U>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEAF0", Offset = "0x2BAD4F0", VA = "0x182BAEAF0")]
		public static bool VerifyAreNotEqual([In] this LogDelegates log, object notExpected, object actual, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E9B0", Offset = "0x3D9D3B0", VA = "0x183D9E9B0")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, [In] T actual, [Optional] string message) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEA20", Offset = "0x2BAD420", VA = "0x182BAEA20")]
		public static PerfScopeToken MSYABPIEJBW([In] this PerfScopeDelegates self, [Optional][CallerMemberName] string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEAB0", Offset = "0x2BAD4B0", VA = "0x182BAEAB0")]
		public static PerfScopeToken TOUILPXUOXD([In] this PerfScopeDelegates self, Func<string> a)
		{
			return default(PerfScopeToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HRCOEZMORSQ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B241B0", Offset = "0x3B22BB0", VA = "0x183B241B0")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3B24330", Offset = "0x3B22D30", VA = "0x183B24330")]
		public static bool VerifyIsNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B23EA0", Offset = "0x3B228A0", VA = "0x183B23EA0")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T? expected, U? actual, [Optional] string message, [Optional] string isNotNullMessage, [Optional] string isNullMessage) where T : struct, IEquatable<U> where U : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerTypeProxy(typeof(IdUnsafeList<, >.SJHIZCQUPAH))]
	public struct IdUnsafeList<M, T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public sealed class SJHIZCQUPAH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal UnsafeList<T> _unsafeList;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
		internal IdUnsafeList([In] UnsafeList<T> unsafeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x660D890", Offset = "0x660C290", VA = "0x18660D890")]
		public static IdUnsafeList<M, T> New()
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x660E180", Offset = "0x660CB80", VA = "0x18660E180")]
		public static IdUnsafeList<M, T> YDUAXTAHNPC(int a)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x660E100", Offset = "0x660CB00", VA = "0x18660E100", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CVFDWPVFIOJ
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
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			internal Deserializer(RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x38117F0", Offset = "0x38101F0", VA = "0x1838117F0")]
			public IdUnsafeList<a, TDeserialized> NQLWDRPWWFN<a>()
			{
				return default(IdUnsafeList<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x386D7A0", Offset = "0x386C1A0", VA = "0x18386D7A0")]
		public static void YEZMFCLDVEZ<a, b, c>([In] this IdUnsafeList<a, b> self, RepeatedField<c> a, Func<b, c> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x386EC00", Offset = "0x386D600", VA = "0x18386EC00")]
		public static Deserializer<i, j> YWGEQOLOIRI<i, j>(this RepeatedField<i> a, Func<i, j> b)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x386B000", Offset = "0x3869A00", VA = "0x18386B000")]
		public static void Destroy<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x386BB50", Offset = "0x386A550", VA = "0x18386BB50")]
		public static string HZFIIBDKWMV<n, o>([In] this IdUnsafeList<n, o> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static UnsafeList<y> LOIDBZKYTBO<y, x>([In] this IdUnsafeList<x, y> self)
		{
			return default(UnsafeList<y>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x386B4B0", Offset = "0x3869EB0", VA = "0x18386B4B0")]
		public static T Get<T, M>([In] this IdUnsafeList<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x386B500", Offset = "0x3869F00", VA = "0x18386B500")]
		public static ba TBLSZXWCOGY<ba, z>(this IdUnsafeList<z, ba> a, Id32<z> b)
		{
			return (ba)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x386DE50", Offset = "0x386C850", VA = "0x18386DE50")]
		public static bc YFFUWJVFPRK<bc, bb>([In] this IdUnsafeList<bb, bc> self, Id32<bb> a)
		{
			return (bc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x386CE60", Offset = "0x386B860", VA = "0x18386CE60")]
		public static void Set<M, T>(this IdUnsafeList<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x386CE60", Offset = "0x386B860", VA = "0x18386CE60")]
		public static void YRLDDFPOHEY<bd, be>(this IdUnsafeList<bd, be> a, Id32<bd> b, be c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x386D410", Offset = "0x386BE10", VA = "0x18386D410")]
		public static int XAVQJSXVKBX<bh, bi>([In] this IdUnsafeList<bh, bi> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x386B090", Offset = "0x3869A90", VA = "0x18386B090")]
		public static Id32<bl> EDKBKRKJFFZ<bl, bm>([In] this IdUnsafeList<bl, bm> self)
		{
			return default(Id32<bl>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x386C9B0", Offset = "0x386B3B0", VA = "0x18386C9B0")]
		public static bo SGXTQBVTAEO<bo, bn>([In] this IdUnsafeList<bn, bo> self)
		{
			return (bo)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x386C910", Offset = "0x386B310", VA = "0x18386C910")]
		public static ReadOnlyIdArray<bt, bu> NHWZTCOMKPK<bt, bu>(this IdUnsafeList<bt, bu> a)
		{
			return default(ReadOnlyIdArray<bt, bu>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x386AB10", Offset = "0x3869510", VA = "0x18386AB10")]
		public static Id32<M> Add<M, T>(this IdUnsafeList<M, T> self, [In] T item)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x386E380", Offset = "0x386CD80", VA = "0x18386E380")]
		public static Id32<bv> YNQAKNAMKZD<bv, bw>(this IdUnsafeList<bv, bw> a, bw b)
		{
			return default(Id32<bv>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x386C030", Offset = "0x386AA30", VA = "0x18386C030")]
		public static void Insert<M, T>(this IdUnsafeList<M, T> self, int index, [In] T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x386D3C0", Offset = "0x386BDC0", VA = "0x18386D3C0")]
		public static void VDAZNXZCGLJ<bx, by>(this IdUnsafeList<bx, by> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x386C400", Offset = "0x386AE00", VA = "0x18386C400")]
		public static void LFNLYEGAJCB<bz, ca>(this IdUnsafeList<bz, ca> a, Id32<bz> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x386AE10", Offset = "0x3869810", VA = "0x18386AE10")]
		public static void Clear<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x386AEE0", Offset = "0x38698E0", VA = "0x18386AEE0")]
		public static IdUnsafeList<M, T> Clone<M, T>([In] this IdUnsafeList<M, T> self, InFunc<T, T> cloneItem)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x386EC70", Offset = "0x386D670", VA = "0x18386EC70")]
		public static Id32Enumerator<ch> ZHDGKEHBZMF<ch, ci>([In] this IdUnsafeList<ch, ci> self)
		{
			return default(Id32Enumerator<ch>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x386B3B0", Offset = "0x3869DB0", VA = "0x18386B3B0")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T, M>([In] this IdUnsafeList<M, T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x386C7C0", Offset = "0x386B1C0", VA = "0x18386C7C0")]
		public static UnsafeList<ck>.MutEnumerator MEWAPICAMGS<ck, cj>(this IdUnsafeList<cj, ck> a)
		{
			return default(UnsafeList<ck>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x386B170", Offset = "0x3869B70", VA = "0x18386B170")]
		public static CopyEnumerable<Id32<cl>, Id32Enumerator<cl>> EMBKTXLKDZD<cl, cm>([In] this IdUnsafeList<cl, cm> self)
		{
			return default(CopyEnumerable<Id32<cl>, Id32Enumerator<cl>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x386C9F0", Offset = "0x386B3F0", VA = "0x18386C9F0")]
		public static ConstEnumerable<co, UnsafeList<co>.Enumerator> SXJZHXIMNGQ<co, cn>([In] this IdUnsafeList<cn, co> self)
		{
			return default(ConstEnumerable<co, UnsafeList<co>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x386B2B0", Offset = "0x3869CB0", VA = "0x18386B2B0")]
		public static MutEnumerable<cq, UnsafeList<cq>.MutEnumerator> GXSERPFBOCC<cq, cp>(this IdUnsafeList<cp, cq> a)
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
		[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
		internal LinearIdAllocator32(int next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x691D730", Offset = "0x691C130", VA = "0x18691D730")]
		public static LinearIdAllocator32<M> New()
		{
			return default(LinearIdAllocator32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x691D830", Offset = "0x691C230", VA = "0x18691D830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class PHECLOKIZTU
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EA60", Offset = "0x3D9D460", VA = "0x183D9EA60")]
		public static void Clear<M>(this LinearIdAllocator32<M> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EAC0", Offset = "0x3D9D4C0", VA = "0x183D9EAC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x660CD80", Offset = "0x660B780", VA = "0x18660CD80", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x660CB10", Offset = "0x660B510", VA = "0x18660CB10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x660CC50", Offset = "0x660B650", VA = "0x18660CC50")]
			private IdEnumerator(Dictionary<Id32<M>, Id32<M>> gcToLinear, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x660C8B0", Offset = "0x660B2B0", VA = "0x18660C8B0")]
			public static IdEnumerator New(LinearObjAllocator32<M, T> self)
			{
				return default(IdEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x660C870", Offset = "0x660B270", VA = "0x18660C870", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x660CC10", Offset = "0x660B610", VA = "0x18660CC10", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x691DD50", Offset = "0x691C750", VA = "0x18691DD50")]
		private LinearObjAllocator32([In] SOAId32Field<M, T> gcObjAllocator, Dictionary<Id32<M>, Id32<M>> linearToGC, Dictionary<Id32<M>, Id32<M>> gcToLinear, LinearIdAllocator32<M> linearIdAllocator32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x691D8F0", Offset = "0x691C2F0", VA = "0x18691D8F0")]
		public static LinearObjAllocator32<M, T> New()
		{
			return default(LinearObjAllocator32<M, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GXTRRSPDLAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3B0FFE0", Offset = "0x3B0E9E0", VA = "0x183B0FFE0")]
		public static T Get<T, M>([In] this LinearObjAllocator32<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3B0FD50", Offset = "0x3B0E750", VA = "0x183B0FD50")]
		public static void Destroy<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3B10300", Offset = "0x3B0ED00", VA = "0x183B10300")]
		public static Id32<e> TNFSOTFAQBJ<e, f>(this LinearObjAllocator32<e, f> a, [In] f obj)
		{
			return default(Id32<e>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3B10170", Offset = "0x3B0EB70", VA = "0x183B10170")]
		public static void Release<M, T>(this LinearObjAllocator32<M, T> self, Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3B0FB80", Offset = "0x3B0E580", VA = "0x183B0FB80")]
		public static void Clear<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3B10450", Offset = "0x3B0EE50", VA = "0x183B10450")]
		public static LinearObjAllocator32<n, o>.IdEnumerator ZHDGKEHBZMF<n, o>([In] this LinearObjAllocator32<n, o> self)
		{
			return default(LinearObjAllocator32<n, o>.IdEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3B0FE60", Offset = "0x3B0E860", VA = "0x183B0FE60")]
		public static CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator> EMBKTXLKDZD<t, u>([In] this LinearObjAllocator32<t, u> self)
		{
			return default(CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MultiResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct Enumerator : LBNSNSASDAU<Result<object, CBUCXYTAOGI>>, LAOQERQLANP<Result<object, CBUCXYTAOGI>>, IEnumerator<Result<object, CBUCXYTAOGI>>, IEnumerator, IDisposable, ULTYGGNROTW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private readonly Result<object, CBUCXYTAOGI>[] _results;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public readonly int DJHUXMLNUTX
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2BAE090", Offset = "0x2BACA90", VA = "0x182BAE090", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public readonly Result<object, CBUCXYTAOGI> Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2BADCE0", Offset = "0x2BAC6E0", VA = "0x182BADCE0", Slot = "11")]
				get
				{
					return default(Result<object, CBUCXYTAOGI>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private readonly Result<object, CBUCXYTAOGI> CPHNXSIWIVW
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2BADCE0", Offset = "0x2BAC6E0", VA = "0x182BADCE0", Slot = "4")]
				get
				{
					return default(Result<object, CBUCXYTAOGI>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private readonly Result<object, CBUCXYTAOGI> PQLACDXKNAU
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2BADD20", Offset = "0x2BAC720", VA = "0x182BADD20", Slot = "5")]
				get
				{
					return default(Result<object, CBUCXYTAOGI>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2BADFE0", Offset = "0x2BAC9E0", VA = "0x182BADFE0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
			private Enumerator(Result<object, CBUCXYTAOGI>[] results, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2BADFB0", Offset = "0x2BAC9B0", VA = "0x182BADFB0")]
			public static Enumerator New(Result<object, CBUCXYTAOGI>[] results)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2BADD60", Offset = "0x2BAC760", VA = "0x182BADD60", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE080", Offset = "0x2BACA80", VA = "0x182BAE080", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly Result<object, CBUCXYTAOGI>[] _results;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Result<object, CBUCXYTAOGI> this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE6C0", Offset = "0x2BAD0C0", VA = "0x182BAE6C0")]
			get
			{
				return default(Result<object, CBUCXYTAOGI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static MultiResult XYCVWQEIWWP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE620", Offset = "0x2BAD020", VA = "0x182BAE620")]
			get
			{
				return default(MultiResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		internal MultiResult(Result<object, CBUCXYTAOGI>[] results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x111A6A0", Offset = "0x11190A0", VA = "0x18111A6A0")]
		public static MultiResult New(Result<object, CBUCXYTAOGI>[] results)
		{
			return default(MultiResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE5E0", Offset = "0x2BACFE0", VA = "0x182BAE5E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DebuggerTypeProxy(typeof(SOAField<, >.SJHIZCQUPAH))]
	public struct SOAField<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct MutEnumerator : LBNSNSASDAU<T>, LAOQERQLANP<T>, IEnumerator<T>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7147120", Offset = "0x7145B20", VA = "0x187147120", Slot = "10")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public readonly T IWCYQTZYSBI
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x7145CF0", Offset = "0x71446F0", VA = "0x187145CF0")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private readonly T PCAZCRRNXAR
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x7146E50", Offset = "0x7145850", VA = "0x187146E50", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private readonly T KCZFSMOPHDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x7145720", Offset = "0x7144120", VA = "0x187145720", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x7146620", Offset = "0x7145020", VA = "0x187146620", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7146ED0", Offset = "0x71458D0", VA = "0x187146ED0")]
			internal MutEnumerator([In] IdUnsafeList<M, T> objects, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x71462A0", Offset = "0x7144CA0", VA = "0x1871462A0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7146AF0", Offset = "0x71454F0", VA = "0x187146AF0", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct Enumerator : LAOQERQLANP<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x5C8A180", Offset = "0x5C88B80", VA = "0x185C8A180", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly T KCZFSMOPHDD
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x5C86BB0", Offset = "0x5C855B0", VA = "0x185C86BB0", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x5C86BB0", Offset = "0x5C855B0", VA = "0x185C86BB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x535E4B0", Offset = "0x535CEB0", VA = "0x18535E4B0")]
			internal Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5C86EC0", Offset = "0x5C858C0", VA = "0x185C86EC0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5C872F0", Offset = "0x5C85CF0", VA = "0x185C872F0", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5C86A40", Offset = "0x5C85440", VA = "0x185C86A40", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public sealed class SJHIZCQUPAH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal IdUnsafeList<M, T> _objects;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
		internal SOAField([In] IdUnsafeList<M, T> objects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78F4FF0", Offset = "0x78F39F0", VA = "0x1878F4FF0")]
		public static SOAField<M, T> New()
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x78F6170", Offset = "0x78F4B70", VA = "0x1878F6170")]
		public static SOAField<M, T> YDUAXTAHNPC(int a)
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x78F4FB0", Offset = "0x78F39B0", VA = "0x1878F4FB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x78F5790", Offset = "0x78F4190", VA = "0x1878F5790")]
		public void TNFSOTFAQBJ(Id32<M> a, [In] T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x78F6C00", Offset = "0x78F5600", VA = "0x1878F6C00")]
		public void YUELKQHMFFV(Id32<M> a, T b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x78F5350", Offset = "0x78F3D50", VA = "0x1878F5350")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78F6ED0", Offset = "0x78F58D0", VA = "0x1878F6ED0")]
		public void ZDMVHNTNPLV(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x78F5FF0", Offset = "0x78F49F0", VA = "0x1878F5FF0", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class HMWJESXGJTT
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3B21B50", Offset = "0x3B20550", VA = "0x183B21B50")]
		public static void YEZMFCLDVEZ<a, b, c>([In] this SOAField<a, b> self, [In] SOAId32<a> ids, RepeatedField<c> a, Func<b, c> b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3B231E0", Offset = "0x3B21BE0", VA = "0x183B231E0")]
		public static void YEZMFCLDVEZ<d, e, f>([In] this SOAField<d, e> self, [In] SOAId32<d> ids, RepeatedField<f> a, InFunc<e, f> b, f c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3B22B30", Offset = "0x3B21530", VA = "0x183B22B30")]
		public static void YEZMFCLDVEZ<g, h>([In] this SOAField<g, h> self, [In] SOAId32<g> ids, RepeatedField<h> a, h b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3B20650", Offset = "0x3B1F050", VA = "0x183B20650")]
		public static void HZZHONMLEQJ<i, j, k>([In] this SOAField<i, j> self, [In] SOAId32<i> ids, RepeatedField<k> a, Func<Id32<i>, k> b, k c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F4C0", Offset = "0x3B1DEC0", VA = "0x183B1F4C0")]
		public static void Destroy<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3B1FEF0", Offset = "0x3B1E8F0", VA = "0x183B1FEF0")]
		public static string HZFIIBDKWMV<l, m>([In] this SOAField<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9E60", Offset = "0x2BC8860", VA = "0x182BC9E60")]
		public static T Get<T, M>([In] this SOAField<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2D23AB0", Offset = "0x2D224B0", VA = "0x182D23AB0")]
		public static o TBLSZXWCOGY<o, n>(this SOAField<n, o> a, Id32<n> b)
		{
			return (o)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3B23560", Offset = "0x3B21F60", VA = "0x183B23560")]
		public static q YFFUWJVFPRK<q, p>([In] this SOAField<p, q> self, Id32<p> a)
		{
			return (q)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2D639F0", Offset = "0x2D623F0", VA = "0x182D639F0")]
		public static void Set<M, T>(this SOAField<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE1E0", Offset = "0x2BBCBE0", VA = "0x182BBE1E0")]
		public static void YRLDDFPOHEY<r, s>(this SOAField<r, s> a, Id32<r> b, s c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3B20DC0", Offset = "0x3B1F7C0", VA = "0x183B20DC0")]
		public static ReadOnlyIdSpan<v, w> VLLIURZGWOJ<v, w>([In] this SOAField<v, w> self)
		{
			return default(ReadOnlyIdSpan<v, w>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3B20CE0", Offset = "0x3B1F6E0", VA = "0x183B20CE0")]
		public static int UPHRFJUKUVR<x, y>([In] this SOAField<x, y> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F480", Offset = "0x3B1DE80", VA = "0x183B1F480")]
		public static void Clear<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3B20A00", Offset = "0x3B1F400", VA = "0x183B20A00")]
		public static bool QRQFIYVPMIW<z, ba>([In] this SOAField<z, ba> self, Id32<z> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F840", Offset = "0x3B1E240", VA = "0x183B1F840")]
		public static SOAField<M, T>.Enumerator GetEnumerator<M, T>([In] this SOAField<M, T> self, [In] SOAId32<M> ids)
		{
			return default(SOAField<M, T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3B20910", Offset = "0x3B1F310", VA = "0x183B20910")]
		public static SOAField<bd, be>.MutEnumerator MEWAPICAMGS<bd, be>(this SOAField<bd, be> a, [In] SOAId32<bd> ids)
		{
			return default(SOAField<bd, be>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3B20A70", Offset = "0x3B1F470", VA = "0x183B20A70")]
		public static ConstEnumerable<bi, SOAField<bh, bi>.Enumerator> SXJZHXIMNGQ<bi, bh>([In] this SOAField<bh, bi> self, [In] SOAId32<bh> ids)
		{
			return default(ConstEnumerable<bi, SOAField<bh, bi>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F600", Offset = "0x3B1E000", VA = "0x183B1F600")]
		public static MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator> GXSERPFBOCC<bm, bl>(this SOAField<bl, bm> a, [In] SOAId32<bl> ids)
		{
			return default(MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DebuggerTypeProxy(typeof(SOAId32<>.SJHIZCQUPAH))]
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
				[Cpp2IlInjected.Address(RVA = "0x5BF9CA0", Offset = "0x5BF86A0", VA = "0x185BF9CA0", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x5BF6E70", Offset = "0x5BF5870", VA = "0x185BF6E70", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2BD36C0", Offset = "0x2BD20C0", VA = "0x182BD36C0")]
			private Enumerator([In] UnsafeList<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6B40", Offset = "0x5BF5540", VA = "0x185BF6B40")]
			public static Enumerator New([In] SOAId32<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5BF53E0", Offset = "0x5BF3DE0", VA = "0x185BF53E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2EAEDE0", Offset = "0x2EAD7E0", VA = "0x182EAEDE0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public sealed class SJHIZCQUPAH
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
		[Cpp2IlInjected.Address(RVA = "0x78FD410", Offset = "0x78FBE10", VA = "0x1878FD410")]
		internal SOAId32(UnsafeList<ulong> used, UnsafeList<Id32<M>> free, Id32<M> next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x78FBD10", Offset = "0x78FA710", VA = "0x1878FBD10")]
		public static SOAId32<M> New()
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x78FB390", Offset = "0x78F9D90", VA = "0x1878FB390", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x78FC4F0", Offset = "0x78FAEF0", VA = "0x1878FC4F0")]
		public Id32<M> TNFSOTFAQBJ()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x78FC190", Offset = "0x78FAB90", VA = "0x1878FC190")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x78FB510", Offset = "0x78F9F10", VA = "0x1878FB510")]
		public readonly LDUQGPSPOOD NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0")]
		public readonly Id32<M> ZIFUDCWQFUW()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x78FBE00", Offset = "0x78FA800", VA = "0x1878FBE00")]
		public readonly bool QRQFIYVPMIW(Id32<M> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x78FB270", Offset = "0x78F9C70", VA = "0x1878FB270")]
		public readonly bool DFPZNIZKTBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x78FD3D0", Offset = "0x78FBDD0", VA = "0x1878FD3D0")]
		public readonly int XAVQJSXVKBX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x78FB1C0", Offset = "0x78F9BC0", VA = "0x1878FB1C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x78FB400", Offset = "0x78F9E00", VA = "0x1878FB400")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x78FC2E0", Offset = "0x78FACE0", VA = "0x1878FC2E0")]
		public readonly CopyEnumerable<Id32<M>, Enumerator> SXJZHXIMNGQ()
		{
			return default(CopyEnumerable<Id32<M>, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x78FCB80", Offset = "0x78FB580", VA = "0x1878FCB80", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class WIUHDSLSETZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFDC0", Offset = "0x2BAE7C0", VA = "0x182BAFDC0")]
		public static (int, ulong) JMKLVHSAOSN(int a)
		{
			return default((int, ulong));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class WFBTLPQXGXH<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x41C5A60", Offset = "0x41C4460", VA = "0x1841C5A60")]
		public static SOAId32<b> VXNEKBAWKSQ<a>([In] SOAId32<a> self) where a : b
		{
			return default(SOAId32<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerTypeProxy(typeof(SOAId32Field<, >.SJHIZCQUPAH))]
	public struct SOAId32Field<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class SJHIZCQUPAH
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal SOAId32<M> _soaId32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal SOAField<M, T> _soaField;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78FB070", Offset = "0x78F9A70", VA = "0x1878FB070")]
		internal SOAId32Field([In] SOAId32<M> soaId32, [In] SOAField<M, T> soaField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x78F9190", Offset = "0x78F7B90", VA = "0x1878F9190")]
		public static SOAId32Field<M, T> New()
		{
			return default(SOAId32Field<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x78F8EB0", Offset = "0x78F78B0", VA = "0x1878F8EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x78F9DC0", Offset = "0x78F87C0", VA = "0x1878F9DC0")]
		public Id32<M> TNFSOTFAQBJ([In] T obj)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78F9B40", Offset = "0x78F8540", VA = "0x1878F9B40")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x78FAC20", Offset = "0x78F9620", VA = "0x1878FAC20")]
		public void ZDMVHNTNPLV(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x78FA6D0", Offset = "0x78F90D0", VA = "0x1878FA6D0", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class CVCZLXOTALT
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public readonly struct Deserializer<TSerialized, TDeserialized>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly LDUQGPSPOOD _serializedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly RepeatedField<TSerialized> _serialized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Func<TSerialized, TDeserialized> _deserialize;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F64830", Offset = "0x1F63230", VA = "0x181F64830")]
			internal Deserializer(LDUQGPSPOOD serializedIds, RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3810FA0", Offset = "0x380F9A0", VA = "0x183810FA0")]
			public SOAId32Field<a, TDeserialized> NQLWDRPWWFN<a>()
			{
				return default(SOAId32Field<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x386A3D0", Offset = "0x3868DD0", VA = "0x18386A3D0")]
		public static LDUQGPSPOOD YEZMFCLDVEZ<a, b, c>([In] this SOAId32Field<a, b> self, RepeatedField<c> a, Func<b, c> b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x386A220", Offset = "0x3868C20", VA = "0x18386A220")]
		public static Deserializer<i, j> UNVXPFPIGPA<i, j>(this LDUQGPSPOOD a, RepeatedField<i> b, Func<i, j> c)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3868F20", Offset = "0x3867920", VA = "0x183868F20")]
		public static void Destroy<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3869880", Offset = "0x3868280", VA = "0x183869880")]
		public static string HZFIIBDKWMV<l, m>([In] this SOAId32Field<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3868E80", Offset = "0x3867880", VA = "0x183868E80")]
		public static void Clear<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x386A770", Offset = "0x3869170", VA = "0x18386A770")]
		public static SOAId32<bb>.Enumerator ZHDGKEHBZMF<bb, bc>([In] this SOAId32Field<bb, bc> self)
		{
			return default(SOAId32<bb>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3868FE0", Offset = "0x38679E0", VA = "0x183868FE0")]
		public static CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator> EMBKTXLKDZD<bd, be>([In] this SOAId32Field<bd, be> self)
		{
			return default(CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3869130", Offset = "0x3867B30", VA = "0x183869130")]
		public static T Get<T, M>([In] this SOAId32Field<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x38690A0", Offset = "0x3867AA0", VA = "0x1838690A0")]
		public static bg TBLSZXWCOGY<bg, bf>(this SOAId32Field<bf, bg> a, Id32<bf> b)
		{
			return (bg)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x386A6E0", Offset = "0x38690E0", VA = "0x18386A6E0")]
		public static bi YFFUWJVFPRK<bi, bh>([In] this SOAId32Field<bh, bi> self, Id32<bh> a)
		{
			return (bi)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x386A1B0", Offset = "0x3868BB0", VA = "0x18386A1B0")]
		public static ConstEnumerable<bw, SOAField<bv, bw>.Enumerator> PUEMIDWNSSJ<bw, bv>([In] this SOAId32Field<bv, bw> self)
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
		[Cpp2IlInjected.Address(RVA = "0x2BAF1F0", Offset = "0x2BADBF0", VA = "0x182BAF1F0")]
		private StopwatchLogScope(string message, [In] ReadOnlyStopwatch stopwatch, [In] LogDelegates logDelegates, bool cachedShouldLog)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF010", Offset = "0x2BADA10", VA = "0x182BAF010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF0C0", Offset = "0x2BADAC0", VA = "0x182BAF0C0")]
		public static StopwatchLogScope NOBAAEZHIMH(string a, [In] LogDelegates logDelegates, bool b)
		{
			return default(StopwatchLogScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class VPKMLCHWXLT
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFBC0", Offset = "0x2BAE5C0", VA = "0x182BAFBC0")]
		public static void XLXRZBRDODL(this Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF670", Offset = "0x2BAE070", VA = "0x182BAF670")]
		public static bool PLRWEWFAWOW(this Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF830", Offset = "0x2BAE230", VA = "0x182BAF830")]
		public static void VCJYWFCDLPH(this Stream a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF9B0", Offset = "0x2BAE3B0", VA = "0x182BAF9B0")]
		public static float VLJXAOCXEWI(this Stream a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF6A0", Offset = "0x2BAE0A0", VA = "0x182BAF6A0")]
		public static void SDTPDVGJMCO(this Stream a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFBA0", Offset = "0x2BAE5A0", VA = "0x182BAFBA0")]
		public static int WVVMIIJEWWD(this Stream a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF8C0", Offset = "0x2BAE2C0", VA = "0x182BAF8C0")]
		public static void VIBKHMVZNSH(this Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF9D0", Offset = "0x2BAE3D0", VA = "0x182BAF9D0")]
		public static long WQXJSNUAZMU(this Stream a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF3E0", Offset = "0x2BADDE0", VA = "0x182BAF3E0")]
		public static void IWKWHQNHCTG(this Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF760", Offset = "0x2BAE160", VA = "0x182BAF760")]
		public static string UAXORWQATJB(this Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF560", Offset = "0x2BADF60", VA = "0x182BAF560")]
		public static void KQCCDCLQWLN(this Stream a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF270", Offset = "0x2BADC70", VA = "0x182BAF270")]
		public static void FLWYPWPHPLQ(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF590", Offset = "0x2BADF90", VA = "0x182BAF590")]
		public static void OVRFJXXMBLE(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF730", Offset = "0x2BAE130", VA = "0x182BAF730")]
		public static byte TJAYLSEVOVS(this Stream a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF2F0", Offset = "0x2BADCF0", VA = "0x182BAF2F0")]
		public static (byte, byte, byte, byte) HMCYTBDXQDH(this Stream self)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFC00", Offset = "0x2BAE600", VA = "0x182BAFC00")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) ZMVNHRWSKTT(this Stream self)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class WZZIMTTTBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x411BE60", Offset = "0x411A860", VA = "0x18411BE60")]
		public static void YEZMFCLDVEZ<a, b>([In] this UnsafeList<a> self, RepeatedField<b> a, Func<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x411C2E0", Offset = "0x411ACE0", VA = "0x18411C2E0")]
		public static void YEZMFCLDVEZ<e>([In] this UnsafeList<e> self, RepeatedField<e> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x411BA40", Offset = "0x411A440", VA = "0x18411BA40")]
		public static UnsafeList<i> UJEAHNENBUD<i, h>(this RepeatedField<h> a, Func<h, i> b)
		{
			return default(UnsafeList<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x411BC60", Offset = "0x411A660", VA = "0x18411BC60")]
		public static UnsafeList<k> UJEAHNENBUD<k>(this RepeatedField<k> a)
		{
			return default(UnsafeList<k>);
		}
	}
}
namespace Circuits.Shared.Utilities.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class TMEEHAIJCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x339F520", Offset = "0x339DF20", VA = "0x18339F520")]
		public static SOAFieldData<T> OKRBMXVPJUV<T>(this RepeatedField<T> a) where T : notnull
		{
			return default(SOAFieldData<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x339F520", Offset = "0x339DF20", VA = "0x18339F520")]
		public static RepeatedId32Field<M> OPEYQFTCYIA<M>(this RepeatedField<int> a) where M : notnull
		{
			return default(RepeatedId32Field<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F6FB50", Offset = "0x3F6E550", VA = "0x183F6FB50")]
		internal static void LFNLYEGAJCB<a>(this RepeatedField<a> a, int b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F6FAE0", Offset = "0x3F6E4E0", VA = "0x183F6FAE0")]
		internal static void LFNLYEGAJCB<b>(this RepeatedField<b> self, int a, b b) where b : struct
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
				[Cpp2IlInjected.Address(RVA = "0x5BF9640", Offset = "0x5BF8040", VA = "0x185BF9640", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x5BF6CA0", Offset = "0x5BF56A0", VA = "0x185BF6CA0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5BF8EE0", Offset = "0x5BF78E0", VA = "0x185BF8EE0")]
			private Enumerator(RepeatedField<int> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x5372790", Offset = "0x5371190", VA = "0x185372790")]
			public static Enumerator New(RepeatedField<int> impl)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5BF5EF0", Offset = "0x5BF48F0", VA = "0x185BF5EF0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE080", Offset = "0x2BACA80", VA = "0x182BAE080", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RepeatedField<int> _impl;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		internal RepeatedId32Field(RepeatedField<int> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x78A96E0", Offset = "0x78A80E0", VA = "0x1878A96E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x78A9740", Offset = "0x78A8140", VA = "0x1878A9740", Slot = "4")]
		private IEnumerator<Id32<M>> NWSXTYFIIPY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x78A9740", Offset = "0x78A8140", VA = "0x1878A9740", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
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
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		internal SOAFieldData(RepeatedField<T> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F12D30", Offset = "0x3F11730", VA = "0x183F12D30")]
		public SOAField<a?, b?> IVDFFFMFEGJ<a, b>([In] SOAId32<a> ids, Func<T, b> deserialize)
		{
			return default(SOAField<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F117F0", Offset = "0x3F101F0", VA = "0x183F117F0")]
		public SOAField<c?, d?> EANDSSPRODH<c, d>([In] SOAId32<c> ids, Func<T, d> deserialize)
		{
			return default(SOAField<c, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F14EE0", Offset = "0x3F138E0", VA = "0x183F14EE0")]
		public SOAField<e?, T?> IVDFFFMFEGJ<e>([In] SOAId32<e> ids)
		{
			return default(SOAField<e, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F15480", Offset = "0x3F13E80", VA = "0x183F15480")]
		public SOAField<f?, g?> YPPYRKQYXND<f, g>([In] SOAId32<f> ids, Func<Id32<f>, g> deserialize)
		{
			return default(SOAField<f, g>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class GIBTCWTNSGY
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3B02520", Offset = "0x3B00F20", VA = "0x183B02520")]
		public static void TNFSOTFAQBJ<a>(this SOAFieldData<a> self, int a, a b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3B02490", Offset = "0x3B00E90", VA = "0x183B02490")]
		public static void TNFSOTFAQBJ<b>(this SOAFieldData<b> a, int b, b c, b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3B022C0", Offset = "0x3B00CC0", VA = "0x183B022C0")]
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
			private KCYLKLPVMJQ.Enumerator _impl;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public readonly Id32<M> Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x5BF9E60", Offset = "0x5BF8860", VA = "0x185BF9E60", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x5BF6C00", Offset = "0x5BF5600", VA = "0x185BF6C00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x12ECD20", Offset = "0x12EB720", VA = "0x1812ECD20")]
			private Enumerator([In] KCYLKLPVMJQ.Enumerator impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6BA0", Offset = "0x5BF55A0", VA = "0x185BF6BA0")]
			public static Enumerator New([In] SOAId32Data<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6850", Offset = "0x5BF5250", VA = "0x185BF6850", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6F10", Offset = "0x5BF5910", VA = "0x185BF6F10", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly LDUQGPSPOOD _impl;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		internal SOAId32Data(LDUQGPSPOOD impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x78F8D00", Offset = "0x78F7700", VA = "0x1878F8D00")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x78F8D60", Offset = "0x78F7760", VA = "0x1878F8D60", Slot = "4")]
		private IEnumerator<Id32<M>> NWSXTYFIIPY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x78F8D60", Offset = "0x78F7760", VA = "0x1878F8D60", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class KCYLKLPVMJQ
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
				[Cpp2IlInjected.Address(RVA = "0xF8BE60", Offset = "0xF8A860", VA = "0x180F8BE60", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x2BAE050", Offset = "0x2BACA50", VA = "0x182BAE050", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE0B0", Offset = "0x2BACAB0", VA = "0x182BAE0B0")]
			private Enumerator([In] RepeatedField<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2BADF70", Offset = "0x2BAC970", VA = "0x182BADF70")]
			public static Enumerator New([In] LDUQGPSPOOD self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2BADD90", Offset = "0x2BAC790", VA = "0x182BADD90", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2BAE080", Offset = "0x2BACA80", VA = "0x182BAE080", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC930", Offset = "0x3BFB330", VA = "0x183BFC930")]
		public static SOAId32<M> IVDFFFMFEGJ<M>(this LDUQGPSPOOD a) where M : notnull
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE130", Offset = "0x2BACB30", VA = "0x182BAE130")]
		public static bool QRQFIYVPMIW(this LDUQGPSPOOD a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE420", Offset = "0x2BACE20", VA = "0x182BAE420")]
		public static int TNFSOTFAQBJ(this LDUQGPSPOOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE240", Offset = "0x2BACC40", VA = "0x182BAE240")]
		public static void Release(this LDUQGPSPOOD self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x339F520", Offset = "0x339DF20", VA = "0x18339F520")]
		public static SOAId32Data<M> OPEYQFTCYIA<M>(this LDUQGPSPOOD a) where M : notnull
		{
			return default(SOAId32Data<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE0E0", Offset = "0x2BACAE0", VA = "0x182BAE0E0")]
		public static Enumerator GetEnumerator(this LDUQGPSPOOD self)
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE380", Offset = "0x2BACD80", VA = "0x182BAE380")]
		public static CopyEnumerable<int, Enumerator> SXJZHXIMNGQ(this LDUQGPSPOOD self)
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
