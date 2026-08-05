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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A87010", Offset = "0x2A85A10", VA = "0x182A87010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate BDAMMNIMKBN<TActionKind, TPayload> JLJNDDIOCED<TActionKind, TSerializedAction, TPayload>(TSerializedAction JBPMFFFDAML);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface LLMDKDDFDPK<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DOHEMIFBILP<object, EFLLFLJPHFD>> IIPBDKMNNFK(TDeps MADJNKEDNDC, TRoot PJFDNMGHMBL, TSerializedAction JBPMFFFDAML);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class ICNHLGLNMKH<TActionKind, TSerializedAction, TRoot, TDeps> : DCAIIPHPGFM where TDeps : OEECMLDGAGK.DCEIDGMMILB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps CHPBOPOCLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction KEGOJHOGCLG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x511D0C0", Offset = "0x511BAC0", VA = "0x18511D0C0")]
	public ICNHLGLNMKH([In] TDeps MADJNKEDNDC, [In] TSerializedAction JBPMFFFDAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x511CEA0", Offset = "0x511B8A0", VA = "0x18511CEA0", Slot = "7")]
	public override string GIDIGOEEAJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BDAMMNIMKBN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind JADBBEFHCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload AIAKNDHHCAE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64B4590", Offset = "0x64B2F90", VA = "0x1864B4590")]
	internal BDAMMNIMKBN(TActionKind KGNKPOAEGDI, [In] TPayload EEMEEFCIEHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MNGLOONIBED
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4B50", Offset = "0x3DB3550", VA = "0x183DB4B50")]
	public static BDAMMNIMKBN<TActionKind, TPayload> MDDJOGPLAFO<TActionKind, TPayload>([In] TActionKind KGNKPOAEGDI, [In] TPayload EEMEEFCIEHD)
	{
		return default(BDAMMNIMKBN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<DOHEMIFBILP<TOk, TErr>> GLJAPAHIGIB<TRoot, TPayload, TOk, TErr>(TRoot PJFDNMGHMBL, TPayload EEMEEFCIEHD);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate DOHEMIFBILP<TOk, TErr> JPNNJCLCADC<TRoot, TPayload, TOk, TErr>(TRoot PJFDNMGHMBL, [In] TPayload EEMEEFCIEHD);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IONIDCNJACC<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : OEECMLDGAGK.DCEIDGMMILB<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NKKFAAPEJLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<object?, EFLLFLJPHFD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IONIDCNJACC<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<DOHEMIFBILP<object, EFLLFLJPHFD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x58D3F50", Offset = "0x58D2950", VA = "0x1858D3F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x58D4850", Offset = "0x58D3250", VA = "0x1858D4850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, LLMDKDDFDPK<TSerializedAction, TRoot, TDeps>> JHKBMLKPGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps CHPBOPOCLBJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
	internal IONIDCNJACC(Dictionary<TActionKind, LLMDKDDFDPK<TSerializedAction, TRoot, TDeps>> MEJKAIONBHG, TDeps MADJNKEDNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5170E50", Offset = "0x516F850", VA = "0x185170E50")]
	[AsyncStateMachine(typeof(IONIDCNJACC<, , , >.NKKFAAPEJLN))]
	public Task<DOHEMIFBILP<object, EFLLFLJPHFD>> IIPBDKMNNFK(TRoot PJFDNMGHMBL, TSerializedAction JBPMFFFDAML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OEECMLDGAGK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DCEIDGMMILB<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EPOPMHLEPCA(TSerializedAction NLDLHIJAJBO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DBEPGFDCEBB(TRoot PJFDNMGHMBL, TSerializedAction FOAIPBIEILM);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FMINNPANFCF(TRoot PJFDNMGHMBL, TSerializedAction FOAIPBIEILM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4D40", Offset = "0x3CF3740", VA = "0x183CF4D40")]
	internal static IONIDCNJACC<TActionKind, TSerializedAction, TRoot, TDeps> MDDJOGPLAFO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, LLMDKDDFDPK<TSerializedAction, TRoot, TDeps>> MEJKAIONBHG, TDeps MADJNKEDNDC) where TDeps : DCEIDGMMILB<TActionKind, TSerializedAction, TRoot>
	{
		return default(IONIDCNJACC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LMBCDODPPDO<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, LLMDKDDFDPK<TSerializedAction, TRoot, TDeps>> GAAJJHNKDFD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	private LMBCDODPPDO(Dictionary<TActionKind, LLMDKDDFDPK<TSerializedAction, TRoot, TDeps>> MEJKAIONBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x561C310", Offset = "0x561AD10", VA = "0x18561C310")]
	public static LMBCDODPPDO<TActionKind, TSerializedAction, TRoot, TDeps> MDDJOGPLAFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KFCEICAGGIJ<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, OEECMLDGAGK.DCEIDGMMILB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class GJLBPGMMMPD<TPayload, TOk, TErr> : LLMDKDDFDPK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EFLLFLJPHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JLJNDDIOCED<TActionKind, TSerializedAction, TPayload> BCBBJDIAJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly JPNNJCLCADC<TRoot, TPayload, TOk, TErr> EJMBKMDPJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool LHNBDOKNFGD;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1C40840", Offset = "0x1C3F240", VA = "0x181C40840")]
		public GJLBPGMMMPD(JLJNDDIOCED<TActionKind, TSerializedAction, TPayload> EBHIBPPDOIF, JPNNJCLCADC<TRoot, TPayload, TOk, TErr> MCFHBCJBCCI, bool BOPGAHLLAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4F77850", Offset = "0x4F76250", VA = "0x184F77850", Slot = "4")]
		public Task<DOHEMIFBILP<object, EFLLFLJPHFD>> IIPBDKMNNFK(TDeps MADJNKEDNDC, TRoot PJFDNMGHMBL, TSerializedAction JBPMFFFDAML)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HALLHKOKHGD<TPayload, TOk, TErr> : LLMDKDDFDPK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EFLLFLJPHFD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct IGPHCAAAEJK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<DOHEMIFBILP<object?, EFLLFLJPHFD>> <>t__builder;

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
			public HALLHKOKHGD<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private DOHEMIFBILP<object?, EFLLFLJPHFD> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DOHEMIFBILP<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x514BB80", Offset = "0x514A580", VA = "0x18514BB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x514DAB0", Offset = "0x514C4B0", VA = "0x18514DAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly JLJNDDIOCED<TActionKind, TSerializedAction, TPayload> BCBBJDIAJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly GLJAPAHIGIB<TRoot, TPayload, TOk, TErr> EJMBKMDPJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool LHNBDOKNFGD;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1C40840", Offset = "0x1C3F240", VA = "0x181C40840")]
		public HALLHKOKHGD(JLJNDDIOCED<TActionKind, TSerializedAction, TPayload> EBHIBPPDOIF, GLJAPAHIGIB<TRoot, TPayload, TOk, TErr> MCFHBCJBCCI, bool BOPGAHLLAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4FEFFB0", Offset = "0x4FEE9B0", VA = "0x184FEFFB0", Slot = "4")]
		[AsyncStateMachine(typeof(HALLHKOKHGD<, , >.IGPHCAAAEJK))]
		public Task<DOHEMIFBILP<object, EFLLFLJPHFD>> IIPBDKMNNFK(TDeps MADJNKEDNDC, TRoot PJFDNMGHMBL, TSerializedAction JBPMFFFDAML)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LMBCDODPPDO<TActionKind, TSerializedAction, TRoot, TDeps> GOKKGMDJPOD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
	private KFCEICAGGIJ(LMBCDODPPDO<TActionKind, TSerializedAction, TRoot, TDeps> GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x54E80C0", Offset = "0x54E6AC0", VA = "0x1854E80C0")]
	public static KFCEICAGGIJ<TActionKind, TSerializedAction, TRoot, TDeps> MDDJOGPLAFO()
	{
		return default(KFCEICAGGIJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x43FFED0", Offset = "0x43FE8D0", VA = "0x1843FFED0")]
	public KFCEICAGGIJ<TActionKind, TSerializedAction, TRoot, TDeps> OMDPMHDDLNH<TPayload, TOk, TErr>(TActionKind KGNKPOAEGDI, JLJNDDIOCED<TActionKind, TSerializedAction, TPayload> EBHIBPPDOIF, JPNNJCLCADC<TRoot, TPayload, TOk, TErr> MCFHBCJBCCI, bool BOPGAHLLAHF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EFLLFLJPHFD
	{
		return default(KFCEICAGGIJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x43FFED0", Offset = "0x43FE8D0", VA = "0x1843FFED0")]
	public KFCEICAGGIJ<TActionKind, TSerializedAction, TRoot, TDeps> LMCDDBGBLOF<TPayload, TOk, TErr>(TActionKind KGNKPOAEGDI, JLJNDDIOCED<TActionKind, TSerializedAction, TPayload> EBHIBPPDOIF, GLJAPAHIGIB<TRoot, TPayload, TOk, TErr> MCFHBCJBCCI, bool BOPGAHLLAHF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EFLLFLJPHFD
	{
		return default(KFCEICAGGIJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x54E8010", Offset = "0x54E6A10", VA = "0x1854E8010")]
	public IONIDCNJACC<TActionKind, TSerializedAction, TRoot, TDeps> LCNCPIGDBHK(TDeps MADJNKEDNDC)
	{
		return default(IONIDCNJACC<TActionKind, TSerializedAction, TRoot, TDeps>);
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
