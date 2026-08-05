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
using Google.Protobuf.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x211A770", Offset = "0x2119970", VA = "0x18211A770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class COBFIMKODNM : IDisposable, HIIOKDHOHKJ, COLCLHIGCDO, PIDKNOALEAM, KKOBANJBOMJ, OIGBHDHBPIE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private readonly struct KCCDHHLLENM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6731D0", Offset = "0x6725D0")]
		public readonly EMMEMCPIJPP<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM>> MLPMIPJPDID;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2115A60", Offset = "0x2114C60", VA = "0x182115A60")]
		internal KCCDHHLLENM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673230", Offset = "0x672630")] EMMEMCPIJPP<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM>> KPCECNDHFND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class HDJGNLDAPKG : PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly HDJGNLDAPKG JHOAALADPKE;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		private HDJGNLDAPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB36210", Offset = "0xB35410", VA = "0x180B36210", Slot = "4")]
		public IFHFCBJLIGK FGCAAKKMIIJ(AKEADGDIFCI KPIHKJNPOFH)
		{
			return default(IFHFCBJLIGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		public void DBDACJGPIIB(COBFIMKODNM MKADPIPCNMO, AKEADGDIFCI AMEKOPCKNIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class JDPKNCHPMIC : DINMPBGALLF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int GBDOECCLKMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x210F770", Offset = "0x210E970", VA = "0x18210F770", Slot = "5")]
		public CKFHAACMBGA AMJNJPKIGOP(IIAHACKKGJM.AOAGJCBPJMC NKPJOKLGAHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void PLEPLEDPPGF();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void DPIHGDCCPKI();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		protected JDPKNCHPMIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface DINMPBGALLF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int GBDOECCLKMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CKFHAACMBGA AMJNJPKIGOP(IIAHACKKGJM.AOAGJCBPJMC NKPJOKLGAHM);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PLEPLEDPPGF();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DPIHGDCCPKI();
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct GNHOLJGPLFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673290", Offset = "0x672690")]
		public GANOHBDLJJM<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM>> MLPMIPJPDID;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x210C890", Offset = "0x210BA90", VA = "0x18210C890")]
		internal GNHOLJGPLFH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6732F0", Offset = "0x6726F0")] GANOHBDLJJM<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM>> KPCECNDHFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x210C840", Offset = "0x210BA40", VA = "0x18210C840")]
		public static GNHOLJGPLFH HBHNAKPOBBF()
		{
			return default(GNHOLJGPLFH);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct BOAIDBMKNLG : BKGPNLAIPGC.FEKMDPDPAPK<PLNBIJGDFND, AKEADGDIFCI, COBFIMKODNM>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BHGIMNJCKOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6733F0", Offset = "0x6727F0")]
			public AsyncTaskMethodBuilder<PINPMIPFEPJ<object, OKKDIBLBODL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public COBFIMKODNM receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AKEADGDIFCI action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BOAIDBMKNLG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673450", Offset = "0x672850")]
			private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6734B0", Offset = "0x6728B0")]
			private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public BHGIMNJCKOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x666EC70", Offset = "0x666DE70", VA = "0x18666EC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA1DB30", Offset = "0xA1CD30", VA = "0x180A1DB30", Slot = "4")]
		public HOGMOCHAFIO<PLNBIJGDFND> JLMKMLEHMIP(COBFIMKODNM ALLNOIPNMOH)
		{
			return default(HOGMOCHAFIO<PLNBIJGDFND>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2105290", Offset = "0x2104490", VA = "0x182105290", Slot = "5")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(BHGIMNJCKOK))]
		public Task<PINPMIPFEPJ<object, OKKDIBLBODL>> BHABDLAJLGE(COBFIMKODNM ALLNOIPNMOH, AKEADGDIFCI AMEKOPCKNIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2105420", Offset = "0x2104620", VA = "0x182105420", Slot = "6")]
		public AKEADGDIFCI[] KKBPNADNFDG(COBFIMKODNM ALLNOIPNMOH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PJENDLHAEIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673510", Offset = "0x672910")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<bool, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IHOBKJMFEMC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BCBMDEOFCBP circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EHKJGJHNGOB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public COBFIMKODNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673570", Offset = "0x672970")]
		private PINPMIPFEPJ<bool, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6735D0", Offset = "0x6729D0")]
		private TaskAwaiter<PINPMIPFEPJ<bool, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PJENDLHAEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x211E990", Offset = "0x211DB90", VA = "0x18211E990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class APJIGDHFNGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673630", Offset = "0x672A30")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<bool, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public COBFIMKODNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673690", Offset = "0x672A90")]
		private PINPMIPFEPJ<bool, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6736F0", Offset = "0x672AF0")]
		private TaskAwaiter<PINPMIPFEPJ<bool, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public APJIGDHFNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x21045A0", Offset = "0x21037A0", VA = "0x1821045A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GPEDJBLFEBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673750", Offset = "0x672B50")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public COBFIMKODNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6737B0", Offset = "0x672BB0")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673810", Offset = "0x672C10")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GPEDJBLFEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x210C8A0", Offset = "0x210BAA0", VA = "0x18210C8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HGMPNNOICIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673870", Offset = "0x672C70")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<object, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AKEADGDIFCI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public COBFIMKODNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HGMPNNOICIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x210CDB0", Offset = "0x210BFB0", VA = "0x18210CDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class EIMNBFGFJLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6738D0", Offset = "0x672CD0")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public COBFIMKODNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673930", Offset = "0x672D30")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673990", Offset = "0x672D90")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <destroyRes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6739F0", Offset = "0x672DF0")]
		private PINPMIPFEPJ<bool, OKKDIBLBODL> <createRes>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673A50", Offset = "0x672E50")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673AB0", Offset = "0x672EB0")]
		private PINPMIPFEPJ<bool, OKKDIBLBODL> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673B10", Offset = "0x672F10")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673B70", Offset = "0x672F70")]
		private TaskAwaiter<PINPMIPFEPJ<bool, OKKDIBLBODL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EIMNBFGFJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x210AEB0", Offset = "0x210A0B0", VA = "0x18210AEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672BA0", Offset = "0x671FA0")]
	private readonly HOGMOCHAFIO<PLNBIJGDFND> NHDIHPNFPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KCCDHHLLENM CDOGLNEHBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DFIKBEOPGKC NBMNJACMLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly GJCNAAJHMHF OIIAJNFHDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly ANPMGNONDHL.LBPOIOGCDCL ODKCGLAMFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly POFFDGBIJCL DLDNJOONNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly NOFKKMOMNIM JHPDDICMOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly IPDEAGDHNLK BJMLLDDCKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly BJCADDNPCDN CGNEMAKJEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OLBIINKLMDO KKBJCEBIKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KHAKKAALHOE MJANKIAMKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly DFIKBEOPGKC.FHJBKGALENJ MMPKDNJPILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly BKMODJCJDAN PHJFNHBDFMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DFIKBEOPGKC LJGADJDEBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2109070", Offset = "0x2108270", VA = "0x182109070")]
		get
		{
			return default(DFIKBEOPGKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal DINMPBGALLF BHHBONNKKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2109350", Offset = "0x2108550", VA = "0x182109350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CKFHAACMBGA LJPOGGEAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96DB70", Offset = "0x96CD70", VA = "0x18096DB70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96DA00", Offset = "0x96CC00", VA = "0x18096DA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool PPCKCOGLCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9AC970", Offset = "0x9ABB70", VA = "0x1809AC970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB860", Offset = "0x9AAA60", VA = "0x1809AB860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BFNCLBPOIHE ODMLKAFFFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EA0", Offset = "0x8D40A0", VA = "0x1808D4EA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NPJIJDMGBJO FJJDCLLBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA13AD0", Offset = "0xA12CD0", VA = "0x180A13AD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EOPJPBLIIMP IIEKCLDELNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB1D850", Offset = "0xB1CA50", VA = "0x180B1D850", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CGCLPPKEBLL MFEIGOGFFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA07360", Offset = "0xA06560", VA = "0x180A07360", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private GCNMPMNNNKF? DOFAPKEKHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2109960", Offset = "0x2108B60", VA = "0x182109960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private OJAPJBMMFFA? BIBDIFJMBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21087A0", Offset = "0x21079A0", VA = "0x1821087A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2109A90", Offset = "0x2108C90", VA = "0x182109A90")]
	private COBFIMKODNM(GJCNAAJHMHF CKIBMJIJHCL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672D20", Offset = "0x672120")] HOGMOCHAFIO<PLNBIJGDFND> OMMCHNLHKPF, KCCDHHLLENM FOMIFCLGAGF, DFIKBEOPGKC GGOJAFBHOED, CKFHAACMBGA BNMBMDEENEH, in ANPMGNONDHL.LBPOIOGCDCL EABEEOAEJMM, DFIKBEOPGKC.FHJBKGALENJ FJPMAGELGIK, BKMODJCJDAN IJBJPNAKACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2108BF0", Offset = "0x2107DF0", VA = "0x182108BF0")]
	public static COBFIMKODNM HBHNAKPOBBF(GJCNAAJHMHF NKPJOKLGAHM, DFIKBEOPGKC.EMKIGOOGJFE AGKBOIBEJDN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672D80", Offset = "0x672180")] HOGMOCHAFIO<PLNBIJGDFND> OMMCHNLHKPF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672DE0", Offset = "0x6721E0")] HOGMOCHAFIO<KMFPIDABNKK> LJMIHLCLEME, KPDEPJCEJAK BFEBKHPPGCK, FEJGLJGLOBF IGMJBBNCFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2108CA0", Offset = "0x2107EA0", VA = "0x182108CA0")]
	public static COBFIMKODNM HBHNAKPOBBF(GJCNAAJHMHF CKIBMJIJHCL, in DFIKBEOPGKC GGOJAFBHOED, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672E40", Offset = "0x672240")] HOGMOCHAFIO<PLNBIJGDFND> OMMCHNLHKPF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672F00", Offset = "0x672300")] HOGMOCHAFIO<KMFPIDABNKK> LJMIHLCLEME, KPDEPJCEJAK BFEBKHPPGCK, FEJGLJGLOBF IGMJBBNCFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2108580", Offset = "0x2107780", VA = "0x182108580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2109790", Offset = "0x2108990", VA = "0x182109790")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PJENDLHAEIJ))]
	internal Task<PINPMIPFEPJ<bool, OKKDIBLBODL>> MBOGAOMMHAJ(IHOBKJMFEMC LCJFJCHKPIE, BCBMDEOFCBP HDAJOGJNNGD, EHKJGJHNGOB GPHICPODLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2108AA0", Offset = "0x2107CA0", VA = "0x182108AA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APJIGDHFNGJ))]
	public Task<PINPMIPFEPJ<bool, OKKDIBLBODL>> GOOCDMPBCJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2108950", Offset = "0x2107B50", VA = "0x182108950")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GPEDJBLFEBO))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> FEOBCMGEKLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2108340", Offset = "0x2107540", VA = "0x182108340")]
	internal void BHMBDONEMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21088D0", Offset = "0x2107AD0", VA = "0x1821088D0")]
	internal NODPJPPOKHP<AKEADGDIFCI> EPOEODNJHAC(in CPMKBDJMJNO KAJGIPALJDN)
	{
		return default(NODPJPPOKHP<AKEADGDIFCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2109010", Offset = "0x2108210", VA = "0x182109010")]
	internal bool HJLLGDIGEIH(in CPMKBDJMJNO KAJGIPALJDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x21093A0", Offset = "0x21085A0", VA = "0x1821093A0")]
	internal NODPJPPOKHP<AKEADGDIFCI> JBEOEIMPIHG(in NNBCJKEDGLA HJFPNNKHMFJ)
	{
		return default(NODPJPPOKHP<AKEADGDIFCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21091E0", Offset = "0x21083E0", VA = "0x1821091E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HGMPNNOICIG))]
	internal Task<PINPMIPFEPJ<object, OKKDIBLBODL>> ILHEGGGOEDD(AKEADGDIFCI AMEKOPCKNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2109420", Offset = "0x2108620", VA = "0x182109420")]
	private AKEADGDIFCI[] KKBPNADNFDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2109080", Offset = "0x2108280", VA = "0x182109080")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EIMNBFGFJLI))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> IEFLLGJMBMI(Guid JAJOMKFJEHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CFEOEMHPKPK<TData> : EAICBCFAACM, NNLFHHJJMBM, NKHHFMGDFFF where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673BD0", Offset = "0x672FD0")]
	private readonly NNDHFAJHACK<JDAAGGKKBIF>? JDOCGFIALOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly string GCEJMFHMPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly TData LEHIJMHIJLJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673D80", Offset = "0x673180")]
	public NNDHFAJHACK<JDAAGGKKBIF>? DGEENKOCJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E54640", Offset = "0x1E53840", VA = "0x181E54640", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190", Slot = "7")]
	public override string MJGKCLCNGHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1E546E0", Offset = "0x1E538E0", VA = "0x181E546E0")]
	internal CFEOEMHPKPK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673CB0", Offset = "0x6730B0")] in NNDHFAJHACK<JDAAGGKKBIF>? LPGBDEBBGNI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673D20", Offset = "0x673120")] HOGMOCHAFIO<DAJLACINGLM>? ILAJIFKHIKL, IOKind? MPIKBLCGHDP, string JPOEHOENKPI, in TData JFGIPFOFKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IDKDCLBGKAH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x210DC60", Offset = "0x210CE60", VA = "0x18210DC60")]
	public static PINPMIPFEPJ<HKCMDKBIADA, NNLFHHJJMBM> FNHAFOEPCAM(this in KKACJHLEPDF<ANEAEFBOIFG> DHBNJONEPDI)
	{
		return default(PINPMIPFEPJ<HKCMDKBIADA, NNLFHHJJMBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2185130", Offset = "0x2184330", VA = "0x182185130")]
	public static PINPMIPFEPJ<TOk, NNLFHHJJMBM> KAIDNMBGIFJ<TOk>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673DF0", Offset = "0x6731F0")] this in PINPMIPFEPJ<TOk, NNLFHHJJMBM> KPIHKJNPOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673E60", Offset = "0x673260")] in NNDHFAJHACK<JDAAGGKKBIF>? LPGBDEBBGNI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673ED0", Offset = "0x6732D0")] HOGMOCHAFIO<DAJLACINGLM>? ILAJIFKHIKL, IOKind? MPIKBLCGHDP, string JPOEHOENKPI) where TOk : notnull
	{
		return default(PINPMIPFEPJ<TOk, NNLFHHJJMBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FCAEFGLMPHL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1933370", Offset = "0x1932570", VA = "0x181933370")]
	public static ALHGFGDMNGJ<(TPrev?, COBFIMKODNM?), OJAPJBMMFFA> CDKADAKLKIB<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673F70", Offset = "0x673370")] this in ALHGFGDMNGJ<TPrev?, COBFIMKODNM?> KPIHKJNPOFH)
	{
		return default(ALHGFGDMNGJ<(TPrev, COBFIMKODNM), OJAPJBMMFFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E1DD00", Offset = "0x1E1CF00", VA = "0x181E1DD00")]
	public static ALHGFGDMNGJ<TPrev?, COBFIMKODNM?> CFIMAMPGNFL<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x673FE0", Offset = "0x6733E0")] this in ALHGFGDMNGJ<TPrev?, COBFIMKODNM?> KPIHKJNPOFH)
	{
		return default(ALHGFGDMNGJ<TPrev, COBFIMKODNM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GJCNAAJHMHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OIBPAHNOGOJ.ADNFENEBIML HBNJOOAPOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IIAHACKKGJM.AOAGJCBPJMC GGBFGOIDDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	COBFIMKODNM.DINMPBGALLF HHIDBBKPKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FMGNBJLPNPP.GOBODOEJJEM EJFNOEIKBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM> IHOCCCAKIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PBCNIAJDNKJ FPMDHLPAOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MEFEINIAOBL LOKJINBCIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DDHNMHAMLGE DEPAMGPBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NIADHPDMBEE FDKOGECIFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	NMPKAKJAEDO HNAIGNLKOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct PCMGJJOGLDL
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MLMOIJFDFCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674100", Offset = "0x673500")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<OGOJDCIJJPH, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public COBFIMKODNM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public PCMGJJOGLDL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674160", Offset = "0x673560")]
		private PINPMIPFEPJ<OGOJDCIJJPH, OKKDIBLBODL> <r1>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6741C0", Offset = "0x6735C0")]
		private PINPMIPFEPJ<object, NKHHFMGDFFF>[] <aggregateResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674220", Offset = "0x673620")]
		private PINPMIPFEPJ<object, NKHHFMGDFFF> <r2>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674280", Offset = "0x673680")]
		private PINPMIPFEPJ<object, NKHHFMGDFFF>[] <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6742E0", Offset = "0x6736E0")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674340", Offset = "0x673740")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MLMOIJFDFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6672AC0", Offset = "0x6671CC0", VA = "0x186672AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly IReadOnlyList<AKEADGDIFCI> EHJLADCCCND;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	private PCMGJJOGLDL(IReadOnlyList<AKEADGDIFCI> CHGGJLGDPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x211CC60", Offset = "0x211BE60", VA = "0x18211CC60")]
	public static AKEADGDIFCI GBKLKPBKMPK(IReadOnlyList<AKEADGDIFCI> CHGGJLGDPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x211CEA0", Offset = "0x211C0A0", VA = "0x18211CEA0")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, PCMGJJOGLDL> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, PCMGJJOGLDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x211CD30", Offset = "0x211BF30", VA = "0x18211CD30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MLMOIJFDFCO))]
	public static Task<PINPMIPFEPJ<OGOJDCIJJPH, OKKDIBLBODL>> ILHEGGGOEDD(COBFIMKODNM MKADPIPCNMO, PCMGJJOGLDL KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JJCFACMAKLG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x210F930", Offset = "0x210EB30", VA = "0x18210F930")]
	public static AKEADGDIFCI NEGMLIIEMKM(this AKEADGDIFCI KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x210F890", Offset = "0x210EA90", VA = "0x18210F890")]
	public static AKEADGDIFCI FNEICKOKDOP(this INJHNJALPIH KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct IFAGNICBDHD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MCKNBKBJEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674460", Offset = "0x673860")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF?>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public COBFIMKODNM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IFAGNICBDHD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6744C0", Offset = "0x6738C0")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF?> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool <shouldDiscard>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MCKNBKBJEPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x21183E0", Offset = "0x21175E0", VA = "0x1821183E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly IHOBKJMFEMC? EAIPMCAHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly BCBMDEOFCBP? EKNDHPLAPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly EHKJGJHNGOB? KOIDKJOOIGO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1055780", Offset = "0x1054980", VA = "0x181055780")]
	private IFAGNICBDHD(IHOBKJMFEMC? LCJFJCHKPIE, BCBMDEOFCBP? HDAJOGJNNGD, EHKJGJHNGOB? GPHICPODLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x210E080", Offset = "0x210D280", VA = "0x18210E080")]
	public static AKEADGDIFCI? GBKLKPBKMPK(IHOBKJMFEMC? LCJFJCHKPIE, BCBMDEOFCBP? HDAJOGJNNGD, EHKJGJHNGOB? GPHICPODLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x210E300", Offset = "0x210D500", VA = "0x18210E300")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, IFAGNICBDHD> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, IFAGNICBDHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x210E180", Offset = "0x210D380", VA = "0x18210E180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MCKNBKBJEPM))]
	public static Task<PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>> ILHEGGGOEDD(COBFIMKODNM MKADPIPCNMO, IFAGNICBDHD KPIHKJNPOFH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct HGKCCLEKAOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x210CCA0", Offset = "0x210BEA0", VA = "0x18210CCA0")]
	public static AKEADGDIFCI GBKLKPBKMPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x210CD40", Offset = "0x210BF40", VA = "0x18210CD40")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, HGKCCLEKAOJ> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, HGKCCLEKAOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x210CC20", Offset = "0x210BE20", VA = "0x18210CC20")]
	public static PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF> BCNLOPJLHFI(COBFIMKODNM MKADPIPCNMO, in HGKCCLEKAOJ KPIHKJNPOFH)
	{
		return default(PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct CPMKBDJMJNO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LBKDLCMEGCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674580", Offset = "0x673980")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<bool, IFCPLEGMLKF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public COBFIMKODNM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CPMKBDJMJNO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6745E0", Offset = "0x6739E0")]
		private PINPMIPFEPJ<bool, IFCPLEGMLKF> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool <shouldDiscard>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private AKEADGDIFCI <value>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674640", Offset = "0x673A40")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, IFCPLEGMLKF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LBKDLCMEGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2117710", Offset = "0x2116910", VA = "0x182117710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int JKNHGEMPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int BBOMBIMAMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] LEHIJMHIJLJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1A0D560", Offset = "0x1A0C760", VA = "0x181A0D560")]
	private CPMKBDJMJNO(int BKHJHJOLNNF, int NNAODBDJDNJ, byte[] JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2109FA0", Offset = "0x21091A0", VA = "0x182109FA0")]
	public static AKEADGDIFCI GBKLKPBKMPK(int BKHJHJOLNNF, int NNAODBDJDNJ, ByteString JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2109D90", Offset = "0x2108F90", VA = "0x182109D90")]
	public static AKEADGDIFCI?[]? FIKABGMNFFD(int ECIKKPDIJLN, IHOBKJMFEMC? LCJFJCHKPIE, BCBMDEOFCBP? HDAJOGJNNGD, EHKJGJHNGOB? GPHICPODLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x210A210", Offset = "0x2109410", VA = "0x18210A210")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, CPMKBDJMJNO> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, CPMKBDJMJNO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x210A0A0", Offset = "0x21092A0", VA = "0x18210A0A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBKDLCMEGCC))]
	public static Task<PINPMIPFEPJ<bool, IFCPLEGMLKF>> ILHEGGGOEDD(COBFIMKODNM MKADPIPCNMO, CPMKBDJMJNO KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct INJHNJALPIH
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AEHNKFNMCAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674710", Offset = "0x673B10")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<object, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public COBFIMKODNM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public INJHNJALPIH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674770", Offset = "0x673B70")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6747D0", Offset = "0x673BD0")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AEHNKFNMCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2103DD0", Offset = "0x2102FD0", VA = "0x182103DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly ByteString HDFPEMDEFEE;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	private INJHNJALPIH(ByteString NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x210EA20", Offset = "0x210DC20", VA = "0x18210EA20")]
	public static AKEADGDIFCI GBKLKPBKMPK(ByteString NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x210EC50", Offset = "0x210DE50", VA = "0x18210EC50")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, INJHNJALPIH> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, INJHNJALPIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x210EAE0", Offset = "0x210DCE0", VA = "0x18210EAE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEHNKFNMCAP))]
	public static Task<PINPMIPFEPJ<object, OKKDIBLBODL>> ILHEGGGOEDD(COBFIMKODNM MKADPIPCNMO, INJHNJALPIH KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct NNBCJKEDGLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly int JKNHGEMPCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly int BBOMBIMAMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly byte[] LEHIJMHIJLJ;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0D560", Offset = "0x1A0C760", VA = "0x181A0D560")]
	private NNBCJKEDGLA(int BKHJHJOLNNF, int NNAODBDJDNJ, byte[] JFGIPFOFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x211A3E0", Offset = "0x21195E0", VA = "0x18211A3E0")]
	public static AKEADGDIFCI GBKLKPBKMPK(int BKHJHJOLNNF, int NNAODBDJDNJ, ByteString JFGIPFOFKHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x211A600", Offset = "0x2119800", VA = "0x18211A600")]
	public static AKEADGDIFCI[] LNNEMPPBAIK(AKEADGDIFCI AMEKOPCKNIK, int ECIKKPDIJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x211A4E0", Offset = "0x21196E0", VA = "0x18211A4E0")]
	public static KDDOJAECMMJ<IFHFCBJLIGK, NNBCJKEDGLA> JGGKNCMPFBF(AKEADGDIFCI IDBBHLFECOA)
	{
		return default(KDDOJAECMMJ<IFHFCBJLIGK, NNBCJKEDGLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x211A2C0", Offset = "0x21194C0", VA = "0x18211A2C0")]
	public static PINPMIPFEPJ<AKEADGDIFCI, IFCPLEGMLKF> BCNLOPJLHFI(COBFIMKODNM MKADPIPCNMO, in NNBCJKEDGLA KPIHKJNPOFH)
	{
		return default(PINPMIPFEPJ<AKEADGDIFCI, IFCPLEGMLKF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ILALNPBCEPC
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NHEFHKAJEAK? DKFFIMCACHE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674870", Offset = "0x673C70")] HOGMOCHAFIO<ALBFEPNKGJA?> IAEFNJNFKHM);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCPIJCMPBHN? ACPIDLPCNAI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6748D0", Offset = "0x673CD0")] HOGMOCHAFIO<GOHONMAKFBH?> PKDNKNMCOMB);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface NCPIJCMPBHN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PBCNIAJDNKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMOKJJMIBAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674930", Offset = "0x673D30")] in PINPMIPFEPJ<CKDLGNFJNCJ, NKHHFMGDFFF> GAMJEJDMFJF);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class PKEIDFLBCJI
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x234ABE0", Offset = "0x2349DE0", VA = "0x18234ABE0")]
	public static bool BMOKJJMIBAL<TOk, TErr>(this PBCNIAJDNKJ KPIHKJNPOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6749A0", Offset = "0x673DA0")] in PINPMIPFEPJ<TOk, TErr> GAMJEJDMFJF) where TOk : notnull where TErr : notnull, NKHHFMGDFFF
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NIADHPDMBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> KIJCFHPLICL(string NABCGCEIEGG, string JDFBABENAGD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NMPKAKJAEDO
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMEAACHKHEG? GAHBIEGLAHG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674A10", Offset = "0x673E10")] in NNDHFAJHACK<NBLMGHLCPAM?> MPNMCJGFLBE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NHEFHKAJEAK
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface MEFEINIAOBL
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LIHGOODKAFE HNCPOHBKKFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BMEAACHKHEG
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILALNPBCEPC? OEBINGMIOLI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674A80", Offset = "0x673E80")] HOGMOCHAFIO<LACIKMLBFJD?> OBOMAALHHEA);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DDHNMHAMLGE
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJIEOAJLKJN HCMABENMJJO(int JBPKHBMCLEL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class LBFINLIIENC
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct FIAMAOGGKCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int BBOMBIMAMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public BCBMDEOFCBP? OOEMDBNFDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public BCBMDEOFCBP? APHPFIGENJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly List<AKEADGDIFCI> EHJLADCCCND;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x34C1860", Offset = "0x34C0A60", VA = "0x1834C1860")]
		private FIAMAOGGKCA(int NNAODBDJDNJ, BCBMDEOFCBP? JBPIGNBMMBE, BCBMDEOFCBP? ABEFHKJENHP, List<AKEADGDIFCI> CHGGJLGDPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6670EE0", Offset = "0x66700E0", VA = "0x186670EE0")]
		public static FIAMAOGGKCA HBHNAKPOBBF()
		{
			return default(FIAMAOGGKCA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int CLMNABAOJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly AJPPACPPDOG<FIAMAOGGKCA> DMNFFADMLAL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static LBFINLIIENC JHOAALADPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x21174F0", Offset = "0x21166F0", VA = "0x1821174F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HPBOMJBPKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB280", Offset = "0xAAA480", VA = "0x180AAB280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAAB100", Offset = "0xAAA300", VA = "0x180AAB100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2117100", Offset = "0x2116300", VA = "0x182117100")]
	public void HGMDHEGLJNG(ANPMGNONDHL ABEFHKJENHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x21171E0", Offset = "0x21163E0", VA = "0x1821171E0")]
	public void JMJFOPPJCMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2116D50", Offset = "0x2115F50", VA = "0x182116D50")]
	private static string? AGBPLONEBLL(in FIAMAOGGKCA GNAFOMHJEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2117650", Offset = "0x2116850", VA = "0x182117650")]
	public LBFINLIIENC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class POFFDGBIJCL : BFNCLBPOIHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly COBFIMKODNM BANGPOFOHOG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EKJCAOPFGGC? JHOAALADPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x211EBF0", Offset = "0x211DDF0", VA = "0x18211EBF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	internal POFFDGBIJCL(COBFIMKODNM DIPIIMIHCJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class GCCOPPNNJAP : JDNAPDNLFFL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly CCOHKDMNIBE FCJKPFODLBF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public CCOHKDMNIBE EPAKECLNDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	private GCCOPPNNJAP(CCOHKDMNIBE FOLOLHLEMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x210C6C0", Offset = "0x210B8C0", VA = "0x18210C6C0")]
	public static GCCOPPNNJAP JHIOLOAEPHF(COBFIMKODNM DIPIIMIHCJA, IHOBKJMFEMC AHGFOCJNNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x210C6A0", Offset = "0x210B8A0", VA = "0x18210C6A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class OBCMKACLDKA : AJBOALEOCFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly DOHCCNMLPPO KAMKGBFKIKA;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly HashSet<DOHCCNMLPPO> GIFPIGAAIML;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly HashSet<DOHCCNMLPPO> MKCNKBMHEPO;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly HashSet<DOHCCNMLPPO> GGNCJCDGBMA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TypeKey GJDAAKMEFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x211BD40", Offset = "0x211AF40", VA = "0x18211BD40", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool EDFNKNNCEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x211BD30", Offset = "0x211AF30", VA = "0x18211BD30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool ONEHCDGKIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x211BDA0", Offset = "0x211AFA0", VA = "0x18211BDA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool NMPLBNGOMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x211BCA0", Offset = "0x211AEA0", VA = "0x18211BCA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x211A990", Offset = "0x2119B90", VA = "0x18211A990")]
	public bool OENBNLCELEJ(string NABCGCEIEGG, out LCPGIEPPFLN CCPGBGCDOCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public OBCMKACLDKA(DOHCCNMLPPO KPCECNDHFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x211A800", Offset = "0x2119A00", VA = "0x18211A800")]
	internal static TypeKey MIDKNGEOEDG(DOHCCNMLPPO FBNKHAJKFLM)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2104860", Offset = "0x2103A60", VA = "0x182104860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DMALPBKHKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674B20", Offset = "0x673F20")]
	private sealed class JOFMELGDADP : MMDKICAFDJH<JAEOLJMLGCN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1234500", Offset = "0x1233700", VA = "0x181234500", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2110350", Offset = "0x210F550", VA = "0x182110350")]
		public JOFMELGDADP(COBFIMKODNM DIPIIMIHCJA, JAEOLJMLGCN MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674B80", Offset = "0x673F80")]
	private abstract class JFKPGPBOPPA<TNode> : MMDKICAFDJH<TNode> where TNode : notnull, IKNFJOFFLFK
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class DPEDEECDIKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674F00", Offset = "0x674300")]
			public AsyncTaskMethodBuilder<PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public JFKPGPBOPPA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter<PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public DPEDEECDIKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x2C7BAA0", Offset = "0x2C7ACA0", VA = "0x182C7BAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class PCMENLEKLKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674F60", Offset = "0x674360")]
			public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674FC0", Offset = "0x6743C0")]
			public HOGMOCHAFIO<LACIKMLBFJD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public JFKPGPBOPPA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public PCMENLEKLKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2A247A0", Offset = "0x2A239A0", VA = "0x182A247A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674E30", Offset = "0x674230")]
		public override NNDHFAJHACK<ICMDIGALLLM>? DCBFMEEKDJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C98BC0", Offset = "0x2C97DC0", VA = "0x182C98BC0", Slot = "101")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674EA0", Offset = "0x6742A0")]
		public override HOGMOCHAFIO<LACIKMLBFJD>? GHECOBLNJMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2FF5450", Offset = "0x2FF4650", VA = "0x182FF5450", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2165C80", Offset = "0x2164E80", VA = "0x182165C80")]
		public JFKPGPBOPPA(COBFIMKODNM DIPIIMIHCJA, TNode MEMCJAOBNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5080", Offset = "0x2FF4280", VA = "0x182FF5080", Slot = "86")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(JFKPGPBOPPA<>.DPEDEECDIKO))]
		public override Task<PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL>> IGJFCGGGAPJ(string JPKENOAMLIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4F40", Offset = "0x2FF4140", VA = "0x182FF4F40", Slot = "107")]
		public sealed override bool DPCJBDNDCMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674C40", Offset = "0x674040")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2FF53B0", Offset = "0x2FF45B0", VA = "0x182FF53B0", Slot = "98")]
		protected sealed override bool PLNPGMDKNKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674CA0", Offset = "0x6740A0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2FF4FE0", Offset = "0x2FF41E0", VA = "0x182FF4FE0", Slot = "99")]
		protected override bool HBHMCJGIBIF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674D00", Offset = "0x674100")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5220", Offset = "0x2FF4420", VA = "0x182FF5220", Slot = "87")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(JFKPGPBOPPA<>.PCMENLEKLKM))]
		public override Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> IPOJIMJPEKJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x674DD0", Offset = "0x6741D0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675020", Offset = "0x674420")]
	private sealed class LAJBDHCMEEK : MMDKICAFDJH<HKEAAJIKCEO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x126E6A0", Offset = "0x126D8A0", VA = "0x18126E6A0", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2116CF0", Offset = "0x2115EF0", VA = "0x182116CF0")]
		public LAJBDHCMEEK(COBFIMKODNM DIPIIMIHCJA, HKEAAJIKCEO MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675080", Offset = "0x674480")]
	private sealed class HNCDDDLIKAC : MMDKICAFDJH<GFAIGGJIIND>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB04630", Offset = "0xB03830", VA = "0x180B04630", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x210D610", Offset = "0x210C810", VA = "0x18210D610")]
		public HNCDDDLIKAC(COBFIMKODNM DIPIIMIHCJA, GFAIGGJIIND MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6750E0", Offset = "0x6744E0")]
	private sealed class MPFCDKDBIBD : JFKPGPBOPPA<KGHCIOKJMLF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool DIIKPIKJFMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9A05B0", Offset = "0x99F7B0", VA = "0x1809A05B0", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2118F80", Offset = "0x2118180", VA = "0x182118F80")]
		public MPFCDKDBIBD(COBFIMKODNM DIPIIMIHCJA, KGHCIOKJMLF MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675140", Offset = "0x674540")]
	private sealed class NEAMDLLBFJI : MMDKICAFDJH<OBBPAGNDKBM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xC2CC60", Offset = "0xC2BE60", VA = "0x180C2CC60", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2118FE0", Offset = "0x21181E0", VA = "0x182118FE0")]
		public NEAMDLLBFJI(COBFIMKODNM DIPIIMIHCJA, OBBPAGNDKBM MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6751A0", Offset = "0x6745A0")]
	private sealed class AMIAGENJLGF : EKGAEPEBNHL<LACIIJILEGN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB4DB40", Offset = "0xB4CD40", VA = "0x180B4DB40", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2104540", Offset = "0x2103740", VA = "0x182104540")]
		public AMIAGENJLGF(COBFIMKODNM DIPIIMIHCJA, LACIIJILEGN MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class MMDKICAFDJH<TNode> : NJCGFKKGOPK, IDisposable where TNode : notnull, HNKICPEMJJE
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class OPDJJBEFOPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public MMDKICAFDJH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public COBFIMKODNM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public OPDJJBEFOPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x3391BD0", Offset = "0x3390DD0", VA = "0x183391BD0")]
			internal JPEMMDOPPKJ LDAMPIMNIHH(LLBNMPGAEBJ portGroup, int index)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class DNHFDELILCL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6763C0", Offset = "0x6757C0")]
			public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public MMDKICAFDJH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public DNHFDELILCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x2C784B0", Offset = "0x2C776B0", VA = "0x182C784B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private COBFIMKODNM BANGPOFOHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675200", Offset = "0x674600")]
		private NJCGNMPMJKC<LACIKMLBFJD, JPEMMDOPPKJ> OPCOEPNFMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675260", Offset = "0x674660")]
		private NJCGNMPMJKC<LACIKMLBFJD, DEHHNHEFJMC> LDLAADINFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[CompilerGenerated]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675580", Offset = "0x674980")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<HOGMOCHAFIO<LACIKMLBFJD>> APJJHKBACMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675600", Offset = "0x674A00")]
		private Action<HOGMOCHAFIO<LACIKMLBFJD>, DEHHNHEFJMC> EGMCBKJEBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675700", Offset = "0x674B00")]
		private Action<HOGMOCHAFIO<LACIKMLBFJD>, HOGMOCHAFIO<LACIKMLBFJD>> GFJKNIAKEKM;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected TNode EJMKPOBEOHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public object GCHLLMNMNPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0B10", Offset = "0x1FBFD10", VA = "0x181FC0B10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public virtual bool FLMHMOCLGOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "75")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int LAGNIFEAPPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x27758E0", Offset = "0x2774AE0", VA = "0x1827758E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public FJIEOAJLKJN OMBDBOAAMMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x27758A0", Offset = "0x2774AA0", VA = "0x1827758A0", Slot = "8")]
			get
			{
				return default(FJIEOAJLKJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public virtual NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675EB0", Offset = "0x6752B0")]
		public HOGMOCHAFIO<FPLIPMPLALG> FHIEDKIOAKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9E7BA0", Offset = "0x9E6DA0", VA = "0x1809E7BA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(HOGMOCHAFIO<FPLIPMPLALG>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xBB0690", Offset = "0xBAF890", VA = "0x180BB0690")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6757E0", Offset = "0x674BE0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual bool AAHPCJDMEBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "78")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public virtual bool DIIKPIKJFMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool KBFKCAMFGGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool PPCPBAKJIDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2775720", Offset = "0x2774920", VA = "0x182775720", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool NGOJNNCLENE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2775760", Offset = "0x2774960", VA = "0x182775760", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool CELCDGICAIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x27757A0", Offset = "0x27749A0", VA = "0x1827757A0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int KKAJOFDMOKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x2775B10", Offset = "0x2774D10", VA = "0x182775B10", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool JCOPCAAGGMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x2775A50", Offset = "0x2774C50", VA = "0x182775A50", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string PBBMMIGOONN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x2775980", Offset = "0x2774B80", VA = "0x182775980", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool KLMLFDBJJCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x2775820", Offset = "0x2774A20", VA = "0x182775820", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool NOEDKLMNCCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAED2F0", Offset = "0xAEC4F0", VA = "0x180AED2F0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAED060", Offset = "0xAEC260", VA = "0x180AED060")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public virtual bool DGHFDODLPCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "81")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public virtual bool EKCKCCBHPAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x27757E0", Offset = "0x27749E0", VA = "0x1827757E0", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool HJABDBKJLJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x27759C0", Offset = "0x2774BC0", VA = "0x1827759C0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public DDAEIDDGCJK IEOOHOKMJDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2775A90", Offset = "0x2774C90", VA = "0x182775A90", Slot = "24")]
			get
			{
				return default(DDAEIDDGCJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public HBNLMECNNNL NDNFEPKHJBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2775AD0", Offset = "0x2774CD0", VA = "0x182775AD0", Slot = "26")]
			get
			{
				return default(HBNLMECNNNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual bool KECAPPMJHGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual BDBPACOBLNF? OBIOOJFPKFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "94")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual HHKOPKOLIHA? MIJIAJICLFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "95")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675F10", Offset = "0x675310")]
		public virtual IEnumerable<HNKICPEMJJE> ONOLPHAGEMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "96")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool AFFFBLKIEJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2775860", Offset = "0x2774A60", VA = "0x182775860", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675F70", Offset = "0x675370")]
		public NNDHFAJHACK<ICMDIGALLLM> NAHPHGJADGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2775910", Offset = "0x2774B10", VA = "0x182775910", Slot = "49")]
			get
			{
				return default(NNDHFAJHACK<ICMDIGALLLM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual bool BELDKDNPFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675FE0", Offset = "0x6753E0")]
		public virtual NNDHFAJHACK<ICMDIGALLLM>? DCBFMEEKDJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2775950", Offset = "0x2774B50", VA = "0x182775950", Slot = "101")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool CNEJBEGOAAC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2775A00", Offset = "0x2774C00", VA = "0x182775A00", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual string GCLEOCLMMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40", Slot = "102")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0", Slot = "103")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676050", Offset = "0x675450")]
		public NNDHFAJHACK<JDAAGGKKBIF> EKMCEGABMAO
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2775B40", Offset = "0x2774D40", VA = "0x182775B40", Slot = "54")]
			get
			{
				return default(NNDHFAJHACK<JDAAGGKKBIF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6760C0", Offset = "0x6754C0")]
		public NNDHFAJHACK<JDAAGGKKBIF>? DIAIBKENICB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2775B80", Offset = "0x2774D80", VA = "0x182775B80", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676120", Offset = "0x675520")]
		public KHCMLBEHALN<LACIKMLBFJD, DEHHNHEFJMC> PAEHGJDEPEL
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2775C60", Offset = "0x2774E60", VA = "0x182775C60", Slot = "56")]
			get
			{
				return default(KHCMLBEHALN<LACIKMLBFJD, DEHHNHEFJMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676180", Offset = "0x675580")]
		public virtual HOGMOCHAFIO<LACIKMLBFJD>? GHECOBLNJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NGJAJAMGGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2773300", Offset = "0x2772500", VA = "0x182773300", Slot = "31")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x2773250", Offset = "0x2772450", VA = "0x182773250", Slot = "32")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event BLNHAPDPPLP BOONNKBBLLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x27748B0", Offset = "0x2773AB0", VA = "0x1827748B0", Slot = "33")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2773460", Offset = "0x2772660", VA = "0x182773460", Slot = "34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event LDELOOGLOIG BJNPALNOEDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x2774CF0", Offset = "0x2773EF0", VA = "0x182774CF0", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x2774C10", Offset = "0x2773E10", VA = "0x182774C10", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DKBHLHNAGIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2771E10", Offset = "0x2771010", VA = "0x182771E10", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2775040", Offset = "0x2774240", VA = "0x182775040", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action LFBPDALIKLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2775250", Offset = "0x2774450", VA = "0x182775250", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x27733B0", Offset = "0x27725B0", VA = "0x1827733B0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<HOGMOCHAFIO<LACIKMLBFJD>, DEHHNHEFJMC> EICJCPDIMIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2774E50", Offset = "0x2774050", VA = "0x182774E50", Slot = "58")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675A20", Offset = "0x674E20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2773CD0", Offset = "0x2772ED0", VA = "0x182773CD0", Slot = "59")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675A80", Offset = "0x674E80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<HOGMOCHAFIO<LACIKMLBFJD>, DEHHNHEFJMC> FJFJCJMMJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2773D80", Offset = "0x2772F80", VA = "0x182773D80", Slot = "62")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675AE0", Offset = "0x674EE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2774DA0", Offset = "0x2773FA0", VA = "0x182774DA0", Slot = "63")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675B40", Offset = "0x674F40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<HOGMOCHAFIO<LACIKMLBFJD>> ICGOADMDGOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2771EF0", Offset = "0x27710F0", VA = "0x182771EF0", Slot = "60")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675BA0", Offset = "0x674FA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x27750F0", Offset = "0x27742F0", VA = "0x1827750F0", Slot = "61")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675C00", Offset = "0x675000")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<HOGMOCHAFIO<LACIKMLBFJD>, HOGMOCHAFIO<LACIKMLBFJD>> KJODPFINCJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2774F00", Offset = "0x2774100", VA = "0x182774F00", Slot = "64")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675C60", Offset = "0x675060")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2774B60", Offset = "0x2773D60", VA = "0x182774B60", Slot = "65")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675CC0", Offset = "0x6750C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<HOGMOCHAFIO<LACIKMLBFJD>, DEHHNHEFJMC> HMDNLFBKLNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2774AB0", Offset = "0x2773CB0", VA = "0x182774AB0", Slot = "66")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675D20", Offset = "0x675120")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x27751A0", Offset = "0x27743A0", VA = "0x1827751A0", Slot = "67")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675D80", Offset = "0x675180")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2775480", Offset = "0x2774680", VA = "0x182775480")]
		[HCMLPCEGDDN("Need to handle `Name` better.")]
		[HCMLPCEGDDN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		public MMDKICAFDJH(COBFIMKODNM DIPIIMIHCJA, TNode MEMCJAOBNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2774220", Offset = "0x2773420", VA = "0x182774220", Slot = "73")]
		protected virtual void KCEHONPEIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2772B80", Offset = "0x2771D80", VA = "0x182772B80", Slot = "74")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2773610", Offset = "0x2772810", VA = "0x182773610", Slot = "76")]
		public virtual void GKFKNCIHBGF(int LBKPLBFDGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2775300", Offset = "0x2774500", VA = "0x182775300")]
		public bool PFJMDJGLEDF(in DDAEIDDGCJK NABCGCEIEGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2773B50", Offset = "0x2772D50", VA = "0x182773B50")]
		public bool IKOIHALOCIP(in HBNLMECNNNL NABCGCEIEGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2773BA0", Offset = "0x2772DA0", VA = "0x182773BA0", Slot = "83")]
		public virtual void IMMKCMMMCGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "84")]
		public virtual void GIDMDLEEAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "85")]
		public virtual void CJMLCKHKGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x98AE00", Offset = "0x98A000", VA = "0x18098AE00")]
		protected void EOGEEFFPNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x98AE60", Offset = "0x98A060", VA = "0x18098AE60")]
		protected void ENCCDANJACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2773B30", Offset = "0x2772D30", VA = "0x182773B30")]
		private void IKIJHDHGAHJ(in HBNLMECNNNL ELGEECMLAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x27738C0", Offset = "0x2772AC0", VA = "0x1827738C0", Slot = "86")]
		public virtual Task<PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL>> IGJFCGGGAPJ(string JPKENOAMLIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2773BE0", Offset = "0x2772DE0", VA = "0x182773BE0", Slot = "87")]
		public virtual Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> IPOJIMJPEKJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675840", Offset = "0x674C40")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2775440", Offset = "0x2774640", VA = "0x182775440", Slot = "88")]
		public virtual void PPBMKPPBIOB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6758A0", Offset = "0x674CA0")] HOGMOCHAFIO<LACIKMLBFJD> NNAODBDJDNJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675900", Offset = "0x674D00")] HOGMOCHAFIO<LACIKMLBFJD> BJPEGONLJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x27747F0", Offset = "0x27739F0", VA = "0x1827747F0", Slot = "89")]
		public virtual IEnumerable<AKEADGDIFCI> KGCPPEOMFOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2774960", Offset = "0x2773B60", VA = "0x182774960", Slot = "41")]
		public PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> KHHJMDDNNAA(string MHAMHEMGGII)
		{
			return default(PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x27739B0", Offset = "0x2772BB0", VA = "0x1827739B0", Slot = "42")]
		public bool IJNECKDCLCO(out Guid EHOPIGAHKCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2771D10", Offset = "0x2770F10", VA = "0x182771D10", Slot = "90")]
		public virtual bool BIEFMBADCOL(in Guid MKJGAIOAKMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2773510", Offset = "0x2772710", VA = "0x182773510", Slot = "91")]
		public virtual void FNKHNDBLOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "92")]
		public virtual void AKDLJONBKBC(bool ILIDBACNNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x27749D0", Offset = "0x2773BD0", VA = "0x1827749D0")]
		protected void KLJHBFNLPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "97")]
		protected virtual void DLLPOCPBPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2775410", Offset = "0x2774610", VA = "0x182775410", Slot = "98")]
		protected virtual bool PLNPGMDKNKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675960", Offset = "0x674D60")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "99")]
		protected virtual bool HBHMCJGIBIF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6759C0", Offset = "0x674DC0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "106")]
		protected virtual void ONPLNIFDPJP(JCAMNNBAGPP KBGLEJLCPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2774CC0", Offset = "0x2773EC0", VA = "0x182774CC0", Slot = "68")]
		public void LJJNPKPKFCN(JCAMNNBAGPP MHIKBNGGHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2771D50", Offset = "0x2770F50", VA = "0x182771D50", Slot = "69")]
		public JMAAGPMELEJ BIENFMBNNEA()
		{
			return default(JMAAGPMELEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "107")]
		public virtual bool DPCJBDNDCMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x675DE0", Offset = "0x6751E0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x27747D0", Offset = "0x27739D0", VA = "0x1827747D0")]
		private void KEBKCJLGHKH(in DDAEIDDGCJK BOEKENJNLKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2775350", Offset = "0x2774550", VA = "0x182775350")]
		private void PHNEHJOOPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x27724D0", Offset = "0x27716D0", VA = "0x1827724D0")]
		private void DGMJLOFJNFF(int DPMJOFHJLJG, LLBNMPGAEBJ LFCEPJFCBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2774FB0", Offset = "0x27741B0", VA = "0x182774FB0")]
		private void MLPGDFANACK(int NNAODBDJDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x27736E0", Offset = "0x27728E0", VA = "0x1827736E0")]
		private void IAMGCOLOOHI(int NNAODBDJDNJ, LLBNMPGAEBJ IJPCHENIGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2773E30", Offset = "0x2773030", VA = "0x182773E30")]
		private void JHBIAEGCNHE(int PNPDFOBGMNJ, int DDFKKOGFCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2773550", Offset = "0x2772750", VA = "0x182773550")]
		private void GFFLMFIFHDE(int PNPDFOBGMNJ, int DDFKKOGFCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2773650", Offset = "0x2772850", VA = "0x182773650")]
		private void HFJNFDLCKLL(int NNAODBDJDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2771FA0", Offset = "0x27711A0", VA = "0x182771FA0")]
		private void CIFFDAPINPL(int DPMJOFHJLJG, LLBNMPGAEBJ LFCEPJFCBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2771AC0", Offset = "0x2770CC0", VA = "0x182771AC0")]
		private void AAKOCKEGMAJ(int NNAODBDJDNJ, LLBNMPGAEBJ IJPCHENIGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2771B70", Offset = "0x2770D70", VA = "0x182771B70", Slot = "108")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MMDKICAFDJH<>.DNHFDELILCL))]
		public virtual Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> BEMFEEOJFHJ(string MHAMHEMGGII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x264D990", Offset = "0x264CB90", VA = "0x18264D990", Slot = "25")]
		private bool FJMEGLFFCBD(in DDAEIDDGCJK NABCGCEIEGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2771EC0", Offset = "0x27710C0", VA = "0x182771EC0", Slot = "27")]
		private bool CAIFDAAMHKA(in HBNLMECNNNL NABCGCEIEGG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676420", Offset = "0x675820")]
	private sealed class AICCOMFCCFK : MMDKICAFDJH<PLFDDEPHCNG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8AEE50", Offset = "0x8AE050", VA = "0x1808AEE50", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2104140", Offset = "0x2103340", VA = "0x182104140")]
		public AICCOMFCCFK(COBFIMKODNM DIPIIMIHCJA, PLFDDEPHCNG MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676480", Offset = "0x675880")]
	private sealed class LPEFFOOJJIC : EKGAEPEBNHL<NKELGIIEEBB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xB645E0", Offset = "0xB637E0", VA = "0x180B645E0", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2118380", Offset = "0x2117580", VA = "0x182118380")]
		public LPEFFOOJJIC(COBFIMKODNM DIPIIMIHCJA, NKELGIIEEBB MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6764E0", Offset = "0x6758E0")]
	private abstract class EKGAEPEBNHL<TNode> : MMDKICAFDJH<TNode> where TNode : notnull, AGLIBDAPCGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class PBEEEHCENBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676800", Offset = "0x675C00")]
			public AsyncTaskMethodBuilder<PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public EKGAEPEBNHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private TaskAwaiter<PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public PBEEEHCENBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x2A1C950", Offset = "0x2A1BB50", VA = "0x182A1C950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class HLGFCGIKNGI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676860", Offset = "0x675C60")]
			public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6768C0", Offset = "0x675CC0")]
			public HOGMOCHAFIO<LACIKMLBFJD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public EKGAEPEBNHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public HLGFCGIKNGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x20ABC60", Offset = "0x20AAE60", VA = "0x1820ABC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public sealed override bool BELDKDNPFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6767A0", Offset = "0x675BA0")]
		public sealed override HOGMOCHAFIO<LACIKMLBFJD>? GHECOBLNJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x3144070", Offset = "0x3143270", VA = "0x183144070", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2165C80", Offset = "0x2164E80", VA = "0x182165C80")]
		public EKGAEPEBNHL(COBFIMKODNM DIPIIMIHCJA, TNode MEMCJAOBNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3143CA0", Offset = "0x3142EA0", VA = "0x183143CA0", Slot = "86")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(EKGAEPEBNHL<>.PBEEEHCENBM))]
		public override Task<PINPMIPFEPJ<HOGMOCHAFIO<LACIKMLBFJD>, OKKDIBLBODL>> IGJFCGGGAPJ(string JPKENOAMLIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3143B60", Offset = "0x3142D60", VA = "0x183143B60", Slot = "107")]
		public sealed override bool DPCJBDNDCMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6765B0", Offset = "0x6759B0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3143FD0", Offset = "0x31431D0", VA = "0x183143FD0", Slot = "98")]
		protected sealed override bool PLNPGMDKNKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676610", Offset = "0x675A10")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3143C00", Offset = "0x3142E00", VA = "0x183143C00", Slot = "99")]
		protected override bool HBHMCJGIBIF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676670", Offset = "0x675A70")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3143E40", Offset = "0x3143040", VA = "0x183143E40", Slot = "87")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(EKGAEPEBNHL<>.HLGFCGIKNGI))]
		public override Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> IPOJIMJPEKJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676740", Offset = "0x675B40")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676920", Offset = "0x675D20")]
	private sealed class KDPGHFODLJP : JFKPGPBOPPA<IEMMKCLKOEN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x890110", Offset = "0x88F310", VA = "0x180890110", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override bool KBFKCAMFGGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2115C80", Offset = "0x2114E80", VA = "0x182115C80")]
		public KDPGHFODLJP(COBFIMKODNM DIPIIMIHCJA, IEMMKCLKOEN MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676980", Offset = "0x675D80")]
	private sealed class MDJFBBOPILG : MMDKICAFDJH<OAIEAENHHIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xB4BCF0", Offset = "0xB4AEF0", VA = "0x180B4BCF0", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2118990", Offset = "0x2117B90", VA = "0x182118990")]
		public MDJFBBOPILG(COBFIMKODNM DIPIIMIHCJA, OAIEAENHHIE MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6769E0", Offset = "0x675DE0")]
	private sealed class BFLGBBOBNLF : MMDKICAFDJH<PDNLEIJKMMI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x9A0830", Offset = "0x99FA30", VA = "0x1809A0830", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2104800", Offset = "0x2103A00", VA = "0x182104800")]
		public BFLGBBOBNLF(COBFIMKODNM DIPIIMIHCJA, PDNLEIJKMMI MEMCJAOBNAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676A40", Offset = "0x675E40")]
	private sealed class FDBFANFLDEK : MMDKICAFDJH<LJNGKNDONLD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override NodeVisualizationKey GJDAAKMEFBO
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x7E22A0", Offset = "0x7E14A0", VA = "0x1807E22A0", Slot = "77")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x210BCD0", Offset = "0x210AED0", VA = "0x18210BCD0")]
		public FDBFANFLDEK(COBFIMKODNM DIPIIMIHCJA, LJNGKNDONLD MEMCJAOBNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7E30C0", Offset = "0x7E22C0", VA = "0x1807E30C0", Slot = "98")]
		protected override bool PLNPGMDKNKA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676AA0", Offset = "0x675EA0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x210A6C0", Offset = "0x21098C0", VA = "0x18210A6C0")]
	internal static NJCGFKKGOPK HBHNAKPOBBF(COBFIMKODNM DIPIIMIHCJA, HNKICPEMJJE MEMCJAOBNAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class OIJMNJNFNOH
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x211C510", Offset = "0x211B710", VA = "0x18211C510")]
	public static GANOHBDLJJM<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM>> HOGODIAIMPD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676B00", Offset = "0x675F00")] this in GANOHBDLJJM<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM>> IIGKBFLJPFC)
	{
		return default(GANOHBDLJJM<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM, PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct BKMODJCJDAN
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class PAKOIHJILPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676CF0", Offset = "0x6760F0")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<object, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AKEADGDIFCI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public BKMODJCJDAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PAKOIHJILPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x211CA70", Offset = "0x211BC70", VA = "0x18211CA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JNJCLKFOGDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676D50", Offset = "0x676150")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<bool, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public IHOBKJMFEMC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BCBMDEOFCBP circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public EHKJGJHNGOB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public BKMODJCJDAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676DB0", Offset = "0x6761B0")]
		private AKEADGDIFCI[] <actions>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676E10", Offset = "0x676210")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private bool <isFirst>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676E70", Offset = "0x676270")]
		private AKEADGDIFCI[] <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AKEADGDIFCI <action>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676ED0", Offset = "0x6762D0")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <thisResult>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676F30", Offset = "0x676330")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676F90", Offset = "0x676390")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JNJCLKFOGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x210FF40", Offset = "0x210F140", VA = "0x18210FF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OBPIAFIPLCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676FF0", Offset = "0x6763F0")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public BKMODJCJDAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677050", Offset = "0x676450")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6770B0", Offset = "0x6764B0")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OBPIAFIPLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x211BED0", Offset = "0x211B0D0", VA = "0x18211BED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly KPDEPJCEJAK DMGDKEHBMMF;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	public BKMODJCJDAN(KPDEPJCEJAK BFEBKHPPGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2104FB0", Offset = "0x21041B0", VA = "0x182104FB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PAKOIHJILPE))]
	private Task<PINPMIPFEPJ<object, OKKDIBLBODL>> FIBNLDBJBLB(AKEADGDIFCI AMEKOPCKNIK, bool OOMDCBCHGMH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2104DD0", Offset = "0x2103FD0", VA = "0x182104DD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JNJCLKFOGDL))]
	public Task<PINPMIPFEPJ<bool, OKKDIBLBODL?>>? CEAAKMLBBLH(int ECIKKPDIJLN, IHOBKJMFEMC? LCJFJCHKPIE, BCBMDEOFCBP? HDAJOGJNNGD, EHKJGJHNGOB? GPHICPODLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2105140", Offset = "0x2104340", VA = "0x182105140")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OBPIAFIPLCD))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> NDBCAEEMEJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class PIELJPAOOEI : AJIGMFLDNLP
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class EJCKHLBLLHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class DDHILNFNCEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public OAMJIJCCHCP spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public DDHILNFNCEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x666EE40", Offset = "0x666E040", VA = "0x18666EE40")]
			internal bool GCMMAEBAADA(AEFCBACNLDK n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class NDKBBHFBFHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public NDKBBHFBFHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x6673300", Offset = "0x6672500", VA = "0x186673300")]
			internal void KDEHIGNNBJP(AEFCBACNLDK n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x666F6F0", Offset = "0x666E8F0", VA = "0x18666F6F0")]
		public static PINPMIPFEPJ<AJIGMFLDNLP.NLONJJNKPOJ, NKHHFMGDFFF> GNJLBDDANJL(PIELJPAOOEI KPIHKJNPOFH, in AJIGMFLDNLP.GJLLIHOLOCJ LCGFCGNMPHN)
		{
			return default(PINPMIPFEPJ<AJIGMFLDNLP.NLONJJNKPOJ, NKHHFMGDFFF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6670080", Offset = "0x666F280", VA = "0x186670080")]
		internal static PINPMIPFEPJ<MHBEJPOAIOP, OKKDIBLBODL> MEBMEKIIOIH(PIELJPAOOEI KPIHKJNPOFH, NEIBEMLJLHM HLKDOCNOCAP, bool DAIHICNGAAA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677670", Offset = "0x676A70")] in NNDHFAJHACK<ICMDIGALLLM> APHNEOJMMCL, in int? FCPFIHCAAHF, in JMAAGPMELEJ? ILLDFHNLKFG, in JMAAGPMELEJ? JCDFFFLCJOM)
		{
			return default(PINPMIPFEPJ<MHBEJPOAIOP, OKKDIBLBODL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x666FBB0", Offset = "0x666EDB0", VA = "0x18666FBB0")]
		private static void LAAHAAKGFIH(bool DAIHICNGAAA, KHALLJGHNEA LDGNEFNKJHM, MHBEJPOAIOP IHCNPHGCIMK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6776E0", Offset = "0x676AE0")] in NNDHFAJHACK<ICMDIGALLLM> APHNEOJMMCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x666F160", Offset = "0x666E360", VA = "0x18666F160")]
		public static void BBMPBDAMKIB(ODIHKEOCBHO IBEBLIAOPHC, in AJIGMFLDNLP.CLGPLIKCMJA IPPCFJKKAOA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly COBFIMKODNM BANGPOFOHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly ANLKOEPIABB CFMGFGIGHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly JDNAPDNLFFL IKBEFNMDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly GNKCIKAGBGF COFEBFGNGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly IPDEAGDHNLK AGKIHBMAPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677110", Offset = "0x676510")]
	private Dictionary<NNDHFAJHACK<JDAAGGKKBIF>, NJCGFKKGOPK> OKCFKIJPELM;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x211E650", Offset = "0x211D850", VA = "0x18211E650")]
	public PIELJPAOOEI(COBFIMKODNM DIPIIMIHCJA, ANLKOEPIABB NOBMGIPLEDC, JDNAPDNLFFL LGEPEIKMLJD, IPDEAGDHNLK JBKJIPJEFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x211CF50", Offset = "0x211C150", VA = "0x18211CF50")]
	public NJCGFKKGOPK? AFOLHMEIAIG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677170", Offset = "0x676570")] in NNDHFAJHACK<JDAAGGKKBIF?> ICCMHBOIOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x211E5F0", Offset = "0x211D7F0", VA = "0x18211E5F0")]
	private void PIBJALLDFEA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6771E0", Offset = "0x6765E0")] NNDHFAJHACK<JDAAGGKKBIF> ICCMHBOIOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x211DED0", Offset = "0x211D0D0", VA = "0x18211DED0")]
	private NJCGFKKGOPK? LHMIICAILNK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677240", Offset = "0x676640")] in NNDHFAJHACK<JDAAGGKKBIF?> ICCMHBOIOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x211D1A0", Offset = "0x211C3A0", VA = "0x18211D1A0")]
	public HNKICPEMJJE? DFJJLIJPMND([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6772B0", Offset = "0x6766B0")] in NNDHFAJHACK<JDAAGGKKBIF?> ICCMHBOIOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x211D450", Offset = "0x211C650", VA = "0x18211D450")]
	public DBHHEEOJOHF? FKDOCIBGBKJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677320", Offset = "0x676720")] in NNDHFAJHACK<ICMDIGALLLM?> MKJGAIOAKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x211D460", Offset = "0x211C660", VA = "0x18211D460")]
	private OAMJIJCCHCP? FMFNDMDOGPD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677390", Offset = "0x676790")] in NNDHFAJHACK<ICMDIGALLLM?> MKJGAIOAKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x211D9E0", Offset = "0x211CBE0", VA = "0x18211D9E0")]
	private DBHHEEOJOHF? HOMENFJAJNB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677400", Offset = "0x676800")] in NNDHFAJHACK<ICMDIGALLLM?> MKJGAIOAKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x211DF70", Offset = "0x211D170", VA = "0x18211DF70", Slot = "6")]
	public IEnumerable<AGDHOILCPAO> LKFMOKEALCM(bool FMHEEKPAILC, bool HGOGCHJDFPC, bool PCOENCNBCGL, bool GGKHNDHOCGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x211D100", Offset = "0x211C300", VA = "0x18211D100")]
	public PINPMIPFEPJ<AJIGMFLDNLP.NLONJJNKPOJ, NKHHFMGDFFF> DJADLNMIPEP(in AJIGMFLDNLP.GJLLIHOLOCJ LCGFCGNMPHN)
	{
		return default(PINPMIPFEPJ<AJIGMFLDNLP.NLONJJNKPOJ, NKHHFMGDFFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x211D220", Offset = "0x211C420", VA = "0x18211D220", Slot = "8")]
	public FKDMMCCLALO FAIJNIBKJOA(IEnumerable<KHALLJGHNEA> JKPOBBNIMGM)
	{
		return default(FKDMMCCLALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x211E070", Offset = "0x211D270", VA = "0x18211E070", Slot = "9")]
	public FKDMMCCLALO LNPFIOCGMAL()
	{
		return default(FKDMMCCLALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x211D4F0", Offset = "0x211C6F0", VA = "0x18211D4F0")]
	private IOOBANILAFG GHKHAEGHJLE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677470", Offset = "0x676870")] IEnumerable<NNDHFAJHACK<ICMDIGALLLM>> BIFPJFGBFHD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6774D0", Offset = "0x6768D0")] IEnumerable<NNDHFAJHACK<JDAAGGKKBIF>> DKFNFJPEFHJ, OJFPFLIENHC BAPGHNMPPGJ)
	{
		return default(IOOBANILAFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x211D6A0", Offset = "0x211C8A0", VA = "0x18211D6A0", Slot = "10")]
	public IOOBANILAFG GHKHAEGHJLE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677530", Offset = "0x676930")] IEnumerable<NNDHFAJHACK<JDAAGGKKBIF>> DKFNFJPEFHJ, IEnumerable<KHALLJGHNEA> JKPOBBNIMGM, OJFPFLIENHC BAPGHNMPPGJ = OJFPFLIENHC.CopyPaste)
	{
		return default(IOOBANILAFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x211DBD0", Offset = "0x211CDD0", VA = "0x18211DBD0")]
	private static IEnumerable<NNDHFAJHACK<ICMDIGALLLM>> JDJJMPJOJNC(IEnumerable<KHALLJGHNEA> JKPOBBNIMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x211E230", Offset = "0x211D430", VA = "0x18211E230")]
	private IEnumerable<NNDHFAJHACK<JDAAGGKKBIF>> OIHEGIFHBOE(IEnumerable<KHALLJGHNEA> JKPOBBNIMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x211D450", Offset = "0x211C650", VA = "0x18211D450", Slot = "4")]
	private DBHHEEOJOHF FNLMHGLMJNK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677590", Offset = "0x676990")] in NNDHFAJHACK<ICMDIGALLLM> MKJGAIOAKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x211CF50", Offset = "0x211C150", VA = "0x18211CF50", Slot = "5")]
	private NJCGFKKGOPK PHGPMIDAFMP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677600", Offset = "0x676A00")] in NNDHFAJHACK<JDAAGGKKBIF> ICCMHBOIOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x211D100", Offset = "0x211C300", VA = "0x18211D100", Slot = "7")]
	private PINPMIPFEPJ<AJIGMFLDNLP.NLONJJNKPOJ, NKHHFMGDFFF> CCHOAAOCELK(in AJIGMFLDNLP.GJLLIHOLOCJ LCGFCGNMPHN)
	{
		return default(PINPMIPFEPJ<AJIGMFLDNLP.NLONJJNKPOJ, NKHHFMGDFFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x211D130", Offset = "0x211C330", VA = "0x18211D130")]
	[CompilerGenerated]
	private BJAAEIJGFHB DBJLPDMOHBO(DOHCCNMLPPO LHPGLCOPMKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x211E1C0", Offset = "0x211D3C0", VA = "0x18211E1C0")]
	[CompilerGenerated]
	private HNKICPEMJJE MGMPELGBEFE(NNDHFAJHACK<JDAAGGKKBIF> LHPGLCOPMKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x211D090", Offset = "0x211C290", VA = "0x18211D090")]
	[CompilerGenerated]
	private OAMJIJCCHCP APPDDFFAFKD(NNDHFAJHACK<ICMDIGALLLM> LHPGLCOPMKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class FMGNBJLPNPP : ANLKOEPIABB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface GOBODOEJJEM
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		BJHHAEFPNIG PODDOILAMGI
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BCBMDEOFCBP> HEPKJJKJNIP(CancellationToken MELLLMEKJLC);

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<EHKJGJHNGOB> JEJFFMNACCF(CancellationToken MELLLMEKJLC);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<IBHFMJGAMEO> EGMADNNFLMF(CancellationToken MELLLMEKJLC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KJKMFGBLCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder<FMGNBJLPNPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public COBFIMKODNM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public BCBMDEOFCBP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public EHKJGJHNGOB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private GOBODOEJJEM <selfDeps>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private BCBMDEOFCBP <downloadedRoomData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private EHKJGJHNGOB <downloadedSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private KCFJMKFPIJE <cloudDataLedgerData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private RepeatedField<DDJPOIDHDKM> <rewardData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private BLAJGJCOMNP <progressionTableData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private EHKJGJHNGOB <finalSuperRoomData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private IBHFMJGAMEO <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ANPMGNONDHL <cv2State>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private BCBMDEOFCBP <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private EHKJGJHNGOB <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private IBHFMJGAMEO <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6777C0", Offset = "0x676BC0")]
		private TaskAwaiter<BCBMDEOFCBP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677820", Offset = "0x676C20")]
		private TaskAwaiter<EHKJGJHNGOB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677880", Offset = "0x676C80")]
		private TaskAwaiter<IBHFMJGAMEO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KJKMFGBLCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x21162E0", Offset = "0x21154E0", VA = "0x1821162E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly ANPMGNONDHL BOMPCHEKAFL;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public ANPMGNONDHL KCLABJOCIFB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	private FMGNBJLPNPP(ANPMGNONDHL FDBMLEGLFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x210C270", Offset = "0x210B470", VA = "0x18210C270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KJKMFGBLCFD))]
	public static Task<FMGNBJLPNPP> KGPNPJBIDCN(COBFIMKODNM DIPIIMIHCJA, BCBMDEOFCBP? DONGKHHNBIB, EHKJGJHNGOB? GPHICPODLBN, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x210C250", Offset = "0x210B450", VA = "0x18210C250", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[OAEHNEMGJME("IStaticEVInstance")]
public interface JDNAPDNLFFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	CCOHKDMNIBE EPAKECLNDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class IIAHACKKGJM : CKFHAACMBGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface AOAGJCBPJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LIKJHJPBELM> HECPFLMELOK(COBFIMKODNM DIPIIMIHCJA, IHOBKJMFEMC AHGFOCJNNED, BCBMDEOFCBP? JIHPLICGAIA, EHKJGJHNGOB? OKLBGAHAEIE, CancellationToken MELLLMEKJLC);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DANIBBOAKLH();

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LLJNKNCCFGG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class KDIBLEFMODI : AOAGJCBPJMC
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class KDLHCPBDBNF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public AsyncTaskMethodBuilder<LIKJHJPBELM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public COBFIMKODNM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public IHOBKJMFEMC evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public BCBMDEOFCBP cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public EHKJGJHNGOB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public KDIBLEFMODI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private OIBPAHNOGOJ <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677AC0", Offset = "0x676EC0")]
			private TaskAwaiter<OIBPAHNOGOJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public KDLHCPBDBNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6672440", Offset = "0x6671640", VA = "0x186672440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2115A70", Offset = "0x2114C70", VA = "0x182115A70", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KDLHCPBDBNF))]
		public Task<LIKJHJPBELM> HECPFLMELOK(COBFIMKODNM DIPIIMIHCJA, IHOBKJMFEMC AHGFOCJNNED, BCBMDEOFCBP? JIHPLICGAIA, EHKJGJHNGOB? OKLBGAHAEIE, CancellationToken MELLLMEKJLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void DANIBBOAKLH();

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void LLJNKNCCFGG();

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		protected KDIBLEFMODI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PPNPDCMKOIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AsyncTaskMethodBuilder<LIKJHJPBELM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public IIAHACKKGJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter<CKDLGNFJNCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PPNPDCMKOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x211EFA0", Offset = "0x211E1A0", VA = "0x18211EFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LKOCHCFCKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public COBFIMKODNM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public IHOBKJMFEMC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public BCBMDEOFCBP cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public EHKJGJHNGOB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IIAHACKKGJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private LIKJHJPBELM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677B20", Offset = "0x676F20")]
		private TaskAwaiter<LIKJHJPBELM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LKOCHCFCKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2117DA0", Offset = "0x2116FA0", VA = "0x182117DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly AOAGJCBPJMC KBFCOPLBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly TaskCompletionSource<CKDLGNFJNCJ> AEPGIGOJENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly TaskCompletionSource<CKDLGNFJNCJ> ALIPEDOAMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly CancellationTokenSource PDPPNNNIDPH;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool PPCKCOGLCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x929880", Offset = "0x928A80", VA = "0x180929880", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9298C0", Offset = "0x928AC0", VA = "0x1809298C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x929890", Offset = "0x928A90", VA = "0x180929890", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9298E0", Offset = "0x928AE0", VA = "0x1809298E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool AMOKBANEIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC94430", Offset = "0xC93630", VA = "0x180C94430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x210E910", Offset = "0x210DB10", VA = "0x18210E910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LIKJHJPBELM? EFBCGIFGDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x210E7C0", Offset = "0x210D9C0", VA = "0x18210E7C0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPNPDCMKOIJ))]
	public Task<LIKJHJPBELM> HMEBEDELIIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x210E920", Offset = "0x210DB20", VA = "0x18210E920")]
	public IIAHACKKGJM(AOAGJCBPJMC NKPJOKLGAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x210E450", Offset = "0x210D650", VA = "0x18210E450", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LKOCHCFCKFL))]
	public Task BEBGBLHONFO(COBFIMKODNM DIPIIMIHCJA, IHOBKJMFEMC AHGFOCJNNED, BCBMDEOFCBP? JIHPLICGAIA, EHKJGJHNGOB? OKLBGAHAEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x210E610", Offset = "0x210D810", VA = "0x18210E610", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[OAEHNEMGJME("IStaticCV2Instance")]
public interface ANLKOEPIABB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	ANPMGNONDHL KCLABJOCIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class BJCADDNPCDN : CGCLPPKEBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly COBFIMKODNM BANGPOFOHOG;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public JKKKHDOELHF? JHOAALADPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2104CE0", Offset = "0x2103EE0", VA = "0x182104CE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	internal BJCADDNPCDN(COBFIMKODNM DIPIIMIHCJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class MGHOBMFMHHD : KMHFDNEBEHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly PIELJPAOOEI GDHOOHLEMDC;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public MGHOBMFMHHD(PIELJPAOOEI BDCDMFEJFAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class IBJMOEDIKJN : NFMJIICBGIM, DKCJPOEDOGH, EHBPFJBKPDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677EF0", Offset = "0x6772F0")]
	public HOGMOCHAFIO<LMGKNPKGIBN> OKOILOEPLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xB647A0", Offset = "0xB639A0", VA = "0x180B647A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(HOGMOCHAFIO<LMGKNPKGIBN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x14ECE20", Offset = "0x14EC020", VA = "0x1814ECE20")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677C50", Offset = "0x677050")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677F50", Offset = "0x677350")]
	public override HOGMOCHAFIO<DAJLACINGLM> BNAMEAFKKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x210D970", Offset = "0x210CB70", VA = "0x18210D970", Slot = "19")]
		get
		{
			return default(HOGMOCHAFIO<DAJLACINGLM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x210D9B0", Offset = "0x210CBB0", VA = "0x18210D9B0")]
	private IBJMOEDIKJN(COBFIMKODNM DIPIIMIHCJA, HNKICPEMJJE MEMCJAOBNAO, BBGGKEPPIIF KCDMDNOHHNN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677CB0", Offset = "0x6770B0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677D10", Offset = "0x677110")] HOGMOCHAFIO<LMGKNPKGIBN> OJFIKOGMAOL, bool ICDAFNPNAJK, string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x210D670", Offset = "0x210C870", VA = "0x18210D670")]
	public static IBJMOEDIKJN HBHNAKPOBBF(COBFIMKODNM DIPIIMIHCJA, HNKICPEMJJE MEMCJAOBNAO, BBGGKEPPIIF DPLIIGPJAPF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677D70", Offset = "0x677170")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677DD0", Offset = "0x6771D0")] HOGMOCHAFIO<GOHONMAKFBH> PKDNKNMCOMB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677E30", Offset = "0x677230")] HOGMOCHAFIO<LMGKNPKGIBN> OJFIKOGMAOL, bool ICDAFNPNAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x14ECE20", Offset = "0x14EC020", VA = "0x1814ECE20")]
	internal void HFJLKEJOONC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x677E90", Offset = "0x677290")] HOGMOCHAFIO<LMGKNPKGIBN> NABCGCEIEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class BJAAEIJGFHB : AGDHOILCPAO
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MDGFKCGABEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6782B0", Offset = "0x6776B0")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<HOGMOCHAFIO<ALBFEPNKGJA>, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678310", Offset = "0x677710")]
		public NNDHFAJHACK<ICMDIGALLLM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678370", Offset = "0x677770")]
		public NNDHFAJHACK<JDAAGGKKBIF> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6783D0", Offset = "0x6777D0")]
		public HOGMOCHAFIO<LACIKMLBFJD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public BJAAEIJGFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private PINPMIPFEPJ<HOGMOCHAFIO<ALBFEPNKGJA>, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter<PINPMIPFEPJ<HOGMOCHAFIO<ALBFEPNKGJA>, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MDGFKCGABEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2118730", Offset = "0x2117930", VA = "0x182118730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class IDBCFOBKMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678430", Offset = "0x677830")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<HOGMOCHAFIO<GOHONMAKFBH>, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678490", Offset = "0x677890")]
		public NNDHFAJHACK<ICMDIGALLLM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6784F0", Offset = "0x6778F0")]
		public NNDHFAJHACK<JDAAGGKKBIF> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678550", Offset = "0x677950")]
		public HOGMOCHAFIO<LACIKMLBFJD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public BJAAEIJGFHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private PINPMIPFEPJ<HOGMOCHAFIO<GOHONMAKFBH>, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter<PINPMIPFEPJ<HOGMOCHAFIO<GOHONMAKFBH>, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IDBCFOBKMDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x210DA00", Offset = "0x210CC00", VA = "0x18210DA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly DOHCCNMLPPO OKNPEDKHFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ANLKOEPIABB CFMGFGIGHJM;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string BIDAFJAAAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2104860", Offset = "0x2103A60", VA = "0x182104860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2104C30", Offset = "0x2103E30", VA = "0x182104C30")]
	public BJAAEIJGFHB(DOHCCNMLPPO MPEFDPOKCNF, ANLKOEPIABB NOBMGIPLEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2104890", Offset = "0x2103A90", VA = "0x182104890", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MDGFKCGABEG))]
	public Task<PINPMIPFEPJ<HOGMOCHAFIO<ALBFEPNKGJA>, OKKDIBLBODL>> HOBLLBLCDNA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678010", Offset = "0x677410")] NNDHFAJHACK<ICMDIGALLLM> MKJGAIOAKMJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678070", Offset = "0x677470")] NNDHFAJHACK<JDAAGGKKBIF> ICCMHBOIOOM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6780D0", Offset = "0x6774D0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, string JPKENOAMLIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2104A60", Offset = "0x2103C60", VA = "0x182104A60", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDBCFOBKMDK))]
	public Task<PINPMIPFEPJ<HOGMOCHAFIO<GOHONMAKFBH>, OKKDIBLBODL>> LDMAGCIJEAE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678190", Offset = "0x677590")] NNDHFAJHACK<ICMDIGALLLM> MKJGAIOAKMJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6781F0", Offset = "0x6775F0")] NNDHFAJHACK<JDAAGGKKBIF> ICCMHBOIOOM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678250", Offset = "0x677650")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, string JPKENOAMLIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class OIBPAHNOGOJ : LIKJHJPBELM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public interface ADNFENEBIML
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ANLKOEPIABB> EHPFDAOFALM(COBFIMKODNM DIPIIMIHCJA, BCBMDEOFCBP? JIHPLICGAIA, EHKJGJHNGOB? OKLBGAHAEIE, CancellationToken MELLLMEKJLC);

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JDNAPDNLFFL LOOFBKMHHKF(COBFIMKODNM DIPIIMIHCJA, IHOBKJMFEMC AHGFOCJNNED);
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class DHNJHPHDFHK : ADNFENEBIML
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class GEPGELCNIFL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public AsyncTaskMethodBuilder<ANLKOEPIABB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public COBFIMKODNM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public BCBMDEOFCBP cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public EHKJGJHNGOB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public DHNJHPHDFHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private FMGNBJLPNPP <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678680", Offset = "0x677A80")]
			private TaskAwaiter<FMGNBJLPNPP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public GEPGELCNIFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x6671640", Offset = "0x6670840", VA = "0x186671640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly DHNJHPHDFHK JHOAALADPKE;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		private DHNJHPHDFHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x666EEF0", Offset = "0x666E0F0", VA = "0x18666EEF0", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GEPGELCNIFL))]
		public Task<ANLKOEPIABB> EHPFDAOFALM(COBFIMKODNM DIPIIMIHCJA, BCBMDEOFCBP? JIHPLICGAIA, EHKJGJHNGOB? OKLBGAHAEIE, CancellationToken MELLLMEKJLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x666F0E0", Offset = "0x666E2E0", VA = "0x18666F0E0", Slot = "5")]
		public JDNAPDNLFFL LOOFBKMHHKF(COBFIMKODNM DIPIIMIHCJA, IHOBKJMFEMC AHGFOCJNNED)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JMABPKKJBNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder<OIBPAHNOGOJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public COBFIMKODNM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public IHOBKJMFEMC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public BCBMDEOFCBP cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EHKJGJHNGOB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private ADNFENEBIML <selfDeps>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private ANLKOEPIABB <cv2RootSys>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private JDNAPDNLFFL <evRootSys>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private ANLKOEPIABB <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6786E0", Offset = "0x677AE0")]
		private TaskAwaiter<ANLKOEPIABB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JMABPKKJBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6671F40", Offset = "0x6671140", VA = "0x186671F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly ANLKOEPIABB CFMGFGIGHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly JDNAPDNLFFL IKBEFNMDHOO;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GCNMPMNNNKF BGILODEECMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x211C150", Offset = "0x211B350", VA = "0x18211C150", Slot = "4")]
		get
		{
			return default(GCNMPMNNNKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public OJAPJBMMFFA DKJADDNPIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x211C410", Offset = "0x211B610", VA = "0x18211C410", Slot = "5")]
		get
		{
			return default(OJAPJBMMFFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public KFFFGLJNNOB JLOGGJMDPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public PIELJPAOOEI NPHMENHPKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public MNIGHBGDCJH IDIBGKKPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x211C480", Offset = "0x211B680", VA = "0x18211C480")]
	private OIBPAHNOGOJ(ANLKOEPIABB NOBMGIPLEDC, JDNAPDNLFFL LGEPEIKMLJD, KFFFGLJNNOB BCAFAMKECEH, PIELJPAOOEI BDCDMFEJFAI, MNIGHBGDCJH CBFANGHJDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x211C220", Offset = "0x211B420", VA = "0x18211C220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMABPKKJBNL))]
	public static Task<OIBPAHNOGOJ> KGPNPJBIDCN(COBFIMKODNM DIPIIMIHCJA, IHOBKJMFEMC AHGFOCJNNED, BCBMDEOFCBP? JIHPLICGAIA, EHKJGJHNGOB? OKLBGAHAEIE, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x211C1C0", Offset = "0x211B3C0", VA = "0x18211C1C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface CKFHAACMBGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	LIKJHJPBELM? EFBCGIFGDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool PPCKCOGLCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<LIKJHJPBELM?>? HMEBEDELIIG();

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BEBGBLHONFO(COBFIMKODNM DIPIIMIHCJA, IHOBKJMFEMC AHGFOCJNNED, BCBMDEOFCBP? JIHPLICGAIA, EHKJGJHNGOB? OKLBGAHAEIE);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class MNIGHBGDCJH : JKKKHDOELHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly ANLKOEPIABB CFMGFGIGHJM;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public ENNCIKOALFP FIBNLDBJBLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2118DA0", Offset = "0x2117FA0", VA = "0x182118DA0", Slot = "4")]
		get
		{
			return default(ENNCIKOALFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public DECKFMCFPMG LMCNANACPOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2118E70", Offset = "0x2118070", VA = "0x182118E70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678820", Offset = "0x677C20")]
	public NNDHFAJHACK<ICMDIGALLLM> MFNJPJGLKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2118ED0", Offset = "0x21180D0", VA = "0x182118ED0", Slot = "6")]
		get
		{
			return default(NNDHFAJHACK<ICMDIGALLLM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public ANPMGNONDHL GGNFHLDOMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2118F30", Offset = "0x2118130", VA = "0x182118F30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public MNIGHBGDCJH(ANLKOEPIABB NOBMGIPLEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2118E00", Offset = "0x2118000", VA = "0x182118E00")]
	public bool GLHIKFGLIKP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678740", Offset = "0x677B40")] in NNDHFAJHACK<ICMDIGALLLM> MKJGAIOAKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2118E00", Offset = "0x2118000", VA = "0x182118E00", Slot = "8")]
	private bool LMKKGLBEJIO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6787B0", Offset = "0x677BB0")] in NNDHFAJHACK<ICMDIGALLLM> MKJGAIOAKMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public sealed class CIKCKIFAAAH : NFMJIICBGIM, ELBIBNLNAKO, EHBPFJBKPDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class CNJICHGMFJM
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private sealed class <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public PBCNIAJDNKJ errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public CNJICHGMFJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x6673330", Offset = "0x6672530", VA = "0x186673330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public CIKCKIFAAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CNJICHGMFJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x21081F0", Offset = "0x21073F0", VA = "0x1821081F0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task CMIEFDJLKIB(PBCNIAJDNKJ errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JMCCCCHLEPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public CIKCKIFAAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private bool <isPure>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private LCPGIEPPFLN <signal>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JMCCCCHLEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x210FA50", Offset = "0x210EC50", VA = "0x18210FA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class HANGPHONIDC
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private sealed class <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public PBCNIAJDNKJ errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public HANGPHONIDC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x66735A0", Offset = "0x66727A0", VA = "0x1866735A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public CIKCKIFAAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public HANGPHONIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x210CA70", Offset = "0x210BC70", VA = "0x18210CA70")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HBCDEKFMDID(PBCNIAJDNKJ errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly IGNGFJDLHPN BPNDCENGEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly ICollection<EBFEDHMJEOH> GIPIKPMCDKF;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private GJCNAAJHMHF AEPNCHCMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2107BB0", Offset = "0x2106DB0", VA = "0x182107BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678C10", Offset = "0x678010")]
	public HOGMOCHAFIO<GKDGBEBJKOB> DAHJHNMCBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xFCB3F0", Offset = "0xFCA5F0", VA = "0x180FCB3F0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(HOGMOCHAFIO<GKDGBEBJKOB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xFCB3D0", Offset = "0xFCA5D0", VA = "0x180FCB3D0")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678910", Offset = "0x677D10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678C70", Offset = "0x678070")]
	public override HOGMOCHAFIO<DAJLACINGLM> BNAMEAFKKOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2106E80", Offset = "0x2106080", VA = "0x182106E80", Slot = "19")]
		get
		{
			return default(HOGMOCHAFIO<DAJLACINGLM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool OPFBHGGHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2105AE0", Offset = "0x2104CE0", VA = "0x182105AE0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2108100", Offset = "0x2107300", VA = "0x182108100")]
	private CIKCKIFAAAH(COBFIMKODNM DIPIIMIHCJA, HNKICPEMJJE MEMCJAOBNAO, IGNGFJDLHPN OEENCAKNOOM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678970", Offset = "0x677D70")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6789D0", Offset = "0x677DD0")] HOGMOCHAFIO<GKDGBEBJKOB> FOIFMMOKJPC, bool ICDAFNPNAJK, string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x21067B0", Offset = "0x21059B0", VA = "0x1821067B0")]
	public static CIKCKIFAAAH HBHNAKPOBBF(COBFIMKODNM DIPIIMIHCJA, HNKICPEMJJE MEMCJAOBNAO, IGNGFJDLHPN FBJAKOEONGA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678A30", Offset = "0x677E30")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678A90", Offset = "0x677E90")] HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678AF0", Offset = "0x677EF0")] HOGMOCHAFIO<GKDGBEBJKOB> FOIFMMOKJPC, bool ICDAFNPNAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2106F10", Offset = "0x2106110", VA = "0x182106F10", Slot = "20")]
	protected override void KCEHONPEIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2106280", Offset = "0x2105480", VA = "0x182106280", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2106430", Offset = "0x2105630", VA = "0x182106430", Slot = "28")]
	public void EMDDFBNMKOM(EBFEDHMJEOH CCDLMOIFMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x21056D0", Offset = "0x21048D0", VA = "0x1821056D0", Slot = "25")]
	public void AMKCMMIOPEG(CIJCEHEKADF HKEHFDNCNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2107160", Offset = "0x2106360", VA = "0x182107160", Slot = "26")]
	public void LJJNPKPKFCN(EBIJPNIGNEH AJIHAPJACGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2105EC0", Offset = "0x21050C0", VA = "0x182105EC0", Slot = "22")]
	protected override void DKKJJDCKLEG(EOJMHAICGII GCBALOFJKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x21060F0", Offset = "0x21052F0", VA = "0x1821060F0", Slot = "30")]
	public string DPDMFNDCMNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2107E00", Offset = "0x2107000", VA = "0x182107E00", Slot = "27")]
	public string PLAALJEPACH(int JFAGLBDJNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2107C20", Offset = "0x2106E20", VA = "0x182107C20")]
	private void OMIDCEMCMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2105930", Offset = "0x2104B30", VA = "0x182105930", Slot = "29")]
	public void CCAAPFJBOFC(EBFEDHMJEOH CCDLMOIFMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2106BF0", Offset = "0x2105DF0", VA = "0x182106BF0")]
	private void IGLEOJMGNJN(bool NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2106660", Offset = "0x2105860", VA = "0x182106660", Slot = "31")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JMCCCCHLEPJ))]
	public Task GNOCAGDCPNP(string NABCGCEIEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2105FA0", Offset = "0x21051A0", VA = "0x182105FA0")]
	public void DLNPIPGHOIE(string NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2105CE0", Offset = "0x2104EE0", VA = "0x182105CE0")]
	private void DDDLBMOJFFJ(int NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0xFCB3D0", Offset = "0xFCA5D0", VA = "0x180FCB3D0")]
	internal void NNABDICPFCD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x678BB0", Offset = "0x677FB0")] HOGMOCHAFIO<GKDGBEBJKOB> NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2107AE0", Offset = "0x2106CE0", VA = "0x182107AE0")]
	[CompilerGenerated]
	private bool MEDGBDFDAMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2106B20", Offset = "0x2105D20", VA = "0x182106B20")]
	[CompilerGenerated]
	private bool HDKIJHHPGHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2106EC0", Offset = "0x21060C0", VA = "0x182106EC0")]
	[CompilerGenerated]
	private int MDGAMONAIOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2106DE0", Offset = "0x2105FE0", VA = "0x182106DE0")]
	[CompilerGenerated]
	private bool JPBOFKLNBFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2105600", Offset = "0x2104800", VA = "0x182105600")]
	[CompilerGenerated]
	private bool AGDKEMKPDOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2107BD0", Offset = "0x2106DD0", VA = "0x182107BD0")]
	[CompilerGenerated]
	private bool OLOMLNCBEEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x21070C0", Offset = "0x21062C0", VA = "0x1821070C0")]
	[CompilerGenerated]
	private bool LBHHECFDHFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2106EC0", Offset = "0x21060C0", VA = "0x182106EC0")]
	[CompilerGenerated]
	private int KCAEFJGGGEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x21059F0", Offset = "0x2104BF0", VA = "0x1821059F0")]
	[CompilerGenerated]
	private bool CCEHMPHHDCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x21058E0", Offset = "0x2104AE0", VA = "0x1821058E0")]
	[CompilerGenerated]
	private int BOBNKBFHFGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x21064F0", Offset = "0x21056F0", VA = "0x1821064F0")]
	[CompilerGenerated]
	private void EOMCCCHMBJM(object NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2106570", Offset = "0x2105770", VA = "0x182106570")]
	[CompilerGenerated]
	private bool GMLAMNBCBGI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class HHKDIOLPKKM
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class CIIHAJJEMLI<TGraph> : DBHHEEOJOHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		protected readonly TGraph LFIOBPKBGHO;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual BBBOOMPEHND? JDNBILJHHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA20090", Offset = "0xA1F290", VA = "0x180A20090", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1C453A0", Offset = "0x1C445A0", VA = "0x181C453A0")]
		public CIIHAJJEMLI(TGraph HEMDALANHJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FA00", Offset = "0x66EE00")]
	private sealed class GMEJMBCBBKJ : CIIHAJJEMLI<ADFNKKDFMPI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public override BBBOOMPEHND? JDNBILJHHEO
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x210C750", Offset = "0x210B950", VA = "0x18210C750", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x210C770", Offset = "0x210B970", VA = "0x18210C770")]
		public GMEJMBCBBKJ(ADFNKKDFMPI AHCDHLPCGML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x210CF90", Offset = "0x210C190", VA = "0x18210CF90")]
	public static DBHHEEOJOHF HBHNAKPOBBF(OAMJIJCCHCP HEMDALANHJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class NOFKKMOMNIM : NPJIJDMGBJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly COBFIMKODNM BANGPOFOHOG;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool PPCKCOGLCFN
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x211A750", Offset = "0x2119950", VA = "0x18211A750", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	internal NOFKKMOMNIM(COBFIMKODNM DIPIIMIHCJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class NFMJIICBGIM : EHBPFJBKPDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private struct JFMFGFNMBEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private OBCMKACLDKA? IBOEDJGFLOK;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x37112C0", Offset = "0x37104C0", VA = "0x1837112C0")]
		public void HNOBOGMOMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6671EB0", Offset = "0x66710B0", VA = "0x186671EB0")]
		public OBCMKACLDKA ANKEHFNAJEE(NFMJIICBGIM MAPFEFCGLGE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	protected readonly COBFIMKODNM BANGPOFOHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	protected readonly HNKICPEMJJE OKNCEHDAGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private JFMFGFNMBEK ODCDPIGLBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly DCJANAONGCG LMEMBMMJJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly List<IMLGPLMMMCO> PKBPOFGMBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<JMOJBNDGLKA> ODDNFEHCNMG;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IEnumerable<StaticEdge> OENJJCNKEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2119CB0", Offset = "0x2118EB0", VA = "0x182119CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DisplayKind JMCBNJFBPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x9162B0", Offset = "0x9154B0", VA = "0x1809162B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FC50", Offset = "0x66F050")]
	public NNDHFAJHACK<ICMDIGALLLM> NAHPHGJADGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x211A0D0", Offset = "0x21192D0", VA = "0x18211A0D0", Slot = "6")]
		get
		{
			return default(NNDHFAJHACK<ICMDIGALLLM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	protected DOHCCNMLPPO LPJIELLMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1B1CDD0", Offset = "0x1B1BFD0", VA = "0x181B1CDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public AJBOALEOCFJ HLBGBAELOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2119AF0", Offset = "0x2118CF0", VA = "0x182119AF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	protected OBCMKACLDKA HKMDBKECMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2119AF0", Offset = "0x2118CF0", VA = "0x182119AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public PortImage FLEFLLNDJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x211A020", Offset = "0x2119220", VA = "0x18211A020", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x9ED510", Offset = "0x9EC710", VA = "0x1809ED510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FCC0", Offset = "0x66F0C0")]
	public NNDHFAJHACK<JDAAGGKKBIF> EKMCEGABMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x211A100", Offset = "0x2119300", VA = "0x18211A100", Slot = "8")]
		get
		{
			return default(NNDHFAJHACK<JDAAGGKKBIF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FD30", Offset = "0x66F130")]
	public HOGMOCHAFIO<LACIKMLBFJD> JNECGBLOJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA30B60", Offset = "0xA2FD60", VA = "0x180A30B60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(HOGMOCHAFIO<LACIKMLBFJD>);
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA2F290", Offset = "0xA2E490", VA = "0x180A2F290")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FB30", Offset = "0x66EF30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FD90", Offset = "0x66F190")]
	public abstract HOGMOCHAFIO<DAJLACINGLM> BNAMEAFKKOE
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x211A180", Offset = "0x2119380", VA = "0x18211A180")]
	protected NFMJIICBGIM(COBFIMKODNM DIPIIMIHCJA, HNKICPEMJJE MEMCJAOBNAO, DCJANAONGCG GDILPIBFDKF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FB90", Offset = "0x66EF90")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, bool ICDAFNPNAJK, string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2119B60", Offset = "0x2118D60", VA = "0x182119B60", Slot = "20")]
	protected virtual void KCEHONPEIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2119420", Offset = "0x2118620", VA = "0x182119420", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2119B00", Offset = "0x2118D00", VA = "0x182119B00", Slot = "13")]
	public void JIJBIJPLDIK(IMLGPLMMMCO GKKIPDKMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x211A120", Offset = "0x2119320", VA = "0x18211A120", Slot = "14")]
	public void OCBHPGBPFEL(JMOJBNDGLKA GKKIPDKMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2119570", Offset = "0x2118770", VA = "0x182119570", Slot = "15")]
	public void EGCPLMDDMDB(EOJMHAICGII GCBALOFJKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x21193C0", Offset = "0x21185C0", VA = "0x1821193C0", Slot = "22")]
	protected virtual void DKKJJDCKLEG(EOJMHAICGII GCBALOFJKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2119EB0", Offset = "0x21190B0", VA = "0x182119EB0")]
	private void MALEPGFBICF(bool JBFDNABELLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2119230", Offset = "0x2118430", VA = "0x182119230")]
	private void BJANILPODHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x21190A0", Offset = "0x21182A0", VA = "0x1821190A0")]
	private void AJCLHBAOKBC(in DLGHJKLMFNK HFCHBFMLOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2119040", Offset = "0x2118240", VA = "0x182119040", Slot = "16")]
	public void AEGBKFGAPOI(IMLGPLMMMCO GKKIPDKMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x2119E50", Offset = "0x2119050", VA = "0x182119E50", Slot = "17")]
	public void LMCIFNEHGPE(JMOJBNDGLKA GKKIPDKMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x9ED510", Offset = "0x9EC710", VA = "0x1809ED510")]
	internal void ADOFKEPOCFO(string JPKENOAMLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0xA2F290", Offset = "0xA2E490", VA = "0x180A2F290")]
	internal void DINDMHBMPIA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FBF0", Offset = "0x66EFF0")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class KFFFGLJNNOB : EKJCAOPFGGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly COBFIMKODNM BANGPOFOHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly ANLKOEPIABB CFMGFGIGHJM;

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x927D00", Offset = "0x926F00", VA = "0x180927D00")]
	public KFFFGLJNNOB(COBFIMKODNM DIPIIMIHCJA, ANLKOEPIABB NOBMGIPLEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2115FB0", Offset = "0x21151B0", VA = "0x182115FB0", Slot = "4")]
	public PINPMIPFEPJ<HKCMDKBIADA, NNLFHHJJMBM> LCKCJOMEENO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FE10", Offset = "0x66F210")] NNDHFAJHACK<JDAAGGKKBIF> ICCMHBOIOOM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FE70", Offset = "0x66F270")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FED0", Offset = "0x66F2D0")] HOGMOCHAFIO<GKDGBEBJKOB> FOIFMMOKJPC)
	{
		return default(PINPMIPFEPJ<HKCMDKBIADA, NNLFHHJJMBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2115CE0", Offset = "0x2114EE0", VA = "0x182115CE0", Slot = "5")]
	public PINPMIPFEPJ<HKCMDKBIADA, NNLFHHJJMBM> HKBIPODKFOC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FF30", Offset = "0x66F330")] NNDHFAJHACK<JDAAGGKKBIF> ICCMHBOIOOM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FF90", Offset = "0x66F390")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66FFF0", Offset = "0x66F3F0")] HOGMOCHAFIO<LMGKNPKGIBN> OJFIKOGMAOL)
	{
		return default(PINPMIPFEPJ<HKCMDKBIADA, NNLFHHJJMBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class IPDEAGDHNLK : EOPJPBLIIMP
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class GBBLMCKNKFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder<AJIGMFLDNLP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public IPDEAGDHNLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private LIKJHJPBELM <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670160", Offset = "0x66F560")]
		private TaskAwaiter<LIKJHJPBELM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GBBLMCKNKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x210C430", Offset = "0x210B630", VA = "0x18210C430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly COBFIMKODNM BANGPOFOHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670090", Offset = "0x66F490")]
	private IReadOnlyList<NNDHFAJHACK<NBLMGHLCPAM>> AGHLAIBBBEH;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public AJIGMFLDNLP? JHOAALADPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x210F360", Offset = "0x210E560", VA = "0x18210F360", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool AOMDAGCPPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x210EF60", Offset = "0x210E160", VA = "0x18210EF60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool CEHLMDICCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x210F710", Offset = "0x210E910", VA = "0x18210F710", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	internal IPDEAGDHNLK(COBFIMKODNM DIPIIMIHCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x210F210", Offset = "0x210E410", VA = "0x18210F210", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBBLMCKNKFI))]
	public Task<AJIGMFLDNLP> JBNEKIINDMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x210F420", Offset = "0x210E620", VA = "0x18210F420")]
	internal Dictionary<NNDHFAJHACK<ICMDIGALLLM>, Guid> NOFJHLEDPCF(IEnumerable<KHALLJGHNEA> NKPKDLMPIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x210ED10", Offset = "0x210DF10", VA = "0x18210ED10")]
	public PINPMIPFEPJ<CNNOEBGLDBB, NKHHFMGDFFF> ACPGBLFKEGO(in CNNOEBGLDBB LDKACPCILNH, IEnumerable<KHALLJGHNEA> JKPOBBNIMGM, int CCCELONFEOF)
	{
		return default(PINPMIPFEPJ<CNNOEBGLDBB, NKHHFMGDFFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x210EF10", Offset = "0x210E110", VA = "0x18210EF10")]
	internal static JMAAGPMELEJ BDLHIBPPOPN(MOBCPFABJOD NJMALOCLDMK, HNKICPEMJJE MEMCJAOBNAO)
	{
		return default(JMAAGPMELEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x210F3E0", Offset = "0x210E5E0", VA = "0x18210F3E0", Slot = "8")]
	private PINPMIPFEPJ<CNNOEBGLDBB, NKHHFMGDFFF> NMEPBJHLEIB(in CNNOEBGLDBB LDKACPCILNH, IEnumerable<KHALLJGHNEA> JKPOBBNIMGM, int CCCELONFEOF)
	{
		return default(PINPMIPFEPJ<CNNOEBGLDBB, NKHHFMGDFFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x210EFC0", Offset = "0x210E1C0", VA = "0x18210EFC0")]
	[CompilerGenerated]
	internal static JMAAGPMELEJ INDADNKJMHL(MOBCPFABJOD JNKGAKDAOCH, HNKICPEMJJE GFLBCEPJKMP)
	{
		return default(JMAAGPMELEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public interface LIKJHJPBELM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	GCNMPMNNNKF BGILODEECMA
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	OJAPJBMMFFA DKJADDNPIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	KFFFGLJNNOB JLOGGJMDPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	MNIGHBGDCJH IDIBGKKPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PIELJPAOOEI NPHMENHPKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public sealed class JPEMMDOPPKJ : DEHHNHEFJMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class CEKPGMOBBFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public COBFIMKODNM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public HNKICPEMJJE node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671E00", Offset = "0x671200")]
		public HOGMOCHAFIO<LACIKMLBFJD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CEKPGMOBBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2105520", Offset = "0x2104720", VA = "0x182105520")]
		internal CIKCKIFAAAH NPMKLAPENAD((int PortDescIndex, int PortIndex, IGNGFJDLHPN InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2105440", Offset = "0x2104640", VA = "0x182105440")]
		internal IBJMOEDIKJN CEPBEGOJIFF(BBGGKEPPIIF i, int idx)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class KNNLPGIJBBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671F10", Offset = "0x671310")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671F70", Offset = "0x671370")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private PBCNIAJDNKJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671FD0", Offset = "0x6713D0")]
		private (CGNIPIAGOLA PortDesc, int PortDescIndex)? <input>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CGNIPIAGOLA <portDesc>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private int <portDescIndex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KNNLPGIJBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6672600", Offset = "0x6671800", VA = "0x186672600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class DAMBCCPKMIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6720A0", Offset = "0x6714A0")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672100", Offset = "0x671500")]
		public HOGMOCHAFIO<ALBFEPNKGJA> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private PBCNIAJDNKJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DAMBCCPKMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x210A330", Offset = "0x2109530", VA = "0x18210A330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class FIENJAOGANJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672160", Offset = "0x671560")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6721C0", Offset = "0x6715C0")]
		public HOGMOCHAFIO<GOHONMAKFBH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private PBCNIAJDNKJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FIENJAOGANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6670F90", Offset = "0x6670190", VA = "0x186670F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class FNJAJHFNNCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672220", Offset = "0x671620")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672280", Offset = "0x671680")]
		public HOGMOCHAFIO<ALBFEPNKGJA> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6722E0", Offset = "0x6716E0")]
		public HOGMOCHAFIO<ALBFEPNKGJA> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private PBCNIAJDNKJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FNJAJHFNNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x66712E0", Offset = "0x66704E0", VA = "0x1866712E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class JFEHHHMHBFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672340", Offset = "0x671740")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6723A0", Offset = "0x6717A0")]
		public HOGMOCHAFIO<GOHONMAKFBH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672400", Offset = "0x671800")]
		public HOGMOCHAFIO<GOHONMAKFBH> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private PBCNIAJDNKJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public JFEHHHMHBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6671B50", Offset = "0x6670D50", VA = "0x186671B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class FFNCIFHLHBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672460", Offset = "0x671860")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6724C0", Offset = "0x6718C0")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private PBCNIAJDNKJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672520", Offset = "0x671920")]
		private (CGNIPIAGOLA PortDesc, int PortDescIndex)? <input>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private CGNIPIAGOLA <portDesc>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private int <portDescIndex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int <inputPortCount>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private int <portIndex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FFNCIFHLHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x210BD30", Offset = "0x210AF30", VA = "0x18210BD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class NABBMDCLMPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6725F0", Offset = "0x6719F0")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private PBCNIAJDNKJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public NABBMDCLMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6672FA0", Offset = "0x66721A0", VA = "0x186672FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class GINHPJHLGLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672650", Offset = "0x671A50")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6726B0", Offset = "0x671AB0")]
		public HOGMOCHAFIO<ALBFEPNKGJA> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private PBCNIAJDNKJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GINHPJHLGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x66717F0", Offset = "0x66709F0", VA = "0x1866717F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class AJOIIAMDKEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672710", Offset = "0x671B10")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672770", Offset = "0x671B70")]
		public HOGMOCHAFIO<GOHONMAKFBH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public JPEMMDOPPKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private PBCNIAJDNKJ <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public AJOIIAMDKEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x21041A0", Offset = "0x21033A0", VA = "0x1821041A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly bool ENDPILAEICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly COBFIMKODNM BANGPOFOHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly bool EEPIBOPKGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6701C0", Offset = "0x66F5C0")]
	private KHCMLBEHALN<GKDGBEBJKOB, CIKCKIFAAAH> CEOGBLMPHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670220", Offset = "0x66F620")]
	private KHCMLBEHALN<GKDGBEBJKOB, ELBIBNLNAKO> IOGLAFBOIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly HNKICPEMJJE OKNCEHDAGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670280", Offset = "0x66F680")]
	private KHCMLBEHALN<LMGKNPKGIBN, IBJMOEDIKJN> POBJFNLPNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6702E0", Offset = "0x66F6E0")]
	private KHCMLBEHALN<LMGKNPKGIBN, DKCJPOEDOGH> NHEEJKCGDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private string? CNCNEAHGFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly LLBNMPGAEBJ DEOMKDAGJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670340", Offset = "0x66F740")]
	private HOGMOCHAFIO<LACIKMLBFJD> HIOIHFBHCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action? AJFFLDCFJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action? BIJKGOJPFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[CompilerGenerated]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670660", Offset = "0x66FA60")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<HOGMOCHAFIO<GKDGBEBJKOB>> EBBHEIOMHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[CompilerGenerated]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670860", Offset = "0x66FC60")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<HOGMOCHAFIO<LMGKNPKGIBN>> CBPOMNAKHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DEHHNHEFJMC.JEIKOJDDKLK? DKPJPMIMJMM;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool PICMNCKBJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x21129A0", Offset = "0x2111BA0", VA = "0x1821129A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool IFEMHJMPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2113940", Offset = "0x2112B40", VA = "0x182113940", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool FNBODACNFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2115360", Offset = "0x2114560", VA = "0x182115360", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671900", Offset = "0x670D00")]
	public NNDHFAJHACK<ICMDIGALLLM> NAHPHGJADGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2115190", Offset = "0x2114390", VA = "0x182115190", Slot = "7")]
		get
		{
			return default(NNDHFAJHACK<ICMDIGALLLM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool BGLIBFABHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2110640", Offset = "0x210F840", VA = "0x182110640", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671970", Offset = "0x670D70")]
	public KHCMLBEHALN<GKDGBEBJKOB, ELBIBNLNAKO> HDGBOMMAILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "9")]
		get
		{
			return default(KHCMLBEHALN<GKDGBEBJKOB, ELBIBNLNAKO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2112320", Offset = "0x2111520", VA = "0x182112320", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6719D0", Offset = "0x670DD0")]
	public NNDHFAJHACK<JDAAGGKKBIF> EKMCEGABMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2115340", Offset = "0x2114540", VA = "0x182115340", Slot = "11")]
		get
		{
			return default(NNDHFAJHACK<JDAAGGKKBIF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671A40", Offset = "0x670E40")]
	public KHCMLBEHALN<LMGKNPKGIBN, DKCJPOEDOGH> FPBPMIPLKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20", Slot = "12")]
		get
		{
			return default(KHCMLBEHALN<LMGKNPKGIBN, DKCJPOEDOGH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671AA0", Offset = "0x670EA0")]
	public HOGMOCHAFIO<LACIKMLBFJD> JNECGBLOJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x95D1F0", Offset = "0x95C3F0", VA = "0x18095D1F0", Slot = "13")]
		get
		{
			return default(HOGMOCHAFIO<LACIKMLBFJD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action KGAOHNHPLME
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2113A20", Offset = "0x2112C20", VA = "0x182113A20", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2112900", Offset = "0x2111B00", VA = "0x182112900", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<HOGMOCHAFIO<GKDGBEBJKOB>, HOGMOCHAFIO<GKDGBEBJKOB>> MMAGDIHAIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2114540", Offset = "0x2113740", VA = "0x182114540", Slot = "16")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6709A0", Offset = "0x66FDA0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x21147E0", Offset = "0x21139E0", VA = "0x1821147E0", Slot = "17")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670A00", Offset = "0x66FE00")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<HOGMOCHAFIO<LMGKNPKGIBN>, HOGMOCHAFIO<LMGKNPKGIBN>> MLNCDEBHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2113360", Offset = "0x2112560", VA = "0x182113360", Slot = "18")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670A60", Offset = "0x66FE60")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x21154C0", Offset = "0x21146C0", VA = "0x1821154C0", Slot = "19")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670AC0", Offset = "0x66FEC0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<HOGMOCHAFIO<GKDGBEBJKOB>, ELBIBNLNAKO> ADLOHKDDAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2113C40", Offset = "0x2112E40", VA = "0x182113C40", Slot = "20")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670B20", Offset = "0x66FF20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2114880", Offset = "0x2113A80", VA = "0x182114880", Slot = "21")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670B80", Offset = "0x66FF80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<HOGMOCHAFIO<GKDGBEBJKOB>> JHHKBKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x21121E0", Offset = "0x21113E0", VA = "0x1821121E0", Slot = "22")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670BE0", Offset = "0x66FFE0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2113EF0", Offset = "0x21130F0", VA = "0x182113EF0", Slot = "23")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670C40", Offset = "0x670040")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<HOGMOCHAFIO<GKDGBEBJKOB>, ELBIBNLNAKO> DDCCODONPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2114740", Offset = "0x2113940", VA = "0x182114740", Slot = "24")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670CA0", Offset = "0x6700A0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2115420", Offset = "0x2114620", VA = "0x182115420", Slot = "25")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670D00", Offset = "0x670100")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<HOGMOCHAFIO<LMGKNPKGIBN>, DKCJPOEDOGH> EHABFBCIOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2112280", Offset = "0x2111480", VA = "0x182112280", Slot = "26")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670D60", Offset = "0x670160")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x21113F0", Offset = "0x21105F0", VA = "0x1821113F0", Slot = "27")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670DC0", Offset = "0x6701C0")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HOGMOCHAFIO<LMGKNPKGIBN>> FHGABCPEGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2114A90", Offset = "0x2113C90", VA = "0x182114A90", Slot = "28")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670E20", Offset = "0x670220")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x21105A0", Offset = "0x210F7A0", VA = "0x1821105A0", Slot = "29")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670E80", Offset = "0x670280")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HOGMOCHAFIO<LMGKNPKGIBN>, DKCJPOEDOGH> FIAPOLNLOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x21103B0", Offset = "0x210F5B0", VA = "0x1821103B0", Slot = "30")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670EE0", Offset = "0x6702E0")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2113CE0", Offset = "0x2112EE0", VA = "0x182113CE0", Slot = "31")]
		[CompilerGenerated]
		[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670F40", Offset = "0x670340")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2115980", Offset = "0x2114B80", VA = "0x182115980")]
	private JPEMMDOPPKJ(bool ICDAFNPNAJK, COBFIMKODNM DIPIIMIHCJA, bool GLGHENONPPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x670FA0", Offset = "0x6703A0")] KHCMLBEHALN<GKDGBEBJKOB, CIKCKIFAAAH> NBHHMNMEHIO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671000", Offset = "0x670400")] KHCMLBEHALN<GKDGBEBJKOB, ELBIBNLNAKO> DMJGJOAMEHN, HNKICPEMJJE MEMCJAOBNAO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671060", Offset = "0x670460")] KHCMLBEHALN<LMGKNPKGIBN, IBJMOEDIKJN> NCGKJLNBIDN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6710C0", Offset = "0x6704C0")] KHCMLBEHALN<LMGKNPKGIBN, DKCJPOEDOGH> DBEKJHKKGFK, string? ONHGCHMBNMK, LLBNMPGAEBJ LFCEPJFCBKA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671120", Offset = "0x670520")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2113400", Offset = "0x2112600", VA = "0x182113400")]
	public static JPEMMDOPPKJ HBHNAKPOBBF(bool ICDAFNPNAJK, COBFIMKODNM DIPIIMIHCJA, bool GLGHENONPPL, HNKICPEMJJE MEMCJAOBNAO, LLBNMPGAEBJ LFCEPJFCBKA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671180", Offset = "0x670580")] HOGMOCHAFIO<LACIKMLBFJD> OBOMAALHHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2113F90", Offset = "0x2113190", VA = "0x182113F90")]
	private void KCEHONPEIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2111820", Offset = "0x2110A20", VA = "0x182111820", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2111110", Offset = "0x2110310", VA = "0x182111110", Slot = "32")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KNNLPGIJBBL))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> DFKHIOHBFDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2112F90", Offset = "0x2112190", VA = "0x182112F90")]
	private (CGNIPIAGOLA, int)? GLJLLFIHEDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2114920", Offset = "0x2113B20", VA = "0x182114920")]
	private void LNJIMBEFEAI(int PCBAOIPOFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x98ADC0", Offset = "0x989FC0", VA = "0x18098ADC0")]
	private void BOCNBAJMBIH(int PCBAOIPOFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2112350", Offset = "0x2111550", VA = "0x182112350")]
	private void FDKBBCJIJMH(int PCLFODBKPIM, int OACNOOAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x15762C0", Offset = "0x15754C0", VA = "0x1815762C0")]
	private void PGEGDPKOFLN(int PCBAOIPOFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2110B60", Offset = "0x210FD60", VA = "0x182110B60")]
	private void DBCKAHEEMHI(int PCBAOIPOFHI, int LDMLEIPCBPO, IGNGFJDLHPN DJFHFDKDHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2112A60", Offset = "0x2111C60", VA = "0x182112A60")]
	private void GBJHBBFIFDH(int JBFDNABELLI, int LDMLEIPCBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2111790", Offset = "0x2110990", VA = "0x182111790")]
	private void DODPKMKJCAA(int JBFDNABELLI, int LDMLEIPCBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x21106D0", Offset = "0x210F8D0", VA = "0x1821106D0")]
	private void CFHENOMEANK(int PCBAOIPOFHI, int LDMLEIPCBPO, IGNGFJDLHPN DJFHFDKDHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x21131F0", Offset = "0x21123F0", VA = "0x1821131F0")]
	private void GMFONEJPBNL(int PCBAOIPOFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x98ADC0", Offset = "0x989FC0", VA = "0x18098ADC0")]
	private void ACAJGKEKECM(int PCBAOIPOFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2115560", Offset = "0x2114760", VA = "0x182115560")]
	private void PNDIMKKHHKH(int PCLFODBKPIM, int OACNOOAIBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x15762C0", Offset = "0x15754C0", VA = "0x1815762C0")]
	private void BNCCNMCPKJB(int PCBAOIPOFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2114B30", Offset = "0x2113D30", VA = "0x182114B30")]
	private void MMOBHMDNBKD(int PCBAOIPOFHI, int LDMLEIPCBPO, BBGGKEPPIIF DJFHFDKDHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2113990", Offset = "0x2112B90", VA = "0x182113990")]
	private void IBLEMFIDLDF(int JBFDNABELLI, int LDMLEIPCBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2115100", Offset = "0x2114300", VA = "0x182115100")]
	private void NDCGKIBGMBI(int JBFDNABELLI, int LDMLEIPCBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2112AF0", Offset = "0x2111CF0", VA = "0x182112AF0")]
	private void GFENDLCKABE(int PCBAOIPOFHI, int LDMLEIPCBPO, BBGGKEPPIIF DJFHFDKDHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2112080", Offset = "0x2111280", VA = "0x182112080", Slot = "33")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DAMBCCPKMIF))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> EJKNKIFCPFN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6712B0", Offset = "0x6706B0")] HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x21145E0", Offset = "0x21137E0", VA = "0x1821145E0", Slot = "34")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FIENJAOGANJ))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> KFBNLINHGDK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671370", Offset = "0x670770")] HOGMOCHAFIO<GOHONMAKFBH> PKDNKNMCOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x21151C0", Offset = "0x21143C0", VA = "0x1821151C0", Slot = "35")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FNJAJHFNNCP))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> NMPPJBNIGDD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671440", Offset = "0x670840")] HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6714A0", Offset = "0x6708A0")] HOGMOCHAFIO<ALBFEPNKGJA> DDFKKOGFCOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2113AC0", Offset = "0x2112CC0", VA = "0x182113AC0", Slot = "36")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFEHHHMHBFI))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> IKDNPCECHPB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671570", Offset = "0x670970")] HOGMOCHAFIO<GOHONMAKFBH> PKDNKNMCOMB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6715D0", Offset = "0x6709D0")] HOGMOCHAFIO<GOHONMAKFBH> DDFKKOGFCOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2110450", Offset = "0x210F650", VA = "0x182110450", Slot = "37")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFNCIFHLHBM))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> BKIDCGEMGHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2113D80", Offset = "0x2112F80", VA = "0x182113D80", Slot = "38")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NABBMDCLMPO))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> JDPPGCIFCPC(string MHAMHEMGGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x2111260", Offset = "0x2110460", VA = "0x182111260", Slot = "39")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GINHPJHLGLH))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> DGJGKOOFGEN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671770", Offset = "0x670B70")] HOGMOCHAFIO<ALBFEPNKGJA> IAEFNJNFKHM, string JPKENOAMLIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x2112770", Offset = "0x2111970", VA = "0x182112770", Slot = "40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AJOIIAMDKEN))]
	public Task<PINPMIPFEPJ<CKDLGNFJNCJ, OKKDIBLBODL>> FEBKEKGLJON([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x671840", Offset = "0x670C40")] HOGMOCHAFIO<GOHONMAKFBH> PKDNKNMCOMB, string JPKENOAMLIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2111490", Offset = "0x2110690", VA = "0x182111490")]
	internal void DINDMHBMPIA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6718A0", Offset = "0x670CA0")] HOGMOCHAFIO<LACIKMLBFJD> NABCGCEIEGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct KHAKKAALHOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6727D0", Offset = "0x671BD0")]
	internal JLFNJGGFBPP<NNBCJKEDGLA, AKEADGDIFCI, EKMMNCOHMFK> KAMKGBFKIKA;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2115A60", Offset = "0x2114C60", VA = "0x182115A60")]
	private KHAKKAALHOE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672830", Offset = "0x671C30")] in JLFNJGGFBPP<NNBCJKEDGLA, AKEADGDIFCI, EKMMNCOHMFK> JPKNCEKFDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2116280", Offset = "0x2115480", VA = "0x182116280")]
	public static KHAKKAALHOE HBHNAKPOBBF()
	{
		return default(KHAKKAALHOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class APLDEHPMLIF
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static JLFNJGGFBPP<NNBCJKEDGLA, AKEADGDIFCI, EKMMNCOHMFK> MBAEFAJFFMJ(this ref KHAKKAALHOE KPIHKJNPOFH)
	{
		return default(JLFNJGGFBPP<NNBCJKEDGLA, AKEADGDIFCI, EKMMNCOHMFK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct HMFFMOAEBJC : BKGPNLAIPGC.KIEJFHNGPLJ<AKEADGDIFCI, CKDLGNFJNCJ>
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x210D3A0", Offset = "0x210C5A0", VA = "0x18210D3A0", Slot = "4")]
	public int IMPKAMNGCKB(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x210D170", Offset = "0x210C370", VA = "0x18210D170", Slot = "5")]
	public AKEADGDIFCI DLEDKLJFELE(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x210D2F0", Offset = "0x210C4F0", VA = "0x18210D2F0", Slot = "6")]
	public AKEADGDIFCI IMHNOICLBEP(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x210D3C0", Offset = "0x210C5C0", VA = "0x18210D3C0", Slot = "7")]
	public IReadOnlyList<AKEADGDIFCI> JFGHBELMJKI(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x210D4C0", Offset = "0x210C6C0", VA = "0x18210D4C0", Slot = "8")]
	public AKEADGDIFCI[] NOMPODNJBPL(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK, int BLDBKCNEHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x210D140", Offset = "0x210C340", VA = "0x18210D140", Slot = "9")]
	public bool BGMDIPMOHCB(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x210D460", Offset = "0x210C660", VA = "0x18210D460", Slot = "10")]
	public bool JJEIAKBENON(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x210D490", Offset = "0x210C690", VA = "0x18210D490", Slot = "11")]
	public bool LPENOGNJALB(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x210D110", Offset = "0x210C310", VA = "0x18210D110", Slot = "12")]
	public bool BCDPEAPHBAJ(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x210D290", Offset = "0x210C490", VA = "0x18210D290", Slot = "13")]
	public bool GMOINHMEOAP(CKDLGNFJNCJ BEFBPKJJMDP, AKEADGDIFCI AMEKOPCKNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x210D2C0", Offset = "0x210C4C0", VA = "0x18210D2C0", Slot = "14")]
	public bool HLFAGGGJEFF(CKDLGNFJNCJ JBFDNABELLI, AKEADGDIFCI AMEKOPCKNIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public abstract class PPNOBDNEPMI : GJCNAAJHMHF
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public OIBPAHNOGOJ.ADNFENEBIML HBNJOOAPOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x211EEE0", Offset = "0x211E0E0", VA = "0x18211EEE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public abstract IIAHACKKGJM.AOAGJCBPJMC GGBFGOIDDKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public abstract COBFIMKODNM.DINMPBGALLF HHIDBBKPKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public abstract FMGNBJLPNPP.GOBODOEJJEM EJFNOEIKBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public PMLHBCKFJGO.DFBLKPGNGBD<IFHFCBJLIGK, AKEADGDIFCI, COBFIMKODNM> IHOCCCAKIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x211EF40", Offset = "0x211E140", VA = "0x18211EF40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public abstract PBCNIAJDNKJ FPMDHLPAOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract MEFEINIAOBL LOKJINBCIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public abstract DDHNMHAMLGE DEPAMGPBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public abstract NIADHPDMBEE FDKOGECIFON
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public abstract NMPKAKJAEDO HNAIGNLKOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	protected PPNOBDNEPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public sealed class ELNDFNLODBH : DECKFMCFPMG
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class PPANCGKBEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6729C0", Offset = "0x671DC0")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<object, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public AKEADGDIFCI action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public ELNDFNLODBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public PPANCGKBEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x211ECE0", Offset = "0x211DEE0", VA = "0x18211ECE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class MMNFMJLPEEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672B40", Offset = "0x671F40")]
		public AsyncTaskMethodBuilder<PINPMIPFEPJ<OGOJDCIJJPH, OKKDIBLBODL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672C00", Offset = "0x672000")]
		public IReadOnlyList<AKEADGDIFCI> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public ELNDFNLODBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672C60", Offset = "0x672060")]
		private PINPMIPFEPJ<object, OKKDIBLBODL> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672CC0", Offset = "0x6720C0")]
		private TaskAwaiter<PINPMIPFEPJ<object, OKKDIBLBODL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MMNFMJLPEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x21189F0", Offset = "0x2117BF0", VA = "0x1821189F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly KPDEPJCEJAK DMGDKEHBMMF;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public ELNDFNLODBH(KPDEPJCEJAK BFEBKHPPGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x210B9B0", Offset = "0x210ABB0", VA = "0x18210B9B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PPANCGKBEAF))]
	private Task<PINPMIPFEPJ<object, OKKDIBLBODL>> FIBNLDBJBLB(AKEADGDIFCI AMEKOPCKNIK, bool OOMDCBCHGMH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x210BB40", Offset = "0x210AD40", VA = "0x18210BB40", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MMNFMJLPEEL))]
	public Task<PINPMIPFEPJ<OGOJDCIJJPH, OKKDIBLBODL>> KMMJOLMEJMN(IReadOnlyList<AKEADGDIFCI> CHGGJLGDPLE, bool OOMDCBCHGMH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct ECFAPLOAHIC : NGHACIKNPPD.LAMLMLNKECO<CPMKBDJMJNO, AKEADGDIFCI>
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBF340", VA = "0x180CC0140")]
	public int JOGNAGBKFCO(in CPMKBDJMJNO HDKCDDJGBDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x210ACE0", Offset = "0x2109EE0", VA = "0x18210ACE0", Slot = "5")]
	public AKEADGDIFCI PPICIPPCACC(CPMKBDJMJNO[] MIKMHCPOKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBF340", VA = "0x180CC0140", Slot = "4")]
	private int JPHHLGLFJCE(in CPMKBDJMJNO HDKCDDJGBDF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct EKMMNCOHMFK : ELFIKDKJBEK.DFNLIFPGLPJ<NNBCJKEDGLA, AKEADGDIFCI>
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x210B7E0", Offset = "0x210A9E0", VA = "0x18210B7E0", Slot = "5")]
	public AKEADGDIFCI JJEFOOONFBJ(NNBCJKEDGLA[] BFLPPDJANFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBF340", VA = "0x180CC0140")]
	public int GANKKLMFEIH(in NNBCJKEDGLA HDKCDDJGBDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xCC0140", Offset = "0xCBF340", VA = "0x180CC0140", Slot = "4")]
	private int GMMKAFPDDNL(in NNBCJKEDGLA HINDKFBEDPE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct OLBIINKLMDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672EA0", Offset = "0x6722A0")]
	internal LCMCKJJKHEH<CPMKBDJMJNO, AKEADGDIFCI, ECFAPLOAHIC> KAMKGBFKIKA;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2115A60", Offset = "0x2114C60", VA = "0x182115A60")]
	private OLBIINKLMDO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x672F60", Offset = "0x672360")] in LCMCKJJKHEH<CPMKBDJMJNO, AKEADGDIFCI, ECFAPLOAHIC> PLOKJNJFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x211CA10", Offset = "0x211BC10", VA = "0x18211CA10")]
	public static OLBIINKLMDO HBHNAKPOBBF()
	{
		return default(OLBIINKLMDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class HNIMMDGNNFL
{
	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90")]
	public static LCMCKJJKHEH<CPMKBDJMJNO, AKEADGDIFCI, ECFAPLOAHIC> MBAEFAJFFMJ(this ref OLBIINKLMDO KPIHKJNPOFH)
	{
		return default(LCMCKJJKHEH<CPMKBDJMJNO, AKEADGDIFCI, ECFAPLOAHIC>);
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
