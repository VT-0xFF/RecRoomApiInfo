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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x224B750", Offset = "0x224AB50", VA = "0x18224B750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate MHCCOIIPMCO<TActionKind, TPayload> OLLBOGKHJBO<TActionKind, TSerializedAction, TPayload>(TSerializedAction LFPDAFGEJLL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KONJHCCGHIE<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MLIDCCDLMIE<object, FNDOAGAGANG>> JKMAMNAOLPC(TDeps ICFGLKCGHOG, TRoot FINELPFBLOK, TSerializedAction LFPDAFGEJLL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KJECDAMHFKO<TActionKind, TSerializedAction, TRoot, TDeps> : FLDDNKNCPHH where TDeps : PBBGFJIIJDE.CNELGLEOHLI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps DILMOBAKENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction AAOPEIMEFMA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4540EC0", Offset = "0x45402C0", VA = "0x184540EC0")]
	public KJECDAMHFKO([In] TDeps ICFGLKCGHOG, [In] TSerializedAction LFPDAFGEJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4540D00", Offset = "0x4540100", VA = "0x184540D00", Slot = "7")]
	public override string KIGPPELGDEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct MHCCOIIPMCO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind GLJENHGFAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload NBEHOIHMJED;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x481C8F0", Offset = "0x481BCF0", VA = "0x18481C8F0")]
	internal MHCCOIIPMCO(TActionKind DFAELIPMAFN, [In] TPayload NNNHDMLPIGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LPPLBAJNNEI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F43660", Offset = "0x2F42A60", VA = "0x182F43660")]
	public static MHCCOIIPMCO<TActionKind, TPayload> AALKPJMFIHM<TActionKind, TPayload>([In] TActionKind DFAELIPMAFN, [In] TPayload NNNHDMLPIGD)
	{
		return default(MHCCOIIPMCO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<MLIDCCDLMIE<TOk, TErr>> AMINICCCJGB<TRoot, TPayload, TOk, TErr>(TRoot FINELPFBLOK, TPayload NNNHDMLPIGD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate MLIDCCDLMIE<TOk, TErr> MLANGDKJEGG<TRoot, TPayload, TOk, TErr>(TRoot FINELPFBLOK, [In] TPayload NNNHDMLPIGD);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IMKDEIMDPBG<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : PBBGFJIIJDE.CNELGLEOHLI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KDJMKIFOAJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IMKDEIMDPBG<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4529950", Offset = "0x4528D50", VA = "0x184529950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x452A300", Offset = "0x4529700", VA = "0x18452A300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, KONJHCCGHIE<TSerializedAction, TRoot, TDeps>> NBMGOEKHHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps DILMOBAKENH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
	internal IMKDEIMDPBG(Dictionary<TActionKind, KONJHCCGHIE<TSerializedAction, TRoot, TDeps>> DFHHONCAHCP, TDeps ICFGLKCGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4210D70", Offset = "0x4210170", VA = "0x184210D70")]
	[AsyncStateMachine(typeof(IMKDEIMDPBG<, , , >.KDJMKIFOAJI))]
	public Task<MLIDCCDLMIE<object, FNDOAGAGANG>> JKMAMNAOLPC(TRoot FINELPFBLOK, TSerializedAction LFPDAFGEJLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PBBGFJIIJDE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CNELGLEOHLI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind MDMGMOIPKNP(TSerializedAction MBGHIKEGJAA);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DBCAGCDNDIA(TRoot FINELPFBLOK, TSerializedAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FMFDIDFNGGA(TRoot FINELPFBLOK, TSerializedAction MDOOJHKFGMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE050", Offset = "0x2BDD450", VA = "0x182BDE050")]
	internal static IMKDEIMDPBG<TActionKind, TSerializedAction, TRoot, TDeps> AALKPJMFIHM<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, KONJHCCGHIE<TSerializedAction, TRoot, TDeps>> DFHHONCAHCP, TDeps ICFGLKCGHOG) where TDeps : CNELGLEOHLI<TActionKind, TSerializedAction, TRoot>
	{
		return default(IMKDEIMDPBG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class PKIBJHCHCEM<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, KONJHCCGHIE<TSerializedAction, TRoot, TDeps>> PBPDAAEIIPH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	private PKIBJHCHCEM(Dictionary<TActionKind, KONJHCCGHIE<TSerializedAction, TRoot, TDeps>> DFHHONCAHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B6C1C0", Offset = "0x4B6B5C0", VA = "0x184B6C1C0")]
	public static PKIBJHCHCEM<TActionKind, TSerializedAction, TRoot, TDeps> AALKPJMFIHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CHBJLOGABAB<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, PBBGFJIIJDE.CNELGLEOHLI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class IICEIKALKKF<TPayload, TOk, TErr> : KONJHCCGHIE<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FNDOAGAGANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OLLBOGKHJBO<TActionKind, TSerializedAction, TPayload> JDEHBOOPKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MLANGDKJEGG<TRoot, TPayload, TOk, TErr> OEKKHPJEHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool FNICBOLDEFB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4207330", Offset = "0x4206730", VA = "0x184207330")]
		public IICEIKALKKF(OLLBOGKHJBO<TActionKind, TSerializedAction, TPayload> PHLPLNPPKJI, MLANGDKJEGG<TRoot, TPayload, TOk, TErr> NMLFIDBEKJI, bool ABAAKMIADOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x41FFC70", Offset = "0x41FF070", VA = "0x1841FFC70", Slot = "4")]
		public Task<MLIDCCDLMIE<object, FNDOAGAGANG>> JKMAMNAOLPC(TDeps ICFGLKCGHOG, TRoot FINELPFBLOK, TSerializedAction LFPDAFGEJLL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class BJDFGCOIFMJ<TPayload, TOk, TErr> : KONJHCCGHIE<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FNDOAGAGANG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct MKEOGPFLJHF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<MLIDCCDLMIE<object?, FNDOAGAGANG>> <>t__builder;

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
			public BJDFGCOIFMJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private MLIDCCDLMIE<object?, FNDOAGAGANG> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MLIDCCDLMIE<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4821860", Offset = "0x4820C60", VA = "0x184821860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4822840", Offset = "0x4821C40", VA = "0x184822840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OLLBOGKHJBO<TActionKind, TSerializedAction, TPayload> JDEHBOOPKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly AMINICCCJGB<TRoot, TPayload, TOk, TErr> OEKKHPJEHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool FNICBOLDEFB;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4207330", Offset = "0x4206730", VA = "0x184207330")]
		public BJDFGCOIFMJ(OLLBOGKHJBO<TActionKind, TSerializedAction, TPayload> PHLPLNPPKJI, AMINICCCJGB<TRoot, TPayload, TOk, TErr> NMLFIDBEKJI, bool ABAAKMIADOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x527AA20", Offset = "0x5279E20", VA = "0x18527AA20", Slot = "4")]
		[AsyncStateMachine(typeof(BJDFGCOIFMJ<, , >.MKEOGPFLJHF))]
		public Task<MLIDCCDLMIE<object, FNDOAGAGANG>> JKMAMNAOLPC(TDeps ICFGLKCGHOG, TRoot FINELPFBLOK, TSerializedAction LFPDAFGEJLL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly PKIBJHCHCEM<TActionKind, TSerializedAction, TRoot, TDeps> CJJBCBGBIDF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	private CHBJLOGABAB(PKIBJHCHCEM<TActionKind, TSerializedAction, TRoot, TDeps> MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x531DB70", Offset = "0x531CF70", VA = "0x18531DB70")]
	public static CHBJLOGABAB<TActionKind, TSerializedAction, TRoot, TDeps> AALKPJMFIHM()
	{
		return default(CHBJLOGABAB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9C10", Offset = "0x2CE9010", VA = "0x182CE9C10")]
	public CHBJLOGABAB<TActionKind, TSerializedAction, TRoot, TDeps> BACHGPEFDHJ<TPayload, TOk, TErr>(TActionKind DFAELIPMAFN, OLLBOGKHJBO<TActionKind, TSerializedAction, TPayload> PHLPLNPPKJI, MLANGDKJEGG<TRoot, TPayload, TOk, TErr> NMLFIDBEKJI, bool ABAAKMIADOM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FNDOAGAGANG
	{
		return default(CHBJLOGABAB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9C10", Offset = "0x2CE9010", VA = "0x182CE9C10")]
	public CHBJLOGABAB<TActionKind, TSerializedAction, TRoot, TDeps> DFKKEIGNCKJ<TPayload, TOk, TErr>(TActionKind DFAELIPMAFN, OLLBOGKHJBO<TActionKind, TSerializedAction, TPayload> PHLPLNPPKJI, AMINICCCJGB<TRoot, TPayload, TOk, TErr> NMLFIDBEKJI, bool ABAAKMIADOM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FNDOAGAGANG
	{
		return default(CHBJLOGABAB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x531DC10", Offset = "0x531D010", VA = "0x18531DC10")]
	public IMKDEIMDPBG<TActionKind, TSerializedAction, TRoot, TDeps> ABKGAJKKDCG(TDeps ICFGLKCGHOG)
	{
		return default(IMKDEIMDPBG<TActionKind, TSerializedAction, TRoot, TDeps>);
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
