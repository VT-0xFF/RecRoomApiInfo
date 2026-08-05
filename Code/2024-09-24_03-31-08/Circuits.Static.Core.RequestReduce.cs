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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x215CD00", Offset = "0x215B700", VA = "0x18215CD00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate BJDDGKIBOMA<TActionKind, TPayload> EHPHPEBGHDE<TActionKind, TSerializedAction, TPayload>(TSerializedAction MMMPPAHBFBB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface KGFILOFENOH<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CDOLGFBAJII<object, IDHCEFLHBPO>> NGKMHBIDPIH(TDeps HBFCALFCDLO, TRoot BAFHJDFHJHD, TSerializedAction MMMPPAHBFBB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IOCDKNJOBMF<TActionKind, TSerializedAction, TRoot, TDeps> : ILCEMBFLKNK where TDeps : DAPKHMLEODH.HCJIIBBHIBA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps GBEKAPOEJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction NJAINKFNKAJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x40CE360", Offset = "0x40CCD60", VA = "0x1840CE360")]
	public IOCDKNJOBMF([In] TDeps HBFCALFCDLO, [In] TSerializedAction MMMPPAHBFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x40CE290", Offset = "0x40CCC90", VA = "0x1840CE290", Slot = "7")]
	public override string OIFECEDJIAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BJDDGKIBOMA<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind GBIKNCLBPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload GDPEJEMCKCO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50EC730", Offset = "0x50EB130", VA = "0x1850EC730")]
	internal BJDDGKIBOMA(TActionKind MGJAIJOEFFE, [In] TPayload HDOCILHNNDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CJDFBLKNMNI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B5AFE0", Offset = "0x2B599E0", VA = "0x182B5AFE0")]
	public static BJDDGKIBOMA<TActionKind, TPayload> OOAFHJGKFEK<TActionKind, TPayload>([In] TActionKind MGJAIJOEFFE, [In] TPayload HDOCILHNNDE)
	{
		return default(BJDDGKIBOMA<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CDOLGFBAJII<TOk, TErr>> EJNHBOJECAG<TRoot, TPayload, TOk, TErr>(TRoot BAFHJDFHJHD, TPayload HDOCILHNNDE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CDOLGFBAJII<TOk, TErr> GDEEONFMHJJ<TRoot, TPayload, TOk, TErr>(TRoot BAFHJDFHJHD, [In] TPayload HDOCILHNNDE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct EDODEPLDHJM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : DAPKHMLEODH.HCJIIBBHIBA<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KMFMPEKCCNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CDOLGFBAJII<object, IDHCEFLHBPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public EDODEPLDHJM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CDOLGFBAJII<object, IDHCEFLHBPO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x43E3840", Offset = "0x43E2240", VA = "0x1843E3840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x43E3CC0", Offset = "0x43E26C0", VA = "0x1843E3CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, KGFILOFENOH<TSerializedAction, TRoot, TDeps>> BLGNOIBLOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps GBEKAPOEJCH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
	internal EDODEPLDHJM(Dictionary<TActionKind, KGFILOFENOH<TSerializedAction, TRoot, TDeps>> KMAGJOLFLPB, TDeps HBFCALFCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A04B50", Offset = "0x3A03550", VA = "0x183A04B50")]
	[AsyncStateMachine(typeof(EDODEPLDHJM<, , , >.KMFMPEKCCNO))]
	public Task<CDOLGFBAJII<object, IDHCEFLHBPO>> NGKMHBIDPIH(TRoot BAFHJDFHJHD, TSerializedAction MMMPPAHBFBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DAPKHMLEODH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HCJIIBBHIBA<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind KJGAFLNMMEF(TSerializedAction NKCEKILMAAM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JKGALBKMEDM(TRoot BAFHJDFHJHD, TSerializedAction GGEEGOKOMKJ);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PIFIKLBEDIP(TRoot BAFHJDFHJHD, TSerializedAction GGEEGOKOMKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2AC91E0", Offset = "0x2AC7BE0", VA = "0x182AC91E0")]
	internal static EDODEPLDHJM<TActionKind, TSerializedAction, TRoot, TDeps> OOAFHJGKFEK<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, KGFILOFENOH<TSerializedAction, TRoot, TDeps>> KMAGJOLFLPB, TDeps HBFCALFCDLO) where TDeps : HCJIIBBHIBA<TActionKind, TSerializedAction, TRoot>
	{
		return default(EDODEPLDHJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class PHCENJAHPKM<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, KGFILOFENOH<TSerializedAction, TRoot, TDeps>> FEENDKNGPJD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	private PHCENJAHPKM(Dictionary<TActionKind, KGFILOFENOH<TSerializedAction, TRoot, TDeps>> KMAGJOLFLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x49A89B0", Offset = "0x49A73B0", VA = "0x1849A89B0")]
	public static PHCENJAHPKM<TActionKind, TSerializedAction, TRoot, TDeps> OOAFHJGKFEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JMCKBGJHBBD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, DAPKHMLEODH.HCJIIBBHIBA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CKKCOLNEMEH<TPayload, TOk, TErr> : KGFILOFENOH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IDHCEFLHBPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EHPHPEBGHDE<TActionKind, TSerializedAction, TPayload> KOHJACFCHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly GDEEONFMHJJ<TRoot, TPayload, TOk, TErr> CBGDCBBMMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool LEEAJKMGGNK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3A036E0", Offset = "0x3A020E0", VA = "0x183A036E0")]
		public CKKCOLNEMEH(EHPHPEBGHDE<TActionKind, TSerializedAction, TPayload> FNJIDILPNPF, GDEEONFMHJJ<TRoot, TPayload, TOk, TErr> HMHIAIOMGOA, bool NGPFGLDLAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x54E1FA0", Offset = "0x54E09A0", VA = "0x1854E1FA0", Slot = "4")]
		public Task<CDOLGFBAJII<object, IDHCEFLHBPO>> NGKMHBIDPIH(TDeps HBFCALFCDLO, TRoot BAFHJDFHJHD, TSerializedAction MMMPPAHBFBB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class ECEMMEADIIM<TPayload, TOk, TErr> : KGFILOFENOH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IDHCEFLHBPO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JBOFGFOKENH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CDOLGFBAJII<object?, IDHCEFLHBPO>> <>t__builder;

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
			public ECEMMEADIIM<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private CDOLGFBAJII<object?, IDHCEFLHBPO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CDOLGFBAJII<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4270C20", Offset = "0x426F620", VA = "0x184270C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x42716B0", Offset = "0x42700B0", VA = "0x1842716B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly EHPHPEBGHDE<TActionKind, TSerializedAction, TPayload> KOHJACFCHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly EJNHBOJECAG<TRoot, TPayload, TOk, TErr> CBGDCBBMMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool LEEAJKMGGNK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3A036E0", Offset = "0x3A020E0", VA = "0x183A036E0")]
		public ECEMMEADIIM(EHPHPEBGHDE<TActionKind, TSerializedAction, TPayload> FNJIDILPNPF, EJNHBOJECAG<TRoot, TPayload, TOk, TErr> HMHIAIOMGOA, bool NGPFGLDLAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3A031A0", Offset = "0x3A01BA0", VA = "0x183A031A0", Slot = "4")]
		[AsyncStateMachine(typeof(ECEMMEADIIM<, , >.JBOFGFOKENH))]
		public Task<CDOLGFBAJII<object, IDHCEFLHBPO>> NGKMHBIDPIH(TDeps HBFCALFCDLO, TRoot BAFHJDFHJHD, TSerializedAction MMMPPAHBFBB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly PHCENJAHPKM<TActionKind, TSerializedAction, TRoot, TDeps> DGNCMKLODFJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	private JMCKBGJHBBD(PHCENJAHPKM<TActionKind, TSerializedAction, TRoot, TDeps> LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x43060B0", Offset = "0x4304AB0", VA = "0x1843060B0")]
	public static JMCKBGJHBBD<TActionKind, TSerializedAction, TRoot, TDeps> OOAFHJGKFEK()
	{
		return default(JMCKBGJHBBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C06170", Offset = "0x2C04B70", VA = "0x182C06170")]
	public JMCKBGJHBBD<TActionKind, TSerializedAction, TRoot, TDeps> OPABLNCDGAJ<TPayload, TOk, TErr>(TActionKind MGJAIJOEFFE, EHPHPEBGHDE<TActionKind, TSerializedAction, TPayload> FNJIDILPNPF, GDEEONFMHJJ<TRoot, TPayload, TOk, TErr> HMHIAIOMGOA, bool NGPFGLDLAKE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IDHCEFLHBPO
	{
		return default(JMCKBGJHBBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C06170", Offset = "0x2C04B70", VA = "0x182C06170")]
	public JMCKBGJHBBD<TActionKind, TSerializedAction, TRoot, TDeps> PANMAIAJCPC<TPayload, TOk, TErr>(TActionKind MGJAIJOEFFE, EHPHPEBGHDE<TActionKind, TSerializedAction, TPayload> FNJIDILPNPF, EJNHBOJECAG<TRoot, TPayload, TOk, TErr> HMHIAIOMGOA, bool NGPFGLDLAKE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IDHCEFLHBPO
	{
		return default(JMCKBGJHBBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4305FF0", Offset = "0x43049F0", VA = "0x184305FF0")]
	public EDODEPLDHJM<TActionKind, TSerializedAction, TRoot, TDeps> OLCHHCBEFGJ(TDeps HBFCALFCDLO)
	{
		return default(EDODEPLDHJM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
