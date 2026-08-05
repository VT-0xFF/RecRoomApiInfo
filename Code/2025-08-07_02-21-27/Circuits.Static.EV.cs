using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.GraphSystem;
using Circuits.Static.Core.TreeSystem;
using Circuits.Static.Core.TypeCheckSystem;
using Circuits.Static.Core.TypeSystem;
using Circuits.Static.Core.TypeSystem.Factory;
using Circuits.Static.Core.UnificationSystem;
using Circuits.Static.Core.UnificationSystem.Reference;
using Circuits.Static.Core.UnificationSystem.Value;
using Circuits.Static.EV.Def;
using Circuits.Static.EV.Error;
using Circuits.Static.EV.Injection;
using Circuits.Static.EV.Lang;
using Circuits.Static.EV.Systems;
using Circuits.Static.Utilities;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Performance;

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
		[Cpp2IlInjected.Address(RVA = "0x2E04510", Offset = "0x2E03110", VA = "0x182E04510")]
		public NullableAttribute(byte P_0)
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
namespace Circuits.Static.EV
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct EVStaticStateSys<TRoot> where TRoot : DCZUNSBMGOL<TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		internal IdArray<TFITIOWUSRJ, ZHOBCASHLNG<TRoot>> _nodeDefs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		internal IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<TRoot>> _graphDefs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		internal Graphs _graphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal EVGraphs _evGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public TypeSys<TRoot> TypeSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public TypeCheckSys<TRoot> TypeCheckSys;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4CDADC0", Offset = "0x4CD99C0", VA = "0x184CDADC0")]
		private EVStaticStateSys(IdArray<TFITIOWUSRJ, ZHOBCASHLNG<TRoot>> nodeDefs, IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<TRoot>> graphDefs, [In] Graphs graphs, [In] EVGraphs evGraphs, [In] TypeSys<TRoot> typeSys, [In] TypeCheckSys<TRoot> typeCheckSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4CDAAB0", Offset = "0x4CD96B0", VA = "0x184CDAAB0")]
		public static EVStaticStateSys<TRoot> HVKYDMYBGAZ(IdArray<TFITIOWUSRJ, ZHOBCASHLNG<TRoot>> a, IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<TRoot>> b, [In] Graphs graphs, [In] EVGraphs evGraphs)
		{
			return default(EVStaticStateSys<TRoot>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class KNMBIGDCJFQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum TestConnectionResult
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			CanConnectDirectly,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			CanConvertAndConnect
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E100", Offset = "0x3C7CD00", VA = "0x183C7E100")]
		public static void Destroy<TRoot>(this EVStaticStateSys<TRoot> self) where TRoot : DCZUNSBMGOL<TRoot>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390")]
		public static IdArray<TFITIOWUSRJ, ZHOBCASHLNG<a>> XPHCJEBECBT<a>([In] this EVStaticStateSys<a> self) where a : DCZUNSBMGOL<a>
		{
			return default(IdArray<TFITIOWUSRJ, ZHOBCASHLNG<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C5C0", Offset = "0x3C7B1C0", VA = "0x183C7C5C0")]
		public static IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<b>> BVIWMHLAVXV<b>([In] this EVStaticStateSys<b> self) where b : DCZUNSBMGOL<b>
		{
			return default(IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<b>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE5F0", Offset = "0x2DCD1F0", VA = "0x182DCE5F0")]
		public static Graphs Graphs<TRoot>([In] this EVStaticStateSys<TRoot> self) where TRoot : DCZUNSBMGOL<TRoot>
		{
			return default(Graphs);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E060", Offset = "0x3C7CC60", VA = "0x183C7E060")]
		public static EVGraphs YWOKTRYWGNB<c>([In] this EVStaticStateSys<c> self) where c : DCZUNSBMGOL<c>
		{
			return default(EVGraphs);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE5F0", Offset = "0x2DCD1F0", VA = "0x182DCE5F0")]
		public static Graphs AJINMUHXABQ<d>(this EVStaticStateSys<d> a) where d : DCZUNSBMGOL<d>
		{
			return default(Graphs);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E060", Offset = "0x3C7CC60", VA = "0x183C7E060")]
		public static EVGraphs DONDVHDEJOT<e>(this EVStaticStateSys<e> a) where e : DCZUNSBMGOL<e>
		{
			return default(EVGraphs);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F990", Offset = "0x3C7E590", VA = "0x183C7F990")]
		public static ZHOBCASHLNG<f> HATGVQPVHRI<f>([In] this EVStaticStateSys<f> self, Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b) where f : DCZUNSBMGOL<f>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3C840D0", Offset = "0x3C82CD0", VA = "0x183C840D0")]
		public static (ZHOBCASHLNG<g>, Id32<TFITIOWUSRJ>) RWJFDQBXFHA<g>([In] this EVStaticStateSys<g> self, Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b) where g : DCZUNSBMGOL<g>
		{
			return default((ZHOBCASHLNG<g>, Id32<TFITIOWUSRJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C83B60", Offset = "0x3C82760", VA = "0x183C83B60")]
		public static OKCLJAZOSIM<h> PUOVJWXNADW<h>([In] this EVStaticStateSys<h> self, Id32<JQPVMRMCZNG> a) where h : DCZUNSBMGOL<h>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C7D700", Offset = "0x3C7C300", VA = "0x183C7D700")]
		public static bool DDNCLDMWJKB<m>([In] this EVStaticStateSys<m> self, m a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c) where m : DCZUNSBMGOL<m>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C826A0", Offset = "0x3C812A0", VA = "0x183C826A0")]
		public static Result<None, BDVKSMELLVG> LUVZGBLSLNT<n>([In] this EVStaticStateSys<n> self, Id32<JQPVMRMCZNG> a) where n : DCZUNSBMGOL<n>
		{
			return default(Result<None, BDVKSMELLVG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C82B80", Offset = "0x3C81780", VA = "0x183C82B80")]
		public static Result<None, YFKOPUBUZRQ> MPLZBEPUVEX<o>([In] this EVStaticStateSys<o> self, Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b) where o : DCZUNSBMGOL<o>
		{
			return default(Result<None, YFKOPUBUZRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E790", Offset = "0x3C7D390", VA = "0x183C7E790")]
		public static Result<None, YFKOPUBUZRQ> ETCFFUXIJUD<p>([In] this EVStaticStateSys<p> self, Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, int c) where p : DCZUNSBMGOL<p>
		{
			return default(Result<None, YFKOPUBUZRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C882F0", Offset = "0x3C86EF0", VA = "0x183C882F0")]
		public static Result<None, YFKOPUBUZRQ> ZVVJSTOFDWO<q>([In] this EVStaticStateSys<q> self, Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, int c) where q : DCZUNSBMGOL<q>
		{
			return default(Result<None, YFKOPUBUZRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C84320", Offset = "0x3C82F20", VA = "0x183C84320")]
		public static Result<None, YFKOPUBUZRQ> RYRUYHOBGIN<r>([In] this EVStaticStateSys<r> self, Id32<JQPVMRMCZNG> a, Id32<AWZVWRTEXTC> b) where r : DCZUNSBMGOL<r>
		{
			return default(Result<None, YFKOPUBUZRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3C84C80", Offset = "0x3C83880", VA = "0x183C84C80")]
		public static Result<None, YFKOPUBUZRQ> TOKRCAMUXLG<s>([In] this EVStaticStateSys<s> self, Id32<JQPVMRMCZNG> a, Id32<IEQQYWIVYHH> b) where s : DCZUNSBMGOL<s>
		{
			return default(Result<None, YFKOPUBUZRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DE80", Offset = "0x3C7CA80", VA = "0x183C7DE80")]
		public static Result<None, YFKOPUBUZRQ> DGYTBZGBCPC<t>([In] this EVStaticStateSys<t> self, Id32<JQPVMRMCZNG> a, Id32<IEQQYWIVYHH> b, Id32<AWZVWRTEXTC> c) where t : DCZUNSBMGOL<t>
		{
			return default(Result<None, YFKOPUBUZRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E360", Offset = "0x3C7CF60", VA = "0x183C7E360")]
		internal static Result<None, YFKOPUBUZRQ> EODZOXGFPOG<u>([In] this EVStaticStateSys<u> self, u a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c) where u : DCZUNSBMGOL<u>
		{
			return default(Result<None, YFKOPUBUZRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C86760", Offset = "0x3C85360", VA = "0x183C86760")]
		private static Result<TestConnectionResult, NJKZNHRVAZM> WSOYZLVQDEF<v>(this EVStaticStateSys<v> a, v b, Id32<JQPVMRMCZNG> c, Id32<IEQQYWIVYHH> d, Id32<AWZVWRTEXTC> e) where v : DCZUNSBMGOL<v>
		{
			return default(Result<TestConnectionResult, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F820", Offset = "0x3C7E420", VA = "0x183C7F820")]
		private static Id32<LWYTCPIHOQE> GRZWMALXGIY<w>(this EVStaticStateSys<w> a, Id32<JQPVMRMCZNG> b, [In] EVNode node) where w : DCZUNSBMGOL<w>
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3C81CA0", Offset = "0x3C808A0", VA = "0x183C81CA0")]
		private static void KUZMCPDMSFA<x>(this EVStaticStateSys<x> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c) where x : DCZUNSBMGOL<x>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C84570", Offset = "0x3C83170", VA = "0x183C84570")]
		internal static Id32<AWZVWRTEXTC> TBIBXCGRNBQ<y>(this EVStaticStateSys<y> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, [In] EVInput input) where y : DCZUNSBMGOL<y>
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C85DC0", Offset = "0x3C849C0", VA = "0x183C85DC0")]
		internal static Id32<IEQQYWIVYHH> VTWBOFTUVPZ<z>(this EVStaticStateSys<z> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, [In] EVOutput output) where z : DCZUNSBMGOL<z>
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C85240", Offset = "0x3C83E40", VA = "0x183C85240")]
		private static Id32<JQPVMRMCZNG> ULYLONDNCIQ<bc>(this EVStaticStateSys<bc> a, Id32<TZJZKVJCHTJ> b) where bc : DCZUNSBMGOL<bc>
		{
			return default(Id32<JQPVMRMCZNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C86FB0", Offset = "0x3C85BB0", VA = "0x183C86FB0")]
		private static Id32<JQPVMRMCZNG> WZMTKKSRLFS<bd>(this EVStaticStateSys<bd> a, Id32<JQPVMRMCZNG> b, Id32<TZJZKVJCHTJ> c) where bd : DCZUNSBMGOL<bd>
		{
			return default(Id32<JQPVMRMCZNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C570", Offset = "0x3C7B170", VA = "0x183C7C570")]
		private static void BKBECXUWMSC<be>(this EVStaticStateSys<be> a, Id32<JQPVMRMCZNG> b) where be : DCZUNSBMGOL<be>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C85B70", Offset = "0x3C84770", VA = "0x183C85B70")]
		public static Result<Id32<JQPVMRMCZNG>, NJKZNHRVAZM> UWSJRCXQLUU<bf>(this EVStaticStateSys<bf> a, bf b, Id32<JQPVMRMCZNG>? c, Id32<TZJZKVJCHTJ> d, RootInstantiation e, Id32<GraphInstantiation.M>? f) where bf : DCZUNSBMGOL<bf>, SDSCWGQDFYG
		{
			return default(Result<Id32<JQPVMRMCZNG>, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C120", Offset = "0x3C7AD20", VA = "0x183C7C120")]
		public static Id32<JQPVMRMCZNG> AJQCWJKWJTS<bg>(this EVStaticStateSys<bg> a, bg b, Id32<JQPVMRMCZNG>? c, Id32<TZJZKVJCHTJ> d, RootInstantiation e, Id32<GraphInstantiation.M>? f) where bg : DCZUNSBMGOL<bg>, SDSCWGQDFYG
		{
			return default(Id32<JQPVMRMCZNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C850B0", Offset = "0x3C83CB0", VA = "0x183C850B0")]
		public static Result<None, NJKZNHRVAZM> UFCEIPMVJCP<bh>(this EVStaticStateSys<bh> a, bh b, Id32<JQPVMRMCZNG> c) where bh : DCZUNSBMGOL<bh>, SDSCWGQDFYG
		{
			return default(Result<None, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C87BB0", Offset = "0x3C867B0", VA = "0x183C87BB0")]
		public static void ZMGZEILRXGJ<bi>(this EVStaticStateSys<bi> a, bi b, Id32<JQPVMRMCZNG> c) where bi : DCZUNSBMGOL<bi>, SDSCWGQDFYG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C831E0", Offset = "0x3C81DE0", VA = "0x183C831E0")]
		public static Result<Id32<LWYTCPIHOQE>, NJKZNHRVAZM> PIUJLQXQDVC<bj>(this EVStaticStateSys<bj> a, bj b, Id32<JQPVMRMCZNG> c, Id32<TFITIOWUSRJ> d, RootInstantiation e, Id32<GraphInstantiation.M>? f) where bj : DCZUNSBMGOL<bj>, SDSCWGQDFYG
		{
			return default(Result<Id32<LWYTCPIHOQE>, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EFC0", Offset = "0x3C7DBC0", VA = "0x183C7EFC0")]
		public static Id32<LWYTCPIHOQE> FOVGWCWPFOE<bk>(this EVStaticStateSys<bk> a, bk b, Id32<JQPVMRMCZNG> c, Id32<TFITIOWUSRJ> d, RootInstantiation e, Id32<GraphInstantiation.M>? f) where bk : DCZUNSBMGOL<bk>, SDSCWGQDFYG
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3C82ED0", Offset = "0x3C81AD0", VA = "0x183C82ED0")]
		public static Result<None, NJKZNHRVAZM> OOCFGWYQFRH<bl>(this EVStaticStateSys<bl> a, bl b, Id32<JQPVMRMCZNG> c, Id32<LWYTCPIHOQE> d) where bl : DCZUNSBMGOL<bl>, SDSCWGQDFYG
		{
			return default(Result<None, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3C80B00", Offset = "0x3C7F700", VA = "0x183C80B00")]
		public static void JYDTTGUTSVJ<bm>(this EVStaticStateSys<bm> a, bm b, Id32<JQPVMRMCZNG> c, Id32<LWYTCPIHOQE> d) where bm : DCZUNSBMGOL<bm>, SDSCWGQDFYG
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C828D0", Offset = "0x3C814D0", VA = "0x183C828D0")]
		public static Id32<AWZVWRTEXTC> LXHCUEODKII<bn>(this EVStaticStateSys<bn> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, int d, Id32<VPKCJSHTFFF> e) where bn : DCZUNSBMGOL<bn>
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3C82390", Offset = "0x3C80F90", VA = "0x183C82390")]
		public static void LCSHVADIHRH<bo>(this EVStaticStateSys<bo> a, bo b, Id32<JQPVMRMCZNG> c, Id32<AWZVWRTEXTC> d) where bo : DCZUNSBMGOL<bo>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3C83EE0", Offset = "0x3C82AE0", VA = "0x183C83EE0")]
		public static Id32<IEQQYWIVYHH> RKFKROGLNLB<bp>(this EVStaticStateSys<bp> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, int d, Id32<TIEJMITYOHO> e) where bp : DCZUNSBMGOL<bp>
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3C82160", Offset = "0x3C80D60", VA = "0x183C82160")]
		public static void KZNPRUKBJKY<bq>(this EVStaticStateSys<bq> a, bq b, Id32<JQPVMRMCZNG> c, Id32<IEQQYWIVYHH> d) where bq : DCZUNSBMGOL<bq>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F5D0", Offset = "0x3C7E1D0", VA = "0x183C7F5D0")]
		public static Result<None, NJKZNHRVAZM> GLMFECEDHKR<br>(this EVStaticStateSys<br> a, br b, Id32<JQPVMRMCZNG> c, Id32<IEQQYWIVYHH> d, Id32<AWZVWRTEXTC> e) where br : DCZUNSBMGOL<br>
		{
			return default(Result<None, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C855F0", Offset = "0x3C841F0", VA = "0x183C855F0")]
		public static void UTBUKIDDUQH<bs>(this EVStaticStateSys<bs> a, bs b, Id32<JQPVMRMCZNG> c, Id32<IEQQYWIVYHH> d, Id32<AWZVWRTEXTC> e) where bs : DCZUNSBMGOL<bs>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DA20", Offset = "0x3C7C620", VA = "0x183C7DA20")]
		public static Result<None, NJKZNHRVAZM> DGIJGTXWGQM<bt>(this EVStaticStateSys<bt> a, bt b, Id32<JQPVMRMCZNG> c, Id32<IEQQYWIVYHH> d, Id32<AWZVWRTEXTC> e) where bt : DCZUNSBMGOL<bt>
		{
			return default(Result<None, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C816B0", Offset = "0x3C802B0", VA = "0x183C816B0")]
		public static void KJWLCFVKXVS<bu>(this EVStaticStateSys<bu> a, bu b, Id32<JQPVMRMCZNG> c, Id32<IEQQYWIVYHH> d, Id32<AWZVWRTEXTC> e) where bu : DCZUNSBMGOL<bu>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C87580", Offset = "0x3C86180", VA = "0x183C87580")]
		public static void ZCSEETQHVZX<bw>(this EVStaticStateSys<bw> a, bw b, Id32<JQPVMRMCZNG> c, Id32<AWZVWRTEXTC> d) where bw : DCZUNSBMGOL<bw>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C83780", Offset = "0x3C82380", VA = "0x183C83780")]
		public static void PKHVQIASDUK<by>(this EVStaticStateSys<by> a, by b, Id32<JQPVMRMCZNG> c, Id32<IEQQYWIVYHH> d) where by : DCZUNSBMGOL<by>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C848C0", Offset = "0x3C834C0", VA = "0x183C848C0")]
		public static Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM> TDUJUOFEVQU<bz>(this EVStaticStateSys<bz> a, bz b, Id32<JQPVMRMCZNG> c, Id32<LWYTCPIHOQE> d, Id32<VPKCJSHTFFF> e) where bz : DCZUNSBMGOL<bz>
		{
			return default(Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C811B0", Offset = "0x3C7FDB0", VA = "0x183C811B0")]
		public static Result<None, NJKZNHRVAZM> JZNPBZWGITV<ca>(this EVStaticStateSys<ca> a, ca b, Id32<JQPVMRMCZNG> c, Id32<AWZVWRTEXTC> d, [In] Variant defaultValue) where ca : DCZUNSBMGOL<ca>
		{
			return default(Result<None, NJKZNHRVAZM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3C82500", Offset = "0x3C81100", VA = "0x183C82500")]
		public static void LTAVGAXJCXX<cb>(this EVStaticStateSys<cb> a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c, [In] Variant defaultValue) where cb : DCZUNSBMGOL<cb>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C84E80", Offset = "0x3C83A80", VA = "0x183C84E80")]
		public static bool UCGCQNMFQSO<cc>([In] this EVStaticStateSys<cc> self, IDLCASSILBG a) where cc : DCZUNSBMGOL<cc>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3C85E70", Offset = "0x3C84A70", VA = "0x183C85E70")]
		public static bool WKVSKGDPJEP<cd>([In] this EVStaticStateSys<cd> self, IDLCASSILBG a) where cd : DCZUNSBMGOL<cd>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C858F0", Offset = "0x3C844F0", VA = "0x183C858F0")]
		public static IDLCASSILBG UTITDXZLKVK<ce>([In] this EVStaticStateSys<ce> self) where ce : DCZUNSBMGOL<ce>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3C83CE0", Offset = "0x3C828E0", VA = "0x183C83CE0")]
		public static void QYRKOCZOGHY<cf>(this EVStaticStateSys<cf> a, cf b, Id32<JQPVMRMCZNG> c, IEnumerable<Id32<LWYTCPIHOQE>> d, UnsafeList<Id32<AWZVWRTEXTC>> e) where cf : DCZUNSBMGOL<cf>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C7FEA0", Offset = "0x3C7EAA0", VA = "0x183C7FEA0")]
		public static void IZFGSTLIJXY<cg, ch>(this EVStaticStateSys<cg> a, cg b, Id32<JQPVMRMCZNG> c, [In] ch inputs) where cg : DCZUNSBMGOL<cg> where ch : IEnumerable<Id32<AWZVWRTEXTC>>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3C870A0", Offset = "0x3C85CA0", VA = "0x183C870A0")]
		public static void XJKQZCWXGHO<ci>(this EVStaticStateSys<ci> a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c) where ci : DCZUNSBMGOL<ci>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C80410", Offset = "0x3C7F010", VA = "0x183C80410")]
		public static Dictionary<Id32<LWYTCPIHOQE>, List<TypeParameter<IDLCASSILBG>>> InferTypes<TRoot>([In] this EVStaticStateSys<TRoot> self, TRoot root, Id32<JQPVMRMCZNG> graphId, IEnumerable<Id32<LWYTCPIHOQE>> nodes) where TRoot : DCZUNSBMGOL<TRoot>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CDF0", Offset = "0x3C7B9F0", VA = "0x183C7CDF0")]
		public static void BYJZMRWICBL<cj>(this EVStaticStateSys<cj> a, Id32<JQPVMRMCZNG> b, Dictionary<Id32<LWYTCPIHOQE>, List<TypeParameter<IDLCASSILBG>>> c, UnsafeList<Id32<AWZVWRTEXTC>> d) where cj : DCZUNSBMGOL<cj>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C87D80", Offset = "0x3C86980", VA = "0x183C87D80")]
		[CompilerGenerated]
		internal static IDLCASSILBG ZVMDNUDHFNP<cl, cl>(Dictionary<Id32<LWYTCPIHOQE>, List<TypeParameter<IDLCASSILBG>>> a, Id32<LWYTCPIHOQE> b, IDLCASSILBG c, IDLCASSILBG d) where cl : DCZUNSBMGOL<cl> where cl : DCZUNSBMGOL<cl>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface WUFFHWSZOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PerfScopeDelegates LVOSKEQMYKA();

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Variant ZDBDVDPMPJD(IDLCASSILBG a);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HHUCKYSJXHJ(IDLCASSILBG a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface DCZUNSBMGOL<a> : WUFFHWSZOIM where a : DCZUNSBMGOL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EVStaticStateSys<a> XHYHTYCHCDE();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class TZNPJLKSRYI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x403C060", Offset = "0x403AC60", VA = "0x18403C060")]
		public static IdArray<TFITIOWUSRJ, ZHOBCASHLNG<a>> XPHCJEBECBT<a>(this a a) where a : DCZUNSBMGOL<a>
		{
			return default(IdArray<TFITIOWUSRJ, ZHOBCASHLNG<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x403BC60", Offset = "0x403A860", VA = "0x18403BC60")]
		public static IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<b>> BVIWMHLAVXV<b>(this b a) where b : DCZUNSBMGOL<b>
		{
			return default(IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<b>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x403BCD0", Offset = "0x403A8D0", VA = "0x18403BCD0")]
		public static Graphs Graphs<TSelf>(this TSelf self) where TSelf : DCZUNSBMGOL<TSelf>
		{
			return default(Graphs);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x403C0D0", Offset = "0x403ACD0", VA = "0x18403C0D0")]
		public static EVGraphs YWOKTRYWGNB<c>(this c a) where c : DCZUNSBMGOL<c>
		{
			return default(EVGraphs);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x403BE50", Offset = "0x403AA50", VA = "0x18403BE50")]
		public static ZHOBCASHLNG<d> HATGVQPVHRI<d>(this d a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c) where d : DCZUNSBMGOL<d>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x403BFE0", Offset = "0x403ABE0", VA = "0x18403BFE0")]
		public static OKCLJAZOSIM<e> PUOVJWXNADW<e>(this e a, Id32<JQPVMRMCZNG> b) where e : DCZUNSBMGOL<e>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface SDSCWGQDFYG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UVANEGYVQKV(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, RootInstantiation c, Id32<GraphInstantiation.M>? d);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UMJLBOVPKEB(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YPIHMSVCXHJ(Id32<JQPVMRMCZNG> a, RootInstantiation b, Id32<GraphInstantiation.M>? c);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TCDAXLBPDYP(Id32<JQPVMRMCZNG> a);
	}
}
namespace Circuits.Static.EV.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct TypeCheckSys<TRoot> where TRoot : DCZUNSBMGOL<TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal TypeCheckSys<Id32<QNJVCBQUPRU>, NVTBIKAOMDA, LBDQRSHFOFV, UKAGKRVKEPC<TRoot>, IDLCASSILBG, Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>, Id32<LWYTCPIHOQE>, Id32<JQPVMRMCZNG>, TRoot, TypeCheckSysDeps<TRoot>> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3023780", Offset = "0x3022380", VA = "0x183023780")]
		private TypeCheckSys([In] TypeCheckSys<Id32<QNJVCBQUPRU>, NVTBIKAOMDA, LBDQRSHFOFV, UKAGKRVKEPC<TRoot>, IDLCASSILBG, Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>, Id32<LWYTCPIHOQE>, Id32<JQPVMRMCZNG>, TRoot, TypeCheckSysDeps<TRoot>> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x678DDB0", Offset = "0x678C9B0", VA = "0x18678DDB0")]
		public static TypeCheckSys<TRoot> New()
		{
			return default(TypeCheckSys<TRoot>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class TypeCheckSys
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390")]
		public static TypeCheckSys<Id32<QNJVCBQUPRU>, NVTBIKAOMDA, LBDQRSHFOFV, UKAGKRVKEPC<TRoot>, IDLCASSILBG, Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>, Id32<LWYTCPIHOQE>, Id32<JQPVMRMCZNG>, TRoot, TypeCheckSysDeps<TRoot>> Get<TRoot>([In] this TypeCheckSys<TRoot> self) where TRoot : DCZUNSBMGOL<TRoot>
		{
			return default(TypeCheckSys<Id32<QNJVCBQUPRU>, NVTBIKAOMDA, LBDQRSHFOFV, UKAGKRVKEPC<TRoot>, IDLCASSILBG, Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>, Id32<LWYTCPIHOQE>, Id32<JQPVMRMCZNG>, TRoot, TypeCheckSysDeps<TRoot>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct TypeSys<TRoot> where TRoot : DCZUNSBMGOL<TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal TypeSys<DirectedType<IDLCASSILBG>, TRoot, TypeSysDeps<TRoot>> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3023A50", Offset = "0x3022650", VA = "0x183023A50")]
		private TypeSys([In] TypeSys<DirectedType<IDLCASSILBG>, TRoot, TypeSysDeps<TRoot>> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67A7F00", Offset = "0x67A6B00", VA = "0x1867A7F00")]
		public static TypeSys<TRoot> New()
		{
			return default(TypeSys<TRoot>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class OESTPVSRNJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390")]
		public static TypeSys<DirectedType<IDLCASSILBG>, TRoot, TypeSysDeps<TRoot>> Get<TRoot>([In] this TypeSys<TRoot> self) where TRoot : DCZUNSBMGOL<TRoot>
		{
			return default(TypeSys<DirectedType<IDLCASSILBG>, TRoot, TypeSysDeps<TRoot>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class UKAGKRVKEPC<a> where a : DCZUNSBMGOL<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly BRJRFCKGQRA<a, UnificationSysDeps<a>> OEGDIYQRJYQ;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
		public BRJRFCKGQRA<a, UnificationSysDeps<a>> Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6814480", Offset = "0x6813080", VA = "0x186814480")]
		private UKAGKRVKEPC(UnificationSysDeps<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68142C0", Offset = "0x6812EC0", VA = "0x1868142C0")]
		public static UKAGKRVKEPC<a> New()
		{
			return null;
		}
	}
}
namespace Circuits.Static.EV.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EVGraph
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public abstract class LPCAELTSUGD
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public SOAField<AWZVWRTEXTC, EVInput> EVInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public SOAField<IEQQYWIVYHH, EVOutput> EVOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public SOAField<LWYTCPIHOQE, EVNode> EVNodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public SOAId32<InputGroups.M> InputGroupIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAField<InputGroups.M, InputGroups> InputGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAId32<OutputGroups.M> OutputGroupIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<OutputGroups.M, OutputGroups> OutputGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly Id32<TZJZKVJCHTJ> DefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Id32<LPCAELTSUGD> VirtId;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2E02DA0", Offset = "0x2E019A0", VA = "0x182E02DA0")]
		private EVGraph([In] SOAField<AWZVWRTEXTC, EVInput> evInputs, [In] SOAField<IEQQYWIVYHH, EVOutput> evOutputs, [In] SOAField<LWYTCPIHOQE, EVNode> evNodes, [In] SOAId32<InputGroups.M> inputGroupIds, [In] SOAField<InputGroups.M, InputGroups> inputGroups, [In] SOAId32<OutputGroups.M> outputGroupIds, [In] SOAField<OutputGroups.M, OutputGroups> outputGroups, Id32<TZJZKVJCHTJ> defId, Id32<LPCAELTSUGD> virtId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2E02AD0", Offset = "0x2E016D0", VA = "0x182E02AD0")]
		public static EVGraph JDWBQXCTRZG(Id32<TZJZKVJCHTJ> a)
		{
			return default(EVGraph);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2E02CF0", Offset = "0x2E018F0", VA = "0x182E02CF0")]
		public static EVGraph NRHPWSBBVER([In] SOAField<AWZVWRTEXTC, EVInput> evInputs, [In] SOAField<IEQQYWIVYHH, EVOutput> evOutputs, [In] SOAField<LWYTCPIHOQE, EVNode> evNodes, [In] SOAId32<InputGroups.M> inputGroupIds, [In] SOAField<InputGroups.M, InputGroups> inputGroups, [In] SOAId32<OutputGroups.M> outputGroupIds, [In] SOAField<OutputGroups.M, OutputGroups> outputGroups, Id32<TZJZKVJCHTJ> a, Id32<LPCAELTSUGD> b)
		{
			return default(EVGraph);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class ISOZOKXZEXT
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2E03B70", Offset = "0x2E02770", VA = "0x182E03B70")]
		public static void Destroy(this EVGraph self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3C27440", Offset = "0x3C26040", VA = "0x183C27440")]
		public static Id32<a> TKITUHJAZML<a>([In] this EVGraph self) where a : EVGraph.LPCAELTSUGD
		{
			return default(Id32<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct EVGraphs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public SOAField<JQPVMRMCZNG, EVGraph> Items;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private EVGraphs([In] SOAField<JQPVMRMCZNG, EVGraph> items)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2E02EA0", Offset = "0x2E01AA0", VA = "0x182E02EA0")]
		public static EVGraphs HVKYDMYBGAZ([In] SOAField<JQPVMRMCZNG, EVGraph> items)
		{
			return default(EVGraphs);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class ZZJYGFONESK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2E06110", Offset = "0x2E04D10", VA = "0x182E06110")]
		public static void Destroy(this EVGraphs self, [In] Graphs graphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2E05E60", Offset = "0x2E04A60", VA = "0x182E05E60")]
		internal static void DDATGWDPZQA(this EVGraphs a, Id32<JQPVMRMCZNG> b, Id32<TZJZKVJCHTJ> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2E06350", Offset = "0x2E04F50", VA = "0x182E06350")]
		internal static void Release(this EVGraphs self, Id32<JQPVMRMCZNG> id, [In] Graphs graphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2E062B0", Offset = "0x2E04EB0", VA = "0x182E062B0")]
		public static EVGraph Get([In] this EVGraphs self, Id32<JQPVMRMCZNG> id)
		{
			return default(EVGraph);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2E065D0", Offset = "0x2E051D0", VA = "0x182E065D0")]
		public static EVGraph YXACYNUPMAX(this EVGraphs a, Id32<JQPVMRMCZNG> b)
		{
			return default(EVGraph);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct EVInput
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IDLCASSILBG GenericType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public IDLCASSILBG InferredType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Variant DefaultValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Id32<VPKCJSHTFFF> DefId;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2E02FC0", Offset = "0x2E01BC0", VA = "0x182E02FC0")]
		private EVInput(IDLCASSILBG genericType, IDLCASSILBG inferredType, [In] Variant defaultValue, Id32<VPKCJSHTFFF> defId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2E02F50", Offset = "0x2E01B50", VA = "0x182E02F50")]
		public static EVInput New(Id32<VPKCJSHTFFF> defId)
		{
			return default(EVInput);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2E02ED0", Offset = "0x2E01AD0", VA = "0x182E02ED0")]
		public static EVInput JKTFHCYGKHB([In] Variant defaultValue, Id32<VPKCJSHTFFF> a)
		{
			return default(EVInput);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class PNVAVGFJOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2E049D0", Offset = "0x2E035D0", VA = "0x182E049D0")]
		public static void SBTWWNVAIAE(this EVInput a, IDLCASSILBG b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct EVNode
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public abstract class LPCAELTSUGD
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly Id32<TFITIOWUSRJ> DefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Id32<LPCAELTSUGD> VirtId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		private EVNode(Id32<TFITIOWUSRJ> nodeDef, Id32<LPCAELTSUGD> virtId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2E03020", Offset = "0x2E01C20", VA = "0x182E03020")]
		public static EVNode JDWBQXCTRZG(Id32<TFITIOWUSRJ> a)
		{
			return default(EVNode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2DE26A0", Offset = "0x2DE12A0", VA = "0x182DE26A0")]
		public static EVNode NRHPWSBBVER(Id32<TFITIOWUSRJ> a, Id32<LPCAELTSUGD> b)
		{
			return default(EVNode);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class ATYFLHORHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x355D800", Offset = "0x355C400", VA = "0x18355D800")]
		public static Id32<a> TKITUHJAZML<a>([In] this EVNode self) where a : EVNode.LPCAELTSUGD
		{
			return default(Id32<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct EVOutput
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IDLCASSILBG GenericType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IDLCASSILBG InferredType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Id32<TIEJMITYOHO> DefId;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2E03090", Offset = "0x2E01C90", VA = "0x182E03090")]
		private EVOutput(IDLCASSILBG genericType, IDLCASSILBG inferredType, Id32<TIEJMITYOHO> defId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2E03040", Offset = "0x2E01C40", VA = "0x182E03040")]
		public static EVOutput New(Id32<TIEJMITYOHO> defId)
		{
			return default(EVOutput);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class TCFLDBPYIEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2E05250", Offset = "0x2E03E50", VA = "0x182E05250")]
		public static void SBTWWNVAIAE(this EVOutput a, IDLCASSILBG b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct GraphInstantiation
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Instantiation Instantiation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2E031B0", Offset = "0x2E01DB0", VA = "0x182E031B0")]
		private GraphInstantiation([In] Instantiation instantiation, Id32<JQPVMRMCZNG> graphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2E030E0", Offset = "0x2E01CE0", VA = "0x182E030E0")]
		public static GraphInstantiation New(Id32<JQPVMRMCZNG> graphId)
		{
			return default(GraphInstantiation);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class NBHXYDZROEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2E03B10", Offset = "0x2E02710", VA = "0x182E03B10")]
		public static void Destroy(this GraphInstantiation self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3DB2650", Offset = "0x3DB1250", VA = "0x183DB2650")]
		public static void CHXKTZXPDBC<a>([In] this GraphInstantiation self, [In] RootInstantiation rootInstantiation, a a, EVStaticStateSys<a> b) where a : DCZUNSBMGOL<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3DB2870", Offset = "0x3DB1470", VA = "0x183DB2870")]
		public static void QYRKOCZOGHY<b>([In] this GraphInstantiation self, [In] RootInstantiation rootInstantiation, b a, EVStaticStateSys<b> b) where b : DCZUNSBMGOL<b>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3DB27F0", Offset = "0x3DB13F0", VA = "0x183DB27F0")]
		public static void IZFGSTLIJXY<c>([In] this GraphInstantiation self, [In] RootInstantiation rootInstantiation, c a, EVStaticStateSys<c> b) where c : DCZUNSBMGOL<c>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct Graphs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TreeSys<JQPVMRMCZNG> Tree;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public SOAField<JQPVMRMCZNG, GraphSys> Items;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03270", Offset = "0x2E01E70", VA = "0x182E03270")]
		private Graphs([In] TreeSys<JQPVMRMCZNG> tree, [In] SOAField<JQPVMRMCZNG, GraphSys> items)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2E031F0", Offset = "0x2E01DF0", VA = "0x182E031F0")]
		public static Graphs HVKYDMYBGAZ([In] TreeSys<JQPVMRMCZNG> tree, [In] SOAField<JQPVMRMCZNG, GraphSys> items)
		{
			return default(Graphs);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class HYNESWIFNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2E03460", Offset = "0x2E02060", VA = "0x182E03460")]
		public static void Destroy(this Graphs self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2E032D0", Offset = "0x2E01ED0", VA = "0x182E032D0")]
		public static Id32<JQPVMRMCZNG> DDATGWDPZQA(this Graphs a)
		{
			return default(Id32<JQPVMRMCZNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2E03890", Offset = "0x2E02490", VA = "0x182E03890")]
		public static Id32<JQPVMRMCZNG> TOUJAEPIEWQ(this Graphs a, Id32<JQPVMRMCZNG> b)
		{
			return default(Id32<JQPVMRMCZNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2E036B0", Offset = "0x2E022B0", VA = "0x182E036B0")]
		public static void Release(this Graphs self, Id32<JQPVMRMCZNG> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2E039B0", Offset = "0x2E025B0", VA = "0x182E039B0")]
		public static SOAId32<JQPVMRMCZNG>.Enumerator VAZLNVUYCAR([In] this Graphs self)
		{
			return default(SOAId32<JQPVMRMCZNG>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2E03610", Offset = "0x2E02210", VA = "0x182E03610")]
		public static GraphSys Get([In] this Graphs self, Id32<JQPVMRMCZNG> id)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2E03A70", Offset = "0x2E02670", VA = "0x182E03A70")]
		public static GraphSys YXACYNUPMAX(this Graphs a, Id32<JQPVMRMCZNG> b)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2E03A20", Offset = "0x2E02620", VA = "0x182E03A20")]
		public static bool VXCRCHKVQSR([In] this Graphs self, Id32<JQPVMRMCZNG> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2E033F0", Offset = "0x2E01FF0", VA = "0x182E033F0")]
		public static ConstEnumerable<Id32<JQPVMRMCZNG>, UnsafeList<Id32<JQPVMRMCZNG>>.Enumerator> DMKEVJOAYER([In] this Graphs self, Id32<JQPVMRMCZNG> a)
		{
			return default(ConstEnumerable<Id32<JQPVMRMCZNG>, UnsafeList<Id32<JQPVMRMCZNG>>.Enumerator>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface OKCLJAZOSIM<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OFMLSTORVPX(a a, Id32<JQPVMRMCZNG> b, RootInstantiation c, Id32<GraphInstantiation.M>? d);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NASCZLCHALL(a a, Id32<JQPVMRMCZNG> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface ZHOBCASHLNG<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OFMLSTORVPX(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, RootInstantiation d, Id32<GraphInstantiation.M>? e);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NASCZLCHALL(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<TypeParameter<IDLCASSILBG>> UZXFXLPRTHR(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WFVEBFVOYYM(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Variant VZXTZLLFWNT(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d, IDLCASSILBG e);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Instantiation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public UnsafeList<Id32<LWYTCPIHOQE>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public UnsafeList<Id32<GraphInstantiation.M>> ChildGraphs;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE1240", Offset = "0x2DDFE40", VA = "0x182DE1240")]
		private Instantiation([In] UnsafeList<Id32<LWYTCPIHOQE>> nodes, [In] UnsafeList<Id32<GraphInstantiation.M>> childGraphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2E03EE0", Offset = "0x2E02AE0", VA = "0x182E03EE0")]
		public static Instantiation New()
		{
			return default(Instantiation);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class IEMOHQIWAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2E03B10", Offset = "0x2E02710", VA = "0x182E03B10")]
		public static void Destroy(this Instantiation self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4800", Offset = "0x3BF3400", VA = "0x183BF4800")]
		internal static void JKGFPMLXSKU<a>([In] this Instantiation self, [In] RootInstantiation rootInstantiation, a a, EVStaticStateSys<a> b) where a : DCZUNSBMGOL<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4130", Offset = "0x3BF2D30", VA = "0x183BF4130")]
		internal static void CHXKTZXPDBC<b>([In] this Instantiation self, [In] RootInstantiation rootInstantiation, b a, EVStaticStateSys<b> b, EVGraph c, Id32<JQPVMRMCZNG> d) where b : DCZUNSBMGOL<b>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3B80", Offset = "0x3BF2780", VA = "0x183BF3B80")]
		internal static void AJLTIBYLIYO<c>([In] this Instantiation self, [In] RootInstantiation rootInstantiation, c a, EVStaticStateSys<c> b) where c : DCZUNSBMGOL<c>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4B70", Offset = "0x3BF3770", VA = "0x183BF4B70")]
		internal static void QYRKOCZOGHY<d>([In] this Instantiation self, [In] RootInstantiation rootInstantiation, d a, EVStaticStateSys<d> b, Id32<JQPVMRMCZNG> c) where d : DCZUNSBMGOL<d>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3CE0", Offset = "0x3BF28E0", VA = "0x183BF3CE0")]
		internal static void BSAFBUGYAOO<e>([In] this Instantiation self, [In] RootInstantiation rootInstantiation, e a, EVStaticStateSys<e> b) where e : DCZUNSBMGOL<e>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4640", Offset = "0x3BF3240", VA = "0x183BF4640")]
		internal static void IZFGSTLIJXY<f>([In] this Instantiation self, [In] RootInstantiation rootInstantiation, f a, EVStaticStateSys<f> b, Id32<JQPVMRMCZNG> c) where f : DCZUNSBMGOL<f>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class QUFGXHZWYWW
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2E05080", Offset = "0x2E03C80", VA = "0x182E05080")]
		public static Id32<VPKCJSHTFFF> BLABPMWYYNN(this int a)
		{
			return default(Id32<VPKCJSHTFFF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2E050C0", Offset = "0x2E03CC0", VA = "0x182E050C0")]
		public static Id32<TIEJMITYOHO> SYVESPLEJBQ(this int a)
		{
			return default(Id32<TIEJMITYOHO>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class ZDQOSUHEIBN<b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3557370", Offset = "0x3555F70", VA = "0x183557370")]
		public static Result<b, KPWSALSIRQU> EDYVEMLNVVI<a>(ZHOBCASHLNG<a> a, Id32<TFITIOWUSRJ> b)
		{
			return default(Result<b, KPWSALSIRQU>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct RootInstantiation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal Instantiation _root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		internal IdUnsafeList<GraphInstantiation.M, GraphInstantiation> _graphs;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2E05200", Offset = "0x2E03E00", VA = "0x182E05200")]
		private RootInstantiation([In] Instantiation root, [In] IdUnsafeList<GraphInstantiation.M, GraphInstantiation> graphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2E05100", Offset = "0x2E03D00", VA = "0x182E05100")]
		public static RootInstantiation New()
		{
			return default(RootInstantiation);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class QCYLVYBIPQV
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2E04A90", Offset = "0x2E03690", VA = "0x182E04A90")]
		public static void Destroy(this RootInstantiation self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2E04A50", Offset = "0x2E03650", VA = "0x182E04A50")]
		public static bool DSWOJSZHWRM([In] this RootInstantiation self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2E04CC0", Offset = "0x2E038C0", VA = "0x182E04CC0")]
		public static void PIUJLQXQDVC(this RootInstantiation a, Id32<GraphInstantiation.M>? b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2E04DB0", Offset = "0x2E039B0", VA = "0x182E04DB0")]
		public static Id32<GraphInstantiation.M> UWSJRCXQLUU(this RootInstantiation a, Id32<GraphInstantiation.M>? b, Id32<JQPVMRMCZNG> c)
		{
			return default(Id32<GraphInstantiation.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2E04C50", Offset = "0x2E03850", VA = "0x182E04C50")]
		public static GraphInstantiation JJWHKHIGMTM([In] this RootInstantiation self, Id32<GraphInstantiation.M> a)
		{
			return default(GraphInstantiation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F09280", Offset = "0x3F07E80", VA = "0x183F09280")]
		public static void CHXKTZXPDBC<a>([In] this RootInstantiation self, a a, EVStaticStateSys<a> b) where a : DCZUNSBMGOL<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F09200", Offset = "0x3F07E00", VA = "0x183F09200")]
		public static void CHXKTZXPDBC<b>([In] this RootInstantiation self, b a, EVStaticStateSys<b> b, EVGraph c, Id32<JQPVMRMCZNG> d) where b : DCZUNSBMGOL<b>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F095D0", Offset = "0x3F081D0", VA = "0x183F095D0")]
		public static void QYRKOCZOGHY<c>([In] this RootInstantiation self, c a, EVStaticStateSys<c> b) where c : DCZUNSBMGOL<c>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F09640", Offset = "0x3F08240", VA = "0x183F09640")]
		public static void QYRKOCZOGHY<d>([In] this RootInstantiation self, d a, EVStaticStateSys<d> b, Id32<JQPVMRMCZNG> c) where d : DCZUNSBMGOL<d>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F093F0", Offset = "0x3F07FF0", VA = "0x183F093F0")]
		public static void IZFGSTLIJXY<e>([In] this RootInstantiation self, e a, EVStaticStateSys<e> b) where e : DCZUNSBMGOL<e>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3F09460", Offset = "0x3F08060", VA = "0x183F09460")]
		public static void IZFGSTLIJXY<f>([In] this RootInstantiation self, f a, EVStaticStateSys<f> b, EVGraph c, Id32<JQPVMRMCZNG> d) where f : DCZUNSBMGOL<f>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[DebuggerDisplay("Class: {ClassString}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
	public readonly struct Variant : IEquatable<Variant>, MNLRIGBOINM<Variant>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly object? _class;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Union32 _struct;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private string QYVRCAGGYWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2E05750", Offset = "0x2E04350", VA = "0x182E05750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LOCVKIXBBWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xF290A0", Offset = "0xF27CA0", VA = "0x180F290A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int DMGLTASHOKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xFD5810", Offset = "0xFD4410", VA = "0x180FD5810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float LOGEQHRPKWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2E05BB0", Offset = "0x2E047B0", VA = "0x182E05BB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? NISNZKOMYXS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2E05950", Offset = "0x2E04550", VA = "0x182E05950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ReadOnlyArray<byte>? LOARWSVIPKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x2E05690", Offset = "0x2E04290", VA = "0x182E05690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2E05BC0", Offset = "0x2E047C0", VA = "0x182E05BC0")]
		private Variant(object? @class, Union32 @struct)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2E05830", Offset = "0x2E04430", VA = "0x182E05830")]
		private static Variant MTPDFRTCSNG(Union32 a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2E058E0", Offset = "0x2E044E0", VA = "0x182E058E0")]
		public static Variant OBHSCQQMSYF(bool a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2E05890", Offset = "0x2E04490", VA = "0x182E05890")]
		public static Variant NTUODGPOOMV(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2E057E0", Offset = "0x2E043E0", VA = "0x182E057E0")]
		public static Variant JPPORXLKETG(float a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2E05860", Offset = "0x2E04460", VA = "0x182E05860")]
		public static Variant VICVMZXHTQE(string a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2E05860", Offset = "0x2E04460", VA = "0x182E05860")]
		public static Variant MVOYGOGLLUY(byte[] a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2E055A0", Offset = "0x2E041A0", VA = "0x182E055A0")]
		public static Variant FBJUJEUJJLL(int a)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2E057B0", Offset = "0x2E043B0", VA = "0x182E057B0")]
		public static Variant JBEJTREFXSY()
		{
			return default(Variant);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2E053E0", Offset = "0x2E03FE0", VA = "0x182E053E0")]
		public static bool EOXNKNKFOQL([In] Variant lhs, [In] Variant rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2E05530", Offset = "0x2E04130", VA = "0x182E05530", Slot = "4")]
		public bool Equals(Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2E053E0", Offset = "0x2E03FE0", VA = "0x182E053E0")]
		public bool XGBYPYNVUZB([In] Variant other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2E05450", Offset = "0x2E04050", VA = "0x182E05450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2E05620", Offset = "0x2E04220", VA = "0x182E05620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2E05980", Offset = "0x2E04580", VA = "0x182E05980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2E053E0", Offset = "0x2E03FE0", VA = "0x182E053E0", Slot = "5")]
		private bool KCTUFRSJFBE([In] Variant other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.EV.Injection
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct TypeCheckSysDeps<TRoot> : BNCNDWXBYZF<Id32<QNJVCBQUPRU>, NVTBIKAOMDA, LBDQRSHFOFV, UKAGKRVKEPC<TRoot>, IDLCASSILBG, Id32<AWZVWRTEXTC>, Id32<IEQQYWIVYHH>, Id32<LWYTCPIHOQE>, Id32<JQPVMRMCZNG>, TRoot> where TRoot : DCZUNSBMGOL<TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3023320", Offset = "0x3021F20", VA = "0x183023320", Slot = "24")]
		public void ULIYIOHPGHZ(TRoot a, IDLCASSILBG b, Action<IDLCASSILBG> c, Action<IDLCASSILBG> d, Action<IDLCASSILBG> e, Action<IDLCASSILBG> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x678C960", Offset = "0x678B560", VA = "0x18678C960", Slot = "25")]
		public IDLCASSILBG LVXZTEHFYMT(TRoot a, IDLCASSILBG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x678CEB0", Offset = "0x678BAB0", VA = "0x18678CEB0", Slot = "5")]
		public IDLCASSILBG RVVOSTMTDFE(TRoot a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x678DD20", Offset = "0x678C920", VA = "0x18678DD20", Slot = "14")]
		public IDLCASSILBG YCDVBIYGXXY(TRoot a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x678BBB0", Offset = "0x678A7B0", VA = "0x18678BBB0", Slot = "17")]
		public Id32<LWYTCPIHOQE> FCAYTPDPMIF(TRoot a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x678CB40", Offset = "0x678B740", VA = "0x18678CB40", Slot = "16")]
		public Id32<IEQQYWIVYHH> NWFFHGCHLHK(TRoot a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c, int d)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x678CBB0", Offset = "0x678B7B0", VA = "0x18678CBB0", Slot = "15")]
		public int OBNJFNOSTYP(TRoot a, Id32<JQPVMRMCZNG> b, Id32<AWZVWRTEXTC> c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x678D6D0", Offset = "0x678C2D0", VA = "0x18678D6D0")]
		public DirectedType<IDLCASSILBG> XARTFBZEUYL(TRoot a, [In] DirectedType<IDLCASSILBG> lhs, [In] DirectedType<IDLCASSILBG> rhs)
		{
			return default(DirectedType<IDLCASSILBG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x678D110", Offset = "0x678BD10", VA = "0x18678D110", Slot = "13")]
		public IEnumerable<EquivalentTypeParameters<Id32<LWYTCPIHOQE>>> UTFIRCMRKIG(TRoot a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x678B3A0", Offset = "0x6789FA0", VA = "0x18678B3A0", Slot = "9")]
		public Id32<AWZVWRTEXTC> CCSXLJXNYIF(TRoot a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, int d)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x678D2D0", Offset = "0x678BED0", VA = "0x18678D2D0", Slot = "8")]
		public int VAGKCEODVSM(TRoot a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x678B150", Offset = "0x6789D50", VA = "0x18678B150", Slot = "11")]
		public Id32<IEQQYWIVYHH> BWEYNOOPYFY(TRoot a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, int d)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x678A8A0", Offset = "0x67894A0", VA = "0x18678A8A0", Slot = "10")]
		public int ACRZINSIWRH(TRoot a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x678B800", Offset = "0x678A400", VA = "0x18678B800", Slot = "7")]
		public int EDDKMBNEFGV(TRoot a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x678DAC0", Offset = "0x678C6C0", VA = "0x18678DAC0", Slot = "12")]
		public IEnumerable<TypeParameter<IDLCASSILBG>> XRCYSEPBDNZ(TRoot a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x678B8F0", Offset = "0x678A4F0", VA = "0x18678B8F0", Slot = "18")]
		public IDLCASSILBG EOCIUXTVWGJ(TRoot a, Id32<JQPVMRMCZNG> b, Id32<IEQQYWIVYHH> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x678C230", Offset = "0x678AE30", VA = "0x18678C230", Slot = "20")]
		public Id32<AWZVWRTEXTC> IAOGNETHDIQ(TRoot a, Id32<JQPVMRMCZNG> b, Id32<IEQQYWIVYHH> c, int d)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x678D0A0", Offset = "0x678BCA0", VA = "0x18678D0A0", Slot = "19")]
		public int TBNJZGZSYJB(TRoot a, Id32<JQPVMRMCZNG> b, Id32<IEQQYWIVYHH> c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x678AA60", Offset = "0x6789660", VA = "0x18678AA60", Slot = "21")]
		public Id32<LWYTCPIHOQE> BEYAHPIHEKQ(TRoot a, Id32<JQPVMRMCZNG> b, Id32<IEQQYWIVYHH> c)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x678C5E0", Offset = "0x678B1E0", VA = "0x18678C5E0", Slot = "4")]
		public PerfScopeDelegates IPWSSTFGNFO(TRoot a)
		{
			return default(PerfScopeDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x678BB80", Offset = "0x678A780", VA = "0x18678BB80", Slot = "27")]
		public UKAGKRVKEPC<TRoot> ERRIVDGINAG(TRoot a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x30232C0", Offset = "0x3021EC0", VA = "0x1830232C0", Slot = "23")]
		public IDLCASSILBG UAFSEFHISVX(TRoot a, IDLCASSILBG b, IEnumerable<IDLCASSILBG> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x678C6A0", Offset = "0x678B2A0", VA = "0x18678C6A0", Slot = "26")]
		public string IWJOWYXFDFG(TRoot a, IDLCASSILBG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x30232F0", Offset = "0x3021EF0", VA = "0x1830232F0", Slot = "22")]
		public bool UKTRQJZWQQT(TRoot a, IDLCASSILBG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x678BF50", Offset = "0x678AB50", VA = "0x18678BF50", Slot = "31")]
		public Id32<QNJVCBQUPRU> GRNFJBVEQRB(TRoot a, UKAGKRVKEPC<TRoot> b, Id32<QNJVCBQUPRU> c, Id32<QNJVCBQUPRU> d)
		{
			return default(Id32<QNJVCBQUPRU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x678C780", Offset = "0x678B380", VA = "0x18678C780", Slot = "32")]
		public void LDLPQFZUOWZ(TRoot a, UKAGKRVKEPC<TRoot> b, Id32<QNJVCBQUPRU> c, Id32<QNJVCBQUPRU> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3023370", Offset = "0x3021F70", VA = "0x183023370", Slot = "39")]
		public NVTBIKAOMDA UQBCPGUOAZJ(TRoot a, UKAGKRVKEPC<TRoot> b, LBDQRSHFOFV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x678C1B0", Offset = "0x678ADB0", VA = "0x18678C1B0", Slot = "30")]
		public Id32<QNJVCBQUPRU> HYSKIYJOFGF(TRoot a, UKAGKRVKEPC<TRoot> b, Id32<QNJVCBQUPRU> c)
		{
			return default(Id32<QNJVCBQUPRU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x678A9F0", Offset = "0x67895F0", VA = "0x18678A9F0", Slot = "29")]
		public Id32<QNJVCBQUPRU> AFDIASSCOMW(TRoot a, UKAGKRVKEPC<TRoot> b)
		{
			return default(Id32<QNJVCBQUPRU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x678CDD0", Offset = "0x678B9D0", VA = "0x18678CDD0", Slot = "36")]
		public NVTBIKAOMDA REORIFJUOWE(TRoot a, UKAGKRVKEPC<TRoot> b, NVTBIKAOMDA c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x678B450", Offset = "0x678A050", VA = "0x18678B450", Slot = "37")]
		public NVTBIKAOMDA CXJLQTNTZKB(TRoot a, UKAGKRVKEPC<TRoot> b, NVTBIKAOMDA c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x678D390", Offset = "0x678BF90", VA = "0x18678D390", Slot = "35")]
		public Id32<QNJVCBQUPRU> WDKMSWIUEZT(TRoot a, UKAGKRVKEPC<TRoot> b, NVTBIKAOMDA c)
		{
			return default(Id32<QNJVCBQUPRU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3023480", Offset = "0x3022080", VA = "0x183023480", Slot = "38")]
		public Id32<QNJVCBQUPRU> VKEFXNNEYIX(TRoot a, UKAGKRVKEPC<TRoot> b, LBDQRSHFOFV c)
		{
			return default(Id32<QNJVCBQUPRU>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x678B540", Offset = "0x678A140", VA = "0x18678B540", Slot = "33")]
		public bool DHHZOXOHZCW(TRoot a, UKAGKRVKEPC<TRoot> b, NVTBIKAOMDA c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x678C410", Offset = "0x678B010", VA = "0x18678C410", Slot = "34")]
		public bool INYJUXVGMBU(TRoot a, UKAGKRVKEPC<TRoot> b, NVTBIKAOMDA c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x678BEB0", Offset = "0x678AAB0", VA = "0x18678BEB0", Slot = "28")]
		public Result<LBDQRSHFOFV[], UTITDXZLKVK> FVAAVNNZTSR(TRoot a, UKAGKRVKEPC<TRoot> b)
		{
			return default(Result<LBDQRSHFOFV[], UTITDXZLKVK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x678AF30", Offset = "0x6789B30", VA = "0x18678AF30", Slot = "40")]
		public NVTBIKAOMDA BNLAIKBBREC(TRoot a, UKAGKRVKEPC<TRoot> b, Id32<QNJVCBQUPRU> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x678AC30", Offset = "0x6789830", VA = "0x18678AC30", Slot = "6")]
		private DirectedType<IDLCASSILBG> BIOQDBFCXKJ(TRoot a, [In] DirectedType<IDLCASSILBG> lhs, [In] DirectedType<IDLCASSILBG> rhs)
		{
			return default(DirectedType<IDLCASSILBG>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct TypeSysDeps<TRoot> : MQBQDZFUSGT<DirectedType<IDLCASSILBG>, IDLCASSILBG, TRoot> where TRoot : DCZUNSBMGOL<TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1047AF0", Offset = "0x10466F0", VA = "0x181047AF0")]
		public IOKind DUGBKFOVSFD([In] DirectedType<IDLCASSILBG> directedType)
		{
			return default(IOKind);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0")]
		public IDLCASSILBG RHQMJZLGJIL([In] DirectedType<IDLCASSILBG> directedType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x67A7DE0", Offset = "0x67A69E0", VA = "0x1867A7DE0", Slot = "4")]
		public DirectedType<IDLCASSILBG> QCHVCQIGXCB(IDLCASSILBG a, IOKind b)
		{
			return default(DirectedType<IDLCASSILBG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x67A7B80", Offset = "0x67A6780", VA = "0x1867A7B80", Slot = "7")]
		public PerfScopeDelegates LVOSKEQMYKA(TRoot a)
		{
			return default(PerfScopeDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x67A7B50", Offset = "0x67A6750", VA = "0x1867A7B50", Slot = "5")]
		private IDLCASSILBG EDNBFVDIIXG([In] DirectedType<IDLCASSILBG> directedType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x67A7AA0", Offset = "0x67A66A0", VA = "0x1867A7AA0", Slot = "6")]
		private IOKind ADJPXXTKLFM([In] DirectedType<IDLCASSILBG> directedType)
		{
			return default(IOKind);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct UnificationSysDeps<TRoot> : MQMDYMTPLDL<TRoot> where TRoot : DCZUNSBMGOL<TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x683AFC0", Offset = "0x6839BC0", VA = "0x18683AFC0", Slot = "4")]
		public PerfScopeDelegates LVOSKEQMYKA(TRoot a)
		{
			return default(PerfScopeDelegates);
		}
	}
}
namespace Circuits.Static.EV.Factory
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface VXFXYEKOFOJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<TZJZKVJCHTJ> HNEDLRCDCZV(OKCLJAZOSIM<a> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface BOEJPDUYVMV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Id32<TFITIOWUSRJ> BDXTWQDWIKT(ZHOBCASHLNG<a> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public abstract class YSCSHHYAUOL<a, b> : BOEJPDUYVMV<b>, VXFXYEKOFOJ<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IdUnsafeList<TFITIOWUSRJ, ZHOBCASHLNG<b>> HDIIYBYXPOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private IdUnsafeList<TZJZKVJCHTJ, OKCLJAZOSIM<b>> SMSRZWZGUNY;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x448C250", Offset = "0x448AE50", VA = "0x18448C250", Slot = "4")]
		public Id32<TFITIOWUSRJ> BDXTWQDWIKT(ZHOBCASHLNG<b> a)
		{
			return default(Id32<TFITIOWUSRJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x448C3F0", Offset = "0x448AFF0", VA = "0x18448C3F0", Slot = "5")]
		public Id32<TZJZKVJCHTJ> HNEDLRCDCZV(OKCLJAZOSIM<b> a)
		{
			return default(Id32<TZJZKVJCHTJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x448C460", Offset = "0x448B060", VA = "0x18448C460")]
		protected internal YSCSHHYAUOL([In] IdUnsafeList<TFITIOWUSRJ, ZHOBCASHLNG<b>> nodeDefs, [In] IdUnsafeList<TZJZKVJCHTJ, OKCLJAZOSIM<b>> graphDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x448C360", Offset = "0x448AF60", VA = "0x18448C360")]
		public (IdArray<TFITIOWUSRJ, ZHOBCASHLNG<b>>, IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<b>>) FATJKNZTHSX()
		{
			return default((IdArray<TFITIOWUSRJ, ZHOBCASHLNG<b>>, IdArray<TZJZKVJCHTJ, OKCLJAZOSIM<b>>));
		}
	}
}
namespace Circuits.Static.EV.Error
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public abstract class YFKOPUBUZRQ : NJKZNHRVAZM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4DC0", Offset = "0x2DF39C0", VA = "0x182DF4DC0")]
		protected YFKOPUBUZRQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class OUMAGFUJJLT : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly Id32<IEQQYWIVYHH> AKCZCDRFOVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly Id32<AWZVWRTEXTC> PAUFQWTKNZD;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2E04230", Offset = "0x2E02E30", VA = "0x182E04230")]
		public OUMAGFUJJLT(Id32<JQPVMRMCZNG> a, Id32<IEQQYWIVYHH> b, Id32<AWZVWRTEXTC> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2E048B0", Offset = "0x2E034B0", VA = "0x182E048B0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class NHNTJCRSTYY : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly Id32<AWZVWRTEXTC> QEDDRQKNBVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly IDLCASSILBG JGVJNZJVVLT;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2E04420", Offset = "0x2E03020", VA = "0x182E04420")]
		public NHNTJCRSTYY(Id32<JQPVMRMCZNG> a, Id32<AWZVWRTEXTC> b, IDLCASSILBG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E043E0", Offset = "0x2E02FE0", VA = "0x182E043E0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class NBCUOHUJFIN : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly Id32<IEQQYWIVYHH> AKCZCDRFOVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly Id32<AWZVWRTEXTC> PAUFQWTKNZD;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E04230", Offset = "0x2E02E30", VA = "0x182E04230")]
		public NBCUOHUJFIN(Id32<JQPVMRMCZNG> a, Id32<IEQQYWIVYHH> b, Id32<AWZVWRTEXTC> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2E04320", Offset = "0x2E02F20", VA = "0x182E04320", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class BDVKSMELLVG : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2E02980", Offset = "0x2E01580", VA = "0x182E02980")]
		public BDVKSMELLVG(Id32<JQPVMRMCZNG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2E02910", Offset = "0x2E01510", VA = "0x182E02910", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class MTKXNQNEGOE : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly Id32<AWZVWRTEXTC> QEDDRQKNBVY;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2E02A50", Offset = "0x2E01650", VA = "0x182E02A50")]
		public MTKXNQNEGOE(Id32<JQPVMRMCZNG> a, Id32<AWZVWRTEXTC> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E04280", Offset = "0x2E02E80", VA = "0x182E04280", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class MBKYCIVLEUR : NJKZNHRVAZM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly Id32<TZJZKVJCHTJ> EFRVMJXRBVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly Id32<TZJZKVJCHTJ> DVPTTPCUHWT;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2E04230", Offset = "0x2E02E30", VA = "0x182E04230")]
		internal MBKYCIVLEUR(Id32<TZJZKVJCHTJ> a, Id32<JQPVMRMCZNG> b, Id32<TZJZKVJCHTJ> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2E041B0", Offset = "0x2E02DB0", VA = "0x182E041B0")]
		public static MBKYCIVLEUR New(Id32<TZJZKVJCHTJ> expectedDefId, Id32<JQPVMRMCZNG> graphId, Id32<TZJZKVJCHTJ> actualDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2E04010", Offset = "0x2E02C10", VA = "0x182E04010", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class ODNHXJDXFKJ : NJKZNHRVAZM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Id32<TFITIOWUSRJ> EFRVMJXRBVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly Id32<TFITIOWUSRJ> DVPTTPCUHWT;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2E04820", Offset = "0x2E03420", VA = "0x182E04820")]
		internal ODNHXJDXFKJ(Id32<TFITIOWUSRJ> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<TFITIOWUSRJ> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E04790", Offset = "0x2E03390", VA = "0x182E04790")]
		public static ODNHXJDXFKJ New(Id32<TFITIOWUSRJ> expectedDefId, Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<TFITIOWUSRJ> actualDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E04590", Offset = "0x2E03190", VA = "0x182E04590", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class GHKZKWQJQEO<a> : NJKZNHRVAZM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly Id32<a> XJCJSTQKCJJ;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2E02A50", Offset = "0x2E01650", VA = "0x182E02A50")]
		public GHKZKWQJQEO(Id32<JQPVMRMCZNG> a, Id32<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x540BF90", Offset = "0x540AB90", VA = "0x18540BF90", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class BFHNXOCOZMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x38FCC80", Offset = "0x38FB880", VA = "0x1838FCC80")]
		public static GHKZKWQJQEO<TM> New<TM>(Id32<JQPVMRMCZNG> graphId, Id32<TM> virtId) where TM : EVGraph.LPCAELTSUGD
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class YLADPMOOUUE<a> : NJKZNHRVAZM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly Id32<a> XJCJSTQKCJJ;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2E04230", Offset = "0x2E02E30", VA = "0x182E04230")]
		internal YLADPMOOUUE(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, Id32<a> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4487EF0", Offset = "0x4486AF0", VA = "0x184487EF0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class IXXQZMBSLMT
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3C291D0", Offset = "0x3C27DD0", VA = "0x183C291D0")]
		public static YLADPMOOUUE<TM> New<TM>(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<TM> virtId) where TM : EVNode.LPCAELTSUGD
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class DBDCJIKIIOK : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2E02A50", Offset = "0x2E01650", VA = "0x182E02A50")]
		public DBDCJIKIIOK(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2E029B0", Offset = "0x2E015B0", VA = "0x182E029B0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class KPWSALSIRQU : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly Id32<TFITIOWUSRJ> ROGJAUITDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly Type ODQSNVAGAAT;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2E03FD0", Offset = "0x2E02BD0", VA = "0x182E03FD0")]
		public KPWSALSIRQU(Id32<TFITIOWUSRJ> a, Type b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2E03F70", Offset = "0x2E02B70", VA = "0x182E03F70", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class VANTJIRAIGU : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly int LQCXBBCCYRX;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2E05030", Offset = "0x2E03C30", VA = "0x182E05030")]
		public VANTJIRAIGU(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2E05320", Offset = "0x2E03F20", VA = "0x182E05320", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class QMCMCTVNYTT : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly int ZHOHBSYOXMM;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2E05030", Offset = "0x2E03C30", VA = "0x182E05030")]
		public QMCMCTVNYTT(Id32<JQPVMRMCZNG> a, Id32<LWYTCPIHOQE> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2E04F70", Offset = "0x2E03B70", VA = "0x182E04F70", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class NJIXNVMYALT : YFKOPUBUZRQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly Id32<IEQQYWIVYHH> TATDDECVBUF;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2E02A50", Offset = "0x2E01650", VA = "0x182E02A50")]
		public NJIXNVMYALT(Id32<JQPVMRMCZNG> a, Id32<IEQQYWIVYHH> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2E04470", Offset = "0x2E03070", VA = "0x182E04470", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class BAJJFIQAEGW : NJKZNHRVAZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2E028E0", Offset = "0x2E014E0", VA = "0x182E028E0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4DC0", Offset = "0x2DF39C0", VA = "0x182DF4DC0")]
		public BAJJFIQAEGW()
		{
		}
	}
}
namespace Circuits.Static.EV.Def
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class AVFTLOIEBMM<a> : OKCLJAZOSIM<a>, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OFMLSTORVPX(a a, Id32<JQPVMRMCZNG> b, RootInstantiation c, Id32<GraphInstantiation.M>? d);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void NASCZLCHALL(a a, Id32<JQPVMRMCZNG> b);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected AVFTLOIEBMM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class SKPGDRSWREE<a> : ZHOBCASHLNG<a>, IDisposable where a : DCZUNSBMGOL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "10")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void OFMLSTORVPX(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, RootInstantiation d, Id32<GraphInstantiation.M>? e);

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void NASCZLCHALL(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c);

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract IEnumerable<TypeParameter<IDLCASSILBG>> UZXFXLPRTHR(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract void WFVEBFVOYYM(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		public abstract Variant VZXTZLLFWNT(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d, IDLCASSILBG e);

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected SKPGDRSWREE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class KIXVCOYSOQY<a> : SKPGDRSWREE<a> where a : DCZUNSBMGOL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct IO : TAGFQEFGBIJ<IO, TypeParamsIODef>, TAGFQEFGBIJ<IO, InputDefs<a>>, TAGFQEFGBIJ<IO, OutputDefs>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public TypeParamsIODef TypeParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public InputDefs<a> Inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public OutputDefs Outputs;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x55642D0", Offset = "0x5562ED0", VA = "0x1855642D0")]
			private IO(TypeParamsIODef typeParams, InputDefs<a> inputs, OutputDefs outputs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5564200", Offset = "0x5562E00", VA = "0x185564200")]
			public static IO New()
			{
				return default(IO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "4")]
			private TypeParamsIODef ABHESASIRYI(IO a)
			{
				return default(TypeParamsIODef);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x55640F0", Offset = "0x5562CF0", VA = "0x1855640F0", Slot = "5")]
			private InputDefs<a> SOYIUKYGDRB(IO a)
			{
				return default(InputDefs<a>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x55640E0", Offset = "0x5562CE0", VA = "0x1855640E0", Slot = "6")]
			private OutputDefs VDMLFRUGMIO(IO a)
			{
				return default(OutputDefs);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		protected IO REMOKFNFUFE;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x43AB740", Offset = "0x43AA340", VA = "0x1843AB740")]
		protected KIXVCOYSOQY([In] IO io)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x43AAF30", Offset = "0x43A9B30", VA = "0x1843AAF30", Slot = "10")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		public override void NASCZLCHALL(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x581B400", Offset = "0x581A000", VA = "0x18581B400", Slot = "13")]
		public override IEnumerable<TypeParameter<IDLCASSILBG>> UZXFXLPRTHR(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x581B4E0", Offset = "0x581A0E0", VA = "0x18581B4E0", Slot = "15")]
		public override Variant VZXTZLLFWNT(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d, IDLCASSILBG e)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x581B840", Offset = "0x581A440", VA = "0x18581B840")]
		public static IOFactory<IO, JZBAJUEKHWB<a, DWBBZVTXQMG>> ZOPBFRATFIS()
		{
			return default(IOFactory<IO, JZBAJUEKHWB<a, DWBBZVTXQMG>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class MTYWBQCECCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0150", Offset = "0x3CAED50", VA = "0x183CB0150")]
		public static void Destroy<TRoot>(this KIXVCOYSOQY<TRoot>.IO self) where TRoot : DCZUNSBMGOL<TRoot>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3D05230", Offset = "0x3D03E30", VA = "0x183D05230")]
		public static void OFMLSTORVPX<a>(this KIXVCOYSOQY<a>.IO a, EVStaticStateSys<a> b, Id32<JQPVMRMCZNG> c, Id32<LWYTCPIHOQE> d) where a : DCZUNSBMGOL<a>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3D056D0", Offset = "0x3D042D0", VA = "0x183D056D0")]
		public static void WFVEBFVOYYM<b>(this KIXVCOYSOQY<b>.IO a, EVStaticStateSys<b> b, Id32<JQPVMRMCZNG> c, Id32<LWYTCPIHOQE> d) where b : DCZUNSBMGOL<b>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class FUMYHVGXUYX
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public sealed class None<TRoot> : RIDFBVQUFTB<TRoot> where TRoot : WUFFHWSZOIM
		{
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly None<TRoot> CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private None()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x6060B80", Offset = "0x605F780", VA = "0x186060B80", Slot = "4")]
			public Variant New(TRoot root, Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<VPKCJSHTFFF> inputDefId, IDLCASSILBG inferredType)
			{
				return default(Variant);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface RIDFBVQUFTB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Variant New(a root, Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<VPKCJSHTFFF> inputDefId, IDLCASSILBG inferredType);
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface JBQLXIBLINW<a> where a : DCZUNSBMGOL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM> FRCWOADHLLS(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct InputDef<TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly IDLCASSILBG Type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly RIDFBVQUFTB<TRoot> DefaultValueNew;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2167760", Offset = "0x2166360", VA = "0x182167760")]
		internal InputDef(string name, IDLCASSILBG type, RIDFBVQUFTB<TRoot> defaultValueNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class NOBCZHTAQES
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9930", Offset = "0x3DB8530", VA = "0x183DB9930")]
		public static InputDef<TRoot> New<TRoot>(string name, IDLCASSILBG type, RIDFBVQUFTB<TRoot> defaultValueNew)
		{
			return default(InputDef<TRoot>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct InputDefs<TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IdUnsafeList<VPKCJSHTFFF, InputDef<TRoot>> Defs;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private InputDefs([In] IdUnsafeList<VPKCJSHTFFF, InputDef<TRoot>> defs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x55AE430", Offset = "0x55AD030", VA = "0x1855AE430")]
		public static InputDefs<TRoot> New()
		{
			return default(InputDefs<TRoot>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class IUBXDJTGXXJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB2E0", Offset = "0x3AD9EE0", VA = "0x183ADB2E0")]
		public static void Destroy<TRoot>(this InputDefs<TRoot> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3C277F0", Offset = "0x3C263F0", VA = "0x183C277F0")]
		public static void BTZTXBRFJHS<a>([In] this InputDefs<a> self, EVStaticStateSys<a> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c) where a : DCZUNSBMGOL<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class RIRHSDNWTVJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F150", Offset = "0x3F1DD50", VA = "0x183F1F150")]
		public static IOFactory<TIO, JZBAJUEKHWB<TRoot, QVAGNHQPTTL>> In<TIO, TRoot, TMarker>(this IOFactory<TIO, JZBAJUEKHWB<TRoot, TMarker>> self, string name, CircuitTypeOrString type, [Out] Id32<VPKCJSHTFFF> defId) where TIO : TAGFQEFGBIJ<TIO, InputDefs<TRoot>> where TRoot : WUFFHWSZOIM where TMarker : QVAGNHQPTTL
		{
			return default(IOFactory<TIO, JZBAJUEKHWB<TRoot, QVAGNHQPTTL>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public readonly struct InputGroupDef<TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly InputDef<TRoot> Def;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly int Min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public readonly int Max;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x55AEC70", Offset = "0x55AD870", VA = "0x1855AEC70")]
		internal InputGroupDef([In] InputDef<TRoot> def, int min, int max)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class ZESSOGYDMQB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x41F09B0", Offset = "0x41EF5B0", VA = "0x1841F09B0")]
		public static InputGroupDef<TRoot> New<TRoot>([In] InputDef<TRoot> def, int min, int max)
		{
			return default(InputGroupDef<TRoot>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x41F08C0", Offset = "0x41EF4C0", VA = "0x1841F08C0")]
		public static void FJOHXZVMCJZ<a>([In] this InputGroupDef<a> self, EVStaticStateSys<a> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d) where a : DCZUNSBMGOL<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct InputGroupDefs<TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IdUnsafeList<VPKCJSHTFFF, InputGroupDef<TRoot>> Defs;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private InputGroupDefs([In] IdUnsafeList<VPKCJSHTFFF, InputGroupDef<TRoot>> defs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x55AE430", Offset = "0x55AD030", VA = "0x1855AE430")]
		public static InputGroupDefs<TRoot> New()
		{
			return default(InputGroupDefs<TRoot>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class EPLVGWRLZCO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB2E0", Offset = "0x3AD9EE0", VA = "0x183ADB2E0")]
		public static void Destroy<TRoot>(this InputGroupDefs<TRoot> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAFF0", Offset = "0x3AD9BF0", VA = "0x183ADAFF0")]
		public static Id32<InputGroups.M> BTZTXBRFJHS<a>([In] this InputGroupDefs<a> self, EVStaticStateSys<a> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c) where a : DCZUNSBMGOL<a>
		{
			return default(Id32<InputGroups.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3ADB3E0", Offset = "0x3AD9FE0", VA = "0x183ADB3E0")]
		public static void QPSEOTHBFSM<b>(EVStaticStateSys<b> a, Id32<JQPVMRMCZNG> b, Id32<InputGroups.M> c) where b : DCZUNSBMGOL<b>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class XVWDEZJEVEE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x41E2230", Offset = "0x41E0E30", VA = "0x1841E2230")]
		public static IOFactory<TIO, JZBAJUEKHWB<TRoot, QVAGNHQPTTL>> In<TIO, TRoot, TMarker>(this IOFactory<TIO, JZBAJUEKHWB<TRoot, TMarker>> self, string name, CircuitTypeOrString type, [Out] Id32<VPKCJSHTFFF> defId, int min = 1, int max = 1) where TIO : TAGFQEFGBIJ<TIO, InputGroupDefs<TRoot>> where TRoot : WUFFHWSZOIM where TMarker : QVAGNHQPTTL
		{
			return default(IOFactory<TIO, JZBAJUEKHWB<TRoot, QVAGNHQPTTL>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct InputGroups
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public sealed class M : EVNode.LPCAELTSUGD
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IdUnsafeList<VPKCJSHTFFF, int> InputGroupStarts;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private InputGroups([In] IdUnsafeList<VPKCJSHTFFF, int> inputGroupStarts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2E02EA0", Offset = "0x2E01AA0", VA = "0x182E02EA0")]
		public static InputGroups HVKYDMYBGAZ([In] IdUnsafeList<VPKCJSHTFFF, int> inputGroupStarts)
		{
			return default(InputGroups);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class YQWZBCRSHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2E05C30", Offset = "0x2E04830", VA = "0x182E05C30")]
		public static void Destroy(this InputGroups self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2E05C70", Offset = "0x2E04870", VA = "0x182E05C70")]
		public static int VAGSESCHUMX([In] this InputGroups self, Id32<VPKCJSHTFFF> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2E05D40", Offset = "0x2E04940", VA = "0x182E05D40")]
		public static int WVAWGYRAUVR([In] this InputGroups self, Id32<VPKCJSHTFFF> a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public abstract class CMPUBHBKLVH<a> : SKPGDRSWREE<a>, JBQLXIBLINW<a> where a : DCZUNSBMGOL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public struct IO : TAGFQEFGBIJ<IO, TypeParamsIODef>, TAGFQEFGBIJ<IO, InputGroupDefs<a>>, TAGFQEFGBIJ<IO, OutputDefs>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public TypeParamsIODef TypeParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public InputGroupDefs<a> Inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public OutputDefs Outputs;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x55642D0", Offset = "0x5562ED0", VA = "0x1855642D0")]
			private IO(TypeParamsIODef typeParams, InputGroupDefs<a> inputs, OutputDefs outputs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x5564200", Offset = "0x5562E00", VA = "0x185564200")]
			public static IO New()
			{
				return default(IO);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "4")]
			private TypeParamsIODef VPGZLUIORLP(IO a)
			{
				return default(TypeParamsIODef);
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x55640F0", Offset = "0x5562CF0", VA = "0x1855640F0", Slot = "5")]
			private InputGroupDefs<a> NHAFDZIMTOH(IO a)
			{
				return default(InputGroupDefs<a>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x55640E0", Offset = "0x5562CE0", VA = "0x1855640E0", Slot = "6")]
			private OutputDefs IEISNWARGPL(IO a)
			{
				return default(OutputDefs);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected IO REMOKFNFUFE;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x43AB740", Offset = "0x43AA340", VA = "0x1843AB740")]
		protected CMPUBHBKLVH([In] IO io)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x43AAF30", Offset = "0x43A9B30", VA = "0x1843AAF30", Slot = "10")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x43AAFE0", Offset = "0x43A9BE0", VA = "0x1843AAFE0")]
		public static void NASCZLCHALL(EVStaticStateSys<a> a, Id32<JQPVMRMCZNG> b, Id32<InputGroups.M> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x43AB0C0", Offset = "0x43A9CC0", VA = "0x1843AB0C0", Slot = "13")]
		public override IEnumerable<TypeParameter<IDLCASSILBG>> UZXFXLPRTHR(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x43AB3A0", Offset = "0x43A9FA0", VA = "0x1843AB3A0", Slot = "15")]
		public override Variant VZXTZLLFWNT(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d, IDLCASSILBG e)
		{
			return default(Variant);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM> FRCWOADHLLS(a a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c, Id32<VPKCJSHTFFF> d);

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x43AB630", Offset = "0x43AA230", VA = "0x1843AB630")]
		public static IOFactory<IO, JZBAJUEKHWB<a, DWBBZVTXQMG>> ZOPBFRATFIS()
		{
			return default(IOFactory<IO, JZBAJUEKHWB<a, DWBBZVTXQMG>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class LNPNTOWMUXD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0150", Offset = "0x3CAED50", VA = "0x183CB0150")]
		public static void Destroy<TRoot>(this CMPUBHBKLVH<TRoot>.IO self) where TRoot : DCZUNSBMGOL<TRoot>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1110", Offset = "0x3CAFD10", VA = "0x183CB1110")]
		public static Id32<InputGroups.M> OFMLSTORVPX<a>(this CMPUBHBKLVH<a>.IO a, EVStaticStateSys<a> b, Id32<JQPVMRMCZNG> c, Id32<LWYTCPIHOQE> d) where a : DCZUNSBMGOL<a>
		{
			return default(Id32<InputGroups.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1500", Offset = "0x3CB0100", VA = "0x183CB1500")]
		public static void WFVEBFVOYYM<b>(this CMPUBHBKLVH<b>.IO a, EVStaticStateSys<b> b, Id32<JQPVMRMCZNG> c, Id32<LWYTCPIHOQE> d) where b : DCZUNSBMGOL<b>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0FE0", Offset = "0x3CAFBE0", VA = "0x183CB0FE0")]
		public static void KSJLLUTNRHV<c>([In] this CMPUBHBKLVH<c>.IO self, EVInput a) where c : DCZUNSBMGOL<c>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0F50", Offset = "0x3CAFB50", VA = "0x183CB0F50")]
		public static void KSJLLUTNRHV<d>([In] this CMPUBHBKLVH<d>.IO io, EVOutput a) where d : DCZUNSBMGOL<d>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0880", Offset = "0x3CAF480", VA = "0x183CB0880")]
		public static Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM> FRCWOADHLLS<e>([In] this CMPUBHBKLVH<e>.IO self, e a, EVStaticStateSys<e> b, Id32<JQPVMRMCZNG> c, Id32<LWYTCPIHOQE> d, Id32<InputGroups.M> e, Id32<VPKCJSHTFFF> f) where e : DCZUNSBMGOL<e>
		{
			return default(Result<Id32<AWZVWRTEXTC>, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct IOFactory<TIO, TOther>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TIO IO;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4641D40", Offset = "0x4640940", VA = "0x184641D40")]
		internal IOFactory([In] TIO io)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class NYDXKSNWKTI<c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x350B880", Offset = "0x350A480", VA = "0x18350B880")]
		public static IOFactory<TIO, c> New<TIO>([In] TIO io)
		{
			return default(IOFactory<TIO, c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x41B2EB0", Offset = "0x41B1AB0", VA = "0x1841B2EB0")]
		public static IOFactory<a, c> HBKWCAIDTVY<a, b>([In] IOFactory<a, b> self)
		{
			return default(IOFactory<a, c>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class FSWBMKCAUXT
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3BA5AE0", Offset = "0x3BA46E0", VA = "0x183BA5AE0")]
		public static a EWICREVRZTI<a, b>([In] this IOFactory<a, b> self)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public interface TAGFQEFGBIJ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b KQOSLVROLKZ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class QVAGNHQPTTL : TCOAKVOEAAC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class TCOAKVOEAAC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class DWBBZVTXQMG : QVAGNHQPTTL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct OutputDef
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly IDLCASSILBG Type;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
		internal OutputDef(string name, IDLCASSILBG type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2D63CF0", Offset = "0x2D628F0", VA = "0x182D63CF0")]
		public static OutputDef New(string name, IDLCASSILBG type)
		{
			return default(OutputDef);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct OutputDefs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public IdUnsafeList<TIEJMITYOHO, OutputDef> Defs;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private OutputDefs([In] IdUnsafeList<TIEJMITYOHO, OutputDef> defs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2E04970", Offset = "0x2E03570", VA = "0x182E04970")]
		public static OutputDefs New()
		{
			return default(OutputDefs);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class XAAKTFVFCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2E05BF0", Offset = "0x2E047F0", VA = "0x182E05BF0")]
		public static void Destroy(this OutputDefs self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x41C4AD0", Offset = "0x41C36D0", VA = "0x1841C4AD0")]
		public static void HXAGSEKRLNT<a>([In] this OutputDefs self, EVStaticStateSys<a> a, Id32<JQPVMRMCZNG> b, Id32<LWYTCPIHOQE> c) where a : DCZUNSBMGOL<a>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class PKLZQIAXMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3E13810", Offset = "0x3E12410", VA = "0x183E13810")]
		public static IOFactory<TIO, JZBAJUEKHWB<TRoot, TCOAKVOEAAC>> Out<TIO, TRoot, TMarker>(this IOFactory<TIO, JZBAJUEKHWB<TRoot, TMarker>> self, string name, CircuitTypeOrString type, [Out] Id32<TIEJMITYOHO> defId) where TIO : TAGFQEFGBIJ<TIO, OutputDefs> where TMarker : TCOAKVOEAAC
		{
			return default(IOFactory<TIO, JZBAJUEKHWB<TRoot, TCOAKVOEAAC>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct OutputGroups
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class M : EVNode.LPCAELTSUGD
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IdUnsafeList<TIEJMITYOHO, int> OutputGroupStarts;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private OutputGroups([In] IdUnsafeList<TIEJMITYOHO, int> outputGroupStarts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2E02EA0", Offset = "0x2E01AA0", VA = "0x182E02EA0")]
		public static OutputGroups HVKYDMYBGAZ([In] IdUnsafeList<TIEJMITYOHO, int> outputGroupStarts)
		{
			return default(OutputGroups);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class DKYHBZQFSVF
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2E02A90", Offset = "0x2E01690", VA = "0x182E02A90")]
		public static void Destroy(this OutputGroups self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class JZBAJUEKHWB<a, b>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct TypeParamsIODef
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public UnsafeList<TypeParameter<IDLCASSILBG>> TypeParameters;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private TypeParamsIODef([In] UnsafeList<TypeParameter<IDLCASSILBG>> typeParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2E052C0", Offset = "0x2E03EC0", VA = "0x182E052C0")]
		public static TypeParamsIODef New()
		{
			return default(TypeParamsIODef);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class OEKPGWSTRIV
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2E04870", Offset = "0x2E03470", VA = "0x182E04870")]
		public static void Destroy(this TypeParamsIODef self)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class GLHGMOXXPEQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5DC0", Offset = "0x3BC49C0", VA = "0x183BC5DC0")]
		public static IOFactory<a, JZBAJUEKHWB<b, DWBBZVTXQMG>> TSLRBKBRVTQ<a, b, c>(this IOFactory<a, JZBAJUEKHWB<b, c>> a, string b, IDLCASSILBG c) where a : TAGFQEFGBIJ<a, TypeParamsIODef> where c : DWBBZVTXQMG
		{
			return default(IOFactory<a, JZBAJUEKHWB<b, DWBBZVTXQMG>>);
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
