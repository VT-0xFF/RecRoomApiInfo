using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F31CC0", Offset = "0x6F304C0", VA = "0x186F31CC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct PJOMKDKOOPO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind CICBEEDBHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload KBCPAJBGNOF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21B4300", Offset = "0x21B2B00", VA = "0x1821B4300")]
	internal PJOMKDKOOPO(TActionKind PIEOOIOAFBN, in TPayload BKHMACKFNNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BBFBJCGMNPP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E64270", Offset = "0x1E62A70", VA = "0x181E64270")]
	public static PJOMKDKOOPO<TActionKind, TPayload> NKAIHPJAMOL<TActionKind, TPayload>(in TActionKind PIEOOIOAFBN, in TPayload BKHMACKFNNF)
	{
		return default(PJOMKDKOOPO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface DOCLPKAAKKC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DLDMCIANGML<object, KCPGGCLIGHK>> CCPPFNMIKFD(TDeps BPNALAJICIC, TRoot CEABICNIABB, TSerializedAction JKPLDOCMNMC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LKNEPLGEPHC<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : MBBIGIBBKAC.LEFMHIHNJNB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BGPILMHMDKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<DLDMCIANGML<object, KCPGGCLIGHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LKNEPLGEPHC<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DOCLPKAAKKC<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DLDMCIANGML<object, KCPGGCLIGHK> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<DLDMCIANGML<object, KCPGGCLIGHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public BGPILMHMDKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2197880", Offset = "0x2196080", VA = "0x182197880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, DOCLPKAAKKC<TSerializedAction, TRoot, TDeps>> JLBCAKCDKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps PGKHJDIFGJI;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xB84550", Offset = "0xB82D50", VA = "0x180B84550")]
	internal LKNEPLGEPHC(Dictionary<TActionKind, DOCLPKAAKKC<TSerializedAction, TRoot, TDeps>> HCLBDDOAGEJ, TDeps BPNALAJICIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2074220", Offset = "0x2072A20", VA = "0x182074220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKNEPLGEPHC<, , , >.BGPILMHMDKI))]
	public Task<DLDMCIANGML<object, KCPGGCLIGHK>> CCPPFNMIKFD(TRoot CEABICNIABB, TSerializedAction JKPLDOCMNMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MBBIGIBBKAC
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface LEFMHIHNJNB<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind DNKDNLEOMMI(TSerializedAction PECDBPPMOJP);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KFGAMBKHJCE(TRoot CEABICNIABB, TSerializedAction COPPLLLOGLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B63E80", Offset = "0x2B62680", VA = "0x182B63E80")]
	internal static LKNEPLGEPHC<TActionKind, TSerializedAction, TRoot, TDeps> NKAIHPJAMOL<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, DOCLPKAAKKC<TSerializedAction, TRoot, TDeps>> HCLBDDOAGEJ, TDeps BPNALAJICIC) where TDeps : LEFMHIHNJNB<TActionKind, TSerializedAction, TRoot>
	{
		return default(LKNEPLGEPHC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate DLDMCIANGML<TOk, TErr> PLLADNAIODB<TRoot, TPayload, TOk, TErr>(TRoot CEABICNIABB, in TPayload BKHMACKFNNF);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class HMNGOCCPMNM<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, DOCLPKAAKKC<TSerializedAction, TRoot, TDeps>> DOKFKKHPHCO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x18FBCA0", Offset = "0x18FA4A0", VA = "0x1818FBCA0")]
	private HMNGOCCPMNM(Dictionary<TActionKind, DOCLPKAAKKC<TSerializedAction, TRoot, TDeps>> HCLBDDOAGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A2FCA0", Offset = "0x3A2E4A0", VA = "0x183A2FCA0")]
	public static HMNGOCCPMNM<TActionKind, TSerializedAction, TRoot, TDeps> NKAIHPJAMOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<DLDMCIANGML<TOk, TErr>> BFPDCOKPOFH<TRoot, TPayload, TOk, TErr>(TRoot CEABICNIABB, TPayload BKHMACKFNNF);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DPCHMGIDDDB<TActionKind, TSerializedAction, TRoot, TDeps> : DLCHKDEOFEA where TDeps : MBBIGIBBKAC.LEFMHIHNJNB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps PGKHJDIFGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction HMPDJOMFFJK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27F1F70", Offset = "0x27F0770", VA = "0x1827F1F70")]
	public DPCHMGIDDDB(in TDeps BPNALAJICIC, in TSerializedAction JKPLDOCMNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27F1E40", Offset = "0x27F0640", VA = "0x1827F1E40", Slot = "7")]
	public override string MOHEBAOGHEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate PJOMKDKOOPO<TActionKind, TPayload> LEGBKNEHACL<TActionKind, TSerializedAction, TPayload>(TSerializedAction JKPLDOCMNMC);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct PAIOLPCBHBC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MBBIGIBBKAC.LEFMHIHNJNB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class KCNHBFHFBJH<TPayload, TOk, TErr> : DOCLPKAAKKC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KCPGGCLIGHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LEGBKNEHACL<TActionKind, TSerializedAction, TPayload> FOEHLOKFGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly PLLADNAIODB<TRoot, TPayload, TOk, TErr> NEDFGABLKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool GABNABLDLNA;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x24CD490", Offset = "0x24CBC90", VA = "0x1824CD490")]
		public KCNHBFHFBJH(LEGBKNEHACL<TActionKind, TSerializedAction, TPayload> AMOIGHEPECM, PLLADNAIODB<TRoot, TPayload, TOk, TErr> EJKJHMBOEMO, bool EOBHHEKDKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3068C20", Offset = "0x3067420", VA = "0x183068C20", Slot = "4")]
		public Task<DLDMCIANGML<object, KCPGGCLIGHK>> CCPPFNMIKFD(TDeps BPNALAJICIC, TRoot CEABICNIABB, TSerializedAction JKPLDOCMNMC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class LAALLNONPAL<TPayload, TOk, TErr> : DOCLPKAAKKC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KCPGGCLIGHK
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MHPNJJIAJHP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x728250", Offset = "0x727650")]
			public AsyncTaskMethodBuilder<DLDMCIANGML<object, KCPGGCLIGHK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LAALLNONPAL<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7282B0", Offset = "0x7276B0")]
			private DLDMCIANGML<object, KCPGGCLIGHK> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x728310", Offset = "0x727710")]
			private PJOMKDKOOPO<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x728370", Offset = "0x727770")]
			private DLDMCIANGML<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7283D0", Offset = "0x7277D0")]
			private DLDMCIANGML<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x728430", Offset = "0x727830")]
			private TaskAwaiter<DLDMCIANGML<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public MHPNJJIAJHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x211A970", Offset = "0x2119170", VA = "0x18211A970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly LEGBKNEHACL<TActionKind, TSerializedAction, TPayload> FOEHLOKFGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BFPDCOKPOFH<TRoot, TPayload, TOk, TErr> NEDFGABLKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool GABNABLDLNA;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x24CD490", Offset = "0x24CBC90", VA = "0x1824CD490")]
		public LAALLNONPAL(LEGBKNEHACL<TActionKind, TSerializedAction, TPayload> AMOIGHEPECM, BFPDCOKPOFH<TRoot, TPayload, TOk, TErr> EJKJHMBOEMO, bool EOBHHEKDKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x24CCB30", Offset = "0x24CB330", VA = "0x1824CCB30", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LAALLNONPAL<, , >.MHPNJJIAJHP))]
		public Task<DLDMCIANGML<object, KCPGGCLIGHK>> CCPPFNMIKFD(TDeps BPNALAJICIC, TRoot CEABICNIABB, TSerializedAction JKPLDOCMNMC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HMNGOCCPMNM<TActionKind, TSerializedAction, TRoot, TDeps> LOCBNHGJJEH;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	private PAIOLPCBHBC(HMNGOCCPMNM<TActionKind, TSerializedAction, TRoot, TDeps> NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C602C0", Offset = "0x2C5EAC0", VA = "0x182C602C0")]
	public static PAIOLPCBHBC<TActionKind, TSerializedAction, TRoot, TDeps> NKAIHPJAMOL()
	{
		return default(PAIOLPCBHBC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x12A56E0", Offset = "0x12A3EE0", VA = "0x1812A56E0")]
	public PAIOLPCBHBC<TActionKind, TSerializedAction, TRoot, TDeps> OKMLDDDMJAC<TPayload, TOk, TErr>(TActionKind PIEOOIOAFBN, LEGBKNEHACL<TActionKind, TSerializedAction, TPayload> AMOIGHEPECM, PLLADNAIODB<TRoot, TPayload, TOk, TErr> EJKJHMBOEMO, bool EOBHHEKDKCO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KCPGGCLIGHK
	{
		return default(PAIOLPCBHBC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x12A56E0", Offset = "0x12A3EE0", VA = "0x1812A56E0")]
	public PAIOLPCBHBC<TActionKind, TSerializedAction, TRoot, TDeps> PMHDNKJLHLK<TPayload, TOk, TErr>(TActionKind PIEOOIOAFBN, LEGBKNEHACL<TActionKind, TSerializedAction, TPayload> AMOIGHEPECM, BFPDCOKPOFH<TRoot, TPayload, TOk, TErr> EJKJHMBOEMO, bool EOBHHEKDKCO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KCPGGCLIGHK
	{
		return default(PAIOLPCBHBC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C60210", Offset = "0x2C5EA10", VA = "0x182C60210")]
	public LKNEPLGEPHC<TActionKind, TSerializedAction, TRoot, TDeps> HOBKBMKCCBO(TDeps BPNALAJICIC)
	{
		return default(LKNEPLGEPHC<TActionKind, TSerializedAction, TRoot, TDeps>);
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
