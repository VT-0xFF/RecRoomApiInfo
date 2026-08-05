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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JHOEKUEVGUO : IEquatable<JHOEKUEVGUO>, GCLDOOWCVKA<JHOEKUEVGUO>, FQNLSQWNTKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool RGRDLQPRCUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool ZADZTADTOZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int ALWVIVXUCRO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind JSZILMLWUMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? HGODNGQIEOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B0CF80", Offset = "0x2B0BD80", VA = "0x182B0CF80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual JHOEKUEVGUO CCBFJALWPMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool MMFKOKXIIYB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D020", Offset = "0x2B0BE20", VA = "0x182B0D020")]
		public static void RWFLESYWDGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
		protected JHOEKUEVGUO(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CF10", Offset = "0x2B0BD10", VA = "0x182B0CF10")]
		public static JHOEKUEVGUO New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		protected static a AAIEBEEQAXY<a>(a a) where a : JHOEKUEVGUO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440", Slot = "9")]
		public virtual JHOEKUEVGUO MDQHUYSVFBP(IReadOnlyDictionary<string, JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CFF0", Offset = "0x2B0BDF0", VA = "0x182B0CFF0", Slot = "11")]
		public virtual void RQWUAHFHGKP(Action<JHOEKUEVGUO> a, Action<JHOEKUEVGUO> b, Action<JHOEKUEVGUO> c, Action<JHOEKUEVGUO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D0E0", Offset = "0x2B0BEE0", VA = "0x182B0D0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CAD0", Offset = "0x2B0B8D0", VA = "0x182B0CAD0", Slot = "12")]
		public virtual bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CC00", Offset = "0x2B0BA00", VA = "0x182B0CC00", Slot = "4")]
		public bool Equals(JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CC30", Offset = "0x2B0BA30", VA = "0x182B0CC30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CC80", Offset = "0x2B0BA80", VA = "0x182B0CC80")]
		public static bool GFBRUTYEXQF(JHOEKUEVGUO a, JHOEKUEVGUO b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CBC0", Offset = "0x2B0B9C0", VA = "0x182B0CBC0")]
		public static bool CQBJVGKOTGK(JHOEKUEVGUO a, JHOEKUEVGUO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CCC0", Offset = "0x2B0BAC0", VA = "0x182B0CCC0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D0B0", Offset = "0x2B0BEB0", VA = "0x182B0D0B0", Slot = "13")]
		public virtual int VGMTVBFVDWO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D0B0", Offset = "0x2B0BEB0", VA = "0x182B0D0B0", Slot = "14")]
		protected virtual int TSLCXIHVRJE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x39B2170", Offset = "0x39B0F70", VA = "0x1839B2170")]
		public b VVAKYHLKVOY<b>() where b : JHOEKUEVGUO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B5C0", Offset = "0x2B0A3C0", VA = "0x182B0B5C0", Slot = "15")]
		public virtual string VRCYNZLPIBZ(IReadOnlyList<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CB70", Offset = "0x2B0B970", VA = "0x182B0CB70", Slot = "16")]
		public virtual int BXFYTZYQHSY(IReadOnlyList<JHOEKUEVGUO> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CD70", Offset = "0x2B0BB70", VA = "0x182B0CD70", Slot = "17")]
		public virtual bool HOEVNFPOFBT(IReadOnlyList<JHOEKUEVGUO> a, IReadOnlyList<JHOEKUEVGUO> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CDC0", Offset = "0x2B0BBC0", VA = "0x182B0CDC0")]
		public MVGGWPNJIXX JEBFKSIEJCX(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CF00", Offset = "0x2B0BD00", VA = "0x182B0CF00")]
		public MVGGWPNJIXX JEBFKSIEJCX(params JHOEKUEVGUO[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CF00", Offset = "0x2B0BD00", VA = "0x182B0CF00")]
		public MVGGWPNJIXX JEBFKSIEJCX(IEnumerable<JHOEKUEVGUO> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface XZMMFITJJKF<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a XRQJWNCNYBF(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b JCMKJDLWGJX([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind HCXZTDRZWJJ([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates RNHCULQHDBI(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FQNLSQWNTKZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int VGMTVBFVDWO(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class VGMTVBFVDWO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class YLAONGPGXVE<a> where a : FQNLSQWNTKZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int NKUIJJQITZZ;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public YLAONGPGXVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x409E700", Offset = "0x409D500", VA = "0x18409E700")]
			internal int CDMTQNEBBED(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class SQDPMMMAZWM<a, b> where b : FQNLSQWNTKZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int NKUIJJQITZZ;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public SQDPMMMAZWM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60F8CC0", Offset = "0x60F7AC0", VA = "0x1860F8CC0")]
			internal int CDMTQNEBBED(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PALYBJDNTMM<a> where a : FQNLSQWNTKZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int NKUIJJQITZZ;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public PALYBJDNTMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5D3B480", Offset = "0x5D3A280", VA = "0x185D3B480")]
			internal int KAIKKTHNSIU(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E72C30", Offset = "0x3E71A30", VA = "0x183E72C30")]
		public static int CWPOYRONDDT<a>(this IEnumerable<a> a, int b = 0) where a : FQNLSQWNTKZ
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E72B60", Offset = "0x3E71960", VA = "0x183E72B60")]
		public static int CWPOYRONDDT<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : FQNLSQWNTKZ
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E72C30", Offset = "0x3E71A30", VA = "0x183E72C30")]
		public static int VCOLSMSKSJK<d>(this IEnumerable<d> a, int b = 0) where d : FQNLSQWNTKZ
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : XZMMFITJJKF<TDirectedType, JHOEKUEVGUO, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x42EAC30", Offset = "0x42E9A30", VA = "0x1842EAC30")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63D60C0", Offset = "0x63D4EC0", VA = "0x1863D60C0")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class XPWTHXNVQPO
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class BDSAAPWJCNG<a, b, c> where c : XZMMFITJJKF<a, JHOEKUEVGUO, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public JHOEKUEVGUO RWZAAPTLDYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<JHOEKUEVGUO> BQTOXGFKQMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public JHOEKUEVGUO JBUMEGKDPFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<JHOEKUEVGUO> LPGWCVSKGLW;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BDSAAPWJCNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x70EA130", Offset = "0x70E8F30", VA = "0x1870EA130")]
			internal bool RWPCNTGQEWK([In] TypeSys<a, b, c> self_, JHOEKUEVGUO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x70E9F00", Offset = "0x70E8D00", VA = "0x1870E9F00")]
			internal bool RWJVQMMSVLB([In] TypeSys<a, b, c> self_, JHOEKUEVGUO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x70EA330", Offset = "0x70E9130", VA = "0x1870EA330")]
			internal bool RXKECUIFQPU([In] TypeSys<a, b, c> self_, JHOEKUEVGUO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JODXBUSWKKH<a, b, c> where c : XZMMFITJJKF<a, JHOEKUEVGUO, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public JHOEKUEVGUO PDEUKCYXEDE;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public JODXBUSWKKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x53D7580", Offset = "0x53D6380", VA = "0x1853D7580")]
			internal bool RXPLABCDABD([In] TypeSys<a, b, c> self__, JHOEKUEVGUO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MUYTKSVNSSG<a, b, c> where c : XZMMFITJJKF<a, JHOEKUEVGUO, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b BSGUJACPZOT;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MUYTKSVNSSG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5A6CA40", Offset = "0x5A6B840", VA = "0x185A6CA40")]
			internal JHOEKUEVGUO BVCCQSVZUIF([In] TypeSys<a, b, c> self_, [In] b root_, JHOEKUEVGUO a, JHOEKUEVGUO b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class DNVNVTDXREB<a, b, c> where c : XZMMFITJJKF<a, JHOEKUEVGUO, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public HWVCIXNUHHP NVWTREPPKAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HWVCIXNUHHP AKMPSVGHSLT;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public DNVNVTDXREB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4304B60", Offset = "0x4303960", VA = "0x184304B60")]
			internal a BUMHYYOHSAE([In] TypeSys<a, b, c> self_, IOKind a, HWVCIXNUHHP b, HWVCIXNUHHP c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class SIVIUHUMXXS<a, b, c> where c : XZMMFITJJKF<a, JHOEKUEVGUO, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<HWVCIXNUHHP> ZVSVXAVCHMR;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public SIVIUHUMXXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x60E5330", Offset = "0x60E4130", VA = "0x1860E5330")]
			internal bool EQBGTRNIVOW(bool a, HWVCIXNUHHP b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] QOMGOHLLCKR;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C250", Offset = "0x3E8B050", VA = "0x183E8C250")]
		public static bool MKJPXXQCDAM<a, b, c>([In] this TypeSys<a, b, c> _, JHOEKUEVGUO a) where c : XZMMFITJJKF<a, JHOEKUEVGUO, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C230", Offset = "0x3E8B030", VA = "0x183E8C230")]
		public static bool GNWENCNRYBT<d, e, f>([In] this TypeSys<d, e, f> _, JHOEKUEVGUO a) where f : XZMMFITJJKF<d, JHOEKUEVGUO, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C270", Offset = "0x3E8B070", VA = "0x183E8C270")]
		public static bool SJGNYIZCIYL<g, h, i>([In] this TypeSys<g, h, i> self, JHOEKUEVGUO a, JHOEKUEVGUO b) where i : XZMMFITJJKF<g, JHOEKUEVGUO, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CDF0", Offset = "0x3E8BBF0", VA = "0x183E8CDF0")]
		private static bool UCSRKMZMSJI<j, k, l>([In] this TypeSys<j, k, l> self, JHOEKUEVGUO a, JHOEKUEVGUO b, IReadOnlyList<JHOEKUEVGUO> c, IReadOnlyList<JHOEKUEVGUO> d) where l : XZMMFITJJKF<j, JHOEKUEVGUO, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3E90DD0", Offset = "0x3E8FBD0", VA = "0x183E90DD0")]
		public static JHOEKUEVGUO UOQVPHGRGRW<m, n, o>([In] this TypeSys<m, n, o> self, n a, JHOEKUEVGUO b, JHOEKUEVGUO c) where o : XZMMFITJJKF<m, JHOEKUEVGUO, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3E8DFE0", Offset = "0x3E8CDE0", VA = "0x183E8DFE0")]
		public static p UOQVPHGRGRW<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : XZMMFITJJKF<p, JHOEKUEVGUO, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3E96100", Offset = "0x3E94F00", VA = "0x183E96100")]
		private static List<w> WPTSDALTJUK<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : XZMMFITJJKF<t, JHOEKUEVGUO, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E8CC50", Offset = "0x3E8BA50", VA = "0x183E8CC50")]
		private static ba TFQAWQMSUWA<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class GKJYZLQTTPB
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static JHOEKUEVGUO PRWQMLBCZMI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A3C0", Offset = "0x2B091C0", VA = "0x182B0A3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static JHOEKUEVGUO FZNUDDBRAPA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A620", Offset = "0x2B09420", VA = "0x182B0A620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static JHOEKUEVGUO MLWHBTZYXJP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A4A0", Offset = "0x2B092A0", VA = "0x182B0A4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static JHOEKUEVGUO PLDHUBOETIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A370", Offset = "0x2B09170", VA = "0x182B0A370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static JHOEKUEVGUO DWTUKBMVKSV
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A320", Offset = "0x2B09120", VA = "0x182B0A320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static JHOEKUEVGUO CTZMNRFJHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A5D0", Offset = "0x2B093D0", VA = "0x182B0A5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static JHOEKUEVGUO BGUUNJPXVRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A580", Offset = "0x2B09380", VA = "0x182B0A580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static JHOEKUEVGUO OBCOOAPCQZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A7A0", Offset = "0x2B095A0", VA = "0x182B0A7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A670", Offset = "0x2B09470", VA = "0x182B0A670")]
		public static MVGGWPNJIXX WCYDXHOAEGF([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A410", Offset = "0x2B09210", VA = "0x182B0A410")]
		public static MVGGWPNJIXX FNHWBVLKSTD(IEnumerable<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A0C0", Offset = "0x2B08EC0", VA = "0x182B0A0C0")]
		public static MVGGWPNJIXX BJBHZVXAIWP(IEnumerable<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B09F20", Offset = "0x2B08D20", VA = "0x182B09F20")]
		public static MVGGWPNJIXX BJBHZVXAIWP(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A4F0", Offset = "0x2B092F0", VA = "0x182B0A4F0")]
		public static MVGGWPNJIXX HPPFUMWMEDM(IEnumerable<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A150", Offset = "0x2B08F50", VA = "0x182B0A150")]
		public static VAFAFNFBAFU BQPFJTNXPOF(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class MVGGWPNJIXX : JHOEKUEVGUO, IEquatable<MVGGWPNJIXX>, GCLDOOWCVKA<MVGGWPNJIXX>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WCODKRWUAFT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, JHOEKUEVGUO> ELLJFQHPIBF;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WCODKRWUAFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B11E90", Offset = "0x2B10C90", VA = "0x182B11E90")]
			internal JHOEKUEVGUO XDRHIIMEWGH(JHOEKUEVGUO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JHOEKUEVGUO UMRVNTJDZUF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override JHOEKUEVGUO CCBFJALWPMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<JHOEKUEVGUO> PZJGAWBBBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool MMFKOKXIIYB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B0DCC0", Offset = "0x2B0CAC0", VA = "0x182B0DCC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D8C0", Offset = "0x2B0C6C0", VA = "0x182B0D8C0", Slot = "9")]
		public sealed override JHOEKUEVGUO MDQHUYSVFBP(IReadOnlyDictionary<string, JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DA60", Offset = "0x2B0C860", VA = "0x182B0DA60", Slot = "11")]
		public sealed override void RQWUAHFHGKP(Action<JHOEKUEVGUO> a, Action<JHOEKUEVGUO> b, Action<JHOEKUEVGUO> c, Action<JHOEKUEVGUO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DEC0", Offset = "0x2B0CCC0", VA = "0x182B0DEC0")]
		private MVGGWPNJIXX(JHOEKUEVGUO a, IEnumerable<JHOEKUEVGUO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D9E0", Offset = "0x2B0C7E0", VA = "0x182B0D9E0")]
		public static MVGGWPNJIXX New(JHOEKUEVGUO originalType, IEnumerable<JHOEKUEVGUO> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DE80", Offset = "0x2B0CC80", VA = "0x182B0DE80", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D800", Offset = "0x2B0C600", VA = "0x182B0D800", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D760", Offset = "0x2B0C560", VA = "0x182B0D760")]
		public bool BURZPLIABAB([In] MVGGWPNJIXX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D8A0", Offset = "0x2B0C6A0", VA = "0x182B0D8A0", Slot = "18")]
		public bool Equals(MVGGWPNJIXX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D850", Offset = "0x2B0C650", VA = "0x182B0D850", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DDD0", Offset = "0x2B0CBD0", VA = "0x182B0DDD0", Slot = "14")]
		protected override int TSLCXIHVRJE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D750", Offset = "0x2B0C550", VA = "0x182B0D750", Slot = "19")]
		private bool BRVBSKRNRGE([In] MVGGWPNJIXX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class MGHJCZHCDTC : JHOEKUEVGUO, IEquatable<MGHJCZHCDTC>, GCLDOOWCVKA<MGHJCZHCDTC>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D730", Offset = "0x2B0C530", VA = "0x182B0D730")]
		private MGHJCZHCDTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D590", Offset = "0x2B0C390", VA = "0x182B0D590")]
		public static MGHJCZHCDTC New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D600", Offset = "0x2B0C400", VA = "0x182B0D600", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D660", Offset = "0x2B0C460", VA = "0x182B0D660", Slot = "15")]
		public sealed override string VRCYNZLPIBZ(IReadOnlyList<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D6F0", Offset = "0x2B0C4F0", VA = "0x182B0D6F0")]
		private static string WUSRPKBOIXH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D4F0", Offset = "0x2B0C2F0", VA = "0x182B0D4F0", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250")]
		public bool BURZPLIABAB([In] MGHJCZHCDTC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB79CA0", Offset = "0xB78AA0", VA = "0x180B79CA0", Slot = "18")]
		public bool Equals(MGHJCZHCDTC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D540", Offset = "0x2B0C340", VA = "0x182B0D540", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250", Slot = "19")]
		private bool QCYYWPTUCVN([In] MGHJCZHCDTC other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class DTRXAVCKOUF
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class QFVEKDSMASK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public JHOEKUEVGUO SYFNXSNKZWT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<JHOEKUEVGUO, MVGGWPNJIXX> CCVXYHDMWNH;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFVEKDSMASK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B0EF30", Offset = "0x2B0DD30", VA = "0x182B0EF30")]
			internal MVGGWPNJIXX MPCPSFNWFMP(JHOEKUEVGUO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class QGALHKMJKDT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public JHOEKUEVGUO BDNYAEFAGKR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<JHOEKUEVGUO, MVGGWPNJIXX> AUYACGJUQSX;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QGALHKMJKDT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F0B0", Offset = "0x2B0DEB0", VA = "0x182B0F0B0")]
			internal MVGGWPNJIXX MMPWLSHVUDT(JHOEKUEVGUO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B07060", Offset = "0x2B05E60", VA = "0x182B07060")]
		public static IEnumerable<HWVCIXNUHHP> AXYAMAPLNEZ(this HWVCIXNUHHP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B09E30", Offset = "0x2B08C30", VA = "0x182B09E30")]
		private static IEnumerable<HWVCIXNUHHP> XHWKUXXDTCX(this HWVCIXNUHHP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B09460", Offset = "0x2B08260", VA = "0x182B09460")]
		public static (JHOEKUEVGUO, IReadOnlyList<JHOEKUEVGUO>, bool) THMZJAZFWMN(this JHOEKUEVGUO a, [Optional] IReadOnlyList<JHOEKUEVGUO> b)
		{
			return default((JHOEKUEVGUO, IReadOnlyList<JHOEKUEVGUO>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B09EF0", Offset = "0x2B08CF0", VA = "0x182B09EF0")]
		public static TypeKind YBVOSXBDRXE(this JHOEKUEVGUO a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B07290", Offset = "0x2B06090", VA = "0x182B07290")]
		private static JHOEKUEVGUO ConvertClassesToIntersections(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B07D30", Offset = "0x2B06B30", VA = "0x182B07D30")]
		private static JHOEKUEVGUO DistributeUnionIntoIntersection(this MVGGWPNJIXX self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B078C0", Offset = "0x2B066C0", VA = "0x182B078C0")]
		private static JHOEKUEVGUO DistributeIntersectionIntoIntersection(this MVGGWPNJIXX self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B07BD0", Offset = "0x2B069D0", VA = "0x182B07BD0")]
		private static JHOEKUEVGUO DistributeIntoIntersection(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B08040", Offset = "0x2B06E40", VA = "0x182B08040")]
		private static bool OtherIsAssignableToOther(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes, JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B096B0", Offset = "0x2B084B0", VA = "0x182B096B0")]
		private static bool UnionIsAssignableToOther(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes, JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B081D0", Offset = "0x2B06FD0", VA = "0x182B081D0")]
		private static bool OtherIsAssignableToUnion(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes, JHOEKUEVGUO union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B099D0", Offset = "0x2B087D0", VA = "0x182B099D0")]
		private static bool UnionIsAssignableToUnion(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes, JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B09260", Offset = "0x2B08060", VA = "0x182B09260")]
		public static JHOEKUEVGUO RemoveCommonTypesFromIntersectionDistribution(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B085C0", Offset = "0x2B073C0", VA = "0x182B085C0")]
		public static JHOEKUEVGUO RemoveCommonTypesFromIntersectionDistributionInternal(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B09390", Offset = "0x2B08190", VA = "0x182B09390")]
		public static JHOEKUEVGUO SimplifyIntersectionUnion(this JHOEKUEVGUO self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B08570", Offset = "0x2B07370", VA = "0x182B08570")]
		public static IEnumerable<JHOEKUEVGUO> PZJGAWBBBHG(this JHOEKUEVGUO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B09620", Offset = "0x2B08420", VA = "0x182B09620")]
		public static IEnumerable<JHOEKUEVGUO> THWBJSGNLBN(this JHOEKUEVGUO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class HWVCIXNUHHP : ZANJJEXRLCS, IEquatable<HWVCIXNUHHP>, GCLDOOWCVKA<HWVCIXNUHHP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class TOTZMQTRFHO : IEnumerable<HWVCIXNUHHP>, IEnumerable, IEnumerator<HWVCIXNUHHP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private HWVCIXNUHHP QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public HWVCIXNUHHP WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<HWVCIXNUHHP> ZQJSAWQBUYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private HWVCIXNUHHP RKVKDTFBQPW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<HWVCIXNUHHP> ZQUFVKDWNVD;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private HWVCIXNUHHP GKCZLJXDPOA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public TOTZMQTRFHO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F600", Offset = "0x2B0E400", VA = "0x182B0F600", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F7F0", Offset = "0x2B0E5F0", VA = "0x182B0F7F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F750", Offset = "0x2B0E550", VA = "0x182B0F750")]
			private void LKISUJFCFYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F7A0", Offset = "0x2B0E5A0", VA = "0x182B0F7A0")]
			private void LKYNMDMUIGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F5C0", Offset = "0x2B0E3C0", VA = "0x182B0F5C0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F520", Offset = "0x2B0E320", VA = "0x182B0F520", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HWVCIXNUHHP> ACFWUFTQMBB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B0F520", Offset = "0x2B0E320", VA = "0x182B0F520", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> QCQPNPDIUHP;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, HWVCIXNUHHP> LOICFNSADCS;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, HWVCIXNUHHP> BVPCVINGWES
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B0BBB0", Offset = "0x2B0A9B0", VA = "0x182B0BBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? HGODNGQIEOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid QXVQSTMOTBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xF782C0", Offset = "0xF770C0", VA = "0x180F782C0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xF782D0", Offset = "0xF770D0", VA = "0x180F782D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<HWVCIXNUHHP> DECGLJVHITU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<HWVCIXNUHHP> TLERGIIKEEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2B0BF80", Offset = "0x2B0AD80", VA = "0x182B0BF80")]
			[IteratorStateMachine(typeof(TOTZMQTRFHO))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> NHFFDHRTOFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, HKBEYLDNIPR> XYQXLJQHAPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C7D0", Offset = "0x2B0B5D0", VA = "0x182B0C7D0")]
		public HWVCIXNUHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C720", Offset = "0x2B0B520", VA = "0x182B0C720")]
		public HWVCIXNUHHP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B960", Offset = "0x2B0A760", VA = "0x182B0B960")]
		public static HWVCIXNUHHP ILOOQWAWRTA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B840", Offset = "0x2B0A640", VA = "0x182B0B840")]
		public static HWVCIXNUHHP ECFOIHXMCBW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B9C0", Offset = "0x2B0A7C0", VA = "0x182B0B9C0")]
		public void Initialize(HWVCIXNUHHP from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C830", Offset = "0x2B0B630", VA = "0x182B0C830")]
		private HWVCIXNUHHP([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<VAFAFNFBAFU> c, [Optional] IEnumerable<HWVCIXNUHHP> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, HKBEYLDNIPR>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BEB0", Offset = "0x2B0ACB0", VA = "0x182B0BEB0")]
		public static HWVCIXNUHHP New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<VAFAFNFBAFU> typeParameters, [Optional] IEnumerable<HWVCIXNUHHP> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, HKBEYLDNIPR>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C110", Offset = "0x2B0AF10", VA = "0x182B0C110", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B890", Offset = "0x2B0A690", VA = "0x182B0B890")]
		private string EJIMWSZRKYC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C580", Offset = "0x2B0B380", VA = "0x182B0C580")]
		private static string ZIJICGGZCOP(IEnumerable<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C2D0", Offset = "0x2B0B0D0", VA = "0x182B0C2D0")]
		private string VXYCDFDRYDU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BC00", Offset = "0x2B0AA00", VA = "0x182B0BC00")]
		private string MFBVDBDSFML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C200", Offset = "0x2B0B000", VA = "0x182B0C200", Slot = "15")]
		public sealed override string VRCYNZLPIBZ(IReadOnlyList<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B7F0", Offset = "0x2B0A5F0", VA = "0x182B0B7F0", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B6D0", Offset = "0x2B0A4D0", VA = "0x182B0B6D0")]
		public bool BURZPLIABAB([In] HWVCIXNUHHP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B940", Offset = "0x2B0A740", VA = "0x182B0B940", Slot = "18")]
		public bool Equals(HWVCIXNUHHP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B8F0", Offset = "0x2B0A6F0", VA = "0x182B0B8F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C000", Offset = "0x2B0AE00", VA = "0x182B0C000", Slot = "14")]
		protected override int TSLCXIHVRJE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B9B0", Offset = "0x2B0A7B0", VA = "0x182B0B9B0", Slot = "19")]
		private bool IYMQZSBHGDE([In] HWVCIXNUHHP other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class AWFSBICZAIY
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<JHOEKUEVGUO> CMEFXIGJJOH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<HWVCIXNUHHP> UOYNQKLFDTM;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, VAFAFNFBAFU> QIZJWNJVDHJ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> CPLTZNXGFIB;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, HKBEYLDNIPR> TAVVRJMNELS;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class NMYHGSQXUAN : IEquatable<NMYHGSQXUAN>, GCLDOOWCVKA<NMYHGSQXUAN>, FQNLSQWNTKZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public JHOEKUEVGUO QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		private NMYHGSQXUAN(JHOEKUEVGUO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E3B0", Offset = "0x2B0D1B0", VA = "0x182B0E3B0")]
		public static NMYHGSQXUAN New(JHOEKUEVGUO type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD120", Offset = "0x2ABBF20", VA = "0x182ABD120", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E2C0", Offset = "0x2B0D0C0", VA = "0x182B0E2C0")]
		public bool BURZPLIABAB([In] NMYHGSQXUAN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E360", Offset = "0x2B0D160", VA = "0x182B0E360", Slot = "4")]
		public bool Equals(NMYHGSQXUAN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E310", Offset = "0x2B0D110", VA = "0x182B0E310", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF8F0", Offset = "0x2ADE6F0", VA = "0x182ADF8F0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E410", Offset = "0x2B0D210", VA = "0x182B0E410", Slot = "6")]
		public int VGMTVBFVDWO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E2C0", Offset = "0x2B0D0C0", VA = "0x182B0E2C0", Slot = "5")]
		private bool YETJGQZJNLE([In] NMYHGSQXUAN other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class XAQXIMHDBUG : IEquatable<XAQXIMHDBUG>, GCLDOOWCVKA<XAQXIMHDBUG>, FQNLSQWNTKZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public JHOEKUEVGUO QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		private XAQXIMHDBUG(JHOEKUEVGUO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B11F20", Offset = "0x2B10D20", VA = "0x182B11F20")]
		public static XAQXIMHDBUG New(JHOEKUEVGUO type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD120", Offset = "0x2ABBF20", VA = "0x182ABD120", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E2C0", Offset = "0x2B0D0C0", VA = "0x182B0E2C0")]
		public bool BURZPLIABAB([In] XAQXIMHDBUG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E360", Offset = "0x2B0D160", VA = "0x182B0E360", Slot = "4")]
		public bool Equals(XAQXIMHDBUG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B11ED0", Offset = "0x2B10CD0", VA = "0x182B11ED0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF8F0", Offset = "0x2ADE6F0", VA = "0x182ADF8F0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E410", Offset = "0x2B0D210", VA = "0x182B0E410", Slot = "6")]
		public int VGMTVBFVDWO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E2C0", Offset = "0x2B0D0C0", VA = "0x182B0E2C0", Slot = "5")]
		private bool DPXZVRZQBIT([In] XAQXIMHDBUG other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HKBEYLDNIPR : ZANJJEXRLCS, IEquatable<HKBEYLDNIPR>, GCLDOOWCVKA<HKBEYLDNIPR>, FQNLSQWNTKZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, NMYHGSQXUAN>> BLDAZTQDASG
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, XAQXIMHDBUG>> PAHPBXBPTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B5E0", Offset = "0x2B0A3E0", VA = "0x182B0B5E0")]
		private HKBEYLDNIPR(IEnumerable<VAFAFNFBAFU> a, IEnumerable<KeyValuePair<string, NMYHGSQXUAN>> b, IEnumerable<KeyValuePair<string, XAQXIMHDBUG>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B0A0", Offset = "0x2B09EA0", VA = "0x182B0B0A0")]
		public static HKBEYLDNIPR New(IEnumerable<VAFAFNFBAFU> typeParameters, IEnumerable<KeyValuePair<string, NMYHGSQXUAN>> inputs, IEnumerable<KeyValuePair<string, XAQXIMHDBUG>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B2C0", Offset = "0x2B0A0C0", VA = "0x182B0B2C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B5C0", Offset = "0x2B0A3C0", VA = "0x182B0B5C0", Slot = "15")]
		public sealed override string VRCYNZLPIBZ(IReadOnlyList<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AEB0", Offset = "0x2B09CB0", VA = "0x182B0AEB0")]
		private string EFOJDLTVMPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AD30", Offset = "0x2B09B30", VA = "0x182B0AD30")]
		private string DCNVAIOZZVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AC00", Offset = "0x2B09A00", VA = "0x182B0AC00", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AC50", Offset = "0x2B09A50", VA = "0x182B0AC50")]
		public bool BURZPLIABAB([In] HKBEYLDNIPR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B030", Offset = "0x2B09E30", VA = "0x182B0B030", Slot = "18")]
		public bool Equals(HKBEYLDNIPR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B050", Offset = "0x2B09E50", VA = "0x182B0B050", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B1E0", Offset = "0x2B09FE0", VA = "0x182B0B1E0", Slot = "14")]
		protected sealed override int TSLCXIHVRJE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B1D0", Offset = "0x2B09FD0", VA = "0x182B0B1D0", Slot = "19")]
		private bool OJTGKFWURJE([In] HKBEYLDNIPR other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class OUKIDLVXAHM : JHOEKUEVGUO, IEquatable<OUKIDLVXAHM>, GCLDOOWCVKA<OUKIDLVXAHM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E8F0", Offset = "0x2B0D6F0", VA = "0x182B0E8F0")]
		private OUKIDLVXAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E760", Offset = "0x2B0D560", VA = "0x182B0E760")]
		public static OUKIDLVXAHM New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E7D0", Offset = "0x2B0D5D0", VA = "0x182B0E7D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E800", Offset = "0x2B0D600", VA = "0x182B0E800", Slot = "15")]
		public override string VRCYNZLPIBZ(IReadOnlyList<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E670", Offset = "0x2B0D470", VA = "0x182B0E670", Slot = "16")]
		public override int BXFYTZYQHSY(IReadOnlyList<JHOEKUEVGUO> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E710", Offset = "0x2B0D510", VA = "0x182B0E710", Slot = "17")]
		public override bool HOEVNFPOFBT(IReadOnlyList<JHOEKUEVGUO> a, IReadOnlyList<JHOEKUEVGUO> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E620", Offset = "0x2B0D420", VA = "0x182B0E620", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250")]
		public bool BURZPLIABAB([In] OUKIDLVXAHM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB79CA0", Offset = "0xB78AA0", VA = "0x180B79CA0", Slot = "18")]
		public bool Equals(OUKIDLVXAHM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E6C0", Offset = "0x2B0D4C0", VA = "0x182B0E6C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250", Slot = "19")]
		private bool EGTGUNAUWPB([In] OUKIDLVXAHM other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, GCLDOOWCVKA<Property>, FQNLSQWNTKZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool ZADZTADTOZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int ALWVIVXUCRO;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public JHOEKUEVGUO QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool WMRAXAWTOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HFMEIICERXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x123BE30", Offset = "0x123AC30", VA = "0x18123BE30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EED0", Offset = "0x2B0DCD0", VA = "0x182B0EED0")]
		private Property(JHOEKUEVGUO type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EB50", Offset = "0x2B0D950", VA = "0x182B0EB50")]
		public static Property New(JHOEKUEVGUO type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EC90", Offset = "0x2B0DA90", VA = "0x182B0EC90", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EE80", Offset = "0x2B0DC80", VA = "0x182B0EE80")]
		private string XYNSNEESCMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EE30", Offset = "0x2B0DC30", VA = "0x182B0EE30")]
		private string VIVJNCRSZZP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E910", Offset = "0x2B0D710", VA = "0x182B0E910")]
		public bool BURZPLIABAB([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EA60", Offset = "0x2B0D860", VA = "0x182B0EA60", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EA10", Offset = "0x2B0D810", VA = "0x182B0EA10", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EA80", Offset = "0x2B0D880", VA = "0x182B0EA80", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EBE0", Offset = "0x2B0D9E0", VA = "0x182B0EBE0")]
		private int TSLCXIHVRJE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ED70", Offset = "0x2B0DB70", VA = "0x182B0ED70", Slot = "6")]
		public int VGMTVBFVDWO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EB40", Offset = "0x2B0D940", VA = "0x182B0EB40", Slot = "5")]
		private bool JOZYRAINNHZ([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class OHNBFRNXGXB : JHOEKUEVGUO, IEquatable<OHNBFRNXGXB>, GCLDOOWCVKA<OHNBFRNXGXB>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E600", Offset = "0x2B0D400", VA = "0x182B0E600")]
		private OHNBFRNXGXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E4E0", Offset = "0x2B0D2E0", VA = "0x182B0E4E0")]
		public static OHNBFRNXGXB New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E550", Offset = "0x2B0D350", VA = "0x182B0E550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E580", Offset = "0x2B0D380", VA = "0x182B0E580", Slot = "15")]
		public override string VRCYNZLPIBZ(IReadOnlyList<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E440", Offset = "0x2B0D240", VA = "0x182B0E440", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250")]
		public bool BURZPLIABAB([In] OHNBFRNXGXB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xB79CA0", Offset = "0xB78AA0", VA = "0x180B79CA0", Slot = "18")]
		public bool Equals(OHNBFRNXGXB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E490", Offset = "0x2B0D290", VA = "0x182B0E490", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250", Slot = "19")]
		private bool EPGAZZRWBSA([In] OHNBFRNXGXB other)
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
	public sealed class KVDOWGFIBWT : JHOEKUEVGUO, IEquatable<KVDOWGFIBWT>, GCLDOOWCVKA<KVDOWGFIBWT>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool MMFKOKXIIYB
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D300", Offset = "0x2B0C100", VA = "0x182B0D300", Slot = "9")]
		public sealed override JHOEKUEVGUO MDQHUYSVFBP(IReadOnlyDictionary<string, JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D460", Offset = "0x2B0C260", VA = "0x182B0D460", Slot = "11")]
		public sealed override void RQWUAHFHGKP(Action<JHOEKUEVGUO> a, Action<JHOEKUEVGUO> b, Action<JHOEKUEVGUO> c, Action<JHOEKUEVGUO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D4B0", Offset = "0x2B0C2B0", VA = "0x182B0D4B0")]
		private KVDOWGFIBWT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D3E0", Offset = "0x2B0C1E0", VA = "0x182B0D3E0")]
		public static KVDOWGFIBWT New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D260", Offset = "0x2B0C060", VA = "0x182B0D260", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250")]
		public bool BURZPLIABAB([In] KVDOWGFIBWT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xB79CA0", Offset = "0xB78AA0", VA = "0x180B79CA0", Slot = "18")]
		public bool Equals(KVDOWGFIBWT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D2B0", Offset = "0x2B0C0B0", VA = "0x182B0D2B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D490", Offset = "0x2B0C290", VA = "0x182B0D490", Slot = "14")]
		protected sealed override int TSLCXIHVRJE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250", Slot = "19")]
		private bool GTOQGCYNPNI([In] KVDOWGFIBWT other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class ZANJJEXRLCS : JHOEKUEVGUO
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<VAFAFNFBAFU> WPTDRWNOFAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2B120F0", Offset = "0x2B10EF0", VA = "0x182B120F0")]
		public void Initialize(ZANJJEXRLCS from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2B121A0", Offset = "0x2B10FA0", VA = "0x182B121A0")]
		protected ZANJJEXRLCS(IEnumerable<VAFAFNFBAFU> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool BURZPLIABAB([In] JHOEKUEVGUO other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2B12010", Offset = "0x2B10E10", VA = "0x182B12010")]
		protected bool BURZPLIABAB([In] ZANJJEXRLCS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2B12120", Offset = "0x2B10F20", VA = "0x182B12120", Slot = "14")]
		protected override int TSLCXIHVRJE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2B12070", Offset = "0x2B10E70", VA = "0x182B12070")]
		protected int EQZVNJMUGBO(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class VAFAFNFBAFU : JHOEKUEVGUO, IEquatable<VAFAFNFBAFU>, GCLDOOWCVKA<VAFAFNFBAFU>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public JHOEKUEVGUO PLLAZOXJMMM
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2B11DD0", Offset = "0x2B10BD0", VA = "0x182B11DD0")]
		private VAFAFNFBAFU(string a, [Optional] JHOEKUEVGUO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2B11B50", Offset = "0x2B10950", VA = "0x182B11B50")]
		public static VAFAFNFBAFU New(string name, [Optional] JHOEKUEVGUO constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B11CD0", Offset = "0x2B10AD0", VA = "0x182B11CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B11A10", Offset = "0x2B10810", VA = "0x182B11A10", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B11A60", Offset = "0x2B10860", VA = "0x182B11A60")]
		public bool BURZPLIABAB([In] VAFAFNFBAFU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B11B00", Offset = "0x2B10900", VA = "0x182B11B00", Slot = "18")]
		public bool Equals(VAFAFNFBAFU other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B11AB0", Offset = "0x2B108B0", VA = "0x182B11AB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B11C50", Offset = "0x2B10A50", VA = "0x182B11C50", Slot = "14")]
		protected override int TSLCXIHVRJE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2B11D60", Offset = "0x2B10B60", VA = "0x182B11D60", Slot = "13")]
		public override int VGMTVBFVDWO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2B11A60", Offset = "0x2B10860", VA = "0x182B11A60", Slot = "19")]
		private bool FSTATDSMTWZ([In] VAFAFNFBAFU other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class TCUDCMMQEAO : JHOEKUEVGUO, IEquatable<TCUDCMMQEAO>, GCLDOOWCVKA<TCUDCMMQEAO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F500", Offset = "0x2B0E300", VA = "0x182B0F500")]
		private TCUDCMMQEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F370", Offset = "0x2B0E170", VA = "0x182B0F370")]
		public static TCUDCMMQEAO New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F3E0", Offset = "0x2B0E1E0", VA = "0x182B0F3E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F410", Offset = "0x2B0E210", VA = "0x182B0F410", Slot = "15")]
		public override string VRCYNZLPIBZ(IReadOnlyList<JHOEKUEVGUO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F280", Offset = "0x2B0E080", VA = "0x182B0F280", Slot = "16")]
		public override int BXFYTZYQHSY(IReadOnlyList<JHOEKUEVGUO> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F320", Offset = "0x2B0E120", VA = "0x182B0F320", Slot = "17")]
		public override bool HOEVNFPOFBT(IReadOnlyList<JHOEKUEVGUO> a, IReadOnlyList<JHOEKUEVGUO> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F230", Offset = "0x2B0E030", VA = "0x182B0F230", Slot = "12")]
		public override bool BURZPLIABAB([In] JHOEKUEVGUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250")]
		public bool BURZPLIABAB([In] TCUDCMMQEAO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xB79CA0", Offset = "0xB78AA0", VA = "0x180B79CA0", Slot = "18")]
		public bool Equals(TCUDCMMQEAO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F2D0", Offset = "0x2B0E0D0", VA = "0x182B0F2D0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D250", Offset = "0x2B0C050", VA = "0x182B0D250", Slot = "19")]
		private bool HYVJZLSZWCN([In] TCUDCMMQEAO other)
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
			public readonly JHOEKUEVGUO CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
			internal Impl(JHOEKUEVGUO circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2B06670", Offset = "0x2B05470", VA = "0x182B06670")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B063E0", Offset = "0x2B051E0", VA = "0x182B063E0")]
		public static CircuitTypeOrString GAMBZBTVIJU(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B06450", Offset = "0x2B05250", VA = "0x182B06450")]
		public static CircuitTypeOrString GAMBZBTVIJU(JHOEKUEVGUO a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B064B0", Offset = "0x2B052B0", VA = "0x182B064B0")]
		public JHOEKUEVGUO IEEUQCIETWN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B06550", Offset = "0x2B05350", VA = "0x182B06550")]
		public static JHOEKUEVGUO[] IXEMZTVUSLS(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly NDCNUEMFDKZ _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		private ClassFactoryBaseClasses(NDCNUEMFDKZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x14CA840", Offset = "0x14C9640", VA = "0x1814CA840")]
		public static ClassFactoryBaseClasses New(NDCNUEMFDKZ data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B066A0", Offset = "0x2B054A0", VA = "0x182B066A0")]
		public ClassFactoryBaseClasses GASYISQWAZZ(HWVCIXNUHHP a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2B06760", Offset = "0x2B05560", VA = "0x182B06760")]
		public ClassFactoryProps LPAPURPWKNO()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B06780", Offset = "0x2B05580", VA = "0x182B06780")]
		public ClassFactoryProps WQITYYUQOAN(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B067E0", Offset = "0x2B055E0", VA = "0x182B067E0")]
		public HWVCIXNUHHP WSFNWRHTUQM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class NDCNUEMFDKZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? QXVQSTMOTBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string JDIPTDKIYCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<VAFAFNFBAFU> WPTDRWNOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<HWVCIXNUHHP> DECGLJVHITU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> NHFFDHRTOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, HKBEYLDNIPR>> XYQXLJQHAPO;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E130", Offset = "0x2B0CF30", VA = "0x182B0E130")]
		private NDCNUEMFDKZ([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DF80", Offset = "0x2B0CD80", VA = "0x182B0DF80")]
		public static NDCNUEMFDKZ New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly NDCNUEMFDKZ _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		private ClassFactoryFuncs(NDCNUEMFDKZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x14CA840", Offset = "0x14C9640", VA = "0x1814CA840")]
		public static ClassFactoryFuncs New(NDCNUEMFDKZ data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B06830", Offset = "0x2B05630", VA = "0x182B06830")]
		public HWVCIXNUHHP WSFNWRHTUQM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly NDCNUEMFDKZ _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		public ClassFactoryProps(NDCNUEMFDKZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B06980", Offset = "0x2B05780", VA = "0x182B06980")]
		public ClassFactoryProps WQITYYUQOAN(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2B06760", Offset = "0x2B05560", VA = "0x182B06760")]
		public ClassFactoryFuncs FVDNMYVIMOJ()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B06B10", Offset = "0x2B05910", VA = "0x182B06B10")]
		public HWVCIXNUHHP WSFNWRHTUQM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly NDCNUEMFDKZ _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		private ClassFactoryTypeParams(NDCNUEMFDKZ data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B06E30", Offset = "0x2B05C30", VA = "0x182B06E30")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B06B50", Offset = "0x2B05950", VA = "0x182B06B50")]
		public ClassFactoryTypeParams BQPFJTNXPOF(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2B06760", Offset = "0x2B05560", VA = "0x182B06760")]
		public ClassFactoryBaseClasses RITAFTACQOR()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B06DF0", Offset = "0x2B05BF0", VA = "0x182B06DF0")]
		public ClassFactoryBaseClasses GASYISQWAZZ(HWVCIXNUHHP a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B07000", Offset = "0x2B05E00", VA = "0x182B07000")]
		public HWVCIXNUHHP WSFNWRHTUQM()
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
