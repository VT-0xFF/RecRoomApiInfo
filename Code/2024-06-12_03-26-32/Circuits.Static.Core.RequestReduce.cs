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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FA6010", Offset = "0x1FA4C10", VA = "0x181FA6010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate JPENIILFPGH<TActionKind, TPayload> AAOEHCEADOA<TActionKind, TSerializedAction, TPayload>(TSerializedAction AEAOBJJNCBC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface ENGBBOKHPIB<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GFFELLBKJIA<object, DCMKOJFPDPC>> KPIGLCGNAIG(TDeps CFCALMONEJL, TRoot BLPDMPJLPPJ, TSerializedAction AEAOBJJNCBC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JGKIFMJOGAI<TActionKind, TSerializedAction, TRoot, TDeps> : GCLPBJOMDAE where TDeps : FBDMKCHIIEC.FNCKIIKMALN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps KJMCLGOJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction BCLNGINHLGH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4034C50", Offset = "0x4033850", VA = "0x184034C50")]
	public JGKIFMJOGAI([In] TDeps CFCALMONEJL, [In] TSerializedAction AEAOBJJNCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4034B30", Offset = "0x4033730", VA = "0x184034B30", Slot = "7")]
	public override string BKHNKMBHNFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JPENIILFPGH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind GADJHKECMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload CBGLBODEGCO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4078E00", Offset = "0x4077A00", VA = "0x184078E00")]
	internal JPENIILFPGH(TActionKind FNEBJHOKKKK, [In] TPayload FAPAFOGIGGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HLNKCKCDOAA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B201D0", Offset = "0x2B1EDD0", VA = "0x182B201D0")]
	public static JPENIILFPGH<TActionKind, TPayload> PPOPBMPFEOP<TActionKind, TPayload>([In] TActionKind FNEBJHOKKKK, [In] TPayload FAPAFOGIGGO)
	{
		return default(JPENIILFPGH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<GFFELLBKJIA<TOk, TErr>> HHCEGPMLMAA<TRoot, TPayload, TOk, TErr>(TRoot BLPDMPJLPPJ, TPayload FAPAFOGIGGO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate GFFELLBKJIA<TOk, TErr> EAPLNCNHJOK<TRoot, TPayload, TOk, TErr>(TRoot BLPDMPJLPPJ, [In] TPayload FAPAFOGIGGO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BKCAOGABAKD<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : FBDMKCHIIEC.FNCKIIKMALN<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ILNAFELPFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public BKCAOGABAKD<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3E703C0", Offset = "0x3E6EFC0", VA = "0x183E703C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3E70850", Offset = "0x3E6F450", VA = "0x183E70850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, ENGBBOKHPIB<TSerializedAction, TRoot, TDeps>> AAPEGGGADGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps KJMCLGOJKLB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
	internal BKCAOGABAKD(Dictionary<TActionKind, ENGBBOKHPIB<TSerializedAction, TRoot, TDeps>> NHBHDPIJJLI, TDeps CFCALMONEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E5EAE0", Offset = "0x4E5D6E0", VA = "0x184E5EAE0")]
	[AsyncStateMachine(typeof(BKCAOGABAKD<, , , >.ILNAFELPFIK))]
	public Task<GFFELLBKJIA<object, DCMKOJFPDPC>> KPIGLCGNAIG(TRoot BLPDMPJLPPJ, TSerializedAction AEAOBJJNCBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FBDMKCHIIEC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FNCKIIKMALN<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GKNJFKACFCJ(TSerializedAction HNFMOHFACKF);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DEBJNPDMINC(TRoot BLPDMPJLPPJ, TSerializedAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IKPGDPGEDLP(TRoot BLPDMPJLPPJ, TSerializedAction FIPNCHEIGMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x295A820", Offset = "0x2959420", VA = "0x18295A820")]
	internal static BKCAOGABAKD<TActionKind, TSerializedAction, TRoot, TDeps> PPOPBMPFEOP<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, ENGBBOKHPIB<TSerializedAction, TRoot, TDeps>> NHBHDPIJJLI, TDeps CFCALMONEJL) where TDeps : FNCKIIKMALN<TActionKind, TSerializedAction, TRoot>
	{
		return default(BKCAOGABAKD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GEBAGOCINND<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, ENGBBOKHPIB<TSerializedAction, TRoot, TDeps>> DDBJBMKOJOF;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	private GEBAGOCINND(Dictionary<TActionKind, ENGBBOKHPIB<TSerializedAction, TRoot, TDeps>> NHBHDPIJJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C73A70", Offset = "0x3C72670", VA = "0x183C73A70")]
	public static GEBAGOCINND<TActionKind, TSerializedAction, TRoot, TDeps> PPOPBMPFEOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LOCGLCFIOKB<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, FBDMKCHIIEC.FNCKIIKMALN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class FMCMLIKHBAN<TPayload, TOk, TErr> : ENGBBOKHPIB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DCMKOJFPDPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AAOEHCEADOA<TActionKind, TSerializedAction, TPayload> FCFLMJBCMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly EAPLNCNHJOK<TRoot, TPayload, TOk, TErr> NKAHEOFPKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DFLAJLGNAOM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5910", Offset = "0x3BB4510", VA = "0x183BB5910")]
		public FMCMLIKHBAN(AAOEHCEADOA<TActionKind, TSerializedAction, TPayload> PMNDMPEODMH, EAPLNCNHJOK<TRoot, TPayload, TOk, TErr> DCKPOLHLEGA, bool ALLNBAPDEIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4AD0", Offset = "0x3BB36D0", VA = "0x183BB4AD0", Slot = "4")]
		public Task<GFFELLBKJIA<object, DCMKOJFPDPC>> KPIGLCGNAIG(TDeps CFCALMONEJL, TRoot BLPDMPJLPPJ, TSerializedAction AEAOBJJNCBC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class PJGPNODJJCM<TPayload, TOk, TErr> : ENGBBOKHPIB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DCMKOJFPDPC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct AJMLAIDDEAC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<GFFELLBKJIA<object?, DCMKOJFPDPC>> <>t__builder;

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
			public PJGPNODJJCM<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private GFFELLBKJIA<object?, DCMKOJFPDPC> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<GFFELLBKJIA<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3DD1D90", Offset = "0x3DD0990", VA = "0x183DD1D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3A50", Offset = "0x3DD2650", VA = "0x183DD3A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AAOEHCEADOA<TActionKind, TSerializedAction, TPayload> FCFLMJBCMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HHCEGPMLMAA<TRoot, TPayload, TOk, TErr> NKAHEOFPKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DFLAJLGNAOM;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5910", Offset = "0x3BB4510", VA = "0x183BB5910")]
		public PJGPNODJJCM(AAOEHCEADOA<TActionKind, TSerializedAction, TPayload> PMNDMPEODMH, HHCEGPMLMAA<TRoot, TPayload, TOk, TErr> DCKPOLHLEGA, bool ALLNBAPDEIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4776360", Offset = "0x4774F60", VA = "0x184776360", Slot = "4")]
		[AsyncStateMachine(typeof(PJGPNODJJCM<, , >.AJMLAIDDEAC))]
		public Task<GFFELLBKJIA<object, DCMKOJFPDPC>> KPIGLCGNAIG(TDeps CFCALMONEJL, TRoot BLPDMPJLPPJ, TSerializedAction AEAOBJJNCBC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GEBAGOCINND<TActionKind, TSerializedAction, TRoot, TDeps> BGKODKCBENK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	private LOCGLCFIOKB(GEBAGOCINND<TActionKind, TSerializedAction, TRoot, TDeps> IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4227A50", Offset = "0x4226650", VA = "0x184227A50")]
	public static LOCGLCFIOKB<TActionKind, TSerializedAction, TRoot, TDeps> PPOPBMPFEOP()
	{
		return default(LOCGLCFIOKB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28165F0", Offset = "0x28151F0", VA = "0x1828165F0")]
	public LOCGLCFIOKB<TActionKind, TSerializedAction, TRoot, TDeps> PDGOMANFLLM<TPayload, TOk, TErr>(TActionKind FNEBJHOKKKK, AAOEHCEADOA<TActionKind, TSerializedAction, TPayload> PMNDMPEODMH, EAPLNCNHJOK<TRoot, TPayload, TOk, TErr> DCKPOLHLEGA, bool ALLNBAPDEIL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DCMKOJFPDPC
	{
		return default(LOCGLCFIOKB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x28165F0", Offset = "0x28151F0", VA = "0x1828165F0")]
	public LOCGLCFIOKB<TActionKind, TSerializedAction, TRoot, TDeps> KKKOCHBLMNE<TPayload, TOk, TErr>(TActionKind FNEBJHOKKKK, AAOEHCEADOA<TActionKind, TSerializedAction, TPayload> PMNDMPEODMH, HHCEGPMLMAA<TRoot, TPayload, TOk, TErr> DCKPOLHLEGA, bool ALLNBAPDEIL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DCMKOJFPDPC
	{
		return default(LOCGLCFIOKB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4227990", Offset = "0x4226590", VA = "0x184227990")]
	public BKCAOGABAKD<TActionKind, TSerializedAction, TRoot, TDeps> KEOKFEIEIKM(TDeps CFCALMONEJL)
	{
		return default(BKCAOGABAKD<TActionKind, TSerializedAction, TRoot, TDeps>);
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
