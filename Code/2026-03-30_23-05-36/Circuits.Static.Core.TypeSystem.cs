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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class BCNDQRECDEP : IEquatable<BCNDQRECDEP>, RRGXPRNQSZZ<BCNDQRECDEP>, LYHQBLZQKRY
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool JNRKVOLITTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool ZGIQACUWGHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int DYHZWEKKLRF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind SSNBWZUXQFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D80", Offset = "0xAD2B80", VA = "0x180AD3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? AYUKIZQTKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x295A080", Offset = "0x2958E80", VA = "0x18295A080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual BCNDQRECDEP CKOTAEXGTTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBD1650", Offset = "0xBD0450", VA = "0x180BD1650", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool MMVEPCFPFFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2959EF0", Offset = "0x2958CF0", VA = "0x182959EF0")]
		public static void NRKVJJKJWDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
		protected BCNDQRECDEP(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2959F80", Offset = "0x2958D80", VA = "0x182959F80")]
		public static BCNDQRECDEP New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBD1650", Offset = "0xBD0450", VA = "0x180BD1650")]
		protected static a THZKLBHKMRN<a>(a a) where a : BCNDQRECDEP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBD1650", Offset = "0xBD0450", VA = "0x180BD1650", Slot = "9")]
		public virtual BCNDQRECDEP URVQWXHMMRO(IReadOnlyDictionary<string, BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2959D40", Offset = "0x2958B40", VA = "0x182959D40", Slot = "11")]
		public virtual void AIZNFXXPBPG(Action<BCNDQRECDEP> a, Action<BCNDQRECDEP> b, Action<BCNDQRECDEP> c, Action<BCNDQRECDEP> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x295A2E0", Offset = "0x29590E0", VA = "0x18295A2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x295A450", Offset = "0x2959250", VA = "0x18295A450", Slot = "12")]
		public virtual bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2959D90", Offset = "0x2958B90", VA = "0x182959D90", Slot = "4")]
		public bool Equals(BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2959DC0", Offset = "0x2958BC0", VA = "0x182959DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x295A0F0", Offset = "0x2958EF0", VA = "0x18295A0F0")]
		public static bool QIDDWXQJPGU(BCNDQRECDEP a, BCNDQRECDEP b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x295A040", Offset = "0x2958E40", VA = "0x18295A040")]
		public static bool OLTCZZLLQGX(BCNDQRECDEP a, BCNDQRECDEP b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2959E10", Offset = "0x2958C10", VA = "0x182959E10", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2959EC0", Offset = "0x2958CC0", VA = "0x182959EC0", Slot = "13")]
		public virtual int IMBWOUISRJB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2959EC0", Offset = "0x2958CC0", VA = "0x182959EC0", Slot = "14")]
		protected virtual int YZHANHMESUL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x34440B0", Offset = "0x3442EB0", VA = "0x1834440B0")]
		public b TAHLQDYVGAX<b>() where b : BCNDQRECDEP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2959D70", Offset = "0x2958B70", VA = "0x182959D70", Slot = "15")]
		public virtual string BPBMUFYGUGA(IReadOnlyList<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2959FF0", Offset = "0x2958DF0", VA = "0x182959FF0", Slot = "16")]
		public virtual int OCUKRFZCICL(IReadOnlyList<BCNDQRECDEP> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x295A130", Offset = "0x2958F30", VA = "0x18295A130", Slot = "17")]
		public virtual bool RPYDZUHCKDE(IReadOnlyList<BCNDQRECDEP> a, IReadOnlyList<BCNDQRECDEP> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x295A180", Offset = "0x2958F80", VA = "0x18295A180")]
		public IJCVYDCEUWW SXQIPFYQBEQ(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x295A2D0", Offset = "0x29590D0", VA = "0x18295A2D0")]
		public IJCVYDCEUWW SXQIPFYQBEQ(params BCNDQRECDEP[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x295A2D0", Offset = "0x29590D0", VA = "0x18295A2D0")]
		public IJCVYDCEUWW SXQIPFYQBEQ(IEnumerable<BCNDQRECDEP> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ZSAXAUTJBCY<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a FYJUQTKOJYS(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b CMMQBKTPISQ([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind LIFTRRMAQXE([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates TWTWQUSDYXX(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LYHQBLZQKRY
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IMBWOUISRJB(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class IMBWOUISRJB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class PFPHQMMHMBL<a> where a : LYHQBLZQKRY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int QCOQRXMUADC;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public PFPHQMMHMBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5C40330", Offset = "0x5C3F130", VA = "0x185C40330")]
			internal int XYSIRTYIJNE(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HLEKWSXSPXF<a, b> where b : LYHQBLZQKRY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int QCOQRXMUADC;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HLEKWSXSPXF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x50060D0", Offset = "0x5004ED0", VA = "0x1850060D0")]
			internal int XYSIRTYIJNE(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class QYFUYFCHFRN<a> where a : LYHQBLZQKRY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int QCOQRXMUADC;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public QYFUYFCHFRN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5D40AE0", Offset = "0x5D3F8E0", VA = "0x185D40AE0")]
			internal int SESGHEMXKWD(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x37DD690", Offset = "0x37DC490", VA = "0x1837DD690")]
		public static int NVHWLUATVNG<a>(this IEnumerable<a> a, int b = 0) where a : LYHQBLZQKRY
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x37DD760", Offset = "0x37DC560", VA = "0x1837DD760")]
		public static int NVHWLUATVNG<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : LYHQBLZQKRY
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37DD690", Offset = "0x37DC490", VA = "0x1837DD690")]
		public static int MNCRVTOVTCX<d>(this IEnumerable<d> a, int b = 0) where d : LYHQBLZQKRY
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : ZSAXAUTJBCY<TDirectedType, BCNDQRECDEP, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4176E70", Offset = "0x4175C70", VA = "0x184176E70")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x635F250", Offset = "0x635E050", VA = "0x18635F250")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class SIGGWUKCENH
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KWRWIOXYHVF<a, b, c> where c : ZSAXAUTJBCY<a, BCNDQRECDEP, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public BCNDQRECDEP XIOGTEPTJTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<BCNDQRECDEP> LBTDCURVEHU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public BCNDQRECDEP JZTLEAWZNTE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<BCNDQRECDEP> MJQFYLCMSSD;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public KWRWIOXYHVF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5394EC0", Offset = "0x5393CC0", VA = "0x185394EC0")]
			internal bool JBZRQRPECAV([In] TypeSys<a, b, c> self_, BCNDQRECDEP a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5394BF0", Offset = "0x53939F0", VA = "0x185394BF0")]
			internal bool JBJWYXHLZSU([In] TypeSys<a, b, c> self_, BCNDQRECDEP a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5394B30", Offset = "0x5393930", VA = "0x185394B30")]
			internal bool JBEQBQNOQHL([In] TypeSys<a, b, c> self_, BCNDQRECDEP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class XAVOZVQTWSU<a, b, c> where c : ZSAXAUTJBCY<a, BCNDQRECDEP, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public BCNDQRECDEP NYQIKMSSDXB;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public XAVOZVQTWSU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3EC9AB0", Offset = "0x3EC88B0", VA = "0x183EC9AB0")]
			internal bool JAZJEJTRGWC([In] TypeSys<a, b, c> self__, BCNDQRECDEP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class RPTDJVVMSGR<a, b, c> where c : ZSAXAUTJBCY<a, BCNDQRECDEP, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b WYBQGJRULHO;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public RPTDJVVMSGR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5DC1C50", Offset = "0x5DC0A50", VA = "0x185DC1C50")]
			internal BCNDQRECDEP GGBGYRHOXUO([In] TypeSys<a, b, c> self_, [In] b root_, BCNDQRECDEP a, BCNDQRECDEP b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BXPQVJDMWCO<a, b, c> where c : ZSAXAUTJBCY<a, BCNDQRECDEP, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public HCGLTFOVHKA KYIBLAQXWZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HCGLTFOVHKA ZGELVGXLFAC;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public BXPQVJDMWCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x714C6E0", Offset = "0x714B4E0", VA = "0x18714C6E0")]
			internal a GFWABKNROJF([In] TypeSys<a, b, c> self_, IOKind a, HCGLTFOVHKA b, HCGLTFOVHKA c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class UGPFRDTGKCT<a, b, c> where c : ZSAXAUTJBCY<a, BCNDQRECDEP, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<HCGLTFOVHKA> URTFSMEDVWM;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public UGPFRDTGKCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6399550", Offset = "0x6398350", VA = "0x186399550")]
			internal bool FRRPZKDQDXJ(bool a, HCGLTFOVHKA b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] KAMONEWAYCS;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE37B0", Offset = "0x3AE25B0", VA = "0x183AE37B0")]
		public static bool ELQYYSYKWZN<a, b, c>([In] this TypeSys<a, b, c> _, BCNDQRECDEP a) where c : ZSAXAUTJBCY<a, BCNDQRECDEP, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB4E0", Offset = "0x3AEA2E0", VA = "0x183AEB4E0")]
		public static bool HIMCFTUZXBC<d, e, f>([In] this TypeSys<d, e, f> _, BCNDQRECDEP a) where f : ZSAXAUTJBCY<d, BCNDQRECDEP, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC6B0", Offset = "0x3AEB4B0", VA = "0x183AEC6B0")]
		public static bool PGISUBWZQCU<g, h, i>([In] this TypeSys<g, h, i> self, BCNDQRECDEP a, BCNDQRECDEP b) where i : ZSAXAUTJBCY<g, BCNDQRECDEP, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB500", Offset = "0x3AEA300", VA = "0x183AEB500")]
		private static bool OEBFFRLFXYN<j, k, l>([In] this TypeSys<j, k, l> self, BCNDQRECDEP a, BCNDQRECDEP b, IReadOnlyList<BCNDQRECDEP> c, IReadOnlyList<BCNDQRECDEP> d) where l : ZSAXAUTJBCY<j, BCNDQRECDEP, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6660", Offset = "0x3AE5460", VA = "0x183AE6660")]
		public static BCNDQRECDEP GIIJDSDUJAL<m, n, o>([In] this TypeSys<m, n, o> self, n a, BCNDQRECDEP b, BCNDQRECDEP c) where o : ZSAXAUTJBCY<m, BCNDQRECDEP, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AE37D0", Offset = "0x3AE25D0", VA = "0x183AE37D0")]
		public static p GIIJDSDUJAL<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : ZSAXAUTJBCY<p, BCNDQRECDEP, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AECD00", Offset = "0x3AEBB00", VA = "0x183AECD00")]
		private static List<w> POKNOSTSFKP<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : ZSAXAUTJBCY<t, BCNDQRECDEP, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3610", Offset = "0x3AE2410", VA = "0x183AE3610")]
		private static ba EBQHYNHAEWN<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class HESZSKPAMUU
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static BCNDQRECDEP UAWFRJHYSDL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2960D40", Offset = "0x295FB40", VA = "0x182960D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static BCNDQRECDEP FXOMPNGEJDX
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2960C50", Offset = "0x295FA50", VA = "0x182960C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static BCNDQRECDEP NJSGSZKXNXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2960CF0", Offset = "0x295FAF0", VA = "0x182960CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static BCNDQRECDEP UQHEDABVLSU
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2960C00", Offset = "0x295FA00", VA = "0x182960C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static BCNDQRECDEP TAIRMRSECKO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2960D90", Offset = "0x295FB90", VA = "0x182960D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static BCNDQRECDEP EMCUZHRGBND
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2960900", Offset = "0x295F700", VA = "0x182960900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static BCNDQRECDEP NSWHAZYURRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2960CA0", Offset = "0x295FAA0", VA = "0x182960CA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static BCNDQRECDEP FIBSGNOSQPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2960950", Offset = "0x295F750", VA = "0x182960950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2960E70", Offset = "0x295FC70", VA = "0x182960E70")]
		public static IJCVYDCEUWW XWDBXDDMRRM([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2960DE0", Offset = "0x295FBE0", VA = "0x182960DE0")]
		public static IJCVYDCEUWW XIVTAPWRLEQ(IEnumerable<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2960870", Offset = "0x295F670", VA = "0x182960870")]
		public static IJCVYDCEUWW ACMQZFHHXSQ(IEnumerable<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x29606C0", Offset = "0x295F4C0", VA = "0x1829606C0")]
		public static IJCVYDCEUWW ACMQZFHHXSQ(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x29609A0", Offset = "0x295F7A0", VA = "0x1829609A0")]
		public static IJCVYDCEUWW JAARKDONWFT(IEnumerable<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2960A30", Offset = "0x295F830", VA = "0x182960A30")]
		public static WUGZPQGCDOP OQMVRNXOWBE(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class IJCVYDCEUWW : BCNDQRECDEP, IEquatable<IJCVYDCEUWW>, RRGXPRNQSZZ<IJCVYDCEUWW>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class XUNCHGEOCXU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, BCNDQRECDEP> SEYPBKNFMBU;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public XUNCHGEOCXU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2965C90", Offset = "0x2964A90", VA = "0x182965C90")]
			internal BCNDQRECDEP KVDSITMSHGO(BCNDQRECDEP a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BCNDQRECDEP BWTIAAXZUBO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override BCNDQRECDEP CKOTAEXGTTF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<BCNDQRECDEP> DZQNQQROPKP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool MMVEPCFPFFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2961A20", Offset = "0x2960820", VA = "0x182961A20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2961C70", Offset = "0x2960A70", VA = "0x182961C70", Slot = "9")]
		public sealed override BCNDQRECDEP URVQWXHMMRO(IReadOnlyDictionary<string, BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x29617C0", Offset = "0x29605C0", VA = "0x1829617C0", Slot = "11")]
		public sealed override void AIZNFXXPBPG(Action<BCNDQRECDEP> a, Action<BCNDQRECDEP> b, Action<BCNDQRECDEP> c, Action<BCNDQRECDEP> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2961F40", Offset = "0x2960D40", VA = "0x182961F40")]
		private IJCVYDCEUWW(BCNDQRECDEP a, IEnumerable<BCNDQRECDEP> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2961BB0", Offset = "0x29609B0", VA = "0x182961BB0")]
		public static IJCVYDCEUWW New(BCNDQRECDEP originalType, IEnumerable<BCNDQRECDEP> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2961C30", Offset = "0x2960A30", VA = "0x182961C30", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2961EE0", Offset = "0x2960CE0", VA = "0x182961EE0", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2961E40", Offset = "0x2960C40", VA = "0x182961E40")]
		public bool ZNVGUJHBSXE([In] IJCVYDCEUWW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2961B90", Offset = "0x2960990", VA = "0x182961B90", Slot = "18")]
		public bool Equals(IJCVYDCEUWW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2961B40", Offset = "0x2960940", VA = "0x182961B40", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2961D90", Offset = "0x2960B90", VA = "0x182961D90", Slot = "14")]
		protected override int YZHANHMESUL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2961F30", Offset = "0x2960D30", VA = "0x182961F30", Slot = "19")]
		private bool ZOLPVPSPJTB([In] IJCVYDCEUWW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class RGITZVSNQXP : BCNDQRECDEP, IEquatable<RGITZVSNQXP>, RRGXPRNQSZZ<RGITZVSNQXP>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x29629F0", Offset = "0x29617F0", VA = "0x1829629F0")]
		private RGITZVSNQXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2962890", Offset = "0x2961690", VA = "0x182962890")]
		public static RGITZVSNQXP New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2962940", Offset = "0x2961740", VA = "0x182962940", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x29627B0", Offset = "0x29615B0", VA = "0x1829627B0", Slot = "15")]
		public sealed override string BPBMUFYGUGA(IReadOnlyList<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2962900", Offset = "0x2961700", VA = "0x182962900")]
		private static string QJXXXDBCSDU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x29629A0", Offset = "0x29617A0", VA = "0x1829629A0", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0")]
		public bool ZNVGUJHBSXE([In] RGITZVSNQXP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD362B0", Offset = "0xD350B0", VA = "0x180D362B0", Slot = "18")]
		public bool Equals(RGITZVSNQXP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2962840", Offset = "0x2961640", VA = "0x182962840", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0", Slot = "19")]
		private bool TJFTUJCTLLI([In] RGITZVSNQXP other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BHBRETCZGTA
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EFLKHXYADXP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public BCNDQRECDEP LCIIXHIDVAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<BCNDQRECDEP, IJCVYDCEUWW> VPFAFVCEXRA;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public EFLKHXYADXP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x295F0C0", Offset = "0x295DEC0", VA = "0x18295F0C0")]
			internal IJCVYDCEUWW QPQNMCOMTKK(BCNDQRECDEP a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class EFGDKRECUMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public BCNDQRECDEP XIZMVKFBMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<BCNDQRECDEP, IJCVYDCEUWW> TMDBJLNWIJQ;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public EFGDKRECUMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x295EF40", Offset = "0x295DD40", VA = "0x18295EF40")]
			internal IJCVYDCEUWW ZFDGVDFJYIO(BCNDQRECDEP a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x295CAC0", Offset = "0x295B8C0", VA = "0x18295CAC0")]
		public static IEnumerable<HCGLTFOVHKA> TYNARNGLCBU(this HCGLTFOVHKA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x295B350", Offset = "0x295A150", VA = "0x18295B350")]
		private static IEnumerable<HCGLTFOVHKA> EEOAYFZLACA(this HCGLTFOVHKA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x295B4A0", Offset = "0x295A2A0", VA = "0x18295B4A0")]
		public static (BCNDQRECDEP, IReadOnlyList<BCNDQRECDEP>, bool) JYHRHDBWCBA(this BCNDQRECDEP a, [Optional] IReadOnlyList<BCNDQRECDEP> b)
		{
			return default((BCNDQRECDEP, IReadOnlyList<BCNDQRECDEP>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x295BBB0", Offset = "0x295A9B0", VA = "0x18295BBB0")]
		public static TypeKind PMDBNPZUQSR(this BCNDQRECDEP a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x295A4F0", Offset = "0x29592F0", VA = "0x18295A4F0")]
		private static BCNDQRECDEP ConvertClassesToIntersections(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x295B020", Offset = "0x2959E20", VA = "0x18295B020")]
		private static BCNDQRECDEP DistributeUnionIntoIntersection(this IJCVYDCEUWW self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x295AB90", Offset = "0x2959990", VA = "0x18295AB90")]
		private static BCNDQRECDEP DistributeIntersectionIntoIntersection(this IJCVYDCEUWW self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x295AEC0", Offset = "0x2959CC0", VA = "0x18295AEC0")]
		private static BCNDQRECDEP DistributeIntoIntersection(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x295B670", Offset = "0x295A470", VA = "0x18295B670")]
		private static bool OtherIsAssignableToOther(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes, BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x295CCE0", Offset = "0x295BAE0", VA = "0x18295CCE0")]
		private static bool UnionIsAssignableToOther(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes, BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x295B800", Offset = "0x295A600", VA = "0x18295B800")]
		private static bool OtherIsAssignableToUnion(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes, BCNDQRECDEP union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x295D010", Offset = "0x295BE10", VA = "0x18295D010")]
		private static bool UnionIsAssignableToUnion(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes, BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x295C8C0", Offset = "0x295B6C0", VA = "0x18295C8C0")]
		public static BCNDQRECDEP RemoveCommonTypesFromIntersectionDistribution(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x295BBE0", Offset = "0x295A9E0", VA = "0x18295BBE0")]
		public static BCNDQRECDEP RemoveCommonTypesFromIntersectionDistributionInternal(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x295C9F0", Offset = "0x295B7F0", VA = "0x18295C9F0")]
		public static BCNDQRECDEP SimplifyIntersectionUnion(this BCNDQRECDEP self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x295AB40", Offset = "0x2959940", VA = "0x18295AB40")]
		public static IEnumerable<BCNDQRECDEP> DZQNQQROPKP(this BCNDQRECDEP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x295B410", Offset = "0x295A210", VA = "0x18295B410")]
		public static IEnumerable<BCNDQRECDEP> HMWHFOHSGDO(this BCNDQRECDEP a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class HCGLTFOVHKA : HRXKPRHCPMR, IEquatable<HCGLTFOVHKA>, RRGXPRNQSZZ<HCGLTFOVHKA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class CWBMKFYGFVN : IEnumerable<HCGLTFOVHKA>, IEnumerable, IEnumerator<HCGLTFOVHKA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private HCGLTFOVHKA LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public HCGLTFOVHKA FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<HCGLTFOVHKA> NUQJCBGEMQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private HCGLTFOVHKA JHUNGKSHZNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<HCGLTFOVHKA> NVAWWOTZFNA;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private HCGLTFOVHKA ECROITWBGPJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public CWBMKFYGFVN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x295DE50", Offset = "0x295CC50", VA = "0x18295DE50", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x295DA90", Offset = "0x295C890", VA = "0x18295DA90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x295D9A0", Offset = "0x295C7A0", VA = "0x18295D9A0")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x295D950", Offset = "0x295C750", VA = "0x18295D950")]
			private void GWCOUVMHXEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x295DFA0", Offset = "0x295CDA0", VA = "0x18295DFA0", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x295D9F0", Offset = "0x295C7F0", VA = "0x18295D9F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HCGLTFOVHKA> SGYBYSGLUWY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x295D9F0", Offset = "0x295C7F0", VA = "0x18295D9F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> GXGSTLRGFNC;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, HCGLTFOVHKA> LUNMUQIXSYB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, HCGLTFOVHKA> FSPQNAFBNXP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x295F9E0", Offset = "0x295E7E0", VA = "0x18295F9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? AYUKIZQTKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid ZVXCDESMJGV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD20AD0", Offset = "0xD1F8D0", VA = "0x180D20AD0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD21730", Offset = "0xD20530", VA = "0x180D21730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xACC890", Offset = "0xACB690", VA = "0x180ACC890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<HCGLTFOVHKA> HWWIWGXLXGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xACC830", Offset = "0xACB630", VA = "0x180ACC830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<HCGLTFOVHKA> NQJSZLVRUAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x295F240", Offset = "0x295E040", VA = "0x18295F240")]
			[IteratorStateMachine(typeof(CWBMKFYGFVN))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> XHULQJFBMWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAC63E0", Offset = "0xAC51E0", VA = "0x180AC63E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC63D0", Offset = "0xAC51D0", VA = "0x180AC63D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, UOKMMQJHIQQ> EWXKZUFOXOR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC6400", Offset = "0xAC5200", VA = "0x180AC6400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC6120", Offset = "0xAC4F20", VA = "0x180AC6120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2960300", Offset = "0x295F100", VA = "0x182960300")]
		public HCGLTFOVHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2960360", Offset = "0x295F160", VA = "0x182960360")]
		public HCGLTFOVHKA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x295F3E0", Offset = "0x295E1E0", VA = "0x18295F3E0")]
		public static HCGLTFOVHKA EQHLDODCMEZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x295F390", Offset = "0x295E190", VA = "0x18295F390")]
		public static HCGLTFOVHKA CPDSHOZZHFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x295F500", Offset = "0x295E300", VA = "0x18295F500")]
		public void Initialize(HCGLTFOVHKA from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2960410", Offset = "0x295F210", VA = "0x182960410")]
		private HCGLTFOVHKA([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<WUGZPQGCDOP> c, [Optional] IEnumerable<HCGLTFOVHKA> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, UOKMMQJHIQQ>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x295FDC0", Offset = "0x295EBC0", VA = "0x18295FDC0")]
		public static HCGLTFOVHKA New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<WUGZPQGCDOP> typeParameters, [Optional] IEnumerable<HCGLTFOVHKA> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, UOKMMQJHIQQ>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x295FEA0", Offset = "0x295ECA0", VA = "0x18295FEA0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x295F4A0", Offset = "0x295E2A0", VA = "0x18295F4A0")]
		private string IYDVBXVTKVN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x295FD00", Offset = "0x295EB00", VA = "0x18295FD00")]
		private static string LGTVRZIPKZG(IEnumerable<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x295F700", Offset = "0x295E500", VA = "0x18295F700")]
		private string JLDTHKTUCSX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x295FA30", Offset = "0x295E830", VA = "0x18295FA30")]
		private string KITHSWBEUKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x295F2C0", Offset = "0x295E0C0", VA = "0x18295F2C0", Slot = "15")]
		public sealed override string BPBMUFYGUGA(IReadOnlyList<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x29600A0", Offset = "0x295EEA0", VA = "0x1829600A0", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x29600F0", Offset = "0x295EEF0", VA = "0x1829600F0")]
		public bool ZNVGUJHBSXE([In] HCGLTFOVHKA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x295F430", Offset = "0x295E230", VA = "0x18295F430", Slot = "18")]
		public bool Equals(HCGLTFOVHKA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x295F450", Offset = "0x295E250", VA = "0x18295F450", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x295FF90", Offset = "0x295ED90", VA = "0x18295FF90", Slot = "14")]
		protected override int YZHANHMESUL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x295FE90", Offset = "0x295EC90", VA = "0x18295FE90", Slot = "19")]
		private bool PTQILCCSTJR([In] HCGLTFOVHKA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class CAENEPTRCCR
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<BCNDQRECDEP> PRSBRKCZNTW;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<HCGLTFOVHKA> AQFOVIQAOWR;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, WUGZPQGCDOP> KEUGTDURRLW;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> WOKLZHEMCJW;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, UOKMMQJHIQQ> VDJGPHGXCEN;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class TMNXSSGDWCQ : IEquatable<TMNXSSGDWCQ>, RRGXPRNQSZZ<TMNXSSGDWCQ>, LYHQBLZQKRY
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BCNDQRECDEP ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		private TMNXSSGDWCQ(BCNDQRECDEP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2962AF0", Offset = "0x29618F0", VA = "0x182962AF0")]
		public static TMNXSSGDWCQ New(BCNDQRECDEP type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x29108C0", Offset = "0x290F6C0", VA = "0x1829108C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x29620B0", Offset = "0x2960EB0", VA = "0x1829620B0")]
		public bool ZNVGUJHBSXE([In] TMNXSSGDWCQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2962060", Offset = "0x2960E60", VA = "0x182962060", Slot = "4")]
		public bool Equals(TMNXSSGDWCQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2962AA0", Offset = "0x29618A0", VA = "0x182962AA0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2932F20", Offset = "0x2931D20", VA = "0x182932F20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2962100", Offset = "0x2960F00", VA = "0x182962100", Slot = "6")]
		public int IMBWOUISRJB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x29620B0", Offset = "0x2960EB0", VA = "0x1829620B0", Slot = "5")]
		private bool QIRSJZIOJCT([In] TMNXSSGDWCQ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class OZMQBKBGZPT : IEquatable<OZMQBKBGZPT>, RRGXPRNQSZZ<OZMQBKBGZPT>, LYHQBLZQKRY
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BCNDQRECDEP ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		private OZMQBKBGZPT(BCNDQRECDEP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2962130", Offset = "0x2960F30", VA = "0x182962130")]
		public static OZMQBKBGZPT New(BCNDQRECDEP type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x29108C0", Offset = "0x290F6C0", VA = "0x1829108C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x29620B0", Offset = "0x2960EB0", VA = "0x1829620B0")]
		public bool ZNVGUJHBSXE([In] OZMQBKBGZPT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2962060", Offset = "0x2960E60", VA = "0x182962060", Slot = "4")]
		public bool Equals(OZMQBKBGZPT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2962010", Offset = "0x2960E10", VA = "0x182962010", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2932F20", Offset = "0x2931D20", VA = "0x182932F20", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2962100", Offset = "0x2960F00", VA = "0x182962100", Slot = "6")]
		public int IMBWOUISRJB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x29620B0", Offset = "0x2960EB0", VA = "0x1829620B0", Slot = "5")]
		private bool FJSEQZWFHAM([In] OZMQBKBGZPT other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class UOKMMQJHIQQ : HRXKPRHCPMR, IEquatable<UOKMMQJHIQQ>, RRGXPRNQSZZ<UOKMMQJHIQQ>, LYHQBLZQKRY
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, TMNXSSGDWCQ>> RZDMILTIJBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, OZMQBKBGZPT>> EFMXSIKGCNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x29653E0", Offset = "0x29641E0", VA = "0x1829653E0")]
		private UOKMMQJHIQQ(IEnumerable<WUGZPQGCDOP> a, IEnumerable<KeyValuePair<string, TMNXSSGDWCQ>> b, IEnumerable<KeyValuePair<string, OZMQBKBGZPT>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2964C00", Offset = "0x2963A00", VA = "0x182964C00")]
		public static UOKMMQJHIQQ New(IEnumerable<WUGZPQGCDOP> typeParameters, IEnumerable<KeyValuePair<string, TMNXSSGDWCQ>> inputs, IEnumerable<KeyValuePair<string, OZMQBKBGZPT>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2964D40", Offset = "0x2963B40", VA = "0x182964D40", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2959D70", Offset = "0x2958B70", VA = "0x182959D70", Slot = "15")]
		public sealed override string BPBMUFYGUGA(IReadOnlyList<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2965050", Offset = "0x2963E50", VA = "0x182965050")]
		private string WTDHRUAFTQZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2964A10", Offset = "0x2963810", VA = "0x182964A10")]
		private string DFHVFOANJAW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2965390", Offset = "0x2964190", VA = "0x182965390", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x29652B0", Offset = "0x29640B0", VA = "0x1829652B0")]
		public bool ZNVGUJHBSXE([In] UOKMMQJHIQQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2964B90", Offset = "0x2963990", VA = "0x182964B90", Slot = "18")]
		public bool Equals(UOKMMQJHIQQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2964BB0", Offset = "0x29639B0", VA = "0x182964BB0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x29651D0", Offset = "0x2963FD0", VA = "0x1829651D0", Slot = "14")]
		protected sealed override int YZHANHMESUL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2964D30", Offset = "0x2963B30", VA = "0x182964D30", Slot = "19")]
		private bool OZNALMPGGFL([In] UOKMMQJHIQQ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class CMIDXIDVCDH : BCNDQRECDEP, IEquatable<CMIDXIDVCDH>, RRGXPRNQSZZ<CMIDXIDVCDH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x295D930", Offset = "0x295C730", VA = "0x18295D930")]
		private CMIDXIDVCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x295D7A0", Offset = "0x295C5A0", VA = "0x18295D7A0")]
		public static CMIDXIDVCDH New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x295D8B0", Offset = "0x295C6B0", VA = "0x18295D8B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x295D660", Offset = "0x295C460", VA = "0x18295D660", Slot = "15")]
		public override string BPBMUFYGUGA(IReadOnlyList<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x295D810", Offset = "0x295C610", VA = "0x18295D810", Slot = "16")]
		public override int OCUKRFZCICL(IReadOnlyList<BCNDQRECDEP> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x295D860", Offset = "0x295C660", VA = "0x18295D860", Slot = "17")]
		public override bool RPYDZUHCKDE(IReadOnlyList<BCNDQRECDEP> a, IReadOnlyList<BCNDQRECDEP> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x295D8E0", Offset = "0x295C6E0", VA = "0x18295D8E0", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0")]
		public bool ZNVGUJHBSXE([In] CMIDXIDVCDH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xD362B0", Offset = "0xD350B0", VA = "0x180D362B0", Slot = "18")]
		public bool Equals(CMIDXIDVCDH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x295D750", Offset = "0x295C550", VA = "0x18295D750", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0", Slot = "19")]
		private bool NSGUHTMQPMM([In] CMIDXIDVCDH other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, RRGXPRNQSZZ<Property>, LYHQBLZQKRY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool ZGIQACUWGHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int DYHZWEKKLRF;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public BCNDQRECDEP ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool MABJNQRLAWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xC70C00", Offset = "0xC6FA00", VA = "0x180C70C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IPTEYWYWCAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x102DDF0", Offset = "0x102CBF0", VA = "0x18102DDF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2962750", Offset = "0x2961550", VA = "0x182962750")]
		private Property(BCNDQRECDEP type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2962430", Offset = "0x2961230", VA = "0x182962430")]
		public static Property New(BCNDQRECDEP type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x29624C0", Offset = "0x29612C0", VA = "0x1829624C0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x29623E0", Offset = "0x29611E0", VA = "0x1829623E0")]
		private string JUXHADMIGII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2962190", Offset = "0x2960F90", VA = "0x182962190")]
		private string DRUMOCOOVDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2962650", Offset = "0x2961450", VA = "0x182962650")]
		public bool ZNVGUJHBSXE([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2962230", Offset = "0x2961030", VA = "0x182962230", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x29621E0", Offset = "0x2960FE0", VA = "0x1829621E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2962260", Offset = "0x2961060", VA = "0x182962260", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x29625A0", Offset = "0x29613A0", VA = "0x1829625A0")]
		private int YZHANHMESUL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2962320", Offset = "0x2961120", VA = "0x182962320", Slot = "6")]
		public int IMBWOUISRJB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2962250", Offset = "0x2961050", VA = "0x182962250", Slot = "5")]
		private bool GNRHMUPRRTS([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class IBYOVPLUYVM : BCNDQRECDEP, IEquatable<IBYOVPLUYVM>, RRGXPRNQSZZ<IBYOVPLUYVM>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x29617A0", Offset = "0x29605A0", VA = "0x1829617A0")]
		private IBYOVPLUYVM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x29616B0", Offset = "0x29604B0", VA = "0x1829616B0")]
		public static IBYOVPLUYVM New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2961720", Offset = "0x2960520", VA = "0x182961720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x29615E0", Offset = "0x29603E0", VA = "0x1829615E0", Slot = "15")]
		public override string BPBMUFYGUGA(IReadOnlyList<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2961750", Offset = "0x2960550", VA = "0x182961750", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0")]
		public bool ZNVGUJHBSXE([In] IBYOVPLUYVM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xD362B0", Offset = "0xD350B0", VA = "0x180D362B0", Slot = "18")]
		public bool Equals(IBYOVPLUYVM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2961660", Offset = "0x2960460", VA = "0x182961660", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0", Slot = "19")]
		private bool TUCTEHOTLXD([In] IBYOVPLUYVM other)
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
	public sealed class AITHUVVKYLW : BCNDQRECDEP, IEquatable<AITHUVVKYLW>, RRGXPRNQSZZ<AITHUVVKYLW>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool MMVEPCFPFFE
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2959BB0", Offset = "0x29589B0", VA = "0x182959BB0", Slot = "9")]
		public sealed override BCNDQRECDEP URVQWXHMMRO(IReadOnlyDictionary<string, BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2959AA0", Offset = "0x29588A0", VA = "0x182959AA0", Slot = "11")]
		public sealed override void AIZNFXXPBPG(Action<BCNDQRECDEP> a, Action<BCNDQRECDEP> b, Action<BCNDQRECDEP> c, Action<BCNDQRECDEP> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2959D00", Offset = "0x2958B00", VA = "0x182959D00")]
		private AITHUVVKYLW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2959B20", Offset = "0x2958920", VA = "0x182959B20")]
		public static AITHUVVKYLW New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2959CB0", Offset = "0x2958AB0", VA = "0x182959CB0", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0")]
		public bool ZNVGUJHBSXE([In] AITHUVVKYLW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xD362B0", Offset = "0xD350B0", VA = "0x180D362B0", Slot = "18")]
		public bool Equals(AITHUVVKYLW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2959AD0", Offset = "0x29588D0", VA = "0x182959AD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2959C90", Offset = "0x2958A90", VA = "0x182959C90", Slot = "14")]
		protected sealed override int YZHANHMESUL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0", Slot = "19")]
		private bool QCPAMJNICSN([In] AITHUVVKYLW other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class HRXKPRHCPMR : BCNDQRECDEP
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<WUGZPQGCDOP> QHSKEYOVJUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x29613E0", Offset = "0x29601E0", VA = "0x1829613E0")]
		public void Initialize(HRXKPRHCPMR from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2961570", Offset = "0x2960370", VA = "0x182961570")]
		protected HRXKPRHCPMR(IEnumerable<WUGZPQGCDOP> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool ZNVGUJHBSXE([In] BCNDQRECDEP other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2961510", Offset = "0x2960310", VA = "0x182961510")]
		protected bool ZNVGUJHBSXE([In] HRXKPRHCPMR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2961490", Offset = "0x2960290", VA = "0x182961490", Slot = "14")]
		protected override int YZHANHMESUL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2961410", Offset = "0x2960210", VA = "0x182961410")]
		protected int TFOFAKPSKPX(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class WUGZPQGCDOP : BCNDQRECDEP, IEquatable<WUGZPQGCDOP>, RRGXPRNQSZZ<WUGZPQGCDOP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public BCNDQRECDEP ITYPOWGXORV
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2965BD0", Offset = "0x29649D0", VA = "0x182965BD0")]
		private WUGZPQGCDOP(string a, [Optional] BCNDQRECDEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2965970", Offset = "0x2964770", VA = "0x182965970")]
		public static WUGZPQGCDOP New(string name, [Optional] BCNDQRECDEP constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2965A70", Offset = "0x2964870", VA = "0x182965A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2965B80", Offset = "0x2964980", VA = "0x182965B80", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x29658B0", Offset = "0x29646B0", VA = "0x1829658B0")]
		public bool ZNVGUJHBSXE([In] WUGZPQGCDOP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2965810", Offset = "0x2964610", VA = "0x182965810", Slot = "18")]
		public bool Equals(WUGZPQGCDOP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2965860", Offset = "0x2964660", VA = "0x182965860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2965B00", Offset = "0x2964900", VA = "0x182965B00", Slot = "14")]
		protected override int YZHANHMESUL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2965900", Offset = "0x2964700", VA = "0x182965900", Slot = "13")]
		public override int IMBWOUISRJB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x29658B0", Offset = "0x29646B0", VA = "0x1829658B0", Slot = "19")]
		private bool HALJCOJNWYU([In] WUGZPQGCDOP other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class EAUANBQMYPB : BCNDQRECDEP, IEquatable<EAUANBQMYPB>, RRGXPRNQSZZ<EAUANBQMYPB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x295EF20", Offset = "0x295DD20", VA = "0x18295EF20")]
		private EAUANBQMYPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x295ED90", Offset = "0x295DB90", VA = "0x18295ED90")]
		public static EAUANBQMYPB New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x295EEA0", Offset = "0x295DCA0", VA = "0x18295EEA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x295EC50", Offset = "0x295DA50", VA = "0x18295EC50", Slot = "15")]
		public override string BPBMUFYGUGA(IReadOnlyList<BCNDQRECDEP> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x295EE00", Offset = "0x295DC00", VA = "0x18295EE00", Slot = "16")]
		public override int OCUKRFZCICL(IReadOnlyList<BCNDQRECDEP> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x295EE50", Offset = "0x295DC50", VA = "0x18295EE50", Slot = "17")]
		public override bool RPYDZUHCKDE(IReadOnlyList<BCNDQRECDEP> a, IReadOnlyList<BCNDQRECDEP> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x295EED0", Offset = "0x295DCD0", VA = "0x18295EED0", Slot = "12")]
		public override bool ZNVGUJHBSXE([In] BCNDQRECDEP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0")]
		public bool ZNVGUJHBSXE([In] EAUANBQMYPB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xD362B0", Offset = "0xD350B0", VA = "0x180D362B0", Slot = "18")]
		public bool Equals(EAUANBQMYPB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x295ED40", Offset = "0x295DB40", VA = "0x18295ED40", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2959BA0", Offset = "0x29589A0", VA = "0x182959BA0", Slot = "19")]
		private bool UBOZIORPRPS([In] EAUANBQMYPB other)
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
			public readonly BCNDQRECDEP CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
			internal Impl(BCNDQRECDEP circuitType, string typeParameterReference)
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
		[Cpp2IlInjected.Address(RVA = "0x295E280", Offset = "0x295D080", VA = "0x18295E280")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x295E170", Offset = "0x295CF70", VA = "0x18295E170")]
		public static CircuitTypeOrString KCCJDSSZLVZ(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x295E110", Offset = "0x295CF10", VA = "0x18295E110")]
		public static CircuitTypeOrString KCCJDSSZLVZ(BCNDQRECDEP a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x295E1E0", Offset = "0x295CFE0", VA = "0x18295E1E0")]
		public BCNDQRECDEP VJRGKGXLLUW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x295DFE0", Offset = "0x295CDE0", VA = "0x18295DFE0")]
		public static BCNDQRECDEP[] HRATRBACHUZ(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly UTCHCBGKDQS _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
		private ClassFactoryBaseClasses(UTCHCBGKDQS data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xE9EE40", Offset = "0xE9DC40", VA = "0x180E9EE40")]
		public static ClassFactoryBaseClasses New(UTCHCBGKDQS data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x295E360", Offset = "0x295D160", VA = "0x18295E360")]
		public ClassFactoryBaseClasses YOVYBGASJWU(HCGLTFOVHKA a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x164ABA0", Offset = "0x16499A0", VA = "0x18164ABA0")]
		public ClassFactoryProps ELCEXKHOWST()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x295E2B0", Offset = "0x295D0B0", VA = "0x18295E2B0")]
		public ClassFactoryProps JEBEGSTSFCE(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x295E310", Offset = "0x295D110", VA = "0x18295E310")]
		public HCGLTFOVHKA LSLJVZFFPFX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class UTCHCBGKDQS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? ZVXCDESMJGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string CANLOGIQDOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<WUGZPQGCDOP> QHSKEYOVJUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<HCGLTFOVHKA> HWWIWGXLXGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> XHULQJFBMWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, UOKMMQJHIQQ>> EWXKZUFOXOR;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2965680", Offset = "0x2964480", VA = "0x182965680")]
		private UTCHCBGKDQS([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x29654D0", Offset = "0x29642D0", VA = "0x1829654D0")]
		public static UTCHCBGKDQS New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly UTCHCBGKDQS _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
		private ClassFactoryFuncs(UTCHCBGKDQS data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xE9EE40", Offset = "0xE9DC40", VA = "0x180E9EE40")]
		public static ClassFactoryFuncs New(UTCHCBGKDQS data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x295E420", Offset = "0x295D220", VA = "0x18295E420")]
		public HCGLTFOVHKA LSLJVZFFPFX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly UTCHCBGKDQS _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
		public ClassFactoryProps(UTCHCBGKDQS data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x295E570", Offset = "0x295D370", VA = "0x18295E570")]
		public ClassFactoryProps JEBEGSTSFCE(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x164ABA0", Offset = "0x16499A0", VA = "0x18164ABA0")]
		public ClassFactoryFuncs WQJRTUOZKVU()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x295E700", Offset = "0x295D500", VA = "0x18295E700")]
		public HCGLTFOVHKA LSLJVZFFPFX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly UTCHCBGKDQS _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
		private ClassFactoryTypeParams(UTCHCBGKDQS data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x295E7A0", Offset = "0x295D5A0", VA = "0x18295E7A0")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x295E970", Offset = "0x295D770", VA = "0x18295E970")]
		public ClassFactoryTypeParams OQMVRNXOWBE(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x164ABA0", Offset = "0x16499A0", VA = "0x18164ABA0")]
		public ClassFactoryBaseClasses NDPUAAMZBLU()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x295EC10", Offset = "0x295DA10", VA = "0x18295EC10")]
		public ClassFactoryBaseClasses YOVYBGASJWU(HCGLTFOVHKA a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x295E740", Offset = "0x295D540", VA = "0x18295E740")]
		public HCGLTFOVHKA LSLJVZFFPFX()
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
