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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x15AEA80", Offset = "0x15ADC80", VA = "0x1815AEA80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct DOODBCPJMHH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind CAIHHGFEFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload LIACFCGJMAC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2EDC120", Offset = "0x2EDB320", VA = "0x182EDC120")]
	internal DOODBCPJMHH(TActionKind BLDBKGGFPPH, in TPayload DGLHFPEOHIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OGKNAOJFOLN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x34C6710", Offset = "0x34C5910", VA = "0x1834C6710")]
	public static DOODBCPJMHH<TActionKind, TPayload> NMBJFIHLDEO<TActionKind, TPayload>(in TActionKind BLDBKGGFPPH, in TPayload DGLHFPEOHIM)
	{
		return default(DOODBCPJMHH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface NMGKFLHABOB<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CLFKONEBOLH<object, IDFBCILOOIB>> JNNIOEACHNC(TDeps FLJLOPPINOK, TRoot NPDELNKHCNM, TSerializedAction ACCJKKMJNGB);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NHNKBALNNIF<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GGOEHBHPNHC.MCPBDMJAJBN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HODOPALOLMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<CLFKONEBOLH<object, IDFBCILOOIB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NHNKBALNNIF<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NMGKFLHABOB<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<CLFKONEBOLH<object, IDFBCILOOIB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public HODOPALOLMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9220", Offset = "0x2DD8420", VA = "0x182DD9220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, NMGKFLHABOB<TSerializedAction, TRoot, TDeps>> IJDFADPLDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps APHBGODKBHN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
	internal NHNKBALNNIF(Dictionary<TActionKind, NMGKFLHABOB<TSerializedAction, TRoot, TDeps>> LNNEGGMECBI, TDeps FLJLOPPINOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2F670B0", Offset = "0x2F662B0", VA = "0x182F670B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHNKBALNNIF<, , , >.HODOPALOLMC))]
	public Task<CLFKONEBOLH<object, IDFBCILOOIB>> JNNIOEACHNC(TRoot NPDELNKHCNM, TSerializedAction ACCJKKMJNGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GGOEHBHPNHC
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface MCPBDMJAJBN<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FAFKMHCKEML(TSerializedAction DCMHODHEGEC);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OIHNGMIEKEJ(TRoot NPDELNKHCNM, TSerializedAction JFFMHPNGJBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B018B0", Offset = "0x2B00AB0", VA = "0x182B018B0")]
	internal static NHNKBALNNIF<TActionKind, TSerializedAction, TRoot, TDeps> NMBJFIHLDEO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, NMGKFLHABOB<TSerializedAction, TRoot, TDeps>> LNNEGGMECBI, TDeps FLJLOPPINOK) where TDeps : MCPBDMJAJBN<TActionKind, TSerializedAction, TRoot>
	{
		return default(NHNKBALNNIF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate CLFKONEBOLH<TOk, TErr> DPMOJKLNGOL<TRoot, TPayload, TOk, TErr>(TRoot NPDELNKHCNM, in TPayload DGLHFPEOHIM);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class LEJGMHCEMML<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, NMGKFLHABOB<TSerializedAction, TRoot, TDeps>> NKFHPGCJIPI;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC600", Offset = "0x1CCB800", VA = "0x181CCC600")]
	private LEJGMHCEMML(Dictionary<TActionKind, NMGKFLHABOB<TSerializedAction, TRoot, TDeps>> LNNEGGMECBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3542BE0", Offset = "0x3541DE0", VA = "0x183542BE0")]
	public static LEJGMHCEMML<TActionKind, TSerializedAction, TRoot, TDeps> NMBJFIHLDEO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<CLFKONEBOLH<TOk, TErr>> MGCFKPIABOP<TRoot, TPayload, TOk, TErr>(TRoot NPDELNKHCNM, TPayload DGLHFPEOHIM);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class JLFDKJPJNGN<TActionKind, TSerializedAction, TRoot, TDeps> : EOPGPABPDLG where TDeps : GGOEHBHPNHC.MCPBDMJAJBN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps APHBGODKBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction GPNLKDIPGGB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x36126B0", Offset = "0x36118B0", VA = "0x1836126B0")]
	public JLFDKJPJNGN(in TDeps FLJLOPPINOK, in TSerializedAction ACCJKKMJNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3612580", Offset = "0x3611780", VA = "0x183612580", Slot = "7")]
	public override string OFGOCDOINLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate DOODBCPJMHH<TActionKind, TPayload> PNEOEDCPJKP<TActionKind, TSerializedAction, TPayload>(TSerializedAction ACCJKKMJNGB);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OOBJJFNMLJK<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GGOEHBHPNHC.MCPBDMJAJBN<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LHIEDDFABFL<TPayload, TOk, TErr> : NMGKFLHABOB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IDFBCILOOIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly PNEOEDCPJKP<TActionKind, TSerializedAction, TPayload> JHKDANCNLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DPMOJKLNGOL<TRoot, TPayload, TOk, TErr> HEEFEHENBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool PGBCJCAFKBN;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x366ACB0", Offset = "0x3669EB0", VA = "0x18366ACB0")]
		public LHIEDDFABFL(PNEOEDCPJKP<TActionKind, TSerializedAction, TPayload> CCFIJMGBPDK, DPMOJKLNGOL<TRoot, TPayload, TOk, TErr> HFEIECNKPBG, bool NJEFLCKPNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38F02F0", Offset = "0x38EF4F0", VA = "0x1838F02F0", Slot = "4")]
		public Task<CLFKONEBOLH<object, IDFBCILOOIB>> JNNIOEACHNC(TDeps FLJLOPPINOK, TRoot NPDELNKHCNM, TSerializedAction ACCJKKMJNGB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class EKJBJPJLLIH<TPayload, TOk, TErr> : NMGKFLHABOB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IDFBCILOOIB
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class EJMABJKOEMK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC62B0", Offset = "0xC56B0")]
			public AsyncTaskMethodBuilder<CLFKONEBOLH<object, IDFBCILOOIB>> <>t__builder;

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
			public EKJBJPJLLIH<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC6310", Offset = "0xC5710")]
			private CLFKONEBOLH<object, IDFBCILOOIB> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC6370", Offset = "0xC5770")]
			private DOODBCPJMHH<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC63D0", Offset = "0xC57D0")]
			private CLFKONEBOLH<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC6430", Offset = "0xC5830")]
			private CLFKONEBOLH<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC6490", Offset = "0xC5890")]
			private TaskAwaiter<CLFKONEBOLH<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public EJMABJKOEMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x448DED0", Offset = "0x448D0D0", VA = "0x18448DED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly PNEOEDCPJKP<TActionKind, TSerializedAction, TPayload> JHKDANCNLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly MGCFKPIABOP<TRoot, TPayload, TOk, TErr> HEEFEHENBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool PGBCJCAFKBN;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x366ACB0", Offset = "0x3669EB0", VA = "0x18366ACB0")]
		public EKJBJPJLLIH(PNEOEDCPJKP<TActionKind, TSerializedAction, TPayload> CCFIJMGBPDK, MGCFKPIABOP<TRoot, TPayload, TOk, TErr> HFEIECNKPBG, bool NJEFLCKPNPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x366A8F0", Offset = "0x3669AF0", VA = "0x18366A8F0", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(EKJBJPJLLIH<, , >.EJMABJKOEMK))]
		public Task<CLFKONEBOLH<object, IDFBCILOOIB>> JNNIOEACHNC(TDeps FLJLOPPINOK, TRoot NPDELNKHCNM, TSerializedAction ACCJKKMJNGB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LEJGMHCEMML<TActionKind, TSerializedAction, TRoot, TDeps> CDJJIIOMFGC;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	private OOBJJFNMLJK(LEJGMHCEMML<TActionKind, TSerializedAction, TRoot, TDeps> JCEJEOAKGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3249000", Offset = "0x3248200", VA = "0x183249000")]
	public static OOBJJFNMLJK<TActionKind, TSerializedAction, TRoot, TDeps> NMBJFIHLDEO()
	{
		return default(OOBJJFNMLJK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x24FD7C0", Offset = "0x24FC9C0", VA = "0x1824FD7C0")]
	public OOBJJFNMLJK<TActionKind, TSerializedAction, TRoot, TDeps> ICMCMHIFHCP<TPayload, TOk, TErr>(TActionKind BLDBKGGFPPH, PNEOEDCPJKP<TActionKind, TSerializedAction, TPayload> CCFIJMGBPDK, DPMOJKLNGOL<TRoot, TPayload, TOk, TErr> HFEIECNKPBG, bool NJEFLCKPNPI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IDFBCILOOIB
	{
		return default(OOBJJFNMLJK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x24FD7C0", Offset = "0x24FC9C0", VA = "0x1824FD7C0")]
	public OOBJJFNMLJK<TActionKind, TSerializedAction, TRoot, TDeps> PMGKBILEEKG<TPayload, TOk, TErr>(TActionKind BLDBKGGFPPH, PNEOEDCPJKP<TActionKind, TSerializedAction, TPayload> CCFIJMGBPDK, MGCFKPIABOP<TRoot, TPayload, TOk, TErr> HFEIECNKPBG, bool NJEFLCKPNPI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IDFBCILOOIB
	{
		return default(OOBJJFNMLJK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3248F50", Offset = "0x3248150", VA = "0x183248F50")]
	public NHNKBALNNIF<TActionKind, TSerializedAction, TRoot, TDeps> DNFFBAJCDFF(TDeps FLJLOPPINOK)
	{
		return default(NHNKBALNNIF<TActionKind, TSerializedAction, TRoot, TDeps>);
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
