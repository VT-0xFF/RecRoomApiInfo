using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x22F1990", Offset = "0x22F0D90", VA = "0x1822F1990")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DLFOGDDKJHH : IDisposable, BOMHJCMILHK, NOOKCCAKDAN, NAKHPGBMNNO, KFPBFAEENFE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class NAPIJJHLJEJ : DEAGPLPGJBD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int LKAHAPEMFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x22EEB50", Offset = "0x22EDF50", VA = "0x1822EEB50", Slot = "5")]
		public BGPHAECIAFF JDJCMDIHLHI(CMPKJCBJJIB.DJCGFLIGCGK CFAPAOIIPAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void NNNEDEBDHIJ();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void BFEMEFAPBGH();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x22EEB10", Offset = "0x22EDF10", VA = "0x1822EEB10", Slot = "13")]
		public virtual void IAAJINEHFAN(DLFOGDDKJHH HCHGEACFMON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x22EECA0", Offset = "0x22EE0A0", VA = "0x1822EECA0", Slot = "14")]
		public virtual void KPMCIHEFICN(DLFOGDDKJHH HCHGEACFMON, OCNCAELNEHP OLHFOBIBHCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		protected NAPIJJHLJEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DEAGPLPGJBD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int LKAHAPEMFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BGPHAECIAFF JDJCMDIHLHI(CMPKJCBJJIB.DJCGFLIGCGK CFAPAOIIPAA);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NNNEDEBDHIJ();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BFEMEFAPBGH();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IAAJINEHFAN(DLFOGDDKJHH HCHGEACFMON);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KPMCIHEFICN(DLFOGDDKJHH HCHGEACFMON, OCNCAELNEHP OLHFOBIBHCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct GBHKANEFPLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly JIGOMCKFOAL<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH, IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH>> NKEGKDFAIEK;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x22DF670", Offset = "0x22DEA70", VA = "0x1822DF670")]
		internal GBHKANEFPLJ(JIGOMCKFOAL<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH, IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH>> HKNABNLJGOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class IGHKLPLDHKG : IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly IGHKLPLDHKG ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private IGHKLPLDHKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x14423A0", Offset = "0x14417A0", VA = "0x1814423A0", Slot = "4")]
		public FEAPAONCDCL KOKKBADJNCP(OCNCAELNEHP MPLBPEBNKFP)
		{
			return default(FEAPAONCDCL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x22EAE90", Offset = "0x22EA290", VA = "0x1822EAE90", Slot = "5")]
		public void IAAJINEHFAN(DLFOGDDKJHH NIMLNKDMKHI, OCNCAELNEHP OLHFOBIBHCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x22EAF90", Offset = "0x22EA390", VA = "0x1822EAF90", Slot = "6")]
		public void KPMCIHEFICN(DLFOGDDKJHH NIMLNKDMKHI, OCNCAELNEHP OLHFOBIBHCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct DHMOIHOPPMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HPGGHNPBFOM<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH, IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH>> NKEGKDFAIEK;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x22DB860", Offset = "0x22DAC60", VA = "0x1822DB860")]
		internal DHMOIHOPPMB(HPGGHNPBFOM<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH, IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH>> HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x22DB810", Offset = "0x22DAC10", VA = "0x1822DB810")]
		public static DHMOIHOPPMB ODOFIFAGLAJ()
		{
			return default(DHMOIHOPPMB);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct CGJNNKPAEDB : KKLBFHFGGKP.NCJNPBNMBKJ<OCNCAELNEHP, DLFOGDDKJHH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct NCHJFIDAAML : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<object?, IAAGGMEHHFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public DLFOGDDKJHH receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OCNCAELNEHP action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public CGJNNKPAEDB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<ABNAGONECLM<object?, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x22EED20", Offset = "0x22EE120", VA = "0x1822EED20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x22EEF00", Offset = "0x22EE300", VA = "0x1822EEF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAE3400", Offset = "0xAE2800", VA = "0x180AE3400", Slot = "4")]
		public AHPCDKCOAJM<APADOHEFPGP> IMLIGOOGFGH(DLFOGDDKJHH NCFNENNCOJO)
		{
			return default(AHPCDKCOAJM<APADOHEFPGP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x22D9980", Offset = "0x22D8D80", VA = "0x1822D9980", Slot = "5")]
		public void NKDBPFGGBAI(DLFOGDDKJHH NCFNENNCOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x22D9830", Offset = "0x22D8C30", VA = "0x1822D9830", Slot = "6")]
		[AsyncStateMachine(typeof(NCHJFIDAAML))]
		public Task<ABNAGONECLM<object, IAAGGMEHHFI>> CGIHCOLCIHO(DLFOGDDKJHH NCFNENNCOJO, OCNCAELNEHP OLHFOBIBHCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x22D9960", Offset = "0x22D8D60", VA = "0x1822D9960", Slot = "7")]
		public OCNCAELNEHP[] MEIHMPDNGIH(DLFOGDDKJHH NCFNENNCOJO)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LGJAEDLEADO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<bool, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DLFOGDDKJHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IEBOLOHJJBA rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DPCOLNDKMBE circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public KOLIENJCING superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<ABNAGONECLM<bool, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x22ED520", Offset = "0x22EC920", VA = "0x1822ED520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x22ED7A0", Offset = "0x22ECBA0", VA = "0x1822ED7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HIOOFCGAIEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<bool, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DLFOGDDKJHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<ABNAGONECLM<bool, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x22EA910", Offset = "0x22E9D10", VA = "0x1822EA910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x22EABA0", Offset = "0x22E9FA0", VA = "0x1822EABA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DHGACHAANNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public DLFOGDDKJHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x22DB5C0", Offset = "0x22DA9C0", VA = "0x1822DB5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x22DB7A0", Offset = "0x22DABA0", VA = "0x1822DB7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JCEAMCMJIND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object?, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DLFOGDDKJHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public OCNCAELNEHP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<ABNAGONECLM<object?, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x22EB610", Offset = "0x22EAA10", VA = "0x1822EB610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x22EB800", Offset = "0x22EAC00", VA = "0x1822EB800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AMDOGPINCFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DLFOGDDKJHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<ABNAGONECLM<bool, IAAGGMEHHFI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x22D8020", Offset = "0x22D7420", VA = "0x1822D8020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x22D8800", Offset = "0x22D7C00", VA = "0x1822D8800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AHPCDKCOAJM<APADOHEFPGP> HLPDINEHKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GBHKANEFPLJ EMOAEIENCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HJGHGKHNDFN HDMCOKPMOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly HFEKAFNHBMH AFCCIAOOLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A90")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly DPIOAKOAPGI MMLKHGLMMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly JFLIKJPNOAH.NFFAGJOKAAG DJJPKBACMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AB8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly OMGGKJMENND LHEPKNPDBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly HDJLABNIDOF FAMHAIDGKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly PEKMEGLGECJ FMNLGKJMGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AD0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly PHKJNDGJFGK IEDOKGODHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AD8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MBIBIFFDFLJ GKAIOOOODJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AE8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private AHEDCMAIFIA GKOFEMKGJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B08")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly HJGHGKHNDFN.PLFAOGKLBBA FKGJFCOCJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly NKLJCJFNJFB FINAJIOOJBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HJGHGKHNDFN OEMEFPMBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x22DCEB0", Offset = "0x22DC2B0", VA = "0x1822DCEB0")]
		get
		{
			return default(HJGHGKHNDFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal DEAGPLPGJBD BMDHLLFPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22DC400", Offset = "0x22DB800", VA = "0x1822DC400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal BGPHAECIAFF KHDFBKMDMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22DB9E0", Offset = "0x22DADE0", VA = "0x1822DB9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x22DC3E0", Offset = "0x22DB7E0", VA = "0x1822DC3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool NLEOHDLLJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x22DC1D0", Offset = "0x22DB5D0", VA = "0x1822DC1D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22DCA30", Offset = "0x22DBE30", VA = "0x1822DCA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BILEEKCDNAO KOKHOHDCKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x22DD1C0", Offset = "0x22DC5C0", VA = "0x1822DD1C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FKHJIHLIDDB KBLEJLBOLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x22DD1D0", Offset = "0x22DC5D0", VA = "0x1822DD1D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MOOJGNIOBNC DDOECEBGFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x22DD1F0", Offset = "0x22DC5F0", VA = "0x1822DD1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HGCNJMMOEHM POFEFCOBMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x22DD1E0", Offset = "0x22DC5E0", VA = "0x1822DD1E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JFLIKJPNOAH? MJNACGLJCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x22DC0E0", Offset = "0x22DB4E0", VA = "0x1822DC0E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private FOCCBPILPIJ? FDNLJOJPNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x22DC7E0", Offset = "0x22DBBE0", VA = "0x1822DC7E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22DCEC0", Offset = "0x22DC2C0", VA = "0x1822DCEC0")]
	private DLFOGDDKJHH(DPIOAKOAPGI OGOGOLFFADO, AHPCDKCOAJM<APADOHEFPGP> EOMBDLJNDJM, [In] GBHKANEFPLJ DHFEGPPFFAE, [In] HJGHGKHNDFN LHKFKCFCNAG, [In] HFEKAFNHBMH LLFFFIIDCEH, BGPHAECIAFF CNFDHFPDHDF, [In] JFLIKJPNOAH.NFFAGJOKAAG OJHGFIEOEHK, HJGHGKHNDFN.PLFAOGKLBBA HABGPINPHKF, NKLJCJFNJFB CCMGNAKLLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x22DCA90", Offset = "0x22DBE90", VA = "0x1822DCA90")]
	public static DLFOGDDKJHH ODOFIFAGLAJ(DPIOAKOAPGI CFAPAOIIPAA, [In] NOLHHPLNGEB MGNOKJBOMBG, CJDKBFJILCL GKPBGPIDFKI, [In] NCHDHDHPDOH LEOANHPKGEE, NMPCFHBCDPE LBEJDIHOEGG, AHPCDKCOAJM<APADOHEFPGP> EOMBDLJNDJM, AHPCDKCOAJM<BHCGNKOKKKM> COENIBFAGLK, ACBBHBEPAOE GMJOLMHJJFA, CNKPIEDJECK JAELOKNPJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22DCBD0", Offset = "0x22DBFD0", VA = "0x1822DCBD0")]
	public static DLFOGDDKJHH ODOFIFAGLAJ(DPIOAKOAPGI OGOGOLFFADO, [In] HJGHGKHNDFN LHKFKCFCNAG, [In] HFEKAFNHBMH LLFFFIIDCEH, AHPCDKCOAJM<APADOHEFPGP> EOMBDLJNDJM, AHPCDKCOAJM<BHCGNKOKKKM> COENIBFAGLK, ACBBHBEPAOE GMJOLMHJJFA, CNKPIEDJECK JAELOKNPJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22DB9F0", Offset = "0x22DADF0", VA = "0x1822DB9F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF80", Offset = "0x22DB380", VA = "0x1822DBF80")]
	[AsyncStateMachine(typeof(LGJAEDLEADO))]
	internal Task<ABNAGONECLM<bool, IAAGGMEHHFI>> GBGLFBIAHPF(IEBOLOHJJBA BNECGPCNHPJ, DPCOLNDKMBE IKIGPJFOFLK, KOLIENJCING EJFFMDCEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x22DB870", Offset = "0x22DAC70", VA = "0x1822DB870")]
	[AsyncStateMachine(typeof(HIOOFCGAIEM))]
	public Task<ABNAGONECLM<bool, IAAGGMEHHFI>> ABJKPEFCIDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x22DC1E0", Offset = "0x22DB5E0", VA = "0x1822DC1E0")]
	[AsyncStateMachine(typeof(DHGACHAANNH))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> JEPGOIMHFNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x22DBBE0", Offset = "0x22DAFE0", VA = "0x1822DBBE0")]
	internal void ENINBJECHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22DB960", Offset = "0x22DAD60", VA = "0x1822DB960")]
	internal GPPELIJDOJB<OCNCAELNEHP> CNBCDEOHGLJ([In] FMBNIOOJGFJ OJGCOOMHEFC)
	{
		return default(GPPELIJDOJB<OCNCAELNEHP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x22DC160", Offset = "0x22DB560", VA = "0x1822DC160")]
	internal bool HGEEDCDKGGH([In] FMBNIOOJGFJ OJGCOOMHEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x22DBDF0", Offset = "0x22DB1F0", VA = "0x1822DBDF0")]
	internal ABNAGONECLM<OCNCAELNEHP, IAAGGMEHHFI> FFGAEOAFAAM([In] BKDLFMCMHNE ELKJLBPMDBH)
	{
		return default(ABNAGONECLM<OCNCAELNEHP, IAAGGMEHHFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x22DCA40", Offset = "0x22DBE40", VA = "0x1822DCA40")]
	private void NKDBPFGGBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x22DC2D0", Offset = "0x22DB6D0", VA = "0x1822DC2D0")]
	[AsyncStateMachine(typeof(JCEAMCMJIND))]
	internal Task<ABNAGONECLM<object, IAAGGMEHHFI>> JKIPIDOJPLO(OCNCAELNEHP OLHFOBIBHCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22DC450", Offset = "0x22DB850", VA = "0x1822DC450")]
	private OCNCAELNEHP[] MEIHMPDNGIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22DC910", Offset = "0x22DBD10", VA = "0x1822DC910")]
	[AsyncStateMachine(typeof(AMDOGPINCFB))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> NABINCFNIEF(Guid CKAEIEHLNEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PJNNFOBMJJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3224810", Offset = "0x3223C10", VA = "0x183224810")]
	public static CBAFJEDNBAD<(TPrev?, DLFOGDDKJHH?), FOCCBPILPIJ> AIKECLNJAKB<TPrev>([In] this CBAFJEDNBAD<TPrev, DLFOGDDKJHH> MPLBPEBNKFP)
	{
		return default(CBAFJEDNBAD<(TPrev, DLFOGDDKJHH), FOCCBPILPIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3224AD0", Offset = "0x3223ED0", VA = "0x183224AD0")]
	public static CBAFJEDNBAD<TPrev?, DLFOGDDKJHH?> LCCKCLKPPIC<TPrev>([In] this CBAFJEDNBAD<TPrev, DLFOGDDKJHH> MPLBPEBNKFP)
	{
		return default(CBAFJEDNBAD<TPrev, DLFOGDDKJHH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GOIMJOKFLMM<TData> : PJPEMJHFJLC, JAIMDHJMEGG, NAONGKGFBLO where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PBDBGAKNNHI<AMFCOJIMJGL>? NBHHFDCALKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly string DIJFEMNHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly TData GLBGLIBCAOD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PBDBGAKNNHI<AMFCOJIMJGL>? AKBFEJNKIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x252AC90", Offset = "0x252A090", VA = "0x18252AC90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0", Slot = "7")]
	public override string MMDDBBBPGKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41B6280", Offset = "0x41B5680", VA = "0x1841B6280")]
	internal GOIMJOKFLMM([In] PBDBGAKNNHI<AMFCOJIMJGL>? IGPEDLENILN, AHPCDKCOAJM<GBPNADAEKMC>? IGLJGFNMNJN, IOKind? EGIEGFODCON, string LNICHECHJFC, [In] TData JGCOLLOOLHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OMPNGDCAFNB
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x22F2770", Offset = "0x22F1B70", VA = "0x1822F2770")]
	public static ABNAGONECLM<FNKGFKLHJEJ, JAIMDHJMEGG> LHIEIGCLKJL([In] this PIEJLMECNNC<AMNKALDGOBP> LIOHLFGHJBD)
	{
		return default(ABNAGONECLM<FNKGFKLHJEJ, JAIMDHJMEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3218220", Offset = "0x3217620", VA = "0x183218220")]
	public static ABNAGONECLM<TOk, JAIMDHJMEGG> KGEJBLMHDHF<TOk>([In] this ABNAGONECLM<TOk, JAIMDHJMEGG> MPLBPEBNKFP, [In] PBDBGAKNNHI<AMFCOJIMJGL>? IGPEDLENILN, AHPCDKCOAJM<GBPNADAEKMC>? IGLJGFNMNJN, IOKind? EGIEGFODCON, string LNICHECHJFC) where TOk : notnull
	{
		return default(ABNAGONECLM<TOk, JAIMDHJMEGG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DPIOAKOAPGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EGFCEIPNOCE.ECIHMKIHNGK HPJLKGICGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	CMPKJCBJJIB.DJCGFLIGCGK JPKGNEPBJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DLFOGDDKJHH.DEAGPLPGJBD KMEJAKABODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IDFENAAFFDL.PGMKMCJMCAF HDIDJJFIGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH> HKFCKEFEHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GDCDMFKBBJH LBPOJHPBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ABLKNGGHEGN DHACIKOIFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GPCNNNDNPHP JCIKIBJDNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BLIECBOGFEI FOODMHICIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	PFJEOGKCODF KHNMNDANFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KJOHDJCBLFL
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x22ECF00", Offset = "0x22EC300", VA = "0x1822ECF00")]
	public static OCNCAELNEHP BIEPHDGJJHP(this OCNCAELNEHP MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x22ED010", Offset = "0x22EC410", VA = "0x1822ED010")]
	public static OCNCAELNEHP FNOMBPMMMIA(this IEBOHPEKMIL MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct IEBOHPEKMIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct FKMKPBBLPOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object?, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public DLFOGDDKJHH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IEBOHPEKMIL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private TaskAwaiter<ABNAGONECLM<object?, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x22DE8A0", Offset = "0x22DDCA0", VA = "0x1822DE8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x22DEB60", Offset = "0x22DDF60", VA = "0x1822DEB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly ByteString GFHLLJBPNAP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	private IEBOHPEKMIL(ByteString HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x22EAC10", Offset = "0x22EA010", VA = "0x1822EAC10")]
	public static OCNCAELNEHP CCDFLFOBCNL(ByteString HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x22EACD0", Offset = "0x22EA0D0", VA = "0x1822EACD0")]
	public static KGAAMPHMJKE<FEAPAONCDCL, IEBOHPEKMIL> JHAAKKPJLOI(OCNCAELNEHP AEKGIDHHLCL)
	{
		return default(KGAAMPHMJKE<FEAPAONCDCL, IEBOHPEKMIL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x22EAD80", Offset = "0x22EA180", VA = "0x1822EAD80")]
	[AsyncStateMachine(typeof(FKMKPBBLPOM))]
	public static Task<ABNAGONECLM<object, IAAGGMEHHFI>> JKIPIDOJPLO(DLFOGDDKJHH NIMLNKDMKHI, IEBOHPEKMIL MPLBPEBNKFP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct OLEDKBINEHM
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x22F24E0", Offset = "0x22F18E0", VA = "0x1822F24E0")]
	public static OCNCAELNEHP CCDFLFOBCNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x22F2580", Offset = "0x22F1980", VA = "0x1822F2580")]
	public static KGAAMPHMJKE<FEAPAONCDCL, OLEDKBINEHM> JHAAKKPJLOI(OCNCAELNEHP AEKGIDHHLCL)
	{
		return default(KGAAMPHMJKE<FEAPAONCDCL, OLEDKBINEHM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x22F25F0", Offset = "0x22F19F0", VA = "0x1822F25F0")]
	public static ABNAGONECLM<ALHKDJHEAFJ, JMMAFLLBCOF> OFALIHCNEIG(DLFOGDDKJHH NIMLNKDMKHI, [In] OLEDKBINEHM MPLBPEBNKFP)
	{
		return default(ABNAGONECLM<ALHKDJHEAFJ, JMMAFLLBCOF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct JNPNAPIBNOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct OKNPJOLFGPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, JMMAFLLBCOF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public DLFOGDDKJHH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JNPNAPIBNOI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private ABNAGONECLM<ALHKDJHEAFJ, JMMAFLLBCOF> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x22F2100", Offset = "0x22F1500", VA = "0x1822F2100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x22F2470", Offset = "0x22F1870", VA = "0x1822F2470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly IEBOLOHJJBA? MNPJFHKMJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly DPCOLNDKMBE? GJODIIGKHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly KOLIENJCING? JMFCOBFLKDC;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x22114B0", Offset = "0x22108B0", VA = "0x1822114B0")]
	private JNPNAPIBNOI(IEBOLOHJJBA? BNECGPCNHPJ, DPCOLNDKMBE? IKIGPJFOFLK, KOLIENJCING? EJFFMDCEBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x22EBE60", Offset = "0x22EB260", VA = "0x1822EBE60")]
	public static OCNCAELNEHP? CCDFLFOBCNL(IEBOLOHJJBA? BNECGPCNHPJ, DPCOLNDKMBE? IKIGPJFOFLK, KOLIENJCING? EJFFMDCEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x22EBF60", Offset = "0x22EB360", VA = "0x1822EBF60")]
	public static KGAAMPHMJKE<FEAPAONCDCL, JNPNAPIBNOI> JHAAKKPJLOI(OCNCAELNEHP AEKGIDHHLCL)
	{
		return default(KGAAMPHMJKE<FEAPAONCDCL, JNPNAPIBNOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x22EC070", Offset = "0x22EB470", VA = "0x1822EC070")]
	[AsyncStateMachine(typeof(OKNPJOLFGPL))]
	public static Task<ABNAGONECLM<ALHKDJHEAFJ, JMMAFLLBCOF>> JKIPIDOJPLO(DLFOGDDKJHH NIMLNKDMKHI, JNPNAPIBNOI MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct JBNOHBOLCEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct LHLELHICOIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<NDLCFMMJECI, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public JBNOHBOLCEI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public DLFOGDDKJHH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ABNAGONECLM<NDLCFMMJECI, IAAGGMEHHFI> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private ABNAGONECLM<object?, NAONGKGFBLO>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private ABNAGONECLM<object?, NAONGKGFBLO> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private ABNAGONECLM<object?, NAONGKGFBLO>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<ABNAGONECLM<object?, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22ED810", Offset = "0x22ECC10", VA = "0x1822ED810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x22EDC70", Offset = "0x22ED070", VA = "0x1822EDC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly IReadOnlyList<OCNCAELNEHP> AGMAMDDJNED;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	private JBNOHBOLCEI(IReadOnlyList<OCNCAELNEHP> GAEGLPHPPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x22EB370", Offset = "0x22EA770", VA = "0x1822EB370")]
	public static OCNCAELNEHP CCDFLFOBCNL(IReadOnlyList<OCNCAELNEHP> GAEGLPHPPHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22EB430", Offset = "0x22EA830", VA = "0x1822EB430")]
	public static KGAAMPHMJKE<FEAPAONCDCL, JBNOHBOLCEI> JHAAKKPJLOI(OCNCAELNEHP AEKGIDHHLCL)
	{
		return default(KGAAMPHMJKE<FEAPAONCDCL, JBNOHBOLCEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22EB4D0", Offset = "0x22EA8D0", VA = "0x1822EB4D0")]
	[AsyncStateMachine(typeof(LHLELHICOIA))]
	public static Task<ABNAGONECLM<NDLCFMMJECI, IAAGGMEHHFI>> JKIPIDOJPLO(DLFOGDDKJHH NIMLNKDMKHI, JBNOHBOLCEI MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct BKDLFMCMHNE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class OIKABFOHPOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class EHDAOFFCMLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public PBDBGAKNNHI<OIKABFOHPOA> actionId;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EHDAOFFCMLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x22DD600", Offset = "0x22DCA00", VA = "0x1822DD600")]
		internal OCNCAELNEHP KGAFJEKIIIO(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly PBDBGAKNNHI<OIKABFOHPOA> OHOJDPHGOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly int MKHKOEAGNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly int MCCLHKLCIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly byte[] GLBGLIBCAOD;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x22D97B0", Offset = "0x22D8BB0", VA = "0x1822D97B0")]
	private BKDLFMCMHNE(PBDBGAKNNHI<OIKABFOHPOA> MDPHKDLJIID, int ABPDJOGPHFP, int IIACLAMOIEE, byte[] JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x22D93C0", Offset = "0x22D87C0", VA = "0x1822D93C0")]
	public static OCNCAELNEHP CCDFLFOBCNL(PBDBGAKNNHI<OIKABFOHPOA> MDPHKDLJIID, int ABPDJOGPHFP, int IIACLAMOIEE, ByteString JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x22D92B0", Offset = "0x22D86B0", VA = "0x1822D92B0")]
	public static OCNCAELNEHP[] ADGKJADMPOB(OCNCAELNEHP OLHFOBIBHCJ, int IMMAMICNCIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x22D94D0", Offset = "0x22D88D0", VA = "0x1822D94D0")]
	public static KGAAMPHMJKE<FEAPAONCDCL, BKDLFMCMHNE> JHAAKKPJLOI(OCNCAELNEHP AEKGIDHHLCL)
	{
		return default(KGAAMPHMJKE<FEAPAONCDCL, BKDLFMCMHNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x22D9620", Offset = "0x22D8A20", VA = "0x1822D9620")]
	public static ABNAGONECLM<OCNCAELNEHP, IAAGGMEHHFI> OFALIHCNEIG(DLFOGDDKJHH NIMLNKDMKHI, [In] BKDLFMCMHNE MPLBPEBNKFP)
	{
		return default(ABNAGONECLM<OCNCAELNEHP, IAAGGMEHHFI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct FMBNIOOJGFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct KINIEIFKADD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<bool, JMMAFLLBCOF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DLFOGDDKJHH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FMBNIOOJGFJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private ABNAGONECLM<bool, JMMAFLLBCOF> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, JMMAFLLBCOF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x22EC850", Offset = "0x22EBC50", VA = "0x1822EC850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x22ECE90", Offset = "0x22EC290", VA = "0x1822ECE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int MKHKOEAGNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly int MCCLHKLCIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly byte[] GLBGLIBCAOD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x214D440", Offset = "0x214C840", VA = "0x18214D440")]
	private FMBNIOOJGFJ(int ABPDJOGPHFP, int IIACLAMOIEE, byte[] JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x22DEBD0", Offset = "0x22DDFD0", VA = "0x1822DEBD0")]
	public static OCNCAELNEHP CCDFLFOBCNL(int ABPDJOGPHFP, int IIACLAMOIEE, ByteString JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x22DEEC0", Offset = "0x22DE2C0", VA = "0x1822DEEC0")]
	public static OCNCAELNEHP?[]? NLJNPECMPJE(int IMMAMICNCIE, IEBOLOHJJBA? BNECGPCNHPJ, DPCOLNDKMBE? IKIGPJFOFLK, KOLIENJCING? EJFFMDCEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x22DECB0", Offset = "0x22DE0B0", VA = "0x1822DECB0")]
	public static KGAAMPHMJKE<FEAPAONCDCL, FMBNIOOJGFJ> JHAAKKPJLOI(OCNCAELNEHP AEKGIDHHLCL)
	{
		return default(KGAAMPHMJKE<FEAPAONCDCL, FMBNIOOJGFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x22DED90", Offset = "0x22DE190", VA = "0x1822DED90")]
	[AsyncStateMachine(typeof(KINIEIFKADD))]
	public static Task<ABNAGONECLM<bool, JMMAFLLBCOF>> JKIPIDOJPLO(DLFOGDDKJHH NIMLNKDMKHI, FMBNIOOJGFJ MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OMGGKJMENND : BILEEKCDNAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DLFOGDDKJHH DMPLBKKFJEJ;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BEONDLECMKF? ELEBKANKHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x22F2670", Offset = "0x22F1A70", VA = "0x1822F2670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	internal OMGGKJMENND(DLFOGDDKJHH HCHGEACFMON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GACIGHAKMFC : BEONDLECMKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly DLFOGDDKJHH DMPLBKKFJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CEGJBKIKGBB LDLPBPGHEOI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	public GACIGHAKMFC(DLFOGDDKJHH HCHGEACFMON, CEGJBKIKGBB KAMPLKLCGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x22DF0B0", Offset = "0x22DE4B0", VA = "0x1822DF0B0", Slot = "4")]
	public ABNAGONECLM<FNKGFKLHJEJ, JAIMDHJMEGG> FMHHJGOFNNN(PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, AHPCDKCOAJM<DPLMPJGGPFN> AFJGGPEMBOM)
	{
		return default(ABNAGONECLM<FNKGFKLHJEJ, JAIMDHJMEGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x22DF390", Offset = "0x22DE790", VA = "0x1822DF390", Slot = "5")]
	public ABNAGONECLM<FNKGFKLHJEJ, JAIMDHJMEGG> ONEAMPIMGAH(PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, AHPCDKCOAJM<JFFAPEFODIA> MLIAJGPJJLE)
	{
		return default(ABNAGONECLM<FNKGFKLHJEJ, JAIMDHJMEGG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class EGFCEIPNOCE : DOGDCGKEOJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface ECIHMKIHNGK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CEGJBKIKGBB> JENINDCNJPF(DLFOGDDKJHH HCHGEACFMON, DPCOLNDKMBE? OCCEMKJNPEO, KOLIENJCING? HNEHKNGJDPN, CancellationToken FHGIOBPPFHG);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PFPGAAFGKDN NCICLFHDKIA(DLFOGDDKJHH HCHGEACFMON, IEBOLOHJJBA FBHLKBBCONG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class AMONCBGOGEN : ECIHMKIHNGK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct JLJBCGFLNBH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<CEGJBKIKGBB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public DLFOGDDKJHH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public DPCOLNDKMBE cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public KOLIENJCING cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<IDFENAAFFDL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x22EBC20", Offset = "0x22EB020", VA = "0x1822EBC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x22EBDF0", Offset = "0x22EB1F0", VA = "0x1822EBDF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly AMONCBGOGEN ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private AMONCBGOGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x22D8870", Offset = "0x22D7C70", VA = "0x1822D8870", Slot = "4")]
		[AsyncStateMachine(typeof(JLJBCGFLNBH))]
		public Task<CEGJBKIKGBB> JENINDCNJPF(DLFOGDDKJHH HCHGEACFMON, DPCOLNDKMBE? OCCEMKJNPEO, KOLIENJCING? HNEHKNGJDPN, CancellationToken FHGIOBPPFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x22D89D0", Offset = "0x22D7DD0", VA = "0x1822D89D0", Slot = "5")]
		public PFPGAAFGKDN NCICLFHDKIA(DLFOGDDKJHH HCHGEACFMON, IEBOLOHJJBA FBHLKBBCONG)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct HENODKECEJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<EGFCEIPNOCE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DLFOGDDKJHH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public DPCOLNDKMBE cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KOLIENJCING cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public IEBOLOHJJBA evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private ECIHMKIHNGK <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<CEGJBKIKGBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x22EA3B0", Offset = "0x22E97B0", VA = "0x1822EA3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x22EA8A0", Offset = "0x22E9CA0", VA = "0x1822EA8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CEGJBKIKGBB LDLPBPGHEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly PFPGAAFGKDN OFHFLNJIANB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JFLIKJPNOAH MJNACGLJCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x22DD440", Offset = "0x22DC840", VA = "0x1822DD440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FOCCBPILPIJ FKIEEJMMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x22DD380", Offset = "0x22DC780", VA = "0x1822DD380", Slot = "5")]
		get
		{
			return default(FOCCBPILPIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GACIGHAKMFC PICCCOOHIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NEMJOPFBBEB NNBNBEPPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xB5C7A0", Offset = "0xB5BBA0", VA = "0x180B5C7A0")]
	private EGFCEIPNOCE(CEGJBKIKGBB KAMPLKLCGEG, PFPGAAFGKDN JNGLNCIGJCC, GACIGHAKMFC NEDDDMLNDAB, NEMJOPFBBEB MBJOCLNCBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x22DD490", Offset = "0x22DC890", VA = "0x1822DD490")]
	[AsyncStateMachine(typeof(HENODKECEJE))]
	public static Task<EGFCEIPNOCE> MKCPCHIKKCB(DLFOGDDKJHH HCHGEACFMON, IEBOLOHJJBA FBHLKBBCONG, DPCOLNDKMBE? OCCEMKJNPEO, KOLIENJCING? HNEHKNGJDPN, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x22DD320", Offset = "0x22DC720", VA = "0x1822DD320", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class CMPKJCBJJIB : BGPHAECIAFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface DJCGFLIGCGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DOGDCGKEOJO> OPLIEONELBE(DLFOGDDKJHH HCHGEACFMON, IEBOLOHJJBA FBHLKBBCONG, DPCOLNDKMBE? OCCEMKJNPEO, KOLIENJCING? HNEHKNGJDPN, CancellationToken FHGIOBPPFHG);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HGNHIHOBPEG();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IKNEDOLHDOH();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public abstract class PHMNJGPNGCA : DJCGFLIGCGK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct JCOLLPLJFGN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<DOGDCGKEOJO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public DLFOGDDKJHH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public IEBOLOHJJBA evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public DPCOLNDKMBE cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public KOLIENJCING cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<EGFCEIPNOCE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x22EB870", Offset = "0x22EAC70", VA = "0x1822EB870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x22EBBB0", Offset = "0x22EAFB0", VA = "0x1822EBBB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x22F2C10", Offset = "0x22F2010", VA = "0x1822F2C10", Slot = "4")]
		[AsyncStateMachine(typeof(JCOLLPLJFGN))]
		public Task<DOGDCGKEOJO> OPLIEONELBE(DLFOGDDKJHH HCHGEACFMON, IEBOLOHJJBA FBHLKBBCONG, DPCOLNDKMBE? OCCEMKJNPEO, KOLIENJCING? HNEHKNGJDPN, CancellationToken FHGIOBPPFHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HGNHIHOBPEG();

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void IKNEDOLHDOH();

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		protected PHMNJGPNGCA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BAEFDMOJCNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<DOGDCGKEOJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CMPKJCBJJIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<ALHKDJHEAFJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x22D8A60", Offset = "0x22D7E60", VA = "0x1822D8A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x22D8C60", Offset = "0x22D8060", VA = "0x1822D8C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct LKJGGHGOCBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CMPKJCBJJIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public DLFOGDDKJHH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public IEBOLOHJJBA evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DPCOLNDKMBE cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KOLIENJCING cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<DOGDCGKEOJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x22EDCE0", Offset = "0x22ED0E0", VA = "0x1822EDCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x22EE210", Offset = "0x22ED610", VA = "0x1822EE210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly DJCGFLIGCGK OIKLGOFBDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<ALHKDJHEAFJ> ONBOHHOELPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<ALHKDJHEAFJ> GHCCJHIPBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource HHGAJDHNBKL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool NLEOHDLLJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8F4100", Offset = "0x8F3500", VA = "0x1808F4100", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8F3F20", Offset = "0x8F3320", VA = "0x1808F3F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9F20B0", Offset = "0x9F14B0", VA = "0x1809F20B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xE8F040", Offset = "0xE8E440", VA = "0x180E8F040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ICDCHOPOFDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x14ED790", Offset = "0x14ECB90", VA = "0x1814ED790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x22D9B60", Offset = "0x22D8F60", VA = "0x1822D9B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DOGDCGKEOJO? GFPMKOLKEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8D0CD0", Offset = "0x8D00D0", VA = "0x1808D0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x22D9CD0", Offset = "0x22D90D0", VA = "0x1822D9CD0", Slot = "7")]
	[AsyncStateMachine(typeof(BAEFDMOJCNE))]
	public Task<DOGDCGKEOJO> OJOHPKFGMPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x22D9DC0", Offset = "0x22D91C0", VA = "0x1822D9DC0")]
	public CMPKJCBJJIB(DJCGFLIGCGK CFAPAOIIPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x22D9B70", Offset = "0x22D8F70", VA = "0x1822D9B70", Slot = "8")]
	[AsyncStateMachine(typeof(LKJGGHGOCBP))]
	public Task LPCJOGFNKJI(DLFOGDDKJHH HCHGEACFMON, IEBOLOHJJBA FBHLKBBCONG, DPCOLNDKMBE? OCCEMKJNPEO, KOLIENJCING? HNEHKNGJDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x22D99E0", Offset = "0x22D8DE0", VA = "0x1822D99E0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class MDKBBHOLKBO : HACAPCOEDNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NEMJOPFBBEB BKBNCBHGDFI;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public MDKBBHOLKBO(NEMJOPFBBEB MBJOCLNCBIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class LDIFCECLEMK
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class NLCHNKIDDEJ<TGraph> : KCEKFMOEPNL where TGraph : DNKFIPMKJGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph AKFBDMBKNAI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual GHAOPPAOICH? JOBKIGAFEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1319B70", Offset = "0x1318F70", VA = "0x181319B70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AHPCDKCOAJM<PNODKKHPFBO> DAILGMDEFCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x4A9AEC0", Offset = "0x4A9A2C0", VA = "0x184A9AEC0", Slot = "5")]
			get
			{
				return default(AHPCDKCOAJM<PNODKKHPFBO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AHPCDKCOAJM<PNODKKHPFBO>? ODELFOCFHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x4A9AEE0", Offset = "0x4A9A2E0", VA = "0x184A9AEE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
		public NLCHNKIDDEJ(TGraph CIBJIJAGOGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class DBKHGHFDIEN : NLCHNKIDDEJ<GAKALHPBOKN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override GHAOPPAOICH? JOBKIGAFEKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x22DB4D0", Offset = "0x22DA8D0", VA = "0x1822DB4D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x22DB4F0", Offset = "0x22DA8F0", VA = "0x1822DB4F0")]
		public DBKHGHFDIEN(GAKALHPBOKN IIMBANPEOLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x22ED390", Offset = "0x22EC790", VA = "0x1822ED390")]
	public static KCEKFMOEPNL ODOFIFAGLAJ(DNKFIPMKJGC CIBJIJAGOGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class NDEIBOIGIEP : LJKOGHONMGE, OIOMPGFJCEO, JIJMCDJACFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class OGAHDGOIFOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public OGAHDGOIFOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public GDCDMFKBBJH errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x22F4C00", Offset = "0x22F4000", VA = "0x1822F4C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x22F4E70", Offset = "0x22F4270", VA = "0x1822F4E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NDEIBOIGIEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OGAHDGOIFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x22F1A10", Offset = "0x22F0E10", VA = "0x1822F1A10")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task DMILNHCNAMG(GDCDMFKBBJH errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct KCMANKLNELD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NDEIBOIGIEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x22EC2F0", Offset = "0x22EB6F0", VA = "0x1822EC2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x22EC7F0", Offset = "0x22EBBF0", VA = "0x1822EC7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class FFPJLBPDAKC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public FFPJLBPDAKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x22F4ED0", Offset = "0x22F42D0", VA = "0x1822F4ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x22F51B0", Offset = "0x22F45B0", VA = "0x1822F51B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public NDEIBOIGIEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FFPJLBPDAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x22DE310", Offset = "0x22DD710", VA = "0x1822DE310")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task OLLKJHEDDEH(GDCDMFKBBJH errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly BLLIGGJJDEM JFMLLFPHABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<GBLHOJCBMBK> HGMMPJOKGHD;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private DPIOAKOAPGI LPIHCEDEMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x22EF930", Offset = "0x22EED30", VA = "0x1822EF930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AHPCDKCOAJM<DPLMPJGGPFN> PLNJCLNGDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xB1C670", Offset = "0xB1BA70", VA = "0x180B1C670", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(AHPCDKCOAJM<DPLMPJGGPFN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB1C920", Offset = "0xB1BD20", VA = "0x180B1C920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private AHPCDKCOAJM<FEHJPJMJDBG> LDALBKLPIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE8D3A0", Offset = "0xE8C7A0", VA = "0x180E8D3A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public AHPCDKCOAJM<PLHEEEFNBNK> DKIEHCHKIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8EE380", Offset = "0x8ED780", VA = "0x1808EE380", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(AHPCDKCOAJM<PLHEEEFNBNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override AHPCDKCOAJM<GBPNADAEKMC> DBCNIGOJOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x22EFAF0", Offset = "0x22EEEF0", VA = "0x1822EFAF0", Slot = "20")]
		get
		{
			return default(AHPCDKCOAJM<GBPNADAEKMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KEMBENDNOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x22EF950", Offset = "0x22EED50", VA = "0x1822EF950", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x22F1770", Offset = "0x22F0B70", VA = "0x1822F1770")]
	private NDEIBOIGIEP(DLFOGDDKJHH HCHGEACFMON, FAKCDJHFJMO AJLPJFOPFCG, BLLIGGJJDEM GDFFHCBMJIO, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, AHPCDKCOAJM<DPLMPJGGPFN> AFJGGPEMBOM, AHPCDKCOAJM<FEHJPJMJDBG> IOOAPHCONAK, bool PPJKGGLIKHO, string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x22F0E40", Offset = "0x22F0240", VA = "0x1822F0E40")]
	public static NDEIBOIGIEP ODOFIFAGLAJ(DLFOGDDKJHH HCHGEACFMON, FAKCDJHFJMO AJLPJFOPFCG, BLLIGGJJDEM AOOGNGKJLKL, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, AHPCDKCOAJM<FEHJPJMJDBG> IOOAPHCONAK, AHPCDKCOAJM<DPLMPJGGPFN> AFJGGPEMBOM, bool PPJKGGLIKHO, bool OAMILALIJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22F1410", Offset = "0x22F0810", VA = "0x1822F1410", Slot = "21")]
	protected override void OOJJEJPOBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x22EF460", Offset = "0x22EE860", VA = "0x1822EF460", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x22EEF70", Offset = "0x22EE370", VA = "0x1822EEF70", Slot = "30")]
	public void AKOCOFEHDAA(GBLHOJCBMBK EELHDOMDJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x22EEFD0", Offset = "0x22EE3D0", VA = "0x1822EEFD0", Slot = "27")]
	public void APNACLIPKOG(EPADMHCDMOI JMGHAHNDOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22F04C0", Offset = "0x22EF8C0", VA = "0x1822F04C0", Slot = "28")]
	public void NJLNBJKMLCD(JGAAHLBFFPO NEKHGHPADML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x22F1200", Offset = "0x22F0600", VA = "0x1822F1200", Slot = "23")]
	protected override void OICFPHMGNCD(PIJNDAFPFNN PNKBECKBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x22EF500", Offset = "0x22EE900", VA = "0x1822EF500", Slot = "32")]
	public string EPGPPHBBMBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x22F14B0", Offset = "0x22F08B0", VA = "0x1822F14B0", Slot = "29")]
	public string PCHLBCAGKAG(int HOCAGGHKPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x22EFD30", Offset = "0x22EF130", VA = "0x1822EFD30")]
	private void LNDBIPENOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x22F1350", Offset = "0x22F0750", VA = "0x1822F1350", Slot = "31")]
	public void OKCKPHNNOEH(GBLHOJCBMBK EELHDOMDJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x22EFF50", Offset = "0x22EF350", VA = "0x1822EFF50")]
	private void MJGHAAAFGNL(bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x22EFB90", Offset = "0x22EEF90", VA = "0x1822EFB90", Slot = "33")]
	[AsyncStateMachine(typeof(KCMANKLNELD))]
	public Task KBOBMOHBLDD(string HCPAOILCJCB, bool CIJABPAFDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x22F01D0", Offset = "0x22EF5D0", VA = "0x1822F01D0")]
	public void MLIEAOKJEMB(string HCPAOILCJCB, bool CIJABPAFDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22F0320", Offset = "0x22EF720", VA = "0x1822F0320")]
	private void MMPJKMMFLLJ(int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xB1C920", Offset = "0xB1BD20", VA = "0x180B1C920")]
	internal void KCCIIDFKBHJ(AHPCDKCOAJM<DPLMPJGGPFN> HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x22F11F0", Offset = "0x22F05F0", VA = "0x1822F11F0")]
	[CompilerGenerated]
	private void OGNHKKFFGKN(string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x22EF7A0", Offset = "0x22EEBA0", VA = "0x1822EF7A0")]
	[CompilerGenerated]
	private bool FMFIKEAIFCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22F0110", Offset = "0x22EF510", VA = "0x1822F0110")]
	[CompilerGenerated]
	private bool MKFFDGNBFHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x22EF410", Offset = "0x22EE810", VA = "0x1822EF410")]
	[CompilerGenerated]
	private int CDJKICIIOFE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x22EF9D0", Offset = "0x22EEDD0", VA = "0x1822EF9D0")]
	[CompilerGenerated]
	private bool HKJABMNOLLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22EFD20", Offset = "0x22EF120", VA = "0x1822EFD20")]
	[CompilerGenerated]
	private void KPMNHBBIIPD(string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x22EF660", Offset = "0x22EEA60", VA = "0x1822EF660")]
	[CompilerGenerated]
	private bool FBGHMIDFOHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x22EFB40", Offset = "0x22EEF40", VA = "0x1822EFB40")]
	[CompilerGenerated]
	private bool JGHOIIAMLEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x22EFA60", Offset = "0x22EEE60", VA = "0x1822EFA60")]
	[CompilerGenerated]
	private bool JDKPPKLINDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x22EF410", Offset = "0x22EE810", VA = "0x1822EF410")]
	[CompilerGenerated]
	private int EAEBAOGKKNO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x22EF340", Offset = "0x22EE740", VA = "0x1822EF340")]
	[CompilerGenerated]
	private bool BBCKKGPJAAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x22EF720", Offset = "0x22EEB20", VA = "0x1822EF720")]
	[CompilerGenerated]
	private object FKDCIIDLKJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x22EFCA0", Offset = "0x22EF0A0", VA = "0x1822EFCA0")]
	[CompilerGenerated]
	private void KGLCIGKNKGA(object HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x22EF860", Offset = "0x22EEC60", VA = "0x1822EF860")]
	[CompilerGenerated]
	private bool GBEBCEJBABA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DANBOJDPENE
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private sealed class FKHOEKNJABB : BDEHOBDKNOL<CDLENDLEKBI>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class MCGIANCNNPF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public FKHOEKNJABB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public MCGIANCNNPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x22EE270", Offset = "0x22ED670", VA = "0x1822EE270")]
			internal object MLAAGLMMDFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x22EE2E0", Offset = "0x22ED6E0", VA = "0x1822EE2E0")]
			internal void PDAJCGGHEFH(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x22DE830", Offset = "0x22DDC30", VA = "0x1822DE830")]
		public FKHOEKNJABB(DLFOGDDKJHH HCHGEACFMON, CDLENDLEKBI HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x22DE5A0", Offset = "0x22DD9A0", VA = "0x1822DE5A0", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class FECDIBCLNEO : LANBKAKBHDN<MBJCDEFNGCE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override KGJJJCENCJI LNCKIBPLPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x935560", Offset = "0x934960", VA = "0x180935560", Slot = "128")]
			get
			{
				return default(KGJJJCENCJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x22DE2B0", Offset = "0x22DD6B0", VA = "0x1822DE2B0")]
		public FECDIBCLNEO(DLFOGDDKJHH HCHGEACFMON, MBJCDEFNGCE HKNABNLJGOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class OGNLICHCLMI : BDEHOBDKNOL<EAOKMLOOFGB>
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x22F1DF0", Offset = "0x22F11F0", VA = "0x1822F1DF0")]
		public OGNLICHCLMI(DLFOGDDKJHH HCHGEACFMON, EAOKMLOOFGB AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x22F1B00", Offset = "0x22F0F00", VA = "0x1822F1B00", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x22F1C80", Offset = "0x22F1080", VA = "0x1822F1C80")]
		[CompilerGenerated]
		private bool EOLNOECFKHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x22F1CD0", Offset = "0x22F10D0", VA = "0x1822F1CD0")]
		[CompilerGenerated]
		private void JMPDCLNIMNK(bool HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class BHDMKEMEKEH : BDEHOBDKNOL<AAPDLPCFPOG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class IHDGEKGMCEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public BHDMKEMEKEH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public IHDGEKGMCEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x22EB160", Offset = "0x22EA560", VA = "0x1822EB160")]
			internal void MLAAGLMMDFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x22EB320", Offset = "0x22EA720", VA = "0x1822EB320")]
			internal bool PDAJCGGHEFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x22EB2D0", Offset = "0x22EA6D0", VA = "0x1822EB2D0")]
			internal bool PBMMAPMNPOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x22EB1B0", Offset = "0x22EA5B0", VA = "0x1822EB1B0")]
			internal void PBAIAHOJBNK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x22EB110", Offset = "0x22EA510", VA = "0x1822EB110")]
			internal bool EHPJBOIINIJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x22D9010", Offset = "0x22D8410", VA = "0x1822D9010")]
		public BHDMKEMEKEH(DLFOGDDKJHH HCHGEACFMON, AAPDLPCFPOG AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x22D8CD0", Offset = "0x22D80D0", VA = "0x1822D8CD0", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class ENNPLHONJKF : BDEHOBDKNOL<LKKEDKFPNFE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class MIADCGDEKAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public ENNPLHONJKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public MIADCGDEKAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x22EE590", Offset = "0x22ED990", VA = "0x1822EE590")]
			internal object MLAAGLMMDFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x22EE690", Offset = "0x22EDA90", VA = "0x1822EE690")]
			internal bool ONONMOPNFIE(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x22EE8C0", Offset = "0x22EDCC0", VA = "0x1822EE8C0")]
			internal void PDAJCGGHEFH(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x22EE760", Offset = "0x22EDB60", VA = "0x1822EE760")]
			internal string PBMMAPMNPOP(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x22EE710", Offset = "0x22EDB10", VA = "0x1822EE710")]
			internal IReadOnlyList<object> PBAIAHOJBNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x22EE400", Offset = "0x22ED800", VA = "0x1822EE400")]
			internal bool EHPJBOIINIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x22EE3B0", Offset = "0x22ED7B0", VA = "0x1822EE3B0")]
			internal bool ADNGHCOIDNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x22EE470", Offset = "0x22ED870", VA = "0x1822EE470")]
			internal void GBINDMDKDFN(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x22DDEC0", Offset = "0x22DD2C0", VA = "0x1822DDEC0")]
		public ENNPLHONJKF(DLFOGDDKJHH HCHGEACFMON, LKKEDKFPNFE AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x22DD770", Offset = "0x22DCB70", VA = "0x1822DD770", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class OKLENKHMLLC : BDEHOBDKNOL<FFNBKAILMPM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class FJEEJJOOKJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public OKLENKHMLLC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public FJEEJJOOKJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x22DE3E0", Offset = "0x22DD7E0", VA = "0x1822DE3E0")]
			internal bool MLAAGLMMDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x22DE480", Offset = "0x22DD880", VA = "0x1822DE480")]
			internal void PDAJCGGHEFH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x22DE430", Offset = "0x22DD830", VA = "0x1822DE430")]
			internal bool PBMMAPMNPOP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x22F2090", Offset = "0x22F1490", VA = "0x1822F2090")]
		public OKLENKHMLLC(DLFOGDDKJHH HCHGEACFMON, FFNBKAILMPM AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x22F1E60", Offset = "0x22F1260", VA = "0x1822F1E60", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class AOOOAPLDGHO<TNode> : BDEHOBDKNOL<TNode> where TNode : notnull, NGNOHKGEJCN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct HAAABIINLHD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<AHPCDKCOAJM<FGCEHDOJGEK>, IAAGGMEHHFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AOOOAPLDGHO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<ABNAGONECLM<AHPCDKCOAJM<FGCEHDOJGEK>, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x4205AE0", Offset = "0x4204EE0", VA = "0x184205AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x4205EE0", Offset = "0x42052E0", VA = "0x184205EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct IGJIDGGINFD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public AOOOAPLDGHO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public AHPCDKCOAJM<FGCEHDOJGEK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x43360B0", Offset = "0x43354B0", VA = "0x1843360B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x43364B0", Offset = "0x43358B0", VA = "0x1843364B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool JEJLNPPCAEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override AHPCDKCOAJM<FGCEHDOJGEK>? GGAIBBCOHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x42FDAD0", Offset = "0x42FCED0", VA = "0x1842FDAD0", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x42FDA80", Offset = "0x42FCE80", VA = "0x1842FDA80")]
		protected AOOOAPLDGHO(DLFOGDDKJHH HCHGEACFMON, TNode AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x42FD780", Offset = "0x42FCB80", VA = "0x1842FD780", Slot = "102")]
		[AsyncStateMachine(typeof(AOOOAPLDGHO<>.HAAABIINLHD))]
		public override Task<ABNAGONECLM<AHPCDKCOAJM<FGCEHDOJGEK>, IAAGGMEHHFI>> GJANPGCGBBG(string LJAGHAHCFHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x42FD8A0", Offset = "0x42FCCA0", VA = "0x1842FD8A0", Slot = "126")]
		public sealed override bool IHGNLGMKNHB(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x42FD9E0", Offset = "0x42FCDE0", VA = "0x1842FD9E0", Slot = "114")]
		protected sealed override bool OHJHNMEMNCA(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x42FD940", Offset = "0x42FCD40", VA = "0x1842FD940", Slot = "115")]
		protected override bool MIAGCNOMNGA(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x42FD670", Offset = "0x42FCA70", VA = "0x1842FD670", Slot = "103")]
		[AsyncStateMachine(typeof(AOOOAPLDGHO<>.IGJIDGGINFD))]
		public override Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> CEFMGNPJPOD(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class LAPHNJFMOKI : KEMIEKNPFEC<HICEDNNIDNO>
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class JPLIOFBFIBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public LAPHNJFMOKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public JPLIOFBFIBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x22EC270", Offset = "0x22EB670", VA = "0x1822EC270")]
			internal bool CEIMNLJHKHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x22EC1B0", Offset = "0x22EB5B0", VA = "0x1822EC1B0")]
			internal void AHJDGHDABAB(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x22ED330", Offset = "0x22EC730", VA = "0x1822ED330")]
		public LAPHNJFMOKI(DLFOGDDKJHH HCHGEACFMON, HICEDNNIDNO HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x22ED0E0", Offset = "0x22EC4E0", VA = "0x1822ED0E0", Slot = "128")]
		protected override void COIEABDHGAB(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private sealed class CDDNDEDGAEL : PHPAMGEBMPK<KPJMDHBNIFI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93DFD0", VA = "0x18093EBD0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x22D97D0", Offset = "0x22D8BD0", VA = "0x1822D97D0")]
		public CDDNDEDGAEL(DLFOGDDKJHH HCHGEACFMON, KPJMDHBNIFI AJLPJFOPFCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class PHPAMGEBMPK<TNode> : BDEHOBDKNOL<TNode> where TNode : notnull, KBIDIHIJPLK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct GKNLLGONLFE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<AHPCDKCOAJM<FGCEHDOJGEK>, IAAGGMEHHFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public PHPAMGEBMPK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<ABNAGONECLM<AHPCDKCOAJM<FGCEHDOJGEK>, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x41A1EE0", Offset = "0x41A12E0", VA = "0x1841A1EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x41A2390", Offset = "0x41A1790", VA = "0x1841A2390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct CFCHEDGNOAK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public PHPAMGEBMPK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public AHPCDKCOAJM<FGCEHDOJGEK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x57018D0", Offset = "0x5700CD0", VA = "0x1857018D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5701D60", Offset = "0x5701160", VA = "0x185701D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct GGCPEFBLBNF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<NDLCFMMJECI, IAAGGMEHHFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public PHPAMGEBMPK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private TaskAwaiter<ABNAGONECLM<NDLCFMMJECI, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x41954C0", Offset = "0x41948C0", VA = "0x1841954C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4195B90", Offset = "0x4194F90", VA = "0x184195B90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class EABFEIBCGGM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public EABFEIBCGGM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x39AAFA0", Offset = "0x39AA3A0", VA = "0x1839AAFA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public MNBPGAMAPPH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public PHPAMGEBMPK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public EABFEIBCGGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x3C78D30", Offset = "0x3C78130", VA = "0x183C78D30")]
			internal bool GBINDMDKDFN(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3C78E10", Offset = "0x3C78210", VA = "0x183C78E10")]
			internal void MLAAGLMMDFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x3C79100", Offset = "0x3C78500", VA = "0x183C79100")]
			[AsyncStateMachine(typeof(PHPAMGEBMPK<>.EABFEIBCGGM.<<BuildConfigMenuInternal>b__7>d))]
			internal void ONONMOPNFIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3C791A0", Offset = "0x3C785A0", VA = "0x183C791A0")]
			internal bool PDAJCGGHEFH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class LECEMHFKHNI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public LECEMHFKHNI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x39AAC20", Offset = "0x39AA020", VA = "0x1839AAC20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public EABFEIBCGGM CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public LECEMHFKHNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x47BEA50", Offset = "0x47BDE50", VA = "0x1847BEA50")]
			internal void PBMMAPMNPOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			internal string PBAIAHOJBNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
			internal void EHPJBOIINIJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x47BE9B0", Offset = "0x47BDDB0", VA = "0x1847BE9B0")]
			[AsyncStateMachine(typeof(PHPAMGEBMPK<>.LECEMHFKHNI.<<BuildConfigMenuInternal>b__5>d))]
			internal void ADNGHCOIDNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class HIAPBKDMAJP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public HIAPBKDMAJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x39AA750", Offset = "0x39A9B50", VA = "0x1839AA750", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public HIAPBKDMAJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<ABNAGONECLM<AHPCDKCOAJM<FEHJPJMJDBG>, IAAGGMEHHFI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x39AA930", Offset = "0x39A9D30", VA = "0x1839AA930", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public HIAPBKDMAJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				private TaskAwaiter<ABNAGONECLM<AHPCDKCOAJM<CBPDOKJJLFC>, IAAGGMEHHFI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x39AA090", Offset = "0x39A9490", VA = "0x1839AA090", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public PHPAMGEBMPK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public AHPCDKCOAJM<FGCEHDOJGEK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public MNBPGAMAPPH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public CDMFBBECKPE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public FJGOBNNFCHJ selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public List<OOCKPHMFLHP> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public FJGOBNNFCHJ selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public List<OOCKPHMFLHP> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public HIAPBKDMAJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4253610", Offset = "0x4252A10", VA = "0x184253610")]
			internal bool FDDKIHJKBFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4253A50", Offset = "0x4252E50", VA = "0x184253A50")]
			internal void NPBAPGAPEMM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4253250", Offset = "0x4252650", VA = "0x184253250")]
			internal bool BCCGHCJDOHF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4253780", Offset = "0x4252B80", VA = "0x184253780")]
			internal bool GIKGCEFPGCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x42534C0", Offset = "0x42528C0", VA = "0x1842534C0")]
			[AsyncStateMachine(typeof(PHPAMGEBMPK<>.HIAPBKDMAJP.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void EHKODDBAKDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4253A10", Offset = "0x4252E10", VA = "0x184253A10")]
			internal bool LPMCIOFHIOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4253950", Offset = "0x4252D50", VA = "0x184253950")]
			internal void LIMKGEMICPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4253410", Offset = "0x4252810", VA = "0x184253410")]
			internal bool EEMLJEBKGJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4253820", Offset = "0x4252C20", VA = "0x184253820")]
			internal void JFGNAGMKHCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4253560", Offset = "0x4252960", VA = "0x184253560")]
			internal bool EPBCAMEFOJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4253B60", Offset = "0x4252F60", VA = "0x184253B60")]
			internal bool PFEJPAJDJHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x42533A0", Offset = "0x42527A0", VA = "0x1842533A0")]
			internal void COIFAFBPIPD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x4253AC0", Offset = "0x4252EC0", VA = "0x184253AC0")]
			[AsyncStateMachine(typeof(PHPAMGEBMPK<>.HIAPBKDMAJP.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void OIKHIEAIGHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x4253720", Offset = "0x4252B20", VA = "0x184253720")]
			internal bool GFHGADHHOAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x4253330", Offset = "0x4252730", VA = "0x184253330")]
			internal bool CCMMPGJMBOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x42538E0", Offset = "0x4252CE0", VA = "0x1842538E0")]
			internal void KCOEFPKGAHL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4253680", Offset = "0x4252A80", VA = "0x184253680")]
			[AsyncStateMachine(typeof(PHPAMGEBMPK<>.HIAPBKDMAJP.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void FKNIGGKFOAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x42537C0", Offset = "0x4252BC0", VA = "0x1842537C0")]
			internal bool HKOOJAMOOCD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class FDKLOFOLMDA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public FDKLOFOLMDA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x39AA380", Offset = "0x39A9780", VA = "0x1839AA380", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public HIAPBKDMAJP CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public FDKLOFOLMDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4058320", Offset = "0x4057720", VA = "0x184058320")]
			internal void ODELHMLFPDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			internal string CPAKHLHPMIP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
			internal void MEDFJEHAAGB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4058280", Offset = "0x4057680", VA = "0x184058280")]
			[AsyncStateMachine(typeof(PHPAMGEBMPK<>.FDKLOFOLMDA.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void LBDIILLAKIC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class IEOICCLMHGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public CDMFBBECKPE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public List<OOCKPHMFLHP> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public PHPAMGEBMPK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public AHPCDKCOAJM<FGCEHDOJGEK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public IEOICCLMHGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4332B40", Offset = "0x4331F40", VA = "0x184332B40")]
			internal bool AFHFOEIPCDN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class PEDHDDEJIEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public JIJMCDJACFB port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public IEOICCLMHGG CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public PEDHDDEJIEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4C5BEE0", Offset = "0x4C5B2E0", VA = "0x184C5BEE0")]
			internal void DOJPGJPCDCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4C5C170", Offset = "0x4C5B570", VA = "0x184C5C170")]
			internal bool OIFGFJOKMMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4C5C050", Offset = "0x4C5B450", VA = "0x184C5C050")]
			internal void FONPDJOPAMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4C5BFF0", Offset = "0x4C5B3F0", VA = "0x184C5BFF0")]
			internal bool EMJCDCFEAAO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class IHNGFJEGIEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public OOCKPHMFLHP portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public PEDHDDEJIEA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public IHNGFJEGIEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x434F7C0", Offset = "0x434EBC0", VA = "0x18434F7C0")]
			internal void MJIBCEIMMJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class AGIMADCCFNO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000061")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public AGIMADCCFNO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x39AC410", Offset = "0x39AB810", VA = "0x1839AC410", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public FJGOBNNFCHJ selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public CDMFBBECKPE nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public JIJMCDJACFB port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public AGIMADCCFNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x41D3260", Offset = "0x41D2660", VA = "0x1841D3260")]
			internal int MCCPFCFCFIK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x41D3020", Offset = "0x41D2420", VA = "0x1841D3020")]
			internal void GHMIDACELNI(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970")]
			internal string FCPFLFFPPLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x41D2F60", Offset = "0x41D2360", VA = "0x1841D2F60")]
			[AsyncStateMachine(typeof(PHPAMGEBMPK<>.AGIMADCCFNO.<<CreatePortItemV2>b__3>d))]
			internal void BMEENJCNJKN(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x41D32A0", Offset = "0x41D26A0", VA = "0x1841D32A0")]
			internal bool OHGKAFHMBMK(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Dictionary<AHPCDKCOAJM<FGCEHDOJGEK>, bool> OLEIDFCHELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly Dictionary<AHPCDKCOAJM<FGCEHDOJGEK>, bool> LLDOKJDALLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<AHPCDKCOAJM<FGCEHDOJGEK>, bool> PNCLGALGEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Dictionary<AHPCDKCOAJM<FGCEHDOJGEK>, bool> EIPODMENAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private Dictionary<AHPCDKCOAJM<FGCEHDOJGEK>, bool> FPOPGAOFNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<AHPCDKCOAJM<FGCEHDOJGEK>, bool> LLNMMFLOADH;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool CBAGBBAGLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool OFKCAIOBAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool IEGLCHBKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool BMKCBIKBPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override AHPCDKCOAJM<PNODKKHPFBO>? CHJILMAINAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4C6A840", Offset = "0x4C69C40", VA = "0x184C6A840", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override AHPCDKCOAJM<FGCEHDOJGEK>? GGAIBBCOHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x4C6AB10", Offset = "0x4C69F10", VA = "0x184C6AB10", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<PBDBGAKNNHI<AMFCOJIMJGL>>? GJPGDEHAPFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x4C6A900", Offset = "0x4C69D00", VA = "0x184C6A900", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4C6A620", Offset = "0x4C69A20", VA = "0x184C6A620")]
		public PHPAMGEBMPK(DLFOGDDKJHH HCHGEACFMON, TNode AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "131")]
		protected virtual bool AIONNHPLGGI(int FJKGHHKDDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "132")]
		protected virtual bool HPANCMHLHEI(int FJKGHHKDDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "133")]
		protected virtual bool GGAJIFHGBIF(int FJKGHHKDDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "134")]
		protected virtual void OPJALCAOKIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4C68DC0", Offset = "0x4C681C0", VA = "0x184C68DC0", Slot = "126")]
		public override bool IHGNLGMKNHB(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4C682B0", Offset = "0x4C676B0", VA = "0x184C682B0", Slot = "102")]
		[AsyncStateMachine(typeof(PHPAMGEBMPK<>.GKNLLGONLFE))]
		public override Task<ABNAGONECLM<AHPCDKCOAJM<FGCEHDOJGEK>, IAAGGMEHHFI>> GJANPGCGBBG(string LJAGHAHCFHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4C67740", Offset = "0x4C66B40", VA = "0x184C67740", Slot = "103")]
		[AsyncStateMachine(typeof(PHPAMGEBMPK<>.CFCHEDGNOAK))]
		public override Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> CEFMGNPJPOD(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4C6A410", Offset = "0x4C69810", VA = "0x184C6A410", Slot = "104")]
		public override void ONLNIEJCPOI(AHPCDKCOAJM<FGCEHDOJGEK> IIACLAMOIEE, AHPCDKCOAJM<FGCEHDOJGEK> MGPMAFDHMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4C6A190", Offset = "0x4C69590", VA = "0x184C6A190", Slot = "105")]
		public override IEnumerable<OCNCAELNEHP> OMOIKBCICBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4C67640", Offset = "0x4C66A40", VA = "0x184C67640")]
		[AsyncStateMachine(typeof(PHPAMGEBMPK<>.GGCPEFBLBNF))]
		private Task<ABNAGONECLM<NDLCFMMJECI, IAAGGMEHHFI>> CDMEPNHPJGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "135")]
		protected virtual bool PBOKBBPOEIK(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "136")]
		protected virtual bool KOJFLALAEPB(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "137")]
		protected virtual bool IKFLKNKONLP(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "138")]
		protected virtual bool CHEINCMNECJ(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "139")]
		protected virtual bool MDOPGGKGOBM(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, int GJMAEFNEOJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "140")]
		protected virtual bool PLNEAKMAAFI(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, int GJMAEFNEOJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "141")]
		protected virtual bool AONIDPDIOKC(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, int BPGFELJIPDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "142")]
		protected virtual bool CHHIKHBHLKJ(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, int BPGFELJIPDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "143")]
		protected virtual bool OMNCMJOKFJM(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, int IJNJJIFCDBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "144")]
		protected virtual bool LMGBDOINJFA(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, int HCBBANBCILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4C65C30", Offset = "0x4C65030", VA = "0x184C65C30", Slot = "145")]
		protected virtual List<FJGOBNNFCHJ> BEOILMADIJO(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "146")]
		protected virtual void GIDOALKNILI(MNBPGAMAPPH NMKGOIAJNCN, LOCOGFFMCHF OBLPMINGKDE, CDMFBBECKPE LCBGAOKLEPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4C67850", Offset = "0x4C66C50", VA = "0x184C67850", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4C65EC0", Offset = "0x4C652C0", VA = "0x184C65EC0")]
		private LOCOGFFMCHF BLPIBIKJEIC(MNBPGAMAPPH NMKGOIAJNCN, CDMFBBECKPE LCBGAOKLEPJ, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4C69050", Offset = "0x4C68450", VA = "0x184C69050")]
		private List<OOCKPHMFLHP> KJGAONAJMEH(MNBPGAMAPPH NMKGOIAJNCN, CDMFBBECKPE LCBGAOKLEPJ, LOCOGFFMCHF CFNMGPADJBI, bool POJBCHAHLFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4C68470", Offset = "0x4C67870", VA = "0x184C68470")]
		private List<OOCKPHMFLHP> IFIOGCBHEJJ(MNBPGAMAPPH NMKGOIAJNCN, CDMFBBECKPE LCBGAOKLEPJ, JIJMCDJACFB KFFGLKDIHDK, bool POJBCHAHLFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4C68E60", Offset = "0x4C68260", VA = "0x184C68E60")]
		private FJGOBNNFCHJ JOFGNFOEKCM(List<FJGOBNNFCHJ> AGJBGIFINIK, JIJMCDJACFB KFFGLKDIHDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4C683D0", Offset = "0x4C677D0", VA = "0x184C683D0")]
		[CompilerGenerated]
		private OCNCAELNEHP IDDKPIMHECF(FAKCDJHFJMO IBIAGDBMPOH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class BIHKFJHGPEN : BDEHOBDKNOL<CJNKFMHOJNH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class FEAAIGAHFGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public BIHKFJHGPEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public FEAAIGAHFGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x22DE1D0", Offset = "0x22DD5D0", VA = "0x1822DE1D0")]
			internal int MLAAGLMMDFC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x22DE220", Offset = "0x22DD620", VA = "0x1822DE220")]
			internal void PDAJCGGHEFH(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xC75E40", Offset = "0xC75240", VA = "0x180C75E40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x22D9240", Offset = "0x22D8640", VA = "0x1822D9240")]
		public BIHKFJHGPEN(DLFOGDDKJHH HCHGEACFMON, CJNKFMHOJNH AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x22D9080", Offset = "0x22D8480", VA = "0x1822D9080", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class EOIOGCODNPC : KEMIEKNPFEC<GOKLCFKFBHE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class EDKLCNNCNEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public EOIOGCODNPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public EDKLCNNCNEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x22DD2A0", Offset = "0x22DC6A0", VA = "0x1822DD2A0")]
			internal int CEIMNLJHKHO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x22DD200", Offset = "0x22DC600", VA = "0x1822DD200")]
			internal void AHJDGHDABAB(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x22DE170", Offset = "0x22DD570", VA = "0x1822DE170")]
		public EOIOGCODNPC(DLFOGDDKJHH HCHGEACFMON, GOKLCFKFBHE HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x22DDF30", Offset = "0x22DD330", VA = "0x1822DDF30", Slot = "128")]
		protected override void COIEABDHGAB(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private sealed class GCEEKPKEHDB : BDEHOBDKNOL<LMFAJJMADEM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9B7990", Offset = "0x9B6D90", VA = "0x1809B7990", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x22DF680", Offset = "0x22DEA80", VA = "0x1822DF680")]
		public GCEEKPKEHDB(DLFOGDDKJHH HCHGEACFMON, LMFAJJMADEM AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class PPNBCADMCNI : BDEHOBDKNOL<MNPFGMPECGB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class GDAPMNICPJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public PPNBCADMCNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public MNBPGAMAPPH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public GDAPMNICPJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x22E91C0", Offset = "0x22E85C0", VA = "0x1822E91C0")]
			internal bool MLAAGLMMDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x22E9C80", Offset = "0x22E9080", VA = "0x1822E9C80")]
			internal void PDAJCGGHEFH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x22E6AF0", Offset = "0x22E5EF0", VA = "0x1822E6AF0")]
			internal bool EHPJBOIINIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x22DF790", Offset = "0x22DEB90", VA = "0x1822DF790")]
			internal bool ADNGHCOIDNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x22E70B0", Offset = "0x22E64B0", VA = "0x1822E70B0")]
			internal void GBINDMDKDFN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x22E9AA0", Offset = "0x22E8EA0", VA = "0x1822E9AA0")]
			internal bool OOIBEPDENDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x22E88C0", Offset = "0x22E7CC0", VA = "0x1822E88C0")]
			internal bool KNCPAOLMPFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x22E9270", Offset = "0x22E8670", VA = "0x1822E9270")]
			internal void MMPLMKBLAAC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x22E67F0", Offset = "0x22E5BF0", VA = "0x1822E67F0")]
			internal bool DDPAKKLDJFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x22DFE50", Offset = "0x22DF250", VA = "0x1822DFE50")]
			internal bool BPIPFDGPKJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x22E7890", Offset = "0x22E6C90", VA = "0x1822E7890")]
			internal void HFNDPLAEPNA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x22E7AC0", Offset = "0x22E6EC0", VA = "0x1822E7AC0")]
			internal bool HNOHBNNPHHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x22E6E30", Offset = "0x22E6230", VA = "0x1822E6E30")]
			internal bool FIKNJNBOBLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x22E7B60", Offset = "0x22E6F60", VA = "0x1822E7B60")]
			internal bool IFNKADNMCIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x22E7F40", Offset = "0x22E7340", VA = "0x1822E7F40")]
			internal bool JBKJHMHLMNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x22DFEF0", Offset = "0x22DF2F0", VA = "0x1822DFEF0")]
			internal bool CBFECAGOPDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x22E6530", Offset = "0x22E5930", VA = "0x1822E6530")]
			internal bool CMNGBECAIJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x22DFFE0", Offset = "0x22DF3E0", VA = "0x1822DFFE0")]
			internal bool CCLAPGAMPAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x22E8AB0", Offset = "0x22E7EB0", VA = "0x1822E8AB0")]
			internal bool LJACMFMLGDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x22DF930", Offset = "0x22DED30", VA = "0x1822DF930")]
			internal bool AMNPHKFOEMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x22E6B40", Offset = "0x22E5F40", VA = "0x1822E6B40")]
			internal void EJAHODDPPNO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x22E83B0", Offset = "0x22E77B0", VA = "0x1822E83B0")]
			internal bool JKFCFFNOEKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x22E6490", Offset = "0x22E5890", VA = "0x1822E6490")]
			internal bool CLDNLFACDJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x22E8F40", Offset = "0x22E8340", VA = "0x1822E8F40")]
			internal bool MECJHDIOAEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x22E8780", Offset = "0x22E7B80", VA = "0x1822E8780")]
			internal bool KLBGGAPDGJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x22E8360", Offset = "0x22E7760", VA = "0x1822E8360")]
			internal bool JKAKAHEKGCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x22E8590", Offset = "0x22E7990", VA = "0x1822E8590")]
			internal bool JPKFOBKLEDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x22E6BA0", Offset = "0x22E5FA0", VA = "0x1822E6BA0")]
			internal bool EPFIIAEOOIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x22E73A0", Offset = "0x22E67A0", VA = "0x1822E73A0")]
			internal bool GIKLPCNGEJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x22DFA20", Offset = "0x22DEE20", VA = "0x1822DFA20")]
			internal void AOPDFFNEPEL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x22E9BE0", Offset = "0x22E8FE0", VA = "0x1822E9BE0")]
			internal bool PAHPFLGEFNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x22E8C60", Offset = "0x22E8060", VA = "0x1822E8C60")]
			internal bool LNDJDFLLCFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x22E85E0", Offset = "0x22E79E0", VA = "0x1822E85E0")]
			internal void KBOEFBLFGLO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x22E9F50", Offset = "0x22E9350", VA = "0x1822E9F50")]
			internal bool PLINMGOINEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x22E03F0", Offset = "0x22DF7F0", VA = "0x1822E03F0")]
			internal bool CIKIPNCGMOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x22E81A0", Offset = "0x22E75A0", VA = "0x1822E81A0")]
			internal void JGJOFKGOBMI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x22E0490", Offset = "0x22DF890", VA = "0x1822E0490")]
			internal List<OOCKPHMFLHP> CKJAIIBNGIM(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x22E90D0", Offset = "0x22E84D0", VA = "0x1822E90D0")]
			internal bool MHFJOFKAOHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x22E96A0", Offset = "0x22E8AA0", VA = "0x1822E96A0")]
			internal int NNCMAFDPEBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x22E89B0", Offset = "0x22E7DB0", VA = "0x1822E89B0")]
			internal void LDIBJFNILCH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x22E6950", Offset = "0x22E5D50", VA = "0x1822E6950")]
			internal bool DNOCKOGGODC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x22E9500", Offset = "0x22E8900", VA = "0x1822E9500")]
			internal bool NEMFKGKJFOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x22DFF40", Offset = "0x22DF340", VA = "0x1822DFF40")]
			internal bool CBGGLLLLEEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x22E9410", Offset = "0x22E8810", VA = "0x1822E9410")]
			internal int NBGDMHJGEOH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x22E75F0", Offset = "0x22E69F0", VA = "0x1822E75F0")]
			internal void GOJGHMMBELH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x22E8D10", Offset = "0x22E8110", VA = "0x1822E8D10")]
			internal bool LOMELJIAMGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x22E8EF0", Offset = "0x22E82F0", VA = "0x1822E8EF0")]
			internal bool MDNIPFBEDHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x22E7250", Offset = "0x22E6650", VA = "0x1822E7250")]
			internal bool GDDGAAJGICG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x22DFE00", Offset = "0x22DF200", VA = "0x1822DFE00")]
			internal bool BOIMAGLBOBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x22E8E50", Offset = "0x22E8250", VA = "0x1822E8E50")]
			internal bool MBPPJGHNHAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x22E8870", Offset = "0x22E7C70", VA = "0x1822E8870")]
			internal bool KMOAFKKFOFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x22E8E00", Offset = "0x22E8200", VA = "0x1822E8E00")]
			internal string MAOMIJEODOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x22E9D30", Offset = "0x22E9130", VA = "0x1822E9D30")]
			internal void PFACFPHOANB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x22E8FF0", Offset = "0x22E83F0", VA = "0x1822E8FF0")]
			internal int MFHJADBEHKG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x22E8140", Offset = "0x22E7540", VA = "0x1822E8140")]
			internal void JGGPMGJCIME(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x22E9A00", Offset = "0x22E8E00", VA = "0x1822E9A00")]
			internal bool ONALAKFAMHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x22DF740", Offset = "0x22DEB40", VA = "0x1822DF740")]
			internal bool ACLBMMEANAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x22E92D0", Offset = "0x22E86D0", VA = "0x1822E92D0")]
			internal bool MNAFKAPGKJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x22E9850", Offset = "0x22E8C50", VA = "0x1822E9850")]
			internal float OEHNEEFAKGL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x22E7C70", Offset = "0x22E7070", VA = "0x1822E7C70")]
			internal void IJOALNABALD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x22E9370", Offset = "0x22E8770", VA = "0x1822E9370")]
			internal bool MNMEIBHDKAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x22E9550", Offset = "0x22E8950", VA = "0x1822E9550")]
			internal bool NGFGFMMGKDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x22E9120", Offset = "0x22E8520", VA = "0x1822E9120")]
			internal bool MJJFLCMKCIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x22E8640", Offset = "0x22E7A40", VA = "0x1822E8640")]
			internal bool KCFANBHODJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x22DFF90", Offset = "0x22DF390", VA = "0x1822DFF90")]
			internal bool CCKGNIFFNEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x22DF980", Offset = "0x22DED80", VA = "0x1822DF980")]
			internal bool ANDPMDLHGFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x22E9FA0", Offset = "0x22E93A0", VA = "0x1822E9FA0")]
			internal void PMGMCMKEAEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x22E77F0", Offset = "0x22E6BF0", VA = "0x1822E77F0")]
			internal string HEOKACIJEDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x22E6670", Offset = "0x22E5A70", VA = "0x1822E6670")]
			internal void DBPMINHLLAP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x22DFB30", Offset = "0x22DEF30", VA = "0x1822DFB30")]
			internal bool BDIFJFJMMBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x22E7CD0", Offset = "0x22E70D0", VA = "0x1822E7CD0")]
			internal bool ILEEEKBCJME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x22E64E0", Offset = "0x22E58E0", VA = "0x1822E64E0")]
			internal bool CMBELFLAFEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x22E0080", Offset = "0x22DF480", VA = "0x1822E0080")]
			internal void CFIGCNOIDAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x22E8C10", Offset = "0x22E8010", VA = "0x1822E8C10")]
			internal bool LMGKPOIPLFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x22E7350", Offset = "0x22E6750", VA = "0x1822E7350")]
			internal bool GHCBMAIJLNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x22E8030", Offset = "0x22E7430", VA = "0x1822E8030")]
			internal bool JDMKGBAPPDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x22E9600", Offset = "0x22E8A00", VA = "0x1822E9600")]
			internal bool NIMMBNMNAHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x22E8CB0", Offset = "0x22E80B0", VA = "0x1822E8CB0")]
			internal void LNIDBPDDCPA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x22E7060", Offset = "0x22E6460", VA = "0x1822E7060")]
			internal bool GAFGJPDNCBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x22E7A70", Offset = "0x22E6E70", VA = "0x1822E7A70")]
			internal bool HMIJJAALOIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x22E7500", Offset = "0x22E6900", VA = "0x1822E7500")]
			internal bool GMDEOMOCBBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x22E7FE0", Offset = "0x22E73E0", VA = "0x1822E7FE0")]
			internal bool JDCMKPKHBMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x22E69F0", Offset = "0x22E5DF0", VA = "0x1822E69F0")]
			internal void DODIKCMMDHH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x22E69A0", Offset = "0x22E5DA0", VA = "0x1822E69A0")]
			internal bool DOCDHCFBHLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x22E8540", Offset = "0x22E7940", VA = "0x1822E8540")]
			internal bool JOIANBCMNDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x22E7EF0", Offset = "0x22E72F0", VA = "0x1822E7EF0")]
			internal bool INFFCOPNPOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x22E94B0", Offset = "0x22E88B0", VA = "0x1822E94B0")]
			internal bool NDKINFFFAGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x22E9E90", Offset = "0x22E9290", VA = "0x1822E9E90")]
			internal object PKAEAFPGGHK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x22E9040", Offset = "0x22E8440", VA = "0x1822E9040")]
			internal void MGJDPHLEGOA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x22DF7E0", Offset = "0x22DEBE0", VA = "0x1822DF7E0")]
			internal bool AELLKKCGDND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x22E9460", Offset = "0x22E8860", VA = "0x1822E9460")]
			internal bool NBIJNPPBCLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x22DF8E0", Offset = "0x22DECE0", VA = "0x1822DF8E0")]
			internal int ALINLMGOPBM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x22E72F0", Offset = "0x22E66F0", VA = "0x1822E72F0")]
			internal void GDGOEFHDJFA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x22E6CD0", Offset = "0x22E60D0", VA = "0x1822E6CD0")]
			internal bool FBECAJKKCNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x22DFB80", Offset = "0x22DEF80", VA = "0x1822DFB80")]
			internal bool BEJKCNNFDMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x22E97B0", Offset = "0x22E8BB0", VA = "0x1822E97B0")]
			internal int OBDIHAEONPD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x22E9210", Offset = "0x22E8610", VA = "0x1822E9210")]
			internal void MMINNOOINDP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x22E8910", Offset = "0x22E7D10", VA = "0x1822E8910")]
			internal bool KNJMIMMDPHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x22DFC70", Offset = "0x22DF070", VA = "0x1822DFC70")]
			internal bool BIBCFCNLNAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x22E9B40", Offset = "0x22E8F40", VA = "0x1822E9B40")]
			internal bool OPJBJLIBDLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x22E86E0", Offset = "0x22E7AE0", VA = "0x1822E86E0")]
			internal int KDCKEDIKDFE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x22E95A0", Offset = "0x22E89A0", VA = "0x1822E95A0")]
			internal void NHEPDBAPDJL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x22E7B10", Offset = "0x22E6F10", VA = "0x1822E7B10")]
			internal bool IEKDLEKLIGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x22E9C30", Offset = "0x22E9030", VA = "0x1822E9C30")]
			internal bool PAIAHHDNKPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x22E8A60", Offset = "0x22E7E60", VA = "0x1822E8A60")]
			internal bool LHLEAMEJMPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x22E8BA0", Offset = "0x22E7FA0", VA = "0x1822E8BA0")]
			internal object LJMJFBCDDPA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x22E6C40", Offset = "0x22E6040", VA = "0x1822E6C40")]
			internal void FAOCIEDLKNN(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x22E7E30", Offset = "0x22E7230", VA = "0x1822E7E30")]
			internal bool IMOBICACGAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x22E9320", Offset = "0x22E8720", VA = "0x1822E9320")]
			internal bool MNCAMAPEIAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x22E6840", Offset = "0x22E5C40", VA = "0x1822E6840")]
			internal object DIPJPPGBPDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x22DFD70", Offset = "0x22DF170", VA = "0x1822DFD70")]
			internal void BMIJHENOAHA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x22E66E0", Offset = "0x22E5AE0", VA = "0x1822E66E0")]
			internal bool DCHHOODODCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x22E93C0", Offset = "0x22E87C0", VA = "0x1822E93C0")]
			internal int NABDFILAILK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x22E8F90", Offset = "0x22E8390", VA = "0x1822E8F90")]
			internal void MFGNLKDCOPN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x22E75A0", Offset = "0x22E69A0", VA = "0x1822E75A0")]
			internal bool GOHIACKJNAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x22E9A50", Offset = "0x22E8E50", VA = "0x1822E9A50")]
			internal bool ONLHCONFBAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x22E0330", Offset = "0x22DF730", VA = "0x1822E0330")]
			internal bool CIDAPFGBMPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x22E7F90", Offset = "0x22E7390", VA = "0x1822E7F90")]
			internal int JCOFIAJEKNL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x22DFCC0", Offset = "0x22DF0C0", VA = "0x1822DFCC0")]
			internal void BIBDFBHHIAD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x22E6E80", Offset = "0x22E6280", VA = "0x1822E6E80")]
			internal bool FJCBIAOCPFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x22E6ED0", Offset = "0x22E62D0", VA = "0x1822E6ED0")]
			internal bool FJNLFPEGNNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x22E8250", Offset = "0x22E7650", VA = "0x1822E8250")]
			internal bool JHPFFCJEIBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x22E71B0", Offset = "0x22E65B0", VA = "0x1822E71B0")]
			internal float GCDHHNBOEJP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x22EA350", Offset = "0x22E9750", VA = "0x1822EA350")]
			internal void PPDDBGMNOPB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x22E8EA0", Offset = "0x22E82A0", VA = "0x1822E8EA0")]
			internal bool MCKFIIAOMIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x22E6FC0", Offset = "0x22E63C0", VA = "0x1822E6FC0")]
			internal bool FPGKGCFMHLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x22E6D90", Offset = "0x22E6190", VA = "0x1822E6D90")]
			internal bool FEHILHGDIFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x22E7D90", Offset = "0x22E7190", VA = "0x1822E7D90")]
			internal float IMGJMBBKPNG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x22E76A0", Offset = "0x22E6AA0", VA = "0x1822E76A0")]
			internal void HABPHKEIGIL(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x22E77A0", Offset = "0x22E6BA0", VA = "0x1822E77A0")]
			internal bool HDBCFGEBENH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x22E8450", Offset = "0x22E7850", VA = "0x1822E8450")]
			internal bool JLCLJNNDAED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x22E6580", Offset = "0x22E5980", VA = "0x1822E6580")]
			internal string COBDNOFMJJG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x22E7A00", Offset = "0x22E6E00", VA = "0x1822E7A00")]
			internal void HLMMDIPFMCN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x22E9960", Offset = "0x22E8D60", VA = "0x1822E9960")]
			internal bool OLMHHKCJDBO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x22E8B50", Offset = "0x22E7F50", VA = "0x1822E8B50")]
			internal bool LJJDLKBOPKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x22E8D60", Offset = "0x22E8160", VA = "0x1822E8D60")]
			internal bool LPJLEPGNLMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x22E7840", Offset = "0x22E6C40", VA = "0x1822E7840")]
			internal bool HFKPHGICMFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x22E78F0", Offset = "0x22E6CF0", VA = "0x1822E78F0")]
			internal string HGBOPKHMBLL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x22E82A0", Offset = "0x22E76A0", VA = "0x1822E82A0")]
			internal void JIOBLNGJBHL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x22DFEA0", Offset = "0x22DF2A0", VA = "0x1822DFEA0")]
			internal bool CALFJFODAEO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x22E7750", Offset = "0x22E6B50", VA = "0x1822E7750")]
			internal bool HCBMCBOPIAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x22E9CE0", Offset = "0x22E90E0", VA = "0x1822E9CE0")]
			internal bool PDNDBGIABKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x22E9DA0", Offset = "0x22E91A0", VA = "0x1822E9DA0")]
			internal bool PHBBLNIIHAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x22DF9D0", Offset = "0x22DEDD0", VA = "0x1822DF9D0")]
			internal string AOCGCPAAIKM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x22E7C00", Offset = "0x22E7000", VA = "0x1822E7C00")]
			internal void IHFBNNDJPNC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x22E96F0", Offset = "0x22E8AF0", VA = "0x1822E96F0")]
			internal bool NNGJEJOICGB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x22DF890", Offset = "0x22DEC90", VA = "0x1822DF890")]
			internal bool ALDIILIDCCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x22E6620", Offset = "0x22E5A20", VA = "0x1822E6620")]
			internal bool DAHEIGOMHOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x22E79B0", Offset = "0x22E6DB0", VA = "0x1822E79B0")]
			internal bool HLEOMCABLIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x22E6F70", Offset = "0x22E6370", VA = "0x1822E6F70")]
			internal string FOPOOELJDKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x22E0380", Offset = "0x22DF780", VA = "0x1822E0380")]
			internal void CIDCKGOFFMC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x22E8400", Offset = "0x22E7800", VA = "0x1822E8400")]
			internal bool JKPFKFIKLJG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x22E6F20", Offset = "0x22E6320", VA = "0x1822E6F20")]
			internal bool FONJCOMKBJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x22E9650", Offset = "0x22E8A50", VA = "0x1822E9650")]
			internal bool NLNALEPKMLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x22E98A0", Offset = "0x22E8CA0", VA = "0x1822E98A0")]
			internal bool OJCOCMEDPEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x22E8960", Offset = "0x22E7D60", VA = "0x1822E8960")]
			internal string LCBFOMKKOAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x22E6730", Offset = "0x22E5B30", VA = "0x1822E6730")]
			internal void DCMBHCFFAKO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x22E8A10", Offset = "0x22E7E10", VA = "0x1822E8A10")]
			internal bool LGNPEAHFAHO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x22E7DE0", Offset = "0x22E71E0", VA = "0x1822E7DE0")]
			internal bool IMMOPGAGFLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x22E8B00", Offset = "0x22E7F00", VA = "0x1822E8B00")]
			internal bool LJDMGLAEHLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x22E7BB0", Offset = "0x22E6FB0", VA = "0x1822E7BB0")]
			internal bool IHCHMPIGIJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x22E99B0", Offset = "0x22E8DB0", VA = "0x1822E99B0")]
			internal string OMBKKBEHPFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x22E7E80", Offset = "0x22E7280", VA = "0x1822E7E80")]
			internal void INAECFEKEIO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x22E80F0", Offset = "0x22E74F0", VA = "0x1822E80F0")]
			internal bool JFECFJOKDIP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x22E7110", Offset = "0x22E6510", VA = "0x1822E7110")]
			internal bool GBNEBPJPEEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x22E7010", Offset = "0x22E6410", VA = "0x1822E7010")]
			internal bool FPILCMLOEFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x22E0440", Offset = "0x22DF840", VA = "0x1822E0440")]
			internal bool CJMNJEKIIFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x22E9DF0", Offset = "0x22E91F0", VA = "0x1822E9DF0")]
			internal string PIEMPNHDMJH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x22E7940", Offset = "0x22E6D40", VA = "0x1822E7940")]
			internal void HIHFOHCMMCC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x22E8730", Offset = "0x22E7B30", VA = "0x1822E8730")]
			internal bool KFJGCMFLNIE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x22DFD20", Offset = "0x22DF120", VA = "0x1822DFD20")]
			internal bool BLMNAAJEEEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x22DFBD0", Offset = "0x22DEFD0", VA = "0x1822DFBD0")]
			internal bool BGBCELJBLDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x22DFA80", Offset = "0x22DEE80", VA = "0x1822DFA80")]
			internal bool BCICADHCPNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x22E8DB0", Offset = "0x22E81B0", VA = "0x1822E8DB0")]
			internal string MAAGBPLDHGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x22E98F0", Offset = "0x22E8CF0", VA = "0x1822E98F0")]
			internal void OJJHKAKFLPI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x22DF6F0", Offset = "0x22DEAF0", VA = "0x1822DF6F0")]
			internal bool ABJGGPCOEFN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x22E6DE0", Offset = "0x22E61E0", VA = "0x1822E6DE0")]
			internal bool FEJBHGAPCKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x22E8200", Offset = "0x22E7600", VA = "0x1822E8200")]
			internal bool JHMPKHKIICO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x22E68B0", Offset = "0x22E5CB0", VA = "0x1822E68B0")]
			internal bool DJIFNOBKNOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x22E9F00", Offset = "0x22E9300", VA = "0x1822E9F00")]
			internal string PKJCJNHKAEF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x22E9740", Offset = "0x22E8B40", VA = "0x1822E9740")]
			internal void NPEPJFBMGMP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x22E72A0", Offset = "0x22E66A0", VA = "0x1822E72A0")]
			internal bool GDDOMAIAOEO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x22E6BF0", Offset = "0x22E5FF0", VA = "0x1822E6BF0")]
			internal bool FACLPHCFKBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x22E6A50", Offset = "0x22E5E50", VA = "0x1822E6A50")]
			internal bool ECCJCIEAGKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x22E9170", Offset = "0x22E8570", VA = "0x1822E9170")]
			internal bool MJMNOBAFGHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x22E87D0", Offset = "0x22E7BD0", VA = "0x1822E87D0")]
			internal string KLDFDJMAAOO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x22E6D20", Offset = "0x22E6120", VA = "0x1822E6D20")]
			internal void FCAJKLJPCOL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x22E7550", Offset = "0x22E6950", VA = "0x1822E7550")]
			internal bool GNIDKECFMFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x22E8820", Offset = "0x22E7C20", VA = "0x1822E8820")]
			internal bool KMGCEOCFFJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x22E9AF0", Offset = "0x22E8EF0", VA = "0x1822E9AF0")]
			internal bool OPHGMJOOKPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x22E84F0", Offset = "0x22E78F0", VA = "0x1822E84F0")]
			internal string JMPBFHINDLC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x22E7440", Offset = "0x22E6840", VA = "0x1822E7440")]
			internal void GJJHHJIHBHJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x22E9800", Offset = "0x22E8C00", VA = "0x1822E9800")]
			internal bool ODGJCAADJOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x22E7650", Offset = "0x22E6A50", VA = "0x1822E7650")]
			internal bool GPCBKGHOOEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x22E7200", Offset = "0x22E6600", VA = "0x1822E7200")]
			internal bool GCFCONBGFND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x22DFC20", Offset = "0x22DF020", VA = "0x1822DFC20")]
			internal string BGLDDAGCEAN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x22E7D20", Offset = "0x22E7120", VA = "0x1822E7D20")]
			internal void ILGMBOAKBDL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x22E84A0", Offset = "0x22E78A0", VA = "0x1822E84A0")]
			internal bool JLIAONEEGAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x22E6900", Offset = "0x22E5D00", VA = "0x1822E6900")]
			internal bool DLIFDLLHFOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x22E6AA0", Offset = "0x22E5EA0", VA = "0x1822E6AA0")]
			internal bool EFPGJKICKGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x22E8690", Offset = "0x22E7A90", VA = "0x1822E8690")]
			internal string KCPHLDNMNDA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x22E8080", Offset = "0x22E7480", VA = "0x1822E8080")]
			internal void JDNIDMCEJJI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x22E0030", Offset = "0x22DF430", VA = "0x1822E0030")]
			internal bool CELFADOFLIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x22E65D0", Offset = "0x22E59D0", VA = "0x1822E65D0")]
			internal bool CPEDNEFENJP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x22E9B90", Offset = "0x22E8F90", VA = "0x1822E9B90")]
			internal float PACDKMDAPCP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x22DF830", Offset = "0x22DEC30", VA = "0x1822DF830")]
			internal void AFEPECIOJND(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x22E67A0", Offset = "0x22E5BA0", VA = "0x1822E67A0")]
			internal bool DDABEFBDJDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x22E74B0", Offset = "0x22E68B0", VA = "0x1822E74B0")]
			internal bool GMCPKHCNLAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x22E73F0", Offset = "0x22E67F0", VA = "0x1822E73F0")]
			internal bool GIMBHNHCBHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x22E7160", Offset = "0x22E6560", VA = "0x1822E7160")]
			internal int GBNKPKHCNKH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x22DFAD0", Offset = "0x22DEED0", VA = "0x1822DFAD0")]
			internal void BCIKOADLGFB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x22E8310", Offset = "0x22E7710", VA = "0x1822E8310")]
			internal bool JJNGDFHBCIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x22E7700", Offset = "0x22E6B00", VA = "0x1822E7700")]
			internal bool HACHLBCLOFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x22E9E40", Offset = "0x22E9240", VA = "0x1822E9E40")]
			internal bool PJEJDIDFILH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class ACAPKPCMGMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public GDAPMNICPJE CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public ACAPKPCMGMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x22D74E0", Offset = "0x22D68E0", VA = "0x1822D74E0")]
			internal void EOMHBLCOHGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class AMDGILMHGDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public AMDGILMHGDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x22F5E80", Offset = "0x22F5280", VA = "0x1822F5E80")]
			internal bool LPEONLGFHHC(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly OABHHDJEDJD BHMECJFFMOP;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x22F4AA0", Offset = "0x22F3EA0", VA = "0x1822F4AA0")]
		public PPNBCADMCNI(DLFOGDDKJHH HCHGEACFMON, MNPFGMPECGB AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x22F2D70", Offset = "0x22F2170", VA = "0x1822F2D70", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class GDOJCDFHEAG : BDEHOBDKNOL<CAMEGKCEIIM>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class OBMINAOLAPK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public OBMINAOLAPK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2310700", Offset = "0x230FB00", VA = "0x182310700", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public GDOJCDFHEAG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public OBMINAOLAPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x230DD70", Offset = "0x230D170", VA = "0x18230DD70")]
			internal string MLAAGLMMDFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x230DEA0", Offset = "0x230D2A0", VA = "0x18230DEA0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void PDAJCGGHEFH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x230DE50", Offset = "0x230D250", VA = "0x18230DE50")]
			internal int PBMMAPMNPOP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x230DDC0", Offset = "0x230D1C0", VA = "0x18230DDC0")]
			internal void PBAIAHOJBNK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xC75E40", Offset = "0xC75240", VA = "0x180C75E40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x22FA0F0", Offset = "0x22F94F0", VA = "0x1822FA0F0")]
		public GDOJCDFHEAG(DLFOGDDKJHH HCHGEACFMON, CAMEGKCEIIM HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x22F9DA0", Offset = "0x22F91A0", VA = "0x1822F9DA0", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NGKJCEHLJJM : BDEHOBDKNOL<PFADMDHABLK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class CNPCIPFEJME
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public CNPCIPFEJME <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2310A10", Offset = "0x230FE10", VA = "0x182310A10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000072")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				public CNPCIPFEJME <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2310D50", Offset = "0x2310150", VA = "0x182310D50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public NGKJCEHLJJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public CNPCIPFEJME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x22F8270", Offset = "0x22F7670", VA = "0x1822F8270")]
			internal string MLAAGLMMDFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x22F8550", Offset = "0x22F7950", VA = "0x1822F8550")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void PDAJCGGHEFH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x22F8500", Offset = "0x22F7900", VA = "0x1822F8500")]
			internal int PBMMAPMNPOP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x22F8470", Offset = "0x22F7870", VA = "0x1822F8470")]
			internal void PBAIAHOJBNK(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x22F8120", Offset = "0x22F7520", VA = "0x1822F8120")]
			internal string EHPJBOIINIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x22F7EF0", Offset = "0x22F72F0", VA = "0x1822F7EF0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void ADNGHCOIDNK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x22F8170", Offset = "0x22F7570", VA = "0x1822F8170")]
			internal bool GBINDMDKDFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x22F8350", Offset = "0x22F7750", VA = "0x1822F8350")]
			internal void ONONMOPNFIE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", VA = "0x1822F7FC0")]
			internal bool CNKNOGJOKLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x22F83E0", Offset = "0x22F77E0", VA = "0x1822F83E0")]
			internal void OOIBEPDENDH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x22F81C0", Offset = "0x22F75C0", VA = "0x1822F81C0")]
			internal float KNCPAOLMPFJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x22F82C0", Offset = "0x22F76C0", VA = "0x1822F82C0")]
			internal void MMPLMKBLAAC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x22F8210", Offset = "0x22F7610", VA = "0x1822F8210")]
			internal int MKMEAEEKFOG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x22F8010", Offset = "0x22F7410", VA = "0x1822F8010")]
			internal void DAKLMKKGMAM(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x22F80B0", Offset = "0x22F74B0", VA = "0x1822F80B0")]
			internal bool DDPAKKLDJFH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xC75E40", Offset = "0xC75240", VA = "0x180C75E40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x230D690", Offset = "0x230CA90", VA = "0x18230D690")]
		public NGKJCEHLJJM(DLFOGDDKJHH HCHGEACFMON, PFADMDHABLK AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x230CC50", Offset = "0x230C050", VA = "0x18230CC50", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class EJGCGNKBHOH : BDEHOBDKNOL<KNHFLBOJNEO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class JEODADBCAOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public EJGCGNKBHOH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public JEODADBCAOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x22FCD80", Offset = "0x22FC180", VA = "0x1822FCD80")]
			internal Dictionary<string, CKGLPPPLONC> MLAAGLMMDFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x22FCFC0", Offset = "0x22FC3C0", VA = "0x1822FCFC0")]
			internal int PDAJCGGHEFH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x22FCEA0", Offset = "0x22FC2A0", VA = "0x1822FCEA0")]
			internal void PBMMAPMNPOP(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x22FCE20", Offset = "0x22FC220", VA = "0x1822FCE20")]
			internal bool PBAIAHOJBNK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xC75E40", Offset = "0xC75240", VA = "0x180C75E40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x22F97F0", Offset = "0x22F8BF0", VA = "0x1822F97F0")]
		public EJGCGNKBHOH(DLFOGDDKJHH HCHGEACFMON, KNHFLBOJNEO HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x22F9520", Offset = "0x22F8920", VA = "0x1822F9520", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class HIKOKLBGNCD : BDEHOBDKNOL<MKMDPFODLHO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class OODIIBOIJCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public HIKOKLBGNCD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public OODIIBOIJCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x230E660", Offset = "0x230DA60", VA = "0x18230E660")]
			internal void MLAAGLMMDFC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xC75E40", Offset = "0xC75240", VA = "0x180C75E40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x22FB6A0", Offset = "0x22FAAA0", VA = "0x1822FB6A0")]
		public HIKOKLBGNCD(DLFOGDDKJHH HCHGEACFMON, MKMDPFODLHO HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x22FB520", Offset = "0x22FA920", VA = "0x1822FB520", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class HKJNIKHKFML<TNode> : PHPAMGEBMPK<TNode> where TNode : notnull, FDHPBBJFNMG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool CBMPEAAMJAK
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override AGAIDCIGFJL? AEOCDJJMNIG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x426C070", Offset = "0x426B470", VA = "0x18426C070", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool EOOGMEPALOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x426C130", Offset = "0x426B530", VA = "0x18426C130", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9AD710", Offset = "0x9ACB10", VA = "0x1809AD710", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x426C0F0", Offset = "0x426B4F0", VA = "0x18426C0F0")]
		public HKJNIKHKFML(DLFOGDDKJHH HCHGEACFMON, TNode AJLPJFOPFCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class MAGNEOLKMKF : HKJNIKHKFML<GNDINNAHBAA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class HHMKHHEBCKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public MAGNEOLKMKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public HHMKHHEBCKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x22FB300", Offset = "0x22FA700", VA = "0x1822FB300")]
			internal object MLAAGLMMDFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x22FB450", Offset = "0x22FA850", VA = "0x1822FB450")]
			internal void PDAJCGGHEFH(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x22FB370", Offset = "0x22FA770", VA = "0x1822FB370")]
			internal void PBMMAPMNPOP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static object[]? IIPGJAPKOFA;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2305AE0", Offset = "0x2304EE0", VA = "0x182305AE0")]
		public MAGNEOLKMKF(DLFOGDDKJHH HCHGEACFMON, GNDINNAHBAA AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2305540", Offset = "0x2304940", VA = "0x182305540", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class CEJMHEFIPJK : BDEHOBDKNOL<AMEJBAJHEBD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xC1E230", Offset = "0xC1D630", VA = "0x180C1E230", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x22F67A0", Offset = "0x22F5BA0", VA = "0x1822F67A0")]
		public CEJMHEFIPJK(DLFOGDDKJHH HCHGEACFMON, AMEJBAJHEBD AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class DDKNAHEHEEM : BDEHOBDKNOL<GPNJELFGKIG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x9A6540", Offset = "0x9A5940", VA = "0x1809A6540", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x22F8620", Offset = "0x22F7A20", VA = "0x1822F8620")]
		public DDKNAHEHEEM(DLFOGDDKJHH HCHGEACFMON, GPNJELFGKIG AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "114")]
		protected override bool OHJHNMEMNCA(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class AFKFLPDOJMF : BDEHOBDKNOL<EGBHPBKCMGN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x92C8E0", Offset = "0x92BCE0", VA = "0x18092C8E0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool EJJGDDJLMBL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x22F5E30", Offset = "0x22F5230", VA = "0x1822F5E30", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override bool EGHFCBHFOMK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x22F5DC0", Offset = "0x22F51C0", VA = "0x1822F5DC0")]
		public AFKFLPDOJMF(DLFOGDDKJHH HCHGEACFMON, EGBHPBKCMGN AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class PNHKFGAFLGE : BDEHOBDKNOL<CNOPIAKAJGN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x935560", Offset = "0x934960", VA = "0x180935560", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool EJJGDDJLMBL
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x230FEF0", Offset = "0x230F2F0", VA = "0x18230FEF0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool EGHFCBHFOMK
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x230FE80", Offset = "0x230F280", VA = "0x18230FE80")]
		public PNHKFGAFLGE(DLFOGDDKJHH HCHGEACFMON, CNOPIAKAJGN AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class IONIIBKNDPG : KEMIEKNPFEC<IOHAFPOFNKH>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class JEDNODHLHGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public IONIIBKNDPG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public JEDNODHLHGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x22FCD00", Offset = "0x22FC100", VA = "0x1822FCD00")]
			internal float CEIMNLJHKHO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x22FCC60", Offset = "0x22FC060", VA = "0x1822FCC60")]
			internal void AHJDGHDABAB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x22FC470", Offset = "0x22FB870", VA = "0x1822FC470")]
		public IONIIBKNDPG(DLFOGDDKJHH HCHGEACFMON, IOHAFPOFNKH HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x22FC1F0", Offset = "0x22FB5F0", VA = "0x1822FC1F0", Slot = "128")]
		protected override void COIEABDHGAB(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class DIMBLMIGDOK : BDEHOBDKNOL<JGIIGIJLFMI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class BBFPDMFGMOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public DIMBLMIGDOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public BBFPDMFGMOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x22F5F00", Offset = "0x22F5300", VA = "0x1822F5F00")]
			internal bool MLAAGLMMDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x22F5F50", Offset = "0x22F5350", VA = "0x1822F5F50")]
			internal void PDAJCGGHEFH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x22F8DF0", Offset = "0x22F81F0", VA = "0x1822F8DF0")]
		public DIMBLMIGDOK(DLFOGDDKJHH HCHGEACFMON, JGIIGIJLFMI HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x22F8B50", Offset = "0x22F7F50", VA = "0x1822F8B50", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class PKCCHCABLLI : BDEHOBDKNOL<ILOMKGNDIMB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class JDHMADHKCFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public PKCCHCABLLI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public JDHMADHKCFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x22FC6B0", Offset = "0x22FBAB0", VA = "0x1822FC6B0")]
			internal object MLAAGLMMDFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x22FC7E0", Offset = "0x22FBBE0", VA = "0x1822FC7E0")]
			internal bool ONONMOPNFIE(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x22FCA10", Offset = "0x22FBE10", VA = "0x1822FCA10")]
			internal void PDAJCGGHEFH(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x22FC8B0", Offset = "0x22FBCB0", VA = "0x1822FC8B0")]
			internal string PBMMAPMNPOP(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x22FC860", Offset = "0x22FBC60", VA = "0x1822FC860")]
			internal IReadOnlyList<object> PBAIAHOJBNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x22FC520", Offset = "0x22FB920", VA = "0x1822FC520")]
			internal bool EHPJBOIINIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x22FC4D0", Offset = "0x22FB8D0", VA = "0x1822FC4D0")]
			internal bool ADNGHCOIDNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x22FC590", Offset = "0x22FB990", VA = "0x1822FC590")]
			internal void GBINDMDKDFN(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x230FD30", Offset = "0x230F130", VA = "0x18230FD30")]
		public PKCCHCABLLI(DLFOGDDKJHH HCHGEACFMON, ILOMKGNDIMB HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x230F530", Offset = "0x230E930", VA = "0x18230F530", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class CLKBIBBIABC : AOOOAPLDGHO<MIEGHPJJFIB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x9AFC50", Offset = "0x9AF050", VA = "0x1809AFC50", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x22F7E90", Offset = "0x22F7290", VA = "0x1822F7E90")]
		public CLKBIBBIABC(DLFOGDDKJHH HCHGEACFMON, MIEGHPJJFIB AJLPJFOPFCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class OBDFKJNAGDL : KEMIEKNPFEC<JILPOAFMECM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class CLGBPDAIJGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public OBDFKJNAGDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public CLGBPDAIJGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x22F7E10", Offset = "0x22F7210", VA = "0x1822F7E10")]
			internal int CEIMNLJHKHO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x22F7D70", Offset = "0x22F7170", VA = "0x1822F7D70")]
			internal void AHJDGHDABAB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x230DD10", Offset = "0x230D110", VA = "0x18230DD10")]
		public OBDFKJNAGDL(DLFOGDDKJHH HCHGEACFMON, JILPOAFMECM HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x230DA80", Offset = "0x230CE80", VA = "0x18230DA80", Slot = "128")]
		protected override void COIEABDHGAB(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class GNGGEDKOICJ : BDEHOBDKNOL<CBJPCLHMCHH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class DHBLLLCJPOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public GNGGEDKOICJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public DHBLLLCJPOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x22F8A70", Offset = "0x22F7E70", VA = "0x1822F8A70")]
			internal bool MLAAGLMMDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x22F8AC0", Offset = "0x22F7EC0", VA = "0x1822F8AC0")]
			internal void PDAJCGGHEFH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x22FA3F0", Offset = "0x22F97F0", VA = "0x1822FA3F0")]
		public GNGGEDKOICJ(DLFOGDDKJHH HCHGEACFMON, CBJPCLHMCHH HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x22FA210", Offset = "0x22F9610", VA = "0x1822FA210", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class CHMIKPCKCNF : BDEHOBDKNOL<EODENHOLJNO>
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class EKCOOCHPCFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public CHMIKPCKCNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public EKCOOCHPCFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x22F9860", Offset = "0x22F8C60", VA = "0x1822F9860")]
			internal bool MLAAGLMMDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x22F98B0", Offset = "0x22F8CB0", VA = "0x1822F98B0")]
			internal void PDAJCGGHEFH(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x22F6A50", Offset = "0x22F5E50", VA = "0x1822F6A50")]
		public CHMIKPCKCNF(DLFOGDDKJHH HCHGEACFMON, EODENHOLJNO HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x22F6870", Offset = "0x22F5C70", VA = "0x1822F6870", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class FOMGLKJMNFD : BDEHOBDKNOL<IKCBDBHCABA>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class INFKNDKOPLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public FOMGLKJMNFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public INFKNDKOPLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x22FC110", Offset = "0x22FB510", VA = "0x1822FC110")]
			internal int MLAAGLMMDFC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x22FC160", Offset = "0x22FB560", VA = "0x1822FC160")]
			internal void PDAJCGGHEFH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x22F9C10", Offset = "0x22F9010", VA = "0x1822F9C10")]
		public FOMGLKJMNFD(DLFOGDDKJHH HCHGEACFMON, IKCBDBHCABA HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x22F99A0", Offset = "0x22F8DA0", VA = "0x1822F99A0", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public sealed class FNNEMHKHECC : LANBKAKBHDN<PCKMKELPLNE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override KGJJJCENCJI LNCKIBPLPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93DFD0", VA = "0x18093EBD0", Slot = "128")]
			get
			{
				return default(KGJJJCENCJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x22F9940", Offset = "0x22F8D40", VA = "0x1822F9940")]
		public FNNEMHKHECC(DLFOGDDKJHH HCHGEACFMON, PCKMKELPLNE HKNABNLJGOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class BCHBMALBDOG : BDEHOBDKNOL<FAKCDJHFJMO>
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x22F5D50", Offset = "0x22F5150", VA = "0x1822F5D50")]
		public BCHBMALBDOG(DLFOGDDKJHH HCHGEACFMON, FAKCDJHFJMO AJLPJFOPFCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public abstract class BDEHOBDKNOL<TNode> : OAIONGHIMFG, IDisposable where TNode : notnull, FAKCDJHFJMO
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class HALPOFJOAAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public BDEHOBDKNOL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public DLFOGDDKJHH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public HALPOFJOAAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x4207D60", Offset = "0x4207160", VA = "0x184207D60")]
			internal JMEGLHNNJLL OBENBHHNFCJ(OHODLOOFPKP portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct FPNLEBDFFNE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public BDEHOBDKNOL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x40BB0A0", Offset = "0x40BA4A0", VA = "0x1840BB0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct EGNANIIDEHI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public BDEHOBDKNOL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public NEIHENNLNMK? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public EMLOIPKJGKA? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x3CC5270", Offset = "0x3CC4670", VA = "0x183CC5270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x3CC5520", Offset = "0x3CC4920", VA = "0x183CC5520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class CKFLMIOBCJH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public CKFLMIOBCJH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A7")]
				[Cpp2IlInjected.Address(RVA = "0x39AB1B0", Offset = "0x39AA5B0", VA = "0x1839AB1B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A8")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public BDEHOBDKNOL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public MNBPGAMAPPH configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public CKFLMIOBCJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			internal string JGGOOHJNGEI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
			internal void BMKBBCBPHEA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x58FF330", Offset = "0x58FE730", VA = "0x1858FF330")]
			[AsyncStateMachine(typeof(BDEHOBDKNOL<>.CKFLMIOBCJH.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void IEBAKJJODPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class MLLEKLEJDBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public MLLEKLEJDBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x4A07CA0", Offset = "0x4A070A0", VA = "0x184A07CA0")]
			internal bool JJELJLPHJPH(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x4A07C90", Offset = "0x4A07090", VA = "0x184A07C90")]
			internal bool HDLJMMAFIOH(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct BDIHIMGMMHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public BDEHOBDKNOL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x53C5BD0", Offset = "0x53C4FD0", VA = "0x1853C5BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x53C5F60", Offset = "0x53C5360", VA = "0x1853C5F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private readonly DLFOGDDKJHH DMPLBKKFJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly bool PEMGDDCEAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private KLJMGMKKBPJ<FGCEHDOJGEK, JMEGLHNNJLL> ADNCKKLIAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private KLJMGMKKBPJ<FGCEHDOJGEK, CDMFBBECKPE> DDLMDDDLLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private List<Action> JKDCGCNKOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[CompilerGenerated]
		private Action<AHPCDKCOAJM<FGCEHDOJGEK>>? HMFMNNIAPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[CompilerGenerated]
		private Action<AHPCDKCOAJM<FGCEHDOJGEK>, CDMFBBECKPE>? JHEALMPGKAA;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected GKJHJDKELLF NNBNBEPPLDH
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x53BEA20", Offset = "0x53BDE20", VA = "0x1853BEA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected HOCIAHJFAGN KLKOCAIFDGN
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x53C2B70", Offset = "0x53C1F70", VA = "0x1853C2B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected TNode OEFCCGIGOHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public PBDBGAKNNHI<DPFBAPKEJKA> HNMBNFKLEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xF0F4B0", Offset = "0xF0E8B0", VA = "0x180F0F4B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(PBDBGAKNNHI<DPFBAPKEJKA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public AHPCDKCOAJM<CCPDCNPKMEJ> GNCPDCEDKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x53C3B70", Offset = "0x53C2F70", VA = "0x1853C3B70", Slot = "6")]
			get
			{
				return default(AHPCDKCOAJM<CCPDCNPKMEJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public object FPOFEBBOGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3D2E0B0", Offset = "0x3D2D4B0", VA = "0x183D2E0B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool GPOGKGPDEAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int FHAKFMIMKOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x53C37A0", Offset = "0x53C2BA0", VA = "0x1853C37A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public KPIFOJLDALK OPCICIDMDDK
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x53C3740", Offset = "0x53C2B40", VA = "0x1853C3740", Slot = "10")]
			get
			{
				return default(KPIFOJLDALK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string IAAOLDONDOG
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x53C3D90", Offset = "0x53C3190", VA = "0x1853C3D90", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected virtual bool EGHFCBHFOMK
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public AHPCDKCOAJM<MADIDMKDPCN> AIGBNNEEEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xA4ACD0", Offset = "0xA4A0D0", VA = "0x180A4ACD0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(AHPCDKCOAJM<MADIDMKDPCN>);
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xA4B310", Offset = "0xA4A710", VA = "0x180A4B310")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool EJJGDDJLMBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool CBMPEAAMJAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual EFGDDJICMPF BLMLELDJIPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0xB46440", Offset = "0xB45840", VA = "0x180B46440", Slot = "96")]
			get
			{
				return default(EFGDDJICMPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool CMIGEGJJOFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x53C3450", Offset = "0x53C2850", VA = "0x1853C3450", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool FBKFMLDLKDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x53C34C0", Offset = "0x53C28C0", VA = "0x1853C34C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool EODEFOJJLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x53C3530", Offset = "0x53C2930", VA = "0x1853C3530", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int MNDJIHGDHGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x53C3B10", Offset = "0x53C2F10", VA = "0x1853C3B10", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HCDKMLOFPNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x53C3930", Offset = "0x53C2D30", VA = "0x1853C3930", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool FKFCLLIDJLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x53C3660", Offset = "0x53C2A60", VA = "0x1853C3660", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool ELJBAONBJNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x53C35F0", Offset = "0x53C29F0", VA = "0x1853C35F0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool KHEPMLHNBDF
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xB14DD0", Offset = "0xB141D0", VA = "0x180B14DD0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xEBE6C0", Offset = "0xEBDAC0", VA = "0x180EBE6C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool FFPFLFOAFIO
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "97")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool ANGIJFMACLH
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x53C35A0", Offset = "0x53C29A0", VA = "0x1853C35A0", Slot = "98")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool ANAHNFKKGIM
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x53C3860", Offset = "0x53C2C60", VA = "0x1853C3860", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public NEIHENNLNMK JOKDPLOFCPN
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x53C3A50", Offset = "0x53C2E50", VA = "0x1853C3A50", Slot = "28")]
			get
			{
				return default(NEIHENNLNMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public EMLOIPKJGKA LIEFADIIOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x53C3AB0", Offset = "0x53C2EB0", VA = "0x1853C3AB0", Slot = "30")]
			get
			{
				return default(EMLOIPKJGKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool DPJFFHFKNNM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual ICPFLACGGCE? BAHFLPPOABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual AGAIDCIGFJL? AEOCDJJMNIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual IEnumerable<PBDBGAKNNHI<AMFCOJIMJGL>>? GJPGDEHAPFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool EFAOJAIOKCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x53C36D0", Offset = "0x53C2AD0", VA = "0x1853C36D0", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public PBDBGAKNNHI<PNODKKHPFBO> MFMKPJBCNLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x53C3990", Offset = "0x53C2D90", VA = "0x1853C3990", Slot = "62")]
			get
			{
				return default(PBDBGAKNNHI<PNODKKHPFBO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public AHPCDKCOAJM<PNODKKHPFBO> DAILGMDEFCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x53C3800", Offset = "0x53C2C00", VA = "0x1853C3800", Slot = "56")]
			get
			{
				return default(AHPCDKCOAJM<PNODKKHPFBO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual bool JEJLNPPCAEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual AHPCDKCOAJM<PNODKKHPFBO>? CHJILMAINAA
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool EOOGMEPALOB
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "119")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool CIBKMLODJKG
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x53C38C0", Offset = "0x53C2CC0", VA = "0x1853C38C0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CEDF0", VA = "0x1808CF9F0", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAC0", Offset = "0x8CEEC0", VA = "0x1808CFAC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string EFEINJAGHBE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAE0", Offset = "0x8CEEE0", VA = "0x1808CFAE0", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA90", Offset = "0x8CEE90", VA = "0x1808CFA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public AHPCDKCOAJM<AMFCOJIMJGL> IIDBDCCCCBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x53C3C00", Offset = "0x53C3000", VA = "0x1853C3C00", Slot = "63")]
			get
			{
				return default(AHPCDKCOAJM<AMFCOJIMJGL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public PBDBGAKNNHI<AMFCOJIMJGL> HOPNMPGBGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x53C39F0", Offset = "0x53C2DF0", VA = "0x1853C39F0", Slot = "64")]
			get
			{
				return default(PBDBGAKNNHI<AMFCOJIMJGL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public PBDBGAKNNHI<AMFCOJIMJGL>? JNEOCKNFAIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x53C3C60", Offset = "0x53C3060", VA = "0x1853C3C60", Slot = "120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public GLJFFNDGJDM<FGCEHDOJGEK, CDMFBBECKPE> KKDAGELFLPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x53C3D50", Offset = "0x53C3150", VA = "0x1853C3D50", Slot = "67")]
			get
			{
				return default(GLJFFNDGJDM<FGCEHDOJGEK, CDMFBBECKPE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual AHPCDKCOAJM<FGCEHDOJGEK>? GGAIBBCOHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool CBAGBBAGLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "124")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool JEBPPIKAANK
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "125")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IBGHNHIKCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x53BEBC0", Offset = "0x53BDFC0", VA = "0x1853BEBC0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x53BE3B0", Offset = "0x53BD7B0", VA = "0x1853BE3B0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NDGCIEMODDI FDFOEIGKLEN
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x53C1CA0", Offset = "0x53C10A0", VA = "0x1853C1CA0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x53C1820", Offset = "0x53C0C20", VA = "0x1853C1820", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HJIDCDBJJNB FBOEKCAEPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x53C10A0", Offset = "0x53C04A0", VA = "0x1853C10A0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x53C0050", Offset = "0x53BF450", VA = "0x1853C0050", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OBMBPBCPMJE
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x53BF700", Offset = "0x53BEB00", VA = "0x1853BF700", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x53BE350", Offset = "0x53BD750", VA = "0x1853BE350", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action HGLJPFEINCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x53BF660", Offset = "0x53BEA60", VA = "0x1853BF660", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x53BF810", Offset = "0x53BEC10", VA = "0x1853BF810", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<AHPCDKCOAJM<FGCEHDOJGEK>, CDMFBBECKPE> DENCOFGJBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x53BE220", Offset = "0x53BD620", VA = "0x1853BE220", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x53C18C0", Offset = "0x53C0CC0", VA = "0x1853C18C0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<AHPCDKCOAJM<FGCEHDOJGEK>, CDMFBBECKPE> BDMEDBPDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x53BFF90", Offset = "0x53BF390", VA = "0x1853BFF90", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x53BF5A0", Offset = "0x53BE9A0", VA = "0x1853BF5A0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AHPCDKCOAJM<FGCEHDOJGEK>> IGHMMECCEOH
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x53C0FE0", Offset = "0x53C03E0", VA = "0x1853C0FE0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x53BF8F0", Offset = "0x53BECF0", VA = "0x1853BF8F0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AHPCDKCOAJM<FGCEHDOJGEK>, AHPCDKCOAJM<FGCEHDOJGEK>> AKGKGJACIIE
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x53C1D80", Offset = "0x53C1180", VA = "0x1853C1D80", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x53C02B0", Offset = "0x53BF6B0", VA = "0x1853C02B0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AHPCDKCOAJM<FGCEHDOJGEK>, CDMFBBECKPE> CFDOHJAILMK
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x53C1980", Offset = "0x53C0D80", VA = "0x1853C1980", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x53BE960", Offset = "0x53BDD60", VA = "0x1853BE960", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<AHPCDKCOAJM<FGCEHDOJGEK>, AHPCDKCOAJM<FGCEHDOJGEK>> KHPELLEFBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x53C1140", Offset = "0x53C0540", VA = "0x1853C1140", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x53C1BE0", Offset = "0x53C0FE0", VA = "0x1853C1BE0", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x53C2E50", Offset = "0x53C2250", VA = "0x1853C2E50")]
		[FAOCFIAPHCP("Need to handle `Name` better.")]
		[FAOCFIAPHCP("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected BDEHOBDKNOL(DLFOGDDKJHH HCHGEACFMON, TNode AJLPJFOPFCG, bool OAMILALIJOE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x53C1EC0", Offset = "0x53C12C0", VA = "0x1853C1EC0", Slot = "89")]
		protected virtual void OOJJEJPOBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x53BECD0", Offset = "0x53BE0D0", VA = "0x1853BECD0", Slot = "90")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x53C0A50", Offset = "0x53BFE50", VA = "0x1853C0A50", Slot = "9")]
		[AsyncStateMachine(typeof(BDEHOBDKNOL<>.FPNLEBDFFNE))]
		public void JENCKLLGLOE(int LGEAOOCPIGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x53C0B00", Offset = "0x53BFF00", VA = "0x1853C0B00")]
		public bool JIIPBINJHHJ([In] NEIHENNLNMK HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x53BEA80", Offset = "0x53BDE80", VA = "0x1853BEA80")]
		public bool CAAHAACMFLG([In] EMLOIPKJGKA HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x53C14B0", Offset = "0x53C08B0", VA = "0x1853C14B0", Slot = "32")]
		public void MLEIIICFBCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x53C1A90", Offset = "0x53C0E90", VA = "0x1853C1A90", Slot = "33")]
		[AsyncStateMachine(typeof(BDEHOBDKNOL<>.EGNANIIDEHI))]
		public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> ODFFACFBGCP(NEIHENNLNMK? ENJPHPPLHAI, EMLOIPKJGKA? HONHOJHJMHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "99")]
		public virtual void PIDEGPAMMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "100")]
		public virtual void FCAFHKINPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "101")]
		public virtual void POPBKIHGBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xAFA6F0", Offset = "0xAF9AF0", VA = "0x180AFA6F0")]
		protected void NDGFKEKCHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA11250", Offset = "0xA10650", VA = "0x180A11250")]
		protected void ELECMHBEMHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x2531580", Offset = "0x2530980", VA = "0x182531580")]
		private void MGAAGGMBECM([In] EMLOIPKJGKA CBCAIPELAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x53BFDC0", Offset = "0x53BF1C0", VA = "0x1853BFDC0", Slot = "102")]
		public virtual Task<ABNAGONECLM<AHPCDKCOAJM<FGCEHDOJGEK>, IAAGGMEHHFI>> GJANPGCGBBG(string LJAGHAHCFHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x53BEAF0", Offset = "0x53BDEF0", VA = "0x1853BEAF0", Slot = "103")]
		public virtual Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> CEFMGNPJPOD(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "104")]
		public virtual void ONLNIEJCPOI(AHPCDKCOAJM<FGCEHDOJGEK> OCLLKPEICCI, AHPCDKCOAJM<FGCEHDOJGEK> CPNPDPKHELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x53C1E40", Offset = "0x53C1240", VA = "0x1853C1E40", Slot = "105")]
		public virtual IEnumerable<OCNCAELNEHP> OMOIKBCICBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x53BE4C0", Offset = "0x53BD8C0", VA = "0x1853BE4C0", Slot = "106")]
		public ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI> BEKHDLFHEHK(string HHFLCHOGNNA)
		{
			return default(ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x53C03B0", Offset = "0x53BF7B0", VA = "0x1853C03B0", Slot = "47")]
		public bool IHGIBMAOPMC([Out] Guid GPBLDNKFEEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x53C1200", Offset = "0x53C0600", VA = "0x1853C1200")]
		public bool MLAGBBPCKGO([In] Guid PAAPGLCPIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "107")]
		public virtual void CALNFFOLFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "108")]
		public virtual void JAKGAFKHKCE(bool HEIDICPIIEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "109")]
		public virtual OODCBEBJLKJ LHFHJAOHBNC([In] COMHIMEDPEN AKJLAAOPPKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x53C2C50", Offset = "0x53C2050", VA = "0x1853C2C50")]
		protected void PNDLNJDPLLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x53C1D40", Offset = "0x53C1140", VA = "0x1853C1D40", Slot = "114")]
		protected virtual bool OHJHNMEMNCA(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "115")]
		protected virtual bool MIAGCNOMNGA(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected virtual void DEMKJCOMBPE(MNBPGAMAPPH NEGKNJNHFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x53BE550", Offset = "0x53BD950", VA = "0x1853BE550")]
		protected void BHENFNCMHPO(MNBPGAMAPPH NMKGOIAJNCN, Func<string> JCOAFEDICOH, Action<string> FGALKNGEHFA, string IAOIIOMPAAO, string MKDFLHGBKML, string LNFNAOPNLCC, PMBHINALJDA IJCNOGOBAAL, KLKLIMJFOGI MBLLPCIDMNC, Func<string, bool> MPGKGELLLOA, string AKCKNBINMGM, Func<string, bool> ABOPDNAINMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x53C0500", Offset = "0x53BF900", VA = "0x1853C0500")]
		protected void IKBHGIHADPJ(MNBPGAMAPPH NMKGOIAJNCN, Func<string> JCOAFEDICOH, Action<string> FGALKNGEHFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x53C00F0", Offset = "0x53BF4F0", VA = "0x1853C00F0", Slot = "123")]
		protected virtual void HFDKIOGCFJM(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x53C1A40", Offset = "0x53C0E40", VA = "0x1853C1A40", Slot = "82")]
		public void NJLNBJKMLCD(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x53BFE90", Offset = "0x53BF290", VA = "0x1853BFE90", Slot = "83")]
		public FLFBBNJJMEH GMMIBCANPGP()
		{
			return default(FLFBBNJJMEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "126")]
		public virtual bool IHGNLGMKNHB(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x193C070", Offset = "0x193B470", VA = "0x18193C070")]
		private void JMDPLLBODKO([In] NEIHENNLNMK CPGMOBFHDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x53C16C0", Offset = "0x53C0AC0", VA = "0x1853C16C0")]
		private void MODKPCNNIGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x53C2630", Offset = "0x53C1A30", VA = "0x1853C2630")]
		private void PFJEKKHKAAO(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, OHODLOOFPKP AGNABMOBHDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xC787A0", Offset = "0xC77BA0", VA = "0x180C787A0")]
		private void FLKKOJAFBIN(AHPCDKCOAJM<FGCEHDOJGEK> LPMIIFILJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x53C0800", Offset = "0x53BFC00", VA = "0x1853C0800")]
		private void INGAMINLBND(AHPCDKCOAJM<FGCEHDOJGEK> LPMIIFILJPI, OHODLOOFPKP LJFBDEPBCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x53C0B90", Offset = "0x53BFF90", VA = "0x1853C0B90")]
		private void KCJFPGKNGAL(AHPCDKCOAJM<FGCEHDOJGEK> OCLLKPEICCI, AHPCDKCOAJM<FGCEHDOJGEK> CPNPDPKHELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xC772C0", Offset = "0xC766C0", VA = "0x180C772C0")]
		private void IANNDNFFOBE(AHPCDKCOAJM<FGCEHDOJGEK> OCLLKPEICCI, AHPCDKCOAJM<FGCEHDOJGEK> CPNPDPKHELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x53C0B70", Offset = "0x53BFF70", VA = "0x1853C0B70")]
		private void JOGJFEJFPCL(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x53BF9B0", Offset = "0x53BEDB0", VA = "0x1853BF9B0")]
		private void GIPMJDJBJNB(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, OHODLOOFPKP AGNABMOBHDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x53BEC60", Offset = "0x53BE060", VA = "0x1853BEC60")]
		private void DOMBNKOLDAI(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, OHODLOOFPKP LJFBDEPBCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x53C0930", Offset = "0x53BFD30", VA = "0x1853C0930", Slot = "127")]
		[AsyncStateMachine(typeof(BDEHOBDKNOL<>.BDIHIMGMMHN))]
		public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> JCHPABMJLFI(string HHFLCHOGNNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x53BE450", Offset = "0x53BD850", VA = "0x1853BE450", Slot = "54")]
		private void BDEIDMFKFEF(object NNNFGCPLJFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x53BE2E0", Offset = "0x53BD6E0", VA = "0x1853BE2E0", Slot = "55")]
		private void AKEEAOCPHNL(object NNNFGCPLJFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x53BF8B0", Offset = "0x53BECB0", VA = "0x1853BF8B0", Slot = "29")]
		private bool GHMGCICJGEG([In] NEIHENNLNMK HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x53BF7D0", Offset = "0x53BEBD0", VA = "0x1853BF7D0", Slot = "31")]
		private bool FANLKJDCCIC([In] EMLOIPKJGKA HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x53C0370", Offset = "0x53BF770", VA = "0x1853C0370", Slot = "48")]
		private bool IDMKECBPKNG([In] Guid PAAPGLCPIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x525D440", Offset = "0x525C840", VA = "0x18525D440")]
		[CompilerGenerated]
		private string GLJENNBMNPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x53C0F30", Offset = "0x53C0330", VA = "0x1853C0F30")]
		[CompilerGenerated]
		private void KGFLDAMJDPB(string LJAGHAHCFHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class OKGIGCNHFIK : AOOOAPLDGHO<KHJCCCFKOGG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x9A16C0", Offset = "0x9A0AC0", VA = "0x1809A16C0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x230DF70", Offset = "0x230D370", VA = "0x18230DF70")]
		public OKGIGCNHFIK(DLFOGDDKJHH HCHGEACFMON, KHJCCCFKOGG AJLPJFOPFCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class CFNLKNKDFNM : PHPAMGEBMPK<HMELBCHECDB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93DFD0", VA = "0x18093EBD0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x22F6810", Offset = "0x22F5C10", VA = "0x1822F6810")]
		public CFNLKNKDFNM(DLFOGDDKJHH HCHGEACFMON, HMELBCHECDB AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public abstract class LANBKAKBHDN<T> : BDEHOBDKNOL<T> where T : notnull, MLMBPEEMFLA
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class MCFMMKOEBBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public IReadOnlyList<KeyValuePair<string, CKGLPPPLONC>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public LANBKAKBHDN<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public KGJJJCENCJI clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public MCFMMKOEBBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			internal IReadOnlyList<KeyValuePair<string, CKGLPPPLONC>> MLAAGLMMDFC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x49DB450", Offset = "0x49DA850", VA = "0x1849DB450")]
			internal int PDAJCGGHEFH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x49DB230", Offset = "0x49DA630", VA = "0x1849DB230")]
			internal void PBMMAPMNPOP(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x49DB1E0", Offset = "0x49DA5E0", VA = "0x1849DB1E0")]
			internal void PBAIAHOJBNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x49DAE00", Offset = "0x49DA200", VA = "0x1849DAE00")]
			internal void EHPJBOIINIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x49DAC50", Offset = "0x49DA050", VA = "0x1849DAC50")]
			internal bool ADNGHCOIDNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x49DAF50", Offset = "0x49DA350", VA = "0x1849DAF50")]
			internal void GBINDMDKDFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x49DAC50", Offset = "0x49DA050", VA = "0x1849DAC50")]
			internal bool ONONMOPNFIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x49DACE0", Offset = "0x49DA0E0", VA = "0x1849DACE0")]
			internal float CNKNOGJOKLG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x49DB120", Offset = "0x49DA520", VA = "0x1849DB120")]
			internal void OOIBEPDENDH(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x49DAFA0", Offset = "0x49DA3A0", VA = "0x1849DAFA0")]
			internal float KNCPAOLMPFJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x49DB060", Offset = "0x49DA460", VA = "0x1849DB060")]
			internal void MMPLMKBLAAC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x49DB000", Offset = "0x49DA400", VA = "0x1849DB000")]
			internal float MKMEAEEKFOG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x49DAD40", Offset = "0x49DA140", VA = "0x1849DAD40")]
			internal void DAKLMKKGMAM(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xC75E40", Offset = "0xC75240", VA = "0x180C75E40", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public abstract KGJJJCENCJI LNCKIBPLPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(Slot = "128")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x4660320", Offset = "0x465F720", VA = "0x184660320")]
		public LANBKAKBHDN(DLFOGDDKJHH HCHGEACFMON, T AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x47B8F70", Offset = "0x47B8370", VA = "0x1847B8F70", Slot = "122")]
		protected sealed override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class LFHFHHHMJAB : BDEHOBDKNOL<LDDFCJIIMCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x9A10D0", Offset = "0x9A04D0", VA = "0x1809A10D0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2303FC0", Offset = "0x23033C0", VA = "0x182303FC0")]
		public LFHFHHHMJAB(DLFOGDDKJHH HCHGEACFMON, LDDFCJIIMCJ AJLPJFOPFCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class EBNMKAAGLPM : BDEHOBDKNOL<BIJJJCNOJPM>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class PKLLAFPPKMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public EBNMKAAGLPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public PKLLAFPPKMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x230FE30", Offset = "0x230F230", VA = "0x18230FE30")]
			internal int PDAJCGGHEFH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x230FDA0", Offset = "0x230F1A0", VA = "0x18230FDA0")]
			internal void PBMMAPMNPOP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private static Dictionary<string, CKGLPPPLONC>? ODGFOLELOOF;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x22F94B0", Offset = "0x22F88B0", VA = "0x1822F94B0")]
		public EBNMKAAGLPM(DLFOGDDKJHH HCHGEACFMON, BIJJJCNOJPM AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x22F9140", Offset = "0x22F8540", VA = "0x1822F9140", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class NFJGMPAEECM : LANBKAKBHDN<OCOEPIJHCID>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override KGJJJCENCJI LNCKIBPLPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "128")]
			get
			{
				return default(KGJJJCENCJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x230CBF0", Offset = "0x230BFF0", VA = "0x18230CBF0")]
		public NFJGMPAEECM(DLFOGDDKJHH HCHGEACFMON, OCOEPIJHCID HKNABNLJGOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class JJEJKLFNFMI : PHPAMGEBMPK<IABKKPJOBIF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93DFD0", VA = "0x18093EBD0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x22FD010", Offset = "0x22FC410", VA = "0x1822FD010")]
		public JJEJKLFNFMI(DLFOGDDKJHH HCHGEACFMON, IABKKPJOBIF AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private sealed class HMBBCDENCAA : PHPAMGEBMPK<IACMDFADCGC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93DFD0", VA = "0x18093EBD0", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x22FB710", Offset = "0x22FAB10", VA = "0x1822FB710")]
		public HMBBCDENCAA(DLFOGDDKJHH HCHGEACFMON, IACMDFADCGC AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class GPDOGPNCNEI : KEMIEKNPFEC<MBOHJPBNGKO>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class DJNJNFAMOJE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A4")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public DJNJNFAMOJE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003DC")]
				[Cpp2IlInjected.Address(RVA = "0x23103F0", Offset = "0x230F7F0", VA = "0x1823103F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public GPDOGPNCNEI <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public DJNJNFAMOJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x22F8E60", Offset = "0x22F8260", VA = "0x1822F8E60")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void CEIMNLJHKHO(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x22FA740", Offset = "0x22F9B40", VA = "0x1822FA740")]
		public GPDOGPNCNEI(DLFOGDDKJHH HCHGEACFMON, MBOHJPBNGKO HKNABNLJGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x22FA460", Offset = "0x22F9860", VA = "0x1822FA460", Slot = "128")]
		protected override void COIEABDHGAB(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class PDAFEHIKNJD : LANBKAKBHDN<DNDFOLLDGNB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override KGJJJCENCJI LNCKIBPLPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x92C8E0", Offset = "0x92BCE0", VA = "0x18092C8E0", Slot = "128")]
			get
			{
				return default(KGJJJCENCJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x230E770", Offset = "0x230DB70", VA = "0x18230E770")]
		public PDAFEHIKNJD(DLFOGDDKJHH HCHGEACFMON, DNDFOLLDGNB HKNABNLJGOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private sealed class BIGHKCJCGPD : BDEHOBDKNOL<IMDDBBPKMHM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x9B7340", Offset = "0x9B6740", VA = "0x1809B7340", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x22F6430", Offset = "0x22F5830", VA = "0x1822F6430")]
		public BIGHKCJCGPD(DLFOGDDKJHH HCHGEACFMON, IMDDBBPKMHM AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class DGJGEAHNJFI : BDEHOBDKNOL<ADFNIAMFNMF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public sealed override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public sealed override bool EJJGDDJLMBL
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected sealed override bool EGHFCBHFOMK
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x22F8A00", Offset = "0x22F7E00", VA = "0x1822F8A00")]
		public DGJGEAHNJFI(DLFOGDDKJHH HCHGEACFMON, ADFNIAMFNMF AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x22F8690", Offset = "0x22F7A90", VA = "0x1822F8690", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x22F89C0", Offset = "0x22F7DC0", VA = "0x1822F89C0")]
		private int MIBGDHLJLDF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x22F8960", Offset = "0x22F7D60", VA = "0x1822F8960")]
		private void IOAOBHBFCPB(int GAADACALPOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class AFFJOGOLMJD : BCHBMALBDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x22F5D50", Offset = "0x22F5150", VA = "0x1822F5D50")]
		public AFFJOGOLMJD(DLFOGDDKJHH HCHGEACFMON, FAKCDJHFJMO AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class MEJOHOJCNCH : KEMIEKNPFEC<GNEHNNAOGMD>
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2305F40", Offset = "0x2305340", VA = "0x182305F40")]
		public MEJOHOJCNCH(DLFOGDDKJHH HCHGEACFMON, GNEHNNAOGMD AJLPJFOPFCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public abstract class KEMIEKNPFEC<TVariableNode> : BDEHOBDKNOL<TVariableNode> where TVariableNode : notnull, GNEHNNAOGMD
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class GGHCDDDGGLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public KEMIEKNPFEC<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public GGHCDDDGGLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x4196100", Offset = "0x4195500", VA = "0x184196100")]
			internal bool MLAAGLMMDFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x4196280", Offset = "0x4195680", VA = "0x184196280")]
			internal void PDAJCGGHEFH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x4196220", Offset = "0x4195620", VA = "0x184196220")]
			internal bool PBMMAPMNPOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x4196160", Offset = "0x4195560", VA = "0x184196160")]
			internal void PBAIAHOJBNK(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x4196050", Offset = "0x4195450", VA = "0x184196050")]
			internal bool EHPJBOIINIJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class PPKJGOKLCIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public HOCIAHJFAGN nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public KEMIEKNPFEC<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public PPKJGOKLCIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x4CB65D0", Offset = "0x4CB59D0", VA = "0x184CB65D0")]
			internal void CEIMNLJHKHO(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x9ABD30", Offset = "0x9AB130", VA = "0x1809ABD30", Slot = "93")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override EFGDDJICMPF BLMLELDJIPO
		{
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x4663D30", Offset = "0x4663130", VA = "0x184663D30", Slot = "96")]
			get
			{
				return default(EFGDDJICMPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x4663B80", Offset = "0x4662F80", VA = "0x184663B80")]
		protected KEMIEKNPFEC(DLFOGDDKJHH HCHGEACFMON, TVariableNode AJLPJFOPFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x46639E0", Offset = "0x4662DE0", VA = "0x1846639E0", Slot = "90")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x4663530", Offset = "0x4662930", VA = "0x184663530", Slot = "122")]
		protected override void DEMKJCOMBPE(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x4663190", Offset = "0x4662590", VA = "0x184663190", Slot = "128")]
		protected virtual void COIEABDHGAB(MNBPGAMAPPH NMKGOIAJNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x4663090", Offset = "0x4662490", VA = "0x184663090", Slot = "107")]
		public override void CALNFFOLFJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x22D9ED0", Offset = "0x22D92D0", VA = "0x1822D9ED0")]
	public static OAIONGHIMFG ODOFIFAGLAJ(DLFOGDDKJHH HCHGEACFMON, FAKCDJHFJMO AJLPJFOPFCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class ONJMMHCEAHM : LJKOGHONMGE, CAENPNJFLFG, JIJMCDJACFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AHPCDKCOAJM<JGJEEGHFLFO> FMGMBLALONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x99DFB0", Offset = "0x99D3B0", VA = "0x18099DFB0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(AHPCDKCOAJM<JGJEEGHFLFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public AHPCDKCOAJM<JFFAPEFODIA> DOHDKADBAML
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB20B0", Offset = "0xAB14B0", VA = "0x180AB20B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(AHPCDKCOAJM<JFFAPEFODIA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x230E020", Offset = "0x230D420", VA = "0x18230E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private AHPCDKCOAJM<CBPDOKJJLFC> MKKLJBJFCNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B69D0", Offset = "0x9B5DD0", VA = "0x1809B69D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public override AHPCDKCOAJM<GBPNADAEKMC> DBCNIGOJOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x230DFD0", Offset = "0x230D3D0", VA = "0x18230DFD0", Slot = "20")]
		get
		{
			return default(AHPCDKCOAJM<GBPNADAEKMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x230E380", Offset = "0x230D780", VA = "0x18230E380")]
	private ONJMMHCEAHM(DLFOGDDKJHH HCHGEACFMON, FAKCDJHFJMO AJLPJFOPFCG, ANMFKCOFLFB CJLEHOGJOCI, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, AHPCDKCOAJM<JFFAPEFODIA> MLIAJGPJJLE, AHPCDKCOAJM<CBPDOKJJLFC> PIOHKEBMBIL, bool PPJKGGLIKHO, string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x230E030", Offset = "0x230D430", VA = "0x18230E030")]
	public static ONJMMHCEAHM ODOFIFAGLAJ(DLFOGDDKJHH HCHGEACFMON, FAKCDJHFJMO AJLPJFOPFCG, ANMFKCOFLFB IJEPNDOCKIJ, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, AHPCDKCOAJM<CBPDOKJJLFC> PIOHKEBMBIL, AHPCDKCOAJM<JFFAPEFODIA> MLIAJGPJJLE, bool PPJKGGLIKHO, bool OAMILALIJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x230E020", Offset = "0x230D420", VA = "0x18230E020")]
	internal void LBLEDNKLKPO(AHPCDKCOAJM<JFFAPEFODIA> HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public abstract class LJKOGHONMGE : JIJMCDJACFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private struct GGHNBIIHIDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private LHCPNBCLHEF? NEPGFGDMCBB;

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x22FA160", Offset = "0x22F9560", VA = "0x1822FA160")]
		public void CDMKLDGEKPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x22FA170", Offset = "0x22F9570", VA = "0x1822FA170")]
		public LHCPNBCLHEF MKINNBKOIGH(LJKOGHONMGE DMPMHLBDEEB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	protected readonly DLFOGDDKJHH DMPLBKKFJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	protected readonly FAKCDJHFJMO MFMCHKMONGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private GGHNBIIHIDO GKKBOJBDKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly LLNMMCOPAPI HIDDICFJIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly List<LIKHONKJOPF> NMDOODBAHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly List<MKIDPAFJFDN> AKPDDGCAGNF;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	[FAOCFIAPHCP("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> CFOBOIECDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2304340", Offset = "0x2303740", VA = "0x182304340", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DisplayKind HGOEDEGAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D52D0", VA = "0x1808D5ED0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public AHPCDKCOAJM<PNODKKHPFBO> DAILGMDEFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2304030", Offset = "0x2303430", VA = "0x182304030", Slot = "6")]
		get
		{
			return default(AHPCDKCOAJM<PNODKKHPFBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PBDBGAKNNHI<PNODKKHPFBO> MFMKPJBCNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2304250", Offset = "0x2303650", VA = "0x182304250", Slot = "7")]
		get
		{
			return default(PBDBGAKNNHI<PNODKKHPFBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public HBNOCLDLIEG POEONHMADFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x9835E0", Offset = "0x9829E0", VA = "0x1809835E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public DJLAMLMHKCG EMBDANEKFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x23041B0", Offset = "0x23035B0", VA = "0x1823041B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	protected LHCPNBCLHEF EHLGFPLMJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x23041B0", Offset = "0x23035B0", VA = "0x1823041B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PortImage JALMPNLMBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x2304EE0", Offset = "0x23042E0", VA = "0x182304EE0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA40", Offset = "0x8CEE40", VA = "0x1808CFA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public PBDBGAKNNHI<AMFCOJIMJGL> HOPNMPGBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x2305360", Offset = "0x2304760", VA = "0x182305360", Slot = "9")]
		get
		{
			return default(PBDBGAKNNHI<AMFCOJIMJGL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public AHPCDKCOAJM<FGCEHDOJGEK> IJFEJMMMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x968280", Offset = "0x967680", VA = "0x180968280", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(AHPCDKCOAJM<FGCEHDOJGEK>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xAB18A0", Offset = "0xAB0CA0", VA = "0x180AB18A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public abstract AHPCDKCOAJM<GBPNADAEKMC> DBCNIGOJOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x23053E0", Offset = "0x23047E0", VA = "0x1823053E0")]
	protected LJKOGHONMGE(DLFOGDDKJHH HCHGEACFMON, FAKCDJHFJMO AJLPJFOPFCG, LLNMMCOPAPI KFFGLKDIHDK, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, bool PPJKGGLIKHO, string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2305210", Offset = "0x2304610", VA = "0x182305210", Slot = "21")]
	protected virtual void OOJJEJPOBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2304060", Offset = "0x2303460", VA = "0x182304060", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2305380", Offset = "0x2304780", VA = "0x182305380", Slot = "14")]
	public void PNLGJMPPCLI(LIKHONKJOPF IMHIIMJFBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2304280", Offset = "0x2303680", VA = "0x182304280", Slot = "15")]
	public void FNJIIBKJEOE(MKIDPAFJFDN IMHIIMJFBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2304600", Offset = "0x2303A00", VA = "0x182304600", Slot = "16")]
	public void KMEMJEFMKJE(PIJNDAFPFNN PNKBECKBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x23051B0", Offset = "0x23045B0", VA = "0x1823051B0", Slot = "23")]
	protected virtual void OICFPHMGNCD(PIJNDAFPFNN PNKBECKBKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2304480", Offset = "0x2303880", VA = "0x182304480")]
	private void KHLIMDLKBNB(bool PGHMIFOEHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2304CB0", Offset = "0x23040B0", VA = "0x182304CB0")]
	private void LBAOKFDIEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2305010", Offset = "0x2304410", VA = "0x182305010")]
	private void OAEEODDGEON([In] BNJKFHIPNCB FEPKJKLHFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x23042E0", Offset = "0x23036E0", VA = "0x1823042E0", Slot = "17")]
	public void HHBHCBPNACH(LIKHONKJOPF IMHIIMJFBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2304E60", Offset = "0x2304260", VA = "0x182304E60", Slot = "18")]
	public void MOLBJHPFMIG(MKIDPAFJFDN IMHIIMJFBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8CFA40", Offset = "0x8CEE40", VA = "0x1808CFA40")]
	internal void EHMGIICIFCP(string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2304EC0", Offset = "0x23042C0", VA = "0x182304EC0")]
	internal void NAKGEHHOLDH(NKMPIANNFDJ CFAPAOIIPAA, HBNOCLDLIEG IFBDJLKPHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xAB18A0", Offset = "0xAB0CA0", VA = "0x180AB18A0")]
	internal void IJMGNPFJPME(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public sealed class JMEGLHNNJLL : CDMFBBECKPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class GCKNOPDNJDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public DLFOGDDKJHH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public FAKCDJHFJMO node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public AHPCDKCOAJM<FGCEHDOJGEK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GCKNOPDNJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x22F9D10", Offset = "0x22F9110", VA = "0x1822F9D10")]
		internal NDEIBOIGIEP HCIJGCCANDP((int PortDescIndex, int PortIndex, BLLIGGJJDEM InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x22F9C80", Offset = "0x22F9080", VA = "0x1822F9C80")]
		internal ONJMMHCEAHM CPALBGFGFLK(ANMFKCOFLFB i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct HHFHMGNMOCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x22FAE30", Offset = "0x22FA230", VA = "0x1822FAE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x22FB290", Offset = "0x22FA690", VA = "0x1822FB290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct BCKLNCFNDBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AHPCDKCOAJM<FEHJPJMJDBG> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x22F6070", Offset = "0x22F5470", VA = "0x1822F6070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x22F63C0", Offset = "0x22F57C0", VA = "0x1822F63C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct ADMKEBEKKFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AHPCDKCOAJM<CBPDOKJJLFC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x22F5990", Offset = "0x22F4D90", VA = "0x1822F5990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x22F5CE0", Offset = "0x22F50E0", VA = "0x1822F5CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct CIPDIICNDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AHPCDKCOAJM<FEHJPJMJDBG> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public AHPCDKCOAJM<FEHJPJMJDBG> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x22F79B0", Offset = "0x22F6DB0", VA = "0x1822F79B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x22F7D00", Offset = "0x22F7100", VA = "0x1822F7D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct IJNLAHHOPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public AHPCDKCOAJM<CBPDOKJJLFC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public AHPCDKCOAJM<CBPDOKJJLFC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x22FB900", Offset = "0x22FAD00", VA = "0x1822FB900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x22FBC50", Offset = "0x22FB050", VA = "0x1822FBC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct KDGIJLJHCCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2303320", Offset = "0x2302720", VA = "0x182303320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2303790", Offset = "0x2302B90", VA = "0x182303790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct ADGHEGLPLGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x22F55D0", Offset = "0x22F49D0", VA = "0x1822F55D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x22F5920", Offset = "0x22F4D20", VA = "0x1822F5920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct HEAKGMHODNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AHPCDKCOAJM<FEHJPJMJDBG> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x22FAA70", Offset = "0x22F9E70", VA = "0x1822FAA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x22FADC0", Offset = "0x22FA1C0", VA = "0x1822FADC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct KOGCLDNAKOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AHPCDKCOAJM<CBPDOKJJLFC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2303800", Offset = "0x2302C00", VA = "0x182303800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2303B50", Offset = "0x2302F50", VA = "0x182303B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct MBIHOLFHLFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public FJGOBNNFCHJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AHPCDKCOAJM<FEHJPJMJDBG> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2305B40", Offset = "0x2304F40", VA = "0x182305B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2305ED0", Offset = "0x23052D0", VA = "0x182305ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LBGPLFCAIGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public JMEGLHNNJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public FJGOBNNFCHJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AHPCDKCOAJM<CBPDOKJJLFC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private GDCDMFKBBJH <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2303BC0", Offset = "0x2302FC0", VA = "0x182303BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2303F50", Offset = "0x2303350", VA = "0x182303F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly bool PPGFCJHGNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly DLFOGDDKJHH DMPLBKKFJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly bool NFKFKAPMMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private GLJFFNDGJDM<DPLMPJGGPFN, NDEIBOIGIEP> KGFMGEJGPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private GLJFFNDGJDM<DPLMPJGGPFN, OIOMPGFJCEO> GBNPKFGAMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly FAKCDJHFJMO MFMCHKMONGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private GLJFFNDGJDM<JFFAPEFODIA, ONJMMHCEAHM> EDBLEMBOFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private GLJFFNDGJDM<JFFAPEFODIA, CAENPNJFLFG> GGAHMFHOAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private string? GACMNPDDBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly OHODLOOFPKP NHIOAGEAMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private AHPCDKCOAJM<FGCEHDOJGEK> FJJLOAJAKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly bool PEMGDDCEAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	[CompilerGenerated]
	private Action? KEEPEHEALIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	[CompilerGenerated]
	private Action? MHEBEKGJNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	[CompilerGenerated]
	private Action<AHPCDKCOAJM<DPLMPJGGPFN>>? KODAHCICJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	[CompilerGenerated]
	private Action<AHPCDKCOAJM<JFFAPEFODIA>>? HJOGOBKMNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	[CompilerGenerated]
	private CDMFBBECKPE.BAHDAFNHJCP? GMEDAMFHJKM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool LBIKFCPHHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2302A10", Offset = "0x2301E10", VA = "0x182302A10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool OBJMKINGNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2300BB0", Offset = "0x22FFFB0", VA = "0x182300BB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool IENMJPONDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2302950", Offset = "0x2301D50", VA = "0x182302950", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public PBDBGAKNNHI<PNODKKHPFBO> MFMKPJBCNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x22FEB50", Offset = "0x22FDF50", VA = "0x1822FEB50", Slot = "7")]
		get
		{
			return default(PBDBGAKNNHI<PNODKKHPFBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool EGNEDBMPKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2301DD0", Offset = "0x23011D0", VA = "0x182301DD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public GLJFFNDGJDM<DPLMPJGGPFN, OIOMPGFJCEO> PMDOJENPBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "9")]
		get
		{
			return default(GLJFFNDGJDM<DPLMPJGGPFN, OIOMPGFJCEO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x22FF630", Offset = "0x22FEA30", VA = "0x1822FF630", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public PBDBGAKNNHI<AMFCOJIMJGL> HOPNMPGBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2302870", Offset = "0x2301C70", VA = "0x182302870", Slot = "11")]
		get
		{
			return default(PBDBGAKNNHI<AMFCOJIMJGL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public GLJFFNDGJDM<JFFAPEFODIA, CAENPNJFLFG> PMJFPPCHOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80", Slot = "12")]
		get
		{
			return default(GLJFFNDGJDM<JFFAPEFODIA, CAENPNJFLFG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public AHPCDKCOAJM<FGCEHDOJGEK> IJFEJMMMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6920", Offset = "0x9B5D20", VA = "0x1809B6920", Slot = "13")]
		get
		{
			return default(AHPCDKCOAJM<FGCEHDOJGEK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action KAKKFBNEDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x22FE930", Offset = "0x22FDD30", VA = "0x1822FE930", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x22FD070", Offset = "0x22FC470", VA = "0x1822FD070", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action DINHPKBJKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x23006F0", Offset = "0x22FFAF0", VA = "0x1823006F0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x22FD3B0", Offset = "0x22FC7B0", VA = "0x1822FD3B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<AHPCDKCOAJM<DPLMPJGGPFN>, AHPCDKCOAJM<DPLMPJGGPFN>> HBABCBBBDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x23014C0", Offset = "0x23008C0", VA = "0x1823014C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2301E50", Offset = "0x2301250", VA = "0x182301E50", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<AHPCDKCOAJM<DPLMPJGGPFN>, AHPCDKCOAJM<DPLMPJGGPFN>> KLALLENLEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x23027B0", Offset = "0x2301BB0", VA = "0x1823027B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x22FE850", Offset = "0x22FDC50", VA = "0x1822FE850", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<AHPCDKCOAJM<JFFAPEFODIA>, AHPCDKCOAJM<JFFAPEFODIA>> KIGHPCAPAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x22FD1D0", Offset = "0x22FC5D0", VA = "0x1822FD1D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2300240", Offset = "0x22FF640", VA = "0x182300240", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<AHPCDKCOAJM<JFFAPEFODIA>, AHPCDKCOAJM<JFFAPEFODIA>> LDDJFJECBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x22FF570", Offset = "0x22FE970", VA = "0x1822FF570", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x22FF680", Offset = "0x22FEA80", VA = "0x1822FF680", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<AHPCDKCOAJM<DPLMPJGGPFN>, OIOMPGFJCEO> GMKAHLLFKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x22FE9D0", Offset = "0x22FDDD0", VA = "0x1822FE9D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2301060", Offset = "0x2300460", VA = "0x182301060", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<AHPCDKCOAJM<DPLMPJGGPFN>> DBFOODDJGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2300180", Offset = "0x22FF580", VA = "0x182300180", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2300630", Offset = "0x22FFA30", VA = "0x182300630", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<AHPCDKCOAJM<DPLMPJGGPFN>, OIOMPGFJCEO> KMGAMCNHBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x23008C0", Offset = "0x22FFCC0", VA = "0x1823008C0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x22FFC00", Offset = "0x22FF000", VA = "0x1822FFC00", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<AHPCDKCOAJM<JFFAPEFODIA>, CAENPNJFLFG> INJEONIHHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2302890", Offset = "0x2301C90", VA = "0x182302890", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x22FF7A0", Offset = "0x22FEBA0", VA = "0x1822FF7A0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<AHPCDKCOAJM<JFFAPEFODIA>> AJFFAJOHDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x22FD2F0", Offset = "0x22FC6F0", VA = "0x1822FD2F0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x22FD110", Offset = "0x22FC510", VA = "0x1822FD110", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<AHPCDKCOAJM<JFFAPEFODIA>, CAENPNJFLFG> HADIHBJLLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x22FEA90", Offset = "0x22FDE90", VA = "0x1822FEA90", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x23016B0", Offset = "0x2300AB0", VA = "0x1823016B0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x2302F20", Offset = "0x2302320", VA = "0x182302F20")]
	private JMEGLHNNJLL(bool PPJKGGLIKHO, DLFOGDDKJHH HCHGEACFMON, bool JGCADHIGPHC, GLJFFNDGJDM<DPLMPJGGPFN, NDEIBOIGIEP> POJBCHAHLFG, GLJFFNDGJDM<DPLMPJGGPFN, OIOMPGFJCEO> KHJJEGIJMMO, FAKCDJHFJMO AJLPJFOPFCG, GLJFFNDGJDM<JFFAPEFODIA, ONJMMHCEAHM> BOJIHAAGEDD, GLJFFNDGJDM<JFFAPEFODIA, CAENPNJFLFG> NPOGOLDFEAP, string? ODDEMLBFKAC, OHODLOOFPKP AGNABMOBHDD, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, bool OAMILALIJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2301860", Offset = "0x2300C60", VA = "0x182301860")]
	public static JMEGLHNNJLL ODOFIFAGLAJ(bool PPJKGGLIKHO, DLFOGDDKJHH HCHGEACFMON, bool JGCADHIGPHC, FAKCDJHFJMO AJLPJFOPFCG, OHODLOOFPKP AGNABMOBHDD, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, bool OAMILALIJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2302000", Offset = "0x2301400", VA = "0x182302000")]
	private void OOJJEJPOBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x22FDAB0", Offset = "0x22FCEB0", VA = "0x1822FDAB0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2301770", Offset = "0x2300B70", VA = "0x182301770", Slot = "38")]
	[AsyncStateMachine(typeof(HHFHMGNMOCF))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> NLCOBJAHNGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2300980", Offset = "0x22FFD80", VA = "0x182300980")]
	private (OHBFAAHGDIJ, int)? KNICEGAEBOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x22FEBC0", Offset = "0x22FDFC0", VA = "0x1822FEBC0")]
	private void GDNJFHGIALA(int OKMBJEGDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x19551E0", Offset = "0x19545E0", VA = "0x1819551E0")]
	private void LEMPOIFHFDJ(int OKMBJEGDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x22FFDE0", Offset = "0x22FF1E0", VA = "0x1822FFDE0")]
	private void JFHBNLKIOLH(int FHHFABGGENB, int HDFCCHAJDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x22FF740", Offset = "0x22FEB40", VA = "0x1822FF740")]
	private void HPLLBOEHAEJ(int FHHFABGGENB, int HDFCCHAJDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x22FD570", Offset = "0x22FC970", VA = "0x1822FD570")]
	private void DIOGLIMLAGA(int OKMBJEGDPPA, AHPCDKCOAJM<DPLMPJGGPFN> FCAEHNJAAOM, BLLIGGJJDEM AHHPGJOEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x22FF660", Offset = "0x22FEA60", VA = "0x1822FF660")]
	private void HNDJMKALDGC(int PGHMIFOEHOF, AHPCDKCOAJM<DPLMPJGGPFN> FCAEHNJAAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x22FEB80", Offset = "0x22FDF80", VA = "0x1822FEB80")]
	private void FLNNMJALMNL(int PGHMIFOEHOF, AHPCDKCOAJM<DPLMPJGGPFN> FCAEHNJAAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2302AD0", Offset = "0x2301ED0", VA = "0x182302AD0")]
	private void PPFDKPANKBI(int OKMBJEGDPPA, AHPCDKCOAJM<DPLMPJGGPFN> FCAEHNJAAOM, BLLIGGJJDEM AHHPGJOEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x22FE5B0", Offset = "0x22FD9B0", VA = "0x1822FE5B0")]
	private void EAKOGAPLMFE(int OKMBJEGDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xE8DBD0", Offset = "0xE8CFD0", VA = "0x180E8DBD0")]
	private void LMDCHAHCBKI(int OKMBJEGDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2300300", Offset = "0x22FF700", VA = "0x182300300")]
	private void KAHNFMJAIPD(int OKMBJEGDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x19551E0", Offset = "0x19545E0", VA = "0x1819551E0")]
	private void AMEBEIAGMKE(int OKMBJEGDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2301120", Offset = "0x2300520", VA = "0x182301120")]
	private void MOOJEFKNHLN(int FHHFABGGENB, int HDFCCHAJDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x22FD290", Offset = "0x22FC690", VA = "0x1822FD290")]
	private void BLKCPKGBLDE(int FHHFABGGENB, int HDFCCHAJDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x22FEF00", Offset = "0x22FE300", VA = "0x1822FEF00")]
	private void HEPOLAFDIGO(int OKMBJEGDPPA, AHPCDKCOAJM<JFFAPEFODIA> FCAEHNJAAOM, ANMFKCOFLFB AHHPGJOEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x22FEBA0", Offset = "0x22FDFA0", VA = "0x1822FEBA0")]
	private void GAPOJJBHDLH(int PGHMIFOEHOF, AHPCDKCOAJM<JFFAPEFODIA> FCAEHNJAAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x22FE910", Offset = "0x22FDD10", VA = "0x1822FE910")]
	private void ENBCILCGEBA(int PGHMIFOEHOF, AHPCDKCOAJM<JFFAPEFODIA> FCAEHNJAAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2300BF0", Offset = "0x22FFFF0", VA = "0x182300BF0")]
	private void MMBIJOIIDAI(int OKMBJEGDPPA, AHPCDKCOAJM<JFFAPEFODIA> FCAEHNJAAOM, ANMFKCOFLFB AHHPGJOEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x22FE700", Offset = "0x22FDB00", VA = "0x1822FE700")]
	private void EALKGFDKNJA(int OKMBJEGDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xE8DBD0", Offset = "0xE8CFD0", VA = "0x180E8DBD0")]
	private void PFKBIOLHHOH(int OKMBJEGDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x23003F0", Offset = "0x22FF7F0", VA = "0x1823003F0", Slot = "39")]
	[AsyncStateMachine(typeof(BCKLNCFNDBB))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> KBHPJBIBFNJ(AHPCDKCOAJM<FEHJPJMJDBG> IOOAPHCONAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x22FD460", Offset = "0x22FC860", VA = "0x1822FD460", Slot = "40")]
	[AsyncStateMachine(typeof(ADMKEBEKKFA))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> DGGFLDHHHEK(AHPCDKCOAJM<CBPDOKJJLFC> PIOHKEBMBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x22FECB0", Offset = "0x22FE0B0", VA = "0x1822FECB0", Slot = "41")]
	[AsyncStateMachine(typeof(CIPDIICNDGL))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> GIKCOKNAHON(AHPCDKCOAJM<FEHJPJMJDBG> IOOAPHCONAK, AHPCDKCOAJM<FEHJPJMJDBG> HIMFEKCBCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x23007A0", Offset = "0x22FFBA0", VA = "0x1823007A0", Slot = "42")]
	[AsyncStateMachine(typeof(IJNLAHHOPOE))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> KGDIHJFFGIH(AHPCDKCOAJM<CBPDOKJJLFC> PIOHKEBMBIL, AHPCDKCOAJM<CBPDOKJJLFC> HIMFEKCBCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2301F10", Offset = "0x2301310", VA = "0x182301F10", Slot = "43")]
	[AsyncStateMachine(typeof(KDGIJLJHCCA))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> ONONGONCEDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x22FFCC0", Offset = "0x22FF0C0", VA = "0x1822FFCC0", Slot = "44")]
	[AsyncStateMachine(typeof(ADGHEGLPLGF))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> JCBIBADJDML(string HHFLCHOGNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2301580", Offset = "0x2300980", VA = "0x182301580", Slot = "45")]
	[AsyncStateMachine(typeof(HEAKGMHODNJ))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> NAMOLHANENE(AHPCDKCOAJM<FEHJPJMJDBG> IOOAPHCONAK, string LJAGHAHCFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x22FF440", Offset = "0x22FE840", VA = "0x1822FF440", Slot = "46")]
	[AsyncStateMachine(typeof(KOGCLDNAKOG))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> HHKCILHBEMI(AHPCDKCOAJM<CBPDOKJJLFC> PIOHKEBMBIL, string LJAGHAHCFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x22FEDD0", Offset = "0x22FE1D0", VA = "0x1822FEDD0", Slot = "47")]
	[AsyncStateMachine(typeof(MBIHOLFHLFD))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> GNHJPOFIPLN(AHPCDKCOAJM<FEHJPJMJDBG> IOOAPHCONAK, FJGOBNNFCHJ IFBDJLKPHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2300500", Offset = "0x22FF900", VA = "0x182300500", Slot = "48")]
	[AsyncStateMachine(typeof(LBGPLFCAIGJ))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> KBLMHMECFJN(AHPCDKCOAJM<CBPDOKJJLFC> PIOHKEBMBIL, FJGOBNNFCHJ IFBDJLKPHIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x22FF860", Offset = "0x22FEC60", VA = "0x1822FF860")]
	internal void IJMGNPFJPME(AHPCDKCOAJM<FGCEHDOJGEK> HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class IDFENAAFFDL : CEGJBKIKGBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public interface PGMKMCJMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		public readonly struct KNCBKKGNIPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public readonly IReadOnlyDictionary<PBDBGAKNNHI<PNODKKHPFBO>, Guid>? GNODKIALOPN;

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
			public KNCBKKGNIPO(IReadOnlyDictionary<PBDBGAKNNHI<PNODKKHPFBO>, Guid>? GNODKIALOPN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		NKMPIANNFDJ CKDPAMOFNFL
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<DPCOLNDKMBE> DGDPLDAGOHL(CancellationToken FHGIOBPPFHG);

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<KOLIENJCING> NBJECLMFBGB(CancellationToken FHGIOBPPFHG);

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<GLNMJLGMCJB> GNGCKHABJBG(CancellationToken FHGIOBPPFHG);

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<KNCBKKGNIPO> NNIBPIEFIKF(CancellationToken FHGIOBPPFHG);

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<LNGLPFFEHBL> KOKJGCHLNFB(CancellationToken FHGIOBPPFHG);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct CHPFBMJIDNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<IDFENAAFFDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public DLFOGDDKJHH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public DPCOLNDKMBE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public KOLIENJCING superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private PGMKMCJMCAF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private DPCOLNDKMBE <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private DPCOLNDKMBE <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private LNGLPFFEHBL <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private KOLIENJCING <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private GLNMJLGMCJB <playerSaveData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<DPCOLNDKMBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private DPCOLNDKMBE <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<LNGLPFFEHBL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter<KOLIENJCING> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter<GLNMJLGMCJB> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<PGMKMCJMCAF.KNCBKKGNIPO> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<JFLIKJPNOAH> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x22F6AC0", Offset = "0x22F5EC0", VA = "0x1822F6AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x22F7940", Offset = "0x22F6D40", VA = "0x1822F7940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly JFLIKJPNOAH HHNHJPHKEDE;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public JFLIKJPNOAH MJNACGLJCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	private IDFENAAFFDL(JFLIKJPNOAH EJDFDGMFHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x22FB790", Offset = "0x22FAB90", VA = "0x1822FB790")]
	[AsyncStateMachine(typeof(CHPFBMJIDNF))]
	public static Task<IDFENAAFFDL> MKCPCHIKKCB(DLFOGDDKJHH HCHGEACFMON, DPCOLNDKMBE? JOMOCOIMIGC, KOLIENJCING? EJFFMDCEBKO, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x22FB770", Offset = "0x22FAB70", VA = "0x1822FB770", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public readonly struct NKLJCJFNJFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct BOKNPECBHJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public NKLJCJFNJFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public OCNCAELNEHP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x22F64A0", Offset = "0x22F58A0", VA = "0x1822F64A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x22F6730", Offset = "0x22F5B30", VA = "0x1822F6730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct ILPKPEIBCMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<bool, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public IEBOLOHJJBA rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public DPCOLNDKMBE circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public KOLIENJCING superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public NKLJCJFNJFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private OCNCAELNEHP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x22FBCC0", Offset = "0x22FB0C0", VA = "0x1822FBCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x22FC0A0", Offset = "0x22FB4A0", VA = "0x1822FC0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct HACEENBACKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public NKLJCJFNJFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x22FA7A0", Offset = "0x22F9BA0", VA = "0x1822FA7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x22FA9E0", Offset = "0x22F9DE0", VA = "0x1822FA9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly ACBBHBEPAOE HKMAKJKLPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	public NKLJCJFNJFB(ACBBHBEPAOE GMJOLMHJJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x230D950", Offset = "0x230CD50", VA = "0x18230D950")]
	[AsyncStateMachine(typeof(BOKNPECBHJM))]
	private Task<ABNAGONECLM<object, IAAGGMEHHFI>> OGFCOLMHMDO(OCNCAELNEHP OLHFOBIBHCJ, bool AECCPLEBFJI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x230D700", Offset = "0x230CB00", VA = "0x18230D700")]
	[AsyncStateMachine(typeof(ILPKPEIBCMK))]
	public Task<ABNAGONECLM<bool, IAAGGMEHHFI?>>? DCCJDKPODGN(int IMMAMICNCIE, IEBOLOHJJBA? BNECGPCNHPJ, DPCOLNDKMBE? IKIGPJFOFLK, KOLIENJCING? EJFFMDCEBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x230D860", Offset = "0x230CC60", VA = "0x18230D860")]
	[AsyncStateMachine(typeof(HACEENBACKC))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> DNAOJJGPLEN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public sealed class DNGGBENIHOH : PFPGAAFGKDN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly NHIDCADNLAC EGLKLHFDKNC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public NHIDCADNLAC CLBGBNKNLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	private DNGGBENIHOH(NHIDCADNLAC AJPJBGBKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x22F8F50", Offset = "0x22F8350", VA = "0x1822F8F50")]
	public static DNGGBENIHOH KBLFJIABLOP(DLFOGDDKJHH HCHGEACFMON, IEBOLOHJJBA FBHLKBBCONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x22F8F30", Offset = "0x22F8330", VA = "0x1822F8F30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public interface DOGDCGKEOJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	JFLIKJPNOAH MJNACGLJCFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	FOCCBPILPIJ FKIEEJMMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	GACIGHAKMFC PICCCOOHIAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	NEMJOPFBBEB NNBNBEPPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public interface BGPHAECIAFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	DOGDCGKEOJO? GFPMKOLKEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool NLEOHDLLJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<DOGDCGKEOJO?>? OJOHPKFGMPB();

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LPCJOGFNKJI(DLFOGDDKJHH HCHGEACFMON, IEBOLOHJJBA FBHLKBBCONG, DPCOLNDKMBE? OCCEMKJNPEO, KOLIENJCING? HNEHKNGJDPN);
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ILFPHCBGMJI("IStaticCV2Instance")]
public interface CEGJBKIKGBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	JFLIKJPNOAH MJNACGLJCFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ILFPHCBGMJI("IStaticEVInstance")]
public interface PFPGAAFGKDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	NHIDCADNLAC CLBGBNKNLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class PNJBMPGCJPI
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x230FF40", Offset = "0x230F340", VA = "0x18230FF40")]
	public static HPGGHNPBFOM<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH, IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH>> JLLALMGBNGP([In] this HPGGHNPBFOM<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH, IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH>> NAHEGEFDLNA)
	{
		return default(HPGGHNPBFOM<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH, IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class HDJLABNIDOF : FKHJIHLIDDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly DLFOGDDKJHH DMPLBKKFJEJ;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool NLEOHDLLJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x22FAA50", Offset = "0x22F9E50", VA = "0x1822FAA50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	internal HDJLABNIDOF(DLFOGDDKJHH HCHGEACFMON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal sealed class PEKMEGLGECJ : HGCNJMMOEHM
{
	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x230E7D0", Offset = "0x230DBD0", VA = "0x18230E7D0", Slot = "4")]
	public BAGICPLKCAC? GMNFMIAHKFJ(string? MEGDKFHABBH, string? IJIPJKEGJAL, string? AIEHIKAHEPK, DEENFPNPKMD.DPHIDMLHLLF.HPMMMDBLOHF OJFMKBIGHIJ, bool NNDEBKHPPCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public PEKMEGLGECJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class PHKJNDGJFGK : MOOJGNIOBNC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct JOBOMAIPFAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder<GKJHJDKELLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public PHKJNDGJFGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<DOGDCGKEOJO?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x2303020", Offset = "0x2302420", VA = "0x182303020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x23032B0", Offset = "0x23026B0", VA = "0x1823032B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly DLFOGDDKJHH DMPLBKKFJEJ;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GKJHJDKELLF? ELEBKANKHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x230F270", Offset = "0x230E670", VA = "0x18230F270", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NEMJOPFBBEB? AJMDLOGMABH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x230E870", Offset = "0x230DC70", VA = "0x18230E870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool KEGPDHIBNPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x230F2F0", Offset = "0x230E6F0", VA = "0x18230F2F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool MDJLPAJAEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x230EB80", Offset = "0x230DF80", VA = "0x18230EB80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x230F350", Offset = "0x230E750", VA = "0x18230F350")]
	internal PHKJNDGJFGK(DLFOGDDKJHH HCHGEACFMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x230EA90", Offset = "0x230DE90", VA = "0x18230EA90", Slot = "7")]
	[AsyncStateMachine(typeof(JOBOMAIPFAO))]
	public Task<GKJHJDKELLF> GHMDDNICEDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x230ED80", Offset = "0x230E180", VA = "0x18230ED80", Slot = "9")]
	public IReadOnlyDictionary<PBDBGAKNNHI<PNODKKHPFBO>, Guid> LNPIPFONFAL(IEnumerable<CGBJPDKLJAK> AKIBBBCCJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x230F0F0", Offset = "0x230E4F0", VA = "0x18230F0F0", Slot = "10")]
	public OIMDOEIIJKB MKFENIKAIEN(IEnumerable<CGBJPDKLJAK> AKIBBBCCJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x230EBE0", Offset = "0x230DFE0", VA = "0x18230EBE0")]
	public ABNAGONECLM<GHMMKBGDDED, NAONGKGFBLO> LAPOIFMHOOM([In] GHMMKBGDDED AMHLJAAPDHB)
	{
		return default(ABNAGONECLM<GHMMKBGDDED, NAONGKGFBLO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x230E8F0", Offset = "0x230DCF0", VA = "0x18230E8F0", Slot = "8")]
	private ABNAGONECLM<GHMMKBGDDED, NAONGKGFBLO> BCLMEJACIJM([In] GHMMKBGDDED AMHLJAAPDHB)
	{
		return default(ABNAGONECLM<GHMMKBGDDED, NAONGKGFBLO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class NEMJOPFBBEB : GKJHJDKELLF
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	internal static class PFGLGJCMBLB
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class ABAMDGLDPCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			public JFLIKJPNOAH state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			public DNKFIPMKJGC spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public ABAMDGLDPCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x2312580", Offset = "0x2311980", VA = "0x182312580")]
			internal bool NKNINLICJEC(GAMAOEIHHFE n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class CNDPPIPOJND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public CNDPPIPOJND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x2312C30", Offset = "0x2312030", VA = "0x182312C30")]
			internal void GNBCKIHCGLD(GAMAOEIHHFE n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x23192A0", Offset = "0x23186A0", VA = "0x1823192A0")]
		public static ABNAGONECLM<GKJHJDKELLF.HOJBEDKMCON, MIFFFGJILCH> PKMNDLFOFHF(NEMJOPFBBEB MPLBPEBNKFP, [In] GKJHJDKELLF.HPEEOBFDKOG DCNLGGHAIIP)
		{
			return default(ABNAGONECLM<GKJHJDKELLF.HOJBEDKMCON, MIFFFGJILCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2317F10", Offset = "0x2317310", VA = "0x182317F10")]
		internal static ABNAGONECLM<(ENBLCBONAIJ, AEELEJNLHJA), MIFFFGJILCH> JPICGNMKIAB(NEMJOPFBBEB MPLBPEBNKFP, AEELEJNLHJA EEPLMJHBJFM, bool CJLEOPMPNMI, [In] PBDBGAKNNHI<PNODKKHPFBO> KNNLIAAOOCJ, [In] int? IGIMIJHNMLM, [In] FLFBBNJJMEH? AAGHCOLMCHO, [In] FLFBBNJJMEH? HHKOAJMJIFB)
		{
			return default(ABNAGONECLM<(ENBLCBONAIJ, AEELEJNLHJA), MIFFFGJILCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2318E30", Offset = "0x2318230", VA = "0x182318E30")]
		private static void PGPDGFALFAD(bool CJLEOPMPNMI, CGBJPDKLJAK MMJPLOBEPHL, ENBLCBONAIJ CDJKFANKLJM, [In] PBDBGAKNNHI<PNODKKHPFBO> KNNLIAAOOCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2317B10", Offset = "0x2316F10", VA = "0x182317B10")]
		public static void IKNOAEAODCA(CEILKCBGBFD CPKCBNMIHHI, [In] GKJHJDKELLF.AFFCIIAKIOG GBDKGNGAOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x23179F0", Offset = "0x2316DF0", VA = "0x1823179F0")]
		[CompilerGenerated]
		internal static bool ALPLIFMNEBP(JFLIKJPNOAH NJIJDBHNJLB, DNKFIPMKJGC PFHOLMJNEIF, GAMAOEIHHFE EHBNMBAEGDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x2317AE0", Offset = "0x2316EE0", VA = "0x182317AE0")]
		[CompilerGenerated]
		internal static bool CMFJBPGOPAH(GAMAOEIHHFE AIGKLGGBPNP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct JENNCKAMDMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public NEMJOPFBBEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AHPCDKCOAJM<PNODKKHPFBO> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AHPCDKCOAJM<AMFCOJIMJGL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public NEIHENNLNMK offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2313D00", Offset = "0x2313100", VA = "0x182313D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2313F40", Offset = "0x2313340", VA = "0x182313F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct IDJMHHKGDFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public NEMJOPFBBEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public AHPCDKCOAJM<PNODKKHPFBO> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public PBDBGAKNNHI<AMFCOJIMJGL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public List<AHPCDKCOAJM<AMFCOJIMJGL>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public NEIHENNLNMK localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public EMLOIPKJGKA localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public NEIHENNLNMK offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2313310", Offset = "0x2312710", VA = "0x182313310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x23135D0", Offset = "0x23129D0", VA = "0x1823135D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct AHLOLLHOABJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public NEMJOPFBBEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AHPCDKCOAJM<PNODKKHPFBO> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public PBDBGAKNNHI<AMFCOJIMJGL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public List<AHPCDKCOAJM<AMFCOJIMJGL>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x23126D0", Offset = "0x2311AD0", VA = "0x1823126D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2312910", Offset = "0x2311D10", VA = "0x182312910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct BPACHBNCIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public NEMJOPFBBEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AHPCDKCOAJM<PNODKKHPFBO> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public PBDBGAKNNHI<AMFCOJIMJGL> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public AHPCDKCOAJM<PNODKKHPFBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public List<AHPCDKCOAJM<AMFCOJIMJGL>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x2312980", Offset = "0x2311D80", VA = "0x182312980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2312BC0", Offset = "0x2311FC0", VA = "0x182312BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct NCJDMGJKMED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public NEMJOPFBBEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public AHPCDKCOAJM<PNODKKHPFBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AHPCDKCOAJM<JGJEEGHFLFO> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AHPCDKCOAJM<PLHEEEFNBNK> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2317080", Offset = "0x2316480", VA = "0x182317080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x23176D0", Offset = "0x2316AD0", VA = "0x1823176D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct KGDLNIIICMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public NEMJOPFBBEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public PBDBGAKNNHI<AMFCOJIMJGL> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public PBDBGAKNNHI<PNODKKHPFBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AHPCDKCOAJM<FGCEHDOJGEK> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AHPCDKCOAJM<DPLMPJGGPFN> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2314470", Offset = "0x2313870", VA = "0x182314470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x23147B0", Offset = "0x2313BB0", VA = "0x1823147B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct KABNKKONOEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public NEMJOPFBBEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public PBDBGAKNNHI<AMFCOJIMJGL> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public PBDBGAKNNHI<PNODKKHPFBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AHPCDKCOAJM<FGCEHDOJGEK> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AHPCDKCOAJM<JFFAPEFODIA> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x23140C0", Offset = "0x23134C0", VA = "0x1823140C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2314400", Offset = "0x2313800", VA = "0x182314400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private readonly DLFOGDDKJHH DMPLBKKFJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private readonly CEGJBKIKGBB LDLPBPGHEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private readonly PFPGAAFGKDN OFHFLNJIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private readonly OABHHDJEDJD BHMECJFFMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly PHKJNDGJFGK KMMAIGAOEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private Dictionary<PBDBGAKNNHI<AMFCOJIMJGL>, OAIONGHIMFG> LLCHNCBMELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[CompilerGenerated]
	private Action<PBDBGAKNNHI<AMFCOJIMJGL>>? OBMBPBCPMJE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public PBDBGAKNNHI<PNODKKHPFBO> NBFLHEMBMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x2308A70", Offset = "0x2307E70", VA = "0x182308A70", Slot = "4")]
		get
		{
			return default(PBDBGAKNNHI<PNODKKHPFBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public OABHHDJEDJD CJLBJLMIBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x22DCEB0", Offset = "0x22DC2B0", VA = "0x1822DCEB0", Slot = "5")]
		get
		{
			return default(OABHHDJEDJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x230C6D0", Offset = "0x230BAD0", VA = "0x18230C6D0")]
	public NEMJOPFBBEB(DLFOGDDKJHH HCHGEACFMON, CEGJBKIKGBB KAMPLKLCGEG, PFPGAAFGKDN JNGLNCIGJCC, PHKJNDGJFGK LIBAKGBJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2308CC0", Offset = "0x23080C0", VA = "0x182308CC0", Slot = "61")]
	public AHPCDKCOAJM<JIJMEHHKNOE> FMEOEJCNIMC(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(AHPCDKCOAJM<JIJMEHHKNOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x230A630", Offset = "0x2309A30", VA = "0x18230A630", Slot = "62")]
	public AHPCDKCOAJM<NDHPMKFGFLB> LBPMMHODDJB(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(AHPCDKCOAJM<NDHPMKFGFLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2308350", Offset = "0x2307750", VA = "0x182308350", Slot = "6")]
	public (bool, bool) EFLFHOOOCED(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<JGJEEGHFLFO> FOKGOFPCJND, AHPCDKCOAJM<PLHEEEFNBNK> ACPIEDANBLP)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2309CD0", Offset = "0x23090D0", VA = "0x182309CD0")]
	public bool JKINLNBNLNL(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, [In] FALDAGKKOFH COMDPEEFNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x230A060", Offset = "0x2309460", VA = "0x18230A060", Slot = "8")]
	public bool KAMGEKPENEO(OIOMPGFJCEO MBFKCDOIMBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x230A5B0", Offset = "0x23099B0", VA = "0x18230A5B0", Slot = "9")]
	public bool KHCMLNNBJAF(CAENPNJFLFG LDLCNNCDMDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2307260", Offset = "0x2306660", VA = "0x182307260", Slot = "10")]
	public IHFKDBDNGHF? CFFLGJIGBID(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2307070", Offset = "0x2306470", VA = "0x182307070", Slot = "11")]
	public BDJPCBKAAIM? BPFHLJFADLN(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2308E50", Offset = "0x2308250", VA = "0x182308E50", Slot = "12")]
	public AHPCDKCOAJM<JGJEEGHFLFO>? GBFAKODEEKG(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, AHPCDKCOAJM<JFFAPEFODIA> HCBBANBCILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2306280", Offset = "0x2305680", VA = "0x182306280", Slot = "13")]
	public AHPCDKCOAJM<PLHEEEFNBNK>? AMLONLMDJMA(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, AHPCDKCOAJM<DPLMPJGGPFN> IJNJJIFCDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x230C5B0", Offset = "0x230B9B0", VA = "0x18230C5B0", Slot = "14")]
	public IEnumerable<AHPCDKCOAJM<PNODKKHPFBO>> PECCCGMOLBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2307130", Offset = "0x2306530", VA = "0x182307130", Slot = "15")]
	public IEnumerable<AHPCDKCOAJM<CMGAOJFHHIL>> CAHFKFJAHKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2305FA0", Offset = "0x23053A0", VA = "0x182305FA0", Slot = "16")]
	public string AGOENALAICD(AHPCDKCOAJM<CMGAOJFHHIL> CADIBNGBFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x230C0C0", Offset = "0x230B4C0", VA = "0x18230C0C0", Slot = "17")]
	public string NONKECBPLLO(AHPCDKCOAJM<CMGAOJFHHIL> CADIBNGBFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2306690", Offset = "0x2305A90", VA = "0x182306690")]
	public OAIONGHIMFG? BHNNLHCBDHL([In] PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2307320", Offset = "0x2306720", VA = "0x182307320", Slot = "23")]
	public AHPCDKCOAJM<CCPDCNPKMEJ> CFKPAAPEONA(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default(AHPCDKCOAJM<CCPDCNPKMEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2308D40", Offset = "0x2308140", VA = "0x182308D40")]
	public AHPCDKCOAJM<AMFCOJIMJGL> FMIOCFNJJBK(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, [In] PBDBGAKNNHI<AMFCOJIMJGL> LIMGNHDJFAN)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2308F40", Offset = "0x2308340", VA = "0x182308F40", Slot = "33")]
	public AHPCDKCOAJM<AMFCOJIMJGL> GGLBMDOBHLF(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x2306FF0", Offset = "0x23063F0", VA = "0x182306FF0", Slot = "34")]
	public AHPCDKCOAJM<AMFCOJIMJGL> BOGAADMKFIB(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2306800", Offset = "0x2305C00", VA = "0x182306800", Slot = "25")]
	public KDOLOHOEFDK? BLDIAKGGKFF(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2308A10", Offset = "0x2307E10", VA = "0x182308A10", Slot = "26")]
	public long ENKKBAGHEME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x230BA20", Offset = "0x230AE20", VA = "0x18230BA20")]
	private void NMJEHJENAKH(PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2308AD0", Offset = "0x2307ED0", VA = "0x182308AD0", Slot = "31")]
	public IEnumerable<(AHPCDKCOAJM<PNODKKHPFBO>, AHPCDKCOAJM<AMFCOJIMJGL>)> FDFCKDDCMBC(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x23061F0", Offset = "0x23055F0", VA = "0x1823061F0", Slot = "32")]
	public AHPCDKCOAJM<PLHEEEFNBNK> AMLONLMDJMA(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<JIJMEHHKNOE> IJNJJIFCDBB)
	{
		return default(AHPCDKCOAJM<PLHEEEFNBNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2308DC0", Offset = "0x23081C0", VA = "0x182308DC0", Slot = "35")]
	public AHPCDKCOAJM<JGJEEGHFLFO> GBFAKODEEKG(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<NDHPMKFGFLB> HCBBANBCILK)
	{
		return default(AHPCDKCOAJM<JGJEEGHFLFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x230B550", Offset = "0x230A950", VA = "0x18230B550")]
	private OAIONGHIMFG? MBKIKEEGLKL([In] PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x230C640", Offset = "0x230BA40", VA = "0x18230C640")]
	public FAKCDJHFJMO? PNADCHDMAGJ([In] PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x23090E0", Offset = "0x23084E0", VA = "0x1823090E0")]
	public KCEKFMOEPNL? LGOENODMPBP([In] PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x230B490", Offset = "0x230A890", VA = "0x18230B490", Slot = "27")]
	public IEnumerable<DJLKPLHDEAP> MACOBCNKFCL(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x230A0E0", Offset = "0x23094E0", VA = "0x18230A0E0", Slot = "28")]
	public bool KEJLKLPEBBC(AHPCDKCOAJM<CMGAOJFHHIL> CADIBNGBFHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x230BAB0", Offset = "0x230AEB0", VA = "0x18230BAB0", Slot = "29")]
	public IEnumerable<FALDAGKKOFH> NOFCBCJDIGJ(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<JGJEEGHFLFO> FOKGOFPCJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x230B600", Offset = "0x230AA00", VA = "0x18230B600", Slot = "30")]
	public IEnumerable<FALDAGKKOFH> NCEIJMFILOH(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<PLHEEEFNBNK> ACPIEDANBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2306010", Offset = "0x2305410", VA = "0x182306010")]
	public AHPCDKCOAJM<PNODKKHPFBO> POKGFGEBOJC([In] PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return default(AHPCDKCOAJM<PNODKKHPFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x230B300", Offset = "0x230A700", VA = "0x18230B300")]
	public AHPCDKCOAJM<PNODKKHPFBO>? LKMOCHHDNCE([In] PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2307740", Offset = "0x2306B40", VA = "0x182307740")]
	private DNKFIPMKJGC? CNEEJHDOIBG([In] PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x23090E0", Offset = "0x23084E0", VA = "0x1823090E0")]
	private KCEKFMOEPNL? HAKAAACNEOI([In] PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2308B80", Offset = "0x2307F80", VA = "0x182308B80", Slot = "21")]
	public AHPCDKCOAJM<PNODKKHPFBO>? FHCMAGJHFPP(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2309490", Offset = "0x2308890", VA = "0x182309490", Slot = "39")]
	public PBDBGAKNNHI<PNODKKHPFBO> HLINKPDBNHB(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return default(PBDBGAKNNHI<PNODKKHPFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x230B380", Offset = "0x230A780", VA = "0x18230B380", Slot = "36")]
	public IEnumerable<FJGOBNNFCHJ> LNDGJHDMJIG(GPIDPMAKAJP EHGGCPPFMKH, bool JFLCLIAJENP, bool NDKPGGJDKBP, bool JJJLLGJPPIA, bool PNKDDBMKKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2306390", Offset = "0x2305790", VA = "0x182306390", Slot = "37")]
	public FJGOBNNFCHJ BEODCBAJCFM(GPIDPMAKAJP EHGGCPPFMKH, JIJMCDJACFB DNCOIHJDANB, bool JFLCLIAJENP, bool NDKPGGJDKBP, bool JJJLLGJPPIA, bool PNKDDBMKKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x23073A0", Offset = "0x23067A0", VA = "0x1823073A0")]
	public DJLKPLHDEAP PHKLMDMEKDP(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, [In] FALDAGKKOFH COMDPEEFNOC)
	{
		return default(DJLKPLHDEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2307510", Offset = "0x2306910", VA = "0x182307510", Slot = "40")]
	public FALDAGKKOFH CMLPIIEBPGE(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<JGJEEGHFLFO> FOKGOFPCJND, AHPCDKCOAJM<PLHEEEFNBNK> ACPIEDANBLP)
	{
		return default(FALDAGKKOFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x23099A0", Offset = "0x2308DA0", VA = "0x1823099A0", Slot = "41")]
	[AsyncStateMachine(typeof(JENNCKAMDMJ))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> IIEBIAHJCMN(AHPCDKCOAJM<PNODKKHPFBO> PDCJKIFBEGI, AHPCDKCOAJM<AMFCOJIMJGL> NFAELOKOANI, NEIHENNLNMK LHBPAMEKCBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x23091B0", Offset = "0x23085B0", VA = "0x1823091B0", Slot = "42")]
	[AsyncStateMachine(typeof(IDJMHHKGDFM))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> HDPLJHOHHKH(AHPCDKCOAJM<PNODKKHPFBO> PDCJKIFBEGI, PBDBGAKNNHI<AMFCOJIMJGL> NFAELOKOANI, List<AHPCDKCOAJM<AMFCOJIMJGL>> ECPIKMGHBDF, NEIHENNLNMK FNPCHBFENHG, EMLOIPKJGKA FIHDJHFCLDC, NEIHENNLNMK LHBPAMEKCBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2308850", Offset = "0x2307C50", VA = "0x182308850", Slot = "43")]
	[AsyncStateMachine(typeof(AHLOLLHOABJ))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> EJAEDKFHMME(AHPCDKCOAJM<PNODKKHPFBO> PDCJKIFBEGI, PBDBGAKNNHI<AMFCOJIMJGL> NFAELOKOANI, List<AHPCDKCOAJM<AMFCOJIMJGL>> ECPIKMGHBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2309B40", Offset = "0x2308F40", VA = "0x182309B40", Slot = "44")]
	[AsyncStateMachine(typeof(BPACHBNCIDK))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> JFJDCHBJPKI(AHPCDKCOAJM<PNODKKHPFBO> PDCJKIFBEGI, PBDBGAKNNHI<AMFCOJIMJGL> NFAELOKOANI, AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, List<AHPCDKCOAJM<AMFCOJIMJGL>> ECPIKMGHBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2309930", Offset = "0x2308D30", VA = "0x182309930", Slot = "45")]
	public bool IGOIPLHFFJG(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x23071E0", Offset = "0x23065E0", VA = "0x1823071E0", Slot = "46")]
	public bool CAMBGBIMIID(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2306310", Offset = "0x2305710", VA = "0x182306310", Slot = "47")]
	public bool BBBMMKEDFIL(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2309CA0", Offset = "0x23090A0", VA = "0x182309CA0")]
	public ABNAGONECLM<GKJHJDKELLF.HOJBEDKMCON, MIFFFGJILCH> NCAOGHCNHAC([In] GKJHJDKELLF.HPEEOBFDKOG DCNLGGHAIIP)
	{
		return default(ABNAGONECLM<GKJHJDKELLF.HOJBEDKMCON, MIFFFGJILCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x230B1D0", Offset = "0x230A5D0", VA = "0x18230B1D0", Slot = "49")]
	[AsyncStateMachine(typeof(NCJDMGJKMED))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> LKENBNMICPD(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<JGJEEGHFLFO> FOKGOFPCJND, AHPCDKCOAJM<PLHEEEFNBNK> ACPIEDANBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2309500", Offset = "0x2308900", VA = "0x182309500", Slot = "50")]
	public ABNAGONECLM<JJEOHLGIIJN, NAONGKGFBLO> HNFLLCCBKCI(PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD, JJEOHLGIIJN PFCIFBNKFNN, EMLOIPKJGKA IJEADAJOBIN)
	{
		return default(ABNAGONECLM<JJEOHLGIIJN, NAONGKGFBLO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2309330", Offset = "0x2308730", VA = "0x182309330", Slot = "51")]
	[AsyncStateMachine(typeof(KGDLNIIICMB))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> HGCCIICPLLC(PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD, PBDBGAKNNHI<AMFCOJIMJGL> CIGLIFNLGKC, AHPCDKCOAJM<FGCEHDOJGEK> GDAMHFCHINH, AHPCDKCOAJM<DPLMPJGGPFN> AFJGGPEMBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2306090", Offset = "0x2305490", VA = "0x182306090", Slot = "52")]
	[AsyncStateMachine(typeof(KABNKKONOEH))]
	public Task<ABNAGONECLM<ALHKDJHEAFJ, IAAGGMEHHFI>> ALMEHNLFHDL(PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD, PBDBGAKNNHI<AMFCOJIMJGL> MLKNJDJNFDM, AHPCDKCOAJM<FGCEHDOJGEK> MMEOHKFNGJJ, AHPCDKCOAJM<JFFAPEFODIA> MLIAJGPJJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x230B900", Offset = "0x230AD00", VA = "0x18230B900", Slot = "53")]
	public NAGIBPJJANK NLDOJKAFNIE()
	{
		return default(NAGIBPJJANK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2308FC0", Offset = "0x23083C0", VA = "0x182308FC0", Slot = "54")]
	public NAGIBPJJANK GIEENAOEBCN()
	{
		return default(NAGIBPJJANK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x230A170", Offset = "0x2309570", VA = "0x18230A170")]
	private KEDPOBIIOOJ KGPKFPCGLHA(CIJDAANHOKH EEEBKDEJDEA, AHPCDKCOAJM<PNODKKHPFBO> HDCHPLOFPMJ, IEnumerable<PBDBGAKNNHI<PNODKKHPFBO>> LLOLABKOJNM, IEnumerable<PBDBGAKNNHI<AMFCOJIMJGL>> ECPIKMGHBDF)
	{
		return default(KEDPOBIIOOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x230A320", Offset = "0x2309720", VA = "0x18230A320", Slot = "55")]
	public KEDPOBIIOOJ KGPKFPCGLHA(CIJDAANHOKH EEEBKDEJDEA, AHPCDKCOAJM<PNODKKHPFBO> HDCHPLOFPMJ, IEnumerable<PBDBGAKNNHI<AMFCOJIMJGL>> ECPIKMGHBDF, IEnumerable<CGBJPDKLJAK> LLLHMPGFCPE)
	{
		return default(KEDPOBIIOOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x230BD40", Offset = "0x230B140", VA = "0x18230BD40")]
	private static IEnumerable<PBDBGAKNNHI<PNODKKHPFBO>> NOHIHOIGMML(IEnumerable<CGBJPDKLJAK> LLLHMPGFCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x230C130", Offset = "0x230B530", VA = "0x18230C130")]
	private IEnumerable<PBDBGAKNNHI<AMFCOJIMJGL>> OEFGOKLKGJI(IEnumerable<CGBJPDKLJAK> LLLHMPGFCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x23082C0", Offset = "0x23076C0", VA = "0x1823082C0", Slot = "56")]
	public List<JCNKLKGJDPP> EDNMHMPNAKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2306930", Offset = "0x2305D30", VA = "0x182306930")]
	public (List<JCNKLKGJDPP>, bool) BNKNLCJBPNB([In] BBDONIBMILN CJIIAMGOAPJ, string NOIHGGNEIML, [In] DOCLOKBDNIJ BNJGMNCEDGM, LFEABJHBDEJ APGHBKBFKNI, CDMLGEJHGKL GCIJGLHENDE)
	{
		return default((List<JCNKLKGJDPP>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x23081D0", Offset = "0x23075D0", VA = "0x1823081D0", Slot = "58")]
	public bool EBBBHIPCNDA(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2309AE0", Offset = "0x2308EE0", VA = "0x182309AE0")]
	internal void IINHPCNEMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x230A000", Offset = "0x2309400", VA = "0x18230A000")]
	internal Task JOGLBJHEPGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2307800", Offset = "0x2306C00", VA = "0x182307800", Slot = "59")]
	public ABNAGONECLM<AHPCDKCOAJM<JGJEEGHFLFO>?, IAAGGMEHHFI> DENLCELBLNO(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<PLHEEEFNBNK> AFJGGPEMBOM)
	{
		return default(ABNAGONECLM<AHPCDKCOAJM<JGJEEGHFLFO>?, IAAGGMEHHFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x230A6B0", Offset = "0x2309AB0", VA = "0x18230A6B0", Slot = "60")]
	public ABNAGONECLM<AHPCDKCOAJM<PLHEEEFNBNK>?, IAAGGMEHHFI> LCPEJDGNAPL(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<JGJEEGHFLFO> MLIAJGPJJLE)
	{
		return default(ABNAGONECLM<AHPCDKCOAJM<PLHEEEFNBNK>?, IAAGGMEHHFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x230B480", Offset = "0x230A880", VA = "0x18230B480", Slot = "7")]
	private bool LPFMJPIFKLN(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, [In] FALDAGKKOFH COMDPEEFNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2308CB0", Offset = "0x23080B0", VA = "0x182308CB0", Slot = "18")]
	private KCEKFMOEPNL FIJDEEBPLLB([In] PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2306010", Offset = "0x2305410", VA = "0x182306010", Slot = "19")]
	private AHPCDKCOAJM<PNODKKHPFBO> AJIMGPPMDOL([In] PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return default(AHPCDKCOAJM<PNODKKHPFBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x230B300", Offset = "0x230A700", VA = "0x18230B300", Slot = "20")]
	private AHPCDKCOAJM<PNODKKHPFBO>? PIJIDKLJHAO([In] PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x230B080", Offset = "0x230A480", VA = "0x18230B080", Slot = "22")]
	private OAIONGHIMFG LFKOGFAJPNK([In] PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2308D40", Offset = "0x2308140", VA = "0x182308D40", Slot = "24")]
	private AHPCDKCOAJM<AMFCOJIMJGL> PKOEBOGGFGN(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, [In] PBDBGAKNNHI<AMFCOJIMJGL> LIMGNHDJFAN)
	{
		return default(AHPCDKCOAJM<AMFCOJIMJGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x23073A0", Offset = "0x23067A0", VA = "0x1823073A0", Slot = "38")]
	private DJLKPLHDEAP CJLPLMJBGJA(AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, [In] FALDAGKKOFH COMDPEEFNOC)
	{
		return default(DJLKPLHDEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2309CA0", Offset = "0x23090A0", VA = "0x182309CA0", Slot = "48")]
	private ABNAGONECLM<GKJHJDKELLF.HOJBEDKMCON, MIFFFGJILCH> JJGDPDIIGDI([In] GKJHJDKELLF.HPEEOBFDKOG DCNLGGHAIIP)
	{
		return default(ABNAGONECLM<GKJHJDKELLF.HOJBEDKMCON, MIFFFGJILCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2308EE0", Offset = "0x23082E0", VA = "0x182308EE0", Slot = "57")]
	private (List<JCNKLKGJDPP>, bool) GFAGPJMDOIN([In] BBDONIBMILN CJIIAMGOAPJ, string NOIHGGNEIML, [In] DOCLOKBDNIJ BNJGMNCEDGM, LFEABJHBDEJ APGHBKBFKNI, CDMLGEJHGKL GCIJGLHENDE)
	{
		return default((List<JCNKLKGJDPP>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x230B880", Offset = "0x230AC80", VA = "0x18230B880")]
	[CompilerGenerated]
	private IJLCFNKLCPK NIDDEGKPICE(HBNOCLDLIEG IBIAGDBMPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x23098C0", Offset = "0x2308CC0", VA = "0x1823098C0")]
	[CompilerGenerated]
	private FAKCDJHFJMO ICHEHINKBFJ(PBDBGAKNNHI<AMFCOJIMJGL> IBIAGDBMPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x23089A0", Offset = "0x2307DA0", VA = "0x1823089A0")]
	[CompilerGenerated]
	private DNKFIPMKJGC EMHBPLMNKJP(PBDBGAKNNHI<PNODKKHPFBO> IBIAGDBMPOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class IJLCFNKLCPK : FJGOBNNFCHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct EHLPIOHOMFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<AHPCDKCOAJM<FEHJPJMJDBG>, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public IJLCFNKLCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public PBDBGAKNNHI<PNODKKHPFBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public PBDBGAKNNHI<AMFCOJIMJGL> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AHPCDKCOAJM<FGCEHDOJGEK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private TaskAwaiter<ABNAGONECLM<AHPCDKCOAJM<FEHJPJMJDBG>, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x2312DA0", Offset = "0x23121A0", VA = "0x182312DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2313020", Offset = "0x2312420", VA = "0x182313020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct POCCHANHCNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<AHPCDKCOAJM<CBPDOKJJLFC>, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public IJLCFNKLCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public PBDBGAKNNHI<PNODKKHPFBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public PBDBGAKNNHI<AMFCOJIMJGL> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AHPCDKCOAJM<FGCEHDOJGEK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter<ABNAGONECLM<AHPCDKCOAJM<CBPDOKJJLFC>, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x23197E0", Offset = "0x2318BE0", VA = "0x1823197E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2319A60", Offset = "0x2318E60", VA = "0x182319A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private readonly HBNOCLDLIEG PFGKNPAAEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly CEGJBKIKGBB LDLPBPGHEOI;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public TypeKey LPLJOIHAGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string MAADDMEGAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x23137B0", Offset = "0x2312BB0", VA = "0x1823137B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public HBNOCLDLIEG LHLNMLCMMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2313950", Offset = "0x2312D50", VA = "0x182313950")]
	public IJLCFNKLCPK(HBNOCLDLIEG OJMKJPBMELN, CEGJBKIKGBB KAMPLKLCGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2313640", Offset = "0x2312A40", VA = "0x182313640", Slot = "6")]
	[AsyncStateMachine(typeof(EHLPIOHOMFB))]
	public Task<ABNAGONECLM<AHPCDKCOAJM<FEHJPJMJDBG>, IAAGGMEHHFI>> EAEEPDMMEMC(PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD, PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, string LJAGHAHCFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x23137E0", Offset = "0x2312BE0", VA = "0x1823137E0", Slot = "7")]
	[AsyncStateMachine(typeof(POCCHANHCNP))]
	public Task<ABNAGONECLM<AHPCDKCOAJM<CBPDOKJJLFC>, IAAGGMEHHFI>> HPNLPPPGIGB(PBDBGAKNNHI<PNODKKHPFBO> PAAPGLCPIFD, PBDBGAKNNHI<AMFCOJIMJGL> DOKBOJKBDAO, AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO, string LJAGHAHCFHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class LHCPNBCLHEF : DJLAMLMHKCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly HBNOCLDLIEG ICFOFAMGABF;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private static readonly HashSet<HBNOCLDLIEG> JIIMPLAEGAD;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private static readonly HashSet<HBNOCLDLIEG> MNIINDMAADG;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly HashSet<HBNOCLDLIEG> GPNPFENKMEL;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public TypeKey ECHGIIKNGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2316C50", Offset = "0x2316050", VA = "0x182316C50", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool BDNCDPBJGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2316C40", Offset = "0x2316040", VA = "0x182316C40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool OBHEKLJKBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2316CA0", Offset = "0x23160A0", VA = "0x182316CA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool FCCPOFDPFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2316BC0", Offset = "0x2315FC0", VA = "0x182316BC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x23156F0", Offset = "0x2314AF0", VA = "0x1823156F0")]
	public bool DCAGAHHIACK(string HCPAOILCJCB, [Out] FBKJLOKIAJJ OBJFFCAKECH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public LHCPNBCLHEF(HBNOCLDLIEG HKNABNLJGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2315960", Offset = "0x2314D60", VA = "0x182315960")]
	internal static TypeKey HEGNHJDCBKI(HBNOCLDLIEG IFBDJLKPHIG)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x23137B0", Offset = "0x2312BB0", VA = "0x1823137B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public readonly struct CNIFFDHKLIO : KKLBFHFGGKP.DLLOBHHPIKL<OCNCAELNEHP, ALHKDJHEAFJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2312CF0", Offset = "0x23120F0", VA = "0x182312CF0", Slot = "4")]
	public int JEJCANPELGG(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2312D50", Offset = "0x2312150", VA = "0x182312D50", Slot = "5")]
	public OCNCAELNEHP LHBEKALPJJH(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2312C90", Offset = "0x2312090", VA = "0x182312C90", Slot = "6")]
	public OCNCAELNEHP GHPBCHIBMKJ(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2312C50", Offset = "0x2312050", VA = "0x182312C50", Slot = "7")]
	public IReadOnlyList<OCNCAELNEHP> AGCHFLFECOM(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2312CC0", Offset = "0x23120C0", VA = "0x182312CC0", Slot = "8")]
	public OCNCAELNEHP[] IFABCMMHNCD(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ, int CKLLDOCGFDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2312C70", Offset = "0x2312070", VA = "0x182312C70", Slot = "9")]
	public bool BCBDDPFOOMF(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2312D10", Offset = "0x2312110", VA = "0x182312D10", Slot = "10")]
	public bool JGDMGPPOAID(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2312D80", Offset = "0x2312180", VA = "0x182312D80", Slot = "11")]
	public bool OLADNCOAAFH(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2312D30", Offset = "0x2312130", VA = "0x182312D30", Slot = "12")]
	public bool JLNAAFAIOPD(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2312D60", Offset = "0x2312160", VA = "0x182312D60", Slot = "13")]
	public bool LIKJIJKKKOJ(ALHKDJHEAFJ LGKJMLLHKCN, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2312CD0", Offset = "0x23120D0", VA = "0x182312CD0", Slot = "14")]
	public bool IHFHHIHGGEF(ALHKDJHEAFJ PGHMIFOEHOF, OCNCAELNEHP OLHFOBIBHCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public abstract class GAGDPIEIMAM : DPIOAKOAPGI
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public EGFCEIPNOCE.ECIHMKIHNGK HPJLKGICGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x23130E0", Offset = "0x23124E0", VA = "0x1823130E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract CMPKJCBJJIB.DJCGFLIGCGK JPKGNEPBJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract DLFOGDDKJHH.DEAGPLPGJBD KMEJAKABODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract IDFENAAFFDL.PGMKMCJMCAF HDIDJJFIGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IEOOEIMIMBE.BMBJHFCAIBG<FEAPAONCDCL, OCNCAELNEHP, DLFOGDDKJHH> HKFCKEFEHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2313090", Offset = "0x2312490", VA = "0x182313090", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract GDCDMFKBBJH LBPOJHPBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract ABLKNGGHEGN DHACIKOIFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract GPCNNNDNPHP JCIKIBJDNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract BLIECBOGFEI FOODMHICIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract PFJEOGKCODF KHNMNDANFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	protected GAGDPIEIMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class LKOKOIPFOGD : INFBDNJCIDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct IOEHPJPAOCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public LKOKOIPFOGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public OCNCAELNEHP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x23139F0", Offset = "0x2312DF0", VA = "0x1823139F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2313C90", Offset = "0x2313090", VA = "0x182313C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct KMLCJCLBLCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<NDLCFMMJECI, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public LKOKOIPFOGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public IReadOnlyList<OCNCAELNEHP> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2314A10", Offset = "0x2313E10", VA = "0x182314A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2314D90", Offset = "0x2314190", VA = "0x182314D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private readonly ACBBHBEPAOE HKMAKJKLPDJ;

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public LKOKOIPFOGD(ACBBHBEPAOE GMJOLMHJJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x2316EF0", Offset = "0x23162F0", VA = "0x182316EF0")]
	[AsyncStateMachine(typeof(IOEHPJPAOCK))]
	private Task<ABNAGONECLM<object, IAAGGMEHHFI>> OGFCOLMHMDO(OCNCAELNEHP OLHFOBIBHCJ, bool AECCPLEBFJI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2316DC0", Offset = "0x23161C0", VA = "0x182316DC0", Slot = "4")]
	[AsyncStateMachine(typeof(KMLCJCLBLCH))]
	public Task<ABNAGONECLM<NDLCFMMJECI, IAAGGMEHHFI>> NFFOCMAPNGE(IReadOnlyList<OCNCAELNEHP> GAEGLPHPPHO, bool AECCPLEBFJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct AHEDCMAIFIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	internal FLNEFILAEJL<BKDLFMCMHNE, PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA>, OCNCAELNEHP, KGPMGLPHHGC> ICFOFAMGABF;

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x22DF670", Offset = "0x22DEA70", VA = "0x1822DF670")]
	private AHEDCMAIFIA([In] FLNEFILAEJL<BKDLFMCMHNE, PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA>, OCNCAELNEHP, KGPMGLPHHGC> LDCJDJMCCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2312670", Offset = "0x2311A70", VA = "0x182312670")]
	public static AHEDCMAIFIA ODOFIFAGLAJ()
	{
		return default(AHEDCMAIFIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public static class FGCCCMLKMKK
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static FLNEFILAEJL<BKDLFMCMHNE, PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA>, OCNCAELNEHP, KGPMGLPHHGC> HEJPNBNFFBD(this AHEDCMAIFIA MPLBPEBNKFP)
	{
		return default(FLNEFILAEJL<BKDLFMCMHNE, PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA>, OCNCAELNEHP, KGPMGLPHHGC>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public struct KGPMGLPHHGC : ADBLJHAIMGH.CPAHDHBOHHN<BKDLFMCMHNE, PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA>, OCNCAELNEHP>
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2314820", Offset = "0x2313C20", VA = "0x182314820", Slot = "7")]
	public OCNCAELNEHP BNIIOLMLNKD(BKDLFMCMHNE[] KKNMPCLHGNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x14A2170", Offset = "0x14A1570", VA = "0x1814A2170")]
	public PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA> FGFALFHCJEF([In] BKDLFMCMHNE BKMJPEKIFBP)
	{
		return default(PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0xC8F350", Offset = "0xC8E750", VA = "0x180C8F350")]
	public int KPDLEJHHFIM([In] BKDLFMCMHNE CONAAJKMBJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x2314A00", Offset = "0x2313E00", VA = "0x182314A00")]
	public int JDPKJCHNKBI([In] BKDLFMCMHNE BKMJPEKIFBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0xC8F350", Offset = "0xC8E750", VA = "0x180C8F350", Slot = "4")]
	private int MLGGFFJACLF([In] BKDLFMCMHNE BKMJPEKIFBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2314A00", Offset = "0x2313E00", VA = "0x182314A00", Slot = "5")]
	private int HOGKHEDIAPD([In] BKDLFMCMHNE BKMJPEKIFBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x14A2170", Offset = "0x14A1570", VA = "0x1814A2170", Slot = "6")]
	private PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA> NAHPKDCKJAJ([In] BKDLFMCMHNE BKMJPEKIFBP)
	{
		return default(PBDBGAKNNHI<BKDLFMCMHNE.OIKABFOHPOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public struct MBIBIFFDFLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	internal GMPCAACGKJP<FMBNIOOJGFJ, OCNCAELNEHP, GLNBJFKOMKG> ICFOFAMGABF;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x22DF670", Offset = "0x22DEA70", VA = "0x1822DF670")]
	private MBIBIFFDFLJ([In] GMPCAACGKJP<FMBNIOOJGFJ, OCNCAELNEHP, GLNBJFKOMKG> DNNJGGFGMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2317020", Offset = "0x2316420", VA = "0x182317020")]
	public static MBIBIFFDFLJ ODOFIFAGLAJ()
	{
		return default(MBIBIFFDFLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public static class JBEMLBJJNOI
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static GMPCAACGKJP<FMBNIOOJGFJ, OCNCAELNEHP, GLNBJFKOMKG> HEJPNBNFFBD(this MBIBIFFDFLJ MPLBPEBNKFP)
	{
		return default(GMPCAACGKJP<FMBNIOOJGFJ, OCNCAELNEHP, GLNBJFKOMKG>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct GLNBJFKOMKG : DDEEBJIOBPL.MFCHOLONLOD<FMBNIOOJGFJ, OCNCAELNEHP>
{
	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x1B43AD0", Offset = "0x1B42ED0", VA = "0x181B43AD0")]
	public int KFNJGJCBCON([In] FMBNIOOJGFJ CONAAJKMBJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x2313130", Offset = "0x2312530", VA = "0x182313130", Slot = "5")]
	public OCNCAELNEHP CCNPAKJBKPC(FMBNIOOJGFJ[] GBGOJPLMHPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x1B43AD0", Offset = "0x1B42ED0", VA = "0x181B43AD0", Slot = "4")]
	private int EMFJNGFCBBK([In] FMBNIOOJGFJ CONAAJKMBJN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class OIBNEDKMLOO : PJPEMJHFJLC, MIFFFGJILCH, IAAGGMEHHFI, NAONGKGFBLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly NAONGKGFBLO? GGEDMBEGHKE;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public EENFBDCNHOM IJBNJPNGFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(EENFBDCNHOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C60", Offset = "0x8C8060", VA = "0x1808C8C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override NAONGKGFBLO? HDDABNLPGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x23178A0", Offset = "0x2316CA0", VA = "0x1823178A0", Slot = "7")]
	public override string MMDDBBBPGKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x23179B0", Offset = "0x2316DB0", VA = "0x1823179B0")]
	private OIBNEDKMLOO(EENFBDCNHOM HBOEBNCIJMJ, NAONGKGFBLO? KBDNPFMPOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x2317740", Offset = "0x2316B40", VA = "0x182317740")]
	public static OIBNEDKMLOO FDBAIPAOFBM(NAONGKGFBLO KBDNPFMPOEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x23177C0", Offset = "0x2316BC0", VA = "0x1823177C0")]
	public static OIBNEDKMLOO FDOOHEIOBEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x2317830", Offset = "0x2316C30", VA = "0x182317830")]
	public static OIBNEDKMLOO MBOGHLIBLJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public static class ICPNJLKLBCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x3090A70", Offset = "0x308FE70", VA = "0x183090A70")]
	public static ABNAGONECLM<TOk, MIFFFGJILCH> IPJCMBHBCFF<TOk>([In] this ABNAGONECLM<TOk, MIFFFGJILCH> MPLBPEBNKFP, NAONGKGFBLO KBDNPFMPOEG) where TOk : notnull
	{
		return default(ABNAGONECLM<TOk, MIFFFGJILCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x3090B50", Offset = "0x308FF50", VA = "0x183090B50")]
	public static ABNAGONECLM<TOk?, MIFFFGJILCH?> JPJFAGIAACL<TOk>([In] this ABNAGONECLM<TOk, MIFFFGJILCH> MPLBPEBNKFP)
	{
		return default(ABNAGONECLM<TOk, MIFFFGJILCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x3090970", Offset = "0x308FD70", VA = "0x183090970")]
	public static ABNAGONECLM<TOk?, MIFFFGJILCH?> FJMLMPGNFCB<TOk>([In] this ABNAGONECLM<TOk, MIFFFGJILCH> MPLBPEBNKFP)
	{
		return default(ABNAGONECLM<TOk, MIFFFGJILCH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public interface GDCDMFKBBJH
{
	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAGMDEEKBKG([In] ABNAGONECLM<ALHKDJHEAFJ, NAONGKGFBLO> CEDDFJCBLGM);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class LEHPOJDEMMO
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x3116240", Offset = "0x3115640", VA = "0x183116240")]
	public static bool GAGMDEEKBKG<TOk, TErr>(this GDCDMFKBBJH MPLBPEBNKFP, [In] ABNAGONECLM<TOk, TErr> CEDDFJCBLGM) where TOk : notnull where TErr : notnull, NAONGKGFBLO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface ABLKNGGHEGN
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	JKGPFLOAPAF JAHCFHHGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface GPCNNNDNPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPIFOJLDALK DFGKMBOGBEH(int ALAHFOHFNNO);
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface KLJLCANEPOK
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface GNMOIKDCNHK
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JOOFDMNCJDF? EHDNOONBJML(AHPCDKCOAJM<FGCEHDOJGEK> PJGFIMFIOLO);
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface AKHEAOBPHPC
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface JOOFDMNCJDF
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string DKCJKHANLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AKHEAOBPHPC? HKILCHOEBEH(AHPCDKCOAJM<FEHJPJMJDBG> IOOAPHCONAK);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KLJLCANEPOK? NNKLFINBBBB(AHPCDKCOAJM<CBPDOKJJLFC> PIOHKEBMBIL);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface BLIECBOGFEI
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HKNODBAEFGF(string HCPAOILCJCB, string NOIHGGNEIML);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface PFJEOGKCODF
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GNMOIKDCNHK? JEKBCBDCBIB([In] PBDBGAKNNHI<DPFBAPKEJKA> JKHDBLFFJKH);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class LDKGLNAHAEN
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private struct JPICFCBDNPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public int MCCLHKLCIBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public DPCOLNDKMBE? ELHMNNGHPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public DPCOLNDKMBE? AEELCLGEKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public readonly List<OCNCAELNEHP> AGMAMDDJNED;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x2314070", Offset = "0x2313470", VA = "0x182314070")]
		private JPICFCBDNPL(int IIACLAMOIEE, DPCOLNDKMBE? GADGKIKGHAF, DPCOLNDKMBE? BHKFFPKCNMB, List<OCNCAELNEHP> GAEGLPHPPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x2313FB0", Offset = "0x23133B0", VA = "0x182313FB0")]
		public static JPICFCBDNPL ODOFIFAGLAJ()
		{
			return default(JPICFCBDNPL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly HPLDMJDBKBP<JPICFCBDNPL> EPMBBNFJPGO;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public static LDKGLNAHAEN ELEBKANKHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x23154F0", Offset = "0x23148F0", VA = "0x1823154F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool LHGABAACAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x9617B0", Offset = "0x960BB0", VA = "0x1809617B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x96FE20", Offset = "0x96F220", VA = "0x18096FE20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2315430", Offset = "0x2314830", VA = "0x182315430")]
	public void KBFOHBJFEOC(JFLIKJPNOAH BHKFFPKCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2315140", Offset = "0x2314540", VA = "0x182315140")]
	public void GOOOKAFLLMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2314E00", Offset = "0x2314200", VA = "0x182314E00")]
	private static string? EICGOPDPNIO([In] JPICFCBDNPL MEOBIKECGJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2315640", Offset = "0x2314A40", VA = "0x182315640")]
	public LDKGLNAHAEN()
	{
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
