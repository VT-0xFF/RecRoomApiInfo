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
		[Cpp2IlInjected.Address(RVA = "0xE190C0", Offset = "0xE17EC0", VA = "0x180E190C0")]
		internal DirectedType(TType type, IOKind ioKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4902310", Offset = "0x4901110", VA = "0x184902310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class YPPBQNEXXGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3EEEE10", Offset = "0x3EEDC10", VA = "0x183EEEE10")]
		public static DirectedType<TType> New<TType>(TType type, IOKind ioKind)
		{
			return default(DirectedType<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3EEEFF0", Offset = "0x3EEDDF0", VA = "0x183EEEFF0")]
		public static (c, IOKind) OGRMKKRTBAA<c>([In] this DirectedType<c> self)
		{
			return default((c, IOKind));
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF260", Offset = "0x3EEE060", VA = "0x183EEF260")]
		public static void ZCUPQIFTYKF<d>([In] this DirectedType<d> self, [Out] d a, [Out] IOKind b)
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
		[Cpp2IlInjected.Address(RVA = "0x4F1A310", Offset = "0x4F19110", VA = "0x184F1A310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class APFQVRKTPMT
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x32BEE40", Offset = "0x32BDC40", VA = "0x1832BEE40")]
		public static (TypeParameterId<a>, TypeParameterId<a>) OGRMKKRTBAA<a>([In] this EquivalentTypeParameters<a> self)
		{
			return default((TypeParameterId<a>, TypeParameterId<a>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x32BF140", Offset = "0x32BDF40", VA = "0x1832BF140")]
		public static void ZCUPQIFTYKF<b>([In] this EquivalentTypeParameters<b> self, [Out] TypeParameterId<b> a, [Out] TypeParameterId<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ASFTBVATWFT<a, b, c, d, e, f, g, h, i, j>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates SJAKQRURDSS(j a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		e MSQVIRENRHW(j a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DirectedType<e> REIZNVIEZBL(j a, [In] DirectedType<e> lhs, [In] DirectedType<e> rhs);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int GTYXEOOJHLZ(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int XHCSXOIOPMS(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		f QOAPIHRSQTB(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int WSXABWLXABN(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		g FHQOXDYTRCQ(j a, i b, h c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IEnumerable<TypeParameter<e>> NYRGAWBFLAR(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<EquivalentTypeParameters<h>> ZQGHXEJMPIQ(j a, i b, h c);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		e CJMXERWVXBK(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int NOCAWXQLDUN(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		g NWMLXQGPOOW(j a, i b, f c, int d);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "13")]
		h IVWNUZRIFCH(j a, i b, f c);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "14")]
		e RAIOKXWZFUT(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "15")]
		int OBLWTDHDMTT(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "16")]
		f LPYGRBSFIXU(j a, i b, g c, int d);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		h HIUFJMUFSLM(j a, i b, g c);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool JBBKQFITYSV(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		e IOOYHIJZMBN(j a, e b, IEnumerable<e> c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void NXHEBXVXMGF(j a, e b, Action<e> c, Action<e> d, Action<e> e, Action<e> f);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		e ZNWIUUKFHNL(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		string OLOMNDJWMDY(j a, e b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "23")]
		d IUAEMVPOMHG(j a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Result<c[], NLAHVKALZBM> ARJJIAQKDHR(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "25")]
		a TVBPLNEGIBK(j a, d b);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "26")]
		a KIMSVZLQOTN(j a, d b, a c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "27")]
		a VZLSCAHKLEV(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void MWLQHPRXSNF(j a, d b, a c, a d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool KGZEGRWQLKI(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool TUFBGLFZCTK(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "31")]
		a XJHLMHRRTMD(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "32")]
		b VWAQQCQOPXM(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		b ZFCHEFLSIAP(j a, d b, b c);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		a PFXOIXPLAWV(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		b ZIGTTDNEVNX(j a, d b, c c);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		b GYLPIHABRXK(j a, d b, a c);
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : ASFTBVATWFT<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40")]
		public static TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> New()
		{
			return default(TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TypeCheckSys
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private static class ZTMLEKGZJDL<b, c, d, e, f, g, h, i, j, k, l> where l : ASFTBVATWFT<b, c, d, e, f, g, h, i, j, k>
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private sealed class EPEMRAKLNIG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public k RDIQMDZZHYP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public readonly l XZYTPGYTANL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public e OLHFVTBVNHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public j BACDOJQIWWJ;

				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public PerfScopeDelegates GEPOEQHHGSY
				{
					[Cpp2IlInjected.Token(Token = "0x6000041")]
					[Cpp2IlInjected.Address(RVA = "0x494F090", Offset = "0x494DE90", VA = "0x18494F090")]
					get
					{
						return default(PerfScopeDelegates);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x4952260", Offset = "0x4951060", VA = "0x184952260")]
				private EPEMRAKLNIG(k a, l b, e c, j d)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x494E7D0", Offset = "0x494D5D0", VA = "0x18494E7D0")]
				public static EPEMRAKLNIG New(k root, l deps, e unificationSys, j graph)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x494D400", Offset = "0x494C200", VA = "0x18494D400")]
				public f MSQVIRENRHW()
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x494FAA0", Offset = "0x494E8A0", VA = "0x18494FAA0")]
				public DirectedType<f> REIZNVIEZBL(DirectedType<f> a, DirectedType<f> b)
				{
					return default(DirectedType<f>);
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x494B1C0", Offset = "0x4949FC0", VA = "0x18494B1C0")]
				public int GTYXEOOJHLZ(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4951290", Offset = "0x4950090", VA = "0x184951290")]
				public int XHCSXOIOPMS(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x494F0C0", Offset = "0x494DEC0", VA = "0x18494F0C0")]
				public g QOAPIHRSQTB(i a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x4950C30", Offset = "0x494FA30", VA = "0x184950C30")]
				public int WSXABWLXABN(i a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x494ADD0", Offset = "0x4949BD0", VA = "0x18494ADD0")]
				public h FHQOXDYTRCQ(i a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x494E0E0", Offset = "0x494CEE0", VA = "0x18494E0E0")]
				public IEnumerable<TypeParameter<f>> NYRGAWBFLAR(i a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x4951CD0", Offset = "0x4950AD0", VA = "0x184951CD0")]
				public IEnumerable<EquivalentTypeParameters<i>> ZQGHXEJMPIQ([In] i node)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x494AD80", Offset = "0x4949B80", VA = "0x18494AD80")]
				public f CJMXERWVXBK(g a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x494FE10", Offset = "0x494EC10", VA = "0x18494FE10")]
				public int SNPRBRULSAS(g a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x494D9E0", Offset = "0x494C7E0", VA = "0x18494D9E0")]
				public h NWMLXQGPOOW(g a, int b)
				{
					return (h)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x494BF60", Offset = "0x494AD60", VA = "0x18494BF60")]
				public i IVWNUZRIFCH(g a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x494F800", Offset = "0x494E600", VA = "0x18494F800")]
				public f RAIOKXWZFUT(h a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x494A9E0", Offset = "0x49497E0", VA = "0x18494A9E0")]
				public int CATNEWLDGIC(h a)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x494D380", Offset = "0x494C180", VA = "0x18494D380")]
				public g LPYGRBSFIXU(h a, int b)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x494B8B0", Offset = "0x494A6B0", VA = "0x18494B8B0")]
				public i HIUFJMUFSLM(h a)
				{
					return (i)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x494C560", Offset = "0x494B360", VA = "0x18494C560")]
				public bool JBBKQFITYSV(f a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x494BC60", Offset = "0x494AA60", VA = "0x18494BC60")]
				public f IOOYHIJZMBN(f a, IEnumerable<f> b)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x494DDE0", Offset = "0x494CBE0", VA = "0x18494DDE0")]
				public void NXHEBXVXMGF(f a, Action<f> b, Action<f> c, Action<f> d, Action<f> e)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x49519E0", Offset = "0x49507E0", VA = "0x1849519E0")]
				public f ZNWIUUKFHNL(f a)
				{
					return (f)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x494EAF0", Offset = "0x494D8F0", VA = "0x18494EAF0")]
				public string OLOMNDJWMDY(f a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x4950470", Offset = "0x494F270", VA = "0x184950470")]
				public b TVBPLNEGIBK()
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x494CFC0", Offset = "0x494BDC0", VA = "0x18494CFC0")]
				public b KIMSVZLQOTN(b a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4950BE0", Offset = "0x494F9E0", VA = "0x184950BE0")]
				public b VZLSCAHKLEV(b a, b b)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x494D9A0", Offset = "0x494C7A0", VA = "0x18494D9A0")]
				public void MWLQHPRXSNF(b a, b b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x494FE60", Offset = "0x494EC60", VA = "0x18494FE60")]
				public bool TUFBGLFZCTK(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x494C930", Offset = "0x494B730", VA = "0x18494C930")]
				public bool KGZEGRWQLKI(c a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x494C5A0", Offset = "0x494B3A0", VA = "0x18494C5A0")]
				public b JJILXFYTXSQ(c a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x49504B0", Offset = "0x494F2B0", VA = "0x1849504B0")]
				public c VWAQQCQOPXM(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x4951610", Offset = "0x4950410", VA = "0x184951610")]
				public c ZFCHEFLSIAP(c a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x494EE80", Offset = "0x494DC80", VA = "0x18494EE80")]
				public b PFXOIXPLAWV(d a)
				{
					return (b)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x4951650", Offset = "0x4950450", VA = "0x184951650")]
				public c ZIGTTDNEVNX(d a)
				{
					return (c)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x494B870", Offset = "0x494A670", VA = "0x18494B870")]
				public c GYLPIHABRXK(b a)
				{
					return (c)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class KUZIAGTACLK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public EPEMRAKLNIG NNEMGOJTQKR;

				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public KUZIAGTACLK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x53C7DF0", Offset = "0x53C6BF0", VA = "0x1853C7DF0")]
				internal b KPVYVQVNYVP(d a)
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class RYMNRJREOIY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public EPEMRAKLNIG NNEMGOJTQKR;

				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public RYMNRJREOIY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x5D7DB50", Offset = "0x5D7C950", VA = "0x185D7DB50")]
				internal int BXCYIKQDNKR(EPEMRAKLNIG a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x5D7D9A0", Offset = "0x5D7C7A0", VA = "0x185D7D9A0")]
				internal g BWXRLDWGDZI(EPEMRAKLNIG a, i b, int c)
				{
					return (g)null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x5D7D970", Offset = "0x5D7C770", VA = "0x185D7D970")]
				internal int BWNDQQILLCQ(EPEMRAKLNIG a, i b)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x5D7DDB0", Offset = "0x5D7CBB0", VA = "0x185D7DDB0")]
				internal h BXXZXLRSZEB(EPEMRAKLNIG a, i b, int c)
				{
					return (h)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class OPUURPABOAR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				public EPEMRAKLNIG NNEMGOJTQKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public i SMJSDUHDMSD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public Dictionary<b, TypeParameterId<i>> OLJJRIJTHHU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public Dictionary<TypeParameterId<i>, b> EMRVPYYNPQC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public List<KeyValuePair<b, DirectedType<f>>> LMCHDYPRFGH;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public OPUURPABOAR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5B5FA60", Offset = "0x5B5E860", VA = "0x185B5FA60")]
				internal (string, b) UNZRBIGCZBH(TypeParameter<f> a)
				{
					return default((string, b));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class IEWMQXGPNAW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public EPEMRAKLNIG NNEMGOJTQKR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public List<KeyValuePair<b, DirectedType<f>>> LMCHDYPRFGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public IOKind VLKNNXGMTQB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public List<b> WTSGFVXLGVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public IReadOnlyDictionary<string, b> EMRVPYYNPQC;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public IEWMQXGPNAW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x51DD920", Offset = "0x51DC720", VA = "0x1851DD920")]
				internal void VZSQSDXPKJC(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x51DE100", Offset = "0x51DCF00", VA = "0x1851DE100")]
				internal void VZXXPKRMTUL(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x51DE770", Offset = "0x51DD570", VA = "0x1851DE770")]
				internal void WADEMRLKDFU(f a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x51DEDD0", Offset = "0x51DDBD0", VA = "0x1851DEDD0")]
				internal void WAILJYFHMRD(f a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4178AD0", Offset = "0x41778D0", VA = "0x184178AD0")]
			private static LogString RMXSCHGBZNK([CallerMemberName] string name = "")
			{
				return default(LogString);
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x416DFC0", Offset = "0x416CDC0", VA = "0x18416DFC0")]
			public static Dictionary<i, List<TypeParameter<f>>> InferTypes(k root, l deps, j graph, IEnumerable<i> nodes)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x416A440", Offset = "0x4169240", VA = "0x18416A440")]
			private static (Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>) GenerateConstraintsForNodes(IEnumerable<i> nodes, EPEMRAKLNIG arg)
			{
				return default((Dictionary<b, TypeParameterId<i>>, List<KeyValuePair<b, DirectedType<f>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x4170070", Offset = "0x416EE70", VA = "0x184170070")]
			private static void LOPSKDTOTQP(i a, Dictionary<g, b> b, Dictionary<h, b> c, Dictionary<b, TypeParameterId<i>> d, Dictionary<TypeParameterId<i>, b> e, List<KeyValuePair<b, DirectedType<f>>> f, Stack<i> g, List<EquivalentTypeParameters<i>> h, EPEMRAKLNIG i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x4169CE0", Offset = "0x4168AE0", VA = "0x184169CE0")]
			private static Dictionary<string, b> GPNJXMUKCCT(i a, Dictionary<b, TypeParameterId<i>> b, Dictionary<TypeParameterId<i>, b> c, List<KeyValuePair<b, DirectedType<f>>> d, EPEMRAKLNIG e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x32C2DC0", Offset = "0x32C1BC0", VA = "0x1832C2DC0")]
			private static (a, b)[] EUDAPLQEUVE<a>(i a, Func<EPEMRAKLNIG, i, int> b, Func<EPEMRAKLNIG, i, int, a> c, Func<EPEMRAKLNIG, a, f> d, Dictionary<a, b> e, EPEMRAKLNIG f)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4172FB0", Offset = "0x4171DB0", VA = "0x184172FB0")]
			private static (b, b) QVLOIDRMLRL((h Output, b Id)[] outputs, List<KeyValuePair<b, DirectedType<f>>> a, Dictionary<string, b> b, Stack<i> c, EPEMRAKLNIG d)
			{
				return default((b, b));
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x41776F0", Offset = "0x41764F0", VA = "0x1841776F0")]
			private static void REBYVCMMJGU((g PortKey, b Id)[] inputs, b a, b b, List<KeyValuePair<b, DirectedType<f>>> c, Dictionary<h, b> d, Dictionary<string, b> e, Stack<i> f, EPEMRAKLNIG g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x417C850", Offset = "0x417B650", VA = "0x18417C850")]
			private static b YTZKLOVQXMA(g a, List<KeyValuePair<b, DirectedType<f>>> b, Dictionary<h, b> c, Stack<i> d, EPEMRAKLNIG e)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x416EA80", Offset = "0x416D880", VA = "0x18416EA80")]
			private static b JQOGXHSNYVG([In] f type, IOKind a, List<KeyValuePair<b, DirectedType<f>>> b, IReadOnlyDictionary<string, b> c, EPEMRAKLNIG d)
			{
				return (b)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x416CA00", Offset = "0x416B800", VA = "0x18416CA00")]
			private static Dictionary<i, List<TypeParameter<f>>> GetTypeParameterAssignments(d[] substitutions, Dictionary<b, TypeParameterId<i>> idToTypeParameter, IEnumerable<KeyValuePair<b, DirectedType<f>>> idToType, EPEMRAKLNIG arg)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x4178020", Offset = "0x4176E20", VA = "0x184178020")]
			private static Dictionary<i, List<TypeParameter<f>>> RJOYOTZZPXE(Dictionary<b, TypeParameterId<i>> a, EPEMRAKLNIG b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x41709B0", Offset = "0x416F7B0", VA = "0x1841709B0")]
			private static void NQHPKHHPQKG([In] i node, Stack<i> a, List<EquivalentTypeParameters<i>> b, EPEMRAKLNIG c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x41798E0", Offset = "0x41786E0", VA = "0x1841798E0")]
			private static void WPOGBWWVEZY(Dictionary<TypeParameterId<i>, b> a, List<EquivalentTypeParameters<i>> b, EPEMRAKLNIG c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x417BCA0", Offset = "0x417AAA0", VA = "0x18417BCA0")]
			private static Dictionary<b, f> YMGBRYINGYF(Dictionary<b, d> a, IEnumerable<KeyValuePair<b, DirectedType<f>>> b, EPEMRAKLNIG c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x41714F0", Offset = "0x41702F0", VA = "0x1841714F0")]
			private static Option<f> QEVDKSLKFLA(c a, Dictionary<b, f> b, Dictionary<b, f> c, EPEMRAKLNIG d)
			{
				return default(Option<f>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4178B10", Offset = "0x4177910", VA = "0x184178B10")]
			private static c SBDEIYBLCCC(c a, EPEMRAKLNIG b)
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F8D0", Offset = "0x3D4E6D0", VA = "0x183D4F8D0")]
		public static Dictionary<TNode, List<TypeParameter<TType>>> InferTypes<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this TypeCheckSys<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> self, TRoot root, TGraph graph, IEnumerable<TNode> nodes) where TDeps : ASFTBVATWFT<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct TypeParameter<TType> : IEquatable<TypeParameter<TType>>, IWKTMLXEDYU<TypeParameter<TType>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly TType Constraint;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x62A0070", Offset = "0x629EE70", VA = "0x1862A0070")]
		internal TypeParameter(string name, [In] TType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x629FE00", Offset = "0x629EC00", VA = "0x18629FE00")]
		public bool JECCPMWTKQN([In] TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x629F940", Offset = "0x629E740", VA = "0x18629F940", Slot = "4")]
		public bool Equals(TypeParameter<TType> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x629F900", Offset = "0x629E700", VA = "0x18629F900", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x629F020", Offset = "0x629DE20", VA = "0x18629F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62A0030", Offset = "0x629EE30", VA = "0x1862A0030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x629FEA0", Offset = "0x629ECA0", VA = "0x18629FEA0", Slot = "5")]
		private bool SDXWOTGTMDP([In] TypeParameter<TType> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZTRNOYITWHQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3F010C0", Offset = "0x3EFFEC0", VA = "0x183F010C0")]
		public static TypeParameter<TType> New<TType>(string name, TType constraint)
		{
			return default(TypeParameter<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F01280", Offset = "0x3F00080", VA = "0x183F01280")]
		public static (string, a) OGRMKKRTBAA<a>([In] this TypeParameter<a> self)
		{
			return default((string, a));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct TypeParameterId<TNode> : IEquatable<TypeParameterId<TNode>>, IWKTMLXEDYU<TypeParameterId<TNode>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly TNode Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly string Name;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
		internal TypeParameterId(TNode node, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x629F4E0", Offset = "0x629E2E0", VA = "0x18629F4E0")]
		public bool JECCPMWTKQN([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x629EFD0", Offset = "0x629DDD0", VA = "0x18629EFD0", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x629EF90", Offset = "0x629DD90", VA = "0x18629EF90", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x629F020", Offset = "0x629DE20", VA = "0x18629F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x629F6C0", Offset = "0x629E4C0", VA = "0x18629F6C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x629F700", Offset = "0x629E500", VA = "0x18629F700", Slot = "5")]
		private bool YUKLHOJBBOS([In] TypeParameterId<TNode> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class IEPWPEYOCID
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3925B50", Offset = "0x3924950", VA = "0x183925B50")]
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
