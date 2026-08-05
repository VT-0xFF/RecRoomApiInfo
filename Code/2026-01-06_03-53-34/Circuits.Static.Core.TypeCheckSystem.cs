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
		[Cpp2IlInjected.Address(RVA = "0xC40E00", Offset = "0xC3F800", VA = "0x180C40E00")]
		internal DirectedType(TType type, IOKind ioKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x469A8C0", Offset = "0x46992C0", VA = "0x18469A8C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class YUQPQJHUHSL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3C06D70", Offset = "0x3C05770", VA = "0x183C06D70")]
		public static DirectedType<TType> New<TType>(TType type, IOKind ioKind)
		{
			return default(DirectedType<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3C06BC0", Offset = "0x3C055C0", VA = "0x183C06BC0")]
		public static (c, IOKind) HZXAFBGPRTO<c>([In] this DirectedType<c> self)
		{
			return default((c, IOKind));
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C069B0", Offset = "0x3C053B0", VA = "0x183C069B0")]
		public static void HMUPOGLQWOR<d>([In] this DirectedType<d> self, [Out] d a, [Out] IOKind b)
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
		[Cpp2IlInjected.Address(RVA = "0x4CD21E0", Offset = "0x4CD0BE0", VA = "0x184CD21E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class YPXPDILZYQT
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C05DE0", Offset = "0x3C047E0", VA = "0x183C05DE0")]
		public static (TypeParameterId<a>, TypeParameterId<a>) HZXAFBGPRTO<a>([In] this EquivalentTypeParameters<a> self)
		{
			return default((TypeParameterId<a>, TypeParameterId<a>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3C05B60", Offset = "0x3C04560", VA = "0x183C05B60")]
		public static void HMUPOGLQWOR<b>([In] this EquivalentTypeParameters<b> self, [Out] TypeParameterId<b> a, [Out] TypeParameterId<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface XEEZTYVIMMB<a, b, c, d, e, f, g, h, i, j>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates KHDKRGMVVFQ(j a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		e ZLTNZXKNEFC(j a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DirectedType<e> GWITVDCEGCB(j a, [In] DirectedType<e> lhs, [In] DirectedType<e> rhs);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int MTRKPBWDFUL(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int OGIBVPOBAXU(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		f CIVTBGFUGMT(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int VNQEUDCRPRF(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		g ZRGRCUDFXQI(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IEnumerable<TypeParameter<e>> KIAGMZXGZSB(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<EquivalentTypeParameters<h>> FPIZHTWIXDO(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		e FGPFZVMNFVG(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int SLGDHHVXIKR(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		g ZKYCOQNSLPM(j a, i b, f c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "13")]
		h BBYHWKIMVRF(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "14")]
		e TIBDIUPHDKD(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "15")]
		int NWTBJNOSTIB(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "16")]
		f ALPMEBUXBFQ(j a, i b, g c, int d);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		h YFQOEXNCXTM(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool VDPWUEKZVEB(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		e XFLULPFSGZZ(j a, e b, IEnumerable<e> c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void LCMXFYMBKGR(j a, e b, Action<e> c, Action<e> d, Action<e> e, Action<e> f);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		e BLRVNQUOAAV(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		string AFFHTVKISRQ(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "23")]
		d HYKJZWCTWRG(j a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Result<c[], KZUDSDVUTEC> FGLPMLTPLNR(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "25")]
		a BWJBUJRDYPC(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "26")]
		a HSPNSWTXZML(j a, d b, a c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "27")]
		a RWVISNLAVIJ(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void MYTFQRJGJIH(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool KFMWRWLQJGM(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool MTQWYPXVMME(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "31")]
		a CZIFXSCYIJB(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "32")]
		b BOCNEAJEPDY(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		b ZDZYPDXSORZ(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		a IUMMNJRJHUR(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		b LYOQEKJWUBX(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		b AOZYBSPZKSE(j a, d b, a c);
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : XEEZTYVIMMB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160")]
		public static TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> New()
		{
			return default(TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TypeCheckSys
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private static class HBTILSUWDVD<b, c, d, e, f, g, h, i, j, k, l> where l : XEEZTYVIMMB<b, c, d, e, f, g, h, i, j, k>
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private sealed class ENOKTQQUSBM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public k XQVYPEOBNLV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public readonly l JKCUUNJHGIZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public e XWNGRUSVXOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public j GXIOPPFFNOJ;

				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public PerfScopeDelegates RJBAKVAGEKU
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x46CFBD0", Offset = "0x46CE5D0", VA = "0x1846CFBD0")]
					get
					{
						return default(PerfScopeDelegates);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x46D11E0", Offset = "0x46CFBE0", VA = "0x1846D11E0")]
				private ENOKTQQUSBM(k a, l b, e c, j d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x46CE370", Offset = "0x46CCD70", VA = "0x1846CE370")]
				public static ENOKTQQUSBM New(k root, l deps, e unificationSys, j graph)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x46D0D70", Offset = "0x46CF770", VA = "0x1846D0D70")]
				public f ZLTNZXKNEFC()
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x46CBAA0", Offset = "0x46CA4A0", VA = "0x1846CBAA0")]
				public DirectedType<f> GWITVDCEGCB(DirectedType<f> a, DirectedType<f> b)
				{
					return default(DirectedType<f>);
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x46CDB70", Offset = "0x46CC570", VA = "0x1846CDB70")]
				public int MTRKPBWDFUL(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x46CE440", Offset = "0x46CCE40", VA = "0x1846CE440")]
				public int OGIBVPOBAXU(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x46CB050", Offset = "0x46C9A50", VA = "0x1846CB050")]
				public g CIVTBGFUGMT(i a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x46CF2A0", Offset = "0x46CDCA0", VA = "0x1846CF2A0")]
				public int VNQEUDCRPRF(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x46D0DB0", Offset = "0x46CF7B0", VA = "0x1846D0DB0")]
				public h ZRGRCUDFXQI(i a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x46CC9E0", Offset = "0x46CB3E0", VA = "0x1846CC9E0")]
				public IEnumerable<TypeParameter<f>> KIAGMZXGZSB(i a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x46CB7D0", Offset = "0x46CA1D0", VA = "0x1846CB7D0")]
				public IEnumerable<EquivalentTypeParameters<i>> FPIZHTWIXDO([In] i node)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x46CB0C0", Offset = "0x46C9AC0", VA = "0x1846CB0C0")]
				public f FGPFZVMNFVG(g a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x46CBEC0", Offset = "0x46CA8C0", VA = "0x1846CBEC0")]
				public int IACYXYUBEHA(g a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x46D06F0", Offset = "0x46CF0F0", VA = "0x1846D06F0")]
				public h ZKYCOQNSLPM(g a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x46C9E40", Offset = "0x46C8840", VA = "0x1846C9E40")]
				public i BBYHWKIMVRF(g a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x46CEC00", Offset = "0x46CD600", VA = "0x1846CEC00")]
				public f TIBDIUPHDKD(h a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x46CF990", Offset = "0x46CE390", VA = "0x1846CF990")]
				public int VYXECSLXCJE(h a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x46C9630", Offset = "0x46C8030", VA = "0x1846C9630")]
				public g ALPMEBUXBFQ(h a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x46D02E0", Offset = "0x46CECE0", VA = "0x1846D02E0")]
				public i YFQOEXNCXTM(h a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x46CEFE0", Offset = "0x46CD9E0", VA = "0x1846CEFE0")]
				public bool VDPWUEKZVEB(f a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x46CFF00", Offset = "0x46CE900", VA = "0x1846CFF00")]
				public f XFLULPFSGZZ(f a, IEnumerable<f> b)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x46CCD80", Offset = "0x46CB780", VA = "0x1846CCD80")]
				public void LCMXFYMBKGR(f a, Action<f> b, Action<f> c, Action<f> d, Action<f> e)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x46C9E90", Offset = "0x46C8890", VA = "0x1846C9E90")]
				public f BLRVNQUOAAV(f a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x46C9230", Offset = "0x46C7C30", VA = "0x1846C9230")]
				public string AFFHTVKISRQ(f a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x46CA950", Offset = "0x46C9350", VA = "0x1846CA950")]
				public b BWJBUJRDYPC()
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x46CBB00", Offset = "0x46CA500", VA = "0x1846CBB00")]
				public b HSPNSWTXZML(b a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x46CEBB0", Offset = "0x46CD5B0", VA = "0x1846CEBB0")]
				public b RWVISNLAVIJ(b a, b b)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x46CDBB0", Offset = "0x46CC5B0", VA = "0x1846CDBB0")]
				public void MYTFQRJGJIH(b a, b b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x46CD7E0", Offset = "0x46CC1E0", VA = "0x1846CD7E0")]
				public bool MTQWYPXVMME(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x46CC640", Offset = "0x46CB040", VA = "0x1846CC640")]
				public bool KFMWRWLQJGM(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x46CA570", Offset = "0x46C8F70", VA = "0x1846CA570")]
				public b BOVTTXEMYLW(c a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x46CA520", Offset = "0x46C8F20", VA = "0x1846CA520")]
				public c BOCNEAJEPDY(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x46D0330", Offset = "0x46CED30", VA = "0x1846D0330")]
				public c ZDZYPDXSORZ(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x46CC260", Offset = "0x46CAC60", VA = "0x1846CC260")]
				public b IUMMNJRJHUR(d a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x46CD0B0", Offset = "0x46CBAB0", VA = "0x1846CD0B0")]
				public c LYOQEKJWUBX(d a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x46C9A50", Offset = "0x46C8450", VA = "0x1846C9A50")]
				public c AOZYBSPZKSE(b a)
				{
					return (c)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class GXJZCZDFVCM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public ENOKTQQUSBM VQMISCAQNCJ;

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
				public GXJZCZDFVCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x4E4E180", Offset = "0x4E4CB80", VA = "0x184E4E180")]
				internal b PGOPAAXKHLD(d a)
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class KSOSAENBDBW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public ENOKTQQUSBM VQMISCAQNCJ;

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
				public KSOSAENBDBW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x52E5130", Offset = "0x52E3B30", VA = "0x1852E5130")]
				internal int LGKSAAKYKFD(ENOKTQQUSBM a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x52E50D0", Offset = "0x52E3AD0", VA = "0x1852E50D0")]
				internal g LGFLCTRBATU(ENOKTQQUSBM a, i b, int c)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x52E4E30", Offset = "0x52E3830", VA = "0x1852E4E30")]
				internal int LFUXIGDGHXC(ENOKTQQUSBM a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x52E4C60", Offset = "0x52E3660", VA = "0x1852E4C60")]
				internal h LFPQKZJIYLT(ENOKTQQUSBM a, i b, int c)
				{
					return (h)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class FVTRMYHTPKV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public ENOKTQQUSBM VQMISCAQNCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public i CBWCVBMBGYT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public Dictionary<b, TypeParameterId<i>> FDTVRLURPYO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public Dictionary<TypeParameterId<i>, b> PNJFNHWWYES;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public List<KeyValuePair<b, DirectedType<f>>> QBENOGKUSTF;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
				public FVTRMYHTPKV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x4D0C700", Offset = "0x4D0B100", VA = "0x184D0C700")]
				internal (string, b) GHRENJIJHCZ(TypeParameter<f> a)
				{
					return default((string, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class LWREDTRENBY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public ENOKTQQUSBM VQMISCAQNCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public List<KeyValuePair<b, DirectedType<f>>> QBENOGKUSTF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public IOKind IGPPCLSMWNP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public List<b> KWNMZQNSVGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public IReadOnlyDictionary<string, b> PNJFNHWWYES;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
				public LWREDTRENBY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x53A96B0", Offset = "0x53A80B0", VA = "0x1853A96B0")]
				internal void WBVKUTKQTZK(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x53A9F20", Offset = "0x53A8920", VA = "0x1853A9F20")]
				internal void WCARSAEODKT(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x53AA600", Offset = "0x53A9000", VA = "0x1853AA600")]
				internal void WCFYPGYLMWC(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x53AAFC0", Offset = "0x53A99C0", VA = "0x1853AAFC0")]
				internal void WCLFMNSIWHL(f a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4EBDB50", Offset = "0x4EBC550", VA = "0x184EBDB50")]
			private static LogString WYPVGEYJCVS([CallerMemberName] string name = "")
			{
				return default(LogString);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4EB2A30", Offset = "0x4EB1430", VA = "0x184EB2A30")]
			public static Dictionary<i, List<TypeParameter<f>>> InferTypes(k root, l deps, j graph, IEnumerable<i> nodes)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4EAF9E0", Offset = "0x4EAE3E0", VA = "0x184EAF9E0")]
			private static (Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>) GenerateConstraintsForNodes(IEnumerable<i> nodes, ENOKTQQUSBM arg)
			{
				return default((Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x4EB4B10", Offset = "0x4EB3510", VA = "0x184EB4B10")]
			private static void KAPUSQPOOXZ(i a, Dictionary<g, b> b, Dictionary<h, b> c, Dictionary<b, TypeParameterId<i>> d, Dictionary<TypeParameterId<i>, b> e, List<KeyValuePair<b, DirectedType<f>>> f, Stack<i> g, List<EquivalentTypeParameters<i>> h, ENOKTQQUSBM i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x4EB9000", Offset = "0x4EB7A00", VA = "0x184EB9000")]
			private static Dictionary<string, b> NGOPDZXFHST(i a, Dictionary<b, TypeParameterId<i>> b, Dictionary<TypeParameterId<i>, b> c, List<KeyValuePair<b, DirectedType<f>>> d, ENOKTQQUSBM e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x3636AB0", Offset = "0x36354B0", VA = "0x183636AB0")]
			private static (a, b)[] ZZTZDGHSEGO<a>(i a, Func<ENOKTQQUSBM, i, int> b, Func<ENOKTQQUSBM, i, int, a> c, Func<ENOKTQQUSBM, a, f> d, Dictionary<a, b> e, ENOKTQQUSBM f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4EBAEB0", Offset = "0x4EB98B0", VA = "0x184EBAEB0")]
			private static (b, b) URKQHQJAKIF((h Output, b Id)[] outputs, List<KeyValuePair<b, DirectedType<f>>> a, Dictionary<string, b> b, Stack<i> c, ENOKTQQUSBM d)
			{
				return default((b, b));
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x4EACAB0", Offset = "0x4EAB4B0", VA = "0x184EACAB0")]
			private static void AFWGHSZMDFK((g PortKey, b Id)[] inputs, b a, b b, List<KeyValuePair<b, DirectedType<f>>> c, Dictionary<h, b> d, Dictionary<string, b> e, Stack<i> f, ENOKTQQUSBM g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x4EBE9B0", Offset = "0x4EBD3B0", VA = "0x184EBE9B0")]
			private static b XIRCMEDAMSM(g a, List<KeyValuePair<b, DirectedType<f>>> b, Dictionary<h, b> c, Stack<i> d, ENOKTQQUSBM e)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x4EAE970", Offset = "0x4EAD370", VA = "0x184EAE970")]
			private static b FZHXHYUXLJW([In] f type, IOKind a, List<KeyValuePair<b, DirectedType<f>>> b, IReadOnlyDictionary<string, b> c, ENOKTQQUSBM d)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x4EB0220", Offset = "0x4EAEC20", VA = "0x184EB0220")]
			private static Dictionary<i, List<TypeParameter<f>>> GetTypeParameterAssignments(d[] substitutions, Dictionary<b, TypeParameterId<i>> idToTypeParameter, IEnumerable<KeyValuePair<b, DirectedType<f>>> idToType, ENOKTQQUSBM arg)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x4EB1F40", Offset = "0x4EB0940", VA = "0x184EB1F40")]
			private static Dictionary<i, List<TypeParameter<f>>> HNBECVMZQAS(Dictionary<b, TypeParameterId<i>> a, ENOKTQQUSBM b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4EBF540", Offset = "0x4EBDF40", VA = "0x184EBF540")]
			private static void YBTLLMXDQLI([In] i node, Stack<i> a, List<EquivalentTypeParameters<i>> b, ENOKTQQUSBM c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4EB3C20", Offset = "0x4EB2620", VA = "0x184EB3C20")]
			private static void JMQYSSHRAZM(Dictionary<TypeParameterId<i>, b> a, List<EquivalentTypeParameters<i>> b, ENOKTQQUSBM c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4EB7E10", Offset = "0x4EB6810", VA = "0x184EB7E10")]
			private static Dictionary<b, f> MPEGINSXSMB(Dictionary<b, d> a, IEnumerable<KeyValuePair<b, DirectedType<f>>> b, ENOKTQQUSBM c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4EBA8E0", Offset = "0x4EB92E0", VA = "0x184EBA8E0")]
			private static Option<f> SCLKMNGMZJI(c a, Dictionary<b, f> b, Dictionary<b, f> c, ENOKTQQUSBM d)
			{
				return default(Option<f>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4EAE130", Offset = "0x4EACB30", VA = "0x184EAE130")]
			private static c EZAVZPUYPVU(c a, ENOKTQQUSBM b)
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D660", Offset = "0x3A9C060", VA = "0x183A9D660")]
		public static Dictionary<TNode, List<TypeParameter<TType>>> InferTypes<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> self, TRoot root, TGraph graph, IEnumerable<TNode> nodes) where TDeps : XEEZTYVIMMB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct TypeParameter<TType> : IEquatable<TypeParameter<TType>>, BYEJVEWXCEM<TypeParameter<TType>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly TType Constraint;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61AE4B0", Offset = "0x61ACEB0", VA = "0x1861AE4B0")]
		internal TypeParameter(string name, [In] TType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x61ADFF0", Offset = "0x61AC9F0", VA = "0x1861ADFF0")]
		public bool QGNBNUHOAWV([In] TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61ADD20", Offset = "0x61AC720", VA = "0x1861ADD20", Slot = "4")]
		public bool Equals(TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61ADCE0", Offset = "0x61AC6E0", VA = "0x1861ADCE0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61AD3E0", Offset = "0x61ABDE0", VA = "0x1861AD3E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61AE470", Offset = "0x61ACE70", VA = "0x1861AE470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61ADFA0", Offset = "0x61AC9A0", VA = "0x1861ADFA0", Slot = "5")]
		private bool IZYYXULFHBT([In] TypeParameter<TType> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MHQUJPVMUYC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x378D1E0", Offset = "0x378BBE0", VA = "0x18378D1E0")]
		public static TypeParameter<TType> New<TType>(string name, TType constraint)
		{
			return default(TypeParameter<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x378D0C0", Offset = "0x378BAC0", VA = "0x18378D0C0")]
		public static (string, a) HZXAFBGPRTO<a>([In] this TypeParameter<a> self)
		{
			return default((string, a));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct TypeParameterId<TNode> : IEquatable<TypeParameterId<TNode>>, BYEJVEWXCEM<TypeParameterId<TNode>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly TNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly string Name;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xE2A700", Offset = "0xE29100", VA = "0x180E2A700")]
		internal TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61AD660", Offset = "0x61AC060", VA = "0x1861AD660")]
		public bool QGNBNUHOAWV([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61AD390", Offset = "0x61ABD90", VA = "0x1861AD390", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61AD350", Offset = "0x61ABD50", VA = "0x1861AD350", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61AD3E0", Offset = "0x61ABDE0", VA = "0x1861AD3E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61ADAE0", Offset = "0x61AC4E0", VA = "0x1861ADAE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x61AD1F0", Offset = "0x61ABBF0", VA = "0x1861AD1F0", Slot = "5")]
		private bool CLAYTIGEVUS([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class XAKCXGGQLWX
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3BE8A00", Offset = "0x3BE7400", VA = "0x183BE8A00")]
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
