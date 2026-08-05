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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCEBF0", Offset = "0x1CCDFF0", VA = "0x181CCEBF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate FELGLDLEHEI<TActionKind, TPayload> OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload>(TSerializedAction FLJHEIIPNBD);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CABONCEGPCC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> IOJNKOBNCPI(TDeps MCFGCLDLEGH, TRoot AFFGDBELLLE, TSerializedAction FLJHEIIPNBD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IELGAMOEGOF<TActionKind, TSerializedAction, TRoot, TDeps> : BPKDACEDAGC where TDeps : KOFCDIJFKKJ.GFLBHNNCDHI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps MHDAFDFFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction GOGGKLLCPHE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3742FF0", Offset = "0x37423F0", VA = "0x183742FF0")]
	public IELGAMOEGOF([In] TDeps MCFGCLDLEGH, [In] TSerializedAction FLJHEIIPNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3742E80", Offset = "0x3742280", VA = "0x183742E80", Slot = "7")]
	public override string KHDKMLPELIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FELGLDLEHEI<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind KBOIAAGMOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload MBCPOEAOCAM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3462130", Offset = "0x3461530", VA = "0x183462130")]
	internal FELGLDLEHEI(TActionKind MKNGFPCPGEH, [In] TPayload LJIMLOGOIHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BFJDNBFINFF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22C0100", Offset = "0x22BF500", VA = "0x1822C0100")]
	public static FELGLDLEHEI<TActionKind, TPayload> PBDMNAJCIOP<TActionKind, TPayload>([In] TActionKind MKNGFPCPGEH, [In] TPayload LJIMLOGOIHA)
	{
		return default(FELGLDLEHEI<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<EFPDAHOJLMO<TOk, TErr>> JIFJPCNLHMO<TRoot, TPayload, TOk, TErr>(TRoot AFFGDBELLLE, TPayload LJIMLOGOIHA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate EFPDAHOJLMO<TOk, TErr> COKLFLPJGGL<TRoot, TPayload, TOk, TErr>(TRoot AFFGDBELLLE, [In] TPayload LJIMLOGOIHA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DOLMOECDOFK<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : KOFCDIJFKKJ.GFLBHNNCDHI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LKCDNNAHCAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public DOLMOECDOFK<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AA57A0", Offset = "0x3AA4BA0", VA = "0x183AA57A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5C30", Offset = "0x3AA5030", VA = "0x183AA5C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, CABONCEGPCC<TSerializedAction, TRoot, TDeps>> EKPADMJDONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps MHDAFDFFEGC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82CAC0", Offset = "0x82BEC0", VA = "0x18082CAC0")]
	internal DOLMOECDOFK(Dictionary<TActionKind, CABONCEGPCC<TSerializedAction, TRoot, TDeps>> JNFNOMLKAED, TDeps MCFGCLDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DEBEC0", Offset = "0x4DEB2C0", VA = "0x184DEBEC0")]
	[AsyncStateMachine(typeof(DOLMOECDOFK<, , , >.LKCDNNAHCAO))]
	public Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> IOJNKOBNCPI(TRoot AFFGDBELLLE, TSerializedAction FLJHEIIPNBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KOFCDIJFKKJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GFLBHNNCDHI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FODGAKDFCHE(TSerializedAction EAODMOEAJOC);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CPMLFEMAPDK(TRoot AFFGDBELLLE, TSerializedAction ONCLGAMIHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2525DD0", Offset = "0x25251D0", VA = "0x182525DD0")]
	internal static DOLMOECDOFK<TActionKind, TSerializedAction, TRoot, TDeps> PBDMNAJCIOP<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, CABONCEGPCC<TSerializedAction, TRoot, TDeps>> JNFNOMLKAED, TDeps MCFGCLDLEGH) where TDeps : GFLBHNNCDHI<TActionKind, TSerializedAction, TRoot>
	{
		return default(DOLMOECDOFK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class OGJBILKFKJO<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, CABONCEGPCC<TSerializedAction, TRoot, TDeps>> HIEFKEGPKFP;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	private OGJBILKFKJO(Dictionary<TActionKind, CABONCEGPCC<TSerializedAction, TRoot, TDeps>> JNFNOMLKAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE760", Offset = "0x3DFDB60", VA = "0x183DFE760")]
	public static OGJBILKFKJO<TActionKind, TSerializedAction, TRoot, TDeps> PBDMNAJCIOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, KOFCDIJFKKJ.GFLBHNNCDHI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class FDOEIFJPPBO<TPayload, TOk, TErr> : CABONCEGPCC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHJGGJPMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> EPJDHCDNHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly COKLFLPJGGL<TRoot, TPayload, TOk, TErr> DKONIMIPKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool BBMLNKPEFDP;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3461700", Offset = "0x3460B00", VA = "0x183461700")]
		public FDOEIFJPPBO(OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> IODMDOOJJPA, COKLFLPJGGL<TRoot, TPayload, TOk, TErr> HCDBJFLDBMC, bool KHKFBOOPCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x345B740", Offset = "0x345AB40", VA = "0x18345B740", Slot = "4")]
		public Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> IOJNKOBNCPI(TDeps MCFGCLDLEGH, TRoot AFFGDBELLLE, TSerializedAction FLJHEIIPNBD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HBMBOMLLPPD<TPayload, TOk, TErr> : CABONCEGPCC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHJGGJPMD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DGELEIIBAIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<EFPDAHOJLMO<object?, CKBHJGGJPMD>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HBMBOMLLPPD<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private EFPDAHOJLMO<object?, CKBHJGGJPMD> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<EFPDAHOJLMO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4DCE6F0", Offset = "0x4DCDAF0", VA = "0x184DCE6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEFE0", Offset = "0x4DCE3E0", VA = "0x184DCEFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> EPJDHCDNHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly JIFJPCNLHMO<TRoot, TPayload, TOk, TErr> DKONIMIPKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool BBMLNKPEFDP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3461700", Offset = "0x3460B00", VA = "0x183461700")]
		public HBMBOMLLPPD(OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> IODMDOOJJPA, JIFJPCNLHMO<TRoot, TPayload, TOk, TErr> HCDBJFLDBMC, bool KHKFBOOPCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35D0680", Offset = "0x35CFA80", VA = "0x1835D0680", Slot = "4")]
		[AsyncStateMachine(typeof(HBMBOMLLPPD<, , >.DGELEIIBAIP))]
		public Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> IOJNKOBNCPI(TDeps MCFGCLDLEGH, TRoot AFFGDBELLLE, TSerializedAction FLJHEIIPNBD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OGJBILKFKJO<TActionKind, TSerializedAction, TRoot, TDeps> GGMGCHKNJCM;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
	private JDJIIMICIMD(OGJBILKFKJO<TActionKind, TSerializedAction, TRoot, TDeps> KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38E8970", Offset = "0x38E7D70", VA = "0x1838E8970")]
	public static JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps> PBDMNAJCIOP()
	{
		return default(JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x20EC0F0", Offset = "0x20EB4F0", VA = "0x1820EC0F0")]
	public JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps> OOCFJINCDKK<TPayload, TOk, TErr>(TActionKind MKNGFPCPGEH, OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> IODMDOOJJPA, COKLFLPJGGL<TRoot, TPayload, TOk, TErr> HCDBJFLDBMC, bool KHKFBOOPCNL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHJGGJPMD
	{
		return default(JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x20EC0F0", Offset = "0x20EB4F0", VA = "0x1820EC0F0")]
	public JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps> GIIJGHPMFHC<TPayload, TOk, TErr>(TActionKind MKNGFPCPGEH, OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> IODMDOOJJPA, JIFJPCNLHMO<TRoot, TPayload, TOk, TErr> HCDBJFLDBMC, bool KHKFBOOPCNL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHJGGJPMD
	{
		return default(JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38E88C0", Offset = "0x38E7CC0", VA = "0x1838E88C0")]
	public DOLMOECDOFK<TActionKind, TSerializedAction, TRoot, TDeps> DGNONMCIIPC(TDeps MCFGCLDLEGH)
	{
		return default(DOLMOECDOFK<TActionKind, TSerializedAction, TRoot, TDeps>);
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
