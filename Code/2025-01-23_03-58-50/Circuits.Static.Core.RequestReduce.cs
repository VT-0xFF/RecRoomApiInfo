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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2341D60", Offset = "0x2340560", VA = "0x182341D60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate NLAHBAMHBNN<TActionKind, TPayload> IBEKMCOKMBK<TActionKind, TSerializedAction, TPayload>(TSerializedAction EOHCCJFFAML);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KPMOMLOAFGD<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> NHKKBFGFOCK(TDeps HNBDHJIILED, TRoot KAMAKIBPPKG, TSerializedAction EOHCCJFFAML);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HBKBLHEMIBG<TActionKind, TSerializedAction, TRoot, TDeps> : DBICEFMNJAI where TDeps : NIHBHKNCMKD.CAFEHNEHCJD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps NNDMPDFKOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction HGPAGOJMIHL;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x420AA60", Offset = "0x4209260", VA = "0x18420AA60")]
	public HBKBLHEMIBG([In] TDeps HNBDHJIILED, [In] TSerializedAction EOHCCJFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x420A850", Offset = "0x4209050", VA = "0x18420A850", Slot = "7")]
	public override string DHOBPLNCIMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NLAHBAMHBNN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind IIJKLMDMHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload FKEBNCLPOKK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A56E50", Offset = "0x4A55650", VA = "0x184A56E50")]
	internal NLAHBAMHBNN(TActionKind EGCCANDMNOF, [In] TPayload OANAMCHLGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BINBFGLCBMP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6690", Offset = "0x2DE4E90", VA = "0x182DE6690")]
	public static NLAHBAMHBNN<TActionKind, TPayload> DFLBOLBHLFN<TActionKind, TPayload>([In] TActionKind EGCCANDMNOF, [In] TPayload OANAMCHLGCB)
	{
		return default(NLAHBAMHBNN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<DNFCNMKAMCE<TOk, TErr>> OIIKIHAGCOK<TRoot, TPayload, TOk, TErr>(TRoot KAMAKIBPPKG, TPayload OANAMCHLGCB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate DNFCNMKAMCE<TOk, TErr> MEOMCLJBELB<TRoot, TPayload, TOk, TErr>(TRoot KAMAKIBPPKG, [In] TPayload OANAMCHLGCB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GDOENMHIADM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : NIHBHKNCMKD.CAFEHNEHCJD<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DIANDBAKAHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GDOENMHIADM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<DNFCNMKAMCE<object, OOJAGAFOLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4FB0", Offset = "0x5DE37B0", VA = "0x185DE4FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5430", Offset = "0x5DE3C30", VA = "0x185DE5430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, KPMOMLOAFGD<TSerializedAction, TRoot, TDeps>> MDPNHIDMLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps NNDMPDFKOOK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
	internal GDOENMHIADM(Dictionary<TActionKind, KPMOMLOAFGD<TSerializedAction, TRoot, TDeps>> BKMONCJJDCC, TDeps HNBDHJIILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x41255D0", Offset = "0x4123DD0", VA = "0x1841255D0")]
	[AsyncStateMachine(typeof(GDOENMHIADM<, , , >.DIANDBAKAHP))]
	public Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> NHKKBFGFOCK(TRoot KAMAKIBPPKG, TSerializedAction EOHCCJFFAML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NIHBHKNCMKD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CAFEHNEHCJD<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind PNEJOIBDEDB(TSerializedAction EGGDEECAALI);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EGFILCBCMEB(TRoot KAMAKIBPPKG, TSerializedAction ILIPDNLABEN);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HEINPFLHAJL(TRoot KAMAKIBPPKG, TSerializedAction ILIPDNLABEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2E5E6B0", Offset = "0x2E5CEB0", VA = "0x182E5E6B0")]
	internal static GDOENMHIADM<TActionKind, TSerializedAction, TRoot, TDeps> DFLBOLBHLFN<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, KPMOMLOAFGD<TSerializedAction, TRoot, TDeps>> BKMONCJJDCC, TDeps HNBDHJIILED) where TDeps : CAFEHNEHCJD<TActionKind, TSerializedAction, TRoot>
	{
		return default(GDOENMHIADM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DLAGBIAMPMC<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, KPMOMLOAFGD<TSerializedAction, TRoot, TDeps>> AGLKCJANINK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	private DLAGBIAMPMC(Dictionary<TActionKind, KPMOMLOAFGD<TSerializedAction, TRoot, TDeps>> BKMONCJJDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE6A0", Offset = "0x5DECEA0", VA = "0x185DEE6A0")]
	public static DLAGBIAMPMC<TActionKind, TSerializedAction, TRoot, TDeps> DFLBOLBHLFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GGOLPAHLCHH<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, NIHBHKNCMKD.CAFEHNEHCJD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PFPLFMDGKAA<TPayload, TOk, TErr> : KPMOMLOAFGD<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OOJAGAFOLJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IBEKMCOKMBK<TActionKind, TSerializedAction, TPayload> EDBOCLGPJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MEOMCLJBELB<TRoot, TPayload, TOk, TErr> GPEEPILIKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool BIOKAMGPJDP;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4C4E850", Offset = "0x4C4D050", VA = "0x184C4E850")]
		public PFPLFMDGKAA(IBEKMCOKMBK<TActionKind, TSerializedAction, TPayload> INJDCABNEPF, MEOMCLJBELB<TRoot, TPayload, TOk, TErr> GCGIOEDKNBK, bool PBOLCENBLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4C4CB80", Offset = "0x4C4B380", VA = "0x184C4CB80", Slot = "4")]
		public Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> NHKKBFGFOCK(TDeps HNBDHJIILED, TRoot KAMAKIBPPKG, TSerializedAction EOHCCJFFAML)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class CMMCILAMIFH<TPayload, TOk, TErr> : KPMOMLOAFGD<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OOJAGAFOLJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BPFNDLJONDC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<DNFCNMKAMCE<object?, OOJAGAFOLJL>> <>t__builder;

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
			public CMMCILAMIFH<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private DNFCNMKAMCE<object?, OOJAGAFOLJL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DNFCNMKAMCE<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5444E70", Offset = "0x5443670", VA = "0x185444E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5445D70", Offset = "0x5444570", VA = "0x185445D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly IBEKMCOKMBK<TActionKind, TSerializedAction, TPayload> EDBOCLGPJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly OIIKIHAGCOK<TRoot, TPayload, TOk, TErr> GPEEPILIKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool BIOKAMGPJDP;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4C4E850", Offset = "0x4C4D050", VA = "0x184C4E850")]
		public CMMCILAMIFH(IBEKMCOKMBK<TActionKind, TSerializedAction, TPayload> INJDCABNEPF, OIIKIHAGCOK<TRoot, TPayload, TOk, TErr> GCGIOEDKNBK, bool PBOLCENBLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x593B950", Offset = "0x593A150", VA = "0x18593B950", Slot = "4")]
		[AsyncStateMachine(typeof(CMMCILAMIFH<, , >.BPFNDLJONDC))]
		public Task<DNFCNMKAMCE<object, OOJAGAFOLJL>> NHKKBFGFOCK(TDeps HNBDHJIILED, TRoot KAMAKIBPPKG, TSerializedAction EOHCCJFFAML)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DLAGBIAMPMC<TActionKind, TSerializedAction, TRoot, TDeps> PHPGHIFGBEK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	private GGOLPAHLCHH(DLAGBIAMPMC<TActionKind, TSerializedAction, TRoot, TDeps> EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4130D40", Offset = "0x412F540", VA = "0x184130D40")]
	public static GGOLPAHLCHH<TActionKind, TSerializedAction, TRoot, TDeps> DFLBOLBHLFN()
	{
		return default(GGOLPAHLCHH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x300B4D0", Offset = "0x3009CD0", VA = "0x18300B4D0")]
	public GGOLPAHLCHH<TActionKind, TSerializedAction, TRoot, TDeps> OMLAEEFCHDB<TPayload, TOk, TErr>(TActionKind EGCCANDMNOF, IBEKMCOKMBK<TActionKind, TSerializedAction, TPayload> INJDCABNEPF, MEOMCLJBELB<TRoot, TPayload, TOk, TErr> GCGIOEDKNBK, bool PBOLCENBLOC = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OOJAGAFOLJL
	{
		return default(GGOLPAHLCHH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x300B4D0", Offset = "0x3009CD0", VA = "0x18300B4D0")]
	public GGOLPAHLCHH<TActionKind, TSerializedAction, TRoot, TDeps> DNNELIOJBIH<TPayload, TOk, TErr>(TActionKind EGCCANDMNOF, IBEKMCOKMBK<TActionKind, TSerializedAction, TPayload> INJDCABNEPF, OIIKIHAGCOK<TRoot, TPayload, TOk, TErr> GCGIOEDKNBK, bool PBOLCENBLOC = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OOJAGAFOLJL
	{
		return default(GGOLPAHLCHH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4130DE0", Offset = "0x412F5E0", VA = "0x184130DE0")]
	public GDOENMHIADM<TActionKind, TSerializedAction, TRoot, TDeps> LFOFFNOPOIK(TDeps HNBDHJIILED)
	{
		return default(GDOENMHIADM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
