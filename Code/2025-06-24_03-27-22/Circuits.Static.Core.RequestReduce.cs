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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2947340", Offset = "0x2945F40", VA = "0x182947340")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate AJOFFEOLEEJ<TActionKind, TPayload> PEKLHPJBOGK<TActionKind, TSerializedAction, TPayload>(TSerializedAction IKJCOOEJFLO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface EBAJFMBNOBI<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> ADMEADCOPJG(TDeps FCHJEFGMLNE, TRoot HMGDINOCJAI, TSerializedAction IKJCOOEJFLO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OLOALIEKPKN<TActionKind, TSerializedAction, TRoot, TDeps> : AJHEICOHAGC where TDeps : FMNPICICGKM.HNGEBILDPPH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction POGKAPCGADA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5682590", Offset = "0x5681190", VA = "0x185682590")]
	public OLOALIEKPKN([In] TDeps FCHJEFGMLNE, [In] TSerializedAction IKJCOOEJFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5682470", Offset = "0x5681070", VA = "0x185682470", Slot = "7")]
	public override string NEEGIDJCGEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct AJOFFEOLEEJ<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind DMOKILDKILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload HANEGOLMCIE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F77A00", Offset = "0x4F76600", VA = "0x184F77A00")]
	internal AJOFFEOLEEJ(TActionKind FMMGOHCCMFH, [In] TPayload ADKJHPADFOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DIEPLDMCDAE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38E64D0", Offset = "0x38E50D0", VA = "0x1838E64D0")]
	public static AJOFFEOLEEJ<TActionKind, TPayload> JHMOIFLKJAD<TActionKind, TPayload>([In] TActionKind FMMGOHCCMFH, [In] TPayload ADKJHPADFOA)
	{
		return default(AJOFFEOLEEJ<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<MDDPJNIIBBI<TOk, TErr>> IMANKOMLAHG<TRoot, TPayload, TOk, TErr>(TRoot HMGDINOCJAI, TPayload ADKJHPADFOA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate MDDPJNIIBBI<TOk, TErr> BNEGHIPCLAF<TRoot, TPayload, TOk, TErr>(TRoot HMGDINOCJAI, [In] TPayload ADKJHPADFOA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LCFFANMCGNM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : FMNPICICGKM.HNGEBILDPPH<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BIGFLBBPNLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<object?, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LCFFANMCGNM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6473C80", Offset = "0x6472880", VA = "0x186473C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6474570", Offset = "0x6473170", VA = "0x186474570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, EBAJFMBNOBI<TSerializedAction, TRoot, TDeps>> GCJFMHKOMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
	internal LCFFANMCGNM(Dictionary<TActionKind, EBAJFMBNOBI<TSerializedAction, TRoot, TDeps>> FPCFOPJACKM, TDeps FCHJEFGMLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x527E350", Offset = "0x527CF50", VA = "0x18527E350")]
	[AsyncStateMachine(typeof(LCFFANMCGNM<, , , >.BIGFLBBPNLA))]
	public Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> ADMEADCOPJG(TRoot HMGDINOCJAI, TSerializedAction IKJCOOEJFLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FMNPICICGKM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HNGEBILDPPH<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind LOPILNCKPIL(TSerializedAction LAAPKLDJLPE);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GKIFHDAJGLK(TRoot HMGDINOCJAI, TSerializedAction IFDCDCHOGGB);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DHNANGCIBOK(TRoot HMGDINOCJAI, TSerializedAction IFDCDCHOGGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3837590", Offset = "0x3836190", VA = "0x183837590")]
	internal static LCFFANMCGNM<TActionKind, TSerializedAction, TRoot, TDeps> JHMOIFLKJAD<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, EBAJFMBNOBI<TSerializedAction, TRoot, TDeps>> FPCFOPJACKM, TDeps FCHJEFGMLNE) where TDeps : HNGEBILDPPH<TActionKind, TSerializedAction, TRoot>
	{
		return default(LCFFANMCGNM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HBBCNEPNIID<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, EBAJFMBNOBI<TSerializedAction, TRoot, TDeps>> CKPNHFCDPAM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	private HBBCNEPNIID(Dictionary<TActionKind, EBAJFMBNOBI<TSerializedAction, TRoot, TDeps>> FPCFOPJACKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D85B20", Offset = "0x4D84720", VA = "0x184D85B20")]
	public static HBBCNEPNIID<TActionKind, TSerializedAction, TRoot, TDeps> JHMOIFLKJAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IOELLAEKKFF<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, FMNPICICGKM.HNGEBILDPPH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AHBBDIFNJHN<TPayload, TOk, TErr> : EBAJFMBNOBI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, JHFNBJHGPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PEKLHPJBOGK<TActionKind, TSerializedAction, TPayload> FCFIKENIFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BNEGHIPCLAF<TRoot, TPayload, TOk, TErr> LNFPJDGBNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool MOJHLDFEOKC;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1B203A0", Offset = "0x1B1EFA0", VA = "0x181B203A0")]
		public AHBBDIFNJHN(PEKLHPJBOGK<TActionKind, TSerializedAction, TPayload> OLLFPFHMDFL, BNEGHIPCLAF<TRoot, TPayload, TOk, TErr> JNGMPBCHBFK, bool NHHIAALKODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4D74F70", Offset = "0x4D73B70", VA = "0x184D74F70", Slot = "4")]
		public Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> ADMEADCOPJG(TDeps FCHJEFGMLNE, TRoot HMGDINOCJAI, TSerializedAction IKJCOOEJFLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class OKEOKKMLPEO<TPayload, TOk, TErr> : EBAJFMBNOBI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, JHFNBJHGPJG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JCCJLMDJDIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<MDDPJNIIBBI<object?, JHFNBJHGPJG>> <>t__builder;

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
			public OKEOKKMLPEO<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private MDDPJNIIBBI<object?, JHFNBJHGPJG> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MDDPJNIIBBI<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x50B0780", Offset = "0x50AF380", VA = "0x1850B0780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x50B1EA0", Offset = "0x50B0AA0", VA = "0x1850B1EA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PEKLHPJBOGK<TActionKind, TSerializedAction, TPayload> FCFIKENIFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly IMANKOMLAHG<TRoot, TPayload, TOk, TErr> LNFPJDGBNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool MOJHLDFEOKC;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1B203A0", Offset = "0x1B1EFA0", VA = "0x181B203A0")]
		public OKEOKKMLPEO(PEKLHPJBOGK<TActionKind, TSerializedAction, TPayload> OLLFPFHMDFL, IMANKOMLAHG<TRoot, TPayload, TOk, TErr> JNGMPBCHBFK, bool NHHIAALKODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x56728F0", Offset = "0x56714F0", VA = "0x1856728F0", Slot = "4")]
		[AsyncStateMachine(typeof(OKEOKKMLPEO<, , >.JCCJLMDJDIO))]
		public Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> ADMEADCOPJG(TDeps FCHJEFGMLNE, TRoot HMGDINOCJAI, TSerializedAction IKJCOOEJFLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HBBCNEPNIID<TActionKind, TSerializedAction, TRoot, TDeps> DGEOKDEKGPB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
	private IOELLAEKKFF(HBBCNEPNIID<TActionKind, TSerializedAction, TRoot, TDeps> PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8EA0", Offset = "0x4EA7AA0", VA = "0x184EA8EA0")]
	public static IOELLAEKKFF<TActionKind, TSerializedAction, TRoot, TDeps> JHMOIFLKJAD()
	{
		return default(IOELLAEKKFF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF51D0", Offset = "0x3FF3DD0", VA = "0x183FF51D0")]
	public IOELLAEKKFF<TActionKind, TSerializedAction, TRoot, TDeps> APBJAJGDMPF<TPayload, TOk, TErr>(TActionKind FMMGOHCCMFH, PEKLHPJBOGK<TActionKind, TSerializedAction, TPayload> OLLFPFHMDFL, BNEGHIPCLAF<TRoot, TPayload, TOk, TErr> JNGMPBCHBFK, bool NHHIAALKODJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JHFNBJHGPJG
	{
		return default(IOELLAEKKFF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF51D0", Offset = "0x3FF3DD0", VA = "0x183FF51D0")]
	public IOELLAEKKFF<TActionKind, TSerializedAction, TRoot, TDeps> EDHPEDLKHFO<TPayload, TOk, TErr>(TActionKind FMMGOHCCMFH, PEKLHPJBOGK<TActionKind, TSerializedAction, TPayload> OLLFPFHMDFL, IMANKOMLAHG<TRoot, TPayload, TOk, TErr> JNGMPBCHBFK, bool NHHIAALKODJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JHFNBJHGPJG
	{
		return default(IOELLAEKKFF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8DF0", Offset = "0x4EA79F0", VA = "0x184EA8DF0")]
	public LCFFANMCGNM<TActionKind, TSerializedAction, TRoot, TDeps> GEEOJDFCKDC(TDeps FCHJEFGMLNE)
	{
		return default(LCFFANMCGNM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
