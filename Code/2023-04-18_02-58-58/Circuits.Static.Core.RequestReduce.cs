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
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x681AE60", Offset = "0x681A060", VA = "0x18681AE60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate global::BNNACKHHFFC<TActionKind, TPayload> KEDCDBCCINF<TActionKind, TSerializedAction, TPayload>(TSerializedAction EDMJGADCABN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface OHOHAKOMLEL<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::LAFJBBFBCGA<object, HODHNINHENI>> LNCALKLBEJG(TDeps JCHGABJHIIM, TRoot KPDGHDGLMHO, TSerializedAction EDMJGADCABN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KMHMAKALGLB<TActionKind, TSerializedAction, TRoot, TDeps> : HODHNINHENI where TDeps : GBLKLILPBLF.EOCBIPMGBHI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps LDMMCHHPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction HAMPGMJGPPA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6170", Offset = "0x1FC5370", VA = "0x181FC6170")]
	public KMHMAKALGLB(in TDeps JCHGABJHIIM, in TSerializedAction EDMJGADCABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6090", Offset = "0x1FC5290", VA = "0x181FC6090", Slot = "5")]
	public override string HMHKJMAEDDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BNNACKHHFFC<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BIAEJLMNADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload BMMKHHAFPCC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA260", Offset = "0x1EB9460", VA = "0x181EBA260")]
	internal BNNACKHHFFC(TActionKind AIIGPNGIAFO, in TPayload KHKGGNHOCOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NFNGJOFDPOC
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C7E3E0", Offset = "0x1C7D5E0", VA = "0x181C7E3E0")]
	public static global::BNNACKHHFFC<TActionKind, TPayload> ELCFDEFNBDD<TActionKind, TPayload>(in TActionKind AIIGPNGIAFO, in TPayload KHKGGNHOCOE)
	{
		return default(global::BNNACKHHFFC<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<global::LAFJBBFBCGA<TOk, TErr>> PLJJFGPCLIP<TRoot, TPayload, TOk, TErr>(TRoot KPDGHDGLMHO, TPayload KHKGGNHOCOE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate global::LAFJBBFBCGA<TOk, TErr> LLPJBPMOFIF<TRoot, TPayload, TOk, TErr>(TRoot KPDGHDGLMHO, in TPayload KHKGGNHOCOE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MMBGOPJGKAP<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GBLKLILPBLF.EOCBIPMGBHI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AKIGCAOIBDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::MMBGOPJGKAP<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x31DE4E0", Offset = "0x31DD6E0", VA = "0x1831DE4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x31DECF0", Offset = "0x31DDEF0", VA = "0x1831DECF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, global::OHOHAKOMLEL<TSerializedAction, TRoot, TDeps>> MINJNCBPPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps LDMMCHHPBGO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7AF930", Offset = "0x7AEB30", VA = "0x1807AF930")]
	internal MMBGOPJGKAP(Dictionary<TActionKind, global::OHOHAKOMLEL<TSerializedAction, TRoot, TDeps>> MEDJBIFCBDB, TDeps JCHGABJHIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2631B90", Offset = "0x2630D90", VA = "0x182631B90")]
	[AsyncStateMachine(typeof(global::MMBGOPJGKAP<, , , >.AKIGCAOIBDN))]
	public Task<global::LAFJBBFBCGA<object, HODHNINHENI>> LNCALKLBEJG(TRoot KPDGHDGLMHO, TSerializedAction EDMJGADCABN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GBLKLILPBLF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface EOCBIPMGBHI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EMCOJBAEGOJ(TSerializedAction DIJPFIMLAFB);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MCMKHPPOOBA(TRoot KPDGHDGLMHO, TSerializedAction IBKGKDECOEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x149DB30", Offset = "0x149CD30", VA = "0x18149DB30")]
	internal static global::MMBGOPJGKAP<TActionKind, TSerializedAction, TRoot, TDeps> ELCFDEFNBDD<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::OHOHAKOMLEL<TSerializedAction, TRoot, TDeps>> MEDJBIFCBDB, TDeps JCHGABJHIIM) where TDeps : EOCBIPMGBHI<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::MMBGOPJGKAP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class ELHJFNHIHEF<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, global::OHOHAKOMLEL<TSerializedAction, TRoot, TDeps>> DJIBMIJOPEM;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1B3B7F0", Offset = "0x1B3A9F0", VA = "0x181B3B7F0")]
	private ELHJFNHIHEF(Dictionary<TActionKind, global::OHOHAKOMLEL<TSerializedAction, TRoot, TDeps>> MEDJBIFCBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27EC890", Offset = "0x27EBA90", VA = "0x1827EC890")]
	public static global::ELHJFNHIHEF<TActionKind, TSerializedAction, TRoot, TDeps> ELCFDEFNBDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JGACPCCOPIL<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GBLKLILPBLF.EOCBIPMGBHI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NEKJONCHHIM<TPayload, TOk, TErr> : global::OHOHAKOMLEL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HODHNINHENI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly global::KEDCDBCCINF<TActionKind, TSerializedAction, TPayload> NAIMNGJDHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly global::LLPJBPMOFIF<TRoot, TPayload, TOk, TErr> HCBMDMCPOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool OFBCOIMFELH;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x24C0A40", Offset = "0x24BFC40", VA = "0x1824C0A40")]
		public NEKJONCHHIM(global::KEDCDBCCINF<TActionKind, TSerializedAction, TPayload> FANMDPHGIPL, global::LLPJBPMOFIF<TRoot, TPayload, TOk, TErr> ICLIDBEFCLL, bool OBMHEBIAKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x24BFE00", Offset = "0x24BF000", VA = "0x1824BFE00", Slot = "4")]
		public Task<global::LAFJBBFBCGA<object, HODHNINHENI>> LNCALKLBEJG(TDeps JCHGABJHIIM, TRoot KPDGHDGLMHO, TSerializedAction EDMJGADCABN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GCCHFLBNAJM<TPayload, TOk, TErr> : global::OHOHAKOMLEL<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HODHNINHENI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::KEDCDBCCINF<TActionKind, TSerializedAction, TPayload> NAIMNGJDHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::PLJJFGPCLIP<TRoot, TPayload, TOk, TErr> HCBMDMCPOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool OFBCOIMFELH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x24C0A40", Offset = "0x24BFC40", VA = "0x1824C0A40")]
		public GCCHFLBNAJM(global::KEDCDBCCINF<TActionKind, TSerializedAction, TPayload> FANMDPHGIPL, global::PLJJFGPCLIP<TRoot, TPayload, TOk, TErr> ICLIDBEFCLL, bool OBMHEBIAKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2FE76E0", Offset = "0x2FE68E0", VA = "0x182FE76E0", Slot = "4")]
		[AsyncStateMachine(typeof(AINEMCOJDOD))]
		public Task<global::LAFJBBFBCGA<object, HODHNINHENI>> LNCALKLBEJG(TDeps JCHGABJHIIM, TRoot KPDGHDGLMHO, TSerializedAction EDMJGADCABN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly global::ELHJFNHIHEF<TActionKind, TSerializedAction, TRoot, TDeps> JKIGONBCCJJ;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
	private JGACPCCOPIL(global::ELHJFNHIHEF<TActionKind, TSerializedAction, TRoot, TDeps> PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2338FC0", Offset = "0x23381C0", VA = "0x182338FC0")]
	public static global::JGACPCCOPIL<TActionKind, TSerializedAction, TRoot, TDeps> ELCFDEFNBDD()
	{
		return default(global::JGACPCCOPIL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x147C4B0", Offset = "0x147B6B0", VA = "0x18147C4B0")]
	public global::JGACPCCOPIL<TActionKind, TSerializedAction, TRoot, TDeps> ANEMHFAIACI<TPayload, TOk, TErr>(TActionKind AIIGPNGIAFO, global::KEDCDBCCINF<TActionKind, TSerializedAction, TPayload> FANMDPHGIPL, global::LLPJBPMOFIF<TRoot, TPayload, TOk, TErr> ICLIDBEFCLL, bool OBMHEBIAKGO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HODHNINHENI
	{
		return default(global::JGACPCCOPIL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x147C4B0", Offset = "0x147B6B0", VA = "0x18147C4B0")]
	public global::JGACPCCOPIL<TActionKind, TSerializedAction, TRoot, TDeps> GKFGJKIGBPJ<TPayload, TOk, TErr>(TActionKind AIIGPNGIAFO, global::KEDCDBCCINF<TActionKind, TSerializedAction, TPayload> FANMDPHGIPL, global::PLJJFGPCLIP<TRoot, TPayload, TOk, TErr> ICLIDBEFCLL, bool OBMHEBIAKGO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HODHNINHENI
	{
		return default(global::JGACPCCOPIL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2339060", Offset = "0x2338260", VA = "0x182339060")]
	public global::MMBGOPJGKAP<TActionKind, TSerializedAction, TRoot, TDeps> OELCFPDDHFJ(TDeps JCHGABJHIIM)
	{
		return default(global::MMBGOPJGKAP<TActionKind, TSerializedAction, TRoot, TDeps>);
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
