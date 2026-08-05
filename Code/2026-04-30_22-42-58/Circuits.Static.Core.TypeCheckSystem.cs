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
		[Cpp2IlInjected.Address(RVA = "0xDACAB0", Offset = "0xDABEB0", VA = "0x180DACAB0")]
		internal DirectedType(TType type, IOKind ioKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A60950", Offset = "0x5A5FD50", VA = "0x185A60950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CVCQSLPZULI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x381FCE0", Offset = "0x381F0E0", VA = "0x18381FCE0")]
		public static DirectedType<TType> New<TType>(TType type, IOKind ioKind)
		{
			return default(DirectedType<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x381FEC0", Offset = "0x381F2C0", VA = "0x18381FEC0")]
		public static (c, IOKind) PEIKOHTWSZZ<c>([In] this DirectedType<c> self)
		{
			return default((c, IOKind));
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3820130", Offset = "0x381F530", VA = "0x183820130")]
		public static void PUDYXZFHDAC<d>([In] this DirectedType<d> self, [Out] d a, [Out] IOKind b)
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
		[Cpp2IlInjected.Address(RVA = "0x6261FD0", Offset = "0x62613D0", VA = "0x186261FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class MPGIQTZVFIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C04910", Offset = "0x3C03D10", VA = "0x183C04910")]
		public static (TypeParameterId<a>, TypeParameterId<a>) PEIKOHTWSZZ<a>([In] this EquivalentTypeParameters<a> self)
		{
			return default((TypeParameterId<a>, TypeParameterId<a>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3C04C20", Offset = "0x3C04020", VA = "0x183C04C20")]
		public static void PUDYXZFHDAC<b>([In] this EquivalentTypeParameters<b> self, [Out] TypeParameterId<b> a, [Out] TypeParameterId<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ELAIMARAHNG<a, b, c, d, e, f, g, h, i, j>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates MEMLXHUKGVV(j a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		e WZYYZTBNPKF(j a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DirectedType<e> VDGYFSDREIW(j a, [In] DirectedType<e> lhs, [In] DirectedType<e> rhs);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int UXGJJYOOLEM(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int VKGROSOJBHX(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		f MMILYYRGLTY(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int RIMFLXZAUMG(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		g FLAYNQPPKUP(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IEnumerable<TypeParameter<e>> RFOFWHNNLBQ(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<EquivalentTypeParameters<h>> SAWFNMUJIGX(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		e LDIYNEGDSXZ(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int VYDIAWXOTXU(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		g EADAPMCBVZJ(j a, i b, f c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "13")]
		h BNLIZSQTPRE(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "14")]
		e ROZUZRFVCCC(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "15")]
		int SHPGEKQSDFI(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "16")]
		f JPTYFKPUULB(j a, i b, g c, int d);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		h XRMZNFYVLUF(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool YVCVXMCKWVC(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		e AKIYUHWPBTU(j a, e b, IEnumerable<e> c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void YHGYBIIVVXG(j a, e b, Action<e> c, Action<e> d, Action<e> e, Action<e> f);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		e OOXZQBOHWHO(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		string XDCDFRORSEZ(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "23")]
		d BWAPRRIZNIF(j a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Result<c[], OKJLNQTBITD> CHENXHRAGHY(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "25")]
		a QSWAKSPREIH(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "26")]
		a CUCRHRNLQGM(j a, d b, a c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "27")]
		a YWUEPKQNVUM(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void WMSSFPJQWOE(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool FKYXPMYZFRX(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool SWYIEJNPZFR(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "31")]
		a VNCRVESTEJY(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "32")]
		b HQQMGNZHZRP(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		b POFXMYAYCTO(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		a DDPNVZNRGUI(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		b CRQAVUZFHNE(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		b LXKXUQBHMWB(j a, d b, a c);
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : ELAIMARAHNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0")]
		public static TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> New()
		{
			return default(TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TypeCheckSys
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private static class KSVZKVHLNTI<b, c, d, e, f, g, h, i, j, k, l> where l : ELAIMARAHNG<b, c, d, e, f, g, h, i, j, k>
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private sealed class XPLTUZQEMLT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public k XJMGIEKJBLY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public readonly l TLGMPNEBIBW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public e QOMWDYPMDTR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public j HKPZFIXUTFA;

				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public PerfScopeDelegates KWBUTGKVQPZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x5030F50", Offset = "0x5030350", VA = "0x185030F50")]
					get
					{
						return default(PerfScopeDelegates);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5031160", Offset = "0x5030560", VA = "0x185031160")]
				private XPLTUZQEMLT(k a, l b, e c, j d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x502D050", Offset = "0x502C450", VA = "0x18502D050")]
				public static XPLTUZQEMLT New(k root, l deps, e unificationSys, j graph)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x502FF00", Offset = "0x502F300", VA = "0x18502FF00")]
				public f WZYYZTBNPKF()
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x502F1B0", Offset = "0x502E5B0", VA = "0x18502F1B0")]
				public DirectedType<f> VDGYFSDREIW(DirectedType<f> a, DirectedType<f> b)
				{
					return default(DirectedType<f>);
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x502EBF0", Offset = "0x502DFF0", VA = "0x18502EBF0")]
				public int UXGJJYOOLEM(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x502F530", Offset = "0x502E930", VA = "0x18502F530")]
				public int VKGROSOJBHX(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x502C8A0", Offset = "0x502BCA0", VA = "0x18502C8A0")]
				public g MMILYYRGLTY(i a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x502DE30", Offset = "0x502D230", VA = "0x18502DE30")]
				public int RIMFLXZAUMG(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x502B590", Offset = "0x502A990", VA = "0x18502B590")]
				public h FLAYNQPPKUP(i a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x502DAD0", Offset = "0x502CED0", VA = "0x18502DAD0")]
				public IEnumerable<TypeParameter<f>> RFOFWHNNLBQ(i a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x502E840", Offset = "0x502DC40", VA = "0x18502E840")]
				public IEnumerable<EquivalentTypeParameters<i>> SAWFNMUJIGX([In] i node)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x502C130", Offset = "0x502B530", VA = "0x18502C130")]
				public f LDIYNEGDSXZ(g a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x5029B70", Offset = "0x5028F70", VA = "0x185029B70")]
				public int AZKEPCEMDHJ(g a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x502AA70", Offset = "0x5029E70", VA = "0x18502AA70")]
				public h EADAPMCBVZJ(g a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x5029F30", Offset = "0x5029330", VA = "0x185029F30")]
				public i BNLIZSQTPRE(g a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x502E190", Offset = "0x502D590", VA = "0x18502E190")]
				public f ROZUZRFVCCC(h a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x502C0E0", Offset = "0x502B4E0", VA = "0x18502C0E0")]
				public int KRPGLGNQCWH(h a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x502B990", Offset = "0x502AD90", VA = "0x18502B990")]
				public g JPTYFKPUULB(h a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5030540", Offset = "0x502F940", VA = "0x185030540")]
				public i XRMZNFYVLUF(h a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x50308A0", Offset = "0x502FCA0", VA = "0x1850308A0")]
				public bool YVCVXMCKWVC(f a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x5029800", Offset = "0x5028C00", VA = "0x185029800")]
				public f AKIYUHWPBTU(f a, IEnumerable<f> b)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x5030590", Offset = "0x502F990", VA = "0x185030590")]
				public void YHGYBIIVVXG(f a, Action<f> b, Action<f> c, Action<f> d, Action<f> e)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x502D120", Offset = "0x502C520", VA = "0x18502D120")]
				public f OOXZQBOHWHO(f a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x502FF30", Offset = "0x502F330", VA = "0x18502FF30")]
				public string XDCDFRORSEZ(f a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x502DA90", Offset = "0x502CE90", VA = "0x18502DA90")]
				public b QSWAKSPREIH()
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x502A680", Offset = "0x5029A80", VA = "0x18502A680")]
				public b CUCRHRNLQGM(b a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x5030B40", Offset = "0x502FF40", VA = "0x185030B40")]
				public b YWUEPKQNVUM(b a, b b)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x502F920", Offset = "0x502ED20", VA = "0x18502F920")]
				public void WMSSFPJQWOE(b a, b b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x502E880", Offset = "0x502DC80", VA = "0x18502E880")]
				public bool SWYIEJNPZFR(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x502AE90", Offset = "0x502A290", VA = "0x18502AE90")]
				public bool FKYXPMYZFRX(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x502F8E0", Offset = "0x502ECE0", VA = "0x18502F8E0")]
				public b VUXNRBHQYJD(c a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x502B600", Offset = "0x502AA00", VA = "0x18502B600")]
				public c HQQMGNZHZRP(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x502D420", Offset = "0x502C820", VA = "0x18502D420")]
				public c POFXMYAYCTO(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x502AA30", Offset = "0x5029E30", VA = "0x18502AA30")]
				public b DDPNVZNRGUI(d a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x502A2F0", Offset = "0x50296F0", VA = "0x18502A2F0")]
				public c CRQAVUZFHNE(d a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x502C860", Offset = "0x502BC60", VA = "0x18502C860")]
				public c LXKXUQBHMWB(b a)
				{
					return (c)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class NCLLTQFRZHV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public XPLTUZQEMLT QVIEKQHPMXY;

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public NCLLTQFRZHV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x71BAC90", Offset = "0x71BA090", VA = "0x1871BAC90")]
				internal b BMDGQSUBYYG(d a)
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class JZPSQTWWHKR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public XPLTUZQEMLT QVIEKQHPMXY;

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public JZPSQTWWHKR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x664BEF0", Offset = "0x664B2F0", VA = "0x18664BEF0")]
				internal int JHGPBFHTHMY(XPLTUZQEMLT a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x664C080", Offset = "0x664B480", VA = "0x18664C080")]
				internal g JHLVYMBQQYH(XPLTUZQEMLT a, i b, int c)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x664C1C0", Offset = "0x664B5C0", VA = "0x18664C1C0")]
				internal int JHWJSZPLJUZ(XPLTUZQEMLT a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x664BDB0", Offset = "0x664B1B0", VA = "0x18664BDB0")]
				internal h JGLNMEGDVTO(XPLTUZQEMLT a, i b, int c)
				{
					return (h)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class EZWOGTCCREE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public XPLTUZQEMLT QVIEKQHPMXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public i CANSHDFJKQC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public Dictionary<b, TypeParameterId<i>> TVPPUNIWYLD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public Dictionary<TypeParameterId<i>, b> HIPBCIDQUXH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public List<KeyValuePair<b, DirectedType<f>>> DTORPLFJFAK;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public EZWOGTCCREE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5B2FC90", Offset = "0x5B2F090", VA = "0x185B2FC90")]
				internal (string, b) IUYYJNRTKTS(TypeParameter<f> a)
				{
					return default((string, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class QXLRGRRVYAH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public XPLTUZQEMLT QVIEKQHPMXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public List<KeyValuePair<b, DirectedType<f>>> DTORPLFJFAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public IOKind XVCQZVZEGHK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public List<b> GKCNPOUWRGV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public IReadOnlyDictionary<string, b> HIPBCIDQUXH;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
				public QXLRGRRVYAH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x76768A0", Offset = "0x7675CA0", VA = "0x1876768A0")]
				internal void YJWBZCQUFPD(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7676210", Offset = "0x7675610", VA = "0x187676210")]
				internal void YJQVBVWWWDU(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x7675BA0", Offset = "0x7674FA0", VA = "0x187675BA0")]
				internal void YJLOEPCZMSL(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x7675A70", Offset = "0x7674E70", VA = "0x187675A70")]
				internal void YJGHHIJCDHC(f a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x678C520", Offset = "0x678B920", VA = "0x18678C520")]
			private static LogString KRVLWKFOWUT([CallerMemberName] string name = "")
			{
				return default(LogString);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x678AFC0", Offset = "0x678A3C0", VA = "0x18678AFC0")]
			public static Dictionary<i, List<TypeParameter<f>>> InferTypes(k root, l deps, j graph, IEnumerable<i> nodes)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6786BE0", Offset = "0x6785FE0", VA = "0x186786BE0")]
			private static (Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>) GenerateConstraintsForNodes(IEnumerable<i> nodes, XPLTUZQEMLT arg)
			{
				return default((Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x678E210", Offset = "0x678D610", VA = "0x18678E210")]
			private static void OUPRXLYESUG(i a, Dictionary<g, b> b, Dictionary<h, b> c, Dictionary<b, TypeParameterId<i>> d, Dictionary<TypeParameterId<i>, b> e, List<KeyValuePair<b, DirectedType<f>>> f, Stack<i> g, List<EquivalentTypeParameters<i>> h, XPLTUZQEMLT i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6789B60", Offset = "0x6788F60", VA = "0x186789B60")]
			private static Dictionary<string, b> IFRZKMAHYGO(i a, Dictionary<b, TypeParameterId<i>> b, Dictionary<TypeParameterId<i>, b> c, List<KeyValuePair<b, DirectedType<f>>> d, XPLTUZQEMLT e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x394CFC0", Offset = "0x394C3C0", VA = "0x18394CFC0")]
			private static (a, b)[] RGYEUSLKUUN<a>(i a, Func<XPLTUZQEMLT, i, int> b, Func<XPLTUZQEMLT, i, int, a> c, Func<XPLTUZQEMLT, a, f> d, Dictionary<a, b> e, XPLTUZQEMLT f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6792FE0", Offset = "0x67923E0", VA = "0x186792FE0")]
			private static (b, b) RATWXMLHREE((h Output, b Id)[] outputs, List<KeyValuePair<b, DirectedType<f>>> a, Dictionary<string, b> b, Stack<i> c, XPLTUZQEMLT d)
			{
				return default((b, b));
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6796190", Offset = "0x6795590", VA = "0x186796190")]
			private static void UWFVMDFATLR((g PortKey, b Id)[] inputs, b a, b b, List<KeyValuePair<b, DirectedType<f>>> c, Dictionary<h, b> d, Dictionary<string, b> e, Stack<i> f, XPLTUZQEMLT g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x678B430", Offset = "0x678A830", VA = "0x18678B430")]
			private static b KHNKGHKVZLZ(g a, List<KeyValuePair<b, DirectedType<f>>> b, Dictionary<h, b> c, Stack<i> d, XPLTUZQEMLT e)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x67867C0", Offset = "0x6785BC0", VA = "0x1867867C0")]
			private static b EFDUBPEMVUZ([In] f type, IOKind a, List<KeyValuePair<b, DirectedType<f>>> b, IReadOnlyDictionary<string, b> c, XPLTUZQEMLT d)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6787F40", Offset = "0x6787340", VA = "0x186787F40")]
			private static Dictionary<i, List<TypeParameter<f>>> GetTypeParameterAssignments(d[] substitutions, Dictionary<b, TypeParameterId<i>> idToTypeParameter, IEnumerable<KeyValuePair<b, DirectedType<f>>> idToType, XPLTUZQEMLT arg)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x678C560", Offset = "0x678B960", VA = "0x18678C560")]
			private static Dictionary<i, List<TypeParameter<f>>> NFSUSJZNLIX(Dictionary<b, TypeParameterId<i>> a, XPLTUZQEMLT b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6784FE0", Offset = "0x67843E0", VA = "0x186784FE0")]
			private static void AOPKZLKMZKN([In] i node, Stack<i> a, List<EquivalentTypeParameters<i>> b, XPLTUZQEMLT c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6795E30", Offset = "0x6795230", VA = "0x186795E30")]
			private static void TSJWDSJGLML(Dictionary<TypeParameterId<i>, b> a, List<EquivalentTypeParameters<i>> b, XPLTUZQEMLT c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x678EB60", Offset = "0x678DF60", VA = "0x18678EB60")]
			private static Dictionary<b, f> QYUVGRNEQYA(Dictionary<b, d> a, IEnumerable<KeyValuePair<b, DirectedType<f>>> b, XPLTUZQEMLT c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x67937C0", Offset = "0x6792BC0", VA = "0x1867937C0")]
			private static Option<f> RCYHACDUVMH(c a, Dictionary<b, f> b, Dictionary<b, f> c, XPLTUZQEMLT d)
			{
				return default(Option<f>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6785FE0", Offset = "0x67853E0", VA = "0x186785FE0")]
			private static c BNWIDADVKGD(c a, XPLTUZQEMLT b)
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F42420", Offset = "0x3F41820", VA = "0x183F42420")]
		public static Dictionary<TNode, List<TypeParameter<TType>>> InferTypes<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> self, TRoot root, TGraph graph, IEnumerable<TNode> nodes) where TDeps : ELAIMARAHNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct TypeParameter<TType> : IEquatable<TypeParameter<TType>>, MAQPBFCDGIJ<TypeParameter<TType>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly TType Constraint;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D19640", Offset = "0x7D18A40", VA = "0x187D19640")]
		internal TypeParameter(string name, [In] TType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7D193C0", Offset = "0x7D187C0", VA = "0x187D193C0")]
		public bool NFHEFKJNFIE([In] TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D18ED0", Offset = "0x7D182D0", VA = "0x187D18ED0", Slot = "4")]
		public bool Equals(TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D18E90", Offset = "0x7D18290", VA = "0x187D18E90", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D18570", Offset = "0x7D17970", VA = "0x187D18570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7D19600", Offset = "0x7D18A00", VA = "0x187D19600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7D19460", Offset = "0x7D18860", VA = "0x187D19460", Slot = "5")]
		private bool SXJXBTHRSHK([In] TypeParameter<TType> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RMGKEFRJEER
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AE20", Offset = "0x3E0A220", VA = "0x183E0AE20")]
		public static TypeParameter<TType> New<TType>(string name, TType constraint)
		{
			return default(TypeParameter<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3E0AFF0", Offset = "0x3E0A3F0", VA = "0x183E0AFF0")]
		public static (string, a) PEIKOHTWSZZ<a>([In] this TypeParameter<a> self)
		{
			return default((string, a));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct TypeParameterId<TNode> : IEquatable<TypeParameterId<TNode>>, MAQPBFCDGIJ<TypeParameterId<TNode>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly TNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly string Name;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
		internal TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D187E0", Offset = "0x7D17BE0", VA = "0x187D187E0")]
		public bool NFHEFKJNFIE([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D18520", Offset = "0x7D17920", VA = "0x187D18520", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7D184E0", Offset = "0x7D178E0", VA = "0x187D184E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7D18570", Offset = "0x7D17970", VA = "0x187D18570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7D18CA0", Offset = "0x7D180A0", VA = "0x187D18CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D18B00", Offset = "0x7D17F00", VA = "0x187D18B00", Slot = "5")]
		private bool QIFBHBIXXML([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class AITYRAACPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3361380", Offset = "0x3360780", VA = "0x183361380")]
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
