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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CBD370", Offset = "0x1CBC370", VA = "0x181CBD370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate DKALFGFBDMJ<TActionKind, TPayload> PDNMIGEDCFD<TActionKind, TSerializedAction, TPayload>(TSerializedAction FGEOLOOIAJH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface BIEDPLHNNAG<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CJDJPCEAKND<object, ONNOIFLMODG>> NJKOGBPOPLM(TDeps AKMCMCJGOCI, TRoot GLACNLFCFNI, TSerializedAction FGEOLOOIAJH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KNNMFDDBDFN<TActionKind, TSerializedAction, TRoot, TDeps> : GIOJECGONFO where TDeps : MBIJPFFIHDH.ELNNJAAEGCF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps ADEFBBLCDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction IKIHNOLEFPH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39D8F30", Offset = "0x39D7F30", VA = "0x1839D8F30")]
	public KNNMFDDBDFN([In] TDeps AKMCMCJGOCI, [In] TSerializedAction FGEOLOOIAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x39D8E00", Offset = "0x39D7E00", VA = "0x1839D8E00", Slot = "7")]
	public override string FNCBJKOJOIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DKALFGFBDMJ<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind MECBHGLIHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload OHKIHBLFAAG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4DBE5B0", Offset = "0x4DBD5B0", VA = "0x184DBE5B0")]
	internal DKALFGFBDMJ(TActionKind GGNOFOPBADK, [In] TPayload HPEDGLBMGED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FACGJEFPIPE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24CCD90", Offset = "0x24CBD90", VA = "0x1824CCD90")]
	public static DKALFGFBDMJ<TActionKind, TPayload> ANBAJJBGINK<TActionKind, TPayload>([In] TActionKind GGNOFOPBADK, [In] TPayload HPEDGLBMGED)
	{
		return default(DKALFGFBDMJ<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CJDJPCEAKND<TOk, TErr>> IEEKOBGDFJJ<TRoot, TPayload, TOk, TErr>(TRoot GLACNLFCFNI, TPayload HPEDGLBMGED);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CJDJPCEAKND<TOk, TErr> IPDEJMECDOE<TRoot, TPayload, TOk, TErr>(TRoot GLACNLFCFNI, [In] TPayload HPEDGLBMGED);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LOMIIICCNFM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : MBIJPFFIHDH.ELNNJAAEGCF<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AGPPKLHPJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<object, ONNOIFLMODG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LOMIIICCNFM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CJDJPCEAKND<object, ONNOIFLMODG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x355BCC0", Offset = "0x355ACC0", VA = "0x18355BCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x355C1C0", Offset = "0x355B1C0", VA = "0x18355C1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, BIEDPLHNNAG<TSerializedAction, TRoot, TDeps>> BLDAMDGBEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps ADEFBBLCDGG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E80", Offset = "0x7F6E80", VA = "0x1807F7E80")]
	internal LOMIIICCNFM(Dictionary<TActionKind, BIEDPLHNNAG<TSerializedAction, TRoot, TDeps>> EAFBBOLPOPB, TDeps AKMCMCJGOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B520", Offset = "0x3A9A520", VA = "0x183A9B520")]
	[AsyncStateMachine(typeof(LOMIIICCNFM<, , , >.AGPPKLHPJKJ))]
	public Task<CJDJPCEAKND<object, ONNOIFLMODG>> NJKOGBPOPLM(TRoot GLACNLFCFNI, TSerializedAction FGEOLOOIAJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MBIJPFFIHDH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ELNNJAAEGCF<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GCHCMKAAONB(TSerializedAction IEOMMHOPOKN);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NHJKEPPGJPC(TRoot GLACNLFCFNI, TSerializedAction NFDFJOBAEPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2356340", Offset = "0x2355340", VA = "0x182356340")]
	internal static LOMIIICCNFM<TActionKind, TSerializedAction, TRoot, TDeps> ANBAJJBGINK<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, BIEDPLHNNAG<TSerializedAction, TRoot, TDeps>> EAFBBOLPOPB, TDeps AKMCMCJGOCI) where TDeps : ELNNJAAEGCF<TActionKind, TSerializedAction, TRoot>
	{
		return default(LOMIIICCNFM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BABLBPELGCG<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, BIEDPLHNNAG<TSerializedAction, TRoot, TDeps>> NKEEFKMDLNJ;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	private BABLBPELGCG(Dictionary<TActionKind, BIEDPLHNNAG<TSerializedAction, TRoot, TDeps>> EAFBBOLPOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4529260", Offset = "0x4528260", VA = "0x184529260")]
	public static BABLBPELGCG<TActionKind, TSerializedAction, TRoot, TDeps> ANBAJJBGINK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OCDJEEBOCJM<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MBIJPFFIHDH.ELNNJAAEGCF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HEDELDFEAKG<TPayload, TOk, TErr> : BIEDPLHNNAG<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, ONNOIFLMODG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PDNMIGEDCFD<TActionKind, TSerializedAction, TPayload> NGJGGBHHEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly IPDEJMECDOE<TRoot, TPayload, TOk, TErr> HCBHACKMCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool PEOEEDCBJIF;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3605430", Offset = "0x3604430", VA = "0x183605430")]
		public HEDELDFEAKG(PDNMIGEDCFD<TActionKind, TSerializedAction, TPayload> JAGAJMNHCIO, IPDEJMECDOE<TRoot, TPayload, TOk, TErr> KIKNKMFDEPB, bool IGADGJPCMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x35FF380", Offset = "0x35FE380", VA = "0x1835FF380", Slot = "4")]
		public Task<CJDJPCEAKND<object, ONNOIFLMODG>> NJKOGBPOPLM(TDeps AKMCMCJGOCI, TRoot GLACNLFCFNI, TSerializedAction FGEOLOOIAJH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class BOPAILLAMDE<TPayload, TOk, TErr> : BIEDPLHNNAG<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, ONNOIFLMODG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct KDBKPKNGHLM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CJDJPCEAKND<object?, ONNOIFLMODG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BOPAILLAMDE<TPayload, TOk, TErr> <>4__this;

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
			private CJDJPCEAKND<object?, ONNOIFLMODG> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CJDJPCEAKND<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x394E490", Offset = "0x394D490", VA = "0x18394E490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x394ED30", Offset = "0x394DD30", VA = "0x18394ED30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PDNMIGEDCFD<TActionKind, TSerializedAction, TPayload> NGJGGBHHEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly IEEKOBGDFJJ<TRoot, TPayload, TOk, TErr> HCBHACKMCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool PEOEEDCBJIF;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3605430", Offset = "0x3604430", VA = "0x183605430")]
		public BOPAILLAMDE(PDNMIGEDCFD<TActionKind, TSerializedAction, TPayload> JAGAJMNHCIO, IEEKOBGDFJJ<TRoot, TPayload, TOk, TErr> KIKNKMFDEPB, bool IGADGJPCMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x457D3B0", Offset = "0x457C3B0", VA = "0x18457D3B0", Slot = "4")]
		[AsyncStateMachine(typeof(BOPAILLAMDE<, , >.KDBKPKNGHLM))]
		public Task<CJDJPCEAKND<object, ONNOIFLMODG>> NJKOGBPOPLM(TDeps AKMCMCJGOCI, TRoot GLACNLFCFNI, TSerializedAction FGEOLOOIAJH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BABLBPELGCG<TActionKind, TSerializedAction, TRoot, TDeps> BPHHKLDCICO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8426A0", VA = "0x1808436A0")]
	private OCDJEEBOCJM(BABLBPELGCG<TActionKind, TSerializedAction, TRoot, TDeps> FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5B70", Offset = "0x3DF4B70", VA = "0x183DF5B70")]
	public static OCDJEEBOCJM<TActionKind, TSerializedAction, TRoot, TDeps> ANBAJJBGINK()
	{
		return default(OCDJEEBOCJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x24313E0", Offset = "0x24303E0", VA = "0x1824313E0")]
	public OCDJEEBOCJM<TActionKind, TSerializedAction, TRoot, TDeps> KMODBJEAKMH<TPayload, TOk, TErr>(TActionKind GGNOFOPBADK, PDNMIGEDCFD<TActionKind, TSerializedAction, TPayload> JAGAJMNHCIO, IPDEJMECDOE<TRoot, TPayload, TOk, TErr> KIKNKMFDEPB, bool IGADGJPCMAE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, ONNOIFLMODG
	{
		return default(OCDJEEBOCJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x24313E0", Offset = "0x24303E0", VA = "0x1824313E0")]
	public OCDJEEBOCJM<TActionKind, TSerializedAction, TRoot, TDeps> AICHDGEAMNK<TPayload, TOk, TErr>(TActionKind GGNOFOPBADK, PDNMIGEDCFD<TActionKind, TSerializedAction, TPayload> JAGAJMNHCIO, IEEKOBGDFJJ<TRoot, TPayload, TOk, TErr> KIKNKMFDEPB, bool IGADGJPCMAE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, ONNOIFLMODG
	{
		return default(OCDJEEBOCJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF5C00", Offset = "0x3DF4C00", VA = "0x183DF5C00")]
	public LOMIIICCNFM<TActionKind, TSerializedAction, TRoot, TDeps> KCHJEPMNGMC(TDeps AKMCMCJGOCI)
	{
		return default(LOMIIICCNFM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
