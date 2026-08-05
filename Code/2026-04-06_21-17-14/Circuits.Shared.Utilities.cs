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
		[Cpp2IlInjected.Address(RVA = "0x2B79860", Offset = "0x2B78860", VA = "0x182B79860")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class AIAWZXKCIEY
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B788D0", Offset = "0x2B778D0", VA = "0x182B788D0")]
		private static string OLUUFLSYYFN(this string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B786C0", Offset = "0x2B776C0", VA = "0x182B786C0")]
		public static string EDRZRVQQIRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B78500", Offset = "0x2B77500", VA = "0x182B78500")]
		public static string AKGFRCAYKTB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x33672D0", Offset = "0x33662D0", VA = "0x1833672D0")]
		public static string FAXQECNFOCN<a>([In] a actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B78790", Offset = "0x2B77790", VA = "0x182B78790")]
		public static string GVYASHZDLNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3365920", Offset = "0x3364920", VA = "0x183365920")]
		public static string AWHEWRFWFSN<b, c>([In] b expected, [In] c actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3366B00", Offset = "0x3365B00", VA = "0x183366B00")]
		public static string EJEWGIRWPEI<d, e>([In] d notExpected, [In] e actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B787C0", Offset = "0x2B777C0", VA = "0x182B787C0")]
		public static string NDEFADQBXQY(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B78810", Offset = "0x2B77810", VA = "0x182B78810")]
		public static string NVLRIVTFKFW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B78640", Offset = "0x2B77640", VA = "0x182B78640")]
		public static string CQAKWHIMLRH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B78680", Offset = "0x2B77680", VA = "0x182B78680")]
		public static string EAYJKPKBIXA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x33674A0", Offset = "0x33664A0", VA = "0x1833674A0")]
		public static string IHXYFXKXYSI<dg>(string a, [In] dg actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B78890", Offset = "0x2B77890", VA = "0x182B78890")]
		public static string OBNLRMYWUHH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3366C70", Offset = "0x3365C70", VA = "0x183366C70")]
		public static string EPMJCCYLINW<dh, di>(string a, [In] dh expected, [In] di actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3366280", Offset = "0x3365280", VA = "0x183366280")]
		public static string BWCMVJRNVTL<dj, dk>(string a, [In] dj notExpected, [In] dk actual)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B786F0", Offset = "0x2B776F0", VA = "0x182B786F0")]
		public static void FBJPNVTIWUR(this LogDelegate a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B78A40", Offset = "0x2B77A40", VA = "0x182B78A40")]
		public static bool QCYUBINZLJN([In] this LogDelegates log, [Optional] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B78BB0", Offset = "0x2B77BB0", VA = "0x182B78BB0")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B78C80", Offset = "0x2B77C80", VA = "0x182B78C80")]
		public static bool VerifyIsTrue([In] this LogDelegates log, bool condition, [Out] LogDelegate err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B78530", Offset = "0x2B77530", VA = "0x182B78530")]
		public static bool BOJUCUKXPPI([In] this LogDelegates log, bool a, [Optional] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3366170", Offset = "0x3365170", VA = "0x183366170")]
		public static bool BOJUCUKXPPI<ic>([In] this LogDelegates log, bool a, ic b, FastestMessageFunc<ic> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3367560", Offset = "0x3366560", VA = "0x183367560")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T expected, U actual, [Optional] string message) where T : IEquatable<U>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B78AC0", Offset = "0x2B77AC0", VA = "0x182B78AC0")]
		public static bool VerifyAreNotEqual([In] this LogDelegates log, object notExpected, object actual, [Optional] string message)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x33678F0", Offset = "0x33668F0", VA = "0x1833678F0")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, [In] T actual, [Optional] string message) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B78D60", Offset = "0x2B77D60", VA = "0x182B78D60")]
		public static PerfScopeToken ZXQYVOBZPOU([In] this PerfScopeDelegates self, [Optional][CallerMemberName] string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B78600", Offset = "0x2B77600", VA = "0x182B78600")]
		public static PerfScopeToken CAMOWYRQCUB([In] this PerfScopeDelegates self, Func<string> a)
		{
			return default(PerfScopeToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class IAGZEXNTFPW
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B121A0", Offset = "0x3B111A0", VA = "0x183B121A0")]
		public static bool VerifyIsNotNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3B12320", Offset = "0x3B11320", VA = "0x183B12320")]
		public static bool VerifyIsNull<T>([In] this LogDelegates log, T? actual, [Optional] string message) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B11E90", Offset = "0x3B10E90", VA = "0x183B11E90")]
		public static bool VerifyAreEquatable<T, U>([In] this LogDelegates log, T? expected, U? actual, [Optional] string message, [Optional] string isNotNullMessage, [Optional] string isNullMessage) where T : struct, IEquatable<U> where U : struct
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerTypeProxy(typeof(IdUnsafeList<, >.BBFVCIGKRPJ))]
	public struct IdUnsafeList<M, T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public sealed class BBFVCIGKRPJ
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal UnsafeList<T> _unsafeList;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
		internal IdUnsafeList([In] UnsafeList<T> unsafeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x662EB80", Offset = "0x662DB80", VA = "0x18662EB80")]
		public static IdUnsafeList<M, T> New()
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x662EB00", Offset = "0x662DB00", VA = "0x18662EB00")]
		public static IdUnsafeList<M, T> LCNHZFSNGFS(int a)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x662EF00", Offset = "0x662DF00", VA = "0x18662EF00", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ESUBOYYAMWB
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
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			internal Deserializer(RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x37D5340", Offset = "0x37D4340", VA = "0x1837D5340")]
			public IdUnsafeList<a, TDeserialized> YUNAEWEBXQD<a>()
			{
				return default(IdUnsafeList<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3949F70", Offset = "0x3948F70", VA = "0x183949F70")]
		public static void DPEADTBFSRD<a, b, c>([In] this IdUnsafeList<a, b> self, RepeatedField<c> a, Func<b, c> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x394BBB0", Offset = "0x394ABB0", VA = "0x18394BBB0")]
		public static Deserializer<i, j> OHEXUFRLUSW<i, j>(this RepeatedField<i> a, Func<i, j> b)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x394A920", Offset = "0x3949920", VA = "0x18394A920")]
		public static void Destroy<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x394B6F0", Offset = "0x394A6F0", VA = "0x18394B6F0")]
		public static string LJSHBXAEUPP<n, o>([In] this IdUnsafeList<n, o> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0")]
		public static UnsafeList<y> EJSRFEILFWM<y, x>([In] this IdUnsafeList<x, y> self)
		{
			return default(UnsafeList<y>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x394A960", Offset = "0x3949960", VA = "0x18394A960")]
		public static T Get<T, M>([In] this IdUnsafeList<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x394AAB0", Offset = "0x3949AB0", VA = "0x18394AAB0")]
		public static ba FMNARAWZCCY<ba, z>(this IdUnsafeList<z, ba> a, Id32<z> b)
		{
			return (ba)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x394B110", Offset = "0x394A110", VA = "0x18394B110")]
		public static bc HTGPLFUWQEA<bc, bb>([In] this IdUnsafeList<bb, bc> self, Id32<bb> a)
		{
			return (bc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3948AD0", Offset = "0x3947AD0", VA = "0x183948AD0")]
		public static void Set<M, T>(this IdUnsafeList<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3948AD0", Offset = "0x3947AD0", VA = "0x183948AD0")]
		public static void DKBRAGJZTHC<bd, be>(this IdUnsafeList<bd, be> a, Id32<bd> b, be c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x394BC60", Offset = "0x394AC60", VA = "0x18394BC60")]
		public static int SCHSMMIDATL<bh, bi>([In] this IdUnsafeList<bh, bi> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x39482D0", Offset = "0x39472D0", VA = "0x1839482D0")]
		public static Id32<bl> BNFYGFFJUEH<bl, bm>([In] this IdUnsafeList<bl, bm> self)
		{
			return default(Id32<bl>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x394BC20", Offset = "0x394AC20", VA = "0x18394BC20")]
		public static bo PQTQLPQTPCW<bo, bn>([In] this IdUnsafeList<bn, bo> self)
		{
			return (bo)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x394C7F0", Offset = "0x394B7F0", VA = "0x18394C7F0")]
		public static ReadOnlyIdArray<bt, bu> YRMIMOUROTK<bt, bu>(this IdUnsafeList<bt, bu> a)
		{
			return default(ReadOnlyIdArray<bt, bu>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3948010", Offset = "0x3947010", VA = "0x183948010")]
		public static Id32<M> Add<M, T>(this IdUnsafeList<M, T> self, [In] T item)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x394C690", Offset = "0x394B690", VA = "0x18394C690")]
		public static Id32<bv> TIJMETXQOWR<bv, bw>(this IdUnsafeList<bv, bw> a, bw b)
		{
			return default(Id32<bv>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x394B390", Offset = "0x394A390", VA = "0x18394B390")]
		public static void Insert<M, T>(this IdUnsafeList<M, T> self, int index, [In] T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x394AD50", Offset = "0x3949D50", VA = "0x18394AD50")]
		public static void FWAYYBTKHHN<bx, by>(this IdUnsafeList<bx, by> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x394A6F0", Offset = "0x39496F0", VA = "0x18394A6F0")]
		public static void DYSHOGYVCVH<bz, ca>(this IdUnsafeList<bz, ca> a, Id32<bz> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3948330", Offset = "0x3947330", VA = "0x183948330")]
		public static void Clear<M, T>(this IdUnsafeList<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3948400", Offset = "0x3947400", VA = "0x183948400")]
		public static IdUnsafeList<M, T> Clone<M, T>([In] this IdUnsafeList<M, T> self, InFunc<T, T> cloneItem)
		{
			return default(IdUnsafeList<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3947C90", Offset = "0x3946C90", VA = "0x183947C90")]
		public static Id32Enumerator<ch> AZHRSBUURSB<ch, ci>([In] this IdUnsafeList<ch, ci> self)
		{
			return default(Id32Enumerator<ch>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x394AEE0", Offset = "0x3949EE0", VA = "0x18394AEE0")]
		public static UnsafeList<T>.Enumerator GetEnumerator<T, M>([In] this IdUnsafeList<M, T> self)
		{
			return default(UnsafeList<T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x394BC90", Offset = "0x394AC90", VA = "0x18394BC90")]
		public static UnsafeList<ck>.MutEnumerator SPPFSVZNENE<ck, cj>(this IdUnsafeList<cj, ck> a)
		{
			return default(UnsafeList<ck>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x394AE20", Offset = "0x3949E20", VA = "0x18394AE20")]
		public static CopyEnumerable<Id32<cl>, Id32Enumerator<cl>> GEFWBUZCWEZ<cl, cm>([In] this IdUnsafeList<cl, cm> self)
		{
			return default(CopyEnumerable<Id32<cl>, Id32Enumerator<cl>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x394C890", Offset = "0x394B890", VA = "0x18394C890")]
		public static ConstEnumerable<co, UnsafeList<co>.Enumerator> ZXOEKPMOXZK<co, cn>([In] this IdUnsafeList<cn, co> self)
		{
			return default(ConstEnumerable<co, UnsafeList<co>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x39485D0", Offset = "0x39475D0", VA = "0x1839485D0")]
		public static MutEnumerable<cq, UnsafeList<cq>.MutEnumerator> DDTHFOFWESC<cq, cp>(this IdUnsafeList<cp, cq> a)
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
		[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
		internal LinearIdAllocator32(int next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69AECB0", Offset = "0x69ADCB0", VA = "0x1869AECB0")]
		public static LinearIdAllocator32<M> New()
		{
			return default(LinearIdAllocator32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69AEDB0", Offset = "0x69ADDB0", VA = "0x1869AEDB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class MMQGYYJFCQG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C196C0", Offset = "0x3C186C0", VA = "0x183C196C0")]
		public static void Clear<M>(this LinearIdAllocator32<M> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C19720", Offset = "0x3C18720", VA = "0x183C19720")]
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
				[Cpp2IlInjected.Address(RVA = "0x662DFF0", Offset = "0x662CFF0", VA = "0x18662DFF0", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x662DA60", Offset = "0x662CA60", VA = "0x18662DA60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x662DEC0", Offset = "0x662CEC0", VA = "0x18662DEC0")]
			private IdEnumerator(Dictionary<Id32<M>, Id32<M>> gcToLinear, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x662DC40", Offset = "0x662CC40", VA = "0x18662DC40")]
			public static IdEnumerator New(LinearObjAllocator32<M, T> self)
			{
				return default(IdEnumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x662DC00", Offset = "0x662CC00", VA = "0x18662DC00", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x662DE80", Offset = "0x662CE80", VA = "0x18662DE80", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x69AF2D0", Offset = "0x69AE2D0", VA = "0x1869AF2D0")]
		private LinearObjAllocator32([In] SOAId32Field<M, T> gcObjAllocator, Dictionary<Id32<M>, Id32<M>> linearToGC, Dictionary<Id32<M>, Id32<M>> gcToLinear, LinearIdAllocator32<M> linearIdAllocator32)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69AEE70", Offset = "0x69ADE70", VA = "0x1869AEE70")]
		public static LinearObjAllocator32<M, T> New()
		{
			return default(LinearObjAllocator32<M, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CLVXNWHKHTC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x37E3430", Offset = "0x37E2430", VA = "0x1837E3430")]
		public static T Get<T, M>([In] this LinearObjAllocator32<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x37E31A0", Offset = "0x37E21A0", VA = "0x1837E31A0")]
		public static void Destroy<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37E3600", Offset = "0x37E2600", VA = "0x1837E3600")]
		public static Id32<e> KMFPVXZDKIT<e, f>(this LinearObjAllocator32<e, f> a, [In] f obj)
		{
			return default(Id32<e>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37E3780", Offset = "0x37E2780", VA = "0x1837E3780")]
		public static void Release<M, T>(this LinearObjAllocator32<M, T> self, Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x37E2F90", Offset = "0x37E1F90", VA = "0x1837E2F90")]
		public static void Clear<M, T>(this LinearObjAllocator32<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x37E2C60", Offset = "0x37E1C60", VA = "0x1837E2C60")]
		public static LinearObjAllocator32<n, o>.IdEnumerator AZHRSBUURSB<n, o>([In] this LinearObjAllocator32<n, o> self)
		{
			return default(LinearObjAllocator32<n, o>.IdEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37E32B0", Offset = "0x37E22B0", VA = "0x1837E32B0")]
		public static CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator> GEFWBUZCWEZ<t, u>([In] this LinearObjAllocator32<t, u> self)
		{
			return default(CopyEnumerable<Id32<t>, LinearObjAllocator32<t, u>.IdEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MultiResult
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct Enumerator : VPQLKCREQAA<Result<object, YCREHOYWOHO>>, CPNMZULKFNT<Result<object, YCREHOYWOHO>>, IEnumerator<Result<object, YCREHOYWOHO>>, IEnumerator, IDisposable, CAEGQGHKZKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private readonly Result<object, YCREHOYWOHO>[] _results;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private int _index;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public readonly int XKLXOHCJQTX
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x2B78D90", Offset = "0x2B77D90", VA = "0x182B78D90", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public readonly Result<object, YCREHOYWOHO> Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x2B78DB0", Offset = "0x2B77DB0", VA = "0x182B78DB0", Slot = "11")]
				get
				{
					return default(Result<object, YCREHOYWOHO>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private readonly Result<object, YCREHOYWOHO> BTMWPIQERLG
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x2B78DB0", Offset = "0x2B77DB0", VA = "0x182B78DB0", Slot = "4")]
				get
				{
					return default(Result<object, YCREHOYWOHO>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private readonly Result<object, YCREHOYWOHO> FDIHULRUYHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x2B79120", Offset = "0x2B78120", VA = "0x182B79120", Slot = "5")]
				get
				{
					return default(Result<object, YCREHOYWOHO>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x2B78DF0", Offset = "0x2B77DF0", VA = "0x182B78DF0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xDAE230", Offset = "0xDAD230", VA = "0x180DAE230")]
			private Enumerator(Result<object, YCREHOYWOHO>[] results, int index)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B790A0", Offset = "0x2B780A0", VA = "0x182B790A0")]
			public static Enumerator New(Result<object, YCREHOYWOHO>[] results)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B78E90", Offset = "0x2B77E90", VA = "0x182B78E90", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B79110", Offset = "0x2B78110", VA = "0x182B79110", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly Result<object, YCREHOYWOHO>[] _results;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Result<object, YCREHOYWOHO> this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2B79820", Offset = "0x2B78820", VA = "0x182B79820")]
			get
			{
				return default(Result<object, YCREHOYWOHO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static MultiResult QXGJXOUJRCD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B79740", Offset = "0x2B78740", VA = "0x182B79740")]
			get
			{
				return default(MultiResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		internal MultiResult(Result<object, YCREHOYWOHO>[] results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x10E4B80", Offset = "0x10E3B80", VA = "0x1810E4B80")]
		public static MultiResult New(Result<object, YCREHOYWOHO>[] results)
		{
			return default(MultiResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B797E0", Offset = "0x2B787E0", VA = "0x182B797E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DebuggerTypeProxy(typeof(SOAField<, >.BBFVCIGKRPJ))]
	public struct SOAField<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct MutEnumerator : VPQLKCREQAA<T>, CPNMZULKFNT<T>, IEnumerator<T>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7286380", Offset = "0x7285380", VA = "0x187286380", Slot = "10")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public readonly T CYEHBBWYWSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x7285D50", Offset = "0x7284D50", VA = "0x187285D50")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private readonly T PGLNFLXSXFH
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x72859F0", Offset = "0x72849F0", VA = "0x1872859F0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private readonly T ORVKBIETJGN
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x7284C60", Offset = "0x7283C60", VA = "0x187284C60", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x7285390", Offset = "0x7284390", VA = "0x187285390", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x72861C0", Offset = "0x72851C0", VA = "0x1872861C0")]
			internal MutEnumerator([In] IdUnsafeList<M, T> objects, [In] SOAId32<M>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x72856E0", Offset = "0x72846E0", VA = "0x1872856E0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7285800", Offset = "0x7284800", VA = "0x187285800", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct Enumerator : CPNMZULKFNT<T>, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private MutEnumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public readonly T Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x5C42410", Offset = "0x5C41410", VA = "0x185C42410", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private readonly T ORVKBIETJGN
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x5C3EE20", Offset = "0x5C3DE20", VA = "0x185C3EE20", Slot = "5")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x5C3EE20", Offset = "0x5C3DE20", VA = "0x185C3EE20", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x53697C0", Offset = "0x53687C0", VA = "0x1853697C0")]
			internal Enumerator([In] MutEnumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5C3F180", Offset = "0x5C3E180", VA = "0x185C3F180", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5C3F550", Offset = "0x5C3E550", VA = "0x185C3F550", Slot = "9")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5C3ECB0", Offset = "0x5C3DCB0", VA = "0x185C3ECB0", Slot = "6")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public sealed class BBFVCIGKRPJ
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal IdUnsafeList<M, T> _objects;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
		internal SOAField([In] IdUnsafeList<M, T> objects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2C80", Offset = "0x7AC1C80", VA = "0x187AC2C80")]
		public static SOAField<M, T> New()
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2C00", Offset = "0x7AC1C00", VA = "0x187AC2C00")]
		public static SOAField<M, T> LCNHZFSNGFS(int a)
		{
			return default(SOAField<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0E80", Offset = "0x7ABFE80", VA = "0x187AC0E80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1170", Offset = "0x7AC0170", VA = "0x187AC1170")]
		public void KMFPVXZDKIT(Id32<M> a, [In] T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC1D70", Offset = "0x7AC0D70", VA = "0x187AC1D70")]
		public void KTNJUIPXSLN(Id32<M> a, T b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC3630", Offset = "0x7AC2630", VA = "0x187AC3630")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC2D00", Offset = "0x7AC1D00", VA = "0x187AC2D00")]
		public void RAHXLJZEISD(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4170", Offset = "0x7AC3170", VA = "0x187AC4170", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class DRCMACSNZAZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x38FC6B0", Offset = "0x38FB6B0", VA = "0x1838FC6B0")]
		public static void DPEADTBFSRD<a, b, c>([In] this SOAField<a, b> self, [In] SOAId32<a> ids, RepeatedField<c> a, Func<b, c> b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x38FDD40", Offset = "0x38FCD40", VA = "0x1838FDD40")]
		public static void DPEADTBFSRD<d, e, f>([In] this SOAField<d, e> self, [In] SOAId32<d> ids, RepeatedField<f> a, InFunc<e, f> b, f c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x38FD690", Offset = "0x38FC690", VA = "0x1838FD690")]
		public static void DPEADTBFSRD<g, h>([In] this SOAField<g, h> self, [In] SOAId32<g> ids, RepeatedField<h> a, h b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x38FE320", Offset = "0x38FD320", VA = "0x1838FE320")]
		public static void FBHRXXPWDYV<i, j, k>([In] this SOAField<i, j> self, [In] SOAId32<i> ids, RepeatedField<k> a, Func<Id32<i>, k> b, k c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x38FDF80", Offset = "0x38FCF80", VA = "0x1838FDF80")]
		public static void Destroy<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x38FF1E0", Offset = "0x38FE1E0", VA = "0x1838FF1E0")]
		public static string LJSHBXAEUPP<l, m>([In] this SOAField<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B94640", Offset = "0x2B93640", VA = "0x182B94640")]
		public static T Get<T, M>([In] this SOAField<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2CEE260", Offset = "0x2CED260", VA = "0x182CEE260")]
		public static o FMNARAWZCCY<o, n>(this SOAField<n, o> a, Id32<n> b)
		{
			return (o)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x38FED50", Offset = "0x38FDD50", VA = "0x1838FED50")]
		public static q HTGPLFUWQEA<q, p>([In] this SOAField<p, q> self, Id32<p> a)
		{
			return (q)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2D2E180", Offset = "0x2D2D180", VA = "0x182D2E180")]
		public static void Set<M, T>(this SOAField<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B88950", Offset = "0x2B87950", VA = "0x182B88950")]
		public static void DKBRAGJZTHC<r, s>(this SOAField<r, s> a, Id32<r> b, s c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x38FFA50", Offset = "0x38FEA50", VA = "0x1838FFA50")]
		public static ReadOnlyIdSpan<v, w> WWHZWCIHBZH<v, w>([In] this SOAField<v, w> self)
		{
			return default(ReadOnlyIdSpan<v, w>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x38FF6A0", Offset = "0x38FE6A0", VA = "0x1838FF6A0")]
		public static int OYRLWZJLLBF<x, y>([In] this SOAField<x, y> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x38FB420", Offset = "0x38FA420", VA = "0x1838FB420")]
		public static void Clear<M, T>(this SOAField<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x38FF630", Offset = "0x38FE630", VA = "0x1838FF630")]
		public static bool NHBRJTHZLXE<z, ba>([In] this SOAField<z, ba> self, Id32<z> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x38FE9D0", Offset = "0x38FD9D0", VA = "0x1838FE9D0")]
		public static SOAField<M, T>.Enumerator GetEnumerator<M, T>([In] this SOAField<M, T> self, [In] SOAId32<M> ids)
		{
			return default(SOAField<M, T>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x38FF790", Offset = "0x38FE790", VA = "0x1838FF790")]
		public static SOAField<bd, be>.MutEnumerator SPPFSVZNENE<bd, be>(this SOAField<bd, be> a, [In] SOAId32<bd> ids)
		{
			return default(SOAField<bd, be>.MutEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x38FFAE0", Offset = "0x38FEAE0", VA = "0x1838FFAE0")]
		public static ConstEnumerable<bi, SOAField<bh, bi>.Enumerator> ZXOEKPMOXZK<bi, bh>([In] this SOAField<bh, bi> self, [In] SOAId32<bh> ids)
		{
			return default(ConstEnumerable<bi, SOAField<bh, bi>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x38FB560", Offset = "0x38FA560", VA = "0x1838FB560")]
		public static MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator> DDTHFOFWESC<bm, bl>(this SOAField<bl, bm> a, [In] SOAId32<bl> ids)
		{
			return default(MutEnumerable<bm, SOAField<bl, bm>.MutEnumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DebuggerTypeProxy(typeof(SOAId32<>.BBFVCIGKRPJ))]
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
				[Cpp2IlInjected.Address(RVA = "0x5BB15B0", Offset = "0x5BB05B0", VA = "0x185BB15B0", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x5BACAC0", Offset = "0x5BABAC0", VA = "0x185BACAC0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x2B9D180", Offset = "0x2B9C180", VA = "0x182B9D180")]
			private Enumerator([In] UnsafeList<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE710", Offset = "0x5BAD710", VA = "0x185BAE710")]
			public static Enumerator New([In] SOAId32<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD000", Offset = "0x5BAC000", VA = "0x185BAD000", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2E616E0", Offset = "0x2E606E0", VA = "0x182E616E0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public sealed class BBFVCIGKRPJ
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
		[Cpp2IlInjected.Address(RVA = "0x7AC7FF0", Offset = "0x7AC6FF0", VA = "0x187AC7FF0")]
		internal SOAId32(UnsafeList<ulong> used, UnsafeList<Id32<M>> free, Id32<M> next)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7120", Offset = "0x7AC6120", VA = "0x187AC7120")]
		public static SOAId32<M> New()
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7AC65B0", Offset = "0x7AC55B0", VA = "0x187AC65B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6AE0", Offset = "0x7AC5AE0", VA = "0x187AC6AE0")]
		public Id32<M> KMFPVXZDKIT()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7380", Offset = "0x7AC6380", VA = "0x187AC7380")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5CA0", Offset = "0x7AC4CA0", VA = "0x187AC5CA0")]
		public readonly UBRJGCFCYDR BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
		public readonly Id32<M> JTFDINEZFPQ()
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6ED0", Offset = "0x7AC5ED0", VA = "0x187AC6ED0")]
		public readonly bool NHBRJTHZLXE(Id32<M> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7DA0", Offset = "0x7AC6DA0", VA = "0x187AC7DA0")]
		public readonly bool ZANTMLNUIXH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC74D0", Offset = "0x7AC64D0", VA = "0x187AC74D0")]
		public readonly int SCHSMMIDATL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6460", Offset = "0x7AC5460", VA = "0x187AC6460")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6620", Offset = "0x7AC5620", VA = "0x187AC6620")]
		public readonly Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7F10", Offset = "0x7AC6F10", VA = "0x187AC7F10")]
		public readonly CopyEnumerable<Id32<M>, Enumerator> ZXOEKPMOXZK()
		{
			return default(CopyEnumerable<Id32<M>, Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7AC7590", Offset = "0x7AC6590", VA = "0x187AC7590", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class KAESOAQRIXZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B79690", Offset = "0x2B78690", VA = "0x182B79690")]
		public static (int, ulong) QSSBKHZIQHT(int a)
		{
			return default((int, ulong));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class LQPEENPFVTT<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x39CA4C0", Offset = "0x39C94C0", VA = "0x1839CA4C0")]
		public static SOAId32<b> NMWRGBYTBEY<a>([In] SOAId32<a> self) where a : b
		{
			return default(SOAId32<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerTypeProxy(typeof(SOAId32Field<, >.BBFVCIGKRPJ))]
	public struct SOAId32Field<M, T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class BBFVCIGKRPJ
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal SOAId32<M> _soaId32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal SOAField<M, T> _soaField;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5C50", Offset = "0x7AC4C50", VA = "0x187AC5C50")]
		internal SOAId32Field([In] SOAId32<M> soaId32, [In] SOAField<M, T> soaField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4D40", Offset = "0x7AC3D40", VA = "0x187AC4D40")]
		public static SOAId32Field<M, T> New()
		{
			return default(SOAId32Field<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC44A0", Offset = "0x7AC34A0", VA = "0x187AC44A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4600", Offset = "0x7AC3600", VA = "0x187AC4600")]
		public Id32<M> KMFPVXZDKIT([In] T obj)
		{
			return default(Id32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC57C0", Offset = "0x7AC47C0", VA = "0x187AC57C0")]
		public void Release(Id32<M> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5040", Offset = "0x7AC4040", VA = "0x187AC5040")]
		public void RAHXLJZEISD(Id32<M> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7AC5BD0", Offset = "0x7AC4BD0", VA = "0x187AC5BD0", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class PJPXCOLWBYV
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public readonly struct Deserializer<TSerialized, TDeserialized>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly UBRJGCFCYDR _serializedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly RepeatedField<TSerialized> _serialized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Func<TSerialized, TDeserialized> _deserialize;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
			internal Deserializer(UBRJGCFCYDR serializedIds, RepeatedField<TSerialized> serialized, Func<TSerialized, TDeserialized> deserialize)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x37D5220", Offset = "0x37D4220", VA = "0x1837D5220")]
			public SOAId32Field<a, TDeserialized> YUNAEWEBXQD<a>()
			{
				return default(SOAId32Field<a, TDeserialized>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D73840", Offset = "0x3D72840", VA = "0x183D73840")]
		public static UBRJGCFCYDR DPEADTBFSRD<a, b, c>([In] this SOAId32Field<a, b> self, RepeatedField<c> a, Func<b, c> b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D74F10", Offset = "0x3D73F10", VA = "0x183D74F10")]
		public static Deserializer<i, j> TCDZFJJQIOS<i, j>(this UBRJGCFCYDR a, RepeatedField<i> b, Func<i, j> c)
		{
			return default(Deserializer<i, j>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D73AD0", Offset = "0x3D72AD0", VA = "0x183D73AD0")]
		public static void Destroy<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D74650", Offset = "0x3D73650", VA = "0x183D74650")]
		public static string LJSHBXAEUPP<l, m>([In] this SOAId32Field<l, m> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D736D0", Offset = "0x3D726D0", VA = "0x183D736D0")]
		public static void Clear<M, T>(this SOAId32Field<M, T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D73610", Offset = "0x3D72610", VA = "0x183D73610")]
		public static SOAId32<bb>.Enumerator AZHRSBUURSB<bb, bc>([In] this SOAId32Field<bb, bc> self)
		{
			return default(SOAId32<bb>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D73E40", Offset = "0x3D72E40", VA = "0x183D73E40")]
		public static CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator> GEFWBUZCWEZ<bd, be>([In] this SOAId32Field<bd, be> self)
		{
			return default(CopyEnumerable<Id32<bd>, SOAId32<bd>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D73B70", Offset = "0x3D72B70", VA = "0x183D73B70")]
		public static T Get<T, M>([In] this SOAId32Field<M, T> self, Id32<M> i)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D73C00", Offset = "0x3D72C00", VA = "0x183D73C00")]
		public static bg FMNARAWZCCY<bg, bf>(this SOAId32Field<bf, bg> a, Id32<bf> b)
		{
			return (bg)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D73FD0", Offset = "0x3D72FD0", VA = "0x183D73FD0")]
		public static bi HTGPLFUWQEA<bi, bh>([In] this SOAId32Field<bh, bi> self, Id32<bh> a)
		{
			return (bi)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D740D0", Offset = "0x3D730D0", VA = "0x183D740D0")]
		public static ConstEnumerable<bw, SOAField<bv, bw>.Enumerator> JOKXRGFPNAR<bw, bv>([In] this SOAId32Field<bv, bw> self)
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
		[Cpp2IlInjected.Address(RVA = "0x2B7A610", Offset = "0x2B79610", VA = "0x182B7A610")]
		private StopwatchLogScope(string message, [In] ReadOnlyStopwatch stopwatch, [In] LogDelegates logDelegates, bool cachedShouldLog)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A560", Offset = "0x2B79560", VA = "0x182B7A560", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A430", Offset = "0x2B79430", VA = "0x182B7A430")]
		public static StopwatchLogScope DIRSUVLYYCD(string a, [In] LogDelegates logDelegates, bool b)
		{
			return default(StopwatchLogScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class SOZZQPFJCZD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B79E40", Offset = "0x2B78E40", VA = "0x182B79E40")]
		public static void SXLCKZFIWFP(this Stream a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A400", Offset = "0x2B79400", VA = "0x182B7A400")]
		public static bool ZXZYGUDANCS(this Stream a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A1A0", Offset = "0x2B791A0", VA = "0x182B7A1A0")]
		public static void XINRIBJZKTD(this Stream a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B79910", Offset = "0x2B78910", VA = "0x182B79910")]
		public static float FQAVAZDEULO(this Stream a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A110", Offset = "0x2B79110", VA = "0x182B7A110")]
		public static void XBZMJMQYWBI(this Stream a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B79E20", Offset = "0x2B78E20", VA = "0x182B79E20")]
		public static int SRZOMTPTEDB(this Stream a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B79D30", Offset = "0x2B78D30", VA = "0x182B79D30")]
		public static void QTOUTKKEVUL(this Stream a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B79AB0", Offset = "0x2B78AB0", VA = "0x182B79AB0")]
		public static long MABVXIRHBCQ(this Stream a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B79930", Offset = "0x2B78930", VA = "0x182B79930")]
		public static void FTZSUUIGOUU(this Stream a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B79E80", Offset = "0x2B78E80", VA = "0x182B79E80")]
		public static string TFPPGMPYPED(this Stream a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B798E0", Offset = "0x2B788E0", VA = "0x182B798E0")]
		public static void CEXRHYCFCZZ(this Stream a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B79CB0", Offset = "0x2B78CB0", VA = "0x182B79CB0")]
		public static void PCRISOGPLOC(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A320", Offset = "0x2B79320", VA = "0x182B7A320")]
		public static void ZPTLYTAVOQW(this Stream self, [In] (byte b0, byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7) bytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B79C80", Offset = "0x2B78C80", VA = "0x182B79C80")]
		public static byte OMZVSSAOJZW(this Stream a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A230", Offset = "0x2B79230", VA = "0x182B7A230")]
		public static (byte, byte, byte, byte) XURPIFUKWWZ(this Stream self)
		{
			return default((byte, byte, byte, byte));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B79F50", Offset = "0x2B78F50", VA = "0x182B79F50")]
		public static (byte, byte, byte, byte, byte, byte, byte, byte) WXOZBSZIVND(this Stream self)
		{
			return default((byte, byte, byte, byte, byte, byte, byte, byte));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class BBBIFCEHEGZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3727010", Offset = "0x3726010", VA = "0x183727010")]
		public static void DPEADTBFSRD<a, b>([In] this UnsafeList<a> self, RepeatedField<b> a, Func<a, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x37277F0", Offset = "0x37267F0", VA = "0x1837277F0")]
		public static void DPEADTBFSRD<e>([In] this UnsafeList<e> self, RepeatedField<e> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3728000", Offset = "0x3727000", VA = "0x183728000")]
		public static UnsafeList<i> NIFFVCTAJTV<i, h>(this RepeatedField<h> a, Func<h, i> b)
		{
			return default(UnsafeList<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3728220", Offset = "0x3727220", VA = "0x183728220")]
		public static UnsafeList<k> NIFFVCTAJTV<k>(this RepeatedField<k> a)
		{
			return default(UnsafeList<k>);
		}
	}
}
namespace Circuits.Shared.Utilities.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class QNTDRHFOCTJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x39B5680", Offset = "0x39B4680", VA = "0x1839B5680")]
		public static SOAFieldData<T> QQCTVAKMBBL<T>(this RepeatedField<T> a) where T : notnull
		{
			return default(SOAFieldData<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x39B5680", Offset = "0x39B4680", VA = "0x1839B5680")]
		public static RepeatedId32Field<M> TXOBLHKDJLW<M>(this RepeatedField<int> a) where M : notnull
		{
			return default(RepeatedId32Field<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E17A30", Offset = "0x3E16A30", VA = "0x183E17A30")]
		internal static void DYSHOGYVCVH<a>(this RepeatedField<a> a, int b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3E179C0", Offset = "0x3E169C0", VA = "0x183E179C0")]
		internal static void DYSHOGYVCVH<b>(this RepeatedField<b> self, int a, b b) where b : struct
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
				[Cpp2IlInjected.Address(RVA = "0x5BB0F50", Offset = "0x5BAFF50", VA = "0x185BB0F50", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x5BACB60", Offset = "0x5BABB60", VA = "0x185BACB60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5BB0500", Offset = "0x5BAF500", VA = "0x185BB0500")]
			private Enumerator(RepeatedField<int> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x537DB80", Offset = "0x537CB80", VA = "0x18537DB80")]
			public static Enumerator New(RepeatedField<int> impl)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5BADA20", Offset = "0x5BACA20", VA = "0x185BADA20", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2B79110", Offset = "0x2B78110", VA = "0x182B79110", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RepeatedField<int> _impl;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		internal RepeatedId32Field(RepeatedField<int> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A61C80", Offset = "0x7A60C80", VA = "0x187A61C80")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A61CE0", Offset = "0x7A60CE0", VA = "0x187A61CE0", Slot = "4")]
		private IEnumerator<Id32<M>> PUJWEENAXVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A61CE0", Offset = "0x7A60CE0", VA = "0x187A61CE0", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
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
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		internal SOAFieldData(RepeatedField<T> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9940", Offset = "0x3EB8940", VA = "0x183EB9940")]
		public SOAField<a?, b?> MQCSYLKHLDL<a, b>([In] SOAId32<a> ids, Func<T, b> deserialize)
		{
			return default(SOAField<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3EBC600", Offset = "0x3EBB600", VA = "0x183EBC600")]
		public SOAField<c?, d?> XNIYYYNWHPD<c, d>([In] SOAId32<c> ids, Func<T, d> deserialize)
		{
			return default(SOAField<c, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3EBB4E0", Offset = "0x3EBA4E0", VA = "0x183EBB4E0")]
		public SOAField<e?, T?> MQCSYLKHLDL<e>([In] SOAId32<e> ids)
		{
			return default(SOAField<e, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3EBBA80", Offset = "0x3EBAA80", VA = "0x183EBBA80")]
		public SOAField<f?, g?> QQASSHPIVVL<f, g>([In] SOAId32<f> ids, Func<Id32<f>, g> deserialize)
		{
			return default(SOAField<f, g>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class WDRSXIVTBQI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x40CDE30", Offset = "0x40CCE30", VA = "0x1840CDE30")]
		public static void KMFPVXZDKIT<a>(this SOAFieldData<a> self, int a, a b, Func<a> c) where a : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x40CDDA0", Offset = "0x40CCDA0", VA = "0x1840CDDA0")]
		public static void KMFPVXZDKIT<b>(this SOAFieldData<b> a, int b, b c, b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x40CDEC0", Offset = "0x40CCEC0", VA = "0x1840CDEC0")]
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
			private JJITFSXNCVA.Enumerator _impl;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public readonly Id32<M> Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x5BB1770", Offset = "0x5BB0770", VA = "0x185BB1770", Slot = "4")]
				get
				{
					return default(Id32<M>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x5BAC9A0", Offset = "0x5BAB9A0", VA = "0x185BAC9A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
			private Enumerator([In] JJITFSXNCVA.Enumerator impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE770", Offset = "0x5BAD770", VA = "0x185BAE770")]
			public static Enumerator New([In] SOAId32Data<M> self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE330", Offset = "0x5BAD330", VA = "0x185BAE330", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5BAE7D0", Offset = "0x5BAD7D0", VA = "0x185BAE7D0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly UBRJGCFCYDR _impl;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		internal SOAId32Data(UBRJGCFCYDR impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7AC42F0", Offset = "0x7AC32F0", VA = "0x187AC42F0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4350", Offset = "0x7AC3350", VA = "0x187AC4350", Slot = "4")]
		private IEnumerator<Id32<M>> PUJWEENAXVA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7AC4350", Offset = "0x7AC3350", VA = "0x187AC4350", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class JJITFSXNCVA
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
				[Cpp2IlInjected.Address(RVA = "0xF584A0", Offset = "0xF574A0", VA = "0x180F584A0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private readonly object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x2B78E60", Offset = "0x2B77E60", VA = "0x182B78E60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x2B79160", Offset = "0x2B78160", VA = "0x182B79160")]
			private Enumerator([In] RepeatedField<ulong> used, int current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2B790D0", Offset = "0x2B780D0", VA = "0x182B790D0")]
			public static Enumerator New([In] UBRJGCFCYDR self)
			{
				return default(Enumerator);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2B78EC0", Offset = "0x2B77EC0", VA = "0x182B78EC0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2B79110", Offset = "0x2B78110", VA = "0x182B79110", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2F90", Offset = "0x3BA1F90", VA = "0x183BA2F90")]
		public static SOAId32<M> MQCSYLKHLDL<M>(this UBRJGCFCYDR a) where M : notnull
		{
			return default(SOAId32<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B793A0", Offset = "0x2B783A0", VA = "0x182B793A0")]
		public static bool NHBRJTHZLXE(this UBRJGCFCYDR a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B791E0", Offset = "0x2B781E0", VA = "0x182B791E0")]
		public static int KMFPVXZDKIT(this UBRJGCFCYDR a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B794B0", Offset = "0x2B784B0", VA = "0x182B794B0")]
		public static void Release(this UBRJGCFCYDR self, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x39B5680", Offset = "0x39B4680", VA = "0x1839B5680")]
		public static SOAId32Data<M> TXOBLHKDJLW<M>(this UBRJGCFCYDR a) where M : notnull
		{
			return default(SOAId32Data<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B79190", Offset = "0x2B78190", VA = "0x182B79190")]
		public static Enumerator GetEnumerator(this UBRJGCFCYDR self)
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B795F0", Offset = "0x2B785F0", VA = "0x182B795F0")]
		public static CopyEnumerable<int, Enumerator> ZXOEKPMOXZK(this UBRJGCFCYDR self)
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
