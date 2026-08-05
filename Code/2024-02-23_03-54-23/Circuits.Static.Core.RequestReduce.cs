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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D7CE60", Offset = "0x1D7B860", VA = "0x181D7CE60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate OBFJIOOLHIO<TActionKind, TPayload> KBILCPOCAAF<TActionKind, TSerializedAction, TPayload>(TSerializedAction JFIELBPHCAO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface IGDPJALACEP<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KKHLNMGODKL<object, MPIKAEBOCFI>> EEFJNOANPLC(TDeps NFFMMJBNJIB, TRoot LMAHFBOHCNI, TSerializedAction JFIELBPHCAO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class AMIAFHBKEFO<TActionKind, TSerializedAction, TRoot, TDeps> : BDPIDPDHGEO where TDeps : LHINJBLMLPJ.HJMNPMINJNE<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps KAIABCGDPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction FABBOMOBFGE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37164C0", Offset = "0x3714EC0", VA = "0x1837164C0")]
	public AMIAFHBKEFO([In] TDeps NFFMMJBNJIB, [In] TSerializedAction JFIELBPHCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3716290", Offset = "0x3714C90", VA = "0x183716290", Slot = "7")]
	public override string GMMJBFEOGBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OBFJIOOLHIO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind CIALHCBGLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload DJOHIIFMNDA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F02780", Offset = "0x3F01180", VA = "0x183F02780")]
	internal OBFJIOOLHIO(TActionKind IPOKFEHJKMH, [In] TPayload MBIDFLHPHHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CGJJEPELJDF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24E2B20", Offset = "0x24E1520", VA = "0x1824E2B20")]
	public static OBFJIOOLHIO<TActionKind, TPayload> JKJFENIAMEL<TActionKind, TPayload>([In] TActionKind IPOKFEHJKMH, [In] TPayload MBIDFLHPHHK)
	{
		return default(OBFJIOOLHIO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<KKHLNMGODKL<TOk, TErr>> HDGDEECPIHN<TRoot, TPayload, TOk, TErr>(TRoot LMAHFBOHCNI, TPayload MBIDFLHPHHK);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate KKHLNMGODKL<TOk, TErr> CGJJFFGOKPN<TRoot, TPayload, TOk, TErr>(TRoot LMAHFBOHCNI, [In] TPayload MBIDFLHPHHK);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NHBPANFFCCL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : LHINJBLMLPJ.HJMNPMINJNE<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FAOAECMKJDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NHBPANFFCCL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x359C040", Offset = "0x359AA40", VA = "0x18359C040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x359C8E0", Offset = "0x359B2E0", VA = "0x18359C8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, IGDPJALACEP<TSerializedAction, TRoot, TDeps>> HPCEHPNAINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps KAIABCGDPPN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88E8A0", Offset = "0x88D2A0", VA = "0x18088E8A0")]
	internal NHBPANFFCCL(Dictionary<TActionKind, IGDPJALACEP<TSerializedAction, TRoot, TDeps>> MOHHJDMDBGB, TDeps NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E346B0", Offset = "0x3E330B0", VA = "0x183E346B0")]
	[AsyncStateMachine(typeof(NHBPANFFCCL<, , , >.FAOAECMKJDK))]
	public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> EEFJNOANPLC(TRoot LMAHFBOHCNI, TSerializedAction JFIELBPHCAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LHINJBLMLPJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HJMNPMINJNE<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GCPDNGMHCIA(TSerializedAction NHHBAHIFHJK);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FIIPDKPDKIJ(TRoot LMAHFBOHCNI, TSerializedAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CPNIDECCBPO(TRoot LMAHFBOHCNI, TSerializedAction MCLCEMNNOFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2734D10", Offset = "0x2733710", VA = "0x182734D10")]
	internal static NHBPANFFCCL<TActionKind, TSerializedAction, TRoot, TDeps> JKJFENIAMEL<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, IGDPJALACEP<TSerializedAction, TRoot, TDeps>> MOHHJDMDBGB, TDeps NFFMMJBNJIB) where TDeps : HJMNPMINJNE<TActionKind, TSerializedAction, TRoot>
	{
		return default(NHBPANFFCCL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BMLFGGFEJCP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, IGDPJALACEP<TSerializedAction, TRoot, TDeps>> FPHBJCJPIAB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	private BMLFGGFEJCP(Dictionary<TActionKind, IGDPJALACEP<TSerializedAction, TRoot, TDeps>> MOHHJDMDBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x46686A0", Offset = "0x46670A0", VA = "0x1846686A0")]
	public static BMLFGGFEJCP<TActionKind, TSerializedAction, TRoot, TDeps> JKJFENIAMEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CHFDGNEIFAE<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, LHINJBLMLPJ.HJMNPMINJNE<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class ODGCPNLBAOF<TPayload, TOk, TErr> : IGDPJALACEP<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MPIKAEBOCFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KBILCPOCAAF<TActionKind, TSerializedAction, TPayload> OANMGCMBNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CGJJFFGOKPN<TRoot, TPayload, TOk, TErr> KBJNAPDEDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DFGGBIPCECN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C3B0", Offset = "0x3F0ADB0", VA = "0x183F0C3B0")]
		public ODGCPNLBAOF(KBILCPOCAAF<TActionKind, TSerializedAction, TPayload> FNKJJIEODDD, CGJJFFGOKPN<TRoot, TPayload, TOk, TErr> KIKKBBDNCIH, bool ONIFLOAFNGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F06090", Offset = "0x3F04A90", VA = "0x183F06090", Slot = "4")]
		public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> EEFJNOANPLC(TDeps NFFMMJBNJIB, TRoot LMAHFBOHCNI, TSerializedAction JFIELBPHCAO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class BNFALLOCBKH<TPayload, TOk, TErr> : IGDPJALACEP<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MPIKAEBOCFI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BAALMCFILNK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<object?, MPIKAEBOCFI>> <>t__builder;

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
			public BNFALLOCBKH<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private KKHLNMGODKL<object?, MPIKAEBOCFI> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<KKHLNMGODKL<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x46106A0", Offset = "0x460F0A0", VA = "0x1846106A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4611110", Offset = "0x460FB10", VA = "0x184611110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KBILCPOCAAF<TActionKind, TSerializedAction, TPayload> OANMGCMBNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HDGDEECPIHN<TRoot, TPayload, TOk, TErr> KBJNAPDEDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DFGGBIPCECN;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C3B0", Offset = "0x3F0ADB0", VA = "0x183F0C3B0")]
		public BNFALLOCBKH(KBILCPOCAAF<TActionKind, TSerializedAction, TPayload> FNKJJIEODDD, HDGDEECPIHN<TRoot, TPayload, TOk, TErr> KIKKBBDNCIH, bool ONIFLOAFNGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4669520", Offset = "0x4667F20", VA = "0x184669520", Slot = "4")]
		[AsyncStateMachine(typeof(BNFALLOCBKH<, , >.BAALMCFILNK))]
		public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> EEFJNOANPLC(TDeps NFFMMJBNJIB, TRoot LMAHFBOHCNI, TSerializedAction JFIELBPHCAO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BMLFGGFEJCP<TActionKind, TSerializedAction, TRoot, TDeps> DMMDIHJBCMK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
	private CHFDGNEIFAE(BMLFGGFEJCP<TActionKind, TSerializedAction, TRoot, TDeps> MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4944850", Offset = "0x4943250", VA = "0x184944850")]
	public static CHFDGNEIFAE<TActionKind, TSerializedAction, TRoot, TDeps> JKJFENIAMEL()
	{
		return default(CHFDGNEIFAE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x223CB30", Offset = "0x223B530", VA = "0x18223CB30")]
	public CHFDGNEIFAE<TActionKind, TSerializedAction, TRoot, TDeps> BDPKAGLBNOI<TPayload, TOk, TErr>(TActionKind IPOKFEHJKMH, KBILCPOCAAF<TActionKind, TSerializedAction, TPayload> FNKJJIEODDD, CGJJFFGOKPN<TRoot, TPayload, TOk, TErr> KIKKBBDNCIH, bool ONIFLOAFNGD = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MPIKAEBOCFI
	{
		return default(CHFDGNEIFAE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x223CB30", Offset = "0x223B530", VA = "0x18223CB30")]
	public CHFDGNEIFAE<TActionKind, TSerializedAction, TRoot, TDeps> BOKIDNANFNO<TPayload, TOk, TErr>(TActionKind IPOKFEHJKMH, KBILCPOCAAF<TActionKind, TSerializedAction, TPayload> FNKJJIEODDD, HDGDEECPIHN<TRoot, TPayload, TOk, TErr> KIKKBBDNCIH, bool ONIFLOAFNGD = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MPIKAEBOCFI
	{
		return default(CHFDGNEIFAE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x49447A0", Offset = "0x49431A0", VA = "0x1849447A0")]
	public NHBPANFFCCL<TActionKind, TSerializedAction, TRoot, TDeps> GJADLDCIGOI(TDeps NFFMMJBNJIB)
	{
		return default(NHBPANFFCCL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
