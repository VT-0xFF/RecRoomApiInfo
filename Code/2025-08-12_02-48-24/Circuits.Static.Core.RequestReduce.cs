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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B13950", Offset = "0x2B11F50", VA = "0x182B13950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate LEGAEEMCDEO<TActionKind, TPayload> KLPEDKNOLNG<TActionKind, TSerializedAction, TPayload>(TSerializedAction KKALGNPJGCE);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface NBCMGHMIMBL<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PKAAAAMEMEI<object, MMMFEDEBKPH>> ODPOFOLNDMC(TDeps AIJNNPIBFLN, TRoot PPOKNBNEDHM, TSerializedAction KKALGNPJGCE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JGCIELCDGDB<TActionKind, TSerializedAction, TRoot, TDeps> : BIIFFOGOHOI where TDeps : EMGAIMJNNBA.PFCAJHKBLLK<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps LLKOIFELBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction JEDIGPPPDBN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x54B24D0", Offset = "0x54B0AD0", VA = "0x1854B24D0")]
	public JGCIELCDGDB([In] TDeps AIJNNPIBFLN, [In] TSerializedAction KKALGNPJGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x54B23A0", Offset = "0x54B09A0", VA = "0x1854B23A0", Slot = "7")]
	public override string JBIKIOHHBGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LEGAEEMCDEO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind AMKCFCOFFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload NDABDONGOPC;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x56D52D0", Offset = "0x56D38D0", VA = "0x1856D52D0")]
	internal LEGAEEMCDEO(TActionKind GAFOKECONHB, [In] TPayload KMJEOGEJMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DIECHAGJAOE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8A00", Offset = "0x3BD7000", VA = "0x183BD8A00")]
	public static LEGAEEMCDEO<TActionKind, TPayload> BPFPEFLIIPC<TActionKind, TPayload>([In] TActionKind GAFOKECONHB, [In] TPayload KMJEOGEJMHB)
	{
		return default(LEGAEEMCDEO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<PKAAAAMEMEI<TOk, TErr>> HHONPKDNCGG<TRoot, TPayload, TOk, TErr>(TRoot PPOKNBNEDHM, TPayload KMJEOGEJMHB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate PKAAAAMEMEI<TOk, TErr> LMDPCLFFFJE<TRoot, TPayload, TOk, TErr>(TRoot PPOKNBNEDHM, [In] TPayload KMJEOGEJMHB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HHELOLOLJPK<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : EMGAIMJNNBA.PFCAJHKBLLK<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KJJJNOBMCEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<object?, MMMFEDEBKPH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HHELOLOLJPK<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<PKAAAAMEMEI<object, MMMFEDEBKPH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x55CE1F0", Offset = "0x55CC7F0", VA = "0x1855CE1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55CEB60", Offset = "0x55CD160", VA = "0x1855CEB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, NBCMGHMIMBL<TSerializedAction, TRoot, TDeps>> OCDKACIFAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps LLKOIFELBCH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
	internal HHELOLOLJPK(Dictionary<TActionKind, NBCMGHMIMBL<TSerializedAction, TRoot, TDeps>> ODBKKOAEIDK, TDeps AIJNNPIBFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x50B65D0", Offset = "0x50B4BD0", VA = "0x1850B65D0")]
	[AsyncStateMachine(typeof(HHELOLOLJPK<, , , >.KJJJNOBMCEK))]
	public Task<PKAAAAMEMEI<object, MMMFEDEBKPH>> ODPOFOLNDMC(TRoot PPOKNBNEDHM, TSerializedAction KKALGNPJGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EMGAIMJNNBA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PFCAJHKBLLK<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind ENNNLEAHEIH(TSerializedAction CCKLBDLJPNG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IODPNLLAMAJ(TRoot PPOKNBNEDHM, TSerializedAction CBDPHPPPDFI);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NENFMAGJMLA(TRoot PPOKNBNEDHM, TSerializedAction CBDPHPPPDFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C13140", Offset = "0x3C11740", VA = "0x183C13140")]
	internal static HHELOLOLJPK<TActionKind, TSerializedAction, TRoot, TDeps> BPFPEFLIIPC<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, NBCMGHMIMBL<TSerializedAction, TRoot, TDeps>> ODBKKOAEIDK, TDeps AIJNNPIBFLN) where TDeps : PFCAJHKBLLK<TActionKind, TSerializedAction, TRoot>
	{
		return default(HHELOLOLJPK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class EGBHJNNBBEO<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, NBCMGHMIMBL<TSerializedAction, TRoot, TDeps>> BGFPMMNFBCD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	private EGBHJNNBBEO(Dictionary<TActionKind, NBCMGHMIMBL<TSerializedAction, TRoot, TDeps>> ODBKKOAEIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A75DE0", Offset = "0x4A743E0", VA = "0x184A75DE0")]
	public static EGBHJNNBBEO<TActionKind, TSerializedAction, TRoot, TDeps> BPFPEFLIIPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FKOPLPPIGBJ<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, EMGAIMJNNBA.PFCAJHKBLLK<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LFICLBDIFCO<TPayload, TOk, TErr> : NBCMGHMIMBL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MMMFEDEBKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KLPEDKNOLNG<TActionKind, TSerializedAction, TPayload> LNEIDHHDDBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LMDPCLFFFJE<TRoot, TPayload, TOk, TErr> GJMBMJFIBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool CIBNDGGAFPG;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1C93340", Offset = "0x1C91940", VA = "0x181C93340")]
		public LFICLBDIFCO(KLPEDKNOLNG<TActionKind, TSerializedAction, TPayload> OLBHCCDBHGO, LMDPCLFFFJE<TRoot, TPayload, TOk, TErr> EAICIBBJAOG, bool KGNBEFMFGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x56DCDA0", Offset = "0x56DB3A0", VA = "0x1856DCDA0", Slot = "4")]
		public Task<PKAAAAMEMEI<object, MMMFEDEBKPH>> ODPOFOLNDMC(TDeps AIJNNPIBFLN, TRoot PPOKNBNEDHM, TSerializedAction KKALGNPJGCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class COBOACJFLIA<TPayload, TOk, TErr> : NBCMGHMIMBL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MMMFEDEBKPH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PNIJJCLIBMK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PKAAAAMEMEI<object?, MMMFEDEBKPH>> <>t__builder;

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
			public COBOACJFLIA<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private PKAAAAMEMEI<object?, MMMFEDEBKPH> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<PKAAAAMEMEI<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5C972B0", Offset = "0x5C958B0", VA = "0x185C972B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5C98CA0", Offset = "0x5C972A0", VA = "0x185C98CA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KLPEDKNOLNG<TActionKind, TSerializedAction, TPayload> LNEIDHHDDBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HHONPKDNCGG<TRoot, TPayload, TOk, TErr> GJMBMJFIBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool CIBNDGGAFPG;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1C93340", Offset = "0x1C91940", VA = "0x181C93340")]
		public COBOACJFLIA(KLPEDKNOLNG<TActionKind, TSerializedAction, TPayload> OLBHCCDBHGO, HHONPKDNCGG<TRoot, TPayload, TOk, TErr> EAICIBBJAOG, bool KGNBEFMFGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB430", Offset = "0x6EC9A30", VA = "0x186ECB430", Slot = "4")]
		[AsyncStateMachine(typeof(COBOACJFLIA<, , >.PNIJJCLIBMK))]
		public Task<PKAAAAMEMEI<object, MMMFEDEBKPH>> ODPOFOLNDMC(TDeps AIJNNPIBFLN, TRoot PPOKNBNEDHM, TSerializedAction KKALGNPJGCE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EGBHJNNBBEO<TActionKind, TSerializedAction, TRoot, TDeps> NGCMHHMAMMK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
	private FKOPLPPIGBJ(EGBHJNNBBEO<TActionKind, TSerializedAction, TRoot, TDeps> DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F48710", Offset = "0x4F46D10", VA = "0x184F48710")]
	public static FKOPLPPIGBJ<TActionKind, TSerializedAction, TRoot, TDeps> BPFPEFLIIPC()
	{
		return default(FKOPLPPIGBJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4462F10", Offset = "0x4461510", VA = "0x184462F10")]
	public FKOPLPPIGBJ<TActionKind, TSerializedAction, TRoot, TDeps> GDLIBLFDKDD<TPayload, TOk, TErr>(TActionKind GAFOKECONHB, KLPEDKNOLNG<TActionKind, TSerializedAction, TPayload> OLBHCCDBHGO, LMDPCLFFFJE<TRoot, TPayload, TOk, TErr> EAICIBBJAOG, bool KGNBEFMFGOD = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MMMFEDEBKPH
	{
		return default(FKOPLPPIGBJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4462F10", Offset = "0x4461510", VA = "0x184462F10")]
	public FKOPLPPIGBJ<TActionKind, TSerializedAction, TRoot, TDeps> KKDOHCIMAEB<TPayload, TOk, TErr>(TActionKind GAFOKECONHB, KLPEDKNOLNG<TActionKind, TSerializedAction, TPayload> OLBHCCDBHGO, HHONPKDNCGG<TRoot, TPayload, TOk, TErr> EAICIBBJAOG, bool KGNBEFMFGOD = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MMMFEDEBKPH
	{
		return default(FKOPLPPIGBJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4F487A0", Offset = "0x4F46DA0", VA = "0x184F487A0")]
	public HHELOLOLJPK<TActionKind, TSerializedAction, TRoot, TDeps> ONIBBDPIEBH(TDeps AIJNNPIBFLN)
	{
		return default(HHELOLOLJPK<TActionKind, TSerializedAction, TRoot, TDeps>);
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
