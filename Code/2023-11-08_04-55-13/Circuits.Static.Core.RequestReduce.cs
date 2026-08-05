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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CBC5C0", Offset = "0x1CBB3C0", VA = "0x181CBC5C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate OHGDAPNNJMC<TActionKind, TPayload> PFNLKBNLBFD<TActionKind, TSerializedAction, TPayload>(TSerializedAction PDKELAFMKAF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface NFKLOMGOJCI<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EFFPFBGFCJB<object, FCBFPODNPBP>> ALGJBIHJFKO(TDeps IFPKGKPDGBH, TRoot NANDDCHCAEB, TSerializedAction PDKELAFMKAF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OGBKJMCPDOM<TActionKind, TSerializedAction, TRoot, TDeps> : JLMPFOOAOBO where TDeps : MFMKLHPACBE.JJFEKGOOHAC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps OFCAAKMDICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction FPJIPGFCDND;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3A50", Offset = "0x3DE2850", VA = "0x183DE3A50")]
	public OGBKJMCPDOM([In] TDeps IFPKGKPDGBH, [In] TSerializedAction PDKELAFMKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3820", Offset = "0x3DE2620", VA = "0x183DE3820", Slot = "7")]
	public override string BCJNMAHEGJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OHGDAPNNJMC<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind NPLAGFJAMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload PHBMLDHKMFK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5630", Offset = "0x3DE4430", VA = "0x183DE5630")]
	internal OHGDAPNNJMC(TActionKind BKFKFLNFJLK, [In] TPayload IPHMLIFNKFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BFCPDGNGCDO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22A1250", Offset = "0x22A0050", VA = "0x1822A1250")]
	public static OHGDAPNNJMC<TActionKind, TPayload> FMIHPEHEFKO<TActionKind, TPayload>([In] TActionKind BKFKFLNFJLK, [In] TPayload IPHMLIFNKFM)
	{
		return default(OHGDAPNNJMC<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<EFFPFBGFCJB<TOk, TErr>> LEMDBGEOBNO<TRoot, TPayload, TOk, TErr>(TRoot NANDDCHCAEB, TPayload IPHMLIFNKFM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate EFFPFBGFCJB<TOk, TErr> FHGPPOECIJC<TRoot, TPayload, TOk, TErr>(TRoot NANDDCHCAEB, [In] TPayload IPHMLIFNKFM);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JBMLNCGGNNJ<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : MFMKLHPACBE.JJFEKGOOHAC<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JGMHIDDFEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<EFFPFBGFCJB<object, FCBFPODNPBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JBMLNCGGNNJ<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<EFFPFBGFCJB<object, FCBFPODNPBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x394EFE0", Offset = "0x394DDE0", VA = "0x18394EFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x394F970", Offset = "0x394E770", VA = "0x18394F970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, NFKLOMGOJCI<TSerializedAction, TRoot, TDeps>> IECAAGBDOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps OFCAAKMDICP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
	internal JBMLNCGGNNJ(Dictionary<TActionKind, NFKLOMGOJCI<TSerializedAction, TRoot, TDeps>> CEAEIHFKHPM, TDeps IFPKGKPDGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x391D0D0", Offset = "0x391BED0", VA = "0x18391D0D0")]
	[AsyncStateMachine(typeof(JBMLNCGGNNJ<, , , >.JGMHIDDFEME))]
	public Task<EFFPFBGFCJB<object, FCBFPODNPBP>> ALGJBIHJFKO(TRoot NANDDCHCAEB, TSerializedAction PDKELAFMKAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MFMKLHPACBE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JJFEKGOOHAC<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind NACCOIGCPDO(TSerializedAction HLCOOGAGOEK);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DIOPMJGJPHM(TRoot NANDDCHCAEB, TSerializedAction CBNAIFNPGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x23AA940", Offset = "0x23A9740", VA = "0x1823AA940")]
	internal static JBMLNCGGNNJ<TActionKind, TSerializedAction, TRoot, TDeps> FMIHPEHEFKO<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, NFKLOMGOJCI<TSerializedAction, TRoot, TDeps>> CEAEIHFKHPM, TDeps IFPKGKPDGBH) where TDeps : JJFEKGOOHAC<TActionKind, TSerializedAction, TRoot>
	{
		return default(JBMLNCGGNNJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HIHKHHKOEFH<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, NFKLOMGOJCI<TSerializedAction, TRoot, TDeps>> EACJEKOJIFN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	private HIHKHHKOEFH(Dictionary<TActionKind, NFKLOMGOJCI<TSerializedAction, TRoot, TDeps>> CEAEIHFKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x364DDD0", Offset = "0x364CBD0", VA = "0x18364DDD0")]
	public static HIHKHHKOEFH<TActionKind, TSerializedAction, TRoot, TDeps> FMIHPEHEFKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DLLEOEKENNC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MFMKLHPACBE.JJFEKGOOHAC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PDLJIGECLJJ<TPayload, TOk, TErr> : NFKLOMGOJCI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FCBFPODNPBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PFNLKBNLBFD<TActionKind, TSerializedAction, TPayload> JMABFHGNHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly FHGPPOECIJC<TRoot, TPayload, TOk, TErr> OEBBGPGIOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool AGGFLNJMLFL;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED46D0", Offset = "0x3ED34D0", VA = "0x183ED46D0")]
		public PDLJIGECLJJ(PFNLKBNLBFD<TActionKind, TSerializedAction, TPayload> FCCOIDOMGKO, FHGPPOECIJC<TRoot, TPayload, TOk, TErr> LMHLGDIGKPJ, bool ICDEHDGJOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB760", Offset = "0x3ECA560", VA = "0x183ECB760", Slot = "4")]
		public Task<EFFPFBGFCJB<object, FCBFPODNPBP>> ALGJBIHJFKO(TDeps IFPKGKPDGBH, TRoot NANDDCHCAEB, TSerializedAction PDKELAFMKAF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class CBDOOFMOMKA<TPayload, TOk, TErr> : NFKLOMGOJCI<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FCBFPODNPBP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JBNLGHBPIKI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<EFFPFBGFCJB<object?, FCBFPODNPBP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CBDOOFMOMKA<TPayload, TOk, TErr> <>4__this;

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
			private EFFPFBGFCJB<object?, FCBFPODNPBP> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<EFFPFBGFCJB<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x391E880", Offset = "0x391D680", VA = "0x18391E880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x391F270", Offset = "0x391E070", VA = "0x18391F270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly PFNLKBNLBFD<TActionKind, TSerializedAction, TPayload> JMABFHGNHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LEMDBGEOBNO<TRoot, TPayload, TOk, TErr> OEBBGPGIOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool AGGFLNJMLFL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3ED46D0", Offset = "0x3ED34D0", VA = "0x183ED46D0")]
		public CBDOOFMOMKA(PFNLKBNLBFD<TActionKind, TSerializedAction, TPayload> FCCOIDOMGKO, LEMDBGEOBNO<TRoot, TPayload, TOk, TErr> LMHLGDIGKPJ, bool ICDEHDGJOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x49B1F50", Offset = "0x49B0D50", VA = "0x1849B1F50", Slot = "4")]
		[AsyncStateMachine(typeof(CBDOOFMOMKA<, , >.JBNLGHBPIKI))]
		public Task<EFFPFBGFCJB<object, FCBFPODNPBP>> ALGJBIHJFKO(TDeps IFPKGKPDGBH, TRoot NANDDCHCAEB, TSerializedAction PDKELAFMKAF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HIHKHHKOEFH<TActionKind, TSerializedAction, TRoot, TDeps> CNPMALOCGKO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
	private DLLEOEKENNC(HIHKHHKOEFH<TActionKind, TSerializedAction, TRoot, TDeps> KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4DA1550", Offset = "0x4DA0350", VA = "0x184DA1550")]
	public static DLLEOEKENNC<TActionKind, TSerializedAction, TRoot, TDeps> FMIHPEHEFKO()
	{
		return default(DLLEOEKENNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E03020", Offset = "0x2E01E20", VA = "0x182E03020")]
	public DLLEOEKENNC<TActionKind, TSerializedAction, TRoot, TDeps> KPFOBMBPCJM<TPayload, TOk, TErr>(TActionKind BKFKFLNFJLK, PFNLKBNLBFD<TActionKind, TSerializedAction, TPayload> FCCOIDOMGKO, FHGPPOECIJC<TRoot, TPayload, TOk, TErr> LMHLGDIGKPJ, bool ICDEHDGJOFF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FCBFPODNPBP
	{
		return default(DLLEOEKENNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E03020", Offset = "0x2E01E20", VA = "0x182E03020")]
	public DLLEOEKENNC<TActionKind, TSerializedAction, TRoot, TDeps> ODENJDGLHLK<TPayload, TOk, TErr>(TActionKind BKFKFLNFJLK, PFNLKBNLBFD<TActionKind, TSerializedAction, TPayload> FCCOIDOMGKO, LEMDBGEOBNO<TRoot, TPayload, TOk, TErr> LMHLGDIGKPJ, bool ICDEHDGJOFF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FCBFPODNPBP
	{
		return default(DLLEOEKENNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA15E0", Offset = "0x4DA03E0", VA = "0x184DA15E0")]
	public JBMLNCGGNNJ<TActionKind, TSerializedAction, TRoot, TDeps> KIEPBNIPFMH(TDeps IFPKGKPDGBH)
	{
		return default(JBMLNCGGNNJ<TActionKind, TSerializedAction, TRoot, TDeps>);
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
