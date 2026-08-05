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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RVNMAEXWNBU : IEquatable<RVNMAEXWNBU>, HOAFHMGXMKA<RVNMAEXWNBU>, SJJAQHLWCIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool LNLSZPWSOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool UAWMDTXFDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int CTIBWTMIENK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind OHCPFBUROHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? VPQUBUWZAJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x29083D0", Offset = "0x2906BD0", VA = "0x1829083D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual RVNMAEXWNBU FPBIMHJHITC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool DJAVVACTQVL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29087E0", Offset = "0x2906FE0", VA = "0x1829087E0")]
		public static void RUCBQSMBUXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
		protected RVNMAEXWNBU(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x29085F0", Offset = "0x2906DF0", VA = "0x1829085F0")]
		public static RVNMAEXWNBU New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0")]
		protected static a IPBSVLAJXXQ<a>(a a) where a : RVNMAEXWNBU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB719A0", Offset = "0xB701A0", VA = "0x180B719A0", Slot = "9")]
		public virtual RVNMAEXWNBU LWEJOOYLGYZ(IReadOnlyDictionary<string, RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x29085C0", Offset = "0x2906DC0", VA = "0x1829085C0", Slot = "11")]
		public virtual void JBYPHMIFXDN(Action<RVNMAEXWNBU> a, Action<RVNMAEXWNBU> b, Action<RVNMAEXWNBU> c, Action<RVNMAEXWNBU> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2908900", Offset = "0x2907100", VA = "0x182908900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2908A70", Offset = "0x2907270", VA = "0x182908A70", Slot = "12")]
		public virtual bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29084E0", Offset = "0x2906CE0", VA = "0x1829084E0", Slot = "4")]
		public bool Equals(RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2908490", Offset = "0x2906C90", VA = "0x182908490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29088C0", Offset = "0x29070C0", VA = "0x1829088C0")]
		public static bool SSVDESVOTBX(RVNMAEXWNBU a, RVNMAEXWNBU b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2908B10", Offset = "0x2907310", VA = "0x182908B10")]
		public static bool XUHFAYKFXBY(RVNMAEXWNBU a, RVNMAEXWNBU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2908510", Offset = "0x2906D10", VA = "0x182908510", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x29087B0", Offset = "0x2906FB0", VA = "0x1829087B0", Slot = "13")]
		public virtual int XGFMDQKYFPY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x29087B0", Offset = "0x2906FB0", VA = "0x1829087B0", Slot = "14")]
		protected virtual int RCCMOAIZDMK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3794650", Offset = "0x3792E50", VA = "0x183794650")]
		public b STJMHVVDCIE<b>() where b : RVNMAEXWNBU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28FF940", Offset = "0x28FE140", VA = "0x1828FF940", Slot = "15")]
		public virtual string KGDEWKBNWMP(IReadOnlyList<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2908870", Offset = "0x2907070", VA = "0x182908870", Slot = "16")]
		public virtual int SLVQIIXSOHO(IReadOnlyList<RVNMAEXWNBU> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2908440", Offset = "0x2906C40", VA = "0x182908440", Slot = "17")]
		public virtual bool DRUHTKYRDUB(IReadOnlyList<RVNMAEXWNBU> a, IReadOnlyList<RVNMAEXWNBU> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2908670", Offset = "0x2906E70", VA = "0x182908670")]
		public QBCOQCAPQYZ QCOICWPBMRZ(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2908660", Offset = "0x2906E60", VA = "0x182908660")]
		public QBCOQCAPQYZ QCOICWPBMRZ(params RVNMAEXWNBU[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2908660", Offset = "0x2906E60", VA = "0x182908660")]
		public QBCOQCAPQYZ QCOICWPBMRZ(IEnumerable<RVNMAEXWNBU> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface BZZUHUVHMDL<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a XIVWESMQEHN(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b IXYIFXJTXOV([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind XUESKCVFQJF([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates DKEPGKMRJNE(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface SJJAQHLWCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int XGFMDQKYFPY(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class XGFMDQKYFPY
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class TWQMYBSWLNI<a> where a : SJJAQHLWCIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int QETAUYBNNJN;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TWQMYBSWLNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5FB3580", Offset = "0x5FB1D80", VA = "0x185FB3580")]
			internal int TDADOIJBHOD(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HGRDSJGYUPK<a, b> where b : SJJAQHLWCIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int QETAUYBNNJN;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public HGRDSJGYUPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4F33A40", Offset = "0x4F32240", VA = "0x184F33A40")]
			internal int TDADOIJBHOD(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class EUNRRBBYLTS<a> where a : SJJAQHLWCIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int QETAUYBNNJN;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public EUNRRBBYLTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4773F20", Offset = "0x4772720", VA = "0x184773F20")]
			internal int IMHCROSQTWI(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C17CE0", Offset = "0x3C164E0", VA = "0x183C17CE0")]
		public static int BPDYUWUFINH<a>(this IEnumerable<a> a, int b = 0) where a : SJJAQHLWCIF
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C17C10", Offset = "0x3C16410", VA = "0x183C17C10")]
		public static int BPDYUWUFINH<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : SJJAQHLWCIF
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C17CE0", Offset = "0x3C164E0", VA = "0x183C17CE0")]
		public static int YGEHXENJWEA<d>(this IEnumerable<d> a, int b = 0) where d : SJJAQHLWCIF
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : BZZUHUVHMDL<TDirectedType, RVNMAEXWNBU, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x410A6D0", Offset = "0x4108ED0", VA = "0x18410A6D0")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6163320", Offset = "0x6161B20", VA = "0x186163320")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class KSRGINVOUFG
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ATHGQBHXDEI<a, b, c> where c : BZZUHUVHMDL<a, RVNMAEXWNBU, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public RVNMAEXWNBU IUBUTNIKHIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<RVNMAEXWNBU> YVHBIXIJSSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public RVNMAEXWNBU QSADLXLMBYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<RVNMAEXWNBU> CNWLNILBHFS;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public ATHGQBHXDEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x54F09E0", Offset = "0x54EF1E0", VA = "0x1854F09E0")]
			internal bool FQSWVCJPUHU([In] TypeSys<a, b, c> self_, RVNMAEXWNBU a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x54F0840", Offset = "0x54EF040", VA = "0x1854F0840")]
			internal bool FQNPXVPSKWL([In] TypeSys<a, b, c> self_, RVNMAEXWNBU a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x54F0670", Offset = "0x54EEE70", VA = "0x1854F0670")]
			internal bool FPXVGBIAIOK([In] TypeSys<a, b, c> self_, RVNMAEXWNBU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class IDVFDYFJZFB<a, b, c> where c : BZZUHUVHMDL<a, RVNMAEXWNBU, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public RVNMAEXWNBU UDIDJMEDTFA;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public IDVFDYFJZFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4FFDD10", Offset = "0x4FFC510", VA = "0x184FFDD10")]
			internal bool FQDCDIBXRZT([In] TypeSys<a, b, c> self__, RVNMAEXWNBU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MEBNJVUIDKG<a, b, c> where c : BZZUHUVHMDL<a, RVNMAEXWNBU, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b GCIIEAQCVVB;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public MEBNJVUIDKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x57E6BC0", Offset = "0x57E53C0", VA = "0x1857E6BC0")]
			internal RVNMAEXWNBU LWCSSOWSMGN([In] TypeSys<a, b, c> self_, [In] b root_, RVNMAEXWNBU a, RVNMAEXWNBU b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class CDMVXWQLFYV<a, b, c> where c : BZZUHUVHMDL<a, RVNMAEXWNBU, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CIHDQNZBWGJ SHFGBYFPCJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CIHDQNZBWGJ LWPNZZDDIFT;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CDMVXWQLFYV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3D6C860", Offset = "0x3D6B060", VA = "0x183D6C860")]
			internal a LVMYAUPAJYM([In] TypeSys<a, b, c> self_, IOKind a, CIHDQNZBWGJ b, CIHDQNZBWGJ c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class OUXPRDSBVGI<a, b, c> where c : BZZUHUVHMDL<a, RVNMAEXWNBU, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<CIHDQNZBWGJ> AUCIHYZZRCB;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OUXPRDSBVGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x59EEED0", Offset = "0x59ED6D0", VA = "0x1859EEED0")]
			internal bool CZQYAKRVMXE(bool a, CIHDQNZBWGJ b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] PACFIPBDWNX;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37A9730", Offset = "0x37A7F30", VA = "0x1837A9730")]
		public static bool XRAKMDPNPSM<a, b, c>([In] this TypeSys<a, b, c> _, RVNMAEXWNBU a) where c : BZZUHUVHMDL<a, RVNMAEXWNBU, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37A11D0", Offset = "0x379F9D0", VA = "0x1837A11D0")]
		public static bool NYYLRATTQWF<d, e, f>([In] this TypeSys<d, e, f> _, RVNMAEXWNBU a) where f : BZZUHUVHMDL<d, RVNMAEXWNBU, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37A1030", Offset = "0x379F830", VA = "0x1837A1030")]
		public static bool LNASNXICJRB<g, h, i>([In] this TypeSys<g, h, i> self, RVNMAEXWNBU a, RVNMAEXWNBU b) where i : BZZUHUVHMDL<g, RVNMAEXWNBU, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x379FEC0", Offset = "0x379E6C0", VA = "0x18379FEC0")]
		private static bool FVVGKHARWPA<j, k, l>([In] this TypeSys<j, k, l> self, RVNMAEXWNBU a, RVNMAEXWNBU b, IReadOnlyList<RVNMAEXWNBU> c, IReadOnlyList<RVNMAEXWNBU> d) where l : BZZUHUVHMDL<j, RVNMAEXWNBU, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x37A1AD0", Offset = "0x37A02D0", VA = "0x1837A1AD0")]
		public static RVNMAEXWNBU WEWDSAYNDHS<m, n, o>([In] this TypeSys<m, n, o> self, n a, RVNMAEXWNBU b, RVNMAEXWNBU c) where o : BZZUHUVHMDL<m, RVNMAEXWNBU, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37A1E20", Offset = "0x37A0620", VA = "0x1837A1E20")]
		public static p WEWDSAYNDHS<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : BZZUHUVHMDL<p, RVNMAEXWNBU, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37A16D0", Offset = "0x379FED0", VA = "0x1837A16D0")]
		private static List<w> RIBXHVBQWIS<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : BZZUHUVHMDL<t, RVNMAEXWNBU, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x379FD20", Offset = "0x379E520", VA = "0x18379FD20")]
		private static ba EGIFFDHLRXW<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class IDPKTWAHEBV
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static RVNMAEXWNBU LOEZQQZYCEI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2902F90", Offset = "0x2901790", VA = "0x182902F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static RVNMAEXWNBU FHLJFTZBPQO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2903160", Offset = "0x2901960", VA = "0x182903160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static RVNMAEXWNBU LKFZHWRCATL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2903110", Offset = "0x2901910", VA = "0x182903110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static RVNMAEXWNBU KNCYBBSERSJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x29035F0", Offset = "0x2901DF0", VA = "0x1829035F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static RVNMAEXWNBU MJMIKWMINAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2903810", Offset = "0x2902010", VA = "0x182903810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static RVNMAEXWNBU SKKKZXBSTZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2902FE0", Offset = "0x29017E0", VA = "0x182902FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static RVNMAEXWNBU DHYIBTDGTPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2903240", Offset = "0x2901A40", VA = "0x182903240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static RVNMAEXWNBU ABTLKLPBVWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x29030C0", Offset = "0x29018C0", VA = "0x1829030C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x29034C0", Offset = "0x2901CC0", VA = "0x1829034C0")]
		public static QBCOQCAPQYZ PWHTKNBJDRX([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2903030", Offset = "0x2901830", VA = "0x182903030")]
		public static QBCOQCAPQYZ FNZUZNNYKSB(IEnumerable<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2903430", Offset = "0x2901C30", VA = "0x182903430")]
		public static QBCOQCAPQYZ PDYZYHFXPBR(IEnumerable<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2903290", Offset = "0x2901A90", VA = "0x182903290")]
		public static QBCOQCAPQYZ PDYZYHFXPBR(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x29031B0", Offset = "0x29019B0", VA = "0x1829031B0")]
		public static QBCOQCAPQYZ NPSZYXNDHAK(IEnumerable<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2903640", Offset = "0x2901E40", VA = "0x182903640")]
		public static CQUYLEJRJJU RHFHGTVSHLH(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class QBCOQCAPQYZ : RVNMAEXWNBU, IEquatable<QBCOQCAPQYZ>, HOAFHMGXMKA<QBCOQCAPQYZ>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WYCMMTINYUJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, RVNMAEXWNBU> NHAXMLVLUFR;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WYCMMTINYUJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x290B6B0", Offset = "0x2909EB0", VA = "0x18290B6B0")]
			internal RVNMAEXWNBU IDKXCRFEDNB(RVNMAEXWNBU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RVNMAEXWNBU AAIYOYMHWSR
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override RVNMAEXWNBU FPBIMHJHITC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<RVNMAEXWNBU> GBNIQRLAYPG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool DJAVVACTQVL
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2907800", Offset = "0x2906000", VA = "0x182907800", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2907BE0", Offset = "0x29063E0", VA = "0x182907BE0", Slot = "9")]
		public sealed override RVNMAEXWNBU LWEJOOYLGYZ(IReadOnlyDictionary<string, RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2907980", Offset = "0x2906180", VA = "0x182907980", Slot = "11")]
		public sealed override void JBYPHMIFXDN(Action<RVNMAEXWNBU> a, Action<RVNMAEXWNBU> b, Action<RVNMAEXWNBU> c, Action<RVNMAEXWNBU> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2907F70", Offset = "0x2906770", VA = "0x182907F70")]
		private QBCOQCAPQYZ(RVNMAEXWNBU a, IEnumerable<RVNMAEXWNBU> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2907D10", Offset = "0x2906510", VA = "0x182907D10")]
		public static QBCOQCAPQYZ New(RVNMAEXWNBU originalType, IEnumerable<RVNMAEXWNBU> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2907E40", Offset = "0x2906640", VA = "0x182907E40", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2907F20", Offset = "0x2906720", VA = "0x182907F20", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2907E80", Offset = "0x2906680", VA = "0x182907E80")]
		public bool WWCFUGHNLCB([In] QBCOQCAPQYZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2907960", Offset = "0x2906160", VA = "0x182907960", Slot = "18")]
		public bool Equals(QBCOQCAPQYZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2907910", Offset = "0x2906110", VA = "0x182907910", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2907D90", Offset = "0x2906590", VA = "0x182907D90", Slot = "14")]
		protected override int RCCMOAIZDMK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2907D00", Offset = "0x2906500", VA = "0x182907D00", Slot = "19")]
		private bool MNUBLQIRKLK([In] QBCOQCAPQYZ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class FRRAPOOAKJW : RVNMAEXWNBU, IEquatable<FRRAPOOAKJW>, HOAFHMGXMKA<FRRAPOOAKJW>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2902C30", Offset = "0x2901430", VA = "0x182902C30")]
		private FRRAPOOAKJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2902AD0", Offset = "0x29012D0", VA = "0x182902AD0")]
		public static FRRAPOOAKJW New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2902B40", Offset = "0x2901340", VA = "0x182902B40", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2902A40", Offset = "0x2901240", VA = "0x182902A40", Slot = "15")]
		public sealed override string KGDEWKBNWMP(IReadOnlyList<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2902BA0", Offset = "0x29013A0", VA = "0x182902BA0")]
		private static string WSTKJNPWGTD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2902BE0", Offset = "0x29013E0", VA = "0x182902BE0", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790")]
		public bool WWCFUGHNLCB([In] FRRAPOOAKJW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xCD2ED0", Offset = "0xCD16D0", VA = "0x180CD2ED0", Slot = "18")]
		public bool Equals(FRRAPOOAKJW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x29029F0", Offset = "0x29011F0", VA = "0x1829029F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790", Slot = "19")]
		private bool BCNXUHCPWDV([In] FRRAPOOAKJW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class KJNBTFAWGXL
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class TPKTMYRKYMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public RVNMAEXWNBU DQGKQVKQLQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<RVNMAEXWNBU, QBCOQCAPQYZ> HFYOFAKQRMZ;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TPKTMYRKYMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2908B50", Offset = "0x2907350", VA = "0x182908B50")]
			internal QBCOQCAPQYZ AYHUMHJQQHZ(RVNMAEXWNBU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class TPQAKFLIHXL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RVNMAEXWNBU RWPKNUIJUEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<RVNMAEXWNBU, QBCOQCAPQYZ> HUZSJHMQVTF;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TPQAKFLIHXL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2908CD0", Offset = "0x29074D0", VA = "0x182908CD0")]
			internal QBCOQCAPQYZ JSPZEBVWVTD(RVNMAEXWNBU a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2906260", Offset = "0x2904A60", VA = "0x182906260")]
		public static IEnumerable<CIHDQNZBWGJ> UXTONQBZBUF(this CIHDQNZBWGJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2904D10", Offset = "0x2903510", VA = "0x182904D10")]
		private static IEnumerable<CIHDQNZBWGJ> LNWNKHRCGID(this CIHDQNZBWGJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2906C10", Offset = "0x2905410", VA = "0x182906C10")]
		public static (RVNMAEXWNBU, IReadOnlyList<RVNMAEXWNBU>, bool) YSQLBKYMNQN(this RVNMAEXWNBU a, [Optional] IReadOnlyList<RVNMAEXWNBU> b)
		{
			return default((RVNMAEXWNBU, IReadOnlyList<RVNMAEXWNBU>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2905390", Offset = "0x2903B90", VA = "0x182905390")]
		public static TypeKind QWKVJUXSCVA(this RVNMAEXWNBU a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2903F10", Offset = "0x2902710", VA = "0x182903F10")]
		private static RVNMAEXWNBU ConvertClassesToIntersections(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x29049B0", Offset = "0x29031B0", VA = "0x1829049B0")]
		private static RVNMAEXWNBU DistributeUnionIntoIntersection(this QBCOQCAPQYZ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2904540", Offset = "0x2902D40", VA = "0x182904540")]
		private static RVNMAEXWNBU DistributeIntersectionIntoIntersection(this QBCOQCAPQYZ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2904850", Offset = "0x2903050", VA = "0x182904850")]
		private static RVNMAEXWNBU DistributeIntoIntersection(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2904E60", Offset = "0x2903660", VA = "0x182904E60")]
		private static bool OtherIsAssignableToOther(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes, RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2906490", Offset = "0x2904C90", VA = "0x182906490")]
		private static bool UnionIsAssignableToOther(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes, RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2904FF0", Offset = "0x29037F0", VA = "0x182904FF0")]
		private static bool OtherIsAssignableToUnion(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes, RVNMAEXWNBU union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x29067B0", Offset = "0x2904FB0", VA = "0x1829067B0")]
		private static bool UnionIsAssignableToUnion(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes, RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2906060", Offset = "0x2904860", VA = "0x182906060")]
		public static RVNMAEXWNBU RemoveCommonTypesFromIntersectionDistribution(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x29053C0", Offset = "0x2903BC0", VA = "0x1829053C0")]
		public static RVNMAEXWNBU RemoveCommonTypesFromIntersectionDistributionInternal(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2906190", Offset = "0x2904990", VA = "0x182906190")]
		public static RVNMAEXWNBU SimplifyIntersectionUnion(this RVNMAEXWNBU self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2904CC0", Offset = "0x29034C0", VA = "0x182904CC0")]
		public static IEnumerable<RVNMAEXWNBU> GBNIQRLAYPG(this RVNMAEXWNBU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2904DD0", Offset = "0x29035D0", VA = "0x182904DD0")]
		public static IEnumerable<RVNMAEXWNBU> ODCXWPMMDJZ(this RVNMAEXWNBU a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class CIHDQNZBWGJ : MSBRRPXLEVU, IEquatable<CIHDQNZBWGJ>, HOAFHMGXMKA<CIHDQNZBWGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class WDTQEEPWHSM : IEnumerable<CIHDQNZBWGJ>, IEnumerable, IEnumerator<CIHDQNZBWGJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private CIHDQNZBWGJ VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public CIHDQNZBWGJ BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<CIHDQNZBWGJ> YLHXGKHQDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private CIHDQNZBWGJ UMXFMPDYOGU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<CIHDQNZBWGJ> YLSLAXVKWGZ;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private CIHDQNZBWGJ UYTGTNAGTAY
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
			[DebuggerHidden]
			public WDTQEEPWHSM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x290B4C0", Offset = "0x2909CC0", VA = "0x18290B4C0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x290B100", Offset = "0x2909900", VA = "0x18290B100", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x290B610", Offset = "0x2909E10", VA = "0x18290B610")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x290B660", Offset = "0x2909E60", VA = "0x18290B660")]
			private void YQUQFKFMWJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x290B020", Offset = "0x2909820", VA = "0x18290B020", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x290B060", Offset = "0x2909860", VA = "0x18290B060", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CIHDQNZBWGJ> WUXMWPATEVV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x290B060", Offset = "0x2909860", VA = "0x18290B060", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> GLWRMASWCNP;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, CIHDQNZBWGJ> FNWXZOLXVMK;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, CIHDQNZBWGJ> MPBTMJTJLPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2900B90", Offset = "0x28FF390", VA = "0x182900B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? VPQUBUWZAJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid VXYCUIZXFBQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCD8870", Offset = "0xCD7070", VA = "0x180CD8870")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7B20", Offset = "0xCD6320", VA = "0x180CD7B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAACAD0", Offset = "0xAAB2D0", VA = "0x180AACAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<CIHDQNZBWGJ> MQYUTMVJOPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<CIHDQNZBWGJ> ZDCBGGJWIJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2900CD0", Offset = "0x28FF4D0", VA = "0x182900CD0")]
			[IteratorStateMachine(typeof(WDTQEEPWHSM))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> SISXIIKSZKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB3290", Offset = "0xAB1A90", VA = "0x180AB3290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, AWODIOOLNAH> KSWTSWUPETS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAB32A0", Offset = "0xAB1AA0", VA = "0x180AB32A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x29015B0", Offset = "0x28FFDB0", VA = "0x1829015B0")]
		public CIHDQNZBWGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2901500", Offset = "0x28FFD00", VA = "0x182901500")]
		public CIHDQNZBWGJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2900A30", Offset = "0x28FF230", VA = "0x182900A30")]
		public static CIHDQNZBWGJ QNAFJDNHMGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2900210", Offset = "0x28FEA10", VA = "0x182900210")]
		public static CIHDQNZBWGJ DCPIDDRREJS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x29006A0", Offset = "0x28FEEA0", VA = "0x1829006A0")]
		public void Initialize(CIHDQNZBWGJ from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2901260", Offset = "0x28FFA60", VA = "0x182901260")]
		private CIHDQNZBWGJ([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<CQUYLEJRJJU> c, [Optional] IEnumerable<CIHDQNZBWGJ> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, AWODIOOLNAH>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2900960", Offset = "0x28FF160", VA = "0x182900960")]
		public static CIHDQNZBWGJ New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<CQUYLEJRJJU> typeParameters, [Optional] IEnumerable<CIHDQNZBWGJ> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, AWODIOOLNAH>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2900BE0", Offset = "0x28FF3E0", VA = "0x182900BE0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2900640", Offset = "0x28FEE40", VA = "0x182900640")]
		private string GPCZOYVYYEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2900260", Offset = "0x28FEA60", VA = "0x182900260")]
		private static string EQGCJPQVSCT(IEnumerable<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2900390", Offset = "0x28FEB90", VA = "0x182900390")]
		private string FWFGKDGOMSC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2900ED0", Offset = "0x28FF6D0", VA = "0x182900ED0")]
		private string YEIKWTOAIWH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2900890", Offset = "0x28FF090", VA = "0x182900890", Slot = "15")]
		public sealed override string KGDEWKBNWMP(IReadOnlyList<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2900D60", Offset = "0x28FF560", VA = "0x182900D60", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2900DB0", Offset = "0x28FF5B0", VA = "0x182900DB0")]
		public bool WWCFUGHNLCB([In] CIHDQNZBWGJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2900370", Offset = "0x28FEB70", VA = "0x182900370", Slot = "18")]
		public bool Equals(CIHDQNZBWGJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2900320", Offset = "0x28FEB20", VA = "0x182900320", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2900A80", Offset = "0x28FF280", VA = "0x182900A80", Slot = "14")]
		protected override int RCCMOAIZDMK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2900D50", Offset = "0x28FF550", VA = "0x182900D50", Slot = "19")]
		private bool WHEVZADCZJY([In] CIHDQNZBWGJ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class RQNYJVSYSOI
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<RVNMAEXWNBU> URCJQBKVUVB;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<CIHDQNZBWGJ> SNNPRWUTUZI;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, CQUYLEJRJJU> QUWTKFQESWL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> GQIVZWVCPWZ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, AWODIOOLNAH> PJMFBTTBCLO;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class VSFALRLGUNX : IEquatable<VSFALRLGUNX>, HOAFHMGXMKA<VSFALRLGUNX>, SJJAQHLWCIF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RVNMAEXWNBU QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		private VSFALRLGUNX(RVNMAEXWNBU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x290AFC0", Offset = "0x29097C0", VA = "0x18290AFC0")]
		public static VSFALRLGUNX New(RVNMAEXWNBU type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x28B64D0", Offset = "0x28B4CD0", VA = "0x1828B64D0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2907160", Offset = "0x2905960", VA = "0x182907160")]
		public bool WWCFUGHNLCB([In] VSFALRLGUNX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2907060", Offset = "0x2905860", VA = "0x182907060", Slot = "4")]
		public bool Equals(VSFALRLGUNX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x290AF70", Offset = "0x2909770", VA = "0x18290AF70", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28DAA10", Offset = "0x28D9210", VA = "0x1828DAA10", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x29071B0", Offset = "0x29059B0", VA = "0x1829071B0", Slot = "6")]
		public int XGFMDQKYFPY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2907160", Offset = "0x2905960", VA = "0x182907160", Slot = "5")]
		private bool SNSNBMIEHFE([In] VSFALRLGUNX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class OXIMGXKHCJM : IEquatable<OXIMGXKHCJM>, HOAFHMGXMKA<OXIMGXKHCJM>, SJJAQHLWCIF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RVNMAEXWNBU QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		private OXIMGXKHCJM(RVNMAEXWNBU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2907100", Offset = "0x2905900", VA = "0x182907100")]
		public static OXIMGXKHCJM New(RVNMAEXWNBU type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x28B64D0", Offset = "0x28B4CD0", VA = "0x1828B64D0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2907160", Offset = "0x2905960", VA = "0x182907160")]
		public bool WWCFUGHNLCB([In] OXIMGXKHCJM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2907060", Offset = "0x2905860", VA = "0x182907060", Slot = "4")]
		public bool Equals(OXIMGXKHCJM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x29070B0", Offset = "0x29058B0", VA = "0x1829070B0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28DAA10", Offset = "0x28D9210", VA = "0x1828DAA10", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x29071B0", Offset = "0x29059B0", VA = "0x1829071B0", Slot = "6")]
		public int XGFMDQKYFPY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2907160", Offset = "0x2905960", VA = "0x182907160", Slot = "5")]
		private bool OYBMLSWUSTN([In] OXIMGXKHCJM other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class AWODIOOLNAH : MSBRRPXLEVU, IEquatable<AWODIOOLNAH>, HOAFHMGXMKA<AWODIOOLNAH>, SJJAQHLWCIF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, VSFALRLGUNX>> NRCBNCHXRGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, OXIMGXKHCJM>> USGSXJAIKQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2900120", Offset = "0x28FE920", VA = "0x182900120")]
		private AWODIOOLNAH(IEnumerable<CQUYLEJRJJU> a, IEnumerable<KeyValuePair<string, VSFALRLGUNX>> b, IEnumerable<KeyValuePair<string, OXIMGXKHCJM>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x28FFAE0", Offset = "0x28FE2E0", VA = "0x1828FFAE0")]
		public static AWODIOOLNAH New(IEnumerable<CQUYLEJRJJU> typeParameters, IEnumerable<KeyValuePair<string, VSFALRLGUNX>> inputs, IEnumerable<KeyValuePair<string, OXIMGXKHCJM>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28FFCF0", Offset = "0x28FE4F0", VA = "0x1828FFCF0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28FF940", Offset = "0x28FE140", VA = "0x1828FF940", Slot = "15")]
		public sealed override string KGDEWKBNWMP(IReadOnlyList<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28FF7C0", Offset = "0x28FDFC0", VA = "0x1828FF7C0")]
		private string HHNMXZZNPJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x28FF960", Offset = "0x28FE160", VA = "0x1828FF960")]
		private string KVNSZRAGAVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x28FFFF0", Offset = "0x28FE7F0", VA = "0x1828FFFF0", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2900040", Offset = "0x28FE840", VA = "0x182900040")]
		public bool WWCFUGHNLCB([In] AWODIOOLNAH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28FF790", Offset = "0x28FDF90", VA = "0x1828FF790", Slot = "18")]
		public bool Equals(AWODIOOLNAH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28FF740", Offset = "0x28FDF40", VA = "0x1828FF740", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28FFC10", Offset = "0x28FE410", VA = "0x1828FFC10", Slot = "14")]
		protected sealed override int RCCMOAIZDMK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28FF7B0", Offset = "0x28FDFB0", VA = "0x1828FF7B0", Slot = "19")]
		private bool HDKPVZHGWYO([In] AWODIOOLNAH other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class DASSFKWKASS : RVNMAEXWNBU, IEquatable<DASSFKWKASS>, HOAFHMGXMKA<DASSFKWKASS>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x29029D0", Offset = "0x29011D0", VA = "0x1829029D0")]
		private DASSFKWKASS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2902890", Offset = "0x2901090", VA = "0x182902890")]
		public static DASSFKWKASS New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2902950", Offset = "0x2901150", VA = "0x182902950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x29027A0", Offset = "0x2900FA0", VA = "0x1829027A0", Slot = "15")]
		public override string KGDEWKBNWMP(IReadOnlyList<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2902900", Offset = "0x2901100", VA = "0x182902900", Slot = "16")]
		public override int SLVQIIXSOHO(IReadOnlyList<RVNMAEXWNBU> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x29026F0", Offset = "0x2900EF0", VA = "0x1829026F0", Slot = "17")]
		public override bool DRUHTKYRDUB(IReadOnlyList<RVNMAEXWNBU> a, IReadOnlyList<RVNMAEXWNBU> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2902980", Offset = "0x2901180", VA = "0x182902980", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790")]
		public bool WWCFUGHNLCB([In] DASSFKWKASS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xCD2ED0", Offset = "0xCD16D0", VA = "0x180CD2ED0", Slot = "18")]
		public bool Equals(DASSFKWKASS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2902740", Offset = "0x2900F40", VA = "0x182902740", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790", Slot = "19")]
		private bool IWHXMLKPWPV([In] DASSFKWKASS other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, HOAFHMGXMKA<Property>, SJJAQHLWCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool UAWMDTXFDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int CTIBWTMIENK;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public RVNMAEXWNBU QWAVKIDXYXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool QJUJVVGHOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool MYQVXVWIZGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xFD2F50", Offset = "0xFD1750", VA = "0x180FD2F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x29077A0", Offset = "0x2905FA0", VA = "0x1829077A0")]
		private Property(RVNMAEXWNBU type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2907360", Offset = "0x2905B60", VA = "0x182907360")]
		public static Property New(RVNMAEXWNBU type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x29074A0", Offset = "0x2905CA0", VA = "0x1829074A0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2907590", Offset = "0x2905D90", VA = "0x182907590")]
		private string WIBQWGOUYLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2907310", Offset = "0x2905B10", VA = "0x182907310")]
		private string LLCIMGZERTP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x29075E0", Offset = "0x2905DE0", VA = "0x1829075E0")]
		public bool WWCFUGHNLCB([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2907230", Offset = "0x2905A30", VA = "0x182907230", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x29071E0", Offset = "0x29059E0", VA = "0x1829071E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2907250", Offset = "0x2905A50", VA = "0x182907250", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x29073F0", Offset = "0x2905BF0", VA = "0x1829073F0")]
		private int RCCMOAIZDMK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x29076E0", Offset = "0x2905EE0", VA = "0x1829076E0", Slot = "6")]
		public int XGFMDQKYFPY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2907580", Offset = "0x2905D80", VA = "0x182907580", Slot = "5")]
		private bool UNJQZAIFOBN([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class RSROTLYQCKH : RVNMAEXWNBU, IEquatable<RSROTLYQCKH>, HOAFHMGXMKA<RSROTLYQCKH>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x29083B0", Offset = "0x2906BB0", VA = "0x1829083B0")]
		private RSROTLYQCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x29082C0", Offset = "0x2906AC0", VA = "0x1829082C0")]
		public static RSROTLYQCKH New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2908330", Offset = "0x2906B30", VA = "0x182908330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2908240", Offset = "0x2906A40", VA = "0x182908240", Slot = "15")]
		public override string KGDEWKBNWMP(IReadOnlyList<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2908360", Offset = "0x2906B60", VA = "0x182908360", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790")]
		public bool WWCFUGHNLCB([In] RSROTLYQCKH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCD2ED0", Offset = "0xCD16D0", VA = "0x180CD2ED0", Slot = "18")]
		public bool Equals(RSROTLYQCKH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x29081F0", Offset = "0x29069F0", VA = "0x1829081F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790", Slot = "19")]
		private bool QKXAVBYZVII([In] RSROTLYQCKH other)
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
	public sealed class ILBVFFCZTVB : RVNMAEXWNBU, IEquatable<ILBVFFCZTVB>, HOAFHMGXMKA<ILBVFFCZTVB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool DJAVVACTQVL
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2903CF0", Offset = "0x29024F0", VA = "0x182903CF0", Slot = "9")]
		public sealed override RVNMAEXWNBU LWEJOOYLGYZ(IReadOnlyDictionary<string, RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2903CC0", Offset = "0x29024C0", VA = "0x182903CC0", Slot = "11")]
		public sealed override void JBYPHMIFXDN(Action<RVNMAEXWNBU> a, Action<RVNMAEXWNBU> b, Action<RVNMAEXWNBU> c, Action<RVNMAEXWNBU> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2903ED0", Offset = "0x29026D0", VA = "0x182903ED0")]
		private ILBVFFCZTVB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2903DE0", Offset = "0x29025E0", VA = "0x182903DE0")]
		public static ILBVFFCZTVB New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2903E80", Offset = "0x2902680", VA = "0x182903E80", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790")]
		public bool WWCFUGHNLCB([In] ILBVFFCZTVB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xCD2ED0", Offset = "0xCD16D0", VA = "0x180CD2ED0", Slot = "18")]
		public bool Equals(ILBVFFCZTVB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2903C70", Offset = "0x2902470", VA = "0x182903C70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2903E60", Offset = "0x2902660", VA = "0x182903E60", Slot = "14")]
		protected sealed override int RCCMOAIZDMK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790", Slot = "19")]
		private bool CTXOQRXSIMK([In] ILBVFFCZTVB other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class MSBRRPXLEVU : RVNMAEXWNBU
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<CQUYLEJRJJU> COXRKENQEMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2906E60", Offset = "0x2905660", VA = "0x182906E60")]
		public void Initialize(MSBRRPXLEVU from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2906FF0", Offset = "0x29057F0", VA = "0x182906FF0")]
		protected MSBRRPXLEVU(IEnumerable<CQUYLEJRJJU> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool WWCFUGHNLCB([In] RVNMAEXWNBU other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2906F90", Offset = "0x2905790", VA = "0x182906F90")]
		protected bool WWCFUGHNLCB([In] MSBRRPXLEVU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2906E90", Offset = "0x2905690", VA = "0x182906E90", Slot = "14")]
		protected override int RCCMOAIZDMK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2906F10", Offset = "0x2905710", VA = "0x182906F10")]
		protected int TUOSKGNCMLW(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class CQUYLEJRJJU : RVNMAEXWNBU, IEquatable<CQUYLEJRJJU>, HOAFHMGXMKA<CQUYLEJRJJU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RVNMAEXWNBU RVNFFBPYQKU
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x29019D0", Offset = "0x29001D0", VA = "0x1829019D0")]
		private CQUYLEJRJJU(string a, [Optional] RVNMAEXWNBU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x29016B0", Offset = "0x28FFEB0", VA = "0x1829016B0")]
		public static CQUYLEJRJJU New(string name, [Optional] RVNMAEXWNBU constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2901880", Offset = "0x2900080", VA = "0x182901880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2901910", Offset = "0x2900110", VA = "0x182901910", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x29017B0", Offset = "0x28FFFB0", VA = "0x1829017B0")]
		public bool WWCFUGHNLCB([In] CQUYLEJRJJU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2901660", Offset = "0x28FFE60", VA = "0x182901660", Slot = "18")]
		public bool Equals(CQUYLEJRJJU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2901610", Offset = "0x28FFE10", VA = "0x182901610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2901800", Offset = "0x2900000", VA = "0x182901800", Slot = "14")]
		protected override int RCCMOAIZDMK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2901960", Offset = "0x2900160", VA = "0x182901960", Slot = "13")]
		public override int XGFMDQKYFPY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x29017B0", Offset = "0x28FFFB0", VA = "0x1829017B0", Slot = "19")]
		private bool QLIJLPBMPQB([In] CQUYLEJRJJU other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class ULDXGOMOEUC : RVNMAEXWNBU, IEquatable<ULDXGOMOEUC>, HOAFHMGXMKA<ULDXGOMOEUC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x290AF50", Offset = "0x2909750", VA = "0x18290AF50")]
		private ULDXGOMOEUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x290AE10", Offset = "0x2909610", VA = "0x18290AE10")]
		public static ULDXGOMOEUC New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x290AED0", Offset = "0x29096D0", VA = "0x18290AED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x290AD20", Offset = "0x2909520", VA = "0x18290AD20", Slot = "15")]
		public override string KGDEWKBNWMP(IReadOnlyList<RVNMAEXWNBU> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x290AE80", Offset = "0x2909680", VA = "0x18290AE80", Slot = "16")]
		public override int SLVQIIXSOHO(IReadOnlyList<RVNMAEXWNBU> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x290AC80", Offset = "0x2909480", VA = "0x18290AC80", Slot = "17")]
		public override bool DRUHTKYRDUB(IReadOnlyList<RVNMAEXWNBU> a, IReadOnlyList<RVNMAEXWNBU> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x290AF00", Offset = "0x2909700", VA = "0x18290AF00", Slot = "12")]
		public override bool WWCFUGHNLCB([In] RVNMAEXWNBU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790")]
		public bool WWCFUGHNLCB([In] ULDXGOMOEUC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xCD2ED0", Offset = "0xCD16D0", VA = "0x180CD2ED0", Slot = "18")]
		public bool Equals(ULDXGOMOEUC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x290ACD0", Offset = "0x29094D0", VA = "0x18290ACD0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2902790", Offset = "0x2900F90", VA = "0x182902790", Slot = "19")]
		private bool FWJSODLAUMF([In] ULDXGOMOEUC other)
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
			public readonly RVNMAEXWNBU CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
			internal Impl(RVNMAEXWNBU circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2901D20", Offset = "0x2900520", VA = "0x182901D20")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2901C50", Offset = "0x2900450", VA = "0x182901C50")]
		public static CircuitTypeOrString PIUEUOZQYSW(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2901CC0", Offset = "0x29004C0", VA = "0x182901CC0")]
		public static CircuitTypeOrString PIUEUOZQYSW(RVNMAEXWNBU a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2901BB0", Offset = "0x29003B0", VA = "0x182901BB0")]
		public RVNMAEXWNBU JUOCKLKRDNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2901A90", Offset = "0x2900290", VA = "0x182901A90")]
		public static RVNMAEXWNBU[] HYWAEMVEFQY(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly HLYFSKGANHL _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		private ClassFactoryBaseClasses(HLYFSKGANHL data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xE48120", Offset = "0xE46920", VA = "0x180E48120")]
		public static ClassFactoryBaseClasses New(HLYFSKGANHL data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2901DA0", Offset = "0x29005A0", VA = "0x182901DA0")]
		public ClassFactoryBaseClasses LXHBMOWTQEX(CIHDQNZBWGJ a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x15D8E90", Offset = "0x15D7690", VA = "0x1815D8E90")]
		public ClassFactoryProps MHAIAYCWDKU()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2901E60", Offset = "0x2900660", VA = "0x182901E60")]
		public ClassFactoryProps RWCGAFRZCBP(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2901D50", Offset = "0x2900550", VA = "0x182901D50")]
		public CIHDQNZBWGJ AXHFTEUJRLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class HLYFSKGANHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? VXYCUIZXFBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string TYWDEKEDEIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<CQUYLEJRJJU> COXRKENQEMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<CIHDQNZBWGJ> MQYUTMVJOPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> SISXIIKSZKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, AWODIOOLNAH>> KSWTSWUPETS;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2902E00", Offset = "0x2901600", VA = "0x182902E00")]
		private HLYFSKGANHL([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2902C50", Offset = "0x2901450", VA = "0x182902C50")]
		public static HLYFSKGANHL New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly HLYFSKGANHL _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		private ClassFactoryFuncs(HLYFSKGANHL data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xE48120", Offset = "0xE46920", VA = "0x180E48120")]
		public static ClassFactoryFuncs New(HLYFSKGANHL data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2901EC0", Offset = "0x29006C0", VA = "0x182901EC0")]
		public CIHDQNZBWGJ AXHFTEUJRLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly HLYFSKGANHL _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		public ClassFactoryProps(HLYFSKGANHL data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2902050", Offset = "0x2900850", VA = "0x182902050")]
		public ClassFactoryProps RWCGAFRZCBP(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x15D8E90", Offset = "0x15D7690", VA = "0x1815D8E90")]
		public ClassFactoryFuncs JLROTODLTSJ()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2902010", Offset = "0x2900810", VA = "0x182902010")]
		public CIHDQNZBWGJ AXHFTEUJRLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly HLYFSKGANHL _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		private ClassFactoryTypeParams(HLYFSKGANHL data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2902280", Offset = "0x2900A80", VA = "0x182902280")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2902450", Offset = "0x2900C50", VA = "0x182902450")]
		public ClassFactoryTypeParams RHFHGTVSHLH(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x15D8E90", Offset = "0x15D7690", VA = "0x1815D8E90")]
		public ClassFactoryBaseClasses HHYSMTLGBND()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2902240", Offset = "0x2900A40", VA = "0x182902240")]
		public ClassFactoryBaseClasses LXHBMOWTQEX(CIHDQNZBWGJ a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x29021E0", Offset = "0x29009E0", VA = "0x1829021E0")]
		public CIHDQNZBWGJ AXHFTEUJRLO()
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
