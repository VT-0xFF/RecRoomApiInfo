using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1B50", Offset = "0x1DF0F50", VA = "0x181DF1B50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate ENAFKGLNMAF<TActionKind, TPayload> COKOLKJMNKJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction FEJAIGODDEB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface DPHJIIEEHAB<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OJIJNKCPBAD<object, DMJBJKNNALA>> KFNCKMLFHKL(TDeps IGMHAFBOHAM, TRoot BEOJJJNJFFJ, TSerializedAction FEJAIGODDEB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JDJAMHFACOC<TActionKind, TSerializedAction, TRoot, TDeps> : LPMKDKJGPIA where TDeps : FMOKEMPCLEN.ADHADMHPJEC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps ECGBFCNDIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction JPIEOOGJPOB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B58B40", Offset = "0x3B57F40", VA = "0x183B58B40")]
	public JDJAMHFACOC([In] TDeps IGMHAFBOHAM, [In] TSerializedAction FEJAIGODDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B58970", Offset = "0x3B57D70", VA = "0x183B58970", Slot = "7")]
	public override string PEMDIIHBGJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ENAFKGLNMAF<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind GPKNNFEDHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload DLBBFFKEPNA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x336BB00", Offset = "0x336AF00", VA = "0x18336BB00")]
	internal ENAFKGLNMAF(TActionKind FOAFEOIHIDD, [In] TPayload KJOCNIDJGCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JPEMABLHGNP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2847F00", Offset = "0x2847300", VA = "0x182847F00")]
	public static ENAFKGLNMAF<TActionKind, TPayload> HGJFOBLHCKL<TActionKind, TPayload>([In] TActionKind FOAFEOIHIDD, [In] TPayload KJOCNIDJGCN)
	{
		return default(ENAFKGLNMAF<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<OJIJNKCPBAD<TOk, TErr>> CDLKIICGOPM<TRoot, TPayload, TOk, TErr>(TRoot BEOJJJNJFFJ, TPayload KJOCNIDJGCN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate OJIJNKCPBAD<TOk, TErr> KNGIFEGMHCK<TRoot, TPayload, TOk, TErr>(TRoot BEOJJJNJFFJ, [In] TPayload KJOCNIDJGCN);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct EPJNPKAONHE<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : FMOKEMPCLEN.ADHADMHPJEC<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GNEBKGMEDIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public EPJNPKAONHE<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x37EF9A0", Offset = "0x37EEDA0", VA = "0x1837EF9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37F02C0", Offset = "0x37EF6C0", VA = "0x1837F02C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, DPHJIIEEHAB<TSerializedAction, TRoot, TDeps>> APLPFDJEODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps ECGBFCNDIAL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x90E910", Offset = "0x90DD10", VA = "0x18090E910")]
	internal EPJNPKAONHE(Dictionary<TActionKind, DPHJIIEEHAB<TSerializedAction, TRoot, TDeps>> FFPOHICFPIF, TDeps IGMHAFBOHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x337AA20", Offset = "0x3379E20", VA = "0x18337AA20")]
	[AsyncStateMachine(typeof(EPJNPKAONHE<, , , >.GNEBKGMEDIK))]
	public Task<OJIJNKCPBAD<object, DMJBJKNNALA>> KFNCKMLFHKL(TRoot BEOJJJNJFFJ, TSerializedAction FEJAIGODDEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FMOKEMPCLEN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ADHADMHPJEC<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind LEFPOPBMPLN(TSerializedAction MEEBIDIALDO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CJAHMENKHOK(TRoot BEOJJJNJFFJ, TSerializedAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GLDEHGAHDKI(TRoot BEOJJJNJFFJ, TSerializedAction PNAPELFIIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27DA1A0", Offset = "0x27D95A0", VA = "0x1827DA1A0")]
	internal static EPJNPKAONHE<TActionKind, TSerializedAction, TRoot, TDeps> HGJFOBLHCKL<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, DPHJIIEEHAB<TSerializedAction, TRoot, TDeps>> FFPOHICFPIF, TDeps IGMHAFBOHAM) where TDeps : ADHADMHPJEC<TActionKind, TSerializedAction, TRoot>
	{
		return default(EPJNPKAONHE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NKHEFFEDEBM<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, DPHJIIEEHAB<TSerializedAction, TRoot, TDeps>> CAKLPMKLMHK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	private NKHEFFEDEBM(Dictionary<TActionKind, DPHJIIEEHAB<TSerializedAction, TRoot, TDeps>> FFPOHICFPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3260", Offset = "0x3FD2660", VA = "0x183FD3260")]
	public static NKHEFFEDEBM<TActionKind, TSerializedAction, TRoot, TDeps> HGJFOBLHCKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IEBEPCNDCNP<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, FMOKEMPCLEN.ADHADMHPJEC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NHMJHIKEENL<TPayload, TOk, TErr> : DPHJIIEEHAB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DMJBJKNNALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly COKOLKJMNKJ<TActionKind, TSerializedAction, TPayload> ALJBBEFIOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KNGIFEGMHCK<TRoot, TPayload, TOk, TErr> KIABPONKCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool KFBCOGHPMGE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x392F200", Offset = "0x392E600", VA = "0x18392F200")]
		public NHMJHIKEENL(COKOLKJMNKJ<TActionKind, TSerializedAction, TPayload> MCJBBIKLLIP, KNGIFEGMHCK<TRoot, TPayload, TOk, TErr> BINKKCIDFBB, bool GJPIKGOBOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3FBB5E0", Offset = "0x3FBA9E0", VA = "0x183FBB5E0", Slot = "4")]
		public Task<OJIJNKCPBAD<object, DMJBJKNNALA>> KFNCKMLFHKL(TDeps IGMHAFBOHAM, TRoot BEOJJJNJFFJ, TSerializedAction FEJAIGODDEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class AHGIMLFIGMP<TPayload, TOk, TErr> : DPHJIIEEHAB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DMJBJKNNALA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PMHHLIGOOEC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<OJIJNKCPBAD<object?, DMJBJKNNALA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AHGIMLFIGMP<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private OJIJNKCPBAD<object?, DMJBJKNNALA> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OJIJNKCPBAD<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x41B8DD0", Offset = "0x41B81D0", VA = "0x1841B8DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x41B9390", Offset = "0x41B8790", VA = "0x1841B9390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly COKOLKJMNKJ<TActionKind, TSerializedAction, TPayload> ALJBBEFIOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CDLKIICGOPM<TRoot, TPayload, TOk, TErr> KIABPONKCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool KFBCOGHPMGE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x392F200", Offset = "0x392E600", VA = "0x18392F200")]
		public AHGIMLFIGMP(COKOLKJMNKJ<TActionKind, TSerializedAction, TPayload> MCJBBIKLLIP, CDLKIICGOPM<TRoot, TPayload, TOk, TErr> BINKKCIDFBB, bool GJPIKGOBOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x392EC80", Offset = "0x392E080", VA = "0x18392EC80", Slot = "4")]
		[AsyncStateMachine(typeof(AHGIMLFIGMP<, , >.PMHHLIGOOEC))]
		public Task<OJIJNKCPBAD<object, DMJBJKNNALA>> KFNCKMLFHKL(TDeps IGMHAFBOHAM, TRoot BEOJJJNJFFJ, TSerializedAction FEJAIGODDEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NKHEFFEDEBM<TActionKind, TSerializedAction, TRoot, TDeps> CPFCAALFHAC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	private IEBEPCNDCNP(NKHEFFEDEBM<TActionKind, TSerializedAction, TRoot, TDeps> FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x39A2C70", Offset = "0x39A2070", VA = "0x1839A2C70")]
	public static IEBEPCNDCNP<TActionKind, TSerializedAction, TRoot, TDeps> HGJFOBLHCKL()
	{
		return default(IEBEPCNDCNP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x24AFCA0", Offset = "0x24AF0A0", VA = "0x1824AFCA0")]
	public IEBEPCNDCNP<TActionKind, TSerializedAction, TRoot, TDeps> DEFOIJPGNHF<TPayload, TOk, TErr>(TActionKind FOAFEOIHIDD, COKOLKJMNKJ<TActionKind, TSerializedAction, TPayload> MCJBBIKLLIP, KNGIFEGMHCK<TRoot, TPayload, TOk, TErr> BINKKCIDFBB, bool GJPIKGOBOGC = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DMJBJKNNALA
	{
		return default(IEBEPCNDCNP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x24AFCA0", Offset = "0x24AF0A0", VA = "0x1824AFCA0")]
	public IEBEPCNDCNP<TActionKind, TSerializedAction, TRoot, TDeps> JFEPCHKAPMJ<TPayload, TOk, TErr>(TActionKind FOAFEOIHIDD, COKOLKJMNKJ<TActionKind, TSerializedAction, TPayload> MCJBBIKLLIP, CDLKIICGOPM<TRoot, TPayload, TOk, TErr> BINKKCIDFBB, bool GJPIKGOBOGC = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DMJBJKNNALA
	{
		return default(IEBEPCNDCNP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x39A2BC0", Offset = "0x39A1FC0", VA = "0x1839A2BC0")]
	public EPJNPKAONHE<TActionKind, TSerializedAction, TRoot, TDeps> BEFCIIIMLEJ(TDeps IGMHAFBOHAM)
	{
		return default(EPJNPKAONHE<TActionKind, TSerializedAction, TRoot, TDeps>);
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
