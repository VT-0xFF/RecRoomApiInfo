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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class IDLCASSILBG : IEquatable<IDLCASSILBG>, MNLRIGBOINM<IDLCASSILBG>, WRVOCMDCMLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool IIISBEHRDYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool EZVSORALWKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int OWOPEWNBEPM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind IXVPXZPOTQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? BTWCMPRAQUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2DF9940", Offset = "0x2DF8540", VA = "0x182DF9940", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual IDLCASSILBG MDKEZLLLRBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool QHXOYOPWBQX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9860", Offset = "0x2DF8460", VA = "0x182DF9860")]
		public static void HRTIXRMSTIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
		protected IDLCASSILBG(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF99B0", Offset = "0x2DF85B0", VA = "0x182DF99B0")]
		public static IDLCASSILBG New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390")]
		protected static a MZMEOVASGEI<a>(a a) where a : IDLCASSILBG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390", Slot = "9")]
		public virtual IDLCASSILBG WTMHKFXROUT(IReadOnlyDictionary<string, IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9DD0", Offset = "0x2DF89D0", VA = "0x182DF9DD0", Slot = "11")]
		public virtual void YRPNBRSEJXX(Action<IDLCASSILBG> a, Action<IDLCASSILBG> b, Action<IDLCASSILBG> c, Action<IDLCASSILBG> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9A60", Offset = "0x2DF8660", VA = "0x182DF9A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9D30", Offset = "0x2DF8930", VA = "0x182DF9D30", Slot = "12")]
		public virtual bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9730", Offset = "0x2DF8330", VA = "0x182DF9730", Slot = "4")]
		public bool Equals(IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DF96E0", Offset = "0x2DF82E0", VA = "0x182DF96E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2DF96A0", Offset = "0x2DF82A0", VA = "0x182DF96A0")]
		public static bool EOXNKNKFOQL(IDLCASSILBG a, IDLCASSILBG b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9A20", Offset = "0x2DF8620", VA = "0x182DF9A20")]
		public static bool SZMIMWEVICM(IDLCASSILBG a, IDLCASSILBG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9760", Offset = "0x2DF8360", VA = "0x182DF9760", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9670", Offset = "0x2DF8270", VA = "0x182DF9670", Slot = "13")]
		public virtual int KTCGSTQKGNK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9670", Offset = "0x2DF8270", VA = "0x182DF9670", Slot = "14")]
		protected virtual int CSLMZOJILYM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3910", Offset = "0x3BF2510", VA = "0x183BF3910")]
		public b HBKWCAIDTVY<b>() where b : IDLCASSILBG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9650", Offset = "0x2DF8250", VA = "0x182DF9650", Slot = "15")]
		public virtual string CCEXGIURFJP(IReadOnlyList<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF98F0", Offset = "0x2DF84F0", VA = "0x182DF98F0", Slot = "16")]
		public virtual int KYJUZDBAWSW(IReadOnlyList<IDLCASSILBG> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9810", Offset = "0x2DF8410", VA = "0x182DF9810", Slot = "17")]
		public virtual bool HEZUPCSXBOT(IReadOnlyList<IDLCASSILBG> a, IReadOnlyList<IDLCASSILBG> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9BE0", Offset = "0x2DF87E0", VA = "0x182DF9BE0")]
		public VYGAXGQUGRJ VWVBBFIMGYB(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9BD0", Offset = "0x2DF87D0", VA = "0x182DF9BD0")]
		public VYGAXGQUGRJ VWVBBFIMGYB(params IDLCASSILBG[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9BD0", Offset = "0x2DF87D0", VA = "0x182DF9BD0")]
		public VYGAXGQUGRJ VWVBBFIMGYB(IEnumerable<IDLCASSILBG> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface MQBQDZFUSGT<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a QCHVCQIGXCB(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b RHQMJZLGJIL([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind DUGBKFOVSFD([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates LVOSKEQMYKA(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface WRVOCMDCMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KTCGSTQKGNK(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class KTCGSTQKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class EMFFBINPTWU<a> where a : WRVOCMDCMLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int MIAWUVGELCR;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public EMFFBINPTWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4CD46E0", Offset = "0x4CD32E0", VA = "0x184CD46E0")]
			internal int ZMXSFOUFFKR(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LKGVCQQJQVQ<a, b> where b : WRVOCMDCMLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int MIAWUVGELCR;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LKGVCQQJQVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x59871A0", Offset = "0x5985DA0", VA = "0x1859871A0")]
			internal int ZMXSFOUFFKR(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class WTFRSPBGSXA<a> where a : WRVOCMDCMLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int MIAWUVGELCR;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public WTFRSPBGSXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6D79470", Offset = "0x6D78070", VA = "0x186D79470")]
			internal int UBOTOTWFHSK(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E410", Offset = "0x3C8D010", VA = "0x183C8E410")]
		public static int RGONEPTQZXF<a>(this IEnumerable<a> a, int b = 0) where a : WRVOCMDCMLN
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E4E0", Offset = "0x3C8D0E0", VA = "0x183C8E4E0")]
		public static int RGONEPTQZXF<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : WRVOCMDCMLN
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E410", Offset = "0x3C8D010", VA = "0x183C8E410")]
		public static int OQDRPPEDEMK<d>(this IEnumerable<d> a, int b = 0) where d : WRVOCMDCMLN
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : MQBQDZFUSGT<TDirectedType, IDLCASSILBG, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4643290", Offset = "0x4641E90", VA = "0x184643290")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67A8130", Offset = "0x67A6D30", VA = "0x1867A8130")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class OESTPVSRNJI
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QOSTFVFIDQC<a, b, c> where c : MQBQDZFUSGT<a, IDLCASSILBG, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public IDLCASSILBG XSSZIWBSQIS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<IDLCASSILBG> HHENSAWXUDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IDLCASSILBG GEYJHWTRRFZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<IDLCASSILBG> HYIFGXSKURM;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOSTFVFIDQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6225020", Offset = "0x6223C20", VA = "0x186225020")]
			internal bool VYJSWIOABXC([In] TypeSys<a, b, c> self_, IDLCASSILBG a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x62250B0", Offset = "0x6223CB0", VA = "0x1862250B0")]
			internal bool VYZNOCVSEFD([In] TypeSys<a, b, c> self_, IDLCASSILBG a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6224EC0", Offset = "0x6223AC0", VA = "0x186224EC0")]
			internal bool VXORHHMKQDS([In] TypeSys<a, b, c> self_, IDLCASSILBG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class GGWFUHXHZUF<a, b, c> where c : MQBQDZFUSGT<a, IDLCASSILBG, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public IDLCASSILBG ICNMYOLGFQA;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GGWFUHXHZUF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x540B180", Offset = "0x5409D80", VA = "0x18540B180")]
			internal bool VXTYEOGHZPB([In] TypeSys<a, b, c> self__, IDLCASSILBG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CVMVEYQRJOU<a, b, c> where c : MQBQDZFUSGT<a, IDLCASSILBG, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b PPGZRRIGXVH;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CVMVEYQRJOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x43AE830", Offset = "0x43AD430", VA = "0x1843AE830")]
			internal IDLCASSILBG ARFJRNZBOZJ([In] TypeSys<a, b, c> self_, [In] b root_, IDLCASSILBG a, IDLCASSILBG b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OXEIUEVEWMH<a, b, c> where c : MQBQDZFUSGT<a, IDLCASSILBG, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public ZTFFPMGVSBN FIIGQIUAEEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public ZTFFPMGVSBN VONYFRNFPIL;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OXEIUEVEWMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x60C1B60", Offset = "0x60C0760", VA = "0x1860C1B60")]
			internal a ARKQOUSYYKS([In] TypeSys<a, b, c> self_, IOKind a, ZTFFPMGVSBN b, ZTFFPMGVSBN c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class FQBDFFDOUYC<a, b, c> where c : MQBQDZFUSGT<a, IDLCASSILBG, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<ZTFFPMGVSBN> FIBXYEGDKET;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public FQBDFFDOUYC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x530DC10", Offset = "0x530C810", VA = "0x18530DC10")]
			internal bool VHLYEEMQVRG(bool a, ZTFFPMGVSBN b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] QMBLEEYSHTF;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E03820", Offset = "0x3E02420", VA = "0x183E03820")]
		public static bool UCGCQNMFQSO<a, b, c>([In] this TypeSys<a, b, c> _, IDLCASSILBG a) where c : MQBQDZFUSGT<a, IDLCASSILBG, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3E03960", Offset = "0x3E02560", VA = "0x183E03960")]
		public static bool WKVSKGDPJEP<d, e, f>([In] this TypeSys<d, e, f> _, IDLCASSILBG a) where f : MQBQDZFUSGT<d, IDLCASSILBG, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB9C0", Offset = "0x3DFA5C0", VA = "0x183DFB9C0")]
		public static bool LKKGYZCISKR<g, h, i>([In] this TypeSys<g, h, i> self, IDLCASSILBG a, IDLCASSILBG b) where i : MQBQDZFUSGT<g, IDLCASSILBG, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9F70", Offset = "0x3DF8B70", VA = "0x183DF9F70")]
		private static bool HNQJHXXUAEA<j, k, l>([In] this TypeSys<j, k, l> self, IDLCASSILBG a, IDLCASSILBG b, IReadOnlyList<IDLCASSILBG> c, IReadOnlyList<IDLCASSILBG> d) where l : MQBQDZFUSGT<j, IDLCASSILBG, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE990", Offset = "0x3DFD590", VA = "0x183DFE990")]
		public static IDLCASSILBG OWUNKARMGYS<m, n, o>([In] this TypeSys<m, n, o> self, n a, IDLCASSILBG b, IDLCASSILBG c) where o : MQBQDZFUSGT<m, IDLCASSILBG, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBB60", Offset = "0x3DFA760", VA = "0x183DFBB60")]
		public static p OWUNKARMGYS<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : MQBQDZFUSGT<p, IDLCASSILBG, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB5E0", Offset = "0x3DFA1E0", VA = "0x183DFB5E0")]
		private static List<w> LHEQLILLHJW<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : MQBQDZFUSGT<t, IDLCASSILBG, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3E041C0", Offset = "0x3E02DC0", VA = "0x183E041C0")]
		private static ba ZKKFUSHINTY<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3E03840", Offset = "0x3E02440", VA = "0x183E03840")]
		public static IDLCASSILBG UTITDXZLKVK<bb, bc, bd>([In] this TypeSys<bb, bc, bd> _) where bd : MQBQDZFUSGT<bb, IDLCASSILBG, bc>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class KWNNKRKAVJD
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IDLCASSILBG FLCBRYZKXYC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2DF9F80", Offset = "0x2DF8B80", VA = "0x182DF9F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static IDLCASSILBG XFEJNGICUGE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA5B0", Offset = "0x2DF91B0", VA = "0x182DFA5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static IDLCASSILBG JDXKMOZMQBR
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA2F0", Offset = "0x2DF8EF0", VA = "0x182DFA2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IDLCASSILBG BSOXHEJHFGD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA340", Offset = "0x2DF8F40", VA = "0x182DFA340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IDLCASSILBG QGCOCLRDIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA390", Offset = "0x2DF8F90", VA = "0x182DFA390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static IDLCASSILBG GQVRPZLOOAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA600", Offset = "0x2DF9200", VA = "0x182DFA600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IDLCASSILBG KEGULKMVQDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA2A0", Offset = "0x2DF8EA0", VA = "0x182DFA2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IDLCASSILBG RUOUQPKQQWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA810", Offset = "0x2DF9410", VA = "0x182DFA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA650", Offset = "0x2DF9250", VA = "0x182DFA650")]
		public static VYGAXGQUGRJ RUEGSOZJBFF([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA780", Offset = "0x2DF9380", VA = "0x182DFA780")]
		public static VYGAXGQUGRJ SKSFVPEWFFJ(IEnumerable<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9FD0", Offset = "0x2DF8BD0", VA = "0x182DF9FD0")]
		public static VYGAXGQUGRJ EFROISZXRKR(IEnumerable<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA060", Offset = "0x2DF8C60", VA = "0x182DFA060")]
		public static VYGAXGQUGRJ EFROISZXRKR(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA210", Offset = "0x2DF8E10", VA = "0x182DFA210")]
		public static VYGAXGQUGRJ EHRJLEHQFZW(IEnumerable<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA3E0", Offset = "0x2DF8FE0", VA = "0x182DFA3E0")]
		public static SFIRYYSAQXK OBEXELJBKOX(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class VYGAXGQUGRJ : IDLCASSILBG, IEquatable<VYGAXGQUGRJ>, MNLRIGBOINM<VYGAXGQUGRJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, IDLCASSILBG> MYTYOQWJYQZ;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2DFC450", Offset = "0x2DFB050", VA = "0x182DFC450")]
			internal IDLCASSILBG GGVEBJONVQN(IDLCASSILBG a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IDLCASSILBG ORNFLEQEJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override IDLCASSILBG MDKEZLLLRBM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<IDLCASSILBG> TCFKYYZNAYO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool QHXOYOPWBQX
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2DFE770", Offset = "0x2DFD370", VA = "0x182DFE770", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE9D0", Offset = "0x2DFD5D0", VA = "0x182DFE9D0", Slot = "9")]
		public sealed override IDLCASSILBG WTMHKFXROUT(IReadOnlyDictionary<string, IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEBE0", Offset = "0x2DFD7E0", VA = "0x182DFEBE0", Slot = "11")]
		public sealed override void YRPNBRSEJXX(Action<IDLCASSILBG> a, Action<IDLCASSILBG> b, Action<IDLCASSILBG> c, Action<IDLCASSILBG> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEE40", Offset = "0x2DFDA40", VA = "0x182DFEE40")]
		private VYGAXGQUGRJ(IDLCASSILBG a, IEnumerable<IDLCASSILBG> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE900", Offset = "0x2DFD500", VA = "0x182DFE900")]
		public static VYGAXGQUGRJ New(IDLCASSILBG originalType, IEnumerable<IDLCASSILBG> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE990", Offset = "0x2DFD590", VA = "0x182DFE990", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEAF0", Offset = "0x2DFD6F0", VA = "0x182DFEAF0", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEB40", Offset = "0x2DFD740", VA = "0x182DFEB40")]
		public bool XGBYPYNVUZB([In] VYGAXGQUGRJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE890", Offset = "0x2DFD490", VA = "0x182DFE890", Slot = "18")]
		public bool Equals(VYGAXGQUGRJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE8B0", Offset = "0x2DFD4B0", VA = "0x182DFE8B0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE6C0", Offset = "0x2DFD2C0", VA = "0x182DFE6C0", Slot = "14")]
		protected override int CSLMZOJILYM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE980", Offset = "0x2DFD580", VA = "0x182DFE980", Slot = "19")]
		private bool SPUOVPCUCFE([In] VYGAXGQUGRJ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class GRQLEKPTKSC : IDLCASSILBG, IEquatable<GRQLEKPTKSC>, MNLRIGBOINM<GRQLEKPTKSC>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9630", Offset = "0x2DF8230", VA = "0x182DF9630")]
		private GRQLEKPTKSC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2DF94D0", Offset = "0x2DF80D0", VA = "0x182DF94D0")]
		public static GRQLEKPTKSC New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9540", Offset = "0x2DF8140", VA = "0x182DF9540", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2DF93F0", Offset = "0x2DF7FF0", VA = "0x182DF93F0", Slot = "15")]
		public sealed override string CCEXGIURFJP(IReadOnlyList<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2DF95F0", Offset = "0x2DF81F0", VA = "0x182DF95F0")]
		private static string YIBTTPLJTJZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2DF95A0", Offset = "0x2DF81A0", VA = "0x182DF95A0", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280")]
		public bool XGBYPYNVUZB([In] GRQLEKPTKSC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xBD2CF0", Offset = "0xBD18F0", VA = "0x180BD2CF0", Slot = "18")]
		public bool Equals(GRQLEKPTKSC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9480", Offset = "0x2DF8080", VA = "0x182DF9480", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280", Slot = "19")]
		private bool GITILMYPYHX([In] GRQLEKPTKSC other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class DVOTUUIRDOH
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IDLCASSILBG YSRAJVGZOQB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<IDLCASSILBG, VYGAXGQUGRJ> VMERMAPSWRR;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2DFAD30", Offset = "0x2DF9930", VA = "0x182DFAD30")]
			internal VYGAXGQUGRJ DMCMNFBSIWZ(IDLCASSILBG a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PYNDJKDWNOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public IDLCASSILBG CQSHCJIZFWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<IDLCASSILBG, VYGAXGQUGRJ> BUNEJPNTJYV;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYNDJKDWNOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2DFAEB0", Offset = "0x2DF9AB0", VA = "0x182DFAEB0")]
			internal VYGAXGQUGRJ HWDRZEKIFUL(IDLCASSILBG a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7100", Offset = "0x2DF5D00", VA = "0x182DF7100")]
		public static IEnumerable<ZTFFPMGVSBN> ESVHENJMXVN(this ZTFFPMGVSBN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7A40", Offset = "0x2DF6640", VA = "0x182DF7A40")]
		private static IEnumerable<ZTFFPMGVSBN> RVMCZSODZLD(this ZTFFPMGVSBN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7330", Offset = "0x2DF5F30", VA = "0x182DF7330")]
		public static (IDLCASSILBG, IReadOnlyList<IDLCASSILBG>, bool) JMXSCTSAXZJ(this IDLCASSILBG a, [Optional] IReadOnlyList<IDLCASSILBG> b)
		{
			return default((IDLCASSILBG, IReadOnlyList<IDLCASSILBG>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8910", Offset = "0x2DF7510", VA = "0x182DF8910")]
		public static TypeKind SKLMKFPPKWY(this IDLCASSILBG a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF62F0", Offset = "0x2DF4EF0", VA = "0x182DF62F0")]
		private static IDLCASSILBG ConvertClassesToIntersections(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6DD0", Offset = "0x2DF59D0", VA = "0x182DF6DD0")]
		private static IDLCASSILBG DistributeUnionIntoIntersection(this VYGAXGQUGRJ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6940", Offset = "0x2DF5540", VA = "0x182DF6940")]
		private static IDLCASSILBG DistributeIntersectionIntoIntersection(this VYGAXGQUGRJ self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6C70", Offset = "0x2DF5870", VA = "0x182DF6C70")]
		private static IDLCASSILBG DistributeIntoIntersection(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7500", Offset = "0x2DF6100", VA = "0x182DF7500")]
		private static bool OtherIsAssignableToOther(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes, IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8A60", Offset = "0x2DF7660", VA = "0x182DF8A60")]
		private static bool UnionIsAssignableToOther(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes, IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7690", Offset = "0x2DF6290", VA = "0x182DF7690")]
		private static bool OtherIsAssignableToUnion(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes, IDLCASSILBG union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8D90", Offset = "0x2DF7990", VA = "0x182DF8D90")]
		private static bool UnionIsAssignableToUnion(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes, IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2DF87E0", Offset = "0x2DF73E0", VA = "0x182DF87E0")]
		public static IDLCASSILBG RemoveCommonTypesFromIntersectionDistribution(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7B00", Offset = "0x2DF6700", VA = "0x182DF7B00")]
		public static IDLCASSILBG RemoveCommonTypesFromIntersectionDistributionInternal(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8940", Offset = "0x2DF7540", VA = "0x182DF8940")]
		public static IDLCASSILBG SimplifyIntersectionUnion(this IDLCASSILBG self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8A10", Offset = "0x2DF7610", VA = "0x182DF8A10")]
		public static IEnumerable<IDLCASSILBG> TCFKYYZNAYO(this IDLCASSILBG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6260", Offset = "0x2DF4E60", VA = "0x182DF6260")]
		public static IEnumerable<IDLCASSILBG> CZRCZECAUAR(this IDLCASSILBG a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class ZTFFPMGVSBN : YEQKIMUQGGQ, IEquatable<ZTFFPMGVSBN>, MNLRIGBOINM<ZTFFPMGVSBN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class RBRLCEPCOMO : IEnumerable<ZTFFPMGVSBN>, IEnumerable, IEnumerator<ZTFFPMGVSBN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private ZTFFPMGVSBN DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public ZTFFPMGVSBN VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<ZTFFPMGVSBN> OKMXNYRHUZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private ZTFFPMGVSBN JCGHXSJCBKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<ZTFFPMGVSBN> OKCJTLDNCCX;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private ZTFFPMGVSBN APHCWJEWYLQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public RBRLCEPCOMO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2DFBB90", Offset = "0x2DFA790", VA = "0x182DFBB90", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB6F0", Offset = "0x2DFA2F0", VA = "0x182DFB6F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2DFBB00", Offset = "0x2DFA700", VA = "0x182DFBB00")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x2DFBAB0", Offset = "0x2DFA6B0", VA = "0x182DFBAB0")]
			private void QCRABUYCHCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2DFBB50", Offset = "0x2DFA750", VA = "0x182DFBB50", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB650", Offset = "0x2DFA250", VA = "0x182DFB650", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ZTFFPMGVSBN> AWLOALGKEGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB650", Offset = "0x2DFA250", VA = "0x182DFB650", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> ABLIOSXCLOH;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, ZTFFPMGVSBN> GZABEYLQKCE;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, ZTFFPMGVSBN> OQISBMCWMOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2E00280", Offset = "0x2DFEE80", VA = "0x182E00280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? BTWCMPRAQUG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid AXUVQJAOTPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xFE1360", Offset = "0xFDFF60", VA = "0x180FE1360")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xFE07E0", Offset = "0xFDF3E0", VA = "0x180FE07E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<ZTFFPMGVSBN> FGLMKKFNQOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<ZTFFPMGVSBN> GJNWSQGQIHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x2E00A00", Offset = "0x2DFF600", VA = "0x182E00A00")]
			[IteratorStateMachine(typeof(RBRLCEPCOMO))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> WSHXAECEFSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, XZSBJYBHFND> EBTBYMYTOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xB131B0", Offset = "0xB11DB0", VA = "0x180B131B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2E01160", Offset = "0x2DFFD60", VA = "0x182E01160")]
		public ZTFFPMGVSBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2E011C0", Offset = "0x2DFFDC0", VA = "0x182E011C0")]
		public ZTFFPMGVSBN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2E01020", Offset = "0x2DFFC20", VA = "0x182E01020")]
		public static ZTFFPMGVSBN ZCDOYOAMCGU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2E00B70", Offset = "0x2DFF770", VA = "0x182E00B70")]
		public static ZTFFPMGVSBN UDKTJDNWFIW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E00460", Offset = "0x2DFF060", VA = "0x182E00460")]
		public void Initialize(ZTFFPMGVSBN from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2E01270", Offset = "0x2DFFE70", VA = "0x182E01270")]
		private ZTFFPMGVSBN([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<SFIRYYSAQXK> c, [Optional] IEnumerable<ZTFFPMGVSBN> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, XZSBJYBHFND>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2E00930", Offset = "0x2DFF530", VA = "0x182E00930")]
		public static ZTFFPMGVSBN New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<SFIRYYSAQXK> typeParameters, [Optional] IEnumerable<ZTFFPMGVSBN> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, XZSBJYBHFND>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2E00A80", Offset = "0x2DFF680", VA = "0x182E00A80", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E00340", Offset = "0x2DFEF40", VA = "0x182E00340")]
		private string GLAEUKQMLPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2E003A0", Offset = "0x2DFEFA0", VA = "0x182E003A0")]
		private static string IHKUDKOVEOF(IEnumerable<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2E00BC0", Offset = "0x2DFF7C0", VA = "0x182E00BC0")]
		private string VHLPLOPHJTG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2E00660", Offset = "0x2DFF260", VA = "0x182E00660")]
		private string MHDPMNBBEOV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E000A0", Offset = "0x2DFECA0", VA = "0x182E000A0", Slot = "15")]
		public sealed override string CCEXGIURFJP(IReadOnlyList<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E00EB0", Offset = "0x2DFFAB0", VA = "0x182E00EB0", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2E00F00", Offset = "0x2DFFB00", VA = "0x182E00F00")]
		public bool XGBYPYNVUZB([In] ZTFFPMGVSBN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2E002D0", Offset = "0x2DFEED0", VA = "0x182E002D0", Slot = "18")]
		public bool Equals(ZTFFPMGVSBN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2E002F0", Offset = "0x2DFEEF0", VA = "0x182E002F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2E00170", Offset = "0x2DFED70", VA = "0x182E00170", Slot = "14")]
		protected override int CSLMZOJILYM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2E00EA0", Offset = "0x2DFFAA0", VA = "0x182E00EA0", Slot = "19")]
		private bool XARYHYUZVJO([In] ZTFFPMGVSBN other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class YNYPZSTBVXE
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<IDLCASSILBG> RIRAZRNETXT;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<ZTFFPMGVSBN> BLLXCJPRPKE;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, SFIRYYSAQXK> SXFKZIOPWWF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> CCDSZKOFSLV;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, XZSBJYBHFND> DMWCHPKNGOK;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class INFJJZWZQAX : IEquatable<INFJJZWZQAX>, MNLRIGBOINM<INFJJZWZQAX>, WRVOCMDCMLN
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IDLCASSILBG JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		private INFJJZWZQAX(IDLCASSILBG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9F20", Offset = "0x2DF8B20", VA = "0x182DF9F20")]
		public static INFJJZWZQAX New(IDLCASSILBG type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2DABA80", Offset = "0x2DAA680", VA = "0x182DABA80", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9EA0", Offset = "0x2DF8AA0", VA = "0x182DF9EA0")]
		public bool XGBYPYNVUZB([In] INFJJZWZQAX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9E50", Offset = "0x2DF8A50", VA = "0x182DF9E50", Slot = "4")]
		public bool Equals(INFJJZWZQAX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9E00", Offset = "0x2DF8A00", VA = "0x182DF9E00", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2DCFCA0", Offset = "0x2DCE8A0", VA = "0x182DCFCA0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9EF0", Offset = "0x2DF8AF0", VA = "0x182DF9EF0", Slot = "6")]
		public int KTCGSTQKGNK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9EA0", Offset = "0x2DF8AA0", VA = "0x182DF9EA0", Slot = "5")]
		private bool KSGQPFELSTO([In] INFJJZWZQAX other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class VVLVUUUBQFG : IEquatable<VVLVUUUBQFG>, MNLRIGBOINM<VVLVUUUBQFG>, WRVOCMDCMLN
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public IDLCASSILBG JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		private VVLVUUUBQFG(IDLCASSILBG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE660", Offset = "0x2DFD260", VA = "0x182DFE660")]
		public static VVLVUUUBQFG New(IDLCASSILBG type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2DABA80", Offset = "0x2DAA680", VA = "0x182DABA80", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9EA0", Offset = "0x2DF8AA0", VA = "0x182DF9EA0")]
		public bool XGBYPYNVUZB([In] VVLVUUUBQFG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9E50", Offset = "0x2DF8A50", VA = "0x182DF9E50", Slot = "4")]
		public bool Equals(VVLVUUUBQFG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE610", Offset = "0x2DFD210", VA = "0x182DFE610", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2DCFCA0", Offset = "0x2DCE8A0", VA = "0x182DCFCA0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9EF0", Offset = "0x2DF8AF0", VA = "0x182DF9EF0", Slot = "6")]
		public int KTCGSTQKGNK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9EA0", Offset = "0x2DF8AA0", VA = "0x182DF9EA0", Slot = "5")]
		private bool FYZETFRELWB([In] VVLVUUUBQFG other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class XZSBJYBHFND : YEQKIMUQGGQ, IEquatable<XZSBJYBHFND>, MNLRIGBOINM<XZSBJYBHFND>, WRVOCMDCMLN
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, INFJJZWZQAX>> NFEHNMKPGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, VVLVUUUBQFG>> RATUKFOUOMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFBD0", Offset = "0x2DFE7D0", VA = "0x182DFFBD0")]
		private XZSBJYBHFND(IEnumerable<SFIRYYSAQXK> a, IEnumerable<KeyValuePair<string, INFJJZWZQAX>> b, IEnumerable<KeyValuePair<string, VVLVUUUBQFG>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF650", Offset = "0x2DFE250", VA = "0x182DFF650")]
		public static XZSBJYBHFND New(IEnumerable<SFIRYYSAQXK> typeParameters, IEnumerable<KeyValuePair<string, INFJJZWZQAX>> inputs, IEnumerable<KeyValuePair<string, VVLVUUUBQFG>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF780", Offset = "0x2DFE380", VA = "0x182DFF780", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9650", Offset = "0x2DF8250", VA = "0x182DF9650", Slot = "15")]
		public sealed override string CCEXGIURFJP(IReadOnlyList<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF4D0", Offset = "0x2DFE0D0", VA = "0x182DFF4D0")]
		private string KVTDVAHXUHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF350", Offset = "0x2DFDF50", VA = "0x182DFF350")]
		private string JPGDRFQWCHX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFB70", Offset = "0x2DFE770", VA = "0x182DFFB70", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFA90", Offset = "0x2DFE690", VA = "0x182DFFA90")]
		public bool XGBYPYNVUZB([In] XZSBJYBHFND other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF330", Offset = "0x2DFDF30", VA = "0x182DFF330", Slot = "18")]
		public bool Equals(XZSBJYBHFND other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF2E0", Offset = "0x2DFDEE0", VA = "0x182DFF2E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF200", Offset = "0x2DFDE00", VA = "0x182DFF200", Slot = "14")]
		protected sealed override int CSLMZOJILYM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFBC0", Offset = "0x2DFE7C0", VA = "0x182DFFBC0", Slot = "19")]
		private bool ZIQXVQSGEQY([In] XZSBJYBHFND other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class RGVPNJSFHFK : IDLCASSILBG, IEquatable<RGVPNJSFHFK>, MNLRIGBOINM<RGVPNJSFHFK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBFB0", Offset = "0x2DFABB0", VA = "0x182DFBFB0")]
		private RGVPNJSFHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBEC0", Offset = "0x2DFAAC0", VA = "0x182DFBEC0")]
		public static RGVPNJSFHFK New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBF30", Offset = "0x2DFAB30", VA = "0x182DFBF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBCE0", Offset = "0x2DFA8E0", VA = "0x182DFBCE0", Slot = "15")]
		public override string CCEXGIURFJP(IReadOnlyList<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBE70", Offset = "0x2DFAA70", VA = "0x182DFBE70", Slot = "16")]
		public override int KYJUZDBAWSW(IReadOnlyList<IDLCASSILBG> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBE20", Offset = "0x2DFAA20", VA = "0x182DFBE20", Slot = "17")]
		public override bool HEZUPCSXBOT(IReadOnlyList<IDLCASSILBG> a, IReadOnlyList<IDLCASSILBG> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBF60", Offset = "0x2DFAB60", VA = "0x182DFBF60", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280")]
		public bool XGBYPYNVUZB([In] RGVPNJSFHFK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xBD2CF0", Offset = "0xBD18F0", VA = "0x180BD2CF0", Slot = "18")]
		public bool Equals(RGVPNJSFHFK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBDD0", Offset = "0x2DFA9D0", VA = "0x182DFBDD0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280", Slot = "19")]
		private bool CJCRNPQXMGN([In] RGVPNJSFHFK other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, MNLRIGBOINM<Property>, WRVOCMDCMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool EZVSORALWKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int OWOPEWNBEPM;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IDLCASSILBG JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool MYETRUOXBLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DFBJCPDGHSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x131B9B0", Offset = "0x131A5B0", VA = "0x18131B9B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB5F0", Offset = "0x2DFA1F0", VA = "0x182DFB5F0")]
		private Property(IDLCASSILBG type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB380", Offset = "0x2DF9F80", VA = "0x182DFB380")]
		public static Property New(IDLCASSILBG type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB410", Offset = "0x2DFA010", VA = "0x182DFB410", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB330", Offset = "0x2DF9F30", VA = "0x182DFB330")]
		private string LSRCDGVQUJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB210", Offset = "0x2DF9E10", VA = "0x182DFB210")]
		private string JAYEXZSIAOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB4F0", Offset = "0x2DFA0F0", VA = "0x182DFB4F0")]
		public bool XGBYPYNVUZB([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB130", Offset = "0x2DF9D30", VA = "0x182DFB130", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB0E0", Offset = "0x2DF9CE0", VA = "0x182DFB0E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB150", Offset = "0x2DF9D50", VA = "0x182DFB150", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB030", Offset = "0x2DF9C30", VA = "0x182DFB030")]
		private int CSLMZOJILYM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB270", Offset = "0x2DF9E70", VA = "0x182DFB270", Slot = "6")]
		public int KTCGSTQKGNK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB260", Offset = "0x2DF9E60", VA = "0x182DFB260", Slot = "5")]
		private bool JFWRHROAJXH([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class FMCZLIUZOXT : IDLCASSILBG, IEquatable<FMCZLIUZOXT>, MNLRIGBOINM<FMCZLIUZOXT>
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2DF93D0", Offset = "0x2DF7FD0", VA = "0x182DF93D0")]
		private FMCZLIUZOXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2DF92E0", Offset = "0x2DF7EE0", VA = "0x182DF92E0")]
		public static FMCZLIUZOXT New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9350", Offset = "0x2DF7F50", VA = "0x182DF9350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9200", Offset = "0x2DF7E00", VA = "0x182DF9200", Slot = "15")]
		public override string CCEXGIURFJP(IReadOnlyList<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9380", Offset = "0x2DF7F80", VA = "0x182DF9380", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280")]
		public bool XGBYPYNVUZB([In] FMCZLIUZOXT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xBD2CF0", Offset = "0xBD18F0", VA = "0x180BD2CF0", Slot = "18")]
		public bool Equals(FMCZLIUZOXT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9290", Offset = "0x2DF7E90", VA = "0x182DF9290", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280", Slot = "19")]
		private bool DSWNPZRLIYG([In] FMCZLIUZOXT other)
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
	public sealed class UYEZPSPUUCZ : IDLCASSILBG, IEquatable<UYEZPSPUUCZ>, MNLRIGBOINM<UYEZPSPUUCZ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool QHXOYOPWBQX
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE470", Offset = "0x2DFD070", VA = "0x182DFE470", Slot = "9")]
		public sealed override IDLCASSILBG WTMHKFXROUT(IReadOnlyDictionary<string, IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE5A0", Offset = "0x2DFD1A0", VA = "0x182DFE5A0", Slot = "11")]
		public sealed override void YRPNBRSEJXX(Action<IDLCASSILBG> a, Action<IDLCASSILBG> b, Action<IDLCASSILBG> c, Action<IDLCASSILBG> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE5D0", Offset = "0x2DFD1D0", VA = "0x182DFE5D0")]
		private UYEZPSPUUCZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE3F0", Offset = "0x2DFCFF0", VA = "0x182DFE3F0")]
		public static UYEZPSPUUCZ New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE550", Offset = "0x2DFD150", VA = "0x182DFE550", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280")]
		public bool XGBYPYNVUZB([In] UYEZPSPUUCZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xBD2CF0", Offset = "0xBD18F0", VA = "0x180BD2CF0", Slot = "18")]
		public bool Equals(UYEZPSPUUCZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE3A0", Offset = "0x2DFCFA0", VA = "0x182DFE3A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE380", Offset = "0x2DFCF80", VA = "0x182DFE380", Slot = "14")]
		protected sealed override int CSLMZOJILYM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280", Slot = "19")]
		private bool PRGRUVSDQTG([In] UYEZPSPUUCZ other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class YEQKIMUQGGQ : IDLCASSILBG
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<SFIRYYSAQXK> NFKDYQGQQBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFD40", Offset = "0x2DFE940", VA = "0x182DFFD40")]
		public void Initialize(YEQKIMUQGGQ from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFE50", Offset = "0x2DFEA50", VA = "0x182DFFE50")]
		protected YEQKIMUQGGQ(IEnumerable<SFIRYYSAQXK> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool XGBYPYNVUZB([In] IDLCASSILBG other);

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFDF0", Offset = "0x2DFE9F0", VA = "0x182DFFDF0")]
		protected bool XGBYPYNVUZB([In] YEQKIMUQGGQ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFCC0", Offset = "0x2DFE8C0", VA = "0x182DFFCC0", Slot = "14")]
		protected override int CSLMZOJILYM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFD70", Offset = "0x2DFE970", VA = "0x182DFFD70")]
		protected int QWHJXKNWPTI(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class SFIRYYSAQXK : IDLCASSILBG, IEquatable<SFIRYYSAQXK>, MNLRIGBOINM<SFIRYYSAQXK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IDLCASSILBG UUXOONAFRXI
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC390", Offset = "0x2DFAF90", VA = "0x182DFC390")]
		private SFIRYYSAQXK(string a, [Optional] IDLCASSILBG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC160", Offset = "0x2DFAD60", VA = "0x182DFC160")]
		public static SFIRYYSAQXK New(string name, [Optional] IDLCASSILBG constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC2B0", Offset = "0x2DFAEB0", VA = "0x182DFC2B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC340", Offset = "0x2DFAF40", VA = "0x182DFC340", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC260", Offset = "0x2DFAE60", VA = "0x182DFC260")]
		public bool XGBYPYNVUZB([In] SFIRYYSAQXK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC050", Offset = "0x2DFAC50", VA = "0x182DFC050", Slot = "18")]
		public bool Equals(SFIRYYSAQXK other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC0A0", Offset = "0x2DFACA0", VA = "0x182DFC0A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBFD0", Offset = "0x2DFABD0", VA = "0x182DFBFD0", Slot = "14")]
		protected override int CSLMZOJILYM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC0F0", Offset = "0x2DFACF0", VA = "0x182DFC0F0", Slot = "13")]
		public override int KTCGSTQKGNK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC260", Offset = "0x2DFAE60", VA = "0x182DFC260", Slot = "19")]
		private bool TGZJXIBOCRF([In] SFIRYYSAQXK other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class XAKIOEYWXRG : IDLCASSILBG, IEquatable<XAKIOEYWXRG>, MNLRIGBOINM<XAKIOEYWXRG>
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF1E0", Offset = "0x2DFDDE0", VA = "0x182DFF1E0")]
		private XAKIOEYWXRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF0F0", Offset = "0x2DFDCF0", VA = "0x182DFF0F0")]
		public static XAKIOEYWXRG New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF160", Offset = "0x2DFDD60", VA = "0x182DFF160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEF10", Offset = "0x2DFDB10", VA = "0x182DFEF10", Slot = "15")]
		public override string CCEXGIURFJP(IReadOnlyList<IDLCASSILBG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF0A0", Offset = "0x2DFDCA0", VA = "0x182DFF0A0", Slot = "16")]
		public override int KYJUZDBAWSW(IReadOnlyList<IDLCASSILBG> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF050", Offset = "0x2DFDC50", VA = "0x182DFF050", Slot = "17")]
		public override bool HEZUPCSXBOT(IReadOnlyList<IDLCASSILBG> a, IReadOnlyList<IDLCASSILBG> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF190", Offset = "0x2DFDD90", VA = "0x182DFF190", Slot = "12")]
		public override bool XGBYPYNVUZB([In] IDLCASSILBG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280")]
		public bool XGBYPYNVUZB([In] XAKIOEYWXRG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xBD2CF0", Offset = "0xBD18F0", VA = "0x180BD2CF0", Slot = "18")]
		public bool Equals(XAKIOEYWXRG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF000", Offset = "0x2DFDC00", VA = "0x182DFF000", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9280", Offset = "0x2DF7E80", VA = "0x182DF9280", Slot = "19")]
		private bool SXXWWVJOIML([In] XAKIOEYWXRG other)
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
			public readonly IDLCASSILBG CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
			internal Impl(IDLCASSILBG circuitType, string typeParameterReference)
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

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5870", Offset = "0x2DF4470", VA = "0x182DF5870")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5670", Offset = "0x2DF4270", VA = "0x182DF5670")]
		public static CircuitTypeOrString UIBWLZUGNWE(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2DF56E0", Offset = "0x2DF42E0", VA = "0x182DF56E0")]
		public static CircuitTypeOrString UIBWLZUGNWE(IDLCASSILBG a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2DF55D0", Offset = "0x2DF41D0", VA = "0x182DF55D0")]
		public IDLCASSILBG FGFEEAZVARB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5740", Offset = "0x2DF4340", VA = "0x182DF5740")]
		public static IDLCASSILBG[] ZVFWSEKJHJQ(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly BLRWHWFJONB _data;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		private ClassFactoryBaseClasses(BLRWHWFJONB data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x157B500", Offset = "0x157A100", VA = "0x18157B500")]
		public static ClassFactoryBaseClasses New(BLRWHWFJONB data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5970", Offset = "0x2DF4570", VA = "0x182DF5970")]
		public ClassFactoryBaseClasses WSDZVIANKGV(ZTFFPMGVSBN a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5950", Offset = "0x2DF4550", VA = "0x182DF5950")]
		public ClassFactoryProps VZTDEFRCUUS()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2DF58F0", Offset = "0x2DF44F0", VA = "0x182DF58F0")]
		public ClassFactoryProps OWAPJTTPGKH(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2DF58A0", Offset = "0x2DF44A0", VA = "0x182DF58A0")]
		public ZTFFPMGVSBN End()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class BLRWHWFJONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? AXUVQJAOTPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string QMZMPPIFWAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<SFIRYYSAQXK> NFKDYQGQQBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<ZTFFPMGVSBN> FGLMKKFNQOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> WSHXAECEFSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, XZSBJYBHFND>> EBTBYMYTOOC;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5440", Offset = "0x2DF4040", VA = "0x182DF5440")]
		private BLRWHWFJONB([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5290", Offset = "0x2DF3E90", VA = "0x182DF5290")]
		public static BLRWHWFJONB New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly BLRWHWFJONB _data;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		private ClassFactoryFuncs(BLRWHWFJONB data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x157B500", Offset = "0x157A100", VA = "0x18157B500")]
		public static ClassFactoryFuncs New(BLRWHWFJONB data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5A30", Offset = "0x2DF4630", VA = "0x182DF5A30")]
		public ZTFFPMGVSBN End()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly BLRWHWFJONB _data;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public ClassFactoryProps(BLRWHWFJONB data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5BC0", Offset = "0x2DF47C0", VA = "0x182DF5BC0")]
		public ClassFactoryProps OWAPJTTPGKH(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5950", Offset = "0x2DF4550", VA = "0x182DF5950")]
		public ClassFactoryFuncs DJMCKRWEXLZ()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5B80", Offset = "0x2DF4780", VA = "0x182DF5B80")]
		public ZTFFPMGVSBN End()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly BLRWHWFJONB _data;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		private ClassFactoryTypeParams(BLRWHWFJONB data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5DB0", Offset = "0x2DF49B0", VA = "0x182DF5DB0")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5F80", Offset = "0x2DF4B80", VA = "0x182DF5F80")]
		public ClassFactoryTypeParams OBEXELJBKOX(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5950", Offset = "0x2DF4550", VA = "0x182DF5950")]
		public ClassFactoryBaseClasses WQZPQHJNSFJ()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6220", Offset = "0x2DF4E20", VA = "0x182DF6220")]
		public ClassFactoryBaseClasses WSDZVIANKGV(ZTFFPMGVSBN a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5D50", Offset = "0x2DF4950", VA = "0x182DF5D50")]
		public ZTFFPMGVSBN End()
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
