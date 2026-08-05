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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22447A0", Offset = "0x2243BA0", VA = "0x1822447A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate DAGAJHJFHEN<TActionKind, TPayload> LLPGKPILGIG<TActionKind, TSerializedAction, TPayload>(TSerializedAction BOPDHANDFDK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface PALMKDFMKIF<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LMFFMMPMNDB<object, FOPCNMINEGF>> JGMEIPOPKPO(TDeps CLOGBAKPPIL, TRoot KCFGMPGPMFA, TSerializedAction BOPDHANDFDK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NKNJCCFJNDJ<TActionKind, TSerializedAction, TRoot, TDeps> : JLINDJLDKOH where TDeps : JGNPCHJFAMM.IOBGODHJBMF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps DBHDOFFCGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction OFDKBMDEBDP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4907130", Offset = "0x4906530", VA = "0x184907130")]
	public NKNJCCFJNDJ([In] TDeps CLOGBAKPPIL, [In] TSerializedAction BOPDHANDFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4907000", Offset = "0x4906400", VA = "0x184907000", Slot = "7")]
	public override string AHEFLPEKLMA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DAGAJHJFHEN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind FHHALGPGDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload EKOOGGKKKHH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C89DE0", Offset = "0x5C891E0", VA = "0x185C89DE0")]
	internal DAGAJHJFHEN(TActionKind LDEIKMFKKAJ, [In] TPayload GKKLHKCNNPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KJCAHLAPNHD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8F30", Offset = "0x2EE8330", VA = "0x182EE8F30")]
	public static DAGAJHJFHEN<TActionKind, TPayload> AHLALEPNKFA<TActionKind, TPayload>([In] TActionKind LDEIKMFKKAJ, [In] TPayload GKKLHKCNNPG)
	{
		return default(DAGAJHJFHEN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<LMFFMMPMNDB<TOk, TErr>> AJMAHACFIFI<TRoot, TPayload, TOk, TErr>(TRoot KCFGMPGPMFA, TPayload GKKLHKCNNPG);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate LMFFMMPMNDB<TOk, TErr> PNIPBIACAFI<TRoot, TPayload, TOk, TErr>(TRoot KCFGMPGPMFA, [In] TPayload GKKLHKCNNPG);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CJKPHJOADDL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JGNPCHJFAMM.IOBGODHJBMF<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OEKPLKKAACI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CJKPHJOADDL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4A0F3B0", Offset = "0x4A0E7B0", VA = "0x184A0F3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4A0FC80", Offset = "0x4A0F080", VA = "0x184A0FC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, PALMKDFMKIF<TSerializedAction, TRoot, TDeps>> BBOGIMFOPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps DBHDOFFCGAC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	internal CJKPHJOADDL(Dictionary<TActionKind, PALMKDFMKIF<TSerializedAction, TRoot, TDeps>> PINMKCPEPKM, TDeps CLOGBAKPPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x596D780", Offset = "0x596CB80", VA = "0x18596D780")]
	[AsyncStateMachine(typeof(CJKPHJOADDL<, , , >.OEKPLKKAACI))]
	public Task<LMFFMMPMNDB<object, FOPCNMINEGF>> JGMEIPOPKPO(TRoot KCFGMPGPMFA, TSerializedAction BOPDHANDFDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JGNPCHJFAMM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IOBGODHJBMF<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind DMPEIOIFJNE(TSerializedAction MCPMOAEEEOJ);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GGELMCCLDNG(TRoot KCFGMPGPMFA, TSerializedAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LONMNBPPKAF(TRoot KCFGMPGPMFA, TSerializedAction HJOAJFDFEDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2E7AC40", Offset = "0x2E7A040", VA = "0x182E7AC40")]
	internal static CJKPHJOADDL<TActionKind, TSerializedAction, TRoot, TDeps> AHLALEPNKFA<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, PALMKDFMKIF<TSerializedAction, TRoot, TDeps>> PINMKCPEPKM, TDeps CLOGBAKPPIL) where TDeps : IOBGODHJBMF<TActionKind, TSerializedAction, TRoot>
	{
		return default(CJKPHJOADDL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HLNIPNFKCEK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, PALMKDFMKIF<TSerializedAction, TRoot, TDeps>> OFIIEFHAKBH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	private HLNIPNFKCEK(Dictionary<TActionKind, PALMKDFMKIF<TSerializedAction, TRoot, TDeps>> PINMKCPEPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x416E8B0", Offset = "0x416DCB0", VA = "0x18416E8B0")]
	public static HLNIPNFKCEK<TActionKind, TSerializedAction, TRoot, TDeps> AHLALEPNKFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct ODHHEHMOGNP<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JGNPCHJFAMM.IOBGODHJBMF<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NAANJELAEGA<TPayload, TOk, TErr> : PALMKDFMKIF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FOPCNMINEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LLPGKPILGIG<TActionKind, TSerializedAction, TPayload> AINIJHBIHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly PNIPBIACAFI<TRoot, TPayload, TOk, TErr> LEAGCBHNBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool OPLFPMFPOJA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x442A5B0", Offset = "0x44299B0", VA = "0x18442A5B0")]
		public NAANJELAEGA(LLPGKPILGIG<TActionKind, TSerializedAction, TPayload> BCHDJBNBAEE, PNIPBIACAFI<TRoot, TPayload, TOk, TErr> NNDNIIDMFPD, bool BPALKLIGGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x48960F0", Offset = "0x48954F0", VA = "0x1848960F0", Slot = "4")]
		public Task<LMFFMMPMNDB<object, FOPCNMINEGF>> JGMEIPOPKPO(TDeps CLOGBAKPPIL, TRoot KCFGMPGPMFA, TSerializedAction BOPDHANDFDK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JMCPAOHODMF<TPayload, TOk, TErr> : PALMKDFMKIF<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FOPCNMINEGF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct FPNNDFHADLE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<LMFFMMPMNDB<object?, FOPCNMINEGF>> <>t__builder;

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
			public JMCPAOHODMF<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private LMFFMMPMNDB<object?, FOPCNMINEGF> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<LMFFMMPMNDB<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3F69A00", Offset = "0x3F68E00", VA = "0x183F69A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A080", Offset = "0x3F69480", VA = "0x183F6A080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LLPGKPILGIG<TActionKind, TSerializedAction, TPayload> AINIJHBIHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly AJMAHACFIFI<TRoot, TPayload, TOk, TErr> LEAGCBHNBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool OPLFPMFPOJA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x442A5B0", Offset = "0x44299B0", VA = "0x18442A5B0")]
		public JMCPAOHODMF(LLPGKPILGIG<TActionKind, TSerializedAction, TPayload> BCHDJBNBAEE, AJMAHACFIFI<TRoot, TPayload, TOk, TErr> NNDNIIDMFPD, bool BPALKLIGGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x442A190", Offset = "0x4429590", VA = "0x18442A190", Slot = "4")]
		[AsyncStateMachine(typeof(JMCPAOHODMF<, , >.FPNNDFHADLE))]
		public Task<LMFFMMPMNDB<object, FOPCNMINEGF>> JGMEIPOPKPO(TDeps CLOGBAKPPIL, TRoot KCFGMPGPMFA, TSerializedAction BOPDHANDFDK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HLNIPNFKCEK<TActionKind, TSerializedAction, TRoot, TDeps> BLMNPNBLJEA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	private ODHHEHMOGNP(HLNIPNFKCEK<TActionKind, TSerializedAction, TRoot, TDeps> AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A0AC30", Offset = "0x4A0A030", VA = "0x184A0AC30")]
	public static ODHHEHMOGNP<TActionKind, TSerializedAction, TRoot, TDeps> AHLALEPNKFA()
	{
		return default(ODHHEHMOGNP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1780", Offset = "0x2EF0B80", VA = "0x182EF1780")]
	public ODHHEHMOGNP<TActionKind, TSerializedAction, TRoot, TDeps> KEHNMDMEIDL<TPayload, TOk, TErr>(TActionKind LDEIKMFKKAJ, LLPGKPILGIG<TActionKind, TSerializedAction, TPayload> BCHDJBNBAEE, PNIPBIACAFI<TRoot, TPayload, TOk, TErr> NNDNIIDMFPD, bool BPALKLIGGGI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FOPCNMINEGF
	{
		return default(ODHHEHMOGNP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2EF1780", Offset = "0x2EF0B80", VA = "0x182EF1780")]
	public ODHHEHMOGNP<TActionKind, TSerializedAction, TRoot, TDeps> MLABMMHINDO<TPayload, TOk, TErr>(TActionKind LDEIKMFKKAJ, LLPGKPILGIG<TActionKind, TSerializedAction, TPayload> BCHDJBNBAEE, AJMAHACFIFI<TRoot, TPayload, TOk, TErr> NNDNIIDMFPD, bool BPALKLIGGGI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FOPCNMINEGF
	{
		return default(ODHHEHMOGNP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A0ACD0", Offset = "0x4A0A0D0", VA = "0x184A0ACD0")]
	public CJKPHJOADDL<TActionKind, TSerializedAction, TRoot, TDeps> KNNOOCDGMKC(TDeps CLOGBAKPPIL)
	{
		return default(CJKPHJOADDL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
