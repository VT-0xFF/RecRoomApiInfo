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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class WPCWYXTKXZN : IEquatable<WPCWYXTKXZN>, DAMLRSAATDB<WPCWYXTKXZN>, WTCGLJIKYVY
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool WTUHUZFJBVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool FFXFLORHNQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int RXQNJPFRBLB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind CXTXOPLXEQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? PDVUNDORSUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B2E2F0", Offset = "0x2B2C8F0", VA = "0x182B2E2F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual WPCWYXTKXZN VJTLMSGUDQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool NOYJPAWMVPI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E260", Offset = "0x2B2C860", VA = "0x182B2E260")]
		public static void FTYJJGFKYMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
		protected WPCWYXTKXZN(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E5A0", Offset = "0x2B2CBA0", VA = "0x182B2E5A0")]
		public static WPCWYXTKXZN New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		protected static a JERDNQZHZMT<a>(a a) where a : WPCWYXTKXZN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "9")]
		public virtual WPCWYXTKXZN BPZUXLRDSFW(IReadOnlyDictionary<string, WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E660", Offset = "0x2B2CC60", VA = "0x182B2E660", Slot = "11")]
		public virtual void SSXEOMZTDOY(Action<WPCWYXTKXZN> a, Action<WPCWYXTKXZN> b, Action<WPCWYXTKXZN> c, Action<WPCWYXTKXZN> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E690", Offset = "0x2B2CC90", VA = "0x182B2E690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E840", Offset = "0x2B2CE40", VA = "0x182B2E840", Slot = "12")]
		public virtual bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E1E0", Offset = "0x2B2C7E0", VA = "0x182B2E1E0", Slot = "4")]
		public bool Equals(WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E210", Offset = "0x2B2C810", VA = "0x182B2E210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E410", Offset = "0x2B2CA10", VA = "0x182B2E410")]
		public static bool HCJGUXGANNO(WPCWYXTKXZN a, WPCWYXTKXZN b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E800", Offset = "0x2B2CE00", VA = "0x182B2E800")]
		public static bool VSCIXNKBWNJ(WPCWYXTKXZN a, WPCWYXTKXZN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E360", Offset = "0x2B2C960", VA = "0x182B2E360", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E160", Offset = "0x2B2C760", VA = "0x182B2E160", Slot = "13")]
		public virtual int GVQECZHDIXB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E160", Offset = "0x2B2C760", VA = "0x182B2E160", Slot = "14")]
		protected virtual int BMSZSFPRISP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EC58C0", Offset = "0x3EC3EC0", VA = "0x183EC58C0")]
		public b UKIMDYNJUJF<b>() where b : WPCWYXTKXZN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B238D0", Offset = "0x2B21ED0", VA = "0x182B238D0", Slot = "15")]
		public virtual string UIVTQJMHANS(IReadOnlyList<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E610", Offset = "0x2B2CC10", VA = "0x182B2E610", Slot = "16")]
		public virtual int RNWUEEZBGEH(IReadOnlyList<WPCWYXTKXZN> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E190", Offset = "0x2B2C790", VA = "0x182B2E190", Slot = "17")]
		public virtual bool CQJEUKVMTJU(IReadOnlyList<WPCWYXTKXZN> a, IReadOnlyList<WPCWYXTKXZN> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E460", Offset = "0x2B2CA60", VA = "0x182B2E460")]
		public PKAKPCXWAYS IACECCYFYJK(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E450", Offset = "0x2B2CA50", VA = "0x182B2E450")]
		public PKAKPCXWAYS IACECCYFYJK(params WPCWYXTKXZN[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E450", Offset = "0x2B2CA50", VA = "0x182B2E450")]
		public PKAKPCXWAYS IACECCYFYJK(IEnumerable<WPCWYXTKXZN> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface UWEOGEPSJXO<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a MLPSYOJBSPQ(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b DSTAUUVRAJK([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind ROCXVTMKKMK([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates TBAWTTYZFHT(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface WTCGLJIKYVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GVQECZHDIXB(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GVQECZHDIXB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class UIPBRHOSQCJ<a> where a : WTCGLJIKYVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int VCCTJFOLIAY;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UIPBRHOSQCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63B2650", Offset = "0x63B0C50", VA = "0x1863B2650")]
			internal int BWGFTJMFWPU(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class UKJSHZDWQSD<a, b> where b : WTCGLJIKYVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int VCCTJFOLIAY;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UKJSHZDWQSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63B47C0", Offset = "0x63B2DC0", VA = "0x1863B47C0")]
			internal int BWGFTJMFWPU(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class OGZDNFCTUGP<a> where a : WTCGLJIKYVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int VCCTJFOLIAY;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGZDNFCTUGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5BC0100", Offset = "0x5BBE700", VA = "0x185BC0100")]
			internal int SHEWASEJXVZ(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x38E6810", Offset = "0x38E4E10", VA = "0x1838E6810")]
		public static int YGMXCHONGTW<a>(this IEnumerable<a> a, int b = 0) where a : WTCGLJIKYVY
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38E68E0", Offset = "0x38E4EE0", VA = "0x1838E68E0")]
		public static int YGMXCHONGTW<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : WTCGLJIKYVY
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38E6810", Offset = "0x38E4E10", VA = "0x1838E6810")]
		public static int RLLWOMUQFXV<d>(this IEnumerable<d> a, int b = 0) where d : WTCGLJIKYVY
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : UWEOGEPSJXO<TDirectedType, WPCWYXTKXZN, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x43059B0", Offset = "0x4303FB0", VA = "0x1843059B0")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x636C8E0", Offset = "0x636AEE0", VA = "0x18636C8E0")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class DOKUUVCQDPH
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QAREISBGPNF<a, b, c> where c : UWEOGEPSJXO<a, WPCWYXTKXZN, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public WPCWYXTKXZN QFDWPNWHLQH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<WPCWYXTKXZN> ETZDRBAKKJQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public WPCWYXTKXZN KGLCKJWPNJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<WPCWYXTKXZN> MXATIFTSDID;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QAREISBGPNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8C70", Offset = "0x5CF7270", VA = "0x185CF8C70")]
			internal bool NAOBQOVPYGJ([In] TypeSys<a, b, c> self_, WPCWYXTKXZN a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8B70", Offset = "0x5CF7170", VA = "0x185CF8B70")]
			internal bool MZYGYUNXVYI([In] TypeSys<a, b, c> self_, WPCWYXTKXZN a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5CF88D0", Offset = "0x5CF6ED0", VA = "0x185CF88D0")]
			internal bool MZTABNUAMMZ([In] TypeSys<a, b, c> self_, WPCWYXTKXZN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class TAASXRWKOQQ<a, b, c> where c : UWEOGEPSJXO<a, WPCWYXTKXZN, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public WPCWYXTKXZN JQMZCPMYYID;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TAASXRWKOQQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6126C70", Offset = "0x6125270", VA = "0x186126C70")]
			internal bool MZNTEHADDBQ([In] TypeSys<a, b, c> self__, WPCWYXTKXZN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class OGHKVWFUKAN<a, b, c> where c : UWEOGEPSJXO<a, WPCWYXTKXZN, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b UPYDKJXZEYI;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGHKVWFUKAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5BBF2F0", Offset = "0x5BBD8F0", VA = "0x185BBF2F0")]
			internal WPCWYXTKXZN QNMNPPGWNJE([In] TypeSys<a, b, c> self_, [In] b root_, WPCWYXTKXZN a, WPCWYXTKXZN b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GVTMHZIHNZU<a, b, c> where c : UWEOGEPSJXO<a, WPCWYXTKXZN, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public UPALZYLPQSM PAHPHJVFJSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public UPALZYLPQSM ANGFNPLTKDA;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public GVTMHZIHNZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5074AE0", Offset = "0x50730E0", VA = "0x185074AE0")]
			internal a QNHGSIMZDXV([In] TypeSys<a, b, c> self_, IOKind a, UPALZYLPQSM b, UPALZYLPQSM c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class RXBLQMCONSX<a, b, c> where c : UWEOGEPSJXO<a, WPCWYXTKXZN, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<UPALZYLPQSM> GBMPUXZYUDG;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RXBLQMCONSX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5D6D8C0", Offset = "0x5D6BEC0", VA = "0x185D6D8C0")]
			internal bool PRZVUJYKYUD(bool a, UPALZYLPQSM b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] CUYPAVXWFJI;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37ABED0", Offset = "0x37AA4D0", VA = "0x1837ABED0")]
		public static bool WAACWHPNVWX<a, b, c>([In] this TypeSys<a, b, c> _, WPCWYXTKXZN a) where c : UWEOGEPSJXO<a, WPCWYXTKXZN, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37ABEB0", Offset = "0x37AA4B0", VA = "0x1837ABEB0")]
		public static bool TVDIGBGQVRS<d, e, f>([In] this TypeSys<d, e, f> _, WPCWYXTKXZN a) where f : UWEOGEPSJXO<d, WPCWYXTKXZN, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37AA120", Offset = "0x37A8720", VA = "0x1837AA120")]
		public static bool MJIRBHFKSUA<g, h, i>([In] this TypeSys<g, h, i> self, WPCWYXTKXZN a, WPCWYXTKXZN b) where i : UWEOGEPSJXO<g, WPCWYXTKXZN, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37AACC0", Offset = "0x37A92C0", VA = "0x1837AACC0")]
		private static bool QOKYXNABPMV<j, k, l>([In] this TypeSys<j, k, l> self, WPCWYXTKXZN a, WPCWYXTKXZN b, IReadOnlyList<WPCWYXTKXZN> c, IReadOnlyList<WPCWYXTKXZN> d) where l : UWEOGEPSJXO<j, WPCWYXTKXZN, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x37A4A20", Offset = "0x37A3020", VA = "0x1837A4A20")]
		public static WPCWYXTKXZN CCOWXNGADAT<m, n, o>([In] this TypeSys<m, n, o> self, n a, WPCWYXTKXZN b, WPCWYXTKXZN c) where o : UWEOGEPSJXO<m, WPCWYXTKXZN, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37A1C50", Offset = "0x37A0250", VA = "0x1837A1C50")]
		public static p CCOWXNGADAT<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : UWEOGEPSJXO<p, WPCWYXTKXZN, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37A9D40", Offset = "0x37A8340", VA = "0x1837A9D40")]
		private static List<w> DAVMDNMFSVV<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : UWEOGEPSJXO<t, WPCWYXTKXZN, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37AAB20", Offset = "0x37A9120", VA = "0x1837AAB20")]
		private static ba OCZGVWZTQRH<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class FIGAAMXJXWM
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static WPCWYXTKXZN KAEFRYWYDYV
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B250F0", Offset = "0x2B236F0", VA = "0x182B250F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static WPCWYXTKXZN MJADKPGVGUB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2B24D30", Offset = "0x2B23330", VA = "0x182B24D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static WPCWYXTKXZN ZXELHDYAADE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2B24E70", Offset = "0x2B23470", VA = "0x182B24E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static WPCWYXTKXZN SWHGYVXAUAM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2B24D80", Offset = "0x2B23380", VA = "0x182B24D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static WPCWYXTKXZN DDNUILZQZXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2B24E20", Offset = "0x2B23420", VA = "0x182B24E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static WPCWYXTKXZN JRXKAEIVZLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2B25220", Offset = "0x2B23820", VA = "0x182B25220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static WPCWYXTKXZN QYUZBGSJRXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2B24DD0", Offset = "0x2B233D0", VA = "0x182B24DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static WPCWYXTKXZN KNCMWOYLBDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2B251D0", Offset = "0x2B237D0", VA = "0x182B251D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B24C00", Offset = "0x2B23200", VA = "0x182B24C00")]
		public static PKAKPCXWAYS EHOSSFEDPHQ([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B249A0", Offset = "0x2B22FA0", VA = "0x182B249A0")]
		public static PKAKPCXWAYS AMVYPLUFMJK(IEnumerable<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B25060", Offset = "0x2B23660", VA = "0x182B25060")]
		public static PKAKPCXWAYS SRADZKIQYAI(IEnumerable<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B24EC0", Offset = "0x2B234C0", VA = "0x182B24EC0")]
		public static PKAKPCXWAYS SRADZKIQYAI(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B25140", Offset = "0x2B23740", VA = "0x182B25140")]
		public static PKAKPCXWAYS WTDXSNKRICZ(IEnumerable<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B24A30", Offset = "0x2B23030", VA = "0x182B24A30")]
		public static HRBSFXCBXWX CIUDGTMCBMK(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class PKAKPCXWAYS : WPCWYXTKXZN, IEquatable<PKAKPCXWAYS>, DAMLRSAATDB<PKAKPCXWAYS>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class TYGMGLNVTBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, WPCWYXTKXZN> UJTECILMINU;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TYGMGLNVTBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2B2ABD0", Offset = "0x2B291D0", VA = "0x182B2ABD0")]
			internal WPCWYXTKXZN GCWHUODTCKC(WPCWYXTKXZN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public WPCWYXTKXZN OTEBMSEGSOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override WPCWYXTKXZN VJTLMSGUDQT
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<WPCWYXTKXZN> ETGBFELUQHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool NOYJPAWMVPI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2B26580", Offset = "0x2B24B80", VA = "0x182B26580", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B263F0", Offset = "0x2B249F0", VA = "0x182B263F0", Slot = "9")]
		public sealed override WPCWYXTKXZN BPZUXLRDSFW(IReadOnlyDictionary<string, WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B26710", Offset = "0x2B24D10", VA = "0x182B26710", Slot = "11")]
		public sealed override void SSXEOMZTDOY(Action<WPCWYXTKXZN> a, Action<WPCWYXTKXZN> b, Action<WPCWYXTKXZN> c, Action<WPCWYXTKXZN> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B26AB0", Offset = "0x2B250B0", VA = "0x182B26AB0")]
		private PKAKPCXWAYS(WPCWYXTKXZN a, IEnumerable<WPCWYXTKXZN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B26690", Offset = "0x2B24C90", VA = "0x182B26690")]
		public static PKAKPCXWAYS New(WPCWYXTKXZN originalType, IEnumerable<WPCWYXTKXZN> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B26970", Offset = "0x2B24F70", VA = "0x182B26970", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B26A60", Offset = "0x2B25060", VA = "0x182B26A60", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B269C0", Offset = "0x2B24FC0", VA = "0x182B269C0")]
		public bool WYCXDAIGFPQ([In] PKAKPCXWAYS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B26560", Offset = "0x2B24B60", VA = "0x182B26560", Slot = "18")]
		public bool Equals(PKAKPCXWAYS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B26510", Offset = "0x2B24B10", VA = "0x182B26510", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B26340", Offset = "0x2B24940", VA = "0x182B26340", Slot = "14")]
		protected override int BMSZSFPRISP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B269B0", Offset = "0x2B24FB0", VA = "0x182B269B0", Slot = "19")]
		private bool VHISSJSJWGP([In] PKAKPCXWAYS other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class HLWWFOXZWUV : WPCWYXTKXZN, IEquatable<HLWWFOXZWUV>, DAMLRSAATDB<HLWWFOXZWUV>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B25980", Offset = "0x2B23F80", VA = "0x182B25980")]
		private HLWWFOXZWUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B25790", Offset = "0x2B23D90", VA = "0x182B25790")]
		public static HLWWFOXZWUV New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B25800", Offset = "0x2B23E00", VA = "0x182B25800", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B25860", Offset = "0x2B23E60", VA = "0x182B25860", Slot = "15")]
		public sealed override string UIVTQJMHANS(IReadOnlyList<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B25940", Offset = "0x2B23F40", VA = "0x182B25940")]
		private static string ZUEYFWBFRDA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B258F0", Offset = "0x2B23EF0", VA = "0x182B258F0", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730")]
		public bool WYCXDAIGFPQ([In] HLWWFOXZWUV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xBC4C40", Offset = "0xBC3240", VA = "0x180BC4C40", Slot = "18")]
		public bool Equals(HLWWFOXZWUV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B25740", Offset = "0x2B23D40", VA = "0x182B25740", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730", Slot = "19")]
		private bool DKZVKHOABIW([In] HLWWFOXZWUV other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class RQXLKNYJBVA
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public WPCWYXTKXZN YCIWUEURAKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<WPCWYXTKXZN, PKAKPCXWAYS> LFBFXAWJNPU;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2B2EA60", Offset = "0x2B2D060", VA = "0x182B2EA60")]
			internal PKAKPCXWAYS MCULOPLLKSW(WPCWYXTKXZN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class XLZAHPMEXGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public WPCWYXTKXZN NMUHQDRZRCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<WPCWYXTKXZN, PKAKPCXWAYS> FKPGYDNBMWW;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XLZAHPMEXGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x2B2E8E0", Offset = "0x2B2CEE0", VA = "0x182B2E8E0")]
			internal PKAKPCXWAYS ZSCIXNTTVJQ(WPCWYXTKXZN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B274B0", Offset = "0x2B25AB0", VA = "0x182B274B0")]
		public static IEnumerable<UPALZYLPQSM> CHHKBSVKVHE(this UPALZYLPQSM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B29940", Offset = "0x2B27F40", VA = "0x182B29940")]
		private static IEnumerable<UPALZYLPQSM> UWSRCZZULUY(this UPALZYLPQSM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A180", Offset = "0x2B28780", VA = "0x182B2A180")]
		public static (WPCWYXTKXZN, IReadOnlyList<WPCWYXTKXZN>, bool) XFDJKVWLNZM(this WPCWYXTKXZN a, [Optional] IReadOnlyList<WPCWYXTKXZN> b)
		{
			return default((WPCWYXTKXZN, IReadOnlyList<WPCWYXTKXZN>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B27480", Offset = "0x2B25A80", VA = "0x182B27480")]
		public static TypeKind AZDCWJRZHOV(this WPCWYXTKXZN a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B276E0", Offset = "0x2B25CE0", VA = "0x182B276E0")]
		private static WPCWYXTKXZN ConvertClassesToIntersections(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B28180", Offset = "0x2B26780", VA = "0x182B28180")]
		private static WPCWYXTKXZN DistributeUnionIntoIntersection(this PKAKPCXWAYS self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B27D10", Offset = "0x2B26310", VA = "0x182B27D10")]
		private static WPCWYXTKXZN DistributeIntersectionIntoIntersection(this PKAKPCXWAYS self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B28020", Offset = "0x2B26620", VA = "0x182B28020")]
		private static WPCWYXTKXZN DistributeIntoIntersection(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B28570", Offset = "0x2B26B70", VA = "0x182B28570")]
		private static bool OtherIsAssignableToOther(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes, WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B29A00", Offset = "0x2B28000", VA = "0x182B29A00")]
		private static bool UnionIsAssignableToOther(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes, WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B28700", Offset = "0x2B26D00", VA = "0x182B28700")]
		private static bool OtherIsAssignableToUnion(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes, WPCWYXTKXZN union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B29D20", Offset = "0x2B28320", VA = "0x182B29D20")]
		private static bool UnionIsAssignableToUnion(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes, WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B29740", Offset = "0x2B27D40", VA = "0x182B29740")]
		public static WPCWYXTKXZN RemoveCommonTypesFromIntersectionDistribution(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B28AA0", Offset = "0x2B270A0", VA = "0x182B28AA0")]
		public static WPCWYXTKXZN RemoveCommonTypesFromIntersectionDistributionInternal(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B29870", Offset = "0x2B27E70", VA = "0x182B29870")]
		public static WPCWYXTKXZN SimplifyIntersectionUnion(this WPCWYXTKXZN self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B28490", Offset = "0x2B26A90", VA = "0x182B28490")]
		public static IEnumerable<WPCWYXTKXZN> ETGBFELUQHJ(this WPCWYXTKXZN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B284E0", Offset = "0x2B26AE0", VA = "0x182B284E0")]
		public static IEnumerable<WPCWYXTKXZN> NWOWEOAURWU(this WPCWYXTKXZN a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class UPALZYLPQSM : RTBHFTIQLCF, IEquatable<UPALZYLPQSM>, DAMLRSAATDB<UPALZYLPQSM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class RQXWPFCKIQD : IEnumerable<UPALZYLPQSM>, IEnumerable, IEnumerator<UPALZYLPQSM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private UPALZYLPQSM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public UPALZYLPQSM CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<UPALZYLPQSM> TPFONUYPLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private UPALZYLPQSM IYOLMJLIPWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<UPALZYLPQSM> TPQCIIMKDYS;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private UPALZYLPQSM YQTLBXQMWUP
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public RQXWPFCKIQD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A3E0", Offset = "0x2B289E0", VA = "0x182B2A3E0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A5D0", Offset = "0x2B28BD0", VA = "0x182B2A5D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A580", Offset = "0x2B28B80", VA = "0x182B2A580")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A530", Offset = "0x2B28B30", VA = "0x182B2A530")]
			private void KOSXCWUKUNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A990", Offset = "0x2B28F90", VA = "0x182B2A990", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A340", Offset = "0x2B28940", VA = "0x182B2A340", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<UPALZYLPQSM> AILNAMUCQWQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2B2A340", Offset = "0x2B28940", VA = "0x182B2A340", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> CKWIMBLTFUE;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, UPALZYLPQSM> OFIRYISZDOR;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, UPALZYLPQSM> UHGOFYWVIPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D0E0", Offset = "0x2B2B6E0", VA = "0x182B2D0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? PDVUNDORSUB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid SNTOXKRGJFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xFD2F70", Offset = "0xFD1570", VA = "0x180FD2F70")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xFD28C0", Offset = "0xFD0EC0", VA = "0x180FD28C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAB0770", Offset = "0xAAED70", VA = "0x180AB0770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<UPALZYLPQSM> BBDDVUJDZXN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<UPALZYLPQSM> JTJYNLDGVXA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D370", Offset = "0x2B2B970", VA = "0x182B2D370")]
			[IteratorStateMachine(typeof(RQXWPFCKIQD))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> WNAALRPFZAR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB0B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, CMEPTWOOXZC> GGNUYUMXOCV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB0A0", VA = "0x180AACAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DD60", Offset = "0x2B2C360", VA = "0x182B2DD60")]
		public UPALZYLPQSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DDC0", Offset = "0x2B2C3C0", VA = "0x182B2DDC0")]
		public UPALZYLPQSM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D320", Offset = "0x2B2B920", VA = "0x182B2D320")]
		public static UPALZYLPQSM RWGBMKSJDZT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CEA0", Offset = "0x2B2B4A0", VA = "0x182B2CEA0")]
		public static UPALZYLPQSM IBUQOUGBKLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CEF0", Offset = "0x2B2B4F0", VA = "0x182B2CEF0")]
		public void Initialize(UPALZYLPQSM from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DAC0", Offset = "0x2B2C0C0", VA = "0x182B2DAC0")]
		private UPALZYLPQSM([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<HRBSFXCBXWX> c, [Optional] IEnumerable<UPALZYLPQSM> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, CMEPTWOOXZC>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D250", Offset = "0x2B2B850", VA = "0x182B2D250")]
		public static UPALZYLPQSM New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<HRBSFXCBXWX> typeParameters, [Optional] IEnumerable<UPALZYLPQSM> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, CMEPTWOOXZC>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D400", Offset = "0x2B2BA00", VA = "0x182B2D400", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D1F0", Offset = "0x2B2B7F0", VA = "0x182B2D1F0")]
		private string NZDQHIBLPVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D130", Offset = "0x2B2B730", VA = "0x182B2D130")]
		private static string KQDYXNGEYRW(IEnumerable<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D5C0", Offset = "0x2B2BBC0", VA = "0x182B2D5C0")]
		private string WCGBVBYSFOT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CBF0", Offset = "0x2B2B1F0", VA = "0x182B2CBF0")]
		private string FXHTRIGGPRA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D4F0", Offset = "0x2B2BAF0", VA = "0x182B2D4F0", Slot = "15")]
		public sealed override string UIVTQJMHANS(IReadOnlyList<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D870", Offset = "0x2B2BE70", VA = "0x182B2D870", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D8C0", Offset = "0x2B2BEC0", VA = "0x182B2D8C0")]
		public bool WYCXDAIGFPQ([In] UPALZYLPQSM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CB80", Offset = "0x2B2B180", VA = "0x182B2CB80", Slot = "18")]
		public bool Equals(UPALZYLPQSM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CBA0", Offset = "0x2B2B1A0", VA = "0x182B2CBA0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CA70", Offset = "0x2B2B070", VA = "0x182B2CA70", Slot = "14")]
		protected override int BMSZSFPRISP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D3F0", Offset = "0x2B2B9F0", VA = "0x182B2D3F0", Slot = "19")]
		private bool STHLHPUCCTR([In] UPALZYLPQSM other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class YJUFDAKSZBX
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<WPCWYXTKXZN> CSJJGXOJFNS;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<UPALZYLPQSM> SBBHBEYTPAR;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, HRBSFXCBXWX> VRLFNZXTSYA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> ZWVXABHPTAU;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, CMEPTWOOXZC> VEDPOETHBHT;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class GEYTHIOVNPS : IEquatable<GEYTHIOVNPS>, DAMLRSAATDB<GEYTHIOVNPS>, WTCGLJIKYVY
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public WPCWYXTKXZN BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		private GEYTHIOVNPS(WPCWYXTKXZN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B256D0", Offset = "0x2B23CD0", VA = "0x182B256D0")]
		public static GEYTHIOVNPS New(WPCWYXTKXZN type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2D00", Offset = "0x2AE1300", VA = "0x182AE2D00", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B23040", Offset = "0x2B21640", VA = "0x182B23040")]
		public bool WYCXDAIGFPQ([In] GEYTHIOVNPS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B230E0", Offset = "0x2B216E0", VA = "0x182B230E0", Slot = "4")]
		public bool Equals(GEYTHIOVNPS other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B25680", Offset = "0x2B23C80", VA = "0x182B25680", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD9E0", Offset = "0x2AFBFE0", VA = "0x182AFD9E0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B23130", Offset = "0x2B21730", VA = "0x182B23130", Slot = "6")]
		public int GVQECZHDIXB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B23040", Offset = "0x2B21640", VA = "0x182B23040", Slot = "5")]
		private bool XNBZPHWZCRR([In] GEYTHIOVNPS other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class CJWRSQVRIIV : IEquatable<CJWRSQVRIIV>, DAMLRSAATDB<CJWRSQVRIIV>, WTCGLJIKYVY
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public WPCWYXTKXZN BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		private CJWRSQVRIIV(WPCWYXTKXZN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B23160", Offset = "0x2B21760", VA = "0x182B23160")]
		public static CJWRSQVRIIV New(WPCWYXTKXZN type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AE2D00", Offset = "0x2AE1300", VA = "0x182AE2D00", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B23040", Offset = "0x2B21640", VA = "0x182B23040")]
		public bool WYCXDAIGFPQ([In] CJWRSQVRIIV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B230E0", Offset = "0x2B216E0", VA = "0x182B230E0", Slot = "4")]
		public bool Equals(CJWRSQVRIIV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B23090", Offset = "0x2B21690", VA = "0x182B23090", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD9E0", Offset = "0x2AFBFE0", VA = "0x182AFD9E0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2B23130", Offset = "0x2B21730", VA = "0x182B23130", Slot = "6")]
		public int GVQECZHDIXB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2B23040", Offset = "0x2B21640", VA = "0x182B23040", Slot = "5")]
		private bool CJJXFBNDTNK([In] CJWRSQVRIIV other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class CMEPTWOOXZC : RTBHFTIQLCF, IEquatable<CMEPTWOOXZC>, DAMLRSAATDB<CMEPTWOOXZC>, WTCGLJIKYVY
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, GEYTHIOVNPS>> CYIHXVVCFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, CJWRSQVRIIV>> TZXLIMBIXXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2B23BA0", Offset = "0x2B221A0", VA = "0x182B23BA0")]
		private CMEPTWOOXZC(IEnumerable<HRBSFXCBXWX> a, IEnumerable<KeyValuePair<string, GEYTHIOVNPS>> b, IEnumerable<KeyValuePair<string, CJWRSQVRIIV>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2B234A0", Offset = "0x2B21AA0", VA = "0x182B234A0")]
		public static CMEPTWOOXZC New(IEnumerable<HRBSFXCBXWX> typeParameters, IEnumerable<KeyValuePair<string, GEYTHIOVNPS>> inputs, IEnumerable<KeyValuePair<string, CJWRSQVRIIV>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2B235D0", Offset = "0x2B21BD0", VA = "0x182B235D0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2B238D0", Offset = "0x2B21ED0", VA = "0x182B238D0", Slot = "15")]
		public sealed override string UIVTQJMHANS(IReadOnlyList<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2B232A0", Offset = "0x2B218A0", VA = "0x182B232A0")]
		private string CKBPAAGXEYV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2B238F0", Offset = "0x2B21EF0", VA = "0x182B238F0")]
		private string VDSGHZIJJJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2B23B50", Offset = "0x2B22150", VA = "0x182B23B50", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2B23A70", Offset = "0x2B22070", VA = "0x182B23A70")]
		public bool WYCXDAIGFPQ([In] CMEPTWOOXZC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2B23420", Offset = "0x2B21A20", VA = "0x182B23420", Slot = "18")]
		public bool Equals(CMEPTWOOXZC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2B23440", Offset = "0x2B21A40", VA = "0x182B23440", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2B231C0", Offset = "0x2B217C0", VA = "0x182B231C0", Slot = "14")]
		protected sealed override int BMSZSFPRISP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2B23490", Offset = "0x2B21A90", VA = "0x182B23490", Slot = "19")]
		private bool LMOKPTKOISB([In] CMEPTWOOXZC other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class WFXNFKWZDEZ : WPCWYXTKXZN, IEquatable<WFXNFKWZDEZ>, DAMLRSAATDB<WFXNFKWZDEZ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E140", Offset = "0x2B2C740", VA = "0x182B2E140")]
		private WFXNFKWZDEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DF10", Offset = "0x2B2C510", VA = "0x182B2DF10")]
		public static WFXNFKWZDEZ New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DFD0", Offset = "0x2B2C5D0", VA = "0x182B2DFD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E000", Offset = "0x2B2C600", VA = "0x182B2E000", Slot = "15")]
		public override string UIVTQJMHANS(IReadOnlyList<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DF80", Offset = "0x2B2C580", VA = "0x182B2DF80", Slot = "16")]
		public override int RNWUEEZBGEH(IReadOnlyList<WPCWYXTKXZN> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DE70", Offset = "0x2B2C470", VA = "0x182B2DE70", Slot = "17")]
		public override bool CQJEUKVMTJU(IReadOnlyList<WPCWYXTKXZN> a, IReadOnlyList<WPCWYXTKXZN> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2E0F0", Offset = "0x2B2C6F0", VA = "0x182B2E0F0", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730")]
		public bool WYCXDAIGFPQ([In] WFXNFKWZDEZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xBC4C40", Offset = "0xBC3240", VA = "0x180BC4C40", Slot = "18")]
		public bool Equals(WFXNFKWZDEZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2B2DEC0", Offset = "0x2B2C4C0", VA = "0x182B2DEC0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730", Slot = "19")]
		private bool RXEAGBAEBME([In] WFXNFKWZDEZ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, DAMLRSAATDB<Property>, WTCGLJIKYVY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool FFXFLORHNQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int RXQNJPFRBLB;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public WPCWYXTKXZN BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GUDXPTFLCOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool AMVFYSLQQJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x12B79D0", Offset = "0x12B5FD0", VA = "0x1812B79D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B27130", Offset = "0x2B25730", VA = "0x182B27130")]
		private Property(WPCWYXTKXZN type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B26E70", Offset = "0x2B25470", VA = "0x182B26E70")]
		public static Property New(WPCWYXTKXZN type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2B26F00", Offset = "0x2B25500", VA = "0x182B26F00", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2B26E20", Offset = "0x2B25420", VA = "0x182B26E20")]
		private string JEKDNOZHIIY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2B270E0", Offset = "0x2B256E0", VA = "0x182B270E0")]
		private string ZRPCTTIYXGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2B26FE0", Offset = "0x2B255E0", VA = "0x182B26FE0")]
		public bool WYCXDAIGFPQ([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2B26C70", Offset = "0x2B25270", VA = "0x182B26C70", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2B26C20", Offset = "0x2B25220", VA = "0x182B26C20", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2B26D50", Offset = "0x2B25350", VA = "0x182B26D50", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2B26B70", Offset = "0x2B25170", VA = "0x182B26B70")]
		private int BMSZSFPRISP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2B26C90", Offset = "0x2B25290", VA = "0x182B26C90", Slot = "6")]
		public int GVQECZHDIXB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2B26E10", Offset = "0x2B25410", VA = "0x182B26E10", Slot = "5")]
		private bool IWXDOAFFGGQ([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class NJXVOOYJJJI : WPCWYXTKXZN, IEquatable<NJXVOOYJJJI>, DAMLRSAATDB<NJXVOOYJJJI>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2B26320", Offset = "0x2B24920", VA = "0x182B26320")]
		private NJXVOOYJJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2B261B0", Offset = "0x2B247B0", VA = "0x182B261B0")]
		public static NJXVOOYJJJI New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2B26220", Offset = "0x2B24820", VA = "0x182B26220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2B26250", Offset = "0x2B24850", VA = "0x182B26250", Slot = "15")]
		public override string UIVTQJMHANS(IReadOnlyList<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2B262D0", Offset = "0x2B248D0", VA = "0x182B262D0", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730")]
		public bool WYCXDAIGFPQ([In] NJXVOOYJJJI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xBC4C40", Offset = "0xBC3240", VA = "0x180BC4C40", Slot = "18")]
		public bool Equals(NJXVOOYJJJI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2B26160", Offset = "0x2B24760", VA = "0x182B26160", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730", Slot = "19")]
		private bool NHBFYSLQAPH([In] NJXVOOYJJJI other)
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
	public sealed class YBZMAKPICRC : WPCWYXTKXZN, IEquatable<YBZMAKPICRC>, DAMLRSAATDB<YBZMAKPICRC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool NOYJPAWMVPI
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EC00", Offset = "0x2B2D200", VA = "0x182B2EC00", Slot = "9")]
		public sealed override WPCWYXTKXZN BPZUXLRDSFW(IReadOnlyDictionary<string, WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EDB0", Offset = "0x2B2D3B0", VA = "0x182B2EDB0", Slot = "11")]
		public sealed override void SSXEOMZTDOY(Action<WPCWYXTKXZN> a, Action<WPCWYXTKXZN> b, Action<WPCWYXTKXZN> c, Action<WPCWYXTKXZN> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EE30", Offset = "0x2B2D430", VA = "0x182B2EE30")]
		private YBZMAKPICRC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2ED30", Offset = "0x2B2D330", VA = "0x182B2ED30")]
		public static YBZMAKPICRC New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EDE0", Offset = "0x2B2D3E0", VA = "0x182B2EDE0", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730")]
		public bool WYCXDAIGFPQ([In] YBZMAKPICRC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xBC4C40", Offset = "0xBC3240", VA = "0x180BC4C40", Slot = "18")]
		public bool Equals(YBZMAKPICRC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2B2ECE0", Offset = "0x2B2D2E0", VA = "0x182B2ECE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2B2EBE0", Offset = "0x2B2D1E0", VA = "0x182B2EBE0", Slot = "14")]
		protected sealed override int BMSZSFPRISP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730", Slot = "19")]
		private bool OGBMKQRNVVL([In] YBZMAKPICRC other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class RTBHFTIQLCF : WPCWYXTKXZN
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<HRBSFXCBXWX> OJVRULHNIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AA50", Offset = "0x2B29050", VA = "0x182B2AA50")]
		public void Initialize(RTBHFTIQLCF from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AB60", Offset = "0x2B29160", VA = "0x182B2AB60")]
		protected RTBHFTIQLCF(IEnumerable<HRBSFXCBXWX> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AB00", Offset = "0x2B29100", VA = "0x182B2AB00")]
		protected bool WYCXDAIGFPQ([In] RTBHFTIQLCF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2B2A9D0", Offset = "0x2B28FD0", VA = "0x182B2A9D0", Slot = "14")]
		protected override int BMSZSFPRISP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2AA80", Offset = "0x2B29080", VA = "0x182B2AA80")]
		protected int KJSWUOHLIDP(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class HRBSFXCBXWX : WPCWYXTKXZN, IEquatable<HRBSFXCBXWX>, DAMLRSAATDB<HRBSFXCBXWX>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public WPCWYXTKXZN HMTVOSZUYWT
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2B25D60", Offset = "0x2B24360", VA = "0x182B25D60")]
		private HRBSFXCBXWX(string a, [Optional] WPCWYXTKXZN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2B25B30", Offset = "0x2B24130", VA = "0x182B25B30")]
		public static HRBSFXCBXWX New(string name, [Optional] WPCWYXTKXZN constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2B25C80", Offset = "0x2B24280", VA = "0x182B25C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2B25D10", Offset = "0x2B24310", VA = "0x182B25D10", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2B25C30", Offset = "0x2B24230", VA = "0x182B25C30")]
		public bool WYCXDAIGFPQ([In] HRBSFXCBXWX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2B25A70", Offset = "0x2B24070", VA = "0x182B25A70", Slot = "18")]
		public bool Equals(HRBSFXCBXWX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2B25A20", Offset = "0x2B24020", VA = "0x182B25A20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2B259A0", Offset = "0x2B23FA0", VA = "0x182B259A0", Slot = "14")]
		protected override int BMSZSFPRISP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2B25AC0", Offset = "0x2B240C0", VA = "0x182B25AC0", Slot = "13")]
		public override int GVQECZHDIXB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2B25C30", Offset = "0x2B24230", VA = "0x182B25C30", Slot = "19")]
		private bool PYBKMHPYAKA([In] HRBSFXCBXWX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class QIRHVUVQSXZ : WPCWYXTKXZN, IEquatable<QIRHVUVQSXZ>, DAMLRSAATDB<QIRHVUVQSXZ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2B27460", Offset = "0x2B25A60", VA = "0x182B27460")]
		private QIRHVUVQSXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2B27230", Offset = "0x2B25830", VA = "0x182B27230")]
		public static QIRHVUVQSXZ New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2B272F0", Offset = "0x2B258F0", VA = "0x182B272F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2B27320", Offset = "0x2B25920", VA = "0x182B27320", Slot = "15")]
		public override string UIVTQJMHANS(IReadOnlyList<WPCWYXTKXZN> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2B272A0", Offset = "0x2B258A0", VA = "0x182B272A0", Slot = "16")]
		public override int RNWUEEZBGEH(IReadOnlyList<WPCWYXTKXZN> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2B27190", Offset = "0x2B25790", VA = "0x182B27190", Slot = "17")]
		public override bool CQJEUKVMTJU(IReadOnlyList<WPCWYXTKXZN> a, IReadOnlyList<WPCWYXTKXZN> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2B27410", Offset = "0x2B25A10", VA = "0x182B27410", Slot = "12")]
		public override bool WYCXDAIGFPQ([In] WPCWYXTKXZN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730")]
		public bool WYCXDAIGFPQ([In] QIRHVUVQSXZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xBC4C40", Offset = "0xBC3240", VA = "0x180BC4C40", Slot = "18")]
		public bool Equals(QIRHVUVQSXZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2B271E0", Offset = "0x2B257E0", VA = "0x182B271E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2B25730", Offset = "0x2B23D30", VA = "0x182B25730", Slot = "19")]
		private bool YYJZUQOJLLS([In] QIRHVUVQSXZ other)
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
			public readonly WPCWYXTKXZN CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
			internal Impl(WPCWYXTKXZN circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x2B23F20", Offset = "0x2B22520", VA = "0x182B23F20")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2B23D90", Offset = "0x2B22390", VA = "0x182B23D90")]
		public static CircuitTypeOrString RLNHVWDCVHF(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2B23D30", Offset = "0x2B22330", VA = "0x182B23D30")]
		public static CircuitTypeOrString RLNHVWDCVHF(WPCWYXTKXZN a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2B23C90", Offset = "0x2B22290", VA = "0x182B23C90")]
		public WPCWYXTKXZN NMEUKDSMODM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2B23E00", Offset = "0x2B22400", VA = "0x182B23E00")]
		public static WPCWYXTKXZN[] VZZCAJYJRWF(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly IYVUAMILGWC _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		private ClassFactoryBaseClasses(IYVUAMILGWC data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x153BCA0", Offset = "0x153A2A0", VA = "0x18153BCA0")]
		public static ClassFactoryBaseClasses New(IYVUAMILGWC data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2B24000", Offset = "0x2B22600", VA = "0x182B24000")]
		public ClassFactoryBaseClasses QOSNQFAZQWA(UPALZYLPQSM a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2B240C0", Offset = "0x2B226C0", VA = "0x182B240C0")]
		public ClassFactoryProps TYKFFXRDXZR()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2B23FA0", Offset = "0x2B225A0", VA = "0x182B23FA0")]
		public ClassFactoryProps HBKJJMHYBJO(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2B23F50", Offset = "0x2B22550", VA = "0x182B23F50")]
		public UPALZYLPQSM BESFLJVUAJT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class IYVUAMILGWC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? SNTOXKRGJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string UDAZODDRFXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<HRBSFXCBXWX> OJVRULHNIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<UPALZYLPQSM> BBDDVUJDZXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> WNAALRPFZAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, CMEPTWOOXZC>> GGNUYUMXOCV;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2B25FD0", Offset = "0x2B245D0", VA = "0x182B25FD0")]
		private IYVUAMILGWC([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2B25E20", Offset = "0x2B24420", VA = "0x182B25E20")]
		public static IYVUAMILGWC New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly IYVUAMILGWC _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		private ClassFactoryFuncs(IYVUAMILGWC data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x153BCA0", Offset = "0x153A2A0", VA = "0x18153BCA0")]
		public static ClassFactoryFuncs New(IYVUAMILGWC data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2B240E0", Offset = "0x2B226E0", VA = "0x182B240E0")]
		public UPALZYLPQSM BESFLJVUAJT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly IYVUAMILGWC _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		public ClassFactoryProps(IYVUAMILGWC data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2B24270", Offset = "0x2B22870", VA = "0x182B24270")]
		public ClassFactoryProps HBKJJMHYBJO(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2B240C0", Offset = "0x2B226C0", VA = "0x182B240C0")]
		public ClassFactoryFuncs DILWYMWDLZY()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B24230", Offset = "0x2B22830", VA = "0x182B24230")]
		public UPALZYLPQSM BESFLJVUAJT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly IYVUAMILGWC _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		private ClassFactoryTypeParams(IYVUAMILGWC data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B24700", Offset = "0x2B22D00", VA = "0x182B24700")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B24460", Offset = "0x2B22A60", VA = "0x182B24460")]
		public ClassFactoryTypeParams CIUDGTMCBMK(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2B240C0", Offset = "0x2B226C0", VA = "0x182B240C0")]
		public ClassFactoryBaseClasses OZFUNIZOKQW()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B248D0", Offset = "0x2B22ED0", VA = "0x182B248D0")]
		public ClassFactoryBaseClasses QOSNQFAZQWA(UPALZYLPQSM a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B24400", Offset = "0x2B22A00", VA = "0x182B24400")]
		public UPALZYLPQSM BESFLJVUAJT()
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
