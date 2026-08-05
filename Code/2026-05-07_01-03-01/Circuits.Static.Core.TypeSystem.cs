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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CXXOCPTCXZR : IEquatable<CXXOCPTCXZR>, WTBFSIOAEWL<CXXOCPTCXZR>, KOYRSGOUQRU
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool TJWAMNXOKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool MVIZSTHWGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int HKATMXQRWIP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind DPDMCSHWOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCDFF30", Offset = "0xCDE930", VA = "0x180CDFF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? FBSUCHZZBJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B9AA40", Offset = "0x2B99440", VA = "0x182B9AA40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual CXXOCPTCXZR PZHIPAGSPZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool AMKGSQTFBGG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ADA0", Offset = "0x2B997A0", VA = "0x182B9ADA0")]
		public static void VQZGAVQPNPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
		protected CXXOCPTCXZR(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AAB0", Offset = "0x2B994B0", VA = "0x182B9AAB0")]
		public static CXXOCPTCXZR New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0")]
		protected static a NBXSPFQAWQD<a>(a a) where a : CXXOCPTCXZR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDF4FD0", Offset = "0xDF39D0", VA = "0x180DF4FD0", Slot = "9")]
		public virtual CXXOCPTCXZR XXUTACXLPBW(IReadOnlyDictionary<string, CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ABB0", Offset = "0x2B995B0", VA = "0x182B9ABB0", Slot = "11")]
		public virtual void RWSDLIOLTVW(Action<CXXOCPTCXZR> a, Action<CXXOCPTCXZR> b, Action<CXXOCPTCXZR> c, Action<CXXOCPTCXZR> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ABE0", Offset = "0x2B995E0", VA = "0x182B9ABE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A9A0", Offset = "0x2B993A0", VA = "0x182B9A9A0", Slot = "12")]
		public virtual bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A830", Offset = "0x2B99230", VA = "0x182B9A830", Slot = "4")]
		public bool Equals(CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A7E0", Offset = "0x2B991E0", VA = "0x182B9A7E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB40", Offset = "0x2B99540", VA = "0x182B9AB40")]
		public static bool OTUOIXXRZSY(CXXOCPTCXZR a, CXXOCPTCXZR b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A960", Offset = "0x2B99360", VA = "0x182B9A960")]
		public static bool JSGIPYLAFHN(CXXOCPTCXZR a, CXXOCPTCXZR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A860", Offset = "0x2B99260", VA = "0x182B9A860", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB80", Offset = "0x2B99580", VA = "0x182B9AB80", Slot = "13")]
		public virtual int XOGNHOYTMYT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB80", Offset = "0x2B99580", VA = "0x182B9AB80", Slot = "14")]
		protected virtual int QUCQYMWTKJV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38532B0", Offset = "0x3851CB0", VA = "0x1838532B0")]
		public b CPMAUTPDHUP<b>() where b : CXXOCPTCXZR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB20", Offset = "0x2B99520", VA = "0x182B9AB20", Slot = "15")]
		public virtual string ORYCYTPKZGA(IReadOnlyList<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A910", Offset = "0x2B99310", VA = "0x182B9A910", Slot = "16")]
		public virtual int JBVOVENBDDJ(IReadOnlyList<CXXOCPTCXZR> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AD50", Offset = "0x2B99750", VA = "0x182B9AD50", Slot = "17")]
		public virtual bool VMYUNWFPEAG(IReadOnlyList<CXXOCPTCXZR> a, IReadOnlyList<CXXOCPTCXZR> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A690", Offset = "0x2B99090", VA = "0x182B9A690")]
		public ILXFIROPVHU BMFXCOGCWNW(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A680", Offset = "0x2B99080", VA = "0x182B9A680")]
		public ILXFIROPVHU BMFXCOGCWNW(params CXXOCPTCXZR[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A680", Offset = "0x2B99080", VA = "0x182B9A680")]
		public ILXFIROPVHU BMFXCOGCWNW(IEnumerable<CXXOCPTCXZR> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ZFCLKDKZCRS<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a BYOCAECLSQK(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b CRZQWFHBJZK([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind GNUIIRKXXOW([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates URERMHZYYFX(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KOYRSGOUQRU
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int XOGNHOYTMYT(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class XOGNHOYTMYT
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class UGQZGQQAJXP<a> where a : KOYRSGOUQRU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int SGGGROIKEBS;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public UGQZGQQAJXP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7DADBF0", Offset = "0x7DAC5F0", VA = "0x187DADBF0")]
			internal int UNKAPCEOPFQ(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class BFGYFGFITKT<a, b> where b : KOYRSGOUQRU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int SGGGROIKEBS;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public BFGYFGFITKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4EA46E0", Offset = "0x4EA30E0", VA = "0x184EA46E0")]
			internal int UNKAPCEOPFQ(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class OFNOLNZMEXZ<a> where a : KOYRSGOUQRU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int SGGGROIKEBS;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public OFNOLNZMEXZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x72EAD10", Offset = "0x72E9710", VA = "0x1872EAD10")]
			internal int PUWTJHYFSVB(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41099E0", Offset = "0x41083E0", VA = "0x1841099E0")]
		public static int WWNXUXXHDMM<a>(this IEnumerable<a> a, int b = 0) where a : KOYRSGOUQRU
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4109AB0", Offset = "0x41084B0", VA = "0x184109AB0")]
		public static int WWNXUXXHDMM<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : KOYRSGOUQRU
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x41099E0", Offset = "0x41083E0", VA = "0x1841099E0")]
		public static int QXWWVYLDFYX<d>(this IEnumerable<d> a, int b = 0) where d : KOYRSGOUQRU
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : ZFCLKDKZCRS<TDirectedType, CXXOCPTCXZR, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x54534F0", Offset = "0x5451EF0", VA = "0x1854534F0")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7D70010", Offset = "0x7D6EA10", VA = "0x187D70010")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class GNBTYOBMJIZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ZCDXRCGYODR<a, b, c> where c : ZFCLKDKZCRS<a, CXXOCPTCXZR, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public CXXOCPTCXZR KULXLZLJPYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<CXXOCPTCXZR> GLJFEBIOCIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public CXXOCPTCXZR QIKEBDCCMNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<CXXOCPTCXZR> CUVAPQFZNXB;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZCDXRCGYODR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5171B30", Offset = "0x5170530", VA = "0x185171B30")]
			internal bool BZNPLYPBDEV([In] TypeSys<a, b, c> self_, CXXOCPTCXZR a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5171A30", Offset = "0x5170430", VA = "0x185171A30")]
			internal bool BYXUUEHJAWU([In] TypeSys<a, b, c> self_, CXXOCPTCXZR a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5171D30", Offset = "0x5170730", VA = "0x185171D30")]
			internal bool CAIRAZQQOYF([In] TypeSys<a, b, c> self_, CXXOCPTCXZR a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JCSPDBKVLPC<a, b, c> where c : ZFCLKDKZCRS<a, CXXOCPTCXZR, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public CXXOCPTCXZR GSHPJJZFEOD;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JCSPDBKVLPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x66D1F40", Offset = "0x66D0940", VA = "0x1866D1F40")]
			internal bool CADKDSWTFMW([In] TypeSys<a, b, c> self__, CXXOCPTCXZR a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class XTNKENEOFSR<a, b, c> where c : ZFCLKDKZCRS<a, CXXOCPTCXZR, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b XBKNLMWAWOQ;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public XTNKENEOFSR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5093F20", Offset = "0x5092920", VA = "0x185093F20")]
			internal CXXOCPTCXZR COADMWKWPHE([In] TypeSys<a, b, c> self_, [In] b root_, CXXOCPTCXZR a, CXXOCPTCXZR b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ZSZAGFARSZU<a, b, c> where c : ZFCLKDKZCRS<a, CXXOCPTCXZR, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LHUDJTUIYXO TOVNYRAZBQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public LHUDJTUIYXO CCDUOTQEJHI;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZSZAGFARSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5181FF0", Offset = "0x51809F0", VA = "0x185181FF0")]
			internal a CNUWPPQZFVV([In] TypeSys<a, b, c> self_, IOKind a, LHUDJTUIYXO b, LHUDJTUIYXO c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class SBYPBZQLGZZ<a, b, c> where c : ZFCLKDKZCRS<a, CXXOCPTCXZR, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<LHUDJTUIYXO> TRQCWHVBQHK;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public SBYPBZQLGZZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x796B2F0", Offset = "0x7969CF0", VA = "0x18796B2F0")]
			internal bool PHWZHHMAWDJ(bool a, LHUDJTUIYXO b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] OZWDCZLOBRU;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBCB0", Offset = "0x3AEA6B0", VA = "0x183AEBCB0")]
		public static bool ZZQCYHGVBAH<a, b, c>([In] this TypeSys<a, b, c> _, CXXOCPTCXZR a) where c : ZFCLKDKZCRS<a, CXXOCPTCXZR, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2390", Offset = "0x3AE0D90", VA = "0x183AE2390")]
		public static bool DBOBQRXEPBW<d, e, f>([In] this TypeSys<d, e, f> _, CXXOCPTCXZR a) where f : ZFCLKDKZCRS<d, CXXOCPTCXZR, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2C40", Offset = "0x3AE1640", VA = "0x183AE2C40")]
		public static bool PGGVRUKVNLC<g, h, i>([In] this TypeSys<g, h, i> self, CXXOCPTCXZR a, CXXOCPTCXZR b) where i : ZFCLKDKZCRS<g, CXXOCPTCXZR, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2DE0", Offset = "0x3AE17E0", VA = "0x183AE2DE0")]
		private static bool UQYJMEGLLJX<j, k, l>([In] this TypeSys<j, k, l> self, CXXOCPTCXZR a, CXXOCPTCXZR b, IReadOnlyList<CXXOCPTCXZR> c, IReadOnlyList<CXXOCPTCXZR> d) where l : ZFCLKDKZCRS<j, CXXOCPTCXZR, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6D80", Offset = "0x3AE5780", VA = "0x183AE6D80")]
		public static CXXOCPTCXZR ZAFYELTFHAP<m, n, o>([In] this TypeSys<m, n, o> self, n a, CXXOCPTCXZR b, CXXOCPTCXZR c) where o : ZFCLKDKZCRS<m, CXXOCPTCXZR, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4010", Offset = "0x3AE2A10", VA = "0x183AE4010")]
		public static p ZAFYELTFHAP<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : ZFCLKDKZCRS<p, CXXOCPTCXZR, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2860", Offset = "0x3AE1260", VA = "0x183AE2860")]
		private static List<w> JLVDAOFJXIX<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : ZFCLKDKZCRS<t, CXXOCPTCXZR, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1910", Offset = "0x3AE0310", VA = "0x183AE1910")]
		private static ba BHKRTDCNEXP<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class JOKSJXTRJKQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static CXXOCPTCXZR FRBGQEMMISJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B9DC90", Offset = "0x2B9C690", VA = "0x182B9DC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static CXXOCPTCXZR NBIKSSDNWGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2B9DC40", Offset = "0x2B9C640", VA = "0x182B9DC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static CXXOCPTCXZR CSJNINTFVPM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B9DB10", Offset = "0x2B9C510", VA = "0x182B9DB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static CXXOCPTCXZR WPSRBSYFOTK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B9DD30", Offset = "0x2B9C730", VA = "0x182B9DD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static CXXOCPTCXZR JAQQVCNLYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B9D4F0", Offset = "0x2B9BEF0", VA = "0x182B9D4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static CXXOCPTCXZR KKKKWAPUOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B9DBF0", Offset = "0x2B9C5F0", VA = "0x182B9DBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static CXXOCPTCXZR VUPQYBVKCSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B9D4A0", Offset = "0x2B9BEA0", VA = "0x182B9D4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static CXXOCPTCXZR HHTJRKYZZIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B9DCE0", Offset = "0x2B9C6E0", VA = "0x182B9DCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D540", Offset = "0x2B9BF40", VA = "0x182B9D540")]
		public static ILXFIROPVHU FKAWAJFRRAK([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DB60", Offset = "0x2B9C560", VA = "0x182B9DB60")]
		public static ILXFIROPVHU RMYHILCKWXK(IEnumerable<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D8D0", Offset = "0x2B9C2D0", VA = "0x182B9D8D0")]
		public static ILXFIROPVHU OAXCXKAMDWM(IEnumerable<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D960", Offset = "0x2B9C360", VA = "0x182B9D960")]
		public static ILXFIROPVHU OAXCXKAMDWM(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D840", Offset = "0x2B9C240", VA = "0x182B9D840")]
		public static ILXFIROPVHU ICVNJTZJOZX(IEnumerable<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D670", Offset = "0x2B9C070", VA = "0x182B9D670")]
		public static RPEWIWWPNNN FURSIYSAZPQ(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ILXFIROPVHU : CXXOCPTCXZR, IEquatable<ILXFIROPVHU>, WTBFSIOAEWL<ILXFIROPVHU>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ZVHTJXFVZVA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, CXXOCPTCXZR> VTQVTVYZTZE;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZVHTJXFVZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2BA6570", Offset = "0x2BA4F70", VA = "0x182BA6570")]
			internal CXXOCPTCXZR OKWEGWJZEXU(CXXOCPTCXZR a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CXXOCPTCXZR RXHHEPTNMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override CXXOCPTCXZR PZHIPAGSPZF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<CXXOCPTCXZR> LUHIKJYTSOP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool AMKGSQTFBGG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B9CC50", Offset = "0x2B9B650", VA = "0x182B9CC50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D2B0", Offset = "0x2B9BCB0", VA = "0x182B9D2B0", Slot = "9")]
		public sealed override CXXOCPTCXZR XXUTACXLPBW(IReadOnlyDictionary<string, CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D010", Offset = "0x2B9BA10", VA = "0x182B9D010", Slot = "11")]
		public sealed override void RWSDLIOLTVW(Action<CXXOCPTCXZR> a, Action<CXXOCPTCXZR> b, Action<CXXOCPTCXZR> c, Action<CXXOCPTCXZR> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D3D0", Offset = "0x2B9BDD0", VA = "0x182B9D3D0")]
		private ILXFIROPVHU(CXXOCPTCXZR a, IEnumerable<CXXOCPTCXZR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CEE0", Offset = "0x2B9B8E0", VA = "0x182B9CEE0")]
		public static ILXFIROPVHU New(CXXOCPTCXZR originalType, IEnumerable<CXXOCPTCXZR> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D270", Offset = "0x2B9BC70", VA = "0x182B9D270", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CDE0", Offset = "0x2B9B7E0", VA = "0x182B9CDE0", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CE30", Offset = "0x2B9B830", VA = "0x182B9CE30")]
		public bool JWGGIVUYRNA([In] ILXFIROPVHU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CDC0", Offset = "0x2B9B7C0", VA = "0x182B9CDC0", Slot = "18")]
		public bool Equals(ILXFIROPVHU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CD70", Offset = "0x2B9B770", VA = "0x182B9CD70", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CF60", Offset = "0x2B9B960", VA = "0x182B9CF60", Slot = "14")]
		protected override int QUCQYMWTKJV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CED0", Offset = "0x2B9B8D0", VA = "0x182B9CED0", Slot = "19")]
		private bool LKNUUWUOSJN([In] ILXFIROPVHU other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class JYJVODDDCOV : CXXOCPTCXZR, IEquatable<JYJVODDDCOV>, WTBFSIOAEWL<JYJVODDDCOV>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E400", Offset = "0x2B9CE00", VA = "0x182B9E400")]
		private JYJVODDDCOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E260", Offset = "0x2B9CC60", VA = "0x182B9E260")]
		public static JYJVODDDCOV New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E360", Offset = "0x2B9CD60", VA = "0x182B9E360", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E2D0", Offset = "0x2B9CCD0", VA = "0x182B9E2D0", Slot = "15")]
		public sealed override string ORYCYTPKZGA(IReadOnlyList<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E3C0", Offset = "0x2B9CDC0", VA = "0x182B9E3C0")]
		private static string VILENVVPFBI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E210", Offset = "0x2B9CC10", VA = "0x182B9E210", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0")]
		public bool JWGGIVUYRNA([In] JYJVODDDCOV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xF58270", Offset = "0xF56C70", VA = "0x180F58270", Slot = "18")]
		public bool Equals(JYJVODDDCOV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E1C0", Offset = "0x2B9CBC0", VA = "0x182B9E1C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0", Slot = "19")]
		private bool FSWEYZFRHHU([In] JYJVODDDCOV other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class KOZLCKPLUXM
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ESCTXDLDNMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public CXXOCPTCXZR FLRJIWWTOMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<CXXOCPTCXZR, ILXFIROPVHU> LSPUMBLAEIC;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ESCTXDLDNMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C6E0", Offset = "0x2B9B0E0", VA = "0x182B9C6E0")]
			internal ILXFIROPVHU BFNSPDBFMPY(CXXOCPTCXZR a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ERXMZWRGEAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public CXXOCPTCXZR MOCAWPIYIDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<CXXOCPTCXZR, ILXFIROPVHU> NJHXTIEVTIK;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ERXMZWRGEAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C560", Offset = "0x2B9AF60", VA = "0x182B9C560")]
			internal ILXFIROPVHU XMXZWEFKKQC(CXXOCPTCXZR a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1190", Offset = "0x2B9FB90", VA = "0x182BA1190")]
		public static IEnumerable<LHUDJTUIYXO> VSBNALXIWWO(this LHUDJTUIYXO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F9C0", Offset = "0x2B9E3C0", VA = "0x182B9F9C0")]
		private static IEnumerable<LHUDJTUIYXO> QIZUVGDOUSM(this LHUDJTUIYXO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E420", Offset = "0x2B9CE20", VA = "0x182B9E420")]
		public static (CXXOCPTCXZR, IReadOnlyList<CXXOCPTCXZR>, bool) ACBRDDFBSLY(this CXXOCPTCXZR a, [Optional] IReadOnlyList<CXXOCPTCXZR> b)
		{
			return default((CXXOCPTCXZR, IReadOnlyList<CXXOCPTCXZR>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E5F0", Offset = "0x2B9CFF0", VA = "0x182B9E5F0")]
		public static TypeKind CZVKEBPZSJH(this CXXOCPTCXZR a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E620", Offset = "0x2B9D020", VA = "0x182B9E620")]
		private static CXXOCPTCXZR ConvertClassesToIntersections(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F100", Offset = "0x2B9DB00", VA = "0x182B9F100")]
		private static CXXOCPTCXZR DistributeUnionIntoIntersection(this ILXFIROPVHU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EC70", Offset = "0x2B9D670", VA = "0x182B9EC70")]
		private static CXXOCPTCXZR DistributeIntersectionIntoIntersection(this ILXFIROPVHU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EFA0", Offset = "0x2B9D9A0", VA = "0x182B9EFA0")]
		private static CXXOCPTCXZR DistributeIntoIntersection(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F480", Offset = "0x2B9DE80", VA = "0x182B9F480")]
		private static bool OtherIsAssignableToOther(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes, CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BA09F0", Offset = "0x2B9F3F0", VA = "0x182BA09F0")]
		private static bool UnionIsAssignableToOther(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes, CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F610", Offset = "0x2B9E010", VA = "0x182B9F610")]
		private static bool OtherIsAssignableToUnion(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes, CXXOCPTCXZR union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0D20", Offset = "0x2B9F720", VA = "0x182BA0D20")]
		private static bool UnionIsAssignableToUnion(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes, CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0760", Offset = "0x2B9F160", VA = "0x182BA0760")]
		public static CXXOCPTCXZR RemoveCommonTypesFromIntersectionDistribution(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B9FA80", Offset = "0x2B9E480", VA = "0x182B9FA80")]
		public static CXXOCPTCXZR RemoveCommonTypesFromIntersectionDistributionInternal(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0920", Offset = "0x2B9F320", VA = "0x182BA0920")]
		public static CXXOCPTCXZR SimplifyIntersectionUnion(this CXXOCPTCXZR self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F430", Offset = "0x2B9DE30", VA = "0x182B9F430")]
		public static IEnumerable<CXXOCPTCXZR> LUHIKJYTSOP(this CXXOCPTCXZR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0890", Offset = "0x2B9F290", VA = "0x182BA0890")]
		public static IEnumerable<CXXOCPTCXZR> SLTUMDNUEAQ(this CXXOCPTCXZR a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class LHUDJTUIYXO : STCOSOBEHFT, IEquatable<LHUDJTUIYXO>, WTBFSIOAEWL<LHUDJTUIYXO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class SEWMYIGJYVN : IEnumerable<LHUDJTUIYXO>, IEnumerable, IEnumerator<LHUDJTUIYXO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private LHUDJTUIYXO AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public LHUDJTUIYXO AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<LHUDJTUIYXO> ONPYAFUWWYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private LHUDJTUIYXO ASKCKUUMQID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<LHUDJTUIYXO> OOALUTIRPVE;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private LHUDJTUIYXO TXMCJWAEWDF
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1007340", Offset = "0x1005D40", VA = "0x181007340")]
			[DebuggerHidden]
			public SEWMYIGJYVN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2BA3EC0", Offset = "0x2BA28C0", VA = "0x182BA3EC0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2BA4010", Offset = "0x2BA2A10", VA = "0x182BA4010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2BA4420", Offset = "0x2BA2E20", VA = "0x182BA4420")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2BA43D0", Offset = "0x2BA2DD0", VA = "0x182BA43D0")]
			private void SMGDSKUDEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2BA4470", Offset = "0x2BA2E70", VA = "0x182BA4470", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2BA3E20", Offset = "0x2BA2820", VA = "0x182BA3E20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LHUDJTUIYXO> ZQDDBXRQMIY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2BA3E20", Offset = "0x2BA2820", VA = "0x182BA3E20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> HYVGMVDYQZK;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, LHUDJTUIYXO> RQYLSXSUGPH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, LHUDJTUIYXO> YPITXGCEHIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2BA1770", Offset = "0x2BA0170", VA = "0x182BA1770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? FBSUCHZZBJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid LVYPECRPQWF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xF4A930", Offset = "0xF49330", VA = "0x180F4A930")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xF4ADB0", Offset = "0xF497B0", VA = "0x180F4ADB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCDB280", Offset = "0xCD9C80", VA = "0x180CDB280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<LHUDJTUIYXO> VYZCEOQMKJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCD76A0", Offset = "0xCD60A0", VA = "0x180CD76A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<LHUDJTUIYXO> IWZXLOEEXSO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2BA17C0", Offset = "0x2BA01C0", VA = "0x182BA17C0")]
			[IteratorStateMachine(typeof(SEWMYIGJYVN))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> AQTDHEINCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, EPTGYCLVVEQ> OKTWTRUJSYN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2A60", Offset = "0x2BA1460", VA = "0x182BA2A60")]
		public LHUDJTUIYXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2AC0", Offset = "0x2BA14C0", VA = "0x182BA2AC0")]
		public LHUDJTUIYXO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1CE0", Offset = "0x2BA06E0", VA = "0x182BA1CE0")]
		public static LHUDJTUIYXO OJSZIGDWQAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1FD0", Offset = "0x2BA09D0", VA = "0x182BA1FD0")]
		public static LHUDJTUIYXO SNDWWSCMARD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1840", Offset = "0x2BA0240", VA = "0x182BA1840")]
		public void Initialize(LHUDJTUIYXO from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA27B0", Offset = "0x2BA11B0", VA = "0x182BA27B0")]
		private LHUDJTUIYXO([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<RPEWIWWPNNN> c, [Optional] IEnumerable<LHUDJTUIYXO> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, EPTGYCLVVEQ>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1C10", Offset = "0x2BA0610", VA = "0x182BA1C10")]
		public static LHUDJTUIYXO New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<RPEWIWWPNNN> typeParameters, [Optional] IEnumerable<LHUDJTUIYXO> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, EPTGYCLVVEQ>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2020", Offset = "0x2BA0A20", VA = "0x182BA2020", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1BB0", Offset = "0x2BA05B0", VA = "0x182BA1BB0")]
		private string KCOOGOUJQAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1E00", Offset = "0x2BA0800", VA = "0x182BA1E00")]
		private static string PBPGKASNYEU(IEnumerable<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BA23E0", Offset = "0x2BA0DE0", VA = "0x182BA23E0")]
		private string XYNGZKSRWHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2110", Offset = "0x2BA0B10", VA = "0x182BA2110")]
		private string XPMXQPKXKOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1D30", Offset = "0x2BA0730", VA = "0x182BA1D30", Slot = "15")]
		public sealed override string ORYCYTPKZGA(IReadOnlyList<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1A40", Offset = "0x2BA0440", VA = "0x182BA1A40", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1A90", Offset = "0x2BA0490", VA = "0x182BA1A90")]
		public bool JWGGIVUYRNA([In] LHUDJTUIYXO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1700", Offset = "0x2BA0100", VA = "0x182BA1700", Slot = "18")]
		public bool Equals(LHUDJTUIYXO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1720", Offset = "0x2BA0120", VA = "0x182BA1720", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1EC0", Offset = "0x2BA08C0", VA = "0x182BA1EC0", Slot = "14")]
		protected override int QUCQYMWTKJV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2BA16F0", Offset = "0x2BA00F0", VA = "0x182BA16F0", Slot = "19")]
		private bool DCMYPPKIWLN([In] LHUDJTUIYXO other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class HJHICKUPDLX
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<CXXOCPTCXZR> FVGPCRMQTZO;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<LHUDJTUIYXO> PMONLHXWQHT;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, RPEWIWWPNNN> SHJNBAOGHIY;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> OLVORJDRCXG;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, EPTGYCLVVEQ> BJEBTJTYGDL;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class FCAGNKGEEYA : IEquatable<FCAGNKGEEYA>, WTBFSIOAEWL<FCAGNKGEEYA>, KOYRSGOUQRU
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CXXOCPTCXZR MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		private FCAGNKGEEYA(CXXOCPTCXZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C950", Offset = "0x2B9B350", VA = "0x182B9C950")]
		public static FCAGNKGEEYA New(CXXOCPTCXZR type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BC70", Offset = "0x2B5A670", VA = "0x182B5BC70", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C860", Offset = "0x2B9B260", VA = "0x182B9C860")]
		public bool JWGGIVUYRNA([In] FCAGNKGEEYA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C900", Offset = "0x2B9B300", VA = "0x182B9C900", Slot = "4")]
		public bool Equals(FCAGNKGEEYA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C8B0", Offset = "0x2B9B2B0", VA = "0x182B9C8B0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B74410", Offset = "0x2B72E10", VA = "0x182B74410", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C9B0", Offset = "0x2B9B3B0", VA = "0x182B9C9B0", Slot = "6")]
		public int XOGNHOYTMYT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C860", Offset = "0x2B9B260", VA = "0x182B9C860", Slot = "5")]
		private bool AXAYWLNRNRR([In] FCAGNKGEEYA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class RJHYOIAOFMF : IEquatable<RJHYOIAOFMF>, WTBFSIOAEWL<RJHYOIAOFMF>, KOYRSGOUQRU
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CXXOCPTCXZR MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		private RJHYOIAOFMF(CXXOCPTCXZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3470", Offset = "0x2BA1E70", VA = "0x182BA3470")]
		public static RJHYOIAOFMF New(CXXOCPTCXZR type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B5BC70", Offset = "0x2B5A670", VA = "0x182B5BC70", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C860", Offset = "0x2B9B260", VA = "0x182B9C860")]
		public bool JWGGIVUYRNA([In] RJHYOIAOFMF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C900", Offset = "0x2B9B300", VA = "0x182B9C900", Slot = "4")]
		public bool Equals(RJHYOIAOFMF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3420", Offset = "0x2BA1E20", VA = "0x182BA3420", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2B74410", Offset = "0x2B72E10", VA = "0x182B74410", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C9B0", Offset = "0x2B9B3B0", VA = "0x182B9C9B0", Slot = "6")]
		public int XOGNHOYTMYT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C860", Offset = "0x2B9B260", VA = "0x182B9C860", Slot = "5")]
		private bool WIEYDKRDKHO([In] RJHYOIAOFMF other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class EPTGYCLVVEQ : STCOSOBEHFT, IEquatable<EPTGYCLVVEQ>, WTBFSIOAEWL<EPTGYCLVVEQ>, KOYRSGOUQRU
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, FCAGNKGEEYA>> BFABQXNNUMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, RJHYOIAOFMF>> FSUKVTOXTMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C470", Offset = "0x2B9AE70", VA = "0x182B9C470")]
		private EPTGYCLVVEQ(IEnumerable<RPEWIWWPNNN> a, IEnumerable<KeyValuePair<string, FCAGNKGEEYA>> b, IEnumerable<KeyValuePair<string, RJHYOIAOFMF>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BF50", Offset = "0x2B9A950", VA = "0x182B9BF50")]
		public static EPTGYCLVVEQ New(IEnumerable<RPEWIWWPNNN> typeParameters, IEnumerable<KeyValuePair<string, FCAGNKGEEYA>> inputs, IEnumerable<KeyValuePair<string, RJHYOIAOFMF>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C160", Offset = "0x2B9AB60", VA = "0x182B9C160", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB20", Offset = "0x2B99520", VA = "0x182B9AB20", Slot = "15")]
		public sealed override string ORYCYTPKZGA(IReadOnlyList<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BAA0", Offset = "0x2B9A4A0", VA = "0x182B9BAA0")]
		private string BNMNYYRIZWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BDD0", Offset = "0x2B9A7D0", VA = "0x182B9BDD0")]
		private string MJSRMCIBJCW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BCA0", Offset = "0x2B9A6A0", VA = "0x182B9BCA0", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BCF0", Offset = "0x2B9A6F0", VA = "0x182B9BCF0")]
		public bool JWGGIVUYRNA([In] EPTGYCLVVEQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BC80", Offset = "0x2B9A680", VA = "0x182B9BC80", Slot = "18")]
		public bool Equals(EPTGYCLVVEQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BC30", Offset = "0x2B9A630", VA = "0x182B9BC30", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C080", Offset = "0x2B9AA80", VA = "0x182B9C080", Slot = "14")]
		protected sealed override int QUCQYMWTKJV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BC20", Offset = "0x2B9A620", VA = "0x182B9BC20", Slot = "19")]
		private bool DBRAPGOFFCB([In] EPTGYCLVVEQ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class RZIRSODFRIN : CXXOCPTCXZR, IEquatable<RZIRSODFRIN>, WTBFSIOAEWL<RZIRSODFRIN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3E00", Offset = "0x2BA2800", VA = "0x182BA3E00")]
		private RZIRSODFRIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3C20", Offset = "0x2BA2620", VA = "0x182BA3C20")]
		public static RZIRSODFRIN New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3D80", Offset = "0x2BA2780", VA = "0x182BA3D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3C90", Offset = "0x2BA2690", VA = "0x182BA3C90", Slot = "15")]
		public override string ORYCYTPKZGA(IReadOnlyList<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B80", Offset = "0x2BA2580", VA = "0x182BA3B80", Slot = "16")]
		public override int JBVOVENBDDJ(IReadOnlyList<CXXOCPTCXZR> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3DB0", Offset = "0x2BA27B0", VA = "0x182BA3DB0", Slot = "17")]
		public override bool VMYUNWFPEAG(IReadOnlyList<CXXOCPTCXZR> a, IReadOnlyList<CXXOCPTCXZR> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3BD0", Offset = "0x2BA25D0", VA = "0x182BA3BD0", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0")]
		public bool JWGGIVUYRNA([In] RZIRSODFRIN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xF58270", Offset = "0xF56C70", VA = "0x180F58270", Slot = "18")]
		public bool Equals(RZIRSODFRIN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B30", Offset = "0x2BA2530", VA = "0x182BA3B30", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0", Slot = "19")]
		private bool QPYSVYACOKY([In] RZIRSODFRIN other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, WTBFSIOAEWL<Property>, KOYRSGOUQRU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool MVIZSTHWGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int HKATMXQRWIP;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public CXXOCPTCXZR MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool PIZAZMOFAKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xE70C80", Offset = "0xE6F680", VA = "0x180E70C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool UWLHHMTKSSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1251240", Offset = "0x124FC40", VA = "0x181251240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2BA33C0", Offset = "0x2BA1DC0", VA = "0x182BA33C0")]
		private Property(CXXOCPTCXZR type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3090", Offset = "0x2BA1A90", VA = "0x182BA3090")]
		public static Property New(CXXOCPTCXZR type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3220", Offset = "0x2BA1C20", VA = "0x182BA3220", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2BA31D0", Offset = "0x2BA1BD0", VA = "0x182BA31D0")]
		private string RHZQWECZCVS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2E10", Offset = "0x2BA1810", VA = "0x182BA2E10")]
		private string CJHFTFWTFHW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2F90", Offset = "0x2BA1990", VA = "0x182BA2F90")]
		public bool JWGGIVUYRNA([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2EB0", Offset = "0x2BA18B0", VA = "0x182BA2EB0", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2E60", Offset = "0x2BA1860", VA = "0x182BA2E60", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2ED0", Offset = "0x2BA18D0", VA = "0x182BA2ED0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3120", Offset = "0x2BA1B20", VA = "0x182BA3120")]
		private int QUCQYMWTKJV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3300", Offset = "0x2BA1D00", VA = "0x182BA3300", Slot = "6")]
		public int XOGNHOYTMYT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2E00", Offset = "0x2BA1800", VA = "0x182BA2E00", Slot = "5")]
		private bool AGNUKZAKVKI([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class RWEQSVERNIW : CXXOCPTCXZR, IEquatable<RWEQSVERNIW>, WTBFSIOAEWL<RWEQSVERNIW>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3B10", Offset = "0x2BA2510", VA = "0x182BA3B10")]
		private RWEQSVERNIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2BA39F0", Offset = "0x2BA23F0", VA = "0x182BA39F0")]
		public static RWEQSVERNIW New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3AE0", Offset = "0x2BA24E0", VA = "0x182BA3AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3A60", Offset = "0x2BA2460", VA = "0x182BA3A60", Slot = "15")]
		public override string ORYCYTPKZGA(IReadOnlyList<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2BA39A0", Offset = "0x2BA23A0", VA = "0x182BA39A0", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0")]
		public bool JWGGIVUYRNA([In] RWEQSVERNIW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF58270", Offset = "0xF56C70", VA = "0x180F58270", Slot = "18")]
		public bool Equals(RWEQSVERNIW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3950", Offset = "0x2BA2350", VA = "0x182BA3950", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0", Slot = "19")]
		private bool VNXMISSMYLT([In] RWEQSVERNIW other)
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
	public sealed class OZYMFHTYXYU : CXXOCPTCXZR, IEquatable<OZYMFHTYXYU>, WTBFSIOAEWL<OZYMFHTYXYU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool AMKGSQTFBGG
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2CE0", Offset = "0x2BA16E0", VA = "0x182BA2CE0", Slot = "9")]
		public sealed override CXXOCPTCXZR XXUTACXLPBW(IReadOnlyDictionary<string, CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2CB0", Offset = "0x2BA16B0", VA = "0x182BA2CB0", Slot = "11")]
		public sealed override void RWSDLIOLTVW(Action<CXXOCPTCXZR> a, Action<CXXOCPTCXZR> b, Action<CXXOCPTCXZR> c, Action<CXXOCPTCXZR> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2DC0", Offset = "0x2BA17C0", VA = "0x182BA2DC0")]
		private OZYMFHTYXYU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2C10", Offset = "0x2BA1610", VA = "0x182BA2C10")]
		public static OZYMFHTYXYU New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2BC0", Offset = "0x2BA15C0", VA = "0x182BA2BC0", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0")]
		public bool JWGGIVUYRNA([In] OZYMFHTYXYU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xF58270", Offset = "0xF56C70", VA = "0x180F58270", Slot = "18")]
		public bool Equals(OZYMFHTYXYU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2B70", Offset = "0x2BA1570", VA = "0x182BA2B70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2C90", Offset = "0x2BA1690", VA = "0x182BA2C90", Slot = "14")]
		protected sealed override int QUCQYMWTKJV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0", Slot = "19")]
		private bool JOXLMVCXOLH([In] OZYMFHTYXYU other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class STCOSOBEHFT : CXXOCPTCXZR
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<RPEWIWWPNNN> WGVYUYPSGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2BA44B0", Offset = "0x2BA2EB0", VA = "0x182BA44B0")]
		public void Initialize(STCOSOBEHFT from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4640", Offset = "0x2BA3040", VA = "0x182BA4640")]
		protected STCOSOBEHFT(IEnumerable<RPEWIWWPNNN> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool JWGGIVUYRNA([In] CXXOCPTCXZR other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA44E0", Offset = "0x2BA2EE0", VA = "0x182BA44E0")]
		protected bool JWGGIVUYRNA([In] STCOSOBEHFT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4540", Offset = "0x2BA2F40", VA = "0x182BA4540", Slot = "14")]
		protected override int QUCQYMWTKJV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA45C0", Offset = "0x2BA2FC0", VA = "0x182BA45C0")]
		protected int ZMBJOIEAVHH(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class RPEWIWWPNNN : CXXOCPTCXZR, IEquatable<RPEWIWWPNNN>, WTBFSIOAEWL<RPEWIWWPNNN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public CXXOCPTCXZR ITCDROFPFBN
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3890", Offset = "0x2BA2290", VA = "0x182BA3890")]
		private RPEWIWWPNNN(string a, [Optional] CXXOCPTCXZR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3610", Offset = "0x2BA2010", VA = "0x182BA3610")]
		public static RPEWIWWPNNN New(string name, [Optional] CXXOCPTCXZR constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3790", Offset = "0x2BA2190", VA = "0x182BA3790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BA35C0", Offset = "0x2BA1FC0", VA = "0x182BA35C0", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BA34D0", Offset = "0x2BA1ED0", VA = "0x182BA34D0")]
		public bool JWGGIVUYRNA([In] RPEWIWWPNNN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3570", Offset = "0x2BA1F70", VA = "0x182BA3570", Slot = "18")]
		public bool Equals(RPEWIWWPNNN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3520", Offset = "0x2BA1F20", VA = "0x182BA3520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3710", Offset = "0x2BA2110", VA = "0x182BA3710", Slot = "14")]
		protected override int QUCQYMWTKJV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3820", Offset = "0x2BA2220", VA = "0x182BA3820", Slot = "13")]
		public override int XOGNHOYTMYT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2BA34D0", Offset = "0x2BA1ED0", VA = "0x182BA34D0", Slot = "19")]
		private bool EHYCAYVZCUA([In] RPEWIWWPNNN other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class ARGYTOTHGVJ : CXXOCPTCXZR, IEquatable<ARGYTOTHGVJ>, WTBFSIOAEWL<ARGYTOTHGVJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A660", Offset = "0x2B99060", VA = "0x182B9A660")]
		private ARGYTOTHGVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A480", Offset = "0x2B98E80", VA = "0x182B9A480")]
		public static ARGYTOTHGVJ New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A5E0", Offset = "0x2B98FE0", VA = "0x182B9A5E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A4F0", Offset = "0x2B98EF0", VA = "0x182B9A4F0", Slot = "15")]
		public override string ORYCYTPKZGA(IReadOnlyList<CXXOCPTCXZR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3E0", Offset = "0x2B98DE0", VA = "0x182B9A3E0", Slot = "16")]
		public override int JBVOVENBDDJ(IReadOnlyList<CXXOCPTCXZR> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A610", Offset = "0x2B99010", VA = "0x182B9A610", Slot = "17")]
		public override bool VMYUNWFPEAG(IReadOnlyList<CXXOCPTCXZR> a, IReadOnlyList<CXXOCPTCXZR> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A430", Offset = "0x2B98E30", VA = "0x182B9A430", Slot = "12")]
		public override bool JWGGIVUYRNA([In] CXXOCPTCXZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0")]
		public bool JWGGIVUYRNA([In] ARGYTOTHGVJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xF58270", Offset = "0xF56C70", VA = "0x180F58270", Slot = "18")]
		public bool Equals(ARGYTOTHGVJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A380", Offset = "0x2B98D80", VA = "0x182B9A380", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A3D0", Offset = "0x2B98DD0", VA = "0x182B9A3D0", Slot = "19")]
		private bool JBTTOTQWTXG([In] ARGYTOTHGVJ other)
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
			public readonly CXXOCPTCXZR CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x10DE880", Offset = "0x10DD280", VA = "0x1810DE880")]
			internal Impl(CXXOCPTCXZR circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2B9B0D0", Offset = "0x2B99AD0", VA = "0x182B9B0D0")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B000", Offset = "0x2B99A00", VA = "0x182B9B000")]
		public static CircuitTypeOrString VFJBORFPFZV(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B070", Offset = "0x2B99A70", VA = "0x182B9B070")]
		public static CircuitTypeOrString VFJBORFPFZV(CXXOCPTCXZR a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AE30", Offset = "0x2B99830", VA = "0x182B9AE30")]
		public CXXOCPTCXZR BXFMJSBEBGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AED0", Offset = "0x2B998D0", VA = "0x182B9AED0")]
		public static CXXOCPTCXZR[] HBYBFXLSXOB(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly KPKGUYBGIMS _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xEBA9B0", Offset = "0xEB93B0", VA = "0x180EBA9B0")]
		private ClassFactoryBaseClasses(KPKGUYBGIMS data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x10DEEF0", Offset = "0x10DD8F0", VA = "0x1810DEEF0")]
		public static ClassFactoryBaseClasses New(KPKGUYBGIMS data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B100", Offset = "0x2B99B00", VA = "0x182B9B100")]
		public ClassFactoryBaseClasses MHJFCORZKBW(LHUDJTUIYXO a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x186A3A0", Offset = "0x1868DA0", VA = "0x18186A3A0")]
		public ClassFactoryProps ZRJTHEOFSHN()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B210", Offset = "0x2B99C10", VA = "0x182B9B210")]
		public ClassFactoryProps RYUCMIERNHG(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B1C0", Offset = "0x2B99BC0", VA = "0x182B9B1C0")]
		public LHUDJTUIYXO QUSLSCNGWNP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class KPKGUYBGIMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? LVYPECRPQWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string KPIDBUYRLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<RPEWIWWPNNN> WGVYUYPSGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<LHUDJTUIYXO> VYZCEOQMKJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> AQTDHEINCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, EPTGYCLVVEQ>> OKTWTRUJSYN;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2BA1560", Offset = "0x2B9FF60", VA = "0x182BA1560")]
		private KPKGUYBGIMS([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2BA13B0", Offset = "0x2B9FDB0", VA = "0x182BA13B0")]
		public static KPKGUYBGIMS New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly KPKGUYBGIMS _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xEBA9B0", Offset = "0xEB93B0", VA = "0x180EBA9B0")]
		private ClassFactoryFuncs(KPKGUYBGIMS data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x10DEEF0", Offset = "0x10DD8F0", VA = "0x1810DEEF0")]
		public static ClassFactoryFuncs New(KPKGUYBGIMS data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B270", Offset = "0x2B99C70", VA = "0x182B9B270")]
		public LHUDJTUIYXO QUSLSCNGWNP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly KPKGUYBGIMS _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xEBA9B0", Offset = "0xEB93B0", VA = "0x180EBA9B0")]
		public ClassFactoryProps(KPKGUYBGIMS data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B400", Offset = "0x2B99E00", VA = "0x182B9B400")]
		public ClassFactoryProps RYUCMIERNHG(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x186A3A0", Offset = "0x1868DA0", VA = "0x18186A3A0")]
		public ClassFactoryFuncs WIOVLSEMPXY()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B3C0", Offset = "0x2B99DC0", VA = "0x182B9B3C0")]
		public LHUDJTUIYXO QUSLSCNGWNP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly KPKGUYBGIMS _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xEBA9B0", Offset = "0xEB93B0", VA = "0x180EBA9B0")]
		private ClassFactoryTypeParams(KPKGUYBGIMS data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B870", Offset = "0x2B9A270", VA = "0x182B9B870")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B590", Offset = "0x2B99F90", VA = "0x182B9B590")]
		public ClassFactoryTypeParams FURSIYSAZPQ(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x186A3A0", Offset = "0x1868DA0", VA = "0x18186A3A0")]
		public ClassFactoryBaseClasses DACLQJZHODE()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B830", Offset = "0x2B9A230", VA = "0x182B9B830")]
		public ClassFactoryBaseClasses MHJFCORZKBW(LHUDJTUIYXO a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BA40", Offset = "0x2B9A440", VA = "0x182B9BA40")]
		public LHUDJTUIYXO QUSLSCNGWNP()
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
