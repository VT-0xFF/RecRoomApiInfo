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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27B2DF0", Offset = "0x27B13F0", VA = "0x1827B2DF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate GPFEFANJIIE<TActionKind, TPayload> LCBEGNGIOLK<TActionKind, TSerializedAction, TPayload>(TSerializedAction MAKFDIHKDKK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface BPMDJIPADMJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> KGIFNIAOLDC(TDeps MMCKJCAOGBM, TRoot KNNDNAPJIDP, TSerializedAction MAKFDIHKDKK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NPAHENPOPJO<TActionKind, TSerializedAction, TRoot, TDeps> : CNPJDFNBLHN where TDeps : KIAIHFFPMKB.IIGBIEGDLEB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps IJFOHHKJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction KJMPFMCPCGA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x541F6D0", Offset = "0x541DCD0", VA = "0x18541F6D0")]
	public NPAHENPOPJO([In] TDeps MMCKJCAOGBM, [In] TSerializedAction MAKFDIHKDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x541F5B0", Offset = "0x541DBB0", VA = "0x18541F5B0", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct GPFEFANJIIE<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind CKOEOAMNPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload CKNMHACEOLE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AD45C0", Offset = "0x4AD2BC0", VA = "0x184AD45C0")]
	internal GPFEFANJIIE(TActionKind MBIPLBPPBOD, [In] TPayload DGHLABNPIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LPJGMPOPHMF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x391B8C0", Offset = "0x3919EC0", VA = "0x18391B8C0")]
	public static GPFEFANJIIE<TActionKind, TPayload> ACADPGMDEBE<TActionKind, TPayload>([In] TActionKind MBIPLBPPBOD, [In] TPayload DGHLABNPIEC)
	{
		return default(GPFEFANJIIE<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<HHHCCNLMPJL<TOk, TErr>> LPJPBIHPOND<TRoot, TPayload, TOk, TErr>(TRoot KNNDNAPJIDP, TPayload DGHLABNPIEC);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate HHHCCNLMPJL<TOk, TErr> LLMJELCADCJ<TRoot, TPayload, TOk, TErr>(TRoot KNNDNAPJIDP, [In] TPayload DGHLABNPIEC);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HLMEOCKMCND<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : KIAIHFFPMKB.IIGBIEGDLEB<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HDNDAGJBKFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HLMEOCKMCND<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4B08650", Offset = "0x4B06C50", VA = "0x184B08650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4B08AD0", Offset = "0x4B070D0", VA = "0x184B08AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, BPMDJIPADMJ<TSerializedAction, TRoot, TDeps>> AGHBPGBACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps IJFOHHKJJKM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
	internal HLMEOCKMCND(Dictionary<TActionKind, BPMDJIPADMJ<TSerializedAction, TRoot, TDeps>> IACHPEHOCAN, TDeps MMCKJCAOGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B623C0", Offset = "0x4B609C0", VA = "0x184B623C0")]
	[AsyncStateMachine(typeof(HLMEOCKMCND<, , , >.HDNDAGJBKFC))]
	public Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> KGIFNIAOLDC(TRoot KNNDNAPJIDP, TSerializedAction MAKFDIHKDKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KIAIHFFPMKB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IIGBIEGDLEB<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind HJAOCKHLDIB(TSerializedAction OCACDKEJIIB);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LKBLLIFPGMA(TRoot KNNDNAPJIDP, TSerializedAction BDCLNIJAFBF);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NEJGNHDJEJE(TRoot KNNDNAPJIDP, TSerializedAction BDCLNIJAFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36D2000", Offset = "0x36D0600", VA = "0x1836D2000")]
	internal static HLMEOCKMCND<TActionKind, TSerializedAction, TRoot, TDeps> ACADPGMDEBE<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, BPMDJIPADMJ<TSerializedAction, TRoot, TDeps>> IACHPEHOCAN, TDeps MMCKJCAOGBM) where TDeps : IIGBIEGDLEB<TActionKind, TSerializedAction, TRoot>
	{
		return default(HLMEOCKMCND<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MKBNELOONIP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, BPMDJIPADMJ<TSerializedAction, TRoot, TDeps>> DINLGNHPBEN;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	private MKBNELOONIP(Dictionary<TActionKind, BPMDJIPADMJ<TSerializedAction, TRoot, TDeps>> IACHPEHOCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5361830", Offset = "0x535FE30", VA = "0x185361830")]
	public static MKBNELOONIP<TActionKind, TSerializedAction, TRoot, TDeps> ACADPGMDEBE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct APNBNOIOAEH<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, KIAIHFFPMKB.IIGBIEGDLEB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BGEOHDJEHPB<TPayload, TOk, TErr> : BPMDJIPADMJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DLKBDBKHJCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LCBEGNGIOLK<TActionKind, TSerializedAction, TPayload> JOMCHBCCPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LLMJELCADCJ<TRoot, TPayload, TOk, TErr> NOCFLCFGCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DACNKOMCNIG;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x19918F0", Offset = "0x198FEF0", VA = "0x1819918F0")]
		public BGEOHDJEHPB(LCBEGNGIOLK<TActionKind, TSerializedAction, TPayload> BELDNHAADHC, LLMJELCADCJ<TRoot, TPayload, TOk, TErr> KLDKOEHIKGI, bool HHOKMPBBHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6240160", Offset = "0x623E760", VA = "0x186240160", Slot = "4")]
		public Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> KGIFNIAOLDC(TDeps MMCKJCAOGBM, TRoot KNNDNAPJIDP, TSerializedAction MAKFDIHKDKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GDFLCAHAKIB<TPayload, TOk, TErr> : BPMDJIPADMJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, DLKBDBKHJCC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct IEHMMNJAKIK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>t__builder;

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
			public GDFLCAHAKIB<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HHHCCNLMPJL<object?, DLKBDBKHJCC> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<HHHCCNLMPJL<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4C314E0", Offset = "0x4C2FAE0", VA = "0x184C314E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4C323E0", Offset = "0x4C309E0", VA = "0x184C323E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LCBEGNGIOLK<TActionKind, TSerializedAction, TPayload> JOMCHBCCPCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LPJPBIHPOND<TRoot, TPayload, TOk, TErr> NOCFLCFGCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DACNKOMCNIG;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x19918F0", Offset = "0x198FEF0", VA = "0x1819918F0")]
		public GDFLCAHAKIB(LCBEGNGIOLK<TActionKind, TSerializedAction, TPayload> BELDNHAADHC, LPJPBIHPOND<TRoot, TPayload, TOk, TErr> KLDKOEHIKGI, bool HHOKMPBBHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4AACFB0", Offset = "0x4AAB5B0", VA = "0x184AACFB0", Slot = "4")]
		[AsyncStateMachine(typeof(GDFLCAHAKIB<, , >.IEHMMNJAKIK))]
		public Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> KGIFNIAOLDC(TDeps MMCKJCAOGBM, TRoot KNNDNAPJIDP, TSerializedAction MAKFDIHKDKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MKBNELOONIP<TActionKind, TSerializedAction, TRoot, TDeps> NKKMPKCKMAO;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	private APNBNOIOAEH(MKBNELOONIP<TActionKind, TSerializedAction, TRoot, TDeps> APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5064410", Offset = "0x5062A10", VA = "0x185064410")]
	public static APNBNOIOAEH<TActionKind, TSerializedAction, TRoot, TDeps> ACADPGMDEBE()
	{
		return default(APNBNOIOAEH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37B2E50", Offset = "0x37B1450", VA = "0x1837B2E50")]
	public APNBNOIOAEH<TActionKind, TSerializedAction, TRoot, TDeps> NAGACCHNPIK<TPayload, TOk, TErr>(TActionKind MBIPLBPPBOD, LCBEGNGIOLK<TActionKind, TSerializedAction, TPayload> BELDNHAADHC, LLMJELCADCJ<TRoot, TPayload, TOk, TErr> KLDKOEHIKGI, bool HHOKMPBBHIH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DLKBDBKHJCC
	{
		return default(APNBNOIOAEH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37B2E50", Offset = "0x37B1450", VA = "0x1837B2E50")]
	public APNBNOIOAEH<TActionKind, TSerializedAction, TRoot, TDeps> LHGHIBMAOII<TPayload, TOk, TErr>(TActionKind MBIPLBPPBOD, LCBEGNGIOLK<TActionKind, TSerializedAction, TPayload> BELDNHAADHC, LPJPBIHPOND<TRoot, TPayload, TOk, TErr> KLDKOEHIKGI, bool HHOKMPBBHIH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, DLKBDBKHJCC
	{
		return default(APNBNOIOAEH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50644B0", Offset = "0x5062AB0", VA = "0x1850644B0")]
	public HLMEOCKMCND<TActionKind, TSerializedAction, TRoot, TDeps> DCICOKIGPEL(TDeps MMCKJCAOGBM)
	{
		return default(HLMEOCKMCND<TActionKind, TSerializedAction, TRoot, TDeps>);
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
