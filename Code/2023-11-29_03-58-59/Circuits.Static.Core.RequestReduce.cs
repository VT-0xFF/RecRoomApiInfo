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
		[Cpp2IlInjected.Address(RVA = "0x1CCEA00", Offset = "0x1CCDE00", VA = "0x181CCEA00")]
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
	[Cpp2IlInjected.Address(RVA = "0x3741A40", Offset = "0x3740E40", VA = "0x183741A40")]
	public IELGAMOEGOF([In] TDeps MCFGCLDLEGH, [In] TSerializedAction FLJHEIIPNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37418D0", Offset = "0x3740CD0", VA = "0x1837418D0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x34609E0", Offset = "0x345FDE0", VA = "0x1834609E0")]
	internal FELGLDLEHEI(TActionKind MKNGFPCPGEH, [In] TPayload LJIMLOGOIHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BFJDNBFINFF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22C0040", Offset = "0x22BF440", VA = "0x1822C0040")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AA4330", Offset = "0x3AA3730", VA = "0x183AA4330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AA47C0", Offset = "0x3AA3BC0", VA = "0x183AA47C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x82CA80", Offset = "0x82BE80", VA = "0x18082CA80")]
	internal DOLMOECDOFK(Dictionary<TActionKind, CABONCEGPCC<TSerializedAction, TRoot, TDeps>> JNFNOMLKAED, TDeps MCFGCLDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DEC000", Offset = "0x4DEB400", VA = "0x184DEC000")]
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
	[Cpp2IlInjected.Address(RVA = "0x2525D40", Offset = "0x2525140", VA = "0x182525D40")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DFD310", Offset = "0x3DFC710", VA = "0x183DFD310")]
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
		[Cpp2IlInjected.Address(RVA = "0x3460970", Offset = "0x345FD70", VA = "0x183460970")]
		public FDOEIFJPPBO(OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> IODMDOOJJPA, COKLFLPJGGL<TRoot, TPayload, TOk, TErr> HCDBJFLDBMC, bool KHKFBOOPCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x345A5E0", Offset = "0x34599E0", VA = "0x18345A5E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DCE7D0", Offset = "0x4DCDBD0", VA = "0x184DCE7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4DCF0C0", Offset = "0x4DCE4C0", VA = "0x184DCF0C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3460970", Offset = "0x345FD70", VA = "0x183460970")]
		public HBMBOMLLPPD(OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> IODMDOOJJPA, JIFJPCNLHMO<TRoot, TPayload, TOk, TErr> HCDBJFLDBMC, bool KHKFBOOPCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35CF010", Offset = "0x35CE410", VA = "0x1835CF010", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x871B00", Offset = "0x870F00", VA = "0x180871B00")]
	private JDJIIMICIMD(OGJBILKFKJO<TActionKind, TSerializedAction, TRoot, TDeps> KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38E73C0", Offset = "0x38E67C0", VA = "0x1838E73C0")]
	public static JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps> PBDMNAJCIOP()
	{
		return default(JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x20EC030", Offset = "0x20EB430", VA = "0x1820EC030")]
	public JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps> OOCFJINCDKK<TPayload, TOk, TErr>(TActionKind MKNGFPCPGEH, OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> IODMDOOJJPA, COKLFLPJGGL<TRoot, TPayload, TOk, TErr> HCDBJFLDBMC, bool KHKFBOOPCNL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHJGGJPMD
	{
		return default(JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x20EC030", Offset = "0x20EB430", VA = "0x1820EC030")]
	public JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps> GIIJGHPMFHC<TPayload, TOk, TErr>(TActionKind MKNGFPCPGEH, OAJGLBCFOFA<TActionKind, TSerializedAction, TPayload> IODMDOOJJPA, JIFJPCNLHMO<TRoot, TPayload, TOk, TErr> HCDBJFLDBMC, bool KHKFBOOPCNL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CKBHJGGJPMD
	{
		return default(JDJIIMICIMD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38E7310", Offset = "0x38E6710", VA = "0x1838E7310")]
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
