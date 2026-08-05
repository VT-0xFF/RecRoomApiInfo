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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D1AB20", Offset = "0x1D19920", VA = "0x181D1AB20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate IPGKHBEPOFG<TActionKind, TPayload> CNOFFMOKGHN<TActionKind, TSerializedAction, TPayload>(TSerializedAction PBFNMBOHBHJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GCIKKDAHNDK<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CGKJAMMICEF<object, EPHFBGIJLJH>> EDIIKGNHBLH(TDeps BKBOLGJILHG, TRoot BPBPHOELENB, TSerializedAction PBFNMBOHBHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IKFELIGPCLD<TActionKind, TSerializedAction, TRoot, TDeps> : CPLGHNODHNJ where TDeps : MOCABJIEGNL.KLHBCKGJKEK<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps EDMEOLOBLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction KGMNCNBBLNN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38133C0", Offset = "0x38121C0", VA = "0x1838133C0")]
	public IKFELIGPCLD([In] TDeps BKBOLGJILHG, [In] TSerializedAction PBFNMBOHBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38131F0", Offset = "0x3811FF0", VA = "0x1838131F0", Slot = "7")]
	public override string EFDGLBEJKDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IPGKHBEPOFG<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind DFBJEPCKMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload HFEDELFHDGP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x381FB60", Offset = "0x381E960", VA = "0x18381FB60")]
	internal IPGKHBEPOFG(TActionKind BBAACDDLEFN, [In] TPayload PLFMLOLFNID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HMJMFOLJEOD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25D3440", Offset = "0x25D2240", VA = "0x1825D3440")]
	public static IPGKHBEPOFG<TActionKind, TPayload> DCPHPAHCOGO<TActionKind, TPayload>([In] TActionKind BBAACDDLEFN, [In] TPayload PLFMLOLFNID)
	{
		return default(IPGKHBEPOFG<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CGKJAMMICEF<TOk, TErr>> PBPCDABFHIF<TRoot, TPayload, TOk, TErr>(TRoot BPBPHOELENB, TPayload PLFMLOLFNID);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CGKJAMMICEF<TOk, TErr> KNOEIKILNMD<TRoot, TPayload, TOk, TErr>(TRoot BPBPHOELENB, [In] TPayload PLFMLOLFNID);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct KPAHGINBBJP<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : MOCABJIEGNL.KLHBCKGJKEK<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GHDIGIEMEGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CGKJAMMICEF<object, EPHFBGIJLJH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KPAHGINBBJP<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CGKJAMMICEF<object, EPHFBGIJLJH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x36E0C00", Offset = "0x36DFA00", VA = "0x1836E0C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x36E1090", Offset = "0x36DFE90", VA = "0x1836E1090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, GCIKKDAHNDK<TSerializedAction, TRoot, TDeps>> IAKHJHMHLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps EDMEOLOBLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x862170", Offset = "0x860F70", VA = "0x180862170")]
	internal KPAHGINBBJP(Dictionary<TActionKind, GCIKKDAHNDK<TSerializedAction, TRoot, TDeps>> OOMFGKADMKM, TDeps BKBOLGJILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB740", Offset = "0x3ABA540", VA = "0x183ABB740")]
	[AsyncStateMachine(typeof(KPAHGINBBJP<, , , >.GHDIGIEMEGE))]
	public Task<CGKJAMMICEF<object, EPHFBGIJLJH>> EDIIKGNHBLH(TRoot BPBPHOELENB, TSerializedAction PBFNMBOHBHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MOCABJIEGNL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KLHBCKGJKEK<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind HANFGOKKJIA(TSerializedAction OJFDNDCDDBK);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JCMOJMEBMFL(TRoot BPBPHOELENB, TSerializedAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AHHIJONALAG(TRoot BPBPHOELENB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26A5760", Offset = "0x26A4560", VA = "0x1826A5760")]
	internal static KPAHGINBBJP<TActionKind, TSerializedAction, TRoot, TDeps> DCPHPAHCOGO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, GCIKKDAHNDK<TSerializedAction, TRoot, TDeps>> OOMFGKADMKM, TDeps BKBOLGJILHG) where TDeps : KLHBCKGJKEK<TActionKind, TSerializedAction, TRoot>
	{
		return default(KPAHGINBBJP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GEOEEOBJNJK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, GCIKKDAHNDK<TSerializedAction, TRoot, TDeps>> MPGKDMEPEEH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	private GEOEEOBJNJK(Dictionary<TActionKind, GCIKKDAHNDK<TSerializedAction, TRoot, TDeps>> OOMFGKADMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x36DB630", Offset = "0x36DA430", VA = "0x1836DB630")]
	public static GEOEEOBJNJK<TActionKind, TSerializedAction, TRoot, TDeps> DCPHPAHCOGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct PPBNGCJIOFG<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MOCABJIEGNL.KLHBCKGJKEK<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CFOPMDLMMNL<TPayload, TOk, TErr> : GCIKKDAHNDK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EPHFBGIJLJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CNOFFMOKGHN<TActionKind, TSerializedAction, TPayload> ICAEBNFMLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KNOEIKILNMD<TRoot, TPayload, TOk, TErr> PHDPEHCHEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool ACCCPDKMHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly bool OKPLKMMACPO;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB9E90", Offset = "0x3AB8C90", VA = "0x183AB9E90")]
		public CFOPMDLMMNL(CNOFFMOKGHN<TActionKind, TSerializedAction, TPayload> DPBCPKKKFAL, KNOEIKILNMD<TRoot, TPayload, TOk, TErr> AGCIHONJAJB, bool BBOLMHIFPBN, bool AFMBFAEEEFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x48046E0", Offset = "0x48034E0", VA = "0x1848046E0", Slot = "4")]
		public Task<CGKJAMMICEF<object, EPHFBGIJLJH>> EDIIKGNHBLH(TDeps BKBOLGJILHG, TRoot BPBPHOELENB, TSerializedAction PBFNMBOHBHJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KNACGMECIDO<TPayload, TOk, TErr> : GCIKKDAHNDK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EPHFBGIJLJH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct ANJCNDIKHEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<CGKJAMMICEF<object?, EPHFBGIJLJH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public KNACGMECIDO<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private CGKJAMMICEF<object?, EPHFBGIJLJH> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<CGKJAMMICEF<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x36B4010", Offset = "0x36B2E10", VA = "0x1836B4010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x36B5000", Offset = "0x36B3E00", VA = "0x1836B5000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CNOFFMOKGHN<TActionKind, TSerializedAction, TPayload> ICAEBNFMLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly PBPCDABFHIF<TRoot, TPayload, TOk, TErr> PHDPEHCHEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool ACCCPDKMHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly bool OKPLKMMACPO;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3AB9E90", Offset = "0x3AB8C90", VA = "0x183AB9E90")]
		public KNACGMECIDO(CNOFFMOKGHN<TActionKind, TSerializedAction, TPayload> DPBCPKKKFAL, PBPCDABFHIF<TRoot, TPayload, TOk, TErr> AGCIHONJAJB, bool BBOLMHIFPBN, bool AFMBFAEEEFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AB97B0", Offset = "0x3AB85B0", VA = "0x183AB97B0", Slot = "4")]
		[AsyncStateMachine(typeof(KNACGMECIDO<, , >.ANJCNDIKHEM))]
		public Task<CGKJAMMICEF<object, EPHFBGIJLJH>> EDIIKGNHBLH(TDeps BKBOLGJILHG, TRoot BPBPHOELENB, TSerializedAction PBFNMBOHBHJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GEOEEOBJNJK<TActionKind, TSerializedAction, TRoot, TDeps> DFEKEJNPLLC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8C4200", Offset = "0x8C3000", VA = "0x1808C4200")]
	private PPBNGCJIOFG(GEOEEOBJNJK<TActionKind, TSerializedAction, TRoot, TDeps> HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4055610", Offset = "0x4054410", VA = "0x184055610")]
	public static PPBNGCJIOFG<TActionKind, TSerializedAction, TRoot, TDeps> DCPHPAHCOGO()
	{
		return default(PPBNGCJIOFG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2516180", Offset = "0x2514F80", VA = "0x182516180")]
	public PPBNGCJIOFG<TActionKind, TSerializedAction, TRoot, TDeps> NBJHGAFKNKM<TPayload, TOk, TErr>(TActionKind BBAACDDLEFN, CNOFFMOKGHN<TActionKind, TSerializedAction, TPayload> DPBCPKKKFAL, KNOEIKILNMD<TRoot, TPayload, TOk, TErr> AGCIHONJAJB, bool BBOLMHIFPBN = true, bool AFMBFAEEEFP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EPHFBGIJLJH
	{
		return default(PPBNGCJIOFG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2516180", Offset = "0x2514F80", VA = "0x182516180")]
	public PPBNGCJIOFG<TActionKind, TSerializedAction, TRoot, TDeps> EEEIIJFDKBN<TPayload, TOk, TErr>(TActionKind BBAACDDLEFN, CNOFFMOKGHN<TActionKind, TSerializedAction, TPayload> DPBCPKKKFAL, PBPCDABFHIF<TRoot, TPayload, TOk, TErr> AGCIHONJAJB, bool BBOLMHIFPBN = true, bool AFMBFAEEEFP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EPHFBGIJLJH
	{
		return default(PPBNGCJIOFG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4055560", Offset = "0x4054360", VA = "0x184055560")]
	public KPAHGINBBJP<TActionKind, TSerializedAction, TRoot, TDeps> APJJALPOAIC(TDeps BKBOLGJILHG)
	{
		return default(KPAHGINBBJP<TActionKind, TSerializedAction, TRoot, TDeps>);
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
