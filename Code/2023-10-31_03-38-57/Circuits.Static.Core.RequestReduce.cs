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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C679A0", Offset = "0x1C66DA0", VA = "0x181C679A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate OLCAOPJKNCE<TActionKind, TPayload> CAEOANDBJJK<TActionKind, TSerializedAction, TPayload>(TSerializedAction OLGNLGBFLAE);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface ENAABPMJLBI<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KJFLOMPEKGD<object, FILGPPIJBDI>> HJPIADCIHGJ(TDeps PGFIMHKNEFE, TRoot OGEFIHKILIO, TSerializedAction OLGNLGBFLAE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JNKEOADAMEB<TActionKind, TSerializedAction, TRoot, TDeps> : ECGJNMBGCNE where TDeps : DAFFCANNAMC.JMFJFIHHBLD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps CKJHGMFLIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction JLPLEFAPKOG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x385FF40", Offset = "0x385F340", VA = "0x18385FF40")]
	public JNKEOADAMEB([In] TDeps PGFIMHKNEFE, [In] TSerializedAction OLGNLGBFLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x385FD10", Offset = "0x385F110", VA = "0x18385FD10", Slot = "7")]
	public override string NKDBAIBOPIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OLCAOPJKNCE<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind MDPJHCKGPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload FLNAJJJHBHK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF6780", Offset = "0x3CF5B80", VA = "0x183CF6780")]
	internal OLCAOPJKNCE(TActionKind BFEKDIMDJAP, [In] TPayload HEFGEKEDAKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CBFHMFEGJKB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22018A0", Offset = "0x2200CA0", VA = "0x1822018A0")]
	public static OLCAOPJKNCE<TActionKind, TPayload> LJCGEPFBFCG<TActionKind, TPayload>([In] TActionKind BFEKDIMDJAP, [In] TPayload HEFGEKEDAKE)
	{
		return default(OLCAOPJKNCE<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<KJFLOMPEKGD<TOk, TErr>> KPHBKPMELOD<TRoot, TPayload, TOk, TErr>(TRoot OGEFIHKILIO, TPayload HEFGEKEDAKE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate KJFLOMPEKGD<TOk, TErr> KCJHHJNMMIG<TRoot, TPayload, TOk, TErr>(TRoot OGEFIHKILIO, [In] TPayload HEFGEKEDAKE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct POGJLGPLNCB<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : DAFFCANNAMC.JMFJFIHHBLD<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DHPBEFKIKHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<KJFLOMPEKGD<object, FILGPPIJBDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public POGJLGPLNCB<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<KJFLOMPEKGD<object, FILGPPIJBDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4C92E20", Offset = "0x4C92220", VA = "0x184C92E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4C932B0", Offset = "0x4C926B0", VA = "0x184C932B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, ENAABPMJLBI<TSerializedAction, TRoot, TDeps>> LIBFBBLJENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps CKJHGMFLIJD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC80", Offset = "0x7EF080", VA = "0x1807EFC80")]
	internal POGJLGPLNCB(Dictionary<TActionKind, ENAABPMJLBI<TSerializedAction, TRoot, TDeps>> DKDGBIFKAOF, TDeps PGFIMHKNEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E108D0", Offset = "0x3E0FCD0", VA = "0x183E108D0")]
	[AsyncStateMachine(typeof(POGJLGPLNCB<, , , >.DHPBEFKIKHG))]
	public Task<KJFLOMPEKGD<object, FILGPPIJBDI>> HJPIADCIHGJ(TRoot OGEFIHKILIO, TSerializedAction OLGNLGBFLAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DAFFCANNAMC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JMFJFIHHBLD<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind HEHLJKDILCG(TSerializedAction LDMHFMNLDHG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HGEMMMAGCHH(TRoot OGEFIHKILIO, TSerializedAction GMCEKENFDDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x222CE40", Offset = "0x222C240", VA = "0x18222CE40")]
	internal static POGJLGPLNCB<TActionKind, TSerializedAction, TRoot, TDeps> LJCGEPFBFCG<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, ENAABPMJLBI<TSerializedAction, TRoot, TDeps>> DKDGBIFKAOF, TDeps PGFIMHKNEFE) where TDeps : JMFJFIHHBLD<TActionKind, TSerializedAction, TRoot>
	{
		return default(POGJLGPLNCB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class AANOJBHHNBM<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, ENAABPMJLBI<TSerializedAction, TRoot, TDeps>> PHMENAHDGNH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
	private AANOJBHHNBM(Dictionary<TActionKind, ENAABPMJLBI<TSerializedAction, TRoot, TDeps>> DKDGBIFKAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3450800", Offset = "0x344FC00", VA = "0x183450800")]
	public static AANOJBHHNBM<TActionKind, TSerializedAction, TRoot, TDeps> LJCGEPFBFCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OABEMPBBNFG<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, DAFFCANNAMC.JMFJFIHHBLD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PKOEKOENNCG<TPayload, TOk, TErr> : ENAABPMJLBI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FILGPPIJBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CAEOANDBJJK<TActionKind, TSerializedAction, TPayload> EINBLKAPDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KCJHHJNMMIG<TRoot, TPayload, TOk, TErr> JDAHMOCBDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool MGPFFMEHNIE;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7560", Offset = "0x3DE6960", VA = "0x183DE7560")]
		public PKOEKOENNCG(CAEOANDBJJK<TActionKind, TSerializedAction, TPayload> HJLEAGNIPNL, KCJHHJNMMIG<TRoot, TPayload, TOk, TErr> OBJNMHHKBBH, bool CJOCEJLIKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEBA00", Offset = "0x3DEAE00", VA = "0x183DEBA00", Slot = "4")]
		public Task<KJFLOMPEKGD<object, FILGPPIJBDI>> HJPIADCIHGJ(TDeps PGFIMHKNEFE, TRoot OGEFIHKILIO, TSerializedAction OLGNLGBFLAE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class PKIENDCAGBJ<TPayload, TOk, TErr> : ENAABPMJLBI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FILGPPIJBDI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BJAOIMODLEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<KJFLOMPEKGD<object?, FILGPPIJBDI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PKIENDCAGBJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private KJFLOMPEKGD<object?, FILGPPIJBDI> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<KJFLOMPEKGD<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4847D60", Offset = "0x4847160", VA = "0x184847D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x48487A0", Offset = "0x4847BA0", VA = "0x1848487A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly CAEOANDBJJK<TActionKind, TSerializedAction, TPayload> EINBLKAPDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly KPHBKPMELOD<TRoot, TPayload, TOk, TErr> JDAHMOCBDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool MGPFFMEHNIE;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7560", Offset = "0x3DE6960", VA = "0x183DE7560")]
		public PKIENDCAGBJ(CAEOANDBJJK<TActionKind, TSerializedAction, TPayload> HJLEAGNIPNL, KPHBKPMELOD<TRoot, TPayload, TOk, TErr> OBJNMHHKBBH, bool CJOCEJLIKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6E80", Offset = "0x3DE6280", VA = "0x183DE6E80", Slot = "4")]
		[AsyncStateMachine(typeof(PKIENDCAGBJ<, , >.BJAOIMODLEA))]
		public Task<KJFLOMPEKGD<object, FILGPPIJBDI>> HJPIADCIHGJ(TDeps PGFIMHKNEFE, TRoot OGEFIHKILIO, TSerializedAction OLGNLGBFLAE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly AANOJBHHNBM<TActionKind, TSerializedAction, TRoot, TDeps> JGOBHHHIFJO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E8520", Offset = "0x7E7920", VA = "0x1807E8520")]
	private OABEMPBBNFG(AANOJBHHNBM<TActionKind, TSerializedAction, TRoot, TDeps> GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD41E0", Offset = "0x3CD35E0", VA = "0x183CD41E0")]
	public static OABEMPBBNFG<TActionKind, TSerializedAction, TRoot, TDeps> LJCGEPFBFCG()
	{
		return default(OABEMPBBNFG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22D6770", Offset = "0x22D5B70", VA = "0x1822D6770")]
	public OABEMPBBNFG<TActionKind, TSerializedAction, TRoot, TDeps> PECCGKAPAGF<TPayload, TOk, TErr>(TActionKind BFEKDIMDJAP, CAEOANDBJJK<TActionKind, TSerializedAction, TPayload> HJLEAGNIPNL, KCJHHJNMMIG<TRoot, TPayload, TOk, TErr> OBJNMHHKBBH, bool CJOCEJLIKCF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FILGPPIJBDI
	{
		return default(OABEMPBBNFG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22D6770", Offset = "0x22D5B70", VA = "0x1822D6770")]
	public OABEMPBBNFG<TActionKind, TSerializedAction, TRoot, TDeps> HJNAMABFPKJ<TPayload, TOk, TErr>(TActionKind BFEKDIMDJAP, CAEOANDBJJK<TActionKind, TSerializedAction, TPayload> HJLEAGNIPNL, KPHBKPMELOD<TRoot, TPayload, TOk, TErr> OBJNMHHKBBH, bool CJOCEJLIKCF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FILGPPIJBDI
	{
		return default(OABEMPBBNFG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4130", Offset = "0x3CD3530", VA = "0x183CD4130")]
	public POGJLGPLNCB<TActionKind, TSerializedAction, TRoot, TDeps> HJCPNAFFHHJ(TDeps PGFIMHKNEFE)
	{
		return default(POGJLGPLNCB<TActionKind, TSerializedAction, TRoot, TDeps>);
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
