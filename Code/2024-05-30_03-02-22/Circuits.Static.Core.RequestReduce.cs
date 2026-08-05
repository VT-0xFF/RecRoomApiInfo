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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1ED1D90", Offset = "0x1ED0F90", VA = "0x181ED1D90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate HBGEDKJHNBH<TActionKind, TPayload> ABCPECPFIJK<TActionKind, TSerializedAction, TPayload>(TSerializedAction FKJPCNJAMEG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FBFKJCLOPAD<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> PFFCILAFNIK(TDeps LPEICIFHPLM, TRoot LNOFAKNEFAA, TSerializedAction FKJPCNJAMEG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CDEPDFOMDEI<TActionKind, TSerializedAction, TRoot, TDeps> : GCHIODKACBE where TDeps : DHCMLCCMCOC.DGJHPPHLBLI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps GJMNJKPIFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction OKEOBIAJHDK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC960", Offset = "0x4EABB60", VA = "0x184EAC960")]
	public CDEPDFOMDEI([In] TDeps LPEICIFHPLM, [In] TSerializedAction FKJPCNJAMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC840", Offset = "0x4EABA40", VA = "0x184EAC840", Slot = "7")]
	public override string HDHLJKIJNJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HBGEDKJHNBH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind EBOCOKFMFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload DDNHCMHEBMG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A22230", Offset = "0x3A21430", VA = "0x183A22230")]
	internal HBGEDKJHNBH(TActionKind JDHBFALINMH, [In] TPayload EIAKFCMMIEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OJNMOAJILHM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF95E0", Offset = "0x2AF87E0", VA = "0x182AF95E0")]
	public static HBGEDKJHNBH<TActionKind, TPayload> EPPBEPCPNMI<TActionKind, TPayload>([In] TActionKind JDHBFALINMH, [In] TPayload EIAKFCMMIEA)
	{
		return default(HBGEDKJHNBH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<GDHFNIGIAEI<TOk, TErr>> AJLLBJFCFEC<TRoot, TPayload, TOk, TErr>(TRoot LNOFAKNEFAA, TPayload EIAKFCMMIEA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate GDHFNIGIAEI<TOk, TErr> IEPDDEGCAEL<TRoot, TPayload, TOk, TErr>(TRoot LNOFAKNEFAA, [In] TPayload EIAKFCMMIEA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GMIMMGKKKAL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : DHCMLCCMCOC.DGJHPPHLBLI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FJFKJONDBJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GMIMMGKKKAL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x390D100", Offset = "0x390C300", VA = "0x18390D100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x390D500", Offset = "0x390C700", VA = "0x18390D500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, FBFKJCLOPAD<TSerializedAction, TRoot, TDeps>> GPBMONHKFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps GJMNJKPIFIO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9FB690", Offset = "0x9FA890", VA = "0x1809FB690")]
	internal GMIMMGKKKAL(Dictionary<TActionKind, FBFKJCLOPAD<TSerializedAction, TRoot, TDeps>> NBKJPDMJPAP, TDeps LPEICIFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x39DDAA0", Offset = "0x39DCCA0", VA = "0x1839DDAA0")]
	[AsyncStateMachine(typeof(GMIMMGKKKAL<, , , >.FJFKJONDBJG))]
	public Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> PFFCILAFNIK(TRoot LNOFAKNEFAA, TSerializedAction FKJPCNJAMEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DHCMLCCMCOC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DGJHPPHLBLI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FOCMFNNDIDA(TSerializedAction CJKIBFNGPNM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DHFKBOMAJMP(TRoot LNOFAKNEFAA, TSerializedAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FPKANFFNBHC(TRoot LNOFAKNEFAA, TSerializedAction BGMBJALDBDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2802540", Offset = "0x2801740", VA = "0x182802540")]
	internal static GMIMMGKKKAL<TActionKind, TSerializedAction, TRoot, TDeps> EPPBEPCPNMI<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FBFKJCLOPAD<TSerializedAction, TRoot, TDeps>> NBKJPDMJPAP, TDeps LPEICIFHPLM) where TDeps : DGJHPPHLBLI<TActionKind, TSerializedAction, TRoot>
	{
		return default(GMIMMGKKKAL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LFFPCJMCFOH<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, FBFKJCLOPAD<TSerializedAction, TRoot, TDeps>> MOEAKOBBCFM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	private LFFPCJMCFOH(Dictionary<TActionKind, FBFKJCLOPAD<TSerializedAction, TRoot, TDeps>> NBKJPDMJPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F37F50", Offset = "0x3F37150", VA = "0x183F37F50")]
	public static LFFPCJMCFOH<TActionKind, TSerializedAction, TRoot, TDeps> EPPBEPCPNMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DFAANEJFENB<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, DHCMLCCMCOC.DGJHPPHLBLI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CLOFCMJFOAH<TPayload, TOk, TErr> : FBFKJCLOPAD<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HHLFGPMDGJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly ABCPECPFIJK<TActionKind, TSerializedAction, TPayload> DDLJLNABOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly IEPDDEGCAEL<TRoot, TPayload, TOk, TErr> KNMGMJIKIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DDINMHMABFO;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x414A7B0", Offset = "0x41499B0", VA = "0x18414A7B0")]
		public CLOFCMJFOAH(ABCPECPFIJK<TActionKind, TSerializedAction, TPayload> NHAPACPKONA, IEPDDEGCAEL<TRoot, TPayload, TOk, TErr> FMEAPNLBCBF, bool OADHDBPIKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x506FD60", Offset = "0x506EF60", VA = "0x18506FD60", Slot = "4")]
		public Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> PFFCILAFNIK(TDeps LPEICIFHPLM, TRoot LNOFAKNEFAA, TSerializedAction FKJPCNJAMEG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MNMNKFAALMP<TPayload, TOk, TErr> : FBFKJCLOPAD<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HHLFGPMDGJA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BGNAJKBCOGG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<GDHFNIGIAEI<object?, HHLFGPMDGJA>> <>t__builder;

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
			public MNMNKFAALMP<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private GDHFNIGIAEI<object?, HHLFGPMDGJA> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<GDHFNIGIAEI<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A490", Offset = "0x4A59690", VA = "0x184A5A490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4A5AF10", Offset = "0x4A5A110", VA = "0x184A5AF10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly ABCPECPFIJK<TActionKind, TSerializedAction, TPayload> DDLJLNABOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly AJLLBJFCFEC<TRoot, TPayload, TOk, TErr> KNMGMJIKIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DDINMHMABFO;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x414A7B0", Offset = "0x41499B0", VA = "0x18414A7B0")]
		public MNMNKFAALMP(ABCPECPFIJK<TActionKind, TSerializedAction, TPayload> NHAPACPKONA, AJLLBJFCFEC<TRoot, TPayload, TOk, TErr> FMEAPNLBCBF, bool OADHDBPIKPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x414A660", Offset = "0x4149860", VA = "0x18414A660", Slot = "4")]
		[AsyncStateMachine(typeof(MNMNKFAALMP<, , >.BGNAJKBCOGG))]
		public Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> PFFCILAFNIK(TDeps LPEICIFHPLM, TRoot LNOFAKNEFAA, TSerializedAction FKJPCNJAMEG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LFFPCJMCFOH<TActionKind, TSerializedAction, TRoot, TDeps> NCAIBNBKMDB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	private DFAANEJFENB(LFFPCJMCFOH<TActionKind, TSerializedAction, TRoot, TDeps> JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x53288F0", Offset = "0x5327AF0", VA = "0x1853288F0")]
	public static DFAANEJFENB<TActionKind, TSerializedAction, TRoot, TDeps> EPPBEPCPNMI()
	{
		return default(DFAANEJFENB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x274BF80", Offset = "0x274B180", VA = "0x18274BF80")]
	public DFAANEJFENB<TActionKind, TSerializedAction, TRoot, TDeps> CADANGBGNOM<TPayload, TOk, TErr>(TActionKind JDHBFALINMH, ABCPECPFIJK<TActionKind, TSerializedAction, TPayload> NHAPACPKONA, IEPDDEGCAEL<TRoot, TPayload, TOk, TErr> FMEAPNLBCBF, bool OADHDBPIKPF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HHLFGPMDGJA
	{
		return default(DFAANEJFENB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x274BF80", Offset = "0x274B180", VA = "0x18274BF80")]
	public DFAANEJFENB<TActionKind, TSerializedAction, TRoot, TDeps> LDEKCCKAAAN<TPayload, TOk, TErr>(TActionKind JDHBFALINMH, ABCPECPFIJK<TActionKind, TSerializedAction, TPayload> NHAPACPKONA, AJLLBJFCFEC<TRoot, TPayload, TOk, TErr> FMEAPNLBCBF, bool OADHDBPIKPF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HHLFGPMDGJA
	{
		return default(DFAANEJFENB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5328980", Offset = "0x5327B80", VA = "0x185328980")]
	public GMIMMGKKKAL<TActionKind, TSerializedAction, TRoot, TDeps> MMPBNMANKLB(TDeps LPEICIFHPLM)
	{
		return default(GMIMMGKKKAL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
