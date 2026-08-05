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
		[Cpp2IlInjected.Address(RVA = "0xBF6FA0", Offset = "0xBF63A0", VA = "0x180BF6FA0")]
		internal DirectedType(TType type, IOKind ioKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4734310", Offset = "0x4733710", VA = "0x184734310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class MRTLNQRTEZU
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x377E7F0", Offset = "0x377DBF0", VA = "0x18377E7F0")]
		public static DirectedType<TType> New<TType>(TType type, IOKind ioKind)
		{
			return default(DirectedType<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x377E390", Offset = "0x377D790", VA = "0x18377E390")]
		public static (c, IOKind) CKNONEHQZMX<c>([In] this DirectedType<c> self)
		{
			return default((c, IOKind));
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x377E600", Offset = "0x377DA00", VA = "0x18377E600")]
		public static void HYZXLOOBRHM<d>([In] this DirectedType<d> self, [Out] d a, [Out] IOKind b)
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
		[Cpp2IlInjected.Address(RVA = "0x4D30D10", Offset = "0x4D30110", VA = "0x184D30D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class CAWDPEMBDLU
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x341B2D0", Offset = "0x341A6D0", VA = "0x18341B2D0")]
		public static (TypeParameterId<a>, TypeParameterId<a>) CKNONEHQZMX<a>([In] this EquivalentTypeParameters<a> self)
		{
			return default((TypeParameterId<a>, TypeParameterId<a>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x341B5E0", Offset = "0x341A9E0", VA = "0x18341B5E0")]
		public static void HYZXLOOBRHM<b>([In] this EquivalentTypeParameters<b> self, [Out] TypeParameterId<b> a, [Out] TypeParameterId<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface PEODMYHLBAQ<a, b, c, d, e, f, g, h, i, j>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates DEAGYPXFQEX(j a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		e GOPUVKPNITP(j a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DirectedType<e> SHCMCVWZEXI(j a, [In] DirectedType<e> lhs, [In] DirectedType<e> rhs);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int YDGTKQLQSDC(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int TSCHYAIXQJP(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		f WYDHGQHTDHQ(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int YPYBLOOBUBE(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		g RCKNXBMOWQH(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IEnumerable<TypeParameter<e>> OAARVVVTWBM(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<EquivalentTypeParameters<h>> RMRSJZZTNUP(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		e BOYOJRVINFR(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int UXSVZBLNFZI(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		g EMOHTITPITR(j a, i b, f c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "13")]
		h BYIQJUJEFJM(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "14")]
		e QKRLWYPWMBU(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "15")]
		int NCRNECCGKDI(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "16")]
		f QSUXMMNYNID(j a, i b, g c, int d);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		h JYNDBJUUTNL(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool RKKFCBNDAAM(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		e WWMYXWPDBQK(j a, e b, IEnumerable<e> c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void AOOCBAMTNIE(j a, e b, Action<e> c, Action<e> d, Action<e> e, Action<e> f);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		e TWDKUVKLXOM(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		string PTNLZLXPTEN(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "23")]
		d APJQADDYDVL(j a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Result<c[], GKLIEWNFSHL> CPFPGEBKVUC(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "25")]
		a ORRMIDWZLKP(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "26")]
		a CYOQVHOIZWI(j a, d b, a c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "27")]
		a UIADUJRMYNG(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void JRTZIYHJWZW(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool THAHLXBYYKB(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool DXGIAAZGRXN(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "31")]
		a SNDPYCFNGTU(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "32")]
		b KLRMROGXBZH(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		b ZVMRFAXGRKE(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		a YFEWNBVYYMA(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		b BBIPOPBROEK(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		b QVHXAYOSCVD(j a, d b, a c);
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : PEODMYHLBAQ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
		public static TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> New()
		{
			return default(TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TypeCheckSys
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private static class ZDDHEEPRPLI<b, c, d, e, f, g, h, i, j, k, l> where l : PEODMYHLBAQ<b, c, d, e, f, g, h, i, j, k>
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private sealed class GKXFOQCFRUF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public k JNBRJWHHBWC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public readonly l IXIUPKGVEEA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public e XQGTAHOJXBV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public j BHZMTSVPTVQ;

				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public PerfScopeDelegates FCYLQUNXMOL
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x4ECC570", Offset = "0x4ECB970", VA = "0x184ECC570")]
					get
					{
						return default(PerfScopeDelegates);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x4ED1CA0", Offset = "0x4ED10A0", VA = "0x184ED1CA0")]
				private GKXFOQCFRUF(k a, l b, e c, j d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x4ECC970", Offset = "0x4ECBD70", VA = "0x184ECC970")]
				public static GKXFOQCFRUF New(k root, l deps, e unificationSys, j graph)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x4ECB610", Offset = "0x4ECAA10", VA = "0x184ECB610")]
				public f GOPUVKPNITP()
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x4ECECB0", Offset = "0x4ECE0B0", VA = "0x184ECECB0")]
				public DirectedType<f> SHCMCVWZEXI(DirectedType<f> a, DirectedType<f> b)
				{
					return default(DirectedType<f>);
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x4ED0840", Offset = "0x4ECFC40", VA = "0x184ED0840")]
				public int YDGTKQLQSDC(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4ECF2F0", Offset = "0x4ECE6F0", VA = "0x184ECF2F0")]
				public int TSCHYAIXQJP(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x4ED0430", Offset = "0x4ECF830", VA = "0x184ED0430")]
				public g WYDHGQHTDHQ(i a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x4ED0F60", Offset = "0x4ED0360", VA = "0x184ED0F60")]
				public int YPYBLOOBUBE(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x4ECE2C0", Offset = "0x4ECD6C0", VA = "0x184ECE2C0")]
				public h RCKNXBMOWQH(i a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x4ECCA40", Offset = "0x4ECBE40", VA = "0x184ECCA40")]
				public IEnumerable<TypeParameter<f>> OAARVVVTWBM(i a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x4ECE5E0", Offset = "0x4ECD9E0", VA = "0x184ECE5E0")]
				public IEnumerable<EquivalentTypeParameters<i>> RMRSJZZTNUP([In] i node)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x4ECA6B0", Offset = "0x4EC9AB0", VA = "0x184ECA6B0")]
				public f BOYOJRVINFR(g a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x4ECE930", Offset = "0x4ECDD30", VA = "0x184ECE930")]
				public int RRMIDMJFPGT(g a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x4ECB1F0", Offset = "0x4ECA5F0", VA = "0x184ECB1F0")]
				public h EMOHTITPITR(g a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x4ECAA80", Offset = "0x4EC9E80", VA = "0x184ECAA80")]
				public i BYIQJUJEFJM(g a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x4ECD380", Offset = "0x4ECC780", VA = "0x184ECD380")]
				public f QKRLWYPWMBU(h a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x4ED00C0", Offset = "0x4ECF4C0", VA = "0x184ED00C0")]
				public int VLIYLJZGYPN(h a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x4ECD740", Offset = "0x4ECCB40", VA = "0x184ECD740")]
				public g QSUXMMNYNID(h a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x4ECBFA0", Offset = "0x4ECB3A0", VA = "0x184ECBFA0")]
				public i JYNDBJUUTNL(h a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x4ECE5A0", Offset = "0x4ECD9A0", VA = "0x184ECE5A0")]
				public bool RKKFCBNDAAM(f a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4ED03F0", Offset = "0x4ECF7F0", VA = "0x184ED03F0")]
				public f WWMYXWPDBQK(f a, IEnumerable<f> b)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x4EC9F30", Offset = "0x4EC9330", VA = "0x184EC9F30")]
				public void AOOCBAMTNIE(f a, Action<f> b, Action<f> c, Action<f> d, Action<f> e)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x4ECF930", Offset = "0x4ECED30", VA = "0x184ECF930")]
				public f TWDKUVKLXOM(f a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x4ECD0D0", Offset = "0x4ECC4D0", VA = "0x184ECD0D0")]
				public string PTNLZLXPTEN(f a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x4ECD090", Offset = "0x4ECC490", VA = "0x184ECD090")]
				public b ORRMIDWZLKP()
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x4ECAAD0", Offset = "0x4EC9ED0", VA = "0x184ECAAD0")]
				public b CYOQVHOIZWI(b a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4ECFD40", Offset = "0x4ECF140", VA = "0x184ECFD40")]
				public b UIADUJRMYNG(b a, b b)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x4ECBBE0", Offset = "0x4ECAFE0", VA = "0x184ECBBE0")]
				public void JRTZIYHJWZW(b a, b b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x4ECB1B0", Offset = "0x4ECA5B0", VA = "0x184ECB1B0")]
				public bool DXGIAAZGRXN(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x4ECF2B0", Offset = "0x4ECE6B0", VA = "0x184ECF2B0")]
				public bool THAHLXBYYKB(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x4ED1640", Offset = "0x4ED0A40", VA = "0x184ED1640")]
				public b YYSFPYPUXHD(c a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x4ECC350", Offset = "0x4ECB750", VA = "0x184ECC350")]
				public c KLRMROGXBZH(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x4ED1680", Offset = "0x4ED0A80", VA = "0x184ED1680")]
				public c ZVMRFAXGRKE(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x4ED0BB0", Offset = "0x4ECFFB0", VA = "0x184ED0BB0")]
				public b YFEWNBVYYMA(d a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x4ECA300", Offset = "0x4EC9700", VA = "0x184ECA300")]
				public c BBIPOPBROEK(d a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x4ECDB60", Offset = "0x4ECCF60", VA = "0x184ECDB60")]
				public c QVHXAYOSCVD(b a)
				{
					return (c)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class MWLHREALRTF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public GKXFOQCFRUF FAWNPPLTYNE;

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public MWLHREALRTF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x57DE8D0", Offset = "0x57DDCD0", VA = "0x1857DE8D0")]
				internal b KOBCWPEZRCW(d a)
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class JLSEUHBSZCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public GKXFOQCFRUF FAWNPPLTYNE;

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public JLSEUHBSZCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x510A210", Offset = "0x5109610", VA = "0x18510A210")]
				internal int HOWGWTGCRVG(GKXFOQCFRUF a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x510A480", Offset = "0x5109880", VA = "0x18510A480")]
				internal g HPBNUAAABGP(GKXFOQCFRUF a, i b, int c)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x510A4E0", Offset = "0x51098E0", VA = "0x18510A4E0")]
				internal int HPMBONNUUDH(GKXFOQCFRUF a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x510A050", Offset = "0x5109450", VA = "0x18510A050")]
				internal h HOBFHSENGBW(GKXFOQCFRUF a, i b, int c)
				{
					return (h)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class OBPSGXVZRRC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public GKXFOQCFRUF FAWNPPLTYNE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public i QMXJVPYWNHQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public Dictionary<b, TypeParameterId<i>> SIFSEYXTZPX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public Dictionary<TypeParameterId<i>, b> XXHSPDJTHMZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public List<KeyValuePair<b, DirectedType<f>>> PTELDLUDCGS;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OBPSGXVZRRC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5981F70", Offset = "0x5981370", VA = "0x185981F70")]
				internal (string, b) FDQPVMFTGTK(TypeParameter<f> a)
				{
					return default((string, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class UMOAHPPLSQX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public GKXFOQCFRUF FAWNPPLTYNE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public List<KeyValuePair<b, DirectedType<f>>> PTELDLUDCGS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public IOKind NPKTNFWBUWM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public List<b> DJDTHPNSDCN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public IReadOnlyDictionary<string, b> XXHSPDJTHMZ;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public UMOAHPPLSQX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x612E310", Offset = "0x612D710", VA = "0x18612E310")]
				internal void GVXCKPTKFIB(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x612E100", Offset = "0x612D500", VA = "0x18612E100")]
				internal void GVRVNIZMVWS(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x612DA70", Offset = "0x612CE70", VA = "0x18612DA70")]
				internal void GVMOQCFPMLJ(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x612D4B0", Offset = "0x612C8B0", VA = "0x18612D4B0")]
				internal void GVHHSVLSDAA(f a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3EF3BD0", Offset = "0x3EF2FD0", VA = "0x183EF3BD0")]
			private static LogString HKUFAKIPXIH([CallerMemberName] string name = "")
			{
				return default(LogString);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3EF5520", Offset = "0x3EF4920", VA = "0x183EF5520")]
			public static Dictionary<i, List<TypeParameter<f>>> InferTypes(k root, l deps, j graph, IEnumerable<i> nodes)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3EF17C0", Offset = "0x3EF0BC0", VA = "0x183EF17C0")]
			private static (Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>) GenerateConstraintsForNodes(IEnumerable<i> nodes, GKXFOQCFRUF arg)
			{
				return default((Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9260", Offset = "0x3EF8660", VA = "0x183EF9260")]
			private static void VXBAZKBFTXE(i a, Dictionary<g, b> b, Dictionary<h, b> c, Dictionary<b, TypeParameterId<i>> d, Dictionary<TypeParameterId<i>, b> e, List<KeyValuePair<b, DirectedType<f>>> f, Stack<i> g, List<EquivalentTypeParameters<i>> h, GKXFOQCFRUF i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x3EF0A00", Offset = "0x3EEFE00", VA = "0x183EF0A00")]
			private static Dictionary<string, b> FVEMQEARMGW(i a, Dictionary<b, TypeParameterId<i>> b, Dictionary<TypeParameterId<i>, b> c, List<KeyValuePair<b, DirectedType<f>>> d, GKXFOQCFRUF e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x3003160", Offset = "0x3002560", VA = "0x183003160")]
			private static (a, b)[] DASADZZXIOZ<a>(i a, Func<GKXFOQCFRUF, i, int> b, Func<GKXFOQCFRUF, i, int, a> c, Func<GKXFOQCFRUF, a, f> d, Dictionary<a, b> e, GKXFOQCFRUF f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x3EFADE0", Offset = "0x3EFA1E0", VA = "0x183EFADE0")]
			private static (b, b) YKMQUYRVWIA((h Output, b Id)[] outputs, List<KeyValuePair<b, DirectedType<f>>> a, Dictionary<string, b> b, Stack<i> c, GKXFOQCFRUF d)
			{
				return default((b, b));
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x3EFD950", Offset = "0x3EFCD50", VA = "0x183EFD950")]
			private static void ZAKPUSOXHJV((g PortKey, b Id)[] inputs, b a, b b, List<KeyValuePair<b, DirectedType<f>>> c, Dictionary<h, b> d, Dictionary<string, b> e, Stack<i> f, GKXFOQCFRUF g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3EEF3C0", Offset = "0x3EEE7C0", VA = "0x183EEF3C0")]
			private static b DZNUBPPXJGD(g a, List<KeyValuePair<b, DirectedType<f>>> b, Dictionary<h, b> c, Stack<i> d, GKXFOQCFRUF e)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3EF42C0", Offset = "0x3EF36C0", VA = "0x183EF42C0")]
			private static b HXXZWUUDJGF([In] f type, IOKind a, List<KeyValuePair<b, DirectedType<f>>> b, IReadOnlyDictionary<string, b> c, GKXFOQCFRUF d)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3EF1FA0", Offset = "0x3EF13A0", VA = "0x183EF1FA0")]
			private static Dictionary<i, List<TypeParameter<f>>> GetTypeParameterAssignments(d[] substitutions, Dictionary<b, TypeParameterId<i>> idToTypeParameter, IEnumerable<KeyValuePair<b, DirectedType<f>>> idToType, GKXFOQCFRUF arg)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3EF6680", Offset = "0x3EF5A80", VA = "0x183EF6680")]
			private static Dictionary<i, List<TypeParameter<f>>> KQQCNSSTMUT(Dictionary<b, TypeParameterId<i>> a, GKXFOQCFRUF b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3EEBE50", Offset = "0x3EEB250", VA = "0x183EEBE50")]
			private static void BCFBCPOXCIN([In] i node, Stack<i> a, List<EquivalentTypeParameters<i>> b, GKXFOQCFRUF c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3EEF060", Offset = "0x3EEE460", VA = "0x183EEF060")]
			private static void CXBYZRNCIPR(Dictionary<TypeParameterId<i>, b> a, List<EquivalentTypeParameters<i>> b, GKXFOQCFRUF c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3EF86B0", Offset = "0x3EF7AB0", VA = "0x183EF86B0")]
			private static Dictionary<b, f> SWDRQMRMHHG(Dictionary<b, d> a, IEnumerable<KeyValuePair<b, DirectedType<f>>> b, GKXFOQCFRUF c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3EEDFB0", Offset = "0x3EED3B0", VA = "0x183EEDFB0")]
			private static Option<f> BVAKPPCYVHB(c a, Dictionary<b, f> b, Dictionary<b, f> c, GKXFOQCFRUF d)
			{
				return default(Option<f>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3EF53B0", Offset = "0x3EF47B0", VA = "0x183EF53B0")]
			private static c IRGFCJIRSOL(c a, GKXFOQCFRUF b)
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD7E0", Offset = "0x3ABCBE0", VA = "0x183ABD7E0")]
		public static Dictionary<TNode, List<TypeParameter<TType>>> InferTypes<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> self, TRoot root, TGraph graph, IEnumerable<TNode> nodes) where TDeps : PEODMYHLBAQ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct TypeParameter<TType> : IEquatable<TypeParameter<TType>>, XLJSAODWXND<TypeParameter<TType>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly TType Constraint;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60E8500", Offset = "0x60E7900", VA = "0x1860E8500")]
		internal TypeParameter(string name, [In] TType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60E8460", Offset = "0x60E7860", VA = "0x1860E8460")]
		public bool XFFAACZDUDS([In] TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60E7D90", Offset = "0x60E7190", VA = "0x1860E7D90", Slot = "4")]
		public bool Equals(TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60E7D50", Offset = "0x60E7150", VA = "0x1860E7D50", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60E7430", Offset = "0x60E6830", VA = "0x1860E7430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60E81A0", Offset = "0x60E75A0", VA = "0x1860E81A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60E8000", Offset = "0x60E7400", VA = "0x1860E8000", Slot = "5")]
		private bool SDZLMCEUGRW([In] TypeParameter<TType> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EKQVVUNCGEZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x355DA80", Offset = "0x355CE80", VA = "0x18355DA80")]
		public static TypeParameter<TType> New<TType>(string name, TType constraint)
		{
			return default(TypeParameter<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x355D950", Offset = "0x355CD50", VA = "0x18355D950")]
		public static (string, a) CKNONEHQZMX<a>([In] this TypeParameter<a> self)
		{
			return default((string, a));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct TypeParameterId<TNode> : IEquatable<TypeParameterId<TNode>>, XLJSAODWXND<TypeParameterId<TNode>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly TNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly string Name;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
		internal TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60E7B00", Offset = "0x60E6F00", VA = "0x1860E7B00")]
		public bool XFFAACZDUDS([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60E73E0", Offset = "0x60E67E0", VA = "0x1860E73E0", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60E73A0", Offset = "0x60E67A0", VA = "0x1860E73A0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60E7430", Offset = "0x60E6830", VA = "0x1860E7430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60E77F0", Offset = "0x60E6BF0", VA = "0x1860E77F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60E7830", Offset = "0x60E6C30", VA = "0x1860E7830", Slot = "5")]
		private bool VRAMIUBSINN([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class XFAWQCHLXVW
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C03190", Offset = "0x3C02590", VA = "0x183C03190")]
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
