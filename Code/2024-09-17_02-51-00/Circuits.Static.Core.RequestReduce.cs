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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x2175040", Offset = "0x2173A40", VA = "0x182175040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate NEEHLPPFFPM<TActionKind, TPayload> BLONFDLCANG<TActionKind, TSerializedAction, TPayload>(TSerializedAction NNIGPJHCHMO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface PJGEEBFMFMA<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> PCINKCMIJED(TDeps LAKCFHGOLJA, TRoot JPBBEMPIGCM, TSerializedAction NNIGPJHCHMO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LGPIMDNPHPN<TActionKind, TSerializedAction, TRoot, TDeps> : NGACCPLNJOL where TDeps : KOAFOGCPACB.IIALHHDPMEC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps FJKKNCLMNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction JLOKDEDEPJE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x44D2810", Offset = "0x44D1210", VA = "0x1844D2810")]
	public LGPIMDNPHPN([In] TDeps LAKCFHGOLJA, [In] TSerializedAction NNIGPJHCHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x44D26E0", Offset = "0x44D10E0", VA = "0x1844D26E0", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NEEHLPPFFPM<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind LNLJAFNEIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload GHKEPGKNIOE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x47DDE70", Offset = "0x47DC870", VA = "0x1847DDE70")]
	internal NEEHLPPFFPM(TActionKind JCCOBLDALOL, [In] TPayload AJFODGMHKJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BJPPHOFECPG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3270", Offset = "0x2AD1C70", VA = "0x182AD3270")]
	public static NEEHLPPFFPM<TActionKind, TPayload> GGBAHLJJLHO<TActionKind, TPayload>([In] TActionKind JCCOBLDALOL, [In] TPayload AJFODGMHKJN)
	{
		return default(NEEHLPPFFPM<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<BCLNLKLFCPB<TOk, TErr>> FAAODLPGKMI<TRoot, TPayload, TOk, TErr>(TRoot JPBBEMPIGCM, TPayload AJFODGMHKJN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate BCLNLKLFCPB<TOk, TErr> KABCKJONHFF<TRoot, TPayload, TOk, TErr>(TRoot JPBBEMPIGCM, [In] TPayload AJFODGMHKJN);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct POKNCEFGIAN<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : KOAFOGCPACB.IIALHHDPMEC<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JIADAAMNPKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public POKNCEFGIAN<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<BCLNLKLFCPB<object, OBJIPJOMIPB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x429CC90", Offset = "0x429B690", VA = "0x18429CC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x429D130", Offset = "0x429BB30", VA = "0x18429D130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, PJGEEBFMFMA<TSerializedAction, TRoot, TDeps>> GBDIFIFBLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps FJKKNCLMNHM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
	internal POKNCEFGIAN(Dictionary<TActionKind, PJGEEBFMFMA<TSerializedAction, TRoot, TDeps>> ADCBINJHLAF, TDeps LAKCFHGOLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A28310", Offset = "0x4A26D10", VA = "0x184A28310")]
	[AsyncStateMachine(typeof(POKNCEFGIAN<, , , >.JIADAAMNPKJ))]
	public Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> PCINKCMIJED(TRoot JPBBEMPIGCM, TSerializedAction NNIGPJHCHMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KOAFOGCPACB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IIALHHDPMEC<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind MJPAOJNCCOI(TSerializedAction BJNJBGHPMEH);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IBEDCEFHOBK(TRoot JPBBEMPIGCM, TSerializedAction PMCMEAHOBEF);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NODKBPMCPAF(TRoot JPBBEMPIGCM, TSerializedAction PMCMEAHOBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2E08FC0", Offset = "0x2E079C0", VA = "0x182E08FC0")]
	internal static POKNCEFGIAN<TActionKind, TSerializedAction, TRoot, TDeps> GGBAHLJJLHO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, PJGEEBFMFMA<TSerializedAction, TRoot, TDeps>> ADCBINJHLAF, TDeps LAKCFHGOLJA) where TDeps : IIALHHDPMEC<TActionKind, TSerializedAction, TRoot>
	{
		return default(POKNCEFGIAN<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MPPICOIEAIJ<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, PJGEEBFMFMA<TSerializedAction, TRoot, TDeps>> EACOPKFOJKN;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	private MPPICOIEAIJ(Dictionary<TActionKind, PJGEEBFMFMA<TSerializedAction, TRoot, TDeps>> ADCBINJHLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x47938F0", Offset = "0x47922F0", VA = "0x1847938F0")]
	public static MPPICOIEAIJ<TActionKind, TSerializedAction, TRoot, TDeps> GGBAHLJJLHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct NLEPKENBEGE<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, KOAFOGCPACB.IIALHHDPMEC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CKJMPCBOFHO<TPayload, TOk, TErr> : PJGEEBFMFMA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OBJIPJOMIPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BLONFDLCANG<TActionKind, TSerializedAction, TPayload> KBKCBDDMMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KABCKJONHFF<TRoot, TPayload, TOk, TErr> EPEJLIPELOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool HFJCMIACKCL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DD43B0", Offset = "0x3DD2DB0", VA = "0x183DD43B0")]
		public CKJMPCBOFHO(BLONFDLCANG<TActionKind, TSerializedAction, TPayload> FIAOFPJPOPA, KABCKJONHFF<TRoot, TPayload, TOk, TErr> KEMDBPHKIKA, bool KGFHMHEHKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5682700", Offset = "0x5681100", VA = "0x185682700", Slot = "4")]
		public Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> PCINKCMIJED(TDeps LAKCFHGOLJA, TRoot JPBBEMPIGCM, TSerializedAction NNIGPJHCHMO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class FACGKCACNJE<TPayload, TOk, TErr> : PJGEEBFMFMA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, OBJIPJOMIPB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct FFHKODPLGNI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<BCLNLKLFCPB<object?, OBJIPJOMIPB>> <>t__builder;

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
			public FACGKCACNJE<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private BCLNLKLFCPB<object?, OBJIPJOMIPB> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BCLNLKLFCPB<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3DEF5A0", Offset = "0x3DEDFA0", VA = "0x183DEF5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3DF1030", Offset = "0x3DEFA30", VA = "0x183DF1030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly BLONFDLCANG<TActionKind, TSerializedAction, TPayload> KBKCBDDMMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly FAAODLPGKMI<TRoot, TPayload, TOk, TErr> EPEJLIPELOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool HFJCMIACKCL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3DD43B0", Offset = "0x3DD2DB0", VA = "0x183DD43B0")]
		public FACGKCACNJE(BLONFDLCANG<TActionKind, TSerializedAction, TPayload> FIAOFPJPOPA, FAAODLPGKMI<TRoot, TPayload, TOk, TErr> KEMDBPHKIKA, bool KGFHMHEHKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3CD0", Offset = "0x3DD26D0", VA = "0x183DD3CD0", Slot = "4")]
		[AsyncStateMachine(typeof(FACGKCACNJE<, , >.FFHKODPLGNI))]
		public Task<BCLNLKLFCPB<object, OBJIPJOMIPB>> PCINKCMIJED(TDeps LAKCFHGOLJA, TRoot JPBBEMPIGCM, TSerializedAction NNIGPJHCHMO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MPPICOIEAIJ<TActionKind, TSerializedAction, TRoot, TDeps> JBPNOBDOEDI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	private NLEPKENBEGE(MPPICOIEAIJ<TActionKind, TSerializedAction, TRoot, TDeps> JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4800E50", Offset = "0x47FF850", VA = "0x184800E50")]
	public static NLEPKENBEGE<TActionKind, TSerializedAction, TRoot, TDeps> GGBAHLJJLHO()
	{
		return default(NLEPKENBEGE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E76000", Offset = "0x2E74A00", VA = "0x182E76000")]
	public NLEPKENBEGE<TActionKind, TSerializedAction, TRoot, TDeps> HKEDDLMKPAB<TPayload, TOk, TErr>(TActionKind JCCOBLDALOL, BLONFDLCANG<TActionKind, TSerializedAction, TPayload> FIAOFPJPOPA, KABCKJONHFF<TRoot, TPayload, TOk, TErr> KEMDBPHKIKA, bool KGFHMHEHKJL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OBJIPJOMIPB
	{
		return default(NLEPKENBEGE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E76000", Offset = "0x2E74A00", VA = "0x182E76000")]
	public NLEPKENBEGE<TActionKind, TSerializedAction, TRoot, TDeps> MGHIDMMLPAB<TPayload, TOk, TErr>(TActionKind JCCOBLDALOL, BLONFDLCANG<TActionKind, TSerializedAction, TPayload> FIAOFPJPOPA, FAAODLPGKMI<TRoot, TPayload, TOk, TErr> KEMDBPHKIKA, bool KGFHMHEHKJL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, OBJIPJOMIPB
	{
		return default(NLEPKENBEGE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4800EF0", Offset = "0x47FF8F0", VA = "0x184800EF0")]
	public POKNCEFGIAN<TActionKind, TSerializedAction, TRoot, TDeps> MIFABMICKLO(TDeps LAKCFHGOLJA)
	{
		return default(POKNCEFGIAN<TActionKind, TSerializedAction, TRoot, TDeps>);
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
