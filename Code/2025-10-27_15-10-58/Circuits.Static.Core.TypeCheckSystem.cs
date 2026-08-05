using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Circuits.Static.Core.TypeCheckSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public readonly struct DirectedType<TType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly TType Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly IOKind IOKind;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xE73B10", Offset = "0xE72B10", VA = "0x180E73B10")]
		internal DirectedType(TType type, IOKind ioKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D090", Offset = "0x4A4C090", VA = "0x184A4D090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class HDWASKBHOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x39A5C50", Offset = "0x39A4C50", VA = "0x1839A5C50")]
		public static DirectedType<TType> New<TType>(TType type, IOKind ioKind)
		{
			return default(DirectedType<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x39A5AA0", Offset = "0x39A4AA0", VA = "0x1839A5AA0")]
		public static (c, IOKind) ILZGMZDGYZM<c>([In] this DirectedType<c> self)
		{
			return default((c, IOKind));
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x39A5ED0", Offset = "0x39A4ED0", VA = "0x1839A5ED0")]
		public static void ZFXAJJHVNLN<d>([In] this DirectedType<d> self, [Out] d a, [Out] IOKind b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct EquivalentTypeParameters<TNode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly TypeParameterId<TNode> Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly TypeParameterId<TNode> Right;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5065400", Offset = "0x5064400", VA = "0x185065400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class JQNTLLQHORL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3A18C70", Offset = "0x3A17C70", VA = "0x183A18C70")]
		public static (TypeParameterId<a>, TypeParameterId<a>) ILZGMZDGYZM<a>([In] this EquivalentTypeParameters<a> self)
		{
			return default((TypeParameterId<a>, TypeParameterId<a>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3A18F80", Offset = "0x3A17F80", VA = "0x183A18F80")]
		public static void ZFXAJJHVNLN<b>([In] this EquivalentTypeParameters<b> self, [Out] TypeParameterId<b> a, [Out] TypeParameterId<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface KHWOHOVSMKP<a, b, c, d, e, f, g, h, i, j>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates LLYGAUXPCRG(j a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		e HSCWVGWOBXM(j a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DirectedType<e> LJOEDJPUEXB(j a, [In] DirectedType<e> lhs, [In] DirectedType<e> rhs);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int FTUSIMIXDQN(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int VVXGZLECWMA(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		f RPCOJQQXHSR(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int YUYSLDIQDQZ(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		g LQHOQPITWDY(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IEnumerable<TypeParameter<e>> SJKHIAACIZR(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<EquivalentTypeParameters<h>> BXURTQOUSBY(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		e HIACDBJGARE(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int JMACVXYNWKD(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		g ZOZBHCQELWA(j a, i b, f c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "13")]
		h NLUADNSWVFD(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "14")]
		e OLBUNFNUWEB(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "15")]
		int DCSPNABOYYH(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "16")]
		f YTICVZGXEEI(j a, i b, g c, int d);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		h CZTCBJFQKHC(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool TZKFAJNJXFJ(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		e WQCIRTMLXXL(j a, e b, IEnumerable<e> c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void ASWBDQMGGSP(j a, e b, Action<e> c, Action<e> d, Action<e> e, Action<e> f);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		e EUXJJCXYFTN(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		string LYJIPTKCLKQ(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "23")]
		d UBGBVFERFBQ(j a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Result<c[], GJHFNOSHAUY> JSJYXXUTSMN(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "25")]
		a PHUYZTRBCPU(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "26")]
		a DZFISMWBNNL(j a, d b, a c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "27")]
		a GULQIMWLARV(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void RNWPRTFCHSZ(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool BZCZUJBEFBU(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool OQSIEULHHBU(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "31")]
		a IBEDESXCWIJ(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "32")]
		b ZZJJBULXYNK(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		b VSTUCMIPWWJ(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		a DYHEKCNOBUX(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		b WCALOVUFGNN(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		b WTXACCWSRDI(j a, d b, a c);
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : KHWOHOVSMKP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		public static TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> New()
		{
			return default(TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TypeCheckSys
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private static class ZDYWKMRNJBF<b, c, d, e, f, g, h, i, j, k, l> where l : KHWOHOVSMKP<b, c, d, e, f, g, h, i, j, k>
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private sealed class QNZKHTXECKA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public k BMMCJSHXUWV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public readonly l RTTBFFUBHQH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public e LLKXFQRKQSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public j ZCJNNUPRSVB;

				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public PerfScopeDelegates OODTJWMFUPI
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x5E4D5F0", Offset = "0x5E4C5F0", VA = "0x185E4D5F0")]
					get
					{
						return default(PerfScopeDelegates);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5E4E9F0", Offset = "0x5E4D9F0", VA = "0x185E4E9F0")]
				private QNZKHTXECKA(k a, l b, e c, j d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x5E49F80", Offset = "0x5E48F80", VA = "0x185E49F80")]
				public static QNZKHTXECKA New(k root, l deps, e unificationSys, j graph)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x5E48B10", Offset = "0x5E47B10", VA = "0x185E48B10")]
				public f HSCWVGWOBXM()
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x5E48DA0", Offset = "0x5E47DA0", VA = "0x185E48DA0")]
				public DirectedType<f> LJOEDJPUEXB(DirectedType<f> a, DirectedType<f> b)
				{
					return default(DirectedType<f>);
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x5E48290", Offset = "0x5E47290", VA = "0x185E48290")]
				public int FTUSIMIXDQN(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5E4C530", Offset = "0x5E4B530", VA = "0x185E4C530")]
				public int VVXGZLECWMA(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x5E4BA80", Offset = "0x5E4AA80", VA = "0x185E4BA80")]
				public g RPCOJQQXHSR(i a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x5E4DA80", Offset = "0x5E4CA80", VA = "0x185E4DA80")]
				public int YUYSLDIQDQZ(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x5E49440", Offset = "0x5E48440", VA = "0x185E49440")]
				public h LQHOQPITWDY(i a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x5E4BAF0", Offset = "0x5E4AAF0", VA = "0x185E4BAF0")]
				public IEnumerable<TypeParameter<f>> SJKHIAACIZR(i a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x5E46C60", Offset = "0x5E45C60", VA = "0x185E46C60")]
				public IEnumerable<EquivalentTypeParameters<i>> BXURTQOUSBY([In] i node)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x5E48AC0", Offset = "0x5E47AC0", VA = "0x185E48AC0")]
				public f HIACDBJGARE(g a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x5E4E180", Offset = "0x5E4D180", VA = "0x185E4E180")]
				public int ZBWVXUMEVMM(g a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x5E4E5A0", Offset = "0x5E4D5A0", VA = "0x185E4E5A0")]
				public h ZOZBHCQELWA(g a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x5E49B30", Offset = "0x5E48B30", VA = "0x185E49B30")]
				public i NLUADNSWVFD(g a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x5E4A050", Offset = "0x5E49050", VA = "0x185E4A050")]
				public f OLBUNFNUWEB(h a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x5E4AB30", Offset = "0x5E49B30", VA = "0x185E4AB30")]
				public int QTDXUWSJVLO(h a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x5E4DA00", Offset = "0x5E4CA00", VA = "0x185E4DA00")]
				public g YTICVZGXEEI(h a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5E47060", Offset = "0x5E46060", VA = "0x185E47060")]
				public i CZTCBJFQKHC(h a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x5E4BE90", Offset = "0x5E4AE90", VA = "0x185E4BE90")]
				public bool TZKFAJNJXFJ(f a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x5E4CFB0", Offset = "0x5E4BFB0", VA = "0x185E4CFB0")]
				public f WQCIRTMLXXL(f a, IEnumerable<f> b)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x5E468D0", Offset = "0x5E458D0", VA = "0x185E468D0")]
				public void ASWBDQMGGSP(f a, Action<f> b, Action<f> c, Action<f> d, Action<f> e)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x5E47F00", Offset = "0x5E46F00", VA = "0x185E47F00")]
				public f EUXJJCXYFTN(f a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x5E49740", Offset = "0x5E48740", VA = "0x185E49740")]
				public string LYJIPTKCLKQ(f a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x5E4AAF0", Offset = "0x5E49AF0", VA = "0x185E4AAF0")]
				public b PHUYZTRBCPU()
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x5E47BD0", Offset = "0x5E46BD0", VA = "0x185E47BD0")]
				public b DZFISMWBNNL(b a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x5E486D0", Offset = "0x5E476D0", VA = "0x185E486D0")]
				public b GULQIMWLARV(b a, b b)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B670", Offset = "0x5E4A670", VA = "0x185E4B670")]
				public void RNWPRTFCHSZ(b a, b b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x5E4A7A0", Offset = "0x5E497A0", VA = "0x185E4A7A0")]
				public bool OQSIEULHHBU(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x5E47010", Offset = "0x5E46010", VA = "0x185E47010")]
				public bool BZCZUJBEFBU(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B280", Offset = "0x5E4A280", VA = "0x185E4B280")]
				public b RKEBSULMLPE(c a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x5E4E620", Offset = "0x5E4D620", VA = "0x185E4E620")]
				public c ZZJJBULXYNK(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x5E4C4E0", Offset = "0x5E4B4E0", VA = "0x185E4C4E0")]
				public c VSTUCMIPWWJ(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x5E47800", Offset = "0x5E46800", VA = "0x185E47800")]
				public b DYHEKCNOBUX(d a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x5E4C8C0", Offset = "0x5E4B8C0", VA = "0x185E4C8C0")]
				public c WCALOVUFGNN(d a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x5E4CFF0", Offset = "0x5E4BFF0", VA = "0x185E4CFF0")]
				public c WTXACCWSRDI(b a)
				{
					return (c)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class MVGSWCHOTEO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public QNZKHTXECKA UNYVXTTZBMP;

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public MVGSWCHOTEO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x5AE8970", Offset = "0x5AE7970", VA = "0x185AE8970")]
				internal b IUHDIVJXMLF(d a)
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class CWRWNJLXLSS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public QNZKHTXECKA UNYVXTTZBMP;

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public CWRWNJLXLSS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x4235220", Offset = "0x4234220", VA = "0x184235220")]
				internal int DEUUNEUZSPB(QNZKHTXECKA a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x42351C0", Offset = "0x42341C0", VA = "0x1842351C0")]
				internal g DEPNPYBCJDS(QNZKHTXECKA a, i b, int c)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x4235350", Offset = "0x4234350", VA = "0x184235350")]
				internal int DFABKLOXCAK(QNZKHTXECKA a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x4234E80", Offset = "0x4233E80", VA = "0x184234E80")]
				internal h DDZSYDTKGVR(QNZKHTXECKA a, i b, int c)
				{
					return (h)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class YNXANUMFTWX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public QNZKHTXECKA UNYVXTTZBMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public i TOZOHSYJFSZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public Dictionary<b, TypeParameterId<i>> SLDZQWBKBME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public Dictionary<TypeParameterId<i>, b> TCIRRBZETIU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public List<KeyValuePair<b, DirectedType<f>>> MXHQOZZPBMR;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public YNXANUMFTWX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x419D7A0", Offset = "0x419C7A0", VA = "0x18419D7A0")]
				internal (string, b) ONZIWDQMGRZ(TypeParameter<f> a)
				{
					return default((string, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class SCYSNCSTSXC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public QNZKHTXECKA UNYVXTTZBMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public List<KeyValuePair<b, DirectedType<f>>> MXHQOZZPBMR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public IOKind PKVILUCFHUH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public List<b> RYEIYCYNLUM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public IReadOnlyDictionary<string, b> TCIRRBZETIU;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public SCYSNCSTSXC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x618D120", Offset = "0x618C120", VA = "0x18618D120")]
				internal void JJPLYJCOQSO(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x618D3A0", Offset = "0x618C3A0", VA = "0x18618D3A0")]
				internal void JJUSVPWMADX(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x618C010", Offset = "0x618B010", VA = "0x18618C010")]
				internal void JJEYDVOTXVW(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x618C6F0", Offset = "0x618B6F0", VA = "0x18618C6F0")]
				internal void JJKFBCIRHHF(f a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x41A5370", Offset = "0x41A4370", VA = "0x1841A5370")]
			private static LogString AVBXJFPLMOS([CallerMemberName] string name = "")
			{
				return default(LogString);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x41A9C60", Offset = "0x41A8C60", VA = "0x1841A9C60")]
			public static Dictionary<i, List<TypeParameter<f>>> InferTypes(k root, l deps, j graph, IEnumerable<i> nodes)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x41A76C0", Offset = "0x41A66C0", VA = "0x1841A76C0")]
			private static (Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>) GenerateConstraintsForNodes(IEnumerable<i> nodes, QNZKHTXECKA arg)
			{
				return default((Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x41AED60", Offset = "0x41ADD60", VA = "0x1841AED60")]
			private static void NVBZSOWQNUN(i a, Dictionary<g, b> b, Dictionary<h, b> c, Dictionary<b, TypeParameterId<i>> d, Dictionary<TypeParameterId<i>, b> e, List<KeyValuePair<b, DirectedType<f>>> f, Stack<i> g, List<EquivalentTypeParameters<i>> h, QNZKHTXECKA i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x41B24A0", Offset = "0x41B14A0", VA = "0x1841B24A0")]
			private static Dictionary<string, b> PNUAQRAKDMZ(i a, Dictionary<b, TypeParameterId<i>> b, Dictionary<TypeParameterId<i>, b> c, List<KeyValuePair<b, DirectedType<f>>> d, QNZKHTXECKA e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x3318D30", Offset = "0x3317D30", VA = "0x183318D30")]
			private static (a, b)[] NOHITUTWFDK<a>(i a, Func<QNZKHTXECKA, i, int> b, Func<QNZKHTXECKA, i, int, a> c, Func<QNZKHTXECKA, a, f> d, Dictionary<a, b> e, QNZKHTXECKA f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x41B9A10", Offset = "0x41B8A10", VA = "0x1841B9A10")]
			private static (b, b) YSIDOCMPQSH((h Output, b Id)[] outputs, List<KeyValuePair<b, DirectedType<f>>> a, Dictionary<string, b> b, Stack<i> c, QNZKHTXECKA d)
			{
				return default((b, b));
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x41AF740", Offset = "0x41AE740", VA = "0x1841AF740")]
			private static void OCKISKSJMZA((g PortKey, b Id)[] inputs, b a, b b, List<KeyValuePair<b, DirectedType<f>>> c, Dictionary<h, b> d, Dictionary<string, b> e, Stack<i> f, QNZKHTXECKA g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x41AC8C0", Offset = "0x41AB8C0", VA = "0x1841AC8C0")]
			private static b NKCBINHBREC(g a, List<KeyValuePair<b, DirectedType<f>>> b, Dictionary<h, b> c, Stack<i> d, QNZKHTXECKA e)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x41AB560", Offset = "0x41AA560", VA = "0x1841AB560")]
			private static b LLGBWPLRLMC([In] f type, IOKind a, List<KeyValuePair<b, DirectedType<f>>> b, IReadOnlyDictionary<string, b> c, QNZKHTXECKA d)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x41A7F10", Offset = "0x41A6F10", VA = "0x1841A7F10")]
			private static Dictionary<i, List<TypeParameter<f>>> GetTypeParameterAssignments(d[] substitutions, Dictionary<b, TypeParameterId<i>> idToTypeParameter, IEnumerable<KeyValuePair<b, DirectedType<f>>> idToType, QNZKHTXECKA arg)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x41A66E0", Offset = "0x41A56E0", VA = "0x1841A66E0")]
			private static Dictionary<i, List<TypeParameter<f>>> GDCMPBRVOWA(Dictionary<b, TypeParameterId<i>> a, QNZKHTXECKA b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x41A5C20", Offset = "0x41A4C20", VA = "0x1841A5C20")]
			private static void BURIBOIRVZO([In] i node, Stack<i> a, List<EquivalentTypeParameters<i>> b, QNZKHTXECKA c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x41AB9C0", Offset = "0x41AA9C0", VA = "0x1841AB9C0")]
			private static void LZVLIPQZLVO(Dictionary<TypeParameterId<i>, b> a, List<EquivalentTypeParameters<i>> b, QNZKHTXECKA c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x41B3D50", Offset = "0x41B2D50", VA = "0x1841B3D50")]
			private static Dictionary<b, f> QIDIKQNXVJJ(Dictionary<b, d> a, IEnumerable<KeyValuePair<b, DirectedType<f>>> b, QNZKHTXECKA c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x41B6F70", Offset = "0x41B5F70", VA = "0x1841B6F70")]
			private static Option<f> YIDKRDSNFSY(c a, Dictionary<b, f> b, Dictionary<b, f> c, QNZKHTXECKA d)
			{
				return default(Option<f>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x41B49B0", Offset = "0x41B39B0", VA = "0x1841B49B0")]
			private static c WONIGKEGLZC(c a, QNZKHTXECKA b)
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAE90", Offset = "0x3DF9E90", VA = "0x183DFAE90")]
		public static Dictionary<TNode, List<TypeParameter<TType>>> InferTypes<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> self, TRoot root, TGraph graph, IEnumerable<TNode> nodes) where TDeps : KHWOHOVSMKP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct TypeParameter<TType> : IEquatable<TypeParameter<TType>>, CMJSCLNOINY<TypeParameter<TType>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly TType Constraint;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x64B72D0", Offset = "0x64B62D0", VA = "0x1864B72D0")]
		internal TypeParameter(string name, [In] TType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64B6E70", Offset = "0x64B5E70", VA = "0x1864B6E70")]
		public bool FSWIJMLMNCH([In] TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64B6B80", Offset = "0x64B5B80", VA = "0x1864B6B80", Slot = "4")]
		public bool Equals(TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x64B6B40", Offset = "0x64B5B40", VA = "0x1864B6B40", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x64B64D0", Offset = "0x64B54D0", VA = "0x1864B64D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x64B7290", Offset = "0x64B6290", VA = "0x1864B7290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64B6AF0", Offset = "0x64B5AF0", VA = "0x1864B6AF0", Slot = "5")]
		private bool AHXJJOMCEOL([In] TypeParameter<TType> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class DQQHOOGJIDW
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3830440", Offset = "0x382F440", VA = "0x183830440")]
		public static TypeParameter<TType> New<TType>(string name, TType constraint)
		{
			return default(TypeParameter<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3830310", Offset = "0x382F310", VA = "0x183830310")]
		public static (string, a) ILZGMZDGYZM<a>([In] this TypeParameter<a> self)
		{
			return default((string, a));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct TypeParameterId<TNode> : IEquatable<TypeParameterId<TNode>>, CMJSCLNOINY<TypeParameterId<TNode>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly TNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly string Name;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
		internal TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x64B6190", Offset = "0x64B5190", VA = "0x1864B6190")]
		public bool FSWIJMLMNCH([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x64B6140", Offset = "0x64B5140", VA = "0x1864B6140", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x64B6100", Offset = "0x64B5100", VA = "0x1864B6100", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64B64D0", Offset = "0x64B54D0", VA = "0x1864B64D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x64B68F0", Offset = "0x64B58F0", VA = "0x1864B68F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x64B6750", Offset = "0x64B5750", VA = "0x1864B6750", Slot = "5")]
		private bool JOMYIXDBMFC([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JPOSONCHTZT
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3A18A40", Offset = "0x3A17A40", VA = "0x183A18A40")]
		public static TypeParameterId<TNode> New<TNode>(TNode node, string name)
		{
			return default(TypeParameterId<TNode>);
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
